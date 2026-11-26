using System;
using System.Collections.Generic;

// Token: 0x02000A9D RID: 2717
public sealed class 1388 : 1054, IDisposable
{
	// Token: 0x06004B6E RID: 19310 RVA: 0x001DD6E7 File Offset: 0x001DB8E7
	internal void 1()
	{
		1379.24.3();
	}

	// Token: 0x06004B6F RID: 19311 RVA: 0x001DD748 File Offset: 0x001DB948
	internal void 2(208 1, 208 2, 198 3)
	{
		this.4.5(new 1398
		{
			Position = new 208(1.X, 2.Y),
			Colour = 3
		});
		this.4.5(new 1398
		{
			Position = 2,
			Colour = 3
		});
		this.4.5(new 1398
		{
			Position = new 208(2.X, 1.Y),
			Colour = 3
		});
		this.4.5(new 1398
		{
			Position = 1,
			Colour = 3
		});
	}

	// Token: 0x06004B70 RID: 19312 RVA: 0x001DD805 File Offset: 0x001DBA05
	internal void 3()
	{
		this.4.6();
		1379.24.4();
	}

	// Token: 0x06004B71 RID: 19313 RVA: 0x001DD81C File Offset: 0x001DBA1C
	public void DrawPath(1051 1, float 2, 198 3)
	{
		this.DrawPath(new List<1051>(1)
		{
			1
		}, null, 2, 3);
	}

	// Token: 0x06004B72 RID: 19314 RVA: 0x001DD844 File Offset: 0x001DBA44
	public void DrawPath(List<1051> 1, 1051 2, float 3, 198 4)
	{
		this.4(1, 3, 4, 0f, "StandardNoGradient", true, false, 15);
	}

	// Token: 0x06004B73 RID: 19315 RVA: 0x001DD86C File Offset: 0x001DBA6C
	internal void 4(List<1051> 1, float 2, 198 3, float 4, string 5, bool 6, bool 7, int 8)
	{
		1379.24.3();
		if (8 > 15)
		{
			8 = 15;
		}
		bool flag = 5 == "NoBlur";
		bool flag2 = 5 == "StandardNoGradient";
		int count = 1.Count;
		for (int i = 0; i < count; i++)
		{
			1051 9 = 1[i];
			1050 10 = 9 as 1050;
			208 11 = 208.Normalize(9.2 - 9.1);
			208 12 = new 208(2 * 11.Y, (0f - 2) * 11.X);
			if (10 != null && 10.5 != 198.White)
			{
				3 = 10.5;
			}
			208 position = 9.1 + 12;
			208 position2 = 9.1 - 12;
			208 position3 = 9.2 - 12;
			208 position4 = 9.2 + 12;
			this.4.5(new 1398
			{
				Position = position,
				Colour = 3
			});
			this.4.5(new 1398
			{
				Position = position4,
				Colour = 3
			});
			198 colour = 3;
			if (!flag)
			{
				if (!flag2)
				{
					colour = new 198(3.R, 3.G, 3.B, (byte)Math.Max(0, (int)(3.A - 30)));
				}
				this.4.5(new 1398
				{
					Position = 9.2,
					Colour = colour
				});
				this.4.5(new 1398
				{
					Position = 9.1,
					Colour = colour
				});
				this.4.5(new 1398
				{
					Position = 9.1,
					Colour = colour
				});
				this.4.5(new 1398
				{
					Position = 9.2,
					Colour = colour
				});
			}
			this.4.5(new 1398
			{
				Position = position3,
				Colour = 3
			});
			this.4.5(new 1398
			{
				Position = position2,
				Colour = 3
			});
			float num = 9.2();
			if (6)
			{
				if (7)
				{
					if (i == 0)
					{
						this.5(9.1, 2, (float)((double)num + 7.853981633974483), 3.1415927f, 3, !flag2 && !flag, 8);
					}
					if (i == count - 1)
					{
						this.5(9.2, 2, (float)((double)num + 4.71238898038469), 3.1415927f, 3, !flag2 && !flag, 8);
					}
					if (i < count - 1)
					{
						float num2 = 1[i + 1].2();
						float num3;
						float num4;
						if (num < num2 - 0.01f)
						{
							num3 = num2 - num;
							num4 = (float)((double)num + 4.71238898038469);
						}
						else
						{
							if (num2 >= num - 0.01f)
							{
								goto IL_3C0;
							}
							num3 = num - num2;
							num4 = (float)((double)num2 + 7.853981633974483);
						}
						this.5(9.2, 2, num4, num3, 3, !flag2 && !flag, 2);
					}
				}
				else
				{
					this.5(9.1, 2, (float)((double)num + 7.853981633974483), 3.1415927f, 3, !flag2 && !flag, 8);
					this.5(9.2, 2, (float)((double)num + 4.71238898038469), 3.1415927f, 3, !flag2 && !flag, 8);
				}
			}
			IL_3C0:;
		}
		this.4.6();
		this.5.6();
		1379.24.4();
	}

