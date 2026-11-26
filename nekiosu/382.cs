using System;
using System.Globalization;
using System.IO;
using System.Xml;

// Token: 0x02000118 RID: 280
[241(0)]
[242(1)]
public static class 382
{
	// Token: 0x06000A1E RID: 2590 RVA: 0x0002630D File Offset: 0x0002450D
	public static TimeSpan Method2106(this DateTime 1)
	{
		return TimeZoneInfo.Local.GetUtcOffset(1);
	}

	// Token: 0x06000A1F RID: 2591 RVA: 0x0002631C File Offset: 0x0002451C
	public static XmlDateTimeSerializationMode Method2107(DateTimeKind 1)
	{
		XmlDateTimeSerializationMode result;
		switch (1)
		{
		case DateTimeKind.Unspecified:
			result = XmlDateTimeSerializationMode.Unspecified;
			break;
		case DateTimeKind.Utc:
			result = XmlDateTimeSerializationMode.Utc;
			break;
		case DateTimeKind.Local:
			result = XmlDateTimeSerializationMode.Local;
			break;
		default:
			throw 736.Method11629("kind", 1, "Unexpected DateTimeKind value.");
		}
		return result;
	}

	// Token: 0x06000A20 RID: 2592 RVA: 0x00026360 File Offset: 0x00024560
	internal static DateTime Method2108(DateTime 1, 49 2)
	{
		switch (2)
		{
		case (49)0:
			1 = 382.Method2109(1);
			break;
		case (49)1:
			1 = 382.Method2110(1);
			break;
		case (49)2:
			1 = new DateTime(1.Ticks, DateTimeKind.Unspecified);
			break;
		case (49)3:
			break;
		default:
			throw new ArgumentException("Invalid date time handling value.");
		}
		return 1;
	}

	// Token: 0x06000A21 RID: 2593 RVA: 0x000263B8 File Offset: 0x000245B8
	private static DateTime Method2109(DateTime 1)
	{
		DateTime result;
		switch (1.Kind)
		{
		case DateTimeKind.Unspecified:
			result = new DateTime(1.Ticks, DateTimeKind.Local);
			break;
		case DateTimeKind.Utc:
			result = 1.ToLocalTime();
			break;
		case DateTimeKind.Local:
			result = 1;
			break;
		default:
			result = 1;
			break;
		}
		return result;
	}

	// Token: 0x06000A22 RID: 2594 RVA: 0x00026404 File Offset: 0x00024604
	private static DateTime Method2110(DateTime 1)
	{
		DateTime result;
		switch (1.Kind)
		{
		case DateTimeKind.Unspecified:
			result = new DateTime(1.Ticks, DateTimeKind.Utc);
			break;
		case DateTimeKind.Utc:
			result = 1;
			break;
		case DateTimeKind.Local:
			result = 1.ToUniversalTime();
			break;
		default:
			result = 1;
			break;
		}
		return result;
	}

	// Token: 0x06000A23 RID: 2595 RVA: 0x0002644E File Offset: 0x0002464E
	private static long Method2111(DateTime 1)
	{
		if (1.Kind == DateTimeKind.Utc)
		{
			return 1.Ticks;
		}
		return 382.Method2111(1, 1.Method2106());
	}

	// Token: 0x06000A24 RID: 2596 RVA: 0x00026470 File Offset: 0x00024670
	private static long Method2111(DateTime 1, TimeSpan 2)
	{
		if (1.Kind == DateTimeKind.Utc || 1 == DateTime.MaxValue || 1 == DateTime.MinValue)
		{
			return 1.Ticks;
		}
		long num = 1.Ticks - 2.Ticks;
		if (num > 3155378975999999999L)
		{
			return 3155378975999999999L;
		}
		if (num < 0L)
		{
			return 0L;
		}
		return num;
	}

	// Token: 0x06000A25 RID: 2597 RVA: 0x000264D8 File Offset: 0x000246D8
	internal static long Method2113(DateTime 1, TimeSpan 2)
	{
		return 382.Method2116(382.Method2111(1, 2));
	}

