using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;

// Token: 0x0200084A RID: 2122
public abstract class 1891
{
	// Token: 0x06003D92 RID: 15762 RVA: 0x00183D00 File Offset: 0x00181F00
	protected 1891(1262 1)
	{
		this.1 = 1.64();
	}

	// Token: 0x06003D93 RID: 15763
	protected abstract 2147 GetPlayMode();

	// Token: 0x06003D94 RID: 15764 RVA: 0x00183D23 File Offset: 0x00181F23
	public virtual 1898[] GetModOptions()
	{
		return this.8;
	}

	// Token: 0x06003D95 RID: 15765 RVA: 0x00183D2B File Offset: 0x00181F2B
	public virtual void SetModOptions(1898[] 1)
	{
		this.8 = 1;
	}

	// Token: 0x06003D96 RID: 15766 RVA: 0x00183D34 File Offset: 0x00181F34
	public 2023[] 1()
	{
		IEnumerable<2023> enumerable = this.5().Select(new Func<1898, 2023>(this.4));
		return this.3(enumerable).Distinct<2023>().ToArray<2023>();
	}

	// Token: 0x06003D97 RID: 15767 RVA: 0x00183D6C File Offset: 0x00181F6C
	private static int 2(2023 1)
	{
		2023 2 = 1 & 2023.KeyMod & ~2023.KeyCoop;
		int num = 0;
		while (2 != 2023.None)
		{
			2 &= 2 - 1;
			num++;
		}
		return num;
	}

	// Token: 0x06003D98 RID: 15768 RVA: 0x00183D99 File Offset: 0x00181F99
	private IEnumerable<2023> 3(IEnumerable<2023> 1)
	{
		return new 1891.1895(-2)
		{
			5 = 1
		};
	}

	// Token: 0x06003D99 RID: 15769 RVA: 0x00183DAC File Offset: 0x00181FAC
	private 2023 4(1898 1)
	{
		1913 5 = 4 as 1913;
		if (5 != null)
		{
			return 5.1();
		}
		1888 3 = 4 as 1888;
		if (3 != null)
		{
			return 3.1().Aggregate(2023.None, (2023 1, 1898 2) => 1 | this.4(2));
		}
		throw new InvalidOperationException();
	}

	// Token: 0x06003D9A RID: 15770 RVA: 0x00183DF2 File Offset: 0x00181FF2
	private 1898[] 5()
	{
		return 1891.13(this.GetModOptions() ?? new 1898[0], new 1898[0], 0).ToArray<1898>();
	}

	// Token: 0x06003D9B RID: 15771 RVA: 0x00183E15 File Offset: 0x00182015
	public virtual void ReleaseHitObjectManager()
	{
		2039 <<EMPTY_NAME>> = this.2;
		if (<<EMPTY_NAME>> != null)
		{
			<<EMPTY_NAME>>.Dispose();
		}
		this.2 = null;
	}

	// Token: 0x06003D9C RID: 15772 RVA: 0x00183E2F File Offset: 0x0018202F
	public static 2023 6(2023 1)
	{
		return 1 & (2093.18(1) | 2171.17() | 1850.17() | 1957.18());
	}

	// Token: 0x06003D9D RID: 15773 RVA: 0x00183E4C File Offset: 0x0018204C
	public static 2023 7(2023 1, 2147 2, 1262 3)
	{
		2023 result;
		switch (2)
		{
		case 2147.Taiko:
			result = (1 & 2171.17());
			break;
		case 2147.CatchTheBeat:
			result = (1 & 1850.17());
			break;
		case 2147.OsuMania:
			result = (2011.55(3, 1) & 1957.18());
			break;
		default:
			result = (1 & 2093.18(1));
			break;
		}
		return result;
	}

	// Token: 0x06003D9E RID: 15774
	internal abstract 2039 CreateHitObjectManager();

	// Token: 0x06003D9F RID: 15775 RVA: 0x0000FF75 File Offset: 0x0000E175
	protected virtual bool RequiresReload(2023 1)
	{
		return false;
	}

	// Token: 0x06003DA0 RID: 15776 RVA: 0x00005ADD File Offset: 0x00003CDD
	protected virtual void ProcessHitObjects()
	{
	}

	// Token: 0x06003DA1 RID: 15777
	protected abstract double Calculate(Dictionary<string, string> 1);

	// Token: 0x06003DA2 RID: 15778 RVA: 0x00183E9D File Offset: 0x0018209D
	protected virtual double Method9854()
	{
		return -1.0;
	}

	// Token: 0x06003DA3 RID: 15779
	protected abstract bool Method1820();

