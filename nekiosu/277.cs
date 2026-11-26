using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;

// Token: 0x02000352 RID: 850
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[DebuggerNonUserCode]
public sealed class 277
{
	// Token: 0x06001A65 RID: 6757 RVA: 0x000055AC File Offset: 0x000037AC
	internal 277()
	{
	}

	// Token: 0x06001A66 RID: 6758 RVA: 0x00063DE6 File Offset: 0x00061FE6
	internal static ResourceManager GetResourceManager()
	{
		if (277.resourceManager == null)
		{
			277.resourceManager = new ResourceManager("Resources", typeof(277).Assembly);
		}
		return 277.resourceManager;
	}

	// Token: 0x06001A67 RID: 6759 RVA: 0x00063E12 File Offset: 0x00062012
	internal static CultureInfo GetCulture()
	{
		return 277.currentCulture;
	}

	// Token: 0x06001A68 RID: 6760 RVA: 0x00063E19 File Offset: 0x00062019
	internal static void SetCulture(CultureInfo 1)
	{
		277.currentCulture = 1;
	}

	// Token: 0x06001A69 RID: 6761 RVA: 0x00063E21 File Offset: 0x00062021
	internal static Bitmap GetAddImage()
	{
		return (Bitmap)277.GetResourceManager().GetObject("add", 277.currentCulture);
	}

	// Token: 0x06001A6A RID: 6762 RVA: 0x00063E3C File Offset: 0x0006203C
	internal static Bitmap GetAimodErrorImage()
	{
		return (Bitmap)277.GetResourceManager().GetObject("aimod_error", 277.currentCulture);
	}

	// Token: 0x06001A6B RID: 6763 RVA: 0x00063E57 File Offset: 0x00062057
	internal static Bitmap GetAimodInfoImage()
	{
		return (Bitmap)277.GetResourceManager().GetObject("aimod_info", 277.currentCulture);
	}

	// Token: 0x06001A6C RID: 6764 RVA: 0x00063E72 File Offset: 0x00062072
	internal static Bitmap GetAimodWarningImage()
	{
		return (Bitmap)277.GetResourceManager().GetObject("aimod_warning", 277.currentCulture);
	}

	// Token: 0x06001A6D RID: 6765 RVA: 0x00063E8D File Offset: 0x0006208D
	internal static string GetEnglishLocalisation()
	{
		return 277.GetResourceManager().GetString("en", 277.currentCulture);
	}

	// Token: 0x06001A6E RID: 6766 RVA: 0x00063EA3 File Offset: 0x000620A3
	internal static Bitmap GetGlassButtonImage()
	{
		return (Bitmap)277.GetResourceManager().GetObject("glassbutton", 277.currentCulture);
	}

	// Token: 0x06001A6F RID: 6767 RVA: 0x00063EBE File Offset: 0x000620BE
	internal static Bitmap GetGlassCornerImage()
	{
		return (Bitmap)277.GetResourceManager().GetObject("glasscorner", 277.currentCulture);
	}

	// Token: 0x06001A70 RID: 6768 RVA: 0x00063ED9 File Offset: 0x000620D9
	internal static Bitmap GetGreenBulletImage()
	{
		return (Bitmap)277.GetResourceManager().GetObject("greenbullet", 277.currentCulture);
	}

	// Token: 0x06001A71 RID: 6769 RVA: 0x00063EF4 File Offset: 0x000620F4
	internal static Bitmap GetOsuCrashImage()
	{
		return (Bitmap)277.GetResourceManager().GetObject("osu_crash", 277.currentCulture);
	}

	// Token: 0x06001A72 RID: 6770 RVA: 0x00063F0F File Offset: 0x0006210F
	internal static Bitmap GetRedBulletImage()
	{
		return (Bitmap)277.GetResourceManager().GetObject("redbullet", 277.currentCulture);
	}

	// Token: 0x06001A73 RID: 6771 RVA: 0x00063F2A File Offset: 0x0006212A
	internal static Bitmap GetSplashImage()
	{
		return (Bitmap)277.GetResourceManager().GetObject("splash", 277.currentCulture);
	}

	// Token: 0x06001A74 RID: 6772 RVA: 0x00063F45 File Offset: 0x00062145
	internal static Bitmap GetSubImage()
	{
		return (Bitmap)277.GetResourceManager().GetObject("sub", 277.currentCulture);
	}

	// Token: 0x06001A75 RID: 6773 RVA: 0x00063F60 File Offset: 0x00062160
	internal static Bitmap GetUpdaterGrid1Image()
	{
		return (Bitmap)277.GetResourceManager().GetObject("updater_grid1", 277.currentCulture);
	}

	// Token: 0x06001A76 RID: 6774 RVA: 0x00063F7B File Offset: 0x0006217B
	internal static Bitmap GetUpdaterGrid2Image()
	{
		return (Bitmap)277.GetResourceManager().GetObject("updater_grid2", 277.currentCulture);
	}

	// Token: 0x06001A77 RID: 6775 RVA: 0x00063F96 File Offset: 0x00062196
	internal static Bitmap GetUpdaterGrid3Image()
	{
		return (Bitmap)277.GetResourceManager().GetObject("updater_grid3", 277.currentCulture);
	}

	// Token: 0x06001A78 RID: 6776 RVA: 0x00063FB1 File Offset: 0x000621B1
	internal static Bitmap GetUpdaterGrid4Image()
	{
		return (Bitmap)277.GetResourceManager().GetObject("updater_grid4", 277.currentCulture);
	}

	// Token: 0x06001A79 RID: 6777 RVA: 0x00063FCC File Offset: 0x000621CC
	internal static Bitmap GetUpdaterLogoImage()
	{
		return (Bitmap)277.GetResourceManager().GetObject("updater_logo", 277.currentCulture);
	}

	// Token: 0x04000C9D RID: 3229
	private static ResourceManager resourceManager;

	// Token: 0x04000C9E RID: 3230
	private static CultureInfo currentCulture;
}
