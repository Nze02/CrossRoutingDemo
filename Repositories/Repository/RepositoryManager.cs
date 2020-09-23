using CrossRouting;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private ApplicationDbContext _db;
        private IEcoCompanyRepository ecoCompanyRepository;
        private ICoinageCompanyRepository coinageCompanyRepository;

        public RepositoryManager(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEcoCompanyRepository CompanyRepository {
            get { 
                if(ecoCompanyRepository == null)
                {
                    ecoCompanyRepository = new EcoCompanyRepository(_db);
                }

                return ecoCompanyRepository;
            }
        }

        public ICoinageCompanyRepository CoinageCompanyRepository
        {
            get
            {
                if (coinageCompanyRepository == null)
                {
                    coinageCompanyRepository = new CoinageCompanyRepository(_db);
                }

                return coinageCompanyRepository;
            }
        }
    }
}
