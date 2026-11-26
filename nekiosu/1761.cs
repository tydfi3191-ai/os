using System;
using System.Collections.Generic;

// Token: 0x020008D2 RID: 2258
public sealed class 1761
{
	// Token: 0x060040B0 RID: 16560 RVA: 0x001919FC File Offset: 0x0018FBFC
	internal 1761(string 1, int 2, 1389 3)
	{
		this.1 = 3;
		int 4 = 1662.33;
		int num = 4 + 2;
		this.3 = new 1452(1, 18f, new 208((float)(1662.70.1() / 2), 240f), new 208((float)1662.70.1 / 1662.70.3(), 0f), 1f, false, 198.White, false);
		this.3.49 = 1065.TopCentre;
		this.3.75 = (1066)2;
		this.3.64(true);
		this.3.3.Add(new 1445(1456.Fade, 0f, 1f, 4, 4 + 100, (1046)0));
		this.3.3.Add(new 1445(1456.Fade, 1f, 0f, num, num + 150, (1046)0));
		float num2 = this.3.GetTextSize().Y;
		1452 5 = this.3;
		5.17.Y = 5.17.Y - num2 / 2f;
		this.4.Add(this.3);
		num2 *= 1.5f;
		this.2 = new 1433(1662.34, new 208(0f, 240f - num2 / 2f), 0.999f, false, new 198(0, 0, 0, 180));
		this.2.15 = 1.6f;
		this.2.49 = 1065.TopLeft;
		this.2.20 = new 208((float)1662.70.1(), num2);
		this.2.3.Add(new 1445(1456.VectorScale, new 208((float)1662.70.1(), 0f), this.2.20, 4, 4 + 300, (1046)30));
		this.2.3.Add(new 1445(new 208(0f, 240f), this.2.7, 4, 4 + 300, (1046)30));
		this.2.3.Add(new 1445(1456.Fade, 0.7058824f, 0f, num, num + 150, (1046)0));
		this.4.Add(this.2);
		if (3 != (1389)1)
		{
			if (3 == (1389)2)
			{
				this.2.6 = 198.Red;
				return;
			}
		}
		else
		{
			this.3.60(new 198(146, 82, 0));
			this.2.6 = new 198(byte.MaxValue, 186, 0);
			1433 6 = new 1433(1455.2("test-build-overlay", (1416)1, null), 1065.BottomLeft, new 208(0f, 240f - num2 / 2f), 0.9991f, false, 198.White);
			6.15 = 1.5f;
			6.15(300);
			6.20(-100f, 2, (1046)0);
			6.3.Add(new 1445(1456.Fade, 1f, 0f, num, num + 150, (1046)0));
			this.4.Add(6);
			6 = new 1433(1455.2("test-build-overlay", (1416)1, null), new 208(-100f, 240f + num2 / 2f), 0.9991f, false, 198.White);
			6.43(true);
			6.20(0f, 2, (1046)0);
			6.15 = 1.5f;
			6.15(300);
			6.3.Add(new 1445(1456.Fade, 1f, 0f, num, num + 150, (1046)0));
			this.4.Add(6);
		}
	}

	// Token: 0x060040B1 RID: 16561 RVA: 0x00191DC7 File Offset: 0x0018FFC7
	internal bool 1()
	{
		return this.4.Find(new Predicate<1433>(1761.1762.instance.1)) != null;
	}

	// Token: 0x060040B2 RID: 16562 RVA: 0x00191DE7 File Offset: 0x0018FFE7
	internal void 2()
	{
		this.4.ForEach(new Action<1433>(1761.1762.instance.2));
		this.4.Clear();
	}

	// Token: 0x04002F48 RID: 12104
	internal 1389 1;

	// Token: 0x04002F49 RID: 12105
	private 1433 2;

	// Token: 0x04002F4A RID: 12106
	private 1452 3;

	// Token: 0x04002F4B RID: 12107
	internal List<1433> 4 = new List<1433>();

	// Token: 0x020008D3 RID: 2259
	[Serializable]
	public sealed class 1762
	{
		// Token: 0x060040B3 RID: 16563 RVA: 0x00191E0F File Offset: 0x0019000F
		internal bool 1(1433 1)
		{
			return 1.16 > 0.01f;
		}

		// Token: 0x060040B4 RID: 16564 RVA: 0x00191E1E File Offset: 0x0019001E
		internal void 2(1433 1)
		{
			1.16(300, (1046)0, 0);
			1.22(new 208(0f, 15f), 600, (1046)2);
			1.10 = false;
		}

		// Token: 0x04002F4C RID: 12108
		public static readonly 1761.1762 instance = new 1761.1762();

		// Token: 0x04002F4D RID: 12109
		public static Predicate<1433> isSpriteVisiblePredicate;

		// Token: 0x04002F4E RID: 12110
		public static Action<1433> fadeOutAndSlideAction;
	}
}
