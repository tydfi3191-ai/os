using System;

// Token: 0x020008CC RID: 2252
public sealed class 1793 : 1779
{
	// Token: 0x06004091 RID: 16529 RVA: 0x00191337 File Offset: 0x0018F537
	public 1793(2679 1, 1319 2, string 3 = null, bool 4 = true, float 5 = 0f) : this(1568.1(1), 1.ToString(), 2, 3, 4, 5)
	{
	}

	// Token: 0x06004092 RID: 16530 RVA: 0x00191358 File Offset: 0x0018F558
	public 1793(string 1, 1319 2, string 3 = null, bool 4 = true, float 5 = 0f) : this(1, null, 2, 3, 4, 5)
	{
	}

	// Token: 0x06004093 RID: 16531 RVA: 0x00191368 File Offset: 0x0018F568
	internal static float 18(params string[] 1)
	{
		float num = 0f;
		for (int i = 0; i < 1.Length; i++)
		{
			using (1452 2 = new 1452(1[i], 12f, 208.Zero, 1f, true, 198.White))
			{
				num = Math.Max(num, 2.GetTextSize().X);
			}
		}
		return num;
	}

	// Token: 0x06004094 RID: 16532 RVA: 0x001913D8 File Offset: 0x0018F5D8
	private 1793(string 1, string 2, 1319 3, string 4, bool 5, float 6)
	{
		this.15 = 3;
		this.16 = 3.GetValue();
		this.17 = 4;
		this.18 = 5;
		3.SubscribeChanged(new EventHandler(this.21));
		this.14 = new 1452(1, 12f, 208.Zero, 1f, true, 198.White);
		this.1.12(this.14);
		208 textSize = this.14.GetTextSize();
		base.3(new 208(Math.Max(textSize.X, 6), textSize.Y));
		this.13 = new 1429(this.1, 3.1(), 3.3(), 3.GetValue(), new 208(base.2().X + 5f, base.2().Y / 2f), (int)(244f - base.2().X - 5f));
		1429 7 = this.13;
		7.18 = (1429.1432)Delegate.Combine(7.18, new 1429.1432(this.23));
		this.13.10 = true;
		this.13.11 = ((3 is 1318) ? 1.0 : 0.01);
		base.10(1);
		if (2 != null)
		{
			base.10(2);
		}
		this.22();
	}

	// Token: 0x06004095 RID: 16533 RVA: 0x00191556 File Offset: 0x0018F756
	internal override bool IsDefaultValue()
	{
		1319 <<EMPTY_NAME>> = this.15;
		return <<EMPTY_NAME>> == null || <<EMPTY_NAME>>.5();
	}

	// Token: 0x06004096 RID: 16534 RVA: 0x00191569 File Offset: 0x0018F769
	internal string 19()
	{
		return this.17;
	}

	// Token: 0x06004097 RID: 16535 RVA: 0x00191571 File Offset: 0x0018F771
	internal void 20(string 1)
	{
		if (!(1 == this.17))
		{
			this.17 = 1;
			this.22();
		}
	}

	// Token: 0x06004098 RID: 16536 RVA: 0x0019158E File Offset: 0x0018F78E
	private void 21(object 1, EventArgs 2)
	{
		this.16 = this.15.GetValue();
		this.13.23(this.15.GetValue(), false, false);
		base.1();
	}

	// Token: 0x06004099 RID: 16537 RVA: 0x001915BF File Offset: 0x0018F7BF
	protected override void ResetToDefault()
	{
		this.15.SetValue(this.15.4);
		base.ResetToDefault();
	}

	// Token: 0x0600409A RID: 16538 RVA: 0x001915E0 File Offset: 0x0018F7E0
	private void 22()
	{
		if (!string.IsNullOrEmpty(this.19()))
		{
			if (this.18)
			{
				1429 <<EMPTY_NAME>> = this.13;
				1319 2 = this.15;
				<<EMPTY_NAME>>.8(((2 != null) ? 2.ToString() : null) + this.19());
				return;
			}
			this.13.8(((this.15 is 1318) ? this.16.ToString("0", 1662.18) : this.16.ToString("0.##", 1662.18)) + this.19());
		}
	}

	// Token: 0x0600409B RID: 16539 RVA: 0x0019167D File Offset: 0x0018F87D
	private void 23(bool 1)
	{
		this.16 = this.13.7;
		if (this.18 || 1)
		{
			this.15.SetValue(this.16);
		}
		this.22();
	}

	// Token: 0x0600409C RID: 16540 RVA: 0x001916B1 File Offset: 0x0018F8B1
	public override void Dispose()
	{
		base.Dispose();
		this.13.Dispose();
		this.15.UnsubscribeChanged(new EventHandler(this.21));
	}

	// Token: 0x04002F38 RID: 12088
	internal new 1429 13;

	// Token: 0x04002F39 RID: 12089
	private new 1452 14;

	// Token: 0x04002F3A RID: 12090
	private new 1319 15;

	// Token: 0x04002F3B RID: 12091
	private double 16;

	// Token: 0x04002F3C RID: 12092
	private string 17;

	// Token: 0x04002F3D RID: 12093
	private bool 18;

	// Token: 0x04002F3E RID: 12094
	private bool 19 = true;
}
