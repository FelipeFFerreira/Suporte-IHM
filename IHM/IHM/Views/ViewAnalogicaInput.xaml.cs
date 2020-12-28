using IHM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IHM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewAnalogicaInput : ContentView
    {
        public static readonly BindableProperty AnalogicaInputProperty =
           BindableProperty.Create(
               nameof(AnalogicaInput),
               typeof(AnalogicaInput),
               typeof(ViewAnalogicaInput),
               new AnalogicaInput());

        public static readonly BindableProperty CardTitleProperty =
            BindableProperty.Create(
                nameof(CardTitle),
                typeof(string),
                typeof(ViewAnalogicaInput),
                string.Empty);

        public static readonly BindableProperty CardDescriptionProperty =
            BindableProperty.Create(
                nameof(CardDescription),
                typeof(string),
                typeof(ViewAnalogicaInput),
                string.Empty);

        public static readonly BindableProperty BorderColorProperty =
            BindableProperty.Create(
                nameof(BorderColor),
                typeof(Color),
                typeof(ViewAnalogicaInput),
                Color.DarkGray);

        public static readonly BindableProperty CardColorProperty =
            BindableProperty.Create(
                nameof(CardColor),
                typeof(Color),
                typeof(ViewAnalogicaInput),
                Color.Red
                );

        public static readonly BindableProperty IconImageSourceProperty =
            BindableProperty.Create(
                nameof(IconImageSource),
                typeof(ImageSource),
                typeof(ViewAnalogicaInput),
                default(ImageSource));

        public static readonly BindableProperty IconBackgroundColorProperty =
            BindableProperty.Create(
                nameof(IconBackgroundColor),
                typeof(Color),
                typeof(ViewAnalogicaInput),
                Color.LightGray);
        public ViewAnalogicaInput()
        {
            InitializeComponent();
        }

        public object AnalogicaInput
        {
            get { return (AnalogicaInput)GetValue(AnalogicaInputProperty); }
            set { SetValue(AnalogicaInputProperty, value); }
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