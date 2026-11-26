using System;
using System.Collections.Generic;

// Token: 0x02000A68 RID: 2664
public sealed class 1561 : 1083, 1079
{
	// Token: 0x060049D7 RID: 18903 RVA: 0x001D431B File Offset: 0x001D251B
	internal override bool Initialize()
	{
		this.3 = 1555.16();
		return true;
	}

	// Token: 0x060049D8 RID: 18904 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal override void Dispose()
	{
	}

	// Token: 0x060049D9 RID: 18905 RVA: 0x001D432C File Offset: 0x001D252C
	internal override void Update(bool 1)
	{
		206 2 = 1555.16();
		if (!1)
		{
			this.1 = false;
			this.2.X = this.2.X + (float)(2.X - this.3.X);
			this.2.Y = this.2.Y + (float)(2.Y - this.3.Y);
			this.3 = 2;
			return;
		}
		this.3 = 2;
		if (!this.1)
		{
			if (1662.115 == 0L || !1555.25(2, 0))
			{
				this.2.X = (float)2.X;
				this.2.Y = (float)2.Y;
			}
			else
			{
				1555.15(new 206((int)Math.Round((double)this.2.X), (int)Math.Round((double)this.2.Y)), true);
				2 = 1555.16();
			}
		}
		this.1 = true;
		if (1304.139 != 1.0 && !1555.32 && !1304.191)
		{
			206 3 = new 206((int)Math.Round((double)this.2.X), (int)Math.Round((double)this.2.Y));
			if (1555.25(new 206(2.X, 2.Y), 0))
			{
				this.2.X = this.2.X + (float)(2.X - 3.X) * (float)1304.139;
				this.2.Y = this.2.Y + (float)(2.Y - 3.Y) * (float)1304.139;
				3 = new 206((int)Math.Round((double)this.2.X), (int)Math.Round((double)this.2.Y));
			}
			else
			{
				this.2.X = (float)2.X;
				this.2.Y = (float)2.Y;
				3 = new 206(2.X, 2.Y);
			}
			1555.15(3, false);
			2 = 1555.16();
			if (3.X != 2.X)
			{
				this.2.X = this.2.X + (float)(2.X - 3.X);
			}
			if (3.Y != 2.Y)
			{
				this.2.Y = this.2.Y + (float)(2.Y - 3.Y);
				return;
			}
		}
		else
		{
			this.2.X = (float)2.X;
			this.2.Y = (float)2.Y;
		}
	}

	// Token: 0x060049DA RID: 18906 RVA: 0x001D45CF File Offset: 0x001D27CF
	public void SetPosition(208 1)
	{
		this.2 = 1;
		this.1 = false;
	}

	// Token: 0x060049DB RID: 18907 RVA: 0x001D45DF File Offset: 0x001D27DF
	public 208 GetPosition()
	{
		return this.2;
	}

	// Token: 0x060049DC RID: 18908 RVA: 0x001D45E8 File Offset: 0x001D27E8
	public 199? GetLeftButton()
	{
		return null;
	}

	// Token: 0x060049DD RID: 18909 RVA: 0x001D4600 File Offset: 0x001D2800
	public 199? GetRightButton()
	{
		return null;
	}

	// Token: 0x060049DE RID: 18910 RVA: 0x001D4618 File Offset: 0x001D2818
	public 199? GetMiddleButton()
	{
		return null;
	}

	// Token: 0x060049DF RID: 18911 RVA: 0x001D4630 File Offset: 0x001D2830
	public 199? GetBackButton()
	{
		return null;
	}

	// Token: 0x060049E0 RID: 18912 RVA: 0x001D4648 File Offset: 0x001D2848
	public 199? GetForwardButton()
	{
		return null;
	}

	// Token: 0x060049E1 RID: 18913 RVA: 0x001D465E File Offset: 0x001D285E
	public List<208> GetPositionHistory()
	{
		return new List<208>();
	}

	// Token: 0x060049E2 RID: 18914 RVA: 0x0001702D File Offset: 0x0001522D
	internal override bool IsActive()
	{
		return true;
	}

	// Token: 0x060049E3 RID: 18915 RVA: 0x0000FF75 File Offset: 0x0000E175
	internal override int GetPriority()
	{
		return 0;
	}

	// Token: 0x040036FE RID: 14078
	private bool 1;

	// Token: 0x040036FF RID: 14079
	private 208 2 = 208.One;

	// Token: 0x04003700 RID: 14080
	private 206 3;
}
