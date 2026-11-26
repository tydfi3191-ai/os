using System;
using System.Globalization;
using System.IO;
using System.Numerics;

// Token: 0x0200010F RID: 271
[242(1)]
[241(0)]
public sealed class 931 : 173
{
	// Token: 0x060009C5 RID: 2501 RVA: 0x000244DC File Offset: 0x000226DC
	public 931(173 1)
	{
		this.jsonWriter2 = 1;
		this.stringWriter = new StringWriter(CultureInfo.InvariantCulture);
		this.stringWriter.Write("Serialized JSON: " + Environment.NewLine);
		this.jsonTextWriter = new 168(this.stringWriter);
		this.jsonTextWriter.SetFormatting((95)1);
		this.jsonTextWriter.SetCulture(1.GetCulture());
		this.jsonTextWriter.SetDateFormatHandling(1.GetDateFormatHandling());
		this.jsonTextWriter.DateFormatString = 1.DateFormatString;
		this.jsonTextWriter.SetDateTimeZoneHandling(1.GetDateTimeZoneHandling());
		this.jsonTextWriter.SetFloatFormatHandling(1.GetFloatFormatHandling());
	}

	// Token: 0x060009C6 RID: 2502 RVA: 0x00024592 File Offset: 0x00022792
	public string Method12021()
	{
		return this.stringWriter.ToString();
	}

	// Token: 0x060009C7 RID: 2503 RVA: 0x0002459F File Offset: 0x0002279F
	public override void WriteValue(decimal 1)
	{
		this.jsonTextWriter.WriteValue(1);
		this.jsonWriter2.WriteValue(1);
		base.WriteValue(1);
	}

	// Token: 0x060009C8 RID: 2504 RVA: 0x000245C0 File Offset: 0x000227C0
	public override void WriteValue(decimal? 1)
	{
		this.jsonTextWriter.WriteValue(1);
		this.jsonWriter2.WriteValue(1);
		if (1 != null)
		{
			base.WriteValue(1.GetValueOrDefault());
			return;
		}
		base.WriteUndefined();
	}

	// Token: 0x060009C9 RID: 2505 RVA: 0x000245F7 File Offset: 0x000227F7
	public override void WriteValue(bool 1)
	{
		this.jsonTextWriter.WriteValue(1);
		this.jsonWriter2.WriteValue(1);
		base.WriteValue(1);
	}

	// Token: 0x060009CA RID: 2506 RVA: 0x00024618 File Offset: 0x00022818
	public override void WriteValue(bool? 1)
	{
		this.jsonTextWriter.WriteValue(1);
		this.jsonWriter2.WriteValue(1);
		if (1 != null)
		{
			base.WriteValue(1.GetValueOrDefault());
			return;
		}
		base.WriteUndefined();
	}

	// Token: 0x060009CB RID: 2507 RVA: 0x0002464F File Offset: 0x0002284F
	public override void WriteValue(byte 1)
	{
		this.jsonTextWriter.WriteValue(1);
		this.jsonWriter2.WriteValue(1);
		base.WriteValue(1);
	}

	// Token: 0x060009CC RID: 2508 RVA: 0x00024670 File Offset: 0x00022870
	public override void WriteValue(byte? 1)
	{
		this.jsonTextWriter.WriteValue(1);
		this.jsonWriter2.WriteValue(1);
		if (1 != null)
		{
			base.WriteValue(1.GetValueOrDefault());
			return;
		}
		base.WriteUndefined();
	}

	// Token: 0x060009CD RID: 2509 RVA: 0x000246A7 File Offset: 0x000228A7
	public override void WriteValue(char 1)
	{
		this.jsonTextWriter.WriteValue(1);
		this.jsonWriter2.WriteValue(1);
		base.WriteValue(1);
	}

	// Token: 0x060009CE RID: 2510 RVA: 0x000246C8 File Offset: 0x000228C8
	public override void WriteValue(char? 1)
	{
		this.jsonTextWriter.WriteValue(1);
		this.jsonWriter2.WriteValue(1);
		if (1 != null)
		{
			base.WriteValue(1.GetValueOrDefault());
			return;
		}
		base.WriteUndefined();
	}

