using System;
using System.Collections.Generic;
using System.Reflection;

// Token: 0x02000232 RID: 562
public static class 290
{
	// Token: 0x06001168 RID: 4456 RVA: 0x0003EDD0 File Offset: 0x0003CFD0
	public static bool Method0117(Type 1)
	{
		return 1.IsGenericType && !1.IsGenericTypeDefinition && 1.GetGenericTypeDefinition() == 290.type6;
	}

	// Token: 0x06001169 RID: 4457 RVA: 0x0003EDF1 File Offset: 0x0003CFF1
	public static Type Method0118(Type 1)
	{
		while (1.HasElementType)
		{
			1 = 1.GetElementType();
		}
		return 1;
	}

	// Token: 0x0600116A RID: 4458 RVA: 0x0003EE06 File Offset: 0x0003D006
	public static Type Method0119(Type 1)
	{
		if (1.HasElementType && !1.IsArray)
		{
			1 = 1.GetElementType();
		}
		return 1;
	}

	// Token: 0x0600116B RID: 4459 RVA: 0x0003EE24 File Offset: 0x0003D024
	public static Stack<293> Method0120(Type 1)
	{
		Stack<293> stack = new Stack<293>();
		Type type = 1;
		for (;;)
		{
			if (type.IsArray)
			{
				stack.Push(new 293
				{
					number = 0,
					number2 = type.GetArrayRank()
				});
			}
			else if (type.IsByRef)
			{
				stack.Push(new 293
				{
					number = 1
				});
			}
			else
			{
				if (!type.IsPointer)
				{
					break;
				}
				stack.Push(new 293
				{
					number = 2
				});
			}
			type = type.GetElementType();
		}
		return stack;
	}

	// Token: 0x0600116C RID: 4460 RVA: 0x0003EEB4 File Offset: 0x0003D0B4
	public static Stack<293> Method0121(string 1)
	{
		string text = 1;
		Stack<293> stack = new Stack<293>();
		for (;;)
		{
			if (text.EndsWith("&", StringComparison.Ordinal))
			{
				stack.Push(new 293
				{
					number = 1
				});
				text = text.Substring(0, text.Length - 1);
			}
			else if (text.EndsWith("*", StringComparison.Ordinal))
			{
				stack.Push(new 293
				{
					number = 2
				});
				text = text.Substring(0, text.Length - 1);
			}
			else if (text.EndsWith("[]", StringComparison.Ordinal))
			{
				stack.Push(new 293
				{
					number = 0,
					number2 = 1
				});
				text = text.Substring(0, text.Length - 2);
			}
			else
			{
				if (!text.EndsWith(",]", StringComparison.Ordinal))
				{
					return stack;
				}
				int num = 1;
				int num2 = -1;
				for (int i = text.Length - 2; i >= 0; i--)
				{
					char c = text[i];
					if (c != ',')
					{
						if (c != '[')
						{
							goto Block_6;
						}
						num2 = i;
						i = -1;
					}
					else
					{
						num++;
					}
				}
				if (num2 < 0)
				{
					goto Block_8;
				}
				text = text.Substring(0, num2);
				stack.Push(new 293
				{
					number = 0,
					number2 = num
				});
			}
		}
		Block_6:
		throw new InvalidOperationException("VM-3012");
		Block_8:
		throw new InvalidOperationException("VM-3014");
	}

	// Token: 0x0600116D RID: 4461 RVA: 0x0003F018 File Offset: 0x0003D218
	public static Type Method0122(Type 1, Stack<293> 2)
	{
		Type type = 1;
		while (2.Count > 0)
		{
			293 3 = 2.Pop();
			switch (3.number)
			{
			case 0:
				type = ((3.number2 != 1) ? type.MakeArrayType(3.number2) : type.MakeArrayType());
				break;
			case 1:
				type = type.MakeByRefType();
				break;
			case 2:
				type = type.MakePointerType();
				break;
			}
		}
		return type;
	}

	// Token: 0x0600116E RID: 4462 RVA: 0x0003F088 File Offset: 0x0003D288
	public static int Method0123(Type 1)
	{
		int result;
		if (290.291.dictionary.TryGetValue(1, out result))
		{
			return result;
		}
		if (1.IsArray)
		{
			return 5;
		}
		if (!1.IsValueType)
		{
			return 16;
		}
		if (1.IsSubclassOf(290.type5))
		{
			return 10;
		}
		if (290.Method0117(1))
		{
			return 0;
		}
		return 25;
	}

	// Token: 0x040008AB RID: 2219
	public static readonly Type type3 = typeof(object);

	// Token: 0x040008AC RID: 2220
	public static readonly Type type4 = typeof(ValueType);

	// Token: 0x040008AD RID: 2221
	public static readonly Type type5 = typeof(Enum);

	// Token: 0x040008AE RID: 2222
	public static readonly Type type6 = typeof(Nullable<>);

	// Token: 0x040008AF RID: 2223
	public static readonly Type type7 = typeof(void);

	// Token: 0x040008B0 RID: 2224
	public static readonly Assembly assembly = typeof(290).Assembly;

	// Token: 0x02000233 RID: 563
	public static class 291
	{
		// Token: 0x040008B1 RID: 2225
		public static readonly Dictionary<Type, int> dictionary = new Dictionary<Type, int>
		{
			{
				typeof(object),
				7
			},
			{
				typeof(byte),
				23
			},
			{
				typeof(sbyte),
				18
			},
			{
				typeof(short),
				20
			},
			{
				typeof(int),
				15
			},
			{
				typeof(long),
				26
			},
			{
				typeof(ushort),
				9
			},
			{
				typeof(uint),
				21
			},
			{
				typeof(ulong),
				17
			},
			{
				typeof(IntPtr),
				22
			},
			{
				typeof(UIntPtr),
				14
			},
			{
				typeof(float),
				24
			},
			{
				typeof(double),
				11
			},
			{
				typeof(bool),
				19
			},
			{
				typeof(char),
				4
			},
			{
				typeof(string),
				2
			}
		};
	}
}
