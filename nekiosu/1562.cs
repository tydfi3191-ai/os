using System;
using System.Runtime.InteropServices;
using System.Security;
using Microsoft.StylusInput;

// Token: 0x02000A69 RID: 2665
public sealed class 1562 : 1083
{
	// Token: 0x060049E5 RID: 18917 RVA: 0x001D4678 File Offset: 0x001D2878
	internal void 1(bool 1)
	{
		if (this.1 && this.4.Enabled != 1)
		{
			this.4.Enabled = 1;
		}
	}

	// Token: 0x060049E6 RID: 18918
	[SuppressUnmanagedCodeSecurity]
	[DllImport("user32.dll")]
	private static extern int GetSystemMetrics(int 1);

	// Token: 0x060049E7 RID: 18919 RVA: 0x001D469C File Offset: 0x001D289C
	internal static bool 2()
	{
		try
		{
			return 1562.GetSystemMetrics(86) != 0;
		}
		catch
		{
		}
		return false;
	}

	// Token: 0x060049E8 RID: 18920 RVA: 0x001D46CC File Offset: 0x001D28CC
	internal static bool 3()
	{
		try
		{
			return 1562.2() && 1562.GetSystemMetrics(8195) == 0;
		}
		catch
		{
		}
		return false;
	}

	// Token: 0x060049E9 RID: 18921 RVA: 0x001D470C File Offset: 0x001D290C
	internal override bool Initialize()
	{
		if (1181.1())
		{
			return false;
		}
		try
		{
			if (!this.1)
			{
				this.4 = new RealTimeStylus(1662.11.4().GetWindowHandle(), false);
				1560 item = new 1560(this);
				this.4.AsyncPluginCollection.Add(item);
				this.4.Enabled = 1304.125.1();
				this.1 = true;
				return true;
			}
		}
		catch (Exception)
		{
			1763.4("Tablet initialisation failed.");
		}
		return false;
	}

	// Token: 0x060049EA RID: 18922 RVA: 0x001D47A0 File Offset: 0x001D29A0
	internal override void Dispose()
	{
		this.1(false);
		this.4.Dispose();
	}

	// Token: 0x060049EB RID: 18923 RVA: 0x001D47B4 File Offset: 0x001D29B4
	internal override void Update(bool 1)
	{
		if (2486.14 && 1304.104)
		{
			this.2 = false;
			return;
		}
		if (this.2)
		{
			1555.3(199.Pressed);
			this.2 = false;
			return;
		}
		if (this.3 == 199.Pressed)
		{
			1555.3(this.3);
		}
	}

	// Token: 0x060049EC RID: 18924 RVA: 0x0000FF75 File Offset: 0x0000E175
	internal override bool IsActive()
	{
		return false;
	}

	// Token: 0x060049ED RID: 18925 RVA: 0x0001702D File Offset: 0x0001522D
	internal override int GetPriority()
	{
		return 1;
	}

	// Token: 0x04003701 RID: 14081
	internal bool 1;

	// Token: 0x04003702 RID: 14082
	internal bool 2;

	// Token: 0x04003703 RID: 14083
	internal 199 3;

	// Token: 0x04003704 RID: 14084
	private RealTimeStylus 4;
}
