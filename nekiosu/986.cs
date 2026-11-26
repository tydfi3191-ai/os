using System;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml;
using System.Xml.Linq;

// Token: 0x020000D0 RID: 208
[241(0)]
[ComVisible(false)]
[242(1)]
public sealed class 986 : 214
{
	// Token: 0x1700002F RID: 47
	// (get) Token: 0x0600055C RID: 1372 RVA: 0x000109FE File Offset: 0x0000EBFE
	// (set) Token: 0x0600055D RID: 1373 RVA: 0x00010A06 File Offset: 0x0000EC06
	[241(2)]
	public string Text3314
	{
		[242(2)]
		get
		{
			return this.text7;
		}
		[242(2)]
		set
		{
			this.text7 = value;
		}
	}

	// Token: 0x0600055E RID: 1374 RVA: 0x00010A0F File Offset: 0x0000EC0F
	public bool GetFlag3311_4229()
	{
		return this.flag2;
	}

	// Token: 0x0600055F RID: 1375 RVA: 0x00010A17 File Offset: 0x0000EC17
	public void SetFlag3311_4230(bool 1)
	{
		this.flag2 = 1;
	}

	// Token: 0x06000560 RID: 1376 RVA: 0x00010A20 File Offset: 0x0000EC20
	public bool GetFlag3312_4231()
	{
		return this.flag3;
	}

	// Token: 0x06000561 RID: 1377 RVA: 0x00010A28 File Offset: 0x0000EC28
	public void SetFlag3312_4232(bool 1)
	{
		this.flag3 = 1;
	}

	// Token: 0x06000562 RID: 1378 RVA: 0x00010A31 File Offset: 0x0000EC31
	public bool GetFlag3313_4233()
	{
		return this.flag4;
	}

	// Token: 0x06000563 RID: 1379 RVA: 0x00010A39 File Offset: 0x0000EC39
	public void SetFlag3313_4234(bool 1)
	{
		this.flag4 = 1;
	}

	// Token: 0x06000564 RID: 1380 RVA: 0x00010A44 File Offset: 0x0000EC44
	public override void WriteJson(173 1, [241(2)] object 2, 158 3)
	{
		if (2 == null)
		{
			1.WriteNull();
			return;
		}
		670 4 = this.Method4235(2);
		XmlNamespaceManager xmlNamespaceManager = new XmlNamespaceManager(new NameTable());
		this.Method4236(4, xmlNamespaceManager);
		if (!this.GetFlag3312_4231())
		{
			1.WriteStartObject();
		}
		this.Method4243(1, 4, xmlNamespaceManager, !this.GetFlag3312_4231());
		if (!this.GetFlag3312_4231())
		{
			1.WriteEndObject();
		}
	}

	// Token: 0x06000565 RID: 1381 RVA: 0x00010AA4 File Offset: 0x0000ECA4
	private 670 Method4235(object 1)
	{
		XObject xobject = 1 as XObject;
		if (xobject != null)
		{
			return 549.Method6996(xobject);
		}
		XmlNode xmlNode = 1 as XmlNode;
		if (xmlNode != null)
		{
			return 535.Method6756(xmlNode);
		}
		throw new ArgumentException("Value must be an XML object.", "value");
	}

	// Token: 0x06000566 RID: 1382 RVA: 0x00010AE4 File Offset: 0x0000ECE4
	private void Method4236(670 1, XmlNamespaceManager 2)
	{
		List<670> list = null;
		670 3 = 1;
		while ((3 = 3.Method13410()) != null)
		{
			if (3.GetXmlDeclaration_11618() == XmlNodeType.Element)
			{
				if (list == null)
				{
					list = new List<670>();
				}
				list.Add(3);
			}
		}
		if (list == null)
		{
			return;
		}
		list.Reverse();
		foreach (670 4 in list)
		{
			2.PushScope();
			foreach (670 5 in 4.List5353)
			{
				if (5.Method13409() == "http://www.w3.org/2000/xmlns/" && 5.Method13408() != "xmlns")
				{
					2.AddNamespace(5.Method13408(), 5.Method13406());
				}
			}
		}
	}

	// Token: 0x06000567 RID: 1383 RVA: 0x00010BD8 File Offset: 0x0000EDD8
	private string Method4237(670 1, XmlNamespaceManager 2)
	{
		string text = (1.Method13409() == null || (1.Method13408() == "xmlns" && 1.Method13409() == "http://www.w3.org/2000/xmlns/")) ? null : 2.LookupPrefix(1.Method13409());
		if (!538.Method6824(text))
		{
			return text + ":" + XmlConvert.DecodeName(1.Method13408());
		}
		return XmlConvert.DecodeName(1.Method13408());
	}

