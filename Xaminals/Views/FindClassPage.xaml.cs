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
    public partial class FindClassPage : ContentPage
    {
        Entry ClassEntry;
        Button Class_Btn;
        public FindClassPage()
        {
            InitializeComponent();

            ClassEntry = new Entry { Placeholder = "Время занятия" };

            Class_Btn = new Button
            {
                Text = "Поиск",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                BorderWidth = 1,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            SLayout.Children.Add(ClassEntry);
            SLayout.Children.Add(Class_Btn);
            this.Content = SLayout;
        }
    }
}