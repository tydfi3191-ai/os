using System;
using System.Runtime.InteropServices;

// Token: 0x02000BC9 RID: 3017
public sealed class 1197
{
	// Token: 0x060052F5 RID: 21237 RVA: 0x00209978 File Offset: 0x00207B78
	internal static uint 1(string 1)
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

	// Token: 0x04003F1A RID: 16154
	internal static readonly int 1;

	// Token: 0x04003F1B RID: 16155
	internal static readonly long 2;

	// Token: 0x04003F1C RID: 16156
	internal static readonly int 3;

	// Token: 0x04003F1D RID: 16157
	internal static readonly long 4;

	// Token: 0x02000BCA RID: 3018
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 20)]
	public struct 1198
	{
	}

	// Token: 0x02000BCB RID: 3019
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 40)]
	public struct 1199
	{
	}

	// Token: 0x02000BCC RID: 3020
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 88)]
	public struct 1200
	{
	}

	// Token: 0x02000BCD RID: 3021
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 72)]
	public struct 1201
	{
	}

	// Token: 0x02000BCE RID: 3022
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 60)]
	public struct 1202
	{
	}

	// Token: 0x02000BCF RID: 3023
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 24)]
	public struct 1203
	{
	}

	// Token: 0x02000BD0 RID: 3024
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 264)]
	public struct 1204
	{
	}

	// Token: 0x02000BD1 RID: 3025
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 984)]
	public struct 1205
	{
	}

	// Token: 0x02000BD2 RID: 3026
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 16)]
	public struct 1206
	{
	}
}