	// Token: 0x06003DA4 RID: 15780 RVA: 0x00183EA8 File Offset: 0x001820A8
	private void 8()
	{
		2023 <<EMPTY_NAME>> = this.2.22;
		2023 2 = 2023.DoubleTime;
		int num;
		if ((<<EMPTY_NAME>> & 2) > 2023.None)
		{
			num = 150;
		}
		else
		{
			2023 3 = this.2.22;
			2 = 2023.HalfTime;
			num = (((3 & 2) <= 2023.None) ? 100 : 75);
		}
		this.4 = ((this.6 != null) ? 1939.17(this.2.22, this.6) : ((double)num / 100.0));
	}

	// Token: 0x06003DA5 RID: 15781 RVA: 0x00183F30 File Offset: 0x00182130
	private void 9(2023 1)
	{
		this.3 = null;
		2039 2 = this.2;
		if (2 != null)
		{
			2.Dispose();
		}
		this.2 = this.CreateHitObjectManager();
		if (!this.1.59)
		{
			int 3 = this.1.25;
			this.1.65();
			this.1.25 = 3;
		}
		this.2.45 = this.5;
		this.2.46 = this.6;
		this.2.47 = this.7;
		this.2.6(this.1, 1);
		this.8();
		this.2.RecalculateDifficulty(false, false, true);
		if (this.1.59)
		{
			this.2.48(1288.HitObjects, false, true, true);
			this.3 = new List<2034>(this.2.34);
			this.ProcessHitObjects();
			if (this.2 is 2122)
			{
				this.2.38();
				if (this.7 != null && this.7.7 != null)
				{
					this.2.54 = delegate()
					{
						this.3 = new List<2034>(this.2.34);
						this.ProcessHitObjects();
					};
					this.2.10();
				}
			}
		}
	}

	// Token: 0x06003DA6 RID: 15782 RVA: 0x00184074 File Offset: 0x00182274
	private void 10(2039 1)
	{
		this.1 = 1.21;
		if (this.2 != 1)
		{
			2039 2 = this.2;
			if (2 != null)
			{
				2.Dispose();
			}
		}
		1.41();
		this.2 = this.CreateHitObjectManager();
		this.2.45 = this.5;
		this.2.46 = this.6;
		this.2.6(this.1, 1.22);
		this.8();
		this.2.RecalculateDifficulty(false, false, false);
		this.2.49(1.34);
		this.3 = this.2.34;
		this.ProcessHitObjects();
		this.2.38();
	}

	// Token: 0x06003DA7 RID: 15783 RVA: 0x0018413E File Offset: 0x0018233E
	protected void 11()
	{
		if (this.11)
		{
			throw new OperationCanceledException();
		}
	}

	// Token: 0x06003DA8 RID: 15784 RVA: 0x00184150 File Offset: 0x00182350
	internal double 12(2023 1, Dictionary<string, string> 2, 2039 3)
	{
		if (this.1 == null)
		{
			return -1.0;
		}
		double result;
		try
		{
			if (3 != null)
			{
				this.10(3);
				if (this.3 == null)
				{
					return 0.0;
				}
			}
			else if (this.3 == null || this.RequiresReload(4))
			{
				this.9(4);
				if (this.3 == null)
				{
					return 0.0;
				}
			}
			else
			{
				this.2.22 = 4;
				this.8();
				this.2.RecalculateDifficulty(false, false, false);
			}
			if (this.9 != null || this.10 != null)
			{
				int windowStart = this.9.GetValueOrDefault(int.MinValue);
				int windowEnd = this.10.GetValueOrDefault(int.MaxValue);
				this.3 = this.3.FindAll((2034 1) => 1.1 >= windowStart && 1.1 <= windowEnd);
			}
			result = this.Calculate(2);
		}
		catch (Exception)
		{
			result = 0.0;
		}
		return result;
	}

	// Token: 0x06003DA9 RID: 15785 RVA: 0x00184278 File Offset: 0x00182478
	internal static IEnumerable<1898> 13(1898[] 1, IEnumerable<1898> 2, int 3)
	{
		return new 1891.1894(-2)
		{
			9 = 1,
			7 = 2,
			5 = 3
		};
	}

