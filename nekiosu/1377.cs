using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Platform;

// Token: 0x02000A98 RID: 2712
public partial class 1377 : Form
{
	// Token: 0x17000310 RID: 784
	// (get) Token: 0x06004B27 RID: 19239 RVA: 0x001DC6CC File Offset: 0x001DA8CC
	protected override CreateParams CreateParams
	{
		get
		{
			CreateParams createParams = base.CreateParams;
			if (Configuration.RunningOnWindows)
			{
				createParams.ClassStyle |= 35;
			}
			return createParams;
		}
	}

	// Token: 0x17000311 RID: 785
	// (get) Token: 0x06004B28 RID: 19240 RVA: 0x001DC6F8 File Offset: 0x001DA8F8
	[Description("The aspect ratio of the client area of this GLControl.")]
	public float Amount1275
	{
		get
		{
			this.12();
			return (float)base.ClientSize.Width / (float)base.ClientSize.Height;
		}
	}

	// Token: 0x17000312 RID: 786
	// (get) Token: 0x06004B29 RID: 19241 RVA: 0x001DC72A File Offset: 0x001DA92A
	// (set) Token: 0x06004B2A RID: 19242 RVA: 0x001DC763 File Offset: 0x001DA963
	[Description("Indicates whether GLControl updates are synced to the monitor's refresh rate.")]
	public bool Flag1276
	{
		get
		{
			if (!base.IsHandleCreated)
			{
				return this.7 == null || this.7.Value;
			}
			this.12();
			return this.15().SwapInterval != 0;
		}
		set
		{
			if (!base.IsHandleCreated)
			{
				this.7 = new bool?(value);
				return;
			}
			this.12();
			this.15().SwapInterval = ((value > false) ? 1 : 0);
		}
	}

	// Token: 0x06004B2B RID: 19243 RVA: 0x001DC78F File Offset: 0x001DA98F
	public 1377() : this(GraphicsMode.Default)
	{
	}

	// Token: 0x06004B2C RID: 19244 RVA: 0x001DC79C File Offset: 0x001DA99C
	public 1377(GraphicsMode 1) : this(1, 1, 0, 0)
	{
	}

