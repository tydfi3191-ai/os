using System;
using System.Globalization;
using System.IO;

// Token: 0x0200010E RID: 270
[242(1)]
[241(0)]
public sealed class 930 : 139, 99
{
	// Token: 0x060009AB RID: 2475 RVA: 0x000242BD File Offset: 0x000224BD
	[242(2)]
	[241(2)]
	public override object GetValue()
	{
		return this.jsonReader2.GetValue();
	}

	// Token: 0x060009AC RID: 2476 RVA: 0x000242CA File Offset: 0x000224CA
	[242(2)]
	[241(2)]
	public override Type GetValueType()
	{
		return this.jsonReader2.GetValueType();
	}

	// Token: 0x060009AD RID: 2477 RVA: 0x000242D8 File Offset: 0x000224D8
	public 930(139 1)
	{
		this.jsonReader2 = 1;
		this.stringWriter = new StringWriter(CultureInfo.InvariantCulture);
		this.stringWriter.Write("Deserialized JSON: " + Environment.NewLine);
		this.jsonTextWriter = new 168(this.stringWriter);
		this.jsonTextWriter.SetFormatting((95)1);
	}

	// Token: 0x060009AE RID: 2478 RVA: 0x00024339 File Offset: 0x00022539
	public string Method1186()
	{
		return this.stringWriter.ToString();
	}

	// Token: 0x060009AF RID: 2479 RVA: 0x00024346 File Offset: 0x00022546
	public override bool Read()
	{
		bool result = this.jsonReader2.Read();
		this.Method1196();
		return result;
	}

	// Token: 0x060009B0 RID: 2480 RVA: 0x00024359 File Offset: 0x00022559
	public override int? ReadAsInt32()
	{
		int? result = this.jsonReader2.ReadAsInt32();
		this.Method1196();
		return result;
	}

	// Token: 0x060009B1 RID: 2481 RVA: 0x0002436C File Offset: 0x0002256C
	[242(2)]
	public override string ReadAsString()
	{
		string result = this.jsonReader2.ReadAsString();
		this.Method1196();
		return result;
	}

	// Token: 0x060009B2 RID: 2482 RVA: 0x0002437F File Offset: 0x0002257F
	[242(2)]
	public override byte[] ReadAsBytes()
	{
		byte[] result = this.jsonReader2.ReadAsBytes();
		this.Method1196();
		return result;
	}

	// Token: 0x060009B3 RID: 2483 RVA: 0x00024392 File Offset: 0x00022592
	public override decimal? ReadAsDecimal()
	{
		decimal? result = this.jsonReader2.ReadAsDecimal();
		this.Method1196();
		return result;
	}

	// Token: 0x060009B4 RID: 2484 RVA: 0x000243A5 File Offset: 0x000225A5
	public override double? ReadAsDouble()
	{
		double? result = this.jsonReader2.ReadAsDouble();
		this.Method1196();
		return result;
	}

	// Token: 0x060009B5 RID: 2485 RVA: 0x000243B8 File Offset: 0x000225B8
	public override bool? ReadAsBoolean()
	{
		bool? result = this.jsonReader2.ReadAsBoolean();
		this.Method1196();
		return result;
	}

	// Token: 0x060009B6 RID: 2486 RVA: 0x000243CB File Offset: 0x000225CB
	public override DateTime? ReadAsDateTime()
	{
		DateTime? result = this.jsonReader2.ReadAsDateTime();
		this.Method1196();
		return result;
	}

	// Token: 0x060009B7 RID: 2487 RVA: 0x000243DE File Offset: 0x000225DE
	public override DateTimeOffset? ReadAsDateTimeOffset()
	{
		DateTimeOffset? result = this.jsonReader2.ReadAsDateTimeOffset();
		this.Method1196();
		return result;
	}

	// Token: 0x060009B8 RID: 2488 RVA: 0x000243F1 File Offset: 0x000225F1
	public void Method1196()
	{
		this.jsonTextWriter.WriteToken(this.jsonReader2, false, false, true);
	}

	// Token: 0x060009B9 RID: 2489 RVA: 0x00024407 File Offset: 0x00022607
	public override int GetDepth()
	{
		return this.jsonReader2.GetDepth();
	}

	// Token: 0x060009BA RID: 2490 RVA: 0x00024414 File Offset: 0x00022614
	public string Method1198()
	{
		return this.jsonReader2.Path;
	}

	// Token: 0x060009BB RID: 2491 RVA: 0x00024421 File Offset: 0x00022621
	public override char GetQuoteChar()
	{
		return this.jsonReader2.GetQuoteChar();
	}

	// Token: 0x060009BC RID: 2492 RVA: 0x0002442E File Offset: 0x0002262E
	protected internal override void SetQuoteChar(char 1)
	{
		this.jsonReader2.SetQuoteChar(1);
	}

	// Token: 0x060009BD RID: 2493 RVA: 0x0002443C File Offset: 0x0002263C
	public override 216 GetTokenType()
	{
		return this.jsonReader2.GetTokenType();
	}

	// Token: 0x060009BE RID: 2494 RVA: 0x00024449 File Offset: 0x00022649
	public override void Close()
	{
		this.jsonReader2.Close();
	}

	// Token: 0x060009BF RID: 2495 RVA: 0x00024458 File Offset: 0x00022658
	private bool Method1203()
	{
		99 <<EMPTY_NAME>> = this.jsonReader2 as 99;
		return <<EMPTY_NAME>> != null && <<EMPTY_NAME>>.HasLineInfo();
	}

	// Token: 0x060009C0 RID: 2496 RVA: 0x0002447C File Offset: 0x0002267C
	bool 99.HasLineInfo()
	{
		return this.Method1203();
	}

	// Token: 0x060009C1 RID: 2497 RVA: 0x00024484 File Offset: 0x00022684
	private int Method1205()
	{
		99 <<EMPTY_NAME>> = this.jsonReader2 as 99;
		if (<<EMPTY_NAME>> == null)
		{
			return 0;
		}
		return <<EMPTY_NAME>>.GetLineNumber();
	}

	// Token: 0x060009C2 RID: 2498 RVA: 0x000244A8 File Offset: 0x000226A8
	int 99.GetLineNumber()
	{
		return this.Method1205();
	}

	// Token: 0x060009C3 RID: 2499 RVA: 0x000244B0 File Offset: 0x000226B0
	private int Method1207()
	{
		99 <<EMPTY_NAME>> = this.jsonReader2 as 99;
		if (<<EMPTY_NAME>> == null)
		{
			return 0;
		}
		return <<EMPTY_NAME>>.GetLinePosition();
	}

	// Token: 0x060009C4 RID: 2500 RVA: 0x000244D4 File Offset: 0x000226D4
	int 99.GetLinePosition()
	{
		return this.Method1207();
	}

	// Token: 0x04000503 RID: 1283
	private readonly 139 jsonReader2;

	// Token: 0x04000504 RID: 1284
	private readonly 168 jsonTextWriter;

	// Token: 0x04000505 RID: 1285
	private readonly StringWriter stringWriter;
}
