using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

// Token: 0x020000EC RID: 236
[242(1)]
[241(0)]
public sealed class 113
{
	// Token: 0x06000800 RID: 2048 RVA: 0x0001AAC8 File Offset: 0x00018CC8
	public 113(string 1)
	{
		756.Method12216(1, "expression");
		this.text4 = 1;
		this.list2 = new List<368>();
		this.Method12254();
	}

	// Token: 0x06000801 RID: 2049 RVA: 0x0001AAF3 File Offset: 0x00018CF3
	public List<368> GetList9575_12253()
	{
		return this.list2;
	}

	// Token: 0x06000802 RID: 2050 RVA: 0x0001AAFC File Offset: 0x00018CFC
	private void Method12254()
	{
		int <<EMPTY_NAME>> = this.number2;
		this.Method12259();
		if (this.text4.Length == this.number2)
		{
			return;
		}
		if (this.text4[this.number2] == '$')
		{
			if (this.text4.Length == 1)
			{
				return;
			}
			char c = this.text4[this.number2 + 1];
			if (c == '.' || c == '[')
			{
				this.number2++;
				<<EMPTY_NAME>> = this.number2;
			}
		}
		if (!this.Method12255(this.GetList9575_12253(), <<EMPTY_NAME>>, false))
		{
			int index = this.number2;
			this.Method12259();
			if (this.number2 < this.text4.Length)
			{
				throw new 134("Unexpected character while parsing path: " + this.text4[index].ToString());
			}
		}
	}

	// Token: 0x06000803 RID: 2051 RVA: 0x0001ABD8 File Offset: 0x00018DD8
	private bool Method12255(List<368> 1, int 2, bool 3)
	{
		bool 4 = false;
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		while (this.number2 < this.text4.Length && !flag3)
		{
			char c = this.text4[this.number2];
			if (c <= ')')
			{
				if (c != ' ')
				{
					if (c != '(')
					{
						if (c != ')')
						{
							goto IL_189;
						}
						goto IL_CD;
					}
				}
				else
				{
					if (this.number2 < this.text4.Length)
					{
						flag3 = true;
						continue;
					}
					continue;
				}
			}
			else
			{
				if (c == '.')
				{
					if (this.number2 > 2)
					{
						string text = this.text4.Substring(2, this.number2 - 2);
						if (text == "*")
						{
							text = null;
						}
						1.Add(113.Method12256(text, 4));
						4 = false;
					}
					if (this.number2 + 1 < this.text4.Length && this.text4[this.number2 + 1] == '.')
					{
						4 = true;
						this.number2++;
					}
					this.number2++;
					2 = this.number2;
					flag = false;
					flag2 = true;
					continue;
				}
				if (c != '[')
				{
					if (c != ']')
					{
						goto IL_189;
					}
					goto IL_CD;
				}
			}
			if (this.number2 > 2)
			{
				string text2 = this.text4.Substring(2, this.number2 - 2);
				if (text2 == "*")
				{
					text2 = null;
				}
				1.Add(113.Method12256(text2, 4));
				4 = false;
			}
			1.Add(this.Method12257(c, 4));
			4 = false;
			this.number2++;
			2 = this.number2;
			flag = true;
			flag2 = false;
			continue;
			IL_CD:
			flag3 = true;
			continue;
			IL_189:
			if (3 && (c == '=' || c == '<' || c == '!' || c == '>' || c == '|' || c == '&'))
			{
				flag3 = true;
			}
			else
			{
				if (flag)
				{
					throw new 134("Unexpected character following indexer: " + c.ToString());
				}
				this.number2++;
			}
		}
		bool flag4 = this.number2 == this.text4.Length;
		if (this.number2 > 2)
		{
			string text3 = this.text4.Substring(2, this.number2 - 2).TrimEnd(Array.Empty<char>());
			if (text3 == "*")
			{
				text3 = null;
			}
			1.Add(113.Method12256(text3, 4));
		}
		else if (flag2 && (flag4 || 3))
		{
			throw new 134("Unexpected end while parsing path.");
		}
		return flag4;
	}