	// Token: 0x06003DAA RID: 15786 RVA: 0x00184298 File Offset: 0x00182498
	internal static 1901 14(1898 1)
	{
		1913 2 = 1 as 1913;
		if (2 != null)
		{
			1901 3 = new 1901();
			3.2(new 1913[]
			{
				2
			});
			3.4(1);
			return 3;
		}
		1888 4 = 1 as 1888;
		if (4 == null)
		{
			throw new InvalidOperationException();
		}
		IEnumerable<1898> first = Enumerable.Empty<1898>();
		int num = 0;
		1898[] array = 4.1();
		for (int i = 0; i < array.Length; i++)
		{
			1901 5 = 1891.14(array[i]);
			first = first.Concat(5.1());
			num += 5.3();
		}
		1901 6 = new 1901();
		6.2(first);
		6.4(num);
		return 6;
	}

	// Token: 0x04002D3C RID: 11580
	internal 1262 1;

	// Token: 0x04002D3D RID: 11581
	internal 2039 2;

	// Token: 0x04002D3E RID: 11582
	internal List<2034> 3;

	// Token: 0x04002D3F RID: 11583
	internal double 4 = 1.0;

	// Token: 0x04002D40 RID: 11584
	internal 1927 5;

	// Token: 0x04002D41 RID: 11585
	internal 1940 6;

	// Token: 0x04002D42 RID: 11586
	internal 1925 7;

	// Token: 0x04002D43 RID: 11587
	private 1898[] 8;

	// Token: 0x04002D44 RID: 11588
	internal int? 9;

	// Token: 0x04002D45 RID: 11589
	internal int? 10;

	// Token: 0x04002D46 RID: 11590
	internal volatile bool 11;

	// Token: 0x0200084B RID: 2123
	public sealed class 1894 : IEnumerable<1898>, IEnumerable, IEnumerator<1898>, IDisposable, IEnumerator
	{
		// Token: 0x06003DAD RID: 15789 RVA: 0x00184361 File Offset: 0x00182561
		[DebuggerHidden]
		public 1894(int 1)
		{
			this.1 = 1;
			this.3 = Thread.CurrentThread.ManagedThreadId;
		}

		// Token: 0x06003DAE RID: 15790 RVA: 0x00184380 File Offset: 0x00182580
		[DebuggerHidden]
		private void 1()
		{
			int num = this.1;
			if (num == -3 || num == 4)
			{
				try
				{
				}
				finally
				{
					this.3();
				}
			}
		}

		// Token: 0x06003DAF RID: 15791 RVA: 0x001843B8 File Offset: 0x001825B8
		void IDisposable.Dispose()
		{
			this.1();
		}

		// Token: 0x06003DB0 RID: 15792 RVA: 0x001843C0 File Offset: 0x001825C0
		private bool 2()
		{
			bool result;
			try
			{
				switch (this.1)
				{
				case 0:
				{
					this.1 = -1;
					int num = this.4;
					if (num == 0)
					{
						this.2 = new 1913(2023.None);
						this.1 = 1;
						return true;
					}
					if (num != 1)
					{
						this.2 = new 1888(this.6.ToArray<1898>());
						this.1 = 3;
						return true;
					}
					this.2 = this.6.Single<1898>();
					this.1 = 2;
					return true;
				}
				case 1:
					this.1 = -1;
					break;
				case 2:
					this.1 = -1;
					break;
				case 3:
					this.1 = -1;
					break;
				case 4:
					this.1 = -3;
					goto IL_19B;
				default:
					return false;
				}
				this.10 = 0;
				IL_CB:
				if (this.10 >= this.8.Length)
				{
					return false;
				}
				1891.1892 moveNextClosure = new 1891.1892();
				moveNextClosure.1 = 1891.14(this.8[this.10]);
				if (!this.6.Any(delegate(1898 1)
				{
					1891.1893 moveNextClosure2 = new 1891.1893();
					moveNextClosure2.1 = 1;
					return moveNextClosure.1.1().Any((1898 1) => moveNextClosure2.1.GetHashCode() == 1.GetHashCode());
				}))
				{
					this.11 = 1891.13(this.8.1(this.10 + 1), this.6.Concat(moveNextClosure.1.1()), this.4 + moveNextClosure.1.3()).GetEnumerator();
					this.1 = -3;
					goto IL_19B;
				}
				IL_188:
				this.10++;
				goto IL_CB;
				IL_19B:
				if (!this.11.MoveNext())
				{
					this.3();
					this.11 = null;
					goto IL_188;
				}
				1898 <<EMPTY_NAME>> = this.11.Current;
				this.2 = <<EMPTY_NAME>>;
				this.1 = 4;
				result = true;
			}
			catch
			{
				this.1();
				throw;
			}
			return result;
		}

		// Token: 0x06003DB1 RID: 15793 RVA: 0x001845CC File Offset: 0x001827CC
		bool IEnumerator.MoveNext()
		{
			return this.2();
		}

