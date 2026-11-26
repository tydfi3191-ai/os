using System;
using System.Collections.Generic;

// Token: 0x0200082F RID: 2095
public sealed class 1925
{
	// Token: 0x06003CBD RID: 15549 RVA: 0x00180BBB File Offset: 0x0017EDBB
	public 1925(1932? 1, 1930 2, 1938 3)
	{
		this.5 = 1;
		this.6 = 2;
		this.7 = 3;
	}

	// Token: 0x170002B4 RID: 692
	// (get) Token: 0x06003CBE RID: 15550 RVA: 0x00180BD8 File Offset: 0x0017EDD8
	public bool IsEmpty
	{
		get
		{
			return this.5 == null && this.6 == 1930.None && this.7 == null;
		}
	}

	// Token: 0x170002B5 RID: 693
	// (get) Token: 0x06003CBF RID: 15551 RVA: 0x00180BFC File Offset: 0x0017EDFC
	public bool FlipsHorizontally
	{
		get
		{
			1932? <<EMPTY_NAME>> = this.5;
			1932 2 = 1932.Horizontal;
			return (<<EMPTY_NAME>>.GetValueOrDefault() == 2 & <<EMPTY_NAME>> != null) || this.5.GetValueOrDefault() == 1932.Both;
		}
	}

	// Token: 0x170002B6 RID: 694
	// (get) Token: 0x06003CC0 RID: 15552 RVA: 0x00180C36 File Offset: 0x0017EE36
	public bool FlipsVertically
	{
		get
		{
			return this.5.GetValueOrDefault() == 1932.Vertical || this.5.GetValueOrDefault() == 1932.Both;
		}
	}

	// Token: 0x06003CC1 RID: 15553 RVA: 0x00180C56 File Offset: 0x0017EE56
	public IEnumerable<string> 1()
	{
		if (this.5 != null)
		{
			yield return "MR";
		}
		if (this.7 != null)
		{
			yield return "RD";
		}
		if (this.6 == 1930.Alternate)
		{
			yield return "AL";
		}
		else if (this.6 == 1930.SingleTap)
		{
			yield return "SG";
		}
		yield break;
	}

	// Token: 0x06003CC2 RID: 15554 RVA: 0x00180C66 File Offset: 0x0017EE66
	public IEnumerable<string> 2()
	{
		if (this.5 != null)
		{
			yield return (this.5.Value == 1932.Horizontal) ? "Mirror" : ("Mirror (" + 1925.3(this.5.Value) + ")");
		}
		if (this.7 != null)
		{
			yield return this.7.HasDefaultStrength ? "Random" : ("Random (" + this.7.9.ToString() + "%)");
		}
		if (this.6 == 1930.Alternate)
		{
			yield return "Alternate";
		}
		else if (this.6 == 1930.SingleTap)
		{
			yield return "SingleTap";
		}
		yield break;
	}

	// Token: 0x06003CC3 RID: 15555 RVA: 0x00180C76 File Offset: 0x0017EE76
	public static string 3(1932 1)
	{
		if (1 == 1932.Both)
		{
			return "both axes";
		}
		if (1 != 1932.Vertical)
		{
			return "horizontal";
		}
		return "vertical";
	}

	// Token: 0x170002B7 RID: 695
	// (get) Token: 0x06003CC4 RID: 15556 RVA: 0x00180C91 File Offset: 0x0017EE91
	public static bool MirrorEnabled
	{
		get
		{
			return 1925.2;
		}
	}

	// Token: 0x170002B8 RID: 696
	// (get) Token: 0x06003CC5 RID: 15557 RVA: 0x00180C98 File Offset: 0x0017EE98
	public static 1932 SelectedMirrorAxes
	{
		get
		{
			return 1925.3;
		}
	}

	// Token: 0x170002B9 RID: 697
	// (get) Token: 0x06003CC6 RID: 15558 RVA: 0x00180C9F File Offset: 0x0017EE9F
	public static 1930 SelectedInput
	{
		get
		{
			return 1925.4;
		}
	}

	// Token: 0x170002BA RID: 698
	// (get) Token: 0x06003CC7 RID: 15559 RVA: 0x00180CA6 File Offset: 0x0017EEA6
	public static bool RandomEnabled
	{
		get
		{
			return 1925.8;
		}
	}

