using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;

// Token: 0x0200081C RID: 2076
[276]
public static class 2057
{
	// Token: 0x06003C6D RID: 15469 RVA: 0x0017FB37 File Offset: 0x0017DD37
	public static IEnumerable<2056> 1(double 1, double 2, double 3, double 4, double 5, int 6)
	{
		return new 2057.2058(-2)
		{
			11 = 1,
			13 = 2,
			9 = 3,
			7 = 4,
			5 = 5,
			15 = 6
		};
	}

	// Token: 0x06003C6E RID: 15470 RVA: 0x0017FB6C File Offset: 0x0017DD6C
	private static IEnumerable<2056> 2(int 1, double 2, double 3, bool 4, double 5, double 6, double 7)
	{
		return new 2057.2059(-2)
		{
			13 = 1,
			15 = 2,
			17 = 3,
			11 = 4,
			7 = 5,
			5 = 6,
			9 = 7
		};
	}

	// Token: 0x0200081D RID: 2077
	[276]
	public sealed class 2059 : IEnumerable<2056>, IEnumerable, IEnumerator<2056>, IDisposable, IEnumerator
	{
		// Token: 0x06003C6F RID: 15471 RVA: 0x0017FBA9 File Offset: 0x0017DDA9
		[DebuggerHidden]
		public 2059(int 1)
		{
			this.1 = 1;
			this.3 = Thread.CurrentThread.ManagedThreadId;
		}

		// Token: 0x06003C70 RID: 15472 RVA: 0x00005ADD File Offset: 0x00003CDD
		[DebuggerHidden]
		private void 1()
		{
		}

		// Token: 0x06003C71 RID: 15473 RVA: 0x0017FBC8 File Offset: 0x0017DDC8
		void IDisposable.Dispose()
		{
			this.1();
		}

		// Token: 0x06003C72 RID: 15474 RVA: 0x0017FBD0 File Offset: 0x0017DDD0
		private bool 2()
		{
			int num = this.1;
			if (num != 0)
			{
				if (num != 1)
				{
					return false;
				}
				this.1 = -1;
				this.18 += this.4;
			}
			else
			{
				this.1 = -1;
				this.18 = this.4;
			}
			if (this.18 <= this.6 && this.18 < this.6 - this.8)
			{
				double num2 = this.18 / this.6;
				double num3 = this.10 ? (1.0 - num2) : num2;
				this.2 = new 2056
				{
					1 = (2060)0,
					3 = this.12,
					4 = this.14,
					2 = this.14 + num3 * this.16,
					5 = num2
				};
				this.1 = 1;
				return true;
			}
			return false;
		}

		// Token: 0x06003C73 RID: 15475 RVA: 0x0017FCC0 File Offset: 0x0017DEC0
		bool IEnumerator.MoveNext()
		{
			return this.2();
		}

		// Token: 0x06003C74 RID: 15476 RVA: 0x0017FCC8 File Offset: 0x0017DEC8
		[DebuggerHidden]
		private 2056 3()
		{
			return this.2;
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06003C75 RID: 15477 RVA: 0x0017FCD0 File Offset: 0x0017DED0
		2056 IEnumerator<2056>.Current
		{
			get
			{
				return this.3();
			}
		}

		// Token: 0x06003C76 RID: 15478 RVA: 0x00005BE8 File Offset: 0x00003DE8
		[DebuggerHidden]
		private void 4()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06003C77 RID: 15479 RVA: 0x0017FCD8 File Offset: 0x0017DED8
		void IEnumerator.Reset()
		{
			this.4();
		}

		// Token: 0x06003C78 RID: 15480 RVA: 0x0017FCE0 File Offset: 0x0017DEE0
		[DebuggerHidden]
		private object 5()
		{
			return this.2;
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06003C79 RID: 15481 RVA: 0x0017FCED File Offset: 0x0017DEED
		object IEnumerator.Current
		{
			get
			{
				return this.5();
			}
		}

		// Token: 0x06003C7A RID: 15482 RVA: 0x0017FCF8 File Offset: 0x0017DEF8
		[DebuggerHidden]
		private IEnumerator<2056> 6()
		{
			2057.2059 <<EMPTY_NAME>>;
			if (this.1 == -2 && this.3 == Thread.CurrentThread.ManagedThreadId)
			{
				this.1 = 0;
				<<EMPTY_NAME>> = this;
			}
			else
			{
				<<EMPTY_NAME>> = new 2057.2059(0);
			}
			<<EMPTY_NAME>>.12 = this.13;
			<<EMPTY_NAME>>.14 = this.15;
			<<EMPTY_NAME>>.16 = this.17;
			<<EMPTY_NAME>>.10 = this.11;
			<<EMPTY_NAME>>.6 = this.7;
			<<EMPTY_NAME>>.4 = this.5;
			<<EMPTY_NAME>>.8 = this.9;
			return <<EMPTY_NAME>>;
		}

		// Token: 0x06003C7B RID: 15483 RVA: 0x0017FD88 File Offset: 0x0017DF88
		IEnumerator<2056> IEnumerable<2056>.GetEnumerator()
		{
			return this.6();
		}

		// Token: 0x06003C7C RID: 15484 RVA: 0x0017FD88 File Offset: 0x0017DF88
		[DebuggerHidden]
		private IEnumerator 7()
		{
			return this.6();
		}

		// Token: 0x06003C7D RID: 15485 RVA: 0x0017FD90 File Offset: 0x0017DF90
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.7();
		}

		// Token: 0x04002C95 RID: 11413
		private int 1;

		// Token: 0x04002C96 RID: 11414
		private 2056 2;

		// Token: 0x04002C97 RID: 11415
		private int 3;

		// Token: 0x04002C98 RID: 11416
		private double 4;

		// Token: 0x04002C99 RID: 11417
		public double 5;

		// Token: 0x04002C9A RID: 11418
		private double 6;

		// Token: 0x04002C9B RID: 11419
		public double 7;

		// Token: 0x04002C9C RID: 11420
		private double 8;

		// Token: 0x04002C9D RID: 11421
		public double 9;

		// Token: 0x04002C9E RID: 11422
		private bool 10;

		// Token: 0x04002C9F RID: 11423
		public bool 11;

		// Token: 0x04002CA0 RID: 11424
		private int 12;

		// Token: 0x04002CA1 RID: 11425
		public int 13;

		// Token: 0x04002CA2 RID: 11426
		private double 14;

		// Token: 0x04002CA3 RID: 11427
		public double 15;

		// Token: 0x04002CA4 RID: 11428
		private double 16;

		// Token: 0x04002CA5 RID: 11429
		public double 17;

		// Token: 0x04002CA6 RID: 11430
		private double 18;
	}

