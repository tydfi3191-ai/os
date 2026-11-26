using System;
using System.Runtime.InteropServices;

// Token: 0x020003AB RID: 939
[242(1)]
[241(0)]
[ComVisible(false)]
public abstract class 214
{
	// Token: 0x170001E0 RID: 480
	// (get) Token: 0x06001CCF RID: 7375 RVA: 0x0001702D File Offset: 0x0001522D
	public virtual bool CanRead
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170001E1 RID: 481
	// (get) Token: 0x06001CD0 RID: 7376 RVA: 0x0001702D File Offset: 0x0001522D
	public virtual bool CanWrite
	{
		get
		{
			return true;
		}
	}

	// Token: 0x06001CD1 RID: 7377
	public abstract void WriteJson(173 1, [241(2)] object 2, 158 3);

	// Token: 0x06001CD2 RID: 7378
	[return: 241(2)]
	public abstract object ReadJson(139 1, Type 2, [241(2)] object 3, 158 4);

	// Token: 0x06001CD3 RID: 7379
	public abstract bool CanConvert(Type 1);
}
