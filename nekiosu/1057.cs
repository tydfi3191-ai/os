using System;

// Token: 0x02000C5E RID: 3166
public sealed class 1057
{
	// Token: 0x060054C1 RID: 21697 RVA: 0x0020FCE2 File Offset: 0x0020DEE2
	internal 1057()
	{
		this.1 = false;
	}

	// Token: 0x060054C2 RID: 21698 RVA: 0x0020FCF4 File Offset: 0x0020DEF4
	internal 1057(params 208[] 1) : this()
	{
		foreach (208 2 in 1)
		{
			this.3(2);
		}
	}

	// Token: 0x060054C3 RID: 21699 RVA: 0x0020FD26 File Offset: 0x0020DF26
	internal void Reset()
	{
		this.1 = false;
	}

	// Token: 0x060054C4 RID: 21700 RVA: 0x0020FD30 File Offset: 0x0020DF30
	internal float? 1()
	{
		if (!this.1)
		{
			return null;
		}
		return new float?(this.3 - this.2);
	}

	// Token: 0x060054C5 RID: 21701 RVA: 0x0020FD64 File Offset: 0x0020DF64
	internal float? 2()
	{
		if (!this.1)
		{
			return null;
		}
		return new float?(this.5 - this.4);
	}

	// Token: 0x060054C6 RID: 21702 RVA: 0x0020FD98 File Offset: 0x0020DF98
	internal void 3(208 1)
	{
		if (this.1)
		{
			this.2 = Math.Min(this.2, 1.X);
			this.3 = Math.Max(this.3, 1.X);
			this.4 = Math.Min(this.4, 1.Y);
			this.5 = Math.Max(this.5, 1.Y);
			return;
		}
		this.2 = 1.X;
		this.3 = 1.X;
		this.4 = 1.Y;
		this.5 = 1.Y;
		this.1 = true;
	}

	// Token: 0x040042FA RID: 17146
	private bool 1;

	// Token: 0x040042FB RID: 17147
	private float 2;

	// Token: 0x040042FC RID: 17148
	private float 3;

	// Token: 0x040042FD RID: 17149
	private float 4;

	// Token: 0x040042FE RID: 17150
	private float 5;
}
