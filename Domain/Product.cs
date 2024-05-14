namespace AMS3A.Sales.Domain
{
    public class Product
    {
        public Guid Id{get;set;} = Guid.NewGuid();
        
        public string? Description{get;set;}
        
        public double Stock{get;set;}
        
        public double Price{get;set;}
        
        public string? ImageUrl{get;set;}
        
        public  bool IsActive{get;set;}
        
        public DateTime CreatedDate {get;set;}
        
        public Category Category{get;set;} 
       
        public Guid CategoryId{get;set;}
    }
}