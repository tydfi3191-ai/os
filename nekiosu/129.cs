using System;
using System.Runtime.InteropServices;

// Token: 0x020000D9 RID: 217
[241(0)]
[ComVisible(false)]
[AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
[242(2)]
public abstract class 129 : Attribute
{
	// Token: 0x17000030 RID: 48
	// (get) Token: 0x06000587 RID: 1415 RVA: 0x000125CF File Offset: 0x000107CF
	// (set) Token: 0x06000588 RID: 1416 RVA: 0x000125D7 File Offset: 0x000107D7
	public string Id
	{
		get
		{
			return this.id;
		}
		set
		{
			this.id = value;
		}
	}

	// Token: 0x17000031 RID: 49
	// (get) Token: 0x06000589 RID: 1417 RVA: 0x000125E0 File Offset: 0x000107E0
	// (set) Token: 0x0600058A RID: 1418 RVA: 0x000125E8 File Offset: 0x000107E8
	public string Title
	{
		get
		{
			return this.title;
		}
		set
		{
			this.title = value;
		}
	}

	// Token: 0x17000032 RID: 50
	// (get) Token: 0x0600058B RID: 1419 RVA: 0x000125F1 File Offset: 0x000107F1
	// (set) Token: 0x0600058C RID: 1420 RVA: 0x000125F9 File Offset: 0x000107F9
	public string Description
	{
		get
		{
			return this.description;
		}
		set
		{
			this.description = value;
		}
	}

	// Token: 0x17000033 RID: 51
	// (get) Token: 0x0600058D RID: 1421 RVA: 0x00012602 File Offset: 0x00010802
	// (set) Token: 0x0600058E RID: 1422 RVA: 0x0001260A File Offset: 0x0001080A
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

	// Token: 0x17000034 RID: 52
	// (get) Token: 0x0600058F RID: 1423 RVA: 0x00012613 File Offset: 0x00010813
	// (set) Token: 0x06000590 RID: 1424 RVA: 0x0001261B File Offset: 0x0001081B
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

	// Token: 0x17000035 RID: 53
	// (get) Token: 0x06000591 RID: 1425 RVA: 0x00012624 File Offset: 0x00010824
	// (set) Token: 0x06000592 RID: 1426 RVA: 0x0001262C File Offset: 0x0001082C
	public Type NamingStrategyType
	{
		get
		{
			return this.namingStrategyType;
		}
		set
		{
			this.namingStrategyType = value;
			this.SetNamingStrategyInstance(null);
		}
	}

	// Token: 0x17000036 RID: 54
	// (get) Token: 0x06000593 RID: 1427 RVA: 0x0001263C File Offset: 0x0001083C
	// (set) Token: 0x06000594 RID: 1428 RVA: 0x00012644 File Offset: 0x00010844
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
			this.SetNamingStrategyInstance(null);
		}
	}

	// Token: 0x17000037 RID: 55
	// (get) Token: 0x06000595 RID: 1429 RVA: 0x00012654 File Offset: 0x00010854
	// (set) Token: 0x06000596 RID: 1430 RVA: 0x00012661 File Offset: 0x00010861
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

	// Token: 0x17000038 RID: 56
	// (get) Token: 0x06000597 RID: 1431 RVA: 0x0001266F File Offset: 0x0001086F
	// (set) Token: 0x06000598 RID: 1432 RVA: 0x0001267C File Offset: 0x0001087C
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

	// Token: 0x17000039 RID: 57
	// (get) Token: 0x06000599 RID: 1433 RVA: 0x0001268A File Offset: 0x0001088A
	// (set) Token: 0x0600059A RID: 1434 RVA: 0x00012697 File Offset: 0x00010897
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

	// Token: 0x1700003A RID: 58
	// (get) Token: 0x0600059B RID: 1435 RVA: 0x000126A5 File Offset: 0x000108A5
	// (set) Token: 0x0600059C RID: 1436 RVA: 0x000126B2 File Offset: 0x000108B2
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

	// Token: 0x0600059D RID: 1437 RVA: 0x000025CA File Offset: 0x000007CA
	protected 129()
	{
	}

	// Token: 0x0600059E RID: 1438 RVA: 0x000126C0 File Offset: 0x000108C0
	[242(1)]
	protected 129(string 1)
	{
		this.Id = 1;
	}

	// Token: 0x0600059F RID: 1439 RVA: 0x000126CF File Offset: 0x000108CF
	internal 136 GetNamingStrategyInstance()
	{
		return this.namingStrategyInstance;
	}

	// Token: 0x060005A0 RID: 1440 RVA: 0x000126D7 File Offset: 0x000108D7
	internal void SetNamingStrategyInstance(136 1)
	{
		this.namingStrategyInstance = 1;
	}

	// Token: 0x04000423 RID: 1059
	private string id;

	// Token: 0x04000424 RID: 1060
	private string title;

	// Token: 0x04000425 RID: 1061
	private string description;

	// Token: 0x04000426 RID: 1062
	private Type itemConverterType;

	// Token: 0x04000427 RID: 1063
	[241(new byte[]
	{
		2,
		1
	})]
	private object[] itemConverterParameters;

	// Token: 0x04000428 RID: 1064
	private 136 namingStrategyInstance;

	// Token: 0x04000429 RID: 1065
	internal bool? isReference;

	// Token: 0x0400042A RID: 1066
	internal bool? itemIsReference;

	// Token: 0x0400042B RID: 1067
	internal 894? itemReferenceLoopHandling;

	// Token: 0x0400042C RID: 1068
	internal 933? itemTypeNameHandling;

	// Token: 0x0400042D RID: 1069
	private Type namingStrategyType;

	// Token: 0x0400042E RID: 1070
	[241(new byte[]
	{
		2,
		1
	})]
	private object[] namingStrategyParameters;
}
