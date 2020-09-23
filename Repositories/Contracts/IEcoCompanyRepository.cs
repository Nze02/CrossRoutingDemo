using CrossRouting.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    public interface IEcoCompanyRepository
    {
        Task<IEnumerable<EcoCompany>> GetAllEcoCompaniesAsync(bool trackChanges);
        Task<EcoCompany> GetEcoCompanyAsync(int BusinessSectorOID, bool trackchanges);
        void CreateEcoCompany(EcoCompany ecoCompany);
    }
}
