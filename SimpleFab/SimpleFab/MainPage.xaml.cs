using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SimpleFab
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        public void OnFabMenuClick(object sender, EventArgs args)
        {
            Application.Current.MainPage.DisplayAlert("Dialog", "Hello", "OK");

        }
    }
}
