using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;

// Token: 0x02000150 RID: 336
[ComVisible(false)]
public sealed class 529
{
	// Token: 0x06000B61 RID: 2913 RVA: 0x0002A68C File Offset: 0x0002888C
	public 529()
	{
		this.SetFlag5117_6423(true);
		this.SetFlag5112_6413(true);
	}

	// Token: 0x06000B62 RID: 2914 RVA: 0x0002A6C5 File Offset: 0x000288C5
	public string GetText5091_6370()
	{
		return this.text2;
	}

	// Token: 0x06000B63 RID: 2915 RVA: 0x0002A6CD File Offset: 0x000288CD
	public void SetText5091_6371(string 1)
	{
		this.text2 = 1;
	}

	// Token: 0x06000B64 RID: 2916 RVA: 0x0002A6D6 File Offset: 0x000288D6
	public string GetText5092_6372()
	{
		return this.text3;
	}

	// Token: 0x06000B65 RID: 2917 RVA: 0x0002A6DE File Offset: 0x000288DE
	public void SetText5092_6373(string 1)
	{
		this.text3 = 1;
	}

	// Token: 0x06000B66 RID: 2918 RVA: 0x0002A6E7 File Offset: 0x000288E7
	public bool? GetNullable5093_6374()
	{
		return this.nullable2;
	}

	// Token: 0x06000B67 RID: 2919 RVA: 0x0002A6EF File Offset: 0x000288EF
	public void SetNullable5093_6375(bool? 1)
	{
		this.nullable2 = 1;
	}

	// Token: 0x06000B68 RID: 2920 RVA: 0x0002A6F8 File Offset: 0x000288F8
	public bool? GetNullable5094_6376()
	{
		return this.nullable3;
	}

	// Token: 0x06000B69 RID: 2921 RVA: 0x0002A700 File Offset: 0x00028900
	public void SetNullable5094_6377(bool? 1)
	{
		this.nullable3 = 1;
	}

	// Token: 0x06000B6A RID: 2922 RVA: 0x0002A709 File Offset: 0x00028909
	public bool? GetNullable5095_6378()
	{
		return this.nullable4;
	}

	// Token: 0x06000B6B RID: 2923 RVA: 0x0002A711 File Offset: 0x00028911
	public void SetNullable5095_6379(bool? 1)
	{
		this.nullable4 = 1;
	}

	// Token: 0x06000B6C RID: 2924 RVA: 0x0002A71A File Offset: 0x0002891A
	public bool? GetNullable5096_6380()
	{
		return this.nullable5;
	}

	// Token: 0x06000B6D RID: 2925 RVA: 0x0002A722 File Offset: 0x00028922
	public void SetNullable5096_6381(bool? 1)
	{
		this.nullable5 = 1;
	}

	// Token: 0x06000B6E RID: 2926 RVA: 0x0002A72B File Offset: 0x0002892B
	public string GetText5097_6382()
	{
		return this.text4;
	}

	// Token: 0x06000B6F RID: 2927 RVA: 0x0002A733 File Offset: 0x00028933
	public void SetText5097_6383(string 1)
	{
		this.text4 = 1;
	}

	// Token: 0x06000B70 RID: 2928 RVA: 0x0002A73C File Offset: 0x0002893C
	public 235? GetNullable5098_6384()
	{
		return this.nullable6;
	}

	// Token: 0x06000B71 RID: 2929 RVA: 0x0002A744 File Offset: 0x00028944
	public void SetNullable5098_6385(235? 1)
	{
		this.nullable6 = 1;
	}

	// Token: 0x06000B72 RID: 2930 RVA: 0x0002A74D File Offset: 0x0002894D
	public string GetText5099_6386()
	{
		return this.text5;
	}

	// Token: 0x06000B73 RID: 2931 RVA: 0x0002A755 File Offset: 0x00028955
	public void SetText5099_6387(string 1)
	{
		this.text5 = 1;
	}

	// Token: 0x06000B74 RID: 2932 RVA: 0x0002A75E File Offset: 0x0002895E
	public int? GetNullable5100_6388()
	{
		return this.nullable7;
	}

