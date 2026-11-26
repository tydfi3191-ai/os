using System;
using System.Collections.Generic;
using System.Threading;

// Token: 0x02000AB3 RID: 2739
public class 1417 : 1350
{
	// Token: 0x06004C00 RID: 19456 RVA: 0x001E0675 File Offset: 0x001DE875
	internal 1417(207 1, 208 2, bool 3, float 4 = 0f, 1545 5 = 1545.Default) : this(new 1058((float)1.X, (float)1.Y, (float)1.Width, (float)1.Height), 2, 3, 4, 5)
	{
	}

	// Token: 0x06004C01 RID: 19457 RVA: 0x001E06A4 File Offset: 0x001DE8A4
	internal 1417(1058 1, 208 2, bool 3, float 4 = 0f, 1545 5 = 1545.Default) : base(1662.11)
	{
		this.3 = 5;
		this.15();
		this.22 = new 1436(3);
		this.23 = new 1436(3);
		this.8 = new 1433(1662.34, (1376)6, 1065.TopLeft, (1044)0, 208.Zero, 1.1f, true, 198.TransparentWhite, null);
		this.8.10 = true;
		this.8.42 = new 1445(198.White, 198.YellowGreen, 0, 0);
		this.8.54 = true;
		this.8.15 = 1.6f;
		this.22.12(this.8);
		this.3(4);
		this.17(2);
		this.19(1);
	}

	// Token: 0x06004C02 RID: 19458 RVA: 0x001E07D3 File Offset: 0x001DE9D3
	internal bool 1()
	{
		return this.6() > 0f && this.6() < 1f;
	}

	// Token: 0x06004C03 RID: 19459 RVA: 0x001E07F1 File Offset: 0x001DE9F1
	internal float 2()
	{
		return this.16;
	}

	// Token: 0x06004C04 RID: 19460 RVA: 0x001E07F9 File Offset: 0x001DE9F9
	internal void 3(float 1)
	{
		this.16 = 1;
		this.18();
	}

	// Token: 0x06004C05 RID: 19461 RVA: 0x001E0808 File Offset: 0x001DEA08
	internal float 4()
	{
		return this.15.Height - this.16;
	}

	// Token: 0x06004C06 RID: 19462 RVA: 0x001E081C File Offset: 0x001DEA1C
	internal bool 5()
	{
		return this.6() >= 0.01f;
	}

	// Token: 0x06004C07 RID: 19463 RVA: 0x001E082E File Offset: 0x001DEA2E
	internal float 6()
	{
		return this.22.5;
	}

	// Token: 0x06004C08 RID: 19464 RVA: 0x001E083C File Offset: 0x001DEA3C
	internal void 7(float 1)
	{
		1417.1420 2 = new 1417.1420();
		2.1 = 1;
		this.22.5 = 2.1;
		this.23.5 = 2.1;
		this.24.ForEach(new Action<1436>(2.1));
	}

	// Token: 0x06004C09 RID: 19465 RVA: 0x001E088F File Offset: 0x001DEA8F
	internal bool 8()
	{
		return this.22.47;
	}

	// Token: 0x06004C0A RID: 19466 RVA: 0x001E089C File Offset: 0x001DEA9C
	internal void 9(bool 1)
	{
		this.22.47 = 1;
		this.23.47 = 1;
	}

	// Token: 0x06004C0B RID: 19467 RVA: 0x001E08B6 File Offset: 0x001DEAB6
	internal void 10(bool 1)
	{
		this.22.22 = 1;
		this.23.22 = 1;
	}

	// Token: 0x06004C0C RID: 19468 RVA: 0x001E08D0 File Offset: 0x001DEAD0
	internal virtual bool IsScrolling()
	{
		return Math.Abs(this.21) > 0.01f || this.11;
	}

