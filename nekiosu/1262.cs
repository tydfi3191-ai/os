using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Threading;
using System.Windows.Forms;

// Token: 0x02000B5E RID: 2910
public sealed class 1262 : 2024, 1570, IComparable<1262>
{
	// Token: 0x06005032 RID: 20530 RVA: 0x001F9781 File Offset: 0x001F7981
	internal new bool 1()
	{
		if (!this.111)
		{
			return !this.108 && !1304.94;
		}
		return !this.108;
	}

	// Token: 0x06005033 RID: 20531 RVA: 0x001F97AC File Offset: 0x001F79AC
	public 1262()
	{
		for (int i = 0; i < this.57.Length; i++)
		{
			this.57[i] = new Dictionary<int, float>();
		}
	}

	// Token: 0x06005034 RID: 20532 RVA: 0x001F98B4 File Offset: 0x001F7AB4
	internal 1262(string 1)
	{
		this.58 = Path.GetFileName(1);
		this.45(Path.GetDirectoryName(1));
		this.65();
	}

	// Token: 0x06005035 RID: 20533 RVA: 0x001F99B9 File Offset: 0x001F7BB9
	internal new bool 2()
	{
		return 1662.78 == 1677.Edit || 1662.79 is 2485;
	}

	// Token: 0x06005036 RID: 20534 RVA: 0x001F99D2 File Offset: 0x001F7BD2
	internal new 2147 3()
	{
		return this.77;
	}

	// Token: 0x06005037 RID: 20535 RVA: 0x001F99DA File Offset: 0x001F7BDA
	internal new void 4(2147 1)
	{
		if (Enum.IsDefined(typeof(2147), 1))
		{
			this.77 = 1;
			return;
		}
		this.77 = 2147.Osu;
	}

	// Token: 0x06005038 RID: 20536 RVA: 0x001F9A02 File Offset: 0x001F7C02
	public int CompareTo(1262 1)
	{
		return this.58.CompareTo(1.58);
	}

	// Token: 0x06005039 RID: 20537 RVA: 0x001F9A18 File Offset: 0x001F7C18
	internal new void 5()
	{
		string str = this.7;
		string text = (this.89.Length > 0) ? (" [" + this.89 + "]") : string.Empty;
		if (this.7.Length > 0)
		{
			this.81 = str + " - " + this.10;
			str = ((this.82.Length > 0) ? (this.82 + " (" + this.7 + ")") : this.7);
			this.49 = this.81 + text;
			this.50 = str + " - " + this.10 + text;
		}
		else if (this.10.Length > 0)
		{
			this.81 = this.10;
			this.49 = this.10 + text;
			this.50 = this.49;
		}
		else
		{
			this.81 = Path.GetFileName(this.58);
			this.49 = this.81;
			this.50 = this.49;
		}
		if (!string.IsNullOrEmpty(this.34))
		{
			this.49 = this.49 + " (" + this.34 + ")";
			this.50 = this.50 + " (" + this.34 + ")";
		}
		if (this.10.Length > 0)
		{
			this.51 = this.10 + text;
			return;
		}
		this.51 = Path.GetFileName(this.58);
	}

	// Token: 0x0600503A RID: 20538 RVA: 0x001F9BBE File Offset: 0x001F7DBE
	internal new void 6()
	{
		1662.69(string.Format(1661.6(), this.25));
	}

	// Token: 0x0600503B RID: 20539 RVA: 0x001F9BDA File Offset: 0x001F7DDA
	internal new void 7()
	{
		1662.69(string.Format(1661.2(), this.29, this.25));
	}

	// Token: 0x0600503C RID: 20540 RVA: 0x001F9C01 File Offset: 0x001F7E01
	public override string ToString()
	{
		return this.49;
	}

	// Token: 0x0600503D RID: 20541 RVA: 0x001F9C09 File Offset: 0x001F7E09
	internal new void 8()
	{
		this.54 = 0.0;
	}

	// Token: 0x0600503E RID: 20542 RVA: 0x001F9C1A File Offset: 0x001F7E1A
	internal new string 9()
	{
		if (1304.119 && !string.IsNullOrEmpty(this.11))
		{
			return this.11;
		}
		return this.10;
	}

	// Token: 0x0600503F RID: 20543 RVA: 0x001F9C42 File Offset: 0x001F7E42
	internal new string 10()
	{
		if (1304.119 && !string.IsNullOrEmpty(this.8))
		{
			return this.8;
		}
		return this.7;
	}

	// Token: 0x06005040 RID: 20544 RVA: 0x001F9C6C File Offset: 0x001F7E6C
	internal new string 11()
	{
		if (1304.119 && !string.IsNullOrEmpty(this.8) && !string.IsNullOrEmpty(this.11))
		{
			return this.8 + " - " + this.11;
		}
		return this.81;
	}

	// Token: 0x06005041 RID: 20545 RVA: 0x001F9CBC File Offset: 0x001F7EBC
	internal string 12()
	{
		if (1304.119 && !string.IsNullOrEmpty(this.8) && !string.IsNullOrEmpty(this.11))
		{
			string text = (this.82.Length > 0) ? (this.82 + " (" + this.8 + ")") : this.8;
			string text2 = string.Empty;
			if (!string.IsNullOrEmpty(this.34))
			{
				text2 = " (" + this.34 + ")";
			}
			return string.Concat(new string[]
			{
				text,
				" - ",
				this.11,
				(this.89.Length > 0) ? (" [" + this.89 + "]") : string.Empty,
				text2
			});
		}
		return this.50;
	}

	// Token: 0x06005042 RID: 20546 RVA: 0x001F9DAC File Offset: 0x001F7FAC
	internal 2327 13()
	{
		double num = this.18(this.3(), 2023.None);
		if (num < 2.0)
		{
			return 2327.Easy;
		}
		if (num < 2.7)
		{
			return 2327.Normal;
		}
		if (num < 4.0)
		{
			return 2327.Hard;
		}
		if (num < 5.3)
		{
			return 2327.Insane;
		}
		if (num < 6.5)
		{
			return 2327.Expert;
		}
		return 2327.ExpertPlus;
	}

	// Token: 0x06005043 RID: 20547 RVA: 0x001F9E10 File Offset: 0x001F8010
	internal double 14()
	{
		return (double)((this.3 + this.4 + this.2 + 1052.19((float)this.65 / (float)this.52 * 8f, 0f, 16f)) / 38f * 5f);
	}

	// Token: 0x06005044 RID: 20548 RVA: 0x001F9E64 File Offset: 0x001F8064
	internal int 15()
	{
		return (int)Math.Round((double)((this.3 + this.4 + this.2 + 1052.19((float)this.65 / (float)this.52 * 8f, 0f, 16f)) / 38f * 5f));
	}

	// Token: 0x06005045 RID: 20549 RVA: 0x001F9EC0 File Offset: 0x001F80C0
	internal double 16()
	{
		if (this.54 > 0.0)
		{
			return this.54;
		}
		int num = (int)(this.40 + 2 * this.41 + 3 * this.42);
		double num2 = (double)num / (double)this.52;
		if (num == 0 || this.94.Count == 0)
		{
			return 0.0;
		}
		double num3 = ((double)((float)this.41 / (float)num) >= 0.1) ? (((double)(this.3 + this.4 + this.2) + Math.Max(0.0, Math.Min(4.0, 1000.0 / this.94[0].1 * this.5 - 1.5) * 2.5)) * 0.75) : ((double)(this.3 + this.4 + this.2));
		double val = (num3 > 21.0) ? ((Math.Min(num3, 30.0) / 3.0 * 4.0 + Math.Min(20.0 - 0.032 * Math.Pow(num2 - 5.0, 4.0), 20.0)) / 10.0) : ((num2 >= 2.5) ? ((Math.Min(num3, 18.0) / 18.0 * 10.0 + Math.Min(40.0 - 40.0 / Math.Pow(5.0, 3.5) * Math.Pow(Math.Min(num2, 5.0) - 5.0, 4.0), 40.0)) / 10.0) : ((num2 >= 1.0) ? ((Math.Min(num3, 18.0) / 18.0 * 10.0 + Math.Min(25.0 * (num2 - 1.0), 40.0)) / 10.0) : (Math.Min(num3, 18.0) / 18.0 * 10.0 / 10.0 + 0.25)));
		this.54 = Math.Min(5.0, val);
		return this.54;
	}

	// Token: 0x06005046 RID: 20550 RVA: 0x001FA198 File Offset: 0x001F8398
	public 1891 17(2147 1)
	{
		1891 result;
		switch (1)
		{
		case 2147.Taiko:
			result = new 2171(this);
			break;
		case 2147.CatchTheBeat:
			result = new 1850(this);
			break;
		case 2147.OsuMania:
			result = new 1957(this);
			break;
		default:
			result = new 2093(this);
			break;
		}
		return result;
	}

	// Token: 0x06005047 RID: 20551 RVA: 0x001FA1DE File Offset: 0x001F83DE
	public double 18(2147 1, 2023 2)
	{
		2 = 1891.7(2, 1, this);
		if (!this.57[(int)1].ContainsKey((int)2))
		{
			return 0.0;
		}
		return (double)this.57[(int)1][(int)2];
	}

	// Token: 0x06005048 RID: 20552 RVA: 0x001FA214 File Offset: 0x001F8414
	internal void 19(2147 1, 2023 2, double 3)
	{
		2 = 1891.7(2, 1, this);
		Dictionary<int, float> obj = this.57[(int)1];
		lock (obj)
		{
			this.57[(int)1][(int)2] = (float)3;
		}
	}

	// Token: 0x06005049 RID: 20553 RVA: 0x001FA26C File Offset: 0x001F846C
	internal void 20(2147 1, Dictionary<int, float> 2)
	{
		Dictionary<int, float> dictionary = this.57[(int)1];
		Dictionary<int, float> obj = dictionary;
		lock (obj)
		{
			foreach (KeyValuePair<int, float> keyValuePair in 2)
			{
				dictionary[keyValuePair.Key] = keyValuePair.Value;
			}
		}
	}

	// Token: 0x0600504A RID: 20554 RVA: 0x001FA2F4 File Offset: 0x001F84F4
	internal void 21(2147 1)
	{
		Dictionary<int, float> dictionary = this.57[(int)1];
		Dictionary<int, float> obj = dictionary;
		lock (obj)
		{
			foreach (int key in new List<int>(dictionary.Keys))
			{
				dictionary[key] = 0f - Math.Abs(dictionary[key]);
			}
		}
	}

	// Token: 0x0600504B RID: 20555 RVA: 0x001FA38C File Offset: 0x001F858C
	internal void 22()
	{
		this.23(this.38());
	}

	// Token: 0x0600504C RID: 20556 RVA: 0x001FA39A File Offset: 0x001F859A
	internal void 23(2147 1)
	{
		this.20(1, this.27(1));
	}

	// Token: 0x0600504D RID: 20557 RVA: 0x001FA3AC File Offset: 0x001F85AC
	internal void 24(2039 1)
	{
		1891 2 = this.17(this.3());
		this.19(this.3(), 1.22, 2.12(1.22, null, 1));
	}

	// Token: 0x0600504E RID: 20558 RVA: 0x001FA3F0 File Offset: 0x001F85F0
	public void 25(915 1, 639 2, 1189 3)
	{
		this.26(1, 2, this.38(), 3);
	}

