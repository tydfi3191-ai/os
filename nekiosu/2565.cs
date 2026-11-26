using System;
using System.Collections.Generic;

// Token: 0x020004BE RID: 1214
public sealed class 2565 : 1371
{
	// Token: 0x060024CC RID: 9420 RVA: 0x000A7550 File Offset: 0x000A5750
	internal 2565(int 1, int 2, 2241 3, 1058 4) : base(true)
	{
		this.2 = 0.85f;
		this.30 = 3;
		this.31 = 1;
		this.32 = 2;
		this.35 = 4;
		if (3.11 == null || 3.11.Count <= 0)
		{
			return;
		}
		float x = 3.11[0].X;
		float x2 = 3.11[3.11.Count - 1].X;
		float num = 4.Width / (x2 - x);
		List<208> list = new List<208>();
		list.AddRange(3.11);
		while (list.Count > 100)
		{
			int num2 = list.Count - 1;
			while (num2 >= 0 && num2 < list.Count)
			{
				list.RemoveAt(num2);
				num2 -= 2;
			}
		}
		208[] array = list.ToArray();
		for (int i = 0; i < array.Length; i++)
		{
			array[i].X = 1662.70.3() * ((array[i].X - x) * num + 4.X);
			bool flag = (double)array[i].Y > 0.5;
			array[i].Y = 1662.70.3() * ((1f - array[i].Y) * 4.Height + 4.Y);
			if (i > 0)
			{
				1050 5 = new 1050(array[i - 1], array[i], flag ? 198.YellowGreen : 198.Red);
				this.28.Add(5);
				this.33 += (double)5.1();
			}
		}
	}

	// Token: 0x060024CD RID: 9421 RVA: 0x000A773B File Offset: 0x000A593B
	public override 1069 Update()
	{
		return base.Update();
	}

	// Token: 0x060024CE RID: 9422 RVA: 0x000A7744 File Offset: 0x000A5944
	public override bool Draw()
	{
		if (!base.Draw())
		{
			return false;
		}
		int num = 1662.33 - this.31;
		208 <<EMPTY_NAME>> = (1436.40.30 - 1436.40.29) * 1662.70.3();
		if (this.28.Count > 0 && (num <= this.32 || <<EMPTY_NAME>> != this.34))
		{
			this.29.Clear();
			double num2 = this.33 * (double)Math.Min((float)this.32, (float)num / (float)this.32);
			foreach (1050 2 in this.28)
			{
				if ((double)2.1() >= num2)
				{
					this.29.Add(new 1050(2.1 + <<EMPTY_NAME>>, 2.1 + 208.Normalize(2.2 - 2.1) * (float)num2 + <<EMPTY_NAME>>, 2.5));
					break;
				}
				1050 3 = 2.Clone() as 1050;
				3.1 += <<EMPTY_NAME>>;
				3.2 += <<EMPTY_NAME>>;
				this.29.Add(3);
				num2 -= (double)2.1();
			}
			this.34 = <<EMPTY_NAME>>;
		}
		if (this.29.Count > 0)
		{
			1662.13.4(this.29, (float)(1662.47 ? 1 : 2), 198.Green, 0f, "StandardNoGradient", true, true, 15);
		}
		return true;
	}

	// Token: 0x040019CB RID: 6603
	private List<1050> 28 = new List<1050>();

	// Token: 0x040019CC RID: 6604
	private List<1051> 29 = new List<1051>();

	// Token: 0x040019CD RID: 6605
	private 2241 30;

	// Token: 0x040019CE RID: 6606
	private int 31;

	// Token: 0x040019CF RID: 6607
	private int 32;

	// Token: 0x040019D0 RID: 6608
	private double 33;

	// Token: 0x040019D1 RID: 6609
	private 208 34;

	// Token: 0x040019D2 RID: 6610
	internal 1058 35;
}
