using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

// Token: 0x02000474 RID: 1140
public sealed class 2621 : IEnumerable<2629>, IEnumerable
{
	// Token: 0x060022C6 RID: 8902 RVA: 0x00096E1D File Offset: 0x0009501D
	internal 2621(2627 1, string 2)
	{
		this.1 = 1;
		this.3 = 2;
	}

	// Token: 0x060022C7 RID: 8903 RVA: 0x00096E49 File Offset: 0x00095049
	internal bool 1()
	{
		return this.2.Count == 0;
	}

	// Token: 0x060022C8 RID: 8904 RVA: 0x00096E5C File Offset: 0x0009505C
	internal void 2(string 1, int 2)
	{
		if (1 != null)
		{
			1 = 1.Trim();
			2629 3 = new 2629(1, 2);
			this.2.Add(3);
			if (!this.4.ContainsKey(3.3) && !string.IsNullOrEmpty(1) && !3.1)
			{
				this.4.Add(3.3, 3.4);
			}
		}
	}

	// Token: 0x060022C9 RID: 8905 RVA: 0x00096EC4 File Offset: 0x000950C4
	internal bool 3(string 1, out object 2, Type 3)
	{
		2 = this.8(3);
		string value;
		if (!this.4.TryGetValue(1, out value))
		{
			return false;
		}
		if (string.IsNullOrEmpty(value) && 2 != null)
		{
			this.4("Value is empty", 1);
			return false;
		}
		if (!this.5(value, ref 2, 3))
		{
			this.4("Expected type " + 3.Name.ToLower(), 1);
			return false;
		}
		return true;
	}

	// Token: 0x060022CA RID: 8906 RVA: 0x00096F30 File Offset: 0x00095130
	private void 4(string 1, string 2)
	{
		2621.2623 3 = new 2621.2623();
		3.1 = 2;
		string text = ("[" + this.3 + "]").PadRight(14);
		string text2 = (this.2.Find(new Predicate<2629>(3.1)).5.ToString() + ":").PadRight(4);
		1338.5(string.Concat(new string[]
		{
			"Error in ",
			text,
			" Line ",
			text2,
			" ",
			1,
			" (name = ",
			3.1,
			")"
		}), 1341.Runtime, (1114)3);
		1662.89.3(new 1189(2621.2622.instance.1));
	}

	// Token: 0x060022CB RID: 8907 RVA: 0x00097004 File Offset: 0x00095204
	internal bool 5(string 1, ref object 2, Type 3)
	{
		Type type = Nullable.GetUnderlyingType(3) ?? 3;
		Type left = 3.IsGenericType ? 3.GetGenericTypeDefinition() : null;
		try
		{
			if (string.IsNullOrEmpty(1) && this.8(3) == null)
			{
				2 = null;
			}
			else if (left == typeof(List<>))
			{
				IList list = (IList)Activator.CreateInstance(3);
				Type type2 = 3.GetGenericArguments()[0];
				foreach (string text in 1.Split(new char[]
				{
					','
				}))
				{
					object value = this.8(type2);
					this.5(text, ref value, type2);
					list.Add(value);
				}
				2 = list;
			}
			else if (type == typeof(198))
			{
				string[] array2 = 1.Split(new char[]
				{
					','
				});
				int i = array2.Length;
				if (i == 3)
				{
					2 = Convert.ChangeType(new 198((byte)Convert.ToInt32(array2[0]), (byte)Convert.ToInt32(array2[1]), (byte)Convert.ToInt32(array2[2])), type, 1662.18);
					return true;
				}
				if (i != 4)
				{
					return false;
				}
				2 = Convert.ChangeType(new 198((byte)Convert.ToInt32(array2[0]), (byte)Convert.ToInt32(array2[1]), (byte)Convert.ToInt32(array2[2]), (byte)(this.1.AllowTransparentColours ? Convert.ToInt32(array2[3]) : 255)), type, 1662.18);
				return true;
			}
			else if (type == typeof(bool))
			{
				bool flag;
				if (bool.TryParse(1, out flag))
				{
					2 = Convert.ChangeType(flag, type, 1662.18);
				}
				else
				{
					2 = Convert.ChangeType(Convert.ToInt32(1), type, 1662.18);
				}
			}
			else if (type.IsEnum)
			{
				2 = Enum.Parse(type, 1, true);
			}
			else
			{
				2 = Convert.ChangeType(1, type, 1662.18);
			}
		}
		catch
		{
			return false;
		}
		return true;
	}

