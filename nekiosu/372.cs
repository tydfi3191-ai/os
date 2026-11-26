using System;
using System.Runtime.InteropServices;

// Token: 0x0200008D RID: 141
public sealed class 372 : IDisposable
{
	// Token: 0x060002EB RID: 747 RVA: 0x000093EE File Offset: 0x000075EE
	internal 372(IntPtr 1, 484 2)
	{
		this._recoveredType08491322 = 2;
		this.intPtr2 = 1;
	}

	// Token: 0x060002EC RID: 748 RVA: 0x00009404 File Offset: 0x00007604
	~372()
	{
		this.Method1930(false);
	}

	// Token: 0x060002ED RID: 749 RVA: 0x00009434 File Offset: 0x00007634
	private void Method1930(bool 1)
	{
		if (this.intPtr2 != IntPtr.Zero)
		{
			if (this._recoveredType08491322 == (484)0)
			{
				Marshal.FreeHGlobal(this.intPtr2);
			}
			else if (this._recoveredType08491322 == (484)1)
			{
				Marshal.FreeCoTaskMem(this.intPtr2);
			}
			this.intPtr2 = IntPtr.Zero;
		}
		if (1)
		{
			GC.SuppressFinalize(this);
		}
	}

	// Token: 0x060002EE RID: 750 RVA: 0x00009490 File Offset: 0x00007690
	public void Dispose()
	{
		this.Method1930(true);
	}

	// Token: 0x060002EF RID: 751 RVA: 0x00009499 File Offset: 0x00007699
	public static implicit operator IntPtr(372 1)
	{
		return 1.intPtr2;
	}

	// Token: 0x04000345 RID: 837
	private IntPtr intPtr2;

	// Token: 0x04000346 RID: 838
	private 484 _recoveredType08491322;
}
