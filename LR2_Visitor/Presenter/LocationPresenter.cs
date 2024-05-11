using LR2_Visitor.Model;
using LR2_Visitor.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2_Visitor.Presenter
{
    // Класс Presenter управляет взаимодействием между моделью и видом
    class LocationPresenter
    {
        // Массив локаций, по которым может путешествовать герой
        private ILocation[] locations = new ILocation[] {
            new Forest(), new Desert(), new Island(), new Cave(), new Mountain()

    };
        private ConsoleView view = new ConsoleView();
        private HeroBuilder heroBuilder = new HeroBuilder();
        private Hero hero;

        // Конструктор Presenter'а, который создает и настраивает героя
        public LocationPresenter()
        {
            // Инициализация и настройка героя с помощью Builder паттерна
            hero = heroBuilder.SetName("Adventurous Alice")
                              .SetHealth(120)
                              .SetStrength(15)
                              .Build();
        }

        // Метод Run запускает основной цикл взаимодействия с пользователем
        public void Run()
        {
            while (true)
            {
                // Получаем выбор пользователя из консоли
                int choice = view.GetUserChoice();
                if (choice == 0)
                {
                    break;
                }
                else if (choice == 6)
                {
                    CustomizeHero();
                }
                else if (choice > 0 && choice <= 5)
                {
                    locations[choice - 1].Accept(hero);
                }
                else
                {
                    view.ShowMessage("Invalid choice. Please enter a number from 0 to 6.");
                }
                Console.WriteLine();
            }
        }

        // Метод для настройки героя через консольный интерфейс
        private void CustomizeHero()
        {
            // Запрашиваем новое имя героя
            string name = view.GetStringValue("Enter hero's new name: ");
            // Запрашиваем новый уровень здоровья
            int health = view.GetIntValue("Enter hero's new health: ");
            // Запрашиваем новую силу героя
            int strength = view.GetIntValue("Enter hero's new strength: ");

            // Создаем новую настройку героя с помощью Builder паттерна
            hero = heroBuilder.SetName(name)
                              .SetHealth(health)
                              .SetStrength(strength)
                              .Build();
            // Сообщаем об успешной настройке героя
            view.ShowMessage("Hero customized successfully.");
        }
    }
}
