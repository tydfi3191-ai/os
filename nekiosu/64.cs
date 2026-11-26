using System;
using System.IO;

// Token: 0x020001FB RID: 507
[242(1)]
[241(0)]
public sealed class 64
{
	// Token: 0x0600100F RID: 4111 RVA: 0x00036846 File Offset: 0x00034A46
	public 64(TextWriter 1)
	{
		756.Method12216(1, "writer");
		this.writer = 1;
	}

	// Token: 0x06001010 RID: 4112 RVA: 0x00036870 File Offset: 0x00034A70
	private void ValidateEncodeParameters(byte[] 1, int 2, int 3)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("#=zpMJwVYM=");
		}
		if (2 < 0)
		{
			throw new ArgumentOutOfRangeException("#=zEcSd6Vg=");
		}
		if (3 < 0)
		{
			throw new ArgumentOutOfRangeException("#=zW32YDQ0=");
		}
		if (3 > 1.Length - 2)
		{
			throw new ArgumentOutOfRangeException("#=zW32YDQ0=");
		}
	}

	// Token: 0x06001011 RID: 4113 RVA: 0x000368BC File Offset: 0x00034ABC
	public void Encode(byte[] 1, int 2, int 3)
	{
		this.ValidateEncodeParameters(1, 2, 3);
		if (this.leftOverBytesCount > 0)
		{
			if (this.EncodeLeftOverBytes(1, 2, ref 3))
			{
				return;
			}
			int 4 = Convert.ToBase64CharArray(this.leftOverBytes, 0, 3, this.charsLine, 0);
			this.WriteChars(this.charsLine, 0, 4);
		}
		this.StoreLeftOverBytes(1, 2, ref 3);
		int num = 2 + 3;
		int num2 = 57;
		while (2 < num)
		{
			if (2 + num2 > num)
			{
				num2 = num - 2;
			}
			int 5 = Convert.ToBase64CharArray(1, 2, num2, this.charsLine, 0);
			this.WriteChars(this.charsLine, 0, 5);
			2 += num2;
		}
	}

	// Token: 0x06001012 RID: 4114 RVA: 0x00036950 File Offset: 0x00034B50
	private void StoreLeftOverBytes(byte[] 1, int 2, ref int 3)
	{
		int num = 3 % 3;
		if (num > 0)
		{
			3 -= num;
			if (this.leftOverBytes == null)
			{
				this.leftOverBytes = new byte[3];
			}
			for (int i = 0; i < num; i++)
			{
				this.leftOverBytes[i] = 1[2 + 3 + i];
			}
		}
		this.leftOverBytesCount = num;
	}

	// Token: 0x06001013 RID: 4115 RVA: 0x000369A4 File Offset: 0x00034BA4
	private bool EncodeLeftOverBytes(byte[] 1, int 2, ref int 3)
	{
		int num = this.leftOverBytesCount;
		while (num < 3 && 3 > 0)
		{
			this.leftOverBytes[num++] = 1[2++];
			3--;
		}
		if (3 == 0 && num < 3)
		{
			this.leftOverBytesCount = num;
			return true;
		}
		return false;
	}

	// Token: 0x06001014 RID: 4116 RVA: 0x000369F0 File Offset: 0x00034BF0
	public void Flush()
	{
		if (this.leftOverBytesCount > 0)
		{
			int <<EMPTY_NAME>> = Convert.ToBase64CharArray(this.leftOverBytes, 0, this.leftOverBytesCount, this.charsLine, 0);
			this.WriteChars(this.charsLine, 0, <<EMPTY_NAME>>);
			this.leftOverBytesCount = 0;
		}
	}

	// Token: 0x06001015 RID: 4117 RVA: 0x00036A35 File Offset: 0x00034C35
	private void WriteChars(char[] 1, int 2, int 3)
	{
		this.writer.Write(1, 2, 3);
	}

	// Token: 0x040007D0 RID: 2000
	private readonly char[] charsLine = new char[76];

	// Token: 0x040007D1 RID: 2001
	private readonly TextWriter writer;

	// Token: 0x040007D2 RID: 2002
	[241(2)]
	private byte[] leftOverBytes;

	// Token: 0x040007D3 RID: 2003
	private int leftOverBytesCount;
}
