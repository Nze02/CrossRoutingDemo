using Entities;
using Microsoft.EntityFrameworkCore;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repository
{
    public class CoinageCompanyRepository : RepositoryBase<CoinageCompany>, ICoinageCompanyRepository
    {
        private readonly ApplicationDbContext _db;

        public CoinageCompanyRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public async Task<IEnumerable<CoinageCompany>> GetAllEcoCompaniesAsync(bool trackChanges) =>
            await FindAll(trackChanges)
            .OrderBy(e => e.CompanyOID)
            .ToListAsync();

        public async Task<CoinageCompany> GetEcoCompanyAsync(int CompanyOID, bool trackChanges) =>
            await FindByCondition(e => e.CompanyOID.Equals(CompanyOID), trackChanges)
            .SingleOrDefaultAsync();


        public void CreateEcoCompany(CoinageCompany ecoCompany) => Create(ecoCompany);

        public void DeleteEcoCompany(CoinageCompany ecoCompany)
        {
            Delete(ecoCompany);
        }
    }
}
