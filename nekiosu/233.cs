using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.InteropServices;

// Token: 0x020003C1 RID: 961
[ComVisible(false)]
[242(2)]
[241(0)]
public class 233 : 226, IEquatable<233>, IFormattable, IComparable, IComparable<233>, IConvertible
{
	// Token: 0x17000212 RID: 530
	// (get) Token: 0x06001E79 RID: 7801 RVA: 0x0000FF75 File Offset: 0x0000E175
	public override bool HasValues
	{
		get
		{
			return false;
		}
	}

	// Token: 0x17000213 RID: 531
	// (get) Token: 0x06001E7A RID: 7802 RVA: 0x00076FF8 File Offset: 0x000751F8
	public override 705 Type
	{
		get
		{
			return this._recoveredType197110907;
		}
	}

	// Token: 0x17000214 RID: 532
	// (get) Token: 0x06001E7B RID: 7803 RVA: 0x00077000 File Offset: 0x00075200
	// (set) Token: 0x06001E7C RID: 7804 RVA: 0x00077008 File Offset: 0x00075208
	public new object Value
	{
		get
		{
			return this.value8;
		}
		set
		{
			object obj = this.value8;
			Type left = (obj != null) ? obj.GetType() : null;
			Type right = (value != null) ? value.GetType() : null;
			if (left != right)
			{
				this._recoveredType197110907 = 233.Method14362(new 705?(this._recoveredType197110907), value);
			}
			this.value8 = value;
		}
	}

	// Token: 0x06001E7D RID: 7805 RVA: 0x0007705A File Offset: 0x0007525A
	internal 233(object 1, 705 2)
	{
		this.value8 = 1;
		this._recoveredType197110907 = 2;
	}

	// Token: 0x06001E7E RID: 7806 RVA: 0x00077070 File Offset: 0x00075270
	[242(1)]
	internal 233(233 1, [241(2)] 479 2) : this(1.Value, 1.Type)
	{
		if (2 == null || 2.GetFlag3606_4588())
		{
			base.Method14353(this, 1);
		}
	}

	// Token: 0x06001E7F RID: 7807 RVA: 0x00077097 File Offset: 0x00075297
	[242(1)]
	public 233(233 1) : this(1.Value, 1.Type)
	{
	}

	// Token: 0x06001E80 RID: 7808 RVA: 0x000770AB File Offset: 0x000752AB
	public 233(long 1) : this(420.Method3206(1), 705.Integer)
	{
	}

	// Token: 0x06001E81 RID: 7809 RVA: 0x000770BA File Offset: 0x000752BA
	public 233(decimal 1) : this(420.Method3206(1), 705.Float)
	{
	}

	// Token: 0x06001E82 RID: 7810 RVA: 0x000770C9 File Offset: 0x000752C9
	public 233(char 1) : this(1, 705.String)
	{
	}

	// Token: 0x06001E83 RID: 7811 RVA: 0x000770D8 File Offset: 0x000752D8
	[CLSCompliant(false)]
	public 233(ulong 1) : this(1, 705.Integer)
	{
	}

	// Token: 0x06001E84 RID: 7812 RVA: 0x000770E7 File Offset: 0x000752E7
	public 233(double 1) : this(420.Method3206(1), 705.Float)
	{
	}

	// Token: 0x06001E85 RID: 7813 RVA: 0x000770F6 File Offset: 0x000752F6
	public 233(float 1) : this(1, 705.Float)
	{
	}

	// Token: 0x06001E86 RID: 7814 RVA: 0x00077105 File Offset: 0x00075305
	public 233(DateTime 1) : this(1, 705.Date)
	{
	}

	// Token: 0x06001E87 RID: 7815 RVA: 0x00077115 File Offset: 0x00075315
	public 233(DateTimeOffset 1) : this(1, 705.Date)
	{
	}

	// Token: 0x06001E88 RID: 7816 RVA: 0x00077125 File Offset: 0x00075325
	public 233(bool 1) : this(420.Method3206(1), 705.Boolean)
	{
	}

	// Token: 0x06001E89 RID: 7817 RVA: 0x00077135 File Offset: 0x00075335
	public 233(string 1) : this(1, 705.String)
	{
	}

	// Token: 0x06001E8A RID: 7818 RVA: 0x0007713F File Offset: 0x0007533F
	public 233(Guid 1) : this(1, 705.Guid)
	{
	}

	// Token: 0x06001E8B RID: 7819 RVA: 0x0007714F File Offset: 0x0007534F
	public 233(Uri 1) : this(1, (1 != null) ? 705.Uri : 705.Null)
	{
	}

	// Token: 0x06001E8C RID: 7820 RVA: 0x00077167 File Offset: 0x00075367
	public 233(TimeSpan 1) : this(1, 705.TimeSpan)
	{
	}

