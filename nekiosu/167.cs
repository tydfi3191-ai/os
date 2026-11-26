using System;
using System.Globalization;
using System.IO;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x020000E4 RID: 228
[242(1)]
[ComVisible(false)]
[241(0)]
public sealed class 167 : 139, 99
{
	// Token: 0x1700004F RID: 79
	// (get) Token: 0x06000625 RID: 1573 RVA: 0x00014008 File Offset: 0x00012208
	// (set) Token: 0x06000626 RID: 1574 RVA: 0x00014010 File Offset: 0x00012210
	[241(2)]
	public 406 RecoveredType04919177
	{
		[242(2)]
		get
		{
			return this._recoveredType04919176;
		}
		[242(2)]
		set
		{
			this._recoveredType04919176 = value;
		}
	}

	// Token: 0x17000050 RID: 80
	// (get) Token: 0x06000627 RID: 1575 RVA: 0x00014019 File Offset: 0x00012219
	// (set) Token: 0x06000628 RID: 1576 RVA: 0x00014021 File Offset: 0x00012221
	[241(2)]
	public 690<char> RecoveredType18549178
	{
		[242(2)]
		get
		{
			return this._recoveredType18549175;
		}
		[242(2)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			this._recoveredType18549175 = value;
		}
	}

	// Token: 0x06000629 RID: 1577 RVA: 0x00014038 File Offset: 0x00012238
	public 167(TextReader 1)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("#=zsocv_UA=");
		}
		this.textReader2 = 1;
		this.number7 = 1;
	}

	// Token: 0x0600062A RID: 1578 RVA: 0x0001405C File Offset: 0x0001225C
	private void Method11512()
	{
		if (this._recoveredType07129173.Method4043())
		{
			this._recoveredType07129173 = new 453(this._recoveredType18549175, 1024);
		}
	}

	// Token: 0x0600062B RID: 1579 RVA: 0x00014081 File Offset: 0x00012281
	private void Method11513(bool 1)
	{
		if (1 && this.charArray3[this.number5] == '\n')
		{
			this.number5++;
		}
		this.Method11514(this.number5);
	}

	// Token: 0x0600062C RID: 1580 RVA: 0x000140B1 File Offset: 0x000122B1
	private void Method11514(int 1)
	{
		this.number7++;
		this.number6 = 1;
	}

	// Token: 0x0600062D RID: 1581 RVA: 0x000140C8 File Offset: 0x000122C8
	private void Method11515(char 1, 815 2)
	{
		this.number5++;
		this.Method11518();
		this.Method11543(1);
		this.Method11516(1, 2);
	}

	// Token: 0x0600062E RID: 1582 RVA: 0x000140F0 File Offset: 0x000122F0
	private void Method11516(char 1, 815 2)
	{
		base.Method2834(true);
		switch (2)
		{
		case (815)1:
		case (815)5:
		case (815)9:
			return;
		case (815)3:
		{
			Guid guid;
			byte[] 3 = (this._recoveredType21659174.GetNumber9360_11933() == 0) ? 418.GetItemArray2540_3182<byte>() : ((this._recoveredType21659174.GetNumber9360_11933() != 36 || !358.Method1508(this._recoveredType21659174.ToString(), out guid)) ? Convert.FromBase64CharArray(this._recoveredType21659174.GetCharArray9358_11931(), this._recoveredType21659174.GetNumber9359_11932(), this._recoveredType21659174.GetNumber9360_11933()) : guid.ToByteArray());
			base.SetToken(216.Bytes, 3, false);
			return;
		}
		case (815)4:
		{
			string 4 = this._recoveredType21659174.ToString();
			base.SetToken(216.String, 4, false);
			this.charValue3 = 1;
			return;
		}
		}
		if (this.dateParseHandling2 != (48)0)
		{
			int num;
			if (2 != (815)6)
			{
				if (2 != (815)7)
				{
					num = (int)this.dateParseHandling2;
				}
				else
				{
					num = 2;
				}
			}
			else
			{
				num = 1;
			}
			DateTimeOffset dateTimeOffset;
			if (num == 1)
			{
				DateTime dateTime;
				if (382.Method2121(this._recoveredType21659174, base.GetDateTimeZoneHandling(), base.GetDateFormatString(), base.Culture, out dateTime))
				{
					base.SetToken(216.Date, dateTime, false);
					return;
				}
			}
			else if (382.Method2123(this._recoveredType21659174, base.GetDateFormatString(), base.Culture, out dateTimeOffset))
			{
				base.SetToken(216.Date, dateTimeOffset, false);
				return;
			}
		}
		base.SetToken(216.String, this._recoveredType21659174.ToString(), false);
		this.charValue3 = 1;
	}

	// Token: 0x0600062F RID: 1583 RVA: 0x00014279 File Offset: 0x00012479
	private static void Method11517(char[] 1, int 2, char[] 3, int 4, int 5)
	{
		Buffer.BlockCopy(1, 2 * 2, 3, 4 * 2, 5 * 2);
	}

	// Token: 0x06000630 RID: 1584 RVA: 0x0001428C File Offset: 0x0001248C
	private void Method11518()
	{
		int num = this.charArray3.Length;
		if ((double)(num - this.number5) <= (double)num * 0.1 || num >= 1073741823)
		{
			int num2 = this.number4 - this.number5;
			if (num2 > 0)
			{
				167.Method11517(this.charArray3, this.number5, this.charArray3, 0, num2);
			}
			this.number6 -= this.number5;
			this.number5 = 0;
			this.number4 = num2;
			this.charArray3[this.number4] = '\0';
		}
	}

	// Token: 0x06000631 RID: 1585 RVA: 0x0001431B File Offset: 0x0001251B
	private int Method11519(bool 1)
	{
		return this.Method11519(1, 0);
	}

	// Token: 0x06000632 RID: 1586 RVA: 0x00014328 File Offset: 0x00012528
	private void Method11520(bool 1, int 2)
	{
		if (this.number4 + 2 < this.charArray3.Length - 1)
		{
			return;
		}
		if (1)
		{
			int num = this.charArray3.Length * 2;
			int 3 = Math.Max((num < 0) ? int.MaxValue : num, this.number4 + 2 + 1);
			char[] 4 = 669.Method9987(this._recoveredType18549175, 3);
			167.Method11517(this.charArray3, 0, 4, 0, this.charArray3.Length);
			669.Method9988(this._recoveredType18549175, this.charArray3);
			this.charArray3 = 4;
			return;
		}
		int num2 = this.number4 - this.number5;
		if (num2 + 2 + 1 >= this.charArray3.Length)
		{
			char[] 5 = 669.Method9987(this._recoveredType18549175, num2 + 2 + 1);
			if (num2 > 0)
			{
				167.Method11517(this.charArray3, this.number5, 5, 0, num2);
			}
			669.Method9988(this._recoveredType18549175, this.charArray3);
			this.charArray3 = 5;
		}
		else if (num2 > 0)
		{
			167.Method11517(this.charArray3, this.number5, this.charArray3, 0, num2);
		}
		this.number6 -= this.number5;
		this.number5 = 0;
		this.number4 = num2;
	}

	// Token: 0x06000633 RID: 1587 RVA: 0x00014454 File Offset: 0x00012654
	private int Method11519(bool 1, int 2)
	{
		if (this.flag3)
		{
			return 0;
		}
		this.Method11520(1, 2);
		int count = this.charArray3.Length - this.number4 - 1;
		int num = this.textReader2.Read(this.charArray3, this.number4, count);
		this.number4 += num;
		if (num == 0)
		{
			this.flag3 = true;
		}
		this.charArray3[this.number4] = '\0';
		return num;
	}

	// Token: 0x06000634 RID: 1588 RVA: 0x000144C5 File Offset: 0x000126C5
	private bool Method11522(int 1, bool 2)
	{
		return this.number5 + 1 < this.number4 || this.Method11523(1, 2);
	}

	// Token: 0x06000635 RID: 1589 RVA: 0x000144E4 File Offset: 0x000126E4
	private bool Method11523(int 1, bool 2)
	{
		if (this.flag3)
		{
			return false;
		}
		int num = this.number5 + 1 - this.number4 + 1;
		int num2 = 0;
		do
		{
			int num3 = this.Method11519(2, num - num2);
			if (num3 == 0)
			{
				break;
			}
			num2 += num3;
		}
		while (num2 < num);
		return num2 >= num;
	}

	// Token: 0x06000636 RID: 1590 RVA: 0x0001452C File Offset: 0x0001272C
	public override bool Read()
	{
		this.Method11542();
		for (;;)
		{
			switch (this.readerState)
			{
			case 139.140.Start:
			case 139.140.Property:
			case 139.140.ArrayStart:
			case 139.140.Array:
			case 139.140.ConstructorStart:
			case 139.140.Constructor:
				goto IL_49;
			case 139.140.ObjectStart:
			case 139.140.Object:
				goto IL_50;
			case 139.140.PostValue:
				if (this.Method11551(false))
				{
					return true;
				}
				continue;
			case 139.140.Finished:
				goto IL_57;
			}
			break;
		}
		goto IL_C3;
		IL_49:
		return this.Method11557();
		IL_50:
		return this.Method11552();
		IL_57:
		if (!this.Method11522(0, false))
		{
			base.SetToken(216.None);
			return false;
		}
		this.Method11560();
		if (this.flag3)
		{
			base.SetToken(216.None);
			return false;
		}
		if (this.charArray3[this.number5] == '/')
		{
			this.Method11566(true);
			return true;
		}
		throw 141.Method12886(this, "Additional text encountered after finished reading JSON content: {0}.".Method6825(CultureInfo.InvariantCulture, this.charArray3[this.number5]));
		IL_C3:
		throw 141.Method12886(this, "Unexpected state: {0}.".Method6825(CultureInfo.InvariantCulture, base.GetReaderState()));
	}

	// Token: 0x06000637 RID: 1591 RVA: 0x0001462A File Offset: 0x0001282A
	public override int? ReadAsInt32()
	{
		return (int?)this.Method11534((815)1);
	}

	// Token: 0x06000638 RID: 1592 RVA: 0x00014638 File Offset: 0x00012838
	public override DateTime? ReadAsDateTime()
	{
		return (DateTime?)this.Method11529((815)6);
	}

	// Token: 0x06000639 RID: 1593 RVA: 0x00014646 File Offset: 0x00012846
	[242(2)]
	public override string ReadAsString()
	{
		return (string)this.Method11529((815)4);
	}

	// Token: 0x0600063A RID: 1594 RVA: 0x00014654 File Offset: 0x00012854
	[242(2)]
	public override byte[] ReadAsBytes()
	{
		this.Method11542();
		bool flag = false;
		switch (this.readerState)
		{
		case 139.140.Start:
		case 139.140.Property:
		case 139.140.ArrayStart:
		case 139.140.Array:
		case 139.140.ConstructorStart:
		case 139.140.Constructor:
			break;
		case 139.140.Complete:
		case 139.140.ObjectStart:
		case 139.140.Object:
		case 139.140.Closed:
		case 139.140.Error:
			goto IL_23E;
		case 139.140.PostValue:
			if (this.Method11551(true))
			{
				return null;
			}
			break;
		case 139.140.Finished:
			this.Method11540();
			return null;
		default:
			goto IL_23E;
		}
		char c;
		for (;;)
		{
			c = this.charArray3[this.number5];
			if (c <= '\'')
			{
				if (c <= '\r')
				{
					if (c != '\0')
					{
						switch (c)
						{
						case '\t':
							break;
						case '\n':
							this.Method11558();
							continue;
						case '\v':
						case '\f':
							goto IL_215;
						case '\r':
							this.Method11559(false);
							continue;
						default:
							goto IL_215;
						}
					}
					else
					{
						if (this.Method11541())
						{
							break;
						}
						continue;
					}
				}
				else if (c != ' ')
				{
					if (c != '"' && c != '\'')
					{
						goto IL_215;
					}
					goto IL_FF;
				}
				this.number5++;
				continue;
			}
			if (c <= '[')
			{
				if (c == ',')
				{
					this.Method11533();
					continue;
				}
				if (c == '/')
				{
					this.Method11566(false);
					continue;
				}
				if (c == '[')
				{
					goto IL_175;
				}
			}
			else
			{
				if (c == ']')
				{
					goto IL_1B0;
				}
				if (c == 'n')
				{
					goto IL_191;
				}
				if (c == '{')
				{
					this.number5++;
					base.SetToken(216.StartObject);
					base.Method2829();
					flag = true;
					continue;
				}
			}
			IL_215:
			this.number5++;
			if (!char.IsWhiteSpace(c))
			{
				goto Block_22;
			}
		}
		base.SetToken(216.None, null, false);
		return null;
		IL_FF:
		this.Method11515(c, (815)3);
		byte[] array = (byte[])this.GetValue();
		if (flag)
		{
			base.Method2827();
			if (this.GetTokenType() != 216.EndObject)
			{
				throw 141.Method12886(this, "Error reading bytes. Unexpected token: {0}.".Method6825(CultureInfo.InvariantCulture, this.GetTokenType()));
			}
			base.SetToken(216.Bytes, array, false);
		}
		return array;
		IL_175:
		this.number5++;
		base.SetToken(216.StartArray);
		return base.Method2815();
		IL_191:
		this.Method11539();
		return null;
		IL_1B0:
		this.number5++;
		if (this.readerState == 139.140.Array || this.readerState == 139.140.ArrayStart || this.readerState == 139.140.PostValue)
		{
			base.SetToken(216.EndArray);
			return null;
		}
		throw this.Method11531(c);
		Block_22:
		throw this.Method11531(c);
		IL_23E:
		throw 141.Method12886(this, "Unexpected state: {0}.".Method6825(CultureInfo.InvariantCulture, base.GetReaderState()));
	}

	// Token: 0x0600063B RID: 1595 RVA: 0x000148C0 File Offset: 0x00012AC0
	[242(2)]
	private object Method11529(815 1)
	{
		this.Method11542();
		switch (this.readerState)
		{
		case 139.140.Start:
		case 139.140.Property:
		case 139.140.ArrayStart:
		case 139.140.Array:
		case 139.140.ConstructorStart:
		case 139.140.Constructor:
			break;
		case 139.140.Complete:
		case 139.140.ObjectStart:
		case 139.140.Object:
		case 139.140.Closed:
		case 139.140.Error:
			goto IL_2E1;
		case 139.140.PostValue:
			if (this.Method11551(true))
			{
				return null;
			}
			break;
		case 139.140.Finished:
			this.Method11540();
			return null;
		default:
			goto IL_2E1;
		}
		char c;
		for (;;)
		{
			c = this.charArray3[this.number5];
			if (c <= 'I')
			{
				if (c <= '\r')
				{
					if (c != '\0')
					{
						switch (c)
						{
						case '\t':
							break;
						case '\n':
							this.Method11558();
							continue;
						case '\v':
						case '\f':
							goto IL_2B8;
						case '\r':
							this.Method11559(false);
							continue;
						default:
							goto IL_2B8;
						}
					}
					else
					{
						if (this.Method11541())
						{
							break;
						}
						continue;
					}
				}
				else
				{
					switch (c)
					{
					case ' ':
						break;
					case '!':
					case '#':
					case '$':
					case '%':
					case '&':
					case '(':
					case ')':
					case '*':
					case '+':
						goto IL_2B8;
					case '"':
					case '\'':
						goto IL_165;
					case ',':
						this.Method11533();
						continue;
					case '-':
						goto IL_175;
					case '.':
					case '0':
					case '1':
					case '2':
					case '3':
					case '4':
					case '5':
					case '6':
					case '7':
					case '8':
					case '9':
						goto IL_1A8;
					case '/':
						this.Method11566(false);
						continue;
					default:
						if (c != 'I')
						{
							goto IL_2B8;
						}
						goto IL_224;
					}
				}
				this.number5++;
				continue;
			}
			if (c <= ']')
			{
				if (c == 'N')
				{
					goto IL_22C;
				}
				if (c == ']')
				{
					goto IL_253;
				}
			}
			else
			{
				if (c == 'f')
				{
					goto IL_1D0;
				}
				if (c == 'n')
				{
					goto IL_234;
				}
				if (c == 't')
				{
					goto IL_1D0;
				}
			}
			IL_2B8:
			this.number5++;
			if (!char.IsWhiteSpace(c))
			{
				goto Block_24;
			}
		}
		base.SetToken(216.None, null, false);
		return null;
		IL_165:
		this.Method11515(c, 1);
		return this.Method11530(1);
		IL_175:
		if (this.Method11522(1, true) && this.charArray3[this.number5 + 1] == 'I')
		{
			return this.Method11576(1);
		}
		this.Method11562(1);
		return this.GetValue();
		IL_1A8:
		if (1 != (815)4)
		{
			this.number5++;
			throw this.Method11531(c);
		}
		this.Method11562((815)4);
		return this.GetValue();
		IL_1D0:
		if (1 != (815)4)
		{
			this.number5++;
			throw this.Method11531(c);
		}
		string text = (c == 't') ? 77.trueText : 77.falseText;
		if (!this.Method11570(text))
		{
			throw this.Method11531(this.charArray3[this.number5]);
		}
		base.SetToken(216.String, text);
		return text;
		IL_224:
		return this.Method11578(1);
		IL_22C:
		return this.Method11580(1);
		IL_234:
		this.Method11539();
		return null;
		IL_253:
		this.number5++;
		if (this.readerState == 139.140.Array || this.readerState == 139.140.ArrayStart || this.readerState == 139.140.PostValue)
		{
			base.SetToken(216.EndArray);
			return null;
		}
		throw this.Method11531(c);
		Block_24:
		throw this.Method11531(c);
		IL_2E1:
		throw 141.Method12886(this, "Unexpected state: {0}.".Method6825(CultureInfo.InvariantCulture, base.GetReaderState()));
	}

	// Token: 0x0600063C RID: 1596 RVA: 0x00014BD0 File Offset: 0x00012DD0
	[242(2)]
	private object Method11530(815 1)
	{
		switch (1)
		{
		case (815)3:
		case (815)4:
			return this.GetValue();
		case (815)6:
		{
			object value = this.GetValue();
			if (value is DateTime)
			{
				DateTime dateTime = (DateTime)value;
				return dateTime;
			}
			return base.Method2824((string)this.GetValue());
		}
		case (815)7:
		{
			object value = this.GetValue();
			if (value is DateTimeOffset)
			{
				DateTimeOffset dateTimeOffset = (DateTimeOffset)value;
				return dateTimeOffset;
			}
			return base.Method2826((string)this.GetValue());
		}
		}
		throw new ArgumentOutOfRangeException("readType");
	}

	// Token: 0x0600063D RID: 1597 RVA: 0x00014C74 File Offset: 0x00012E74
	private 141 Method11531(char 1)
	{
		return 141.Method12886(this, "Unexpected character encountered while parsing value: {0}.".Method6825(CultureInfo.InvariantCulture, 1));
	}

	// Token: 0x0600063E RID: 1598 RVA: 0x00014C94 File Offset: 0x00012E94
	public override bool? ReadAsBoolean()
	{
		this.Method11542();
		switch (this.readerState)
		{
		case 139.140.Start:
		case 139.140.Property:
		case 139.140.ArrayStart:
		case 139.140.Array:
		case 139.140.ConstructorStart:
		case 139.140.Constructor:
			break;
		case 139.140.Complete:
		case 139.140.ObjectStart:
		case 139.140.Object:
		case 139.140.Closed:
		case 139.140.Error:
			goto IL_2DE;
		case 139.140.PostValue:
			if (this.Method11551(true))
			{
				return null;
			}
			break;
		case 139.140.Finished:
			this.Method11540();
			return null;
		default:
			goto IL_2DE;
		}
		char c;
		for (;;)
		{
			c = this.charArray3[this.number5];
			if (c <= '9')
			{
				if (c != '\0')
				{
					switch (c)
					{
					case '\t':
						break;
					case '\n':
						this.Method11558();
						continue;
					case '\v':
					case '\f':
						goto IL_2AD;
					case '\r':
						this.Method11559(false);
						continue;
					default:
						switch (c)
						{
						case ' ':
							break;
						case '!':
						case '#':
						case '$':
						case '%':
						case '&':
						case '(':
						case ')':
						case '*':
						case '+':
							goto IL_2AD;
						case '"':
						case '\'':
							goto IL_158;
						case ',':
							this.Method11533();
							continue;
						case '-':
						case '.':
						case '0':
						case '1':
						case '2':
						case '3':
						case '4':
						case '5':
						case '6':
						case '7':
						case '8':
						case '9':
							goto IL_188;
						case '/':
							this.Method11566(false);
							continue;
						default:
							goto IL_2AD;
						}
						break;
					}
					this.number5++;
					continue;
				}
				if (this.Method11541())
				{
					break;
				}
				continue;
			}
			else if (c <= 'f')
			{
				if (c == ']')
				{
					goto IL_240;
				}
				if (c == 'f')
				{
					goto IL_1DB;
				}
			}
			else
			{
				if (c == 'n')
				{
					goto IL_178;
				}
				if (c == 't')
				{
					goto IL_1DB;
				}
			}
			IL_2AD:
			this.number5++;
			if (!char.IsWhiteSpace(c))
			{
				goto Block_18;
			}
		}
		base.SetToken(216.None, null, false);
		return null;
		IL_158:
		this.Method11515(c, (815)0);
		return base.Method2820(this._recoveredType21659174.ToString());
		IL_178:
		this.Method11539();
		return null;
		IL_188:
		this.Method11562((815)0);
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
		base.SetToken(216.Boolean, flag2, false);
		return new bool?(flag2);
		IL_1DB:
		bool flag3 = c == 't';
		string <<EMPTY_NAME>> = flag3 ? 77.trueText : 77.falseText;
		if (!this.Method11570(<<EMPTY_NAME>>))
		{
			throw this.Method11531(this.charArray3[this.number5]);
		}
		base.SetToken(216.Boolean, 420.Method3206(flag3));
		return new bool?(flag3);
		IL_240:
		this.number5++;
		if (this.readerState == 139.140.Array || this.readerState == 139.140.ArrayStart || this.readerState == 139.140.PostValue)
		{
			base.SetToken(216.EndArray);
			return null;
		}
		throw this.Method11531(c);
		Block_18:
		throw this.Method11531(c);
		IL_2DE:
		throw 141.Method12886(this, "Unexpected state: {0}.".Method6825(CultureInfo.InvariantCulture, base.GetReaderState()));
	}

	// Token: 0x0600063F RID: 1599 RVA: 0x00014F9F File Offset: 0x0001319F
	private void Method11533()
	{
		this.number5++;
		if (this.readerState != 139.140.PostValue)
		{
			base.SetToken(216.Undefined);
			141 <<EMPTY_NAME>> = this.Method11531(',');
			this.number5--;
			throw <<EMPTY_NAME>>;
		}
		base.Method2837();
	}

	// Token: 0x06000640 RID: 1600 RVA: 0x00014FE0 File Offset: 0x000131E0
	[242(2)]
	private object Method11534(815 1)
	{
		this.Method11542();
		switch (this.readerState)
		{
		case 139.140.Start:
		case 139.140.Property:
		case 139.140.ArrayStart:
		case 139.140.Array:
		case 139.140.ConstructorStart:
		case 139.140.Constructor:
			break;
		case 139.140.Complete:
		case 139.140.ObjectStart:
		case 139.140.Object:
		case 139.140.Closed:
		case 139.140.Error:
			goto IL_250;
		case 139.140.PostValue:
			if (this.Method11551(true))
			{
				return null;
			}
			break;
		case 139.140.Finished:
			this.Method11540();
			return null;
		default:
			goto IL_250;
		}
		char c;
		for (;;)
		{
			c = this.charArray3[this.number5];
			if (c <= '9')
			{
				if (c != '\0')
				{
					switch (c)
					{
					case '\t':
						break;
					case '\n':
						this.Method11558();
						continue;
					case '\v':
					case '\f':
						goto IL_227;
					case '\r':
						this.Method11559(false);
						continue;
					default:
						switch (c)
						{
						case ' ':
							break;
						case '!':
						case '#':
						case '$':
						case '%':
						case '&':
						case '(':
						case ')':
						case '*':
						case '+':
							goto IL_227;
						case '"':
						case '\'':
							goto IL_142;
						case ',':
							this.Method11533();
							continue;
						case '-':
							goto IL_16A;
						case '.':
						case '0':
						case '1':
						case '2':
						case '3':
						case '4':
						case '5':
						case '6':
						case '7':
						case '8':
						case '9':
							goto IL_19D;
						case '/':
							this.Method11566(false);
							continue;
						default:
							goto IL_227;
						}
						break;
					}
					this.number5++;
					continue;
				}
				if (this.Method11541())
				{
					break;
				}
				continue;
			}
			else if (c <= 'N')
			{
				if (c == 'I')
				{
					goto IL_162;
				}
				if (c == 'N')
				{
					goto IL_15A;
				}
			}
			else
			{
				if (c == ']')
				{
					goto IL_1C2;
				}
				if (c == 'n')
				{
					goto IL_152;
				}
			}
			IL_227:
			this.number5++;
			if (!char.IsWhiteSpace(c))
			{
				goto Block_17;
			}
		}
		base.SetToken(216.None, null, false);
		return null;
		IL_142:
		this.Method11515(c, 1);
		return this.Method11535(1);
		IL_152:
		this.Method11539();
		return null;
		IL_15A:
		return this.Method11580(1);
		IL_162:
		return this.Method11578(1);
		IL_16A:
		if (this.Method11522(1, true) && this.charArray3[this.number5 + 1] == 'I')
		{
			return this.Method11576(1);
		}
		this.Method11562(1);
		return this.GetValue();
		IL_19D:
		this.Method11562(1);
		return this.GetValue();
		IL_1C2:
		this.number5++;
		if (this.readerState == 139.140.Array || this.readerState == 139.140.ArrayStart || this.readerState == 139.140.PostValue)
		{
			base.SetToken(216.EndArray);
			return null;
		}
		throw this.Method11531(c);
		Block_17:
		throw this.Method11531(c);
		IL_250:
		throw 141.Method12886(this, "Unexpected state: {0}.".Method6825(CultureInfo.InvariantCulture, base.GetReaderState()));
	}

	// Token: 0x06000641 RID: 1601 RVA: 0x00015260 File Offset: 0x00013460
	[242(2)]
	private object Method11535(815 1)
	{
		object result;
		if (1 != (815)1)
		{
			if (1 != (815)5)
			{
				if (1 != (815)8)
				{
					throw new ArgumentOutOfRangeException("readType");
				}
				result = base.Method2818(this._recoveredType21659174.ToString());
			}
			else
			{
				result = base.Method2822(this._recoveredType21659174.ToString());
			}
		}
		else
		{
			result = base.Method2812(this._recoveredType21659174.ToString());
		}
		return result;
	}

	// Token: 0x06000642 RID: 1602 RVA: 0x000152E4 File Offset: 0x000134E4
	public override DateTimeOffset? ReadAsDateTimeOffset()
	{
		return (DateTimeOffset?)this.Method11529((815)7);
	}

	// Token: 0x06000643 RID: 1603 RVA: 0x000152F2 File Offset: 0x000134F2
	public override decimal? ReadAsDecimal()
	{
		return (decimal?)this.Method11534((815)5);
	}

	// Token: 0x06000644 RID: 1604 RVA: 0x00015300 File Offset: 0x00013500
	public override double? ReadAsDouble()
	{
		return (double?)this.Method11534((815)8);
	}

	// Token: 0x06000645 RID: 1605 RVA: 0x00015310 File Offset: 0x00013510
	private void Method11539()
	{
		if (!this.Method11522(1, true))
		{
			this.number5 = this.number4;
			throw base.Method2828();
		}
		if (this.charArray3[this.number5 + 1] == 'u')
		{
			this.Method11573();
			return;
		}
		this.number5 += 2;
		throw this.Method11531(this.charArray3[this.number5 - 1]);
	}

	// Token: 0x06000646 RID: 1606 RVA: 0x00015378 File Offset: 0x00013578
	private void Method11540()
	{
		if (this.Method11522(0, false))
		{
			this.Method11560();
			if (this.flag3)
			{
				return;
			}
			if (this.charArray3[this.number5] != '/')
			{
				throw 141.Method12886(this, "Additional text encountered after finished reading JSON content: {0}.".Method6825(CultureInfo.InvariantCulture, this.charArray3[this.number5]));
			}
			this.Method11566(false);
		}
		base.SetToken(216.None);
	}

	// Token: 0x06000647 RID: 1607 RVA: 0x000153E5 File Offset: 0x000135E5
	private bool Method11541()
	{
		if (this.number4 == this.number5)
		{
			if (this.Method11519(false) == 0)
			{
				this.flag3 = true;
				return true;
			}
		}
		else
		{
			this.number5++;
		}
		return false;
	}

	// Token: 0x06000648 RID: 1608 RVA: 0x00015416 File Offset: 0x00013616
	private void Method11542()
	{
		if (this.charArray3 == null)
		{
			this.charArray3 = 669.Method9987(this._recoveredType18549175, 1024);
			this.charArray3[0] = '\0';
		}
	}

	// Token: 0x06000649 RID: 1609 RVA: 0x00015440 File Offset: 0x00013640
	private void Method11543(char 1)
	{
		int num = this.number5;
		int 2 = this.number5;
		int num2 = this.number5;
		this._recoveredType07129173.SetNumber3143_4042(0);
		char c2;
		for (;;)
		{
			char c = this.charArray3[num++];
			if (c <= '\r')
			{
				if (c != '\0')
				{
					if (c != '\n')
					{
						if (c == '\r')
						{
							this.number5 = num - 1;
							this.Method11559(true);
							num = this.number5;
						}
					}
					else
					{
						this.number5 = num - 1;
						this.Method11558();
						num = this.number5;
					}
				}
				else if (this.number4 == num - 1)
				{
					num--;
					if (this.Method11519(true) == 0)
					{
						break;
					}
				}
			}
			else if (c != '"' && c != '\'')
			{
				if (c == '\\')
				{
					this.number5 = num;
					if (!this.Method11522(0, true))
					{
						goto Block_10;
					}
					int 3 = num - 1;
					c2 = this.charArray3[num];
					num++;
					char c3;
					if (c2 <= '\\')
					{
						if (c2 <= '\'')
						{
							if (c2 != '"' && c2 != '\'')
							{
								goto Block_14;
							}
						}
						else if (c2 != '/')
						{
							if (c2 != '\\')
							{
								goto Block_16;
							}
							c3 = '\\';
							goto IL_287;
						}
						c3 = c2;
					}
					else if (c2 <= 'f')
					{
						if (c2 != 'b')
						{
							if (c2 != 'f')
							{
								goto Block_19;
							}
							c3 = '\f';
						}
						else
						{
							c3 = '\b';
						}
					}
					else
					{
						if (c2 != 'n')
						{
							switch (c2)
							{
							case 'r':
								c3 = '\r';
								goto IL_287;
							case 't':
								c3 = '\t';
								goto IL_287;
							case 'u':
								this.number5 = num;
								c3 = this.Method11547();
								if (538.Method6840(c3))
								{
									c3 = '�';
								}
								else if (538.Method6839(c3))
								{
									bool flag;
									do
									{
										flag = false;
										if (this.Method11522(2, true) && this.charArray3[this.number5] == '\\' && this.charArray3[this.number5 + 1] == 'u')
										{
											char 4 = c3;
											this.number5 += 2;
											c3 = this.Method11547();
											if (!538.Method6840(c3))
											{
												if (538.Method6839(c3))
												{
													4 = '�';
													flag = true;
												}
												else
												{
													4 = '�';
												}
											}
											this.Method11512();
											this.Method11545(4, num2, 3);
											num2 = this.number5;
										}
										else
										{
											c3 = '�';
										}
									}
									while (flag);
								}
								num = this.number5;
								goto IL_287;
							}
							goto Block_21;
						}
						c3 = '\n';
					}
					IL_287:
					this.Method11512();
					this.Method11545(c3, num2, 3);
					num2 = num;
				}
			}
			else if (this.charArray3[num - 1] == 1)
			{
				goto Block_28;
			}
		}
		this.number5 = num;
		throw 141.Method12886(this, "Unterminated string. Expected delimiter: {0}.".Method6825(CultureInfo.InvariantCulture, 1));
		Block_10:
		throw 141.Method12886(this, "Unterminated string. Expected delimiter: {0}.".Method6825(CultureInfo.InvariantCulture, 1));
		Block_14:
		Block_16:
		Block_19:
		Block_21:
		this.number5 = num;
		throw 141.Method12886(this, "Bad JSON escape sequence: {0}.".Method6825(CultureInfo.InvariantCulture, "\\" + c2.ToString()));
		Block_28:
		this.Method11544(num - 1, 2, num2);
	}

	// Token: 0x0600064A RID: 1610 RVA: 0x00015740 File Offset: 0x00013940
	private void Method11544(int 1, int 2, int 3)
	{
		if (2 == 3)
		{
			this._recoveredType21659174 = new 743(this.charArray3, 2, 1 - 2);
		}
		else
		{
			this.Method11512();
			if (1 > 3)
			{
				this._recoveredType07129173.Method4044(this._recoveredType18549175, this.charArray3, 3, 1 - 3);
			}
			this._recoveredType21659174 = new 743(this._recoveredType07129173.GetCharArray3142_4049(), 0, this._recoveredType07129173.GetNumber3143_4041());
		}
		this.number5 = 1 + 1;
	}

	// Token: 0x0600064B RID: 1611 RVA: 0x000157B8 File Offset: 0x000139B8
	private void Method11545(char 1, int 2, int 3)
	{
		if (3 > 2)
		{
			this._recoveredType07129173.Method4044(this._recoveredType18549175, this.charArray3, 2, 3 - 2);
		}
		this._recoveredType07129173.Method4044(this._recoveredType18549175, 1);
	}

	// Token: 0x0600064C RID: 1612 RVA: 0x000157EC File Offset: 0x000139EC
	private char Method11546(bool 1)
	{
		if (!1)
		{
			throw 141.Method12886(this, "Unexpected end while parsing Unicode escape sequence.");
		}
		int value;
		if (358.Method1509(this.charArray3, this.number5, this.number5 + 4, out value))
		{
			char result = Convert.ToChar(value);
			this.number5 += 4;
			return result;
		}
		throw 141.Method12886(this, "Invalid Unicode escape sequence: \\u{0}.".Method6825(CultureInfo.InvariantCulture, new string(this.charArray3, this.number5, 4)));
	}

	// Token: 0x0600064D RID: 1613 RVA: 0x00015861 File Offset: 0x00013A61
	private char Method11547()
	{
		return this.Method11546(this.Method11522(4, true));
	}

	// Token: 0x0600064E RID: 1614 RVA: 0x00015874 File Offset: 0x00013A74
	private void Method11548()
	{
		int num = this.number5;
		for (;;)
		{
			char c = this.charArray3[num];
			if (c == '\0')
			{
				this.number5 = num;
				if (this.number4 != num)
				{
					return;
				}
				if (this.Method11519(true) == 0)
				{
					break;
				}
			}
			else
			{
				if (this.Method11549(c, num))
				{
					return;
				}
				num++;
			}
		}
	}

	// Token: 0x0600064F RID: 1615 RVA: 0x000158C0 File Offset: 0x00013AC0
	private bool Method11549(char 1, int 2)
	{
		if (1 <= 'X')
		{
			switch (1)
			{
			case '+':
			case '-':
			case '.':
			case '0':
			case '1':
			case '2':
			case '3':
			case '4':
			case '5':
			case '6':
			case '7':
			case '8':
			case '9':
			case 'A':
			case 'B':
			case 'C':
			case 'D':
			case 'E':
			case 'F':
				break;
			case ',':
			case '/':
			case ':':
			case ';':
			case '<':
			case '=':
			case '>':
			case '?':
			case '@':
				goto IL_B0;
			default:
				if (1 != 'X')
				{
					goto IL_B0;
				}
				break;
			}
		}
		else
		{
			switch (1)
			{
			case 'a':
			case 'b':
			case 'c':
			case 'd':
			case 'e':
			case 'f':
				break;
			default:
				if (1 != 'x')
				{
					goto IL_B0;
				}
				break;
			}
		}
		return false;
		IL_B0:
		this.number5 = 2;
		if (char.IsWhiteSpace(1) || 1 == ',' || 1 == '}' || 1 == ']' || 1 == ')' || 1 == '/')
		{
			return true;
		}
		throw 141.Method12886(this, "Unexpected character encountered while parsing number: {0}.".Method6825(CultureInfo.InvariantCulture, 1));
	}

	// Token: 0x06000650 RID: 1616 RVA: 0x000159C2 File Offset: 0x00013BC2
	private void Method11550()
	{
		this._recoveredType07129173.SetNumber3143_4042(0);
		this._recoveredType21659174 = default(743);
	}

	// Token: 0x06000651 RID: 1617 RVA: 0x000159DC File Offset: 0x00013BDC
	private bool Method11551(bool 1)
	{
		char c;
		for (;;)
		{
			c = this.charArray3[this.number5];
			if (c <= ')')
			{
				if (c <= '\r')
				{
					if (c != '\0')
					{
						switch (c)
						{
						case '\t':
							break;
						case '\n':
							this.Method11558();
							continue;
						case '\v':
						case '\f':
							goto IL_14C;
						case '\r':
							this.Method11559(false);
							continue;
						default:
							goto IL_14C;
						}
					}
					else
					{
						if (this.number4 != this.number5)
						{
							this.number5++;
							continue;
						}
						if (this.Method11519(false) == 0)
						{
							break;
						}
						continue;
					}
				}
				else if (c != ' ')
				{
					if (c != ')')
					{
						goto IL_14C;
					}
					goto IL_E2;
				}
				this.number5++;
				continue;
			}
			if (c <= '/')
			{
				if (c == ',')
				{
					goto IL_10C;
				}
				if (c == '/')
				{
					this.Method11566(!1);
					if (!1)
					{
						return true;
					}
					continue;
				}
			}
			else
			{
				if (c == ']')
				{
					goto IL_CA;
				}
				if (c == '}')
				{
					goto IL_B2;
				}
			}
			IL_14C:
			if (!char.IsWhiteSpace(c))
			{
				goto IL_167;
			}
			this.number5++;
		}
		this.readerState = 139.140.Finished;
		return false;
		IL_B2:
		this.number5++;
		base.SetToken(216.EndObject);
		return true;
		IL_CA:
		this.number5++;
		base.SetToken(216.EndArray);
		return true;
		IL_E2:
		this.number5++;
		base.SetToken(216.EndConstructor);
		return true;
		IL_10C:
		this.number5++;
		base.Method2837();
		return false;
		IL_167:
		if (base.GetSupportMultipleContent() && this.GetDepth() == 0)
		{
			base.Method2837();
			return false;
		}
		throw 141.Method12886(this, "After parsing a value an unexpected character was encountered: {0}.".Method6825(CultureInfo.InvariantCulture, c));
	}

	// Token: 0x06000652 RID: 1618 RVA: 0x00015B84 File Offset: 0x00013D84
	private bool Method11552()
	{
		for (;;)
		{
			char c = this.charArray3[this.number5];
			if (c <= '\r')
			{
				if (c != '\0')
				{
					switch (c)
					{
					case '\t':
						break;
					case '\n':
						this.Method11558();
						continue;
					case '\v':
					case '\f':
						goto IL_BD;
					case '\r':
						this.Method11559(false);
						continue;
					default:
						goto IL_BD;
					}
				}
				else
				{
					if (this.number4 != this.number5)
					{
						this.number5++;
						continue;
					}
					if (this.Method11519(false) == 0)
					{
						break;
					}
					continue;
				}
			}
			else if (c != ' ')
			{
				if (c == '/')
				{
					goto IL_8A;
				}
				if (c != '}')
				{
					goto IL_BD;
				}
				goto IL_72;
			}
			this.number5++;
			continue;
			IL_BD:
			if (!char.IsWhiteSpace(c))
			{
				goto IL_D8;
			}
			this.number5++;
		}
		return false;
		IL_72:
		base.SetToken(216.EndObject);
		this.number5++;
		return true;
		IL_8A:
		this.Method11566(true);
		return true;
		IL_D8:
		return this.Method11553();
	}

	// Token: 0x06000653 RID: 1619 RVA: 0x00015C70 File Offset: 0x00013E70
	private bool Method11553()
	{
		char c = this.charArray3[this.number5];
		char c2;
		if (c == '"' || c == '\'')
		{
			this.number5++;
			c2 = c;
			this.Method11518();
			this.Method11543(c2);
		}
		else
		{
			if (!this.Method11554(c))
			{
				throw 141.Method12886(this, "Invalid property identifier character: {0}.".Method6825(CultureInfo.InvariantCulture, this.charArray3[this.number5]));
			}
			c2 = '\0';
			this.Method11518();
			this.Method11555();
		}
		string text;
		if (this.RecoveredType04919177 != null)
		{
			text = this.RecoveredType04919177.Method7974(this._recoveredType21659174.GetCharArray9358_11931(), this._recoveredType21659174.GetNumber9359_11932(), this._recoveredType21659174.GetNumber9360_11933());
			if (text == null)
			{
				text = this._recoveredType21659174.ToString();
			}
		}
		else
		{
			text = this._recoveredType21659174.ToString();
		}
		this.Method11560();
		if (this.charArray3[this.number5] != ':')
		{
			throw 141.Method12886(this, "Invalid character after parsing property name. Expected ':' but got: {0}.".Method6825(CultureInfo.InvariantCulture, this.charArray3[this.number5]));
		}
		this.number5++;
		base.SetToken(216.PropertyName, text);
		this.charValue3 = c2;
		this.Method11550();
		return true;
	}

	// Token: 0x06000654 RID: 1620 RVA: 0x00015DB4 File Offset: 0x00013FB4
	private bool Method11554(char 1)
	{
		return char.IsLetterOrDigit(1) || 1 == '_' || 1 == '$';
	}

	// Token: 0x06000655 RID: 1621 RVA: 0x00015DCC File Offset: 0x00013FCC
	private void Method11555()
	{
		int num = this.number5;
		for (;;)
		{
			char c = this.charArray3[this.number5];
			if (c == '\0')
			{
				if (this.number4 != this.number5)
				{
					break;
				}
				if (this.Method11519(true) == 0)
				{
					goto Block_3;
				}
			}
			else if (this.Method11556(c, num))
			{
				return;
			}
		}
		this._recoveredType21659174 = new 743(this.charArray3, num, this.number5 - num);
		return;
		Block_3:
		throw 141.Method12886(this, "Unexpected end while parsing unquoted property name.");
	}

	// Token: 0x06000656 RID: 1622 RVA: 0x00015E3C File Offset: 0x0001403C
	private bool Method11556(char 1, int 2)
	{
		if (this.Method11554(1))
		{
			this.number5++;
			return false;
		}
		if (char.IsWhiteSpace(1) || 1 == ':')
		{
			this._recoveredType21659174 = new 743(this.charArray3, 2, this.number5 - 2);
			return true;
		}
		throw 141.Method12886(this, "Invalid JavaScript property identifier character: {0}.".Method6825(CultureInfo.InvariantCulture, 1));
	}

	// Token: 0x06000657 RID: 1623 RVA: 0x00015EA8 File Offset: 0x000140A8
	private bool Method11557()
	{
		char c;
		for (;;)
		{
			c = this.charArray3[this.number5];
			if (c <= 'N')
			{
				if (c <= ' ')
				{
					if (c != '\0')
					{
						switch (c)
						{
						case '\t':
							break;
						case '\n':
							this.Method11558();
							continue;
						case '\v':
						case '\f':
							goto IL_276;
						case '\r':
							this.Method11559(false);
							continue;
						default:
							if (c != ' ')
							{
								goto IL_276;
							}
							break;
						}
						this.number5++;
						continue;
					}
					if (this.number4 != this.number5)
					{
						this.number5++;
						continue;
					}
					if (this.Method11519(false) == 0)
					{
						break;
					}
					continue;
				}
				else if (c <= '/')
				{
					if (c == '"')
					{
						goto IL_116;
					}
					switch (c)
					{
					case '\'':
						goto IL_116;
					case ')':
						goto IL_234;
					case ',':
						goto IL_22A;
					case '-':
						goto IL_1A3;
					case '/':
						goto IL_1D3;
					}
				}
				else
				{
					if (c == 'I')
					{
						goto IL_199;
					}
					if (c == 'N')
					{
						goto IL_18F;
					}
				}
			}
			else if (c <= 'f')
			{
				if (c == '[')
				{
					goto IL_1FB;
				}
				if (c == ']')
				{
					goto IL_212;
				}
				if (c == 'f')
				{
					goto IL_128;
				}
			}
			else if (c <= 't')
			{
				if (c == 'n')
				{
					goto IL_130;
				}
				if (c == 't')
				{
					goto IL_120;
				}
			}
			else
			{
				if (c == 'u')
				{
					goto IL_1DC;
				}
				if (c == '{')
				{
					goto IL_1E4;
				}
			}
			IL_276:
			if (!char.IsWhiteSpace(c))
			{
				goto IL_291;
			}
			this.number5++;
		}
		return false;
		IL_116:
		this.Method11515(c, (815)0);
		return true;
		IL_120:
		this.Method11572();
		return true;
		IL_128:
		this.Method11575();
		return true;
		IL_130:
		if (this.Method11522(1, true))
		{
			char c2 = this.charArray3[this.number5 + 1];
			if (c2 != 'e')
			{
				if (c2 != 'u')
				{
					throw this.Method11531(this.charArray3[this.number5]);
				}
				this.Method11573();
			}
			else
			{
				this.Method11561();
			}
			return true;
		}
		this.number5++;
		throw base.Method2828();
		IL_18F:
		this.Method11580((815)0);
		return true;
		IL_199:
		this.Method11578((815)0);
		return true;
		IL_1A3:
		if (this.Method11522(1, true) && this.charArray3[this.number5 + 1] == 'I')
		{
			this.Method11576((815)0);
		}
		else
		{
			this.Method11562((815)0);
		}
		return true;
		IL_1D3:
		this.Method11566(true);
		return true;
		IL_1DC:
		this.Method11574();
		return true;
		IL_1E4:
		this.number5++;
		base.SetToken(216.StartObject);
		return true;
		IL_1FB:
		this.number5++;
		base.SetToken(216.StartArray);
		return true;
		IL_212:
		this.number5++;
		base.SetToken(216.EndArray);
		return true;
		IL_22A:
		base.SetToken(216.Undefined);
		return true;
		IL_234:
		this.number5++;
		base.SetToken(216.EndConstructor);
		return true;
		IL_291:
		if (char.IsNumber(c) || c == '-' || c == '.')
		{
			this.Method11562((815)0);
			return true;
		}
		throw this.Method11531(c);
	}

	// Token: 0x06000658 RID: 1624 RVA: 0x00016168 File Offset: 0x00014368
	private void Method11558()
	{
		this.number5++;
		this.Method11514(this.number5);
	}

	// Token: 0x06000659 RID: 1625 RVA: 0x00016184 File Offset: 0x00014384
	private void Method11559(bool 1)
	{
		this.number5++;
		this.Method11513(this.Method11522(1, 1));
	}

	// Token: 0x0600065A RID: 1626 RVA: 0x000161A4 File Offset: 0x000143A4
	private void Method11560()
	{
		for (;;)
		{
			char c = this.charArray3[this.number5];
			if (c <= '\n')
			{
				if (c != '\0')
				{
					if (c != '\n')
					{
						goto IL_62;
					}
					this.Method11558();
					continue;
				}
				else
				{
					if (this.number4 != this.number5)
					{
						this.number5++;
						continue;
					}
					if (this.Method11519(false) == 0)
					{
						break;
					}
					continue;
				}
			}
			else
			{
				if (c == '\r')
				{
					this.Method11559(false);
					continue;
				}
				if (c != ' ')
				{
					goto IL_62;
				}
			}
			IL_6B:
			this.number5++;
			continue;
			IL_62:
			if (!char.IsWhiteSpace(c))
			{
				return;
			}
			goto IL_6B;
		}
	}

	// Token: 0x0600065B RID: 1627 RVA: 0x0001622C File Offset: 0x0001442C
	private void Method11561()
	{
		if (!this.Method11570("new"))
		{
			throw 141.Method12886(this, "Unexpected content while parsing JSON.");
		}
		this.Method11560();
		int num = this.number5;
		char c;
		for (;;)
		{
			c = this.charArray3[this.number5];
			if (c == '\0')
			{
				if (this.number4 != this.number5)
				{
					goto IL_51;
				}
				if (this.Method11519(true) == 0)
				{
					break;
				}
			}
			else
			{
				if (!char.IsLetterOrDigit(c))
				{
					goto IL_83;
				}
				this.number5++;
			}
		}
		throw 141.Method12886(this, "Unexpected end while parsing constructor.");
		IL_51:
		int num2 = this.number5;
		this.number5++;
		goto IL_F5;
		IL_83:
		if (c != '\n')
		{
			if (c == '\r')
			{
				num2 = this.number5;
				this.Method11559(true);
			}
			else if (char.IsWhiteSpace(c))
			{
				num2 = this.number5;
				this.number5++;
			}
			else
			{
				if (c != '(')
				{
					throw 141.Method12886(this, "Unexpected character while parsing constructor: {0}.".Method6825(CultureInfo.InvariantCulture, c));
				}
				num2 = this.number5;
			}
		}
		else
		{
			num2 = this.number5;
			this.Method11558();
		}
		IL_F5:
		this._recoveredType21659174 = new 743(this.charArray3, num, num2 - num);
		string <<EMPTY_NAME>> = this._recoveredType21659174.ToString();
		this.Method11560();
		if (this.charArray3[this.number5] != '(')
		{
			throw 141.Method12886(this, "Unexpected character while parsing constructor: {0}.".Method6825(CultureInfo.InvariantCulture, this.charArray3[this.number5]));
		}
		this.number5++;
		this.Method11550();
		base.SetToken(216.StartConstructor, <<EMPTY_NAME>>);
	}

	// Token: 0x0600065C RID: 1628 RVA: 0x000163BC File Offset: 0x000145BC
	private void Method11562(815 1)
	{
		this.Method11518();
		char 2 = this.charArray3[this.number5];
		int 3 = this.number5;
		this.Method11548();
		this.Method11563(1, 2, 3);
	}

	// Token: 0x0600065D RID: 1629 RVA: 0x000163F4 File Offset: 0x000145F4
	private void Method11563(815 1, char 2, int 3)
	{
		base.Method2834(true);
		this._recoveredType21659174 = new 743(this.charArray3, 3, this.number5 - 3);
		bool flag = char.IsDigit(2) && this._recoveredType21659174.GetNumber9360_11933() == 1;
		bool flag2 = 2 == '0' && this._recoveredType21659174.GetNumber9360_11933() > 1 && this._recoveredType21659174.GetCharArray9358_11931()[this._recoveredType21659174.GetNumber9359_11932() + 1] != '.' && this._recoveredType21659174.GetCharArray9358_11931()[this._recoveredType21659174.GetNumber9359_11932() + 1] != 'e' && this._recoveredType21659174.GetCharArray9358_11931()[this._recoveredType21659174.GetNumber9359_11932() + 1] != 'E';
		object 4;
		216 5;
		switch (1)
		{
		case (815)0:
		case (815)2:
		{
			if (flag)
			{
				4 = 420.Method3206((long)((ulong)2 - 48UL));
				5 = 216.Integer;
				goto IL_618;
			}
			if (flag2)
			{
				string text = this._recoveredType21659174.ToString();
				try
				{
					4 = 420.Method3206(text.StartsWith("0x", StringComparison.OrdinalIgnoreCase) ? Convert.ToInt64(text, 16) : Convert.ToInt64(text, 8));
				}
				catch (Exception 6)
				{
					throw this.Method11564("Input string '{0}' is not a valid number.".Method6825(CultureInfo.InvariantCulture, text), 6);
				}
				5 = 216.Integer;
				goto IL_618;
			}
			long 8;
			514 7 = 358.Method1506(this._recoveredType21659174.GetCharArray9358_11931(), this._recoveredType21659174.GetNumber9359_11932(), this._recoveredType21659174.GetNumber9360_11933(), out 8);
			if (7 == (514)1)
			{
				4 = 420.Method3206(8);
				5 = 216.Integer;
				goto IL_618;
			}
			if (7 != (514)2)
			{
				if (this.floatParseHandling2 == (94)1)
				{
					decimal 9;
					if (358.Method1507(this._recoveredType21659174.GetCharArray9358_11931(), this._recoveredType21659174.GetNumber9359_11932(), this._recoveredType21659174.GetNumber9360_11933(), out 9) != (514)1)
					{
						throw this.Method11564("Input string '{0}' is not a valid decimal.".Method6825(CultureInfo.InvariantCulture, this._recoveredType21659174.ToString()), null);
					}
					4 = 420.Method3206(9);
				}
				else
				{
					double 10;
					if (!double.TryParse(this._recoveredType21659174.ToString(), NumberStyles.Float, CultureInfo.InvariantCulture, out 10))
					{
						throw this.Method11564("Input string '{0}' is not a valid number.".Method6825(CultureInfo.InvariantCulture, this._recoveredType21659174.ToString()), null);
					}
					4 = 420.Method3206(10);
				}
				5 = 216.Float;
				goto IL_618;
			}
			string text2 = this._recoveredType21659174.ToString();
			if (text2.Length > 380)
			{
				throw this.Method11564("JSON integer {0} is too large to parse.".Method6825(CultureInfo.InvariantCulture, this._recoveredType21659174.ToString()), null);
			}
			4 = 167.Method11565(text2, CultureInfo.InvariantCulture);
			5 = 216.Integer;
			goto IL_618;
		}
		case (815)1:
			if (flag)
			{
				4 = 420.Method3206((int)(2 - '0'));
			}
			else
			{
				if (flag2)
				{
					string text3 = this._recoveredType21659174.ToString();
					try
					{
						4 = 420.Method3206(text3.StartsWith("0x", StringComparison.OrdinalIgnoreCase) ? Convert.ToInt32(text3, 16) : Convert.ToInt32(text3, 8));
						goto IL_278;
					}
					catch (Exception 11)
					{
						throw this.Method11564("Input string '{0}' is not a valid integer.".Method6825(CultureInfo.InvariantCulture, text3), 11);
					}
				}
				int 12;
				514 7 = 358.Method1505(this._recoveredType21659174.GetCharArray9358_11931(), this._recoveredType21659174.GetNumber9359_11932(), this._recoveredType21659174.GetNumber9360_11933(), out 12);
				if (7 != (514)1)
				{
					if (7 == (514)2)
					{
						throw this.Method11564("JSON integer {0} is too large or small for an Int32.".Method6825(CultureInfo.InvariantCulture, this._recoveredType21659174.ToString()), null);
					}
					throw this.Method11564("Input string '{0}' is not a valid integer.".Method6825(CultureInfo.InvariantCulture, this._recoveredType21659174.ToString()), null);
				}
				else
				{
					4 = 420.Method3206(12);
				}
			}
			IL_278:
			5 = 216.Integer;
			goto IL_618;
		case (815)4:
		{
			string text4 = this._recoveredType21659174.ToString();
			if (flag2)
			{
				try
				{
					if (text4.StartsWith("0x", StringComparison.OrdinalIgnoreCase))
					{
						Convert.ToInt64(text4, 16);
					}
					else
					{
						Convert.ToInt64(text4, 8);
					}
					goto IL_170;
				}
				catch (Exception 13)
				{
					throw this.Method11564("Input string '{0}' is not a valid number.".Method6825(CultureInfo.InvariantCulture, text4), 13);
				}
			}
			double num;
			if (!double.TryParse(text4, NumberStyles.Float, CultureInfo.InvariantCulture, out num))
			{
				throw this.Method11564("Input string '{0}' is not a valid number.".Method6825(CultureInfo.InvariantCulture, this._recoveredType21659174.ToString()), null);
			}
			IL_170:
			5 = 216.String;
			4 = text4;
			goto IL_618;
		}
		case (815)5:
			if (flag)
			{
				4 = 420.Method3206(2 - 48m);
			}
			else
			{
				if (flag2)
				{
					string text5 = this._recoveredType21659174.ToString();
					try
					{
						4 = 420.Method3206(Convert.ToDecimal(text5.StartsWith("0x", StringComparison.OrdinalIgnoreCase) ? Convert.ToInt64(text5, 16) : Convert.ToInt64(text5, 8)));
						goto IL_35B;
					}
					catch (Exception 14)
					{
						throw this.Method11564("Input string '{0}' is not a valid decimal.".Method6825(CultureInfo.InvariantCulture, text5), 14);
					}
				}
				decimal 15;
				if (358.Method1507(this._recoveredType21659174.GetCharArray9358_11931(), this._recoveredType21659174.GetNumber9359_11932(), this._recoveredType21659174.GetNumber9360_11933(), out 15) != (514)1)
				{
					throw this.Method11564("Input string '{0}' is not a valid decimal.".Method6825(CultureInfo.InvariantCulture, this._recoveredType21659174.ToString()), null);
				}
				4 = 420.Method3206(15);
			}
			IL_35B:
			5 = 216.Float;
			goto IL_618;
		case (815)8:
			if (flag)
			{
				4 = 420.Method3206((double)2 - 48.0);
			}
			else
			{
				if (flag2)
				{
					string text6 = this._recoveredType21659174.ToString();
					try
					{
						4 = 420.Method3206(Convert.ToDouble(text6.StartsWith("0x", StringComparison.OrdinalIgnoreCase) ? Convert.ToInt64(text6, 16) : Convert.ToInt64(text6, 8)));
						goto IL_431;
					}
					catch (Exception 16)
					{
						throw this.Method11564("Input string '{0}' is not a valid double.".Method6825(CultureInfo.InvariantCulture, text6), 16);
					}
				}
				double 17;
				if (!double.TryParse(this._recoveredType21659174.ToString(), NumberStyles.Float, CultureInfo.InvariantCulture, out 17))
				{
					throw this.Method11564("Input string '{0}' is not a valid double.".Method6825(CultureInfo.InvariantCulture, this._recoveredType21659174.ToString()), null);
				}
				4 = 420.Method3206(17);
			}
			IL_431:
			5 = 216.Float;
			goto IL_618;
		}
		throw 141.Method12886(this, "Cannot read number value as type.");
		IL_618:
		this.Method11550();
		base.SetToken(5, 4, false);
	}

	// Token: 0x0600065E RID: 1630 RVA: 0x00016A68 File Offset: 0x00014C68
	private 141 Method11564(string 1, [241(2)] Exception 2)
	{
		base.SetToken(216.Undefined, null, false);
		return 141.Method12886(this, 1, 2);
	}

	// Token: 0x0600065F RID: 1631 RVA: 0x00016A7C File Offset: 0x00014C7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object Method11565(string 1, CultureInfo 2)
	{
		return BigInteger.Parse(1, 2);
	}

	// Token: 0x06000660 RID: 1632 RVA: 0x00016A8C File Offset: 0x00014C8C
	private void Method11566(bool 1)
	{
		this.number5++;
		if (!this.Method11522(1, false))
		{
			throw 141.Method12886(this, "Unexpected end while parsing comment.");
		}
		bool flag;
		if (this.charArray3[this.number5] == '*')
		{
			flag = false;
		}
		else
		{
			if (this.charArray3[this.number5] != '/')
			{
				throw 141.Method12886(this, "Error parsing comment. Expected: *, got {0}.".Method6825(CultureInfo.InvariantCulture, this.charArray3[this.number5]));
			}
			flag = true;
		}
		this.number5++;
		int 2 = this.number5;
		for (;;)
		{
			char c = this.charArray3[this.number5];
			if (c <= '\n')
			{
				if (c != '\0')
				{
					if (c == '\n')
					{
						if (flag)
						{
							goto Block_16;
						}
						this.Method11558();
						continue;
					}
				}
				else
				{
					if (this.number4 != this.number5)
					{
						this.number5++;
						continue;
					}
					if (this.Method11519(true) == 0)
					{
						break;
					}
					continue;
				}
			}
			else if (c != '\r')
			{
				if (c == '*')
				{
					this.number5++;
					if (!flag && this.Method11522(0, true) && this.charArray3[this.number5] == '/')
					{
						goto Block_14;
					}
					continue;
				}
			}
			else
			{
				if (flag)
				{
					goto Block_15;
				}
				this.Method11559(true);
				continue;
			}
			this.number5++;
		}
		if (!flag)
		{
			throw 141.Method12886(this, "Unexpected end while parsing comment.");
		}
		this.Method11567(1, 2, this.number5);
		return;
		Block_14:
		this.Method11567(1, 2, this.number5 - 1);
		this.number5++;
		return;
		Block_15:
		this.Method11567(1, 2, this.number5);
		return;
		Block_16:
		this.Method11567(1, 2, this.number5);
	}

	// Token: 0x06000661 RID: 1633 RVA: 0x00016C3D File Offset: 0x00014E3D
	private void Method11567(bool 1, int 2, int 3)
	{
		if (1)
		{
			base.SetToken(216.Comment, new string(this.charArray3, 2, 3 - 2));
		}
	}

	// Token: 0x06000662 RID: 1634 RVA: 0x00016C58 File Offset: 0x00014E58
	private bool Method11568(string 1)
	{
		return this.Method11568(this.Method11522(1.Length - 1, true), 1);
	}

	// Token: 0x06000663 RID: 1635 RVA: 0x00016C70 File Offset: 0x00014E70
	private bool Method11568(bool 1, string 2)
	{
		if (!1)
		{
			this.number5 = this.number4;
			throw base.Method2828();
		}
		for (int i = 0; i < 2.Length; i++)
		{
			if (this.charArray3[this.number5 + i] != 2[i])
			{
				this.number5 += i;
				return false;
			}
		}
		this.number5 += 2.Length;
		return true;
	}

	// Token: 0x06000664 RID: 1636 RVA: 0x00016CE0 File Offset: 0x00014EE0
	private bool Method11570(string 1)
	{
		return this.Method11568(1) && (!this.Method11522(0, false) || this.Method11571(this.charArray3[this.number5]) || this.charArray3[this.number5] == '\0');
	}

	// Token: 0x06000665 RID: 1637 RVA: 0x00016D20 File Offset: 0x00014F20
	private bool Method11571(char 1)
	{
		if (1 <= ')')
		{
			switch (1)
			{
			case '\t':
			case '\n':
			case '\r':
				break;
			case '\v':
			case '\f':
				goto IL_8C;
			default:
				if (1 != ' ')
				{
					if (1 != ')')
					{
						goto IL_8C;
					}
					if (base.GetReaderState() == 139.140.Constructor || base.GetReaderState() == 139.140.ConstructorStart)
					{
						return true;
					}
					return false;
				}
				break;
			}
			return true;
		}
		if (1 <= '/')
		{
			if (1 != ',')
			{
				if (1 != '/')
				{
					goto IL_8C;
				}
				if (!this.Method11522(1, false))
				{
					return false;
				}
				char c = this.charArray3[this.number5 + 1];
				return c == '*' || c == '/';
			}
		}
		else if (1 != ']' && 1 != '}')
		{
			goto IL_8C;
		}
		return true;
		IL_8C:
		if (char.IsWhiteSpace(1))
		{
			return true;
		}
		return false;
	}

	// Token: 0x06000666 RID: 1638 RVA: 0x00016DC4 File Offset: 0x00014FC4
	private void Method11572()
	{
		if (this.Method11570(77.trueText))
		{
			base.SetToken(216.Boolean, 420.value);
			return;
		}
		throw 141.Method12886(this, "Error parsing boolean value.");
	}

	// Token: 0x06000667 RID: 1639 RVA: 0x00016DEC File Offset: 0x00014FEC
	private void Method11573()
	{
		if (this.Method11570(77.nullText))
		{
			base.SetToken(216.Null);
			return;
		}
		throw 141.Method12886(this, "Error parsing null value.");
	}

	// Token: 0x06000668 RID: 1640 RVA: 0x00016E0F File Offset: 0x0001500F
	private void Method11574()
	{
		if (this.Method11570(77.undefinedText))
		{
			base.SetToken(216.Undefined);
			return;
		}
		throw 141.Method12886(this, "Error parsing undefined value.");
	}

	// Token: 0x06000669 RID: 1641 RVA: 0x00016E32 File Offset: 0x00015032
	private void Method11575()
	{
		if (this.Method11570(77.falseText))
		{
			base.SetToken(216.Boolean, 420.value2);
			return;
		}
		throw 141.Method12886(this, "Error parsing boolean value.");
	}

	// Token: 0x0600066A RID: 1642 RVA: 0x00016E5A File Offset: 0x0001505A
	private object Method11576(815 1)
	{
		return this.Method11576(1, this.Method11570(77.negativeInfinityText));
	}

	// Token: 0x0600066B RID: 1643 RVA: 0x00016E70 File Offset: 0x00015070
	private object Method11576(815 1, bool 2)
	{
		if (2)
		{
			if (1 != (815)0)
			{
				if (1 == (815)4)
				{
					base.SetToken(216.String, 77.negativeInfinityText);
					return 77.negativeInfinityText;
				}
				if (1 != (815)8)
				{
					goto IL_44;
				}
			}
			if (this.floatParseHandling2 == (94)0)
			{
				base.SetToken(216.Float, 420.value25);
				return double.NegativeInfinity;
			}
			IL_44:
			throw 141.Method12886(this, "Cannot read -Infinity value.");
		}
		throw 141.Method12886(this, "Error parsing -Infinity value.");
	}

	// Token: 0x0600066C RID: 1644 RVA: 0x00016ED8 File Offset: 0x000150D8
	private object Method11578(815 1)
	{
		return this.Method11578(1, this.Method11570(77.positiveInfinityText));
	}

	// Token: 0x0600066D RID: 1645 RVA: 0x00016EEC File Offset: 0x000150EC
	private object Method11578(815 1, bool 2)
	{
		if (2)
		{
			if (1 != (815)0)
			{
				if (1 == (815)4)
				{
					base.SetToken(216.String, 77.positiveInfinityText);
					return 77.positiveInfinityText;
				}
				if (1 != (815)8)
				{
					goto IL_44;
				}
			}
			if (this.floatParseHandling2 == (94)0)
			{
				base.SetToken(216.Float, 420.value24);
				return double.PositiveInfinity;
			}
			IL_44:
			throw 141.Method12886(this, "Cannot read Infinity value.");
		}
		throw 141.Method12886(this, "Error parsing Infinity value.");
	}

	// Token: 0x0600066E RID: 1646 RVA: 0x00016F54 File Offset: 0x00015154
	private object Method11580(815 1)
	{
		return this.Method11580(1, this.Method11570(77.nanText));
	}

	// Token: 0x0600066F RID: 1647 RVA: 0x00016F68 File Offset: 0x00015168
	private object Method11580(815 1, bool 2)
	{
		if (2)
		{
			if (1 != (815)0)
			{
				if (1 == (815)4)
				{
					base.SetToken(216.String, 77.nanText);
					return 77.nanText;
				}
				if (1 != (815)8)
				{
					goto IL_44;
				}
			}
			if (this.floatParseHandling2 == (94)0)
			{
				base.SetToken(216.Float, 420.value23);
				return double.NaN;
			}
			IL_44:
			throw 141.Method12886(this, "Cannot read NaN value.");
		}
		throw 141.Method12886(this, "Error parsing NaN value.");
	}

	// Token: 0x06000670 RID: 1648 RVA: 0x00016FD0 File Offset: 0x000151D0
	public override void Close()
	{
		base.Close();
		if (this.charArray3 != null)
		{
			669.Method9988(this._recoveredType18549175, this.charArray3);
			this.charArray3 = null;
		}
		if (base.GetCloseInput())
		{
			TextReader textReader = this.textReader2;
			if (textReader != null)
			{
				textReader.Close();
			}
		}
		this._recoveredType07129173.Method4046(this._recoveredType18549175);
	}

	// Token: 0x06000671 RID: 1649 RVA: 0x0001702D File Offset: 0x0001522D
	public bool HasLineInfo()
	{
		return true;
	}

	// Token: 0x06000672 RID: 1650 RVA: 0x00017030 File Offset: 0x00015230
	public int GetLineNumber()
	{
		if (base.GetReaderState() == 139.140.Start && this.GetLinePosition() == 0 && this.GetTokenType() != 216.Comment)
		{
			return 0;
		}
		return this.number7;
	}

	// Token: 0x06000673 RID: 1651 RVA: 0x00017053 File Offset: 0x00015253
	public int GetLinePosition()
	{
		return this.number5 - this.number6;
	}

	// Token: 0x0400046B RID: 1131
	private readonly TextReader textReader2;

	// Token: 0x0400046C RID: 1132
	[241(2)]
	private char[] charArray3;

	// Token: 0x0400046D RID: 1133
	private int number4;

	// Token: 0x0400046E RID: 1134
	private int number5;

	// Token: 0x0400046F RID: 1135
	private int number6;

	// Token: 0x04000470 RID: 1136
	private int number7;

	// Token: 0x04000471 RID: 1137
	private bool flag3;

	// Token: 0x04000472 RID: 1138
	private 453 _recoveredType07129173;

	// Token: 0x04000473 RID: 1139
	private 743 _recoveredType21659174;

	// Token: 0x04000474 RID: 1140
	[241(2)]
	private 690<char> _recoveredType18549175;

	// Token: 0x04000475 RID: 1141
	[241(2)]
	private 406 _recoveredType04919176;
}
