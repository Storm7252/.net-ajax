using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cascadind_dropdown.Models
{
    public class Designation
    {
        [Key]
        public int Desig_Id { get; set; }
        public string Designation_Title { get; set; }

        public ICollection<Employee> Employee { get; set; }

        public ICollection<Grade> DesignationGrade { get; set; }

    }
}
