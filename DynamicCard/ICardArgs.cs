using System;
using System.Collections.Generic;

namespace DynamicCard
{
	public interface ICardArgs<T> where T : class
	{
		IEnumerable<T> SortedCard(IEnumerable<T> source);
	}
}
