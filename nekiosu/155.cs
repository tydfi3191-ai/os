using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;

// Token: 0x020001D5 RID: 469
[ComVisible(false)]
public sealed class 155
{
	// Token: 0x06000EEA RID: 3818 RVA: 0x000328C0 File Offset: 0x00030AC0
	public 660 GetUndefinedSchemaIdHandling()
	{
		return this.undefinedSchemaIdHandling;
	}

	// Token: 0x06000EEB RID: 3819 RVA: 0x000328C8 File Offset: 0x00030AC8
	public void SetUndefinedSchemaIdHandling(660 1)
	{
		this.undefinedSchemaIdHandling = 1;
	}

	// Token: 0x06000EEC RID: 3820 RVA: 0x000328D1 File Offset: 0x00030AD1
	public 733 GetContractResolver()
	{
		if (this.contractResolver == null)
		{
			return 65.GetInstance();
		}
		return this.contractResolver;
	}

	// Token: 0x06000EED RID: 3821 RVA: 0x000328E7 File Offset: 0x00030AE7
	public void SetContractResolver(733 1)
	{
		this.contractResolver = 1;
	}

	// Token: 0x06000EEE RID: 3822 RVA: 0x000328F0 File Offset: 0x00030AF0
	private 529 GetCurrentSchema()
	{
		return this.currentSchema;
	}

	// Token: 0x06000EEF RID: 3823 RVA: 0x000328F8 File Offset: 0x00030AF8
	private void Push(155.157 1)
	{
		this.currentSchema = 1.GetSchema();
		this.iList.Add(1);
		this.resolver.GetIList9362_11936().Add(1.GetSchema());
	}

	// Token: 0x06000EF0 RID: 3824 RVA: 0x00032928 File Offset: 0x00030B28
	private 155.157 Pop()
	{
		155.157 result = this.iList[this.iList.Count - 1];
		this.iList.RemoveAt(this.iList.Count - 1);
		155.157 <<EMPTY_NAME>> = this.iList.LastOrDefault<155.157>();
		if (<<EMPTY_NAME>> != null)
		{
			this.currentSchema = <<EMPTY_NAME>>.GetSchema();
			return result;
		}
		this.currentSchema = null;
		return result;
	}

	// Token: 0x06000EF1 RID: 3825 RVA: 0x0003298B File Offset: 0x00030B8B
	public 529 Method10019(Type 1)
	{
		return this.Method10019(1, new 744(), false);
	}

	// Token: 0x06000EF2 RID: 3826 RVA: 0x0003299A File Offset: 0x00030B9A
	public 529 Method10019(Type 1, 744 2)
	{
		return this.Method10019(1, 2, false);
	}

	// Token: 0x06000EF3 RID: 3827 RVA: 0x000329A5 File Offset: 0x00030BA5
	public 529 Method10019(Type 1, bool 2)
	{
		return this.Method10019(1, new 744(), 2);
	}

	// Token: 0x06000EF4 RID: 3828 RVA: 0x000329B4 File Offset: 0x00030BB4
	public 529 Method10019(Type 1, 744 2, bool 3)
	{
		756.Method12216(1, "type");
		756.Method12216(2, "resolver");
		this.resolver = 2;
		return this.GenerateInternal(1, (!3) ? ((896)2) : ((896)0), false);
	}

	// Token: 0x06000EF5 RID: 3829 RVA: 0x000329E4 File Offset: 0x00030BE4
	private string GetTitle(Type 1)
	{
		129 attribute = 170.GetAttribute<129>(1);
		if (!538.Method6824((attribute != null) ? attribute.Title : null))
		{
			return attribute.Title;
		}
		return null;
	}

	// Token: 0x06000EF6 RID: 3830 RVA: 0x00032A14 File Offset: 0x00030C14
	private string GetDescription(Type 1)
	{
		129 attribute = 170.GetAttribute<129>(1);
		if (!538.Method6824((attribute != null) ? attribute.Description : null))
		{
			return attribute.Description;
		}
		DescriptionAttribute descriptionAttribute = 143.Method3911<DescriptionAttribute>(1);
		if (descriptionAttribute == null)
		{
			return null;
		}
		return descriptionAttribute.Description;
	}

