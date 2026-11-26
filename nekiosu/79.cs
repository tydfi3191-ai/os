using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;

// Token: 0x020000A9 RID: 169
[ComVisible(false)]
[242(2)]
[241(0)]
public sealed class 79
{
	// Token: 0x17000024 RID: 36
	// (get) Token: 0x060003FE RID: 1022 RVA: 0x0000CA6B File Offset: 0x0000AC6B
	// (set) Token: 0x060003FF RID: 1023 RVA: 0x0000CA73 File Offset: 0x0000AC73
	[241(1)]
	public IList<214> Converters
	{
		[242(1)]
		get
		{
			return this.iList;
		}
		[242(1)]
		set
		{
			this.iList = value;
		}
	}

	// Token: 0x17000025 RID: 37
	// (get) Token: 0x06000400 RID: 1024 RVA: 0x0000CA7C File Offset: 0x0000AC7C
	// (set) Token: 0x06000401 RID: 1025 RVA: 0x0000CA84 File Offset: 0x0000AC84
	[241(new byte[]
	{
		2,
		1
	})]
	public EventHandler<713> Error
	{
		[return: 241(new byte[]
		{
			2,
			1
		})]
		get
		{
			return this.eventHandler;
		}
		[param: 241(new byte[]
		{
			2,
			1
		})]
		set
		{
			this.eventHandler = value;
		}
	}

	// Token: 0x17000026 RID: 38
	// (get) Token: 0x06000402 RID: 1026 RVA: 0x0000CA8D File Offset: 0x0000AC8D
	// (set) Token: 0x06000403 RID: 1027 RVA: 0x0000CA9E File Offset: 0x0000AC9E
	[241(1)]
	public string DateFormatString
	{
		[242(1)]
		get
		{
			return this.text ?? "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK";
		}
		[242(1)]
		set
		{
			this.text = value;
			this.dateFormatStringSet = true;
		}
	}

	// Token: 0x17000027 RID: 39
	// (get) Token: 0x06000404 RID: 1028 RVA: 0x0000CAAE File Offset: 0x0000ACAE
	// (set) Token: 0x06000405 RID: 1029 RVA: 0x0000CABF File Offset: 0x0000ACBF
	[241(1)]
	public CultureInfo Culture
	{
		[242(1)]
		get
		{
			return this.userCulture ?? 79.cultureInfo;
		}
		[242(1)]
		set
		{
			this.userCulture = value;
		}
	}

	// Token: 0x06000407 RID: 1031 RVA: 0x0000CADF File Offset: 0x0000ACDF
	[DebuggerStepThrough]
	public 79()
	{
		this.Converters = new List<214>();
	}

	// Token: 0x06000408 RID: 1032 RVA: 0x0000CAF4 File Offset: 0x0000ACF4
	[242(1)]
	public 79(79 1)
	{
		this.floatParseHandlingSetting = 1.floatParseHandlingSetting;
		this.floatFormatHandlingSetting = 1.floatFormatHandlingSetting;
		this.dateParseHandlingSetting = 1.dateParseHandlingSetting;
		this.dateTimeZoneHandlingSetting = 1.dateTimeZoneHandlingSetting;
		this.dateFormatHandlingSetting = 1.dateFormatHandlingSetting;
		this.formattingSetting = 1.formattingSetting;
		this.maxDepthSetting = 1.maxDepthSetting;
		this.maxDepthSet = 1.maxDepthSet;
		this.text = 1.text;
		this.dateFormatStringSet = 1.dateFormatStringSet;
		this.contextSetting = 1.contextSetting;
		this.Error = 1.Error;
		this.SetBinder(1.GetBinder());
		this.SetTraceWriter(1.GetTraceWriter());
		this.userCulture = 1.userCulture;
		this.SetReferenceResolverProvider(1.GetReferenceResolverProvider());
		this.SetEqualityComparer(1.GetEqualityComparer());
		this.SetContractResolver(1.GetContractResolver());
		this.metadataPropertyHandlingSetting = 1.metadataPropertyHandlingSetting;
		this.typeNameAssemblyFormatSetting = 1.typeNameAssemblyFormatSetting;
		this.nullable21 = 1.nullable21;
		this.typeNameHandlingSetting = 1.typeNameHandlingSetting;
		this.missingMemberHandlingSetting = 1.missingMemberHandlingSetting;
		this.Converters = 1.Converters.ToList<214>();
		this.defaultValueHandlingSetting = 1.defaultValueHandlingSetting;
		this.nullValueHandlingSetting = 1.nullValueHandlingSetting;
		this.objectCreationHandlingSetting = 1.objectCreationHandlingSetting;
		this.preserveReferencesHandlingSetting = 1.preserveReferencesHandlingSetting;
		this.referenceLoopHandlingSetting = 1.referenceLoopHandlingSetting;
		this.checkAdditionalContentSetting = 1.checkAdditionalContentSetting;
		this.stringEscapeHandlingSetting = 1.stringEscapeHandlingSetting;
	}

