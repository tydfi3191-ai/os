using System;

// Token: 0x02000451 RID: 1105
public sealed class 2638 : 2656
{
	// Token: 0x06002200 RID: 8704 RVA: 0x000927DC File Offset: 0x000909DC
	public 2638(string 1)
	{
		if (1.Length > 0)
		{
			throw new ArgumentException("Invalid trigger description: " + 1);
		}
	}

	// Token: 0x06002201 RID: 8705 RVA: 0x0000D019 File Offset: 0x0000B219
	internal override 2659 GetDefaultGroup()
	{
		return 2659.HitObjectHit;
	}

	// Token: 0x06002202 RID: 8706 RVA: 0x00092851 File Offset: 0x00090A51
	internal override void Attach(2647 1, 2657 2, 1433 3)
	{
		2648.30(new 2038(new 2638.2639
		{
			1 = this,
			2 = 1,
			3 = 2,
			4 = 3
		}.1));
	}

	// Token: 0x02000452 RID: 1106
	public sealed class 2639
	{
		// Token: 0x06002203 RID: 8707 RVA: 0x00092884 File Offset: 0x00090A84
		internal void 1(2034 1)
		{
			if (1.41 > 0)
			{
				this.1.3(this.2, this.3, this.4, false);
			}
		}

		// Token: 0x04001769 RID: 5993
		public 2638 1;

		// Token: 0x0400176A RID: 5994
		public 2647 2;

		// Token: 0x0400176B RID: 5995
		public 2657 3;

		// Token: 0x0400176C RID: 5996
		public 1433 4;
	}
}