	// Token: 0x06000804 RID: 2052 RVA: 0x0001AE4F File Offset: 0x0001904F
	private static 368 Method12256([241(2)] string 1, bool 2)
	{
		if (!2)
		{
			return new 599(1);
		}
		return new 475(1);
	}

	// Token: 0x06000805 RID: 2053 RVA: 0x0001AE64 File Offset: 0x00019064
	private 368 Method12257(char 1, bool 2)
	{
		this.number2++;
		char 3 = (1 == '[') ? ']' : ')';
		this.Method12271("Path ended with open indexer.");
		this.Method12259();
		if (this.text4[this.number2] == '\'')
		{
			return this.Method12270(3, 2);
		}
		if (this.text4[this.number2] == '?')
		{
			return this.Method12260(3, 2);
		}
		return this.Method12258(3);
	}

	// Token: 0x06000806 RID: 2054 RVA: 0x0001AEE0 File Offset: 0x000190E0
	private 368 Method12258(char 1)
	{
		int num = this.number2;
		int? num2 = null;
		List<int> list = null;
		int num3 = 0;
		int? nullable9986_ = null;
		int? nullable9987_ = null;
		int? nullable9988_ = null;
		while (this.number2 < this.text4.Length)
		{
			char c = this.text4[this.number2];
			if (c == ' ')
			{
				num2 = new int?(this.number2);
				this.Method12259();
			}
			else if (c == 1)
			{
				int num4 = (num2 ?? this.number2) - num;
				if (list != null)
				{
					if (num4 == 0)
					{
						throw new 134("Array index expected.");
					}
					int item = Convert.ToInt32(this.text4.Substring(num, num4), CultureInfo.InvariantCulture);
					list.Add(item);
					return new 750(list);
				}
				else
				{
					if (num3 > 0)
					{
						if (num4 > 0)
						{
							int value = Convert.ToInt32(this.text4.Substring(num, num4), CultureInfo.InvariantCulture);
							if (num3 == 1)
							{
								nullable9987_ = new int?(value);
							}
							else
							{
								nullable9988_ = new int?(value);
							}
						}
						779 2 = new 779();
						2.SetNullable9986_12756(nullable9986_);
						2.SetNullable9987_12758(nullable9987_);
						2.SetNullable9988_12760(nullable9988_);
						return 2;
					}
					if (num4 == 0)
					{
						throw new 134("Array index expected.");
					}
					int value2 = Convert.ToInt32(this.text4.Substring(num, num4), CultureInfo.InvariantCulture);
					752 3 = new 752();
					3.SetNullable9513_12177(new int?(value2));
					return 3;
				}
			}
			else if (c != '*')
			{
				if (c != ',')
				{
					if (c != ':')
					{
						if (!char.IsDigit(c) && c != '-')
						{
							throw new 134("Unexpected character while parsing path indexer: " + c.ToString());
						}
						if (num2 != null)
						{
							throw new 134("Unexpected character while parsing path indexer: " + c.ToString());
						}
						this.number2++;
					}
					else
					{
						int num5 = (num2 ?? this.number2) - num;
						if (num5 > 0)
						{
							int value3 = Convert.ToInt32(this.text4.Substring(num, num5), CultureInfo.InvariantCulture);
							if (num3 != 0)
							{
								if (num3 != 1)
								{
									nullable9988_ = new int?(value3);
								}
								else
								{
									nullable9987_ = new int?(value3);
								}
							}
							else
							{
								nullable9986_ = new int?(value3);
							}
						}
						num3++;
						this.number2++;
						this.Method12259();
						num = this.number2;
						num2 = null;
					}
				}
				else
				{
					int num6 = (num2 ?? this.number2) - num;
					if (num6 == 0)
					{
						throw new 134("Array index expected.");
					}
					if (list == null)
					{
						list = new List<int>();
					}
					string value4 = this.text4.Substring(num, num6);
					list.Add(Convert.ToInt32(value4, CultureInfo.InvariantCulture));
					this.number2++;
					this.Method12259();
					num = this.number2;
					num2 = null;
				}
			}
			else
			{
				this.number2++;
				this.Method12271("Path ended with open indexer.");
				this.Method12259();
				if (this.text4[this.number2] != 1)
				{
					throw new 134("Unexpected character while parsing path indexer: " + c.ToString());
				}
				return new 752();
			}
		}
		throw new 134("Path ended with open indexer.");
	}

