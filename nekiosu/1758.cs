using System;
using System.Globalization;

// Token: 0x020008FA RID: 2298
public sealed class 1758 : 1689
{
	// Token: 0x06004182 RID: 16770 RVA: 0x00196C24 File Offset: 0x00194E24
	public 1758() : base("Random", true)
	{
		float num = (float)1662.70.1() / 2f;
		2147 selectedPlayMode = 1925.SelectedPlayMode;
		this.31 = (selectedPlayMode == 2147.CatchTheBeat);
		this.30 = (selectedPlayMode == 2147.Taiko || this.31);
		string <<EMPTY_NAME>> = this.31 ? "Every jump keeps its size but may switch direction. Streams move as a whole." : (this.30 ? "Shuffle around the colours! At 100% every note gets a random colour, as in lazer." : "It never gets boring! Every object is moved to a new place.");
		this.7.12(new 1452(<<EMPTY_NAME>>, 14f, new 208(0f, this.3 - 30f), 208.Zero, 0.94f, true, 198.LightGray, true)
		{
			41 = (1376)7,
			49 = 1065.Centre
		});
		this.21 = new 1452(this.30 ? "Randomness" : "Angle sharpness", 16f, new 208(num - 230f, this.3), 0.94f, true, 198.White);
		this.21.49 = 1065.CentreLeft;
		this.21.52 = (this.31 ? "How many of the jumps may switch direction (about half of those do)." : (this.30 ? "How many of the notes get a random colour (about half of those change).\nnekiosu's own setting: lazer's Random is 100%." : "How sharp angles should be"));
		this.7.12(this.21);
		this.20 = new 1429(this.7, (double)this.12(), (double)this.13(), (double)this.14(), new 208(num - 100f, this.3), 200);
		this.20.21 = (this.30 ? 5.0 : 0.5);
		this.17.Add(this.20);
		this.20.18 = delegate(bool 1)
		{
			if (!this.27 && 1925.RandomEnabled)
			{
				if (this.30)
				{
					1925.6((int)Math.Round(this.20.7));
				}
				else
				{
					1925.4(true, 1925.SelectedRandomSeed, (float)Math.Round(this.20.7, 1));
				}
				this.Refresh();
			}
		};
		this.22 = new 1452(string.Empty, 16f, new 208(num + 115f, this.3), 0.94f, true, 198.White);
		this.22.49 = 1065.CentreLeft;
		this.7.12(this.22);
		this.3 += 35f;
		this.23 = new 1452("Seed", 16f, new 208(num - 230f, this.3), 0.94f, true, 198.White);
		this.23.49 = 1065.CentreLeft;
		this.23.52 = "Use a custom seed instead of a random one";
		this.7.12(this.23);
		this.26 = ((1925.SelectedRandomSeed != null) ? 1925.SelectedRandomSeed.Value.ToString(1662.18) : string.Empty);
		this.25 = new 1448(this.26, 14f, new 208(num - 100f, this.3 - 9f), 120f, 0.95f, false);
		this.25.4 = 11;
		this.7.14<1433>(this.25.2);
		this.24 = new 1452("roll", 14f, new 208(num + 30f, this.3), 0.94f, true, 198.Gray);
		this.24.49 = 1065.CentreLeft;
		this.24.10 = true;
		this.24.52 = "A new seed";
		this.24.42 = new 1445(198.Gray, 198.White, 0, 100);
		this.24.3(delegate(object 1, EventArgs 2)
		{
			this.25.SetText(1925.5().ToString(1662.18));
			this.Refresh();
		});
		this.7.12(this.24);
		this.3 += 45f;
		this.19 = base.7(1758.16(), 1758.17(), delegate(object 1, EventArgs 2)
		{
			1925.4(!1925.RandomEnabled, 1758.15(this.25.GetText()), 1925.SelectedAngleSharpness);
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

	// Token: 0x06004183 RID: 16771 RVA: 0x0019705C File Offset: 0x0019525C
	private float 12()
	{
		if (!this.30)
		{
			return 1f;
		}
		return 1f;
	}

	// Token: 0x06004184 RID: 16772 RVA: 0x00197071 File Offset: 0x00195271
	private float 13()
	{
		if (!this.30)
		{
			return 10f;
		}
		return 100f;
	}

	// Token: 0x06004185 RID: 16773 RVA: 0x00197086 File Offset: 0x00195286
	private new float 14()
	{
		if (!this.30)
		{
			return 1925.SelectedAngleSharpness;
		}
		return (float)1925.SelectedRandomStrength;
	}

	// Token: 0x06004186 RID: 16774 RVA: 0x0019709C File Offset: 0x0019529C
	private new static int? 15(string 1)
	{
		int value;
		if (!int.TryParse((1 ?? string.Empty).Trim(), NumberStyles.Integer, 1662.18, out value))
		{
			return null;
		}
		return new int?(value);
	}

	// Token: 0x06004187 RID: 16775 RVA: 0x001970D7 File Offset: 0x001952D7
	private new static string 16()
	{
		if (!1925.RandomEnabled)
		{
			return "Enable Random";
		}
		return "Disable Random";
	}

	// Token: 0x06004188 RID: 16776 RVA: 0x001970EB File Offset: 0x001952EB
	private new static 198 17()
	{
		if (!1925.RandomEnabled)
		{
			return 198.YellowGreen;
		}
		return 198.OrangeRed;
	}

	// Token: 0x06004189 RID: 16777 RVA: 0x001970FF File Offset: 0x001952FF
	internal override void OnShown()
	{
		base.OnShown();
		this.Refresh();
	}

	// Token: 0x0600418A RID: 16778 RVA: 0x00197110 File Offset: 0x00195310
	public override void Update()
	{
		base.Update();
		bool randomEnabled = 1925.RandomEnabled;
		bool flag = 1555.2() == 199.Pressed;
		if (!flag || !this.4 || !randomEnabled)
		{
			this.28 = false;
		}
		else if (!this.29)
		{
			this.28 = this.20.25();
		}
		if (this.28)
		{
			this.20.27();
		}
		this.29 = flag;
		int? selectedRandomSeed = 1925.SelectedRandomSeed;
		if (selectedRandomSeed != null)
		{
			int? num = selectedRandomSeed;
			int? num2 = 1758.15(this.25.GetText());
			if (!(num.GetValueOrDefault() == num2.GetValueOrDefault() & num != null == (num2 != null)) && !this.25.1())
			{
				this.25.SetText(selectedRandomSeed.Value.ToString(1662.18));
			}
		}
		string text = this.25.GetText();
		if (text != this.26)
		{
			this.26 = text;
			if (randomEnabled)
			{
				1925.4(true, 1758.15(text), 1925.SelectedAngleSharpness);
			}
		}
	}

	// Token: 0x0600418B RID: 16779 RVA: 0x00197228 File Offset: 0x00195428
	private void Refresh()
	{
		bool randomEnabled = 1925.RandomEnabled;
		this.27 = true;
		this.20.22((double)this.12(), (double)this.13(), (double)this.14());
		this.20.2(!randomEnabled);
		for (int i = 0; i < this.20.13.Count; i++)
		{
			float num = (i == this.20.13.Count - 1) ? 0.5f : 1f;
			this.20.13[i].24(num * (randomEnabled ? 1f : 0.35f), 140, (1046)0);
		}
		this.27 = false;
		if (this.30)
		{
			int selectedRandomStrength = 1925.SelectedRandomStrength;
			this.22.SetText(selectedRandomStrength.ToString() + "%" + ((selectedRandomStrength == 100 && !this.31) ? " (lazer)" : string.Empty));
		}
		else
		{
			bool flag = Math.Abs(1925.SelectedAngleSharpness - 7f) < 0.05f;
			string text = 1925.SelectedAngleSharpness.ToString("0.0", 1662.18);
			this.22.SetText(flag ? (text + " (default)") : text);
		}
		float <<EMPTY_NAME>> = randomEnabled ? 1f : 0.35f;
		this.22.24(<<EMPTY_NAME>>, 140, (1046)0);
		this.21.24(<<EMPTY_NAME>>, 140, (1046)0);
		this.23.24(<<EMPTY_NAME>>, 140, (1046)0);
		this.25.SetEnabled(randomEnabled);
		foreach (1433 2 in this.25.2)
		{
			2.24(<<EMPTY_NAME>>, 140, (1046)0);
		}
		this.19.4.SetText(1758.16());
		this.19.4(1758.17());
	}

	// Token: 0x0600418C RID: 16780 RVA: 0x00197444 File Offset: 0x00195644
	protected override void Dispose(bool 1)
	{
		this.25.Dispose();
		base.Dispose(1);
	}

	// Token: 0x04002FD1 RID: 12241
	private const float 18 = 0.35f;

	// Token: 0x04002FD2 RID: 12242
	private readonly 1361 19;

	// Token: 0x04002FD3 RID: 12243
	private readonly 1429 20;

	// Token: 0x04002FD4 RID: 12244
	private readonly 1452 21;

	// Token: 0x04002FD5 RID: 12245
	private readonly 1452 22;

	// Token: 0x04002FD6 RID: 12246
	private readonly 1452 23;

	// Token: 0x04002FD7 RID: 12247
	private readonly 1452 24;

	// Token: 0x04002FD8 RID: 12248
	private readonly 1448 25;

	// Token: 0x04002FD9 RID: 12249
	private string 26;

	// Token: 0x04002FDA RID: 12250
	private bool 27;

	// Token: 0x04002FDB RID: 12251
	private bool 28;

	// Token: 0x04002FDC RID: 12252
	private bool 29;

	// Token: 0x04002FDD RID: 12253
	private readonly bool 30;

	// Token: 0x04002FDE RID: 12254
	private readonly bool 31;
}
