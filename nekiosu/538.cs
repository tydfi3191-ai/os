using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

// Token: 0x02000153 RID: 339
[242(1)]
[241(0)]
public static class 538
{
	// Token: 0x06000BCA RID: 3018 RVA: 0x0002AD9E File Offset: 0x00028F9E
	[242(2)]
	public static bool Method6824([239(false)] string 1)
	{
		return string.IsNullOrEmpty(1);
	}

	// Token: 0x06000BCB RID: 3019 RVA: 0x0002ADA6 File Offset: 0x00028FA6
	public static string Method6825(this string 1, IFormatProvider 2, [241(2)] object 3)
	{
		return 1.Method6825(2, new object[]
		{
			3
		});
	}

	// Token: 0x06000BCC RID: 3020 RVA: 0x0002ADB9 File Offset: 0x00028FB9
	public static string Method6825(this string 1, IFormatProvider 2, [241(2)] object 3, [241(2)] object 4)
	{
		return 1.Method6825(2, new object[]
		{
			3,
			4
		});
	}

	// Token: 0x06000BCD RID: 3021 RVA: 0x0002ADD0 File Offset: 0x00028FD0
	public static string Method6825(this string 1, IFormatProvider 2, [241(2)] object 3, [241(2)] object 4, [241(2)] object 5)
	{
		return 1.Method6825(2, new object[]
		{
			3,
			4,
			5
		});
	}

	// Token: 0x06000BCE RID: 3022 RVA: 0x0002ADEC File Offset: 0x00028FEC
	[242(2)]
	[return: 241(1)]
	public static string Method6825([241(1)] this string 1, [241(1)] IFormatProvider 2, object 3, object 4, object 5, object 6)
	{
		return 1.Method6825(2, new object[]
		{
			3,
			4,
			5,
			6
		});
	}

	// Token: 0x06000BCF RID: 3023 RVA: 0x0002AE0D File Offset: 0x0002900D
	private static string Method6825(this string 1, IFormatProvider 2, [241(new byte[]
	{
		1,
		2
	})] object[] 3)
	{
		756.Method12216(1, "format");
		return string.Format(2, 1, 3);
	}

