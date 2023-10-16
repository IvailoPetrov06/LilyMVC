using LilyMVC.Controller;
using System;

namespace LilyMVC
{
    public class Program
    {
        static void Main(string[] args)
        {
            MainController controller = new MainController();
            controller.Run();
        }
    }
}
