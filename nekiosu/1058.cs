using System;
using System.Drawing;
using System.Globalization;

// Token: 0x02000C6C RID: 3180
[Serializable]
public struct 1058
{
	// Token: 0x060054D5 RID: 21717 RVA: 0x002104F9 File Offset: 0x0020E6F9
	public 1058(float 1, float 2, float 3, float 4)
	{
		this.X = 1;
		this.Y = 2;
		this.Width = 3;
		this.Height = 4;
	}

	// Token: 0x060054D6 RID: 21718 RVA: 0x00210518 File Offset: 0x0020E718
	public 1058(PointF 1, SizeF 2)
	{
		this.X = 1.X;
		this.Y = 1.Y;
		this.Width = 2.Width;
		this.Height = 2.Height;
	}

	// Token: 0x060054D8 RID: 21720 RVA: 0x0021055B File Offset: 0x0020E75B
	public static 1058 1(float 1, float 2, float 3, float 4)
	{
		return new 1058(1, 2, 3 - 1, 4 - 2);
	}

	// Token: 0x060054D9 RID: 21721 RVA: 0x0021056A File Offset: 0x0020E76A
	public float 2()
	{
		return this.X;
	}

	// Token: 0x060054DA RID: 21722 RVA: 0x00210572 File Offset: 0x0020E772
	public float 3()
	{
		return this.Y;
	}

	// Token: 0x060054DB RID: 21723 RVA: 0x0021057A File Offset: 0x0020E77A
	public float 4()
	{
		return this.X + this.Width;
	}

	// Token: 0x060054DC RID: 21724 RVA: 0x00210589 File Offset: 0x0020E789
	public float 5()
	{
		return this.Y + this.Height;
	}

	// Token: 0x060054DD RID: 21725 RVA: 0x00210598 File Offset: 0x0020E798
	public override bool Equals(object 1)
	{
		if (1 is 1058)
		{
			1058 2 = (1058)1;
			return 2.X == this.X && 2.Y == this.Y && 2.Width == this.Width && 2.Height == this.Height;
		}
		return false;
	}

	// Token: 0x060054DE RID: 21726 RVA: 0x002105F2 File Offset: 0x0020E7F2
	public static bool operator ==(1058 1, 1058 2)
	{
		return 1.X == 2.X && 1.Y == 2.Y && 1.Width == 2.Width && 1.Height == 2.Height;
	}

	// Token: 0x060054DF RID: 21727 RVA: 0x0021062E File Offset: 0x0020E82E
	public static bool operator !=(1058 1, 1058 2)
	{
		return !(1 == 2);
	}

	// Token: 0x060054E0 RID: 21728 RVA: 0x0021063A File Offset: 0x0020E83A
	public static 1058 operator *(1058 1, float 2)
	{
		return new 1058(1.X * 2, 1.Y * 2, 1.Width * 2, 1.Height * 2);
	}

	// Token: 0x060054E1 RID: 21729 RVA: 0x00210661 File Offset: 0x0020E861
	public static 1058 operator /(1058 1, float 2)
	{
		return new 1058(1.X / 2, 1.Y / 2, 1.Width / 2, 1.Height / 2);
	}

	// Token: 0x060054E2 RID: 21730 RVA: 0x00210688 File Offset: 0x0020E888
	public bool 6(float 1, float 2)
	{
		return this.X <= 1 && 1 < this.X + this.Width && this.Y <= 2 && 2 < this.Y + this.Height;
	}

	// Token: 0x060054E3 RID: 21731 RVA: 0x002106BE File Offset: 0x0020E8BE
	public bool 7(208 1)
	{
		return this.6(1.X, 1.Y);
	}

	// Token: 0x060054E4 RID: 21732 RVA: 0x002106D2 File Offset: 0x0020E8D2
	public bool 8(PointF 1)
	{
		return this.6(1.X, 1.Y);
	}

	// Token: 0x060054E5 RID: 21733 RVA: 0x002106E8 File Offset: 0x0020E8E8
	public bool 9(206 1)
	{
		return this.6((float)1.X, (float)1.Y);
	}