	// Token: 0x060022CC RID: 8908 RVA: 0x00097230 File Offset: 0x00095430
	internal string 6(object 1, Type 2)
	{
		2621.2624 3 = new 2621.2624();
		3.1 = this;
		if (1 == null)
		{
			return null;
		}
		Type left = Nullable.GetUnderlyingType(2) ?? 2;
		if ((2.IsGenericType ? 2.GetGenericTypeDefinition() : null) == typeof(List<>))
		{
			List<object> list = (1 as IEnumerable).Cast<object>().ToList<object>();
			3.2 = 2.GetGenericArguments()[0];
			return string.Join(",", list.ConvertAll<string>(new Converter<object, string>(3.1)));
		}
		if (left == typeof(198))
		{
			198? 4 = 1 as 198?;
			return string.Format("{0},{1},{2}" + (this.1.AllowTransparentColours ? ",{3}" : string.Empty), new object[]
			{
				4.Value.R,
				4.Value.G,
				4.Value.B,
				4.Value.A
			});
		}
		if (left == typeof(bool))
		{
			return Convert.ToInt32(1).ToString(1662.18);
		}
		if (left == typeof(double) || left == typeof(float))
		{
			return Convert.ToDouble(1).ToString(1662.18);
		}
		return 1.ToString();
	}

	// Token: 0x060022CD RID: 8909 RVA: 0x000973C0 File Offset: 0x000955C0
	internal void 7(string 1, object 2, object 3, Type 4, bool 5)
	{
		2621.2625 CS_0024_003C_003E8__locals6 = new 2621.2625();
		CS_0024_003C_003E8__locals6.1 = 7;
		object obj;
		2629 6;
		if (this.3(CS_0024_003C_003E8__locals6.1, out obj, 4) && (6 = this.2.Find((2629 1) => 1.3 == CS_0024_003C_003E8__locals6.1)) != null)
		{
			if (this.6(obj, 4) != this.6(2, 4))
			{
				6.4 = this.6(2, 4);
			}
		}
		else if ((3 == null && 2 != null) || this.6(2, 4) != this.6(3, 4))
		{
			if (5)
			{
				this.2.Insert(0, new 2629(CS_0024_003C_003E8__locals6.1, this.6(2, 4)));
			}
			else
			{
				this.2.Add(new 2629(CS_0024_003C_003E8__locals6.1, this.6(2, 4)));
			}
		}
		this.4[CS_0024_003C_003E8__locals6.1] = this.6(2, 4);
	}

	// Token: 0x060022CE RID: 8910 RVA: 0x000974D3 File Offset: 0x000956D3
	private object 8(Type 1)
	{
		if (1.IsValueType)
		{
			return Activator.CreateInstance(1, true);
		}
		return null;
	}

	// Token: 0x060022CF RID: 8911 RVA: 0x000974E6 File Offset: 0x000956E6
	public IEnumerator<2629> GetEnumerator()
	{
		return this.2.GetEnumerator();
	}

	// Token: 0x060022D0 RID: 8912 RVA: 0x000974F8 File Offset: 0x000956F8
	private IEnumerator 9()
	{
		return this.GetEnumerator();
	}

	// Token: 0x060022D1 RID: 8913 RVA: 0x00097500 File Offset: 0x00095700
	IEnumerator IEnumerable.GetEnumerator()
	{
		return this.9();
	}

	// Token: 0x0400181B RID: 6171
	private 2627 1;

	// Token: 0x0400181C RID: 6172
	private List<2629> 2 = new List<2629>();

	// Token: 0x0400181D RID: 6173
	internal string 3;

	// Token: 0x0400181E RID: 6174
	internal Dictionary<string, string> 4 = new Dictionary<string, string>();

	// Token: 0x02000475 RID: 1141
	public sealed class 2625
	{
		// Token: 0x0400181F RID: 6175
		public string 1;
	}

	// Token: 0x02000476 RID: 1142
	[Serializable]
	public sealed class 2622
	{
		// Token: 0x060022D3 RID: 8915 RVA: 0x00097508 File Offset: 0x00095708
		internal void 1()
		{
			1763.6(new 1489(1568.1(2679.Skin_ErrorEncountered), 10000, 198.Red, new 1189(2621.2622.instance.2)));
		}

		// Token: 0x060022D4 RID: 8916 RVA: 0x00097538 File Offset: 0x00095738
		internal void 2()
		{
			1804.5(1338.7(1341.Runtime, false).10(), null);
		}

		// Token: 0x04001820 RID: 6176
		public static readonly 2621.2622 instance = new 2621.2622();

		// Token: 0x04001821 RID: 6177
		public static 1189 voidDelegate;

		// Token: 0x04001822 RID: 6178
		public static 1189 voidDelegate2;
	}

	// Token: 0x02000477 RID: 1143
	public sealed class 2623
	{
		// Token: 0x060022D7 RID: 8919 RVA: 0x00097558 File Offset: 0x00095758
		internal bool 1(2629 1)
		{
			return 1.3 == this.1;
		}

		// Token: 0x04001823 RID: 6179
		public string 1;
	}

	// Token: 0x02000478 RID: 1144
	public sealed class 2624
	{
		// Token: 0x060022D9 RID: 8921 RVA: 0x0009756B File Offset: 0x0009576B
		internal string 1(object 1)
		{
			return this.1.6(1, this.2);
		}

		// Token: 0x04001824 RID: 6180
		public 2621 1;

		// Token: 0x04001825 RID: 6181
		public Type 2;
	}
}
