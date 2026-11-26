using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;

// Token: 0x02000334 RID: 820
[ComVisible(false)]
public sealed class 355
{
	// Token: 0x0600194E RID: 6478 RVA: 0x0005B5C8 File Offset: 0x000597C8
	public void Method1455(798 1)
	{
		798 2 = this._recoveredType24360895;
		798 3;
		do
		{
			3 = 2;
			798 value = (798)Delegate.Combine(3, 1);
			2 = Interlocked.CompareExchange<798>(ref this._recoveredType24360895, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x0600194F RID: 6479 RVA: 0x0005B600 File Offset: 0x00059800
	public void Method1456(798 1)
	{
		798 2 = this._recoveredType24360895;
		798 3;
		do
		{
			3 = 2;
			798 value = (798)Delegate.Remove(3, 1);
			2 = Interlocked.CompareExchange<798>(ref this._recoveredType24360895, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x06001950 RID: 6480 RVA: 0x0005B638 File Offset: 0x00059838
	private static int Method1457(byte[] 1, int 2)
	{
		int num = (int)(1[7 + 2] & 127);
		num *= 256;
		num += (int)1[6 + 2];
		num *= 256;
		num += (int)1[5 + 2];
		num *= 256;
		num += (int)1[4 + 2];
		num *= 256;
		num += (int)1[3 + 2];
		num *= 256;
		num += (int)1[2 + 2];
		num *= 256;
		num += (int)1[1 + 2];
		num *= 256;
		num += (int)1[2];
		if ((1[7 + 2] & 128) > 0)
		{
			num = -num;
		}
		return num;
	}

	// Token: 0x06001951 RID: 6481 RVA: 0x0005B6D0 File Offset: 0x000598D0
	public void Method1458(string 1, string 2, string 3, 410 4)
	{
		long num;
		long num2;
		long num3;
		using (FileStream fileStream = File.OpenRead(3))
		{
			byte[] array = new byte[32];
			if (fileStream.Read(array, 0, 32) < 32)
			{
				throw new Exception("invalid patch file (too small)");
			}
			if (!355.Method1460(array, "BSDIFF40", 0, 8))
			{
				throw new Exception("invalid patch file (no magic)");
			}
			num = (long)355.Method1457(array, 8);
			num2 = (long)355.Method1457(array, 16);
			num3 = (long)355.Method1457(array, 24);
			if (num < 0L || num2 < 0L || num3 < 0L)
			{
				throw new Exception("invalid patch file (sizes are corrupt)");
			}
		}
		long 5 = num3 * 3L;
		byte[] array2;
		byte[] array3;
		byte[] array4;
		using (FileStream fileStream2 = File.OpenRead(3))
		{
			fileStream2.Seek(32L, SeekOrigin.Begin);
			array2 = new byte[num];
			fileStream2.Read(array2, 0, array2.Length);
			array3 = new byte[num2];
			fileStream2.Read(array3, 0, array3.Length);
			array4 = new byte[fileStream2.Length - fileStream2.Position];
			fileStream2.Read(array4, 0, array4.Length);
		}
		Stream stream;
		Stream stream2;
		Stream stream3;
		if (4 == (410)1)
		{
			stream = new 537(new MemoryStream(array2));
			stream2 = new 537(new MemoryStream(array3));
			stream3 = new 537(new MemoryStream(array4));
		}
		else
		{
			stream = new 481(new MemoryStream(array2), (777)1, (724)9);
			stream2 = new 481(new MemoryStream(array3), (777)1, (724)9);
			stream3 = new 481(new MemoryStream(array4), (777)1, (724)9);
		}
		int num4 = 1048573;
		FileStream fileStream3 = new FileStream(1, FileMode.Open, FileAccess.Read, FileShare.Read);
		byte[] array5;
		try
		{
			array5 = new byte[(int)fileStream3.Length];
			for (int i = 0; i < array5.Length; i += num4)
			{
				fileStream3.Read(array5, i, Math.Min(num4, array5.Length - i));
				this.Method1459((long)i, 5);
			}
		}
		finally
		{
			((IDisposable)fileStream3).Dispose();
		}
		byte[] array6 = new byte[num3];
		long num5 = (long)array5.Length;
		int num6 = 0;
		int num7 = 0;
		int[] array7 = new int[3];
		byte[] array8 = new byte[8];
		while ((long)num6 < num3)
		{
			int num8;
			for (int j = 0; j <= 2; j++)
			{
				num8 = stream.Read(array8, 0, 8);
				if (num8 < 8)
				{
					throw new Exception("invalid patch file (corrupt)");
				}
				array7[j] = 355.Method1457(array8, 0);
			}
			if ((long)(num6 + array7[0]) > num3)
			{
				throw new Exception("invalid patch file (corrupt)");
			}
			num8 = 0;
			for (int k = num6; k < num6 + array7[0]; k += 65536)
			{
				num8 += stream2.Read(array6, k, Math.Min(65536, num6 + array7[0] - k));
				this.Method1459(num3 + (long)num6 + (long)num8, 5);
			}
			if (num8 < array7[0])
			{
				throw new Exception("invalid patch file (corrupt)");
			}
			for (int l = 0; l < array7[0]; l++)
			{
				if (num7 + l >= 0 && (long)(num7 + l) < num5)
				{
					byte[] array9 = array6;
					int num9 = num6 + l;
					array9[num9] += array5[num7 + l];
				}
			}
			num6 += array7[0];
			num7 += array7[0];
			if ((long)num6 > num3)
			{
				throw new Exception("invalid patch file (corrupt)");
			}
			num8 = stream3.Read(array6, num6, array7[1]);
			if (num8 < array7[1])
			{
				throw new Exception("invalid patch file (corrupt)");
			}
			num6 += array7[1];
			num7 += array7[2];
		}
		stream.Close();
		stream2.Close();
		stream3.Close();
		using (FileStream fileStream4 = File.Create(2))
		{
			for (int m = 0; m < array6.Length; m += num4)
			{
				fileStream4.Write(array6, m, Math.Min(num4, array6.Length - m));
				this.Method1459(num3 * 2L + (long)m, 5);
			}
		}
		if (this._recoveredType24360895 != null)
		{
			this._recoveredType24360895(this, 1L, 1L);
		}
	}

	// Token: 0x06001952 RID: 6482 RVA: 0x0005BAE4 File Offset: 0x00059CE4
	private void Method1459(long 1, long 2)
	{
		int num = this.number3;
		this.number3 = (int)((float)1 / (float)2 * 100f);
		if (num != this.number3 && this._recoveredType24360895 != null)
		{
			this._recoveredType24360895(this, 1, 2);
		}
	}

	// Token: 0x06001953 RID: 6483 RVA: 0x0005BB1C File Offset: 0x00059D1C
	private static bool Method1460(byte[] 1, string 2, int 3, int 4)
	{
		for (int i = 3; i < 3 + 4; i++)
		{
			if ((char)1[i] != 2[i])
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x04000BC0 RID: 3008
	private 798 _recoveredType24360895;

	// Token: 0x04000BC1 RID: 3009
	private int number3;
}
