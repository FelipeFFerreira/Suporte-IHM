
using IHM.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IHM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewDigitalInput : ContentView
    {
        public static readonly BindableProperty DigitalInputProperty =
            BindableProperty.Create(
                nameof(DigitalInput),
                typeof(DigitalInput),
                typeof(ViewDigitalInput),
                new DigitalInput());

        public static readonly BindableProperty CardTitleProperty =
            BindableProperty.Create(
                nameof(CardTitle),
                typeof(string),
                typeof(ViewDigitalInput),
                string.Empty);

        public static readonly BindableProperty CardDescriptionProperty =
            BindableProperty.Create(
                nameof(CardDescription),
                typeof(string),
                typeof(ViewDigitalInput),
                string.Empty);

        public static readonly BindableProperty BorderColorProperty =
            BindableProperty.Create(
                nameof(BorderColor),
                typeof(Color),
                typeof(ViewDigitalInput),
                Color.White);

        public static readonly BindableProperty CardColorProperty =
            BindableProperty.Create(
                nameof(CardColor),
                typeof(Color),
                typeof(ViewDigitalInput),
                Color.FromHex("FF696969"));

        public static readonly BindableProperty IconImageSourceProperty =
            BindableProperty.Create(
                nameof(IconImageSource),
                typeof(ImageSource),
                typeof(ViewDigitalInput),
                default(ImageSource));

        public static readonly BindableProperty IconBackgroundColorProperty =
            BindableProperty.Create(
                nameof(IconBackgroundColor),
                typeof(Color),
                typeof(ViewDigitalInput),
                Color.LightGray);
        public ViewDigitalInput()
        {
            InitializeComponent();
        }

        public object DigitalInput
        {
            get { return (DigitalInput)GetValue(DigitalInputProperty); }
            set { SetValue(DigitalInputProperty, value); }
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