using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

// Token: 0x02000025 RID: 37
public sealed class 520<TItem> : IEnumerable<!0>, IEnumerable
{
	// Token: 0x1700000E RID: 14
	public TItem this[int 1]
	{
		get
		{
			if (1 < 0 || 1 >= this.GetNumber4767_5997())
			{
				throw new ArgumentOutOfRangeException("#=zEcSd6Vg=");
			}
			return this._itemArray4768[(this._number4770 + 1) % this._number4769];
		}
	}

	// Token: 0x060000D4 RID: 212 RVA: 0x00005C50 File Offset: 0x00003E50
	public 520(int 1)
	{
		if (1 < 0)
		{
			throw new ArgumentOutOfRangeException("#=zcawKLn0=");
		}
		this._number4769 = 1;
		this._itemArray4768 = new TItem[1];
		this.Method6000();
	}

	// Token: 0x060000D5 RID: 213 RVA: 0x00005C80 File Offset: 0x00003E80
	public int GetNumber4767_5997()
	{
		return this._number4767;
	}

	// Token: 0x060000D6 RID: 214 RVA: 0x00005C88 File Offset: 0x00003E88
	private void SetNumber4767_5998(int 1)
	{
		this._number4767 = 1;
	}

	// Token: 0x060000D7 RID: 215 RVA: 0x00005C91 File Offset: 0x00003E91
	public bool Method5999()
	{
		return this.GetNumber4767_5997() == this._number4769;
	}

	// Token: 0x060000D8 RID: 216 RVA: 0x00005CA1 File Offset: 0x00003EA1
	public void Method6000()
	{
		this._number4770 = 0;
		this._number4771 = -1;
		this.SetNumber4767_5998(0);
	}

	// Token: 0x060000D9 RID: 217 RVA: 0x00005CB8 File Offset: 0x00003EB8
	public TItem Method6001()
	{
		if (this.GetNumber4767_5997() == 0)
		{
			throw new InvalidOperationException("Queue is empty.");
		}
		TItem result = this._itemArray4768[this._number4770];
		this._number4770 = (this._number4770 + 1) % this._number4769;
		int number4767_ = this.GetNumber4767_5997();
		this.SetNumber4767_5998(number4767_ - 1);
		return result;
	}

	// Token: 0x060000DA RID: 218 RVA: 0x00005D10 File Offset: 0x00003F10
	public void Method6002(TItem 1)
	{
		this._number4771 = (this._number4771 + 1) % this._number4769;
		if (this.GetNumber4767_5997() == this._number4769)
		{
			this._number4770 = (this._number4770 + 1) % this._number4769;
		}
		else
		{
			int number4767_ = this.GetNumber4767_5997();
			this.SetNumber4767_5998(number4767_ + 1);
		}
		this._itemArray4768[this._number4771] = 1;
	}

	// Token: 0x060000DB RID: 219 RVA: 0x00005D79 File Offset: 0x00003F79
	public IEnumerator<TItem> GetEnumerator()
	{
		return new 520<TItem>.521(0)
		{
			_recoveredType10814765 = this
		};
	}

	// Token: 0x060000DC RID: 220 RVA: 0x00005D88 File Offset: 0x00003F88
	private IEnumerator Method6003()
	{
		return this.GetEnumerator();
	}

	// Token: 0x060000DD RID: 221 RVA: 0x00005D90 File Offset: 0x00003F90
	IEnumerator IEnumerable.GetEnumerator()
	{
		return this.Method6003();
	}

	// Token: 0x0400005F RID: 95
	private int _number4767;

	// Token: 0x04000060 RID: 96
	private readonly TItem[] _itemArray4768;

	// Token: 0x04000061 RID: 97
	private readonly int _number4769;

	// Token: 0x04000062 RID: 98
	private int _number4770;

	// Token: 0x04000063 RID: 99
	private int _number4771;

	// Token: 0x02000026 RID: 38
	public sealed class 521 : IEnumerator<!0>, IDisposable, IEnumerator
	{
		// Token: 0x060000DE RID: 222 RVA: 0x00005D98 File Offset: 0x00003F98
		[DebuggerHidden]
		public 521(int 1)
		{
			this._number4763 = 1;
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00005ADD File Offset: 0x00003CDD
		[DebuggerHidden]
		private void Method5993()
		{
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00005DA7 File Offset: 0x00003FA7
		void IDisposable.Dispose()
		{
			this.Method5993();
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00005DB0 File Offset: 0x00003FB0
		private bool MoveNext()
		{
			int number = this._number4763;
			520<TItem> recoveredType = this._recoveredType10814765;
			if (number != 0)
			{
				if (number != 1)
				{
					return false;
				}
				this._number4763 = -1;
				this._number4766++;
			}
			else
			{
				this._number4763 = -1;
				if (recoveredType.GetNumber4767_5997() == 0)
				{
					return false;
				}
				this._number4766 = 0;
			}
			if (this._number4766 < recoveredType.GetNumber4767_5997())
			{
				this._item4764 = recoveredType._itemArray4768[(recoveredType._number4770 + this._number4766) % recoveredType._number4769];
				this._number4763 = 1;
				return true;
			}
			return false;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00005E40 File Offset: 0x00004040
		bool IEnumerator.MoveNext()
		{
			return this.MoveNext();
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00005E48 File Offset: 0x00004048
		[DebuggerHidden]
		private TItem GetItem4764_5994()
		{
			return this._item4764;
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x00005E50 File Offset: 0x00004050
		TItem IEnumerator<!0>.Current
		{
			get
			{
				return this.GetItem4764_5994();
			}
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00005BE8 File Offset: 0x00003DE8
		[DebuggerHidden]
		private void Method5995()
		{
			throw new NotSupportedException();
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00005E58 File Offset: 0x00004058
		void IEnumerator.Reset()
		{
			this.Method5995();
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00005E60 File Offset: 0x00004060
		[DebuggerHidden]
		private object GetItem4764_5996()
		{
			return this._item4764;
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x00005E6D File Offset: 0x0000406D
		object IEnumerator.Current
		{
			get
			{
				return this.GetItem4764_5996();
			}
		}

		// Token: 0x04000064 RID: 100
		private int _number4763;

		// Token: 0x04000065 RID: 101
		private TItem _item4764;

		// Token: 0x04000066 RID: 102
		public 520<TItem> _recoveredType10814765;

		// Token: 0x04000067 RID: 103
		private int _number4766;
	}
}
