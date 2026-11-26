using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

// Token: 0x020002EC RID: 748
[ComVisible(false)]
public sealed class 448
{
	// Token: 0x06001667 RID: 5735 RVA: 0x000055AC File Offset: 0x000037AC
	private 448()
	{
	}

	// Token: 0x06001668 RID: 5736 RVA: 0x0004D074 File Offset: 0x0004B274
	public static int GetNumber3101_4008()
	{
		return 448.number3;
	}

	// Token: 0x06001669 RID: 5737 RVA: 0x0004D07B File Offset: 0x0004B27B
	public static void Method4009(int 1)
	{
		if (1 < 0 || 1 > 65535 || 1 == 1 || 1 == 2 || 1 == 3 || 1 == 42)
		{
			throw new ArgumentOutOfRangeException("#=zUkSU2UA=");
		}
		448.number3 = 1;
	}

	// Token: 0x0600166A RID: 5738 RVA: 0x0004D0AB File Offset: 0x0004B2AB
	public static string Method4010(byte[] 1, int 2)
	{
		if (1 == null)
		{
			return string.Empty;
		}
		return Encoding.GetEncoding(448.GetNumber3101_4008()).GetString(1, 0, 2);
	}

	// Token: 0x0600166B RID: 5739 RVA: 0x0004D0C8 File Offset: 0x0004B2C8
	public static string Method4010(byte[] 1)
	{
		if (1 == null)
		{
			return string.Empty;
		}
		return 448.Method4010(1, 1.Length);
	}

	// Token: 0x0600166C RID: 5740 RVA: 0x0004D0DC File Offset: 0x0004B2DC
	public static string Method4012(int 1, byte[] 2, int 3)
	{
		if (2 == null)
		{
			return string.Empty;
		}
		if ((1 & 2048) != 0)
		{
			return Encoding.UTF8.GetString(2, 0, 3);
		}
		return 448.Method4010(2, 3);
	}

	// Token: 0x0600166D RID: 5741 RVA: 0x0004D105 File Offset: 0x0004B305
	public static string Method4012(int 1, byte[] 2)
	{
		if (2 == null)
		{
			return string.Empty;
		}
		if ((1 & 2048) != 0)
		{
			return Encoding.UTF8.GetString(2, 0, 2.Length);
		}
		return 448.Method4010(2, 2.Length);
	}

	// Token: 0x0600166E RID: 5742 RVA: 0x0004D132 File Offset: 0x0004B332
	public static byte[] Method4014(string 1)
	{
		if (1 == null)
		{
			return new byte[0];
		}
		return Encoding.GetEncoding(448.GetNumber3101_4008()).GetBytes(1);
	}

	// Token: 0x0600166F RID: 5743 RVA: 0x0004D14E File Offset: 0x0004B34E
	public static byte[] Method4014(int 1, string 2)
	{
		if (2 == null)
		{
			return new byte[0];
		}
		if ((1 & 2048) != 0)
		{
			return Encoding.UTF8.GetBytes(2);
		}
		return 448.Method4014(2);
	}

	// Token: 0x04000A82 RID: 2690
	private static int number3 = (Thread.CurrentThread.CurrentCulture.TextInfo.OEMCodePage == 1 || Thread.CurrentThread.CurrentCulture.TextInfo.OEMCodePage == 2 || Thread.CurrentThread.CurrentCulture.TextInfo.OEMCodePage == 3 || Thread.CurrentThread.CurrentCulture.TextInfo.OEMCodePage == 42) ? 437 : Thread.CurrentThread.CurrentCulture.TextInfo.OEMCodePage;
}
