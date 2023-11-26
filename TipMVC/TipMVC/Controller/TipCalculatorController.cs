using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TipMVC.Model;
using TipMVC.View;

namespace TipMVC.Controller
{
    class TipCalculatorController
    {
        private Tip tip;
        private Display display;


        public TipCalculatorController()
        {
            NewMethod();
        }

        private void NewMethod()
        {
            display = new Display();
            tip = new Tip(display.Amount, display.Percent);
            display.TipAmount = tip.CalculateTip();
            display.Total = tip.CalculateTotal();
            display.ShowTipAndTotal();
        }
    }
}