	// Token: 0x06000807 RID: 2055 RVA: 0x0001B236 File Offset: 0x00019436
	private void Method12259()
	{
		while (this.number2 < this.text4.Length && this.text4[this.number2] == ' ')
		{
			this.number2++;
		}
	}

	// Token: 0x06000808 RID: 2056 RVA: 0x0001B270 File Offset: 0x00019470
	private 368 Method12260(char 1, bool 2)
	{
		this.number2++;
		this.Method12271("Path ended with open indexer.");
		if (this.text4[this.number2] != '(')
		{
			throw new 134("Unexpected character while parsing path indexer: " + this.text4[this.number2].ToString());
		}
		this.number2++;
		781 3 = this.Method12264();
		this.number2++;
		this.Method12271("Path ended with open indexer.");
		this.Method12259();
		if (this.text4[this.number2] != 1)
		{
			throw new 134("Unexpected character while parsing path indexer: " + this.text4[this.number2].ToString());
		}
		if (!2)
		{
			return new 457(3);
		}
		return new 445(3);
	}

	// Token: 0x06000809 RID: 2057 RVA: 0x0001B358 File Offset: 0x00019558
	private bool Method12261([241(new byte[]
	{
		2,
		1
	})] out List<368> 1)
	{
		if (this.text4[this.number2] == '$')
		{
			1 = new List<368>
			{
				682._recoveredType18428059
			};
		}
		else
		{
			if (this.text4[this.number2] != '@')
			{
				1 = null;
				return false;
			}
			1 = new List<368>();
		}
		this.number2++;
		if (this.Method12255(1, this.number2, true))
		{
			throw new 134("Path ended with open query.");
		}
		return true;
	}

	// Token: 0x0600080A RID: 2058 RVA: 0x0001B3DC File Offset: 0x000195DC
	private 134 Method12262()
	{
		return new 134("Unexpected character while parsing path query: " + this.text4[this.number2].ToString());
	}

	// Token: 0x0600080B RID: 2059 RVA: 0x0001B414 File Offset: 0x00019614
	private object Method12263()
	{
		this.Method12259();
		List<368> result;
		if (this.Method12261(out result))
		{
			this.Method12259();
			this.Method12271("Path ended with open query.");
			return result;
		}
		object <<EMPTY_NAME>>;
		if (this.Method12265(out <<EMPTY_NAME>>))
		{
			this.Method12259();
			this.Method12271("Path ended with open query.");
			return new 233(<<EMPTY_NAME>>);
		}
		throw this.Method12262();
	}

	// Token: 0x0600080C RID: 2060 RVA: 0x0001B46C File Offset: 0x0001966C
	private 781 Method12264()
	{
		781 <<EMPTY_NAME>> = null;
		433 2 = null;
		while (this.number2 < this.text4.Length)
		{
			object 3 = this.Method12263();
			object 4 = null;
			696 5;
			if (this.text4[this.number2] == ')' || this.text4[this.number2] == '|' || this.text4[this.number2] == '&')
			{
				5 = (696)3;
			}
			else
			{
				5 = this.Method12269();
				4 = this.Method12263();
			}
			562 6 = new 562(5, 3, 4);
			if (this.text4[this.number2] == ')')
			{
				if (2 != null)
				{
					2.GetList2844_3597().Add(6);
					return <<EMPTY_NAME>>;
				}
				return 6;
			}
			else
			{
				if (this.text4[this.number2] == '&')
				{
					if (!this.Method12268("&&"))
					{
						throw this.Method12262();
					}
					if (2 == null || 2._recoveredType19089989 != (696)8)
					{
						433 7 = new 433((696)8);
						if (2 != null)
						{
							2.GetList2844_3597().Add(7);
						}
						2 = 7;
						if (<<EMPTY_NAME>> == null)
						{
							<<EMPTY_NAME>> = 2;
						}
					}
					2.GetList2844_3597().Add(6);
				}
				if (this.text4[this.number2] == '|')
				{
					if (!this.Method12268("||"))
					{
						throw this.Method12262();
					}
					if (2 == null || 2._recoveredType19089989 != (696)9)
					{
						433 8 = new 433((696)9);
						if (2 != null)
						{
							2.GetList2844_3597().Add(8);
						}
						2 = 8;
						if (<<EMPTY_NAME>> == null)
						{
							<<EMPTY_NAME>> = 2;
						}
					}
					2.GetList2844_3597().Add(6);
				}
			}
		}
		throw new 134("Path ended with open query.");
	}