	// Token: 0x06000B75 RID: 2933 RVA: 0x0002A766 File Offset: 0x00028966
	public void SetNullable5100_6389(int? 1)
	{
		this.nullable7 = 1;
	}

	// Token: 0x06000B76 RID: 2934 RVA: 0x0002A76F File Offset: 0x0002896F
	public int? GetNullable5101_6390()
	{
		return this.nullable8;
	}

	// Token: 0x06000B77 RID: 2935 RVA: 0x0002A777 File Offset: 0x00028977
	public void SetNullable5101_6391(int? 1)
	{
		this.nullable8 = 1;
	}

	// Token: 0x06000B78 RID: 2936 RVA: 0x0002A780 File Offset: 0x00028980
	public double? GetNullable5102_6392()
	{
		return this.nullable9;
	}

	// Token: 0x06000B79 RID: 2937 RVA: 0x0002A788 File Offset: 0x00028988
	public void SetNullable5102_6393(double? 1)
	{
		this.nullable9 = 1;
	}

	// Token: 0x06000B7A RID: 2938 RVA: 0x0002A791 File Offset: 0x00028991
	public double? GetNullable5103_6394()
	{
		return this.nullable10;
	}

	// Token: 0x06000B7B RID: 2939 RVA: 0x0002A799 File Offset: 0x00028999
	public void SetNullable5103_6395(double? 1)
	{
		this.nullable10 = 1;
	}

	// Token: 0x06000B7C RID: 2940 RVA: 0x0002A7A2 File Offset: 0x000289A2
	public double? GetNullable5104_6396()
	{
		return this.nullable11;
	}

	// Token: 0x06000B7D RID: 2941 RVA: 0x0002A7AA File Offset: 0x000289AA
	public void SetNullable5104_6397(double? 1)
	{
		this.nullable11 = 1;
	}

	// Token: 0x06000B7E RID: 2942 RVA: 0x0002A7B3 File Offset: 0x000289B3
	public bool? GetNullable5105_6398()
	{
		return this.nullable12;
	}

	// Token: 0x06000B7F RID: 2943 RVA: 0x0002A7BB File Offset: 0x000289BB
	public void SetNullable5105_6399(bool? 1)
	{
		this.nullable12 = 1;
	}

	// Token: 0x06000B80 RID: 2944 RVA: 0x0002A7C4 File Offset: 0x000289C4
	public bool? GetNullable5106_6400()
	{
		return this.nullable13;
	}

	// Token: 0x06000B81 RID: 2945 RVA: 0x0002A7CC File Offset: 0x000289CC
	public void SetNullable5106_6401(bool? 1)
	{
		this.nullable13 = 1;
	}

	// Token: 0x06000B82 RID: 2946 RVA: 0x0002A7D5 File Offset: 0x000289D5
	public int? GetNullable5107_6402()
	{
		return this.nullable14;
	}

	// Token: 0x06000B83 RID: 2947 RVA: 0x0002A7DD File Offset: 0x000289DD
	public void SetNullable5107_6403(int? 1)
	{
		this.nullable14 = 1;
	}

	// Token: 0x06000B84 RID: 2948 RVA: 0x0002A7E6 File Offset: 0x000289E6
	public int? GetNullable5108_6404()
	{
		return this.nullable15;
	}

	// Token: 0x06000B85 RID: 2949 RVA: 0x0002A7EE File Offset: 0x000289EE
	public void SetNullable5108_6405(int? 1)
	{
		this.nullable15 = 1;
	}

	// Token: 0x06000B86 RID: 2950 RVA: 0x0002A7F7 File Offset: 0x000289F7
	public IList<529> GetIList5109_6406()
	{
		return this.iList2;
	}

	// Token: 0x06000B87 RID: 2951 RVA: 0x0002A7FF File Offset: 0x000289FF
	public void SetIList5109_6407(IList<529> 1)
	{
		this.iList2 = 1;
	}

