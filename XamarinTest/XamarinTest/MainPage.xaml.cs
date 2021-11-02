using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Diagnostics;
using System.Reflection;

namespace XamarinTest
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

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Klikač", MethodBase.GetCurrentMethod().Name, "Zavřít");
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            DisplayAlert("Časovač", Convert.ToString(Application.Current.Properties["FirstRun"]), "Zavřít");
        }

        private void ContentPage_Appearing(object sender, EventArgs e)
        {
            Application.Current.Properties.Add("FirstRun", DateTime.Now);
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Entry entry = new Entry() { Text = "Zadej jméno" };
            MainStackLayout.Children.Add(entry);
        }
    }
}
