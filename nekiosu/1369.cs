using System;
using System.Collections.Generic;

// Token: 0x02000A85 RID: 2693
public sealed class 1369
{
	// Token: 0x06004A83 RID: 19075 RVA: 0x001D8AB4 File Offset: 0x001D6CB4
	internal 1369()
	{
		this.1 = new 1411<1396>(2048, 35048);
		this.4 = new float[2048];
		this.5 = new bool[2048];
	}

	// Token: 0x06004A84 RID: 19076 RVA: 0x001D8B1F File Offset: 0x001D6D1F
	internal void 1(208 1)
	{
		this.12.Enqueue(1);
	}

	// Token: 0x06004A85 RID: 19077 RVA: 0x001D8B30 File Offset: 0x001D6D30
	private void 2(208 1)
	{
		1381 2 = 2630.12;
		if (2 != null)
		{
			float num = (float)2.3() * 1662.70.9() * 1535.51.15 * 1535.51.20.X;
			1058 3 = new 1058(0f, 0f, (float)2.1() / (float)1454.1(2.1()), (float)2.2() / (float)1454.1(2.2()));
			int num2 = this.11 * 4;
			float num3 = this.2 + 1f;
			this.1.1[num2].Position = 1 + new 208((0f - num) / 2f, (0f - num) / 2f);
			this.1.1[num2].TexturePosition = new 208(0f, 0f);
			this.1.1[num2].Colour = 198.White;
			this.1.1[num2].Time = num3;
			this.1.1[num2 + 1].Position = 1 + new 208((0f - num) / 2f, num / 2f);
			this.1.1[num2 + 1].TexturePosition = new 208(0f, 3.Height);
			this.1.1[num2 + 1].Colour = 198.White;
			this.1.1[num2 + 1].Time = num3;
			this.1.1[num2 + 2].Position = 1 + new 208(num / 2f, num / 2f);
			this.1.1[num2 + 2].TexturePosition = new 208(3.Width, 3.Height);
			this.1.1[num2 + 2].Colour = 198.White;
			this.1.1[num2 + 2].Time = num3;
			this.1.1[num2 + 3].Position = 1 + new 208(num / 2f, (0f - num) / 2f);
			this.1.1[num2 + 3].TexturePosition = new 208(3.Width, 0f);
			this.1.1[num2 + 3].Colour = 198.White;
			this.1.1[num2 + 3].Time = num3;
			this.4[this.11] = num3;
			this.5[this.11] = true;
			this.11 = (this.11 + 1) % 2048;
		}
	}

	// Token: 0x06004A86 RID: 19078 RVA: 0x001D8E48 File Offset: 0x001D7048
	private int 3(int[] 1, float 2)
	{
		int num = 0;
		for (int i = 0; i < 2048; i++)
		{
			if (this.4[i] - this.2 >= 2 || this.5[i])
			{
				if (num % 2 == 0)
				{
					1[num] = i;
					num++;
				}
			}
			else if (num % 2 == 1)
			{
				1[num] = i;
				num++;
			}
		}
		if (num % 2 == 1)
		{
			1[num] = 2048;
			num++;
		}
		return num;
	}

	// Token: 0x06004A87 RID: 19079 RVA: 0x001D8EB4 File Offset: 0x001D70B4
	public void 4()
	{
		if (!1304.220)
		{
			while (this.12.Count > 0)
			{
				this.2(this.12.Dequeue());
			}
			this.2 = (float)((double)(1662.33 - this.3) / 500.0);
			int num = (1662.87() > 60000 || !1662.11.2()) ? 10000 : 1000000;
			if (this.2 > (float)num)
			{
				this.5();
			}
			this.8 = this.3(this.6, 1f);
			this.9 = this.3(this.7, 0f);
		}
	}

	// Token: 0x06004A88 RID: 19080 RVA: 0x001D8F74 File Offset: 0x001D7174
	private void 5()
	{
		int <<EMPTY_NAME>> = 1662.33;
		this.3 = <<EMPTY_NAME>>;
		for (int i = 0; i < 2048; i++)
		{
			this.4[i] -= this.2;
			this.5[i] = true;
			int num = i * 4;
			1396[] array = this.1.1;
			int num2 = num;
			array[num2].Time = array[num2].Time - this.2;
			1396[] array2 = this.1.1;
			int num3 = num + 1;
			array2[num3].Time = array2[num3].Time - this.2;
			1396[] array3 = this.1.1;
			int num4 = num + 2;
			array3[num4].Time = array3[num4].Time - this.2;
			1396[] array4 = this.1.1;
			int num5 = num + 3;
			array4[num5].Time = array4[num5].Time - this.2;
		}
		this.2 = 0f;
	}

	// Token: 0x06004A89 RID: 19081 RVA: 0x001D9058 File Offset: 0x001D7258
	public void 6()
	{
		if (1304.220)
		{
			return;
		}
		1381 <<EMPTY_NAME>> = 2630.12;
		if (this.9 == 0 || ((<<EMPTY_NAME>> != null) ? <<EMPTY_NAME>>.gpuTexture : null) == null || <<EMPTY_NAME>>.5() || !<<EMPTY_NAME>>.gpuTexture.TryBind())
		{
			return;
		}
		1369.10.1["g_FadeClock"] = this.2;
		1369.10.3();
		1379.35(770, 1);
		for (int i = 0; i < this.8; i += 2)
		{
			for (int j = this.6[i]; j < this.6[i + 1]; j++)
			{
				this.5[j] = false;
			}
			this.1.7(this.6[i] * 4, this.6[i + 1] * 4);
		}
		for (int k = 0; k < this.9; k += 2)
		{
			this.1.5(this.7[k] * 4, this.7[k + 1] * 4);
		}
		1369.10.4();
	}

	// Token: 0x0400378A RID: 14218
	private 1509<1396> 1;

	// Token: 0x0400378B RID: 14219
	private float 2;

	// Token: 0x0400378C RID: 14220
	private int 3;

	// Token: 0x0400378D RID: 14221
	private float[] 4;

	// Token: 0x0400378E RID: 14222
	private bool[] 5;

	// Token: 0x0400378F RID: 14223
	private int[] 6 = new int[4];

	// Token: 0x04003790 RID: 14224
	private int[] 7 = new int[4];

	// Token: 0x04003791 RID: 14225
	private int 8;

	// Token: 0x04003792 RID: 14226
	private int 9;

	// Token: 0x04003793 RID: 14227
	private static readonly 1426 10 = 1425.6(1510.CursorTrail, 1049.Texture, false);

	// Token: 0x04003794 RID: 14228
	private int 11;

	// Token: 0x04003795 RID: 14229
	private Queue<208> 12 = new Queue<208>();
}
