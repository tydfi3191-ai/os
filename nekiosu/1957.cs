using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x020007AC RID: 1964
public sealed class 1957 : 1920
{
	// Token: 0x06003952 RID: 14674 RVA: 0x00143B44 File Offset: 0x00141D44
	public 1957(1262 1) : base(1)
	{
	}

	// Token: 0x06003953 RID: 14675 RVA: 0x000193B1 File Offset: 0x000175B1
	protected override 2147 GetPlayMode()
	{
		return 2147.OsuMania;
	}

	// Token: 0x06003954 RID: 14676 RVA: 0x00169CAE File Offset: 0x00167EAE
	public override 1898[] GetModOptions()
	{
		return 1957.19(this.1.3() != 2147.OsuMania);
	}

	// Token: 0x06003955 RID: 14677 RVA: 0x00169CC6 File Offset: 0x00167EC6
	private static 1898[] 17()
	{
		return new 1898[]
		{
			new 1913(2023.DoubleTime),
			new 1913(2023.HalfTime),
			new 1913(2023.Easy),
			new 1913(2023.HardRock)
		};
	}

	// Token: 0x06003956 RID: 14678 RVA: 0x00169CF8 File Offset: 0x00167EF8
	public static 2023 18()
	{
		return 2023.Easy | 2023.HardRock | 2023.DoubleTime | 2023.HalfTime | 2023.Key4 | 2023.Key5 | 2023.Key6 | 2023.Key7 | 2023.Key8 | 2023.Key9;
	}

	// Token: 0x06003957 RID: 14679 RVA: 0x00169D00 File Offset: 0x00167F00
	private static 1898[] 19(bool 1)
	{
		List<1898> list = 1957.17().ToList<1898>();
		if (!1)
		{
			return list.ToArray();
		}
		return list.Concat(new 1898[]
		{
			new 1913(2023.Key4),
			new 1888(new 2023[]
			{
				2023.Key4,
				2023.KeyCoop
			}),
			new 1913(2023.Key5),
			new 1888(new 2023[]
			{
				2023.Key5,
				2023.KeyCoop
			}),
			new 1913(2023.Key6),
			new 1888(new 2023[]
			{
				2023.Key6,
				2023.KeyCoop
			}),
			new 1913(2023.Key7),
			new 1888(new 2023[]
			{
				2023.Key7,
				2023.KeyCoop
			}),
			new 1913(2023.Key8),
			new 1888(new 2023[]
			{
				2023.Key8,
				2023.KeyCoop
			}),
			new 1913(2023.Key9),
			new 1888(new 2023[]
			{
				2023.Key9,
				2023.KeyCoop
			})
		}).ToArray<1898>();
	}

	// Token: 0x06003958 RID: 14680 RVA: 0x00169E39 File Offset: 0x00168039
	internal override 2039 CreateHitObjectManager()
	{
		return new 1975(false);
	}

	// Token: 0x06003959 RID: 14681 RVA: 0x00169E44 File Offset: 0x00168044
	protected override double Calculate(Dictionary<string, string> 1)
	{
		1956 2 = (1956)base.16();
		if (1 != null)
		{
			1.Add("Strain", 2.3.ToString("0.00", 1662.18));
			1.Add("Hit window 300", Math.Ceiling((double)this.2.5 / this.4).ToString("0.00", 1662.18));
			1.Add("Score multiplier", 2019.12(this.2.22 & ~(2023.Hidden | 2023.HardRock | 2023.DoubleTime | 2023.Flashlight | 2023.FadeIn), 2147.OsuMania, this.1).ToString("0.00", 1662.18));
		}
		return 2.3;
	}

	// Token: 0x0600395A RID: 14682 RVA: 0x00169F00 File Offset: 0x00168100
	private 1941.1953 20()
	{
		if (this.1.3() == 2147.OsuMania)
		{
			return null;
		}
		2023 <<EMPTY_NAME>> = this.2.22 & 2023.KeyMod;
		2023? 2 = this.16;
		2023 3 = <<EMPTY_NAME>>;
		if (!(2.GetValueOrDefault() == 3 & 2 != null))
		{
			this.16 = new 2023?(<<EMPTY_NAME>>);
			try
			{
				this.15 = 1941.1(this.1.49(this.1.58), <<EMPTY_NAME>>);
			}
			catch (Exception 4)
			{
				this.15 = null;
				1338.4(4, "lazer's osu!mania conversion of " + this.1.58, 1341.Runtime);
			}
		}
		return this.15;
	}

	// Token: 0x1700029C RID: 668
	// (get) Token: 0x0600395B RID: 14683 RVA: 0x00169FBC File Offset: 0x001681BC
	private int ObjectCount
	{
		get
		{
			1941.1953 <<EMPTY_NAME>> = this.20();
			if (<<EMPTY_NAME>> == null)
			{
				return this.3.Count;
			}
			return <<EMPTY_NAME>>.1.Count;
		}
	}

