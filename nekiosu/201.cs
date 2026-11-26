using System;
using System.Globalization;
using System.Runtime.InteropServices;

// Token: 0x0200038C RID: 908
[ComVisible(false)]
[Serializable]
public struct 201
{
	// Token: 0x1700014A RID: 330
	// (get) Token: 0x06001C24 RID: 7204 RVA: 0x00072636 File Offset: 0x00070836
	public int ScrollWheelValue
	{
		get
		{
			return this.wheel;
		}
	}

	// Token: 0x1700014B RID: 331
	// (get) Token: 0x06001C25 RID: 7205 RVA: 0x0007263E File Offset: 0x0007083E
	public 199 XButton2
	{
		get
		{
			return this.xb2;
		}
	}

	// Token: 0x1700014C RID: 332
	// (get) Token: 0x06001C26 RID: 7206 RVA: 0x00072646 File Offset: 0x00070846
	public 199 XButton1
	{
		get
		{
			return this.xb1;
		}
	}

	// Token: 0x1700014D RID: 333
	// (get) Token: 0x06001C27 RID: 7207 RVA: 0x0007264E File Offset: 0x0007084E
	public 199 MiddleButton
	{
		get
		{
			return this.middle;
		}
	}

	// Token: 0x1700014E RID: 334
	// (get) Token: 0x06001C28 RID: 7208 RVA: 0x00072656 File Offset: 0x00070856
	public 199 RightButton
	{
		get
		{
			return this.right;
		}
	}

	// Token: 0x1700014F RID: 335
	// (get) Token: 0x06001C29 RID: 7209 RVA: 0x0007265E File Offset: 0x0007085E
	public 199 LeftButton
	{
		get
		{
			return this.left;
		}
	}

	// Token: 0x17000150 RID: 336
	// (get) Token: 0x06001C2A RID: 7210 RVA: 0x00072666 File Offset: 0x00070866
	public int Y
	{
		get
		{
			return this.y;
		}
	}

	// Token: 0x17000151 RID: 337
	// (get) Token: 0x06001C2B RID: 7211 RVA: 0x0007266E File Offset: 0x0007086E
	public int X
	{
		get
		{
			return this.x;
		}
	}

	// Token: 0x06001C2C RID: 7212 RVA: 0x00072678 File Offset: 0x00070878
	public override string ToString()
	{
		string text = string.Empty;
		if (this.left == 199.Pressed)
		{
			string str = (text.Length == 0) ? string.Empty : " ";
			text = text + str + "Left";
		}
		if (this.right == 199.Pressed)
		{
			string str2 = (text.Length == 0) ? string.Empty : " ";
			text = text + str2 + "Right";
		}
		if (this.middle == 199.Pressed)
		{
			string str3 = (text.Length == 0) ? string.Empty : " ";
			text = text + str3 + "Middle";
		}
		if (this.xb1 == 199.Pressed)
		{
			string str4 = (text.Length == 0) ? string.Empty : " ";
			text = text + str4 + "XButton1";
		}
		if (this.xb2 == 199.Pressed)
		{
			string str5 = (text.Length == 0) ? string.Empty : " ";
			text = text + str5 + "XButton2";
		}
		if (text.Length == 0)
		{
			text = "None";
		}
		object[] args = new object[]
		{
			this.x,
			this.y,
			text,
			this.wheel
		};
		return string.Format(CultureInfo.CurrentCulture, "{{X:{0} Y:{1} Buttons:{2} Wheel:{3}}}", args);
	}

	// Token: 0x06001C2D RID: 7213 RVA: 0x000727BC File Offset: 0x000709BC
	[return: MarshalAs(UnmanagedType.U1)]
	public override bool Equals(object 1)
	{
		if (1 == null)
		{
			return false;
		}
		if (1.GetType() != typeof(201))
		{
			return false;
		}
		201 2 = (201)1;
		return this == 2;
	}

	// Token: 0x06001C2E RID: 7214 RVA: 0x000727FC File Offset: 0x000709FC
	[return: MarshalAs(UnmanagedType.U1)]
	public unsafe static bool operator ==(201 1, 201 2)
	{
		uint num = (uint)sizeof(201);
		201* ptr = &2;
		201* ptr2 = &1;
		if (num == 0U)
		{
			goto IL_69;
		}
		sbyte b = *(sbyte*)ptr2;
		sbyte b2 = *(sbyte*)ptr;
		if (b >= b2)
		{
			while (b <= b2)
			{
				if (num == 1U)
				{
					goto IL_69;
				}
				num -= 1U;
				ptr2 += 1 / sizeof(201);
				ptr += 1 / sizeof(201);
				b = *(sbyte*)ptr2;
				b2 = *(sbyte*)ptr;
				if (b < b2)
				{
					break;
				}
			}
		}
		int num2 = 0;
		IL_62:
		return (byte)num2 > 0;
		IL_69:
		num2 = 1;
		goto IL_62;
	}

	// Token: 0x06001C2F RID: 7215 RVA: 0x00072876 File Offset: 0x00070A76
	[return: MarshalAs(UnmanagedType.U1)]
	public static bool operator !=(201 1, 201 2)
	{
		return !(1 == 2);
	}

	// Token: 0x04000DB0 RID: 3504
	internal int x;

	// Token: 0x04000DB1 RID: 3505
	internal int y;

	// Token: 0x04000DB2 RID: 3506
	internal 199 left;

	// Token: 0x04000DB3 RID: 3507
	internal 199 right;

	// Token: 0x04000DB4 RID: 3508
	internal 199 middle;

	// Token: 0x04000DB5 RID: 3509
	internal 199 xb1;

	// Token: 0x04000DB6 RID: 3510
	internal 199 xb2;

	// Token: 0x04000DB7 RID: 3511
	internal int wheel;
}