	// Token: 0x06000A26 RID: 2598 RVA: 0x000264E6 File Offset: 0x000246E6
	internal static long Method2113(DateTime 1)
	{
		return 382.Method2113(1, true);
	}

	// Token: 0x06000A27 RID: 2599 RVA: 0x000264EF File Offset: 0x000246EF
	internal static long Method2113(DateTime 1, bool 2)
	{
		return 382.Method2116(2 ? 382.Method2111(1) : 1.Ticks);
	}

	// Token: 0x06000A28 RID: 2600 RVA: 0x00026508 File Offset: 0x00024708
	private static long Method2116(long 1)
	{
		return (1 - 382.number5) / 10000L;
	}

	// Token: 0x06000A29 RID: 2601 RVA: 0x00026518 File Offset: 0x00024718
	internal static DateTime Method2117(long 1)
	{
		return new DateTime(1 * 10000L + 382.number5, DateTimeKind.Utc);
	}

	// Token: 0x06000A2A RID: 2602 RVA: 0x00026530 File Offset: 0x00024730
	internal static bool Method2118(743 1, 49 2, out DateTime 3)
	{
		361 4 = default(361);
		if (!4.Method1646(1.GetCharArray9358_11931(), 1.GetNumber9359_11932(), 1.GetNumber9360_11933()))
		{
			3 = default(DateTime);
			return false;
		}
		DateTime 5 = 382.Method2120(4);
		switch (4._recoveredType18661110)
		{
		case (692)1:
			5 = new DateTime(5.Ticks, DateTimeKind.Utc);
			break;
		case (692)2:
		{
			TimeSpan timeSpan = new TimeSpan(4.number10, 4.number11, 0);
			long num = 5.Ticks + timeSpan.Ticks;
			if (num <= DateTime.MaxValue.Ticks)
			{
				5 = new DateTime(num, DateTimeKind.Utc).ToLocalTime();
			}
			else
			{
				num += 5.Method2106().Ticks;
				if (num > DateTime.MaxValue.Ticks)
				{
					num = DateTime.MaxValue.Ticks;
				}
				5 = new DateTime(num, DateTimeKind.Local);
			}
			break;
		}
		case (692)3:
		{
			TimeSpan timeSpan2 = new TimeSpan(4.number10, 4.number11, 0);
			long num2 = 5.Ticks - timeSpan2.Ticks;
			if (num2 >= DateTime.MinValue.Ticks)
			{
				5 = new DateTime(num2, DateTimeKind.Utc).ToLocalTime();
			}
			else
			{
				num2 += 5.Method2106().Ticks;
				if (num2 < DateTime.MinValue.Ticks)
				{
					num2 = DateTime.MinValue.Ticks;
				}
				5 = new DateTime(num2, DateTimeKind.Local);
			}
			break;
		}
		}
		3 = 382.Method2108(5, 2);
		return true;
	}

	// Token: 0x06000A2B RID: 2603 RVA: 0x000266D4 File Offset: 0x000248D4
	internal static bool Method2119(743 1, out DateTimeOffset 2)
	{
		361 3 = default(361);
		if (!3.Method1646(1.GetCharArray9358_11931(), 1.GetNumber9359_11932(), 1.GetNumber9360_11933()))
		{
			2 = default(DateTimeOffset);
			return false;
		}
		DateTime dateTime = 382.Method2120(3);
		TimeSpan timeSpan;
		switch (3._recoveredType18661110)
		{
		case (692)1:
			timeSpan = new TimeSpan(0L);
			break;
		case (692)2:
			timeSpan = new TimeSpan(-3.number10, -3.number11, 0);
			break;
		case (692)3:
			timeSpan = new TimeSpan(3.number10, 3.number11, 0);
			break;
		default:
			timeSpan = TimeZoneInfo.Local.GetUtcOffset(dateTime);
			break;
		}
		TimeSpan offset = timeSpan;
		long num = dateTime.Ticks - offset.Ticks;
		if (num < 0L || num > 3155378975999999999L)
		{
			2 = default(DateTimeOffset);
			return false;
		}
		2 = new DateTimeOffset(dateTime, offset);
		return true;
	}

