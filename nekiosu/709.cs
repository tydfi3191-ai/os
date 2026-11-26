using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading;

// Token: 0x020001A6 RID: 422
[241(0)]
[242(1)]
public sealed class 709 : 368
{
	// Token: 0x06000DB9 RID: 3513 RVA: 0x0002F399 File Offset: 0x0002D599
	public 709(List<string> 1)
	{
		this.list2 = 1;
	}

	// Token: 0x06000DBA RID: 3514 RVA: 0x0002F3A8 File Offset: 0x0002D5A8
	public override IEnumerable<226> Method12761(226 1, IEnumerable<226> 2, [241(2)] 541 3)
	{
		return new 709.711(-2)
		{
			_recoveredType19888684 = this,
			iEnumerable2 = 2,
			_recoveredType12048686 = 3
		};
	}

	// Token: 0x04000694 RID: 1684
	internal List<string> list2;

	// Token: 0x020001A7 RID: 423
	[Serializable]
	public sealed class 710
	{
		// Token: 0x06000DBB RID: 3515 RVA: 0x0002F3C6 File Offset: 0x0002D5C6
		[242(0)]
		internal string Method11010(string 1)
		{
			return "'" + 1 + "'";
		}

		// Token: 0x04000695 RID: 1685
		[241(0)]
		public static readonly 709.710 instance = new 709.710();

		// Token: 0x04000696 RID: 1686
		[241(0)]
		public static Func<string, string> func;
	}

	// Token: 0x020001A8 RID: 424
	public sealed class 711 : IEnumerable<226>, IEnumerable, IEnumerator<226>, IDisposable, IEnumerator
	{
		// Token: 0x06000DBE RID: 3518 RVA: 0x0002F3E4 File Offset: 0x0002D5E4
		[DebuggerHidden]
		public 711(int 1)
		{
			this.number2 = 1;
			this.number3 = Thread.CurrentThread.ManagedThreadId;
		}

