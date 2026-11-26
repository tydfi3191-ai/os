using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

// Token: 0x02000018 RID: 24
[SuppressUnmanagedCodeSecurity]
public sealed class 542
{
	// Token: 0x0600007A RID: 122 RVA: 0x00003D50 File Offset: 0x00001F50
	public 542(IntPtr 1)
	{
		if (Marshal.PtrToStringAnsi(1, 3) == "ID3")
		{
			this.number3 += 3;
			this.byteValue4 = Marshal.ReadByte(1, this.number3);
			this.number3++;
			this.byteValue5 = Marshal.ReadByte(1, this.number3);
			this.number3++;
			int num = (int)Marshal.ReadByte(1, this.number3);
			this.number3++;
			int num2 = this.Method6866(1, this.number3);
			this.number3 += 4;
			bool flag = (num & 64) > 0;
			int num3 = 0;
			if (flag)
			{
				num3 = this.Method6866(1, this.number3);
			}
			this.byteArray2 = new byte[num2 + 10];
			Marshal.Copy(1, this.byteArray2, 0, num2 + 10);
			this.stream = new MemoryStream(this.byteArray2);
			this.stream.Position = (long)(10 + num3);
			int num4 = num2 + 10;
			this.number2 = num4 - 10;
		}
		else
		{
			this.byteValue4 = this.byteValue2;
			this.byteValue5 = this.byteValue3;
			this.stream = null;
		}
		this.text5 = null;
		this.value2 = null;
	}

	// Token: 0x0600007B RID: 123 RVA: 0x00003E9B File Offset: 0x0000209B
	public void Method6852()
	{
		if (this.stream != null)
		{
			this.stream.Close();
		}
	}

	// Token: 0x0600007C RID: 124 RVA: 0x00003EB0 File Offset: 0x000020B0
	private Encoding Method6853(byte 1)
	{
		Encoding result;
		switch (1)
		{
		case 1:
			result = Encoding.Unicode;
			break;
		case 2:
			result = Encoding.BigEndianUnicode;
			break;
		case 3:
			result = Encoding.UTF8;
			break;
		default:
			result = Encoding.GetEncoding(1252);
			break;
		}
		return result;
	}

	// Token: 0x0600007D RID: 125 RVA: 0x00003EF7 File Offset: 0x000020F7
	public string GetText5438_6854()
	{
		return this.text5;
	}

	// Token: 0x0600007E RID: 126 RVA: 0x00003EFF File Offset: 0x000020FF
	public object GetValue5439_6855()
	{
		return this.value2;
	}

	// Token: 0x0600007F RID: 127 RVA: 0x00003F08 File Offset: 0x00002108
	public bool Method6856()
	{
		this.text5 = null;
		this.value2 = null;
		if (this.stream == null)
		{
			return false;
		}
		if (this.stream.Position > (long)this.number2)
		{
			return false;
		}
		this.text5 = this.Method6858();
		int num = this.Method6859();
		if (this.byteValue4 > 2)
		{
			this.Method6857();
		}
		if (num == 0)
		{
			this.value2 = string.Empty;
		}
		else
		{
			this.value2 = this.Method6860(num);
		}
		return true;
	}

	// Token: 0x06000080 RID: 128 RVA: 0x00003F84 File Offset: 0x00002184
	private short Method6857()
	{
		int num = this.stream.ReadByte();
		int num2 = this.stream.ReadByte();
		return (short)(num << 8 | num2);
	}

	// Token: 0x06000081 RID: 129 RVA: 0x00003FB0 File Offset: 0x000021B0
	private string Method6858()
	{
		int num = 4;
		if (this.byteValue4 == 2)
		{
			num = 3;
		}
		byte[] array = new byte[num];
		this.stream.Read(array, 0, num);
		return Encoding.ASCII.GetString(array, 0, num).TrimEnd(new char[1]);
	}

	// Token: 0x06000082 RID: 130 RVA: 0x00003FF8 File Offset: 0x000021F8
	private int Method6859()
	{
		if (this.byteValue4 == 4)
		{
			return this.Method6866();
		}
		if (this.byteValue4 == 3)
		{
			return this.Method6863();
		}
		if (this.byteValue4 != 2)
		{
			throw new NotSupportedException("Unsupported ID3v2 version detected. Don't know how to deal with this version.");
		}
		return this.Method6861();
	}

