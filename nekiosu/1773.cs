using System;
using System.Collections.Generic;

// Token: 0x020008B0 RID: 2224
public sealed class 1773<TItem> : 1779 where TItem : IComparable
{
	// Token: 0x06003FA5 RID: 16293 RVA: 0x0018A4A7 File Offset: 0x001886A7
	public 1773(2679 1, IEnumerable<1772> 2 = null, 1320<TItem> 3 = null, EventHandler 4 = null) : this(1568.1(1), 2, 3, 4)
	{
		base.10(1.ToString());
	}

	// Token: 0x06003FA6 RID: 16294 RVA: 0x0018A4CC File Offset: 0x001886CC
	public 1773(string 1, IEnumerable<1772> 2 = null, 1320<TItem> 3 = null, EventHandler 4 = null)
	{
		this.14 = 3;
		if (3 != null)
		{
			((1317)3).SubscribeChanged(delegate(object 1, EventArgs 2)
			{
				this.13.18(this.14.GetBoxedValue(), true);
				base.1();
			});
		}
		1452 5 = new 1452(7, 12f, 208.Zero, 1f, true, 198.White);
		this.1.12(5);
		base.3(5.GetTextSize() + new 208(5f, 0f));
		this.13 = new 1373(this.1, string.Empty, new 208(base.2().X, 0f), 244f - base.2().X, 1f)
		{
			5 = 10
		};
		this.13.1(new EventHandler(this.19));
		this.13.2(new EventHandler(this.18));
		this.13.10.11 = true;
		if (4 != null)
		{
			this.13.1(4);
		}
		if (8 != null)
		{
			foreach (1772 6 in 8)
			{
				this.13.9(6);
				base.10(6.1);
			}
		}
		if (3 != null)
		{
			this.13.18(3.GetBoxedValue(), true);
		}
		base.10(7);
	}

	// Token: 0x06003FA7 RID: 16295 RVA: 0x0018A64C File Offset: 0x0018884C
	internal override bool IsDefaultValue()
	{
		if (!this.15)
		{
			1320<TItem> <<EMPTY_NAME>> = this.14;
			return <<EMPTY_NAME>> == null || <<EMPTY_NAME>>.1();
		}
		return true;
	}

	// Token: 0x06003FA8 RID: 16296 RVA: 0x0018A669 File Offset: 0x00188869
	protected override void ResetToDefault()
	{
		this.14.SetValue(this.14.2);
		base.ResetToDefault();
		this.13.18(this.14.GetBoxedValue(), false);
	}

	// Token: 0x06003FA9 RID: 16297 RVA: 0x0018A69F File Offset: 0x0018889F
	private void 18(object 1, EventArgs 2)
	{
		base.5(this.13.3() ? ((float)this.13.8.Count * base.2().Y) : 0f);
	}

	// Token: 0x06003FAA RID: 16298 RVA: 0x0018A6D8 File Offset: 0x001888D8
	private void 19(object 1, EventArgs 2)
	{
		if (this.14 != null)
		{
			this.14.SetBoxedValue(this.13.18);
		}
		base.5(0f);
	}

	// Token: 0x06003FAB RID: 16299 RVA: 0x0018A703 File Offset: 0x00188903
	public override void Dispose()
	{
		base.Dispose();
		1373 <<EMPTY_NAME>> = this.13;
		if (<<EMPTY_NAME>> != null)
		{
			<<EMPTY_NAME>>.17();
		}
		1320<TItem> 3 = this.14;
		if (3 == null)
		{
			return;
		}
		((1317)3).UnsubscribeChanged(delegate(object 1, EventArgs 2)
		{
			this.13.18(this.14.GetBoxedValue(), true);
			base.1();
		});
	}

	// Token: 0x04002E8A RID: 11914
	internal new 1373 13;

	// Token: 0x04002E8B RID: 11915
	private new 1320<TItem> 14;

	// Token: 0x04002E8C RID: 11916
	internal new bool 15;
}
