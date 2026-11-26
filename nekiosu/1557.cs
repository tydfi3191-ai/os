using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

// Token: 0x02000A64 RID: 2660
public sealed class 1557 : 1553
{
	// Token: 0x060049A9 RID: 18857 RVA: 0x001D3B64 File Offset: 0x001D1D64
	public void 6()
	{
		if (this.12)
		{
			return;
		}
		try
		{
			1095 <<EMPTY_NAME>> = this.8();
			1480 2 = 1662.11.4() as 1480;
			<<EMPTY_NAME>>.3 = (1096)512;
			<<EMPTY_NAME>>.4 = 2.GetWindowHandle();
			1136.RegisterRawInputDevices(new 1095[]
			{
				<<EMPTY_NAME>>
			}, 1, sizeof(1095));
			this.12 = true;
		}
		catch
		{
		}
	}

	// Token: 0x060049AA RID: 18858 RVA: 0x001D3BE4 File Offset: 0x001D1DE4
	public void 7()
	{
		if (!this.12)
		{
			return;
		}
		try
		{
			1095 <<EMPTY_NAME>> = this.8();
			<<EMPTY_NAME>>.3 = (1096)1;
			<<EMPTY_NAME>>.4 = IntPtr.Zero;
			1136.RegisterRawInputDevices(new 1095[]
			{
				<<EMPTY_NAME>>
			}, 1, sizeof(1095));
			this.12 = false;
		}
		catch
		{
		}
	}

	// Token: 0x060049AB RID: 18859 RVA: 0x001D3C50 File Offset: 0x001D1E50
	private 1095 8()
	{
		return new 1095
		{
			1 = (1078)1,
			2 = (1077)6
		};
	}

	// Token: 0x060049AC RID: 18860 RVA: 0x001D3C76 File Offset: 0x001D1E76
	internal override void Dispose()
	{
		this.7();
		base.Dispose();
	}

	// Token: 0x060049AD RID: 18861
	[DllImport("user32.dll")]
	private static extern uint MapVirtualKey(uint 1, uint 2);

	// Token: 0x060049AE RID: 18862 RVA: 0x001D3C84 File Offset: 0x001D1E84
	public 1087 9()
	{
		1087 result = default(1087);
		for (int i = 0; i < this.11.Length; i++)
		{
			if (this.11[i])
			{
				result.1(i);
			}
		}
		return result;
	}

	// Token: 0x060049AF RID: 18863 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal override void Update(bool 1)
	{
	}

	// Token: 0x060049B0 RID: 18864 RVA: 0x0000FF75 File Offset: 0x0000E175
	internal override bool IsActive()
	{
		return false;
	}

	// Token: 0x060049B1 RID: 18865 RVA: 0x0001905A File Offset: 0x0001725A
	internal override int GetPriority()
	{
		return 2;
	}

	// Token: 0x040036F2 RID: 14066
	private Dictionary<uint, uint> 10 = new Dictionary<uint, uint>();

	// Token: 0x040036F3 RID: 14067
	private bool[] 11 = new bool[256];

	// Token: 0x040036F4 RID: 14068
	private bool 12;
}
