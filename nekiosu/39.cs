using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

// Token: 0x020000BD RID: 189
[ComVisible(false)]
public sealed class 39 : 139
{
	// Token: 0x060004C2 RID: 1218 RVA: 0x0000E26C File Offset: 0x0000C46C
	public 39(Stream 1) : this(1, false, DateTimeKind.Local)
	{
	}

	// Token: 0x060004C3 RID: 1219 RVA: 0x0000E277 File Offset: 0x0000C477
	public 39(BinaryReader 1) : this(1, false, DateTimeKind.Local)
	{
	}

	// Token: 0x060004C4 RID: 1220 RVA: 0x0000E282 File Offset: 0x0000C482
	public 39(Stream 1, bool 2, DateTimeKind 3)
	{
		756.Method12216(1, "stream");
		this.binaryReader2 = new BinaryReader(1);
		this.list = new List<39.41>();
		this.flag2 = 2;
		this.dateTimeKind2 = 3;
	}

	// Token: 0x060004C5 RID: 1221 RVA: 0x0000E2BA File Offset: 0x0000C4BA
	public 39(BinaryReader 1, bool 2, DateTimeKind 3)
	{
		756.Method12216(1, "reader");
		this.binaryReader2 = 1;
		this.list = new List<39.41>();
		this.flag2 = 2;
		this.dateTimeKind2 = 3;
	}

	// Token: 0x060004C6 RID: 1222 RVA: 0x0000E2ED File Offset: 0x0000C4ED
	public bool GetFlag1168_1690()
	{
		return this.flag3;
	}

	// Token: 0x060004C7 RID: 1223 RVA: 0x0000E2F5 File Offset: 0x0000C4F5
	public void SetFlag1168_1691(bool 1)
	{
		this.flag3 = 1;
	}

	// Token: 0x060004C8 RID: 1224 RVA: 0x0000E2FE File Offset: 0x0000C4FE
	public bool GetFlag1167_1692()
	{
		return this.flag2;
	}

	// Token: 0x060004C9 RID: 1225 RVA: 0x0000E306 File Offset: 0x0000C506
	public void SetFlag1167_1693(bool 1)
	{
		this.flag2 = 1;
	}

	// Token: 0x060004CA RID: 1226 RVA: 0x0000E30F File Offset: 0x0000C50F
	public DateTimeKind GetDateTimeKind1169_1694()
	{
		return this.dateTimeKind2;
	}

	// Token: 0x060004CB RID: 1227 RVA: 0x0000E317 File Offset: 0x0000C517
	public void SetDateTimeKind1169_1695(DateTimeKind 1)
	{
		this.dateTimeKind2 = 1;
	}

	// Token: 0x060004CC RID: 1228 RVA: 0x0000E320 File Offset: 0x0000C520
	private string Method1696()
	{
		this._recoveredType12351164 = this.Method1705();
		return this.Method1707();
	}

	// Token: 0x060004CD RID: 1229 RVA: 0x0000E334 File Offset: 0x0000C534
	public override bool Read()
	{
		bool result;
		try
		{
			bool flag;
			switch (this._recoveredType03101165)
			{
			case 39.40.Normal:
				flag = this.Method1701();
				break;
			case 39.40.ReferenceStart:
			case 39.40.ReferenceRef:
			case 39.40.ReferenceId:
				flag = this.Method1700();
				break;
			case 39.40.CodeWScopeStart:
			case 39.40.CodeWScopeCode:
			case 39.40.CodeWScopeScope:
			case 39.40.CodeWScopeScopeObject:
			case 39.40.CodeWScopeScopeEnd:
				flag = this.Method1699();
				break;
			default:
				throw 141.Method12886(this, "Unexpected state: {0}".Method6825(CultureInfo.InvariantCulture, this._recoveredType03101165));
			}
			if (!flag)
			{
				base.SetToken(216.None);
				result = false;
			}
			else
			{
				result = true;
			}
		}
		catch (EndOfStreamException)
		{
			base.SetToken(216.None);
			result = false;
		}
		return result;
	}

