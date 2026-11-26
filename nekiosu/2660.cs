using System;
using System.Runtime.InteropServices;
using System.Threading;

// Token: 0x02000448 RID: 1096
[ComVisible(false)]
public sealed class 2660 : 2662
{
	// Token: 0x060021E7 RID: 8679 RVA: 0x000922C1 File Offset: 0x000904C1
	public 2660(1186 1)
	{
		this.1 = 1;
	}

	// Token: 0x060021E8 RID: 8680 RVA: 0x000922D0 File Offset: 0x000904D0
	public override bool Schedule(1189 1, bool 2 = false)
	{
		2660.2661 3 = new 2660.2661();
		3.1 = this;
		3.2 = 1;
		3.3 = 2;
		if (!this.1.1() || this.IsOnOwnerThread())
		{
			base.Schedule(3.2, 3.3);
			return true;
		}
		ThreadPool.QueueUserWorkItem(new WaitCallback(3.1));
		return false;
	}

	// Token: 0x0400174F RID: 5967
	private new 1186 1;

	// Token: 0x02000449 RID: 1097
	public sealed class 2661
	{
		// Token: 0x060021E9 RID: 8681 RVA: 0x00092338 File Offset: 0x00090538
		internal void 1(object 1)
		{
			if (this.1.1.1())
			{
				this.1.1.Invoke(new 1189(this.2.Invoke));
				return;
			}
			this.1.Schedule(this.2, this.3);
		}

		// Token: 0x04001750 RID: 5968
		public 2660 1;

		// Token: 0x04001751 RID: 5969
		public 1189 2;

		// Token: 0x04001752 RID: 5970
		public bool 3;
	}
}
