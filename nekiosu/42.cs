using System;
using System.Globalization;
using System.IO;
using System.Numerics;
using System.Runtime.InteropServices;

// Token: 0x020000C0 RID: 192
[ComVisible(false)]
public sealed class 42 : 173
{
	// Token: 0x060004E5 RID: 1253 RVA: 0x0000EE99 File Offset: 0x0000D099
	public 42(Stream 1)
	{
		756.Method12216(1, "stream");
		this.jsonBsonBinaryWriter = new 127(new BinaryWriter(1));
	}

	// Token: 0x060004E6 RID: 1254 RVA: 0x0000EEBD File Offset: 0x0000D0BD
	public 42(BinaryWriter 1)
	{
		756.Method12216(1, "writer");
		this.jsonBsonBinaryWriter = new 127(1);
	}

	// Token: 0x060004E7 RID: 1255 RVA: 0x0000EEDC File Offset: 0x0000D0DC
	public DateTimeKind Method12952()
	{
		return this.jsonBsonBinaryWriter.GetDateTimeKind();
	}

	// Token: 0x060004E8 RID: 1256 RVA: 0x0000EEE9 File Offset: 0x0000D0E9
	public void Method12953(DateTimeKind 1)
	{
		this.jsonBsonBinaryWriter.SetDateTimeKind(1);
	}

	// Token: 0x060004E9 RID: 1257 RVA: 0x0000EEF7 File Offset: 0x0000D0F7
	public override void Flush()
	{
		this.jsonBsonBinaryWriter.Flush();
	}

	// Token: 0x060004EA RID: 1258 RVA: 0x0000EF04 File Offset: 0x0000D104
	protected override void WriteEnd(216 1)
	{
		base.WriteEnd(1);
		this.SetRecoveredType183110105_12965();
		if (base.GetTop() == 0)
		{
			this.jsonBsonBinaryWriter.WriteToken(this._recoveredType183110104);
		}
	}

	// Token: 0x060004EB RID: 1259 RVA: 0x0000EF2C File Offset: 0x0000D12C
	public override void WriteComment(string 1)
	{
		throw 763.Method12341(this, "Cannot write JSON comment as BSON.", null);
	}

	// Token: 0x060004EC RID: 1260 RVA: 0x0000EF3A File Offset: 0x0000D13A
	public override void WriteStartConstructor(string 1)
	{
		throw 763.Method12341(this, "Cannot write JSON constructor as BSON.", null);
	}

	// Token: 0x060004ED RID: 1261 RVA: 0x0000EF48 File Offset: 0x0000D148
	public override void WriteRaw(string 1)
	{
		throw 763.Method12341(this, "Cannot write raw JSON as BSON.", null);
	}

	// Token: 0x060004EE RID: 1262 RVA: 0x0000EF48 File Offset: 0x0000D148
	public override void WriteRawValue(string 1)
	{
		throw 763.Method12341(this, "Cannot write raw JSON as BSON.", null);
	}

	// Token: 0x060004EF RID: 1263 RVA: 0x0000EF56 File Offset: 0x0000D156
	public override void WriteStartArray()
	{
		base.WriteStartArray();
		this.Method12964(new 125());
	}

	// Token: 0x060004F0 RID: 1264 RVA: 0x0000EF69 File Offset: 0x0000D169
	public override void WriteStartObject()
	{
		base.WriteStartObject();
		this.Method12964(new 388());
	}

	// Token: 0x060004F1 RID: 1265 RVA: 0x0000EF7C File Offset: 0x0000D17C
	public override void WritePropertyName(string 1)
	{
		base.WritePropertyName(1);
		this.text4 = 1;
	}

	// Token: 0x060004F2 RID: 1266 RVA: 0x0000EF8C File Offset: 0x0000D18C
	public override void Close()
	{
		base.Close();
		if (base.GetCloseOutput())
		{
			127 <<EMPTY_NAME>> = this.jsonBsonBinaryWriter;
			if (<<EMPTY_NAME>> == null)
			{
				return;
			}
			<<EMPTY_NAME>>.Close();
		}
	}

	// Token: 0x060004F3 RID: 1267 RVA: 0x0000EFAC File Offset: 0x0000D1AC
	private void Method12964(679 1)
	{
		this.Method12967(1);
		this._recoveredType183110105 = 1;
	}

	// Token: 0x060004F4 RID: 1268 RVA: 0x0000EFBC File Offset: 0x0000D1BC
	private void SetRecoveredType183110105_12965()
	{
		this._recoveredType183110105 = this._recoveredType183110105.GetRecoveredType18318041_10255();
	}

