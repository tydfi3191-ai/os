using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml;
using System.Xml.Linq;

// Token: 0x020000A8 RID: 168
[ComVisible(false)]
[241(0)]
[242(1)]
public static class 77
{
	// Token: 0x17000023 RID: 35
	// (get) Token: 0x060003B6 RID: 950 RVA: 0x0000C072 File Offset: 0x0000A272
	// (set) Token: 0x060003B7 RID: 951 RVA: 0x0000C079 File Offset: 0x0000A279
	[241(new byte[]
	{
		2,
		1
	})]
	public static Func<79> DefaultSettings
	{
		[return: 241(new byte[]
		{
			2,
			1
		})]
		get
		{
			return 77.defaultSettings;
		}
		[param: 241(new byte[]
		{
			2,
			1
		})]
		set
		{
			77.defaultSettings = value;
		}
	}

	// Token: 0x060003B8 RID: 952 RVA: 0x0000C081 File Offset: 0x0000A281
	public static string Method5202(DateTime 1)
	{
		return 77.Method5202(1, (47)0, (49)3);
	}

	// Token: 0x060003B9 RID: 953 RVA: 0x0000C08C File Offset: 0x0000A28C
	public static string Method5202(DateTime 1, 47 2, 49 3)
	{
		DateTime 4 = 382.Method2108(1, 3);
		string result;
		using (StringWriter stringWriter = 538.Method6831(64))
		{
			stringWriter.Write('"');
			382.Method2131(stringWriter, 4, 2, null, CultureInfo.InvariantCulture);
			stringWriter.Write('"');
			result = stringWriter.ToString();
		}
		return result;
	}

	// Token: 0x060003BA RID: 954 RVA: 0x0000C0EC File Offset: 0x0000A2EC
	public static string Method5202(DateTimeOffset 1)
	{
		return 77.Method5202(1, (47)0);
	}

	// Token: 0x060003BB RID: 955 RVA: 0x0000C0F8 File Offset: 0x0000A2F8
	public static string Method5202(DateTimeOffset 1, 47 2)
	{
		string result;
		using (StringWriter stringWriter = 538.Method6831(64))
		{
			stringWriter.Write('"');
			382.Method2136(stringWriter, 1, 2, null, CultureInfo.InvariantCulture);
			stringWriter.Write('"');
			result = stringWriter.ToString();
		}
		return result;
	}

	// Token: 0x060003BC RID: 956 RVA: 0x0000C150 File Offset: 0x0000A350
	public static string Method5202(bool 1)
	{
		if (!1)
		{
			return 77.falseText;
		}
		return 77.trueText;
	}

	// Token: 0x060003BD RID: 957 RVA: 0x0000C160 File Offset: 0x0000A360
	public static string Method5202(char 1)
	{
		return 77.Method5202(char.ToString(1));
	}

	// Token: 0x060003BE RID: 958 RVA: 0x0000C16D File Offset: 0x0000A36D
	public static string Method5202(Enum 1)
	{
		return 1.ToString("D");
	}

	// Token: 0x060003BF RID: 959 RVA: 0x0000C17A File Offset: 0x0000A37A
	public static string Method5202(int 1)
	{
		return 1.ToString(null, CultureInfo.InvariantCulture);
	}

	// Token: 0x060003C0 RID: 960 RVA: 0x0000C189 File Offset: 0x0000A389
	public static string Method5202(short 1)
	{
		return 1.ToString(null, CultureInfo.InvariantCulture);
	}

	// Token: 0x060003C1 RID: 961 RVA: 0x0000C198 File Offset: 0x0000A398
	[CLSCompliant(false)]
	public static string Method5202(ushort 1)
	{
		return 1.ToString(null, CultureInfo.InvariantCulture);
	}

	// Token: 0x060003C2 RID: 962 RVA: 0x0000C1A7 File Offset: 0x0000A3A7
	[CLSCompliant(false)]
	public static string Method5202(uint 1)
	{
		return 1.ToString(null, CultureInfo.InvariantCulture);
	}

	// Token: 0x060003C3 RID: 963 RVA: 0x0000C1B6 File Offset: 0x0000A3B6
	public static string Method5202(long 1)
	{
		return 1.ToString(null, CultureInfo.InvariantCulture);
	}