	// Token: 0x060009CF RID: 2511 RVA: 0x000246FF File Offset: 0x000228FF
	[242(2)]
	public override void WriteValue(byte[] 1)
	{
		this.jsonTextWriter.WriteValue(1);
		this.jsonWriter2.WriteValue(1);
		if (1 == null)
		{
			base.WriteUndefined();
			return;
		}
		base.WriteValue(1);
	}

	// Token: 0x060009D0 RID: 2512 RVA: 0x0002472A File Offset: 0x0002292A
	public override void WriteValue(DateTime 1)
	{
		this.jsonTextWriter.WriteValue(1);
		this.jsonWriter2.WriteValue(1);
		base.WriteValue(1);
	}

	// Token: 0x060009D1 RID: 2513 RVA: 0x0002474B File Offset: 0x0002294B
	public override void WriteValue(DateTime? 1)
	{
		this.jsonTextWriter.WriteValue(1);
		this.jsonWriter2.WriteValue(1);
		if (1 != null)
		{
			base.WriteValue(1.GetValueOrDefault());
			return;
		}
		base.WriteUndefined();
	}

	// Token: 0x060009D2 RID: 2514 RVA: 0x00024782 File Offset: 0x00022982
	public override void WriteValue(DateTimeOffset 1)
	{
		this.jsonTextWriter.WriteValue(1);
		this.jsonWriter2.WriteValue(1);
		base.WriteValue(1);
	}

	// Token: 0x060009D3 RID: 2515 RVA: 0x000247A3 File Offset: 0x000229A3
	public override void WriteValue(DateTimeOffset? 1)
	{
		this.jsonTextWriter.WriteValue(1);
		this.jsonWriter2.WriteValue(1);
		if (1 != null)
		{
			base.WriteValue(1.GetValueOrDefault());
			return;
		}
		base.WriteUndefined();
	}

	// Token: 0x060009D4 RID: 2516 RVA: 0x000247DA File Offset: 0x000229DA
	public override void WriteValue(double 1)
	{
		this.jsonTextWriter.WriteValue(1);
		this.jsonWriter2.WriteValue(1);
		base.WriteValue(1);
	}

	// Token: 0x060009D5 RID: 2517 RVA: 0x000247FB File Offset: 0x000229FB
	public override void WriteValue(double? 1)
	{
		this.jsonTextWriter.WriteValue(1);
		this.jsonWriter2.WriteValue(1);
		if (1 != null)
		{
			base.WriteValue(1.GetValueOrDefault());
			return;
		}
		base.WriteUndefined();
	}

	// Token: 0x060009D6 RID: 2518 RVA: 0x00024832 File Offset: 0x00022A32
	public override void WriteUndefined()
	{
		this.jsonTextWriter.WriteUndefined();
		this.jsonWriter2.WriteUndefined();
		base.WriteUndefined();
	}

	// Token: 0x060009D7 RID: 2519 RVA: 0x00024850 File Offset: 0x00022A50
	public override void WriteNull()
	{
		this.jsonTextWriter.WriteNull();
		this.jsonWriter2.WriteNull();
		base.WriteUndefined();
	}

	// Token: 0x060009D8 RID: 2520 RVA: 0x0002486E File Offset: 0x00022A6E
	public override void WriteValue(float 1)
	{
		this.jsonTextWriter.WriteValue(1);
		this.jsonWriter2.WriteValue(1);
		base.WriteValue(1);
	}

	// Token: 0x060009D9 RID: 2521 RVA: 0x0002488F File Offset: 0x00022A8F
	public override void WriteValue(float? 1)
	{
		this.jsonTextWriter.WriteValue(1);
		this.jsonWriter2.WriteValue(1);
		if (1 != null)
		{
			base.WriteValue(1.GetValueOrDefault());
			return;
		}
		base.WriteUndefined();
	}

