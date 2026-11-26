using System;
using System.Globalization;
using System.IO;
using System.Text;

// Token: 0x020000AC RID: 172
public sealed class 127
{
	// Token: 0x06000449 RID: 1097 RVA: 0x0000D051 File Offset: 0x0000B251
	public 127(BinaryWriter 1)
	{
		this.SetDateTimeKind(DateTimeKind.Utc);
		this.writer = 1;
	}

	// Token: 0x0600044A RID: 1098 RVA: 0x0000D067 File Offset: 0x0000B267
	public DateTimeKind GetDateTimeKind()
	{
		return this.dateTimeKindHandling;
	}

	// Token: 0x0600044B RID: 1099 RVA: 0x0000D06F File Offset: 0x0000B26F
	public void SetDateTimeKind(DateTimeKind 1)
	{
		this.dateTimeKindHandling = 1;
	}

	// Token: 0x0600044C RID: 1100 RVA: 0x0000D078 File Offset: 0x0000B278
	public void Flush()
	{
		this.writer.Flush();
	}

	// Token: 0x0600044D RID: 1101 RVA: 0x0000D085 File Offset: 0x0000B285
	public void Close()
	{
		this.writer.Close();
	}

	// Token: 0x0600044E RID: 1102 RVA: 0x0000D092 File Offset: 0x0000B292
	public void WriteToken(679 1)
	{
		this.Method8462(1);
		this.WriteTokenValue(1);
	}

	// Token: 0x0600044F RID: 1103 RVA: 0x0000D0A4 File Offset: 0x0000B2A4
	private void WriteTokenValue(679 1)
	{
		switch (1.GetRegex_12135())
		{
		case 550.Number:
		{
			564 2 = (564)1;
			this.writer.Write(Convert.ToDouble(2.GetValue6027_7763(), CultureInfo.InvariantCulture));
			return;
		}
		case 550.String:
		{
			741 3 = (741)1;
			this.WriteString((string)3.GetValue6027_7763(), 3.GetNumber9323_11836(), new int?(3.GetNumber8042_10257() - 4));
			return;
		}
		case 550.Object:
		{
			388 4 = (388)1;
			this.writer.Write(4.GetNumber8042_10257());
			foreach (375 5 in 4)
			{
				this.writer.Write((sbyte)5.GetRecoveredType18311340_1962().GetRegex_12135());
				this.WriteString((string)5.GetRecoveredType21551339_1960().GetValue6027_7763(), 5.GetRecoveredType21551339_1960().GetNumber9323_11836(), null);
				this.WriteTokenValue(5.GetRecoveredType18311340_1962());
			}
			this.writer.Write(0);
			return;
		}
		case 550.Array:
		{
			125 6 = (125)1;
			this.writer.Write(6.GetNumber8042_10257());
			ulong num = 0UL;
			foreach (679 7 in 6)
			{
				this.writer.Write((sbyte)7.GetRegex_12135());
				this.WriteString(num.ToString(CultureInfo.InvariantCulture), 421.Method3211(num), null);
				this.WriteTokenValue(7);
				num += 1UL;
			}
			this.writer.Write(0);
			return;
		}
		case 550.Binary:
		{
			730 8 = (730)1;
			byte[] array = (byte[])8.GetValue6027_7763();
			this.writer.Write(array.Length);
			this.writer.Write((byte)8.GetRecoveredType06609017_11350());
			this.writer.Write(array);
			return;
		}
		case 550.Undefined:
		case 550.Null:
			return;
		case 550.Oid:
		{
			byte[] buffer = (byte[])((564)1).GetValue6027_7763();
			this.writer.Write(buffer);
			return;
		}
		case 550.Boolean:
			this.writer.Write(1 == 570._recoveredType13546079);
			return;
		case 550.Date:
		{
			564 9 = (564)1;
			object value6027_ = 9.GetValue6027_7763();
			long value;
			if (value6027_ is DateTime)
			{
				DateTime 10 = (DateTime)value6027_;
				if (this.GetDateTimeKind() == DateTimeKind.Utc)
				{
					10 = 10.ToUniversalTime();
				}
				else if (this.GetDateTimeKind() == DateTimeKind.Local)
				{
					10 = 10.ToLocalTime();
				}
				value = 382.Method2113(10, false);
			}
			else
			{
				DateTimeOffset dateTimeOffset = (DateTimeOffset)9.GetValue6027_7763();
				value = 382.Method2113(dateTimeOffset.UtcDateTime, dateTimeOffset.Offset);
			}
			this.writer.Write(value);
			return;
		}
		case 550.Regex:
		{
			747 11 = (747)1;
			this.WriteString((string)11.GetRecoveredType21559482_12131().GetValue6027_7763(), 11.GetRecoveredType21559482_12131().GetNumber9323_11836(), null);
			this.WriteString((string)11.GetRecoveredType21559483_12133().GetValue6027_7763(), 11.GetRecoveredType21559483_12133().GetNumber9323_11836(), null);
			return;
		}
		case 550.Integer:
		{
			564 12 = (564)1;
			this.writer.Write(Convert.ToInt32(12.GetValue6027_7763(), CultureInfo.InvariantCulture));
			return;
		}
		case 550.Long:
		{
			564 13 = (564)1;
			this.writer.Write(Convert.ToInt64(13.GetValue6027_7763(), CultureInfo.InvariantCulture));
			return;
		}
		}
		throw new ArgumentOutOfRangeException("t", "Unexpected token when writing BSON: {0}".Method6825(CultureInfo.InvariantCulture, 1.GetRegex_12135()));
	}

