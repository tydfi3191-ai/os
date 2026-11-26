using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

// Token: 0x020001B4 RID: 436
[ComVisible(false)]
public sealed class 744
{
	// Token: 0x06000E05 RID: 3589 RVA: 0x0002FE5E File Offset: 0x0002E05E
	public 744()
	{
		this.SetIList9362_11937(new List<529>());
	}

	// Token: 0x06000E06 RID: 3590 RVA: 0x0002FE71 File Offset: 0x0002E071
	public IList<529> GetIList9362_11936()
	{
		return this.iList2;
	}

	// Token: 0x06000E07 RID: 3591 RVA: 0x0002FE79 File Offset: 0x0002E079
	protected void SetIList9362_11937(IList<529> 1)
	{
		this.iList2 = 1;
	}

	// Token: 0x06000E08 RID: 3592 RVA: 0x0002FE84 File Offset: 0x0002E084
	public 529 Method11938(string 1)
	{
		744.745 CS_0024_003C_003E8__locals3 = new 744.745();
		CS_0024_003C_003E8__locals3.text = 3;
		529 2 = this.GetIList9362_11936().SingleOrDefault((529 1) => string.Equals(1.GetText5091_6370(), CS_0024_003C_003E8__locals3.text, StringComparison.Ordinal));
		if (2 == null)
		{
			2 = this.GetIList9362_11936().SingleOrDefault(new Func<529, bool>(CS_0024_003C_003E8__locals3.Method11935));
		}
		return 2;
	}

	// Token: 0x040006DA RID: 1754
	private IList<529> iList2;

	// Token: 0x020001B5 RID: 437
	public sealed class 745
	{
		// Token: 0x06000E09 RID: 3593 RVA: 0x0002FEE7 File Offset: 0x0002E0E7
		internal bool Method11934(529 1)
		{
			return string.Equals(1.GetText5091_6370(), this.text, StringComparison.Ordinal);
		}

		// Token: 0x06000E0A RID: 3594 RVA: 0x0002FEFB File Offset: 0x0002E0FB
		internal bool Method11935(529 1)
		{
			return string.Equals(1.GetText5124_6436(), this.text, StringComparison.Ordinal);
		}

		// Token: 0x040006DB RID: 1755
		public string text;
	}
}
