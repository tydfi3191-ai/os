using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Runtime.InteropServices;

// Token: 0x020001E6 RID: 486
[ComVisible(false)]
[242(2)]
[241(0)]
public sealed class 126 : 130
{
	// Token: 0x170000CC RID: 204
	// (get) Token: 0x06000F64 RID: 3940 RVA: 0x00034C00 File Offset: 0x00032E00
	[241(new byte[]
	{
		2,
		1
	})]
	internal 516<object> RecoveredType10454652
	{
		[return: 241(new byte[]
		{
			2,
			1
		})]
		get
		{
			if (this.parameterizedCreator == null && this.parameterizedConstructor != null)
			{
				this.parameterizedCreator = 170.GetReflectionDelegateFactory().Method9974(this.parameterizedConstructor);
			}
			return this.parameterizedCreator;
		}
	}

	// Token: 0x170000CD RID: 205
	// (get) Token: 0x06000F65 RID: 3941 RVA: 0x00034C34 File Offset: 0x00032E34
	// (set) Token: 0x06000F66 RID: 3942 RVA: 0x00034C3C File Offset: 0x00032E3C
	[241(new byte[]
	{
		2,
		1
	})]
	public 516<object> RecoveredType10454653
	{
		[return: 241(new byte[]
		{
			2,
			1
		})]
		get
		{
			return this.overrideCreator;
		}
		[param: 241(new byte[]
		{
			2,
			1
		})]
		set
		{
			this.overrideCreator = value;
			this.SetCanDeserialize(true);
		}
	}

	// Token: 0x06000F67 RID: 3943 RVA: 0x00034C4C File Offset: 0x00032E4C
	[242(1)]
	public 126(Type 1) : base(1)
	{
		this._recoveredType17440783 = (659)2;
		this.isArrayLike = (base.GetCreatedType().IsArray || (this.nonNullableUnderlyingType.Method6705() && this.nonNullableUnderlyingType.GetGenericTypeDefinition().FullName == "System.Linq.EmptyPartition`1"));
		bool flag;
		Type type;
		if (this.GetIsArrayLike())
		{
			this.collectionItemType = 143.GetCollectionItemType(base.GetUnderlyingType());
			this.flag5 = true;
			this.genericCollectionDefinitionType = typeof(List<>).MakeGenericType(new Type[]
			{
				this.GetCollectionItemType()
			});
			flag = true;
			this.isMultidimensionalArray = (base.GetCreatedType().IsArray && base.GetUnderlyingType().GetArrayRank() > 1);
		}
		else if (typeof(IList).IsAssignableFrom(this.nonNullableUnderlyingType))
		{
			if (143.Method3895(this.nonNullableUnderlyingType, typeof(ICollection<>), out this.genericCollectionDefinitionType))
			{
				this.collectionItemType = this.genericCollectionDefinitionType.GetGenericArguments()[0];
			}
			else
			{
				this.collectionItemType = 143.GetCollectionItemType(this.nonNullableUnderlyingType);
			}
			if (this.nonNullableUnderlyingType == typeof(IList))
			{
				base.SetCreatedType(typeof(List<object>));
			}
			if (this.GetCollectionItemType() != null)
			{
				this.parameterizedConstructor = 418.Method3168(this.nonNullableUnderlyingType, this.GetCollectionItemType());
			}
			this.flag5 = 143.Method3897(this.nonNullableUnderlyingType, typeof(ReadOnlyCollection<>));
			flag = true;
		}
		else if (143.Method3895(this.nonNullableUnderlyingType, typeof(ICollection<>), out this.genericCollectionDefinitionType))
		{
			this.collectionItemType = this.genericCollectionDefinitionType.GetGenericArguments()[0];
			if (143.IsGenericTypeOf(this.nonNullableUnderlyingType, typeof(ICollection<>)) || 143.IsGenericTypeOf(this.nonNullableUnderlyingType, typeof(IList<>)))
			{
				base.SetCreatedType(typeof(List<>).MakeGenericType(new Type[]
				{
					this.GetCollectionItemType()
				}));
			}
			if (143.IsGenericTypeOf(this.nonNullableUnderlyingType, typeof(ISet<>)))
			{
				base.SetCreatedType(typeof(HashSet<>).MakeGenericType(new Type[]
				{
					this.GetCollectionItemType()
				}));
			}
			this.parameterizedConstructor = 418.Method3168(this.nonNullableUnderlyingType, this.GetCollectionItemType());
			flag = true;
			this.flag11 = true;
		}
		else if (143.Method3895(this.nonNullableUnderlyingType, typeof(IEnumerable<>), out type))
		{
			this.collectionItemType = type.GetGenericArguments()[0];
			if (143.IsGenericTypeOf(base.GetUnderlyingType(), typeof(IEnumerable<>)))
			{
				base.SetCreatedType(typeof(List<>).MakeGenericType(new Type[]
				{
					this.GetCollectionItemType()
				}));
			}
			this.parameterizedConstructor = 418.Method3168(this.nonNullableUnderlyingType, this.GetCollectionItemType());
			this.ConfigureFSharpListCreator(this.nonNullableUnderlyingType);
			if (this.nonNullableUnderlyingType.Method6705() && this.nonNullableUnderlyingType.GetGenericTypeDefinition() == typeof(IEnumerable<>))
			{
				this.genericCollectionDefinitionType = type;
				this.flag5 = false;
				this.flag11 = false;
				flag = true;
			}
			else
			{
				this.genericCollectionDefinitionType = typeof(List<>).MakeGenericType(new Type[]
				{
					this.GetCollectionItemType()
				});
				this.flag5 = true;
				this.flag11 = true;
				flag = this.Method5836();
			}
		}
		else
		{
			flag = false;
			this.flag11 = true;
		}
		this.SetCanDeserialize(flag);
		Type createdType;
		516<object> 2;
		if (this.GetCollectionItemType() != null && 573.Method7896(this.nonNullableUnderlyingType, this.GetCollectionItemType(), out createdType, out 2))
		{
			base.SetCreatedType(createdType);
			this.parameterizedCreator = 2;
			this.flag5 = true;
			this.SetCanDeserialize(true);
		}
	}

