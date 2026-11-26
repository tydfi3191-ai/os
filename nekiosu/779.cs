using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Threading;

// Token: 0x020001C1 RID: 449
public sealed class 779 : 368
{
	// Token: 0x06000E56 RID: 3670 RVA: 0x000307C3 File Offset: 0x0002E9C3
	public int? GetNullable9986_12755()
	{
		return this.nullable2;
	}

	// Token: 0x06000E57 RID: 3671 RVA: 0x000307CB File Offset: 0x0002E9CB
	public void SetNullable9986_12756(int? 1)
	{
		this.nullable2 = 1;
	}

	// Token: 0x06000E58 RID: 3672 RVA: 0x000307D4 File Offset: 0x0002E9D4
	public int? GetNullable9987_12757()
	{
		return this.nullable3;
	}

	// Token: 0x06000E59 RID: 3673 RVA: 0x000307DC File Offset: 0x0002E9DC
	public void SetNullable9987_12758(int? 1)
	{
		this.nullable3 = 1;
	}

	// Token: 0x06000E5A RID: 3674 RVA: 0x000307E5 File Offset: 0x0002E9E5
	public int? GetNullable9988_12759()
	{
		return this.nullable4;
	}

	// Token: 0x06000E5B RID: 3675 RVA: 0x000307ED File Offset: 0x0002E9ED
	public void SetNullable9988_12760(int? 1)
	{
		this.nullable4 = 1;
	}

	// Token: 0x06000E5C RID: 3676 RVA: 0x000307F6 File Offset: 0x0002E9F6
	[242(1)]
	public override IEnumerable<226> Method12761(226 1, IEnumerable<226> 2, [241(2)] 541 3)
	{
		return new 779.780(-2)
		{
			_recoveredType23349975 = this,
			iEnumerable2 = 2,
			_recoveredType12049979 = 3
		};
	}

	// Token: 0x06000E5D RID: 3677 RVA: 0x00030814 File Offset: 0x0002EA14
	private bool Method12762(int 1, int 2, bool 3)
	{
		if (3)
		{
			return 1 < 2;
		}
		return 1 > 2;
	}

	// Token: 0x04000703 RID: 1795
	private int? nullable2;

	// Token: 0x04000704 RID: 1796
	private int? nullable3;

	// Token: 0x04000705 RID: 1797
	private int? nullable4;

	// Token: 0x020001C2 RID: 450
	public sealed class 780 : IEnumerable<226>, IEnumerable, IEnumerator<226>, IDisposable, IEnumerator
	{
		// Token: 0x06000E5F RID: 3679 RVA: 0x00030822 File Offset: 0x0002EA22
		[DebuggerHidden]
		public 780(int 1)
		{
			this.number2 = 1;
			this.number3 = Thread.CurrentThread.ManagedThreadId;
		}

		// Token: 0x06000E60 RID: 3680 RVA: 0x00030844 File Offset: 0x0002EA44
		[DebuggerHidden]
		private void Method12748()
		{
			int num = this.number2;
			if (num == -3 || num == 1)
			{
				try
				{
				}
				finally
				{
					this.Method12749();
				}
			}
		}

		// Token: 0x06000E61 RID: 3681 RVA: 0x0003087C File Offset: 0x0002EA7C
		void IDisposable.Dispose()
		{
			this.Method12748();
		}

		// Token: 0x06000E62 RID: 3682 RVA: 0x00030884 File Offset: 0x0002EA84
		private bool MoveNext()
		{
			try
			{
				int num = this.number2;
				779 recoveredType = this._recoveredType23349975;
				if (num != 0)
				{
					if (num != 1)
					{
						return false;
					}
					this.number2 = -3;
					this.number6 += this.number4;
				}
				else
				{
					this.number2 = -1;
					int? num2 = recoveredType.GetNullable9988_12759();
					int num3 = 0;
					if (num2.GetValueOrDefault() == num3 & num2 != null)
					{
						throw new 134("Step cannot be zero.");
					}
					this.iEnumerator = this.iEnumerable.GetEnumerator();
					this.number2 = -3;
					goto IL_C7;
				}
				IL_85:
				if (recoveredType.Method12762(this.number6, this.number5, this.flag))
				{
					this.jToken = this.jArray[this.number6];
					this.number2 = 1;
					return true;
				}
				goto IL_364;
				IL_C7:
				if (!this.iEnumerator.MoveNext())
				{
					this.Method12749();
					this.iEnumerator = null;
					return false;
				}
				226 <<EMPTY_NAME>> = this.iEnumerator.Current;
				this.jArray = (<<EMPTY_NAME>> as 109);
				if (this.jArray != null)
				{
					this.number4 = recoveredType.GetNullable9988_12759().GetValueOrDefault(1);
					int num4 = recoveredType.GetNullable9986_12755() ?? ((this.number4 <= 0) ? (this.jArray.Count - 1) : 0);
					this.number5 = (recoveredType.GetNullable9987_12757() ?? ((this.number4 > 0) ? this.jArray.Count : -1));
					int? num2 = recoveredType.GetNullable9986_12755();
					int num3 = 0;
					if (num2.GetValueOrDefault() < num3 & num2 != null)
					{
						num4 = this.jArray.Count + num4;
					}
					num2 = recoveredType.GetNullable9987_12757();
					num3 = 0;
					if (num2.GetValueOrDefault() < num3 & num2 != null)
					{
						this.number5 = this.jArray.Count + this.number5;
					}
					num4 = Math.Max(num4, (this.number4 <= 0) ? int.MinValue : 0);
					num4 = Math.Min(num4, (this.number4 > 0) ? this.jArray.Count : (this.jArray.Count - 1));
					this.number5 = Math.Max(this.number5, -1);
					this.number5 = Math.Min(this.number5, this.jArray.Count);
					this.flag = (this.number4 > 0);
					if (recoveredType.Method12762(num4, this.number5, this.flag))
					{
						this.number6 = num4;
						goto IL_85;
					}
					541 recoveredType2 = this._recoveredType12049978;
					if (recoveredType2 != null && recoveredType2.GetFlag5433_6846())
					{
						throw new 134("Array slice of {0} to {1} returned no results.".Method6825(CultureInfo.InvariantCulture, (recoveredType.GetNullable9986_12755() != null) ? recoveredType.GetNullable9986_12755().GetValueOrDefault().ToString(CultureInfo.InvariantCulture) : "*", (recoveredType.GetNullable9987_12757() != null) ? recoveredType.GetNullable9987_12757().GetValueOrDefault().ToString(CultureInfo.InvariantCulture) : "*"));
					}
				}
				else
				{
					541 recoveredType3 = this._recoveredType12049978;
					if (recoveredType3 != null && recoveredType3.GetFlag5433_6846())
					{
						throw new 134("Array slice is not valid on {0}.".Method6825(CultureInfo.InvariantCulture, <<EMPTY_NAME>>.GetType().Name));
					}
				}
				IL_364:
				this.jArray = null;
				goto IL_C7;
			}
			catch
			{
				this.Method12748();
				throw;
			}
			bool result;
			return result;
		}

