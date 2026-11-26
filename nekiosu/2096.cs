using System;

// Token: 0x02000742 RID: 1858
[276]
public static class 2096
{
	// Token: 0x060036BB RID: 14011 RVA: 0x00156C8C File Offset: 0x00154E8C
	public static double 1(2092 1, 2096.2097 2)
	{
		if (1 == null || !1.4)
		{
			return 0.0;
		}
		bool flag = false;
		if (2099.1(2.1))
		{
			2100 3 = 1.29;
			if (3 != 2100.NoNerfs)
			{
				if (3 == 2100.Akatsuki)
				{
					if (1.30 != null)
					{
						return 2078.23(1.30, 2.1, 2.2, 2.3, 2.4, 2.5, 2.6, 2.8);
					}
					return 0.0;
				}
			}
			else
			{
				2.1 &= ~2023.Relax;
				flag = true;
			}
		}
		2096.2098 4 = new 2096.2098
		{
			1 = 1,
			2 = 2,
			3 = flag
		};
		4.4 = 4.1(2023.ScoreV2);
		int totalHits = 4.TotalHits;
		4.5 = ((totalHits > 0) ? 2096.19((double)(2.2 * 6 + 2.3 * 2 + 2.4) / (double)(totalHits * 6), 0.0, 1.0) : 0.0);
		4.6 = (int)2096.19((double)2.6, 0.0, (double)1.17);
		4.8 = (79.5 - 1.25) / 6.0;
		double 5 = 2096.8(4);
		if (!4.4 && 2.7 > 0L)
		{
			4.7 = 2096.9(4);
		}
		else
		{
			4.7 = 5;
		}
		4.7 = Math.Max((double)2.5, 4.7);
		4.7 = Math.Min((double)totalHits, 4.7);
		4.7 = Math.Max(0.0, 4.7);
		if (4.7 > 0.0)
		{
			4.10 = 2096.14(4, 1.15);
			4.11 = 2096.14(4, 1.16);
		}
		double num = 1.12;
		if (4.1(2023.NoFail))
		{
			num *= Math.Max(0.9, 1.0 - 0.02 * 4.7);
		}
		if (4.1(2023.SpunOut) && totalHits > 0)
		{
			num *= 1.0 - 1897.11((double)1.21 / (double)totalHits, 0.85);
		}
		if (4.1(2023.Relax))
		{
			double num2 = 0.75 * Math.Max(0.0, (4.8 > 0.0) ? (1.0 - 4.8 / 13.33) : 1.0);
			double num3 = Math.Max(0.0, (4.8 > 0.0) ? (1.0 - 1897.12(4.8 / 13.33, 5)) : 1.0);
			4.7 = Math.Min(4.7 + (double)2.3 * num2 + (double)2.4 * num3, (double)totalHits);
		}
		4.9 = 2096.15(4);
		double num4 = 2096.3(4);
		double num5 = 2096.4(4);
		double num6 = 2096.5(4);
		double num7 = 2096.7(4);
		double num8 = 2096.6(4);
		double num9 = 2096.2(num7, num8);
		double num10 = 1897.5(1.1, new double[]
		{
			num4,
			num5,
			num6,
			num9
		}) * num;
		if (!double.IsNaN(num10) && !double.IsInfinity(num10))
		{
			return num10;
		}
		return 0.0;
	}

	// Token: 0x060036BC RID: 14012 RVA: 0x0015706C File Offset: 0x0015526C
	private static double 2(double 1, double 2)
	{
		if (1 <= 0.0)
		{
			return 2;
		}
		if (2 <= 0.0)
		{
			return 1;
		}
		return 1897.5(1.1, new double[]
		{
			1,
			2 * 2096.19(2 / 1, 0.25, 1.0)
		});
	}

