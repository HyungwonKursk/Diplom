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
    public partial class RegistrationPage : ContentPage
    {
        public RegistrationPage()
        {
            InitializeComponent();
            RegisrationPage = new RegisrationContrioolers();
            this.Content = RegisrationPage.SetContent();
            this.Content = new ScrollView { Content = RegisrationPage.SetContent() };
        }

        public class RegisrationContrioolers
        {
            public Label labelMessage { get; set; }

            public Entry NameBox { get; set; }
            public Entry LoginBox { get; set; }
            public Entry PasswBox { get; set; }
            public Entry PasswCheckBox { get; set; }

            public Button RegisBtn { get; set; }
            public Picker TypePick { get; set; }

            public Picker GroupPick { get; set; }

            public RegisrationContrioolers()
            {
                labelMessage = new Label
                {
                    Text = "Регистрация",
                    Style = Device.Styles.TitleStyle,
                    HorizontalOptions = LayoutOptions.Center,
                    TextColor = Color.Black
                };

                NameBox = new Entry
                {
                    Text = "",
                    Placeholder = "Имя пользователя",
                    Keyboard = Keyboard.Default,
                    TextColor = Color.Black,
                    PlaceholderColor = Color.Black,
                    ClearButtonVisibility = ClearButtonVisibility.WhileEditing,
                    Style = Device.Styles.BodyStyle,
                    HorizontalOptions = LayoutOptions.Fill
                };
                TypePick = new Picker { Title = "Должность", TextColor = Color.Black };
                TypePick.Items.Add("Студент");
                TypePick.Items.Add("Преподаватель");

                GroupPick = new Picker { Title = "Группа", TextColor = Color.Black };
                GroupPick.Items.Add("113");
                GroupPick.Items.Add("213");
                GroupPick.Items.Add("313");
                GroupPick.Items.Add("413");

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
                    ClearButtonVisibility = ClearButtonVisibility.WhileEditing,
                    Style = Device.Styles.BodyStyle,
                    HorizontalOptions = LayoutOptions.Fill
                };
                PasswCheckBox = new Entry
                {
                    Text = "",
                    Placeholder = "Подтверждение пароля",
                    Keyboard = Keyboard.Default,
                    TextColor = Color.Black,
                    PlaceholderColor = Color.Black,
                    IsPassword = true,
                    ClearButtonVisibility = ClearButtonVisibility.WhileEditing,
                    Style = Device.Styles.BodyStyle,
                    HorizontalOptions = LayoutOptions.Fill
                };

                RegisBtn = new Button
                {
                    Text = "Зарегестрироваться",
                    BackgroundColor = Color.FromHex("#b3e5fc"),
                    TextColor = Color.Black,
                    BorderColor = Color.Black,
                };
                
            }

            public ScrollView SetContent()
            {
                StackLayout stackLayout = new StackLayout();
                stackLayout.Margin = 20;

                stackLayout.Children.Add(new BoxView { VerticalOptions = LayoutOptions.CenterAndExpand });
                stackLayout.Children.Add(labelMessage);
                stackLayout.Children.Add(NameBox);
                stackLayout.Children.Add(TypePick);
                stackLayout.Children.Add(GroupPick);
                stackLayout.Children.Add(LoginBox);
                stackLayout.Children.Add(PasswBox);
                stackLayout.Children.Add(PasswCheckBox);
                stackLayout.Children.Add(RegisBtn);
                stackLayout.Children.Add(new BoxView { VerticalOptions = LayoutOptions.CenterAndExpand });

                ScrollView scroll = new ScrollView { Content = stackLayout };
                return scroll;
            }
        }

        public RegisrationContrioolers RegisrationPage;

        
    }
}