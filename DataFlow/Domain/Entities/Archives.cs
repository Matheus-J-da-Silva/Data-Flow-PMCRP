namespace Domain.Entities
{
    
    public class ArchiveEntities
    {
        Guid Id {get;set;}
        int CollectorId {get;set;}
        string ?Name {get;set;}
        DateTime CreatedAt{get;set;}
        enum Status{NaoIniciado,EmAndamento,Sucesso}

        
        


    }
}