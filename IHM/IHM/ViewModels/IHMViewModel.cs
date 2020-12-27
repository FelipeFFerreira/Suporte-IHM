using IHM.Models;
using System;
using System.Collections.ObjectModel;

namespace IHM.ViewModels
{
   
    public class IHMViewModel
    {
        public ObservableCollection<TransistorOutput> TransistorOutputsViewModel { get; set; } = new ObservableCollection<TransistorOutput>();
        public TransistorOutput TransistorOutput1 { get; } = new TransistorOutput("O.1", false, 150, 200);
        public TransistorOutput TransistorOutput2 { get; } = new TransistorOutput("O.2", false, 160, 210);
        public TransistorOutput TransistorOutput3 { get; } = new TransistorOutput("O.3", false, 170, 220);
        public TransistorOutput TransistorOutput4 { get; } = new TransistorOutput("O.4", false, 180, 230);
        public TransistorOutput TransistorOutput5 { get; } = new TransistorOutput("O.5", false, 190, 240);
        public TransistorOutput TransistorOutput6 { get; } = new TransistorOutput("O.6", false, 200, 250);
        public TransistorOutput TransistorOutput7 { get; } = new TransistorOutput("O.7", false, 210, 260);
        public TransistorOutput TransistorOutput8 { get; } = new TransistorOutput("O.8", false, 220, 270);

        public ObservableCollection<TransistorOutput> TransistorOutputs { get; set; }

        public ObservableCollection<DigitalInput> DigitalInputs { get; set; }

        public ObservableCollection<object> Teste { get; set; }
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
                new DigitalInput("I1", false),
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
        }
        public void AtribuiComponenteSelecionado(object item)
        { 
            SearchComponenteEndAtribui(item);      
        }

        public TransistorOutput SearchTransistorOutput(TransistorOutput t)
        {

            foreach (var item in TransistorOutputs)
            {
                if (String.Compare(t.Nome, item.Nome) == 0)
                    return item;
            }
            return null;
        }
    }

}