	// Token: 0x060003C4 RID: 964 RVA: 0x0000C1C5 File Offset: 0x0000A3C5
	private static string FormatBigInteger(BigInteger 1)
	{
		return 1.ToString(null, CultureInfo.InvariantCulture);
	}

	// Token: 0x060003C5 RID: 965 RVA: 0x0000C1D4 File Offset: 0x0000A3D4
	[CLSCompliant(false)]
	public static string Method5202(ulong 1)
	{
		return 1.ToString(null, CultureInfo.InvariantCulture);
	}

	// Token: 0x060003C6 RID: 966 RVA: 0x0000C1E3 File Offset: 0x0000A3E3
	public static string Method5202(float 1)
	{
		return 77.Method5221((double)1, 1.ToString("R", CultureInfo.InvariantCulture));
	}

	// Token: 0x060003C7 RID: 967 RVA: 0x0000C1FD File Offset: 0x0000A3FD
	internal static string Method5202(float 1, 93 2, char 3, bool 4)
	{
		return 77.EnsureFloatFormat((double)1, 77.Method5221((double)1, 1.ToString("R", CultureInfo.InvariantCulture)), 2, 3, 4);
	}

	// Token: 0x060003C8 RID: 968 RVA: 0x0000C221 File Offset: 0x0000A421
	private static string EnsureFloatFormat(double 1, string 2, 93 3, char 4, bool 5)
	{
		if (3 == (93)1 || (!double.IsInfinity(1) && !double.IsNaN(1)))
		{
			return 2;
		}
		if (3 != (93)2)
		{
			return 4.ToString() + 2 + 4.ToString();
		}
		if (5)
		{
			return 77.nullText;
		}
		return "0.0";
	}

	// Token: 0x060003C9 RID: 969 RVA: 0x0000C261 File Offset: 0x0000A461
	public static string Method5202(double 1)
	{
		return 77.Method5221(1, 1.ToString("R", CultureInfo.InvariantCulture));
	}

	// Token: 0x060003CA RID: 970 RVA: 0x0000C27A File Offset: 0x0000A47A
	internal static string Method5202(double 1, 93 2, char 3, bool 4)
	{
		return 77.EnsureFloatFormat(1, 77.Method5221(1, 1.ToString("R", CultureInfo.InvariantCulture)), 2, 3, 4);
	}

	// Token: 0x060003CB RID: 971 RVA: 0x0000C29C File Offset: 0x0000A49C
	private static string Method5221(double 1, string 2)
	{
		if (double.IsNaN(1) || double.IsInfinity(1) || 538.Method6841(2, '.') != -1 || 538.Method6841(2, 'E') != -1 || 538.Method6841(2, 'e') != -1)
		{
			return 2;
		}
		return 2 + ".0";
	}

	// Token: 0x060003CC RID: 972 RVA: 0x0000C2DC File Offset: 0x0000A4DC
	private static string Method5221(string 1)
	{
		if (538.Method6841(1, '.') != -1)
		{
			return 1;
		}
		return 1 + ".0";
	}

	// Token: 0x060003CD RID: 973 RVA: 0x0000C2F6 File Offset: 0x0000A4F6
	public static string Method5202(byte 1)
	{
		return 1.ToString(null, CultureInfo.InvariantCulture);
	}

	// Token: 0x060003CE RID: 974 RVA: 0x0000C305 File Offset: 0x0000A505
	[CLSCompliant(false)]
	public static string Method5202(sbyte 1)
	{
		return 1.ToString(null, CultureInfo.InvariantCulture);
	}

	// Token: 0x060003CF RID: 975 RVA: 0x0000C314 File Offset: 0x0000A514
	public static string Method5202(decimal 1)
	{
		return 77.Method5221(1.ToString(null, CultureInfo.InvariantCulture));
	}

	// Token: 0x060003D0 RID: 976 RVA: 0x0000C328 File Offset: 0x0000A528
	public static string Method5202(Guid 1)
	{
		return 77.Method5202(1, '"');
	}

	// Token: 0x060003D1 RID: 977 RVA: 0x0000C334 File Offset: 0x0000A534
	internal static string Method5202(Guid 1, char 2)
	{
		string str = 1.ToString("D", CultureInfo.InvariantCulture);
		string text = 2.ToString(CultureInfo.InvariantCulture);
		return text + str + text;
	}

