namespace Domain.Entities
{

public class Collectors
{
public Guid Id {get;set;}
public int SiteId {get;set;}
public DateTime StartedAt {get;set;}
public DateTime FinishedAt {get;set;}
public enum Status {NaoIniciado,EmAndamento,Sucesso}

} 
}