	// Token: 0x06004B2D RID: 19245 RVA: 0x001DC7A8 File Offset: 0x001DA9A8
	public 1377(GraphicsMode 1, int 2, int 3, GraphicsContextFlags 4)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("#=zB5lEg5c=");
		}
		Toolkit.Init(new ToolkitOptions
		{
			Backend = 1
		});
		base.SetStyle(ControlStyles.Opaque, true);
		base.SetStyle(ControlStyles.UserPaint, true);
		base.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
		this.DoubleBuffered = false;
		this.3 = 1;
		this.4 = 2;
		this.5 = 3;
		this.6 = 4;
		this.9 = (base.DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime);
		this.20();
	}

	// Token: 0x06004B2E RID: 19246 RVA: 0x001DC83A File Offset: 0x001DAA3A
	public static bool 1()
	{
		return 1377.10;
	}

	// Token: 0x06004B2F RID: 19247 RVA: 0x001DC841 File Offset: 0x001DAA41
	private static void 2(bool 1)
	{
		1377.10 = 1;
	}

	// Token: 0x06004B30 RID: 19248 RVA: 0x001DC849 File Offset: 0x001DAA49
	public static bool 3()
	{
		return 1377.11;
	}

	// Token: 0x06004B31 RID: 19249 RVA: 0x001DC850 File Offset: 0x001DAA50
	private static void 4(bool 1)
	{
		1377.11 = 1;
	}

	// Token: 0x06004B32 RID: 19250 RVA: 0x001DC858 File Offset: 0x001DAA58
	public static bool 5()
	{
		return 1377.12;
	}

	// Token: 0x06004B33 RID: 19251 RVA: 0x001DC85F File Offset: 0x001DAA5F
	private static void 6(bool 1)
	{
		1377.12 = 1;
	}

	// Token: 0x06004B34 RID: 19252 RVA: 0x001DC867 File Offset: 0x001DAA67
	public static bool 7()
	{
		return 1377.13;
	}

	// Token: 0x06004B35 RID: 19253 RVA: 0x001DC86E File Offset: 0x001DAA6E
	private static void 8(bool 1)
	{
		1377.13 = 1;
	}

	// Token: 0x06004B36 RID: 19254 RVA: 0x001DC878 File Offset: 0x001DAA78
	private GraphicsContextFlags 9(GraphicsContextFlags 1)
	{
		Control control = null;
		IGraphicsContext graphicsContext = null;
		351 2 = null;
		Exception ex = null;
		if (1 <= 16)
		{
			if (1 == null)
			{
				goto IL_32;
			}
			if (1 == 16)
			{
				return this.9(32);
			}
		}
		else if (1 == 32 || 1 == 64)
		{
			goto IL_32;
		}
		return this.9(0);
		IL_32:
		try
		{
			control = new Control();
			control.CreateControl();
			if (1 != 32)
			{
				if (1 == 64)
				{
					this.4 = 3;
				}
			}
			else
			{
				this.4 = 2;
			}
			351 3;
			if (!this.9)
			{
				3 = new 1125().1(this.3, control, 1);
			}
			else
			{
				3 = new 578();
			}
			2 = 3;
			graphicsContext = 2.CreateContext(this.4, this.5, 1);
			graphicsContext.MakeCurrent(2.GetWindowInfo());
			if (!this.9)
			{
				((IGraphicsContextInternal)graphicsContext).LoadAll();
			}
			if (1 == null && new Version(GL.GetString(7938).Split(new char[]
			{
				' '
			})[0]) < new Version(this.4, this.5))
			{
				1377.4(true);
				throw new Exception("Unsupported version, using ANGLE.");
			}
			1377.8(1809.5());
			if (1 == null && 1304.167 && 1304.214 && 1377.7())
			{
				1377.4(true);
				throw new Exception("Optimus user detected, using ANGLE.");
			}
			if ((1 & 240) > 0)
			{
				1377.6(true);
			}
		}
		catch (Exception ex)
		{
		}
		if (control != null)
		{
			control.Dispose();
		}
		if (graphicsContext != null)
		{
			graphicsContext.Dispose();
		}
		if (2 != null)
		{
			IWindowInfo windowInfo = 2.GetWindowInfo();
			if (windowInfo != null)
			{
				windowInfo.Dispose();
			}
		}
		if (ex != null)
		{
			1338.5("Renderer " + 1.ToString() + " not used: " + ex.Message, 1341.Runtime, (1114)2);
			GraphicsContextFlags result;
			if (1 != null)
			{
				if (1 != 64)
				{
					throw new 1055(ex);
				}
				result = this.9(32);
			}
			else
			{
				result = this.9(16);
			}
			return result;
		}
		return 1;
	}

	// Token: 0x06004B37 RID: 19255 RVA: 0x001DCA74 File Offset: 0x001DAC74
	private 351 10()
	{
		this.12();
		return this.2;
	}

	// Token: 0x06004B38 RID: 19256 RVA: 0x001DCA82 File Offset: 0x001DAC82
	[Conditional("DEBUG")]
	private void 11(string 1)
	{
		bool isCurrent = this.15().IsCurrent;
	}

	// Token: 0x06004B39 RID: 19257 RVA: 0x001DCA90 File Offset: 0x001DAC90
	private void 12()
	{
		if (base.IsDisposed)
		{
			throw new ObjectDisposedException(base.GetType().Name);
		}
		if (!base.IsHandleCreated)
		{
			base.CreateControl();
		}
		if (this.2 == null || this.1 == null || this.1.IsDisposed)
		{
			base.RecreateHandle();
		}
	}

	// Token: 0x06004B3A RID: 19258 RVA: 0x001DCAE8 File Offset: 0x001DACE8
	protected override void OnHandleCreated(EventArgs 1)
	{
		IGraphicsContext graphicsContext = this.1;
		if (graphicsContext != null)
		{
			graphicsContext.Dispose();
		}
		351 2 = this.2;
		if (2 != null)
		{
			IWindowInfo windowInfo = 2.GetWindowInfo();
			if (windowInfo != null)
			{
				windowInfo.Dispose();
			}
		}
		this.6 = this.9(this.6);
		if ((this.6 & 32) > 0)
		{
			if (1304.167)
			{
				1377.2(false);
				this.6 |= 256;
			}
			else
			{
				1377.2(true);
			}
		}
		351 3;
		if (!this.9)
		{
			3 = new 1125().1(this.3, this, this.6);
		}
		else
		{
			3 = new 578();
		}
		this.2 = 3;
		this.1 = this.2.CreateContext(this.4, this.5, this.6);
		this.14();
		if (!this.9)
		{
			((IGraphicsContextInternal)this.1).LoadAll();
		}
		if (this.7 != null)
		{
			this.15().SwapInterval = ((this.7.Value > false) ? 1 : 0);
			this.7 = null;
		}
		base.OnHandleCreated(1);
		if (this.8)
		{
			this.OnResize(EventArgs.Empty);
			this.8 = false;
		}
	}

	// Token: 0x06004B3B RID: 19259 RVA: 0x001DCC30 File Offset: 0x001DAE30
	protected override void OnHandleDestroyed(EventArgs 1)
	{
		base.OnHandleDestroyed(1);
		if (this.1 != null)
		{
			this.1.Dispose();
			this.1 = null;
		}
		if (this.2 != null)
		{
			this.2.GetWindowInfo().Dispose();
			this.2 = null;
		}
	}

	// Token: 0x06004B3C RID: 19260 RVA: 0x001DCC7D File Offset: 0x001DAE7D
	protected override void OnPaint(PaintEventArgs 1)
	{
		this.12();
		if (this.9)
		{
			1.Graphics.Clear(this.BackColor);
		}
		base.OnPaint(1);
	}

	// Token: 0x06004B3D RID: 19261 RVA: 0x001DCCA8 File Offset: 0x001DAEA8
	protected override void OnResize(EventArgs 1)
	{
		if (!base.IsHandleCreated)
		{
			this.8 = true;
			return;
		}
		if (Configuration.RunningOnMacOS)
		{
			1377.1378 method = new 1377.1378(this.13);
			base.BeginInvoke(method);
		}
		else if (this.1 != null)
		{
			this.1.Update(this.10().GetWindowInfo());
		}
		base.OnResize(1);
	}

	// Token: 0x06004B3E RID: 19262 RVA: 0x001DCD08 File Offset: 0x001DAF08
	public void 13()
	{
		if (this.1 != null)
		{
			this.1.Update(this.10().GetWindowInfo());
		}
	}

	// Token: 0x06004B3F RID: 19263 RVA: 0x001DCD28 File Offset: 0x001DAF28
	protected override void OnParentChanged(EventArgs 1)
	{
		if (this.1 != null)
		{
			this.1.Update(this.10().GetWindowInfo());
		}
		base.OnParentChanged(1);
	}

	// Token: 0x06004B40 RID: 19264 RVA: 0x001DCD4F File Offset: 0x001DAF4F
	public virtual void PresentFrame()
	{
		this.12();
		this.15().SwapBuffers();
	}

	// Token: 0x06004B41 RID: 19265 RVA: 0x001DCD62 File Offset: 0x001DAF62
	public void 14()
	{
		this.12();
		this.15().MakeCurrent(this.10().GetWindowInfo());
	}

	// Token: 0x06004B42 RID: 19266 RVA: 0x001DCD80 File Offset: 0x001DAF80
	public IGraphicsContext 15()
	{
		this.12();
		return this.1;
	}

	// Token: 0x06004B43 RID: 19267 RVA: 0x001DCD8E File Offset: 0x001DAF8E
	public GraphicsMode 16()
	{
		this.12();
		return this.15().GraphicsMode;
	}

	// Token: 0x06004B44 RID: 19268 RVA: 0x001DCDA1 File Offset: 0x001DAFA1
	public GraphicsContextFlags 17()
	{
		return this.6;
	}

	// Token: 0x06004B45 RID: 19269 RVA: 0x001DCDA9 File Offset: 0x001DAFA9
	public IWindowInfo 18()
	{
		return this.2.GetWindowInfo();
	}

	// Token: 0x06004B46 RID: 19270 RVA: 0x001DCDB6 File Offset: 0x001DAFB6
	public static void 19()
	{
		if (1377.5())
		{
			1377.eglToggleWindowed();
		}
		1377.2(!1377.1());
	}

	// Token: 0x06004B47 RID: 19271
	[DllImport("libEGL.dll")]
	private static extern void eglToggleWindowed();

	// Token: 0x06004B49 RID: 19273 RVA: 0x001DCDF0 File Offset: 0x001DAFF0
	private void 20()
	{
		base.SuspendLayout();
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		this.BackColor = Color.Black;
		base.Name = "NewGLControl";
		base.ResumeLayout(false);
	}

	// Token: 0x04003815 RID: 14357
	private IGraphicsContext 1;

	// Token: 0x04003816 RID: 14358
	private 351 2;

	// Token: 0x04003817 RID: 14359
	private GraphicsMode 3;

	// Token: 0x04003818 RID: 14360
	private int 4;

	// Token: 0x04003819 RID: 14361
	private int 5;

	// Token: 0x0400381A RID: 14362
	private GraphicsContextFlags 6;

	// Token: 0x0400381B RID: 14363
	private bool? 7;

	// Token: 0x0400381C RID: 14364
	private bool 8;

	// Token: 0x0400381D RID: 14365
	private readonly bool 9;

	// Token: 0x0400381E RID: 14366
	private static bool 10;

	// Token: 0x0400381F RID: 14367
	private static bool 11;

	// Token: 0x04003820 RID: 14368
	private static bool 12;

	// Token: 0x04003821 RID: 14369
	private static bool 13;

	// Token: 0x02000A99 RID: 2713
	// (Invoke) Token: 0x06004B4B RID: 19275
	public delegate void 1378();
}
