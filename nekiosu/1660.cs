using System;
using System.IO;
using System.Runtime.InteropServices;

// Token: 0x02000985 RID: 2437
[ComVisible(false)]
public sealed class 1660 : 1570
{
	// Token: 0x06004465 RID: 17509 RVA: 0x001B0656 File Offset: 0x001AE856
	public 1660(1653 1, bool 2, string 3, string 4, int 5, 2023 6, 2147 7)
	{
		this.5 = 1;
		this.1 = 4;
		this.6 = 3;
		this.3 = 6;
		this.4 = 7;
		this.2 = 5;
	}

	// Token: 0x06004466 RID: 17510 RVA: 0x001B068C File Offset: 0x001AE88C
	public 1660(Stream 1) : this(new 1647(1))
	{
	}

	// Token: 0x06004467 RID: 17511 RVA: 0x001B069C File Offset: 0x001AE89C
	public 1660(1647 1)
	{
		this.5 = (1653)1.ReadByte();
		this.6 = 1.ReadString();
		this.1 = 1.ReadString();
		if (2148.2 > 10)
		{
			this.3 = (2023)1.ReadUInt32();
		}
		else
		{
			this.3 = (2023)1.ReadInt16();
		}
		this.4 = (2147)Math.Max(0, Math.Min(3, 1.ReadByte()));
		this.2 = 1.ReadInt32();
	}

	// Token: 0x06004468 RID: 17512 RVA: 0x00053ADC File Offset: 0x00051CDC
	public void ReadFrom(1647 1)
	{
		throw new NotImplementedException();
	}

	// Token: 0x06004469 RID: 17513 RVA: 0x001B071C File Offset: 0x001AE91C
	public void WriteTo(1648 1)
	{
		1.Write((byte)this.5);
		1.Write(this.6);
		1.Write(this.1);
		1.Write((uint)this.3);
		1.Write((byte)this.4);
		1.Write(this.2);
	}

	// Token: 0x0600446A RID: 17514 RVA: 0x001B0773 File Offset: 0x001AE973
	internal 1660 Clone()
	{
		return (1660)base.MemberwiseClone();
	}

	// Token: 0x0400326C RID: 12908
	public string 1;

	// Token: 0x0400326D RID: 12909
	public int 2;

	// Token: 0x0400326E RID: 12910
	public 2023 3;

	// Token: 0x0400326F RID: 12911
	public 2147 4;

	// Token: 0x04003270 RID: 12912
	public 1653 5;

	// Token: 0x04003271 RID: 12913
	public string 6;
}
