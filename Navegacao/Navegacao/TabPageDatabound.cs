using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace Navegacao
{
    public class TabPageDatabound : TabbedPage
    {
        public TabPageDatabound()
        {
            this.Title = "TabbedPage, herdando dados de um data";
            this.ItemsSource = new tabItem[]
            {
                new tabItem ("Primeiro", 1),
                new tabItem ("Segundo", 2),
                new tabItem ("Terceiro", 3),
                new tabItem ("Quarto", 4),
                new tabItem ("Quinto", 5),
                new tabItem ("Sexto", 6),
            };
            this.ItemTemplate = new DataTemplate(() =>
            {
                return new NumberPage();
            })
        }
        public class tabItem
        {
            public tabItem(string name, int number)
            {
                this.Name = name;
                this.Number = number;
            }
            public string Name { private set; get; }
            public int Number { private set; get; }
        }
    }
}
