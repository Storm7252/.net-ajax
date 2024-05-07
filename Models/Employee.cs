using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cascadind_dropdown.Models
{
    public class Employee
    {
        [Key]
        public int EmpoyeeId { get; set; }

        public string EmpName { get; set; }

        //--------creating designation relation----------
        public int DesigId { get; set; }
        [ForeignKey("DesigId")]
        public Designation Designation { get; set; }


        //creating grade relation-------------
        public int GradeId { get; set; }
        [ForeignKey("GradeId")]
        public Grade Grade { get; set; }
    }
}
