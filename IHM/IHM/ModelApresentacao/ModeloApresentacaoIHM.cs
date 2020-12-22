using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Text;
using Xamarin.Forms;
using Color = Xamarin.Forms.Color;

namespace IHM.ModelApresentacao
{
    public class ConversorDigitalInputStatusParaCor : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((value is bool bValue) && (bValue))
                return Color.Green;

            return Color.Gray;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((value is Color cValue) && (cValue == Color.Green))
                return true;

            return false;
        }
    }

    public class DigitalInput : INotifyPropertyChanged
    {
        private string nome;
        private bool status;

        public DigitalInput(
            string nome,
            bool status)
        {
            Nome = nome;
            Status = status;
        }

        public string Nome
        {
            get { return nome; }

            set
            {
                if (nome != value)
                {
                    nome = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Nome)));
                }
            }
        }

        public bool Status
        {
            get { return status; }

            set
            {
                if (status != value)
                {
                    status = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Status)));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }

    class ModeloApresentacaoIHM
    {
        public DigitalInput DigitalInput1 { get; } = new DigitalInput("I1", false);
        public DigitalInput DigitalInput2 { get; } = new DigitalInput("I2", false);
        public DigitalInput DigitalInput3 { get; } = new DigitalInput("I3", false);
        public DigitalInput DigitalInput4 { get; } = new DigitalInput("I4", false);
        public DigitalInput DigitalInput5 { get; } = new DigitalInput("I5", false);
        public DigitalInput DigitalInput6 { get; } = new DigitalInput("I6", false);
        public DigitalInput DigitalInput7 { get; } = new DigitalInput("I7", false);
        public DigitalInput DigitalInput8 { get; } = new DigitalInput("I8", false);
        private List<DigitalInput> ListDigitalInputs = new List<DigitalInput>();

        public ModeloApresentacaoIHM()
        {
            ListDigitalInputs = new List<DigitalInput>()
            {
                DigitalInput1,
                DigitalInput2,
                DigitalInput3,
                DigitalInput4,
                DigitalInput5,
                DigitalInput6,
                DigitalInput7,
                DigitalInput8,
            };

            foreach (DigitalInput item in ListDigitalInputs)
            {
                item.PropertyChanged += DigitalInput_PropertyChanged;

            }
        }

        private void DigitalInput_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if ((sender is DigitalInput DigitalInput) && (e.PropertyName == nameof(DigitalInput.Status))) ;
                //Enviar(string.Format("{0}_{1}\0", DigitalInput.Nome, DigitalInput.Status ? 1 : 0));
        }

    }
}
