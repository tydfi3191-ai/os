using System;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;
using System.Runtime.InteropServices;

// Token: 0x020000E0 RID: 224
[241(0)]
[242(2)]
[ComVisible(false)]
public abstract class 139 : IDisposable
{
	// Token: 0x1700004C RID: 76
	// (get) Token: 0x060005D4 RID: 1492 RVA: 0x00012B9C File Offset: 0x00010D9C
	[241(1)]
	public virtual string Path
	{
		[242(1)]
		get
		{
			if (this.jsonPosition2.jsonContainerType2 == 131.None)
			{
				return string.Empty;
			}
			137? <<EMPTY_NAME>> = (this.readerState != 139.140.ArrayStart && this.readerState != 139.140.ConstructorStart && this.readerState != 139.140.ObjectStart) ? new 137?(this.jsonPosition2) : null;
			return 137.Method3521(this.list3, <<EMPTY_NAME>>);
		}
	}

	// Token: 0x1700004D RID: 77
	// (get) Token: 0x060005D5 RID: 1493 RVA: 0x00012BFB File Offset: 0x00010DFB
	// (set) Token: 0x060005D6 RID: 1494 RVA: 0x00012C0C File Offset: 0x00010E0C
	[241(1)]
	public CultureInfo Culture
	{
		[242(1)]
		get
		{
			return this.cultureInfo2 ?? CultureInfo.InvariantCulture;
		}
		[242(1)]
		set
		{
			this.cultureInfo2 = value;
		}
	}

	// Token: 0x060005D7 RID: 1495 RVA: 0x00012C15 File Offset: 0x00010E15
	protected 139()
	{
		this.readerState = 139.140.Start;
		this.dateTimeZoneHandling2 = (49)3;
		this.dateParseHandling2 = (48)1;
		this.floatParseHandling2 = (94)0;
		this.nullable2 = new int?(64);
		this.SetCloseInput(true);
	}

	// Token: 0x060005D8 RID: 1496 RVA: 0x00012C4D File Offset: 0x00010E4D
	protected 139.140 GetReaderState()
	{
		return this.readerState;
	}

	// Token: 0x060005D9 RID: 1497 RVA: 0x00012C55 File Offset: 0x00010E55
	public bool GetCloseInput()
	{
		return this.flag5;
	}

	// Token: 0x060005DA RID: 1498 RVA: 0x00012C5D File Offset: 0x00010E5D
	public void SetCloseInput(bool 1)
	{
		this.flag5 = 1;
	}

	// Token: 0x060005DB RID: 1499 RVA: 0x00012C66 File Offset: 0x00010E66
	public bool GetSupportMultipleContent()
	{
		return this.flag6;
	}

	// Token: 0x060005DC RID: 1500 RVA: 0x00012C6E File Offset: 0x00010E6E
	public void SetSupportMultipleContent(bool 1)
	{
		this.flag6 = 1;
	}

	// Token: 0x060005DD RID: 1501 RVA: 0x00012C77 File Offset: 0x00010E77
	public virtual char GetQuoteChar()
	{
		return this.charValue3;
	}

	// Token: 0x060005DE RID: 1502 RVA: 0x00012C7F File Offset: 0x00010E7F
	protected internal virtual void SetQuoteChar(char 1)
	{
		this.charValue3 = 1;
	}

	// Token: 0x060005DF RID: 1503 RVA: 0x00012C88 File Offset: 0x00010E88
	public 49 GetDateTimeZoneHandling()
	{
		return this.dateTimeZoneHandling2;
	}

	// Token: 0x060005E0 RID: 1504 RVA: 0x00012C90 File Offset: 0x00010E90
	public void SetDateTimeZoneHandling(49 1)
	{
		if (1 < (49)0 || 1 > (49)3)
		{
			throw new ArgumentOutOfRangeException("value");
		}
		this.dateTimeZoneHandling2 = 1;
	}

	// Token: 0x060005E1 RID: 1505 RVA: 0x00012CAC File Offset: 0x00010EAC
	public 48 GetDateParseHandling()
	{
		return this.dateParseHandling2;
	}

	// Token: 0x060005E2 RID: 1506 RVA: 0x00012CB4 File Offset: 0x00010EB4
	public void SetDateParseHandling(48 1)
	{
		if (1 < (48)0 || 1 > (48)2)
		{
			throw new ArgumentOutOfRangeException("value");
		}
		this.dateParseHandling2 = 1;
	}

	// Token: 0x060005E3 RID: 1507 RVA: 0x00012CD0 File Offset: 0x00010ED0
	public 94 GetFloatParseHandling()
	{
		return this.floatParseHandling2;
	}

	// Token: 0x060005E4 RID: 1508 RVA: 0x00012CD8 File Offset: 0x00010ED8
	public void SetFloatParseHandling(94 1)
	{
		if (1 < (94)0 || 1 > (94)1)
		{
			throw new ArgumentOutOfRangeException("value");
		}
		this.floatParseHandling2 = 1;
	}

