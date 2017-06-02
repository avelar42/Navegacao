using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace Navegacao
{
    public class DrilldownListViewByItem : ContentPage
    {
        public class ListItem
        {
            public string Title { get; set; }
            public string Description { get; set; }
        }
        public DrilldownListViewByItem()
        {
            Title = "DrillDown usando listView";
            var listView = new ListView();
            listView.ItemsSource = new ListItem[]
            {
                new ListItem {Title="Primeiro", Description="1st item" },
                new ListItem {Title="Segundo", Description="2st item" },
                new ListItem {Title="Terceiro", Description="3st item" }
            };
            listView.ItemTemplate = new DataTemplate(typeof(TextCell));
            listView.ItemTemplate.SetBinding(TextCell.TextProperty, "Title");

            listView.ItemTapped += async (sender, args) =>
            {
                var item = args.Item as ListItem;
                if (item == null) return;
                await Navigation.PushAsync(new DetailPage(item));
                listView.SelectedItem = null;
            };
            Content = listView;
        }
    }
}
