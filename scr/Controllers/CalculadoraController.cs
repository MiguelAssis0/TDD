using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace scr.Controllers
{
    public class CalculadoraController
    {
        private List<string> historico;

        public CalculadoraController()
        {
            historico = new List<string>();
        }

        public int Somar(int n1,int n2)
        {
            int result = n1 + n2;
            
            historico.Insert(0,$"{n1.ToString()} + {n2.ToString()}");
            return result;
        }

        public int Subtrair(int n1,int n2)
        {
            int result = n1 - n2;
            historico.Insert(0, $"{n1.ToString()} - {n2.ToString()}");
            return result;
        }

        public int Multiplicar(int n1,int n2)
        {
            int result = n1 * n2;
            historico.Insert(0, $"{n1.ToString()} * {n2.ToString()}");
            return result;
        }

        public int Dividir(int n1,int n2)
        {
            int result = n1 / n2;
            
            historico.Insert(0, $"{n1.ToString()} / {n2.ToString()}");
            return result;
        }

        public List<string> Historico()
        {
            if(historico.Count > 3)
            {
                historico.RemoveRange(3, historico.Count - 3);
            }
            return historico;
        }
    }
}