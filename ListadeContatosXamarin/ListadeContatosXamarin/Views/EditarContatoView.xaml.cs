using ListadeContatosXamarin.Models;
using ListadeContatosXamarin.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListadeContatosXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditarContatoView : ContentPage
    {
        public EditarContatoView(Contato contatoSelecionado)
        {
            InitializeComponent();
            BindingContext = new EditarContatoViewModel(contatoSelecionado);
        }
    }
}