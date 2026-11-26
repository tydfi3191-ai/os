using System;
using System.Collections.Generic;

// Token: 0x02000A65 RID: 2661
public sealed class 1558 : 1553, 1079
{
	// Token: 0x060049B3 RID: 18867 RVA: 0x001D3CE2 File Offset: 0x001D1EE2
	internal bool 6()
	{
		return this.10;
	}

	// Token: 0x060049B4 RID: 18868 RVA: 0x001D3CEA File Offset: 0x001D1EEA
	private void 7(bool 1)
	{
		if (1 != this.10 && this.IsActive())
		{
			1535.14();
		}
		this.10 = 1;
	}

	// Token: 0x060049B5 RID: 18869 RVA: 0x001D3D0C File Offset: 0x001D1F0C
	internal override bool Initialize()
	{
		if (!base.Initialize())
		{
			return false;
		}
		try
		{
			1095 <<EMPTY_NAME>> = new 1095
			{
				1 = (1078)1,
				2 = (1077)2,
				3 = (1096)0,
				4 = 1553.4
			};
			if (!1136.RegisterRawInputDevices(new 1095[]
			{
				<<EMPTY_NAME>>
			}, 1, sizeof(1095)))
			{
				return false;
			}
		}
		catch
		{
		}
		1553.4(new 1097(this.8));
		return true;
	}

	// Token: 0x060049B6 RID: 18870 RVA: 0x001D3D9C File Offset: 0x001D1F9C
	internal override void Dispose()
	{
		1553.5(new 1097(this.8));
		base.Dispose();
	}

	// Token: 0x060049B7 RID: 18871 RVA: 0x001D3DB8 File Offset: 0x001D1FB8
	private void 8(1099 1)
	{
		1104 2 = 1.2;
		float num = (float)1304.139;
		this.7((2.1 & (1106)1) > (1106)0);
		if (this.6())
		{
			if (1304.205)
			{
				this.14.X = ((float)(2.5 - 32768) * num + 32768f) / 65536f * (float)1662.70.1;
				this.14.Y = ((float)(2.6 - 32768) * num + 32768f) / 65536f * (float)1662.70.2;
			}
			else
			{
				this.14 = 1558.9(2) - new 208((float)1662.94.X, (float)1662.94.Y);
				this.14.X = (this.14.X - (float)(1662.70.1 / 2)) * num + (float)(1662.70.1 / 2);
				this.14.Y = (this.14.Y - (float)(1662.70.2 / 2)) * num + (float)(1662.70.2 / 2);
			}
		}
		else
		{
			this.14.X = this.14.X + (float)2.5 * num;
			this.14.Y = this.14.Y + (float)2.6 * num;
		}
		if (1535.57)
		{
			this.14.X = 1052.19(this.14.X, 0f, (float)(1662.70.1 - 1));
			this.14.Y = 1052.19(this.14.Y, 0f, (float)(1662.70.2 - 1));
		}
		this.16.Add(this.14);
		this.13++;
		this.12 += (double)(1662.32.ElapsedMilliseconds - this.11);
	}

	// Token: 0x060049B8 RID: 18872 RVA: 0x001D3FD0 File Offset: 0x001D21D0
	internal static 208 9(1104 1)
	{
		207 2 = ((1.1 & (1106)2) > (1106)0) ? 1553.1 : new 207(1662.114.X, 1662.114.Y, 1662.113.Width, 1662.113.Height);
		return new 208((float)1.5 / 65536f * (float)2.Width + (float)2.X, (float)1.6 / 65536f * (float)2.Height + (float)2.Y);
	}

	// Token: 0x060049B9 RID: 18873 RVA: 0x001D405C File Offset: 0x001D225C
	private void 10()
	{
		if (this.13 > 0)
		{
			this.12 /= (double)this.13;
		}
		float num = (float)Math.Pow(0.9, 1662.10);
		1555.4 = 1555.4 * num + (1f - num) * ((float)this.13 / (float)1662.82 * 1000f);
		1555.2 = this.13;
		1555.3 = (int)Math.Round(this.12);
		1555.1 = this.11;
		this.13 = 0;
		this.12 = 0.0;
		this.11 = 1662.32.ElapsedMilliseconds;
	}

	// Token: 0x060049BA RID: 18874 RVA: 0x001D4114 File Offset: 0x001D2314
	internal override void Update(bool 1)
	{
		this.10();
		this.15.Clear();
		this.15.AddRange(this.16);
		this.16.Clear();
		206 2 = new 206((int)Math.Round((double)this.14.X), (int)Math.Round((double)this.14.Y));
		if (1 && !this.6() && !1555.25(2, 1))
		{
			206 3 = 1555.16();
			if (!1555.25(3, 0))
			{
				this.14.X = (float)3.X;
				this.14.Y = (float)3.Y;
				return;
			}
			1555.15(2, false);
		}
	}

	// Token: 0x060049BB RID: 18875 RVA: 0x001D41C8 File Offset: 0x001D23C8
	public void SetPosition(208 1)
	{
		this.14 = 1;
	}

	// Token: 0x060049BC RID: 18876 RVA: 0x001D41D1 File Offset: 0x001D23D1
	public 208 GetPosition()
	{
		return this.14;
	}

	// Token: 0x060049BD RID: 18877 RVA: 0x001D41DC File Offset: 0x001D23DC
	public 199? GetLeftButton()
	{
		return null;
	}

	// Token: 0x060049BE RID: 18878 RVA: 0x001D41F4 File Offset: 0x001D23F4
	public 199? GetRightButton()
	{
		return null;
	}

	// Token: 0x060049BF RID: 18879 RVA: 0x001D420C File Offset: 0x001D240C
	public 199? GetMiddleButton()
	{
		return null;
	}

	// Token: 0x060049C0 RID: 18880 RVA: 0x001D4224 File Offset: 0x001D2424
	public 199? GetBackButton()
	{
		return null;
	}

	// Token: 0x060049C1 RID: 18881 RVA: 0x001D423C File Offset: 0x001D243C
	public 199? GetForwardButton()
	{
		return null;
	}

	// Token: 0x060049C2 RID: 18882 RVA: 0x001D4252 File Offset: 0x001D2452
	public List<208> GetPositionHistory()
	{
		return this.15;
	}

	// Token: 0x060049C3 RID: 18883 RVA: 0x001D425C File Offset: 0x001D245C
	internal override bool IsActive()
	{
		return 1304.191 && 1662.11.2() && !1555.33 && (this.6() || (!1555.32 && 1555.25(1555.17(), 1)));
	}

	// Token: 0x060049C4 RID: 18884 RVA: 0x0001702D File Offset: 0x0001522D
	internal override int GetPriority()
	{
		return 1;
	}

	// Token: 0x040036F5 RID: 14069
	private bool 10;

	// Token: 0x040036F6 RID: 14070
	private long 11;

	// Token: 0x040036F7 RID: 14071
	private double 12;

	// Token: 0x040036F8 RID: 14072
	private int 13;

	// Token: 0x040036F9 RID: 14073
	private 208 14 = 208.One;

	// Token: 0x040036FA RID: 14074
	private List<208> 15 = new List<208>();

	// Token: 0x040036FB RID: 14075
	private List<208> 16 = new List<208>();
}
