using System;
using System.Collections.Generic;

// Token: 0x020005A6 RID: 1446
public sealed class 2333 : 1474
{
	// Token: 0x06002CF5 RID: 11509 RVA: 0x000FB3BD File Offset: 0x000F95BD
	internal 2333(1803 1, 2263 2, 208 3) : base(1)
	{
		this.3 = 2;
		this.4 = 2.76;
		this.7 = 3;
		this.8 = 34f;
		this.Initialize();
	}

	// Token: 0x06002CF6 RID: 11510 RVA: 0x000FB3FC File Offset: 0x000F95FC
	public override void Initialize()
	{
		this.5 = new 1436(true);
		this.5.12(new 1433(1455.2("editor-metronome-bg", (1416)1, null), (1376)8, 1065.TopLeft, (1044)0, this.7, 0f, true, 198.White, null));
		float num = this.7.X - 179f;
		float <<EMPTY_NAME>> = this.7.Y + 18f;
		this.6 = new 2333.2334[]
		{
			new 2333.2334(new 208(num + this.8 * 3f, <<EMPTY_NAME>>)),
			new 2333.2334(new 208(num + this.8 * 2f, <<EMPTY_NAME>>)),
			new 2333.2334(new 208(num + this.8, <<EMPTY_NAME>>)),
			new 2333.2334(new 208(num, <<EMPTY_NAME>>))
		};
		this.5.14<2333.2334>(this.6);
		num = this.7.X - 60f;
		<<EMPTY_NAME>> = this.7.Y + this.8;
		1361 4 = new 1361(1568.1(2679.EditorModeTiming_TapHere), new 208(num, <<EMPTY_NAME>>), new 208(136f, 25f), 1f, 198.SkyBlue, delegate(object 1, EventArgs 2)
		{
			this.2();
		}, true, true, new float?(12f), true);
		4.5 = false;
		4.6(1568.1(2679.EditorModeTiming_TapHereTooltip));
		this.5.14<1433>(4.1);
		num = this.7.X - 3f;
		<<EMPTY_NAME>> = this.7.Y + 4f;
		1361 3 = new 1361(1568.1(2679.General_Reset), new 208(num, <<EMPTY_NAME>>), new 208(58f, 58f), 1f, 198.Orange, new EventHandler(this.1), true, true, new float?(12f), true);
		this.5.14<1433>(3.1);
	}

	// Token: 0x06002CF7 RID: 11511 RVA: 0x000FB5F8 File Offset: 0x000F97F8
	private void 1(object 1, EventArgs 2)
	{
		this.4.20();
	}

