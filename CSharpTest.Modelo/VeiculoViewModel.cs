using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace CSharpTest.Modelo
{
    public class VeiculoViewModel
    {

       
        public string COD_CHASSI { get; set; }
       
        public string TIPO_VEICULO { get; set; }
       
        public int NUM_PASSAGEIROS { get; set; }
        public Nullable<System.DateTime> DT_CADASTRO { get; set; }
        public Nullable<System.DateTime> DT_ALTERACAO { get; set; }
        public string COR { get; set; }
    }
}
