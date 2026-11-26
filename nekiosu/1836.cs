using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows.Forms;
using OpenTK.Graphics;

// Token: 0x02000897 RID: 2199
public sealed class 1836 : 1802
{
	// Token: 0x06003F13 RID: 16147 RVA: 0x00187648 File Offset: 0x00185848
	public 1836(1803 1, GraphicsContextFlags 2)
	{
		1836.1838 CS_0024_003C_003E8__locals2 = new 1836.1838();
		this.8 = 1;
		base.2(new 1480(2));
		this.9().2(new EventHandler(base.5));
		this.9().3(new EventHandler(base.6));
		CS_0024_003C_003E8__locals2.1 = this.9().GetWindowHandle();
		this.2 = new 1314<bool>(() => 1836.GetForegroundWindow().Equals(CS_0024_003C_003E8__locals2.1), 50, true);
	}

	// Token: 0x06003F14 RID: 16148 RVA: 0x001876DD File Offset: 0x001858DD
	public override 1379 GetGLWindow()
	{
		return this.9().10();
	}

	// Token: 0x06003F15 RID: 16149 RVA: 0x001876EA File Offset: 0x001858EA
	public 1480 9()
	{
		return base.1() as 1480;
	}

	// Token: 0x06003F16 RID: 16150 RVA: 0x001876F8 File Offset: 0x001858F8
	private void 10(object 1, EventArgs 2)
	{
		1836.1837 3;
		do
		{
			if (this.7)
			{
				this.9().11();
			}
			else
			{
				base.8(1, 2);
			}
		}
		while (!1836.PeekMessage(out 3, IntPtr.Zero, 0U, 0U, 0U));
	}

	// Token: 0x06003F17 RID: 16151 RVA: 0x00187733 File Offset: 0x00185933
	internal override void SetFlag10615_13769()
	{
		this.7 = true;
	}

	// Token: 0x06003F18 RID: 16152 RVA: 0x0018773C File Offset: 0x0018593C
	internal override void RunMessageLoop()
	{
		Exception ex = null;
		try
		{
			Application.Idle += this.10;
			Application.Run(this.9().10());
		}
		catch (OutOfMemoryException ex)
		{
		}
		finally
		{
			Application.Idle -= this.10;
			if (ex == null || !(ex is OutOfMemoryException))
			{
				base.7(this, null);
			}
		}
	}

	// Token: 0x06003F19 RID: 16153
	[DllImport("user32.dll")]
	private static extern IntPtr GetForegroundWindow();

	// Token: 0x06003F1A RID: 16154
	[SuppressUnmanagedCodeSecurity]
	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool PeekMessage(out 1836.1837 1, IntPtr 2, uint 3, uint 4, uint 5);

	// Token: 0x04002E1E RID: 11806
	private new bool 7;

	// Token: 0x04002E1F RID: 11807
	private new 1803 8;

	// Token: 0x02000898 RID: 2200
	public enum 1839 : uint
	{

	}

	// Token: 0x02000899 RID: 2201
	public sealed class 1838
	{
		// Token: 0x04002E21 RID: 11809
		public IntPtr 1;
	}

	// Token: 0x0200089A RID: 2202
	public struct 1837
	{
		// Token: 0x04002E22 RID: 11810
		public IntPtr 1;

		// Token: 0x04002E23 RID: 11811
		public 1836.1839 2;

		// Token: 0x04002E24 RID: 11812
		public IntPtr 3;

		// Token: 0x04002E25 RID: 11813
		public IntPtr 4;

		// Token: 0x04002E26 RID: 11814
		public uint 5;

		// Token: 0x04002E27 RID: 11815
		public Point 6;
	}
}
