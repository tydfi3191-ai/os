using System;
using System.Threading;

// Token: 0x0200040A RID: 1034
public sealed class 1260 : 2535
{
	// Token: 0x1700022F RID: 559
	// (get) Token: 0x06002070 RID: 8304 RVA: 0x000898F4 File Offset: 0x00087AF4
	internal bool IsDisposed
	{
		get
		{
			return this.8;
		}
	}

	// Token: 0x06002071 RID: 8305 RVA: 0x000898FE File Offset: 0x00087AFE
	public 1260(1189 1, 1300 2 = null) : base(false)
	{
		1662.111 = true;
		this.4 = 1;
		this.5 = 2;
		this.6 = 1662.17(new 1189(this.1));
	}

	// Token: 0x06002072 RID: 8306 RVA: 0x00089934 File Offset: 0x00087B34
	private new void 1()
	{
		if (!this.8)
		{
			bool <<EMPTY_NAME>> = true;
			try
			{
				this.4();
			}
			catch (Exception ex)
			{
				<<EMPTY_NAME>> = false;
				this.7 = ex;
			}
			if (!this.8)
			{
				this.3(<<EMPTY_NAME>>, true);
			}
		}
	}

	// Token: 0x06002073 RID: 8307 RVA: 0x00089988 File Offset: 0x00087B88
	internal void 2()
	{
		this.3(true, false);
	}

	// Token: 0x06002074 RID: 8308 RVA: 0x00089994 File Offset: 0x00087B94
	private void 3(bool 1, bool 2)
	{
		1260.1261 3 = new 1260.1261();
		3.1 = this;
		3.2 = 2;
		3.3 = 1;
		if (!this.3 || 3.3)
		{
			1662.89.Schedule(new 1189(3.Finish), false);
		}
	}

	// Token: 0x06002075 RID: 8309 RVA: 0x000899E4 File Offset: 0x00087BE4
	protected override void Dispose(bool 1)
	{
		this.8 = true;
		this.6.Method134352();
		while (!this.6.Method13423())
		{
			Thread.Sleep(50);
		}
		1662.111 = false;
		base.Dispose(1);
	}

	// Token: 0x04001100 RID: 4352
	public bool 3;

	// Token: 0x04001101 RID: 4353
	private 1189 4;

	// Token: 0x04001102 RID: 4354
	private 1300 5;

	// Token: 0x04001103 RID: 4355
	private 373 6;

	// Token: 0x04001104 RID: 4356
	public Exception 7;

	// Token: 0x04001105 RID: 4357
	private volatile bool 8;

	// Token: 0x0200040B RID: 1035
	public sealed class 1261
	{
		// Token: 0x06002076 RID: 8310 RVA: 0x00089A20 File Offset: 0x00087C20
		internal void Finish()
		{
			if (!this.1.8)
			{
				this.1.3 = (!(this.1.5 != null & this.2) || this.1.5(this.3));
				if (this.1.3)
				{
					1662.111 = false;
				}
			}
		}

		// Token: 0x04001106 RID: 4358
		public 1260 1;

		// Token: 0x04001107 RID: 4359
		public bool 2;

		// Token: 0x04001108 RID: 4360
		public bool 3;
	}
}
