using System;

// Token: 0x0200023E RID: 574
public sealed class 338 : 346
{
	// Token: 0x060011B1 RID: 4529 RVA: 0x00040627 File Offset: 0x0003E827
	public 338() : base(19)
	{
	}

	// Token: 0x060011B2 RID: 4530 RVA: 0x00040631 File Offset: 0x0003E831
	public bool GetFlag0582_982()
	{
		return this.flag2;
	}

	// Token: 0x060011B3 RID: 4531 RVA: 0x00040639 File Offset: 0x0003E839
	public void SetFlag0582_983(bool 1)
	{
		this.flag2 = 1;
	}

	// Token: 0x060011B4 RID: 4532 RVA: 0x00040642 File Offset: 0x0003E842
	public override object Method1135()
	{
		return this.GetFlag0582_982();
	}

	// Token: 0x060011B5 RID: 4533 RVA: 0x0004064F File Offset: 0x0003E84F
	public override void Method1136(object 1)
	{
		this.SetFlag0582_983(Convert.ToBoolean(1));
	}

	// Token: 0x060011B6 RID: 4534 RVA: 0x00040660 File Offset: 0x0003E860
	public override 346 Method1137(346 1)
	{
		base.SetType0637_1116(1.GetType0637_1115());
		switch (1.GetNumber0636_1112())
		{
		case 7:
			this.SetFlag0582_983(Convert.ToBoolean(((349)1).GetValue0650_1133()));
			return this;
		case 9:
			this.SetFlag0582_983(Convert.ToBoolean(((294)1).GetUInt160074_195()));
			return this;
		case 10:
			this.SetFlag0582_983(Convert.ToBoolean(((340)1).GetEnum0597_1005()));
			return this;
		case 14:
			this.SetFlag0582_983(Convert.ToBoolean(((329)1).GetUIntPtr0505_797()));
			return this;
		case 15:
			this.SetFlag0582_983(Convert.ToBoolean(((327)1).GetNumber0284_789()));
			return this;
		case 17:
			this.SetFlag0582_983(Convert.ToBoolean(((285)1).GetNumber0023_90()));
			return this;
		case 18:
			this.SetFlag0582_983(Convert.ToBoolean(((320)1).GetSByte0149_302()));
			return this;
		case 19:
			this.SetFlag0582_983(((338)1).GetFlag0582_982());
			return this;
		case 20:
			this.SetFlag0582_983(Convert.ToBoolean(((324)1).GetInt160253_734()));
			return this;
		case 21:
			this.SetFlag0582_983(Convert.ToBoolean(((296)1).GetNumber0087_234()));
			return this;
		case 22:
			this.SetFlag0582_983(Convert.ToBoolean(((298)1).GetIntPtr0108_295()));
			return this;
		case 23:
			this.SetFlag0582_983(Convert.ToBoolean(((339)1).GetByte0596_999()));
			return this;
		case 26:
			this.SetFlag0582_983(Convert.ToBoolean(((286)1).GetNumber0024_96()));
			return this;
		}
		throw new ArgumentOutOfRangeException();
	}

	// Token: 0x060011B7 RID: 4535 RVA: 0x00040839 File Offset: 0x0003EA39
	public override 346 Method1138()
	{
		338 <<EMPTY_NAME>> = new 338();
		<<EMPTY_NAME>>.SetFlag0582_983(this.flag2);
		<<EMPTY_NAME>>.SetType0637_1116(base.GetType0637_1115());
		return <<EMPTY_NAME>>;
	}

	// Token: 0x040008BD RID: 2237
	private bool flag2;
}
