using IHM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace IHM.Controls
{
    class CtrTransitorOutput : ContentView
    {
        public ObservableCollection<TransistorOutput> TransistorOutputs { get; set; }

        public static readonly BindableProperty
            ApresentacaoDadosTitlePropperty = BindableProperty.Create(
                nameof(ApresentacaoDadosTitle),
                typeof(string),
                typeof(CtrTransitorOutput),
                string.Empty);

        public static readonly BindableProperty
            ApresentacaoDadosValor1Propperty = BindableProperty.Create(
                nameof(ApresentacaoDadosValor1),
                typeof(string),
                typeof(CtrTransitorOutput),
                string.Empty);

        public static readonly BindableProperty
            ApresentacaoDadosValor2Propperty = BindableProperty.Create(
                nameof(ApresentacaoDadosValor2),
                typeof(string),
                typeof(CtrTransitorOutput),
                string.Empty);

        public static readonly BindableProperty CardTitleProperty =
            BindableProperty.Create(nameof(CtrTransitorOutput),
                typeof(string),
                typeof(CtrTransitorOutput),
                string.Empty);
        
        public string ApresentacaoDadosTitle
        {
            get => (string)GetValue(ApresentacaoDadosTitlePropperty);
            set => SetValue(ApresentacaoDadosTitlePropperty, value);
        }

        public string ApresentacaoDadosValor1
        {
            get => (string)GetValue(ApresentacaoDadosValor1Propperty);
            set => SetValue(ApresentacaoDadosValor1Propperty, value);
        }

        public string ApresentacaoDadosValor2
        {
            get => (string)GetValue(ApresentacaoDadosValor2Propperty);
            set => SetValue(ApresentacaoDadosValor2Propperty, value);
        }

      

    }
}
