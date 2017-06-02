using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace Navegacao
{
    public class FirstPage : ContentPage
    {
        public FirstPage()
        {
            var headerLabel = new Label
            {
                Text = "Primeira Pagina",
                FontSize = 40
            };
            var desclabel = new Label
            {
                Text = "1st PAGE",
                FontSize = 20
            };
            Content = new StackLayout
            {
                Children = {headerLabel, desclabel} 
            };
        }
    }
}
