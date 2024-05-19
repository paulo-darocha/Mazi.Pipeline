using Mazi.Pipeline.Api;
using Mazi.Pipeline.Common;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Mazi.Pipeline.WebUi.Models;

public partial class ConfigurationItemEditorViewModel
   : IInt32Identity,
      ISelectable,
      IDeleteable
{
   public bool IsSelected { get; set; }
   public bool IsMarkedForDelete { get; set; }

   [Display(Name = "Id")]
   public int Id { get; set; }

   [Display(Name = "category")]
   [DisplayFormat(ConvertEmptyStringToNull = false)]
   public string Category { get; set; }

   [Display(Name = "configuration key")]
   [DisplayFormat(ConvertEmptyStringToNull = false)]
   public string ConfigurationKey { get; set; }

   [Display(Name = "description")]
   [DisplayFormat(ConvertEmptyStringToNull = false)]
   public string Description { get; set; }

   [Display(Name = "configuration value")]
   [DataType(DataType.MultilineText)]
   [DisplayFormat(ConvertEmptyStringToNull = false)]
   public string ConfigurationValue { get; set; }

   [Display(Name = "Status")]
   [DisplayFormat(ConvertEmptyStringToNull = true)]
   [Required]
   public string Status { get; set; } = ApiConstants.StatusActive;
   private List<SelectListItem> _Statuses;
   public List<SelectListItem> Statuses
   {
      get
      {
         if (_Statuses == null)
         {
            _Statuses = new List<SelectListItem>();
         }

         return _Statuses;
      }
      set { _Statuses = value; }
   }

   [Display(Name = "Created By")]
   [DisplayFormat(ConvertEmptyStringToNull = false)]
   public string CreatedBy { get; set; }

   [Display(Name = "Created Date")]
   [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
   public DateTime CreatedDate { get; set; }

   [Display(Name = "Last Modified By")]
   [DisplayFormat(ConvertEmptyStringToNull = false)]
   public string LastModifiedBy { get; set; }

   [Display(Name = "Last Modified Date")]
   [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
   public DateTime LastModifiedDate { get; set; }

   [Display(Name = "Timestamp")]
   public byte[] Timestamp { get; set; }
}
