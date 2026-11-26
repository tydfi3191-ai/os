using System;
using System.Collections.Generic;
using System.Threading;

// Token: 0x02000B18 RID: 2840
public class 1498
{
	// Token: 0x06004ED8 RID: 20184 RVA: 0x001F2890 File Offset: 0x001F0A90
	internal 1498(1436 1, int 2, 208 3, float 4, bool 5, 198 6, int 7 = 0, bool 8 = false)
	{
		this.9 = 7;
		this.11 = 1;
		this.1 = 4;
		this.10 = 5;
		this.8 = 2;
		this.4 = 3;
		this.15 = 8;
		this.13 = 6;
		this.14 = new 198((byte)Math.Min(255f, (float)this.13.R * 1.8f), (byte)Math.Min(255f, (float)this.13.G * 1.8f), (byte)Math.Min(255f, (float)this.13.B * 1.8f));
		this.2 = new 1445(this.13, new 198((byte)Math.Min(255, (int)(this.13.R + 20)), (byte)Math.Min(255, (int)(this.13.G + 50)), (byte)Math.Min(255, (int)(this.13.B + 50))), 0, 80);
		this.3 = new 1445(this.14, new 198((byte)Math.Min(255, (int)(this.14.R + 20)), (byte)Math.Min(255, (int)(this.14.G + 50)), (byte)Math.Min(255, (int)(this.14.B + 50))), 0, 80);
	}

	// Token: 0x06004ED9 RID: 20185 RVA: 0x001F2A34 File Offset: 0x001F0C34
	internal void 1(EventHandler 1)
	{
		EventHandler eventHandler = this.17;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, 1);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.17, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06004EDA RID: 20186 RVA: 0x001F2A69 File Offset: 0x001F0C69
	internal virtual 1496 AddTab(string 1, object 2, bool 3)
	{
		return this.AddTab(1, 2, (!3) ? this.16.Count : 0);
	}

	// Token: 0x06004EDB RID: 20187 RVA: 0x001F2A84 File Offset: 0x001F0C84
	internal virtual 1496 AddTab(string 1, object 2, int 3)
	{
		1498.1501 4 = new 1498.1501();
		4.1 = 2;
		if (this.16.Find(new Predicate<1496>(4.1)) != null)
		{
			return null;
		}
		208 5 = new 208(this.4.X + (float)(this.16.Count % this.8 * this.9) + (float)(this.16.Count / this.8 * 10 * ((!this.15) ? 1 : -1)), this.4.Y + 6f - (float)(14 * (1 + this.16.Count / this.8)));
		float num = this.1 - (float)this.16.Count * 0.0002f - (float)(this.16.Count / this.8) * 0.0001f;
		1496 6 = this.CreateTab(1, 4.1, 5, num);
		6.1(new EventHandler(this.OnTabClicked));
		if (this.5 == null)
		{
			this.5 = 6;
		}
		this.12.AddRange(6.4);
		this.11.14<1433>(6.4);
		if (3 < 0)
		{
			3 = 0;
		}
		this.16.Insert((3 > this.16.Count) ? this.16.Count : 3, 6);
		this.Layout();
		return 6;
	}

	// Token: 0x06004EDC RID: 20188 RVA: 0x001F2BF2 File Offset: 0x001F0DF2
	protected virtual 1496 CreateTab(string 1, object 2, 208 3, float 4)
	{
		return new 1496(1, 2, 3, 4, this.6, this.10, this.2, this.19);
	}

	// Token: 0x06004EDD RID: 20189 RVA: 0x001F2C16 File Offset: 0x001F0E16
	internal void 2(int 1)
	{
		this.8 = 1;
		this.Layout();
	}

