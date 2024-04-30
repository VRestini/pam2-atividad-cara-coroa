using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using CaraCoroa.Models;
using System.Windows.Input;

namespace CaraCoroa.ViewModels
{
    internal partial class CoinViewModel : ObservableObject // partial significa que tem parte dessa classe tá em outro arquivo
    {
        [ObservableProperty]
        private string _lado;
        [ObservableProperty]
        private string _ladoEscolhido; // quanto tem _ significa que pode ser nulo   
        [ObservableProperty]
        private string _resultado;

        public CoinViewModel() {
            JogarCommand = new Command(Jogar);
        }

        public ICommand JogarCommand { get; }

        public void Jogar()
        {
            Coin coin = new Coin();
            Resultado = coin.Jogar(LadoEscolhido);
        }
    }
}
