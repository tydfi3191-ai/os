using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;

// Token: 0x02000804 RID: 2052
[276]
public abstract class 2039 : 2046, IDisposable
{
	// Token: 0x06003B7C RID: 15228 RVA: 0x00175D38 File Offset: 0x00173F38
	internal virtual void LoadComboColours(bool 1)
	{
		this.27.Clear();
		for (int i = 1; i <= 8; i++)
		{
			198 2 = 2630.19("Combo" + i.ToString(), this.21.1());
			if (2.A != 0)
			{
				this.27.Add(2);
			}
		}
		if (!1)
		{
			return;
		}
		List<198> list = new List<198>();
		foreach (198 3 in this.27)
		{
			list.Add(new 198(80 + 3.R / 2, 80 + 3.G / 2, 80 + 3.B / 2));
		}
		this.27 = list;
	}

	// Token: 0x06003B7D RID: 15229 RVA: 0x00175E18 File Offset: 0x00174018
	protected virtual bool UsesComboColours()
	{
		return 1272.5().3() != 2147.Taiko;
	}

	// Token: 0x06003B7E RID: 15230 RVA: 0x00175E2C File Offset: 0x0017402C
	private new static bool 1(List<2034> 1)
	{
		for (int i = 1; i < 1.Count; i++)
		{
			if (1[i - 1].CompareTo(1[i]) > 0)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06003B7F RID: 15231 RVA: 0x00175E68 File Offset: 0x00174068
	internal new void 2(bool 1)
	{
		if (this.34 == null)
		{
			this.35 = 0;
			return;
		}
		this.35 = this.34.Count;
		if (1 && !2039.1(this.34))
		{
			2034[] collection = 177.StableSortedCopy<2034>(this.34);
			this.34.Clear();
			this.34.AddRange(collection);
		}
		int num = 0;
		int num2 = 0;
		bool flag = false;
		int num3 = -1;
		int count = this.27.Count;
		int count2 = this.32.13.Count;
		for (int i = 0; i < this.35; i++)
		{
			2034 2 = this.34[i];
			while (num3 + 1 < count2 && this.32.13[num3 + 1].1 < 2.1)
			{
				num3++;
				2.SetNewCombo(true);
			}
			int num4 = this.21.1() ? 2.16 : 0;
			if (2.HasObjectType(2047.Spinner))
			{
				if (this.21.32 <= 8)
				{
					flag = true;
				}
				else if (2.IsNewCombo())
				{
					num += num4;
					flag = true;
				}
			}
			else if (flag || (2.3 & 2047.NewCombo) > (2047)0 || (i == 0 && !(2 is 1866)))
			{
				num2 = 1;
				2.SetComboNumber(num2);
				num += num4 + 1;
				flag = false;
			}
			else
			{
				2.SetComboNumber(++num2);
			}
			if (count > 0 && this.UsesComboColours())
			{
				2.SetComboColour(this.27[num % count]);
				2.17 = num % count;
			}
		}
		if (this.35 > 0)
		{
			this.34[this.35 - 1].10 = true;
		}
	}

	// Token: 0x06003B80 RID: 15232 RVA: 0x00176028 File Offset: 0x00174228
	internal new void 3(2034 1)
	{
		int num = this.34.IndexOf(1);
		if (num < 0)
		{
			return;
		}
		if (!(1 is 2070))
		{
			if (num == 0)
			{
				return;
			}
			num--;
			if (!(this.34[num] is 2070))
			{
				return;
			}
		}
		for (int i = num; i > 0; i--)
		{
			if (!(this.34[i] is 2070))
			{
				i++;
				IL_9A:
				while (i < this.35)
				{
					if (!(this.34[i] is 2070))
					{
						this.34[i].SetNewCombo(true);
						return;
					}
					if (this.34[i].IsNewCombo())
					{
						break;
					}
					i++;
				}
				return;
			}
		}
		goto IL_9A;
	}

	// Token: 0x06003B81 RID: 15233 RVA: 0x001760D8 File Offset: 0x001742D8
	internal new void 4()
	{
		bool flag = false;
		bool flag2 = false;
		for (int i = 0; i < this.34.Count; i++)
		{
			2034 <<EMPTY_NAME>> = this.34[i];
			if (!<<EMPTY_NAME>>.HasObjectType(2047.Spinner))
			{
				if (flag && !flag2)
				{
					<<EMPTY_NAME>>.SetNewCombo(true);
				}
				flag = false;
				flag2 = false;
			}
			else
			{
				flag2 |= <<EMPTY_NAME>>.IsNewCombo();
			}
		}
	}

	// Token: 0x06003B82 RID: 15234 RVA: 0x00176131 File Offset: 0x00174331
	public new bool 5()
	{
		return this.44 == null || this.44 is 2070 || this.44 is 1860;
	}

	// Token: 0x06003B83 RID: 15235 RVA: 0x00176158 File Offset: 0x00174358
	internal 2039(bool 1)
	{
		if (1)
		{
			this.39 = new 1436(this.UsesFullWindowCoordinates())
			{
				22 = false
			};
			this.39.23();
			List<2039> obj = 2039.12;
			lock (obj)
			{
				2039.12.Add(this);
			}
		}
		if (this.39 != null && 1662.78 != 1677.Edit)
		{
			this.39.16 = true;
		}
	}

	// Token: 0x06003B84 RID: 15236 RVA: 0x0017621C File Offset: 0x0017441C
	internal new void 6(1262 1, 2023 2)
	{
		this.21 = 1;
		this.22 = 2;
		this.33 = this.CreateHitObjectFactory();
		this.OnBeatmapChanged();
	}

	// Token: 0x06003B85 RID: 15237 RVA: 0x00005ADD File Offset: 0x00003CDD
	protected virtual void OnBeatmapChanged()
	{
	}

	// Token: 0x06003B86 RID: 15238 RVA: 0x00176243 File Offset: 0x00174443
	public override 2024 GetBeatmap()
	{
		return this.21;
	}

	// Token: 0x06003B87 RID: 15239 RVA: 0x0017624C File Offset: 0x0017444C
	public override List<2036> CloneHitObjectData()
	{
		List<2036> list = new List<2036>();
		foreach (2034 <<EMPTY_NAME>> in this.34)
		{
			list.Add(<<EMPTY_NAME>>.Clone());
		}
		return list;
	}

	// Token: 0x06003B88 RID: 15240 RVA: 0x0000FF75 File Offset: 0x0000E175
	protected virtual bool UsesFullWindowCoordinates()
	{
		return false;
	}

	// Token: 0x06003B89 RID: 15241
	internal abstract 2037 CreateHitObjectFactory();

	// Token: 0x06003B8A RID: 15242 RVA: 0x001762AC File Offset: 0x001744AC
	internal new void 7()
	{
		this.35 = 0;
		this.9 = 0;
		this.10 = 0;
		this.42.Clear();
		1436 <<EMPTY_NAME>> = this.39;
		if (<<EMPTY_NAME>> != null)
		{
			<<EMPTY_NAME>>.15(true);
		}
		if (this.34 == null)
		{
			return;
		}
		foreach (2034 2 in this.34)
		{
			2.StopHitSounds();
			2.Dispose();
		}
		this.34.Clear();
	}

	// Token: 0x06003B8B RID: 15243 RVA: 0x00176348 File Offset: 0x00174548
	public virtual void Dispose()
	{
		2050 <<EMPTY_NAME>> = this.56;
		if (<<EMPTY_NAME>> != null)
		{
			<<EMPTY_NAME>>.Dispose();
		}
		this.56 = null;
		if (this.39 != null)
		{
			this.39.Dispose();
			List<2039> obj = 2039.12;
			lock (obj)
			{
				2039.12.Remove(this);
			}
		}
		this.7();
		2648 2 = this.32;
		if (2 != null)
		{
			2.Dispose();
		}
		Dictionary<string, string> dictionary = this.40;
		if (dictionary != null)
		{
			dictionary.Clear();
		}
		this.34 = null;
	}

	// Token: 0x06003B8C RID: 15244 RVA: 0x001763E8 File Offset: 0x001745E8
	internal new void 8()
	{
		this.39.22();
	}

	// Token: 0x06003B8D RID: 15245 RVA: 0x001763F6 File Offset: 0x001745F6
	protected internal virtual void PrepareHitObjects()
	{
		if (1662.78 != 1677.Edit)
		{
			this.35 = this.34.Count;
			this.38();
			this.11();
			this.42(0, -1);
		}
	}

	// Token: 0x06003B8E RID: 15246 RVA: 0x00176425 File Offset: 0x00174625
	internal virtual void ResetConversionState()
	{
		this.48 = null;
		this.49 = null;
	}

	// Token: 0x06003B8F RID: 15247 RVA: 0x00176438 File Offset: 0x00174638
	internal 1245 9(1245 1)
	{
		if (this.47 == null || !(this is 2184))
		{
			return 1;
		}
		bool flag = (1 & (1245.Whistle | 1245.Clap)) > 1245.None;
		bool flag3;
		if (this.47.7 != null)
		{
			if (this.48 == null)
			{
				this.48 = new Random(this.47.7.4);
				this.49 = new Random(this.47.7.4 * 31 + 17);
			}
			bool flag2 = this.48.Next(2) != 0;
			if (!this.47.7.HasDefaultStrength && this.49.Next(100) >= this.47.7.9)
			{
				return 1;
			}
			flag3 = flag2;
		}
		else
		{
			if (this.47.5 == null)
			{
				return 1;
			}
			flag3 = !flag;
		}
		if (flag3 == flag)
		{
			return 1;
		}
		if (!flag3)
		{
			return 1 & ~(1245.Whistle | 1245.Clap);
		}
		return 1 | 1245.Clap;
	}

	// Token: 0x170002A9 RID: 681
	// (get) Token: 0x06003B90 RID: 15248 RVA: 0x00176526 File Offset: 0x00174726
	internal 2117 RandomLayoutForDifficulty
	{
		get
		{
			if (this.47 == null || this.47.7 == null)
			{
				return null;
			}
			return this.50;
		}
	}

	// Token: 0x06003B91 RID: 15249 RVA: 0x00176545 File Offset: 0x00174745
	internal void 10()
	{
		this.11();
	}

	// Token: 0x06003B92 RID: 15250 RVA: 0x00176550 File Offset: 0x00174750
	private void 11()
	{
		if (this.47 == null || this.47.7 == null || this.53 || this.21 == null || this.21.3() != 2147.Osu || !(this is 2122))
		{
			return;
		}
		2023 <<EMPTY_NAME>> = this.22 & 2023.HardRock;
		if (this.50 == null || this.51 != <<EMPTY_NAME>> || this.52 == null || this.52.4 != this.47.7.4 || this.52.5 != this.47.7.5)
		{
			this.53 = true;
			try
			{
				if (this.50 != null)
				{
					this.50 = null;
					this.13();
					this.38();
				}
				this.50 = 2117.1(this, this.47.7.4, this.47.7.5);
				this.51 = <<EMPTY_NAME>>;
				this.52 = this.47.7;
				this.13();
				this.38();
			}
			finally
			{
				this.53 = false;
			}
		}
		208 2 = new 208(this.8, this.8);
		foreach (2034 3 in this.34)
		{
			if (3.19 < this.50.11.Length && this.50.11[3.19] != null)
			{
				3.9 = this.50.11[3.19].3;
				3.SetPosition(3.18 - (float)3.9 * 2, true);
			}
		}
	}

	// Token: 0x06003B93 RID: 15251 RVA: 0x0017673C File Offset: 0x0017493C
	private static List<208> 12(string 1, int 2, int 3, double 4, bool 5, bool 6, 2117.2118 7)
	{
		2114 8 = 2114.1(1, 2, 3, 4, 5, 6);
		foreach (float num in 7.2)
		{
			if (float.IsNaN(num))
			{
				8.6();
			}
			else
			{
				8.7(num);
			}
		}
		List<208> list = new List<208>();
		foreach (208 9 in 8.CalculatedPath)
		{
			if (list.Count == 0 || list[list.Count - 1] != 9)
			{
				list.Add(9);
			}
		}
		if (list.Count < 2 || 8.Distance <= 1E-07)
		{
			return null;
		}
		return list;
	}

	// Token: 0x06003B94 RID: 15252 RVA: 0x00176838 File Offset: 0x00174A38
	private void 13()
	{
		if (this.54 != null)
		{
			this.7();
			this.48(1288.HitObjects, false, true, true);
			this.35 = this.34.Count;
			this.54();
			return;
		}
		1436 <<EMPTY_NAME>> = this.39;
		if (<<EMPTY_NAME>> != null)
		{
			<<EMPTY_NAME>>.2(true);
		}
		this.7();
		this.48((1288)66, false, false, false);
		this.2(false);
		this.35 = this.34.Count;
		1436 2 = this.39;
		if (2 != null)
		{
			2.2(false);
		}
		this.14();
	}

	// Token: 0x170002AA RID: 682
	// (get) Token: 0x06003B95 RID: 15253 RVA: 0x001768D0 File Offset: 0x00174AD0
	internal int StackingPreemptTime
	{
		get
		{
			if (this.2 < 86400000 || this.21 == null)
			{
				return this.2;
			}
			return (int)this.GetDifficultyRange((double)this.21.1, 1800.0, 1200.0, 450.0);
		}
	}

	// Token: 0x170002AB RID: 683
	// (get) Token: 0x06003B96 RID: 15254 RVA: 0x00176927 File Offset: 0x00174B27
	internal bool IsInfiniteApproach
	{
		get
		{
			return this.2 >= 86400000;
		}
	}

	// Token: 0x170002AC RID: 684
	// (get) Token: 0x06003B97 RID: 15255 RVA: 0x00176939 File Offset: 0x00174B39
	internal int HiddenPreemptTime
	{
		get
		{
			return this.StackingPreemptTime;
		}
	}

	// Token: 0x170002AD RID: 685
	// (get) Token: 0x06003B98 RID: 15256 RVA: 0x00176941 File Offset: 0x00174B41
	internal int LeadInPreemptTime
	{
		get
		{
			if (!this.IsInfiniteApproach)
			{
				return this.2;
			}
			return 1800;
		}
	}

	// Token: 0x06003B99 RID: 15257 RVA: 0x00176958 File Offset: 0x00174B58
	internal void 14()
	{
		if (this.39 == null || this.2 < 86400000 || 1662.78 != 1677.Play)
		{
			return;
		}
		this.39.16 = false;
		this.39.3();
		1428.Apply(this.39, this.21);
		if (this.56 == null)
		{
			this.56 = new 2050(this);
		}
		this.56.1();
	}

	// Token: 0x06003B9A RID: 15258 RVA: 0x001769CA File Offset: 0x00174BCA
	internal bool 15()
	{
		return this.2 >= 86400000 || (1662.78 == 1677.Play && 1304.64.1());
	}

	// Token: 0x06003B9B RID: 15259 RVA: 0x001769EF File Offset: 0x00174BEF
	internal float 16(1928 1, float 2)
	{
		1927 3 = this.45;
		if (3 == null)
		{
			return 2;
		}
		return 3.Apply(1, 2);
	}

	// Token: 0x06003B9C RID: 15260 RVA: 0x00176A04 File Offset: 0x00174C04
	public static void 17(bool 1)
	{
		List<2039> obj = 2039.12;
		lock (obj)
		{
			foreach (2039 2 in 2039.12)
			{
				2.RecalculateDifficulty(1, true, true);
			}
		}
	}

	// Token: 0x06003B9D RID: 15261 RVA: 0x00176A7C File Offset: 0x00174C7C
	public override double GetSliderVelocityAt(int 1)
	{
		double num = this.21.90((double)1, true);
		if (num > 0.0)
		{
			return this.6 * this.21.6 * (1000.0 / num);
		}
		return this.6 * this.21.6;
	}

	// Token: 0x06003B9E RID: 15262 RVA: 0x00176AD5 File Offset: 0x00174CD5
	public static double 18(double 1, 2023 2)
	{
		return 1 * 1939.19(2);
	}

	// Token: 0x06003B9F RID: 15263 RVA: 0x00176ADF File Offset: 0x00174CDF
	public static double 19(double 1)
	{
		return 2039.18(1, 2019.1);
	}

	// Token: 0x06003BA0 RID: 15264 RVA: 0x00176AEC File Offset: 0x00174CEC
	public static double 20(double 1, 2023 2)
	{
		return 1 / 1939.19(2);
	}

	// Token: 0x06003BA1 RID: 15265 RVA: 0x00176AF6 File Offset: 0x00174CF6
	public static double 21(double 1)
	{
		return 2039.20(1, 2019.1);
	}

	// Token: 0x06003BA2 RID: 15266 RVA: 0x00176B04 File Offset: 0x00174D04
	public static double 22(double 1, double 2, 2023 3)
	{
		if (1662.78 != 1677.Edit)
		{
			2023 4 = 2023.Easy;
			if ((3 & 4) > 2023.None)
			{
				1 = Math.Max(0.0, 1 / 2.0);
			}
		}
		if (1662.78 != 1677.Edit)
		{
			2023 5 = 2023.HardRock;
			if ((3 & 5) > 2023.None)
			{
				1 = Math.Min(10.0, 1 * 2);
			}
		}
		return 1;
	}

	// Token: 0x06003BA3 RID: 15267 RVA: 0x00176B61 File Offset: 0x00174D61
	public static double 23(double 1, double 2)
	{
		return 2039.22(1, 2, 2019.1);
	}

	// Token: 0x06003BA4 RID: 15268 RVA: 0x00176B6F File Offset: 0x00174D6F
	public override double GetNormalizedDifficulty(double 1)
	{
		return (2039.22(1, 1.3, this.22) - 5.0) / 5.0;
	}

	// Token: 0x06003BA5 RID: 15269 RVA: 0x00176BA0 File Offset: 0x00174DA0
	public override double GetDifficultyRange(double 1, double 2, double 3, double 4)
	{
		1 = 2039.22(1, 1.4, this.22);
		if (1 > 5.0)
		{
			return 3 + (4 - 3) * (1 - 5.0) / 5.0;
		}
		if (1 < 5.0)
		{
			return 3 - (3 - 2) * (5.0 - 1) / 5.0;
		}
		return 3;
	}

	// Token: 0x06003BA6 RID: 15270 RVA: 0x00176C1C File Offset: 0x00174E1C
	internal virtual void RecalculateDifficulty(bool 1, bool 2, bool 3)
	{
		if (this.21 != null)
		{
			this.6 = 100.0 * this.21.5 / this.21.6;
			this.7 = Math.Max(1.0, this.GetDifficultyRange((double)this.16(1928.OverallDifficulty, this.21.4), 3.0, 5.0, 7.5));
			this.3 = (int)this.GetDifficultyRange((double)this.16(1928.OverallDifficulty, this.21.4), 200.0, 150.0, 100.0);
			this.4 = (int)this.GetDifficultyRange((double)this.16(1928.OverallDifficulty, this.21.4), 140.0, 100.0, 60.0);
			this.5 = (int)this.GetDifficultyRange((double)this.16(1928.OverallDifficulty, this.21.4), 80.0, 50.0, 20.0);
			float num = this.16(1928.ApproachRate, this.21.1);
			this.2 = (1926.1(num) ? 86400000 : ((int)this.GetDifficultyRange((double)num, 1800.0, 1200.0, 450.0)));
			this.24 = (float)((double)(1662.69.1() / 8f) * (1.0 - 0.699999988079071 * this.GetNormalizedDifficulty((double)this.16(1928.CircleSize, this.21.2))));
			this.1 = this.24 / 2f / 1662.69.9() * 1.00041f;
			this.28 = (int)((float)this.2 * 2f / 3f);
			if (2)
			{
				1226.70(true);
			}
			this.23 = this.24 / (float)2039.16;
			if (this.39 != null)
			{
				this.39.14 = this.23;
			}
			this.8 = this.1 / 10f;
			if (1)
			{
				this.25(false);
			}
		}
	}

	// Token: 0x06003BA7 RID: 15271 RVA: 0x00176E74 File Offset: 0x00175074
	internal void 24(bool 1, bool 2)
	{
		2039.2045 timingQuery = new 2039.2045();
		timingQuery.3 = 4;
		timingQuery.1 = (int)1226.79();
		timingQuery.2 = (int)((1226.81().Count - 1 > 1226.70) ? 1226.81()[1226.70 + 1].3 : ((double)1226.9()));
		if (this.34 == null)
		{
			return;
		}
		List<2034> list = this.34.FindAll((2034 1) => 1.1 >= timingQuery.1 && 1.2 <= timingQuery.2 && 1.HasObjectType(2047.Slider) && (!timingQuery.3 || 1.IsActive()));
		if (1662.78 == 1677.Edit && list.Count > 0)
		{
			2263.4.8.24<2034>(list, false);
		}
		int count = list.Count;
		for (int i = 0; i < count; i++)
		{
			2123 3 = (2123)list[i];
			if (2)
			{
				3.6 = 0.0;
			}
			3.RebuildPathAndTiming(true);
		}
	}

	// Token: 0x06003BA8 RID: 15272 RVA: 0x00176F6C File Offset: 0x0017516C
	internal void 25(bool 1)
	{
		if (this.34 == null)
		{
			return;
		}
		List<2034> list = this.34.FindAll(new Predicate<2034>(2039.2040.Instance.1));
		if (1662.78 == 1677.Edit && list.Count > 0)
		{
			2263 2 = 2263.4;
			if (2 != null)
			{
				2458 3 = 2.8;
				if (3 != null)
				{
					3.24<2034>(list, false);
				}
			}
		}
		int count = list.Count;
		for (int i = 0; i < count; i++)
		{
			2123 4 = (2123)list[i];
			if (1)
			{
				4.6 = 0.0;
			}
			4.RebuildPathAndTiming(true);
		}
	}

	// Token: 0x06003BA9 RID: 15273 RVA: 0x00177008 File Offset: 0x00175208
	internal 2034 26()
	{
		2034 result = null;
		this.10 = 0;
		this.9 = 0;
		foreach (2034 <<EMPTY_NAME>> in this.34)
		{
			if (this.27(<<EMPTY_NAME>>, true))
			{
				result = <<EMPTY_NAME>>;
			}
		}
		return result;
	}

	// Token: 0x06003BAA RID: 15274 RVA: 0x00177074 File Offset: 0x00175274
	internal bool 27(2034 1, bool 2)
	{
		if (1.GetDuration() > this.9)
		{
			if (2)
			{
				this.10 = 1;
				this.9 = 1.GetDuration();
			}
			return true;
		}
		if (2)
		{
			this.10++;
		}
		return false;
	}

	// Token: 0x06003BAB RID: 15275 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal virtual void AddCircleReplacingContainingObject(2034 1)
	{
	}

	// Token: 0x06003BAC RID: 15276 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal virtual void RemoveContainingObject(2034 1)
	{
	}

	// Token: 0x06003BAD RID: 15277 RVA: 0x001770B0 File Offset: 0x001752B0
	internal virtual void AddHitObject(2034 1, bool 2, bool 3)
	{
		2039.2043 4 = new 2039.2043();
		4.1 = 1;
		if (2)
		{
			2034 5 = this.36.Find(new Predicate<2034>(4.1));
			if (5 != null)
			{
				this.37.Add(5);
				this.29(5, false);
			}
		}
		int num = this.34.BinarySearch(4.1);
		if (num < 0)
		{
			num = ~num;
		}
		if (4.1.IsNewCombo() && num > 0)
		{
			this.34[num - 1].10 = true;
		}
		while (num < this.34.Count && this.34[num].1 == 4.1.1)
		{
			num++;
		}
		this.27(4.1, true);
		this.34.Insert(num, 4.1);
		this.44 = 4.1;
		if (3 && this.39 != null)
		{
			this.39.14<1433>(4.1.30);
		}
		this.35++;
	}

	// Token: 0x06003BAE RID: 15278 RVA: 0x001771C8 File Offset: 0x001753C8
	internal void 28(2034[] 1)
	{
		foreach (2034 2 in 1)
		{
			this.29(2, false);
		}
		this.2(false);
	}

	// Token: 0x06003BAF RID: 15279 RVA: 0x001771FC File Offset: 0x001753FC
	internal bool 29(2034 1, bool 2)
	{
		if (1 == null)
		{
			return false;
		}
		this.39.20<1433>(1.30);
		bool flag = this.34.Remove(1);
		if (flag)
		{
			if (1.GetDuration() == this.9)
			{
				this.10--;
				if (this.10 == 0)
				{
					this.26();
				}
			}
			this.35--;
		}
		this.36.Remove(1);
		if (2)
		{
			this.2(false);
		}
		if (1662.78 != 1677.Edit)
		{
			1.Dispose();
		}
		return flag;
	}

	// Token: 0x06003BB0 RID: 15280 RVA: 0x0017728C File Offset: 0x0017548C
	protected internal virtual void AddCircle(2072 1)
	{
		this.AddHitObject(1, false, true);
	}

	// Token: 0x06003BB1 RID: 15281 RVA: 0x0017728C File Offset: 0x0017548C
	protected internal virtual void AddSpinner(2070 1)
	{
		this.AddHitObject(1, false, true);
	}

	// Token: 0x06003BB2 RID: 15282 RVA: 0x0017728C File Offset: 0x0017548C
	protected internal virtual void AddSlider(2063 1)
	{
		this.AddHitObject(1, false, true);
	}

	// Token: 0x06003BB3 RID: 15283 RVA: 0x0001702D File Offset: 0x0001522D
	protected virtual bool UsesComboEndJudgements()
	{
		return true;
	}

	// Token: 0x06003BB4 RID: 15284 RVA: 0x00177298 File Offset: 0x00175498
	internal void 30(2039.2041 1)
	{
		2039.2041 2 = this.43;
		2039.2041 3;
		do
		{
			3 = 2;
			2039.2041 value = (2039.2041)Delegate.Combine(3, 1);
			2 = Interlocked.CompareExchange<2039.2041>(ref this.43, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x06003BB5 RID: 15285 RVA: 0x001772D0 File Offset: 0x001754D0
	internal void 31(2039.2041 1)
	{
		2039.2041 2 = this.43;
		2039.2041 3;
		do
		{
			3 = 2;
			2039.2041 value = (2039.2041)Delegate.Remove(3, 1);
			2 = Interlocked.CompareExchange<2039.2041>(ref this.43, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x06003BB6 RID: 15286 RVA: 0x00177305 File Offset: 0x00175505
	protected void 32(2149 1, string 2, 2034 3)
	{
		if (this.43 != null)
		{
			this.43(1, 2, 3);
		}
	}

	// Token: 0x06003BB7 RID: 15287 RVA: 0x00177320 File Offset: 0x00175520
	internal virtual 2149 JudgeHitObject(2034 1)
	{
		if (1.11)
		{
			return (2149)0;
		}
		this.38 = 1;
		2149 2 = 1.GetOrCalculateJudgement();
		int num = this.34.BinarySearch(1);
		this.31 = ((num < 0) ? (~num) : num);
		if (2 == (2149)0)
		{
			return 2;
		}
		bool flag = false;
		string text = string.Empty;
		if (2486.88 != null)
		{
			2023 3 = this.22;
			2023 4 = 2023.Perfect;
			if ((3 & 4) > 2023.None)
			{
				2149 5 = 2 & (2149)520095494;
				if (5 - (2149)256 <= 1 || 5 - (2149)512 <= 2)
				{
					2 = (2149)(-131072);
				}
			}
		}
		198 white = 198.White;
		int num2 = 0;
		string str;
		if (2 < (2149)0)
		{
			str = "hit0";
		}
		else
		{
			2149 6 = 2 & (2149)520095494;
			if (6 <= (2149)512)
			{
				if (6 == (2149)256)
				{
					str = "hit50";
					num2 = 50;
					new 198(byte.MaxValue, 216, 95);
					goto IL_1C6;
				}
				if (6 == (2149)512)
				{
					str = "hit100";
					num2 = 100;
					new 198(129, byte.MaxValue, 95);
					goto IL_1C6;
				}
			}
			else
			{
				if (6 == (2149)514)
				{
					str = "hit100k";
					num2 = 100;
					new 198(129, byte.MaxValue, 95);
					goto IL_1C6;
				}
				switch (6)
				{
				case (2149)1024:
					str = "hit300";
					num2 = 300;
					new 198(69, byte.MaxValue, byte.MaxValue);
					goto IL_1C6;
				case (2149)1026:
					str = "hit300k";
					num2 = 300;
					new 198(69, byte.MaxValue, byte.MaxValue);
					goto IL_1C6;
				case (2149)1028:
					str = "hit300g";
					num2 = 300;
					new 198(69, byte.MaxValue, byte.MaxValue);
					goto IL_1C6;
				}
			}
			str = string.Empty;
		}
		IL_1C6:
		if ((2 & (2149)65536) > (2149)0 && 2 > (2149)(-131072))
		{
			text = "k";
		}
		if (2 != (2149)(-131072) && 2 != (2149)256)
		{
			if (2 == (2149)512)
			{
				this.30++;
			}
		}
		else
		{
			this.29++;
		}
		if (this.UsesComboEndJudgements() && num >= 0 && (num == this.35 - 1 || (num < this.35 - 1 && this.34[num + 1].IsNewCombo())))
		{
			flag = true;
			bool flag2 = false;
			if (!(1 is 2129))
			{
				for (int i = num; i > -1; i--)
				{
					if (!this.34[i].11)
					{
						flag2 = true;
						break;
					}
					if (this.34[i].IsNewCombo())
					{
						break;
					}
				}
			}
			if (2 > (2149)0)
			{
				if (this.30 == 0 && this.29 == 0 && !flag2)
				{
					text = "g";
					2 |= (2149)4;
				}
				else if (this.29 == 0 && !flag2)
				{
					text = "k";
					2 |= (2149)2;
				}
				else
				{
					2 |= (2149)1;
				}
			}
			this.30 = 0;
			this.29 = 0;
		}
		1381 7 = null;
		1381[] judgementTextures = this.GetJudgementTextures(str + text);
		if (judgementTextures != null)
		{
			7 = 1455.2("particle" + num2.ToString(), judgementTextures[0].6, null);
		}
		bool flag3 = false;
		float num3;
		if (2486.14() == 2147.Taiko)
		{
			num3 = 0.96f;
		}
		else if (1 is 2129)
		{
			num3 = 1436.30((float)(1.1 + 20));
		}
		else if (7 == null && (1 is 2033 || 1 is 2123))
		{
			num3 = 1436.31((float)(2000 + 1.2 - 4));
		}
		else
		{
			flag3 = true;
			num3 = 1436.30((float)1.2);
		}
		1351 8 = new 1351(judgementTextures, (1376)1, 1065.Centre, (1044)2, 1.GetEndPosition(), num3, false, 198.White)
		{
			71 = 1446.LoopOnce
		};
		bool flag4 = 8.73 == 1;
		if (7 != null && flag3 && 2 > (2149)0)
		{
			1351 9 = (1351)8.Clone();
			9.2 = 1f;
			9.28 = true;
			9.15 = 0.9f;
			9.3.Add(new 1445(1456.Scale, 0.6f, 1.1f, 1226.16, (int)((double)1226.16 + (double)2039.18 * 0.8), (1046)0));
			9.3.Add(new 1445(1456.Scale, 1.1f, 0.9f, 1226.16 + 2039.18, (int)((double)1226.16 + (double)2039.18 * 1.2), (1046)0));
			9.3.Add(new 1445(1456.Scale, 0.9f, 1.05f, 1226.16, 1226.16 + 2039.20 + 2039.19, (1046)0));
			9.3.Add(new 1445(1456.Fade, 0f, 0.5f, 1226.16 - 16, 1226.16 + 40, (1046)1));
			9.3.Add(new 1445(1456.Fade, 0.5f, 0f, 1226.16 + 40, 1226.16 + 340, (1046)0));
			this.39.12(9);
		}
		if (2 > (2149)0 && 1304.91 && this.UsesHitLighting())
		{
			1433 10 = new 1433(1455.2("lighting", (1416)7, null), (1376)1, 1065.Centre, (1044)2, 1.GetEndPosition(), 0f, false, 1.7, null);
			if (!2630.21())
			{
				bool flag5 = 2486.103 && !1304.107 && !1304.54.1();
				int num4 = flag5 ? 300 : 600;
				float num5 = flag5 ? 2f : 1.85f;
				10.3.Add(new 1445(1456.Scale, 0.8f, num5, 1226.16, 1226.16 + num4, (1046)1));
				10.3.Add(new 1445(1456.Scale, num5, 2.2f, 1226.16 + num4, 1226.16 + 1400, (1046)0));
				10.3.Add(new 1445(1456.Fade, 1f, 0f, 1226.16, 1226.16 + 1400, (1046)0));
				10.28 = true;
				this.39.12(10);
			}
			else
			{
				10.3.Add(new 1445(1456.Scale, 0.8f, 1.2f, 1226.16, 1226.16 + 600, (1046)1));
				10.3.Add(new 1445(1456.Fade, 0f, 1f, 1226.16, 1226.16 + 200, (1046)0));
				10.3.Add(new 1445(1456.Fade, 1f, 0f, 1226.16 + 400, 1226.16 + 1400, (1046)0));
				10.28 = true;
				this.39.12(10);
			}
		}
		if (7 != null && 2 >= (2149)0)
		{
			2023 11 = this.22;
			2023 12 = 2023.Cinema;
			if ((11 & 12) <= 2023.None && 2486.14() == 2147.Osu)
			{
				this.39.12(new 1399(150, 70f, 0f, 7, (1376)1, 1065.Centre, (1044)2, 1.GetEndPosition(), 0f, true, 198.White)
				{
					28 = true
				});
			}
		}
		bool flag6 = 1.HasObjectType(2047.Spinner);
		if (2 == (2149)(-131072) && (!2486.21 || 1304.29.1()) && !2486.22)
		{
			8.3.Add(new 1445(1456.Fade, 0f, 1f, 1226.16, 1226.16 + 2039.18, (1046)0));
			if (flag4)
			{
				if (2486.88 != null && 1662.100.40 != 1653.Multiplaying)
				{
					2023 13 = this.22;
					2023 14 = 2023.SuddenDeath;
					if ((13 & 14) > 2023.None)
					{
						8.3.Add(new 1445(1456.Scale, 2f, 6f, 1226.16, 1226.16 + 600, (1046)0));
						goto IL_8BC;
					}
				}
				8.3.Add(new 1445(1456.Scale, 2f, 1f, 1226.16, 1226.16 + 2039.18, (1046)0));
				IL_8BC:
				float num6 = 1196.7(-0.15f, 0.15f);
				if (2630.21() && 2486.14() == 2147.Osu)
				{
					8.3.Add(new 1445(1456.Movement, 1.GetEndPosition() + new 208(0f, -5f), 1.GetEndPosition() + new 208(0f, 40f), 1226.16, 1226.16 + 2039.20 + 2039.19, (1046)2));
				}
				8.3.Add(new 1445(1456.Rotation, 0f, num6, 1226.16, 1226.16 + 2039.18, (1046)0));
				8.3.Add(new 1445(1456.Rotation, num6, num6 * 2f, 1226.16 + 2039.18, 1226.16 + 2039.20 + 2039.19, (1046)2));
			}
			8.3.Add(new 1445(1456.Fade, 1f, 0f, 1226.16 + 2039.20, 1226.16 + 2039.20 + 2039.19, (1046)0));
		}
		else if (2 > (2149)0)
		{
			if (flag6 && !2630.21())
			{
				1433 15 = new 1433(1455.2("spinner-osu", (1416)7, null), (1376)6, 1065.Centre, (1044)2, new 208(320f, 180f), (2486.14() == 2147.Osu) ? 0f : num3, false, 198.White, null);
				this.AnimateSpinnerJudgement(15);
				this.39.12(15);
			}
			this.AnimateHitJudgement(8, flag4, 7 != null);
		}
		this.OnJudgementSpriteCreated(8);
		this.39.12(8);
		if (flag && text.Length == 0)
		{
			text = "b";
		}
		if (this.43 != null)
		{
			this.43(2, text, 1);
		}
		if (this.32 != null)
		{
			this.32.31(1);
		}
		return 2;
	}

	// Token: 0x06003BB8 RID: 15288 RVA: 0x00005ADD File Offset: 0x00003CDD
	protected virtual void OnJudgementSpriteCreated(1433 1)
	{
	}

	// Token: 0x06003BB9 RID: 15289 RVA: 0x000CAF16 File Offset: 0x000C9116
	public virtual 1381[] GetJudgementTextures(string 1)
	{
		return 1455.5(1, (1416)7, true);
	}

	// Token: 0x06003BBA RID: 15290 RVA: 0x00177D54 File Offset: 0x00175F54
	protected virtual void AnimateSpinnerJudgement(1433 1)
	{
		1.3.Add(new 1445(1456.Fade, 0f, 1f, 1226.16, 1226.16 + 2039.18, (1046)0));
		1.3.Add(new 1445(1456.Fade, 1f, 0f, 1226.16 + 2039.20, 1226.16 + 2039.20 + 2039.19, (1046)0));
		this.39.12(1);
	}

	// Token: 0x06003BBB RID: 15291 RVA: 0x00177DD4 File Offset: 0x00175FD4
	protected virtual void AnimateHitJudgement(1433 1, bool 2, bool 3)
	{
		1.3.Add(new 1445(1456.Fade, 0f, 1f, 1226.16, 1226.16 + (3 ? 80 : 2039.18), (1046)0));
		if (2)
		{
			if (!3)
			{
				1.3.Add(new 1445(1456.Scale, 0.6f, 1.1f, 1226.16, (int)((double)1226.16 + (double)2039.18 * 0.8), (1046)0));
				1.3.Add(new 1445(1456.Scale, 1.1f, 0.9f, 1226.16 + 2039.18, (int)((double)1226.16 + (double)2039.18 * 1.2), (1046)0));
				1.3.Add(new 1445(1456.Scale, 0.9f, 1f, 1226.16 + 2039.18, (int)((double)1226.16 + (double)2039.18 * 1.4), (1046)0));
			}
			else
			{
				1.3.Add(new 1445(1456.Scale, 0.9f, 1.05f, 1226.16, 1226.16 + 2039.20 + 2039.19, (1046)0));
			}
		}
		1.3.Add(new 1445(1456.Fade, 1f, 0f, 1226.16 + 2039.20, 1226.16 + 2039.20 + 2039.19, (1046)0));
	}

	// Token: 0x06003BBC RID: 15292 RVA: 0x00177F44 File Offset: 0x00176144
	protected virtual void ProcessOverdueJudgement(2034 1)
	{
		if (!1535.56 && 1535.1())
		{
			return;
		}
		if (1.HasObjectType(2047.Slider))
		{
			2123 2 = (2123)1;
			if (1662.78 == 1677.Play)
			{
				if (2.1 + this.3 < 1226.16 && !2.IsHeadJudged() && 1662.78 == 1677.Play)
				{
					this.JudgeHitObject(2.58);
				}
				if (2._0003_2002_200A_2007_2007_2004_200A_2006_200A_2005_2005_2007_2009_2008_2002_2001_2005_2003_2001_200B() <= 1226.16 && !2.11)
				{
					this.JudgeHitObject(2);
					return;
				}
			}
		}
		else if (1.HasObjectType(2047.Spinner))
		{
			if (1._0003_2002_200A_2007_2007_2004_200A_2006_200A_2005_2005_2007_2009_2008_2002_2001_2005_2003_2001_200B() < 1226.16 && !1.11 && 1662.78 == 1677.Play)
			{
				this.JudgeHitObject(1);
				return;
			}
		}
		else if (1.2 + this.3 < 1226.16 && !1.11 && 1662.78 == 1677.Play)
		{
			this.JudgeHitObject(1);
		}
	}

	// Token: 0x06003BBD RID: 15293 RVA: 0x0001702D File Offset: 0x0001522D
	protected virtual bool UsesHitLighting()
	{
		return true;
	}

	// Token: 0x06003BBE RID: 15294 RVA: 0x00178028 File Offset: 0x00176228
	public static void 33(1244 1)
	{
		List<2039> obj = 2039.12;
		lock (obj)
		{
			if (2039.12.Count > 0 && 2039.12[0].32 != null)
			{
				2039.12[0].32.33(1);
			}
		}
	}

	// Token: 0x06003BBF RID: 15295 RVA: 0x00178098 File Offset: 0x00176298
	internal int 34()
	{
		if (1662.78 != 1677.Edit || 1304.83)
		{
			return 0;
		}
		return 800;
	}

	// Token: 0x06003BC0 RID: 15296 RVA: 0x001780B8 File Offset: 0x001762B8
	internal static void 35()
	{
		List<2039> obj = 2039.12;
		lock (obj)
		{
			foreach (2039 <<EMPTY_NAME>> in 2039.12)
			{
				if (1662.78 == 1677.Edit)
				{
					for (int i = 0; i < <<EMPTY_NAME>>.35; i++)
					{
						if (<<EMPTY_NAME>>.34[i].38)
						{
							<<EMPTY_NAME>>.34[i].PrepareRendering();
						}
					}
				}
				else if (2486.109 || 1662.78 != 1677.Play)
				{
					foreach (2034 2 in <<EMPTY_NAME>>.36)
					{
						if (2.38)
						{
							2.PrepareRendering();
						}
					}
					2050 3 = <<EMPTY_NAME>>.56;
					if (3 != null)
					{
						3.2();
					}
				}
			}
		}
	}

	// Token: 0x06003BC1 RID: 15297 RVA: 0x001781E4 File Offset: 0x001763E4
	internal static void 36()
	{
		List<2039> obj = 2039.12;
		lock (obj)
		{
			foreach (2039 <<EMPTY_NAME>> in 2039.12)
			{
				foreach (2034 2 in <<EMPTY_NAME>>.36)
				{
					2123 3 = 2 as 2123;
					if (3 != null)
					{
						3.36();
					}
				}
			}
		}
	}

	// Token: 0x06003BC2 RID: 15298 RVA: 0x001782A0 File Offset: 0x001764A0
	internal void 37(bool 1)
	{
		this.32.29(true, 2);
		if (!this.32.21.16)
		{
			this.32.21.28.ForEach(new Action<1371>(2039.2040.Instance.2));
			this.32.23.28.ForEach(delegate(1371 1)
			{
				1.11();
			});
			this.32.24.28.ForEach(new Action<1371>(2039.2040.Instance.3));
		}
	}

	// Token: 0x06003BC3 RID: 15299 RVA: 0x0017834C File Offset: 0x0017654C
	internal void 38()
	{
		if (this.21.32 > 5)
		{
			foreach (2034 <<EMPTY_NAME>> in this.34)
			{
				2123 2 = <<EMPTY_NAME>> as 2123;
				if (2 != null)
				{
					2.RebuildPathAndTiming(true);
				}
			}
			this.39(0, -1);
			return;
		}
		this.40();
	}

	// Token: 0x06003BC4 RID: 15300 RVA: 0x001783C4 File Offset: 0x001765C4
	internal void 39(int 1, int 2)
	{
		if (this.21.3() != 2147.Osu)
		{
			return;
		}
		if (2 == -1)
		{
			2 = this.35 - 1;
		}
		208 3 = new 208(this.8, this.8);
		float num = (float)this.StackingPreemptTime * this.21.83;
		for (int i = 1; i <= 2; i++)
		{
			this.34[i].9 = 0;
		}
		int num2 = 2;
		for (int j = 2; j >= 1; j--)
		{
			int num3 = j;
			for (int k = num3 + 1; k < this.35; k++)
			{
				2034 4 = this.34[num3];
				if (4 is 2070)
				{
					break;
				}
				2034 5 = this.34[k];
				if (!(5 is 2070))
				{
					if ((float)(5.1 - 4.2) > num)
					{
						break;
					}
					if (208.Distance(4.18, 5.18) < 3f || (4 is 2063 && 208.Distance(4.1(), 5.18) < 3f))
					{
						num3 = k;
						5.9 = 0;
					}
				}
			}
			if (num3 > num2)
			{
				num2 = num3;
				if (num2 == this.35 - 1)
				{
					break;
				}
			}
		}
		int num4 = 1;
		for (int l = num2; l > 1; l--)
		{
			int num5 = l;
			2034 6 = this.34[l];
			if (6.9 == 0 && !(6 is 2070))
			{
				if (6 is 2072)
				{
					while (--num5 >= 0)
					{
						2034 7 = this.34[num5];
						if (!(7 is 2070))
						{
							if ((float)(6.1 - 7.2) > num)
							{
								break;
							}
							if (num5 < num4)
							{
								7.9 = 0;
								num4 = num5;
							}
							if (7 is 2063 && 208.Distance(7.1(), 6.18) < 3f)
							{
								int num6 = 6.9 - 7.9 + 1;
								for (int m = num5 + 1; m <= l; m++)
								{
									if (208.Distance(7.1(), this.34[m].18) < 3f)
									{
										this.34[m].9 -= num6;
									}
								}
								break;
							}
							if (208.Distance(7.18, 6.18) < 3f)
							{
								7.9 = 6.9 + 1;
								6 = 7;
							}
						}
					}
				}
				else if (6 is 2063)
				{
					while (--num5 >= 1)
					{
						2034 8 = this.34[num5];
						if (!(8 is 2070))
						{
							if ((float)(6.1 - 8.1) > num)
							{
								break;
							}
							if (208.Distance(8.1(), 6.18) < 3f)
							{
								8.9 = 6.9 + 1;
								6 = 8;
							}
						}
					}
				}
			}
		}
		for (int n = 1; n <= 2; n++)
		{
			2034 9 = this.34[n];
			9.SetPosition(9.18 - (float)9.9 * 3, true);
		}
	}

	// Token: 0x06003BC5 RID: 15301 RVA: 0x00178728 File Offset: 0x00176928
	private void 40()
	{
		208 <<EMPTY_NAME>> = new 208(this.8, this.8);
		for (int i = 0; i < this.35; i++)
		{
			2034 2 = this.34[i];
			if (2 is 2123)
			{
				((2123)2).RebuildPathAndTiming(true);
			}
			int 3 = 2.2;
			if (2.9 == 0 || 2.HasObjectType(2047.Slider))
			{
				int num = 0;
				float num2 = (float)this.StackingPreemptTime;
				int num3 = i + 1;
				while (num3 < this.35 && (float)this.34[num3].1 - num2 * this.21.83 <= (float)3)
				{
					if (208.Distance(this.34[num3].8, 2.8) < 3f)
					{
						2.9++;
						3 = this.34[num3].2;
					}
					else if (208.Distance(this.34[num3].8, 2.GetCurrentPosition()) < 3f)
					{
						num++;
						this.34[num3].9 -= num;
						3 = this.34[num3].2;
					}
					num3++;
				}
			}
			if (2.9 != 0)
			{
				2.SetPosition(2.8 - (float)2.9 * <<EMPTY_NAME>>, true);
			}
		}
	}

	// Token: 0x06003BC6 RID: 15302 RVA: 0x001788B0 File Offset: 0x00176AB0
	internal void 41()
	{
		this.34.ForEach(new Action<2034>(2039.2040.Instance.4));
	}

	// Token: 0x06003BC7 RID: 15303 RVA: 0x001788D0 File Offset: 0x00176AD0
	internal void 42(int 1, int 2)
	{
		if (2 == -1)
		{
			2 = this.35 - 1;
		}
		1381[] 3 = 1455.5("followpoint", (1416)7, true);
		int num = 0;
		for (int i = 1 + 1; i <= 2; i++)
		{
			2034 4 = this.34[i];
			if (!4.IsNewCombo() && !this.34[i - 1].HasObjectType(2047.Spinner) && !this.34[i].HasObjectType(2047.Spinner))
			{
				208 endPosition = this.34[i - 1].GetEndPosition();
				int 5 = this.34[i - 1].2;
				208 6 = 4.8;
				int 7 = 4.1;
				int num2 = (int)208.Distance(endPosition, 6);
				208 8 = 6 - endPosition;
				int num3 = 7 - 5;
				float num4 = (float)Math.Atan2((double)(6.Y - endPosition.Y), (double)(6.X - endPosition.X));
				for (int j = (int)((double)2039.15 * 1.5); j < num2 - 2039.15; j += 2039.15)
				{
					float num5 = (float)j / (float)num2;
					208 9 = endPosition + (num5 - 0.1f) * 8;
					208 10 = endPosition + num5 * 8;
					int num6 = (int)((float)5 + num5 * (float)num3) - 2039.17;
					int num7 = (int)((float)5 + num5 * (float)num3);
					1351 11;
					if (num < this.42.Count)
					{
						11 = this.42[num];
						11.17 = 10;
						foreach (1445 12 in 11.3)
						{
							if (12.14 == 1456.Fade && 12.5 == 0f)
							{
								12.9 = num7;
								12.10 = num7 + 2039.13;
							}
							else
							{
								12.9 = num6;
								12.10 = num6 + 2039.13;
							}
							if (12.14 == 1456.Movement)
							{
								12.2 = 9;
								12.6 = 10;
							}
						}
						11.59();
					}
					else
					{
						11 = new 1351(3, (1376)1, 1065.Centre, (1044)1, 10, 0f, false, 198.White, null);
						11.61();
						11.3.Add(new 1445(1456.Fade, 0f, 1f, num6, num6 + 2039.13, (1046)0));
						if (2630.20() && 1662.112)
						{
							11.3.Add(new 1445(1456.Scale, 1.5f, 1f, num6, num6 + 2039.13, (1046)1));
							11.3.Add(new 1445(1456.Movement, 9, 10, num6, num6 + 2039.13, (1046)1));
						}
						11.3.Add(new 1445(1456.Fade, 1f, 0f, num7, num7 + 2039.13, (1046)0));
						if (1662.78 == 1677.Edit)
						{
							this.42.Add(11);
						}
					}
					11.14 = num4;
					this.39.12(11);
					num++;
				}
			}
		}
	}

	// Token: 0x06003BC8 RID: 15304 RVA: 0x00178C28 File Offset: 0x00176E28
	public bool 43()
	{
		1290 <<EMPTY_NAME>> = this.21.105;
		return <<EMPTY_NAME>> != 1290.Below && (<<EMPTY_NAME>> == 1290.Above || 2630.5.OverlayAboveNumber);
	}

	// Token: 0x06003BC9 RID: 15305 RVA: 0x00178C5D File Offset: 0x00176E5D
	private void 44(2034 1)
	{
		1.30.ForEach(new Action<1433>(this.39.12));
	}

	// Token: 0x06003BCA RID: 15306 RVA: 0x00178C7B File Offset: 0x00176E7B
	internal bool 45()
	{
		bool result = this.46(true, false);
		this.37(false);
		this.32.39();
		return result;
	}

	// Token: 0x06003BCB RID: 15307 RVA: 0x00178C98 File Offset: 0x00176E98
	internal bool 46(bool 1, bool 2)
	{
		this.ClearBeatmapResources();
		if (5)
		{
			this.21.65();
		}
		if (this.32 != null)
		{
			this.32.Dispose();
		}
		this.32 = new 2648(this);
		if (1662.78 != 1677.Edit)
		{
			this.39.2(true);
			this.32.21.2(true);
			this.32.23.2(true);
			this.32.24.2(true);
		}
		this.RecalculateDifficulty(false, true, true);
		if (!this.26)
		{
			if (this.25 == null)
			{
				this.25 = new List<int>();
			}
			else
			{
				this.25.Clear();
			}
		}
		this.26 = false;
		this.7();
		bool flag = this.21.28;
		if (flag)
		{
			try
			{
				this.48(1288.All, true, 2, false);
			}
			catch (Exception ex)
			{
				string str = 1568.1(2679.HitObjectManager_LoadSave_BeatmapFailLoad);
				if (ex is 2025)
				{
					str += string.Format(1568.1(2679.HitObjectManager_LoadSave_StoryboardErrorOnLine), ((2025)ex).1);
				}
				if (1662.78 == 1677.Edit && DialogResult.Yes != 1763.9(str + 1568.1(2679.HitObjectManager_LoadSave_EditAsNewMap), MessageBoxButtons.YesNo, MessageBoxIcon.Hand))
				{
					1763.9("osu! will do its best to load what it can of the map...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				else
				{
					this.7();
					flag = false;
				}
			}
		}
		this.2(false);
		List<1253> list = new List<1253>();
		foreach (1259 3 in this.21.94)
		{
			if (3.2 > 1253.Custom2 && !list.Contains(3.2))
			{
				list.Add(3.2);
			}
		}
		foreach (2034 4 in this.34)
		{
			if (4.37 > 1253.Custom2 && !list.Contains(4.37))
			{
				list.Add(4.37);
			}
		}
		list.ForEach(delegate(1253 1)
		{
			1226.52(1);
		});
		1226.53();
		1226.25 = 1254.None;
		if (this.21.32 < 4 || !flag)
		{
			1226.59(this.21.48, false);
		}
		this.PrepareHitObjects();
		this.32.40();
		if (1662.78 != 1677.Edit)
		{
			this.39.2(false);
			this.14();
			this.32.22.2(false);
			this.32.21.2(false);
			this.32.23.2(false);
			this.32.24.2(false);
		}
		if (1662.78 == 1677.Edit || 2486.14() == 2147.Osu)
		{
			2630.12(this);
		}
		return flag;
	}

	// Token: 0x06003BCC RID: 15308 RVA: 0x00178FB8 File Offset: 0x001771B8
	internal void 47(2023 1)
	{
		this.22 = 1;
		this.39.2(true);
		this.RecalculateDifficulty(false, false, true);
		List<1371> list = (this.57 == null) ? null : this.39.18(this.57);
		this.7();
		this.33.ResetState();
		this.OnHitObjectsReloading();
		this.48((1288)66, false, false, false);
		this.2(false);
		this.PrepareHitObjects();
		this.39.2(false);
		this.14();
		if (list != null)
		{
			this.39.14<1371>(list);
		}
		2630.12(this);
		this.38 = null;
	}

	// Token: 0x06003BCD RID: 15309 RVA: 0x00005ADD File Offset: 0x00003CDD
	protected virtual void OnHitObjectsReloading()
	{
	}

	// Token: 0x06003BCE RID: 15310 RVA: 0x00179060 File Offset: 0x00177260
	protected virtual void ClearBeatmapResources()
	{
		1226.108();
		1226.57();
		2630.3.Clear();
	}

	// Token: 0x06003BCF RID: 15311 RVA: 0x00179078 File Offset: 0x00177278
	internal void 48(1288 1, bool 2, bool 3, bool 4)
	{
		1288 5 = 1288.Unknown;
		if (2)
		{
			this.21.70();
		}
		this.ResetConversionState();
		List<string> list = new List<string>();
		list.Add(this.21.58);
		string text = this.21.67();
		bool flag = this.21.52(text);
		if (flag && (1 & (1288)288) == 1288.Unknown)
		{
			this.11 = true;
		}
		else if (flag)
		{
			1262 6 = this.21;
			byte[] array = this.21.49(text);
			1262 7 = 6;
			MD5 8 = 1209.1;
			string text2;
			lock (8)
			{
				try
				{
					array = 1209.1.ComputeHash(array);
				}
				catch (Exception)
				{
					text2 = "fail";
					goto IL_105;
				}
			}
			char[] array2 = new char[array.Length * 2];
			for (int i = 0; i < array.Length; i++)
			{
				array[i].ToString("x2", 1209.3).CopyTo(0, array2, i * 2, 2);
			}
			string text3 = new string(array2);
			goto IL_109;
			IL_105:
			text3 = text2;
			IL_109:
			string text4 = text3;
			7.24 = text4;
			this.11 = true;
			list.Add(text);
		}
		bool flag3 = false;
		bool flag4 = false;
		int num;
		if (1662.78 == 1677.Play || 4)
		{
			2023 9 = this.22;
			2023 10 = 2023.HardRock;
			num = (((9 & 10) > 2023.None) ? 1 : 0);
		}
		else
		{
			num = 0;
		}
		bool flag5 = (byte)num > 0;
		bool flag6 = this is 2122;
		bool flag7 = flag6 && this.47 != null && this.47.FlipsHorizontally;
		int num2 = 0;
		flag5 |= (flag6 && this.47 != null && this.47.FlipsVertically);
		this.40 = new Dictionary<string, string>();
		for (int j = 0; j < list.Count; j++)
		{
			TextReader textReader = new StreamReader(this.21.48(list[j]));
			try
			{
				int num3 = 0;
				string text5 = null;
				bool flag8 = true;
				for (;;)
				{
					if (flag8)
					{
						text5 = textReader.ReadLine();
						if (text5 == null)
						{
							break;
						}
						num3++;
					}
					flag8 = true;
					if (text5.Length != 0 && !text5.StartsWith(" ") && !text5.StartsWith("_") && !text5.StartsWith("//"))
					{
						try
						{
							if (5 == 1288.Events)
							{
								this.50(ref text5);
							}
						}
						catch (Exception 11)
						{
							throw new 2025(num3, 11);
						}
						if (text5[0] == '[')
						{
							try
							{
								5 = (1288)Enum.Parse(typeof(1288), text5.Trim(new char[]
								{
									'[',
									']'
								}));
								continue;
							}
							catch (Exception)
							{
								continue;
							}
						}
						if ((1 & 5) > 1288.Unknown)
						{
							string[] array3 = text5.Trim().Split(new char[]
							{
								','
							});
							string[] array4 = text5.Trim().Split(new char[]
							{
								':'
							});
							string text6 = string.Empty;
							string text7 = string.Empty;
							if (array4.Length > 1)
							{
								text6 = array4[0].Trim();
								text7 = array4[1].Trim();
							}
							if (5 <= 1288.Events)
							{
								switch (5)
								{
								case 1288.General:
									if (text6 == "EditorBookmarks")
									{
										foreach (string text8 in text7.Split(new char[]
										{
											','
										}))
										{
											if (text8.Length > 0)
											{
												int item = int.Parse(text8);
												if (!this.25.Contains(item))
												{
													this.25.Add(item);
												}
											}
										}
										continue;
									}
									if (text6 == "EditorDistanceSpacing")
									{
										1304.138.SetValue(Convert.ToDouble(text7, 1662.18));
										continue;
									}
									if (text6 == "StoryFireInFront")
									{
										this.21.84 = (text7[0] == '1');
										continue;
									}
									if (text6 == "UseSkinSprites")
									{
										this.21.88 = (text7[0] == '1');
										continue;
									}
									continue;
								case 1288.Colours:
									if (!flag3)
									{
										flag3 = true;
										for (int l = 1; l <= 8; l++)
										{
											2630.3["Combo" + l.ToString()] = 198.TransparentWhite;
										}
									}
									if (this.21.1() || 1662.78 == 1677.Edit)
									{
										string[] array6 = text7.Split(new char[]
										{
											','
										});
										2630.3[text6] = new 198((byte)Convert.ToInt32(array6[0]), (byte)Convert.ToInt32(array6[1]), (byte)Convert.ToInt32(array6[2]));
										continue;
									}
									continue;
								case (1288)3:
									continue;
								case 1288.Editor:
									if (1662.78 != 1677.Edit && !1662.84)
									{
										continue;
									}
									if (text6 == "Bookmarks")
									{
										foreach (string text9 in text7.Split(new char[]
										{
											','
										}))
										{
											if (text9.Length > 0)
											{
												int item2 = int.Parse(text9);
												if (!this.25.Contains(item2))
												{
													this.25.Add(item2);
												}
											}
										}
										continue;
									}
									if (text6 == "DistanceSpacing")
									{
										1304.138.SetValue(Convert.ToDouble(text7, 1662.18));
										continue;
									}
									if (text6 == "BeatDivisor")
									{
										1304.144.7(Convert.ToInt32(text7, 1662.18));
										continue;
									}
									if (text6 == "GridSize")
									{
										1304.145.7(Convert.ToInt32(text7, 1662.18));
										continue;
									}
									if (text6 == "TimelineZoom")
									{
										this.21.86 = (float)Convert.ToDecimal(text7, 1662.18);
										continue;
									}
									continue;
								default:
									if (5 != 1288.Events)
									{
										continue;
									}
									try
									{
										2647 12 = null;
										2635 13;
										try
										{
											13 = (2635)Enum.Parse(typeof(2635), array3[0]);
										}
										catch (ThreadAbortException)
										{
											return;
										}
										catch
										{
											MessageBox.Show(string.Format(1568.1(2679.HitObjectManager_LoadSave_StoryboardErrorOnLine_2), list[j], num3, text5) + 1568.1(2679.HitObjectManager_LoadSave_StoryboardErrorContent_1));
											continue;
										}
										switch (13)
										{
										case 2635.Background:
										case 2635.Video:
											12 = this.32.11(array3[2].Trim(new char[]
											{
												'"'
											}), int.Parse(array3[1], 1662.18) + this.21.90);
											if (12 != null)
											{
												if (12.7 != null && array3.Length > 4)
												{
													208 14 = new 208((float)int.Parse(array3[3]), (float)int.Parse(array3[4]));
													if (14 != 208.One)
													{
														12.7.17 = 14;
													}
												}
												12.4 = num3;
												12.11 = (j == 0);
											}
											break;
										case 2635.Break:
											if (j > 0)
											{
												continue;
											}
											12 = new 2275(int.Parse(array3[1], 1662.18) + this.21.90, int.Parse(array3[2], 1662.18) + this.21.90, true);
											12.4 = num3;
											12.11 = true;
											if (12.GetDuration() >= 650)
											{
												this.32.9(12);
											}
											break;
										case 2635.Sprite:
											try
											{
												12 = new 2655(2672.26(array3[3]), new 208(float.Parse(array3[4], 1662.18), float.Parse(array3[5], 1662.18)), (1065)Enum.Parse(typeof(1065), array3[2]), (2645)Enum.Parse(typeof(2645), array3[1]), this.21.88);
												12.4 = num3;
												12.11 = (j == 0);
											}
											catch (Exception)
											{
												continue;
											}
											this.32.9(12);
											break;
										case 2635.Sample:
											try
											{
												string text10 = 2672.26(array3[3]);
												12 = new 2654(1226.49(text10, false, true, false), text10, int.Parse(array3[1], 1662.18) + this.21.90, (2645)Enum.Parse(typeof(2645), array3[2]), (array3.Length > 4) ? Math.Min(100, Math.Max(0, int.Parse(array3[4], 1662.18))) : 100);
												12.4 = num3;
												12.11 = (j == 0);
											}
											catch
											{
											}
											this.32.9(12);
											break;
										case 2635.Animation:
											try
											{
												12 = new 2646(2672.26(array3[3]), new 208(float.Parse(array3[4], 1662.18), float.Parse(array3[5], 1662.18)), (1065)Enum.Parse(typeof(1065), array3[2]), (2645)Enum.Parse(typeof(2645), array3[1]), int.Parse(array3[6]), double.Parse(array3[7], 1662.18), this.21.88, (1446)((array3.Length > 8) ? Enum.Parse(typeof(1446), array3[8]) : 1446.LoopForever));
												12.4 = num3;
												12.11 = (j == 0);
											}
											catch
											{
												continue;
											}
											this.32.9(12);
											break;
										}
										text5 = textReader.ReadLine();
										if (text5 != null)
										{
											this.50(ref text5);
											num3++;
											1457 15 = null;
											bool flag9 = false;
											while (text5.Trim().Length > 0 && (text5[0] == ' ' || text5[0] == '_'))
											{
												try
												{
													if (2648.1() || 13 == 2635.Video || 13 == 2635.Sprite || 13 == 2635.Animation)
													{
														array3 = text5.Trim(new char[]
														{
															' ',
															'_'
														}).Split(new char[]
														{
															','
														});
														int num4 = 1;
														int num5 = array3.Length;
														if (text5[1] != ' ' && text5[1] != '_')
														{
															15 = null;
														}
														1046 16 = (1046)0;
														int num6 = 0;
														int num7 = 0;
														int num8 = 0;
														string text11 = array3[0];
														if (!(text11 == "L") && !(text11 == "T"))
														{
															16 = (1046)int.Parse(array3[num4++]);
															num6 = int.Parse(array3[num4++]) + this.21.90;
															if (array3[num4].Length == 0)
															{
																num7 = num6;
																num4++;
															}
															else
															{
																num7 = int.Parse(array3[num4++]) + this.21.90;
															}
															num8 = num7 - num6;
														}
														if (num7 > this.32.31)
														{
															this.32.31 = num7;
														}
														if (num6 < this.32.32)
														{
															this.32.32 = num6;
														}
														bool flag10 = true;
														int num9 = -1;
														while (num4 < num5 && num9 != num4)
														{
															num9 = num4;
															1445 17 = null;
															text11 = array3[0];
															uint num10 = 1197.1(text11);
															if (num10 <= 3356228888U)
															{
																if (num10 <= 736079187U)
																{
																	if (num10 != 719301568U)
																	{
																		if (num10 == 736079187U)
																		{
																			if (text11 == "MY")
																			{
																				num4 -= ((!flag10) ? 1 : 0);
																				bool flag11 = num4 == num5 - 1;
																				float num11 = float.Parse(array3[num4++], 1662.18);
																				float 18 = flag11 ? num11 : float.Parse(array3[num4++], 1662.18);
																				17 = new 1445(1456.MovementY, num11, 18, num6, num7, (1046)0);
																			}
																		}
																	}
																	else if (text11 == "MX")
																	{
																		num4 -= ((!flag10) ? 1 : 0);
																		bool flag12 = num4 == num5 - 1;
																		float num12 = float.Parse(array3[num4++], 1662.18);
																		float 19 = flag12 ? num12 : float.Parse(array3[num4++], 1662.18);
																		17 = new 1445(1456.MovementX, num12, 19, num6, num7, (1046)0);
																	}
																}
																else if (num10 != 3272340793U)
																{
																	if (num10 != 3322673650U)
																	{
																		if (num10 == 3356228888U)
																		{
																			if (text11 == "M")
																			{
																				num4 -= ((!flag10) ? 2 : 0);
																				bool flag13 = num4 == num5 - 2;
																				208 20 = new 208(float.Parse(array3[num4++], 1662.18), float.Parse(array3[num4++], 1662.18));
																				208 21 = flag13 ? 20 : new 208(float.Parse(array3[num4++], 1662.18), float.Parse(array3[num4++], 1662.18));
																				17 = new 1445(20, 21, num6, num7, (1046)0);
																			}
																		}
																	}
																	else if (text11 == "C")
																	{
																		num4 -= ((!flag10) ? 3 : 0);
																		bool flag14 = num4 == num5 - 3;
																		198 22 = new 198(byte.Parse(array3[num4++]), byte.Parse(array3[num4++]), byte.Parse(array3[num4++]));
																		198 23 = flag14 ? 22 : new 198(byte.Parse(array3[num4++]), byte.Parse(array3[num4++]), byte.Parse(array3[num4++]));
																		17 = new 1445(22, 23, num6, num7);
																	}
																}
																else if (text11 == "F")
																{
																	num4 -= ((!flag10) ? 1 : 0);
																	bool flag15 = num4 == num5 - 1;
																	float num13 = float.Parse(array3[num4++], 1662.18);
																	float 24 = flag15 ? num13 : float.Parse(array3[num4++], 1662.18);
																	17 = new 1445(1456.Fade, num13, 24, num6, num7, (1046)0);
																}
															}
															else if (num10 <= 3540782697U)
															{
																if (num10 != 3373006507U)
																{
																	if (num10 != 3507227459U)
																	{
																		if (num10 == 3540782697U)
																		{
																			if (text11 == "V")
																			{
																				num4 -= ((!flag10) ? 2 : 0);
																				bool flag16 = num4 == num5 - 2;
																				208 25 = new 208(float.Parse(array3[num4++], 1662.18), float.Parse(array3[num4++], 1662.18));
																				208 26 = flag16 ? 25 : new 208(float.Parse(array3[num4++], 1662.18), float.Parse(array3[num4++], 1662.18));
																				17 = new 1445(1456.VectorScale, 25, 26, num6, num7, (1046)0);
																			}
																		}
																	}
																	else if (text11 == "T")
																	{
																		2656 27 = 2656.5(array3[num4++]);
																		if (array3.Length > 2)
																		{
																			num6 = int.Parse(array3[num4++]) + this.21.90;
																			num7 = int.Parse(array3[num4++]) + this.21.90;
																		}
																		if (array3.Length > 4)
																		{
																			2659 28 = (2659)(-(2659)int.Parse(array3[num4++]));
																			if (28 != 2659.None)
																			{
																				27.4(28);
																			}
																		}
																		15 = new 2657(27, num6, num7);
																		if (((12 != null) ? 12.7 : null) != null)
																		{
																			12.1(15 as 2657);
																		}
																	}
																}
																else if (text11 == "L")
																{
																	15 = new 1457(int.Parse(array3[num4++]) + this.21.90, int.Parse(array3[num4++]));
																	if (((12 != null) ? 12.7 : null) != null)
																	{
																		if (12.7.4 == null)
																		{
																			12.7.4 = new List<1457>();
																		}
																		12.7.4.Add(15);
																	}
																}
															}
															else if (num10 != 3574337935U)
															{
																if (num10 != 3591115554U)
																{
																	if (num10 == 3607893173U)
																	{
																		if (text11 == "R")
																		{
																			num4 -= ((!flag10) ? 1 : 0);
																			bool flag17 = num4 == num5 - 1;
																			float num14 = float.Parse(array3[num4++], 1662.18);
																			float 29 = flag17 ? num14 : float.Parse(array3[num4++], 1662.18);
																			17 = new 1445(1456.Rotation, num14, 29, num6, num7, (1046)0);
																		}
																	}
																}
																else if (text11 == "S")
																{
																	num4 -= ((!flag10) ? 1 : 0);
																	bool flag18 = num4 == num5 - 1;
																	float num15 = float.Parse(array3[num4++], 1662.18);
																	float 30 = flag18 ? num15 : float.Parse(array3[num4++], 1662.18);
																	17 = new 1445(1456.Scale, num15, 30, num6, num7, (1046)0);
																}
															}
															else if (text11 == "P")
															{
																num4 -= ((!flag10) ? 3 : 0);
																17 = new 1445();
																17.9 = num6;
																17.10 = num7;
																string a = array3[num4++];
																if (!(a == "H"))
																{
																	if (!(a == "V"))
																	{
																		if (a == "A")
																		{
																			if (12.7 != null && 17.1() == 0)
																			{
																				12.7.28 = true;
																			}
																			17.14 = 1456.ParameterAdditive;
																		}
																	}
																	else
																	{
																		if (12.7 != null && 17.1() == 0)
																		{
																			12.7.43(true);
																		}
																		17.14 = 1456.ParameterFlipVertical;
																	}
																}
																else
																{
																	if (12.7 != null && 17.1() == 0)
																	{
																		12.7.45(true);
																	}
																	17.14 = 1456.ParameterFlipHorizontal;
																}
															}
															if (17 != null)
															{
																17.15 = 16;
																if (15 != null)
																{
																	15.3.Method11157(17);
																	if (!flag9 || 15.2 < 12.8)
																	{
																		12.8 = 15.2;
																		flag9 = true;
																	}
																}
																else if (((12 != null) ? 12.7 : null) != null)
																{
																	12.7.3.Method11157(17);
																	if (!flag9 || num6 < 12.8)
																	{
																		12.8 = num6;
																		flag9 = true;
																	}
																}
															}
															num6 += num8;
															num7 += num8;
															flag10 = false;
														}
													}
												}
												catch (ThreadAbortException)
												{
												}
												catch (Exception ex)
												{
													MessageBox.Show(string.Format(1568.1(2679.HitObjectManager_LoadSave_StoryboardErrorOnLine_2) + "\n\n" + ex.Message, list[j], num3, text5));
												}
												finally
												{
													text5 = textReader.ReadLine();
													this.50(ref text5);
													num3++;
												}
											}
											if (12 != null && 12.7 != null && this.32.21.16 && 12.10 != 2635.Background && 12.10 != 2635.Video)
											{
												12.7.11();
												2645 31 = 12.5;
												if (31 != 2645.Background)
												{
													if (31 != 2645.Overlay)
													{
														this.32.23.12(12.7);
													}
													else
													{
														this.32.24.12(12.7);
													}
												}
												else
												{
													this.32.21.12(12.7);
												}
											}
											flag8 = false;
										}
										continue;
									}
									catch (Exception 32)
									{
										throw new 2025(num3, 32);
									}
									break;
								}
							}
							else if (5 != 1288.HitObjects)
							{
								if (5 != 1288.Variables)
								{
									continue;
								}
								string[] array7 = text5.Split(new char[]
								{
									'='
								});
								if (array7.Length == 2)
								{
									this.40.Add(array7[0], array7[1]);
									continue;
								}
								continue;
							}
							if (j <= 0)
							{
								if (!flag4)
								{
									this.LoadComboColours(false);
									flag4 = true;
								}
								try
								{
									2047 33 = (2047)(2678.3(array3[3], int.MaxValue, 3) & -113);
									1245 34 = (1245)2678.3(array3[4], int.MaxValue, 3);
									int num16 = (int)Math.Max(0f, Math.Min(512f, 2678.1(array3[0], 131072f, 3)));
									int num17 = (int)Math.Max(0f, Math.Min(512f, 2678.1(array3[1], 131072f, 3)));
									208 35 = new 208((float)(flag7 ? (512 - num16) : num16), (float)(flag5 ? (384 - num17) : num17));
									int num18 = num2++;
									2117.2118 36 = (this.50 != null && num18 < this.50.11.Length) ? this.50.11[num18] : null;
									208 37 = 35;
									if (36 != null && !36.4)
									{
										35 = 36.1;
									}
									int num19 = (int)2678.2(array3[2], 2147483647.0, 3) + this.21.90;
									int num20 = Convert.ToInt32(array3[3], 1662.18) >> 4 & 7;
									bool flag19 = 33.1(2047.NewCombo);
									1254 38 = 1254.None;
									1254 39 = 1254.None;
									1253 40 = 1253.Default;
									string 41 = string.Empty;
									int 42 = 0;
									if (33.1(2047.Normal))
									{
										if (array3.Length > 5 && array3[5].Length > 0)
										{
											string[] array8 = array3[5].Split(new char[]
											{
												':'
											});
											38 = (1254)Convert.ToInt32(array8[0]);
											39 = (1254)Convert.ToInt32(array8[1]);
											40 = (1253)((array8.Length > 2) ? Convert.ToInt32(array8[2]) : 0);
											42 = ((array8.Length > 3) ? 1052.18(int.Parse(array8[3]), 0, 100) : 0);
											41 = ((array8.Length > 4) ? array8[4] : string.Empty);
										}
										2072 43 = this.33.CreateCircle(35, num19, this.5() || flag19, 34, flag19 ? num20 : 0, 38, 39, 40, 42, 41);
										43.19 = num18;
										43.20 = flag19;
										this.AddCircle(43);
									}
									else if (33.1(2047.Slider))
									{
										2064 44 = 2064.Catmull;
										int num21 = 0;
										double num22 = 0.0;
										List<208> list2 = new List<208>();
										List<1245> list3 = null;
										string[] array9 = array3[5].Split(new char[]
										{
											'|'
										});
										for (int m = 0; m < array9.Length; m++)
										{
											if (array9[m].Length == 1)
											{
												string a2 = array9[m];
												if (!(a2 == "C"))
												{
													if (!(a2 == "B"))
													{
														if (!(a2 == "L"))
														{
															if (a2 == "P")
															{
																44 = 2064.PerfectCurve;
															}
														}
														else
														{
															44 = 2064.Linear;
														}
													}
													else
													{
														44 = 2064.Bezier;
													}
												}
												else
												{
													44 = 2064.Catmull;
												}
											}
											else
											{
												string[] array10 = array9[m].Split(new char[]
												{
													':'
												});
												208 item3 = new 208((float)((int)(flag7 ? (512.0 - 2678.2(array10[0], 131072.0, 3)) : 2678.2(array10[0], 131072.0, 3))), (float)((int)(flag5 ? (384.0 - 2678.2(array10[1], 131072.0, 3)) : 2678.2(array10[1], 131072.0, 3))));
												list2.Add(item3);
											}
										}
										num21 = 2678.3(array3[6], int.MaxValue, 3);
										if (num21 > 9000)
										{
											throw new ArgumentOutOfRangeException(1568.1(2679.HitObjectManager_LoadSave_ErrorTooManyRepeats));
										}
										if (array3.Length > 7)
										{
											num22 = 2678.2(array3[7], 2147483647.0, 3);
										}
										if (array3.Length > 8 && array3[8].Length > 0)
										{
											string[] array11 = array3[8].Split(new char[]
											{
												'|'
											});
											if (array11.Length != 0)
											{
												list3 = new List<1245>();
												int num23 = Math.Min(array11.Length, num21 + 1);
												int n;
												for (n = 0; n < num23; n++)
												{
													int item4;
													int.TryParse(array11[n], out item4);
													list3.Add((1245)item4);
												}
												while (n < num21 + 1)
												{
													list3.Add(34);
													n++;
												}
											}
										}
										List<1254> list4 = new List<1254>();
										List<1254> list5 = new List<1254>();
										if (array3.Length > 9 && array3[9].Length > 0)
										{
											string[] array12 = array3[9].Split(new char[]
											{
												'|'
											});
											if (array12.Length != 0)
											{
												string[] array13 = array12;
												for (int num24 = 0; num24 < array13.Length; num24++)
												{
													string[] array14 = array13[num24].Split(new char[]
													{
														':'
													});
													list4.Add((1254)Convert.ToInt32(array14[0]));
													list5.Add((1254)Convert.ToInt32(array14[1]));
												}
											}
										}
										if (list3 != null)
										{
											if (list4.Count > num21 + 1)
											{
												list4.RemoveRange(num21 + 1, list4.Count - num21 - 1);
											}
											else
											{
												for (int num25 = list4.Count; num25 <= num21; num25++)
												{
													list4.Add(1254.None);
												}
											}
											if (list5.Count > num21 + 1)
											{
												list5.RemoveRange(num21 + 1, list5.Count - num21 - 1);
											}
											else
											{
												for (int num26 = list5.Count; num26 <= num21; num26++)
												{
													list5.Add(1254.None);
												}
											}
										}
										if (array3.Length > 10)
										{
											string[] array15 = array3[10].Split(new char[]
											{
												':'
											});
											38 = (1254)Convert.ToInt32(array15[0]);
											39 = (1254)Convert.ToInt32(array15[1]);
											40 = (1253)((array15.Length > 2) ? Convert.ToInt32(array15[2]) : 0);
											42 = ((array15.Length > 3) ? 1052.18(int.Parse(array15[3]), 0, 100) : 0);
											41 = ((array15.Length > 4) ? array15[4] : string.Empty);
										}
										if (36 != null)
										{
											List<208> list6 = 2039.12(array3[5], num16, num17, num22, flag7, flag5, 36);
											if (list6 != null)
											{
												list2.Clear();
												foreach (208 45 in list6)
												{
													list2.Add(35 + 45);
												}
												44 = 2064.Linear;
											}
											else
											{
												for (int num27 = 0; num27 < list2.Count; num27++)
												{
													list2[num27] = 35 + 36.1(list2[num27] - 37);
												}
											}
										}
										2063 46 = this.33.CreateSlider(35, num19, this.5() || flag19, 34, 44, num21, num22, list2, list3, flag19 ? num20 : 0, 38, 39, list4, list5, 40, 42, 41);
										46.19 = num18;
										46.20 = flag19;
										46.21 = array3[5];
										46.22 = num16;
										46.23 = num17;
										46.24 = ((array3.Length > 7) ? 2678.2(array3[7], 2147483647.0, false) : 0.0);
										this.AddSlider(46);
									}
									else if (33.1(2047.Spinner))
									{
										if (array3.Length > 6)
										{
											string[] array16 = array3[6].Split(new char[]
											{
												':'
											});
											38 = (1254)Convert.ToInt32(array16[0]);
											39 = (1254)Convert.ToInt32(array16[1]);
											40 = (1253)((array16.Length > 2) ? Convert.ToInt32(array16[2]) : 0);
											42 = ((array16.Length > 3) ? 1052.18(int.Parse(array16[3]), 0, 100) : 0);
											41 = ((array16.Length > 4) ? array16[4] : string.Empty);
										}
										int num28 = (int)2678.2(array3[5], 2147483647.0, 3);
										if (!3)
										{
											num28 = Math.Min(1226.9() - 50, num28);
										}
										2070 47 = this.33.CreateSpinner(num19, num28 + this.21.90, 34, 38, 39, 40, 42, 41);
										47.SetNewCombo(33.1(2047.NewCombo));
										47.19 = num18;
										47.20 = flag19;
										this.AddSpinner(47);
									}
									else if (33.1(2047.Hold))
									{
										int 48 = num19;
										if (array3.Length > 5 && array3[5].Length > 0)
										{
											string[] array17 = array3[5].Split(new char[]
											{
												':'
											});
											48 = (int)2678.2(array17[0], 2147483647.0, 3);
											if (array17.Length > 1)
											{
												38 = (1254)2678.3(array17[1], int.MaxValue, 3);
												39 = (1254)2678.3(array17[2], int.MaxValue, 3);
											}
											if (array17.Length > 3)
											{
												40 = (1253)2678.3(array17[3], int.MaxValue, 3);
											}
											42 = ((array17.Length > 4) ? 1052.18(2678.3(array17[4], int.MaxValue, 3), 0, 100) : 0);
											41 = ((array17.Length > 5) ? array17[5] : string.Empty);
										}
										2072 49 = this.33.CreateHold(35, num19, 48, this.5() || flag19, 34, flag19 ? num20 : 0, 38, 39, 40, 42, 41);
										if (49 != null)
										{
											this.AddCircle(49);
										}
									}
								}
								catch
								{
									if (!3)
									{
										throw;
									}
								}
							}
						}
					}
				}
			}
			finally
			{
				((IDisposable)textReader).Dispose();
			}
			if (!flag4)
			{
				this.LoadComboColours(false);
			}
		}
	}

	// Token: 0x06003BD0 RID: 15312 RVA: 0x0017AFD4 File Offset: 0x001791D4
	internal void 49(List<2034> 1)
	{
		foreach (2034 2 in 1)
		{
			if (2.HasObjectType(2047.Normal))
			{
				2072 3 = this.33.CreateCircle(2.8, 2.1, 2.IsNewCombo(), 2.4, 2.16, 2.35, 2.36, 2.37, 2.34, 2.33);
				this.AddCircle(3);
			}
			else if (2.HasObjectType(2047.Slider))
			{
				2123 4 = 2 as 2123;
				2063 5 = this.33.CreateSlider(2.8, 2.1, 2.IsNewCombo(), 2.4, 4.51, 4.5, 2.6, new List<208>(4.54), 4.84, 2.16, 2.35, 2.36, 4.85, 4.86, 2.37, 2.34, 2.33);
				this.AddSlider(5);
			}
			else if (2.HasObjectType(2047.Spinner))
			{
				2070 6 = this.33.CreateSpinner(2.1, 2.2, 2.4, 2.35, 2.36, 2.37, 2.34, 2.33);
				6.SetNewCombo(2.HasObjectType(2047.NewCombo));
				this.AddSpinner(6);
			}
			else if (2.HasObjectType(2047.Hold))
			{
				2072 7 = this.33.CreateHold(2.8, 2.1, 2.2, 2.IsNewCombo(), 2.4, 2.16, 2.35, 2.36, 2.37, 2.34, 2.33);
				if (7 != null)
				{
					this.AddCircle(7);
				}
			}
		}
	}

	// Token: 0x06003BD1 RID: 15313 RVA: 0x0017B1E8 File Offset: 0x001793E8
	private void 50(ref string 1)
	{
		if (this.40 == null || 1.IndexOf('$') < 0)
		{
			return;
		}
		foreach (KeyValuePair<string, string> keyValuePair in this.40)
		{
			1 = 1.Replace(keyValuePair.Key, keyValuePair.Value);
		}
	}

	// Token: 0x06003BD2 RID: 15314 RVA: 0x0017B260 File Offset: 0x00179460
	internal static List<1259> 51(1262 1, string 2, out bool 3, bool 4)
	{
		List<1259> list = 4 ? null : new List<1259>();
		if (2.Contains("NaN") || 2.Contains("Infinity"))
		{
			3 = false;
			return null;
		}
		string[] array = 2.Split(new char[]
		{
			'\n'
		});
		3 = true;
		foreach (string text in array)
		{
			if (text.Trim().Length != 0)
			{
				1259 5 = 2039.52(text, 1.90, 1.79, 1.48);
				if (5 == null)
				{
					3 = false;
					return null;
				}
				if (!4)
				{
					list.Add(5);
				}
			}
		}
		return list;
	}

	// Token: 0x06003BD3 RID: 15315 RVA: 0x0017B2FC File Offset: 0x001794FC
	internal static 1259 52(string 1, int 2, int 3, 1254 4)
	{
		1259 result;
		try
		{
			string[] array = 1.Split(new char[]
			{
				','
			});
			if (array.Length > 2)
			{
				int 5 = (array.Length > 7) ? Convert.ToInt32(array[7], 1662.18) : 0;
				result = new 1259(double.Parse(array[0].Trim(), 1662.18) + (double)2, double.Parse(array[1].Trim(), 1662.18), (1257)((array[2][0] == '0') ? 4 : int.Parse(array[2])), (1254)int.Parse(array[3]), (1253)((array.Length > 4) ? int.Parse(array[4]) : 0), (array.Length > 5) ? int.Parse(array[5]) : 3, array.Length <= 6 || array[6][0] == '1', (1258)5);
			}
			else if (array.Length == 2)
			{
				result = new 1259(double.Parse(array[0].Trim(), 1662.18) + (double)2, double.Parse(array[1].Trim(), 1662.18), (1257)4, 4, 1226.61(), 100, true, (1258)0);
			}
			else
			{
				result = null;
			}
		}
		catch (FormatException)
		{
			result = null;
		}
		return result;
	}

	// Token: 0x06003BD4 RID: 15316 RVA: 0x0017B420 File Offset: 0x00179620
	internal bool 53(bool 1, bool 2, bool 3, bool 4)
	{
		this.41();
		this.32.23();
		1262 5 = this.21;
		5.32 = 14;
		StringWriter stringWriter = new StringWriter();
		StringBuilder stringBuilder;
		try
		{
			string str = "osu file format v";
			int num = 5.32;
			stringWriter.WriteLine(str + num.ToString());
			stringWriter.WriteLine();
			stringWriter.WriteLine("[General]");
			stringWriter.WriteLine("AudioFilename: " + Path.GetFileName(5.18));
			string str2 = "AudioLeadIn: ";
			num = 5.19;
			stringWriter.WriteLine(str2 + num.ToString());
			stringWriter.WriteLine("PreviewTime: " + 1226.97().ToString());
			string str3 = "Countdown: ";
			num = (int)5.38;
			stringWriter.WriteLine(str3 + num.ToString());
			stringWriter.WriteLine("SampleSet: " + ((1226.25 <= 1254.Drum) ? 1226.25 : 1254.None).ToString());
			stringWriter.WriteLine("StackLeniency: " + 5.83.ToString(1662.18));
			stringWriter.WriteLine("Mode: " + ((int)5.3()).ToString());
			stringWriter.WriteLine("LetterboxInBreaks: " + (5.62 ? "1" : "0"));
			if (!5.84)
			{
				stringWriter.WriteLine("StoryFireInFront: 0");
			}
			if (5.88)
			{
				stringWriter.WriteLine("UseSkinSprites: 1");
			}
			if (5.16)
			{
				stringWriter.WriteLine("AlwaysShowPlayfield: 1");
			}
			if (5.105 != 1290.NoChange)
			{
				stringWriter.WriteLine("OverlayPosition: " + 5.105.ToString());
			}
			if (!string.IsNullOrEmpty(5.80))
			{
				stringWriter.WriteLine("SkinPreference:" + 5.80);
			}
			if (5.106)
			{
				stringWriter.WriteLine("EpilepsyWarning: 1");
			}
			if (5.39 > 0)
			{
				TextWriter textWriter = stringWriter;
				string str4 = "CountdownOffset: ";
				int num2 = 5.39;
				textWriter.WriteLine(str4 + num2.ToString());
			}
			if (5.3() == 2147.OsuMania)
			{
				stringWriter.WriteLine("SpecialStyle: " + (5.91 ? "1" : "0"));
			}
			stringWriter.WriteLine("WidescreenStoryboard: " + (5.63 ? "1" : "0"));
			if (5.93)
			{
				stringWriter.WriteLine("SamplesMatchPlaybackRate: 1");
			}
			stringWriter.WriteLine();
			stringWriter.WriteLine("[Editor]");
			if (this.25.Count > 0)
			{
				string text = string.Empty;
				foreach (int num3 in this.25)
				{
					text = text + num3.ToString() + ",";
				}
				text = text.Trim(new char[]
				{
					','
				});
				stringWriter.WriteLine("Bookmarks: " + text);
			}
			TextWriter textWriter2 = stringWriter;
			string str5 = "DistanceSpacing: ";
			1319 6 = 1304.138;
			textWriter2.WriteLine(str5 + ((6 != null) ? 6.ToString() : null));
			TextWriter textWriter3 = stringWriter;
			string str6 = "BeatDivisor: ";
			1318 7 = 1304.144;
			textWriter3.WriteLine(str6 + ((7 != null) ? 7.ToString() : null));
			TextWriter textWriter4 = stringWriter;
			string str7 = "GridSize: ";
			1318 8 = 1304.145;
			textWriter4.WriteLine(str7 + ((8 != null) ? 8.ToString() : null));
			stringWriter.WriteLine("TimelineZoom: " + 5.86.ToString(1662.18));
			stringWriter.WriteLine();
			stringWriter.WriteLine("[Metadata]");
			stringWriter.WriteLine("Title:" + 5.10);
			stringWriter.WriteLine("TitleUnicode:" + 5.11);
			stringWriter.WriteLine("Artist:" + 5.7);
			stringWriter.WriteLine("ArtistUnicode:" + 5.8);
			stringWriter.WriteLine("Creator:" + 5.43);
			stringWriter.WriteLine("Version:" + 5.89);
			stringWriter.WriteLine("Source:" + 5.82);
			stringWriter.WriteLine("Tags:" + 5.9);
			string str8 = "BeatmapID:";
			num = 5.25;
			stringWriter.WriteLine(str8 + num.ToString());
			string str9 = "BeatmapSetID:";
			num = 5.29;
			stringWriter.WriteLine(str9 + num.ToString());
			stringWriter.WriteLine();
			stringWriter.WriteLine("[Difficulty]");
			stringWriter.WriteLine("HPDrainRate:" + 5.3.ToString(1662.18));
			stringWriter.WriteLine("CircleSize:" + 5.2.ToString(1662.18));
			stringWriter.WriteLine("OverallDifficulty:" + 5.4.ToString(1662.18));
			stringWriter.WriteLine("ApproachRate:" + 5.1.ToString(1662.18));
			stringWriter.WriteLine("SliderMultiplier:" + 5.5.ToString(1662.18));
			stringWriter.WriteLine("SliderTickRate:" + 5.6.ToString(1662.18));
			stringWriter.WriteLine();
			this.54(stringWriter, true);
			stringWriter.WriteLine();
			if (this.21.94.Count > 0)
			{
				stringWriter.WriteLine("[TimingPoints]");
				stringWriter.WriteLine(2039.56(this.21.94));
			}
			if (5.44)
			{
				stringWriter.WriteLine();
				stringWriter.WriteLine("[Colours]");
				foreach (KeyValuePair<string, 198> keyValuePair in 2630.3)
				{
					if (keyValuePair.Value.A != 0)
					{
						stringWriter.WriteLine("{0} : {1},{2},{3}", new object[]
						{
							keyValuePair.Key,
							keyValuePair.Value.R,
							keyValuePair.Value.G,
							keyValuePair.Value.B
						});
					}
				}
			}
			stringWriter.WriteLine();
			stringWriter.WriteLine("[HitObjects]");
			this.4();
			this.2(true);
			foreach (2034 9 in this.34)
			{
				if (9.1 <= 1226.9() && 9.1 >= 0)
				{
					string text2 = string.Empty;
					if (9.HasObjectType(2047.Slider))
					{
						text2 = ",";
						2123 10 = (2123)9;
						if (10.6 == 0.0)
						{
							continue;
						}
						text2 = text2 + 10.63.ToString().Substring(0, 1) + "|";
						for (int i = 1; i < 10.54.Count; i++)
						{
							208 11 = 10.54[i];
							text2 = string.Concat(new string[]
							{
								text2,
								((int)11.X).ToString(),
								":",
								((int)11.Y).ToString(),
								"|"
							});
						}
						text2 = text2.Trim(new char[]
						{
							'|'
						});
						string str10 = text2;
						string str11 = ",";
						num = 10.5;
						text2 = str10 + str11 + num.ToString();
						text2 = text2 + "," + 10.6.ToString(1662.18);
						if (!10.73)
						{
							text2 += ",";
							for (int j = 0; j < 10.84.Count; j++)
							{
								text2 = text2 + ((int)10.84[j]).ToString() + "|";
							}
							text2 = text2.Trim(new char[]
							{
								'|'
							});
							text2 += ",";
							for (int k = 0; k < 10.85.Count; k++)
							{
								text2 = string.Concat(new string[]
								{
									text2,
									((int)10.85[k]).ToString(),
									":",
									((int)10.86[k]).ToString(),
									"|"
								});
							}
							text2 = text2.Trim(new char[]
							{
								'|'
							});
							text2 += string.Format(",{0}:{1}:{2}:{3}:{4}", new object[]
							{
								(int)9.35,
								(int)9.36,
								(int)9.37,
								9.34,
								9.33
							});
						}
					}
					else if (9.HasObjectType(2047.Spinner))
					{
						text2 = string.Format(",{0},{1}:{2}:{3}:{4}:{5}", new object[]
						{
							9.2,
							(int)9.35,
							(int)9.36,
							(int)9.37,
							9.34,
							9.33
						});
					}
					else if (9.HasObjectType(2047.Normal))
					{
						text2 = string.Format(",{0}:{1}:{2}:{3}:{4}", new object[]
						{
							(int)9.35,
							(int)9.36,
							(int)9.37,
							9.34,
							9.33
						});
					}
					else if (9.HasObjectType(2047.Hold))
					{
						text2 = string.Format(",{0}:{1}:{2}:{3}:{4}:{5}", new object[]
						{
							9.2,
							(int)9.35,
							(int)9.36,
							(int)9.37,
							9.34,
							9.33
						});
					}
					string[] array = new string[10];
					array[0] = ((int)9.8.X).ToString();
					array[1] = ",";
					array[2] = ((int)9.8.Y).ToString();
					array[3] = ",";
					string[] array2 = array;
					num = 9.1;
					array2[4] = num.ToString();
					array2[5] = ",";
					array2[6] = ((int)(9.3 | (2047)((9.16 & 7) << 4))).ToString();
					array2[7] = ",";
					num = (int)9.4;
					array2[8] = num.ToString();
					array2[9] = text2;
					stringWriter.WriteLine(string.Concat(array2));
				}
			}
			stringBuilder = stringWriter.GetStringBuilder();
		}
		finally
		{
			((IDisposable)stringWriter).Dispose();
		}
		string text3 = 1209.1(5.68());
		string s = stringBuilder.ToString();
		byte[] array3 = 1209.2.GetBytes(s);
		MD5 12 = 1209.1;
		string text4;
		lock (12)
		{
			try
			{
				array3 = 1209.1.ComputeHash(array3);
			}
			catch (Exception)
			{
				text4 = "fail";
				goto IL_C40;
			}
		}
		char[] array4 = new char[array3.Length * 2];
		for (int l = 0; l < array3.Length; l++)
		{
			array3[l].ToString("x2", 1209.3).CopyTo(0, array4, l * 2, 2);
		}
		string text5 = new string(array4);
		goto IL_C44;
		IL_C40:
		text5 = text4;
		IL_C44:
		string value = text5;
		bool flag2 = !text3.Equals(value);
		if (3)
		{
			return flag2;
		}
		if (15)
		{
			if (text3.Equals(value))
			{
				return true;
			}
			if (1662.84)
			{
				if (DialogResult.OK != MessageBox.Show(1568.1(2679.HitObjectManager_LoadSave_TestModeDirtyDialog), "nekiosu", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation))
				{
					return false;
				}
			}
			else
			{
				DialogResult dialogResult = MessageBox.Show(4 ? "osu! has encountered a problem and needs to close. Would you like to save?" : 1568.1(2679.HitObjectManager_LoadSave_SaveChangesDialog), "nekiosu", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
				if (dialogResult == DialogResult.Cancel)
				{
					return false;
				}
				if (dialogResult == DialogResult.No)
				{
					return true;
				}
			}
		}
		bool flag3 = false;
		string 13 = 5.58;
		string 14 = 5.68();
		string text6 = 5.66();
		if (2 || text6.ToLower() != 5.58.ToLower())
		{
			if (File.Exists(5.44() + "\\" + text6) && MessageBox.Show(1568.1(2679.HitObjectManager_LoadSave_FileAlreadyExistsDialog), "nekiosu", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.No)
			{
				return false;
			}
			5.58 = text6;
			if (!2)
			{
				flag3 = true;
			}
		}
		if (5.61)
		{
			5.60();
		}
		try
		{
			string tempFileName = Path.GetTempFileName();
			File.WriteAllText(tempFileName, stringBuilder.ToString());
			File.Delete(5.68());
			File.Move(tempFileName, 5.68());
		}
		catch (Exception)
		{
			1763.4("Unable to write to file " + 5.58);
			5.58 = 13;
			return false;
		}
		if (flag3)
		{
			2672.20(14);
		}
		if (this.32.14.Find((2647 1) => !1.11) != null)
		{
			StringWriter stringWriter2 = new StringWriter();
			try
			{
				if (this.40 != null && this.40.Count > 0)
				{
					stringWriter2.WriteLine("[Variables]");
					foreach (KeyValuePair<string, string> keyValuePair2 in this.40)
					{
						stringWriter2.WriteLine("{0}={1}", keyValuePair2.Key, keyValuePair2.Value);
					}
					stringWriter2.WriteLine();
				}
				this.54(stringWriter2, false);
				stringBuilder = stringWriter2.GetStringBuilder();
			}
			finally
			{
				((IDisposable)stringWriter2).Dispose();
			}
			string text7 = stringBuilder.ToString();
			foreach (KeyValuePair<string, string> keyValuePair3 in this.40)
			{
				text7 = text7.Replace("," + keyValuePair3.Value, "," + keyValuePair3.Key);
			}
			try
			{
				string text8 = Path.Combine(5.61 ? 5.53() : 5.44(), 5.67());
				string tempFileName2 = Path.GetTempFileName();
				File.WriteAllText(tempFileName2, text7);
				File.Delete(text8);
				File.Move(tempFileName2, text8);
			}
			catch
			{
				1763.4("Unable to write to file " + 5.67());
				return false;
			}
			if (this.21.85 > (1281)1)
			{
				this.21.97 = flag2;
			}
		}
		else
		{
			File.Delete(Path.Combine(5.61 ? 5.53() : 5.44(), 5.67()));
		}
		1662.105(Path.GetFileName(5.58));
		5.30();
		if (2)
		{
			5.23 = null;
		}
		5.65();
		1226.70(false);
		return true;
	}

	// Token: 0x06003BD5 RID: 15317 RVA: 0x0017C4E0 File Offset: 0x0017A6E0
	private void 54(StringWriter 1, bool 2)
	{
		2039.2044 3 = new 2039.2044();
		3.1 = 2;
		1.WriteLine("[Events]");
		1.WriteLine("//Background and Video events");
		foreach (2647 4 in this.32.14.FindAll(new Predicate<2647>(3.1)))
		{
			if (4.10 <= 2635.Video)
			{
				this.55(4, 1);
			}
		}
		if (3.1)
		{
			1.WriteLine("//Break Periods");
			foreach (2275 5 in this.32.13)
			{
				1.WriteLine("{0},{1},{2}", (int)5.10, 5.8, 5.1);
			}
		}
		for (int i = 0; i < this.32.26.Length; i++)
		{
			1.WriteLine("//Storyboard Layer {0} ({1})", i, (2645)i);
			foreach (2647 6 in this.32.26[i].FindAll(new Predicate<2647>(3.2)))
			{
				2635 7 = 6.10;
				if (7 == 2635.Sprite || 7 == 2635.Animation)
				{
					this.55(6, 1);
				}
			}
		}
		1.WriteLine("//Storyboard Sound Samples");
		foreach (2654 8 in this.32.15.FindAll(new Predicate<2654>(3.3)))
		{
			1.WriteLine("{0},{1},{2},\"{3}\",{4}", new object[]
			{
				8.10,
				8.8,
				(int)8.5,
				2672.18(8.3),
				8.12
			});
		}
		this.32.14.ForEach(new Action<2647>(2039.2040.Instance.5));
	}

	// Token: 0x06003BD6 RID: 15318 RVA: 0x0017C780 File Offset: 0x0017A980
	private void 55(2647 1, StringWriter 2)
	{
		1433 3 = 1.7;
		if (3 != null)
		{
			3.3.Sort();
		}
		2646 4 = 1 as 2646;
		switch (1.10)
		{
		case 2635.Background:
			2.WriteLine("{0},{1},\"{2}\",{3},{4}", new object[]
			{
				(int)1.10,
				1.8,
				2672.18(1.3),
				(1.7 != null) ? 1.7.17.X.ToString(1662.18) : "0",
				(1.7 != null) ? 1.7.17.Y.ToString(1662.18) : "0"
			});
			break;
		case 2635.Video:
			2.WriteLine("{0},{1},\"{2}\"", 1.10, 1.8, 1.3);
			break;
		case 2635.Sprite:
			2.WriteLine("{0},{1},{2},\"{3}\",{4},{5}", new object[]
			{
				1.10,
				1.5,
				1.7.49,
				1.3,
				1.7.7.X.ToString(1662.18),
				1.7.7.Y.ToString(1662.18)
			});
			break;
		case 2635.Animation:
			2.WriteLine("{0},{1},{2},\"{3}\",{4},{5},{6},{7},{8}", new object[]
			{
				1.10,
				1.5,
				1.7.49,
				1.3,
				1.7.7.X.ToString(1662.18),
				1.7.7.Y.ToString(1662.18),
				4.17.73,
				4.18.ToString(1662.18),
				4.17.71
			});
			break;
		}
		if (1.7 != null)
		{
			if (1.7.4 != null)
			{
				foreach (1457 5 in 1.7.4)
				{
					2.WriteLine(" L,{0},{1}", 5.2, 5.1);
					5.3.Sort();
					foreach (1445 6 in 5.3)
					{
						if (6.16 != 149)
						{
							if (6.1() == 0)
							{
								2.Write("  {0},{1},{2},,", 2039.57(6.14), (int)6.15, 6.9);
							}
							else
							{
								2.Write("  {0},{1},{2},{3},", new object[]
								{
									2039.57(6.14),
									(int)6.15,
									6.9,
									6.10
								});
							}
							this.58(2, 6);
							2.WriteLine();
						}
					}
				}
			}
			foreach (1445 7 in 1.7.3)
			{
				if (!7.18 && 7.16 != 149)
				{
					if (7.1() == 0)
					{
						2.Write(" {0},{1},{2},,", 2039.57(7.14), (int)7.15, 7.9);
					}
					else
					{
						2.Write(" {0},{1},{2},{3},", new object[]
						{
							2039.57(7.14),
							(int)7.15,
							7.9,
							7.10
						});
					}
					this.58(2, 7);
					2.WriteLine();
				}
			}
		}
		if (1.2.Count <= 0)
		{
			return;
		}
		foreach (KeyValuePair<2659, List<2657>> keyValuePair in 1.2)
		{
			foreach (2657 8 in keyValuePair.Value)
			{
				if (8.5 == 0)
				{
					2.Write(" T,{0}", 8.4);
				}
				else
				{
					2.Write(" T,{0},{1},{2}", 8.4, 8.6, 8.5);
				}
				if (8.4.1())
				{
					2.WriteLine(",{0}", (int)(2659.None - 8.4.2()));
				}
				else
				{
					2.WriteLine();
				}
				8.3.Sort();
				foreach (1445 9 in 8.3)
				{
					if (9.16 != 149)
					{
						if (9.1() == 0)
						{
							2.Write("  {0},{1},{2},,", 2039.57(9.14), (int)9.15, 9.9);
						}
						else
						{
							2.Write("  {0},{1},{2},{3},", new object[]
							{
								2039.57(9.14),
								(int)9.15,
								9.9,
								9.10
							});
						}
						this.58(2, 9);
						2.WriteLine();
					}
				}
			}
		}
	}

	// Token: 0x06003BD7 RID: 15319 RVA: 0x0017CEA8 File Offset: 0x0017B0A8
	internal static string 56(List<1259> 1)
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (1259 2 in 1)
		{
			if (2.1 != 0.0)
			{
				stringBuilder.AppendFormat(1662.18, "{0},{1},{2},{3},{4},{5},{6},{7}\r\n", new object[]
				{
					2.3,
					2.1,
					(int)2.5,
					(int)2.4,
					(int)2.2,
					2.6,
					2.1() ? "1" : "0",
					(int)2.8
				});
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06003BD8 RID: 15320 RVA: 0x0017CFA8 File Offset: 0x0017B1A8
	private static string 57(1456 1)
	{
		string result;
		if (1 != 1456.MovementX)
		{
			if (1 != 1456.MovementY)
			{
				result = 1.ToString().Substring(0, 1);
			}
			else
			{
				result = "MY";
			}
		}
		else
		{
			result = "MX";
		}
		return result;
	}

	// Token: 0x06003BD9 RID: 15321 RVA: 0x0017CFF0 File Offset: 0x0017B1F0
	private void 58(StringWriter 1, 1445 2)
	{
		1456 3 = 2.14;
		if (3 <= 1456.ParameterFlipHorizontal)
		{
			if (3 <= 1456.Rotation)
			{
				switch (3)
				{
				case 1456.Movement:
					break;
				case 1456.Fade:
				case 1456.Scale:
					goto IL_137;
				case 1456.Movement | 1456.Fade:
					return;
				default:
					if (3 != 1456.Rotation)
					{
						return;
					}
					goto IL_137;
				}
			}
			else if (3 != 1456.Colour)
			{
				if (3 != 1456.ParameterFlipHorizontal)
				{
					return;
				}
				1.Write("H");
				return;
			}
			else
			{
				if (2.3 == 2.7)
				{
					1.Write("{0},{1},{2}", 2.3.R, 2.3.G, 2.3.B);
					return;
				}
				1.Write("{0},{1},{2},{3},{4},{5}", new object[]
				{
					2.3.R,
					2.3.G,
					2.3.B,
					2.7.R,
					2.7.G,
					2.7.B
				});
				return;
			}
		}
		else if (3 <= 1456.MovementX)
		{
			if (3 == 1456.ParameterFlipVertical)
			{
				1.Write("V");
				return;
			}
			if (3 != 1456.MovementX)
			{
				return;
			}
			goto IL_137;
		}
		else
		{
			if (3 == 1456.MovementY)
			{
				goto IL_137;
			}
			if (3 != 1456.VectorScale)
			{
				if (3 != 1456.ParameterAdditive)
				{
					return;
				}
				1.Write("A");
				return;
			}
		}
		if (2.2 == 2.6)
		{
			1.Write("{0},{1}", 2.2.X.ToString(1662.18), 2.2.Y.ToString(1662.18));
			return;
		}
		1.Write("{0},{1},{2},{3}", new object[]
		{
			2.2.X.ToString(1662.18),
			2.2.Y.ToString(1662.18),
			2.6.X.ToString(1662.18),
			2.6.Y.ToString(1662.18)
		});
		return;
		IL_137:
		if (2.1 == 2.5)
		{
			1.Write("{0}", 2.1.ToString(1662.18));
			return;
		}
		1.Write("{0},{1}", 2.1.ToString(1662.18), 2.5.ToString(1662.18));
	}

	// Token: 0x06003BDA RID: 15322 RVA: 0x0017D280 File Offset: 0x0017B480
	internal 2034 59()
	{
		if (this.35 > 0)
		{
			return this.34[this.35 - 1];
		}
		return null;
	}

	// Token: 0x06003BDB RID: 15323 RVA: 0x0017D2A0 File Offset: 0x0017B4A0
	internal 2034 60(int 1)
	{
		if (1 < 0 || 1 >= this.35)
		{
			return null;
		}
		return this.34[1];
	}

	// Token: 0x06003BDC RID: 15324 RVA: 0x0017D2BD File Offset: 0x0017B4BD
	internal 2034 61(2275 1)
	{
		return this.34[this.73(1)];
	}

	// Token: 0x06003BDD RID: 15325 RVA: 0x0017D2D1 File Offset: 0x0017B4D1
	internal 2034 62(2275 1)
	{
		return this.34[this.71(1)];
	}

	// Token: 0x06003BDE RID: 15326 RVA: 0x0017D2E5 File Offset: 0x0017B4E5
	internal virtual 2034 GetFirstGameplayHitObject()
	{
		if (this.35 <= 0)
		{
			return null;
		}
		return this.34[0];
	}

	// Token: 0x06003BDF RID: 15327 RVA: 0x001711A8 File Offset: 0x0016F3A8
	internal virtual int GetReplayOpenUntil(2034 1)
	{
		return 1.2;
	}

	// Token: 0x06003BE0 RID: 15328 RVA: 0x0017D2FE File Offset: 0x0017B4FE
	internal virtual 2034 GetLastGameplayHitObject()
	{
		if (this.35 <= 0)
		{
			return null;
		}
		return this.34[this.35 - 1];
	}

	// Token: 0x06003BE1 RID: 15329 RVA: 0x0017D320 File Offset: 0x0017B520
	internal 2034 63(int 1, int 2, float 3, bool 4, Predicate<2034> 5)
	{
		if (this.36.Count == 0)
		{
			return null;
		}
		208 6 = new 208((float)1, (float)2);
		2034 7 = null;
		int num = 0;
		foreach (2034 8 in this.36)
		{
			if ((5 != null || 8.IsActive()) && (5 == null || 5(8)))
			{
				int num2 = Math.Min(Math.Abs(8.1 - 1226.16), Math.Abs(8.2 - 1226.16));
				if (7 == null || num2 <= num)
				{
					if (208.DistanceSquared(6, 4 ? 8.18 : 8.8) < 3 * 3 || 208.DistanceSquared(6, 4 ? 8.2() : 8.GetCurrentPosition()) < 3 * 3)
					{
						7 = 8;
						num = num2;
					}
					else
					{
						2123 9 = 8 as 2123;
						if (((9 != null) ? 9.55 : null) != null)
						{
							foreach (1051 10 in 9.55)
							{
								208 11 = 10.1;
								if (10.4)
								{
									11 = 10.5(6);
								}
								if (4)
								{
									11 -= 9.8 - 9.18;
								}
								if (208.Distance(6, 11) < 3)
								{
									7 = 8;
									num = num2;
									break;
								}
							}
						}
					}
				}
			}
		}
		return 7;
	}

	// Token: 0x06003BE2 RID: 15330 RVA: 0x0017D4F4 File Offset: 0x0017B6F4
	internal 2034 64(float 1, float 2, bool 3)
	{
		return this.65(1, 2, 3, this.1);
	}

	// Token: 0x06003BE3 RID: 15331 RVA: 0x0017D508 File Offset: 0x0017B708
	internal 2034 65(float 1, float 2, bool 3, float 4)
	{
		bool flag = !1535.1() && 3;
		208 5 = new 208(1, 2);
		foreach (2034 6 in this.36)
		{
			if ((!flag || 6.39) && 6.HitTest(5, 3, 4))
			{
				return 6;
			}
		}
		return null;
	}

	// Token: 0x06003BE4 RID: 15332 RVA: 0x0017D588 File Offset: 0x0017B788
	internal int 66(int 1, int 2, int 3, bool 4)
	{
		int num = 2 - 1;
		bool flag = false;
		if (4)
		{
			3 = 1 - 3;
		}
		if (num >= this.35)
		{
			return -1;
		}
		bool flag2 = num >= 0;
		while (flag2 && !flag)
		{
			2034 5 = this.34[num];
			flag2 = (5.1 >= 3);
			if (flag2)
			{
				flag = (1 <= 5.2 && 1 >= 5.1);
				if (!flag)
				{
					num--;
					flag2 = (num >= 0);
				}
			}
		}
		if (!flag)
		{
			return -1;
		}
		return num;
	}

	// Token: 0x06003BE5 RID: 15333 RVA: 0x0017D60C File Offset: 0x0017B80C
	internal int 67(int 1, int 2)
	{
		int num = 1;
		int result = -1;
		int num2 = 2;
		while (num2 != -1)
		{
			num2 = this.66(1, num2, this.9, true);
			if (num2 >= 0)
			{
				2034 3 = this.34[num2];
				if (3.2 > num)
				{
					num = 3.2;
					result = num2;
				}
			}
		}
		return result;
	}

	// Token: 0x06003BE6 RID: 15334 RVA: 0x0017D65C File Offset: 0x0017B85C
	internal int 68(int 1)
	{
		bool flag;
		return this.69(1, out flag);
	}

	// Token: 0x06003BE7 RID: 15335 RVA: 0x0017D674 File Offset: 0x0017B874
	internal int 69(int 1, out bool 2)
	{
		int num = this.70(new 2071(this, 1));
		2 = (num >= 0);
		if (!2)
		{
			num = ~num;
		}
		return num;
	}

	// Token: 0x06003BE8 RID: 15336 RVA: 0x0017D6A0 File Offset: 0x0017B8A0
	internal int 70(2034 1)
	{
		return this.34.BinarySearch(1);
	}

	// Token: 0x06003BE9 RID: 15337 RVA: 0x0017D6B0 File Offset: 0x0017B8B0
	internal int 71(2275 1)
	{
		int 2 = 1.GetDuration() / 2 + 1.8;
		int num = this.34.BinarySearch(new 2071(this, 2));
		if (num < 0)
		{
			num = ~num;
		}
		return num;
	}

	// Token: 0x06003BEA RID: 15338 RVA: 0x0017D6E8 File Offset: 0x0017B8E8
	internal bool 72(2034 1, bool 2)
	{
		2039.2042 gapQuery = new 2039.2042();
		gapQuery.1 = 3;
		int num = this.34.FindIndex((2034 1) => 1 == gapQuery.1);
		if (num <= 0)
		{
			return 2;
		}
		gapQuery.3 = this.34[num].1;
		gapQuery.2 = this.34[num - 1].2;
		return this.32.13.Find(new Predicate<2275>(gapQuery.3)) != null;
	}

	// Token: 0x06003BEB RID: 15339 RVA: 0x0017D78E File Offset: 0x0017B98E
	internal int 73(2275 1)
	{
		return this.71(1) - 1;
	}

	// Token: 0x06003BEC RID: 15340 RVA: 0x0017D799 File Offset: 0x0017B999
	internal void 74()
	{
		this.RebuildTimeWindowObjects();
		this.UpdateTimeWindowObjects();
	}

	// Token: 0x06003BED RID: 15341 RVA: 0x0017D7A8 File Offset: 0x0017B9A8
	internal virtual void RebuildTimeWindowObjects()
	{
		2263 <<EMPTY_NAME>> = 2263.4;
		this.35 = this.34.Count;
		int num = (<<EMPTY_NAME>> == null && this.IsInfiniteApproach) ? this.LeadInPreemptTime : this.2;
		int num2 = 1226.16 - ((<<EMPTY_NAME>> != null && !1304.83) ? this.34() : num);
		int num3 = 1226.16 + num;
		if (<<EMPTY_NAME>> != null)
		{
			num2 = Math.Min(num2, <<EMPTY_NAME>>.62);
			num3 = Math.Max(num3, <<EMPTY_NAME>>.63);
		}
		int num4 = this.34.BinarySearch(new 2071(this, num2));
		if (num4 < 0)
		{
			num4 = ~num4;
		}
		int num5 = num4;
		while (num5 < this.35 - 1 && this.34[num5].1 <= num3)
		{
			num5++;
		}
		if (num4 == this.35)
		{
			this.36.Clear();
			if (<<EMPTY_NAME>> != null)
			{
				this.39.28.Clear();
			}
			return;
		}
		this.36 = this.34.GetRange(num4, 1 + num5 - num4);
		if (<<EMPTY_NAME>> == null)
		{
			return;
		}
		this.39.28.Clear();
		this.36.ForEach(new Action<2034>(this.44));
		if (this.21.3() == 2147.Osu)
		{
			if (1304.85)
			{
				this.39(num4, num5);
			}
			if (1304.84)
			{
				this.42(num4, num5);
			}
		}
		foreach (2034 2 in <<EMPTY_NAME>>.74.44)
		{
			if (!this.36.Contains(2))
			{
				if (2.HasObjectType(2047.Slider))
				{
					2123 3 = 2 as 2123;
					2033 4 = 3.58;
					this.39.12(4.49);
					if (3.9().Count > 1)
					{
						4 = 3.9()[1];
						this.39.12(4.49);
					}
				}
				else
				{
					2033 5 = 2 as 2033;
					if (5 != null)
					{
						this.39.12(5.49);
					}
				}
			}
		}
	}

	// Token: 0x06003BEE RID: 15342 RVA: 0x0017D9F8 File Offset: 0x0017BBF8
	internal virtual void UpdateTimeWindowObjects()
	{
		foreach (2034 <<EMPTY_NAME>> in this.36)
		{
			<<EMPTY_NAME>>.Update();
			this.ProcessOverdueJudgement(<<EMPTY_NAME>>);
		}
	}

	// Token: 0x04002BFA RID: 11258
	internal int 9;

	// Token: 0x04002BFB RID: 11259
	internal int 10;

	// Token: 0x04002BFC RID: 11260
	internal bool 11;

	// Token: 0x04002BFD RID: 11261
	internal static List<2039> 12 = new List<2039>();

	// Token: 0x04002BFE RID: 11262
	internal static readonly int 13 = 400;

	// Token: 0x04002BFF RID: 11263
	internal static readonly int 14 = 240;

	// Token: 0x04002C00 RID: 11264
	internal static readonly int 15 = 32;

	// Token: 0x04002C01 RID: 11265
	internal static readonly int 16 = 128;

	// Token: 0x04002C02 RID: 11266
	internal static readonly int 17 = 800;

	// Token: 0x04002C03 RID: 11267
	internal static readonly int 18 = 120;

	// Token: 0x04002C04 RID: 11268
	internal static readonly int 19 = 600;

	// Token: 0x04002C05 RID: 11269
	internal static readonly int 20 = 500;

	// Token: 0x04002C06 RID: 11270
	internal 1262 21;

	// Token: 0x04002C07 RID: 11271
	internal 2685<2023> 22;

	// Token: 0x04002C08 RID: 11272
	internal float 23;

	// Token: 0x04002C09 RID: 11273
	internal float 24;

	// Token: 0x04002C0A RID: 11274
	internal List<int> 25;

	// Token: 0x04002C0B RID: 11275
	internal bool 26;

	// Token: 0x04002C0C RID: 11276
	internal List<198> 27 = new List<198>();

	// Token: 0x04002C0D RID: 11277
	public int 28;

	// Token: 0x04002C0E RID: 11278
	internal int 29;

	// Token: 0x04002C0F RID: 11279
	internal int 30;

	// Token: 0x04002C10 RID: 11280
	internal int 31;

	// Token: 0x04002C11 RID: 11281
	internal 2648 32;

	// Token: 0x04002C12 RID: 11282
	protected internal 2037 33;

	// Token: 0x04002C13 RID: 11283
	internal List<2034> 34 = new List<2034>();

	// Token: 0x04002C14 RID: 11284
	internal int 35;

	// Token: 0x04002C15 RID: 11285
	internal List<2034> 36 = new List<2034>();

	// Token: 0x04002C16 RID: 11286
	internal List<2034> 37 = new List<2034>();

	// Token: 0x04002C17 RID: 11287
	internal 2034 38;

	// Token: 0x04002C18 RID: 11288
	internal 1436 39;

	// Token: 0x04002C19 RID: 11289
	private Dictionary<string, string> 40;

	// Token: 0x04002C1A RID: 11290
	internal 2011 41;

	// Token: 0x04002C1B RID: 11291
	private List<1351> 42 = new List<1351>();

	// Token: 0x04002C1C RID: 11292
	private 2039.2041 43;

	// Token: 0x04002C1D RID: 11293
	private 2034 44;

	// Token: 0x04002C1E RID: 11294
	internal 1927 45;

	// Token: 0x04002C1F RID: 11295
	internal 1940 46;

	// Token: 0x04002C20 RID: 11296
	internal 1925 47;

	// Token: 0x04002C21 RID: 11297
	private Random 48;

	// Token: 0x04002C22 RID: 11298
	private Random 49;

	// Token: 0x04002C23 RID: 11299
	private 2117 50;

	// Token: 0x04002C24 RID: 11300
	private 2023 51;

	// Token: 0x04002C25 RID: 11301
	private 1938 52;

	// Token: 0x04002C26 RID: 11302
	private bool 53;

	// Token: 0x04002C27 RID: 11303
	internal Action 54;

	// Token: 0x04002C28 RID: 11304
	internal const int 55 = 86400000;

	// Token: 0x04002C29 RID: 11305
	internal 2050 56;

	// Token: 0x04002C2A RID: 11306
	internal HashSet<1371> 57;

	// Token: 0x02000805 RID: 2053
	[276]
	[Serializable]
	public sealed class 2040
	{
		// Token: 0x06003BF0 RID: 15344 RVA: 0x0017DAB5 File Offset: 0x0017BCB5
		internal bool 1(2034 1)
		{
			return 1.HasObjectType(2047.Slider);
		}

		// Token: 0x06003BF1 RID: 15345 RVA: 0x0017DABE File Offset: 0x0017BCBE
		internal void 2(1371 1)
		{
			1.11();
		}

		// Token: 0x06003BF2 RID: 15346 RVA: 0x0017DABE File Offset: 0x0017BCBE
		internal void 3(1371 1)
		{
			1.11();
		}

		// Token: 0x06003BF3 RID: 15347 RVA: 0x000E8A03 File Offset: 0x000E6C03
		internal void 4(2034 1)
		{
			1.5();
		}

		// Token: 0x06003BF4 RID: 15348 RVA: 0x0017DAC6 File Offset: 0x0017BCC6
		internal void 5(2647 1)
		{
			1.4 = 0;
		}

		// Token: 0x04002C2B RID: 11307
		public static readonly 2039.2040 Instance = new 2039.2040();

		// Token: 0x04002C2C RID: 11308
		public static Predicate<2034> predicate;

		// Token: 0x04002C2D RID: 11309
		public static Action<1371> action;

		// Token: 0x04002C2E RID: 11310
		public static Action<1371> action2;

		// Token: 0x04002C2F RID: 11311
		public static Action<1371> action3;

		// Token: 0x04002C30 RID: 11312
		public static Action<2034> action4;

		// Token: 0x04002C31 RID: 11313
		public static Action<1253> action5;

		// Token: 0x04002C32 RID: 11314
		public static Predicate<2647> predicate2;

		// Token: 0x04002C33 RID: 11315
		public static Action<2647> action6;
	}

	// Token: 0x02000806 RID: 2054
	[276]
	public sealed class 2045
	{
		// Token: 0x04002C34 RID: 11316
		public int 1;

		// Token: 0x04002C35 RID: 11317
		public int 2;

		// Token: 0x04002C36 RID: 11318
		public bool 3;
	}

	// Token: 0x02000807 RID: 2055
	[276]
	public sealed class 2043
	{
		// Token: 0x06003BF8 RID: 15352 RVA: 0x0017DADB File Offset: 0x0017BCDB
		internal bool 1(2034 1)
		{
			return 1.1 == this.1.1;
		}

		// Token: 0x04002C37 RID: 11319
		public 2034 1;
	}

	// Token: 0x02000808 RID: 2056
	// (Invoke) Token: 0x06003BFB RID: 15355
	[276]
	public delegate void 2041(2149 1, string 2, 2034 3);

	// Token: 0x02000809 RID: 2057
	[276]
	public sealed class 2044
	{
		// Token: 0x06003BFE RID: 15358 RVA: 0x0017DAF0 File Offset: 0x0017BCF0
		internal bool 1(2647 1)
		{
			return (1.9 && 1.11) == this.1;
		}

		// Token: 0x06003BFF RID: 15359 RVA: 0x0017DB0B File Offset: 0x0017BD0B
		internal bool 2(2647 1)
		{
			return 1.11 == this.1;
		}

		// Token: 0x06003C00 RID: 15360 RVA: 0x0017DB0B File Offset: 0x0017BD0B
		internal bool 3(2654 1)
		{
			return 1.11 == this.1;
		}

		// Token: 0x04002C38 RID: 11320
		public bool 1;
	}

	// Token: 0x0200080A RID: 2058
	[276]
	public sealed class 2042
	{
		// Token: 0x06003C02 RID: 15362 RVA: 0x0017DB1B File Offset: 0x0017BD1B
		internal bool 1(2275 1)
		{
			return 1.8 > this.2 && 1.1 < this.3;
		}

		// Token: 0x04002C39 RID: 11321
		public 2034 1;

		// Token: 0x04002C3A RID: 11322
		public int 2;

		// Token: 0x04002C3B RID: 11323
		public int 3;
	}
}
