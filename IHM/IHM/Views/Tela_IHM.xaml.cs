using System;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using IHM.ViewModels;

namespace IHM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Tela_IHM : ContentPage
    {
        SynchronizationContext synchronizationContext;
        IHMViewModel modeloApresentacao;
        public Tela_IHM()
        {
            synchronizationContext = SynchronizationContext.Current;
            BindingContext = modeloApresentacao = new IHMViewModel();
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            if (sender is BindableObject bindableObject)
                modeloApresentacao.AtribuiComponenteSelecionado(bindableObject.BindingContext);

        }
    }
}