	// Token: 0x06000B88 RID: 2952 RVA: 0x0002A808 File Offset: 0x00028A08
	public bool GetFlag5110_6408()
	{
		return this.flag2;
	}

	// Token: 0x06000B89 RID: 2953 RVA: 0x0002A810 File Offset: 0x00028A10
	public void SetFlag5110_6409(bool 1)
	{
		this.flag2 = 1;
	}

	// Token: 0x06000B8A RID: 2954 RVA: 0x0002A819 File Offset: 0x00028A19
	public 529 GetRecoveredType11435111_6410()
	{
		return this._recoveredType11435111;
	}

	// Token: 0x06000B8B RID: 2955 RVA: 0x0002A821 File Offset: 0x00028A21
	public void SetRecoveredType11435111_6411(529 1)
	{
		this._recoveredType11435111 = 1;
	}

	// Token: 0x06000B8C RID: 2956 RVA: 0x0002A82A File Offset: 0x00028A2A
	public bool GetFlag5112_6412()
	{
		return this.flag3;
	}

	// Token: 0x06000B8D RID: 2957 RVA: 0x0002A832 File Offset: 0x00028A32
	public void SetFlag5112_6413(bool 1)
	{
		this.flag3 = 1;
	}

	// Token: 0x06000B8E RID: 2958 RVA: 0x0002A83B File Offset: 0x00028A3B
	public bool GetFlag5113_6414()
	{
		return this.flag4;
	}

	// Token: 0x06000B8F RID: 2959 RVA: 0x0002A843 File Offset: 0x00028A43
	public void SetFlag5113_6415(bool 1)
	{
		this.flag4 = 1;
	}

	// Token: 0x06000B90 RID: 2960 RVA: 0x0002A84C File Offset: 0x00028A4C
	public IDictionary<string, 529> GetIDictionary5114_6416()
	{
		return this.iDictionary2;
	}

	// Token: 0x06000B91 RID: 2961 RVA: 0x0002A854 File Offset: 0x00028A54
	public void SetIDictionary5114_6417(IDictionary<string, 529> 1)
	{
		this.iDictionary2 = 1;
	}

	// Token: 0x06000B92 RID: 2962 RVA: 0x0002A85D File Offset: 0x00028A5D
	public 529 GetRecoveredType11435115_6418()
	{
		return this._recoveredType11435115;
	}

	// Token: 0x06000B93 RID: 2963 RVA: 0x0002A865 File Offset: 0x00028A65
	public void SetRecoveredType11435115_6419(529 1)
	{
		this._recoveredType11435115 = 1;
	}

	// Token: 0x06000B94 RID: 2964 RVA: 0x0002A86E File Offset: 0x00028A6E
	public IDictionary<string, 529> GetIDictionary5116_6420()
	{
		return this.iDictionary3;
	}

	// Token: 0x06000B95 RID: 2965 RVA: 0x0002A876 File Offset: 0x00028A76
	public void SetIDictionary5116_6421(IDictionary<string, 529> 1)
	{
		this.iDictionary3 = 1;
	}

	// Token: 0x06000B96 RID: 2966 RVA: 0x0002A87F File Offset: 0x00028A7F
	public bool GetFlag5117_6422()
	{
		return this.flag5;
	}

	// Token: 0x06000B97 RID: 2967 RVA: 0x0002A887 File Offset: 0x00028A87
	public void SetFlag5117_6423(bool 1)
	{
		this.flag5 = 1;
	}

	// Token: 0x06000B98 RID: 2968 RVA: 0x0002A890 File Offset: 0x00028A90
	public string GetText5118_6424()
	{
		return this.text6;
	}

	// Token: 0x06000B99 RID: 2969 RVA: 0x0002A898 File Offset: 0x00028A98
	public void SetText5118_6425(string 1)
	{
		this.text6 = 1;
	}

	// Token: 0x06000B9A RID: 2970 RVA: 0x0002A8A1 File Offset: 0x00028AA1
	public IList<226> GetIList5119_6426()
	{
		return this.iList3;
	}

