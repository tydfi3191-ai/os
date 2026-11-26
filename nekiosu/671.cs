using System;
using System.Globalization;
using System.Runtime.Serialization;

// Token: 0x02000195 RID: 405
[242(1)]
[241(0)]
public sealed class 671 : IFormatterConverter
{
	// Token: 0x06000D2C RID: 3372 RVA: 0x0002E5C5 File Offset: 0x0002C7C5
	public 671(161 1, 515 2, [241(2)] 666 3)
	{
		756.Method12216(1, "reader");
		756.Method12216(2, "contract");
		this.jsonSerializerInternalReader2 = 1;
		this._recoveredType10437864 = 2;
		this._recoveredType17827865 = 3;
	}

	// Token: 0x06000D2D RID: 3373 RVA: 0x0002E5F8 File Offset: 0x0002C7F8
	private T Method10008<[241(2)] T>(object 1)
	{
		756.Method12216(1, "value");
		return (T)((object)System.Convert.ChangeType(((233)1).Value, typeof(T), CultureInfo.InvariantCulture));
	}

	// Token: 0x06000D2E RID: 3374 RVA: 0x0002E62C File Offset: 0x0002C82C
	public object Convert(object 1, Type 2)
	{
		756.Method12216(1, "value");
		226 3 = 1 as 226;
		if (3 == null)
		{
			throw new ArgumentException("Value is not a JToken.", "#=zUkSU2UA=");
		}
		return this.jsonSerializerInternalReader2.Method11677(3, 2, this._recoveredType10437864, this._recoveredType17827865);
	}

	// Token: 0x06000D2F RID: 3375 RVA: 0x0002E678 File Offset: 0x0002C878
	public object Convert(object 1, TypeCode 2)
	{
		756.Method12216(1, "value");
		233 3 = 1 as 233;
		return System.Convert.ChangeType((3 != null) ? 3.Value : 1, 2, CultureInfo.InvariantCulture);
	}

	// Token: 0x06000D30 RID: 3376 RVA: 0x0002E6AE File Offset: 0x0002C8AE
	public bool ToBoolean(object 1)
	{
		return this.Method10008<bool>(1);
	}

	// Token: 0x06000D31 RID: 3377 RVA: 0x0002E6B7 File Offset: 0x0002C8B7
	public byte ToByte(object 1)
	{
		return this.Method10008<byte>(1);
	}

	// Token: 0x06000D32 RID: 3378 RVA: 0x0002E6C0 File Offset: 0x0002C8C0
	public char ToChar(object 1)
	{
		return this.Method10008<char>(1);
	}

	// Token: 0x06000D33 RID: 3379 RVA: 0x0002E6C9 File Offset: 0x0002C8C9
	public DateTime ToDateTime(object 1)
	{
		return this.Method10008<DateTime>(1);
	}

	// Token: 0x06000D34 RID: 3380 RVA: 0x0002E6D2 File Offset: 0x0002C8D2
	public decimal ToDecimal(object 1)
	{
		return this.Method10008<decimal>(1);
	}

	// Token: 0x06000D35 RID: 3381 RVA: 0x0002E6DB File Offset: 0x0002C8DB
	public double ToDouble(object 1)
	{
		return this.Method10008<double>(1);
	}

	// Token: 0x06000D36 RID: 3382 RVA: 0x0002E6E4 File Offset: 0x0002C8E4
	public short ToInt16(object 1)
	{
		return this.Method10008<short>(1);
	}

	// Token: 0x06000D37 RID: 3383 RVA: 0x0002E6ED File Offset: 0x0002C8ED
	public int ToInt32(object 1)
	{
		return this.Method10008<int>(1);
	}

	// Token: 0x06000D38 RID: 3384 RVA: 0x0002E6F6 File Offset: 0x0002C8F6
	public long ToInt64(object 1)
	{
		return this.Method10008<long>(1);
	}

	// Token: 0x06000D39 RID: 3385 RVA: 0x0002E6FF File Offset: 0x0002C8FF
	public sbyte ToSByte(object 1)
	{
		return this.Method10008<sbyte>(1);
	}

	// Token: 0x06000D3A RID: 3386 RVA: 0x0002E708 File Offset: 0x0002C908
	public float ToSingle(object 1)
	{
		return this.Method10008<float>(1);
	}

	// Token: 0x06000D3B RID: 3387 RVA: 0x0002E711 File Offset: 0x0002C911
	public string ToString(object 1)
	{
		return this.Method10008<string>(1);
	}

	// Token: 0x06000D3C RID: 3388 RVA: 0x0002E71A File Offset: 0x0002C91A
	public ushort ToUInt16(object 1)
	{
		return this.Method10008<ushort>(1);
	}

	// Token: 0x06000D3D RID: 3389 RVA: 0x0002E723 File Offset: 0x0002C923
	public uint ToUInt32(object 1)
	{
		return this.Method10008<uint>(1);
	}

	// Token: 0x06000D3E RID: 3390 RVA: 0x0002E72C File Offset: 0x0002C92C
	public ulong ToUInt64(object 1)
	{
		return this.Method10008<ulong>(1);
	}

	// Token: 0x04000664 RID: 1636
	private readonly 161 jsonSerializerInternalReader2;

	// Token: 0x04000665 RID: 1637
	private readonly 515 _recoveredType10437864;

	// Token: 0x04000666 RID: 1638
	[241(2)]
	private readonly 666 _recoveredType17827865;
}
