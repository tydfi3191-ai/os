using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

// Token: 0x020001F8 RID: 504
[241(0)]
[242(1)]
[ComVisible(false)]
public abstract class 902
{
	// Token: 0x170000D8 RID: 216
	// (get) Token: 0x06000FF1 RID: 4081 RVA: 0x0003642C File Offset: 0x0003462C
	// (set) Token: 0x06000FF2 RID: 4082 RVA: 0x00036434 File Offset: 0x00034634
	[241(2)]
	public 214 Converter
	{
		[242(2)]
		get
		{
			return this.converter;
		}
		[242(2)]
		set
		{
			this.converter = value;
		}
	}

	// Token: 0x170000D9 RID: 217
	// (get) Token: 0x06000FF3 RID: 4083 RVA: 0x0003643D File Offset: 0x0003463D
	// (set) Token: 0x06000FF4 RID: 4084 RVA: 0x00036445 File Offset: 0x00034645
	[241(2)]
	public 214 InternalConverter
	{
		[242(2)]
		get
		{
			return this.internalConverter;
		}
		[242(2)]
		internal set
		{
			this.internalConverter = value;
		}
	}

	// Token: 0x170000DA RID: 218
	// (get) Token: 0x06000FF5 RID: 4085 RVA: 0x0003644E File Offset: 0x0003464E
	// (set) Token: 0x06000FF6 RID: 4086 RVA: 0x00036456 File Offset: 0x00034656
	[241(new byte[]
	{
		2,
		1
	})]
	public Func<object> DefaultCreator
	{
		[return: 241(new byte[]
		{
			2,
			1
		})]
		get
		{
			return this.func;
		}
		[param: 241(new byte[]
		{
			2,
			1
		})]
		set
		{
			this.func = value;
		}
	}

	// Token: 0x06000FF7 RID: 4087 RVA: 0x00036460 File Offset: 0x00034660
	internal 902(Type 1)
	{
		756.Method12216(1, "underlyingType");
		this.underlyingType = 1;
		1 = 143.GetNonByRefType(1);
		this.isNullable = 143.IsNullable(1);
		this.nonNullableUnderlyingType = ((this.isNullable && 143.IsNullableType(1)) ? Nullable.GetUnderlyingType(1) : 1);
		Type type;
		this.SetCreatedType(type = this.nonNullableUnderlyingType);
		this.createdType = type;
		this.flag3 = 358.Method1493(this.nonNullableUnderlyingType);
		this.flag4 = this.nonNullableUnderlyingType.Method6709();
		this.internalReadType = (815)0;
	}

	// Token: 0x06000FF8 RID: 4088 RVA: 0x000364F6 File Offset: 0x000346F6
	public Type GetUnderlyingType()
	{
		return this.underlyingType;
	}

	// Token: 0x06000FF9 RID: 4089 RVA: 0x000364FE File Offset: 0x000346FE
	public Type GetCreatedType()
	{
		return this.createdType;
	}

	// Token: 0x06000FFA RID: 4090 RVA: 0x00036508 File Offset: 0x00034708
	public void SetCreatedType(Type 1)
	{
		756.Method12216(1, "value");
		this.createdType = 1;
		this.flag6 = this.createdType.Method6711();
		this.isInstantiable = (!this.createdType.Method6704() && !this.createdType.Method6712());
	}

	// Token: 0x06000FFB RID: 4091 RVA: 0x0003655C File Offset: 0x0003475C
	public bool? GetIsReference()
	{
		return this.isReference;
	}

	// Token: 0x06000FFC RID: 4092 RVA: 0x00036564 File Offset: 0x00034764
	public void SetIsReference(bool? 1)
	{
		this.isReference = 1;
	}

	// Token: 0x06000FFD RID: 4093 RVA: 0x0003656D File Offset: 0x0003476D
	public IList<437> Method1373()
	{
		if (this.list == null)
		{
			this.list = new List<437>();
		}
		return this.list;
	}

	// Token: 0x06000FFE RID: 4094 RVA: 0x00036588 File Offset: 0x00034788
	public IList<437> Method1374()
	{
		if (this.list2 == null)
		{
			this.list2 = new List<437>();
		}
		return this.list2;
	}

	// Token: 0x06000FFF RID: 4095 RVA: 0x000365A3 File Offset: 0x000347A3
	public IList<437> Method1375()
	{
		if (this.list3 == null)
		{
			this.list3 = new List<437>();
		}
		return this.list3;
	}

	// Token: 0x06001000 RID: 4096 RVA: 0x000365BE File Offset: 0x000347BE
	public IList<437> Method1376()
	{
		if (this.list4 == null)
		{
			this.list4 = new List<437>();
		}
		return this.list4;
	}

	// Token: 0x06001001 RID: 4097 RVA: 0x000365D9 File Offset: 0x000347D9
	public IList<791> GetOnErrorCallbacks()
	{
		if (this.onErrorCallbacks == null)
		{
			this.onErrorCallbacks = new List<791>();
		}
		return this.onErrorCallbacks;
	}

	// Token: 0x06001002 RID: 4098 RVA: 0x000365F4 File Offset: 0x000347F4
	public bool GetFlag0798_1378()
	{
		return this.flag8;
	}

