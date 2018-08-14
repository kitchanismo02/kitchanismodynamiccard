using ns0;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicCard
{
	public class Card : Panel
	{
		public enum CardTheme
		{
			Light,
			Dark
		}

		[CompilerGenerated]
		private sealed class Class0
		{
			private sealed class Class1 : IAsyncStateMachine
			{
				public int int_0;

				public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

				public Card.Class0 class0_0;

				private TaskAwaiter taskAwaiter_0;

				void IAsyncStateMachine.MoveNext()
				{
					int num = this.int_0;
					try
					{
						TaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = this.class0_0.card_0.method_3(this.class0_0.string_0).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								this.int_0 = 0;
								this.taskAwaiter_0 = awaiter;
								Card.Class0.Class1 @class = this;
								this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, Card.Class0.Class1>(ref awaiter, ref @class);
								return;
							}
						}
						else
						{
							awaiter = this.taskAwaiter_0;
							this.taskAwaiter_0 = default(TaskAwaiter);
							this.int_0 = -1;
						}
						awaiter.GetResult();
					}
					catch (Exception exception)
					{
						this.int_0 = -2;
						this.asyncVoidMethodBuilder_0.SetException(exception);
						return;
					}
					this.int_0 = -2;
					this.asyncVoidMethodBuilder_0.SetResult();
				}

				[DebuggerHidden]
				void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			public Card card_0;

			public string string_0;

			[DebuggerStepThrough, AsyncStateMachine(typeof(Card.Class0.Class1))]
			internal void method_0()
			{
				Card.Class0.Class1 @class = new Card.Class0.Class1();
				@class.class0_0 = this;
				@class.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
				@class.int_0 = -1;
				AsyncVoidMethodBuilder asyncVoidMethodBuilder_ = @class.asyncVoidMethodBuilder_0;
				asyncVoidMethodBuilder_.Start<Card.Class0.Class1>(ref @class);
			}
		}

		[CompilerGenerated]
		private sealed class Class3
		{
			public string string_0;

			internal bool method_0(CardArgs cardArgs_0)
			{
				return cardArgs_0.Key == this.string_0;
			}
		}

		[CompilerGenerated]
		private sealed class Class4
		{
			public string string_0;

			internal bool method_0(CardArgs cardArgs_0)
			{
				return cardArgs_0.Key == this.string_0;
			}
		}

		public EventHandler<CardArgs> OnCount;

		public EventHandler<CardArgs> OnIncrement;

		public EventHandler<CardArgs> OnDecrement;

		public EventHandler<CardArgs> OnLoad;

		[DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
		private static double double_0;

		[DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
		private static int int_0;

		public static List<CardArgs> List;

		private int int_1;

		[DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
		private string string_0;

		[DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
		private string string_1;

		[DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
		private double double_1;

		[DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
		private string string_2;

		[DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
		private int int_2;

		private TextBox txtCounter;

		private Button BtnAddToCart;

		private Button BtnAdd;

		private Button BtnSubtract;

		private Label LblDescription;

		private Label LblTitle;

		private PictureBox ProductImage;

		private double double_2;

		private string string_3;

		private string string_4;

		public static double Total
		{
			get;
			set;
		}

		public static int TotalQuantity
		{
			get;
			set;
		}

		public static Image DefaultImage
		{
			get
			{
				return Class22.bg;
			}
		}

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

		public CardArgs CardEventArgs
		{
			get
			{
				return new CardArgs
				{
					Key = this.Key,
					Title = this.string_3,
					Price = this.double_2,
					ImagePath = this.string_4,
					Quantity = this.int_1
				};
			}
		}

		public Card(string key, string title = "Title", double price = 0.0, string imagePath = null, string currency = "")
		{
			Card.Class0 @class = new Card.Class0();
			@class.string_0 = imagePath;
			base..ctor();
			@class.card_0 = this;
			this.InitializeComponent();
			Card.List = new List<CardArgs>();
			this.method_0(key);
			this.Key = key;
			this.Title = title;
			this.string_3 = title;
			this.LblTitle.Text = this.method_1(title).ToUpper();
			this.double_2 = price;
			this.string_4 = @class.string_0;
			this.method_4(price, currency);
			Task task = new Task(new Action(@class.method_0));
			task.Start();
		}

		private void method_0(string string_5)
		{
			if (string_5 == "" || string_5 == "0")
			{
				this.BtnAddToCart.Enabled = false;
				this.BtnAdd.Enabled = false;
				this.BtnSubtract.Enabled = false;
			}
		}

		private string method_1(string string_5 = "")
		{
			string result;
			if (string_5 == null)
			{
				result = "";
			}
			else if (string_5.Length > 14)
			{
				string_5 = (result = string_5.Substring(0, 14) + " ...");
			}
			else
			{
				result = string_5;
			}
			return result;
		}

		private void method_2(string string_5)
		{
			this.ProductImage.InitialImage = Class22.bg;
			this.ProductImage.ErrorImage = Class22.bg;
			this.ProductImage.Image = Photo.Resize(string_5, 240, 134);
		}

		[DebuggerStepThrough, AsyncStateMachine(typeof(Card.Class2))]
		private Task method_3(string string_5)
		{
			Card.Class2 @class = new Card.Class2();
			@class.card_0 = this;
			@class.string_0 = string_5;
			@class.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@class.int_0 = -1;
			AsyncTaskMethodBuilder asyncTaskMethodBuilder_ = @class.asyncTaskMethodBuilder_0;
			asyncTaskMethodBuilder_.Start<Card.Class2>(ref @class);
			return @class.asyncTaskMethodBuilder_0.Task;
		}

		private void method_4(double double_3, string string_5)
		{
			string str = string_5 ?? "Php";
			this.LblDescription.Text = str + " " + double_3.ToString("N");
		}

		private void InitializeComponent()
		{
			this.LblTitle = new Label();
			this.txtCounter = new TextBox();
			this.BtnAdd = new Button();
			this.BtnSubtract = new Button();
			this.LblDescription = new Label();
			this.ProductImage = new PictureBox();
			this.BtnAddToCart = new Button();
			base.SuspendLayout();
			((ISupportInitialize)this.ProductImage).BeginInit();
			base.SuspendLayout();
			this.BackColor = Color.White;
			base.BorderStyle = BorderStyle.FixedSingle;
			base.Controls.Add(this.BtnAddToCart);
			base.Controls.Add(this.LblTitle);
			base.Controls.Add(this.txtCounter);
			base.Controls.Add(this.BtnAdd);
			base.Controls.Add(this.BtnSubtract);
			base.Controls.Add(this.LblDescription);
			base.Controls.Add(this.ProductImage);
			base.Margin = new Padding(5, 5, 0, 0);
			base.Location = new Point(33, 24);
			base.Name = "Card";
			base.Size = new Size(242, 276);
			base.TabIndex = 0;
			this.LblTitle.Anchor = AnchorStyles.Left;
			this.LblTitle.AutoSize = true;
			this.LblTitle.Font = new Font("Century Gothic", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.LblTitle.ForeColor = Color.Black;
			this.LblTitle.Location = new Point(14, 149);
			this.LblTitle.Name = "LblTitle";
			this.LblTitle.Size = new Size(47, 24);
			this.LblTitle.TabIndex = 7;
			this.LblTitle.Text = "Title";
			this.txtCounter.BackColor = Color.White;
			this.txtCounter.BorderStyle = BorderStyle.None;
			this.txtCounter.Font = new Font("Century Gothic", 20.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txtCounter.Location = new Point(84, 223);
			this.txtCounter.MaxLength = 100;
			this.txtCounter.Name = "txtCounter";
			this.txtCounter.Size = new Size(60, 34);
			this.txtCounter.TabIndex = 6;
			this.txtCounter.TextAlign = HorizontalAlignment.Center;
			this.BtnAdd.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.BtnAdd.FlatStyle = FlatStyle.Flat;
			this.BtnAdd.Font = new Font("Century Gothic", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.BtnAdd.Location = new Point(167, 220);
			this.BtnAdd.Name = "BtnAdd";
			this.BtnAdd.Size = new Size(55, 37);
			this.BtnAdd.TabIndex = 4;
			this.BtnAdd.Text = "+";
			this.BtnAdd.UseVisualStyleBackColor = true;
			this.BtnAdd.Click += new EventHandler(this.BtnAddToCart_Click);
			this.BtnSubtract.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.BtnSubtract.FlatStyle = FlatStyle.Flat;
			this.BtnSubtract.Font = new Font("Century Gothic", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.BtnSubtract.Location = new Point(18, 220);
			this.BtnSubtract.Name = "BtnSubtract";
			this.BtnSubtract.Size = new Size(55, 37);
			this.BtnSubtract.TabIndex = 3;
			this.BtnSubtract.Text = "-";
			this.BtnSubtract.UseVisualStyleBackColor = true;
			this.BtnSubtract.Click += new EventHandler(this.BtnSubtract_Click);
			this.LblDescription.Anchor = AnchorStyles.Left;
			this.LblDescription.AutoSize = true;
			this.LblDescription.Font = new Font("Century Gothic", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.LblDescription.ForeColor = Color.DimGray;
			this.LblDescription.Location = new Point(14, 185);
			this.LblDescription.Name = "LblDescription";
			this.LblDescription.Size = new Size(97, 21);
			this.LblDescription.TabIndex = 2;
			this.LblDescription.Text = "...";
			this.ProductImage.BackColor = Color.White;
			this.ProductImage.Dock = DockStyle.Top;
			this.ProductImage.Location = new Point(0, 0);
			this.ProductImage.Name = "ProductImage";
			this.ProductImage.Size = new Size(240, 134);
			this.ProductImage.SizeMode = PictureBoxSizeMode.StretchImage;
			this.ProductImage.TabIndex = 0;
			this.ProductImage.TabStop = false;
			this.ProductImage.Image = Class22.bg;
			this.BtnAddToCart.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.BtnAddToCart.FlatStyle = FlatStyle.Flat;
			this.BtnAddToCart.Font = new Font("Century Gothic", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.BtnAddToCart.Location = new Point(18, 220);
			this.BtnAddToCart.Name = "BtnAddToCart";
			this.BtnAddToCart.Size = new Size(204, 37);
			this.BtnAddToCart.TabIndex = 5;
			this.BtnAddToCart.Text = "ADD";
			this.BtnAddToCart.UseVisualStyleBackColor = true;
			this.BtnAddToCart.Click += new EventHandler(this.BtnAddToCart_Click);
			this.BtnAdd.ForeColor = Color.White;
			this.BtnSubtract.ForeColor = Color.White;
			this.BtnAddToCart.ForeColor = Color.White;
			this.BtnAdd.ForeColor = Color.White;
			this.LblDescription.ForeColor = Color.Crimson;
			this.BtnAdd.Cursor = Cursors.Hand;
			this.BtnAddToCart.Cursor = Cursors.Hand;
			this.BtnSubtract.Cursor = Cursors.Hand;
		}

		public void Theme(Card.CardTheme theme, Color primary, Color secondary)
		{
			Color color;
			if (theme == Card.CardTheme.Light)
			{
				color = Color.White;
				this.LblTitle.ForeColor = Color.Black;
				this.txtCounter.ForeColor = Color.Black;
			}
			else
			{
				color = Color.FromArgb(40, 40, 40);
				this.LblTitle.ForeColor = Color.White;
				this.txtCounter.ForeColor = Color.White;
			}
			this.BtnAdd.BackColor = primary;
			this.BtnAddToCart.BackColor = primary;
			this.BtnAdd.BackColor = primary;
			this.BtnSubtract.BackColor = primary;
			this.BtnAdd.FlatAppearance.BorderColor = color;
			this.BtnSubtract.FlatAppearance.BorderColor = color;
			this.BtnAddToCart.FlatAppearance.BorderColor = color;
			this.BtnAdd.FlatAppearance.BorderColor = color;
			this.BackColor = color;
			this.txtCounter.BackColor = color;
			this.LblDescription.ForeColor = secondary;
		}

		private void BtnAddToCart_Click(object sender, EventArgs e)
		{
			this.method_6();
			this.method_7();
			this.method_8(this.Key, this.int_1);
			Card.Total = this.method_11();
			this.method_5();
		}

		private void method_5()
		{
			EventHandler<CardArgs> expr_06 = this.OnCount;
			if (expr_06 != null)
			{
				expr_06(this, this.CardEventArgs);
			}
			EventHandler<CardArgs> expr_1E = this.OnIncrement;
			if (expr_1E != null)
			{
				expr_1E(this, this.CardEventArgs);
			}
		}

		private void method_6()
		{
			Card.TotalQuantity++;
			this.method_10(1);
		}

		private void method_7()
		{
			this.BtnAdd.Focus();
			this.BtnAddToCart.Visible = false;
		}

		private void method_8(string string_5, int int_3)
		{
			Card.Class3 @class = new Card.Class3();
			@class.string_0 = string_5;
			CardArgs cardArgs = Card.List.Find(new Predicate<CardArgs>(@class.method_0));
			if (cardArgs == null)
			{
				Card.List.Add(this.CardEventArgs);
			}
			else
			{
				cardArgs.Quantity = int_3;
			}
		}

		private void method_9(string string_5, int int_3)
		{
			Card.Class4 @class = new Card.Class4();
			@class.string_0 = string_5;
			CardArgs cardArgs = Card.List.Find(new Predicate<CardArgs>(@class.method_0));
			if (cardArgs != null)
			{
				if (cardArgs.Quantity <= 1)
				{
					Card.List.Remove(cardArgs);
				}
				else
				{
					cardArgs.Quantity = int_3;
				}
			}
		}

		private void method_10(int int_3)
		{
			this.int_1 += int_3;
			this.txtCounter.Text = this.int_1.ToString();
		}

		private double method_11()
		{
			double num = 0.0;
			foreach (CardArgs current in Card.List)
			{
				num += current.Price * (double)current.Quantity;
			}
			return num;
		}

		private void BtnSubtract_Click(object sender, EventArgs e)
		{
			Card.TotalQuantity--;
			this.method_10(-1);
			this.method_9(this.Key, this.int_1);
			Card.Total = this.method_11();
			EventHandler<CardArgs> expr_36 = this.OnCount;
			if (expr_36 != null)
			{
				expr_36(this, this.CardEventArgs);
			}
			EventHandler<CardArgs> expr_4E = this.OnDecrement;
			if (expr_4E != null)
			{
				expr_4E(this, this.CardEventArgs);
			}
			if (this.int_1 <= 0)
			{
				this.BtnAddToCart.Visible = true;
			}
		}
	}
}
