using IHM.Models;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace IHM.ViewModels
{
    public class IHMViewModel
    {
        public TransistorOutput TransistorOutput1 { get; } = new TransistorOutput("O.1", false, 150, 200);
        public TransistorOutput TransistorOutput2 { get; } = new TransistorOutput("O.2", false, 160, 210);

        public ObservableCollection<TransistorOutput> TransistorOutputs { get; set; }
        public ObservableCollection<TransistorOutput> TransistorOutputsViewModel { get; set; } = new ObservableCollection<TransistorOutput>();

        public ObservableCollection<DigitalInput> DigitalInputs { get; set; }

        public ObservableCollection<object> Teste { get; set; }
        public IHMViewModel()
        {

            TransistorOutputs = new ObservableCollection<TransistorOutput>
            {
                TransistorOutput1,
                TransistorOutput2,
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
