using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x020000FE RID: 254
public sealed class 543
{
	// Token: 0x06000893 RID: 2195 RVA: 0x0001CF75 File Offset: 0x0001B175
	public 543(173 1, 744 2)
	{
		756.Method12216(1, "writer");
		this.jsonWriter2 = 1;
		this._recoveredType21665502 = 2;
	}

	// Token: 0x06000894 RID: 2196 RVA: 0x0001CF98 File Offset: 0x0001B198
	private void Method6918(529 1)
	{
		if (1.GetText5091_6370() != null && this._recoveredType21665502.Method11938(1.GetText5091_6370()) != null)
		{
			this.jsonWriter2.WriteStartObject();
			this.jsonWriter2.WritePropertyName("$ref");
			this.jsonWriter2.WriteValue(1.GetText5091_6370());
			this.jsonWriter2.WriteEndObject();
			return;
		}
		this.Method6919(1);
	}

	// Token: 0x06000895 RID: 2197 RVA: 0x0001D000 File Offset: 0x0001B200
	public void Method6919(529 1)
	{
		756.Method12216(1, "schema");
		if (!this._recoveredType21665502.GetIList9362_11936().Contains(1))
		{
			this._recoveredType21665502.GetIList9362_11936().Add(1);
		}
		this.jsonWriter2.WriteStartObject();
		this.Method6923(this.jsonWriter2, "id", 1.GetText5091_6370());
		this.Method6923(this.jsonWriter2, "title", 1.GetText5092_6372());
		this.Method6923(this.jsonWriter2, "description", 1.GetText5097_6382());
		this.Method6923(this.jsonWriter2, "required", 1.GetNullable5093_6374());
		this.Method6923(this.jsonWriter2, "readonly", 1.GetNullable5094_6376());
		this.Method6923(this.jsonWriter2, "hidden", 1.GetNullable5095_6378());
		this.Method6923(this.jsonWriter2, "transient", 1.GetNullable5096_6380());
		if (1.GetNullable5098_6384() != null)
		{
			this.Method6922("type", this.jsonWriter2, 1.GetNullable5098_6384().GetValueOrDefault());
		}
		if (!1.GetFlag5117_6422())
		{
			this.jsonWriter2.WritePropertyName("additionalProperties");
			this.jsonWriter2.WriteValue(1.GetFlag5117_6422());
		}
		else if (1.GetRecoveredType11435115_6418() != null)
		{
			this.jsonWriter2.WritePropertyName("additionalProperties");
			this.Method6918(1.GetRecoveredType11435115_6418());
		}
		if (!1.GetFlag5112_6412())
		{
			this.jsonWriter2.WritePropertyName("additionalItems");
			this.jsonWriter2.WriteValue(1.GetFlag5112_6412());
		}
		else if (1.GetRecoveredType11435111_6410() != null)
		{
			this.jsonWriter2.WritePropertyName("additionalItems");
			this.Method6918(1.GetRecoveredType11435111_6410());
		}
		this.Method6920(this.jsonWriter2, "properties", 1.GetIDictionary5114_6416());
		this.Method6920(this.jsonWriter2, "patternProperties", 1.GetIDictionary5116_6420());
		this.Method6921(1);
		this.Method6923(this.jsonWriter2, "minimum", 1.GetNullable5103_6394());
		this.Method6923(this.jsonWriter2, "maximum", 1.GetNullable5104_6396());
		this.Method6923(this.jsonWriter2, "exclusiveMinimum", 1.GetNullable5105_6398());
		this.Method6923(this.jsonWriter2, "exclusiveMaximum", 1.GetNullable5106_6400());
		this.Method6923(this.jsonWriter2, "minLength", 1.GetNullable5100_6388());
		this.Method6923(this.jsonWriter2, "maxLength", 1.GetNullable5101_6390());
		this.Method6923(this.jsonWriter2, "minItems", 1.GetNullable5107_6402());
		this.Method6923(this.jsonWriter2, "maxItems", 1.GetNullable5108_6404());
		this.Method6923(this.jsonWriter2, "divisibleBy", 1.GetNullable5102_6392());
		this.Method6923(this.jsonWriter2, "format", 1.GetText5123_6434());
		this.Method6923(this.jsonWriter2, "pattern", 1.GetText5099_6386());
		if (1.GetIList5119_6426() != null)
		{
			this.jsonWriter2.WritePropertyName("enum");
			this.jsonWriter2.WriteStartArray();
			foreach (226 2 in 1.GetIList5119_6426())
			{
				2.WriteTo(this.jsonWriter2, Array.Empty<214>());
			}
			this.jsonWriter2.WriteEndArray();
		}
		if (1.GetJToken5121_6430() != null)
		{
			this.jsonWriter2.WritePropertyName("default");
			1.GetJToken5121_6430().WriteTo(this.jsonWriter2, Array.Empty<214>());
		}
		if (1.GetNullable5120_6428() != null)
		{
			this.Method6922("disallow", this.jsonWriter2, 1.GetNullable5120_6428().GetValueOrDefault());
		}
		if (1.GetIList5122_6432() != null && 1.GetIList5122_6432().Count > 0)
		{
			this.jsonWriter2.WritePropertyName("extends");
			if (1.GetIList5122_6432().Count == 1)
			{
				this.Method6918(1.GetIList5122_6432()[0]);
			}
			else
			{
				this.jsonWriter2.WriteStartArray();
				foreach (529 3 in 1.GetIList5122_6432())
				{
					this.Method6918(3);
				}
				this.jsonWriter2.WriteEndArray();
			}
		}
		this.jsonWriter2.WriteEndObject();
	}

