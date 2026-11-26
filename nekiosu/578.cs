using System;
using System.Threading;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Platform;

// Token: 0x020002BC RID: 700
public sealed class 578 : 351
{
	// Token: 0x06001509 RID: 5385 RVA: 0x000492FC File Offset: 0x000474FC
	public IGraphicsContext CreateContext(int 1, int 2, GraphicsContextFlags 3)
	{
		return new 578.579();
	}

	// Token: 0x0600150A RID: 5386 RVA: 0x0000FF75 File Offset: 0x0000E175
	public bool Method9556()
	{
		return false;
	}

	// Token: 0x0600150B RID: 5387 RVA: 0x00049303 File Offset: 0x00047503
	public IWindowInfo GetWindowInfo()
	{
		return Utilities.CreateDummyWindowInfo();
	}

	// Token: 0x020002BD RID: 701
	public sealed class 579 : IGraphicsContext, IDisposable, IGraphicsContextInternal
	{
		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x0600150D RID: 5389 RVA: 0x0004930A File Offset: 0x0004750A
		public bool IsCurrent
		{
			get
			{
				return this.iWindowInfo2 != null;
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x0600150E RID: 5390 RVA: 0x00049315 File Offset: 0x00047515
		public bool IsDisposed
		{
			get
			{
				return this.flag;
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x0600150F RID: 5391 RVA: 0x0004931D File Offset: 0x0004751D
		// (set) Token: 0x06001510 RID: 5392 RVA: 0x00049328 File Offset: 0x00047528
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

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06001511 RID: 5393 RVA: 0x00049334 File Offset: 0x00047534
		// (set) Token: 0x06001512 RID: 5394 RVA: 0x0004933C File Offset: 0x0004753C
		public int SwapInterval
		{
			get
			{
				return this.number2;
			}
			set
			{
				this.number2 = value;
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06001513 RID: 5395 RVA: 0x00049345 File Offset: 0x00047545
		public GraphicsMode GraphicsMode
		{
			get
			{
				return GraphicsMode.Default;
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06001514 RID: 5396 RVA: 0x0000FF75 File Offset: 0x0000E175
		// (set) Token: 0x06001515 RID: 5397 RVA: 0x00005ADD File Offset: 0x00003CDD
		public bool ErrorChecking
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06001516 RID: 5398 RVA: 0x0004934C File Offset: 0x0004754C
		public ContextHandle Context
		{
			get
			{
				return this.contextHandle;
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06001517 RID: 5399 RVA: 0x00043D55 File Offset: 0x00041F55
		public IGraphicsContext Implementation
		{
			get
			{
				return this;
			}
		}

		// Token: 0x06001518 RID: 5400 RVA: 0x00005ADD File Offset: 0x00003CDD
		public void SwapBuffers()
		{
		}

		// Token: 0x06001519 RID: 5401 RVA: 0x00049354 File Offset: 0x00047554
		public void MakeCurrent(IWindowInfo 1)
		{
			this.iWindowInfo2 = 1;
		}

		// Token: 0x0600151A RID: 5402 RVA: 0x00005ADD File Offset: 0x00003CDD
		public void Update(IWindowInfo 1)
		{
		}

		// Token: 0x0600151B RID: 5403 RVA: 0x00005ADD File Offset: 0x00003CDD
		public void LoadAll()
		{
		}

		// Token: 0x0600151C RID: 5404 RVA: 0x0004935D File Offset: 0x0004755D
		public void Dispose()
		{
			this.flag = true;
		}

		// Token: 0x0600151D RID: 5405 RVA: 0x00049366 File Offset: 0x00047566
		public IntPtr GetAddress(IntPtr 1)
		{
			return IntPtr.Zero;
		}

		// Token: 0x0600151E RID: 5406 RVA: 0x00049366 File Offset: 0x00047566
		public IntPtr GetAddress(string 1)
		{
			return IntPtr.Zero;
		}

		// Token: 0x040009E8 RID: 2536
		private static int number;

		// Token: 0x040009E9 RID: 2537
		private readonly ContextHandle contextHandle = new ContextHandle(new IntPtr(Interlocked.Increment(ref 578.579.number)));

		// Token: 0x040009EA RID: 2538
		private IWindowInfo iWindowInfo2;

		// Token: 0x040009EB RID: 2539
		private bool flag;

		// Token: 0x040009EC RID: 2540
		private int number2;
	}
}
