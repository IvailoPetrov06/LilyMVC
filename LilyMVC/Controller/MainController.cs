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
        private Money model;
        private MainView view;

        public MainController()
        {
            model = new Money();
            view = new MainView();
        }

        public void Run()
        {
            double totalSavings = 0;
            double toyMoney = 0;

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

            totalSavings += toyMoney;
            model.TotalSavings = totalSavings;
            view.ShowResult(model.TotalSavings, model.WashingMachinePrice);
        }
    }
}
