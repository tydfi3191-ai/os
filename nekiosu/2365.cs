using System;
using System.Collections.Generic;

// Token: 0x020005CA RID: 1482
public sealed class 2365 : 1474
{
	// Token: 0x06002DC6 RID: 11718 RVA: 0x00102ADC File Offset: 0x00100CDC
	internal 2365(1803 1, 2263 2) : base(1)
	{
		this.3 = 2;
		this.4 = new 1256(1226.48("metronomehigh", false, true, (1416)1));
		this.5 = new 1256(1226.48("metronomelow", false, true, (1416)1));
		this.8 = new 2333(1, 2, new 208(200f, 0f));
	}

	// Token: 0x06002DC7 RID: 11719 RVA: 0x00102B7F File Offset: 0x00100D7F
	internal void 1(bool 1)
	{
		this.8.5.22 = 1;
	}

	// Token: 0x06002DC8 RID: 11720 RVA: 0x00102B92 File Offset: 0x00100D92
	internal void 2(float 1)
	{
		this.8.5.5 = 1;
	}

	// Token: 0x06002DC9 RID: 11721 RVA: 0x00102BA8 File Offset: 0x00100DA8
	public override void Draw()
	{
		this.8.Draw();
		List<1051> list = new List<1051>();
		208 <<EMPTY_NAME>> = new 208(330f, 360f);
		float 2 = this.3.7.1;
		1259 3 = 1226.73();
		float num = (3 != null) ? 3.5() : 1f;
		float num2 = (float)(100.0 * 1272.5().5 / (double)num);
		float num3 = (float)((int)(300f / num2));
		if (num3 == 0f)
		{
			num3 = 0.5f;
		}
		float num4 = num3 * num2;
		208 4 = new 208(num4 * 0.5f, 0f);
		list.Add(new 1051(1662.70.10(<<EMPTY_NAME>> - 4), 1662.70.10(<<EMPTY_NAME>> + 4)));
		1662.13.4(list, 2 * 1662.70.9(), this.6, 0f, "Standard", true, false, 15);
		list.Clear();
		208 5 = new 208((float)this.3.7.6 / num, 0f);
		208 6 = <<EMPTY_NAME>> - 4;
		while (6.X <= <<EMPTY_NAME>>.X + 4.X + 1f)
		{
			list.Add(new 1051(1662.70.10(6), 1662.70.10(6)));
			6 += 5;
		}
		6 = <<EMPTY_NAME>> - 4;
		1662.13.4(list, 2 * 0.2f * this.3.7.23, 198.White, 0f, "Standard", true, false, 15);
		list.Clear();
		double num5 = 1226.87((double)1226.16);
		double num6 = ((double)1226.16 - num5) / 1226.88((double)1226.16, false);
		num6 *= (double)num2;
		for (num6 %= (double)(num4 * 2f); num6 < 0.0; num6 += (double)num4)
		{
		}
		if (num6 >= (double)num4)
		{
			num6 = (double)(num4 * 2f) - num6;
		}
		6 += new 208((float)num6, 0f);
		list.Add(new 1051(1662.70.10(6), 1662.70.10(6)));
		1662.13.4(list, 2 * 1662.70.9(), this.7, 0f, "Standard", true, false, 15);
	}

	// Token: 0x06002DCA RID: 11722 RVA: 0x00102E36 File Offset: 0x00101036
	internal void 3()
	{
		this.8.4();
	}

	// Token: 0x06002DCB RID: 11723 RVA: 0x00102E44 File Offset: 0x00101044
	public override void Update()
	{
		if (!1226.75())
		{
			return;
		}
		double num = 1226.64() / 1226.76();
		int num2 = (int)1226.84();
		this.10 = (int)Math.Floor(num);
		this.9 = (int)num % num2;
		this.11 = this.10 / num2;
		int num3 = (int)(2.0 * num);
		int num4 = (int)(3.0 * num);
		bool flag = (this.3.96() % 3 == 0) ? (num4 > this.14) : (num3 > this.13);
		if (1226.64() < 0.0)
		{
			this.9 += 3;
			this.11--;
		}
		if (this.15 && 1226.32 == (1042)1)
		{
			if (this.12 == this.10 - 1 || this.12 > this.10)
			{
				if (this.16 == 0)
				{
					if (1226.84() == (1257)4)
					{
						switch (this.9)
						{
						case 0:
							this.4.Play(true, true);
							break;
						case 1:
						case 3:
							this.5.Play(true, true);
							this.5.2(0.8f);
							break;
						case 2:
							this.5.Play(true, true);
							this.5.2(0.6f);
							break;
						}
					}
					else if (this.9 == 0)
					{
						this.4.Play(true, true);
					}
					else
					{
						this.5.Play(true, true);
						this.5.2(0.8f);
					}
				}
				else
				{
					this.16--;
				}
			}
			else if (flag && 1549.1)
			{
				this.5.Play(true, true);
				this.5.2(0.8f);
			}
		}
		this.12 = this.10;
		this.13 = num3;
		this.14 = num4;
	}

	// Token: 0x04002197 RID: 8599
	private 2263 3;

	// Token: 0x04002198 RID: 8600
	private readonly 1256 4;

	// Token: 0x04002199 RID: 8601
	private readonly 1256 5;

	// Token: 0x0400219A RID: 8602
	private 198 6 = new 198(250, 250, 250, 140);

	// Token: 0x0400219B RID: 8603
	private 198 7 = new 198(50, 50, 50, 140);

	// Token: 0x0400219C RID: 8604
	internal 2333 8;

	// Token: 0x0400219D RID: 8605
	internal int 9;

	// Token: 0x0400219E RID: 8606
	internal int 10;

	// Token: 0x0400219F RID: 8607
	internal int 11;

	// Token: 0x040021A0 RID: 8608
	private int 12;

	// Token: 0x040021A1 RID: 8609
	private int 13;

	// Token: 0x040021A2 RID: 8610
	private int 14;

	// Token: 0x040021A3 RID: 8611
	internal bool 15 = true;

	// Token: 0x040021A4 RID: 8612
	internal int 16;
}