	// Token: 0x06000083 RID: 131 RVA: 0x00004034 File Offset: 0x00002234
	private object Method6860(int 1)
	{
		byte[] array = new byte[1];
		this.stream.Read(array, 0, 1);
		if (this.text5 == "COM" || this.text5 == "COMM" || this.text5 == "USER" || this.text5 == "ULT" || this.text5 == "USLT")
		{
			Encoding encoding = this.Method6853(array[0]);
			int num = 4;
			if (array[0] == 1 && 1 > 6)
			{
				if (array[num + 1] == 254 && array[num + 2] == 255)
				{
					encoding = Encoding.BigEndianUnicode;
					num += 2;
				}
				else if (array[num + 1] == 255 && array[num + 2] == 254)
				{
					encoding = Encoding.Unicode;
					num += 2;
				}
			}
			string text = encoding.GetString(array, num, 1 - num).TrimEnd(new char[1]);
			string[] array2 = text.Split(new char[1]);
			if (array2 != null && array2.Length > 1)
			{
				text = ((array2[0].Trim().Length <= 0) ? array2[1].Trim() : (array2[0].Trim() + ":" + array2[1].Trim()));
			}
			return text.Trim();
		}
		if (this.text5 == "WXXX" || this.text5 == "WXX" || this.text5 == "TXXX" || this.text5 == "TXX")
		{
			Encoding encoding2 = this.Method6853(array[0]);
			int num2 = 1;
			if (array[0] == 1 && 1 > 6)
			{
				if (array[num2 + 1] == 254 && array[num2 + 2] == 255)
				{
					encoding2 = Encoding.BigEndianUnicode;
					num2 += 2;
				}
				else if (array[num2 + 1] == 255 && array[num2 + 2] == 254)
				{
					encoding2 = Encoding.Unicode;
					num2 += 2;
				}
			}
			string text2 = encoding2.GetString(array, num2, 1 - num2).TrimEnd(new char[1]);
			string[] array3 = text2.Split(new char[1]);
			if (array3 != null && array3.Length > 1)
			{
				text2 = ((array3[0].Trim().Length <= 0) ? array3[1].Trim() : (array3[0].Trim() + ":" + array3[1].Trim()));
			}
			return text2.Trim();
		}
		if (this.text5[0] == 'T')
		{
			Encoding encoding3 = this.Method6853(array[0]);
			int num3 = 1;
			if (array[0] == 1 && 1 > 3)
			{
				if (array[1] == 254 && array[2] == 255)
				{
					encoding3 = Encoding.BigEndianUnicode;
					num3 = 3;
				}
				else if (array[1] == 255 && array[2] == 254)
				{
					encoding3 = Encoding.Unicode;
					num3 = 3;
				}
			}
			return encoding3.GetString(array, num3, 1 - num3).TrimEnd(new char[1]).Trim();
		}
		if (this.text5[0] == 'W')
		{
			string text3 = Encoding.ASCII.GetString(array, 0, 1).TrimEnd(new char[1]).TrimEnd(new char[1]);
			string[] array4 = text3.Split(new char[1]);
			if (array4 != null && array4.Length > 1)
			{
				text3 = array4[0].Trim();
			}
			return text3.Trim();
		}
		if (!(this.text5 == "UFI") && !(this.text5 == "LNK") && !(this.text5 == "UFID") && !(this.text5 == "LINK"))
		{
			return array;
		}
		string text4 = Encoding.ASCII.GetString(array, 0, 1).TrimEnd(new char[1]);
		string[] array5 = text4.Split(new char[1]);
		if (array5 != null && array5.Length > 1)
		{
			text4 = ((array5[0].Trim().Length <= 0) ? array5[1].Trim() : (array5[0].Trim() + ":" + array5[1].Trim()));
		}
		return text4.Trim();
	}

	// Token: 0x06000084 RID: 132 RVA: 0x00004454 File Offset: 0x00002654
	private int Method6861()
	{
		byte[] array = new byte[3];
		this.stream.Read(array, 0, 3);
		return (int)array[0] << 16 | (int)array[1] << 8 | (int)array[2];
	}

	// Token: 0x06000085 RID: 133 RVA: 0x00004488 File Offset: 0x00002688
	private int Method6861(IntPtr 1, int 2)
	{
		byte[] array = new byte[]
		{
			Marshal.ReadByte(1, 2),
			Marshal.ReadByte(1, 2 + 1),
			Marshal.ReadByte(1, 2 + 2)
		};
		return (int)array[0] << 16 | (int)array[1] << 8 | (int)array[2];
	}

	// Token: 0x06000086 RID: 134 RVA: 0x000044D0 File Offset: 0x000026D0
	private int Method6863()
	{
		byte[] array = new byte[4];
		this.stream.Read(array, 0, 4);
		return (int)array[0] << 24 | (int)array[1] << 16 | (int)array[2] << 8 | (int)array[3];
	}