	// Token: 0x060009DA RID: 2522 RVA: 0x000248C6 File Offset: 0x00022AC6
	public override void WriteValue(Guid 1)
	{
		this.jsonTextWriter.WriteValue(1);
		this.jsonWriter2.WriteValue(1);
		base.WriteValue(1);
	}

	// Token: 0x060009DB RID: 2523 RVA: 0x000248E7 File Offset: 0x00022AE7
	public override void WriteValue(Guid? 1)
	{
		this.jsonTextWriter.WriteValue(1);
		this.jsonWriter2.WriteValue(1);
		if (1 != null)
		{
			base.WriteValue(1.GetValueOrDefault());
			return;
		}
		base.WriteUndefined();
	}

	// Token: 0x060009DC RID: 2524 RVA: 0x0002491E File Offset: 0x00022B1E
	public override void WriteValue(int 1)
	{
		this.jsonTextWriter.WriteValue(1);
		this.jsonWriter2.WriteValue(1);
		base.WriteValue(1);
	}

	// Token: 0x060009DD RID: 2525 RVA: 0x0002493F File Offset: 0x00022B3F
	public override void WriteValue(int? 1)
	{
		this.jsonTextWriter.WriteValue(1);
		this.jsonWriter2.WriteValue(1);
		if (1 != null)
		{
			base.WriteValue(1.GetValueOrDefault());
			return;
		}
		base.WriteUndefined();
	}

	// Token: 0x060009DE RID: 2526 RVA: 0x00024976 File Offset: 0x00022B76
	public override void WriteValue(long 1)
	{
		this.jsonTextWriter.WriteValue(1);
		this.jsonWriter2.WriteValue(1);
		base.WriteValue(1);
	}

	// Token: 0x060009DF RID: 2527 RVA: 0x00024997 File Offset: 0x00022B97
	public override void WriteValue(long? 1)
	{
		this.jsonTextWriter.WriteValue(1);
		this.jsonWriter2.WriteValue(1);
		if (1 != null)
		{
			base.WriteValue(1.GetValueOrDefault());
			return;
		}
		base.WriteUndefined();
	}

	// Token: 0x060009E0 RID: 2528 RVA: 0x000249D0 File Offset: 0x00022BD0
	[242(2)]
	public override void WriteValue(object 1)
	{
		if (1 is BigInteger)
		{
			this.jsonTextWriter.WriteValue(1);
			this.jsonWriter2.WriteValue(1);
			base.Method7425(216.Integer);
			return;
		}
		this.jsonTextWriter.WriteValue(1);
		this.jsonWriter2.WriteValue(1);
		if (1 == null)
		{
			base.WriteUndefined();
			return;
		}
		base.Method7425(216.String);
	}

	// Token: 0x060009E1 RID: 2529 RVA: 0x00024A2F File Offset: 0x00022C2F
	public override void WriteValue(sbyte 1)
	{
		this.jsonTextWriter.WriteValue(1);
		this.jsonWriter2.WriteValue(1);
		base.WriteValue(1);
	}

	// Token: 0x060009E2 RID: 2530 RVA: 0x00024A50 File Offset: 0x00022C50
	public override void WriteValue(sbyte? 1)
	{
		this.jsonTextWriter.WriteValue(1);
		this.jsonWriter2.WriteValue(1);
		if (1 != null)
		{
			base.WriteValue(1.GetValueOrDefault());
			return;
		}
		base.WriteUndefined();
	}

	// Token: 0x060009E3 RID: 2531 RVA: 0x00024A87 File Offset: 0x00022C87
	public override void WriteValue(short 1)
	{
		this.jsonTextWriter.WriteValue(1);
		this.jsonWriter2.WriteValue(1);
		base.WriteValue(1);
	}

	// Token: 0x060009E4 RID: 2532 RVA: 0x00024AA8 File Offset: 0x00022CA8
	public override void WriteValue(short? 1)
	{
		this.jsonTextWriter.WriteValue(1);
		this.jsonWriter2.WriteValue(1);
		if (1 != null)
		{
			base.WriteValue(1.GetValueOrDefault());
			return;
		}
		base.WriteUndefined();
	}