	// Token: 0x06000409 RID: 1033 RVA: 0x0000CC80 File Offset: 0x0000AE80
	public 894 GetReferenceLoopHandling()
	{
		return this.referenceLoopHandlingSetting.GetValueOrDefault();
	}

	// Token: 0x0600040A RID: 1034 RVA: 0x0000CC8D File Offset: 0x0000AE8D
	public void SetReferenceLoopHandling(894 1)
	{
		this.referenceLoopHandlingSetting = new 894?(1);
	}

	// Token: 0x0600040B RID: 1035 RVA: 0x0000CC9B File Offset: 0x0000AE9B
	public 492 GetPreserveReferencesHandling()
	{
		return this.preserveReferencesHandlingSetting.GetValueOrDefault();
	}

	// Token: 0x0600040C RID: 1036 RVA: 0x0000CCA8 File Offset: 0x0000AEA8
	public void SetPreserveReferencesHandling(492 1)
	{
		this.preserveReferencesHandlingSetting = new 492?(1);
	}

	// Token: 0x0600040D RID: 1037 RVA: 0x0000CCB6 File Offset: 0x0000AEB6
	public 243 GetObjectCreationHandling()
	{
		return this.objectCreationHandlingSetting.GetValueOrDefault();
	}

	// Token: 0x0600040E RID: 1038 RVA: 0x0000CCC3 File Offset: 0x0000AEC3
	public void SetObjectCreationHandling(243 1)
	{
		this.objectCreationHandlingSetting = new 243?(1);
	}

	// Token: 0x0600040F RID: 1039 RVA: 0x0000CCD1 File Offset: 0x0000AED1
	public 240 GetNullValueHandling()
	{
		return this.nullValueHandlingSetting.GetValueOrDefault();
	}

	// Token: 0x06000410 RID: 1040 RVA: 0x0000CCDE File Offset: 0x0000AEDE
	public void SetNullValueHandling(240 1)
	{
		this.nullValueHandlingSetting = new 240?(1);
	}

	// Token: 0x06000411 RID: 1041 RVA: 0x0000CCEC File Offset: 0x0000AEEC
	public 50 GetDefaultValueHandling()
	{
		return this.defaultValueHandlingSetting.GetValueOrDefault();
	}

	// Token: 0x06000412 RID: 1042 RVA: 0x0000CCF9 File Offset: 0x0000AEF9
	public void SetDefaultValueHandling(50 1)
	{
		this.defaultValueHandlingSetting = new 50?(1);
	}

	// Token: 0x06000413 RID: 1043 RVA: 0x0000CD07 File Offset: 0x0000AF07
	public 586 GetMissingMemberHandling()
	{
		return this.missingMemberHandlingSetting.GetValueOrDefault();
	}

	// Token: 0x06000414 RID: 1044 RVA: 0x0000CD14 File Offset: 0x0000AF14
	public void SetMissingMemberHandling(586 1)
	{
		this.missingMemberHandlingSetting = new 586?(1);
	}

	// Token: 0x06000415 RID: 1045 RVA: 0x0000CD22 File Offset: 0x0000AF22
	public 933 GetTypeNameHandling()
	{
		return this.typeNameHandlingSetting.GetValueOrDefault();
	}

	// Token: 0x06000416 RID: 1046 RVA: 0x0000CD2F File Offset: 0x0000AF2F
	public void SetTypeNameHandling(933 1)
	{
		this.typeNameHandlingSetting = new 933?(1);
	}

	// Token: 0x06000417 RID: 1047 RVA: 0x0000CD3D File Offset: 0x0000AF3D
	public 504 Method11470()
	{
		return this.nullable21.GetValueOrDefault();
	}

	// Token: 0x06000418 RID: 1048 RVA: 0x0000CD4A File Offset: 0x0000AF4A
	public void SetNullable9154_11471(504 1)
	{
		this.nullable21 = new 504?(1);
	}

	// Token: 0x06000419 RID: 1049 RVA: 0x0000CD58 File Offset: 0x0000AF58
	public FormatterAssemblyStyle GetTypeNameAssemblyFormat()
	{
		return (FormatterAssemblyStyle)this.GetTypeNameAssemblyFormatValue();
	}

