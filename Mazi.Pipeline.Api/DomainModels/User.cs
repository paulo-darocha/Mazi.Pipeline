﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Mazi.Pipeline.Api.DomainModels;

public partial class User : CoreFieldsDomainModelBase
{
   private DomainModelField<string> _Username = new(default);
   private DomainModelField<string> _Source = new(default);
   private DomainModelField<string> _EmailAddress = new(default);
   private DomainModelField<string> _FirstName = new(default);
   private DomainModelField<string> _LastName = new(default);
   private DomainModelField<string> _PhoneNumber = new(default);
   private IList<UserClaim> _Claims;

   [Display(Name = "username")]
   [StringLength(100)]
   public string Username
   {
      get { return _Username.Value; }
      set { _Username.Value = value; }
   }

   [Display(Name = "Source")]
   [StringLength(100)]
   public string Source
   {
      get { return _Source.Value; }
      set { _Source.Value = value; }
   }

   [Display(Name = "email address")]
   [StringLength(100)]
   public string EmailAddress
   {
      get { return _EmailAddress.Value; }
      set { _EmailAddress.Value = value; }
   }

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

   [Display(Name = "claims")]
   public IList<UserClaim> Claims
   {
      get
      {
         if (_Claims == null)
         {
            _Claims = new List<UserClaim>();
         }

         return _Claims;
      }
      set { _Claims = value; }
   }

   public override bool HasChanges()
   {
      if (base.HasChanges() == true)
         return true;

      if (_Username.HasChanges() == true)
         return true;

      if (_Source.HasChanges() == true)
         return true;

      if (_EmailAddress.HasChanges() == true)
         return true;

      if (_FirstName.HasChanges() == true)
         return true;

      if (_LastName.HasChanges() == true)
         return true;

      if (_PhoneNumber.HasChanges() == true)
         return true;

      return false;
   }

   public override void AcceptChanges()
   {
      base.AcceptChanges();
      _Username.AcceptChanges();
      _Source.AcceptChanges();
      _EmailAddress.AcceptChanges();
      _FirstName.AcceptChanges();
      _LastName.AcceptChanges();
      _PhoneNumber.AcceptChanges();
   }

   public override void UndoChanges()
   {
      base.UndoChanges();
      _Username.UndoChanges();
      _Source.UndoChanges();
      _EmailAddress.UndoChanges();
      _FirstName.UndoChanges();
      _LastName.UndoChanges();
      _PhoneNumber.UndoChanges();
   }
}
