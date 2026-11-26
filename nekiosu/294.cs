using System;

// Token: 0x02000235 RID: 565
public sealed class 294 : 346
{
	// Token: 0x06001171 RID: 4465 RVA: 0x0003F278 File Offset: 0x0003D478
	public 294() : base(9)
	{
	}

	// Token: 0x06001172 RID: 4466 RVA: 0x0003F282 File Offset: 0x0003D482
	public ushort GetUInt160074_195()
	{
		return this.uInt2;
	}

	// Token: 0x06001173 RID: 4467 RVA: 0x0003F28A File Offset: 0x0003D48A
	public void SetUInt160074_196(ushort 1)
	{
		this.uInt2 = 1;
	}

	// Token: 0x06001174 RID: 4468 RVA: 0x0003F293 File Offset: 0x0003D493
	public override object Method1135()
	{
		return this.GetUInt160074_195();
	}

	// Token: 0x06001175 RID: 4469 RVA: 0x0003F2A0 File Offset: 0x0003D4A0
	public override void Method1136(object 1)
	{
		if (1 is short)
		{
			this.SetUInt160074_196((ushort)((short)1));
			return;
		}
		if (1 is int)
		{
			this.SetUInt160074_196((ushort)((int)1));
			return;
		}
		if (1 is long)
		{
			this.SetUInt160074_196((ushort)((long)1));
			return;
		}
		if (1 is uint)
		{
			this.SetUInt160074_196((ushort)((uint)1));
			return;
		}
		if (1 is ulong)
		{
			this.SetUInt160074_196((ushort)((ulong)1));
			return;
		}
		if (1 is float)
		{
			this.SetUInt160074_196((ushort)((float)1));
			return;
		}
		if (1 is double)
		{
			this.SetUInt160074_196((ushort)((double)1));
			return;
		}
		this.SetUInt160074_196(Convert.ToUInt16(1));
	}

	// Token: 0x06001176 RID: 4470 RVA: 0x0003F353 File Offset: 0x0003D553
	public override 346 Method1138()
	{
		294 <<EMPTY_NAME>> = new 294();
		<<EMPTY_NAME>>.SetUInt160074_196(this.uInt2);
		<<EMPTY_NAME>>.SetType0637_1116(base.GetType0637_1115());
		return <<EMPTY_NAME>>;
	}

	// Token: 0x06001177 RID: 4471 RVA: 0x0003F374 File Offset: 0x0003D574
	public override 346 Method1137(346 1)
	{
		base.SetType0637_1116(1.GetType0637_1115());
		switch (1.GetNumber0636_1112())
		{
		case 7:
			this.SetUInt160074_196(Convert.ToUInt16(((349)1).GetValue0650_1133()));
			return this;
		case 9:
			this.SetUInt160074_196(((294)1).GetUInt160074_195());
			return this;
		case 10:
			this.SetUInt160074_196(Convert.ToUInt16(((340)1).GetEnum0597_1005()));
			return this;
		case 11:
			this.SetUInt160074_196((ushort)((288)1).GetAmount0028_108());
			return this;
		case 14:
			this.SetUInt160074_196((ushort)((uint)((329)1).GetUIntPtr0505_797()));
			return this;
		case 15:
			this.SetUInt160074_196((ushort)((327)1).GetNumber0284_789());
			return this;
		case 17:
			this.SetUInt160074_196((ushort)((285)1).GetNumber0023_90());
			return this;
		case 18:
			this.SetUInt160074_196((ushort)((320)1).GetSByte0149_302());
			return this;
		case 19:
			this.SetUInt160074_196((ushort)Convert.ToByte(((338)1).GetFlag0582_982()));
			return this;
		case 20:
			this.SetUInt160074_196((ushort)((324)1).GetInt160253_734());
			return this;
		case 21:
			this.SetUInt160074_196((ushort)((296)1).GetNumber0087_234());
			return this;
		case 22:
			this.SetUInt160074_196((ushort)((int)((298)1).GetIntPtr0108_295()));
			return this;
		case 23:
			this.SetUInt160074_196((ushort)((339)1).GetByte0596_999());
			return this;
		case 24:
			this.SetUInt160074_196((ushort)((284)1).GetAmount0020_67());
			return this;
		case 26:
			this.SetUInt160074_196((ushort)((286)1).GetNumber0024_96());
			return this;
		}
		throw new ArgumentOutOfRangeException();
	}

	// Token: 0x040008B4 RID: 2228
	private ushort uInt2;
}
