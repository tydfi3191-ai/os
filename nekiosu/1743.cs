using System;

// Token: 0x020008DD RID: 2269
internal sealed class 1743
{
	// Token: 0x060040D1 RID: 16593 RVA: 0x001923CC File Offset: 0x001905CC
	private 1743(1452[] 1, 1436 2)
	{
		this.2 = 1;
		this.3 = new 1452[1.Length];
		for (int i = 0; i < 1.Length; i++)
		{
			1452 3 = 1[i];
			1452 4 = new 1452(3.GetText(), 3.65(), 3.17, 208.Zero, 0.93f, true, 3.6, false);
			4.54(3.53());
			4.62(3.61());
			this.3[i] = 4;
			2.12(4);
		}
	}

	// Token: 0x060040D2 RID: 16594 RVA: 0x00192458 File Offset: 0x00190658
	internal static 1743 Create(1436 1)
	{
		2601 2 = 1662.79 as 2601;
		if (2 == null)
		{
			return null;
		}
		return new 1743(2.41(), 1);
	}

	// Token: 0x060040D3 RID: 16595 RVA: 0x00192484 File Offset: 0x00190684
	internal void 1()
	{
		for (int i = 0; i < this.3.Length; i++)
		{
			this.3[i].SetText(this.2[i].GetText());
			this.3[i].62(this.2[i].61());
			this.3[i].17.Y = this.2[i].17.Y;
		}
	}

	// Token: 0x04002F63 RID: 12131
	internal const float 1 = 30f;

	// Token: 0x04002F64 RID: 12132
	private readonly 1452[] 2;

	// Token: 0x04002F65 RID: 12133
	private readonly 1452[] 3;
}
