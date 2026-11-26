using System;
using OpenTK;

// Token: 0x02000A84 RID: 2692
public sealed class 1368 : 1371
{
	// Token: 0x06004A7C RID: 19068 RVA: 0x001D862C File Offset: 0x001D682C
	public 1368(bool 1 = true) : base(1)
	{
		this.39 = new 1411<1397>(1, 35044);
		this.27(198.White);
		this.28(new 198(54, 72, 78, byte.MaxValue));
		this.29(new 198(17, 136, 170, byte.MaxValue));
	}

	// Token: 0x06004A7D RID: 19069 RVA: 0x001D86B0 File Offset: 0x001D68B0
	internal new void 27(198 1)
	{
		if (!(1 == this.33))
		{
			this.33 = 1;
			this.32 = new Vector4((float)1.R, (float)1.G, (float)1.B, (float)1.A) / 255f;
		}
	}

	// Token: 0x06004A7E RID: 19070 RVA: 0x001D8704 File Offset: 0x001D6904
	internal void 28(198 1)
	{
		if (!(1 == this.35))
		{
			this.35 = 1;
			this.34 = new Vector4((float)1.R, (float)1.G, (float)1.B, (float)1.A) / 255f;
		}
	}

	// Token: 0x06004A7F RID: 19071 RVA: 0x001D8758 File Offset: 0x001D6958
	internal void 29(198 1)
	{
		if (!(1 == this.37))
		{
			this.37 = 1;
			this.36 = new Vector4((float)1.R, (float)1.G, (float)1.B, (float)1.A) / 255f;
		}
	}

	// Token: 0x06004A80 RID: 19072 RVA: 0x001D87AC File Offset: 0x001D69AC
	public override 1069 Update()
	{
		1069 <<EMPTY_NAME>> = base.Update();
		if (<<EMPTY_NAME>> != (1069)0)
		{
			return <<EMPTY_NAME>>;
		}
		if (this.16 <= 0f)
		{
			return (1069)1;
		}
		return base.Update();
	}

	// Token: 0x06004A81 RID: 19073 RVA: 0x001D87DC File Offset: 0x001D69DC
	public override bool Draw()
	{
		if (!base.Draw())
		{
			return false;
		}
		this.31 = (float)Math.Min(1.0, (double)this.31);
		float num = this.28 * this.15 * 1662.70.9();
		float num2 = this.30 * this.15 * 1662.70.9();
		float num3 = (float)Math.Min((double)num, Math.Max(0.0, (double)((this.28 - this.29) * this.15 * 1662.70.9())));
		208 <<EMPTY_NAME>> = this.17 * 1662.70.3();
		this.39.1[0].Position = <<EMPTY_NAME>> + new 208(0f - num - num2, 0f - num - num2);
		this.39.1[1].Position = <<EMPTY_NAME>> + new 208(0f - num - num2, num + num2);
		this.39.1[2].Position = <<EMPTY_NAME>> + new 208(num + num2, num + num2);
		this.39.1[3].Position = <<EMPTY_NAME>> + new 208(num + num2, 0f - num - num2);
		this.39.6();
		1368.38.1["m_CenterPos"] = new Vector2(<<EMPTY_NAME>>.X, <<EMPTY_NAME>>.Y);
		1368.38.1["m_OuterRadius"] = num;
		1368.38.1["m_InnerRadius"] = num3;
		1368.38.1["m_OuterGlowRadius"] = num + num2;
		1368.38.1["m_InnerGlowRadius"] = num3 - num2;
		1368.38.1["m_Alpha"] = this.16;
		1368.38.1["m_GlowColour"] = this.36;
		1368.38.1["m_RingBackgroundColour"] = this.34;
		1368.38.1["m_RingForegroundColour"] = this.32;
		1368.38.1["m_Progress"] = this.31;
		1379.35(1, 1);
		1368.38.3();
		this.39.4();
		1368.38.4();
		return true;
	}

	// Token: 0x0400377E RID: 14206
	internal float 28 = 10f;

	// Token: 0x0400377F RID: 14207
	internal float 29 = 4f;

	// Token: 0x04003780 RID: 14208
	internal float 30 = 10f;

	// Token: 0x04003781 RID: 14209
	internal float 31;

	// Token: 0x04003782 RID: 14210
	private Vector4 32;

	// Token: 0x04003783 RID: 14211
	private 198 33;

	// Token: 0x04003784 RID: 14212
	private Vector4 34;

	// Token: 0x04003785 RID: 14213
	private 198 35;

	// Token: 0x04003786 RID: 14214
	private Vector4 36;

	// Token: 0x04003787 RID: 14215
	private 198 37;

	// Token: 0x04003788 RID: 14216
	private static 1426 38 = 1425.6(1510.Position, 1049.CircularProgressBar, false);

	// Token: 0x04003789 RID: 14217
	private 1411<1397> 39;
}
