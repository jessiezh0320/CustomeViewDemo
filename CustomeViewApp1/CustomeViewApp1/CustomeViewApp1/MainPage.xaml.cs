using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CustomeViewApp1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<TestModel> veggies { get; set; }

        public MainPage()
        {
            InitializeComponent();

            //TestModel model = new TestModel { Title="asd"};

            veggies = new ObservableCollection<TestModel>();

            veggies.Add(new TestModel { Title = "Tomato", Type = "Fruit" });
            veggies.Add(new TestModel { Title = "Zucchini", Type = "Vegetable" });
            veggies.Add(new TestModel { Title = "Tomato" , Type = "Vegetable" });
            veggies.Add(new TestModel { Title = "Romaine", Type = "Fruit" });
            veggies.Add(new TestModel { Title = "Zucchini", Type = "Vegetable" });

            lstView.ItemsSource = veggies;

            BindingContext = this;
        }
    }
}
