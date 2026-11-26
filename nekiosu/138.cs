using System;
using System.Runtime.InteropServices;

// Token: 0x020000DF RID: 223
[ComVisible(false)]
[242(2)]
[241(0)]
[AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
public sealed class 138 : Attribute
{
	// Token: 0x1700003C RID: 60
	// (get) Token: 0x060005B2 RID: 1458 RVA: 0x00012A0E File Offset: 0x00010C0E
	// (set) Token: 0x060005B3 RID: 1459 RVA: 0x00012A16 File Offset: 0x00010C16
	public Type ItemConverterType
	{
		get
		{
			return this.itemConverterType;
		}
		set
		{
			this.itemConverterType = value;
		}
	}

	// Token: 0x1700003D RID: 61
	// (get) Token: 0x060005B4 RID: 1460 RVA: 0x00012A1F File Offset: 0x00010C1F
	// (set) Token: 0x060005B5 RID: 1461 RVA: 0x00012A27 File Offset: 0x00010C27
	[241(new byte[]
	{
		2,
		1
	})]
	public object[] ItemConverterParameters
	{
		[return: 241(new byte[]
		{
			2,
			1
		})]
		get
		{
			return this.itemConverterParameters;
		}
		[param: 241(new byte[]
		{
			2,
			1
		})]
		set
		{
			this.itemConverterParameters = value;
		}
	}

	// Token: 0x1700003E RID: 62
	// (get) Token: 0x060005B6 RID: 1462 RVA: 0x00012A30 File Offset: 0x00010C30
	// (set) Token: 0x060005B7 RID: 1463 RVA: 0x00012A38 File Offset: 0x00010C38
	public Type NamingStrategyType
	{
		get
		{
			return this.namingStrategyType;
		}
		set
		{
			this.namingStrategyType = value;
		}
	}

	// Token: 0x1700003F RID: 63
	// (get) Token: 0x060005B8 RID: 1464 RVA: 0x00012A41 File Offset: 0x00010C41
	// (set) Token: 0x060005B9 RID: 1465 RVA: 0x00012A49 File Offset: 0x00010C49
	[241(new byte[]
	{
		2,
		1
	})]
	public object[] NamingStrategyParameters
	{
		[return: 241(new byte[]
		{
			2,
			1
		})]
		get
		{
			return this.namingStrategyParameters;
		}
		[param: 241(new byte[]
		{
			2,
			1
		})]
		set
		{
			this.namingStrategyParameters = value;
		}
	}

	// Token: 0x17000040 RID: 64
	// (get) Token: 0x060005BA RID: 1466 RVA: 0x00012A52 File Offset: 0x00010C52
	// (set) Token: 0x060005BB RID: 1467 RVA: 0x00012A5F File Offset: 0x00010C5F
	public 240 NullValueHandling
	{
		get
		{
			return this.nullValueHandling.GetValueOrDefault();
		}
		set
		{
			this.nullValueHandling = new 240?(value);
		}
	}

	// Token: 0x17000041 RID: 65
	// (get) Token: 0x060005BC RID: 1468 RVA: 0x00012A6D File Offset: 0x00010C6D
	// (set) Token: 0x060005BD RID: 1469 RVA: 0x00012A7A File Offset: 0x00010C7A
	public 50 DefaultValueHandling
	{
		get
		{
			return this.defaultValueHandling.GetValueOrDefault();
		}
		set
		{
			this.defaultValueHandling = new 50?(value);
		}
	}

	// Token: 0x17000042 RID: 66
	// (get) Token: 0x060005BE RID: 1470 RVA: 0x00012A88 File Offset: 0x00010C88
	// (set) Token: 0x060005BF RID: 1471 RVA: 0x00012A95 File Offset: 0x00010C95
	public 894 ReferenceLoopHandling
	{
		get
		{
			return this.referenceLoopHandling.GetValueOrDefault();
		}
		set
		{
			this.referenceLoopHandling = new 894?(value);
		}
	}

	// Token: 0x17000043 RID: 67
	// (get) Token: 0x060005C0 RID: 1472 RVA: 0x00012AA3 File Offset: 0x00010CA3
	// (set) Token: 0x060005C1 RID: 1473 RVA: 0x00012AB0 File Offset: 0x00010CB0
	public 243 ObjectCreationHandling
	{
		get
		{
			return this.objectCreationHandling.GetValueOrDefault();
		}
		set
		{
			this.objectCreationHandling = new 243?(value);
		}
	}

	// Token: 0x17000044 RID: 68
	// (get) Token: 0x060005C2 RID: 1474 RVA: 0x00012ABE File Offset: 0x00010CBE
	// (set) Token: 0x060005C3 RID: 1475 RVA: 0x00012ACB File Offset: 0x00010CCB
	public 933 TypeNameHandling
	{
		get
		{
			return this.typeNameHandling.GetValueOrDefault();
		}
		set
		{
			this.typeNameHandling = new 933?(value);
		}
	}

	// Token: 0x17000045 RID: 69
	// (get) Token: 0x060005C4 RID: 1476 RVA: 0x00012AD9 File Offset: 0x00010CD9
	// (set) Token: 0x060005C5 RID: 1477 RVA: 0x00012AE6 File Offset: 0x00010CE6
	public bool IsReference
	{
		get
		{
			return this.isReference.GetValueOrDefault();
		}
		set
		{
			this.isReference = new bool?(value);
		}
	}

	// Token: 0x17000046 RID: 70
	// (get) Token: 0x060005C6 RID: 1478 RVA: 0x00012AF4 File Offset: 0x00010CF4
	// (set) Token: 0x060005C7 RID: 1479 RVA: 0x00012B01 File Offset: 0x00010D01
	public int Order
	{
		get
		{
			return this.order.GetValueOrDefault();
		}
		set
		{
			this.order = new int?(value);
		}
	}

	// Token: 0x17000047 RID: 71
	// (get) Token: 0x060005C8 RID: 1480 RVA: 0x00012B0F File Offset: 0x00010D0F
	// (set) Token: 0x060005C9 RID: 1481 RVA: 0x00012B1C File Offset: 0x00010D1C
	public 896 Required
	{
		get
		{
			return this.required.GetValueOrDefault();
		}
		set
		{
			this.required = new 896?(value);
		}
	}

	// Token: 0x17000048 RID: 72
	// (get) Token: 0x060005CA RID: 1482 RVA: 0x00012B2A File Offset: 0x00010D2A
	// (set) Token: 0x060005CB RID: 1483 RVA: 0x00012B32 File Offset: 0x00010D32
	public string PropertyName
	{
		get
		{
			return this.propertyName;
		}
		set
		{
			this.propertyName = value;
		}
	}

	// Token: 0x17000049 RID: 73
	// (get) Token: 0x060005CC RID: 1484 RVA: 0x00012B3B File Offset: 0x00010D3B
	// (set) Token: 0x060005CD RID: 1485 RVA: 0x00012B48 File Offset: 0x00010D48
	public 894 ItemReferenceLoopHandling
	{
		get
		{
			return this.itemReferenceLoopHandling.GetValueOrDefault();
		}
		set
		{
			this.itemReferenceLoopHandling = new 894?(value);
		}
	}

	// Token: 0x1700004A RID: 74
	// (get) Token: 0x060005CE RID: 1486 RVA: 0x00012B56 File Offset: 0x00010D56
	// (set) Token: 0x060005CF RID: 1487 RVA: 0x00012B63 File Offset: 0x00010D63
	public 933 ItemTypeNameHandling
	{
		get
		{
			return this.itemTypeNameHandling.GetValueOrDefault();
		}
		set
		{
			this.itemTypeNameHandling = new 933?(value);
		}
	}

	// Token: 0x1700004B RID: 75
	// (get) Token: 0x060005D0 RID: 1488 RVA: 0x00012B71 File Offset: 0x00010D71
	// (set) Token: 0x060005D1 RID: 1489 RVA: 0x00012B7E File Offset: 0x00010D7E
	public bool ItemIsReference
	{
		get
		{
			return this.itemIsReference.GetValueOrDefault();
		}
		set
		{
			this.itemIsReference = new bool?(value);
		}
	}

	// Token: 0x060005D2 RID: 1490 RVA: 0x000025CA File Offset: 0x000007CA
	public 138()
	{
	}

	// Token: 0x060005D3 RID: 1491 RVA: 0x00012B8C File Offset: 0x00010D8C
	[242(1)]
	public 138(string 1)
	{
		this.PropertyName = 1;
	}

	// Token: 0x0400043B RID: 1083
	internal 240? nullValueHandling;

	// Token: 0x0400043C RID: 1084
	internal 50? defaultValueHandling;

	// Token: 0x0400043D RID: 1085
	internal 894? referenceLoopHandling;

	// Token: 0x0400043E RID: 1086
	internal 243? objectCreationHandling;

	// Token: 0x0400043F RID: 1087
	internal 933? typeNameHandling;

	// Token: 0x04000440 RID: 1088
	internal bool? isReference;

	// Token: 0x04000441 RID: 1089
	internal int? order;

	// Token: 0x04000442 RID: 1090
	internal 896? required;

	// Token: 0x04000443 RID: 1091
	internal bool? itemIsReference;

	// Token: 0x04000444 RID: 1092
	internal 894? itemReferenceLoopHandling;

	// Token: 0x04000445 RID: 1093
	internal 933? itemTypeNameHandling;

	// Token: 0x04000446 RID: 1094
	private Type itemConverterType;

	// Token: 0x04000447 RID: 1095
	[241(new byte[]
	{
		2,
		1
	})]
	private object[] itemConverterParameters;

	// Token: 0x04000448 RID: 1096
	private Type namingStrategyType;

	// Token: 0x04000449 RID: 1097
	[241(new byte[]
	{
		2,
		1
	})]
	private object[] namingStrategyParameters;

	// Token: 0x0400044A RID: 1098
	private string propertyName;
}
