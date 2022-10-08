using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BMI_Calculator
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ResultPage : ContentPage
    {
        private double result;
        private string BMIRange;

        public ResultPage()
        {
            InitializeComponent();
            Height.Text = $"Your Height is {Application.Current.Properties["Height"].ToString()} cm";
            Weight.Text= $"Your Weight is {Application.Current.Properties["Weight"].ToString()} kg";
            calculateBMI();
            ResultBMI.Text = $"Your BMI Value is: {result.ToString()}";
            BMIValue.Text = BMIRange;
            
        }
        public void calculateBMI()
        {
            double height1 = (double)Application.Current.Properties["Height"];
            double weight1 = (double)Application.Current.Properties["Weight"];
            result = Math.Round( (weight1) / (Math.Pow(height1*0.01,2)),3);
            if(result<=18.5)
            {
                BMIRange = "UnderWeight";
            }
            else if(result> 18.5 && result<24.9)
            {
                BMIRange = "Normal";
            }
            else if (result > 25.0 && result < 29.0)
            {
                BMIRange = "Over Weight";
            }
            else
            {
                BMIRange = "Obese";
            }
        }

    }
}