using System;
using System.Collections.Generic;

// Token: 0x02000703 RID: 1795
[276]
public class 2141 : 2504
{
	// Token: 0x060034EF RID: 13551 RVA: 0x00145750 File Offset: 0x00143950
	public 2141(2486 1) : base(1)
	{
	}

	// Token: 0x060034F0 RID: 13552 RVA: 0x00145764 File Offset: 0x00143964
	internal override void Initialize()
	{
		this.36 = 1455.2("cursor-smoke", (1416)7, null);
		base.Initialize();
	}

	// Token: 0x060034F1 RID: 13553 RVA: 0x0014577E File Offset: 0x0014397E
	internal override 2039 CreateHitObjectManager()
	{
		if (2486.16())
		{
			return new 2133();
		}
		return new 2122(true);
	}

	// Token: 0x060034F2 RID: 13554 RVA: 0x00145794 File Offset: 0x00143994
	internal override void InitializeHealthDrain()
	{
		if (this.6 != null)
		{
			this.6.12 = this.CalculateHealthDrain();
			2023 <<EMPTY_NAME>> = 2486.88.8;
			2023 2 = 2023.HalfTime;
			if ((<<EMPTY_NAME>> & 2) > 2023.None)
			{
				this.6.12 *= 1939.19(2023.HalfTime);
			}
			base.InitializeHealthDrain();
		}
	}

	// Token: 0x060034F3 RID: 13555 RVA: 0x001457F8 File Offset: 0x001439F8
	internal override void PreloadJudgementTextures()
	{
		base.PreloadJudgementTextures();
		1455.5("particle50", (1416)7, true);
		1455.5("particle100", (1416)7, true);
		1455.5("particle300", (1416)7, true);
		1455.5("sliderpoint30", (1416)7, true);
		1455.5("sliderpoint10", (1416)7, true);
	}

	// Token: 0x060034F4 RID: 13556 RVA: 0x0014584C File Offset: 0x00143A4C
	internal override bool ShouldHideCursor()
	{
		if (!2486.14 && (this.5.31 + 1 >= this.5.35 || Math.Abs(this.5.34[this.5.31 + 1].1 - 1226.16) > 3000) && 208.Distance(1555.21(), this.30) < 3f && !1535.21 && !1535.50)
		{
			this.29 += 1662.82;
		}
		else
		{
			this.29 = 0.0;
		}
		this.30 = 1555.21();
		return this.29 > 3000.0 && !1535.1();
	}

	// Token: 0x060034F5 RID: 13557 RVA: 0x0014591F File Offset: 0x00143B1F
	internal override void CreateModSprites()
	{
		if (1304.74)
		{
			this.19 = 1455.5("comboburst", (1416)7, true);
		}
		base.CreateModSprites();
	}

	// Token: 0x060034F6 RID: 13558 RVA: 0x00145948 File Offset: 0x00143B48
	internal override void UpdateHealthDrain()
	{
		if (this.6 != null && this.8.89)
		{
			this.6.Drain(this.6.12 / 1.0 * (double)(1226.16 - 1226.18) * (double)(2486.9 ? 0.25f : 1f));
		}
		base.UpdateHealthDrain();
	}

	// Token: 0x060034F7 RID: 13559 RVA: 0x001459B4 File Offset: 0x00143BB4
	internal override void UpdateFlashlight()
	{
		if (this.20 != null)
		{
			208 <<EMPTY_NAME>> = new 208(Math.Max(0f, Math.Min(640f, (1535.51.17.X - (float)1662.70.4()) / 1662.70.3())) + 1662.70.5(), Math.Max(0f, Math.Min(480f, 1535.51.17.Y / 1662.70.3())));
			if (this.20 != null)
			{
				this.20.17 = 1052.12(this.20.17, <<EMPTY_NAME>>, (double)((float)1662.82), 0.0, 120f, (1046)1);
			}
		}
		base.UpdateFlashlight();
	}