	// Token: 0x060003D2 RID: 978 RVA: 0x0000C368 File Offset: 0x0000A568
	public static string Method5202(TimeSpan 1)
	{
		return 77.Method5202(1, '"');
	}

	// Token: 0x060003D3 RID: 979 RVA: 0x0000C372 File Offset: 0x0000A572
	internal static string Method5202(TimeSpan 1, char 2)
	{
		return 77.Method5202(1.ToString(), 2);
	}

	// Token: 0x060003D4 RID: 980 RVA: 0x0000C387 File Offset: 0x0000A587
	public static string Method5202([241(2)] Uri 1)
	{
		if (1 == null)
		{
			return 77.nullText;
		}
		return 77.Method5202(1, '"');
	}

	// Token: 0x060003D5 RID: 981 RVA: 0x0000C3A0 File Offset: 0x0000A5A0
	internal static string Method5202(Uri 1, char 2)
	{
		return 77.Method5202(1.OriginalString, 2);
	}

	// Token: 0x060003D6 RID: 982 RVA: 0x0000C3AE File Offset: 0x0000A5AE
	public static string Method5202([241(2)] string 1)
	{
		return 77.Method5202(1, '"');
	}

	// Token: 0x060003D7 RID: 983 RVA: 0x0000C3B8 File Offset: 0x0000A5B8
	public static string Method5202([241(2)] string 1, char 2)
	{
		return 77.Method5202(1, 2, (925)0);
	}

	// Token: 0x060003D8 RID: 984 RVA: 0x0000C3C2 File Offset: 0x0000A5C2
	public static string Method5202([241(2)] string 1, char 2, 925 3)
	{
		if (2 != '"' && 2 != '\'')
		{
			throw new ArgumentException("Delimiter must be a single or double quote.", "delimiter");
		}
		return 473.Method4463(1, 2, true, 3);
	}

	// Token: 0x060003D9 RID: 985 RVA: 0x0000C3E8 File Offset: 0x0000A5E8
	public static string Method5202([241(2)] object 1)
	{
		if (1 == null)
		{
			return 77.nullText;
		}
		switch (358.Method1490(1.GetType()))
		{
		case 723.Char:
			return 77.Method5202((char)1);
		case 723.Boolean:
			return 77.Method5202((bool)1);
		case 723.SByte:
			return 77.Method5202((sbyte)1);
		case 723.Int16:
			return 77.Method5202((short)1);
		case 723.UInt16:
			return 77.Method5202((ushort)1);
		case 723.Int32:
			return 77.Method5202((int)1);
		case 723.Byte:
			return 77.Method5202((byte)1);
		case 723.UInt32:
			return 77.Method5202((uint)1);
		case 723.Int64:
			return 77.Method5202((long)1);
		case 723.UInt64:
			return 77.Method5202((ulong)1);
		case 723.Single:
			return 77.Method5202((float)1);
		case 723.Double:
			return 77.Method5202((double)1);
		case 723.DateTime:
			return 77.Method5202((DateTime)1);
		case 723.DateTimeOffset:
			return 77.Method5202((DateTimeOffset)1);
		case 723.Decimal:
			return 77.Method5202((decimal)1);
		case 723.Guid:
			return 77.Method5202((Guid)1);
		case 723.TimeSpan:
			return 77.Method5202((TimeSpan)1);
		case 723.BigInteger:
			return 77.FormatBigInteger((BigInteger)1);
		case 723.Uri:
			return 77.Method5202((Uri)1);
		case 723.String:
			return 77.Method5202((string)1);
		case 723.DBNull:
			return 77.nullText;
		}
		throw new ArgumentException("Unsupported type: {0}. Use the JsonSerializer class to get the object's JSON representation.".Method6825(CultureInfo.InvariantCulture, 1.GetType()));
	}

	// Token: 0x060003DA RID: 986 RVA: 0x0000C61A File Offset: 0x0000A81A
	[DebuggerStepThrough]
	public static string Method5236([241(2)] object 1)
	{
		return 77.Method5236(1, null, null);
	}

