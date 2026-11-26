using System;

// Token: 0x0200022E RID: 558
public sealed class 284 : 346
{
	// Token: 0x0600114B RID: 4427 RVA: 0x0003E4DF File Offset: 0x0003C6DF
	public 284() : base(24)
	{
	}

	// Token: 0x0600114C RID: 4428 RVA: 0x0003E4E9 File Offset: 0x0003C6E9
	public float GetAmount0020_67()
	{
		return this.amount2;
	}

	// Token: 0x0600114D RID: 4429 RVA: 0x0003E4F1 File Offset: 0x0003C6F1
	public void SetAmount0020_68(float 1)
	{
		this.amount2 = 1;
	}

	// Token: 0x0600114E RID: 4430 RVA: 0x0003E4FA File Offset: 0x0003C6FA
	public override object Method1135()
	{
		return this.GetAmount0020_67();
	}

	// Token: 0x0600114F RID: 4431 RVA: 0x0003E507 File Offset: 0x0003C707
	public override void Method1136(object 1)
	{
		this.SetAmount0020_68(Convert.ToSingle(1));
	}

	// Token: 0x06001150 RID: 4432 RVA: 0x0003E515 File Offset: 0x0003C715
	public override 346 Method1138()
	{
		284 <<EMPTY_NAME>> = new 284();
		<<EMPTY_NAME>>.SetAmount0020_68(this.amount2);
		<<EMPTY_NAME>>.SetType0637_1116(base.GetType0637_1115());
		return <<EMPTY_NAME>>;
	}

	// Token: 0x06001151 RID: 4433 RVA: 0x0003E534 File Offset: 0x0003C734
	public override 346 Method1137(346 1)
	{
		base.SetType0637_1116(1.GetType0637_1115());
		switch (1.GetNumber0636_1112())
		{
		case 7:
			this.SetAmount0020_68((float)((349)1).GetValue0650_1133());
			return this;
		case 9:
			this.SetAmount0020_68((float)((294)1).GetUInt160074_195());
			return this;
		case 10:
			this.SetAmount0020_68(Convert.ToSingle(((340)1).GetEnum0597_1005()));
			return this;
		case 11:
			this.SetAmount0020_68((float)((288)1).GetAmount0028_108());
			return this;
		case 15:
			this.SetAmount0020_68((float)((327)1).GetNumber0284_789());
			return this;
		case 17:
			this.SetAmount0020_68(((285)1).GetNumber0023_90());
			return this;
		case 18:
			this.SetAmount0020_68((float)((320)1).GetSByte0149_302());
			return this;
		case 20:
			this.SetAmount0020_68((float)((324)1).GetInt160253_734());
			return this;
		case 21:
			this.SetAmount0020_68(((296)1).GetNumber0087_234());
			return this;
		case 23:
			this.SetAmount0020_68((float)((339)1).GetByte0596_999());
			return this;
		case 24:
			this.SetAmount0020_68(((284)1).GetAmount0020_67());
			return this;
		case 26:
			this.SetAmount0020_68((float)((286)1).GetNumber0024_96());
			return this;
		}
		throw new ArgumentOutOfRangeException();
	}

	// Token: 0x040008A7 RID: 2215
	private float amount2;
}
