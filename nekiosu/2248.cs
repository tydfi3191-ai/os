using System;
using System.Collections.Generic;
using System.Threading;

// Token: 0x02000658 RID: 1624
public sealed class 2248 : 2462
{
	// Token: 0x0600317A RID: 12666 RVA: 0x001279F8 File Offset: 0x00125BF8
	public 2248(1662 1) : base(1)
	{
	}

	// Token: 0x0600317B RID: 12667 RVA: 0x00127A24 File Offset: 0x00125C24
	public override void Initialize()
	{
		this.10 = new 1452("Please click to start the benchmark.\nWhile running do not move your mouse or switch windows.", 20f, new 208(0f, 0f), new 208(600f, 0f), 1f, true, 198.White, true)
		{
			75 = (1066)3,
			49 = 1065.Centre,
			41 = (1376)10
		};
		this.4.12(this.10);
		base.Initialize();
		1549.1(new 1549.1550(this.3));
		1535.40((1082)8, new 1081(this.2), 1545.Default, (1559)0);
		this.12 = new 1380(this.4, 1409.Bottom, 34f);
	}

	// Token: 0x0600317C RID: 12668 RVA: 0x00127AD9 File Offset: 0x00125CD9
	private void Start()
	{
		if (!this.6)
		{
			this.6 = true;
			this.9 = (double)1662.33;
			this.1();
		}
	}

	// Token: 0x0600317D RID: 12669 RVA: 0x00127AFC File Offset: 0x00125CFC
	protected override void Dispose(bool 1)
	{
		this.4.Dispose();
		this.5.Dispose();
		this.12.Dispose();
		1549.2(new 1549.1550(this.3));
		base.Dispose(1);
	}

	// Token: 0x0600317E RID: 12670 RVA: 0x00127B37 File Offset: 0x00125D37
	public override void Draw()
	{
		base.Draw();
		this.5.22();
		this.4.22();
	}

