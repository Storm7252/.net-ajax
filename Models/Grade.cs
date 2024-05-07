using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cascadind_dropdown.Models
{
    public class Grade
    {
        [Key]
        public int Grade_Id { get; set; }

        public string Grade_Name { get; set; }

        //-------creating relation to designation 
        public int Desig_Id { get; set; }
        [ForeignKey("Desig_Id")]
        public Designation designation { get; set; }

        public ICollection<Employee> Employees { get; set; } 


    }
}
