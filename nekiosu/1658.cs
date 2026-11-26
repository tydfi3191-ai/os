using System;
using System.Runtime.InteropServices;

// Token: 0x02000983 RID: 2435
[ComVisible(false)]
public sealed class 1658 : 1570
{
	// Token: 0x0600445C RID: 17500 RVA: 0x001B0384 File Offset: 0x001AE584
	public 1658(int 1, string 2, 1642 3, int 4, int 5, 1657 6, float 7, float 8, int 9, bool 10, 2147 11)
	{
		this.5 = 1;
		this.6 = 2;
		this.4 = 4;
		this.1 = (byte)5;
		this.2 = 6;
		this.3 = 3;
		this.7 = 7;
		this.8 = 8;
		this.9 = 9;
		this.10 = 10;
		this.11 = 11;
	}

	// Token: 0x0600445D RID: 17501 RVA: 0x001B03F0 File Offset: 0x001AE5F0
	public 1658(1647 1)
	{
		this.5 = 1.ReadInt32();
		if (this.5 < 0)
		{
			this.5 = -this.5;
		}
		else
		{
			this.10 = (this.5 != 0);
		}
		this.6 = 1.ReadString();
		this.4 = (int)(1.ReadByte() - 24);
		this.1 = 1.ReadByte();
		byte b = 1.ReadByte();
		this.2 = ((1657)b & (1657)(-225));
		this.11 = (2147)Math.Max(0, Math.Min(3, (b & 224) >> 5));
		this.7 = 1.ReadSingle();
		this.8 = 1.ReadSingle();
		this.9 = 1.ReadInt32();
	}

	// Token: 0x0600445E RID: 17502 RVA: 0x00053ADC File Offset: 0x00051CDC
	public void ReadFrom(1647 1)
	{
		throw new NotImplementedException();
	}

	// Token: 0x0600445F RID: 17503 RVA: 0x001B04B0 File Offset: 0x001AE6B0
	public void WriteTo(1648 1)
	{
		1.Write(this.10 ? this.5 : (-this.5));
		1.Write(this.6);
		1.Write((byte)(this.4 + 24));
		1.Write(this.1);
		1.Write((byte)((int)((byte)this.2 & 31) | (int)((byte)this.11 & 7) << 5));
		1.Write(this.7);
		1.Write(this.8);
		1.Write(this.9);
	}

	// Token: 0x04003258 RID: 12888
	public byte 1;

	// Token: 0x04003259 RID: 12889
	public readonly 1657 2;

	// Token: 0x0400325A RID: 12890
	public 1642 3;

	// Token: 0x0400325B RID: 12891
	public int 4;

	// Token: 0x0400325C RID: 12892
	public int 5;

	// Token: 0x0400325D RID: 12893
	public string 6;

	// Token: 0x0400325E RID: 12894
	public float 7;

	// Token: 0x0400325F RID: 12895
	public float 8;

	// Token: 0x04003260 RID: 12896
	public int 9;

	// Token: 0x04003261 RID: 12897
	public bool 10;

	// Token: 0x04003262 RID: 12898
	public 2147 11;
}
