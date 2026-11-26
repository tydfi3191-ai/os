using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

// Token: 0x02000AD2 RID: 2770
public sealed class 1441
{
	// Token: 0x06004D03 RID: 19715 RVA: 0x001E7FA8 File Offset: 0x001E61A8
	internal 1441()
	{
	}

	// Token: 0x06004D04 RID: 19716 RVA: 0x001E7FD0 File Offset: 0x001E61D0
	internal void 1(1441.1442 1)
	{
		1441.1442 2 = this.4;
		1441.1442 3;
		do
		{
			3 = 2;
			1441.1442 value = (1441.1442)Delegate.Combine(3, 1);
			2 = Interlocked.CompareExchange<1441.1442>(ref this.4, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x06004D05 RID: 19717 RVA: 0x001E8005 File Offset: 0x001E6205
	public void 2()
	{
		this.6 = 1662.17(new 1189(this.3));
	}

	// Token: 0x06004D06 RID: 19718 RVA: 0x001E8020 File Offset: 0x001E6220
	private void 3()
	{
		for (;;)
		{
			if (!this.1 || 2486.14)
			{
				Thread.Sleep(1000);
			}
			else
			{
				List<1441.1443> list = new List<1441.1443>(1441.5);
				foreach (1441.1443 item in this.3)
				{
					list.Remove(item);
				}
				if (list.Count == 0)
				{
					break;
				}
				Process[] processes = Process.GetProcesses();
				for (int i = 0; i < processes.Length; i++)
				{
					1441.1443 item2;
					if ((item2 = list.Find(new Predicate<1441.1443>(new 1441.1444
					{
						1 = processes[i]
					}.1))) != null)
					{
						1441.1442 <<EMPTY_NAME>> = this.4;
						if (<<EMPTY_NAME>> != null)
						{
							<<EMPTY_NAME>>(item2);
						}
						this.3.Add(item2);
					}
				}
				Thread.Sleep(this.2);
			}
		}
	}

	// Token: 0x04003967 RID: 14695
	internal bool 1 = true;

	// Token: 0x04003968 RID: 14696
	internal int 2 = 300000;

	// Token: 0x04003969 RID: 14697
	private List<1441.1443> 3 = new List<1441.1443>();

	// Token: 0x0400396A RID: 14698
	private 1441.1442 4;

	// Token: 0x0400396B RID: 14699
	private static List<1441.1443> 5 = new List<1441.1443>
	{
		new 1441.1443
		{
			1 = "f.lux",
			2 = "flux"
		}
	};

	// Token: 0x0400396C RID: 14700
	private 373 6;

	// Token: 0x02000AD3 RID: 2771
	public sealed class 1444
	{
		// Token: 0x06004D08 RID: 19720 RVA: 0x001E8145 File Offset: 0x001E6345
		internal bool 1(1441.1443 1)
		{
			return 1.2 == this.1.ProcessName;
		}

		// Token: 0x0400396D RID: 14701
		public Process 1;
	}

	// Token: 0x02000AD4 RID: 2772
	public sealed class 1443
	{
		// Token: 0x0400396E RID: 14702
		public string 1;

		// Token: 0x0400396F RID: 14703
		public string 2;
	}

	// Token: 0x02000AD5 RID: 2773
	// (Invoke) Token: 0x06004D0C RID: 19724
	public delegate void 1442(1441.1443 1);
}
