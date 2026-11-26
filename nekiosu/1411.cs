using System;
using OpenTK.Graphics.ES20;

// Token: 0x02000AAD RID: 2733
public sealed class 1411<TItem> : 1509<TItem> where TItem : struct, IEquatable<!0>
{
	// Token: 0x06004BD1 RID: 19409 RVA: 0x001DFD91 File Offset: 0x001DDF91
	public 1411(int 1, BufferUsageHint 2) : base(1 * 4, 2)
	{
		1410.1(1);
	}

	// Token: 0x06004BD2 RID: 19410 RVA: 0x001DFDA3 File Offset: 0x001DDFA3
	public override void BindVertexBuffer(bool 1)
	{
		base.BindVertexBuffer(1);
		if (1)
		{
			1410.1(this.1.Length / 4);
		}
	}

	// Token: 0x06004BD3 RID: 19411 RVA: 0x001DFDBE File Offset: 0x001DDFBE
	public override void UnbindVertexBuffer()
	{
		base.UnbindVertexBuffer();
	}

	// Token: 0x06004BD4 RID: 19412 RVA: 0x001DFDC6 File Offset: 0x001DDFC6
	protected override int GetIndexCount(int 1)
	{
		return 3 * 1 / 2;
	}

	// Token: 0x06004BD5 RID: 19413 RVA: 0x001DFDC6 File Offset: 0x001DDFC6
	protected override int GetIndexOffset(int 1)
	{
		return 3 * 1 / 2;
	}

	// Token: 0x06004BD6 RID: 19414 RVA: 0x0000D019 File Offset: 0x0000B219
	protected override BeginMode GetBeginMode8401_10799()
	{
		return 4;
	}
}
