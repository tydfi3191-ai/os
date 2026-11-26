using System;
using System.Globalization;

// Token: 0x02000546 RID: 1350
[276]
internal sealed class 2530
{
	// Token: 0x06002982 RID: 10626 RVA: 0x000D7CCC File Offset: 0x000D5ECC
	internal 2530(string 1, string 2, string 3, 2531 4, string 5)
	{
		this.1 = 1;
		this.2 = 2;
		this.3 = 3;
		this.4 = 4;
		this.5 = 5;
	}

	// Token: 0x06002983 RID: 10627 RVA: 0x000D7D30 File Offset: 0x000D5F30
	internal static 2530 1(string 1, string 2, string 3, bool 4)
	{
		return new 2530(1, 2, 3, 2531.Toggle, 4 ? "1" : "0");
	}

	// Token: 0x06002984 RID: 10628 RVA: 0x000D7D4A File Offset: 0x000D5F4A
	internal static 2530 2(string 1, string 2, string 3, float 4, float 5, float 6, float 7, string 8 = "0.##")
	{
		return new 2530(1, 2, 3, 2531.Number, 2530.8(4))
		{
			6 = 5,
			7 = 6,
			8 = 7,
			9 = 8
		};
	}

	// Token: 0x06002985 RID: 10629 RVA: 0x000D7D7B File Offset: 0x000D5F7B
	internal static 2530 3(string 1, string 2, string 3, string 4, string[] 5, string[] 6 = null)
	{
		return new 2530(1, 2, 3, 2531.Choice, 4)
		{
			12 = 5,
			13 = (6 ?? 5)
		};
	}

	// Token: 0x06002986 RID: 10630 RVA: 0x000D7D9D File Offset: 0x000D5F9D
	internal static 2530 Colour(string 1, string 2, string 3, 198 4)
	{
		return new 2530(1, 2, 3, 2531.Colour, 2530.9(4));
	}

	// Token: 0x06002987 RID: 10631 RVA: 0x000D7DAE File Offset: 0x000D5FAE
	internal static 2530 Text(string 1, string 2, string 3, string 4, int 5 = 200)
	{
		return new 2530(1, 2, 3, 2531.Text, 4)
		{
			19 = 5
		};
	}

	// Token: 0x06002988 RID: 10632 RVA: 0x000D7DC2 File Offset: 0x000D5FC2
	internal string[] 4()
	{
		string[] result;
		if (this.14 == null)
		{
			if ((result = this.12) == null)
			{
				return new string[0];
			}
		}
		else
		{
			result = this.14();
		}
		return result;
	}

	// Token: 0x06002989 RID: 10633 RVA: 0x000D7DE8 File Offset: 0x000D5FE8
	internal string[] 5()
	{
		return ((this.15 != null) ? this.15() : this.13) ?? this.4();
	}

	// Token: 0x0600298A RID: 10634 RVA: 0x000D7E10 File Offset: 0x000D6010
	internal string 6(string 1)
	{
		string[] array = this.4();
		string[] array2 = this.5();
		int i = 0;
		while (i < array.Length)
		{
			if (string.Equals(array[i], 1, StringComparison.OrdinalIgnoreCase))
			{
				if (i >= array2.Length)
				{
					return array[i];
				}
				return array2[i];
			}
			else
			{
				i++;
			}
		}
		return 1;
	}