	// Token: 0x06000568 RID: 1384 RVA: 0x00010C4C File Offset: 0x0000EE4C
	private string Method4238(670 1, XmlNamespaceManager 2)
	{
		switch (1.GetXmlDeclaration_11618())
		{
		case XmlNodeType.Element:
			if (1.Method13409() == "http://james.newtonking.com/projects/json")
			{
				return "$" + 1.Method13408();
			}
			return this.Method4237(1, 2);
		case XmlNodeType.Attribute:
			if (1.Method13409() == "http://james.newtonking.com/projects/json")
			{
				return "$" + 1.Method13408();
			}
			return "@" + this.Method4237(1, 2);
		case XmlNodeType.Text:
			return "#text";
		case XmlNodeType.CDATA:
			return "#cdata-section";
		case XmlNodeType.ProcessingInstruction:
			return "?" + this.Method4237(1, 2);
		case XmlNodeType.Comment:
			return "#comment";
		case XmlNodeType.DocumentType:
			return "!" + this.Method4237(1, 2);
		case XmlNodeType.Whitespace:
			return "#whitespace";
		case XmlNodeType.SignificantWhitespace:
			return "#significant-whitespace";
		case XmlNodeType.XmlDeclaration:
			return "?xml";
		}
		throw new 364("Unexpected XmlNodeType when getting node name: " + 1.GetXmlDeclaration_11618().ToString());
	}

	// Token: 0x06000569 RID: 1385 RVA: 0x00010D80 File Offset: 0x0000EF80
	private bool Method4239(670 1)
	{
		foreach (670 2 in 1.List5353)
		{
			if (2.Method13408() == "Array" && 2.Method13409() == "http://james.newtonking.com/projects/json")
			{
				return XmlConvert.ToBoolean(2.Method13406());
			}
		}
		return false;
	}

	// Token: 0x0600056A RID: 1386 RVA: 0x00010E04 File Offset: 0x0000F004
	private void Method4240(173 1, 670 2, XmlNamespaceManager 3, bool 4)
	{
		int count = 2.List5352.Count;
		if (count == 0)
		{
			return;
		}
		if (count == 1)
		{
			string 5 = this.Method4238(2.List5352[0], 3);
			this.Method4241(1, 3, 4, 2.List5352, 5);
			return;
		}
		Dictionary<string, object> dictionary = null;
		string text = null;
		for (int i = 0; i < 2.List5352.Count; i++)
		{
			670 6 = 2.List5352[i];
			string text2 = this.Method4238(6, 3);
			object obj;
			if (dictionary == null)
			{
				if (text == null)
				{
					text = text2;
				}
				else if (!(text2 == text))
				{
					dictionary = new Dictionary<string, object>();
					if (i > 1)
					{
						List<670> list = new List<670>(i);
						for (int j = 0; j < i; j++)
						{
							list.Add(2.List5352[j]);
						}
						dictionary.Add(text, list);
					}
					else
					{
						dictionary.Add(text, 2.List5352[0]);
					}
					dictionary.Add(text2, 6);
				}
			}
			else if (!dictionary.TryGetValue(text2, out obj))
			{
				dictionary.Add(text2, 6);
			}
			else
			{
				List<670> list2 = obj as List<670>;
				if (list2 == null)
				{
					Dictionary<string, object> dictionary2 = dictionary;
					string key = text2;
					List<670> list3 = new List<670>();
					list3.Add((670)obj);
					object obj2 = list3;
					dictionary2[key] = list3;
					list2 = (List<670>)obj2;
				}
				list2.Add(6);
			}
		}
		if (dictionary == null)
		{
			this.Method4241(1, 3, 4, 2.List5352, text);
			return;
		}
		foreach (KeyValuePair<string, object> keyValuePair in dictionary)
		{
			List<670> list4 = keyValuePair.Value as List<670>;
			if (list4 != null)
			{
				this.Method4241(1, 3, 4, list4, keyValuePair.Key);
			}
			else
			{
				this.Method4241(1, 3, 4, (670)keyValuePair.Value, keyValuePair.Key);
			}
		}
	}

	// Token: 0x0600056B RID: 1387 RVA: 0x00010FF0 File Offset: 0x0000F1F0
	private void Method4241(173 1, XmlNamespaceManager 2, bool 3, List<670> 4, string 5)
	{
		if (4.Count == 1 && !this.Method4239(4[0]))
		{
			this.Method4243(1, 4[0], 2, 3);
			return;
		}
		if (3)
		{
			1.WritePropertyName(5);
		}
		1.WriteStartArray();
		for (int i = 0; i < 4.Count; i++)
		{
			this.Method4243(1, 4[i], 2, false);
		}
		1.WriteEndArray();
	}

