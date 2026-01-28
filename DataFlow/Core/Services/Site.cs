using Core.interfaces;
using Domain.Entities;

namespace Core.Services
{
    public class SiteRepository
    {
        private readonly ISiteRepository _repository;

        public SiteRepository(ISiteRepository repository)
        {
            _repository = repository;
        }

        public void CriateSite(string nome, string link, bool active,DateTime createdat)
        {

            var site =  new Sites(Guid.NewGuid(),nome,link,active,createdat);
            
            _repository.CreateSite(site);
    

        }



    }
}