	// Token: 0x060054E6 RID: 21734 RVA: 0x00210700 File Offset: 0x0020E900
	public bool 10(1058 1)
	{
		return this.X <= 1.X && 1.X + 1.Width <= this.X + this.Width && this.Y <= 1.Y && 1.Y + 1.Height <= this.Y + this.Height;
	}

	// Token: 0x060054E7 RID: 21735 RVA: 0x00210768 File Offset: 0x0020E968
	public bool 11(208 1, 208 2, float 3)
	{
		if (3 == 0f)
		{
			return this.7(1);
		}
		202 4 = 202.CreateRotationZ(0f - 3);
		208 5 = 208.Transform(1 - 2, 4) + 2;
		return this.6(5.X, 5.Y);
	}

	// Token: 0x060054E8 RID: 21736 RVA: 0x002107B8 File Offset: 0x0020E9B8
	public void 12(208 1, float 2, out 208 3, out 208 4, out 208 5, out 208 6)
	{
		202 7 = 202.CreateRotationZ(2);
		3 = 208.Transform(new 208(this.2(), this.3()) - 1, 7) + 1;
		4 = 208.Transform(new 208(this.4(), this.3()) - 1, 7) + 1;
		5 = 208.Transform(new 208(this.2(), this.5()) - 1, 7) + 1;
		6 = 208.Transform(new 208(this.4(), this.5()) - 1, 7) + 1;
	}

	// Token: 0x060054E9 RID: 21737 RVA: 0x00210874 File Offset: 0x0020EA74
	public override int GetHashCode()
	{
		return (int)((uint)this.X ^ ((uint)this.Y << 13 | (uint)this.Y >> 19) ^ ((uint)this.Width << 26 | (uint)this.Width >> 6) ^ ((uint)this.Height << 7 | (uint)this.Height >> 25));
	}

	// Token: 0x060054EA RID: 21738 RVA: 0x002108C8 File Offset: 0x0020EAC8
	public void 13(float 1, float 2)
	{
		this.X -= 1;
		this.Y -= 2;
		this.Width += 2f * 1;
		this.Height += 2f * 2;
	}

	// Token: 0x060054EB RID: 21739 RVA: 0x00210919 File Offset: 0x0020EB19
	public void 14(SizeF 1)
	{
		this.13(1.Width, 1.Height);
	}

	// Token: 0x060054EC RID: 21740 RVA: 0x00210930 File Offset: 0x0020EB30
	public static 1058 15(1058 1, float 2, float 3)
	{
		1058 result = 1;
		result.13(2, 3);
		return result;
	}

	// Token: 0x060054ED RID: 21741 RVA: 0x0021094C File Offset: 0x0020EB4C
	public static 1058 16(1058 1, 1058 2)
	{
		float num = Math.Min(1.X, 2.X);
		float num2 = Math.Max(1.X + 1.Width, 2.X + 2.Width);
		float num3 = Math.Min(1.Y, 2.Y);
		float num4 = Math.Max(1.Y + 1.Height, 2.Y + 2.Height);
		return new 1058(num, num3, num2 - num, num4 - num3);
	}

	// Token: 0x060054EE RID: 21742 RVA: 0x002109CA File Offset: 0x0020EBCA
	public void Offset(PointF 1)
	{
		this.Offset(1.X, 1.Y);
	}

	// Token: 0x060054EF RID: 21743 RVA: 0x002109E0 File Offset: 0x0020EBE0
	public void Offset(float 1, float 2)
	{
		this.X += 1;
		this.Y += 2;
	}

	// Token: 0x060054F0 RID: 21744 RVA: 0x002109FE File Offset: 0x0020EBFE
	public static implicit operator 1058(Rectangle 1)
	{
		return new 1058((float)1.X, (float)1.Y, (float)1.Width, (float)1.Height);
	}

