using System;
using System.Collections.Generic;

// Token: 0x0200055F RID: 1375
public sealed class 2479 : 1239
{
	// Token: 0x06002A31 RID: 10801 RVA: 0x000DDD16 File Offset: 0x000DBF16
	internal float 1()
	{
		return this.9;
	}

	// Token: 0x06002A32 RID: 10802 RVA: 0x000DDD20 File Offset: 0x000DBF20
	internal void 2(float 1)
	{
		if (1 != this.9)
		{
			this.9 = 1;
			for (int i = 0; i < 1024; i++)
			{
				float num = this.16[i];
				1433 2 = this.8[i];
				2.17 = this.10 + this.1() * this.17[i];
				2.14 = num;
			}
		}
	}

	// Token: 0x06002A33 RID: 10803 RVA: 0x000DDD90 File Offset: 0x000DBF90
	public override void Initialize()
	{
		base.Initialize();
		this.6 = true;
		for (int i = 0; i < 1024; i++)
		{
			float num = 6.2831855f * (0.4f + (float)i / 1024f * (this.13 * 0.5f));
			this.16[i] = num;
			this.17[i] = new 208((float)Math.Cos((double)num), (float)Math.Sin((double)num));
			1433 <<EMPTY_NAME>> = new 1433(1455.2("menu-vis", (1416)1, null), (1376)6, 1065.CentreLeft, (1044)0, new 208(0f, 0.5f * (float)i))
			{
				16 = 0.2f,
				28 = true,
				20 = new 208(0f, 0.5f),
				5 = true,
				6 = 2479.14
			};
			this.7.12(<<EMPTY_NAME>>);
			this.8.Add(<<EMPTY_NAME>>);
		}
	}

	// Token: 0x06002A34 RID: 10804 RVA: 0x000DDE84 File Offset: 0x000DC084
	protected override void Dispose(bool 1)
	{
		this.7.Dispose();
		base.Dispose(1);
	}

	// Token: 0x06002A35 RID: 10805 RVA: 0x000DDE98 File Offset: 0x000DC098
	public override void Draw()
	{
		this.7.22();
		base.Draw();
	}

	// Token: 0x06002A36 RID: 10806 RVA: 0x000DDEAC File Offset: 0x000DC0AC
	public override void Update()
	{
		base.Update();
		this.3(1662.82);
	}

	// Token: 0x06002A37 RID: 10807 RVA: 0x000DDEC0 File Offset: 0x000DC0C0
	private new void 3(double 1)
	{
		if (1 > 1000.0)
		{
			return;
		}
		while (1 > 0.0)
		{
			this.19 += 1;
			double num = Math.Max(0.0, this.19 - 10.0);
			1 -= num;
			this.4(1);
			if (num == 0.0)
			{
				break;
			}
			this.19 = 0.0;
			this.18 = (this.18 + 50.0) % (double)this.5.Length;
			1 = num;
		}
	}

	// Token: 0x06002A38 RID: 10808 RVA: 0x000DDF60 File Offset: 0x000DC160
	private new void 4(double 1)
	{
		double num = Math.Pow(0.949999988079071, 1 / 16.666666666666668);
		for (int i = 1023; i >= 0; i--)
		{
			1433 2 = this.8[this.5.Length - i - 1];
			2.20.X = (float)((double)Math.Max(2.20.X, this.5[(int)(((double)i + this.18) % (double)this.5.Length)] * 3f) * num);
			if (2.20.X < 0.01f)
			{
				2.20.X = 0f;
				2.16 = 0f;
			}
			else
			{
				2.16 = Math.Max(0f, this.11 * this.12 * Math.Min(1f, (2.20.X - 0.04f) / 0.08f));
			}
		}
	}

	// Token: 0x06002A39 RID: 10809 RVA: 0x000DE064 File Offset: 0x000DC264
	internal new void 5(198 1, bool 2)
	{
		2479.2480 3 = new 2479.2480();
		3.1 = 1;
		3.2 = 2;
		if (!1308.1 || 2630.20())
		{
			3.1 = 2479.15;
		}
		this.8.ForEach(new Action<1433>(3.1));
	}

	// Token: 0x04001EE4 RID: 7908
	private 1436 7 = new 1436(true)
	{
		22 = false
	};

	// Token: 0x04001EE5 RID: 7909
	private List<1433> 8 = new List<1433>();

	// Token: 0x04001EE6 RID: 7910
	private float 9;

	// Token: 0x04001EE7 RID: 7911
	internal 208 10;

	// Token: 0x04001EE8 RID: 7912
	internal float 11 = 1f;

	// Token: 0x04001EE9 RID: 7913
	internal float 12 = 0.4f;

	// Token: 0x04001EEA RID: 7914
	internal float 13 = 8f;

	// Token: 0x04001EEB RID: 7915
	private static 198 14 = new 198(0, 114, byte.MaxValue);

	// Token: 0x04001EEC RID: 7916
	private static 198 15 = new 198(128, 128, 160);

	// Token: 0x04001EED RID: 7917
	private float[] 16 = new float[1024];

	// Token: 0x04001EEE RID: 7918
	private 208[] 17 = new 208[1024];

	// Token: 0x04001EEF RID: 7919
	private double 18;

	// Token: 0x04001EF0 RID: 7920
	private double 19;

	// Token: 0x02000560 RID: 1376
	public sealed class 2480
	{
		// Token: 0x06002A3C RID: 10812 RVA: 0x000DE157 File Offset: 0x000DC357
		internal void 1(1433 1)
		{
			1.39(this.1, (!this.2) ? 200 : 0, false, (1046)0);
		}

		// Token: 0x04001EF1 RID: 7921
		public 198 1;

		// Token: 0x04001EF2 RID: 7922
		public bool 2;
	}
}
