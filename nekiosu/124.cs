using System;
using System.Globalization;
using System.Numerics;
using System.Runtime.InteropServices;

// Token: 0x020000EE RID: 238
[ComVisible(false)]
[241(0)]
[242(2)]
public sealed class 124 : 173
{
	// Token: 0x06000829 RID: 2089 RVA: 0x0001C160 File Offset: 0x0001A360
	[242(1)]
	public 124(111 1)
	{
		756.Method12216(1, "container");
		this.jContainer2 = 1;
		this.jContainer3 = 1;
	}

	// Token: 0x0600082A RID: 2090 RVA: 0x0001C181 File Offset: 0x0001A381
	public 124()
	{
	}

	// Token: 0x0600082B RID: 2091 RVA: 0x0001C189 File Offset: 0x0001A389
	public 226 GetJToken9349_11874()
	{
		return this.jToken2;
	}

	// Token: 0x0600082C RID: 2092 RVA: 0x0001C191 File Offset: 0x0001A391
	public 226 Method11875()
	{
		if (this.jContainer2 != null)
		{
			return this.jContainer2;
		}
		return this.jValue2;
	}

	// Token: 0x0600082D RID: 2093 RVA: 0x00005ADD File Offset: 0x00003CDD
	public override void Flush()
	{
	}

	// Token: 0x0600082E RID: 2094 RVA: 0x0001C1A8 File Offset: 0x0001A3A8
	public override void Close()
	{
		base.Close();
	}

	// Token: 0x0600082F RID: 2095 RVA: 0x0001C1B0 File Offset: 0x0001A3B0
	public override void WriteStartObject()
	{
		base.WriteStartObject();
		this.Method11879(new 217());
	}

	// Token: 0x06000830 RID: 2096 RVA: 0x0001C1C3 File Offset: 0x0001A3C3
	[242(1)]
	private void Method11879(111 1)
	{
		if (this.jContainer3 == null)
		{
			this.jContainer2 = 1;
		}
		else
		{
			this.jContainer3.Method7258(1);
		}
		this.jContainer3 = 1;
		this.jToken2 = 1;
	}

	// Token: 0x06000831 RID: 2097 RVA: 0x0001C1F0 File Offset: 0x0001A3F0
	private void Method11880()
	{
		this.jToken2 = this.jContainer3;
		this.jContainer3 = this.jContainer3.Parent;
		if (this.jContainer3 != null && this.jContainer3.Type == 705.Property)
		{
			this.jContainer3 = this.jContainer3.Parent;
		}
	}

	// Token: 0x06000832 RID: 2098 RVA: 0x0001C241 File Offset: 0x0001A441
	public override void WriteStartArray()
	{
		base.WriteStartArray();
		this.Method11879(new 109());
	}

	// Token: 0x06000833 RID: 2099 RVA: 0x0001C254 File Offset: 0x0001A454
	[242(1)]
	public override void WriteStartConstructor(string 1)
	{
		base.WriteStartConstructor(1);
		this.Method11879(new 110(1));
	}

	// Token: 0x06000834 RID: 2100 RVA: 0x0001C269 File Offset: 0x0001A469
	protected override void WriteEnd(216 1)
	{
		this.Method11880();
	}

	// Token: 0x06000835 RID: 2101 RVA: 0x0001C271 File Offset: 0x0001A471
	[242(1)]
	public override void WritePropertyName(string 1)
	{
		217 2 = this.jContainer3 as 217;
		if (2 != null)
		{
			2.Remove(1);
		}
		this.Method11879(new 222(1));
		base.WritePropertyName(1);
	}

	// Token: 0x06000836 RID: 2102 RVA: 0x0001C29E File Offset: 0x0001A49E
	private void Method11885(object 1, 705 2, 216 3)
	{
		this.Method11886(new 233(1, 2), 3);
	}

	// Token: 0x06000837 RID: 2103 RVA: 0x0001C2B0 File Offset: 0x0001A4B0
	internal void Method11886(233 1, 216 2)
	{
		if (this.jContainer3 != null)
		{
			if (this.jContainer3.Method7257(1))
			{
				this.jToken2 = this.jContainer3.Last;
				if (this.jContainer3.Type == 705.Property)
				{
					this.jContainer3 = this.jContainer3.Parent;
					return;
				}
			}
		}
		else
		{
			this.jValue2 = (1 ?? 233.CreateNull());
			this.jToken2 = this.jValue2;
		}
	}

