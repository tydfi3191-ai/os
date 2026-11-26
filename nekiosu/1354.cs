using System;
using System.Collections.Generic;

// Token: 0x02000A72 RID: 2674
public sealed class 1354
{
	// Token: 0x06004A29 RID: 18985 RVA: 0x001D66B8 File Offset: 0x001D48B8
	public 1354(EventHandler 1, bool 2 = true, bool 3 = false)
	{
		this.11 = 8;
		1381[] array = null;
		if (9)
		{
			array = 1455.5("menu-back", (1416)3, true);
		}
		if (array != null && array.Length != 0)
		{
			this.10 = new 1351(array, (1376)6, 1065.BottomLeft, (1044)0, new 208(0f, 480f), 0.9f, true, 198.White);
			this.10.61();
			this.10.54 = true;
			this.1.Add(this.10);
			this.9 = new 1351(array, (1376)6, 1065.BottomLeft, (1044)0, new 208(0f, 480f), 0.91f, true, 198.White);
			if (3)
			{
				this.9.24(0f, 0, (1046)0);
			}
			this.9.16 = 0.01f;
			this.9.61();
			this.9.3(new EventHandler(this.OnClick));
			this.9.35(delegate(object 1, EventArgs 2)
			{
				if (1662.11.2())
				{
					1226.27(new string[]
					{
						"back-button-hover",
						"menuclick"
					});
				}
			});
			this.9.10 = true;
			this.9.54 = true;
			this.9.28 = true;
			this.9.42 = new 1445(1456.Fade, 0.003921569f, 0.4f, 0, 250, (1046)0);
			this.1.Add(this.9);
			return;
		}
		List<1433> list = this.1;
		1452 4 = new 1452(1568.1(2679.General_Back).ToLower(), 15f, new 208(0f, 21f), 0.91f, true, 198.White)
		{
			41 = (1376)12,
			49 = 1065.Centre,
			54 = true
		};
		1452 item = 4;
		this.5 = 4;
		list.Add(item);
		float x = this.5.GetTextSize().X;
		if (x > 38f)
		{
			this.2 = x - 38f;
		}
		List<1433> list2 = this.1;
		1433 5 = new 1433(1455.2("back-button-layer", (1416)1, null), (1376)12, 1065.BottomRight, (1044)0, new 208(0f, 0f), 0.91f, true, this.3, null);
		5.54 = true;
		1433 item2 = 5;
		this.7 = 5;
		list2.Add(item2);
		List<1433> list3 = this.1;
		1386 6 = new 1386(1048.chevron_circle_left, 18f, new 208(0f, 21f));
		6.2 = 0.92f;
		6.41 = (1376)12;
		1386 item3 = 6;
		this.6 = 6;
		list3.Add(item3);
		this.6.29(delegate
		{
			if (1226.69)
			{
				this.6.15 = (this.12 ? 1.5f : 0.9f);
				1445 10 = this.6.25(1f, (int)1226.76() * 3, (1046)25);
				if (10 != null)
				{
					10.9 -= (int)1226.76() / 4;
					10.10 -= (int)1226.76() / 4;
				}
			}
		});
		List<1433> list4 = this.1;
		1433 7 = new 1433(1455.2("back-button-layer", (1416)1, null), (1376)12, 1065.BottomRight, (1044)0, new 208(0f, 0f), 0.9f, true, this.3, null);
		7.10 = true;
		7.54 = true;
		item2 = 7;
		this.8 = 7;
		list4.Add(item2);
		this.8.3(new EventHandler(this.4));
		this.8.35(new EventHandler(this.5));
		this.8.35(delegate(object 1, EventArgs 2)
		{
			if (1662.11.2())
			{
				1226.27(new string[]
				{
					"back-button-hover",
					"menuclick"
				});
			}
		});
		this.8.37(new EventHandler(this.6));
		this.2((1046)25, 0);
	}

	// Token: 0x06004A2A RID: 18986 RVA: 0x001D6A68 File Offset: 0x001D4C68
	private void 1(1046 1, int 2)
	{
		this.12 = true;
		this.7.19(new 208(40f, this.7.17.Y), 2, 1);
		this.6.19(new 208(16.666666f, this.6.17.Y), 2, 1);
		this.8.19(new 208(86f + this.2, this.8.17.Y), 2, 1);
		this.5.19(new 208((86f + this.2 - 40f) / 2.4f + 40f, this.5.17.Y), 2, 1);
		this.7.39(this.4, 2, false, 1);
	}

	// Token: 0x06004A2B RID: 18987 RVA: 0x001D6B54 File Offset: 0x001D4D54
	private void 2(1046 1, int 2)
	{
		this.12 = false;
		this.7.19(new 208(22f, this.7.17.Y), 2, 1);
		this.6.19(new 208(9.166666f, this.6.17.Y), 2, 1);
		this.8.19(new 208(60f + this.2, this.8.17.Y), 2, 1);
		this.5.19(new 208((60f + this.2 - 22f) / 2.4f + 22f, this.5.17.Y), 2, 1);
		this.7.39(this.3, 2, false, 1);
	}

	// Token: 0x06004A2C RID: 18988 RVA: 0x001D6C3D File Offset: 0x001D4E3D
	private void OnClick(object 1, EventArgs 2)
	{
		this.3();
	}

	// Token: 0x06004A2D RID: 18989 RVA: 0x001D6C45 File Offset: 0x001D4E45
	internal void 3()
	{
		1226.27(new string[]
		{
			"back-button-click",
			"menuback"
		});
		EventHandler eventHandler = this.11;
		if (eventHandler == null)
		{
			return;
		}
		eventHandler(this, null);
	}

	// Token: 0x06004A2E RID: 18990 RVA: 0x001D6C75 File Offset: 0x001D4E75
	private void 4(object 1, EventArgs 2)
	{
		this.OnClick(this, null);
		this.2((1046)31, 400);
	}

	// Token: 0x06004A2F RID: 18991 RVA: 0x001D6C8C File Offset: 0x001D4E8C
	private void 5(object 1, EventArgs 2)
	{
		this.1((1046)25, 600);
	}

	// Token: 0x06004A30 RID: 18992 RVA: 0x001D6C9B File Offset: 0x001D4E9B
	private void 6(object 1, EventArgs 2)
	{
		this.2((1046)25, 600);
	}

	// Token: 0x0400373D RID: 14141
	internal List<1433> 1 = new List<1433>();

	// Token: 0x0400373E RID: 14142
	private float 2;

	// Token: 0x0400373F RID: 14143
	private 198 3 = new 198(238, 51, 153);

	// Token: 0x04003740 RID: 14144
	private 198 4 = new 198(187, 17, 119);

	// Token: 0x04003741 RID: 14145
	private 1452 5;

	// Token: 0x04003742 RID: 14146
	private 1386 6;

	// Token: 0x04003743 RID: 14147
	private 1433 7;

	// Token: 0x04003744 RID: 14148
	private 1433 8;

	// Token: 0x04003745 RID: 14149
	private 1351 9;

	// Token: 0x04003746 RID: 14150
	private 1351 10;

	// Token: 0x04003747 RID: 14151
	private EventHandler 11;

	// Token: 0x04003748 RID: 14152
	private bool 12;
}
