using System;
using System.Collections.Generic;
using OpenTK.Graphics.ES20;

// Token: 0x02000ADD RID: 2781
public abstract class 1454 : IDisposable
{
	// Token: 0x06004D79 RID: 19833 RVA: 0x001EB304 File Offset: 0x001E9504
	~1454()
	{
		this.DisposeCore(false);
	}

	// Token: 0x06004D7A RID: 19834 RVA: 0x001EB334 File Offset: 0x001E9534
	protected virtual void DisposeCore(bool 1)
	{
		this.3 = true;
	}

	// Token: 0x06004D7B RID: 19835 RVA: 0x001EB33D File Offset: 0x001E953D
	public void Dispose()
	{
		if (!this.3)
		{
			GC.SuppressFinalize(this);
			this.DisposeCore(true);
		}
	}

	// Token: 0x06004D7C RID: 19836
	public abstract bool HasContent();

	// Token: 0x06004D7D RID: 19837
	public abstract int GetTextureId();

	// Token: 0x06004D7E RID: 19838
	public abstract int GetHeight_10756();

	// Token: 0x06004D7F RID: 19839
	public abstract void SetHeight_10757(int 1);

	// Token: 0x06004D80 RID: 19840
	public abstract int GetWidth_10758();

	// Token: 0x06004D81 RID: 19841
	public abstract void SetWidth_10759(int 1);

	// Token: 0x06004D82 RID: 19842
	public abstract void Draw(208 1, 208 2, 198 3, 208 4, float 5, 207? 6, 1508<1394> 7);

	// Token: 0x06004D83 RID: 19843
	public abstract bool TryBind();

	// Token: 0x06004D84 RID: 19844
	public abstract bool FlushPendingUpload();

	// Token: 0x06004D85 RID: 19845
	public abstract void UploadPixels(byte[] 1, int 2, PixelFormat 3);

	// Token: 0x06004D86 RID: 19846 RVA: 0x001EB354 File Offset: 0x001E9554
	internal static int 1(int 1)
	{
		if (1379.17.Major >= 2)
		{
			return 1;
		}
		int num = 1;
		while (num < 1 && num * 2 <= 1379.16)
		{
			num *= 2;
		}
		return num;
	}

	// Token: 0x06004D87 RID: 19847 RVA: 0x001EB388 File Offset: 0x001E9588
	internal void 2()
	{
		if (this.3)
		{
			return;
		}
		Queue<1454> obj = 1454.4;
		lock (obj)
		{
			1454.4.Enqueue(this);
		}
	}

	// Token: 0x06004D88 RID: 19848 RVA: 0x001EB3D8 File Offset: 0x001E95D8
	internal static void 3()
	{
		Queue<1454> obj = 1454.4;
		lock (obj)
		{
			while (1454.4.Count > 0 && !1454.4.Dequeue().FlushPendingUpload())
			{
			}
		}
	}

	// Token: 0x06004D89 RID: 19849 RVA: 0x001EB430 File Offset: 0x001E9630
	private static byte[] 4(int 1)
	{
		byte[] array = null;
		if (1454.5.Count > 0)
		{
			array = 1454.5.Pop();
		}
		if (array == null || array.Length < 1)
		{
			array = new byte[1];
		}
		if (1454.6.Count < 10)
		{
			1454.6.Add(array);
		}
		return array;
	}

	// Token: 0x06004D8A RID: 19850 RVA: 0x001EB482 File Offset: 0x001E9682
	private static void 5(byte[] 1)
	{
		if (1454.6.Remove(1))
		{
			1454.5.Push(1);
		}
	}

	// Token: 0x06004D8B RID: 19851 RVA: 0x001EB49C File Offset: 0x001E969C
	internal static byte[] 6(int 1)
	{
		Stack<byte[]> obj = 1454.5;
		byte[] result;
		lock (obj)
		{
			result = 1454.4(1);
		}
		return result;
	}

	// Token: 0x06004D8C RID: 19852 RVA: 0x001EB4E0 File Offset: 0x001E96E0
	internal static void 7(byte[] 1)
	{
		Stack<byte[]> obj = 1454.5;
		lock (obj)
		{
			1454.5(1);
		}
	}

	// Token: 0x040039BE RID: 14782
	public bool 1;

	// Token: 0x040039BF RID: 14783
	public TextureWrapMode 2 = 33071;

	// Token: 0x040039C0 RID: 14784
	protected bool 3;

	// Token: 0x040039C1 RID: 14785
	private static Queue<1454> 4 = new Queue<1454>();

	// Token: 0x040039C2 RID: 14786
	private static Stack<byte[]> 5 = new Stack<byte[]>();

	// Token: 0x040039C3 RID: 14787
	private static HashSet<byte[]> 6 = new HashSet<byte[]>();
}
