using System;

// Token: 0x020002A8 RID: 680
public abstract class 331 : IDisposable
{
	// Token: 0x06001490 RID: 5264
	public abstract bool GetFlag0541_880();

	// Token: 0x06001491 RID: 5265
	public abstract bool GetFlag0540_882();

	// Token: 0x06001492 RID: 5266
	public abstract bool GetFlag0541_881();

	// Token: 0x06001493 RID: 5267
	public abstract long Method0892();

	// Token: 0x06001494 RID: 5268
	public abstract long Method0893();

	// Token: 0x06001495 RID: 5269
	public abstract void Method0894(long 1);

	// Token: 0x06001496 RID: 5270 RVA: 0x00047807 File Offset: 0x00045A07
	public virtual void Method0855()
	{
		this.Method0883(true);
		GC.SuppressFinalize(this);
	}

	// Token: 0x06001497 RID: 5271 RVA: 0x00047816 File Offset: 0x00045A16
	public void Dispose()
	{
		this.Method0855();
	}

	// Token: 0x06001498 RID: 5272 RVA: 0x00005ADD File Offset: 0x00003CDD
	protected virtual void Method0883(bool 1)
	{
	}

	// Token: 0x06001499 RID: 5273
	public abstract void Method0885();

	// Token: 0x0600149A RID: 5274
	public abstract long Method0897(long 1, int 2);

	// Token: 0x0600149B RID: 5275
	public abstract void Method0898(long 1);

	// Token: 0x0600149C RID: 5276
	public abstract int Method0895(byte[] 1, int 2, int 3);

	// Token: 0x0600149D RID: 5277 RVA: 0x00047820 File Offset: 0x00045A20
	public virtual int Method0896()
	{
		byte[] array = new byte[1];
		if (this.Method0895(array, 0, 1) == 0)
		{
			return -1;
		}
		return (int)array[0];
	}

	// Token: 0x0600149E RID: 5278
	public abstract void Method0900(byte[] 1, int 2, int 3);

	// Token: 0x0600149F RID: 5279 RVA: 0x00047844 File Offset: 0x00045A44
	public virtual void Method0901(byte 1)
	{
		this.Method0900(new byte[]
		{
			1
		}, 0, 1);
	}
}
