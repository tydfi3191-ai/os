using System;

// Token: 0x02000BAC RID: 2988
public class 1239 : 1474
{
	// Token: 0x0600522D RID: 21037 RVA: 0x0020631C File Offset: 0x0020451C
	public 1239() : base(1662.11)
	{
		this.Initialize();
	}

	// Token: 0x0600522E RID: 21038 RVA: 0x0020634A File Offset: 0x0020454A
	public override void Draw()
	{
		base.Draw();
	}

	// Token: 0x0600522F RID: 21039 RVA: 0x00206354 File Offset: 0x00204554
	public override void Update()
	{
		if (!this.6)
		{
			return;
		}
		if (this.4 != null || (1226.31 != null && !1226.10() && !1226.4))
		{
			try
			{
				1219.11((this.4 != null) ? this.4.2() : 1226.31.2(), this.5, -2147483645);
			}
			catch
			{
			}
			if (this.3 != 1f)
			{
				for (int i = 0; i < 1024; i++)
				{
					this.5[i] *= this.3;
				}
			}
		}
		else
		{
			float num = (float)Math.Pow(0.949999988079071, 1662.10);
			for (int j = 0; j < 1024; j++)
			{
				if (this.5[j] < 0.01f)
				{
					this.5[j] = 0f;
				}
				else
				{
					this.5[j] *= num;
				}
			}
		}
		base.Update();
	}

	// Token: 0x04003E9F RID: 16031
	internal float 3 = 1f;

	// Token: 0x04003EA0 RID: 16032
	internal 1240 4;

	// Token: 0x04003EA1 RID: 16033
	internal float[] 5 = new float[1024];

	// Token: 0x04003EA2 RID: 16034
	protected bool 6;
}
