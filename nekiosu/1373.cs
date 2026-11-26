using System;
using System.Collections.Generic;
using System.Threading;

// Token: 0x02000A8A RID: 2698
public sealed class 1373
{
	// Token: 0x06004AC2 RID: 19138 RVA: 0x001DA013 File Offset: 0x001D8213
	internal 1373(1436 1, string 2, 208 3) : this(1, 2, 3, 118f, 0.98f, false, false)
	{
	}

	// Token: 0x06004AC3 RID: 19139 RVA: 0x001DA02A File Offset: 0x001D822A
	internal 1373(1436 1, string 2, 208 3, bool 4) : this(1, 2, 3, 118f, 0.98f, 4, false)
	{
	}

	// Token: 0x06004AC4 RID: 19140 RVA: 0x001DA042 File Offset: 0x001D8242
	internal 1373(1436 1, string 2, 208 3, float 4, float 5) : this(1, 2, 3, 4, 5, false, false)
	{
	}

	// Token: 0x06004AC5 RID: 19141 RVA: 0x001DA054 File Offset: 0x001D8254
	internal 1373(1436 1, string 2, 208 3, float 4, float 5, bool 6, bool 7 = false)
	{
		this.6 = 8;
		this.16 = 4;
		this.14 = 6;
		this.4 = 7;
		this.12 = 3;
		this.17 = 5;
		this.14(0);
		this.10 = new 1452(9, 13f, 3, new 208(4 + 2f, 15f), 5 + 0.001f, true, 198.White, false);
		this.10.58(new 198(0, 0, 0, 128));
		this.10.78 = 210.GetOne() * 5f;
		this.10.75 = ((!this.4) ? ((1066)1) : ((1066)2));
		this.10.63(true);
		this.10.35(delegate(object 1, EventArgs 2)
		{
			1452 10 = 1 as 1452;
			if (10 != null)
			{
				if (10.8 is 198)
				{
					10.58(1045.1(10.57(), 0.1f));
				}
				else
				{
					10.58(this.11);
				}
				1226.20(null, "click-short", 1f, false);
				10.88 = true;
			}
		});
		this.10.37(delegate(object 1, EventArgs 2)
		{
			1452 10 = 1 as 1452;
			if (10 != null)
			{
				if (10.8 is 198)
				{
					10.58(1045.3(10.57(), 0.1f));
				}
				else if (10 == this.10)
				{
					10.58(new 198(0, 0, 0, 128));
				}
				else
				{
					10.58(1373.1);
				}
				10.88 = true;
			}
		});
		this.10.10 = true;
		this.10.3(new EventHandler(this.15));
		this.7.Add(this.10);
		this.9 = new 1386(1048.chevron_down, 14f, new 208(3.X + 4 - 8f, 3.Y + 8f))
		{
			2 = 5 + 0.002f
		};
		this.7.Add(this.9);
		if (8 != null)
		{
			8.14<1433>(this.7);
		}
	}

	// Token: 0x06004AC6 RID: 19142 RVA: 0x001DA214 File Offset: 0x001D8414
	internal void 1(EventHandler 1)
	{
		EventHandler eventHandler = this.2;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, 1);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.2, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06004AC7 RID: 19143 RVA: 0x001DA24C File Offset: 0x001D844C
	internal void 2(EventHandler 1)
	{
		EventHandler eventHandler = this.3;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, 1);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.3, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06004AC8 RID: 19144 RVA: 0x001DA281 File Offset: 0x001D8481
	internal bool 3()
	{
		return this.21;
	}

	// Token: 0x06004AC9 RID: 19145 RVA: 0x001DA289 File Offset: 0x001D8489
	private void 4(bool 1)
	{
		this.21 = 1;
	}

	// Token: 0x06004ACA RID: 19146 RVA: 0x001DA294 File Offset: 0x001D8494
	public void 5(bool 1)
	{
		if (this.15 != 1)
		{
			if (this.15)
			{
				this.8();
			}
			this.15 = 1;
			if (!this.15)
			{
				this.10.SetHovered(false);
			}
			this.10.10 = this.15;
			this.10.58(this.15 ? 198.Black : 198.DarkGray);
			this.10.88 = true;
		}
	}

