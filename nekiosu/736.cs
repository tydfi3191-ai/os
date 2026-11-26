using System;
using System.Diagnostics;
using System.Globalization;
using System.Text.RegularExpressions;

// Token: 0x020001AF RID: 431
[241(0)]
[242(1)]
public static class 736
{
	// Token: 0x06000DD8 RID: 3544 RVA: 0x00005ADD File Offset: 0x00003CDD
	[Conditional("DEBUG")]
	[242(2)]
	public static void Method11627([58(false)] bool 1, string 2)
	{
	}

	// Token: 0x06000DD9 RID: 3545 RVA: 0x0002F75C File Offset: 0x0002D95C
	[242(2)]
	public static bool Method11628(object 1, object 2)
	{
		if (1 == 2)
		{
			return true;
		}
		if (1 == null || 2 == null)
		{
			return false;
		}
		if (!(1.GetType() != 2.GetType()))
		{
			return 1.Equals(2);
		}
		if (358.Method1504(1) && 358.Method1504(2))
		{
			return Convert.ToDecimal(1, CultureInfo.CurrentCulture).Equals(Convert.ToDecimal(2, CultureInfo.CurrentCulture));
		}
		return (1 is double || 1 is float || 1 is decimal) && (2 is double || 2 is float || 2 is decimal) && 421.Method3216(Convert.ToDouble(1, CultureInfo.CurrentCulture), Convert.ToDouble(2, CultureInfo.CurrentCulture));
	}

	// Token: 0x06000DDA RID: 3546 RVA: 0x0002F810 File Offset: 0x0002DA10
	public static ArgumentOutOfRangeException Method11629(string 1, object 2, string 3)
	{
		string message = 3 + Environment.NewLine + "Actual value was {0}.".Method6825(CultureInfo.InvariantCulture, 2);
		return new ArgumentOutOfRangeException(1, message);
	}

	// Token: 0x06000DDB RID: 3547 RVA: 0x0002F840 File Offset: 0x0002DA40
	public static string Method11630([241(2)] object 1)
	{
		if (1 == null)
		{
			return "{null}";
		}
		string text = 1 as string;
		if (text == null)
		{
			return 1.ToString();
		}
		return "\"" + text + "\"";
	}

	// Token: 0x06000DDC RID: 3548 RVA: 0x0002F878 File Offset: 0x0002DA78
	public static int Method11631(byte[] 1, byte[] 2)
	{
		int num = 1.Length.CompareTo(2.Length);
		if (num != 0)
		{
			return num;
		}
		for (int i = 0; i < 1.Length; i++)
		{
			int num2 = 1[i].CompareTo(2[i]);
			if (num2 != 0)
			{
				return num2;
			}
		}
		return 0;
	}

	// Token: 0x06000DDD RID: 3549 RVA: 0x0002F8C0 File Offset: 0x0002DAC0
	[return: 241(2)]
	public static string Method11632(string 1)
	{
		string result;
		string text;
		736.Method11634(1, out result, out text);
		return result;
	}

	// Token: 0x06000DDE RID: 3550 RVA: 0x0002F8D8 File Offset: 0x0002DAD8
	public static string Method11633(string 1)
	{
		string text;
		string result;
		736.Method11634(1, out text, out result);
		return result;
	}

	// Token: 0x06000DDF RID: 3551 RVA: 0x0002F8F0 File Offset: 0x0002DAF0
	public static void Method11634(string 1, [241(2)] out string 2, out string 3)
	{
		int num = 538.Method6841(1, ':');
		if (num == -1 || num == 0 || 1.Length - 1 == num)
		{
			2 = null;
			3 = 1;
			return;
		}
		2 = 1.Substring(0, num);
		3 = 1.Substring(num + 1);
	}

	// Token: 0x06000DE0 RID: 3552 RVA: 0x0002F934 File Offset: 0x0002DB34
	internal static RegexOptions Method11635(string 1)
	{
		RegexOptions regexOptions = RegexOptions.None;
		foreach (char c in 1)
		{
			if (c <= 'm')
			{
				if (c != 'i')
				{
					if (c == 'm')
					{
						regexOptions |= RegexOptions.Multiline;
					}
				}
				else
				{
					regexOptions |= RegexOptions.IgnoreCase;
				}
			}
			else if (c != 's')
			{
				if (c == 'x')
				{
					regexOptions |= RegexOptions.ExplicitCapture;
				}
			}
			else
			{
				regexOptions |= RegexOptions.Singleline;
			}
		}
		return regexOptions;
	}
}
