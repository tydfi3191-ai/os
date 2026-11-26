using System;
using OpenTK.Graphics.ES20;

// Token: 0x02000AAE RID: 2734
public sealed class 1412 : 1454
{
	// Token: 0x06004BD7 RID: 19415 RVA: 0x001DFDCD File Offset: 0x001DDFCD
	public 1412(207 1, 1402 2)
	{
		this.8 = 1;
		this.7 = 2;
	}

	// Token: 0x06004BD8 RID: 19416 RVA: 0x001DFDE3 File Offset: 0x001DDFE3
	public override int GetHeight_10756()
	{
		return this.8.Height;
	}

	// Token: 0x06004BD9 RID: 19417 RVA: 0x001DFDF0 File Offset: 0x001DDFF0
	public override void SetHeight_10757(int 1)
	{
		this.8.Height = 1;
	}

	// Token: 0x06004BDA RID: 19418 RVA: 0x001DFDFE File Offset: 0x001DDFFE
	public override int GetWidth_10758()
	{
		return this.8.Width;
	}

	// Token: 0x06004BDB RID: 19419 RVA: 0x001DFE0B File Offset: 0x001DE00B
	public override void SetWidth_10759(int 1)
	{
		this.8.Width = 1;
	}

	// Token: 0x06004BDC RID: 19420 RVA: 0x001DFE19 File Offset: 0x001DE019
	public override bool HasContent()
	{
		return this.7.HasContent() || this.11 != null;
	}

	// Token: 0x06004BDD RID: 19421 RVA: 0x001DFE33 File Offset: 0x001DE033
	public override int GetTextureId()
	{
		return this.7.GetTextureId();
	}

	// Token: 0x06004BDE RID: 19422 RVA: 0x001DFE40 File Offset: 0x001DE040
	public override void UploadPixels(byte[] 1, int 2 = 0, PixelFormat 3 = 6408)
	{
		lock (this)
		{
			this.10 = 3;
			this.9 = 2;
			this.11 = 1;
		}
	}

	// Token: 0x06004BDF RID: 19423 RVA: 0x001DFE8C File Offset: 0x001DE08C
	public override void Draw(208 1, 208 2, 198 3, 208 4, float 5, 207? 6, 1508<1394> 7 = null)
	{
		this.FlushPendingUpload();
		207 value = this.8;
		if (6 != null)
		{
			207 value2 = 6.Value;
			value.X += value2.X;
			value.Y += value2.Y;
			value.Width = Math.Min(value2.Width, this.8.Width);
			value.Height = Math.Min(value2.Height, this.8.Height);
		}
		this.7.Draw(1, 2, 3, 4, 5, new 207?(value), 7);
	}

	// Token: 0x06004BE0 RID: 19424 RVA: 0x001DFF30 File Offset: 0x001DE130
	public override bool FlushPendingUpload()
	{
		if (this.3)
		{
			return false;
		}
		lock (this)
		{
			if (this.11 != null)
			{
				this.7.12(this.11, this.8, this.9, this.10);
				this.7.FlushPendingUpload();
				this.11 = null;
				return true;
			}
		}
		return false;
	}

	// Token: 0x06004BE1 RID: 19425 RVA: 0x001DFFB4 File Offset: 0x001DE1B4
	public override bool TryBind()
	{
		this.FlushPendingUpload();
		return this.7.TryBind();
	}

	// Token: 0x04003879 RID: 14457
	private new 1402 7;

	// Token: 0x0400387A RID: 14458
	private 207 8;

	// Token: 0x0400387B RID: 14459
	private int 9;

	// Token: 0x0400387C RID: 14460
	private PixelFormat 10;

	// Token: 0x0400387D RID: 14461
	private byte[] 11;
}
