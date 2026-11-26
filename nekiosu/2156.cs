using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

// Token: 0x020006E7 RID: 1767
internal sealed class 2156
{
	// Token: 0x0600347B RID: 13435 RVA: 0x00142964 File Offset: 0x00140B64
	internal 2156(1262 1)
	{
		foreach (IGrouping<double, 1259> grouping in from 1 in 3.94 ?? new List<1259>()
		group 1 by 1.3 into 1
		orderby 1.Key
		select 1)
		{
			1259 2 = grouping.LastOrDefault((1259 1) => !1.1()) ?? grouping.First<1259>();
			this.2(grouping.Key, 2.3(), 1.0);
			this.4.Add(grouping.Key);
			this.5.Add((2.1 < 0.0) ? Math.Min(10.0, Math.Max(0.1, 100.0 / -2.1)) : 1.0);
		}
		double num = 1.0;
		foreach (double num2 in 2156.5(3))
		{
			double num3 = this.4(num2);
			if (num3 != num)
			{
				num = num3;
				int num4 = this.3(num2);
				this.2(num2, num4 >= 0 && this.2[num4], num3);
			}
		}
	}

	// Token: 0x0600347C RID: 13436 RVA: 0x00142B70 File Offset: 0x00140D70
	internal double 1(double 1)
	{
		int num = this.3(1);
		if (num >= 0)
		{
			return Math.Min(10.0, Math.Max(0.01, this.3[num]));
		}
		return 1.0;
	}

	// Token: 0x0600347D RID: 13437 RVA: 0x00142BBC File Offset: 0x00140DBC
	private void 2(double 1, bool 2, double 3)
	{
		int num = this.3(1);
		bool flag = num >= 0 && this.2[num];
		double num2 = (num >= 0) ? this.3[num] : 1.0;
		if (flag == 2 && num2 == 3)
		{
			return;
		}
		if (num >= 0 && this.1[num] == 1)
		{
			this.2[num] = 2;
			this.3[num] = 3;
			return;
		}
		this.1.Insert(num + 1, 1);
		this.2.Insert(num + 1, 2);
		this.3.Insert(num + 1, 3);
	}

	// Token: 0x0600347E RID: 13438 RVA: 0x00142C64 File Offset: 0x00140E64
	private int 3(double 1)
	{
		int num = this.1.BinarySearch(1);
		if (num >= 0)
		{
			while (num + 1 < this.1.Count && this.1[num + 1] == 1)
			{
				num++;
			}
			return num;
		}
		return ~num - 1;
	}

	// Token: 0x0600347F RID: 13439 RVA: 0x00142CB0 File Offset: 0x00140EB0
	private double 4(double 1)
	{
		int num = this.4.BinarySearch(1);
		num = ((num >= 0) ? num : (~num - 1));
		if (num >= 0)
		{
			return this.5[num];
		}
		return 1.0;
	}

	// Token: 0x06003480 RID: 13440 RVA: 0x00142CF0 File Offset: 0x00140EF0
	private static List<double> 5(1262 1)
	{
		List<double> list = new List<double>();
		byte[] array;
		try
		{
			array = 3.49(3.58);
		}
		catch (Exception)
		{
			return list;
		}
		if (array == null)
		{
			return list;
		}
		bool flag = false;
		using (StringReader stringReader = new StringReader(Encoding.UTF8.GetString(array)))
		{
			string text;
			while ((text = stringReader.ReadLine()) != null)
			{
				text = text.Trim();
				if (text.StartsWith("[", StringComparison.Ordinal))
				{
					flag = (text == "[HitObjects]");
				}
				else if (flag && text.Length != 0 && !text.StartsWith("//", StringComparison.Ordinal))
				{
					string[] array2 = text.Split(new char[]
					{
						','
					});
					int num;
					double item;
					if (array2.Length > 3 && int.TryParse(array2[3], NumberStyles.Integer, CultureInfo.InvariantCulture, out num) && (num & 2) != 0 && double.TryParse(array2[2], NumberStyles.Float, CultureInfo.InvariantCulture, out item))
					{
						list.Add(item);
					}
				}
			}
		}
		return (from 1 in list.Select((double 1, int 2) => new
		{
			1,
			2
		})
		orderby 1.time, 1.order
		select 1.time).ToList<double>();
	}

	// Token: 0x040026FE RID: 9982
	private readonly List<double> 1 = new List<double>();

	// Token: 0x040026FF RID: 9983
	private readonly List<bool> 2 = new List<bool>();

	// Token: 0x04002700 RID: 9984
	private readonly List<double> 3 = new List<double>();

	// Token: 0x04002701 RID: 9985
	private readonly List<double> 4 = new List<double>();

	// Token: 0x04002702 RID: 9986
	private readonly List<double> 5 = new List<double>();
}
