using System;

// Token: 0x0200044F RID: 1103
public sealed class 2636 : 2656
{
	// Token: 0x060021FB RID: 8699 RVA: 0x000927DC File Offset: 0x000909DC
	public 2636(string 1)
	{
		if (1.Length > 0)
		{
			throw new ArgumentException("Invalid trigger description: " + 1);
		}
	}

	// Token: 0x060021FC RID: 8700 RVA: 0x000193B1 File Offset: 0x000175B1
	internal override 2659 GetDefaultGroup()
	{
		return 2659.Failing;
	}

	// Token: 0x060021FD RID: 8701 RVA: 0x000927FE File Offset: 0x000909FE
	internal override void Attach(2647 1, 2657 2, 1433 3)
	{
		2648.36(new 1189(new 2636.2637
		{
			1 = this,
			2 = 1,
			3 = 2,
			4 = 3
		}.1));
	}

	// Token: 0x02000450 RID: 1104
	public sealed class 2637
	{
		// Token: 0x060021FE RID: 8702 RVA: 0x00092831 File Offset: 0x00090A31
		internal void 1()
		{
			this.1.3(this.2, this.3, this.4, true);
		}

		// Token: 0x04001765 RID: 5989
		public 2636 1;

		// Token: 0x04001766 RID: 5990
		public 2647 2;

		// Token: 0x04001767 RID: 5991
		public 2657 3;

		// Token: 0x04001768 RID: 5992
		public 1433 4;
	}
}
