using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using OpenTK.Graphics.ES20;
using osu_gameplay;
using osu_ui;

// Token: 0x02000A90 RID: 2704
public sealed class 1381 : IDisposable
{
	// Token: 0x1700030E RID: 782
	// (get) Token: 0x06004AF3 RID: 19187 RVA: 0x001DB6B8 File Offset: 0x001D98B8
	// (set) Token: 0x06004AF4 RID: 19188 RVA: 0x001DB6EC File Offset: 0x001D98EC
	internal 1454 gpuTexture
	{
		get
		{
			1381 <<EMPTY_NAME>> = this.9;
			if (<<EMPTY_NAME>> == null || <<EMPTY_NAME>>.5 || <<EMPTY_NAME>>.7 == null)
			{
				return this.7;
			}
			return <<EMPTY_NAME>>.7;
		}
		set
		{
			this.7 = value;
		}
	}

	// Token: 0x1700030F RID: 783
	// (get) Token: 0x06004AF5 RID: 19189 RVA: 0x001DB6F8 File Offset: 0x001D98F8
	// (set) Token: 0x06004AF6 RID: 19190 RVA: 0x001DB72C File Offset: 0x001D992C
	public int resolutionScale
	{
		get
		{
			1381 <<EMPTY_NAME>> = this.9;
			if (<<EMPTY_NAME>> == null || <<EMPTY_NAME>>.5 || <<EMPTY_NAME>>.7 == null)
			{
				return this.8;
			}
			return <<EMPTY_NAME>>.8;
		}
		set
		{
			this.8 = value;
		}
	}

	// Token: 0x06004AF7 RID: 19191 RVA: 0x001DB735 File Offset: 0x001D9935
	public 1381(1454 1, 1453 2 = null)
	{
		this.gpuTexture = 1;
		this.3 = 2;
	}

	// Token: 0x06004AF8 RID: 19192 RVA: 0x001DB759 File Offset: 0x001D9959
	public 1381(int 1, int 2) : this(new 1402(1, 2), null)
	{
	}

	// Token: 0x06004AF9 RID: 19193 RVA: 0x001DB769 File Offset: 0x001D9969
	internal int 1()
	{
		1454 gpuTexture = this.gpuTexture;
		if (gpuTexture == null)
		{
			return 0;
		}
		return gpuTexture.GetWidth_10758();
	}

	// Token: 0x06004AFA RID: 19194 RVA: 0x001DB77C File Offset: 0x001D997C
	internal int 2()
	{
		1454 gpuTexture = this.gpuTexture;
		if (gpuTexture == null)
		{
			return 0;
		}
		return gpuTexture.GetHeight_10756();
	}

	// Token: 0x06004AFB RID: 19195 RVA: 0x001DB78F File Offset: 0x001D998F
	public int 3()
	{
		return this.1() / this.resolutionScale;
	}

	// Token: 0x06004AFC RID: 19196 RVA: 0x001DB79E File Offset: 0x001D999E
	public int 4()
	{
		return this.2() / this.resolutionScale;
	}

	// Token: 0x06004AFD RID: 19197 RVA: 0x001DB7B0 File Offset: 0x001D99B0
	~1381()
	{
		if (1662.78 != 1677.Exit && 1662.78 != 1677.Update)
		{
			this.7(false);
		}
	}

	// Token: 0x06004AFE RID: 19198 RVA: 0x001DB7F0 File Offset: 0x001D99F0
	public bool 5()
	{
		if (this.10)
		{
			this.4 = 1662.33;
		}
		return this.5;
	}

	// Token: 0x06004AFF RID: 19199 RVA: 0x001DB80B File Offset: 0x001D9A0B
	public void 6(bool 1)
	{
		this.5 = 1;
	}

	// Token: 0x06004B00 RID: 19200 RVA: 0x001DB814 File Offset: 0x001D9A14
	public void Dispose()
	{
		this.7(true);
		GC.SuppressFinalize(this);
	}

	// Token: 0x06004B01 RID: 19201 RVA: 0x001DB823 File Offset: 0x001D9A23
	private void 7(bool 1)
	{
		if (!this.5)
		{
			this.5 = true;
			this.9 = null;
			if (this.7 != null)
			{
				this.7.Dispose();
				this.7 = null;
			}
		}
	}

