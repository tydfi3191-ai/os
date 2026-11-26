using System;

// Token: 0x0200023C RID: 572
public sealed class 329 : 346
{
	// Token: 0x060011A3 RID: 4515 RVA: 0x00040381 File Offset: 0x0003E581
	public 329() : base(14)
	{
	}

	// Token: 0x060011A4 RID: 4516 RVA: 0x0004038B File Offset: 0x0003E58B
	public UIntPtr GetUIntPtr0505_797()
	{
		return this.uIntPtr2;
	}

	// Token: 0x060011A5 RID: 4517 RVA: 0x00040393 File Offset: 0x0003E593
	public void SetUIntPtr0505_798(UIntPtr 1)
	{
		this.uIntPtr2 = 1;
	}

	// Token: 0x060011A6 RID: 4518 RVA: 0x0004039C File Offset: 0x0003E59C
	public override 346 Method1138()
	{
		329 <<EMPTY_NAME>> = new 329();
		<<EMPTY_NAME>>.SetUIntPtr0505_798(this.uIntPtr2);
		<<EMPTY_NAME>>.SetType0637_1116(base.GetType0637_1115());
		return <<EMPTY_NAME>>;
	}

	// Token: 0x060011A7 RID: 4519 RVA: 0x000403BB File Offset: 0x0003E5BB
	public override object Method1135()
	{
		return this.GetUIntPtr0505_797();
	}

	// Token: 0x060011A8 RID: 4520 RVA: 0x000403C8 File Offset: 0x0003E5C8
	public override void Method1136(object 1)
	{
		this.SetUIntPtr0505_798((UIntPtr)1);
	}

	// Token: 0x060011A9 RID: 4521 RVA: 0x000403D8 File Offset: 0x0003E5D8
	public override 346 Method1137(346 1)
	{
		base.SetType0637_1116(1.GetType0637_1115());
		switch (1.GetNumber0636_1112())
		{
		case 7:
			this.SetUIntPtr0505_798((UIntPtr)((349)1).GetValue0650_1133());
			return this;
		case 9:
			this.SetUIntPtr0505_798((UIntPtr)((uint)((294)1).GetUInt160074_195()));
			return this;
		case 10:
			this.SetUIntPtr0505_798(new UIntPtr(Convert.ToUInt64(((340)1).GetEnum0597_1005())));
			return this;
		case 11:
			this.SetUIntPtr0505_798((UIntPtr)((ulong)((288)1).GetAmount0028_108()));
			return this;
		case 14:
			this.SetUIntPtr0505_798(((329)1).GetUIntPtr0505_797());
			return this;
		case 15:
			this.SetUIntPtr0505_798((UIntPtr)((ulong)((long)((327)1).GetNumber0284_789())));
			return this;
		case 17:
			this.SetUIntPtr0505_798((UIntPtr)((285)1).GetNumber0023_90());
			return this;
		case 21:
			this.SetUIntPtr0505_798((UIntPtr)((296)1).GetNumber0087_234());
			return this;
		case 23:
			this.SetUIntPtr0505_798((UIntPtr)((uint)((339)1).GetByte0596_999()));
			return this;
		case 24:
			this.SetUIntPtr0505_798((UIntPtr)((ulong)((284)1).GetAmount0020_67()));
			return this;
		case 26:
			this.SetUIntPtr0505_798((UIntPtr)((ulong)((286)1).GetNumber0024_96()));
			return this;
		}
		throw new ArgumentOutOfRangeException();
	}

	// Token: 0x040008BB RID: 2235
	private UIntPtr uIntPtr2;
}
