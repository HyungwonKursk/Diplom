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
    public partial class SettingsPage : ContentPage
    {
        Entry TeacherEntry;
        public SettingsPage()
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
        }
        
        Button Btn;
        void picker_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
            stackLayout.Children.Add(TeacherEntry);
            //TeacherEntry.TextChanged += loginEntry_TextChanged; обработчик события. потом понадобится

            header.Text = "Вы выбрали: " + picker.Items[picker.SelectedIndex];
            if (picker.Items[picker.SelectedIndex] == "Поиск преподавателя по ФИО")
            {
                TeacherEntry.Placeholder = "ФИО преподавателя";
            }
            if (picker.Items[picker.SelectedIndex] == "Поиск свободной аудитории по времени")
            {
                TeacherEntry.Placeholder = "Время занятия";
            }
            stackLayout.Children.Add(Btn);

            this.Content = stackLayout;
        }

        /*private void loginEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            textLabel.Text = loginEntry.Text;
        }*/
    }
}