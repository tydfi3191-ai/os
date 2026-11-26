using System;
using System.Collections.Generic;
using System.IO;

// Token: 0x020005BA RID: 1466
public sealed class 2351 : 2254
{
	// Token: 0x06002D8C RID: 11660 RVA: 0x0010128C File Offset: 0x000FF48C
	public override 2277 _0005_2005_2000_200A_2003_2005_2004_2004_2005_2003_2000()
	{
		return 2277.Mapset;
	}

	// Token: 0x06002D8D RID: 11661 RVA: 0x00101290 File Offset: 0x000FF490
	protected override void _000E_2000_2004_2001_2006_2006_2000_2005_2007_2009_2007_2000_2005_200B_200A_2004_2007_2002_2003_2001_2003_2005_200A_2007_200B(2046 1)
	{
		2351.2352 2 = new 2351.2352();
		2.1 = 1272.5();
		this.2 = 1;
		this.3 = 1272.3.FindAll(new Predicate<1262>(2.1));
		this.4();
		for (int i = 0; i < this.3.Count; i++)
		{
			1262 3 = this.3[i];
			this.3(3);
			if (!(3.23 == 2.1.23))
			{
				3.65();
				this.1(2.1, 3);
				this.6(2.1, 3);
			}
		}
		this.2();
		this.7(this.3);
	}

	// Token: 0x06002D8E RID: 11662 RVA: 0x0010134C File Offset: 0x000FF54C
	protected new void 1(1262 1, 1262 2)
	{
		if (2.7 != 1.7)
		{
			this.1.Add(new 2278((2341)1, string.Format(1568.1(2679.AIMapset_ConflictingArtist), 2.89)));
		}
		if (2.10 != 1.10)
		{
			this.1.Add(new 2278((2341)1, string.Format(1568.1(2679.AIMapset_ConflictingTitle), 2.89)));
		}
		if (2.8 != 1.8)
		{
			this.1.Add(new 2278((2341)1, string.Format(1568.1(2679.AIMapset_ConflictingUnicodeArtist), 2.89)));
		}
		if (2.11 != 1.11)
		{
			this.1.Add(new 2278((2341)1, string.Format(1568.1(2679.AIMapset_ConflictingUnicodeTitle), 2.89)));
		}
		if (2.82 != 1.82)
		{
			this.1.Add(new 2278((2341)1, string.Format(1568.1(2679.AIMapset_ConflictingSource), 2.89)));
		}
		if (2.9 != 1.9)
		{
			this.1.Add(new 2278((2341)1, string.Format(1568.1(2679.AIMapset_ConflictingTags), 2.89)));
		}
		if (2.18 != 1.18)
		{
			this.1.Add(new 2278((2341)1, string.Format(1568.1(2679.AIMapset_ConflictingAudioFile), 2.89)));
		}
		if (2.19 != 1.19)
		{
			this.1.Add(new 2278((2341)1, string.Format(1568.1(2679.AIMapset_ConflictingLeadin), 2.89)));
		}
		if (2.78 != 1.78)
		{
			this.1.Add(new 2278((2341)1, string.Format(1568.1(2679.AIMapset_ConflictingPreviewTime), 2.89)));
		}
		if (2.38 != 1.38)
		{
			this.1.Add(new 2278((2341)1, string.Format(1568.1(2679.AIMapset_ConflictingCountdown), 2.89)));
		}
		if (2.62 != 1.62)
		{
			this.1.Add(new 2278((2341)1, string.Format(1568.1(2679.AIMapset_ConflictingLetterbox), 2.89)));
		}
	}

	// Token: 0x06002D8F RID: 11663 RVA: 0x001015B8 File Offset: 0x000FF7B8
	protected void 2()
	{
		List<2036> list = this.2.CloneHitObjectData();
		double num = 2.7;
		if (list.Count > 0)
		{
			int num2 = list[list.Count - 1].2 - list[0].1;
			if (num2 > 300000)
			{
				num = 999.0;
			}
			else if (num2 > 255000)
			{
				num = 5.3;
			}
			else if (num2 > 210000)
			{
				num = 4.0;
			}
		}
		if (this.4 == 1)
		{
			this.1.Add(new 2278((2341)1, 1568.1(2679.AIMapset_MissingStandardDiff)));
		}
		if (this.8 > num && this.4 > 0)
		{
			this.1.Add(new 2278((2341)1, "This mapset needs an easier difficulty."));
		}
		if (this.5 == 1)
		{
			this.1.Add(new 2278((2341)1, 1568.1(2679.AIMapset_MissingTaikoDiff)));
		}
		if (this.7 == 1)
		{
			this.1.Add(new 2278((2341)1, 1568.1(2679.AIMapset_MissingManiaDiff)));
		}
	}