	// Token: 0x06000B9B RID: 2971 RVA: 0x0002A8A9 File Offset: 0x00028AA9
	public void SetIList5119_6427(IList<226> 1)
	{
		this.iList3 = 1;
	}

	// Token: 0x06000B9C RID: 2972 RVA: 0x0002A8B2 File Offset: 0x00028AB2
	public 235? GetNullable5120_6428()
	{
		return this.nullable16;
	}

	// Token: 0x06000B9D RID: 2973 RVA: 0x0002A8BA File Offset: 0x00028ABA
	public void SetNullable5120_6429(235? 1)
	{
		this.nullable16 = 1;
	}

	// Token: 0x06000B9E RID: 2974 RVA: 0x0002A8C3 File Offset: 0x00028AC3
	public 226 GetJToken5121_6430()
	{
		return this.jToken2;
	}

	// Token: 0x06000B9F RID: 2975 RVA: 0x0002A8CB File Offset: 0x00028ACB
	public void SetJToken5121_6431(226 1)
	{
		this.jToken2 = 1;
	}

	// Token: 0x06000BA0 RID: 2976 RVA: 0x0002A8D4 File Offset: 0x00028AD4
	public IList<529> GetIList5122_6432()
	{
		return this.iList4;
	}

	// Token: 0x06000BA1 RID: 2977 RVA: 0x0002A8DC File Offset: 0x00028ADC
	public void SetIList5122_6433(IList<529> 1)
	{
		this.iList4 = 1;
	}

	// Token: 0x06000BA2 RID: 2978 RVA: 0x0002A8E5 File Offset: 0x00028AE5
	public string GetText5123_6434()
	{
		return this.text7;
	}

	// Token: 0x06000BA3 RID: 2979 RVA: 0x0002A8ED File Offset: 0x00028AED
	public void SetText5123_6435(string 1)
	{
		this.text7 = 1;
	}

	// Token: 0x06000BA4 RID: 2980 RVA: 0x0002A8F6 File Offset: 0x00028AF6
	internal string GetText5124_6436()
	{
		return this.text8;
	}

	// Token: 0x06000BA5 RID: 2981 RVA: 0x0002A8FE File Offset: 0x00028AFE
	internal void SetText5124_6437(string 1)
	{
		this.text8 = 1;
	}

	// Token: 0x06000BA6 RID: 2982 RVA: 0x0002A907 File Offset: 0x00028B07
	internal string GetText5125_6438()
	{
		return this.text9;
	}

	// Token: 0x06000BA7 RID: 2983 RVA: 0x0002A90F File Offset: 0x00028B0F
	internal string GetText5126_6439()
	{
		return this.text10;
	}

	// Token: 0x06000BA8 RID: 2984 RVA: 0x0002A917 File Offset: 0x00028B17
	internal void SetText5126_6440(string 1)
	{
		this.text10 = 1;
	}

	// Token: 0x06000BA9 RID: 2985 RVA: 0x0002A920 File Offset: 0x00028B20
	internal bool GetFlag5127_6441()
	{
		return this.flag6;
	}

	// Token: 0x06000BAA RID: 2986 RVA: 0x0002A928 File Offset: 0x00028B28
	internal void SetFlag5127_6442(bool 1)
	{
		this.flag6 = 1;
	}

	// Token: 0x06000BAB RID: 2987 RVA: 0x0002A931 File Offset: 0x00028B31
	public static 529 Method6443(139 1)
	{
		return 529.Method6443(1, new 744());
	}

	// Token: 0x06000BAC RID: 2988 RVA: 0x0002A93E File Offset: 0x00028B3E
	public static 529 Method6443(139 1, 744 2)
	{
		756.Method12216(1, "reader");
		756.Method12216(2, "resolver");
		return new 150(2).Read(1);
	}

	// Token: 0x06000BAD RID: 2989 RVA: 0x0002A962 File Offset: 0x00028B62
	public static 529 Method6445(string 1)
	{
		return 529.Method6445(1, new 744());
	}

