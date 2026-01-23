namespace Domain.Entities
{

public class CollectorEntities
{
Guid Id {get;set;}
int SiteId {get;set;}
DateTime StartedAt {get;set;}
DateTime FinishedAt {get;set;}
enum Status{NaoIniciado,EmAndamento,Sucesso}

} 
}
