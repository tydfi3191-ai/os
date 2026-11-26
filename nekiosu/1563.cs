using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;

// Token: 0x02000A6A RID: 2666
public sealed class 1563 : 1083, 1079
{
	// Token: 0x060049EF RID: 18927 RVA: 0x001D4808 File Offset: 0x001D2A08
	internal override bool Initialize()
	{
		if (1304.188 == string.Empty)
		{
			this.3();
		}
		else
		{
			string[] array = 1304.188.Split(new char[]
			{
				':'
			});
			this.12 = new 208(float.Parse(array[0]), float.Parse(array[1]));
			this.11 = new 208(float.Parse(array[2]), float.Parse(array[3]));
			this.1 = true;
		}
		new Thread(new ThreadStart(this.1))
		{
			IsBackground = true
		}.Start();
		return true;
	}

	// Token: 0x060049F0 RID: 18928 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal override void Dispose()
	{
	}

	// Token: 0x060049F1 RID: 18929 RVA: 0x001D489F File Offset: 0x001D2A9F
	internal override void OnWindowSizeChanged()
	{
		this.3();
		base.OnWindowSizeChanged();
	}

	// Token: 0x060049F2 RID: 18930 RVA: 0x00005ADD File Offset: 0x00003CDD
	public void SetPosition(208 1)
	{
	}

	// Token: 0x060049F3 RID: 18931 RVA: 0x001D48AD File Offset: 0x001D2AAD
	public 208 GetPosition()
	{
		return new 208((float)this.5, (float)this.6);
	}

	// Token: 0x060049F4 RID: 18932 RVA: 0x001D48C2 File Offset: 0x001D2AC2
	public 199? GetLeftButton()
	{
		return new 199?(this.14);
	}

	// Token: 0x060049F5 RID: 18933 RVA: 0x001D48CF File Offset: 0x001D2ACF
	public 199? GetRightButton()
	{
		return new 199?(this.15);
	}

	// Token: 0x060049F6 RID: 18934 RVA: 0x001D48DC File Offset: 0x001D2ADC
	public 199? GetMiddleButton()
	{
		return null;
	}

	// Token: 0x060049F7 RID: 18935 RVA: 0x001D48F4 File Offset: 0x001D2AF4
	public 199? GetBackButton()
	{
		return null;
	}

	// Token: 0x060049F8 RID: 18936 RVA: 0x001D490C File Offset: 0x001D2B0C
	public 199? GetForwardButton()
	{
		return null;
	}

	// Token: 0x060049F9 RID: 18937 RVA: 0x001D465E File Offset: 0x001D285E
	public List<208> GetPositionHistory()
	{
		return new List<208>();
	}

	// Token: 0x060049FA RID: 18938 RVA: 0x001D4924 File Offset: 0x001D2B24
	internal override bool IsActive()
	{
		bool flag = 1304.87 && this.1 && (this.4 || this.13 == 199.Pressed);
		if (!flag && this.2)
		{
			flag = true;
			this.2 = false;
		}
		else if (flag)
		{
			this.2 = true;
		}
		return flag && 1662.11.2() && !1555.32;
	}

	// Token: 0x060049FB RID: 18939 RVA: 0x0001905A File Offset: 0x0001725A
	internal override int GetPriority()
	{
		return 2;
	}

	// Token: 0x060049FC RID: 18940 RVA: 0x001D4998 File Offset: 0x001D2B98
	internal override void Update(bool 1)
	{
		this.14 = 199.Released;
		this.15 = 199.Released;
		if (this.4)
		{
			this.3 = (2486.13 || 1535.1() || 1662.78 != 1677.Play || !this.3);
			if (this.3)
			{
				this.14 = 199.Pressed;
			}
			else
			{
				this.15 = 199.Pressed;
			}
			this.4 = false;
			return;
		}
		if (this.3 && this.13 == 199.Pressed)
		{
			this.14 = this.13;
			return;
		}
		if (!this.3 && this.13 == 199.Pressed)
		{
			this.15 = this.13;
		}
	}