	// Token: 0x060036BD RID: 14013 RVA: 0x001570CC File Offset: 0x001552CC
	private static double 3(2096.2098 1)
	{
		2092 2 = 1.1;
		if (1.1(2023.Relax2))
		{
			return 0.0;
		}
		double num = 2.5;
		if (2.20 > 0 && 2.6 > 0.0)
		{
			double num2 = 2096.19((double)Math.Min(1.TotalImperfectHits, 2.17 - 1.6), 0.0, 2.6);
			double num3 = (1.0 - 2.11) * 1897.12(1.0 - num2 / 2.6, 3) + 2.11;
			num *= num3;
		}
		double num4 = 4.0 * 1897.12(num, 3);
		int totalHits = 1.TotalHits;
		double num5 = 0.95 + 0.35 * Math.Min(1.0, (double)totalHits / 2000.0) + ((totalHits > 2000) ? (Math.Log10((double)totalHits / 2000.0) * 0.5) : 0.0);
		num4 *= num5;
		if (1.7 > 0.0)
		{
			double num6 = Math.Min(1.7 + 1.10, (double)1.TotalImperfectHits);
			num4 *= 2096.18(num6, 2.12);
		}
		return num4 * 1.5;
	}

	// Token: 0x060036BE RID: 14014 RVA: 0x00157240 File Offset: 0x00155440
	private static double 4(2096.2098 1)
	{
		2092 2 = 1.1;
		if (1.1(2023.Relax) || 1.9 == null)
		{
			return 0.0;
		}
		double num = 2090.4(2.7);
		if (1.7 > 0.0)
		{
			double num2 = Math.Min(1.7 + 1.11, (double)1.TotalImperfectHits);
			num *= 2096.18(num2, 2.13);
		}
		num *= 2096.17(1);
		double num3 = 1897.15(20.0 * 1897.11(4.0 / 2.7, 0.35) / 1.9.Value);
		return num * 1897.12(num3, 2);
	}

	// Token: 0x060036BF RID: 14015 RVA: 0x0015730C File Offset: 0x0015550C
	private static double 5(2096.2098 1)
	{
		2092 2 = 1.1;
		if (1.1(2023.Relax))
		{
			return 0.0;
		}
		int num = 2.19;
		if (1.4)
		{
			num += 2.20;
		}
		double num2 = 0.0;
		if (num > 0)
		{
			num2 = (double)((1.2.2 - Math.Max(1.TotalHits - num, 0)) * 6 + 1.2.3 * 2 + 1.2.4) / (double)(num * 6);
		}
		if (num2 < 0.0)
		{
			num2 = 0.0;
		}
		return 1897.11(1.52163, 1.8) * 1897.12(num2, 24) * 2.83 * ((num < 1000) ? 1897.11((double)num / 1000.0, 0.3) : 1897.11((double)num / 1000.0, 0.1));
	}

	// Token: 0x060036C0 RID: 14016 RVA: 0x00157418 File Offset: 0x00155618
	private static double 6(2096.2098 1)
	{
		2092 2 = 1.1;
		if (!1.1(2023.Flashlight) || 2.9 == null)
		{
			return 0.0;
		}
		double num = 25.0 * 1897.12(2.9.Value, 2);
		int totalHits = 1.TotalHits;
		if (1.7 > 0.0 && totalHits > 0)
		{
			num *= 0.97 * 1897.11(1.0 - 1897.11(1.7 / (double)totalHits, 0.775), 1897.11(1.7, 0.875));
		}
		double num2 = (2.17 <= 0) ? 1.0 : Math.Min(1897.11((double)1.6, 0.8) / 1897.11((double)2.17, 0.8), 1.0);
		num *= num2;
		return num * (0.5 + 1.5 / 2.0);
	}

	// Token: 0x060036C1 RID: 14017 RVA: 0x00157540 File Offset: 0x00155740
	private static double 7(2096.2098 1)
	{
		double num = 2090.4(1.1.10);
		if (1.7 > 0.0)
		{
			num *= 2096.18(1.7 + 1.10, 1.1.14);
		}
		return num * 1897.12(1.5, 3);
	}

