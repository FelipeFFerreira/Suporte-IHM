using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Text;
using Xamarin.Forms;
using IHM.Models;
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

        public TransistorOutput TransistorOutput1 { get; } = new TransistorOutput("O1", false, 0, 0);
        public TransistorOutput TransistorOutput2 { get; } = new TransistorOutput("O2", false, 0, 0);
        public TransistorOutput TransistorOutput3 { get; } = new TransistorOutput("O3", false, 0, 0);
        public TransistorOutput TransistorOutput4 { get; } = new TransistorOutput("O4", false, 0, 0);
        public TransistorOutput TransistorOutput5 { get; } = new TransistorOutput("O5", false, 0, 0);
        public TransistorOutput TransistorOutput6 { get; } = new TransistorOutput("O6", false, 0, 0);
        public TransistorOutput TransistorOutput7 { get; } = new TransistorOutput("O7", false, 0, 0);

        public AnalogicalInput AnalogicaInput1 { get; } = new AnalogicalInput("A1", false, 0);
        public AnalogicalInput AnalogicaInput2 { get; } = new AnalogicalInput("A2", false, 0);
        public AnalogicalInput AnalogicaInput3 { get; } = new AnalogicalInput("A3", false, 0);
        public AnalogicalInput AnalogicaInput4 { get; } = new AnalogicalInput("A4", false, 0);

        private List<AnalogicalInput> ListAnalogicalInputs = new List<AnalogicalInput>();
        private List<DigitalInput> ListDigitalInputs = new List<DigitalInput>();
        private List<TransistorOutput> ListtransistorOutputs = new List<TransistorOutput>();

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

            ListAnalogicalInputs = new List<AnalogicalInput>()
            {
                AnalogicaInput1,
                AnalogicaInput2,
                AnalogicaInput3,
                AnalogicaInput4,
            };

            foreach (DigitalInput item in ListDigitalInputs)
            {
                item.PropertyChanged += DigitalInput_PropertyChanged;
            }

            foreach (AnalogicalInput item in ListAnalogicalInputs)
            {
                item.PropertyChanged += DigitalInput_PropertyChanged;
            }

        }

        private void DigitalInput_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if ((sender is DigitalInput DigitalInput) && (e.PropertyName == nameof(DigitalInput.Status)));
               //Enviar(string.Format("{0}_{1}\0", DigitalInput.Nome, DigitalInput.Status ? 1 : 0));
        }

        private void AnalogicolInput_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if ((sender is AnalogicalInput DigitalInput) && (e.PropertyName == nameof(AnalogicalInput.Value)));
            //Enviar(string.Format("{0}_{1}\0", DigitalInput.Nome, DigitalInput.Status ? 1 : 0));
        }

    }
}
