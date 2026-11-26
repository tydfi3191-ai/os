using System;
using System.Runtime.InteropServices;

// Token: 0x02000319 RID: 793
[ComVisible(false)]
public sealed class 740
{
	// Token: 0x060017D7 RID: 6103 RVA: 0x00053BD0 File Offset: 0x00051DD0
	public bool Method11825(string 1, Exception 2)
	{
		bool result = false;
		496 recoveredType = this._recoveredType09649319;
		if (recoveredType != null)
		{
			782 3 = new 782(1, 2);
			recoveredType(this, 3);
			result = 3.GetFlag9992_12767();
		}
		return result;
	}

	// Token: 0x060017D8 RID: 6104 RVA: 0x00053C04 File Offset: 0x00051E04
	public bool Method11826(string 1, Exception 2)
	{
		719 recoveredType = this._recoveredType20139320;
		bool flag = recoveredType != null;
		if (flag)
		{
			782 3 = new 782(1, 2);
			recoveredType(this, 3);
			flag = 3.GetFlag9992_12767();
		}
		return flag;
	}

	// Token: 0x060017D9 RID: 6105 RVA: 0x00053C38 File Offset: 0x00051E38
	public bool Method11827(string 1)
	{
		bool result = true;
		487 recoveredType = this._recoveredType08789316;
		if (recoveredType != null)
		{
			759 2 = new 759(1);
			recoveredType(this, 2);
			result = 2.GetFlag9563_12246();
		}
		return result;
	}

	// Token: 0x060017DA RID: 6106 RVA: 0x00053C68 File Offset: 0x00051E68
	public bool Method11828(string 1)
	{
		bool result = true;
		376 recoveredType = this._recoveredType03549318;
		if (recoveredType != null)
		{
			759 2 = new 759(1);
			recoveredType(this, 2);
			result = 2.GetFlag9563_12246();
		}
		return result;
	}

	// Token: 0x060017DB RID: 6107 RVA: 0x00053C98 File Offset: 0x00051E98
	public bool Method11829(string 1, bool 2)
	{
		bool result = true;
		444 recoveredType = this._recoveredType06809315;
		if (recoveredType != null)
		{
			565 3 = new 565(1, 2);
			recoveredType(this, 3);
			result = 3.GetFlag9563_12246();
		}
		return result;
	}

	// Token: 0x060017DC RID: 6108 RVA: 0x00053CC9 File Offset: 0x00051EC9
	public TimeSpan GetTimeSpan9321_11830()
	{
		return this.timeSpan2;
	}

	// Token: 0x060017DD RID: 6109 RVA: 0x00053CD1 File Offset: 0x00051ED1
	public void SetTimeSpan9321_11831(TimeSpan 1)
	{
		this.timeSpan2 = 1;
	}

	// Token: 0x04000B27 RID: 2855
	public 444 _recoveredType06809315;

	// Token: 0x04000B28 RID: 2856
	public 487 _recoveredType08789316;

	// Token: 0x04000B29 RID: 2857
	public 380 _recoveredType03709317;

	// Token: 0x04000B2A RID: 2858
	public 376 _recoveredType03549318;

	// Token: 0x04000B2B RID: 2859
	public 496 _recoveredType09649319;

	// Token: 0x04000B2C RID: 2860
	public 719 _recoveredType20139320;

	// Token: 0x04000B2D RID: 2861
	private TimeSpan timeSpan2 = TimeSpan.FromSeconds(3.0);
}
