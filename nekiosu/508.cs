using System;
using System.Runtime.InteropServices;

// Token: 0x020001D8 RID: 472
public sealed class 508
{
	// Token: 0x06000F05 RID: 3845 RVA: 0x0003328C File Offset: 0x0003148C
	internal static uint ComputeStringHash(string 1)
	{
		uint num = 0U;
		if (1 != null)
		{
			num = 2166136261U;
			for (int i = 0; i < 1.Length; i++)
			{
				num = ((uint)1[i] ^ num) * 16777619U;
			}
		}
		return num;
	}

	// Token: 0x0400074A RID: 1866
	internal static readonly 508.513 _recoveredType10374602;

	// Token: 0x0400074B RID: 1867
	internal static readonly 508.509 _recoveredType10334603;

	// Token: 0x0400074C RID: 1868
	internal static readonly 508.511 _recoveredType10354604;

	// Token: 0x0400074D RID: 1869
	internal static readonly 508.512 _recoveredType10364605;

	// Token: 0x0400074E RID: 1870
	internal static readonly 508.510 _recoveredType10344606;

	// Token: 0x0400074F RID: 1871
	internal static readonly 508.511 _recoveredType10354607;

	// Token: 0x020001D9 RID: 473
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 28)]
	public struct 509
	{
	}

	// Token: 0x020001DA RID: 474
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 6)]
	public struct 510
	{
	}

	// Token: 0x020001DB RID: 475
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 52)]
	public struct 511
	{
	}

	// Token: 0x020001DC RID: 476
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 36)]
	public struct 512
	{
	}

	// Token: 0x020001DD RID: 477
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 10)]
	public struct 513
	{
	}
}
