using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x020007DD RID: 2013
public sealed class 1850 : 1920
{
	// Token: 0x06003A83 RID: 14979 RVA: 0x00143B44 File Offset: 0x00141D44
	public 1850(1262 1) : base(1)
	{
	}

	// Token: 0x06003A84 RID: 14980 RVA: 0x0001905A File Offset: 0x0001725A
	protected override 2147 GetPlayMode()
	{
		return 2147.CatchTheBeat;
	}

	// Token: 0x06003A85 RID: 14981 RVA: 0x00169CC6 File Offset: 0x00167EC6
	public override 1898[] GetModOptions()
	{
		return new 1898[]
		{
			new 1913(2023.DoubleTime),
			new 1913(2023.HalfTime),
			new 1913(2023.Easy),
			new 1913(2023.HardRock)
		};
	}

	// Token: 0x06003A86 RID: 14982 RVA: 0x00143B7F File Offset: 0x00141D7F
	public static 2023 17()
	{
		return 2023.Easy | 2023.HardRock | 2023.DoubleTime | 2023.HalfTime;
	}

	// Token: 0x06003A87 RID: 14983 RVA: 0x00170B8F File Offset: 0x0016ED8F
	internal override 2039 CreateHitObjectManager()
	{
		return new 1875(false);
	}

	// Token: 0x06003A88 RID: 14984 RVA: 0x00170B98 File Offset: 0x0016ED98
	protected override double Calculate(Dictionary<string, string> 1)
	{
		this.13 = null;
		1925 2 = this.7;
		1841 3 = (((2 != null) ? 2.7 : null) == null) ? this.18() : null;
		if (3 == null)
		{
			List<KeyValuePair<double, 1841>> list = this.14;
			if (list != null)
			{
				list.Clear();
			}
			3 = (1841)base.16();
			3.4 = this.3.Count((2034 1) => !(1 is 1860) && !(1 is 1872));
			3.5 = 2039.22((double)this.2.16(1928.ApproachRate, this.1.1), 1.4, this.2.22);
			3.6 = this.4;
			3.9 = this.3.Count((2034 1) => 1 is 1872);
			3.8 = this.3.Count((2034 1) => 1 is 1863 && !(1 is 1872));
			3.7 = 3.4 - 3.8;
		}
		this.13 = 3;
		if (4 != null)
		{
			4.Add("Aim", 3.3.ToString("0.00", 1662.18));
			double num = (double)this.2.2 / this.4;
			4.Add("AR", ((num > 1200.0) ? ((0.0 - (num - 1800.0)) / 120.0) : ((0.0 - (num - 1200.0)) / 150.0 + 5.0)).ToString("0.00", 1662.18));
			4.Add("Max combo", this.3.Count.ToString(1662.18));
		}
		return 3.3;
	}

	// Token: 0x06003A89 RID: 14985 RVA: 0x00170DB8 File Offset: 0x0016EFB8
	private 1841 18()
	{
		1841 result;
		try
		{
			List<KeyValuePair<double, 1841>> list = this.14;
			if (list != null)
			{
				list.Clear();
			}
			List<KeyValuePair<double, double>> list2 = (this.12 != null) ? new List<KeyValuePair<double, double>>() : null;
			byte[] <<EMPTY_NAME>> = this.1.49(this.1.58);
			2023 2 = this.2.22;
			1927 3 = this.5;
			double 4 = this.4;
			1925 5 = this.7;
			1841 6 = 1851.1(<<EMPTY_NAME>>, 2, 3, 4, 5 != null && 5.5 != null, this.14, null, list2);
			if (list2 != null && 6 != null && this.3 != null && this.3.Count > 0)
			{
				this.12.1.Clear();
				this.12.2.Clear();
				this.12.1.AddRange(from 1 in list2
				select 1.Key);
				this.12.2.Add((from 1 in list2
				select 1.Value).ToArray<double>());
				this.12.3 = (double)this.3.Min((2034 1) => 1.1);
				this.12.4 = (double)this.3.Max((2034 1) => 1.2);
				this.12.5 = this.4;
			}
			result = 6;
		}
		catch (Exception 7)
		{
			1338.4(7, "lazer's osu!catch difficulty for " + this.1.58, 1341.Runtime);
			result = null;
		}
		return result;
	}

	// Token: 0x06003A8A RID: 14986 RVA: 0x00170FB4 File Offset: 0x0016F1B4
	protected override 1914[] CreateSkills(2023 1)
	{
		return new 1914[]
		{
			new 1843(1)
		};
	}

	// Token: 0x06003A8B RID: 14987 RVA: 0x00170FC8 File Offset: 0x0016F1C8
	protected override 1890 CreateDifficultyAttributes(1914[] 1)
	{
		if (this.3.Count == 0)
		{
			return new 1841
			{
				1 = this.2.22
			};
		}
		return new 1841
		{
			3 = Math.Sqrt(1.OfType<1843>().Single<1843>().DifficultyValue()) * 4.59,
			1 = this.2.22
		};
	}

	// Token: 0x06003A8C RID: 14988 RVA: 0x001556B4 File Offset: 0x001538B4
	protected override bool RequiresReload(2023 1)
	{
		return ((this.2.22 ^ 1) & (2023.Easy | 2023.HardRock)) > 2023.None;
	}

	// Token: 0x06003A8D RID: 14989 RVA: 0x00171040 File Offset: 0x0016F240
	protected override IEnumerable<1896> CreateDifficultyHitObjects()
	{
		2034 <<EMPTY_NAME>> = null;
		List<1896> list = new List<1896>(this.3.Count);
		float num = 305f / 1662.69.9() * this.2.23 * 0.7f;
		((1875)this.2).81(num);
		float num2 = num * 0.5f;
		num2 *= 0.8f;
		num2 *= 1f - Math.Max(0f, this.2.16(1928.CircleSize, this.1.2) - 5.5f) * 0.0625f;
		foreach (2034 2 in this.3)
		{
			if (!(2 is 1860) && !(2 is 1872))
			{
				if (<<EMPTY_NAME>> != null)
				{
					list.Add(new 1842(2, <<EMPTY_NAME>>, this.4, num2, list, list.Count));
				}
				<<EMPTY_NAME>> = 2;
			}
		}
		return list;
	}

	// Token: 0x04002B1D RID: 11037
	internal new 1841 13;

	// Token: 0x04002B1E RID: 11038
	internal new List<KeyValuePair<double, 1841>> 14;
}
