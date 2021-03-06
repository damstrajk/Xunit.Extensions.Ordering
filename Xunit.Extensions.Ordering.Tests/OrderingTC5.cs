﻿namespace Xunit.Extensions.Ordering.Tests
{
	[Collection("C1"), Order(1)]
	public partial class OrderingTC5
	{
		[Fact, Order(20)]
		public void M1() { Assert.Equal(7, Counter.Next()); }

		[Fact, Order(1)]
		public void M2() { Assert.Equal(6, Counter.Next()); }

	}
}
