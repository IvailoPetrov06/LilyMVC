using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LilyMVC.View
{
    public class MainView
    {
        public void ShowResult(double totalSavings, double washingMachinePrice)
        {
            if (totalSavings >= washingMachinePrice)
            {
                Console.WriteLine($"Да! {totalSavings - washingMachinePrice:f2}");
            }
            else
            {
                Console.WriteLine($"Не! {washingMachinePrice - totalSavings:f2}");
            }
        }
    }
}