	// Token: 0x060009E5 RID: 2533 RVA: 0x00024ADF File Offset: 0x00022CDF
	[242(2)]
	public override void WriteValue(string 1)
	{
		this.jsonTextWriter.WriteValue(1);
		this.jsonWriter2.WriteValue(1);
		base.WriteValue(1);
	}

	// Token: 0x060009E6 RID: 2534 RVA: 0x00024B00 File Offset: 0x00022D00
	public override void WriteValue(TimeSpan 1)
	{
		this.jsonTextWriter.WriteValue(1);
		this.jsonWriter2.WriteValue(1);
		base.WriteValue(1);
	}

	// Token: 0x060009E7 RID: 2535 RVA: 0x00024B21 File Offset: 0x00022D21
	public override void WriteValue(TimeSpan? 1)
	{
		this.jsonTextWriter.WriteValue(1);
		this.jsonWriter2.WriteValue(1);
		if (1 != null)
		{
			base.WriteValue(1.GetValueOrDefault());
			return;
		}
		base.WriteUndefined();
	}

	// Token: 0x060009E8 RID: 2536 RVA: 0x00024B58 File Offset: 0x00022D58
	public override void WriteValue(uint 1)
	{
		this.jsonTextWriter.WriteValue(1);
		this.jsonWriter2.WriteValue(1);
		base.WriteValue(1);
	}

	// Token: 0x060009E9 RID: 2537 RVA: 0x00024B79 File Offset: 0x00022D79
	public override void WriteValue(uint? 1)
	{
		this.jsonTextWriter.WriteValue(1);
		this.jsonWriter2.WriteValue(1);
		if (1 != null)
		{
			base.WriteValue(1.GetValueOrDefault());
			return;
		}
		base.WriteUndefined();
	}

	// Token: 0x060009EA RID: 2538 RVA: 0x00024BB0 File Offset: 0x00022DB0
	public override void WriteValue(ulong 1)
	{
		this.jsonTextWriter.WriteValue(1);
		this.jsonWriter2.WriteValue(1);
		base.WriteValue(1);
	}

	// Token: 0x060009EB RID: 2539 RVA: 0x00024BD1 File Offset: 0x00022DD1
	public override void WriteValue(ulong? 1)
	{
		this.jsonTextWriter.WriteValue(1);
		this.jsonWriter2.WriteValue(1);
		if (1 != null)
		{
			base.WriteValue(1.GetValueOrDefault());
			return;
		}
		base.WriteUndefined();
	}

	// Token: 0x060009EC RID: 2540 RVA: 0x00024C08 File Offset: 0x00022E08
	[242(2)]
	public override void WriteValue(Uri 1)
	{
		this.jsonTextWriter.WriteValue(1);
		this.jsonWriter2.WriteValue(1);
		if (1 == null)
		{
			base.WriteUndefined();
			return;
		}
		base.WriteValue(1);
	}

	// Token: 0x060009ED RID: 2541 RVA: 0x00024C39 File Offset: 0x00022E39
	public override void WriteValue(ushort 1)
	{
		this.jsonTextWriter.WriteValue(1);
		this.jsonWriter2.WriteValue(1);
		base.WriteValue(1);
	}

	// Token: 0x060009EE RID: 2542 RVA: 0x00024C5A File Offset: 0x00022E5A
	public override void WriteValue(ushort? 1)
	{
		this.jsonTextWriter.WriteValue(1);
		this.jsonWriter2.WriteValue(1);
		if (1 != null)
		{
			base.WriteValue(1.GetValueOrDefault());
			return;
		}
		base.WriteUndefined();
	}

	// Token: 0x060009EF RID: 2543 RVA: 0x00024C91 File Offset: 0x00022E91
	public override void WriteWhitespace(string 1)
	{
		this.jsonTextWriter.WriteWhitespace(1);
		this.jsonWriter2.WriteWhitespace(1);
		base.WriteWhitespace(1);
	}

	// Token: 0x060009F0 RID: 2544 RVA: 0x00024CB2 File Offset: 0x00022EB2
	[242(2)]
	public override void WriteComment(string 1)
	{
		this.jsonTextWriter.WriteComment(1);
		this.jsonWriter2.WriteComment(1);
		base.WriteComment(1);
	}

