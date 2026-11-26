using System;

// Token: 0x020008F3 RID: 2291
public sealed class 1755 : 1689
{
	// Token: 0x0600414F RID: 16719 RVA: 0x00195BFC File Offset: 0x00193DFC
	public 1755() : base("Pitch", true)
	{
		float num = (float)1662.70.1() / 2f;
		this.7.12(new 1452("Change the music's pitch.", 14f, new 208(0f, this.3 - 30f), 208.Zero, 0.94f, true, 198.LightGray, true)
		{
			41 = (1376)7,
			49 = 1065.Centre
		});
		1452 <<EMPTY_NAME>> = new 1452("Semitones", 16f, new 208(num - 230f, this.3), 0.94f, true, 198.White);
		<<EMPTY_NAME>>.49 = 1065.CentreLeft;
		this.7.12(<<EMPTY_NAME>>);
		this.19 = new 1429(this.7, -12.0, 12.0, 1933.Semitones, new 208(num - 100f, this.3), 200);
		this.19.21 = 0.5;
		this.17.Add(this.19);
		this.19.18 = delegate(bool 1)
		{
			if (!this.22 && 1933.Enabled)
			{
				1933.2(this.19.7);
				this.Refresh();
			}
		};
		this.20 = new 1452(string.Empty, 16f, new 208(num + 115f, this.3), 0.94f, true, 198.White);
		this.20.49 = 1065.CentreLeft;
		this.7.12(this.20);
		this.3 += 45f;
		this.21 = base.7(1755.12(), 1755.13(), delegate(object 1, EventArgs 2)
		{
			1933.1(!1933.Enabled);
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

	// Token: 0x06004150 RID: 16720 RVA: 0x00195DF1 File Offset: 0x00193FF1
	private static string 12()
	{
		if (!1933.Enabled)
		{
			return "Enable Pitch";
		}
		return "Disable Pitch";
	}

	// Token: 0x06004151 RID: 16721 RVA: 0x00195E05 File Offset: 0x00194005
	private static 198 13()
	{
		if (!1933.Enabled)
		{
			return 198.YellowGreen;
		}
		return 198.OrangeRed;
	}

	// Token: 0x06004152 RID: 16722 RVA: 0x00195E19 File Offset: 0x00194019
	internal override void OnShown()
	{
		base.OnShown();
		this.Refresh();
	}

	// Token: 0x06004153 RID: 16723 RVA: 0x00195E28 File Offset: 0x00194028
	public override void Update()
	{
		base.Update();
		bool flag = 1555.2() == 199.Pressed;
		if (!flag || !this.4 || !1933.Enabled)
		{
			this.23 = false;
		}
		else if (!this.24)
		{
			this.23 = this.19.25();
		}
		if (this.23)
		{
			this.19.27();
		}
		this.24 = flag;
	}

	// Token: 0x06004154 RID: 16724 RVA: 0x00195E94 File Offset: 0x00194094
	internal override bool OnKeyDown(200 1)
	{
		if ((1 == 200.Left || 1 == 200.Right) && 1933.Enabled)
		{
			1933.2(1933.Semitones + ((1 == 200.Right) ? 0.5 : -0.5));
			this.Refresh();
			return true;
		}
		return base.OnKeyDown(1);
	}

	// Token: 0x06004155 RID: 16725 RVA: 0x00195EE8 File Offset: 0x001940E8
	private void Refresh()
	{
		bool enabled = 1933.Enabled;
		this.22 = true;
		this.19.22(-12.0, 12.0, 1933.Semitones);
		this.19.2(!enabled);
		for (int i = 0; i < this.19.13.Count; i++)
		{
			float num = (i == this.19.13.Count - 1) ? 0.5f : 1f;
			this.19.13[i].24(num * (enabled ? 1f : 0.3f), 140, (1046)0);
		}
		this.22 = false;
		this.20.SetText(1933.3(1933.Semitones));
		this.20.24(enabled ? 1f : 0.3f, 140, (1046)0);
		this.21.4.SetText(1755.12());
		this.21.4(1755.13());
	}

	// Token: 0x04002FB8 RID: 12216
	private const float 18 = 0.3f;

	// Token: 0x04002FB9 RID: 12217
	private readonly 1429 19;

	// Token: 0x04002FBA RID: 12218
	private readonly 1452 20;

	// Token: 0x04002FBB RID: 12219
	private readonly 1361 21;

	// Token: 0x04002FBC RID: 12220
	private bool 22;

	// Token: 0x04002FBD RID: 12221
	private bool 23;

	// Token: 0x04002FBE RID: 12222
	private bool 24;
}
