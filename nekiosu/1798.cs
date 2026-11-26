using System;
using System.Threading;

// Token: 0x020008A7 RID: 2215
public sealed class 1798 : 1474
{
	// Token: 0x06003F59 RID: 16217 RVA: 0x001890C0 File Offset: 0x001872C0
	internal 1798(1318 1, string 2, 208 3, 208 4, float 5, bool 6, EventHandler 7, EventHandler 8) : base(1662.11)
	{
		this.9(false);
		this.15 = 13;
		13.SubscribeChanged(8);
		this.2(7);
		this.3(8);
		this.18 = 5;
		this.3 = new 1433(1455.2("volume-circle-bg", (1416)1, null), (1376)14, 1065.Centre, (1044)0, 3, 0.968f, true, this.6, null);
		this.3.10 = true;
		this.3.35(new EventHandler(this.6));
		this.3.3(new EventHandler(this.4));
		this.8.12(this.3);
		this.4 = new 1433(1455.2("volume-circle-bg-max", (1416)1, null), (1376)14, 1065.Centre, (1044)0, 3, 0.97f, true, 198.TransparentWhite, null);
		this.8.12(this.4);
		1436 9 = this.8;
		1368 10 = new 1368(true)
		{
			28 = 50f,
			29 = 8f,
			2 = 0.971f
		};
		1368 11 = 10;
		this.11 = 10;
		9.12(11);
		this.7 = new 1452(string.Empty, 14f, 3, 0.991f, true, 198.White)
		{
			41 = (1376)14,
			49 = 1065.Centre
		};
		this.9.12(this.7);
		1452 12 = new 1452(2, 12f, new 208(3.X + 36f * 5, 3.Y) - 4, 0.991f, true, 198.White)
		{
			41 = (1376)14,
			49 = 1065.CentreRight
		};
		this.10.12(12);
		this.9.28.ForEach(new Action<1371>(1798.1799.volumeBarCallbacks.1));
		this.8.28.ForEach(new Action<1371>(1798.1799.volumeBarCallbacks.2));
		this.10.28.ForEach(delegate(1371 1)
		{
			1.16 = 0f;
		});
		this.1(6);
	}

	// Token: 0x06003F5A RID: 16218 RVA: 0x0018935C File Offset: 0x0018755C
	internal void 1(bool 1)
	{
		if (2 == this.14 && this.13 != 0f)
		{
			return;
		}
		this.14 = 2;
		if (this.14)
		{
			this.3.39(this.5, 100, false, (1046)0);
			this.13 = 1f;
		}
		else
		{
			this.3.39(this.6, 100, false, (1046)0);
			this.13 = 0.95f;
		}
		if (this.8())
		{
			this.8.28.ForEach(new Action<1371>(this.14));
			this.9.28.ForEach(delegate(1371 1)
			{
				1.25(this.13 * this.18, 600, (1046)25);
			});
		}
	}

	// Token: 0x06003F5B RID: 16219 RVA: 0x00189414 File Offset: 0x00187614
	private void 2(EventHandler 1)
	{
		EventHandler eventHandler = this.16;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, 1);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.16, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06003F5C RID: 16220 RVA: 0x0018944C File Offset: 0x0018764C
	private void 3(EventHandler 1)
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

	// Token: 0x06003F5D RID: 16221 RVA: 0x00189481 File Offset: 0x00187681
	private void 4(object 1, EventArgs 2)
	{
		this.19 = 1555.19().Y;
		1535.40((1082)3, new 1081(this.5), 1545.Highest, (1559)2);
		1535.40((1082)6, new 1081(this.15), 1545.Highest, (1559)3);
	}

	// Token: 0x06003F5E RID: 16222 RVA: 0x001894BC File Offset: 0x001876BC
	private bool 5(object 1, EventArgs 2)
	{
		float y = 1555.19().Y;
		float num = this.19 - y;
		EventHandler eventHandler = this.17;
		if (eventHandler != null)
		{
			eventHandler(this, null);
		}
		if (Math.Abs(num) < 1f)
		{
			return true;
		}
		this.12((int)Math.Round((double)num));
		this.19 = y;
		return true;
	}

	// Token: 0x06003F5F RID: 16223 RVA: 0x00189515 File Offset: 0x00187715
	private void 6(object 1, EventArgs 2)
	{
		EventHandler eventHandler = this.16;
		if (eventHandler == null)
		{
			return;
		}
		eventHandler(this, null);
	}