	// Token: 0x06000896 RID: 2198 RVA: 0x0001D4A4 File Offset: 0x0001B6A4
	private void Method6920(173 1, string 2, IDictionary<string, 529> 3)
	{
		if (3 == null)
		{
			return;
		}
		1.WritePropertyName(2);
		1.WriteStartObject();
		foreach (KeyValuePair<string, 529> keyValuePair in 3)
		{
			1.WritePropertyName(keyValuePair.Key);
			this.Method6918(keyValuePair.Value);
		}
		1.WriteEndObject();
	}

	// Token: 0x06000897 RID: 2199 RVA: 0x0001D518 File Offset: 0x0001B718
	private void Method6921(529 1)
	{
		if (1.GetIList5109_6406() == null && !1.GetFlag5110_6408())
		{
			return;
		}
		this.jsonWriter2.WritePropertyName("items");
		if (1.GetFlag5110_6408())
		{
			this.jsonWriter2.WriteStartArray();
			if (1.GetIList5109_6406() != null)
			{
				foreach (529 2 in 1.GetIList5109_6406())
				{
					this.Method6918(2);
				}
			}
			this.jsonWriter2.WriteEndArray();
			return;
		}
		if (1.GetIList5109_6406() != null && 1.GetIList5109_6406().Count > 0)
		{
			this.Method6918(1.GetIList5109_6406()[0]);
			return;
		}
		this.jsonWriter2.WriteStartObject();
		this.jsonWriter2.WriteEndObject();
	}

	// Token: 0x06000898 RID: 2200 RVA: 0x0001D5EC File Offset: 0x0001B7EC
	private void Method6922(string 1, 173 2, 235 3)
	{
		if (Enum.IsDefined(typeof(235), 3))
		{
			2.WritePropertyName(5);
			2.WriteValue(150.Method4160(3));
			return;
		}
		IEnumerator<235> enumerator = (from 1 in 83.Method5803<235>(3)
		where 1 > 235.None
		select 1).GetEnumerator();
		if (!enumerator.MoveNext())
		{
			return;
		}
		2.WritePropertyName(5);
		235 4 = enumerator.Current;
		if (enumerator.MoveNext())
		{
			2.WriteStartArray();
			2.WriteValue(150.Method4160(4));
			do
			{
				2.WriteValue(150.Method4160(enumerator.Current));
			}
			while (enumerator.MoveNext());
			2.WriteEndArray();
			return;
		}
		2.WriteValue(150.Method4160(4));
	}

	// Token: 0x06000899 RID: 2201 RVA: 0x0001D6B1 File Offset: 0x0001B8B1
	private void Method6923(173 1, string 2, object 3)
	{
		if (3 != null)
		{
			1.WritePropertyName(2);
			1.WriteValue(3);
		}
	}

	// Token: 0x040004C3 RID: 1219
	private readonly 173 jsonWriter2;

	// Token: 0x040004C4 RID: 1220
	private readonly 744 _recoveredType21665502;

	// Token: 0x020000FF RID: 255
	[Serializable]
	public sealed class 544
	{
		// Token: 0x0600089A RID: 2202 RVA: 0x0001D6C4 File Offset: 0x0001B8C4
		internal bool Method6917(235 1)
		{
			return 1 > 235.None;
		}

		// Token: 0x040004C5 RID: 1221
		public static readonly 543.544 instance = new 543.544();

		// Token: 0x040004C6 RID: 1222
		public static Func<235, bool> func;
	}
}
