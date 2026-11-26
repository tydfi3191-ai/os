using System;

// Token: 0x02000415 RID: 1045
public class 1350 : IDisposable
{
	// Token: 0x060020A1 RID: 8353 RVA: 0x0008A853 File Offset: 0x00088A53
	public 1350(1803 1)
	{
		this.1 = 1;
	}

	// Token: 0x060020A2 RID: 8354 RVA: 0x0008A862 File Offset: 0x00088A62
	public void Dispose()
	{
		this.Dispose(true);
		GC.SuppressFinalize(this);
	}

	// Token: 0x060020A3 RID: 8355 RVA: 0x00005ADD File Offset: 0x00003CDD
	public virtual void Initialize()
	{
	}

	// Token: 0x060020A4 RID: 8356 RVA: 0x00005ADD File Offset: 0x00003CDD
	public virtual void Update()
	{
	}

	// Token: 0x060020A5 RID: 8357 RVA: 0x0008A871 File Offset: 0x00088A71
	protected virtual void Dispose(bool 1)
	{
		if (1)
		{
			EventHandler eventHandler = this.2;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler(this, EventArgs.Empty);
		}
	}

	// Token: 0x060020A6 RID: 8358 RVA: 0x0008A88C File Offset: 0x00088A8C
	~1350()
	{
		this.Dispose(false);
	}

	// Token: 0x0400112E RID: 4398
	private readonly 1803 1;

	// Token: 0x0400112F RID: 4399
	private EventHandler 2;
}