	// Token: 0x060036C2 RID: 14018 RVA: 0x001575A0 File Offset: 0x001557A0
	private static double 8(2096.2098 1)
	{
		2092 2 = 1.1;
		int 3 = 1.2.5;
		if (2.20 <= 0)
		{
			return (double)3;
		}
		double num = (double)3;
		double num2 = 0.04 + 0.06 * 1897.12(Math.Min(2.15, 1.0), 2);
		double num3 = (double)2.17 - Math.Min(4.0 + num2 * (double)2.20, (double)2.20);
		if ((double)1.6 < num3)
		{
			num = num3 / Math.Max(1.0, (double)1.6);
		}
		num = Math.Min(num, (double)1.TotalImperfectHits);
		int num4 = Math.Min(2.20, (2.17 - 1.6) / 2);
		if (num - (double)3 > (double)num4)
		{
			num = (double)(3 + num4);
		}
		return num;
	}

	// Token: 0x060036C3 RID: 14019 RVA: 0x00157688 File Offset: 0x00155888
	private static double 9(2096.2098 1)
	{
		2092 2 = 1.1;
		if (2.17 == 0 || 1.2.7 <= 0L)
		{
			return 0.0;
		}
		double 3 = 2.23 * 2096.13(1);
		double num = 2096.11(2);
		double num2 = 2096.12(1);
		double num3 = 2096.10(1, (double)1.2.6, num, 3);
		double num4 = (double)1.2.7 - num3;
		if (num4 <= 0.0)
		{
			return num2;
		}
		double num5 = (double)(2.17 - 1.2.6);
		return Math.Min(Math.Max(2096.10(1, num5, num, 3) / num4, 1.0), num2);
	}

	// Token: 0x060036C4 RID: 14020 RVA: 0x00157748 File Offset: 0x00155948
	private static double 10(2096.2098 1, double 2, double 3, double 4)
	{
		double num = 2 / 3 - 1.0;
		double num2 = ((3 > 0.0) ? ((2.0 * (3 - 1.0) + (num - 1.0) * 3) * num / 2.0) : 0.0) * (1.5 * 300.0 / 25.0 * 4);
		double num3 = (double)(1.TotalHits - 1.2.5) * 2 / (double)1.1.17;
		double num4 = (300.0 + 1.1.22) * 1.5 * num3;
		return num2 + num4;
	}

	// Token: 0x060036C5 RID: 14021 RVA: 0x0015780C File Offset: 0x00155A0C
	private static double 11(2092 1)
	{
		double num = 1.24;
		num /= 12.0 * 1.23;
		return ((double)1.17 - 2.0) * (double)1.17 / Math.Max((double)1.17 + 2.0 * (num - 1.0), 1.0);
	}

	// Token: 0x060036C6 RID: 14022 RVA: 0x00157878 File Offset: 0x00155A78
	private static double 12(2096.2098 1)
	{
		2092 2 = 1.1;
		int 3 = 1.2.5;
		if (2.20 <= 0)
		{
			return (double)3;
		}
		double num = 0.0;
		double num2 = 0.04 + 0.06 * 1897.12(Math.Min(2.15, 1.0), 2);
		double num3 = (double)2.17 - Math.Min(4.0 + num2 * (double)2.20, (double)2.20);
		if ((double)1.2.6 < num3)
		{
			num = 1897.11(num3 / Math.Max(1.0, (double)1.2.6), 2.5);
		}
		num = Math.Min(num, (double)1.TotalImperfectHits);
		int num4 = Math.Min(2.20, (2.17 - 1.2.6) / 2);
		if (num - (double)3 > (double)num4)
		{
			num = (double)(3 + num4);
		}
		return num;
	}

