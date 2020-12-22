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
    public class ConversorSerialInputStatusParaCor : IValueConverter
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

    public class SerialInput : INotifyPropertyChanged
    {
        private string nome;
        private bool status;

        public SerialInput(
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
        public SerialInput SerialInput1 { get; } = new SerialInput("I1", false);
        public SerialInput SerialInput2 { get; } = new SerialInput("I2", false);
        public SerialInput SerialInput3 { get; } = new SerialInput("I3", false);
        public SerialInput SerialInput4 { get; } = new SerialInput("I4", false);
        public SerialInput SerialInput5 { get; } = new SerialInput("I5", false);
        public SerialInput SerialInput6 { get; } = new SerialInput("I6", false);
        public SerialInput SerialInput7 { get; } = new SerialInput("I7", false);
        public SerialInput SerialInput8 { get; } = new SerialInput("I8", false);
        private List<SerialInput> ListSerialInputs = new List<SerialInput>();

        public ModeloApresentacaoIHM()
        {
            ListSerialInputs = new List<SerialInput>()
            {
                SerialInput1,
                SerialInput2,
                SerialInput3,
                SerialInput4,
                SerialInput5,
                SerialInput6,
                SerialInput7,
                SerialInput8,
            };

            foreach (SerialInput item in ListSerialInputs)
            {
                item.PropertyChanged += SerialInput_PropertyChanged;

            }
        }

        private void SerialInput_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if ((sender is SerialInput serialInput) && (e.PropertyName == nameof(SerialInput.Status))) ;
                //Enviar(string.Format("{0}_{1}\0", serialInput.Nome, serialInput.Status ? 1 : 0));
        }

    }
}
