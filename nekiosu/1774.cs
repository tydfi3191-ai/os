using System;

// Token: 0x020008B1 RID: 2225
public sealed class 1774 : 1779
{
	// Token: 0x06003FAE RID: 16302 RVA: 0x0018A758 File Offset: 0x00188958
	public 1774(string 1, 1189 2 = null)
	{
		int num = 0;
		this.13 = new 1452(1, 12f, new 208(0f, (float)(num / 2)), new 208(244f, 0f), 1f, true, 198.White, true);
		this.13.75 = (1066)0;
		this.13.10 = true;
		this.13.3(new EventHandler(this.19));
		this.13.11 = true;
		this.1.12(this.13);
		base.3(this.13.GetTextSize() + new 208(0f, (float)num));
		base.10(1);
		if (2 != null)
		{
			this.14 = 2;
		}
	}

	// Token: 0x06003FAF RID: 16303 RVA: 0x0018A826 File Offset: 0x00188A26
	internal void 18(198 1)
	{
		this.13.6 = 1;
	}

	// Token: 0x06003FB0 RID: 16304 RVA: 0x0018A834 File Offset: 0x00188A34
	private void 19(object 1, EventArgs 2)
	{
		if (this.14 != null)
		{
			this.14();
		}
	}

	// Token: 0x06003FB1 RID: 16305 RVA: 0x0000FF75 File Offset: 0x0000E175
	internal override bool IsHeader()
	{
		return false;
	}

	// Token: 0x06003FB2 RID: 16306 RVA: 0x0018A849 File Offset: 0x00188A49
	internal void 20(string 1)
	{
		this.13.SetText(1);
	}

	// Token: 0x04002E8D RID: 11917
	private new 1452 13;

	// Token: 0x04002E8E RID: 11918
	internal new 1189 14;
}
