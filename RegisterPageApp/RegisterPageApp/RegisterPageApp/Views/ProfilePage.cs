using RegisterPageApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace RegisterPageApp.Views
{
    public class ProfilePage : ContentPage
    {
        public ProfilePage(User user)
        {
            Title = "Profile";
            Padding = new Thickness(40);
            FormattedString formattedString = new FormattedString();
            formattedString.Spans.Add(new Span { Text= "Welcome to ", TextColor=Color.Black, FontSize=20 });
            formattedString.Spans.Add(new Span { Text = "OAK Academy.", TextColor = Color.Orange, FontSize = 24,
                TextDecorations =TextDecorations.Underline });

            Content = new StackLayout
            {
                Children =
                {
                    new Label { Text = "Hi "+user.FirstName, TextColor=Color.Black, FontSize=24 },
                    //new Label{Text="Welcome to OAK Academy.", TextColor=Color.Black, FontSize=24},
                    new Label{FormattedText=formattedString},

                    new Label{Text="Your Informations:", TextColor=Color.Red, FontSize=30, VerticalOptions=LayoutOptions.EndAndExpand},
                    new Label{Text=$"First Name: {user.FirstName}", TextColor=Color.Black, FontSize=28},
                    new Label{Text=$"Last Name: {user.LastName}", TextColor=Color.Black, FontSize=28},
                    new Label{Text=$"Age: {user.Age}", TextColor=Color.Black, FontSize=28},
                    new Label{Text=$"Gender: {user.Gender}", TextColor=Color.Black, FontSize=28},
                    new Label{Text=$"Email: {user.Email}", TextColor=Color.Black, FontSize=28},
                    new Label{Text=$"Phone: {user.Phone}", TextColor=Color.Black, FontSize=28},
                }
            };
        }
    }
}