	// Token: 0x0600056C RID: 1388 RVA: 0x00011063 File Offset: 0x0000F263
	private void Method4241(173 1, XmlNamespaceManager 2, bool 3, 670 4, string 5)
	{
		if (!this.Method4239(4))
		{
			this.Method4243(1, 4, 2, 3);
			return;
		}
		if (3)
		{
			1.WritePropertyName(5);
		}
		1.WriteStartArray();
		this.Method4243(1, 4, 2, false);
		1.WriteEndArray();
	}

	// Token: 0x0600056D RID: 1389 RVA: 0x000110A0 File Offset: 0x0000F2A0
	private void Method4243(173 1, 670 2, XmlNamespaceManager 3, bool 4)
	{
		switch (2.GetXmlDeclaration_11618())
		{
		case XmlNodeType.Element:
			if (this.Method4239(2) && 986.Method4244(2) && 2.List5352.Count > 0)
			{
				this.Method4240(1, 2, 3, false);
				return;
			}
			3.PushScope();
			foreach (670 5 in 2.List5353)
			{
				if (5.Method13409() == "http://www.w3.org/2000/xmlns/")
				{
					string prefix = (5.Method13408() != "xmlns") ? XmlConvert.DecodeName(5.Method13408()) : string.Empty;
					string text = 5.Method13406();
					if (text == null)
					{
						throw new 364("Namespace attribute must have a value.");
					}
					3.AddNamespace(prefix, text);
				}
			}
			if (4)
			{
				1.WritePropertyName(this.Method4238(2, 3));
			}
			if (!this.Method4259(2.List5353) && 2.List5352.Count == 1 && 2.List5352[0].GetXmlDeclaration_11618() == XmlNodeType.Text)
			{
				1.WriteValue(2.List5352[0].Method13406());
			}
			else if (2.List5352.Count == 0 && 2.List5353.Count == 0)
			{
				if (((613)2).Method7762())
				{
					1.WriteNull();
				}
				else
				{
					1.WriteValue(string.Empty);
				}
			}
			else
			{
				1.WriteStartObject();
				for (int i = 0; i < 2.List5353.Count; i++)
				{
					this.Method4243(1, 2.List5353[i], 3, true);
				}
				this.Method4240(1, 2, 3, true);
				1.WriteEndObject();
			}
			3.PopScope();
			return;
		case XmlNodeType.Attribute:
		case XmlNodeType.Text:
		case XmlNodeType.CDATA:
		case XmlNodeType.ProcessingInstruction:
		case XmlNodeType.Whitespace:
		case XmlNodeType.SignificantWhitespace:
			if ((!(2.Method13409() == "http://www.w3.org/2000/xmlns/") || !(2.Method13406() == "http://james.newtonking.com/projects/json")) && (!(2.Method13409() == "http://james.newtonking.com/projects/json") || !(2.Method13408() == "Array")))
			{
				if (4)
				{
					1.WritePropertyName(this.Method4238(2, 3));
				}
				1.WriteValue(2.Method13406());
				return;
			}
			return;
		case XmlNodeType.Comment:
			if (4)
			{
				1.WriteComment(2.Method13406());
				return;
			}
			return;
		case XmlNodeType.Document:
		case XmlNodeType.DocumentFragment:
			this.Method4240(1, 2, 3, 4);
			return;
		case XmlNodeType.DocumentType:
		{
			489 6 = (489)2;
			1.WritePropertyName(this.Method4238(2, 3));
			1.WriteStartObject();
			if (!538.Method6824(6.Text3100))
			{
				1.WritePropertyName("@name");
				1.WriteValue(6.Text3100);
			}
			if (!538.Method6824(6.Method4005()))
			{
				1.WritePropertyName("@public");
				1.WriteValue(6.Method4005());
			}
			if (!538.Method6824(6.Method4004()))
			{
				1.WritePropertyName("@system");
				1.WriteValue(6.Method4004());
			}
			if (!538.Method6824(6.Method4006()))
			{
				1.WritePropertyName("@internalSubset");
				1.WriteValue(6.Method4006());
			}
			1.WriteEndObject();
			return;
		}
		case XmlNodeType.XmlDeclaration:
		{
			635 7 = (635)2;
			1.WritePropertyName(this.Method4238(2, 3));
			1.WriteStartObject();
			if (!538.Method6824(7.Method11619()))
			{
				1.WritePropertyName("@version");
				1.WriteValue(7.Method11619());
			}
			if (!538.Method6824(7.Method11620()))
			{
				1.WritePropertyName("@encoding");
				1.WriteValue(7.Method11620());
			}
			if (!538.Method6824(7.Method11622()))
			{
				1.WritePropertyName("@standalone");
				1.WriteValue(7.Method11622());
			}
			1.WriteEndObject();
			return;
		}
		}
		throw new 364("Unexpected XmlNodeType when serializing nodes: " + 2.GetXmlDeclaration_11618().ToString());
	}

