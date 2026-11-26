using System;

// Token: 0x0200054B RID: 1355
[276]
public abstract class 2535 : IDisposable
{
	// Token: 0x0600299F RID: 10655 RVA: 0x000D8628 File Offset: 0x000D6828
	public 2535(bool 1 = false)
	{
		this.1 = new 1436(1);
	}

	// Token: 0x060029A0 RID: 10656 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal virtual void Initialize()
	{
	}

	// Token: 0x060029A1 RID: 10657 RVA: 0x000D863C File Offset: 0x000D683C
	internal virtual void Draw()
	{
		this.1.22();
	}

	// Token: 0x060029A2 RID: 10658 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal virtual void Update()
	{
	}

	// Token: 0x060029A3 RID: 10659 RVA: 0x000D864A File Offset: 0x000D684A
	protected virtual void Dispose(bool 1)
	{
		if (!this.2)
		{
			this.1.Dispose();
			this.2 = true;
		}
	}

	// Token: 0x060029A4 RID: 10660 RVA: 0x000D8666 File Offset: 0x000D6866
	public void Dispose()
	{
		this.Dispose(true);
	}

	// Token: 0x04001E3D RID: 7741
	internal 1436 1;

	// Token: 0x04001E3E RID: 7742
	private bool 2;
}
