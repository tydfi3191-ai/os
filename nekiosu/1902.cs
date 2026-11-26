using System;
using System.Collections.Generic;

// Token: 0x02000858 RID: 2136
public sealed class 1902
{
	// Token: 0x06003DF6 RID: 15862 RVA: 0x00184F8E File Offset: 0x0018318E
	public 1902(1902 1)
	{
		this.2 = 1;
	}

	// Token: 0x06003DF7 RID: 15863 RVA: 0x00184FB0 File Offset: 0x001831B0
	public 1919 1()
	{
		return this.1[0].1();
	}

	// Token: 0x06003DF8 RID: 15864 RVA: 0x00184FC3 File Offset: 0x001831C3
	public int 2()
	{
		return this.3;
	}

	// Token: 0x06003DF9 RID: 15865 RVA: 0x00184FCB File Offset: 0x001831CB
	private void 3(int 1)
	{
		this.3 = 1;
	}

	// Token: 0x06003DFA RID: 15866 RVA: 0x00184FD4 File Offset: 0x001831D4
	private bool 4(1902 1)
	{
		if (this.1.Count != 1.1.Count)
		{
			return false;
		}
		for (int i = 0; i < Math.Min(this.1.Count, 2); i++)
		{
			if (!this.1[i].3(1.1[i]))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06003DFB RID: 15867 RVA: 0x0018503C File Offset: 0x0018323C
	public void 5()
	{
		if (this.2 == null)
		{
			this.3(17);
			return;
		}
		1902 <<EMPTY_NAME>> = this.2;
		for (int i = 1; i < 16; i++)
		{
			if (this.4(<<EMPTY_NAME>>))
			{
				this.3(Math.Min(i, 16));
				return;
			}
			<<EMPTY_NAME>> = <<EMPTY_NAME>>.2;
			if (<<EMPTY_NAME>> == null)
			{
				break;
			}
		}
		this.3(17);
	}

	// Token: 0x04002D6E RID: 11630
	public readonly List<1899> 1 = new List<1899>();

	// Token: 0x04002D6F RID: 11631
	public readonly 1902 2;

	// Token: 0x04002D70 RID: 11632
	private int 3 = 17;
}
