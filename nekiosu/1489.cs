using System;
using System.Collections.Generic;

// Token: 0x02000B08 RID: 2824
public sealed class 1489
{
	// Token: 0x06004E92 RID: 20114 RVA: 0x001F0F77 File Offset: 0x001EF177
	internal 1489(string 1, int 2, 198 3, 1189 4 = null)
	{
		this.1 = 261.2(1);
		this.2 = 2;
		this.4 = 3;
		this.11 = 4;
	}

	// Token: 0x06004E93 RID: 20115 RVA: 0x001F0FAC File Offset: 0x001EF1AC
	internal int 1()
	{
		return this.3;
	}

	// Token: 0x06004E94 RID: 20116 RVA: 0x001F0FB4 File Offset: 0x001EF1B4
	private void 2(int 1)
	{
		this.3 = 1;
	}

	// Token: 0x06004E95 RID: 20117 RVA: 0x001F0FBD File Offset: 0x001EF1BD
	private void 3(object 1, EventArgs 2)
	{
		if (!this.12)
		{
			this.2(1662.33);
			this.5.ForEach(new Action<1433>(this.5));
		}
	}

	// Token: 0x06004E96 RID: 20118 RVA: 0x001F0FE9 File Offset: 0x001EF1E9
	private void 4(object 1, EventArgs 2)
	{
		if (!this.12)
		{
			this.2(1662.33);
			this.5.ForEach(new Action<1433>(this.6));
		}
	}

	// Token: 0x06004E97 RID: 20119 RVA: 0x001F1018 File Offset: 0x001EF218
	private void OnClick(object 1, EventArgs 2)
	{
		this.12 = true;
		this.5.ForEach(new Action<1433>(1489.1490.Instance.2));
		if (1535.14 == 199.Pressed && this.11 != null && !2486.14)
		{
			this.11();
		}
	}

	// Token: 0x06004E98 RID: 20120 RVA: 0x001F106C File Offset: 0x001EF26C
	internal float Show()
	{
		1381 <<EMPTY_NAME>> = 1455.2("notification", (1416)1, null);
		float num = (float)<<EMPTY_NAME>>.3() * 0.625f;
		float num2 = num * 0.9f;
		float num3 = (num - num2) / 2f;
		float num4 = (float)1662.70.2();
		float num5 = Math.Max(7f, 9f - (float)(1662.70.2 - 1024) / 256f);
		this.10 = new 1452(this.1, num5, new 208(3f + num3 + num2, num4 + num3), new 208(num2, 0f), 1f, false, 198.White, false);
		this.10.41 = (1376)8;
		this.10.49 = 1065.TopLeft;
		this.10.54(true);
		ref 208 textSize = this.10.GetTextSize();
		this.8 = new 1433(<<EMPTY_NAME>>, (1376)8, 1065.TopRight, (1044)0, new 208(0f, num4), 0.98f, false, this.4, null);
		this.8.40 = new bool?(false);
		this.8.34 = 13;
		this.8.3(new EventHandler(this.OnClick));
		this.8.10 = true;
		this.8.35(new EventHandler(this.4));
		this.8.37(new EventHandler(this.3));
		num4 += 8.125f;
		float num6 = textSize.Y - (26.875f - num3 * 2f);
		if (num6 > 0f)
		{
			this.7 = new 1433(<<EMPTY_NAME>>, (1376)8, 1065.TopRight, (1044)0, new 208(0f, num4), 0.98f, false, this.4, null);
			this.7.40 = new bool?(false);
			this.7.37 = 13;
			this.7.34 = 13;
			this.7.3(new EventHandler(this.OnClick));
			this.7.10 = true;
			this.7.35(new EventHandler(this.4));
			this.7.37(new EventHandler(this.3));
			this.7.20.Y = num6 / 8.125f;
			this.5.Add(this.7);
			num4 += 8.125f * this.7.20.Y;
		}
		this.9 = new 1433(<<EMPTY_NAME>>, (1376)8, 1065.TopRight, (1044)0, new 208(0f, num4), 0.98f, false, this.4, null);
		this.9.40 = new bool?(false);
		this.9.37 = 26;
		this.9.34 = 30;
		this.9.10 = true;
		this.9.35(new EventHandler(this.4));
		this.9.37(new EventHandler(this.3));
		this.9.3(new EventHandler(this.OnClick));
		num4 += 18.75f;
		this.5.Add(this.8);
		this.5.Add(this.10);
		this.5.Add(this.9);
		this.6 = num4 - (float)1662.70.2();
		this.2(1662.33);
		foreach (1433 2 in this.5)
		{
			2.17.Y = 2.17.Y - (this.6 + 28f);
			2.17.X = 2.17.X - 100f;
			2.22(new 208(100f, 0f), 800, (1046)26);
			2.3.Add(new 1445(1456.Fade, 0f, 1f, 1662.33, 1662.33 + 200, (1046)0));
			2.3.Add(new 1445(1456.Fade, 1f, 0f, 1662.33 + 200 + this.2 - 500, 1662.33 + 200 + this.2, (1046)2));
			2.8 = "notice";
			1662.89.2(new 1189(this.7), 200, false);
		}
		return this.6;
	}

