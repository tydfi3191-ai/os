using System;

// Token: 0x02000C35 RID: 3125
public abstract class 1083
{
	// Token: 0x06005458 RID: 21592
	internal abstract bool Initialize();

	// Token: 0x06005459 RID: 21593
	internal abstract void Dispose();

	// Token: 0x0600545A RID: 21594 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal virtual void OnWindowSizeChanged()
	{
	}

	// Token: 0x0600545B RID: 21595
	internal abstract void Update(bool 1);

	// Token: 0x0600545C RID: 21596
	internal abstract bool IsActive();

	// Token: 0x0600545D RID: 21597
	internal abstract int GetPriority();
}
