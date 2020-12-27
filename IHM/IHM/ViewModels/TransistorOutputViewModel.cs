using IHM.Models;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace IHM.ViewModels
{
    public class TransistorOutputViewModel
    {
        public TransistorOutput TransistorOutput1 { get; } = new TransistorOutput("O.1", false, 150, 0, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla elit dolor, convallis non interdum.");
        public TransistorOutput TransistorOutput2 { get; } = new TransistorOutput("O.2", false, 150, 0, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla elit dolor, convallis non interdum.");

        public ObservableCollection<TransistorOutput> TransistorOutputs { get; set; }
        public ObservableCollection<TransistorOutput> TransistorOutputs_ { get; set; } = new ObservableCollection<TransistorOutput>();

        public ICommand PesquisaTransistorOutputCommand { get; private set; }
        public ObservableCollection<DigitalInput> DigitalInputs { get; set; }

        public ObservableCollection<object> Teste { get; set; }
        public TransistorOutputViewModel()
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
                if (TransistorOutputs_.Count > 0)
                    TransistorOutputs_.Remove(TransistorOutputs_[0]);
                TransistorOutputs_.Add(SearchTransistorOutput(transistorOutput));
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
