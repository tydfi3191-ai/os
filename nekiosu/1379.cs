using System;
using System.Drawing;
using System.Threading;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.ES20;

// Token: 0x02000A9A RID: 2714
public partial class 1379 : 1377
{
	// Token: 0x17000313 RID: 787
	// (get) Token: 0x06004B4E RID: 19278 RVA: 0x001DCE3C File Offset: 0x001DB03C
	// (set) Token: 0x06004B4F RID: 19279 RVA: 0x001DCE43 File Offset: 0x001DB043
	internal static int BufferContextGeneration { get; private set; }

	// Token: 0x06004B50 RID: 19280 RVA: 0x001DCE4B File Offset: 0x001DB04B
	internal static void 21(IGraphicsContext 1)
	{
		if (1 == null || 1.IsDisposed)
		{
			throw new InvalidOperationException("A live graphics context is required for buffer rendering.");
		}
		if (1379.31 == 1)
		{
			return;
		}
		1379.31 = 1;
		1379.BufferContextGeneration++;
		1379.22();
	}

	// Token: 0x06004B51 RID: 19281 RVA: 0x001DCE84 File Offset: 0x001DB084
	internal static void 22()
	{
		1379.30[0] = (1379.30[1] = -1);
	}

	// Token: 0x06004B52 RID: 19282 RVA: 0x001DCEA4 File Offset: 0x001DB0A4
	internal static void 23(int 1, int 2)
	{
		IGraphicsContext currentContext = GraphicsContext.CurrentContext;
		if (currentContext == null || currentContext.IsDisposed)
		{
			return;
		}
		1379.21(currentContext);
		if (1 == 0 || 2 != 1379.BufferContextGeneration)
		{
			return;
		}
		GL.DeleteBuffers(1, ref 1);
		1379.22();
	}

	// Token: 0x06004B53 RID: 19283 RVA: 0x001DCEE2 File Offset: 0x001DB0E2
	public 1379(GraphicsMode 1, int 2, int 3, GraphicsContextFlags 4) : base(1, 2, 3, 4)
	{
	}

	// Token: 0x06004B54 RID: 19284 RVA: 0x001DCEF0 File Offset: 0x001DB0F0
	internal void 24()
	{
		1379.21(base.15());
		1379.25();
		1379.19 = (1377.5() || 1379.26("GL_ARB_framebuffer_object"));
		1379.20 = (1377.5() || 1379.26("ARB_vertex_buffer_object"));
		string @string = GL.GetString(7938);
		1379.17 = new Version(@string.Split(new char[]
		{
			' '
		})[1377.5() ? 2 : 0]);
		@string = GL.GetString(35724);
		if (!string.IsNullOrEmpty(@string))
		{
			try
			{
				1379.18 = new Version(@string.Split(new char[]
				{
					' '
				})[1377.5() ? 4 : 0]);
			}
			catch (Exception)
			{
				1338.4(<<EMPTY_NAME>>, "couldn't set GLSL version using string '" + @string + "'", 1341.Runtime);
			}
		}
		if (1379.18 == null)
		{
			1379.18 = new Version();
		}
		GL.Disable(2929);
		GL.Disable(2960);
		GL.Enable(3042);
		1379.16 = GL.GetInteger(3379);
		1379.22 = 1425.6(1510.Texture2D, 1049.Texture, false);
		1379.23 = 1425.6(1510.Texture3D, 1049.Texture, false);
		1379.24 = 1425.6(1510.Colour, 1049.Colour, false);
		1379.25 = 1425.6(1510.Particle, 1049.Texture, false);
		1338.5(string.Format("GL Initialized\r\n                        GL Version:                 {0}\r\n                        GL Renderer:                {1}\r\n                        GL Shader Language version: {2}\r\n                        GL Vendor:                  {3}\r\n                        GL Extensions:              {4}\r\n                        GL Context:                 {5}", new object[]
		{
			GL.GetString(7938),
			GL.GetString(7937),
			GL.GetString(35724),
			1379.37(),
			GL.GetString(7939),
			base.16()
		}), 1341.Runtime, (1114)2);
	}

