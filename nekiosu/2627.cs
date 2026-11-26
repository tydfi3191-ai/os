using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

// Token: 0x0200046B RID: 1131
[Serializable]
public abstract class 2627
{
	// Token: 0x0600228C RID: 8844 RVA: 0x0009575C File Offset: 0x0009395C
	internal 1881 1()
	{
		if (this.fruitsSkin == null)
		{
			this.fruitsSkin = new 1881();
		}
		return this.fruitsSkin;
	}

	// Token: 0x0600228D RID: 8845 RVA: 0x00095777 File Offset: 0x00093977
	internal void 2(1881 1)
	{
		this.fruitsSkin = 1;
	}

	// Token: 0x0600228E RID: 8846 RVA: 0x00095780 File Offset: 0x00093980
	internal void 3(string 1)
	{
		this.ManiaSkins.Clear();
		this.2(new 1881());
		this.sections.Clear();
		this.currentSection = null;
		this.Filename = 1;
		1338.5("Loading Skin " + this.Filename, 1341.Runtime, (1114)1);
		string text = "General";
		if (base.GetType() == typeof(1992))
		{
			text = "Mania";
		}
		else if (base.GetType() == typeof(1881))
		{
			text = "CatchTheBeat";
		}
		StreamReader streamReader = new StreamReader(File.OpenRead(1));
		try
		{
			int num = 0;
			2137 2 = null;
			while (streamReader.Peek() != -1)
			{
				num++;
				string text2 = streamReader.ReadLine();
				if (text2.StartsWith("["))
				{
					int num2 = text2.IndexOf(']');
					text = ((num2 < 0) ? text2.Trim(new char[]
					{
						'['
					}) : text2.Substring(1, num2 - 1));
					2 = ((text == "Mania") ? new 2137() : null);
				}
				else if (2 != null)
				{
					2.LoadLine(text, text2, num);
					string s = null;
					if (2.6<string>("Keys", ref s))
					{
						int num3;
						int.TryParse(s, out num3);
						if (num3 < 0 || num3 > 18)
						{
							num3 = 0;
						}
						this.ManiaSkins.Add(new 1992(num3));
						foreach (2629 3 in 2.currentSection)
						{
							this.ManiaSkins[this.ManiaSkins.Count - 1].LoadLine(text, 3.ToString(), 3.5);
						}
						2 = null;
					}
				}
				else if (!(text == "Mania"))
				{
					if (text == "CatchTheBeat")
					{
						this.1().LoadLine(text, text2, num);
					}
					else
					{
						this.LoadLine(text, text2, num);
					}
				}
				else
				{
					this.ManiaSkins[this.ManiaSkins.Count - 1].LoadLine(text, text2, num);
				}
			}
		}
		finally
		{
			((IDisposable)streamReader).Dispose();
		}
		this.ReadSettings();
		for (int i = 0; i < this.ManiaSkins.Count; i++)
		{
			this.ManiaSkins[i].ReadSettings();
		}
		this.1().ReadSettings();
		1338.5("Finished loading Skin", 1341.Runtime, (1114)1);
	}

	// Token: 0x0600228F RID: 8847 RVA: 0x00095A28 File Offset: 0x00093C28
	internal void 4(StreamWriter 1)
	{
		this.WriteSettings();
		foreach (KeyValuePair<string, 2621> keyValuePair in this.sections)
		{
			if (!keyValuePair.Value.1())
			{
				1.WriteLine("[" + keyValuePair.Key + "]");
				foreach (2629 2 in keyValuePair.Value)
				{
					1.WriteLine(2.ToString());
				}
			}
		}
		if (this.fruitsSkin != null)
		{
			this.fruitsSkin.4(1);
		}
		for (int i = 0; i < this.ManiaSkins.Count; i++)
		{
			this.ManiaSkins[i].4(1);
		}
	}

	// Token: 0x06002290 RID: 8848
	protected abstract void WriteSettings();

	// Token: 0x06002291 RID: 8849
	protected abstract void ReadSettings();

	// Token: 0x06002292 RID: 8850 RVA: 0x00095B28 File Offset: 0x00093D28
	protected void 5(string 1)
	{
		if (!this.sections.TryGetValue(1, out this.currentSection))
		{
			this.sections[1] = (this.currentSection = new 2621(this, 1));
		}
	}

	// Token: 0x06002293 RID: 8851 RVA: 0x00095B68 File Offset: 0x00093D68
	protected bool 6<T>(string 1, ref T 2)
	{
		if (this.currentSection == null)
		{
			throw new ArgumentException("No section is bound.");
		}
		object obj;
		if (this.currentSection.3(1, out obj, typeof(T)))
		{
			2 = (T)((object)obj);
			return true;
		}
		return false;
	}

	// Token: 0x06002294 RID: 8852 RVA: 0x00095BB4 File Offset: 0x00093DB4
	protected void 7<T>(Dictionary<string, T> 1)
	{
		if (this.currentSection == null)
		{
			throw new ArgumentException("No section is bound.");
		}
		foreach (string text in 1.Keys.ToList<string>())
		{
			object obj;
			if (this.currentSection.3(text, out obj, typeof(T)))
			{
				1[text] = (T)((object)obj);
			}
		}
	}

