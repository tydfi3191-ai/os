using System;
using System.Runtime.InteropServices;

// Token: 0x020001E7 RID: 487
[241(0)]
[ComVisible(false)]
[242(2)]
public class 130 : 902
{
	// Token: 0x06000F74 RID: 3956 RVA: 0x00035210 File Offset: 0x00033410
	[242(1)]
	internal 130(Type 1) : base(1)
	{
		129 attribute = 170.GetAttribute<129>(1);
		if (attribute != null)
		{
			if (attribute.ItemConverterType != null)
			{
				this.SetItemConverter(170.CreateJsonConverterInstance(attribute.ItemConverterType, attribute.ItemConverterParameters));
			}
			this.SetItemIsReference(attribute.itemIsReference);
			this.SetItemReferenceLoopHandling(attribute.itemReferenceLoopHandling);
			this.SetItemTypeNameHandling(attribute.itemTypeNameHandling);
		}
	}

	// Token: 0x06000F75 RID: 3957 RVA: 0x00035277 File Offset: 0x00033477
	internal 902 GetItemContract()
	{
		return this.itemContract;
	}

	// Token: 0x06000F76 RID: 3958 RVA: 0x0003527F File Offset: 0x0003347F
	internal void SetItemContract(902 1)
	{
		this.itemContract = 1;
		if (this.itemContract != null)
		{
			this.finalItemContract = (this.itemContract.GetUnderlyingType().Method6711() ? this.itemContract : null);
			return;
		}
		this.finalItemContract = null;
	}

	// Token: 0x06000F77 RID: 3959 RVA: 0x000352B9 File Offset: 0x000334B9
	internal 902 GetFinalItemContract()
	{
		return this.finalItemContract;
	}

	// Token: 0x06000F78 RID: 3960 RVA: 0x000352C1 File Offset: 0x000334C1
	public 214 GetItemConverter()
	{
		return this.itemConverter;
	}

	// Token: 0x06000F79 RID: 3961 RVA: 0x000352C9 File Offset: 0x000334C9
	public void SetItemConverter(214 1)
	{
		this.itemConverter = 1;
	}

	// Token: 0x06000F7A RID: 3962 RVA: 0x000352D2 File Offset: 0x000334D2
	public bool? GetItemIsReference()
	{
		return this.itemIsReference;
	}

	// Token: 0x06000F7B RID: 3963 RVA: 0x000352DA File Offset: 0x000334DA
	public void SetItemIsReference(bool? 1)
	{
		this.itemIsReference = 1;
	}

	// Token: 0x06000F7C RID: 3964 RVA: 0x000352E3 File Offset: 0x000334E3
	public 894? GetItemReferenceLoopHandling()
	{
		return this.itemReferenceLoopHandling;
	}

	// Token: 0x06000F7D RID: 3965 RVA: 0x000352EB File Offset: 0x000334EB
	public void SetItemReferenceLoopHandling(894? 1)
	{
		this.itemReferenceLoopHandling = 1;
	}

	// Token: 0x06000F7E RID: 3966 RVA: 0x000352F4 File Offset: 0x000334F4
	public 933? GetItemTypeNameHandling()
	{
		return this.itemTypeNameHandling;
	}

	// Token: 0x06000F7F RID: 3967 RVA: 0x000352FC File Offset: 0x000334FC
	public void SetItemTypeNameHandling(933? 1)
	{
		this.itemTypeNameHandling = 1;
	}

	// Token: 0x04000780 RID: 1920
	private 902 itemContract;

	// Token: 0x04000781 RID: 1921
	private 902 finalItemContract;

	// Token: 0x04000782 RID: 1922
	private 214 itemConverter;

	// Token: 0x04000783 RID: 1923
	private bool? itemIsReference;

	// Token: 0x04000784 RID: 1924
	private 894? itemReferenceLoopHandling;

	// Token: 0x04000785 RID: 1925
	private 933? itemTypeNameHandling;
}
