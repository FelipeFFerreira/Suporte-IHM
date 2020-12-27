using IHM.Models;
using System;
using System.Collections.ObjectModel;

namespace IHM.ViewModels
{
   
    public class IHMViewModel
    {
        public TransistorOutput TransistorOutput1 { get; } = new TransistorOutput("O.1", false, 150, 200);
        public TransistorOutput TransistorOutput2 { get; } = new TransistorOutput("O.2", false, 160, 210);
        public TransistorOutput TransistorOutput3 { get; } = new TransistorOutput("O.3", false, 170, 220);
        public TransistorOutput TransistorOutput4 { get; } = new TransistorOutput("O.4", false, 180, 230);
        public TransistorOutput TransistorOutput5 { get; } = new TransistorOutput("O.5", false, 190, 240);
        public TransistorOutput TransistorOutput6 { get; } = new TransistorOutput("O.6", false, 200, 250);
        public TransistorOutput TransistorOutput7 { get; } = new TransistorOutput("O.7", false, 210, 260);
        public TransistorOutput TransistorOutput8 { get; } = new TransistorOutput("O.8", false, 220, 270);
        public DigitalInput DigitalInput1 { get; } = new DigitalInput("I1", false);
        public DigitalInput DigitalInput2 { get; } = new DigitalInput("I2", false);
        public DigitalInput DigitalInput3 { get; } = new DigitalInput("I3", false);
        public DigitalInput DigitalInput4 { get; } = new DigitalInput("I4", false);
        public DigitalInput DigitalInput5 { get; } = new DigitalInput("I5", false);
        public DigitalInput DigitalInput6 { get; } = new DigitalInput("I6", false);
        public DigitalInput DigitalInput7 { get; } = new DigitalInput("I7", false);
        public DigitalInput DigitalInput8 { get; } = new DigitalInput("I8", false);
        public AnalogicalInput AnalogicaInput1 { get; } = new AnalogicalInput("A1", false, 100);
        public AnalogicalInput AnalogicaInput2 { get; } = new AnalogicalInput("A2", false, 0);
        public AnalogicalInput AnalogicaInput3 { get; } = new AnalogicalInput("A3", false, 0);
        public AnalogicalInput AnalogicaInput4 { get; } = new AnalogicalInput("A4", false, 0);
        public ObservableCollection<DigitalInput> DigitalInputsViewModel { get; set; } = new ObservableCollection<DigitalInput>();
        public ObservableCollection<TransistorOutput> TransistorOutputsViewModel { get; set; } = new ObservableCollection<TransistorOutput>();
        public ObservableCollection<AnalogicalInput> AnalogicaInputsViewModel { get; set; }
        public ObservableCollection<DigitalInput> DigitalInputs { get; set; }
        public ObservableCollection<TransistorOutput> TransistorOutputs { get; set; }
        public ObservableCollection<AnalogicalInput> AnalogicaInputs { get; set; }

        public IHMViewModel()
        {

            TransistorOutputs = new ObservableCollection<TransistorOutput>
            {
                TransistorOutput1,
                TransistorOutput2,
                TransistorOutput3,
                TransistorOutput4,
                TransistorOutput5,
                TransistorOutput6,
                TransistorOutput7,
                TransistorOutput8,
            };

            DigitalInputs = new ObservableCollection<DigitalInput>
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

            AnalogicaInputs = new ObservableCollection<AnalogicalInput>
            {
                AnalogicaInput1,
                AnalogicaInput2,
                AnalogicaInput3,
                AnalogicaInput4,
            };
        }

        private void SearchComponenteEndAtribui(object item)
        {
            if (item is TransistorOutput transistorOutput)
            {
                if (TransistorOutputsViewModel.Count > 0)
                    TransistorOutputsViewModel.Remove(TransistorOutputsViewModel[0]);
                TransistorOutputsViewModel.Add(SearchTransistorOutput(transistorOutput));
            }
            else if (item is DigitalInput digitalInput)
            {
                if (DigitalInputsViewModel.Count > 0)
                    DigitalInputsViewModel.Remove(DigitalInputsViewModel[0]);
                DigitalInputsViewModel.Add(SearchDigitalInput(digitalInput));
            }
            else if (item is AnalogicalInput analogicaInput)
            {
                if (AnalogicaInputsViewModel.Count > 0)
                    AnalogicaInputsViewModel.Remove(AnalogicaInputsViewModel[0]);
                AnalogicaInputsViewModel.Add(SearchAnalogicaInput(analogicaInput));
            }
        }
        public void AtribuiComponenteSelecionado(object item)
        { 
            SearchComponenteEndAtribui(item);      
        }

        public TransistorOutput SearchTransistorOutput(TransistorOutput transistor)
        {

            foreach (var item in TransistorOutputs)
            {
                if (String.Compare(transistor.Nome, item.Nome) == 0)
                    return item;
            }
            return null;
        }

        public DigitalInput SearchDigitalInput(DigitalInput digital)
        {

            foreach (var item in DigitalInputs)
            {
                if (String.Compare(digital.Nome, item.Nome) == 0)
                    return item;
            }
            return null;
        }

        public AnalogicalInput SearchAnalogicaInput(AnalogicalInput analogica)
        {

            foreach (var item in AnalogicaInputs)
            {
                if (String.Compare(analogica.Nome, item.Nome) == 0)
                    return item;
            }
            return null;
        }
    }

}
