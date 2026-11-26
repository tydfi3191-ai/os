using System;
using OpenTK.Graphics.ES20;

// Token: 0x02000B20 RID: 2848
public sealed class 1392<TItem> : 1509<TItem> where TItem : struct, IEquatable<!0>
{
	// Token: 0x06004F01 RID: 20225 RVA: 0x001F3579 File Offset: 0x001F1779
	public 1392(int 1, BeginMode 2, BufferUsageHint 3) : base(1, 3)
	{
		this.8 = 2;
		1393.1(1);
	}

	// Token: 0x06004F02 RID: 20226 RVA: 0x001F3590 File Offset: 0x001F1790
	public override void BindVertexBuffer(bool 1)
	{
		base.BindVertexBuffer(1);
		if (1)
		{
			1393.1(this.1.Length);
		}
	}

	// Token: 0x06004F03 RID: 20227 RVA: 0x001DFDBE File Offset: 0x001DDFBE
	public override void UnbindVertexBuffer()
	{
		base.UnbindVertexBuffer();
	}

	// Token: 0x06004F04 RID: 20228 RVA: 0x001F35A9 File Offset: 0x001F17A9
	protected override BeginMode GetBeginMode8401_10799()
	{
		return this.8;
	}

	// Token: 0x04003AFA RID: 15098
	private BeginMode 8;
}