	// Token: 0x060005E5 RID: 1509 RVA: 0x00012CF4 File Offset: 0x00010EF4
	public string GetDateFormatString()
	{
		return this.text7;
	}

	// Token: 0x060005E6 RID: 1510 RVA: 0x00012CFC File Offset: 0x00010EFC
	public void SetDateFormatString(string 1)
	{
		this.text7 = 1;
	}

	// Token: 0x060005E7 RID: 1511 RVA: 0x00012D05 File Offset: 0x00010F05
	public int? GetMaxDepth()
	{
		return this.nullable2;
	}

	// Token: 0x060005E8 RID: 1512 RVA: 0x00012D10 File Offset: 0x00010F10
	public void SetMaxDepth(int? 1)
	{
		int? num = 1;
		int num2 = 0;
		if (num.GetValueOrDefault() <= num2 & num != null)
		{
			throw new ArgumentException("Value must be positive.", "#=zUkSU2UA=");
		}
		this.nullable2 = 1;
	}

	// Token: 0x060005E9 RID: 1513 RVA: 0x00012D4F File Offset: 0x00010F4F
	public virtual 216 GetTokenType()
	{
		return this.jsonToken3;
	}

	// Token: 0x060005EA RID: 1514 RVA: 0x00012D57 File Offset: 0x00010F57
	public virtual object GetValue()
	{
		return this.value2;
	}

	// Token: 0x060005EB RID: 1515 RVA: 0x00012D5F File Offset: 0x00010F5F
	public virtual Type GetValueType()
	{
		object obj = this.value2;
		if (obj == null)
		{
			return null;
		}
		return obj.GetType();
	}

	// Token: 0x060005EC RID: 1516 RVA: 0x00012D74 File Offset: 0x00010F74
	public virtual int GetDepth()
	{
		List<137> list = this.list3;
		int num = (list != null) ? list.Count : 0;
		if (169.IsStartToken(this.GetTokenType()) || this.jsonPosition2.jsonContainerType2 == 131.None)
		{
			return num;
		}
		return num + 1;
	}

	// Token: 0x060005ED RID: 1517 RVA: 0x00012DB3 File Offset: 0x00010FB3
	internal 137 Method2806(int 1)
	{
		if (this.list3 != null && 1 < this.list3.Count)
		{
			return this.list3[1];
		}
		return this.jsonPosition2;
	}

	// Token: 0x060005EE RID: 1518 RVA: 0x00012DE0 File Offset: 0x00010FE0
	private void Method2807(131 1)
	{
		this.Method2835();
		if (this.jsonPosition2.jsonContainerType2 == 131.None)
		{
			this.jsonPosition2 = new 137(1);
			return;
		}
		if (this.list3 == null)
		{
			this.list3 = new List<137>();
		}
		this.list3.Add(this.jsonPosition2);
		this.jsonPosition2 = new 137(1);
		if (this.nullable2 != null)
		{
			int num = this.GetDepth() + 1;
			int? num2 = this.nullable2;
			if ((num > num2.GetValueOrDefault() & num2 != null) && !this.flag4)
			{
				this.flag4 = true;
				throw 141.Method12886(this, "The reader's MaxDepth of {0} has been exceeded.".Method6825(CultureInfo.InvariantCulture, this.nullable2));
			}
		}
	}

	// Token: 0x060005EF RID: 1519 RVA: 0x00012E9C File Offset: 0x0001109C
	private 131 Method2808()
	{
		137 <<EMPTY_NAME>>;
		if (this.list3 != null && this.list3.Count > 0)
		{
			<<EMPTY_NAME>> = this.jsonPosition2;
			this.jsonPosition2 = this.list3[this.list3.Count - 1];
			this.list3.RemoveAt(this.list3.Count - 1);
		}
		else
		{
			<<EMPTY_NAME>> = this.jsonPosition2;
			this.jsonPosition2 = default(137);
		}
		if (this.nullable2 != null)
		{
			int depth = this.GetDepth();
			int? num = this.nullable2;
			if (depth <= num.GetValueOrDefault() & num != null)
			{
				this.flag4 = false;
			}
		}
		return <<EMPTY_NAME>>.jsonContainerType2;
	}

	// Token: 0x060005F0 RID: 1520 RVA: 0x00012F4E File Offset: 0x0001114E
	private 131 GetRecoveredType24302792_2809()
	{
		return this.jsonPosition2.jsonContainerType2;
	}

	// Token: 0x060005F1 RID: 1521
	public abstract bool Read();

