using EminentTest.Abstraction.DataAccess;
using EminentTest.Abstraction.Service.Data;
using EminentTest.DB.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EminentTest.Abstraction.Repository
{
    public class LookupRepository : ILookupDataService
    {
        private readonly EminentTestContext _context;
        public LookupRepository(EminentTestContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Lookup>> GetLookupByType(string type)
        {
            var result = await _context.Lookups.Where(x => x.LookupType == type).ToListAsync();
            if (result != null)
                return result;
            return null;
        }
    }
}