	// Token: 0x060004CE RID: 1230 RVA: 0x0000E3E0 File Offset: 0x0000C5E0
	public override void Close()
	{
		base.Close();
		if (base.GetCloseInput())
		{
			BinaryReader binaryReader = this.binaryReader2;
			if (binaryReader == null)
			{
				return;
			}
			binaryReader.Close();
		}
	}

	// Token: 0x060004CF RID: 1231 RVA: 0x0000E400 File Offset: 0x0000C600
	private bool Method1699()
	{
		switch (this._recoveredType03101165)
		{
		case 39.40.CodeWScopeStart:
			base.SetToken(216.PropertyName, "$code");
			this._recoveredType03101165 = 39.40.CodeWScopeCode;
			return true;
		case 39.40.CodeWScopeCode:
			this.Method1714();
			base.SetToken(216.String, this.Method1708());
			this._recoveredType03101165 = 39.40.CodeWScopeScope;
			return true;
		case 39.40.CodeWScopeScope:
		{
			if (base.GetReaderState() == 139.140.PostValue)
			{
				base.SetToken(216.PropertyName, "$scope");
				return true;
			}
			base.SetToken(216.StartObject);
			this._recoveredType03101165 = 39.40.CodeWScopeScopeObject;
			39.41 <<EMPTY_NAME>> = new 39.41(550.Object);
			this.Method1703(<<EMPTY_NAME>>);
			<<EMPTY_NAME>>.number = this.Method1714();
			return true;
		}
		case 39.40.CodeWScopeScopeObject:
		{
			bool flag = this.Method1701();
			if (flag && this.GetTokenType() == 216.EndObject)
			{
				this._recoveredType03101165 = 39.40.CodeWScopeScopeEnd;
			}
			return flag;
		}
		case 39.40.CodeWScopeScopeEnd:
			base.SetToken(216.EndObject);
			this._recoveredType03101165 = 39.40.Normal;
			return true;
		default:
			throw new ArgumentOutOfRangeException();
		}
	}

	// Token: 0x060004D0 RID: 1232 RVA: 0x0000E4DC File Offset: 0x0000C6DC
	private bool Method1700()
	{
		139.140 readerState = base.GetReaderState();
		if (readerState != 139.140.Property)
		{
			if (readerState == 139.140.ObjectStart)
			{
				base.SetToken(216.PropertyName, "$ref");
				this._recoveredType03101165 = 39.40.ReferenceRef;
				return true;
			}
			if (readerState != 139.140.PostValue)
			{
				throw 141.Method12886(this, "Unexpected state when reading BSON reference: " + base.GetReaderState().ToString());
			}
			if (this._recoveredType03101165 == 39.40.ReferenceRef)
			{
				base.SetToken(216.PropertyName, "$id");
				this._recoveredType03101165 = 39.40.ReferenceId;
				return true;
			}
			if (this._recoveredType03101165 == 39.40.ReferenceId)
			{
				base.SetToken(216.EndObject);
				this._recoveredType03101165 = 39.40.Normal;
				return true;
			}
			throw 141.Method12886(this, "Unexpected state when reading BSON reference: " + this._recoveredType03101165.ToString());
		}
		else
		{
			if (this._recoveredType03101165 == 39.40.ReferenceRef)
			{
				base.SetToken(216.String, this.Method1708());
				return true;
			}
			if (this._recoveredType03101165 == 39.40.ReferenceId)
			{
				base.SetToken(216.Bytes, this.Method1718(12));
				return true;
			}
			throw 141.Method12886(this, "Unexpected state when reading BSON reference: " + this._recoveredType03101165.ToString());
		}
	}

