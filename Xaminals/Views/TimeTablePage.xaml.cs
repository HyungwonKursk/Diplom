using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xaminals.Models;

namespace Xaminals.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TimeTablePage : ContentPage
    {
        Label header;
        Picker picker;
        public TimeTablePage()
        {

            InitializeComponent();

            CollectionView collectionView = new CollectionView();
            collectionView.Scrolled += OnCollectionViewScrolled;
            header = new Label
            {
                Text = "Выберите неделю",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            };

            picker = new Picker
            {

            };
            picker.Items.Add("Числитель");
            picker.Items.Add("Знамениталь");

            picker.SelectedIndexChanged += picker_SelectedIndexChanged;

            this.Content = new StackLayout { Children = { header, picker } };
            
        }

        async private void TimeTablePage_Clicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new BearsPage());
        }

        void picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (picker.Items[picker.SelectedIndex] == "Числитель")
            {
                header.Text = "Вы выбрали: " + picker.Items[picker.SelectedIndex];
                Grid grid = new Grid
                {
                    RowDefinitions =
            {
                new RowDefinition { Height = 60 },
                new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                new RowDefinition { Height = new GridLength(1, GridUnitType.Star) }
            },
              //      ColumnDefinitions =
           // {
           //     new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
           // }
                };


                Button[] buttons = new Button[9];

                Label[] labels = new Label[9];
                for (int i = 0; i < 9; i++)
                {
                    labels[i] = new Label();
                    labels[i].Text = "Урок №" + Convert.ToString(i);
                    buttons[i] = new Button();
                    buttons[i].Text = "Урок №" + Convert.ToString(i);

                    //buttons[i].Clicked += async (sender, args) => await Navigation.PushAsync(new MonkeyDetailPage()
                    //{ 

                    //});

                    buttons[i].Clicked += TimeTablePage_Clicked;
                    // buttons[i].Clicked+= delegate()


                }
                grid.Children.Add(picker,0,0);
               

                grid.Children.Add(buttons[1],0,1);
                grid.Children.Add(buttons[2],0,2);

                grid.Children.Add(buttons[3],0,3);
                grid.Children.Add(buttons[4],0,4);
                grid.Children.Add(buttons[5],0,5);
                Content = grid;
            }
            else
            {    
                header.Text = "Вы выбрали: " + picker.Items[picker.SelectedIndex];


                Grid grid = new Grid
                {
                    RowDefinitions =
                    {
                        new RowDefinition { Height = 60 },
                        new RowDefinition { Height = 100 },
                        new RowDefinition { Height = 100 },
                        new RowDefinition { Height = 100 },
                        new RowDefinition { Height = 100 },
                        new RowDefinition { Height = 100 },
                        new RowDefinition { Height = 100 },
                        new RowDefinition { Height = 100 },
                        new RowDefinition { Height = 100 }
                    },
                    //      ColumnDefinitions =
                    // {
                    //     new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
                    // }
                };


                Button[] buttons = new Button[11];

                Label[] labels = new Label[11];
                for (int i = 0; i < 11; i++)
                 {
                    labels[i] = new Label();
                    labels[i].Text = "Урок №" + Convert.ToString(i+9);
                    buttons[i] = new Button();
                    buttons[i].Text = "Урок №" + Convert.ToString(i+9);

                    //buttons[i].Clicked += async (sender, args) => await Navigation.PushAsync(new MonkeyDetailPage()
                    //{ 

                    //});

                    buttons[i].Clicked += TimeTablePage_Clicked;
                    // buttons[i].Clicked+= delegate()
                }
                grid.Children.Add(picker, 0, 0);


                 grid.Children.Add(buttons[1], 0, 1);
                 grid.Children.Add(buttons[2], 0, 2);

                grid.Children.Add(buttons[3], 0, 3);
                grid.Children.Add(buttons[4], 0, 4);
                grid.Children.Add(buttons[5], 0, 5);
                grid.Children.Add(buttons[6], 0, 6);
                grid.Children.Add(buttons[7], 0, 7);
                grid.Children.Add(buttons[8], 0, 8);
                Content = grid;
            }
        }

        async void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string bearName = (e.CurrentSelection.FirstOrDefault() as TimeTable).Name;
            // This works because route names are unique in this application.
            await Shell.Current.GoToAsync($"beardetails?name={bearName}");
            // The full route is shown below.
            // await Shell.Current.GoToAsync($"//animals/bears/beardetails?name={bearName}");
        }
        void OnCollectionViewScrolled(object sender, ItemsViewScrolledEventArgs e)
        {
            Debug.WriteLine("HorizontalDelta: " + e.HorizontalDelta);
            Debug.WriteLine("VerticalDelta: " + e.VerticalDelta);
            Debug.WriteLine("HorizontalOffset: " + e.HorizontalOffset);
            Debug.WriteLine("VerticalOffset: " + e.VerticalOffset);
            Debug.WriteLine("FirstVisibleItemIndex: " + e.FirstVisibleItemIndex);
            Debug.WriteLine("CenterItemIndex: " + e.CenterItemIndex);
            Debug.WriteLine("LastVisibleItemIndex: " + e.LastVisibleItemIndex);
        }
    }
}