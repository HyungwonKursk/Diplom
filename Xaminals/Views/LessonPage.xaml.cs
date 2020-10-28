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
    public partial class LessonPage : ContentPage
    {
        public LessonPage()
        {
            InitializeComponent();
        }
        async void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string LessonName = (e.CurrentSelection.FirstOrDefault() as Animal).Name;
            // This works because route names are unique in this application.
            await Shell.Current.GoToAsync($"lessondetails?name={LessonName}");
            // The full route is shown below.
            // await Shell.Current.GoToAsync($"//animals/elephants/elephantdetails?name={elephantName}");
        }
    }
}