	// Token: 0x0600056E RID: 1390 RVA: 0x000114B8 File Offset: 0x0000F6B8
	private static bool Method4244(670 1)
	{
		using (List<670>.Enumerator enumerator = 1.List5352.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.Method13408() != 1.Method13408())
				{
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x0600056F RID: 1391 RVA: 0x0001151C File Offset: 0x0000F71C
	[return: 241(2)]
	public override object ReadJson(139 1, Type 2, [241(2)] object 3, 158 4)
	{
		216 tokenType = 1.GetTokenType();
		if (tokenType != 216.StartObject)
		{
			if (tokenType == 216.Null)
			{
				return null;
			}
			throw 364.Method1687(1, "XmlNodeConverter can only convert JSON that begins with an object.");
		}
		else
		{
			XmlNamespaceManager xmlNamespaceManager = new XmlNamespaceManager(new NameTable());
			422 5 = null;
			670 6 = null;
			if (typeof(XObject).IsAssignableFrom(2))
			{
				if (2 != typeof(XContainer) && 2 != typeof(XDocument) && 2 != typeof(XElement) && 2 != typeof(XNode) && 2 != typeof(XObject))
				{
					throw 364.Method1687(1, "XmlNodeConverter only supports deserializing XDocument, XElement, XContainer, XNode or XObject.");
				}
				5 = new 81(new XDocument());
				6 = 5;
			}
			if (typeof(XmlNode).IsAssignableFrom(2))
			{
				if (2 != typeof(XmlDocument) && 2 != typeof(XmlElement) && 2 != typeof(XmlNode))
				{
					throw 364.Method1687(1, "XmlNodeConverter only supports deserializing XmlDocument, XmlElement or XmlNode.");
				}
				5 = new 175(new XmlDocument
				{
					XmlResolver = null
				});
				6 = 5;
			}
			if (5 == null || 6 == null)
			{
				throw 364.Method1687(1, "Unexpected type when converting XML: " + ((2 != null) ? 2.ToString() : null));
			}
			if (!538.Method6824(this.Text3314))
			{
				this.Method4246(1, 5, 6, this.Text3314, xmlNamespaceManager);
			}
			else
			{
				1.Method2843();
				this.Method4257(1, 5, xmlNamespaceManager, 6);
			}
			if (2 == typeof(XElement))
			{
				XElement xelement = (XElement)5.RecoveredType15909193.GetXmlNode5349_6752();
				xelement.Remove();
				return xelement;
			}
			if (2 == typeof(XmlElement))
			{
				return 5.RecoveredType15909193.GetXmlNode5349_6752();
			}
			return 5.GetXmlNode5349_6752();
		}
	}

	// Token: 0x06000570 RID: 1392 RVA: 0x000116E4 File Offset: 0x0000F8E4
	private void Method4245(139 1, 422 2, XmlNamespaceManager 3, string 4, 670 5)
	{
		if (!this.GetFlag3313_4233())
		{
			if (4 == "#text")
			{
				5.Method11617(2.CreateTextNode(986.Method4249(1)));
				return;
			}
			if (4 == "#cdata-section")
			{
				5.Method11617(2.CreateCDataSection(986.Method4249(1)));
				return;
			}
			if (4 == "#whitespace")
			{
				5.Method11617(2.CreateWhitespace(986.Method4249(1)));
				return;
			}
			if (4 == "#significant-whitespace")
			{
				5.Method11617(2.CreateSignificantWhitespace(986.Method4249(1)));
				return;
			}
			if (!538.Method6824(4) && 4[0] == '?')
			{
				this.Method4254(1, 2, 5, 4);
				return;
			}
			if (string.Equals(4, "!DOCTYPE", StringComparison.OrdinalIgnoreCase))
			{
				this.Method4255(1, 2, 5);
				return;
			}
		}
		if (1.GetTokenType() == 216.StartArray)
		{
			this.Method4250(1, 2, 4, 5, 3);
			return;
		}
		this.Method4246(1, 2, 5, 4, 3);
	}

	// Token: 0x06000571 RID: 1393 RVA: 0x000117E8 File Offset: 0x0000F9E8
	private void Method4246(139 1, 422 2, 670 3, string 4, XmlNamespaceManager 5)
	{
		if (538.Method6824(4))
		{
			throw 364.Method1687(1, "XmlNodeConverter cannot convert JSON with an empty property name to XML.");
		}
		Dictionary<string, string> 6 = null;
		string 7 = null;
		if (!this.GetFlag3313_4233())
		{
			6 = (this.Method4252(1) ? this.Method4253(1, 5) : null);
			7 = 736.Method11632(4);
			if (4.Method6843('@'))
			{
				string text = 4.Substring(1);
				string 8 = 736.Method11632(text);
				986.Method4248(1, 2, 3, 4, text, 5, 8);
				return;
			}
			if (4.Method6843('$'))
			{
				if (4 == "$values")
				{
					4 = 4.Substring(1);
					7 = 5.LookupPrefix("http://james.newtonking.com/projects/json");
					this.Method4247(1, 2, 3, 4, 5, 7, 6);
					return;
				}
				if (4 == "$id" || 4 == "$ref" || 4 == "$type" || 4 == "$value")
				{
					string 9 = 4.Substring(1);
					string 10 = 5.LookupPrefix("http://james.newtonking.com/projects/json");
					986.Method4248(1, 2, 3, 4, 9, 5, 10);
					return;
				}
			}
		}
		else if (this.Method4252(1))
		{
			1.Method2843();
		}
		this.Method4247(1, 2, 3, 4, 5, 7, 6);
	}

	// Token: 0x06000572 RID: 1394 RVA: 0x00011924 File Offset: 0x0000FB24
	private void Method4247(139 1, 422 2, 670 3, string 4, XmlNamespaceManager 5, [241(2)] string 6, [241(new byte[]
	{
		2,
		1,
		2
	})] Dictionary<string, string> 7)
	{
		613 8 = this.Method4247(4, 2, 6, 5);
		3.Method11617(8);
		if (7 != null)
		{
			foreach (KeyValuePair<string, string> keyValuePair in 7)
			{
				string 9 = XmlConvert.EncodeName(keyValuePair.Key);
				string text = 736.Method11632(keyValuePair.Key);
				670 10 = (!538.Method6824(text)) ? 2.Method116152(9, 5.LookupNamespace(text) ?? string.Empty, keyValuePair.Value) : 2.Method116152(9, keyValuePair.Value);
				8.Method7757(10);
			}
		}
		switch (1.GetTokenType())
		{
		case 216.Integer:
		case 216.Float:
		case 216.String:
		case 216.Boolean:
		case 216.Date:
		case 216.Bytes:
		{
			string text2 = 986.Method4249(1);
			if (text2 != null)
			{
				8.Method11617(2.CreateTextNode(text2));
				return;
			}
			return;
		}
		case 216.Null:
			return;
		case 216.EndObject:
			5.RemoveNamespace(string.Empty, 5.DefaultNamespace);
			return;
		}
		5.PushScope();
		this.Method4257(1, 2, 5, 8);
		5.PopScope();
		5.RemoveNamespace(string.Empty, 5.DefaultNamespace);
	}

	// Token: 0x06000573 RID: 1395 RVA: 0x00011A84 File Offset: 0x0000FC84
	private static void Method4248(139 1, 422 2, 670 3, string 4, string 5, XmlNamespaceManager 6, [241(2)] string 7)
	{
		if (3.GetXmlDeclaration_11618() == XmlNodeType.Document)
		{
			throw 364.Method1687(1, "JSON root object has property '{0}' that will be converted to an attribute. A root object cannot have any attribute properties. Consider specifying a DeserializeRootElementName.".Method6825(CultureInfo.InvariantCulture, 4));
		}
		string 8 = XmlConvert.EncodeName(5);
		string text = 986.Method4249(1);
		670 9 = (!538.Method6824(7)) ? 2.Method116152(8, 6.LookupNamespace(7), text) : 2.Method116152(8, text);
		((613)3).Method7757(9);
	}

	// Token: 0x06000574 RID: 1396 RVA: 0x00011AF4 File Offset: 0x0000FCF4
	[return: 241(2)]
	private static string Method4249(139 1)
	{
		switch (1.GetTokenType())
		{
		case 216.Integer:
		{
			object value = 1.GetValue();
			if (value is BigInteger)
			{
				return ((BigInteger)value).ToString(CultureInfo.InvariantCulture);
			}
			return XmlConvert.ToString(Convert.ToInt64(1.GetValue(), CultureInfo.InvariantCulture));
		}
		case 216.Float:
		{
			object value = 1.GetValue();
			if (value is decimal)
			{
				decimal value2 = (decimal)value;
				return XmlConvert.ToString(value2);
			}
			value = 1.GetValue();
			if (value is float)
			{
				float value3 = (float)value;
				return XmlConvert.ToString(value3);
			}
			return XmlConvert.ToString(Convert.ToDouble(1.GetValue(), CultureInfo.InvariantCulture));
		}
		case 216.String:
		{
			object value4 = 1.GetValue();
			if (value4 == null)
			{
				return null;
			}
			return value4.ToString();
		}
		case 216.Boolean:
			return XmlConvert.ToString(Convert.ToBoolean(1.GetValue(), CultureInfo.InvariantCulture));
		case 216.Null:
			return null;
		case 216.Date:
		{
			object value = 1.GetValue();
			if (value is DateTimeOffset)
			{
				DateTimeOffset value5 = (DateTimeOffset)value;
				return XmlConvert.ToString(value5);
			}
			DateTime value6 = Convert.ToDateTime(1.GetValue(), CultureInfo.InvariantCulture);
			return XmlConvert.ToString(value6, 382.Method2107(value6.Kind));
		}
		case 216.Bytes:
			return Convert.ToBase64String((byte[])1.GetValue());
		}
		throw 364.Method1687(1, "Cannot get an XML string value from token type '{0}'.".Method6825(CultureInfo.InvariantCulture, 1.GetTokenType()));
	}

	// Token: 0x06000575 RID: 1397 RVA: 0x00011C78 File Offset: 0x0000FE78
	private void Method4250(139 1, 422 2, string 3, 670 4, XmlNamespaceManager 5)
	{
		string 6 = 736.Method11632(3);
		613 7 = this.Method4247(3, 2, 6, 5);
		4.Method11617(7);
		int num = 0;
		while (1.Read() && 1.GetTokenType() != 216.EndArray)
		{
			this.Method4245(1, 2, 5, 3, 7);
			num++;
		}
		if (this.GetFlag3311_4229())
		{
			this.Method4251(7, 2);
		}
		if (num != 1 || !this.GetFlag3311_4229())
		{
			return;
		}
		foreach (670 8 in 7.List5352)
		{
			613 9 = 8 as 613;
			if (9 != null && 9.Method13408() == 3)
			{
				this.Method4251(9, 2);
				break;
			}
		}
	}

	// Token: 0x06000576 RID: 1398 RVA: 0x00011D48 File Offset: 0x0000FF48
	private void Method4251(613 1, 422 2)
	{
		1.Method7757(2.Method116152("json:Array", "http://james.newtonking.com/projects/json", "true"));
		if (1 is 563 && 1.Method7761("http://james.newtonking.com/projects/json") == null)
		{
			1.Method7757(2.Method116152("xmlns:json", "http://www.w3.org/2000/xmlns/", "http://james.newtonking.com/projects/json"));
		}
	}

	// Token: 0x06000577 RID: 1399 RVA: 0x00011DA0 File Offset: 0x0000FFA0
	private bool Method4252(139 1)
	{
		switch (1.GetTokenType())
		{
		case 216.StartConstructor:
		case 216.Integer:
		case 216.Float:
		case 216.String:
		case 216.Boolean:
		case 216.Null:
		case 216.Date:
		case 216.Bytes:
			return false;
		}
		return true;
	}

	// Token: 0x06000578 RID: 1400 RVA: 0x00011E00 File Offset: 0x00010000
	[return: 241(new byte[]
	{
		2,
		1,
		2
	})]
	private Dictionary<string, string> Method4253(139 1, XmlNamespaceManager 2)
	{
		Dictionary<string, string> dictionary = null;
		bool flag = false;
		while (!flag && 1.Read())
		{
			216 tokenType = 1.GetTokenType();
			if (tokenType != 216.PropertyName)
			{
				if (tokenType != 216.Comment && tokenType != 216.EndObject)
				{
					throw 364.Method1687(1, "Unexpected JsonToken: " + 1.GetTokenType().ToString());
				}
				flag = true;
			}
			else
			{
				string text = 1.GetValue().ToString();
				if (!538.Method6824(text))
				{
					char c = text[0];
					if (c != '$')
					{
						if (c == '@')
						{
							if (dictionary == null)
							{
								dictionary = new Dictionary<string, string>();
							}
							text = text.Substring(1);
							1.Method2843();
							string text2 = 986.Method4249(1);
							dictionary.Add(text, text2);
							string prefix;
							if (this.Method4258(text, out prefix))
							{
								2.AddNamespace(prefix, text2);
							}
						}
						else
						{
							flag = true;
						}
					}
					else if (text == "$values" || text == "$id" || text == "$ref" || text == "$type" || text == "$value")
					{
						string text3 = 2.LookupPrefix("http://james.newtonking.com/projects/json");
						if (text3 == null)
						{
							if (dictionary == null)
							{
								dictionary = new Dictionary<string, string>();
							}
							int? num = null;
							int? num2;
							int? num3;
							for (;;)
							{
								string text4 = "json";
								num2 = num;
								string str = text4;
								num3 = num2;
								if (2.LookupNamespace(str + num3.ToString()) == null)
								{
									break;
								}
								num = new int?(num.GetValueOrDefault() + 1);
							}
							string str2 = "json";
							num2 = num;
							num3 = num2;
							text3 = str2 + num3.ToString();
							dictionary.Add("xmlns:" + text3, "http://james.newtonking.com/projects/json");
							2.AddNamespace(text3, "http://james.newtonking.com/projects/json");
						}
						if (text == "$values")
						{
							flag = true;
						}
						else
						{
							text = text.Substring(1);
							1.Method2843();
							if (!169.IsPrimitiveToken(1.GetTokenType()))
							{
								throw 364.Method1687(1, "Unexpected JsonToken: " + 1.GetTokenType().ToString());
							}
							if (dictionary == null)
							{
								dictionary = new Dictionary<string, string>();
							}
							object value = 1.GetValue();
							string value2 = (value != null) ? value.ToString() : null;
							dictionary.Add(text3 + ":" + text, value2);
						}
					}
					else
					{
						flag = true;
					}
				}
				else
				{
					flag = true;
				}
			}
		}
		return dictionary;
	}

	// Token: 0x06000579 RID: 1401 RVA: 0x00012064 File Offset: 0x00010264
	private void Method4254(139 1, 422 2, 670 3, string 4)
	{
		if (!(4 == "?xml"))
		{
			670 5 = 2.CreateProcessingInstruction(4.Substring(1), 986.Method4249(1));
			3.Method11617(5);
			return;
		}
		string text = null;
		string 6 = null;
		string 7 = null;
		while (1.Read() && 1.GetTokenType() != 216.EndObject)
		{
			object value = 1.GetValue();
			string a = (value != null) ? value.ToString() : null;
			if (!(a == "@version"))
			{
				if (!(a == "@encoding"))
				{
					if (!(a == "@standalone"))
					{
						string str = "Unexpected property name encountered while deserializing XmlDeclaration: ";
						object value2 = 1.GetValue();
						throw 364.Method1687(1, str + ((value2 != null) ? value2.ToString() : null));
					}
					1.Method2843();
					7 = 986.Method4249(1);
				}
				else
				{
					1.Method2843();
					6 = 986.Method4249(1);
				}
			}
			else
			{
				1.Method2843();
				text = 986.Method4249(1);
			}
		}
		if (text == null)
		{
			throw 364.Method1687(1, "Version not specified for XML declaration.");
		}
		670 8 = 2.CreateXmlDeclaration(text, 6, 7);
		3.Method11617(8);
	}

	// Token: 0x0600057A RID: 1402 RVA: 0x00012170 File Offset: 0x00010370
	private void Method4255(139 1, 422 2, 670 3)
	{
		string text = null;
		string 4 = null;
		string 5 = null;
		string 6 = null;
		while (1.Read() && 1.GetTokenType() != 216.EndObject)
		{
			object value = 1.GetValue();
			string a = (value != null) ? value.ToString() : null;
			if (!(a == "@name"))
			{
				if (!(a == "@public"))
				{
					if (!(a == "@system"))
					{
						if (!(a == "@internalSubset"))
						{
							string str = "Unexpected property name encountered while deserializing XmlDeclaration: ";
							object value2 = 1.GetValue();
							throw 364.Method1687(1, str + ((value2 != null) ? value2.ToString() : null));
						}
						1.Method2843();
						6 = 986.Method4249(1);
					}
					else
					{
						1.Method2843();
						5 = 986.Method4249(1);
					}
				}
				else
				{
					1.Method2843();
					4 = 986.Method4249(1);
				}
			}
			else
			{
				1.Method2843();
				text = 986.Method4249(1);
			}
		}
		if (text == null)
		{
			throw 364.Method1687(1, "Name not specified for XML document type.");
		}
		670 7 = 2.CreateXmlDocumentType(text, 4, 5, 6);
		3.Method11617(7);
	}

	// Token: 0x0600057B RID: 1403 RVA: 0x0001226C File Offset: 0x0001046C
	private 613 Method4247(string 1, 422 2, [241(2)] string 3, XmlNamespaceManager 4)
	{
		string 5 = this.GetFlag3313_4233() ? XmlConvert.EncodeLocalName(1) : XmlConvert.EncodeName(1);
		string text = 538.Method6824(3) ? 4.DefaultNamespace : 4.LookupNamespace(3);
		if (538.Method6824(text))
		{
			return 2.Method116132(5);
		}
		return 2.Method116132(5, text);
	}

	// Token: 0x0600057C RID: 1404 RVA: 0x000122C4 File Offset: 0x000104C4
	private void Method4257(139 1, 422 2, XmlNamespaceManager 3, 670 4)
	{
		216 tokenType;
		for (;;)
		{
			tokenType = 1.GetTokenType();
			switch (tokenType)
			{
			case 216.StartConstructor:
			{
				string 5 = 1.GetValue().ToString();
				while (1.Read())
				{
					if (1.GetTokenType() == 216.EndConstructor)
					{
						break;
					}
					this.Method4245(1, 2, 3, 5, 4);
				}
				goto IL_1AE;
			}
			case 216.PropertyName:
			{
				if (4.GetXmlDeclaration_11618() == XmlNodeType.Document && 2.RecoveredType15909193 != null)
				{
					goto Block_3;
				}
				string text = 1.GetValue().ToString();
				1.Method2843();
				if (1.GetTokenType() == 216.StartArray)
				{
					int num = 0;
					while (1.Read() && 1.GetTokenType() != 216.EndArray)
					{
						this.Method4245(1, 2, 3, text, 4);
						num++;
					}
					if (num != 1 || !this.GetFlag3311_4229())
					{
						goto IL_1AE;
					}
					string text2;
					string b;
					736.Method11634(text, out text2, out b);
					string b2 = 538.Method6824(text2) ? 3.DefaultNamespace : 3.LookupNamespace(text2);
					using (List<670>.Enumerator enumerator = 4.List5352.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							670 6 = enumerator.Current;
							613 7 = 6 as 613;
							if (7 != null && 7.Method13408() == b && 7.Method13409() == b2)
							{
								this.Method4251(7, 2);
								break;
							}
						}
						goto IL_1AE;
					}
				}
				this.Method4245(1, 2, 3, text, 4);
				goto IL_1AE;
			}
			case 216.Comment:
				4.Method11617(2.CreateComment((string)1.GetValue()));
				goto IL_1AE;
			}
			break;
			IL_1AE:
			if (!1.Read())
			{
				return;
			}
		}
		if (tokenType - 216.EndObject > 1)
		{
			throw 364.Method1687(1, "Unexpected JsonToken when deserializing node: " + 1.GetTokenType().ToString());
		}
		return;
		Block_3:
		throw 364.Method1687(1, "JSON root object has multiple properties. The root object must have a single property in order to create a valid XML document. Consider specifying a DeserializeRootElementName.");
	}

	// Token: 0x0600057D RID: 1405 RVA: 0x0001249C File Offset: 0x0001069C
	private bool Method4258(string 1, [241(2)] [239(true)] out string 2)
	{
		if (1.StartsWith("xmlns", StringComparison.Ordinal))
		{
			if (1.Length == 5)
			{
				2 = string.Empty;
				return true;
			}
			if (1[5] == ':')
			{
				2 = 1.Substring(6, 1.Length - 6);
				return true;
			}
		}
		2 = null;
		return false;
	}

	// Token: 0x0600057E RID: 1406 RVA: 0x000124EC File Offset: 0x000106EC
	private bool Method4259(List<670> 1)
	{
		foreach (670 2 in 1)
		{
			if (!(2.Method13409() == "http://james.newtonking.com/projects/json") && (!(2.Method13409() == "http://www.w3.org/2000/xmlns/") || !(2.Method13406() == "http://james.newtonking.com/projects/json")))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600057F RID: 1407 RVA: 0x00012570 File Offset: 0x00010770
	public override bool CanConvert(Type 1)
	{
		if (1.Method6716("System.Xml.Linq.XObject", false))
		{
			return this.Method4260(1);
		}
		return 1.Method6716("System.Xml.XmlNode", false) && this.Method4261(1);
	}

	// Token: 0x06000580 RID: 1408 RVA: 0x0001259F File Offset: 0x0001079F
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool Method4260(Type 1)
	{
		return typeof(XObject).IsAssignableFrom(1);
	}

	// Token: 0x06000581 RID: 1409 RVA: 0x000125B1 File Offset: 0x000107B1
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool Method4261(Type 1)
	{
		return typeof(XmlNode).IsAssignableFrom(1);
	}

	// Token: 0x04000417 RID: 1047
	internal static readonly List<670> list4 = new List<670>();

	// Token: 0x04000418 RID: 1048
	[241(2)]
	private string text7;

	// Token: 0x04000419 RID: 1049
	private bool flag2;

	// Token: 0x0400041A RID: 1050
	private bool flag3;

	// Token: 0x0400041B RID: 1051
	private bool flag4;
}
