using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Threading;

// Token: 0x02000170 RID: 368
[242(2)]
[241(0)]
public sealed class 599 : 368
{
	// Token: 0x06000C45 RID: 3141 RVA: 0x0002C658 File Offset: 0x0002A858
	public 599(string 1)
	{
		this.text2 = 1;
	}

	// Token: 0x06000C46 RID: 3142 RVA: 0x0002C667 File Offset: 0x0002A867
	[242(1)]
	public override IEnumerable<226> Method12761(226 1, IEnumerable<226> 2, [241(2)] 541 3)
	{
		return new 599.600(-2)
		{
			_recoveredType14446382 = this,
			iEnumerable2 = 2,
			_recoveredType12046384 = 3
		};
	}

	// Token: 0x04000608 RID: 1544
	internal string text2;

	// Token: 0x02000171 RID: 369
	public sealed class 600 : IEnumerable<226>, IEnumerable, IEnumerator<226>, IDisposable, IEnumerator
	{
		// Token: 0x06000C47 RID: 3143 RVA: 0x0002C685 File Offset: 0x0002A885
		[DebuggerHidden]
		public 600(int 1)
		{
			this.number2 = 1;
			this.number3 = Thread.CurrentThread.ManagedThreadId;
		}

		// Token: 0x06000C48 RID: 3144 RVA: 0x0002C6A4 File Offset: 0x0002A8A4
		[DebuggerHidden]
		private void Method8163()
		{
			int num = this.number2;
			if (num - -4 > 1 && num - 1 > 1)
			{
				return;
			}
			try
			{
				if (num == -4 || num == 2)
				{
					try
					{
					}
					finally
					{
						this.Method8165();
					}
				}
			}
			finally
			{
				this.Method8164();
			}
		}

		// Token: 0x06000C49 RID: 3145 RVA: 0x0002C700 File Offset: 0x0002A900
		void IDisposable.Dispose()
		{
			this.Method8163();
		}

		// Token: 0x06000C4A RID: 3146 RVA: 0x0002C708 File Offset: 0x0002A908
		private bool MoveNext()
		{
			bool result;
			try
			{
				int num = this.number2;
				599 recoveredType = this._recoveredType14446382;
				switch (num)
				{
				case 0:
					this.number2 = -1;
					this.iEnumerator = this.iEnumerable.GetEnumerator();
					this.number2 = -3;
					break;
				case 1:
					this.number2 = -3;
					break;
				case 2:
					this.number2 = -4;
					goto IL_15B;
				default:
					return false;
				}
				IL_60:
				while (this.iEnumerator.MoveNext())
				{
					226 <<EMPTY_NAME>> = this.iEnumerator.Current;
					217 2 = <<EMPTY_NAME>> as 217;
					if (2 != null)
					{
						if (recoveredType.text2 == null)
						{
							this.iEnumerator2 = 2.GetEnumerator();
							this.number2 = -4;
							goto IL_15B;
						}
						226 3 = 2[recoveredType.text2];
						if (3 != null)
						{
							this.jToken2 = 3;
							this.number2 = 1;
							return true;
						}
						541 recoveredType2 = this._recoveredType12046383;
						if (recoveredType2 != null && recoveredType2.GetFlag5433_6846())
						{
							throw new 134("Property '{0}' does not exist on JObject.".Method6825(CultureInfo.InvariantCulture, recoveredType.text2));
						}
					}
					else
					{
						541 recoveredType3 = this._recoveredType12046383;
						if (recoveredType3 != null && recoveredType3.GetFlag5433_6846())
						{
							throw new 134("Property '{0}' not valid on {1}.".Method6825(CultureInfo.InvariantCulture, recoveredType.text2 ?? "*", <<EMPTY_NAME>>.GetType().Name));
						}
					}
				}
				this.Method8164();
				this.iEnumerator = null;
				return false;
				IL_15B:
				if (!this.iEnumerator2.MoveNext())
				{
					this.Method8165();
					this.iEnumerator2 = null;
					goto IL_60;
				}
				KeyValuePair<string, 226> keyValuePair = this.iEnumerator2.Current;
				this.jToken2 = keyValuePair.Value;
				this.number2 = 2;
				result = true;
			}
			catch
			{
				this.Method8163();
				throw;
			}
			return result;
		}

		// Token: 0x06000C4B RID: 3147 RVA: 0x0002C8DC File Offset: 0x0002AADC
		bool IEnumerator.MoveNext()
		{
			return this.MoveNext();
		}