	// Token: 0x06000838 RID: 2104 RVA: 0x0001C320 File Offset: 0x0001A520
	public override void WriteValue(object 1)
	{
		if (1 is BigInteger)
		{
			base.Method7425(216.Integer);
			this.Method11885(1, 705.Integer, 216.Integer);
			return;
		}
		base.WriteValue(1);
	}

	// Token: 0x06000839 RID: 2105 RVA: 0x0001C342 File Offset: 0x0001A542
	public override void WriteNull()
	{
		base.WriteNull();
		this.Method11886(233.CreateNull(), 216.Null);
	}

	// Token: 0x0600083A RID: 2106 RVA: 0x0001C357 File Offset: 0x0001A557
	public override void WriteUndefined()
	{
		base.WriteUndefined();
		this.Method11886(233.CreateUndefined(), 216.Undefined);
	}

	// Token: 0x0600083B RID: 2107 RVA: 0x0001C36C File Offset: 0x0001A56C
	public override void WriteRaw(string 1)
	{
		base.WriteRaw(1);
		this.Method11886(new 225(1), 216.Raw);
	}

	// Token: 0x0600083C RID: 2108 RVA: 0x0001C382 File Offset: 0x0001A582
	public override void WriteComment(string 1)
	{
		base.WriteComment(1);
		this.Method11886(233.CreateComment(1), 216.Comment);
	}

	// Token: 0x0600083D RID: 2109 RVA: 0x0001C398 File Offset: 0x0001A598
	public override void WriteValue(string 1)
	{
		if (1 == null)
		{
			this.WriteNull();
			return;
		}
		base.WriteValue(1);
		this.Method11886(new 233(1), 216.String);
	}

	// Token: 0x0600083E RID: 2110 RVA: 0x0001C3B9 File Offset: 0x0001A5B9
	public override void WriteValue(int 1)
	{
		base.WriteValue(1);
		this.Method11885(1, 705.Integer, 216.Integer);
	}

	// Token: 0x0600083F RID: 2111 RVA: 0x0001C3D0 File Offset: 0x0001A5D0
	[CLSCompliant(false)]
	public override void WriteValue(uint 1)
	{
		base.WriteValue(1);
		this.Method11885(1, 705.Integer, 216.Integer);
	}

	// Token: 0x06000840 RID: 2112 RVA: 0x0001C3E7 File Offset: 0x0001A5E7
	public override void WriteValue(long 1)
	{
		base.WriteValue(1);
		this.Method11886(new 233(1), 216.Integer);
	}

	// Token: 0x06000841 RID: 2113 RVA: 0x0001C3FD File Offset: 0x0001A5FD
	[CLSCompliant(false)]
	public override void WriteValue(ulong 1)
	{
		base.WriteValue(1);
		this.Method11886(new 233(1), 216.Integer);
	}

	// Token: 0x06000842 RID: 2114 RVA: 0x0001C413 File Offset: 0x0001A613
	public override void WriteValue(float 1)
	{
		base.WriteValue(1);
		this.Method11886(new 233(1), 216.Float);
	}

	// Token: 0x06000843 RID: 2115 RVA: 0x0001C429 File Offset: 0x0001A629
	public override void WriteValue(double 1)
	{
		base.WriteValue(1);
		this.Method11886(new 233(1), 216.Float);
	}

	// Token: 0x06000844 RID: 2116 RVA: 0x0001C43F File Offset: 0x0001A63F
	public override void WriteValue(bool 1)
	{
		base.WriteValue(1);
		this.Method11886(new 233(1), 216.Boolean);
	}

	// Token: 0x06000845 RID: 2117 RVA: 0x0001C456 File Offset: 0x0001A656
	public override void WriteValue(short 1)
	{
		base.WriteValue(1);
		this.Method11885(1, 705.Integer, 216.Integer);
	}

	// Token: 0x06000846 RID: 2118 RVA: 0x0001C46D File Offset: 0x0001A66D
	[CLSCompliant(false)]
	public override void WriteValue(ushort 1)
	{
		base.WriteValue(1);
		this.Method11885(1, 705.Integer, 216.Integer);
	}