	// Token: 0x0600298B RID: 10635 RVA: 0x000D7E54 File Offset: 0x000D6054
	internal string 7(string 1)
	{
		switch (this.4)
		{
		case 2531.Toggle:
			if (!(1 == "1") && !string.Equals(1, "true", StringComparison.OrdinalIgnoreCase))
			{
				return "0";
			}
			return "1";
		case 2531.Number:
		{
			float num;
			if (!float.TryParse(1, NumberStyles.Float, CultureInfo.InvariantCulture, out num) || float.IsNaN(num) || float.IsInfinity(num))
			{
				return this.5;
			}
			if (this.8 > 0f)
			{
				num = (float)(Math.Round((double)((num - this.6) / this.8)) * (double)this.8 + (double)this.6);
			}
			return 2530.8(Math.Max(this.6, Math.Min(this.7, num)));
		}
		case 2531.Choice:
			foreach (string text in this.4())
			{
				if (string.Equals(text, 1, StringComparison.OrdinalIgnoreCase))
				{
					return text;
				}
			}
			if (this.14 == null || string.IsNullOrEmpty(1))
			{
				return this.5;
			}
			return 1;
		case 2531.Colour:
		{
			198 2;
			if (!2530.10(1, out 2))
			{
				return this.5;
			}
			return 2530.9(2);
		}
		default:
			1 = (1 ?? string.Empty);
			if (1.Length <= this.19)
			{
				return 1;
			}
			return 1.Substring(0, this.19);
		}
	}

	// Token: 0x0600298C RID: 10636 RVA: 0x000D7FB0 File Offset: 0x000D61B0
	internal string Display(float 1)
	{
		if (1 == 0f && this.11 != null)
		{
			return this.11;
		}
		if (!this.10)
		{
			return 1.ToString(this.9, CultureInfo.InvariantCulture);
		}
		return (1 * 100f).ToString("0", CultureInfo.InvariantCulture) + "%";
	}

	// Token: 0x0600298D RID: 10637 RVA: 0x000D8012 File Offset: 0x000D6212
	internal static string 8(float 1)
	{
		return 1.ToString("0.####", CultureInfo.InvariantCulture);
	}

	// Token: 0x0600298E RID: 10638 RVA: 0x000D8028 File Offset: 0x000D6228
	internal static string 9(198 1)
	{
		return "#" + 1.R.ToString("X2", CultureInfo.InvariantCulture) + 1.G.ToString("X2", CultureInfo.InvariantCulture) + 1.B.ToString("X2", CultureInfo.InvariantCulture);
	}

	// Token: 0x0600298F RID: 10639 RVA: 0x000D8084 File Offset: 0x000D6284
	internal static bool 10(string 1, out 198 2)
	{
		2 = 198.White;
		if (string.IsNullOrEmpty(1))
		{
			return false;
		}
		string text = 1.Trim().TrimStart(new char[]
		{
			'#'
		});
		if (text.Length == 3)
		{
			text = new string(new char[]
			{
				text[0],
				text[0],
				text[1],
				text[1],
				text[2],
				text[2]
			});
		}
		int num;
		if (text.Length != 6 || !int.TryParse(text, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out num))
		{
			return false;
		}
		2 = new 198((byte)(num >> 16), (byte)(num >> 8), (byte)num);
		return true;
	}

	// Token: 0x04001E23 RID: 7715
	internal readonly string 1;

	// Token: 0x04001E24 RID: 7716
	internal readonly string 2;

	// Token: 0x04001E25 RID: 7717
	internal readonly string 3;

	// Token: 0x04001E26 RID: 7718
	internal readonly 2531 4;

	// Token: 0x04001E27 RID: 7719
	internal readonly string 5;

	// Token: 0x04001E28 RID: 7720
	internal float 6;

	// Token: 0x04001E29 RID: 7721
	internal float 7 = 1f;

	// Token: 0x04001E2A RID: 7722
	internal float 8 = 1f;

	// Token: 0x04001E2B RID: 7723
	internal string 9 = "0";

	// Token: 0x04001E2C RID: 7724
	internal bool 10;

	// Token: 0x04001E2D RID: 7725
	internal string 11;

	// Token: 0x04001E2E RID: 7726
	internal string[] 12;

	// Token: 0x04001E2F RID: 7727
	internal string[] 13;

	// Token: 0x04001E30 RID: 7728
	internal Func<string[]> 14;

	// Token: 0x04001E31 RID: 7729
	internal Func<string[]> 15;

	// Token: 0x04001E32 RID: 7730
	internal Func<bool> 16;

	// Token: 0x04001E33 RID: 7731
	internal Func<string> 17;

	// Token: 0x04001E34 RID: 7732
	internal Action<string> 18;

	// Token: 0x04001E35 RID: 7733
	internal int 19 = 200;
}
