using CSharpTest.Dados.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest.Dados.Interfaces
{
    public interface IDataContextFactory
    {
        CSharpTestEntities Create();
    }
}
