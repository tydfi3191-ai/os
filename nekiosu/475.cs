using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

// Token: 0x02000144 RID: 324
[242(2)]
[241(0)]
public sealed class 475 : 368
{
	// Token: 0x06000B2B RID: 2859 RVA: 0x00029F42 File Offset: 0x00028142
	public 475(string 1)
	{
		this.text2 = 1;
	}

	// Token: 0x06000B2C RID: 2860 RVA: 0x00029F51 File Offset: 0x00028151
	[242(1)]
	public override IEnumerable<226> Method12761(226 1, IEnumerable<226> 2, [241(2)] 541 3)
	{
		return new 475.476(-2)
		{
			_recoveredType08063504 = this,
			iEnumerable2 = 2
		};
	}

	// Token: 0x04000581 RID: 1409
	internal string text2;

	// Token: 0x02000145 RID: 325
	public sealed class 476 : IEnumerable<226>, IEnumerable, IEnumerator<226>, IDisposable, IEnumerator
	{
		// Token: 0x06000B2D RID: 2861 RVA: 0x00029F68 File Offset: 0x00028168
		[DebuggerHidden]
		public 476(int 1)
		{
			this.number2 = 1;
			this.number3 = Thread.CurrentThread.ManagedThreadId;
		}

		// Token: 0x06000B2E RID: 2862 RVA: 0x00029F88 File Offset: 0x00028188
		[DebuggerHidden]
		private void Method4514()
		{
			int num = this.number2;
			if (num == -3 || num - 1 <= 2)
			{
				try
				{
				}
				finally
				{
					this.Method4515();
				}
			}
		}

		// Token: 0x06000B2F RID: 2863 RVA: 0x00029FC4 File Offset: 0x000281C4
		void IDisposable.Dispose()
		{
			this.Method4514();
		}

		// Token: 0x06000B30 RID: 2864 RVA: 0x00029FCC File Offset: 0x000281CC
		private bool MoveNext()
		{
			try
			{
				int num = this.number2;
				475 recoveredType = this._recoveredType08063504;
				switch (num)
				{
				case 0:
					this.number2 = -1;
					this.iEnumerator = this.iEnumerable.GetEnumerator();
					this.number2 = -3;
					goto IL_6B;
				case 1:
					this.number2 = -3;
					goto IL_BF;
				case 2:
					this.number2 = -3;
					break;
				case 3:
					this.number2 = -3;
					break;
				default:
					return false;
				}
				222 2;
				for (;;)
				{
					IL_CB:
					111 <<EMPTY_NAME>> = this.jToken3 as 111;
					this.jToken3 = 368.Method1842(this.jToken2, <<EMPTY_NAME>>, this.jToken3);
					if (this.jToken3 == null)
					{
						goto IL_153;
					}
					2 = (this.jToken3 as 222);
					if (2 != null)
					{
						if (2.Name == recoveredType.text2)
						{
							break;
						}
					}
					else if (recoveredType.text2 == null)
					{
						goto Block_8;
					}
				}
				this.jToken = 2.Value;
				this.number2 = 2;
				return true;
				Block_8:
				this.jToken = this.jToken3;
				this.number2 = 3;
				return true;
				IL_153:
				this.jToken3 = null;
				this.jToken2 = null;
				IL_6B:
				if (!this.iEnumerator.MoveNext())
				{
					this.Method4515();
					this.iEnumerator = null;
					return false;
				}
				this.jToken2 = this.iEnumerator.Current;
				if (recoveredType.text2 == null)
				{
					this.jToken = this.jToken2;
					this.number2 = 1;
					return true;
				}
				IL_BF:
				this.jToken3 = this.jToken2;
				goto IL_CB;
			}
			catch
			{
				this.Method4514();
				throw;
			}
			bool result;
			return result;
		}

		// Token: 0x06000B31 RID: 2865 RVA: 0x0002A168 File Offset: 0x00028368
		bool IEnumerator.MoveNext()
		{
			return this.MoveNext();
		}

