using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

// Token: 0x02000143 RID: 323
[241(0)]
[242(1)]
public static class 473
{
	// Token: 0x06000B23 RID: 2851 RVA: 0x000298A0 File Offset: 0x00027AA0
	static 473()
	{
		IList<char> list = new List<char>
		{
			'\n',
			'\r',
			'\t',
			'\\',
			'\f',
			'\b'
		};
		for (int i = 0; i < 32; i++)
		{
			list.Add((char)i);
		}
		foreach (char c in list.Union(new char[]
		{
			'\''
		}))
		{
			473.flagArray2[(int)c] = true;
		}
		foreach (char c2 in list.Union(new char[]
		{
			'"'
		}))
		{
			473.flagArray3[(int)c2] = true;
		}
		foreach (char c3 in list.Union(new char[]
		{
			'"',
			'\'',
			'<',
			'>',
			'&'
		}))
		{
			473.flagArray4[(int)c3] = true;
		}
	}

	// Token: 0x06000B24 RID: 2852 RVA: 0x00029A0C File Offset: 0x00027C0C
	public static bool[] Method4460(925 1, char 2)
	{
		if (1 == (925)2)
		{
			return 473.flagArray4;
		}
		if (2 == '"')
		{
			return 473.flagArray3;
		}
		return 473.flagArray2;
	}