	// Token: 0x060004D1 RID: 1233 RVA: 0x0000E5EC File Offset: 0x0000C7EC
	private bool Method1701()
	{
		switch (base.GetReaderState())
		{
		case 139.140.Start:
			break;
		case 139.140.Complete:
		case 139.140.Closed:
			return false;
		case 139.140.Property:
			this.Method1705(this._recoveredType12351164);
			return true;
		case 139.140.ObjectStart:
		case 139.140.ArrayStart:
		case 139.140.PostValue:
		{
			39.41 recoveredType = this._recoveredType03111166;
			if (recoveredType == null)
			{
				if (!base.GetSupportMultipleContent())
				{
					return false;
				}
			}
			else
			{
				int num = recoveredType.number - 1;
				if (recoveredType.number2 < num)
				{
					if (recoveredType._recoveredType12351153 == 550.Array)
					{
						this.Method1696();
						this.Method1705(this._recoveredType12351164);
						return true;
					}
					base.SetToken(216.PropertyName, this.Method1696());
					return true;
				}
				else
				{
					if (recoveredType.number2 != num)
					{
						throw 141.Method12886(this, "Read past end of current container context.");
					}
					if (this.Method1704() != 0)
					{
						throw 141.Method12886(this, "Unexpected end of object byte value.");
					}
					this.Method1702();
					if (this._recoveredType03111166 != null)
					{
						this.SetNumber1155_1717(recoveredType.number);
					}
					216 token = (recoveredType._recoveredType12351153 == 550.Object) ? 216.EndObject : 216.EndArray;
					base.SetToken(token);
					return true;
				}
			}
			break;
		}
		case 139.140.Object:
		case 139.140.Array:
			goto IL_146;
		case 139.140.ConstructorStart:
		case 139.140.Constructor:
		case 139.140.Error:
		case 139.140.Finished:
			return false;
		default:
			goto IL_146;
		}
		216 token2 = (!this.flag2) ? 216.StartObject : 216.StartArray;
		550 <<EMPTY_NAME>> = (!this.flag2) ? 550.Object : 550.Array;
		base.SetToken(token2);
		39.41 2 = new 39.41(<<EMPTY_NAME>>);
		this.Method1703(2);
		2.number = this.Method1714();
		return true;
		IL_146:
		throw new ArgumentOutOfRangeException();
	}

	// Token: 0x060004D2 RID: 1234 RVA: 0x0000E748 File Offset: 0x0000C948
	private void Method1702()
	{
		this.list.RemoveAt(this.list.Count - 1);
		if (this.list.Count == 0)
		{
			this._recoveredType03111166 = null;
			return;
		}
		this._recoveredType03111166 = this.list[this.list.Count - 1];
	}

	// Token: 0x060004D3 RID: 1235 RVA: 0x0000E7A0 File Offset: 0x0000C9A0
	private void Method1703(39.41 1)
	{
		this.list.Add(1);
		this._recoveredType03111166 = 1;
	}

	// Token: 0x060004D4 RID: 1236 RVA: 0x0000E7B5 File Offset: 0x0000C9B5
	private byte Method1704()
	{
		this.SetNumber1155_1717(1);
		return this.binaryReader2.ReadByte();
	}