	// Token: 0x06000A2C RID: 2604 RVA: 0x000267B8 File Offset: 0x000249B8
	private static DateTime Method2120(361 1)
	{
		bool flag;
		if (1.number6 == 24)
		{
			flag = true;
			1.number6 = 0;
		}
		else
		{
			flag = false;
		}
		DateTime result = new DateTime(1.number3, 1.number4, 1.number5, 1.number6, 1.number7, 1.number8).AddTicks((long)1.number9);
		if (flag)
		{
			result = result.AddDays(1.0);
		}
		return result;
	}

	// Token: 0x06000A2D RID: 2605 RVA: 0x0002682C File Offset: 0x00024A2C
	internal static bool Method2121(743 1, 49 2, [241(2)] string 3, CultureInfo 4, out DateTime 5)
	{
		if (1.GetNumber9360_11933() > 0)
		{
			int number9359_ = 1.GetNumber9359_11932();
			if (1[number9359_] == '/')
			{
				if (1.GetNumber9360_11933() >= 9 && 1.StartsWith("/Date(") && 1.EndsWith(")/") && 382.Method2126(1, 2, out 5))
				{
					return true;
				}
			}
			else if (1.GetNumber9360_11933() >= 19 && 1.GetNumber9360_11933() <= 40 && char.IsDigit(1[number9359_]) && 1[number9359_ + 10] == 'T' && 382.Method2118(1, 2, out 5))
			{
				return true;
			}
			if (!538.Method6824(3) && 382.Method2127(1.ToString(), 2, 3, 4, out 5))
			{
				return true;
			}
		}
		5 = default(DateTime);
		return false;
	}

	// Token: 0x06000A2E RID: 2606 RVA: 0x000268FC File Offset: 0x00024AFC
	internal static bool Method2121(string 1, 49 2, [241(2)] string 3, CultureInfo 4, out DateTime 5)
	{
		if (1.Length > 0)
		{
			if (1[0] == '/')
			{
				if (1.Length >= 9 && 1.StartsWith("/Date(", StringComparison.Ordinal) && 1.EndsWith(")/", StringComparison.Ordinal) && 382.Method2126(new 743(1.ToCharArray(), 0, 1.Length), 2, out 5))
				{
					return true;
				}
			}
			else if (1.Length >= 19 && 1.Length <= 40 && char.IsDigit(1[0]) && 1[10] == 'T' && DateTime.TryParseExact(1, "yyyy-MM-ddTHH:mm:ss.FFFFFFFK", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind, out 5))
			{
				5 = 382.Method2108(5, 2);
				return true;
			}
			if (!538.Method6824(3) && 382.Method2127(1, 2, 3, 4, out 5))
			{
				return true;
			}
		}
		5 = default(DateTime);
		return false;
	}

	// Token: 0x06000A2F RID: 2607 RVA: 0x000269E8 File Offset: 0x00024BE8
	internal static bool Method2123(743 1, [241(2)] string 2, CultureInfo 3, out DateTimeOffset 4)
	{
		if (1.GetNumber9360_11933() > 0)
		{
			int number9359_ = 1.GetNumber9359_11932();
			if (1[number9359_] == '/')
			{
				if (1.GetNumber9360_11933() >= 9 && 1.StartsWith("/Date(") && 1.EndsWith(")/") && 382.Method2128(1, out 4))
				{
					return true;
				}
			}
			else if (1.GetNumber9360_11933() >= 19 && 1.GetNumber9360_11933() <= 40 && char.IsDigit(1[number9359_]) && 1[number9359_ + 10] == 'T' && 382.Method2119(1, out 4))
			{
				return true;
			}
			if (!538.Method6824(2) && 382.Method2129(1.ToString(), 2, 3, out 4))
			{
				return true;
			}
		}
		4 = default(DateTimeOffset);
		return false;
	}