	// Token: 0x060036C7 RID: 14023 RVA: 0x00157984 File Offset: 0x00155B84
	private static double 13(2096.2098 1)
	{
		if (1.1(2023.Relax2) || ((1.3 || 1.1(2023.Relax)) && !1.2.9))
		{
			return 0.0;
		}
		double num = 1.0;
		if (1.1(2023.NoFail))
		{
			num *= (1.4 ? 1.0 : 0.5);
		}
		if (1.1(2023.Easy))
		{
			num *= 0.5;
		}
		if (1.1(2023.HalfTime))
		{
			num *= 0.3;
		}
		if (1.1(2023.Hidden))
		{
			num *= 1.06;
		}
		if (1.1(2023.HardRock))
		{
			num *= (1.4 ? 1.1 : 1.06);
		}
		if (1.1(2023.DoubleTime))
		{
			num *= (1.4 ? 1.2 : 1.12);
		}
		if (1.1(2023.Flashlight))
		{
			num *= 1.12;
		}
		if (1.1(2023.SpunOut))
		{
			num *= 0.9;
		}
		return num;
	}

	// Token: 0x060036C8 RID: 14024 RVA: 0x00157AC4 File Offset: 0x00155CC4
	private static double 14(2096.2098 1, double 2)
	{
		int num = 1.2.3 + 1.2.4;
		if (num == 0 || 1.1.17 <= 0)
		{
			return 0.0;
		}
		double num2 = 1.0 - (double)1.6 / (double)1.1.17;
		double num3 = Math.Min((double)num, 1.7 * 2);
		double num4 = ((double)num - num3 + 4.5) / ((double)num + 4.0);
		num3 *= 1897.8(1.7, 1.0, 2.0);
		return num3 * num4 * 1897.3(num2, 0.33, 15.0, 1.0);
	}

	// Token: 0x060036C9 RID: 14025 RVA: 0x00157B94 File Offset: 0x00155D94
	private static double? 15(2096.2098 1)
	{
		if (1.TotalSuccessfulHits == 0)
		{
			return null;
		}
		double num = 1.1.8;
		num += ((double)1.TotalHits - 1.1.8) * 0.1;
		double num2 = Math.Min((double)1.2.5, num);
		double num3 = Math.Min((double)1.2.4, num - num2);
		double num4 = Math.Min((double)1.2.3, num - num2 - num3);
		double num5 = Math.Max(0.0, num - num2 - num3 - num4);
		return 2096.16(1, num5, num4, num3);
	}

	// Token: 0x060036CA RID: 14026 RVA: 0x00157C40 File Offset: 0x00155E40
	private static double? 16(2096.2098 1, double 2, double 3, double 4)
	{
		if (2 + 3 + 4 <= 0.0)
		{
			return null;
		}
		double 5 = 1.1.25;
		double 6 = 1.1.26;
		double 7 = 1.1.27;
		double num = Math.Max(1.0, 2 + 3);
		double num2 = 2 / num;
		double num3 = Math.Min(num2, (num * num2 + 2.7059472155252142) / (num + 5.4118944310504284) - 2.32634787404 / (num + 5.4118944310504284) * Math.Sqrt(num * num2 * (1.0 - num2) + 1.3529736077626071));
		double num4;
		if (num3 > 0.01)
		{
			num4 = 5 / (1.414213562373095 * 1897.16(num3));
			double num5 = Math.Sqrt(0.6366197723675814) * 6 * Math.Exp(-0.5 * 1897.12(6 / num4, 2)) / (num4 * 1897.15(6 / (1.414213562373095 * num4)));
			num4 *= Math.Sqrt(1.0 - num5);
		}
		else
		{
			num4 = 6 / Math.Sqrt(3.0);
		}
		double num6 = (7 * 7 + 6 * 7 + 6 * 6) / 3.0;
		return new double?(Math.Sqrt(((2 + 3) * 1897.12(num4, 2) + 4 * num6) / (2 + 3 + 4)));
	}

