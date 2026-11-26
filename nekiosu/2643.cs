using System;

// Token: 0x02000456 RID: 1110
public sealed class 2643 : 2656
{
	// Token: 0x0600220F RID: 8719 RVA: 0x000927DC File Offset: 0x000909DC
	public 2643(string 1)
	{
		if (1.Length > 0)
		{
			throw new ArgumentException("Invalid trigger description: " + 1);
		}
	}

	// Token: 0x06002210 RID: 8720 RVA: 0x0001905A File Offset: 0x0001725A
	internal override 2659 GetDefaultGroup()
	{
		return 2659.Passing;
	}

	// Token: 0x06002211 RID: 8721 RVA: 0x00092C08 File Offset: 0x00090E08
	internal override void Attach(2647 1, 2657 2, 1433 3)
	{
		2648.34(new 1189(new 2643.2644
		{
			1 = this,
			2 = 1,
			3 = 2,
			4 = 3
		}.1));
	}

	// Token: 0x02000457 RID: 1111
	public sealed class 2644
	{
		// Token: 0x06002212 RID: 8722 RVA: 0x00092C3B File Offset: 0x00090E3B
		internal void 1()
		{
			this.1.3(this.2, this.3, this.4, true);
		}

		// Token: 0x04001778 RID: 6008
		public 2643 1;

		// Token: 0x04001779 RID: 6009
		public 2647 2;

		// Token: 0x0400177A RID: 6010
		public 2657 3;

		// Token: 0x0400177B RID: 6011
		public 1433 4;
	}
}
