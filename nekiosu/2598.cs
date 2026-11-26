using System;
using System.Collections.Generic;

// Token: 0x0200049C RID: 1180
public sealed class 2598 : 2593
{
	// Token: 0x060023E9 RID: 9193 RVA: 0x0009E13C File Offset: 0x0009C33C
	public 2598(string 1) : base(null, null, null)
	{
		this.49 = 1;
		this.50 = 1;
		this.48 = new List<2593>();
		base.28((2597)1);
		base.7(2593.3);
		this.47 = 2593.3;
	}

	// Token: 0x060023EA RID: 9194 RVA: 0x0009E19B File Offset: 0x0009C39B
	internal override string GetDisplayTitle()
	{
		return this.49;
	}

	// Token: 0x060023EB RID: 9195 RVA: 0x0009E1A3 File Offset: 0x0009C3A3
	internal bool 35()
	{
		return this.48.Exists(new Predicate<2593>(2598.2600.Instance.1));
	}

	// Token: 0x060023EC RID: 9196 RVA: 0x0009E1C0 File Offset: 0x0009C3C0
	internal new int 36()
	{
		if (this.48 == null || this.48.Count == 0)
		{
			return 0;
		}
		int num = 0;
		for (int i = 0; i < this.48.Count; i++)
		{
			if (2598.2600.Instance.2(this.48[i]))
			{
				num++;
			}
		}
		this.50 = string.Concat(new string[]
		{
			this.49,
			" (",
			num.ToString(),
			" map",
			(num != 1) ? "s" : string.Empty,
			")"
		});
		if (this.16)
		{
			this.31.SetText(this.50);
		}
		return num;
	}

	// Token: 0x060023ED RID: 9197 RVA: 0x0009E284 File Offset: 0x0009C484
	internal void 37(bool 1)
	{
		if (!this.16)
		{
			return;
		}
		if (this.46 >= (2597)3)
		{
			this.31.6 = 2593.11;
			base.7(2593.2);
		}
		else
		{
			this.31.6 = 2593.12;
			if (this.35())
			{
				base.7(2593.4);
			}
			else
			{
				base.7(2593.3);
			}
		}
		base.31(base.6(), (!1) ? 300 : 0);
	}

	// Token: 0x060023EE RID: 9198 RVA: 0x0009E308 File Offset: 0x0009C508
	internal override void ApplyStateChange(2597 1, bool 2)
	{
		2598.2599 3 = new 2598.2599();
		3.1 = 2;
		if (this.46 <= (2597)0)
		{
			if (this.30.16 != 0f)
			{
				this.29.ForEach(new Action<1371>(3.1));
			}
			return;
		}
		if (1 <= (2597)0)
		{
			for (int i = 0; i < this.29.Count; i++)
			{
				this.29[i].FadeIn((!3.1) ? 200 : 0, (1046)0, 0);
			}
		}
		this.37(3.1);
	}

	// Token: 0x060023EF RID: 9199 RVA: 0x0009E3A0 File Offset: 0x0009C5A0
	protected override void CreateSprites()
	{
		if (this.29 == null)
		{
			this.29 = new List<1371>();
		}
		this.30 = new 1433(2593.38, (1376)6, 1065.CentreLeft, (1044)0, new 208((float)this.44.X, (float)this.44.Y), this.43, true, this.47, this);
		this.30.10 = true;
		this.29.Add(this.30);
		this.31 = new 1452(this.50, 24f, 208.Zero, 208.Zero, this.43 + 1E-06f, true, 2593.12, false);
		this.31.49 = 1065.CentreLeft;
		this.31.8 = new 208(15f, 0f);
		this.36.Add(this.31);
		this.29.Add(this.31);
		this.36();
	}

	// Token: 0x060023F0 RID: 9200 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal override void OnStateChanged(2597 1)
	{
	}

	// Token: 0x04001904 RID: 6404
	internal List<2593> 48 = new List<2593>();

	// Token: 0x04001905 RID: 6405
	private string 49;

	// Token: 0x04001906 RID: 6406
	private string 50;

	// Token: 0x0200049D RID: 1181
	[Serializable]
	public sealed class 2600
	{
		// Token: 0x060023F1 RID: 9201 RVA: 0x0009E4A2 File Offset: 0x0009C6A2
		internal bool 1(2593 1)
		{
			return !1.23 && 1.14 == 1272.5();
		}

		// Token: 0x060023F2 RID: 9202 RVA: 0x0009E4BB File Offset: 0x0009C6BB
		internal bool 2(2593 1)
		{
			return !1.23;
		}

		// Token: 0x04001907 RID: 6407
		public static readonly 2598.2600 Instance = new 2598.2600();

		// Token: 0x04001908 RID: 6408
		public static Predicate<2593> predicate;

		// Token: 0x04001909 RID: 6409
		public static Predicate<2593> predicate2;
	}

	// Token: 0x0200049E RID: 1182
	public sealed class 2599
	{
		// Token: 0x060023F5 RID: 9205 RVA: 0x0009E4D2 File Offset: 0x0009C6D2
		internal void 1(1371 1)
		{
			1.16((!this.1) ? 200 : 0, (1046)0, 0);
		}

		// Token: 0x0400190A RID: 6410
		public bool 1;
	}
}
