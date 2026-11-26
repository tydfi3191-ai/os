using System;
using System.IO;
using System.Runtime.InteropServices;

// Token: 0x02000B8C RID: 2956
public sealed class 1292
{
	// Token: 0x06005123 RID: 20771
	[DllImport("Shell32.dll", CharSet = CharSet.Auto)]
	private static extern int SHFileOperation(ref 1292.1294 1);

	// Token: 0x06005124 RID: 20772 RVA: 0x002016BC File Offset: 0x001FF8BC
	public static bool 1(string 1, 1292.1293 2)
	{
		string currentDirectory = Directory.GetCurrentDirectory();
		if (!1.StartsWith(currentDirectory))
		{
			1 = Path.Combine(currentDirectory, 1);
		}
		bool result;
		try
		{
			1292.1294 3 = new 1292.1294
			{
				2 = (1292.1295)3U,
				3 = 1 + "\0\0",
				5 = ((1292.1293)64 | 2)
			};
			1292.SHFileOperation(ref 3);
			result = true;
		}
		catch (Exception)
		{
			result = false;
		}
		return result;
	}

	// Token: 0x06005125 RID: 20773 RVA: 0x00201734 File Offset: 0x001FF934
	public static bool 2(string 1)
	{
		return 1292.1(1, (1292.1293)1044);
	}

	// Token: 0x02000B8D RID: 2957
	public enum 1293 : ushort
	{

	}

	// Token: 0x02000B8E RID: 2958
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto, Pack = 1)]
	public struct 1294
	{
		// Token: 0x04003DB8 RID: 15800
		public IntPtr 1;

		// Token: 0x04003DB9 RID: 15801
		[MarshalAs(UnmanagedType.U4)]
		public 1292.1295 2;

		// Token: 0x04003DBA RID: 15802
		public string 3;

		// Token: 0x04003DBB RID: 15803
		public string 4;

		// Token: 0x04003DBC RID: 15804
		public 1292.1293 5;

		// Token: 0x04003DBD RID: 15805
		[MarshalAs(UnmanagedType.Bool)]
		public bool 6;

		// Token: 0x04003DBE RID: 15806
		public IntPtr 7;

		// Token: 0x04003DBF RID: 15807
		public string 8;
	}

	// Token: 0x02000B8F RID: 2959
	public enum 1295 : uint
	{

	}
}
