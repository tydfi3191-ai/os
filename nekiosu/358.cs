using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Numerics;
using System.Reflection;

// Token: 0x02000113 RID: 275
[241(0)]
[242(1)]
public static class 358
{
	// Token: 0x060009FD RID: 2557 RVA: 0x00024E48 File Offset: 0x00023048
	public static 723 Method1490(Type 1)
	{
		bool flag;
		return 358.Method1490(1, out flag);
	}

	// Token: 0x060009FE RID: 2558 RVA: 0x00024E60 File Offset: 0x00023060
	public static 723 Method1490(Type 1, out bool 2)
	{
		723 result;
		if (358.dictionary.TryGetValue(1, out result))
		{
			2 = false;
			return result;
		}
		if (1.Method6709())
		{
			2 = true;
			return 358.Method1490(Enum.GetUnderlyingType(1));
		}
		if (143.IsNullableType(1))
		{
			Type underlyingType = Nullable.GetUnderlyingType(1);
			if (underlyingType.Method6709())
			{
				Type 3 = typeof(Nullable<>).MakeGenericType(new Type[]
				{
					Enum.GetUnderlyingType(underlyingType)
				});
				2 = true;
				return 358.Method1490(3);
			}
		}
		2 = false;
		return 723.Object;
	}

	// Token: 0x060009FF RID: 2559 RVA: 0x00024EDA File Offset: 0x000230DA
	public static 697 Method1492(IConvertible 1)
	{
		return 358._recoveredType1927Array0920[(int)1.GetTypeCode()];
	}

	// Token: 0x06000A00 RID: 2560 RVA: 0x00024EE8 File Offset: 0x000230E8
	public static bool Method1493(Type 1)
	{
		return typeof(IConvertible).IsAssignableFrom(1);
	}

	// Token: 0x06000A01 RID: 2561 RVA: 0x00024EFA File Offset: 0x000230FA
	public static TimeSpan Method1494(string 1)
	{
		return TimeSpan.Parse(1, CultureInfo.InvariantCulture);
	}

	// Token: 0x06000A02 RID: 2562 RVA: 0x00024F08 File Offset: 0x00023108
	[242(2)]
	private static Func<object, object> Method1495([241(new byte[]
	{
		0,
		1,
		1
	})] 558<Type, Type> 1)
	{
		358.359 2 = new 358.359();
		Type item = 1._item5821;
		Type item2 = 1._item5822;
		MethodInfo method;
		if ((method = item2.GetMethod("op_Implicit", new Type[]
		{
			item
		})) == null)
		{
			method = item2.GetMethod("op_Explicit", new Type[]
			{
				item
			});
		}
		MethodInfo methodInfo = method;
		if (methodInfo == null)
		{
			return null;
		}
		2._recoveredType06220918 = 170.GetReflectionDelegateFactory().Method9975<object>(methodInfo);
		return new Func<object, object>(2.Method1489);
	}

	// Token: 0x06000A03 RID: 2563 RVA: 0x00024F80 File Offset: 0x00023180
	internal static BigInteger Method1496(object 1)
	{
		if (1 is BigInteger)
		{
			return (BigInteger)1;
		}
		string text = 1 as string;
		if (text != null)
		{
			return BigInteger.Parse(text, CultureInfo.InvariantCulture);
		}
		if (1 is float)
		{
			float value = (float)1;
			return new BigInteger(value);
		}
		if (1 is double)
		{
			double value2 = (double)1;
			return new BigInteger(value2);
		}
		if (1 is decimal)
		{
			decimal value3 = (decimal)1;
			return new BigInteger(value3);
		}
		if (1 is int)
		{
			int value4 = (int)1;
			return new BigInteger(value4);
		}
		if (1 is long)
		{
			long value5 = (long)1;
			return new BigInteger(value5);
		}
		if (1 is uint)
		{
			uint value6 = (uint)1;
			return new BigInteger(value6);
		}
		if (1 is ulong)
		{
			ulong value7 = (ulong)1;
			return new BigInteger(value7);
		}
		byte[] array = 1 as byte[];
		if (array != null)
		{
			return new BigInteger(array);
		}
		throw new InvalidCastException("Cannot convert {0} to BigInteger.".Method6825(CultureInfo.InvariantCulture, 1.GetType()));
	}

