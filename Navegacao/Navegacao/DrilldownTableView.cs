using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace Navegacao
{
    public class DrilldownTableView : ContentPage
    {
        public DrilldownTableView()
        {
            Command<Type> navigateCommand = new Command<Type>(async (Type pageType) =>
            {
                Page page = (Page)Activator.CreateInstance(pageType);
                await this.Navigation.PushAsync(page);
            });

            this.Title = "Drilldown List usando TableView";
            this.Content = new TableView
            {
                Intent = TableIntent.Menu,
                Root = new TableRoot
                {
                    new TableSection("Espanõl")
                    {
                        new TextCell
                        {
                            Text = "Primero",
                            Command = navigateCommand,
                            CommandParameter = typeof(FirstPage)
                        },
                        new TextCell
                        {
                            Text="Segundo",
                            Command = navigateCommand,
                            CommandParameter = typeof(secondPage)
                        }
                    },
                    new TableSection ("English")
                    {
                        new TextCell
                        {
                            Text="First",
                            Command = navigateCommand,
                            CommandParameter = typeof(FirstPage)
                        },
                        new TextCell
                        {
                            Text="Second",
                            Command = navigateCommand,
                            CommandParameter = typeof(secondPage)
                        }
                    },
                    new TableSection("Hindi")
                    {
                        new TextCell
                        {
                            Text="Prathma",
                            Command = navigateCommand,
                            CommandParameter = typeof(FirstPage)
                        },
                        new TextCell
                        {
                            Text="Dusara",
                            Command = navigateCommand,
                            CommandParameter = typeof(secondPage)
                        }
                    }
                }
            };
        }
    }
}
