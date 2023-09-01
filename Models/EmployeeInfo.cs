using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Elev8WebApp.Models
{
    [Table("Employees")]
    public class EmployeeInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string surName { get; set; }
        public string otherNames { get; set; }
        public DateTime DOE { get; set; }

    }
    [Table("EmployeeSalary")]
    public class EmployeeSalaryInfo : EmployeeInfo
    {

        [Required]
        public double salaryAmount { get; set; }
        public double deductions { get; set; }
    }
}
