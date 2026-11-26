using System;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Platform;
using OpenTK.Platform.MacOS;

// Token: 0x02000BE5 RID: 3045
public sealed class 1116 : IGraphicsContext, IDisposable, IGraphicsContextInternal
{
	// Token: 0x17000322 RID: 802
	// (get) Token: 0x06005326 RID: 21286 RVA: 0x0020A236 File Offset: 0x00208436
	public bool IsCurrent
	{
		get
		{
			return this.1.Handle == 614.aglGetCurrentContext();
		}
	}

	// Token: 0x17000323 RID: 803
	// (get) Token: 0x06005327 RID: 21287 RVA: 0x0020A250 File Offset: 0x00208450
	// (set) Token: 0x06005328 RID: 21288 RVA: 0x0020A286 File Offset: 0x00208486
	public int SwapInterval
	{
		get
		{
			int result = 0;
			if (614.aglGetInteger(this.1.Handle, (614.618)222, out result))
			{
				return result;
			}
			this.5("aglGetInteger");
			return 0;
		}
		set
		{
			if (!614.aglSetInteger(this.1.Handle, (614.618)222, ref value))
			{
				this.5("aglSetInteger");
			}
		}
	}

	// Token: 0x17000324 RID: 804
	// (get) Token: 0x06005329 RID: 21289 RVA: 0x0020A2AC File Offset: 0x002084AC
	public bool IsDisposed
	{
		get
		{
			return this.5;
		}
	}

	// Token: 0x17000325 RID: 805
	// (get) Token: 0x0600532A RID: 21290 RVA: 0x0020A2B4 File Offset: 0x002084B4
	// (set) Token: 0x0600532B RID: 21291 RVA: 0x0020A2BF File Offset: 0x002084BF
	public bool VSync
	{
		get
		{
			return this.SwapInterval != 0;
		}
		set
		{
			this.SwapInterval = ((value > false) ? 1 : 0);
		}
	}

	// Token: 0x17000326 RID: 806
	// (get) Token: 0x0600532C RID: 21292 RVA: 0x0020A2CB File Offset: 0x002084CB
	public GraphicsMode GraphicsMode
	{
		get
		{
			return this.2;
		}
	}

	// Token: 0x17000327 RID: 807
	// (get) Token: 0x0600532D RID: 21293 RVA: 0x0020A2D3 File Offset: 0x002084D3
	// (set) Token: 0x0600532E RID: 21294 RVA: 0x0020A2DB File Offset: 0x002084DB
	public bool ErrorChecking
	{
		get
		{
			return this.6;
		}
		set
		{
			this.6 = value;
		}
	}

	// Token: 0x17000328 RID: 808
	// (get) Token: 0x0600532F RID: 21295 RVA: 0x00043D55 File Offset: 0x00041F55
	public IGraphicsContext Implementation
	{
		get
		{
			return this;
		}
	}

	// Token: 0x17000329 RID: 809
	// (get) Token: 0x06005330 RID: 21296 RVA: 0x0020A2E4 File Offset: 0x002084E4
	public ContextHandle Context
	{
		get
		{
			return this.1;
		}
	}

	// Token: 0x06005331 RID: 21297 RVA: 0x0020A2EC File Offset: 0x002084EC
	public 1116(GraphicsMode 1, IWindowInfo 2, IGraphicsContext 3, GetInt 4, GetInt 5)
	{
		IntPtr value = IntPtr.Zero;
		this.7 = 4;
		this.8 = 5;
		this.3 = 2;
		if (3 is 1116)
		{
			value = ((1116)3).1.Handle;
		}
		else if (3 is GraphicsContext)
		{
			value = ((3 != null) ? (3 as IGraphicsContextInternal).Context : ((ContextHandle)IntPtr.Zero)).Handle;
		}
		value == IntPtr.Zero;
		this.1(1, this.3, value, true);
	}

	// Token: 0x06005332 RID: 21298 RVA: 0x0020A384 File Offset: 0x00208584
	private void 1(GraphicsMode 1, IWindowInfo 2, IntPtr 3, bool 4)
	{
		789 5 = new 789();
		IntPtr intPtr;
		this.6(5.Method12900(1.ColorFormat, 1.Depth, 1.Stencil, 1.Samples, 1.AccumulatorFormat, 1.Buffers, 1.Stereo, out intPtr));
		this.5("aglChoosePixelFormat");
		this.1 = new ContextHandle(614.aglCreateContext(intPtr, 3));
		this.5("aglCreateContext");
		614.aglDestroyPixelFormat(intPtr);
		this.5("aglDestroyPixelFormat");
		this.3(2);
		this.2(2);
		this.Update(2);
		this.MakeCurrent(2);
		this.4 = new GraphicsContext(this.1, new GraphicsContext.GetAddressDelegate(this.GetAddress), () => new ContextHandle(614.aglGetCurrentContext()));
	}

