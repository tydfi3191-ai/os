using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

// Token: 0x02000B42 RID: 2882
[ComVisible(false)]
public sealed class 1301 : IDisposable
{
	// Token: 0x06004F80 RID: 20352 RVA: 0x001F5FCB File Offset: 0x001F41CB
	public 1301(string 1, bool 2 = false, bool 3 = false)
	{
		this.1 = 3;
		this.4(1, 2);
	}

	// Token: 0x06004F81 RID: 20353 RVA: 0x001F5FF8 File Offset: 0x001F41F8
	public bool 1()
	{
		return this.6;
	}

	// Token: 0x06004F82 RID: 20354 RVA: 0x001F6000 File Offset: 0x001F4200
	~1301()
	{
		this.Dispose();
	}

	// Token: 0x06004F83 RID: 20355 RVA: 0x001F602C File Offset: 0x001F422C
	public void Dispose()
	{
		if (this.5)
		{
			this.Save();
		}
	}

	// Token: 0x06004F84 RID: 20356 RVA: 0x001F603C File Offset: 0x001F423C
	public T 2<T>(string 1, T 2)
	{
		object obj;
		if (this.3.TryGetValue(1, out obj))
		{
			return (T)((object)obj);
		}
		string text;
		if (!this.2.TryGetValue(1, out text))
		{
			this.3<T>(1, 2);
			return 2;
		}
		string name = typeof(T).Name;
		if (this.1)
		{
			if (!(name == "Boolean"))
			{
				if (!(name == "Int32"))
				{
					if (!(name == "Int64"))
					{
						if (!(name == "Double"))
						{
							if (name == "String")
							{
								obj = text;
							}
						}
						else
						{
							obj = double.Parse(text, NumberFormatInfo.InvariantInfo);
						}
					}
					else
					{
						obj = long.Parse(text, NumberFormatInfo.InvariantInfo);
					}
				}
				else
				{
					obj = int.Parse(text, NumberFormatInfo.InvariantInfo);
				}
			}
			else
			{
				obj = (text[0] == '1');
			}
		}
		else if (!(name == "Boolean"))
		{
			if (!(name == "Int32"))
			{
				if (!(name == "Int64"))
				{
					if (!(name == "Double"))
					{
						if (name == "String")
						{
							obj = text;
						}
					}
					else
					{
						obj = double.Parse(text);
					}
				}
				else
				{
					obj = long.Parse(text);
				}
			}
			else
			{
				obj = int.Parse(text);
			}
		}
		else
		{
			obj = (text[0] == '1');
		}
		this.3[1] = obj;
		this.2[1] = text;
		return (T)((object)obj);
	}

	// Token: 0x06004F85 RID: 20357 RVA: 0x001F61DC File Offset: 0x001F43DC
	public void 3<T>(string 1, T 2)
	{
		if (!(typeof(T).Name == "Boolean"))
		{
			Dictionary<string, string> dictionary = this.2;
			ref T ptr = ref 2;
			T t = default(T);
			string value;
			if (t == null)
			{
				t = 2;
				ptr = ref t;
				if (t == null)
				{
					value = null;
					goto IL_53;
				}
			}
			value = ptr.ToString();
			IL_53:
			dictionary[1] = value;
		}
		else
		{
			this.2[1] = ((2.ToString() == "True") ? "1" : "0");
		}
		this.3[1] = 2;
		this.5 = true;
		if (this.1())
		{
			this.Save();
		}
	}

	// Token: 0x06004F86 RID: 20358 RVA: 0x001F629B File Offset: 0x001F449B
	public void 4(string 1, bool 2)
	{
		this.2.Clear();
		this.3.Clear();
		if (this.5(1) || 2)
		{
			this.4 = 1;
		}
	}

	// Token: 0x06004F87 RID: 20359 RVA: 0x001F62C8 File Offset: 0x001F44C8
	private bool 5(string 1)
	{
		if (!File.Exists(1))
		{
			return false;
		}
		try
		{
			using (StreamReader streamReader = File.OpenText(1))
			{
				while (!streamReader.EndOfStream)
				{
					string text = streamReader.ReadLine();
					if (text.Length >= 2 && !text.StartsWith("#"))
					{
						int num = text.IndexOf('=');
						string key = text.Remove(num).Trim();
						string value = text.Substring(num + 1).Trim();
						this.2[key] = value;
					}
				}
			}
		}
		catch
		{
		}
		return true;
	}

	// Token: 0x06004F88 RID: 20360 RVA: 0x001F6370 File Offset: 0x001F4570
	public void Save()
	{
		if (this.4 != null)
		{
			this.6(this.4);
			this.5 = false;
		}
	}

	// Token: 0x06004F89 RID: 20361 RVA: 0x001F6390 File Offset: 0x001F4590
	private bool 6(string 1)
	{
		if (this.1)
		{
			throw new InvalidOperationException("Saving is not supported when in culture invariant mode");
		}
		try
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (KeyValuePair<string, string> keyValuePair in this.2)
			{
				stringBuilder.AppendLine(keyValuePair.Key + " = " + keyValuePair.Value);
			}
			File.WriteAllText(1, stringBuilder.ToString());
		}
		catch
		{
			return false;
		}
		return true;
	}

	// Token: 0x04003B7D RID: 15229
	private readonly bool 1;

	// Token: 0x04003B7E RID: 15230
	private readonly Dictionary<string, string> 2 = new Dictionary<string, string>();

	// Token: 0x04003B7F RID: 15231
	private readonly Dictionary<string, object> 3 = new Dictionary<string, object>();

	// Token: 0x04003B80 RID: 15232
	private string 4;

	// Token: 0x04003B81 RID: 15233
	private bool 5;

	// Token: 0x04003B82 RID: 15234
	private bool 6;
}
