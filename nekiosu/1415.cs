using System;
using System.Drawing;
using OpenTK.Graphics.ES20;

// Token: 0x02000AB1 RID: 2737
public sealed class 1415 : IDisposable
{
	// Token: 0x06004BEF RID: 19439 RVA: 0x001E0226 File Offset: 0x001DE426
	internal 1415(int 1, int 2, RenderbufferInternalFormat? 3 = null) : this(new 1402(1, 2), 3)
	{
	}

	// Token: 0x06004BF0 RID: 19440 RVA: 0x001E0238 File Offset: 0x001DE438
	internal 1415(1402 1, RenderbufferInternalFormat? 2 = null)
	{
		this.6(1);
		this.13 = 2;
		this.8 = new Rectangle(0, 0, this.7(), this.8());
		this.5().UploadPixels(new byte[0], 0, 6408);
		this.5().FlushPendingUpload();
		if (1379.19)
		{
			this.5 = 1415.4;
			1415.4 = (this.11 = GL.GenFramebuffer());
			GL.BindFramebuffer(36160, this.11);
			GL.FramebufferTexture2D(36160, 36064, 3553, this.5().GetTextureId(), 0);
			1379.33(0);
			if (2 != null)
			{
				this.12 = GL.GenRenderbuffer();
				GL.BindRenderbuffer(36161, this.12);
				GL.RenderbufferStorage(36161, 33189, this.7(), this.8());
				GL.FramebufferRenderbuffer(36160, 36096, 36161, this.12);
				1415.2(1415.1() + 1);
			}
			1415.4 = this.5;
			GL.BindFramebuffer(36160, this.5);
			1415.4(1415.3() + 1);
		}
	}

	// Token: 0x06004BF1 RID: 19441 RVA: 0x001E038D File Offset: 0x001DE58D
	internal static int 1()
	{
		return 1415.1;
	}

	// Token: 0x06004BF2 RID: 19442 RVA: 0x001E0394 File Offset: 0x001DE594
	private static void 2(int 1)
	{
		1415.1 = 1;
	}

	// Token: 0x06004BF3 RID: 19443 RVA: 0x001E039C File Offset: 0x001DE59C
	internal static int 3()
	{
		return 1415.2;
	}

	// Token: 0x06004BF4 RID: 19444 RVA: 0x001E03A3 File Offset: 0x001DE5A3
	private static void 4(int 1)
	{
		1415.2 = 1;
	}

	// Token: 0x06004BF5 RID: 19445 RVA: 0x001E03AB File Offset: 0x001DE5AB
	internal 1454 5()
	{
		return this.3;
	}

	// Token: 0x06004BF6 RID: 19446 RVA: 0x001E03B3 File Offset: 0x001DE5B3
	private void 6(1454 1)
	{
		this.3 = 1;
	}

	// Token: 0x06004BF7 RID: 19447 RVA: 0x001E03BC File Offset: 0x001DE5BC
	internal int 7()
	{
		return this.5().GetWidth_10758();
	}

	// Token: 0x06004BF8 RID: 19448 RVA: 0x001E03C9 File Offset: 0x001DE5C9
	internal int 8()
	{
		return this.5().GetHeight_10756();
	}

	// Token: 0x06004BF9 RID: 19449 RVA: 0x001E03D8 File Offset: 0x001DE5D8
	~1415()
	{
		this.9(false);
	}

	// Token: 0x06004BFA RID: 19450 RVA: 0x001E0408 File Offset: 0x001DE608
	public void Dispose()
	{
		this.9(true);
		GC.SuppressFinalize(this);
	}

	// Token: 0x06004BFB RID: 19451 RVA: 0x001E0417 File Offset: 0x001DE617
	protected void 9(bool 1)
	{
		if (this.10)
		{
			return;
		}
		this.10 = true;
		1662.89.Schedule(delegate()
		{
			this.11();
			if (this.11 != -1)
			{
				GL.DeleteFramebuffer(this.11);
				1415.4(1415.3() - 1);
			}
			if (this.12 != -1)
			{
				GL.DeleteRenderbuffer(this.12);
				1415.2(1415.1() - 1);
			}
			this.12 = -1;
			this.11 = -1;
		}, false);
	}

	// Token: 0x06004BFC RID: 19452 RVA: 0x001E0444 File Offset: 0x001DE644
	internal void 10()
	{
		if (!this.9)
		{
			this.6 = 1379.28;
			this.7 = 1379.29;
			if (1379.19)
			{
				this.5 = 1415.4;
				1415.4 = this.11;
				GL.BindFramebuffer(36160, this.11);
			}
			GL.Clear(16640);
			if (this.8 != this.6)
			{
				1379.28(new Rectangle?(this.8));
				1379.29(new Rectangle?(this.8));
			}
			this.9 = true;
		}
	}

	// Token: 0x06004BFD RID: 19453 RVA: 0x001E04E4 File Offset: 0x001DE6E4
	internal void 11()
	{
		if (this.9)
		{
			if (1379.19)
			{
				1415.4 = this.5;
				GL.BindFramebuffer(36160, this.5);
			}
			else
			{
				1379.33(this.5().GetTextureId());
				GL.TexParameter(3553, 10241, 9729);
				GL.TexParameter(3553, 10240, 9729);
				GL.CopyTexImage2D(3553, 0, 6408, 0, 0, this.7(), this.8(), 0);
			}
			if (1379.28 != this.6)
			{
				1379.28(new Rectangle?(this.6));
				1379.29(new Rectangle?(this.7));
			}
			this.9 = false;
		}
	}

	// Token: 0x06004BFE RID: 19454 RVA: 0x001E05B0 File Offset: 0x001DE7B0
	private void 12()
	{
		this.11();
		if (this.11 != -1)
		{
			GL.DeleteFramebuffer(this.11);
			1415.4(1415.3() - 1);
		}
		if (this.12 != -1)
		{
			GL.DeleteRenderbuffer(this.12);
			1415.2(1415.1() - 1);
		}
		this.12 = -1;
		this.11 = -1;
	}

	// Token: 0x04003882 RID: 14466
	private static int 1;

	// Token: 0x04003883 RID: 14467
	private static int 2;

	// Token: 0x04003884 RID: 14468
	private 1454 3;

	// Token: 0x04003885 RID: 14469
	private static int 4;

	// Token: 0x04003886 RID: 14470
	private int 5;

	// Token: 0x04003887 RID: 14471
	private Rectangle 6;

	// Token: 0x04003888 RID: 14472
	private Rectangle 7;

	// Token: 0x04003889 RID: 14473
	private Rectangle 8;

	// Token: 0x0400388A RID: 14474
	private bool 9;

	// Token: 0x0400388B RID: 14475
	private bool 10;

	// Token: 0x0400388C RID: 14476
	private int 11 = -1;

	// Token: 0x0400388D RID: 14477
	private int 12 = -1;

	// Token: 0x0400388E RID: 14478
	private RenderbufferInternalFormat? 13;
}
