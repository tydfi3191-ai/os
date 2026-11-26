using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;

// Token: 0x020001FC RID: 508
[242(1)]
[241(0)]
public static class 83
{
	// Token: 0x06001016 RID: 4118 RVA: 0x00036A48 File Offset: 0x00034C48
	private static 678 Method5802([241(new byte[]
	{
		0,
		1,
		2
	})] 558<Type, 136> 1)
	{
		Type item = 1._item5821;
		string[] names = Enum.GetNames(item);
		string[] array = new string[names.Length];
		ulong[] array2 = new ulong[names.Length];
		for (int i = 0; i < names.Length; i++)
		{
			string text = names[i];
			FieldInfo field = item.GetField(text, BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			array2[i] = 83.ToUInt64(field.GetValue(null));
			string text2 = field.GetCustomAttributes(typeof(EnumMemberAttribute), true).Cast<EnumMemberAttribute>().Select(new Func<EnumMemberAttribute, string>(83.84.instance.Method5800)).SingleOrDefault<string>();
			bool 2 = text2 != null;
			if (text2 == null)
			{
				text2 = text;
			}
			string text3 = text2;
			if (Array.IndexOf<string>(array, text3, 0, i) != -1)
			{
				throw new InvalidOperationException("Enum name '{0}' already exists on enum '{1}'.".Method6825(CultureInfo.InvariantCulture, text3, item.Name));
			}
			array[i] = ((1._item5822 != null) ? 1._item5822.GetPropertyName(text3, 2) : text3);
		}
		return new 678(item.IsDefined(typeof(FlagsAttribute), false), array2, names, array);
	}

	// Token: 0x06001017 RID: 4119 RVA: 0x00036B5C File Offset: 0x00034D5C
	[242(0)]
	[return: 241(new byte[]
	{
		1,
		0
	})]
	public static IList<T> Method5803<T>(T 1) where T : struct
	{
		Type typeFromHandle = typeof(T);
		if (!typeFromHandle.IsDefined(typeof(FlagsAttribute), false))
		{
			throw new ArgumentException("Enum type {0} is not a set of flags.".Method6825(CultureInfo.InvariantCulture, typeFromHandle));
		}
		Type underlyingType = Enum.GetUnderlyingType(1.GetType());
		ulong num = 83.ToUInt64(1);
		678 enumValuesAndNames = 83.GetEnumValuesAndNames(typeFromHandle);
		IList<T> list = new List<T>();
		for (int i = 0; i < enumValuesAndNames.numberArray2.Length; i++)
		{
			ulong num2 = enumValuesAndNames.numberArray2[i];
			if ((num & num2) == num2 && num2 != 0UL)
			{
				list.Add((T)((object)Convert.ChangeType(num2, underlyingType, CultureInfo.CurrentCulture)));
			}
		}
		if (list.Count == 0 && enumValuesAndNames.numberArray2.Any(new Func<ulong, bool>(83.85<T>._recoveredType10504627.Method5801)))
		{
			list.Add(default(T));
		}
		return list;
	}

	// Token: 0x06001018 RID: 4120 RVA: 0x00036C4F File Offset: 0x00034E4F
	public static bool Method5804(Type 1, object 2, bool 3, [241(2)] [239(true)] out string 4)
	{
		return 83.Method5804(1, 2, 3 ? 83._recoveredType22124630 : null, out 4);
	}

	// Token: 0x06001019 RID: 4121 RVA: 0x00036C64 File Offset: 0x00034E64
	public static bool Method5804(Type 1, object 2, [241(2)] 136 3, [239(true)] [241(2)] out string 4)
	{
		678 5 = 83._recoveredType08384629.Method4701(new 558<Type, 136>(1, 3));
		ulong num = 83.ToUInt64(2);
		if (5.flag2)
		{
			4 = 83.Method5806(5, num);
			return 4 != null;
		}
		int num2 = Array.BinarySearch<ulong>(5.numberArray2, num);
		if (num2 >= 0)
		{
			4 = 5.textArray4[num2];
			return true;
		}
		4 = null;
		return false;
	}

	// Token: 0x0600101A RID: 4122 RVA: 0x00036CC4 File Offset: 0x00034EC4
	[return: 241(2)]
	private static string Method5806(678 1, ulong 2)
	{
		string[] textArray = 1.textArray4;
		ulong[] numberArray = 1.numberArray2;
		int num = numberArray.Length - 1;
		StringBuilder stringBuilder = new StringBuilder();
		bool flag = true;
		ulong num2 = 2;
		while (num >= 0 && (num != 0 || numberArray[num] != 0UL))
		{
			if ((2 & numberArray[num]) == numberArray[num])
			{
				2 -= numberArray[num];
				if (!flag)
				{
					stringBuilder.Insert(0, ", ");
				}
				string value = textArray[num];
				stringBuilder.Insert(0, value);
				flag = false;
			}
			num--;
		}
		if (2 != 0UL)
		{
			return null;
		}
		if (num2 != 0UL)
		{
			return stringBuilder.ToString();
		}
		if (numberArray.Length != 0 && numberArray[0] == 0UL)
		{
			return textArray[0];
		}
		return null;
	}

	// Token: 0x0600101B RID: 4123 RVA: 0x00036D55 File Offset: 0x00034F55
	public static 678 GetEnumValuesAndNames(Type 1)
	{
		return 83._recoveredType08384629.Method4701(new 558<Type, 136>(1, null));
	}

	// Token: 0x0600101C RID: 4124 RVA: 0x00036D68 File Offset: 0x00034F68
	private static ulong ToUInt64(object 1)
	{
		bool flag;
		switch (358.Method1490(1.GetType(), out flag))
		{
		case 723.Char:
			return (ulong)((char)1);
		case 723.Boolean:
			return (ulong)Convert.ToByte((bool)1);
		case 723.SByte:
			return (ulong)((long)((sbyte)1));
		case 723.Int16:
			return (ulong)((long)((short)1));
		case 723.UInt16:
			return (ulong)((ushort)1);
		case 723.Int32:
			return (ulong)((long)((int)1));
		case 723.Byte:
			return (ulong)((byte)1);
		case 723.UInt32:
			return (ulong)((uint)1);
		case 723.Int64:
			return (ulong)((long)1);
		case 723.UInt64:
			return (ulong)1;
		}
		throw new InvalidOperationException("Unknown enum type.");
	}

	// Token: 0x0600101D RID: 4125 RVA: 0x00036E4C File Offset: 0x0003504C
	public static object ParseEnum(Type 1, [241(2)] 136 2, string 3, bool 4)
	{
		756.Method12216(1, "enumType");
		756.Method12216(3, "value");
		if (!1.Method6709())
		{
			throw new ArgumentException("Type provided must be an Enum.", "enumType");
		}
		678 5 = 83._recoveredType08384629.Method4701(new 558<Type, 136>(1, 2));
		string[] textArray = 5.textArray3;
		string[] textArray2 = 5.textArray4;
		ulong[] numberArray = 5.numberArray2;
		int? num = 83.Method5811(textArray2, 3, 0, 3.Length, StringComparison.Ordinal);
		if (num != null)
		{
			return Enum.ToObject(1, numberArray[num.Value]);
		}
		int num2 = -1;
		for (int i = 0; i < 3.Length; i++)
		{
			if (!char.IsWhiteSpace(3[i]))
			{
				num2 = i;
				break;
			}
		}
		if (num2 == -1)
		{
			throw new ArgumentException("Must specify valid information for parsing in the string.");
		}
		char c = 3[num2];
		if (char.IsDigit(c) || c == '-' || c == '+')
		{
			Type underlyingType = Enum.GetUnderlyingType(1);
			3 = 3.Trim();
			object obj = null;
			try
			{
				obj = Convert.ChangeType(3, underlyingType, CultureInfo.InvariantCulture);
			}
			catch (FormatException)
			{
			}
			if (obj != null)
			{
				if (4)
				{
					throw new FormatException("Integer string '{0}' is not allowed.".Method6825(CultureInfo.InvariantCulture, 3));
				}
				return Enum.ToObject(1, obj);
			}
		}
		ulong num3 = 0UL;
		int j = num2;
		while (j <= 3.Length)
		{
			int num4 = 3.IndexOf(',', j);
			if (num4 == -1)
			{
				num4 = 3.Length;
			}
			int num5 = num4;
			while (j < num4)
			{
				if (!char.IsWhiteSpace(3[j]))
				{
					break;
				}
				j++;
			}
			while (num5 > j && char.IsWhiteSpace(3[num5 - 1]))
			{
				num5--;
			}
			int 6 = num5 - j;
			num = 83.Method5810(3, textArray, textArray2, j, 6, StringComparison.Ordinal);
			if (num == null)
			{
				num = 83.Method5810(3, textArray, textArray2, j, 6, StringComparison.OrdinalIgnoreCase);
			}
			if (num == null)
			{
				num = 83.Method5811(textArray2, 3, 0, 3.Length, StringComparison.OrdinalIgnoreCase);
				if (num != null)
				{
					return Enum.ToObject(1, numberArray[num.Value]);
				}
				throw new ArgumentException("Requested value '{0}' was not found.".Method6825(CultureInfo.InvariantCulture, 3));
			}
			else
			{
				num3 |= numberArray[num.Value];
				j = num4 + 1;
			}
		}
		return Enum.ToObject(1, num3);
	}

	// Token: 0x0600101E RID: 4126 RVA: 0x00037094 File Offset: 0x00035294
	private static int? Method5810(string 1, string[] 2, string[] 3, int 4, int 5, StringComparison 6)
	{
		int? result = 83.Method5811(3, 1, 4, 5, 6);
		if (result == null)
		{
			result = 83.Method5811(2, 1, 4, 5, 6);
		}
		return result;
	}

	// Token: 0x0600101F RID: 4127 RVA: 0x000370C8 File Offset: 0x000352C8
	private static int? Method5811(string[] 1, string 2, int 3, int 4, StringComparison 5)
	{
		for (int i = 0; i < 1.Length; i++)
		{
			if (1[i].Length == 4 && string.Compare(1[i], 0, 2, 3, 4, 5) == 0)
			{
				return new int?(i);
			}
		}
		return null;
	}

	// Token: 0x040007D4 RID: 2004
	[241(new byte[]
	{
		1,
		0,
		1,
		2,
		1
	})]
	private static readonly 482<558<Type, 136>, 678> _recoveredType08384629 = new 482<558<Type, 136>, 678>(new Func<558<Type, 136>, 678>(83.Method5802));

	// Token: 0x040007D5 RID: 2005
	private static 755 _recoveredType22124630 = new 755();

	// Token: 0x020001FD RID: 509
	[Serializable]
	public sealed class 84
	{
		// Token: 0x06001021 RID: 4129 RVA: 0x00037130 File Offset: 0x00035330
		[242(0)]
		internal string Method5800(EnumMemberAttribute 1)
		{
			return 1.Value;
		}

		// Token: 0x040007D6 RID: 2006
		[241(0)]
		public static readonly 83.84 instance = new 83.84();

		// Token: 0x040007D7 RID: 2007
		[241(0)]
		public static Func<EnumMemberAttribute, string> func;
	}

	// Token: 0x020001FE RID: 510
	[Serializable]
	public sealed class 85<TItem> where TItem : struct
	{
		// Token: 0x06001024 RID: 4132 RVA: 0x00037144 File Offset: 0x00035344
		internal bool Method5801(ulong 1)
		{
			return 1 == 0UL;
		}

		// Token: 0x040007D8 RID: 2008
		[241(0)]
		public static readonly 83.85<TItem> _recoveredType10504627 = new 83.85<TItem>();

		// Token: 0x040007D9 RID: 2009
		[241(0)]
		public static Func<ulong, bool> _func4628;
	}
}
