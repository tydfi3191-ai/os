using System;
using System.Collections.Generic;
using System.Threading;

// Token: 0x02000914 RID: 2324
public class 1689 : 1350
{
	// Token: 0x06004229 RID: 16937 RVA: 0x0019BE34 File Offset: 0x0019A034
	internal 1689(string 1, bool 2) : base(1662.11)
	{
		this.14 = new 1433(1662.34, (1376)5, 1065.TopLeft, (1044)0, 208.Zero, 0.1f, true, new 198(0, 0, 0, this.8), null);
		this.14.20 = new 208((float)1662.70.1, (float)1662.70.2);
		this.14.10 = true;
		this.7.12(this.14);
		this.5 = 2;
		this.6 = (string.IsNullOrEmpty(1) ? "(untitled)" : 1);
		if (!string.IsNullOrEmpty(1))
		{
			1452 3 = new 1452(1, 24f, new 208(2f, 2f), new 208((float)(1662.70.1() - 2), 0f), 0.92f, true, 198.White, true);
			this.7.12(3);
			this.3 = 3.GetTextSize().Y + 3.17.Y + 50f;
		}
		this.SubscribeInput();
	}

	// Token: 0x0600422A RID: 16938 RVA: 0x0000FF75 File Offset: 0x0000E175
	internal virtual bool KeepsChatOpen()
	{
		return false;
	}

	// Token: 0x0600422B RID: 16939 RVA: 0x0019BF88 File Offset: 0x0019A188
	protected virtual void SubscribeInput()
	{
		1535.40((1082)8, new 1081(this.10), 1545.Dialog, (1559)0);
		1535.40((1082)6, new 1081(this.11), 1545.Dialog, (1559)0);
		1535.40((1082)1, (object 1, EventArgs 2) => this.4 && (this.1(1) || true), 1545.Dialog, (1559)0);
		1535.40((1082)0, (object 1, EventArgs 2) => this.4 && (this.1(-1) || true), 1545.Dialog, (1559)0);
	}