	// Token: 0x06001E8D RID: 7821 RVA: 0x00077178 File Offset: 0x00075378
	public 233(object 1) : this(1, 233.Method14362(null, 1))
	{
	}

	// Token: 0x06001E8E RID: 7822 RVA: 0x0007719C File Offset: 0x0007539C
	[242(1)]
	internal override bool Method14356(226 1)
	{
		233 2 = 1 as 233;
		return 2 != null && (2 == this || 233.Method14365(this, 2));
	}

	// Token: 0x06001E8F RID: 7823 RVA: 0x000771C4 File Offset: 0x000753C4
	[242(1)]
	private static int Method14357(BigInteger 1, object 2)
	{
		int num = 1.CompareTo(358.Method1496(2));
		if (num != 0)
		{
			return num;
		}
		if (2 is decimal)
		{
			decimal num2 = (decimal)2;
			return 0m.CompareTo(Math.Abs(num2 - Math.Truncate(num2)));
		}
		if (2 is double || 2 is float)
		{
			double num3 = Convert.ToDouble(2, CultureInfo.InvariantCulture);
			return 0.0.CompareTo(Math.Abs(num3 - Math.Truncate(num3)));
		}
		return num;
	}

	// Token: 0x06001E90 RID: 7824 RVA: 0x00077250 File Offset: 0x00075450
	internal static int Method14358(705 1, object 2, object 3)
	{
		if (2 == 3)
		{
			return 0;
		}
		if (3 == null)
		{
			return 1;
		}
		if (2 == null)
		{
			return -1;
		}
		switch (1)
		{
		case 705.Comment:
		case 705.String:
		case 705.Raw:
		{
			string strA = Convert.ToString(2, CultureInfo.InvariantCulture);
			string strB = Convert.ToString(3, CultureInfo.InvariantCulture);
			return string.CompareOrdinal(strA, strB);
		}
		case 705.Integer:
			if (2 is BigInteger)
			{
				BigInteger 4 = (BigInteger)2;
				return 233.Method14357(4, 3);
			}
			if (3 is BigInteger)
			{
				BigInteger 5 = (BigInteger)3;
				return -233.Method14357(5, 2);
			}
			if (2 is ulong || 3 is ulong || 2 is decimal || 3 is decimal)
			{
				return Convert.ToDecimal(2, CultureInfo.InvariantCulture).CompareTo(Convert.ToDecimal(3, CultureInfo.InvariantCulture));
			}
			if (2 is float || 3 is float || 2 is double || 3 is double)
			{
				return 233.Method14359(2, 3);
			}
			return Convert.ToInt64(2, CultureInfo.InvariantCulture).CompareTo(Convert.ToInt64(3, CultureInfo.InvariantCulture));
		case 705.Float:
			if (2 is BigInteger)
			{
				BigInteger 6 = (BigInteger)2;
				return 233.Method14357(6, 3);
			}
			if (3 is BigInteger)
			{
				BigInteger 7 = (BigInteger)3;
				return -233.Method14357(7, 2);
			}
			if (2 is ulong || 3 is ulong || 2 is decimal || 3 is decimal)
			{
				return Convert.ToDecimal(2, CultureInfo.InvariantCulture).CompareTo(Convert.ToDecimal(3, CultureInfo.InvariantCulture));
			}
			return 233.Method14359(2, 3);
		case 705.Boolean:
		{
			bool flag = Convert.ToBoolean(2, CultureInfo.InvariantCulture);
			bool value = Convert.ToBoolean(3, CultureInfo.InvariantCulture);
			return flag.CompareTo(value);
		}
		case 705.Date:
		{
			if (2 is DateTime)
			{
				DateTime dateTime = (DateTime)2;
				DateTime value2 = (!(3 is DateTimeOffset)) ? Convert.ToDateTime(3, CultureInfo.InvariantCulture) : ((DateTimeOffset)3).DateTime;
				return dateTime.CompareTo(value2);
			}
			DateTimeOffset dateTimeOffset = (DateTimeOffset)2;
			DateTimeOffset other = (!(3 is DateTimeOffset)) ? new DateTimeOffset(Convert.ToDateTime(3, CultureInfo.InvariantCulture)) : ((DateTimeOffset)3);
			return dateTimeOffset.CompareTo(other);
		}
		case 705.Bytes:
		{
			byte[] array = 3 as byte[];
			if (array == null)
			{
				throw new ArgumentException("Object must be of type byte[].");
			}
			return 736.Method11631(2 as byte[], array);
		}
		case 705.Guid:
		{
			if (!(3 is Guid))
			{
				throw new ArgumentException("Object must be of type Guid.");
			}
			Guid guid = (Guid)2;
			Guid value3 = (Guid)3;
			return guid.CompareTo(value3);
		}
		case 705.Uri:
		{
			Uri uri = 3 as Uri;
			if (uri == null)
			{
				throw new ArgumentException("Object must be of type Uri.");
			}
			Uri uri2 = (Uri)2;
			return Comparer<string>.Default.Compare(uri2.ToString(), uri.ToString());
		}
		case 705.TimeSpan:
		{
			if (!(3 is TimeSpan))
			{
				throw new ArgumentException("Object must be of type TimeSpan.");
			}
			TimeSpan timeSpan = (TimeSpan)2;
			TimeSpan value4 = (TimeSpan)3;
			return timeSpan.CompareTo(value4);
		}
		}
		throw 736.Method11629("valueType", 1, "Unexpected value type: {0}".Method6825(CultureInfo.InvariantCulture, 1));
	}

