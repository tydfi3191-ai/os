using System;
using System.Collections.Generic;
using System.Windows.Forms;

// Token: 0x020008D4 RID: 2260
public static class 1763
{
	// Token: 0x060040B7 RID: 16567 RVA: 0x00191E5B File Offset: 0x0019005B
	private static bool 1()
	{
		return (!2486.14 || 1304.111) && 1535.32;
	}

	// Token: 0x060040B8 RID: 16568 RVA: 0x00191E78 File Offset: 0x00190078
	internal static void 2(string 1, int 2, 1389 3)
	{
		1763.1769 showMiniMessageClosure = new 1763.1769();
		showMiniMessageClosure.1 = 261.2(1);
		showMiniMessageClosure.2 = 2;
		showMiniMessageClosure.3 = 3;
		if (showMiniMessageClosure.1 == null)
		{
			return;
		}
		1338.5("Notification: " + showMiniMessageClosure.1, 1341.Runtime, (1114)1);
		if (1662.47)
		{
			return;
		}
		1662.89.Schedule(delegate()
		{
			if (1763.3 != null && 1763.3.1())
			{
				1763.3();
			}
			1763.3 = new 1761(showMiniMessageClosure.1, showMiniMessageClosure.2, showMiniMessageClosure.3);
			if (1662.29 != null)
			{
				1662.29.14<1433>(1763.3.4);
			}
		}, true);
	}

	// Token: 0x060040B9 RID: 16569 RVA: 0x00191F09 File Offset: 0x00190109
	internal static void 3()
	{
		1662.89.Schedule(new 1189(1763.1764.instance.1), false);
	}

	// Token: 0x060040BA RID: 16570 RVA: 0x00191F28 File Offset: 0x00190128
	internal static void 4(string 1)
	{
		1763.1768 2 = new 1763.1768();
		2.1 = 1;
		1662.89.Schedule(new 1189(2.1), true);
	}

	// Token: 0x060040BB RID: 16571 RVA: 0x00191F5C File Offset: 0x0019015C
	internal static void 5(string 1, 198 2, int 3, 1189 4)
	{
		1763.1766 5 = new 1763.1766();
		5.1 = 1;
		5.2 = 3;
		5.3 = 2;
		5.4 = 4;
		1662.89.Schedule(new 1189(5.1), true);
	}

	// Token: 0x060040BC RID: 16572 RVA: 0x00191FA4 File Offset: 0x001901A4
	internal static void 6(1489 1)
	{
		1763.1767 2 = new 1763.1767();
		2.1 = 1;
		1338.5("Notification: " + 2.1.1, 1341.Runtime, (1114)1);
		if (!1662.47 && (1763.4 == null || !(2.1.1 == 1763.4.1) || 1763.4.1() + 1763.4.2 <= 1662.33))
		{
			if (!1763.1())
			{
				if (1763.1.Count < 50 && !1763.7(2.1.1))
				{
					1763.1.Enqueue(2.1);
				}
				return;
			}
			1763.4 = 2.1;
			1662.89.Schedule(new 1189(2.1), true);
		}
	}

