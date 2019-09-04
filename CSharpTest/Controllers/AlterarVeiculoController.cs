using CSharpTest.Dados.Implementacoes;
using CSharpTest.Dados.Interfaces;
using CSharpTest.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CSharpTest.Controllers
{
    public class AlterarVeiculoController : Controller
    {

        private readonly IVeiculoDAL _IVeiculoDAL;


        public AlterarVeiculoController()
        {
            _IVeiculoDAL = new VeiculoDAL();
        }


        public AlterarVeiculoController(IVeiculoDAL veiculoDAL)
        {
            _IVeiculoDAL = veiculoDAL;
        }


   
        public ActionResult Index(string COD_CHASSI)
        {
            VeiculoViewModel veiculo = new VeiculoViewModel();

            try
            {
                veiculo = _IVeiculoDAL.GetVeiculoByChassi(COD_CHASSI);
            }
            catch (Exception)
            {

                throw new Exception("Desculpe, não foi possível alterar o veículo.");
            }

            return View("Index", veiculo);
        }


        [HttpGet]
        public ActionResult Update(string COD_CHASSI)
        {
            VeiculoViewModel veiculo = new VeiculoViewModel();

            try
            {
                veiculo = _IVeiculoDAL.GetVeiculoByChassi(COD_CHASSI);
            }
            catch (Exception)
            {

                throw new Exception("Desculpe, não foi possível alterar o veículo.");
            }

            return View("Index", veiculo);
        }

        [HttpPost]
        public ActionResult Alterar(VeiculoViewModel veiculo)
        {
            try
            {
                bool put = _IVeiculoDAL.AlterarVeiculo(veiculo);
            }
            catch (Exception)
            {
                throw new Exception("Desculpe, não foi possível alterar o veículo.");
            }
            return RedirectToAction("PesquisarVeiculo", "Index");
        }
    }
}