using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

// Token: 0x0200050C RID: 1292
[276]
internal sealed class 2543 : 2510
{
	// Token: 0x0600278E RID: 10126 RVA: 0x000C5A8C File Offset: 0x000C3C8C
	internal 2543(2511 1, 2528 2) : base(1, 2)
	{
		2.21 = true;
		2.22 = true;
		2.8(2530.2("width", "Width", "In game units (the screen is 480 high).", 81.25f, 10f, 2000f, 1f, "0.##"));
		2.8(2530.2("height", "Height", "In game units (the screen is 480 high).", 43.75f, 5f, 480f, 1f, "0.##"));
		2.8(2530.Colour("played", "Played colour", "The part of the map already played.", new 198(230, 141, 235)));
		2.8(2530.Colour("unplayed", "Unplayed colour", "The part still to come.", new 198(51, 51, 51)));
		2.8(2530.1("outline", "Outline", "A line along the graph, the area under it darker.", false));
	}

	// Token: 0x0600278F RID: 10127 RVA: 0x000C5B88 File Offset: 0x000C3D88
	internal override void Build()
	{
		this.9 = null;
		this.10 = null;
		208 pivot = base.Pivot;
		this.7 = base.1<1433>(new 1433(null, (1376)6, 1065.TopLeft, (1044)0, pivot, 0.9f, true, 198.White, null), true);
		this.6 = base.1<1433>(new 1433(null, (1376)6, 1065.TopLeft, (1044)0, pivot, 0.901f, true, 198.White, null), false);
		1433[] array = new 1433[]
		{
			this.6,
			this.7
		};
		for (int i = 0; i < array.Length; i++)
		{
			array[i].66 = false;
		}
		this.6();
	}

	// Token: 0x06002790 RID: 10128 RVA: 0x000C5C28 File Offset: 0x000C3E28
	private void 6()
	{
		1922 strainGraph = 2206.StrainGraph;
		float num = 1662.70.3();
		float num2 = Math.Max(0.05f, this.2.10);
		float num3 = this.2.12("width");
		float num4 = this.2.12("height");
		int num5 = Math.Max(1, (int)Math.Round((double)(num3 * num * num2)));
		int num6 = Math.Max(1, (int)Math.Round((double)(num4 * num * num2)));
		bool flag = this.2.11("outline");
		string a = string.Concat(new string[]
		{
			num5.ToString(),
			"x",
			num6.ToString(),
			"/",
			flag.ToString()
		});
		if (a == this.9 && strainGraph == this.10)
		{
			return;
		}
		this.9 = a;
		this.10 = strainGraph;
		1381 <<EMPTY_NAME>> = this.8;
		float num7 = num * num2 * 0.625f;
		this.8 = 2543.7(strainGraph, num5, num6, num3 / 0.625f, 2f * num7, flag ? (2f * num7) : 0f);
		this.11 = num5;
		208 2 = new 208(num3 * num * num2 / (float)num5, num4 * num * num2 / (float)num6);
		foreach (1433 3 in new 1433[]
		{
			this.6,
			this.7
		})
		{
			3.SetTexture(this.8);
			3.15 = 1f;
			3.69 = num2;
			3.20 = 2;
		}
		if (<<EMPTY_NAME>> != null)
		{
			<<EMPTY_NAME>>.Dispose();
		}
		this.2.32();
	}

	// Token: 0x06002791 RID: 10129 RVA: 0x000C5DF4 File Offset: 0x000C3FF4
	internal override void Update()
	{
		if (this.7 == null)
		{
			return;
		}
		this.6();
		1922 <<EMPTY_NAME>> = this.10;
		this.6.6 = this.2.14("played");
		this.7.6 = this.2.14("unplayed");
		double num = 0.0;
		if (<<EMPTY_NAME>> != null)
		{
			double num2 = Math.Max(1.0, <<EMPTY_NAME>>.5 - <<EMPTY_NAME>>.4);
			num = Math.Max(0.0, Math.Min(1.0, ((double)1226.16 - <<EMPTY_NAME>>.4) / num2));
		}
		this.6.ResetSourceRectangle();
		this.6.35 = (int)Math.Round(num * (double)this.11);
		this.6.16 = (this.7.16 = ((<<EMPTY_NAME>> != null) ? 1f : 0f));
	}

