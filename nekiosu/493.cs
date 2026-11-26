using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

// Token: 0x020001F0 RID: 496
[241(0)]
[242(2)]
[ComVisible(false)]
public sealed class 493 : 130
{
	// Token: 0x170000CF RID: 207
	// (get) Token: 0x06000FB6 RID: 4022 RVA: 0x00035C65 File Offset: 0x00033E65
	// (set) Token: 0x06000FB7 RID: 4023 RVA: 0x00035C6D File Offset: 0x00033E6D
	[241(new byte[]
	{
		2,
		1,
		1
	})]
	public Func<string, string> Func4189
	{
		[return: 241(new byte[]
		{
			2,
			1,
			1
		})]
		get
		{
			return this.func2;
		}
		[param: 241(new byte[]
		{
			2,
			1,
			1
		})]
		set
		{
			this.func2 = value;
		}
	}

	// Token: 0x170000D0 RID: 208
	// (get) Token: 0x06000FB8 RID: 4024 RVA: 0x00035C76 File Offset: 0x00033E76
	[241(new byte[]
	{
		2,
		1
	})]
	internal 516<object> RecoveredType10454190
	{
		[return: 241(new byte[]
		{
			2,
			1
		})]
		get
		{
			if (this._recoveredType10454187 == null && this.constructorInfo != null)
			{
				this._recoveredType10454187 = 170.GetReflectionDelegateFactory().Method9974(this.constructorInfo);
			}
			return this._recoveredType10454187;
		}
	}

	// Token: 0x170000D1 RID: 209
	// (get) Token: 0x06000FB9 RID: 4025 RVA: 0x00035CAA File Offset: 0x00033EAA
	// (set) Token: 0x06000FBA RID: 4026 RVA: 0x00035CB2 File Offset: 0x00033EB2
	[241(new byte[]
	{
		2,
		1
	})]
	public 516<object> RecoveredType10454191
	{
		[return: 241(new byte[]
		{
			2,
			1
		})]
		get
		{
			return this._recoveredType10454186;
		}
		[param: 241(new byte[]
		{
			2,
			1
		})]
		set
		{
			this._recoveredType10454186 = value;
		}
	}

	// Token: 0x06000FBB RID: 4027 RVA: 0x00035CBC File Offset: 0x00033EBC
	[242(1)]
	public 493(Type 1) : base(1)
	{
		this._recoveredType17440783 = (659)5;
		Type type;
		Type type2;
		if (143.Method3895(this.nonNullableUnderlyingType, typeof(IDictionary<, >), out this.type10))
		{
			type = this.type10.GetGenericArguments()[0];
			type2 = this.type10.GetGenericArguments()[1];
			if (143.IsGenericTypeOf(this.nonNullableUnderlyingType, typeof(IDictionary<, >)))
			{
				base.SetCreatedType(typeof(Dictionary<, >).MakeGenericType(new Type[]
				{
					type,
					type2
				}));
			}
			else if (this.nonNullableUnderlyingType.Method6705() && this.nonNullableUnderlyingType.GetGenericTypeDefinition().FullName == "System.Collections.Concurrent.ConcurrentDictionary`2")
			{
				this.flag9 = true;
			}
		}
		else
		{
			143.GetDictionaryKeyValueTypes(this.nonNullableUnderlyingType, out type, out type2);
			if (this.nonNullableUnderlyingType == typeof(IDictionary))
			{
				base.SetCreatedType(typeof(Dictionary<object, object>));
			}
		}
		if (type != null && type2 != null)
		{
			this.constructorInfo = 418.Method3168(base.GetCreatedType(), typeof(KeyValuePair<, >).MakeGenericType(new Type[]
			{
				type,
				type2
			}), typeof(IDictionary<, >).MakeGenericType(new Type[]
			{
				type,
				type2
			}));
			if (!this.Method5372() && this.nonNullableUnderlyingType.Name == "FSharpMap`2")
			{
				469.Method4454(this.nonNullableUnderlyingType.Method6708());
				this._recoveredType10454187 = 469.GetRecoveredType07893454_4445().Method4458(type, type2);
			}
		}
		if (!typeof(IDictionary).IsAssignableFrom(base.GetCreatedType()))
		{
			this.flag9 = true;
		}
		this.type8 = type;
		this.type9 = type2;
		Type createdType;
		516<object> recoveredType;
		if (this.GetType4177_5365() != null && this.GetType4178_5366() != null && 573.Method7897(this.nonNullableUnderlyingType, this.GetType4177_5365(), this.GetType4178_5366(), out createdType, out recoveredType))
		{
			base.SetCreatedType(createdType);
			this._recoveredType10454187 = recoveredType;
			this.flag5 = true;
		}
	}