	// Token: 0x06001E91 RID: 7825 RVA: 0x00077578 File Offset: 0x00075778
	[242(1)]
	private static int Method14359(object 1, object 2)
	{
		double 3 = Convert.ToDouble(1, CultureInfo.InvariantCulture);
		double num = Convert.ToDouble(2, CultureInfo.InvariantCulture);
		if (421.Method3216(3, num))
		{
			return 0;
		}
		return 3.CompareTo(num);
	}

	// Token: 0x06001E92 RID: 7826 RVA: 0x000775B0 File Offset: 0x000757B0
	private static bool Method14360(ExpressionType 1, object 2, object 3, out object 4)
	{
		if ((2 is string || 3 is string) && (1 == ExpressionType.Add || 1 == ExpressionType.AddAssign))
		{
			4 = ((2 != null) ? 2.ToString() : null) + ((3 != null) ? 3.ToString() : null);
			return true;
		}
		if (2 is BigInteger || 3 is BigInteger)
		{
			if (2 == null || 3 == null)
			{
				4 = null;
				return true;
			}
			BigInteger bigInteger = 358.Method1496(2);
			BigInteger bigInteger2 = 358.Method1496(3);
			if (1 <= ExpressionType.Subtract)
			{
				if (1 <= ExpressionType.Divide)
				{
					if (1 != ExpressionType.Add)
					{
						if (1 != ExpressionType.Divide)
						{
							goto IL_393;
						}
						goto IL_DE;
					}
				}
				else
				{
					if (1 == ExpressionType.Multiply)
					{
						goto IL_CE;
					}
					if (1 != ExpressionType.Subtract)
					{
						goto IL_393;
					}
					goto IL_BE;
				}
			}
			else if (1 <= ExpressionType.DivideAssign)
			{
				if (1 != ExpressionType.AddAssign)
				{
					if (1 != ExpressionType.DivideAssign)
					{
						goto IL_393;
					}
					goto IL_DE;
				}
			}
			else
			{
				if (1 == ExpressionType.MultiplyAssign)
				{
					goto IL_CE;
				}
				if (1 != ExpressionType.SubtractAssign)
				{
					goto IL_393;
				}
				goto IL_BE;
			}
			4 = bigInteger + bigInteger2;
			return true;
			IL_BE:
			4 = bigInteger - bigInteger2;
			return true;
			IL_CE:
			4 = bigInteger * bigInteger2;
			return true;
			IL_DE:
			4 = bigInteger / bigInteger2;
			return true;
		}
		else if (2 is ulong || 3 is ulong || 2 is decimal || 3 is decimal)
		{
			if (2 == null || 3 == null)
			{
				4 = null;
				return true;
			}
			decimal d = Convert.ToDecimal(2, CultureInfo.InvariantCulture);
			decimal d2 = Convert.ToDecimal(3, CultureInfo.InvariantCulture);
			if (1 <= ExpressionType.Subtract)
			{
				if (1 <= ExpressionType.Divide)
				{
					if (1 != ExpressionType.Add)
					{
						if (1 != ExpressionType.Divide)
						{
							goto IL_393;
						}
						goto IL_1AD;
					}
				}
				else
				{
					if (1 == ExpressionType.Multiply)
					{
						goto IL_19D;
					}
					if (1 != ExpressionType.Subtract)
					{
						goto IL_393;
					}
					goto IL_18D;
				}
			}
			else if (1 <= ExpressionType.DivideAssign)
			{
				if (1 != ExpressionType.AddAssign)
				{
					if (1 != ExpressionType.DivideAssign)
					{
						goto IL_393;
					}
					goto IL_1AD;
				}
			}
			else
			{
				if (1 == ExpressionType.MultiplyAssign)
				{
					goto IL_19D;
				}
				if (1 != ExpressionType.SubtractAssign)
				{
					goto IL_393;
				}
				goto IL_18D;
			}
			4 = d + d2;
			return true;
			IL_18D:
			4 = d - d2;
			return true;
			IL_19D:
			4 = d * d2;
			return true;
			IL_1AD:
			4 = d / d2;
			return true;
		}
		else if (2 is float || 3 is float || 2 is double || 3 is double)
		{
			if (2 == null || 3 == null)
			{
				4 = null;
				return true;
			}
			double num = Convert.ToDouble(2, CultureInfo.InvariantCulture);
			double num2 = Convert.ToDouble(3, CultureInfo.InvariantCulture);
			if (1 <= ExpressionType.Subtract)
			{
				if (1 <= ExpressionType.Divide)
				{
					if (1 != ExpressionType.Add)
					{
						if (1 != ExpressionType.Divide)
						{
							goto IL_393;
						}
						goto IL_278;
					}
				}
				else
				{
					if (1 == ExpressionType.Multiply)
					{
						goto IL_26A;
					}
					if (1 != ExpressionType.Subtract)
					{
						goto IL_393;
					}
					goto IL_25C;
				}
			}
			else if (1 <= ExpressionType.DivideAssign)
			{
				if (1 != ExpressionType.AddAssign)
				{
					if (1 != ExpressionType.DivideAssign)
					{
						goto IL_393;
					}
					goto IL_278;
				}
			}
			else
			{
				if (1 == ExpressionType.MultiplyAssign)
				{
					goto IL_26A;
				}
				if (1 != ExpressionType.SubtractAssign)
				{
					goto IL_393;
				}
				goto IL_25C;
			}
			4 = num + num2;
			return true;
			IL_25C:
			4 = num - num2;
			return true;
			IL_26A:
			4 = num * num2;
			return true;
			IL_278:
			4 = num / num2;
			return true;
		}
		else if (2 is int || 2 is uint || 2 is long || 2 is short || 2 is ushort || 2 is sbyte || 2 is byte || 3 is int || 3 is uint || 3 is long || 3 is short || 3 is ushort || 3 is sbyte || 3 is byte)
		{
			if (2 == null || 3 == null)
			{
				4 = null;
				return true;
			}
			long num3 = Convert.ToInt64(2, CultureInfo.InvariantCulture);
			long num4 = Convert.ToInt64(3, CultureInfo.InvariantCulture);
			if (1 <= ExpressionType.Subtract)
			{
				if (1 <= ExpressionType.Divide)
				{
					if (1 != ExpressionType.Add)
					{
						if (1 != ExpressionType.Divide)
						{
							goto IL_393;
						}
						goto IL_385;
					}
				}
				else
				{
					if (1 == ExpressionType.Multiply)
					{
						goto IL_377;
					}
					if (1 != ExpressionType.Subtract)
					{
						goto IL_393;
					}
					goto IL_369;
				}
			}
			else if (1 <= ExpressionType.DivideAssign)
			{
				if (1 != ExpressionType.AddAssign)
				{
					if (1 != ExpressionType.DivideAssign)
					{
						goto IL_393;
					}
					goto IL_385;
				}
			}
			else
			{
				if (1 == ExpressionType.MultiplyAssign)
				{
					goto IL_377;
				}
				if (1 != ExpressionType.SubtractAssign)
				{
					goto IL_393;
				}
				goto IL_369;
			}
			4 = num3 + num4;
			return true;
			IL_369:
			4 = num3 - num4;
			return true;
			IL_377:
			4 = num3 * num4;
			return true;
			IL_385:
			4 = num3 / num4;
			return true;
		}
		IL_393:
		4 = null;
		return false;
	}