	// Token: 0x06000847 RID: 2119 RVA: 0x0001C484 File Offset: 0x0001A684
	public override void WriteValue(char 1)
	{
		base.WriteValue(1);
		string 2 = 1.ToString(CultureInfo.InvariantCulture);
		this.Method11886(new 233(2), 216.String);
	}

	// Token: 0x06000848 RID: 2120 RVA: 0x0001C4B3 File Offset: 0x0001A6B3
	public override void WriteValue(byte 1)
	{
		base.WriteValue(1);
		this.Method11885(1, 705.Integer, 216.Integer);
	}

	// Token: 0x06000849 RID: 2121 RVA: 0x0001C4CA File Offset: 0x0001A6CA
	[CLSCompliant(false)]
	public override void WriteValue(sbyte 1)
	{
		base.WriteValue(1);
		this.Method11885(1, 705.Integer, 216.Integer);
	}

	// Token: 0x0600084A RID: 2122 RVA: 0x0001C4E1 File Offset: 0x0001A6E1
	public override void WriteValue(decimal 1)
	{
		base.WriteValue(1);
		this.Method11886(new 233(1), 216.Float);
	}

	// Token: 0x0600084B RID: 2123 RVA: 0x0001C4F7 File Offset: 0x0001A6F7
	public override void WriteValue(DateTime 1)
	{
		base.WriteValue(1);
		1 = 382.Method2108(1, base.GetDateTimeZoneHandling());
		this.Method11886(new 233(1), 216.Date);
	}

	// Token: 0x0600084C RID: 2124 RVA: 0x0001C51C File Offset: 0x0001A71C
	public override void WriteValue(DateTimeOffset 1)
	{
		base.WriteValue(1);
		this.Method11886(new 233(1), 216.Date);
	}

	// Token: 0x0600084D RID: 2125 RVA: 0x0001C533 File Offset: 0x0001A733
	public override void WriteValue(byte[] 1)
	{
		base.WriteValue(1);
		this.Method11886(new 233(1, 705.Bytes), 216.Bytes);
	}

	// Token: 0x0600084E RID: 2126 RVA: 0x0001C54C File Offset: 0x0001A74C
	public override void WriteValue(TimeSpan 1)
	{
		base.WriteValue(1);
		this.Method11886(new 233(1), 216.String);
	}

	// Token: 0x0600084F RID: 2127 RVA: 0x0001C563 File Offset: 0x0001A763
	public override void WriteValue(Guid 1)
	{
		base.WriteValue(1);
		this.Method11886(new 233(1), 216.String);
	}

	// Token: 0x06000850 RID: 2128 RVA: 0x0001C57A File Offset: 0x0001A77A
	public override void WriteValue(Uri 1)
	{
		base.WriteValue(1);
		this.Method11886(new 233(1), 216.String);
	}

	// Token: 0x06000851 RID: 2129 RVA: 0x0001C594 File Offset: 0x0001A794
	[242(1)]
	internal override void WriteToken(139 1, bool 2, bool 3, bool 4)
	{
		123 5 = 1 as 123;
		if (5 == null || !2 || !3 || !4)
		{
			base.WriteToken(1, 2, 3, 4);
			return;
		}
		if (5.GetTokenType() == 216.None && !5.Read())
		{
			return;
		}
		226 6 = 5.JToken6023.Method14299(null);
		if (this.jContainer3 != null)
		{
			this.jContainer3.Method7256(6);
			this.jToken2 = this.jContainer3.Last;
			if (this.jContainer3.Type == 705.Property)
			{
				this.jContainer3 = this.jContainer3.Parent;
				base.Method7425(216.Null);
			}
		}
		else
		{
			this.jToken2 = 6;
			if (this.jContainer2 == null && this.jValue2 == null)
			{
				this.jContainer2 = (6 as 111);
				this.jValue2 = (6 as 233);
			}
		}
		5.Skip();
	}

	// Token: 0x040004B2 RID: 1202
	private 111 jContainer2;

	// Token: 0x040004B3 RID: 1203
	private 111 jContainer3;

	// Token: 0x040004B4 RID: 1204
	private 233 jValue2;

	// Token: 0x040004B5 RID: 1205
	private 226 jToken2;
}
