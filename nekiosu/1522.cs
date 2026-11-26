using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Ipc;
using System.Threading;

// Token: 0x02000A30 RID: 2608
public static class 1522
{
	// Token: 0x0600483C RID: 18492 RVA: 0x001CAF5C File Offset: 0x001C915C
	internal static void 1(string 1)
	{
		bool flag = 1522.2(1);
		if (!flag && !1345.1 && 1522.4())
		{
			int num = 20;
			while (num-- > 0 && !flag)
			{
				Thread.Sleep(200);
				flag = 1522.2(1);
			}
			if (!flag)
			{
				1662.SetMode(1677.Exit, false);
			}
		}
	}

	// Token: 0x0600483D RID: 18493 RVA: 0x001CAFAC File Offset: 0x001C91AC
	private static bool 2(string 1)
	{
		try
		{
			1522.1 = new IpcChannel(1);
			ChannelServices.RegisterChannel(1522.1, false);
			RemotingConfiguration.RegisterWellKnownServiceType(typeof(InterProcessOsu), "loader", WellKnownObjectMode.Singleton);
			return true;
		}
		catch
		{
			1522.1 = null;
		}
		return false;
	}

	// Token: 0x0600483E RID: 18494 RVA: 0x001CB004 File Offset: 0x001C9204
	internal static void 3()
	{
		if (1522.1 != null)
		{
			try
			{
				ChannelServices.UnregisterChannel(1522.1);
			}
			catch
			{
			}
			1522.1 = null;
		}
	}

	// Token: 0x0600483F RID: 18495 RVA: 0x001CB040 File Offset: 0x001C9240
	private static bool 4()
	{
		try
		{
			using (1151 <<EMPTY_NAME>> = 1151.1())
			{
				if (<<EMPTY_NAME>> == null)
				{
					return false;
				}
				InterProcessOsu interProcessOsu = (InterProcessOsu)Activator.GetObject(typeof(InterProcessOsu), "ipc://nekiosu/loader");
				if (interProcessOsu != null)
				{
					interProcessOsu.Quit();
					return true;
				}
			}
		}
		catch
		{
		}
		return false;
	}

	// Token: 0x06004840 RID: 18496 RVA: 0x001CB0B4 File Offset: 0x001C92B4
	internal static InterProcessOsu 5()
	{
		InterProcessOsu result;
		try
		{
			using (1151 <<EMPTY_NAME>> = 1151.1())
			{
				if (<<EMPTY_NAME>> == null)
				{
					result = null;
				}
				else
				{
					result = (InterProcessOsu)Activator.GetObject(typeof(InterProcessOsu), "ipc://nekiosu/loader");
				}
			}
		}
		catch
		{
			result = null;
		}
		return result;
	}

	// Token: 0x06004841 RID: 18497 RVA: 0x001CB118 File Offset: 0x001C9318
	internal static void 6(string 1)
	{
		try
		{
			using (1151 2 = 1151.1())
			{
				if (2 != null)
				{
					InterProcessOsu interProcessOsu = (InterProcessOsu)Activator.GetObject(typeof(InterProcessOsu), "ipc://nekiosu/loader");
					if (interProcessOsu != null)
					{
						interProcessOsu.HandleArguments(1);
					}
				}
			}
		}
		catch
		{
		}
	}

	// Token: 0x04003549 RID: 13641
	internal static IpcChannel 1;

	// Token: 0x0400354A RID: 13642
	private const string 2 = "ipc://nekiosu/loader";

	// Token: 0x0400354B RID: 13643
	public static int 3;
}
