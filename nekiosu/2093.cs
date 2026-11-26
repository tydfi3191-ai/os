using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x0200073E RID: 1854
[276]
public sealed class 2093 : 1920
{
	// Token: 0x06003675 RID: 13941 RVA: 0x00155637 File Offset: 0x00153837
	public 2093(1262 1) : base(1)
	{
	}

	// Token: 0x06003676 RID: 13942 RVA: 0x0000FF75 File Offset: 0x0000E175
	protected override 2147 GetPlayMode()
	{
		return 2147.Osu;
	}

	// Token: 0x06003677 RID: 13943 RVA: 0x00155647 File Offset: 0x00153847
	private static 2023 17()
	{
		return 2023.Easy | 2023.Hidden | 2023.HardRock | 2023.DoubleTime | 2023.HalfTime | 2023.Flashlight;
	}

	// Token: 0x06003678 RID: 13944 RVA: 0x00155650 File Offset: 0x00153850
	public override 1898[] GetModOptions()
	{
		return new 1898[]
		{
			new 1913(2023.HalfTime),
			new 1913(2023.DoubleTime),
			new 1913(2023.Easy),
			new 1913(2023.HardRock),
			new 1913(2023.Flashlight),
			new 1913(2023.Hidden)
		};
	}

	// Token: 0x06003679 RID: 13945 RVA: 0x001556A3 File Offset: 0x001538A3
	public static 2023 18(2023 1)
	{
		return 2093.17() & 1;
	}

	// Token: 0x0600367A RID: 13946 RVA: 0x001556AC File Offset: 0x001538AC
	internal override 2039 CreateHitObjectManager()
	{
		return new 2122(false);
	}

	// Token: 0x0600367B RID: 13947 RVA: 0x001556B4 File Offset: 0x001538B4
	protected override bool RequiresReload(2023 1)
	{
		return ((this.2.22 ^ 1) & (2023.Easy | 2023.HardRock)) > 2023.None;
	}

	// Token: 0x0600367C RID: 13948 RVA: 0x001556D0 File Offset: 0x001538D0
	protected override void ProcessHitObjects()
	{
		foreach (2034 <<EMPTY_NAME>> in this.3)
		{
			2123 2 = <<EMPTY_NAME>> as 2123;
			if (2 != null)
			{
				2.RebuildPathAndTiming(false);
			}
			if (2 != null)
			{
				2.GenerateSliderEvents();
			}
		}
	}

	// Token: 0x0600367D RID: 13949 RVA: 0x00155738 File Offset: 0x00153938
	protected override double Calculate(Dictionary<string, string> 1)
	{
		2092 2 = (2092)base.16();
		this.18 = 2;
		if (this.14)
		{
			this.19(2);
		}
		if (1 != null)
		{
			1.Add("Strain", 2.3.ToString("0.00", 1662.18));
			1.Add("Hit window 300", ((double)this.2.5 / this.4).ToString("0.00", 1662.18));
		}
		return 2.3;
	}

	// Token: 0x0600367E RID: 13950 RVA: 0x001557C0 File Offset: 0x001539C0
	private void 19(2092 1)
	{
		1.29 = this.13;
		if (this.15 != null)
		{
			foreach (KeyValuePair<double, 2092> keyValuePair in this.15)
			{
				keyValuePair.Value.29 = this.13;
			}
		}
		2023 2 = this.2.22;
		if (this.13 != 2100.Akatsuki || !2099.1(2))
		{
			return;
		}
		bool 3 = this.2.47 != null && this.2.47.FlipsHorizontally;
		bool 4 = (2 & 2023.HardRock) > 2023.None;
		2077[] array = 2078.22(this.1.49(this.1.58), 2, this.5, this.4, this.2.RandomLayoutForDifficulty, 3, 4, this.15 != null);
		if (array == null)
		{
			return;
		}
		1.30 = array[array.Length - 1];
		if (this.15 != null)
		{
			foreach (KeyValuePair<double, 2092> keyValuePair2 in this.15)
			{
				keyValuePair2.Value.30 = array[Math.Max(0, Math.Min(array.Length - 1, keyValuePair2.Value.31))];
			}
		}
	}

