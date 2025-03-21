using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid._01_SRP.Bad
{
    public class Report
    {
        public void Generate() // Única responsabilidade é de gerar o relatório
        {
        }

        public void Print()
        {
        }

        public void Save()
        {
        }
    }
}
