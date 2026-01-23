using Domain.Entities;

namespace interfaces
{
    
    public interface ICollectorRepository
    {
        
        Task<Collectors> CreateCollector(string SiteId);
        Task<Collectors> DeleteCollector(string SiteId);
        Task<Collectors> ViewCollector(Guid Id);
        Task<IEnumerable<Collectors>>ViewAllCollectors();






    }
}