	// Token: 0x0600080D RID: 2061 RVA: 0x0001B5FC File Offset: 0x000197FC
	[242(2)]
	private bool Method12265(out object 1)
	{
		char c = this.text4[this.number2];
		if (c == '\'')
		{
			1 = this.Method12266();
			return true;
		}
		if (char.IsDigit(c) || c == '-')
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(c);
			this.number2++;
			while (this.number2 < this.text4.Length)
			{
				c = this.text4[this.number2];
				if (c == ' ' || c == ')')
				{
					string text = stringBuilder.ToString();
					if (text.IndexOfAny(113.charArray) != -1)
					{
						double num;
						bool result = double.TryParse(text, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, CultureInfo.InvariantCulture, out num);
						1 = num;
						return result;
					}
					long num2;
					bool result2 = long.TryParse(text, NumberStyles.Integer, CultureInfo.InvariantCulture, out num2);
					1 = num2;
					return result2;
				}
				else
				{
					stringBuilder.Append(c);
					this.number2++;
				}
			}
		}
		else if (c <= 'f')
		{
			if (c == '/')
			{
				1 = this.Method12267();
				return true;
			}
			if (c == 'f')
			{
				if (this.Method12268("false"))
				{
					1 = false;
					return true;
				}
			}
		}
		else if (c != 'n')
		{
			if (c == 't' && this.Method12268("true"))
			{
				1 = true;
				return true;
			}
		}
		else if (this.Method12268("null"))
		{
			1 = null;
			return true;
		}
		1 = null;
		return false;
	}

	// Token: 0x0600080E RID: 2062 RVA: 0x0001B754 File Offset: 0x00019954
	private string Method12266()
	{
		StringBuilder stringBuilder = new StringBuilder();
		this.number2++;
		while (this.number2 < this.text4.Length)
		{
			char c = this.text4[this.number2];
			if (c == '\\' && this.number2 + 1 < this.text4.Length)
			{
				this.number2++;
				c = this.text4[this.number2];
				char value;
				if (c <= '\\')
				{
					if (c <= '\'')
					{
						if (c != '"' && c != '\'')
						{
							goto IL_CB;
						}
					}
					else if (c != '/' && c != '\\')
					{
						goto IL_CB;
					}
					value = c;
				}
				else if (c <= 'f')
				{
					if (c != 'b')
					{
						if (c != 'f')
						{
							goto IL_CB;
						}
						value = '\f';
					}
					else
					{
						value = '\b';
					}
				}
				else if (c != 'n')
				{
					if (c != 'r')
					{
						if (c != 't')
						{
							goto IL_CB;
						}
						value = '\t';
					}
					else
					{
						value = '\r';
					}
				}
				else
				{
					value = '\n';
				}
				stringBuilder.Append(value);
				this.number2++;
				continue;
				IL_CB:
				throw new 134("Unknown escape character: \\" + c.ToString());
			}
			if (c == '\'')
			{
				this.number2++;
				return stringBuilder.ToString();
			}
			this.number2++;
			stringBuilder.Append(c);
		}
		throw new 134("Path ended with an open string.");
	}

	// Token: 0x0600080F RID: 2063 RVA: 0x0001B8AC File Offset: 0x00019AAC
	private string Method12267()
	{
		int num = this.number2;
		this.number2++;
		while (this.number2 < this.text4.Length)
		{
			char c = this.text4[this.number2];
			if (c == '\\' && this.number2 + 1 < this.text4.Length)
			{
				this.number2 += 2;
			}
			else
			{
				if (c == '/')
				{
					this.number2++;
					while (this.number2 < this.text4.Length)
					{
						c = this.text4[this.number2];
						if (!char.IsLetter(c))
						{
							break;
						}
						this.number2++;
					}
					return this.text4.Substring(num, this.number2 - num);
				}
				this.number2++;
			}
		}
		throw new 134("Path ended with an open regex.");
	}

	// Token: 0x06000810 RID: 2064 RVA: 0x0001B9A4 File Offset: 0x00019BA4
	private bool Method12268(string 1)
	{
		int num = this.number2;
		for (int i = 0; i < 1.Length; i++)
		{
			if (num >= this.text4.Length || this.text4[num] != 1[i])
			{
				return false;
			}
			num++;
		}
		this.number2 = num;
		return true;
	}

	// Token: 0x06000811 RID: 2065 RVA: 0x0001B9FC File Offset: 0x00019BFC
	private 696 Method12269()
	{
		if (this.number2 + 1 >= this.text4.Length)
		{
			throw new 134("Path ended with open query.");
		}
		if (this.Method12268("==="))
		{
			return (696)11;
		}
		if (this.Method12268("=="))
		{
			return (696)1;
		}
		if (this.Method12268("=~"))
		{
			return (696)10;
		}
		if (this.Method12268("!=="))
		{
			return (696)12;
		}
		if (this.Method12268("!=") || this.Method12268("<>"))
		{
			return (696)2;
		}
		if (this.Method12268("<="))
		{
			return (696)5;
		}
		if (this.Method12268("<"))
		{
			return (696)4;
		}
		if (this.Method12268(">="))
		{
			return (696)7;
		}
		if (this.Method12268(">"))
		{
			return (696)6;
		}
		throw new 134("Could not read query operator.");
	}

	// Token: 0x06000812 RID: 2066 RVA: 0x0001BACC File Offset: 0x00019CCC
	private 368 Method12270(char 1, bool 2)
	{
		List<string> list = null;
		while (this.number2 < this.text4.Length)
		{
			string text = this.Method12266();
			this.Method12259();
			this.Method12271("Path ended with open indexer.");
			if (this.text4[this.number2] == 1)
			{
				if (list == null)
				{
					return 113.Method12256(text, 2);
				}
				list.Add(text);
				if (!2)
				{
					return new 709(list);
				}
				return new 497(list);
			}
			else
			{
				if (this.text4[this.number2] != ',')
				{
					throw new 134("Unexpected character while parsing path indexer: " + this.text4[this.number2].ToString());
				}
				this.number2++;
				this.Method12259();
				if (list == null)
				{
					list = new List<string>();
				}
				list.Add(text);
			}
		}
		throw new 134("Path ended with open indexer.");
	}

	// Token: 0x06000813 RID: 2067 RVA: 0x0001BBB3 File Offset: 0x00019DB3
	private void Method12271(string 1)
	{
		if (this.number2 >= this.text4.Length)
		{
			throw new 134(1);
		}
	}

	// Token: 0x06000814 RID: 2068 RVA: 0x0001BBCF File Offset: 0x00019DCF
	internal IEnumerable<226> Method12272(226 1, 226 2, [241(2)] 541 3)
	{
		return 113.Method12272(this.GetList9575_12253(), 1, 2, 3);
	}

	// Token: 0x06000815 RID: 2069 RVA: 0x0001BBE0 File Offset: 0x00019DE0
	internal static IEnumerable<226> Method12272(List<368> 1, 226 2, 226 3, [241(2)] 541 4)
	{
		IEnumerable<226> enumerable = new 226[]
		{
			3
		};
		foreach (368 5 in 1)
		{
			enumerable = 5.Method12761(2, enumerable, 4);
		}
		return enumerable;
	}

	// Token: 0x040004AA RID: 1194
	private static readonly char[] charArray = new char[]
	{
		'.',
		'E',
		'e'
	};

	// Token: 0x040004AB RID: 1195
	private readonly string text4;

	// Token: 0x040004AC RID: 1196
	private readonly List<368> list2;

	// Token: 0x040004AD RID: 1197
	private int number2;
}
