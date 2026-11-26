using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

// Token: 0x020001B9 RID: 441
[241(0)]
[242(1)]
public sealed class 750 : 368
{
	// Token: 0x06000E18 RID: 3608 RVA: 0x0003005D File Offset: 0x0002E25D
	public 750(List<int> 1)
	{
		this.list2 = 1;
	}

	// Token: 0x06000E19 RID: 3609 RVA: 0x0003006C File Offset: 0x0002E26C
	public override IEnumerable<226> Method12761(226 1, IEnumerable<226> 2, [241(2)] 541 3)
	{
		return new 750.751(-2)
		{
			_recoveredType21939496 = this,
			iEnumerable2 = 2,
			_recoveredType12049498 = 3
		};
	}

	// Token: 0x040006E2 RID: 1762
	internal List<int> list2;

	// Token: 0x020001BA RID: 442
	public sealed class 751 : IEnumerable<226>, IEnumerable, IEnumerator<226>, IDisposable, IEnumerator
	{
		// Token: 0x06000E1A RID: 3610 RVA: 0x0003008A File Offset: 0x0002E28A
		[DebuggerHidden]
		public 751(int 1)
		{
			this.number2 = 1;
			this.number3 = Thread.CurrentThread.ManagedThreadId;
		}

		// Token: 0x06000E1B RID: 3611 RVA: 0x000300AC File Offset: 0x0002E2AC
		[DebuggerHidden]
		private void Method12159()
		{
			int num = this.number2;
			if (num - -4 > 1 && num != 1)
			{
				return;
			}
			try
			{
				if (num == -4 || num == 1)
				{
					try
					{
					}
					finally
					{
						this.Method12161();
					}
				}
			}
			finally
			{
				this.Method12160();
			}
		}

		// Token: 0x06000E1C RID: 3612 RVA: 0x00030108 File Offset: 0x0002E308
		void IDisposable.Dispose()
		{
			this.Method12159();
		}

		// Token: 0x06000E1D RID: 3613 RVA: 0x00030110 File Offset: 0x0002E310
		private bool MoveNext()
		{
			bool result;
			try
			{
				int num = this.number2;
				750 recoveredType = this._recoveredType21939496;
				if (num == 0)
				{
					this.number2 = -1;
					this.iEnumerator = this.iEnumerable.GetEnumerator();
					this.number2 = -3;
					goto IL_A5;
				}
				if (num != 1)
				{
					return false;
				}
				this.number2 = -4;
				IL_7F:
				while (this.enumerator.MoveNext())
				{
					int <<EMPTY_NAME>> = this.enumerator.Current;
					226 2 = 368.Method1841(this.jToken3, this._recoveredType12049497, <<EMPTY_NAME>>);
					if (2 != null)
					{
						this.jToken2 = 2;
						this.number2 = 1;
						return true;
					}
				}
				this.Method12161();
				this.enumerator = default(List<int>.Enumerator);
				this.jToken3 = null;
				IL_A5:
				if (this.iEnumerator.MoveNext())
				{
					this.jToken3 = this.iEnumerator.Current;
					this.enumerator = recoveredType.list2.GetEnumerator();
					this.number2 = -4;
					goto IL_7F;
				}
				this.Method12160();
				this.iEnumerator = null;
				result = false;
			}
			catch
			{
				this.Method12159();
				throw;
			}
			return result;
		}

		// Token: 0x06000E1E RID: 3614 RVA: 0x00030228 File Offset: 0x0002E428
		bool IEnumerator.MoveNext()
		{
			return this.MoveNext();
		}

		// Token: 0x06000E1F RID: 3615 RVA: 0x00030230 File Offset: 0x0002E430
		private void Method12160()
		{
			this.number2 = -1;
			if (this.iEnumerator != null)
			{
				this.iEnumerator.Dispose();
			}
		}

		// Token: 0x06000E20 RID: 3616 RVA: 0x0003024C File Offset: 0x0002E44C
		private void Method12161()
		{
			this.number2 = -3;
			((IDisposable)this.enumerator).Dispose();
		}

