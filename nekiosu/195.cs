using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Globalization;
using System.Resources;

// Token: 0x020002B6 RID: 694
[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
public sealed class 195
{
	// Token: 0x060014EF RID: 5359 RVA: 0x000055AC File Offset: 0x000037AC
	internal 195()
	{
	}

	// Token: 0x060014F0 RID: 5360 RVA: 0x00049075 File Offset: 0x00047275
	internal static ResourceManager GetResourceManager()
	{
		if (195.resourceManager == null)
		{
			195.resourceManager = new ResourceManager("Microsoft.Xna.Framework.MathResources", typeof(195).Assembly);
		}
		return 195.resourceManager;
	}

	// Token: 0x060014F1 RID: 5361 RVA: 0x000490A1 File Offset: 0x000472A1
	internal static CultureInfo GetCultureInfo()
	{
		return 195.cultureInfo2;
	}

	// Token: 0x060014F2 RID: 5362 RVA: 0x000490A8 File Offset: 0x000472A8
	internal static void SetCultureInfo(CultureInfo 1)
	{
		195.cultureInfo2 = 1;
	}

	// Token: 0x060014F3 RID: 5363 RVA: 0x000490B0 File Offset: 0x000472B0
	internal static string GetBoundingBoxZeroPointsMessage()
	{
		return 195.GetResourceManager().GetString("BoundingBoxZeroPoints", 195.cultureInfo2);
	}

	// Token: 0x060014F4 RID: 5364 RVA: 0x000490C6 File Offset: 0x000472C6
	internal static string GetBoundingSphereZeroPointsMessage()
	{
		return 195.GetResourceManager().GetString("BoundingSphereZeroPoints", 195.cultureInfo2);
	}

	// Token: 0x060014F5 RID: 5365 RVA: 0x000490DC File Offset: 0x000472DC
	internal static string GetInvalidStringFormatMessage()
	{
		return 195.GetResourceManager().GetString("InvalidStringFormat", 195.cultureInfo2);
	}

	// Token: 0x060014F6 RID: 5366 RVA: 0x000490F2 File Offset: 0x000472F2
	internal static string GetNegativePlaneDistanceMessage()
	{
		return 195.GetResourceManager().GetString("NegativePlaneDistance", 195.cultureInfo2);
	}

	// Token: 0x060014F7 RID: 5367 RVA: 0x00049108 File Offset: 0x00047308
	internal static string GetNegativeRadiusMessage()
	{
		return 195.GetResourceManager().GetString("NegativeRadius", 195.cultureInfo2);
	}

	// Token: 0x060014F8 RID: 5368 RVA: 0x0004911E File Offset: 0x0004731E
	internal static string GetNotEnoughCornersMessage()
	{
		return 195.GetResourceManager().GetString("NotEnoughCorners", 195.cultureInfo2);
	}

	// Token: 0x060014F9 RID: 5369 RVA: 0x00049134 File Offset: 0x00047334
	internal static string GetNotEnoughSourceSizeMessage()
	{
		return 195.GetResourceManager().GetString("NotEnoughSourceSize", 195.cultureInfo2);
	}

	// Token: 0x060014FA RID: 5370 RVA: 0x0004914A File Offset: 0x0004734A
	internal static string GetNotEnoughTargetSizeMessage()
	{
		return 195.GetResourceManager().GetString("NotEnoughTargetSize", 195.cultureInfo2);
	}

	// Token: 0x060014FB RID: 5371 RVA: 0x00049160 File Offset: 0x00047360
	internal static string GetOppositePlanesMessage()
	{
		return 195.GetResourceManager().GetString("OppositePlanes", 195.cultureInfo2);
	}

	// Token: 0x060014FC RID: 5372 RVA: 0x00049176 File Offset: 0x00047376
	internal static string GetOutRangeFieldOfViewMessage()
	{
		return 195.GetResourceManager().GetString("OutRangeFieldOfView", 195.cultureInfo2);
	}

	// Token: 0x040009DA RID: 2522
	private static ResourceManager resourceManager;

	// Token: 0x040009DB RID: 2523
	private static CultureInfo cultureInfo2;
}