	// Token: 0x060005F2 RID: 1522 RVA: 0x00012F5C File Offset: 0x0001115C
	public virtual int? ReadAsInt32()
	{
		216 <<EMPTY_NAME>> = this.Method2848();
		if (<<EMPTY_NAME>> != 216.None)
		{
			switch (<<EMPTY_NAME>>)
			{
			case 216.Integer:
			case 216.Float:
			{
				object value = this.GetValue();
				if (value is int)
				{
					return new int?((int)value);
				}
				int num;
				if (value is BigInteger)
				{
					BigInteger value2 = (BigInteger)value;
					num = (int)value2;
				}
				else
				{
					try
					{
						num = Convert.ToInt32(value, CultureInfo.InvariantCulture);
					}
					catch (Exception 2)
					{
						throw 141.Method12886(this, "Could not convert to integer: {0}.".Method6825(CultureInfo.InvariantCulture, value), 2);
					}
				}
				this.SetToken(216.Integer, num, false);
				return new int?(num);
			}
			case 216.String:
			{
				string 3 = (string)this.GetValue();
				return this.Method2812(3);
			}
			case 216.Null:
			case 216.EndArray:
				goto IL_37;
			}
			throw 141.Method12886(this, "Error reading integer. Unexpected token: {0}.".Method6825(CultureInfo.InvariantCulture, <<EMPTY_NAME>>));
		}
		IL_37:
		return null;
	}

	// Token: 0x060005F3 RID: 1523 RVA: 0x00013060 File Offset: 0x00011260
	internal int? Method2812(string 1)
	{
		if (538.Method6824(1))
		{
			this.SetToken(216.Null, null, false);
			return null;
		}
		int num;
		if (int.TryParse(1, NumberStyles.Integer, this.Culture, out num))
		{
			this.SetToken(216.Integer, num, false);
			return new int?(num);
		}
		this.SetToken(216.String, 1, false);
		throw 141.Method12886(this, "Could not convert string to integer: {0}.".Method6825(CultureInfo.InvariantCulture, 1));
	}

	// Token: 0x060005F4 RID: 1524 RVA: 0x000130D0 File Offset: 0x000112D0
	public virtual string ReadAsString()
	{
		216 <<EMPTY_NAME>> = this.Method2848();
		if (<<EMPTY_NAME>> <= 216.String)
		{
			if (<<EMPTY_NAME>> != 216.None)
			{
				if (<<EMPTY_NAME>> != 216.String)
				{
					goto IL_2E;
				}
				return (string)this.GetValue();
			}
		}
		else if (<<EMPTY_NAME>> != 216.Null && <<EMPTY_NAME>> != 216.EndArray)
		{
			goto IL_2E;
		}
		return null;
		IL_2E:
		if (169.IsPrimitiveToken(<<EMPTY_NAME>>))
		{
			object value = this.GetValue();
			if (value != null)
			{
				IFormattable formattable = value as IFormattable;
				string text;
				if (formattable != null)
				{
					text = formattable.ToString(null, this.Culture);
				}
				else
				{
					Uri uri = value as Uri;
					text = ((uri != null) ? uri.OriginalString : value.ToString());
				}
				string text2 = text;
				this.SetToken(216.String, text2, false);
				return text2;
			}
		}
		throw 141.Method12886(this, "Error reading string. Unexpected token: {0}.".Method6825(CultureInfo.InvariantCulture, <<EMPTY_NAME>>));
	}

	// Token: 0x060005F5 RID: 1525 RVA: 0x0001317C File Offset: 0x0001137C
	public virtual byte[] ReadAsBytes()
	{
		216 <<EMPTY_NAME>> = this.Method2848();
		if (<<EMPTY_NAME>> <= 216.String)
		{
			switch (<<EMPTY_NAME>>)
			{
			case 216.None:
				break;
			case 216.StartObject:
			{
				this.Method2829();
				byte[] array = this.ReadAsBytes();
				this.Method2827();
				if (this.GetTokenType() != 216.EndObject)
				{
					throw 141.Method12886(this, "Error reading bytes. Unexpected token: {0}.".Method6825(CultureInfo.InvariantCulture, this.GetTokenType()));
				}
				this.SetToken(216.Bytes, array, false);
				return array;
			}
			case 216.StartArray:
				return this.Method2815();
			default:
			{
				if (<<EMPTY_NAME>> != 216.String)
				{
					goto IL_118;
				}
				string text = (string)this.GetValue();
				Guid guid;
				byte[] array2 = (text.Length == 0) ? 418.GetItemArray2540_3182<byte>() : ((!358.Method1508(text, out guid)) ? Convert.FromBase64String(text) : guid.ToByteArray());
				this.SetToken(216.Bytes, array2, false);
				return array2;
			}
			}
		}
		else if (<<EMPTY_NAME>> != 216.Null && <<EMPTY_NAME>> != 216.EndArray)
		{
			if (<<EMPTY_NAME>> != 216.Bytes)
			{
				goto IL_118;
			}
			object value = this.GetValue();
			if (value is Guid)
			{
				byte[] array3 = ((Guid)value).ToByteArray();
				this.SetToken(216.Bytes, array3, false);
				return array3;
			}
			return (byte[])this.GetValue();
		}
		return null;
		IL_118:
		throw 141.Method12886(this, "Error reading bytes. Unexpected token: {0}.".Method6825(CultureInfo.InvariantCulture, <<EMPTY_NAME>>));
	}