		// Token: 0x06000DBF RID: 3519 RVA: 0x0002F404 File Offset: 0x0002D604
		[DebuggerHidden]
		private void Method11011()
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
						this.Method11013();
					}
				}
			}
			finally
			{
				this.Method11012();
			}
		}

		// Token: 0x06000DC0 RID: 3520 RVA: 0x0002F460 File Offset: 0x0002D660
		void IDisposable.Dispose()
		{
			this.Method11011();
		}

		// Token: 0x06000DC1 RID: 3521 RVA: 0x0002F468 File Offset: 0x0002D668
		private bool MoveNext()
		{
			try
			{
				int num = this.number2;
				709 recoveredType = this._recoveredType19888684;
				if (num == 0)
				{
					this.number2 = -1;
					this.iEnumerator = this.iEnumerable.GetEnumerator();
					this.number2 = -3;
					goto IL_52;
				}
				if (num != 1)
				{
					return false;
				}
				this.number2 = -4;
				goto IL_16D;
				IL_4B:
				this.jObject = null;
				IL_52:
				if (!this.iEnumerator.MoveNext())
				{
					this.Method11012();
					this.iEnumerator = null;
					return false;
				}
				226 <<EMPTY_NAME>> = this.iEnumerator.Current;
				this.jObject = (<<EMPTY_NAME>> as 217);
				if (this.jObject != null)
				{
					this.enumerator = recoveredType.list2.GetEnumerator();
					this.number2 = -4;
				}
				else
				{
					541 recoveredType2 = this._recoveredType12048685;
					if (recoveredType2 != null && recoveredType2.GetFlag5433_6846())
					{
						throw new 134("Properties {0} not valid on {1}.".Method6825(CultureInfo.InvariantCulture, string.Join(", ", recoveredType.list2.Select(new Func<string, string>(709.710.instance.Method11010))), <<EMPTY_NAME>>.GetType().Name));
					}
					goto IL_4B;
				}
				IL_10E:
				if (!this.enumerator.MoveNext())
				{
					this.Method11013();
					this.enumerator = default(List<string>.Enumerator);
					goto IL_4B;
				}
				this.text = this.enumerator.Current;
				226 2 = this.jObject[this.text];
				if (2 != null)
				{
					this.jToken2 = 2;
					this.number2 = 1;
					return true;
				}
				IL_16D:
				541 recoveredType3 = this._recoveredType12048685;
				if (recoveredType3 != null && recoveredType3.GetFlag5433_6846())
				{
					throw new 134("Property '{0}' does not exist on JObject.".Method6825(CultureInfo.InvariantCulture, this.text));
				}
				this.text = null;
				goto IL_10E;
			}
			catch
			{
				this.Method11011();
				throw;
			}
			bool result;
			return result;
		}

		// Token: 0x06000DC2 RID: 3522 RVA: 0x0002F644 File Offset: 0x0002D844
		bool IEnumerator.MoveNext()
		{
			return this.MoveNext();
		}

		// Token: 0x06000DC3 RID: 3523 RVA: 0x0002F64C File Offset: 0x0002D84C
		private void Method11012()
		{
			this.number2 = -1;
			if (this.iEnumerator != null)
			{
				this.iEnumerator.Dispose();
			}
		}

		// Token: 0x06000DC4 RID: 3524 RVA: 0x0002F668 File Offset: 0x0002D868
		private void Method11013()
		{
			this.number2 = -3;
			((IDisposable)this.enumerator).Dispose();
		}

		// Token: 0x06000DC5 RID: 3525 RVA: 0x0002F682 File Offset: 0x0002D882
		[DebuggerHidden]
		private 226 GetJToken8680_11014()
		{
			return this.jToken2;
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000DC6 RID: 3526 RVA: 0x0002F68A File Offset: 0x0002D88A
		226 IEnumerator<226>.Current
		{
			get
			{
				return this.GetJToken8680_11014();
			}
		}

		// Token: 0x06000DC7 RID: 3527 RVA: 0x00005BE8 File Offset: 0x00003DE8
		[DebuggerHidden]
		private void Method11015()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06000DC8 RID: 3528 RVA: 0x0002F692 File Offset: 0x0002D892
		void IEnumerator.Reset()
		{
			this.Method11015();
		}

		// Token: 0x06000DC9 RID: 3529 RVA: 0x0002F682 File Offset: 0x0002D882
		[DebuggerHidden]
		[return: 241(0)]
		private object GetJToken8680_11016()
		{
			return this.jToken2;
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000DCA RID: 3530 RVA: 0x0002F69A File Offset: 0x0002D89A
		object IEnumerator.Current
		{
			get
			{
				return this.GetJToken8680_11016();
			}
		}

		// Token: 0x06000DCB RID: 3531 RVA: 0x0002F6A4 File Offset: 0x0002D8A4
		[DebuggerHidden]
		[return: 241(0)]
		private IEnumerator<226> Method11017()
		{
			709.711 <<EMPTY_NAME>>;
			if (this.number2 == -2 && this.number3 == Thread.CurrentThread.ManagedThreadId)
			{
				this.number2 = 0;
				<<EMPTY_NAME>> = this;
			}
			else
			{
				<<EMPTY_NAME>> = new 709.711(0);
				<<EMPTY_NAME>>._recoveredType19888684 = this._recoveredType19888684;
			}
			<<EMPTY_NAME>>.iEnumerable = this.iEnumerable2;
			<<EMPTY_NAME>>._recoveredType12048685 = this._recoveredType12048686;
			return <<EMPTY_NAME>>;
		}

		// Token: 0x06000DCC RID: 3532 RVA: 0x0002F704 File Offset: 0x0002D904
		IEnumerator<226> IEnumerable<226>.GetEnumerator()
		{
			return this.Method11017();
		}

		// Token: 0x06000DCD RID: 3533 RVA: 0x0002F704 File Offset: 0x0002D904
		[DebuggerHidden]
		[return: 241(0)]
		private IEnumerator Method11018()
		{
			return this.Method11017();
		}

		// Token: 0x06000DCE RID: 3534 RVA: 0x0002F70C File Offset: 0x0002D90C
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.Method11018();
		}

		// Token: 0x04000697 RID: 1687
		private int number2;

		// Token: 0x04000698 RID: 1688
		private 226 jToken2;

		// Token: 0x04000699 RID: 1689
		private int number3;

		// Token: 0x0400069A RID: 1690
		[241(new byte[]
		{
			0,
			1
		})]
		private IEnumerable<226> iEnumerable;

		// Token: 0x0400069B RID: 1691
		[241(new byte[]
		{
			0,
			1
		})]
		public IEnumerable<226> iEnumerable2;

		// Token: 0x0400069C RID: 1692
		[241(0)]
		public 709 _recoveredType19888684;

		// Token: 0x0400069D RID: 1693
		[241(0)]
		private 541 _recoveredType12048685;

		// Token: 0x0400069E RID: 1694
		[241(0)]
		public 541 _recoveredType12048686;

		// Token: 0x0400069F RID: 1695
		[241(new byte[]
		{
			0,
			1
		})]
		private IEnumerator<226> iEnumerator;

		// Token: 0x040006A0 RID: 1696
		[241(0)]
		private 217 jObject;

		// Token: 0x040006A1 RID: 1697
		[241(new byte[]
		{
			0,
			1
		})]
		private List<string>.Enumerator enumerator;

		// Token: 0x040006A2 RID: 1698
		[241(0)]
		private string text;
	}
}