	// Token: 0x060003DB RID: 987 RVA: 0x0000C624 File Offset: 0x0000A824
	[DebuggerStepThrough]
	public static string Method5236([241(2)] object 1, 95 2)
	{
		return 77.Method5236(1, 2, null);
	}

	// Token: 0x060003DC RID: 988 RVA: 0x0000C630 File Offset: 0x0000A830
	[DebuggerStepThrough]
	public static string Method5236([241(2)] object 1, 214[] 2)
	{
		object obj;
		if (2 == null || 2.Length == 0)
		{
			obj = null;
		}
		else
		{
			(obj = new 79()).Converters = 2;
		}
		79 3 = obj;
		return 77.Method5236(1, null, 3);
	}

	// Token: 0x060003DD RID: 989 RVA: 0x0000C65C File Offset: 0x0000A85C
	[DebuggerStepThrough]
	public static string Method5236([241(2)] object 1, 95 2, 214[] 3)
	{
		object obj;
		if (3 == null || 3.Length == 0)
		{
			obj = null;
		}
		else
		{
			(obj = new 79()).Converters = 3;
		}
		79 4 = obj;
		return 77.Method5236(1, null, 2, 4);
	}

	// Token: 0x060003DE RID: 990 RVA: 0x0000C689 File Offset: 0x0000A889
	[DebuggerStepThrough]
	[242(2)]
	[return: 241(1)]
	public static string Method5236(object 1, 79 2)
	{
		return 77.Method5236(1, null, 2);
	}

	// Token: 0x060003DF RID: 991 RVA: 0x0000C694 File Offset: 0x0000A894
	[242(2)]
	[DebuggerStepThrough]
	[return: 241(1)]
	public static string Method5236(object 1, Type 2, 79 3)
	{
		158 4 = 158.Method3835(3);
		return 77.SerializeObjectInternal(1, 2, 4);
	}

	// Token: 0x060003E0 RID: 992 RVA: 0x0000C6B0 File Offset: 0x0000A8B0
	[DebuggerStepThrough]
	[242(2)]
	[return: 241(1)]
	public static string Method5236(object 1, 95 2, 79 3)
	{
		return 77.Method5236(1, null, 2, 3);
	}

	// Token: 0x060003E1 RID: 993 RVA: 0x0000C6BC File Offset: 0x0000A8BC
	[242(2)]
	[DebuggerStepThrough]
	[return: 241(1)]
	public static string Method5236(object 1, Type 2, 95 3, 79 4)
	{
		158 5 = 158.Method3835(4);
		5.Method1788(3);
		return 77.SerializeObjectInternal(1, 2, 5);
	}

	// Token: 0x060003E2 RID: 994 RVA: 0x0000C6E0 File Offset: 0x0000A8E0
	private static string SerializeObjectInternal([241(2)] object 1, [241(2)] Type 2, 158 3)
	{
		StringWriter stringWriter = new StringWriter(new StringBuilder(256), CultureInfo.InvariantCulture);
		168 4 = new 168(stringWriter);
		try
		{
			4.SetFormatting(3.Method1787());
			3.Method3848(4, 1, 2);
		}
		finally
		{
			((IDisposable)4).Dispose();
		}
		return stringWriter.ToString();
	}

	// Token: 0x060003E3 RID: 995 RVA: 0x0000C740 File Offset: 0x0000A940
	[DebuggerStepThrough]
	[return: 241(2)]
	public static object Method5245(string 1)
	{
		return 77.Method5245(1, null, null);
	}

	// Token: 0x060003E4 RID: 996 RVA: 0x0000C74A File Offset: 0x0000A94A
	[DebuggerStepThrough]
	[return: 241(2)]
	public static object Method5245(string 1, 79 2)
	{
		return 77.Method5245(1, null, 2);
	}

	// Token: 0x060003E5 RID: 997 RVA: 0x0000C754 File Offset: 0x0000A954
	[DebuggerStepThrough]
	[return: 241(2)]
	public static object Method5245(string 1, Type 2)
	{
		return 77.Method5245(1, 2, null);
	}

	// Token: 0x060003E6 RID: 998 RVA: 0x0000C75E File Offset: 0x0000A95E
	[DebuggerStepThrough]
	[242(2)]
	public static T Method5245<T>([241(1)] string 1)
	{
		return 77.Method5245<T>(1, null);
	}