	// Token: 0x060040BD RID: 16573 RVA: 0x00192080 File Offset: 0x00190280
	private static bool 7(string 1)
	{
		using (Queue<1489>.Enumerator enumerator = 1763.1.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.1 == 1)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x060040BE RID: 16574 RVA: 0x001920E0 File Offset: 0x001902E0
	internal static void 8()
	{
		if (1763.1())
		{
			if (1662.33 > 1763.2 + 500 && 1763.1.Count > 0)
			{
				1763.2 = 1662.33;
				1763.6(1763.1.Dequeue());
				return;
			}
		}
		else
		{
			if (1304.111 || !2486.14 || 1763.2 <= 0)
			{
				return;
			}
			1763.2 = 0;
			foreach (1371 <<EMPTY_NAME>> in 1662.29.16("notice"))
			{
				1433 2 = (1433)<<EMPTY_NAME>>;
				2.5 = false;
				2.16(100, (1046)0, 0);
			}
		}
	}

	// Token: 0x060040BF RID: 16575 RVA: 0x001921B4 File Offset: 0x001903B4
	public static DialogResult 9(string 1, MessageBoxButtons 2, MessageBoxIcon 3)
	{
		1662.82(true);
		DialogResult result = MessageBox.Show(1, "nekiosu", 2, 3);
		1662.82(false);
		return result;
	}

	// Token: 0x04002F4F RID: 12111
	private static readonly Queue<1489> 1 = new Queue<1489>();

	// Token: 0x04002F50 RID: 12112
	private static int 2;

	// Token: 0x04002F51 RID: 12113
	private static 1761 3;

	// Token: 0x04002F52 RID: 12114
	private static 1489 4;

	// Token: 0x04002F53 RID: 12115
	private static 1059 5 = (1059)1;

	// Token: 0x020008D5 RID: 2261
	public sealed class 1766
	{
		// Token: 0x060040C1 RID: 16577 RVA: 0x001921E1 File Offset: 0x001903E1
		internal void 1()
		{
			1763.6(new 1489(this.1, this.2, this.3, this.4));
		}

		// Token: 0x04002F54 RID: 12116
		public string 1;

		// Token: 0x04002F55 RID: 12117
		public int 2;

		// Token: 0x04002F56 RID: 12118
		public 198 3;

		// Token: 0x04002F57 RID: 12119
		public 1189 4;
	}

	// Token: 0x020008D6 RID: 2262
	[Serializable]
	public sealed class 1764
	{
		// Token: 0x060040C3 RID: 16579 RVA: 0x00192205 File Offset: 0x00190405
		internal void 1()
		{
			if (1763.3 != null)
			{
				1763.3.2();
				1763.3 = null;
			}
		}

		// Token: 0x060040C4 RID: 16580 RVA: 0x000BA3D9 File Offset: 0x000B85D9
		internal bool 2(1445 1)
		{
			return 1.14 == 1456.Movement;
		}

		// Token: 0x04002F58 RID: 12120
		public static readonly 1763.1764 instance = new 1763.1764();

		// Token: 0x04002F59 RID: 12121
		public static 1189 voidDelegate;

		// Token: 0x04002F5A RID: 12122
		public static Predicate<1445> predicate;
	}

	// Token: 0x020008D7 RID: 2263
	public sealed class 1767
	{
		// Token: 0x060040C7 RID: 16583 RVA: 0x0019222C File Offset: 0x0019042C
		internal void 1()
		{
			1763.1765 CS_0024_003C_003E8__locals2 = new 1763.1765();
			List<1371> list = 1662.29.16("notice");
			foreach (1371 <<EMPTY_NAME>> in list)
			{
				1445 2 = <<EMPTY_NAME>>.3.Find(new Predicate<1445>(1763.1764.instance.2));
				if (2 != null)
				{
					<<EMPTY_NAME>>.17 = 2.6;
					<<EMPTY_NAME>>.3.Remove(2);
				}
			}
			CS_0024_003C_003E8__locals2.1 = this.1.Show();
			list.ForEach(delegate(1371 1)
			{
				1.22(new 208(0f, 0f - CS_0024_003C_003E8__locals2.1), 800, (1046)27);
			});
			1662.29.14<1433>(this.1.5);
		}

		// Token: 0x04002F5B RID: 12123
		public 1489 1;
	}

	// Token: 0x020008D9 RID: 2265
	public sealed class 1769
	{
		// Token: 0x04002F5D RID: 12125
		public string 1;

		// Token: 0x04002F5E RID: 12126
		public int 2;

		// Token: 0x04002F5F RID: 12127
		public 1389 3;
	}

	// Token: 0x020008DA RID: 2266
	public sealed class 1768
	{
		// Token: 0x060040CC RID: 16588 RVA: 0x0019233A File Offset: 0x0019053A
		internal void 1()
		{
			1763.6(new 1489(this.1, this.1.Length * 100, 198.DarkRed, null));
		}

		// Token: 0x04002F60 RID: 12128
		public string 1;
	}

	// Token: 0x020008DB RID: 2267
	public sealed class 1765
	{
		// Token: 0x04002F61 RID: 12129
		public float 1;
	}
}
