using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

// Token: 0x02000132 RID: 306
[241(0)]
[242(1)]
public sealed class 457 : 368
{
	// Token: 0x06000ACB RID: 2763 RVA: 0x00028E75 File Offset: 0x00027075
	public 457(781 1)
	{
		this._recoveredType23363381 = 1;
	}

	// Token: 0x06000ACC RID: 2764 RVA: 0x00028E84 File Offset: 0x00027084
	public override IEnumerable<226> Method12761(226 1, IEnumerable<226> 2, [241(2)] 541 3)
	{
		return new 457.458(-2)
		{
			_recoveredType07613374 = this,
			jToken3 = 1,
			iEnumerable2 = 2,
			_recoveredType12043378 = 3
		};
	}

	// Token: 0x04000550 RID: 1360
	internal 781 _recoveredType23363381;

	// Token: 0x02000133 RID: 307
	public sealed class 458 : IEnumerable<226>, IEnumerable, IEnumerator<226>, IDisposable, IEnumerator
	{
		// Token: 0x06000ACD RID: 2765 RVA: 0x00028EA9 File Offset: 0x000270A9
		[DebuggerHidden]
		public 458(int 1)
		{
			this.number2 = 1;
			this.number3 = Thread.CurrentThread.ManagedThreadId;
		}