	// Token: 0x06001E93 RID: 7827 RVA: 0x00077954 File Offset: 0x00075B54
	[242(1)]
	internal override 226 Method14299([241(2)] 479 1)
	{
		return new 233(this, 1);
	}

	// Token: 0x06001E94 RID: 7828 RVA: 0x0007795D File Offset: 0x00075B5D
	[242(1)]
	public static 233 CreateComment([241(2)] string 1)
	{
		return new 233(1, 705.Comment);
	}

	// Token: 0x06001E95 RID: 7829 RVA: 0x00077966 File Offset: 0x00075B66
	[242(1)]
	public static 233 CreateString([241(2)] string 1)
	{
		return new 233(1, 705.String);
	}

	// Token: 0x06001E96 RID: 7830 RVA: 0x0007796F File Offset: 0x00075B6F
	[242(1)]
	public static 233 CreateNull()
	{
		return new 233(null, 705.Null);
	}

	// Token: 0x06001E97 RID: 7831 RVA: 0x00077979 File Offset: 0x00075B79
	[242(1)]
	public static 233 CreateUndefined()
	{
		return new 233(null, 705.Undefined);
	}

	// Token: 0x06001E98 RID: 7832 RVA: 0x00077984 File Offset: 0x00075B84
	private static 705 Method14362(705? 1, object 2)
	{
		if (2 == null)
		{
			return 705.Null;
		}
		if (2 == DBNull.Value)
		{
			return 705.Null;
		}
		if (2 is string)
		{
			return 233.Method14363(1);
		}
		if (2 is long || 2 is int || 2 is short || 2 is sbyte || 2 is ulong || 2 is uint || 2 is ushort || 2 is byte)
		{
			return 705.Integer;
		}
		if (2 is Enum)
		{
			return 705.Integer;
		}
		if (2 is BigInteger)
		{
			return 705.Integer;
		}
		if (2 is double || 2 is float || 2 is decimal)
		{
			return 705.Float;
		}
		if (2 is DateTime)
		{
			return 705.Date;
		}
		if (2 is DateTimeOffset)
		{
			return 705.Date;
		}
		if (2 is byte[])
		{
			return 705.Bytes;
		}
		if (2 is bool)
		{
			return 705.Boolean;
		}
		if (2 is Guid)
		{
			return 705.Guid;
		}
		if (2 is Uri)
		{
			return 705.Uri;
		}
		if (2 is TimeSpan)
		{
			return 705.TimeSpan;
		}
		throw new ArgumentException("Could not determine JSON object type for type {0}.".Method6825(CultureInfo.InvariantCulture, 2.GetType()));
	}

