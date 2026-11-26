using System;

// Token: 0x020009B7 RID: 2487
public sealed class 1626
{
	// Token: 0x170002F0 RID: 752
	// (get) Token: 0x060045BE RID: 17854 RVA: 0x001B66F9 File Offset: 0x001B48F9
	// (set) Token: 0x060045BF RID: 17855 RVA: 0x001B6701 File Offset: 0x001B4901
	[138("image")]
	public string Text9927
	{
		get
		{
			return this.imageUrl;
		}
		set
		{
			this.imageUrl = value;
		}
	}

	// Token: 0x170002F1 RID: 753
	// (get) Token: 0x060045C0 RID: 17856 RVA: 0x001B670A File Offset: 0x001B490A
	// (set) Token: 0x060045C1 RID: 17857 RVA: 0x001B6712 File Offset: 0x001B4912
	[138("url")]
	public string Text9928
	{
		get
		{
			return this.linkUrl;
		}
		set
		{
			this.linkUrl = value;
		}
	}

	// Token: 0x170002F2 RID: 754
	// (get) Token: 0x060045C2 RID: 17858 RVA: 0x001B671B File Offset: 0x001B491B
	// (set) Token: 0x060045C3 RID: 17859 RVA: 0x001B6723 File Offset: 0x001B4923
	[138("begins")]
	public DateTimeOffset? Nullable9929
	{
		get
		{
			return this.beginsAt;
		}
		set
		{
			this.beginsAt = value;
		}
	}

	// Token: 0x170002F3 RID: 755
	// (get) Token: 0x060045C4 RID: 17860 RVA: 0x001B672C File Offset: 0x001B492C
	// (set) Token: 0x060045C5 RID: 17861 RVA: 0x001B6734 File Offset: 0x001B4934
	[138("expires")]
	public DateTimeOffset? Nullable9930
	{
		get
		{
			return this.expiresAt;
		}
		set
		{
			this.expiresAt = value;
		}
	}

	// Token: 0x0400330B RID: 13067
	private string imageUrl = string.Empty;

	// Token: 0x0400330C RID: 13068
	private string linkUrl = string.Empty;

	// Token: 0x0400330D RID: 13069
	private DateTimeOffset? beginsAt;

	// Token: 0x0400330E RID: 13070
	private DateTimeOffset? expiresAt;
}
