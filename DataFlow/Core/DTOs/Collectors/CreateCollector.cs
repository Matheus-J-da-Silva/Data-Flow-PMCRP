namespace Core.DTOs.Collectors
{
    public class CreateCollector
    {
        public Guid Id {get;set;}
        public int SiteId {get;set;}
        public DateTime StartedAt {get;set;}
        public DateTime FinishedAt {get;set;}
        public enum Status{NaoIniciado,EmAndamento,Sucesso}

    }


}