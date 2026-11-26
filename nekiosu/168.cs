using System;
using System.Globalization;
using System.IO;
using System.Numerics;
using System.Runtime.InteropServices;

// Token: 0x020000E5 RID: 229
[241(0)]
[242(2)]
[ComVisible(false)]
public sealed class 168 : 173
{
	// Token: 0x17000051 RID: 81
	// (get) Token: 0x06000674 RID: 1652 RVA: 0x00017062 File Offset: 0x00015262
	[241(1)]
	private 64 RecoveredType09292357
	{
		[242(1)]
		get
		{
			if (this.embeddedBase64Encoder == null)
			{
				this.embeddedBase64Encoder = new 64(this.textWriter2);
			}
			return this.embeddedBase64Encoder;
		}
	}

	// Token: 0x06000675 RID: 1653 RVA: 0x00017084 File Offset: 0x00015284
	[242(1)]
	public 168(TextWriter 1)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("#=zSwiHjn_dqHQx");
		}
		this.textWriter2 = 1;
		this.charValue3 = '"';
		this.flag2 = true;
		this.charValue2 = ' ';
		this.number2 = 2;
		this.SetFlagArray2353_2962();
	}

	// Token: 0x06000676 RID: 1654 RVA: 0x000170D0 File Offset: 0x000152D0
	public 690<char> GetRecoveredType18542355_2942()
	{
		return this._recoveredType18542355;
	}

	// Token: 0x06000677 RID: 1655 RVA: 0x000170D8 File Offset: 0x000152D8
	public void Method2943(690<char> 1)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("value");
		}
		this._recoveredType18542355 = 1;
	}

	// Token: 0x06000678 RID: 1656 RVA: 0x000170EF File Offset: 0x000152EF
	public int GetNumber2350_2944()
	{
		return this.number2;
	}

	// Token: 0x06000679 RID: 1657 RVA: 0x000170F7 File Offset: 0x000152F7
	public void Method2945(int 1)
	{
		if (1 < 0)
		{
			throw new ArgumentException("Indentation value must be greater than 0.");
		}
		this.number2 = 1;
	}

	// Token: 0x0600067A RID: 1658 RVA: 0x0001710F File Offset: 0x0001530F
	public char GetChar2351_2946()
	{
		return this.charValue3;
	}

	// Token: 0x0600067B RID: 1659 RVA: 0x00017117 File Offset: 0x00015317
	public void Method2947(char 1)
	{
		if (1 != '"' && 1 != '\'')
		{
			throw new ArgumentException("Invalid JavaScript string quote character. Valid quote characters are ' and \".");
		}
		this.charValue3 = 1;
		this.SetFlagArray2353_2962();
	}

	// Token: 0x0600067C RID: 1660 RVA: 0x0001713B File Offset: 0x0001533B
	public char GetChar2349_2948()
	{
		return this.charValue2;
	}

	// Token: 0x0600067D RID: 1661 RVA: 0x00017143 File Offset: 0x00015343
	public void Method2949(char 1)
	{
		if (1 != this.charValue2)
		{
			this.charValue2 = 1;
			this.charArray2 = null;
		}
	}

	// Token: 0x0600067E RID: 1662 RVA: 0x0001715C File Offset: 0x0001535C
	public bool GetFlag2352_2950()
	{
		return this.flag2;
	}

	// Token: 0x0600067F RID: 1663 RVA: 0x00017164 File Offset: 0x00015364
	public void SetFlag2352_2951(bool 1)
	{
		this.flag2 = 1;
	}

	// Token: 0x06000680 RID: 1664 RVA: 0x0001716D File Offset: 0x0001536D
	public override void Flush()
	{
		this.textWriter2.Flush();
	}

	// Token: 0x06000681 RID: 1665 RVA: 0x0001717A File Offset: 0x0001537A
	public override void Close()
	{
		base.Close();
		this.Method2954();
	}

	// Token: 0x06000682 RID: 1666 RVA: 0x00017188 File Offset: 0x00015388
	private void Method2954()
	{
		if (this.charArray != null)
		{
			669.Method9988(this._recoveredType18542355, this.charArray);
			this.charArray = null;
		}
		if (base.GetCloseOutput())
		{
			TextWriter textWriter = this.textWriter2;
			if (textWriter == null)
			{
				return;
			}
			textWriter.Close();
		}
	}

	// Token: 0x06000683 RID: 1667 RVA: 0x000171C2 File Offset: 0x000153C2
	public override void WriteStartObject()
	{
		base.Method7424(216.StartObject, 131.Object);
		this.textWriter2.Write('{');
	}

	// Token: 0x06000684 RID: 1668 RVA: 0x000171D9 File Offset: 0x000153D9
	public override void WriteStartArray()
	{
		base.Method7424(216.StartArray, 131.Array);
		this.textWriter2.Write('[');
	}

	// Token: 0x06000685 RID: 1669 RVA: 0x000171F0 File Offset: 0x000153F0
	[242(1)]
	public override void WriteStartConstructor(string 1)
	{
		base.Method7424(216.StartConstructor, 131.Constructor);
		this.textWriter2.Write("new ");
		this.textWriter2.Write(1);
		this.textWriter2.Write('(');
	}

	// Token: 0x06000686 RID: 1670 RVA: 0x00017224 File Offset: 0x00015424
	protected override void WriteEnd(216 1)
	{
		switch (1)
		{
		case 216.EndObject:
			this.textWriter2.Write('}');
			return;
		case 216.EndArray:
			this.textWriter2.Write(']');
			return;
		case 216.EndConstructor:
			this.textWriter2.Write(')');
			return;
		default:
			throw 763.Method12341(this, "Invalid JsonToken: " + 1.ToString(), null);
		}
	}

	// Token: 0x06000687 RID: 1671 RVA: 0x00017290 File Offset: 0x00015490
	[242(1)]
	public override void WritePropertyName(string 1)
	{
		base.Method7422(1);
		this.Method2973(1, this.flag2);
		this.textWriter2.Write(':');
	}

	// Token: 0x06000688 RID: 1672 RVA: 0x000172B4 File Offset: 0x000154B4
	[242(1)]
	public override void WritePropertyName(string 1, bool 2)
	{
		base.Method7422(1);
		if (2)
		{
			this.Method2973(1, this.flag2);
		}
		else
		{
			if (this.flag2)
			{
				this.textWriter2.Write(this.charValue3);
			}
			this.textWriter2.Write(1);
			if (this.flag2)
			{
				this.textWriter2.Write(this.charValue3);
			}
		}
		this.textWriter2.Write(':');
	}

	// Token: 0x06000689 RID: 1673 RVA: 0x00017325 File Offset: 0x00015525
	internal override void Method2961()
	{
		this.SetFlagArray2353_2962();
	}

	// Token: 0x0600068A RID: 1674 RVA: 0x0001732D File Offset: 0x0001552D
	private void SetFlagArray2353_2962()
	{
		this.flagArray = 473.Method4460(base.GetStringEscapeHandling(), this.charValue3);
	}

	// Token: 0x0600068B RID: 1675 RVA: 0x00017348 File Offset: 0x00015548
	protected override void Method2963()
	{
		int num = base.GetTop() * this.number2;
		int num2 = this.Method2964();
		this.textWriter2.Write(this.charArray2, 0, num2 + Math.Min(num, 12));
		while ((num -= 12) > 0)
		{
			this.textWriter2.Write(this.charArray2, num2, Math.Min(num, 12));
		}
	}

	// Token: 0x0600068C RID: 1676 RVA: 0x000173AC File Offset: 0x000155AC
	private int Method2964()
	{
		string newLine = this.textWriter2.NewLine;
		int length = newLine.Length;
		bool flag = this.charArray2 != null && this.charArray2.Length == 12 + length;
		if (flag)
		{
			for (int num = 0; num != length; num++)
			{
				if (newLine[num] != this.charArray2[num])
				{
					flag = false;
					break;
				}
			}
		}
		if (!flag)
		{
			this.charArray2 = (newLine + new string(this.charValue2, 12)).ToCharArray();
		}
		return length;
	}

	// Token: 0x0600068D RID: 1677 RVA: 0x0001742C File Offset: 0x0001562C
	protected override void Method2965()
	{
		this.textWriter2.Write(',');
	}

	// Token: 0x0600068E RID: 1678 RVA: 0x0001743B File Offset: 0x0001563B
	protected override void Method2966()
	{
		this.textWriter2.Write(' ');
	}

	// Token: 0x0600068F RID: 1679 RVA: 0x0001744A File Offset: 0x0001564A
	[242(1)]
	private void Method2967(string 1, 216 2)
	{
		this.textWriter2.Write(1);
	}

	// Token: 0x06000690 RID: 1680 RVA: 0x00017458 File Offset: 0x00015658
	public override void WriteValue(object 1)
	{
		if (1 is BigInteger)
		{
			BigInteger bigInteger = (BigInteger)1;
			base.Method7425(216.Integer);
			this.Method2967(bigInteger.ToString(CultureInfo.InvariantCulture), 216.String);
			return;
		}
		base.WriteValue(1);
	}

	// Token: 0x06000691 RID: 1681 RVA: 0x00017497 File Offset: 0x00015697
	public override void WriteNull()
	{
		base.Method7425(216.Null);
		this.Method2967(77.nullText, 216.Null);
	}

	// Token: 0x06000692 RID: 1682 RVA: 0x000174AE File Offset: 0x000156AE
	public override void WriteUndefined()
	{
		base.Method7425(216.Undefined);
		this.Method2967(77.undefinedText, 216.Undefined);
	}

	// Token: 0x06000693 RID: 1683 RVA: 0x000174C5 File Offset: 0x000156C5
	public override void WriteRaw(string 1)
	{
		base.Method7423();
		this.textWriter2.Write(1);
	}

	// Token: 0x06000694 RID: 1684 RVA: 0x000174D9 File Offset: 0x000156D9
	public override void WriteValue(string 1)
	{
		base.Method7425(216.String);
		if (1 == null)
		{
			this.Method2967(77.nullText, 216.Null);
			return;
		}
		this.Method2973(1, true);
	}

	// Token: 0x06000695 RID: 1685 RVA: 0x000174FC File Offset: 0x000156FC
	[242(1)]
	private void Method2973(string 1, bool 2)
	{
		this.Method2999();
		473.Method4462(this.textWriter2, 1, this.charValue3, 2, this.flagArray, base.GetStringEscapeHandling(), this._recoveredType18542355, ref this.charArray);
	}

	// Token: 0x06000696 RID: 1686 RVA: 0x0001752F File Offset: 0x0001572F
	public override void WriteValue(int 1)
	{
		base.Method7425(216.Integer);
		this.Method3000(1);
	}

	// Token: 0x06000697 RID: 1687 RVA: 0x0001753F File Offset: 0x0001573F
	[CLSCompliant(false)]
	public override void WriteValue(uint 1)
	{
		base.Method7425(216.Integer);
		this.Method3000((long)((ulong)1));
	}

	// Token: 0x06000698 RID: 1688 RVA: 0x00017550 File Offset: 0x00015750
	public override void WriteValue(long 1)
	{
		base.Method7425(216.Integer);
		this.Method3000(1);
	}

	// Token: 0x06000699 RID: 1689 RVA: 0x00017560 File Offset: 0x00015760
	[CLSCompliant(false)]
	public override void WriteValue(ulong 1)
	{
		base.Method7425(216.Integer);
		this.Method3000(1, false);
	}

	// Token: 0x0600069A RID: 1690 RVA: 0x00017571 File Offset: 0x00015771
	public override void WriteValue(float 1)
	{
		base.Method7425(216.Float);
		this.Method2967(77.Method5202(1, base.GetFloatFormatHandling(), this.GetChar2351_2946(), false), 216.Float);
	}

	// Token: 0x0600069B RID: 1691 RVA: 0x00017594 File Offset: 0x00015794
	public override void WriteValue(float? 1)
	{
		if (1 == null)
		{
			this.WriteNull();
			return;
		}
		base.Method7425(216.Float);
		this.Method2967(77.Method5202(1.GetValueOrDefault(), base.GetFloatFormatHandling(), this.GetChar2351_2946(), true), 216.Float);
	}

	// Token: 0x0600069C RID: 1692 RVA: 0x000175CD File Offset: 0x000157CD
	public override void WriteValue(double 1)
	{
		base.Method7425(216.Float);
		this.Method2967(77.Method5202(1, base.GetFloatFormatHandling(), this.GetChar2351_2946(), false), 216.Float);
	}

	// Token: 0x0600069D RID: 1693 RVA: 0x000175F0 File Offset: 0x000157F0
	public override void WriteValue(double? 1)
	{
		if (1 == null)
		{
			this.WriteNull();
			return;
		}
		base.Method7425(216.Float);
		this.Method2967(77.Method5202(1.GetValueOrDefault(), base.GetFloatFormatHandling(), this.GetChar2351_2946(), true), 216.Float);
	}

	// Token: 0x0600069E RID: 1694 RVA: 0x00017629 File Offset: 0x00015829
	public override void WriteValue(bool 1)
	{
		base.Method7425(216.Boolean);
		this.Method2967(77.Method5202(1), 216.Boolean);
	}

	// Token: 0x0600069F RID: 1695 RVA: 0x0001752F File Offset: 0x0001572F
	public override void WriteValue(short 1)
	{
		base.Method7425(216.Integer);
		this.Method3000((int)1);
	}

	// Token: 0x060006A0 RID: 1696 RVA: 0x0001752F File Offset: 0x0001572F
	[CLSCompliant(false)]
	public override void WriteValue(ushort 1)
	{
		base.Method7425(216.Integer);
		this.Method3000((int)1);
	}

	// Token: 0x060006A1 RID: 1697 RVA: 0x00017641 File Offset: 0x00015841
	public override void WriteValue(char 1)
	{
		base.Method7425(216.String);
		this.Method2967(77.Method5202(1), 216.String);
	}

	// Token: 0x060006A2 RID: 1698 RVA: 0x0001752F File Offset: 0x0001572F
	public override void WriteValue(byte 1)
	{
		base.Method7425(216.Integer);
		this.Method3000((int)1);
	}

	// Token: 0x060006A3 RID: 1699 RVA: 0x0001752F File Offset: 0x0001572F
	[CLSCompliant(false)]
	public override void WriteValue(sbyte 1)
	{
		base.Method7425(216.Integer);
		this.Method3000((int)1);
	}

	// Token: 0x060006A4 RID: 1700 RVA: 0x00017659 File Offset: 0x00015859
	public override void WriteValue(decimal 1)
	{
		base.Method7425(216.Float);
		this.Method2967(77.Method5202(1), 216.Float);
	}

	// Token: 0x060006A5 RID: 1701 RVA: 0x00017670 File Offset: 0x00015870
	public override void WriteValue(DateTime 1)
	{
		base.Method7425(216.Date);
		1 = 382.Method2108(1, base.GetDateTimeZoneHandling());
		if (538.Method6824(base.DateFormatString))
		{
			int count = this.Method2990(1);
			this.textWriter2.Write(this.charArray, 0, count);
			return;
		}
		this.textWriter2.Write(this.charValue3);
		this.textWriter2.Write(1.ToString(base.DateFormatString, base.GetCulture()));
		this.textWriter2.Write(this.charValue3);
	}

	// Token: 0x060006A6 RID: 1702 RVA: 0x000176FC File Offset: 0x000158FC
	private int Method2990(DateTime 1)
	{
		this.Method2999();
		int num = 0;
		this.charArray[num++] = this.charValue3;
		num = 382.Method2131(this.charArray, num, 1, null, 1.Kind, base.GetDateFormatHandling());
		this.charArray[num++] = this.charValue3;
		return num;
	}

	// Token: 0x060006A7 RID: 1703 RVA: 0x0001775C File Offset: 0x0001595C
	public override void WriteValue(byte[] 1)
	{
		if (1 == null)
		{
			this.WriteNull();
			return;
		}
		base.Method7425(216.Bytes);
		this.textWriter2.Write(this.charValue3);
		this.RecoveredType09292357.Encode(1, 0, 1.Length);
		this.RecoveredType09292357.Flush();
		this.textWriter2.Write(this.charValue3);
	}

	// Token: 0x060006A8 RID: 1704 RVA: 0x000177B8 File Offset: 0x000159B8
	public override void WriteValue(DateTimeOffset 1)
	{
		base.Method7425(216.Date);
		if (538.Method6824(base.DateFormatString))
		{
			int count = this.Method2990(1);
			this.textWriter2.Write(this.charArray, 0, count);
			return;
		}
		this.textWriter2.Write(this.charValue3);
		this.textWriter2.Write(1.ToString(base.DateFormatString, base.GetCulture()));
		this.textWriter2.Write(this.charValue3);
	}

	// Token: 0x060006A9 RID: 1705 RVA: 0x00017838 File Offset: 0x00015A38
	private int Method2990(DateTimeOffset 1)
	{
		this.Method2999();
		int num = 0;
		this.charArray[num++] = this.charValue3;
		num = 382.Method2131(this.charArray, num, (base.GetDateFormatHandling() == (47)0) ? 1.DateTime : 1.UtcDateTime, new TimeSpan?(1.Offset), DateTimeKind.Local, base.GetDateFormatHandling());
		this.charArray[num++] = this.charValue3;
		return num;
	}

	// Token: 0x060006AA RID: 1706 RVA: 0x000178AC File Offset: 0x00015AAC
	public override void WriteValue(Guid 1)
	{
		base.Method7425(216.String);
		string value = 1.ToString("D", CultureInfo.InvariantCulture);
		this.textWriter2.Write(this.charValue3);
		this.textWriter2.Write(value);
		this.textWriter2.Write(this.charValue3);
	}

	// Token: 0x060006AB RID: 1707 RVA: 0x00017904 File Offset: 0x00015B04
	public override void WriteValue(TimeSpan 1)
	{
		base.Method7425(216.String);
		string value = 1.ToString(null, CultureInfo.InvariantCulture);
		this.textWriter2.Write(this.charValue3);
		this.textWriter2.Write(value);
		this.textWriter2.Write(this.charValue3);
	}

	// Token: 0x060006AC RID: 1708 RVA: 0x00017955 File Offset: 0x00015B55
	public override void WriteValue(Uri 1)
	{
		if (1 == null)
		{
			this.WriteNull();
			return;
		}
		base.Method7425(216.String);
		this.Method2973(1.OriginalString, true);
	}

	// Token: 0x060006AD RID: 1709 RVA: 0x0001797C File Offset: 0x00015B7C
	public override void WriteComment(string 1)
	{
		base.Method7427();
		this.textWriter2.Write("/*");
		this.textWriter2.Write(1);
		this.textWriter2.Write("*/");
	}

	// Token: 0x060006AE RID: 1710 RVA: 0x000179B0 File Offset: 0x00015BB0
	[242(1)]
	public override void WriteWhitespace(string 1)
	{
		base.Method7426(1);
		this.textWriter2.Write(1);
	}

	// Token: 0x060006AF RID: 1711 RVA: 0x000179C5 File Offset: 0x00015BC5
	private void Method2999()
	{
		if (this.charArray == null)
		{
			this.charArray = 669.Method9987(this._recoveredType18542355, 35);
		}
	}

	// Token: 0x060006B0 RID: 1712 RVA: 0x000179E4 File Offset: 0x00015BE4
	private void Method3000(long 1)
	{
		if (1 >= 0L && 1 <= 9L)
		{
			this.textWriter2.Write((char)(48L + 1));
			return;
		}
		bool flag = 1 < 0L;
		this.Method3000((ulong)(flag ? (-(ulong)1) : 1), flag);
	}

	// Token: 0x060006B1 RID: 1713 RVA: 0x00017A24 File Offset: 0x00015C24
	private void Method3000(ulong 1, bool 2)
	{
		if (!2 && 1 <= 9UL)
		{
			this.textWriter2.Write((char)(48UL + 1));
			return;
		}
		int count = this.Method3002(1, 2);
		this.textWriter2.Write(this.charArray, 0, count);
	}

	// Token: 0x060006B2 RID: 1714 RVA: 0x00017A68 File Offset: 0x00015C68
	private int Method3002(ulong 1, bool 2)
	{
		if (1 <= (ulong)-1)
		{
			return this.Method3002((uint)1, 2);
		}
		this.Method2999();
		int num = 421.Method3211(1);
		if (2)
		{
			num++;
			this.charArray[0] = '-';
		}
		int num2 = num;
		do
		{
			ulong num3 = 1 / 10UL;
			ulong num4 = 1 - num3 * 10UL;
			this.charArray[--num2] = (char)(48UL + num4);
			1 = num3;
		}
		while (1 != 0UL);
		return num;
	}

	// Token: 0x060006B3 RID: 1715 RVA: 0x00017ACC File Offset: 0x00015CCC
	private void Method3000(int 1)
	{
		if (1 >= 0 && 1 <= 9)
		{
			this.textWriter2.Write((char)(48 + 1));
			return;
		}
		bool flag = 1 < 0;
		this.Method3000((uint)(flag ? (-(uint)1) : 1), flag);
	}

	// Token: 0x060006B4 RID: 1716 RVA: 0x00017B08 File Offset: 0x00015D08
	private void Method3000(uint 1, bool 2)
	{
		if (!2 && 1 <= 9U)
		{
			this.textWriter2.Write((char)(48U + 1));
			return;
		}
		int count = this.Method3002(1, 2);
		this.textWriter2.Write(this.charArray, 0, count);
	}

	// Token: 0x060006B5 RID: 1717 RVA: 0x00017B4C File Offset: 0x00015D4C
	private int Method3002(uint 1, bool 2)
	{
		this.Method2999();
		int num = 421.Method3211((ulong)1);
		if (2)
		{
			num++;
			this.charArray[0] = '-';
		}
		int num2 = num;
		do
		{
			uint num3 = 1 / 10U;
			uint num4 = 1 - num3 * 10U;
			this.charArray[--num2] = (char)(48U + num4);
			1 = num3;
		}
		while (1 != 0U);
		return num;
	}

	// Token: 0x04000476 RID: 1142
	[241(1)]
	private readonly TextWriter textWriter2;

	// Token: 0x04000477 RID: 1143
	private 64 embeddedBase64Encoder;

	// Token: 0x04000478 RID: 1144
	private char charValue2;

	// Token: 0x04000479 RID: 1145
	private int number2;

	// Token: 0x0400047A RID: 1146
	private char charValue3;

	// Token: 0x0400047B RID: 1147
	private bool flag2;

	// Token: 0x0400047C RID: 1148
	private bool[] flagArray;

	// Token: 0x0400047D RID: 1149
	private char[] charArray;

	// Token: 0x0400047E RID: 1150
	private 690<char> _recoveredType18542355;

	// Token: 0x0400047F RID: 1151
	private char[] charArray2;
}
