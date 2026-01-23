namespace Core.Dtos
{
    public class CreateSite
    {
        public Guid Id{get;set;}
        public string ?Name{get;set;}
        public string ?Link{get;set;}
        public bool Active{get;set;}
        public DateTime CreatedAt{get;set;}

    }


}