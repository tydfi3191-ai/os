using System;

// Token: 0x020007CE RID: 1998
public sealed class 1872 : 1866
{
	// Token: 0x06003A2B RID: 14891 RVA: 0x0016E4D4 File Offset: 0x0016C6D4
	public 1872(2039 1, 208 2, int 3, bool 4, 1245 5, string 6) : base(8, 2, 3, 4, 5, "drop")
	{
		1872.1873 7 = new 1872.1873();
		this.30.ForEach(delegate(1433 1)
		{
			1.15 *= 0.4f;
		});
		7.1 = new 1445(1456.Rotation, 0f, 0f, this.1 - this.28.2, this.1 + 2000, (1046)0);
		7.1.5 = (float)7.1.1() / 200f;
		this.30.ForEach(new Action<1433>(7.8));
	}

	// Token: 0x06003A2C RID: 14892 RVA: 0x0000FF75 File Offset: 0x0000E175
	internal override bool BreaksComboOnMiss()
	{
		return false;
	}

	// Token: 0x06003A2D RID: 14893 RVA: 0x0016E58C File Offset: 0x0016C78C
	internal override void PlayHitSound()
	{
		1226.29(1226.48("slidertick", false, false, 1226.2 ? ((1416)3) : ((1416)7)), 100, 0f, false, 1f, true);
	}

	// Token: 0x06003A2E RID: 14894 RVA: 0x0016E5B9 File Offset: 0x0016C7B9
	internal override 2149 GetOrCalculateJudgement()
	{
		this.11 = true;
		this.14 = (this.46 ? ((2149)16) : ((2149)32));
		this.ApplyJudgementAnimation(this.14 > (2149)0);
		return this.14;
	}

	// Token: 0x020007CF RID: 1999
	[Serializable]
	public sealed class 1874
	{
		// Token: 0x04002AE7 RID: 10983
		public static readonly 1872.1874 instance = new 1872.1874();

		// Token: 0x04002AE8 RID: 10984
		public static Action<1433> action;
	}

	// Token: 0x020007D0 RID: 2000
	public sealed class 1873
	{
		// Token: 0x06003A31 RID: 14897 RVA: 0x0016E5F7 File Offset: 0x0016C7F7
		internal void 1(1433 1)
		{
			1.3.Add(this.1);
		}

		// Token: 0x04002AE9 RID: 10985
		public 1445 1;
	}
}
