using System;
using OpenTK.Graphics.ES20;

// Token: 0x02000A9C RID: 2716
public sealed class 1387 : IDisposable
{
	// Token: 0x06004B66 RID: 19302 RVA: 0x001DD66C File Offset: 0x001DB86C
	internal 1387(BeginMode 1)
	{
		this.1 = new 1407<1398>(4000, 1, 1);
	}

	// Token: 0x06004B67 RID: 19303 RVA: 0x001DD688 File Offset: 0x001DB888
	~1387()
	{
		1662.89.Schedule(new 1189(this.5), false);
	}

	// Token: 0x06004B68 RID: 19304 RVA: 0x001DD6C8 File Offset: 0x001DB8C8
	public void Dispose()
	{
		this.1(true);
		GC.SuppressFinalize(this);
	}

	// Token: 0x06004B69 RID: 19305 RVA: 0x001DD6D7 File Offset: 0x001DB8D7
	protected void 1(bool 1)
	{
		if (1)
		{
			this.1.3();
		}
	}

	// Token: 0x06004B6A RID: 19306 RVA: 0x001DD6E7 File Offset: 0x001DB8E7
	internal void 2()
	{
		1379.24.3();
	}

	// Token: 0x06004B6B RID: 19307 RVA: 0x001DD6F4 File Offset: 0x001DB8F4
	internal void 3(208 1, 198 2)
	{
		this.1.5(new 1398
		{
			Position = 1,
			Colour = 2
		});
	}

	// Token: 0x06004B6C RID: 19308 RVA: 0x001DD725 File Offset: 0x001DB925
	internal void 4()
	{
		this.1.6();
		1379.24.4();
	}

	// Token: 0x06004B6D RID: 19309 RVA: 0x001DD73C File Offset: 0x001DB93C
	private void 5()
	{
		this.1(false);
	}

	// Token: 0x04003838 RID: 14392
	private 1407<1398> 1;
}
