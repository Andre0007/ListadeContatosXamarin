using ListadeContatosXamarin.BD.Interfaces;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListadeContatosXamarin.BD.Services
{
    public class PaginaService : IPaginaService
    {
        public async Task<bool> DisplayAlert(string title, string message, string ok, string cancel)
        {
            return await App.Current.MainPage.DisplayAlert(title, message, ok, cancel);
        }

        public async Task DisplayAlert(string title, string message, string cancel)
        {
            await Application.Current.MainPage.DisplayAlert(title, message, cancel);
        }

        public async Task PushModalAsync(Page page)
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(page);
        }

        public async Task PushAsync(Page page)
        {
            await App.Current.MainPage.Navigation.PushAsync(page);
        }

        public async Task PopModalAsync()
        {
            await App.Current.MainPage.Navigation.PopModalAsync();
        }
    }
}