	// Token: 0x060049FD RID: 18941 RVA: 0x001D4A40 File Offset: 0x001D2C40
	private void 1()
	{
		try
		{
			this.2();
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x060049FE RID: 18942 RVA: 0x001D4A68 File Offset: 0x001D2C68
	private unsafe void 2()
	{
		uint[] array = new uint[32];
		int num;
		1563.EloGetScreenInfo(array, out num);
		1563.1565 <<EMPTY_NAME>> = default(1563.1565);
		uint num2 = array[0];
		bool flag = false;
		int num3 = 0;
		int num4 = 0;
		for (;;)
		{
			1563.EloGetTouch(&<<EMPTY_NAME>>, false, (1563.1564)4, ref num2);
			if (!this.1)
			{
				this.4(<<EMPTY_NAME>>);
			}
			else
			{
				this.5 = (int)(((float)<<EMPTY_NAME>>.1 - this.11.X) / this.12.X);
				this.6 = (int)(((float)<<EMPTY_NAME>>.2 - this.11.Y) / this.12.Y);
				if (!flag)
				{
					if (<<EMPTY_NAME>>.3 > num3)
					{
						flag = true;
						this.4 = true;
					}
				}
				else if (<<EMPTY_NAME>>.3 <= Math.Max(12, num4 - (2486.14 ? 20 : 100)))
				{
					flag = false;
					num4 = 0;
				}
				if (flag && <<EMPTY_NAME>>.3 > num4)
				{
					num4 = <<EMPTY_NAME>>.3;
				}
				this.13 = ((<<EMPTY_NAME>>.4 != (1563.1566)4) ? 199.Pressed : 199.Released);
				num3 = <<EMPTY_NAME>>.3;
			}
		}
	}

	// Token: 0x060049FF RID: 18943 RVA: 0x001D4B6F File Offset: 0x001D2D6F
	internal void 3()
	{
		1763.2("Touchscreen Input Enabled - Please calibrate by touching top-left and bottom-right corners", 20000, (1389)0);
		this.1 = false;
		this.7 = 206.GetZero();
		this.9 = 206.GetZero();
		1304.188 = string.Empty;
	}

	// Token: 0x06004A00 RID: 18944 RVA: 0x001D4BA8 File Offset: 0x001D2DA8
	private void 4(1563.1565 1)
	{
		Thread.Sleep(50);
		206 2 = 1555.16();
		if (this.7.X == 0)
		{
			if (2.X < 200)
			{
				this.7.X = 1.1;
				this.8.X = 2.X;
			}
		}
		else if (2.X > 600)
		{
			this.9.X = 1.1;
			this.10.X = 2.X;
		}
		if (this.7.Y == 0)
		{
			if (2.Y < 200)
			{
				this.7.Y = 1.2;
				this.8.Y = 2.Y;
			}
		}
		else if (2.Y > 600)
		{
			this.9.Y = 1.2;
			this.10.Y = 2.Y;
		}
		if (this.9.X > 0 && this.9.Y > 0)
		{
			this.1 = true;
			this.12.X = (float)(this.9.X - this.7.X) / (float)(this.10.X - this.8.X);
			this.12.Y = (float)(this.9.Y - this.7.Y) / (float)(this.10.Y - this.8.Y);
			this.11.X = (float)this.7.X - (float)this.8.X * this.12.X;
			this.11.Y = (float)this.7.Y - (float)this.8.Y * this.12.Y;
			1304.188 = string.Concat(new string[]
			{
				this.12.X.ToString(1662.18),
				":",
				this.12.Y.ToString(1662.18),
				":",
				this.11.X.ToString(1662.18),
				":",
				this.11.Y.ToString(1662.18)
			});
			1763.2("Touchscreen Calibration Complete!", 2000, (1389)0);
		}
	}

	// Token: 0x06004A01 RID: 18945
	[SuppressUnmanagedCodeSecurity]
	[SuppressUnmanagedCodeSecurity]
	[DllImport("EloPubIf.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern int EloGetScreenInfo(uint[] 1, out int 2);

	// Token: 0x06004A02 RID: 18946
	[SuppressUnmanagedCodeSecurity]
	[SuppressUnmanagedCodeSecurity]
	[DllImport("EloPubIf.dll", CallingConvention = CallingConvention.Cdecl)]
	private unsafe static extern int EloGetTouch(1563.1565* 1, bool 2, 1563.1564 3, ref uint 4);

	// Token: 0x04003705 RID: 14085
	private bool 1;

	// Token: 0x04003706 RID: 14086
	private bool 2;

	// Token: 0x04003707 RID: 14087
	private bool 3;

	// Token: 0x04003708 RID: 14088
	private bool 4;

	// Token: 0x04003709 RID: 14089
	private int 5;

	// Token: 0x0400370A RID: 14090
	private int 6;

	// Token: 0x0400370B RID: 14091
	private 206 7;

	// Token: 0x0400370C RID: 14092
	private 206 8;

	// Token: 0x0400370D RID: 14093
	private 206 9;

	// Token: 0x0400370E RID: 14094
	private 206 10;

	// Token: 0x0400370F RID: 14095
	private 208 11;

	// Token: 0x04003710 RID: 14096
	private 208 12;

	// Token: 0x04003711 RID: 14097
	private 199 13;

	// Token: 0x04003712 RID: 14098
	private 199 14;

	// Token: 0x04003713 RID: 14099
	private 199 15;

	// Token: 0x02000A6B RID: 2667
	public enum 1566
	{

	}

	// Token: 0x02000A6C RID: 2668
	public enum 1564
	{

	}

	// Token: 0x02000A6D RID: 2669
	public struct 1565
	{
		// Token: 0x04003716 RID: 14102
		public int 1;

		// Token: 0x04003717 RID: 14103
		public int 2;

		// Token: 0x04003718 RID: 14104
		public int 3;

		// Token: 0x04003719 RID: 14105
		public 1563.1566 4;
	}
}
