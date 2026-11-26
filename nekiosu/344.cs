using System;
using System.Reflection;

// Token: 0x02000243 RID: 579
public sealed class 344 : 346
{
	// Token: 0x060011CF RID: 4559 RVA: 0x00040F9C File Offset: 0x0003F19C
	public 344() : base(12)
	{
	}

	// Token: 0x060011D0 RID: 4560 RVA: 0x00040FA6 File Offset: 0x0003F1A6
	public MethodBase GetMethodBase0628_1086()
	{
		return this.methodBase2;
	}

	// Token: 0x060011D1 RID: 4561 RVA: 0x00040FAE File Offset: 0x0003F1AE
	public void SetMethodBase0628_1087(MethodBase 1)
	{
		this.methodBase2 = 1;
	}

	// Token: 0x060011D2 RID: 4562 RVA: 0x00040FB8 File Offset: 0x0003F1B8
	public IntPtr Method1088()
	{
		return this.GetMethodBase0628_1086().MethodHandle.GetFunctionPointer();
	}

	// Token: 0x060011D3 RID: 4563 RVA: 0x00040FD8 File Offset: 0x0003F1D8
	public override object Method1135()
	{
		return this.GetMethodBase0628_1086();
	}

	// Token: 0x060011D4 RID: 4564 RVA: 0x00040FE0 File Offset: 0x0003F1E0
	public override void Method1136(object 1)
	{
		this.SetMethodBase0628_1087((MethodBase)1);
	}

	// Token: 0x060011D5 RID: 4565 RVA: 0x00040FEE File Offset: 0x0003F1EE
	public override 346 Method1137(346 1)
	{
		base.SetType0637_1116(1.GetType0637_1115());
		if (1.GetNumber0636_1112() == 12)
		{
			this.SetMethodBase0628_1087(((344)1).GetMethodBase0628_1086());
			return this;
		}
		throw new ArgumentOutOfRangeException();
	}

	// Token: 0x060011D6 RID: 4566 RVA: 0x0004101E File Offset: 0x0003F21E
	public override 346 Method1138()
	{
		344 <<EMPTY_NAME>> = new 344();
		<<EMPTY_NAME>>.SetMethodBase0628_1087(this.methodBase2);
		<<EMPTY_NAME>>.SetType0637_1116(base.GetType0637_1115());
		return <<EMPTY_NAME>>;
	}

	// Token: 0x040008C3 RID: 2243
	private MethodBase methodBase2;
}