	// Token: 0x06000B25 RID: 2853 RVA: 0x00029A28 File Offset: 0x00027C28
	public static bool Method4461([241(2)] string 1, bool[] 2)
	{
		if (1 == null)
		{
			return false;
		}
		foreach (char c in 1)
		{
			if ((int)c >= 2.Length || 2[(int)c])
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06000B26 RID: 2854 RVA: 0x00029A64 File Offset: 0x00027C64
	[242(2)]
	public static void Method4462([241(1)] TextWriter 1, string 2, char 3, bool 4, [241(1)] bool[] 5, 925 6, 690<char> 7, ref char[] 8)
	{
		if (4)
		{
			1.Write(3);
		}
		if (!538.Method6824(2))
		{
			int num = 473.Method4464(2, 5, 6);
			if (num == -1)
			{
				1.Write(2);
			}
			else
			{
				if (num != 0)
				{
					if (8 == null || 8.Length < num)
					{
						8 = 669.Method9989(7, num, 8);
					}
					2.CopyTo(0, 8, 0, num);
					1.Write(8, 0, num);
				}
				int num2;
				for (int i = num; i < 2.Length; i++)
				{
					char c = 2[i];
					if ((int)c >= 5.Length || 5[(int)c])
					{
						string text;
						if (c <= '\\')
						{
							switch (c)
							{
							case '\b':
								text = "\\b";
								break;
							case '\t':
								text = "\\t";
								break;
							case '\n':
								text = "\\n";
								break;
							case '\v':
								goto IL_12A;
							case '\f':
								text = "\\f";
								break;
							case '\r':
								text = "\\r";
								break;
							default:
								if (c != '\\')
								{
									goto IL_12A;
								}
								text = "\\\\";
								break;
							}
						}
						else if (c != '\u0085')
						{
							if (c != '\u2028')
							{
								if (c != '\u2029')
								{
									goto IL_12A;
								}
								text = "\\u2029";
							}
							else
							{
								text = "\\u2028";
							}
						}
						else
						{
							text = "\\u0085";
						}
						IL_18C:
						if (text == null)
						{
							goto IL_22E;
						}
						bool flag = string.Equals(text, "!", StringComparison.Ordinal);
						if (i > num)
						{
							num2 = i - num + (flag ? 6 : 0);
							int num3 = flag ? 6 : 0;
							if (8 == null || 8.Length < num2)
							{
								char[] array = 669.Method9987(7, num2);
								if (flag)
								{
									Array.Copy(8, array, 6);
								}
								669.Method9988(7, 8);
								8 = array;
							}
							2.CopyTo(num, 8, num3, num2 - num3);
							1.Write(8, num3, num2 - num3);
						}
						num = i + 1;
						if (!flag)
						{
							1.Write(text);
							goto IL_22E;
						}
						1.Write(8, 0, 6);
						goto IL_22E;
						IL_12A:
						if ((int)c >= 5.Length && 6 != (925)1)
						{
							text = null;
							goto IL_18C;
						}
						if (c == '\'' && 6 != (925)2)
						{
							text = "\\'";
							goto IL_18C;
						}
						if (c == '"' && 6 != (925)2)
						{
							text = "\\\"";
							goto IL_18C;
						}
						if (8 == null || 8.Length < 6)
						{
							8 = 669.Method9989(7, 6, 8);
						}
						538.Method6832(c, 8);
						text = "!";
						goto IL_18C;
					}
					IL_22E:;
				}
				num2 = 2.Length - num;
				if (num2 > 0)
				{
					if (8 == null || 8.Length < num2)
					{
						8 = 669.Method9989(7, num2, 8);
					}
					2.CopyTo(num, 8, 0, num2);
					1.Write(8, 0, num2);
				}
			}
		}
		if (4)
		{
			1.Write(3);
		}
	}

	// Token: 0x06000B27 RID: 2855 RVA: 0x00029CF8 File Offset: 0x00027EF8
	public static string Method4463([241(2)] string 1, char 2, bool 3, 925 4)
	{
		bool[] 5 = 473.Method4460(4, 2);
		string result;
		using (StringWriter stringWriter = 538.Method6831((1 != null) ? 1.Length : 16))
		{
			char[] array = null;
			473.Method4462(stringWriter, 1, 2, 3, 5, 4, null, ref array);
			result = stringWriter.ToString();
		}
		return result;
	}

	// Token: 0x06000B28 RID: 2856 RVA: 0x00029D54 File Offset: 0x00027F54
	private static int Method4464(string 1, bool[] 2, 925 3)
	{
		for (int num = 0; num != 1.Length; num++)
		{
			char c = 1[num];
			if ((int)c < 2.Length)
			{
				if (2[(int)c])
				{
					return num;
				}
			}
			else
			{
				if (3 == (925)1)
				{
					return num;
				}
				if (c == '\u0085' || c == '\u2028' || c == '\u2029')
				{
					return num;
				}
			}
		}
		return -1;
	}

	// Token: 0x06000B29 RID: 2857 RVA: 0x00029DA8 File Offset: 0x00027FA8
	public static bool Method4465(139 1, out DateTime 2, [241(2)] [239(false)] out string 3)
	{
		2 = default(DateTime);
		3 = null;
		long? num;
		if (!473.Method4466(1, out num, out 3) || num == null)
		{
			3 = (3 ?? "Date constructor has no arguments.");
			return false;
		}
		long? num2;
		if (!473.Method4466(1, out num2, out 3))
		{
			return false;
		}
		if (num2 != null)
		{
			List<long> list = new List<long>
			{
				num.Value,
				num2.Value
			};
			long? num3;
			while (473.Method4466(1, out num3, out 3))
			{
				if (num3 != null)
				{
					list.Add(num3.Value);
				}
				else
				{
					if (list.Count > 7)
					{
						3 = "Unexpected number of arguments when reading date constructor.";
						return false;
					}
					while (list.Count < 7)
					{
						list.Add(0L);
					}
					2 = new DateTime((int)list[0], (int)list[1] + 1, (int)((list[2] == 0L) ? 1L : list[2]), (int)list[3], (int)list[4], (int)list[5], (int)list[6]);
					return true;
				}
			}
			return false;
		}
		2 = 382.Method2117(num.Value);
		return true;
	}

	// Token: 0x06000B2A RID: 2858 RVA: 0x00029ECC File Offset: 0x000280CC
	private static bool Method4466(139 1, out long? 2, [239(false)] [241(2)] out string 3)
	{
		2 = null;
		3 = null;
		if (!1.Read())
		{
			3 = "Unexpected end when reading date constructor.";
			return false;
		}
		if (1.GetTokenType() == 216.EndConstructor)
		{
			return true;
		}
		if (1.GetTokenType() != 216.Integer)
		{
			3 = "Unexpected token when reading date constructor. Expected Integer, got " + 1.GetTokenType().ToString();
			return false;
		}
		2 = new long?((long)1.GetValue());
		return true;
	}

	// Token: 0x0400057E RID: 1406
	internal static readonly bool[] flagArray2 = new bool[128];

	// Token: 0x0400057F RID: 1407
	internal static readonly bool[] flagArray3 = new bool[128];

	// Token: 0x04000580 RID: 1408
	internal static readonly bool[] flagArray4 = new bool[128];
}
