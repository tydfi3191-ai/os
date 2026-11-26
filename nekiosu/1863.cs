using System;

// Token: 0x020007C3 RID: 1987
public sealed class 1863 : 1866
{
	// Token: 0x060039EC RID: 14828 RVA: 0x0016D53C File Offset: 0x0016B73C
	public 1863(2039 1, 208 2, int 3, bool 4, 1245 5, string 6) : base(8, 2, 3, 4, 5, "drop")
	{
		1863.1864 7 = new 1863.1864();
		this.30.ForEach(delegate(1433 1)
		{
			1.15 *= 0.8f;
		});
		float num = (float)(this.28.33 as 1870).7.3() * 2f;
		7.1 = new 1445(1456.Rotation, num, 0f, this.1 - this.28.2, this.1 + 2000, (1046)0);
		7.1.5 = (float)7.1.1() / 200f + num;
		this.30.ForEach(new Action<1433>(7.8));
	}

	// Token: 0x060039ED RID: 14829 RVA: 0x0016D614 File Offset: 0x0016B814
	internal override void PlayHitSound()
	{
		1259 <<EMPTY_NAME>> = this.28.21.92((double)(this.1 + 2));
		1254 2 = (this.35 == 1254.None) ? <<EMPTY_NAME>>.4 : this.35;
		1226.33(new 1244(this.4, 2, <<EMPTY_NAME>>.2, <<EMPTY_NAME>>.6, (this.36 == 1254.None) ? 2 : this.36), this.GetSamplePan());
	}

	// Token: 0x060039EE RID: 14830 RVA: 0x0016D688 File Offset: 0x0016B888
	internal override 2149 GetOrCalculateJudgement()
	{
		this.11 = true;
		if (this.46)
		{
			this.14 = (2149)2048;
			this.PlayHitSound();
		}
		else
		{
			this.14 = (2149)(-131072);
		}
		this.ApplyJudgementAnimation(this.14 > (2149)0);
		return this.14;
	}

	// Token: 0x020007C4 RID: 1988
	[Serializable]
	public sealed class 1865
	{
		// Token: 0x04002ACA RID: 10954
		public static readonly 1863.1865 instance = new 1863.1865();

		// Token: 0x04002ACB RID: 10955
		public static Action<1433> action;
	}

	// Token: 0x020007C5 RID: 1989
	public sealed class 1864
	{
		// Token: 0x060039F1 RID: 14833 RVA: 0x0016D6E3 File Offset: 0x0016B8E3
		internal void 1(1433 1)
		{
			1.3.Add(this.1);
		}

		// Token: 0x04002ACC RID: 10956
		public 1445 1;
	}
}
