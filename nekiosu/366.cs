using System;
using System.Collections;
using System.Globalization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;

// Token: 0x0200010C RID: 268
[242(1)]
[241(0)]
public sealed class 366 : 158
{
	// Token: 0x17000080 RID: 128
	// (get) Token: 0x06000968 RID: 2408 RVA: 0x00023EB1 File Offset: 0x000220B1
	// (set) Token: 0x06000969 RID: 2409 RVA: 0x00023EBE File Offset: 0x000220BE
	[241(2)]
	public override 548 RecoveredType12331204
	{
		[242(2)]
		get
		{
			return this.jsonSerializer.RecoveredType12331204;
		}
		[242(2)]
		set
		{
			this.jsonSerializer.RecoveredType12331204 = value;
		}
	}

	// Token: 0x17000081 RID: 129
	// (get) Token: 0x0600096A RID: 2410 RVA: 0x00023ECC File Offset: 0x000220CC
	// (set) Token: 0x0600096B RID: 2411 RVA: 0x00023ED9 File Offset: 0x000220D9
	[241(2)]
	public override 665 RecoveredType17751205
	{
		[242(2)]
		get
		{
			return this.jsonSerializer.RecoveredType17751205;
		}
		[242(2)]
		set
		{
			this.jsonSerializer.RecoveredType17751205 = value;
		}
	}

	// Token: 0x17000082 RID: 130
	// (get) Token: 0x0600096C RID: 2412 RVA: 0x00023EE7 File Offset: 0x000220E7
	// (set) Token: 0x0600096D RID: 2413 RVA: 0x00023EF4 File Offset: 0x000220F4
	[241(2)]
	public override IEqualityComparer IEqualityComparer1206
	{
		[242(2)]
		get
		{
			return this.jsonSerializer.IEqualityComparer1206;
		}
		[242(2)]
		set
		{
			this.jsonSerializer.IEqualityComparer1206 = value;
		}
	}

	// Token: 0x14000004 RID: 4
	// (add) Token: 0x0600096E RID: 2414 RVA: 0x00023F02 File Offset: 0x00022102
	// (remove) Token: 0x0600096F RID: 2415 RVA: 0x00023F10 File Offset: 0x00022110
	[241(new byte[]
	{
		2,
		1
	})]
	public override event EventHandler<713> EventHandler1207
	{
		add
		{
			this.jsonSerializer.EventHandler1207 += value;
		}
		remove
		{
			this.jsonSerializer.EventHandler1207 -= value;
		}
	}

	// Token: 0x06000970 RID: 2416 RVA: 0x00023F1E File Offset: 0x0002211E
	public 366(161 1)
	{
		756.Method12216(1, "serializerReader");
		this.jsonSerializerInternalReader2 = 1;
		this.jsonSerializer = 1.jsonSerializer2;
	}

	// Token: 0x06000971 RID: 2417 RVA: 0x00023F44 File Offset: 0x00022144
	public 366(166 1)
	{
		756.Method12216(1, "serializerWriter");
		this.jsonSerializerInternalWriter2 = 1;
		this.jsonSerializer = 1.jsonSerializer2;
	}

	// Token: 0x06000972 RID: 2418 RVA: 0x00023F6A File Offset: 0x0002216A
	public override 133 Method1756()
	{
		return this.jsonSerializer.Method1756();
	}

	// Token: 0x06000973 RID: 2419 RVA: 0x00023F77 File Offset: 0x00022177
	public override 50 Method1757()
	{
		return this.jsonSerializer.Method1757();
	}

	// Token: 0x06000974 RID: 2420 RVA: 0x00023F84 File Offset: 0x00022184
	public override void Method1758(50 1)
	{
		this.jsonSerializer.Method1758(1);
	}

	// Token: 0x06000975 RID: 2421 RVA: 0x00023F92 File Offset: 0x00022192
	public override 733 Method1759()
	{
		return this.jsonSerializer.Method1759();
	}

