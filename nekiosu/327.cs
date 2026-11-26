using System;

// Token: 0x0200023B RID: 571
public sealed class 327 : 346
{
	// Token: 0x0600119B RID: 4507 RVA: 0x000400AE File Offset: 0x0003E2AE
	public 327() : base(15)
	{
	}

	// Token: 0x0600119C RID: 4508 RVA: 0x000400B8 File Offset: 0x0003E2B8
	public 327(int 1) : this()
	{
		this.number2 = 1;
	}

	// Token: 0x0600119D RID: 4509 RVA: 0x000400C7 File Offset: 0x0003E2C7
	public int GetNumber0284_789()
	{
		return this.number2;
	}

	// Token: 0x0600119E RID: 4510 RVA: 0x000400CF File Offset: 0x0003E2CF
	public void SetNumber0284_790(int 1)
	{
		this.number2 = 1;
	}

	// Token: 0x0600119F RID: 4511 RVA: 0x000400D8 File Offset: 0x0003E2D8
	public override object Method1135()
	{
		return this.GetNumber0284_789();
	}

	// Token: 0x060011A0 RID: 4512 RVA: 0x000400E8 File Offset: 0x0003E2E8
	public override void Method1136(object 1)
	{
		if (1 is long)
		{
			this.SetNumber0284_790((int)((long)1));
			return;
		}
		if (1 is ushort)
		{
			this.SetNumber0284_790((int)((ushort)1));
			return;
		}
		if (1 is uint)
		{
			this.SetNumber0284_790((int)((uint)1));
			return;
		}
		if (1 is ulong)
		{
			this.SetNumber0284_790((int)((ulong)1));
			return;
		}
		if (1 is float)
		{
			this.SetNumber0284_790((int)((float)1));
			return;
		}
		if (1 is double)
		{
			this.SetNumber0284_790((int)((double)1));
			return;
		}
		this.SetNumber0284_790(Convert.ToInt32(1));
	}

	// Token: 0x060011A1 RID: 4513 RVA: 0x00040183 File Offset: 0x0003E383
	public override 346 Method1138()
	{
		327 <<EMPTY_NAME>> = new 327();
		<<EMPTY_NAME>>.SetNumber0284_790(this.number2);
		<<EMPTY_NAME>>.SetType0637_1116(base.GetType0637_1115());
		return <<EMPTY_NAME>>;
	}

	// Token: 0x060011A2 RID: 4514 RVA: 0x000401A4 File Offset: 0x0003E3A4
	public override 346 Method1137(346 1)
	{
		base.SetType0637_1116(1.GetType0637_1115());
		switch (1.GetNumber0636_1112())
		{
		case 7:
			this.SetNumber0284_790(Convert.ToInt32(((349)1).GetValue0650_1133()));
			return this;
		case 9:
			this.SetNumber0284_790((int)((294)1).GetUInt160074_195());
			return this;
		case 10:
			this.SetNumber0284_790(Convert.ToInt32(((340)1).GetEnum0597_1005()));
			return this;
		case 11:
			this.SetNumber0284_790((int)((288)1).GetAmount0028_108());
			return this;
		case 14:
			this.SetNumber0284_790((int)((uint)((329)1).GetUIntPtr0505_797()));
			return this;
		case 15:
			this.SetNumber0284_790(((327)1).GetNumber0284_789());
			return this;
		case 17:
			this.SetNumber0284_790((int)((285)1).GetNumber0023_90());
			return this;
		case 18:
			this.SetNumber0284_790((int)((320)1).GetSByte0149_302());
			return this;
		case 19:
			this.SetNumber0284_790((int)Convert.ToByte(((338)1).GetFlag0582_982()));
			return this;
		case 20:
			this.SetNumber0284_790((int)((324)1).GetInt160253_734());
			return this;
		case 21:
			this.SetNumber0284_790((int)((296)1).GetNumber0087_234());
			return this;
		case 22:
			this.SetNumber0284_790((int)((298)1).GetIntPtr0108_295());
			return this;
		case 23:
			this.SetNumber0284_790((int)((339)1).GetByte0596_999());
			return this;
		case 24:
			this.SetNumber0284_790((int)((284)1).GetAmount0020_67());
			return this;
		case 26:
			this.SetNumber0284_790(Convert.ToInt32(((286)1).GetNumber0024_96()));
			return this;
		}
		throw new ArgumentOutOfRangeException();
	}

	// Token: 0x040008BA RID: 2234
	private int number2;
}
