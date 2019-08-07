using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompanyExplorer.Model
{
    [Table("Empoyee")]
    public partial class Empoyee
    {
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ID { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string SurName { get; set; }

        [StringLength(50)]
        public string Patronymic { get; set; }

        public DateTime DateOfBirth { get; set; }

        [StringLength(4)]
        public string DocSeries { get; set; }

        [StringLength(6)]
        public string DocNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string Position { get; set; }

        public Guid DepartmentID { get; set; }

        public virtual Department Department { get; set; }

        [NotMapped]
        public int Age
        {
            get
            {
                DateTime startDate = DateTime.Now, endDate = DateOfBirth;
                int years = DateTime.Now.Year - DateOfBirth.Year;
                if (startDate.Month == endDate.Month && endDate.Day < startDate.Day)
                {
                    years--;
                }
                else if (endDate.Month < startDate.Month)
                {
                    years--;
                }
                return years;
            }
        }

        public override bool Equals(object obj)
        {
            return obj != null && obj is Empoyee && ID == (obj as Empoyee).ID;
        }
    }
}
