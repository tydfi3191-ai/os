using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading;
using System.Windows.Forms;

// Token: 0x0200091C RID: 2332
public sealed class 1695 : TextBox
{
	// Token: 0x06004261 RID: 16993
	[SuppressUnmanagedCodeSecurity]
	[DllImport("Imm32.dll")]
	private static extern IntPtr ImmGetContext(IntPtr 1);

	// Token: 0x06004262 RID: 16994
	[SuppressUnmanagedCodeSecurity]
	[DllImport("Imm32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern int ImmGetCompositionString(IntPtr 1, int 2, byte[] 3, int 4);

	// Token: 0x06004263 RID: 16995
	[SuppressUnmanagedCodeSecurity]
	[DllImport("Imm32.dll")]
	private static extern bool ImmReleaseContext(IntPtr 1, IntPtr 2);

	// Token: 0x06004264 RID: 16996
	[SuppressUnmanagedCodeSecurity]
	[DllImport("Imm32.dll", CharSet = CharSet.Auto)]
	public static extern uint ImmGetCandidateList(IntPtr 1, uint 2, IntPtr 3, uint 4);

	// Token: 0x06004265 RID: 16997 RVA: 0x0019DDE0 File Offset: 0x0019BFE0
	protected override void WndProc(ref Message 1)
	{
		int msg = 1.Msg;
		if (msg <= 123)
		{
			if (msg != 8)
			{
				if (msg != 123)
				{
					goto IL_2CA;
				}
				return;
			}
		}
		else if (msg != 260)
		{
			switch (msg)
			{
			case 269:
				this.1 = true;
				if (this.5 != null)
				{
					this.5(true);
				}
				base.Parent.Location = new Point(base.Parent.Location.X, base.Parent.Location.Y - 5000);
				goto IL_2CA;
			case 270:
				break;
			case 271:
			{
				bool flag = false;
				if ((int)1.LParam == 24600)
				{
					flag = true;
				}
				if (((int)1.LParam & 8) > 0)
				{
					IntPtr intPtr = 1695.ImmGetContext(base.Handle);
					int num = 1695.ImmGetCompositionString(intPtr, 8, null, 0);
					byte[] bytes = new byte[num];
					1695.ImmGetCompositionString(intPtr, 8, bytes, num);
					1695.ImmReleaseContext(base.Handle, intPtr);
					this.1(Encoding.Unicode.GetString(bytes));
				}
				if (flag)
				{
					return;
				}
				goto IL_2CA;
			}
			default:
				if (msg != 642)
				{
					goto IL_2CA;
				}
				switch (1.WParam.ToInt32())
				{
				case 3:
				case 5:
				{
					IntPtr intPtr2 = 1695.ImmGetContext(base.Handle);
					uint num2 = 1695.ImmGetCandidateList(intPtr2, 0U, IntPtr.Zero, 0U);
					this.3.Clear();
					if (num2 != 0U)
					{
						IntPtr intPtr3 = Marshal.AllocHGlobal((int)num2);
						num2 = 1695.ImmGetCandidateList(intPtr2, 0U, intPtr3, num2);
						1695.1696 2 = (1695.1696)Marshal.PtrToStructure(intPtr3, typeof(1695.1696));
						if (2.3 > 1U)
						{
							int num3 = (int)2.5;
							while ((long)num3 < (long)((ulong)2.3) && (long)num3 - (long)((ulong)2.5) <= (long)((ulong)(2.6 - 1U)))
							{
								int num4 = Marshal.ReadInt32(intPtr3, 24 + 4 * num3);
								string item = Marshal.PtrToStringUni((IntPtr)(intPtr3.ToInt32() + num4));
								this.3.Add(item);
								num3++;
							}
						}
						Marshal.FreeHGlobal(intPtr3);
					}
					1695.ImmReleaseContext(base.Handle, intPtr2);
					goto IL_2CA;
				}
				case 4:
					this.3.Clear();
					goto IL_2CA;
				default:
					goto IL_2CA;
				}
				break;
			}
		}
		else
		{
			if ((int)1.WParam == 121)
			{
				return;
			}
			goto IL_2CA;
		}
		this.1 = false;
		if (1.Msg == 270)
		{
			this.2 = 1662.33;
		}
		if (this.5 != null)
		{
			this.5(false);
		}
		base.Parent.Location = new Point(base.Parent.Location.X, base.Parent.Location.Y + 5000);
		IL_2CA:
		base.WndProc(ref 1);
	}

	// Token: 0x06004266 RID: 16998 RVA: 0x0019E0BE File Offset: 0x0019C2BE
	private void 1(string 1)
	{
		1188 2 = this.4;
		if (2 == null)
		{
			return;
		}
		2(1);
	}

	// Token: 0x06004267 RID: 16999 RVA: 0x0019E0D4 File Offset: 0x0019C2D4
	internal void 2(1188 1)
	{
		1188 2 = this.4;
		1188 3;
		do
		{
			3 = 2;
			1188 value = (1188)Delegate.Combine(3, 1);
			2 = Interlocked.CompareExchange<1188>(ref this.4, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x06004268 RID: 17000 RVA: 0x0019E10C File Offset: 0x0019C30C
	internal void 3(1184 1)
	{
		1184 2 = this.5;
		1184 3;
		do
		{
			3 = 2;
			1184 value = (1184)Delegate.Combine(3, 1);
			2 = Interlocked.CompareExchange<1184>(ref this.5, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x04003088 RID: 12424
	internal bool 1;

	// Token: 0x04003089 RID: 12425
	internal int 2;

	// Token: 0x0400308A RID: 12426
	internal List<string> 3 = new List<string>();

	// Token: 0x0400308B RID: 12427
	private 1188 4;

	// Token: 0x0400308C RID: 12428
	private 1184 5;

	// Token: 0x0200091D RID: 2333
	public struct 1696
	{
		// Token: 0x0400308D RID: 12429
		public uint 1;

		// Token: 0x0400308E RID: 12430
		public uint 2;

		// Token: 0x0400308F RID: 12431
		public uint 3;

		// Token: 0x04003090 RID: 12432
		public uint 4;

		// Token: 0x04003091 RID: 12433
		public uint 5;

		// Token: 0x04003092 RID: 12434
		public uint 6;

		// Token: 0x04003093 RID: 12435
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.U4)]
		public uint[] 7;
	}
}
