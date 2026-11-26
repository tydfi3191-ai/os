using System;
using System.Globalization;
using System.Runtime.InteropServices;

// Token: 0x020001C7 RID: 455
[ComVisible(false)]
[241(0)]
[242(1)]
public sealed class 788 : 601
{
	// Token: 0x06000E7F RID: 3711 RVA: 0x00030E59 File Offset: 0x0002F059
	public 788() : this(false)
	{
	}

	// Token: 0x06000E80 RID: 3712 RVA: 0x00030E62 File Offset: 0x0002F062
	public 788(bool 1)
	{
		this.SetFlag10068_12899(1);
	}

	// Token: 0x06000E81 RID: 3713 RVA: 0x00030E71 File Offset: 0x0002F071
	public bool GetFlag10068_12898()
	{
		return this.flag2;
	}

	// Token: 0x06000E82 RID: 3714 RVA: 0x00030E79 File Offset: 0x0002F079
	public void SetFlag10068_12899(bool 1)
	{
		this.flag2 = 1;
	}

	// Token: 0x06000E83 RID: 3715 RVA: 0x00030E84 File Offset: 0x0002F084
	public override void WriteJson(173 1, [241(2)] object 2, 158 3)
	{
		long num;
		if (2 is DateTime)
		{
			num = (long)(((DateTime)2).ToUniversalTime() - 788.dateTime2).TotalSeconds;
		}
		else
		{
			if (!(2 is DateTimeOffset))
			{
				throw new 364("Expected date object value.");
			}
			num = (long)(((DateTimeOffset)2).ToUniversalTime() - 788.dateTime2).TotalSeconds;
		}
		if (!this.GetFlag10068_12898() && num < 0L)
		{
			throw new 364("Cannot convert date value that is before Unix epoch of 00:00:00 UTC on 1 January 1970.");
		}
		1.WriteValue(num);
	}

	// Token: 0x06000E84 RID: 3716 RVA: 0x00030F18 File Offset: 0x0002F118
	[return: 241(2)]
	public override object ReadJson(139 1, Type 2, [241(2)] object 3, 158 4)
	{
		bool flag = 143.IsNullable(2);
		if (1.GetTokenType() == 216.Null)
		{
			if (!flag)
			{
				throw 364.Method1687(1, "Cannot convert null value to {0}.".Method6825(CultureInfo.InvariantCulture, 2));
			}
			return null;
		}
		else
		{
			long num;
			if (1.GetTokenType() == 216.Integer)
			{
				num = (long)1.GetValue();
			}
			else
			{
				if (1.GetTokenType() != 216.String)
				{
					throw 364.Method1687(1, "Unexpected token parsing date. Expected Integer or String, got {0}.".Method6825(CultureInfo.InvariantCulture, 1.GetTokenType()));
				}
				if (!long.TryParse((string)1.GetValue(), out num))
				{
					throw 364.Method1687(1, "Cannot convert invalid value to {0}.".Method6825(CultureInfo.InvariantCulture, 2));
				}
			}
			if (!this.GetFlag10068_12898() && num < 0L)
			{
				throw 364.Method1687(1, "Cannot convert value that is before Unix epoch of 00:00:00 UTC on 1 January 1970 to {0}.".Method6825(CultureInfo.InvariantCulture, 2));
			}
			DateTime dateTime = 788.dateTime2.AddSeconds((double)num);
			if ((flag ? Nullable.GetUnderlyingType(2) : 2) == typeof(DateTimeOffset))
			{
				return new DateTimeOffset(dateTime, TimeSpan.Zero);
			}
			return dateTime;
		}
	}

	// Token: 0x04000718 RID: 1816
	internal static readonly DateTime dateTime2 = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

	// Token: 0x04000719 RID: 1817
	private bool flag2;
}