	// Token: 0x0600422C RID: 16940 RVA: 0x0019BFE8 File Offset: 0x0019A1E8
	private bool 1(int 1)
	{
		using (List<1429>.Enumerator enumerator = this.17.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.26(1))
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x0600422D RID: 16941 RVA: 0x0019C044 File Offset: 0x0019A244
	internal virtual void AddSprite(1433 1)
	{
		this.7.12(1);
	}

	// Token: 0x0600422E RID: 16942 RVA: 0x0019C052 File Offset: 0x0019A252
	internal virtual void DrawDialog()
	{
		if (this.4)
		{
			this.7.22();
		}
	}

	// Token: 0x0600422F RID: 16943 RVA: 0x0019C068 File Offset: 0x0019A268
	internal int 2()
	{
		if (!this.4)
		{
			return 0;
		}
		return 1662.33;
	}

	// Token: 0x06004230 RID: 16944 RVA: 0x0019C07C File Offset: 0x0019A27C
	internal virtual void Show()
	{
		if (this.4)
		{
			return;
		}
		for (int i = this.7.28.Count - 1; i > -1; i--)
		{
			1371 <<EMPTY_NAME>> = this.7.28[i];
			if (<<EMPTY_NAME>>.3.Count > 0 && <<EMPTY_NAME>>.3[0].10 < 1662.33)
			{
				<<EMPTY_NAME>>.3.ForEach(delegate(1445 1)
				{
					1.9 += 1662.33;
					1.10 += 1662.33;
				});
			}
			if (<<EMPTY_NAME>>.3.Count == 0 && <<EMPTY_NAME>>.6 != 198.TransparentWhite)
			{
				<<EMPTY_NAME>>.15(300);
			}
		}
		this.4 = true;
	}

	// Token: 0x06004231 RID: 16945 RVA: 0x0019C14C File Offset: 0x0019A34C
	internal void 3(EventHandler 1)
	{
		EventHandler eventHandler = this.10;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, 1);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.10, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06004232 RID: 16946 RVA: 0x0019C184 File Offset: 0x0019A384
	private void 4(EventHandler 1)
	{
		EventHandler eventHandler = this.11;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, 1);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.11, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06004233 RID: 16947 RVA: 0x0019C1B9 File Offset: 0x0019A3B9
	internal void 5(string 1, 198 2, EventHandler 3)
	{
		this.4(3);
		this.7(4, 5, delegate(object 1, EventArgs 2)
		{
			this.Close(true);
		}, false, false, true);
	}

	// Token: 0x06004234 RID: 16948 RVA: 0x0019C1DA File Offset: 0x0019A3DA
	internal void 6(1361 1)
	{
		this.12.Remove(1.1[0]);
	}

	// Token: 0x06004235 RID: 16949 RVA: 0x0019C1F4 File Offset: 0x0019A3F4
	internal 1361 7(string 1, 198 2, EventHandler 3, bool 4, bool 5, bool 6)
	{
		1361 7 = new 1361(1, new 208((float)(1662.70.1() / 2 - 230 + ((!6) ? 240 : 0)), this.3) + this.15, new 208((float)(5 ? 220 : 460), 40f), 0.92f, 2, 3, this.5, false, null, true);
		((1452)7.1[3]).63(true);
		for (int i = 0; i < 4; i++)
		{
			1433 8 = 7.1[i];
			if (i < 3 && 4)
			{
				8.3(new EventHandler(this.8));
				8.8 = 7;
			}
			if (this.4)
			{
				8.15(140);
			}
			else
			{
				int num = this.12.Count * 60;
				8.16 = 0f;
				8.3.Add(new 1445(8.7 + new 208((float)(this.13 ? -40 : 40), 0f), 8.7, num, num + 800, (1046)33));
				8.3.Add(new 1445(1456.Fade, 0f, 1f, num, num + 800, (1046)1));
				8.17 += new 208((float)(this.13 ? -40 : 40), 0f);
			}
			this.7.12(8);
		}
		this.12.Add(7.1[0]);
		this.13 = !this.13;
		this.3 += 50f;
		return 7;
	}

	// Token: 0x06004236 RID: 16950 RVA: 0x0019C3D8 File Offset: 0x0019A5D8
	private void 8(object 1, EventArgs 2)
	{
		this.Close(false);
		1433 3 = 1 as 1433;
		1361 4 = (3 != null) ? (3.8 as 1361) : (1 as 1361);
		if (4 == null)
		{
			return;
		}
		4.1.ForEach(new Action<1433>(1689.1690.dialogOverlayCallbacks.1));
	}

	// Token: 0x06004237 RID: 16951 RVA: 0x0019C428 File Offset: 0x0019A628
	internal virtual void Close(bool 1)
	{
		if (!this.4)
		{
			return;
		}
		foreach (1371 2 in this.7.28)
		{
			1433 3 = (1433)2;
			3.16(120, (1046)0, 0);
			3.10 = false;
			3.5 = false;
		}
		if (1 && this.11 != null)
		{
			this.11(this, null);
		}
		if (this.10 != null)
		{
			this.10(this, null);
		}
		this.4 = false;
		this.16 = true;
		this.9();
	}

	// Token: 0x06004238 RID: 16952 RVA: 0x00005ADD File Offset: 0x00003CDD
	public override void Initialize()
	{
	}

	// Token: 0x06004239 RID: 16953 RVA: 0x0019C4E0 File Offset: 0x0019A6E0
	public override void Update()
	{
		if (1304.65 && this.4)
		{
			1356.4 = true;
			1356.6 = 0.004f;
			1356.1 = false;
			1356.5 = false;
			1356.2 = this.14.16;
		}
		base.Update();
	}

	// Token: 0x0600423A RID: 16954 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal virtual void OnShown()
	{
	}

	// Token: 0x0600423B RID: 16955 RVA: 0x0008A862 File Offset: 0x00088A62
	public void 9()
	{
		this.Dispose(true);
		GC.SuppressFinalize(this);
	}

	// Token: 0x0600423C RID: 16956 RVA: 0x0019C533 File Offset: 0x0019A733
	protected override void Dispose(bool 1)
	{
		if (1)
		{
			if (this.4)
			{
				this.Close(false);
			}
			this.10 = null;
			this.7.Dispose();
		}
		base.Dispose(1);
	}

	// Token: 0x0600423D RID: 16957 RVA: 0x0019C560 File Offset: 0x0019A760
	internal virtual bool OnKeyDown(200 1)
	{
		if (1 == 200.Enter)
		{
			this.Close(false);
			return true;
		}
		if (1 == 200.Escape)
		{
			this.Close(true);
			return true;
		}
		int num;
		if (int.TryParse(1.ToString().Replace("D", string.Empty), out num) && num < this.12.Count + 1 && num > 0)
		{
			this.12[num - 1].1(true);
			return true;
		}
		return false;
	}

	// Token: 0x0600423E RID: 16958 RVA: 0x0019C5DC File Offset: 0x0019A7DC
	private bool 10(object 1, EventArgs 2)
	{
		return this.4;
	}

	// Token: 0x0600423F RID: 16959 RVA: 0x0019C5DC File Offset: 0x0019A7DC
	private bool 11(object 1, EventArgs 2)
	{
		return this.4;
	}

	// Token: 0x04003052 RID: 12370
	internal float 3;

	// Token: 0x04003053 RID: 12371
	internal bool 4;

	// Token: 0x04003054 RID: 12372
	internal bool 5;

	// Token: 0x04003055 RID: 12373
	internal string 6;

	// Token: 0x04003056 RID: 12374
	internal 1436 7 = new 1436(true)
	{
		10 = false
	};

	// Token: 0x04003057 RID: 12375
	private byte 8 = 240;

	// Token: 0x04003058 RID: 12376
	private bool 9;

	// Token: 0x04003059 RID: 12377
	private EventHandler 10;

	// Token: 0x0400305A RID: 12378
	private EventHandler 11;

	// Token: 0x0400305B RID: 12379
	private List<1433> 12 = new List<1433>();

	// Token: 0x0400305C RID: 12380
	private bool 13;

	// Token: 0x0400305D RID: 12381
	internal 1433 14;

	// Token: 0x0400305E RID: 12382
	internal 208 15;

	// Token: 0x0400305F RID: 12383
	internal bool 16;

	// Token: 0x04003060 RID: 12384
	internal readonly List<1429> 17 = new List<1429>();

	// Token: 0x02000915 RID: 2325
	[Serializable]
	public sealed class 1690
	{
		// Token: 0x06004243 RID: 16963 RVA: 0x0019C61D File Offset: 0x0019A81D
		internal void 1(1433 1)
		{
			1.16(600, (1046)0, 0);
		}

		// Token: 0x04003061 RID: 12385
		public static readonly 1689.1690 dialogOverlayCallbacks = new 1689.1690();

		// Token: 0x04003062 RID: 12386
		public static Action<1445> action;

		// Token: 0x04003063 RID: 12387
		public static Action<1433> action2;
	}
}
