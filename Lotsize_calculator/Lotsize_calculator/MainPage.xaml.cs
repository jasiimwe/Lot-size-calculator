using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lotsize_calculator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Process_inputs_Clicked(object sender, EventArgs e)
        {
            int x = Int32.Parse(acc_size.Text);
            int y = Int32.Parse(percentange_risk.Text);

            double per_risk = calculate_percentange_risk(x, y);
            double sl_pips = Int32.Parse(stop_loss.Text);


            double amnt_per_pip = per_risk / sl_pips;

            lot_size.Text = (Math.Round((amnt_per_pip / 10), 2)).ToString();

        }

        public double calculate_percentange_risk(int acc_size, double risk)
        {
            //claculate percentage risk
            
            return acc_size * (risk / 100);

        }

        
    }
}
