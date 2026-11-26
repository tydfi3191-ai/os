using System;

// Token: 0x02000AA0 RID: 2720
public sealed class 1399 : 1433
{
	// Token: 0x06004B7C RID: 19324 RVA: 0x001DDF10 File Offset: 0x001DC110
	internal 1399(int 1, float 2, float 3, 1381 4, 1376 5, 1065 6, 1044 7, 208 8, float 9, bool 10, 198 11) : base(4, 5, 6, 7, 8, 9, 10, 11, null)
	{
		this.71 = 1;
		this.72 = 2;
		this.73 = 3;
		this.76 = base.10();
	}

	// Token: 0x06004B7D RID: 19325 RVA: 0x001DDF60 File Offset: 0x001DC160
	internal override void ReleaseResources(bool 1)
	{
		base.ReleaseResources(1);
		if (!1 && this.70 != null)
		{
			this.70.Dispose();
			this.70 = null;
		}
	}

	// Token: 0x06004B7E RID: 19326 RVA: 0x001DDF86 File Offset: 0x001DC186
	public override 1069 Update()
	{
		if (base.10() - this.76 > this.77)
		{
			this.5 = false;
		}
		return base.Update();
	}

	// Token: 0x06004B7F RID: 19327 RVA: 0x001DDFAC File Offset: 0x001DC1AC
	public override bool Draw()
	{
		if (this.26)
		{
			return false;
		}
		1436.40.36(this.28);
		1381 texture = this.GetTexture();
		if (texture == null || texture.5())
		{
			return true;
		}
		208 <<EMPTY_NAME>> = new 208(this.50.X + this.64.X, this.50.Y + this.64.Y);
		if (this.70 == null)
		{
			if (!this.5)
			{
				return false;
			}
			this.70 = new 1411<1391>(this.71, 35044);
			1058 2 = new 1058(0f, 0f, (float)texture.1() / (float)1454.1(texture.1()), (float)texture.2() / (float)1454.1(texture.2()));
			for (int i = 0; i < this.71; i++)
			{
				int num = i * 4;
				int num2 = 1196.2(this.74 / 3, this.74);
				double num3 = 1196.4(6.283185307179586);
				208 direction = this.62 * new 208((float)Math.Cos(num3), (float)Math.Sin(num3)) * (float)1196.4((double)this.72);
				if (num2 > this.77)
				{
					this.77 = num2;
				}
				this.70.1[num].Position = <<EMPTY_NAME>> + new 208((0f - this.50.Width) / 2f, (0f - this.50.Height) / 2f);
				this.70.1[num].TexturePosition = new 208(0f, 0f);
				this.70.1[num].Colour = 198.White;
				this.70.1[num].Time = (float)num2;
				this.70.1[num].Direction = direction;
				this.70.1[num + 1].Position = <<EMPTY_NAME>> + new 208((0f - this.50.Width) / 2f, this.50.Height / 2f);
				this.70.1[num + 1].TexturePosition = new 208(0f, 2.Height);
				this.70.1[num + 1].Colour = 198.White;
				this.70.1[num + 1].Time = (float)num2;
				this.70.1[num + 1].Direction = direction;
				this.70.1[num + 2].Position = <<EMPTY_NAME>> + new 208(this.50.Width / 2f, this.50.Height / 2f);
				this.70.1[num + 2].TexturePosition = new 208(2.Width, 2.Height);
				this.70.1[num + 2].Colour = 198.White;
				this.70.1[num + 2].Time = (float)num2;
				this.70.1[num + 2].Direction = direction;
				this.70.1[num + 3].Position = <<EMPTY_NAME>> + new 208(this.50.Width / 2f, (0f - this.50.Height) / 2f);
				this.70.1[num + 3].TexturePosition = new 208(2.Width, 0f);
				this.70.1[num + 3].Colour = 198.White;
				this.70.1[num + 3].Time = (float)num2;
				this.70.1[num + 3].Direction = direction;
			}
			this.70.6();
		}
		if (texture.gpuTexture != null && texture.gpuTexture.TryBind())
		{
			1379.25.1["g_Gravity"] = this.73;
			1379.25.1["g_FadeClock"] = (float)this.74 * this.75 + (float)(base.10() - this.76) * (1f - this.75);
			1379.25.3();
			this.70.4();
			1379.25.4();
		}
		return true;
	}

	// Token: 0x04003840 RID: 14400
	private 1411<1391> 70;

	// Token: 0x04003841 RID: 14401
	private readonly int 71;

	// Token: 0x04003842 RID: 14402
	private readonly float 72;

	// Token: 0x04003843 RID: 14403
	private readonly float 73;

	// Token: 0x04003844 RID: 14404
	internal int 74 = 1200;

	// Token: 0x04003845 RID: 14405
	internal float 75;

	// Token: 0x04003846 RID: 14406
	private readonly int 76;

	// Token: 0x04003847 RID: 14407
	private int 77;
}