	// Token: 0x06000BD0 RID: 3024 RVA: 0x0002AE24 File Offset: 0x00029024
	public static bool Method6830(string 1)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("#=zJIhL83g=");
		}
		if (1.Length == 0)
		{
			return false;
		}
		for (int i = 0; i < 1.Length; i++)
		{
			if (!char.IsWhiteSpace(1[i]))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06000BD1 RID: 3025 RVA: 0x0002AE6B File Offset: 0x0002906B
	public static StringWriter Method6831(int 1)
	{
		return new StringWriter(new StringBuilder(1), CultureInfo.InvariantCulture);
	}

	// Token: 0x06000BD2 RID: 3026 RVA: 0x0002AE80 File Offset: 0x00029080
	public static void Method6832(char 1, char[] 2)
	{
		2[0] = '\\';
		2[1] = 'u';
		2[2] = 421.Method3212((int)(1 >> 12 & '\u000f'));
		2[3] = 421.Method3212((int)(1 >> 8 & '\u000f'));
		2[4] = 421.Method3212((int)(1 >> 4 & '\u000f'));
		2[5] = 421.Method3212((int)(1 & '\u000f'));
	}

	// Token: 0x06000BD3 RID: 3027 RVA: 0x0002AED0 File Offset: 0x000290D0
	[return: 241(2)]
	public static TSource Method6833<[241(2)] TSource>(this IEnumerable<TSource> 1, Func<TSource, string> 2, string 3)
	{
		538.539<TSource> CS_0024_003C_003E8__locals6 = new 538.539<TSource>();
		CS_0024_003C_003E8__locals6._func5431 = 2;
		CS_0024_003C_003E8__locals6._text5432 = 3;
		if (4 == null)
		{
			throw new ArgumentNullException("#=zUCAUQIw=");
		}
		if (CS_0024_003C_003E8__locals6._func5431 == null)
		{
			throw new ArgumentNullException("#=zm9ia5ZY=");
		}
		IEnumerable<TSource> source = from 1 in 4
		where string.Equals(CS_0024_003C_003E8__locals6._func5431(1), CS_0024_003C_003E8__locals6._text5432, StringComparison.OrdinalIgnoreCase)
		select 1;
		if (source.Count<TSource>() <= 1)
		{
			return source.SingleOrDefault<TSource>();
		}
		return 4.Where(new Func<TSource, bool>(CS_0024_003C_003E8__locals6.Method6823)).SingleOrDefault<TSource>();
	}

	// Token: 0x06000BD4 RID: 3028 RVA: 0x0002AF6C File Offset: 0x0002916C
	public static string Method6834(string 1)
	{
		if (538.Method6824(1) || !char.IsUpper(1[0]))
		{
			return 1;
		}
		char[] array = 1.ToCharArray();
		int num = 0;
		while (num < array.Length && (num != 1 || char.IsUpper(array[num])))
		{
			bool flag = num + 1 < array.Length;
			if (num > 0 && flag && !char.IsUpper(array[num + 1]))
			{
				if (char.IsSeparator(array[num + 1]))
				{
					array[num] = 538.Method6835(array[num]);
					break;
				}
				break;
			}
			else
			{
				array[num] = 538.Method6835(array[num]);
				num++;
			}
		}
		return new string(array);
	}

	// Token: 0x06000BD5 RID: 3029 RVA: 0x0002AFFB File Offset: 0x000291FB
	private static char Method6835(char 1)
	{
		1 = char.ToLower(1, CultureInfo.InvariantCulture);
		return 1;
	}

	// Token: 0x06000BD6 RID: 3030 RVA: 0x0002B00B File Offset: 0x0002920B
	public static string Method6836(string 1)
	{
		return 538.Method6838(1, '_');
	}

	// Token: 0x06000BD7 RID: 3031 RVA: 0x0002B015 File Offset: 0x00029215
	public static string Method6837(string 1)
	{
		return 538.Method6838(1, '-');
	}

	// Token: 0x06000BD8 RID: 3032 RVA: 0x0002B020 File Offset: 0x00029220
	private static string Method6838(string 1, char 2)
	{
		if (538.Method6824(1))
		{
			return 1;
		}
		StringBuilder stringBuilder = new StringBuilder();
		538.540 3 = (538.540)0;
		for (int i = 0; i < 1.Length; i++)
		{
			if (1[i] == ' ')
			{
				if (3 != (538.540)0)
				{
					3 = (538.540)3;
				}
			}
			else if (char.IsUpper(1[i]))
			{
				switch (3)
				{
				case (538.540)1:
				case (538.540)3:
					stringBuilder.Append(2);
					break;
				case (538.540)2:
				{
					bool flag = i + 1 < 1.Length;
					if (i > 0 && flag)
					{
						char c = 1[i + 1];
						if (!char.IsUpper(c) && c != 2)
						{
							stringBuilder.Append(2);
						}
					}
					break;
				}
				}
				char value = char.ToLower(1[i], CultureInfo.InvariantCulture);
				stringBuilder.Append(value);
				3 = (538.540)2;
			}
			else if (1[i] == 2)
			{
				stringBuilder.Append(2);
				3 = (538.540)0;
			}
			else
			{
				if (3 == (538.540)3)
				{
					stringBuilder.Append(2);
				}
				stringBuilder.Append(1[i]);
				3 = (538.540)1;
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06000BD9 RID: 3033 RVA: 0x0002B129 File Offset: 0x00029329
	public static bool Method6839(char 1)
	{
		return char.IsHighSurrogate(1);
	}

	// Token: 0x06000BDA RID: 3034 RVA: 0x0002B131 File Offset: 0x00029331
	public static bool Method6840(char 1)
	{
		return char.IsLowSurrogate(1);
	}

	// Token: 0x06000BDB RID: 3035 RVA: 0x0002B139 File Offset: 0x00029339
	public static int Method6841(string 1, char 2)
	{
		return 1.IndexOf(2);
	}

	// Token: 0x06000BDC RID: 3036 RVA: 0x0002B142 File Offset: 0x00029342
	public static string Method6842(string 1, string 2, string 3)
	{
		return 1.Replace(2, 3);
	}

	// Token: 0x06000BDD RID: 3037 RVA: 0x0002B14C File Offset: 0x0002934C
	public static bool Method6843(this string 1, char 2)
	{
		return 1.Length > 0 && 1[0] == 2;
	}

	// Token: 0x06000BDE RID: 3038 RVA: 0x0002B163 File Offset: 0x00029363
	public static bool Method6844(this string 1, char 2)
	{
		return 1.Length > 0 && 1[1.Length - 1] == 2;
	}

	// Token: 0x06000BDF RID: 3039 RVA: 0x0002B184 File Offset: 0x00029384
	public static string Method6845(this string 1, int 2, int 3)
	{
		if (1 == null)
		{
			throw new ArgumentNullException();
		}
		if (2 < 0)
		{
			throw new ArgumentOutOfRangeException("#=zXA0X49A=");
		}
		if (3 < 0)
		{
			throw new ArgumentOutOfRangeException("#=zidzotuw=");
		}
		int num = 2 + 3 - 1;
		if (num >= 1.Length)
		{
			throw new ArgumentOutOfRangeException("#=zidzotuw=");
		}
		while (2 < num)
		{
			if (!char.IsWhiteSpace(1[2]))
			{
				break;
			}
			2++;
		}
		while (num >= 2 && char.IsWhiteSpace(1[num]))
		{
			num--;
		}
		return 1.Substring(2, num - 2 + 1);
	}

	// Token: 0x02000154 RID: 340
	public sealed class 539<TItem>
	{
		// Token: 0x06000BE0 RID: 3040 RVA: 0x0002B20D File Offset: 0x0002940D
		[242(0)]
		internal bool Method6822(TItem 1)
		{
			return string.Equals(this._func5431(1), this._text5432, StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x06000BE1 RID: 3041 RVA: 0x0002B227 File Offset: 0x00029427
		[242(0)]
		internal bool Method6823(TItem 1)
		{
			return string.Equals(this._func5431(1), this._text5432, StringComparison.Ordinal);
		}

		// Token: 0x040005C9 RID: 1481
		[241(new byte[]
		{
			0,
			0,
			1
		})]
		public Func<TItem, string> _func5431;

		// Token: 0x040005CA RID: 1482
		[241(0)]
		public string _text5432;
	}

	// Token: 0x02000155 RID: 341
	[242(0)]
	public enum 540
	{

	}
}
