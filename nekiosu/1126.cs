using System;
using System.Runtime.InteropServices;
using System.Threading;

// Token: 0x02000BF0 RID: 3056
[ComVisible(false)]
public sealed class 1126 : IDisposable
{
	// Token: 0x0600536D RID: 21357 RVA: 0x0020AFA0 File Offset: 0x002091A0
	public 1126(Guid 1, int 2 = 5000)
	{
		this.3 = 1;
		for (;;)
		{
			this.1 = new Mutex(true, 1.ToString(), ref this.2);
			if (2 >= 0)
			{
				try
				{
					if (!this.1.WaitOne(2, false))
					{
						throw new 1155();
					}
				}
				catch (AbandonedMutexException)
				{
					continue;
				}
				break;
			}
			break;
		}
	}

	// Token: 0x0600536E RID: 21358 RVA: 0x0020B008 File Offset: 0x00209208
	public bool 1()
	{
		return this.2;
	}

	// Token: 0x0600536F RID: 21359 RVA: 0x0020B010 File Offset: 0x00209210
	protected void 2(bool 1)
	{
		if (this.4)
		{
			return;
		}
		if (this.1 != null)
		{
			try
			{
				this.1.Close();
			}
			catch
			{
			}
			this.1 = null;
		}
		this.4 = true;
	}

	// Token: 0x06005370 RID: 21360 RVA: 0x0020B05C File Offset: 0x0020925C
	~1126()
	{
		this.2(false);
	}

	// Token: 0x06005371 RID: 21361 RVA: 0x0020B08C File Offset: 0x0020928C
	public void Dispose()
	{
		this.2(true);
		GC.SuppressFinalize(this);
	}

	// Token: 0x04003F67 RID: 16231
	private Mutex 1;

	// Token: 0x04003F68 RID: 16232
	private bool 2;

	// Token: 0x04003F69 RID: 16233
	private Guid 3;

	// Token: 0x04003F6A RID: 16234
	private bool 4;
}
