using System.Collections.Generic;

namespace Exemplo_MVC.Models
{
    public class ListaAluno
    {
        private static List<Aluno> Lista = new List<Aluno>();

        public static void Incluir(Aluno aluno)
        {
            Lista.Add(aluno);
        }

        public static double Total()
        {
            double total = 0;
            for (int i = 0; i < Lista.Count; i++)
            {
                total = total + Lista[i].Nota;
            }

            return total;
        }

        public static List<Aluno> Listar()
        {
            return Lista;
        }
    }
}