	// Token: 0x0200081E RID: 2078
	[276]
	public sealed class 2058 : IEnumerable<2056>, IEnumerable, IEnumerator<2056>, IDisposable, IEnumerator
	{
		// Token: 0x06003C7E RID: 15486 RVA: 0x0017FD98 File Offset: 0x0017DF98
		[DebuggerHidden]
		public 2058(int 1)
		{
			this.1 = 1;
			this.3 = Thread.CurrentThread.ManagedThreadId;
		}

		// Token: 0x06003C7F RID: 15487 RVA: 0x0017FDB8 File Offset: 0x0017DFB8
		[DebuggerHidden]
		private void 1()
		{
			int num = this.1;
			if (num == -3 || num == 2)
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

		// Token: 0x06003C80 RID: 15488 RVA: 0x0017FDF0 File Offset: 0x0017DFF0
		void IDisposable.Dispose()
		{
			this.1();
		}

		// Token: 0x06003C81 RID: 15489 RVA: 0x0017FDF8 File Offset: 0x0017DFF8
		private bool 2()
		{
			bool result;
			try
			{
				switch (this.1)
				{
				case 0:
					this.1 = -1;
					this.16 = Math.Min(100000.0, this.4);
					this.6 = 1052.20(this.6, 0.0, this.16);
					this.17 = this.8 * 10.0;
					this.2 = new 2056
					{
						1 = (2060)2,
						3 = 0,
						4 = this.10,
						2 = this.10,
						5 = 0.0
					};
					this.1 = 1;
					return true;
				case 1:
					this.1 = -1;
					if (this.6 != 0.0)
					{
						this.20 = 0;
						goto IL_27D;
					}
					break;
				case 2:
					this.1 = -3;
					goto IL_31A;
				case 3:
					this.1 = -1;
					goto IL_307;
				case 4:
					this.1 = -1;
					this.2 = new 2056
					{
						1 = (2060)3,
						3 = this.19,
						4 = this.10 + (double)(this.14 - 1) * this.12,
						2 = this.10 + this.18,
						5 = (double)(this.14 % 2)
					};
					this.1 = 5;
					return true;
				case 5:
					this.1 = -1;
					return false;
				default:
					return false;
				}
				IL_1A9:
				this.18 = (double)this.14 * this.12;
				this.19 = this.14 - 1;
				double num = this.10 + (double)this.19 * this.12;
				double num2 = Math.Max(this.10 + this.18 / 2.0, num + this.12 + -36.0);
				double num3 = (num2 - num) / this.12;
				if (this.14 % 2 == 0)
				{
					num3 = 1.0 - num3;
				}
				this.2 = new 2056
				{
					1 = (2060)1,
					3 = this.19,
					4 = num,
					2 = num2,
					5 = num3
				};
				this.1 = 4;
				return true;
				IL_27D:
				if (this.20 < this.14)
				{
					this.21 = this.10 + (double)this.20 * this.12;
					bool flag = this.20 % 2 == 1;
					IEnumerable<2056> enumerable = 2057.2(this.20, this.21, this.12, flag, this.16, this.6, this.17);
					if (flag)
					{
						enumerable = enumerable.Reverse<2056>();
					}
					this.22 = enumerable.GetEnumerator();
					this.1 = -3;
					goto IL_31A;
				}
				goto IL_1A9;
				IL_307:
				this.20++;
				goto IL_27D;
				IL_31A:
				if (this.22.MoveNext())
				{
					2056 <<EMPTY_NAME>> = this.22.Current;
					this.2 = <<EMPTY_NAME>>;
					this.1 = 2;
					result = true;
				}
				else
				{
					this.3();
					this.22 = null;
					if (this.20 >= this.14 - 1)
					{
						goto IL_307;
					}
					this.2 = new 2056
					{
						1 = (2060)4,
						3 = this.20,
						4 = this.10 + (double)this.20 * this.12,
						2 = this.21 + this.12,
						5 = (double)((this.20 + 1) % 2)
					};
					this.1 = 3;
					result = true;
				}
			}
			catch
			{
				this.1();
				throw;
			}
			return result;
		}

		// Token: 0x06003C82 RID: 15490 RVA: 0x00180208 File Offset: 0x0017E408
		bool IEnumerator.MoveNext()
		{
			return this.2();
		}

		// Token: 0x06003C83 RID: 15491 RVA: 0x00180210 File Offset: 0x0017E410
		private void 3()
		{
			this.1 = -1;
			if (this.22 != null)
			{
				this.22.Dispose();
			}
		}

		// Token: 0x06003C84 RID: 15492 RVA: 0x0018022C File Offset: 0x0017E42C
		[DebuggerHidden]
		private 2056 4()
		{
			return this.2;
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06003C85 RID: 15493 RVA: 0x00180234 File Offset: 0x0017E434
		2056 IEnumerator<2056>.Current
		{
			get
			{
				return this.4();
			}
		}

		// Token: 0x06003C86 RID: 15494 RVA: 0x00005BE8 File Offset: 0x00003DE8
		[DebuggerHidden]
		private void 5()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06003C87 RID: 15495 RVA: 0x0018023C File Offset: 0x0017E43C
		void IEnumerator.Reset()
		{
			this.5();
		}

		// Token: 0x06003C88 RID: 15496 RVA: 0x00180244 File Offset: 0x0017E444
		[DebuggerHidden]
		private object 6()
		{
			return this.2;
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06003C89 RID: 15497 RVA: 0x00180251 File Offset: 0x0017E451
		object IEnumerator.Current
		{
			get
			{
				return this.6();
			}
		}

		// Token: 0x06003C8A RID: 15498 RVA: 0x0018025C File Offset: 0x0017E45C
		[DebuggerHidden]
		private IEnumerator<2056> 7()
		{
			2057.2058 <<EMPTY_NAME>>;
			if (this.1 == -2 && this.3 == Thread.CurrentThread.ManagedThreadId)
			{
				this.1 = 0;
				<<EMPTY_NAME>> = this;
			}
			else
			{
				<<EMPTY_NAME>> = new 2057.2058(0);
			}
			<<EMPTY_NAME>>.10 = this.11;
			<<EMPTY_NAME>>.12 = this.13;
			<<EMPTY_NAME>>.8 = this.9;
			<<EMPTY_NAME>>.6 = this.7;
			<<EMPTY_NAME>>.4 = this.5;
			<<EMPTY_NAME>>.14 = this.15;
			return <<EMPTY_NAME>>;
		}

		// Token: 0x06003C8B RID: 15499 RVA: 0x001802E0 File Offset: 0x0017E4E0
		IEnumerator<2056> IEnumerable<2056>.GetEnumerator()
		{
			return this.7();
		}

		// Token: 0x06003C8C RID: 15500 RVA: 0x001802E0 File Offset: 0x0017E4E0
		[DebuggerHidden]
		private IEnumerator 8()
		{
			return this.7();
		}

		// Token: 0x06003C8D RID: 15501 RVA: 0x001802E8 File Offset: 0x0017E4E8
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.8();
		}

		// Token: 0x04002CA7 RID: 11431
		private int 1;

		// Token: 0x04002CA8 RID: 11432
		private 2056 2;

		// Token: 0x04002CA9 RID: 11433
		private int 3;

		// Token: 0x04002CAA RID: 11434
		private double 4;

		// Token: 0x04002CAB RID: 11435
		public double 5;

		// Token: 0x04002CAC RID: 11436
		private double 6;

		// Token: 0x04002CAD RID: 11437
		public double 7;

		// Token: 0x04002CAE RID: 11438
		private double 8;

		// Token: 0x04002CAF RID: 11439
		public double 9;

		// Token: 0x04002CB0 RID: 11440
		private double 10;

		// Token: 0x04002CB1 RID: 11441
		public double 11;

		// Token: 0x04002CB2 RID: 11442
		private double 12;

		// Token: 0x04002CB3 RID: 11443
		public double 13;

		// Token: 0x04002CB4 RID: 11444
		private int 14;

		// Token: 0x04002CB5 RID: 11445
		public int 15;

		// Token: 0x04002CB6 RID: 11446
		private double 16;

		// Token: 0x04002CB7 RID: 11447
		private double 17;

		// Token: 0x04002CB8 RID: 11448
		private double 18;

		// Token: 0x04002CB9 RID: 11449
		private int 19;

		// Token: 0x04002CBA RID: 11450
		private int 20;

		// Token: 0x04002CBB RID: 11451
		private double 21;

		// Token: 0x04002CBC RID: 11452
		private IEnumerator<2056> 22;
	}
}
