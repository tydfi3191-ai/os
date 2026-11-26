using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

// Token: 0x0200012D RID: 301
[242(1)]
[241(0)]
public sealed class 445 : 368
{
	// Token: 0x06000AA5 RID: 2725 RVA: 0x000289C8 File Offset: 0x00026BC8
	public 445(781 1)
	{
		this._recoveredType23363071 = 1;
	}

	// Token: 0x06000AA6 RID: 2726 RVA: 0x000289D7 File Offset: 0x00026BD7
	public override IEnumerable<226> Method12761(226 1, IEnumerable<226> 2, [241(2)] 541 3)
	{
		return new 445.446(-2)
		{
			_recoveredType06923064 = this,
			jToken3 = 1,
			iEnumerable2 = 2,
			_recoveredType12043068 = 3
		};
	}

	// Token: 0x04000540 RID: 1344
	internal 781 _recoveredType23363071;

	// Token: 0x0200012E RID: 302
	public sealed class 446 : IEnumerable<226>, IEnumerable, IEnumerator<226>, IDisposable, IEnumerator
	{
		// Token: 0x06000AA7 RID: 2727 RVA: 0x000289FC File Offset: 0x00026BFC
		[DebuggerHidden]
		public 446(int 1)
		{
			this.number2 = 1;
			this.number3 = Thread.CurrentThread.ManagedThreadId;
		}

