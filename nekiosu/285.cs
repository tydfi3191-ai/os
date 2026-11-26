using System;

// Token: 0x0200022F RID: 559
public sealed class 285 : 346
{
	// Token: 0x06001152 RID: 4434 RVA: 0x0003E6C3 File Offset: 0x0003C8C3
	public 285() : base(17)
	{
	}

	// Token: 0x06001153 RID: 4435 RVA: 0x0003E6CD File Offset: 0x0003C8CD
	public ulong GetNumber0023_90()
	{
		return this.number2;
	}

	// Token: 0x06001154 RID: 4436 RVA: 0x0003E6D5 File Offset: 0x0003C8D5
	public void SetNumber0023_91(ulong 1)
	{
		this.number2 = 1;
	}

	// Token: 0x06001155 RID: 4437 RVA: 0x0003E6DE File Offset: 0x0003C8DE
	public override object Method1135()
	{
		return this.GetNumber0023_90();
	}

	// Token: 0x06001156 RID: 4438 RVA: 0x0003E6EC File Offset: 0x0003C8EC
	public override void Method1136(object 1)
	{
		if (1 is short)
		{
			this.SetNumber0023_91((ulong)((long)((short)1)));
			return;
		}
		if (1 is int)
		{
			this.SetNumber0023_91((ulong)((long)((int)1)));
			return;
		}
		if (1 is long)
		{
			this.SetNumber0023_91((ulong)((long)1));
			return;
		}
		if (1 is float)
		{
			this.SetNumber0023_91((ulong)((float)1));
			return;
		}
		if (1 is double)
		{
			this.SetNumber0023_91((ulong)((double)1));
			return;
		}
		this.SetNumber0023_91(Convert.ToUInt64(1));
	}

	// Token: 0x06001157 RID: 4439 RVA: 0x0003E772 File Offset: 0x0003C972
	public override 346 Method1138()
	{
		285 <<EMPTY_NAME>> = new 285();
		<<EMPTY_NAME>>.SetNumber0023_91(this.number2);
		<<EMPTY_NAME>>.SetType0637_1116(base.GetType0637_1115());
		return <<EMPTY_NAME>>;
	}

	// Token: 0x06001158 RID: 4440 RVA: 0x0003E794 File Offset: 0x0003C994
	public override 346 Method1137(346 1)
	{
		base.SetType0637_1116(1.GetType0637_1115());
		switch (1.GetNumber0636_1112())
		{
		case 7:
			this.SetNumber0023_91(Convert.ToUInt64(((349)1).GetValue0650_1133()));
			return this;
		case 9:
			this.SetNumber0023_91((ulong)((294)1).GetUInt160074_195());
			return this;
		case 10:
			this.SetNumber0023_91(Convert.ToUInt64(((340)1).GetEnum0597_1005()));
			return this;
		case 11:
			this.SetNumber0023_91((ulong)((288)1).GetAmount0028_108());
			return this;
		case 14:
			this.SetNumber0023_91((ulong)((329)1).GetUIntPtr0505_797());
			return this;
		case 15:
			this.SetNumber0023_91((ulong)((long)((327)1).GetNumber0284_789()));
			return this;
		case 17:
			this.SetNumber0023_91(((285)1).GetNumber0023_90());
			return this;
		case 18:
			this.SetNumber0023_91((ulong)((long)((320)1).GetSByte0149_302()));
			return this;
		case 19:
			this.SetNumber0023_91((ulong)Convert.ToByte(((338)1).GetFlag0582_982()));
			return this;
		case 20:
			this.SetNumber0023_91((ulong)((long)((324)1).GetInt160253_734()));
			return this;
		case 21:
			this.SetNumber0023_91((ulong)((296)1).GetNumber0087_234());
			return this;
		case 22:
			this.SetNumber0023_91((ulong)((long)((298)1).GetIntPtr0108_295()));
			return this;
		case 23:
			this.SetNumber0023_91((ulong)((339)1).GetByte0596_999());
			return this;
		case 24:
			this.SetNumber0023_91((ulong)((284)1).GetAmount0020_67());
			return this;
		case 26:
			this.SetNumber0023_91((ulong)((286)1).GetNumber0024_96());
			return this;
		}
		throw new ArgumentOutOfRangeException();
	}

	// Token: 0x040008A8 RID: 2216
	private ulong number2;
}
