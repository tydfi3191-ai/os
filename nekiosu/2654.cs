using System;

// Token: 0x02000463 RID: 1123
public sealed class 2654 : 2647, IComparable<2654>
{
	// Token: 0x06002267 RID: 8807 RVA: 0x000951D6 File Offset: 0x000933D6
	internal 2654(int 1)
	{
		this.8 = 1;
	}

	// Token: 0x06002268 RID: 8808 RVA: 0x000951E8 File Offset: 0x000933E8
	internal 2654(int 1, string 2, int 3, 2645 4, int 5)
	{
		this.12 = 5;
		this.10 = 2635.Sample;
		this.3 = 2;
		this.14 = 1;
		this.8 = 3;
		this.5 = 4;
		this.13 = new 1255(this.8, this.14, this.12, true);
	}

	// Token: 0x06002269 RID: 8809 RVA: 0x0000FF75 File Offset: 0x0000E175
	internal override bool LoadTextures()
	{
		return false;
	}

	// Token: 0x0600226A RID: 8810 RVA: 0x00053ADC File Offset: 0x00051CDC
	internal override void SetStartTime(int 1)
	{
		throw new NotImplementedException();
	}

	// Token: 0x0600226B RID: 8811 RVA: 0x00053ADC File Offset: 0x00051CDC
	internal override void SetEndTime(int 1)
	{
		throw new NotImplementedException();
	}

	// Token: 0x0600226C RID: 8812 RVA: 0x00095245 File Offset: 0x00093445
	internal override 2647 Clone()
	{
		return new 2654(this.14, this.3, this.8, this.5, this.12)
		{
			11 = this.11
		};
	}

	// Token: 0x0600226D RID: 8813 RVA: 0x00095278 File Offset: 0x00093478
	public override string ToString()
	{
		int num = this.8 / 1000 / 60;
		int num2 = (this.8 - num * 1000 * 60) / 1000;
		int num3 = this.8 - num * 1000 * 60 - num2 * 1000;
		return string.Format("{0}:{1}:{2}  {3}@{4}%", new object[]
		{
			num,
			num2,
			num3,
			this.3,
			this.12
		});
	}

	// Token: 0x0600226E RID: 8814 RVA: 0x00095309 File Offset: 0x00093509
	public int CompareTo(2654 1)
	{
		return this.8.CompareTo(1.8);
	}

	// Token: 0x040017D8 RID: 6104
	internal int 12;

	// Token: 0x040017D9 RID: 6105
	internal 1255 13;

	// Token: 0x040017DA RID: 6106
	internal int 14;

	// Token: 0x040017DB RID: 6107
	internal bool 15;
}