	// Token: 0x06004B74 RID: 19316 RVA: 0x001DDC64 File Offset: 0x001DBE64
	private void 5(208 1, float 2, float 3, float 4, 198 5, bool 6, int 7)
	{
		float num = 4 / (float)7;
		198 colour = 6 ? new 198(5.R, 5.G, 5.B, (byte)Math.Max(0, (int)(5.A - 30))) : 5;
		1398 8 = new 1398
		{
			Position = 1,
			Colour = colour
		};
		1398 9 = default(1398);
		float num2 = 4 + 3;
		float num3 = 3;
		for (int i = 0; i <= 7; i++)
		{
			if (6)
			{
				double num4 = Math.Sin(Math.Abs((double)(num3 - 3) - 1.5707963267948966));
				colour = new 198(5.R, 5.G, 5.B, (byte)Math.Max(0.0, (double)5.A - 30.0 * (1.0 - num4)));
			}
			208 10 = new 208((float)Math.Cos((double)num3), (float)Math.Sin((double)num3));
			1398 11 = new 1398
			{
				Position = 1 + 10 * 2,
				Colour = colour
			};
			if (i > 0)
			{
				this.5.5(8);
				this.5.5(11);
				this.5.5(9);
			}
			9 = 11;
			num3 += num;
			if (num3 > num2)
			{
				num3 = num2;
			}
		}
	}

	// Token: 0x06004B75 RID: 19317 RVA: 0x001DDDD8 File Offset: 0x001DBFD8
	public void 6(double 1, double 2, 198 3)
	{
		this.2(new 208((float)(1 - 2.0), (float)(2 - 2.0)), new 208((float)(1 + 2.0), (float)(2 + 2.0)), 3);
	}

	// Token: 0x06004B76 RID: 19318 RVA: 0x0000FF75 File Offset: 0x0000E175
	public bool IsSliderBody()
	{
		return false;
	}

	// Token: 0x06004B77 RID: 19319 RVA: 0x001DDE28 File Offset: 0x001DC028
	~1388()
	{
		this.7(false);
	}

	// Token: 0x06004B78 RID: 19320 RVA: 0x001DDE58 File Offset: 0x001DC058
	public void Dispose()
	{
		this.7(true);
		GC.SuppressFinalize(this);
	}

	// Token: 0x06004B79 RID: 19321 RVA: 0x00005ADD File Offset: 0x00003CDD
	protected void 7(bool 1)
	{
	}

	// Token: 0x04003839 RID: 14393
	private int 1;

	// Token: 0x0400383A RID: 14394
	private int 2;

	// Token: 0x0400383B RID: 14395
	private int 3;

	// Token: 0x0400383C RID: 14396
	private 1375<1398> 4 = new 1375<1398>(100, 20);

	// Token: 0x0400383D RID: 14397
	private 1407<1398> 5 = new 1407<1398>(4500, 20, 4);
}