	// Token: 0x060034F8 RID: 13560 RVA: 0x00145A88 File Offset: 0x00143C88
	internal override void UpdateModeInputEffects()
	{
		if (1662.23)
		{
			if ((!1535.1() && 1549.10(1548.8(1532.OsuSmoke))) || (1535.1() && 1535.71 != null && (1535.71.9 & 1572.Smoke) > 1572.None))
			{
				float num = (this.34 != null) ? 208.Distance(this.34.17, 1535.6) : 0f;
				float num2 = Math.Max(2f, (this.34 != null) ? ((float)this.34.35 * 0.625f * 1662.70.3() / 4f) : 0f);
				int num3 = Math.Max(1, (int)(num / num2));
				208 <<EMPTY_NAME>> = 1535.6;
				if (this.34 == null || this.34.17 != <<EMPTY_NAME>>)
				{
					208 2 = (this.34 != null) ? (this.34.17 + 208.Normalize(<<EMPTY_NAME>> - this.34.17) * Math.Min(num, num2)) : 1535.6;
					for (int i = 0; i < num3; i++)
					{
						1433 3 = new 1433(this.36, (1376)16, 1065.Centre, (1044)0, 208.Lerp(2, <<EMPTY_NAME>>, (float)i / (float)num3), 1f, false, 198.White, null);
						3.28 = true;
						3.16 = 0.6f;
						3.15 = 0.5f;
						3.14 = 1196.6(10f);
						3.26(3.14 + 1196.7(-0.25f, 0.25f), 500, (1046)1);
						3.25(3.15, 2000, (1046)1);
						3.16(4000, (1046)0, 0);
						this.8.73.12(3);
						this.35.Add(3);
						this.34 = 3;
					}
				}
				if (this.35.Count > 50 && 208.Distance(this.34.17, this.35[0].17) < 10f)
				{
					this.13();
				}
			}
			else
			{
				this.13();
				this.34 = null;
			}
		}
		base.UpdateModeInputEffects();
	}

	// Token: 0x060034F9 RID: 13561 RVA: 0x00145CE0 File Offset: 0x00143EE0
	private new void 13()
	{
		if (this.35.Count <= 0)
		{
			return;
		}
		int num = 0;
		foreach (1433 <<EMPTY_NAME>> in this.35)
		{
			if (<<EMPTY_NAME>>.16 != 0f)
			{
				1445 2 = <<EMPTY_NAME>>.3.Find(new Predicate<1445>(2141.2142.Instance.1));
				2.1 = 1f;
				2.9 = 1662.33 + num;
				2.10 = 1662.33 + num + 8000;
				2.15 = (1046)2;
				num += 2;
			}
		}
		this.35.Clear();
	}

	// Token: 0x060034FA RID: 13562 RVA: 0x00145DA8 File Offset: 0x00143FA8
	internal override void ApplyJudgement(2149 1, 2034 2)
	{
		if (2.10 && 2.11 && 1 != (2149)0)
		{
			this.8.9(1);
		}
		base.ApplyJudgement(1, 2);
	}

	// Token: 0x060034FB RID: 13563 RVA: 0x0001702D File Offset: 0x0001522D
	internal override bool CapturesCursor()
	{
		return true;
	}

	// Token: 0x060034FC RID: 13564 RVA: 0x00145DD4 File Offset: 0x00143FD4
	private static int 14(List<1840> 1, 1840 2)
	{
		int num = 1.BinarySearch(2, 2141.37);
		if (num < 0)
		{
			num = ~num;
		}
		else
		{
			while (num < 1.Count && 2.10 == 1[num].10)
			{
				num++;
			}
		}
		return num;
	}

	// Token: 0x060034FD RID: 13565 RVA: 0x00145E19 File Offset: 0x00144019
	private new static void 15(List<1840> 1, 1840 2)
	{
		1.Insert(2141.14(1, 2), 2);
	}

	// Token: 0x060034FE RID: 13566 RVA: 0x00145E29 File Offset: 0x00144029
	private new static 208 16(float 1, float 2)
	{
		return new 208((float)(Math.Cos((double)1) * (double)2), (float)(Math.Sin((double)1) * (double)2));
	}

