using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;

// Token: 0x020002DC RID: 732
[ComVisible(false)]
public sealed class 357 : 495
{
	// Token: 0x060015F2 RID: 5618 RVA: 0x0004BC85 File Offset: 0x00049E85
	public 357(string 1)
	{
		this.text2 = 1;
		this.arrayList2 = new ArrayList();
		this.arrayList3 = new ArrayList();
		this.Method1485();
	}

	// Token: 0x060015F3 RID: 5619 RVA: 0x0004BCB0 File Offset: 0x00049EB0
	public static bool Method1479(string 1)
	{
		bool result = true;
		try
		{
			new Regex(1, RegexOptions.IgnoreCase | RegexOptions.Singleline);
		}
		catch (ArgumentException)
		{
			result = false;
		}
		return result;
	}

	// Token: 0x060015F4 RID: 5620 RVA: 0x0004BCE0 File Offset: 0x00049EE0
	public static bool Method1480(string 1)
	{
		bool result = true;
		try
		{
			if (1 != null)
			{
				string[] array = 357.Method1481(1);
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i] != null && array[i].Length > 0)
					{
						new Regex((array[i][0] == '+') ? array[i].Substring(1, array[i].Length - 1) : ((array[i][0] != '-') ? array[i] : array[i].Substring(1, array[i].Length - 1)), RegexOptions.IgnoreCase | RegexOptions.Singleline);
					}
				}
			}
		}
		catch (ArgumentException)
		{
			result = false;
		}
		return result;
	}

	// Token: 0x060015F5 RID: 5621 RVA: 0x0004BD80 File Offset: 0x00049F80
	public static string[] Method1481(string 1)
	{
		char c = '\\';
		char[] array = new char[]
		{
			';'
		};
		ArrayList arrayList = new ArrayList();
		if (1 != null && 1.Length > 0)
		{
			int i = -1;
			StringBuilder stringBuilder = new StringBuilder();
			while (i < 1.Length)
			{
				i++;
				if (i >= 1.Length)
				{
					arrayList.Add(stringBuilder.ToString());
				}
				else if (1[i] == c)
				{
					i++;
					if (i >= 1.Length)
					{
						throw new ArgumentException("Missing terminating escape character", "#=zcep$eNQ=");
					}
					if (Array.IndexOf<char>(array, 1[i]) < 0)
					{
						stringBuilder.Append(c);
					}
					stringBuilder.Append(1[i]);
				}
				else if (Array.IndexOf<char>(array, 1[i]) >= 0)
				{
					arrayList.Add(stringBuilder.ToString());
					stringBuilder.Length = 0;
				}
				else
				{
					stringBuilder.Append(1[i]);
				}
			}
		}
		return (string[])arrayList.ToArray(typeof(string));
	}

	// Token: 0x060015F6 RID: 5622 RVA: 0x0004BE8B File Offset: 0x0004A08B
	public override string ToString()
	{
		return this.text2;
	}

	// Token: 0x060015F7 RID: 5623 RVA: 0x0004BE94 File Offset: 0x0004A094
	public bool Method1482(string 1)
	{
		bool result = false;
		if (this.arrayList2.Count == 0)
		{
			result = true;
		}
		else
		{
			using (IEnumerator enumerator = this.arrayList2.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (((Regex)enumerator.Current).IsMatch(1))
					{
						result = true;
						break;
					}
				}
			}
		}
		return result;
	}

	// Token: 0x060015F8 RID: 5624 RVA: 0x0004BF08 File Offset: 0x0004A108
	public bool Method1483(string 1)
	{
		bool result = false;
		using (IEnumerator enumerator = this.arrayList3.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (((Regex)enumerator.Current).IsMatch(1))
				{
					result = true;
					break;
				}
			}
		}
		return result;
	}

	// Token: 0x060015F9 RID: 5625 RVA: 0x0004BF68 File Offset: 0x0004A168
	public bool Method11363(string 1)
	{
		return this.Method1482(1) && !this.Method1483(1);
	}

	// Token: 0x060015FA RID: 5626 RVA: 0x0004BF80 File Offset: 0x0004A180
	private void Method1485()
	{
		if (this.text2 == null)
		{
			return;
		}
		string[] array = 357.Method1481(this.text2);
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i] != null && array[i].Length > 0)
			{
				bool flag = array[i][0] != '-';
				string pattern = (array[i][0] == '+') ? array[i].Substring(1, array[i].Length - 1) : ((array[i][0] != '-') ? array[i] : array[i].Substring(1, array[i].Length - 1));
				if (flag)
				{
					this.arrayList2.Add(new Regex(pattern, RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.Singleline));
				}
				else
				{
					this.arrayList3.Add(new Regex(pattern, RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.Singleline));
				}
			}
		}
	}

	// Token: 0x04000A62 RID: 2658
	private string text2;

	// Token: 0x04000A63 RID: 2659
	private ArrayList arrayList2;

	// Token: 0x04000A64 RID: 2660
	private ArrayList arrayList3;
}
