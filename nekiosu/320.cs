using System;

// Token: 0x02000238 RID: 568
public sealed class 320 : 346
{
	// Token: 0x06001186 RID: 4486 RVA: 0x0003FA57 File Offset: 0x0003DC57
	public 320() : base(18)
	{
	}

	// Token: 0x06001187 RID: 4487 RVA: 0x0003FA61 File Offset: 0x0003DC61
	public sbyte GetSByte0149_302()
	{
		return this.sByte2;
	}

	// Token: 0x06001188 RID: 4488 RVA: 0x0003FA69 File Offset: 0x0003DC69
	public void SetSByte0149_303(sbyte 1)
	{
		this.sByte2 = 1;
	}

	// Token: 0x06001189 RID: 4489 RVA: 0x0003FA72 File Offset: 0x0003DC72
	public override object Method1135()
	{
		return this.GetSByte0149_302();
	}

	// Token: 0x0600118A RID: 4490 RVA: 0x0003FA80 File Offset: 0x0003DC80
	public override void Method1136(object 1)
	{
		if (1 is byte)
		{
			this.SetSByte0149_303((sbyte)((byte)1));
			return;
		}
		if (1 is short)
		{
			this.SetSByte0149_303((sbyte)((short)1));
			return;
		}
		if (1 is int)
		{
			this.SetSByte0149_303((sbyte)((int)1));
			return;
		}
		if (1 is long)
		{
			this.SetSByte0149_303((sbyte)((long)1));
			return;
		}
		if (1 is ushort)
		{
			this.SetSByte0149_303((sbyte)((ushort)1));
			return;
		}
		if (1 is uint)
		{
			this.SetSByte0149_303((sbyte)((uint)1));
			return;
		}
		if (1 is ulong)
		{
			this.SetSByte0149_303((sbyte)((ulong)1));
			return;
		}
		if (1 is float)
		{
			this.SetSByte0149_303((sbyte)((float)1));
			return;
		}
		if (1 is double)
		{
			this.SetSByte0149_303((sbyte)((double)1));
			return;
		}
		this.SetSByte0149_303(Convert.ToSByte(1));
	}

	// Token: 0x0600118B RID: 4491 RVA: 0x0003FB5F File Offset: 0x0003DD5F
	public override 346 Method1138()
	{
		320 <<EMPTY_NAME>> = new 320();
		<<EMPTY_NAME>>.SetSByte0149_303(this.sByte2);
		<<EMPTY_NAME>>.SetType0637_1116(base.GetType0637_1115());
		return <<EMPTY_NAME>>;
	}

	// Token: 0x0600118C RID: 4492 RVA: 0x0003FB80 File Offset: 0x0003DD80
	public override 346 Method1137(346 1)
	{
		base.SetType0637_1116(1.GetType0637_1115());
		switch (1.GetNumber0636_1112())
		{
		case 7:
			this.SetSByte0149_303(Convert.ToSByte(((349)1).GetValue0650_1133()));
			return this;
		case 9:
			this.SetSByte0149_303((sbyte)((294)1).GetUInt160074_195());
			return this;
		case 10:
			this.SetSByte0149_303(Convert.ToSByte(((340)1).GetEnum0597_1005()));
			return this;
		case 11:
			this.SetSByte0149_303((sbyte)((288)1).GetAmount0028_108());
			return this;
		case 15:
			this.SetSByte0149_303((sbyte)((327)1).GetNumber0284_789());
			return this;
		case 17:
			this.SetSByte0149_303((sbyte)((285)1).GetNumber0023_90());
			return this;
		case 18:
			this.SetSByte0149_303(((320)1).GetSByte0149_302());
			return this;
		case 19:
			this.SetSByte0149_303(Convert.ToSByte(((338)1).GetFlag0582_982()));
			return this;
		case 20:
			this.SetSByte0149_303((sbyte)((324)1).GetInt160253_734());
			return this;
		case 21:
			this.SetSByte0149_303((sbyte)((296)1).GetNumber0087_234());
			return this;
		case 22:
			this.SetSByte0149_303((sbyte)((int)((298)1).GetIntPtr0108_295()));
			return this;
		case 23:
			this.SetSByte0149_303((sbyte)((339)1).GetByte0596_999());
			return this;
		case 24:
			this.SetSByte0149_303((sbyte)((284)1).GetAmount0020_67());
			return this;
		case 26:
			this.SetSByte0149_303((sbyte)((286)1).GetNumber0024_96());
			return this;
		}
		throw new ArgumentOutOfRangeException();
	}

	// Token: 0x040008B7 RID: 2231
	private sbyte sByte2;
}
