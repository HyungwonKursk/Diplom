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
    public partial class FindTeacherPage : ContentPage
    {
        Entry TeacherEntry;
        Button Btn, Btn2;

        public FindTeacherPage()
        {
            InitializeComponent();

            TeacherEntry = new Entry { Placeholder = "ФИО преподавателя" };

            Btn = new Button
            {
                Text = "Поиск",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                BorderWidth = 1,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            Btn2 = new Button
            {
                Text = "Назад",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                BorderWidth = 1,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            Btn2.Clicked += Btn2_Clicked;
            SLayout.Children.Add(TeacherEntry);
            SLayout.Children.Add(Btn);
            SLayout.Children.Add(Btn2);
            this.Content = SLayout;

        }

        private async void Btn2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}