	// Token: 0x0600041A RID: 1050 RVA: 0x0000CD60 File Offset: 0x0000AF60
	public void SetTypeNameAssemblyFormat(FormatterAssemblyStyle 1)
	{
		this.SetTypeNameAssemblyFormatValue((703)1);
	}

	// Token: 0x0600041B RID: 1051 RVA: 0x0000CD69 File Offset: 0x0000AF69
	public 703 GetTypeNameAssemblyFormatValue()
	{
		return this.typeNameAssemblyFormatSetting.GetValueOrDefault();
	}

	// Token: 0x0600041C RID: 1052 RVA: 0x0000CD76 File Offset: 0x0000AF76
	public void SetTypeNameAssemblyFormatValue(703 1)
	{
		this.typeNameAssemblyFormatSetting = new 703?(1);
	}

	// Token: 0x0600041D RID: 1053 RVA: 0x0000CD84 File Offset: 0x0000AF84
	public 593 GetMetadataPropertyHandling()
	{
		return this.metadataPropertyHandlingSetting.GetValueOrDefault();
	}

	// Token: 0x0600041E RID: 1054 RVA: 0x0000CD91 File Offset: 0x0000AF91
	public void SetMetadataPropertyHandling(593 1)
	{
		this.metadataPropertyHandlingSetting = new 593?(1);
	}

	// Token: 0x0600041F RID: 1055 RVA: 0x0000CD9F File Offset: 0x0000AF9F
	public 733 GetContractResolver()
	{
		return this.contractResolver;
	}

	// Token: 0x06000420 RID: 1056 RVA: 0x0000CDA7 File Offset: 0x0000AFA7
	public void SetContractResolver(733 1)
	{
		this.contractResolver = 1;
	}

	// Token: 0x06000421 RID: 1057 RVA: 0x0000CDB0 File Offset: 0x0000AFB0
	public IEqualityComparer GetEqualityComparer()
	{
		return this.equalityComparer;
	}

	// Token: 0x06000422 RID: 1058 RVA: 0x0000CDB8 File Offset: 0x0000AFB8
	public void SetEqualityComparer(IEqualityComparer 1)
	{
		this.equalityComparer = 1;
	}

	// Token: 0x06000423 RID: 1059 RVA: 0x0000CDC1 File Offset: 0x0000AFC1
	public 548 GetReferenceResolver()
	{
		Func<548> func = this.GetReferenceResolverProvider();
		if (func == null)
		{
			return null;
		}
		return func();
	}

	// Token: 0x06000424 RID: 1060 RVA: 0x0000CDD4 File Offset: 0x0000AFD4
	public void SetReferenceResolver(548 1)
	{
		79.80 2 = new 79.80();
		2._recoveredType12339128 = 1;
		this.SetReferenceResolverProvider((2._recoveredType12339128 != null) ? new Func<548>(2.GetRecoveredType12339128_11455) : null);
	}

	// Token: 0x06000425 RID: 1061 RVA: 0x0000CE0B File Offset: 0x0000B00B
	public Func<548> GetReferenceResolverProvider()
	{
		return this.referenceResolverProvider;
	}

	// Token: 0x06000426 RID: 1062 RVA: 0x0000CE13 File Offset: 0x0000B013
	public void SetReferenceResolverProvider(Func<548> 1)
	{
		this.referenceResolverProvider = 1;
	}

	// Token: 0x06000427 RID: 1063 RVA: 0x0000CE1C File Offset: 0x0000B01C
	public 665 GetTraceWriter()
	{
		return this.traceWriter;
	}

	// Token: 0x06000428 RID: 1064 RVA: 0x0000CE24 File Offset: 0x0000B024
	public void SetTraceWriter(665 1)
	{
		this.traceWriter = 1;
	}

	// Token: 0x06000429 RID: 1065 RVA: 0x0000CE30 File Offset: 0x0000B030
	public SerializationBinder GetSerializationBinder()
	{
		if (this.GetBinder() == null)
		{
			return null;
		}
		546 <<EMPTY_NAME>> = this.GetBinder() as 546;
		if (<<EMPTY_NAME>> != null)
		{
			return <<EMPTY_NAME>>.serializationBinder2;
		}
		throw new InvalidOperationException("Cannot get SerializationBinder because an ISerializationBinder was previously set.");
	}

	// Token: 0x0600042A RID: 1066 RVA: 0x0000CE67 File Offset: 0x0000B067
	public void SetSerializationBinder(SerializationBinder 1)
	{
		this.SetBinder((1 == null) ? null : new 546(1));
	}

