using ListadeContatosXamarin.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListadeContatosXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AdicionarContatoView : ContentPage
    {
        public AdicionarContatoView()
        {
            InitializeComponent();
            BindingContext = new AdicionarContatoViewModel();
        }
    }
}