	// Token: 0x0600317F RID: 12671 RVA: 0x00127B58 File Offset: 0x00125D58
	public override void Update()
	{
		base.Update();
		this.12.SetProgress((float)(this.9 / 6000.0));
		if (!this.6)
		{
			return;
		}
		this.9 += 1662.82;
		if (this.9 > 6000.0)
		{
			this.1();
			return;
		}
		if (this.9 > 5000.0)
		{
			if (!this.11)
			{
				this.5.28.ForEach(new Action<1371>(2248.2249.instance.1));
				this.11 = true;
			}
			GC.Collect();
		}
		if (this.8.ContainsKey(this.7))
		{
			Dictionary<2248.2250, int> dictionary = this.8;
			2248.2250 key = this.7;
			int num = dictionary[key];
			dictionary[key] = num + 1;
		}
		if (this.11)
		{
			return;
		}
		switch (this.7)
		{
		case 2248.2250.TextRendering:
			if (this.5.28.Count == 0)
			{
				for (int i = 0; i < 4; i++)
				{
					this.5.12(new 1452("Testing text rendering", 20f, new 208((float)1196.2(0, 1662.70.1), (float)1196.2(0, 1662.70.2)), new 208(400f, 0f), 1f, true, 198.White, true)
					{
						75 = (1066)2,
						49 = 1065.Centre
					});
				}
			}
			for (int j = 0; j < 4; j++)
			{
				((1452)this.5.28[j]).SetText(1196.3().ToString());
			}
			return;
		case 2248.2250.FillRate:
			if (this.5.28.Count == 0)
			{
				for (int k = 0; k < 10; k++)
				{
					1433 <<EMPTY_NAME>> = new 1433(1662.34, (1376)5, 1065.TopLeft, (1044)0, 208.Zero, 0f, true, new 198((byte)1196.2(0, 255), (byte)1196.2(0, 255), (byte)1196.2(0, 255), byte.MaxValue), null)
					{
						28 = true,
						20 = new 208((float)1662.70.1, (float)1662.70.2)
					};
					<<EMPTY_NAME>>.15(1196.2(10000, 30000));
					this.5.12(<<EMPTY_NAME>>);
				}
				return;
			}
			break;
		case 2248.2250.TexturedFillRate:
			if (this.5.28.Count == 0)
			{
				for (int l = 0; l < 10; l++)
				{
					1433 2 = new 1433(1455.2("menu-background", (1416)1, null), (1376)5, 1065.TopLeft, (1044)0, 208.Zero, 0f, true, 198.White, null);
					if ((float)(1662.70.1 / 1662.70.2) > 1.6f)
					{
						2.20 = new 208((float)1662.70.1 / 1662.70.3() / 640f, (float)1662.70.2 / 1662.70.3() / 480f);
					}
					2.28 = true;
					2.15(20000);
					this.5.12(2);
				}
			}
			break;
		case 2248.2250.TextureLoading:
		{
			1455.9(false);
			1433 3 = new 1433(1455.2("sliderb" + 1196.2(0, 10).ToString(), (1416)1, null), (1376)6, 1065.TopLeft, (1044)0, new 208((float)1196.2(0, 1662.70.1), (float)1196.2(0, 1662.70.2)), 0f, false, 198.White, null)
			{
				28 = true
			};
			3.17(500);
			this.5.12(3);
			this.5.28.ForEach(new Action<1371>(2248.2249.instance.2));
			return;
		}
		case 2248.2250.Threading:
			if (this.5.28.Count == 0)
			{
				1433 4 = new 1433(1662.34, (1376)5, 1065.TopLeft, (1044)0, 208.Zero, 0f, true, 198.Orange, null)
				{
					28 = true,
					20 = new 208((float)1662.70.1, (float)1662.70.2)
				};
				4.15(5000);
				this.5.12(4);
				for (int m = 0; m < 2; m++)
				{
					1662.17(new 1189(this.4));
				}
				return;
			}
			break;
		case 2248.2250.CPUPerformance:
		case 2248.2250.GarbageCollection:
		{
			198 5 = 198.MediumPurple;
			if (this.7 == 2248.2250.CPUPerformance)
			{
				this.5.15(true);
				5 = 198.GreenYellow;
			}
			else
			{
				this.5.28.Clear();
			}
			for (int n = 0; n < 1000; n++)
			{
				this.5.12(new 1433(1662.34, (1376)5, 1065.TopLeft, (1044)0, new 208((float)1196.2(0, 1662.70.1), (float)1196.2(0, 1662.70.2)), 0f, true, 5, null)
				{
					16 = 1f,
					28 = true
				});
			}
			return;
		}
		default:
			return;
		}
	}

	// Token: 0x06003180 RID: 12672 RVA: 0x001280A0 File Offset: 0x001262A0
	private void 1()
	{
		this.5.15(true);
		this.7++;
		this.9 = 0.0;
		this.11 = false;
		2248.2250 <<EMPTY_NAME>> = this.7;
		if (<<EMPTY_NAME>> == 2248.2250.Start)
		{
			this.10.SetText("Preparing...");
			return;
		}
		if (<<EMPTY_NAME>> != 2248.2250.Finished)
		{
			this.10.SetText(string.Format("Running stage {0} of {1}\n{2}", this.7 - 2248.2250.Start, 8, this.7));
			this.8[this.7] = 0;
			return;
		}
		this.10.75 = (1066)3;
		this.10.SetText("Complete!\n");
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = this.8[2248.2250.IdleFramerate];
		foreach (KeyValuePair<2248.2250, int> keyValuePair in this.8)
		{
			if (keyValuePair.Key == 2248.2250.IdleFramerate)
			{
				1452 2 = this.10;
				2.SetText(2.GetText() + string.Format("\nIdle framerate: {0}fps\n\nIndividual tests:", keyValuePair.Value / 6));
				num2 += keyValuePair.Value;
			}
			else
			{
				int num5 = (int)Math.Min(100f, (float)keyValuePair.Value / (float)num4 * 100f);
				num3++;
				int num6 = keyValuePair.Value / 6;
				if (num6 > 120)
				{
					num5 = (int)Math.Min(100f, (float)num5 + (float)(num6 - 120) / 2f);
				}
				num += num5;
				num2 += keyValuePair.Value;
				1452 3 = this.10;
				3.SetText(3.GetText() + string.Format("\n{0}: {1} ({2}fps)", keyValuePair.Key, num5, num6));
			}
		}
		1452 4 = this.10;
		4.SetText(4.GetText() + "\n\nOverall Smoothness: " + (num / num3).ToString());
		1452 5 = this.10;
		5.SetText(5.GetText() + "\nRaw Score: " + num2.ToString());
		this.6 = false;
		this.7 = 2248.2250.Idle;
	}

