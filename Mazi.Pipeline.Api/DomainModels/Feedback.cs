using System.ComponentModel.DataAnnotations;

namespace Mazi.Pipeline.Api.DomainModels;

public partial class Feedback : CoreFieldsDomainModelBase
{
   private DomainModelField<string> _FeedbackType = new(default);
   private DomainModelField<string> _Sentiment = new(default);
   private DomainModelField<string> _Subject = new(default);
   private DomainModelField<string> _FeedbackText = new(default);
   private DomainModelField<string> _Username = new(default);
   private DomainModelField<string> _FirstName = new(default);
   private DomainModelField<string> _LastName = new(default);
   private DomainModelField<string> _Referrer = new(default);
   private DomainModelField<string> _UserAgent = new(default);
   private DomainModelField<string> _IpAddress = new(default);
   private DomainModelField<bool> _IsContactRequest = new(default);

   [Display(Name = "feedback type")]
   [StringLength(50)]
   public string FeedbackType
   {
      get { return _FeedbackType.Value; }
      set { _FeedbackType.Value = value; }
   }

   [Display(Name = "sentiment")]
   [StringLength(50)]
   public string Sentiment
   {
      get { return _Sentiment.Value; }
      set { _Sentiment.Value = value; }
   }

   [Display(Name = "notification subject")]
   [StringLength(1024)]
   public string Subject
   {
      get { return _Subject.Value; }
      set { _Subject.Value = value; }
   }

   [Display(Name = "message")]
   [StringLength(2048)]
   public string FeedbackText
   {
      get { return _FeedbackText.Value; }
      set { _FeedbackText.Value = value; }
   }

   [Display(Name = "username")]
   [StringLength(50)]
   public string Username
   {
      get { return _Username.Value; }
      set { _Username.Value = value; }
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

   [Display(Name = "referrer")]
   [StringLength(1000)]
   public string Referrer
   {
      get { return _Referrer.Value; }
      set { _Referrer.Value = value; }
   }

   [Display(Name = "user agent")]
   [StringLength(1000)]
   public string UserAgent
   {
      get { return _UserAgent.Value; }
      set { _UserAgent.Value = value; }
   }

   [Display(Name = "ip address")]
   [StringLength(50)]
   public string IpAddress
   {
      get { return _IpAddress.Value; }
      set { _IpAddress.Value = value; }
   }

   [Display(Name = "yes, I'd like a reply")]
   public bool IsContactRequest
   {
      get { return _IsContactRequest.Value; }
      set { _IsContactRequest.Value = value; }
   }

   public override bool HasChanges()
   {
      if (base.HasChanges() == true)
         return true;
      if (_FeedbackType.HasChanges() == true)
         return true;
      if (_Sentiment.HasChanges() == true)
         return true;
      if (_Subject.HasChanges() == true)
         return true;
      if (_FeedbackText.HasChanges() == true)
         return true;
      if (_Username.HasChanges() == true)
      {
         return true;
      }
      if (_FirstName.HasChanges() == true)
         return true;
      if (_LastName.HasChanges() == true)
         return true;
      if (_Referrer.HasChanges() == true)
         return true;
      if (_UserAgent.HasChanges() == true)
         return true;
      if (_IpAddress.HasChanges() == true)
         return true;
      if (_IsContactRequest.HasChanges() == true)
         return true;
      return false;
   }

   public override void AcceptChanges()
   {
      base.AcceptChanges();
      _FeedbackType.AcceptChanges();
      _Sentiment.AcceptChanges();
      _Subject.AcceptChanges();
      _FeedbackText.AcceptChanges();
      _Username.AcceptChanges();
      _FirstName.AcceptChanges();
      _LastName.AcceptChanges();
      _Referrer.AcceptChanges();
      _UserAgent.AcceptChanges();
      _IpAddress.AcceptChanges();
      _IsContactRequest.AcceptChanges();
   }

   public override void UndoChanges()
   {
      base.UndoChanges();
      _FeedbackType.UndoChanges();
      _Sentiment.UndoChanges();
      _Subject.UndoChanges();
      _FeedbackText.UndoChanges();
      _Username.UndoChanges();
      _FirstName.UndoChanges();
      _LastName.UndoChanges();
      _Referrer.UndoChanges();
      _UserAgent.UndoChanges();
      _IpAddress.UndoChanges();
      _IsContactRequest.UndoChanges();
   }
}
