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
    }
}
