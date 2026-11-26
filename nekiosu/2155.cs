using System;

// Token: 0x020007F2 RID: 2034
[276]
public class 2155
{
	// Token: 0x06003AE7 RID: 15079 RVA: 0x00173A72 File Offset: 0x00171C72
	public 2155(2149 1, bool 2, bool 3)
	{
		this.4 = 1;
		this.2 = 2;
		this.1 = 3;
	}

	// Token: 0x06003AE8 RID: 15080 RVA: 0x00173A90 File Offset: 0x00171C90
	public virtual int GetBaseScore()
	{
		2149 <<EMPTY_NAME>> = this.4 & (2149)(-8);
		if (<<EMPTY_NAME>> <= (2149)256)
		{
			if (<<EMPTY_NAME>> <= (2149)64)
			{
				if (<<EMPTY_NAME>> == (2149)8)
				{
					return 10;
				}
				if (<<EMPTY_NAME>> != (2149)64)
				{
					return 0;
				}
			}
			else if (<<EMPTY_NAME>> != (2149)128)
			{
				if (<<EMPTY_NAME>> != (2149)256)
				{
					return 0;
				}
				return 50;
			}
			return 30;
		}
		if (<<EMPTY_NAME>> <= (2149)1024)
		{
			if (<<EMPTY_NAME>> == (2149)512)
			{
				return 100;
			}
			if (<<EMPTY_NAME>> == (2149)1024)
			{
				return 300;
			}
		}
		else
		{
			if (<<EMPTY_NAME>> == (2149)8192)
			{
				return 100;
			}
			if (<<EMPTY_NAME>> == (2149)16384)
			{
				return 500;
			}
		}
		return 0;
	}

	// Token: 0x04002BA1 RID: 11169
	public bool 1;

	// Token: 0x04002BA2 RID: 11170
	public bool 2;

	// Token: 0x04002BA3 RID: 11171
	public int 3;

	// Token: 0x04002BA4 RID: 11172
	public 2149 4;
}
