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

        public static readonly BindableProperty CardTitleProperty =
            BindableProperty.Create(
                nameof(CardTitle),
                typeof(string),
                typeof(ExpanderTransistorOutput),
                string.Empty);

        public static readonly BindableProperty CardDescriptionProperty = 
            BindableProperty.Create(
                nameof(CardDescription),
                typeof(string),
                typeof(ExpanderTransistorOutput),
                string.Empty);

        public static readonly BindableProperty BorderColorProperty =
            BindableProperty.Create(
                nameof(BorderColor),
                typeof(Color),
                typeof(ExpanderTransistorOutput),
                Color.DarkGray);

        public static readonly BindableProperty CardColorProperty = 
            BindableProperty.Create(
                nameof(CardColor),
                typeof(Color),
                typeof(ExpanderTransistorOutput),
                Color.White);

        public static readonly BindableProperty IconImageSourceProperty =
            BindableProperty.Create(
                nameof(IconImageSource),
                typeof(ImageSource),
                typeof(ExpanderTransistorOutput),
                default(ImageSource));

        public static readonly BindableProperty IconBackgroundColorProperty =
            BindableProperty.Create(
                nameof(IconBackgroundColor),
                typeof(Color),
                typeof(ExpanderTransistorOutput),
                Color.LightGray);
        public ExpanderTransistorOutput()
        {
            InitializeComponent();
        }

        public object TransistorOutput
        {
            get { return (TransistorOutput)GetValue(TransistorOutputProperty); }
            set { SetValue(TransistorOutputProperty, value); }
        }

        public string CardTitle
        {
            get => (string)GetValue(CardTitleProperty);
            set => SetValue(CardTitleProperty, value);
        }

        public string CardDescription
        {
            get => (string)GetValue(CardDescriptionProperty);
            set => SetValue(CardDescriptionProperty, value);
        }

        public Color BorderColor
        {
            get => (Color)GetValue(BorderColorProperty);
            set => SetValue(BorderColorProperty, value);
        }

        public Color CardColor
        {
            get => (Color)GetValue(CardColorProperty);
            set => SetValue(CardColorProperty, value);
        }

        public ImageSource IconImageSource
        {
            get => (ImageSource)GetValue(IconImageSourceProperty);
            set => SetValue(IconImageSourceProperty, value);
        }

        public Color IconBackgroundColor
        {
            get => (Color)GetValue(IconBackgroundColorProperty);
            set => SetValue(IconBackgroundColorProperty, value);
        }
    }
}