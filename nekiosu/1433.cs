using System;
using System.Collections.Generic;
using System.Threading;

// Token: 0x02000AC6 RID: 2758
public class 1433 : 1371
{
	// Token: 0x06004C87 RID: 19591 RVA: 0x001E33B4 File Offset: 0x001E15B4
	internal 1433(string 1, 208 2, 1416 3 = (1416)7, 1065 4 = 1065.Centre, 1376 5 = (1376)6) : this(1455.2(1, 3, null), 5, 4, (1044)0, 2, 1f, true, 198.White, null)
	{
	}

	// Token: 0x06004C88 RID: 19592 RVA: 0x001E33E4 File Offset: 0x001E15E4
	internal 1433(1381 1, 1376 2, 1065 3, 1044 4, 208 5) : this(1, 2, 3, 4, 5, 1f, false, 198.White, null)
	{
	}

	// Token: 0x06004C89 RID: 19593 RVA: 0x001E340C File Offset: 0x001E160C
	internal 1433(1381 1, 1065 2, 208 3, float 4, bool 5, 198 6) : this(1, (1376)6, 2, (1044)0, 3, 4, 5, 6, null)
	{
	}

	// Token: 0x06004C8A RID: 19594 RVA: 0x001E342C File Offset: 0x001E162C
	internal 1433(1381 1, 208 2, float 3, bool 4, 198 5) : this(1, (1376)6, 1065.TopLeft, (1044)0, 2, 3, 4, 5, null)
	{
	}

	// Token: 0x06004C8B RID: 19595 RVA: 0x001E344C File Offset: 0x001E164C
	internal 1433(1381 1, 1376 2, 1065 3, 1044 4, 208 5, float 6, bool 7, 198 8, object 9 = null) : base(7)
	{
		this.47 = 1;
		this.49 = 3;
		this.ResetSourceRectangle();
		this.UpdateOriginOffset();
		this.1 = 4;
		this.17 = 5;
		this.7 = this.17;
		this.15 = 1f;
		this.2 = 6;
		this.45 = 0f - this.2;
		this.41 = 2;
		this.16 = (float)8.A / 255f;
		this.6 = 8;
		this.8 = 9;
	}

	// Token: 0x06004C8C RID: 19596 RVA: 0x001E34EE File Offset: 0x001E16EE
	internal new 208 27()
	{
		if (this.41 == (1376)8)
		{
			return new 208((float)1662.70.1() - this.17.X, this.17.Y);
		}
		return this.17;
	}

	// Token: 0x06004C8D RID: 19597 RVA: 0x0001702D File Offset: 0x0001522D
	internal override bool CanBatch()
	{
		return true;
	}

	// Token: 0x06004C8E RID: 19598 RVA: 0x001E3528 File Offset: 0x001E1728
	internal int 28()
	{
		int val = (int)(853.3333f * 1662.69.5 * (480f * 1662.69.5));
		return Math.Min((int)(this.50.Width * this.50.Height / (1662.70.3() * 1662.70.3())), val);
	}

	// Token: 0x06004C8F RID: 19599 RVA: 0x001E358C File Offset: 0x001E178C
	internal virtual bool GetIsReversed()
	{
		return this.51;
	}

	// Token: 0x06004C90 RID: 19600 RVA: 0x001E3594 File Offset: 0x001E1794
	internal virtual void SetIsReversed(bool 1)
	{
		this.51 = 1;
	}