	// Token: 0x060036CB RID: 14027 RVA: 0x00157DC4 File Offset: 0x00155FC4
	private static double 17(2096.2098 1)
	{
		if (1.9 == null)
		{
			return 0.0;
		}
		double num = 2090.4(1.1.7);
		double num2 = 100.0 + 220.0 * 1897.11(22.0 / 1.9.Value, 6.5);
		if (num <= num2)
		{
			return 1.0;
		}
		double num3 = 50.0 * (Math.Log((num - num2) / 50.0 + 1.0) + num2 / 50.0);
		double num4 = 1.0 - 1897.10(1.9.Value, 22.0, 27.0);
		num3 += (num - num3) * num4;
		return num3 / num;
	}

	// Token: 0x060036CC RID: 14028 RVA: 0x00157EAA File Offset: 0x001560AA
	private static double 18(double 1, double 2)
	{
		return 0.93 / (1 / (4.0 * Math.Log(Math.Max(1.0, 2))) + 1.0);
	}

	// Token: 0x060036CD RID: 14029 RVA: 0x00157EE0 File Offset: 0x001560E0
	private static double 19(double 1, double 2, double 3)
	{
		return Math.Max(2, Math.Min(3, 1));
	}

	// Token: 0x040028C3 RID: 10435
	private const double 1 = 1.12;

	// Token: 0x040028C4 RID: 10436
	private const double 2 = 1.1;

	// Token: 0x040028C5 RID: 10437
	private const double 3 = 1.414213562373095;

	// Token: 0x02000743 RID: 1859
	[276]
	public struct 2097
	{
		// Token: 0x040028C6 RID: 10438
		public 2023 1;

		// Token: 0x040028C7 RID: 10439
		public int 2;

		// Token: 0x040028C8 RID: 10440
		public int 3;

		// Token: 0x040028C9 RID: 10441
		public int 4;

		// Token: 0x040028CA RID: 10442
		public int 5;

		// Token: 0x040028CB RID: 10443
		public int 6;

		// Token: 0x040028CC RID: 10444
		public long 7;

		// Token: 0x040028CD RID: 10445
		public bool 8;

		// Token: 0x040028CE RID: 10446
		public bool 9;
	}

	// Token: 0x02000744 RID: 1860
	[276]
	private sealed class 2098
	{
		// Token: 0x17000292 RID: 658
		// (get) Token: 0x060036CE RID: 14030 RVA: 0x00157EEF File Offset: 0x001560EF
		public int TotalHits
		{
			get
			{
				return this.2.2 + this.2.3 + this.2.4 + this.2.5;
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x060036CF RID: 14031 RVA: 0x00157F20 File Offset: 0x00156120
		public int TotalSuccessfulHits
		{
			get
			{
				return this.2.2 + this.2.3 + this.2.4;
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x060036D0 RID: 14032 RVA: 0x00157F45 File Offset: 0x00156145
		public int TotalImperfectHits
		{
			get
			{
				return this.2.3 + this.2.4 + this.2.5;
			}
		}

		// Token: 0x060036D1 RID: 14033 RVA: 0x00157F6A File Offset: 0x0015616A
		public bool 1(2023 1)
		{
			return (this.2.1 & 1) > 2023.None;
		}

		// Token: 0x040028CF RID: 10447
		public 2092 1;

		// Token: 0x040028D0 RID: 10448
		public 2096.2097 2;

		// Token: 0x040028D1 RID: 10449
		public bool 3;

		// Token: 0x040028D2 RID: 10450
		public bool 4;

		// Token: 0x040028D3 RID: 10451
		public double 5;

		// Token: 0x040028D4 RID: 10452
		public int 6;

		// Token: 0x040028D5 RID: 10453
		public double 7;

		// Token: 0x040028D6 RID: 10454
		public double 8;

		// Token: 0x040028D7 RID: 10455
		public double? 9;

		// Token: 0x040028D8 RID: 10456
		public double 10;

		// Token: 0x040028D9 RID: 10457
		public double 11;
	}
}