	// Token: 0x06005333 RID: 21299 RVA: 0x0020A464 File Offset: 0x00208664
	private void 2(IWindowInfo 1)
	{
		1142 2 = 1118.1(1.Handle);
		int[] array = new int[4];
		if (this.7 != null)
		{
			array[0] = (int)2.1() + this.7.Invoke();
		}
		else
		{
			array[0] = (int)2.1();
		}
		if (this.8 != null)
		{
			array[1] = (int)2.2() + this.8.Invoke();
		}
		else
		{
			array[1] = (int)2.2();
		}
		array[2] = (int)2.3();
		array[3] = (int)2.4();
		614.aglSetInteger(this.1.Handle, (614.618)202, array);
		this.5("aglSetInteger");
		614.aglEnable(this.1.Handle, (614.618)202);
		this.5("aglEnable");
	}

	// Token: 0x06005334 RID: 21300 RVA: 0x0020A530 File Offset: 0x00208730
	private void 3(IWindowInfo 1)
	{
		IntPtr intPtr = 1116.4(1);
		614.Method9032(this.1.Handle, intPtr);
		this.5("aglSetDrawable");
	}

	// Token: 0x06005335 RID: 21301 RVA: 0x0020A560 File Offset: 0x00208760
	private static IntPtr 4(IWindowInfo 1)
	{
		return 1118.GetWindowPort(1118.GetControlOwner(1.Handle));
	}

	// Token: 0x06005336 RID: 21302 RVA: 0x0020A572 File Offset: 0x00208772
	public void Update(IWindowInfo 1)
	{
		this.3(1);
		this.2(1);
		614.aglUpdateContext(this.1.Handle);
	}

	// Token: 0x06005337 RID: 21303 RVA: 0x0020A594 File Offset: 0x00208794
	private void 5(string 1)
	{
		614.624 2 = 614.aglGetError();
		if (2 != 614.624.NoError)
		{
			throw new Exception(string.Format("AGL Error from function {0}: {1}  {2}", 1, 2, 614.Method9034(2)));
		}
	}

	// Token: 0x06005338 RID: 21304 RVA: 0x0020A5C8 File Offset: 0x002087C8
	public void SwapBuffers()
	{
		if (this.9)
		{
			this.9 = false;
			this.3(this.3);
			this.Update(this.3);
		}
		614.aglSwapBuffers(this.1.Handle);
		this.5("aglSwapBuffers");
	}

	// Token: 0x06005339 RID: 21305 RVA: 0x0020A617 File Offset: 0x00208817
	public void MakeCurrent(IWindowInfo 1)
	{
		if (!614.Method9031(this.1.Handle))
		{
			this.5("aglSetCurrentContext");
		}
	}

	// Token: 0x0600533A RID: 21306 RVA: 0x0020A636 File Offset: 0x00208836
	public void 6(GraphicsMode 1)
	{
		this.2 = 1;
	}

	// Token: 0x0600533B RID: 21307 RVA: 0x0020A63F File Offset: 0x0020883F
	public void LoadAll()
	{
		this.4.LoadAll();
	}

	// Token: 0x0600533C RID: 21308 RVA: 0x0020A64C File Offset: 0x0020884C
	~1116()
	{
		this.7(false);
	}

	// Token: 0x0600533D RID: 21309 RVA: 0x0020A67C File Offset: 0x0020887C
	public void Dispose()
	{
		this.7(true);
	}

	// Token: 0x0600533E RID: 21310 RVA: 0x0020A688 File Offset: 0x00208888
	private void 7(bool 1)
	{
		if (this.IsDisposed || this.1.Handle == IntPtr.Zero)
		{
			return;
		}
		614.Method9031(IntPtr.Zero);
		if (614.Method9030(this.1.Handle))
		{
			this.1 = ContextHandle.Zero;
			return;
		}
		if (1)
		{
			throw new Exception(614.Method9034(614.aglGetError()));
		}
		this.5 = true;
	}

	// Token: 0x0600533F RID: 21311 RVA: 0x0020A6F8 File Offset: 0x002088F8
	public IntPtr GetAddress(string 1)
	{
		return 1128.1(1);
	}

	// Token: 0x06005340 RID: 21312 RVA: 0x0020A700 File Offset: 0x00208900
	public IntPtr GetAddress(IntPtr 1)
	{
		return 1128.2(1);
	}

	// Token: 0x04003F40 RID: 16192
	private ContextHandle 1;

	// Token: 0x04003F41 RID: 16193
	private GraphicsMode 2;

	// Token: 0x04003F42 RID: 16194
	private IWindowInfo 3;

	// Token: 0x04003F43 RID: 16195
	private IGraphicsContext 4;

	// Token: 0x04003F44 RID: 16196
	private bool 5;

	// Token: 0x04003F45 RID: 16197
	private bool 6;

	// Token: 0x04003F46 RID: 16198
	private readonly GetInt 7;

	// Token: 0x04003F47 RID: 16199
	private readonly GetInt 8;

	// Token: 0x04003F48 RID: 16200
	private bool 9 = true;

	// Token: 0x02000BE6 RID: 3046
	[Serializable]
	public sealed class 1117
	{
		// Token: 0x04003F49 RID: 16201
		public static readonly 1116.1117 instance = new 1116.1117();

		// Token: 0x04003F4A RID: 16202
		public static GraphicsContext.GetCurrentContextDelegate getCurrentContextDelegate;
	}
}
