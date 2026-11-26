using System;
using System.Runtime.InteropServices;
using System.Threading;

// Token: 0x02000BE1 RID: 3041
[ComVisible(false)]
public sealed class 1186
{
	// Token: 0x06005316 RID: 21270 RVA: 0x0020A140 File Offset: 0x00208340
	public 1186()
	{
		this.1 = new AutoResetEvent(false);
		this.2 = new AutoResetEvent(false);
	}

	// Token: 0x06005317 RID: 21271 RVA: 0x0020A16B File Offset: 0x0020836B
	internal bool 1()
	{
		return this.5;
	}

	// Token: 0x06005318 RID: 21272 RVA: 0x0020A174 File Offset: 0x00208374
	public void Invoke(1189 1)
	{
		object obj = this.3;
		lock (obj)
		{
			if (this.4 != null)
			{
				throw new Exception();
			}
			this.4 = 1;
			this.1.Set();
			this.2.WaitOne();
		}
	}

	// Token: 0x04003F37 RID: 16183
	private AutoResetEvent 1;

	// Token: 0x04003F38 RID: 16184
	private AutoResetEvent 2;

	// Token: 0x04003F39 RID: 16185
	private object 3 = new object();

	// Token: 0x04003F3A RID: 16186
	private 1189 4;

	// Token: 0x04003F3B RID: 16187
	private bool 5;
}
