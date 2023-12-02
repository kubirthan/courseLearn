using System.ComponentModel.DataAnnotations;

namespace learn.Model
{
    public class Company
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public String Name { get; set; }

        [Required]
        public String Location { get; set; }
    }
}
