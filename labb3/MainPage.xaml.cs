using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace labb3
{
	// Learn more about making custom code visible in the Xamarin.Forms previewer
	// by visiting https://aka.ms/xamarinforms-previewer
	[DesignTimeVisible(false)]
	public partial class MainPage : ContentPage
	{

		public MainPage()
		{
			InitializeComponent();

		}

        private void OnTopClicked(object sender, EventArgs args)
        {
            if (UserInput.Text != null)
            {
                Belopp.Text = UserInput.Text + " SEK";
                Moms.Text = TwentyFivePercent.Text;
                double sum = double.Parse(UserInput.Text);

                var calculateValue = sum * 0.75;
                UtBelopp.Text = calculateValue.ToString() + " SEK";

                var calculateVAT = sum * 0.25;
                UtMoms.Text = calculateVAT.ToString() + " SEK";
            }
        }

		private void OnMiddleClicked(object sender, EventArgs args)
		{
			if (UserInput.Text != null)
			{
				Belopp.Text = UserInput.Text + " SEK";
				Moms.Text = TwelvePercent.Text;
				double amount = double.Parse(UserInput.Text);

				var calculateValue = amount * 0.88;
				UtBelopp.Text = calculateValue.ToString() + " SEK";

				var calculateVAT = amount * 0.12;
				UtMoms.Text = calculateVAT.ToString() + " SEK";
			}
		}

        private void OnBottomClicked(object sender, EventArgs args)
        {
            if (UserInput.Text != null)
            {
                Belopp.Text = UserInput.Text + " SEK";
                Moms.Text = EightPercent.Text;
                double amount = double.Parse(UserInput.Text);

                var calculateValue = amount * 0.92;
                UtBelopp.Text = calculateValue.ToString() + " SEK";

                var caclulateVAT = amount * 0.08;
                UtMoms.Text = caclulateVAT.ToString() + " SEK";
            }
        }
    }
}