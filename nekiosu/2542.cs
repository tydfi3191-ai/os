using System;
using System.Globalization;

// Token: 0x02000550 RID: 1360
[276]
public class 2542 : 1350
{
	// Token: 0x17000270 RID: 624
	// (get) Token: 0x060029BE RID: 10686 RVA: 0x000D9186 File Offset: 0x000D7386
	internal 1436 Layer
	{
		get
		{
			return this.4;
		}
	}

	// Token: 0x060029BF RID: 10687 RVA: 0x000D9190 File Offset: 0x000D7390
	internal 2542(1803 1, 2039 2) : base(1)
	{
		this.3 = 2;
		this.4 = new 1436(true);
		this.4.5 = 0f;
		this.BuildLayout();
	}

	// Token: 0x060029C0 RID: 10688 RVA: 0x000D920F File Offset: 0x000D740F
	protected virtual float GetMeterScale()
	{
		return (float)1304.195.GetValue();
	}

	// Token: 0x060029C1 RID: 10689 RVA: 0x000D921C File Offset: 0x000D741C
	internal void 1()
	{
		this.4.Dispose();
	}

	// Token: 0x060029C2 RID: 10690 RVA: 0x000D9229 File Offset: 0x000D7429
	internal void 2()
	{
		this.4.15(true);
		this.BuildLayout();
		if (2513.IsOpen)
		{
			this.6 = 1226.16 + 4000;
			this.6();
		}
	}

	// Token: 0x060029C3 RID: 10691 RVA: 0x000D925B File Offset: 0x000D745B
	protected string 3(string 1, string 2)
	{
		2528 3 = this.5;
		if (((3 != null) ? 3.9(1) : null) == null)
		{
			return 2;
		}
		return this.5.10(1);
	}

	// Token: 0x060029C4 RID: 10692 RVA: 0x000D9280 File Offset: 0x000D7480
	protected float 4(string 1, float 2)
	{
		float result;
		if (!float.TryParse(this.3(1, null), NumberStyles.Float, CultureInfo.InvariantCulture, out result))
		{
			return 2;
		}
		return result;
	}

	// Token: 0x060029C5 RID: 10693 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal virtual void BuildLayout()
	{
	}

	// Token: 0x060029C6 RID: 10694 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal virtual void OnJudged(2149 1)
	{
	}

	// Token: 0x060029C7 RID: 10695 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal virtual void OnHitOffset(2034 1, int? 2)
	{
	}

	// Token: 0x060029C8 RID: 10696 RVA: 0x000D92AB File Offset: 0x000D74AB
	internal void 5()
	{
		this.4.22();
	}

	// Token: 0x060029C9 RID: 10697 RVA: 0x000D92B9 File Offset: 0x000D74B9
	protected void 6()
	{
		this.4.7 = 0f;
		this.4.5 = 1f;
	}

	// Token: 0x060029CA RID: 10698 RVA: 0x000D92DC File Offset: 0x000D74DC
	public override void Update()
	{
		if ((2486.9 || 1226.16 > this.6 || (2486.7.80 != (707)2 && 2486.7.80 != (707)3)) && this.4.5 > 0f)
		{
			this.4.7 = (float)Math.Max(0.0, (double)(1f - 4f * this.4.5) - 0.03999999910593033 * 1662.10);
			this.4.5 = (float)Math.Max(0.0, (double)this.4.5 - 0.03999999910593033 * 1662.10);
		}
	}

	// Token: 0x04001E5C RID: 7772
	protected 2039 3;

	// Token: 0x04001E5D RID: 7773
	protected 1436 4;

	// Token: 0x04001E5E RID: 7774
	internal 2528 5;

	// Token: 0x04001E5F RID: 7775
	protected int 6;

	// Token: 0x04001E60 RID: 7776
	protected 198 7 = new 198(50, 188, 231);

	// Token: 0x04001E61 RID: 7777
	protected 198 8 = new 198(87, 227, 19);

	// Token: 0x04001E62 RID: 7778
	protected 198 9 = new 198(218, 174, 70);
}