	// Token: 0x06004B02 RID: 19202 RVA: 0x001DB858 File Offset: 0x001D9A58
	private unsafe static bool 8(byte[] 1, int 2)
	{
		bool flag = true;
		fixed (byte* ptr = &1[0])
		{
			byte* ptr3;
			byte* ptr2 = (ptr3 = ptr) + 2;
			if (1381.14)
			{
				while (ptr3 < ptr2)
				{
					byte b = *ptr3;
					byte b2 = ptr3[1];
					byte b3 = ptr3[2];
					byte b4 = (byte)(0.299 * (double)b3 + 0.587 * (double)b2 + 0.114 * (double)b);
					*(int*)ptr3 = ((int)b4 | (int)b4 << 8 | (int)b4 << 16 | (int)ptr3[3] << 24);
					flag &= (ptr3[3] == 0);
					ptr3 += 4;
				}
			}
			else
			{
				while (ptr3 < ptr2)
				{
					*(int*)ptr3 = ((int)ptr3[2] | (int)ptr3[1] << 8 | (int)(*ptr3) << 16 | (int)ptr3[3] << 24);
					flag &= (ptr3[3] == 0);
					ptr3 += 4;
				}
			}
		}
		return flag;
	}

	// Token: 0x06004B03 RID: 19203 RVA: 0x001DB91A File Offset: 0x001D9B1A
	public void 9(byte[] 1, int 2, PixelFormat 3)
	{
		if (this.gpuTexture != null)
		{
			if (3 != null)
			{
				this.gpuTexture.UploadPixels(1, 2, 3);
				return;
			}
			this.gpuTexture.UploadPixels(1, 2, 6408);
		}
	}

