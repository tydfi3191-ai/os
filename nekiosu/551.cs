using System;
using System.Runtime.InteropServices;

// Token: 0x02000014 RID: 20
[ComVisible(false)]
[StructLayout(LayoutKind.Sequential)]
public sealed class 551 : IDisposable
{
	// Token: 0x06000050 RID: 80 RVA: 0x00002FD0 File Offset: 0x000011D0
	public 551(int 1)
	{
		this.intPtr = IntPtr.Zero;
		this._recoveredType0341Array5575 = new 371[1];
		for (int i = 0; i < 1; i++)
		{
			this._recoveredType0341Array5575[i] = (371)(1 << i);
		}
	}

	// Token: 0x06000051 RID: 81 RVA: 0x00003014 File Offset: 0x00001214
	public 551(params 371[] 1)
	{
		this.intPtr = IntPtr.Zero;
		this._recoveredType0341Array5575 = new 371[1.Length];
		for (int i = 0; i < 1.Length; i++)
		{
			this._recoveredType0341Array5575[i] = 1[i];
		}
	}

	// Token: 0x06000052 RID: 82 RVA: 0x0000305C File Offset: 0x0000125C
	internal void Method7035()
	{
		if (this.gCHandle.IsAllocated)
		{
			this.gCHandle.Free();
			this.intPtr = IntPtr.Zero;
		}
		int[] array = new int[this._recoveredType0341Array5575.Length];
		for (int i = 0; i < this._recoveredType0341Array5575.Length; i++)
		{
			array[i] = (int)this._recoveredType0341Array5575[i];
		}
		this.gCHandle = GCHandle.Alloc(array, GCHandleType.Pinned);
		this.intPtr = this.gCHandle.AddrOfPinnedObject();
	}

	// Token: 0x06000053 RID: 83 RVA: 0x000030D8 File Offset: 0x000012D8
	internal void Method7036()
	{
		if (this.intPtr != IntPtr.Zero)
		{
			int[] array = new int[this._recoveredType0341Array5575.Length];
			Marshal.Copy(this.intPtr, array, 0, array.Length);
			for (int i = 0; i < array.Length; i++)
			{
				this._recoveredType0341Array5575[i] = (371)array[i];
			}
		}
	}

	// Token: 0x06000054 RID: 84 RVA: 0x0000312E File Offset: 0x0000132E
	public void Dispose()
	{
		if (this.gCHandle.IsAllocated)
		{
			this.gCHandle.Free();
			this.intPtr = IntPtr.Zero;
		}
	}

	// Token: 0x04000037 RID: 55
	private IntPtr intPtr;

	// Token: 0x04000038 RID: 56
	private GCHandle gCHandle;

	// Token: 0x04000039 RID: 57
	public 371[] _recoveredType0341Array5575;
}
