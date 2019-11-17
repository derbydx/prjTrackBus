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
        // para declarar y agregar binding al label 
        public string Recuperar { get; set; } = Constantes.RecuperarPass;
        public string Correo { get; set; } = Constantes.Correoe;


        public MainPage()
        {
            InitializeComponent();

            //binding del label 
            BindingContext = this;
        }

        private async void OnButtonRegister(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Registro());
        }
        private void Iniciar_clicked(object o, EventArgs e)
        {
            Application.Current.MainPage = new PaginaTab();
        }
    }
}
