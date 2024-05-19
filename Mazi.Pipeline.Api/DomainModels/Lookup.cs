using System.ComponentModel.DataAnnotations;

namespace Mazi.Pipeline.Api.DomainModels;

public partial class Lookup : CoreFieldsDomainModelBase
{
   private DomainModelField<int> _DisplayOrder = new(default);
   private DomainModelField<string> _LookupType = new(default);
   private DomainModelField<string> _LookupKey = new(default);
   private DomainModelField<string> _LookupValue = new(default);

   [Display(Name = "Display Order")]
   public int DisplayOrder
   {
      get { return _DisplayOrder.Value; }
      set { _DisplayOrder.Value = value; }
   }

   [Display(Name = "Lookup Type")]
   [StringLength(50)]
   public string LookupType
   {
      get { return _LookupType.Value; }
      set { _LookupType.Value = value; }
   }

   [Display(Name = "Lookup Key")]
   [StringLength(50)]
   public string LookupKey
   {
      get { return _LookupKey.Value; }
      set { _LookupKey.Value = value; }
   }

   [Display(Name = "Lookup Value")]
   [StringLength(50)]
   public string LookupValue
   {
      get { return _LookupValue.Value; }
      set { _LookupValue.Value = value; }
   }

   public override bool HasChanges()
   {
      if (base.HasChanges() == true)
         return true;
      if (_DisplayOrder.HasChanges() == true)
         return true;
      if (_LookupType.HasChanges() == true)
         return true;
      if (_LookupKey.HasChanges() == true)
         return true;
      if (_LookupValue.HasChanges() == true)
         return true;
      return false;
   }

   public override void AcceptChanges()
   {
      base.AcceptChanges();
      _DisplayOrder.AcceptChanges();
      _LookupType.AcceptChanges();
      _LookupKey.AcceptChanges();
      _LookupValue.AcceptChanges();
   }

   public override void UndoChanges()
   {
      base.UndoChanges();
      _DisplayOrder.UndoChanges();
      _LookupType.UndoChanges();
      _LookupKey.UndoChanges();
      _LookupValue.UndoChanges();
   }
}
