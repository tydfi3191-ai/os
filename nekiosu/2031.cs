using System;
using System.Drawing;
using OpenTK;
using OpenTK.Graphics.ES20;

// Token: 0x020007FA RID: 2042
[276]
public sealed class 2031 : 2054
{
	// Token: 0x06003B0D RID: 15117 RVA: 0x00174190 File Offset: 0x00172390
	protected override 1454 CreateTexture(198 1, 198 2)
	{
		198 3;
		198 4;
		2031.12(1, out 3, out 4);
		return this.14(2, 3, 4);
	}

	// Token: 0x06003B0E RID: 15118 RVA: 0x001741B0 File Offset: 0x001723B0
	internal static void 12(198 1, out 198 2, out 198 3)
	{
		198 4 = new 198(1.R, 1.G, 1.B, 180);
		2 = 1045.2(4, 0.5f);
		3 = 1045.3(4, 0.1f);
	}

	// Token: 0x06003B0F RID: 15119 RVA: 0x00174200 File Offset: 0x00172400
	private 1454 13(198 1, 198 2, 198 3, 198 4, float 5)
	{
		1415 6 = new 1415(128, 1, null);
		1454 result;
		try
		{
			6.10();
			GL.Disable(2929);
			GL.Disable(3042);
			GL.ClearColor(0.859f, 0.439f, 0.576f, 1f);
			GL.Clear(16384);
			GL.ClearColor(0f, 0f, 0f, 0f);
			1379.24.1["g_ProjMatrix"] = Matrix4.CreateOrthographicOffCenter(0f, 1f, 1f, -1f, -1f, 1f);
			1379.24.3();
			this.20.5(new 1398
			{
				Position = new 208(-0.5f, 0f),
				Colour = 198.TransparentBlack
			});
			this.20.5(new 1398
			{
				Position = new 208(0f, 0f),
				Colour = 198.TransparentBlack
			});
			this.20.5(new 1398
			{
				Position = new 208(0.078125f - 5, 0f),
				Colour = 1
			});
			this.20.5(new 1398
			{
				Position = new 208(0.078125f + 5, 0f),
				Colour = 2
			});
			this.20.5(new 1398
			{
				Position = new 208(0.1875f - 5, 0f),
				Colour = 2
			});
			this.20.5(new 1398
			{
				Position = new 208(0.1875f + 5, 0f),
				Colour = 4
			});
			this.20.5(new 1398
			{
				Position = new 208(1f, 0f),
				Colour = 3
			});
			this.20.5(new 1398
			{
				Position = new 208(1.5f, 0f),
				Colour = 3
			});
			this.20.6();
			1379.24.4();
			1379.24.1["g_ProjMatrix"] = 1379.21;
			if (!1379.19)
			{
				6.11();
				GL.Clear(16384);
			}
			GL.Enable(3042);
			result = 6.5();
		}
		finally
		{
			((IDisposable)6).Dispose();
		}
		return result;
	}

	// Token: 0x06003B10 RID: 15120 RVA: 0x001744E4 File Offset: 0x001726E4
	private 1454 14(198 1, 198 2, 198 3)
	{
		float 4 = Math.Min(Math.Max(0.5f / base.GetBodyWidth(), 0.01171875f), 0.0625f);
		198 5 = new 198(0, 0, 0, 64);
		return this.13(5, 1, 2, 3, 4);
	}

	// Token: 0x06003B11 RID: 15121 RVA: 0x00174529 File Offset: 0x00172729
	protected override Size GetTextureSize()
	{
		return new Size(128, 1);
	}

	// Token: 0x04002BBB RID: 11195
	private 1407<1398> 20 = new 1407<1398>(8, 1, 3);
}
