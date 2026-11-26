using System;

// Token: 0x02000245 RID: 581
public sealed class 347 : 346
{
	// Token: 0x060011E0 RID: 4576 RVA: 0x00041275 File Offset: 0x0003F475
	public 347() : base(4)
	{
	}

	// Token: 0x060011E1 RID: 4577 RVA: 0x0004127E File Offset: 0x0003F47E
	public char GetChar0638_1117()
	{
		return this.charValue2;
	}

	// Token: 0x060011E2 RID: 4578 RVA: 0x00041286 File Offset: 0x0003F486
	public void SetChar0638_1118(char 1)
	{
		this.charValue2 = 1;
	}

	// Token: 0x060011E3 RID: 4579 RVA: 0x0004128F File Offset: 0x0003F48F
	public override object Method1135()
	{
		return this.GetChar0638_1117();
	}

	// Token: 0x060011E4 RID: 4580 RVA: 0x0004129C File Offset: 0x0003F49C
	public override void Method1136(object 1)
	{
		this.SetChar0638_1118(Convert.ToChar(1));
	}

	// Token: 0x060011E5 RID: 4581 RVA: 0x000412AC File Offset: 0x0003F4AC
	public override 346 Method1137(346 1)
	{
		base.SetType0637_1116(1.GetType0637_1115());
		switch (1.GetNumber0636_1112())
		{
		case 4:
			this.SetChar0638_1118(((347)1).GetChar0638_1117());
			return this;
		case 7:
			this.SetChar0638_1118(Convert.ToChar(((349)1).GetValue0650_1133()));
			return this;
		case 9:
			this.SetChar0638_1118((char)((294)1).GetUInt160074_195());
			return this;
		case 10:
			this.SetChar0638_1118(Convert.ToChar(((340)1).GetEnum0597_1005()));
			return this;
		case 14:
			this.SetChar0638_1118((char)((uint)((329)1).GetUIntPtr0505_797()));
			return this;
		case 15:
			this.SetChar0638_1118((char)((327)1).GetNumber0284_789());
			return this;
		case 17:
			this.SetChar0638_1118((char)((285)1).GetNumber0023_90());
			return this;
		case 18:
			this.SetChar0638_1118((char)((320)1).GetSByte0149_302());
			return this;
		case 19:
			this.SetChar0638_1118(Convert.ToChar(((338)1).GetFlag0582_982()));
			return this;
		case 20:
			this.SetChar0638_1118((char)((324)1).GetInt160253_734());
			return this;
		case 21:
			this.SetChar0638_1118((char)((296)1).GetNumber0087_234());
			return this;
		case 22:
			this.SetChar0638_1118((char)((int)((298)1).GetIntPtr0108_295()));
			return this;
		case 23:
			this.SetChar0638_1118((char)((339)1).GetByte0596_999());
			return this;
		case 26:
			this.SetChar0638_1118((char)((286)1).GetNumber0024_96());
			return this;
		}
		throw new ArgumentOutOfRangeException();
	}

	// Token: 0x060011E6 RID: 4582 RVA: 0x0004147F File Offset: 0x0003F67F
	public override 346 Method1138()
	{
		347 <<EMPTY_NAME>> = new 347();
		<<EMPTY_NAME>>.SetChar0638_1118(this.charValue2);
		<<EMPTY_NAME>>.SetType0637_1116(base.GetType0637_1115());
		return <<EMPTY_NAME>>;
	}

	// Token: 0x040008C6 RID: 2246
	private char charValue2;
}
