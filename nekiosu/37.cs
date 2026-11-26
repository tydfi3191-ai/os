using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

// Token: 0x02000019 RID: 25
[ComVisible(false)]
public sealed class 37
{
	// Token: 0x0600008F RID: 143 RVA: 0x000047B8 File Offset: 0x000029B8
	public void AddProgressHandler(798 1)
	{
		798 2 = this.progressHandler;
		798 3;
		do
		{
			3 = 2;
			798 value = (798)Delegate.Combine(3, 1);
			2 = Interlocked.CompareExchange<798>(ref this.progressHandler, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x06000090 RID: 144 RVA: 0x000047F0 File Offset: 0x000029F0
	public void RemoveProgressHandler(798 1)
	{
		798 2 = this.progressHandler;
		798 3;
		do
		{
			3 = 2;
			798 value = (798)Delegate.Remove(3, 1);
			2 = Interlocked.CompareExchange<798>(ref this.progressHandler, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x06000091 RID: 145 RVA: 0x00004828 File Offset: 0x00002A28
	private void SplitSuffixGroups(int[] 1, int[] 2, int 3, int 4, int 5)
	{
		int i;
		int num;
		int num2;
		int j;
		if (4 < 16)
		{
			for (i = 3; i < 3 + 4; i += num)
			{
				num = 1;
				num2 = 2[1[i] + 5];
				j = 1;
				while (i + j < 3 + 4)
				{
					if (2[1[i + j] + 5] < num2)
					{
						num2 = 2[1[i + j] + 5];
						num = 0;
					}
					if (2[1[i + j] + 5] == num2)
					{
						int num3 = 1[i + num];
						1[i + num] = 1[i + j];
						1[i + j] = num3;
						num++;
					}
					j++;
				}
				for (j = 0; j < num; j++)
				{
					2[1[i + j]] = i + num - 1;
				}
				if (num == 1)
				{
					1[i] = -1;
				}
			}
			return;
		}
		num2 = 2[1[3 + 4 / 2] + 5];
		int num4 = 0;
		int num5 = 0;
		for (j = 3; j < 3 + 4; j++)
		{
			if (2[1[j] + 5] < num2)
			{
				num4++;
			}
			if (2[1[j] + 5] == num2)
			{
				num5++;
			}
		}
		num4 += 3;
		num5 += num4;
		j = 3;
		num = 0;
		i = 0;
		while (j < num4)
		{
			if (2[1[j] + 5] < num2)
			{
				j++;
			}
			else if (2[1[j] + 5] == num2)
			{
				int num6 = 1[j];
				1[j] = 1[num4 + num];
				1[num4 + num] = num6;
				num++;
			}
			else
			{
				int num7 = 1[j];
				1[j] = 1[num5 + i];
				1[num5 + i] = num7;
				i++;
			}
		}
		while (num4 + num < num5)
		{
			if (2[1[num4 + num] + 5] == num2)
			{
				num++;
			}
			else
			{
				int num8 = 1[num4 + num];
				1[num4 + num] = 1[num5 + i];
				1[num5 + i] = num8;
				i++;
			}
		}
		if (num4 > 3)
		{
			this.SplitSuffixGroups(1, 2, 3, num4 - 3, 5);
		}
		for (j = 0; j < num5 - num4; j++)
		{
			2[1[num4 + j]] = num5 - 1;
		}
		if (num4 == num5 - 1)
		{
			1[num4] = -1;
		}
		if (3 + 4 > num5)
		{
			this.SplitSuffixGroups(1, 2, num5, 3 + 4 - num5, 5);
		}
	}

	// Token: 0x06000092 RID: 146 RVA: 0x00004A1C File Offset: 0x00002C1C
	private void BuildSuffixArray(int[] 1, int[] 2, byte[] 3, int 4)
	{
		int[] array = new int[256];
		for (int i = 0; i < 4; i++)
		{
			array[(int)3[i]]++;
		}
		for (int j = 1; j < 256; j++)
		{
			array[j] += array[j - 1];
		}
		for (int k = 255; k > 0; k--)
		{
			array[k] = array[k - 1];
		}
		array[0] = 0;
		for (int l = 0; l < 4; l++)
		{
			int[] array2 = array;
			byte b = 3[l];
			int num = array2[(int)b] + 1;
			array2[(int)b] = num;
			1[num] = l;
		}
		1[0] = 4;
		for (int m = 0; m < 4; m++)
		{
			2[m] = array[(int)3[m]];
		}
		2[4] = 0;
		for (int n = 1; n < 256; n++)
		{
			if (array[n] == array[n - 1] + 1)
			{
				1[array[n]] = -1;
			}
		}
		1[0] = -1;
		int num2 = 1;
		while (1[0] != -(4 + 1))
		{
			int num3 = 0;
			int num4 = 0;
			while (num4 < 4 + 1)
			{
				this.ReportProgress((long)num4, (long)4);
				if (1[num4] < 0)
				{
					num3 -= 1[num4];
					num4 -= 1[num4];
				}
				else
				{
					if (num3 != 0)
					{
						1[num4 - num3] = -num3;
					}
					num3 = 2[1[num4]] + 1 - num4;
					this.SplitSuffixGroups(1, 2, num4, num3, num2);
					num4 += num3;
					num3 = 0;
				}
			}
			if (num3 != 0)
			{
				1[num4 - num3] = -num3;
			}
			num2 += num2;
		}
		for (int num5 = 0; num5 < 4 + 1; num5++)
		{
			1[2[num5]] = num5;
		}
	}

	// Token: 0x06000093 RID: 147 RVA: 0x00004BB4 File Offset: 0x00002DB4
	private static int GetMatchLength(byte[] 1, int 2, int 3, byte[] 4, int 5, int 6)
	{
		int num = 0;
		while (num < 3 - 2 && num < 6 - 5 && 1[num + 2] == 4[num + 5])
		{
			num++;
		}
		return num;
	}

	// Token: 0x06000094 RID: 148 RVA: 0x00004BE8 File Offset: 0x00002DE8
	private int SearchSuffixArray(int[] 1, byte[] 2, int 3, byte[] 4, int 5, int 6, int 7, int 8, out int 9)
	{
		if (8 - 7 < 2)
		{
			int num = 37.GetMatchLength(2, 1[7], 3, 4, 5, 6);
			int matchLength = 37.GetMatchLength(2, 1[8], 3, 4, 5, 6);
			if (num > matchLength)
			{
				9 = 1[7];
				return num;
			}
			9 = 1[8];
			return matchLength;
		}
		else
		{
			int num = 7 + (8 - 7) / 2;
			if (37.Method11946(2, 1[num], 4, 5, Math.Min(3 - 1[num], 6 - 5)) < 0)
			{
				return this.SearchSuffixArray(1, 2, 3, 4, 5, 6, num, 8, out 9);
			}
			return this.SearchSuffixArray(1, 2, 3, 4, 5, 6, 7, num, out 9);
		}
	}

	// Token: 0x06000095 RID: 149 RVA: 0x00004C8C File Offset: 0x00002E8C
	private void EncodeOffset(int 1, byte[] 2)
	{
		int num = (1 >= 0) ? 1 : (-1);
		for (int i = 0; i < 7; i++)
		{
			2[i] = (byte)(num % 256);
			num -= (int)2[i];
			num /= 256;
		}
		2[7] = (byte)(num % 256);
		if (1 < 0)
		{
			int num2 = 7;
			2[num2] |= 128;
		}
	}

	// Token: 0x06000096 RID: 150 RVA: 0x00004CE8 File Offset: 0x00002EE8
	private unsafe static int Method11946(byte* 1, byte* 2, int 3)
	{
		int num = 0;
		int num2 = 0;
		while (num2 < 3 && num == 0)
		{
			num = (int)(1[num2] - 2[num2]);
			num2++;
		}
		return num;
	}

	// Token: 0x06000097 RID: 151 RVA: 0x00004D14 File Offset: 0x00002F14
	private static int Method11946(byte[] 1, int 2, byte[] 3, int 4, int 5)
	{
		int num = 0;
		int num2 = 0;
		while (num2 < 5 && num == 0)
		{
			num = (int)(1[num2 + 2] - 3[num2 + 4]);
			num2++;
		}
		return num;
	}

	// Token: 0x06000098 RID: 152 RVA: 0x00004D40 File Offset: 0x00002F40
	private Stream CreateCompressionStream(410 1, Stream 2)
	{
		Stream result;
		if (1 != (410)0)
		{
			if (1 == (410)1)
			{
				result = new 714(2);
			}
			else
			{
				result = null;
			}
		}
		else
		{
			result = new 481(2, (777)0, (724)9, true);
		}
		return result;
	}

	// Token: 0x06000099 RID: 153 RVA: 0x00004D6D File Offset: 0x00002F6D
	public void Method11949(string 1, string 2, Stream 3)
	{
		this.Method11949(1, 2, 3, (410)1);
	}

	// Token: 0x0600009A RID: 154 RVA: 0x00004D7C File Offset: 0x00002F7C
	public void Method11949(string 1, string 2, string 3)
	{
		using (FileStream fileStream = File.Open(3, FileMode.Create))
		{
			this.Method11949(1, 2, fileStream);
		}
	}

	// Token: 0x0600009B RID: 155 RVA: 0x00004DB8 File Offset: 0x00002FB8
	public void Method11949(string 1, string 2, Stream 3, 410 4)
	{
		int num = 0;
		int num2;
		byte[] array;
		int num3;
		using (FileStream fileStream = File.OpenRead(1))
		{
			num2 = (int)fileStream.Length;
			array = new byte[num2];
			num3 = num2 * 9;
			for (int i = 0; i < num2; i += 65536)
			{
				fileStream.Read(array, i, Math.Min(65536, num2 - i));
				this.ReportProgress((long)(num + i), (long)num3);
			}
			num = num2;
		}
		int[] 5 = new int[num2 + 1];
		int[] 6 = new int[num2 + 1];
		this.BuildSuffixArray(5, 6, array, num2);
		int num4;
		byte[] array2;
		using (FileStream fileStream2 = File.OpenRead(2))
		{
			num4 = (int)fileStream2.Length;
			array2 = new byte[num4];
			num3 += num4 * 7 - num2 * 7;
			for (int j = 0; j < num4; j += 65536)
			{
				fileStream2.Read(array2, j, Math.Min(65536, num4 - j));
				this.ReportProgress((long)(num + j), (long)num3);
			}
			num += num4;
		}
		byte[] array3 = new byte[num4 + 1];
		byte[] array4 = new byte[num4 + 1];
		int num5 = 0;
		int num6 = 0;
		BinaryWriter binaryWriter = new BinaryWriter(3);
		try
		{
			binaryWriter.Write(Encoding.ASCII.GetBytes("BSDIFF40"));
			binaryWriter.Write(0L);
			binaryWriter.Write(0L);
			binaryWriter.Write((long)num4);
			MemoryStream memoryStream = new MemoryStream();
			try
			{
				using (Stream stream = this.CreateCompressionStream(4, memoryStream))
				{
					int num7 = 0;
					int k = 0;
					int num8 = 0;
					int num9 = 0;
					int num10 = 0;
					int num11 = 0;
					while (k < num4)
					{
						int num12 = 0;
						int l;
						for (k = (l = k + num8); k < num4; k++)
						{
							num8 = this.SearchSuffixArray(5, array, num2, array2, k, num4, 0, num2, out num7);
							while (l < k + num8)
							{
								if (l + num11 < num2 && array[l + num11] == array2[l])
								{
									num12++;
								}
								l++;
							}
							if ((num8 == num12 && num8 != 0) || num8 > num12 + 8)
							{
								break;
							}
							if (k + num11 < num2 && array[k + num11] == array2[k])
							{
								num12--;
							}
						}
						if (num8 != num12 || k == num4)
						{
							int num13 = 0;
							int num14 = 0;
							int num15 = 0;
							int num16 = 0;
							int num17 = 0;
							int num18 = 0;
							int num19 = 0;
							int num20 = 0;
							while (num9 + num20 < k && num10 + num20 < num2)
							{
								if (array[num10 + num20] == array2[num9 + num20])
								{
									num13++;
								}
								num20++;
								if (num13 * 2 - num20 > num14 * 2 - num15)
								{
									num14 = num13;
									num15 = num20;
								}
							}
							if (k < num4)
							{
								num13 = 0;
								int num21 = 1;
								while (k >= num9 + num21 && num7 >= num21)
								{
									if (array[num7 - num21] == array2[k - num21])
									{
										num13++;
									}
									if (num13 * 2 - num21 > num16 * 2 - num17)
									{
										num16 = num13;
										num17 = num21;
									}
									num21++;
								}
							}
							if (num9 + num15 > k - num17)
							{
								int num22 = num9 + num15 - (k - num17);
								num13 = 0;
								for (int m = 0; m < num22; m++)
								{
									if (array2[num9 + num15 - num22 + m] == array[num10 + num15 - num22 + m])
									{
										num13++;
									}
									if (array2[k - num17 + m] == array[num7 - num17 + m])
									{
										num13--;
									}
									if (num13 > num18)
									{
										num18 = num13;
										num19 = m + 1;
									}
								}
								num15 += num19 - num22;
								num17 -= num19;
							}
							for (int n = 0; n < num15; n++)
							{
								array3[num5 + n] = array2[num9 + n] - array[num10 + n];
							}
							for (int num23 = 0; num23 < k - num17 - (num9 + num15); num23++)
							{
								array4[num6 + num23] = array2[num9 + num15 + num23];
							}
							num5 += num15;
							num6 += k - num17 - (num9 + num15);
							byte[] array5 = new byte[8];
							this.EncodeOffset(num15, array5);
							stream.Write(array5, 0, 8);
							this.EncodeOffset(k - num17 - (num9 + num15), array5);
							stream.Write(array5, 0, 8);
							this.EncodeOffset(num7 - num17 - (num10 + num15), array5);
							stream.Write(array5, 0, 8);
							num9 = k - num17;
							num10 = num7 - num17;
							num11 = num7 - k;
						}
						this.ReportProgress((long)(num + k), (long)num3);
					}
					num += num4;
				}
				byte[] array6 = memoryStream.ToArray();
				num3 += array6.Length - num4;
				for (int num24 = 0; num24 < array6.Length; num24 += 65536)
				{
					binaryWriter.Write(array6, num24, Math.Min(65536, array6.Length - num24));
					this.ReportProgress((long)(num + num24), (long)num3);
				}
				num += array6.Length;
			}
			finally
			{
				((IDisposable)memoryStream).Dispose();
			}
			binaryWriter.Flush();
			long num25 = binaryWriter.BaseStream.Position - 32L;
			MemoryStream memoryStream2 = new MemoryStream();
			try
			{
				using (Stream stream2 = this.CreateCompressionStream(4, memoryStream2))
				{
					num3 += num5 - num4;
					for (int num26 = 0; num26 < num5; num26 += 65536)
					{
						stream2.Write(array3, num26, Math.Min(65536, num5 - num26));
						this.ReportProgress((long)(num + num26), (long)num3);
					}
					num += num5;
				}
				byte[] array7 = memoryStream2.ToArray();
				num3 += array7.Length - num4;
				for (int num27 = 0; num27 < array7.Length; num27 += 65536)
				{
					binaryWriter.Write(array7, num27, Math.Min(65536, array7.Length - num27));
					this.ReportProgress((long)(num += num27), (long)num3);
				}
			}
			finally
			{
				((IDisposable)memoryStream2).Dispose();
			}
			binaryWriter.Flush();
			long value = binaryWriter.BaseStream.Position - num25 - 32L;
			MemoryStream memoryStream3 = new MemoryStream();
			try
			{
				using (Stream stream3 = this.CreateCompressionStream(4, memoryStream3))
				{
					num3 += num6 - num4;
					for (int num28 = 0; num28 < num6; num28 += 65536)
					{
						stream3.Write(array4, num28, Math.Min(65536, num6 - num28));
						this.ReportProgress((long)(num + num28), (long)num3);
					}
					num += num6;
				}
				byte[] array8 = memoryStream3.ToArray();
				num3 += array8.Length - num4;
				for (int num29 = 0; num29 < array8.Length; num29 += 65536)
				{
					binaryWriter.Write(array8, num29, Math.Min(65536, array8.Length - num29));
					this.ReportProgress((long)(num + num29), (long)num3);
				}
			}
			finally
			{
				((IDisposable)memoryStream3).Dispose();
			}
			binaryWriter.Flush();
			binaryWriter.Seek(8, SeekOrigin.Begin);
			binaryWriter.Write(num25);
			binaryWriter.Write(value);
			if (this.progressHandler != null)
			{
				this.progressHandler(this, 1L, 1L);
			}
		}
		finally
		{
			((IDisposable)binaryWriter).Dispose();
		}
	}

	// Token: 0x0600009C RID: 156 RVA: 0x00005574 File Offset: 0x00003774
	private void ReportProgress(long 1, long 2)
	{
		int num = this.lastPercent;
		this.lastPercent = (int)((float)1 / (float)2 * 100f);
		if (num != this.lastPercent && this.progressHandler != null)
		{
			this.progressHandler(this, 1, 2);
		}
	}

	// Token: 0x04000052 RID: 82
	private 798 progressHandler;

	// Token: 0x04000053 RID: 83
	private int lastPercent;
}
