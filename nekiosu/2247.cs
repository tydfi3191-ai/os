using System;
using System.IO;
using System.Runtime.InteropServices;

// Token: 0x020006C1 RID: 1729
[ComVisible(false)]
[276]
public struct 2247 : 1570
{
	// Token: 0x06003385 RID: 13189 RVA: 0x0013B4C6 File Offset: 0x001396C6
	public 2247(Stream 1)
	{
		this = new 2247(new 1647(1));
	}

	// Token: 0x06003386 RID: 13190 RVA: 0x0013B4D4 File Offset: 0x001396D4
	public 2247(1647 1)
	{
		this.13 = 1.ReadInt32();
		this.9 = 1.ReadByte();
		this.2 = 1.ReadUInt16();
		this.1 = 1.ReadUInt16();
		this.3 = 1.ReadUInt16();
		this.4 = 1.ReadUInt16();
		this.5 = 1.ReadUInt16();
		this.6 = 1.ReadUInt16();
		this.14 = 1.ReadInt32();
		this.10 = 1.ReadUInt16();
		this.7 = 1.ReadUInt16();
		this.12 = 1.ReadBoolean();
		this.8 = (int)1.ReadByte();
		this.15 = (int)1.ReadByte();
		this.16 = 1.ReadBoolean();
		this.17 = (this.16 ? 1.ReadDouble() : 0.0);
		this.18 = (this.16 ? 1.ReadDouble() : 0.0);
		if (this.8 == 254)
		{
			this.8 = 0;
			this.11 = false;
			return;
		}
		this.11 = true;
	}

	// Token: 0x06003387 RID: 13191 RVA: 0x00053ADC File Offset: 0x00051CDC
	public void ReadFrom(1647 1)
	{
		throw new NotImplementedException();
	}

	// Token: 0x06003388 RID: 13192 RVA: 0x0013B5F8 File Offset: 0x001397F8
	public void WriteTo(1648 1)
	{
		1.Write(this.13);
		1.Write(this.9);
		1.Write(this.2);
		1.Write(this.1);
		1.Write(this.3);
		1.Write(this.4);
		1.Write(this.5);
		1.Write(this.6);
		1.Write(this.14);
		1.Write(this.10);
		1.Write(this.7);
		1.Write(this.12);
		1.Write((byte)(this.11 ? this.8 : 254));
		1.Write((byte)this.15);
		1.Write(this.16);
		if (this.16)
		{
			1.Write(this.17);
			1.Write(this.18);
		}
	}

	// Token: 0x04002650 RID: 9808
	public ushort 1;

	// Token: 0x04002651 RID: 9809
	public ushort 2;

	// Token: 0x04002652 RID: 9810
	public ushort 3;

	// Token: 0x04002653 RID: 9811
	public ushort 4;

	// Token: 0x04002654 RID: 9812
	public ushort 5;

	// Token: 0x04002655 RID: 9813
	public ushort 6;

	// Token: 0x04002656 RID: 9814
	public ushort 7;

	// Token: 0x04002657 RID: 9815
	public int 8;

	// Token: 0x04002658 RID: 9816
	public byte 9;

	// Token: 0x04002659 RID: 9817
	public ushort 10;

	// Token: 0x0400265A RID: 9818
	public bool 11;

	// Token: 0x0400265B RID: 9819
	public bool 12;

	// Token: 0x0400265C RID: 9820
	public int 13;

	// Token: 0x0400265D RID: 9821
	public int 14;

	// Token: 0x0400265E RID: 9822
	public int 15;

	// Token: 0x0400265F RID: 9823
	public bool 16;

	// Token: 0x04002660 RID: 9824
	public double 17;

	// Token: 0x04002661 RID: 9825
	public double 18;
}
