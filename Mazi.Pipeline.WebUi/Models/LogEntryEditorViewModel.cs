using Mazi.Pipeline.Common;
using System.ComponentModel.DataAnnotations;
using System;

namespace Mazi.Pipeline.WebUi.Models;

public partial class LogEntryEditorViewModel
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

   [Display(Name = "log level")]
   [DisplayFormat(ConvertEmptyStringToNull = false)]
   public string LogLevel { get; set; }

   [Display(Name = "log text")]
   [DisplayFormat(ConvertEmptyStringToNull = false)]
   public string LogText { get; set; }

   [Display(Name = "exception text")]
   [DisplayFormat(ConvertEmptyStringToNull = false)]
   public string ExceptionText { get; set; }

   [Display(Name = "event id")]
   [DisplayFormat(ConvertEmptyStringToNull = false)]
   public string EventId { get; set; }

   [Display(Name = "state")]
   [DisplayFormat(ConvertEmptyStringToNull = false)]
   public string State { get; set; }

   [Display(Name = "log date")]
   [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
   public DateTime LogDate { get; set; }
}
