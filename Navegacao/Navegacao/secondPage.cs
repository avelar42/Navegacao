using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace Navegacao
{
    public class secondPage : ContentPage
    {
        public secondPage()
        {
            Title = "Navegação Hierarquica";
            Label homeLabel = new Label
            {
                Text = "Segunda Pagina",
                FontSize = 40,
            };

            Button button = new Button { Text = "Mostre o alerta" };
            button.Clicked += async (sender, e) =>
            {
                Boolean resposta = await DisplayAlert("Olá", "Tem certeza que vai fazer essa ação?", "Sim", "Não");
            };
            Button button2 = new Button { Text = "Mostre ActionSheet" };
            button2.Clicked += async (sender, e) =>
            {
                string action = await DisplayActionSheet("Options", "Cancel", null, "Here", "There", "Everywhere");
                homeLabel.Text = "Action is: " + action;
            };


            var stackLayout = new StackLayout
            {
                Children = { homeLabel, button, button2 }
            };

           
            this.Content = stackLayout;

        }
    }
}