	// Token: 0x06004B55 RID: 19285 RVA: 0x001DD0AC File Offset: 0x001DB2AC
	private static void 25()
	{
		if (1809.7())
		{
			1809.8(false);
			if (1809.7() || 1809.1() != 1159.OK)
			{
				1338.5(string.Format("Failed to disable ThreadedOptimisations: {0}", 1809.1()), 1341.Runtime, (1114)2);
			}
		}
	}

	// Token: 0x06004B56 RID: 19286 RVA: 0x001DD0E4 File Offset: 0x001DB2E4
	internal static bool 26(string 1)
	{
		try
		{
			if (string.IsNullOrEmpty(1379.15))
			{
				1379.15 = GL.GetString(7939);
			}
			return 1379.15.Contains(1);
		}
		catch
		{
		}
		return false;
	}

	// Token: 0x06004B57 RID: 19287 RVA: 0x001DD130 File Offset: 0x001DB330
	internal static void 27(Rectangle? 1)
	{
		Rectangle rectangle = 1 ?? 1379.28;
		if (rectangle.Width < 0)
		{
			rectangle.X += rectangle.Width;
			rectangle.Width = -rectangle.Width;
		}
		if (rectangle.Height < 0)
		{
			rectangle.Y += rectangle.Height;
			rectangle.Height = -rectangle.Height;
		}
		if (1379.27 == rectangle)
		{
			return;
		}
		bool flag = 1379.27 != 1379.28;
		bool flag2 = rectangle != 1379.28;
		1379.27 = rectangle;
		if (flag != flag2)
		{
			if (!flag2)
			{
				GL.Disable(3089);
				return;
			}
			GL.Enable(3089);
		}
		if (flag2)
		{
			GL.Scissor(1379.27.X, 1379.27.Y, 1379.27.Width, 1379.27.Height);
		}
	}

	// Token: 0x06004B58 RID: 19288 RVA: 0x001DD230 File Offset: 0x001DB430
	internal static void 28(Rectangle? 1)
	{
		if (1 != null)
		{
			1379.28 = 1.Value;
			if (1379.28.Width < 0)
			{
				1379.28.X = 1379.28.X + 1379.28.Width;
				1379.28.Width = -1379.28.Width;
			}
			if (1379.28.Height < 0)
			{
				1379.28.Y = 1379.28.Y + 1379.28.Height;
				1379.28.Height = -1379.28.Height;
			}
			GL.Viewport(1379.28.Left, 1379.28.Top, 1379.28.Width, 1379.28.Height);
		}
		else
		{
			Vector2 vector;
			vector..ctor(0f, (float)1662.120);
			if (1304.208)
			{
				Vector2 vector2;
				vector2..ctor((float)(1662.113.Width - 1662.70.1) / 2f, (float)(1662.113.Height - 1662.70.2 - 1662.31()) / 2f);
				vector += vector2 * new Vector2((float)(100 + 1304.209), (float)(100 - 1304.210)) / 100f;
			}
			1379.28 = new Rectangle((int)vector.X, (int)vector.Y, 1662.70.1, 1662.70.2);
			GL.Viewport(1379.28.Left, 1379.28.Top, 1379.28.Width, 1379.28.Height);
			1379.29(null);
		}
		1379.27(new Rectangle?(1379.28));
	}

	// Token: 0x06004B59 RID: 19289 RVA: 0x001DD414 File Offset: 0x001DB614
	internal static void 29(Rectangle? 1)
	{
		1379.29 = (1 ?? new Rectangle(0, 0, 1662.70.1, 1662.70.2));
		1379.21 = Matrix4.CreateOrthographicOffCenter((float)1379.29.Left, (float)1379.29.Right, (float)1379.29.Bottom, (float)1379.29.Top, -1f, 1f);
		1426.5("g_ProjMatrix", 1379.21);
	}

	// Token: 0x06004B5A RID: 19290 RVA: 0x001DD4A9 File Offset: 0x001DB6A9
	internal static 207 30()
	{
		return new 207(0, 1662.70.2 - 1379.28.Height, 1379.28.Width, 1379.28.Height);
	}