		// Token: 0x06003DB2 RID: 15794 RVA: 0x001845D4 File Offset: 0x001827D4
		private void 3()
		{
			this.1 = -1;
			if (this.11 != null)
			{
				this.11.Dispose();
			}
		}

		// Token: 0x06003DB3 RID: 15795 RVA: 0x001845F0 File Offset: 0x001827F0
		[DebuggerHidden]
		private 1898 4()
		{
			return this.2;
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06003DB4 RID: 15796 RVA: 0x001845F8 File Offset: 0x001827F8
		1898 IEnumerator<1898>.Current
		{
			get
			{
				return this.4();
			}
		}

		// Token: 0x06003DB5 RID: 15797 RVA: 0x00005BE8 File Offset: 0x00003DE8
		[DebuggerHidden]
		private void 5()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06003DB6 RID: 15798 RVA: 0x00184600 File Offset: 0x00182800
		void IEnumerator.Reset()
		{
			this.5();
		}

		// Token: 0x06003DB7 RID: 15799 RVA: 0x001845F0 File Offset: 0x001827F0
		[DebuggerHidden]
		private object 6()
		{
			return this.2;
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06003DB8 RID: 15800 RVA: 0x00184608 File Offset: 0x00182808
		object IEnumerator.Current
		{
			get
			{
				return this.6();
			}
		}

		// Token: 0x06003DB9 RID: 15801 RVA: 0x00184610 File Offset: 0x00182810
		[DebuggerHidden]
		private IEnumerator<1898> 7()
		{
			1891.1894 <<EMPTY_NAME>>;
			if (this.1 == -2 && this.3 == Thread.CurrentThread.ManagedThreadId)
			{
				this.1 = 0;
				<<EMPTY_NAME>> = this;
			}
			else
			{
				<<EMPTY_NAME>> = new 1891.1894(0);
			}
			<<EMPTY_NAME>>.8 = this.9;
			<<EMPTY_NAME>>.6 = this.7;
			<<EMPTY_NAME>>.4 = this.5;
			return <<EMPTY_NAME>>;
		}

		// Token: 0x06003DBA RID: 15802 RVA: 0x00184670 File Offset: 0x00182870
		IEnumerator<1898> IEnumerable<1898>.GetEnumerator()
		{
			return this.7();
		}

		// Token: 0x06003DBB RID: 15803 RVA: 0x00184670 File Offset: 0x00182870
		[DebuggerHidden]
		private IEnumerator 8()
		{
			return this.7();
		}

		// Token: 0x06003DBC RID: 15804 RVA: 0x00184678 File Offset: 0x00182878
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.8();
		}

		// Token: 0x04002D47 RID: 11591
		private int 1;

		// Token: 0x04002D48 RID: 11592
		private 1898 2;

		// Token: 0x04002D49 RID: 11593
		private int 3;

		// Token: 0x04002D4A RID: 11594
		private int 4;

		// Token: 0x04002D4B RID: 11595
		public int 5;

		// Token: 0x04002D4C RID: 11596
		private IEnumerable<1898> 6;

		// Token: 0x04002D4D RID: 11597
		public IEnumerable<1898> 7;

		// Token: 0x04002D4E RID: 11598
		private 1898[] 8;

		// Token: 0x04002D4F RID: 11599
		public 1898[] 9;

		// Token: 0x04002D50 RID: 11600
		private int 10;

		// Token: 0x04002D51 RID: 11601
		private IEnumerator<1898> 11;
	}

	// Token: 0x0200084E RID: 2126
	public sealed class 1892
	{
		// Token: 0x04002D54 RID: 11604
		public 1901 1;
	}

	// Token: 0x0200084F RID: 2127
	public sealed class 1893
	{
		// Token: 0x04002D55 RID: 11605
		public 1898 1;
	}

	// Token: 0x02000850 RID: 2128
	public sealed class 1895 : IEnumerable<2023>, IEnumerable, IEnumerator<2023>, IDisposable, IEnumerator
	{
		// Token: 0x06003DC3 RID: 15811 RVA: 0x001846E5 File Offset: 0x001828E5
		[DebuggerHidden]
		public 1895(int 1)
		{
			this.1 = 1;
			this.3 = Thread.CurrentThread.ManagedThreadId;
		}

		// Token: 0x06003DC4 RID: 15812 RVA: 0x00184704 File Offset: 0x00182904
		[DebuggerHidden]
		private void 1()
		{
			int num = this.1;
			if (num == -3 || num == 1)
			{
				try
				{
				}
				finally
				{
					this.3();
				}
			}
		}

