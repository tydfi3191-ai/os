using System;
using System.Collections.Generic;

// Token: 0x020001CF RID: 463
public sealed class 78
{
	// Token: 0x06000E9D RID: 3741 RVA: 0x0003135C File Offset: 0x0002F55C
	public 78()
	{
		this.SetSchemaType(235.Any);
		this.SetAllowAdditionalProperties(true);
		this.SetAllowAdditionalItems(true);
		this.SetIsRequired(false);
	}

	// Token: 0x06000E9E RID: 3742 RVA: 0x00031381 File Offset: 0x0002F581
	public bool GetIsRequired()
	{
		return this.isRequired;
	}

	// Token: 0x06000E9F RID: 3743 RVA: 0x00031389 File Offset: 0x0002F589
	public void SetIsRequired(bool 1)
	{
		this.isRequired = 1;
	}

	// Token: 0x06000EA0 RID: 3744 RVA: 0x00031392 File Offset: 0x0002F592
	public 235 GetSchemaType()
	{
		return this.schemaType;
	}

	// Token: 0x06000EA1 RID: 3745 RVA: 0x0003139A File Offset: 0x0002F59A
	public void SetSchemaType(235 1)
	{
		this.schemaType = 1;
	}

	// Token: 0x06000EA2 RID: 3746 RVA: 0x000313A3 File Offset: 0x0002F5A3
	public int? GetMinimumLength()
	{
		return this.minimumLength;
	}

	// Token: 0x06000EA3 RID: 3747 RVA: 0x000313AB File Offset: 0x0002F5AB
	public void SetMinimumLength(int? 1)
	{
		this.minimumLength = 1;
	}

	// Token: 0x06000EA4 RID: 3748 RVA: 0x000313B4 File Offset: 0x0002F5B4
	public int? GetMaximumLength()
	{
		return this.maximumLength;
	}

	// Token: 0x06000EA5 RID: 3749 RVA: 0x000313BC File Offset: 0x0002F5BC
	public void SetMaximumLength(int? 1)
	{
		this.maximumLength = 1;
	}

	// Token: 0x06000EA6 RID: 3750 RVA: 0x000313C5 File Offset: 0x0002F5C5
	public double? GetNullable4147_5310()
	{
		return this.nullable4;
	}

	// Token: 0x06000EA7 RID: 3751 RVA: 0x000313CD File Offset: 0x0002F5CD
	public void SetNullable4147_5311(double? 1)
	{
		this.nullable4 = 1;
	}

	// Token: 0x06000EA8 RID: 3752 RVA: 0x000313D6 File Offset: 0x0002F5D6
	public double? GetNullable4148_5312()
	{
		return this.nullable5;
	}

	// Token: 0x06000EA9 RID: 3753 RVA: 0x000313DE File Offset: 0x0002F5DE
	public void SetNullable4148_5313(double? 1)
	{
		this.nullable5 = 1;
	}

	// Token: 0x06000EAA RID: 3754 RVA: 0x000313E7 File Offset: 0x0002F5E7
	public double? GetNullable4149_5314()
	{
		return this.nullable6;
	}

	// Token: 0x06000EAB RID: 3755 RVA: 0x000313EF File Offset: 0x0002F5EF
	public void SetNullable4149_5315(double? 1)
	{
		this.nullable6 = 1;
	}

	// Token: 0x06000EAC RID: 3756 RVA: 0x000313F8 File Offset: 0x0002F5F8
	public bool GetExclusiveMinimum()
	{
		return this.exclusiveMinimum;
	}

	// Token: 0x06000EAD RID: 3757 RVA: 0x00031400 File Offset: 0x0002F600
	public void SetExclusiveMinimum(bool 1)
	{
		this.exclusiveMinimum = 1;
	}

	// Token: 0x06000EAE RID: 3758 RVA: 0x00031409 File Offset: 0x0002F609
	public bool GetExclusiveMaximum()
	{
		return this.exclusiveMaximum;
	}

	// Token: 0x06000EAF RID: 3759 RVA: 0x00031411 File Offset: 0x0002F611
	public void SetExclusiveMaximum(bool 1)
	{
		this.exclusiveMaximum = 1;
	}

	// Token: 0x06000EB0 RID: 3760 RVA: 0x0003141A File Offset: 0x0002F61A
	public int? GetMinimumItems()
	{
		return this.minimumItems;
	}

	// Token: 0x06000EB1 RID: 3761 RVA: 0x00031422 File Offset: 0x0002F622
	public void SetMinimumItems(int? 1)
	{
		this.minimumItems = 1;
	}

	// Token: 0x06000EB2 RID: 3762 RVA: 0x0003142B File Offset: 0x0002F62B
	public int? GetMaximumItems()
	{
		return this.maximumItems;
	}

	// Token: 0x06000EB3 RID: 3763 RVA: 0x00031433 File Offset: 0x0002F633
	public void SetMaximumItems(int? 1)
	{
		this.maximumItems = 1;
	}