	// Token: 0x06001E99 RID: 7833 RVA: 0x00077A88 File Offset: 0x00075C88
	private static 705 Method14363(705? 1)
	{
		if (1 == null)
		{
			return 705.String;
		}
		705 valueOrDefault = 1.GetValueOrDefault();
		if (valueOrDefault == 705.Comment || valueOrDefault == 705.String || valueOrDefault == 705.Raw)
		{
			return 1.GetValueOrDefault();
		}
		return 705.String;
	}

	// Token: 0x06001E9A RID: 7834 RVA: 0x00077AC0 File Offset: 0x00075CC0
	[242(1)]
	public override void WriteTo(173 1, params 214[] 2)
	{
		if (2 != null && 2.Length != 0 && this.value8 != null)
		{
			214 3 = 158.Method3855(2, this.value8.GetType());
			if (3 != null && 3.CanWrite)
			{
				3.WriteJson(1, this.value8, 158.Method3835());
				return;
			}
		}
		switch (this._recoveredType197110907)
		{
		case 705.Comment:
		{
			object obj = this.value8;
			1.WriteComment((obj != null) ? obj.ToString() : null);
			return;
		}
		case 705.Integer:
		{
			object obj2 = this.value8;
			if (obj2 is int)
			{
				int 4 = (int)obj2;
				1.WriteValue(4);
				return;
			}
			obj2 = this.value8;
			if (obj2 is long)
			{
				long 5 = (long)obj2;
				1.WriteValue(5);
				return;
			}
			obj2 = this.value8;
			if (obj2 is ulong)
			{
				ulong 6 = (ulong)obj2;
				1.WriteValue(6);
				return;
			}
			obj2 = this.value8;
			if (obj2 is BigInteger)
			{
				BigInteger bigInteger = (BigInteger)obj2;
				1.WriteValue(bigInteger);
				return;
			}
			1.WriteValue(Convert.ToInt64(this.value8, CultureInfo.InvariantCulture));
			return;
		}
		case 705.Float:
		{
			object obj2 = this.value8;
			if (obj2 is decimal)
			{
				decimal 7 = (decimal)obj2;
				1.WriteValue(7);
				return;
			}
			obj2 = this.value8;
			if (obj2 is double)
			{
				double 8 = (double)obj2;
				1.WriteValue(8);
				return;
			}
			obj2 = this.value8;
			if (obj2 is float)
			{
				float 9 = (float)obj2;
				1.WriteValue(9);
				return;
			}
			1.WriteValue(Convert.ToDouble(this.value8, CultureInfo.InvariantCulture));
			return;
		}
		case 705.String:
		{
			object obj3 = this.value8;
			1.WriteValue((obj3 != null) ? obj3.ToString() : null);
			return;
		}
		case 705.Boolean:
			1.WriteValue(Convert.ToBoolean(this.value8, CultureInfo.InvariantCulture));
			return;
		case 705.Null:
			1.WriteNull();
			return;
		case 705.Undefined:
			1.WriteUndefined();
			return;
		case 705.Date:
		{
			object obj2 = this.value8;
			if (obj2 is DateTimeOffset)
			{
				DateTimeOffset 10 = (DateTimeOffset)obj2;
				1.WriteValue(10);
				return;
			}
			1.WriteValue(Convert.ToDateTime(this.value8, CultureInfo.InvariantCulture));
			return;
		}
		case 705.Raw:
		{
			object obj4 = this.value8;
			1.WriteRawValue((obj4 != null) ? obj4.ToString() : null);
			return;
		}
		case 705.Bytes:
			1.WriteValue((byte[])this.value8);
			return;
		case 705.Guid:
			1.WriteValue((this.value8 != null) ? ((Guid?)this.value8) : null);
			return;
		case 705.Uri:
			1.WriteValue((Uri)this.value8);
			return;
		case 705.TimeSpan:
			1.WriteValue((this.value8 != null) ? ((TimeSpan?)this.value8) : null);
			return;
		default:
			throw 736.Method11629("Type", this._recoveredType197110907, "Unexpected token type.");
		}
	}

