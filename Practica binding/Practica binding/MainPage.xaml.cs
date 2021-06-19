using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Practica_binding
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void BtnEnviar_Clicked(object sender, EventArgs e)
        {
            var nuevaPagina = new SegundPagina();
            nuevaPagina.BindingContext = new {Nombre = TxtNombre.Text,
            Apellido = TxtApellido.Text, Edad =TxtEdad.Text, Correo =TxtCorreo.Text};
            await Navigation.PushAsync(nuevaPagina);
            
        }

    }
}