	// Token: 0x06000FBC RID: 4028 RVA: 0x00035ED5 File Offset: 0x000340D5
	public Type GetType4177_5365()
	{
		return this.type8;
	}

	// Token: 0x06000FBD RID: 4029 RVA: 0x00035EDD File Offset: 0x000340DD
	public Type GetType4178_5366()
	{
		return this.type9;
	}

	// Token: 0x06000FBE RID: 4030 RVA: 0x00035EE5 File Offset: 0x000340E5
	internal 902 GetRecoveredType02514179_5367()
	{
		return this.serializerContractBase2;
	}

	// Token: 0x06000FBF RID: 4031 RVA: 0x00035EED File Offset: 0x000340ED
	internal void SetRecoveredType02514179_5368(902 1)
	{
		this.serializerContractBase2 = 1;
	}

	// Token: 0x06000FC0 RID: 4032 RVA: 0x00035EF6 File Offset: 0x000340F6
	internal bool GetFlag4184_5369()
	{
		return this.flag9;
	}

	// Token: 0x06000FC1 RID: 4033 RVA: 0x00035EFE File Offset: 0x000340FE
	public bool GetFlag4188_5370()
	{
		return this.flag10;
	}

	// Token: 0x06000FC2 RID: 4034 RVA: 0x00035F06 File Offset: 0x00034106
	public void SetFlag4188_5371(bool 1)
	{
		this.flag10 = 1;
	}

	// Token: 0x06000FC3 RID: 4035 RVA: 0x00035F0F File Offset: 0x0003410F
	internal bool Method5372()
	{
		return this.GetFlag4188_5370() || this._recoveredType10454187 != null || this.constructorInfo != null;
	}

	// Token: 0x06000FC4 RID: 4036 RVA: 0x00035F30 File Offset: 0x00034130
	[242(1)]
	internal 424 Method5373(object 1)
	{
		if (this._recoveredType10454182 == null)
		{
			this.type11 = typeof(672<, >).MakeGenericType(new Type[]
			{
				this.GetType4177_5365(),
				this.GetType4178_5366()
			});
			ConstructorInfo constructor = this.type11.GetConstructor(new Type[]
			{
				this.type10
			});
			this._recoveredType10454182 = 170.GetReflectionDelegateFactory().Method9974(constructor);
		}
		return (424)this._recoveredType10454182(new object[]
		{
			1
		});
	}

	// Token: 0x06000FC5 RID: 4037 RVA: 0x00035FB8 File Offset: 0x000341B8
	[242(1)]
	internal IDictionary Method5374()
	{
		if (this.func3 == null)
		{
			Type <<EMPTY_NAME>> = typeof(Dictionary<, >).MakeGenericType(new Type[]
			{
				this.GetType4177_5365() ?? typeof(object),
				this.GetType4178_5366() ?? typeof(object)
			});
			this.func3 = 170.GetReflectionDelegateFactory().Method9977<object>(<<EMPTY_NAME>>);
		}
		return (IDictionary)this.func3();
	}

	// Token: 0x0400079B RID: 1947
	[241(new byte[]
	{
		2,
		1,
		1
	})]
	private Func<string, string> func2;

	// Token: 0x0400079C RID: 1948
	private readonly Type type8;

	// Token: 0x0400079D RID: 1949
	private readonly Type type9;

	// Token: 0x0400079E RID: 1950
	private 902 serializerContractBase2;

	// Token: 0x0400079F RID: 1951
	private readonly Type type10;

	// Token: 0x040007A0 RID: 1952
	private Type type11;

	// Token: 0x040007A1 RID: 1953
	[241(new byte[]
	{
		2,
		1
	})]
	private 516<object> _recoveredType10454182;

	// Token: 0x040007A2 RID: 1954
	[241(new byte[]
	{
		2,
		1
	})]
	private Func<object> func3;

	// Token: 0x040007A3 RID: 1955
	private readonly bool flag9;

	// Token: 0x040007A4 RID: 1956
	private readonly ConstructorInfo constructorInfo;

	// Token: 0x040007A5 RID: 1957
	[241(new byte[]
	{
		2,
		1
	})]
	private 516<object> _recoveredType10454186;

	// Token: 0x040007A6 RID: 1958
	[241(new byte[]
	{
		2,
		1
	})]
	private 516<object> _recoveredType10454187;

	// Token: 0x040007A7 RID: 1959
	private bool flag10;
}
