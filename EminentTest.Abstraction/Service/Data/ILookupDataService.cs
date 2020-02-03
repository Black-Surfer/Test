using EminentTest.DB.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EminentTest.Abstraction.Service.Data
{
    public interface ILookupDataService
    {
        public Task<IEnumerable<Lookup>> GetLookupByType(string type);
    }
}
