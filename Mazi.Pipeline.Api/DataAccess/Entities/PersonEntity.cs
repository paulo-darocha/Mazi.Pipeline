using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mazi.Pipeline.Api.DataAccess.Entities;

[Table("Person", Schema = "dbo")]
public partial class PersonEntity : CoreFieldsEntityBase
{
   [Column(Order = 1)]
   [StringLength(50)]
   [Required]
   public string FirstName { get; set; }

   [Column(Order = 2)]
   [StringLength(50)]
   [Required]
   public string LastName { get; set; }

   [Column(Order = 3)]
   [StringLength(50)]
   [Required]
   public string PhoneNumber { get; set; }

   [Column(Order = 4)]
   [StringLength(50)]
   [Required]
   public string EmailAddress { get; set; }
}
