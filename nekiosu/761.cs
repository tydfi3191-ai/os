using System;
using System.Runtime.InteropServices;

// Token: 0x0200031E RID: 798
[ComVisible(false)]
public sealed class 761 : EventArgs
{
	// Token: 0x06001805 RID: 6149 RVA: 0x00054392 File Offset: 0x00052592
	public 761(string 1, long 2, long 3)
	{
		this.text2 = 1;
		this.number3 = 2;
		this.number4 = 3;
	}

	// Token: 0x06001806 RID: 6150 RVA: 0x000543B6 File Offset: 0x000525B6
	public string GetText9642_12329()
	{
		return this.text2;
	}

	// Token: 0x06001807 RID: 6151 RVA: 0x000543BE File Offset: 0x000525BE
	public bool GetFlag9645_12330()
	{
		return this.flag2;
	}

	// Token: 0x06001808 RID: 6152 RVA: 0x000543C6 File Offset: 0x000525C6
	public void SetFlag9645_12331(bool 1)
	{
		this.flag2 = 1;
	}

	// Token: 0x06001809 RID: 6153 RVA: 0x000543CF File Offset: 0x000525CF
	public float Method12332()
	{
		if (this.number4 <= 0L)
		{
			return 0f;
		}
		return (float)this.number3 / (float)this.number4 * 100f;
	}

	// Token: 0x0600180A RID: 6154 RVA: 0x000543F6 File Offset: 0x000525F6
	public long GetNumber9643_12333()
	{
		return this.number3;
	}

	// Token: 0x0600180B RID: 6155 RVA: 0x000543FE File Offset: 0x000525FE
	public long GetNumber9644_12334()
	{
		return this.number4;
	}

	// Token: 0x04000B36 RID: 2870
	private string text2;

	// Token: 0x04000B37 RID: 2871
	private long number3;

	// Token: 0x04000B38 RID: 2872
	private long number4;

	// Token: 0x04000B39 RID: 2873
	private bool flag2 = true;
}
