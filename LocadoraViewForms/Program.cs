using LocadoraViewForms.Views;

namespace LocadoraViewForms
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Menu());
        }
    }
}