	// Token: 0x060004F5 RID: 1269 RVA: 0x0000EFCF File Offset: 0x0000D1CF
	private void Method12966(object 1, 550 2)
	{
		this.Method12967(new 564(1, 2));
	}

	// Token: 0x060004F6 RID: 1270 RVA: 0x0000EFE0 File Offset: 0x0000D1E0
	internal void Method12967(679 1)
	{
		if (this._recoveredType183110105 != null)
		{
			388 2 = this._recoveredType183110105 as 388;
			if (2 != null)
			{
				2.Method2239(this.text4, 1);
				this.text4 = null;
				return;
			}
			((125)this._recoveredType183110105).AddToken(1);
			return;
		}
		else
		{
			if (1.GetRegex_12135() != 550.Object && 1.GetRegex_12135() != 550.Array)
			{
				throw 763.Method12341(this, "Error writing {0} value. BSON must start with an Object or Array.".Method6825(CultureInfo.InvariantCulture, 1.GetRegex_12135()), null);
			}
			this._recoveredType183110105 = 1;
			this._recoveredType183110104 = 1;
			return;
		}
	}

	// Token: 0x060004F7 RID: 1271 RVA: 0x0000F070 File Offset: 0x0000D270
	public override void WriteValue(object 1)
	{
		if (1 is BigInteger)
		{
			BigInteger bigInteger = (BigInteger)1;
			base.Method7420(216.Integer, null);
			this.Method12967(new 730(bigInteger.ToByteArray(), (440)0));
			return;
		}
		base.WriteValue(1);
	}

	// Token: 0x060004F8 RID: 1272 RVA: 0x0000F0AF File Offset: 0x0000D2AF
	public override void WriteNull()
	{
		base.WriteNull();
		this.Method12967(38.NullValue);
	}

	// Token: 0x060004F9 RID: 1273 RVA: 0x0000F0C2 File Offset: 0x0000D2C2
	public override void WriteUndefined()
	{
		base.WriteUndefined();
		this.Method12967(38.UndefinedValue);
	}

	// Token: 0x060004FA RID: 1274 RVA: 0x0000F0D5 File Offset: 0x0000D2D5
	public override void WriteValue(string 1)
	{
		base.WriteValue(1);
		this.Method12967((1 == null) ? 38.NullValue : new 741(1, true));
	}

	// Token: 0x060004FB RID: 1275 RVA: 0x0000F0F5 File Offset: 0x0000D2F5
	public override void WriteValue(int 1)
	{
		base.WriteValue(1);
		this.Method12966(1, 550.Integer);
	}

	// Token: 0x060004FC RID: 1276 RVA: 0x0000F10C File Offset: 0x0000D30C
	[CLSCompliant(false)]
	public override void WriteValue(uint 1)
	{
		if (1 > 2147483647U)
		{
			throw 763.Method12341(this, "Value is too large to fit in a signed 32 bit integer. BSON does not support unsigned values.", null);
		}
		base.WriteValue(1);
		this.Method12966(1, 550.Integer);
	}

	// Token: 0x060004FD RID: 1277 RVA: 0x0000F138 File Offset: 0x0000D338
	public override void WriteValue(long 1)
	{
		base.WriteValue(1);
		this.Method12966(1, 550.Long);
	}

	// Token: 0x060004FE RID: 1278 RVA: 0x0000F14F File Offset: 0x0000D34F
	[CLSCompliant(false)]
	public override void WriteValue(ulong 1)
	{
		if (1 > 9223372036854775807UL)
		{
			throw 763.Method12341(this, "Value is too large to fit in a signed 64 bit integer. BSON does not support unsigned values.", null);
		}
		base.WriteValue(1);
		this.Method12966(1, 550.Long);
	}

	// Token: 0x060004FF RID: 1279 RVA: 0x0000F17F File Offset: 0x0000D37F
	public override void WriteValue(float 1)
	{
		base.WriteValue(1);
		this.Method12966(1, 550.Number);
	}

	// Token: 0x06000500 RID: 1280 RVA: 0x0000F195 File Offset: 0x0000D395
	public override void WriteValue(double 1)
	{
		base.WriteValue(1);
		this.Method12966(1, 550.Number);
	}

	// Token: 0x06000501 RID: 1281 RVA: 0x0000F1AB File Offset: 0x0000D3AB
	public override void WriteValue(bool 1)
	{
		base.WriteValue(1);
		this.Method12967(1 ? 570._recoveredType13546079 : 570._recoveredType13546078);
	}