	// Token: 0x06004C0D RID: 19469 RVA: 0x001E08EC File Offset: 0x001DEAEC
	internal void 11(1189 1)
	{
		1189 2 = this.27;
		1189 3;
		do
		{
			3 = 2;
			1189 value = (1189)Delegate.Combine(3, 1);
			2 = Interlocked.CompareExchange<1189>(ref this.27, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x06004C0E RID: 19470 RVA: 0x001E0924 File Offset: 0x001DEB24
	internal void 12(1189 1)
	{
		1189 2 = this.28;
		1189 3;
		do
		{
			3 = 2;
			1189 value = (1189)Delegate.Combine(3, 1);
			2 = Interlocked.CompareExchange<1189>(ref this.28, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x06004C0F RID: 19471 RVA: 0x001E0959 File Offset: 0x001DEB59
	internal bool 13()
	{
		return this.5() && this.22.35.6((float)1555.17().X, (float)1555.17().Y);
	}

	// Token: 0x06004C10 RID: 19472 RVA: 0x001E098B File Offset: 0x001DEB8B
	internal void 14()
	{
		this.15();
	}

	// Token: 0x06004C11 RID: 19473 RVA: 0x001E0994 File Offset: 0x001DEB94
	private void 15()
	{
		1535.40((1082)8, new 1081(this.OnPointerPressed), this.3, this.4);
		1535.40((1082)6, new 1081(this.OnPointerReleased), this.3, this.4);
		1535.40((1082)3, new 1081(this.OnDrag), this.3, this.4);
		1535.40((1082)2, new 1081(this.OnDragEnd), this.3, this.4);
		1535.40((1082)1, new 1081(this.OnWheelUp), this.3, this.4);
		1535.40((1082)0, new 1081(this.OnWheelDown), this.3, this.4);
	}

	// Token: 0x06004C12 RID: 19474 RVA: 0x001E0A5C File Offset: 0x001DEC5C
	private void 16()
	{
		1535.41((1082)8, new 1081(this.OnPointerPressed), this.3);
		1535.41((1082)6, new 1081(this.OnPointerReleased), this.3);
		1535.41((1082)3, new 1081(this.OnDrag), this.3);
		1535.41((1082)2, new 1081(this.OnDragEnd), this.3);
		1535.41((1082)1, new 1081(this.OnWheelUp), this.3);
		1535.41((1082)0, new 1081(this.OnWheelDown), this.3);
	}

	// Token: 0x06004C13 RID: 19475 RVA: 0x001E0AFF File Offset: 0x001DECFF
	protected virtual bool OnPointerPressed(object 1, EventArgs 2)
	{
		this.26 = (this.13() && (!this.29 || (this.22.23 == 1436.1 && 1436.1 != null)));
		return false;
	}

	// Token: 0x06004C14 RID: 19476 RVA: 0x001E0B3B File Offset: 0x001DED3B
	protected virtual bool OnPointerReleased(object 1, EventArgs 2)
	{
		this.26 = false;
		return false;
	}

	// Token: 0x06004C15 RID: 19477 RVA: 0x001E0B48 File Offset: 0x001DED48
	protected virtual bool OnWheelDown(object 1, EventArgs 2)
	{
		if (!this.5() || !this.13() || 1436.1 != null)
		{
			return false;
		}
		if (this.21 < 0f)
		{
			this.21 = 0f;
		}
		this.27(100f * this.31, 0f);
		return true;
	}

	// Token: 0x06004C16 RID: 19478 RVA: 0x001E0BA0 File Offset: 0x001DEDA0
	protected virtual bool OnWheelUp(object 1, EventArgs 2)
	{
		if (!this.5() || !this.13() || 1436.1 != null)
		{
			return false;
		}
		if (this.21 > 0f)
		{
			this.21 = 0f;
		}
		this.27(-100f * this.31, 0f);
		return true;
	}

	// Token: 0x06004C17 RID: 19479 RVA: 0x001E0BF8 File Offset: 0x001DEDF8
	protected virtual bool OnDrag(object 1, EventArgs 2)
	{
		if (!this.5() || this.33)
		{
			return false;
		}
		if (1535.70)
		{
			return false;
		}
		if (!this.11)
		{
			if (!this.26 || (!this.8.IsHovered() && (!this.10 || !this.13())))
			{
				this.33 = true;
				return false;
			}
			this.11 = true;
			this.34 = 0.0;
			this.12 = !this.8.IsHovered();
			this.13 = 1555.21() * 1662.70.8();
			this.14 = this.20 + new 208(0f, this.20.Y - this.22().Y);
		}
		if (this.11)
		{
			this.26 = false;
			if (float.IsNaN(this.21) || float.IsInfinity(this.21))
			{
				this.21 = 0f;
			}
			this.37 = ((this.21 == 0f) ? 0.5f : (0f - (float)Math.Max(0.5, 0.9959999918937683 - 0.002 / (double)Math.Abs(this.21))));
			208 3 = 1555.21() * 1662.70.8();
			if (this.32 != 208.Zero && 1662.82 > 0.0)
			{
				this.34 += 1662.82;
				float num = (float)((double)(this.32.Y - 3.Y) / this.34);
				float num2 = (float)Math.Pow((Math.Sign(num) == -Math.Sign(this.21) || Math.Abs(num) > Math.Abs(this.21)) ? 0.9 : 0.95, this.34);
				if (num != 0f)
				{
					this.34 = 0.0;
					this.21 = this.21 * num2 + (1f - num2) * num;
				}
			}
			this.32 = 3;
			if (this.12)
			{
				this.20(this.14 + (this.13 - 1555.21() * 1662.70.8()), 0.5f);
			}
			else
			{
				this.20(this.14 + (1555.21() * 1662.70.8() - this.13) * (this.17.Y - this.4()) / (this.4() - this.8.20.Y - 4f), 1f);
			}
			return true;
		}
		return false;
	}

	// Token: 0x06004C18 RID: 19480 RVA: 0x001E0EF0 File Offset: 0x001DF0F0
	protected virtual bool OnDragEnd(object 1, EventArgs 2)
	{
		this.33 = false;
		this.26 = false;
		if (this.11)
		{
			if (this.12)
			{
				this.32 = 208.Zero;
			}
			this.21 *= (float)Math.Pow(0.95, Math.Max(0.0, this.34 - 66.0));
			this.34 = 0.0;
			this.11 = false;
			1189 3 = this.27;
			if (3 != null)
			{
				3();
			}
		}
		return false;
	}

	// Token: 0x06004C19 RID: 19481 RVA: 0x001E0F88 File Offset: 0x001DF188
	internal void 17(208 1)
	{
		this.17 = 1;
		this.20(this.20, 0f);
	}

	// Token: 0x06004C1A RID: 19482 RVA: 0x001E0FA4 File Offset: 0x001DF1A4
	private void 18()
	{
		this.30 = (this.5 && this.17.Y > this.4());
		this.8.10 = this.30;
		if (this.30)
		{
			this.8.20 = new 208(6f, Math.Max(14f, this.4() / this.17.Y * this.4() - 4f));
			this.8.17 = new 208(this.6 ? (2f + this.7) : (this.15.Width - 8f - this.7), this.2() + 2f + this.20.Y / (this.17.Y - this.4()) * (this.4() - this.8.20.Y - 4f));
		}
	}

	// Token: 0x06004C1B RID: 19483 RVA: 0x001E10B8 File Offset: 0x001DF2B8
	internal void 19(1058 1)
	{
		1417.1421 2 = new 1417.1421();
		2.1 = 1;
		this.15 = 2.1;
		1417.1421 3 = 2;
		3.1.Width = 3.1.Width + this.35.X;
		1417.1421 4 = 2;
		4.1.Height = 4.1.Height + this.35.Y;
		this.22.27(2.1);
		this.23.27(2.1);
		this.24.ForEach(new Action<1436>(2.1));
		this.17(this.17);
	}

	// Token: 0x06004C1C RID: 19484 RVA: 0x001E1158 File Offset: 0x001DF358
	internal void 20(208 1, float 2)
	{
		this.20 = new 208((float)((this.6 && this.5 && this.9) ? -8 : 0), 1052.19(3.Y, this.18, Math.Max(this.18, this.17.Y - this.4())) * 2 + 3.Y * (1f - 2));
		if (float.IsNaN(this.20.X))
		{
			this.20.X = 0f;
		}
		if (float.IsNaN(this.20.Y))
		{
			this.20.Y = this.18;
		}
		this.22.29 = this.20;
		this.23.29 = this.20;
		this.24.ForEach(delegate(1436 1)
		{
			1.30 = this.20;
		});
		this.18();
	}

	// Token: 0x06004C1D RID: 19485 RVA: 0x001E1251 File Offset: 0x001DF451
	internal void Show()
	{
		this.7(1f);
	}

	// Token: 0x06004C1E RID: 19486 RVA: 0x001E125E File Offset: 0x001DF45E
	internal void Hide()
	{
		this.7(0f);
	}

	// Token: 0x06004C1F RID: 19487 RVA: 0x001E126C File Offset: 0x001DF46C
	public void 21()
	{
		if (this.5())
		{
			this.23.22();
			for (int i = this.24.Count - 1; i >= 0; i--)
			{
				if (!this.25.Contains(this.24[i]))
				{
					this.24[i].22();
				}
			}
			this.22.22();
			for (int j = this.24.Count - 1; j >= 0; j--)
			{
				if (this.25.Contains(this.24[j]))
				{
					this.24[j].22();
				}
			}
		}
	}

	// Token: 0x06004C20 RID: 19488 RVA: 0x001E1324 File Offset: 0x001DF524
	protected override void Dispose(bool 1)
	{
		this.16();
		this.22.Dispose();
		this.23.Dispose();
		this.24.ForEach(delegate(1436 1)
		{
			1.Dispose();
		});
		base.Dispose(2);
	}

	// Token: 0x06004C21 RID: 19489 RVA: 0x00005ADD File Offset: 0x00003CDD
	public override void Initialize()
	{
	}

	// Token: 0x06004C22 RID: 19490 RVA: 0x001E137E File Offset: 0x001DF57E
	private 208 22()
	{
		return new 208(0f, 1052.19(this.20.Y, this.18, Math.Max(this.18, this.17.Y - this.4())));
	}

	// Token: 0x06004C23 RID: 19491 RVA: 0x001E13BD File Offset: 0x001DF5BD
	internal bool 23()
	{
		return this.36;
	}

	// Token: 0x06004C24 RID: 19492 RVA: 0x001E13C8 File Offset: 0x001DF5C8
	internal void 24(bool 1)
	{
		if (this.36 != 1)
		{
			this.36 = 1;
			if (this.36)
			{
				this.8.FadeIn(50, (1046)0, 0);
			}
			else
			{
				this.8.16(50, (1046)0, 0);
			}
			if (this.28 != null)
			{
				this.28();
			}
		}
	}

	// Token: 0x06004C25 RID: 19493 RVA: 0x001E1420 File Offset: 0x001DF620
	public override void Update()
	{
		if (this.5())
		{
			this.24(this.30 && (this.13() || this.IsScrolling()));
			if (!this.1())
			{
				this.10(true);
			}
		}
		else
		{
			this.24(false);
			this.10(false);
		}
		if (Math.Abs(this.21) > 0.01f || !(this.22() == this.20))
		{
			this.19 = 1662.33;
			float num = this.30();
			this.20(new 208(this.20.X, this.20.Y + num * (float)1662.82), 0f);
			if (Math.Abs(num) <= 0.01f && !this.IsScrolling() && this.22() == this.20 && this.27 != null)
			{
				this.27();
			}
		}
	}

	// Token: 0x06004C26 RID: 19494 RVA: 0x001E1518 File Offset: 0x001DF718
	internal void 25(float 1, float 2)
	{
		this.37 = 2;
		if (this.37 == 0f)
		{
			this.37 = -0.98f;
		}
		float num = 1 - this.20.Y;
		if (this.37 < 0f)
		{
			this.21 = (float)Math.Sign(num) * 0.01f - num * (float)Math.Log((double)(0f - this.37));
			return;
		}
		this.21 = (float)Math.Sign(num) * (float)Math.Sqrt((double)Math.Abs(num * this.37 * 2f));
	}

	// Token: 0x06004C27 RID: 19495 RVA: 0x001E15B4 File Offset: 0x001DF7B4
	internal float 26()
	{
		if (float.IsNaN(this.21) || float.IsInfinity(this.21))
		{
			this.21 = 0f;
		}
		if (this.37 == 0f)
		{
			return 0f;
		}
		float num = (this.37 >= 0f) ? (this.20.Y + this.21 / this.37 * (this.21 / 2f) * (float)Math.Sign(this.21)) : (this.20.Y + ((float)Math.Sign(this.21) * 0.01f - this.21) / (float)Math.Log((double)(0f - this.37)));
		if (float.IsNaN(num))
		{
			throw new Exception(string.Concat(new string[]
			{
				"NaN in TargetHeight. ",
				this.20.Y.ToString(),
				" ",
				this.21.ToString(),
				" ",
				this.37.ToString()
			}));
		}
		return num;
	}

	// Token: 0x06004C28 RID: 19496 RVA: 0x001E16D8 File Offset: 0x001DF8D8
	internal void 27(float 1, float 2)
	{
		float num = this.26();
		this.25(num + 1, 2);
	}

	// Token: 0x06004C29 RID: 19497 RVA: 0x001E16F8 File Offset: 0x001DF8F8
	internal void 28(float 1)
	{
		float 2 = Math.Max(this.18, this.17.Y - this.4());
		this.25(2, 1);
	}

	// Token: 0x06004C2A RID: 19498 RVA: 0x001E172B File Offset: 0x001DF92B
	internal void 29()
	{
		this.21 = 0f;
		this.37 = -0.98f;
	}

	// Token: 0x06004C2B RID: 19499 RVA: 0x001E1744 File Offset: 0x001DF944
	private float 30()
	{
		if (this.11)
		{
			return 0f;
		}
		float num = this.21;
		float num2 = this.22().Y - this.20.Y;
		if (num2 != 0f && !this.11)
		{
			double num3 = 1.0 - 0.2 * this.38;
			if (Math.Sign(this.21) != Math.Sign(num2))
			{
				this.21 *= (float)Math.Pow(num3, 1662.10);
			}
			num = ((this.21 != num && 1662.10 > 0.0) ? ((this.21 - num) / (float)(1662.10 * Math.Log(num3))) : this.21);
		}
		else if (this.37 < 0f)
		{
			float num4 = (float)Math.Min((double)((Math.Abs(this.21) <= 0.01f) ? 0f : ((float)Math.Log((double)(0.01f / Math.Abs(this.21)), (double)(0f - this.37)))), 1662.82);
			this.21 *= (float)Math.Pow((double)(0f - this.37), (double)num4);
			num = ((num4 > 0f && this.21 != num) ? ((this.21 - num) / (float)((double)num4 * Math.Log((double)(0f - this.37)))) : this.21);
			num *= num4 / (float)1662.82;
		}
		else if (this.37 > 0f)
		{
			float num5 = Math.Abs(this.21) / this.37;
			if (this.21 > 0f)
			{
				this.21 = Math.Max(0f, this.21 - this.37 * (float)1662.82);
			}
			else if (this.21 < 0f)
			{
				this.21 = Math.Min(0f, this.21 + this.37 * (float)1662.82);
			}
			num = (num + this.21) * Math.Min(num5 / (float)1662.82, 1f) / 2f;
		}
		if (Math.Abs(num) <= 0.01f && Math.Abs(this.21) <= 0.01f && (double)Math.Abs(num2) < 0.5)
		{
			this.20(this.22(), 0f);
			num = 0f;
			this.21 = 0f;
			this.37 = -0.98f;
		}
		else if (1662.82 > 0.0)
		{
			float num6 = num2 - num2 * (float)Math.Pow(1.0 - 0.005 * this.38, 1662.82);
			num += num6 / (float)1662.82;
		}
		return num;
	}

	// Token: 0x06004C2C RID: 19500 RVA: 0x001E1A34 File Offset: 0x001DFC34
	public void 31(bool 1, bool 2)
	{
		1417.1418 3 = new 1417.1418();
		3.1 = 2;
		this.22.15(3.1);
		this.23.15(3.1);
		this.22.12(this.8);
		if (1)
		{
			this.17(208.Zero);
		}
		this.24.ForEach(new Action<1436>(3.1));
	}

	// Token: 0x06004C2D RID: 19501 RVA: 0x001E1AA6 File Offset: 0x001DFCA6
	internal void 32(1436 1)
	{
		1.27(this.15);
		1.47 = this.8();
		this.24.Add(1);
	}

	// Token: 0x06004C2E RID: 19502 RVA: 0x001E1ACC File Offset: 0x001DFCCC
	internal void 33(1436 1)
	{
		this.32(1);
		this.25.Add(1);
	}

	// Token: 0x04003890 RID: 14480
	private 1545 3;

	// Token: 0x04003891 RID: 14481
	private 1559 4 = (1559)2;

	// Token: 0x04003892 RID: 14482
	internal bool 5 = true;

	// Token: 0x04003893 RID: 14483
	internal bool 6;

	// Token: 0x04003894 RID: 14484
	internal float 7;

	// Token: 0x04003895 RID: 14485
	private readonly 1433 8;

	// Token: 0x04003896 RID: 14486
	internal bool 9 = true;

	// Token: 0x04003897 RID: 14487
	internal bool 10 = true;

	// Token: 0x04003898 RID: 14488
	internal bool 11;

	// Token: 0x04003899 RID: 14489
	private bool 12;

	// Token: 0x0400389A RID: 14490
	private 208 13;

	// Token: 0x0400389B RID: 14491
	private 208 14;

	// Token: 0x0400389C RID: 14492
	internal 1058 15;

	// Token: 0x0400389D RID: 14493
	private float 16;

	// Token: 0x0400389E RID: 14494
	internal 208 17;

	// Token: 0x0400389F RID: 14495
	internal float 18;

	// Token: 0x040038A0 RID: 14496
	internal int 19;

	// Token: 0x040038A1 RID: 14497
	internal 208 20;

	// Token: 0x040038A2 RID: 14498
	internal float 21;

	// Token: 0x040038A3 RID: 14499
	internal 1436 22;

	// Token: 0x040038A4 RID: 14500
	internal 1436 23;

	// Token: 0x040038A5 RID: 14501
	internal List<1436> 24 = new List<1436>();

	// Token: 0x040038A6 RID: 14502
	private readonly HashSet<1436> 25 = new HashSet<1436>();

	// Token: 0x040038A7 RID: 14503
	protected bool 26;

	// Token: 0x040038A8 RID: 14504
	private 1189 27;

	// Token: 0x040038A9 RID: 14505
	private 1189 28;

	// Token: 0x040038AA RID: 14506
	internal bool 29;

	// Token: 0x040038AB RID: 14507
	private bool 30;

	// Token: 0x040038AC RID: 14508
	public float 31 = 1f;

	// Token: 0x040038AD RID: 14509
	private 208 32;

	// Token: 0x040038AE RID: 14510
	protected bool 33;

	// Token: 0x040038AF RID: 14511
	private double 34;

	// Token: 0x040038B0 RID: 14512
	internal 208 35 = 208.Zero;

	// Token: 0x040038B1 RID: 14513
	private bool 36;

	// Token: 0x040038B2 RID: 14514
	private float 37 = -0.98f;

	// Token: 0x040038B3 RID: 14515
	internal double 38 = 2.0;

	// Token: 0x02000AB4 RID: 2740
	public sealed class 1420
	{
		// Token: 0x06004C30 RID: 19504 RVA: 0x001E1AF0 File Offset: 0x001DFCF0
		internal void 1(1436 1)
		{
			1.5 = this.1;
		}

		// Token: 0x040038B4 RID: 14516
		public float 1;
	}

	// Token: 0x02000AB5 RID: 2741
	[Serializable]
	public sealed class 1419
	{
		// Token: 0x040038B5 RID: 14517
		public static readonly 1417.1419 instance = new 1417.1419();

		// Token: 0x040038B6 RID: 14518
		public static Action<1436> action;
	}

	// Token: 0x02000AB6 RID: 2742
	public sealed class 1421
	{
		// Token: 0x06004C34 RID: 19508 RVA: 0x001E1B0A File Offset: 0x001DFD0A
		internal void 1(1436 1)
		{
			1.27(this.1);
		}

		// Token: 0x040038B7 RID: 14519
		public 1058 1;
	}

	// Token: 0x02000AB7 RID: 2743
	public sealed class 1418
	{
		// Token: 0x06004C36 RID: 19510 RVA: 0x001E1B18 File Offset: 0x001DFD18
		internal void 1(1436 1)
		{
			1.15(this.1);
		}

		// Token: 0x040038B8 RID: 14520
		public bool 1;
	}
}
