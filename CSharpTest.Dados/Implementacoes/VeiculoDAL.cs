using CSharpTest.Dados.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using CSharpTest.Dados.DAO;
using CSharpTest.Dados.Implementacoes;
using CSharpTest.Dados.DAO;
using CSharpTest.Modelo;

namespace CSharpTest.Dados.Implementacoes
{
    public class VeiculoDAL : IVeiculoDAL
    {
        private readonly IDataContextFactory _context;



        public VeiculoDAL()
        {
            _context = new DataContextFactory();



        }

        public VeiculoDAL(IDataContextFactory context)
        {
            _context = context;
        }

        public List<TB_CHASSI> GetVeiculosByChassi(string chassi)
        {
            CSharpTestEntities tEntity = new CSharpTestEntities();
            List<TB_CHASSI> lstVeiculos = new List<TB_CHASSI>();

            try
            {
                lstVeiculos = tEntity.TB_CHASSI.Where(x => x.COD_CHASSI.Contains(chassi)).ToList();

                return lstVeiculos.ToList();
            }
            catch (Exception ex)
            {

                throw;
            }
        }


        public VeiculoViewModel GetVeiculoByChassi(string chassi)
        {
            CSharpTestEntities tEntity = new CSharpTestEntities();
            VeiculoViewModel model = new VeiculoViewModel();


            try
            {
               var veiculo = tEntity.TB_CHASSI.Where(x => x.COD_CHASSI == chassi).FirstOrDefault();

                if(veiculo != null)
                {
                    model.COD_CHASSI = veiculo.COD_CHASSI;
                    model.TIPO_VEICULO = veiculo.TIPO_VEICULO;
                    model.NUM_PASSAGEIROS = veiculo.NUM_PASSAGEIROS;
                    model.COR = veiculo.COR;
                    return model;
                }
                else
                {
                    return null;
                }

               
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public bool CadastrarVeiculo(VeiculoViewModel model)
        {
            CSharpTestEntities tEntity = new CSharpTestEntities();
            TB_CHASSI obj = new TB_CHASSI();
            try
            {
                if (model != null)
                {
                    obj.COD_CHASSI = model.COD_CHASSI;
                    obj.TIPO_VEICULO = model.TIPO_VEICULO;
                    obj.NUM_PASSAGEIROS = model.NUM_PASSAGEIROS;
                    obj.COR = model.COR;
                    obj.DT_CADASTRO = DateTime.Now;
                    obj.DT_ALTERACAO = DateTime.Now;

                    tEntity.TB_CHASSI.Add(obj);
                    tEntity.SaveChanges();

                }

                return true;
            }
            catch (Exception)
            {

                throw;
            }           

        }

        public bool AlterarVeiculo(VeiculoViewModel model)
        {
            CSharpTestEntities tEntity = new CSharpTestEntities();
            
            try
            {
                var obj = tEntity.TB_CHASSI.Where(x => x.COD_CHASSI == model.COD_CHASSI).FirstOrDefault();


                if (obj != null)
                {
                    obj.COD_CHASSI = model.COD_CHASSI;
                    obj.TIPO_VEICULO = model.TIPO_VEICULO;
                    obj.COR = model.COR;
                    obj.DT_ALTERACAO = DateTime.Now;
                    tEntity.SaveChanges();
                    return true;
                }

                else
                {
                    return false;
                }

                return true;
            }
            catch (Exception)
            {

                throw;
            }

        }

    }


    
}
