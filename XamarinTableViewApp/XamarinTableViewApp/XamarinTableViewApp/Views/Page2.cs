using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XamarinTableViewApp.Views
{
    public class Page2 : ContentPage
    {
        public Page2()
        {
            TableView tableView = new TableView
            {
                HasUnevenRows=true,
                Intent=TableIntent.Settings,
                Root=new TableRoot
                {
                    new TableSection("Title")
                    {
                        new TextCell{Text="My Text", Detail="My Detail", TextColor=Color.Navy },
                        new SwitchCell{ Text="SwitchCell" },
                        new EntryCell{Label="Email", Keyboard=Keyboard.Email, Placeholder="Your Email"},
                        new ViewCell{View=new Button{Text="Button1"}},
                        new ViewCell{View=new StackLayout
                        {                            
                            Children=
                            {
                                new Label{Text="Label", FontSize=30},
                                new Button{Text="Click"}
                            }
                        } }
                    }
                }
            };

            Content = tableView;
        }
    }
}