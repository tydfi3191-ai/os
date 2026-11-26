using System;
using System.Windows.Forms;
using OpenTK;
using OpenTK.Graphics;

// Token: 0x02000BEF RID: 3055
public sealed class 1125
{
	// Token: 0x0600536B RID: 21355 RVA: 0x0020AF34 File Offset: 0x00209134
	public 351 1(GraphicsMode 1, Control 2, GraphicsContextFlags 3)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("mode");
		}
		if (2 == null)
		{
			throw new ArgumentNullException("control");
		}
		if (Configuration.RunningOnSdl2)
		{
			return new 636(1, 2);
		}
		if (Configuration.RunningOnWindows)
		{
			return new 434(1, 2, 3);
		}
		if (Configuration.RunningOnMacOS)
		{
			return new 1129(1, 2);
		}
		if (Configuration.RunningOnX11)
		{
			return new 633(1, 2);
		}
		throw new PlatformNotSupportedException();
	}
}