	// Token: 0x06000A04 RID: 2564 RVA: 0x00025084 File Offset: 0x00023284
	public static object Method1497(BigInteger 1, Type 2)
	{
		if (2 == typeof(decimal))
		{
			return (decimal)1;
		}
		if (2 == typeof(double))
		{
			return (double)1;
		}
		if (2 == typeof(float))
		{
			return (float)1;
		}
		if (2 == typeof(ulong))
		{
			return (ulong)1;
		}
		if (2 == typeof(bool))
		{
			return 1 != 0L;
		}
		object result;
		try
		{
			result = Convert.ChangeType((long)1, 2, CultureInfo.InvariantCulture);
		}
		catch (Exception innerException)
		{
			throw new InvalidOperationException("Can not convert from BigInteger to {0}.".Method6825(CultureInfo.InvariantCulture, 2), innerException);
		}
		return result;
	}

	// Token: 0x06000A05 RID: 2565 RVA: 0x00025170 File Offset: 0x00023370
	public static object Method1498(object 1, CultureInfo 2, Type 3)
	{
		object result;
		switch (358.Method1500(1, 2, 3, out result))
		{
		case (358.360)0:
			return result;
		case (358.360)1:
			throw new Exception("Can not convert null {0} into non-nullable {1}.".Method6825(CultureInfo.InvariantCulture, 1.GetType(), 3));
		case (358.360)2:
			throw new ArgumentException("Target type {0} is not a value type or a non-abstract class.".Method6825(CultureInfo.InvariantCulture, 3), "#=z_ohxpzI=");
		case (358.360)3:
			throw new InvalidOperationException("Can not convert from {0} to {1}.".Method6825(CultureInfo.InvariantCulture, 1.GetType(), 3));
		default:
			throw new InvalidOperationException("Unexpected conversion result.");
		}
	}

	// Token: 0x06000A06 RID: 2566 RVA: 0x00025204 File Offset: 0x00023404
	private static bool Method1499([241(2)] object 1, CultureInfo 2, Type 3, [241(2)] out object 4)
	{
		bool result;
		try
		{
			if (358.Method1500(1, 2, 3, out 4) == (358.360)0)
			{
				result = true;
			}
			else
			{
				4 = null;
				result = false;
			}
		}
		catch
		{
			4 = null;
			result = false;
		}
		return result;
	}

