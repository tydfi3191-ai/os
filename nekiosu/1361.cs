using System;
using System.Collections.Generic;
using System.Threading;

// Token: 0x02000A7B RID: 2683
public sealed class 1361
{
	// Token: 0x06004A47 RID: 19015 RVA: 0x001D77A8 File Offset: 0x001D59A8
	internal 1361(string 1, 208 2, 208 3, float 4, 198 5, EventHandler 6, bool 7 = true, bool 8 = false, float? 9 = null, bool 10 = true)
	{
		this.4(5);
		if (6 != null)
		{
			this.2(6);
		}
		this.1 = new List<1433>();
		int num = (!8) ? 1 : -1;
		1452 11 = new 1452(13, (9 != null) ? 9.Value : (14f * 3.Y / 18f / (float)((13.IndexOf('\n') <= 0) ? 1 : 2)), 14, 4 + 0.002f, true, 198.White);
		11.67((1068)1);
		this.4 = 11;
		if (8)
		{
			this.4.41 = (1376)8;
		}
		this.4.49 = 1065.Centre;
		float x = this.4.GetTextSize().X;
		if (x > 3.X)
		{
			3.X = x;
		}
		this.4.7 += new 208(3.X * (float)num, 3.Y) / 2f;
		this.4.17 = this.4.7;
		this.4.UpdateOriginOffset();
		1433 12 = new 1433(7 ? 1455.2("button-left", (1416)3, null) : 1455.2("button-left", (1416)1, null), 8 ? ((1376)8) : ((1376)6), 1065.TopLeft, (1044)0, 14, 4, true, this.3, this);
		12.15 = 3.Y / ((float)12.34 * 0.625f);
		12.10 = true;
		12.3(delegate(object 1, EventArgs 2)
		{
			if (this.6 != null)
			{
				this.6(this, null);
			}
			if (this.5)
			{
				1226.24("click-short-confirm", 100, (1416)3, false);
			}
			this.1.ForEach(new Action<1433>(1361.1362.instance.1));
		});
		12.35(new EventHandler(this.3));
		12.37(delegate(object 1, EventArgs 2)
		{
			1662.89.Schedule(new 1189(this.8), true);
		});
		this.1.Add(12);
		float num2 = (float)this.1[0].35 * 0.625f * this.1[0].15;
		12 = new 1433(7 ? 1455.2("button-right", (1416)3, null) : 1455.2("button-right", (1416)1, null), 8 ? ((1376)8) : ((1376)6), 1065.TopLeft, (1044)0, 14 + (float)num * new 208(3.X - num2, 0f), 4, true, this.3, this);
		12.15 = 3.Y / ((float)12.34 * 0.625f);
		12.10 = true;
		12.3(delegate(object 1, EventArgs 2)
		{
			if (this.6 != null)
			{
				this.6(this, null);
			}
			if (this.5)
			{
				1226.24("click-short-confirm", 100, (1416)3, false);
			}
			this.1.ForEach(new Action<1433>(1361.1362.instance.1));
		});
		12.35(new EventHandler(this.3));
		12.37(delegate(object 1, EventArgs 2)
		{
			1662.89.Schedule(new 1189(this.8), true);
		});
		this.1.Add(12);
		12 = new 1433(7 ? 1455.2("button-middle", (1416)3, null) : 1455.2("button-middle", (1416)1, null), 8 ? ((1376)8) : ((1376)6), 1065.TopLeft, (1044)0, 14 + (float)num * new 208(num2, 0f), 4 + 0.001f, true, this.3, this);
		12.10 = true;
		12.3(delegate(object 1, EventArgs 2)
		{
			if (this.6 != null)
			{
				this.6(this, null);
			}
			if (this.5)
			{
				1226.24("click-short-confirm", 100, (1416)3, false);
			}
			this.1.ForEach(new Action<1433>(1361.1362.instance.1));
		});
		12.35(new EventHandler(this.3));
		12.37(delegate(object 1, EventArgs 2)
		{
			1662.89.Schedule(new 1189(this.8), true);
		});
		if (12.GetTexture() != null)
		{
			12.20 = new 208((3.X - num2 * 2f) / (float)12.GetTexture().3() * 1.6f, this.1[1].15);
		}
		this.1.Add(12);
		this.1.Add(this.4);
		this.1(10);
	}

	// Token: 0x06004A48 RID: 19016 RVA: 0x001D7B60 File Offset: 0x001D5D60
	public void 1(bool 1)
	{
		foreach (1433 2 in this.1)
		{
			if (!(2 is 1452))
			{
				2.11 = 1;
			}
		}
	}

	// Token: 0x06004A49 RID: 19017 RVA: 0x001D7BBC File Offset: 0x001D5DBC
	internal void 2(EventHandler 1)
	{
		EventHandler eventHandler = this.6;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, 1);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.6, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06004A4A RID: 19018 RVA: 0x001D7BF4 File Offset: 0x001D5DF4
	private void OnClick(object 1, EventArgs 2)
	{
		if (this.6 != null)
		{
			this.6(this, null);
		}
		if (this.5)
		{
			1226.24("click-short-confirm", 100, (1416)3, false);
		}
		this.1.ForEach(new Action<1433>(1361.1362.instance.1));
	}

