using System;

// Token: 0x02000224 RID: 548
public abstract class 602
{
	// Token: 0x0600111A RID: 4378 RVA: 0x0003D5B7 File Offset: 0x0003B7B7
	public static uint Method8321(uint 1)
	{
		1 -= 2U;
		if (1 < 4U)
		{
			return 1;
		}
		return 3U;
	}

	// Token: 0x02000225 RID: 549
	public struct 603
	{
		// Token: 0x0600111C RID: 4380 RVA: 0x0003D5C5 File Offset: 0x0003B7C5
		public void SetNumber6486_8315()
		{
			this.number = 0U;
		}

		// Token: 0x0600111D RID: 4381 RVA: 0x0003D5CE File Offset: 0x0003B7CE
		public void Method8316()
		{
			if (this.number < 4U)
			{
				this.number = 0U;
				return;
			}
			if (this.number < 10U)
			{
				this.number -= 3U;
				return;
			}
			this.number -= 6U;
		}

		// Token: 0x0600111E RID: 4382 RVA: 0x0003D608 File Offset: 0x0003B808
		public void SetNumber6486_8317()
		{
			this.number = ((this.number < 7U) ? 7U : 10U);
		}

		// Token: 0x0600111F RID: 4383 RVA: 0x0003D61E File Offset: 0x0003B81E
		public void SetNumber6486_8318()
		{
			this.number = ((this.number < 7U) ? 8U : 11U);
		}

		// Token: 0x06001120 RID: 4384 RVA: 0x0003D634 File Offset: 0x0003B834
		public void SetNumber6486_8319()
		{
			this.number = ((this.number < 7U) ? 9U : 11U);
		}

		// Token: 0x06001121 RID: 4385 RVA: 0x0003D64B File Offset: 0x0003B84B
		public bool Method8320()
		{
			return this.number < 7U;
		}

		// Token: 0x04000894 RID: 2196
		public uint number;
	}
}
