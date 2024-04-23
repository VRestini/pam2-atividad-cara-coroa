using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaraCoroa.Models
{
    public class Coin
    {
        // Quando for criar um atributo, utilizar o prop (propriedade)
        public string Lado { get; set; }

        public string Jogar()
        {
            int ladoSorteado = new Random().Next(2);
            Lado = ladoSorteado == 0 ? "Cara" : "Coroa";
           
            return (Lado);
        }

        public string Jogar(string ladoEscolhido)
        {
            int ladoSorteado = new Random().Next(2);
            Lado = ladoSorteado == 0 ? "Cara" : "Coroa";
            string Resultado = Lado == ladoEscolhido 
                ? $"Parabéns, você pediu {ladoEscolhido} e deu {Lado}" 
                : $"Que pena, você pediu {ladoEscolhido} e deu {Lado}";
            return (Resultado);
        }


    }
}