	// Token: 0x06001003 RID: 4099 RVA: 0x000365FC File Offset: 0x000347FC
	public void SetFlag0798_1379(bool 1)
	{
		this.flag8 = 1;
	}

	// Token: 0x06001004 RID: 4100 RVA: 0x00036608 File Offset: 0x00034808
	internal void Method1380(object 1, StreamingContext 2)
	{
		if (this.list4 == null)
		{
			return;
		}
		foreach (437 3 in this.list4)
		{
			3(1, 2);
		}
	}

	// Token: 0x06001005 RID: 4101 RVA: 0x00036664 File Offset: 0x00034864
	internal void Method1381(object 1, StreamingContext 2)
	{
		if (this.list3 == null)
		{
			return;
		}
		foreach (437 3 in this.list3)
		{
			3(1, 2);
		}
	}

	// Token: 0x06001006 RID: 4102 RVA: 0x000366C0 File Offset: 0x000348C0
	internal void Method1382(object 1, StreamingContext 2)
	{
		if (this.list2 == null)
		{
			return;
		}
		foreach (437 3 in this.list2)
		{
			3(1, 2);
		}
	}

	// Token: 0x06001007 RID: 4103 RVA: 0x0003671C File Offset: 0x0003491C
	internal void Method1383(object 1, StreamingContext 2)
	{
		if (this.list == null)
		{
			return;
		}
		foreach (437 3 in this.list)
		{
			3(1, 2);
		}
	}

	// Token: 0x06001008 RID: 4104 RVA: 0x00036778 File Offset: 0x00034978
	internal void InvokeErrorCallbacks(object 1, StreamingContext 2, 236 3)
	{
		if (this.onErrorCallbacks == null)
		{
			return;
		}
		foreach (791 4 in this.onErrorCallbacks)
		{
			4(1, 2, 3);
		}
	}

	// Token: 0x06001009 RID: 4105 RVA: 0x000367D4 File Offset: 0x000349D4
	internal static 437 CreateSerializationCallback(MethodInfo 1)
	{
		return new 437(new 902.904
		{
			methodInfo = 1
		}.InvokeCallback);
	}

	// Token: 0x0600100A RID: 4106 RVA: 0x000367ED File Offset: 0x000349ED
	internal static 791 CreateErrorCallback(MethodInfo 1)
	{
		return new 791(new 902.903
		{
			methodInfo = 1
		}.InvokeCallback);
	}

	// Token: 0x040007B9 RID: 1977
	internal bool isNullable;

	// Token: 0x040007BA RID: 1978
	internal bool flag3;

	// Token: 0x040007BB RID: 1979
	internal bool flag4;

	// Token: 0x040007BC RID: 1980
	internal Type nonNullableUnderlyingType;

	// Token: 0x040007BD RID: 1981
	internal 815 internalReadType;

	// Token: 0x040007BE RID: 1982
	internal 659 _recoveredType17440783;

	// Token: 0x040007BF RID: 1983
	internal bool flag5;

	// Token: 0x040007C0 RID: 1984
	internal bool flag6;

	// Token: 0x040007C1 RID: 1985
	internal bool isInstantiable;

	// Token: 0x040007C2 RID: 1986
	[241(new byte[]
	{
		2,
		1
	})]
	private List<437> list;

	// Token: 0x040007C3 RID: 1987
	[241(new byte[]
	{
		2,
		1
	})]
	private List<437> list2;

	// Token: 0x040007C4 RID: 1988
	[241(new byte[]
	{
		2,
		1
	})]
	private List<437> list3;

	// Token: 0x040007C5 RID: 1989
	[241(new byte[]
	{
		2,
		1
	})]
	private List<437> list4;

	// Token: 0x040007C6 RID: 1990
	[241(new byte[]
	{
		2,
		1
	})]
	private List<791> onErrorCallbacks;

	// Token: 0x040007C7 RID: 1991
	private Type createdType;

	// Token: 0x040007C8 RID: 1992
	private readonly Type underlyingType;

	// Token: 0x040007C9 RID: 1993
	private bool? isReference;

	// Token: 0x040007CA RID: 1994
	[241(2)]
	private 214 converter;

	// Token: 0x040007CB RID: 1995
	[241(2)]
	private 214 internalConverter;

	// Token: 0x040007CC RID: 1996
	[241(new byte[]
	{
		2,
		1
	})]
	private Func<object> func;

	// Token: 0x040007CD RID: 1997
	private bool flag8;

	// Token: 0x020001F9 RID: 505
	public sealed class 904
	{
		// Token: 0x0600100B RID: 4107 RVA: 0x00036806 File Offset: 0x00034A06
		internal void InvokeCallback(object 1, StreamingContext 2)
		{
			this.methodInfo.Invoke(1, new object[]
			{
				2
			});
		}

		// Token: 0x040007CE RID: 1998
		[241(0)]
		public MethodInfo methodInfo;
	}

	// Token: 0x020001FA RID: 506
	public sealed class 903
	{
		// Token: 0x0600100D RID: 4109 RVA: 0x00036824 File Offset: 0x00034A24
		internal void InvokeCallback(object 1, StreamingContext 2, 236 3)
		{
			this.methodInfo.Invoke(1, new object[]
			{
				2,
				3
			});
		}

		// Token: 0x040007CF RID: 1999
		[241(0)]
		public MethodInfo methodInfo;
	}
}