	// Token: 0x060054F1 RID: 21745 RVA: 0x00210A28 File Offset: 0x0020EC28
	public override string ToString()
	{
		return string.Concat(new string[]
		{
			"{X=",
			this.X.ToString(CultureInfo.CurrentCulture),
			",Y=",
			this.Y.ToString(CultureInfo.CurrentCulture),
			",Width=",
			this.Width.ToString(CultureInfo.CurrentCulture),
			",Height=",
			this.Height.ToString(CultureInfo.CurrentCulture),
			"}"
		});
	}

	// Token: 0x060054F2 RID: 21746 RVA: 0x00210AB8 File Offset: 0x0020ECB8
	public static bool 17(double 1, 1058 2, 1058 3, 208 4)
	{
		double num2;
		double num;
		double num4;
		double num3;
		double num6;
		double num5;
		double num8;
		double num7;
		if (1 == 0.0)
		{
			num = (num2 = (double)2.X) + (double)2.Width;
			num3 = (num4 = (double)2.Y) + (double)2.Height;
			num5 = (num6 = (double)3.X) + (double)3.Width;
			num7 = (num8 = (double)3.Y) + (double)3.Height;
			return num2 <= num5 && num6 <= num && num4 <= num7 && num8 <= num3;
		}
		double num9 = Math.Cos(1);
		double num10 = Math.Sin(1);
		bool flag = num9 > 0.0;
		bool flag2 = num10 > 0.0;
		double num11 = 0.5 * (double)2.Width;
		double num12 = 0.5 * (double)2.Height;
		double num13 = (double)(2.X + 4.X);
		double num14 = (double)(2.Y + 4.Y);
		double num15 = num9 * num11;
		double num16 = num10 * num11;
		double num17 = num9 * num12;
		double num18 = num10 * num12;
		num5 = (num6 = (double)3.X - num13) + (double)3.Width;
		num7 = (num8 = (double)3.Y - num14) + (double)3.Height;
		if (flag)
		{
			if (flag2)
			{
				num2 = 0.0 - (num = num15 + num18);
				num4 = 0.0 - (num3 = num17 + num16);
			}
			else
			{
				num2 = 0.0 - (num = num15 - num18);
				num4 = 0.0 - (num3 = num17 - num16);
			}
		}
		else if (flag2)
		{
			num = 0.0 - (num2 = num15 - num18);
			num3 = 0.0 - (num4 = num17 - num16);
		}
		else
		{
			num = 0.0 - (num2 = num15 + num18);
			num3 = 0.0 - (num4 = num17 + num16);
		}
		if (num2 > num5 || num6 > num || num4 > num7 || num8 > num3)
		{
			return false;
		}
		if (flag)
		{
			if (flag2)
			{
				return num9 * num5 + num10 * num7 >= 0.0 - num11 && num9 * num6 + num10 * num8 <= num11 && num9 * num7 - num10 * num6 >= 0.0 - num12 && num9 * num8 - num10 * num5 <= num12;
			}
			return num9 * num5 + num10 * num8 >= 0.0 - num11 && num9 * num6 + num10 * num7 <= num11 && num9 * num7 - num10 * num5 >= 0.0 - num12 && num9 * num8 - num10 * num6 <= num12;
		}
		else
		{
			if (flag2)
			{
				return num9 * num6 + num10 * num7 >= 0.0 - num11 && num9 * num5 + num10 * num8 <= num11 && num9 * num8 - num10 * num6 >= 0.0 - num12 && num9 * num7 - num10 * num5 <= num12;
			}
			return num9 * num6 + num10 * num8 >= 0.0 - num11 && num9 * num5 + num10 * num7 <= num11 && num9 * num8 - num10 * num5 >= 0.0 - num12 && num9 * num7 - num10 * num6 <= num12;
		}
	}

	// Token: 0x04004323 RID: 17187
	public static readonly 1058 rectangleF3 = default(1058);

	// Token: 0x04004324 RID: 17188
	public float X;

	// Token: 0x04004325 RID: 17189
	public float Y;

	// Token: 0x04004326 RID: 17190
	public float Width;

	// Token: 0x04004327 RID: 17191
	public float Height;
}
