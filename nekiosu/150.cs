using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

// Token: 0x020001D0 RID: 464
public sealed class 150
{
	// Token: 0x06000ECE RID: 3790 RVA: 0x00031756 File Offset: 0x0002F956
	public 150(744 1)
	{
		this.iList = new List<529>();
		this.iDictionary = new Dictionary<string, 529>();
		this.resolver = 1;
	}

	// Token: 0x06000ECF RID: 3791 RVA: 0x0003177B File Offset: 0x0002F97B
	private void Push(529 1)
	{
		this.currentSchema = 1;
		this.iList.Add(1);
		this.resolver.GetIList9362_11936().Add(1);
		this.iDictionary.Add(1.GetText5124_6436(), 1);
	}

	// Token: 0x06000ED0 RID: 3792 RVA: 0x000317B3 File Offset: 0x0002F9B3
	private 529 Pop()
	{
		529 result = this.currentSchema;
		this.iList.RemoveAt(this.iList.Count - 1);
		this.currentSchema = this.iList.LastOrDefault<529>();
		return result;
	}

	// Token: 0x06000ED1 RID: 3793 RVA: 0x000317E4 File Offset: 0x0002F9E4
	private 529 GetCurrentSchema()
	{
		return this.currentSchema;
	}

	// Token: 0x06000ED2 RID: 3794 RVA: 0x000317EC File Offset: 0x0002F9EC
	internal 529 Read(139 1)
	{
		226 2 = 226.ReadFrom(1);
		this.rootObject = (2 as 217);
		529 3 = this.BuildSchema(2);
		this.ResolveReferences(3);
		return 3;
	}

	// Token: 0x06000ED3 RID: 3795 RVA: 0x0003181D File Offset: 0x0002FA1D
	private string UnescapeReference(string 1)
	{
		return 538.Method6842(538.Method6842(Uri.UnescapeDataString(1), "~1", "/"), "~0", "~");
	}

	// Token: 0x06000ED4 RID: 3796 RVA: 0x00031844 File Offset: 0x0002FA44
	private 529 ResolveReferences(529 1)
	{
		if (1.GetText5126_6439() != null)
		{
			string text = 1.GetText5126_6439();
			bool flag = text.StartsWith("#", StringComparison.Ordinal);
			if (flag)
			{
				text = this.UnescapeReference(text);
			}
			529 2 = this.resolver.Method11938(text);
			if (2 == null)
			{
				if (flag)
				{
					string[] array = 1.GetText5126_6439().TrimStart(new char[]
					{
						'#'
					}).Split(new char[]
					{
						'/'
					}, StringSplitOptions.RemoveEmptyEntries);
					226 3 = this.rootObject;
					foreach (string 4 in array)
					{
						string text2 = this.UnescapeReference(4);
						if (3.Type == 705.Object)
						{
							3 = 3[text2];
						}
						else if (3.Type == 705.Array || 3.Type == 705.Constructor)
						{
							int num;
							3 = ((!int.TryParse(text2, out num) || num < 0 || num >= 3.Count<226>()) ? null : 3[num]);
						}
						if (3 == null)
						{
							break;
						}
					}
					if (3 != null)
					{
						2 = this.BuildSchema(3);
					}
				}
				if (2 == null)
				{
					throw new 134("Could not resolve schema reference '{0}'.".Method6825(CultureInfo.InvariantCulture, 1.GetText5126_6439()));
				}
			}
			1 = 2;
		}
		if (1.GetFlag5127_6441())
		{
			return 1;
		}
		1.SetFlag5127_6442(true);
		if (1.GetIList5122_6432() != null)
		{
			for (int j = 0; j < 1.GetIList5122_6432().Count; j++)
			{
				1.GetIList5122_6432()[j] = this.ResolveReferences(1.GetIList5122_6432()[j]);
			}
		}
		if (1.GetIList5109_6406() != null)
		{
			for (int k = 0; k < 1.GetIList5109_6406().Count; k++)
			{
				1.GetIList5109_6406()[k] = this.ResolveReferences(1.GetIList5109_6406()[k]);
			}
		}
		if (1.GetRecoveredType11435111_6410() != null)
		{
			1.SetRecoveredType11435111_6411(this.ResolveReferences(1.GetRecoveredType11435111_6410()));
		}
		if (1.GetIDictionary5116_6420() != null)
		{
			foreach (KeyValuePair<string, 529> keyValuePair in 1.GetIDictionary5116_6420().ToList<KeyValuePair<string, 529>>())
			{
				1.GetIDictionary5116_6420()[keyValuePair.Key] = this.ResolveReferences(keyValuePair.Value);
			}
		}
		if (1.GetIDictionary5114_6416() != null)
		{
			foreach (KeyValuePair<string, 529> keyValuePair2 in 1.GetIDictionary5114_6416().ToList<KeyValuePair<string, 529>>())
			{
				1.GetIDictionary5114_6416()[keyValuePair2.Key] = this.ResolveReferences(keyValuePair2.Value);
			}
		}
		if (1.GetRecoveredType11435115_6418() != null)
		{
			1.SetRecoveredType11435115_6419(this.ResolveReferences(1.GetRecoveredType11435115_6418()));
		}
		return 1;
	}

