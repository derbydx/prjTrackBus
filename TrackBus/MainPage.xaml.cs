using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TrackBus
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
        //public void OnButtonRegister(object o, EventArgs e)
        //{
        //  Navigation.PushModalAsync(new Registro());
        //}
        private async void OnButtonRegister(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Registro());
        }
    }
}
