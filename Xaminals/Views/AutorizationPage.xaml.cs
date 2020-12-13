using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xaminals.Models;

namespace Xaminals.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AutorizationPage : ContentPage
    {
        public Image LogoImage { get; set; }
        public Label TitleLab { get; set; }
        public Entry LoginBox { get; set; }
        public Entry PasswBox { get; set; }
        public Button LoginBtn { get; set; }
        public Button RegisBtn { get; set; }
        public AutorizationPage()
        {
            InitializeComponent();

            LogoImage = new Image
            {
                Source = "Logo2.jpg"
            };

            TitleLab = new Label
            {
                Text = "Вход",
                Style = Device.Styles.TitleStyle,
                HorizontalOptions = LayoutOptions.Center,
            };

            LoginBox = new Entry
            {
                Text = "",
                Placeholder = "Логин",
                Keyboard = Keyboard.Default,
                TextColor = Color.Black,
                PlaceholderColor = Color.Black,
                ClearButtonVisibility = ClearButtonVisibility.WhileEditing,
                Style = Device.Styles.BodyStyle,
                HorizontalOptions = LayoutOptions.Fill
            };
            PasswBox = new Entry
            {
                Text = "",
                Placeholder = "Пароль",
                Keyboard = Keyboard.Default,
                TextColor = Color.Black,
                PlaceholderColor = Color.Black,
                IsPassword = true,
                ClearButtonVisibility = ClearButtonVisibility.WhileEditing,
                Style = Device.Styles.BodyStyle,
                HorizontalOptions = LayoutOptions.Fill
            };

            LoginBtn = new Button
            {
                Text = "Войти",
                //BackgroundColor = Color.FromHex("#BFD9B6"),
                TextColor = Color.Black,
                BorderColor = Color.Black,
            };
            RegisBtn = new Button
            {
                Text = "Зарегистрироваться",
                //BackgroundColor = Color.FromHex("#BFD9B6"),
                TextColor = Color.Black,
                BorderColor = Color.Black,
            };

            LoginBtn.Clicked += LoginBtn_Clicked;
            RegisBtn.Clicked += RegisBtn_Clicked;
            



            this.Content = SetContent();
        }

        private void RegisBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegistrationPage());
        }


        private void LoginBtn_Clicked(object sender, EventArgs e)
        {
           
            Navigation.PushAsync(new RegistrationPage());
        }

        public StackLayout SetContent()
        {
            StackLayout stackLayout = new StackLayout();
            stackLayout.Margin = 20;

            stackLayout.Children.Add(LogoImage);
            stackLayout.Children.Add(new BoxView { VerticalOptions = LayoutOptions.CenterAndExpand });
            stackLayout.Children.Add(TitleLab);
            stackLayout.Children.Add(LoginBox);
            stackLayout.Children.Add(PasswBox);
            stackLayout.Children.Add(LoginBtn);
            stackLayout.Children.Add(RegisBtn);
            stackLayout.Children.Add(new BoxView { VerticalOptions = LayoutOptions.CenterAndExpand });

            return stackLayout;
        }


    }
}