	// Token: 0x0600395C RID: 14684 RVA: 0x00169FE0 File Offset: 0x001681E0
	protected override 1890 CreateDifficultyAttributes(1914[] 1)
	{
		1956 result;
		if (this.ObjectCount == 0)
		{
			1956 2 = new 1956();
			2.1 = this.2.22;
			result = 2;
			this.13 = 2;
			return result;
		}
		1956 3 = new 1956();
		3.3 = 1.OfType<1963>().Single<1963>().DifficultyValue() * 0.018;
		3.1 = this.2.22;
		3.4 = this.ObjectCount;
		result = 3;
		this.13 = 3;
		return result;
	}

	// Token: 0x0600395D RID: 14685 RVA: 0x0016A06C File Offset: 0x0016826C
	protected override void OnObjectProcessed(1896 1, 1914[] 2)
	{
		if (this.14 == null)
		{
			return;
		}
		int num = this.ObjectCount - 1;
		int num2 = Math.Max(1, num / 400);
		if (1.8 % num2 != 0 && 1.8 != num - 1)
		{
			return;
		}
		base.11();
		2034 3 = 1.2;
		int? num3 = (3 != null) ? new int?(3.2) : null;
		double key = (num3 != null) ? ((double)num3.GetValueOrDefault()) : (1.6 * 1.7);
		this.14.Add(new KeyValuePair<double, 1956>(key, new 1956
		{
			3 = 2.OfType<1963>().Single<1963>().DifficultyValue() * 0.018,
			1 = this.2.22,
			4 = 1.8 + 2
		}));
	}

	// Token: 0x0600395E RID: 14686 RVA: 0x0016A151 File Offset: 0x00168351
	protected override 1914[] CreateSkills(2023 1)
	{
		1914[] array = new 1914[1];
		int num = 0;
		1941.1953 2 = this.20();
		array[num] = new 1963(1, (2 != null) ? 2.2 : 2011.53(this.1, 1));
		return array;
	}

	// Token: 0x0600395F RID: 14687 RVA: 0x0016A17F File Offset: 0x0016837F
	protected override bool RequiresReload(2023 1)
	{
		return (this.2.22 & 2023.KeyMod) != (1 & 2023.KeyMod);
	}

	// Token: 0x06003960 RID: 14688 RVA: 0x00022391 File Offset: 0x00020591
	protected override IEnumerable<1896> SortObjects(IEnumerable<1896> 1)
	{
		return 1;
	}

	// Token: 0x06003961 RID: 14689 RVA: 0x0016A1A4 File Offset: 0x001683A4
	protected override IEnumerable<1896> CreateDifficultyHitObjects()
	{
		1941.1953 <<EMPTY_NAME>> = this.20();
		if (<<EMPTY_NAME>> != null)
		{
			return this.21(<<EMPTY_NAME>>);
		}
		int num = 2011.53(this.1, this.2.22);
		List<1896> list = new List<1896>(this.3.Count);
		List<1896>[] array = new List<1896>[num];
		for (int i = 0; i < num; i++)
		{
			array[i] = new List<1896>();
		}
		2034[] array2 = (from 1 in this.3
		orderby 1.DifficultyStartTime, 1.27
		select 1).ToArray<2034>();
		1955<2034>.1(array2, Comparer<2034>.Create((2034 1, 2034 2) => (int)Math.Round(1.DifficultyStartTime) - (int)Math.Round(2.DifficultyStartTime)));
		for (int j = 1; j < array2.Length; j++)
		{
			1979 4 = (1979)array2[j];
			1958 3 = new 1958(array2[j], array2[j - 1], this.4, list, array, list.Count, 4.44);
			list.Add(3);
			array[3.columnIndex].Add(3);
		}
		return list;
	}

	// Token: 0x06003962 RID: 14690 RVA: 0x0016A2F8 File Offset: 0x001684F8
	private IEnumerable<1896> 21(1941.1953 1)
	{
		List<1896> list = new List<1896>(3.1.Count);
		List<1896>[] array = new List<1896>[3.2];
		for (int i = 0; i < 3.2; i++)
		{
			array[i] = new List<1896>();
		}
		1941.1949[] array2 = (from 1 in 3.1.Select((1941.1949 1, int 2) => new
		{
			1,
			2
		})
		orderby 1.note.2, 1.order
		select 1.note).ToArray<1941.1949>();
		1955<1941.1949>.1(array2, Comparer<1941.1949>.Create((1941.1949 1, 1941.1949 2) => (int)Math.Round(1.2) - (int)Math.Round(2.2)));
		for (int j = 1; j < array2.Length; j++)
		{
			1958 4 = new 1958(array2[j].2, array2[j].3, array2[j - 1].2, this.4, list, array, list.Count, array2[j].1);
			list.Add(4);
			array[4.columnIndex].Add(4);
		}
		return list;
	}

	// Token: 0x04002A81 RID: 10881
	internal new 1956 13;

	// Token: 0x04002A82 RID: 10882
	internal new List<KeyValuePair<double, 1956>> 14;

	// Token: 0x04002A83 RID: 10883
	private new 1941.1953 15;

	// Token: 0x04002A84 RID: 10884
	private new 2023? 16;
}
