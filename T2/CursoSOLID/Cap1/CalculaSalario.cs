using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoSOLID
{
    public class CalculaSalario
    {
        public double Calcula(Funcionario funcionario)
        {
            return funcionario.Cargo.RegraDesconto.Calcula(funcionario);
        }
    }
}