	// Token: 0x06002792 RID: 10130 RVA: 0x000C5EF0 File Offset: 0x000C40F0
	protected override void OnSettingChanged(string 1)
	{
		if (this.7 != null && (1 == "width" || 1 == "height" || 1 == "outline" || 1 == "played" || 1 == "unplayed"))
		{
			this.6();
			return;
		}
		base.OnSettingChanged(1);
	}

	// Token: 0x06002793 RID: 10131 RVA: 0x000C5F54 File Offset: 0x000C4154
	public override void Dispose()
	{
		base.Dispose();
		1381 <<EMPTY_NAME>> = this.8;
		if (<<EMPTY_NAME>> != null)
		{
			<<EMPTY_NAME>>.Dispose();
		}
		this.8 = null;
	}

	// Token: 0x06002794 RID: 10132 RVA: 0x000C5F74 File Offset: 0x000C4174
	internal static 1381 7(1922 1, int 2, int 3, float 4, float 5, float 6)
	{
		return 2532.5(2, 3, delegate(Graphics 1)
		{
			if (7 == null || 7.1 == null || 7.1.Length == 0)
			{
				return;
			}
			double num;
			2543.2544 8 = 2543.8(7, 4, out num);
			float num2 = (float)3;
			if (6 > 0f)
			{
				num2 -= 6 / 2f;
				5 = Math.Max(5, 6 / 2f);
			}
			float num3 = num2 - 5;
			List<PointF> list = new List<PointF>();
			for (float num4 = 0f; num4 <= (float)2; num4 += 0.5f)
			{
				double num5 = Math.Max(8.1((double)(num4 / (float)2)), 0.0) / num;
				list.Add(new PointF(num4, (float)3 - (float)(num5 * num5 * (double)num3 + (double)5)));
			}
			List<PointF> list2 = new List<PointF>
			{
				new PointF(0f, (float)3)
			};
			list2.AddRange(list);
			list2.Add(new PointF((float)2, (float)3));
			using (SolidBrush solidBrush = new SolidBrush((6 > 0f) ? Color.FromArgb(128, 128, 128, 128) : Color.White))
			{
				1.FillPolygon(solidBrush, list2.ToArray());
			}
			if (6 > 0f && list.Count > 1)
			{
				using (Pen pen = new Pen(Color.White, 6)
				{
					StartCap = LineCap.Round,
					EndCap = LineCap.Round,
					LineJoin = LineJoin.Round
				})
				{
					1.DrawLines(pen, list.ToArray());
				}
			}
		});
	}

	// Token: 0x06002795 RID: 10133 RVA: 0x000C5FD0 File Offset: 0x000C41D0
	private static 2543.2544 8(1922 1, float 2, out double 3)
	{
		double[] 4 = 1.1;
		double 5 = 1.4;
		double num = Math.Max(1.5, 1.3);
		double num2 = 1.3 - 1.2;
		int num3 = Math.Max((int)((num - 5) / 30000.0 * (200.0 / (double)2)), 1);
		List<KeyValuePair<double, double>> list = new List<KeyValuePair<double, double>>
		{
			new KeyValuePair<double, double>(1.4 - 0.001, 4[0])
		};
		int num4 = (4.Length - 1) / num3;
		3 = 0.0;
		for (int i = 0; i <= num4; i++)
		{
			double num5 = 0.0;
			for (int j = i * num3; j < Math.Min(4.Length, i * num3 + num3); j++)
			{
				num5 = Math.Max(num5, 4[j]);
			}
			3 = Math.Max(3, num5);
			list.Add(new KeyValuePair<double, double>(1.2 + (double)i / (double)Math.Max(1, num4) * num2, num5));
		}
		if (1.5 > 1.3)
		{
			list.Add(new KeyValuePair<double, double>(1.5, 4[4.Length - 1]));
		}
		if (3 <= 0.0)
		{
			3 = 1.0;
		}
		return new 2543.2544(list);
	}