	// Token: 0x0600367F RID: 13951 RVA: 0x00155940 File Offset: 0x00153B40
	protected override 1890 CreateDifficultyAttributes(1914[] 1)
	{
		if (this.3.Count == 0)
		{
			return new 2092
			{
				1 = this.2.22
			};
		}
		2103 2 = 10.OfType<2103>().Single((2103 1) => 1.12);
		2111 3 = 10.OfType<2111>().Single<2111>();
		2105 4 = 10.OfType<2105>().SingleOrDefault<2105>();
		2106 5 = 10.OfType<2106>().Single<2106>();
		double num = 2.DifficultyValue();
		double num2 = 3.DifficultyValue();
		double num3 = 5.DifficultyValue();
		double num4 = this.27(num);
		double num5 = this.28(num2);
		double num6 = this.28(num3);
		double num7 = 0.0;
		if (4 != null)
		{
			num7 = this.28(4.DifficultyValue());
		}
		double num8 = 2093.25(num4);
		double num9 = 2090.4(num5);
		double 6 = 2090.4(num6);
		double 7 = 2105.9(num7);
		double num10 = 2093.26(6, 7);
		double 8 = 2093.29(1897.5(1.1, new double[]
		{
			num8,
			num9,
			num10
		}));
		2092 9 = new 2092
		{
			3 = 8,
			1 = this.2.22
		};
		if (this.14)
		{
			this.23(9, 10, 2, 3, 5, num, num2, num3, num4, num5, num6, (4 != null) ? new double?(num7) : null);
		}
		return 9;
	}

	// Token: 0x06003680 RID: 13952 RVA: 0x00155ACC File Offset: 0x00153CCC
	protected override void OnObjectProcessed(1896 1, 1914[] 2)
	{
		if (this.15 == null)
		{
			return;
		}
		if (this.15.Count == 0)
		{
			this.17 = 0;
		}
		while (this.17 < this.3.Count && this.3[this.17].1 <= 1.2.1)
		{
			this.17++;
		}
		base.11();
		this.16 = this.17;
		try
		{
			2092 3 = (2092)this.CreateDifficultyAttributes(2);
			3.2 = null;
			3.31 = this.17;
			this.15.Add(new KeyValuePair<double, 2092>((double)1.2.2, 3));
		}
		finally
		{
			this.16 = -1;
		}
	}

	// Token: 0x06003681 RID: 13953 RVA: 0x00155BA8 File Offset: 0x00153DA8
	private int 20()
	{
		if (this.16 >= 0)
		{
			return Math.Min(this.16, this.3.Count);
		}
		return this.3.Count;
	}

	// Token: 0x06003682 RID: 13954 RVA: 0x00155BD8 File Offset: 0x00153DD8
	internal static int 21(List<2034> 1)
	{
		int num = 0;
		foreach (2034 2 in 1)
		{
			num += 2093.22(2);
		}
		return num;
	}

	// Token: 0x06003683 RID: 13955 RVA: 0x00155C2C File Offset: 0x00153E2C
	private static int 22(2034 1)
	{
		2123 2 = 1 as 2123;
		if (2 == null)
		{
			return 1;
		}
		return 1 + 2.83.Count;
	}

	// Token: 0x06003684 RID: 13956 RVA: 0x00155C54 File Offset: 0x00153E54
	private void 23(2092 1, 1914[] 2, 2103 3, 2111 4, 2106 5, double 6, double 7, double 8, double 9, double 10, double 11, double? 12)
	{
		2103 13 = 2.OfType<2103>().First((2103 1) => !1.12);
		double 14 = 13.DifficultyValue();
		double num = this.27(14);
		19.5 = 9;
		19.7 = 10;
		19.10 = 11;
		19.9 = 12;
		19.11 = ((6 > 0.0) ? (num / 9) : 1.0);
		19.12 = 3.6(6);
		19.13 = 4.CountTopWeightedObjectDifficulties(7);
		19.14 = 5.CountTopWeightedObjectDifficulties(8);
		19.8 = 4.6();
		19.6 = 3.9();
		double num2 = 13.10(14);
		double num3 = 13.6(14);
		19.15 = num2 / Math.Max(1.0, num3 - num2);
		double num4 = 4.7(7);
		19.16 = num4 / Math.Max(1.0, 19.13 - num4);
		double num5 = (double)this.1.15();
		int num6 = 0;
		int num7 = 0;
		long num8 = 0L;
		int num9 = 0;
		int num10 = 0;
		double num11 = 0.0;
		int num12 = this.20();
		for (int i = 0; i < num12; i++)
		{
			2034 15 = this.3[i];
			num7 += 2093.22(15);
			2123 16 = 15 as 2123;
			if (16 != null)
			{
				int num13 = 0;
				int num14 = 0;
				foreach (2055 17 in 16.23())
				{
					if (17 is 2069)
					{
						num13++;
					}
					else if (17 is 2065)
					{
						num14++;
					}
				}
				19.20++;
				num9 += 2 + num14;
				num10 += num13;
				num6 += 2 + num14 + num13;
				num8 += (long)((int)((double)Math.Max(0, num6 - 1) * (12.0 * num5)));
			}
			else
			{
				if (15.HasObjectType(2047.Spinner))
				{
					19.21++;
					num11 += 2093.24((double)(15.2 - 15.1) / 1000.0);
				}
				else
				{
					19.19++;
				}
				num8 += (long)((int)((double)Math.Max(0, num6 - 1) * (12.0 * num5)));
				num6++;
			}
		}
		19.17 = num6;
		19.18 = num7;
		19.24 = (double)num8;
		19.23 = num5;
		19.22 = ((num12 > 0) ? (((double)num9 * 30.0 + (double)num10 * 10.0 + num11) / (double)num12) : 0.0);
		double 18 = (double)this.2.16(1928.OverallDifficulty, this.1.4);
		19.28 = this.4;
		19.25 = (Math.Floor(this.2.GetDifficultyRange(18, 80.0, 50.0, 20.0)) - 0.5) / this.4;
		19.26 = (Math.Floor(this.2.GetDifficultyRange(18, 140.0, 100.0, 60.0)) - 0.5) / this.4;
		19.27 = (Math.Floor(this.2.GetDifficultyRange(18, 200.0, 150.0, 100.0)) - 0.5) / this.4;
		19.4 = true;
	}

