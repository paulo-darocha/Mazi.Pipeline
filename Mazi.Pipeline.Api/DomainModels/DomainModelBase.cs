using Mazi.Pipeline.Common;

namespace Mazi.Pipeline.Api.DomainModels;

public abstract class DomainModelBase : IInt32Identity
{
	private readonly DomainModelField<int> id = new(default);

	public int Id
	{
		get => id.Value;
		set => id.Value = value;
	}

	public virtual bool HasChanges()
	{
		if (id.HasChanges() == true)
			return true;
		return false;
	}

	public virtual void AcceptChanges()
	{
		id.AcceptChanges();
	}

	public virtual void UndoChanges()
	{
		id.UndoChanges();
	}
}
