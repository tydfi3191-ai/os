using System;

// Token: 0x02000230 RID: 560
public sealed class 286 : 346
{
	// Token: 0x06001159 RID: 4441 RVA: 0x0003E972 File Offset: 0x0003CB72
	public 286() : base(26)
	{
	}

	// Token: 0x0600115A RID: 4442 RVA: 0x0003E97C File Offset: 0x0003CB7C
	public 286(long 1) : this()
	{
		this.number2 = 1;
	}

	// Token: 0x0600115B RID: 4443 RVA: 0x0003E98B File Offset: 0x0003CB8B
	public long GetNumber0024_96()
	{
		return this.number2;
	}

	// Token: 0x0600115C RID: 4444 RVA: 0x0003E993 File Offset: 0x0003CB93
	public void SetNumber0024_97(long 1)
	{
		this.number2 = 1;
	}

	// Token: 0x0600115D RID: 4445 RVA: 0x0003E99C File Offset: 0x0003CB9C
	public override object Method1135()
	{
		return this.GetNumber0024_96();
	}

	// Token: 0x0600115E RID: 4446 RVA: 0x0003E9AC File Offset: 0x0003CBAC
	public override void Method1136(object 1)
	{
		if (1 is ulong)
		{
			this.SetNumber0024_97((long)((ulong)1));
			return;
		}
		if (1 is float)
		{
			this.SetNumber0024_97((long)((float)1));
			return;
		}
		if (1 is double)
		{
			this.SetNumber0024_97((long)((double)1));
			return;
		}
		this.SetNumber0024_97(Convert.ToInt64(1));
	}

	// Token: 0x0600115F RID: 4447 RVA: 0x0003EA06 File Offset: 0x0003CC06
	public override 346 Method1138()
	{
		286 <<EMPTY_NAME>> = new 286();
		<<EMPTY_NAME>>.SetNumber0024_97(this.number2);
		<<EMPTY_NAME>>.SetType0637_1116(base.GetType0637_1115());
		return <<EMPTY_NAME>>;
	}

	// Token: 0x06001160 RID: 4448 RVA: 0x0003EA28 File Offset: 0x0003CC28
	public override 346 Method1137(346 1)
	{
		base.SetType0637_1116(1.GetType0637_1115());
		switch (1.GetNumber0636_1112())
		{
		case 7:
			this.SetNumber0024_97(Convert.ToInt64(((349)1).GetValue0650_1133()));
			return this;
		case 9:
			this.SetNumber0024_97((long)((ulong)((294)1).GetUInt160074_195()));
			return this;
		case 10:
			this.SetNumber0024_97(Convert.ToInt64(((340)1).GetEnum0597_1005()));
			return this;
		case 11:
			this.SetNumber0024_97((long)((288)1).GetAmount0028_108());
			return this;
		case 14:
			this.SetNumber0024_97((long)((ulong)((329)1).GetUIntPtr0505_797()));
			return this;
		case 15:
			this.SetNumber0024_97((long)((327)1).GetNumber0284_789());
			return this;
		case 17:
			this.SetNumber0024_97((long)((285)1).GetNumber0023_90());
			return this;
		case 18:
			this.SetNumber0024_97((long)((320)1).GetSByte0149_302());
			return this;
		case 19:
			this.SetNumber0024_97((long)((ulong)Convert.ToByte(((338)1).GetFlag0582_982())));
			return this;
		case 20:
			this.SetNumber0024_97((long)((324)1).GetInt160253_734());
			return this;
		case 21:
			this.SetNumber0024_97((long)((ulong)((296)1).GetNumber0087_234()));
			return this;
		case 22:
			this.SetNumber0024_97((long)((298)1).GetIntPtr0108_295());
			return this;
		case 23:
			this.SetNumber0024_97((long)((ulong)((339)1).GetByte0596_999()));
			return this;
		case 24:
			this.SetNumber0024_97((long)((284)1).GetAmount0020_67());
			return this;
		case 26:
			this.SetNumber0024_97(((286)1).GetNumber0024_96());
			return this;
		}
		throw new ArgumentOutOfRangeException();
	}

	// Token: 0x040008A9 RID: 2217
	private long number2;
}
