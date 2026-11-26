using System;

// Token: 0x02000286 RID: 646
public sealed class 969
{
	// Token: 0x060013E5 RID: 5093 RVA: 0x00045A68 File Offset: 0x00043C68
	public 969()
	{
		this.SetFlag7369_9482(false);
		this.SetFlag7370_9484(false);
		this.SetFlag7371_9486(false);
		this.SetCallToPostExecute((567)3);
		this.SetPostExecuteWorkItemCallback(915._recoveredType18073841);
		this.SetWorkItemPriority((639)2);
	}

	// Token: 0x060013E6 RID: 5094 RVA: 0x00045AA0 File Offset: 0x00043CA0
	public 969(969 1)
	{
		this.SetFlag7369_9482(1.GetFlag7369_9481());
		this.SetFlag7370_9484(1.GetFlag7370_9483());
		this.SetFlag7371_9486(1.GetFlag7371_9485());
		this.SetCallToPostExecute(1.GetCallToPostExecute());
		this.SetPostExecuteWorkItemCallback(1.GetPostExecuteWorkItemCallback());
		this.SetWorkItemPriority(1.GetWorkItemPriority());
		this.SetNumber7375_9494(1.GetNumber7375_9493());
	}

	// Token: 0x060013E7 RID: 5095 RVA: 0x00045B07 File Offset: 0x00043D07
	public bool GetFlag7369_9481()
	{
		return this.flag2;
	}

	// Token: 0x060013E8 RID: 5096 RVA: 0x00045B0F File Offset: 0x00043D0F
	public void SetFlag7369_9482(bool 1)
	{
		this.flag2 = 1;
	}

	// Token: 0x060013E9 RID: 5097 RVA: 0x00045B18 File Offset: 0x00043D18
	public bool GetFlag7370_9483()
	{
		return this.flag3;
	}

	// Token: 0x060013EA RID: 5098 RVA: 0x00045B20 File Offset: 0x00043D20
	public void SetFlag7370_9484(bool 1)
	{
		this.flag3 = 1;
	}

	// Token: 0x060013EB RID: 5099 RVA: 0x00045B29 File Offset: 0x00043D29
	public bool GetFlag7371_9485()
	{
		return this.flag4;
	}

	// Token: 0x060013EC RID: 5100 RVA: 0x00045B31 File Offset: 0x00043D31
	public void SetFlag7371_9486(bool 1)
	{
		this.flag4 = 1;
	}

	// Token: 0x060013ED RID: 5101 RVA: 0x00045B3A File Offset: 0x00043D3A
	public 567 GetCallToPostExecute()
	{
		return this.callToPostExecute;
	}

	// Token: 0x060013EE RID: 5102 RVA: 0x00045B42 File Offset: 0x00043D42
	public void SetCallToPostExecute(567 1)
	{
		this.callToPostExecute = 1;
	}

	// Token: 0x060013EF RID: 5103 RVA: 0x00045B4B File Offset: 0x00043D4B
	public 675 GetPostExecuteWorkItemCallback()
	{
		return this.postExecuteWorkItemCallback;
	}

	// Token: 0x060013F0 RID: 5104 RVA: 0x00045B53 File Offset: 0x00043D53
	public void SetPostExecuteWorkItemCallback(675 1)
	{
		this.postExecuteWorkItemCallback = 1;
	}

	// Token: 0x060013F1 RID: 5105 RVA: 0x00045B5C File Offset: 0x00043D5C
	public 639 GetWorkItemPriority()
	{
		return this.workItemPriority;
	}

	// Token: 0x060013F2 RID: 5106 RVA: 0x00045B64 File Offset: 0x00043D64
	public void SetWorkItemPriority(639 1)
	{
		this.workItemPriority = 1;
	}

	// Token: 0x060013F3 RID: 5107 RVA: 0x00045B6D File Offset: 0x00043D6D
	public long GetNumber7375_9493()
	{
		return this.number2;
	}

	// Token: 0x060013F4 RID: 5108 RVA: 0x00045B75 File Offset: 0x00043D75
	public void SetNumber7375_9494(long 1)
	{
		this.number2 = 1;
	}

	// Token: 0x04000957 RID: 2391
	private bool flag2;

	// Token: 0x04000958 RID: 2392
	private bool flag3;

	// Token: 0x04000959 RID: 2393
	private bool flag4;

	// Token: 0x0400095A RID: 2394
	private 567 callToPostExecute;

	// Token: 0x0400095B RID: 2395
	private 675 postExecuteWorkItemCallback;

	// Token: 0x0400095C RID: 2396
	private 639 workItemPriority;

	// Token: 0x0400095D RID: 2397
	private long number2;
}
