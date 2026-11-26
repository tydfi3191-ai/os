using System;

// Token: 0x02000246 RID: 582
public sealed class 349 : 346
{
	// Token: 0x060011E7 RID: 4583 RVA: 0x0004149E File Offset: 0x0003F69E
	public 349() : base(7)
	{
	}

	// Token: 0x060011E8 RID: 4584 RVA: 0x000414A7 File Offset: 0x0003F6A7
	public object GetValue0650_1133()
	{
		return this.value2;
	}

	// Token: 0x060011E9 RID: 4585 RVA: 0x000414AF File Offset: 0x0003F6AF
	public void SetValue0650_1134(object 1)
	{
		this.value2 = 1;
	}

	// Token: 0x060011EA RID: 4586 RVA: 0x000414B8 File Offset: 0x0003F6B8
	public override object Method1135()
	{
		return this.GetValue0650_1133();
	}

	// Token: 0x060011EB RID: 4587 RVA: 0x000414C0 File Offset: 0x0003F6C0
	public override void Method1136(object 1)
	{
		this.SetValue0650_1134(1);
	}

	// Token: 0x060011EC RID: 4588 RVA: 0x000414C9 File Offset: 0x0003F6C9
	public override 346 Method1137(346 1)
	{
		base.SetType0637_1116(1.GetType0637_1115());
		this.SetValue0650_1134(1.Method1135());
		return this;
	}

	// Token: 0x060011ED RID: 4589 RVA: 0x000414E4 File Offset: 0x0003F6E4
	public override 346 Method1138()
	{
		349 <<EMPTY_NAME>> = new 349();
		<<EMPTY_NAME>>.SetValue0650_1134(this.value2);
		<<EMPTY_NAME>>.SetType0637_1116(base.GetType0637_1115());
		return <<EMPTY_NAME>>;
	}

	// Token: 0x040008C7 RID: 2247
	private object value2;
}