		// Token: 0x06003DC5 RID: 15813 RVA: 0x0018473C File Offset: 0x0018293C
		void IDisposable.Dispose()
		{
			this.1();
		}

		// Token: 0x06003DC6 RID: 15814 RVA: 0x00184744 File Offset: 0x00182944
		private bool 2()
		{
			bool result;
			try
			{
				int num = this.1;
				if (num != 0)
				{
					if (num != 1)
					{
						return false;
					}
					this.1 = -3;
				}
				else
				{
					this.1 = -1;
					this.6 = this.4.GetEnumerator();
					this.1 = -3;
				}
				while (this.6.MoveNext())
				{
					2023 <<EMPTY_NAME>> = this.6.Current;
					if ((<<EMPTY_NAME>> & (2023.DoubleTime | 2023.HalfTime)) != (2023.DoubleTime | 2023.HalfTime) && (<<EMPTY_NAME>> & (2023.Easy | 2023.HardRock)) != (2023.Easy | 2023.HardRock) && (<<EMPTY_NAME>> & (2023.Relax | 2023.Relax2)) != (2023.Relax | 2023.Relax2) && 1891.2(<<EMPTY_NAME>>) <= 1)
					{
						this.2 = <<EMPTY_NAME>>;
						this.1 = 1;
						return true;
					}
				}
				this.3();
				this.6 = null;
				result = false;
			}
			catch
			{
				this.1();
				throw;
			}
			return result;
		}

		// Token: 0x06003DC7 RID: 15815 RVA: 0x00184818 File Offset: 0x00182A18
		bool IEnumerator.MoveNext()
		{
			return this.2();
		}

		// Token: 0x06003DC8 RID: 15816 RVA: 0x00184820 File Offset: 0x00182A20
		private void 3()
		{
			this.1 = -1;
			if (this.6 != null)
			{
				this.6.Dispose();
			}
		}

		// Token: 0x06003DC9 RID: 15817 RVA: 0x0018483C File Offset: 0x00182A3C
		[DebuggerHidden]
		private 2023 4()
		{
			return this.2;
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06003DCA RID: 15818 RVA: 0x00184844 File Offset: 0x00182A44
		2023 IEnumerator<2023>.Current
		{
			get
			{
				return this.4();
			}
		}

		// Token: 0x06003DCB RID: 15819 RVA: 0x00005BE8 File Offset: 0x00003DE8
		[DebuggerHidden]
		private void 5()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06003DCC RID: 15820 RVA: 0x0018484C File Offset: 0x00182A4C
		void IEnumerator.Reset()
		{
			this.5();
		}

		// Token: 0x06003DCD RID: 15821 RVA: 0x00184854 File Offset: 0x00182A54
		[DebuggerHidden]
		private object 6()
		{
			return this.2;
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06003DCE RID: 15822 RVA: 0x00184861 File Offset: 0x00182A61
		object IEnumerator.Current
		{
			get
			{
				return this.6();
			}
		}

		// Token: 0x06003DCF RID: 15823 RVA: 0x0018486C File Offset: 0x00182A6C
		[DebuggerHidden]
		private IEnumerator<2023> 7()
		{
			1891.1895 <<EMPTY_NAME>>;
			if (this.1 == -2 && this.3 == Thread.CurrentThread.ManagedThreadId)
			{
				this.1 = 0;
				<<EMPTY_NAME>> = this;
			}
			else
			{
				<<EMPTY_NAME>> = new 1891.1895(0);
			}
			<<EMPTY_NAME>>.4 = this.5;
			return <<EMPTY_NAME>>;
		}

		// Token: 0x06003DD0 RID: 15824 RVA: 0x001848B4 File Offset: 0x00182AB4
		IEnumerator<2023> IEnumerable<2023>.GetEnumerator()
		{
			return this.7();
		}

		// Token: 0x06003DD1 RID: 15825 RVA: 0x001848B4 File Offset: 0x00182AB4
		[DebuggerHidden]
		private IEnumerator 8()
		{
			return this.7();
		}

		// Token: 0x06003DD2 RID: 15826 RVA: 0x001848BC File Offset: 0x00182ABC
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.8();
		}

		// Token: 0x04002D56 RID: 11606
		private int 1;

		// Token: 0x04002D57 RID: 11607
		private 2023 2;

		// Token: 0x04002D58 RID: 11608
		private int 3;

		// Token: 0x04002D59 RID: 11609
		private IEnumerable<2023> 4;

		// Token: 0x04002D5A RID: 11610
		public IEnumerable<2023> 5;

		// Token: 0x04002D5B RID: 11611
		private IEnumerator<2023> 6;
	}
}
