using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Threading;

// Token: 0x02000681 RID: 1665
[276]
internal static class 2218
{
	// Token: 0x1700027D RID: 637
	// (get) Token: 0x0600325B RID: 12891 RVA: 0x00131887 File Offset: 0x0012FA87
	internal static bool Available
	{
		get
		{
			return !261.FullyOffline && 1304.41.1();
		}
	}

	// Token: 0x0600325C RID: 12892 RVA: 0x0013189C File Offset: 0x0012FA9C
	private static long 1(double 1, 2147 2)
	{
		return (long)Math.Round(1 * 100.0) * 4L + (long)2;
	}

	// Token: 0x0600325D RID: 12893 RVA: 0x001318B5 File Offset: 0x0012FAB5
	private static bool 2(double 1)
	{
		return 2218.Available && !double.IsNaN(1) && !double.IsInfinity(1) && 1 >= 0.01;
	}

	// Token: 0x0600325E RID: 12894 RVA: 0x001318E0 File Offset: 0x0012FAE0
	internal static int? Get(double 1, Action 2, 2147 3 = 2147.Osu)
	{
		int? result;
		if (!2218.2(1))
		{
			result = null;
			return result;
		}
		long key = 2218.1(1, 3);
		object obj = 2218.4;
		lock (obj)
		{
			2218.2219 4;
			if (2218.5.TryGetValue(key, out 4) && DateTime.UtcNow - 4.2 < 2218.1)
			{
				result = new int?(4.1);
			}
			else
			{
				DateTime t;
				if (!2218.7.TryGetValue(key, out t) || !(DateTime.UtcNow < t))
				{
					2218.4(key, 2);
				}
				result = null;
			}
		}
		return result;
	}

	// Token: 0x0600325F RID: 12895 RVA: 0x001319A0 File Offset: 0x0012FBA0
	internal static bool 3(double 1, 2147 2 = 2147.Osu)
	{
		if (!2218.2(1))
		{
			return true;
		}
		object obj = 2218.4;
		bool result;
		lock (obj)
		{
			result = !2218.6.ContainsKey(2218.1(1, 2));
		}
		return result;
	}

	// Token: 0x06003260 RID: 12896 RVA: 0x001319FC File Offset: 0x0012FBFC
	private static void 4(long 1, Action 2)
	{
		List<Action> list;
		if (2218.6.TryGetValue(3, out list))
		{
			if (2 != null && !list.Contains(2))
			{
				list.Add(2);
			}
			return;
		}
		Dictionary<long, List<Action>> dictionary = 2218.6;
		long key = 3;
		List<Action> value;
		if (2 == null)
		{
			value = new List<Action>();
		}
		else
		{
			(value = new List<Action>()).Add(2);
		}
		dictionary[key] = value;
		ThreadPool.QueueUserWorkItem(delegate(object 1)
		{
			int? num = null;
			try
			{
				Match match = 2218.3.Match(270.1((double)(3 / 4L) / 100.0, 2202.1((2147)(3 % 4L))));
				int num2;
				if (match.Success && int.TryParse(match.Groups[1].Value, NumberStyles.Integer, CultureInfo.InvariantCulture, out num2) && num2 > 0)
				{
					num = new int?(num2);
				}
			}
			catch (Exception ex)
			{
				1338.5(string.Concat(new string[]
				{
					"Rank: could not ask for the rank of ",
					((double)(3 / 4L) / 100.0).ToString("0.##", CultureInfo.InvariantCulture),
					"pp (",
					ex.Message,
					")"
				}), 1341.Runtime, (1114)1);
			}
			object obj = 2218.4;
			List<Action> waiting;
			lock (obj)
			{
				2218.6.TryGetValue(3, out waiting);
				2218.6.Remove(3);
				if (num != null)
				{
					2218.5[3] = new 2218.2219
					{
						1 = num.Value,
						2 = DateTime.UtcNow
					};
					2218.7.Remove(3);
				}
				else
				{
					2218.7[3] = DateTime.UtcNow + 2218.2;
				}
				foreach (long key2 in new List<long>(2218.5.Keys))
				{
					if (DateTime.UtcNow - 2218.5[key2].2 >= 2218.1)
					{
						2218.5.Remove(key2);
					}
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
							1338.4(ex2, "a rank result's callback", 1341.Runtime);
						}
					}
				}, true);
			}
		});
	}

	// Token: 0x0400253C RID: 9532
	private static readonly TimeSpan 1 = TimeSpan.FromSeconds(60.0);

	// Token: 0x0400253D RID: 9533
	private static readonly TimeSpan 2 = TimeSpan.FromSeconds(30.0);

	// Token: 0x0400253E RID: 9534
	private static readonly Regex 3 = new Regex("\"rank\"\\s*:\\s*(\\d+)", RegexOptions.Compiled);

	// Token: 0x0400253F RID: 9535
	private static readonly object 4 = new object();

	// Token: 0x04002540 RID: 9536
	private static readonly Dictionary<long, 2218.2219> 5 = new Dictionary<long, 2218.2219>();

	// Token: 0x04002541 RID: 9537
	private static readonly Dictionary<long, List<Action>> 6 = new Dictionary<long, List<Action>>();

	// Token: 0x04002542 RID: 9538
	private static readonly Dictionary<long, DateTime> 7 = new Dictionary<long, DateTime>();

	// Token: 0x02000682 RID: 1666
	[276]
	private sealed class 2219
	{
		// Token: 0x04002543 RID: 9539
		public int 1;

		// Token: 0x04002544 RID: 9540
		public DateTime 2;
	}
}
