using LilyMVC.Controller;
using System;

namespace LilyMVC
{
    class Program
    {
        static void Main(string[] args)
        {
            MainController controller = new MainController();
            controller.Run();
        }
    }
}