	// Token: 0x060004D5 RID: 1237 RVA: 0x0000E7CC File Offset: 0x0000C9CC
	private void Method1705(550 1)
	{
		switch (1)
		{
		case 550.Number:
		{
			double num = this.Method1713();
			if (this.floatParseHandling2 == (94)1)
			{
				base.SetToken(216.Float, Convert.ToDecimal(num, CultureInfo.InvariantCulture));
				return;
			}
			base.SetToken(216.Float, num);
			return;
		}
		case 550.String:
		case 550.Symbol:
			base.SetToken(216.String, this.Method1708());
			return;
		case 550.Object:
		{
			base.SetToken(216.StartObject);
			39.41 2 = new 39.41(550.Object);
			this.Method1703(2);
			2.number = this.Method1714();
			return;
		}
		case 550.Array:
		{
			base.SetToken(216.StartArray);
			39.41 3 = new 39.41(550.Array);
			this.Method1703(3);
			3.number = this.Method1714();
			return;
		}
		case 550.Binary:
		{
			440 4;
			byte[] array = this.Method1706(out 4);
			object 5 = (4 != (440)4) ? array : new Guid(array);
			base.SetToken(216.Bytes, 5);
			return;
		}
		case 550.Undefined:
			base.SetToken(216.Undefined);
			return;
		case 550.Oid:
		{
			byte[] 6 = this.Method1718(12);
			base.SetToken(216.Bytes, 6);
			return;
		}
		case 550.Boolean:
		{
			bool flag = Convert.ToBoolean(this.Method1704());
			base.SetToken(216.Boolean, flag);
			return;
		}
		case 550.Date:
		{
			DateTime dateTime = 382.Method2117(this.Method1715());
			DateTimeKind dateTimeKind1169_ = this.GetDateTimeKind1169_1694();
			DateTime dateTime2;
			if (dateTimeKind1169_ != DateTimeKind.Unspecified)
			{
				if (dateTimeKind1169_ != DateTimeKind.Local)
				{
					dateTime2 = dateTime;
				}
				else
				{
					dateTime2 = dateTime.ToLocalTime();
				}
			}
			else
			{
				dateTime2 = DateTime.SpecifyKind(dateTime, DateTimeKind.Unspecified);
			}
			base.SetToken(216.Date, dateTime2);
			return;
		}
		case 550.Null:
			base.SetToken(216.Null);
			return;
		case 550.Regex:
		{
			string str = this.Method1707();
			string str2 = this.Method1707();
			string 7 = "/" + str + "/" + str2;
			base.SetToken(216.String, 7);
			return;
		}
		case 550.Reference:
			base.SetToken(216.StartObject);
			this._recoveredType03101165 = 39.40.ReferenceStart;
			return;
		case 550.Code:
			base.SetToken(216.String, this.Method1708());
			return;
		case 550.CodeWScope:
			base.SetToken(216.StartObject);
			this._recoveredType03101165 = 39.40.CodeWScopeStart;
			return;
		case 550.Integer:
			base.SetToken(216.Integer, (long)this.Method1714());
			return;
		case 550.TimeStamp:
		case 550.Long:
			base.SetToken(216.Integer, this.Method1715());
			return;
		default:
			throw new ArgumentOutOfRangeException("type", "Unexpected BsonType value: " + 1.ToString());
		}
	}

	// Token: 0x060004D6 RID: 1238 RVA: 0x0000EA1C File Offset: 0x0000CC1C
	private byte[] Method1706(out 440 1)
	{
		int 2 = this.Method1714();
		1 = (440)this.Method1704();
		if (1 == (440)2 && !this.flag3)
		{
			2 = this.Method1714();
		}
		return this.Method1718(2);
	}

	// Token: 0x060004D7 RID: 1239 RVA: 0x0000EA54 File Offset: 0x0000CC54
	private string Method1707()
	{
		this.Method1712();
		StringBuilder stringBuilder = null;
		int num = 0;
		int num2 = 0;
		int num4;
		for (;;)
		{
			int num3 = num2;
			byte b;
			while (num3 < 128 && (b = this.binaryReader2.ReadByte()) > 0)
			{
				this.byteArray6[num3++] = b;
			}
			num4 = num3 - num2;
			num += num4;
			if (num3 < 128 && stringBuilder == null)
			{
				break;
			}
			int num5 = this.Method1710(num3 - 1);
			int chars = Encoding.UTF8.GetChars(this.byteArray6, 0, num5 + 1, this.charArray, 0);
			if (stringBuilder == null)
			{
				stringBuilder = new StringBuilder(256);
			}
			stringBuilder.Append(this.charArray, 0, chars);
			if (num5 < num4 - 1)
			{
				num2 = num4 - num5 - 1;
				Array.Copy(this.byteArray6, num5 + 1, this.byteArray6, 0, num2);
			}
			else
			{
				if (num3 < 128)
				{
					goto IL_102;
				}
				num2 = 0;
			}
		}
		int chars2 = Encoding.UTF8.GetChars(this.byteArray6, 0, num4, this.charArray, 0);
		this.SetNumber1155_1717(num + 1);
		return new string(this.charArray, 0, chars2);
		IL_102:
		this.SetNumber1155_1717(num + 1);
		return stringBuilder.ToString();
	}