	// Token: 0x06000976 RID: 2422 RVA: 0x00023F9F File Offset: 0x0002219F
	public override void Method1760(733 1)
	{
		this.jsonSerializer.Method1760(1);
	}

	// Token: 0x06000977 RID: 2423 RVA: 0x00023FAD File Offset: 0x000221AD
	public override 492 Method1761()
	{
		return this.jsonSerializer.Method1761();
	}

	// Token: 0x06000978 RID: 2424 RVA: 0x00023FBA File Offset: 0x000221BA
	public override void Method1762(492 1)
	{
		this.jsonSerializer.Method1762(1);
	}

	// Token: 0x06000979 RID: 2425 RVA: 0x00023FC8 File Offset: 0x000221C8
	public override 240 Method1763()
	{
		return this.jsonSerializer.Method1763();
	}

	// Token: 0x0600097A RID: 2426 RVA: 0x00023FD5 File Offset: 0x000221D5
	public override void Method1764(240 1)
	{
		this.jsonSerializer.Method1764(1);
	}

	// Token: 0x0600097B RID: 2427 RVA: 0x00023FE3 File Offset: 0x000221E3
	public override 243 Method1765()
	{
		return this.jsonSerializer.Method1765();
	}

	// Token: 0x0600097C RID: 2428 RVA: 0x00023FF0 File Offset: 0x000221F0
	public override void Method1766(243 1)
	{
		this.jsonSerializer.Method1766(1);
	}

	// Token: 0x0600097D RID: 2429 RVA: 0x00023FFE File Offset: 0x000221FE
	public override 894 Method1767()
	{
		return this.jsonSerializer.Method1767();
	}

	// Token: 0x0600097E RID: 2430 RVA: 0x0002400B File Offset: 0x0002220B
	public override void Method1768(894 1)
	{
		this.jsonSerializer.Method1768(1);
	}

	// Token: 0x0600097F RID: 2431 RVA: 0x00024019 File Offset: 0x00022219
	public override 586 Method1769()
	{
		return this.jsonSerializer.Method1769();
	}

	// Token: 0x06000980 RID: 2432 RVA: 0x00024026 File Offset: 0x00022226
	public override void Method1770(586 1)
	{
		this.jsonSerializer.Method1770(1);
	}

	// Token: 0x06000981 RID: 2433 RVA: 0x00024034 File Offset: 0x00022234
	public override 933 Method1771()
	{
		return this.jsonSerializer.Method1771();
	}

	// Token: 0x06000982 RID: 2434 RVA: 0x00024041 File Offset: 0x00022241
	public override void Method1772(933 1)
	{
		this.jsonSerializer.Method1772(1);
	}

	// Token: 0x06000983 RID: 2435 RVA: 0x0002404F File Offset: 0x0002224F
	public override 504 Method1773()
	{
		return this.jsonSerializer.Method1773();
	}

	// Token: 0x06000984 RID: 2436 RVA: 0x0002405C File Offset: 0x0002225C
	public override void Method1774(504 1)
	{
		this.jsonSerializer.Method1774(1);
	}

	// Token: 0x06000985 RID: 2437 RVA: 0x0002406A File Offset: 0x0002226A
	public override FormatterAssemblyStyle Method1775()
	{
		return this.jsonSerializer.Method1775();
	}

	// Token: 0x06000986 RID: 2438 RVA: 0x00024077 File Offset: 0x00022277
	public override void Method1776(FormatterAssemblyStyle 1)
	{
		this.jsonSerializer.Method1776(1);
	}

	// Token: 0x06000987 RID: 2439 RVA: 0x00024085 File Offset: 0x00022285
	public override 703 Method1777()
	{
		return this.jsonSerializer.Method1777();
	}

	// Token: 0x06000988 RID: 2440 RVA: 0x00024092 File Offset: 0x00022292
	public override void Method1778(703 1)
	{
		this.jsonSerializer.Method1778(1);
	}

	// Token: 0x06000989 RID: 2441 RVA: 0x000240A0 File Offset: 0x000222A0
	public override 593 Method1779()
	{
		return this.jsonSerializer.Method1779();
	}

