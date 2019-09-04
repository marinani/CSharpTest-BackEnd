using CSharpTest.Dados.DAO;
using CSharpTest.Dados.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest.Dados.Implementacoes
{
    public class DataContextFactory : IDataContextFactory
    { 
        public CSharpTestEntities Create()
        {
            return new CSharpTestEntities();
        }
    }
}
