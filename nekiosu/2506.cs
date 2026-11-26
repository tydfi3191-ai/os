using System;
using System.Collections.Generic;

// Token: 0x02000518 RID: 1304
[276]
public class 2506
{
	// Token: 0x06002804 RID: 10244 RVA: 0x000CABB8 File Offset: 0x000C8DB8
	internal 2506(1436 1)
	{
		this.7 = 1;
		1381[] array = this.GetFrames("scorebar-colour");
		1381[] frames = this.GetFrames("scorebar-marker");
		this.18 = (array[0].6 == (1416)1 || frames[0].6 == (1416)2);
		if (this.18)
		{
			if (array[0].2 == "scorebar-colour-0" && array[0].6 == (1416)1)
			{
				array = new 1381[]
				{
					this.GetTexture("scorebar-colour")
				};
			}
			this.6 = frames[0];
			this.4 = frames[0];
			this.5 = frames[0];
			this.1 = new 1351(array, (1376)6, 1065.TopLeft, (1044)0, new 208(7.5f, 7.8f), 0.965f, true, 198.White, null);
			this.3 = new 1433(this.6, (1376)16, 1065.Centre, (1044)0, new 208(this.9(), 10.625f * 1662.70.3()), 0.97f, true, 198.White, null);
			this.3.28 = true;
		}
		else
		{
			this.6 = this.GetTexture("scorebar-ki");
			this.4 = this.GetTexture("scorebar-kidanger");
			this.5 = this.GetTexture("scorebar-kidanger2");
			this.1 = new 1351(array, (1376)6, 1065.TopLeft, (1044)0, new 208(3f, 10f), 0.965f, true, 198.White, null);
			this.3 = new 1433(this.6, (1376)16, 1065.Centre, (1044)0, new 208(0f, 10f * 1662.70.3()), 0.97f, true, 198.White, null);
		}
		this.1.35 = 0;
		this.1.34 = 120;
		this.1.61();
		this.1.70 = true;
		this.2 = new 1433(this.GetTexture("scorebar-bg"), (1376)6, 1065.TopLeft, (1044)0, 208.Zero, 0.96f, true, 198.White, null);
		this.8.Add(this.2);
		this.8.Add(this.1);
		this.8.Add(this.3);
		if (1 != null)
		{
			1.14<1433>(this.8);
		}
		this.Update();
	}

	// Token: 0x06002805 RID: 10245 RVA: 0x000CAE3C File Offset: 0x000C903C
	internal double 1()
	{
		return this.13;
	}

	// Token: 0x06002806 RID: 10246 RVA: 0x000CAE44 File Offset: 0x000C9044
	private void 2(double 1)
	{
		this.13 = 1;
	}

	// Token: 0x06002807 RID: 10247 RVA: 0x000CAE4D File Offset: 0x000C904D
	internal double 3()
	{
		return this.14;
	}

	// Token: 0x06002808 RID: 10248 RVA: 0x000CAE55 File Offset: 0x000C9055
	private void 4(double 1)
	{
		this.14 = 1;
	}

	// Token: 0x06002809 RID: 10249 RVA: 0x000CAE5E File Offset: 0x000C905E
	internal double 5()
	{
		return this.15;
	}

	// Token: 0x0600280A RID: 10250 RVA: 0x000CAE66 File Offset: 0x000C9066
	private void 6(double 1)
	{
		this.15 = 1;
	}

	// Token: 0x0600280B RID: 10251 RVA: 0x000CAE6F File Offset: 0x000C906F
	internal bool 7()
	{
		return this.16;
	}

	// Token: 0x0600280C RID: 10252 RVA: 0x000CAE77 File Offset: 0x000C9077
	internal void 8(bool 1)
	{
		if (this.16 != 1)
		{
			this.OnVisibilityChanged(1);
			this.16 = 1;
		}
	}

	// Token: 0x0600280D RID: 10253 RVA: 0x000CAE90 File Offset: 0x000C9090
	protected virtual void OnVisibilityChanged(bool 1)
	{
		if (2)
		{
			this.8.ForEach(new Action<1433>(2506.2507.instance.1));
			return;
		}
		this.8.ForEach(delegate(1433 1)
		{
			1.16(100, (1046)0, 0);
		});
	}

	// Token: 0x0600280E RID: 10254 RVA: 0x000CAEE6 File Offset: 0x000C90E6
	internal float 9()
	{
		return (this.1.17.X + (float)this.1.35 / 1.6f) * 1662.70.3();
	}

	// Token: 0x0600280F RID: 10255 RVA: 0x000CAF16 File Offset: 0x000C9116
	protected virtual 1381[] GetFrames(string 1)
	{
		return 1455.5(1, (1416)7, true);
	}

	// Token: 0x06002810 RID: 10256 RVA: 0x000CAF20 File Offset: 0x000C9120
	protected virtual 1381 GetTexture(string 1)
	{
		return 1455.2(1, (1416)7, null);
	}

