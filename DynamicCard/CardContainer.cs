using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicCard
{
	public class CardContainer : UserControl
	{
		[CompilerGenerated]
		private sealed class Class9
		{
			private sealed class Class10 : IAsyncStateMachine
			{
				public int int_0;

				public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

				public CardContainer.Class9 class9_0;

				private IEnumerable<CardArgs> ienumerable_0;

				private IEnumerator<CardArgs> ienumerator_0;

				private CardArgs cardArgs_0;

				private TaskAwaiter<IEnumerable<CardArgs>> taskAwaiter_0;

				private TaskAwaiter taskAwaiter_1;

				void IAsyncStateMachine.MoveNext()
				{
					int num = this.int_0;
					try
					{
						TaskAwaiter<IEnumerable<CardArgs>> awaiter;
						if (num != 0)
						{
							if (num == 1)
							{
								goto IL_CE;
							}
							this.class9_0.cardContainer_0.CardWrapper.Visible = false;
							awaiter = this.class9_0.cardContainer_0.method_3(this.class9_0.ienumerable_0).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int arg_55_1 = 0;
								num = 0;
								this.int_0 = arg_55_1;
								this.taskAwaiter_0 = awaiter;
								CardContainer.Class9.Class10 @class = this;
								this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<CardArgs>>, CardContainer.Class9.Class10>(ref awaiter, ref @class);
								return;
							}
						}
						else
						{
							awaiter = this.taskAwaiter_0;
							this.taskAwaiter_0 = default(TaskAwaiter<IEnumerable<CardArgs>>);
							int arg_8E_1 = -1;
							num = -1;
							this.int_0 = arg_8E_1;
						}
						this.ienumerable_0 = awaiter.GetResult();
						this.class9_0.ienumerable_0 = this.ienumerable_0;
						this.ienumerable_0 = null;
						this.ienumerator_0 = this.class9_0.ienumerable_0.GetEnumerator();
						IL_CE:
						try
						{
							TaskAwaiter awaiter2;
							if (num == 1)
							{
								awaiter2 = this.taskAwaiter_1;
								this.taskAwaiter_1 = default(TaskAwaiter);
								int arg_EC_1 = -1;
								num = -1;
								this.int_0 = arg_EC_1;
								goto IL_136;
							}
							IL_F3:
							if (!this.ienumerator_0.MoveNext())
							{
								goto IL_186;
							}
							this.cardArgs_0 = this.ienumerator_0.Current;
							awaiter2 = this.class9_0.cardContainer_0.method_5(this.cardArgs_0).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								int arg_14C_1 = 1;
								num = 1;
								this.int_0 = arg_14C_1;
								this.taskAwaiter_1 = awaiter2;
								CardContainer.Class9.Class10 @class = this;
								this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter, CardContainer.Class9.Class10>(ref awaiter2, ref @class);
								return;
							}
							IL_136:
							awaiter2.GetResult();
							this.cardArgs_0 = null;
							goto IL_F3;
						}
						finally
						{
							if (num < 0 && this.ienumerator_0 != null)
							{
								this.ienumerator_0.Dispose();
							}
						}
						IL_186:
						this.ienumerator_0 = null;
						this.class9_0.cardContainer_0.CardWrapper.Visible = true;
						EventHandler<CardArgs> expr_1B3 = this.class9_0.cardContainer_0.OnLoaded;
						if (expr_1B3 != null)
						{
							expr_1B3(this.class9_0.cardContainer_0, new CardArgs
							{
								TotalCards = this.class9_0.ienumerable_0.Count<CardArgs>()
							});
						}
						this.class9_0.cardContainer_0.timer_0.Stop();
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

			public CardContainer cardContainer_0;

			public IEnumerable<CardArgs> ienumerable_0;

			public MethodInvoker methodInvoker_0;

			internal void method_0()
			{
				Control arg_2A_0 = this.cardContainer_0.CardWrapper;
				MethodInvoker arg_2A_1;
				if ((arg_2A_1 = this.methodInvoker_0) == null)
				{
					arg_2A_1 = (this.methodInvoker_0 = new MethodInvoker(this.method_1));
				}
				arg_2A_0.Invoke(arg_2A_1);
			}

			[DebuggerStepThrough, AsyncStateMachine(typeof(CardContainer.Class9.Class10))]
			internal void method_1()
			{
				CardContainer.Class9.Class10 @class = new CardContainer.Class9.Class10();
				@class.class9_0 = this;
				@class.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
				@class.int_0 = -1;
				AsyncVoidMethodBuilder asyncVoidMethodBuilder_ = @class.asyncVoidMethodBuilder_0;
				asyncVoidMethodBuilder_.Start<CardContainer.Class9.Class10>(ref @class);
			}
		}

		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			public static readonly CardContainer.<>c <>c_0 = new CardContainer.<>c();

			public static Func<CardArgs, string> func_0;

			public static Func<CardArgs, string> func_1;

			public static Func<Card, string> func_2;

			public static Func<Card, string> func_3;

			public static Func<CardArgs, string> func_4;

			public static Func<CardArgs, string> func_5;

			public static Func<Card, string> func_6;

			public static Func<Card, string> func_7;

			internal string method_0(CardArgs cardArgs_0)
			{
				return cardArgs_0.Title;
			}

			internal string method_1(CardArgs cardArgs_0)
			{
				return cardArgs_0.Title;
			}

			internal string method_2(Card card_0)
			{
				return card_0.Title;
			}

			internal string method_3(Card card_0)
			{
				return card_0.Title;
			}

			internal string method_4(CardArgs cardArgs_0)
			{
				return cardArgs_0.Title;
			}

			internal string method_5(CardArgs cardArgs_0)
			{
				return cardArgs_0.Title;
			}

			internal string method_6(Card card_0)
			{
				return card_0.Title;
			}

			internal string method_7(Card card_0)
			{
				return card_0.Title;
			}
		}

		[CompilerGenerated]
		private sealed class Class12
		{
			public CardContainer cardContainer_0;

			public IEnumerable<CardArgs> ienumerable_0;

			internal IEnumerable<CardArgs> method_0()
			{
				if (this.cardContainer_0.OrderBy == OrderBy.ASCENDING)
				{
					IEnumerable<CardArgs> arg_36_0 = this.ienumerable_0;
					Func<CardArgs, string> arg_36_1;
					if ((arg_36_1 = CardContainer.<>c.func_4) == null)
					{
						arg_36_1 = (CardContainer.<>c.func_4 = new Func<CardArgs, string>(CardContainer.<>c.<>c_0.method_4));
					}
					this.ienumerable_0 = arg_36_0.OrderBy(arg_36_1);
				}
				if (this.cardContainer_0.OrderBy == OrderBy.DESCENDING)
				{
					IEnumerable<CardArgs> arg_76_0 = this.ienumerable_0;
					Func<CardArgs, string> arg_76_1;
					if ((arg_76_1 = CardContainer.<>c.func_5) == null)
					{
						arg_76_1 = (CardContainer.<>c.func_5 = new Func<CardArgs, string>(CardContainer.<>c.<>c_0.method_5));
					}
					this.ienumerable_0 = arg_76_0.OrderByDescending(arg_76_1);
				}
				return this.ienumerable_0;
			}
		}

		[CompilerGenerated]
		private sealed class Class14
		{
			public CardContainer cardContainer_0;

			public IEnumerable<Card> ienumerable_0;

			internal IEnumerable<Card> method_0()
			{
				if (this.cardContainer_0.OrderBy == OrderBy.ASCENDING)
				{
					IEnumerable<Card> arg_36_0 = this.ienumerable_0;
					Func<Card, string> arg_36_1;
					if ((arg_36_1 = CardContainer.<>c.func_6) == null)
					{
						arg_36_1 = (CardContainer.<>c.func_6 = new Func<Card, string>(CardContainer.<>c.<>c_0.method_6));
					}
					this.ienumerable_0 = arg_36_0.OrderBy(arg_36_1);
				}
				if (this.cardContainer_0.OrderBy == OrderBy.DESCENDING)
				{
					IEnumerable<Card> arg_76_0 = this.ienumerable_0;
					Func<Card, string> arg_76_1;
					if ((arg_76_1 = CardContainer.<>c.func_7) == null)
					{
						arg_76_1 = (CardContainer.<>c.func_7 = new Func<Card, string>(CardContainer.<>c.<>c_0.method_7));
					}
					this.ienumerable_0 = arg_76_0.OrderByDescending(arg_76_1);
				}
				return this.ienumerable_0;
			}
		}

		[CompilerGenerated]
		private sealed class Class16
		{
			public CardContainer cardContainer_0;

			public CardArgs cardArgs_0;

			public EventHandler<CardArgs> eventHandler_0;

			public MethodInvoker methodInvoker_0;

			internal void method_0()
			{
				Control arg_2A_0 = this.cardContainer_0.CardWrapper;
				MethodInvoker arg_2A_1;
				if ((arg_2A_1 = this.methodInvoker_0) == null)
				{
					arg_2A_1 = (this.methodInvoker_0 = new MethodInvoker(this.method_1));
				}
				arg_2A_0.Invoke(arg_2A_1);
			}

			internal void method_1()
			{
				Card card = new Card(this.cardArgs_0.Key ?? "", this.cardArgs_0.Title ?? "", this.cardArgs_0.Price, this.cardArgs_0.ImagePath, this.cardContainer_0.Currency);
				card.Theme(this.cardContainer_0.cardTheme_0, this.cardContainer_0.color_0, this.cardContainer_0.color_1);
				this.cardContainer_0.CardWrapper.Controls.Add(card);
				this.cardContainer_0.list_0.Add(card);
				Card expr_9E = card;
				Delegate arg_C3_0 = expr_9E.OnCount;
				EventHandler<CardArgs> arg_C3_1;
				if ((arg_C3_1 = this.eventHandler_0) == null)
				{
					arg_C3_1 = (this.eventHandler_0 = new EventHandler<CardArgs>(this.method_2));
				}
				expr_9E.OnCount = (EventHandler<CardArgs>)Delegate.Combine(arg_C3_0, arg_C3_1);
			}

			internal void method_2(object object_0, CardArgs cardArgs_1)
			{
				EventHandler<CardArgs> expr_0B = this.cardContainer_0.eventHandler_0;
				if (expr_0B != null)
				{
					expr_0B(this.cardContainer_0, cardArgs_1);
				}
			}
		}

		[CompilerGenerated]
		private sealed class Class18
		{
			private sealed class Class19 : IAsyncStateMachine
			{
				public int int_0;

				public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

				public CardContainer.Class18 class18_0;

				private IEnumerable<Card> ienumerable_0;

				private IEnumerable<Card> ienumerable_1;

				private IEnumerator<Card> ienumerator_0;

				private Card card_0;

				private TaskAwaiter<IEnumerable<Card>> taskAwaiter_0;

				void IAsyncStateMachine.MoveNext()
				{
					int num = this.int_0;
					try
					{
						TaskAwaiter<IEnumerable<Card>> awaiter;
						if (num != 0)
						{
							IEnumerable<Card> arg_4C_0 = this.class18_0.cardContainer_0.list_0;
							Func<Card, bool> arg_4C_1;
							if ((arg_4C_1 = this.class18_0.func_0) == null)
							{
								arg_4C_1 = (this.class18_0.func_0 = new Func<Card, bool>(this.class18_0.method_2));
							}
							this.ienumerable_0 = arg_4C_0.Where(arg_4C_1);
							awaiter = this.class18_0.cardContainer_0.method_4(this.ienumerable_0).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								int arg_7F_1 = 0;
								num = 0;
								this.int_0 = arg_7F_1;
								this.taskAwaiter_0 = awaiter;
								CardContainer.Class18.Class19 @class = this;
								this.asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<Card>>, CardContainer.Class18.Class19>(ref awaiter, ref @class);
								return;
							}
						}
						else
						{
							awaiter = this.taskAwaiter_0;
							this.taskAwaiter_0 = default(TaskAwaiter<IEnumerable<Card>>);
							int arg_B8_1 = -1;
							num = -1;
							this.int_0 = arg_B8_1;
						}
						this.ienumerable_1 = awaiter.GetResult();
						this.ienumerable_0 = this.ienumerable_1;
						this.ienumerable_1 = null;
						this.class18_0.cardContainer_0.CardWrapper.Visible = false;
						this.class18_0.cardContainer_0.CardWrapper.Controls.Clear();
						this.ienumerator_0 = this.ienumerable_0.GetEnumerator();
						try
						{
							while (this.ienumerator_0.MoveNext())
							{
								this.card_0 = this.ienumerator_0.Current;
								this.card_0.Theme(this.class18_0.cardContainer_0.cardTheme_0, this.class18_0.cardContainer_0.color_0, this.class18_0.cardContainer_0.color_1);
								this.class18_0.cardContainer_0.CardWrapper.Controls.Add(this.card_0);
								this.card_0 = null;
							}
						}
						finally
						{
							if (num < 0 && this.ienumerator_0 != null)
							{
								this.ienumerator_0.Dispose();
							}
						}
						this.ienumerator_0 = null;
						EventHandler<CardArgs> expr_1D2 = this.class18_0.cardContainer_0.OnLoaded;
						if (expr_1D2 != null)
						{
							expr_1D2(this.class18_0.cardContainer_0, new CardArgs
							{
								TotalCards = this.ienumerable_0.Count<Card>()
							});
						}
						this.class18_0.cardContainer_0.CardWrapper.Visible = true;
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

			public CardContainer cardContainer_0;

			public string string_0;

			public Func<Card, bool> func_0;

			public MethodInvoker methodInvoker_0;

			internal void method_0()
			{
				Control arg_2A_0 = this.cardContainer_0.CardWrapper;
				MethodInvoker arg_2A_1;
				if ((arg_2A_1 = this.methodInvoker_0) == null)
				{
					arg_2A_1 = (this.methodInvoker_0 = new MethodInvoker(this.method_1));
				}
				arg_2A_0.Invoke(arg_2A_1);
			}

			[DebuggerStepThrough, AsyncStateMachine(typeof(CardContainer.Class18.Class19))]
			internal void method_1()
			{
				CardContainer.Class18.Class19 @class = new CardContainer.Class18.Class19();
				@class.class18_0 = this;
				@class.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
				@class.int_0 = -1;
				AsyncVoidMethodBuilder asyncVoidMethodBuilder_ = @class.asyncVoidMethodBuilder_0;
				asyncVoidMethodBuilder_.Start<CardContainer.Class18.Class19>(ref @class);
			}

			internal bool method_2(Card card_0)
			{
				return card_0.Title.ToLower().Contains(this.string_0.ToLower());
			}
		}

		public EventHandler<CardArgs> OnLoaded;

		private OrderBy orderBy_0 = OrderBy.ASCENDING;

		private string string_0 = "Php";

		private Color color_0 = Color.FromArgb(255, 0, 128);

		private Color color_1 = Color.Crimson;

		private Card.CardTheme cardTheme_0 = Card.CardTheme.Light;

		[DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
		private EventHandler<CardArgs> eventHandler_0;

		private List<Card> list_0;

		private int int_0 = 0;

		private IContainer icontainer_0 = null;

		private FlowLayoutPanel CardWrapper;

		private Label label1;

		private System.Windows.Forms.Timer timer_0;

		public event EventHandler<CardArgs> OnCounted
		{
			[CompilerGenerated]
			add
			{
				EventHandler<CardArgs> eventHandler = this.eventHandler_0;
				EventHandler<CardArgs> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<CardArgs> value2 = (EventHandler<CardArgs>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<CardArgs>>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler<CardArgs> eventHandler = this.eventHandler_0;
				EventHandler<CardArgs> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<CardArgs> value2 = (EventHandler<CardArgs>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<CardArgs>>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		public string Currency
		{
			get
			{
				return this.string_0;
			}
			set
			{
				this.string_0 = value;
			}
		}

		public OrderBy OrderBy
		{
			get
			{
				return this.orderBy_0;
			}
			set
			{
				this.orderBy_0 = value;
			}
		}

		public Color Primary
		{
			get
			{
				return this.color_0;
			}
			set
			{
				this.color_0 = value;
			}
		}

		public Color Secondary
		{
			get
			{
				return this.color_1;
			}
			set
			{
				this.color_1 = value;
			}
		}

		public Card.CardTheme Theme
		{
			get
			{
				return this.cardTheme_0;
			}
			set
			{
				this.cardTheme_0 = value;
			}
		}

		public CardContainer()
		{
			this.InitializeComponent();
			this.method_0();
			this.list_0 = new List<Card>();
		}

		private void method_0()
		{
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
		}

		public void Add(CardArgs source)
		{
			if (source == null)
			{
				throw new Exception("CardArgs is null!");
			}
			this.method_6(source);
		}

		[DebuggerStepThrough, AsyncStateMachine(typeof(CardContainer.Class8))]
		public Task AddAsync(CardArgs source)
		{
			CardContainer.Class8 @class = new CardContainer.Class8();
			@class.cardContainer_0 = this;
			@class.cardArgs_0 = source;
			@class.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@class.int_0 = -1;
			AsyncTaskMethodBuilder asyncTaskMethodBuilder_ = @class.asyncTaskMethodBuilder_0;
			asyncTaskMethodBuilder_.Start<CardContainer.Class8>(ref @class);
			return @class.asyncTaskMethodBuilder_0.Task;
		}

		public IEnumerable<CardArgs> AddRange(IEnumerable<CardArgs> sources)
		{
			if (sources == null)
			{
				throw new Exception("List of CardArgs is null!");
			}
			this.CardWrapper.Visible = false;
			sources = this.method_1(sources);
			foreach (CardArgs current in sources)
			{
				this.method_6(current);
			}
			this.CardWrapper.Visible = true;
			return sources;
		}

		[DebuggerStepThrough, AsyncStateMachine(typeof(CardContainer.Class11))]
		public Task<IEnumerable<CardArgs>> AddRangeAsync(IEnumerable<CardArgs> sources)
		{
			CardContainer.Class11 @class = new CardContainer.Class11();
			@class.cardContainer_0 = this;
			@class.ienumerable_0 = sources;
			@class.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<IEnumerable<CardArgs>>.Create();
			@class.int_0 = -1;
			AsyncTaskMethodBuilder<IEnumerable<CardArgs>> asyncTaskMethodBuilder_ = @class.asyncTaskMethodBuilder_0;
			asyncTaskMethodBuilder_.Start<CardContainer.Class11>(ref @class);
			return @class.asyncTaskMethodBuilder_0.Task;
		}

		private IEnumerable<CardArgs> method_1(IEnumerable<CardArgs> ienumerable_0)
		{
			if (this.OrderBy == OrderBy.ASCENDING)
			{
				IEnumerable<CardArgs> arg_2B_0 = ienumerable_0;
				Func<CardArgs, string> arg_2B_1;
				if ((arg_2B_1 = CardContainer.<>c.func_0) == null)
				{
					arg_2B_1 = (CardContainer.<>c.func_0 = new Func<CardArgs, string>(CardContainer.<>c.<>c_0.method_0));
				}
				ienumerable_0 = arg_2B_0.OrderBy(arg_2B_1);
			}
			if (this.OrderBy == OrderBy.DESCENDING)
			{
				IEnumerable<CardArgs> arg_5F_0 = ienumerable_0;
				Func<CardArgs, string> arg_5F_1;
				if ((arg_5F_1 = CardContainer.<>c.func_1) == null)
				{
					arg_5F_1 = (CardContainer.<>c.func_1 = new Func<CardArgs, string>(CardContainer.<>c.<>c_0.method_1));
				}
				ienumerable_0 = arg_5F_0.OrderByDescending(arg_5F_1);
			}
			return ienumerable_0;
		}

		private IEnumerable<Card> method_2(IEnumerable<Card> ienumerable_0)
		{
			if (this.OrderBy == OrderBy.ASCENDING)
			{
				IEnumerable<Card> arg_2B_0 = ienumerable_0;
				Func<Card, string> arg_2B_1;
				if ((arg_2B_1 = CardContainer.<>c.func_2) == null)
				{
					arg_2B_1 = (CardContainer.<>c.func_2 = new Func<Card, string>(CardContainer.<>c.<>c_0.method_2));
				}
				ienumerable_0 = arg_2B_0.OrderBy(arg_2B_1);
			}
			if (this.OrderBy == OrderBy.DESCENDING)
			{
				IEnumerable<Card> arg_5F_0 = ienumerable_0;
				Func<Card, string> arg_5F_1;
				if ((arg_5F_1 = CardContainer.<>c.func_3) == null)
				{
					arg_5F_1 = (CardContainer.<>c.func_3 = new Func<Card, string>(CardContainer.<>c.<>c_0.method_3));
				}
				ienumerable_0 = arg_5F_0.OrderByDescending(arg_5F_1);
			}
			return ienumerable_0;
		}

		[DebuggerStepThrough, AsyncStateMachine(typeof(CardContainer.Class13))]
		private Task<IEnumerable<CardArgs>> method_3(IEnumerable<CardArgs> ienumerable_0)
		{
			CardContainer.Class13 @class = new CardContainer.Class13();
			@class.cardContainer_0 = this;
			@class.ienumerable_0 = ienumerable_0;
			@class.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<IEnumerable<CardArgs>>.Create();
			@class.int_0 = -1;
			AsyncTaskMethodBuilder<IEnumerable<CardArgs>> asyncTaskMethodBuilder_ = @class.asyncTaskMethodBuilder_0;
			asyncTaskMethodBuilder_.Start<CardContainer.Class13>(ref @class);
			return @class.asyncTaskMethodBuilder_0.Task;
		}

		[DebuggerStepThrough, AsyncStateMachine(typeof(CardContainer.Class15))]
		private Task<IEnumerable<Card>> method_4(IEnumerable<Card> ienumerable_0)
		{
			CardContainer.Class15 @class = new CardContainer.Class15();
			@class.cardContainer_0 = this;
			@class.ienumerable_0 = ienumerable_0;
			@class.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<IEnumerable<Card>>.Create();
			@class.int_0 = -1;
			AsyncTaskMethodBuilder<IEnumerable<Card>> asyncTaskMethodBuilder_ = @class.asyncTaskMethodBuilder_0;
			asyncTaskMethodBuilder_.Start<CardContainer.Class15>(ref @class);
			return @class.asyncTaskMethodBuilder_0.Task;
		}

		[DebuggerStepThrough, AsyncStateMachine(typeof(CardContainer.Class17))]
		private Task method_5(CardArgs cardArgs_0)
		{
			CardContainer.Class17 @class = new CardContainer.Class17();
			@class.cardContainer_0 = this;
			@class.cardArgs_0 = cardArgs_0;
			@class.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@class.int_0 = -1;
			AsyncTaskMethodBuilder asyncTaskMethodBuilder_ = @class.asyncTaskMethodBuilder_0;
			asyncTaskMethodBuilder_.Start<CardContainer.Class17>(ref @class);
			return @class.asyncTaskMethodBuilder_0.Task;
		}

		private void method_6(CardArgs cardArgs_0)
		{
			Card card = new Card(cardArgs_0.Key ?? "", cardArgs_0.Title ?? "", cardArgs_0.Price, cardArgs_0.ImagePath, this.Currency);
			card.Theme(this.cardTheme_0, this.color_0, this.color_1);
			this.CardWrapper.Controls.Add(card);
			this.list_0.Add(card);
			Card expr_6C = card;
			expr_6C.OnCount = (EventHandler<CardArgs>)Delegate.Combine(expr_6C.OnCount, new EventHandler<CardArgs>(this.method_7));
		}

		[DebuggerStepThrough, AsyncStateMachine(typeof(CardContainer.Class20))]
		public new Task Load(string key = "")
		{
			CardContainer.Class20 @class = new CardContainer.Class20();
			@class.cardContainer_0 = this;
			@class.string_0 = key;
			@class.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
			@class.int_0 = -1;
			AsyncTaskMethodBuilder asyncTaskMethodBuilder_ = @class.asyncTaskMethodBuilder_0;
			asyncTaskMethodBuilder_.Start<CardContainer.Class20>(ref @class);
			return @class.asyncTaskMethodBuilder_0.Task;
		}

		public void Reset()
		{
			this.CardWrapper.Visible = false;
			this.list_0.Clear();
			Card.List = null;
			Card.TotalQuantity = 0;
			Card.Total = 0.0;
			this.CardWrapper.Controls.Clear();
		}

		private void timer_0_Tick(object sender, EventArgs e)
		{
			this.int_0++;
			if (this.int_0 == 3)
			{
				this.label1.Visible = true;
				this.label1.Text = "|";
			}
			else if (this.int_0 == 4)
			{
				this.label1.Text = "/";
			}
			else if (this.int_0 == 5)
			{
				this.label1.Text = "--";
			}
			else if (this.int_0 == 6)
			{
				this.label1.Text = "\\";
			}
			else if (this.int_0 == 7)
			{
				this.int_0 = 2;
			}
		}

		private void CardWrapper_Paint(object sender, PaintEventArgs e)
		{
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.icontainer_0 = new Container();
			this.CardWrapper = new FlowLayoutPanel();
			this.label1 = new Label();
			this.timer_0 = new System.Windows.Forms.Timer(this.icontainer_0);
			base.SuspendLayout();
			this.CardWrapper.AutoScroll = true;
			this.CardWrapper.BackColor = Color.White;
			this.CardWrapper.Dock = DockStyle.Fill;
			this.CardWrapper.Location = new Point(0, 0);
			this.CardWrapper.Name = "CardWrapper";
			this.CardWrapper.Padding = new Padding(0, 0, 0, 5);
			this.CardWrapper.Size = new Size(514, 318);
			this.CardWrapper.TabIndex = 0;
			this.CardWrapper.Paint += new PaintEventHandler(this.CardWrapper_Paint);
			this.label1.AutoSize = true;
			this.label1.Font = new Font("Century Gothic", 20.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label1.Location = new Point(8, 2);
			this.label1.Name = "label1";
			this.label1.Size = new Size(31, 32);
			this.label1.TabIndex = 1;
			this.label1.Text = "|";
			this.label1.Visible = false;
			this.timer_0.Interval = 50;
			this.timer_0.Tick += new EventHandler(this.timer_0_Tick);
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.CardWrapper);
			base.Controls.Add(this.label1);
			base.Name = "CardContainer";
			base.Size = new Size(514, 318);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		[CompilerGenerated]
		private void method_7(object object_0, CardArgs cardArgs_0)
		{
			EventHandler<CardArgs> expr_06 = this.eventHandler_0;
			if (expr_06 != null)
			{
				expr_06(this, cardArgs_0);
			}
		}
	}
}
