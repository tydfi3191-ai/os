using System;

// Token: 0x02000124 RID: 292
[241(0)]
[242(1)]
public static class 420
{
	// Token: 0x06000A7B RID: 2683 RVA: 0x0002837D File Offset: 0x0002657D
	internal static object Method3206(bool 1)
	{
		if (!1)
		{
			return 420.value2;
		}
		return 420.value;
	}

	// Token: 0x06000A7C RID: 2684 RVA: 0x00028390 File Offset: 0x00026590
	internal static object Method3206(int 1)
	{
		object result;
		switch (1)
		{
		case -1:
			result = 420.value3;
			break;
		case 0:
			result = 420.value4;
			break;
		case 1:
			result = 420.value5;
			break;
		case 2:
			result = 420.value6;
			break;
		case 3:
			result = 420.value7;
			break;
		case 4:
			result = 420.value8;
			break;
		case 5:
			result = 420.value9;
			break;
		case 6:
			result = 420.value10;
			break;
		case 7:
			result = 420.value11;
			break;
		case 8:
			result = 420.value12;
			break;
		default:
			result = 1;
			break;
		}
		return result;
	}

	// Token: 0x06000A7D RID: 2685 RVA: 0x00028428 File Offset: 0x00026628
	internal static object Method3206(long 1)
	{
		long num = 1 - -1L;
		if (num <= 9L)
		{
			long num2 = num;
			if (num2 <= 9L)
			{
				switch ((uint)num2)
				{
				case 0U:
					return 420.value13;
				case 1U:
					return 420.value14;
				case 2U:
					return 420.value15;
				case 3U:
					return 420.value16;
				case 4U:
					return 420.value17;
				case 5U:
					return 420.value18;
				case 6U:
					return 420.value19;
				case 7U:
					return 420.value20;
				case 8U:
					return 420.value21;
				case 9U:
					return 420.value22;
				}
			}
		}
		return 1;
	}

	// Token: 0x06000A7E RID: 2686 RVA: 0x000284BC File Offset: 0x000266BC
	internal static object Method3206(decimal 1)
	{
		return 1;
	}

	// Token: 0x06000A7F RID: 2687 RVA: 0x000284C4 File Offset: 0x000266C4
	internal static object Method3206(double 1)
	{
		if (1 == 0.0)
		{
			if (!double.IsNegativeInfinity(1.0 / 1))
			{
				return 420.value26;
			}
			return 420.value27;
		}
		else if (double.IsInfinity(1))
		{
			if (!double.IsPositiveInfinity(1))
			{
				return 420.value25;
			}
			return 420.value24;
		}
		else
		{
			if (double.IsNaN(1))
			{
				return 420.value23;
			}
			return 1;
		}
	}

	// Token: 0x04000522 RID: 1314
	internal static readonly object value = true;

	// Token: 0x04000523 RID: 1315
	internal static readonly object value2 = false;

	// Token: 0x04000524 RID: 1316
	internal static readonly object value3 = -1;

	// Token: 0x04000525 RID: 1317
	internal static readonly object value4 = 0;

	// Token: 0x04000526 RID: 1318
	internal static readonly object value5 = 1;

	// Token: 0x04000527 RID: 1319
	internal static readonly object value6 = 2;

	// Token: 0x04000528 RID: 1320
	internal static readonly object value7 = 3;

	// Token: 0x04000529 RID: 1321
	internal static readonly object value8 = 4;

	// Token: 0x0400052A RID: 1322
	internal static readonly object value9 = 5;

	// Token: 0x0400052B RID: 1323
	internal static readonly object value10 = 6;

	// Token: 0x0400052C RID: 1324
	internal static readonly object value11 = 7;

	// Token: 0x0400052D RID: 1325
	internal static readonly object value12 = 8;

	// Token: 0x0400052E RID: 1326
	internal static readonly object value13 = -1L;

	// Token: 0x0400052F RID: 1327
	internal static readonly object value14 = 0L;

	// Token: 0x04000530 RID: 1328
	internal static readonly object value15 = 1L;

	// Token: 0x04000531 RID: 1329
	internal static readonly object value16 = 2L;

	// Token: 0x04000532 RID: 1330
	internal static readonly object value17 = 3L;

	// Token: 0x04000533 RID: 1331
	internal static readonly object value18 = 4L;

	// Token: 0x04000534 RID: 1332
	internal static readonly object value19 = 5L;

	// Token: 0x04000535 RID: 1333
	internal static readonly object value20 = 6L;

	// Token: 0x04000536 RID: 1334
	internal static readonly object value21 = 7L;

	// Token: 0x04000537 RID: 1335
	internal static readonly object value22 = 8L;

	// Token: 0x04000538 RID: 1336
	internal static readonly object value23 = double.NaN;

	// Token: 0x04000539 RID: 1337
	internal static readonly object value24 = double.PositiveInfinity;

	// Token: 0x0400053A RID: 1338
	internal static readonly object value25 = double.NegativeInfinity;

	// Token: 0x0400053B RID: 1339
	internal static readonly object value26 = 0.0;

	// Token: 0x0400053C RID: 1340
	internal static readonly object value27 = --0.0;
}
