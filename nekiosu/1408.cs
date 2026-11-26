using System;

// Token: 0x02000AAA RID: 2730
public sealed class 1408 : 1474
{
	// Token: 0x06004BCC RID: 19404 RVA: 0x001DFA8E File Offset: 0x001DDC8E
	public 1408() : base(1662.11)
	{
		this.Initialize();
	}

	// Token: 0x06004BCD RID: 19405 RVA: 0x001DFAB7 File Offset: 0x001DDCB7
	private float 1()
	{
		return (float)((double)(this.7 - 0.5f) * 3.141592653589793);
	}

	// Token: 0x06004BCE RID: 19406 RVA: 0x001DFAD4 File Offset: 0x001DDCD4
	public override void Draw()
	{
		if (this.4 <= 0f || this.8 == 0f)
		{
			return;
		}
		this.8 = (float)Math.Min((double)this.8, 1.0);
		try
		{
			float num = (float)((double)this.8 * 6.283185307179586 + (double)this.1());
			float <<EMPTY_NAME>> = this.6 * 1662.70.3();
			208 2 = this.3 * 1662.70.3();
			float num2;
			float num3;
			if (num < this.1())
			{
				num2 = num;
				num3 = this.1();
			}
			else
			{
				num2 = this.1();
				num3 = num;
			}
			if (num3 > num2)
			{
				1379.24.3();
				if (this.9 == null)
				{
					this.9 = new 1407<1398>(42, 1, 6);
				}
				this.9.5(new 1398
				{
					Position = 2,
					Colour = this.5
				});
				208 3;
				for (float num4 = num2; num4 < num3; num4 += 0.15707964f)
				{
					3 = new 208((float)Math.Cos((double)num4), (float)Math.Sin((double)num4)) * <<EMPTY_NAME>>;
					this.9.5(new 1398
					{
						Position = 2 + 3,
						Colour = this.5
					});
				}
				3 = new 208((float)Math.Cos((double)num3), (float)Math.Sin((double)num3)) * <<EMPTY_NAME>>;
				this.9.5(new 1398
				{
					Position = 2 + 3,
					Colour = this.5
				});
				this.9.6();
				1379.24.4();
			}
		}
		catch (InvalidOperationException)
		{
		}
	}

	// Token: 0x04003869 RID: 14441
	internal 208 3;

	// Token: 0x0400386A RID: 14442
	internal float 4 = 1f;

	// Token: 0x0400386B RID: 14443
	internal 198 5;

	// Token: 0x0400386C RID: 14444
	internal float 6 = 10f;

	// Token: 0x0400386D RID: 14445
	internal float 7;

	// Token: 0x0400386E RID: 14446
	internal float 8;

	// Token: 0x0400386F RID: 14447
	private 1407<1398> 9;
}
