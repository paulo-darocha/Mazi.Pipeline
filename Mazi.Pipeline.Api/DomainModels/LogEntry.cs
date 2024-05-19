using System.ComponentModel.DataAnnotations;
using System;

namespace Mazi.Pipeline.Api.DomainModels;

public partial class LogEntry : DomainModelBase
{
   private DomainModelField<string> _Category = new(default);
   private DomainModelField<string> _LogLevel = new(default);
   private DomainModelField<string> _LogText = new(default);
   private DomainModelField<string> _ExceptionText = new(default);
   private DomainModelField<string> _EventId = new(default);
   private DomainModelField<string> _State = new(default);
   private DomainModelField<DateTime> _LogDate = new(default);

   [Display(Name = "category")]
   public string Category
   {
      get { return _Category.Value; }
      set { _Category.Value = value; }
   }

   [Display(Name = "log level")]
   public string LogLevel
   {
      get { return _LogLevel.Value; }
      set { _LogLevel.Value = value; }
   }

   [Display(Name = "log text")]
   public string LogText
   {
      get { return _LogText.Value; }
      set { _LogText.Value = value; }
   }

   [Display(Name = "exception text")]
   public string ExceptionText
   {
      get { return _ExceptionText.Value; }
      set { _ExceptionText.Value = value; }
   }

   [Display(Name = "event id")]
   public string EventId
   {
      get { return _EventId.Value; }
      set { _EventId.Value = value; }
   }

   [Display(Name = "state")]
   public string State
   {
      get { return _State.Value; }
      set { _State.Value = value; }
   }

   [Display(Name = "log date")]
   public DateTime LogDate
   {
      get { return _LogDate.Value; }
      set { _LogDate.Value = value; }
   }

   public override bool HasChanges()
   {
      if (base.HasChanges() == true)
         return true;
      if (_Category.HasChanges() == true)
         return true;
      if (_LogLevel.HasChanges() == true)
         return true;
      if (_LogText.HasChanges() == true)
         return true;
      if (_ExceptionText.HasChanges() == true)
         return true;
      if (_EventId.HasChanges() == true)
         return true;
      if (_State.HasChanges() == true)
         return true;
      if (_LogDate.HasChanges() == true)
         return true;
      return false;
   }

   public override void AcceptChanges()
   {
      base.AcceptChanges();
      _Category.AcceptChanges();
      _LogLevel.AcceptChanges();
      _LogText.AcceptChanges();
      _ExceptionText.AcceptChanges();
      _EventId.AcceptChanges();
      _State.AcceptChanges();
      _LogDate.AcceptChanges();
   }

   public override void UndoChanges()
   {
      base.UndoChanges();
      _Category.UndoChanges();
      _LogLevel.UndoChanges();
      _LogText.UndoChanges();
      _ExceptionText.UndoChanges();
      _EventId.UndoChanges();
      _State.UndoChanges();
      _LogDate.UndoChanges();
   }
}
