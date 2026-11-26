using System;
using System.Runtime.InteropServices;
using System.Threading;

// Token: 0x0200088D RID: 2189
public sealed class 1826
{
	// Token: 0x06003EFA RID: 16122 RVA: 0x00187430 File Offset: 0x00185630
	internal void 1(Action 1)
	{
		Action action = this.1;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Combine(action2, 1);
			action = Interlocked.CompareExchange<Action>(ref this.1, value, action2);
		}
		while (action != action2);
	}

	// Token: 0x06003EFB RID: 16123 RVA: 0x00187465 File Offset: 0x00185665
	public void 2()
	{
		1662.17(new 1189(this.3));
	}

	// Token: 0x06003EFC RID: 16124
	[DllImport("kernel32")]
	private static extern bool GetSystemPowerStatus(1826.1829 1);

	// Token: 0x06003EFD RID: 16125 RVA: 0x0018747C File Offset: 0x0018567C
	private void 3()
	{
		for (;;)
		{
			try
			{
				1826.1829 <<EMPTY_NAME>> = new 1826.1829();
				1826.GetSystemPowerStatus(<<EMPTY_NAME>>);
				if ((<<EMPTY_NAME>>.2 & (1826.1828)128) == (1826.1828)0 && <<EMPTY_NAME>>.1 == (1826.1827)0)
				{
					1826.1827? 2 = this.2;
					1826.1827 3 = <<EMPTY_NAME>>.1;
					if (!(2.GetValueOrDefault() == 3 & 2 != null))
					{
						Action action = this.1;
						if (action != null)
						{
							action();
						}
					}
				}
				this.2 = new 1826.1827?(<<EMPTY_NAME>>.1);
				Thread.Sleep(10000);
				continue;
			}
			catch
			{
			}
			break;
		}
	}

	// Token: 0x04002E05 RID: 11781
	private Action 1;

	// Token: 0x04002E06 RID: 11782
	private 1826.1827? 2;

	// Token: 0x0200088E RID: 2190
	[StructLayout(LayoutKind.Sequential)]
	public sealed class 1829
	{
		// Token: 0x04002E07 RID: 11783
		public 1826.1827 1;

		// Token: 0x04002E08 RID: 11784
		public 1826.1828 2;

		// Token: 0x04002E09 RID: 11785
		public byte 3;

		// Token: 0x04002E0A RID: 11786
		public byte 4;

		// Token: 0x04002E0B RID: 11787
		public int 5;

		// Token: 0x04002E0C RID: 11788
		public int 6;
	}

	// Token: 0x0200088F RID: 2191
	public enum 1828 : byte
	{

	}

	// Token: 0x02000890 RID: 2192
	public enum 1827 : byte
	{

	}
}