	// Token: 0x06001E9B RID: 7835 RVA: 0x00077DAC File Offset: 0x00075FAC
	internal override int Method14364()
	{
		int num = (this.value8 != null) ? this.value8.GetHashCode() : 0;
		int recoveredType = (int)this._recoveredType197110907;
		return recoveredType.GetHashCode() ^ num;
	}

	// Token: 0x06001E9C RID: 7836 RVA: 0x00077DE0 File Offset: 0x00075FE0
	[242(1)]
	private static bool Method14365(233 1, 233 2)
	{
		return 1 == 2 || (1._recoveredType197110907 == 2._recoveredType197110907 && 233.Method14358(1._recoveredType197110907, 1.value8, 2.value8) == 0);
	}

	// Token: 0x06001E9D RID: 7837 RVA: 0x00077E12 File Offset: 0x00076012
	public bool Equals(233 1)
	{
		return 1 != null && 233.Method14365(this, 1);
	}

	// Token: 0x06001E9E RID: 7838 RVA: 0x00077E20 File Offset: 0x00076020
	public override bool Equals(object 1)
	{
		233 2 = 1 as 233;
		return 2 != null && this.Equals(2);
	}

	// Token: 0x06001E9F RID: 7839 RVA: 0x00077E40 File Offset: 0x00076040
	public override int GetHashCode()
	{
		if (this.value8 == null)
		{
			return 0;
		}
		return this.value8.GetHashCode();
	}

	// Token: 0x06001EA0 RID: 7840 RVA: 0x00077E57 File Offset: 0x00076057
	[242(1)]
	public override string ToString()
	{
		if (this.value8 == null)
		{
			return string.Empty;
		}
		return this.value8.ToString();
	}

	// Token: 0x06001EA1 RID: 7841 RVA: 0x00077E72 File Offset: 0x00076072
	[242(1)]
	public string ToString(string 1)
	{
		return this.ToString(1, CultureInfo.CurrentCulture);
	}

	// Token: 0x06001EA2 RID: 7842 RVA: 0x00077E80 File Offset: 0x00076080
	[242(1)]
	public string ToString([241(2)] IFormatProvider 1)
	{
		return this.ToString(null, 1);
	}

	// Token: 0x06001EA3 RID: 7843 RVA: 0x00077E8C File Offset: 0x0007608C
	[return: 241(1)]
	public string ToString(string 1, IFormatProvider 2)
	{
		if (this.value8 == null)
		{
			return string.Empty;
		}
		IFormattable formattable = this.value8 as IFormattable;
		if (formattable != null)
		{
			return formattable.ToString(1, 2);
		}
		return this.value8.ToString();
	}

	// Token: 0x06001EA4 RID: 7844 RVA: 0x00077ECA File Offset: 0x000760CA
	[242(1)]
	protected override DynamicMetaObject GetMetaObject(Expression 1)
	{
		return new 640<233>(1, this, new 233.234());
	}

	// Token: 0x06001EA5 RID: 7845 RVA: 0x00077ED8 File Offset: 0x000760D8
	private int Method14366(object 1)
	{
		if (1 == null)
		{
			return 1;
		}
		233 2 = 1 as 233;
		object 3;
		705 4;
		if (2 != null)
		{
			3 = 2.Value;
			4 = ((this._recoveredType197110907 == 705.String && this._recoveredType197110907 != 2._recoveredType197110907) ? 2._recoveredType197110907 : this._recoveredType197110907);
		}
		else
		{
			3 = 1;
			4 = this._recoveredType197110907;
		}
		return 233.Method14358(4, this.value8, 3);
	}

	// Token: 0x06001EA6 RID: 7846 RVA: 0x00077F39 File Offset: 0x00076139
	int IComparable.CompareTo(object 1)
	{
		return this.Method14366(1);
	}

	// Token: 0x06001EA7 RID: 7847 RVA: 0x00077F42 File Offset: 0x00076142
	public int CompareTo(233 1)
	{
		if (1 == null)
		{
			return 1;
		}
		return 233.Method14358((this._recoveredType197110907 == 705.String && this._recoveredType197110907 != 1._recoveredType197110907) ? 1._recoveredType197110907 : this._recoveredType197110907, this.value8, 1.value8);
	}

	// Token: 0x06001EA8 RID: 7848 RVA: 0x00077F80 File Offset: 0x00076180
	private TypeCode Method14367()
	{
		if (this.value8 == null)
		{
			return TypeCode.Empty;
		}
		IConvertible convertible = this.value8 as IConvertible;
		if (convertible != null)
		{
			return convertible.GetTypeCode();
		}
		return TypeCode.Object;
	}

	// Token: 0x06001EA9 RID: 7849 RVA: 0x00077FAE File Offset: 0x000761AE
	TypeCode IConvertible.GetTypeCode()
	{
		return this.Method14367();
	}

