using System;

// Token: 0x02000AF3 RID: 2803
public sealed class 1468 : 2535
{
	// Token: 0x06004E0E RID: 19982 RVA: 0x001EE19C File Offset: 0x001EC39C
	public 1468() : base(false)
	{
		this.5 = new 1433(1455.2("notification", (1416)1, null), (1376)19, 1065.Centre, (1044)0, new 208(0f, 0f), 0.8f, true, new 198(0, 0, 0, 128), null);
		this.1.12(this.5);
		this.3 = new 1433(1455.2("loading-small", (1416)1, null), (1376)19, 1065.Centre, (1044)0, new 208(-100f, 11f), 1f, true, 198.White, null);
		1445 item = new 1445(1456.Rotation, 0f, 6.2831855f, 1662.33, 1662.33 + 1500, (1046)0)
		{
			17 = true
		};
		this.3.3.Add(item);
		this.3.15(2000);
		this.1.12(this.3);
		this.4 = new 1452("Bancho is connecting...", 8f, new 208(-88f, 18f), 1f, true, 198.White);
		this.4.74 = false;
		this.4.85 = false;
		this.4.41 = (1376)19;
		this.1.12(this.4);
		this.1.28.ForEach(new Action<1371>(1468.1469.instance.1));
		this.1.5 = 0f;
	}

	// Token: 0x06004E0F RID: 19983 RVA: 0x001EE326 File Offset: 0x001EC526
	internal new void 1(string 1)
	{
		if (!(this.7 == 1))
		{
			this.7 = 1;
			1662.89.Schedule(new 1189(this.3), false);
		}
	}

	// Token: 0x06004E10 RID: 19984 RVA: 0x001EE358 File Offset: 0x001EC558
	internal override void Update()
	{
		if (!2486.14 && 1535.32)
		{
			if (this.1.5 < 1f)
			{
				this.1.5 = Math.Min(1f, this.1.5 + 0.01f);
			}
		}
		else if (this.1.5 > 0f)
		{
			this.1.5 = Math.Max(0f, this.1.5 - 0.01f);
		}
		base.Update();
	}

	// Token: 0x06004E11 RID: 19985 RVA: 0x001EE3EC File Offset: 0x001EC5EC
	internal void 2(bool 1)
	{
		1468.1470 2 = new 1468.1470();
		2.1 = 1;
		2.2 = this;
		if (!1662.47)
		{
			1662.89.Schedule(new 1189(2.1), false);
		}
	}

	// Token: 0x06004E12 RID: 19986 RVA: 0x001EE42C File Offset: 0x001EC62C
	private void 3()
	{
		this.4.SetText(this.7);
		float x = this.4.GetTextSize().X;
		this.5.20.X = Math.Max(1f, (x + 40f) / ((float)this.5.39 / 1.6f));
		this.4.7.X = (this.4.17.X = -88f * this.5.20.X - 30f * Math.Max(0f, this.5.20.X - 1f));
		this.4.3.ForEach(new Action<1445>(this.4));
		this.3.7.X = (this.3.17.X = -12f - 88f * this.5.20.X - 30f * Math.Max(0f, this.5.20.X - 1f));
		this.3.3.ForEach(new Action<1445>(this.5));
		if (!string.IsNullOrEmpty(this.7))
		{
			this.2(true);
		}
	}

	// Token: 0x06004E13 RID: 19987 RVA: 0x001EE5A1 File Offset: 0x001EC7A1
	private void 4(1445 1)
	{
		1.6.X = this.4.17.X;
	}

	// Token: 0x06004E14 RID: 19988 RVA: 0x001EE5BE File Offset: 0x001EC7BE
	private void 5(1445 1)
	{
		1.6.X = this.3.17.X;
	}

	// Token: 0x04003A38 RID: 14904
	private 1433 3;

	// Token: 0x04003A39 RID: 14905
	private 1452 4;

	// Token: 0x04003A3A RID: 14906
	private 1433 5;

	// Token: 0x04003A3B RID: 14907
	private bool 6;

	// Token: 0x04003A3C RID: 14908
	private string 7;

	// Token: 0x02000AF4 RID: 2804
	public sealed class 1470
	{
		// Token: 0x06004E15 RID: 19989 RVA: 0x001EE5DC File Offset: 0x001EC7DC
		internal void 1()
		{
			if (this.1 == this.2.6)
			{
				return;
			}
			this.2.6 = this.1;
			foreach (1371 <<EMPTY_NAME>> in this.2.1.28)
			{
				1433 2 = (1433)<<EMPTY_NAME>>;
				if (this.2.6)
				{
					2.FadeIn(500, (1046)0, 0);
					2.19(2.7, 500, (1046)1);
				}
				else
				{
					2.16(3000, (1046)0, 0);
					2.19(new 208(2.7.X, 2.7.Y - 25f), 1500, (1046)2);
				}
			}
		}

		// Token: 0x04003A3D RID: 14909
		public bool 1;

		// Token: 0x04003A3E RID: 14910
		public 1468 2;
	}

	// Token: 0x02000AF5 RID: 2805
	[Serializable]
	public sealed class 1469
	{
		// Token: 0x06004E17 RID: 19991 RVA: 0x001EE6C8 File Offset: 0x001EC8C8
		internal void 1(1371 1)
		{
			1.16 = 0f;
			1.17.Y = 1.17.Y - 25f;
		}

		// Token: 0x04003A3F RID: 14911
		public static readonly 1468.1469 instance = new 1468.1469();

		// Token: 0x04003A40 RID: 14912
		public static Action<1371> prepareFadeInAction;
	}
}