	// Token: 0x0600504F RID: 20559 RVA: 0x001FA404 File Offset: 0x001F8604
	public void 26(915 1, 639 2, 2147 3, 1189 4)
	{
		1262.1264 difficultyCalculationJob = new 1262.1264();
		difficultyCalculationJob.1 = this;
		difficultyCalculationJob.2 = 4;
		difficultyCalculationJob.4 = 1;
		difficultyCalculationJob.5 = 3;
		if (!this.35(difficultyCalculationJob.5))
		{
			difficultyCalculationJob.2();
			return;
		}
		List<int> obj = 1262.14;
		lock (obj)
		{
			if (1262.14.Contains(this.25))
			{
				difficultyCalculationJob.2();
				return;
			}
		}
		difficultyCalculationJob.3 = null;
		difficultyCalculationJob.3 = difficultyCalculationJob.4.Method36622(delegate()
		{
			1262.1265 5 = new 1262.1265();
			5.2 = difficultyCalculationJob;
			while (1662.78 == 1677.Play)
			{
				Thread.Sleep(1000);
			}
			1187 6 = 1662.89.2(new 1189(difficultyCalculationJob.1), (int)1262.13.TotalMilliseconds, false);
			1262 7 = difficultyCalculationJob.1;
			lock (7)
			{
				difficultyCalculationJob.1.99 = true;
			}
			1338.5(string.Format("({0}) difficulty calculation started.", difficultyCalculationJob.1.25), 1341.Runtime, (1114)1);
			5.1 = difficultyCalculationJob.1.27(difficultyCalculationJob.5);
			1338.5(string.Format("({0}) difficulty calculation completed.", difficultyCalculationJob.1.25), 1341.Runtime, (1114)1);
			7 = difficultyCalculationJob.1;
			lock (7)
			{
				difficultyCalculationJob.1.99 = false;
			}
			6.Cancel();
			1662.89.Schedule(new 1189(5.1), false);
		}, 2);
	}

	// Token: 0x06005050 RID: 20560 RVA: 0x001FA4FC File Offset: 0x001F86FC
	public Dictionary<int, float> 27(2147 1)
	{
		1891 2 = this.17(1);
		Dictionary<int, float> dictionary = new Dictionary<int, float>();
		foreach (2023 3 in 2.1())
		{
			dictionary[(int)3] = (float)2.12(3, null, null);
		}
		2.ReleaseHitObjectManager();
		return dictionary;
	}

	// Token: 0x06005051 RID: 20561 RVA: 0x001FA54C File Offset: 0x001F874C
	internal double 28()
	{
		if (this.55 > 0.0)
		{
			return this.55;
		}
		float num = (this.52 != 0) ? ((float)this.52) : 10000f;
		if (this.3() == 2147.OsuMania)
		{
			this.55 = ((double)(this.3 + this.2) / 1.5 + (double)Math.Max((float)this.65 / num * 9f, 0f)) / 38.0 * 5.0 / 1.5;
		}
		else
		{
			this.55 = ((double)(this.3 + 1052.19(this.1, 4f, 7f)) / 1.5 + (double)Math.Max((float)this.65 / num * 9f, 0f)) / 38.0 * 5.0 / 1.15;
		}
		this.55 = Math.Min(this.55, 12.0);
		return this.55;
	}

	// Token: 0x06005052 RID: 20562 RVA: 0x001FA678 File Offset: 0x001F8878
	internal double 29()
	{
		if (this.56 > 0.0)
		{
			return this.56;
		}
		if (this.94 == null || this.94.Count == 0)
		{
			return 0.0;
		}
		double num = (this.52 == 0) ? ((this.94[this.94.Count - 1].3 + 1.0) / 1000.0) : ((double)this.52);
		float num2 = (float)this.40 + (float)this.41 * 1.2f;
		if (num2 == 0f)
		{
			this.56 = 0.0;
		}
		else
		{
			this.56 = Math.Min((double)(this.3 / 14f + this.4 / 12f) + (double)num2 / num / 2.3 * Math.Pow(1.04, (double)(this.2 - 3f)), 5.0);
		}
		return this.56;
	}

