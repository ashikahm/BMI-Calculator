using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BMI_Calculator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ResultPage());

        }

        private void SlidderHeight_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            double height = (sender as Slider).Value;
            Application.Current.Properties["Height"]=height;

        }

        private void StepperWeight_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            double weight = (sender as Stepper).Value;
            Application.Current.Properties["Weight"] = weight;

        }

    }
}
