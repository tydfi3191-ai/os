using System;
using System.Runtime.InteropServices;

// Token: 0x02000A42 RID: 2626
[ComVisible(false)]
public struct 1519 : 1570
{
	// Token: 0x060048BC RID: 18620 RVA: 0x001CDCBC File Offset: 0x001CBEBC
	public 1519(string 1, int 2, int 3, byte[] 4, DateTime 5, DateTime 6)
	{
		this = default(1519);
		this.2(1);
		this.6(2);
		this.4(3);
		this.8(4);
		this.10(5);
		this.12(6);
	}

	// Token: 0x060048BD RID: 18621 RVA: 0x001CDCF2 File Offset: 0x001CBEF2
	public string 1()
	{
		return this.1;
	}

	// Token: 0x060048BE RID: 18622 RVA: 0x001CDCFA File Offset: 0x001CBEFA
	private void 2(string 1)
	{
		this.1 = 1;
	}

	// Token: 0x060048BF RID: 18623 RVA: 0x001CDD03 File Offset: 0x001CBF03
	public int 3()
	{
		return this.2;
	}

	// Token: 0x060048C0 RID: 18624 RVA: 0x001CDD0B File Offset: 0x001CBF0B
	private void 4(int 1)
	{
		this.2 = 1;
	}

	// Token: 0x060048C1 RID: 18625 RVA: 0x001CDD14 File Offset: 0x001CBF14
	public int 5()
	{
		return this.3;
	}

	// Token: 0x060048C2 RID: 18626 RVA: 0x001CDD1C File Offset: 0x001CBF1C
	private void 6(int 1)
	{
		this.3 = 1;
	}

	// Token: 0x060048C3 RID: 18627 RVA: 0x001CDD25 File Offset: 0x001CBF25
	public byte[] 7()
	{
		return this.4;
	}

	// Token: 0x060048C4 RID: 18628 RVA: 0x001CDD2D File Offset: 0x001CBF2D
	private void 8(byte[] 1)
	{
		this.4 = 1;
	}

	// Token: 0x060048C5 RID: 18629 RVA: 0x001CDD36 File Offset: 0x001CBF36
	public DateTime 9()
	{
		return this.5;
	}

	// Token: 0x060048C6 RID: 18630 RVA: 0x001CDD3E File Offset: 0x001CBF3E
	private void 10(DateTime 1)
	{
		this.5 = 1;
	}

	// Token: 0x060048C7 RID: 18631 RVA: 0x001CDD47 File Offset: 0x001CBF47
	public DateTime 11()
	{
		return this.6;
	}

	// Token: 0x060048C8 RID: 18632 RVA: 0x001CDD4F File Offset: 0x001CBF4F
	private void 12(DateTime 1)
	{
		this.6 = 1;
	}

	// Token: 0x060048C9 RID: 18633 RVA: 0x001CDD58 File Offset: 0x001CBF58
	public void ReadFrom(1647 1)
	{
		this.2(1.ReadString());
		this.4(1.ReadInt32());
		this.6(1.ReadInt32());
		this.8(1.1());
		this.10((DateTime)1.6());
		this.12((DateTime)1.6());
	}

	// Token: 0x060048CA RID: 18634 RVA: 0x001CDDB8 File Offset: 0x001CBFB8
	public void WriteTo(1648 1)
	{
		1.Write(this.1());
		1.Write(this.3());
		1.Write(this.5());
		1.6(this.7());
		1.4(this.9());
		1.4(this.11());
	}

	// Token: 0x040035B1 RID: 13745
	private string 1;

	// Token: 0x040035B2 RID: 13746
	private int 2;

	// Token: 0x040035B3 RID: 13747
	private int 3;

	// Token: 0x040035B4 RID: 13748
	private byte[] 4;

	// Token: 0x040035B5 RID: 13749
	private DateTime 5;

	// Token: 0x040035B6 RID: 13750
	private DateTime 6;
}
