using System;
using System.Dynamic;

// Token: 0x02000250 RID: 592
[242(1)]
[241(0)]
public sealed class 385 : SetMemberBinder
{
	// Token: 0x0600120C RID: 4620 RVA: 0x00041D07 File Offset: 0x0003FF07
	public 385(SetMemberBinder 1) : base(1.Name, 1.IgnoreCase)
	{
		this.setMemberBinder2 = 1;
	}

	// Token: 0x0600120D RID: 4621 RVA: 0x00041D24 File Offset: 0x0003FF24
	public override DynamicMetaObject FallbackSetMember(DynamicMetaObject 1, DynamicMetaObject 2, [241(2)] DynamicMetaObject 3)
	{
		DynamicMetaObject dynamicMetaObject = this.setMemberBinder2.Bind(1, new DynamicMetaObject[]
		{
			2
		});
		return new DynamicMetaObject(new 429().Visit(dynamicMetaObject.Expression), dynamicMetaObject.Restrictions);
	}

	// Token: 0x040008DB RID: 2267
	private readonly SetMemberBinder setMemberBinder2;
}
