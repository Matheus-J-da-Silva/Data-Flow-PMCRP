using Core.interfaces;

namespace Core.Services
{
    public class SiteService
    {
        private readonly ISiteRepository _repository;

        public SiteService(ISiteRepository repository)
        {
            _repository = repository;
        }




    }
}