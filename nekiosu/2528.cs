using System;
using System.Collections.Generic;
using System.Globalization;

// Token: 0x02000541 RID: 1345
[276]
internal sealed class 2528
{
	// Token: 0x06002946 RID: 10566 RVA: 0x000D696C File Offset: 0x000D4B6C
	internal float 1(1436 1)
	{
		2524 2 = this.12;
		if (2 != 2524.Show)
		{
			if (2 != 2524.Hide)
			{
				return 1.5;
			}
			if (!1.27)
			{
				return 1.5 * 2528.23;
			}
			return 1.5;
		}
		else
		{
			if (!1.27)
			{
				return 1.5;
			}
			return 2528.24;
		}
	}

	// Token: 0x17000265 RID: 613
	// (get) Token: 0x06002947 RID: 10567 RVA: 0x000D69C4 File Offset: 0x000D4BC4
	internal static bool AnyShownWithoutInterface
	{
		get
		{
			using (List<2528>.Enumerator enumerator = 2522.1.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.12 == 2524.Show)
					{
						return true;
					}
				}
			}
			return false;
		}
	}

	// Token: 0x06002948 RID: 10568 RVA: 0x000D6A20 File Offset: 0x000D4C20
	internal 2528(string 1, string 2, 2509 3, 208 4, bool 5 = true, string 6 = null)
	{
		this.3 = 1;
		this.4 = (6 ?? 2528.2(1));
		this.5 = 2;
		this.6 = 3;
		this.7 = 4;
		this.30 = 5;
		this.7();
		2525.Apply(this);
	}

	// Token: 0x06002949 RID: 10569 RVA: 0x000D6ACC File Offset: 0x000D4CCC
	internal static string 2(string 1)
	{
		int num = 1.IndexOf('#');
		if (num <= 0)
		{
			return 1;
		}
		return 1.Substring(0, num);
	}

	// Token: 0x17000266 RID: 614
	// (get) Token: 0x0600294A RID: 10570 RVA: 0x000D6AF0 File Offset: 0x000D4CF0
	internal bool IsExtraInstance
	{
		get
		{
			return !string.Equals(this.3, this.4, StringComparison.OrdinalIgnoreCase);
		}
	}

	// Token: 0x0600294B RID: 10571 RVA: 0x000D6B08 File Offset: 0x000D4D08
	internal static 2528 3(string 1, string 2, 1433 3)
	{
		2509 4 = (2509)(2528.24(3.41) ? 3.41 : ((1376)6));
		return new 2528(1, 2, 4, 2528.30(3.17, 3.41), true, null);
	}

	// Token: 0x0600294C RID: 10572 RVA: 0x000D6B47 File Offset: 0x000D4D47
	internal static 2528 4(string 1, string 2, 1433 3, 2509 4, bool 5 = true)
	{
		return 2528.5(1, 2, 4, 2528.6(3), 5, null);
	}

	// Token: 0x0600294D RID: 10573 RVA: 0x000D6B5A File Offset: 0x000D4D5A
	internal static 2528 5(string 1, string 2, 2509 3, 208 4, bool 5 = true, string 6 = null)
	{
		return new 2528(1, 2, 3, 4 - 2528.26(3, 2528.WindowWidth, 480f), 5, 6);
	}

	// Token: 0x0600294E RID: 10574 RVA: 0x000D6B7E File Offset: 0x000D4D7E
	internal static 208 6(1433 1)
	{
		if (!2528.25(1.41))
		{
			return 1.17;
		}
		return 2528.28(1.17, 1.41, 2528.WindowWidth, 480f);
	}

	// Token: 0x17000267 RID: 615
	// (get) Token: 0x0600294F RID: 10575 RVA: 0x000D6BB0 File Offset: 0x000D4DB0
	internal bool IsTransformDefault
	{
		get
		{
			return this.8 == this.6 && this.9 == this.7 && this.10 == 1f && this.14 == 2527.Default && this.15 == 0f && !this.16 && !this.17;
		}
	}

	// Token: 0x17000268 RID: 616
	// (get) Token: 0x06002950 RID: 10576 RVA: 0x000D6C14 File Offset: 0x000D4E14
	internal bool IsDefault
	{
		get
		{
			return this.IsTransformDefault && this.11 == this.30 && this.12 == 2524.Follow && !this.13 && this.18 == 1f && this.19 == 198.White && this.20 == 0 && this.26.Count == 0;
		}
	}

	// Token: 0x06002951 RID: 10577 RVA: 0x000D6C80 File Offset: 0x000D4E80
	internal void 7()
	{
		this.8 = this.6;
		this.9 = this.7;
		this.10 = 1f;
		this.11 = this.30;
		this.12 = 2524.Follow;
		this.13 = false;
		this.14 = 2527.Default;
		this.15 = 0f;
		this.16 = false;
		this.17 = false;
		this.18 = 1f;
		this.19 = 198.White;
		this.20 = 0;
		List<string> list = new List<string>(this.26.Keys);
		this.26.Clear();
		foreach (2530 <<EMPTY_NAME>> in this.25)
		{
			if (<<EMPTY_NAME>>.18 != null && <<EMPTY_NAME>>.17() != <<EMPTY_NAME>>.5)
			{
				<<EMPTY_NAME>>.18(<<EMPTY_NAME>>.5);
				list.Add(<<EMPTY_NAME>>.1);
			}
		}
		foreach (string obj in list)
		{
			Action<string> action = this.27;
			if (action != null)
			{
				action(obj);
			}
		}
	}

	// Token: 0x06002952 RID: 10578 RVA: 0x000D6DEC File Offset: 0x000D4FEC
	internal 2530 8(2530 1)
	{
		this.25.RemoveAll((2530 1) => string.Equals(1.1, 2.1, StringComparison.OrdinalIgnoreCase));
		this.25.Add(2);
		return 2;
	}

	// Token: 0x06002953 RID: 10579 RVA: 0x000D6E38 File Offset: 0x000D5038
	internal 2530 9(string 1)
	{
		return this.25.Find((2530 1) => string.Equals(1.1, 2, StringComparison.OrdinalIgnoreCase));
	}

	// Token: 0x06002954 RID: 10580 RVA: 0x000D6E6C File Offset: 0x000D506C
	internal string 10(string 1)
	{
		2530 2 = this.9(1);
		if (2 != null && 2.17 != null)
		{
			return 2.17();
		}
		string result;
		if (!this.26.TryGetValue(1, out result))
		{
			return ((2 != null) ? 2.5 : null) ?? string.Empty;
		}
		if (2 == null)
		{
			return result;
		}
		return 2.7(result);
	}

	// Token: 0x06002955 RID: 10581 RVA: 0x000D6ECA File Offset: 0x000D50CA
	internal bool 11(string 1)
	{
		return this.10(1) == "1";
	}

	// Token: 0x06002956 RID: 10582 RVA: 0x000D6EE0 File Offset: 0x000D50E0
	internal float 12(string 1)
	{
		float result;
		if (!float.TryParse(this.10(1), NumberStyles.Float, CultureInfo.InvariantCulture, out result))
		{
			return 0f;
		}
		return result;
	}

	// Token: 0x06002957 RID: 10583 RVA: 0x000D6F0E File Offset: 0x000D510E
	internal int 13(string 1)
	{
		return (int)Math.Round((double)this.12(1));
	}

	// Token: 0x06002958 RID: 10584 RVA: 0x000D6F20 File Offset: 0x000D5120
	internal 198 14(string 1)
	{
		198 result;
		if (!2530.10(this.10(1), out result))
		{
			return 198.White;
		}
		return result;
	}

	// Token: 0x06002959 RID: 10585 RVA: 0x000D6F44 File Offset: 0x000D5144
	internal void 15(string 1, string 2)
	{
		2530 3 = this.9(1);
		string text = (3 != null) ? 3.7(2) : 2;
		if (this.10(1) == text)
		{
			return;
		}
		if (3 != null && 3.18 != null)
		{
			3.18(text);
		}
		else if (3 != null && text == 3.5)
		{
			this.26.Remove(1);
		}
		else
		{
			this.26[1] = text;
		}
		Action<string> action = this.27;
		if (action == null)
		{
			return;
		}
		action(1);
	}

	// Token: 0x0600295A RID: 10586 RVA: 0x000D6FD0 File Offset: 0x000D51D0
	internal Dictionary<string, string> 16()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>(this.26, StringComparer.OrdinalIgnoreCase);
		foreach (2530 <<EMPTY_NAME>> in this.25)
		{
			if (<<EMPTY_NAME>>.17 != null)
			{
				dictionary[<<EMPTY_NAME>>.1] = <<EMPTY_NAME>>.17();
			}
		}
		return dictionary;
	}

	// Token: 0x0600295B RID: 10587 RVA: 0x000D7050 File Offset: 0x000D5250
	internal void 17(Dictionary<string, string> 1)
	{
		List<string> list = new List<string>(this.26.Keys);
		foreach (2530 2 in this.25)
		{
			if (!list.Contains(2.1))
			{
				list.Add(2.1);
			}
		}
		foreach (string item in 1.Keys)
		{
			if (!list.Contains(item))
			{
				list.Add(item);
			}
		}
		foreach (string key in list)
		{
			2530 3 = this.9(key);
			string text2;
			string text = 1.TryGetValue(key, out text2) ? text2 : ((3 != null) ? 3.5 : null);
			if (text == null)
			{
				this.26.Remove(key);
			}
			else
			{
				this.15(key, text);
			}
		}
	}

	// Token: 0x17000269 RID: 617
	// (get) Token: 0x0600295C RID: 10588 RVA: 0x000D7198 File Offset: 0x000D5398
	internal static 2528 Current
	{
		get
		{
			return 2528.1;
		}
	}

	// Token: 0x0600295D RID: 10589 RVA: 0x000D719F File Offset: 0x000D539F
	internal static 2528 18()
	{
		return new 2528(string.Empty, string.Empty, 2509.TopLeft, 208.Zero, true, null)
		{
			31 = true
		};
	}

	// Token: 0x0600295E RID: 10590 RVA: 0x000D71BF File Offset: 0x000D53BF
	internal void 19(1371 1)
	{
		if (this.31 || this.32)
		{
			this.22(1);
			return;
		}
		if (1 != null)
		{
			1.18 = this;
		}
	}

	// Token: 0x0600295F RID: 10591 RVA: 0x000D71E3 File Offset: 0x000D53E3
	internal static 2528.2529 20(2528 1)
	{
		2528 2 = 2528.1;
		if (1 != null)
		{
			2528.1 = 1;
		}
		return new 2528.2529(2);
	}

	// Token: 0x06002960 RID: 10592 RVA: 0x000D71F8 File Offset: 0x000D53F8
	internal 2528.2529 21()
	{
		2528 <<EMPTY_NAME>> = 2528.1;
		2528.1 = this;
		return new 2528.2529(<<EMPTY_NAME>>);
	}

	// Token: 0x06002961 RID: 10593 RVA: 0x000D720A File Offset: 0x000D540A
	internal void 22(1371 1)
	{
		if (1 == null)
		{
			return;
		}
		1.18 = this;
		if (!this.28.Contains(1))
		{
			this.28.Add(1);
		}
	}

	// Token: 0x06002962 RID: 10594 RVA: 0x000D7231 File Offset: 0x000D5431
	internal void 23(1371 1)
	{
		if (1 == null)
		{
			return;
		}
		if (1.18 == this)
		{
			1.18 = null;
		}
		this.28.Remove(1);
	}

	// Token: 0x06002963 RID: 10595 RVA: 0x000D7254 File Offset: 0x000D5454
	internal static bool 24(1376 1)
	{
		return 1 >= (1376)6 && 1 <= (1376)14;
	}

	// Token: 0x06002964 RID: 10596 RVA: 0x000D7264 File Offset: 0x000D5464
	internal static bool 25(1376 1)
	{
		return 2528.24(1) || (1 >= (1376)16 && 1 <= (1376)19);
	}

	// Token: 0x1700026A RID: 618
	// (get) Token: 0x06002965 RID: 10597 RVA: 0x000D727F File Offset: 0x000D547F
	private static float PixelScale
	{
		get
		{
			return 1662.70.3();
		}
	}

	// Token: 0x1700026B RID: 619
	// (get) Token: 0x06002966 RID: 10598 RVA: 0x000D728B File Offset: 0x000D548B
	internal static float WindowWidth
	{
		get
		{
			return (float)1662.70.1 / 1662.70.3();
		}
	}

	// Token: 0x06002967 RID: 10599 RVA: 0x000D72A4 File Offset: 0x000D54A4
	internal static 208 26(2509 1, float 2, float 3)
	{
		int num = 1 - 2509.TopLeft;
		return new 208((float)(num % 3) * 2 / 2f, (float)(num / 3) * 3 / 2f);
	}

	// Token: 0x06002968 RID: 10600 RVA: 0x000D72D4 File Offset: 0x000D54D4
	internal static 208 27(int 1, 1058 2)
	{
		int num = 1 - 6;
		return new 208(2.X + (float)(num % 3) * 2.Width / 2f, 2.Y + (float)(num / 3) * 2.Height / 2f);
	}

	// Token: 0x06002969 RID: 10601 RVA: 0x000D731C File Offset: 0x000D551C
	internal static 208 28(208 1, 1376 2, float 3, float 4)
	{
		if (2 < (1376)16)
		{
			int num = 2 - (1376)6;
			int num2 = num % 3;
			int num3 = num / 3;
			float num4 = (num2 == 0) ? 1.X : ((num2 == 1) ? (3 / 2f + 1.X) : (3 - 1.X));
			float num5 = (num3 == 0) ? 1.Y : ((num3 == 1) ? (4 / 2f + 1.Y) : (4 - 1.Y));
			return new 208(num4, num5);
		}
		208 5 = 1 / 2528.PixelScale;
		switch (2)
		{
		case (1376)17:
			return new 208(3 - 5.X, 5.Y);
		case (1376)18:
			return new 208(3 - 5.X, 4 - 5.Y);
		case (1376)19:
			return new 208(3 / 2f + 5.X, 4 - 5.Y);
		default:
			return 5;
		}
	}

	// Token: 0x0600296A RID: 10602 RVA: 0x000D73FC File Offset: 0x000D55FC
	internal static 208 29(208 1, 1376 2, float 3, float 4)
	{
		if (2 >= (1376)16)
		{
			208 5;
			switch (2)
			{
			case (1376)17:
				5 = new 208(3 - 1.X, 1.Y);
				break;
			case (1376)18:
				5 = new 208(3 - 1.X, 4 - 1.Y);
				break;
			case (1376)19:
				5 = new 208(1.X - 3 / 2f, 4 - 1.Y);
				break;
			default:
				5 = 1;
				break;
			}
			return 5 * 2528.PixelScale;
		}
		int num = 2 - (1376)6;
		int num2 = num % 3;
		int num3 = num / 3;
		float num4 = (num2 == 0) ? 1.X : ((num2 == 1) ? (1.X - 3 / 2f) : (3 - 1.X));
		float num5 = (num3 == 0) ? 1.Y : ((num3 == 1) ? (1.Y - 4 / 2f) : (4 - 1.Y));
		return new 208(num4, num5);
	}

	// Token: 0x0600296B RID: 10603 RVA: 0x000D74E8 File Offset: 0x000D56E8
	private static 208 30(208 1, 1376 2)
	{
		if (!2528.25(2))
		{
			return 1;
		}
		float windowWidth = 2528.WindowWidth;
		2509 3 = (2509)(2528.24(2) ? 2 : ((1376)6));
		return 2528.28(1, 2, windowWidth, 480f) - 2528.26(3, windowWidth, 480f);
	}

	// Token: 0x1700026C RID: 620
	// (get) Token: 0x0600296C RID: 10604 RVA: 0x000D7530 File Offset: 0x000D5730
	internal 1058 NaturalBounds
	{
		get
		{
			this.31();
			return this.34;
		}
	}

	// Token: 0x0600296D RID: 10605 RVA: 0x000D7540 File Offset: 0x000D5740
	private void 31()
	{
		if (this.33 == 1662.115)
		{
			return;
		}
		this.33 = 1662.115;
		bool flag = false;
		float num = 0f;
		float num2 = 0f;
		float num3 = 0f;
		float num4 = 0f;
		List<1371> list = (this.29 != null) ? this.29.28 : this.28;
		for (int i = 0; i < list.Count; i++)
		{
			1433 <<EMPTY_NAME>> = list[i] as 1433;
			1058 2;
			if (<<EMPTY_NAME>> != null && (this.29 == null || <<EMPTY_NAME>>.5) && 2528.33(<<EMPTY_NAME>>, out 2))
			{
				num = (flag ? Math.Min(num, 2.X) : 2.X);
				num2 = (flag ? Math.Min(num2, 2.Y) : 2.Y);
				num3 = (flag ? Math.Max(num3, 2.X + 2.Width) : (2.X + 2.Width));
				num4 = (flag ? Math.Max(num4, 2.Y + 2.Height) : (2.Y + 2.Height));
				flag = true;
			}
		}
		if (!flag && this.36 != null)
		{
			1058? 3 = this.36();
			if (3 != null)
			{
				this.34 = 3.Value;
				this.35 = true;
				return;
			}
		}
		if (flag)
		{
			this.34 = new 1058(num, num2, Math.Max(num3 - num, 0.01f), Math.Max(num4 - num2, 0.01f));
			this.35 = true;
			return;
		}
		if (!this.35)
		{
			208 4 = this.34(2528.WindowWidth, 480f);
			this.34 = new 1058(4.X - 8f, 4.Y - 8f, 16f, 16f);
		}
	}

	// Token: 0x0600296E RID: 10606 RVA: 0x000D7731 File Offset: 0x000D5931
	internal void 32()
	{
		this.33 = -1L;
	}

	// Token: 0x0600296F RID: 10607 RVA: 0x000D773C File Offset: 0x000D593C
	internal static bool 33(1433 1, out 1058 2)
	{
		2 = default(1058);
		if (!2528.25(1.41))
		{
			return false;
		}
		1452 3 = 1 as 1452;
		if (3 != null)
		{
			if (string.IsNullOrEmpty(3.GetText()) && 3.57().A == 0)
			{
				return false;
			}
			if (3.88)
			{
				3.GetTextSize();
			}
		}
		if (1.35 <= 0 || 1.34 <= 0)
		{
			return false;
		}
		float num = Math.Max(1.15, 0f);
		int 4 = (int)1.41;
		if (4 != 17 && 4 != 19 && 1.66)
		{
			num *= 1662.70.9();
		}
		if (1.69 > 0f)
		{
			num /= 1.69;
		}
		float num2 = Math.Abs(1.20.X) * num / 2528.PixelScale;
		float num3 = Math.Abs(1.20.Y) * num / 2528.PixelScale;
		if (num2 <= 0f || num3 <= 0f)
		{
			return false;
		}
		208 5 = 2528.28(1.17, 1.41, 2528.WindowWidth, 480f);
		2 = new 1058(5.X - 1.48.X * num2, 5.Y - 1.48.Y * num3, (float)1.35 * num2, (float)1.34 * num3);
		return true;
	}

	// Token: 0x06002970 RID: 10608 RVA: 0x000D78A2 File Offset: 0x000D5AA2
	internal 208 34(float 1, float 2)
	{
		return 2528.26(this.6, 1, 2) + this.7;
	}

	// Token: 0x06002971 RID: 10609 RVA: 0x000D78BC File Offset: 0x000D5ABC
	internal 208 35(float 1, float 2)
	{
		if (this.14 != 2527.Default)
		{
			return 2528.27((int)this.14, this.NaturalBounds);
		}
		return this.34(1, 2);
	}

	// Token: 0x06002972 RID: 10610 RVA: 0x000D78E0 File Offset: 0x000D5AE0
	internal 208 36(float 1, float 2)
	{
		return 2528.26(this.8, 1, 2) + this.9;
	}

	// Token: 0x06002973 RID: 10611 RVA: 0x000D78FC File Offset: 0x000D5AFC
	internal 208 37(208 1)
	{
		1.X *= (this.16 ? (-this.10) : this.10);
		1.Y *= (this.17 ? (-this.10) : this.10);
		if (this.15 != 0f)
		{
			double num = (double)this.15 * 3.141592653589793 / 180.0;
			float num2 = (float)Math.Cos(num);
			float num3 = (float)Math.Sin(num);
			1 = new 208(1.X * num2 - 1.Y * num3, 1.X * num3 + 1.Y * num2);
		}
		return 1;
	}

	// Token: 0x06002974 RID: 10612 RVA: 0x000D79AE File Offset: 0x000D5BAE
	internal 208 38(208 1, float 2, float 3)
	{
		return this.36(2, 3) + this.37(1 - this.35(2, 3));
	}

	// Token: 0x06002975 RID: 10613 RVA: 0x000D79D1 File Offset: 0x000D5BD1
	internal 208 39(208 1, 1376 2, float 3, float 4)
	{
		if (!2528.25(2) || this.IsTransformDefault)
		{
			return 1;
		}
		return 2528.29(this.38(2528.28(1, 2, 3, 4), 3, 4), 2, 3, 4);
	}

	// Token: 0x06002976 RID: 10614 RVA: 0x000D7A04 File Offset: 0x000D5C04
	internal 208[] 40()
	{
		float windowWidth = 2528.WindowWidth;
		1058 naturalBounds = this.NaturalBounds;
		return new 208[]
		{
			this.38(new 208(naturalBounds.X, naturalBounds.Y), windowWidth, 480f),
			this.38(new 208(naturalBounds.X + naturalBounds.Width, naturalBounds.Y), windowWidth, 480f),
			this.38(new 208(naturalBounds.X + naturalBounds.Width, naturalBounds.Y + naturalBounds.Height), windowWidth, 480f),
			this.38(new 208(naturalBounds.X, naturalBounds.Y + naturalBounds.Height), windowWidth, 480f)
		};
	}

	// Token: 0x06002977 RID: 10615 RVA: 0x000D7AD0 File Offset: 0x000D5CD0
	internal 1058 41()
	{
		208[] array = this.40();
		float num = array[0].X;
		float num2 = array[0].Y;
		float num3 = array[0].X;
		float num4 = array[0].Y;
		for (int i = 1; i < 4; i++)
		{
			num = Math.Min(num, array[i].X);
			num2 = Math.Min(num2, array[i].Y);
			num3 = Math.Max(num3, array[i].X);
			num4 = Math.Max(num4, array[i].Y);
		}
		return new 1058(num, num2, num3 - num, num4 - num2);
	}

	// Token: 0x06002978 RID: 10616 RVA: 0x000D7B8C File Offset: 0x000D5D8C
	internal void 42(2527 1)
	{
		if (1 == this.14)
		{
			return;
		}
		float windowWidth = 2528.WindowWidth;
		208 2 = (1 == 2527.Default) ? this.34(windowWidth, 480f) : 2528.27((int)1, this.NaturalBounds);
		208 3 = this.38(2, windowWidth, 480f);
		this.14 = 1;
		this.9 = 3 - 2528.26(this.8, windowWidth, 480f);
	}

	// Token: 0x06002979 RID: 10617 RVA: 0x000D7BFC File Offset: 0x000D5DFC
	internal void 43(2509 1)
	{
		float windowWidth = 2528.WindowWidth;
		208 2 = this.36(windowWidth, 480f);
		this.8 = 1;
		this.9 = 2 - 2528.26(1, windowWidth, 480f);
	}

	// Token: 0x0600297A RID: 10618 RVA: 0x000D7C3B File Offset: 0x000D5E3B
	internal static float 44(float 1)
	{
		1 %= 360f;
		if (1 <= -180f)
		{
			1 += 360f;
		}
		else if (1 > 180f)
		{
			1 -= 360f;
		}
		return (float)Math.Round((double)1, 2);
	}

	// Token: 0x04001DF6 RID: 7670
	[ThreadStatic]
	private static 2528 1;

	// Token: 0x04001DF7 RID: 7671
	internal static bool 2;

	// Token: 0x04001DF8 RID: 7672
	internal readonly string 3;

	// Token: 0x04001DF9 RID: 7673
	internal readonly string 4;

	// Token: 0x04001DFA RID: 7674
	internal string 5;

	// Token: 0x04001DFB RID: 7675
	internal 2509 6;

	// Token: 0x04001DFC RID: 7676
	internal 208 7;

	// Token: 0x04001DFD RID: 7677
	internal 2509 8;

	// Token: 0x04001DFE RID: 7678
	internal 208 9;

	// Token: 0x04001DFF RID: 7679
	internal float 10 = 1f;

	// Token: 0x04001E00 RID: 7680
	internal bool 11 = true;

	// Token: 0x04001E01 RID: 7681
	internal 2524 12;

	// Token: 0x04001E02 RID: 7682
	internal bool 13;

	// Token: 0x04001E03 RID: 7683
	internal 2527 14;

	// Token: 0x04001E04 RID: 7684
	internal float 15;

	// Token: 0x04001E05 RID: 7685
	internal bool 16;

	// Token: 0x04001E06 RID: 7686
	internal bool 17;

	// Token: 0x04001E07 RID: 7687
	internal float 18 = 1f;

	// Token: 0x04001E08 RID: 7688
	internal 198 19 = 198.White;

	// Token: 0x04001E09 RID: 7689
	internal int 20;

	// Token: 0x04001E0A RID: 7690
	internal bool 21;

	// Token: 0x04001E0B RID: 7691
	internal bool 22;

	// Token: 0x04001E0C RID: 7692
	internal static float 23 = 1f;

	// Token: 0x04001E0D RID: 7693
	internal static float 24 = 1f;

	// Token: 0x04001E0E RID: 7694
	internal readonly List<2530> 25 = new List<2530>();

	// Token: 0x04001E0F RID: 7695
	internal readonly Dictionary<string, string> 26 = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

	// Token: 0x04001E10 RID: 7696
	internal Action<string> 27;

	// Token: 0x04001E11 RID: 7697
	internal readonly List<1371> 28 = new List<1371>();

	// Token: 0x04001E12 RID: 7698
	internal 1436 29;

	// Token: 0x04001E13 RID: 7699
	internal readonly bool 30;

	// Token: 0x04001E14 RID: 7700
	private bool 31;

	// Token: 0x04001E15 RID: 7701
	internal bool 32;

	// Token: 0x04001E16 RID: 7702
	private long 33 = -1L;

	// Token: 0x04001E17 RID: 7703
	private 1058 34;

	// Token: 0x04001E18 RID: 7704
	private bool 35;

	// Token: 0x04001E19 RID: 7705
	internal Func<1058?> 36;

	// Token: 0x02000542 RID: 1346
	[276]
	internal readonly struct 2529 : IDisposable
	{
		// Token: 0x0600297C RID: 10620 RVA: 0x000D7C89 File Offset: 0x000D5E89
		internal 2529(2528 1)
		{
			this.1 = 1;
		}

		// Token: 0x0600297D RID: 10621 RVA: 0x000D7C92 File Offset: 0x000D5E92
		public void Dispose()
		{
			2528.1 = this.1;
		}

		// Token: 0x04001E1A RID: 7706
		private readonly 2528 1;
	}
}