	// Token: 0x06004EDE RID: 20190 RVA: 0x001F2C28 File Offset: 0x001F0E28
	internal virtual void Layout()
	{
		for (int i = 0; i < this.16.Count; i++)
		{
			1496 <<EMPTY_NAME>> = this.16[i];
			208 2 = new 208(this.4.X + (float)(i % this.8 * 74 * ((!this.15) ? 1 : -1)) + (float)(i / this.8 % 2 * this.9), this.4.Y + 6f - 14f - (float)(this.18 * (i / this.8)));
			float num = this.1 - (float)i * 0.0002f - (float)(i / this.8) * 0.0001f;
			<<EMPTY_NAME>>.4[0].45 = (float)((int)(-100f + num * 100f));
			for (int j = 0; j < <<EMPTY_NAME>>.4.Count; j++)
			{
				1433 3 = <<EMPTY_NAME>>.4[j];
				3.7 = 2;
				3.19(2, 300, (1046)27);
				3.2 = num + 0.0001f * (float)j + ((this.7 == <<EMPTY_NAME>>) ? 0.001f : 0f);
			}
		}
		this.11.13();
	}

	// Token: 0x06004EDF RID: 20191 RVA: 0x001F2D73 File Offset: 0x001F0F73
	internal 1496 3(object 1)
	{
		if (1 == null || 1 is 1493)
		{
			return null;
		}
		return this.4(1, false, false);
	}

	// Token: 0x06004EE0 RID: 20192 RVA: 0x001F2D8C File Offset: 0x001F0F8C
	internal 1496 4(object 1, bool 2, bool 3)
	{
		1496 4 = this.5(1);
		if (4 == null && !3)
		{
			return null;
		}
		this.6(4, 2);
		return 4;
	}

	// Token: 0x06004EE1 RID: 20193 RVA: 0x001F2DB4 File Offset: 0x001F0FB4
	internal 1496 5(object 1)
	{
		1498.1500 2 = new 1498.1500();
		2.1 = 1;
		return this.16.Find(new Predicate<1496>(2.1));
	}

	// Token: 0x06004EE2 RID: 20194 RVA: 0x001F2DE8 File Offset: 0x001F0FE8
	protected virtual void OnTabClicked(object 1, EventArgs 2)
	{
		1226.20(null, "click-short-confirm", 1f, false);
		this.6((1496)1, false);
	}

	// Token: 0x06004EE3 RID: 20195 RVA: 0x001F2E1C File Offset: 0x001F101C
	internal void 6(1496 1, bool 2)
	{
		if (this.7 == 5 || (5 != null && !5.IsSelectable()))
		{
			return;
		}
		1496 3 = this.7;
		this.7 = 5;
		foreach (1496 4 in this.16)
		{
			if (4 == this.7)
			{
				4.1.39(198.White, 100, false, (1046)0);
				4.1.42 = null;
				4.5 = false;
				4.2.39(198.Black, 20, false, (1046)0);
				4.2.63(false);
				4.2.88 = true;
				4.4.ForEach(delegate(1433 1)
				{
					1.2 += 0.001f;
				});
				this.11.20<1433>(4.4);
				this.11.14<1433>(4.4);
			}
			else if (4 == 3)
			{
				4.1.42 = this.2;
				4.1.39(this.13, 20, false, (1046)0);
				4.2.39(198.White, 20, false, (1046)0);
				4.2.63(true);
				4.2.88 = true;
				4.4.ForEach(delegate(1433 1)
				{
					1.2 -= 0.001f;
				});
				this.11.20<1433>(4.4);
				this.11.14<1433>(4.4);
			}
		}
		if (!2 && this.17 != null)
		{
			this.17((this.7 != null) ? this.7.3 : null, null);
		}
	}

	// Token: 0x06004EE4 RID: 20196 RVA: 0x001F3024 File Offset: 0x001F1224
	public void 7(object 1)
	{
		this.RemoveTab(this.5(1));
	}