	// Token: 0x06000450 RID: 1104 RVA: 0x0000D484 File Offset: 0x0000B684
	private void WriteString(string 1, int 2, int? 3)
	{
		if (3 != null)
		{
			this.writer.Write(3.GetValueOrDefault());
		}
		this.WriteUtf8Bytes(1, 2);
		this.writer.Write(0);
	}

	// Token: 0x06000451 RID: 1105 RVA: 0x0000D4B8 File Offset: 0x0000B6B8
	public void WriteUtf8Bytes(string 1, int 2)
	{
		if (1 == null)
		{
			return;
		}
		if (2 <= 256)
		{
			if (this.byteArray == null)
			{
				this.byteArray = new byte[256];
			}
			127.encoding.GetBytes(1, 0, 1.Length, this.byteArray, 0);
			this.writer.Write(this.byteArray, 0, 2);
			return;
		}
		byte[] bytes = 127.encoding.GetBytes(1);
		this.writer.Write(bytes);
	}

	// Token: 0x06000452 RID: 1106 RVA: 0x0000D52F File Offset: 0x0000B72F
	private int Method8462(int 1)
	{
		return 1 + 1;
	}

	// Token: 0x06000453 RID: 1107 RVA: 0x0000D534 File Offset: 0x0000B734
	private int AddStringOverhead(int 1, bool 2)
	{
		return ((!2) ? 1 : 5) + 1;
	}

	// Token: 0x06000454 RID: 1108 RVA: 0x0000D540 File Offset: 0x0000B740
	private int Method8462(679 1)
	{
		switch (1.GetRegex_12135())
		{
		case 550.Number:
			return 8;
		case 550.String:
		{
			741 2 = (741)1;
			string text = (string)2.GetValue6027_7763();
			2.SetNumber9323_11837((text != null) ? 127.encoding.GetByteCount(text) : 0);
			2.SetNumber8042_10258(this.AddStringOverhead(2.GetNumber9323_11836(), 2.GetFlag9324_11838()));
			return 2.GetNumber8042_10257();
		}
		case 550.Object:
		{
			388 3 = (388)1;
			int num = 4;
			foreach (375 4 in 3)
			{
				int num2 = 1;
				num2 += this.Method8462(4.GetRecoveredType21551339_1960());
				num2 += this.Method8462(4.GetRecoveredType18311340_1962());
				num += num2;
			}
			num++;
			3.SetNumber8042_10258(num);
			return num;
		}
		case 550.Array:
		{
			125 5 = (125)1;
			int num3 = 4;
			ulong num4 = 0UL;
			foreach (679 6 in 5)
			{
				num3++;
				num3 += this.Method8462(421.Method3211(num4));
				num3 += this.Method8462(6);
				num4 += 1UL;
			}
			num3++;
			5.SetNumber8042_10258(num3);
			return 5.GetNumber8042_10257();
		}
		case 550.Binary:
		{
			730 7 = (730)1;
			byte[] array = (byte[])7.GetValue6027_7763();
			7.SetNumber8042_10258(5 + array.Length);
			return 7.GetNumber8042_10257();
		}
		case 550.Undefined:
		case 550.Null:
			return 0;
		case 550.Oid:
			return 12;
		case 550.Boolean:
			return 1;
		case 550.Date:
			return 8;
		case 550.Regex:
		{
			747 8 = (747)1;
			int num5 = 0;
			num5 += this.Method8462(8.GetRecoveredType21559482_12131());
			num5 += this.Method8462(8.GetRecoveredType21559483_12133());
			8.SetNumber8042_10258(num5);
			return 8.GetNumber8042_10257();
		}
		case 550.Integer:
			return 4;
		case 550.Long:
			return 8;
		}
		throw new ArgumentOutOfRangeException("t", "Unexpected token when writing BSON: {0}".Method6825(CultureInfo.InvariantCulture, 1.GetRegex_12135()));
	}

	// Token: 0x040003BA RID: 954
	private static readonly Encoding encoding = new UTF8Encoding(false);

	// Token: 0x040003BB RID: 955
	private readonly BinaryWriter writer;

	// Token: 0x040003BC RID: 956
	private byte[] byteArray;

	// Token: 0x040003BD RID: 957
	private DateTimeKind dateTimeKindHandling;
}
