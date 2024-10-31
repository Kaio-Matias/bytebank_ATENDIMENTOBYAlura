using bytebank.Modelos.Conta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ATENDIMENTO.bytebank.Util
{
    public class ListaDeContasCorrentes
    {
        private ContaCorrente[] _itens = null;
        private int _proximaPossicao = 0;
        public ListaDeContasCorrentes(int tamanhoInicial=5)
        {
                _itens = new ContaCorrente[tamanhoInicial];
        }

        public void Adicionar(ContaCorrente item)
        {
            Console.WriteLine($"Adicionando nova possição {_proximaPossicao}");
            _itens[_proximaPossicao] = item;   
            _proximaPossicao++; 
        }

    }
}