	// Token: 0x06004C91 RID: 19601 RVA: 0x001E35A0 File Offset: 0x001E17A0
	internal void 29(1189 1)
	{
		1189 2 = this.56;
		1189 3;
		do
		{
			3 = 2;
			1189 value = (1189)Delegate.Combine(3, 1);
			2 = Interlocked.CompareExchange<1189>(ref this.56, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x06004C92 RID: 19602 RVA: 0x001E35D8 File Offset: 0x001E17D8
	public override 1069 Update()
	{
		1069 <<EMPTY_NAME>> = base.Update();
		if (<<EMPTY_NAME>> != (1069)0)
		{
			return <<EMPTY_NAME>>;
		}
		<<EMPTY_NAME>> = this.30(true);
		if (<<EMPTY_NAME>> != (1069)0)
		{
			return <<EMPTY_NAME>>;
		}
		208 2 = this.31;
		1436 3 = 1436.40;
		2528 4 = this.18 ?? 3.26;
		208 5 = this.17;
		float num = 1f;
		float num2 = 1f;
		bool flag = false;
		bool flag2 = false;
		this.67 = 0f;
		if (4 != null)
		{
			if (!4.11)
			{
				if (!2528.2)
				{
					this.19 = false;
					return (1069)1;
				}
				num2 = 0.3f;
			}
			num2 *= 4.18;
			if (2528.25(this.41))
			{
				float 6 = 3.24 ? 3.34.Width : ((float)1662.70.1 / 1662.70.3());
				float 7 = 3.24 ? 3.34.Height : ((float)1662.70.2 / 1662.70.3());
				5 = 4.39(this.17, this.41, 6, 7);
				num = 4.10;
				flag = 4.16;
				flag2 = 4.17;
				this.67 = (float)((double)4.15 * 3.141592653589793 / 180.0);
			}
		}
		this.68 = (flag != flag2);
		float num3 = (4 != null) ? 4.1(3) : 3.5;
		bool flag3 = (double)this.16 > 0.001 && num3 > 0f;
		if (flag3 && this.41 == (1376)6 && !this.54)
		{
			float num4 = 3.29.Y - 3.33.Y + 3.30.Y - 5.Y;
			float num5 = 3.29.X - 3.33.X + 3.30.X - 5.X;
			float num6 = 5.Y - (3.29.Y - 3.33.Y + 3.30.Y + 3.34.Height / 3.13);
			float num7 = 5.X - (3.29.X - 3.33.X + 3.30.X + 3.34.Width / 3.13);
			if ((num4 > 0f || num6 > 0f || num5 > 0f || num7 > 0f) && this.14 == 0f && this.67 == 0f && !flag && !flag2)
			{
				float num8 = Math.Abs((float)this.34 * this.20.Y * this.15);
				float num9 = Math.Abs((float)this.35 * this.20.X * this.15);
				if (!this.66)
				{
					num9 /= 1662.70.3();
					num8 /= 1662.70.3();
				}
				else
				{
					num9 /= 1.6f;
					num8 /= 1.6f;
				}
				switch (this.49)
				{
				case 1065.TopLeft:
					if (num6 > 0f || num4 > num8 || num7 > 0f || num5 > num9)
					{
						flag3 = false;
					}
					break;
				case 1065.Centre:
					if (num6 > num8 / 2f || num4 > num8 / 2f || num7 > num9 / 2f || num5 > num9 / 2f)
					{
						flag3 = false;
					}
					break;
				case 1065.CentreLeft:
					if (num6 > num8 / 2f || num4 > num8 / 2f || num7 > 0f || num5 > num9)
					{
						flag3 = false;
					}
					break;
				case 1065.TopRight:
					if (num6 > 0f || num4 > num8 || num7 > num9 || num5 > 0f)
					{
						flag3 = false;
					}
					break;
				case 1065.BottomCentre:
					if (num6 > num8 || num4 > 0f || num7 > num9 / 2f || num5 > num9 / 2f)
					{
						flag3 = false;
					}
					break;
				case 1065.TopCentre:
					if (num6 > 0f || num4 > num8 || num7 > num9 / 2f || num5 > num9 / 2f)
					{
						flag3 = false;
					}
					break;
				case 1065.CentreRight:
					if (num6 > num8 / 2f || num4 > num8 / 2f || num7 > num9 || num5 > 0f)
					{
						flag3 = false;
					}
					break;
				case 1065.BottomLeft:
					if (num6 > num8 || num4 > 0f || num7 > 0f || num5 > num9)
					{
						flag3 = false;
					}
					break;
				case 1065.BottomRight:
					if (num6 > num8 || num4 > 0f || num7 > num9 || num5 > 0f)
					{
						flag3 = false;
					}
					break;
				}
			}
		}
		if (!flag3 && !3.37)
		{
			this.19 = false;
			return (1069)1;
		}
		this.31 = 5;
		this.61 = this.48;
		this.63 = Math.Max(this.15, 0f) * ((this.69 > 0f) ? (num / this.69) : num);
		if (3.24 && (!this.54 || this.55 > 0f))
		{
			208 8 = 3.30 - 3.33;
			switch (this.41)
			{
			case (1376)8:
			case (1376)11:
			case (1376)17:
				8 += new 208(0f - 3.29.X, 3.29.Y);
				break;
			default:
				8 += 3.29;
				break;
			case (1376)12:
			case (1376)13:
			case (1376)19:
				8 += new 208(3.29.X, 0f - 3.29.Y);
				break;
			case (1376)14:
			case (1376)18:
				8 -= 3.29;
				break;
			}
			if (this.55 > 0f)
			{
				8.Y = Math.Max(0f, Math.Min(this.55, 8.Y));
			}
			this.31 -= 8;
		}
		bool flag4 = true;
		float num10 = 3.24 ? (3.34.Width * 1662.70.3()) : ((float)1662.70.1);
		float num11 = 3.24 ? (3.34.Height * 1662.70.3()) : ((float)1662.70.2);
		1376 9 = this.41;
		switch (9)
		{
		case (1376)1:
		case (1376)2:
			this.63 *= 3.14;
			break;
		case (1376)3:
		case (1376)4:
			this.63 *= 1662.69.9();
			break;
		case (1376)5:
			break;
		default:
			switch (9)
			{
			case (1376)15:
				this.63 *= 1662.70.3() * 1662.69.10();
				break;
			default:
				if (this.66)
				{
					this.63 *= 1662.70.9();
				}
				break;
			case (1376)17:
			case (1376)19:
				break;
			}
			break;
		}
		switch (this.41)
		{
		case (1376)1:
			1662.69.18(ref this.31);
			flag4 = false;
			goto IL_CE1;
		case (1376)2:
			1662.69.19(ref this.31);
			flag4 = false;
			goto IL_CE1;
		case (1376)3:
			this.31 = this.31 * 1662.70.3() * 1662.69.5;
			this.31.X = this.31.X + (num10 + (float)((!3.25) ? (1662.70.4() * 2) : 0)) * ((1f - 1662.69.5) * 0.5f);
			this.31.Y = this.31.Y + num11 * ((1f - 1662.69.5) * 0.75f);
			goto IL_CE1;
		case (1376)4:
			this.31 += new 208((float)((3.25 ? 640 : 1662.70.1()) / 2), 240f);
			this.31 = this.31 * 1662.70.3() * 1662.69.5;
			this.31.X = this.31.X + (num10 + (float)((!3.25) ? (1662.70.4() * 2) : 0)) * ((1f - 1662.69.5) * 0.5f);
			this.31.Y = this.31.Y + num11 * ((1f - 1662.69.5) * 0.75f);
			goto IL_CE1;
		case (1376)6:
			this.31 *= 1662.70.3();
			goto IL_CE1;
		case (1376)7:
			this.31 *= 1662.70.3();
			this.31.X = this.31.X + num10 / 2f;
			goto IL_CE1;
		case (1376)8:
			this.31 *= 1662.70.3();
			this.31.X = num10 - this.31.X;
			goto IL_CE1;
		case (1376)9:
			this.31.X = this.31.X * 1662.70.3();
			this.31.Y = num11 / 2f + this.31.Y * 1662.70.3();
			goto IL_CE1;
		case (1376)10:
			this.31.X = num10 / 2f + this.31.X * 1662.70.3();
			this.31.Y = num11 / 2f + this.31.Y * 1662.70.3();
			goto IL_CE1;
		case (1376)11:
			this.31.X = num10 - this.31.X * 1662.70.3();
			this.31.Y = num11 / 2f + this.31.Y * 1662.70.3();
			goto IL_CE1;
		case (1376)12:
			this.31 *= 1662.70.3();
			this.31.Y = num11 - this.31.Y;
			goto IL_CE1;
		case (1376)13:
			this.31 *= 1662.70.3();
			this.31.X = num10 / 2f + this.31.X;
			this.31.Y = num11 - this.31.Y;
			goto IL_CE1;
		case (1376)14:
			this.31 *= 1662.70.3();
			this.31.X = num10 - this.31.X;
			this.31.Y = num11 - this.31.Y;
			goto IL_CE1;
		case (1376)15:
			this.31 = 1662.70.3() * this.31;
			goto IL_CE1;
		case (1376)16:
			flag4 = false;
			goto IL_CE1;
		case (1376)17:
			this.31.X = num10 - this.31.X;
			flag4 = false;
			goto IL_CE1;
		case (1376)18:
			this.31.X = num10 - this.31.X;
			this.31.Y = num11 - this.31.Y;
			flag4 = false;
			goto IL_CE1;
		case (1376)19:
			this.31.X = num10 / 2f + this.31.X;
			this.31.Y = num11 - this.31.Y;
			flag4 = false;
			goto IL_CE1;
		}
		flag4 = false;
		IL_CE1:
		byte b = (byte)(this.16 * num3 * num2 * 255f);
		byte a = this.6.A;
		if (a > 0 && a < 255)
		{
			b = (byte)((float)b * ((float)a / 255f));
		}
		if (3.7 == 0f)
		{
			this.30 = new 198(this.6.R, this.6.G, this.6.B, b);
		}
		else
		{
			this.30 = new 198((byte)Math.Max(0f, Math.Min(255f, 255f * 3.8 * 3.7 + (float)this.6.R * (1f - 3.7))), (byte)Math.Max(0f, Math.Min(255f, 255f * 3.8 * 3.7 + (float)this.6.G * (1f - 3.7))), (byte)Math.Max(0f, Math.Min(255f, 255f * 3.8 * 3.7 + (float)this.6.B * (1f - 3.7))), b);
		}
		if (4 != null && 4.19 != 198.White)
		{
			198 10 = 4.19;
			this.30 = new 198(this.30.R * 10.R / byte.MaxValue, this.30.G * 10.G / byte.MaxValue, this.30.B * 10.B / byte.MaxValue, this.30.A);
		}
		this.62 = this.20 * this.63;
		if (flag)
		{
			this.62.X = -this.62.X;
		}
		if (flag2)
		{
			this.62.Y = -this.62.Y;
		}
		if (3.13 != 1f && !this.54)
		{
			if (!(this is 1452))
			{
				this.62 *= 3.13;
			}
			this.31 *= 3.13;
		}
		if (flag4)
		{
			this.31.X = this.31.X + 3.35.X;
			this.31.Y = this.31.Y + 3.35.Y;
		}
		this.32 = false;
		if (this.40 != null)
		{
			this.32 = this.40.Value;
		}
		else if (this.62.X == 1f && this.62.Y == 1f && 208.DistanceSquared(2, this.31) < 1E-45f)
		{
			this.32 = true;
		}
		this.64 = new 208(this.61.X * Math.Abs(this.62.X), this.61.Y * Math.Abs(this.62.Y));
		208 11 = this.31 - this.64;
		if (this.32)
		{
			11.X = (float)Math.Round((double)11.X);
			11.Y = (float)Math.Round((double)11.Y);
		}
		this.50 = new 1058(11.X, 11.Y, (float)this.35 * Math.Abs(this.62.X), (float)this.34 * Math.Abs(this.62.Y));
		if (3.24 && this.14 == 0f && this.67 == 0f && this.41 != (1376)16 && (this.41 != (1376)8 || !3.25) && !1058.17((double)this.14, this.50, 3.35, this.64))
		{
			this.19 = false;
			if (this.IsHovered())
			{
				this.SetHovered(false);
			}
			return (1069)1;
		}
		this.65 = new 207(this.36, this.37, Math.Min(this.39, Math.Max(0, this.35)), Math.Min(this.38, Math.Max(0, this.34)));
		if (this.56 != null)
		{
			this.56();
		}
		this.19 = flag3;
		if (!this.19)
		{
			return (1069)1;
		}
		return (1069)0;
	}

	// Token: 0x06004C93 RID: 19603 RVA: 0x001E4780 File Offset: 0x001E2980
	private 1069 30(bool 1)
	{
		int num = this.3.Count;
		if (num == 0)
		{
			if (!this.5)
			{
				return (1069)2;
			}
			return (1069)0;
		}
		else
		{
			bool flag = this.5;
			int num2 = base.10();
			bool flag2 = false;
			bool flag3 = false;
			bool? flag4 = null;
			bool? flag5 = null;
			bool? flag6 = null;
			bool flag7 = false;
			bool flag8 = false;
			bool flag9 = false;
			bool flag10 = false;
			bool flag11 = false;
			bool flag12 = false;
			bool flag13 = false;
			bool flag14 = false;
			bool flag15 = false;
			bool flag16 = false;
			bool flag17 = false;
			bool flag18 = false;
			foreach (1445 2 in this.3)
			{
				if (2.9 >= num2 || 2.10 > num2)
				{
					flag2 = true;
					if (2.17 && 2.13 > 0 && !1436.40.16)
					{
						flag15 = true;
					}
					if (2.9 > num2)
					{
						continue;
					}
				}
				if (2.10 <= num2)
				{
					flag3 = true;
					if (2.17 && (2.12 == 0 || 2.13 < 2.12 - 1))
					{
						flag15 = true;
					}
					if (2.10 < num2)
					{
						continue;
					}
				}
				flag = true;
				1456 3 = 2.14;
				if (3 <= 1456.MovementX)
				{
					if (3 <= 1456.Colour)
					{
						switch (3)
						{
						case 1456.Movement:
							if (!flag11)
							{
								this.17 = 1052.12(2.2, 2.6, (double)num2, (double)2.9, (float)2.10, 2.15);
								if (this.53)
								{
									208 4 = 2.6 - 2.2;
									this.14 = (float)Math.Atan2((double)4.Y, (double)4.X);
									if (this.GetIsReversed())
									{
										this.14 -= 3.1415927f;
									}
								}
								flag11 = true;
							}
							break;
						case 1456.Fade:
							if (!flag9)
							{
								this.16 = 1052.11(2.1, 2.5, num2, 2.9, 2.10, 2.15);
								flag9 = true;
							}
							break;
						case 1456.Movement | 1456.Fade:
							break;
						case 1456.Scale:
							if (!flag8)
							{
								this.15 = 1052.11(2.1, 2.5, num2, 2.9, 2.10, 2.15);
								flag8 = true;
							}
							break;
						default:
							if (3 != 1456.Rotation)
							{
								if (3 == 1456.Colour)
								{
									if (!flag14)
									{
										this.6 = 1052.10(2.3, 2.7, num2, 2.9, 2.10, 2.15);
										flag14 = true;
									}
								}
							}
							else if (!flag7)
							{
								this.14 = 1052.11(2.1, 2.5, num2, 2.9, 2.10, 2.15);
								flag7 = true;
							}
							break;
						}
					}
					else if (3 != 1456.ParameterFlipHorizontal)
					{
						if (3 != 1456.ParameterFlipVertical)
						{
							if (3 == 1456.MovementX)
							{
								if (!flag12)
								{
									this.17.X = 1052.11(2.1, 2.5, num2, 2.9, 2.10, 2.15);
									flag12 = true;
								}
							}
						}
						else
						{
							bool value;
							this.43(value = true);
							flag5 = new bool?(value);
						}
					}
					else
					{
						bool value2;
						this.45(value2 = true);
						flag4 = new bool?(value2);
					}
				}
				else if (3 <= 1456.ParameterAdditive)
				{
					if (3 != 1456.MovementY)
					{
						if (3 != 1456.VectorScale)
						{
							if (3 == 1456.ParameterAdditive)
							{
								flag6 = new bool?(this.28 = true);
							}
						}
						else if (!flag8)
						{
							this.20 = 1052.12(2.2, 2.6, (double)num2, (double)2.9, (float)2.10, 2.15);
							if (flag4.GetValueOrDefault())
							{
								this.20.X = 0f - this.20.X;
							}
							if (flag5.GetValueOrDefault())
							{
								this.20.Y = 0f - this.20.Y;
							}
							flag8 = true;
						}
					}
					else if (!flag13)
					{
						this.17.Y = 1052.11(2.1, 2.5, num2, 2.9, 2.10, 2.15);
						flag13 = true;
					}
				}
				else if (3 <= 1456.ClippingHeight)
				{
					if (3 != 1456.ClippingWidth)
					{
						if (3 == 1456.ClippingHeight)
						{
							if (!flag17)
							{
								this.34 = (int)1052.11(2.1, 2.5, num2, 2.9, 2.10, 2.15);
								flag17 = true;
							}
						}
					}
					else if (!flag16)
					{
						this.35 = (int)1052.11(2.1, 2.5, num2, 2.9, 2.10, 2.15);
						flag16 = true;
					}
				}
				else if (3 != 1456.ClipRectangle)
				{
					if (3 == 1456.Blur)
					{
						if (!flag10)
						{
							this.23 = (int)1052.11(2.1, 2.5, num2, 2.9, 2.10, 2.15);
							flag10 = true;
						}
					}
				}
				else if (!flag18)
				{
					base.6(new 1058?(1052.13(2.4, 2.8, (double)num2, (double)2.9, (float)2.10, 2.15)));
					flag18 = true;
				}
			}
			if (flag15 && 1)
			{
				bool flag19 = this.5 || flag2;
				bool flag20 = false;
				bool flag21 = true;
				for (int i = num - 1; i >= 0; i--)
				{
					1445 5 = this.3[i];
					if (5.17 && (5.12 != 0 || flag19))
					{
						int num3 = 0;
						int num4 = 5.1();
						int num5 = num4 + 5.11;
						if (5.10 <= num2)
						{
							int num6 = 5.12 - 5.13 - 1;
							if (5.12 > 0 && num6 < 1)
							{
								goto IL_75E;
							}
							num3 = ((num5 != 0) ? ((num2 - 5.9) / num5) : 0);
							if (5.12 > 0)
							{
								num3 = Math.Min(num3, num6);
							}
						}
						else if (!1436.40.16 && 5.9 > num2)
						{
							int 6 = 5.13;
							if (6 < 1)
							{
								goto IL_75E;
							}
							num3 = (num2 - 5.10 - 5.11) / num5;
							num3 = Math.Max(-6, num3);
						}
						if (num3 != 0)
						{
							if (!flag20)
							{
								flag21 = 177.IsSorted<1445>(this.3, true);
							}
							5.9 += num5 * num3;
							5.10 = 5.9 + num4;
							5.13 += num3;
							if (flag21)
							{
								this.3.RemoveAt(i);
								if (this.3.Method11157(5) < i)
								{
									i++;
								}
							}
							flag20 = true;
						}
					}
					IL_75E:;
				}
				if (flag20)
				{
					if (!flag21)
					{
						this.3.Sort();
					}
					return this.30(false);
				}
			}
			if (!flag2 && !flag && !flag15 && (this.1 == (1044)0 || 1436.40.16))
			{
				this.19 = false;
				return (1069)2;
			}
			if ((!flag2 || !flag3) && !flag)
			{
				this.19 = false;
				if (this.1 == (1044)2)
				{
					return (1069)2;
				}
				return (1069)1;
			}
			else
			{
				for (int j = num - 1; j >= 0; j--)
				{
					1445 7 = this.3[j];
					if (7.10 < num2)
					{
						flag = true;
						1456 3 = 7.14;
						if (3 <= 1456.MovementX)
						{
							if (3 <= 1456.Colour)
							{
								switch (3)
								{
								case 1456.Movement:
									if (!flag11 && !flag12 && !flag13)
									{
										this.17 = 7.6;
										flag11 = true;
									}
									break;
								case 1456.Fade:
									if (!flag9)
									{
										this.16 = 7.5;
										flag9 = true;
									}
									break;
								case 1456.Movement | 1456.Fade:
									break;
								case 1456.Scale:
									if (!flag8)
									{
										this.15 = 7.5;
										flag8 = true;
									}
									break;
								default:
									if (3 != 1456.Rotation)
									{
										if (3 == 1456.Colour)
										{
											if (!flag14)
											{
												this.6 = 7.7;
												flag14 = true;
											}
										}
									}
									else if (!flag7)
									{
										this.14 = 7.5;
										flag7 = true;
									}
									break;
								}
							}
							else if (3 != 1456.ParameterFlipHorizontal)
							{
								if (3 != 1456.ParameterFlipVertical)
								{
									if (3 == 1456.MovementX)
									{
										if (!flag12)
										{
											this.17.X = 7.5;
											flag12 = true;
										}
									}
								}
								else if (flag5 == null)
								{
									bool flag22 = 7.1() == 0;
									bool value3;
									this.43(value3 = flag22);
									flag5 = new bool?(value3);
								}
							}
							else if (flag4 == null)
							{
								bool flag23 = 7.1() == 0;
								bool value4;
								this.45(value4 = flag23);
								flag4 = new bool?(value4);
							}
						}
						else if (3 <= 1456.ParameterAdditive)
						{
							if (3 != 1456.MovementY)
							{
								if (3 != 1456.VectorScale)
								{
									if (3 == 1456.ParameterAdditive)
									{
										if (flag6 == null)
										{
											bool flag24 = 7.1() == 0;
											flag6 = new bool?(this.28 = flag24);
										}
									}
								}
								else if (!flag8)
								{
									this.20 = 7.6;
									if (flag4.GetValueOrDefault())
									{
										this.20.X = 0f - this.20.X;
									}
									if (flag5.GetValueOrDefault())
									{
										this.20.Y = 0f - this.20.Y;
									}
									flag8 = true;
								}
							}
							else if (!flag13)
							{
								this.17.Y = 7.5;
								flag13 = true;
							}
						}
						else if (3 <= 1456.ClippingHeight)
						{
							if (3 != 1456.ClippingWidth)
							{
								if (3 == 1456.ClippingHeight)
								{
									if (!flag17)
									{
										this.34 = (int)7.5;
										flag17 = true;
									}
								}
							}
							else if (!flag16)
							{
								this.35 = (int)7.5;
								flag16 = true;
							}
						}
						else if (3 != 1456.ClipRectangle)
						{
							if (3 == 1456.Blur)
							{
								if (!flag10)
								{
									this.23 = (int)7.5;
									flag10 = true;
								}
							}
						}
						else if (!flag18)
						{
							base.6(new 1058?(7.8));
							flag18 = true;
						}
						if (this.1 == (1044)0 && !7.17 && this.5)
						{
							this.3.RemoveAt(j);
							num--;
						}
					}
				}
				if (flag2 && this.1 != (1044)0)
				{
					for (int k = 0; k < num; k++)
					{
						1445 8 = this.3[k];
						if (8.9 >= num2)
						{
							1456 3 = 8.14;
							if (3 <= 1456.Colour)
							{
								switch (3)
								{
								case 1456.Movement:
									if (!flag11 && !flag12 && !flag13)
									{
										this.17 = 8.2;
										flag11 = true;
									}
									break;
								case 1456.Fade:
									if (!flag9)
									{
										this.16 = 8.1;
										flag9 = true;
									}
									break;
								case 1456.Movement | 1456.Fade:
									break;
								case 1456.Scale:
									if (!flag8)
									{
										this.15 = 8.1;
										flag8 = true;
									}
									break;
								default:
									if (3 != 1456.Rotation)
									{
										if (3 == 1456.Colour)
										{
											if (!flag14)
											{
												this.6 = 8.3;
												flag14 = true;
											}
										}
									}
									else if (!flag7)
									{
										this.14 = 8.1;
										flag7 = true;
									}
									break;
								}
							}
							else if (3 != 1456.MovementX)
							{
								if (3 != 1456.MovementY)
								{
									if (3 == 1456.VectorScale)
									{
										if (!flag8)
										{
											this.20 = 8.2;
											if (flag4.GetValueOrDefault())
											{
												this.20.X = 0f - this.20.X;
											}
											if (flag5.GetValueOrDefault())
											{
												this.20.Y = 0f - this.20.Y;
											}
											flag8 = true;
										}
									}
								}
								else if (!flag13)
								{
									flag13 = true;
									this.17.Y = 8.1;
								}
							}
							else if (!flag12)
							{
								flag12 = true;
								this.17.X = 8.1;
							}
						}
					}
				}
				if (!flag)
				{
					return (1069)1;
				}
				return (1069)0;
			}
		}
	}

	// Token: 0x06004C94 RID: 19604 RVA: 0x001E54B0 File Offset: 0x001E36B0
	public override bool Draw()
	{
		if (!base.Draw())
		{
			return false;
		}
		1436.40.36(this.28);
		1381 texture = this.GetTexture();
		if (texture == null || texture.5())
		{
			return true;
		}
		if (texture.resolutionScale != 1)
		{
			this.62 *= 1f / (float)texture.resolutionScale;
			this.65.Width = this.65.Width * texture.resolutionScale;
			this.65.Height = this.65.Height * texture.resolutionScale;
			this.65.X = this.65.X * texture.resolutionScale;
			this.65.Y = this.65.Y * texture.resolutionScale;
			this.61 *= (float)texture.resolutionScale;
		}
		208 <<EMPTY_NAME>> = new 208(this.50.X + this.64.X, this.50.Y + this.64.Y);
		if (texture.gpuTexture != null)
		{
			texture.gpuTexture.2 = (this.29 ? 10497 : 33071);
			1381 2 = texture;
			if (this.23 > 0)
			{
				2 = 1358.2(texture, this.23, this.24);
			}
			2.gpuTexture.Draw(<<EMPTY_NAME>>, this.61, this.30, this.62, this.31(), new 207?(this.65), 1436.40.35());
		}
		if (1436.40.11)
		{
			1436.40.43 += this.28();
		}
		return true;
	}

	// Token: 0x06004C95 RID: 19605 RVA: 0x001E5658 File Offset: 0x001E3858
	internal float 31()
	{
		return (this.68 ? (-this.14) : this.14) + this.67;
	}

	// Token: 0x06004C96 RID: 19606 RVA: 0x001E5678 File Offset: 0x001E3878
	internal void 32(198 1, int 2)
	{
		208 3;
		208 4;
		208 5;
		208 6;
		this.48(2).12(this.31, this.14, out 3, out 4, out 5, out 6);
		1662.20.2();
		1662.20.3(3, 1);
		1662.20.3(5, 1);
		1662.20.3(5, 1);
		1662.20.3(6, 1);
		1662.20.3(6, 1);
		1662.20.3(4, 1);
		1662.20.3(4, 1);
		1662.20.3(3, 1);
		1662.20.4();
	}

	// Token: 0x06004C97 RID: 19607 RVA: 0x001E5720 File Offset: 0x001E3920
	public override string ToString()
	{
		if (this.47 != null)
		{
			return string.Concat(new string[]
			{
				this.47.2,
				" @",
				this.17.X.ToString(),
				",",
				this.17.Y.ToString(),
				") a:",
				Math.Round((double)this.16, 2).ToString(),
				" depth:",
				this.2.ToString()
			});
		}
		return base.ToString();
	}

	// Token: 0x06004C98 RID: 19608 RVA: 0x001E57C5 File Offset: 0x001E39C5
	internal virtual 1381 GetTexture()
	{
		return this.47;
	}

	// Token: 0x06004C99 RID: 19609 RVA: 0x001E57CD File Offset: 0x001E39CD
	internal virtual void SetTexture(1381 1)
	{
		if (1 != this.47)
		{
			if (this.47 != null && this.27)
			{
				this.47.Dispose();
			}
			this.47 = 1;
			this.ResetSourceRectangle();
			this.UpdateOriginOffset();
		}
	}

	// Token: 0x06004C9A RID: 19610 RVA: 0x001E5806 File Offset: 0x001E3A06
	internal override bool IsHovered()
	{
		return base.IsHovered();
	}

	// Token: 0x06004C9B RID: 19611 RVA: 0x001E5810 File Offset: 0x001E3A10
	internal override void SetHovered(bool 1)
	{
		if (1 == this.25)
		{
			return;
		}
		base.SetHovered(1);
		if (this.25)
		{
			this.33();
			if (this.57 != null)
			{
				this.57(this, null);
				return;
			}
		}
		else if (!this.25)
		{
			this.34();
			if (this.58 != null)
			{
				this.58(this, null);
			}
		}
	}

	// Token: 0x06004C9C RID: 19612 RVA: 0x001E5878 File Offset: 0x001E3A78
	private void 33()
	{
		int num = 1436.25(this);
		object <<EMPTY_NAME>>;
		if (this.42 != null)
		{
			<<EMPTY_NAME>> = 1436.2;
			lock (<<EMPTY_NAME>>)
			{
				this.3.RemoveAll(new Predicate<1445>(1433.1435.spriteCallbacks.1));
			}
			1445 2 = this.42.Clone();
			2.2 = this.17;
			1456 3 = this.42.14;
			if (3 != 1456.Fade)
			{
				if (3 != 1456.Scale)
				{
					if (3 == 1456.Rotation)
					{
						2.1 = this.14;
					}
				}
				else
				{
					2.1 = this.15;
				}
			}
			else
			{
				2.1 = this.16;
			}
			2.3 = this.6;
			int num2 = this.42.1();
			2.9 = num;
			2.10 = num + num2;
			2.16 = 1;
			this.3.Add(2);
		}
		if (this.43 == null)
		{
			return;
		}
		<<EMPTY_NAME>> = 1436.2;
		lock (<<EMPTY_NAME>>)
		{
			this.3.RemoveAll(new Predicate<1445>(1433.1435.spriteCallbacks.2));
		}
		bool flag2 = true;
		foreach (1445 4 in this.43)
		{
			1433.1434 applyHoverTransformationsClosure = new 1433.1434();
			applyHoverTransformationsClosure.1 = 4.Clone();
			if (flag2)
			{
				this.3.RemoveAll((1445 1) => 1.14 == applyHoverTransformationsClosure.1.14);
				applyHoverTransformationsClosure.1.2 = this.17;
				1456 3 = applyHoverTransformationsClosure.1.14;
				if (3 != 1456.Fade)
				{
					if (3 != 1456.Scale)
					{
						if (3 == 1456.Rotation)
						{
							applyHoverTransformationsClosure.1.1 = this.14;
						}
					}
					else
					{
						applyHoverTransformationsClosure.1.1 = this.15;
					}
				}
				else
				{
					applyHoverTransformationsClosure.1.1 = this.16;
				}
				applyHoverTransformationsClosure.1.3 = this.6;
				flag2 = false;
			}
			applyHoverTransformationsClosure.1.9 += num;
			applyHoverTransformationsClosure.1.10 += num;
			applyHoverTransformationsClosure.1.16 = 1;
			this.3.Add(applyHoverTransformationsClosure.1);
		}
	}

	// Token: 0x06004C9D RID: 19613 RVA: 0x001E5B78 File Offset: 0x001E3D78
	private void 34()
	{
		int num = 1436.25(this);
		object <<EMPTY_NAME>>;
		if (this.42 != null)
		{
			<<EMPTY_NAME>> = 1436.2;
			lock (<<EMPTY_NAME>>)
			{
				this.3.RemoveAll(new Predicate<1445>(1433.1435.spriteCallbacks.3));
			}
			1445 2 = this.42.2();
			2.2 = this.17;
			1456 3 = this.42.14;
			if (3 != 1456.Fade)
			{
				if (3 != 1456.Scale)
				{
					if (3 == 1456.Rotation)
					{
						2.1 = this.14;
					}
				}
				else
				{
					2.1 = this.15;
				}
			}
			else
			{
				2.1 = this.16;
			}
			2.3 = this.6;
			int num2 = this.42.1();
			2.9 = num;
			2.10 = num + num2;
			2.16 = 1;
			this.3.Add(2);
		}
		if (this.44 == null)
		{
			return;
		}
		<<EMPTY_NAME>> = 1436.2;
		lock (<<EMPTY_NAME>>)
		{
			this.3.RemoveAll(new Predicate<1445>(1433.1435.spriteCallbacks.4));
		}
		bool flag2 = true;
		foreach (1445 4 in this.44)
		{
			1445 5 = 4.Clone();
			if (flag2)
			{
				5.2 = this.17;
				1456 3 = 5.14;
				if (3 != 1456.Fade)
				{
					if (3 != 1456.Scale)
					{
						if (3 == 1456.Rotation)
						{
							5.1 = this.14;
						}
					}
					else
					{
						5.1 = this.15;
					}
				}
				else
				{
					5.1 = this.16;
				}
				5.3 = this.6;
				flag2 = false;
			}
			5.9 += num;
			5.10 += num;
			5.16 = 1;
			this.3.Add(5);
		}
	}

	// Token: 0x06004C9E RID: 19614 RVA: 0x001E5DB0 File Offset: 0x001E3FB0
	internal virtual void ResetSourceRectangle()
	{
		if (this.47 != null && !this.47.5())
		{
			this.39 = this.47.3();
			this.38 = this.47.4();
		}
		this.35 = this.39;
		this.34 = this.38;
		this.37 = 0;
		this.36 = 0;
	}

	// Token: 0x06004C9F RID: 19615 RVA: 0x001E5E1C File Offset: 0x001E401C
	internal virtual void UpdateOriginOffset()
	{
		switch (this.49)
		{
		case 1065.TopLeft:
			this.48 = 208.Zero;
			return;
		case 1065.Centre:
			this.48 = new 208((float)this.39 / 2f, (float)this.38 / 2f);
			return;
		case 1065.CentreLeft:
			this.48 = new 208(0f, (float)this.38 / 2f);
			return;
		case 1065.TopRight:
			this.48 = new 208((float)this.39, 0f);
			break;
		case 1065.BottomCentre:
			this.48 = new 208((float)this.39 / 2f, (float)this.38);
			return;
		case 1065.TopCentre:
			this.48 = new 208((float)this.39 / 2f, 0f);
			return;
		case 1065.Custom:
			break;
		case 1065.CentreRight:
			this.48 = new 208((float)this.39, (float)this.38 / 2f);
			return;
		case 1065.BottomLeft:
			this.48 = new 208(0f, (float)this.38);
			return;
		case 1065.BottomRight:
			this.48 = new 208((float)this.39, (float)this.38);
			return;
		default:
			return;
		}
	}

	// Token: 0x06004CA0 RID: 19616 RVA: 0x001E5F58 File Offset: 0x001E4158
	internal void 35(EventHandler 1)
	{
		EventHandler eventHandler = this.57;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, 1);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.57, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06004CA1 RID: 19617 RVA: 0x001E5F90 File Offset: 0x001E4190
	internal void 36(EventHandler 1)
	{
		EventHandler eventHandler = this.57;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, 1);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.57, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06004CA2 RID: 19618 RVA: 0x001E5FC8 File Offset: 0x001E41C8
	internal void 37(EventHandler 1)
	{
		EventHandler eventHandler = this.58;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, 1);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.58, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06004CA3 RID: 19619 RVA: 0x001E6000 File Offset: 0x001E4200
	internal void 38(EventHandler 1)
	{
		EventHandler eventHandler = this.58;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, 1);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.58, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06004CA4 RID: 19620 RVA: 0x001E6038 File Offset: 0x001E4238
	internal 1445 39(198 1, int 2, bool 3, 1046 4)
	{
		if (!3 && this.6 == 7 && this.3.Count == 0)
		{
			return null;
		}
		object 5 = 1436.2;
		lock (5)
		{
			this.3.RemoveAll((1445 1) => 1.14 == 1456.Colour);
		}
		if (2 == 0)
		{
			this.6 = 7;
			return null;
		}
		1445 6 = new 1445(this.6, 7, 1662.43(this.1) - (int)1662.82, 1662.43(this.1) + 2)
		{
			15 = 4
		};
		this.3.Add(6);
		return 6;
	}

	// Token: 0x06004CA5 RID: 19621 RVA: 0x001E610C File Offset: 0x001E430C
	internal void 40(198 1, int 2)
	{
		if (this.6 == 7)
		{
			return;
		}
		198 3 = this.6;
		object 4 = 1436.2;
		lock (4)
		{
			1445 5 = this.3.Find((1445 1) => 1.14 == 1456.Colour);
			if (5 != null && 5.16 != 51)
			{
				return;
			}
			if (5 != null)
			{
				3 = 5.7;
			}
			this.3.RemoveAll(new Predicate<1445>(1433.1435.spriteCallbacks.5));
		}
		1445 6 = new 1445(7, 3, 1662.43(this.1) - (int)1662.82, 1662.43(this.1) + 2);
		6.16 = 51;
		this.3.Add(6);
	}

	// Token: 0x06004CA6 RID: 19622 RVA: 0x001E61FC File Offset: 0x001E43FC
	internal override void ReleaseResources(bool 1)
	{
		if (this.27 && !this.59)
		{
			base.2();
			this.57 = null;
			this.58 = null;
		}
		if (this.60 != null)
		{
			this.60(this.27, null);
		}
		if (this.27 && this.47 != null)
		{
			this.47.Dispose();
			this.47 = null;
		}
		this.56 = null;
	}

	// Token: 0x06004CA7 RID: 19623 RVA: 0x001E6278 File Offset: 0x001E4478
	public virtual 1433 Clone()
	{
		1433 <<EMPTY_NAME>> = new 1433(this.GetTexture(), this.41, this.49, this.1, this.7, this.2, this.5, this.6, this.8)
		{
			48 = this.48,
			17 = this.17,
			36 = this.36,
			37 = this.37,
			35 = this.35,
			34 = this.34,
			20 = this.20,
			28 = this.28,
			47 = this.47,
			19 = this.19,
			15 = this.15,
			16 = this.16
		};
		foreach (1445 2 in this.3)
		{
			if (!2.18)
			{
				<<EMPTY_NAME>>.3.Add(2.Clone());
			}
		}
		if (this.4 != null)
		{
			<<EMPTY_NAME>>.4 = new List<1457>(this.4.Count);
			foreach (1457 3 in this.4)
			{
				<<EMPTY_NAME>>.4.Add(3.Clone());
			}
		}
		return <<EMPTY_NAME>>;
	}

	// Token: 0x06004CA8 RID: 19624 RVA: 0x001E6418 File Offset: 0x001E4618
	public void 41(EventHandler 1)
	{
		EventHandler eventHandler = this.60;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, 1);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.60, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06004CA9 RID: 19625 RVA: 0x001E644D File Offset: 0x001E464D
	public bool 42()
	{
		return this.20.Y < 0f;
	}

	// Token: 0x06004CAA RID: 19626 RVA: 0x001E6461 File Offset: 0x001E4661
	public void 43(bool 1)
	{
		if (this.42() != 1)
		{
			this.20.Y = 0f - this.20.Y;
		}
	}

	// Token: 0x06004CAB RID: 19627 RVA: 0x001E6488 File Offset: 0x001E4688
	public bool 44()
	{
		return this.20.X < 0f;
	}

	// Token: 0x06004CAC RID: 19628 RVA: 0x001E649C File Offset: 0x001E469C
	public void 45(bool 1)
	{
		if (this.44() != 1)
		{
			this.20.X = 0f - this.20.X;
		}
	}

	// Token: 0x06004CAD RID: 19629 RVA: 0x001E64C4 File Offset: 0x001E46C4
	internal void 46(bool 1, bool 2)
	{
		float num = (float)1662.70.2() / (float)this.38;
		float num2 = (float)1662.70.1() / (float)this.39;
		if (num > num2 && !2)
		{
			num2 = num;
		}
		if (this.41 != (1376)3 && this.41 != (1376)4)
		{
			num2 *= 1.6f;
			num *= 1.6f;
		}
		if ((float)this.39 / (float)this.38 > 1.34f)
		{
			this.15 = num2;
			return;
		}
		switch (1304.165.GetValue())
		{
		case 1311.Letterbox:
			this.15 = num;
			return;
		case 1311.WidescreenConservative:
			this.15 = (1 ? num2 : num);
			return;
		case 1311.WidescreenAlways:
			this.15 = num2;
			return;
		default:
			return;
		}
	}

	// Token: 0x06004CAE RID: 19630 RVA: 0x001E6580 File Offset: 0x001E4780
	public void 47(int 1, int 2, 1046 3)
	{
		if (this.3.Count == 1)
		{
			1445 4 = this.3[0];
			if (4.14 == 1456.ClippingWidth && 4.5 == (float)1 && 4.10 - 4.9 == 2)
			{
				return;
			}
		}
		object 5 = 1436.2;
		lock (5)
		{
			this.3.RemoveAll(new Predicate<1445>(1433.1435.spriteCallbacks.6));
		}
		if (this.35 != 1)
		{
			1445 6 = new 1445(1456.ClippingWidth, (float)this.35, (float)1, 1662.43(this.1) - (int)1662.82, 1662.43(this.1) + 2, (1046)0);
			6.15 = 3;
			this.3.Add(6);
		}
	}

	// Token: 0x06004CAF RID: 19631 RVA: 0x001E6668 File Offset: 0x001E4868
	internal virtual bool ContainsPoint(208 1, int 2)
	{
		return this.48(2).11(1, this.31, this.14);
	}

	// Token: 0x06004CB0 RID: 19632 RVA: 0x001E6694 File Offset: 0x001E4894
	private 1058 48(int 1)
	{
		if (1 == 0)
		{
			return this.50;
		}
		return 1058.15(this.50, Math.Max(0f, ((float)1 - this.50.Width) * 0.5f), Math.Max(0f, ((float)1 - this.50.Height) * 0.5f));
	}

	// Token: 0x040038EF RID: 14575
	internal bool 28;

	// Token: 0x040038F0 RID: 14576
	internal bool 29;

	// Token: 0x040038F1 RID: 14577
	internal 198 30;

	// Token: 0x040038F2 RID: 14578
	internal 208 31;

	// Token: 0x040038F3 RID: 14579
	private bool 32;

	// Token: 0x040038F4 RID: 14580
	internal bool 33;

	// Token: 0x040038F5 RID: 14581
	internal int 34;

	// Token: 0x040038F6 RID: 14582
	internal int 35;

	// Token: 0x040038F7 RID: 14583
	internal int 36;

	// Token: 0x040038F8 RID: 14584
	internal int 37;

	// Token: 0x040038F9 RID: 14585
	internal int 38;

	// Token: 0x040038FA RID: 14586
	internal int 39;

	// Token: 0x040038FB RID: 14587
	internal bool? 40;

	// Token: 0x040038FC RID: 14588
	internal 1376 41;

	// Token: 0x040038FD RID: 14589
	internal 1445 42;

	// Token: 0x040038FE RID: 14590
	internal List<1445> 43;

	// Token: 0x040038FF RID: 14591
	internal List<1445> 44;

	// Token: 0x04003900 RID: 14592
	internal float 45;

	// Token: 0x04003901 RID: 14593
	internal 208 46;

	// Token: 0x04003902 RID: 14594
	internal 1381 47;

	// Token: 0x04003903 RID: 14595
	internal 208 48;

	// Token: 0x04003904 RID: 14596
	internal 1065 49;

	// Token: 0x04003905 RID: 14597
	internal 1058 50;

	// Token: 0x04003906 RID: 14598
	private bool 51;

	// Token: 0x04003907 RID: 14599
	internal string 52;

	// Token: 0x04003908 RID: 14600
	internal bool 53;

	// Token: 0x04003909 RID: 14601
	internal bool 54;

	// Token: 0x0400390A RID: 14602
	internal float 55;

	// Token: 0x0400390B RID: 14603
	private 1189 56;

	// Token: 0x0400390C RID: 14604
	private EventHandler 57;

	// Token: 0x0400390D RID: 14605
	private EventHandler 58;

	// Token: 0x0400390E RID: 14606
	internal bool 59;

	// Token: 0x0400390F RID: 14607
	private EventHandler 60;

	// Token: 0x04003910 RID: 14608
	protected 208 61;

	// Token: 0x04003911 RID: 14609
	protected 208 62;

	// Token: 0x04003912 RID: 14610
	protected float 63;

	// Token: 0x04003913 RID: 14611
	protected 208 64;

	// Token: 0x04003914 RID: 14612
	private 207 65;

	// Token: 0x04003915 RID: 14613
	internal bool 66 = true;

	// Token: 0x04003916 RID: 14614
	internal float 67;

	// Token: 0x04003917 RID: 14615
	internal bool 68;

	// Token: 0x04003918 RID: 14616
	internal float 69;

	// Token: 0x02000AC7 RID: 2759
	[Serializable]
	public sealed class 1435
	{
		// Token: 0x06004CB1 RID: 19633 RVA: 0x000C2741 File Offset: 0x000C0941
		internal bool 1(1445 1)
		{
			return 1.16 == 1;
		}

		// Token: 0x06004CB2 RID: 19634 RVA: 0x000C2741 File Offset: 0x000C0941
		internal bool 2(1445 1)
		{
			return 1.16 == 1;
		}

		// Token: 0x06004CB3 RID: 19635 RVA: 0x000C2741 File Offset: 0x000C0941
		internal bool 3(1445 1)
		{
			return 1.16 == 1;
		}

		// Token: 0x06004CB4 RID: 19636 RVA: 0x000C2741 File Offset: 0x000C0941
		internal bool 4(1445 1)
		{
			return 1.16 == 1;
		}

		// Token: 0x06004CB5 RID: 19637 RVA: 0x000CB7EB File Offset: 0x000C99EB
		internal bool 5(1445 1)
		{
			return 1.14 == 1456.Colour;
		}

		// Token: 0x06004CB6 RID: 19638 RVA: 0x001E66F2 File Offset: 0x001E48F2
		internal bool 6(1445 1)
		{
			return 1.14 == 1456.ClippingWidth;
		}

		// Token: 0x04003919 RID: 14617
		public static readonly 1433.1435 spriteCallbacks = new 1433.1435();

		// Token: 0x0400391A RID: 14618
		public static Predicate<1445> predicate;

		// Token: 0x0400391B RID: 14619
		public static Predicate<1445> predicate2;

		// Token: 0x0400391C RID: 14620
		public static Predicate<1445> predicate3;

		// Token: 0x0400391D RID: 14621
		public static Predicate<1445> predicate4;

		// Token: 0x0400391E RID: 14622
		public static Predicate<1445> predicate5;

		// Token: 0x0400391F RID: 14623
		public static Predicate<1445> predicate6;

		// Token: 0x04003920 RID: 14624
		public static Predicate<1445> predicate7;

		// Token: 0x04003921 RID: 14625
		public static Predicate<1445> predicate8;

		// Token: 0x04003922 RID: 14626
		public static Predicate<1445> predicate9;
	}

	// Token: 0x02000AC8 RID: 2760
	public sealed class 1434
	{
		// Token: 0x04003923 RID: 14627
		public 1445 1;
	}
}