	// Token: 0x06004B5B RID: 19291 RVA: 0x001DD4DA File Offset: 0x001DB6DA
	internal static void 31()
	{
		1379.21(GraphicsContext.CurrentContext);
		1379.22();
		1379.32 = -1;
		1379.33 = 0;
		1379.34 = 0;
		1379.27 = new Rectangle(0, 0, 0, 0);
	}

	// Token: 0x06004B5C RID: 19292 RVA: 0x001DD50C File Offset: 0x001DB70C
	internal static bool 32(BufferTarget 1, int 2)
	{
		int num = 1 - 34962;
		if (1379.30[num] == 2)
		{
			return false;
		}
		1379.30[num] = 2;
		GL.BindBuffer(1, 2);
		return true;
	}

	// Token: 0x06004B5D RID: 19293 RVA: 0x001DD53D File Offset: 0x001DB73D
	internal static void 33(int 1)
	{
		if (1379.32 != 1)
		{
			if (1436.40 != null)
			{
				1436.40.35().6();
			}
			GL.BindTexture(3553, 1);
			1379.32 = 1;
		}
	}

	// Token: 0x06004B5E RID: 19294 RVA: 0x001DD56E File Offset: 0x001DB76E
	internal static void 34()
	{
		GL.BlendFunc(1379.33, 1379.34);
	}

	// Token: 0x06004B5F RID: 19295 RVA: 0x001DD57F File Offset: 0x001DB77F
	internal static void 35(BlendingFactorSrc 1, BlendingFactorDest 2)
	{
		if (!1304.221 && (1379.33 != 1 || 1379.34 != 2))
		{
			GL.BlendFunc(1, 2);
			1379.33 = 1;
			1379.34 = 2;
		}
	}

	// Token: 0x06004B60 RID: 19296 RVA: 0x001DD5B0 File Offset: 0x001DB7B0
	protected override void OnHandleCreated(EventArgs 1)
	{
		base.OnHandleCreated(1);
		1379.26.Set();
	}

	// Token: 0x06004B61 RID: 19297 RVA: 0x001DD5C4 File Offset: 0x001DB7C4
	public override void PresentFrame()
	{
		base.PresentFrame();
		if (1304.175)
		{
			1662.43.7(1335.Draw);
			this.36();
			1662.43.9(1335.Draw);
		}
	}

	// Token: 0x06004B62 RID: 19298 RVA: 0x001DD5F4 File Offset: 0x001DB7F4
	public void 36()
	{
		GL.Flush();
		GL.Finish();
	}

	// Token: 0x06004B63 RID: 19299 RVA: 0x001DD600 File Offset: 0x001DB800
	public static string 37()
	{
		return GL.GetString(7936);
	}

	// Token: 0x04003823 RID: 14371
	private new static string 15;

	// Token: 0x04003824 RID: 14372
	internal new static int 16;

	// Token: 0x04003825 RID: 14373
	internal new static Version 17;

	// Token: 0x04003826 RID: 14374
	internal new static Version 18;

	// Token: 0x04003827 RID: 14375
	internal new static bool 19;

	// Token: 0x04003828 RID: 14376
	internal static bool 20;

	// Token: 0x04003829 RID: 14377
	internal static Matrix4 21;

	// Token: 0x0400382A RID: 14378
	internal static 1426 22;

	// Token: 0x0400382B RID: 14379
	internal static 1426 23;

	// Token: 0x0400382C RID: 14380
	internal static 1426 24;

	// Token: 0x0400382D RID: 14381
	internal static 1426 25;

	// Token: 0x0400382E RID: 14382
	internal static AutoResetEvent 26 = new AutoResetEvent(false);

	// Token: 0x0400382F RID: 14383
	internal static Rectangle 27;

	// Token: 0x04003830 RID: 14384
	internal static Rectangle 28;

	// Token: 0x04003831 RID: 14385
	internal static Rectangle 29;

	// Token: 0x04003832 RID: 14386
	private static int[] 30 = new int[]
	{
		-1,
		-1
	};

	// Token: 0x04003833 RID: 14387
	private static IGraphicsContext 31;

	// Token: 0x04003835 RID: 14389
	private static int 32 = -1;

	// Token: 0x04003836 RID: 14390
	private static BlendingFactorSrc 33;

	// Token: 0x04003837 RID: 14391
	private static BlendingFactorDest 34;
}
