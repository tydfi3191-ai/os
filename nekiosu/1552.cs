using System;
using System.Runtime.InteropServices;

// Token: 0x02000A5E RID: 2654
[ComVisible(false)]
public static class 1552
{
	// Token: 0x06004959 RID: 18777
	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool GetKeyboardState(byte[] 1);

	// Token: 0x0600495A RID: 18778 RVA: 0x001D26A4 File Offset: 0x001D08A4
	public static 1087 1()
	{
		1087 result;
		if (263.4(out result))
		{
			return result;
		}
		1087 result2 = default(1087);
		byte[] array = new byte[256];
		1552.GetKeyboardState(array);
		int num = 0;
		do
		{
			if ((array[num] & 128) != 0)
			{
				result2.1(num);
			}
			num++;
		}
		while (num < 256);
		return result2;
	}
}
