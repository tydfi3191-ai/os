using System;

// Token: 0x02000C6F RID: 3183
public class 1051 : ICloneable
{
	// Token: 0x060054F4 RID: 21748 RVA: 0x00210E14 File Offset: 0x0020F014
	internal 1051(208 1, 208 2)
	{
		this.1 = 1;
		this.2 = 2;
	}

	// Token: 0x060054F5 RID: 21749 RVA: 0x00210E2C File Offset: 0x0020F02C
	internal float 1()
	{
		return (this.2 - this.1).Length();
	}

	// Token: 0x060054F6 RID: 21750 RVA: 0x00210E52 File Offset: 0x0020F052
	internal float 2()
	{
		return (float)Math.Atan2((double)(this.2.Y - this.1.Y), (double)(this.2.X - this.1.X));
	}

	// Token: 0x060054F7 RID: 21751 RVA: 0x00210E8A File Offset: 0x0020F08A
	internal float 3(208 1)
	{
		return 208.DistanceSquared(1, this.5(1));
	}

	// Token: 0x060054F8 RID: 21752 RVA: 0x00210E99 File Offset: 0x0020F099
	internal float 4(208 1)
	{
		return 208.Distance(1, this.5(1));
	}

	// Token: 0x060054F9 RID: 21753 RVA: 0x00210EA8 File Offset: 0x0020F0A8
	internal 208 5(208 1)
	{
		208 2 = this.2 - this.1;
		float num = 208.Dot(1 - this.1, 2);
		if (num <= 0f)
		{
			return this.1;
		}
		float num2 = 208.Dot(2, 2);
		if (num2 <= num)
		{
			return this.2;
		}
		float num3 = num / num2;
		return this.1 + num3 * 2;
	}

	// Token: 0x060054FA RID: 21754 RVA: 0x00210F14 File Offset: 0x0020F114
	internal 202 6()
	{
		202 <<EMPTY_NAME>> = 202.CreateRotationZ(this.2());
		202 2 = 202.CreateTranslation(this.1.X, this.1.Y, 0f);
		return <<EMPTY_NAME>> * 2;
	}

	// Token: 0x060054FB RID: 21755 RVA: 0x00210F53 File Offset: 0x0020F153
	internal 202 7()
	{
		return 202.CreateRotationZ(this.2()) * 202.CreateTranslation(this.2.X, this.2.Y, 0f);
	}

	// Token: 0x060054FC RID: 21756 RVA: 0x0013A7E0 File Offset: 0x001389E0
	public object Clone()
	{
		return base.MemberwiseClone();
	}

	// Token: 0x0400432F RID: 17199
	internal 208 1;

	// Token: 0x04004330 RID: 17200
	internal 208 2;

	// Token: 0x04004331 RID: 17201
	internal bool 3;

	// Token: 0x04004332 RID: 17202
	internal bool 4;
}
