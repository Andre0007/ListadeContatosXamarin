using ListadeContatosXamarin.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListadeContatosXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListaDeContatosView : ContentPage
    {
        public ListaDeContatosView()
        {
            InitializeComponent();
            ViewModel = new ListaDeContatosViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            BindingContext = new ListaDeContatosViewModel();
        }

        public ListaDeContatosViewModel ViewModel
        {
            get { return BindingContext as ListaDeContatosViewModel; }
            set { BindingContext = value; }
        }

        private void OnItemSelect(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
                ViewModel.SelecionarContatoCommand.Execute(e.SelectedItem);

            listViewContatos.SelectedItem = null;
        }
    }
}