	// Token: 0x060005F6 RID: 1526 RVA: 0x000132BC File Offset: 0x000114BC
	[242(1)]
	internal byte[] Method2815()
	{
		List<byte> list = new List<byte>();
		do
		{
			if (!this.Read())
			{
				this.SetToken(216.None);
			}
		}
		while (!this.Method2816(list));
		byte[] array = list.ToArray();
		this.SetToken(216.Bytes, array, false);
		return array;
	}

	// Token: 0x060005F7 RID: 1527 RVA: 0x000132FC File Offset: 0x000114FC
	[242(1)]
	private bool Method2816(List<byte> 1)
	{
		216 tokenType = this.GetTokenType();
		if (tokenType <= 216.Comment)
		{
			if (tokenType == 216.None)
			{
				throw 141.Method12886(this, "Unexpected end when reading bytes.");
			}
			if (tokenType == 216.Comment)
			{
				return false;
			}
		}
		else
		{
			if (tokenType == 216.Integer)
			{
				1.Add(Convert.ToByte(this.GetValue(), CultureInfo.InvariantCulture));
				return false;
			}
			if (tokenType == 216.EndArray)
			{
				return true;
			}
		}
		throw 141.Method12886(this, "Unexpected token when reading bytes: {0}.".Method6825(CultureInfo.InvariantCulture, this.GetTokenType()));
	}

	// Token: 0x060005F8 RID: 1528 RVA: 0x00013370 File Offset: 0x00011570
	public virtual double? ReadAsDouble()
	{
		216 <<EMPTY_NAME>> = this.Method2848();
		if (<<EMPTY_NAME>> != 216.None)
		{
			switch (<<EMPTY_NAME>>)
			{
			case 216.Integer:
			case 216.Float:
			{
				object value = this.GetValue();
				if (value is double)
				{
					return new double?((double)value);
				}
				double num;
				if (value is BigInteger)
				{
					BigInteger value2 = (BigInteger)value;
					num = (double)value2;
				}
				else
				{
					num = Convert.ToDouble(value, CultureInfo.InvariantCulture);
				}
				double num2 = num;
				this.SetToken(216.Float, num2, false);
				return new double?(num2);
			}
			case 216.String:
				return this.Method2818((string)this.GetValue());
			case 216.Null:
			case 216.EndArray:
				goto IL_34;
			}
			throw 141.Method12886(this, "Error reading double. Unexpected token: {0}.".Method6825(CultureInfo.InvariantCulture, <<EMPTY_NAME>>));
		}
		IL_34:
		return null;
	}

	// Token: 0x060005F9 RID: 1529 RVA: 0x00013440 File Offset: 0x00011640
	internal double? Method2818(string 1)
	{
		if (538.Method6824(1))
		{
			this.SetToken(216.Null, null, false);
			return null;
		}
		double num;
		if (double.TryParse(1, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, this.Culture, out num))
		{
			this.SetToken(216.Float, num, false);
			return new double?(num);
		}
		this.SetToken(216.String, 1, false);
		throw 141.Method12886(this, "Could not convert string to double: {0}.".Method6825(CultureInfo.InvariantCulture, 1));
	}

	// Token: 0x060005FA RID: 1530 RVA: 0x000134B4 File Offset: 0x000116B4
	public virtual bool? ReadAsBoolean()
	{
		216 <<EMPTY_NAME>> = this.Method2848();
		if (<<EMPTY_NAME>> != 216.None)
		{
			switch (<<EMPTY_NAME>>)
			{
			case 216.Integer:
			case 216.Float:
			{
				object value = this.GetValue();
				bool flag;
				if (value is BigInteger)
				{
					BigInteger left = (BigInteger)value;
					flag = (left != 0L);
				}
				else
				{
					flag = Convert.ToBoolean(this.GetValue(), CultureInfo.InvariantCulture);
				}
				bool flag2 = flag;
				this.SetToken(216.Boolean, flag2, false);
				return new bool?(flag2);
			}
			case 216.String:
				return this.Method2820((string)this.GetValue());
			case 216.Boolean:
				return new bool?((bool)this.GetValue());
			case 216.Null:
			case 216.EndArray:
				goto IL_34;
			}
			throw 141.Method12886(this, "Error reading boolean. Unexpected token: {0}.".Method6825(CultureInfo.InvariantCulture, <<EMPTY_NAME>>));
		}
		IL_34:
		return null;
	}

