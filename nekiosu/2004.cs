using System;

// Token: 0x02000763 RID: 1891
public sealed class 2004
{
	// Token: 0x17000296 RID: 662
	internal 200 this[int 1, 2007 2]
	{
		get
		{
			return this.3[this.2(1, 2)];
		}
		set
		{
			for (int i = 0; i < this.3.Length; i++)
			{
				if (this.3[i] == value)
				{
					this.3[i] = 200.None;
				}
			}
			this.3[this.2(1, 2)] = value;
		}
	}

	// Token: 0x06003790 RID: 14224 RVA: 0x0015C200 File Offset: 0x0015A400
	internal 2004(int 1, 2008 2, string 3 = "")
	{
		this.1 = 1;
		this.2 = 2;
		this.3 = new 200[this.1 + this.1()];
		string[] array = 3.Split(null, StringSplitOptions.RemoveEmptyEntries);
		for (int i = 0; i < this.3.Length; i++)
		{
			200 4 = 200.None;
			if (i < array.Length)
			{
				Enum.TryParse<200>(array[i], out 4);
			}
			this[i, (2007)(-1)] = 4;
		}
	}

	// Token: 0x06003791 RID: 14225 RVA: 0x0015C271 File Offset: 0x0015A471
	internal int 1()
	{
		if (this.2 != 2008.Split)
		{
			return 1;
		}
		return 2;
	}

	// Token: 0x06003792 RID: 14226 RVA: 0x0015C27F File Offset: 0x0015A47F
	private int 2(int 1, 2007 2)
	{
		switch (2)
		{
		case (2007)(-1):
			return 1;
		case (2007)0:
			if (1 < this.1)
			{
				return 1;
			}
			break;
		case (2007)1:
			if (1 < this.1())
			{
				return 1 + this.1;
			}
			break;
		}
		throw new IndexOutOfRangeException();
	}

	// Token: 0x06003793 RID: 14227 RVA: 0x0015C2BC File Offset: 0x0015A4BC
	public override string ToString()
	{
		int num = this.1 - 1;
		for (int i = this.1; i < this.3.Length; i++)
		{
			if (this[i, (2007)(-1)] != 200.None)
			{
				num = i;
			}
		}
		string text = string.Empty;
		for (int j = 0; j <= num; j++)
		{
			text = text + this[j, (2007)(-1)].ToString() + " ";
		}
		return text.TrimEnd(Array.Empty<char>());
	}

	// Token: 0x0400292F RID: 10543
	internal int 1;

	// Token: 0x04002930 RID: 10544
	internal 2008 2;

	// Token: 0x04002931 RID: 10545
	private 200[] 3;
}
