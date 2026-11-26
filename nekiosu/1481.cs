using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

// Token: 0x02000B00 RID: 2816
public sealed class 1481 : LinkLabel
{
	// Token: 0x06004E58 RID: 20056
	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr LoadCursor(IntPtr 1, int 2);

	// Token: 0x06004E59 RID: 20057 RVA: 0x001EFB5B File Offset: 0x001EDD5B
	protected override void OnMouseMove(MouseEventArgs 1)
	{
		base.OnMouseMove(1);
		if (base.OverrideCursor == Cursors.Hand)
		{
			base.OverrideCursor = new Cursor(1481.LoadCursor(IntPtr.Zero, 32649));
		}
	}
}