		// Token: 0x06000B32 RID: 2866 RVA: 0x0002A170 File Offset: 0x00028370
		private void Method4515()
		{
			this.number2 = -1;
			if (this.iEnumerator != null)
			{
				this.iEnumerator.Dispose();
			}
		}

		// Token: 0x06000B33 RID: 2867 RVA: 0x0002A18C File Offset: 0x0002838C
		[DebuggerHidden]
		[return: 241(1)]
		private 226 GetJToken3500_4516()
		{
			return this.jToken;
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000B34 RID: 2868 RVA: 0x0002A194 File Offset: 0x00028394
		226 IEnumerator<226>.Current
		{
			get
			{
				return this.GetJToken3500_4516();
			}
		}

		// Token: 0x06000B35 RID: 2869 RVA: 0x00005BE8 File Offset: 0x00003DE8
		[DebuggerHidden]
		private void Method4517()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06000B36 RID: 2870 RVA: 0x0002A19C File Offset: 0x0002839C
		void IEnumerator.Reset()
		{
			this.Method4517();
		}

		// Token: 0x06000B37 RID: 2871 RVA: 0x0002A18C File Offset: 0x0002838C
		[DebuggerHidden]
		[return: 241(0)]
		private object GetJToken3500_4518()
		{
			return this.jToken;
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000B38 RID: 2872 RVA: 0x0002A1A4 File Offset: 0x000283A4
		object IEnumerator.Current
		{
			get
			{
				return this.GetJToken3500_4518();
			}
		}

		// Token: 0x06000B39 RID: 2873 RVA: 0x0002A1AC File Offset: 0x000283AC
		[DebuggerHidden]
		[return: 241(0)]
		private IEnumerator<226> Method4519()
		{
			475.476 <<EMPTY_NAME>>;
			if (this.number2 == -2 && this.number3 == Thread.CurrentThread.ManagedThreadId)
			{
				this.number2 = 0;
				<<EMPTY_NAME>> = this;
			}
			else
			{
				<<EMPTY_NAME>> = new 475.476(0);
				<<EMPTY_NAME>>._recoveredType08063504 = this._recoveredType08063504;
			}
			<<EMPTY_NAME>>.iEnumerable = this.iEnumerable2;
			return <<EMPTY_NAME>>;
		}

		// Token: 0x06000B3A RID: 2874 RVA: 0x0002A200 File Offset: 0x00028400
		IEnumerator<226> IEnumerable<226>.GetEnumerator()
		{
			return this.Method4519();
		}

		// Token: 0x06000B3B RID: 2875 RVA: 0x0002A200 File Offset: 0x00028400
		[DebuggerHidden]
		[return: 241(0)]
		private IEnumerator Method4520()
		{
			return this.Method4519();
		}

		// Token: 0x06000B3C RID: 2876 RVA: 0x0002A208 File Offset: 0x00028408
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.Method4520();
		}

		// Token: 0x04000582 RID: 1410
		private int number2;

		// Token: 0x04000583 RID: 1411
		[241(1)]
		private 226 jToken;

		// Token: 0x04000584 RID: 1412
		private int number3;

		// Token: 0x04000585 RID: 1413
		[241(new byte[]
		{
			0,
			1
		})]
		private IEnumerable<226> iEnumerable;

		// Token: 0x04000586 RID: 1414
		[241(new byte[]
		{
			0,
			1
		})]
		public IEnumerable<226> iEnumerable2;

		// Token: 0x04000587 RID: 1415
		[241(0)]
		public 475 _recoveredType08063504;

		// Token: 0x04000588 RID: 1416
		[241(new byte[]
		{
			0,
			1
		})]
		private IEnumerator<226> iEnumerator;

		// Token: 0x04000589 RID: 1417
		[241(0)]
		private 226 jToken2;

		// Token: 0x0400058A RID: 1418
		[241(0)]
		private 226 jToken3;
	}
}