	// Token: 0x06002CF8 RID: 11512 RVA: 0x000FB608 File Offset: 0x000F9808
	internal void 2()
	{
		if (1226.32 != (1042)1)
		{
			1226.Pause();
		}
		this.4.10.16 = 3;
		if (this.9.Count > 0 && 1226.16 == this.9[this.9.Count - 1])
		{
			return;
		}
		if (this.9.Count > 0 && this.9[this.9.Count - 1] > 1226.16)
		{
			this.9.Clear();
		}
		if (this.9.Count == 1 && 1226.16 - this.9[0] > 1000)
		{
			this.9.Clear();
		}
		if (this.9.Count == 0)
		{
			1763.2(1568.1(2679.EditorModeTiming_Tap_TapInTimeToTheBeat), 5000, (1389)0);
		}
		else if (this.9.Count == 2)
		{
			1763.2(1568.1(2679.EditorModeTiming_Tap_KeepGoing), 5000, (1389)0);
		}
		else if (this.9.Count >= 4)
		{
			if (this.9.Count < 8)
			{
				1763.2(string.Format(1568.1(2679.EditorModeTiming_Tap_TapMoreTimes), 7 - this.9.Count), 5000, (1389)0);
			}
			else if (this.9.Count == 8)
			{
				1763.2(1568.1(2679.EditorModeTiming_Tap_TapToIncreaseAccuracy), 5000, (1389)0);
			}
			else if (this.9.Count == 16)
			{
				1763.2(string.Format(1568.1(2679.EditorModeTiming_Tap_BPMSensitivity), 0), 5000, (1389)0);
			}
			else if (this.9.Count == 32)
			{
				1763.2(string.Format(1568.1(2679.EditorModeTiming_Tap_BPMSensitivity), 1), 5000, (1389)0);
			}
			else if (this.9.Count == 64)
			{
				1763.2(string.Format(1568.1(2679.EditorModeTiming_Tap_BPMSensitivity), 2), 5000, (1389)0);
			}
		}
		this.9.Add(1226.16);
		int num = 0;
		if (this.9.Count >= 8)
		{
			IL_231:
			while (this.9.Count >= 2)
			{
				double num2 = (double)((float)(this.9[this.9.Count - 1] - this.9[1]) / ((float)this.9.Count - 2f));
				for (int i = 0; i < this.9.Count - 1; i++)
				{
					int num3 = this.9[i + 1] - this.9[i];
					if ((double)Math.Abs(num3) > num2 * 1.4)
					{
						this.9.RemoveAt(i + 1);
						if (i < this.9.Count - 1)
						{
							num3 = this.9[i + 1] - this.9[i];
							this.9.RemoveAt(i + 1);
						}
						for (int j = i + 1; j < this.9.Count; j++)
						{
							List<int> list = this.9;
							int index = j;
							list[index] -= num3;
						}
						num++;
						goto IL_231;
					}
				}
				double num4 = 0.0;
				for (int k = 1; k < this.9.Count - 1; k++)
				{
					num4 += Math.Abs((double)this.9[k + 1] - ((double)this.9[k] + num2)) * (1.0 + (double)k / 64.0);
				}
				num4 /= (double)((float)this.9.Count - 1f);
				double num5 = ((double)(this.9[this.9.Count - 1] - this.9[1]) + num4) / (double)((float)this.9.Count - 2f);
				double num6 = ((double)(this.9[this.9.Count - 1] - this.9[1]) - num4) / (double)((float)this.9.Count - 2f);
				double num7 = 0.0;
				double num8 = 10000.0;
				while (num6 < num5)
				{
					double num9 = Math.Round(60000.0 / num6, (this.9.Count >= 64) ? 2 : ((this.9.Count >= 32) ? 1 : 0));
					if (Math.Abs(60000.0 / num9 - num2) < num8)
					{
						num8 = Math.Abs(60000.0 / num7 - num2);
						num7 = num9;
					}
					num6 += ((this.9.Count >= 64) ? 0.05 : ((this.9.Count < 32) ? 0.1 : 0.5));
				}
				double num10 = 60000.0 / num7;
				double <<EMPTY_NAME>> = -1.0;
				double num11 = 1000.0;
				int l = 0;
				while (l < this.9.Count - 1)
				{
					double num12 = (double)this.9[l] - num10 * (double)l;
					double num13 = 0.0;
					double num14 = 0.0;
					int num15 = 0;
					for (int m = 1; m < this.9.Count - 1; m++)
					{
						if (l != m)
						{
							num15++;
							num13 += num12 + num10 * (double)m - (double)this.9[m];
							num14 = Math.Max(num14, Math.Abs(num12 + num10 * (double)m - (double)this.9[m]));
						}
					}
					if (Math.Abs(num13) / (double)num15 <= 200.0)
					{
						if (num14 < num11)
						{
							num11 = num14;
							<<EMPTY_NAME>> = num12;
						}
						l++;
					}
					else
					{
						if (l == 0)
						{
							this.9.RemoveAt(l);
							for (int n = 0; n < this.9.Count; n++)
							{
								List<int> list = this.9;
								int index = n;
								list[index] -= (int)Math.Round(num2);
							}
							num++;
							goto IL_231;
						}
						l--;
						int num16 = this.9[l + 1] - this.9[l];
						this.9.RemoveAt(l + 1);
						if (l < this.9.Count - 1)
						{
							num16 = this.9[l + 1] - this.9[l];
							this.9.RemoveAt(l + 1);
						}
						for (int num17 = l + 1; num17 < this.9.Count; num17++)
						{
							List<int> list = this.9;
							int index = num17;
							list[index] -= num16;
						}
						num++;
						goto IL_231;
					}
				}
				double num18 = (double)this.9[this.9.Count - 1] - (double)(this.9.Count - 1) * num10;
				1226.77(60000.0 / num7);
				if (1226.79() == 0.0)
				{
					1226.80(<<EMPTY_NAME>>);
				}
				else
				{
					1226.80(1226.79() - (1226.79() - num18) / 2.0);
				}
				this.3.8.13 = true;
				if (1226.16 != this.9[this.9.Count - 1])
				{
					1226.4(this.9[this.9.Count - 1], false, false);
				}
				num2 -= num4;
				goto IL_816;
			}
			return;
		}
		IL_816:
		if (double.IsInfinity(1226.76()))
		{
			this.4.20();
		}
	}