	// Token: 0x06002811 RID: 10257 RVA: 0x000CAF2C File Offset: 0x000C912C
	internal virtual void Hide()
	{
		this.1.16(500, (1046)0, 0);
		this.2.16(500, (1046)0, 0);
		this.3.16(500, (1046)0, 0);
		if (this.17 != null)
		{
			this.17.16(50, (1046)0, 0);
		}
		208 <<EMPTY_NAME>> = new 208(0f, 20f);
		this.1.18(this.1.7 - <<EMPTY_NAME>>, 500);
		this.2.18(this.2.7 - <<EMPTY_NAME>>, 500);
		this.3.7 = new 208(this.3.17.X, this.3.7.Y);
		this.3.3.Add(new 1445(1456.Scale, 1f, 1.6f, 1662.33, 1662.33 + 500, (1046)0));
	}

	// Token: 0x06002812 RID: 10258 RVA: 0x000CB03C File Offset: 0x000C923C
	internal virtual void Show()
	{
		this.1.FadeIn(500, (1046)0, 0);
		this.2.FadeIn(500, (1046)0, 0);
		this.3.FadeIn(500, (1046)0, 0);
		this.1.18(this.1.7, 500);
		this.2.18(this.2.7, 500);
		this.3.3.Add(new 1445(1456.Scale, 1.6f, 1f, 1662.33, 1662.33 + 500, (1046)0));
	}

	// Token: 0x06002813 RID: 10259 RVA: 0x000CB0E8 File Offset: 0x000C92E8
	internal virtual void Update()
	{
		if (2486.4)
		{
			this.1.35 = 0;
		}
		if (!this.9 || this.10 > 0)
		{
			if (this.18 && 2486.14() == 2147.Osu)
			{
				if (this.1() < 40.0)
				{
					this.3.6 = (this.1.6 = 1045.4(198.Black, 198.Red, Math.Max(0f, (float)((40.0 - this.1()) / 40.0))));
					this.3.9(true);
				}
				else if (this.1() < 100.0)
				{
					this.3.6 = (this.1.6 = 1045.4(198.White, 198.Black, Math.Max(0f, (float)((100.0 - this.1()) / 100.0))));
					this.3.28 = false;
					this.3.9(false);
				}
				else
				{
					this.1.6 = 198.White;
					this.3.6 = 198.White;
					this.3.28 = true;
					this.3.9(false);
				}
			}
			if (this.1() < 40.0)
			{
				if (this.3.47 != this.5)
				{
					this.3.47 = this.5;
				}
			}
			else if (this.1() < 100.0)
			{
				if (this.3.47 != this.4)
				{
					this.3.47 = this.4;
				}
			}
			else if (this.3.47 != this.6)
			{
				this.3.47 = this.6;
			}
		}
		if (this.1() < this.3())
		{
			if (this.9)
			{
				if (this.10 < 1226.16 && (2486.16 || 1226.32 == (1042)1))
				{
					this.2(Math.Min(200.0, this.1() + this.11 * (2486.16 ? 1662.82 : 1226.21)));
					if (this.3.3.Count == 0)
					{
						this.3.3.Add(new 1445(1456.Scale, 1.2f, 0.8f, 1662.33, 1662.33 + 150, (1046)0));
					}
				}
			}
			else
			{
				this.2(Math.Min(200.0, this.1() + Math.Abs(this.3() - this.1()) / 4.0 * 1662.10));
			}
		}
		else if (this.1() > this.3())
		{
			this.9 = false;
			this.2(Math.Max(0.0, this.1() - Math.Abs(this.1() - this.3()) / 6.0 * 1662.10));
		}
		this.1.35 = (int)Math.Min((double)this.1.39, Math.Max(0.0, (double)this.1.39 * (this.1() / 200.0)));
		this.UpdateMarkerPosition();
	}

	// Token: 0x06002814 RID: 10260 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal virtual void Method3946()
	{
	}

	// Token: 0x06002815 RID: 10261 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal virtual void SetAlpha(float 1)
	{
	}

	// Token: 0x06002816 RID: 10262 RVA: 0x000CB47F File Offset: 0x000C967F
	protected virtual void UpdateMarkerPosition()
	{
		this.3.17 = new 208(this.9(), this.3.17.Y);
	}

	// Token: 0x06002817 RID: 10263 RVA: 0x000CB4A8 File Offset: 0x000C96A8
	internal virtual void FadeMarkerColour(198 1)
	{
		1445 2 = this.3.3.Find(new Predicate<1445>(2506.2507.instance.2));
		if (2 != null)
		{
			this.3.6 = 2.7;
			this.3.3.Remove(2);
		}
		1445 item = new 1445(this.3.6, 1, 1662.33, 1662.33 + 400);
		this.3.3.Add(item);
	}

	// Token: 0x06002818 RID: 10264 RVA: 0x000CB530 File Offset: 0x000C9730
	internal virtual void PulseMarker()
	{
		this.3.3.RemoveAll((1445 1) => 1.14 == 1456.Scale);
		this.3.3.Add(new 1445(1456.Scale, 1.2f, 0.8f, 1662.33, 1662.33 + 150, (1046)0));
	}

