using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;

// Token: 0x02000A2E RID: 2606
[ComVisible(false)]
public static class 1568
{
	// Token: 0x06004833 RID: 18483 RVA: 0x001CAB1C File Offset: 0x001C8D1C
	public static string 1(2679 1)
	{
		if (!1568.2)
		{
			1568.3(string.Empty);
		}
		string result;
		try
		{
			string text;
			result = (1568.1.TryGetValue(1, out text) ? text : string.Empty);
		}
		catch
		{
			result = string.Empty;
		}
		return result;
	}

	// Token: 0x06004834 RID: 18484 RVA: 0x001CAB70 File Offset: 0x001C8D70
	public static bool 2(string 1, bool 2, 1189 3, string 4)
	{
		1568.1569 5 = new 1568.1569();
		5.2 = 3;
		5.3 = 4;
		5.5 = 1;
		Thread currentThread = Thread.CurrentThread;
		if (string.IsNullOrEmpty(5.5) || 5.5 == "unknown")
		{
			string name = currentThread.CurrentUICulture.Name;
			string text = name.Substring(0, 2);
			if (!(text == "ms") && !(text == "vi") && !(text == "zh"))
			{
				5.5 = text;
			}
			else
			{
				5.5 = name;
			}
		}
		1568.2 = false;
		1568.3 = 5.5;
		if ((5.5 == "en" || !2) && 1568.3(5.3))
		{
			try
			{
				currentThread.CurrentUICulture = new CultureInfo(5.5);
			}
			catch
			{
			}
			if (5.2 != null)
			{
				5.2();
			}
			return true;
		}
		5.1 = Path.Combine("Localisation", 5.5 + ".txt");
		5.4 = 5.1 + ".new";
		1620 6 = new 1620(5.4, string.Concat(new string[]
		{
			1336.3,
			"Localisation/",
			5.5,
			".txt?",
			DateTime.Today.ToFileTimeUtc().ToString()
		}));
		6.9(new 1621.1622(5.1));
		6.Start();
		return false;
	}

	// Token: 0x06004835 RID: 18485 RVA: 0x001CAD18 File Offset: 0x001C8F18
	private static bool 3(string 1)
	{
		Dictionary<2679, string> obj = 1568.1;
		bool result;
		lock (obj)
		{
			if (1568.2)
			{
				result = true;
			}
			else
			{
				try
				{
					1568.1.Clear();
					if (!string.IsNullOrEmpty(1))
					{
						1568.4(1);
					}
					else
					{
						1568.5("en");
					}
					if (1568.3 == "en")
					{
						result = true;
					}
					else
					{
						result = 1568.5(1568.3);
					}
				}
				finally
				{
					1568.2 = true;
				}
			}
		}
		return result;
	}

	// Token: 0x06004836 RID: 18486 RVA: 0x001CADB8 File Offset: 0x001C8FB8
	private static bool 4(string 1)
	{
		StringReader stringReader = new StringReader(1);
		try
		{
			while (stringReader.Peek() != -1)
			{
				string text = stringReader.ReadLine();
				int num = text.IndexOf('=');
				2679 key;
				if (num > 0 && Enum.TryParse<2679>(text.Remove(num), false, out key))
				{
					1568.1[key] = text.Substring(num + 1).Replace("\\n", "\n");
				}
			}
		}
		finally
		{
			((IDisposable)stringReader).Dispose();
		}
		return true;
	}

	// Token: 0x06004837 RID: 18487 RVA: 0x001CAE3C File Offset: 0x001C903C
	private static bool 5(string 1)
	{
		string path = Path.Combine("Localisation", 1 + ".txt");
		if (!File.Exists(path))
		{
			return false;
		}
		try
		{
			1568.4(File.ReadAllText(path));
		}
		catch
		{
			return false;
		}
		return true;
	}

	// Token: 0x04003541 RID: 13633
	private static Dictionary<2679, string> 1 = new Dictionary<2679, string>();

	// Token: 0x04003542 RID: 13634
	public static bool 2;

	// Token: 0x04003543 RID: 13635
	public static string 3 = string.Empty;

	// Token: 0x02000A2F RID: 2607
	public sealed class 1569
	{
		// Token: 0x06004839 RID: 18489 RVA: 0x001CAEA8 File Offset: 0x001C90A8
		internal void 1(1621 1, Exception 2)
		{
			if (2 != null)
			{
				if (!File.Exists(this.1))
				{
					new Thread(new ThreadStart(this.2))
					{
						IsBackground = true
					}.Start();
					return;
				}
			}
			else
			{
				2672.16(this.4, this.1, true);
			}
			1568.2(this.5, false, this.2, this.3);
		}

		// Token: 0x0600483A RID: 18490 RVA: 0x001CAF10 File Offset: 0x001C9110
		internal void 2()
		{
			try
			{
				Thread.Sleep(1000);
				1568.2(null, false, this.2, this.3);
			}
			catch (Exception ex)
			{
				1338.4(ex, "loading the language", 1341.Runtime);
			}
		}

		// Token: 0x04003544 RID: 13636
		public string 1;

		// Token: 0x04003545 RID: 13637
		public 1189 2;

		// Token: 0x04003546 RID: 13638
		public string 3;

		// Token: 0x04003547 RID: 13639
		public string 4;

		// Token: 0x04003548 RID: 13640
		public string 5;
	}
}