	// Token: 0x170002BB RID: 699
	// (get) Token: 0x06003CC8 RID: 15560 RVA: 0x00180CAD File Offset: 0x0017EEAD
	public static int? SelectedRandomSeed
	{
		get
		{
			return 1925.9;
		}
	}

	// Token: 0x170002BC RID: 700
	// (get) Token: 0x06003CC9 RID: 15561 RVA: 0x00180CB4 File Offset: 0x0017EEB4
	public static float SelectedAngleSharpness
	{
		get
		{
			return 1925.10;
		}
	}

	// Token: 0x170002BD RID: 701
	// (get) Token: 0x06003CCA RID: 15562 RVA: 0x00180CBB File Offset: 0x0017EEBB
	public static int SelectedRandomStrength
	{
		get
		{
			return 1925.11;
		}
	}

	// Token: 0x170002BE RID: 702
	// (get) Token: 0x06003CCB RID: 15563 RVA: 0x00180CC2 File Offset: 0x0017EEC2
	internal static 2147 SelectedPlayMode
	{
		get
		{
			1262 <<EMPTY_NAME>> = 1272.5();
			if (<<EMPTY_NAME>> == null)
			{
				return 2486.14();
			}
			return <<EMPTY_NAME>>.38();
		}
	}

	// Token: 0x06003CCC RID: 15564 RVA: 0x00180CD8 File Offset: 0x0017EED8
	public static void 4(bool 1, int? 2, float 3)
	{
		3 = Math.Max(1f, Math.Min(10f, (float)Math.Round((double)3, 1)));
		if (1925.8 == 1)
		{
			int? num = 1925.9;
			int? num2 = 2;
			if ((num.GetValueOrDefault() == num2.GetValueOrDefault() & num != null == (num2 != null)) && 1925.10 == 3)
			{
				return;
			}
		}
		1925.8 = 1;
		1925.9 = 2;
		1925.10 = 3;
		if (1)
		{
			if (1925.SelectedPlayMode == 2147.Osu)
			{
				2019.1 &= ~2023.Target;
			}
			else if (1925.SelectedPlayMode == 2147.Taiko)
			{
				1925.2 = false;
			}
		}
		2019.3();
	}

	// Token: 0x06003CCD RID: 15565 RVA: 0x00180D84 File Offset: 0x0017EF84
	public static int 5()
	{
		int num = 1925.12.Next();
		1925.4(true, new int?(num), 1925.10);
		return num;
	}

	// Token: 0x06003CCE RID: 15566 RVA: 0x00180DAE File Offset: 0x0017EFAE
	public static void 6(int 1)
	{
		1 = Math.Max(1, Math.Min(100, 1));
		if (1925.11 == 1)
		{
			return;
		}
		1925.11 = 1;
		2019.3();
	}

	// Token: 0x06003CCF RID: 15567 RVA: 0x00180DD4 File Offset: 0x0017EFD4
	public static bool 7(2147 1)
	{
		return 1925.8(1) || 1925.9(1) || 1925.10(1);
	}

	// Token: 0x06003CD0 RID: 15568 RVA: 0x00180DEE File Offset: 0x0017EFEE
	public static bool 8(2147 1)
	{
		return 1 == 2147.Osu || 1 == 2147.Taiko || 1 == 2147.CatchTheBeat;
	}

	// Token: 0x06003CD1 RID: 15569 RVA: 0x00180DEE File Offset: 0x0017EFEE
	public static bool 9(2147 1)
	{
		return 1 == 2147.Osu || 1 == 2147.Taiko || 1 == 2147.CatchTheBeat;
	}

	// Token: 0x06003CD2 RID: 15570 RVA: 0x00180DFD File Offset: 0x0017EFFD
	public static bool 10(2147 1)
	{
		return 1 == 2147.Osu;
	}

	// Token: 0x06003CD3 RID: 15571 RVA: 0x00180DFD File Offset: 0x0017EFFD
	public static bool 11(2147 1)
	{
		return 1 == 2147.Osu;
	}