		// Token: 0x06000AA8 RID: 2728 RVA: 0x00028A1C File Offset: 0x00026C1C
		[DebuggerHidden]
		private void Method3935()
		{
			int num = this.number2;
			if (num - -4 > 1 && num - 1 > 1)
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
						this.Method3937();
					}
				}
			}
			finally
			{
				this.Method3936();
			}
		}

		// Token: 0x06000AA9 RID: 2729 RVA: 0x00028A78 File Offset: 0x00026C78
		void IDisposable.Dispose()
		{
			this.Method3935();
		}

		// Token: 0x06000AAA RID: 2730 RVA: 0x00028A80 File Offset: 0x00026C80
		private bool MoveNext()
		{
			try
			{
				int num = this.number2;
				445 recoveredType = this._recoveredType06923064;
				switch (num)
				{
				case 0:
					this.number2 = -1;
					this.iEnumerator = this.iEnumerable.GetEnumerator();
					this.number2 = -3;
					break;
				case 1:
					this.number2 = -4;
					goto IL_11B;
				case 2:
					this.number2 = -3;
					break;
				default:
					return false;
				}
				IL_5E:
				while (this.iEnumerator.MoveNext())
				{
					226 <<EMPTY_NAME>> = this.iEnumerator.Current;
					111 2 = <<EMPTY_NAME>> as 111;
					if (2 != null)
					{
						this.iEnumerator2 = 2.Method7240().GetEnumerator();
						this.number2 = -4;
						goto IL_11B;
					}
					if (recoveredType._recoveredType23363071.Method12763(this.jToken2, <<EMPTY_NAME>>, this._recoveredType12043067))
					{
						this.jToken = <<EMPTY_NAME>>;
						this.number2 = 2;
						return true;
					}
				}
				this.Method3936();
				this.iEnumerator = null;
				return false;
				IL_11B:
				while (this.iEnumerator2.MoveNext())
				{
					226 3 = this.iEnumerator2.Current;
					if (recoveredType._recoveredType23363071.Method12763(this.jToken2, 3, this._recoveredType12043067))
					{
						this.jToken = 3;
						this.number2 = 1;
						return true;
					}
				}
				this.Method3937();
				this.iEnumerator2 = null;
				goto IL_5E;
			}
			catch
			{
				this.Method3935();
				throw;
			}
			bool result;
			return result;
		}

		// Token: 0x06000AAB RID: 2731 RVA: 0x00028BF0 File Offset: 0x00026DF0
		bool IEnumerator.MoveNext()
		{
			return this.MoveNext();
		}

		// Token: 0x06000AAC RID: 2732 RVA: 0x00028BF8 File Offset: 0x00026DF8
		private void Method3936()
		{
			this.number2 = -1;
			if (this.iEnumerator != null)
			{
				this.iEnumerator.Dispose();
			}
		}

		// Token: 0x06000AAD RID: 2733 RVA: 0x00028C14 File Offset: 0x00026E14
		private void Method3937()
		{
			this.number2 = -3;
			if (this.iEnumerator2 != null)
			{
				this.iEnumerator2.Dispose();
			}
		}

		// Token: 0x06000AAE RID: 2734 RVA: 0x00028C31 File Offset: 0x00026E31
		[DebuggerHidden]
		private 226 GetJToken3060_3938()
		{
			return this.jToken;
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000AAF RID: 2735 RVA: 0x00028C39 File Offset: 0x00026E39
		226 IEnumerator<226>.Current
		{
			get
			{
				return this.GetJToken3060_3938();
			}
		}

		// Token: 0x06000AB0 RID: 2736 RVA: 0x00005BE8 File Offset: 0x00003DE8
		[DebuggerHidden]
		private void Method3939()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06000AB1 RID: 2737 RVA: 0x00028C41 File Offset: 0x00026E41
		void IEnumerator.Reset()
		{
			this.Method3939();
		}

		// Token: 0x06000AB2 RID: 2738 RVA: 0x00028C31 File Offset: 0x00026E31
		[DebuggerHidden]
		[return: 241(0)]
		private object GetJToken3060_3940()
		{
			return this.jToken;
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000AB3 RID: 2739 RVA: 0x00028C49 File Offset: 0x00026E49
		object IEnumerator.Current
		{
			get
			{
				return this.GetJToken3060_3940();
			}
		}

		// Token: 0x06000AB4 RID: 2740 RVA: 0x00028C54 File Offset: 0x00026E54
		[DebuggerHidden]
		[return: 241(0)]
		private IEnumerator<226> Method3941()
		{
			445.446 <<EMPTY_NAME>>;
			if (this.number2 == -2 && this.number3 == Thread.CurrentThread.ManagedThreadId)
			{
				this.number2 = 0;
				<<EMPTY_NAME>> = this;
			}
			else
			{
				<<EMPTY_NAME>> = new 445.446(0);
				<<EMPTY_NAME>>._recoveredType06923064 = this._recoveredType06923064;
			}
			<<EMPTY_NAME>>.jToken2 = this.jToken3;
			<<EMPTY_NAME>>.iEnumerable = this.iEnumerable2;
			<<EMPTY_NAME>>._recoveredType12043067 = this._recoveredType12043068;
			return <<EMPTY_NAME>>;
		}

		// Token: 0x06000AB5 RID: 2741 RVA: 0x00028CC0 File Offset: 0x00026EC0
		IEnumerator<226> IEnumerable<226>.GetEnumerator()
		{
			return this.Method3941();
		}

		// Token: 0x06000AB6 RID: 2742 RVA: 0x00028CC0 File Offset: 0x00026EC0
		[DebuggerHidden]
		[return: 241(0)]
		private IEnumerator Method3942()
		{
			return this.Method3941();
		}

		// Token: 0x06000AB7 RID: 2743 RVA: 0x00028CC8 File Offset: 0x00026EC8
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.Method3942();
		}

		// Token: 0x04000541 RID: 1345
		private int number2;

		// Token: 0x04000542 RID: 1346
		private 226 jToken;

		// Token: 0x04000543 RID: 1347
		private int number3;

		// Token: 0x04000544 RID: 1348
		[241(new byte[]
		{
			0,
			1
		})]
		private IEnumerable<226> iEnumerable;

		// Token: 0x04000545 RID: 1349
		[241(new byte[]
		{
			0,
			1
		})]
		public IEnumerable<226> iEnumerable2;

		// Token: 0x04000546 RID: 1350
		[241(0)]
		public 445 _recoveredType06923064;

		// Token: 0x04000547 RID: 1351
		[241(0)]
		private 226 jToken2;

		// Token: 0x04000548 RID: 1352
		[241(0)]
		public 226 jToken3;

		// Token: 0x04000549 RID: 1353
		[241(0)]
		private 541 _recoveredType12043067;

		// Token: 0x0400054A RID: 1354
		[241(0)]
		public 541 _recoveredType12043068;

		// Token: 0x0400054B RID: 1355
		[241(new byte[]
		{
			0,
			1
		})]
		private IEnumerator<226> iEnumerator;

		// Token: 0x0400054C RID: 1356
		[241(new byte[]
		{
			0,
			1
		})]
		private IEnumerator<226> iEnumerator2;
	}
}
