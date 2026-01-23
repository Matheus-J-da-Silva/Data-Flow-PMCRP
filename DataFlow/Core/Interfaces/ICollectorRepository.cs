namespace interfaces
{
    
    public interface ICollectorRepository
    {
        
        Task AddCollector();
        Task InnitCollector(string siteId);
        Task ViewStatus(string status);




    }
}