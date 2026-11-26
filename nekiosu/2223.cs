using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

// Token: 0x0200068E RID: 1678
[276]
internal sealed class 2223
{
	// Token: 0x1700027E RID: 638
	// (get) Token: 0x06003280 RID: 12928 RVA: 0x00132FA4 File Offset: 0x001311A4
	internal bool IsEmpty
	{
		get
		{
			return this.3.Count == 0;
		}
	}

	// Token: 0x1700027F RID: 639
	// (get) Token: 0x06003281 RID: 12929 RVA: 0x00132FB4 File Offset: 0x001311B4
	// (set) Token: 0x06003282 RID: 12930 RVA: 0x00132FBC File Offset: 0x001311BC
	internal string Problem { get; private set; }

	// Token: 0x06003283 RID: 12931 RVA: 0x00132FC8 File Offset: 0x001311C8
	internal 2223(string 1)
	{
		foreach (string text in 2223.10(1 ?? string.Empty))
		{
			if (!this.2(text))
			{
				this.Problem = ((this.Problem == null) ? text : (this.Problem + " " + text));
			}
		}
	}

	// Token: 0x06003284 RID: 12932 RVA: 0x0013305C File Offset: 0x0013125C
	internal bool 1(2210.2214 1)
	{
		using (List<Func<2210.2214, bool>>.Enumerator enumerator = this.3.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (!enumerator.Current(1))
				{
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x06003285 RID: 12933 RVA: 0x001330B8 File Offset: 0x001312B8
	private bool 2(string 1)
	{
		if (2.Length > 1 && (2[0] == '+' || 2[0] == '-'))
		{
			HashSet<string> wanted = 2223.8(2.Substring(1));
			if (wanted == null || wanted.Count == 0)
			{
				string name = 2.ToLowerInvariant();
				this.3.Add((2210.2214 1) => (2223.4(1) ?? string.Empty).ToLowerInvariant().Contains(name));
				return true;
			}
			bool has = 2[0] == '+';
			this.3.Add(delegate(2210.2214 1)
			{
				HashSet<string> hashSet = 2223.9(1.1, wanted);
				foreach (string item in wanted)
				{
					if (hashSet.Contains(item) != has)
					{
						return false;
					}
				}
				return true;
			});
			return true;
		}
		else
		{
			Match match = 2223.1.Match(2);
			if (!match.Success)
			{
				string text = 2.ToLowerInvariant();
				this.3.Add((2210.2214 1) => (2223.4(1) ?? string.Empty).ToLowerInvariant().Contains(text));
				return true;
			}
			string text3 = match.Groups[1].Value.ToLowerInvariant();
			string op = match.Groups[2].Value;
			string text2 = match.Groups[3].Value.Trim();
			if (!(text3 == "mods") && !(text3 == "mod"))
			{
				if (!(text3 == "set"))
				{
					if (!(text3 == "grade") && !(text3 == "rank"))
					{
						Func<2210.2214, double> field2;
						if (text3 != null)
						{
							switch (text3.Length)
							{
							case 2:
								if (!(text3 == "pp"))
								{
									goto IL_566;
								}
								field2 = ((2210.2214 1) => 1.4);
								goto IL_569;
							case 3:
							{
								char c = text3[1];
								if (c != 'c')
								{
									if (c != 'g')
									{
										goto IL_566;
									}
									if (!(text3 == "age"))
									{
										goto IL_566;
									}
									goto IL_543;
								}
								else if (!(text3 == "acc"))
								{
									goto IL_566;
								}
								break;
							}
							case 4:
							{
								char c = text3[0];
								if (c != 'd')
								{
									if (c != 'm')
									{
										goto IL_566;
									}
									if (!(text3 == "miss"))
									{
										goto IL_566;
									}
									goto IL_4FD;
								}
								else
								{
									if (!(text3 == "days"))
									{
										goto IL_566;
									}
									goto IL_543;
								}
								break;
							}
							case 5:
							{
								char c = text3[0];
								if (c != 'c')
								{
									if (c != 's')
									{
										goto IL_566;
									}
									if (!(text3 == "score"))
									{
										goto IL_566;
									}
									field2 = ((2210.2214 1) => (double)1.1.GetScore());
									goto IL_569;
								}
								else
								{
									if (!(text3 == "combo"))
									{
										goto IL_566;
									}
									field2 = ((2210.2214 1) => (double)1.1.13);
									goto IL_569;
								}
								break;
							}
							case 6:
								if (!(text3 == "misses"))
								{
									goto IL_566;
								}
								goto IL_4FD;
							case 7:
								goto IL_566;
							case 8:
								if (!(text3 == "accuracy"))
								{
									goto IL_566;
								}
								break;
							default:
								goto IL_566;
							}
							field2 = ((2210.2214 1) => 1.5 * 100.0);
							goto IL_569;
							IL_4FD:
							field2 = ((2210.2214 1) => (double)1.1.6);
							goto IL_569;
							IL_543:
							field2 = ((2210.2214 1) => (DateTime.UtcNow - 1.1.7.ToUniversalTime()).TotalDays);
							goto IL_569;
						}
						IL_566:
						field2 = null;
						IL_569:
						Func<2210.2214, double> field = field2;
						double number;
						if (field == null || !double.TryParse(text2.TrimEnd(new char[]
						{
							'%',
							'x',
							'X'
						}), NumberStyles.Float, CultureInfo.InvariantCulture, out number))
						{
							return false;
						}
						this.3.Add((2210.2214 1) => 2223.5(field(1), op, number));
						return true;
					}
					else
					{
						int wanted = 2223.6(text2.ToUpperInvariant());
						if (wanted < 0)
						{
							return false;
						}
						this.3.Add((2210.2214 1) => 2223.5((double)2223.7(1.1), op, (double)wanted));
						return true;
					}
				}
				else
				{
					string a = text2.ToLowerInvariant();
					bool? online2;
					if (!(a == "bancho") && !(a == "online"))
					{
						if (!(a == "offline") && !(a == "local"))
						{
							online2 = null;
						}
						else
						{
							online2 = new bool?(false);
						}
					}
					else
					{
						online2 = new bool?(true);
					}
					bool? online = online2;
					if (online == null || (op != "=" && op != "==" && op != "!="))
					{
						return false;
					}
					bool equal = op != "!=";
					this.3.Add((2210.2214 1) => 2223.3(1.1) == online.Value == equal);
					return true;
				}
			}
			else
			{
				HashSet<string> wanted = 2223.8(text2);
				if (wanted == null || (op != "=" && op != "==" && op != "!="))
				{
					return false;
				}
				bool equal = op != "!=";
				this.3.Add((2210.2214 1) => 2223.9(1.1, wanted).SetEquals(wanted) == equal);
				return true;
			}
		}
	}

	// Token: 0x06003286 RID: 12934 RVA: 0x00133686 File Offset: 0x00131886
	internal static bool 3(2241 1)
	{
		return 1.16 > 0L;
	}

	// Token: 0x06003287 RID: 12935 RVA: 0x00133692 File Offset: 0x00131892
	private static string 4(2210.2214 1)
	{
		1262 2 = 1.3;
		return ((2 != null) ? 2.49 : null) ?? 1.8;
	}

	// Token: 0x06003288 RID: 12936 RVA: 0x001336B0 File Offset: 0x001318B0
	private static bool 5(double 1, string 2, double 3)
	{
		if (2 == "<")
		{
			return 1 < 3;
		}
		if (2 == ">")
		{
			return 1 > 3;
		}
		if (2 == "<=")
		{
			return 1 <= 3;
		}
		if (2 == ">=")
		{
			return 1 >= 3;
		}
		if (!(2 == "!="))
		{
			return Math.Abs(1 - 3) <= 1E-09;
		}
		return Math.Abs(1 - 3) > 1E-09;
	}

	// Token: 0x06003289 RID: 12937 RVA: 0x00133744 File Offset: 0x00131944
	private static int 6(string 1)
	{
		if (1 != null)
		{
			switch (1.Length)
			{
			case 1:
			{
				char c = 1[0];
				switch (c)
				{
				case 'A':
					return 3;
				case 'B':
					return 2;
				case 'C':
					return 1;
				case 'D':
					return 0;
				default:
					if (c != 'S')
					{
						if (c != 'X')
						{
							return -1;
						}
						return 5;
					}
					break;
				}
				break;
			}
			case 2:
			{
				char c = 1[0];
				if (c != 'S')
				{
					if (c != 'X')
					{
						return -1;
					}
					if (!(1 == "XH"))
					{
						return -1;
					}
					return 5;
				}
				else if (!(1 == "SH"))
				{
					if (!(1 == "SS"))
					{
						return -1;
					}
					return 5;
				}
				break;
			}
			case 3:
				if (!(1 == "SSH"))
				{
					return -1;
				}
				return 5;
			default:
				return -1;
			}
			return 4;
		}
		return -1;
	}

	// Token: 0x0600328A RID: 12938 RVA: 0x00133800 File Offset: 0x00131A00
	private static int 7(2241 1)
	{
		return 2223.6(1.CalculateGrade().ToString());
	}

	// Token: 0x0600328B RID: 12939 RVA: 0x00133828 File Offset: 0x00131A28
	private static HashSet<string> 8(string 1)
	{
		HashSet<string> hashSet = new HashSet<string>(StringComparer.Ordinal);
		string text = 2.ToUpperInvariant().Replace(",", string.Empty).Replace("+", string.Empty);
		if (text == "NM" || text == "NOMOD" || text.Length == 0)
		{
			return hashSet;
		}
		string text2;
		for (int i = 0; i < text.Length; i += text2.Length)
		{
			text2 = null;
			foreach (string text3 in new string[]
			{
				"SV2",
				"DA",
				"NL",
				"AL",
				"SG",
				"PR"
			})
			{
				if (string.CompareOrdinal(text, i, text3, 0, text3.Length) == 0)
				{
					text2 = text3;
					break;
				}
			}
			if (text2 == null && i + 2 <= text.Length)
			{
				string pair = text.Substring(i, 2);
				if (Array.Exists<KeyValuePair<string, 2023>>(2223.2, (KeyValuePair<string, 2023> 1) => 1.Key == pair))
				{
					text2 = pair;
				}
			}
			if (text2 == null)
			{
				return null;
			}
			hashSet.Add(text2);
		}
		return hashSet;
	}

	// Token: 0x0600328C RID: 12940 RVA: 0x00133964 File Offset: 0x00131B64
	private static HashSet<string> 9(2241 1, HashSet<string> 2)
	{
		HashSet<string> hashSet = new HashSet<string>(StringComparer.Ordinal);
		2023 3 = 1.8;
		foreach (KeyValuePair<string, 2023> keyValuePair in 2223.2)
		{
			if ((3 & keyValuePair.Value) != 2023.None)
			{
				hashSet.Add(keyValuePair.Key);
			}
		}
		if (hashSet.Contains("NC") && !2.Contains("NC"))
		{
			hashSet.Remove("NC");
			hashSet.Add("DT");
		}
		else if (hashSet.Contains("NC"))
		{
			hashSet.Remove("DT");
		}
		if (hashSet.Contains("PF") && !2.Contains("PF"))
		{
			hashSet.Remove("PF");
			hashSet.Add("SD");
		}
		else if (hashSet.Contains("PF"))
		{
			hashSet.Remove("SD");
		}
		if (1.43 != null)
		{
			hashSet.Add("DA");
		}
		if (1.45)
		{
			hashSet.Add("NL");
		}
		if (1.47)
		{
			hashSet.Add("PR");
		}
		if (1.52 != null)
		{
			foreach (string text in 1.52.1())
			{
				hashSet.Add(text.ToUpperInvariant());
			}
		}
		return hashSet;
	}

	// Token: 0x0600328D RID: 12941 RVA: 0x00133AF0 File Offset: 0x00131CF0
	private static List<string> 10(string 1)
	{
		List<string> list = new List<string>();
		StringBuilder stringBuilder = new StringBuilder();
		bool flag = false;
		foreach (char c in 1)
		{
			if (c == '"')
			{
				flag = !flag;
			}
			else if (c == ' ' && !flag)
			{
				if (stringBuilder.Length > 0)
				{
					list.Add(stringBuilder.ToString());
					stringBuilder.Clear();
				}
			}
			else
			{
				stringBuilder.Append(c);
			}
		}
		if (stringBuilder.Length > 0)
		{
			list.Add(stringBuilder.ToString());
		}
		return list;
	}

	// Token: 0x0400255C RID: 9564
	private static readonly Regex 1 = new Regex("^(\\w+)([<>=]=?|!=)(.*)$", RegexOptions.Compiled);

	// Token: 0x0400255D RID: 9565
	private static readonly KeyValuePair<string, 2023>[] 2 = new KeyValuePair<string, 2023>[]
	{
		new KeyValuePair<string, 2023>("NF", 2023.NoFail),
		new KeyValuePair<string, 2023>("EZ", 2023.Easy),
		new KeyValuePair<string, 2023>("TD", 2023.TouchDevice),
		new KeyValuePair<string, 2023>("HD", 2023.Hidden),
		new KeyValuePair<string, 2023>("HR", 2023.HardRock),
		new KeyValuePair<string, 2023>("SD", 2023.SuddenDeath),
		new KeyValuePair<string, 2023>("DT", 2023.DoubleTime),
		new KeyValuePair<string, 2023>("RX", 2023.Relax),
		new KeyValuePair<string, 2023>("HT", 2023.HalfTime),
		new KeyValuePair<string, 2023>("NC", 2023.Nightcore),
		new KeyValuePair<string, 2023>("FL", 2023.Flashlight),
		new KeyValuePair<string, 2023>("SO", 2023.SpunOut),
		new KeyValuePair<string, 2023>("AP", 2023.Relax2),
		new KeyValuePair<string, 2023>("PF", 2023.Perfect),
		new KeyValuePair<string, 2023>("RD", 2023.Random),
		new KeyValuePair<string, 2023>("MR", 2023.Mirror),
		new KeyValuePair<string, 2023>("SV2", 2023.ScoreV2)
	};

	// Token: 0x0400255E RID: 9566
	private readonly List<Func<2210.2214, bool>> 3 = new List<Func<2210.2214, bool>>();
}
