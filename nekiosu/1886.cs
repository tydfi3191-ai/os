using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x02000845 RID: 2117
public sealed class 1886
{
	// Token: 0x06003D82 RID: 15746 RVA: 0x00183BCE File Offset: 0x00181DCE
	public List<1919> 1()
	{
		return this.1;
	}

	// Token: 0x06003D83 RID: 15747 RVA: 0x00183BD6 File Offset: 0x00181DD6
	public 1919 2()
	{
		return this.1()[0];
	}

	// Token: 0x06003D84 RID: 15748 RVA: 0x00183BE4 File Offset: 0x00181DE4
	public 1919 3()
	{
		return this.1().Last<1919>();
	}

	// Token: 0x06003D85 RID: 15749 RVA: 0x00183BF1 File Offset: 0x00181DF1
	public 1887? 4()
	{
		return this.5();
	}

	// Token: 0x06003D86 RID: 15750 RVA: 0x00183BFC File Offset: 0x00181DFC
	private 1887? 5()
	{
		if (this.1()[0].2.HasObjectType(2047.Normal))
		{
			2034 <<EMPTY_NAME>> = this.1()[0].2;
			return new 1887?((<<EMPTY_NAME>>.HasClap() || <<EMPTY_NAME>>.HasWhistle()) ? ((1887)1) : ((1887)0));
		}
		return null;
	}

	// Token: 0x06003D87 RID: 15751 RVA: 0x00183C57 File Offset: 0x00181E57
	public int 6()
	{
		return this.1().Count;
	}

	// Token: 0x04002D32 RID: 11570
	private List<1919> 1 = new List<1919>();

	// Token: 0x04002D33 RID: 11571
	public 1899 2;

	// Token: 0x04002D34 RID: 11572
	public int 3;
}
