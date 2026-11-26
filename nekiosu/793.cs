using System;
using System.Runtime.InteropServices;

// Token: 0x020001C9 RID: 457
[ComVisible(false)]
public sealed class 793
{
	// Token: 0x06000E8A RID: 3722 RVA: 0x0003103E File Offset: 0x0002F23E
	public 793()
	{
		this.stringComparison2 = StringComparison.Ordinal;
	}

	// Token: 0x06000E8B RID: 3723 RVA: 0x0003104D File Offset: 0x0002F24D
	public 632 GetRecoveredType168210100_12946()
	{
		return this._recoveredType168210100;
	}

	// Token: 0x06000E8C RID: 3724 RVA: 0x00031055 File Offset: 0x0002F255
	public void Method12947(632 1)
	{
		if (1 < (632)0 || 1 > (632)3)
		{
			throw new ArgumentOutOfRangeException("value");
		}
		this._recoveredType168210100 = 1;
	}

	// Token: 0x06000E8D RID: 3725 RVA: 0x00031071 File Offset: 0x0002F271
	public 354 GetRecoveredType025710101_12948()
	{
		return this._recoveredType025710101;
	}

	// Token: 0x06000E8E RID: 3726 RVA: 0x00031079 File Offset: 0x0002F279
	public void Method12949(354 1)
	{
		if (1 < (354)0 || 1 > (354)1)
		{
			throw new ArgumentOutOfRangeException("value");
		}
		this._recoveredType025710101 = 1;
	}

	// Token: 0x06000E8F RID: 3727 RVA: 0x00031095 File Offset: 0x0002F295
	public StringComparison GetStringComparison10102_12950()
	{
		return this.stringComparison2;
	}

	// Token: 0x06000E90 RID: 3728 RVA: 0x0003109D File Offset: 0x0002F29D
	public void Method12951(StringComparison 1)
	{
		if (1 < StringComparison.CurrentCulture || 1 > StringComparison.OrdinalIgnoreCase)
		{
			throw new ArgumentOutOfRangeException("#=zUkSU2UA=");
		}
		this.stringComparison2 = 1;
	}

	// Token: 0x0400071A RID: 1818
	private 632 _recoveredType168210100;

	// Token: 0x0400071B RID: 1819
	private 354 _recoveredType025710101;

	// Token: 0x0400071C RID: 1820
	private StringComparison stringComparison2;
}
