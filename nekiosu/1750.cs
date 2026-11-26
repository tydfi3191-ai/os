using System;

// Token: 0x020008EC RID: 2284
public sealed class 1750 : 1689
{
	// Token: 0x06004121 RID: 16673 RVA: 0x0019454C File Offset: 0x0019274C
	public 1750() : base("Mirror", true)
	{
		float num = (float)1662.70.1() / 2f;
		this.7.12(new 1452("Flip objects on the chosen axes.", 14f, new 208(0f, this.3 - 30f), 208.Zero, 0.94f, true, 198.LightGray, true)
		{
			41 = (1376)7,
			49 = 1065.Centre
		});
		this.20 = new 1452("Flipped axes", 16f, new 208(num - 230f, this.3), 0.94f, true, 198.White);
		this.20.49 = 1065.CentreLeft;
		this.7.12(this.20);
		this.19 = new 1373(this.7, string.Empty, new 208(num - 100f, this.3 - 9f), 200f, 0.96f);
		this.19.10("Horizontal", 1932.Horizontal);
		this.19.10("Vertical", 1932.Vertical);
		this.19.10("Both", 1932.Both);
		this.19.18(1925.SelectedMirrorAxes, true);
		this.19.1(delegate(object 1, EventArgs 2)
		{
			if (1925.MirrorEnabled)
			{
				object obj = this.19.18;
				if (obj is 1932)
				{
					1932 3 = (1932)obj;
					1925.12(true, 3);
				}
			}
		});
		this.3 += 45f;
		this.18 = base.7(1750.12(), 1750.13(), delegate(object 1, EventArgs 2)
		{
			1925.12(!1925.MirrorEnabled, 1925.SelectedMirrorAxes);
			this.Refresh();
		}, false, false, true);
		base.7("Back", 198.Gray, null, true, false, true);
		base.3(delegate(object 1, EventArgs 2)
		{
			if (1662.78 == 1677.SelectPlay)
			{
				1662.25(new 1746());
			}
		});
	}

	// Token: 0x06004122 RID: 16674 RVA: 0x00194731 File Offset: 0x00192931
	private static string 12()
	{
		if (!1925.MirrorEnabled)
		{
			return "Enable Mirror";
		}
		return "Disable Mirror";
	}

	// Token: 0x06004123 RID: 16675 RVA: 0x00194745 File Offset: 0x00192945
	private static 198 13()
	{
		if (!1925.MirrorEnabled)
		{
			return 198.YellowGreen;
		}
		return 198.OrangeRed;
	}

	// Token: 0x06004124 RID: 16676 RVA: 0x00194759 File Offset: 0x00192959
	internal override void OnShown()
	{
		base.OnShown();
		this.Refresh();
	}

	// Token: 0x06004125 RID: 16677 RVA: 0x00194768 File Offset: 0x00192968
	private void Refresh()
	{
		bool mirrorEnabled = 1925.MirrorEnabled;
		this.18.4.SetText(1750.12());
		this.18.4(1750.13());
		this.19.5(mirrorEnabled);
		this.20.24(mirrorEnabled ? 1f : 0.4f, 100, (1046)0);
	}

	// Token: 0x06004126 RID: 16678 RVA: 0x001947C9 File Offset: 0x001929C9
	protected override void Dispose(bool 1)
	{
		this.19.17();
		base.Dispose(1);
	}

	// Token: 0x04002FA1 RID: 12193
	private readonly 1361 18;

	// Token: 0x04002FA2 RID: 12194
	private readonly 1373 19;

	// Token: 0x04002FA3 RID: 12195
	private readonly 1452 20;
}