	// Token: 0x06005053 RID: 20563 RVA: 0x001FA790 File Offset: 0x001F8990
	internal void 30()
	{
		this.56 = 0.0;
		this.55 = 0.0;
		this.54 = 0.0;
		Dictionary<int, float>[] array = this.57;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].Clear();
		}
	}

	// Token: 0x06005054 RID: 20564 RVA: 0x001FA7E8 File Offset: 0x001F89E8
	internal double 31()
	{
		double? num = this.32();
		if (num != null)
		{
			return num.Value;
		}
		bool flag;
		double? num2 = 1285.Get(this, out flag);
		if (num2 != null)
		{
			this.114 = num2.Value;
			return num2.Value;
		}
		if (flag && this.114 > 0.0)
		{
			return this.114;
		}
		this.114 = Math.Abs(this.18(this.38(), 1929.2(this.38(), 2019.1)));
		return this.114;
	}

	// Token: 0x06005055 RID: 20565 RVA: 0x001FA87C File Offset: 0x001F8A7C
	private double? 32()
	{
		2023 <<EMPTY_NAME>> = 2019.1;
		if (1662.78 != 1677.SelectPlay || !2099.1(<<EMPTY_NAME>>) || 2099.Current == 2100.NoNerfs || this.38() != 2147.Osu || this != 1272.5())
		{
			return null;
		}
		1890 2 = 2237.5(this, 2147.Osu, 1929.2(2147.Osu, <<EMPTY_NAME>>), 1926.3(2147.Osu), 1939.16(<<EMPTY_NAME>>), null);
		if (2 != null)
		{
			return new double?(2237.StarRating(2));
		}
		return null;
	}

	// Token: 0x06005056 RID: 20566 RVA: 0x001FA8F8 File Offset: 0x001F8AF8
	internal double 33(bool 1)
	{
		double? num = 1285.1(this);
		if (num != null)
		{
			return num.Value;
		}
		return Math.Abs(this.18(this.38(), 1929.2(this.38(), 2019.1)));
	}

	// Token: 0x06005057 RID: 20567 RVA: 0x001FA93E File Offset: 0x001F8B3E
	internal double 34()
	{
		if (this.3() == 2147.OsuMania)
		{
			return this.29();
		}
		return this.16();
	}

	// Token: 0x06005058 RID: 20568 RVA: 0x001FA956 File Offset: 0x001F8B56
	internal bool 35(2147 1)
	{
		if (!this.57[(int)1].ContainsKey(0))
		{
			return !this.99;
		}
		return this.57[(int)1][0] < 0f && !this.99;
	}

	// Token: 0x06005059 RID: 20569 RVA: 0x001FA992 File Offset: 0x001F8B92
	internal bool 36()
	{
		return this.35(this.38());
	}

	// Token: 0x0600505A RID: 20570 RVA: 0x001FA9A0 File Offset: 0x001F8BA0
	internal double 37()
	{
		double num = this.31();
		if (num >= 0.0)
		{
			return num;
		}
		return this.34();
	}

	// Token: 0x0600505B RID: 20571 RVA: 0x001FA9C8 File Offset: 0x001F8BC8
	internal 2147 38()
	{
		if (this.3() != 2147.Osu)
		{
			return this.3();
		}
		return 2486.14();
	}

	// Token: 0x0600505C RID: 20572 RVA: 0x001FA9E0 File Offset: 0x001F8BE0
	internal string 39()
	{
		double value = 2039.23((double)1926.4(1928.CircleSize, this.2), 1.3);
		double value2 = 2039.23((double)1926.4(1928.DrainRate, this.3), 1.4);
		double num = 2039.23((double)1926.4(1928.ApproachRate, this.1), 1.4);
		double num2 = 2039.23((double)1926.4(1928.OverallDifficulty, this.4), 1.4);
		2147 <<EMPTY_NAME>> = this.38();
		double num3 = 1939.19(2019.1);
		if (num3 != 1.0)
		{
			if (<<EMPTY_NAME>> == 2147.Osu || <<EMPTY_NAME>> == 2147.CatchTheBeat)
			{
				num = 1262.40(num, num3);
			}
			if (<<EMPTY_NAME>> == 2147.Osu)
			{
				num2 = (80.0 - (80.0 - 6.0 * num2) / num3) / 6.0;
			}
			else if (<<EMPTY_NAME>> == 2147.Taiko)
			{
				num2 = (50.0 - (50.0 - 3.0 * num2) / num3) / 3.0;
			}
		}
		string text = string.Empty;
		double num4 = this.31();
		switch (<<EMPTY_NAME>>)
		{
		case 2147.Osu:
		case 2147.CatchTheBeat:
			text += "CS:{0:0.##} AR:{1} ";
			break;
		case 2147.OsuMania:
			text += "Keys:{0:0} ";
			break;
		}
		text += "OD:{2:0.##} HP:{3:0.##} ";
		if (num4 >= 0.0)
		{
			text += "Star Rating: {4:0.##}★";
		}
		string text2 = 1926.1(1926.4(1928.ApproachRate, this.1)) ? "-inf" : Math.Round(num, 2).ToString("0.##", CultureInfo.CurrentCulture);
		string text3 = string.Format(text, new object[]
		{
			(<<EMPTY_NAME>> == 2147.OsuMania) ? ((double)2011.52(this)) : Math.Round(value, 2),
			text2,
			Math.Round(num2, 2),
			Math.Round(value2, 2),
			1052.21(num4, 2U)
		});
		if (this.72 != 0 || this.67 != 0)
		{
			text3 = text3 + "\n" + string.Format(1568.1(2679.SongSelection_CustomOffset), new object[]
			{
				(this.72 > 0) ? "+" : string.Empty,
				this.72,
				(this.67 > 0) ? "+" : string.Empty,
				this.67
			});
		}
		return text3;
	}

	// Token: 0x0600505D RID: 20573 RVA: 0x001FAC7C File Offset: 0x001F8E7C
	private static double 40(double 1, double 2)
	{
		double num = ((1 > 5.0) ? (1200.0 - 750.0 * (1 - 5.0) / 5.0) : (1200.0 + 600.0 * (5.0 - 1) / 5.0)) / 2;
		if (num <= 1200.0)
		{
			return 5.0 + (1200.0 - num) / 150.0;
		}
		return 5.0 - (num - 1200.0) / 120.0;
	}

	// Token: 0x0600505E RID: 20574 RVA: 0x001FAD38 File Offset: 0x001F8F38
	internal string 41()
	{
		string result = string.Empty;
		switch (this.38())
		{
		case 2147.Taiko:
		{
			2184 <<EMPTY_NAME>> = new 2184(false);
			<<EMPTY_NAME>>.45 = 1926.3(this.38());
			<<EMPTY_NAME>>.46 = 1939.16(2019.1);
			<<EMPTY_NAME>>.6(this, 2019.1);
			<<EMPTY_NAME>>.RecalculateDifficulty(false, false, true);
			result = string.Format(1568.1(2679.SongSelection_DifficultyInfo_Tooltip_Taiko), 2039.21((double)<<EMPTY_NAME>>.5 - 0.5), 2039.21((double)<<EMPTY_NAME>>.4 - 0.5));
			<<EMPTY_NAME>>.Dispose();
			break;
		}
		case 2147.CatchTheBeat:
		{
			1875 2 = new 1875(false);
			2.45 = 1926.3(this.38());
			2.46 = 1939.16(2019.1);
			2.6(this, 2019.1);
			2.RecalculateDifficulty(false, false, true);
			result = string.Format(1568.1(2679.SongSelection_DifficultyInfo_Tooltip_CatchTheBeat), 2039.21((double)2.2), 2.1);
			2.Dispose();
			break;
		}
		case 2147.OsuMania:
		{
			1975 3 = new 1975(false);
			3.45 = 1926.3(this.38());
			3.46 = 1939.16(2019.1);
			3.6(this, 2019.1);
			3.RecalculateDifficulty(false, false, false);
			result = string.Format(1568.1(2679.SongSelection_DifficultyInfo_Tooltip_Mania), new object[]
			{
				2039.21((double)3.59 + 0.5),
				2039.21((double)3.5 + 0.5),
				2039.21((double)3.60 + 0.5),
				2039.21((double)3.4 + 0.5),
				2039.21((double)3.3 + 0.5)
			});
			3.Dispose();
			break;
		}
		default:
		{
			2122 4 = new 2122(false);
			4.45 = 1926.3(this.38());
			4.46 = 1939.16(2019.1);
			4.6(this, 2019.1);
			4.RecalculateDifficulty(false, false, true);
			result = string.Format(1568.1(2679.SongSelection_DifficultyInfo_Tooltip_Osu), new object[]
			{
				2039.21((double)4.2),
				2039.21((double)4.5 - 0.5),
				2039.21((double)4.4 - 0.5),
				2039.21((double)4.3 - 0.5),
				4.7,
				4.1
			});
			4.Dispose();
			break;
		}
		}
		return result;
	}

	// Token: 0x0600505F RID: 20575 RVA: 0x001FB059 File Offset: 0x001F9259
	internal bool 42()
	{
		return this.20;
	}

	// Token: 0x06005060 RID: 20576 RVA: 0x001FB061 File Offset: 0x001F9261
	internal void 43(bool 1)
	{
		this.20 = 1;
	}

	// Token: 0x06005061 RID: 20577 RVA: 0x001FB06A File Offset: 0x001F926A
	internal string 44()
	{
		return Path.Combine(1272.1, this.37);
	}

	// Token: 0x06005062 RID: 20578 RVA: 0x001FB07C File Offset: 0x001F927C
	internal void 45(string 1)
	{
		1 = 2672.17(1);
		if (1.LastIndexOf(Path.DirectorySeparatorChar) >= 0)
		{
			int num = 1.IndexOf(1272.1);
			if (num >= 0)
			{
				1 = 1.Substring(num + 1272.1.Length);
			}
		}
		this.37 = 1.Trim(new char[]
		{
			Path.DirectorySeparatorChar
		});
	}

	// Token: 0x06005063 RID: 20579 RVA: 0x001FB0E0 File Offset: 0x001F92E0
	internal Stream 46()
	{
		if (!this.42())
		{
			return null;
		}
		if (this.55() == null || this.58(this.18))
		{
			return this.48(this.18);
		}
		Stream stream = this.55().30(this.18);
		if (stream == null)
		{
			this.43(false);
			return null;
		}
		return stream;
	}

	// Token: 0x06005064 RID: 20580 RVA: 0x001FB139 File Offset: 0x001F9339
	internal Stream 47()
	{
		return this.48(this.58);
	}

	// Token: 0x06005065 RID: 20581 RVA: 0x001FB148 File Offset: 0x001F9348
	internal Stream 48(string 1)
	{
		Stream result;
		try
		{
			if (this.55() == null)
			{
				1 = Path.Combine(this.44(), 1);
				if (!File.Exists(1))
				{
					result = null;
				}
				else
				{
					result = File.OpenRead(1);
				}
			}
			else if (this.58(1))
			{
				result = File.OpenRead(Path.Combine(this.53(), 1));
			}
			else
			{
				result = this.55().30(1);
			}
		}
		catch (Exception arg)
		{
			1338.5(string.Format("{0} could not be loaded.\n{1}", 1, arg), 1341.Runtime, (1114)1);
			result = null;
		}
		return result;
	}

	// Token: 0x06005066 RID: 20582 RVA: 0x001FB1D8 File Offset: 0x001F93D8
	internal byte[] 49(string 1)
	{
		byte[] array = null;
		if (this.55() != null && !this.55().40(1, false))
		{
			return null;
		}
		try
		{
			using (Stream stream = this.48(1))
			{
				if (stream != null)
				{
					array = new byte[stream.Length];
					stream.Read(array, 0, array.Length);
					stream.Close();
				}
			}
		}
		finally
		{
			if (this.55() != null)
			{
				this.55().41();
			}
		}
		return array;
	}

	// Token: 0x06005067 RID: 20583 RVA: 0x001FB268 File Offset: 0x001F9468
	internal bool 50(string 1, string 2)
	{
		if (1 == 2)
		{
			return true;
		}
		if (this.61)
		{
			return false;
		}
		bool result;
		try
		{
			result = 2672.16(Path.Combine(this.44(), 1), Path.Combine(this.44(), 2), true);
		}
		catch
		{
			result = false;
		}
		return result;
	}

	// Token: 0x06005068 RID: 20584 RVA: 0x001FB2C4 File Offset: 0x001F94C4
	internal void 51(string 1)
	{
		if (this.61)
		{
			this.55().37(1);
			this.55().Save();
			return;
		}
		1292.2(Path.Combine(this.44(), 1));
	}

	// Token: 0x06005069 RID: 20585 RVA: 0x001FB2F9 File Offset: 0x001F94F9
	internal bool 52(string 1)
	{
		if (string.IsNullOrEmpty(1))
		{
			return false;
		}
		if (this.55() == null)
		{
			return File.Exists(Path.Combine(this.44(), 1));
		}
		return this.55().28(1) || this.58(1);
	}

	// Token: 0x0600506A RID: 20586 RVA: 0x001FB336 File Offset: 0x001F9536
	internal string 53()
	{
		if (this.95 == null)
		{
			return null;
		}
		if (!Directory.Exists(this.95))
		{
			this.95 = null;
			return null;
		}
		return this.95;
	}

	// Token: 0x0600506B RID: 20587 RVA: 0x001FB35E File Offset: 0x001F955E
	internal void 54(string 1)
	{
		this.95 = 1;
	}

	// Token: 0x0600506C RID: 20588 RVA: 0x001FB368 File Offset: 0x001F9568
	internal 1514 55()
	{
		if (!this.61)
		{
			return null;
		}
		if (!this.100 && this.15 != null)
		{
			return this.15;
		}
		1514 <<EMPTY_NAME>> = 1520.1(this.44());
		if (this.15 != null || this.100)
		{
			this.15 = <<EMPTY_NAME>>;
			return <<EMPTY_NAME>>;
		}
		if (<<EMPTY_NAME>> == null)
		{
			string text = this.44().Replace(".osz2", string.Empty) + ".osz2";
			if (!File.Exists(text))
			{
				return null;
			}
			<<EMPTY_NAME>> = 1520.1(text);
			if (<<EMPTY_NAME>> == null)
			{
				this.100 = false;
				return null;
			}
			this.45(text);
			this.61 = true;
		}
		this.100 = true;
		this.15 = <<EMPTY_NAME>>;
		return this.15;
	}

	// Token: 0x0600506D RID: 20589 RVA: 0x001FB41D File Offset: 0x001F961D
	internal void 56(1514 1)
	{
		if (1 != null)
		{
			this.15 = 1;
			this.61 = true;
		}
	}

	// Token: 0x0600506E RID: 20590 RVA: 0x001FB430 File Offset: 0x001F9630
	internal void 57()
	{
		try
		{
			string text = Path.Combine(this.44(), this.58);
			File.Delete(text);
			File.Move(text + "_", text);
			string text2 = this.23;
			List<string> list = 1297.4(text2);
			this.65();
			if (list != null && list.Count > 0)
			{
				foreach (string <<EMPTY_NAME>> in list)
				{
					1297.11(<<EMPTY_NAME>>, text2);
					1297.9(<<EMPTY_NAME>>, this.23);
				}
			}
			this.30();
			if (1662.79 is 2601)
			{
				((2601)1662.79).37(this, (639)2);
			}
		}
		catch
		{
		}
	}

	// Token: 0x0600506F RID: 20591 RVA: 0x001FB508 File Offset: 0x001F9708
	internal bool 58(string 1)
	{
		return this.2() && this.53() != null && File.Exists(Path.Combine(this.53(), 1));
	}

	// Token: 0x06005070 RID: 20592 RVA: 0x001FB530 File Offset: 0x001F9730
	internal 1514 59(string 1, bool 2)
	{
		1262.1267 packageImportState = new 1262.1267();
		packageImportState.1 = this;
		packageImportState.2 = 2;
		packageImportState.3 = 3;
		if (this.29 <= 0)
		{
			throw new InvalidOperationException("Cannot convert a map to osz2 which does not have a Beatmapset ID.");
		}
		if (this.61)
		{
			return null;
		}
		try
		{
			1272.15.EnableRaisingEvents = false;
			if (!2672.20(packageImportState.3))
			{
				1338.5("Submission Error: Could not delete existing osz2 file.", 1341.Runtime, (1114)1);
				return null;
			}
			packageImportState.4 = 1520.2(packageImportState.3, true, false);
			if (packageImportState.4 == null)
			{
				return null;
			}
			if (!packageImportState.4.40(50, false))
			{
				return null;
			}
			try
			{
				packageImportState.4.33(this.44(), true);
				packageImportState.4.32(1513.BeatmapSetID, Convert.ToString(this.29));
				packageImportState.4.32(1513.Artist, this.7);
				packageImportState.4.32(1513.Creator, this.43);
				packageImportState.4.32(1513.Source, this.82);
				packageImportState.4.32(1513.Title, this.10);
				packageImportState.4.32(1513.TitleUnicode, this.11);
				packageImportState.4.32(1513.ArtistUnicode, this.8);
				packageImportState.4.32(1513.Tags, this.9);
			}
			catch
			{
				packageImportState.4.Close();
				return null;
			}
			string path = this.44();
			1272.3.FindAll(new Predicate<1262>(packageImportState.1)).ForEach(delegate(1262 1)
			{
				if (packageImportState.2)
				{
					1.45(packageImportState.3);
					1.58 = Path.GetFileName(1.58);
					1.18 = Path.GetFileName(1.18);
					1.15 = packageImportState.4;
					1.61 = true;
				}
				packageImportState.4.27(1.58, 1.25);
			});
			packageImportState.4.Save(false);
			if (!this.44().EndsWith(1272.1) & packageImportState.2)
			{
				1226.103();
				Directory.Delete(path, true);
			}
		}
		finally
		{
			1272.15.EnableRaisingEvents = true;
		}
		return packageImportState.4;
	}

	// Token: 0x06005071 RID: 20593 RVA: 0x001FB7C4 File Offset: 0x001F99C4
	internal string 60()
	{
		if (!this.61)
		{
			return null;
		}
		string text = this.53();
		if (text == null)
		{
			text = Path.Combine(1345.4(), "Data", "e", string.Format("{0} - {1}", this.29, this.10));
		}
		if (!Directory.Exists(text))
		{
			Directory.CreateDirectory(text);
		}
		this.54(text);
		return this.53();
	}

	// Token: 0x06005072 RID: 20594 RVA: 0x001FB834 File Offset: 0x001F9A34
	internal string 61(string 1, bool 2)
	{
		byte[] array = this.49(1);
		if (array == null)
		{
			return null;
		}
		this.60();
		string text = Path.Combine(this.53(), 1);
		if (File.Exists(text) && !2)
		{
			return text;
		}
		string result;
		try
		{
			File.WriteAllBytes(text, array);
			result = text;
		}
		catch
		{
			result = null;
		}
		return result;
	}

	// Token: 0x06005073 RID: 20595 RVA: 0x001FB894 File Offset: 0x001F9A94
	internal bool 62(1262.1266 1, bool 2)
	{
		bool result = true;
		this.60();
		if (!this.55().40(100, false))
		{
			return false;
		}
		try
		{
			foreach (1519 3 in this.55().39())
			{
				string text = 3.1();
				if (!1514.22(text) && !1514.20(text))
				{
					string text2 = Path.Combine(this.53(), text);
					string directoryName = Path.GetDirectoryName(text2);
					if (!Directory.Exists(directoryName))
					{
						Directory.CreateDirectory(directoryName);
					}
					if (File.Exists(text2))
					{
						DateTime lastWriteTimeUtc = File.GetLastWriteTimeUtc(text2);
						FileInfo fileInfo = new FileInfo(text2);
						long num = 0L;
						long num2 = 0L;
						try
						{
							num = lastWriteTimeUtc.ToFileTime();
							num2 = 3.11().ToFileTime();
						}
						catch
						{
						}
						if (Math.Abs(num2 - num) < 200000000L && fileInfo.Length == (long)(3.3() - 4))
						{
							continue;
						}
						switch (1)
						{
						case (1262.1266)0:
						{
							1693 4 = new 1693(text2, (int)fileInfo.Length, fileInfo.LastWriteTime, Path.Combine(this.44(), text), 3.3(), 3.11().ToLocalTime());
							try
							{
								if (4.ShowDialog(1662.13()) != DialogResult.Ignore)
								{
									switch (4.1())
									{
									case (1693.1694)2:
										1 = (1262.1266)1;
										break;
									case (1693.1694)3:
										continue;
									case (1693.1694)4:
										1 = (1262.1266)3;
										continue;
									}
									goto IL_1A5;
								}
								continue;
							}
							finally
							{
								((IDisposable)4).Dispose();
							}
							break;
						}
						case (1262.1266)1:
							goto IL_1A5;
						case (1262.1266)2:
							break;
						case (1262.1266)3:
							continue;
						default:
							goto IL_1A5;
						}
						if (3.11() < lastWriteTimeUtc)
						{
							continue;
						}
					}
					else if (2)
					{
						continue;
					}
					IL_1A5:
					using (Stream stream = this.55().30(text))
					{
						if (stream.Length == 0L)
						{
							File.WriteAllBytes(text2, new byte[0]);
						}
						else
						{
							using (FileStream fileStream = File.Create(text2, (int)stream.Length, FileOptions.WriteThrough))
							{
								byte[] array = new byte[stream.Length];
								stream.Read(array, 0, array.Length);
								fileStream.Write(array, 0, array.Length);
								fileStream.Flush();
							}
						}
					}
					try
					{
						File.SetCreationTimeUtc(text2, 3.9());
						File.SetLastWriteTimeUtc(text2, 3.11());
					}
					catch
					{
					}
				}
			}
		}
		catch
		{
			result = false;
		}
		finally
		{
			this.55().41();
		}
		return result;
	}

	// Token: 0x06005074 RID: 20596 RVA: 0x001FBBE8 File Offset: 0x001F9DE8
	internal void 63()
	{
		1520.3(this.15);
		this.15 = null;
	}

	// Token: 0x06005075 RID: 20597 RVA: 0x001FBBFC File Offset: 0x001F9DFC
	internal 1262 64()
	{
		if (string.IsNullOrEmpty(this.58) || string.IsNullOrEmpty(this.44()))
		{
			return null;
		}
		1262 result;
		try
		{
			result = new 1262(Path.Combine(this.44(), this.58));
		}
		catch (Exception arg)
		{
			1338.5(string.Format("({0}) difficulty calculation failed during construction ({1}).", this.25, arg), 1341.Runtime, (1114)1);
			result = null;
		}
		return result;
	}

	// Token: 0x06005076 RID: 20598 RVA: 0x001FBC74 File Offset: 0x001F9E74
	internal bool 65()
	{
		List<1259> list = new List<1259>();
		bool flag = 1226.11() == this;
		if (flag)
		{
			1226.69();
			1226.62(1253.Default);
		}
		this.78 = -1;
		this.19 = 0;
		this.65 = 0;
		this.52 = 0;
		this.41 = 0;
		this.40 = 0;
		this.42 = 0;
		this.32 = 14;
		this.90 = 0;
		this.83 = 0.7f;
		this.38 = (1284)1;
		this.105 = 1290.NoChange;
		this.44 = false;
		this.22 = null;
		this.4(2147.Osu);
		this.48 = 1254.Normal;
		this.60 = false;
		bool flag2 = false;
		if (this.61)
		{
			if (this.55() == null)
			{
				return false;
			}
			if (this.29 <= 0)
			{
				this.29 = Convert.ToInt32(this.55().29(1513.BeatmapSetID));
			}
			this.10 = this.55().29(1513.Title);
			this.54(Path.Combine(1345.4(), "Data", "e", string.Format("{0} - {1}", this.29, this.10)));
		}
		using (Stream stream = this.47())
		{
			if (stream == null)
			{
				this.28 = false;
				this.38 = (1284)0;
				this.29 = -1;
				this.25 = 0;
				this.94 = list;
				return false;
			}
			this.28 = true;
			StreamReader streamReader = new StreamReader(stream);
			try
			{
				this.70();
				this.47 = ((this.37 != null) ? File.GetLastWriteTimeUtc(this.61 ? this.44() : this.68()) : DateTime.MinValue);
				1288 <<EMPTY_NAME>> = 1288.Unknown;
				int num = -1;
				int num2 = -1;
				int num3 = -1;
				string text = string.Empty;
				string text2 = string.Empty;
				int num4 = 0;
				char[] separator = new char[]
				{
					','
				};
				int num5 = 0;
				try
				{
					if (!streamReader.EndOfStream)
					{
						string text3 = streamReader.ReadLine();
						if (text3.IndexOf("osu file format") == 0)
						{
							this.32 = int.Parse(text3.Remove(0, text3.LastIndexOf('v') + 1));
							if (flag)
							{
								1226.62((this.32 < 4) ? 1253.Custom1 : 1253.Default);
							}
							this.90 = ((this.32 < 5 && 1662.78 == 1677.Edit) ? 24 : 0);
						}
					}
					while (!streamReader.EndOfStream)
					{
						string text4 = streamReader.ReadLine().Trim();
						num5++;
						if (text4.Length != 0)
						{
							string text5 = string.Empty;
							string text6 = string.Empty;
							if (<<EMPTY_NAME>> != 1288.HitObjects)
							{
								int num6 = text4.IndexOf(':');
								if (num6 >= 0)
								{
									text5 = text4.Remove(num6).Trim();
									text6 = text4.Remove(0, num6 + 1).Trim();
								}
								else if (text4[0] == '[')
								{
									try
									{
										<<EMPTY_NAME>> = (1288)Enum.Parse(typeof(1288), text4.Trim(new char[]
										{
											'[',
											']'
										}));
										continue;
									}
									catch
									{
										continue;
									}
								}
							}
							if (<<EMPTY_NAME>> <= 1288.Metadata)
							{
								if (<<EMPTY_NAME>> != 1288.General)
								{
									if (<<EMPTY_NAME>> != 1288.Colours)
									{
										if (<<EMPTY_NAME>> == 1288.Metadata)
										{
											uint num7 = 1197.1(text5);
											if (num7 <= 1992138944U)
											{
												if (num7 <= 1573770551U)
												{
													if (num7 != 617902505U)
													{
														if (num7 == 1573770551U)
														{
															if (text5 == "Version")
															{
																this.89 = text6;
															}
														}
													}
													else if (text5 == "Title")
													{
														this.10 = text6;
													}
												}
												else if (num7 != 1642243064U)
												{
													if (num7 != 1711094138U)
													{
														if (num7 == 1992138944U)
														{
															if (text5 == "Tags")
															{
																this.9 = text6;
															}
														}
													}
													else if (text5 == "BeatmapSetID" && this.29 == -1)
													{
														this.29 = Convert.ToInt32(text6);
													}
												}
												else if (text5 == "Source")
												{
													this.82 = text6;
												}
											}
											else if (num7 <= 2490816510U)
											{
												if (num7 != 2258803444U)
												{
													if (num7 == 2490816510U)
													{
														if (text5 == "Artist")
														{
															this.7 = text6;
														}
													}
												}
												else if (text5 == "TitleUnicode")
												{
													this.11 = text6;
												}
											}
											else if (num7 != 3198710089U)
											{
												if (num7 != 3382753380U)
												{
													if (num7 == 4291165879U)
													{
														if (text5 == "Creator")
														{
															this.43 = text6;
														}
													}
												}
												else if (text5 == "BeatmapID" && this.25 == 0)
												{
													this.25 = Convert.ToInt32(text6);
												}
											}
											else if (text5 == "ArtistUnicode")
											{
												this.8 = text6;
											}
										}
									}
									else
									{
										this.44 = true;
									}
								}
								else
								{
									uint num7 = 1197.1(text5);
									if (num7 <= 2167992445U)
									{
										if (num7 <= 1192550549U)
										{
											if (num7 <= 749010473U)
											{
												if (num7 != 277247333U)
												{
													if (num7 == 749010473U)
													{
														if (text5 == "WidescreenStoryboard")
														{
															this.63 = (text6[0] == '1');
														}
													}
												}
												else if (text5 == "AudioHash")
												{
													this.17 = text6;
												}
											}
											else if (num7 != 906899804U)
											{
												if (num7 != 1037595928U)
												{
													if (num7 == 1192550549U)
													{
														if (text5 == "SpecialStyle")
														{
															this.91 = (text6[0] == '1');
														}
													}
												}
												else if (text5 == "AudioLeadIn")
												{
													this.19 = int.Parse(text6);
												}
											}
											else if (text5 == "AudioFilename" && text6.Length > 0)
											{
												this.18 = text6;
											}
										}
										else if (num7 <= 1397651250U)
										{
											if (num7 != 1392113653U)
											{
												if (num7 == 1397651250U)
												{
													if (text5 == "Mode")
													{
														this.4((2147)int.Parse(text6));
													}
												}
											}
											else if (text5 == "SkinPreference")
											{
												this.80 = text6;
											}
										}
										else if (num7 != 1454601404U)
										{
											if (num7 != 1665405120U)
											{
												if (num7 == 2167992445U)
												{
													if (text5 == "SampleSet")
													{
														this.48 = (1254)Enum.Parse(typeof(1254), text6);
														if (flag)
														{
															1226.25 = this.48;
														}
													}
												}
											}
											else if (text5 == "Countdown")
											{
												this.38 = (1284)int.Parse(text6);
											}
										}
										else if (text5 == "EpilepsyWarning")
										{
											this.106 = (text6[0] == '1');
										}
									}
									else if (num7 <= 3353878245U)
									{
										if (num7 <= 2369465937U)
										{
											if (num7 != 2299751581U)
											{
												if (num7 == 2369465937U)
												{
													if (text5 == "SampleVolume")
													{
														this.79 = int.Parse(text6);
													}
												}
											}
											else if (text5 == "CustomSamples" && flag)
											{
												1226.62((text6[0] == '1') ? 1253.Custom1 : 1253.Default);
											}
										}
										else if (num7 != 2576849862U)
										{
											if (num7 != 2801293904U)
											{
												if (num7 == 3353878245U)
												{
													if (text5 == "AlwaysShowPlayfield")
													{
														this.16 = (text6[0] == '1');
													}
												}
											}
											else if (text5 == "OverlayPosition")
											{
												this.105 = (1290)Enum.Parse(typeof(1290), text6, true);
											}
										}
										else if (text5 == "PreviewTime")
										{
											this.78 = int.Parse(text6);
										}
									}
									else if (num7 <= 3492706485U)
									{
										if (num7 != 3491551619U)
										{
											if (num7 == 3492706485U)
											{
												if (text5 == "TimelineZoom")
												{
													this.86 = float.Parse(text6);
												}
											}
										}
										else if (text5 == "CountdownOffset")
										{
											this.39 = Math.Max(Math.Min(int.Parse(text6), 3), 0);
										}
									}
									else if (num7 != 3513966430U)
									{
										if (num7 != 3626434118U)
										{
											if (num7 == 4088792625U)
											{
												if (text5 == "LetterboxInBreaks")
												{
													this.62 = (text6[0] == '1');
												}
											}
										}
										else if (text5 == "StackLeniency")
										{
											this.83 = Math.Max(0f, Math.Min(1f, float.Parse(text6, 1662.18)));
										}
									}
									else if (text5 == "SamplesMatchPlaybackRate")
									{
										this.93 = (text6[0] == '1');
									}
								}
							}
							else if (<<EMPTY_NAME>> <= 1288.Events)
							{
								if (<<EMPTY_NAME>> != 1288.TimingPoints)
								{
									if (<<EMPTY_NAME>> == 1288.Events)
									{
										char c = char.ToUpper(text4[0]);
										switch (c)
										{
										case '0':
										{
											string[] array = text4.Split(new char[]
											{
												','
											});
											this.22 = array[2].Trim(new char[]
											{
												'"'
											});
											break;
										}
										case '1':
											break;
										case '2':
										{
											string[] array2 = text4.Split(new char[]
											{
												','
											});
											num4 += int.Parse(array2[2]) - int.Parse(array2[1]);
											break;
										}
										case '3':
										{
											string[] array3 = text4.Split(new char[]
											{
												','
											});
											this.21 = new 198(byte.Parse(array3[2]), byte.Parse(array3[3]), byte.Parse(array3[4]));
											break;
										}
										default:
											if (c == 'S')
											{
												if (this.22 == null && char.ToUpper(text4[1]) == 'P')
												{
													string[] array4 = text4.Split(new char[]
													{
														','
													});
													this.22 = array4[3].Trim(new char[]
													{
														'"'
													});
												}
											}
											break;
										}
									}
								}
								else
								{
									1259 2 = 2039.52(text4, this.90, this.79, this.48);
									if (2 != null)
									{
										list.Add(2);
									}
								}
							}
							else if (<<EMPTY_NAME>> != 1288.HitObjects)
							{
								if (<<EMPTY_NAME>> == 1288.Difficulty)
								{
									if (!(text5 == "HPDrainRate"))
									{
										if (!(text5 == "CircleSize"))
										{
											if (!(text5 == "OverallDifficulty"))
											{
												if (!(text5 == "SliderMultiplier"))
												{
													if (!(text5 == "SliderTickRate"))
													{
														if (text5 == "ApproachRate")
														{
															if (this.32 >= 13)
															{
																this.1 = Math.Min(10f, Math.Max(0f, float.Parse(text6, 1662.18)));
															}
															else
															{
																this.1 = (float)Math.Min(10, Math.Max(0, byte.Parse(text6)));
															}
															flag2 = true;
														}
													}
													else
													{
														this.6 = Math.Max(0.5, Math.Min(8.0, double.Parse(text6, 1662.18)));
													}
												}
												else
												{
													this.5 = Math.Max(0.4, Math.Min(3.6, double.Parse(text6, 1662.18)));
												}
											}
											else
											{
												if (this.32 >= 13)
												{
													this.4 = Math.Min(10f, Math.Max(0f, float.Parse(text6, 1662.18)));
												}
												else
												{
													this.4 = (float)Math.Min(10, Math.Max(0, byte.Parse(text6)));
												}
												if (!flag2)
												{
													this.1 = this.4;
												}
											}
										}
										else if (this.32 >= 13)
										{
											if (this.3() == 2147.OsuMania)
											{
												this.2 = Math.Min(18f, Math.Max(1f, float.Parse(text6, 1662.18)));
											}
											else
											{
												this.2 = Math.Min(10f, Math.Max(0f, float.Parse(text6, 1662.18)));
											}
										}
										else
										{
											this.2 = (float)Math.Min(10, Math.Max(0, byte.Parse(text6)));
										}
									}
									else if (this.32 >= 13)
									{
										this.3 = Math.Min(10f, Math.Max(0f, float.Parse(text6, 1662.18)));
									}
									else
									{
										this.3 = (float)Math.Min(10, Math.Max(0, byte.Parse(text6)));
									}
								}
							}
							else
							{
								string[] array5 = text4.Split(separator, 7);
								if (num == -1)
								{
									num = (int)2678.2(array5[2], 2147483647.0, false);
								}
								int num8 = Convert.ToInt32(array5[3]) & 139;
								if (num8 <= 2)
								{
									if (num8 != 1)
									{
										if (num8 == 2)
										{
											this.41 += 1;
											text = array5[2];
											text2 = text;
										}
									}
									else
									{
										this.40 += 1;
										text = array5[2];
										text2 = text;
									}
								}
								else if (num8 != 8)
								{
									if (num8 == 128)
									{
										this.41 += 1;
										text = array5[5].Split(new char[]
										{
											':'
										})[0];
										text2 = text;
									}
								}
								else
								{
									this.42 += 1;
									text = array5[2];
									text2 = array5[5];
								}
								this.65++;
							}
						}
					}
				}
				catch (Exception arg)
				{
					1338.5(string.Format("An error occurred while processing {0} at line {1}\n{2}", this.58, num5, arg), 1341.Runtime, (1114)1);
					1763.2("Processing beatmap's headers failed.  This map is likely corrupt!", 3000, (1389)0);
				}
				if (this.29 <= 0 && this.85 != (1281)1 && this.37 != null)
				{
					string[] array6 = this.37.Split(new char[]
					{
						Path.DirectorySeparatorChar
					})[0].Split(new char[]
					{
						' '
					});
					if (array6.Length != 0 && !int.TryParse(array6[0], out this.29))
					{
						this.29 = -1;
					}
				}
				this.5();
				if (text.Length > 0)
				{
					num2 = (int)2678.2(text, 2147483647.0, false);
				}
				if (text2.Length > 0)
				{
					num3 = (int)2678.2(text2, 2147483647.0, false);
				}
				this.52 = (num2 - num - num4) / 1000;
				this.53 = (num3 - num - num4) / 1000;
				this.43(this.52(this.18));
				this.87 = num3;
				this.94 = list;
				this.8();
				this.59 = true;
			}
			finally
			{
				((IDisposable)streamReader).Dispose();
			}
		}
		return true;
	}

	// Token: 0x06005077 RID: 20599 RVA: 0x001FCCAC File Offset: 0x001FAEAC
	internal string 66()
	{
		return 2672.2(((this.7.Length > 0) ? (this.7 + " - " + this.10) : Path.GetFileNameWithoutExtension(this.18)) + ((this.43.Length > 0) ? (" (" + this.43 + ")") : string.Empty) + ((this.89.Length > 0) ? (" [" + this.89 + "]") : string.Empty) + ".osu");
	}

	// Token: 0x06005078 RID: 20600 RVA: 0x001FCD50 File Offset: 0x001FAF50
	internal string 67()
	{
		return 2672.2(((this.7.Length > 0) ? (this.7 + " - " + this.10) : Path.GetFileNameWithoutExtension(this.18)) + ((this.43.Length > 0) ? (" (" + this.43 + ")") : string.Empty) + ".osb");
	}

	// Token: 0x06005079 RID: 20601 RVA: 0x001FCDC8 File Offset: 0x001FAFC8
	internal string 68()
	{
		if (!this.61)
		{
			return Path.Combine(this.44(), this.58);
		}
		if (this.53() != null && this.2())
		{
			return Path.Combine(this.53(), this.58);
		}
		return this.58;
	}

	// Token: 0x0600507A RID: 20602 RVA: 0x001FCE18 File Offset: 0x001FB018
	public void ReadFrom(1647 1)
	{
		try
		{
			if (1272.9 >= 20160408 && 1272.9 < 20191106)
			{
				1.ReadInt32();
			}
			this.69(1);
		}
		catch (Exception 2)
		{
			1338.4(2, "beatmap database read failure", 1341.Runtime);
		}
	}

	// Token: 0x0600507B RID: 20603 RVA: 0x001FCE6C File Offset: 0x001FB06C
	private void 69(1647 1)
	{
		this.7 = 1.ReadString();
		if (1272.9 >= 1296.2)
		{
			this.8 = 1.ReadString();
		}
		this.10 = 1.ReadString();
		if (1272.9 >= 1296.2)
		{
			this.11 = 1.ReadString();
		}
		this.43 = 1.ReadString();
		this.89 = 1.ReadString();
		this.18 = 1.ReadString();
		this.23 = 1.ReadString();
		this.58 = 1.ReadString();
		this.85 = (1281)1.ReadByte();
		this.40 = 1.ReadUInt16();
		this.41 = 1.ReadUInt16();
		this.42 = 1.ReadUInt16();
		this.47 = 1.3();
		this.1 = 1.ReadSingle();
		this.2 = 1.ReadSingle();
		this.3 = 1.ReadSingle();
		this.4 = 1.ReadSingle();
		this.5 = 1.ReadDouble();
		for (int i = 0; i < 4; i++)
		{
			Dictionary<int, float> dictionary;
			if (1272.9 < 20250107)
			{
				IEnumerable<KeyValuePair<int, double>> source = 1.5<int, double>() as Dictionary<int, double>;
				dictionary = new Dictionary<int, float>();
				foreach (KeyValuePair<int, double> keyValuePair in source.ToArray<KeyValuePair<int, double>>())
				{
					if (1891.6((2023)keyValuePair.Key) == (2023)keyValuePair.Key)
					{
						dictionary[keyValuePair.Key] = (float)keyValuePair.Value;
					}
				}
			}
			else
			{
				dictionary = (1.5<int, float>() as Dictionary<int, float>);
			}
			if (1272.9 < 1262.12[i])
			{
				foreach (KeyValuePair<int, float> keyValuePair2 in dictionary.ToList<KeyValuePair<int, float>>())
				{
					dictionary[keyValuePair2.Key] = 0f - Math.Abs(keyValuePair2.Value);
				}
			}
			this.57[i] = dictionary;
		}
		this.52 = 1.ReadInt32();
		this.87 = 1.ReadInt32();
		this.78 = 1.ReadInt32();
		this.94 = (List<1259>)1.4<1259>(false);
		this.25 = 1.ReadInt32();
		this.29 = 1.ReadInt32();
		this.31 = 1.ReadInt32();
		this.74 = (2236)1.ReadByte();
		this.73 = (2236)1.ReadByte();
		this.75 = (2236)1.ReadByte();
		this.76 = (2236)1.ReadByte();
		this.72 = (int)1.ReadInt16();
		this.83 = 1.ReadSingle();
		this.4((2147)1.ReadByte());
		this.82 = 1.ReadString();
		this.9 = 1.ReadString();
		this.67 = (int)1.ReadInt16();
		this.66 = 1.ReadString();
		this.64 = 1.ReadBoolean();
		this.46 = 1.3();
		this.61 = 1.ReadBoolean();
		this.45(1.ReadString());
		this.96 = 1.ReadInt64();
		this.107 = 1.ReadBoolean();
		this.108 = 1.ReadBoolean();
		this.109 = 1.ReadBoolean();
		this.110 = 1.ReadBoolean();
		this.111 = 1.ReadBoolean();
		this.36 = 1.ReadInt32();
		this.92 = (int)1.ReadByte();
		this.65 = (int)(this.40 + this.42 + this.41);
		this.28 = (this.23 != null);
		this.43(true);
		this.5();
	}

	// Token: 0x0600507C RID: 20604 RVA: 0x001FD214 File Offset: 0x001FB414
	public void WriteTo(1648 1)
	{
		1.Write(this.7);
		1.Write(this.8);
		1.Write(this.10);
		1.Write(this.11);
		1.Write(this.43);
		1.Write(this.89);
		1.Write(this.18);
		1.Write(this.23);
		1.Write(this.58);
		1.Write((byte)this.85);
		1.Write(this.40);
		1.Write(this.41);
		1.Write(this.42);
		1.1(this.47);
		1.Write(this.1);
		1.Write(this.2);
		1.Write(this.3);
		1.Write(this.4);
		1.Write(this.5);
		for (int i = 0; i < 4; i++)
		{
			Dictionary<int, float> obj = this.57[i];
			Dictionary<int, float> 2;
			lock (obj)
			{
				2 = new Dictionary<int, float>(this.57[i]);
			}
			1.3<int, float>(2);
		}
		1.Write(this.52);
		1.Write(this.87);
		1.Write(this.78);
		1.2<1259>(this.84());
		1.Write(this.25);
		1.Write(this.29);
		1.Write(this.31);
		1.Write((byte)this.74);
		1.Write((byte)this.73);
		1.Write((byte)this.75);
		1.Write((byte)this.76);
		1.Write((short)this.72);
		1.Write(this.83);
		1.Write((byte)this.3());
		1.Write(this.82);
		1.Write(this.9);
		1.Write((short)this.67);
		1.Write(this.66);
		1.Write(this.64);
		1.1(this.46);
		1.Write(this.61);
		1.Write(this.37);
		1.Write(this.96);
		1.Write(this.107);
		1.Write(this.108);
		1.Write(this.109);
		1.Write(this.110);
		1.Write(this.111);
		1.Write(this.36);
		1.Write((byte)this.92);
	}

	// Token: 0x0600507D RID: 20605 RVA: 0x001FD4C8 File Offset: 0x001FB6C8
	internal void 70()
	{
		byte[] array = this.49(this.58);
		MD5 <<EMPTY_NAME>> = 1209.1;
		string text;
		lock (<<EMPTY_NAME>>)
		{
			try
			{
				array = 1209.1.ComputeHash(array);
			}
			catch (Exception)
			{
				text = "fail";
				goto IL_117;
			}
		}
		char[] array2 = new char[array.Length * 2];
		for (int i = 0; i < array.Length; i++)
		{
			array[i].ToString("x2", 1209.3).CopyTo(0, array2, i * 2, 2);
		}
		string text2 = new string(array2);
		IL_8D:
		string text3 = text2;
		if (text3 == this.23)
		{
			return;
		}
		bool flag2 = 1272.12(this);
		List<string> list = 1297.4(this.23);
		if (list != null && list.Count > 0)
		{
			foreach (string 2 in list)
			{
				1297.11(2, this.23);
				1297.9(2, text3);
			}
		}
		this.23 = text3;
		if (flag2)
		{
			1272.16(this);
		}
		return;
		IL_117:
		text2 = text;
		goto IL_8D;
	}

	// Token: 0x0600507E RID: 20606 RVA: 0x001FD61C File Offset: 0x001FB81C
	internal bool 71()
	{
		return this.85 > (1281)0 && this.85 < (1281)3;
	}

	// Token: 0x0600507F RID: 20607 RVA: 0x001FD634 File Offset: 0x001FB834
	internal 2236 72()
	{
		2236 result;
		switch (2486.14())
		{
		case 2147.Osu:
			result = this.74;
			break;
		case 2147.Taiko:
			result = this.75;
			break;
		case 2147.CatchTheBeat:
			result = this.73;
			break;
		case 2147.OsuMania:
			result = this.76;
			break;
		default:
			result = 2236.N;
			break;
		}
		return result;
	}

	// Token: 0x06005080 RID: 20608 RVA: 0x001FD688 File Offset: 0x001FB888
	internal void 73(2236 1)
	{
		switch (2486.14())
		{
		case 2147.Osu:
			this.74 = 1;
			return;
		case 2147.Taiko:
			this.75 = 1;
			return;
		case 2147.CatchTheBeat:
			this.73 = 1;
			return;
		case 2147.OsuMania:
			this.76 = 1;
			return;
		default:
			return;
		}
	}

	// Token: 0x06005081 RID: 20609 RVA: 0x001FD6D1 File Offset: 0x001FB8D1
	internal bool 74()
	{
		return this.101 != null || this.115;
	}

	// Token: 0x06005082 RID: 20610 RVA: 0x001FD6E4 File Offset: 0x001FB8E4
	private void 75(2147 1, 2023? 2)
	{
		List<2241> list = 2230.3(this.23, 6);
		if (list == null)
		{
			return;
		}
		2241 best = null;
		foreach (2241 3 in list)
		{
			2023 4 = 3.8;
			if (2210.25(3) && 3.18 && (4 & (2023.Relax | 2023.Autoplay | 2023.Relax2 | 2023.Random | 2023.Cinema | 2023.Target | 2023.KeyCoop | 2023.ScoreV2)) <= 2023.None && !3.45 && 3.52 == null && 3.44 == null && (3.43 == null || 3.43.IsEmpty) && (2 == null || (4 & (2023.NoFail | 2023.Easy | 2023.Hidden | 2023.HardRock | 2023.DoubleTime | 2023.HalfTime | 2023.Flashlight | 2023.SpunOut | 2023.Key4 | 2023.Key5 | 2023.Key6 | 2023.Key7 | 2023.Key8 | 2023.FadeIn | 2023.Key9 | 2023.KeyCoop | 2023.Key1 | 2023.Key3 | 2023.Key2)) == (2.Value & (2023.NoFail | 2023.Easy | 2023.Hidden | 2023.HardRock | 2023.DoubleTime | 2023.HalfTime | 2023.Flashlight | 2023.SpunOut | 2023.Key4 | 2023.Key5 | 2023.Key6 | 2023.Key7 | 2023.Key8 | 2023.FadeIn | 2023.Key9 | 2023.KeyCoop | 2023.Key1 | 2023.Key3 | 2023.Key2))) && (best == null || 3.GetScore() > best.GetScore()))
			{
				best = 3;
			}
		}
		if (best == null)
		{
			return;
		}
		best = (2241)best.Clone();
		best.17 = 0;
		int count = this.70.Count;
		2241 5 = this.70.Find((2241 1) => 1.23 == best.23);
		if (5 != null)
		{
			if (5.GetScore() >= best.GetScore())
			{
				this.68 = 5;
				return;
			}
			this.70.Remove(5);
		}
		int num = this.70.FindIndex((2241 1) => 1.GetScore() < best.GetScore());
		bool flag = count < 100;
		if (num >= 0 || flag)
		{
			this.70.Insert((num >= 0) ? num : this.70.Count, best);
			if (this.70.Count > Math.Max(count, 1) && !flag)
			{
				this.70.RemoveAt(this.70.Count - 1);
			}
			for (int i = 0; i < this.70.Count; i++)
			{
				this.70[i].17 = i + 1;
			}
		}
		this.68 = best;
	}

	// Token: 0x06005083 RID: 20611 RVA: 0x001FD934 File Offset: 0x001FBB34
	private void 76()
	{
		if (this.70.Count == 0)
		{
			return;
		}
		2241 top = this.70[0];
		Dictionary<long, double> <<EMPTY_NAME>> = 1631.2;
		double reported;
		lock (<<EMPTY_NAME>>)
		{
			if (!1631.2.TryGetValue(top.16, out reported))
			{
				return;
			}
		}
		Action log = null;
		log = delegate()
		{
			double? num = 2237.Get(top, this, log);
			if (num != null)
			{
				1338.5(string.Format(1662.18, "pp check: beatmap {0}, {1} {2}x mods {3}: local {4:0.00}, online {5:0.00}", new object[]
				{
					this.25,
					top.23,
					top.13,
					(int)top.8,
					num.Value,
					reported
				}), 1341.Runtime, (1114)2);
			}
		};
		log();
	}

	// Token: 0x06005084 RID: 20612 RVA: 0x001FD9E0 File Offset: 0x001FBBE0
	private void 77(bool 1, 1289 2, 1291 3)
	{
		1262.<>c__DisplayClass196_0 CS$<>8__locals1 = new 1262.<>c__DisplayClass196_0();
		CS$<>8__locals1.<>4__this = this;
		if (3 != null)
		{
			this.80(3);
		}
		if (this.115 && !1)
		{
			return;
		}
		this.70.Clear();
		this.71 = 2;
		1262.102 = this;
		CS$<>8__locals1.playMode = this.38();
		1262.103 = CS$<>8__locals1.playMode;
		CS$<>8__locals1.selectedMods = ((2 == 1289.SelectedMod) ? new 2023?(2019.1) : null);
		1262.<>c__DisplayClass196_0 CS$<>8__locals2 = CS$<>8__locals1;
		int generation = this.116 + 1;
		this.116 = generation;
		CS$<>8__locals2.generation = generation;
		this.115 = true;
		1662.89.2(delegate
		{
			if (CS$<>8__locals1.generation != CS$<>8__locals1.<>4__this.116)
			{
				return;
			}
			if (1262.102 != CS$<>8__locals1.<>4__this || 1262.103 != CS$<>8__locals1.playMode)
			{
				CS$<>8__locals1.<>4__this.115 = false;
				return;
			}
			1631.8(CS$<>8__locals1.<>4__this, CS$<>8__locals1.playMode, CS$<>8__locals1.selectedMods, delegate(List<string> 1, int 2, string 3)
			{
				if (CS$<>8__locals1.generation != CS$<>8__locals1.<>4__this.116)
				{
					return;
				}
				CS$<>8__locals1.<>4__this.115 = false;
				CS$<>8__locals1.<>4__this.70.Clear();
				CS$<>8__locals1.<>4__this.68 = null;
				if (1 == null)
				{
					1763.4(3 ?? "Scores could not be retrieved.");
				}
				else
				{
					CS$<>8__locals1.<>4__this.30 = 2;
					foreach (string 7 in 1)
					{
						try
						{
							2241 score = 2246.1(CS$<>8__locals1.playMode, 7, CS$<>8__locals1.<>4__this);
							if (CS$<>8__locals1.<>4__this.70.Find((2241 1) => 1.23 == score.23) == null)
							{
								CS$<>8__locals1.<>4__this.70.Add(score);
							}
						}
						catch (Exception)
						{
						}
					}
					CS$<>8__locals1.<>4__this.76();
					CS$<>8__locals1.<>4__this.75(CS$<>8__locals1.playMode, CS$<>8__locals1.selectedMods);
				}
				CS$<>8__locals1.<>4__this.83();
			});
		}, 1 ? 0 : 400, false);
	}

	// Token: 0x06005085 RID: 20613 RVA: 0x001FDAA0 File Offset: 0x001FBCA0
	internal void 78(bool 1, bool 2, 1289 3, 1291 4)
	{
		1262.1269 5 = new 1262.1269();
		5.2 = this;
		if (1662.21())
		{
			if (4 != null)
			{
				this.80(4);
			}
			if (this.101 == null || 2)
			{
				this.70.Clear();
				this.71 = 3;
				1262.102 = this;
				5.3 = this.38();
				1262.103 = 5.3;
				string text = string.Empty;
				if (this.55() != null)
				{
					text = (BitConverter.ToString(this.55().5()) + BitConverter.ToString(this.55().1())).Replace("-", string.Empty);
				}
				int num = 400;
				if (3 != 1289.Friends)
				{
					if (3 == 1289.Country)
					{
						num = 1000;
					}
				}
				else
				{
					num = 1000;
				}
				string[] array = new string[23];
				array[0] = 1296.6;
				array[1] = "/web/osu-osz2-getscores.php?s=";
				array[2] = (1 ? "0" : "1");
				array[3] = "&vv=4&v=";
				int num2 = (int)3;
				array[4] = num2.ToString();
				array[5] = "&c=";
				array[6] = this.23;
				array[7] = "&f=";
				array[8] = 2672.9(Path.GetFileName(this.58));
				array[9] = "&m=";
				num2 = (int)5.3;
				array[10] = num2.ToString();
				array[11] = "&i=";
				array[12] = this.29.ToString();
				array[13] = "&mods=";
				num2 = (int)2019.1;
				array[14] = num2.ToString();
				array[15] = "&h=";
				array[16] = text;
				array[17] = "&a=";
				array[18] = (1662.117 ? "1" : "0");
				array[19] = "&us=";
				array[20] = 1304.189;
				array[21] = "&ha=";
				array[22] = 1304.186.1(1643.Hashed);
				string 6 = string.Concat(array);
				5.1 = new 1621(6, Array.Empty<object>());
				5.1.9(new 1621.1622(this.79));
				1621 7 = this.101;
				if (7 != null)
				{
					7.18();
				}
				this.101 = 5.1;
				1662.89.2(new 1189(5.1), (!2) ? num : 0, false);
			}
			return;
		}
		if (1631.2(this, 3))
		{
			this.77(2, 3, 4);
			return;
		}
		if (4 != null)
		{
			1662.89.Schedule(delegate()
			{
				4(this);
			}, false);
		}
	}

	// Token: 0x06005086 RID: 20614 RVA: 0x001FDD48 File Offset: 0x001FBF48
	private void 79(1621 1, Exception 2)
	{
		this.101 = null;
		if (2 != null)
		{
			return;
		}
		this.60 = false;
		try
		{
			string[] array = 1.12().Split(new char[]
			{
				'\n'
			});
			this.70.Clear();
			if (array.Length != 0)
			{
				this.97 = false;
				string[] array2 = array[0].Split(new char[]
				{
					'|'
				});
				bool.TryParse(array2[1], out this.27);
				string a = array2[0];
				if (!(a == "-1"))
				{
					if (!(a == "0"))
					{
						if (!(a == "1"))
						{
							if (!(a == "3"))
							{
								if (!(a == "4"))
								{
									if (!(a == "5"))
									{
										this.85 = (1281)4;
									}
									else
									{
										this.85 = (1281)7;
									}
								}
								else
								{
									this.85 = (1281)6;
								}
							}
							else
							{
								this.85 = (1281)5;
							}
						}
						else
						{
							this.85 = (1281)0;
							this.97 = true;
						}
					}
					else
					{
						this.85 = (1281)2;
					}
				}
				else
				{
					this.85 = (1281)1;
					this.60 = true;
				}
				if (array2.Length > 2)
				{
					int.TryParse(array2[2], out this.25);
					int.TryParse(array2[3], out this.29);
					int.TryParse(array2[4], out this.30);
					if (array2.Length > 5)
					{
						int.TryParse(array2[5], out this.35);
					}
					if (array2.Length > 6)
					{
						this.34 = array2[6];
						if (!string.IsNullOrEmpty(this.34))
						{
							this.5();
						}
					}
					if (array2.Length > 7)
					{
						bool.TryParse(array2[7], out this.33);
					}
				}
			}
			if (array.Length > 1 && array[1].Length > 0)
			{
				int num = int.Parse(array[1]);
				if (num != this.67 && this.72 != 0)
				{
					1763.2(string.Concat(new string[]
					{
						"New online offset available.  Adjusting overall local offset from ",
						this.72.ToString(),
						" to ",
						num.ToString(),
						"."
					}), 2000, (1389)0);
					this.72 = 0;
				}
				this.67 = num;
				this.66 = array[2].Replace('|', '\n');
				this.69 = float.Parse(array[3], 1662.18);
			}
			if (array.Length > 4)
			{
				if (array[4].Length > 0)
				{
					this.68 = 2246.1(this.38(), array[4], this);
					if (this.46 == DateTime.MinValue)
					{
						this.46 = this.68.7;
					}
				}
				else
				{
					this.68 = null;
				}
				int i = 5;
				while (i < array.Length)
				{
					1262.1268 3 = new 1262.1268();
					if (array[i].Length != 0)
					{
						3.1 = 2246.1(this.38(), array[i], this);
						2241 4 = this.70.Find(new Predicate<2241>(3.1));
						if (4 == null)
						{
							goto IL_2E4;
						}
						if (4.17 <= 0)
						{
							this.70.Remove(4);
							goto IL_2E4;
						}
						IL_2F6:
						i++;
						continue;
						IL_2E4:
						this.70.Add(3.1);
						goto IL_2F6;
					}
					break;
				}
				this.70.Sort(new Comparison<2241>(1262.1263.instance.2));
			}
		}
		catch
		{
			1763.4("Scores could not be retrieved.");
		}
		1662.89.Schedule(new 1189(this.83), false);
	}

	// Token: 0x06005087 RID: 20615 RVA: 0x001FE0B8 File Offset: 0x001FC2B8
	internal void 80(1291 1)
	{
		1291 2 = this.104;
		1291 3;
		do
		{
			3 = 2;
			1291 value = (1291)Delegate.Combine(3, 1);
			2 = Interlocked.CompareExchange<1291>(ref this.104, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x06005088 RID: 20616 RVA: 0x001FE0ED File Offset: 0x001FC2ED
	internal void 81()
	{
		1621 <<EMPTY_NAME>> = this.101;
		if (<<EMPTY_NAME>> != null)
		{
			<<EMPTY_NAME>>.18();
		}
		this.101 = null;
		this.116++;
		this.115 = false;
		this.104 = null;
	}

	// Token: 0x06005089 RID: 20617 RVA: 0x001FE123 File Offset: 0x001FC323
	internal void 82()
	{
		this.73 = 2236.N;
		this.75 = 2236.N;
		this.74 = 2236.N;
		this.76 = 2236.N;
	}

	// Token: 0x0600508A RID: 20618 RVA: 0x001FE145 File Offset: 0x001FC345
	private void 83()
	{
		1291 <<EMPTY_NAME>> = this.104;
		if (<<EMPTY_NAME>> != null)
		{
			<<EMPTY_NAME>>(this);
		}
		this.104 = null;
	}

	// Token: 0x0600508B RID: 20619 RVA: 0x001FE160 File Offset: 0x001FC360
	internal List<1259> 84()
	{
		if (this.94 == null)
		{
			return null;
		}
		return this.94.FindAll(new Predicate<1259>(1262.1263.instance.1));
	}

	// Token: 0x0600508C RID: 20620 RVA: 0x001FE188 File Offset: 0x001FC388
	internal double 85()
	{
		List<1259> list = this.94;
		if (list == null || list.Count == 0)
		{
			return 0.0;
		}
		double num = 5000.0;
		foreach (1259 <<EMPTY_NAME>> in list)
		{
			if (<<EMPTY_NAME>>.1() && <<EMPTY_NAME>>.1 < num)
			{
				num = <<EMPTY_NAME>>.1;
			}
		}
		if (num == 0.0)
		{
			return 0.0;
		}
		return 60000.0 / num;
	}

	// Token: 0x0600508D RID: 20621 RVA: 0x001FE230 File Offset: 0x001FC430
	internal 209 86()
	{
		List<1259> list = this.94;
		if (list == null || list.Count == 0)
		{
			return 209.Zero;
		}
		double num = double.MaxValue;
		double num2 = double.MinValue;
		double num3 = (double)this.87;
		double num4 = 0.0;
		Dictionary<double, int> dictionary = new Dictionary<double, int>();
		for (int i = list.Count - 1; i >= 0; i--)
		{
			1259 <<EMPTY_NAME>> = list[i];
			if (<<EMPTY_NAME>>.1())
			{
				num4 = <<EMPTY_NAME>>.1;
			}
			if (num4 != 0.0 && <<EMPTY_NAME>>.3 <= num3 && (<<EMPTY_NAME>>.1() || i <= 0))
			{
				if (num4 < num)
				{
					num = num4;
				}
				if (num4 > num2)
				{
					num2 = num4;
				}
				if (dictionary.ContainsKey(num4))
				{
					Dictionary<double, int> dictionary2 = dictionary;
					double key = num4;
					dictionary2[key] += (int)(num3 - ((i == 0) ? 0.0 : <<EMPTY_NAME>>.3));
				}
				else
				{
					dictionary[num4] = (int)(num3 - ((i == 0) ? 0.0 : <<EMPTY_NAME>>.3));
				}
				num3 = <<EMPTY_NAME>>.3;
			}
		}
		int num5 = 0;
		double num6 = 0.0;
		foreach (KeyValuePair<double, int> keyValuePair in dictionary)
		{
			if (keyValuePair.Value > num5)
			{
				num5 = keyValuePair.Value;
				num6 = keyValuePair.Key;
			}
		}
		return new 209((float)Math.Round(60000.0 / num2), (float)Math.Round(60000.0 / num), (float)Math.Round(60000.0 / num6));
	}

	// Token: 0x0600508E RID: 20622 RVA: 0x001FE404 File Offset: 0x001FC604
	internal static string 87(209 1)
	{
		if (1.X == 1.Y)
		{
			return 1.X.ToString("0");
		}
		return string.Format("{0:0}-{1:0} ({2:0})", 1.X, 1.Y, 1.Z);
	}

	// Token: 0x0600508F RID: 20623 RVA: 0x001FE45C File Offset: 0x001FC65C
	internal double 88(double 1)
	{
		if (this.94 == null || this.94.Count == 0)
		{
			return 0.0;
		}
		int num = 0;
		for (int i = 0; i < this.94.Count; i++)
		{
			if (this.94[i].1() && this.94[i].3 <= 1)
			{
				num = i;
			}
		}
		double 2 = this.94[num].1;
		double num2 = this.94[num].3;
		if (num == 0 && 2 > 0.0)
		{
			while (num2 > 0.0)
			{
				num2 -= 2;
			}
		}
		return num2;
	}

	// Token: 0x06005090 RID: 20624 RVA: 0x001FE510 File Offset: 0x001FC710
	internal double 89(double 1)
	{
		if (this.94 == null || this.94.Count == 0)
		{
			return 0.0;
		}
		int index = 0;
		for (int i = 0; i < this.94.Count; i++)
		{
			if (this.94[i].1() && this.94[i].3 <= 1)
			{
				index = i;
			}
		}
		return this.94[index].3;
	}

	// Token: 0x06005091 RID: 20625 RVA: 0x001FE590 File Offset: 0x001FC790
	internal double 90(double 1, bool 2)
	{
		if (this.94 == null || this.94.Count == 0)
		{
			return 0.0;
		}
		int num = 0;
		int num2 = 0;
		for (int i = 0; i < this.94.Count; i++)
		{
			if ((double)((int)this.94[i].3) <= 1)
			{
				if (this.94[i].1())
				{
					num = i;
				}
				else
				{
					num2 = i;
				}
			}
		}
		double num3 = 1.0;
		if (2 && num2 > num && this.94[num2].1 < 0.0)
		{
			num3 = ((this.3() != 2147.Taiko && this.3() != 2147.OsuMania) ? ((double)this.94[num2].5()) : ((double)this.94[num2].6()));
		}
		return this.94[num].1 * num3;
	}

	// Token: 0x06005092 RID: 20626 RVA: 0x001FE680 File Offset: 0x001FC880
	internal float 91(double 1)
	{
		1259 2 = this.92(1);
		if (2 == null)
		{
			return 1f;
		}
		if (this.3() == 2147.Taiko || this.3() == 2147.OsuMania)
		{
			return 2.6();
		}
		return 2.5();
	}

	// Token: 0x06005093 RID: 20627 RVA: 0x001FE6C0 File Offset: 0x001FC8C0
	internal 1259 92(double 1)
	{
		if (this.94 == null || this.94.Count == 0)
		{
			return null;
		}
		1259 2 = null;
		for (int i = 0; i < this.94.Count; i++)
		{
			1259 3 = this.94[i];
			if (3.3 <= 1)
			{
				2 = 3;
			}
		}
		if (2 == null)
		{
			2 = this.94[0];
		}
		return 2;
	}

	// Token: 0x06005094 RID: 20628 RVA: 0x001FE728 File Offset: 0x001FC928
	internal 1259 93(double 1)
	{
		if (this.94 == null || this.94.Count == 0)
		{
			return null;
		}
		1259 2 = null;
		foreach (1259 3 in this.94)
		{
			if (3.3 > 4)
			{
				break;
			}
			if (3.1())
			{
				2 = 3;
			}
		}
		1259 result;
		if ((result = 2) == null)
		{
			result = this.94.FirstOrDefault((1259 1) => 1.1());
		}
		return result;
	}

	// Token: 0x06005095 RID: 20629 RVA: 0x001FE7D4 File Offset: 0x001FC9D4
	internal 1259 94(double 1)
	{
		return 1262.95(1, this.94);
	}

	// Token: 0x06005096 RID: 20630 RVA: 0x001FE7E4 File Offset: 0x001FC9E4
	internal static 1259 95(double 1, List<1259> 2)
	{
		if (2 == null || 2.Count == 0)
		{
			return null;
		}
		1259 item = new 1259(1, 0.0);
		int num = 2.BinarySearch(item);
		if (num < 0)
		{
			num = ~num;
		}
		if (num <= 1)
		{
			return 2[0];
		}
		return 2[num - 1];
	}

	// Token: 0x04003CB0 RID: 15536
	private static readonly int[] 12 = new int[]
	{
		20260630,
		20260630,
		20260630,
		20231214
	};

	// Token: 0x04003CB1 RID: 15537
	private static readonly TimeSpan 13 = TimeSpan.FromMinutes(1.0);

	// Token: 0x04003CB2 RID: 15538
	private static readonly List<int> 14 = new List<int>();

	// Token: 0x04003CB3 RID: 15539
	private 1514 15;

	// Token: 0x04003CB4 RID: 15540
	internal bool 16;

	// Token: 0x04003CB5 RID: 15541
	internal string 17;

	// Token: 0x04003CB6 RID: 15542
	internal string 18;

	// Token: 0x04003CB7 RID: 15543
	internal int 19;

	// Token: 0x04003CB8 RID: 15544
	private bool 20 = true;

	// Token: 0x04003CB9 RID: 15545
	internal 198 21;

	// Token: 0x04003CBA RID: 15546
	internal string 22;

	// Token: 0x04003CBB RID: 15547
	internal string 23;

	// Token: 0x04003CBC RID: 15548
	internal string 24 = string.Empty;

	// Token: 0x04003CBD RID: 15549
	internal int 25;

	// Token: 0x04003CBE RID: 15550
	internal bool 26;

	// Token: 0x04003CBF RID: 15551
	internal bool 27;

	// Token: 0x04003CC0 RID: 15552
	internal bool 28;

	// Token: 0x04003CC1 RID: 15553
	internal int 29 = -1;

	// Token: 0x04003CC2 RID: 15554
	internal int 30;

	// Token: 0x04003CC3 RID: 15555
	internal int 31;

	// Token: 0x04003CC4 RID: 15556
	internal int 32;

	// Token: 0x04003CC5 RID: 15557
	internal bool 33;

	// Token: 0x04003CC6 RID: 15558
	internal string 34;

	// Token: 0x04003CC7 RID: 15559
	internal int 35;

	// Token: 0x04003CC8 RID: 15560
	internal int 36;

	// Token: 0x04003CC9 RID: 15561
	internal string 37;

	// Token: 0x04003CCA RID: 15562
	internal 1284 38;

	// Token: 0x04003CCB RID: 15563
	internal int 39;

	// Token: 0x04003CCC RID: 15564
	internal ushort 40;

	// Token: 0x04003CCD RID: 15565
	internal ushort 41;

	// Token: 0x04003CCE RID: 15566
	internal ushort 42;

	// Token: 0x04003CCF RID: 15567
	internal string 43 = string.Empty;

	// Token: 0x04003CD0 RID: 15568
	internal bool 44;

	// Token: 0x04003CD1 RID: 15569
	internal bool 45;

	// Token: 0x04003CD2 RID: 15570
	internal DateTime 46;

	// Token: 0x04003CD3 RID: 15571
	internal DateTime 47;

	// Token: 0x04003CD4 RID: 15572
	internal 1254 48;

	// Token: 0x04003CD5 RID: 15573
	internal string 49;

	// Token: 0x04003CD6 RID: 15574
	internal string 50;

	// Token: 0x04003CD7 RID: 15575
	internal string 51;

	// Token: 0x04003CD8 RID: 15576
	internal int 52;

	// Token: 0x04003CD9 RID: 15577
	internal int 53;

	// Token: 0x04003CDA RID: 15578
	private double 54;

	// Token: 0x04003CDB RID: 15579
	private double 55;

	// Token: 0x04003CDC RID: 15580
	private double 56;

	// Token: 0x04003CDD RID: 15581
	private Dictionary<int, float>[] 57 = new Dictionary<int, float>[Enum.GetNames(typeof(2147)).Length];

	// Token: 0x04003CDE RID: 15582
	internal string 58 = string.Empty;

	// Token: 0x04003CDF RID: 15583
	internal bool 59;

	// Token: 0x04003CE0 RID: 15584
	internal bool 60;

	// Token: 0x04003CE1 RID: 15585
	internal bool 61;

	// Token: 0x04003CE2 RID: 15586
	internal bool 62;

	// Token: 0x04003CE3 RID: 15587
	internal bool 63;

	// Token: 0x04003CE4 RID: 15588
	internal bool 64;

	// Token: 0x04003CE5 RID: 15589
	internal int 65;

	// Token: 0x04003CE6 RID: 15590
	internal string 66 = string.Empty;

	// Token: 0x04003CE7 RID: 15591
	internal int 67;

	// Token: 0x04003CE8 RID: 15592
	internal 2241 68;

	// Token: 0x04003CE9 RID: 15593
	internal float 69;

	// Token: 0x04003CEA RID: 15594
	internal List<2241> 70 = new List<2241>();

	// Token: 0x04003CEB RID: 15595
	internal 1289 71;

	// Token: 0x04003CEC RID: 15596
	internal int 72;

	// Token: 0x04003CED RID: 15597
	internal 2236 73 = 2236.N;

	// Token: 0x04003CEE RID: 15598
	internal 2236 74 = 2236.N;

	// Token: 0x04003CEF RID: 15599
	internal 2236 75 = 2236.N;

	// Token: 0x04003CF0 RID: 15600
	internal 2236 76 = 2236.N;

	// Token: 0x04003CF1 RID: 15601
	private 2147 77;

	// Token: 0x04003CF2 RID: 15602
	internal int 78;

	// Token: 0x04003CF3 RID: 15603
	internal int 79 = 100;

	// Token: 0x04003CF4 RID: 15604
	internal string 80 = string.Empty;

	// Token: 0x04003CF5 RID: 15605
	internal string 81;

	// Token: 0x04003CF6 RID: 15606
	internal string 82 = string.Empty;

	// Token: 0x04003CF7 RID: 15607
	internal float 83;

	// Token: 0x04003CF8 RID: 15608
	internal bool 84 = true;

	// Token: 0x04003CF9 RID: 15609
	internal 1281 85;

	// Token: 0x04003CFA RID: 15610
	internal float 86 = 1f;

	// Token: 0x04003CFB RID: 15611
	internal int 87;

	// Token: 0x04003CFC RID: 15612
	internal bool 88;

	// Token: 0x04003CFD RID: 15613
	internal string 89 = string.Empty;

	// Token: 0x04003CFE RID: 15614
	internal int 90;

	// Token: 0x04003CFF RID: 15615
	internal bool 91;

	// Token: 0x04003D00 RID: 15616
	internal int 92;

	// Token: 0x04003D01 RID: 15617
	internal bool 93;

	// Token: 0x04003D02 RID: 15618
	internal List<1259> 94 = new List<1259>();

	// Token: 0x04003D03 RID: 15619
	private string 95;

	// Token: 0x04003D04 RID: 15620
	internal long 96;

	// Token: 0x04003D05 RID: 15621
	internal bool 97;

	// Token: 0x04003D06 RID: 15622
	internal bool 98;

	// Token: 0x04003D07 RID: 15623
	private bool 99;

	// Token: 0x04003D08 RID: 15624
	private bool 100;

	// Token: 0x04003D09 RID: 15625
	private 1621 101;

	// Token: 0x04003D0A RID: 15626
	private static 1262 102;

	// Token: 0x04003D0B RID: 15627
	private static 2147 103;

	// Token: 0x04003D0C RID: 15628
	private 1291 104;

	// Token: 0x04003D0D RID: 15629
	internal 1290 105;

	// Token: 0x04003D0E RID: 15630
	public bool 106;

	// Token: 0x04003D0F RID: 15631
	public bool 107;

	// Token: 0x04003D10 RID: 15632
	public bool 108;

	// Token: 0x04003D11 RID: 15633
	public bool 109;

	// Token: 0x04003D12 RID: 15634
	public bool 110;

	// Token: 0x04003D13 RID: 15635
	public bool 111;

	// Token: 0x04003D14 RID: 15636
	public int? 112;

	// Token: 0x04003D15 RID: 15637
	public object 113 = true;

	// Token: 0x04003D16 RID: 15638
	private double 114;

	// Token: 0x04003D17 RID: 15639
	private bool 115;

	// Token: 0x04003D18 RID: 15640
	private int 116;

	// Token: 0x04003D19 RID: 15641
	private const 2023 117 = 2023.NoFail | 2023.Easy | 2023.Hidden | 2023.HardRock | 2023.DoubleTime | 2023.HalfTime | 2023.Flashlight | 2023.SpunOut | 2023.Key4 | 2023.Key5 | 2023.Key6 | 2023.Key7 | 2023.Key8 | 2023.FadeIn | 2023.Key9 | 2023.KeyCoop | 2023.Key1 | 2023.Key3 | 2023.Key2;

	// Token: 0x04003D1A RID: 15642
	private const 2023 118 = 2023.Relax | 2023.Autoplay | 2023.Relax2 | 2023.Random | 2023.Cinema | 2023.Target | 2023.KeyCoop | 2023.ScoreV2;

	// Token: 0x02000B5F RID: 2911
	[Serializable]
	public sealed class 1263
	{
		// Token: 0x06005098 RID: 20632 RVA: 0x00126D5C File Offset: 0x00124F5C
		internal bool 1(1259 1)
		{
			return 1.1();
		}

		// Token: 0x06005099 RID: 20633 RVA: 0x001FE868 File Offset: 0x001FCA68
		internal int 2(2241 1, 2241 2)
		{
			int num = 2.GetScore().CompareTo(1.GetScore());
			if (num != 0)
			{
				return num;
			}
			num = 1.7.CompareTo(2.7);
			if (num != 0)
			{
				return num;
			}
			return 1.16.CompareTo(2.16);
		}

		// Token: 0x04003D1B RID: 15643
		public static readonly 1262.1263 instance = new 1262.1263();

		// Token: 0x04003D1C RID: 15644
		public static Predicate<1259> cachedIsTimingChange;

		// Token: 0x04003D1D RID: 15645
		public static Func<1259, bool> cachedIsTimingChangeFunc;

		// Token: 0x04003D1E RID: 15646
		public static Comparison<2241> cachedCompareScores;
	}

	// Token: 0x02000B60 RID: 2912
	public sealed class 1264
	{
		// Token: 0x0600509C RID: 20636 RVA: 0x001FE8C4 File Offset: 0x001FCAC4
		internal void 1()
		{
			1262 obj = this.1;
			lock (obj)
			{
				this.1.99 = false;
			}
			this.2();
			if (this.3 == null || this.3.Method13423() || this.3.Method13424() || this.4.GetIsShuttingDown())
			{
				return;
			}
			this.3.Method134352();
			if (this.1.25 != 0)
			{
				List<int> <<EMPTY_NAME>> = 1262.14;
				lock (<<EMPTY_NAME>>)
				{
					1262.14.Add(this.1.25);
				}
			}
			1338.5(string.Format("({0}) difficulty calculation timed out.", this.1.25), 1341.Runtime, (1114)1);
		}

		// Token: 0x04003D1F RID: 15647
		public 1262 1;

		// Token: 0x04003D20 RID: 15648
		public 1189 2;

		// Token: 0x04003D21 RID: 15649
		public 373 3;

		// Token: 0x04003D22 RID: 15650
		public 915 4;

		// Token: 0x04003D23 RID: 15651
		public 2147 5;
	}

	// Token: 0x02000B61 RID: 2913
	public sealed class 1265
	{
		// Token: 0x0600509E RID: 20638 RVA: 0x001FE9BC File Offset: 0x001FCBBC
		internal void 1()
		{
			this.2.1.20(this.2.5, this.1);
			this.2.2();
		}

		// Token: 0x04003D24 RID: 15652
		public Dictionary<int, float> 1;

		// Token: 0x04003D25 RID: 15653
		public 1262.1264 2;
	}

	// Token: 0x02000B62 RID: 2914
	public enum 1266
	{

	}

	// Token: 0x02000B63 RID: 2915
	public sealed class 1267
	{
		// Token: 0x060050A0 RID: 20640 RVA: 0x001FE9EF File Offset: 0x001FCBEF
		internal bool 1(1262 1)
		{
			return 1.37 == this.1.37;
		}

		// Token: 0x04003D27 RID: 15655
		public 1262 1;

		// Token: 0x04003D28 RID: 15656
		public bool 2;

		// Token: 0x04003D29 RID: 15657
		public string 3;

		// Token: 0x04003D2A RID: 15658
		public 1514 4;
	}

	// Token: 0x02000B64 RID: 2916
	public sealed class 1269
	{
		// Token: 0x060050A2 RID: 20642 RVA: 0x001FEA08 File Offset: 0x001FCC08
		internal void 1()
		{
			if (!this.1.3())
			{
				if (1262.102 != this.2 || 1262.103 != this.3)
				{
					this.2.101 = null;
					return;
				}
				this.1.Start();
			}
		}

		// Token: 0x04003D2B RID: 15659
		public 1621 1;

		// Token: 0x04003D2C RID: 15660
		public 1262 2;

		// Token: 0x04003D2D RID: 15661
		public 2147 3;
	}

	// Token: 0x02000B65 RID: 2917
	public sealed class 1268
	{
		// Token: 0x060050A4 RID: 20644 RVA: 0x001FEA54 File Offset: 0x001FCC54
		internal bool 1(2241 1)
		{
			return 1.23 == this.1.23;
		}

		// Token: 0x04003D2E RID: 15662
		public 2241 1;
	}
}
