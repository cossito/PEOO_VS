using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_time
{
    internal class Time
    {
        private string nome, estado;
        private Jogador[] jogadores = new Jogador[11];
        private int k = 0;
        public void SetNome(string n)
        {
            this.nome = n;
        }
        public void SetEstado(string e)
        {
            this.estado = e;
        }
        public void Inserir(Jogador j)
        {
            jogadores[k] = j;
            k++;
        }
        public Jogador[] Listar()
        {
            Jogador[] vetor = new Jogador[k];
            Array.Copy(jogadores, vetor, k);
            return vetor;
        }
        public Jogador Artilheiro()
        {
            if (k == 1) return jogadores[0];
            Jogador art = jogadores[0];
            for (int i = 1; i <= k - 1; i++)
            {
                if (jogadores[i].GetGols() > art.GetGols()) art = jogadores[i];
            }
            return art;
        }
        public override string ToString()
        {
            return $"o artilheiro do time {nome} do estado {estado} é o {Artilheiro().GetNome()}, com {Artilheiro().GetGols()} gols.";
        }
    }
}
