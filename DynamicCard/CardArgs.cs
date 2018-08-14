using ns0;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace DynamicCard
{
	public class CardArgs : EventArgs
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
		private string string_0;

		[DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
		private string string_1;

		[DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
		private double double_0;

		[DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
		private string string_2;

		[DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
		private int int_0;

		[DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
		private int int_1;

		public string Key
		{
			get;
			set;
		}

		public string Title
		{
			get;
			set;
		}

		public double Price
		{
			get;
			set;
		}

		public string ImagePath
		{
			get;
			set;
		}

		public int Quantity
		{
			get;
			set;
		}

		public int TotalCards
		{
			get;
			set;
		}

		public CardArgs()
		{
			new Class21();
		}
	}
}