		// Token: 0x06000E63 RID: 3683 RVA: 0x00030C28 File Offset: 0x0002EE28
		bool IEnumerator.MoveNext()
		{
			return this.MoveNext();
		}

		// Token: 0x06000E64 RID: 3684 RVA: 0x00030C30 File Offset: 0x0002EE30
		private void Method12749()
		{
			this.number2 = -1;
			if (this.iEnumerator != null)
			{
				this.iEnumerator.Dispose();
			}
		}

		// Token: 0x06000E65 RID: 3685 RVA: 0x00030C4C File Offset: 0x0002EE4C
		[DebuggerHidden]
		[return: 241(1)]
		private 226 GetJToken9973_12750()
		{
			return this.jToken;
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000E66 RID: 3686 RVA: 0x00030C54 File Offset: 0x0002EE54
		226 IEnumerator<226>.Current
		{
			get
			{
				return this.GetJToken9973_12750();
			}
		}

		// Token: 0x06000E67 RID: 3687 RVA: 0x00005BE8 File Offset: 0x00003DE8
		[DebuggerHidden]
		private void Method12751()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06000E68 RID: 3688 RVA: 0x00030C5C File Offset: 0x0002EE5C
		void IEnumerator.Reset()
		{
			this.Method12751();
		}

		// Token: 0x06000E69 RID: 3689 RVA: 0x00030C4C File Offset: 0x0002EE4C
		[DebuggerHidden]
		private object GetJToken9973_12752()
		{
			return this.jToken;
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000E6A RID: 3690 RVA: 0x00030C64 File Offset: 0x0002EE64
		object IEnumerator.Current
		{
			get
			{
				return this.GetJToken9973_12752();
			}
		}

		// Token: 0x06000E6B RID: 3691 RVA: 0x00030C6C File Offset: 0x0002EE6C
		[DebuggerHidden]
		private IEnumerator<226> Method12753()
		{
			779.780 <<EMPTY_NAME>>;
			if (this.number2 == -2 && this.number3 == Thread.CurrentThread.ManagedThreadId)
			{
				this.number2 = 0;
				<<EMPTY_NAME>> = this;
			}
			else
			{
				<<EMPTY_NAME>> = new 779.780(0);
				<<EMPTY_NAME>>._recoveredType23349975 = this._recoveredType23349975;
			}
			<<EMPTY_NAME>>.iEnumerable = this.iEnumerable2;
			<<EMPTY_NAME>>._recoveredType12049978 = this._recoveredType12049979;
			return <<EMPTY_NAME>>;
		}

		// Token: 0x06000E6C RID: 3692 RVA: 0x00030CCC File Offset: 0x0002EECC
		IEnumerator<226> IEnumerable<226>.GetEnumerator()
		{
			return this.Method12753();
		}

		// Token: 0x06000E6D RID: 3693 RVA: 0x00030CCC File Offset: 0x0002EECC
		[DebuggerHidden]
		private IEnumerator Method12754()
		{
			return this.Method12753();
		}

		// Token: 0x06000E6E RID: 3694 RVA: 0x00030CD4 File Offset: 0x0002EED4
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.Method12754();
		}

		// Token: 0x04000706 RID: 1798
		private int number2;

		// Token: 0x04000707 RID: 1799
		[241(1)]
		private 226 jToken;

		// Token: 0x04000708 RID: 1800
		private int number3;

		// Token: 0x04000709 RID: 1801
		public 779 _recoveredType23349975;

		// Token: 0x0400070A RID: 1802
		[241(new byte[]
		{
			0,
			1
		})]
		private IEnumerable<226> iEnumerable;

		// Token: 0x0400070B RID: 1803
		[241(new byte[]
		{
			0,
			1
		})]
		public IEnumerable<226> iEnumerable2;

		// Token: 0x0400070C RID: 1804
		private 541 _recoveredType12049978;

		// Token: 0x0400070D RID: 1805
		public 541 _recoveredType12049979;

		// Token: 0x0400070E RID: 1806
		[241(new byte[]
		{
			0,
			1
		})]
		private IEnumerator<226> iEnumerator;

		// Token: 0x0400070F RID: 1807
		private 109 jArray;

		// Token: 0x04000710 RID: 1808
		private int number4;

		// Token: 0x04000711 RID: 1809
		private int number5;

		// Token: 0x04000712 RID: 1810
		private bool flag;

		// Token: 0x04000713 RID: 1811
		private int number6;
	}
}
