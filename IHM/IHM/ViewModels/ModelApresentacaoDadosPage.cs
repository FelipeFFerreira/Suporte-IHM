using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using IHM.Models;
using System.Collections.ObjectModel;

namespace IHM.ModelApresentacao.Controls
{
    public class ModelApresentacaoDadosPage : ContentView
    {
        public ObservableCollection<TransistorOutput> TransistorOutputs { get; set; }

        public static readonly BindableProperty
            ApresentacaoDadosTitlePropperty = BindableProperty.Create(
                nameof(ApresentacaoDadosTitle),
                typeof(string),
                typeof(ModelApresentacaoDadosPage),
                string.Empty);

        public static readonly BindableProperty
            ApresentacaoDadosValor1Propperty = BindableProperty.Create(
                nameof(ApresentacaoDadosValor1),
                typeof(string),
                typeof(ModelApresentacaoDadosPage),
                string.Empty);

        public static readonly BindableProperty
            ApresentacaoDadosValor2Propperty = BindableProperty.Create(
                nameof(ApresentacaoDadosValor2),
                typeof(string),
                typeof(ModelApresentacaoDadosPage),
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

