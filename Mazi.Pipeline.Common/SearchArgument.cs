using System;

namespace Mazi.Pipeline.Common;

public class SearchArgument(
   string propertyName,
   SearchMethod method,
   string searchValue,
   SearchOperator addAsOperator = SearchOperator.And
)
{
   public string PropertyName { get; set; } =
      propertyName ?? throw new ArgumentNullException(nameof(propertyName));
   public SearchMethod Method { get; set; } = method;
   public string SearchValue { get; set; } =
      searchValue ?? throw new ArgumentNullException(nameof(searchValue));
   public SearchOperator Operator { get; set; } = addAsOperator;
}
