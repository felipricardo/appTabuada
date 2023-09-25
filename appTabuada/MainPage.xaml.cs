using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace appTabuada
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btCalcular_Clicked(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(Numero.Text);
            List<String> items = new List<String>();
            String texto = "";
            for (int i = 0; i < 11; i++)
            {
                texto = n + " X " + i + " = " + (n * i);
                items.Add(texto);
            }
            tabuada.ItemsSource = items;
        }
    }
}
