namespace Mazi.Pipeline.Api.DomainModels;

public interface IValidatorStrategy<T>
{
   bool IsValid(T validateThis);
}