	// Token: 0x060004D8 RID: 1240 RVA: 0x0000EB74 File Offset: 0x0000CD74
	private string Method1708()
	{
		int num = this.Method1714();
		this.SetNumber1155_1717(num);
		string result = this.Method1709(num - 1);
		this.binaryReader2.ReadByte();
		return result;
	}

	// Token: 0x060004D9 RID: 1241 RVA: 0x0000EBA4 File Offset: 0x0000CDA4
	private string Method1709(int 1)
	{
		if (1 == 0)
		{
			return string.Empty;
		}
		this.Method1712();
		StringBuilder stringBuilder = null;
		int num = 0;
		int num2 = 0;
		int num3;
		for (;;)
		{
			int count = (1 - num > 128 - num2) ? (128 - num2) : (1 - num);
			num3 = this.binaryReader2.Read(this.byteArray6, num2, count);
			if (num3 == 0)
			{
				break;
			}
			num += num3;
			num3 += num2;
			if (num3 == 1)
			{
				goto Block_4;
			}
			int num4 = this.Method1710(num3 - 1);
			if (stringBuilder == null)
			{
				stringBuilder = new StringBuilder(1);
			}
			int chars = Encoding.UTF8.GetChars(this.byteArray6, 0, num4 + 1, this.charArray, 0);
			stringBuilder.Append(this.charArray, 0, chars);
			if (num4 < num3 - 1)
			{
				num2 = num3 - num4 - 1;
				Array.Copy(this.byteArray6, num4 + 1, this.byteArray6, 0, num2);
			}
			else
			{
				num2 = 0;
			}
			if (num >= 1)
			{
				goto Block_7;
			}
		}
		throw new EndOfStreamException("Unable to read beyond the end of the stream.");
		Block_4:
		int chars2 = Encoding.UTF8.GetChars(this.byteArray6, 0, num3, this.charArray, 0);
		return new string(this.charArray, 0, chars2);
		Block_7:
		return stringBuilder.ToString();
	}

	// Token: 0x060004DA RID: 1242 RVA: 0x0000ECBC File Offset: 0x0000CEBC
	private int Method1710(int 1)
	{
		int i = 1;
		int num = 0;
		while (i >= 0)
		{
			num = this.Method1711(this.byteArray6[i]);
			if (num != 0)
			{
				if (num != 1)
				{
					i--;
					break;
				}
				break;
			}
			else
			{
				i--;
			}
		}
		if (num == 1 - i)
		{
			return 1;
		}
		return i;
	}

	// Token: 0x060004DB RID: 1243 RVA: 0x0000ECFC File Offset: 0x0000CEFC
	private int Method1711(byte 1)
	{
		if (1 <= 39.byteArray2[1])
		{
			return 1;
		}
		if (1 >= 39.byteArray3[0] && 1 <= 39.byteArray3[1])
		{
			return 2;
		}
		if (1 >= 39.byteArray4[0] && 1 <= 39.byteArray4[1])
		{
			return 3;
		}
		if (1 >= 39.byteArray5[0] && 1 <= 39.byteArray5[1])
		{
			return 4;
		}
		return 0;
	}

	// Token: 0x060004DC RID: 1244 RVA: 0x0000ED58 File Offset: 0x0000CF58
	private void Method1712()
	{
		if (this.byteArray6 == null)
		{
			this.byteArray6 = new byte[128];
		}
		if (this.charArray == null)
		{
			int maxCharCount = Encoding.UTF8.GetMaxCharCount(128);
			this.charArray = new char[maxCharCount];
		}
	}

	// Token: 0x060004DD RID: 1245 RVA: 0x0000EDA1 File Offset: 0x0000CFA1
	private double Method1713()
	{
		this.SetNumber1155_1717(8);
		return this.binaryReader2.ReadDouble();
	}