	// Token: 0x060034FF RID: 13567 RVA: 0x00145E48 File Offset: 0x00144048
	internal override void GenerateAutoplayReplay()
	{
		int num = 0;
		2023 <<EMPTY_NAME>> = 2023.Relax2;
		2023 2 = 2019.1;
		2023 3 = <<EMPTY_NAME>>;
		bool flag = (2 & 3) > 2023.None;
		1046 4 = (!flag) ? ((1046)1) : ((1046)8);
		1535.39.26 = new List<1840>();
		List<1840> 5 = 1535.39.26;
		2141.15(5, new 1840(-100000, 256f, 500f, 1572.None));
		2141.15(5, new 1840(this.5.34[0].1 - 1500, 256f, 500f, 1572.None));
		2141.15(5, new 1840(this.5.34[0].1 - 1000, 256f, 192f, 1572.None));
		float num2 = (float)2039.19(16.666666666666668);
		208 6 = new 208(256f, 192f);
		int num3 = (int)2039.19(100.0);
		for (int i = 0; i < this.5.35; i++)
		{
			2034 7 = this.5.34[i];
			if (7.2 < 1535.41)
			{
				7.11 = true;
			}
			else
			{
				int num4 = (7 is 2129) ? 1 : 0;
				if (flag && i > 0)
				{
					2034 8 = this.5.34[i - 1];
					if (7.1 - 400 > 8.2 + this.5.3 + 50)
					{
						if (!(8 is 2070) && 7.1 - 8.2 < 1000)
						{
							2141.15(5, new 1840(8.2 + this.5.3, 8.GetEndPosition().X, 8.GetEndPosition().Y, 1572.None));
						}
						if (!(7 is 2070))
						{
							2141.15(5, new 1840(7.1 - 400, 7.8.X, 7.8.Y, 1572.None));
						}
					}
					else if (7.1 - this.5.3 > 8.2 + this.5.3 + 50)
					{
						if (!(8 is 2070) && 7.1 - 8.2 < 1000)
						{
							2141.15(5, new 1840(8.2 + this.5.3, 8.GetEndPosition().X, 8.GetEndPosition().Y, 1572.None));
						}
						if (!(7 is 2070))
						{
							2141.15(5, new 1840(7.1 - this.5.3, 7.8.X, 7.8.Y, 1572.None));
						}
					}
					else if (7.1 - this.5.4 > 8.2 + this.5.4 + 50)
					{
						if (!(8 is 2070) && 7.1 - 8.2 < 1000)
						{
							2141.15(5, new 1840(8.2 + this.5.4, 8.GetEndPosition().X, 8.GetEndPosition().Y, 1572.None));
						}
						if (!(7 is 2070))
						{
							2141.15(5, new 1840(7.1 - this.5.4, 7.8.X, 7.8.Y, 1572.None));
						}
					}
				}
				208 9 = 7.8;
				1046 10 = 4;
				float num5 = -1f;
				if (7 is 2070)
				{
					9.X = 5[5.Count - 1].1;
					9.Y = 5[5.Count - 1].2;
					208 11 = 6 - 9;
					float num6 = 11.Length();
					float 12 = (float)Math.Sqrt((double)(num6 * num6 - 2500f));
					if (num6 <= 50f)
					{
						9 = ((11.Length() <= 0f) ? (6 + new 208(0f, -50f)) : (6 - 11 * (50f / 11.Length())));
					}
					else
					{
						float num7 = (float)Math.Asin((double)(50f / num6));
						num5 = ((num7 <= 0f) ? 1f : -1f);
						11.X = 11.X * (float)Math.Cos((double)num7) - 11.Y * (float)Math.Sin((double)num7);
						11.Y = 11.X * (float)Math.Sin((double)num7) + 11.Y * (float)Math.Cos((double)num7);
						11.Normalize();
						11 *= 12;
						9 += 11;
						10 = (1046)2;
					}
				}
				if (5.Count > 0)
				{
					1840 13 = 5[5.Count - 1];
					int num8 = 7.1 - (int)Math.Max(0.0, (double)(this.5.2 - num3));
					if (num8 > 13.10)
					{
						13 = new 1840(num8, 13.1, 13.2, 13.9);
						2141.15(5, 13);
					}
					208 14 = new 208(13.1, 13.2);
					2122 15 = this.5 as 2122;
					double num9 = 2039.20((double)(7.1 - 13.10), 2019.1);
					if (15 != null && num9 > 0.0 && ((double)(14 - 9).Length() > (double)15.1 * (1.5 + 100.0 / num9) || num9 >= 266.0))
					{
						for (float num10 = (float)13.10 + num2; num10 < (float)7.1; num10 += num2)
						{
							208 16 = 1052.12(14, 9, (double)num10, (double)13.10, (float)7.1, 10);
							2141.15(5, new 1840((int)num10, 16.X, 16.Y, 13.9));
						}
						num = 0;
					}
					else
					{
						num++;
					}
				}
				1572 17 = (num % 2 == 0) ? 1572.Left1 : 1572.Right1;
				1840 18 = new 1840(7.1, 9.X, 9.Y, 17);
				1840 19 = new 1840(7.2 + num4, 7.GetEndPosition().X, 7.GetEndPosition().Y, 1572.None);
				int num11 = 2141.14(5, 18) - 1;
				if (num11 >= 0)
				{
					1572 20 = 5[num11].9;
					if (20 != 1572.None)
					{
						if (20 == 17)
						{
							17 = ((1572.Left1 | 1572.Right1) & ~17);
							18.1(17);
						}
						int num12 = 2141.14(5, 19);
						if (num11 < 5.Count - 1)
						{
							5.RemoveRange(num11 + 1, Math.Max(0, num12 - (num11 + 1)));
						}
						for (int j = num11 + 1; j < 5.Count; j++)
						{
							if (j < 5.Count - 1 || 5[j].9 == 20)
							{
								5[j].1(17);
							}
						}
					}
				}
				2141.15(5, 18);
				if (7 is 2129)
				{
					208 21 = 9 - 6;
					float num13 = (21.Length() == 0f) ? 0f : ((float)Math.Atan2((double)21.Y, (double)21.X));
					float num15;
					for (float num14 = (float)7.1 + num2; num14 < (float)7.2; num14 += num2)
					{
						num15 = (float)2039.21((double)(num14 - (float)7.1)) * num5;
						208 22 = 6 + 2141.16(num15 / 20f + num13, 50f);
						2141.15(5, new 1840((int)num14, 22.X, 22.Y, 17));
					}
					num15 = (float)2039.21((double)(7.2 - 7.1)) * num5;
					208 23 = 6 + 2141.16(num15 / 20f + num13, 50f);
					2141.15(5, new 1840(7.2, 23.X, 23.Y, 17));
					19.1 = 23.X;
					19.2 = 23.Y;
				}
				else if (7 is 2123)
				{
					2123 24 = 7 as 2123;
					int num16 = 0;
					foreach (1445 25 in 24.49.3.FindAll(new Predicate<1445>(2141.2142.Instance.2)))
					{
						if (num16 == 0 || (float)(25.10 - num16) >= num2)
						{
							if ((float)(25.10 - 25.9) > num2 * 2f)
							{
								for (float num17 = (float)25.9 + num2; num17 < (float)25.10; num17 += num2)
								{
									208 26 = 1052.12(25.2, 25.6, (double)num17, (double)25.9, (float)25.10, 25.15);
									2141.15(5, new 1840((int)num17, 26.X, 26.Y, 17));
								}
							}
							else
							{
								2141.15(5, new 1840(25.9, 25.2.X, 25.2.Y, 17));
								num16 = 25.9;
							}
						}
					}
					2141.15(5, new 1840(7.2, 7.GetEndPosition().X, 7.GetEndPosition().Y, 17));
				}
				if (5[5.Count - 1].10 <= 19.10)
				{
					2141.15(5, 19);
				}
			}
		}
		2486.88.26 = 1535.39.26;
		2486.88.23 = "osu!";
	}

