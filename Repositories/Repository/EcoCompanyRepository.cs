using CrossRouting;
using CrossRouting.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repository
{
    public class EcoCompanyRepository : RepositoryBase<EcoCompany>, IEcoCompanyRepository
    {
        private readonly ApplicationDbContext _db;

        public EcoCompanyRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public async Task<IEnumerable<EcoCompany>> GetAllEcoCompaniesAsync(bool trackChanges) =>
            await FindAll(trackChanges)
            .OrderBy(e => e.CompanyOID)
            .ToListAsync();

        public async Task<EcoCompany> GetEcoCompanyAsync(int CompanyOID, bool trackChanges) =>
            await FindByCondition(e => e.CompanyOID.Equals(CompanyOID), trackChanges)
            .SingleOrDefaultAsync();


        public void CreateEcoCompany(EcoCompany ecoCompany) => Create(ecoCompany);

        public void DeleteEcoCompany(EcoCompany ecoCompany)
        {
            Delete(ecoCompany);
        }
    }
}