		// Token: 0x06000E21 RID: 3617 RVA: 0x00030266 File Offset: 0x0002E466
		[DebuggerHidden]
		private 226 GetJToken9492_12162()
		{
			return this.jToken2;
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000E22 RID: 3618 RVA: 0x0003026E File Offset: 0x0002E46E
		226 IEnumerator<226>.Current
		{
			get
			{
				return this.GetJToken9492_12162();
			}
		}

		// Token: 0x06000E23 RID: 3619 RVA: 0x00005BE8 File Offset: 0x00003DE8
		[DebuggerHidden]
		private void Method12163()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06000E24 RID: 3620 RVA: 0x00030276 File Offset: 0x0002E476
		void IEnumerator.Reset()
		{
			this.Method12163();
		}

		// Token: 0x06000E25 RID: 3621 RVA: 0x00030266 File Offset: 0x0002E466
		[DebuggerHidden]
		[return: 241(0)]
		private object GetJToken9492_12164()
		{
			return this.jToken2;
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000E26 RID: 3622 RVA: 0x0003027E File Offset: 0x0002E47E
		object IEnumerator.Current
		{
			get
			{
				return this.GetJToken9492_12164();
			}
		}

		// Token: 0x06000E27 RID: 3623 RVA: 0x00030288 File Offset: 0x0002E488
		[DebuggerHidden]
		[return: 241(0)]
		private IEnumerator<226> Method12165()
		{
			750.751 <<EMPTY_NAME>>;
			if (this.number2 == -2 && this.number3 == Thread.CurrentThread.ManagedThreadId)
			{
				this.number2 = 0;
				<<EMPTY_NAME>> = this;
			}
			else
			{
				<<EMPTY_NAME>> = new 750.751(0);
				<<EMPTY_NAME>>._recoveredType21939496 = this._recoveredType21939496;
			}
			<<EMPTY_NAME>>.iEnumerable = this.iEnumerable2;
			<<EMPTY_NAME>>._recoveredType12049497 = this._recoveredType12049498;
			return <<EMPTY_NAME>>;
		}

		// Token: 0x06000E28 RID: 3624 RVA: 0x000302E8 File Offset: 0x0002E4E8
		IEnumerator<226> IEnumerable<226>.GetEnumerator()
		{
			return this.Method12165();
		}

		// Token: 0x06000E29 RID: 3625 RVA: 0x000302E8 File Offset: 0x0002E4E8
		[DebuggerHidden]
		[return: 241(0)]
		private IEnumerator Method12166()
		{
			return this.Method12165();
		}

		// Token: 0x06000E2A RID: 3626 RVA: 0x000302F0 File Offset: 0x0002E4F0
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.Method12166();
		}

		// Token: 0x040006E3 RID: 1763
		private int number2;

		// Token: 0x040006E4 RID: 1764
		private 226 jToken2;

		// Token: 0x040006E5 RID: 1765
		private int number3;

		// Token: 0x040006E6 RID: 1766
		[241(new byte[]
		{
			0,
			1
		})]
		private IEnumerable<226> iEnumerable;

		// Token: 0x040006E7 RID: 1767
		[241(new byte[]
		{
			0,
			1
		})]
		public IEnumerable<226> iEnumerable2;

		// Token: 0x040006E8 RID: 1768
		[241(0)]
		public 750 _recoveredType21939496;

		// Token: 0x040006E9 RID: 1769
		[241(0)]
		private 541 _recoveredType12049497;

		// Token: 0x040006EA RID: 1770
		[241(0)]
		public 541 _recoveredType12049498;

		// Token: 0x040006EB RID: 1771
		[241(new byte[]
		{
			0,
			1
		})]
		private IEnumerator<226> iEnumerator;

		// Token: 0x040006EC RID: 1772
		[241(0)]
		private 226 jToken3;

		// Token: 0x040006ED RID: 1773
		[241(0)]
		private List<int>.Enumerator enumerator;
	}
}
