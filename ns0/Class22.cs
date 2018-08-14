using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace ns0
{
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0"), DebuggerNonUserCode, CompilerGenerated]
	internal class Class22
	{
		private static ResourceManager resourceManager_0;

		private static CultureInfo cultureInfo_0;

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (Class22.resourceManager_0 == null)
				{
					ResourceManager resourceManager = new ResourceManager("ns0.Class22", typeof(Class22).Assembly);
					Class22.resourceManager_0 = resourceManager;
				}
				return Class22.resourceManager_0;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Class22.cultureInfo_0;
			}
			set
			{
				Class22.cultureInfo_0 = value;
			}
		}

		internal static Bitmap bg
		{
			get
			{
				object @object = Class22.ResourceManager.GetObject("bg", Class22.cultureInfo_0);
				return (Bitmap)@object;
			}
		}

		internal Class22()
		{
		}
	}
}
