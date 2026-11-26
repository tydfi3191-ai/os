using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Text;

// Token: 0x0200096F RID: 2415
public sealed class 1614
{
	// Token: 0x0600440F RID: 17423
	[DllImport("crypt32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool CryptProtectData(ref 1614.1616 1, string 2, ref 1614.1616 3, IntPtr 4, ref 1614.1615 5, int 6, ref 1614.1616 7);

	// Token: 0x06004410 RID: 17424
	[DllImport("crypt32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool CryptUnprotectData(ref 1614.1616 1, ref string 2, ref 1614.1616 3, IntPtr 4, ref 1614.1615 5, int 6, ref 1614.1616 7);

	// Token: 0x06004411 RID: 17425 RVA: 0x001ACC78 File Offset: 0x001AAE78
	private static void 1(ref 1614.1615 1)
	{
		1.1 = Marshal.SizeOf(typeof(1614.1615));
		1.2 = 0;
		1.3 = 1614.1;
		1.4 = null;
	}

	// Token: 0x06004412 RID: 17426 RVA: 0x001ACCA8 File Offset: 0x001AAEA8
	private static void 2(byte[] 1, ref 1614.1616 2)
	{
		if (1 == null)
		{
			1 = new byte[0];
		}
		2.2 = Marshal.AllocHGlobal(1.Length);
		if (2.2 == IntPtr.Zero)
		{
			throw new Exception("Unable to allocate data buffer for BLOB structure.");
		}
		2.1 = 1.Length;
		Marshal.Copy(1, 0, 2.2, 1.Length);
	}

	// Token: 0x06004413 RID: 17427 RVA: 0x001ACD04 File Offset: 0x001AAF04
	public static string 3(1614.1617 1, string 2, string 3, string 4)
	{
		if (2 == null)
		{
			2 = string.Empty;
		}
		if (3 == null)
		{
			3 = string.Empty;
		}
		return Convert.ToBase64String(1614.4(1, Encoding.UTF8.GetBytes(2), Encoding.UTF8.GetBytes(3), 4));
	}

	// Token: 0x06004414 RID: 17428 RVA: 0x001ACD3C File Offset: 0x001AAF3C
	public static byte[] 4(1614.1617 1, byte[] 2, byte[] 3, string 4)
	{
		if (2 == null)
		{
			2 = new byte[0];
		}
		if (3 == null)
		{
			3 = new byte[0];
		}
		if (4 == null)
		{
			4 = string.Empty;
		}
		1614.1616 5 = default(1614.1616);
		1614.1616 6 = default(1614.1616);
		1614.1616 7 = default(1614.1616);
		1614.1615 8 = default(1614.1615);
		1614.1(ref 8);
		byte[] result;
		try
		{
			try
			{
				1614.2(2, ref 5);
			}
			catch (Exception innerException)
			{
				throw new Exception("Cannot initialize plaintext BLOB.", innerException);
			}
			try
			{
				1614.2(3, ref 7);
			}
			catch (Exception innerException2)
			{
				throw new Exception("Cannot initialize entropy BLOB.", innerException2);
			}
			int num = 1;
			if (1 == (1614.1617)2)
			{
				num |= 4;
			}
			if (!1614.CryptProtectData(ref 5, 4, ref 7, IntPtr.Zero, ref 8, num, ref 6))
			{
				int lastWin32Error = Marshal.GetLastWin32Error();
				throw new Exception("CryptProtectData failed.", new Win32Exception(lastWin32Error));
			}
			byte[] array = new byte[6.1];
			Marshal.Copy(6.2, array, 0, 6.1);
			result = array;
		}
		catch (Exception innerException3)
		{
			throw new Exception("DPAPI was unable to encrypt data.", innerException3);
		}
		finally
		{
			if (5.2 != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(5.2);
			}
			if (6.2 != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(6.2);
			}
			if (7.2 != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(7.2);
			}
		}
		return result;
	}

	// Token: 0x06004415 RID: 17429 RVA: 0x001ACEC4 File Offset: 0x001AB0C4
	public static string 5(string 1, string 2, out string 3)
	{
		if (2 == null)
		{
			2 = string.Empty;
		}
		return Encoding.UTF8.GetString(1614.6(Convert.FromBase64String(1), Encoding.UTF8.GetBytes(2), out 3));
	}

	// Token: 0x06004416 RID: 17430 RVA: 0x001ACEF4 File Offset: 0x001AB0F4
	public static byte[] 6(byte[] 1, byte[] 2, out string 3)
	{
		1614.1616 4 = default(1614.1616);
		1614.1616 5 = default(1614.1616);
		1614.1616 6 = default(1614.1616);
		1614.1615 7 = default(1614.1615);
		1614.1(ref 7);
		3 = string.Empty;
		byte[] result;
		try
		{
			try
			{
				1614.2(1, ref 5);
			}
			catch (Exception innerException)
			{
				throw new Exception("Cannot initialize ciphertext BLOB.", innerException);
			}
			try
			{
				1614.2(2, ref 6);
			}
			catch (Exception innerException2)
			{
				throw new Exception("Cannot initialize entropy BLOB.", innerException2);
			}
			if (!1614.CryptUnprotectData(ref 5, ref 3, ref 6, IntPtr.Zero, ref 7, 1, ref 4))
			{
				int lastWin32Error = Marshal.GetLastWin32Error();
				throw new Exception("CryptUnprotectData failed.", new Win32Exception(lastWin32Error));
			}
			byte[] array = new byte[4.1];
			Marshal.Copy(4.2, array, 0, 4.1);
			result = array;
		}
		catch (Exception innerException3)
		{
			throw new Exception("DPAPI was unable to decrypt data.", innerException3);
		}
		finally
		{
			if (4.2 != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(4.2);
			}
			if (5.2 != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(5.2);
			}
			if (6.2 != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(6.2);
			}
		}
		return result;
	}

	// Token: 0x040031E3 RID: 12771
	private static IntPtr 1 = (IntPtr)0;

	// Token: 0x040031E4 RID: 12772
	private static 1614.1617 2 = (1614.1617)1;

	// Token: 0x02000970 RID: 2416
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct 1616
	{
		// Token: 0x040031E5 RID: 12773
		public int 1;

		// Token: 0x040031E6 RID: 12774
		public IntPtr 2;
	}

	// Token: 0x02000971 RID: 2417
	public enum 1617
	{

	}

	// Token: 0x02000972 RID: 2418
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct 1615
	{
		// Token: 0x040031E8 RID: 12776
		public int 1;

		// Token: 0x040031E9 RID: 12777
		public int 2;

		// Token: 0x040031EA RID: 12778
		public IntPtr 3;

		// Token: 0x040031EB RID: 12779
		public string 4;
	}
}
