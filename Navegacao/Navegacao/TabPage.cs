using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace Navegacao
{
    public class TabPage : TabbedPage
    {
        public TabPage()
        {
            this.Title = "Tabbed Page";
            this.Children.Add(new HomePage()
            {
                Title = "HomePage"
            });
            this.Children.Add(new FirstPage()
            {
                Title= "Primeira Pagina"
            });
            this.Children.Add(new secondPage()
            {
                Title = "Segunda Pagina"
            });
           
        }
    }
}
