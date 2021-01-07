using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xaminals.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserPage : ContentPage
    {
        public Label NameLabel { get; set; }
        public Label StatusLabel { get; set; }
        public Label FucultyLabel { get; set; }
        public Label GroupLabel { get; set; }
        public Button GroupBtn { get; set; }
        public Button LogOutBtn { get; set; }

        public UserPage()
        {

            InitializeComponent();
            contentPage.Title = "student1234";
            NameLabel = new Label
            {
                Text = "ФИО: Иванов Иван Иванович",
                Style = Device.Styles.TitleStyle,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.Center,
            };
            StatusLabel = new Label
            {
                Text = "Должность: Студент",
                Style = Device.Styles.TitleStyle,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.Center
            };
            GroupLabel = new Label
            { 
                Text = "Группа: 413.1",
                Style = Device.Styles.TitleStyle,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.Center
            };
            GroupBtn = new Button
            { 
                Text = "Посмотреть список группы",

            };
            LogOutBtn = new Button
            { 
                Text = "Выйти" 
            };
            stackLayout.Children.Add(NameLabel);
            stackLayout.Children.Add(StatusLabel);
            stackLayout.Children.Add(GroupLabel);
            stackLayout.Children.Add(GroupBtn);
            stackLayout.Children.Add(LogOutBtn);
            this.Content = stackLayout;

        }
    }
}