	// Token: 0x060003E7 RID: 999 RVA: 0x0000C767 File Offset: 0x0000A967
	[DebuggerStepThrough]
	[return: 241(2)]
	public static T Method5249<[241(2)] T>(string 1, T 2)
	{
		return 77.Method5245<T>(1);
	}

	// Token: 0x060003E8 RID: 1000 RVA: 0x0000C76F File Offset: 0x0000A96F
	[DebuggerStepThrough]
	[return: 241(2)]
	public static T Method5249<[241(2)] T>(string 1, T 2, 79 3)
	{
		return 77.Method5245<T>(1, 3);
	}

	// Token: 0x060003E9 RID: 1001 RVA: 0x0000C778 File Offset: 0x0000A978
	[DebuggerStepThrough]
	[return: 241(2)]
	public static T Method5245<[241(2)] T>(string 1, 214[] 2)
	{
		return (T)((object)77.Method5245(1, typeof(T), 2));
	}

	// Token: 0x060003EA RID: 1002 RVA: 0x0000C790 File Offset: 0x0000A990
	[242(2)]
	[DebuggerStepThrough]
	public static T Method5245<T>([241(1)] string 1, 79 2)
	{
		return (T)((object)77.Method5245(1, typeof(T), 2));
	}

	// Token: 0x060003EB RID: 1003 RVA: 0x0000C7A8 File Offset: 0x0000A9A8
	[DebuggerStepThrough]
	[return: 241(2)]
	public static object Method5245(string 1, Type 2, 214[] 3)
	{
		object obj;
		if (3 == null || 3.Length == 0)
		{
			obj = null;
		}
		else
		{
			(obj = new 79()).Converters = 3;
		}
		79 4 = obj;
		return 77.Method5245(1, 2, 4);
	}

	// Token: 0x060003EC RID: 1004 RVA: 0x0000C7D4 File Offset: 0x0000A9D4
	[242(2)]
	public static object Method5245([241(1)] string 1, Type 2, 79 3)
	{
		756.Method12216(1, "value");
		158 4 = 158.Method3835(3);
		if (!4.Method3832())
		{
			4.Method1808(true);
		}
		167 5 = new 167(new StringReader(1));
		object result;
		try
		{
			result = 4.Method3841(5, 2);
		}
		finally
		{
			((IDisposable)5).Dispose();
		}
		return result;
	}

	// Token: 0x060003ED RID: 1005 RVA: 0x0000C834 File Offset: 0x0000AA34
	[DebuggerStepThrough]
	public static void Method5255(string 1, object 2)
	{
		77.Method5255(1, 2, null);
	}

	// Token: 0x060003EE RID: 1006 RVA: 0x0000C840 File Offset: 0x0000AA40
	public static void Method5255(string 1, object 2, [241(2)] 79 3)
	{
		158 4 = 158.Method3835(3);
		139 5 = new 167(new StringReader(1));
		try
		{
			4.Method3838(5, 2);
			if (3 != null && 3.GetCheckAdditionalContent())
			{
				while (5.Read())
				{
					if (5.GetTokenType() != 216.Comment)
					{
						throw 364.Method1687(5, "Additional text found in JSON string after finishing deserializing object.");
					}
				}
			}
		}
		finally
		{
			((IDisposable)5).Dispose();
		}
	}

	// Token: 0x060003EF RID: 1007 RVA: 0x0000C8AC File Offset: 0x0000AAAC
	public static string Method5257([241(2)] XmlNode 1)
	{
		return 77.Method5257(1, (95)0);
	}

	// Token: 0x060003F0 RID: 1008 RVA: 0x0000C8B8 File Offset: 0x0000AAB8
	public static string Method5257([241(2)] XmlNode 1, 95 2)
	{
		986 3 = new 986();
		return 77.Method5236(1, 2, new 214[]
		{
			3
		});
	}

	// Token: 0x060003F1 RID: 1009 RVA: 0x0000C8DC File Offset: 0x0000AADC
	public static string Method5257([241(2)] XmlNode 1, 95 2, bool 3)
	{
		986 4 = new 986();
		4.SetFlag3312_4232(3);
		986 5 = 4;
		return 77.Method5236(1, 2, new 214[]
		{
			5
		});
	}