	// Token: 0x06003500 RID: 13568 RVA: 0x00146918 File Offset: 0x00144B18
	internal virtual double CalculateHealthDrain()
	{
		double num = 0.05;
		double <<EMPTY_NAME>> = (double)1926.5(1928.DrainRate, 1272.5().3);
		double difficultyRange = this.5.GetDifficultyRange(<<EMPTY_NAME>>, 195.0, 160.0, 60.0);
		double difficultyRange2 = this.5.GetDifficultyRange(<<EMPTY_NAME>>, 198.0, 170.0, 80.0);
		double difficultyRange3 = this.5.GetDifficultyRange(<<EMPTY_NAME>>, 198.0, 180.0, 80.0);
		double difficultyRange4 = this.5.GetDifficultyRange(<<EMPTY_NAME>>, 8.0, 4.0, 0.0);
		bool flag;
		do
		{
			this.17 = 0;
			this.6.ResetToFull();
			this.3.SetCombo(0);
			2486.88.ResetJudgements(false);
			double num2 = this.6.3();
			int num3 = this.5.34[0].1 - this.5.2;
			flag = false;
			int count = this.8.34.13.Count;
			int num4 = 0;
			int num5 = 0;
			for (int i = 0; i < this.5.35; i++)
			{
				2034 2 = this.5.34[i];
				int num6 = num3;
				int num7 = 0;
				if (count > 0 && num4 < count)
				{
					2647 3 = this.8.34.13[num4];
					if (3.8 >= num6 && 3.1 <= 2.1)
					{
						num7 = ((1272.5().32 < 8) ? 3.GetDuration() : (3.1 - num6));
						num4++;
					}
				}
				this.6.Drain(num * (double)(2.1 - num3 - num7));
				num3 = 2.2;
				if (this.6.3() < num2)
				{
					num2 = this.6.3();
				}
				if (this.6.3() <= difficultyRange)
				{
					flag = true;
					num *= 0.96;
					break;
				}
				double num8 = num * (double)(2.2 - 2.1);
				double num9 = Math.Max(0.0, num8 - this.6.3());
				this.6.Drain(num8);
				if (2.HasObjectType(2047.Slider))
				{
					2123 4 = (2123)2;
					int num10 = 4.82.Count + 2;
					int num11 = 4.83.Count - 4.82.Count - 1;
					this.17 += num10 + num11 - 1;
					for (int j = 0; j < num10; j++)
					{
						this.ApplyJudgement((2149)64, 2);
					}
					for (int k = 0; k < num11; k++)
					{
						this.ApplyJudgement((2149)8, 2);
					}
				}
				else if (2.HasObjectType(2047.Spinner))
				{
					2129 5 = (2129)2;
					for (int l = 0; l < 5.49; l++)
					{
						this.ApplyJudgement((2149)8192, 2);
					}
				}
				if (num9 > 0.0 && this.6.3() - num9 <= difficultyRange)
				{
					flag = true;
					num *= 0.96;
					break;
				}
				if (i == this.5.35 - 1 || this.5.34[i + 1].IsNewCombo())
				{
					this.ApplyJudgement((2149)1028, 2);
					if (this.6.3() < difficultyRange2 && ++num5 > 2)
					{
						this.24 *= 1.07;
						this.25 *= 1.03;
						flag = true;
						break;
					}
				}
				else
				{
					this.ApplyJudgement((2149)1024, 2);
				}
				this.17++;
				2.13 = this.6.3();
			}
			if (!flag && this.6.3() < difficultyRange3)
			{
				flag = true;
				num *= 0.94;
				this.24 *= 1.01;
				this.25 *= 1.01;
			}
			double num12 = (this.6.5() - 200.0) / (double)this.5.35;
			if (!flag && num12 < difficultyRange4)
			{
				flag = true;
				num *= 0.96;
				this.24 *= 1.02;
				this.25 *= 1.01;
			}
		}
		while (flag);
		if (1662.84)
		{
			2485 6 = this.8 as 2485;
			if (6 != null)
			{
				6.218 = 2486.88.GetScore();
				6.217 = this.3.GetCombo();
			}
		}
		return num;
	}

