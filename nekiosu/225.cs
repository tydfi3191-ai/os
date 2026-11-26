using System;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;

// Token: 0x020003B9 RID: 953
[242(1)]
[ComVisible(false)]
[241(0)]
public class 225 : 233
{
	// Token: 0x06001D85 RID: 7557 RVA: 0x00074328 File Offset: 0x00072528
	public 225(225 1) : base(1, null)
	{
	}

	// Token: 0x06001D86 RID: 7558 RVA: 0x00074332 File Offset: 0x00072532
	internal 225(225 1, [241(2)] 479 2) : base(1, 2)
	{
	}

	// Token: 0x06001D87 RID: 7559 RVA: 0x0007433C File Offset: 0x0007253C
	[242(2)]
	public 225(object 1) : base(1, 705.Raw)
	{
	}

	// Token: 0x06001D88 RID: 7560 RVA: 0x00074348 File Offset: 0x00072548
	public static 225 Create(139 1)
	{
		StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture);
		225 result;
		try
		{
			168 2 = new 168(stringWriter);
			try
			{
				2.WriteToken(1);
				result = new 225(stringWriter.ToString());
			}
			finally
			{
				((IDisposable)2).Dispose();
			}
		}
		finally
		{
			((IDisposable)stringWriter).Dispose();
		}
		return result;
	}

	// Token: 0x06001D89 RID: 7561 RVA: 0x000743A8 File Offset: 0x000725A8
	internal override 226 Method14299([241(2)] 479 1)
	{
		return new 225(this, 1);
	}
}