	// Token: 0x0600098A RID: 2442 RVA: 0x000240AD File Offset: 0x000222AD
	public override void Method1780(593 1)
	{
		this.jsonSerializer.Method1780(1);
	}

	// Token: 0x0600098B RID: 2443 RVA: 0x000240BB File Offset: 0x000222BB
	public override SerializationBinder Method1781()
	{
		return this.jsonSerializer.Method1781();
	}

	// Token: 0x0600098C RID: 2444 RVA: 0x000240C8 File Offset: 0x000222C8
	public override void Method1782(SerializationBinder 1)
	{
		this.jsonSerializer.Method1782(1);
	}

	// Token: 0x0600098D RID: 2445 RVA: 0x000240D6 File Offset: 0x000222D6
	public override 718 Method1783()
	{
		return this.jsonSerializer.Method1783();
	}

	// Token: 0x0600098E RID: 2446 RVA: 0x000240E3 File Offset: 0x000222E3
	public override void Method1784(718 1)
	{
		this.jsonSerializer.Method1784(1);
	}

	// Token: 0x0600098F RID: 2447 RVA: 0x000240F1 File Offset: 0x000222F1
	public override StreamingContext Method1785()
	{
		return this.jsonSerializer.Method1785();
	}

	// Token: 0x06000990 RID: 2448 RVA: 0x000240FE File Offset: 0x000222FE
	public override void Method1786(StreamingContext 1)
	{
		this.jsonSerializer.Method1786(1);
	}

	// Token: 0x06000991 RID: 2449 RVA: 0x0002410C File Offset: 0x0002230C
	public override 95 Method1787()
	{
		return this.jsonSerializer.Method1787();
	}

	// Token: 0x06000992 RID: 2450 RVA: 0x00024119 File Offset: 0x00022319
	public override void Method1788(95 1)
	{
		this.jsonSerializer.Method1788(1);
	}

	// Token: 0x06000993 RID: 2451 RVA: 0x00024127 File Offset: 0x00022327
	public override 47 Method1789()
	{
		return this.jsonSerializer.Method1789();
	}

	// Token: 0x06000994 RID: 2452 RVA: 0x00024134 File Offset: 0x00022334
	public override void Method1790(47 1)
	{
		this.jsonSerializer.Method1790(1);
	}

	// Token: 0x06000995 RID: 2453 RVA: 0x00024142 File Offset: 0x00022342
	public override 49 Method1791()
	{
		return this.jsonSerializer.Method1791();
	}

	// Token: 0x06000996 RID: 2454 RVA: 0x0002414F File Offset: 0x0002234F
	public override void Method1792(49 1)
	{
		this.jsonSerializer.Method1792(1);
	}

	// Token: 0x06000997 RID: 2455 RVA: 0x0002415D File Offset: 0x0002235D
	public override 48 Method1793()
	{
		return this.jsonSerializer.Method1793();
	}

	// Token: 0x06000998 RID: 2456 RVA: 0x0002416A File Offset: 0x0002236A
	public override void Method1794(48 1)
	{
		this.jsonSerializer.Method1794(1);
	}

	// Token: 0x06000999 RID: 2457 RVA: 0x00024178 File Offset: 0x00022378
	public override 93 Method1795()
	{
		return this.jsonSerializer.Method1795();
	}

	// Token: 0x0600099A RID: 2458 RVA: 0x00024185 File Offset: 0x00022385
	public override void Method1796(93 1)
	{
		this.jsonSerializer.Method1796(1);
	}

	// Token: 0x0600099B RID: 2459 RVA: 0x00024193 File Offset: 0x00022393
	public override 94 Method1797()
	{
		return this.jsonSerializer.Method1797();
	}

	// Token: 0x0600099C RID: 2460 RVA: 0x000241A0 File Offset: 0x000223A0
	public override void Method1798(94 1)
	{
		this.jsonSerializer.Method1798(1);
	}

