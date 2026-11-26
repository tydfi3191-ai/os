using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

// Token: 0x0200056C RID: 1388
public class 2255 : 2336
{
	// Token: 0x06002A6C RID: 10860 RVA: 0x000DF15C File Offset: 0x000DD35C
	public 2255(2263 1) : base(1)
	{
		this.44 = new List<2034>();
		this.20 = new List<2034>();
		this.73 = (1.15 == 2147.Taiko);
		1549.3(new 1549.1550(this.14));
		this.46 = -1;
	}

	// Token: 0x06002A6D RID: 10861 RVA: 0x0001702D File Offset: 0x0001522D
	internal override bool HasGrid()
	{
		return true;
	}

	// Token: 0x06002A6E RID: 10862 RVA: 0x000DF1FE File Offset: 0x000DD3FE
	private 208 2()
	{
		return 1535.6;
	}

	// Token: 0x06002A6F RID: 10863 RVA: 0x000DF205 File Offset: 0x000DD405
	private new 208 3()
	{
		return 1662.69.14(this.2());
	}

	// Token: 0x06002A70 RID: 10864 RVA: 0x000DF217 File Offset: 0x000DD417
	internal override bool IsEditingSliderPath()
	{
		return this.50 != null || this.46 >= 0 || (1549.1 && this.45 != null);
	}

	// Token: 0x06002A71 RID: 10865 RVA: 0x000DF240 File Offset: 0x000DD440
	protected override void InitializeState()
	{
		if (this.4.34.Count > 0)
		{
			this.63((2255.2257)0);
		}
		else
		{
			this.63((2255.2257)1);
		}
		this.45(2357.NewCombo | 2357.Whistle | 2357.Finish | 2357.GridSnap | 2357.DistSnap | 2357.NoteLock | 2357.Clap);
		this.24(1304.144);
		this.26(1304.138);
	}