	// Token: 0x06003F60 RID: 16224 RVA: 0x00189529 File Offset: 0x00187729
	internal bool 7()
	{
		return this.8() && this.3.IsHovered();
	}

	// Token: 0x06003F61 RID: 16225 RVA: 0x00189540 File Offset: 0x00187740
	internal bool 8()
	{
		return this.20;
	}

	// Token: 0x06003F62 RID: 16226 RVA: 0x00189548 File Offset: 0x00187748
	internal void 9(bool 1)
	{
		if (2)
		{
			this.12 = 1662.33;
		}
		if (2 == this.20)
		{
			return;
		}
		this.20 = 2;
		if (2)
		{
			this.8.28.ForEach(new Action<1371>(this.16));
			this.9.28.ForEach(new Action<1371>(this.17));
			this.4.9(this.15.6() != 100);
			this.10.28.ForEach(new Action<1371>(1798.1799.volumeBarCallbacks.3));
			this.11.31 = 0f;
			return;
		}
		this.8.28.ForEach(delegate(1371 1)
		{
			1.16(200, (1046)0, 0);
			1.25(0.6f * this.13 * this.18, 1000, (1046)1);
		});
		this.9.28.ForEach(new Action<1371>(this.18));
		this.10.28.ForEach(new Action<1371>(1798.1799.volumeBarCallbacks.4));
		this.11.31 = 0f;
	}

	// Token: 0x06003F63 RID: 16227 RVA: 0x00189668 File Offset: 0x00187868
	internal float 10()
	{
		return this.8.28[0].16;
	}

	// Token: 0x06003F64 RID: 16228 RVA: 0x00189680 File Offset: 0x00187880
	public override void Update()
	{
		this.3.10 = (!2486.14 || 2486.83);
		if (this.8() && (float)(1662.33 - this.12) > 1000f)
		{
			this.9(false);
		}
		if (this.8())
		{
			if (this.3.16 > 0.98f)
			{
				float num = (float)this.15.6() / 100f;
				if (this.11.31 != num)
				{
					float num2 = this.11.31 - num;
					if ((double)Math.Abs(num2) < 0.0001)
					{
						this.11.31 = num;
					}
					else
					{
						this.11.31 = 1052.19(num + num2 * (float)Math.Pow(0.99, 1662.82), 0f, 1f);
					}
				}
				this.7.SetText(Math.Round((double)(this.11.31 * 100f)).ToString() + "%");
			}
		}
		else if (this.7.16 == 0f)
		{
			this.7.SetText(string.Empty);
		}
		base.Update();
	}

	// Token: 0x06003F65 RID: 16229 RVA: 0x001897CC File Offset: 0x001879CC
	public override void Draw()
	{
		this.11.16 = (float)Math.Pow((double)this.3.16, 8.0);
		if (this.11.16 > 0f)
		{
			this.11.15 = this.3.15;
			this.11.17 = new 208((float)1662.70.1 / 1662.70.3(), (float)1662.70.2 / 1662.70.3()) - this.3.17;
		}
		this.8.22();
		this.9.22();
		this.10.22();
		base.Draw();
	}

	// Token: 0x06003F66 RID: 16230 RVA: 0x0018989D File Offset: 0x00187A9D
	internal void 11()
	{
		this.8.Dispose();
		this.9.Dispose();
		this.10.Dispose();
	}

	// Token: 0x06003F67 RID: 16231 RVA: 0x001898C0 File Offset: 0x00187AC0
	internal void 12(int 1)
	{
		this.13(this.15.6() + 1);
	}

	// Token: 0x06003F68 RID: 16232 RVA: 0x001898D8 File Offset: 0x00187AD8
	internal void 13(int 1)
	{
		if (1 != this.15.6())
		{
			this.9(true);
			int num = this.15.6();
			this.15.7(1);
			if (this.15.6() == 100)
			{
				this.4.9(false);
				this.4.FadeIn(150, (1046)0, 0);
			}
			else
			{
				this.4.16(150, (1046)0, 0);
			}
			1226.20(null, "sliderbar", 1.1f - (0.5f - (float)this.15.6() / 100f) * 0.15f * (float)((this.15.6() != num) ? 1 : 4), false);
		}
	}

