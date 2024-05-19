using System;
using System.Collections.Generic;
using System.Linq;

namespace Mazi.Pipeline.Common;

public class Search
{
	public Search()
	{
		Arguments = [];
		Sorts = [];
		MaxNumberOfResults = -1;
		Name = string.Empty;
	}

	public string Name { get; set; }

	public List<SearchArgument> Arguments { get; }

	public void AddArgument(
		string propertyName,
		SearchMethod method,
		string value,
		SearchOperator combinedWithOtherArgumentsAs = SearchOperator.And
	)
	{
		Arguments.Add(
			new SearchArgument(
				propertyName,
				method,
				value,
				combinedWithOtherArgumentsAs
			)
		);
	}

	public int MaxNumberOfResults { get; set; }
	public List<SortBy> Sorts { get; set; }

	public void AddSort(
		string sortByPropertyName,
		string direction = SearchConstants.SortDirectionAscending
	)
	{
		ArgumentNullException.ThrowIfNull(sortByPropertyName);
		ArgumentNullException.ThrowIfNull(direction);

		string directionCleaned;

		if (
			string.Compare(direction, SearchConstants.SortDirectionAscending, true)
			== 0
		)
		{
			directionCleaned = SearchConstants.SortDirectionAscending;
		}
		else if (
			string.Compare(
				direction,
				SearchConstants.SortDirectionDescending,
				true
			) == 0
		)
		{
			directionCleaned = SearchConstants.SortDirectionAscending;
		}
		else
		{
			throw new ArgumentOutOfRangeException(
				nameof(direction),
				string.Format(
					"Value should be '{0}' or '{1}'.",
					SearchConstants.SortDirectionAscending,
					SearchConstants.SortDirectionDescending
				)
			);
		}

		AddSort(
			new SortBy()
			{
				PropertyName = sortByPropertyName,
				Direction = directionCleaned
			}
		);
	}

	private void AddSort(SortBy sortBy)
	{
		ArgumentNullException.ThrowIfNull(sortBy);

		var match = (
			from temp in Sorts
			where string.Compare(temp.PropertyName, sortBy.PropertyName, true) == 0
			select temp
		).FirstOrDefault();
		if (match == null)
			Sorts.Add(sortBy);
	}
}
