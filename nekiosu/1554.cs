using System;
using System.Collections.Generic;
using System.Drawing;

// Token: 0x02000A60 RID: 2656
public sealed class 1554 : 1553, 1079
{
	// Token: 0x06004965 RID: 18789 RVA: 0x001D2A30 File Offset: 0x001D0C30
	internal override bool Initialize()
	{
		if (!base.Initialize())
		{
			return false;
		}
		try
		{
			ushort num = 1136.GlobalAddAtom("MicrosoftTabletPenServiceProperty");
			if (num != 0)
			{
				1136.SetProp(1553.4, "MicrosoftTabletPenServiceProperty", 18415641);
			}
			1136.GlobalDeleteAtom(num);
			1136.RegisterTouchWindow(1553.4, 2);
		}
		catch
		{
		}
		1553.2(new 1093(this.8));
		return true;
	}

	// Token: 0x06004966 RID: 18790 RVA: 0x001D2AA4 File Offset: 0x001D0CA4
	internal override void Dispose()
	{
		1553.3(new 1093(this.8));
		base.Dispose();
	}

	// Token: 0x06004967 RID: 18791 RVA: 0x001D2ABD File Offset: 0x001D0CBD
	internal override void Update(bool 1)
	{
		this.15.Clear();
		this.15.AddRange(this.16);
		this.16.Clear();
	}

	// Token: 0x06004968 RID: 18792 RVA: 0x001D2AE6 File Offset: 0x001D0CE6
	private bool 6()
	{
		return 2486.13 || 1535.1() || 1662.78 != 1677.Play;
	}

	// Token: 0x06004969 RID: 18793 RVA: 0x001D2B04 File Offset: 0x001D0D04
	private void 7(199 1)
	{
		if (1 == 199.Pressed)
		{
			this.19 |= this.6();
		}
		if (this.19)
		{
			this.17 = 1;
		}
		else
		{
			this.18 = 1;
		}
		if (1 == 199.Pressed)
		{
			this.19 = !this.19;
		}
	}

	// Token: 0x0600496A RID: 18794 RVA: 0x001D2B54 File Offset: 0x001D0D54
	private void 8(1092 1)
	{
		Point point = 1662.13().PointToClient(1.9);
		206 2 = 1662.48();
		point.X -= 2.X;
		point.Y -= 2.Y;
		208 3 = new 208((float)point.X, (float)point.Y);
		if ((1.4 & (1091)65536U) != (1091)0U && !this.11.Contains(1.2))
		{
			if (this.11.Count < 2)
			{
				this.7(199.Pressed);
			}
			this.12 = 1.2;
			this.11.Add(1.2);
			this.10.Add(1.2, 3 / 1662.70.3());
		}
		if (this.12 == 1.2)
		{
			this.14 = point;
			this.16.Add(3);
		}
		if ((1.4 & (1091)262144U) == (1091)0U && (1.4 & (1091)2097152U) == (1091)0U)
		{
			return;
		}
		if (this.11.Contains(1.2))
		{
			if (this.11.Count <= 2)
			{
				if (this.11.Count == 1)
				{
					this.17 = 199.Released;
					this.18 = 199.Released;
					this.19 = true;
				}
				else
				{
					this.7(199.Released);
				}
			}
			this.11.Remove(1.2);
			this.10.Remove(1.2);
		}
		this.12 = ((this.11.Count == 0) ? -1 : this.11[this.11.Count - 1]);
	}

	// Token: 0x0600496B RID: 18795 RVA: 0x00005ADD File Offset: 0x00003CDD
	public void SetPosition(208 1)
	{
	}

	// Token: 0x0600496C RID: 18796 RVA: 0x001D2D08 File Offset: 0x001D0F08
	public 208 GetPosition()
	{
		return new 208((float)this.14.X, (float)this.14.Y);
	}

	// Token: 0x0600496D RID: 18797 RVA: 0x001D2D27 File Offset: 0x001D0F27
	public 199? GetLeftButton()
	{
		return new 199?(this.17);
	}

	// Token: 0x0600496E RID: 18798 RVA: 0x001D2D34 File Offset: 0x001D0F34
	public 199? GetRightButton()
	{
		return new 199?(this.18);
	}

	// Token: 0x0600496F RID: 18799 RVA: 0x001D2D44 File Offset: 0x001D0F44
	public 199? GetMiddleButton()
	{
		return null;
	}

	// Token: 0x06004970 RID: 18800 RVA: 0x001D2D5C File Offset: 0x001D0F5C
	public 199? GetBackButton()
	{
		return null;
	}

	// Token: 0x06004971 RID: 18801 RVA: 0x001D2D74 File Offset: 0x001D0F74
	public 199? GetForwardButton()
	{
		return null;
	}

	// Token: 0x06004972 RID: 18802 RVA: 0x001D2D8A File Offset: 0x001D0F8A
	public List<208> GetPositionHistory()
	{
		return this.15;
	}

	// Token: 0x06004973 RID: 18803 RVA: 0x001D2D94 File Offset: 0x001D0F94
	internal override bool IsActive()
	{
		bool flag = this.12 != -1;
		if (!flag && this.13)
		{
			flag = true;
			this.13 = false;
		}
		else if (flag)
		{
			this.13 = true;
		}
		return flag && 1662.11.2() && !1555.32;
	}

	// Token: 0x06004974 RID: 18804 RVA: 0x0001905A File Offset: 0x0001725A
	internal override int GetPriority()
	{
		return 2;
	}

	// Token: 0x040036BF RID: 14015
	internal Dictionary<int, 208> 10 = new Dictionary<int, 208>();

	// Token: 0x040036C0 RID: 14016
	private List<int> 11 = new List<int>();

	// Token: 0x040036C1 RID: 14017
	private int 12 = -1;

	// Token: 0x040036C2 RID: 14018
	private bool 13;

	// Token: 0x040036C3 RID: 14019
	private Point 14;

	// Token: 0x040036C4 RID: 14020
	private List<208> 15 = new List<208>();

	// Token: 0x040036C5 RID: 14021
	private List<208> 16 = new List<208>();

	// Token: 0x040036C6 RID: 14022
	private 199 17;

	// Token: 0x040036C7 RID: 14023
	private 199 18;

	// Token: 0x040036C8 RID: 14024
	private bool 19 = true;
}
