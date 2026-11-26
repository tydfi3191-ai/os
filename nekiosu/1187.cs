using System;
using System.Runtime.InteropServices;

// Token: 0x02000BE2 RID: 3042
[ComVisible(false)]
public sealed class 1187 : IComparable<1187>
{
	// Token: 0x06005319 RID: 21273 RVA: 0x0020A1DC File Offset: 0x002083DC
	public 1187(1189 1, long 2, int 3 = 0)
	{
		this.dueTime = 2;
		this.repeatInterval = 3;
		this.action = 1;
	}

	// Token: 0x0600531A RID: 21274 RVA: 0x0020A1F9 File Offset: 0x002083F9
	public bool 1()
	{
		return this.isCancelled;
	}

	// Token: 0x0600531B RID: 21275 RVA: 0x0020A201 File Offset: 0x00208401
	private void 2(bool 1)
	{
		this.isCancelled = 1;
	}

	// Token: 0x0600531C RID: 21276 RVA: 0x0020A20A File Offset: 0x0020840A
	public void Cancel()
	{
		this.2(true);
	}

	// Token: 0x0600531D RID: 21277 RVA: 0x0020A213 File Offset: 0x00208413
	public int CompareTo(1187 1)
	{
		if (this.dueTime != 1.dueTime)
		{
			return this.dueTime.CompareTo(1.dueTime);
		}
		return -1;
	}

	// Token: 0x04003F3C RID: 16188
	public 1189 action;

	// Token: 0x04003F3D RID: 16189
	private bool isCancelled;

	// Token: 0x04003F3E RID: 16190
	public long dueTime;

	// Token: 0x04003F3F RID: 16191
	public int repeatInterval;
}
