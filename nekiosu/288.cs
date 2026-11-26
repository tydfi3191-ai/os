using System;

// Token: 0x02000231 RID: 561
public sealed class 288 : 346
{
	// Token: 0x06001161 RID: 4449 RVA: 0x0003EC06 File Offset: 0x0003CE06
	public 288() : base(11)
	{
	}

	// Token: 0x06001162 RID: 4450 RVA: 0x0003EC10 File Offset: 0x0003CE10
	public double GetAmount0028_108()
	{
		return this.amount2;
	}

	// Token: 0x06001163 RID: 4451 RVA: 0x0003EC18 File Offset: 0x0003CE18
	public void SetAmount0028_109(double 1)
	{
		this.amount2 = 1;
	}

	// Token: 0x06001164 RID: 4452 RVA: 0x0003EC21 File Offset: 0x0003CE21
	public override object Method1135()
	{
		return this.GetAmount0028_108();
	}

	// Token: 0x06001165 RID: 4453 RVA: 0x0003EC2E File Offset: 0x0003CE2E
	public override void Method1136(object 1)
	{
		this.SetAmount0028_109(Convert.ToDouble(1));
	}

	// Token: 0x06001166 RID: 4454 RVA: 0x0003EC3C File Offset: 0x0003CE3C
	public override 346 Method1138()
	{
		288 <<EMPTY_NAME>> = new 288();
		<<EMPTY_NAME>>.SetAmount0028_109(this.amount2);
		<<EMPTY_NAME>>.SetType0637_1116(base.GetType0637_1115());
		return <<EMPTY_NAME>>;
	}

	// Token: 0x06001167 RID: 4455 RVA: 0x0003EC5C File Offset: 0x0003CE5C
	public override 346 Method1137(346 1)
	{
		base.SetType0637_1116(1.GetType0637_1115());
		switch (1.GetNumber0636_1112())
		{
		case 7:
			this.SetAmount0028_109((double)((349)1).GetValue0650_1133());
			return this;
		case 9:
			this.SetAmount0028_109((double)((294)1).GetUInt160074_195());
			return this;
		case 11:
			this.SetAmount0028_109(((288)1).GetAmount0028_108());
			return this;
		case 15:
			this.SetAmount0028_109((double)((327)1).GetNumber0284_789());
			return this;
		case 17:
			this.SetAmount0028_109(((285)1).GetNumber0023_90());
			return this;
		case 18:
			this.SetAmount0028_109((double)((320)1).GetSByte0149_302());
			return this;
		case 20:
			this.SetAmount0028_109((double)((324)1).GetInt160253_734());
			return this;
		case 21:
			this.SetAmount0028_109(((296)1).GetNumber0087_234());
			return this;
		case 23:
			this.SetAmount0028_109((double)((339)1).GetByte0596_999());
			return this;
		case 24:
			this.SetAmount0028_109((double)((284)1).GetAmount0020_67());
			return this;
		case 26:
			this.SetAmount0028_109((double)((286)1).GetNumber0024_96());
			return this;
		}
		throw new ArgumentOutOfRangeException();
	}

	// Token: 0x040008AA RID: 2218
	private double amount2;
}
