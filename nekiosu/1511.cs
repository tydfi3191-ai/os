using System;
using System.IO;
using osu_ui;

// Token: 0x02000AE6 RID: 2790
public sealed class 1511 : IDisposable
{
	// Token: 0x06004DC2 RID: 19906 RVA: 0x001ECAAC File Offset: 0x001EACAC
	internal 1511(string 1, 1416 2, 1044 3)
	{
		this.13 = 3;
		1 = 2672.17(1);
		byte[] array = null;
		if ((2 & (1416)2) > (1416)0)
		{
			array = 1511.11(Path.Combine(2630.5.14(), (1.IndexOf('.') < 0) ? (1 + ".mp4") : 1));
		}
		if (array == null && (2 & (1416)1) > (1416)0)
		{
			array = (byte[])ResourcesStore.ResourceManager.GetObject(1);
		}
		if (array == null && (2 & (1416)4) > (1416)0)
		{
			array = 1272.5().49(1);
		}
		this.3 = new 90((3 == (1044)0) ? 4 : ((int)(1226.38() / 100.0 * 4.0)));
		if (this.3.Method9955(array))
		{
			this.5 = this.3.GetWidth();
			this.1 = this.3.GetHeight();
			this.4 = new 1381[3];
			this.3();
			this.2 = (int)this.3.GetDuration();
		}
	}

	// Token: 0x06004DC3 RID: 19907 RVA: 0x001ECBC1 File Offset: 0x001EADC1
	internal 1070 1()
	{
		return this.11;
	}

	// Token: 0x06004DC4 RID: 19908 RVA: 0x001ECBC9 File Offset: 0x001EADC9
	private void 2(1070 1)
	{
		this.11 = 1;
	}

	// Token: 0x06004DC5 RID: 19909 RVA: 0x001ECBD4 File Offset: 0x001EADD4
	private void 3()
	{
		byte[] array = new byte[this.5 * this.1 * 4];
		for (int i = 0; i < array.Length - 1; i++)
		{
			array[i] = ((i % 4 == 3) ? byte.MaxValue : 0);
		}
		for (int j = 0; j < 3; j++)
		{
			this.4[j] = new 1381(this.5, this.1);
			this.4[j].9(array, 0, 0);
		}
	}

	// Token: 0x06004DC6 RID: 19910 RVA: 0x001ECC4D File Offset: 0x001EAE4D
	internal double 4()
	{
		return this.3.GetCurrentFrameTime();
	}

	// Token: 0x06004DC7 RID: 19911 RVA: 0x001ECC5A File Offset: 0x001EAE5A
	internal 1381 5()
	{
		if (this.4 != null && this.4.Length != 0)
		{
			return this.4[this.6];
		}
		return null;
	}

	// Token: 0x06004DC8 RID: 19912 RVA: 0x001ECC7C File Offset: 0x001EAE7C
	internal int 6()
	{
		return this.5;
	}

	// Token: 0x06004DC9 RID: 19913 RVA: 0x001ECC84 File Offset: 0x001EAE84
	internal int 7()
	{
		return this.1;
	}

	// Token: 0x06004DCA RID: 19914 RVA: 0x001ECC8C File Offset: 0x001EAE8C
	~1511()
	{
		this.8(false);
	}

	// Token: 0x06004DCB RID: 19915 RVA: 0x001ECCBC File Offset: 0x001EAEBC
	public void Dispose()
	{
		GC.SuppressFinalize(this);
		this.8(true);
	}

	// Token: 0x06004DCC RID: 19916 RVA: 0x001ECCCC File Offset: 0x001EAECC
	public void 8(bool 1)
	{
		this.2((1070)2);
		if (this.3 != null)
		{
			this.3.Dispose();
		}
		if (this.4 != null)
		{
			foreach (1381 2 in this.4)
			{
				if (2 != null)
				{
					2.Dispose();
				}
			}
		}
	}

	// Token: 0x06004DCD RID: 19917 RVA: 0x001ECD20 File Offset: 0x001EAF20
	internal 1070 9()
	{
		byte[] frame = this.3.GetFrame(((this.13 == (1044)0) ? 1662.33 : 1226.17) - this.12);
		if (frame == null)
		{
			this.2((1070)0);
			return this.1();
		}
		double currentFrameTime = this.3.GetCurrentFrameTime();
		if (frame != this.8 || currentFrameTime != this.9)
		{
			this.8 = frame;
			this.9 = currentFrameTime;
			this.7++;
			this.6 = (this.6 + 1) % 3;
			this.4[this.6].9(frame, 0, 0);
		}
		this.2((1070)1);
		return this.1();
	}

	// Token: 0x06004DCE RID: 19918 RVA: 0x001ECDD1 File Offset: 0x001EAFD1
	public void 10(int 1, bool 2)
	{
		if (Math.Abs(1 - this.10) >= 2000 || 2)
		{
			this.10 = 1;
			this.3.SeekTo(1);
			this.8 = null;
		}
	}

	// Token: 0x06004DCF RID: 19919 RVA: 0x001ECE08 File Offset: 0x001EB008
	internal static byte[] 11(string 1)
	{
		if (!File.Exists(1))
		{
			return null;
		}
		byte[] result;
		try
		{
			Stream stream = new FileStream(1, FileMode.Open, FileAccess.Read, FileShare.Read);
			try
			{
				result = 1511.12(stream, 1);
			}
			finally
			{
				((IDisposable)stream).Dispose();
			}
		}
		catch
		{
			result = null;
		}
		return result;
	}

	// Token: 0x06004DD0 RID: 19920 RVA: 0x001ECE60 File Offset: 0x001EB060
	internal static byte[] 12(Stream 1, string 2)
	{
		if (1 == null || 1.Length == 0L)
		{
			return null;
		}
		byte[] result;
		try
		{
			byte[] array = new byte[1.Length];
			1.Read(array, 0, array.Length);
			result = array;
		}
		catch
		{
			result = null;
		}
		return result;
	}

	// Token: 0x04003A00 RID: 14848
	private readonly int 1;

	// Token: 0x04003A01 RID: 14849
	internal readonly int 2;

	// Token: 0x04003A02 RID: 14850
	private readonly 90 3;

	// Token: 0x04003A03 RID: 14851
	private readonly 1381[] 4;

	// Token: 0x04003A04 RID: 14852
	private readonly int 5;

	// Token: 0x04003A05 RID: 14853
	private int 6;

	// Token: 0x04003A06 RID: 14854
	private int 7;

	// Token: 0x04003A07 RID: 14855
	private byte[] 8;

	// Token: 0x04003A08 RID: 14856
	private double 9 = double.NaN;

	// Token: 0x04003A09 RID: 14857
	private int 10;

	// Token: 0x04003A0A RID: 14858
	private 1070 11;

	// Token: 0x04003A0B RID: 14859
	internal int 12;

	// Token: 0x04003A0C RID: 14860
	private 1044 13;
}