	// Token: 0x06003685 RID: 13957 RVA: 0x00156060 File Offset: 0x00154260
	private static double 24(double 1)
	{
		int num = (int)(1 * 7.95 * 2.0);
		int num2 = (int)(1 * 3.0) + 3;
		int num3 = num / 2;
		int num4 = Math.Max(0, (num - num2) / 2 - num3 / 2);
		return 100.0 * (double)num3 + 1000.0 * (double)num4;
	}

	// Token: 0x06003686 RID: 13958 RVA: 0x001555D8 File Offset: 0x001537D8
	private static double 25(double 1)
	{
		return 4.0 * 1897.12(1, 3);
	}

	// Token: 0x06003687 RID: 13959 RVA: 0x001560C0 File Offset: 0x001542C0
	private static double 26(double 1, double 2)
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
			2 * 1052.20(2 / 1, 0.25, 1.0)
		});
	}

	// Token: 0x06003688 RID: 13960 RVA: 0x00156120 File Offset: 0x00154320
	private double 27(double 1)
	{
		return 1897.11(1, 0.63) * 0.02275;
	}

	// Token: 0x06003689 RID: 13961 RVA: 0x0015613B File Offset: 0x0015433B
	private double 28(double 1)
	{
		return Math.Sqrt(1) * 0.0675;
	}

	// Token: 0x0600368A RID: 13962 RVA: 0x0015614D File Offset: 0x0015434D
	private static double 29(double 1)
	{
		return 1897.13(1 * 1.12);
	}

	// Token: 0x0600368B RID: 13963 RVA: 0x00156160 File Offset: 0x00154360
	protected override IEnumerable<1896> CreateDifficultyHitObjects()
	{
		List<1896> list = new List<1896>(this.3.Count);
		double <<EMPTY_NAME>> = Math.Floor(this.2.GetDifficultyRange((double)this.2.16(1928.OverallDifficulty, this.1.4), 80.0, 50.0, 20.0)) - 0.5;
		int 2 = this.2.IsInfiniteApproach ? 13800 : this.2.2;
		for (int i = 1; i < this.3.Count; i++)
		{
			list.Add(new 2095(this.3[i], this.3[i - 1], this.4, <<EMPTY_NAME>>, this.2.1, 2, list.Count, list));
		}
		return list;
	}

	// Token: 0x0600368C RID: 13964 RVA: 0x00156244 File Offset: 0x00154444
	protected override 1914[] CreateSkills(2023 1)
	{
		List<1914> list = new List<1914>
		{
			new 2103(1, true),
			new 2111(1),
			new 2106(1)
		};
		if ((1 & 2023.Flashlight) > 2023.None)
		{
			list.Add(new 2105(1, this.3.Count));
		}
		if (this.14)
		{
			list.Add(new 2103(1, false));
		}
		return list.ToArray();
	}

	// Token: 0x040028A8 RID: 10408
	internal new 2100 13;

	// Token: 0x040028A9 RID: 10409
	internal new bool 14;

	// Token: 0x040028AA RID: 10410
	internal new List<KeyValuePair<double, 2092>> 15;

	// Token: 0x040028AB RID: 10411
	private new int 16 = -1;

	// Token: 0x040028AC RID: 10412
	private int 17;

	// Token: 0x040028AD RID: 10413
	internal 2092 18;

	// Token: 0x0200073F RID: 1855
	[276]
	[Serializable]
	public sealed class 2094
	{
		// Token: 0x040028AE RID: 10414
		public static readonly 2093.2094 instance = new 2093.2094();

		// Token: 0x040028AF RID: 10415
		public static Func<2103, bool> func;
	}
}
