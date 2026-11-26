using System;
using System.Drawing;
using System.Windows.Forms;

// Token: 0x02000929 RID: 2345
public static class 1705
{
	// Token: 0x0600429C RID: 17052 RVA: 0x0019F6D7 File Offset: 0x0019D8D7
	public static DialogResult 1(string 1)
	{
		return 1705.3(1, "nekiosu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
	}

	// Token: 0x0600429D RID: 17053 RVA: 0x0019F6E8 File Offset: 0x0019D8E8
	public static DialogResult 2(string 1, string 2, MessageBoxButtons 3)
	{
		return 1705.3(1, 2, 3, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
	}

	// Token: 0x0600429E RID: 17054 RVA: 0x0019F6F8 File Offset: 0x0019D8F8
	public static DialogResult 3(string 1, string 2, MessageBoxButtons 3, MessageBoxIcon 4, MessageBoxDefaultButton 5)
	{
		1726.14();
		Form form = new Form();
		form.ShowInTaskbar = false;
		form.Size = new Size(1, 1);
		form.StartPosition = FormStartPosition.Manual;
		Rectangle virtualScreen = SystemInformation.VirtualScreen;
		form.Location = new Point(virtualScreen.Bottom + 10, virtualScreen.Right + 10);
		form.Show();
		form.Focus();
		form.BringToFront();
		form.TopMost = true;
		DialogResult result = MessageBox.Show(form, 1, 2, 3, 4);
		form.Dispose();
		return result;
	}
}