	// Token: 0x04001C89 RID: 7305
	private new const float 5 = 0.625f;

	// Token: 0x04001C8A RID: 7306
	private 1433 6;

	// Token: 0x04001C8B RID: 7307
	private 1433 7;

	// Token: 0x04001C8C RID: 7308
	private 1381 8;

	// Token: 0x04001C8D RID: 7309
	private string 9;

	// Token: 0x04001C8E RID: 7310
	private 1922 10;

	// Token: 0x04001C8F RID: 7311
	private int 11;

	// Token: 0x0200050D RID: 1293
	[276]
	private sealed class 2544
	{
		// Token: 0x06002796 RID: 10134 RVA: 0x000C6124 File Offset: 0x000C4324
		public 2544(List<KeyValuePair<double, double>> 1)
		{
			List<KeyValuePair<double, double>> list = new List<KeyValuePair<double, double>>(1);
			for (int i = 1; i < list.Count; i++)
			{
				int num = i;
				while (num > 0 && list[num - 1].Key > list[num].Key)
				{
					KeyValuePair<double, double> value = list[num - 1];
					list[num - 1] = list[num];
					list[num] = value;
					num--;
				}
			}
			foreach (KeyValuePair<double, double> item in list)
			{
				if (this.1.Count <= 0 || item.Key > this.1[this.1.Count - 1].Key)
				{
					this.1.Add(item);
				}
			}
			if (this.1.Count == 1)
			{
				this.1.Add(new KeyValuePair<double, double>(this.1[0].Key + 1.0, this.1[0].Value));
			}
			List<double> list2 = new List<double>();
			List<double> list3 = new List<double>();
			for (int j = 0; j < this.1.Count - 1; j++)
			{
				double num2 = this.1[j + 1].Key - this.1[j].Key;
				this.2 += num2;
				list2.Add(num2);
				list3.Add((this.1[j + 1].Value - this.1[j].Value) / num2);
			}
			this.3.Add(list3[0]);
			for (int k = 0; k < list2.Count - 1; k++)
			{
				double num3 = list3[k];
				double num4 = list3[k + 1];
				if (num3 * num4 <= 0.0)
				{
					this.3.Add(0.0);
				}
				else
				{
					double num5 = list2[k] + list2[k + 1];
					this.3.Add(3.0 * num5 / ((num5 + list2[k + 1]) / num3 + (num5 + list2[k]) / num4));
				}
			}
			this.3.Add(list3[list3.Count - 1]);
			for (int l = 0; l < this.3.Count - 1; l++)
			{
				double num6 = this.3[l];
				double num7 = list3[l];
				double num8 = 1.0 / list2[l];
				double num9 = num6 + this.3[l + 1] - num7 - num7;
				this.4.Add((num7 - num6 - num9) * num8);
				this.5.Add(num9 * num8 * num8);
			}
		}

		// Token: 0x06002797 RID: 10135 RVA: 0x000C64BC File Offset: 0x000C46BC
		public double 1(double 1)
		{
			double num = this.1[0].Key + this.2 * Math.Max(0.0, Math.Min(1.0, 1));
			int num2 = 0;
			while (num2 < this.5.Count && this.1[num2].Key < num)
			{
				num2++;
			}
			num2 = Math.Max(0, Math.Min(this.5.Count - 1, num2 - 1));
			double num3 = num - this.1[num2].Key;
			return this.1[num2].Value + this.3[num2] * num3 + this.4[num2] * num3 * num3 + this.5[num2] * num3 * num3 * num3;
		}

		// Token: 0x04001C90 RID: 7312
		private readonly List<KeyValuePair<double, double>> 1 = new List<KeyValuePair<double, double>>();

		// Token: 0x04001C91 RID: 7313
		private readonly double 2;

		// Token: 0x04001C92 RID: 7314
		private readonly List<double> 3 = new List<double>();

		// Token: 0x04001C93 RID: 7315
		private readonly List<double> 4 = new List<double>();

		// Token: 0x04001C94 RID: 7316
		private readonly List<double> 5 = new List<double>();
	}
}