	// Token: 0x06000502 RID: 1282 RVA: 0x0000F1C9 File Offset: 0x0000D3C9
	public override void WriteValue(short 1)
	{
		base.WriteValue(1);
		this.Method12966(1, 550.Integer);
	}

	// Token: 0x06000503 RID: 1283 RVA: 0x0000F1E0 File Offset: 0x0000D3E0
	[CLSCompliant(false)]
	public override void WriteValue(ushort 1)
	{
		base.WriteValue(1);
		this.Method12966(1, 550.Integer);
	}

	// Token: 0x06000504 RID: 1284 RVA: 0x0000F1F8 File Offset: 0x0000D3F8
	public override void WriteValue(char 1)
	{
		base.WriteValue(1);
		string 2 = 1.ToString(CultureInfo.InvariantCulture);
		this.Method12967(new 741(2, true));
	}

	// Token: 0x06000505 RID: 1285 RVA: 0x0000F228 File Offset: 0x0000D428
	public override void WriteValue(byte 1)
	{
		base.WriteValue(1);
		this.Method12966(1, 550.Integer);
	}

	// Token: 0x06000506 RID: 1286 RVA: 0x0000F23F File Offset: 0x0000D43F
	[CLSCompliant(false)]
	public override void WriteValue(sbyte 1)
	{
		base.WriteValue(1);
		this.Method12966(1, 550.Integer);
	}

	// Token: 0x06000507 RID: 1287 RVA: 0x0000F256 File Offset: 0x0000D456
	public override void WriteValue(decimal 1)
	{
		base.WriteValue(1);
		this.Method12966(1, 550.Number);
	}

	// Token: 0x06000508 RID: 1288 RVA: 0x0000F26C File Offset: 0x0000D46C
	public override void WriteValue(DateTime 1)
	{
		base.WriteValue(1);
		1 = 382.Method2108(1, base.GetDateTimeZoneHandling());
		this.Method12966(1, 550.Date);
	}

	// Token: 0x06000509 RID: 1289 RVA: 0x0000F291 File Offset: 0x0000D491
	public override void WriteValue(DateTimeOffset 1)
	{
		base.WriteValue(1);
		this.Method12966(1, 550.Date);
	}

	// Token: 0x0600050A RID: 1290 RVA: 0x0000F2A8 File Offset: 0x0000D4A8
	public override void WriteValue(byte[] 1)
	{
		if (1 == null)
		{
			this.WriteNull();
			return;
		}
		base.WriteValue(1);
		this.Method12967(new 730(1, (440)0));
	}

	// Token: 0x0600050B RID: 1291 RVA: 0x0000F2C8 File Offset: 0x0000D4C8
	public override void WriteValue(Guid 1)
	{
		base.WriteValue(1);
		this.Method12967(new 730(1.ToByteArray(), (440)4));
	}

	// Token: 0x0600050C RID: 1292 RVA: 0x0000F2E4 File Offset: 0x0000D4E4
	public override void WriteValue(TimeSpan 1)
	{
		base.WriteValue(1);
		this.Method12967(new 741(1.ToString(), true));
	}

	// Token: 0x0600050D RID: 1293 RVA: 0x0000F306 File Offset: 0x0000D506
	public override void WriteValue(Uri 1)
	{
		if (1 == null)
		{
			this.WriteNull();
			return;
		}
		base.WriteValue(1);
		this.Method12967(new 741(1.ToString(), true));
	}

	// Token: 0x0600050E RID: 1294 RVA: 0x0000F331 File Offset: 0x0000D531
	public void Method12991(byte[] 1)
	{
		756.Method12216(1, "value");
		if (1.Length != 12)
		{
			throw 763.Method12341(this, "An object id must be 12 bytes", null);
		}
		base.Method7420(216.Undefined, null);
		this.Method12966(1, 550.Oid);
	}

	// Token: 0x0600050F RID: 1295 RVA: 0x0000F363 File Offset: 0x0000D563
	public void Method12992(string 1, string 2)
	{
		756.Method12216(1, "pattern");
		base.Method7420(216.Undefined, null);
		this.Method12967(new 747(1, 2));
	}

	// Token: 0x040003FE RID: 1022
	private readonly 127 jsonBsonBinaryWriter;

	// Token: 0x040003FF RID: 1023
	private 679 _recoveredType183110104;

	// Token: 0x04000400 RID: 1024
	private 679 _recoveredType183110105;

	// Token: 0x04000401 RID: 1025
	private string text4;
}
