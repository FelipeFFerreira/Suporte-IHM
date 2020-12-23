using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using IHM.Models;

namespace IHM.Views
{
    class OpcaoEscolhaTemplateSelector : DataTemplateSelector
    {
        public DataTemplate Nenhum { get; set; }
        public DataTemplate ExpanderTransistorOutput { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            if (item is TransistorOutput)
                return ExpanderTransistorOutput;

            return Nenhum;
        }
    }
}