	// Token: 0x06002CF9 RID: 11513 RVA: 0x000FBE42 File Offset: 0x000FA042
	internal void 3()
	{
		this.9.Clear();
	}

	// Token: 0x06002CFA RID: 11514 RVA: 0x000FBE50 File Offset: 0x000FA050
	public override void Draw()
	{
		byte <<EMPTY_NAME>> = 0;
		byte 2 = 0;
		byte b = 0;
		byte b2 = 0;
		byte b3 = 0;
		byte b4 = 0;
		if (1226.75() && (double)1226.16 >= 1226.79())
		{
			double num = 1226.64() % (1226.76() * (double)1226.84()) / 1226.76();
			if (num < 1.0)
			{
				<<EMPTY_NAME>> = (byte)(187.0 * (1.0 - num));
				2 = (byte)(255.0 * (1.0 - num));
				b = (byte)(51.0 * (1.0 - num));
			}
			else
			{
				num %= 3.0;
				if (num < 1.0)
				{
					b4 = (byte)(255.0 * (1.0 - num));
				}
				else if (num < 2.0)
				{
					b2 = (byte)(255.0 * (2.0 - num));
				}
				else if (num < 3.0)
				{
					b3 = (byte)(255.0 * (3.0 - num));
				}
			}
		}
		this.6[0].6 = new 198(<<EMPTY_NAME>>, 2, b, 0);
		this.6[1].6 = new 198(b2, b2, b2, 0);
		this.6[2].6 = new 198(b3, b3, b3, 0);
		this.6[3].6 = new 198(b4, b4, b4, 0);
		this.5.22();
	}

	// Token: 0x06002CFB RID: 11515 RVA: 0x000FBFE6 File Offset: 0x000FA1E6
	internal void 4()
	{
		this.5.Dispose();
	}

	// Token: 0x04002115 RID: 8469
	private 2263 3;

	// Token: 0x04002116 RID: 8470
	private 2366 4;

	// Token: 0x04002117 RID: 8471
	internal 1436 5;

	// Token: 0x04002118 RID: 8472
	private 2333.2334[] 6;

	// Token: 0x04002119 RID: 8473
	internal 208 7;

	// Token: 0x0400211A RID: 8474
	internal float 8;

	// Token: 0x0400211B RID: 8475
	private List<int> 9 = new List<int>();

	// Token: 0x020005A7 RID: 1447
	public sealed class 2334 : 1433
	{
		// Token: 0x06002CFD RID: 11517 RVA: 0x000FBFFC File Offset: 0x000FA1FC
		internal 2334(208 1) : base(1455.2("editor-metronome-beat-lighting", (1416)1, null), (1376)8, 1065.Centre, (1044)0, 1, 0.9f, true, 198.White, null)
		{
		}
	}
}
