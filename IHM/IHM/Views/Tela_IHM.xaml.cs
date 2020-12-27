using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using IHM.ModelApresentacao;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using IHM.ViewModels;

namespace IHM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Tela_IHM : ContentPage
    {
        SynchronizationContext synchronizationContext;
        TransistorOutputViewModel modeloApresentacao;
        public Tela_IHM()
        {
            synchronizationContext = SynchronizationContext.Current;
            BindingContext = modeloApresentacao = new TransistorOutputViewModel();
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            if (sender is BindableObject bindableObject)
                modeloApresentacao.AtribuiComponenteSelecionado(bindableObject.BindingContext);

        }
    }
}