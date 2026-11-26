using System;
using System.Collections.Generic;
using System.Threading;

// Token: 0x02000A7F RID: 2687
public sealed class 1364
{
	// Token: 0x06004A61 RID: 19041 RVA: 0x001D80E0 File Offset: 0x001D62E0
	internal 1364(string 1, 208 2, float 3, bool 4) : this(1, 1f, 2, 3, 4, 0f)
	{
	}

	// Token: 0x06004A62 RID: 19042 RVA: 0x001D80F8 File Offset: 0x001D62F8
	internal 1364(string 1, float 2, 208 3, float 4, bool 5, float 6 = 0f)
	{
		this.8 = 3;
		this.1 = 5;
		this.9 = 8;
		this.3 = 1455.2("circle-full", (1416)1, null);
		this.4 = 1455.2("circle-empty", (1416)1, null);
		this.6 = new 1433(this.1 ? this.3 : this.4, (1376)6, 1065.Centre, (1044)0, 3 + new 208(8f, 8f), 4, true, 2630.14, null);
		this.6.10 = true;
		this.6.15 = 8;
		this.6.3(delegate(object 1, EventArgs 2)
		{
			this.5(!this.4());
			1226.24("check-" + (this.4() ? "on" : "off"), 100, (1416)3, false);
		});
		this.6.11 = true;
		this.5 = new 1452(7, 15f * 8, 3 + new 208(20f * 8, 8f), new 208(Math.Max(0f, 6 - 20f * 8), 0f), 4, true, 198.White, true);
		this.5.49 = 1065.CentreLeft;
		this.5.11 = true;
		this.5.10 = true;
		this.5.3(delegate(object 1, EventArgs 2)
		{
			this.5(!this.4());
			1226.24("check-" + (this.4() ? "on" : "off"), 100, (1416)3, false);
		});
		this.2.Add(this.6);
		this.2.Add(this.5);
	}

	// Token: 0x06004A63 RID: 19043 RVA: 0x001D8282 File Offset: 0x001D6482
	internal bool 1()
	{
		return this.7;
	}

	// Token: 0x06004A64 RID: 19044 RVA: 0x001D828C File Offset: 0x001D648C
	internal void 2(bool 1)
	{
		if (this.7 == 1)
		{
			return;
		}
		this.7 = 1;
		if (this.7)
		{
			foreach (1433 2 in this.2)
			{
				2.6 = 198.White;
				2.10 = true;
			}
			this.6.6 = 2630.14;
			return;
		}
		foreach (1433 3 in this.2)
		{
			3.6 = 198.Gray;
			3.10 = false;
		}
	}

	// Token: 0x06004A65 RID: 19045 RVA: 0x001D8360 File Offset: 0x001D6560
	internal void 3(string 1)
	{
		this.5.SetText(1);
	}

	// Token: 0x06004A66 RID: 19046 RVA: 0x001D836E File Offset: 0x001D656E
	internal bool 4()
	{
		return this.1;
	}

	// Token: 0x06004A67 RID: 19047 RVA: 0x001D8376 File Offset: 0x001D6576
	internal void 5(bool 1)
	{
		if (this.1 != 1)
		{
			this.1 = 1;
			this.8();
			if (this.10 != null)
			{
				this.10(this, this.4());
			}
		}
	}

	// Token: 0x06004A68 RID: 19048 RVA: 0x001D83A8 File Offset: 0x001D65A8
	public void 6(string 1)
	{
		this.5.52 = 1;
		this.6.52 = 1;
	}

	// Token: 0x06004A69 RID: 19049 RVA: 0x001D83C2 File Offset: 0x001D65C2
	private void OnClick(object 1, EventArgs 2)
	{
		this.5(!this.4());
		1226.24("check-" + (this.4() ? "on" : "off"), 100, (1416)3, false);
	}

	// Token: 0x06004A6A RID: 19050 RVA: 0x001D83FB File Offset: 0x001D65FB
	internal void 7(bool 1)
	{
		if (this.1 != 1)
		{
			this.1 = 1;
			this.8();
		}
	}

	// Token: 0x06004A6B RID: 19051 RVA: 0x001D8414 File Offset: 0x001D6614
	private void 8()
	{
		this.6.SetTexture(this.4() ? this.3 : this.4);
		this.6.3.RemoveAll(new Predicate<1445>(1364.1365.instance.1));
		if (this.4())
		{
			this.6.3.Add(new 1445(1456.Scale, this.9 * 1.2f, this.9, 1662.33, 1662.33 + 350, (1046)1));
			return;
		}
		this.6.3.Add(new 1445(1456.Scale, this.9 * 0.8f, this.9, 1662.33, 1662.33 + 350, (1046)1));
	}

	// Token: 0x06004A6C RID: 19052 RVA: 0x001D84E0 File Offset: 0x001D66E0
	internal void 9(1183 1)
	{
		1183 2 = this.10;
		1183 3;
		do
		{
			3 = 2;
			1183 value = (1183)Delegate.Combine(3, 1);
			2 = Interlocked.CompareExchange<1183>(ref this.10, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x06004A6D RID: 19053 RVA: 0x001D8515 File Offset: 0x001D6715
	public void Hide()
	{
		this.Hide(false);
	}

	// Token: 0x06004A6E RID: 19054 RVA: 0x001D8520 File Offset: 0x001D6720
	public void Hide(bool 1)
	{
		1364.1366 hideClosure = new 1364.1366();
		hideClosure.1 = 2;
		this.2.ForEach(delegate(1433 1)
		{
			1.16((!hideClosure.1) ? 20 : 0, (1046)0, 0);
		});
	}

	// Token: 0x06004A6F RID: 19055 RVA: 0x001D8561 File Offset: 0x001D6761
	public void Show()
	{
		this.2.ForEach(new Action<1433>(1364.1365.instance.2));
	}

	// Token: 0x0400376D RID: 14189
	private bool 1;

	// Token: 0x0400376E RID: 14190
	internal List<1433> 2 = new List<1433>();

	// Token: 0x0400376F RID: 14191
	private 1381 3;

	// Token: 0x04003770 RID: 14192
	private 1381 4;

	// Token: 0x04003771 RID: 14193
	internal 1452 5;

	// Token: 0x04003772 RID: 14194
	internal 1433 6;

	// Token: 0x04003773 RID: 14195
	private bool 7 = true;

	// Token: 0x04003774 RID: 14196
	private 208 8;

	// Token: 0x04003775 RID: 14197
	private float 9;

	// Token: 0x04003776 RID: 14198
	private 1183 10;

	// Token: 0x02000A80 RID: 2688
	[Serializable]
	public sealed class 1365
	{
		// Token: 0x06004A72 RID: 19058 RVA: 0x000AAB47 File Offset: 0x000A8D47
		internal bool 1(1445 1)
		{
			return 1.14 == 1456.Scale;
		}

		// Token: 0x06004A73 RID: 19059 RVA: 0x001D857E File Offset: 0x001D677E
		internal void 2(1433 1)
		{
			1.FadeIn(20, (1046)0, 0);
		}

		// Token: 0x04003777 RID: 14199
		public static readonly 1364.1365 instance = new 1364.1365();

		// Token: 0x04003778 RID: 14200
		public static Predicate<1433> predicate;

		// Token: 0x04003779 RID: 14201
		public static Predicate<1445> predicate2;

		// Token: 0x0400377A RID: 14202
		public static Action<1433> action;
	}

	// Token: 0x02000A81 RID: 2689
	public sealed class 1366
	{
		// Token: 0x0400377B RID: 14203
		public bool 1;
	}
}
