using System;
using System.IO;

// Token: 0x02000464 RID: 1124
public sealed class 2655 : 2647
{
	// Token: 0x0600226F RID: 8815 RVA: 0x0009531C File Offset: 0x0009351C
	internal 2655(1433 1, string 2, int 3, int 4)
	{
		this.7 = 1;
		this.16 = 0;
		this.16 = 3;
		this.15 = 4;
		this.10 = 2635.Sprite;
		this.3 = 2672.17(2).Replace(1272.5().44() + Path.DirectorySeparatorChar.ToString(), string.Empty);
	}

	// Token: 0x06002270 RID: 8816 RVA: 0x00095385 File Offset: 0x00093585
	internal 2655(string 1, 208 2, 1065 3, 2645 4) : this(1, 2, 3, 4, false)
	{
	}

	// Token: 0x06002271 RID: 8817 RVA: 0x00095394 File Offset: 0x00093594
	internal 2655(string 1, 208 2, 1065 3, 2645 4, bool 5)
	{
		this.12 = 2;
		this.13 = 3;
		this.14 = 5;
		this.5 = 4;
		this.10 = 2635.Sprite;
		this.17 = 2648.24(this.5);
		this.3 = 2672.17(1).Replace(1272.5().44() + Path.DirectorySeparatorChar.ToString(), string.Empty);
		1455.16(this.3);
		this.7 = new 1433(null, (1376)3, 3, (1044)1, 2, this.17, false, 198.White, null);
		this.7.41(new EventHandler(this.4));
	}

	// Token: 0x06002272 RID: 8818 RVA: 0x0009544E File Offset: 0x0009364E
	internal new void 4(object 1, EventArgs 2)
	{
		if (!(bool)1)
		{
			1455.17(this.3);
		}
	}

	// Token: 0x06002273 RID: 8819 RVA: 0x00095464 File Offset: 0x00093664
	internal override bool LoadTextures()
	{
		if (this.6)
		{
			return false;
		}
		this.6 = true;
		if (this.14)
		{
			this.7.SetTexture(1455.2(this.3, (1416)7, null) ?? 1455.2(this.3, (1416)4, null));
		}
		else
		{
			this.7.SetTexture(1455.2(this.3, (1416)4, null));
		}
		return true;
	}

	// Token: 0x06002274 RID: 8820 RVA: 0x00053ADC File Offset: 0x00051CDC
	internal override void SetStartTime(int 1)
	{
		throw new NotImplementedException();
	}

	// Token: 0x06002275 RID: 8821 RVA: 0x00053ADC File Offset: 0x00051CDC
	internal override void SetEndTime(int 1)
	{
		throw new NotImplementedException();
	}

	// Token: 0x06002276 RID: 8822 RVA: 0x000954D0 File Offset: 0x000936D0
	internal override 2647 Clone()
	{
		return new 2655(this.7.Clone(), this.3, this.8, this.1)
		{
			11 = this.11,
			10 = this.10,
			5 = this.5,
			9 = this.9,
			2 = this.2
		};
	}

	// Token: 0x040017DC RID: 6108
	private readonly 208 12;

	// Token: 0x040017DD RID: 6109
	private readonly 1065 13;

	// Token: 0x040017DE RID: 6110
	private readonly bool 14;

	// Token: 0x040017DF RID: 6111
	private int 15;

	// Token: 0x040017E0 RID: 6112
	private int 16;

	// Token: 0x040017E1 RID: 6113
	private float 17;
}
