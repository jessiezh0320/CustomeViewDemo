using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CustomeViewApp1.controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TestControl : ContentView
    {

        public static readonly BindableProperty TestTextProperty = BindableProperty.Create(nameof(TestText), typeof(string), typeof(TestControl));
        public string TestText
        {
            get { return (string)GetValue(TestTextProperty); }
            set { SetValue(TestTextProperty, value); }
        }

        public TestControl()
        {
            InitializeComponent();

            //BindingContext = this;
        }
        
    }
}