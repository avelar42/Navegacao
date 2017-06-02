using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace Navegacao
{
    public class DropDownMenu : ContentPage
    {
        public DropDownMenu()
        {
            ToolbarItems.Clear();
            ToolbarItems.Add(new ToolbarItem
            {
                Text = "Home",
                Order = ToolbarItemOrder.Secondary,
                Command = new Command(() =>
                Navigation.PushAsync(new DropDownMenu()))
            });
            ToolbarItems.Add(new ToolbarItem
            {
                Text = "Second Page",
                Order = ToolbarItemOrder.Secondary,
                Command = new Command(() =>
                Navigation.PushAsync(new secondPage()))
            });
            
        }
        
    }
}