		// Token: 0x06000ACE RID: 2766 RVA: 0x00028EC8 File Offset: 0x000270C8
		[DebuggerHidden]
		private void Method4350()
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
						this.Method4352();
					}
				}
			}
			finally
			{
				this.Method4351();
			}
		}

		// Token: 0x06000ACF RID: 2767 RVA: 0x00028F24 File Offset: 0x00027124
		void IDisposable.Dispose()
		{
			this.Method4350();
		}

		// Token: 0x06000AD0 RID: 2768 RVA: 0x00028F2C File Offset: 0x0002712C
		private bool MoveNext()
		{
			bool result;
			try
			{
				int num = this.number2;
				457 recoveredType = this._recoveredType07613374;
				if (num == 0)
				{
					this.number2 = -1;
					this.iEnumerator = this.iEnumerable.GetEnumerator();
					this.number2 = -3;
					goto IL_9A;
				}
				if (num != 1)
				{
					return false;
				}
				this.number2 = -4;
				IL_80:
				while (this.iEnumerator2.MoveNext())
				{
					226 <<EMPTY_NAME>> = this.iEnumerator2.Current;
					if (recoveredType._recoveredType23363381.Method12763(this.jToken2, <<EMPTY_NAME>>, this._recoveredType12043377))
					{
						this.jToken = <<EMPTY_NAME>>;
						this.number2 = 1;
						return true;
					}
				}
				this.Method4352();
				this.iEnumerator2 = null;
				IL_9A:
				if (this.iEnumerator.MoveNext())
				{
					226 2 = this.iEnumerator.Current;
					this.iEnumerator2 = ((IEnumerable<226>)2).GetEnumerator();
					this.number2 = -4;
					goto IL_80;
				}
				this.Method4351();
				this.iEnumerator = null;
				result = false;
			}
			catch
			{
				this.Method4350();
				throw;
			}
			return result;
		}

		// Token: 0x06000AD1 RID: 2769 RVA: 0x00029030 File Offset: 0x00027230
		bool IEnumerator.MoveNext()
		{
			return this.MoveNext();
		}

		// Token: 0x06000AD2 RID: 2770 RVA: 0x00029038 File Offset: 0x00027238
		private void Method4351()
		{
			this.number2 = -1;
			if (this.iEnumerator != null)
			{
				this.iEnumerator.Dispose();
			}
		}

		// Token: 0x06000AD3 RID: 2771 RVA: 0x00029054 File Offset: 0x00027254
		private void Method4352()
		{
			this.number2 = -3;
			if (this.iEnumerator2 != null)
			{
				this.iEnumerator2.Dispose();
			}
		}

		// Token: 0x06000AD4 RID: 2772 RVA: 0x00029071 File Offset: 0x00027271
		[DebuggerHidden]
		private 226 GetJToken3370_4353()
		{
			return this.jToken;
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000AD5 RID: 2773 RVA: 0x00029079 File Offset: 0x00027279
		226 IEnumerator<226>.Current
		{
			get
			{
				return this.GetJToken3370_4353();
			}
		}

		// Token: 0x06000AD6 RID: 2774 RVA: 0x00005BE8 File Offset: 0x00003DE8
		[DebuggerHidden]
		private void Method4354()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06000AD7 RID: 2775 RVA: 0x00029081 File Offset: 0x00027281
		void IEnumerator.Reset()
		{
			this.Method4354();
		}

		// Token: 0x06000AD8 RID: 2776 RVA: 0x00029071 File Offset: 0x00027271
		[DebuggerHidden]
		[return: 241(0)]
		private object GetJToken3370_4355()
		{
			return this.jToken;
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000AD9 RID: 2777 RVA: 0x00029089 File Offset: 0x00027289
		object IEnumerator.Current
		{
			get
			{
				return this.GetJToken3370_4355();
			}
		}

		// Token: 0x06000ADA RID: 2778 RVA: 0x00029094 File Offset: 0x00027294
		[DebuggerHidden]
		[return: 241(0)]
		private IEnumerator<226> Method4356()
		{
			457.458 <<EMPTY_NAME>>;
			if (this.number2 == -2 && this.number3 == Thread.CurrentThread.ManagedThreadId)
			{
				this.number2 = 0;
				<<EMPTY_NAME>> = this;
			}
			else
			{
				<<EMPTY_NAME>> = new 457.458(0);
				<<EMPTY_NAME>>._recoveredType07613374 = this._recoveredType07613374;
			}
			<<EMPTY_NAME>>.jToken2 = this.jToken3;
			<<EMPTY_NAME>>.iEnumerable = this.iEnumerable2;
			<<EMPTY_NAME>>._recoveredType12043377 = this._recoveredType12043378;
			return <<EMPTY_NAME>>;
		}

		// Token: 0x06000ADB RID: 2779 RVA: 0x00029100 File Offset: 0x00027300
		IEnumerator<226> IEnumerable<226>.GetEnumerator()
		{
			return this.Method4356();
		}

		// Token: 0x06000ADC RID: 2780 RVA: 0x00029100 File Offset: 0x00027300
		[DebuggerHidden]
		[return: 241(0)]
		private IEnumerator Method4357()
		{
			return this.Method4356();
		}

		// Token: 0x06000ADD RID: 2781 RVA: 0x00029108 File Offset: 0x00027308
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.Method4357();
		}

		// Token: 0x04000551 RID: 1361
		private int number2;

		// Token: 0x04000552 RID: 1362
		private 226 jToken;

		// Token: 0x04000553 RID: 1363
		private int number3;

		// Token: 0x04000554 RID: 1364
		[241(new byte[]
		{
			0,
			1
		})]
		private IEnumerable<226> iEnumerable;

		// Token: 0x04000555 RID: 1365
		[241(new byte[]
		{
			0,
			1
		})]
		public IEnumerable<226> iEnumerable2;

		// Token: 0x04000556 RID: 1366
		[241(0)]
		public 457 _recoveredType07613374;

		// Token: 0x04000557 RID: 1367
		[241(0)]
		private 226 jToken2;

		// Token: 0x04000558 RID: 1368
		[241(0)]
		public 226 jToken3;

		// Token: 0x04000559 RID: 1369
		[241(0)]
		private 541 _recoveredType12043377;

		// Token: 0x0400055A RID: 1370
		[241(0)]
		public 541 _recoveredType12043378;

		// Token: 0x0400055B RID: 1371
		[241(new byte[]
		{
			0,
			1
		})]
		private IEnumerator<226> iEnumerator;

		// Token: 0x0400055C RID: 1372
		[241(new byte[]
		{
			0,
			1
		})]
		private IEnumerator<226> iEnumerator2;
	}
}