	// Token: 0x06000ED5 RID: 3797 RVA: 0x00031B08 File Offset: 0x0002FD08
	private 529 BuildSchema(226 1)
	{
		217 2 = 1 as 217;
		if (2 == null)
		{
			throw 134.Method8331(1, 1.Path, "Expected object while parsing schema object, got {0}.".Method6825(CultureInfo.InvariantCulture, 1.Type));
		}
		226 3;
		if (2.TryGetValue("$ref", out 3))
		{
			529 4 = new 529();
			4.SetText5126_6440((string)3);
			return 4;
		}
		string text = 1.Path;
		text = 538.Method6842(text, ".", "/");
		text = 538.Method6842(text, "[", "/");
		text = 538.Method6842(text, "]", string.Empty);
		if (!538.Method6824(text))
		{
			text = "/" + text;
		}
		text = "#" + text;
		529 result;
		if (this.iDictionary.TryGetValue(text, out result))
		{
			return result;
		}
		529 5 = new 529();
		5.SetText5124_6437(text);
		this.Push(5);
		this.ProcessSchemaProperties(2);
		return this.Pop();
	}

	// Token: 0x06000ED6 RID: 3798 RVA: 0x00031BF8 File Offset: 0x0002FDF8
	private void ProcessSchemaProperties(217 1)
	{
		foreach (KeyValuePair<string, 226> keyValuePair in 1)
		{
			string key = keyValuePair.Key;
			uint num = 508.ComputeStringHash(key);
			if (num <= 2223801888U)
			{
				if (num <= 981021583U)
				{
					if (num <= 353304077U)
					{
						if (num != 299789532U)
						{
							if (num != 334560121U)
							{
								if (num == 353304077U)
								{
									if (key == "divisibleBy")
									{
										this.GetCurrentSchema().SetNullable5102_6393(new double?((double)keyValuePair.Value));
									}
								}
							}
							else if (key == "minItems")
							{
								this.GetCurrentSchema().SetNullable5107_6403(new int?((int)keyValuePair.Value));
							}
						}
						else if (key == "properties")
						{
							this.GetCurrentSchema().SetIDictionary5114_6417(this.ProcessProperties(keyValuePair.Value));
						}
					}
					else if (num <= 879704937U)
					{
						if (num != 479998177U)
						{
							if (num == 879704937U)
							{
								if (key == "description")
								{
									this.GetCurrentSchema().SetText5097_6383((string)keyValuePair.Value);
								}
							}
						}
						else if (key == "additionalProperties")
						{
							this.ProcessAdditionalProperties(keyValuePair.Value);
						}
					}
					else if (num != 926444256U)
					{
						if (num == 981021583U)
						{
							if (key == "items")
							{
								this.ProcessItems(keyValuePair.Value);
							}
						}
					}
					else if (key == "id")
					{
						this.GetCurrentSchema().SetText5091_6371((string)keyValuePair.Value);
					}
				}
				else if (num <= 1693958795U)
				{
					if (num != 1361572173U)
					{
						if (num != 1542649473U)
						{
							if (num == 1693958795U)
							{
								if (key == "exclusiveMaximum")
								{
									this.GetCurrentSchema().SetNullable5106_6401(new bool?((bool)keyValuePair.Value));
								}
							}
						}
						else if (key == "maximum")
						{
							this.GetCurrentSchema().SetNullable5104_6397(new double?((double)keyValuePair.Value));
						}
					}
					else if (key == "type")
					{
						this.GetCurrentSchema().SetNullable5098_6385(this.ProcessType(keyValuePair.Value));
					}
				}
				else if (num <= 2051482624U)
				{
					if (num != 1913005517U)
					{
						if (num == 2051482624U)
						{
							if (key == "additionalItems")
							{
								this.ProcessAdditionalItems(keyValuePair.Value);
							}
						}
					}
					else if (key == "exclusiveMinimum")
					{
						this.GetCurrentSchema().SetNullable5105_6399(new bool?((bool)keyValuePair.Value));
					}
				}
				else if (num != 2171383808U)
				{
					if (num == 2223801888U)
					{
						if (key == "required")
						{
							this.GetCurrentSchema().SetNullable5093_6375(new bool?((bool)keyValuePair.Value));
						}
					}
				}
				else if (key == "enum")
				{
					this.ProcessEnum(keyValuePair.Value);
				}
			}
			else if (num <= 2692244416U)
			{
				if (num <= 2474713847U)
				{
					if (num != 2268922153U)
					{
						if (num != 2470140894U)
						{
							if (num == 2474713847U)
							{
								if (key == "minimum")
								{
									this.GetCurrentSchema().SetNullable5103_6395(new double?((double)keyValuePair.Value));
								}
							}
						}
						else if (key == "default")
						{
							this.GetCurrentSchema().SetJToken5121_6431(keyValuePair.Value.DeepClone());
						}
					}
					else if (key == "pattern")
					{
						this.GetCurrentSchema().SetText5099_6387((string)keyValuePair.Value);
					}
				}
				else if (num <= 2609687125U)
				{
					if (num != 2556802313U)
					{
						if (num == 2609687125U)
						{
							if (key == "requires")
							{
								this.GetCurrentSchema().SetText5118_6425((string)keyValuePair.Value);
							}
						}
					}
					else if (key == "title")
					{
						this.GetCurrentSchema().SetText5092_6373((string)keyValuePair.Value);
					}
				}
				else if (num != 2642794062U)
				{
					if (num == 2692244416U)
					{
						if (key == "disallow")
						{
							this.GetCurrentSchema().SetNullable5120_6429(this.ProcessType(keyValuePair.Value));
						}
					}
				}
				else if (key == "extends")
				{
					this.ProcessExtends(keyValuePair.Value);
				}
			}
			else if (num <= 3522602594U)
			{
				if (num <= 3114108242U)
				{
					if (num != 2957261815U)
					{
						if (num == 3114108242U)
						{
							if (key == "format")
							{
								this.GetCurrentSchema().SetText5123_6435((string)keyValuePair.Value);
							}
						}
					}
					else if (key == "minLength")
					{
						this.GetCurrentSchema().SetNullable5100_6389(new int?((int)keyValuePair.Value));
					}
				}
				else if (num != 3456888823U)
				{
					if (num == 3522602594U)
					{
						if (key == "uniqueItems")
						{
							this.GetCurrentSchema().SetFlag5113_6415((bool)keyValuePair.Value);
						}
					}
				}
				else if (key == "readonly")
				{
					this.GetCurrentSchema().SetNullable5094_6377(new bool?((bool)keyValuePair.Value));
				}
			}
			else if (num <= 3947606640U)
			{
				if (num != 3526559937U)
				{
					if (num == 3947606640U)
					{
						if (key == "patternProperties")
						{
							this.GetCurrentSchema().SetIDictionary5116_6421(this.ProcessProperties(keyValuePair.Value));
						}
					}
				}
				else if (key == "maxLength")
				{
					this.GetCurrentSchema().SetNullable5101_6391(new int?((int)keyValuePair.Value));
				}
			}
			else if (num != 4128829753U)
			{
				if (num == 4244322099U)
				{
					if (key == "maxItems")
					{
						this.GetCurrentSchema().SetNullable5108_6405(new int?((int)keyValuePair.Value));
					}
				}
			}
			else if (key == "hidden")
			{
				this.GetCurrentSchema().SetNullable5095_6379(new bool?((bool)keyValuePair.Value));
			}
		}
	}

