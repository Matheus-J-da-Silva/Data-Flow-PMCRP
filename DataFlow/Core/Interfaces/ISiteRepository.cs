using Domain.Entities;

namespace Core.interfaces{

public interface ISiteRepository
{
    Task<Sites> ViewSitesAsync(string Name);
    Task<Sites>DeleteSistesAsync(string Name);
    Task<Sites>UpdateSite(string Name, string Link, bool Active);
    Task<Sites>CreateSite(string Name, string Link);
    Task<IEnumerable<Sites>>ListAllSitesAsync();
    
}


}