	// Token: 0x0600042B RID: 1067 RVA: 0x0000CE7B File Offset: 0x0000B07B
	public 718 GetBinder()
	{
		return this.binder;
	}

	// Token: 0x0600042C RID: 1068 RVA: 0x0000CE83 File Offset: 0x0000B083
	public void SetBinder(718 1)
	{
		this.binder = 1;
	}

	// Token: 0x0600042D RID: 1069 RVA: 0x0000CE8C File Offset: 0x0000B08C
	public StreamingContext GetContext()
	{
		StreamingContext? streamingContext = this.contextSetting;
		if (streamingContext == null)
		{
			return 79.defaultContext;
		}
		return streamingContext.GetValueOrDefault();
	}

	// Token: 0x0600042E RID: 1070 RVA: 0x0000CEB6 File Offset: 0x0000B0B6
	public void SetContext(StreamingContext 1)
	{
		this.contextSetting = new StreamingContext?(1);
	}

	// Token: 0x0600042F RID: 1071 RVA: 0x0000CEC4 File Offset: 0x0000B0C4
	public int? GetMaxDepth()
	{
		if (!this.maxDepthSet)
		{
			return new int?(64);
		}
		return this.maxDepthSetting;
	}

	// Token: 0x06000430 RID: 1072 RVA: 0x0000CEDC File Offset: 0x0000B0DC
	public void SetMaxDepth(int? 1)
	{
		int? num = 1;
		int num2 = 0;
		if (num.GetValueOrDefault() <= num2 & num != null)
		{
			throw new ArgumentException("Value must be positive.", "#=zUkSU2UA=");
		}
		this.maxDepthSetting = 1;
		this.maxDepthSet = true;
	}

	// Token: 0x06000431 RID: 1073 RVA: 0x0000CF22 File Offset: 0x0000B122
	public 95 GetFormatting()
	{
		return this.formattingSetting.GetValueOrDefault();
	}

	// Token: 0x06000432 RID: 1074 RVA: 0x0000CF2F File Offset: 0x0000B12F
	public void SetFormatting(95 1)
	{
		this.formattingSetting = new 95?(1);
	}

	// Token: 0x06000433 RID: 1075 RVA: 0x0000CF3D File Offset: 0x0000B13D
	public 47 GetDateFormatHandling()
	{
		return this.dateFormatHandlingSetting.GetValueOrDefault();
	}

	// Token: 0x06000434 RID: 1076 RVA: 0x0000CF4A File Offset: 0x0000B14A
	public void SetDateFormatHandling(47 1)
	{
		this.dateFormatHandlingSetting = new 47?(1);
	}

	// Token: 0x06000435 RID: 1077 RVA: 0x0000CF58 File Offset: 0x0000B158
	public 49 GetDateTimeZoneHandling()
	{
		return this.dateTimeZoneHandlingSetting.GetValueOrDefault((49)3);
	}

	// Token: 0x06000436 RID: 1078 RVA: 0x0000CF66 File Offset: 0x0000B166
	public void SetDateTimeZoneHandling(49 1)
	{
		this.dateTimeZoneHandlingSetting = new 49?(1);
	}

	// Token: 0x06000437 RID: 1079 RVA: 0x0000CF74 File Offset: 0x0000B174
	public 48 GetDateParseHandling()
	{
		return this.dateParseHandlingSetting.GetValueOrDefault((48)1);
	}

	// Token: 0x06000438 RID: 1080 RVA: 0x0000CF82 File Offset: 0x0000B182
	public void SetDateParseHandling(48 1)
	{
		this.dateParseHandlingSetting = new 48?(1);
	}

	// Token: 0x06000439 RID: 1081 RVA: 0x0000CF90 File Offset: 0x0000B190
	public 93 GetFloatFormatHandling()
	{
		return this.floatFormatHandlingSetting.GetValueOrDefault();
	}

	// Token: 0x0600043A RID: 1082 RVA: 0x0000CF9D File Offset: 0x0000B19D
	public void SetFloatFormatHandling(93 1)
	{
		this.floatFormatHandlingSetting = new 93?(1);
	}

	// Token: 0x0600043B RID: 1083 RVA: 0x0000CFAB File Offset: 0x0000B1AB
	public 94 GetFloatParseHandling()
	{
		return this.floatParseHandlingSetting.GetValueOrDefault();
	}

	// Token: 0x0600043C RID: 1084 RVA: 0x0000CFB8 File Offset: 0x0000B1B8
	public void SetFloatParseHandling(94 1)
	{
		this.floatParseHandlingSetting = new 94?(1);
	}