	// Token: 0x0600099D RID: 2461 RVA: 0x000241AE File Offset: 0x000223AE
	public override 925 Method1799()
	{
		return this.jsonSerializer.Method1799();
	}

	// Token: 0x0600099E RID: 2462 RVA: 0x000241BB File Offset: 0x000223BB
	public override void Method1800(925 1)
	{
		this.jsonSerializer.Method1800(1);
	}

	// Token: 0x0600099F RID: 2463 RVA: 0x000241C9 File Offset: 0x000223C9
	public override string Method1801()
	{
		return this.jsonSerializer.Method1801();
	}

	// Token: 0x060009A0 RID: 2464 RVA: 0x000241D6 File Offset: 0x000223D6
	public override void Method1802(string 1)
	{
		this.jsonSerializer.Method1802(1);
	}

	// Token: 0x060009A1 RID: 2465 RVA: 0x000241E4 File Offset: 0x000223E4
	public override CultureInfo Method1803()
	{
		return this.jsonSerializer.Method1803();
	}

	// Token: 0x060009A2 RID: 2466 RVA: 0x000241F1 File Offset: 0x000223F1
	public override void Method1804(CultureInfo 1)
	{
		this.jsonSerializer.Method1804(1);
	}

	// Token: 0x060009A3 RID: 2467 RVA: 0x000241FF File Offset: 0x000223FF
	public override int? Method1805()
	{
		return this.jsonSerializer.Method1805();
	}

	// Token: 0x060009A4 RID: 2468 RVA: 0x0002420C File Offset: 0x0002240C
	public override void Method1806(int? 1)
	{
		this.jsonSerializer.Method1806(1);
	}

	// Token: 0x060009A5 RID: 2469 RVA: 0x0002421A File Offset: 0x0002241A
	public override bool Method1807()
	{
		return this.jsonSerializer.Method1807();
	}

	// Token: 0x060009A6 RID: 2470 RVA: 0x00024227 File Offset: 0x00022427
	public override void Method1808(bool 1)
	{
		this.jsonSerializer.Method1808(1);
	}

	// Token: 0x060009A7 RID: 2471 RVA: 0x00024235 File Offset: 0x00022435
	internal 159 Method1809()
	{
		if (this.jsonSerializerInternalReader2 != null)
		{
			return this.jsonSerializerInternalReader2;
		}
		return this.jsonSerializerInternalWriter2;
	}

	// Token: 0x060009A8 RID: 2472 RVA: 0x0002424C File Offset: 0x0002244C
	[242(2)]
	internal override object Method1810([241(1)] 139 1, Type 2)
	{
		if (this.jsonSerializerInternalReader2 != null)
		{
			return this.jsonSerializerInternalReader2.Method11647(1, 2, false);
		}
		return this.jsonSerializer.Method3841(1, 2);
	}

	// Token: 0x060009A9 RID: 2473 RVA: 0x00024272 File Offset: 0x00022472
	internal override void Method1811(139 1, object 2)
	{
		if (this.jsonSerializerInternalReader2 != null)
		{
			this.jsonSerializerInternalReader2.Method11644(1, 2);
			return;
		}
		this.jsonSerializer.Method3838(1, 2);
	}

	// Token: 0x060009AA RID: 2474 RVA: 0x00024297 File Offset: 0x00022497
	[242(2)]
	internal override void Method1812([241(1)] 173 1, object 2, Type 3)
	{
		if (this.jsonSerializerInternalWriter2 != null)
		{
			this.jsonSerializerInternalWriter2.Method12834(1, 2, 3);
			return;
		}
		this.jsonSerializer.Method3848(1, 2);
	}

	// Token: 0x040004FF RID: 1279
	[241(2)]
	private readonly 161 jsonSerializerInternalReader2;

	// Token: 0x04000500 RID: 1280
	[241(2)]
	private readonly 166 jsonSerializerInternalWriter2;

	// Token: 0x04000501 RID: 1281
	internal readonly 158 jsonSerializer;
}
