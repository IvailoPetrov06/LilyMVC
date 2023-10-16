using LilyMVC.Model;
using LilyMVC.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LilyMVC.Controller
{
    public class MainController
    {

        public void Run()
        {
            Money model = new Money();
            Console.WriteLine($"Enter the age:");
            model.Age = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter the pricr on washing:");
            model.WashingMachinePrice = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter the price on toy:");
            model.ToyPrice = int.Parse(Console.ReadLine());
            double totalSavings = 0;
            
            for (int age = 1; age <= model.Age; age++)
            {
                if (age % 2 == 0)
                {
                    totalSavings += (age / 2) * 10.0 - 1.0;
                    toyMoney += model.ToyPrice;
                }
                else
                {
                    toyMoney += model.ToyPrice;
                }
            }
            model.TotalSavings = totalSavings;
            MainView view = new MainView();
            view.ShowResult(model.TotalSavings, model.WashingMachinePrice);
        }
    }
}
