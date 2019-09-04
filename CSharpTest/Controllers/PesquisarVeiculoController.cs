using CSharpTest.Dados.DAO;
using CSharpTest.Dados.Implementacoes;
using CSharpTest.Dados.Interfaces;
using CSharpTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CSharpTest.Controllers
{
    public class PesquisarVeiculoController : Controller
    {

        private readonly IVeiculoDAL _IVeiculoDAL;


        public PesquisarVeiculoController()
        {
            _IVeiculoDAL = new VeiculoDAL();
        }


        public PesquisarVeiculoController(IVeiculoDAL veiculoDAL)
        {
            _IVeiculoDAL = veiculoDAL;
        }




        public ActionResult Index(List<VeiculoViewModels> model, string COD_CHASSI)
        {
            List<VeiculoViewModels> lst = new List<VeiculoViewModels>();
            if (!String.IsNullOrEmpty(COD_CHASSI))
            {
               
                try
                {
                    var chassi = _IVeiculoDAL.GetVeiculosByChassi(COD_CHASSI);

                    foreach (var item in chassi)
                    {
                        VeiculoViewModels obj = new VeiculoViewModels();
                        obj.COD_CHASSI = item.COD_CHASSI;
                        obj.TIPO_VEICULO = item.TIPO_VEICULO;
                        obj.NUM_PASSAGEIROS = item.NUM_PASSAGEIROS;
                        obj.COR = item.COR;
                        obj.DT_CADASTRO = item.DT_CADASTRO;
                        obj.DT_ALTERACAO = item.DT_ALTERACAO;
                        lst.Add(obj);
                    }



                }
                catch (Exception ex)
                {

                    throw;
                }
            }         

            return View(lst);
        }


        public ActionResult PesquisarVeiculo(VeiculoViewModels veiculo)
        {
            return View();
        }
    }
}