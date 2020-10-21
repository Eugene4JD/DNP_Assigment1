using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace DNPAssigment1.Models
{
    public class Family
    {
        public string Address { get; set; }
        [Required]
        [MaxLength(2)]
        public List<Adult> Adults { get; set; }
        
        [Required]
        [MaxLength(5)]
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