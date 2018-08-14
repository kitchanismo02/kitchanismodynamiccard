using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ns0
{
	internal class Class21
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
		private static bool bool_0;

		public static bool isShown
		{
			get;
			set;
		}

		public Class21()
		{
			if (!Class21.isShown)
			{
				MessageBox.Show("kitchanismo dynamic card", "kitchan betsayda", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				Class21.isShown = true;
			}
		}
	}
}
