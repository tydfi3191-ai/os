using System;

// Token: 0x02000B04 RID: 2820
public sealed class 1485
{
	// Token: 0x06004E6D RID: 20077 RVA: 0x001F01C0 File Offset: 0x001EE3C0
	internal 1485(1436 1, 208 2, 1695 3)
	{
		this.1 = new 1433(1662.34, (1376)6, 1065.TopLeft, (1044)0, 2, 0.999f, true, 198.Gray, null);
		this.1.15 = 1.6f;
		this.1.16 = 0f;
		1.12(this.1);
		this.3 = 3;
		this.4 = 2;
		this.2 = new 1452[10];
		for (int i = 0; i < 10; i++)
		{
			this.2[i] = new 1452(string.Empty, 15f, 2 + new 208(0f, (float)(15 * i)), 1f, true, 198.White);
			this.2[i].16 = 0f;
			1.12(this.2[i]);
		}
	}

	// Token: 0x06004E6E RID: 20078 RVA: 0x001F02A8 File Offset: 0x001EE4A8
	internal void 1(208 1)
	{
		this.1.17 = 1;
		for (int i = 0; i < 10; i++)
		{
			this.2[i].17 = 1 + new 208(0f, (float)(15 * i));
		}
	}

	// Token: 0x06004E6F RID: 20079 RVA: 0x001F02F0 File Offset: 0x001EE4F0
	internal void Refresh()
	{
		if (1662.118)
		{
			return;
		}
		if (this.3.3.Count == 0 || this.3.Text == string.Empty)
		{
			this.Hide();
			return;
		}
		this.Show();
		float num = 90f;
		this.1(this.4 + (this.5 ? 208.Zero : new 208(0f, (float)(-15 * this.3.3.Count))));
		for (int i = 0; i < this.3.3.Count; i++)
		{
			this.2[i].SetText(string.Format("{0}.{1}", i + 1, this.3.3[i]));
			float x = this.2[i].GetTextSize().X;
			if (x > num)
			{
				num = x;
			}
		}
		this.1.20 = new 208(Math.Min(num, 250f), (float)(15 * this.3.3.Count));
	}

	// Token: 0x06004E70 RID: 20080 RVA: 0x001F0414 File Offset: 0x001EE614
	internal void Show()
	{
		this.1.16 = 1f;
		for (int i = 0; i < 10; i++)
		{
			this.2[i].16 = 1f;
		}
	}

	// Token: 0x06004E71 RID: 20081 RVA: 0x001F0450 File Offset: 0x001EE650
	internal void Hide()
	{
		this.1.16 = 0f;
		for (int i = 0; i < 10; i++)
		{
			this.2[i].16 = 0f;
			this.2[i].SetText(string.Empty);
		}
	}

	// Token: 0x04003A77 RID: 14967
	private 1433 1;

	// Token: 0x04003A78 RID: 14968
	private 1452[] 2;

	// Token: 0x04003A79 RID: 14969
	private 1695 3;

	// Token: 0x04003A7A RID: 14970
	internal 208 4;

	// Token: 0x04003A7B RID: 14971
	internal bool 5 = true;
}
