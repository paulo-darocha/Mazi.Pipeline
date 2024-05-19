using Mazi.Pipeline.Api.DomainModels;
using System.ComponentModel.DataAnnotations;

namespace Mazi.Pipeline.Api.ServiceLayers;

public partial class ConfigurationItem : CoreFieldsDomainModelBase
{
   private DomainModelField<string> _Category = new(default);
   private DomainModelField<string> _ConfigurationKey = new(default);
   private DomainModelField<string> _Description = new(default);
   private DomainModelField<string> _ConfigurationValue = new(default);

   [Display(Name = "category")]
   [StringLength(50)]
   public string Category
   {
      get { return _Category.Value; }
      set { _Category.Value = value; }
   }

   [Display(Name = "configuration key")]
   [StringLength(50)]
   public string ConfigurationKey
   {
      get { return _ConfigurationKey.Value; }
      set { _ConfigurationKey.Value = value; }
   }

   [Display(Name = "description")]
   [StringLength(512)]
   public string Description
   {
      get { return _Description.Value; }
      set { _Description.Value = value; }
   }

   [Display(Name = "configuration value")]
   public string ConfigurationValue
   {
      get { return _ConfigurationValue.Value; }
      set { _ConfigurationValue.Value = value; }
   }

   public override bool HasChanges()
   {
      if (base.HasChanges() == true)
         return true;

      if (_Category.HasChanges() == true)
         return true;

      if (_ConfigurationKey.HasChanges() == true)
         return true;

      if (_Description.HasChanges() == true)
         return true;

      if (_ConfigurationValue.HasChanges() == true)
         return true;

      return false;
   }

   public override void AcceptChanges()
   {
      base.AcceptChanges();
      _Category.AcceptChanges();
      _ConfigurationKey.AcceptChanges();
      _Description.AcceptChanges();
      _ConfigurationValue.AcceptChanges();
   }

   public override void UndoChanges()
   {
      base.UndoChanges();
      _Category.UndoChanges();
      _ConfigurationKey.UndoChanges();
      _Description.UndoChanges();
      _ConfigurationValue.UndoChanges();
   }
}
