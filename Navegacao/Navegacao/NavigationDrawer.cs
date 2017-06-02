using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace Navegacao
{
    public class NavigationDrawer : MasterDetailPage
    {
        public NavigationDrawer()
        {
            Title = "Navigation Drawer usando MasterDetailsPage";
            string[] myPageNames = { "HomePage", "FistPage", "secondPage" };
            ListView listView = new ListView
            {
                ItemsSource = myPageNames,
            };
            this.Master = new ContentPage
            {
                Title = "Opções",
                Content = listView,
                Icon = "hamburger.png"
            };

            listView.ItemTapped += (sender, e) =>
            {
                ContentPage gotoPage;
                switch (e.Item.ToString())
                {
                    case "HomePage":
                        gotoPage = new HomePage();
                        break;
                    case "FirstPage":
                        gotoPage = new FirstPage();
                        break;
                    case "secondPage":
                        gotoPage = new secondPage();
                        break;
                    default:
                        gotoPage = new HomePage();
                        break;
                }
                Detail = new NavigationPage(gotoPage);
                ((ListView)sender).SelectedItem = null;
                this.IsPresented = false;
            };
            Detail = new NavigationPage(new HomePage());
        }
    }
}