	// Token: 0x060009F1 RID: 2545 RVA: 0x00024CD3 File Offset: 0x00022ED3
	public override void WriteStartArray()
	{
		this.jsonTextWriter.WriteStartArray();
		this.jsonWriter2.WriteStartArray();
		base.WriteStartArray();
	}

	// Token: 0x060009F2 RID: 2546 RVA: 0x00024CF1 File Offset: 0x00022EF1
	public override void WriteEndArray()
	{
		this.jsonTextWriter.WriteEndArray();
		this.jsonWriter2.WriteEndArray();
		base.WriteEndArray();
	}

	// Token: 0x060009F3 RID: 2547 RVA: 0x00024D0F File Offset: 0x00022F0F
	public override void WriteStartConstructor(string 1)
	{
		this.jsonTextWriter.WriteStartConstructor(1);
		this.jsonWriter2.WriteStartConstructor(1);
		base.WriteStartConstructor(1);
	}

	// Token: 0x060009F4 RID: 2548 RVA: 0x00024D30 File Offset: 0x00022F30
	public override void WriteEndConstructor()
	{
		this.jsonTextWriter.WriteEndConstructor();
		this.jsonWriter2.WriteEndConstructor();
		base.WriteEndConstructor();
	}

	// Token: 0x060009F5 RID: 2549 RVA: 0x00024D4E File Offset: 0x00022F4E
	public override void WritePropertyName(string 1)
	{
		this.jsonTextWriter.WritePropertyName(1);
		this.jsonWriter2.WritePropertyName(1);
		base.WritePropertyName(1);
	}

	// Token: 0x060009F6 RID: 2550 RVA: 0x00024D6F File Offset: 0x00022F6F
	public override void WritePropertyName(string 1, bool 2)
	{
		this.jsonTextWriter.WritePropertyName(1, 2);
		this.jsonWriter2.WritePropertyName(1, 2);
		base.WritePropertyName(1);
	}

	// Token: 0x060009F7 RID: 2551 RVA: 0x00024D92 File Offset: 0x00022F92
	public override void WriteStartObject()
	{
		this.jsonTextWriter.WriteStartObject();
		this.jsonWriter2.WriteStartObject();
		base.WriteStartObject();
	}

	// Token: 0x060009F8 RID: 2552 RVA: 0x00024DB0 File Offset: 0x00022FB0
	public override void WriteEndObject()
	{
		this.jsonTextWriter.WriteEndObject();
		this.jsonWriter2.WriteEndObject();
		base.WriteEndObject();
	}

	// Token: 0x060009F9 RID: 2553 RVA: 0x00024DCE File Offset: 0x00022FCE
	[242(2)]
	public override void WriteRawValue(string 1)
	{
		this.jsonTextWriter.WriteRawValue(1);
		this.jsonWriter2.WriteRawValue(1);
		base.Method7425(216.Undefined);
	}

	// Token: 0x060009FA RID: 2554 RVA: 0x00024DF0 File Offset: 0x00022FF0
	[242(2)]
	public override void WriteRaw(string 1)
	{
		this.jsonTextWriter.WriteRaw(1);
		this.jsonWriter2.WriteRaw(1);
		base.WriteRaw(1);
	}

	// Token: 0x060009FB RID: 2555 RVA: 0x00024E11 File Offset: 0x00023011
	public override void Close()
	{
		this.jsonTextWriter.Close();
		this.jsonWriter2.Close();
		base.Close();
	}

	// Token: 0x060009FC RID: 2556 RVA: 0x00024E2F File Offset: 0x0002302F
	public override void Flush()
	{
		this.jsonTextWriter.Flush();
		this.jsonWriter2.Flush();
	}

	// Token: 0x04000506 RID: 1286
	private readonly 173 jsonWriter2;

	// Token: 0x04000507 RID: 1287
	private readonly 168 jsonTextWriter;

	// Token: 0x04000508 RID: 1288
	private readonly StringWriter stringWriter;
}
