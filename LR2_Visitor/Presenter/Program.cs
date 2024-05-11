using LR2_Visitor.Model;

namespace LR2_Visitor.Presenter
{
    class Program
    {
        static void Main(string[] args)
        {
            var presenter = new LocationPresenter();
            presenter.Run();
        }
    }
}