	// Token: 0x06002A72 RID: 10866 RVA: 0x000DF298 File Offset: 0x000DD498
	protected override void CreateInterface()
	{
		this.17 = new 1429(this.5, 1.0, 16.0, 1.0, new 208((float)(1662.70.1() - 190), 25f), 140);
		1429 <<EMPTY_NAME>> = this.17;
		<<EMPTY_NAME>>.18 = (1429.1432)Delegate.Combine(<<EMPTY_NAME>>.18, new 1429.1432(this.28));
		this.48 = new 1452(1568.1(2679.EditorModeCompose_BeatSnapDivisor) + ":", 14f, new 208((float)(1662.70.1() - 200), 0f), 1f, true, 198.White);
		this.48.8 = 2335.Compose;
		this.5.12(this.48);
		this.18 = new 1452(string.Empty, 14f, new 208((float)(1662.70.1() - 40), 15f), 1f, true, 198.White);
		this.18.8 = 2335.Compose;
		this.5.12(this.18);
		1361 6 = new 1361(1568.1(2679.EditorModeCompose_InsertBreakTime), new 208((float)(1662.70.1() - 190), 40f), new 208(130f, 22.5f), 1f, new 198(112, 152, 252), delegate(object 1, EventArgs 2)
		{
			if (!this.IsEditingSliderPath())
			{
				this.3.20(1226.16, true, true);
				this.6.20(false, false);
			}
		}, true, false, null, true);
		6.6(1568.1(2679.EditorModeCompose_InsertBreakTooltip));
		this.5.14<1433>(6.1);
		float num = 2328.1(1662.13(), false) / 96f;
		this.58 = new 1452(string.Empty, 10f * num, new 208(70f, 120f), new 208((float)1662.70.1 - 140f * 1662.70.3(), 1662.69.3()), 1f, true, 198.TransparentWhite, true);
		this.58.6 = new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue, 180);
		this.58.40 = new bool?(true);
		this.58.85 = false;
		this.58.75 = (1066)2;
		this.58.74 = false;
		this.5.12(this.58);
		this.19 = new 1433[]
		{
			new 1433(1455.2("editor-draw-select", (1416)1, null), (1376)6, 1065.TopLeft, (1044)0, new 208(0f, 140f), 0.98f, true, 198.TransparentWhite, null),
			new 1433(1455.2("editor-draw-normal", (1416)1, null), (1376)6, 1065.TopLeft, (1044)0, new 208(0f, 200f), 0.98f, true, 198.TransparentWhite, null),
			new 1433(1455.2("editor-draw-slider", (1416)1, null), (1376)6, 1065.TopLeft, (1044)0, new 208(0f, 260f), 0.98f, true, 198.TransparentWhite, null),
			new 1433(1455.2("editor-draw-spinner", (1416)1, null), (1376)6, 1065.TopLeft, (1044)0, new 208(0f, 320f), 0.98f, true, 198.TransparentWhite, null),
			new 1433(1455.2("editor-draw-hold", (1416)1, null), (1376)6, 1065.TopLeft, (1044)0, new 208(0f, 260f), 0.98f, true, 198.TransparentWhite, null)
		};
		this.19[0].52 = 1568.1(2679.EditorModeCompose_ComposeToolSelectTooltip);
		this.19[1].52 = 1568.1(2679.EditorModeCompose_ComposeToolCircleTooltip);
		this.19[2].52 = 1568.1(2679.EditorModeCompose_ComposeToolSliderTooltip);
		this.19[3].52 = 1568.1(2679.EditorModeCompose_ComposeToolSpinnerTooltip);
		this.19[4].52 = 1568.1(2679.EditorModeCompose_ComposeToolHoldTooltip);
		if (this.3.15 != 2147.OsuMania)
		{
			this.19[4].9(true);
		}
		else
		{
			this.19[2].9(true);
			this.19[3].9(true);
		}
		foreach (1433 3 in this.19)
		{
			3.10 = true;
			3.3(new EventHandler(this.64));
			this.5.12(3);
		}
		if (2255.54 == null)
		{
			2255.54 = new Dictionary<2357, bool>();
			2255.54.Add(2357.Finish, false);
			2255.54.Add(2357.Clap, false);
			2255.54.Add(2357.Whistle, false);
			2255.54.Add(2357.NewCombo, false);
			2255.54.Add(2357.GridSnap, 1304.143);
			2255.54.Add(2357.DistSnap, 1304.78);
			2255.54.Add(2357.NoteLock, false);
		}
		1662.8.20(1226.75());
		this.65 = new 1483(this.5);
		this.64 = new 1433(1455.2("editor-draw-newcombo-expand", (1416)1, null), (1376)8, 1065.TopLeft, (1044)0, new 208(50f, 80f), 2f, true, 198.TransparentWhite, null);
		this.64.10 = true;
		this.64.3(delegate(object 1, EventArgs 2)
		{
			if (this.65.2())
			{
				this.65.Hide();
				return;
			}
			this.65.Show();
		});
		this.65.4(new EventHandler(this.50));
		this.5.12(this.64);
		this.53 = new 1433[]
		{
			new 1433(1455.2("editor-draw-newcombo", (1416)1, null), (1376)8, 1065.TopLeft, (1044)0, new 208(50f, 80f), 1f, true, 198.TransparentWhite, 2357.NewCombo),
			new 1433(1455.2("editor-sound-whistle", (1416)1, null), (1376)8, 1065.TopLeft, (1044)0, new 208(50f, 140f), 1f, true, 198.TransparentWhite, 2357.Whistle),
			new 1433(1455.2("editor-sound-finish", (1416)1, null), (1376)8, 1065.TopLeft, (1044)0, new 208(50f, 180f), 1f, true, 198.TransparentWhite, 2357.Finish),
			new 1433(1455.2("editor-sound-clap", (1416)1, null), (1376)8, 1065.TopLeft, (1044)0, new 208(50f, 220f), 1f, true, 198.TransparentWhite, 2357.Clap),
			new 1433(1455.2("editor-draw-beatsnap", (1416)1, null), (1376)8, 1065.TopLeft, (1044)0, new 208(50f, 260f), 1f, true, 198.TransparentWhite, 2357.GridSnap),
			new 1433(1455.2("editor-draw-distsnap", (1416)1, null), (1376)8, 1065.TopLeft, (1044)0, new 208(50f, 320f), 1f, true, 198.TransparentWhite, 2357.DistSnap),
			new 1433(1455.2("editor-draw-lock", (1416)1, null), (1376)8, 1065.TopLeft, (1044)0, new 208(50f, 380f), 1f, true, 198.TransparentWhite, 2357.NoteLock)
		};
		foreach (1433 4 in this.53)
		{
			4.10 = true;
			4.3(delegate(object 1, EventArgs 2)
			{
				if (!this.IsEditingSliderPath())
				{
					2357 7 = (2357)((1433)1).8;
					this.30(7);
				}
			});
			this.5.12(4);
		}
		this.53[0].52 = 1568.1(2679.EditorModeCompose_NewComboTooltip);
		this.53[1].52 = 1568.1(2679.EditorModeCompose_WhistleTooltip);
		this.53[2].52 = 1568.1(2679.EditorModeCompose_FinishTooltip);
		this.53[3].52 = 1568.1(2679.EditorModeCompose_ClapTooltip);
		this.53[4].52 = 1568.1(2679.EditorModeCompose_GridSnapTooltip);
		this.53[5].52 = 1568.1(2679.EditorModeCompose_DistanceSnapTooltip);
		this.53[6].52 = 1568.1(2679.EditorModeCompose_NoteLockTooltip);
		this.70 = new 1452(string.Empty, 10f, new 208((float)(1662.70.1() - 50), 36f), 208.Zero, 1f, true, 198.White, true);
		this.70.74 = false;
		this.70.63(true);
		this.70.10 = true;
		this.70.3(new EventHandler(this.23));
		this.5.12(this.70);
		this.66 = new 1452("Sampleset", 10f, new 208(2f, 84f), 208.Zero, 0.97f, true, 198.White, false);
		this.5.12(this.66);
		this.67 = new 1452("Additions", 10f, new 208(2f, 109f), 208.Zero, 0.97f, true, 198.White, false);
		this.5.12(this.67);
		this.68 = new 1373(this.5, string.Empty, new 208(0f, 94f), 52f, 0.98f, false, false);
		this.68.10("Auto", 1254.None);
		this.68.10("Normal", 1254.Normal);
		this.68.10("Soft", 1254.Soft);
		this.68.10("Drum", 1254.Drum);
		this.68.18(1254.None, true);
		this.68.1(new EventHandler(this.34));
		this.69 = new 1373(this.5, string.Empty, new 208(0f, 119f), 52f, 0.98f, false, false);
		this.69.10("Auto", 1254.None);
		this.69.10("Normal", 1254.Normal);
		this.69.10("Soft", 1254.Soft);
		this.69.10("Drum", 1254.Drum);
		this.69.18(1254.None, true);
		this.69.1(new EventHandler(this.35));
		1452 5 = new 1452("Break", 16f, 208.Zero, 1f, true, 198.White);
		5.9(true);
		this.76 = 5;
		this.5.12(this.76);
		base.CreateInterface();
	}

	// Token: 0x06002A73 RID: 10867 RVA: 0x000DFD9C File Offset: 0x000DDF9C
	internal override void Update()
	{
		2255.2262 <<EMPTY_NAME>> = new 2255.2262();
		<<EMPTY_NAME>>.1 = this;
		this.10();
		this.40();
		int num = (int)this.3().X;
		int num2 = (int)this.3().Y;
		float num3 = (float)num;
		float num4 = (float)num2;
		2034 2 = null;
		if (this.44.Count > 0)
		{
			num3 -= (float)((int)this.28.X);
			num4 -= (float)((int)this.28.Y);
			if (this.47)
			{
				this.44.Sort();
			}
			2 = this.44[0];
			if (this.45 != null && !this.45.3())
			{
				this.45 = null;
			}
		}
		else
		{
			this.45 = null;
		}
		float num5 = this.4.1 * 0.6f;
		this.16 = 2255.54[2357.GridSnap];
		if ((this.3.10 || this.22 != null) && this.50 == null && this.46 <= 0 && !this.3.70)
		{
			int 3 = 1226.16;
			if (this.44.Count > 0)
			{
				3 = 2.1;
			}
			int num6 = this.4.34.BinarySearch(new 2071(this.4, 3 - 1));
			if (num6 < 0)
			{
				num6 = ~num6 - 1;
			}
			<<EMPTY_NAME>>.2 = ((num6 >= 0 && !(this.4.34[num6] is 2129)) ? this.4.34[num6] : null);
			if (<<EMPTY_NAME>>.2 != null)
			{
				208 4 = <<EMPTY_NAME>>.2.1();
				int 5 = <<EMPTY_NAME>>.2.2;
				208 6 = 208.Normalize(new 208(num3, num4) - 4);
				if (2255.54[2357.DistSnap])
				{
					208 7 = 4 + 6 * (float)(this.4.GetSliderVelocityAt(3) * this.23 * (double)(3 - 5) / 1000.0);
					if (1662.69.24(7))
					{
						num3 = 7.X;
						num4 = 7.Y;
						if (2 != null)
						{
							208 8 = 2.8 - 2.18;
							num3 -= 8.X;
							num4 -= 8.Y;
						}
						if (this.53[5].6 == 198.Red)
						{
							this.53[5].39(198.White, 100, false, (1046)0);
						}
						if (this.3.10 && this.44.Count > 0)
						{
							this.33 = 2;
						}
					}
					else if (!this.27 && this.3.59 == (2329)2)
					{
						this.53[5].39(198.Red, 100, false, (1046)0);
					}
					if (!2255.54[2357.GridSnap] && ((1549.3 && !1549.1) || (!1549.3 && 1549.1)) && 1662.69.23(this.3()))
					{
						double num7 = Math.Atan2((double)(7.X - 4.X), (double)(7.Y - 4.Y)) * 180.0 / 3.141592653589793;
						Math.Abs(num7);
						int num8 = (int)(Math.Round(num7 / 45.0) * 45.0);
						if (Math.Abs(num7 - (double)num8) < 10.0)
						{
							num8 = -num8 + 90;
							float num9 = 208.Distance(new 208(num3, num4), 4);
							208 9 = new 208((float)Math.Cos((double)num8 * 3.141592653589793 / 180.0), (float)Math.Sin((double)num8 * 3.141592653589793 / 180.0));
							num3 = 4.X + 9.X * num9;
							num4 = 4.Y + 9.Y * num9;
							this.60 = new 1051(1662.69.17(4), 1662.69.17(4 + 9 * num9 * 2f));
							this.16 = false;
						}
					}
					if (208.Distance(this.3(), 4) < num5)
					{
						num3 = <<EMPTY_NAME>>.2.1().X;
						num4 = <<EMPTY_NAME>>.2.1().Y;
						this.16 = false;
					}
				}
				else
				{
					num5 = this.4.1 * 0.15f;
					if (this.44.Count > 0)
					{
						if (!this.61)
						{
							float num10 = 208.Distance(2.18, 4);
							if ((!this.62 || 208.Distance(this.3(), 4) < num5) && num10 < num5)
							{
								num3 = <<EMPTY_NAME>>.2.1().X;
								num4 = <<EMPTY_NAME>>.2.1().Y;
								this.63 = new 208((float)num, (float)num2);
								this.61 = true;
								this.16 = false;
							}
						}
						else if (208.Distance(this.3(), this.63) > 8f)
						{
							this.61 = false;
						}
						else
						{
							num3 = 4.X;
							num4 = 4.Y;
							this.16 = false;
						}
					}
					else
					{
						this.62 = false;
						this.61 = false;
					}
				}
			}
			else
			{
				this.62 = false;
				this.61 = false;
			}
			if (!this.3.10 || this.27 || this.44.Count <= 0 || this.61)
			{
				goto IL_8C0;
			}
			float num11 = this.4.1 * 0.15f;
			using (List<2034>.Enumerator enumerator = this.44.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					2255.2259 10 = new 2255.2259();
					10.2 = <<EMPTY_NAME>>;
					10.1 = enumerator.Current;
					Predicate<2034> 11 = new Predicate<2034>(10.1);
					208 12 = 10.1.18 - 2.18;
					int num12 = (int)(num3 + 12.X);
					int num13 = (int)(num4 + 12.Y);
					2034 13 = this.4.63(num12, num13, num11, true, 11);
					if (13 != null)
					{
						if (208.Distance(10.1.18, 13.18) < num11)
						{
							num3 = 13.18.X - 12.X;
							num4 = 13.18.Y - 12.Y;
							this.16 = false;
							break;
						}
						if (208.Distance(10.1.18, 13.2()) < num11)
						{
							num3 = 13.2().X - 12.X;
							num4 = 13.2().Y - 12.Y;
							this.16 = false;
							break;
						}
					}
					else if (this.46 < 0 && 10.1.8 != 10.1.GetCurrentPosition())
					{
						208 14 = 10.1.GetCurrentPosition() - 10.1.8;
						num12 += (int)14.X;
						num13 += (int)14.Y;
						13 = this.4.63(num12, num13, num11, true, 11);
						if (13 != null)
						{
							if (208.Distance(10.1.2(), 13.18) < num11)
							{
								num3 = 13.18.X - 12.X - 14.X;
								num4 = 13.18.Y - 12.Y - 14.Y;
								this.16 = false;
								break;
							}
							if (208.Distance(10.1.2(), 13.2()) < num11)
							{
								num3 = 13.2().X - 12.X - 14.X;
								num4 = 13.2().Y - 12.Y - 14.Y;
								this.16 = false;
								break;
							}
						}
					}
				}
				goto IL_8C0;
			}
		}
		if (this.53[5].6 == 198.Red)
		{
			this.53[5].39(198.White, 100, false, (1046)0);
		}
		IL_8C0:
		if (this.16)
		{
			num3 = (float)this.7.4(num3);
			num4 = (float)this.7.4(num4);
		}
		bool flag3;
		if (this.3.10)
		{
			2329 15 = this.3.59;
			if (15 != (2329)1)
			{
				if (15 == (2329)2)
				{
					if (this.27)
					{
						this.26 = this.2();
						207 16 = new 207((int)Math.Min(this.25.X, this.26.X), (int)Math.Min(this.25.Y, this.26.Y), (int)Math.Abs(this.26.X - this.25.X), (int)Math.Abs(this.26.Y - this.25.Y));
						foreach (2034 17 in this.4.34.FindAll((2034 1) => 1.IsActive()))
						{
							if (16.Contains((int)1662.69.15((float)((int)17.8.X)), (int)1662.69.16((float)((int)17.8.Y))))
							{
								this.SelectObject(17);
							}
							else
							{
								this.20(17);
							}
						}
						if (this.44.Count == 0)
						{
							this.44();
						}
					}
					else if (this.34 != null && this.34 != this.50 && this.46 >= 0)
					{
						208 18 = new 208(num3, num4);
						208 19 = this.34.54[this.46];
						if (!this.6.5())
						{
							this.6.15((2452)0, (2451)12, null);
							this.6.28(this.34, this.46);
							if (!this.43)
							{
								this.6.16 = true;
							}
						}
						if (18 != 19)
						{
							this.3.85 = true;
							this.35 = true;
							this.34.18(18, this.46);
						}
					}
					else if (this.44.Count > 0 && this.33 != null)
					{
						this.MoveSelectionTo(num3, num4, false);
					}
				}
			}
			else
			{
				this.57 = this.3.103(1535.5.X);
				this.58(this.57, this.3.62, this.3.63);
				if (this.32)
				{
					if (this.33 != null)
					{
						2275 20 = this.3.10(this.33.2);
						if (this.33.HasObjectType(2047.Slider))
						{
							2123 21 = (2123)this.33;
							int 22 = 21.2;
							int 23 = 21.5;
							21.15(this.57);
							if (21.2 != 22)
							{
								this.35 = true;
								this.33 = 21;
								this.4.2(true);
							}
							else
							{
								20 = null;
							}
						}
						else if (this.33.HasObjectType(2047.Spinner))
						{
							int num14 = this.3.76.27((double)this.57);
							if (num14 > this.33.1)
							{
								this.35 = true;
								this.33.SetEndTime(num14);
							}
							else
							{
								20 = null;
							}
						}
						else
						{
							20 = null;
						}
						if (20 != null)
						{
							this.3.85 = true;
							20.10(true, true);
							this.3.85 = false;
						}
						this.33.Update();
					}
					else if (this.38 != null)
					{
						this.ClearSelection();
						this.3.85 = true;
					}
				}
				else
				{
					if (this.27)
					{
						int num15 = Math.Min(Math.Max(this.3.62, this.57), this.3.63);
						HashSet<2034> hashSet = new HashSet<2034>(this.44);
						using (List<2034>.Enumerator enumerator2 = this.4.34.GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								2034 24 = enumerator2.Current;
								bool flag = hashSet.Contains(24);
								if ((24.1 >= this.56 && 24.1 <= num15) || (24.1 <= this.56 && 24.1 >= num15) || (24.2 >= this.56 && 24.2 <= num15) || (24.2 <= this.56 && 24.2 >= num15))
								{
									if (!flag || this.21 != (2255.2257)0)
									{
										this.SelectObject(24);
									}
								}
								else if (flag)
								{
									this.20(24);
								}
							}
							goto IL_1618;
						}
					}
					if (this.44.Count > 0 && this.33 != null)
					{
						2255.2260 25 = new 2255.2260();
						int num16 = this.3.103(1535.5.X);
						num16 = (1549.3 ? (num16 - this.29) : this.3.76.27((double)(num16 - this.29)));
						25.1 = num16 - this.33.1;
						bool flag2 = true;
						for (int i = 0; i < this.44.Count; i++)
						{
							2034 26 = this.44[i];
							if (26.1 + 25.1 < 0 || 26.1 + 25.1 >= 1226.9())
							{
								flag2 = false;
								break;
							}
						}
						if (flag2 && !2255.54[2357.NoteLock] && 25.1 != 0)
						{
							this.35 = true;
							this.44.ForEach(new Action<2034>(25.1));
							this.4.2(true);
							this.3.85 = true;
							this.3.17(25.1 > 0, false, true, true);
						}
					}
				}
			}
		}
		else
		{
			this.46 = -1;
			if (this.34 != null)
			{
				if (this.21 == (2255.2257)0)
				{
					for (int j = 0; j < this.34.54.Count; j++)
					{
						if (208.Distance(this.3(), this.34.54[j]) < 4f)
						{
							this.46 = j;
							break;
						}
					}
				}
				if (this.46 >= 0)
				{
					this.3.69 = true;
				}
				else if (this.3.69 && this.3.72 == (2339)1)
				{
					this.34 = null;
				}
			}
			this.9(new 208(num3, num4));
			num3 = (float)((int)num3);
			num4 = (float)((int)num4);
			switch (this.21)
			{
			case (2255.2257)1:
			case (2255.2257)2:
			case (2255.2257)4:
				if (this.21 != (2255.2257)2 || this.50 == null)
				{
					if (this.33 != null)
					{
						if (208.Distance(this.3(), this.33.18) < num5)
						{
							num3 = this.33.18.X;
							num4 = this.33.18.Y;
						}
						else if (208.Distance(this.3(), this.33.2()) < num5)
						{
							num3 = this.33.2().X;
							num4 = this.33.2().Y;
						}
					}
					208 27 = new 208(num3, num4);
					if (1662.69.24(27))
					{
						this.22 = new 2033(this.4, 27, 1226.16, 2255.54[2357.NewCombo] || this.62(), false, false, false, 0)
						{
							11 = true,
							31 = true
						};
						if (this.3.15 == 2147.Taiko)
						{
							198 28 = new 198(235, 69, 44);
							198 29 = new 198(67, 142, 172);
							198 30 = new 198(252, 184, 6);
							if (this.21 == (2255.2257)1)
							{
								if (2255.54[2357.Whistle] || 2255.54[2357.Clap])
								{
									this.22.30[0].3[1].3 = 29;
									this.22.30[0].3[1].7 = 29;
									this.22.30[0].6 = 29;
									this.22.30[1].6 = 29;
								}
								else
								{
									this.22.30[0].3[1].3 = 28;
									this.22.30[0].3[1].7 = 28;
									this.22.30[0].6 = 28;
									this.22.30[1].6 = 28;
								}
							}
							else if (this.21 == (2255.2257)2)
							{
								this.22.30[0].3[1].3 = 30;
								this.22.30[0].3[1].7 = 30;
								this.22.30[0].6 = 30;
								this.22.30[1].6 = 30;
							}
						}
						this.4.AddHitObject(this.22, false, true);
						this.4.2(false);
					}
				}
				else
				{
					this.6.15((2452)0, (2451)14, null);
					this.6.23(this.50, false);
					int 31 = this.50.2;
					this.50.14(1226.16);
					this.51 = new 208(num3, num4);
					int count = this.50.54.Count;
					if (count > 1 && this.51 != this.50.54[count - 1])
					{
						this.6.15((2452)0, (2451)10, null);
						this.6.28(this.50, count - 1);
					}
					this.50.17(this.51);
					this.50.Update();
					if (31 != this.50.2)
					{
						this.3.85 = true;
						this.3.86 = true;
					}
				}
				break;
			case (2255.2257)3:
				if (this.55 != null)
				{
					int num17 = this.3.104() + (int)1226.76();
					if (this.55.2 != num17 && num17 > this.55.1)
					{
						this.55.SetEndTime(Math.Max(this.55.1 + 1, num17));
						this.3.85 = true;
						this.3.86 = true;
					}
				}
				else
				{
					this.22 = new 2129(this.4, 1226.16, 1226.16, this.29());
					foreach (1433 32 in this.22.30)
					{
						32.15 = 0.4f;
						if (32.49 == 1065.TopLeft)
						{
							32.3.Clear();
						}
					}
					this.22.11 = true;
					this.22.31 = true;
					this.4.AddHitObject(this.22, false, true);
				}
				break;
			}
			this.32 = false;
			if (this.3.70)
			{
				if (this.33 != null)
				{
					if (this.44.Count <= 1 && (this.33.HasObjectType(2047.Slider) || this.33.HasObjectType(2047.Spinner)))
					{
						this.32 = (Math.Abs((float)1535.5.X - this.3.102((double)this.33.2)) < 6f);
					}
				}
				else
				{
					this.32 = (this.5(out flag3) != null);
				}
			}
			if (this.32)
			{
				1555.27(Cursors.SizeWE);
			}
			else if (this.21 != (2255.2257)0 && 1662.69.24(this.3()))
			{
				1555.27(Cursors.Cross);
				if (this.44.Count > 0)
				{
					this.ClearSelection();
				}
			}
			else
			{
				1555.26();
			}
		}
		IL_1618:
		if (this.44.Count == 1 && this.44[0].HasObjectType(2047.Slider))
		{
			this.45 = (2123)this.44[0];
			this.34 = this.45;
		}
		else if (this.50 != null)
		{
			this.45 = this.50;
			this.34 = this.50;
		}
		else if (this.33 != null && this.33.HasObjectType(2047.Slider))
		{
			this.34 = (2123)this.33;
		}
		else
		{
			this.45 = null;
			this.34 = this.45;
		}
		if (this.47)
		{
			this.44.Sort();
			this.52();
			this.53();
			this.54();
		}
		if (this.3.69)
		{
			this.3.72 = (2339)2;
		}
		else if (this.3.70)
		{
			this.3.72 = (2339)1;
		}
		else if (this.3.71)
		{
			this.3.72 = (2339)3;
		}
		else
		{
			this.3.72 = (2339)0;
		}
		this.4.74();
		if (this.38 == null)
		{
			this.3.16(true);
		}
		else
		{
			this.35 |= this.3.15(this.38, this.37, this.3.76.27((double)this.57));
		}
		this.59 = new 208(num3, num4);
		if (1662.23)
		{
			this.UpdateInfoText();
		}
		flag3 = (this.43 = false);
		this.47 = flag3;
	}

	// Token: 0x06002A74 RID: 10868 RVA: 0x000E15D8 File Offset: 0x000DF7D8
	internal override void Activate()
	{
		this.6.20(false, false);
		this.6.18 = true;
		1662.69.12(1f, false);
		this.3.67 = 12;
		this.17.7(true);
		this.17.7(true);
		base.Activate();
		this.6.18 = false;
	}

	// Token: 0x06002A75 RID: 10869 RVA: 0x000E1645 File Offset: 0x000DF845
	internal override void Deactivate()
	{
		this.46 = -1;
		this.66();
		this.ClearSelection();
		1535.19();
		this.17.7(false);
		base.Deactivate();
	}

	// Token: 0x06002A76 RID: 10870 RVA: 0x000E1674 File Offset: 0x000DF874
	internal override void Dispose()
	{
		1304.138.SetValue(this.23);
		if (2255.54 != null)
		{
			1304.78.2(2255.54[2357.DistSnap]);
		}
		if (this.65 != null)
		{
			this.65.Dispose();
		}
		1373 <<EMPTY_NAME>> = this.68;
		if (<<EMPTY_NAME>> != null)
		{
			<<EMPTY_NAME>>.17();
		}
		1373 2 = this.69;
		if (2 != null)
		{
			2.17();
		}
		1549.4(new 1549.1550(this.14));
		this.22();
		if (this.74 != null)
		{
			this.74.Dispose();
			this.74 = null;
		}
		base.Dispose();
	}

	// Token: 0x06002A77 RID: 10871 RVA: 0x000E171C File Offset: 0x000DF91C
	internal override void Draw()
	{
		base.Draw();
		if (this.27)
		{
			2329 <<EMPTY_NAME>> = this.3.59;
			if (<<EMPTY_NAME>> != (2329)1)
			{
				if (<<EMPTY_NAME>> == (2329)2)
				{
					this.12();
				}
			}
			else
			{
				this.13();
			}
		}
		if (this.60 != null)
		{
			1662.20.2();
			198 white = 198.White;
			int num = Math.Abs(1662.33 % 600 - 300);
			byte 2 = (byte)(255f * ((float)num / 300f));
			1662.20.3(this.60.1, new 198(white.R, white.G, white.B, 2));
			1662.20.3(this.60.2, new 198(white.R, white.G, white.B, 0));
			1662.20.4();
			this.60 = null;
		}
		if (this.34 != null && (this.21 == (2255.2257)0 || this.50 != null))
		{
			1662.13.1();
			for (int i = 0; i < this.34.54.Count; i++)
			{
				bool flag = i > 0 && this.34.54[i] == this.34.54[i - 1];
				208 3 = 1662.69.17(this.34.54[i]);
				1662.13.2(3 - 208.One * 4f, 3 + 208.One * 4f, 2255.9);
				1662.13.2(3 - 208.One * 3f, 3 + 208.One * 3f, flag ? 2255.11 : ((i == this.46) ? 2255.10 : 2255.8));
			}
			1662.13.3();
			1662.20.2();
			for (int j = 1; j < this.34.54.Count; j++)
			{
				1662.20.3(1662.69.17(this.34.54[j - 1]), (j - 1 == this.46) ? 2255.10 : 2255.8);
				1662.20.3(1662.69.17(this.34.54[j]), (j == this.46) ? 2255.10 : 2255.8);
			}
			1662.20.4();
		}
	}

	// Token: 0x06002A78 RID: 10872 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal virtual void OnReferenceBeatmapChanged()
	{
	}

	// Token: 0x06002A79 RID: 10873 RVA: 0x000E19F7 File Offset: 0x000DFBF7
	private new bool 4()
	{
		return this.46 >= 0 && this.45 != null && this.50 == null;
	}

	// Token: 0x06002A7A RID: 10874 RVA: 0x000E1A18 File Offset: 0x000DFC18
	private new 2275 5(out bool 1)
	{
		1 = false;
		2275 2 = this.31 as 2275;
		if (2 == null)
		{
			return null;
		}
		if (this.3.103((int)1555.21().X - 8) <= 2.8)
		{
			return 2;
		}
		if (this.3.103((int)1555.21().X + 8) >= 2.1)
		{
			1 = true;
			return 2;
		}
		return null;
	}

	// Token: 0x06002A7B RID: 10875 RVA: 0x000E1A84 File Offset: 0x000DFC84
	internal override bool HandleDragStart()
	{
		if (this.39)
		{
			return true;
		}
		this.41 = true;
		this.35 = false;
		this.36 = false;
		this.38 = null;
		this.25 = (this.26 = 1535.6);
		if (this.3.70 && this.46 < 0)
		{
			this.3.59 = (2329)1;
			int num = this.3.103(1535.5.X);
			this.38 = this.5(out this.37);
			if (this.33 != null)
			{
				this.6.19((2452)0, null);
				if (this.32)
				{
					if (this.45 != null)
					{
						this.6.13((2451)14, (2450)0);
						this.6.23(this.45, false);
					}
					else
					{
						this.6.13((2451)7, (2450)0);
						this.6.23(this.33, false);
					}
					this.36 = true;
				}
				else if (this.44.Count > 0)
				{
					this.6.13((2451)0, (2450)0);
					this.6.13((2451)7, (2450)256);
					this.6.21<2034>(this.44);
					this.36 = true;
				}
				this.29 = num - this.33.1;
			}
			else if (this.38 != null)
			{
				this.6.19((2452)2, null);
				this.6.13((2451)0, (2450)2304);
				this.6.23(this.38, false);
				this.36 = true;
				if (this.37)
				{
					this.3.88 = this.38.1 - (5000 - this.38.5(this.4.62(this.38).1));
				}
				else
				{
					this.3.88 = this.38.8 + (5000 - this.38.4(this.4.61(this.38).2));
				}
				this.29 = num - (this.37 ? this.38.1 : this.38.8);
			}
			else
			{
				this.56 = (this.57 = num);
				this.27 = true;
				this.ClearSelection();
			}
			this.41 = false;
			return true;
		}
		if (this.46 >= 0 || this.33 != null || (this.3.69 && !this.3.71))
		{
			this.3.59 = (2329)2;
			this.27 = true;
			if (this.50 != null)
			{
				this.27 = false;
			}
			else if (this.46 >= 0)
			{
				this.27 = false;
				this.6.15((2452)0, (2451)12, null);
				this.6.28(this.34, this.46);
				this.6.16 = true;
				this.36 = true;
			}
			else if (this.55 == null)
			{
				this.27 = (this.33 == null || this.33.HasObjectType(2047.Spinner));
				if (2255.54[2357.NoteLock])
				{
					return true;
				}
				if (this.33 != null && !this.33.HasObjectType(2047.Spinner) && this.33.3())
				{
					if (this.44.Find((2034 1) => !1.HasObjectType(2047.Spinner)) != null)
					{
						this.28 = this.3() - this.44[0].8;
						this.6.17<2034>((2452)0, (2451)1, this.44);
						this.36 = true;
					}
				}
			}
			this.41 = false;
			return true;
		}
		this.41 = false;
		return false;
	}

	// Token: 0x06002A7C RID: 10876 RVA: 0x000E1E98 File Offset: 0x000E0098
	internal override void HandleDragEnd()
	{
		this.41 = true;
		this.27 = false;
		this.28 = 208.Zero;
		this.29 = this.3.103(1535.5.X);
		this.46 = -1;
		this.6.16 = false;
		if (this.35)
		{
			this.3.12(true);
			this.6.20(false, false);
			if (this.3.59 == (2329)2)
			{
				this.4.2(true);
				if (this.45 != null && this.45.48.Count > 0)
				{
					this.45.48[0].OnSelected();
				}
			}
		}
		else if (this.36)
		{
			this.6.20(true, false);
		}
		this.35 = false;
		this.36 = false;
		this.38 = null;
		if (!this.40)
		{
			this.39 = false;
		}
		this.41 = false;
		base.HandleDragEnd();
	}

	// Token: 0x06002A7D RID: 10877 RVA: 0x000E1FA0 File Offset: 0x000E01A0
	internal new void 6(bool 1)
	{
		if (1)
		{
			this.6.16 = false;
			this.43 = true;
		}
		if (this.6.16)
		{
			if (this.4())
			{
				this.6.18((2452)0, (2451)13, this.45);
				this.6.11((2452)0, false);
				return;
			}
		}
		else
		{
			this.3.12(true);
			this.6.20(false, false);
		}
	}

	// Token: 0x06002A7E RID: 10878 RVA: 0x000E2014 File Offset: 0x000E0214
	internal new void 7(bool 1)
	{
		if (!this.40 && this.3.10 && !this.41 && this.3.59 - (2329)1 <= 1 && ((!this.27 && !this.4()) || (this.27 && 1)))
		{
			this.40 = true;
		}
	}

	// Token: 0x06002A7F RID: 10879 RVA: 0x000E2070 File Offset: 0x000E0270
	private void 8()
	{
		this.28 = 208.Zero;
		this.29 = this.3.103(1535.5.X);
		this.56 = (this.57 = this.29);
	}

	// Token: 0x06002A80 RID: 10880 RVA: 0x000E20B8 File Offset: 0x000E02B8
	private void 9(208 1)
	{
		208 2 = 1535.6;
		int num = (int)this.3().X;
		int num2 = (int)this.3().Y;
		int num3 = (int)1.X;
		int num4 = (int)1.Y;
		2034 3 = null;
		if (this.3.70)
		{
			int num5 = this.3.103(1535.5.X);
			2647 4 = null;
			foreach (2275 5 in this.3.6.13)
			{
				if (num5 > 5.8 && num5 < 5.1)
				{
					4 = 5;
					break;
				}
			}
			this.31 = 4;
			if (this.50 != null)
			{
				goto IL_32F;
			}
			double num6 = 1000.0;
			using (List<1371>.Enumerator enumerator2 = this.3.65.28.FindAll(new Predicate<1371>(2255.2256.Instance.2)).GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					1371 6 = enumerator2.Current;
					1433 7 = (1433)6;
					2034 8 = (2034)7.8;
					double num7 = (double)208.Distance(2, 7.17 * 1662.70.3());
					bool flag = num5 > 8.1 && num5 < 8.2;
					bool flag2 = this.44.Contains(8);
					if ((num7 < (double)((float)7.35 * 7.15 * 1662.70.3() / 5f) && (num7 < num6 || flag2)) || flag)
					{
						num6 = num7;
						3 = 8;
						if (flag2)
						{
							break;
						}
					}
				}
				goto IL_32F;
			}
		}
		foreach (2034 9 in this.44)
		{
			if (208.Distance(this.3(), 9.8) < this.4.1)
			{
				3 = 9;
			}
			if (9.HasObjectType(2047.Slider) && 9.IsActive())
			{
				2123 10 = 9 as 2123;
				if (10.55 != null)
				{
					foreach (1051 11 in 10.55)
					{
						if (208.Distance(this.3(), 11.1) < this.4.1)
						{
							3 = 9;
							break;
						}
					}
				}
			}
			if (3 != null)
			{
				break;
			}
		}
		if (3 == null)
		{
			3 = ((this.21 == (2255.2257)0) ? this.4.63(num, num2, this.4.1 * 0.8f, false, null) : ((!2255.54[2357.DistSnap]) ? this.4.65((float)num3, (float)num4, false, this.4.1 * 0.8f) : this.4.65((float)num, (float)num2, false, this.4.1 * 0.5f)));
		}
		IL_32F:
		this.33 = 3;
	}

	// Token: 0x06002A81 RID: 10881 RVA: 0x000E2430 File Offset: 0x000E0630
	private void 10()
	{
		if (this.39)
		{
			this.3.10 = false;
		}
		if (this.40)
		{
			this.3.57();
			this.8();
			this.9(this.2());
			this.27 = (this.33 == null || (!this.33.3() && this.46 < 0));
			if (this.42 && this.27)
			{
				this.39 = true;
				this.42 = false;
			}
			this.40 = false;
		}
	}

	// Token: 0x06002A82 RID: 10882 RVA: 0x000E24C5 File Offset: 0x000E06C5
	private void 11()
	{
		this.33 = null;
		this.34 = null;
	}

	// Token: 0x06002A83 RID: 10883 RVA: 0x000E24D8 File Offset: 0x000E06D8
	private void 12()
	{
		if (!(this.25 == this.26))
		{
			198 <<EMPTY_NAME>> = new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue, 180);
			208 2 = new 208(this.26.X, this.25.Y);
			208 3 = new 208(this.25.X, this.26.Y);
			1662.20.2();
			1662.20.3(this.25, <<EMPTY_NAME>>);
			1662.20.3(2, <<EMPTY_NAME>>);
			1662.20.3(2, <<EMPTY_NAME>>);
			1662.20.3(this.26, <<EMPTY_NAME>>);
			1662.20.3(this.26, <<EMPTY_NAME>>);
			1662.20.3(3, <<EMPTY_NAME>>);
			1662.20.3(3, <<EMPTY_NAME>>);
			1662.20.3(this.25, <<EMPTY_NAME>>);
			1662.20.4();
			1662.13.1();
			1662.13.2(this.25, this.26, this.13);
			1662.13.3();
		}
	}

	// Token: 0x06002A84 RID: 10884 RVA: 0x000E2608 File Offset: 0x000E0808
	private void 13()
	{
		if (this.56 != this.57)
		{
			float num = Math.Max((float)this.3.66.GetLeft(), this.3.102((double)Math.Min(this.56, this.57)));
			float num2 = Math.Min((float)this.3.66.GetRight(), this.3.102((double)Math.Max(this.56, this.57)));
			if (num != num2)
			{
				1662.13.1();
				1662.13.2(new 208(num, (float)this.3.66.GetTop()), new 208(num2, (float)this.3.66.GetBottom()), this.14);
				1662.13.3();
			}
		}
	}

	// Token: 0x06002A85 RID: 10885 RVA: 0x000E26E4 File Offset: 0x000E08E4
	internal override bool IsInputEnabled()
	{
		return base.IsInputEnabled();
	}

	// Token: 0x06002A86 RID: 10886 RVA: 0x000E26EC File Offset: 0x000E08EC
	internal override void SetInputEnabled(bool 1)
	{
		base.SetInputEnabled(1);
		this.4.39.22 = 1;
		if (this.74 != null)
		{
			this.74.39.22 = 1;
		}
		this.63((2255.2257)0);
	}

	// Token: 0x06002A87 RID: 10887 RVA: 0x000E2726 File Offset: 0x000E0926
	internal override bool HandleWheelDown()
	{
		if (1549.1)
		{
			this.24(Math.Max(1, this.3.96() / 2));
			return true;
		}
		return false;
	}

	// Token: 0x06002A88 RID: 10888 RVA: 0x000E274B File Offset: 0x000E094B
	internal override bool HandleWheelUp()
	{
		if (1549.1)
		{
			this.24(Math.Min(16, this.3.96() * 2));
			return true;
		}
		return false;
	}

	// Token: 0x06002A89 RID: 10889 RVA: 0x000E2774 File Offset: 0x000E0974
	internal override bool HandleAltWheelUp()
	{
		if (1549.1)
		{
			2255.2257 <<EMPTY_NAME>> = (2255.2257)Math.Max(0.1f, (float)(this.21 - (2255.2257)1));
			if (<<EMPTY_NAME>> != this.21)
			{
				this.63(<<EMPTY_NAME>>);
			}
			return true;
		}
		if (!this.17.14() && !1662.69.24(this.3()) && (this.21 != (2255.2257)0 || this.3.59 != (2329)2 || this.27))
		{
			return false;
		}
		this.26((double)((float)this.23 + (1549.3 ? 0.01f : 0.1f)));
		return true;
	}

	// Token: 0x06002A8A RID: 10890 RVA: 0x000E2814 File Offset: 0x000E0A14
	internal override bool HandleAltWheelDown()
	{
		if (1549.1)
		{
			2255.2257 <<EMPTY_NAME>> = (2255.2257)Math.Min(3, (int)(this.21 + 1));
			if (<<EMPTY_NAME>> != this.21)
			{
				this.63(<<EMPTY_NAME>>);
			}
			return true;
		}
		if (!this.17.14() && !1662.69.24(this.3()) && (this.21 != (2255.2257)0 || this.3.59 != (2329)2 || this.27))
		{
			return false;
		}
		this.26((double)((float)this.23 - (1549.3 ? 0.01f : 0.1f)));
		return true;
	}

	// Token: 0x06002A8B RID: 10891 RVA: 0x000E28AC File Offset: 0x000E0AAC
	internal override bool HandleDoubleClick()
	{
		if (!this.IsInputEnabled())
		{
			return false;
		}
		if (this.44.Count > 0 && ((this.3.69 && this.21 == (2255.2257)0) || this.3.70))
		{
			1226.4(this.44[0].1, false, false);
			return true;
		}
		return false;
	}

	// Token: 0x06002A8C RID: 10892 RVA: 0x000E2910 File Offset: 0x000E0B10
	internal override bool HandleKey(200 1, bool 2)
	{
		if (2)
		{
			1532 3 = 1548.9(1, 1531.Universal);
			if (this.3.15 != 2147.OsuMania && this.3.31 && this.3.69 && 1226.32 != (1042)0)
			{
				switch (3)
				{
				case 1532.TaikoInnerLeft:
					this.59(false);
					return true;
				case 1532.TaikoInnerRight:
					this.59(false);
					return true;
				case 1532.TaikoOuterLeft:
					this.59(true);
					return true;
				case 1532.TaikoOuterRight:
					this.59(true);
					return true;
				}
			}
			if (1549.3)
			{
				if (1 <= 200.E)
				{
					switch (1)
					{
					case 200.D1:
						this.24(1);
						return true;
					case 200.D2:
						this.24(2);
						return true;
					case 200.D3:
						this.24(3);
						return true;
					case 200.D4:
						this.24(4);
						return true;
					case 200.D5:
						this.24(5);
						return true;
					case 200.D6:
						this.24(6);
						return true;
					case 200.D7:
						this.24(7);
						return true;
					case 200.D8:
						this.24(8);
						return true;
					case 200.D9:
						this.24(9);
						return true;
					default:
						if (1 != 200.E)
						{
							goto IL_405;
						}
						break;
					}
				}
				else if (1 != 200.Q)
				{
					if (1 == 200.R)
					{
						if (1549.1)
						{
							this.3.42();
						}
						else
						{
							this.68.18(1254.Drum, false);
						}
						return true;
					}
					if (1 != 200.W)
					{
						goto IL_405;
					}
				}
				1254 4 = (1254)this.68.18;
				1254 5;
				if (1 != 200.Q)
				{
					if (1 != 200.W)
					{
						5 = 1254.Soft;
					}
					else
					{
						5 = 1254.Normal;
					}
				}
				else
				{
					5 = 1254.None;
				}
				1254 6 = 5;
				if (6 != 4)
				{
					if (this.44.Count > 0)
					{
						this.6.20(false, false);
					}
					this.68.18(6, false);
				}
				return true;
			}
			if (1549.1)
			{
				if (1 <= 200.M)
				{
					if (1 == 200.Tab)
					{
						this.60();
						return true;
					}
					switch (1)
					{
					case 200.A:
						this.SelectAll();
						return true;
					case 200.D:
						this.18();
						return true;
					case 200.E:
						this.69.18(1254.Soft, false);
						return true;
					case 200.G:
						this.75();
						return true;
					case 200.H:
						this.FlipHorizontally();
						return true;
					case 200.J:
						this.FlipVertically();
						return true;
					case 200.M:
						this.24(this.3.96() * 2 % 15);
						return true;
					}
				}
				else
				{
					switch (1)
					{
					case 200.Q:
						this.69.18(1254.None, false);
						return true;
					case 200.R:
						this.69.18(1254.Drum, false);
						return true;
					case 200.S:
					case 200.T:
					case 200.U:
						break;
					case 200.V:
						this.Paste();
						return true;
					case 200.W:
						this.69.18(1254.Normal, false);
						return true;
					case 200.X:
						this.CutSelection();
						return true;
					default:
						if (1 == 200.OemComma)
						{
							this.76();
							return true;
						}
						if (1 == 200.OemPeriod)
						{
							this.77();
							return true;
						}
						break;
					}
				}
			}
			else
			{
				switch (1548.9(1, 1531.Editor))
				{
				case 1532.SelectTool:
					this.63((2255.2257)0);
					return true;
				case 1532.NormalTool:
					this.63((2255.2257)1);
					return true;
				case 1532.SliderTool:
					if (this.3.15 == 2147.OsuMania)
					{
						this.63((2255.2257)4);
					}
					else
					{
						this.63((2255.2257)2);
					}
					return true;
				case 1532.SpinnerTool:
					this.63((2255.2257)3);
					return true;
				case 1532.NewComboToggle:
					this.30(2357.NewCombo);
					return true;
				case 1532.WhistleToggle:
					this.30(2357.Whistle);
					return true;
				case 1532.FinishToggle:
					this.30(2357.Finish);
					return true;
				case 1532.ClapToggle:
					this.30(2357.Clap);
					return true;
				case 1532.GridSnapToggle:
					this.30(2357.GridSnap);
					return true;
				case 1532.DistSnapToggle:
					this.30(2357.DistSnap);
					return true;
				case 1532.NoteLockToggle:
					this.30(2357.NoteLock);
					return true;
				case 1532.NudgeLeft:
					this.73();
					return true;
				case 1532.NudgeRight:
					this.74();
					return true;
				default:
					if (1 == 200.Delete)
					{
						this.DeleteSelection();
						return true;
					}
					if (1 == 200.Add)
					{
						this.72();
						return true;
					}
					if (1 == 200.Subtract)
					{
						this.71();
						return true;
					}
					break;
				}
			}
		}
		IL_405:
		if (this.44 != null && this.44.Count != 0 && 1549.1 && !this.73)
		{
			float num = 1f;
			float x = this.44[0].18.X;
			float y = this.44[0].18.Y;
			if (this.16)
			{
				num = (float)(this.7.1() / (2337)2) + 0.1f;
			}
			switch (1)
			{
			case 200.Left:
				this.MoveSelectionTo(x - num, y, true);
				return true;
			case 200.Up:
				this.MoveSelectionTo(x, y - num, true);
				return true;
			case 200.Right:
				this.MoveSelectionTo(x + num, y, true);
				return true;
			case 200.Down:
				this.MoveSelectionTo(x, y + num, true);
				return true;
			}
		}
		return base.HandleKey(1, 2);
	}

	// Token: 0x06002A8D RID: 10893 RVA: 0x000E2E0C File Offset: 0x000E100C
	private bool 14(object 1, 200 2)
	{
		if (this.15 && 2 - 200.Left <= 3)
		{
			if (!1549.10(200.Up) && !1549.10(200.Down) && !1549.10(200.Left) && !1549.10(200.Right))
			{
				this.6.20(false, false);
				this.15 = false;
			}
			return true;
		}
		return false;
	}

	// Token: 0x06002A8E RID: 10894 RVA: 0x000E2E64 File Offset: 0x000E1064
	internal override bool HandleClick()
	{
		if (!this.IsInputEnabled())
		{
			return false;
		}
		if (this.IsEditingSliderPath())
		{
			this.17.2(true);
		}
		bool flag = 1535.14 == 199.Pressed;
		bool flag2 = 1535.43 == 199.Pressed;
		this.41 = true;
		if (flag)
		{
			2034 <<EMPTY_NAME>> = null;
			if (2255.54[2357.NoteLock] && 1549.1 && 1549.3 && this.33 != null)
			{
				this.43(this.33);
				return true;
			}
			this.49 = (!this.32 || this.33 != this.55);
			if (this.3.70 && this.50 == null)
			{
				this.63((2255.2257)0);
			}
			this.49 = true;
			if (this.21 != (2255.2257)0)
			{
				this.65();
				int num = this.3.104();
				switch (this.21)
				{
				case (2255.2257)1:
					if (1662.69.24(this.59) && 1662.69.24(this.3()))
					{
						<<EMPTY_NAME>> = new 2033(this.4, this.59, num, 2255.54[2357.NewCombo] || this.62(), 2255.54[2357.Whistle], 2255.54[2357.Finish], 2255.54[2357.Clap], 0);
					}
					break;
				case (2255.2257)2:
					this.39 = true;
					if (this.50 == null)
					{
						if (1662.69.24(this.59) && 1662.69.24(this.3()))
						{
							this.50 = new 2123(this.4, this.59, num, 2255.54[2357.NewCombo] || this.62(), this.29(), this.12, 0, 0.0, null, null, 0)
							{
								67 = true
							};
							<<EMPTY_NAME>> = this.50;
						}
					}
					else
					{
						this.50.16(false, false);
					}
					break;
				case (2255.2257)3:
					if (this.55 == null && !this.3.70)
					{
						this.55 = new 2129(this.4, num, (int)((double)num + 1226.76()), this.29());
						this.55.SetNewCombo(true);
						<<EMPTY_NAME>> = this.55;
					}
					break;
				}
				if (<<EMPTY_NAME>> != null)
				{
					this.6.18((2452)0, (2451)8, <<EMPTY_NAME>>);
					this.4.AddHitObject(<<EMPTY_NAME>>, true, true);
					if (<<EMPTY_NAME>> == this.55)
					{
						if (<<EMPTY_NAME>> != this.4.59())
						{
							int index = this.4.70(<<EMPTY_NAME>>) + 1;
							2034 2 = this.4.34[index];
							if (!2.IsNewCombo())
							{
								this.6.13((2451)5, (2450)0);
								this.6.23(2, false);
								2.SetNewCombo(true);
							}
						}
					}
					else if (2255.54[2357.NewCombo])
					{
						this.30(2357.NewCombo);
					}
					<<EMPTY_NAME>>.35 = (1254)this.68.18;
					<<EMPTY_NAME>>.36 = (1254)this.69.18;
					this.4.2(true);
					if (this.4.37.Count > 0)
					{
						this.6.26<2034>(this.4.37, (2450)65536, false);
						this.4.37.Clear();
					}
					if (<<EMPTY_NAME>> is 2033)
					{
						this.3.2(true);
					}
					else
					{
						this.3.85 = true;
					}
					return true;
				}
			}
			else
			{
				if (1549.1)
				{
					if (this.45 != null && (this.33 == null || this.33 == this.45) && this.44.Count == 1 && !this.3.70 && (!this.3.10 || this.27 || this.46 >= 0))
					{
						2123 3 = this.45;
						if (this.46 < 0)
						{
							float num2 = 0f;
							int 4 = 0;
							208 5 = this.3();
							for (int i = 1; i < 3.54.Count; i++)
							{
								208 6 = 3.54[i];
								208 7 = 3.54[i - 1];
								if (!(7 == 6))
								{
									float num3 = 1052.19(((5.X - 7.X) * (6.X - 7.X) + (5.Y - 7.Y) * (6.Y - 7.Y)) / 208.DistanceSquared(7, 6), 0f, 1f);
									float num4 = 208.DistanceSquared(new 208(7.X + num3 * (6.X - 7.X), 7.Y + num3 * (6.Y - 7.Y)), 5);
									if (num2 == 0f || num4 <= num2)
									{
										4 = i;
										num2 = num4;
									}
								}
							}
							3.19(4, 5);
							return true;
						}
						208 8 = 3.54[this.46];
						if (this.46 != 0 && this.46 != 3.54.Count - 1 && 8 != 3.54[this.46 - 1] && 8 != 3.54[this.46 + 1])
						{
							this.6.15((2452)0, (2451)7, null);
							this.6.23(3, true);
							3.19(this.46, 3.54[this.46]);
							return true;
						}
					}
					if (this.33 != null)
					{
						if (this.33.3() && this.44.Count > 1)
						{
							this.20(this.33);
							this.39 = true;
						}
						else
						{
							this.SelectObject(this.33);
						}
						return true;
					}
				}
				if (this.46 >= 0)
				{
					if (this.45 == null && this.34 != null)
					{
						this.45 = this.34;
						this.SelectObject(this.45);
					}
					return true;
				}
				if (this.33 == null)
				{
					if (!this.32 && !this.3.71)
					{
						this.ClearSelection();
					}
					return true;
				}
				if (this.32 && this.33 == this.55)
				{
					this.ClearSelection();
					this.SelectObject(this.55);
					this.69(this.55.2);
					return true;
				}
				if (!this.32 && this.33 == this.45)
				{
					bool flag3 = false;
					for (int j = 0; j < this.45.9().Count; j++)
					{
						2033 9 = this.45.9()[j];
						bool flag4 = (!flag3 && this.3.70) ? (Math.Abs(this.3.102((double)9.1) - (float)1535.5.X) < this.4.1 * 0.5f) : (208.DistanceSquared(this.3(), 9.8) < this.4.1 * this.4.1);
						if (9.3() != flag4)
						{
							9.4(flag4);
							if (flag4)
							{
								9.49.6 = 198.Red;
							}
							else if (j < 2)
							{
								9.OnSelected();
								9.49.6 = 198.White;
							}
							this.47 = true;
						}
						if (flag4)
						{
							flag3 = true;
						}
					}
					this.45.12(!flag3);
				}
				if (this.33.3())
				{
					return true;
				}
				this.ClearSelection();
				this.SelectObject(this.33);
			}
		}
		else if (flag2)
		{
			if (this.3.70 && this.31 != null && this.31.10 == 2635.Break)
			{
				2275 10 = this.31 as 2275;
				if (!this.3.3(10, true))
				{
					this.3.21(10, true);
					this.6.20(false, false);
				}
				return true;
			}
			if (this.50 != null)
			{
				2123 11 = this.50;
				bool 12 = 11.70 || 11.54.Count <= 1;
				this.70(12);
			}
			else if (this.55 != null)
			{
				this.68();
			}
			else if (this.46 >= 0 && this.34 != null && this.34.54.Count > 2)
			{
				this.6.15((2452)0, (2451)11, null);
				this.6.28(this.45, this.46);
				this.34.5();
				this.34.54.RemoveAt(this.46);
				if (this.46 == 0)
				{
					this.34.8 = (this.34.18 = this.34.54[0]);
					this.34.SetPosition(this.34.54[0], false);
				}
				this.34.6 = 0.0;
				this.34.RebuildPathAndTiming(true);
				this.3.2(true);
			}
			else if (this.33 != null)
			{
				if (this.33.3())
				{
					this.DeleteSelection();
					this.11();
				}
				else if (1226.32 == (1042)0 || this.21 == (2255.2257)0)
				{
					this.6.18((2452)0, (2451)9, this.33);
					this.4.29(this.33, true);
					this.11();
					this.3.87 = true;
					this.3.2(true);
				}
				else
				{
					this.30(2357.NewCombo);
				}
			}
			else if (this.21 - (2255.2257)1 <= 1)
			{
				this.30(2357.NewCombo);
			}
		}
		return true;
	}

	// Token: 0x06002A8F RID: 10895 RVA: 0x000E38DC File Offset: 0x000E1ADC
	internal override bool HandleRelease()
	{
		if (1535.20)
		{
			this.39 = false;
			this.42 = false;
		}
		this.17.2(false);
		return base.HandleRelease();
	}

	// Token: 0x06002A90 RID: 10896 RVA: 0x000E3908 File Offset: 0x000E1B08
	internal override bool HandleEscape()
	{
		if (this.50 != null)
		{
			this.4.29(this.50, true);
			this.50 = null;
			return false;
		}
		if (this.55 != null)
		{
			this.4.29(this.55, true);
			this.55 = null;
			return false;
		}
		if (this.44.Count > 0)
		{
			this.ClearSelection();
			return false;
		}
		if (this.21 != (2255.2257)0)
		{
			this.63((2255.2257)0);
			return false;
		}
		return true;
	}

	// Token: 0x06002A91 RID: 10897 RVA: 0x000E3988 File Offset: 0x000E1B88
	internal void 15(List<object> 1)
	{
		this.ClearSelection();
		foreach (object obj in 1)
		{
			2034 2 = (2034)obj;
			this.SelectObject(2);
		}
	}

	// Token: 0x06002A92 RID: 10898 RVA: 0x000E39E4 File Offset: 0x000E1BE4
	internal void 16()
	{
		this.50 = null;
		this.55 = null;
		this.44.Clear();
		this.44 = this.4.34.FindAll((2034 1) => 1.3());
		this.47 = true;
		this.45 = null;
		this.46 = -1;
		this.34 = null;
	}

	// Token: 0x06002A93 RID: 10899 RVA: 0x000E3A5C File Offset: 0x000E1C5C
	internal void 17(2123 1, List<int> 2, int 3)
	{
		try
		{
			int num = 3;
			while (num < 2.Count && 2[num] >= 0)
			{
				2033 4 = 1.9()[2[num]];
				4.4(true);
				4.49.6 = 198.Red;
				num++;
			}
			this.45 = 1;
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06002A94 RID: 10900 RVA: 0x000E3AC8 File Offset: 0x000E1CC8
	internal virtual void CutSelection()
	{
		if (this.44.Count != 0)
		{
			if (this.3.10)
			{
				this.7(false);
				this.39 = this.40;
			}
			this.CopySelection();
			this.DeleteSelection();
		}
	}

	// Token: 0x06002A95 RID: 10901 RVA: 0x000E3B04 File Offset: 0x000E1D04
	internal void 18()
	{
		if (this.44.Count == 0)
		{
			return;
		}
		this.6(true);
		this.7(false);
		this.42 = this.40;
		List<2034> list = new List<2034>();
		int num = this.44[0].2;
		int <<EMPTY_NAME>> = this.44[0].1;
		for (int i = 0; i < this.44.Count; i++)
		{
			if (this.44[i].2 > num)
			{
				num = this.44[i].2;
			}
			if (this.44[i].1 < <<EMPTY_NAME>>)
			{
				<<EMPTY_NAME>> = this.44[i].1;
			}
		}
		num = this.3.76.27((double)num + 1226.76());
		this.6.15((2452)0, (2451)8, null);
		foreach (2034 2 in this.44)
		{
			2034 3 = 2.Clone();
			if (2 is 2123)
			{
				((2123)3).13(num + (2.1 - <<EMPTY_NAME>>), false);
			}
			else
			{
				3.SetStartTime(num + (2.1 - <<EMPTY_NAME>>));
			}
			list.Add(3);
			this.4.AddHitObject(3, true, true);
		}
		this.6.24<2034>(list, false);
		this.6.26<2034>(this.4.37, (2450)65536, false);
		this.ClearSelection();
		this.44 = list;
		this.21();
		this.4.2(false);
		this.4.37.Clear();
		this.3.2(true);
	}

	// Token: 0x06002A96 RID: 10902 RVA: 0x000E3CF0 File Offset: 0x000E1EF0
	internal virtual void DeleteSelection()
	{
		if (this.44.Count != 0)
		{
			this.19(true);
		}
	}

	// Token: 0x06002A97 RID: 10903 RVA: 0x000E3D08 File Offset: 0x000E1F08
	internal void 19(bool 1)
	{
		if (1)
		{
			this.6(true);
			this.6.17<2034>((2452)0, (2451)9, this.44);
		}
		this.4.28(this.44.ToArray());
		this.44.Clear();
		this.4.2(true);
		this.3.87 = true;
		if (1)
		{
			this.3.2(true);
		}
	}

	// Token: 0x06002A98 RID: 10904 RVA: 0x000E3D7C File Offset: 0x000E1F7C
	internal virtual void SelectObjects(2036[] 1)
	{
		if (this.38 == null)
		{
			this.ClearSelection();
			this.44 = new List<2034>();
			foreach (2036 2 in 1)
			{
				this.44.Add(2 as 2034);
			}
			this.44.ForEach(new Action<2034>(2255.2256.Instance.9));
			this.47 = true;
		}
	}

	// Token: 0x06002A99 RID: 10905 RVA: 0x000E3DEC File Offset: 0x000E1FEC
	internal virtual void SelectObject(2034 1)
	{
		if (this.38 == null)
		{
			if (this.21 != (2255.2257)0)
			{
				this.63((2255.2257)0);
			}
			if (!this.44.Contains(1))
			{
				1.4(true);
				this.44.Add(1);
				this.47 = true;
			}
		}
	}

	// Token: 0x06002A9A RID: 10906 RVA: 0x000E3E38 File Offset: 0x000E2038
	internal void 20(2034 1)
	{
		if (this.44.Contains(1))
		{
			1.4(false);
			this.44.Remove(1);
			this.47 = true;
		}
	}

	// Token: 0x06002A9B RID: 10907 RVA: 0x000E3E64 File Offset: 0x000E2064
	internal override void SelectAll()
	{
		if (this.38 == null)
		{
			this.63((2255.2257)0);
			this.7(true);
			this.ClearSelection();
			this.44.AddRange(this.4.34);
			this.47 = true;
			this.21();
		}
	}

	// Token: 0x06002A9C RID: 10908 RVA: 0x000E3EB0 File Offset: 0x000E20B0
	internal override void ClearSelection()
	{
		this.44();
		if (this.44.Count != 0)
		{
			this.7(false);
			this.44.ForEach(new Action<2034>(2255.2256.Instance.10));
			if (this.45 != null)
			{
				this.45.47();
			}
			this.47 = true;
			this.44.Clear();
		}
	}

	// Token: 0x06002A9D RID: 10909 RVA: 0x000E3F17 File Offset: 0x000E2117
	internal void 21()
	{
		this.44.ForEach(new Action<2034>(2255.2256.Instance.11));
	}

	// Token: 0x06002A9E RID: 10910 RVA: 0x000E3F34 File Offset: 0x000E2134
	internal override void CopySelection()
	{
		this.22();
		this.3.76.27.Clear();
		this.44.Sort();
		string text = string.Empty;
		int <<EMPTY_NAME>> = 1226.16;
		if (this.44.Count > 0)
		{
			text = " (";
			foreach (2034 2 in this.44)
			{
				text = text + 2.GetComboNumber().ToString() + ",";
			}
			text = text.Trim(new char[]
			{
				','
			}) + ")";
			<<EMPTY_NAME>> = this.44[0].1;
		}
		string str = string.Format("{0:00}:{1:00}:{2:000}", <<EMPTY_NAME>> / 60000, <<EMPTY_NAME>> % 60000 / 1000, <<EMPTY_NAME>> % 1000);
		try
		{
			Clipboard.SetText(str + text + " - ");
		}
		catch (Exception)
		{
			1763.4(1568.1(2679.General_Editor_ClipboardNotAvailable));
		}
		foreach (2034 3 in this.44)
		{
			2034 item = 3.Clone();
			this.20.Add(item);
		}
		if (this.44.Count == 1 && 2255.54[2357.NoteLock])
		{
			this.72 = this.44[0];
		}
	}

	// Token: 0x06002A9F RID: 10911 RVA: 0x000E40F8 File Offset: 0x000E22F8
	internal override void Paste()
	{
		if (this.20 == null || this.20.Count == 0)
		{
			if (this.3.76.27 != null && this.3.76.27.Count > 0)
			{
				this.3.76.Paste();
			}
			return;
		}
		this.6(true);
		this.6.15((2452)0, (2451)8, null);
		this.ClearSelection();
		this.7(false);
		this.39 = this.40;
		this.20.Sort((2034 1, 2034 2) => 1.1.CompareTo(2.1));
		int num = (1226.75() ? this.3.76.27((double)1226.16) : 1226.16) - this.20[0].1;
		foreach (2034 <<EMPTY_NAME>> in this.20)
		{
			2034 3 = <<EMPTY_NAME>>.Clone();
			if (<<EMPTY_NAME>> is 2123)
			{
				((2123)3).13(3.1 + num, false);
			}
			else
			{
				3.SetStartTime(3.1 + num);
			}
			3.Update();
			this.4.AddHitObject(3, true, true);
			this.SelectObject(3);
			this.6.23(3, false);
			this.6.26<2034>(this.4.37, (2450)65536, false);
		}
		this.4.2(true);
		this.4.37.Clear();
		this.3.2(true);
	}

	// Token: 0x06002AA0 RID: 10912 RVA: 0x000E42CC File Offset: 0x000E24CC
	internal void 22()
	{
		if (this.20 == null)
		{
			return;
		}
		foreach (2034 <<EMPTY_NAME>> in this.20)
		{
			<<EMPTY_NAME>>.Dispose();
		}
		this.20.Clear();
	}

	// Token: 0x06002AA1 RID: 10913 RVA: 0x0001702D File Offset: 0x0001522D
	protected virtual bool SupportsDistanceSpacing()
	{
		return true;
	}

	// Token: 0x06002AA2 RID: 10914 RVA: 0x000E4330 File Offset: 0x000E2530
	private void 23(object 1, EventArgs 2)
	{
		if (this.44.Count == 0)
		{
			1763.2(1568.1(2679.EditorModeCompose_SelectNotesMessage), 1000, (1389)0);
			return;
		}
		if (this.71 == null)
		{
			this.71 = new 2307();
			this.71.Show(1662.13());
			this.71 = null;
		}
	}

	// Token: 0x06002AA3 RID: 10915 RVA: 0x000E438C File Offset: 0x000E258C
	internal void 24(int 1)
	{
		this.52 = true;
		1 = this.25(1);
		this.3.97(1);
		1304.144.7(1);
		1662.8.9(1);
		if (!this.SupportsDistanceSpacing() || !1549.2)
		{
			this.17.23((double)1, false, false);
			this.18.SetText("1/" + 1.ToString());
		}
	}

	// Token: 0x06002AA4 RID: 10916 RVA: 0x000E4405 File Offset: 0x000E2605
	internal int 25(int 1)
	{
		if (1 > 16)
		{
			1 = 1;
		}
		if (1 >= 10 && 1 <= 11)
		{
			1 = 12;
		}
		if (1 > 12 && 1 < 16)
		{
			1 = 16;
		}
		return 1;
	}

	// Token: 0x06002AA5 RID: 10917 RVA: 0x000E442C File Offset: 0x000E262C
	internal void 26(double 1)
	{
		1 = Math.Round(1052.20(1, 1304.138.1(), 1304.138.3()), 2);
		this.23 = 1;
		1304.138.SetValue(1);
		if (1549.2)
		{
			this.17.23(1, false, false);
			this.18.SetText(string.Format("{0:0.0#}x", this.23));
		}
	}

	// Token: 0x06002AA6 RID: 10918 RVA: 0x000E44A4 File Offset: 0x000E26A4
	protected void 27()
	{
		if (!this.17.6())
		{
			return;
		}
		if (!this.SupportsDistanceSpacing() || !1549.2)
		{
			int num = this.25((int)Math.Round(this.17.7));
			if (num != this.3.96())
			{
				this.24(num);
				return;
			}
		}
		else
		{
			double num2 = Math.Round(this.17.7, (!1549.3) ? 1 : 2);
			if (num2 != this.23)
			{
				this.26((double)((float)num2));
			}
		}
	}

	// Token: 0x06002AA7 RID: 10919 RVA: 0x000E452C File Offset: 0x000E272C
	protected virtual string GetDistanceSnapHint(int 1, 208 2, bool 3)
	{
		2255.2261 match = new 2255.2261();
		match.1 = 9;
		int 5;
		int num;
		208 6;
		208 7;
		string arg;
		if (3)
		{
			2034 4 = this.4.34.FindLast(new Predicate<2034>(match.1));
			if (4 == null || 4 is 2070)
			{
				return string.Empty;
			}
			5 = match.1;
			num = 4.2;
			6 = 2;
			7 = 4.GetEndPosition();
			arg = "Prev";
		}
		else
		{
			2034 8 = this.4.34.Find((2034 1) => 1.1 > match.1 + 1);
			if (8 == null || 8 is 2070)
			{
				return string.Empty;
			}
			5 = 8.1;
			num = match.1;
			6 = 8.8;
			7 = 2;
			arg = "Next";
		}
		int num2 = 5 - num;
		if (num2 > 3000)
		{
			return string.Empty;
		}
		double num3 = 1000.0 * (double)this.MeasureDistance(6, 7) / (this.4.GetSliderVelocityAt(5) * (double)num2);
		return string.Format("\n{1}: {0:f2}x", num3, arg);
	}

	// Token: 0x06002AA8 RID: 10920 RVA: 0x000E465C File Offset: 0x000E285C
	protected virtual float MeasureDistance(208 1, 208 2)
	{
		return 208.Distance(1, 2);
	}

	// Token: 0x06002AA9 RID: 10921 RVA: 0x000E4668 File Offset: 0x000E2868
	protected virtual void UpdateInfoText()
	{
		string text = string.Empty;
		if (this.34 != null && this.46 >= 0)
		{
			if (this.46 < this.34.54.Count)
			{
				208 <<EMPTY_NAME>> = this.34.54[this.46];
				this.70.6 = 198.LightSalmon;
				this.70.SetText(string.Format("x:{0:0} y:{1:0}", <<EMPTY_NAME>>.X, <<EMPTY_NAME>>.Y));
			}
			text += this.GetDistanceSnapHint(this.34.1, this.34.8, true);
			text += this.GetDistanceSnapHint(this.34.2, this.34.GetEndPosition(), false);
			1452 2 = this.70;
			2.SetText(2.GetText() + text);
			return;
		}
		if (this.44.Count > 0)
		{
			2255.2258 3 = new 2255.2258();
			this.70.6 = 198.Yellow;
			3.1 = this.44[0];
			3.2 = this.44[this.44.Count - 1];
			int num = this.4.34.FindIndex(new Predicate<2034>(3.1));
			int num2 = this.4.34.FindIndex(new Predicate<2034>(3.2));
			if (!(3.1 is 2070))
			{
				if (num > 0)
				{
					text += this.GetDistanceSnapHint(3.1.1, 3.1.8, true);
				}
				if (num2 < this.4.35 - 1 && num2 >= 0)
				{
					text += this.GetDistanceSnapHint(3.2.2, 3.2.GetEndPosition(), false);
				}
			}
			this.70.SetText(string.Format("x:{0:0} y:{1:0}", 3.1.8.X, 3.1.8.Y) + text);
			return;
		}
		if (this.21 == (2255.2257)1 || (this.21 == (2255.2257)2 && this.50 == null))
		{
			208 4 = this.59;
			text += this.GetDistanceSnapHint(1226.16, 4, true);
			text += this.GetDistanceSnapHint(1226.16, 4, false);
			this.70.SetText(string.Format("x:{0:0} y:{1:0}", 4.X, 4.Y) + text);
			return;
		}
		if (this.21 != (2255.2257)2 || this.50 == null)
		{
			this.70.6 = 198.White;
			this.70.SetText(string.Format("x:{0:0} y:{1:0}", this.59.X, this.59.Y));
		}
	}

	// Token: 0x06002AAA RID: 10922 RVA: 0x000E4979 File Offset: 0x000E2B79
	private void 28(bool 1)
	{
		if (!1)
		{
			this.27();
		}
	}

	// Token: 0x06002AAB RID: 10923 RVA: 0x000E4984 File Offset: 0x000E2B84
	private 1245 29()
	{
		1245 <<EMPTY_NAME>> = 1245.None;
		if (2255.54[2357.Whistle])
		{
			<<EMPTY_NAME>> |= 1245.Whistle;
		}
		if (2255.54[2357.Finish])
		{
			<<EMPTY_NAME>> |= 1245.Finish;
		}
		if (2255.54[2357.Clap])
		{
			<<EMPTY_NAME>> |= 1245.Clap;
		}
		return <<EMPTY_NAME>>;
	}

	// Token: 0x06002AAC RID: 10924 RVA: 0x000E49C8 File Offset: 0x000E2BC8
	internal void 30(2357 1)
	{
		this.32(1, !2255.54[1], true);
	}

	// Token: 0x06002AAD RID: 10925 RVA: 0x000E49E0 File Offset: 0x000E2BE0
	internal void 31(2357 1, bool 2)
	{
		this.32(1, 2, false);
	}

	// Token: 0x06002AAE RID: 10926 RVA: 0x000E49EC File Offset: 0x000E2BEC
	internal void 32(2357 1, bool 2, bool 3)
	{
		if (2255.54[1] == 2 && !this.6.7())
		{
			return;
		}
		2255.54[1] = 2;
		if (this.5.16(1)[0].19)
		{
			this.39(1);
		}
		if (1 == 2357.GridSnap)
		{
			1662.8.21(2);
			return;
		}
		if (1 == 2357.DistSnap)
		{
			return;
		}
		if (!3 || this.44.Count == 0)
		{
			return;
		}
		if (!this.6.7())
		{
			2451 4 = (1 == 2357.NewCombo) ? ((2451)5) : ((2451)2);
			this.6.17<2034>((2452)0, 4, this.44);
		}
		if (this.45 != null)
		{
			this.37(this.45, 1, 2);
		}
		else
		{
			foreach (2034 5 in this.44)
			{
				this.37(5, 1, 2);
			}
		}
		if (1 == 2357.NewCombo)
		{
			this.4.2(true);
			this.52();
		}
		this.6.20(false, false);
	}

	// Token: 0x06002AAF RID: 10927 RVA: 0x000E4B1C File Offset: 0x000E2D1C
	private void 33(object 1, EventArgs 2)
	{
		if (this.44.Count == 1)
		{
			1482 3 = 1 as 1482;
			if (3 != null)
			{
				this.6.17<2034>((2452)0, (2451)6, this.44);
				this.44[0].SetNewCombo(true);
				this.44[0].16 = 3.10;
				this.4.2(false);
				this.52();
				this.6.20(false, false);
			}
		}
	}

	// Token: 0x06002AB0 RID: 10928 RVA: 0x000E4B9C File Offset: 0x000E2D9C
	private void 34(object 1, EventArgs 2)
	{
		1254 value = (1254)this.68.18;
		if (this.45 != null)
		{
			this.6.19((2452)0, null);
			this.6.13((2451)3, (2450)64);
			this.6.23(this.45, false);
			bool flag = this.45.58.3();
			List<2066> list = this.45.48.FindAll((2066 1) => 1.3());
			this.45.45();
			if (flag || list.Count > 0)
			{
				if (flag)
				{
					this.45.85[0] = value;
				}
				for (int i = 0; i < this.45.48.Count; i++)
				{
					if (this.45.48[i].3())
					{
						this.45.85[i + 1] = value;
					}
				}
			}
			else
			{
				if (!this.45.11())
				{
					this.45.85[0] = value;
					for (int j = 0; j < this.45.48.Count; j++)
					{
						this.45.85[j + 1] = value;
					}
				}
				this.45.35 = value;
			}
		}
		else if (this.44.Count > 0)
		{
			this.6.19((2452)0, null);
			this.6.13((2451)3, (2450)64);
			this.6.24<2034>(this.44, false);
			foreach (2034 3 in this.44)
			{
				2123 4 = 3 as 2123;
				if (4 != null)
				{
					4.45();
					4.85[0] = value;
					for (int k = 0; k < 4.48.Count; k++)
					{
						4.85[k + 1] = value;
					}
				}
				3.35 = value;
			}
		}
		this.53();
		if (this.50 == null && this.55 == null)
		{
			this.6.20(false, false);
		}
	}

	// Token: 0x06002AB1 RID: 10929 RVA: 0x000E4E20 File Offset: 0x000E3020
	private void 35(object 1, EventArgs 2)
	{
		1254 value = (1254)this.69.18;
		if (this.45 != null)
		{
			this.6.19((2452)0, null);
			this.6.13((2451)3, (2450)128);
			this.6.23(this.45, false);
			bool flag = this.45.58.3();
			List<2066> list = this.45.48.FindAll(new Predicate<2066>(2255.2256.Instance.1));
			this.45.45();
			if (flag || list.Count > 0)
			{
				if (flag)
				{
					this.45.86[0] = value;
				}
				for (int i = 0; i < this.45.48.Count; i++)
				{
					if (this.45.48[i].3())
					{
						this.45.86[i + 1] = value;
					}
				}
			}
			else
			{
				if (!this.45.11())
				{
					this.45.86[0] = value;
					for (int j = 0; j < this.45.48.Count; j++)
					{
						this.45.86[j + 1] = value;
					}
				}
				this.45.36 = value;
			}
		}
		else if (this.44.Count > 0)
		{
			this.6.19((2452)0, null);
			this.6.13((2451)3, (2450)128);
			this.6.24<2034>(this.44, false);
			foreach (2034 3 in this.44)
			{
				2123 4 = 3 as 2123;
				if (4 != null)
				{
					4.45();
					4.86[0] = value;
					for (int k = 0; k < 4.48.Count; k++)
					{
						4.86[k + 1] = value;
					}
				}
				3.36 = value;
			}
		}
		if (this.50 == null && this.55 == null)
		{
			this.6.20(false, false);
		}
	}

	// Token: 0x06002AB2 RID: 10930 RVA: 0x000E5094 File Offset: 0x000E3294
	private 1245 36(2357 1)
	{
		1245 result = 1245.None;
		if (1 != 2357.Whistle)
		{
			if (1 != 2357.Finish)
			{
				if (1 == 2357.Clap)
				{
					result = 1245.Clap;
				}
			}
			else
			{
				result = 1245.Finish;
			}
		}
		else
		{
			result = 1245.Whistle;
		}
		return result;
	}

	// Token: 0x06002AB3 RID: 10931 RVA: 0x000E50C0 File Offset: 0x000E32C0
	private void 37(2034 1, 2357 2, bool 3)
	{
		if (2 == 2357.NewCombo)
		{
			this.38(1);
			return;
		}
		1245 4 = this.36(2);
		if (4 != 1245.None)
		{
			bool 5 = 1 == this.45 && this.45.10();
			1.SetHitSound(4, 3, 5);
		}
	}

	// Token: 0x06002AB4 RID: 10932 RVA: 0x000E5108 File Offset: 0x000E3308
	private void 38(2034 1)
	{
		bool flag;
		1.SetNewCombo(flag = 2255.54[2357.NewCombo]);
		this.4.3(1);
		if (!flag)
		{
			1.16 = 0;
		}
	}

	// Token: 0x06002AB5 RID: 10933 RVA: 0x000E5140 File Offset: 0x000E3340
	private void 39(2357 1)
	{
		1371 2 = this.5.16(1)[0];
		2.3.Clear();
		if (2255.54[1])
		{
			2.3.Add(new 1445(1456.Fade, 1f, 0.9f, 1662.33, 1662.33 + 100, (1046)0));
			return;
		}
		2.3.Add(new 1445(1456.Fade, 2.16, 0.4f, 1662.33, 1662.33 + 100, (1046)0));
	}

	// Token: 0x06002AB6 RID: 10934 RVA: 0x000E51D4 File Offset: 0x000E33D4
	private void 40()
	{
		if (1549.2)
		{
			if (!this.24)
			{
				this.30(2357.DistSnap);
				this.48.SetText(1568.1(2679.EditorModeCompose_DistanceSpacing) + ":");
				this.17.22(1304.138.1(), 1304.138.3(), this.23);
				this.26(this.23);
				this.24 = true;
			}
		}
		else if (this.24)
		{
			this.30(2357.DistSnap);
			this.48.SetText(1568.1(2679.EditorModeCompose_BeatSnapDivisor) + ":");
			this.17.22(1.0, 16.0, (double)this.3.96());
			this.24(this.3.96());
			this.24 = false;
		}
		if (1549.3)
		{
			if (!this.30)
			{
				this.30(2357.GridSnap);
				this.30 = true;
				return;
			}
		}
		else if (this.30)
		{
			this.30(2357.GridSnap);
			this.30 = false;
		}
	}

	// Token: 0x06002AB7 RID: 10935 RVA: 0x000E52F8 File Offset: 0x000E34F8
	internal void 41()
	{
		this.42(this.44);
	}

	// Token: 0x06002AB8 RID: 10936 RVA: 0x000E5308 File Offset: 0x000E3508
	private void 42(List<2034> 1)
	{
		if (1.Count == 0)
		{
			return;
		}
		this.6(false);
		int num = 0;
		this.6.19((2452)0, null);
		this.6.13((2451)3, (2450)16384);
		this.6.13((2451)4, (2450)16384);
		this.6.13((2451)2, (2450)0);
		this.6.21<2034>(1);
		foreach (2034 2 in 1)
		{
			2123 3 = 2 as 2123;
			if (3 != null)
			{
				3.46();
			}
			2.37 = 1253.Default;
			2.35 = 1254.None;
			2.36 = 1254.None;
			2.34 = 0;
			2.33 = string.Empty;
			2.32 = -1;
			2.4 = 1245.None;
		}
		if (num > 0)
		{
			1763.2(1568.1(2679.EditorModeCompose_SelectedSampleReset), 2000, (1389)0);
		}
		this.6.20(false, false);
	}

	// Token: 0x06002AB9 RID: 10937 RVA: 0x000E541C File Offset: 0x000E361C
	protected void 43(2034 1)
	{
		if (this.72 != null)
		{
			this.6.19((2452)0, null);
			this.6.13((2451)3, (2450)16384);
			this.6.13((2451)4, (2450)16384);
			this.6.13((2451)2, (2450)0);
			this.6.22(1);
			1.4 = this.72.4;
			1.37 = this.72.37;
			1.35 = this.72.35;
			1.36 = this.72.36;
			1.33 = this.72.33;
			1.32 = this.72.32;
			1.34 = this.72.34;
			this.6.20(false, false);
			1763.5(1568.1(2679.EditorModeCompose_SampleApplied), 198.YellowGreen, 700, null);
			return;
		}
		1763.2(1568.1(2679.EditorModeCompose_SelectNoteBeforeSampleCopy), 1500, (1389)0);
	}

	// Token: 0x06002ABA RID: 10938 RVA: 0x000E5538 File Offset: 0x000E3738
	private void 44()
	{
		this.31(2357.Whistle, false);
		this.31(2357.Finish, false);
		this.31(2357.Clap, false);
		this.31(2357.NewCombo, false);
	}

	// Token: 0x06002ABB RID: 10939 RVA: 0x000E555C File Offset: 0x000E375C
	private void 45(2357 1)
	{
		foreach (object obj in Enum.GetValues(typeof(2357)))
		{
			2357 2 = (2357)obj;
			if ((2 & 1) > (2357)0)
			{
				this.39(2);
			}
			else
			{
				this.5.16(2)[0].16(300, (1046)0, 0);
			}
		}
	}

	// Token: 0x06002ABC RID: 10940 RVA: 0x000E55EC File Offset: 0x000E37EC
	internal void 46()
	{
		this.42(this.4.34);
	}

	// Token: 0x06002ABD RID: 10941 RVA: 0x000E55FF File Offset: 0x000E37FF
	private void 47(object 1, EventArgs 2)
	{
		this.64.3.Clear();
		this.64.FadeIn(200, (1046)0, 0);
	}

	// Token: 0x06002ABE RID: 10942 RVA: 0x000E5624 File Offset: 0x000E3824
	private void 48(object 1, EventArgs 2)
	{
		if (this.65.2())
		{
			this.64.3.Clear();
			this.64.FadeIn(200, (1046)0, 0);
			return;
		}
		this.64.3.Clear();
		this.64.24(0.003921569f, 50, (1046)0);
	}

	// Token: 0x06002ABF RID: 10943 RVA: 0x000E5684 File Offset: 0x000E3884
	private void 49()
	{
		this.64.10 = false;
		this.64.3.Clear();
		this.64.16(50, (1046)0, 0);
		this.64.36(new EventHandler(this.47));
		this.64.38(new EventHandler(this.48));
		this.53[0].SetTexture(1455.2("editor-draw-newcombo", (1416)1, null));
	}

	// Token: 0x06002AC0 RID: 10944 RVA: 0x000E5703 File Offset: 0x000E3903
	private void 50(object 1, EventArgs 2)
	{
		this.48(this, EventArgs.Empty);
	}

	// Token: 0x06002AC1 RID: 10945 RVA: 0x000E5714 File Offset: 0x000E3914
	private void 51(198 1, int 2, int 3, bool 4, EventHandler 5)
	{
		1482 6 = new 1482(this.65, this.5, new 208(32f, 32f), new 208((float)(1662.70.1() - 70), (float)(80 + 20 * 3)), 4);
		1433 7 = new 1433(1455.2("hitcircle", (1416)1, null), (1376)3, 1065.TopLeft, (1044)0, new 208((float)(1662.70.1() - 70), (float)(80 + 20 * 3)), 2f, true, new 198(1.R, 1.G, 1.B, 0), null);
		1433 8 = new 1433(1455.2("hitcircleoverlay", (1416)1, null), (1376)3, 1065.TopLeft, (1044)0, new 208((float)(1662.70.1() - 70), (float)(80 + 20 * 3)), 3f, true, 198.TransparentWhite, null);
		7.15 = 0.15625f;
		8.15 = 0.15625f;
		this.5.12(7);
		this.5.12(8);
		6.5.Add(7);
		6.5.Add(8);
		6.10 = 2;
		6.1(new EventHandler(this.33));
		this.65.1.Add(6);
	}

	// Token: 0x06002AC2 RID: 10946 RVA: 0x000E585C File Offset: 0x000E3A5C
	private void 52()
	{
		if (this.44.Count != 1)
		{
			this.49();
			return;
		}
		2034 <<EMPTY_NAME>> = this.44[0];
		if (!<<EMPTY_NAME>>.IsNewCombo())
		{
			this.49();
			return;
		}
		this.53[0].SetTexture(1455.2("editor-draw-newcombo-expandable", (1416)1, null));
		this.64.10 = true;
		this.64.35(new EventHandler(this.47));
		this.64.37(new EventHandler(this.48));
		this.64.24(0.003921569f, 0, (1046)0);
		this.65.3();
		int count = this.4.27.Count;
		int num = <<EMPTY_NAME>>.17 - <<EMPTY_NAME>>.16;
		if (num < 0)
		{
			num -= num / this.4.27.Count * this.4.27.Count;
			num += this.4.27.Count;
		}
		int num2 = this.3.7.72(<<EMPTY_NAME>>, true) ? count : (count - 1);
		for (int i = 0; i < num2; i++)
		{
			198 2 = this.4.27[(num + i) % count];
			this.51(2, i, i, i == <<EMPTY_NAME>>.16, new EventHandler(this.33));
		}
	}

	// Token: 0x06002AC3 RID: 10947 RVA: 0x000E59CC File Offset: 0x000E3BCC
	internal void 53()
	{
		if (this.44.Count == 0)
		{
			if (this.47)
			{
				this.68.18(1254.None, true);
				this.69.18(1254.None, true);
			}
			return;
		}
		if (this.45 != null)
		{
			1254 <<EMPTY_NAME>> = 1254.None;
			1254 2 = 1254.None;
			if (this.45.73)
			{
				<<EMPTY_NAME>> = this.45.35;
				2 = this.45.36;
			}
			else
			{
				int num;
				bool flag;
				if (this.45.58.3())
				{
					<<EMPTY_NAME>> = this.45.85[0];
					2 = this.45.86[0];
					num = 0;
					flag = true;
				}
				else
				{
					num = this.45.48.FindIndex((2066 1) => 1.3());
					if (num >= 0)
					{
						<<EMPTY_NAME>> = this.45.85[num + 1];
						2 = this.45.86[num + 1];
						flag = true;
					}
					else
					{
						flag = false;
					}
				}
				if (flag)
				{
					bool flag2 = true;
					bool flag3 = true;
					while (flag2 || flag3)
					{
						if (this.45.48[num].3())
						{
							if (flag2)
							{
								flag2 = (this.45.85[num + 1] == <<EMPTY_NAME>>);
							}
							if (flag3)
							{
								flag3 = (this.45.86[num + 1] == 2);
							}
						}
						num++;
						if (num >= this.45.48.Count)
						{
							break;
						}
					}
					if (!flag2)
					{
						<<EMPTY_NAME>> = 1254.None;
					}
					if (!flag3)
					{
						2 = 1254.None;
					}
				}
				else
				{
					<<EMPTY_NAME>> = this.45.35;
					2 = this.45.36;
				}
			}
			this.68.18(<<EMPTY_NAME>>, true);
			this.69.18(2, true);
			return;
		}
		1254 3 = this.44[0].35;
		1254 4 = this.44[0].36;
		bool flag4 = true;
		bool flag5 = true;
		foreach (2034 5 in this.44)
		{
			if (flag4)
			{
				flag4 = (5.35 == 3);
			}
			if (flag5)
			{
				flag5 = (5.36 == 4);
			}
			if (!flag4 && !flag5)
			{
				break;
			}
		}
		if (!flag4)
		{
			3 = 1254.None;
		}
		if (!flag5)
		{
			4 = 1254.None;
		}
		this.68.18(3, true);
		this.69.18(4, true);
	}

	// Token: 0x06002AC4 RID: 10948 RVA: 0x000E5C94 File Offset: 0x000E3E94
	internal void 54()
	{
		if (this.44.Count == 0)
		{
			return;
		}
		if (this.3.59 != (2329)1 && this.21 != (2255.2257)0 && this.3.69)
		{
			this.ClearSelection();
			return;
		}
		bool flag4;
		bool flag3;
		bool flag2;
		bool flag = flag2 = (flag3 = (flag4 = true));
		if (this.45 != null)
		{
			flag4 = this.45.IsNewCombo();
			if (this.45.73)
			{
				flag &= this.45.HasWhistle();
				flag2 &= this.45.HasFinish();
				flag3 &= this.45.HasClap();
			}
			else
			{
				int num = 0;
				for (int i = 0; i < this.45.9().Count; i++)
				{
					if (this.45.9()[i].3())
					{
						flag &= this.45.84[i].2(1245.Whistle);
						flag2 &= this.45.84[i].2(1245.Finish);
						flag3 &= this.45.84[i].2(1245.Clap);
						num++;
					}
				}
				if (num == 0)
				{
					flag &= this.45.HasWhistle();
					flag2 &= this.45.HasFinish();
					flag3 &= this.45.HasClap();
				}
			}
		}
		else
		{
			foreach (2034 <<EMPTY_NAME>> in this.44)
			{
				flag4 &= <<EMPTY_NAME>>.IsNewCombo();
				flag &= <<EMPTY_NAME>>.HasWhistle();
				flag2 &= <<EMPTY_NAME>>.HasFinish();
				flag3 &= <<EMPTY_NAME>>.HasClap();
			}
		}
		this.31(2357.Whistle, flag);
		this.31(2357.Finish, flag2);
		this.31(2357.Clap, flag3);
		this.31(2357.NewCombo, flag4);
	}

	// Token: 0x06002AC5 RID: 10949 RVA: 0x000E5E88 File Offset: 0x000E4088
	internal void 55(string 1, int 2)
	{
		if (this.44.Count == 0)
		{
			return;
		}
		this.6.19((2452)0, null);
		this.6.13((2451)4, (2450)4096);
		this.6.24<2034>(this.44, false);
		foreach (2034 3 in this.44)
		{
			3.34 = 2;
			3.6(1);
		}
		this.6.20(false, false);
	}

	// Token: 0x06002AC6 RID: 10950 RVA: 0x000E5F34 File Offset: 0x000E4134
	internal void 56(int 1, int 2)
	{
		if (this.44.Count == 0)
		{
			return;
		}
		this.6.19((2452)0, null);
		this.6.13((2451)4, (2450)0);
		this.6.24<2034>(this.44, false);
		foreach (2034 3 in this.44)
		{
			3.34 = 2;
			3.37 = (1253)1;
		}
		this.6.20(false, false);
	}

	// Token: 0x06002AC7 RID: 10951 RVA: 0x000E5FDC File Offset: 0x000E41DC
	internal void 57()
	{
		if (this.3.15 != 2147.OsuMania)
		{
			return;
		}
		int num = 0;
		List<2034> list = this.4.34;
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].1 != list[num].1)
			{
				int num2 = i - num;
				if (num2 < 1)
				{
					num2 = 1;
				}
				int <<EMPTY_NAME>> = 1226.89((double)list[num].1).6;
				for (int j = num; j < i; j++)
				{
					list[j].34 = <<EMPTY_NAME>> * 4 / 3 / num2;
				}
				num = i;
			}
		}
	}

	// Token: 0x06002AC8 RID: 10952 RVA: 0x000E607C File Offset: 0x000E427C
	protected bool 58(int 1, int 2, int 3)
	{
		if (1226.32 == (1042)1)
		{
			return true;
		}
		int num = 0;
		if (1 > 3)
		{
			num = (1 - 3) / 2;
		}
		else if (1 < 2)
		{
			num = (1 - 2) / 2;
		}
		bool flag = num != 0;
		if (flag)
		{
			1226.4(1226.16 + num, false, false);
		}
		return flag;
	}

	// Token: 0x06002AC9 RID: 10953 RVA: 0x000E60C0 File Offset: 0x000E42C0
	internal override void UpdateTimelineObjects()
	{
		this.75.Clear();
		this.76.GetTextSize();
		foreach (2275 <<EMPTY_NAME>> in this.3.6.13)
		{
			if (<<EMPTY_NAME>>.8 >= this.3.62 && <<EMPTY_NAME>>.8 <= this.3.63)
			{
				float num = this.3.101((double)<<EMPTY_NAME>>.8);
				1452 2 = (1452)this.76.Clone();
				2.17 = new 208(num + 5f, 35f);
				2.16 = 1f;
				this.3.65.12(2);
			}
		}
		int num2 = -60000;
		int num3 = 0;
		foreach (2034 3 in this.4.36)
		{
			if (3 != this.22)
			{
				2123 4 = 3 as 2123;
				bool flag = 3.1 >= this.3.62 && 3.1 <= this.3.63;
				bool flag2 = 3.2 != 3.1 && 3.2 >= this.3.62 && 3.2 <= this.3.63;
				if ((3.GetDuration() > 0 && (flag || flag2)) || (3.1 < this.3.62 && 3.2 > this.3.63))
				{
					this.75.Add(3);
				}
				num3 = ((3.1 == num2) ? (num3 + 1) : 0);
				num2 = 3.1;
				int num4 = 45 - 2 * num3;
				int num5 = 3 * num3;
				int num6 = 0;
				num4 += num6;
				if (flag)
				{
					float num7 = this.3.101((double)3.1);
					byte 5 = (byte)Math.Min(255.0, 255.0 * (double)Math.Min(num7 - (float)this.3.56, (float)this.3.68 - (num7 - (float)this.3.56)) / 40.0);
					198 6 = new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue, 5);
					198 7 = new 198(3.7.R, 3.7.G, 3.7.B, 5);
					198 8 = new 198(byte.MaxValue, 0, 0, 5);
					1433 9 = new 1433(1455.2("hitcircle", (1416)7, null), (1376)6, 1065.Centre, (1044)1, new 208(num7, (float)num4), 1436.32((float)(3.1 + num5)), true, 7, 3);
					9.15 = 0.4f;
					1433 10 = new 1433(1455.2("hitcircleoverlay", (1416)7, null), (1376)6, 1065.Centre, (1044)1, new 208(num7, (float)num4), 1436.32((float)(3.1 - 1 + num5)), true, 6, null);
					10.15 = 0.4f;
					1433 11 = new 1353(3.GetComboNumber().ToString(), 2630.5.FontHitCircle, (float)2630.5.FontHitCircleOverlap, (1376)6, 1065.Centre, (1044)1, new 208(num7, (float)(45 - 3 * num3 + num6)), 1436.32((float)(3.1 - 2 + num5)), true, 6, false, (1416)7);
					11.15 = 0.32f;
					if (3.3())
					{
						1433 12 = new 1433(1455.2("hitcircleselect", (1416)7, null), (1376)6, 1065.Centre, (1044)1, new 208(num7, (float)num4), 1436.32((float)(3.1 - 3 + num5)), true, (4 != null && 4.58.3()) ? 8 : 6, null);
						12.15 = 0.4f;
						this.3.65.12(12);
					}
					this.3.65.12(9);
					this.3.65.12(10);
					this.3.65.12(11);
				}
				if (flag2)
				{
					float num8 = this.3.101((double)3.2);
					byte 13 = (byte)Math.Min(255.0, 255.0 * (double)Math.Min(num8 - (float)this.3.56, (float)this.3.68 - (num8 - (float)this.3.56)) / 40.0);
					198 14 = new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue, 13);
					198 15 = new 198(3.7.R, 3.7.G, 3.7.B, 13);
					198 16 = new 198(byte.MaxValue, 0, 0, 13);
					1433 17 = new 1433(1455.2("hitcircle", (1416)7, null), (1376)6, 1065.Centre, (1044)1, new 208(num8, (float)num4), 1436.32((float)(3.2 + num5)), true, 15, 3);
					17.15 = 0.4f;
					1433 18 = new 1433(1455.2("hitcircleoverlay", (1416)7, null), (1376)6, 1065.Centre, (1044)1, new 208(num8, (float)num4), 1436.32((float)(3.2 - 1 + num5)), true, 14, null);
					18.15 = 0.4f;
					if (3.3())
					{
						1433 19 = new 1433(1455.2("hitcircleselect", (1416)7, null), (1376)6, 1065.Centre, (1044)1, new 208(num8, (float)num4), 1436.32((float)(3.2 - 3 + num5)), true, (4 != null && 4.48.Count > 0 && 4.48[4.48.Count - 1].3()) ? 16 : 14, null);
						19.15 = 0.4f;
						this.3.65.12(19);
					}
					this.3.65.12(17);
					this.3.65.12(18);
				}
				if (4 != null && (flag || flag2 || (3.1 < this.3.62 && 3.2 >= this.3.63)))
				{
					for (int i = 0; i < 4.82.Count; i++)
					{
						int num9 = 4.82[i];
						if (num9 >= this.3.62 && num9 <= this.3.63)
						{
							float num10 = this.3.101((double)num9);
							byte 20 = (byte)Math.Min(255.0, 255.0 * (double)Math.Min(num10 - (float)this.3.56, (float)this.3.68 - (num10 - (float)this.3.56)) / 40.0);
							198 21 = new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue, 20);
							198 22 = new 198(3.7.R, 3.7.G, 3.7.B, 20);
							198 23 = new 198(0, 0, 0, 20);
							198 24 = new 198(byte.MaxValue, 0, 0, 20);
							1433 25 = new 1433(1455.2("hitcircle", (1416)7, null), (1376)6, 1065.Centre, (1044)1, new 208(num10, (float)num4), 1436.32((float)(num9 + num5)), true, 22, 3);
							25.15 = 0.4f;
							1433 26 = new 1433(1455.2("hitcircleoverlay", (1416)7, null), (1376)6, 1065.Centre, (1044)1, new 208(num10, (float)num4), 1436.32((float)(num9 - 1 + num5)), true, 21, null);
							26.15 = 0.4f;
							198 27 = (25.GetTexture().6 != (1416)1 || (int)(3.7.R + 3.7.G + 3.7.B) <= 600) ? 21 : 23;
							1433 28 = new 1433(1455.2("reversearrow", (1416)7, null), (1376)6, 1065.Centre, (1044)1, new 208(num10, (float)num4), 1436.32((float)(num9 - 2 + num5)), true, 27, null);
							28.15 = 0.4f;
							this.3.65.12(28);
							if (i < 4.48.Count && 4.48[i].3())
							{
								1433 29 = new 1433(1455.2("hitcircleselect", (1416)7, null), (1376)6, 1065.Centre, (1044)1, new 208(num10, (float)num4), 1436.32((float)(num9 - 3 + num5)), true, 24, null);
								29.15 = 0.4f;
								this.3.65.12(29);
							}
							this.3.65.12(25);
							this.3.65.12(26);
						}
					}
				}
			}
		}
	}

	// Token: 0x06002ACA RID: 10954 RVA: 0x000E6A74 File Offset: 0x000E4C74
	internal override void DrawTimelineContent()
	{
		List<1051> list = new List<1051>();
		foreach (2034 <<EMPTY_NAME>> in this.75)
		{
			float num = this.3.101((double)<<EMPTY_NAME>>.1);
			float num2 = this.3.101((double)<<EMPTY_NAME>>.2);
			byte b = 170;
			if (num > (float)(this.3.56 + this.3.68 / 2))
			{
				b = (byte)Math.Min(170.0, 170.0 * (double)Math.Min(num - (float)this.3.56, (float)this.3.68 - (num - (float)this.3.56)) / 40.0);
			}
			else if (num2 < (float)(this.3.56 + this.3.68 / 2))
			{
				b = (byte)Math.Min(170.0, 170.0 * (double)Math.Min(num2 - (float)this.3.56, (float)this.3.68 - (num2 - (float)this.3.56)) / 40.0);
			}
			float num3 = (float)2039.16 / 8f * 1662.70.3() - 1f;
			num = Math.Max(num * 1662.70.3(), (float)this.3.66.GetLeft() + num3);
			num2 = Math.Min(num2 * 1662.70.3(), (float)this.3.66.GetRight() - num3);
			if (num <= num2)
			{
				list.Clear();
				list.Add(new 1051(new 208(num, (float)this.3.66.GetTop() + 3f * 1662.70.3() + (float)this.3.66.Height / 2f), new 208(num2, (float)this.3.66.GetTop() + 3f * 1662.70.3() + (float)this.3.66.Height / 2f)));
				1662.13.4(list, num3, new 198(<<EMPTY_NAME>>.7.R, <<EMPTY_NAME>>.7.G, <<EMPTY_NAME>>.7.B, <<EMPTY_NAME>>.3() ? byte.MaxValue : b), 0f, "Standard", true, false, 15);
			}
		}
		foreach (2275 2 in this.3.6.13)
		{
			int num4 = 0;
			int num5 = 0;
			try
			{
				int num6 = this.4.71(2);
				num4 = this.4.34[num6 - 1].2;
				num5 = ((num6 >= this.4.35) ? (2.1 + this.4.2) : this.4.34[num6].1);
			}
			catch (ArgumentOutOfRangeException)
			{
				num4 = 2.8;
				num5 = 2.1 + this.4.2;
			}
			if ((this.3.62 <= num4 && this.3.63 >= num4) || (this.3.62 <= num5 && this.3.63 >= num5) || (this.3.62 >= num4 && this.3.63 <= num5))
			{
				list.Clear();
				198 3;
				198 4;
				if (2.1 - 2.8 < 50)
				{
					3 = new 198(byte.MaxValue, 0, 0, 150);
					4 = new 198(byte.MaxValue, 0, 0, 150);
				}
				else
				{
					3 = (2.12 ? new 198(40, 100, 100, 100) : new 198(100, 100, 100, 100));
					4 = (2.13 ? new 198(40, 100, 100, 100) : new 198(100, 100, 100, 100));
				}
				list.Add(new 1051(new 208(this.3.102((double)2.8), (float)this.3.66.GetTop() + 3f * 1662.70.3() + (float)(this.3.66.Height / 2)), new 208(this.3.102((double)2.1), (float)this.3.66.GetTop() + 3f * 1662.70.3() + (float)(this.3.66.Height / 2))));
				list.Add(new 1050(new 208(this.3.102((double)2.1), (float)this.3.66.GetTop() + 3f * 1662.70.3() + (float)(this.3.66.Height / 2)), new 208(this.3.102((double)num5), (float)this.3.66.GetTop() + 3f * 1662.70.3() + (float)(this.3.66.Height / 2)), 4));
				list.Add(new 1050(new 208(this.3.102((double)num4), (float)this.3.66.GetTop() + 3f * 1662.70.3() + (float)(this.3.66.Height / 2)), new 208(this.3.102((double)2.8), (float)this.3.66.GetTop() + 3f * 1662.70.3() + (float)(this.3.66.Height / 2)), 3));
				1662.13.4(list, (float)(2039.16 / 8) * 1662.70.3() - 1f, new 198(100, 100, 100, 150), 0f, "NoBlur", false, false, 15);
			}
		}
	}

	// Token: 0x06002ACB RID: 10955 RVA: 0x000E7168 File Offset: 0x000E5368
	protected virtual bool IsToolAvailable(2255.2257 1)
	{
		return 1 <= (2255.2257)3;
	}

	// Token: 0x06002ACC RID: 10956 RVA: 0x000E7174 File Offset: 0x000E5374
	internal void 59(bool 1)
	{
		this.6(true);
		2033 2 = new 2033(this.4, this.59, this.3.104(), false, (!1) ? 1245.Normal : 1245.Clap, 0);
		this.6.15((2452)0, (2451)8, null);
		this.4.AddHitObject(2, true, true);
		this.4.2(true);
		this.6.23(2, false);
		this.6.26<2034>(this.4.37, (2450)65536, false);
		this.4.37.Clear();
		this.3.87 = true;
		this.3.2(true);
	}

	// Token: 0x06002ACD RID: 10957 RVA: 0x000E7230 File Offset: 0x000E5430
	internal void 60()
	{
		this.3.31 = !this.3.31;
		if (this.3.31)
		{
			this.63((2255.2257)1);
		}
		1763.2(this.3.31 ? 1568.1(2679.EditorModeCompose_LiveMappingEnabled) : 1568.1(2679.EditorModeCompose_LiveMappingDisabled), 3000, (1389)0);
	}

	// Token: 0x06002ACE RID: 10958 RVA: 0x000E7298 File Offset: 0x000E5498
	internal bool 61(int 1, int 2, double 3, double 4)
	{
		if (1 < 3)
		{
			return false;
		}
		int num = this.3.104();
		double num2 = 1226.88((double)num, false) / (double)this.3.96();
		double sliderVelocityAt = this.3.74.4.GetSliderVelocityAt(1226.16);
		double 5 = 1052.29(2263.91(4, sliderVelocityAt, num2), 1);
		this.19(false);
		208 6 = this.81(true);
		bool flag = true;
		for (int i = 1; i <= 1 * 2; i++)
		{
			208 7 = 1052.31(5, 1, 6, 3, i);
			bool 8 = this.62() || (flag && 2255.54[2357.NewCombo]);
			2033 9 = new 2033(this.4, 7, num, 8, 2255.54[2357.Whistle], 2255.54[2357.Finish], 2255.54[2357.Clap], 0);
			this.4.AddHitObject(9, true, true);
			this.SelectObject(9);
			flag = false;
			num = this.3.76.27((double)num + num2);
		}
		this.6.14((2452)0, (2451)8, (2450)0);
		this.6.24<2034>(this.44, true);
		this.6.26<2034>(this.4.37, (2450)65536, false);
		this.3.85 = true;
		this.4.2(true);
		this.4.37.Clear();
		return true;
	}

	// Token: 0x06002ACF RID: 10959 RVA: 0x000E7419 File Offset: 0x000E5619
	private bool 62()
	{
		return this.4.34.FindLast((2034 1) => 1.2 < 1226.16 && 1 != this.22) is 2070;
	}

	// Token: 0x06002AD0 RID: 10960 RVA: 0x000E7440 File Offset: 0x000E5640
	internal void 63(2255.2257 1)
	{
		if (!this.IsToolAvailable(1))
		{
			return;
		}
		this.66();
		if (this.21 == (2255.2257)0 && 1 != this.21)
		{
			this.ClearSelection();
		}
		this.21 = 1;
		for (int i = 0; i < this.19.Length; i++)
		{
			if (i != (int)this.21)
			{
				this.19[i].3.Add(new 1445(1456.Fade, this.19[i].16, 0.4f, 1662.33, 1662.33 + 100, (1046)0));
			}
			else
			{
				this.19[i].3.Add(new 1445(1456.Fade, 1f, 0.9f, 1662.33, 1662.33 + 100, (1046)0));
			}
		}
	}

	// Token: 0x06002AD1 RID: 10961 RVA: 0x000E7504 File Offset: 0x000E5704
	private void 64(object 1, EventArgs 2)
	{
		if (this.IsEditingSliderPath())
		{
			return;
		}
		for (int i = 0; i < this.19.Length; i++)
		{
			if (this.19[i].Equals(1))
			{
				2255.2257 3 = (2255.2257)i;
				this.63(3);
				return;
			}
		}
	}

	// Token: 0x06002AD2 RID: 10962 RVA: 0x000E7547 File Offset: 0x000E5747
	internal void 65()
	{
		if (this.22 != null)
		{
			this.4.29(this.22, true);
		}
	}

	// Token: 0x06002AD3 RID: 10963 RVA: 0x000E7564 File Offset: 0x000E5764
	internal void 66()
	{
		this.70(true);
		this.68();
	}

	// Token: 0x06002AD4 RID: 10964 RVA: 0x000E7573 File Offset: 0x000E5773
	internal bool 67()
	{
		return this.50 != null || this.55 != null;
	}

	// Token: 0x06002AD5 RID: 10965 RVA: 0x000E7588 File Offset: 0x000E5788
	private void 68()
	{
		this.69(this.3.104());
	}

	// Token: 0x06002AD6 RID: 10966 RVA: 0x000E759C File Offset: 0x000E579C
	private void 69(int 1)
	{
		if (this.55 != null && this.49)
		{
			if (1 != this.55.2)
			{
				this.55.SetEndTime(Math.Max(this.55.1, 1));
			}
			if (this.55.2 <= this.55.1)
			{
				this.4.29(this.55, true);
			}
			this.55 = null;
			this.3.87 = true;
			this.3.2(true);
		}
	}

	// Token: 0x06002AD7 RID: 10967 RVA: 0x000E7630 File Offset: 0x000E5830
	private void 70(bool 1)
	{
		if (this.50 != null && this.49)
		{
			if (this.50.54.Count == 1 || this.50.6 == 0.0)
			{
				this.4.29(this.50, true);
			}
			else if (1)
			{
				this.50.16(true, false);
			}
			this.3.87 = true;
			this.3.2(true);
			this.50 = null;
		}
	}

	// Token: 0x06002AD8 RID: 10968 RVA: 0x000E76BC File Offset: 0x000E58BC
	protected virtual void MoveSelectionTo(float 1, float 2, bool 3)
	{
		if (2255.54[2357.NoteLock])
		{
			return;
		}
		List<2034> list = this.44.Where(new Func<2034, bool>(2255.2256.Instance.3)).ToList<2034>();
		if (list.Count == 0)
		{
			return;
		}
		if (3 && !this.15)
		{
			this.6.17<2034>((2452)0, (2451)1, list);
			this.15 = true;
		}
		foreach (2034 4 in list)
		{
			4.5();
		}
		bool flag = true;
		2034 5 = global::44.ListFirstOrDefault<2034>(list);
		if (5 == null)
		{
			return;
		}
		if (this.16)
		{
			1 = (float)this.7.4(1);
			2 = (float)this.7.4(2);
		}
		float num = Math.Min(512f, Math.Max(0f, 1)) - 5.8.X;
		float num2 = Math.Min(384f, Math.Max(0f, 2)) - 5.8.Y;
		foreach (2034 6 in list)
		{
			if (!1662.69.23(new 208(6.8.X + num, 6.8.Y + num2)) || !1662.69.23(new 208(6.GetCurrentPosition().X + num, 6.GetCurrentPosition().Y + num2)))
			{
				flag = false;
				break;
			}
		}
		if (!flag || (num == 0f && num2 == 0f))
		{
			return;
		}
		this.35 = true;
		foreach (2034 7 in list)
		{
			7.SetPosition(new 208((float)((int)(7.8.X + num)), (float)((int)(7.8.Y + num2))), false);
		}
	}

	// Token: 0x06002AD9 RID: 10969 RVA: 0x000E78F4 File Offset: 0x000E5AF4
	private void 71()
	{
		List<2034> list = this.4.34;
		for (int i = 1; i < list.Count; i++)
		{
			if (list[i].3() && list[i - 1].CompareTo(list[i]) == 0)
			{
				2034 value = list[i];
				list[i] = list[i - 1];
				list[i - 1] = value;
			}
		}
		this.4.2(false);
	}

	// Token: 0x06002ADA RID: 10970 RVA: 0x000E7974 File Offset: 0x000E5B74
	private void 72()
	{
		List<2034> list = this.4.34;
		for (int i = 0; i < list.Count - 1; i++)
		{
			if (list[i].3() && list[i].CompareTo(list[i + 1]) == 0)
			{
				2034 value = list[i + 1];
				list[i + 1] = list[i];
				list[i] = value;
			}
		}
		this.4.2(false);
	}

	// Token: 0x06002ADB RID: 10971 RVA: 0x000E79F3 File Offset: 0x000E5BF3
	internal void 73()
	{
		if (this.44.Count != 0)
		{
			this.6(false);
			this.3.76.25(-1);
		}
	}

	// Token: 0x06002ADC RID: 10972 RVA: 0x000E7A1A File Offset: 0x000E5C1A
	internal void 74()
	{
		if (this.44.Count != 0)
		{
			this.6(false);
			this.3.76.25(1);
		}
	}

	// Token: 0x06002ADD RID: 10973 RVA: 0x000E7A44 File Offset: 0x000E5C44
	internal void 75()
	{
		if (this.44.Count == 0)
		{
			return;
		}
		this.6(false);
		this.44.Sort();
		this.6.17<2034>((2452)0, (2451)26, this.44);
		this.44.ForEach(new Action<2034>(2255.2256.Instance.4));
		this.7(false);
		this.42 = this.40;
		int <<EMPTY_NAME>> = this.44[0].2;
		int 2 = this.44[0].1;
		bool[] array = new bool[this.44.Count];
		for (int i = 0; i < this.44.Count; i++)
		{
			array[i] = this.44[i].IsNewCombo();
			if (this.44[i].2 > <<EMPTY_NAME>>)
			{
				<<EMPTY_NAME>> = this.44[i].2;
			}
			if (this.44[i].1 < 2)
			{
				2 = this.44[i].1;
			}
		}
		bool flag = this.3.15 == 2147.OsuMania;
		int num = 1;
		foreach (2034 3 in this.44)
		{
			3.SetNewCombo(array[this.44.Count - num]);
			num++;
			int num2 = 2 + (<<EMPTY_NAME>> - 3.2);
			if (!flag)
			{
				3.SetStartTime(num2);
				if (3.HasObjectType(2047.Slider))
				{
					((2123)3).20();
				}
			}
			else
			{
				int num3 = this.3.76.26((double)num2);
				if (Math.Abs(num3 - num2) == 1)
				{
					num2 = num3;
				}
				3.SetStartTime(num2);
				if (3.HasObjectType(2047.Hold))
				{
					int num4 = this.3.76.26((double)3.2);
					if (Math.Abs(num4 - 3.2) == 1)
					{
						3.SetEndTime(num4);
					}
				}
			}
		}
		this.47 = true;
		this.4.2(true);
		if (!this.6.7())
		{
			this.3.2(true);
		}
	}

	// Token: 0x06002ADE RID: 10974 RVA: 0x000E7CB0 File Offset: 0x000E5EB0
	internal virtual void FlipHorizontally()
	{
		if (this.44.Count == 0)
		{
			return;
		}
		this.6(false);
		this.6.19((2452)0, null);
		this.6.13((2451)24, (2450)1);
		this.6.24<2034>(this.44, false);
		this.44.ForEach(new Action<2034>(2255.2256.Instance.5));
		this.7(false);
		this.42 = this.40;
		foreach (2034 <<EMPTY_NAME>> in this.44)
		{
			208 2 = 1052.23(<<EMPTY_NAME>>.8, 512f);
			if (<<EMPTY_NAME>>.HasObjectType(2047.Slider))
			{
				2123 3 = (2123)<<EMPTY_NAME>>;
				for (int i = 0; i < 3.54.Count; i++)
				{
					3.54[i] = 1052.23(3.54[i], 512f);
				}
				3.58.SetPosition(2, false);
				3.8 = (3.18 = 2);
				3.RebuildPathAndTiming(true);
			}
			else
			{
				<<EMPTY_NAME>>.SetPosition(2, false);
			}
		}
		this.6.20(false, false);
	}

	// Token: 0x06002ADF RID: 10975 RVA: 0x000E7E20 File Offset: 0x000E6020
	internal virtual void FlipVertically()
	{
		if (this.44.Count == 0)
		{
			return;
		}
		this.6(false);
		this.6.19((2452)0, null);
		this.6.13((2451)24, (2450)2);
		this.6.24<2034>(this.44, false);
		this.44.ForEach(new Action<2034>(2255.2256.Instance.6));
		this.7(false);
		this.42 = this.40;
		foreach (2034 <<EMPTY_NAME>> in this.44)
		{
			208 2 = 1052.22(<<EMPTY_NAME>>.8, 384f);
			if (<<EMPTY_NAME>>.HasObjectType(2047.Slider))
			{
				2123 3 = (2123)<<EMPTY_NAME>>;
				for (int i = 0; i < 3.54.Count; i++)
				{
					3.54[i] = 1052.22(3.54[i], 384f);
				}
				3.58.SetPosition(2, false);
				3.8 = (3.18 = 2);
				3.RebuildPathAndTiming(true);
			}
			else
			{
				<<EMPTY_NAME>>.SetPosition(2, false);
			}
		}
		this.6.20(false, false);
	}

	// Token: 0x06002AE0 RID: 10976 RVA: 0x000E7F90 File Offset: 0x000E6190
	internal void 76()
	{
		if (this.44.Count == 0)
		{
			return;
		}
		this.6(false);
		this.6.19((2452)0, null);
		this.6.13((2451)25, (2450)8);
		this.6.24<2034>(this.44, false);
		this.44.ForEach(new Action<2034>(2255.2256.Instance.7));
		this.7(false);
		this.42 = this.40;
		208 <<EMPTY_NAME>> = this.81(true);
		foreach (2034 2 in this.44)
		{
			208 3 = 1052.25(2.8, <<EMPTY_NAME>>);
			if (2.HasObjectType(2047.Slider))
			{
				2123 4 = (2123)2;
				for (int i = 0; i < 4.54.Count; i++)
				{
					4.54[i] = 1052.25(4.54[i], <<EMPTY_NAME>>);
				}
				4.58.SetPosition(3, false);
				4.8 = (4.18 = 3);
				4.RebuildPathAndTiming(true);
			}
			else
			{
				2.SetPosition(3, false);
			}
		}
		this.6.20(false, false);
	}

	// Token: 0x06002AE1 RID: 10977 RVA: 0x000E8104 File Offset: 0x000E6304
	internal void 77()
	{
		if (this.44.Count == 0)
		{
			return;
		}
		this.6(false);
		this.6.19((2452)0, null);
		this.6.13((2451)25, (2450)4);
		this.6.24<2034>(this.44, false);
		this.44.ForEach(delegate(2034 1)
		{
			1.5();
		});
		this.7(false);
		this.42 = this.40;
		208 <<EMPTY_NAME>> = this.81(true);
		foreach (2034 2 in this.44)
		{
			208 3 = 1052.24(2.8, <<EMPTY_NAME>>);
			if (2.HasObjectType(2047.Slider))
			{
				2123 4 = (2123)2;
				for (int i = 0; i < 4.54.Count; i++)
				{
					4.54[i] = 1052.24(4.54[i], <<EMPTY_NAME>>);
				}
				4.58.SetPosition(3, false);
				4.8 = (4.18 = 3);
				4.RebuildPathAndTiming(true);
			}
			else
			{
				2.SetPosition(3, false);
			}
		}
		this.6.20(false, false);
	}

	// Token: 0x06002AE2 RID: 10978 RVA: 0x000E8288 File Offset: 0x000E6488
	internal void 78(int 1, bool 2)
	{
		if (this.44.Count == 0)
		{
			return;
		}
		this.44.ForEach(new Action<2034>(2255.2256.Instance.8));
		208 3 = this.81(2);
		foreach (2034 4 in this.44)
		{
			208 5 = 1052.26(4.8, 3, 1);
			if (4.HasObjectType(2047.Slider))
			{
				2123 6 = (2123)4;
				for (int i = 0; i < 6.54.Count; i++)
				{
					6.54[i] = 1052.26(6.54[i], 3, 1);
				}
				6.58.SetPosition(5, false);
				6.8 = (6.18 = 5);
				6.RebuildPathAndTiming(true);
			}
			else
			{
				4.SetPosition(5, false);
			}
		}
	}

	// Token: 0x06002AE3 RID: 10979 RVA: 0x000E839C File Offset: 0x000E659C
	internal void 79(208 1, bool 2)
	{
		if (this.44.Count == 0)
		{
			return;
		}
		this.44.ForEach(delegate(2034 1)
		{
			1.5();
		});
		208 3 = this.81(2);
		foreach (2034 4 in this.44)
		{
			208 5 = 1052.28(4.8, 3, 7);
			if (4.HasObjectType(2047.Slider))
			{
				2123 6 = (2123)4;
				for (int i = 0; i < 6.54.Count; i++)
				{
					6.54[i] = 1052.28(6.54[i], 3, 7);
				}
				6.58.SetPosition(5, false);
				6.8 = (6.18 = 5);
				6.6 = 0.0;
				6.RebuildPathAndTiming(true);
			}
			else
			{
				4.SetPosition(5, false);
			}
		}
		this.3.85 = true;
	}

	// Token: 0x06002AE4 RID: 10980 RVA: 0x000E84E0 File Offset: 0x000E66E0
	internal void 80(int 1, int 2, bool 3)
	{
		if (this.44.Count == 0)
		{
			return;
		}
		this.6.19((2452)0, null);
		this.6.13((2451)1, (!3) ? ((2450)256) : ((2450)0));
		this.6.24<2034>(this.44, false);
		this.44.ForEach(delegate(2034 1)
		{
			1.5();
		});
		foreach (2034 4 in this.44)
		{
			4.SetPosition(3 ? new 208(4.8.X + (float)5, 4.8.Y + (float)2) : new 208((float)5, (float)2), false);
		}
		this.6.20(false, false);
		this.6.17 = true;
	}

	// Token: 0x06002AE5 RID: 10981 RVA: 0x000E85F4 File Offset: 0x000E67F4
	internal 208 81(bool 1)
	{
		if (1)
		{
			return new 208(256f, 192f);
		}
		208 2 = 208.Zero;
		foreach (2034 3 in this.44)
		{
			2 += 3.18;
		}
		2.X /= (float)this.44.Count;
		2.Y /= (float)this.44.Count;
		return 2;
	}

	// Token: 0x06002AE6 RID: 10982 RVA: 0x000E8698 File Offset: 0x000E6898
	internal float 82(bool 1)
	{
		if (this.44.Count == 0)
		{
			return -1f;
		}
		208 2 = this.81(1);
		float num = 2.X;
		float num2 = 2.Y;
		float num3 = 2.X;
		float num4 = 2.Y;
		foreach (2034 3 in this.44)
		{
			num = Math.Min(3.8.X, num);
			num2 = Math.Min(3.8.Y, num2);
			num3 = Math.Max(3.8.X, num3);
			num4 = Math.Max(3.8.Y, num4);
			if (3.HasObjectType(2047.Slider))
			{
				2123 4 = (2123)3;
				num = Math.Min(4.GetEndPosition().X, num);
				num2 = Math.Min(4.GetEndPosition().Y, num2);
				num3 = Math.Max(4.GetEndPosition().X, num3);
				num4 = Math.Max(4.GetEndPosition().Y, num4);
			}
		}
		num -= 2.X;
		num2 -= 2.Y;
		num3 -= 2.X;
		num4 -= 2.Y;
		float num5 = (0f - 2.X) / num;
		float num6 = (0f - 2.Y) / num2;
		float num7 = (num3 == 0f) ? num5 : ((512f - 2.X) / num3);
		float num8 = (num4 == 0f) ? num6 : ((384f - 2.Y) / num4);
		if (num == 0f)
		{
			num5 = num7;
		}
		if (num2 == 0f)
		{
			num6 = num8;
		}
		if (num == 0f && num3 == 0f && num2 == 0f && num4 == 0f)
		{
			return -1f;
		}
		if (num == 0f && num3 == 0f)
		{
			return Math.Min(num6, num8);
		}
		if (num2 == 0f && num4 == 0f)
		{
			return Math.Min(num5, num7);
		}
		return Math.Min(Math.Min(num5, num7), Math.Min(num6, num8));
	}

	// Token: 0x04001F0D RID: 7949
	private static readonly 198 8 = new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue, 150);

	// Token: 0x04001F0E RID: 7950
	private static readonly 198 9 = new 198(0, 0, 0, 100);

	// Token: 0x04001F0F RID: 7951
	private static readonly 198 10 = new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);

	// Token: 0x04001F10 RID: 7952
	private static readonly 198 11 = new 198(byte.MaxValue, 40, 40, byte.MaxValue);

	// Token: 0x04001F11 RID: 7953
	private 2064 12 = 2064.PerfectCurve;

	// Token: 0x04001F12 RID: 7954
	protected readonly 198 13 = new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue, 20);

	// Token: 0x04001F13 RID: 7955
	private readonly 198 14 = new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue, 50);

	// Token: 0x04001F14 RID: 7956
	protected bool 15;

	// Token: 0x04001F15 RID: 7957
	protected bool 16;

	// Token: 0x04001F16 RID: 7958
	internal 1429 17;

	// Token: 0x04001F17 RID: 7959
	private 1452 18;

	// Token: 0x04001F18 RID: 7960
	private 1433[] 19;

	// Token: 0x04001F19 RID: 7961
	internal List<2034> 20;

	// Token: 0x04001F1A RID: 7962
	protected 2255.2257 21;

	// Token: 0x04001F1B RID: 7963
	internal 2034 22;

	// Token: 0x04001F1C RID: 7964
	private double 23;

	// Token: 0x04001F1D RID: 7965
	private bool 24;

	// Token: 0x04001F1E RID: 7966
	protected 208 25;

	// Token: 0x04001F1F RID: 7967
	protected 208 26;

	// Token: 0x04001F20 RID: 7968
	internal bool 27;

	// Token: 0x04001F21 RID: 7969
	private 208 28;

	// Token: 0x04001F22 RID: 7970
	private int 29;

	// Token: 0x04001F23 RID: 7971
	private bool 30;

	// Token: 0x04001F24 RID: 7972
	private 2647 31;

	// Token: 0x04001F25 RID: 7973
	private bool 32;

	// Token: 0x04001F26 RID: 7974
	protected 2034 33;

	// Token: 0x04001F27 RID: 7975
	private 2123 34;

	// Token: 0x04001F28 RID: 7976
	protected bool 35;

	// Token: 0x04001F29 RID: 7977
	protected bool 36;

	// Token: 0x04001F2A RID: 7978
	private bool 37;

	// Token: 0x04001F2B RID: 7979
	private 2275 38;

	// Token: 0x04001F2C RID: 7980
	internal bool 39;

	// Token: 0x04001F2D RID: 7981
	internal bool 40;

	// Token: 0x04001F2E RID: 7982
	internal bool 41;

	// Token: 0x04001F2F RID: 7983
	internal bool 42;

	// Token: 0x04001F30 RID: 7984
	private bool 43;

	// Token: 0x04001F31 RID: 7985
	internal List<2034> 44;

	// Token: 0x04001F32 RID: 7986
	internal 2123 45;

	// Token: 0x04001F33 RID: 7987
	internal int 46;

	// Token: 0x04001F34 RID: 7988
	protected bool 47;

	// Token: 0x04001F35 RID: 7989
	private 1452 48;

	// Token: 0x04001F36 RID: 7990
	private bool 49 = true;

	// Token: 0x04001F37 RID: 7991
	internal 2123 50;

	// Token: 0x04001F38 RID: 7992
	private 208 51;

	// Token: 0x04001F39 RID: 7993
	private bool 52;

	// Token: 0x04001F3A RID: 7994
	private 1433[] 53;

	// Token: 0x04001F3B RID: 7995
	internal static Dictionary<2357, bool> 54;

	// Token: 0x04001F3C RID: 7996
	private 2129 55;

	// Token: 0x04001F3D RID: 7997
	private int 56;

	// Token: 0x04001F3E RID: 7998
	private int 57;

	// Token: 0x04001F3F RID: 7999
	private 1452 58;

	// Token: 0x04001F40 RID: 8000
	private 208 59;

	// Token: 0x04001F41 RID: 8001
	private 1051 60;

	// Token: 0x04001F42 RID: 8002
	private bool 61;

	// Token: 0x04001F43 RID: 8003
	private bool 62;

	// Token: 0x04001F44 RID: 8004
	private 208 63;

	// Token: 0x04001F45 RID: 8005
	private 1433 64;

	// Token: 0x04001F46 RID: 8006
	private 1483 65;

	// Token: 0x04001F47 RID: 8007
	private 1452 66;

	// Token: 0x04001F48 RID: 8008
	private 1452 67;

	// Token: 0x04001F49 RID: 8009
	internal 1373 68;

	// Token: 0x04001F4A RID: 8010
	internal 1373 69;

	// Token: 0x04001F4B RID: 8011
	protected 1452 70;

	// Token: 0x04001F4C RID: 8012
	protected 2307 71;

	// Token: 0x04001F4D RID: 8013
	protected 2034 72;

	// Token: 0x04001F4E RID: 8014
	private bool 73;

	// Token: 0x04001F4F RID: 8015
	internal 2039 74;

	// Token: 0x04001F50 RID: 8016
	private List<2034> 75 = new List<2034>();

	// Token: 0x04001F51 RID: 8017
	private 1452 76;

	// Token: 0x0200056D RID: 1389
	[Serializable]
	public sealed class 2256
	{
		// Token: 0x06002AEC RID: 10988 RVA: 0x000E89E2 File Offset: 0x000E6BE2
		internal bool 1(2066 1)
		{
			return 1.3();
		}

		// Token: 0x06002AED RID: 10989 RVA: 0x000E89EA File Offset: 0x000E6BEA
		internal bool 2(1371 1)
		{
			return 1.8 != null;
		}

		// Token: 0x06002AEE RID: 10990 RVA: 0x000E89F5 File Offset: 0x000E6BF5
		internal bool 3(2034 1)
		{
			return !(1 is 2070);
		}

		// Token: 0x06002AEF RID: 10991 RVA: 0x000E8A03 File Offset: 0x000E6C03
		internal void 4(2034 1)
		{
			1.5();
		}

		// Token: 0x06002AF0 RID: 10992 RVA: 0x000E8A03 File Offset: 0x000E6C03
		internal void 5(2034 1)
		{
			1.5();
		}

		// Token: 0x06002AF1 RID: 10993 RVA: 0x000E8A03 File Offset: 0x000E6C03
		internal void 6(2034 1)
		{
			1.5();
		}

		// Token: 0x06002AF2 RID: 10994 RVA: 0x000E8A03 File Offset: 0x000E6C03
		internal void 7(2034 1)
		{
			1.5();
		}

		// Token: 0x06002AF3 RID: 10995 RVA: 0x000E8A03 File Offset: 0x000E6C03
		internal void 8(2034 1)
		{
			1.5();
		}

		// Token: 0x06002AF4 RID: 10996 RVA: 0x000E8A0B File Offset: 0x000E6C0B
		internal void 9(2034 1)
		{
			1.4(true);
		}

		// Token: 0x06002AF5 RID: 10997 RVA: 0x000E8A14 File Offset: 0x000E6C14
		internal void 10(2034 1)
		{
			1.4(false);
		}

		// Token: 0x06002AF6 RID: 10998 RVA: 0x000E8A0B File Offset: 0x000E6C0B
		internal void 11(2034 1)
		{
			1.4(true);
		}

		// Token: 0x04001F52 RID: 8018
		public static readonly 2255.2256 Instance = new 2255.2256();

		// Token: 0x04001F53 RID: 8019
		public static Predicate<2034> predicate;

		// Token: 0x04001F54 RID: 8020
		public static Predicate<2066> predicate2;

		// Token: 0x04001F55 RID: 8021
		public static Predicate<2066> predicate3;

		// Token: 0x04001F56 RID: 8022
		public static Predicate<1371> predicate4;

		// Token: 0x04001F57 RID: 8023
		public static Predicate<2034> predicate5;

		// Token: 0x04001F58 RID: 8024
		public static Func<2034, bool> func;

		// Token: 0x04001F59 RID: 8025
		public static Predicate<2034> predicate6;

		// Token: 0x04001F5A RID: 8026
		public static Action<2034> action;

		// Token: 0x04001F5B RID: 8027
		public static Action<2034> action2;

		// Token: 0x04001F5C RID: 8028
		public static Action<2034> action3;

		// Token: 0x04001F5D RID: 8029
		public static Action<2034> action4;

		// Token: 0x04001F5E RID: 8030
		public static Action<2034> action5;

		// Token: 0x04001F5F RID: 8031
		public static Action<2034> action6;

		// Token: 0x04001F60 RID: 8032
		public static Action<2034> action7;

		// Token: 0x04001F61 RID: 8033
		public static Action<2034> action8;

		// Token: 0x04001F62 RID: 8034
		public static Action<2034> action9;

		// Token: 0x04001F63 RID: 8035
		public static Action<2034> action10;

		// Token: 0x04001F64 RID: 8036
		public static Action<2034> action11;

		// Token: 0x04001F65 RID: 8037
		public static Comparison<2034> comparison;

		// Token: 0x04001F66 RID: 8038
		public static Predicate<2066> predicate7;
	}

	// Token: 0x0200056E RID: 1390
	public enum 2257
	{

	}

	// Token: 0x0200056F RID: 1391
	public sealed class 2260
	{
		// Token: 0x06002AF9 RID: 11001 RVA: 0x000E8A29 File Offset: 0x000E6C29
		internal void 1(2034 1)
		{
			1.SetStartTime(1.1 + this.1);
		}

		// Token: 0x04001F68 RID: 8040
		public int 1;
	}

	// Token: 0x02000570 RID: 1392
	public sealed class 2262
	{
		// Token: 0x04001F69 RID: 8041
		public 2255 1;

		// Token: 0x04001F6A RID: 8042
		public 2034 2;
	}

	// Token: 0x02000571 RID: 1393
	public sealed class 2259
	{
		// Token: 0x06002AFC RID: 11004 RVA: 0x000E8A40 File Offset: 0x000E6C40
		internal bool 1(2034 1)
		{
			if (this.2.1.44.Contains(1))
			{
				return false;
			}
			if (1 == this.2.2 && 2255.54[2357.DistSnap])
			{
				return false;
			}
			2123 2 = 1 as 2123;
			return 1.IsActive() || (2 != null && 2.58 != null && 2.58.IsActive()) || (1.2 > this.1.1 - this.2.1.4.2 && 1.1 < this.1.2 + this.2.1.4.2);
		}

		// Token: 0x04001F6B RID: 8043
		public 2034 1;

		// Token: 0x04001F6C RID: 8044
		public 2255.2262 2;
	}

	// Token: 0x02000572 RID: 1394
	public sealed class 2261
	{
		// Token: 0x06002AFE RID: 11006 RVA: 0x000E8B02 File Offset: 0x000E6D02
		internal bool 1(2034 1)
		{
			return 1.2 < this.1 - 1;
		}

		// Token: 0x04001F6D RID: 8045
		public int 1;
	}

	// Token: 0x02000573 RID: 1395
	public sealed class 2258
	{
		// Token: 0x06002B00 RID: 11008 RVA: 0x000E8B14 File Offset: 0x000E6D14
		internal bool 1(2034 1)
		{
			return 1 == this.1;
		}

		// Token: 0x06002B01 RID: 11009 RVA: 0x000E8B1F File Offset: 0x000E6D1F
		internal bool 2(2034 1)
		{
			return 1 == this.2;
		}

		// Token: 0x04001F6E RID: 8046
		public 2034 1;

		// Token: 0x04001F6F RID: 8047
		public 2034 2;
	}
}
