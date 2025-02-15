﻿using System.ComponentModel.DataAnnotations;

namespace Mazi.Pipeline.Api.DomainModels;

public partial class Person : CoreFieldsDomainModelBase
{
   private DomainModelField<string> _FirstName = new(default);
   private DomainModelField<string> _LastName = new(default);
   private DomainModelField<string> _PhoneNumber = new(default);
   private DomainModelField<string> _EmailAddress = new(default);

   [Display(Name = "first name")]
   [StringLength(50)]
   public string FirstName
   {
      get { return _FirstName.Value; }
      set { _FirstName.Value = value; }
   }

   [Display(Name = "last name")]
   [StringLength(50)]
   public string LastName
   {
      get { return _LastName.Value; }
      set { _LastName.Value = value; }
   }

   [Display(Name = "phone number")]
   [StringLength(50)]
   public string PhoneNumber
   {
      get { return _PhoneNumber.Value; }
      set { _PhoneNumber.Value = value; }
   }

   [Display(Name = "email address")]
   [StringLength(50)]
   public string EmailAddress
   {
      get { return _EmailAddress.Value; }
      set { _EmailAddress.Value = value; }
   }

   public override bool HasChanges()
   {
      if (base.HasChanges() == true)
         return true;
      if (_FirstName.HasChanges() == true)
         return true;
      if (_LastName.HasChanges() == true)
         return true;
      if (_PhoneNumber.HasChanges() == true)
         return true;
      if (_EmailAddress.HasChanges() == true)
         return true;
      return false;
   }

   public override void AcceptChanges()
   {
      base.AcceptChanges();
      _FirstName.AcceptChanges();
      _LastName.AcceptChanges();
      _PhoneNumber.AcceptChanges();
      _EmailAddress.AcceptChanges();
   }

   public override void UndoChanges()
   {
      base.UndoChanges();
      _FirstName.UndoChanges();
      _LastName.UndoChanges();
      _PhoneNumber.UndoChanges();
      _EmailAddress.UndoChanges();
   }
}
