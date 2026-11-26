using System;

// Token: 0x0200023A RID: 570
public sealed class 324 : 346
{
	// Token: 0x06001194 RID: 4500 RVA: 0x0003FDF0 File Offset: 0x0003DFF0
	public 324() : base(20)
	{
	}

	// Token: 0x06001195 RID: 4501 RVA: 0x0003FDFA File Offset: 0x0003DFFA
	public short GetInt160253_734()
	{
		return this.intValue2;
	}

	// Token: 0x06001196 RID: 4502 RVA: 0x0003FE02 File Offset: 0x0003E002
	public void SetInt160253_735(short 1)
	{
		this.intValue2 = 1;
	}

	// Token: 0x06001197 RID: 4503 RVA: 0x0003FE0B File Offset: 0x0003E00B
	public override object Method1135()
	{
		return this.GetInt160253_734();
	}

	// Token: 0x06001198 RID: 4504 RVA: 0x0003FE18 File Offset: 0x0003E018
	public override void Method1136(object 1)
	{
		if (1 is int)
		{
			this.SetInt160253_735((short)((int)1));
			return;
		}
		if (1 is long)
		{
			this.SetInt160253_735((short)((long)1));
			return;
		}
		if (1 is ushort)
		{
			this.SetInt160253_735((short)((ushort)1));
			return;
		}
		if (1 is uint)
		{
			this.SetInt160253_735((short)((uint)1));
			return;
		}
		if (1 is ulong)
		{
			this.SetInt160253_735((short)((ulong)1));
			return;
		}
		if (1 is float)
		{
			this.SetInt160253_735((short)((float)1));
			return;
		}
		if (1 is double)
		{
			this.SetInt160253_735((short)((double)1));
			return;
		}
		this.SetInt160253_735(Convert.ToInt16(1));
	}

	// Token: 0x06001199 RID: 4505 RVA: 0x0003FECB File Offset: 0x0003E0CB
	public override 346 Method1138()
	{
		324 <<EMPTY_NAME>> = new 324();
		<<EMPTY_NAME>>.SetInt160253_735(this.intValue2);
		<<EMPTY_NAME>>.SetType0637_1116(base.GetType0637_1115());
		return <<EMPTY_NAME>>;
	}

	// Token: 0x0600119A RID: 4506 RVA: 0x0003FEEC File Offset: 0x0003E0EC
	public override 346 Method1137(346 1)
	{
		base.SetType0637_1116(1.GetType0637_1115());
		switch (1.GetNumber0636_1112())
		{
		case 7:
			this.SetInt160253_735(Convert.ToInt16(((349)1).GetValue0650_1133()));
			return this;
		case 9:
			this.SetInt160253_735((short)((294)1).GetUInt160074_195());
			return this;
		case 10:
			this.SetInt160253_735(Convert.ToInt16(((340)1).GetEnum0597_1005()));
			return this;
		case 11:
			this.SetInt160253_735((short)((288)1).GetAmount0028_108());
			return this;
		case 15:
			this.SetInt160253_735((short)((327)1).GetNumber0284_789());
			return this;
		case 17:
			this.SetInt160253_735((short)((285)1).GetNumber0023_90());
			return this;
		case 18:
			this.SetInt160253_735((short)((320)1).GetSByte0149_302());
			return this;
		case 19:
			this.SetInt160253_735((short)Convert.ToByte(((338)1).GetFlag0582_982()));
			return this;
		case 20:
			this.SetInt160253_735(((324)1).GetInt160253_734());
			return this;
		case 21:
			this.SetInt160253_735((short)((296)1).GetNumber0087_234());
			return this;
		case 22:
			this.SetInt160253_735((short)((int)((298)1).GetIntPtr0108_295()));
			return this;
		case 23:
			this.SetInt160253_735((short)((339)1).GetByte0596_999());
			return this;
		case 24:
			this.SetInt160253_735((short)((284)1).GetAmount0020_67());
			return this;
		case 26:
			this.SetInt160253_735((short)((286)1).GetNumber0024_96());
			return this;
		}
		throw new ArgumentOutOfRangeException();
	}

	// Token: 0x040008B9 RID: 2233
	private short intValue2;
}
