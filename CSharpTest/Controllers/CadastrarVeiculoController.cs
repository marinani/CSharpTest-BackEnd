using CSharpTest.Dados.Implementacoes;
using CSharpTest.Dados.Interfaces;
using CSharpTest.Modelo;
using CSharpTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace CSharpTest.Controllers
{
    public class CadastrarVeiculoController : Controller
    {
        private readonly IVeiculoDAL _IVeiculoDAL;


        public CadastrarVeiculoController()
        {
            _IVeiculoDAL = new VeiculoDAL();
        }


        public CadastrarVeiculoController(IVeiculoDAL veiculoDAL)
        {
            _IVeiculoDAL = veiculoDAL;
        }

      
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(VeiculoViewModel veiculo)
        {
            try
            {
                bool cadastrar = _IVeiculoDAL.CadastrarVeiculo(veiculo);
            }
            catch (Exception)
            {
                throw new Exception("Desculpe, não foi possível cadastrar veículo no momento.");
            }
            return View("Index", veiculo);
        }

        [HttpGet]
        public ActionResult Update(string COD_CHASSI)
        {
            //VeiculoViewModel veiculo = new VeiculoViewModel();

            //try
            //{
            //    veiculo = _IVeiculoDAL.GetVeiculoByChassi(COD_CHASSI);
            //}
            //catch (Exception)
            //{

            //    throw new Exception("Desculpe, não foi possível alterar o veículo.");
            //}
            if(!String.IsNullOrWhiteSpace(COD_CHASSI))
            {
                return RedirectToAction("Index", "AlterarVeiculo", COD_CHASSI);
            }
            else
            {
                return View();
            }
           
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
            return RedirectToAction("PesquisarVeiculo","Index");
        }


    }
}
