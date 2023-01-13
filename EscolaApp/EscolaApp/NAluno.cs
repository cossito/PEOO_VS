using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EscolaApp
{
    static class NAluno
    {
        private static List<Aluno> alunos = new List<Aluno>();
        public static void Inserir(Aluno a)
        {
            Abrir();
            // procurar o maior Id
            int id = 0;
            foreach (Aluno obj in alunos)
                if (obj.Id > id) id = obj.Id;
            a.Id = id + 1;
            alunos.Add(a);
            Salvar();
        }
        public static List<Aluno> Listar()
        {
            Abrir();
            return alunos;
        }
        public static void Excluir(Aluno a)
        {
            Abrir();
            Aluno x = null;
            // percorrer a lista de alunos procurando ao id informado (a.Id)
            foreach (Aluno obj in alunos)
                if (obj.Id == a.Id) x = obj;
            if (x != null) alunos.Remove(x);
            Salvar();
        }
        public static void Atualizar(Aluno a)
        {
            Abrir();
            // percorrer a lista de aluno procurando ao id informado (a.Id)
            foreach (Aluno obj in alunos)
                if (obj.Id == a.Id)
                {
                    obj.Nome = a.Nome;
                    obj.Matricula = a.Matricula;
                    obj.Email = a.Email;
                    obj.IdTurma = a.IdTurma;
                }
            Salvar();
        }
        public static void Abrir()
        {
            StreamReader f = null;
            try
            {
                // objeto que transforma uma lista de turmas em texto em XML
                XmlSerializer xml = new XmlSerializer(typeof(List<Aluno>));
                // objeto que abre um texto em um arquivo
                f = new StreamReader("./alunos.xml");
                // chama a operação de desserialização informando o destino do texto XML
                alunos = (List<Aluno>)xml.Deserialize(f);
                // fecha o arquivo
            }
            catch
            {
                alunos = new List<Aluno>();
            }
            if (f != null) f.Close();
        }
        public static void Salvar()
        {
            // objeto que transforma uma lista de turmas em texto em XML
            XmlSerializer xml = new XmlSerializer(typeof(List<Aluno>));
            // objeto que grava um texto em um arquivo
            StreamWriter f = new StreamWriter("./alunos.xml", false);
            // chama a operação de serialização informando o destino do texto XML
            xml.Serialize(f, alunos);
            // fecha o arquivo
            f.Close();
        }
        public static void Matricular(Aluno a, Turma t)
        {
            a.IdTurma = t.Id;
            Atualizar(a);
        }
        public static List<Aluno> Listar(Turma t)
        {
            Abrir();
            // percorrer a lista de aluno procurando o id da turma
            List<Aluno> diario = new List<Aluno>();
            foreach (Aluno obj in alunos)
                if (obj.IdTurma == t.Id) diario.Add(obj);
            return diario;
        }
    }
}