	// Token: 0x06002819 RID: 10265 RVA: 0x000CB5A0 File Offset: 0x000C97A0
	internal virtual void AddMarkerBurst()
	{
		if (this.16)
		{
			this.17 = new 1433(this.6, (1376)16, 1065.Centre, (1044)0, this.3.17, 1f, false, 198.White, null);
			1445 <<EMPTY_NAME>>;
			1445 2;
			if (this.3.28)
			{
				this.17.28 = this.3.28;
				<<EMPTY_NAME>> = new 1445(1456.Fade, 0.5f, 0f, 1662.33, 1662.33 + 120, (1046)0);
				2 = new 1445(1456.Scale, 1f, 2f, 1662.33, 1662.33 + 120, (1046)0);
			}
			else
			{
				<<EMPTY_NAME>> = new 1445(1456.Fade, 1f, 0f, 1662.33, 1662.33 + 120, (1046)0);
				2 = new 1445(1456.Scale, 1f, 1.6f, 1662.33, 1662.33 + 120, (1046)0);
			}
			2.15 = (1046)1;
			<<EMPTY_NAME>>.15 = (1046)1;
			this.17.3.Add(2);
			this.17.3.Add(<<EMPTY_NAME>>);
			if (this.7 != null)
			{
				this.7.12(this.17);
			}
		}
	}

	// Token: 0x0600281A RID: 10266 RVA: 0x000CB6CE File Offset: 0x000C98CE
	internal virtual void SetHealth(double 1)
	{
		this.4(Math.Max(0.0, Math.Min(200.0, 1)));
		this.6(1);
	}

	// Token: 0x0600281B RID: 10267 RVA: 0x000CB6FC File Offset: 0x000C98FC
	internal virtual void Drain(double 1)
	{
		if (2486.14 && this.9)
		{
			this.9 = false;
		}
		this.6(Math.Max(0.0, this.5() - 1));
		this.4(Math.Max(0.0, this.3() - 1));
	}

	// Token: 0x0600281C RID: 10268 RVA: 0x000CB758 File Offset: 0x000C9958
	internal virtual void AddHealth(double 1)
	{
		if (2486.14 && this.9)
		{
			this.9 = false;
		}
		this.6(this.5() + 1);
		this.4(Math.Max(0.0, Math.Min(200.0, this.3() + 1)));
	}

	// Token: 0x0600281D RID: 10269 RVA: 0x000CB7B3 File Offset: 0x000C99B3
	internal void 10(double 1)
	{
		this.2(1);
	}

	// Token: 0x0600281E RID: 10270 RVA: 0x000CB7BC File Offset: 0x000C99BC
	internal virtual void ResetToFull()
	{
		this.4(200.0);
		this.6(200.0);
		this.2(0.0);
	}

	// Token: 0x04001CCE RID: 7374
	protected readonly 1351 1;

	// Token: 0x04001CCF RID: 7375
	protected internal readonly 1433 2;

	// Token: 0x04001CD0 RID: 7376
	protected readonly 1433 3;

	// Token: 0x04001CD1 RID: 7377
	protected readonly 1381 4;

	// Token: 0x04001CD2 RID: 7378
	protected readonly 1381 5;

	// Token: 0x04001CD3 RID: 7379
	protected readonly 1381 6;

	// Token: 0x04001CD4 RID: 7380
	protected readonly 1436 7;

	// Token: 0x04001CD5 RID: 7381
	protected readonly List<1433> 8 = new List<1433>();

	// Token: 0x04001CD6 RID: 7382
	internal bool 9 = true;

	// Token: 0x04001CD7 RID: 7383
	internal int 10;

	// Token: 0x04001CD8 RID: 7384
	internal double 11 = 0.02;

	// Token: 0x04001CD9 RID: 7385
	internal double 12;

	// Token: 0x04001CDA RID: 7386
	private double 13;

	// Token: 0x04001CDB RID: 7387
	private double 14;

	// Token: 0x04001CDC RID: 7388
	private double 15;

	// Token: 0x04001CDD RID: 7389
	private bool 16 = true;

	// Token: 0x04001CDE RID: 7390
	private 1433 17;

	// Token: 0x04001CDF RID: 7391
	protected bool 18;

	// Token: 0x02000519 RID: 1305
	[276]
	[Serializable]
	public sealed class 2507
	{
		// Token: 0x0600281F RID: 10271 RVA: 0x000BFD5C File Offset: 0x000BDF5C
		internal void 1(1433 1)
		{
			1.FadeIn(100, (1046)0, 0);
		}

		// Token: 0x06002820 RID: 10272 RVA: 0x000CB7EB File Offset: 0x000C99EB
		internal bool 2(1445 1)
		{
			return 1.14 == 1456.Colour;
		}

		// Token: 0x04001CE0 RID: 7392
		public static readonly 2506.2507 instance = new 2506.2507();

		// Token: 0x04001CE1 RID: 7393
		public static Action<1433> action;

		// Token: 0x04001CE2 RID: 7394
		public static Action<1433> action2;

		// Token: 0x04001CE3 RID: 7395
		public static Predicate<1445> predicate;

		// Token: 0x04001CE4 RID: 7396
		public static Predicate<1445> predicate2;
	}
}
