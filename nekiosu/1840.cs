using System;
using System.IO;
using System.Runtime.InteropServices;

// Token: 0x02000874 RID: 2164
[ComVisible(false)]
public sealed class 1840 : 1570
{
	// Token: 0x06003E65 RID: 15973 RVA: 0x0018628F File Offset: 0x0018448F
	public 1840(int 1, float 2, float 3, 1572 4)
	{
		this.1 = 2;
		this.2 = 3;
		this.9 = 4;
		this.1(4);
		this.10 = 1;
	}

	// Token: 0x06003E66 RID: 15974 RVA: 0x001862BC File Offset: 0x001844BC
	public 1840(Stream 1) : this(new 1647(1))
	{
	}

	// Token: 0x06003E67 RID: 15975 RVA: 0x001862CC File Offset: 0x001844CC
	public 1840(1647 1)
	{
		this.9 = (1572)1.ReadByte();
		this.1(this.9);
		if (1.ReadByte() > 0)
		{
			this.1(1572.Right1);
		}
		this.1 = 1.ReadSingle();
		this.2 = 1.ReadSingle();
		this.10 = 1.ReadInt32();
	}

	// Token: 0x06003E68 RID: 15976 RVA: 0x0018632C File Offset: 0x0018452C
	public void 1(1572 1)
	{
		this.9 = 1;
		this.3 = ((1 & (1572.Left1 | 1572.Left2)) > 1572.None);
		this.5 = ((1 & 1572.Left1) > 1572.None);
		this.7 = ((1 & 1572.Left2) > 1572.None);
		this.4 = ((1 & (1572.Right1 | 1572.Right2)) > 1572.None);
		this.6 = ((1 & 1572.Right1) > 1572.None);
		this.8 = ((1 & 1572.Right2) > 1572.None);
	}

	// Token: 0x06003E69 RID: 15977 RVA: 0x00053ADC File Offset: 0x00051CDC
	public void ReadFrom(1647 1)
	{
		throw new NotImplementedException();
	}

	// Token: 0x06003E6A RID: 15978 RVA: 0x00186389 File Offset: 0x00184589
	public void WriteTo(1648 1)
	{
		1.Write((byte)this.9);
		1.Write(0);
		1.Write(this.1);
		1.Write(this.2);
		1.Write(this.10);
	}

	// Token: 0x06003E6B RID: 15979 RVA: 0x001863C4 File Offset: 0x001845C4
	public override string ToString()
	{
		return string.Format("{0}\t({1},{2})\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}\t{9}", new object[]
		{
			this.10,
			this.1,
			this.2,
			this.3,
			this.4,
			this.5,
			this.6,
			this.7,
			this.8,
			this.9
		});
	}

	// Token: 0x04002DB1 RID: 11697
	public float 1;

	// Token: 0x04002DB2 RID: 11698
	public float 2;

	// Token: 0x04002DB3 RID: 11699
	public bool 3;

	// Token: 0x04002DB4 RID: 11700
	public bool 4;

	// Token: 0x04002DB5 RID: 11701
	public bool 5;

	// Token: 0x04002DB6 RID: 11702
	public bool 6;

	// Token: 0x04002DB7 RID: 11703
	public bool 7;

	// Token: 0x04002DB8 RID: 11704
	public bool 8;

	// Token: 0x04002DB9 RID: 11705
	public 1572 9;

	// Token: 0x04002DBA RID: 11706
	public int 10;
}
