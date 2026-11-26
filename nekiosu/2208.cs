using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

// Token: 0x0200066C RID: 1644
[276]
internal static class 2208
{
	// Token: 0x17000277 RID: 631
	// (get) Token: 0x060031C6 RID: 12742 RVA: 0x0012BE58 File Offset: 0x0012A058
	internal static bool Available
	{
		get
		{
			return !261.FullyOffline && 1304.42.1() && 267.IsConfigured;
		}
	}

	// Token: 0x060031C7 RID: 12743 RVA: 0x0012BE74 File Offset: 0x0012A074
	private static string 1(string 1, double 2, 2147 3)
	{
		string[] array = new string[5];
		array[0] = 1;
		array[1] = ":";
		int num = 2;
		int num2 = (int)3;
		array[num] = num2.ToString();
		array[3] = ":";
		array[4] = ((long)Math.Round(2 * 100.0)).ToString(CultureInfo.InvariantCulture);
		return string.Concat(array);
	}

	// Token: 0x060031C8 RID: 12744 RVA: 0x0012BECD File Offset: 0x0012A0CD
	private static bool 2(string 1, double 2)
	{
		return 2208.Available && 2204.1(1) && !double.IsNaN(2) && !double.IsInfinity(2) && 2 >= 0.01;
	}

	// Token: 0x060031C9 RID: 12745 RVA: 0x0012BF00 File Offset: 0x0012A100
	internal static int? Get(string 1, double 2, Action 3, 2147 4 = 2147.Osu)
	{
		int? num;
		if (!2208.2(1, 2))
		{
			num = null;
			return num;
		}
		1 = 1.ToUpperInvariant();
		string key = 2208.1(1, 2, 4);
		object obj = 2208.5;
		lock (obj)
		{
			KeyValuePair<int, DateTime> keyValuePair;
			if (2208.7.TryGetValue(key, out keyValuePair) && DateTime.UtcNow - keyValuePair.Value < 2208.3)
			{
				int? num2;
				if (keyValuePair.Key <= 0)
				{
					num = null;
					num2 = num;
				}
				else
				{
					num2 = new int?(keyValuePair.Key);
				}
				num = num2;
			}
			else
			{
				DateTime t;
				if (!2208.9.TryGetValue(key, out t) || !(DateTime.UtcNow < t))
				{
					2208.4(1, 2, 4, key, 3);
				}
				num = null;
			}
		}
		return num;
	}

	// Token: 0x060031CA RID: 12746 RVA: 0x0012BFE0 File Offset: 0x0012A1E0
	internal static bool 3(string 1, double 2, 2147 3 = 2147.Osu)
	{
		if (!2208.2(1, 2))
		{
			return true;
		}
		object obj = 2208.5;
		bool result;
		lock (obj)
		{
			result = !2208.8.ContainsKey(2208.1(1.ToUpperInvariant(), 2, 3));
		}
		return result;
	}

	// Token: 0x060031CB RID: 12747 RVA: 0x0012C040 File Offset: 0x0012A240
	private static void 4(string 1, double 2, 2147 3, string 4, Action 5)
	{
		List<Action> list;
		if (2208.8.TryGetValue(4, out list))
		{
			if (5 != null && !list.Contains(5))
			{
				list.Add(5);
			}
			return;
		}
		Dictionary<string, List<Action>> dictionary = 2208.8;
		string key = 4;
		List<Action> value;
		if (5 == null)
		{
			value = new List<Action>();
		}
		else
		{
			(value = new List<Action>()).Add(5);
		}
		dictionary[key] = value;
		ThreadPool.QueueUserWorkItem(delegate(object 1)
		{
			int? num = null;
			try
			{
				num = new int?(2208.5(6, Math.Round(2, 2), 2202.1(3)));
			}
			catch (Exception ex)
			{
				1338.5(string.Concat(new string[]
				{
					"Country rank: could not look up ",
					6,
					" for ",
					2.ToString("0.##", CultureInfo.InvariantCulture),
					"pp (",
					ex.Message,
					")"
				}), 1341.Runtime, (1114)1);
			}
			object obj = 2208.5;
			List<Action> waiting;
			lock (obj)
			{
				2208.8.TryGetValue(4, out waiting);
				2208.8.Remove(4);
				if (num != null)
				{
					2208.7[4] = new KeyValuePair<int, DateTime>(num.Value, DateTime.UtcNow);
					2208.9.Remove(4);
				}
				else
				{
					2208.9[4] = DateTime.UtcNow + 2208.4;
				}
			}
			if (waiting != null && waiting.Count > 0)
			{
				1662.89.Schedule(delegate()
				{
					foreach (Action action in waiting)
					{
						try
						{
							action();
						}
						catch (Exception ex2)
						{
							1338.4(ex2, "a country rank result's callback", 1341.Runtime);
						}
					}
				}, true);
			}
		});
	}