	// Token: 0x06002295 RID: 8853 RVA: 0x00095C40 File Offset: 0x00093E40
	protected void 8<T>(string 1, List<T> 2, 2626<T> 3)
	{
		if (this.currentSection == null)
		{
			throw new ArgumentException("No section is bound.");
		}
		object obj;
		if (!this.currentSection.3(1, out obj, typeof(List<T>)))
		{
			return;
		}
		List<T> list = (List<T>)obj;
		int num = (2.Count == 0) ? list.Count : Math.Min(list.Count, 2.Count);
		for (int i = 0; i < num; i++)
		{
			T t = (3 != null) ? 3(list[i]) : list[i];
			if (i == 2.Count)
			{
				2.Add(t);
			}
			else
			{
				2[i] = t;
			}
		}
	}

	// Token: 0x06002296 RID: 8854 RVA: 0x00095CE8 File Offset: 0x00093EE8
	protected Dictionary<string, T> 9<T>()
	{
		if (this.currentSection == null)
		{
			throw new ArgumentException("No section is bound.");
		}
		Dictionary<string, T> dictionary = new Dictionary<string, T>();
		foreach (KeyValuePair<string, string> keyValuePair in this.currentSection.4)
		{
			T value = default(T);
			if (this.6<T>(keyValuePair.Key, ref value))
			{
				dictionary[keyValuePair.Key] = value;
			}
		}
		return dictionary;
	}

	// Token: 0x06002297 RID: 8855 RVA: 0x00095D7C File Offset: 0x00093F7C
	protected void 10<T>(string 1, T 2, T 3, bool 4)
	{
		if (this.currentSection == null)
		{
			throw new ArgumentException("No section is bound.");
		}
		this.currentSection.7(1, 2, 3, typeof(T), 4);
	}

	// Token: 0x06002298 RID: 8856 RVA: 0x00095DB8 File Offset: 0x00093FB8
	protected void 11(string 1, string 2, bool 3)
	{
		if (this.currentSection == null)
		{
			throw new ArgumentException("No section is bound.");
		}
		object 4;
		object 5;
		Type 6;
		if (this.12(2, out 4, out 5, out 6))
		{
			this.currentSection.7(1, 4, 5, 6, 3);
		}
	}

	// Token: 0x06002299 RID: 8857 RVA: 0x00095DF8 File Offset: 0x00093FF8
	private bool 12(string 1, out object 2, out object 3, out Type 4)
	{
		2627.2628 CS_0024_003C_003E8__locals4 = new 2627.2628();
		CS_0024_003C_003E8__locals4.1 = 5;
		if (this.defaultSkin == null || base.GetType() != this.defaultSkin.GetType())
		{
			this.defaultSkin = (2627)Activator.CreateInstance(base.GetType(), new object[]
			{
				this
			});
			this.defaultProperties = new List<PropertyInfo>(base.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			this.defaultFields = new List<FieldInfo>(base.GetType().GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
		}
		PropertyInfo propertyInfo = this.defaultProperties.Find((PropertyInfo 1) => 1.Name == CS_0024_003C_003E8__locals4.1);
		FieldInfo fieldInfo = this.defaultFields.Find((FieldInfo 1) => 1.Name == CS_0024_003C_003E8__locals4.1);
		if (propertyInfo != null)
		{
			2 = propertyInfo.GetValue(this, null);
			3 = propertyInfo.GetValue(this.defaultSkin, null);
			4 = propertyInfo.PropertyType;
		}
		else
		{
			if (!(fieldInfo != null))
			{
				object obj;
				3 = (obj = null);
				2 = obj;
				4 = null;
				1338.5("Error writing " + this.Filename + ": Property not found: " + CS_0024_003C_003E8__locals4.1, 1341.Runtime, (1114)1);
				return false;
			}
			2 = fieldInfo.GetValue(this);
			3 = fieldInfo.GetValue(this.defaultSkin);
			4 = fieldInfo.FieldType;
		}
		return true;
	}

	// Token: 0x0600229A RID: 8858 RVA: 0x00095F50 File Offset: 0x00094150
	protected void 13<T>(string 1)
	{
		if (this.currentSection == null)
		{
			throw new ArgumentException("No section is bound.");
		}
		object obj;
		object obj2;
		Type type;
		if (!this.12(1, out obj, out obj2, out type))
		{
			return;
		}
		Dictionary<string, T> dictionary = (Dictionary<string, T>)obj;
		Dictionary<string, T> dictionary2 = (Dictionary<string, T>)obj2;
		foreach (string text in dictionary2.Keys)
		{
			this.currentSection.7(text, dictionary[text], dictionary2[text], typeof(T), false);
		}
	}

	// Token: 0x0600229B RID: 8859 RVA: 0x00096004 File Offset: 0x00094204
	protected virtual void LoadLine(string 1, string 2, int 3)
	{
		if (!2.StartsWith("["))
		{
			this.5(1);
			this.currentSection.2(2, 3);
		}
	}

	// Token: 0x040017F4 RID: 6132
	internal List<1992> ManiaSkins = new List<1992>();

	// Token: 0x040017F5 RID: 6133
	private 1881 fruitsSkin;

	// Token: 0x040017F6 RID: 6134
	internal string Filename;

	// Token: 0x040017F7 RID: 6135
	private Dictionary<string, 2621> sections = new Dictionary<string, 2621>();

	// Token: 0x040017F8 RID: 6136
	private 2621 currentSection;

	// Token: 0x040017F9 RID: 6137
	private 2627 defaultSkin;

	// Token: 0x040017FA RID: 6138
	private List<PropertyInfo> defaultProperties;

	// Token: 0x040017FB RID: 6139
	private List<FieldInfo> defaultFields;

	// Token: 0x040017FC RID: 6140
	internal bool AllowTransparentColours = true;

	// Token: 0x0200046C RID: 1132
	public sealed class 2628
	{
		// Token: 0x040017FD RID: 6141
		public string 1;
	}
}
