using System;
using System.Collections.Generic;

// Token: 0x02000765 RID: 1893
public sealed class 2005
{
	// Token: 0x17000297 RID: 663
	internal 2004 this[int 1]
	{
		get
		{
			if (1 < 0 || 1 >= this.3.Count)
			{
				return null;
			}
			return this.3[1];
		}
	}

	// Token: 0x0600379A RID: 14234 RVA: 0x0015C517 File Offset: 0x0015A717
	internal 2005(int 1, 2008 2)
	{
		this.1 = 1;
		this.2 = 2;
	}

	// Token: 0x0600379B RID: 14235 RVA: 0x0015C53F File Offset: 0x0015A73F
	internal int 1()
	{
		return this.4;
	}

	// Token: 0x0600379C RID: 14236 RVA: 0x0015C547 File Offset: 0x0015A747
	internal void 2(int 1)
	{
		this.4 = ((1 < this.3.Count) ? Math.Max(1, -1) : -1);
	}

	// Token: 0x0600379D RID: 14237 RVA: 0x0015C567 File Offset: 0x0015A767
	internal 2004 3()
	{
		return this[this.1()];
	}

	// Token: 0x0600379E RID: 14238 RVA: 0x0015C578 File Offset: 0x0015A778
	internal void 4(string 1)
	{
		foreach (string text in 1.Split(new char[]
		{
			';'
		}))
		{
			this.3.Add(new 2004(this.1, this.2, text));
		}
	}

	// Token: 0x0600379F RID: 14239 RVA: 0x0015C5C6 File Offset: 0x0015A7C6
	internal 2004 5()
	{
		return new 2004(this.1, this.2, string.Empty);
	}

	// Token: 0x060037A0 RID: 14240 RVA: 0x0015C5DE File Offset: 0x0015A7DE
	internal void 6(int 1, 2004 2)
	{
		this.3.Insert(1, 2 ?? this.5());
	}

	// Token: 0x060037A1 RID: 14241 RVA: 0x0015C5F8 File Offset: 0x0015A7F8
	public override string ToString()
	{
		string text = string.Empty;
		foreach (2004 <<EMPTY_NAME>> in this.3)
		{
			text = text + <<EMPTY_NAME>>.ToString() + ";";
		}
		return text.TrimEnd(new char[]
		{
			';'
		});
	}

	// Token: 0x04002933 RID: 10547
	internal int 1;

	// Token: 0x04002934 RID: 10548
	internal 2008 2;

	// Token: 0x04002935 RID: 10549
	private List<2004> 3 = new List<2004>();

	// Token: 0x04002936 RID: 10550
	private int 4 = -1;
}
