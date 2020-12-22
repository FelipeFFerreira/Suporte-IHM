using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using IHM.ModelApresentacao;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IHM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Tela_IHM : ContentPage
    {
        SynchronizationContext synchronizationContext;
        ModeloApresentacaoIHM modeloApresentacaoIHM;

        public Tela_IHM()
        {
            synchronizationContext = SynchronizationContext.Current;
            BindingContext = modeloApresentacaoIHM = new ModeloApresentacaoIHM();
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {

        }
    }
}