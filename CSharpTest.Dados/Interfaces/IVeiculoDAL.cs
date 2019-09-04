using CSharpTest.Dados.DAO;
using CSharpTest.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest.Dados.Interfaces
{
    public interface IVeiculoDAL
    {
        List<TB_CHASSI> GetVeiculosByChassi(string chassi);
        bool CadastrarVeiculo(VeiculoViewModel model);
        bool AlterarVeiculo(VeiculoViewModel model);
        VeiculoViewModel GetVeiculoByChassi(string chassi);

    }
}
