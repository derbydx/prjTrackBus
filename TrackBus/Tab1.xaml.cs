using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TrackBus
{
    public partial class Tab1 : ContentPage
    {
        List<Autobus> Datos;
        public Tab1()
        {

            InitializeComponent();
            Datos = new List<Autobus>();
            Datos.Add(new Autobus()


            {
                Imagen = "autobus32.png",
                Nombre = "Ruta 1 Cotui-Fantino",
                Chofer = "Juan Perez"
            });

            Datos.Add(new Autobus()
            {
                Imagen = "autobus32.png",
                Nombre = "Ruta 2 Cotui-Maimon",
                Chofer = "Miguel Hernandez"
            });

            Datos.Add(new Autobus()
            {
                Imagen = "autobus32.png",
                Nombre = "Ruta 3 Cotui-Cevicos",
                Chofer = "Jefferson Smith"
            });
            ListaBus.ItemsSource = Datos;

        }

    }


    //1- Crear la clase autobus 
    public class Autobus
    {
        public string Imagen { get; set; }
        public string Nombre { get; set; }
        public string Chofer { get; set; }


    }



}

