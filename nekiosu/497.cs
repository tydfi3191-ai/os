using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

// Token: 0x0200014B RID: 331
[242(1)]
[241(0)]
public sealed class 497 : 368
{
	// Token: 0x06000B4A RID: 2890 RVA: 0x0002A380 File Offset: 0x00028580
	public 497(List<string> 1)
	{
		this.list2 = 1;
	}

	// Token: 0x06000B4B RID: 2891 RVA: 0x0002A38F File Offset: 0x0002858F
	public override IEnumerable<226> Method12761(226 1, IEnumerable<226> 2, [241(2)] 541 3)
	{
		return new 497.498(-2)
		{
			_recoveredType09684270 = this,
			iEnumerable2 = 2
		};
	}

	// Token: 0x04000593 RID: 1427
	private List<string> list2;

	// Token: 0x0200014C RID: 332
	public sealed class 498 : IEnumerable<226>, IEnumerable, IEnumerator<226>, IDisposable, IEnumerator
	{
		// Token: 0x06000B4C RID: 2892 RVA: 0x0002A3A6 File Offset: 0x000285A6
		[DebuggerHidden]
		public 498(int 1)
		{
			this.number2 = 1;
			this.number3 = Thread.CurrentThread.ManagedThreadId;
		}

		// Token: 0x06000B4D RID: 2893 RVA: 0x0002A3C8 File Offset: 0x000285C8
		[DebuggerHidden]
		private void Method5441()
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
						this.Method5443();
					}
				}
			}
			finally
			{
				this.Method5442();
			}
		}

		// Token: 0x06000B4E RID: 2894 RVA: 0x0002A424 File Offset: 0x00028624
		void IDisposable.Dispose()
		{
			this.Method5441();
		}

		// Token: 0x06000B4F RID: 2895 RVA: 0x0002A42C File Offset: 0x0002862C
		private bool MoveNext()
		{
			try
			{
				int num = this.number2;
				497 recoveredType = this._recoveredType09684270;
				if (num == 0)
				{
					this.number2 = -1;
					this.iEnumerator = this.iEnumerable.GetEnumerator();
					this.number2 = -3;
					goto IL_BC;
				}
				if (num != 1)
				{
					return false;
				}
				this.number2 = -4;
				IL_145:
				while (this.enumerator.MoveNext())
				{
					string b = this.enumerator.Current;
					if (this.jProperty.Name == b)
					{
						this.jToken = this.jProperty.Value;
						this.number2 = 1;
						return true;
					}
				}
				this.Method5443();
				this.enumerator = default(List<string>.Enumerator);
				goto IL_FC;
				IL_4B:
				111 <<EMPTY_NAME>> = this.jToken3 as 111;
				this.jToken3 = 368.Method1842(this.jToken2, <<EMPTY_NAME>>, this.jToken3);
				if (this.jToken3 != null)
				{
					this.jProperty = (this.jToken3 as 222);
					if (this.jProperty != null)
					{
						this.enumerator = recoveredType.list2.GetEnumerator();
						this.number2 = -4;
						goto IL_145;
					}
					goto IL_FC;
				}
				else
				{
					this.jToken3 = null;
					this.jToken2 = null;
				}
				IL_BC:
				if (this.iEnumerator.MoveNext())
				{
					this.jToken2 = this.iEnumerator.Current;
					this.jToken3 = this.jToken2;
					goto IL_4B;
				}
				this.Method5442();
				this.iEnumerator = null;
				return false;
				IL_FC:
				this.jProperty = null;
				goto IL_4B;
			}
			catch
			{
				this.Method5441();
				throw;
			}
			bool result;
			return result;
		}

		// Token: 0x06000B50 RID: 2896 RVA: 0x0002A5C8 File Offset: 0x000287C8
		bool IEnumerator.MoveNext()
		{
			return this.MoveNext();
		}

		// Token: 0x06000B51 RID: 2897 RVA: 0x0002A5D0 File Offset: 0x000287D0
		private void Method5442()
		{
			this.number2 = -1;
			if (this.iEnumerator != null)
			{
				this.iEnumerator.Dispose();
			}
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x0002A5EC File Offset: 0x000287EC
		private void Method5443()
		{
			this.number2 = -3;
			((IDisposable)this.enumerator).Dispose();
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x0002A606 File Offset: 0x00028806
		[DebuggerHidden]
		private 226 GetJToken4266_5444()
		{
			return this.jToken;
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000B54 RID: 2900 RVA: 0x0002A60E File Offset: 0x0002880E
		226 IEnumerator<226>.Current
		{
			get
			{
				return this.GetJToken4266_5444();
			}
		}

		// Token: 0x06000B55 RID: 2901 RVA: 0x00005BE8 File Offset: 0x00003DE8
		[DebuggerHidden]
		private void Method5445()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x0002A616 File Offset: 0x00028816
		void IEnumerator.Reset()
		{
			this.Method5445();
		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x0002A606 File Offset: 0x00028806
		[DebuggerHidden]
		[return: 241(0)]
		private object GetJToken4266_5446()
		{
			return this.jToken;
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000B58 RID: 2904 RVA: 0x0002A61E File Offset: 0x0002881E
		object IEnumerator.Current
		{
			get
			{
				return this.GetJToken4266_5446();
			}
		}

		// Token: 0x06000B59 RID: 2905 RVA: 0x0002A628 File Offset: 0x00028828
		[DebuggerHidden]
		[return: 241(0)]
		private IEnumerator<226> Method5447()
		{
			497.498 <<EMPTY_NAME>>;
			if (this.number2 == -2 && this.number3 == Thread.CurrentThread.ManagedThreadId)
			{
				this.number2 = 0;
				<<EMPTY_NAME>> = this;
			}
			else
			{
				<<EMPTY_NAME>> = new 497.498(0);
				<<EMPTY_NAME>>._recoveredType09684270 = this._recoveredType09684270;
			}
			<<EMPTY_NAME>>.iEnumerable = this.iEnumerable2;
			return <<EMPTY_NAME>>;
		}

		// Token: 0x06000B5A RID: 2906 RVA: 0x0002A67C File Offset: 0x0002887C
		IEnumerator<226> IEnumerable<226>.GetEnumerator()
		{
			return this.Method5447();
		}

		// Token: 0x06000B5B RID: 2907 RVA: 0x0002A67C File Offset: 0x0002887C
		[DebuggerHidden]
		[return: 241(0)]
		private IEnumerator Method5448()
		{
			return this.Method5447();
		}

		// Token: 0x06000B5C RID: 2908 RVA: 0x0002A684 File Offset: 0x00028884
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.Method5448();
		}

		// Token: 0x04000594 RID: 1428
		private int number2;

		// Token: 0x04000595 RID: 1429
		private 226 jToken;

		// Token: 0x04000596 RID: 1430
		private int number3;

		// Token: 0x04000597 RID: 1431
		[241(new byte[]
		{
			0,
			1
		})]
		private IEnumerable<226> iEnumerable;

		// Token: 0x04000598 RID: 1432
		[241(new byte[]
		{
			0,
			1
		})]
		public IEnumerable<226> iEnumerable2;

		// Token: 0x04000599 RID: 1433
		[241(0)]
		public 497 _recoveredType09684270;

		// Token: 0x0400059A RID: 1434
		[241(new byte[]
		{
			0,
			1
		})]
		private IEnumerator<226> iEnumerator;

		// Token: 0x0400059B RID: 1435
		[241(0)]
		private 226 jToken2;

		// Token: 0x0400059C RID: 1436
		[241(0)]
		private 226 jToken3;

		// Token: 0x0400059D RID: 1437
		[241(0)]
		private 222 jProperty;

		// Token: 0x0400059E RID: 1438
		[241(new byte[]
		{
			0,
			1
		})]
		private List<string>.Enumerator enumerator;
	}
}
