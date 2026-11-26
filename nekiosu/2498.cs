using System;

// Token: 0x02000509 RID: 1289
[276]
internal sealed class 2498 : 2510
{
	// Token: 0x0600277F RID: 10111 RVA: 0x000C5434 File Offset: 0x000C3634
	internal 2498(2511 1, 2528 2) : base(1, 2)
	{
		2.21 = true;
		2.22 = true;
		2.8(2530.2("width", "Width", "In game units (the screen is 480 high).", 250f, 1f, 2000f, 1f, "0.##"));
		2.8(2530.2("height", "Height", "In game units (the screen is 480 high).", 50f, 1f, 2000f, 1f, "0.##"));
		2.8(2530.2("corner_radius", "Corner radius", "How rounded the corners should be.", 0.25f, 0f, 0.5f, 0.01f, "0.##")).10 = true;
	}

	// Token: 0x06002780 RID: 10112 RVA: 0x000C54F8 File Offset: 0x000C36F8
	internal override void Build()
	{
		this.7 = null;
		this.5 = base.1<1433>(new 1433(null, (1376)6, 1065.Centre, (1044)0, base.Pivot, 0.9f, true, 198.White, null), true);
		this.5.66 = false;
		this.6();
	}

	// Token: 0x06002781 RID: 10113 RVA: 0x000C5548 File Offset: 0x000C3748
	private void 6()
	{
		float num = 1662.70.3();
		float num2 = Math.Max(0.05f, this.2.10);
		int num3 = (int)Math.Round((double)(this.2.12("width") * num * num2));
		int num4 = (int)Math.Round((double)(this.2.12("height") * num * num2));
		float <<EMPTY_NAME>> = this.2.12("corner_radius");
		string a = string.Concat(new string[]
		{
			num3.ToString(),
			"x",
			num4.ToString(),
			"/",
			<<EMPTY_NAME>>.ToString()
		});
		if (a == this.7)
		{
			return;
		}
		this.7 = a;
		1381 2 = this.6;
		this.6 = 2532.2(num3, num4, <<EMPTY_NAME>>);
		this.5.SetTexture(this.6);
		this.5.15 = 1f;
		this.5.69 = num2;
		this.5.20 = new 208(this.2.12("width") * num * num2 / (float)Math.Max(1, num3), this.2.12("height") * num * num2 / (float)Math.Max(1, num4));
		if (2 != null)
		{
			2.Dispose();
		}
		this.2.32();
	}

	// Token: 0x06002782 RID: 10114 RVA: 0x000C56B5 File Offset: 0x000C38B5
	internal override void Update()
	{
		if (this.5 != null)
		{
			this.6();
		}
	}

	// Token: 0x06002783 RID: 10115 RVA: 0x000C56C5 File Offset: 0x000C38C5
	protected override void OnSettingChanged(string 1)
	{
		if (this.5 != null && (1 == "width" || 1 == "height" || 1 == "corner_radius"))
		{
			this.6();
			return;
		}
		base.OnSettingChanged(1);
	}

	// Token: 0x06002784 RID: 10116 RVA: 0x000C5704 File Offset: 0x000C3904
	public override void Dispose()
	{
		base.Dispose();
		1381 <<EMPTY_NAME>> = this.6;
		if (<<EMPTY_NAME>> != null)
		{
			<<EMPTY_NAME>>.Dispose();
		}
		this.6 = null;
	}

	// Token: 0x04001C81 RID: 7297
	private new 1433 5;

	// Token: 0x04001C82 RID: 7298
	private 1381 6;

	// Token: 0x04001C83 RID: 7299
	private string 7;
}