	// Token: 0x06004E99 RID: 20121 RVA: 0x001F1514 File Offset: 0x001EF714
	private void 5(1433 1)
	{
		if (1 != this.10)
		{
			1.39(this.4, 60, false, (1046)0);
		}
		1.3.RemoveAll(new Predicate<1445>(1489.1490.Instance.1));
		1.3.Add(new 1445(1456.Fade, 1f, 0f, 1662.33 + 200 + this.2 - 500, 1662.33 + 200 + this.2, (1046)2));
	}

	// Token: 0x06004E9A RID: 20122 RVA: 0x001F15A0 File Offset: 0x001EF7A0
	private void 6(1433 1)
	{
		if (2 != this.10)
		{
			2.39(198.White, 60, false, (1046)0);
		}
		2.3.RemoveAll((1445 1) => 1.14 == 1456.Fade && 1.5 == 0f);
		2.3.Add(new 1445(1456.Fade, 1f, 0f, 1662.33 + 200 + this.2 - 500 + 60000, 1662.33 + 200 + this.2 + 60000, (1046)2));
	}

	// Token: 0x06004E9B RID: 20123 RVA: 0x001F1643 File Offset: 0x001EF843
	private void 7()
	{
		this.10.40 = new bool?(true);
	}

	// Token: 0x04003A8D RID: 14989
	internal readonly string 1;

	// Token: 0x04003A8E RID: 14990
	internal readonly int 2;

	// Token: 0x04003A8F RID: 14991
	private int 3;

	// Token: 0x04003A90 RID: 14992
	internal readonly 198 4;

	// Token: 0x04003A91 RID: 14993
	internal List<1433> 5 = new List<1433>();

	// Token: 0x04003A92 RID: 14994
	private float 6;

	// Token: 0x04003A93 RID: 14995
	private 1433 7;

	// Token: 0x04003A94 RID: 14996
	private 1433 8;

	// Token: 0x04003A95 RID: 14997
	private 1433 9;

	// Token: 0x04003A96 RID: 14998
	private 1452 10;

	// Token: 0x04003A97 RID: 14999
	internal 1189 11;

	// Token: 0x04003A98 RID: 15000
	private bool 12;

	// Token: 0x02000B09 RID: 2825
	[Serializable]
	public sealed class 1490
	{
		// Token: 0x06004E9C RID: 20124 RVA: 0x0014F0B5 File Offset: 0x0014D2B5
		internal bool 1(1445 1)
		{
			return 1.14 == 1456.Fade && 1.5 == 0f;
		}

		// Token: 0x06004E9D RID: 20125 RVA: 0x000BFBF7 File Offset: 0x000BDDF7
		internal void 2(1433 1)
		{
			1.16(100, (1046)0, 0);
		}

		// Token: 0x04003A99 RID: 15001
		public static readonly 1489.1490 Instance = new 1489.1490();

		// Token: 0x04003A9A RID: 15002
		public static Predicate<1445> predicate;

		// Token: 0x04003A9B RID: 15003
		public static Predicate<1445> predicate2;

		// Token: 0x04003A9C RID: 15004
		public static Action<1433> action;
	}
}