	// Token: 0x060005FB RID: 1531 RVA: 0x00013588 File Offset: 0x00011788
	internal bool? Method2820(string 1)
	{
		if (538.Method6824(1))
		{
			this.SetToken(216.Null, null, false);
			return null;
		}
		bool flag;
		if (bool.TryParse(1, out flag))
		{
			this.SetToken(216.Boolean, flag, false);
			return new bool?(flag);
		}
		this.SetToken(216.String, 1, false);
		throw 141.Method12886(this, "Could not convert string to boolean: {0}.".Method6825(CultureInfo.InvariantCulture, 1));
	}

	// Token: 0x060005FC RID: 1532 RVA: 0x000135F4 File Offset: 0x000117F4
	public virtual decimal? ReadAsDecimal()
	{
		216 <<EMPTY_NAME>> = this.Method2848();
		if (<<EMPTY_NAME>> != 216.None)
		{
			switch (<<EMPTY_NAME>>)
			{
			case 216.Integer:
			case 216.Float:
			{
				object value = this.GetValue();
				if (value is decimal)
				{
					return new decimal?((decimal)value);
				}
				decimal num;
				if (value is BigInteger)
				{
					BigInteger value2 = (BigInteger)value;
					num = (decimal)value2;
				}
				else
				{
					try
					{
						num = Convert.ToDecimal(value, CultureInfo.InvariantCulture);
					}
					catch (Exception 2)
					{
						throw 141.Method12886(this, "Could not convert to decimal: {0}.".Method6825(CultureInfo.InvariantCulture, value), 2);
					}
				}
				this.SetToken(216.Float, num, false);
				return new decimal?(num);
			}
			case 216.String:
				return this.Method2822((string)this.GetValue());
			case 216.Null:
			case 216.EndArray:
				goto IL_37;
			}
			throw 141.Method12886(this, "Error reading decimal. Unexpected token: {0}.".Method6825(CultureInfo.InvariantCulture, <<EMPTY_NAME>>));
		}
		IL_37:
		return null;
	}

	// Token: 0x060005FD RID: 1533 RVA: 0x000136F4 File Offset: 0x000118F4
	internal decimal? Method2822(string 1)
	{
		if (538.Method6824(1))
		{
			this.SetToken(216.Null, null, false);
			return null;
		}
		decimal num;
		if (decimal.TryParse(1, NumberStyles.Number, this.Culture, out num))
		{
			this.SetToken(216.Float, num, false);
			return new decimal?(num);
		}
		if (358.Method1507(1.ToCharArray(), 0, 1.Length, out num) == (514)1)
		{
			this.SetToken(216.Float, num, false);
			return new decimal?(num);
		}
		this.SetToken(216.String, 1, false);
		throw 141.Method12886(this, "Could not convert string to decimal: {0}.".Method6825(CultureInfo.InvariantCulture, 1));
	}

	// Token: 0x060005FE RID: 1534 RVA: 0x00013790 File Offset: 0x00011990
	public virtual DateTime? ReadAsDateTime()
	{
		216 <<EMPTY_NAME>> = this.Method2848();
		if (<<EMPTY_NAME>> <= 216.String)
		{
			if (<<EMPTY_NAME>> != 216.None)
			{
				if (<<EMPTY_NAME>> != 216.String)
				{
					goto IL_7F;
				}
				return this.Method2824((string)this.GetValue());
			}
		}
		else if (<<EMPTY_NAME>> != 216.Null && <<EMPTY_NAME>> != 216.EndArray)
		{
			if (<<EMPTY_NAME>> != 216.Date)
			{
				goto IL_7F;
			}
			object value = this.GetValue();
			if (value is DateTimeOffset)
			{
				this.SetToken(216.Date, ((DateTimeOffset)value).DateTime, false);
			}
			return new DateTime?((DateTime)this.GetValue());
		}
		return null;
		IL_7F:
		throw 141.Method12886(this, "Error reading date. Unexpected token: {0}.".Method6825(CultureInfo.InvariantCulture, this.GetTokenType()));
	}

	// Token: 0x060005FF RID: 1535 RVA: 0x0001383C File Offset: 0x00011A3C
	internal DateTime? Method2824(string 1)
	{
		if (538.Method6824(1))
		{
			this.SetToken(216.Null, null, false);
			return null;
		}
		DateTime dateTime;
		if (382.Method2121(1, this.GetDateTimeZoneHandling(), this.text7, this.Culture, out dateTime))
		{
			dateTime = 382.Method2108(dateTime, this.GetDateTimeZoneHandling());
			this.SetToken(216.Date, dateTime, false);
			return new DateTime?(dateTime);
		}
		if (DateTime.TryParse(1, this.Culture, DateTimeStyles.RoundtripKind, out dateTime))
		{
			dateTime = 382.Method2108(dateTime, this.GetDateTimeZoneHandling());
			this.SetToken(216.Date, dateTime, false);
			return new DateTime?(dateTime);
		}
		throw 141.Method12886(this, "Could not convert string to DateTime: {0}.".Method6825(CultureInfo.InvariantCulture, 1));
	}

