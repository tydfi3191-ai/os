using System;

// Token: 0x02000253 RID: 595
public sealed class 43
{
	// Token: 0x06001213 RID: 4627 RVA: 0x00041E02 File Offset: 0x00040002
	public 43()
	{
		this.SetIsCanceled(false);
	}

	// Token: 0x06001214 RID: 4628 RVA: 0x00041E11 File Offset: 0x00040011
	public bool GetIsCanceled()
	{
		return this.isCanceled;
	}

	// Token: 0x06001215 RID: 4629 RVA: 0x00041E19 File Offset: 0x00040019
	public void SetIsCanceled(bool 1)
	{
		this.isCanceled = 1;
	}

	// Token: 0x040008DE RID: 2270
	public static readonly 43 canceledSmartThreadPool = new 43();

	// Token: 0x040008DF RID: 2271
	private bool isCanceled;
}
