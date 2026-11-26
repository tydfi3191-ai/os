using System;
using System.Runtime.CompilerServices;

// Token: 0x0200050F RID: 1295
[276]
internal abstract class 2503 : 2510
{
	// Token: 0x0600279A RID: 10138 RVA: 0x000C67B4 File Offset: 0x000C49B4
	protected 2503(2511 1, 2528 2) : base(1, 2)
	{
	}

	// Token: 0x0600279B RID: 10139 RVA: 0x000C67C0 File Offset: 0x000C49C0
	protected void 6()
	{
		this.2.8(2530.3("font", "Font", "The typeface of the text.", "aller", 2503.6, 2503.7));
		2530 <<EMPTY_NAME>> = this.2.8(2530.3("weight", "Text weight", "How bold the text is.", "regular", null, null));
		<<EMPTY_NAME>>.14 = (() => 2503.7(this.2.10("font")));
		<<EMPTY_NAME>>.15 = delegate()
		{
			string[] array = 2503.7(this.2.10("font"));
			Converter<string, string> converter;
			if ((converter = 2503.<>O.<0>__WeightName) == null)
			{
				converter = (2503.<>O.<0>__WeightName = new Converter<string, string>(2503.8));
			}
			return Array.ConvertAll<string, string>(array, converter);
		};
	}

	// Token: 0x0600279C RID: 10140 RVA: 0x000C6848 File Offset: 0x000C4A48
	private static string[] 7(string 1)
	{
		if (1 == "exo")
		{
			return new string[]
			{
				"thin",
				"extralight",
				"light",
				"regular",
				"medium",
				"semibold",
				"bold",
				"extrabold",
				"black"
			};
		}
		if (!(1 == "tahoma"))
		{
			return new string[]
			{
				"light",
				"regular",
				"bold"
			};
		}
		return new string[]
		{
			"regular",
			"bold"
		};
	}

	// Token: 0x0600279D RID: 10141 RVA: 0x000C68F8 File Offset: 0x000C4AF8
	private static string 8(string 1)
	{
		if (1 == "extralight")
		{
			return "Extra light";
		}
		if (1 == "semibold")
		{
			return "Semi bold";
		}
		if (!(1 == "extrabold"))
		{
			return char.ToUpperInvariant(1[0]).ToString() + 1.Substring(1);
		}
		return "Extra bold";
	}

	// Token: 0x0600279E RID: 10142 RVA: 0x000C6960 File Offset: 0x000C4B60
	private static 1068 9(string 1, string 2, out bool 3)
	{
		3 = (2 == "bold");
		if (1 == "exo")
		{
			if (2 != null)
			{
				switch (2.Length)
				{
				case 4:
					if (2 == "thin")
					{
						return (1068)11;
					}
					break;
				case 5:
				{
					char c = 2[0];
					if (c != 'b')
					{
						if (c == 'l')
						{
							if (2 == "light")
							{
								return (1068)8;
							}
						}
					}
					else if (2 == "black")
					{
						return (1068)5;
					}
					break;
				}
				case 6:
					if (2 == "medium")
					{
						return (1068)9;
					}
					break;
				case 8:
					if (2 == "semibold")
					{
						return (1068)10;
					}
					break;
				case 9:
					if (2 == "extrabold")
					{
						return (1068)6;
					}
					break;
				case 10:
					if (2 == "extralight")
					{
						return (1068)7;
					}
					break;
				}
			}
			return (1068)4;
		}
		if (1 == "tahoma")
		{
			return (1068)2;
		}
		if (!(2 == "light"))
		{
			return (1068)1;
		}
		return (1068)0;
	}

	// Token: 0x0600279F RID: 10143
	protected abstract string GetText();

	// Token: 0x060027A0 RID: 10144 RVA: 0x000C6A74 File Offset: 0x000C4C74
	internal override void Build()
	{
		string <<EMPTY_NAME>> = this.2.10("font");
		string text = this.2.10("weight");
		if (Array.IndexOf<string>(2503.7(<<EMPTY_NAME>>), text) < 0)
		{
			text = "regular";
		}
		this.9 = this.GetText();
		this.8 = base.1<1452>(2510.4(this.9, 25f, base.Pivot, 1065.CentreLeft, 198.White, false), true);
		bool 2;
		this.8.67(2503.9(<<EMPTY_NAME>>, text, out 2));
		this.8.54(2);
	}

	// Token: 0x060027A1 RID: 10145 RVA: 0x000C6B10 File Offset: 0x000C4D10
	protected override void OnSettingChanged(string 1)
	{
		if (1 == "font" && Array.IndexOf<string>(2503.7(this.2.10("font")), this.2.10("weight")) < 0)
		{
			this.2.15("weight", "regular");
		}
		base.OnSettingChanged(1);
	}

	// Token: 0x060027A2 RID: 10146 RVA: 0x000C6B74 File Offset: 0x000C4D74
	internal override void Update()
	{
		if (this.8 == null)
		{
			return;
		}
		base.3(this.8, 25f);
		string text = this.GetText();
		if (text != this.9)
		{
			this.9 = text;
			this.8.SetText(text);
		}
	}

	// Token: 0x04001C9B RID: 7323
	private new const float 5 = 25f;

	// Token: 0x04001C9C RID: 7324
	private static readonly string[] 6 = new string[]
	{
		"aller",
		"exo",
		"tahoma"
	};

	// Token: 0x04001C9D RID: 7325
	private static readonly string[] 7 = new string[]
	{
		"Aller",
		"Exo 2.0",
		"Tahoma"
	};

	// Token: 0x04001C9E RID: 7326
	private 1452 8;

	// Token: 0x04001C9F RID: 7327
	private string 9;

	// Token: 0x02000510 RID: 1296
	[CompilerGenerated]
	[276]
	private static class <>O
	{
		// Token: 0x04001CA0 RID: 7328
		public static Converter<string, string> <0>__WeightName;
	}
}
