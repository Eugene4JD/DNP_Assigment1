namespace DNPAssigment1.Models
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        public HairColor HairColor { get; set; } 
        public EyeColor EyeColor { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }
    }
}