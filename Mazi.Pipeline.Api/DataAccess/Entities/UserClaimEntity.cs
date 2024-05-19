using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace Mazi.Pipeline.Api.DataAccess.Entities;

[Table("UserClaim", Schema = "dbo")]
public partial class UserClaimEntity : CoreFieldsEntityBase
{
   [Column(Order = 1)]
   [StringLength(100)]
   [Required]
   public string Username { get; set; }

   [Column(Order = 2)]
   [StringLength(100)]
   [Required]
   public string ClaimName { get; set; }

   [Column(Order = 3)]
   [StringLength(100)]
   [Required]
   public string ClaimValue { get; set; }

   [Column(Order = 4)]
   [Required]
   public int UserId { get; set; }

   [Column(Order = 5)]
   public UserEntity User { get; set; }

   [Column(Order = 6)]
   [StringLength(100)]
   [Required]
   public string ClaimLogicType { get; set; }

   [Column(Order = 7)]
   [Required]
   public DateTime StartDate { get; set; }

   [Column(Order = 8)]
   [Required]
   public DateTime EndDate { get; set; }
}