	// Token: 0x06000A30 RID: 2608 RVA: 0x00026AB0 File Offset: 0x00024CB0
	internal static bool Method2123(string 1, [241(2)] string 2, CultureInfo 3, out DateTimeOffset 4)
	{
		if (1.Length > 0)
		{
			if (1[0] == '/')
			{
				if (1.Length >= 9 && 1.StartsWith("/Date(", StringComparison.Ordinal) && 1.EndsWith(")/", StringComparison.Ordinal) && 382.Method2128(new 743(1.ToCharArray(), 0, 1.Length), out 4))
				{
					return true;
				}
			}
			else if (1.Length >= 19 && 1.Length <= 40 && char.IsDigit(1[0]) && 1[10] == 'T' && DateTimeOffset.TryParseExact(1, "yyyy-MM-ddTHH:mm:ss.FFFFFFFK", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind, out 4) && 382.Method2119(new 743(1.ToCharArray(), 0, 1.Length), out 4))
			{
				return true;
			}
			if (!538.Method6824(2) && 382.Method2129(1, 2, 3, out 4))
			{
				return true;
			}
		}
		4 = default(DateTimeOffset);
		return false;
	}

	// Token: 0x06000A31 RID: 2609 RVA: 0x00026B9C File Offset: 0x00024D9C
	private static bool Method2125(743 1, out long 2, out TimeSpan 3, out DateTimeKind 4)
	{
		4 = DateTimeKind.Utc;
		int num = 1.IndexOf('+', 7, 1.GetNumber9360_11933() - 8);
		if (num == -1)
		{
			num = 1.IndexOf('-', 7, 1.GetNumber9360_11933() - 8);
		}
		if (num != -1)
		{
			4 = DateTimeKind.Local;
			if (!382.Method2130(1, num + 1.GetNumber9359_11932(), out 3))
			{
				2 = 0L;
				return false;
			}
		}
		else
		{
			3 = TimeSpan.Zero;
			num = 1.GetNumber9360_11933() - 2;
		}
		return 358.Method1506(1.GetCharArray9358_11931(), 6 + 1.GetNumber9359_11932(), num - 6, out 2) == (514)1;
	}

	// Token: 0x06000A32 RID: 2610 RVA: 0x00026C28 File Offset: 0x00024E28
	private static bool Method2126(743 1, 49 2, out DateTime 3)
	{
		long 4;
		TimeSpan timeSpan;
		DateTimeKind dateTimeKind;
		if (!382.Method2125(1, out 4, out timeSpan, out dateTimeKind))
		{
			3 = default(DateTime);
			return false;
		}
		DateTime dateTime = 382.Method2117(4);
		if (dateTimeKind != DateTimeKind.Unspecified)
		{
			if (dateTimeKind != DateTimeKind.Local)
			{
				3 = dateTime;
			}
			else
			{
				3 = dateTime.ToLocalTime();
			}
		}
		else
		{
			3 = DateTime.SpecifyKind(dateTime.ToLocalTime(), DateTimeKind.Unspecified);
		}
		3 = 382.Method2108(3, 2);
		return true;
	}

	// Token: 0x06000A33 RID: 2611 RVA: 0x00026C9C File Offset: 0x00024E9C
	private static bool Method2127(string 1, 49 2, string 3, CultureInfo 4, out DateTime 5)
	{
		DateTime dateTime;
		if (DateTime.TryParseExact(1, 3, 4, DateTimeStyles.RoundtripKind, out dateTime))
		{
			dateTime = 382.Method2108(dateTime, 2);
			5 = dateTime;
			return true;
		}
		5 = default(DateTime);
		return false;
	}

	// Token: 0x06000A34 RID: 2612 RVA: 0x00026CD8 File Offset: 0x00024ED8
	private static bool Method2128(743 1, out DateTimeOffset 2)
	{
		long 3;
		TimeSpan timeSpan;
		DateTimeKind dateTimeKind;
		if (!382.Method2125(1, out 3, out timeSpan, out dateTimeKind))
		{
			2 = default(DateTime);
			return false;
		}
		2 = new DateTimeOffset(382.Method2117(3).Add(timeSpan).Ticks, timeSpan);
		return true;
	}

