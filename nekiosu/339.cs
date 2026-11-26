using System;

// Token: 0x0200023F RID: 575
public sealed class 339 : 346
{
	// Token: 0x060011B8 RID: 4536 RVA: 0x00040858 File Offset: 0x0003EA58
	public 339() : base(23)
	{
	}

	// Token: 0x060011B9 RID: 4537 RVA: 0x00040862 File Offset: 0x0003EA62
	public byte GetByte0596_999()
	{
		return this.byteValue2;
	}

	// Token: 0x060011BA RID: 4538 RVA: 0x0004086A File Offset: 0x0003EA6A
	public void SetByte0596_1000(byte 1)
	{
		this.byteValue2 = 1;
	}

	// Token: 0x060011BB RID: 4539 RVA: 0x00040873 File Offset: 0x0003EA73
	public override 346 Method1138()
	{
		339 <<EMPTY_NAME>> = new 339();
		<<EMPTY_NAME>>.SetByte0596_1000(this.byteValue2);
		<<EMPTY_NAME>>.SetType0637_1116(base.GetType0637_1115());
		return <<EMPTY_NAME>>;
	}

	// Token: 0x060011BC RID: 4540 RVA: 0x00040892 File Offset: 0x0003EA92
	public override object Method1135()
	{
		return this.GetByte0596_999();
	}

	// Token: 0x060011BD RID: 4541 RVA: 0x000408A0 File Offset: 0x0003EAA0
	public override void Method1136(object 1)
	{
		if (1 is short)
		{
			this.SetByte0596_1000((byte)((short)1));
			return;
		}
		if (1 is int)
		{
			this.SetByte0596_1000((byte)((int)1));
			return;
		}
		if (1 is long)
		{
			this.SetByte0596_1000((byte)((long)1));
			return;
		}
		if (1 is ushort)
		{
			this.SetByte0596_1000((byte)((ushort)1));
			return;
		}
		if (1 is uint)
		{
			this.SetByte0596_1000((byte)((uint)1));
			return;
		}
		if (1 is ulong)
		{
			this.SetByte0596_1000((byte)((ulong)1));
			return;
		}
		if (1 is float)
		{
			this.SetByte0596_1000((byte)((float)1));
			return;
		}
		if (1 is double)
		{
			this.SetByte0596_1000((byte)((double)1));
			return;
		}
		this.SetByte0596_1000(Convert.ToByte(1));
	}

	// Token: 0x060011BE RID: 4542 RVA: 0x0004096C File Offset: 0x0003EB6C
	public override 346 Method1137(346 1)
	{
		base.SetType0637_1116(1.GetType0637_1115());
		switch (1.GetNumber0636_1112())
		{
		case 7:
			this.SetByte0596_1000(Convert.ToByte(((349)1).GetValue0650_1133()));
			return this;
		case 9:
			this.SetByte0596_1000((byte)((294)1).GetUInt160074_195());
			return this;
		case 10:
			this.SetByte0596_1000(Convert.ToByte(((340)1).GetEnum0597_1005()));
			return this;
		case 11:
			this.SetByte0596_1000((byte)((288)1).GetAmount0028_108());
			return this;
		case 14:
			this.SetByte0596_1000((byte)((uint)((329)1).GetUIntPtr0505_797()));
			return this;
		case 15:
			this.SetByte0596_1000((byte)((327)1).GetNumber0284_789());
			return this;
		case 17:
			this.SetByte0596_1000((byte)((285)1).GetNumber0023_90());
			return this;
		case 18:
			this.SetByte0596_1000((byte)((320)1).GetSByte0149_302());
			return this;
		case 19:
			this.SetByte0596_1000(Convert.ToByte(((338)1).GetFlag0582_982()));
			return this;
		case 20:
			this.SetByte0596_1000((byte)((324)1).GetInt160253_734());
			return this;
		case 21:
			this.SetByte0596_1000((byte)((296)1).GetNumber0087_234());
			return this;
		case 22:
			this.SetByte0596_1000((byte)((int)((298)1).GetIntPtr0108_295()));
			return this;
		case 23:
			this.SetByte0596_1000(((339)1).GetByte0596_999());
			return this;
		case 24:
			this.SetByte0596_1000((byte)((284)1).GetAmount0020_67());
			return this;
		case 26:
			this.SetByte0596_1000((byte)((286)1).GetNumber0024_96());
			return this;
		}
		throw new ArgumentOutOfRangeException();
	}

	// Token: 0x040008BE RID: 2238
	private byte byteValue2;
}
