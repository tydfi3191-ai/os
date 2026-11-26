using System;
using System.Threading;

// Token: 0x020004FB RID: 1275
[276]
public class 2499
{
	// Token: 0x0600270B RID: 9995 RVA: 0x000C21CE File Offset: 0x000C03CE
	public 2499(1436 1)
	{
		this.1 = 1;
		this.CreateSprites();
	}

	// Token: 0x0600270C RID: 9996 RVA: 0x000C21E3 File Offset: 0x000C03E3
	internal virtual int GetCombo()
	{
		return this.5;
	}

	// Token: 0x0600270D RID: 9997 RVA: 0x000C21EB File Offset: 0x000C03EB
	internal virtual void SetCombo(int 1)
	{
		this.5 = 1;
	}

	// Token: 0x0600270E RID: 9998 RVA: 0x000C21F4 File Offset: 0x000C03F4
	protected virtual string FormatCombo()
	{
		return this.4.ToString() + "x";
	}

	// Token: 0x0600270F RID: 9999 RVA: 0x000C220C File Offset: 0x000C040C
	protected virtual void CreateSprites()
	{
		2137 hudSkin = 2630.HudSkin;
		208 <<EMPTY_NAME>> = new 208(2f, 472f);
		this.2 = new 1353(this.FormatCombo(), hudSkin.FontCombo, (float)hudSkin.FontComboOverlap, (1376)6, 1065.Custom, (1044)0, <<EMPTY_NAME>>, 0.92f, true, 198.TransparentWhite, true, (1416)7);
		this.2.48 = new 208(0f, this.2.GetTextSize().Y * 0.625f + 9f);
		this.3 = new 1353("0x", hudSkin.FontCombo, (float)hudSkin.FontComboOverlap, (1376)6, 1065.Custom, (1044)0, <<EMPTY_NAME>>, 0.91f, true, 198.TransparentWhite, true, (1416)7);
		this.3.48 = new 208(3f, this.3.GetTextSize().Y * 0.625f + 9f);
		this.3.28 = true;
		this.2.15 = (this.3.15 = 1.28f);
		this.1.12(this.2);
		this.1.12(this.3);
	}

	// Token: 0x06002710 RID: 10000 RVA: 0x000C233C File Offset: 0x000C053C
	internal virtual void Hide()
	{
		this.2.16(1000, (1046)0, 0);
		this.2.19(this.2.7 - new 208(80f, 0f), 1000, (1046)2);
	}

	// Token: 0x06002711 RID: 10001 RVA: 0x000C238C File Offset: 0x000C058C
	internal virtual void Show()
	{
		this.2.FadeIn(1000, (1046)0, 0);
		this.2.19(this.2.7, 1000, (1046)1);
	}

	// Token: 0x06002712 RID: 10002 RVA: 0x000C23C0 File Offset: 0x000C05C0
	internal virtual void UpdateVisibility()
	{
		if (this.4 > 0 && !this.7)
		{
			this.7 = true;
			this.2.FadeIn(120, (1046)0, 0);
			return;
		}
		if (this.7 && this.GetCombo() == 0)
		{
			this.7 = false;
			this.2.16(120, (1046)0, 0);
		}
	}

	// Token: 0x06002713 RID: 10003 RVA: 0x000C241B File Offset: 0x000C061B
	internal void Reset()
	{
		this.SetCombo(0);
		this.4 = 0;
	}

