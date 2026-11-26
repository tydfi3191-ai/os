using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;

// Token: 0x02000102 RID: 258
[ComVisible(false)]
[242(1)]
[241(0)]
public class 158
{
	// Token: 0x1700007D RID: 125
	// (get) Token: 0x060008A1 RID: 2209 RVA: 0x0001D6EA File Offset: 0x0001B8EA
	// (set) Token: 0x060008A2 RID: 2210 RVA: 0x0001D6F2 File Offset: 0x0001B8F2
	[241(2)]
	public virtual 548 RecoveredType12331204
	{
		[242(2)]
		get
		{
			return this.Method3854();
		}
		[242(2)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value", "Reference resolver cannot be null.");
			}
			this._recoveredType12332973 = value;
		}
	}

	// Token: 0x1700007E RID: 126
	// (get) Token: 0x060008A3 RID: 2211 RVA: 0x0001D70E File Offset: 0x0001B90E
	// (set) Token: 0x060008A4 RID: 2212 RVA: 0x0001D716 File Offset: 0x0001B916
	[241(2)]
	public virtual 665 RecoveredType17751205
	{
		[242(2)]
		get
		{
			return this._recoveredType17752969;
		}
		[242(2)]
		set
		{
			this._recoveredType17752969 = value;
		}
	}

	// Token: 0x1700007F RID: 127
	// (get) Token: 0x060008A5 RID: 2213 RVA: 0x0001D71F File Offset: 0x0001B91F
	// (set) Token: 0x060008A6 RID: 2214 RVA: 0x0001D727 File Offset: 0x0001B927
	[241(2)]
	public virtual IEqualityComparer IEqualityComparer1206
	{
		[242(2)]
		get
		{
			return this.iEqualityComparer;
		}
		[242(2)]
		set
		{
			this.iEqualityComparer = value;
		}
	}

	// Token: 0x14000003 RID: 3
	// (add) Token: 0x060008A7 RID: 2215 RVA: 0x0001D730 File Offset: 0x0001B930
	// (remove) Token: 0x060008A8 RID: 2216 RVA: 0x0001D768 File Offset: 0x0001B968
	[241(new byte[]
	{
		2,
		1
	})]
	[method: 241(new byte[]
	{
		2,
		1
	})]
	[241(new byte[]
	{
		2,
		1
	})]
	public virtual event EventHandler<713> EventHandler1207;

	// Token: 0x060008A9 RID: 2217 RVA: 0x0001D7A0 File Offset: 0x0001B9A0
	public 158()
	{
		this.referenceLoopHandling2 = (894)0;
		this._recoveredType09352961 = (492)0;
		this.nullValueHandling2 = (240)0;
		this.defaultValueHandling2 = (50)0;
		this.objectCreationHandling2 = (243)0;
		this._recoveredType13962959 = (586)0;
		this._recoveredType14152965 = (593)0;
		this.typeNameHandling2 = (933)0;
		this._recoveredType10032966 = (504)0;
		this.streamingContext2 = 79.defaultContext;
		this._recoveredType20112971 = 559._recoveredType12935828;
		this.cultureInfo2 = 79.cultureInfo;
		this._recoveredType21142968 = 65.GetInstance();
	}

	// Token: 0x060008AA RID: 2218 RVA: 0x0001D820 File Offset: 0x0001BA20
	public virtual SerializationBinder Method1781()
	{
		SerializationBinder serializationBinder = this._recoveredType20112971 as SerializationBinder;
		if (serializationBinder != null)
		{
			return serializationBinder;
		}
		546 <<EMPTY_NAME>> = this._recoveredType20112971 as 546;
		if (<<EMPTY_NAME>> != null)
		{
			return <<EMPTY_NAME>>.serializationBinder2;
		}
		throw new InvalidOperationException("Cannot get SerializationBinder because an ISerializationBinder was previously set.");
	}

	// Token: 0x060008AB RID: 2219 RVA: 0x0001D85E File Offset: 0x0001BA5E
	public virtual void Method1782(SerializationBinder 1)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("#=zUkSU2UA=", "Serialization binder cannot be null.");
		}
		this._recoveredType20112971 = ((1 as 718) ?? new 546(1));
	}

	// Token: 0x060008AC RID: 2220 RVA: 0x0001D889 File Offset: 0x0001BA89
	public virtual 718 Method1783()
	{
		return this._recoveredType20112971;
	}

	// Token: 0x060008AD RID: 2221 RVA: 0x0001D891 File Offset: 0x0001BA91
	public virtual void Method1784(718 1)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("value", "Serialization binder cannot be null.");
		}
		this._recoveredType20112971 = 1;
	}

	// Token: 0x060008AE RID: 2222 RVA: 0x0001D8AD File Offset: 0x0001BAAD
	public virtual 933 Method1771()
	{
		return this.typeNameHandling2;
	}

	// Token: 0x060008AF RID: 2223 RVA: 0x0001D8B5 File Offset: 0x0001BAB5
	public virtual void Method1772(933 1)
	{
		if (1 < (933)0 || 1 > (933)4)
		{
			throw new ArgumentOutOfRangeException("value");
		}
		this.typeNameHandling2 = 1;
	}

	// Token: 0x060008B0 RID: 2224 RVA: 0x0001D8D1 File Offset: 0x0001BAD1
	public virtual FormatterAssemblyStyle Method1775()
	{
		return (FormatterAssemblyStyle)this._recoveredType19652958;
	}

	// Token: 0x060008B1 RID: 2225 RVA: 0x0001D8D9 File Offset: 0x0001BAD9
	public virtual void Method1776(FormatterAssemblyStyle 1)
	{
		if (1 < FormatterAssemblyStyle.Simple || 1 > FormatterAssemblyStyle.Full)
		{
			throw new ArgumentOutOfRangeException("#=zUkSU2UA=");
		}
		this._recoveredType19652958 = (703)1;
	}

	// Token: 0x060008B2 RID: 2226 RVA: 0x0001D8D1 File Offset: 0x0001BAD1
	public virtual 703 Method1777()
	{
		return this._recoveredType19652958;
	}

	// Token: 0x060008B3 RID: 2227 RVA: 0x0001D8F5 File Offset: 0x0001BAF5
	public virtual void Method1778(703 1)
	{
		if (1 < (703)0 || 1 > (703)1)
		{
			throw new ArgumentOutOfRangeException("value");
		}
		this._recoveredType19652958 = 1;
	}

	// Token: 0x060008B4 RID: 2228 RVA: 0x0001D911 File Offset: 0x0001BB11
	public virtual 586 Method1769()
	{
		return this._recoveredType13962959;
	}

	// Token: 0x060008B5 RID: 2229 RVA: 0x0001D919 File Offset: 0x0001BB19
	public virtual void Method1770(586 1)
	{
		if (1 < (586)0 || 1 > (586)3)
		{
			throw new ArgumentOutOfRangeException("value");
		}
		this._recoveredType13962959 = 1;
	}

	// Token: 0x060008B6 RID: 2230 RVA: 0x0001D935 File Offset: 0x0001BB35
	public virtual 894 Method1767()
	{
		return this.referenceLoopHandling2;
	}

	// Token: 0x060008B7 RID: 2231 RVA: 0x0001D93D File Offset: 0x0001BB3D
	public virtual void Method1768(894 1)
	{
		if (1 < (894)0 || 1 > (894)2)
		{
			throw new ArgumentOutOfRangeException("value");
		}
		this.referenceLoopHandling2 = 1;
	}

	// Token: 0x060008B8 RID: 2232 RVA: 0x0001D959 File Offset: 0x0001BB59
	public virtual 492 Method1761()
	{
		return this._recoveredType09352961;
	}

	// Token: 0x060008B9 RID: 2233 RVA: 0x0001D961 File Offset: 0x0001BB61
	public virtual void Method1762(492 1)
	{
		if (1 < (492)0 || 1 > (492)1)
		{
			throw new ArgumentOutOfRangeException("value");
		}
		this._recoveredType09352961 = 1;
	}

	// Token: 0x060008BA RID: 2234 RVA: 0x0001D97D File Offset: 0x0001BB7D
	public virtual 240 Method1763()
	{
		return this.nullValueHandling2;
	}

	// Token: 0x060008BB RID: 2235 RVA: 0x0001D985 File Offset: 0x0001BB85
	public virtual void Method1764(240 1)
	{
		if (1 < (240)0 || 1 > (240)1)
		{
			throw new ArgumentOutOfRangeException("value");
		}
		this.nullValueHandling2 = 1;
	}

	// Token: 0x060008BC RID: 2236 RVA: 0x0001D9A1 File Offset: 0x0001BBA1
	public virtual 50 Method1757()
	{
		return this.defaultValueHandling2;
	}

	// Token: 0x060008BD RID: 2237 RVA: 0x0001D9A9 File Offset: 0x0001BBA9
	public virtual void Method1758(50 1)
	{
		if (1 < (50)0 || 1 > (50)3)
		{
			throw new ArgumentOutOfRangeException("value");
		}
		this.defaultValueHandling2 = 1;
	}

	// Token: 0x060008BE RID: 2238 RVA: 0x0001D9C5 File Offset: 0x0001BBC5
	public virtual 243 Method1765()
	{
		return this.objectCreationHandling2;
	}

	// Token: 0x060008BF RID: 2239 RVA: 0x0001D9CD File Offset: 0x0001BBCD
	public virtual void Method1766(243 1)
	{
		if (1 < (243)0 || 1 > (243)2)
		{
			throw new ArgumentOutOfRangeException("value");
		}
		this.objectCreationHandling2 = 1;
	}

	// Token: 0x060008C0 RID: 2240 RVA: 0x0001D9E9 File Offset: 0x0001BBE9
	public virtual 593 Method1779()
	{
		return this._recoveredType14152965;
	}

	// Token: 0x060008C1 RID: 2241 RVA: 0x0001D9F1 File Offset: 0x0001BBF1
	public virtual void Method1780(593 1)
	{
		if (1 < (593)0 || 1 > (593)1)
		{
			throw new ArgumentOutOfRangeException("value");
		}
		this._recoveredType14152965 = 1;
	}

	// Token: 0x060008C2 RID: 2242 RVA: 0x0001DA0D File Offset: 0x0001BC0D
	public virtual 504 Method1773()
	{
		return this._recoveredType10032966;
	}

	// Token: 0x060008C3 RID: 2243 RVA: 0x0001DA15 File Offset: 0x0001BC15
	public virtual void Method1774(504 1)
	{
		if (1 < (504)0 || 1 > (504)2)
		{
			throw new ArgumentOutOfRangeException("value");
		}
		this._recoveredType10032966 = 1;
	}

	// Token: 0x060008C4 RID: 2244 RVA: 0x0001DA31 File Offset: 0x0001BC31
	public virtual 133 Method1756()
	{
		if (this.jsonConverterCollection == null)
		{
			this.jsonConverterCollection = new 133();
		}
		return this.jsonConverterCollection;
	}

	// Token: 0x060008C5 RID: 2245 RVA: 0x0001DA4C File Offset: 0x0001BC4C
	public virtual 733 Method1759()
	{
		return this._recoveredType21142968;
	}

	// Token: 0x060008C6 RID: 2246 RVA: 0x0001DA54 File Offset: 0x0001BC54
	public virtual void Method1760(733 1)
	{
		this._recoveredType21142968 = (1 ?? 65.GetInstance());
	}

	// Token: 0x060008C7 RID: 2247 RVA: 0x0001DA66 File Offset: 0x0001BC66
	public virtual StreamingContext Method1785()
	{
		return this.streamingContext2;
	}

	// Token: 0x060008C8 RID: 2248 RVA: 0x0001DA6E File Offset: 0x0001BC6E
	public virtual void Method1786(StreamingContext 1)
	{
		this.streamingContext2 = 1;
	}

	// Token: 0x060008C9 RID: 2249 RVA: 0x0001DA77 File Offset: 0x0001BC77
	public virtual 95 Method1787()
	{
		return this.nullable6.GetValueOrDefault();
	}

	// Token: 0x060008CA RID: 2250 RVA: 0x0001DA84 File Offset: 0x0001BC84
	public virtual void Method1788(95 1)
	{
		this.nullable6 = new 95?(1);
	}

	// Token: 0x060008CB RID: 2251 RVA: 0x0001DA92 File Offset: 0x0001BC92
	public virtual 47 Method1789()
	{
		return this.nullable7.GetValueOrDefault();
	}

	// Token: 0x060008CC RID: 2252 RVA: 0x0001DA9F File Offset: 0x0001BC9F
	public virtual void Method1790(47 1)
	{
		this.nullable7 = new 47?(1);
	}

	// Token: 0x060008CD RID: 2253 RVA: 0x0001DAAD File Offset: 0x0001BCAD
	public virtual 49 Method1791()
	{
		return this.nullable8.GetValueOrDefault((49)3);
	}

	// Token: 0x060008CE RID: 2254 RVA: 0x0001DABB File Offset: 0x0001BCBB
	public virtual void Method1792(49 1)
	{
		this.nullable8 = new 49?(1);
	}

	// Token: 0x060008CF RID: 2255 RVA: 0x0001DAC9 File Offset: 0x0001BCC9
	public virtual 48 Method1793()
	{
		return this.nullable9.GetValueOrDefault((48)1);
	}

	// Token: 0x060008D0 RID: 2256 RVA: 0x0001DAD7 File Offset: 0x0001BCD7
	public virtual void Method1794(48 1)
	{
		this.nullable9 = new 48?(1);
	}

	// Token: 0x060008D1 RID: 2257 RVA: 0x0001DAE5 File Offset: 0x0001BCE5
	public virtual 94 Method1797()
	{
		return this.nullable11.GetValueOrDefault();
	}

	// Token: 0x060008D2 RID: 2258 RVA: 0x0001DAF2 File Offset: 0x0001BCF2
	public virtual void Method1798(94 1)
	{
		this.nullable11 = new 94?(1);
	}

	// Token: 0x060008D3 RID: 2259 RVA: 0x0001DB00 File Offset: 0x0001BD00
	public virtual 93 Method1795()
	{
		return this.nullable10.GetValueOrDefault();
	}

	// Token: 0x060008D4 RID: 2260 RVA: 0x0001DB0D File Offset: 0x0001BD0D
	public virtual void Method1796(93 1)
	{
		this.nullable10 = new 93?(1);
	}

	// Token: 0x060008D5 RID: 2261 RVA: 0x0001DB1B File Offset: 0x0001BD1B
	public virtual 925 Method1799()
	{
		return this.nullable12.GetValueOrDefault();
	}

	// Token: 0x060008D6 RID: 2262 RVA: 0x0001DB28 File Offset: 0x0001BD28
	public virtual void Method1800(925 1)
	{
		this.nullable12 = new 925?(1);
	}

	// Token: 0x060008D7 RID: 2263 RVA: 0x0001DB36 File Offset: 0x0001BD36
	public virtual string Method1801()
	{
		return this.text2 ?? "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK";
	}

	// Token: 0x060008D8 RID: 2264 RVA: 0x0001DB47 File Offset: 0x0001BD47
	public virtual void Method1802(string 1)
	{
		this.text2 = 1;
		this.flag3 = true;
	}

	// Token: 0x060008D9 RID: 2265 RVA: 0x0001DB57 File Offset: 0x0001BD57
	public virtual CultureInfo Method1803()
	{
		return this.cultureInfo2 ?? 79.cultureInfo;
	}

	// Token: 0x060008DA RID: 2266 RVA: 0x0001DB68 File Offset: 0x0001BD68
	public virtual void Method1804(CultureInfo 1)
	{
		this.cultureInfo2 = 1;
	}

	// Token: 0x060008DB RID: 2267 RVA: 0x0001DB71 File Offset: 0x0001BD71
	public virtual int? Method1805()
	{
		return this.nullable13;
	}

	// Token: 0x060008DC RID: 2268 RVA: 0x0001DB7C File Offset: 0x0001BD7C
	public virtual void Method1806(int? 1)
	{
		int? num = 1;
		int num2 = 0;
		if (num.GetValueOrDefault() <= num2 & num != null)
		{
			throw new ArgumentException("Value must be positive.", "#=zUkSU2UA=");
		}
		this.nullable13 = 1;
		this.flag2 = true;
	}

	// Token: 0x060008DD RID: 2269 RVA: 0x0001DBC2 File Offset: 0x0001BDC2
	public virtual bool Method1807()
	{
		return this.nullable14.GetValueOrDefault();
	}

	// Token: 0x060008DE RID: 2270 RVA: 0x0001DBCF File Offset: 0x0001BDCF
	public virtual void Method1808(bool 1)
	{
		this.nullable14 = new bool?(1);
	}

	// Token: 0x060008DF RID: 2271 RVA: 0x0001DBDD File Offset: 0x0001BDDD
	internal bool Method3832()
	{
		return this.nullable14 != null;
	}

	// Token: 0x060008E0 RID: 2272 RVA: 0x0001DBEA File Offset: 0x0001BDEA
	public static 158 Method3833()
	{
		return new 158();
	}

	// Token: 0x060008E1 RID: 2273 RVA: 0x0001DBF4 File Offset: 0x0001BDF4
	public static 158 Method3833([241(2)] 79 1)
	{
		158 2 = 158.Method3833();
		if (1 != null)
		{
			158.Method3837(2, 1);
		}
		return 2;
	}

	// Token: 0x060008E2 RID: 2274 RVA: 0x0001DC12 File Offset: 0x0001BE12
	public static 158 Method3835()
	{
		Func<79> defaultSettings = 77.DefaultSettings;
		return 158.Method3833((defaultSettings != null) ? defaultSettings() : null);
	}

	// Token: 0x060008E3 RID: 2275 RVA: 0x0001DC2C File Offset: 0x0001BE2C
	public static 158 Method3835([241(2)] 79 1)
	{
		158 2 = 158.Method3835();
		if (1 != null)
		{
			158.Method3837(2, 1);
		}
		return 2;
	}

	// Token: 0x060008E4 RID: 2276 RVA: 0x0001DC4C File Offset: 0x0001BE4C
	private static void Method3837(158 1, 79 2)
	{
		if (!418.Method3165<214>(2.Converters))
		{
			for (int i = 0; i < 2.Converters.Count; i++)
			{
				1.Method1756().Insert(i, 2.Converters[i]);
			}
		}
		if (2.typeNameHandlingSetting != null)
		{
			1.Method1772(2.GetTypeNameHandling());
		}
		if (2.nullable21 != null)
		{
			1.Method1774(2.Method11470());
		}
		if (2.typeNameAssemblyFormatSetting != null)
		{
			1.Method1778(2.GetTypeNameAssemblyFormatValue());
		}
		if (2.missingMemberHandlingSetting != null)
		{
			1.Method1770(2.GetMissingMemberHandling());
		}
		if (2.referenceLoopHandlingSetting != null)
		{
			1.Method1768(2.GetReferenceLoopHandling());
		}
		if (2.preserveReferencesHandlingSetting != null)
		{
			1.Method1762(2.GetPreserveReferencesHandling());
		}
		if (2.objectCreationHandlingSetting != null)
		{
			1.Method1766(2.GetObjectCreationHandling());
		}
		if (2.nullValueHandlingSetting != null)
		{
			1.Method1764(2.GetNullValueHandling());
		}
		if (2.defaultValueHandlingSetting != null)
		{
			1.Method1758(2.GetDefaultValueHandling());
		}
		if (2.metadataPropertyHandlingSetting != null)
		{
			1.Method1780(2.GetMetadataPropertyHandling());
		}
		if (2.contextSetting != null)
		{
			1.Method1786(2.GetContext());
		}
		if (2.checkAdditionalContentSetting != null)
		{
			1.nullable14 = 2.checkAdditionalContentSetting;
		}
		if (2.Error != null)
		{
			1.EventHandler1207 += 2.Error;
		}
		if (2.GetContractResolver() != null)
		{
			1.Method1760(2.GetContractResolver());
		}
		if (2.GetReferenceResolverProvider() != null)
		{
			1.RecoveredType12331204 = 2.GetReferenceResolverProvider()();
		}
		if (2.GetTraceWriter() != null)
		{
			1.RecoveredType17751205 = 2.GetTraceWriter();
		}
		if (2.GetEqualityComparer() != null)
		{
			1.IEqualityComparer1206 = 2.GetEqualityComparer();
		}
		if (2.GetBinder() != null)
		{
			1.Method1784(2.GetBinder());
		}
		if (2.formattingSetting != null)
		{
			1.nullable6 = 2.formattingSetting;
		}
		if (2.dateFormatHandlingSetting != null)
		{
			1.nullable7 = 2.dateFormatHandlingSetting;
		}
		if (2.dateTimeZoneHandlingSetting != null)
		{
			1.nullable8 = 2.dateTimeZoneHandlingSetting;
		}
		if (2.dateParseHandlingSetting != null)
		{
			1.nullable9 = 2.dateParseHandlingSetting;
		}
		if (2.dateFormatStringSet)
		{
			1.text2 = 2.text;
			1.flag3 = 2.dateFormatStringSet;
		}
		if (2.floatFormatHandlingSetting != null)
		{
			1.nullable10 = 2.floatFormatHandlingSetting;
		}
		if (2.floatParseHandlingSetting != null)
		{
			1.nullable11 = 2.floatParseHandlingSetting;
		}
		if (2.stringEscapeHandlingSetting != null)
		{
			1.nullable12 = 2.stringEscapeHandlingSetting;
		}
		if (2.userCulture != null)
		{
			1.cultureInfo2 = 2.userCulture;
		}
		if (2.maxDepthSet)
		{
			1.nullable13 = 2.maxDepthSetting;
			1.flag2 = 2.maxDepthSet;
		}
	}

	// Token: 0x060008E5 RID: 2277 RVA: 0x0001DF40 File Offset: 0x0001C140
	[DebuggerStepThrough]
	public void Method3838(TextReader 1, object 2)
	{
		this.Method3838(new 167(1), 2);
	}

	// Token: 0x060008E6 RID: 2278 RVA: 0x0001DF4F File Offset: 0x0001C14F
	[DebuggerStepThrough]
	public void Method3838(139 1, object 2)
	{
		this.Method1811(1, 2);
	}

	// Token: 0x060008E7 RID: 2279 RVA: 0x0001DF5C File Offset: 0x0001C15C
	internal virtual void Method1811(139 1, object 2)
	{
		756.Method12216(1, "reader");
		756.Method12216(2, "target");
		CultureInfo 3;
		49? 4;
		48? 5;
		94? 6;
		int? 7;
		string 8;
		this.Method3846(1, out 3, out 4, out 5, out 6, out 7, out 8);
		930 9 = (this.RecoveredType17751205 != null && this.RecoveredType17751205.GetLevelFilter() >= TraceLevel.Verbose) ? this.Method3852(1) : null;
		new 161(this).Method11644(9 ?? 1, 2);
		if (9 != null)
		{
			this.RecoveredType17751205.WriteTrace(TraceLevel.Verbose, 9.Method1186(), null);
		}
		this.Method3847(1, 3, 4, 5, 6, 7, 8);
	}

	// Token: 0x060008E8 RID: 2280 RVA: 0x0001DFEE File Offset: 0x0001C1EE
	[DebuggerStepThrough]
	[return: 241(2)]
	public object Method3841(139 1)
	{
		return this.Method3841(1, null);
	}

	// Token: 0x060008E9 RID: 2281 RVA: 0x0001DFF8 File Offset: 0x0001C1F8
	[DebuggerStepThrough]
	[return: 241(2)]
	public object Method3841(TextReader 1, Type 2)
	{
		return this.Method3841(new 167(1), 2);
	}

	// Token: 0x060008EA RID: 2282 RVA: 0x0001E007 File Offset: 0x0001C207
	[DebuggerStepThrough]
	[242(2)]
	public T Method3841<T>([241(1)] 139 1)
	{
		return (T)((object)this.Method3841(1, typeof(T)));
	}

	// Token: 0x060008EB RID: 2283 RVA: 0x0001E01F File Offset: 0x0001C21F
	[DebuggerStepThrough]
	[242(2)]
	public object Method3841([241(1)] 139 1, Type 2)
	{
		return this.Method1810(1, 2);
	}

	// Token: 0x060008EC RID: 2284 RVA: 0x0001E02C File Offset: 0x0001C22C
	[242(2)]
	internal virtual object Method1810([241(1)] 139 1, Type 2)
	{
		756.Method12216(1, "reader");
		CultureInfo 3;
		49? 4;
		48? 5;
		94? 6;
		int? 7;
		string 8;
		this.Method3846(1, out 3, out 4, out 5, out 6, out 7, out 8);
		930 9 = (this.RecoveredType17751205 != null && this.RecoveredType17751205.GetLevelFilter() >= TraceLevel.Verbose) ? this.Method3852(1) : null;
		object result = new 161(this).Method11647(9 ?? 1, 2, this.Method1807());
		if (9 != null)
		{
			this.RecoveredType17751205.WriteTrace(TraceLevel.Verbose, 9.Method1186(), null);
		}
		this.Method3847(1, 3, 4, 5, 6, 7, 8);
		return result;
	}

	// Token: 0x060008ED RID: 2285 RVA: 0x0001E0BC File Offset: 0x0001C2BC
	[242(2)]
	internal void Method3846([241(1)] 139 1, out CultureInfo 2, out 49? 3, out 48? 4, out 94? 5, out int? 6, out string 7)
	{
		if (this.cultureInfo2 != null && !this.cultureInfo2.Equals(1.Culture))
		{
			2 = 1.Culture;
			1.Culture = this.cultureInfo2;
		}
		else
		{
			2 = null;
		}
		if (this.nullable8 != null)
		{
			49 dateTimeZoneHandling = 1.GetDateTimeZoneHandling();
			49? 8 = this.nullable8;
			if (!(dateTimeZoneHandling == 8.GetValueOrDefault() & 8 != null))
			{
				3 = new 49?(1.GetDateTimeZoneHandling());
				1.SetDateTimeZoneHandling(this.nullable8.GetValueOrDefault());
				goto IL_8C;
			}
		}
		3 = null;
		IL_8C:
		if (this.nullable9 != null)
		{
			48 dateParseHandling = 1.GetDateParseHandling();
			48? 9 = this.nullable9;
			if (!(dateParseHandling == 9.GetValueOrDefault() & 9 != null))
			{
				4 = new 48?(1.GetDateParseHandling());
				1.SetDateParseHandling(this.nullable9.GetValueOrDefault());
				goto IL_E6;
			}
		}
		4 = null;
		IL_E6:
		if (this.nullable11 != null)
		{
			94 floatParseHandling = 1.GetFloatParseHandling();
			94? 10 = this.nullable11;
			if (!(floatParseHandling == 10.GetValueOrDefault() & 10 != null))
			{
				5 = new 94?(1.GetFloatParseHandling());
				1.SetFloatParseHandling(this.nullable11.GetValueOrDefault());
				goto IL_141;
			}
		}
		5 = null;
		IL_141:
		if (this.flag2)
		{
			int? maxDepth = 1.GetMaxDepth();
			int? num = this.nullable13;
			if (!(maxDepth.GetValueOrDefault() == num.GetValueOrDefault() & maxDepth != null == (num != null)))
			{
				6 = 1.GetMaxDepth();
				1.SetMaxDepth(this.nullable13);
				goto IL_19F;
			}
		}
		6 = null;
		IL_19F:
		if (this.flag3 && 1.GetDateFormatString() != this.text2)
		{
			7 = 1.GetDateFormatString();
			1.SetDateFormatString(this.text2);
		}
		else
		{
			7 = null;
		}
		167 11 = 1 as 167;
		if (11 != null && 11.RecoveredType04919177 == null)
		{
			65 12 = this._recoveredType21142968 as 65;
			if (12 != null)
			{
				11.RecoveredType04919177 = 12.GetNameTable();
			}
		}
	}

	// Token: 0x060008EE RID: 2286 RVA: 0x0001E2CC File Offset: 0x0001C4CC
	[242(2)]
	private void Method3847([241(1)] 139 1, CultureInfo 2, 49? 3, 48? 4, 94? 5, int? 6, string 7)
	{
		if (2 != null)
		{
			1.Culture = 2;
		}
		if (3 != null)
		{
			1.SetDateTimeZoneHandling(3.GetValueOrDefault());
		}
		if (4 != null)
		{
			1.SetDateParseHandling(4.GetValueOrDefault());
		}
		if (5 != null)
		{
			1.SetFloatParseHandling(5.GetValueOrDefault());
		}
		if (this.flag2)
		{
			1.SetMaxDepth(6);
		}
		if (this.flag3)
		{
			1.SetDateFormatString(7);
		}
		167 8 = 1 as 167;
		if (8 != null && 8.RecoveredType04919177 != null)
		{
			65 9 = this._recoveredType21142968 as 65;
			if (9 != null && 8.RecoveredType04919177 == 9.GetNameTable())
			{
				8.RecoveredType04919177 = null;
			}
		}
	}

	// Token: 0x060008EF RID: 2287 RVA: 0x0001E37B File Offset: 0x0001C57B
	public void Method3848(TextWriter 1, [241(2)] object 2)
	{
		this.Method3848(new 168(1), 2);
	}

	// Token: 0x060008F0 RID: 2288 RVA: 0x0001E38A File Offset: 0x0001C58A
	[242(2)]
	public void Method3848([241(1)] 173 1, object 2, Type 3)
	{
		this.Method1812(1, 2, 3);
	}

	// Token: 0x060008F1 RID: 2289 RVA: 0x0001E395 File Offset: 0x0001C595
	public void Method3848(TextWriter 1, [241(2)] object 2, Type 3)
	{
		this.Method3848(new 168(1), 2, 3);
	}

	// Token: 0x060008F2 RID: 2290 RVA: 0x0001E3A5 File Offset: 0x0001C5A5
	public void Method3848(173 1, [241(2)] object 2)
	{
		this.Method1812(1, 2, null);
	}

	// Token: 0x060008F3 RID: 2291 RVA: 0x0001E3B0 File Offset: 0x0001C5B0
	private 930 Method3852(139 1)
	{
		930 2 = new 930(1);
		if (1.GetTokenType() != 216.None)
		{
			2.Method1196();
		}
		return 2;
	}

	// Token: 0x060008F4 RID: 2292 RVA: 0x0001E3D4 File Offset: 0x0001C5D4
	[242(2)]
	internal virtual void Method1812([241(1)] 173 1, object 2, Type 3)
	{
		756.Method12216(1, "jsonWriter");
		95? 4 = null;
		if (this.nullable6 != null)
		{
			95 formatting = 1.GetFormatting();
			95? 5 = this.nullable6;
			if (!(formatting == 5.GetValueOrDefault() & 5 != null))
			{
				4 = new 95?(1.GetFormatting());
				1.SetFormatting(this.nullable6.GetValueOrDefault());
			}
		}
		47? 6 = null;
		if (this.nullable7 != null)
		{
			47 dateFormatHandling = 1.GetDateFormatHandling();
			47? 7 = this.nullable7;
			if (!(dateFormatHandling == 7.GetValueOrDefault() & 7 != null))
			{
				6 = new 47?(1.GetDateFormatHandling());
				1.SetDateFormatHandling(this.nullable7.GetValueOrDefault());
			}
		}
		49? 8 = null;
		if (this.nullable8 != null)
		{
			49 dateTimeZoneHandling = 1.GetDateTimeZoneHandling();
			49? 9 = this.nullable8;
			if (!(dateTimeZoneHandling == 9.GetValueOrDefault() & 9 != null))
			{
				8 = new 49?(1.GetDateTimeZoneHandling());
				1.SetDateTimeZoneHandling(this.nullable8.GetValueOrDefault());
			}
		}
		93? 10 = null;
		if (this.nullable10 != null)
		{
			93 floatFormatHandling = 1.GetFloatFormatHandling();
			93? 11 = this.nullable10;
			if (!(floatFormatHandling == 11.GetValueOrDefault() & 11 != null))
			{
				10 = new 93?(1.GetFloatFormatHandling());
				1.SetFloatFormatHandling(this.nullable10.GetValueOrDefault());
			}
		}
		925? 12 = null;
		if (this.nullable12 != null)
		{
			925 stringEscapeHandling = 1.GetStringEscapeHandling();
			925? 13 = this.nullable12;
			if (!(stringEscapeHandling == 13.GetValueOrDefault() & 13 != null))
			{
				12 = new 925?(1.GetStringEscapeHandling());
				1.SetStringEscapeHandling(this.nullable12.GetValueOrDefault());
			}
		}
		CultureInfo cultureInfo = null;
		if (this.cultureInfo2 != null && !this.cultureInfo2.Equals(1.GetCulture()))
		{
			cultureInfo = 1.GetCulture();
			1.SetCulture(this.cultureInfo2);
		}
		string dateFormatString = null;
		if (this.flag3 && 1.DateFormatString != this.text2)
		{
			dateFormatString = 1.DateFormatString;
			1.DateFormatString = this.text2;
		}
		931 14 = (this.RecoveredType17751205 != null && this.RecoveredType17751205.GetLevelFilter() >= TraceLevel.Verbose) ? new 931(1) : null;
		new 166(this).Method12834(14 ?? 1, 2, 3);
		if (14 != null)
		{
			this.RecoveredType17751205.WriteTrace(TraceLevel.Verbose, 14.Method12021(), null);
		}
		if (4 != null)
		{
			1.SetFormatting(4.GetValueOrDefault());
		}
		if (6 != null)
		{
			1.SetDateFormatHandling(6.GetValueOrDefault());
		}
		if (8 != null)
		{
			1.SetDateTimeZoneHandling(8.GetValueOrDefault());
		}
		if (10 != null)
		{
			1.SetFloatFormatHandling(10.GetValueOrDefault());
		}
		if (12 != null)
		{
			1.SetStringEscapeHandling(12.GetValueOrDefault());
		}
		if (this.flag3)
		{
			1.DateFormatString = dateFormatString;
		}
		if (cultureInfo != null)
		{
			1.SetCulture(cultureInfo);
		}
	}

	// Token: 0x060008F5 RID: 2293 RVA: 0x0001E6CB File Offset: 0x0001C8CB
	internal 548 Method3854()
	{
		if (this._recoveredType12332973 == null)
		{
			this._recoveredType12332973 = new 738();
		}
		return this._recoveredType12332973;
	}

	// Token: 0x060008F6 RID: 2294 RVA: 0x0001E6E6 File Offset: 0x0001C8E6
	[return: 241(2)]
	internal 214 Method3855(Type 1)
	{
		return 158.Method3855(this.jsonConverterCollection, 1);
	}

	// Token: 0x060008F7 RID: 2295 RVA: 0x0001E6F4 File Offset: 0x0001C8F4
	[return: 241(2)]
	internal static 214 Method3855([241(new byte[]
	{
		2,
		1
	})] IList<214> 1, Type 2)
	{
		if (1 != null)
		{
			for (int i = 0; i < 1.Count; i++)
			{
				214 3 = 1[i];
				if (3.CanConvert(2))
				{
					return 3;
				}
			}
		}
		return null;
	}

	// Token: 0x060008F8 RID: 2296 RVA: 0x0001E729 File Offset: 0x0001C929
	internal void Method3857(713 1)
	{
		EventHandler<713> eventHandler = this.EventHandler1207;
		if (eventHandler == null)
		{
			return;
		}
		eventHandler(this, 1);
	}

	// Token: 0x040004C9 RID: 1225
	internal 933 typeNameHandling2;

	// Token: 0x040004CA RID: 1226
	internal 703 _recoveredType19652958;

	// Token: 0x040004CB RID: 1227
	internal 586 _recoveredType13962959;

	// Token: 0x040004CC RID: 1228
	internal 894 referenceLoopHandling2;

	// Token: 0x040004CD RID: 1229
	internal 492 _recoveredType09352961;

	// Token: 0x040004CE RID: 1230
	internal 243 objectCreationHandling2;

	// Token: 0x040004CF RID: 1231
	internal 240 nullValueHandling2;

	// Token: 0x040004D0 RID: 1232
	internal 50 defaultValueHandling2;

	// Token: 0x040004D1 RID: 1233
	internal 593 _recoveredType14152965;

	// Token: 0x040004D2 RID: 1234
	internal 504 _recoveredType10032966;

	// Token: 0x040004D3 RID: 1235
	[241(2)]
	internal 133 jsonConverterCollection;

	// Token: 0x040004D4 RID: 1236
	internal 733 _recoveredType21142968;

	// Token: 0x040004D5 RID: 1237
	[241(2)]
	internal 665 _recoveredType17752969;

	// Token: 0x040004D6 RID: 1238
	[241(2)]
	internal IEqualityComparer iEqualityComparer;

	// Token: 0x040004D7 RID: 1239
	internal 718 _recoveredType20112971;

	// Token: 0x040004D8 RID: 1240
	internal StreamingContext streamingContext2;

	// Token: 0x040004D9 RID: 1241
	[241(2)]
	private 548 _recoveredType12332973;

	// Token: 0x040004DA RID: 1242
	private 95? nullable6;

	// Token: 0x040004DB RID: 1243
	private 47? nullable7;

	// Token: 0x040004DC RID: 1244
	private 49? nullable8;

	// Token: 0x040004DD RID: 1245
	private 48? nullable9;

	// Token: 0x040004DE RID: 1246
	private 93? nullable10;

	// Token: 0x040004DF RID: 1247
	private 94? nullable11;

	// Token: 0x040004E0 RID: 1248
	private 925? nullable12;

	// Token: 0x040004E1 RID: 1249
	private CultureInfo cultureInfo2;

	// Token: 0x040004E2 RID: 1250
	private int? nullable13;

	// Token: 0x040004E3 RID: 1251
	private bool flag2;

	// Token: 0x040004E4 RID: 1252
	private bool? nullable14;

	// Token: 0x040004E5 RID: 1253
	[241(2)]
	private string text2;

	// Token: 0x040004E6 RID: 1254
	private bool flag3;
}