	// Token: 0x06000A07 RID: 2567 RVA: 0x00025240 File Offset: 0x00023440
	private static 358.360 Method1500([241(2)] object 1, CultureInfo 2, Type 3, [241(2)] out object 4)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("initialValue");
		}
		if (143.IsNullableType(3))
		{
			3 = Nullable.GetUnderlyingType(3);
		}
		Type type = 1.GetType();
		if (3 == type)
		{
			4 = 1;
			return (358.360)0;
		}
		if (358.Method1493(1.GetType()) && 358.Method1493(3))
		{
			if (3.Method6709())
			{
				if (1 is string)
				{
					4 = Enum.Parse(3, 1.ToString(), true);
					return (358.360)0;
				}
				if (358.Method1504(1))
				{
					4 = Enum.ToObject(3, 1);
					return (358.360)0;
				}
			}
			4 = Convert.ChangeType(1, 3, 2);
			return (358.360)0;
		}
		if (1 is DateTime)
		{
			DateTime dateTime = (DateTime)1;
			if (3 == typeof(DateTimeOffset))
			{
				4 = new DateTimeOffset(dateTime);
				return (358.360)0;
			}
		}
		byte[] array = 1 as byte[];
		if (array != null && 3 == typeof(Guid))
		{
			4 = new Guid(array);
			return (358.360)0;
		}
		if (1 is Guid)
		{
			Guid guid = (Guid)1;
			if (3 == typeof(byte[]))
			{
				4 = guid.ToByteArray();
				return (358.360)0;
			}
		}
		string text = 1 as string;
		if (text != null)
		{
			if (3 == typeof(Guid))
			{
				4 = new Guid(text);
				return (358.360)0;
			}
			if (3 == typeof(Uri))
			{
				4 = new Uri(text, UriKind.RelativeOrAbsolute);
				return (358.360)0;
			}
			if (3 == typeof(TimeSpan))
			{
				4 = 358.Method1494(text);
				return (358.360)0;
			}
			if (3 == typeof(byte[]))
			{
				4 = Convert.FromBase64String(text);
				return (358.360)0;
			}
			if (3 == typeof(Version))
			{
				Version version;
				if (358.Method1503(text, out version))
				{
					4 = version;
					return (358.360)0;
				}
				4 = null;
				return (358.360)3;
			}
			else if (typeof(Type).IsAssignableFrom(3))
			{
				4 = Type.GetType(text, true);
				return (358.360)0;
			}
		}
		if (3 == typeof(BigInteger))
		{
			4 = 358.Method1496(1);
			return (358.360)0;
		}
		if (1 is BigInteger)
		{
			BigInteger 5 = (BigInteger)1;
			4 = 358.Method1497(5, 3);
			return (358.360)0;
		}
		TypeConverter converter = TypeDescriptor.GetConverter(type);
		if (converter != null && converter.CanConvertTo(3))
		{
			4 = converter.ConvertTo(null, 2, 1, 3);
			return (358.360)0;
		}
		TypeConverter converter2 = TypeDescriptor.GetConverter(3);
		if (converter2 != null && converter2.CanConvertFrom(type))
		{
			4 = converter2.ConvertFrom(null, 2, 1);
			return (358.360)0;
		}
		if (1 == DBNull.Value)
		{
			if (143.IsNullable(3))
			{
				4 = 358.Method1502(null, type, 3);
				return (358.360)0;
			}
			4 = null;
			return (358.360)1;
		}
		else
		{
			if (3.Method6704() || 3.Method6706() || 3.Method6712())
			{
				4 = null;
				return (358.360)2;
			}
			4 = null;
			return (358.360)3;
		}
	}

	// Token: 0x06000A08 RID: 2568 RVA: 0x000254F8 File Offset: 0x000236F8
	[return: 241(2)]
	public static object Method1501([241(2)] object 1, CultureInfo 2, Type 3)
	{
		if (3 == typeof(object))
		{
			return 1;
		}
		if (1 == null && 143.IsNullable(3))
		{
			return null;
		}
		object result;
		if (358.Method1499(1, 2, 3, out result))
		{
			return result;
		}
		return 358.Method1502(1, 143.GetObjectType(1), 3);
	}

	// Token: 0x06000A09 RID: 2569 RVA: 0x00025544 File Offset: 0x00023744
	[return: 241(2)]
	private static object Method1502([241(2)] object 1, Type 2, Type 3)
	{
		if (1 != null)
		{
			Type type = 1.GetType();
			if (3.IsAssignableFrom(type))
			{
				return 1;
			}
			Func<object, object> func = 358._recoveredType08380921.Method4701(new 558<Type, Type>(type, 3));
			if (func != null)
			{
				return func(1);
			}
		}
		else if (143.IsNullable(3))
		{
			return null;
		}
		throw new ArgumentException("Could not cast or convert from {0} to {1}.".Method6825(CultureInfo.InvariantCulture, ((2 != null) ? 2.ToString() : null) ?? "{null}", 3));
	}

	// Token: 0x06000A0A RID: 2570 RVA: 0x000255B7 File Offset: 0x000237B7
	public static bool Method1503(string 1, [239(true)] [241(2)] out Version 2)
	{
		return Version.TryParse(1, out 2);
	}

	// Token: 0x06000A0B RID: 2571 RVA: 0x000255C0 File Offset: 0x000237C0
	public static bool Method1504(object 1)
	{
		switch (358.Method1490(1.GetType()))
		{
		case 723.SByte:
		case 723.Int16:
		case 723.UInt16:
		case 723.Int32:
		case 723.Byte:
		case 723.UInt32:
		case 723.Int64:
		case 723.UInt64:
			return true;
		}
		return false;
	}

	// Token: 0x06000A0C RID: 2572 RVA: 0x00025624 File Offset: 0x00023824
	public static 514 Method1505(char[] 1, int 2, int 3, out int 4)
	{
		4 = 0;
		if (3 == 0)
		{
			return (514)3;
		}
		bool flag = 1[2] == '-';
		if (flag)
		{
			if (3 == 1)
			{
				return (514)3;
			}
			2++;
			3--;
		}
		int num = 2 + 3;
		if (3 > 10 || (3 == 10 && 1[2] - '0' > '\u0002'))
		{
			for (int i = 2; i < num; i++)
			{
				int num2 = (int)(1[i] - '0');
				if (num2 < 0 || num2 > 9)
				{
					return (514)3;
				}
			}
			return (514)2;
		}
		for (int j = 2; j < num; j++)
		{
			int num3 = (int)(1[j] - '0');
			if (num3 < 0 || num3 > 9)
			{
				return (514)3;
			}
			int num4 = 10 * 4 - num3;
			if (num4 > 4)
			{
				for (j++; j < num; j++)
				{
					num3 = (int)(1[j] - '0');
					if (num3 < 0 || num3 > 9)
					{
						return (514)3;
					}
				}
				return (514)2;
			}
			4 = num4;
		}
		if (!flag)
		{
			if (4 == -2147483648)
			{
				return (514)2;
			}
			4 = -4;
		}
		return (514)1;
	}

	// Token: 0x06000A0D RID: 2573 RVA: 0x00025704 File Offset: 0x00023904
	public static 514 Method1506(char[] 1, int 2, int 3, out long 4)
	{
		4 = 0L;
		if (3 == 0)
		{
			return (514)3;
		}
		bool flag = 1[2] == '-';
		if (flag)
		{
			if (3 == 1)
			{
				return (514)3;
			}
			2++;
			3--;
		}
		int num = 2 + 3;
		if (3 > 19)
		{
			for (int i = 2; i < num; i++)
			{
				int num2 = (int)(1[i] - '0');
				if (num2 < 0 || num2 > 9)
				{
					return (514)3;
				}
			}
			return (514)2;
		}
		for (int j = 2; j < num; j++)
		{
			int num3 = (int)(1[j] - '0');
			if (num3 < 0 || num3 > 9)
			{
				return (514)3;
			}
			long num4 = 10L * 4 - (long)num3;
			if (num4 > 4)
			{
				for (j++; j < num; j++)
				{
					num3 = (int)(1[j] - '0');
					if (num3 < 0 || num3 > 9)
					{
						return (514)3;
					}
				}
				return (514)2;
			}
			4 = num4;
		}
		if (!flag)
		{
			if (4 == -9223372036854775808L)
			{
				return (514)2;
			}
			4 = -4;
		}
		return (514)1;
	}

	// Token: 0x06000A0E RID: 2574 RVA: 0x000257E0 File Offset: 0x000239E0
	public static 514 Method1507(char[] 1, int 2, int 3, out decimal 4)
	{
		4 = 0m;
		if (3 == 0)
		{
			return (514)3;
		}
		bool flag = 1[2] == '-';
		if (flag)
		{
			if (3 == 1)
			{
				return (514)3;
			}
			2++;
			3--;
		}
		int i = 2;
		int num = 2 + 3;
		int num2 = num;
		int num3 = num;
		int num4 = 0;
		ulong num5 = 0UL;
		ulong num6 = 0UL;
		int num7 = 0;
		int num8 = 0;
		char? c = null;
		bool? flag2 = null;
		while (i < num)
		{
			char c2 = 1[i];
			if (c2 == '.')
			{
				goto IL_16A;
			}
			if (c2 != 'E' && c2 != 'e')
			{
				if (c2 < '0' || c2 > '9')
				{
					return (514)3;
				}
				if (i == 2 && c2 == '0')
				{
					i++;
					if (i != num)
					{
						c2 = 1[i];
						if (c2 == '.')
						{
							goto IL_16A;
						}
						if (c2 != 'e' && c2 != 'E')
						{
							return (514)3;
						}
						goto IL_1A1;
					}
				}
				if (num7 < 29)
				{
					if (num7 == 28)
					{
						bool? flag3 = flag2;
						bool valueOrDefault;
						if (flag3 == null)
						{
							flag2 = new bool?(num5 > 7922816251426433759UL || (num5 == 7922816251426433759UL && (num6 > 354395033UL || (num6 == 354395033UL && c2 > '5'))));
							bool? flag4 = flag2;
							valueOrDefault = flag4.GetValueOrDefault();
						}
						else
						{
							valueOrDefault = flag3.GetValueOrDefault();
						}
						if (valueOrDefault)
						{
							goto IL_187;
						}
					}
					if (num7 < 19)
					{
						num5 = num5 * 10UL + (ulong)((long)(c2 - '0'));
					}
					else
					{
						num6 = num6 * 10UL + (ulong)((long)(c2 - '0'));
					}
					num7++;
					goto IL_21E;
				}
				IL_187:
				if (c == null)
				{
					c = new char?(c2);
				}
				num8++;
				goto IL_21E;
			}
			IL_1A1:
			if (i == 2)
			{
				return (514)3;
			}
			if (i == num2)
			{
				return (514)3;
			}
			i++;
			if (i == num)
			{
				return (514)3;
			}
			if (num2 < num)
			{
				num3 = i - 1;
			}
			c2 = 1[i];
			bool flag5 = false;
			if (c2 != '+')
			{
				if (c2 == '-')
				{
					flag5 = true;
					i++;
				}
			}
			else
			{
				i++;
			}
			while (i < num)
			{
				c2 = 1[i];
				if (c2 < '0' || c2 > '9')
				{
					return (514)3;
				}
				int num9 = 10 * num4 + (int)(c2 - '0');
				if (num4 < num9)
				{
					num4 = num9;
				}
				i++;
			}
			if (flag5)
			{
				num4 = -num4;
			}
			IL_21E:
			i++;
			continue;
			IL_16A:
			if (i == 2)
			{
				return (514)3;
			}
			if (i + 1 == num)
			{
				return (514)3;
			}
			if (num2 != num)
			{
				return (514)3;
			}
			num2 = i + 1;
			goto IL_21E;
		}
		num4 += num8;
		num4 -= num3 - num2;
		if (num7 <= 19)
		{
			4 = num5;
		}
		else
		{
			4 = num5 / new decimal(1, 0, 0, false, (byte)(num7 - 19)) + num6;
		}
		if (num4 > 0)
		{
			num7 += num4;
			if (num7 > 29)
			{
				return (514)2;
			}
			if (num7 == 29)
			{
				if (num4 > 1)
				{
					4 /= new decimal(1, 0, 0, false, (byte)(num4 - 1));
					if (4 > 7922816251426433759354395033m)
					{
						return (514)2;
					}
				}
				else if (4 == 7922816251426433759354395033m)
				{
					char? c3 = c;
					int? num10 = (c3 != null) ? new int?((int)c3.GetValueOrDefault()) : null;
					int num11 = 53;
					if (num10.GetValueOrDefault() > num11 & num10 != null)
					{
						return (514)2;
					}
				}
				4 *= 10m;
			}
			else
			{
				4 /= new decimal(1, 0, 0, false, (byte)num4);
			}
		}
		else
		{
			char? c3 = c;
			int? num10 = (c3 != null) ? new int?((int)c3.GetValueOrDefault()) : null;
			int num11 = 53;
			if ((num10.GetValueOrDefault() >= num11 & num10 != null) && num4 >= -28)
			{
				4 = ++4;
			}
			if (num4 < 0)
			{
				if (num7 + num4 + 28 <= 0)
				{
					4 = (flag ? 0m : 0m);
					return (514)1;
				}
				if (num4 >= -28)
				{
					4 *= new decimal(1, 0, 0, false, (byte)(-(byte)num4));
				}
				else
				{
					4 /= 10000000000000000000000000000m;
					4 *= new decimal(1, 0, 0, false, (byte)(-num4 - 28));
				}
			}
		}
		if (flag)
		{
			4 = -4;
		}
		return (514)1;
	}

	// Token: 0x06000A0F RID: 2575 RVA: 0x00025C7C File Offset: 0x00023E7C
	public static bool Method1508(string 1, out Guid 2)
	{
		return Guid.TryParseExact(1, "D", out 2);
	}

	// Token: 0x06000A10 RID: 2576 RVA: 0x00025C8C File Offset: 0x00023E8C
	public static bool Method1509(char[] 1, int 2, int 3, out int 4)
	{
		4 = 0;
		for (int i = 2; i < 3; i++)
		{
			char c = 1[i];
			int num;
			if (c <= '9' && c >= '0')
			{
				num = (int)(c - '0');
			}
			else if (c <= 'F' && c >= 'A')
			{
				num = (int)(c - '7');
			}
			else
			{
				if (c > 'f' || c < 'a')
				{
					4 = 0;
					return false;
				}
				num = (int)(c - 'W');
			}
			4 += num << (3 - 1 - i) * 4;
		}
		return true;
	}

	// Token: 0x0400050C RID: 1292
	private static readonly Dictionary<Type, 723> dictionary = new Dictionary<Type, 723>
	{
		{
			typeof(char),
			723.Char
		},
		{
			typeof(char?),
			723.CharNullable
		},
		{
			typeof(bool),
			723.Boolean
		},
		{
			typeof(bool?),
			723.BooleanNullable
		},
		{
			typeof(sbyte),
			723.SByte
		},
		{
			typeof(sbyte?),
			723.SByteNullable
		},
		{
			typeof(short),
			723.Int16
		},
		{
			typeof(short?),
			723.Int16Nullable
		},
		{
			typeof(ushort),
			723.UInt16
		},
		{
			typeof(ushort?),
			723.UInt16Nullable
		},
		{
			typeof(int),
			723.Int32
		},
		{
			typeof(int?),
			723.Int32Nullable
		},
		{
			typeof(byte),
			723.Byte
		},
		{
			typeof(byte?),
			723.ByteNullable
		},
		{
			typeof(uint),
			723.UInt32
		},
		{
			typeof(uint?),
			723.UInt32Nullable
		},
		{
			typeof(long),
			723.Int64
		},
		{
			typeof(long?),
			723.Int64Nullable
		},
		{
			typeof(ulong),
			723.UInt64
		},
		{
			typeof(ulong?),
			723.UInt64Nullable
		},
		{
			typeof(float),
			723.Single
		},
		{
			typeof(float?),
			723.SingleNullable
		},
		{
			typeof(double),
			723.Double
		},
		{
			typeof(double?),
			723.DoubleNullable
		},
		{
			typeof(DateTime),
			723.DateTime
		},
		{
			typeof(DateTime?),
			723.DateTimeNullable
		},
		{
			typeof(DateTimeOffset),
			723.DateTimeOffset
		},
		{
			typeof(DateTimeOffset?),
			723.DateTimeOffsetNullable
		},
		{
			typeof(decimal),
			723.Decimal
		},
		{
			typeof(decimal?),
			723.DecimalNullable
		},
		{
			typeof(Guid),
			723.Guid
		},
		{
			typeof(Guid?),
			723.GuidNullable
		},
		{
			typeof(TimeSpan),
			723.TimeSpan
		},
		{
			typeof(TimeSpan?),
			723.TimeSpanNullable
		},
		{
			typeof(BigInteger),
			723.BigInteger
		},
		{
			typeof(BigInteger?),
			723.BigIntegerNullable
		},
		{
			typeof(Uri),
			723.Uri
		},
		{
			typeof(string),
			723.String
		},
		{
			typeof(byte[]),
			723.Bytes
		},
		{
			typeof(DBNull),
			723.DBNull
		}
	};

	// Token: 0x0400050D RID: 1293
	private static readonly 697[] _recoveredType1927Array0920 = new 697[]
	{
		new 697(typeof(object), 723.Empty),
		new 697(typeof(object), 723.Object),
		new 697(typeof(object), 723.DBNull),
		new 697(typeof(bool), 723.Boolean),
		new 697(typeof(char), 723.Char),
		new 697(typeof(sbyte), 723.SByte),
		new 697(typeof(byte), 723.Byte),
		new 697(typeof(short), 723.Int16),
		new 697(typeof(ushort), 723.UInt16),
		new 697(typeof(int), 723.Int32),
		new 697(typeof(uint), 723.UInt32),
		new 697(typeof(long), 723.Int64),
		new 697(typeof(ulong), 723.UInt64),
		new 697(typeof(float), 723.Single),
		new 697(typeof(double), 723.Double),
		new 697(typeof(decimal), 723.Decimal),
		new 697(typeof(DateTime), 723.DateTime),
		new 697(typeof(object), 723.Empty),
		new 697(typeof(string), 723.String)
	};

	// Token: 0x0400050E RID: 1294
	[241(new byte[]
	{
		1,
		0,
		1,
		1,
		2,
		2,
		2
	})]
	private static readonly 482<558<Type, Type>, Func<object, object>> _recoveredType08380921 = new 482<558<Type, Type>, Func<object, object>>(new Func<558<Type, Type>, Func<object, object>>(358.Method1495));

	// Token: 0x02000114 RID: 276
	public sealed class 359
	{
		// Token: 0x06000A12 RID: 2578 RVA: 0x00026175 File Offset: 0x00024375
		[242(2)]
		internal object Method1489(object 1)
		{
			return this._recoveredType06220918(null, new object[]
			{
				1
			});
		}

		// Token: 0x0400050F RID: 1295
		[241(new byte[]
		{
			0,
			2,
			2
		})]
		public 431<object, object> _recoveredType06220918;
	}

	// Token: 0x02000115 RID: 277
	[242(0)]
	public enum 360
	{

	}
}
