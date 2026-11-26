using System;
using System.Dynamic;

// Token: 0x02000252 RID: 594
[242(1)]
[241(0)]
public sealed class 490 : GetMemberBinder
{
	// Token: 0x06001211 RID: 4625 RVA: 0x00041DAB File Offset: 0x0003FFAB
	public 490(GetMemberBinder 1) : base(1.Name, 1.IgnoreCase)
	{
		this.getMemberBinder2 = 1;
	}

	// Token: 0x06001212 RID: 4626 RVA: 0x00041DC8 File Offset: 0x0003FFC8
	public override DynamicMetaObject FallbackGetMember(DynamicMetaObject 1, [241(2)] DynamicMetaObject 2)
	{
		DynamicMetaObject dynamicMetaObject = this.getMemberBinder2.Bind(1, 418.GetItemArray2540_3182<DynamicMetaObject>());
		return new DynamicMetaObject(new 429().Visit(dynamicMetaObject.Expression), dynamicMetaObject.Restrictions);
	}

	// Token: 0x040008DD RID: 2269
	private readonly GetMemberBinder getMemberBinder2;
}