	// Token: 0x060003F2 RID: 1010 RVA: 0x0000C907 File Offset: 0x0000AB07
	[return: 241(2)]
	public static XmlDocument Method5260(string 1)
	{
		return 77.Method5260(1, null);
	}

	// Token: 0x060003F3 RID: 1011 RVA: 0x0000C910 File Offset: 0x0000AB10
	[242(2)]
	public static XmlDocument Method5260([241(1)] string 1, string 2)
	{
		return 77.Method5260(1, 2, false);
	}

	// Token: 0x060003F4 RID: 1012 RVA: 0x0000C91A File Offset: 0x0000AB1A
	[242(2)]
	public static XmlDocument Method5260([241(1)] string 1, string 2, bool 3)
	{
		return 77.Method5260(1, 2, 3, false);
	}

	// Token: 0x060003F5 RID: 1013 RVA: 0x0000C928 File Offset: 0x0000AB28
	[242(2)]
	public static XmlDocument Method5260([241(1)] string 1, string 2, bool 3, bool 4)
	{
		986 5 = new 986();
		5.Text3314 = 2;
		5.SetFlag3311_4230(3);
		5.SetFlag3313_4234(4);
		return (XmlDocument)77.Method5245(1, typeof(XmlDocument), new 214[]
		{
			5
		});
	}

	// Token: 0x060003F6 RID: 1014 RVA: 0x0000C96F File Offset: 0x0000AB6F
	public static string Method5264([241(2)] XObject 1)
	{
		return 77.Method5264(1, (95)0);
	}

	// Token: 0x060003F7 RID: 1015 RVA: 0x0000C978 File Offset: 0x0000AB78
	public static string Method5264([241(2)] XObject 1, 95 2)
	{
		return 77.Method5264(1, 2, false);
	}

	// Token: 0x060003F8 RID: 1016 RVA: 0x0000C984 File Offset: 0x0000AB84
	public static string Method5264([241(2)] XObject 1, 95 2, bool 3)
	{
		986 4 = new 986();
		4.SetFlag3312_4232(3);
		986 5 = 4;
		return 77.Method5236(1, 2, new 214[]
		{
			5
		});
	}

	// Token: 0x060003F9 RID: 1017 RVA: 0x0000C9AF File Offset: 0x0000ABAF
	[return: 241(2)]
	public static XDocument Method5267(string 1)
	{
		return 77.Method5267(1, null);
	}

	// Token: 0x060003FA RID: 1018 RVA: 0x0000C9B8 File Offset: 0x0000ABB8
	[242(2)]
	public static XDocument Method5267([241(1)] string 1, string 2)
	{
		return 77.Method5267(1, 2, false);
	}

	// Token: 0x060003FB RID: 1019 RVA: 0x0000C9C2 File Offset: 0x0000ABC2
	[242(2)]
	public static XDocument Method5267([241(1)] string 1, string 2, bool 3)
	{
		return 77.Method5267(1, 2, 3, false);
	}

	// Token: 0x060003FC RID: 1020 RVA: 0x0000C9D0 File Offset: 0x0000ABD0
	[242(2)]
	public static XDocument Method5267([241(1)] string 1, string 2, bool 3, bool 4)
	{
		986 5 = new 986();
		5.Text3314 = 2;
		5.SetFlag3311_4230(3);
		5.SetFlag3313_4234(4);
		return (XDocument)77.Method5245(1, typeof(XDocument), new 214[]
		{
			5
		});
	}

	// Token: 0x0400038F RID: 911
	[241(new byte[]
	{
		2,
		1
	})]
	private static Func<79> defaultSettings;

	// Token: 0x04000390 RID: 912
	public static readonly string trueText = "true";

	// Token: 0x04000391 RID: 913
	public static readonly string falseText = "false";

	// Token: 0x04000392 RID: 914
	public static readonly string nullText = "null";

	// Token: 0x04000393 RID: 915
	public static readonly string undefinedText = "undefined";

	// Token: 0x04000394 RID: 916
	public static readonly string positiveInfinityText = "Infinity";

	// Token: 0x04000395 RID: 917
	public static readonly string negativeInfinityText = "-Infinity";

	// Token: 0x04000396 RID: 918
	public static readonly string nanText = "NaN";
}
