using System;

// Token: 0x02000236 RID: 566
public sealed class 296 : 346
{
	// Token: 0x06001178 RID: 4472 RVA: 0x0003F553 File Offset: 0x0003D753
	public 296() : base(21)
	{
	}

	// Token: 0x06001179 RID: 4473 RVA: 0x0003F55D File Offset: 0x0003D75D
	public uint GetNumber0087_234()
	{
		return this.number2;
	}

	// Token: 0x0600117A RID: 4474 RVA: 0x0003F565 File Offset: 0x0003D765
	public void SetNumber0087_235(uint 1)
	{
		this.number2 = 1;
	}

	// Token: 0x0600117B RID: 4475 RVA: 0x0003F56E File Offset: 0x0003D76E
	public override object Method1135()
	{
		return this.GetNumber0087_234();
	}

	// Token: 0x0600117C RID: 4476 RVA: 0x0003F57C File Offset: 0x0003D77C
	public override void Method1136(object 1)
	{
		if (1 is short)
		{
			this.SetNumber0087_235((uint)((short)1));
			return;
		}
		if (1 is int)
		{
			this.SetNumber0087_235((uint)((int)1));
			return;
		}
		if (1 is long)
		{
			this.SetNumber0087_235((uint)((long)1));
			return;
		}
		if (1 is ulong)
		{
			this.SetNumber0087_235((uint)((ulong)1));
			return;
		}
		if (1 is float)
		{
			this.SetNumber0087_235((uint)((float)1));
			return;
		}
		if (1 is double)
		{
			this.SetNumber0087_235((uint)((double)1));
			return;
		}
		this.SetNumber0087_235(Convert.ToUInt32(1));
	}

	// Token: 0x0600117D RID: 4477 RVA: 0x0003F617 File Offset: 0x0003D817
	public override 346 Method1138()
	{
		296 <<EMPTY_NAME>> = new 296();
		<<EMPTY_NAME>>.SetNumber0087_235(this.number2);
		<<EMPTY_NAME>>.SetType0637_1116(base.GetType0637_1115());
		return <<EMPTY_NAME>>;
	}

	// Token: 0x0600117E RID: 4478 RVA: 0x0003F638 File Offset: 0x0003D838
	public override 346 Method1137(346 1)
	{
		base.SetType0637_1116(1.GetType0637_1115());
		switch (1.GetNumber0636_1112())
		{
		case 7:
			this.SetNumber0087_235(Convert.ToUInt32(((349)1).GetValue0650_1133()));
			return this;
		case 9:
			this.SetNumber0087_235((uint)((294)1).GetUInt160074_195());
			return this;
		case 10:
			this.SetNumber0087_235(Convert.ToUInt32(((340)1).GetEnum0597_1005()));
			return this;
		case 11:
			this.SetNumber0087_235((uint)((288)1).GetAmount0028_108());
			return this;
		case 14:
			this.SetNumber0087_235((uint)((329)1).GetUIntPtr0505_797());
			return this;
		case 15:
			this.SetNumber0087_235((uint)((327)1).GetNumber0284_789());
			return this;
		case 17:
			this.SetNumber0087_235((uint)((285)1).GetNumber0023_90());
			return this;
		case 18:
			this.SetNumber0087_235((uint)((320)1).GetSByte0149_302());
			return this;
		case 19:
			this.SetNumber0087_235((uint)Convert.ToByte(((338)1).GetFlag0582_982()));
			return this;
		case 20:
			this.SetNumber0087_235((uint)((324)1).GetInt160253_734());
			return this;
		case 21:
			this.SetNumber0087_235(((296)1).GetNumber0087_234());
			return this;
		case 22:
			this.SetNumber0087_235((uint)((int)((298)1).GetIntPtr0108_295()));
			return this;
		case 23:
			this.SetNumber0087_235((uint)((339)1).GetByte0596_999());
			return this;
		case 24:
			this.SetNumber0087_235((uint)((284)1).GetAmount0020_67());
			return this;
		case 26:
			this.SetNumber0087_235((uint)((286)1).GetNumber0024_96());
			return this;
		}
		throw new ArgumentOutOfRangeException();
	}

	// Token: 0x040008B5 RID: 2229
	private uint number2;
}
