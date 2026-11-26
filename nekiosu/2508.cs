using System;

// Token: 0x0200051B RID: 1307
[276]
public class 2508 : 2542
{
	// Token: 0x06002827 RID: 10279 RVA: 0x000BB2E3 File Offset: 0x000B94E3
	internal 2508(1803 1, 2039 2) : base(1, 2)
	{
	}

	// Token: 0x06002828 RID: 10280 RVA: 0x000CB80F File Offset: 0x000C9A0F
	protected new float 7()
	{
		return 3f * this.GetMeterScale();
	}

	// Token: 0x06002829 RID: 10281 RVA: 0x000CB81D File Offset: 0x000C9A1D
	internal virtual 208 GetBarCenter()
	{
		return new 208((float)(1662.70.1() / 2), (float)1662.70.2() - this.7() * 2f);
	}

	// Token: 0x0600282A RID: 10282 RVA: 0x000CB849 File Offset: 0x000C9A49
	internal virtual float GetScaledHitWindow()
	{
		return (float)this.3.3 * this.GetMeterScale();
	}

	// Token: 0x0600282B RID: 10283 RVA: 0x000CB85E File Offset: 0x000C9A5E
	internal new float 8()
	{
		return (float)this.3.3;
	}

	// Token: 0x0600282C RID: 10284 RVA: 0x000CB86C File Offset: 0x000C9A6C
	internal override void BuildLayout()
	{
		float <<EMPTY_NAME>> = this.GetScaledHitWindow();
		1433 2 = new 1433(1662.34, (1376)6, 1065.Centre, (1044)1, this.GetBarCenter(), 0.79f, true, 198.Black, null);
		2.16 = 0.6f;
		2.20 = new 208(<<EMPTY_NAME>>, this.7() * 4f) * 1.6f;
		this.4.12(2);
		if (base.3("colour_bars", "1") == "1")
		{
			<<EMPTY_NAME>> = (float)this.3.5 / this.8() * this.GetScaledHitWindow();
			1433 3 = new 1433(1662.34, (1376)6, 1065.Centre, (1044)1, this.GetBarCenter(), 0.82f, true, this.7, null);
			3.20 = new 208(<<EMPTY_NAME>>, this.7()) * 1.6f;
			this.4.12(3);
			<<EMPTY_NAME>> = (float)this.3.4 / this.8() * this.GetScaledHitWindow();
			3 = new 1433(1662.34, (1376)6, 1065.Centre, (1044)1, this.GetBarCenter(), 0.81f, true, this.8, null);
			3.20 = new 208(<<EMPTY_NAME>>, this.7()) * 1.6f;
			this.4.12(3);
			<<EMPTY_NAME>> = (float)this.3.3 / this.8() * this.GetScaledHitWindow();
			3 = new 1433(1662.34, (1376)6, 1065.Centre, (1044)1, this.GetBarCenter(), 0.8f, true, this.9, null);
			3.20 = new 208(<<EMPTY_NAME>>, this.7()) * 1.6f;
			this.4.12(3);
		}
		this.12 = new 1433(1662.34, (1376)6, 1065.Centre, (1044)1, this.GetBarCenter(), 0.83f, true, 198.White, null);
		this.12.20 = new 208(1.5f, this.7() * 4f) * 1.6f;
		this.4.12(this.12);
		this.10 = new 1433(1455.2("editor-rate-arrow", (1416)1, null), (1376)6, 1065.BottomCentre, (1044)1, this.GetBarCenter() + new 208(0f, -3f), 0.84f, true, 198.White, null);
		this.10.15 = 0.6f * this.GetMeterScale();
		this.10.16 = ((base.3("average_arrow", "1") == "1") ? 1f : 0f);
		this.4.12(this.10);
		this.9();
		this.10();
	}

	// Token: 0x0600282D RID: 10285 RVA: 0x000CBB2C File Offset: 0x000C9D2C
	private new void 9()
	{
		string a = base.3("centre_marker", "none");
		float num = this.7() * 4f;
		if (a == "circle")
		{
			float num2 = Math.Min(num, 5f * this.GetMeterScale());
			1433 <<EMPTY_NAME>> = new 1433(2532.Circle(64), (1376)6, 1065.Centre, (1044)1, this.GetBarCenter(), 0.835f, true, this.7, null);
			<<EMPTY_NAME>>.15 = 1.6f * num2 / 64f;
			this.4.12(<<EMPTY_NAME>>);
			1433 2 = new 1433(2532.Circle(64), (1376)6, 1065.Centre, (1044)1, this.GetBarCenter(), 0.836f, true, new 198(35, 132, 162), null);
			2.15 = 1.6f * num2 / 2f / 64f;
			this.4.12(2);
			return;
		}
		if (a == "line")
		{
			1433 3 = new 1433(1662.34, (1376)6, 1065.Centre, (1044)1, this.GetBarCenter(), 0.835f, true, this.7, null);
			3.20 = new 208(1.5f, num) * 1.6f;
			this.4.12(3);
		}
	}

	// Token: 0x0600282E RID: 10286 RVA: 0x000CBC6C File Offset: 0x000C9E6C
	private void 10()
	{
		if (base.3("labels", "none") != "text")
		{
			return;
		}
		float num = this.GetScaledHitWindow() / 2f;
		1452 <<EMPTY_NAME>> = new 1452("Early", 8f, this.GetBarCenter() - new 208(num + 4f, 0f), 0.85f, true, 198.White)
		{
			49 = 1065.CentreRight,
			1 = (1044)1
		};
		1452 2 = new 1452("Late", 8f, this.GetBarCenter() + new 208(num + 4f, 0f), 0.85f, true, 198.White)
		{
			49 = 1065.CentreLeft,
			1 = (1044)1
		};
		this.4.12(<<EMPTY_NAME>>);
		this.4.12(2);
	}

	// Token: 0x0600282F RID: 10287 RVA: 0x000CBD48 File Offset: 0x000C9F48
	internal override void OnHitOffset(2034 1, int? 2)
	{
		float num = (float)(2 ?? (1226.16 - 1.1));
		this.6 = 1226.16 + 4000;
		base.6();
		num = ((num >= 0f) ? Math.Min(num, this.8()) : Math.Max(num, 0f - this.8()));
		float num2 = num / this.8() * (this.GetScaledHitWindow() / 2f);
		this.11 = this.11 * 0.8f + num2 * 0.2f;
		this.10.19(new 208(this.GetBarCenter().X + this.11, this.10.7.Y), 800, (1046)1);
		num = Math.Abs(num);
		1433 3 = this.12.Clone();
		3.1 = (1044)2;
		3.5 = false;
		3.2 = 0.85f;
		3.6 = ((num < (float)this.3.5) ? this.7 : ((num < (float)this.3.4) ? this.8 : this.9));
		3.17.X = this.GetBarCenter().X + num2;
		3.20.X = base.4("line_thickness", 3f);
		3.16 = 0.4f;
		3.28 = true;
		3.16(10000, (1046)0, 0);
		this.4.12(3);
	}

	// Token: 0x04001CE8 RID: 7400
	protected 1433 10;

	// Token: 0x04001CE9 RID: 7401
	private float 11;

	// Token: 0x04001CEA RID: 7402
	private 1433 12;
}