		// Token: 0x06000C4C RID: 3148 RVA: 0x0002C8E4 File Offset: 0x0002AAE4
		private void Method8164()
		{
			this.number2 = -1;
			if (this.iEnumerator != null)
			{
				this.iEnumerator.Dispose();
			}
		}

		// Token: 0x06000C4D RID: 3149 RVA: 0x0002C900 File Offset: 0x0002AB00
		private void Method8165()
		{
			this.number2 = -3;
			if (this.iEnumerator2 != null)
			{
				this.iEnumerator2.Dispose();
			}
		}

		// Token: 0x06000C4E RID: 3150 RVA: 0x0002C91D File Offset: 0x0002AB1D
		[DebuggerHidden]
		[return: 241(1)]
		private 226 GetJToken6378_8166()
		{
			return this.jToken2;
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000C4F RID: 3151 RVA: 0x0002C925 File Offset: 0x0002AB25
		226 IEnumerator<226>.Current
		{
			get
			{
				return this.GetJToken6378_8166();
			}
		}

		// Token: 0x06000C50 RID: 3152 RVA: 0x00005BE8 File Offset: 0x00003DE8
		[DebuggerHidden]
		private void Method8167()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06000C51 RID: 3153 RVA: 0x0002C92D File Offset: 0x0002AB2D
		void IEnumerator.Reset()
		{
			this.Method8167();
		}

		// Token: 0x06000C52 RID: 3154 RVA: 0x0002C91D File Offset: 0x0002AB1D
		[DebuggerHidden]
		[return: 241(0)]
		private object GetJToken6378_8168()
		{
			return this.jToken2;
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000C53 RID: 3155 RVA: 0x0002C935 File Offset: 0x0002AB35
		object IEnumerator.Current
		{
			get
			{
				return this.GetJToken6378_8168();
			}
		}

		// Token: 0x06000C54 RID: 3156 RVA: 0x0002C940 File Offset: 0x0002AB40
		[DebuggerHidden]
		[return: 241(0)]
		private IEnumerator<226> Method8169()
		{
			599.600 <<EMPTY_NAME>>;
			if (this.number2 == -2 && this.number3 == Thread.CurrentThread.ManagedThreadId)
			{
				this.number2 = 0;
				<<EMPTY_NAME>> = this;
			}
			else
			{
				<<EMPTY_NAME>> = new 599.600(0);
				<<EMPTY_NAME>>._recoveredType14446382 = this._recoveredType14446382;
			}
			<<EMPTY_NAME>>.iEnumerable = this.iEnumerable2;
			<<EMPTY_NAME>>._recoveredType12046383 = this._recoveredType12046384;
			return <<EMPTY_NAME>>;
		}

		// Token: 0x06000C55 RID: 3157 RVA: 0x0002C9A0 File Offset: 0x0002ABA0
		IEnumerator<226> IEnumerable<226>.GetEnumerator()
		{
			return this.Method8169();
		}

		// Token: 0x06000C56 RID: 3158 RVA: 0x0002C9A0 File Offset: 0x0002ABA0
		[DebuggerHidden]
		[return: 241(0)]
		private IEnumerator Method8170()
		{
			return this.Method8169();
		}

		// Token: 0x06000C57 RID: 3159 RVA: 0x0002C9A8 File Offset: 0x0002ABA8
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.Method8170();
		}

		// Token: 0x04000609 RID: 1545
		private int number2;

		// Token: 0x0400060A RID: 1546
		[241(1)]
		private 226 jToken2;

		// Token: 0x0400060B RID: 1547
		private int number3;

		// Token: 0x0400060C RID: 1548
		[241(new byte[]
		{
			0,
			1
		})]
		private IEnumerable<226> iEnumerable;

		// Token: 0x0400060D RID: 1549
		[241(new byte[]
		{
			0,
			1
		})]
		public IEnumerable<226> iEnumerable2;

		// Token: 0x0400060E RID: 1550
		[241(0)]
		public 599 _recoveredType14446382;

		// Token: 0x0400060F RID: 1551
		[241(0)]
		private 541 _recoveredType12046383;

		// Token: 0x04000610 RID: 1552
		[241(0)]
		public 541 _recoveredType12046384;

		// Token: 0x04000611 RID: 1553
		[241(new byte[]
		{
			0,
			1
		})]
		private IEnumerator<226> iEnumerator;

		// Token: 0x04000612 RID: 1554
		[241(new byte[]
		{
			0,
			0,
			1,
			2
		})]
		private IEnumerator<KeyValuePair<string, 226>> iEnumerator2;
	}
}
