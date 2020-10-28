using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xaminals.Data;

namespace Xaminals.Views
{
    [QueryProperty("Name", "name")]
    public partial class LessonDetailPage : ContentPage
    {

        public string Name
        {
            set
            {
                BindingContext = LessonData.Lessons.FirstOrDefault(m => m.Name == Uri.UnescapeDataString(value));
            }
        }
        public LessonDetailPage()
        {
            InitializeComponent();
        }
    }
}