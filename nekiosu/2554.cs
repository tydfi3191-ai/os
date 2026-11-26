using System;
using System.Collections.Generic;
using System.Globalization;

// Token: 0x020004EC RID: 1260
[276]
public sealed class 2554
{
	// Token: 0x0600268B RID: 9867 RVA: 0x000BD96C File Offset: 0x000BBB6C
	public 2554(2486 1, 1436 2)
	{
		this.6 = 4;
		this.15 = 2554.1();
		this.Box(208.Zero, new 208(164f, 84f), 0.9f, new 198(18, 18, 24, 220));
		this.8 = this.Box(208.Zero, new 208(164f, 13f), 0.905f, new 198(58, 62, 84, 240));
		this.8.10 = true;
		this.8.52 = "Drag to move";
		this.Text("Replay controls", 10f, new 208(5f, 6.5f), 198.White);
		string[] array = new string[]
		{
			"<<",
			"<",
			"|<",
			"||",
			">|",
			">",
			">>"
		};
		string[] array2 = new string[]
		{
			"Seek back 10 seconds",
			"Seek back 1 second",
			"Step back one frame (,)",
			"Pause or play (Space)",
			"Step forward one frame (.)",
			"Seek forward 1 second",
			"Seek forward 10 seconds"
		};
		EventHandler[] array3 = new EventHandler[]
		{
			delegate(object 1, EventArgs 2)
			{
				this.6.136(-10.0);
			},
			delegate(object 1, EventArgs 2)
			{
				this.6.136(-1.0);
			},
			delegate(object 1, EventArgs 2)
			{
				this.6.138(-1);
			},
			delegate(object 1, EventArgs 2)
			{
				this.6.132();
			},
			delegate(object 1, EventArgs 2)
			{
				this.6.138(1);
			},
			delegate(object 1, EventArgs 2)
			{
				this.6.136(1.0);
			},
			delegate(object 1, EventArgs 2)
			{
				this.6.136(10.0);
			}
		};
		for (int i = 0; i < array.Length; i++)
		{
			1361 3 = new 1361(array[i], this.15 + new 208(5f + (float)i * 22.2f, 19f), new 208(20.5f, 17f), 0.92f, (i == 3) ? 198.YellowGreen : new 198(92, 132, 190), array3[i], true, false, null, true);
			3.6(array2[i]);
			this.7.AddRange(3.1);
			if (i == 3)
			{
				this.9 = 3;
			}
		}
		this.Text("Speed", 11f, new 208(5f, 50f), 198.White);
		this.10 = new 1429(null, 0.1, 2.0, 1.0, this.15 + new 208(43f, 50f), 74);
		this.10.18 = delegate(bool 1)
		{
			this.6.133(this.10.7);
		};
		this.7.AddRange(this.10.13);
		this.11 = this.Text("1.00x", 11f, new 208(127f, 50f), 198.White);
		this.12 = this.Text(string.Empty, 11f, new 208(5f, 65f), 198.White);
		this.13 = this.Box(new 208(5f, 72f), new 208(154f, 6f), 0.91f, new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue, 60));
		this.13.52 = "Click or drag to jump to a point in the replay";
		this.13.10 = true;
		this.14 = this.Box(new 208(5f, 72f), new 208(0f, 6f), 0.915f, new 198(120, 190, byte.MaxValue));
		5.14<1433>(this.7);
	}

	// Token: 0x0600268C RID: 9868 RVA: 0x000BDD70 File Offset: 0x000BBF70
	private 1433 Box(208 1, 208 2, float 3, 198 4)
	{
		1433 5 = new 1433(1662.34, (1376)6, 1065.TopLeft, (1044)0, this.15 + 1, 3, true, 4, null);
		5.15 = 1.6f;
		5.20 = 2;
		this.7.Add(5);
		return 5;
	}

	// Token: 0x0600268D RID: 9869 RVA: 0x000BDDBC File Offset: 0x000BBFBC
	private 1452 Text(string 1, float 2, 208 3, 198 4)
	{
		1452 5 = new 1452(1, 2, this.15 + 3, 0.92f, true, 4);
		5.49 = 1065.CentreLeft;
		this.7.Add(5);
		return 5;
	}

	// Token: 0x0600268E RID: 9870 RVA: 0x000BDDFC File Offset: 0x000BBFFC
	private static 208 1()
	{
		string[] array = (1304.60.GetValue() ?? string.Empty).Split(new char[]
		{
			','
		});
		float num;
		float num2;
		if (array.Length == 2 && float.TryParse(array[0], NumberStyles.Float, 1662.18, out num) && float.TryParse(array[1], NumberStyles.Float, 1662.18, out num2))
		{
			return 2554.2(new 208(num, num2));
		}
		return 2554.2(new 208((float)1662.70.1() - 164f - 8f, 215f));
	}

	// Token: 0x0600268F RID: 9871 RVA: 0x000BDE94 File Offset: 0x000BC094
	private static 208 2(208 1)
	{
		float val = Math.Max(0f, (float)1662.70.1() - 164f);
		return new 208(Math.Max(0f, Math.Min(val, 1.X)), Math.Max(0f, Math.Min(396f, 1.Y)));
	}

	// Token: 0x06002690 RID: 9872 RVA: 0x000BDEF4 File Offset: 0x000BC0F4
	private void 3(208 1)
	{
		4 = 2554.2(4);
		208 2 = 4 - this.15;
		if (2 == 208.Zero)
		{
			return;
		}
		this.15 = 4;
		foreach (1433 3 in this.7)
		{
			3.3.RemoveAll((1445 1) => 1.14 == 1456.Movement);
			3.17 += 2;
			3.7 += 2;
		}
		this.10.22(this.10.9, this.10.8, this.10.7);
	}

	// Token: 0x06002691 RID: 9873 RVA: 0x000BDFE4 File Offset: 0x000BC1E4
	public void 4()
	{
		if (this.6.IsReplayViewerPaused != this.21)
		{
			this.21 = this.6.IsReplayViewerPaused;
			this.9.4.SetText(this.21 ? ">" : "||");
		}
		this.11.SetText(this.6.ReplayUserRate.ToString("0.00", 1662.18) + "x");
		int num = Math.Max(1, this.6.ReplayEndTime);
		int num2 = Math.Max(0, Math.Min(num, 1226.16));
		208 <<EMPTY_NAME>> = 1555.21();
		bool flag = 1555.2() == 199.Pressed;
		1058 2 = this.13.50;
		2.Y -= 2.Height;
		2.Height *= 3f;
		float num3 = (2.Width > 0f) ? Math.Max(0f, Math.Min(1f, (<<EMPTY_NAME>>.X - 2.X) / 2.Width)) : 0f;
		if (flag && !this.16)
		{
			this.17 = this.10.25();
			this.18 = (!this.17 && 2.7(<<EMPTY_NAME>>));
			this.19 = (!this.17 && !this.18 && this.8.50.7(<<EMPTY_NAME>>));
			this.20 = <<EMPTY_NAME>>;
		}
		if (this.19 && flag)
		{
			this.3(this.15 + (<<EMPTY_NAME>> - this.20) * 1662.70.8());
			this.20 = <<EMPTY_NAME>>;
		}
		if (this.17 && flag)
		{
			this.10.27();
		}
		if (!flag)
		{
			if (this.18)
			{
				this.6.137((int)(num3 * (float)num));
			}
			if (this.19)
			{
				1304.60.SetValue(this.15.X.ToString("0", 1662.18) + "," + this.15.Y.ToString("0", 1662.18));
			}
			this.17 = false;
			this.18 = false;
			this.19 = false;
		}
		float num4 = this.18 ? num3 : ((float)num2 / (float)num);
		this.14.20.X = 154f * num4;
		this.12.SetText(2554.5((int)(num4 * (float)num)) + " / " + 2554.5(num));
		this.16 = flag;
	}

	// Token: 0x06002692 RID: 9874 RVA: 0x000BE2A0 File Offset: 0x000BC4A0
	private static string 5(int 1)
	{
		int num = Math.Max(0, 1) / 1000;
		return (num / 60).ToString() + ":" + (num % 60).ToString("00");
	}

	// Token: 0x04001B90 RID: 7056
	private const float 1 = 164f;

	// Token: 0x04001B91 RID: 7057
	private const float 2 = 84f;

	// Token: 0x04001B92 RID: 7058
	private const float 3 = 13f;

	// Token: 0x04001B93 RID: 7059
	private const float 4 = 5f;

	// Token: 0x04001B94 RID: 7060
	private const float 5 = 154f;

	// Token: 0x04001B95 RID: 7061
	private readonly 2486 6;

	// Token: 0x04001B96 RID: 7062
	private readonly List<1433> 7 = new List<1433>();

	// Token: 0x04001B97 RID: 7063
	private readonly 1433 8;

	// Token: 0x04001B98 RID: 7064
	private readonly 1361 9;

	// Token: 0x04001B99 RID: 7065
	private readonly 1429 10;

	// Token: 0x04001B9A RID: 7066
	private readonly 1452 11;

	// Token: 0x04001B9B RID: 7067
	private readonly 1452 12;

	// Token: 0x04001B9C RID: 7068
	private readonly 1433 13;

	// Token: 0x04001B9D RID: 7069
	private readonly 1433 14;

	// Token: 0x04001B9E RID: 7070
	private 208 15;

	// Token: 0x04001B9F RID: 7071
	private bool 16;

	// Token: 0x04001BA0 RID: 7072
	private bool 17;

	// Token: 0x04001BA1 RID: 7073
	private bool 18;

	// Token: 0x04001BA2 RID: 7074
	private bool 19;

	// Token: 0x04001BA3 RID: 7075
	private 208 20;

	// Token: 0x04001BA4 RID: 7076
	private bool 21;
}
