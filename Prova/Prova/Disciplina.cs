using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
    class Disciplina
    {
        private string nome;
        private int media;
        public Disciplina(string n, int m)
        {
            if (n != "") this.nome = n;
            if (m >= 0) this.media = m;

        }
        public void SetNome(string n)
        {
            if (n != "") this.nome = n;
        }
        public void SetMedia(int m)
        {
            if (m >= 0) this.media = m;
        }
        public string GetNome()
        {
            return nome;
        }
        public int GetMedia()
        {
            return media;
        }
        public override string ToString()
        {
            return $"A média da disciplina {nome} é {media}";
        }
    }
}
