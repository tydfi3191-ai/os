using System;
using System.IO;

// Token: 0x02000467 RID: 1127
public sealed class 2658 : 2647
{
	// Token: 0x06002283 RID: 8835 RVA: 0x000956E8 File Offset: 0x000938E8
	internal 2658(1447 1, string 2, int 3)
	{
		this.12 = 1;
		this.9 = true;
		this.10 = 2635.Video;
		this.3 = Path.GetFileName(2);
		this.7 = 1;
		this.8 = 3;
		this.6 = true;
	}

	// Token: 0x06002284 RID: 8836 RVA: 0x0000FF75 File Offset: 0x0000E175
	internal override bool LoadTextures()
	{
		return false;
	}

	// Token: 0x06002285 RID: 8837 RVA: 0x00095726 File Offset: 0x00093926
	internal override void SetStartTime(int 1)
	{
		if (this.12 != null)
		{
			this.12.50(1);
		}
		this.8 = 1;
	}

	// Token: 0x06002286 RID: 8838 RVA: 0x00053ADC File Offset: 0x00051CDC
	internal override void SetEndTime(int 1)
	{
		throw new NotImplementedException();
	}

	// Token: 0x06002287 RID: 8839 RVA: 0x00095743 File Offset: 0x00093943
	internal override 2647 Clone()
	{
		return new 2658(this.12, this.3, this.8);
	}

	// Token: 0x040017E7 RID: 6119
	internal 1447 12;
}
