namespace Domain.Entities

{
    public class Sites
    {
        
        public Guid Id {get;set;}
        public string ?Name {get;set;}
        public string ?Link {get;set;}
        public bool Active {get;set;}
        public DateTime CreatedAt {get;set;}


    
    public Sites(Guid id, string?name, string?link, bool active, DateTime createdAt)
        {
            if(string.IsNullOrEmpty(name))
                throw new Exception("O nome nao pode ser nulo, ou vazio!!");

            if(string.IsNullOrEmpty(link))
                throw new Exception("O Link não pode ser nulo, ou vazio!!");


        Id = id;
        Name= name;
        Link = link;
        Active = active;
        CreatedAt = createdAt;


        }


    }

}