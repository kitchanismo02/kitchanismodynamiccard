using ns0;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace DynamicCard
{
	public class Photo
	{
		[CompilerGenerated]
		private sealed class Class6
		{
			public Bitmap bitmap_0;

			public Image image_0;

			public Rectangle rectangle_0;

			internal Bitmap method_0()
			{
				this.bitmap_0.SetResolution(this.image_0.HorizontalResolution, this.image_0.VerticalResolution);
				using (Graphics graphics = Graphics.FromImage(this.bitmap_0))
				{
					using (ImageAttributes imageAttributes = new ImageAttributes())
					{
						imageAttributes.SetWrapMode(WrapMode.TileFlipXY);
						graphics.DrawImage(this.image_0, this.rectangle_0, 0, 0, this.image_0.Width, this.image_0.Height, GraphicsUnit.Pixel, imageAttributes);
					}
				}
				return this.bitmap_0;
			}
		}

		public static Image Resize(string srcPath, int width, int height)
		{
			Image result;
			if (srcPath == null)
			{
				result = Class22.bg;
			}
			else
			{
				Image image;
				try
				{
					image = Image.FromFile(srcPath);
				}
				catch (FileNotFoundException)
				{
					result = Class22.bg;
					return result;
				}
				result = Photo.ReSize(image, width, height);
			}
			return result;
		}

		[DebuggerStepThrough, AsyncStateMachine(typeof(Photo.Class5))]
		public static Task<Image> ResizeAsync(string srcPath, int width, int height)
		{
			Photo.Class5 @class = new Photo.Class5();
			@class.string_0 = srcPath;
			@class.int_1 = width;
			@class.int_2 = height;
			@class.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<Image>.Create();
			@class.int_0 = -1;
			AsyncTaskMethodBuilder<Image> asyncTaskMethodBuilder_ = @class.asyncTaskMethodBuilder_0;
			asyncTaskMethodBuilder_.Start<Photo.Class5>(ref @class);
			return @class.asyncTaskMethodBuilder_0.Task;
		}

		public static Bitmap ReSize(Image image, int width, int height)
		{
			Rectangle destRect = new Rectangle(0, 0, width, height);
			Bitmap bitmap = new Bitmap(width, height);
			bitmap.SetResolution(image.HorizontalResolution, image.VerticalResolution);
			using (Graphics graphics = Graphics.FromImage(bitmap))
			{
				using (ImageAttributes imageAttributes = new ImageAttributes())
				{
					imageAttributes.SetWrapMode(WrapMode.TileFlipXY);
					graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, imageAttributes);
				}
			}
			return bitmap;
		}

		[DebuggerStepThrough, AsyncStateMachine(typeof(Photo.Class7))]
		public static Task<Bitmap> ReSizeAsync(Image image, int width, int height)
		{
			Photo.Class7 @class = new Photo.Class7();
			@class.image_0 = image;
			@class.int_1 = width;
			@class.int_2 = height;
			@class.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<Bitmap>.Create();
			@class.int_0 = -1;
			AsyncTaskMethodBuilder<Bitmap> asyncTaskMethodBuilder_ = @class.asyncTaskMethodBuilder_0;
			asyncTaskMethodBuilder_.Start<Photo.Class7>(ref @class);
			return @class.asyncTaskMethodBuilder_0.Task;
		}
	}
}