	// Token: 0x06000600 RID: 1536 RVA: 0x000138F4 File Offset: 0x00011AF4
	public virtual DateTimeOffset? ReadAsDateTimeOffset()
	{
		216 <<EMPTY_NAME>> = this.Method2848();
		if (<<EMPTY_NAME>> <= 216.String)
		{
			if (<<EMPTY_NAME>> != 216.None)
			{
				if (<<EMPTY_NAME>> != 216.String)
				{
					goto IL_82;
				}
				string 2 = (string)this.GetValue();
				return this.Method2826(2);
			}
		}
		else if (<<EMPTY_NAME>> != 216.Null && <<EMPTY_NAME>> != 216.EndArray)
		{
			if (<<EMPTY_NAME>> != 216.Date)
			{
				goto IL_82;
			}
			object value = this.GetValue();
			if (value is DateTime)
			{
				DateTime dateTime = (DateTime)value;
				this.SetToken(216.Date, new DateTimeOffset(dateTime), false);
			}
			return new DateTimeOffset?((DateTimeOffset)this.GetValue());
		}
		return null;
		IL_82:
		throw 141.Method12886(this, "Error reading date. Unexpected token: {0}.".Method6825(CultureInfo.InvariantCulture, <<EMPTY_NAME>>));
	}

	// Token: 0x06000601 RID: 1537 RVA: 0x000139A0 File Offset: 0x00011BA0
	internal DateTimeOffset? Method2826(string 1)
	{
		if (538.Method6824(1))
		{
			this.SetToken(216.Null, null, false);
			return null;
		}
		DateTimeOffset dateTimeOffset;
		if (382.Method2123(1, this.text7, this.Culture, out dateTimeOffset))
		{
			this.SetToken(216.Date, dateTimeOffset, false);
			return new DateTimeOffset?(dateTimeOffset);
		}
		if (DateTimeOffset.TryParse(1, this.Culture, DateTimeStyles.RoundtripKind, out dateTimeOffset))
		{
			this.SetToken(216.Date, dateTimeOffset, false);
			return new DateTimeOffset?(dateTimeOffset);
		}
		this.SetToken(216.String, 1, false);
		throw 141.Method12886(this, "Could not convert string to DateTimeOffset: {0}.".Method6825(CultureInfo.InvariantCulture, 1));
	}

	// Token: 0x06000602 RID: 1538 RVA: 0x00013A40 File Offset: 0x00011C40
	internal void Method2827()
	{
		if (!this.Read())
		{
			throw this.Method2828();
		}
	}

	// Token: 0x06000603 RID: 1539 RVA: 0x00013A51 File Offset: 0x00011C51
	[242(1)]
	internal 141 Method2828()
	{
		return 141.Method12886(this, "Unexpected end when reading JSON.");
	}

	// Token: 0x06000604 RID: 1540 RVA: 0x00013A60 File Offset: 0x00011C60
	internal void Method2829()
	{
		this.Method2827();
		if (this.GetValue() != null && this.GetValue().ToString() == "$type")
		{
			this.Method2827();
			if (this.GetValue() != null && this.GetValue().ToString().StartsWith("System.Byte[]", StringComparison.Ordinal))
			{
				this.Method2827();
				if (this.GetValue().ToString() == "$value")
				{
					return;
				}
			}
		}
		throw 141.Method12886(this, "Error reading bytes. Unexpected token: {0}.".Method6825(CultureInfo.InvariantCulture, 216.StartObject));
	}

	// Token: 0x06000605 RID: 1541 RVA: 0x00013AF4 File Offset: 0x00011CF4
	public void Skip()
	{
		if (this.GetTokenType() == 216.PropertyName)
		{
			this.Read();
		}
		if (169.IsStartToken(this.GetTokenType()))
		{
			int depth = this.GetDepth();
			while (this.Read() && depth < this.GetDepth())
			{
			}
		}
	}

	// Token: 0x06000606 RID: 1542 RVA: 0x00013B36 File Offset: 0x00011D36
	protected void SetToken(216 1)
	{
		this.SetToken(1, null, true);
	}

	// Token: 0x06000607 RID: 1543 RVA: 0x00013B41 File Offset: 0x00011D41
	protected void SetToken(216 1, object 2)
	{
		this.SetToken(1, 2, true);
	}

