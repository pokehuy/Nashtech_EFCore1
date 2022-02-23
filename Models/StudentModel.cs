using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace efcore.Models
{
    [Table("Student")]
    public class StudentModel
    {
        [Key]
        [Required]
        public int StudentId {get; set;}
        [Column("FirstName", TypeName="ntext")]
        [MaxLength(30)]
        [Required]
        public string FirstName {get; set;}
        [Column("LastName", TypeName="ntext")]
        [MaxLength(50)]
        [Required]
        public string LastName {get; set;}
        [Column("City", TypeName="ntext")]
        [MaxLength(60)]
        [Required]
        public string City {get; set;}
        [Column("State", TypeName="ntext")]
        [MaxLength(50)]
        [Required]
        public string State {get; set;}
    }
}