	// Token: 0x06004A4B RID: 19019 RVA: 0x001D7C48 File Offset: 0x001D5E48
	private void 3(object 1, EventArgs 2)
	{
		if (!this.7 && this.8)
		{
			this.7 = true;
			this.1[0].39(this.2, 50, true, (1046)0);
			this.1[1].39(this.2, 50, true, (1046)0);
			this.1[2].39(this.2, 50, true, (1046)0);
			if (this.5)
			{
				1226.20(null, "click-short", 1f, false);
			}
		}
	}

	// Token: 0x06004A4C RID: 19020 RVA: 0x001D7CE4 File Offset: 0x001D5EE4
	public void Hide()
	{
		this.1.ForEach(new Action<1433>(1361.1362.instance.2));
	}

	// Token: 0x06004A4D RID: 19021 RVA: 0x001D7D01 File Offset: 0x001D5F01
	public void Show()
	{
		this.1.ForEach(delegate(1433 1)
		{
			if (!(1 is 1452))
			{
				1.10 = this.8;
			}
			1.FadeIn(50, (1046)0, 0);
		});
	}

	// Token: 0x06004A4E RID: 19022 RVA: 0x001D7D1A File Offset: 0x001D5F1A
	public void 4(198 1)
	{
		this.2 = 1;
		this.5();
	}

	// Token: 0x06004A4F RID: 19023 RVA: 0x001D7D2C File Offset: 0x001D5F2C
	public void 5()
	{
		198 <<EMPTY_NAME>> = this.8 ? this.2 : 198.Gray;
		this.3 = new 198((byte)Math.Max(0, (int)(<<EMPTY_NAME>>.R - 20)), (byte)Math.Max(0, (int)(<<EMPTY_NAME>>.G - 20)), (byte)Math.Max(0, (int)(<<EMPTY_NAME>>.B - 20)));
		if (this.1 != null && this.1.Count >= 3)
		{
			this.1[0].6 = this.3;
			this.1[1].6 = this.3;
			this.1[2].6 = this.3;
			this.1[3].6 = (this.8 ? 198.White : 198.LightGray);
		}
	}

	// Token: 0x06004A50 RID: 19024 RVA: 0x001D7E0C File Offset: 0x001D600C
	public void 6(string 1)
	{
		1361.1363 setTooltipClosure = new 1361.1363();
		setTooltipClosure.1 = 2;
		this.1.ForEach(delegate(1433 1)
		{
			1.52 = setTooltipClosure.1;
		});
	}

	// Token: 0x06004A51 RID: 19025 RVA: 0x001D7E50 File Offset: 0x001D6050
	internal void 7(bool 1)
	{
		if (this.8 != 1)
		{
			this.8 = 1;
			this.1[0].10 = (this.1[1].10 = (this.1[2].10 = this.8));
			this.5();
		}
	}

	// Token: 0x06004A52 RID: 19026 RVA: 0x001D7EB4 File Offset: 0x001D60B4
	private void 8()
	{
		if (this.8 && !this.1[0].IsHovered() && !this.1[1].IsHovered() && !this.1[2].IsHovered())
		{
			this.1[0].39(this.3, 50, false, (1046)0);
			this.1[1].39(this.3, 50, false, (1046)0);
			this.1[2].39(this.3, 50, false, (1046)0);
			this.7 = false;
		}
	}

	// Token: 0x04003760 RID: 14176
	internal List<1433> 1;

	// Token: 0x04003761 RID: 14177
	private 198 2;

	// Token: 0x04003762 RID: 14178
	private 198 3;

	// Token: 0x04003763 RID: 14179
	internal 1452 4;

	// Token: 0x04003764 RID: 14180
	public bool 5 = true;

	// Token: 0x04003765 RID: 14181
	private EventHandler 6;

	// Token: 0x04003766 RID: 14182
	private bool 7;

	// Token: 0x04003767 RID: 14183
	private bool 8 = true;

	// Token: 0x02000A7C RID: 2684
	[Serializable]
	public sealed class 1362
	{
		// Token: 0x06004A5A RID: 19034 RVA: 0x001D809C File Offset: 0x001D629C
		internal void 1(1433 1)
		{
			1.40(198.White, 400);
		}

		// Token: 0x06004A5B RID: 19035 RVA: 0x001D80AE File Offset: 0x001D62AE
		internal void 2(1433 1)
		{
			1.10 = false;
			1.16(50, (1046)0, 0);
		}

		// Token: 0x04003768 RID: 14184
		public static readonly 1361.1362 instance = new 1361.1362();

		// Token: 0x04003769 RID: 14185
		public static Action<1433> action;

		// Token: 0x0400376A RID: 14186
		public static Action<1433> action2;
	}

	// Token: 0x02000A7D RID: 2685
	public sealed class 1363
	{
		// Token: 0x0400376B RID: 14187
		public string 1;
	}
}
