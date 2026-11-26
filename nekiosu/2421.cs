using System;
using System.Collections.Generic;

// Token: 0x0200061D RID: 1565
public abstract class 2421 : 2448
{
	// Token: 0x06002F93 RID: 12179 RVA: 0x0010D0F0 File Offset: 0x0010B2F0
	internal 2421(2445 1, 2450 2) : base(1, 2)
	{
		this.13 = new List<1445>();
		this.14 = new List<2445.2446>();
		this.15 = new List<2445.2446>();
	}

	// Token: 0x06002F94 RID: 12180 RVA: 0x0010D11B File Offset: 0x0010B31B
	internal override void RecordObjects(object 1, 2450 2)
	{
		if (1 is 1445)
		{
			this.15((1445)1);
			return;
		}
		if (1 is 2445.2446)
		{
			this.16((2445.2446)1);
			return;
		}
		base.RecordObjects(1, 2);
	}

	// Token: 0x06002F95 RID: 12181 RVA: 0x0010D14F File Offset: 0x0010B34F
	private void 15(1445 1)
	{
		if (!this.13.Contains(1))
		{
			base.6(true);
			this.13.Add(1);
			this.CaptureBackup();
			this.12 = 0;
		}
	}

	// Token: 0x06002F96 RID: 12182 RVA: 0x0010D180 File Offset: 0x0010B380
	private void 16(2445.2446 1)
	{
		if (1 == null)
		{
			return;
		}
		2451 2 = base.1();
		if (2 != (2451)30)
		{
			if (2 != (2451)31)
			{
				throw new NotImplementedException();
			}
			if (!this.15.Contains(1))
			{
				base.6(true);
				this.15.Add(1);
				this.CaptureBackup();
				this.12 = 0;
				return;
			}
		}
		else if (!this.14.Contains(1))
		{
			base.6(true);
			this.14.Add(1);
			this.CaptureBackup();
			this.12 = 0;
			return;
		}
	}

	// Token: 0x06002F97 RID: 12183 RVA: 0x0010D20A File Offset: 0x0010B40A
	protected void 17()
	{
		this.16 = new List<int>();
		this.17 = new List<int>();
	}

	// Token: 0x06002F98 RID: 12184 RVA: 0x0010D222 File Offset: 0x0010B422
	internal void 18(2647 1)
	{
		if (1662.78 == 1677.Edit)
		{
			this.4.1.75.48 = 1;
			this.4.1.75.28(1, false);
		}
	}

	// Token: 0x06002F99 RID: 12185 RVA: 0x0010D25C File Offset: 0x0010B45C
	protected void 19()
	{
		2263 <<EMPTY_NAME>> = this.4.1;
		if (base.13((2450)131072) && <<EMPTY_NAME>>.26 == 2335.Design)
		{
			2647 2 = <<EMPTY_NAME>>.75.48;
			if (2 != null && this.7.Contains(2))
			{
				<<EMPTY_NAME>>.31();
			}
			<<EMPTY_NAME>>.75.8.44 = true;
		}
	}

	// Token: 0x04002253 RID: 8787
	internal new List<1445> 13;

	// Token: 0x04002254 RID: 8788
	internal List<2445.2446> 14;

	// Token: 0x04002255 RID: 8789
	internal List<2445.2446> 15;

	// Token: 0x04002256 RID: 8790
	protected List<int> 16;

	// Token: 0x04002257 RID: 8791
	protected List<int> 17;
}
