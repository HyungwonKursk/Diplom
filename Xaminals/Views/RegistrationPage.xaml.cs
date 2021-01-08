using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xaminals.Models;
using Xaminals.Data;

namespace Xaminals.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationPage : ContentPage
    {

        public Label labelMessage { get; set; }
        public Entry NameBox { get; set; }
        public Entry LoginBox { get; set; }
        public Entry PasswBox { get; set; }
        public Entry PasswCheckBox { get; set; }
        public Button RegisBtn { get; set; }
        public Picker TypePick { get; set; }
        public Picker GroupPick { get; set; }
        public Entry DepartBox { get; set; }

        public RegistrationPage()
        {
            InitializeComponent();
            Title = "Зарегистрироваться";

            

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
                Placeholder = "ФИО пользователя",
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

            DepartBox = new Entry
            {
                Text = "",
                Placeholder = "Кафедра",
                Keyboard = Keyboard.Default,
                TextColor = Color.Black,
                PlaceholderColor = Color.Black,
                ClearButtonVisibility = ClearButtonVisibility.WhileEditing,
                Style = Device.Styles.BodyStyle,
                HorizontalOptions = LayoutOptions.Fill
            };

            TypePick.SelectedIndexChanged += TypePick_SelectedIndexChanged;
            RegisBtn.Clicked += RegisBtn_Clicked; ;
            /*RegisrationPage.LoginBtn.Clicked += ToLoginPage;*/

            this.Content = new ScrollView { Content = SetContent() };
        }

        private void TypePick_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TypePick.Items[TypePick.SelectedIndex]=="Студент")
            {
                
                stackLayout.Children.Remove(DepartBox);
                stackLayout.Children.Remove(RegisBtn);
                stackLayout.Children.Add(GroupPick);
            }
                
            else
                if (TypePick.Items[TypePick.SelectedIndex] == "Преподаватель")
                {
                    stackLayout.Children.Remove(GroupPick);
                    stackLayout.Children.Remove(RegisBtn);
                    stackLayout.Children.Add(DepartBox);
                }
                
            stackLayout.Children.Add(RegisBtn);
            //stackLayout.Children.Add(new BoxView { VerticalOptions = LayoutOptions.CenterAndExpand });
            this.Content = new ScrollView { Content = stackLayout };
        }
        StackLayout stackLayout;
        public ScrollView SetContent()
        {
            stackLayout = new StackLayout();
            stackLayout.Margin = 20;

            stackLayout.Children.Add(new BoxView { VerticalOptions = LayoutOptions.CenterAndExpand });
            stackLayout.Children.Add(labelMessage);
            stackLayout.Children.Add(NameBox);
            stackLayout.Children.Add(TypePick);
            
            stackLayout.Children.Add(LoginBox);
            stackLayout.Children.Add(PasswBox);
            stackLayout.Children.Add(PasswCheckBox);
            stackLayout.Children.Add(new BoxView { VerticalOptions = LayoutOptions.CenterAndExpand });

            ScrollView scroll = new ScrollView { Content = stackLayout };
            return scroll;
        }

   
        private void RegisBtn_Clicked(object sender, EventArgs e)
        {
            if (LoginBox.Text == "" || PasswBox.Text == "" || PasswCheckBox.Text == "" ||
                TypePick.Items[TypePick.SelectedIndex] == "" || NameBox.Text == "")
            {
                DependencyService.Get<IToast>().Show("Не все поля заполнены");
                return;
            }
            if (PasswBox.Text != PasswCheckBox.Text)
            {
                DependencyService.Get<IToast>().Show("Пароли не совпадают");
                return;
            }

            if (TypePick.Items[TypePick.SelectedIndex] == "Преподаватель")
            {
                var user = new Teacher(NameBox.Text, PasswBox.Text, LoginBox.Text, DepartBox.Text);
                if (TeacherData.CheckLogin(user) )
                    DependencyService.Get<IToast>().Show("Успешно");
                else
                    DependencyService.Get<IToast>().Show("Логин уже занят");

            }
            
            

            /*
            if (RegisrationPage.LoginBox.Text=="")
                DependencyService.Get<IToast>().Show("Не все поля заполнены");
            bool connect = await WebConnection.CheckConnection();
            if (connect == false) return;

            ClientService clientService = new ClientService();

            // отправка данных регистрации на сервер    
            var client = await clientService.
                Register(RegisrationPage.NameBox.Text, RegisrationPage.LoginBox.Text, RegisrationPage.PasswBox.Text);


            // если сервер вернул данные пользователя - загрузить в пользователя
            if (client != null)
            {
                Client.setClient(Int32.Parse(client["Id"]), client["Name"], client["Login"]);
                DbService.SaveClient(Client.CurrentClient); // сохранили пользователя
                                                            // DbService.LoadUser();

                GetClientPage();
                return;
            }
            else
            {
                await DisplayAlert("Ошибка", "Сервер не вернул данные", "OK");
                return;
            }*/
        }
    }
}