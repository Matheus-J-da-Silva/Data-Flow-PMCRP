using Domain.Entities;

namespace Core.interfaces{

public interface ISiteRepository
{
    public Task CreateSite(Sites sites);
    // Task<Sites> ViewSitesAsync(Sites sites);
    // Task<Sites>DeleteSistesAsync(Sites sites);
    // Task<Sites>UpdateSite(Sites sites);

    // Task<IEnumerable<Sites>>ListAllSitesAsync();
    
}


}
