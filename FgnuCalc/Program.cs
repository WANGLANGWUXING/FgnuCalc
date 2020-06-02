using Fgnu.Views;
using System;
using System.Windows;

namespace FgnuCalc
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            CalculatorView view = new CalculatorView();
            Application app = new Application();
            app.Run(view);
        }
    }
}