	// Token: 0x06000F68 RID: 3944 RVA: 0x0003501C File Offset: 0x0003321C
	public Type GetCollectionItemType()
	{
		return this.collectionItemType;
	}

	// Token: 0x06000F69 RID: 3945 RVA: 0x00035024 File Offset: 0x00033224
	public bool GetIsMultidimensionalArray()
	{
		return this.isMultidimensionalArray;
	}

	// Token: 0x06000F6A RID: 3946 RVA: 0x0003502C File Offset: 0x0003322C
	internal bool GetIsArrayLike()
	{
		return this.isArrayLike;
	}

	// Token: 0x06000F6B RID: 3947 RVA: 0x00035034 File Offset: 0x00033234
	internal bool GetFlag4646_5831()
	{
		return this.flag11;
	}

	// Token: 0x06000F6C RID: 3948 RVA: 0x0003503C File Offset: 0x0003323C
	internal bool GetCanDeserialize()
	{
		return this.canDeserialize;
	}

	// Token: 0x06000F6D RID: 3949 RVA: 0x00035044 File Offset: 0x00033244
	private void SetCanDeserialize(bool 1)
	{
		this.canDeserialize = 1;
	}

	// Token: 0x06000F6E RID: 3950 RVA: 0x0003504D File Offset: 0x0003324D
	public bool GetFlag4651_5834()
	{
		return this.flag13;
	}

	// Token: 0x06000F6F RID: 3951 RVA: 0x00035055 File Offset: 0x00033255
	public void SetFlag4651_5835(bool 1)
	{
		this.flag13 = 1;
	}

