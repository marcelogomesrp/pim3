using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmCondominio.model
{
    public class Aluno
    {
        public String Nome { get; set; }
        public Decimal NotaB1 { get; set; }
        public Decimal NotaB2 { get; set; }
        public Decimal Media
        {
            get { return (NotaB1 + NotaB2) / 2; }
        }
        public Boolean IsAprovado
        {
            get { return Media == 5; }
        }
    }
}