	// Token: 0x06001EAA RID: 7850 RVA: 0x00077FB6 File Offset: 0x000761B6
	private bool Method14368(IFormatProvider 1)
	{
		return (bool)this;
	}

	// Token: 0x06001EAB RID: 7851 RVA: 0x00077FBE File Offset: 0x000761BE
	bool IConvertible.ToBoolean(IFormatProvider 1)
	{
		return this.Method14368(1);
	}

	// Token: 0x06001EAC RID: 7852 RVA: 0x00077FC7 File Offset: 0x000761C7
	private char Method14369(IFormatProvider 1)
	{
		return (char)this;
	}

	// Token: 0x06001EAD RID: 7853 RVA: 0x00077FCF File Offset: 0x000761CF
	char IConvertible.ToChar(IFormatProvider 1)
	{
		return this.Method14369(1);
	}

	// Token: 0x06001EAE RID: 7854 RVA: 0x00077FD8 File Offset: 0x000761D8
	private sbyte Method14370(IFormatProvider 1)
	{
		return (sbyte)this;
	}

	// Token: 0x06001EAF RID: 7855 RVA: 0x00077FE0 File Offset: 0x000761E0
	sbyte IConvertible.ToSByte(IFormatProvider 1)
	{
		return this.Method14370(1);
	}

	// Token: 0x06001EB0 RID: 7856 RVA: 0x00077FE9 File Offset: 0x000761E9
	private byte Method14371(IFormatProvider 1)
	{
		return (byte)this;
	}

	// Token: 0x06001EB1 RID: 7857 RVA: 0x00077FF1 File Offset: 0x000761F1
	byte IConvertible.ToByte(IFormatProvider 1)
	{
		return this.Method14371(1);
	}

	// Token: 0x06001EB2 RID: 7858 RVA: 0x00077FFA File Offset: 0x000761FA
	private short Method14372(IFormatProvider 1)
	{
		return (short)this;
	}

	// Token: 0x06001EB3 RID: 7859 RVA: 0x00078002 File Offset: 0x00076202
	short IConvertible.ToInt16(IFormatProvider 1)
	{
		return this.Method14372(1);
	}

	// Token: 0x06001EB4 RID: 7860 RVA: 0x0007800B File Offset: 0x0007620B
	private ushort Method14373(IFormatProvider 1)
	{
		return (ushort)this;
	}

	// Token: 0x06001EB5 RID: 7861 RVA: 0x00078013 File Offset: 0x00076213
	ushort IConvertible.ToUInt16(IFormatProvider 1)
	{
		return this.Method14373(1);
	}

	// Token: 0x06001EB6 RID: 7862 RVA: 0x0007801C File Offset: 0x0007621C
	private int Method14374(IFormatProvider 1)
	{
		return (int)this;
	}

	// Token: 0x06001EB7 RID: 7863 RVA: 0x00078024 File Offset: 0x00076224
	int IConvertible.ToInt32(IFormatProvider 1)
	{
		return this.Method14374(1);
	}

	// Token: 0x06001EB8 RID: 7864 RVA: 0x0007802D File Offset: 0x0007622D
	private uint Method14375(IFormatProvider 1)
	{
		return (uint)this;
	}

	// Token: 0x06001EB9 RID: 7865 RVA: 0x00078035 File Offset: 0x00076235
	uint IConvertible.ToUInt32(IFormatProvider 1)
	{
		return this.Method14375(1);
	}

	// Token: 0x06001EBA RID: 7866 RVA: 0x0007803E File Offset: 0x0007623E
	private long Method14376(IFormatProvider 1)
	{
		return (long)this;
	}

	// Token: 0x06001EBB RID: 7867 RVA: 0x00078046 File Offset: 0x00076246
	long IConvertible.ToInt64(IFormatProvider 1)
	{
		return this.Method14376(1);
	}

	// Token: 0x06001EBC RID: 7868 RVA: 0x0007804F File Offset: 0x0007624F
	private ulong Method14377(IFormatProvider 1)
	{
		return (ulong)this;
	}

	// Token: 0x06001EBD RID: 7869 RVA: 0x00078057 File Offset: 0x00076257
	ulong IConvertible.ToUInt64(IFormatProvider 1)
	{
		return this.Method14377(1);
	}

	// Token: 0x06001EBE RID: 7870 RVA: 0x00078060 File Offset: 0x00076260
	private float Method14378(IFormatProvider 1)
	{
		return (float)this;
	}

	// Token: 0x06001EBF RID: 7871 RVA: 0x00078069 File Offset: 0x00076269
	float IConvertible.ToSingle(IFormatProvider 1)
	{
		return this.Method14378(1);
	}

	// Token: 0x06001EC0 RID: 7872 RVA: 0x00078072 File Offset: 0x00076272
	private double Method14379(IFormatProvider 1)
	{
		return (double)this;
	}

