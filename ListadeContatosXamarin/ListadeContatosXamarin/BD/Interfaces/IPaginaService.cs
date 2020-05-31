using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListadeContatosXamarin.BD.Interfaces
{
    public interface IPaginaService
    {
        Task PushAsync(Page page);
        Task PushModalAsync(Page page);
        Task PopModalAsync();
        Task<bool> DisplayAlert(string title, string message, string ok, string cancel);
        Task DisplayAlert(string title, string message, string cancel);
    }
}