	// Token: 0x060031CC RID: 12748 RVA: 0x0012C0D4 File Offset: 0x0012A2D4
	private static int 5(string 1, double 2, string 3)
	{
		2208.2209 4 = 2208.7(1, 1, 3);
		if (4.1.Length == 0 || 2 > 4.1[0])
		{
			return 1;
		}
		int num = Math.Max(1, Math.Min(200, (4.2 + 50 - 1) / 50));
		int i = 1;
		int num2 = num;
		while (i < num2)
		{
			int num3 = (i + num2) / 2;
			if (2208.6(2208.7(1, num3, 3)) < 2)
			{
				num2 = num3;
			}
			else
			{
				i = num3 + 1;
			}
		}
		2208.2209 5 = 2208.7(1, i, 3);
		if (2208.6(5) < 2)
		{
			int num4 = 0;
			double[] array = 5.1;
			for (int j = 0; j < array.Length; j++)
			{
				if (array[j] > 2)
				{
					num4++;
				}
			}
			return (i - 1) * 50 + num4 + 1;
		}
		if (4.2 <= 10000 && num != 200)
		{
			return 4.2 + 1;
		}
		return 0;
	}

	// Token: 0x060031CD RID: 12749 RVA: 0x0012C1B7 File Offset: 0x0012A3B7
	private static double 6(2208.2209 1)
	{
		if (1.1.Length == 0)
		{
			return double.MinValue;
		}
		return 1.1[1.1.Length - 1];
	}

	// Token: 0x060031CE RID: 12750 RVA: 0x0012C1E0 File Offset: 0x0012A3E0
	private static 2208.2209 7(string 1, int 2, string 3)
	{
		string key = string.Concat(new string[]
		{
			1,
			"#",
			3,
			"#",
			2.ToString(CultureInfo.InvariantCulture)
		});
		object obj = 2208.5;
		lock (obj)
		{
			2208.2209 4;
			if (2208.6.TryGetValue(key, out 4) && DateTime.UtcNow - 4.3 < 2208.3)
			{
				return 4;
			}
		}
		string text = 267.7(1, 2, 3);
		if (text == null)
		{
			throw new InvalidOperationException("no ranking for " + 1);
		}
		217 5 = 217.Parse(text);
		List<double> list = new List<double>();
		109 6 = 5["ranking"] as 109;
		if (6 != null)
		{
			foreach (226 7 in 6)
			{
				list.Add(((double?)7["pp"]).GetValueOrDefault());
			}
		}
		2208.2209 8 = new 2208.2209
		{
			1 = list.ToArray(),
			2 = (((int?)5["total"]) ?? list.Count),
			3 = DateTime.UtcNow
		};
		obj = 2208.5;
		lock (obj)
		{
			2208.6[key] = 8;
			foreach (string key2 in new List<string>(2208.6.Keys))
			{
				if (DateTime.UtcNow - 2208.6[key2].3 >= 2208.3)
				{
					2208.6.Remove(key2);
				}
			}
		}
		return 8;
	}

	// Token: 0x040024B5 RID: 9397
	private const int 1 = 50;

	// Token: 0x040024B6 RID: 9398
	private const int 2 = 200;

	// Token: 0x040024B7 RID: 9399
	private static readonly TimeSpan 3 = TimeSpan.FromMinutes(30.0);

	// Token: 0x040024B8 RID: 9400
	private static readonly TimeSpan 4 = TimeSpan.FromMinutes(1.0);

	// Token: 0x040024B9 RID: 9401
	private static readonly object 5 = new object();

	// Token: 0x040024BA RID: 9402
	private static readonly Dictionary<string, 2208.2209> 6 = new Dictionary<string, 2208.2209>(StringComparer.Ordinal);

	// Token: 0x040024BB RID: 9403
	private static readonly Dictionary<string, KeyValuePair<int, DateTime>> 7 = new Dictionary<string, KeyValuePair<int, DateTime>>(StringComparer.Ordinal);

	// Token: 0x040024BC RID: 9404
	private static readonly Dictionary<string, List<Action>> 8 = new Dictionary<string, List<Action>>(StringComparer.Ordinal);

	// Token: 0x040024BD RID: 9405
	private static readonly Dictionary<string, DateTime> 9 = new Dictionary<string, DateTime>(StringComparer.Ordinal);

	// Token: 0x0200066D RID: 1645
	[276]
	private sealed class 2209
	{
		// Token: 0x040024BE RID: 9406
		public double[] 1;

		// Token: 0x040024BF RID: 9407
		public int 2;

		// Token: 0x040024C0 RID: 9408
		public DateTime 3;
	}
}