	// Token: 0x06003CD4 RID: 15572 RVA: 0x00180E04 File Offset: 0x0017F004
	public static void 12(bool 1, 1932 2)
	{
		if (1925.2 == 1 && 1925.3 == 2)
		{
			return;
		}
		1925.2 = 1;
		1925.3 = 2;
		if (1)
		{
			if (1925.SelectedPlayMode == 2147.Osu)
			{
				2019.1 &= ~2023.HardRock;
			}
			else if (1925.SelectedPlayMode == 2147.Taiko)
			{
				1925.8 = false;
			}
		}
		2019.3();
	}

	// Token: 0x06003CD5 RID: 15573 RVA: 0x00180E5A File Offset: 0x0017F05A
	public static void 13(1930 1)
	{
		if (1925.4 == 1)
		{
			return;
		}
		1925.4 = 1;
		if (1 != 1930.None)
		{
			2019.1 &= ~(2023.Relax | 2023.Autoplay | 2023.Cinema);
		}
		2019.3();
	}

	// Token: 0x06003CD6 RID: 15574 RVA: 0x00180E83 File Offset: 0x0017F083
	public static void Reset()
	{
		if (1925.2 || 1925.4 != 1930.None || 1925.8)
		{
			1925.2 = false;
			1925.8 = false;
			1925.4 = 1930.None;
			2019.3();
		}
	}

	// Token: 0x06003CD7 RID: 15575 RVA: 0x00180EB1 File Offset: 0x0017F0B1
	public static void 14(2023 1)
	{
		if ((1 & 2023.HardRock) > 2023.None && 1925.SelectedPlayMode == 2147.Osu)
		{
			1925.2 = false;
		}
		if ((1 & (2023.Relax | 2023.Autoplay | 2023.Cinema)) > 2023.None)
		{
			1925.4 = 1930.None;
		}
		if ((1 & 2023.Target) > 2023.None)
		{
			1925.8 = false;
		}
	}

	// Token: 0x06003CD8 RID: 15576 RVA: 0x00180EE8 File Offset: 0x0017F0E8
	public static 1925 15(2147 1, 2023 2)
	{
		if (!1925.7(1))
		{
			return null;
		}
		bool flag = 1 == 2147.Osu;
		1932? 3 = null;
		if (1925.2 && 1925.8(1))
		{
			3 = ((!flag) ? new 1932?(1932.Horizontal) : (((2 & 2023.HardRock) == 2023.None) ? new 1932?(1925.3) : null));
		}
		1930 4 = (1925.10(1) && (2 & (2023.Relax | 2023.Autoplay | 2023.Cinema)) == 2023.None) ? 1925.4 : 1930.None;
		1938 5 = null;
		if (1925.8 && 1925.9(1) && (!flag || (2 & 2023.Target) == 2023.None))
		{
			if (1925.9 == null)
			{
				1925.9 = new int?(1925.12.Next());
			}
			5 = (flag ? new 1938(1925.9.Value, 1925.10, 100) : new 1938(1925.9.Value, 7f, 1925.11));
		}
		if (1 == 2147.Taiko && 5 != null)
		{
			3 = null;
		}
		1925 6 = new 1925(3, 4, 5);
		if (!6.IsEmpty)
		{
			return 6;
		}
		return null;
	}

	// Token: 0x04002CE1 RID: 11489
	private const 2023 1 = 2023.Relax | 2023.Autoplay | 2023.Cinema;

	// Token: 0x04002CE2 RID: 11490
	private static bool 2;

	// Token: 0x04002CE3 RID: 11491
	private static 1932 3 = 1932.Horizontal;

	// Token: 0x04002CE4 RID: 11492
	private static 1930 4 = 1930.None;

	// Token: 0x04002CE5 RID: 11493
	public readonly 1932? 5;

	// Token: 0x04002CE6 RID: 11494
	public readonly 1930 6;

	// Token: 0x04002CE7 RID: 11495
	public readonly 1938 7;

	// Token: 0x04002CE8 RID: 11496
	private static bool 8;

	// Token: 0x04002CE9 RID: 11497
	private static int? 9;

	// Token: 0x04002CEA RID: 11498
	private static float 10 = 7f;

	// Token: 0x04002CEB RID: 11499
	private static int 11 = 100;

	// Token: 0x04002CEC RID: 11500
	private static readonly Random 12 = new Random();
}
