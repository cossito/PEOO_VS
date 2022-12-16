using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_time
{
    internal class Jogador
    {
        private string nome, camisa;
        private int gols;
        public void SetNome(string n)
        {
            this.nome = n;
        }
        public void SetCamisa(string c)
        {
            this.camisa = c;
        }
        public void SetGols(int g)
        {
            this.gols = g;
        }
        public string GetNome()
        {
            return nome;
        }
        public int GetGols()
        {
            return gols;
        }
        public override string ToString()
        {
            return $"{nome} - camisa {camisa} - {gols} gols";
        }
    }
}
