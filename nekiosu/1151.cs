using System;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Ipc;

// Token: 0x02000C0E RID: 3086
public sealed class 1151 : IpcClientChannel, IDisposable
{
	// Token: 0x060053EE RID: 21486 RVA: 0x0020B950 File Offset: 0x00209B50
	public 1151()
	{
		try
		{
			ChannelServices.RegisterChannel(this, false);
		}
		catch
		{
		}
	}

	// Token: 0x060053EF RID: 21487 RVA: 0x0020B980 File Offset: 0x00209B80
	public static 1151 1()
	{
		1151 <<EMPTY_NAME>> = null;
		try
		{
			<<EMPTY_NAME>> = new 1151();
		}
		catch
		{
			if (<<EMPTY_NAME>> != null)
			{
				<<EMPTY_NAME>>.Dispose();
				<<EMPTY_NAME>> = null;
			}
		}
		return <<EMPTY_NAME>>;
	}

	// Token: 0x060053F0 RID: 21488 RVA: 0x0020B9B8 File Offset: 0x00209BB8
	public void Dispose()
	{
		if (this.1)
		{
			return;
		}
		this.1 = true;
		try
		{
			ChannelServices.UnregisterChannel(this);
		}
		catch
		{
		}
	}

	// Token: 0x04003FA8 RID: 16296
	private bool 1;
}
