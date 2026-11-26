using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

// Token: 0x02000BE9 RID: 3049
public sealed class 1119 : 282, IDisposable
{
	// Token: 0x0600534C RID: 21324 RVA: 0x0020A744 File Offset: 0x00208944
	protected 1119(bool 1, 289 2)
	{
		if (2 == null)
		{
			throw new ArgumentNullException("parameters");
		}
		int num = 2.GetRecoveredType01460030_115().Method0812();
		this.4 = 1119.6(num);
		this.2(1119.4(num, 1));
		this.3(1119.5(num, 1));
		1177.1(1177.NCryptOpenStorageProvider(out this.2, "Microsoft Software Key Storage Provider", 0U));
		string text;
		byte[] array = this.8(2, out text);
		1177.1(1177.NCryptImportKey(this.2, IntPtr.Zero, text, IntPtr.Zero, out this.3, array, array.Length, 64U));
	}

	// Token: 0x0600534D RID: 21325 RVA: 0x0020A7E0 File Offset: 0x002089E0
	public static 1119 1(bool 1, 289 2)
	{
		if (!1119.1)
		{
			return null;
		}
		if (!1175.2())
		{
			1119.1 = false;
			return null;
		}
		1119 3 = null;
		1119 result;
		try
		{
			3 = new 1119(1, 2);
			result = 3;
		}
		catch
		{
			if (3 != null)
			{
				3.Dispose();
			}
			1119.1 = false;
			result = null;
		}
		return result;
	}

	// Token: 0x0600534E RID: 21326 RVA: 0x0020A838 File Offset: 0x00208A38
	private void 2(int 1)
	{
		this.5 = 1;
	}

	// Token: 0x0600534F RID: 21327 RVA: 0x0020A841 File Offset: 0x00208A41
	[CompilerGenerated]
	public int GetOutputBlockSize()
	{
		return this.6;
	}

	// Token: 0x06005350 RID: 21328 RVA: 0x0020A849 File Offset: 0x00208A49
	private void 3(int 1)
	{
		this.6 = 1;
	}

	// Token: 0x06005351 RID: 21329 RVA: 0x00006208 File Offset: 0x00004408
	private static int 4(int 1, bool 2)
	{
		if (!2)
		{
			return (1 + 7) / 8;
		}
		return (1 - 1) / 8;
	}

	// Token: 0x06005352 RID: 21330 RVA: 0x00006218 File Offset: 0x00004418
	private static int 5(int 1, bool 2)
	{
		if (!2)
		{
			return (1 - 1) / 8;
		}
		return (1 + 7) / 8;
	}

	// Token: 0x06005353 RID: 21331 RVA: 0x0020A852 File Offset: 0x00208A52
	private static int 6(int 1)
	{
		return (1 + 7) / 8;
	}

	// Token: 0x06005354 RID: 21332 RVA: 0x0020A859 File Offset: 0x00208A59
	private void 7()
	{
		if (!this.9)
		{
			this.7 = new byte[this.4];
			this.8 = new byte[this.4];
			this.9 = true;
		}
	}

	// Token: 0x06005355 RID: 21333 RVA: 0x0020A88C File Offset: 0x00208A8C
	public int TransformBlock(byte[] 1, int 2, int 3, byte[] 4, int 5, RandomNumberGenerator 6)
	{
		this.7();
		byte[] array = this.7;
		int num = array.Length - 3;
		if (num > 0)
		{
			Array.Clear(array, 0, num);
		}
		Buffer.BlockCopy(1, 2, array, num, 3);
		int num2;
		1177.1(1177.NCryptEncrypt(this.3, array, array.Length, IntPtr.Zero, this.8, this.4, out num2, 1));
		int outputBlockSize = this.GetOutputBlockSize();
		int srcOffset = num2 - outputBlockSize;
		Buffer.BlockCopy(this.8, srcOffset, 4, 5, outputBlockSize);
		return outputBlockSize;
	}

	// Token: 0x06005356 RID: 21334 RVA: 0x0020A909 File Offset: 0x00208B09
	protected byte[] 8(289 1, out string 2)
	{
		2 = "RSAPUBLICBLOB";
		return 1119.9(1);
	}

	// Token: 0x06005357 RID: 21335 RVA: 0x0020A918 File Offset: 0x00208B18
	protected static byte[] 9(289 1)
	{
		int num = Marshal.SizeOf(typeof(1177.1178));
		byte[] result = new byte[num + 1.GetRecoveredType01460031_116().Method0835() + 1.GetRecoveredType01460030_115().Method0835()];
		1119.10(new 1177.1178
		{
			1 = 826364754U,
			2 = 1.GetRecoveredType01460030_115().Method0812(),
			3 = 1.GetRecoveredType01460031_116().Method0835(),
			4 = 1.GetRecoveredType01460030_115().Method0835()
		}, result, 0);
		int num2 = num;
		num2 += 1.GetRecoveredType01460031_116().Method0836(result, num2);
		num2 += 1.GetRecoveredType01460030_115().Method0836(result, num2);
		return result;
	}

	// Token: 0x06005358 RID: 21336 RVA: 0x0020A9C8 File Offset: 0x00208BC8
	protected static void 10(1177.1178 1, byte[] 2, int 3)
	{
		int num = Marshal.SizeOf(1);
		if (3 + num > 2.Length)
		{
			throw new ArgumentException("blob");
		}
		try
		{
		}
		finally
		{
			IntPtr intPtr = Marshal.AllocHGlobal(num);
			Marshal.StructureToPtr(1, intPtr, false);
			Marshal.Copy(intPtr, 2, 3, num);
			Marshal.DestroyStructure(intPtr, typeof(1177.1178));
			Marshal.FreeHGlobal(intPtr);
		}
	}

	// Token: 0x06005359 RID: 21337 RVA: 0x0020AA3C File Offset: 0x00208C3C
	public void Dispose()
	{
		if (this.2 != null)
		{
			this.2.Dispose();
			this.2 = null;
		}
		if (this.3 != null)
		{
			this.3.Dispose();
			this.3 = null;
		}
	}

	// Token: 0x0600535A RID: 21338 RVA: 0x0020AA72 File Offset: 0x00208C72
	[CompilerGenerated]
	public int GetInputBlockSize()
	{
		return this.5;
	}

	// Token: 0x04003F4D RID: 16205
	private static bool 1 = true;

	// Token: 0x04003F4E RID: 16206
	protected 1177.1180 2;

	// Token: 0x04003F4F RID: 16207
	protected 1177.1179 3;

	// Token: 0x04003F50 RID: 16208
	protected int 4;

	// Token: 0x04003F51 RID: 16209
	private int 5;

	// Token: 0x04003F52 RID: 16210
	private int 6;

	// Token: 0x04003F53 RID: 16211
	private byte[] 7;

	// Token: 0x04003F54 RID: 16212
	private byte[] 8;

	// Token: 0x04003F55 RID: 16213
	private bool 9;
}
