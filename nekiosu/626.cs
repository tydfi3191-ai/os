using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

// Token: 0x02000301 RID: 769
[ComVisible(false)]
public sealed class 626 : 381
{
	// Token: 0x060016FD RID: 5885 RVA: 0x0004F842 File Offset: 0x0004DA42
	public 626(string 1)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("#=z0LIiYuMM1PrE", "Directory name is invalid");
		}
		this.Method9053(1);
	}

	// Token: 0x060016FE RID: 5886 RVA: 0x0004F86C File Offset: 0x0004DA6C
	public 626()
	{
	}

	// Token: 0x060016FF RID: 5887 RVA: 0x0004F87C File Offset: 0x0004DA7C
	static 626()
	{
		char[] invalidPathChars = Path.GetInvalidPathChars();
		int num = invalidPathChars.Length + 3;
		626.charArray = new char[num];
		Array.Copy(invalidPathChars, 0, 626.charArray, 0, invalidPathChars.Length);
		626.charArray[num - 1] = '*';
		626.charArray[num - 2] = '?';
		626.charArray[num - 3] = ':';
	}

	// Token: 0x06001700 RID: 5888 RVA: 0x0004F8D1 File Offset: 0x0004DAD1
	public string GetText7003_9052()
	{
		return this.text2;
	}

	// Token: 0x06001701 RID: 5889 RVA: 0x0004F8D9 File Offset: 0x0004DAD9
	public void Method9053(string 1)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("#=zUkSU2UA=");
		}
		this.text2 = Path.GetFullPath(1);
	}

	// Token: 0x06001702 RID: 5890 RVA: 0x0004F8F5 File Offset: 0x0004DAF5
	public bool GetFlag7004_9054()
	{
		return this.flag2;
	}

	// Token: 0x06001703 RID: 5891 RVA: 0x0004F8FD File Offset: 0x0004DAFD
	public void SetFlag7004_9055(bool 1)
	{
		this.flag2 = 1;
	}

	// Token: 0x06001704 RID: 5892 RVA: 0x0004F908 File Offset: 0x0004DB08
	public string Method10308(string 1)
	{
		1 = this.Method10309(1);
		if (1.Length > 0)
		{
			while (1.EndsWith(Path.DirectorySeparatorChar.ToString()))
			{
				1 = 1.Remove(1.Length - 1, 1);
			}
			return 1;
		}
		throw new 415("Cannot have an empty directory name");
	}

	// Token: 0x06001705 RID: 5893 RVA: 0x0004F95C File Offset: 0x0004DB5C
	public string Method10309(string 1)
	{
		if (1 != null)
		{
			1 = 626.Method9059(1, this.charValue2);
			if (this.flag2)
			{
				1 = Path.GetFileName(1);
			}
			if (this.text2 != null)
			{
				1 = Path.Combine(this.text2, 1);
			}
		}
		else
		{
			1 = string.Empty;
		}
		return 1;
	}

	// Token: 0x06001706 RID: 5894 RVA: 0x0004F9AA File Offset: 0x0004DBAA
	public static bool Method9058(string 1)
	{
		return 1 != null && 1.Length <= 260 && string.Compare(1, 626.Method9059(1, '_')) == 0;
	}

	// Token: 0x06001707 RID: 5895 RVA: 0x0004F9D0 File Offset: 0x0004DBD0
	public static string Method9059(string 1, char 2)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("#=zcC_miSk=");
		}
		1 = 720.Method11154(1.Replace("/", Path.DirectorySeparatorChar.ToString()));
		while (1.Length > 0)
		{
			if (1[0] != Path.DirectorySeparatorChar)
			{
				break;
			}
			1 = 1.Remove(0, 1);
		}
		while (1.Length > 0 && 1[1.Length - 1] == Path.DirectorySeparatorChar)
		{
			1 = 1.Remove(1.Length - 1, 1);
		}
		int i;
		for (i = 1.IndexOf(string.Format("{0}{0}", Path.DirectorySeparatorChar)); i >= 0; i = 1.IndexOf(Path.DirectorySeparatorChar))
		{
			1 = 1.Remove(i, 1);
		}
		i = 1.IndexOfAny(626.charArray);
		if (i >= 0)
		{
			StringBuilder stringBuilder = new StringBuilder(1);
			while (i >= 0)
			{
				stringBuilder[i] = 2;
				i = ((i < 1.Length) ? 1.IndexOfAny(626.charArray, i + 1) : -1);
			}
			1 = stringBuilder.ToString();
		}
		if (1.Length > 260)
		{
			throw new PathTooLongException();
		}
		return 1;
	}

	// Token: 0x06001708 RID: 5896 RVA: 0x0004FAF1 File Offset: 0x0004DCF1
	public char GetChar7005_9060()
	{
		return this.charValue2;
	}

	// Token: 0x06001709 RID: 5897 RVA: 0x0004FAFC File Offset: 0x0004DCFC
	public void Method9061(char 1)
	{
		for (int i = 0; i < 626.charArray.Length; i++)
		{
			if (626.charArray[i] == 1)
			{
				throw new ArgumentException("invalid path character");
			}
		}
		if (1 == Path.DirectorySeparatorChar || 1 == Path.AltDirectorySeparatorChar)
		{
			throw new ArgumentException("invalid replacement character");
		}
		this.charValue2 = 1;
	}

	// Token: 0x04000AD5 RID: 2773
	private string text2;

	// Token: 0x04000AD6 RID: 2774
	private bool flag2;

	// Token: 0x04000AD7 RID: 2775
	private char charValue2 = '_';

	// Token: 0x04000AD8 RID: 2776
	private static readonly char[] charArray;
}