	// Token: 0x06002714 RID: 10004 RVA: 0x000C242C File Offset: 0x000C062C
	internal virtual void UpdateDisplay()
	{
		if (this.GetCombo() < this.4)
		{
			if (this.GetCombo() == 0)
			{
				if (1662.23)
				{
					this.4--;
				}
			}
			else
			{
				this.4 = this.GetCombo();
			}
			this.OnDisplayedComboDecreased();
		}
		else if (this.GetCombo() > this.4)
		{
			this.4++;
			bool flag = this.2.GetText() != this.3.GetText();
			this.2.SetText(this.3.GetText());
			this.AnimateComboIncrement(flag);
			if (this.8 != null)
			{
				this.8();
			}
		}
		this.3.SetText(this.FormatCombo());
		if (!(this.2.GetText() != this.3.GetText()))
		{
			return;
		}
		if (this.3.3.Count > 0)
		{
			if (this.3.3[0].10 < 1662.33 + 140)
			{
				this.1();
				return;
			}
		}
		else
		{
			this.2.SetText(this.3.GetText());
		}
	}

	// Token: 0x06002715 RID: 10005 RVA: 0x000C2564 File Offset: 0x000C0764
	private void 1()
	{
		this.2.SetText(this.3.GetText());
		this.2.3.RemoveAll(new Predicate<1445>(2499.2500.Instance.1));
		this.2.3.Add(new 1445(1456.Scale, 1.28f, 1.4f, 1662.33, 1662.33 + 50, (1046)0)
		{
			15 = (1046)2
		});
		this.2.3.Add(new 1445(1456.Scale, 1.4f, 1.28f, 1662.33 + 50, 1662.33 + 100, (1046)0)
		{
			15 = (1046)1
		});
	}

	// Token: 0x06002716 RID: 10006 RVA: 0x00005ADD File Offset: 0x00003CDD
	protected virtual void OnDisplayedComboDecreased()
	{
	}

	// Token: 0x06002717 RID: 10007 RVA: 0x000C2618 File Offset: 0x000C0818
	protected virtual void AnimateComboIncrement(bool 1)
	{
		if (2)
		{
			this.1();
		}
		this.3.3.RemoveAll((1445 1) => 1.16 == 1);
		this.3.3.Add(new 1445(1456.Scale, 2f, 1.28f, 1662.33, 1662.33 + 300, (1046)0)
		{
			16 = 1
		});
		this.3.3.Add(new 1445(1456.Fade, 0.6f, 0f, 1662.33, 1662.33 + 300, (1046)0)
		{
			16 = 1
		});
	}

	// Token: 0x06002718 RID: 10008 RVA: 0x000C26CE File Offset: 0x000C08CE
	internal void 2(int 1)
	{
		if (1 > 0 && Math.Abs(this.GetCombo() - 1) > 10)
		{
			this.4 = 1;
		}
		this.SetCombo(1);
	}

	// Token: 0x06002719 RID: 10009 RVA: 0x000C26F4 File Offset: 0x000C08F4
	internal void 3(1189 1)
	{
		1189 2 = this.8;
		1189 3;
		do
		{
			3 = 2;
			1189 value = (1189)Delegate.Combine(3, 1);
			2 = Interlocked.CompareExchange<1189>(ref this.8, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x04001C06 RID: 7174
	protected readonly 1436 1;

	// Token: 0x04001C07 RID: 7175
	protected 1353 2;

	// Token: 0x04001C08 RID: 7176
	protected 1353 3;

	// Token: 0x04001C09 RID: 7177
	internal int 4;

	// Token: 0x04001C0A RID: 7178
	private int 5;

	// Token: 0x04001C0B RID: 7179
	internal int 6;

	// Token: 0x04001C0C RID: 7180
	private bool 7;

	// Token: 0x04001C0D RID: 7181
	private 1189 8;

	// Token: 0x020004FC RID: 1276
	[276]
	[Serializable]
	public sealed class 2500
	{
		// Token: 0x0600271A RID: 10010 RVA: 0x000AAB47 File Offset: 0x000A8D47
		internal bool 1(1445 1)
		{
			return 1.14 == 1456.Scale;
		}

		// Token: 0x04001C0E RID: 7182
		public static readonly 2499.2500 Instance = new 2499.2500();

		// Token: 0x04001C0F RID: 7183
		public static Predicate<1445> predicate;

		// Token: 0x04001C10 RID: 7184
		public static Predicate<1445> predicate2;
	}
}
