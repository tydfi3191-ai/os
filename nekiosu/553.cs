using System;
using System.Globalization;
using System.Runtime.InteropServices;

// Token: 0x0200015C RID: 348
[ComVisible(false)]
[242(1)]
[241(0)]
public sealed class 553 : 601
{
	// Token: 0x17000099 RID: 153
	// (get) Token: 0x06000BF3 RID: 3059 RVA: 0x0002B2A4 File Offset: 0x000294A4
	// (set) Token: 0x06000BF4 RID: 3060 RVA: 0x0002B2B5 File Offset: 0x000294B5
	[241(2)]
	public string Text5682
	{
		[242(2)]
		get
		{
			return this.text2 ?? string.Empty;
		}
		[242(2)]
		set
		{
			this.text2 = (538.Method6824(value) ? null : value);
		}
	}

	// Token: 0x06000BF5 RID: 3061 RVA: 0x0002B2C9 File Offset: 0x000294C9
	public DateTimeStyles GetDateTimeStyles5679_7214()
	{
		return this.dateTimeStyles2;
	}

	// Token: 0x06000BF6 RID: 3062 RVA: 0x0002B2D1 File Offset: 0x000294D1
	public void SetDateTimeStyles5679_7215(DateTimeStyles 1)
	{
		this.dateTimeStyles2 = 1;
	}

	// Token: 0x06000BF7 RID: 3063 RVA: 0x0002B2DA File Offset: 0x000294DA
	public CultureInfo Method7216()
	{
		return this.cultureInfo2 ?? CultureInfo.CurrentCulture;
	}

	// Token: 0x06000BF8 RID: 3064 RVA: 0x0002B2EB File Offset: 0x000294EB
	public void SetCultureInfo5681_7217(CultureInfo 1)
	{
		this.cultureInfo2 = 1;
	}

	// Token: 0x06000BF9 RID: 3065 RVA: 0x0002B2F4 File Offset: 0x000294F4
	public override void WriteJson(173 1, [241(2)] object 2, 158 3)
	{
		string 4;
		if (2 is DateTime)
		{
			DateTime dateTime = (DateTime)2;
			if ((this.dateTimeStyles2 & DateTimeStyles.AdjustToUniversal) == DateTimeStyles.AdjustToUniversal || (this.dateTimeStyles2 & DateTimeStyles.AssumeUniversal) == DateTimeStyles.AssumeUniversal)
			{
				dateTime = dateTime.ToUniversalTime();
			}
			4 = dateTime.ToString(this.text2 ?? "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK", this.Method7216());
		}
		else
		{
			if (!(2 is DateTimeOffset))
			{
				throw new 364("Unexpected value when converting date. Expected DateTime or DateTimeOffset, got {0}.".Method6825(CultureInfo.InvariantCulture, 143.GetObjectType(2)));
			}
			DateTimeOffset dateTimeOffset = (DateTimeOffset)2;
			if ((this.dateTimeStyles2 & DateTimeStyles.AdjustToUniversal) == DateTimeStyles.AdjustToUniversal || (this.dateTimeStyles2 & DateTimeStyles.AssumeUniversal) == DateTimeStyles.AssumeUniversal)
			{
				dateTimeOffset = dateTimeOffset.ToUniversalTime();
			}
			4 = dateTimeOffset.ToString(this.text2 ?? "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK", this.Method7216());
		}
		1.WriteValue(4);
	}

	// Token: 0x06000BFA RID: 3066 RVA: 0x0002B3C4 File Offset: 0x000295C4
	[return: 241(2)]
	public override object ReadJson(139 1, Type 2, [241(2)] object 3, 158 4)
	{
		bool flag = 143.IsNullableType(2);
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
			Type left = flag ? Nullable.GetUnderlyingType(2) : 2;
			if (1.GetTokenType() == 216.Date)
			{
				if (left == typeof(DateTimeOffset))
				{
					if (!(1.GetValue() is DateTimeOffset))
					{
						return new DateTimeOffset((DateTime)1.GetValue());
					}
					return 1.GetValue();
				}
				else
				{
					object value = 1.GetValue();
					if (value is DateTimeOffset)
					{
						return ((DateTimeOffset)value).DateTime;
					}
					return 1.GetValue();
				}
			}
			else
			{
				if (1.GetTokenType() != 216.String)
				{
					throw 364.Method1687(1, "Unexpected token parsing date. Expected String, got {0}.".Method6825(CultureInfo.InvariantCulture, 1.GetTokenType()));
				}
				object value2 = 1.GetValue();
				string text = (value2 != null) ? value2.ToString() : null;
				if (538.Method6824(text) && flag)
				{
					return null;
				}
				if (left == typeof(DateTimeOffset))
				{
					if (!538.Method6824(this.text2))
					{
						return DateTimeOffset.ParseExact(text, this.text2, this.Method7216(), this.dateTimeStyles2);
					}
					return DateTimeOffset.Parse(text, this.Method7216(), this.dateTimeStyles2);
				}
				else
				{
					if (!538.Method6824(this.text2))
					{
						return DateTime.ParseExact(text, this.text2, this.Method7216(), this.dateTimeStyles2);
					}
					return DateTime.Parse(text, this.Method7216(), this.dateTimeStyles2);
				}
			}
		}
	}

	// Token: 0x040005E4 RID: 1508
	private DateTimeStyles dateTimeStyles2 = DateTimeStyles.RoundtripKind;

	// Token: 0x040005E5 RID: 1509
	[241(2)]
	private string text2;

	// Token: 0x040005E6 RID: 1510
	[241(2)]
	private CultureInfo cultureInfo2;
}