	// Token: 0x06000EB4 RID: 3764 RVA: 0x0003143C File Offset: 0x0002F63C
	public IList<string> GetPatterns()
	{
		return this.patterns;
	}

	// Token: 0x06000EB5 RID: 3765 RVA: 0x00031444 File Offset: 0x0002F644
	public void SetPatterns(IList<string> 1)
	{
		this.patterns = 1;
	}

	// Token: 0x06000EB6 RID: 3766 RVA: 0x0003144D File Offset: 0x0002F64D
	public IList<78> GetItems()
	{
		return this.items;
	}

	// Token: 0x06000EB7 RID: 3767 RVA: 0x00031455 File Offset: 0x0002F655
	public void SetItems(IList<78> 1)
	{
		this.items = 1;
	}

	// Token: 0x06000EB8 RID: 3768 RVA: 0x0003145E File Offset: 0x0002F65E
	public IDictionary<string, 78> GetProperties()
	{
		return this.properties;
	}

	// Token: 0x06000EB9 RID: 3769 RVA: 0x00031466 File Offset: 0x0002F666
	public void SetProperties(IDictionary<string, 78> 1)
	{
		this.properties = 1;
	}

	// Token: 0x06000EBA RID: 3770 RVA: 0x0003146F File Offset: 0x0002F66F
	public IDictionary<string, 78> GetPatternProperties()
	{
		return this.patternProperties;
	}

	// Token: 0x06000EBB RID: 3771 RVA: 0x00031477 File Offset: 0x0002F677
	public void SetPatternProperties(IDictionary<string, 78> 1)
	{
		this.patternProperties = 1;
	}

	// Token: 0x06000EBC RID: 3772 RVA: 0x00031480 File Offset: 0x0002F680
	public 78 GetAdditionalProperties()
	{
		return this.additionalProperties;
	}

	// Token: 0x06000EBD RID: 3773 RVA: 0x00031488 File Offset: 0x0002F688
	public void SetAdditionalProperties(78 1)
	{
		this.additionalProperties = 1;
	}

	// Token: 0x06000EBE RID: 3774 RVA: 0x00031491 File Offset: 0x0002F691
	public 78 GetAdditionalItems()
	{
		return this.additionalItems;
	}

	// Token: 0x06000EBF RID: 3775 RVA: 0x00031499 File Offset: 0x0002F699
	public void SetAdditionalItems(78 1)
	{
		this.additionalItems = 1;
	}

	// Token: 0x06000EC0 RID: 3776 RVA: 0x000314A2 File Offset: 0x0002F6A2
	public bool GetPositionalItemsValidation()
	{
		return this.positionalItemsValidation;
	}

	// Token: 0x06000EC1 RID: 3777 RVA: 0x000314AA File Offset: 0x0002F6AA
	public void SetPositionalItemsValidation(bool 1)
	{
		this.positionalItemsValidation = 1;
	}

	// Token: 0x06000EC2 RID: 3778 RVA: 0x000314B3 File Offset: 0x0002F6B3
	public bool GetAllowAdditionalProperties()
	{
		return this.allowAdditionalProperties;
	}

	// Token: 0x06000EC3 RID: 3779 RVA: 0x000314BB File Offset: 0x0002F6BB
	public void SetAllowAdditionalProperties(bool 1)
	{
		this.allowAdditionalProperties = 1;
	}

	// Token: 0x06000EC4 RID: 3780 RVA: 0x000314C4 File Offset: 0x0002F6C4
	public bool GetAllowAdditionalItems()
	{
		return this.allowAdditionalItems;
	}

	// Token: 0x06000EC5 RID: 3781 RVA: 0x000314CC File Offset: 0x0002F6CC
	public void SetAllowAdditionalItems(bool 1)
	{
		this.allowAdditionalItems = 1;
	}

	// Token: 0x06000EC6 RID: 3782 RVA: 0x000314D5 File Offset: 0x0002F6D5
	public bool GetUniqueItems()
	{
		return this.uniqueItems;
	}

	// Token: 0x06000EC7 RID: 3783 RVA: 0x000314DD File Offset: 0x0002F6DD
	public void SetUniqueItems(bool 1)
	{
		this.uniqueItems = 1;
	}

	// Token: 0x06000EC8 RID: 3784 RVA: 0x000314E6 File Offset: 0x0002F6E6
	public IList<226> GetEnumValues()
	{
		return this.enumValues;
	}

	// Token: 0x06000EC9 RID: 3785 RVA: 0x000314EE File Offset: 0x0002F6EE
	public void SetEnumValues(IList<226> 1)
	{
		this.enumValues = 1;
	}

	// Token: 0x06000ECA RID: 3786 RVA: 0x000314F7 File Offset: 0x0002F6F7
	public 235 GetDisallow()
	{
		return this.disallow;
	}