	// Token: 0x06000EF7 RID: 3831 RVA: 0x00032A54 File Offset: 0x00030C54
	private string GetId(Type 1, bool 2)
	{
		129 attribute = 170.GetAttribute<129>(1);
		if (!538.Method6824((attribute != null) ? attribute.Id : null))
		{
			return attribute.Id;
		}
		if (2)
		{
			return null;
		}
		660 3 = this.GetUndefinedSchemaIdHandling();
		string result;
		if (3 != (660)1)
		{
			if (3 != (660)2)
			{
				result = null;
			}
			else
			{
				result = 1.AssemblyQualifiedName;
			}
		}
		else
		{
			result = 1.FullName;
		}
		return result;
	}

	// Token: 0x06000EF8 RID: 3832 RVA: 0x00032AB0 File Offset: 0x00030CB0
	private 529 GenerateInternal(Type 1, 896 2, bool 3)
	{
		155.156 4 = new 155.156();
		4.type = 1;
		756.Method12216(4.type, "type");
		string id = this.GetId(4.type, false);
		string id2 = this.GetId(4.type, true);
		if (!538.Method6824(id))
		{
			529 5 = this.resolver.Method11938(id);
			if (5 != null)
			{
				if (2 != (896)2 && !155.Method10028(5.GetNullable5098_6384(), 235.Null))
				{
					5.SetNullable5098_6385(5.GetNullable5098_6384() | 235.Null);
				}
				if (3 && !5.GetNullable5093_6374().GetValueOrDefault())
				{
					5.SetNullable5093_6375(new bool?(true));
				}
				return 5;
			}
		}
		if (this.iList.Any(new Func<155.157, bool>(4.MatchesType)))
		{
			throw new 134("Unresolved circular reference for type '{0}'. Explicitly define an Id for the type using a JsonObject/JsonArray attribute or automatically generate a type Id using the UndefinedSchemaIdHandling property.".Method6825(CultureInfo.InvariantCulture, 4.type));
		}
		902 6 = this.GetContractResolver().ResolveContract(4.type);
		bool flag = (6.Converter ?? 6.InternalConverter) != null;
		this.Push(new 155.157(4.type, new 529()));
		if (id2 != null)
		{
			this.GetCurrentSchema().SetText5091_6371(id2);
		}
		if (3)
		{
			this.GetCurrentSchema().SetNullable5093_6375(new bool?(true));
		}
		this.GetCurrentSchema().SetText5092_6373(this.GetTitle(4.type));
		this.GetCurrentSchema().SetText5097_6383(this.GetDescription(4.type));
		if (flag)
		{
			this.GetCurrentSchema().SetNullable5098_6385(new 235?(235.Any));
		}
		else
		{
			switch (6._recoveredType17440783)
			{
			case (659)1:
				this.GetCurrentSchema().SetNullable5098_6385(new 235?(this.AddNullType(235.Object, 2)));
				this.GetCurrentSchema().SetText5091_6371(this.GetId(4.type, false));
				this.GenerateObjectSchema(4.type, (612)6);
				break;
			case (659)2:
			{
				this.GetCurrentSchema().SetNullable5098_6385(new 235?(this.AddNullType(235.Array, 2)));
				this.GetCurrentSchema().SetText5091_6371(this.GetId(4.type, false));
				702 attribute = 170.GetAttribute<702>(4.type);
				bool flag2 = attribute == null || attribute.Flag8459;
				Type collectionItemType = 143.GetCollectionItemType(4.type);
				if (collectionItemType != null)
				{
					this.GetCurrentSchema().SetIList5109_6407(new List<529>());
					this.GetCurrentSchema().GetIList5109_6406().Add(this.GenerateInternal(collectionItemType, (!flag2) ? ((896)2) : ((896)0), false));
				}
				break;
			}
			case (659)3:
				this.GetCurrentSchema().SetNullable5098_6385(new 235?(this.GetJsonSchemaType(4.type, 2)));
				if (this.GetCurrentSchema().GetNullable5098_6384().GetValueOrDefault() == 235.Integer && 4.type.Method6709() && !4.type.IsDefined(typeof(FlagsAttribute), true))
				{
					this.GetCurrentSchema().SetIList5119_6427(new List<226>());
					678 enumValuesAndNames = 83.GetEnumValuesAndNames(4.type);
					for (int i = 0; i < enumValuesAndNames.textArray3.Length; i++)
					{
						ulong value = enumValuesAndNames.numberArray2[i];
						226 item = 226.FromObject(Enum.ToObject(4.type, value));
						this.GetCurrentSchema().GetIList5119_6426().Add(item);
					}
				}
				break;
			case (659)4:
			{
				235 value2 = (!143.IsNullable(6.GetUnderlyingType())) ? 235.String : this.AddNullType(235.String, 2);
				this.GetCurrentSchema().SetNullable5098_6385(new 235?(value2));
				break;
			}
			case (659)5:
			{
				this.GetCurrentSchema().SetNullable5098_6385(new 235?(this.AddNullType(235.Object, 2)));
				Type type;
				Type 7;
				143.GetDictionaryKeyValueTypes(4.type, out type, out 7);
				if (type != null && this.GetContractResolver().ResolveContract(type)._recoveredType17440783 == (659)3)
				{
					this.GetCurrentSchema().SetRecoveredType11435115_6419(this.GenerateInternal(7, (896)0, false));
				}
				break;
			}
			case (659)6:
			case (659)8:
				this.GetCurrentSchema().SetNullable5098_6385(new 235?(235.Any));
				break;
			case (659)7:
				this.GetCurrentSchema().SetNullable5098_6385(new 235?(this.AddNullType(235.Object, 2)));
				this.GetCurrentSchema().SetText5091_6371(this.GetId(4.type, false));
				this.GenerateISerializableContract(4.type, (515)6);
				break;
			default:
				throw new 134("Unexpected contract type: {0}".Method6825(CultureInfo.InvariantCulture, 6));
			}
		}
		return this.Pop().GetSchema();
	}

