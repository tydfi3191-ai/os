using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

// Token: 0x02000BD6 RID: 3030
[ComVisible(false)]
public static class 1210
{
	// Token: 0x060052FC RID: 21244
	[DllImport("wintrust.dll")]
	private static extern uint WinVerifyTrust(IntPtr 1, IntPtr 2, IntPtr 3);

	// Token: 0x060052FD RID: 21245 RVA: 0x00209B70 File Offset: 0x00207D70
	private static 1210.1211 1(string 1, StoreLocation 2)
	{
		1210.1211 result;
		try
		{
			X509Store x509Store = new X509Store(StoreName.Root, 2);
			x509Store.Open(OpenFlags.ReadOnly);
			result = ((x509Store.Certificates.Find(X509FindType.FindBySubjectName, 1, true).Count <= 0) ? ((1210.1211)1) : ((1210.1211)0));
		}
		catch
		{
			result = (1210.1211)2;
		}
		return result;
	}

	// Token: 0x060052FE RID: 21246 RVA: 0x00209BC0 File Offset: 0x00207DC0
	public static bool 2()
	{
		1210.1211 <<EMPTY_NAME>> = 1210.1("Microsoft Identity Verification Root Certificate Authority 2020", StoreLocation.LocalMachine);
		bool result;
		if (<<EMPTY_NAME>> != (1210.1211)0)
		{
			if (<<EMPTY_NAME>> != (1210.1211)1)
			{
				1210.1211 2 = 1210.1("Microsoft Identity Verification Root Certificate Authority 2020", StoreLocation.CurrentUser);
				bool flag = 2 == (1210.1211)0 || 2 == (1210.1211)2;
				result = flag;
			}
			else
			{
				result = false;
			}
		}
		else
		{
			result = true;
		}
		return result;
	}

	// Token: 0x060052FF RID: 21247 RVA: 0x00209C0C File Offset: 0x00207E0C
	public static bool 3(string 1)
	{
		bool result;
		try
		{
			Guid guid = new Guid("{00AAC56B-CD44-11d0-8CC2-00C04FC295EE}");
			uint num = 0U;
			using (1176 2 = new 1176(1, Guid.Empty))
			{
				372 3 = new 372(Marshal.AllocHGlobal(Marshal.SizeOf(typeof(Guid))), (484)0);
				try
				{
					372 4 = new 372(Marshal.AllocHGlobal(Marshal.SizeOf(typeof(1213))), (484)0);
					try
					{
						1213 5 = new 1213(2);
						IntPtr intPtr = 3;
						IntPtr intPtr2 = 4;
						Marshal.StructureToPtr(guid, intPtr, true);
						Marshal.StructureToPtr(5, intPtr2, true);
						num = 1210.WinVerifyTrust(IntPtr.Zero, intPtr, intPtr2);
					}
					finally
					{
						((IDisposable)4).Dispose();
					}
				}
				finally
				{
					((IDisposable)3).Dispose();
				}
			}
			bool flag = num == 0U;
			if (!flag && !1210.2())
			{
				flag = true;
			}
			result = flag;
		}
		catch
		{
			result = true;
		}
		return result;
	}

	// Token: 0x02000BD7 RID: 3031
	public enum 1211
	{

	}
}