	// Token: 0x06000ECB RID: 3787 RVA: 0x000314FF File Offset: 0x0002F6FF
	public void SetDisallow(235 1)
	{
		this.disallow = 1;
	}

	// Token: 0x06000ECC RID: 3788 RVA: 0x00031508 File Offset: 0x0002F708
	public static 78 Create(IList<529> 1)
	{
		78 2 = new 78();
		foreach (529 3 in 1)
		{
			78.Combine(2, 3);
		}
		return 2;
	}

	// Token: 0x06000ECD RID: 3789 RVA: 0x00031558 File Offset: 0x0002F758
	private static void Combine(78 1, 529 2)
	{
		1.SetIsRequired(1.GetIsRequired() || 2.GetNullable5093_6374().GetValueOrDefault());
		1.SetSchemaType(1.GetSchemaType() & 2.GetNullable5098_6384().GetValueOrDefault(235.Any));
		1.SetMinimumLength(421.Method3214(1.GetMinimumLength(), 2.GetNullable5100_6388()));
		1.SetMaximumLength(421.Method3213(1.GetMaximumLength(), 2.GetNullable5101_6390()));
		1.SetNullable4147_5311(421.Method3214(1.GetNullable4147_5310(), 2.GetNullable5102_6392()));
		1.SetNullable4148_5313(421.Method3214(1.GetNullable4148_5312(), 2.GetNullable5103_6394()));
		1.SetNullable4149_5315(421.Method3214(1.GetNullable4149_5314(), 2.GetNullable5104_6396()));
		1.SetExclusiveMinimum(1.GetExclusiveMinimum() || 2.GetNullable5105_6398().GetValueOrDefault());
		1.SetExclusiveMaximum(1.GetExclusiveMaximum() || 2.GetNullable5106_6400().GetValueOrDefault());
		1.SetMinimumItems(421.Method3214(1.GetMinimumItems(), 2.GetNullable5107_6402()));
		1.SetMaximumItems(421.Method3213(1.GetMaximumItems(), 2.GetNullable5108_6404()));
		1.SetPositionalItemsValidation(1.GetPositionalItemsValidation() || 2.GetFlag5110_6408());
		1.SetAllowAdditionalProperties(1.GetAllowAdditionalProperties() && 2.GetFlag5117_6422());
		1.SetAllowAdditionalItems(1.GetAllowAdditionalItems() && 2.GetFlag5112_6412());
		1.SetUniqueItems(1.GetUniqueItems() || 2.GetFlag5113_6414());
		if (2.GetIList5119_6426() != null)
		{
			if (1.GetEnumValues() == null)
			{
				1.SetEnumValues(new List<226>());
			}
			1.GetEnumValues().Method3173(2.GetIList5119_6426(), 226.EqualityComparer);
		}
		1.SetDisallow(1.GetDisallow() | 2.GetNullable5120_6428().GetValueOrDefault());
		if (2.GetText5099_6386() != null)
		{
			if (1.GetPatterns() == null)
			{
				1.SetPatterns(new List<string>());
			}
			1.GetPatterns().Method3170(2.GetText5099_6386());
		}
	}

	// Token: 0x04000723 RID: 1827
	private bool isRequired;

	// Token: 0x04000724 RID: 1828
	private 235 schemaType;

	// Token: 0x04000725 RID: 1829
	private int? minimumLength;

	// Token: 0x04000726 RID: 1830
	private int? maximumLength;

	// Token: 0x04000727 RID: 1831
	private double? nullable4;

	// Token: 0x04000728 RID: 1832
	private double? nullable5;

	// Token: 0x04000729 RID: 1833
	private double? nullable6;

	// Token: 0x0400072A RID: 1834
	private bool exclusiveMinimum;

	// Token: 0x0400072B RID: 1835
	private bool exclusiveMaximum;

	// Token: 0x0400072C RID: 1836
	private int? minimumItems;

	// Token: 0x0400072D RID: 1837
	private int? maximumItems;

	// Token: 0x0400072E RID: 1838
	private IList<string> patterns;

	// Token: 0x0400072F RID: 1839
	private IList<78> items;

	// Token: 0x04000730 RID: 1840
	private IDictionary<string, 78> properties;

	// Token: 0x04000731 RID: 1841
	private IDictionary<string, 78> patternProperties;

	// Token: 0x04000732 RID: 1842
	private 78 additionalProperties;

	// Token: 0x04000733 RID: 1843
	private 78 additionalItems;

	// Token: 0x04000734 RID: 1844
	private bool positionalItemsValidation;

	// Token: 0x04000735 RID: 1845
	private bool allowAdditionalProperties;

	// Token: 0x04000736 RID: 1846
	private bool allowAdditionalItems;

	// Token: 0x04000737 RID: 1847
	private bool uniqueItems;

	// Token: 0x04000738 RID: 1848
	private IList<226> enumValues;

	// Token: 0x04000739 RID: 1849
	private 235 disallow;
}
