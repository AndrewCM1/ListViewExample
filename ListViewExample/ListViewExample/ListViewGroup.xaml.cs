using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewGroup : ContentPage
    {
        public ObservableCollection<Group> Groups { get; set; }
        public ListViewGroup()
        {
            InitializeComponent();
            Groups = new ObservableCollection<Group>
        {
            new Group("SeccionA")
            {
                new Item { Title = "Andrew", Subtitle = "Cuellar" },
                new Item { Title = "Lenard", Subtitle = "Idone" },
                new Item { Title = "Carlos", Subtitle = "Cabrera" },
                new Item { Title = "Oscar", Subtitle = "Hurtado" }
            },
            new Group("SeccionB")
            {
                new Item { Title = "Raul", Subtitle = "Garay" },
                new Item { Title = "Samir", Subtitle = "Alanya" },
                new Item { Title = "Abraham", Subtitle = "Guzman" },
                new Item { Title = "Angela", Subtitle = "Chancasanampa" }
            },
            new Group("SeccionC")
            {
                new Item { Title = "Josue", Subtitle = "Castillo" },
                new Item { Title = "Alex", Subtitle = "Najarro" },
                new Item { Title = "Diego", Subtitle = "Mendieta" },
                new Item { Title = "Max", Subtitle = "Martinez" }
            },
        };
            GroupedView.ItemsSource = Groups;
        }
    }
}