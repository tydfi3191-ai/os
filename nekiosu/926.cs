using System;

// Token: 0x0200020A RID: 522
[242(1)]
[241(0)]
public static class 926
{
	// Token: 0x0600107A RID: 4218 RVA: 0x000389EC File Offset: 0x00036BEC
	public static int IndexOf(this 743 1, char 2, int 3, int 4)
	{
		int num = Array.IndexOf<char>(1.GetCharArray9358_11931(), 2, 1.GetNumber9359_11932() + 3, 4);
		if (num == -1)
		{
			return -1;
		}
		return num - 1.GetNumber9359_11932();
	}

	// Token: 0x0600107B RID: 4219 RVA: 0x00038A20 File Offset: 0x00036C20
	public static bool StartsWith(this 743 1, string 2)
	{
		if (2.Length > 1.GetNumber9360_11933())
		{
			return false;
		}
		char[] charArray9358_ = 1.GetCharArray9358_11931();
		for (int i = 0; i < 2.Length; i++)
		{
			if (2[i] != charArray9358_[i + 1.GetNumber9359_11932()])
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600107C RID: 4220 RVA: 0x00038A70 File Offset: 0x00036C70
	public static bool EndsWith(this 743 1, string 2)
	{
		if (2.Length > 1.GetNumber9360_11933())
		{
			return false;
		}
		char[] charArray9358_ = 1.GetCharArray9358_11931();
		int num = 1.GetNumber9359_11932() + 1.GetNumber9360_11933() - 2.Length;
		for (int i = 0; i < 2.Length; i++)
		{
			if (2[i] != charArray9358_[i + num])
			{
				return false;
			}
		}
		return true;
	}
}