	// Token: 0x0600043D RID: 1085 RVA: 0x0000CFC6 File Offset: 0x0000B1C6
	public 925 GetStringEscapeHandling()
	{
		return this.stringEscapeHandlingSetting.GetValueOrDefault();
	}

	// Token: 0x0600043E RID: 1086 RVA: 0x0000CFD3 File Offset: 0x0000B1D3
	public void SetStringEscapeHandling(925 1)
	{
		this.stringEscapeHandlingSetting = new 925?(1);
	}

	// Token: 0x0600043F RID: 1087 RVA: 0x0000CFE1 File Offset: 0x0000B1E1
	public bool GetCheckAdditionalContent()
	{
		return this.checkAdditionalContentSetting.GetValueOrDefault();
	}

	// Token: 0x06000440 RID: 1088 RVA: 0x0000CFEE File Offset: 0x0000B1EE
	public void SetCheckAdditionalContent(bool 1)
	{
		this.checkAdditionalContentSetting = new bool?(1);
	}

	// Token: 0x04000397 RID: 919
	internal static readonly StreamingContext defaultContext = default(StreamingContext);

	// Token: 0x04000398 RID: 920
	[241(1)]
	internal static readonly CultureInfo cultureInfo = CultureInfo.InvariantCulture;

	// Token: 0x04000399 RID: 921
	internal 95? formattingSetting;

	// Token: 0x0400039A RID: 922
	internal 47? dateFormatHandlingSetting;

	// Token: 0x0400039B RID: 923
	internal 49? dateTimeZoneHandlingSetting;

	// Token: 0x0400039C RID: 924
	internal 48? dateParseHandlingSetting;

	// Token: 0x0400039D RID: 925
	internal 93? floatFormatHandlingSetting;

	// Token: 0x0400039E RID: 926
	internal 94? floatParseHandlingSetting;

	// Token: 0x0400039F RID: 927
	internal 925? stringEscapeHandlingSetting;

	// Token: 0x040003A0 RID: 928
	internal CultureInfo userCulture;

	// Token: 0x040003A1 RID: 929
	internal bool? checkAdditionalContentSetting;

	// Token: 0x040003A2 RID: 930
	internal int? maxDepthSetting;

	// Token: 0x040003A3 RID: 931
	internal bool maxDepthSet;

	// Token: 0x040003A4 RID: 932
	internal string text;

	// Token: 0x040003A5 RID: 933
	internal bool dateFormatStringSet;

	// Token: 0x040003A6 RID: 934
	internal 703? typeNameAssemblyFormatSetting;

	// Token: 0x040003A7 RID: 935
	internal 50? defaultValueHandlingSetting;

	// Token: 0x040003A8 RID: 936
	internal 586? missingMemberHandlingSetting;

	// Token: 0x040003A9 RID: 937
	internal 240? nullValueHandlingSetting;

	// Token: 0x040003AA RID: 938
	internal 243? objectCreationHandlingSetting;

	// Token: 0x040003AB RID: 939
	internal 492? preserveReferencesHandlingSetting;

	// Token: 0x040003AC RID: 940
	internal 894? referenceLoopHandlingSetting;

	// Token: 0x040003AD RID: 941
	internal StreamingContext? contextSetting;

	// Token: 0x040003AE RID: 942
	internal 593? metadataPropertyHandlingSetting;

	// Token: 0x040003AF RID: 943
	internal 933? typeNameHandlingSetting;

	// Token: 0x040003B0 RID: 944
	internal 504? nullable21;

	// Token: 0x040003B1 RID: 945
	[241(1)]
	private IList<214> iList;

	// Token: 0x040003B2 RID: 946
	private 733 contractResolver;

	// Token: 0x040003B3 RID: 947
	private IEqualityComparer equalityComparer;

	// Token: 0x040003B4 RID: 948
	private Func<548> referenceResolverProvider;

	// Token: 0x040003B5 RID: 949
	private 665 traceWriter;

	// Token: 0x040003B6 RID: 950
	private 718 binder;

	// Token: 0x040003B7 RID: 951
	[241(new byte[]
	{
		2,
		1
	})]
	private EventHandler<713> eventHandler;

	// Token: 0x020000AA RID: 170
	public sealed class 80
	{
		// Token: 0x06000441 RID: 1089 RVA: 0x0000CFFC File Offset: 0x0000B1FC
		internal 548 GetRecoveredType12339128_11455()
		{
			return this._recoveredType12339128;
		}

		// Token: 0x040003B8 RID: 952
		[241(0)]
		public 548 _recoveredType12339128;
	}
}
