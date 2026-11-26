using System;

// Token: 0x02000285 RID: 645
public sealed class 968
{
	// Token: 0x060013D9 RID: 5081 RVA: 0x00045787 File Offset: 0x00043987
	public static 802 Method8759(103 1, 555 2, 454 3)
	{
		return 968.Method8759(1, 2, 3, null);
	}

	// Token: 0x060013DA RID: 5082 RVA: 0x00045792 File Offset: 0x00043992
	public static 802 Method8759(103 1, 555 2, 454 3, 639 4)
	{
		return 968.Method8759(1, 2, 3, null, 4);
	}

	// Token: 0x060013DB RID: 5083 RVA: 0x0004579E File Offset: 0x0004399E
	public static 802 Method8759(103 1, 555 2, 969 3, 454 4)
	{
		return 968.Method8759(1, 2, 3, 4, null);
	}

	// Token: 0x060013DC RID: 5084 RVA: 0x000457AC File Offset: 0x000439AC
	public static 802 Method8759(103 1, 555 2, 454 3, object 4)
	{
		968.ValidateCallback(3);
		969 5 = new 969();
		5.SetFlag7369_9482(2.GetFlag5787_7488());
		5.SetFlag7370_9484(2.GetFlag5788_7490());
		5.SetPostExecuteWorkItemCallback(2.GetRecoveredType18075791_7496());
		5.SetCallToPostExecute(2.GetRecoveredType13395790_7494());
		5.SetFlag7371_9486(2.GetFlag5789_7492());
		5.SetWorkItemPriority(2.GetRecoveredType16945793_7500());
		return new 802(1, 5, 3, 4);
	}

	// Token: 0x060013DD RID: 5085 RVA: 0x00045818 File Offset: 0x00043A18
	public static 802 Method8759(103 1, 555 2, 454 3, object 4, 639 5)
	{
		968.ValidateCallback(3);
		969 6 = new 969();
		6.SetFlag7369_9482(2.GetFlag5787_7488());
		6.SetFlag7370_9484(2.GetFlag5788_7490());
		6.SetPostExecuteWorkItemCallback(2.GetRecoveredType18075791_7496());
		6.SetCallToPostExecute(2.GetRecoveredType13395790_7494());
		6.SetFlag7371_9486(2.GetFlag5789_7492());
		6.SetWorkItemPriority(5);
		return new 802(1, 6, 3, 4);
	}

	// Token: 0x060013DE RID: 5086 RVA: 0x0004587E File Offset: 0x00043A7E
	public static 802 Method8759(103 1, 555 2, 969 3, 454 4, object 5)
	{
		968.ValidateCallback(4);
		968.ValidateCallback(3.GetPostExecuteWorkItemCallback());
		return new 802(1, new 969(3), 4, 5);
	}

	// Token: 0x060013DF RID: 5087 RVA: 0x000458A0 File Offset: 0x00043AA0
	public static 802 Method8759(103 1, 555 2, 454 3, object 4, 675 5)
	{
		968.ValidateCallback(3);
		968.ValidateCallback(5);
		969 6 = new 969();
		6.SetFlag7369_9482(2.GetFlag5787_7488());
		6.SetFlag7370_9484(2.GetFlag5788_7490());
		6.SetPostExecuteWorkItemCallback(5);
		6.SetCallToPostExecute(2.GetRecoveredType13395790_7494());
		6.SetFlag7371_9486(2.GetFlag5789_7492());
		6.SetWorkItemPriority(2.GetRecoveredType16945793_7500());
		return new 802(1, 6, 3, 4);
	}

	// Token: 0x060013E0 RID: 5088 RVA: 0x00045910 File Offset: 0x00043B10
	public static 802 Method8759(103 1, 555 2, 454 3, object 4, 675 5, 639 6)
	{
		968.ValidateCallback(3);
		968.ValidateCallback(5);
		969 7 = new 969();
		7.SetFlag7369_9482(2.GetFlag5787_7488());
		7.SetFlag7370_9484(2.GetFlag5788_7490());
		7.SetPostExecuteWorkItemCallback(5);
		7.SetCallToPostExecute(2.GetRecoveredType13395790_7494());
		7.SetFlag7371_9486(2.GetFlag5789_7492());
		7.SetWorkItemPriority(6);
		return new 802(1, 7, 3, 4);
	}

	// Token: 0x060013E1 RID: 5089 RVA: 0x0004597C File Offset: 0x00043B7C
	public static 802 Method8759(103 1, 555 2, 454 3, object 4, 675 5, 567 6)
	{
		968.ValidateCallback(3);
		968.ValidateCallback(5);
		969 7 = new 969();
		7.SetFlag7369_9482(2.GetFlag5787_7488());
		7.SetFlag7370_9484(2.GetFlag5788_7490());
		7.SetPostExecuteWorkItemCallback(5);
		7.SetCallToPostExecute(6);
		7.SetFlag7371_9486(2.GetFlag5789_7492());
		7.SetWorkItemPriority(2.GetRecoveredType16945793_7500());
		return new 802(1, 7, 3, 4);
	}

	// Token: 0x060013E2 RID: 5090 RVA: 0x000459E8 File Offset: 0x00043BE8
	public static 802 Method8759(103 1, 555 2, 454 3, object 4, 675 5, 567 6, 639 7)
	{
		968.ValidateCallback(3);
		968.ValidateCallback(5);
		969 8 = new 969();
		8.SetFlag7369_9482(2.GetFlag5787_7488());
		8.SetFlag7370_9484(2.GetFlag5788_7490());
		8.SetPostExecuteWorkItemCallback(5);
		8.SetCallToPostExecute(6);
		8.SetWorkItemPriority(7);
		8.SetFlag7371_9486(2.GetFlag5789_7492());
		return new 802(1, 8, 3, 4);
	}

	// Token: 0x060013E3 RID: 5091 RVA: 0x00045A4D File Offset: 0x00043C4D
	private static void ValidateCallback(Delegate 1)
	{
		if (1 != null && 1.GetInvocationList().Length > 1)
		{
			throw new NotSupportedException("SmartThreadPool doesn't support delegates chains");
		}
	}
}
