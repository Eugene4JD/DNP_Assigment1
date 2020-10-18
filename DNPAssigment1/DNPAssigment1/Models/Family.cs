using System.Collections.Generic;

namespace DNPAssigment1.Models
{
    public class Family
    {
        public string Address { get; set; }
        public List<Adult> Adults { get; set; }
        public List<Child> Children { get; set; }
        public List<Pet> Pets { get; set; }
        
        public int Id { get; set; }

        public Family()
        {
            this.Adults = new List<Adult>();
            this.Children = new List<Child>();
            this.Pets = new List<Pet>();
            this.Address = "UNKNOWN";
        }
        
    }
}