	// Token: 0x06004B04 RID: 19204 RVA: 0x001DB948 File Offset: 0x001D9B48
	public unsafe void 10(Bitmap 1)
	{
		if (this.gpuTexture != null)
		{
			int num = Math.Min(1.Width, this.1());
			int num2 = Math.Min(1.Height, this.2());
			BitmapData bitmapData = 1.LockBits(new Rectangle(0, 0, num, num2), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
			byte[] destination = 1454.6(num * num2 * 4);
			int num3 = 4;
			byte* ptr = (byte*)((void*)bitmapData.Scan0);
			for (int i = 0; i < num2; i++)
			{
				Marshal.Copy(new IntPtr((void*)(ptr + i * bitmapData.Stride)), destination, num * num3 * i, num * num3);
			}
			1.UnlockBits(bitmapData);
			bool flag = 1381.8(destination, num * num2 * 4);
			this.gpuTexture.1 = flag;
			if (!flag)
			{
				this.9(destination, 0, 0);
				return;
			}
			1454.7(destination);
		}
	}

	// Token: 0x06004B05 RID: 19205 RVA: 0x001DBA1C File Offset: 0x001D9C1C
	public static 1381 11(string 1, 1453 2)
	{
		bool flag = 1662.54();
		if (flag)
		{
			1 += "@2x";
		}
		using (Bitmap bitmap = osu_gameplay.ResourcesStore.ResourceManager.GetObject(1) as Bitmap)
		{
			if (bitmap != null)
			{
				1381 3 = 1381.15(bitmap, 2);
				if (flag)
				{
					3.resolutionScale = 2;
				}
				return 3;
			}
		}
		using (Bitmap bitmap2 = osu_ui.ResourcesStore.ResourceManager.GetObject(1) as Bitmap)
		{
			if (bitmap2 != null)
			{
				1381 4 = 1381.15(bitmap2, 2);
				if (flag)
				{
					4.resolutionScale = 2;
				}
				return 4;
			}
		}
		using (Bitmap bitmap3 = 1390.1(1))
		{
			if (bitmap3 != null)
			{
				1381 5 = 1381.15(bitmap3, 2);
				if (flag)
				{
					5.resolutionScale = 2;
				}
				return 5;
			}
		}
		return null;
	}

	// Token: 0x06004B06 RID: 19206 RVA: 0x001DBB18 File Offset: 0x001D9D18
	public static 1381 12(string 1, 1453 2)
	{
		if (!1662.112)
		{
			throw new Exception("Missing required DLLs!");
		}
		1381 3 = 1381.11(1, 2);
		if (3 != null)
		{
			3.1 = 1;
		}
		return 3;
	}

	// Token: 0x06004B07 RID: 19207 RVA: 0x001DBB4C File Offset: 0x001D9D4C
	public static 1381 13(string 1, 1453 2)
	{
		if (!File.Exists(1))
		{
			return null;
		}
		1381 result;
		try
		{
			Stream stream = new FileStream(1, FileMode.Open, FileAccess.Read, FileShare.Read);
			try
			{
				1381 3 = 1381.14(stream, 2);
				if (3 != null)
				{
					3.1 = 1;
					if (1.Contains("@2x"))
					{
						3.resolutionScale = 2;
					}
				}
				result = 3;
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

	// Token: 0x06004B08 RID: 19208 RVA: 0x001DBBC4 File Offset: 0x001D9DC4
	public static 1381 14(Stream 1, 1453 2)
	{
		if (1 == null || 1.Length == 0L)
		{
			return null;
		}
		1381 result;
		try
		{
			using (Bitmap bitmap = (Bitmap)Image.FromStream(1, false, false))
			{
				result = 1381.15(bitmap, 2);
			}
		}
		catch (ArgumentException)
		{
			result = null;
		}
		return result;
	}

	// Token: 0x06004B09 RID: 19209 RVA: 0x001DBC24 File Offset: 0x001D9E24
	public static 1381 15(Bitmap 1, 1453 2)
	{
		if (1 == null)
		{
			return null;
		}
		int num = Math.Min(1379.16, 1.Width);
		int num2 = Math.Min(1379.16, 1.Height);
		1381 3 = (2 == null) ? new 1381(num, num2) : 2.2(num, num2);
		3.10(1);
		return 3;
	}

	// Token: 0x06004B0A RID: 19210 RVA: 0x001DBC74 File Offset: 0x001D9E74
	public static 1381 16(byte[] 1)
	{
		MemoryStream memoryStream = new MemoryStream(1);
		1381 result;
		try
		{
			result = 1381.14(memoryStream, null);
		}
		finally
		{
			((IDisposable)memoryStream).Dispose();
		}
		return result;
	}

	// Token: 0x06004B0B RID: 19211 RVA: 0x001DBCAC File Offset: 0x001D9EAC
	public static 1381 17(byte[] 1, int 2, int 3)
	{
		1381 4 = new 1381(2, 3);
		4.9(1, 0, 0);
		return 4;
	}

	// Token: 0x06004B0C RID: 19212 RVA: 0x001DBCC0 File Offset: 0x001D9EC0
	public void 18()
	{
		List<1454> obj = 1381.12;
		lock (obj)
		{
			1381.12.Add(this.gpuTexture);
			if (!1381.13)
			{
				1662.91.Schedule(new 1189(1381.1382.Instance.1), true);
				1381.13 = true;
			}
		}
	}

	// Token: 0x040037F0 RID: 14320
	public string 1;

	// Token: 0x040037F1 RID: 14321
	public string 2;

	// Token: 0x040037F2 RID: 14322
	public 1453 3;

	// Token: 0x040037F3 RID: 14323
	internal int 4;

	// Token: 0x040037F4 RID: 14324
	private bool 5;

	// Token: 0x040037F5 RID: 14325
	public 1416 6;

	// Token: 0x040037F6 RID: 14326
	internal 1454 7;

	// Token: 0x040037F7 RID: 14327
	private int 8 = 1;

	// Token: 0x040037F8 RID: 14328
	internal 1381 9;

	// Token: 0x040037F9 RID: 14329
	internal bool 10;

	// Token: 0x040037FA RID: 14330
	public bool 11 = true;

	// Token: 0x040037FB RID: 14331
	private static List<1454> 12 = new List<1454>();

	// Token: 0x040037FC RID: 14332
	private static bool 13;

	// Token: 0x040037FD RID: 14333
	public static bool 14;

	// Token: 0x02000A91 RID: 2705
	[Serializable]
	public sealed class 1382
	{
		// Token: 0x06004B0E RID: 19214 RVA: 0x001DBD40 File Offset: 0x001D9F40
		internal void 1()
		{
			List<1454> <<EMPTY_NAME>> = 1381.12;
			lock (<<EMPTY_NAME>>)
			{
				long num = Stopwatch.GetTimestamp() + Stopwatch.Frequency * 4L / 1000L;
				int i = 0;
				try
				{
					while (i < 1381.12.Count)
					{
						1381.12[i++].FlushPendingUpload();
						if (Stopwatch.GetTimestamp() >= num)
						{
							break;
						}
					}
				}
				finally
				{
					1381.12.RemoveRange(0, i);
					1381.13 = (1381.12.Count > 0);
					if (1381.13)
					{
						1662.91.Schedule(new 1189(this.1), true);
					}
				}
			}
		}

		// Token: 0x040037FE RID: 14334
		public static readonly 1381.1382 Instance = new 1381.1382();

		// Token: 0x040037FF RID: 14335
		public static 1189 voidDelegate;
	}
}
