using System;
using System.Collections.Generic;

// Token: 0x02000B05 RID: 2821
public sealed class 1486 : 1239
{
	// Token: 0x06004E72 RID: 20082 RVA: 0x001F04A0 File Offset: 0x001EE6A0
	public 1486()
	{
		this.6 = true;
		this.2(new List<198>());
		1304.171.SubscribeChanged(delegate(object 1, EventArgs 2)
		{
			foreach (1371 3 in this.16.28)
			{
				1433 4 = (1433)3;
				4.5 = false;
				4.16(1196.2(0, 500), (1046)0, 0);
			}
		});
	}

	// Token: 0x06004E73 RID: 20083 RVA: 0x001F0532 File Offset: 0x001EE732
	internal List<198> 1()
	{
		return this.19;
	}

	// Token: 0x06004E74 RID: 20084 RVA: 0x001F053A File Offset: 0x001EE73A
	private void 2(List<198> 1)
	{
		this.19 = 1;
	}

	// Token: 0x06004E75 RID: 20085 RVA: 0x001F0543 File Offset: 0x001EE743
	protected override void Dispose(bool 1)
	{
		this.16.Dispose();
		base.Dispose(1);
	}

	// Token: 0x06004E76 RID: 20086 RVA: 0x001F0557 File Offset: 0x001EE757
	public override void Draw()
	{
		this.16.22();
		base.Draw();
	}

	// Token: 0x06004E77 RID: 20087 RVA: 0x001F056C File Offset: 0x001EE76C
	public override void Update()
	{
		if (1662.82 > 20.0)
		{
			return;
		}
		base.Update();
		if (this.12)
		{
			if (2470.36)
			{
				this.16.7 = Math.Max(0f, this.16.7 - 0.01f * (float)1662.10);
			}
			else
			{
				this.16.7 = Math.Min(0.6f, this.16.7 + 0.01f * (float)1662.10);
			}
		}
		if (1304.171)
		{
			bool flag = this.13 && 1662.82 > 16.666666666666668;
			if (1662.23)
			{
				long num = this.17;
				this.17 = num + 1L;
				if (num % (flag ? 10L : 6L) == 0L)
				{
					int num2 = 0;
					while ((float)num2 < this.7)
					{
						this.3(false);
						num2++;
					}
				}
			}
		}
		if (this.10)
		{
			float num3 = 0f;
			int num4 = 40;
			for (int i = 0; i < num4; i++)
			{
				num3 += 2f * this.5[i] * (float)(num4 - i) / (float)num4;
			}
			this.7 = Math.Max(this.7, (float)Math.Min((double)num3 * 1.5, 6.0));
		}
		if (this.15)
		{
			this.7 *= 1f - 0.05f * (float)1662.10;
		}
		float num5 = (this.8 + this.7) * (float)1662.10 * 0.5f;
		foreach (1371 <<EMPTY_NAME>> in this.16.28)
		{
			1433 2 = (1433)<<EMPTY_NAME>>;
			1433 3 = 2;
			3.17.Y = 3.17.Y - num5 * (0.2f + this.14 * (1f - 2.15));
			if (!1662.47)
			{
				1433 4 = 2;
				4.17.Y = 4.17.Y + 1535.73.Y / 1662.70.3() * (0.2f + (1f - 2.15) / 1f) * 0.02f;
				1433 5 = 2;
				5.17.X = 5.17.X + 1535.73.X / 1662.70.3() * (0.2f + (1f - 2.15) / 1f) * 0.02f;
			}
			if (2.17.Y < -50f)
			{
				2.5 = false;
			}
		}
		if (this.11)
		{
			this.16.5 = (float)Math.Pow((double)Math.Max(this.10 > false, Math.Min(1f, num5 / 10f)), 3.0);
		}
	}

	// Token: 0x06004E78 RID: 20088 RVA: 0x001F0884 File Offset: 0x001EEA84
	private new void 3(bool 1)
	{
		if (this.9 && this.1().Count != 0)
		{
			198 2 = this.1()[1196.2(0, this.1().Count)];
			float num = 1196.7(0.2f, 1f);
			1433 3 = new 1433(1455.2("triangle", (!1308.1) ? ((1416)1) : ((1416)7), null), (1376)6, 1065.Centre, (1044)0, new 208(1196.6((float)1662.70.1()), 1 ? 1196.6((float)1662.70.2()) : ((float)1662.70.2() + 50f)), 0.8f - num * 0.01f, true, 198.White, null)
			{
				6 = 2,
				15 = num
			};
			this.16.12(3);
		}
	}

	// Token: 0x04003A7C RID: 14972
	internal float 7 = 100f;

	// Token: 0x04003A7D RID: 14973
	internal float 8 = 1f;

	// Token: 0x04003A7E RID: 14974
	internal bool 9 = true;

	// Token: 0x04003A7F RID: 14975
	internal bool 10 = true;

	// Token: 0x04003A80 RID: 14976
	internal bool 11 = true;

	// Token: 0x04003A81 RID: 14977
	internal bool 12 = true;

	// Token: 0x04003A82 RID: 14978
	internal bool 13 = true;

	// Token: 0x04003A83 RID: 14979
	internal float 14 = 1.4f;

	// Token: 0x04003A84 RID: 14980
	private bool 15 = true;

	// Token: 0x04003A85 RID: 14981
	private 1436 16 = new 1436(true);

	// Token: 0x04003A86 RID: 14982
	private long 17;

	// Token: 0x04003A87 RID: 14983
	private 208? 18;

	// Token: 0x04003A88 RID: 14984
	private List<198> 19;
}
