using System;
using System.IO;

// Token: 0x02000458 RID: 1112
public sealed class 2646 : 2647
{
	// Token: 0x06002214 RID: 8724 RVA: 0x00092C5C File Offset: 0x00090E5C
	internal 2646(1433 1, string 2, int 3, int 4)
	{
		this.7 = 1;
		this.17 = (1 as 1351);
		this.19 = 0;
		this.19 = 3;
		this.10 = 2635.Animation;
		this.16 = 4;
		this.3 = 2.Replace(1272.5().44() + Path.DirectorySeparatorChar.ToString(), string.Empty);
	}

	// Token: 0x06002215 RID: 8725 RVA: 0x00092CCC File Offset: 0x00090ECC
	internal 2646(string 1, 208 2, 1065 3, 2645 4, int 5, double 6, bool 7, 1446 8)
	{
		this.12 = 2;
		this.13 = 3;
		this.14 = 5;
		this.15 = 7;
		this.18 = Math.Max(1.0, 6);
		this.5 = 4;
		this.20 = 2648.24(this.5);
		this.17 = new 1351(null, (1376)3, 3, (1044)1, 2, this.20, false, 198.White, null);
		this.17.71 = 8;
		if (1272.5() != null && 1272.5().32 < 6)
		{
			this.17.53(Math.Round(0.015 * 6) * 1.186 * 16.666666666666668);
		}
		else
		{
			this.17.53(6);
		}
		this.7 = this.17;
		this.10 = 2635.Animation;
		this.3 = 2672.17(1).Replace(1272.5().44() + Path.DirectorySeparatorChar.ToString(), string.Empty);
		this.21 = new string[this.14];
		for (int i = 0; i < this.14; i++)
		{
			string text = this.3.Replace(".", i.ToString() + ".");
			1455.16(text);
			this.21[i] = text;
		}
		this.17.41(new EventHandler(this.4));
	}

	// Token: 0x06002216 RID: 8726 RVA: 0x00092E58 File Offset: 0x00091058
	private new void 4(object 1, EventArgs 2)
	{
		if (this.6 && !(bool)1)
		{
			for (int i = 0; i < this.14; i++)
			{
				1455.17(this.21[i]);
			}
		}
	}

	// Token: 0x06002217 RID: 8727 RVA: 0x00053ADC File Offset: 0x00051CDC
	internal override void SetStartTime(int 1)
	{
		throw new NotImplementedException();
	}

	// Token: 0x06002218 RID: 8728 RVA: 0x00053ADC File Offset: 0x00051CDC
	internal override void SetEndTime(int 1)
	{
		throw new NotImplementedException();
	}

	// Token: 0x06002219 RID: 8729 RVA: 0x00092E94 File Offset: 0x00091094
	internal override bool LoadTextures()
	{
		if (this.6)
		{
			return false;
		}
		this.6 = true;
		1381[] array = null;
		if (this.15)
		{
			array = 1455.5(this.3, (1416)7, false);
		}
		if (array == null)
		{
			array = new 1381[this.14];
			if (this.21 != null)
			{
				for (int i = 0; i < this.14; i++)
				{
					array[i] = 1455.2(this.21[i], (1416)4, null);
				}
			}
		}
		this.17.55(array);
		return true;
	}

	// Token: 0x0600221A RID: 8730 RVA: 0x00092F14 File Offset: 0x00091114
	internal override 2647 Clone()
	{
		return new 2646((1351)this.17.Clone(), this.3, this.8, this.1)
		{
			21 = this.21,
			18 = this.18,
			14 = this.14,
			11 = this.11,
			5 = this.5,
			9 = this.9
		};
	}

	// Token: 0x0400177C RID: 6012
	private readonly 208 12;

	// Token: 0x0400177D RID: 6013
	private readonly 1065 13;

	// Token: 0x0400177E RID: 6014
	private int 14;

	// Token: 0x0400177F RID: 6015
	private readonly bool 15;

	// Token: 0x04001780 RID: 6016
	private int 16;

	// Token: 0x04001781 RID: 6017
	internal 1351 17;

	// Token: 0x04001782 RID: 6018
	internal double 18;

	// Token: 0x04001783 RID: 6019
	private int 19;

	// Token: 0x04001784 RID: 6020
	private float 20;

	// Token: 0x04001785 RID: 6021
	private string[] 21;
}