	// Token: 0x06000F70 RID: 3952 RVA: 0x0003505E File Offset: 0x0003325E
	internal bool Method5836()
	{
		return this.GetFlag4651_5834() || this.parameterizedCreator != null || this.parameterizedConstructor != null;
	}

	// Token: 0x06000F71 RID: 3953 RVA: 0x00035080 File Offset: 0x00033280
	[242(1)]
	internal 450 CreateWrapper(object 1)
	{
		if (this.genericWrapperCreator == null)
		{
			this.genericWrapperType = typeof(699<>).MakeGenericType(new Type[]
			{
				this.GetCollectionItemType()
			});
			Type type = (!143.Method3897(this.genericCollectionDefinitionType, typeof(List<>)) && !(this.genericCollectionDefinitionType.GetGenericTypeDefinition() == typeof(IEnumerable<>))) ? this.genericCollectionDefinitionType : typeof(ICollection<>).MakeGenericType(new Type[]
			{
				this.GetCollectionItemType()
			});
			ConstructorInfo constructor = this.genericWrapperType.GetConstructor(new Type[]
			{
				type
			});
			this.genericWrapperCreator = 170.GetReflectionDelegateFactory().Method9974(constructor);
		}
		return (450)this.genericWrapperCreator(new object[]
		{
			1
		});
	}

	// Token: 0x06000F72 RID: 3954 RVA: 0x00035158 File Offset: 0x00033358
	[242(1)]
	internal IList CreateTemporaryCollection()
	{
		if (this.genericTemporaryCollectionCreator == null)
		{
			Type type = (this.GetIsMultidimensionalArray() || this.GetCollectionItemType() == null) ? typeof(object) : this.GetCollectionItemType();
			Type <<EMPTY_NAME>> = typeof(List<>).MakeGenericType(new Type[]
			{
				type
			});
			this.genericTemporaryCollectionCreator = 170.GetReflectionDelegateFactory().Method9977<object>(<<EMPTY_NAME>>);
		}
		return (IList)this.genericTemporaryCollectionCreator();
	}

	// Token: 0x06000F73 RID: 3955 RVA: 0x000351D1 File Offset: 0x000333D1
	[242(1)]
	private void ConfigureFSharpListCreator(Type 1)
	{
		if (!this.Method5836() && 1.Name == "FSharpList`1")
		{
			469.Method4454(1.Method6708());
			this.parameterizedCreator = 469.GetRecoveredType07893454_4445().Method4457(this.GetCollectionItemType());
		}
	}

	// Token: 0x04000773 RID: 1907
	private readonly Type collectionItemType;

	// Token: 0x04000774 RID: 1908
	private readonly bool isMultidimensionalArray;

	// Token: 0x04000775 RID: 1909
	private readonly Type genericCollectionDefinitionType;

	// Token: 0x04000776 RID: 1910
	private Type genericWrapperType;

	// Token: 0x04000777 RID: 1911
	[241(new byte[]
	{
		2,
		1
	})]
	private 516<object> genericWrapperCreator;

	// Token: 0x04000778 RID: 1912
	[241(new byte[]
	{
		2,
		1
	})]
	private Func<object> genericTemporaryCollectionCreator;

	// Token: 0x04000779 RID: 1913
	private readonly bool isArrayLike;

	// Token: 0x0400077A RID: 1914
	private readonly bool flag11;

	// Token: 0x0400077B RID: 1915
	private bool canDeserialize;

	// Token: 0x0400077C RID: 1916
	private readonly ConstructorInfo parameterizedConstructor;

	// Token: 0x0400077D RID: 1917
	[241(new byte[]
	{
		2,
		1
	})]
	private 516<object> parameterizedCreator;

	// Token: 0x0400077E RID: 1918
	[241(new byte[]
	{
		2,
		1
	})]
	private 516<object> overrideCreator;

	// Token: 0x0400077F RID: 1919
	private bool flag13;
}
