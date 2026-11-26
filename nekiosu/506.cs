using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

// Token: 0x02000022 RID: 34
public sealed class 506<TItem> : IEnumerable<!0>, IEnumerable
{
	// Token: 0x1700000B RID: 11
	public TItem this[int 1]
	{
		get
		{
			if (1 < 0 || 1 > this.GetNumber4528_5711() - 1)
			{
				throw new ArgumentOutOfRangeException("#=zQ759Q9c=");
			}
			1 += this._number4531;
			if (1 > this._number4530 - 1)
			{
				1 -= this._number4530;
			}
			return this._itemArray4529[1];
		}
	}

	// Token: 0x060000BF RID: 191 RVA: 0x00005A0A File Offset: 0x00003C0A
	public 506(int 1)
	{
		if (1 < 0)
		{
			throw new ArgumentOutOfRangeException("#=zcawKLn0=");
		}
		this._number4530 = 1;
		this._itemArray4529 = new TItem[1];
		this._number4531 = 1;
	}

	// Token: 0x060000C0 RID: 192 RVA: 0x00005A3B File Offset: 0x00003C3B
	public int GetNumber4528_5711()
	{
		return this._number4528;
	}

	// Token: 0x060000C1 RID: 193 RVA: 0x00005A43 File Offset: 0x00003C43
	private void SetNumber4528_5712(int 1)
	{
		this._number4528 = 1;
	}

	// Token: 0x060000C2 RID: 194 RVA: 0x00005A4C File Offset: 0x00003C4C
	public void Method5713(TItem 1)
	{
		if (this._number4531 == 0)
		{
			this._number4531 = this._number4530 - 1;
		}
		else
		{
			this._number4531--;
		}
		this._itemArray4529[this._number4531] = 1;
		if (this.GetNumber4528_5711() < this._number4530)
		{
			int number4528_ = this.GetNumber4528_5711() + 1;
			this.SetNumber4528_5712(number4528_);
		}
	}

	// Token: 0x060000C3 RID: 195 RVA: 0x00005AAF File Offset: 0x00003CAF
	public IEnumerator<TItem> GetEnumerator()
	{
		return new 506<TItem>.507(0)
		{
			_recoveredType10144526 = this
		};
	}

	// Token: 0x060000C4 RID: 196 RVA: 0x00005ABE File Offset: 0x00003CBE
	private IEnumerator Method5714()
	{
		return this.GetEnumerator();
	}

	// Token: 0x060000C5 RID: 197 RVA: 0x00005AC6 File Offset: 0x00003CC6
	IEnumerator IEnumerable.GetEnumerator()
	{
		return this.Method5714();
	}

	// Token: 0x04000057 RID: 87
	private int _number4528;

	// Token: 0x04000058 RID: 88
	private readonly TItem[] _itemArray4529;

	// Token: 0x04000059 RID: 89
	private readonly int _number4530;

	// Token: 0x0400005A RID: 90
	private int _number4531;

	// Token: 0x02000023 RID: 35
	public sealed class 507 : IEnumerator<!0>, IDisposable, IEnumerator
	{
		// Token: 0x060000C6 RID: 198 RVA: 0x00005ACE File Offset: 0x00003CCE
		[DebuggerHidden]
		public 507(int 1)
		{
			this._number4524 = 1;
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00005ADD File Offset: 0x00003CDD
		[DebuggerHidden]
		private void Method5707()
		{
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00005ADF File Offset: 0x00003CDF
		void IDisposable.Dispose()
		{
			this.Method5707();
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00005AE8 File Offset: 0x00003CE8
		private bool MoveNext()
		{
			int number = this._number4524;
			506<TItem> recoveredType = this._recoveredType10144526;
			switch (number)
			{
			case 0:
				this._number4524 = -1;
				this._number4527 = recoveredType._number4531;
				break;
			case 1:
			{
				this._number4524 = -1;
				int number2 = this._number4527 + 1;
				this._number4527 = number2;
				break;
			}
			case 2:
			{
				this._number4524 = -1;
				int number3 = this._number4527 + 1;
				this._number4527 = number3;
				goto IL_AC;
			}
			default:
				return false;
			}
			if (this._number4527 < recoveredType._number4530)
			{
				this._item4525 = recoveredType._itemArray4529[this._number4527];
				this._number4524 = 1;
				return true;
			}
			if (recoveredType.GetNumber4528_5711() != recoveredType._number4530)
			{
				return false;
			}
			this._number4527 = 0;
			IL_AC:
			if (this._number4527 < recoveredType._number4531)
			{
				this._item4525 = recoveredType._itemArray4529[this._number4527];
				this._number4524 = 2;
				return true;
			}
			return false;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00005BD0 File Offset: 0x00003DD0
		bool IEnumerator.MoveNext()
		{
			return this.MoveNext();
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00005BD8 File Offset: 0x00003DD8
		[DebuggerHidden]
		private TItem GetItem4525_5708()
		{
			return this._item4525;
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x060000CC RID: 204 RVA: 0x00005BE0 File Offset: 0x00003DE0
		TItem IEnumerator<!0>.Current
		{
			get
			{
				return this.GetItem4525_5708();
			}
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00005BE8 File Offset: 0x00003DE8
		[DebuggerHidden]
		private void Method5709()
		{
			throw new NotSupportedException();
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00005BEF File Offset: 0x00003DEF
		void IEnumerator.Reset()
		{
			this.Method5709();
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00005BF7 File Offset: 0x00003DF7
		[DebuggerHidden]
		private object GetItem4525_5710()
		{
			return this._item4525;
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x00005C04 File Offset: 0x00003E04
		object IEnumerator.Current
		{
			get
			{
				return this.GetItem4525_5710();
			}
		}

		// Token: 0x0400005B RID: 91
		private int _number4524;

		// Token: 0x0400005C RID: 92
		private TItem _item4525;

		// Token: 0x0400005D RID: 93
		public 506<TItem> _recoveredType10144526;

		// Token: 0x0400005E RID: 94
		private int _number4527;
	}
}
