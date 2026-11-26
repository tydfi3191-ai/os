using System;

// Token: 0x02000237 RID: 567
public sealed class 298 : 346
{
	// Token: 0x0600117F RID: 4479 RVA: 0x0003F811 File Offset: 0x0003DA11
	public 298() : base(22)
	{
	}

	// Token: 0x06001180 RID: 4480 RVA: 0x0003F81B File Offset: 0x0003DA1B
	public IntPtr GetIntPtr0108_295()
	{
		return this.intPtr2;
	}

	// Token: 0x06001181 RID: 4481 RVA: 0x0003F823 File Offset: 0x0003DA23
	public void SetIntPtr0108_296(IntPtr 1)
	{
		this.intPtr2 = 1;
	}

	// Token: 0x06001182 RID: 4482 RVA: 0x0003F82C File Offset: 0x0003DA2C
	public override 346 Method1138()
	{
		298 <<EMPTY_NAME>> = new 298();
		<<EMPTY_NAME>>.SetIntPtr0108_296(this.intPtr2);
		<<EMPTY_NAME>>.SetType0637_1116(base.GetType0637_1115());
		return <<EMPTY_NAME>>;
	}

	// Token: 0x06001183 RID: 4483 RVA: 0x0003F84B File Offset: 0x0003DA4B
	public override object Method1135()
	{
		return this.GetIntPtr0108_295();
	}

	// Token: 0x06001184 RID: 4484 RVA: 0x0003F858 File Offset: 0x0003DA58
	public override void Method1136(object 1)
	{
		this.SetIntPtr0108_296((IntPtr)1);
	}

	// Token: 0x06001185 RID: 4485 RVA: 0x0003F868 File Offset: 0x0003DA68
	public override 346 Method1137(346 1)
	{
		base.SetType0637_1116(1.GetType0637_1115());
		switch (1.GetNumber0636_1112())
		{
		case 7:
			this.SetIntPtr0108_296((IntPtr)((349)1).GetValue0650_1133());
			return this;
		case 9:
			this.SetIntPtr0108_296((IntPtr)((int)((294)1).GetUInt160074_195()));
			return this;
		case 10:
			this.SetIntPtr0108_296(new IntPtr(Convert.ToInt64(((340)1).GetEnum0597_1005())));
			return this;
		case 11:
			this.SetIntPtr0108_296((IntPtr)((long)((288)1).GetAmount0028_108()));
			return this;
		case 12:
		{
			344 2 = (344)1;
			this.SetIntPtr0108_296(2.Method1088());
			return this;
		}
		case 15:
			this.SetIntPtr0108_296((IntPtr)((327)1).GetNumber0284_789());
			return this;
		case 17:
			this.SetIntPtr0108_296((IntPtr)((long)((285)1).GetNumber0023_90()));
			return this;
		case 18:
			this.SetIntPtr0108_296((IntPtr)((int)((320)1).GetSByte0149_302()));
			return this;
		case 20:
			this.SetIntPtr0108_296((IntPtr)((int)((324)1).GetInt160253_734()));
			return this;
		case 21:
			this.SetIntPtr0108_296((IntPtr)((long)((ulong)((296)1).GetNumber0087_234())));
			return this;
		case 22:
			this.SetIntPtr0108_296(((298)1).GetIntPtr0108_295());
			return this;
		case 23:
			this.SetIntPtr0108_296((IntPtr)((int)((339)1).GetByte0596_999()));
			return this;
		case 24:
			this.SetIntPtr0108_296((IntPtr)((long)((284)1).GetAmount0020_67()));
			return this;
		case 26:
			this.SetIntPtr0108_296((IntPtr)((286)1).GetNumber0024_96());
			return this;
		}
		throw new ArgumentOutOfRangeException();
	}

	// Token: 0x040008B6 RID: 2230
	private IntPtr intPtr2;
}