	// Token: 0x06000A35 RID: 2613 RVA: 0x00026D30 File Offset: 0x00024F30
	private static bool Method2129(string 1, string 2, CultureInfo 3, out DateTimeOffset 4)
	{
		DateTimeOffset dateTimeOffset;
		if (DateTimeOffset.TryParseExact(1, 2, 3, DateTimeStyles.RoundtripKind, out dateTimeOffset))
		{
			4 = dateTimeOffset;
			return true;
		}
		4 = default(DateTimeOffset);
		return false;
	}

	// Token: 0x06000A36 RID: 2614 RVA: 0x00026D60 File Offset: 0x00024F60
	private static bool Method2130(743 1, int 2, out TimeSpan 3)
	{
		bool flag = 1[2] == '-';
		int num;
		if (358.Method1505(1.GetCharArray9358_11931(), 2 + 1, 2, out num) != (514)1)
		{
			3 = default(TimeSpan);
			return false;
		}
		int num2 = 0;
		if (1.GetNumber9360_11933() - 2 > 5 && 358.Method1505(1.GetCharArray9358_11931(), 2 + 3, 2, out num2) != (514)1)
		{
			3 = default(TimeSpan);
			return false;
		}
		3 = TimeSpan.FromHours((double)num) + TimeSpan.FromMinutes((double)num2);
		if (flag)
		{
			3 = 3.Negate();
		}
		return true;
	}

	// Token: 0x06000A37 RID: 2615 RVA: 0x00026DF0 File Offset: 0x00024FF0
	internal static void Method2131(TextWriter 1, DateTime 2, 47 3, [241(2)] string 4, CultureInfo 5)
	{
		if (538.Method6824(4))
		{
			char[] array = new char[64];
			int count = 382.Method2131(array, 0, 2, null, 2.Kind, 3);
			1.Write(array, 0, count);
			return;
		}
		1.Write(2.ToString(4, 5));
	}

	// Token: 0x06000A38 RID: 2616 RVA: 0x00026E44 File Offset: 0x00025044
	internal static int Method2131(char[] 1, int 2, DateTime 3, TimeSpan? 4, DateTimeKind 5, 47 6)
	{
		int num2;
		if (6 == (47)1)
		{
			TimeSpan timeSpan = 4 ?? 3.Method2106();
			long num = 382.Method2113(3, timeSpan);
			"\\/Date(".CopyTo(0, 1, 2, 7);
			num2 = 2 + 7;
			string text = num.ToString(CultureInfo.InvariantCulture);
			text.CopyTo(0, 1, num2, text.Length);
			num2 += text.Length;
			if (5 != DateTimeKind.Unspecified)
			{
				if (5 == DateTimeKind.Local)
				{
					num2 = 382.Method2135(1, num2, timeSpan, 6);
				}
			}
			else if (3 != DateTime.MaxValue && 3 != DateTime.MinValue)
			{
				num2 = 382.Method2135(1, num2, timeSpan, 6);
			}
			")\\/".CopyTo(0, 1, num2, 3);
			num2 += 3;
		}
		else
		{
			num2 = 382.Method2133(1, 2, 3);
			if (5 != DateTimeKind.Utc)
			{
				if (5 == DateTimeKind.Local)
				{
					num2 = 382.Method2135(1, num2, 4 ?? 3.Method2106(), 6);
				}
			}
			else
			{
				1[num2++] = 'Z';
			}
		}
		return num2;
	}