	// Token: 0x06004EE5 RID: 20197 RVA: 0x001F3034 File Offset: 0x001F1234
	public virtual void RemoveTab(1496 1)
	{
		if (1 == null)
		{
			return;
		}
		int num = this.16.IndexOf(1);
		if (num < 0 || num >= this.16.Count)
		{
			return;
		}
		this.16.Remove(1);
		1.4.ForEach(new Action<1433>(this.9));
		if (this.7 == 1 && this.16.Count > 0)
		{
			if (num < this.16.Count && this.16[num].IsSelectable())
			{
				this.6(this.16[num], false);
			}
			else if (num > 0)
			{
				this.6(this.16[num - 1], false);
			}
		}
		this.Layout();
	}

	// Token: 0x06004EE6 RID: 20198 RVA: 0x001F30F8 File Offset: 0x001F12F8
	public void 8(object 1)
	{
		1496 2 = this.5(1);
		if (2 != null && 2 != this.7)
		{
			2.5 = true;
			2.1.39(this.14, 100, false, (1046)0);
			2.1.42 = this.3;
		}
	}

	// Token: 0x06004EE7 RID: 20199 RVA: 0x001F3147 File Offset: 0x001F1347
	private void 9(1433 1)
	{
		this.12.Remove(1);
		1.5 = false;
		1.16(200, (1046)0, 0);
	}

	// Token: 0x04003ACC RID: 15052
	private readonly float 1;

	// Token: 0x04003ACD RID: 15053
	protected readonly 1445 2;

	// Token: 0x04003ACE RID: 15054
	private readonly 1445 3;

	// Token: 0x04003ACF RID: 15055
	internal 208 4;

	// Token: 0x04003AD0 RID: 15056
	protected 1496 5;

	// Token: 0x04003AD1 RID: 15057
	internal bool 6;

	// Token: 0x04003AD2 RID: 15058
	internal 1496 7;

	// Token: 0x04003AD3 RID: 15059
	internal int 8;

	// Token: 0x04003AD4 RID: 15060
	protected int 9;

	// Token: 0x04003AD5 RID: 15061
	internal bool 10;

	// Token: 0x04003AD6 RID: 15062
	internal 1436 11;

	// Token: 0x04003AD7 RID: 15063
	internal List<1433> 12 = new List<1433>();

	// Token: 0x04003AD8 RID: 15064
	internal 198 13;

	// Token: 0x04003AD9 RID: 15065
	internal 198 14;

	// Token: 0x04003ADA RID: 15066
	internal bool 15;

	// Token: 0x04003ADB RID: 15067
	internal List<1496> 16 = new List<1496>();

	// Token: 0x04003ADC RID: 15068
	private EventHandler 17;

	// Token: 0x04003ADD RID: 15069
	protected int 18 = 13;

	// Token: 0x04003ADE RID: 15070
	internal float 19 = 1f;

	// Token: 0x02000B19 RID: 2841
	public sealed class 1501
	{
		// Token: 0x06004EE8 RID: 20200 RVA: 0x001F316A File Offset: 0x001F136A
		internal bool 1(1496 1)
		{
			return 1.3 == this.1;
		}

		// Token: 0x04003ADF RID: 15071
		public object 1;
	}

	// Token: 0x02000B1A RID: 2842
	[Serializable]
	public sealed class 1499
	{
		// Token: 0x04003AE0 RID: 15072
		public static readonly 1498.1499 tabStripCallbacks = new 1498.1499();

		// Token: 0x04003AE1 RID: 15073
		public static Action<1433> action;

		// Token: 0x04003AE2 RID: 15074
		public static Action<1433> action2;
	}

	// Token: 0x02000B1B RID: 2843
	public sealed class 1500
	{
		// Token: 0x06004EEC RID: 20204 RVA: 0x001F3186 File Offset: 0x001F1386
		internal bool 1(1496 1)
		{
			return this.1.Equals(1.3);
		}

		// Token: 0x04003AE3 RID: 15075
		public object 1;
	}
}
