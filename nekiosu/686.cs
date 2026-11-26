using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

// Token: 0x0200030D RID: 781
[ComVisible(false)]
public sealed class 686 : 381
{
	// Token: 0x06001766 RID: 5990 RVA: 0x000055AC File Offset: 0x000037AC
	public 686()
	{
	}

	// Token: 0x06001767 RID: 5991 RVA: 0x00050934 File Offset: 0x0004EB34
	public 686(string 1)
	{
		this.Method10311(1);
	}

	// Token: 0x06001768 RID: 5992 RVA: 0x00050944 File Offset: 0x0004EB44
	static 686()
	{
		char[] invalidPathChars = Path.GetInvalidPathChars();
		int num = invalidPathChars.Length + 2;
		686.charArray2 = new char[num];
		Array.Copy(invalidPathChars, 0, 686.charArray2, 0, invalidPathChars.Length);
		686.charArray2[num - 1] = '*';
		686.charArray2[num - 2] = '?';
		num = invalidPathChars.Length + 4;
		686.charArray = new char[num];
		Array.Copy(invalidPathChars, 0, 686.charArray, 0, invalidPathChars.Length);
		686.charArray[num - 1] = ':';
		686.charArray[num - 2] = '\\';
		686.charArray[num - 3] = '*';
		686.charArray[num - 4] = '?';
	}

	// Token: 0x06001769 RID: 5993 RVA: 0x000509DB File Offset: 0x0004EBDB
	public string Method10308(string 1)
	{
		1 = this.Method10309(1);
		if (1.Length > 0)
		{
			if (!1.EndsWith("/"))
			{
				1 += "/";
			}
			return 1;
		}
		throw new 415("Cannot have an empty directory name");
	}

	// Token: 0x0600176A RID: 5994 RVA: 0x00050A18 File Offset: 0x0004EC18
	public string Method10309(string 1)
	{
		if (1 != null)
		{
			string text = 1.ToLower();
			if (this.text3 != null && text.IndexOf(this.text3) == 0)
			{
				1 = 1.Substring(this.text3.Length);
			}
			1 = 1.Replace('\\', '/');
			1 = 720.Method11154(1);
			while (1.Length > 0)
			{
				if (1[0] != '/')
				{
					break;
				}
				1 = 1.Remove(0, 1);
			}
			while (1.Length > 0 && 1[1.Length - 1] == '/')
			{
				1 = 1.Remove(1.Length - 1, 1);
			}
			for (int i = 1.IndexOf("//"); i >= 0; i = 1.IndexOf("//"))
			{
				1 = 1.Remove(i, 1);
			}
			1 = 686.Method10312(1, '_');
		}
		else
		{
			1 = string.Empty;
		}
		return 1;
	}

	// Token: 0x0600176B RID: 5995 RVA: 0x00050AF9 File Offset: 0x0004ECF9
	public string GetText8064_10310()
	{
		return this.text3;
	}

	// Token: 0x0600176C RID: 5996 RVA: 0x00050B01 File Offset: 0x0004ED01
	public void Method10311(string 1)
	{
		this.text3 = 1;
		if (this.text3 != null)
		{
			this.text3 = this.text3.ToLower();
		}
	}

	// Token: 0x0600176D RID: 5997 RVA: 0x00050B24 File Offset: 0x0004ED24
	private static string Method10312(string 1, char 2)
	{
		int i = 1.IndexOfAny(686.charArray);
		if (i >= 0)
		{
			StringBuilder stringBuilder = new StringBuilder(1);
			while (i >= 0)
			{
				stringBuilder[i] = 2;
				i = ((i < 1.Length) ? 1.IndexOfAny(686.charArray, i + 1) : -1);
			}
			1 = stringBuilder.ToString();
		}
		if (1.Length > 65535)
		{
			throw new PathTooLongException();
		}
		return 1;
	}

	// Token: 0x0600176E RID: 5998 RVA: 0x00050B90 File Offset: 0x0004ED90
	public static bool Method10313(string 1, bool 2)
	{
		bool flag = 1 != null;
		if (flag)
		{
			flag = ((!2) ? (1.IndexOfAny(686.charArray) < 0 && 1.IndexOf('/') != 0) : (1.IndexOfAny(686.charArray2) < 0));
		}
		return flag;
	}

	// Token: 0x0600176F RID: 5999 RVA: 0x00050BD6 File Offset: 0x0004EDD6
	public static bool Method10313(string 1)
	{
		return 1 != null && 1.IndexOfAny(686.charArray) < 0 && 1.IndexOf('/') != 0;
	}

	// Token: 0x04000AEC RID: 2796
	private string text3;

	// Token: 0x04000AED RID: 2797
	private static readonly char[] charArray;

	// Token: 0x04000AEE RID: 2798
	private static readonly char[] charArray2;
}