	// Token: 0x06004ACB RID: 19147 RVA: 0x001DA310 File Offset: 0x001D8510
	private bool 6(object 1, EventArgs 2)
	{
		if (this.6.42)
		{
			this.17();
		}
		if (!1555.31)
		{
			return false;
		}
		using (List<1452>.Enumerator enumerator = this.8.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.IsHovered())
				{
					return false;
				}
			}
		}
		if (this.10.IsHovered())
		{
			return false;
		}
		this.8();
		this.22 = true;
		1535.40((1082)6, delegate(object 1, EventArgs 2)
		{
			this.22 = false;
			return false;
		}, 1545.Highest, (1559)3);
		return true;
	}

	// Token: 0x06004ACC RID: 19148 RVA: 0x001DA3B8 File Offset: 0x001D85B8
	private void 7()
	{
		if (this.3() || !this.15 || this.22)
		{
			return;
		}
		this.4(true);
		1535.40((1082)8, new 1081(this.6), 1545.Highest, (1559)2);
		1535.40((1082)6, new 1081(this.20), 1545.Highest, (1559)3);
		1226.20(null, "select-expand", 1f, false);
		if (this.8.Count > 0)
		{
			if (this.14)
			{
				this.8[0].78.X = 5f;
				this.8[0].78.Y = 5f;
				this.8[this.8.Count - 2].78.Z = 5f;
				this.8[this.8.Count - 2].78.W = 5f;
			}
			else
			{
				this.8[0].78.Z = 5f;
				this.8[0].78.W = 5f;
				this.8[this.8.Count - 2].78.X = 5f;
				this.8[this.8.Count - 2].78.Y = 5f;
			}
		}
		int num = 0;
		int num2 = (int)Math.Min(10.0, Math.Max(1.0, Math.Round(100.0 / (double)this.8.Count)));
		208 <<EMPTY_NAME>> = new 208(0f, 0f);
		foreach (1452 2 in this.8)
		{
			bool flag = 2 is 1386;
			if (!flag)
			{
				<<EMPTY_NAME>>.Y += (float)((!this.14) ? 1 : -1) * 2.GetTextSize().Y + (this.14 ? 0.5f : -0.5f);
			}
			int num3 = 1662.33 + num * num2;
			2.9(false);
			2.3.Clear();
			2.17 = this.10.17 + (flag ? new 208(6f, 9f) : 208.Zero);
			2.19(2.17 + <<EMPTY_NAME>>, ((num > 0) ? 200 : 0) + num * num2, (1046)22);
			2.3.Add(new 1445(1456.Fade, 0f, 1f, num3, num3 + 200, (1046)1));
			num++;
		}
		if (this.3 != null)
		{
			this.3(this, null);
		}
	}

	// Token: 0x06004ACD RID: 19149 RVA: 0x001DA6F0 File Offset: 0x001D88F0
	internal void 8()
	{
		if (!this.3())
		{
			return;
		}
		this.4(false);
		1535.41((1082)8, new 1081(this.6), 1545.Highest);
		int num = 0;
		foreach (1452 <<EMPTY_NAME>> in this.8)
		{
			bool flag = <<EMPTY_NAME>> is 1386;
			if (flag)
			{
				<<EMPTY_NAME>>.16(0, (1046)0, 0);
			}
			else
			{
				<<EMPTY_NAME>>.19(this.10.17 + (flag ? new 208(6f, 9f) : 208.Zero), 200 + num * 10, (1046)2);
				<<EMPTY_NAME>>.16(100 + num++ * 10, (1046)0, 0);
			}
		}
		if (this.3 != null)
		{
			this.3(this, null);
		}
		1662.89.2(new 1189(this.21), 100 + num * 10, false);
	}

	// Token: 0x06004ACE RID: 19150 RVA: 0x001DA7FC File Offset: 0x001D89FC
	internal 1433 9(1772 1)
	{
		return this.12(1.1, 1.2, 0, 1373.1, true);
	}

	// Token: 0x06004ACF RID: 19151 RVA: 0x001DA817 File Offset: 0x001D8A17
	internal 1433 10(string 1, object 2)
	{
		return this.12(1, 2, 0, 1373.1, true);
	}

	// Token: 0x06004AD0 RID: 19152 RVA: 0x001DA828 File Offset: 0x001D8A28
	internal 1433 11(string 1, object 2, 198 3)
	{
		return this.12(1, 2, 0, 3, true);
	}

	// Token: 0x06004AD1 RID: 19153 RVA: 0x001DA838 File Offset: 0x001D8A38
	internal 1433 12(string 1, object 2, int 3, 198 4, bool 5)
	{
		1452 6 = new 1452(9, this.10.65() - 1f, this.13, new 208(this.16 + 2f, 17f), this.17 + 0.003f, true, 198.TransparentWhite, true);
		6.75 = ((!this.4) ? ((1066)1) : ((1066)2));
		1386 7 = new 1386(1048.chevron_right, 10f, this.13 + new 208(6f, 9f));
		7.2 = this.17 + 0.004f;
		7.6 = 198.TransparentBlack;
		7.16 = 0f;
		7.63(false);
		1452 8 = 7;
		6.58(4);
		6.79 = new 208(12f, 3f);
		6.9(true);
		8.9(true);
		if (5)
		{
			6.10 = true;
			6.11 = true;
			if (10 != null)
			{
				6.3(new EventHandler(this.15));
				if (3 != 400)
				{
					6.35(delegate(object 1, EventArgs 2)
					{
						1452 11 = 1 as 1452;
						if (11 != null)
						{
							if (11.8 is 198)
							{
								11.58(1045.1(11.57(), 0.1f));
							}
							else
							{
								11.58(this.11);
							}
							1226.20(null, "click-short", 1f, false);
							11.88 = true;
						}
					});
					6.37(delegate(object 1, EventArgs 2)
					{
						1452 11 = 1 as 1452;
						if (11 != null)
						{
							if (11.8 is 198)
							{
								11.58(1045.3(11.57(), 0.1f));
							}
							else if (11 == this.10)
							{
								11.58(new 198(0, 0, 0, 128));
							}
							else
							{
								11.58(1373.1);
							}
							11.88 = true;
						}
					});
				}
			}
			6.8 = 10;
			6.9 = 3;
			6.45 = -1000f;
		}
		this.8.Add(6);
		this.8.Add(8);
		this.7.Add(6);
		this.7.Add(8);
		if (this.6 != null)
		{
			this.6.12(6);
			this.6.12(8);
		}
		return 6;
	}

	// Token: 0x06004AD2 RID: 19154 RVA: 0x001DA9E0 File Offset: 0x001D8BE0
	internal void 13()
	{
		while (this.8.Count > 0)
		{
			1452 <<EMPTY_NAME>> = this.8[0];
			this.8.Remove(<<EMPTY_NAME>>);
			this.7.Remove(<<EMPTY_NAME>>);
			if (this.6 != null)
			{
				this.6.Remove(<<EMPTY_NAME>>);
			}
			<<EMPTY_NAME>>.Dispose();
		}
		this.14(0);
		this.20 = 0;
		this.18 = null;
		this.19 = null;
	}

	// Token: 0x06004AD3 RID: 19155 RVA: 0x001DAA5C File Offset: 0x001D8C5C
	private void 14(int 1)
	{
		if (this.14)
		{
			this.13 = this.12 + new 208(this.16 * (float)1, 2f);
			return;
		}
		this.13 = this.12 + new 208(this.16 * (float)1, 17f);
	}

	// Token: 0x06004AD4 RID: 19156 RVA: 0x001DAABA File Offset: 0x001D8CBA
	private void 15(object 1, EventArgs 2)
	{
		if (1 == this.10 || this.3())
		{
			this.16(1, false);
		}
	}

	// Token: 0x06004AD5 RID: 19157 RVA: 0x001DAAD8 File Offset: 0x001D8CD8
	private void 16(object 1, bool 2)
	{
		if (1 == null)
		{
			1 = this.10;
		}
		1452 3 = (1452)1;
		if (3 == this.10)
		{
			if (this.3())
			{
				this.8();
				return;
			}
			this.7();
			return;
		}
		else
		{
			this.8();
			if (3.GetText() != this.10.GetText())
			{
				this.10.88 = true;
			}
			if (this.23 != null && 3 != this.10)
			{
				this.23.54(false);
				this.23.88 = true;
			}
			if (3 != null)
			{
				3.54(true);
				this.10.8 = 3.8;
			}
			if (3.8 == null)
			{
				return;
			}
			this.18 = 3.8;
			this.19 = 3.GetText();
			this.20 = 3.9;
			if (3 != this.10)
			{
				this.23 = 3;
			}
			this.10.SetText(string.IsNullOrEmpty(3.GetText()) ? " " : 3.GetText());
			if (!2)
			{
				1226.20(null, "click-short-confirm", 1f, false);
			}
			if (3.8 is 198)
			{
				198 4 = (198)3.8;
				if (4.A < 1)
				{
					this.10.58(198.Black);
				}
				else
				{
					this.10.58(4);
				}
			}
			if (3.8 != null && 3 != this.10 && !2 && this.2 != null)
			{
				this.2(3.8, null);
			}
			return;
		}
	}

	// Token: 0x06004AD6 RID: 19158 RVA: 0x001DAC70 File Offset: 0x001D8E70
	public void 17()
	{
		1535.41((1082)8, new 1081(this.6), 1545.Highest);
	}

	// Token: 0x06004AD7 RID: 19159 RVA: 0x001DAC88 File Offset: 0x001D8E88
	public bool 18(object 1, bool 2)
	{
		1433 3 = this.19(1);
		if (3 != null)
		{
			this.16(3, 2);
			return true;
		}
		return false;
	}

	// Token: 0x06004AD8 RID: 19160 RVA: 0x001DACAC File Offset: 0x001D8EAC
	public 1433 19(object 1)
	{
		foreach (1452 2 in this.8)
		{
			if (2.8 != null && 2.8.Equals(1))
			{
				return 2;
			}
		}
		return null;
	}

	// Token: 0x06004AD9 RID: 19161 RVA: 0x001DAD18 File Offset: 0x001D8F18
	private bool 20(object 1, EventArgs 2)
	{
		if (!this.3())
		{
			return false;
		}
		if (this.6 != null && this.6.23 != null && this.6.23 != this.10)
		{
			this.6.23.1(true);
			return true;
		}
		return false;
	}

	// Token: 0x06004ADA RID: 19162 RVA: 0x001DAD6C File Offset: 0x001D8F6C
	private void 21()
	{
		if (!this.3())
		{
			this.8.ForEach(delegate(1452 1)
			{
				1.9(true);
			});
		}
	}

	// Token: 0x040037C4 RID: 14276
	private static 198 1 = new 198(0, 0, 0, 240);

	// Token: 0x040037C5 RID: 14277
	private EventHandler 2;

	// Token: 0x040037C6 RID: 14278
	private EventHandler 3;

	// Token: 0x040037C7 RID: 14279
	internal bool 4;

	// Token: 0x040037C8 RID: 14280
	internal int 5;

	// Token: 0x040037C9 RID: 14281
	internal 1436 6;

	// Token: 0x040037CA RID: 14282
	internal List<1433> 7 = new List<1433>();

	// Token: 0x040037CB RID: 14283
	internal List<1452> 8 = new List<1452>();

	// Token: 0x040037CC RID: 14284
	private 1386 9;

	// Token: 0x040037CD RID: 14285
	internal 1452 10;

	// Token: 0x040037CE RID: 14286
	internal 198 11 = 2630.15;

	// Token: 0x040037CF RID: 14287
	private 208 12;

	// Token: 0x040037D0 RID: 14288
	private 208 13;

	// Token: 0x040037D1 RID: 14289
	private bool 14;

	// Token: 0x040037D2 RID: 14290
	private bool 15 = true;

	// Token: 0x040037D3 RID: 14291
	private float 16;

	// Token: 0x040037D4 RID: 14292
	private float 17;

	// Token: 0x040037D5 RID: 14293
	internal object 18;

	// Token: 0x040037D6 RID: 14294
	internal string 19;

	// Token: 0x040037D7 RID: 14295
	internal int 20;

	// Token: 0x040037D8 RID: 14296
	private bool 21;

	// Token: 0x040037D9 RID: 14297
	private bool 22;

	// Token: 0x040037DA RID: 14298
	private 1452 23;

	// Token: 0x02000A8B RID: 2699
	[Serializable]
	public sealed class 1374
	{
		// Token: 0x040037DB RID: 14299
		public static readonly 1373.1374 instance = new 1373.1374();

		// Token: 0x040037DC RID: 14300
		public static Action<1452> action;
	}
}
