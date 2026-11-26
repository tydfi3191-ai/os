using System;

// Token: 0x02000BC1 RID: 3009
public sealed class 1259 : IComparable<1259>, ICloneable, 1570
{
	// Token: 0x060052C8 RID: 21192 RVA: 0x00208DD4 File Offset: 0x00206FD4
	internal 1259(double 1, double 2) : this(1, 2, (1257)4, (1226.25 != 1254.None) ? 1226.25 : 1272.5().48, 1226.61(), (1272.5() != null) ? 1272.5().79 : 100, true, (1258)0)
	{
	}

	// Token: 0x060052C9 RID: 21193 RVA: 0x00208E1E File Offset: 0x0020701E
	public 1259()
	{
		this.7 = true;
		base..ctor();
	}

	// Token: 0x060052CA RID: 21194 RVA: 0x00208E30 File Offset: 0x00207030
	internal 1259(double 1, double 2, 1257 3, 1254 4, 1253 5, int 6, bool 7, 1258 8)
	{
		this.7 = true;
		base..ctor();
		this.3 = 1;
		this.1 = 2;
		this.5 = 3;
		this.4 = ((4 == 1254.None) ? 1254.Soft : 4);
		this.2 = 5;
		this.6 = 1052.18(6, 0, 100);
		this.2(7);
		this.8 = 8;
	}

	// Token: 0x060052CB RID: 21195 RVA: 0x00208E96 File Offset: 0x00207096
	internal bool 1()
	{
		return this.7;
	}

	// Token: 0x060052CC RID: 21196 RVA: 0x00208E9E File Offset: 0x0020709E
	internal void 2(bool 1)
	{
		if (!1 && this.1 >= 0.0)
		{
			this.1 = -100.0;
		}
		this.7 = 1;
	}

	// Token: 0x060052CD RID: 21197 RVA: 0x00208ECA File Offset: 0x002070CA
	internal bool 3()
	{
		return (this.8 & (1258)1) > (1258)0;
	}

	// Token: 0x060052CE RID: 21198 RVA: 0x00208ED7 File Offset: 0x002070D7
	internal void 4(bool 1)
	{
		if (1)
		{
			this.8 |= (1258)1;
			return;
		}
		this.8 &= (1258)(-2);
	}

	// Token: 0x060052CF RID: 21199 RVA: 0x00208EFA File Offset: 0x002070FA
	internal float 5()
	{
		if (this.1 >= 0.0)
		{
			return 1f;
		}
		return 1052.19((float)(0.0 - this.1), 10f, 1000f) / 100f;
	}

	// Token: 0x060052D0 RID: 21200 RVA: 0x00208F39 File Offset: 0x00207139
	internal float 6()
	{
		if (this.1 >= 0.0)
		{
			return 1f;
		}
		return 1052.19((float)(0.0 - this.1), 10f, 10000f) / 100f;
	}

	// Token: 0x060052D1 RID: 21201 RVA: 0x00208F78 File Offset: 0x00207178
	internal double 7()
	{
		if (this.1 >= 0.0)
		{
			return 1.0;
		}
		return 100.0 / (0.0 - this.1);
	}

	// Token: 0x060052D2 RID: 21202 RVA: 0x00208FAF File Offset: 0x002071AF
	internal double 8()
	{
		if (this.1 != 0.0)
		{
			return 60000.0 / this.1;
		}
		return 0.0;
	}

	// Token: 0x060052D3 RID: 21203 RVA: 0x00208FDC File Offset: 0x002071DC
	public override bool Equals(object 1)
	{
		1259 2 = (1259)1;
		return Math.Abs(2.3 - this.3) <= double.Epsilon && 2.1() == this.1() && Math.Abs(2.1 - this.1) <= double.Epsilon && 2.3() == this.3() && 2.4 == this.4 && 2.5 == this.5 && 2.6 == this.6 && 2.2 == this.2;
	}

	// Token: 0x060052D4 RID: 21204 RVA: 0x0020908F File Offset: 0x0020728F
	public object Clone()
	{
		return new 1259(this.3, this.1, this.5, this.4, this.2, this.6, this.1(), this.8);
	}

	// Token: 0x060052D5 RID: 21205 RVA: 0x002090C8 File Offset: 0x002072C8
	public int CompareTo(1259 1)
	{
		if (this.3 == 1.3)
		{
			return 1.1().CompareTo(this.1());
		}
		return this.3.CompareTo(1.3);
	}

	// Token: 0x060052D6 RID: 21206 RVA: 0x0020910C File Offset: 0x0020730C
	public override string ToString()
	{
		return string.Format("{5}{0:00}:{1:00}:{2:00} {3}/4 {4} {6}{7}{8}", new object[]
		{
			(int)this.3 / 60000,
			(int)this.3 % 60000 / 1000,
			(int)this.3 % 1000 / 10,
			(int)this.5,
			(this.1 < 0.0) ? (Math.Round(-100.0 / this.1, 2).ToString() + "x sm") : ((60000.0 / this.1).ToString("N") + "bpm"),
			(!this.1()) ? "^ " : string.Empty,
			(this.4 == 1254.Soft) ? "S" : "N",
			(this.2 == 1253.Custom1) ? ":C1" : ((this.2 == 1253.Custom2) ? ":C2" : string.Empty),
			this.3() ? " Ki" : string.Empty
		});
	}

	// Token: 0x060052D7 RID: 21207 RVA: 0x00209253 File Offset: 0x00207453
	public void ReadFrom(1647 1)
	{
		this.1 = 1.ReadDouble();
		this.3 = 1.ReadDouble();
		this.2(1.ReadBoolean());
	}

	// Token: 0x060052D8 RID: 21208 RVA: 0x00209279 File Offset: 0x00207479
	public void WriteTo(1648 1)
	{
		1.Write(this.1);
		1.Write(this.3);
		1.Write(this.1());
	}

	// Token: 0x04003F0B RID: 16139
	internal double 1;

	// Token: 0x04003F0C RID: 16140
	internal 1253 2;

	// Token: 0x04003F0D RID: 16141
	internal double 3;

	// Token: 0x04003F0E RID: 16142
	internal 1254 4;

	// Token: 0x04003F0F RID: 16143
	internal 1257 5;

	// Token: 0x04003F10 RID: 16144
	internal int 6;

	// Token: 0x04003F11 RID: 16145
	private bool 7;

	// Token: 0x04003F12 RID: 16146
	internal 1258 8;
}