	// Token: 0x06000BAE RID: 2990 RVA: 0x0002A970 File Offset: 0x00028B70
	public static 529 Method6445(string 1, 744 2)
	{
		756.Method12216(1, "json");
		139 3 = new 167(new StringReader(1));
		529 result;
		try
		{
			result = 529.Method6443(3, 2);
		}
		finally
		{
			((IDisposable)3).Dispose();
		}
		return result;
	}

	// Token: 0x06000BAF RID: 2991 RVA: 0x0002A9B8 File Offset: 0x00028BB8
	public void Method6447(173 1)
	{
		this.Method6447(1, new 744());
	}

	// Token: 0x06000BB0 RID: 2992 RVA: 0x0002A9C6 File Offset: 0x00028BC6
	public void Method6447(173 1, 744 2)
	{
		756.Method12216(1, "writer");
		756.Method12216(2, "resolver");
		new 543(1, 2).Method6919(this);
	}

	// Token: 0x06000BB1 RID: 2993 RVA: 0x0002A9EC File Offset: 0x00028BEC
	public override string ToString()
	{
		StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture);
		168 <<EMPTY_NAME>> = new 168(stringWriter);
		<<EMPTY_NAME>>.SetFormatting((95)1);
		this.Method6447(<<EMPTY_NAME>>);
		return stringWriter.ToString();
	}

	// Token: 0x040005A1 RID: 1441
	private string text2;

	// Token: 0x040005A2 RID: 1442
	private string text3;

	// Token: 0x040005A3 RID: 1443
	private bool? nullable2;

	// Token: 0x040005A4 RID: 1444
	private bool? nullable3;

	// Token: 0x040005A5 RID: 1445
	private bool? nullable4;

	// Token: 0x040005A6 RID: 1446
	private bool? nullable5;

	// Token: 0x040005A7 RID: 1447
	private string text4;

	// Token: 0x040005A8 RID: 1448
	private 235? nullable6;

	// Token: 0x040005A9 RID: 1449
	private string text5;

	// Token: 0x040005AA RID: 1450
	private int? nullable7;

	// Token: 0x040005AB RID: 1451
	private int? nullable8;

	// Token: 0x040005AC RID: 1452
	private double? nullable9;

	// Token: 0x040005AD RID: 1453
	private double? nullable10;

	// Token: 0x040005AE RID: 1454
	private double? nullable11;

	// Token: 0x040005AF RID: 1455
	private bool? nullable12;

	// Token: 0x040005B0 RID: 1456
	private bool? nullable13;

	// Token: 0x040005B1 RID: 1457
	private int? nullable14;

	// Token: 0x040005B2 RID: 1458
	private int? nullable15;

	// Token: 0x040005B3 RID: 1459
	private IList<529> iList2;

	// Token: 0x040005B4 RID: 1460
	private bool flag2;

	// Token: 0x040005B5 RID: 1461
	private 529 _recoveredType11435111;

	// Token: 0x040005B6 RID: 1462
	private bool flag3;

	// Token: 0x040005B7 RID: 1463
	private bool flag4;

	// Token: 0x040005B8 RID: 1464
	private IDictionary<string, 529> iDictionary2;

	// Token: 0x040005B9 RID: 1465
	private 529 _recoveredType11435115;

	// Token: 0x040005BA RID: 1466
	private IDictionary<string, 529> iDictionary3;

	// Token: 0x040005BB RID: 1467
	private bool flag5;

	// Token: 0x040005BC RID: 1468
	private string text6;

	// Token: 0x040005BD RID: 1469
	private IList<226> iList3;

	// Token: 0x040005BE RID: 1470
	private 235? nullable16;

	// Token: 0x040005BF RID: 1471
	private 226 jToken2;

	// Token: 0x040005C0 RID: 1472
	private IList<529> iList4;

	// Token: 0x040005C1 RID: 1473
	private string text7;

	// Token: 0x040005C2 RID: 1474
	private string text8;

	// Token: 0x040005C3 RID: 1475
	private readonly string text9 = Guid.NewGuid().ToString("N");

	// Token: 0x040005C4 RID: 1476
	private string text10;

	// Token: 0x040005C5 RID: 1477
	private bool flag6;
}
