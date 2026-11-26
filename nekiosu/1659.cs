using System;
using System.Runtime.InteropServices;

// Token: 0x02000984 RID: 2436
[ComVisible(false)]
public sealed class 1659 : 1570
{
	// Token: 0x06004460 RID: 17504 RVA: 0x000055AC File Offset: 0x000037AC
	public 1659()
	{
	}

	// Token: 0x06004461 RID: 17505 RVA: 0x001B0544 File Offset: 0x001AE744
	public 1659(1647 1)
	{
		this.8 = 1.ReadInt32();
		this.6 = new 1660(1);
		this.5 = 1.ReadInt64();
		this.1 = 1.ReadSingle();
		this.3 = 1.ReadInt32();
		this.7 = 1.ReadInt64();
		this.4 = 1.ReadInt32();
		this.9 = 1.ReadInt16();
	}

	// Token: 0x06004462 RID: 17506 RVA: 0x00053ADC File Offset: 0x00051CDC
	public void ReadFrom(1647 1)
	{
		throw new NotImplementedException();
	}

	// Token: 0x06004463 RID: 17507 RVA: 0x001B05B8 File Offset: 0x001AE7B8
	public void WriteTo(1648 1)
	{
		1.Write(this.8);
		this.6.WriteTo(1);
		1.Write(this.5);
		1.Write(this.1);
		1.Write(this.3);
		1.Write(this.7);
		1.Write(this.4);
		1.Write(this.9);
	}

	// Token: 0x06004464 RID: 17508 RVA: 0x001B0628 File Offset: 0x001AE828
	public 1659 Clone(bool 1)
	{
		1659 2 = (1659)base.MemberwiseClone();
		if (1)
		{
			2.6 = this.6.Clone();
		}
		return 2;
	}

	// Token: 0x04003263 RID: 12899
	public float 1;

	// Token: 0x04003264 RID: 12900
	public int 2;

	// Token: 0x04003265 RID: 12901
	public int 3;

	// Token: 0x04003266 RID: 12902
	public int 4;

	// Token: 0x04003267 RID: 12903
	public long 5;

	// Token: 0x04003268 RID: 12904
	public 1660 6;

	// Token: 0x04003269 RID: 12905
	public long 7;

	// Token: 0x0400326A RID: 12906
	public int 8;

	// Token: 0x0400326B RID: 12907
	public short 9;
}