	// Token: 0x06000A39 RID: 2617 RVA: 0x00026F4C File Offset: 0x0002514C
	internal static int Method2133(char[] 1, int 2, DateTime 3)
	{
		int num = 19;
		int 4;
		int 5;
		int 6;
		382.Method2137(3, out 4, out 5, out 6);
		382.Method2134(1, 2, 4, 4);
		1[2 + 4] = '-';
		382.Method2134(1, 2 + 5, 5, 2);
		1[2 + 7] = '-';
		382.Method2134(1, 2 + 8, 6, 2);
		1[2 + 10] = 'T';
		382.Method2134(1, 2 + 11, 3.Hour, 2);
		1[2 + 13] = ':';
		382.Method2134(1, 2 + 14, 3.Minute, 2);
		1[2 + 16] = ':';
		382.Method2134(1, 2 + 17, 3.Second, 2);
		int num2 = (int)(3.Ticks % 10000000L);
		if (num2 != 0)
		{
			int num3 = 7;
			while (num2 % 10 == 0)
			{
				num3--;
				num2 /= 10;
			}
			1[2 + 19] = '.';
			382.Method2134(1, 2 + 20, num2, num3);
			num += num3 + 1;
		}
		return 2 + num;
	}

	// Token: 0x06000A3A RID: 2618 RVA: 0x00027031 File Offset: 0x00025231
	private static void Method2134(char[] 1, int 2, int 3, int 4)
	{
		while (4-- != 0)
		{
			1[2 + 4] = (char)(3 % 10 + 48);
			3 /= 10;
		}
	}

	// Token: 0x06000A3B RID: 2619 RVA: 0x00027050 File Offset: 0x00025250
	internal static int Method2135(char[] 1, int 2, TimeSpan 3, 47 4)
	{
		1[2++] = ((3.Ticks >= 0L) ? '+' : '-');
		int 5 = Math.Abs(3.Hours);
		382.Method2134(1, 2, 5, 2);
		2 += 2;
		if (4 == (47)0)
		{
			1[2++] = ':';
		}
		int 6 = Math.Abs(3.Minutes);
		382.Method2134(1, 2, 6, 2);
		2 += 2;
		return 2;
	}

	// Token: 0x06000A3C RID: 2620 RVA: 0x000270BC File Offset: 0x000252BC
	internal static void Method2136(TextWriter 1, DateTimeOffset 2, 47 3, [241(2)] string 4, CultureInfo 5)
	{
		if (538.Method6824(4))
		{
			char[] array = new char[64];
			int count = 382.Method2131(array, 0, (3 == (47)0) ? 2.DateTime : 2.UtcDateTime, new TimeSpan?(2.Offset), DateTimeKind.Local, 3);
			1.Write(array, 0, count);
			return;
		}
		1.Write(2.ToString(4, 5));
	}

	// Token: 0x06000A3D RID: 2621 RVA: 0x0002711C File Offset: 0x0002531C
	private static void Method2137(DateTime 1, out int 2, out int 3, out int 4)
	{
		int i = (int)(1.Ticks / 864000000000L);
		int num = i / 146097;
		i -= num * 146097;
		int num2 = i / 36524;
		if (num2 == 4)
		{
			num2 = 3;
		}
		i -= num2 * 36524;
		int num3 = i / 1461;
		i -= num3 * 1461;
		int num4 = i / 365;
		if (num4 == 4)
		{
			num4 = 3;
		}
		2 = num * 400 + num2 * 100 + num3 * 4 + num4 + 1;
		i -= num4 * 365;
		int[] array = (num4 == 3 && (num3 != 24 || num2 == 3)) ? 382.numberArray2 : 382.numberArray;
		int num5 = i >> 6;
		while (i >= array[num5])
		{
			num5++;
		}
		3 = num5;
		4 = i - array[num5 - 1] + 1;
	}

	// Token: 0x04000513 RID: 1299
	internal static readonly long number5 = 621355968000000000L;

	// Token: 0x04000514 RID: 1300
	private static readonly int[] numberArray = new int[]
	{
		0,
		31,
		59,
		90,
		120,
		151,
		181,
		212,
		243,
		273,
		304,
		334,
		365
	};

	// Token: 0x04000515 RID: 1301
	private static readonly int[] numberArray2 = new int[]
	{
		0,
		31,
		60,
		91,
		121,
		152,
		182,
		213,
		244,
		274,
		305,
		335,
		366
	};
}