	// Token: 0x06000087 RID: 135 RVA: 0x0000450C File Offset: 0x0000270C
	private int Method6863(IntPtr 1, int 2)
	{
		byte[] array = new byte[]
		{
			Marshal.ReadByte(1, 2),
			Marshal.ReadByte(1, 2 + 1),
			Marshal.ReadByte(1, 2 + 2),
			Marshal.ReadByte(1, 2 + 3)
		};
		return (int)array[0] << 24 | (int)array[1] << 16 | (int)array[2] << 8 | (int)array[3];
	}

	// Token: 0x06000088 RID: 136 RVA: 0x00004568 File Offset: 0x00002768
	private string Method6865(IntPtr 1)
	{
		byte[] array = new byte[3];
		this.stream.Read(array, 0, 3);
		return Encoding.ASCII.GetString(array, 0, 3);
	}

	// Token: 0x06000089 RID: 137 RVA: 0x00004598 File Offset: 0x00002798
	private int Method6866()
	{
		byte[] array = new byte[4];
		this.stream.Read(array, 0, 4);
		if ((array[0] & 128) != 0 || (array[1] & 128) != 0 || (array[2] & 128) != 0 || (array[3] & 128) != 0)
		{
			throw new FormatException("Found invalid syncsafe integer");
		}
		return (int)array[0] << 21 | (int)array[1] << 14 | (int)array[2] << 7 | (int)array[3];
	}

	// Token: 0x0600008A RID: 138 RVA: 0x0000460C File Offset: 0x0000280C
	private int Method6866(IntPtr 1, int 2)
	{
		byte[] array = new byte[]
		{
			Marshal.ReadByte(1, 2),
			Marshal.ReadByte(1, 2 + 1),
			Marshal.ReadByte(1, 2 + 2),
			Marshal.ReadByte(1, 2 + 3)
		};
		if ((array[0] & 128) != 0 || (array[1] & 128) != 0 || (array[2] & 128) != 0 || (array[3] & 128) != 0)
		{
			throw new FormatException("Found invalid syncsafe integer");
		}
		return (int)array[0] << 21 | (int)array[1] << 14 | (int)array[2] << 7 | (int)array[3];
	}

	// Token: 0x0600008B RID: 139 RVA: 0x0000469C File Offset: 0x0000289C
	private string Method6868(byte[] 1, ref int 2)
	{
		StringBuilder stringBuilder = new StringBuilder();
		try
		{
			char value;
			while ((value = (char)1[2]) != '\0')
			{
				stringBuilder.Append(value);
				2++;
			}
		}
		catch
		{
		}
		return stringBuilder.ToString();
	}

	// Token: 0x0600008C RID: 140 RVA: 0x000046E4 File Offset: 0x000028E4
	private string Method6868(byte[] 1, ref int 2, Encoding 3)
	{
		string result = string.Empty;
		try
		{
			if (1[0] == 1)
			{
				if (1[2] == 254 && 1[2 + 1] == 255)
				{
					3 = Encoding.BigEndianUnicode;
				}
				else if (1[2] == 255 && 1[2 + 1] == 254)
				{
					3 = Encoding.Unicode;
				}
			}
			int num = 1;
			if (1[0] == 1 || 1[0] == 2)
			{
				num = 2;
			}
			int num2 = 2;
			for (;;)
			{
				if (num != 1)
				{
					if (num == 2)
					{
						if (1[num2] == 0 && 1[num2 + 1] == 0)
						{
							break;
						}
						num2++;
					}
				}
				else
				{
					if (1[num2] == 0)
					{
						goto IL_8C;
					}
					num2++;
				}
			}
			num2++;
			IL_8C:
			result = 3.GetString(1, 2, num2 - 2 + 1 - num);
			2 = num2;
		}
		catch
		{
		}
		return result;
	}

	// Token: 0x0600008D RID: 141 RVA: 0x000047A8 File Offset: 0x000029A8
	public byte GetByte5441_6870()
	{
		return this.byteValue4;
	}

	// Token: 0x0600008E RID: 142 RVA: 0x000047B0 File Offset: 0x000029B0
	public byte GetByte5442_6871()
	{
		return this.byteValue5;
	}

	// Token: 0x04000048 RID: 72
	private byte[] byteArray2;

	// Token: 0x04000049 RID: 73
	private byte byteValue2 = 3;

	// Token: 0x0400004A RID: 74
	private byte byteValue3;

	// Token: 0x0400004B RID: 75
	private string text5;

	// Token: 0x0400004C RID: 76
	private object value2;

	// Token: 0x0400004D RID: 77
	private int number2;

	// Token: 0x0400004E RID: 78
	private byte byteValue4;

	// Token: 0x0400004F RID: 79
	private byte byteValue5;

	// Token: 0x04000050 RID: 80
	private int number3;

	// Token: 0x04000051 RID: 81
	private Stream stream;
}
