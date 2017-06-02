using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace Navegacao
{
    public class HomePage : ContentPage
    {
        Button homeButton;
        public HomePage()
        {
            Title = "Navegação hierarquica";
            Label homeLabel = new Label
            {
                Text = "HomePage",
                FontSize = 40
            };
            homeButton = new Button
            {
                Text = "vá para segunda pagina!"
            };
            homeButton.Clicked += async (sender, args) =>
            {
                await Navigation.PushAsync(new secondPage());
            };

            StackLayout stackLayout = new StackLayout
            {
                Children = { homeLabel, homeButton }
            };
            this.Content = stackLayout;
        }
    }
}
