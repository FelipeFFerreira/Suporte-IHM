using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IHM.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IHM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExpanderTransistorOutput : ContentView
    {
        public static readonly BindableProperty TransistorOutputProperty =
            BindableProperty.Create(
                nameof(TransistorOutput),
                typeof(TransistorOutput),
                typeof(ExpanderTransistorOutput),
                new TransistorOutput());

        public ExpanderTransistorOutput()
        {
            InitializeComponent();
        }

        public TransistorOutput TransistorOutput
        {
            get { return (TransistorOutput)GetValue(TransistorOutputProperty); }
            set { SetValue(TransistorOutputProperty, value); }
        }
    }
}