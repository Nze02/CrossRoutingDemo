using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    public interface ICoinageCompanyRepository
    {
        Task<IEnumerable<CoinageCompany>> GetAllEcoCompaniesAsync(bool trackChanges);
        Task<CoinageCompany> GetEcoCompanyAsync(int BusinessSectorOID, bool trackchanges);
        void CreateEcoCompany(CoinageCompany ecoCompany);
    }
}
