using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
    class Escola
    {
        private Disciplina[] disciplinas = new Disciplina[10];
        private int i = 0;
        public void Inserir(Disciplina x)
        {
            disciplinas[i] = x;
            i++;
        }
        public Disciplina[] Listar()
        {
            Disciplina[] vetor = new Disciplina[i];
            Array.Copy(disciplinas, vetor, i);
            return vetor;
        }
        public Disciplina Menor()
        {
            if (i == 1) return disciplinas[0];
            Disciplina menor = disciplinas[0];
            for (int p = 1; p <= i - 1; p++)
            {
                if (disciplinas[i].GetMedia() > menor.GetMedia()) menor = disciplinas[i];
            }
            return menor;
        }
    }
}
