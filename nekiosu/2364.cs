using System;
using System.Collections.Generic;

// Token: 0x020005C9 RID: 1481
public class 2364 : 2254
{
	// Token: 0x06002DC2 RID: 11714 RVA: 0x000193B1 File Offset: 0x000175B1
	public override 2277 _0005_2005_2000_200A_2003_2005_2004_2004_2005_2003_2000()
	{
		return 2277.Timing;
	}

	// Token: 0x06002DC3 RID: 11715 RVA: 0x00102634 File Offset: 0x00100834
	protected override void _000E_2000_2004_2001_2006_2006_2000_2005_2007_2009_2007_2000_2005_200B_200A_2004_2007_2002_2003_2001_2003_2005_200A_2007_200B(2046 1)
	{
		this.2 = 1;
		this._0006_2000_2007_200B_2007_2009_200A_2004_2003_2006_200B_2009_200B_2006();
	}

	// Token: 0x06002DC4 RID: 11716 RVA: 0x00102644 File Offset: 0x00100844
	protected virtual void _0006_2000_2007_200B_2007_2009_200A_2004_2003_2006_200B_2009_200B_2006()
	{
		List<2036> list = this.2.CloneHitObjectData();
		int num = 0;
		int num2 = 0;
		if (list.Count > 0)
		{
			num = list[list.Count - 1].2;
			num2 = num - list[0].1;
			if (num2 > 360000)
			{
				this.1.Add(new 2278(-1, (2341)1, 1568.1(2679.AITiming_BeatmapTooLong), -1, null));
			}
			else if (num2 < 45000)
			{
				this.1.Add(new 2278(-1, (2341)1, 1568.1(2679.AITiming_BeatmapTooShort), -1, null));
			}
			if ((double)num2 / (double)(1226.9() - list[0].1) < 0.8)
			{
				this.1.Add(new 2278(-1, (2341)1, 1568.1(2679.AITiming_Mp3LongerThanMap), -1, null));
			}
		}
		List<1259> list2 = 1226.81();
		int num3 = 0;
		int num4 = 0;
		bool flag = false;
		double num5 = 0.0;
		int num6 = 0;
		int num7 = 0;
		bool flag2 = false;
		for (int i = 0; i < list2.Count; i++)
		{
			1259 <<EMPTY_NAME>> = list2[i];
			int num8 = (int)<<EMPTY_NAME>>.3;
			int num9 = ((i == list2.Count - 1) ? num : ((int)list2[i + 1].3)) - num8;
			if (num9 > 0 && <<EMPTY_NAME>>.3())
			{
				num4 += num9;
				if (i > 0 && !list2[i - 1].3())
				{
					num3++;
				}
			}
			if (!flag2)
			{
				if (!<<EMPTY_NAME>>.1())
				{
					this.1.Add(new 2278(num8, (2341)2, "Inherited timing point before the first uninherited timing point!", 0, null));
				}
				else
				{
					flag2 = true;
					if (<<EMPTY_NAME>>.3())
					{
						this.1.Add(new 2278(num8, (2341)2, "First uninherited timing point toggles kiai!", 0, null));
					}
				}
			}
			if (i > 0 && num8 == (int)list2[i - 1].3)
			{
				num7++;
				for (int j = 1; j <= num7; j++)
				{
					if (<<EMPTY_NAME>>.1() == list2[i - j].1())
					{
						this.1.Add(new 2278(num8, (2341)1, 1568.1(2679.AITiming_OverlappingTimingPoints), 0, null));
						break;
					}
				}
			}
			else
			{
				num7 = 0;
			}
			if (<<EMPTY_NAME>>.3() && !flag)
			{
				flag = true;
				if (2280.7(num8, false, 1.0))
				{
					this.1.Add(new 2278(num8, (2341)1, 1568.1(2679.AITiming_UnsnappedKiai), 0, null));
				}
				if (<<EMPTY_NAME>>.3 - num5 < 15000.0 && <<EMPTY_NAME>>.3 - num5 > 10.0)
				{
					this.1.Add(new 2278(num8, (2341)1, 1568.1(2679.AITiming_KiaiTooShort), -1, null));
				}
			}
			else if (!<<EMPTY_NAME>>.3() && flag)
			{
				flag = false;
				if (2280.7(num8, false, 1.0))
				{
					this.1.Add(new 2278(num8, (2341)1, 1568.1(2679.AITiming_UnsnappedKiaiEnd), 0, null));
				}
				num5 = <<EMPTY_NAME>>.3;
			}
			if (<<EMPTY_NAME>>.6 < 5)
			{
				num6++;
			}
		}
		if (num6 == list2.Count)
		{
			this.1.Add(new 2278((2341)2, 1568.1(2679.AITiming_AllTimingSectionsQuiet)));
		}
		else if (num6 > 0)
		{
			this.1.Add(new 2278((2341)1, string.Format(1568.1(2679.AITiming_SomeTimingSectionsQuiet), num6, list2.Count)));
		}
		if (num2 > 180000 && num4 > num2 / 3)
		{
			this.1.Add(new 2278(-1, (2341)1, 1568.1(2679.AITiming_TooMuchKiai), -1, null));
		}
		else if (num2 < 90000 && num4 > num2 / 2)
		{
			this.1.Add(new 2278(-1, (2341)1, 1568.1(2679.AITiming_TooMuchKiaiTvSize), -1, null));
		}
		if (1272.5().78 < 0)
		{
			this.1.Add(new 2278(-1, (2341)1, 1568.1(2679.AITiming_NoPreviewPoint), -1, null));
		}
		if (flag)
		{
			this.1.Add(new 2278(-1, (2341)1, 1568.1(2679.AITiming_NoKiaiEnd), -1, null));
		}
		1041 2 = 1226.100();
		if (2 != null)
		{
			if (2.6 < 128)
			{
				this.1.Add(new 2278((2341)1, 1568.1(2679.AITiming_LowAudioBitrate)));
				return;
			}
			if (2.6 > 192)
			{
				this.1.Add(new 2278((2341)1, 1568.1(2679.AITiming_HighAudioBitrate)));
			}
		}
	}

	// Token: 0x04002196 RID: 8598
	protected 2046 2;
}