	// Token: 0x06000EF9 RID: 3833 RVA: 0x00032F48 File Offset: 0x00031148
	private 235 AddNullType(235 1, 896 2)
	{
		if (2 != (896)2)
		{
			return 1 | 235.Null;
		}
		return 1;
	}

	// Token: 0x06000EFA RID: 3834 RVA: 0x00010382 File Offset: 0x0000E582
	private bool Method10028(50 1, 50 2)
	{
		return (1 & 2) == 2;
	}

	// Token: 0x06000EFB RID: 3835 RVA: 0x00032F54 File Offset: 0x00031154
	private void GenerateObjectSchema(Type 1, 612 2)
	{
		this.GetCurrentSchema().SetIDictionary5114_6417(new Dictionary<string, 529>());
		foreach (666 3 in 2.RecoveredType17666960)
		{
			if (!3.GetFlag7770_9897())
			{
				bool flag = 3.GetNullable7775_9913().GetValueOrDefault() == (240)1 || this.Method10028(3.GetNullable7776_9915().GetValueOrDefault(), (50)1) || 3.Predicate7788 != null || 3.Predicate7790 != null;
				529 4 = this.GenerateInternal(3.GetType7762_9891(), 3.Method9908(), !flag);
				if (3.Method9905() != null)
				{
					4.SetJToken5121_6431(226.FromObject(3.Method9905()));
				}
				this.GetCurrentSchema().GetIDictionary5114_6416().Add(3.GetText7760_9879(), 4);
			}
		}
		if (1.Method6711())
		{
			this.GetCurrentSchema().SetFlag5117_6423(false);
		}
	}