	// Token: 0x06003F69 RID: 16233 RVA: 0x001899A2 File Offset: 0x00187BA2
	private void 14(1371 1)
	{
		1.25(this.13 * this.18, 600, (1046)25);
	}

	// Token: 0x06003F6A RID: 16234 RVA: 0x001899BF File Offset: 0x00187BBF
	private bool 15(object 1, EventArgs 2)
	{
		1535.41((1082)3, new 1081(this.5), 1545.Highest);
		return false;
	}

	// Token: 0x06003F6B RID: 16235 RVA: 0x001899D5 File Offset: 0x00187BD5
	private void 16(1371 1)
	{
		1.FadeIn(80, (1046)0, 0);
		1.25(this.13 * this.18, 600, (1046)25);
	}

	// Token: 0x06003F6C RID: 16236 RVA: 0x001899FC File Offset: 0x00187BFC
	private void 17(1371 1)
	{
		1.FadeIn(150, (1046)0, 0);
		1.25(this.13 * this.18, 600, (1046)25);
	}

	// Token: 0x06003F6D RID: 16237 RVA: 0x00189A26 File Offset: 0x00187C26
	private void 18(1371 1)
	{
		1.16(50, (1046)0, 0);
		1.25(0.6f * this.13 * this.18, 1000, (1046)1);
	}

	// Token: 0x04002E5D RID: 11869
	private readonly 1433 3;

	// Token: 0x04002E5E RID: 11870
	private readonly 1433 4;

	// Token: 0x04002E5F RID: 11871
	private 198 5 = 198.White;

	// Token: 0x04002E60 RID: 11872
	private 198 6 = new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue, 80);

	// Token: 0x04002E61 RID: 11873
	private 1452 7;

	// Token: 0x04002E62 RID: 11874
	private 1436 8 = new 1436(true)
	{
		47 = true
	};

	// Token: 0x04002E63 RID: 11875
	private 1436 9 = new 1436(true)
	{
		47 = true
	};

	// Token: 0x04002E64 RID: 11876
	private 1436 10 = new 1436(true)
	{
		47 = true
	};

	// Token: 0x04002E65 RID: 11877
	private 1368 11;

	// Token: 0x04002E66 RID: 11878
	private int 12;

	// Token: 0x04002E67 RID: 11879
	private float 13;

	// Token: 0x04002E68 RID: 11880
	private bool 14;

	// Token: 0x04002E69 RID: 11881
	private 1318 15;

	// Token: 0x04002E6A RID: 11882
	private EventHandler 16;

	// Token: 0x04002E6B RID: 11883
	private EventHandler 17;

	// Token: 0x04002E6C RID: 11884
	private float 18;

	// Token: 0x04002E6D RID: 11885
	private float 19;

	// Token: 0x04002E6E RID: 11886
	private bool 20;

	// Token: 0x020008A8 RID: 2216
	[Serializable]
	public sealed class 1799
	{
		// Token: 0x06003F70 RID: 16240 RVA: 0x00188354 File Offset: 0x00186554
		internal void 1(1371 1)
		{
			1.16 = 0f;
		}

		// Token: 0x06003F71 RID: 16241 RVA: 0x00188354 File Offset: 0x00186554
		internal void 2(1371 1)
		{
			1.16 = 0f;
		}

		// Token: 0x06003F72 RID: 16242 RVA: 0x00189A81 File Offset: 0x00187C81
		internal void 3(1371 1)
		{
			1.FadeIn(250, (1046)0, 0);
		}

		// Token: 0x06003F73 RID: 16243 RVA: 0x00189A90 File Offset: 0x00187C90
		internal void 4(1371 1)
		{
			1.16(250, (1046)0, 0);
		}

		// Token: 0x04002E6F RID: 11887
		public static readonly 1798.1799 volumeBarCallbacks = new 1798.1799();

		// Token: 0x04002E70 RID: 11888
		public static Action<1371> action;

		// Token: 0x04002E71 RID: 11889
		public static Action<1371> action2;

		// Token: 0x04002E72 RID: 11890
		public static Action<1371> action3;

		// Token: 0x04002E73 RID: 11891
		public static Action<1371> action4;

		// Token: 0x04002E74 RID: 11892
		public static Action<1371> action5;
	}
}
