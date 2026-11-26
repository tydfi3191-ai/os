using System;
using System.Security;

// Token: 0x02000017 RID: 23
[SuppressUnmanagedCodeSecurity]
public sealed class 717
{
	// Token: 0x06000069 RID: 105 RVA: 0x000039C4 File Offset: 0x00001BC4
	public 717(int 1, string 2, 590 3, object 4)
	{
		this.number2 = 1;
		this.text2 = 2.TrimEnd(new char[1]);
		this._recoveredType14048766 = 3;
		switch (3)
		{
		case (590)0:
			this.value2 = Convert.ToUInt32(4);
			return;
		case (590)1:
			this.value2 = Convert.ToString(4).Trim();
			return;
		case (590)2:
			this.value2 = (byte[])4;
			return;
		case (590)3:
			this.value2 = Convert.ToBoolean(4);
			return;
		case (590)4:
			this.value2 = Convert.ToUInt64(4);
			return;
		case (590)5:
			this.value2 = Convert.ToUInt16(4);
			return;
		case (590)6:
			this.value2 = (Guid)4;
			return;
		default:
			throw new ArgumentException("Invalid data type", "type");
		}
	}

	// Token: 0x0600006A RID: 106 RVA: 0x00003AAD File Offset: 0x00001CAD
	public static explicit operator byte[](717 1)
	{
		if (1._recoveredType14048766 != (590)2)
		{
			throw new InvalidCastException("Tag can not be converted to a byte array.");
		}
		return (byte[])1.value2;
	}

	// Token: 0x0600006B RID: 107 RVA: 0x00003ACE File Offset: 0x00001CCE
	public static explicit operator string(717 1)
	{
		if (1._recoveredType14048766 != (590)1)
		{
			throw new InvalidCastException("Tag can not be converted to a string.");
		}
		return (string)1.value2;
	}

	// Token: 0x0600006C RID: 108 RVA: 0x00003AEF File Offset: 0x00001CEF
	public static explicit operator bool(717 1)
	{
		if (1._recoveredType14048766 != (590)3)
		{
			throw new InvalidCastException("Tag can not be converted to a bool.");
		}
		return (bool)1.value2;
	}

	// Token: 0x0600006D RID: 109 RVA: 0x00003B10 File Offset: 0x00001D10
	public static explicit operator Guid(717 1)
	{
		if (1._recoveredType14048766 != (590)6)
		{
			throw new InvalidCastException("Tag can not be converted to a Guid.");
		}
		return (Guid)1.value2;
	}

	// Token: 0x0600006E RID: 110 RVA: 0x00003B31 File Offset: 0x00001D31
	public static explicit operator int(717 1)
	{
		return (int)((ulong)1);
	}

	// Token: 0x0600006F RID: 111 RVA: 0x00003B3A File Offset: 0x00001D3A
	public static explicit operator long(717 1)
	{
		return (long)((ulong)1);
	}

	// Token: 0x06000070 RID: 112 RVA: 0x00003B42 File Offset: 0x00001D42
	public static explicit operator ushort(717 1)
	{
		return (ushort)((ulong)1);
	}

	// Token: 0x06000071 RID: 113 RVA: 0x00003B4B File Offset: 0x00001D4B
	public static explicit operator uint(717 1)
	{
		return (uint)((ulong)1);
	}

	// Token: 0x06000072 RID: 114 RVA: 0x00003B54 File Offset: 0x00001D54
	public static explicit operator ulong(717 1)
	{
		590 recoveredType = 1._recoveredType14048766;
		if (recoveredType == (590)0 || recoveredType - (590)4 <= 1)
		{
			return (ulong)1.value2;
		}
		throw new InvalidCastException("Tag can not be converted to a number.");
	}

	// Token: 0x06000073 RID: 115 RVA: 0x00003B88 File Offset: 0x00001D88
	public override string ToString()
	{
		return string.Format("{0}={1}", this.text2, this.Method11137());
	}

	// Token: 0x06000074 RID: 116 RVA: 0x00003BA0 File Offset: 0x00001DA0
	public 590 GetRecoveredType14048766_11132()
	{
		return this._recoveredType14048766;
	}

	// Token: 0x06000075 RID: 117 RVA: 0x00003BA8 File Offset: 0x00001DA8
	public int GetNumber8767_11133()
	{
		return this.number2;
	}

	// Token: 0x06000076 RID: 118 RVA: 0x00003BB0 File Offset: 0x00001DB0
	public string GetText8768_11134()
	{
		return this.text2;
	}

	// Token: 0x06000077 RID: 119 RVA: 0x00003BB8 File Offset: 0x00001DB8
	public object GetValue8769_11135()
	{
		return this.value2;
	}

	// Token: 0x06000078 RID: 120 RVA: 0x00003BC0 File Offset: 0x00001DC0
	public void Method11136(object 1)
	{
		switch (this._recoveredType14048766)
		{
		case (590)0:
			this.value2 = (uint)1;
			return;
		case (590)1:
			this.value2 = (string)1;
			return;
		case (590)2:
			this.value2 = (byte[])1;
			return;
		case (590)3:
			this.value2 = (bool)1;
			return;
		case (590)4:
			this.value2 = (ulong)1;
			return;
		case (590)5:
			this.value2 = (ushort)1;
			return;
		case (590)6:
			this.value2 = (Guid)1;
			return;
		default:
			return;
		}
	}

	// Token: 0x06000079 RID: 121 RVA: 0x00003C6C File Offset: 0x00001E6C
	public string Method11137()
	{
		string empty = string.Empty;
		switch (this._recoveredType14048766)
		{
		case (590)0:
			return ((uint)this.value2).ToString();
		case (590)1:
			return (string)this.value2;
		case (590)2:
			return "[" + ((byte[])this.value2).Length.ToString() + " bytes]";
		case (590)3:
			return ((bool)this.value2).ToString();
		case (590)4:
			return ((ulong)this.value2).ToString();
		case (590)5:
			return ((ushort)this.value2).ToString();
		case (590)6:
			return ((Guid)this.value2).ToString();
		default:
			return empty;
		}
	}

	// Token: 0x04000044 RID: 68
	private 590 _recoveredType14048766;

	// Token: 0x04000045 RID: 69
	private int number2;

	// Token: 0x04000046 RID: 70
	private string text2;

	// Token: 0x04000047 RID: 71
	private object value2;
}