	// Token: 0x06000608 RID: 1544 RVA: 0x00013B4C File Offset: 0x00011D4C
	protected void SetToken(216 1, object 2, bool 3)
	{
		this.jsonToken3 = 1;
		this.value2 = 2;
		switch (1)
		{
		case 216.StartObject:
			this.readerState = 139.140.ObjectStart;
			this.Method2807(131.Object);
			return;
		case 216.StartArray:
			this.readerState = 139.140.ArrayStart;
			this.Method2807(131.Array);
			return;
		case 216.StartConstructor:
			this.readerState = 139.140.ConstructorStart;
			this.Method2807(131.Constructor);
			return;
		case 216.PropertyName:
			this.readerState = 139.140.Property;
			this.jsonPosition2.text3 = (string)2;
			return;
		case 216.Comment:
			break;
		case 216.Raw:
		case 216.Integer:
		case 216.Float:
		case 216.String:
		case 216.Boolean:
		case 216.Null:
		case 216.Undefined:
		case 216.Date:
		case 216.Bytes:
			this.Method2834(3);
			break;
		case 216.EndObject:
			this.Method2836(216.EndObject);
			return;
		case 216.EndArray:
			this.Method2836(216.EndArray);
			return;
		case 216.EndConstructor:
			this.Method2836(216.EndConstructor);
			return;
		default:
			return;
		}
	}

	// Token: 0x06000609 RID: 1545 RVA: 0x00013C1D File Offset: 0x00011E1D
	internal void Method2834(bool 1)
	{
		if (this.GetRecoveredType24302792_2809() != 131.None || this.GetSupportMultipleContent())
		{
			this.readerState = 139.140.PostValue;
		}
		else
		{
			this.SetRecoveredType04882230_2838();
		}
		if (1)
		{
			this.Method2835();
		}
	}

	// Token: 0x0600060A RID: 1546 RVA: 0x00013C47 File Offset: 0x00011E47
	private void Method2835()
	{
		if (this.jsonPosition2.flag)
		{
			this.jsonPosition2.number = this.jsonPosition2.number + 1;
		}
	}

	// Token: 0x0600060B RID: 1547 RVA: 0x00013C68 File Offset: 0x00011E68
	private void Method2836(216 1)
	{
		131 2 = this.Method2808();
		if (this.Method2839(1) != 2)
		{
			throw 141.Method12886(this, "JsonToken {0} is not valid for closing JsonType {1}.".Method6825(CultureInfo.InvariantCulture, 1, 2));
		}
		if (this.GetRecoveredType24302792_2809() != 131.None || this.GetSupportMultipleContent())
		{
			this.readerState = 139.140.PostValue;
			return;
		}
		this.SetRecoveredType04882230_2838();
	}

	// Token: 0x0600060C RID: 1548 RVA: 0x00013CC8 File Offset: 0x00011EC8
	protected void Method2837()
	{
		131 recoveredType24302792_ = this.GetRecoveredType24302792_2809();
		switch (recoveredType24302792_)
		{
		case 131.None:
			this.SetRecoveredType04882230_2838();
			return;
		case 131.Object:
			this.readerState = 139.140.Object;
			return;
		case 131.Array:
			this.readerState = 139.140.Array;
			return;
		case 131.Constructor:
			this.readerState = 139.140.Constructor;
			return;
		default:
			throw 141.Method12886(this, "While setting the reader state back to current object an unexpected JsonType was encountered: {0}".Method6825(CultureInfo.InvariantCulture, recoveredType24302792_));
		}
	}

	// Token: 0x0600060D RID: 1549 RVA: 0x00013D2F File Offset: 0x00011F2F
	private void SetRecoveredType04882230_2838()
	{
		this.readerState = ((!this.GetSupportMultipleContent()) ? 139.140.Finished : 139.140.Start);
	}

	// Token: 0x0600060E RID: 1550 RVA: 0x00013D44 File Offset: 0x00011F44
	private 131 Method2839(216 1)
	{
		131 result;
		switch (1)
		{
		case 216.EndObject:
			result = 131.Object;
			break;
		case 216.EndArray:
			result = 131.Array;
			break;
		case 216.EndConstructor:
			result = 131.Constructor;
			break;
		default:
			throw 141.Method12886(this, "Not a valid close JsonToken: {0}".Method6825(CultureInfo.InvariantCulture, 1));
		}
		return result;
	}

	// Token: 0x0600060F RID: 1551 RVA: 0x00013D91 File Offset: 0x00011F91
	private void Method2840()
	{
		this.Method2841(true);
		GC.SuppressFinalize(this);
	}

	// Token: 0x06000610 RID: 1552 RVA: 0x00013DA0 File Offset: 0x00011FA0
	void IDisposable.Dispose()
	{
		this.Method2840();
	}

	// Token: 0x06000611 RID: 1553 RVA: 0x00013DA8 File Offset: 0x00011FA8
	protected virtual void Method2841(bool 1)
	{
		if (this.readerState != 139.140.Closed && 1)
		{
			this.Close();
		}
	}

	// Token: 0x06000612 RID: 1554 RVA: 0x00013DC0 File Offset: 0x00011FC0
	public virtual void Close()
	{
		this.readerState = 139.140.Closed;
		this.jsonToken3 = 216.None;
		this.value2 = null;
	}