	// Token: 0x06002D90 RID: 11664 RVA: 0x001016D8 File Offset: 0x000FF8D8
	private void 3(1262 1)
	{
		2147 2 = 1.3();
		this.5(2);
		if (2 == 2147.Osu && 1.18(2, 2023.None) < this.8)
		{
			this.8 = 1.18(2, 2023.None);
		}
	}

	// Token: 0x06002D91 RID: 11665 RVA: 0x00101714 File Offset: 0x000FF914
	private void 4()
	{
		this.4 = (this.5 = (this.6 = (this.7 = 0)));
		this.8 = 10.0;
	}

	// Token: 0x06002D92 RID: 11666 RVA: 0x00101754 File Offset: 0x000FF954
	private void 5(2147 1)
	{
		switch (1)
		{
		case 2147.Taiko:
			this.5++;
			return;
		case 2147.CatchTheBeat:
			this.6++;
			return;
		case 2147.OsuMania:
			this.7++;
			return;
		default:
			this.4++;
			return;
		}
	}

	// Token: 0x06002D93 RID: 11667 RVA: 0x001017B4 File Offset: 0x000FF9B4
	private void 6(1262 1, 1262 2)
	{
		if (1.18 != 2.18)
		{
			return;
		}
		List<1259> list = 1.84();
		List<1259> list2 = 2.84();
		bool flag = list.Count == list2.Count;
		if (flag)
		{
			for (int i = 0; i < list.Count; i++)
			{
				1259 3 = list[i];
				1259 4 = list2[i];
				if ((int)3.3 != (int)4.3 || 3.1 != 4.1)
				{
					flag = false;
					break;
				}
			}
		}
		if (!flag)
		{
			this.1.Add(new 2278((2341)1, "Uninherited timing points conflict with " + 2.89 + " diff."));
		}
	}

	// Token: 0x06002D94 RID: 11668 RVA: 0x00101868 File Offset: 0x000FFA68
	private void 7(List<1262> 1)
	{
		FileInfo[] files = new DirectoryInfo(1272.5().44()).GetFiles("*", SearchOption.AllDirectories);
		long num = 0L;
		bool flag = false;
		int num2 = 0;
		foreach (FileInfo fileInfo in files)
		{
			num += fileInfo.Length;
			if (!flag)
			{
				flag = (2672.24(fileInfo.Name) == (2670)13);
			}
			if (2672.24(fileInfo.Name) == (2670)7)
			{
				using (Stream stream = File.OpenRead(fileInfo.FullName))
				{
					try
					{
						1241 2 = new 1241(stream, true, false);
						if (2.4 > 20000.0)
						{
							num2++;
						}
						2.Dispose();
					}
					catch (1043)
					{
						this.1.Add(new 2278((2341)1, "Beatmap audio has unsupported format."));
					}
				}
			}
		}
		1.Sort(new Comparison<1262>(2351.2353.mapsetCheckerCallbacks.1));
		long num3 = (long)(1[0].87 / 1000) * 166667L + 5242880L;
		if (num > num3)
		{
			this.1.Add(new 2278((2341)1, string.Format("Beatmap exceeds allowed upload size ({0:n0}kb allowed)", num3 / 1024L)));
		}
		if (num2 > 1)
		{
			this.1.Add(new 2278((2341)1, "There are " + num2.ToString() + " song files in your map directory!"));
		}
	}

	// Token: 0x0400216A RID: 8554
	protected 2046 2;

	// Token: 0x0400216B RID: 8555
	protected List<1262> 3;

	// Token: 0x0400216C RID: 8556
	private int 4;

	// Token: 0x0400216D RID: 8557
	private int 5;

	// Token: 0x0400216E RID: 8558
	private int 6;

	// Token: 0x0400216F RID: 8559
	private int 7;

	// Token: 0x04002170 RID: 8560
	private double 8;

	// Token: 0x020005BB RID: 1467
	[Serializable]
	public sealed class 2353
	{
		// Token: 0x06002D96 RID: 11670 RVA: 0x001019E8 File Offset: 0x000FFBE8
		internal int 1(1262 1, 1262 2)
		{
			return 2.87.CompareTo(1.87);
		}

		// Token: 0x04002171 RID: 8561
		public static readonly 2351.2353 mapsetCheckerCallbacks = new 2351.2353();

		// Token: 0x04002172 RID: 8562
		public static Comparison<1262> comparison;
	}

	// Token: 0x020005BC RID: 1468
	public sealed class 2352
	{
		// Token: 0x06002D99 RID: 11673 RVA: 0x00101A07 File Offset: 0x000FFC07
		internal bool 1(1262 1)
		{
			return 1.37 == this.1.37;
		}

		// Token: 0x04002173 RID: 8563
		public 1262 1;
	}
}
