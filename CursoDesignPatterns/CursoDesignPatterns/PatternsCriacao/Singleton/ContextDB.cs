using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.PatternsCriacao.Singleton
{
    public class ContextDB
    {
        private static ContextDB _instancia = null;
        private ContextDB()
        {
        }

        public static ContextDB Instancia 
        { 
            get
            {
                if (_instancia == null)
                {
                    _instancia = new ContextDB();
                    Console.WriteLine("Instancia ContextDB criada com sucesso!");
                }

                return _instancia;
            }
        }

        public void ExecutaQuery(string query)
        {
            Console.WriteLine(query);
        }
    }
}