	// Token: 0x06000613 RID: 1555 RVA: 0x00013DD7 File Offset: 0x00011FD7
	internal void Method2843()
	{
		if (!this.Read())
		{
			throw 364.Method1687(this, "Unexpected end when reading JSON.");
		}
	}

	// Token: 0x06000614 RID: 1556 RVA: 0x00013DED File Offset: 0x00011FED
	internal void Method2844(902 1, bool 2)
	{
		if (!this.Method2845(1, 2))
		{
			throw 364.Method1687(this, "Unexpected end when reading JSON.");
		}
	}

	// Token: 0x06000615 RID: 1557 RVA: 0x00013E08 File Offset: 0x00012008
	internal bool Method2845(902 1, bool 2)
	{
		if (2)
		{
			return this.Read();
		}
		switch ((1 != null) ? 1.internalReadType : ((815)0))
		{
		case (815)0:
			return this.Method2846();
		case (815)1:
			this.ReadAsInt32();
			break;
		case (815)2:
		{
			bool result = this.Method2846();
			if (this.GetTokenType() == 216.Undefined)
			{
				throw 141.Method12886(this, "An undefined token is not a valid {0}.".Method6825(CultureInfo.InvariantCulture, ((1 != null) ? 1.GetUnderlyingType() : null) ?? typeof(long)));
			}
			return result;
		}
		case (815)3:
			this.ReadAsBytes();
			break;
		case (815)4:
			this.ReadAsString();
			break;
		case (815)5:
			this.ReadAsDecimal();
			break;
		case (815)6:
			this.ReadAsDateTime();
			break;
		case (815)7:
			this.ReadAsDateTimeOffset();
			break;
		case (815)8:
			this.ReadAsDouble();
			break;
		case (815)9:
			this.ReadAsBoolean();
			break;
		default:
			throw new ArgumentOutOfRangeException();
		}
		return this.GetTokenType() > 216.None;
	}

	// Token: 0x06000616 RID: 1558 RVA: 0x00013F01 File Offset: 0x00012101
	internal bool Method2846()
	{
		return this.Read() && this.Method2847();
	}

	// Token: 0x06000617 RID: 1559 RVA: 0x00013F14 File Offset: 0x00012114
	internal bool Method2847()
	{
		216 tokenType = this.GetTokenType();
		while (tokenType == 216.None || tokenType == 216.Comment)
		{
			if (!this.Read())
			{
				return false;
			}
			tokenType = this.GetTokenType();
		}
		return true;
	}

	// Token: 0x06000618 RID: 1560 RVA: 0x00013F44 File Offset: 0x00012144
	private 216 Method2848()
	{
		while (this.Read())
		{
			216 tokenType = this.GetTokenType();
			if (tokenType != 216.Comment)
			{
				return tokenType;
			}
		}
		this.SetToken(216.None);
		return 216.None;
	}

	// Token: 0x0400044B RID: 1099
	private 216 jsonToken3;

	// Token: 0x0400044C RID: 1100
	private object value2;

	// Token: 0x0400044D RID: 1101
	internal char charValue3;

	// Token: 0x0400044E RID: 1102
	internal 139.140 readerState;

	// Token: 0x0400044F RID: 1103
	private 137 jsonPosition2;

	// Token: 0x04000450 RID: 1104
	private CultureInfo cultureInfo2;

	// Token: 0x04000451 RID: 1105
	private 49 dateTimeZoneHandling2;

	// Token: 0x04000452 RID: 1106
	private int? nullable2;

	// Token: 0x04000453 RID: 1107
	private bool flag4;

	// Token: 0x04000454 RID: 1108
	internal 48 dateParseHandling2;

	// Token: 0x04000455 RID: 1109
	internal 94 floatParseHandling2;

	// Token: 0x04000456 RID: 1110
	private string text7;

	// Token: 0x04000457 RID: 1111
	private List<137> list3;

	// Token: 0x04000458 RID: 1112
	private bool flag5;

	// Token: 0x04000459 RID: 1113
	private bool flag6;

	// Token: 0x020000E1 RID: 225
	[242(0)]
	public enum 140
	{
		// Token: 0x0400045B RID: 1115
		Start,
		// Token: 0x0400045C RID: 1116
		Complete,
		// Token: 0x0400045D RID: 1117
		Property,
		// Token: 0x0400045E RID: 1118
		ObjectStart,
		// Token: 0x0400045F RID: 1119
		Object,
		// Token: 0x04000460 RID: 1120
		ArrayStart,
		// Token: 0x04000461 RID: 1121
		Array,
		// Token: 0x04000462 RID: 1122
		Closed,
		// Token: 0x04000463 RID: 1123
		PostValue,
		// Token: 0x04000464 RID: 1124
		ConstructorStart,
		// Token: 0x04000465 RID: 1125
		Constructor,
		// Token: 0x04000466 RID: 1126
		Error,
		// Token: 0x04000467 RID: 1127
		Finished
	}
}
