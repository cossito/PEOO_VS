using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EscolaApp
{
    static class NProfessor
    {
        private static List<Professor> professores = new List<Professor>();
        public static void Inserir(Professor p)
        {
            Abrir();
            // procurar o maior Id
            int id = 0;
            foreach (Professor obj in professores)
                if (obj.Id > id) id = obj.Id;
            p.Id = id + 1;
            professores.Add(p);
            Salvar();
        }
        public static List<Professor> Listar()
        {
            Abrir();
            return professores;
        }
        public static void Excluir(Professor p)
        {
            Abrir();
            Professor x = null;
            // percorrer a lista de professores procurando ao id informado (p.Id)
            foreach (Professor obj in professores)
                if (obj.Id == p.Id) x = obj;
            if (x != null) professores.Remove(x);
            Salvar();
        }
        public static void Atualizar(Professor p)
        {
            Abrir();
            // percorrer a lista de professores procurando ao id informado (p.Id)
            foreach (Professor obj in professores)
                if (obj.Id == p.Id)
                {
                    obj.Nome = p.Nome;
                    obj.Matricula = p.Matricula;
                    obj.Area = p.Area;
                }
            Salvar();
        }
        public static void Abrir()
        {
            StreamReader f = null;
            try
            {
                // objeto que transforma uma lista de professores em texto em XML
                XmlSerializer xml = new XmlSerializer(typeof(List<Professor>));
                // objeto que abre um texto em um arquivo
                f = new StreamReader("./professores.xml");
                // chama a operação de desserialização informando o destino do texto XML
                professores = (List<Professor>)xml.Deserialize(f);
                // fecha o arquivo
            }
            catch
            {
                professores = new List<Professor>();
            }
            if (f != null) f.Close();
        }
        public static void Salvar()
        {
            // objeto que transforma uma lista de professores em texto em XML
            XmlSerializer xml = new XmlSerializer(typeof(List<Professor>));
            // objeto que grava um texto em um arquivo
            StreamWriter f = new StreamWriter("./professores.xml", false);
            // chama a operação de serialização informando o destino do texto XML
            xml.Serialize(f, professores);
            // fecha o arquivo
            f.Close();
        }
    }
}
