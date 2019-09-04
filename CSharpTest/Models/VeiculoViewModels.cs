using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace CSharpTest.Models
{
    public class VeiculoViewModels
    {
       

        [Display(Name = "Chassi"), Required(ErrorMessage = "O campo 'Chassi' é obrigatório")]
        public string COD_CHASSI { get; set; }
        [Display(Name = "TipoVeiculo"), Required(ErrorMessage = "O campo 'Tipo do Veículo' é obrigatório")]
        public string TIPO_VEICULO { get; set; }
        [Display(Name = "NumPassageiros"), Required(ErrorMessage = "O campo 'Numero de Passageiros' é obrigatório")]
        public int NUM_PASSAGEIROS { get; set; }
        public Nullable<System.DateTime> DT_CADASTRO { get; set; }
        public Nullable<System.DateTime> DT_ALTERACAO { get; set; }
        [Display(Name = "Cor"), Required(ErrorMessage = "O campo 'Cor' é obrigatório")]
        public string COR { get; set; }


        public static List<SelectListItem> LISTA_TIPO_VEICULO
        {
            get
            {
                return new List<SelectListItem>
                {
                    new SelectListItem(){ Text = "Ônibus", Value = "Ônibus" },
                    new SelectListItem(){ Text = "Caminhão", Value = "Caminhão" }
                };
            }
        }
    }
}