	// Token: 0x04002745 RID: 10053
	private 1433 34;

	// Token: 0x04002746 RID: 10054
	private List<1433> 35 = new List<1433>();

	// Token: 0x04002747 RID: 10055
	private 1381 36;

	// Token: 0x04002748 RID: 10056
	private static IComparer<1840> 37 = new 2141.2143();

	// Token: 0x02000704 RID: 1796
	[276]
	[Serializable]
	public sealed class 2142
	{
		// Token: 0x06003502 RID: 13570 RVA: 0x000CAAF9 File Offset: 0x000C8CF9
		internal bool 1(1445 1)
		{
			return 1.14 == 1456.Fade;
		}

		// Token: 0x06003503 RID: 13571 RVA: 0x000BA3D9 File Offset: 0x000B85D9
		internal bool 2(1445 1)
		{
			return 1.14 == 1456.Movement;
		}

		// Token: 0x04002749 RID: 10057
		public static readonly 2141.2142 Instance = new 2141.2142();

		// Token: 0x0400274A RID: 10058
		public static Predicate<1445> predicate;

		// Token: 0x0400274B RID: 10059
		public static Predicate<1445> predicate2;
	}

	// Token: 0x02000705 RID: 1797
	[276]
	public sealed class 2143 : IComparer<1840>
	{
		// Token: 0x06003506 RID: 13574 RVA: 0x00146E57 File Offset: 0x00145057
		public int Compare(1840 1, 1840 2)
		{
			return 1.10.CompareTo(2.10);
		}
	}
}