	// Token: 0x06003181 RID: 12673 RVA: 0x00128308 File Offset: 0x00126508
	private bool 2(object 1, EventArgs 2)
	{
		if (!this.6)
		{
			this.Start();
			return true;
		}
		return false;
	}

	// Token: 0x06003182 RID: 12674 RVA: 0x0012831B File Offset: 0x0012651B
	private new bool 3(object 1, 200 2)
	{
		if (2 == 200.Escape)
		{
			1662.SetMode(1677.Menu, false);
			return true;
		}
		return false;
	}

	// Token: 0x06003183 RID: 12675 RVA: 0x0012832C File Offset: 0x0012652C
	private void 4()
	{
		while (this.9 < 5000.0)
		{
			Thread.SpinWait(1);
		}
	}

	// Token: 0x0400246B RID: 9323
	private 1436 4 = new 1436(true);

	// Token: 0x0400246C RID: 9324
	private 1436 5 = new 1436(true);

	// Token: 0x0400246D RID: 9325
	private bool 6;

	// Token: 0x0400246E RID: 9326
	private 2248.2250 7;

	// Token: 0x0400246F RID: 9327
	private Dictionary<2248.2250, int> 8 = new Dictionary<2248.2250, int>();

	// Token: 0x04002470 RID: 9328
	private double 9;

	// Token: 0x04002471 RID: 9329
	private 1452 10;

	// Token: 0x04002472 RID: 9330
	private bool 11;

	// Token: 0x04002473 RID: 9331
	private 1380 12;

	// Token: 0x02000659 RID: 1625
	[Serializable]
	public sealed class 2249
	{
		// Token: 0x06003184 RID: 12676 RVA: 0x00128347 File Offset: 0x00126547
		internal void 1(1371 1)
		{
			1.16(300, (1046)0, 0);
		}

		// Token: 0x06003185 RID: 12677 RVA: 0x00128358 File Offset: 0x00126558
		internal void 2(1371 1)
		{
			((1433)1).SetTexture(1455.2("sliderb" + 1196.2(0, 10).ToString(), (1416)1, null));
		}

		// Token: 0x04002474 RID: 9332
		public static readonly 2248.2249 instance = new 2248.2249();

		// Token: 0x04002475 RID: 9333
		public static Action<1371> action;

		// Token: 0x04002476 RID: 9334
		public static Action<1371> action2;
	}

	// Token: 0x0200065A RID: 1626
	public enum 2250
	{
		// Token: 0x04002478 RID: 9336
		Idle,
		// Token: 0x04002479 RID: 9337
		Start,
		// Token: 0x0400247A RID: 9338
		IdleFramerate,
		// Token: 0x0400247B RID: 9339
		TextRendering,
		// Token: 0x0400247C RID: 9340
		FillRate,
		// Token: 0x0400247D RID: 9341
		TexturedFillRate,
		// Token: 0x0400247E RID: 9342
		TextureLoading,
		// Token: 0x0400247F RID: 9343
		Threading,
		// Token: 0x04002480 RID: 9344
		CPUPerformance,
		// Token: 0x04002481 RID: 9345
		GarbageCollection,
		// Token: 0x04002482 RID: 9346
		Finished
	}
}