	// Token: 0x060004DE RID: 1246 RVA: 0x0000EDB5 File Offset: 0x0000CFB5
	private int Method1714()
	{
		this.SetNumber1155_1717(4);
		return this.binaryReader2.ReadInt32();
	}

	// Token: 0x060004DF RID: 1247 RVA: 0x0000EDC9 File Offset: 0x0000CFC9
	private long Method1715()
	{
		this.SetNumber1155_1717(8);
		return this.binaryReader2.ReadInt64();
	}

	// Token: 0x060004E0 RID: 1248 RVA: 0x0000EDDD File Offset: 0x0000CFDD
	private 550 Method1705()
	{
		this.SetNumber1155_1717(1);
		return (550)this.binaryReader2.ReadSByte();
	}

	// Token: 0x060004E1 RID: 1249 RVA: 0x0000EDF1 File Offset: 0x0000CFF1
	private void SetNumber1155_1717(int 1)
	{
		this._recoveredType03111166.number2 += 1;
	}

	// Token: 0x060004E2 RID: 1250 RVA: 0x0000EE06 File Offset: 0x0000D006
	private byte[] Method1718(int 1)
	{
		this.SetNumber1155_1717(1);
		return this.binaryReader2.ReadBytes(1);
	}

	// Token: 0x040003E3 RID: 995
	private static readonly byte[] byteArray2 = new byte[]
	{
		0,
		127
	};

	// Token: 0x040003E4 RID: 996
	private static readonly byte[] byteArray3 = new byte[]
	{
		194,
		223
	};

	// Token: 0x040003E5 RID: 997
	private static readonly byte[] byteArray4 = new byte[]
	{
		224,
		239
	};

	// Token: 0x040003E6 RID: 998
	private static readonly byte[] byteArray5 = new byte[]
	{
		240,
		244
	};

	// Token: 0x040003E7 RID: 999
	private readonly BinaryReader binaryReader2;

	// Token: 0x040003E8 RID: 1000
	private readonly List<39.41> list;

	// Token: 0x040003E9 RID: 1001
	private byte[] byteArray6;

	// Token: 0x040003EA RID: 1002
	private char[] charArray;

	// Token: 0x040003EB RID: 1003
	private 550 _recoveredType12351164;

	// Token: 0x040003EC RID: 1004
	private 39.40 _recoveredType03101165;

	// Token: 0x040003ED RID: 1005
	private 39.41 _recoveredType03111166;

	// Token: 0x040003EE RID: 1006
	private bool flag2;

	// Token: 0x040003EF RID: 1007
	private bool flag3;

	// Token: 0x040003F0 RID: 1008
	private DateTimeKind dateTimeKind2;

	// Token: 0x020000BE RID: 190
	public enum 40
	{
		// Token: 0x040003F2 RID: 1010
		Normal,
		// Token: 0x040003F3 RID: 1011
		ReferenceStart,
		// Token: 0x040003F4 RID: 1012
		ReferenceRef,
		// Token: 0x040003F5 RID: 1013
		ReferenceId,
		// Token: 0x040003F6 RID: 1014
		CodeWScopeStart,
		// Token: 0x040003F7 RID: 1015
		CodeWScopeCode,
		// Token: 0x040003F8 RID: 1016
		CodeWScopeScope,
		// Token: 0x040003F9 RID: 1017
		CodeWScopeScopeObject,
		// Token: 0x040003FA RID: 1018
		CodeWScopeScopeEnd
	}

	// Token: 0x020000BF RID: 191
	public sealed class 41
	{
		// Token: 0x060004E4 RID: 1252 RVA: 0x0000EE8A File Offset: 0x0000D08A
		public 41(550 1)
		{
			this._recoveredType12351153 = 1;
		}

		// Token: 0x040003FB RID: 1019
		public readonly 550 _recoveredType12351153;

		// Token: 0x040003FC RID: 1020
		public int number;

		// Token: 0x040003FD RID: 1021
		public int number2;
	}
}