	// Token: 0x06000EFC RID: 3836 RVA: 0x00033058 File Offset: 0x00031258
	private void GenerateISerializableContract(Type 1, 515 2)
	{
		this.GetCurrentSchema().SetFlag5117_6423(true);
	}

	// Token: 0x06000EFD RID: 3837 RVA: 0x00033068 File Offset: 0x00031268
	internal static bool Method10028(235? 1, 235 2)
	{
		if (1 == null)
		{
			return true;
		}
		235? 3 = 1 & 2;
		if (3.GetValueOrDefault() == 2 & 3 != null)
		{
			return true;
		}
		if (2 == 235.Integer)
		{
			uint? num = (uint)(1 & 235.Float);
			uint num2 = 2U;
			if (num.GetValueOrDefault() == num2 & num != null)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06000EFE RID: 3838 RVA: 0x00033108 File Offset: 0x00031308
	private 235 GetJsonSchemaType(Type 1, 896 2)
	{
		235 3 = 235.None;
		if (2 != (896)2 && 143.IsNullable(1))
		{
			3 = 235.Null;
			if (143.IsNullableType(1))
			{
				1 = Nullable.GetUnderlyingType(1);
			}
		}
		723 4 = 358.Method1490(1);
		switch (4)
		{
		case 723.Empty:
		case 723.Object:
			return 3 | 235.String;
		case 723.Char:
			return 3 | 235.String;
		case 723.Boolean:
			return 3 | 235.Boolean;
		case 723.SByte:
		case 723.Int16:
		case 723.UInt16:
		case 723.Int32:
		case 723.Byte:
		case 723.UInt32:
		case 723.Int64:
		case 723.UInt64:
		case 723.BigInteger:
			return 3 | 235.Integer;
		case 723.Single:
		case 723.Double:
		case 723.Decimal:
			return 3 | 235.Float;
		case 723.DateTime:
		case 723.DateTimeOffset:
			return 3 | 235.String;
		case 723.Guid:
		case 723.TimeSpan:
		case 723.Uri:
		case 723.String:
		case 723.Bytes:
			return 3 | 235.String;
		case 723.DBNull:
			return 3 | 235.Null;
		}
		throw new 134("Unexpected type code '{0}' for type '{1}'.".Method6825(CultureInfo.InvariantCulture, 4, 1));
	}

	// Token: 0x04000742 RID: 1858
	private 660 undefinedSchemaIdHandling;

	// Token: 0x04000743 RID: 1859
	private 733 contractResolver;

	// Token: 0x04000744 RID: 1860
	private 744 resolver;

	// Token: 0x04000745 RID: 1861
	private readonly IList<155.157> iList = new List<155.157>();

	// Token: 0x04000746 RID: 1862
	private 529 currentSchema;

	// Token: 0x020001D6 RID: 470
	public sealed class 157
	{
		// Token: 0x06000F00 RID: 3840 RVA: 0x0003323C File Offset: 0x0003143C
		public 157(Type 1, 529 2)
		{
			756.Method12216(1, "type");
			756.Method12216(2, "schema");
			this.targetType = 1;
			this.schema = 2;
		}

		// Token: 0x06000F01 RID: 3841 RVA: 0x00033268 File Offset: 0x00031468
		public Type GetTargetType()
		{
			return this.targetType;
		}

		// Token: 0x06000F02 RID: 3842 RVA: 0x00033270 File Offset: 0x00031470
		public 529 GetSchema()
		{
			return this.schema;
		}

		// Token: 0x04000747 RID: 1863
		private readonly Type targetType;

		// Token: 0x04000748 RID: 1864
		private readonly 529 schema;
	}

	// Token: 0x020001D7 RID: 471
	public sealed class 156
	{
		// Token: 0x06000F03 RID: 3843 RVA: 0x00033278 File Offset: 0x00031478
		internal bool MatchesType(155.157 1)
		{
			return 1.GetTargetType() == this.type;
		}

		// Token: 0x04000749 RID: 1865
		public Type type;
	}
}