	// Token: 0x06000ED7 RID: 3799 RVA: 0x00032330 File Offset: 0x00030530
	private void ProcessExtends(226 1)
	{
		IList<529> list = new List<529>();
		if (1.Type == 705.Array)
		{
			using (IEnumerator<226> enumerator = ((IEnumerable<226>)1).GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					226 2 = enumerator.Current;
					list.Add(this.BuildSchema(2));
				}
				goto IL_52;
			}
		}
		529 3 = this.BuildSchema(1);
		if (3 != null)
		{
			list.Add(3);
		}
		IL_52:
		if (list.Count > 0)
		{
			this.GetCurrentSchema().SetIList5122_6433(list);
		}
	}

	// Token: 0x06000ED8 RID: 3800 RVA: 0x000323B4 File Offset: 0x000305B4
	private void ProcessEnum(226 1)
	{
		if (1.Type != 705.Array)
		{
			throw 134.Method8331(1, 1.Path, "Expected Array token while parsing enum values, got {0}.".Method6825(CultureInfo.InvariantCulture, 1.Type));
		}
		this.GetCurrentSchema().SetIList5119_6427(new List<226>());
		foreach (226 2 in ((IEnumerable<226>)1))
		{
			this.GetCurrentSchema().GetIList5119_6426().Add(2.DeepClone());
		}
	}

	// Token: 0x06000ED9 RID: 3801 RVA: 0x0003244C File Offset: 0x0003064C
	private void ProcessAdditionalProperties(226 1)
	{
		if (1.Type == 705.Boolean)
		{
			this.GetCurrentSchema().SetFlag5117_6423((bool)1);
			return;
		}
		this.GetCurrentSchema().SetRecoveredType11435115_6419(this.BuildSchema(1));
	}

	// Token: 0x06000EDA RID: 3802 RVA: 0x0003247C File Offset: 0x0003067C
	private void ProcessAdditionalItems(226 1)
	{
		if (1.Type == 705.Boolean)
		{
			this.GetCurrentSchema().SetFlag5112_6413((bool)1);
			return;
		}
		this.GetCurrentSchema().SetRecoveredType11435111_6411(this.BuildSchema(1));
	}

	// Token: 0x06000EDB RID: 3803 RVA: 0x000324AC File Offset: 0x000306AC
	private IDictionary<string, 529> ProcessProperties(226 1)
	{
		IDictionary<string, 529> dictionary = new Dictionary<string, 529>();
		if (1.Type != 705.Object)
		{
			throw 134.Method8331(1, 1.Path, "Expected Object token while parsing schema properties, got {0}.".Method6825(CultureInfo.InvariantCulture, 1.Type));
		}
		foreach (226 2 in ((IEnumerable<226>)1))
		{
			222 3 = (222)2;
			if (dictionary.ContainsKey(3.Name))
			{
				throw new 134("Property {0} has already been defined in schema.".Method6825(CultureInfo.InvariantCulture, 3.Name));
			}
			dictionary.Add(3.Name, this.BuildSchema(3.Value));
		}
		return dictionary;
	}

	// Token: 0x06000EDC RID: 3804 RVA: 0x0003256C File Offset: 0x0003076C
	private void ProcessItems(226 1)
	{
		this.GetCurrentSchema().SetIList5109_6407(new List<529>());
		705 type = 1.Type;
		if (type != 705.Object)
		{
			if (type == 705.Array)
			{
				this.GetCurrentSchema().SetFlag5110_6409(true);
				using (IEnumerator<226> enumerator = ((IEnumerable<226>)1).GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						226 2 = enumerator.Current;
						this.GetCurrentSchema().GetIList5109_6406().Add(this.BuildSchema(2));
					}
					return;
				}
			}
			throw 134.Method8331(1, 1.Path, "Expected array or JSON schema object, got {0}.".Method6825(CultureInfo.InvariantCulture, 1.Type));
		}
		this.GetCurrentSchema().GetIList5109_6406().Add(this.BuildSchema(1));
		this.GetCurrentSchema().SetFlag5110_6409(false);
	}

	// Token: 0x06000EDD RID: 3805 RVA: 0x0003263C File Offset: 0x0003083C
	private 235? ProcessType(226 1)
	{
		705 type = 1.Type;
		if (type == 705.Array)
		{
			235? 2 = new 235?(235.None);
			foreach (226 3 in ((IEnumerable<226>)1))
			{
				if (3.Type != 705.String)
				{
					throw 134.Method8331(3, 3.Path, "Expected JSON schema type string token, got {0}.".Method6825(CultureInfo.InvariantCulture, 1.Type));
				}
				2 |= 150.Method4160((string)3);
			}
			return 2;
		}
		if (type != 705.String)
		{
			throw 134.Method8331(1, 1.Path, "Expected array or JSON schema type string token, got {0}.".Method6825(CultureInfo.InvariantCulture, 1.Type));
		}
		return new 235?(150.Method4160((string)1));
	}

	// Token: 0x06000EDE RID: 3806 RVA: 0x0003273C File Offset: 0x0003093C
	internal static 235 Method4160(string 1)
	{
		235 result;
		if (!785.iDictionary.TryGetValue(1, out result))
		{
			throw new 134("Invalid JSON schema type: {0}".Method6825(CultureInfo.InvariantCulture, 1));
		}
		return result;
	}

	// Token: 0x06000EDF RID: 3807 RVA: 0x00032770 File Offset: 0x00030970
	internal static string Method4160(235 1)
	{
		150.151 2 = new 150.151();
		2.jsonSchemaType = 1;
		return 785.iDictionary.Single(new Func<KeyValuePair<string, 235>, bool>(2.Method4144)).Key;
	}

	// Token: 0x0400073A RID: 1850
	private readonly IList<529> iList;

	// Token: 0x0400073B RID: 1851
	private readonly 744 resolver;

	// Token: 0x0400073C RID: 1852
	private readonly IDictionary<string, 529> iDictionary;

	// Token: 0x0400073D RID: 1853
	private 529 currentSchema;

	// Token: 0x0400073E RID: 1854
	private 217 rootObject;

	// Token: 0x020001D1 RID: 465
	public sealed class 151
	{
		// Token: 0x06000EE0 RID: 3808 RVA: 0x000327A8 File Offset: 0x000309A8
		internal bool Method4144(KeyValuePair<string, 235> 1)
		{
			return 1.Value == this.jsonSchemaType;
		}

		// Token: 0x0400073F RID: 1855
		public 235 jsonSchemaType;
	}
}
