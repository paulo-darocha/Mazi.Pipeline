namespace Mazi.Pipeline.Common;

public interface IDeleteable : IInt32Identity
{
   bool IsMarkedForDelete { get; set; }
}
