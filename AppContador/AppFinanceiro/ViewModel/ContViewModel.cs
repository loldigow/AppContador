using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Xamarin.Forms;

namespace AppFinanceiro.ViewModel
{
    public partial class ContViewModel : ObservableObject
    {
        [ObservableProperty]
        int contador;

        [ObservableProperty]
        Color corTexto;

        [RelayCommand]
        void Adicione()
        {
            Adicione(1);
        }

        [RelayCommand]
        void Remova()
        {
            Adicione(-1);
        }

        [RelayCommand]
        void Reset()
        {
            Adicione(Contador * -1);
        }

        void Adicione(int valor)
        {
            Contador += valor;
            CorTexto = Contador >= 0 ? Color.DarkGray : Color.Red;
        }

        public ContViewModel()
        {
            Contador = 0;
        }
    }
}
