using System.ComponentModel.DataAnnotations;
using System;

namespace Mazi.Pipeline.Api.DomainModels;

public partial class UserClaim : CoreFieldsDomainModelBase
{
   private DomainModelField<string> _Username = new(default);
   private DomainModelField<string> _ClaimName = new(default);
   private DomainModelField<string> _ClaimValue = new(default);
   private DomainModelField<int> _UserId = new(default);
   private User _User;
   private DomainModelField<string> _ClaimLogicType = new(default);
   private DomainModelField<DateTime> _StartDate = new(default);
   private DomainModelField<DateTime> _EndDate = new(default);

   public UserClaim()
   {
      _ClaimLogicType.Value = ApiConstants.ClaimLogicType_Default;
      _ClaimLogicType.AcceptChanges();
   }

   public bool IsValidOnDate(DateTime forDate)
   {
      if (this.ClaimLogicType != ApiConstants.ClaimLogicType_DateTimeBased)
      {
         return true;
      }
      else
      {
         bool isInfiniteStart = false;
         bool isInfiniteEnd = false;

         if (StartDate == default)
         {
            isInfiniteStart = true;
         }

         if (EndDate == default)
         {
            isInfiniteEnd = true;
         }

         if (isInfiniteStart == true && isInfiniteEnd == true)
         {
            return true;
         }
         else if (isInfiniteStart == true)
         {
            return forDate < EndDate;
         }
         else if (isInfiniteEnd == true)
         {
            return StartDate <= forDate;
         }
         else
         {
            return (StartDate <= forDate && forDate < EndDate);
         }
      }
   }

   [Display(Name = "username")]
   [StringLength(100)]
   public string Username
   {
      get { return _Username.Value; }
      set { _Username.Value = value; }
   }

   [Display(Name = "claim name")]
   [StringLength(100)]
   public string ClaimName
   {
      get { return _ClaimName.Value; }
      set { _ClaimName.Value = value; }
   }

   [Display(Name = "claim value")]
   [StringLength(100)]
   public string ClaimValue
   {
      get { return _ClaimValue.Value; }
      set { _ClaimValue.Value = value; }
   }

   [Display(Name = "UserId")]
   public int UserId
   {
      get { return _UserId.Value; }
      set { _UserId.Value = value; }
   }

   [Display(Name = "User")]
   public User User
   {
      get { return _User; }
      set { _User = value; }
   }

   [Display(Name = "claim type (normal / date)")]
   [StringLength(100)]
   public string ClaimLogicType
   {
      get { return _ClaimLogicType.Value; }
      set { _ClaimLogicType.Value = value; }
   }

   [Display(Name = "claim start date")]
   public DateTime StartDate
   {
      get { return _StartDate.Value; }
      set { _StartDate.Value = value; }
   }

   [Display(Name = "claim end date")]
   public DateTime EndDate
   {
      get { return _EndDate.Value; }
      set { _EndDate.Value = value; }
   }

   public override bool HasChanges()
   {
      if (base.HasChanges() == true)
         return true;

      if (_Username.HasChanges() == true)
         return true;

      if (_ClaimName.HasChanges() == true)
         return true;

      if (_ClaimValue.HasChanges() == true)
         return true;

      if (_UserId.HasChanges() == true)
         return true;

      if (_ClaimLogicType.HasChanges() == true)
         return true;

      if (_StartDate.HasChanges() == true)
         return true;

      if (_EndDate.HasChanges() == true)
         return true;

      return false;
   }

   public override void AcceptChanges()
   {
      base.AcceptChanges();
      _Username.AcceptChanges();
      _ClaimName.AcceptChanges();
      _ClaimValue.AcceptChanges();
      _UserId.AcceptChanges();
      _ClaimLogicType.AcceptChanges();
      _StartDate.AcceptChanges();
      _EndDate.AcceptChanges();
   }

   public override void UndoChanges()
   {
      base.UndoChanges();
      _Username.UndoChanges();
      _ClaimName.UndoChanges();
      _ClaimValue.UndoChanges();
      _UserId.UndoChanges();
      _ClaimLogicType.UndoChanges();
      _StartDate.UndoChanges();
      _EndDate.UndoChanges();
   }
}