	// Token: 0x06001EC1 RID: 7873 RVA: 0x0007807B File Offset: 0x0007627B
	double IConvertible.ToDouble(IFormatProvider 1)
	{
		return this.Method14379(1);
	}

	// Token: 0x06001EC2 RID: 7874 RVA: 0x00078084 File Offset: 0x00076284
	private decimal Method14380(IFormatProvider 1)
	{
		return (decimal)this;
	}

	// Token: 0x06001EC3 RID: 7875 RVA: 0x0007808C File Offset: 0x0007628C
	decimal IConvertible.ToDecimal(IFormatProvider 1)
	{
		return this.Method14380(1);
	}

	// Token: 0x06001EC4 RID: 7876 RVA: 0x00078095 File Offset: 0x00076295
	private DateTime Method14381(IFormatProvider 1)
	{
		return (DateTime)this;
	}

	// Token: 0x06001EC5 RID: 7877 RVA: 0x0007809D File Offset: 0x0007629D
	DateTime IConvertible.ToDateTime(IFormatProvider 1)
	{
		return this.Method14381(1);
	}

	// Token: 0x06001EC6 RID: 7878 RVA: 0x000780A6 File Offset: 0x000762A6
	[242(1)]
	private object Method14382(Type 1, [241(2)] IFormatProvider 2)
	{
		return base.ToObject(1);
	}

	// Token: 0x06001EC7 RID: 7879 RVA: 0x000780AF File Offset: 0x000762AF
	object IConvertible.ToType(Type 1, [241(2)] IFormatProvider 2)
	{
		return this.Method14382(1, 2);
	}

	// Token: 0x04000ED9 RID: 3801
	private 705 _recoveredType197110907;

	// Token: 0x04000EDA RID: 3802
	private object value8;

	// Token: 0x020003C2 RID: 962
	[242(1)]
	[241(new byte[]
	{
		0,
		1
	})]
	public sealed class 234 : 625<233>
	{
		// Token: 0x06001EC8 RID: 7880 RVA: 0x000780BC File Offset: 0x000762BC
		public override bool Method14354(233 1, ConvertBinder 2, [239(true)] [241(2)] out object 3)
		{
			if (2.Type == typeof(233) || 2.Type == typeof(226))
			{
				3 = 1;
				return true;
			}
			object value = 1.Value;
			if (value == null)
			{
				3 = null;
				return 143.IsNullable(2.Type);
			}
			3 = 358.Method1498(value, CultureInfo.InvariantCulture, 2.Type);
			return true;
		}

		// Token: 0x06001EC9 RID: 7881 RVA: 0x0007812C File Offset: 0x0007632C
		public override bool Method14355(233 1, BinaryOperationBinder 2, object 3, [241(2)] [239(true)] out object 4)
		{
			233 5 = 3 as 233;
			object 6 = (5 != null) ? 5.Value : 3;
			ExpressionType operation = 2.Operation;
			if (operation <= ExpressionType.NotEqual)
			{
				if (operation <= ExpressionType.LessThanOrEqual)
				{
					if (operation != ExpressionType.Add)
					{
						switch (operation)
						{
						case ExpressionType.Divide:
							break;
						case ExpressionType.Equal:
							4 = (233.Method14358(1.Type, 1.Value, 6) == 0);
							return true;
						case ExpressionType.ExclusiveOr:
						case ExpressionType.Invoke:
						case ExpressionType.Lambda:
						case ExpressionType.LeftShift:
							goto IL_18D;
						case ExpressionType.GreaterThan:
							4 = (233.Method14358(1.Type, 1.Value, 6) > 0);
							return true;
						case ExpressionType.GreaterThanOrEqual:
							4 = (233.Method14358(1.Type, 1.Value, 6) >= 0);
							return true;
						case ExpressionType.LessThan:
							4 = (233.Method14358(1.Type, 1.Value, 6) < 0);
							return true;
						case ExpressionType.LessThanOrEqual:
							4 = (233.Method14358(1.Type, 1.Value, 6) <= 0);
							return true;
						default:
							goto IL_18D;
						}
					}
				}
				else if (operation != ExpressionType.Multiply)
				{
					if (operation != ExpressionType.NotEqual)
					{
						goto IL_18D;
					}
					4 = (233.Method14358(1.Type, 1.Value, 6) != 0);
					return true;
				}
			}
			else if (operation <= ExpressionType.AddAssign)
			{
				if (operation != ExpressionType.Subtract && operation != ExpressionType.AddAssign)
				{
					goto IL_18D;
				}
			}
			else if (operation != ExpressionType.DivideAssign && operation != ExpressionType.MultiplyAssign && operation != ExpressionType.SubtractAssign)
			{
				goto IL_18D;
			}
			if (233.Method14360(2.Operation, 1.Value, 6, out 4))
			{
				4 = new 233(4);
				return true;
			}
			IL_18D:
			4 = null;
			return false;
		}
	}
}
