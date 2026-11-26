using System;

// Token: 0x02000240 RID: 576
public sealed class 340 : 346
{
	// Token: 0x060011BF RID: 4543 RVA: 0x00040B4C File Offset: 0x0003ED4C
	public 340() : base(10)
	{
	}

	// Token: 0x060011C0 RID: 4544 RVA: 0x00040B56 File Offset: 0x0003ED56
	public 340(Enum 1) : this()
	{
		this.enumValue2 = (Enum)(1 ?? 340.341.Value);
	}

	// Token: 0x060011C1 RID: 4545 RVA: 0x00040B74 File Offset: 0x0003ED74
	public Enum GetEnum0597_1005()
	{
		return this.enumValue2;
	}

	// Token: 0x060011C2 RID: 4546 RVA: 0x00040B7C File Offset: 0x0003ED7C
	public void Method1006(Enum 1)
	{
		if (1 == null)
		{
			throw new ArgumentException();
		}
		this.enumValue2 = 1;
	}

	// Token: 0x060011C3 RID: 4547 RVA: 0x00040B8E File Offset: 0x0003ED8E
	public override object Method1135()
	{
		return this.GetEnum0597_1005();
	}

	// Token: 0x060011C4 RID: 4548 RVA: 0x00040B96 File Offset: 0x0003ED96
	public override void Method1136(object 1)
	{
		this.Method1006((Enum)Enum.Parse(this.GetEnum0597_1005().GetType(), 1.ToString()));
	}

	// Token: 0x060011C5 RID: 4549 RVA: 0x00040BBC File Offset: 0x0003EDBC
	public override 346 Method1137(346 1)
	{
		base.SetType0637_1116(1.GetType0637_1115());
		int number0636_ = 1.GetNumber0636_1112();
		switch (number0636_)
		{
		case 7:
			this.Method1006((Enum)Enum.ToObject(this.enumValue2.GetType(), ((349)1).GetValue0650_1133()));
			return this;
		case 8:
		case 11:
		case 12:
		case 13:
		case 14:
		case 16:
		case 19:
		case 22:
			break;
		case 9:
			this.Method1006((Enum)Enum.ToObject(this.enumValue2.GetType(), ((294)1).GetUInt160074_195()));
			return this;
		case 10:
		{
			Type type = this.enumValue2.GetType();
			Enum enum0597_ = ((340)1).GetEnum0597_1005();
			if (enum0597_.GetType() == type)
			{
				this.Method1006(enum0597_);
				return this;
			}
			this.Method1006((Enum)Enum.ToObject(type, enum0597_));
			return this;
		}
		case 15:
			this.Method1006((Enum)Enum.ToObject(this.enumValue2.GetType(), ((327)1).GetNumber0284_789()));
			return this;
		case 17:
			this.Method1006((Enum)Enum.ToObject(this.enumValue2.GetType(), ((285)1).GetNumber0023_90()));
			return this;
		case 18:
			this.Method1006((Enum)Enum.ToObject(this.enumValue2.GetType(), ((320)1).GetSByte0149_302()));
			return this;
		case 20:
			this.Method1006((Enum)Enum.ToObject(this.enumValue2.GetType(), ((324)1).GetInt160253_734()));
			return this;
		case 21:
			this.Method1006((Enum)Enum.ToObject(this.enumValue2.GetType(), ((296)1).GetNumber0087_234()));
			return this;
		case 23:
			this.Method1006((Enum)Enum.ToObject(this.enumValue2.GetType(), ((339)1).GetByte0596_999()));
			return this;
		default:
			if (number0636_ == 26)
			{
				this.Method1006((Enum)Enum.ToObject(this.enumValue2.GetType(), ((286)1).GetNumber0024_96()));
				return this;
			}
			break;
		}
		throw new ArgumentOutOfRangeException();
	}

	// Token: 0x060011C6 RID: 4550 RVA: 0x00040DF7 File Offset: 0x0003EFF7
	public override 346 Method1138()
	{
		340 <<EMPTY_NAME>> = new 340(this.enumValue2);
		<<EMPTY_NAME>>.SetType0637_1116(base.GetType0637_1115());
		return <<EMPTY_NAME>>;
	}

	// Token: 0x040008BF RID: 2239
	private Enum enumValue2;

	// Token: 0x02000241 RID: 577
	public enum 341
	{
		// Token: 0x040008C1 RID: 2241
		Value
	}
}
