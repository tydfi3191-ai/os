using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

// Token: 0x0200050A RID: 1290
[276]
internal sealed class 2533 : 2510
{
	// Token: 0x06002785 RID: 10117 RVA: 0x000C5724 File Offset: 0x000C3924
	internal 2533(2511 1, 2528 2) : base(1, 2)
	{
		2530 3 = 2.8(2530.3("image", "Image", "A picture from the HUD images folder. Drop pictures on the window to add them.", string.Empty, null, null));
		Func<string[]> 4;
		if ((4 = 2533.<>O.<0>__ListImages) == null)
		{
			4 = (2533.<>O.<0>__ListImages = new Func<string[]>(2533.7));
		}
		3.14 = 4;
	}

	// Token: 0x1700025B RID: 603
	// (get) Token: 0x06002786 RID: 10118 RVA: 0x000C577A File Offset: 0x000C397A
	internal static string Folder
	{
		get
		{
			return 268.2("HUD images");
		}
	}

	// Token: 0x06002787 RID: 10119 RVA: 0x000C5786 File Offset: 0x000C3986
	internal static bool 6(string 1)
	{
		return Array.IndexOf<string>(2533.5, Path.GetExtension(1 ?? string.Empty).ToLowerInvariant()) >= 0;
	}

	// Token: 0x06002788 RID: 10120 RVA: 0x000C57AC File Offset: 0x000C39AC
	internal static string[] 7()
	{
		string[] result;
		try
		{
			if (!Directory.Exists(2533.Folder))
			{
				result = new string[0];
			}
			else
			{
				List<string> list = new List<string>();
				foreach (string text in Directory.GetFiles(2533.Folder))
				{
					if (2533.6(text))
					{
						list.Add(Path.GetFileName(text));
					}
				}
				list.Sort(StringComparer.OrdinalIgnoreCase);
				result = list.ToArray();
			}
		}
		catch (IOException)
		{
			result = new string[0];
		}
		catch (UnauthorizedAccessException)
		{
			result = new string[0];
		}
		return result;
	}

	// Token: 0x06002789 RID: 10121 RVA: 0x000C5850 File Offset: 0x000C3A50
	internal static string Import(string 1)
	{
		Directory.CreateDirectory(2533.Folder);
		string text = Path.GetFileName(1);
		string text2 = Path.Combine(2533.Folder, text);
		if (string.Equals(Path.GetFullPath(1), Path.GetFullPath(text2), StringComparison.OrdinalIgnoreCase))
		{
			return text;
		}
		int num = 2;
		while (File.Exists(text2))
		{
			text = string.Concat(new string[]
			{
				Path.GetFileNameWithoutExtension(1),
				" (",
				num++.ToString(),
				")",
				Path.GetExtension(1)
			});
			text2 = Path.Combine(2533.Folder, text);
		}
		File.Copy(1, text2);
		return text;
	}

	// Token: 0x0600278A RID: 10122 RVA: 0x000C58F0 File Offset: 0x000C3AF0
	private static 1381 8(string 1)
	{
		if (string.IsNullOrEmpty(1) || 1.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0)
		{
			return null;
		}
		1381 2;
		if (2533.6.TryGetValue(1, out 2) && 2 != null && !2.5())
		{
			return 2;
		}
		string text = Path.Combine(2533.Folder, 1);
		1381 3 = File.Exists(text) ? 2532.3(text) : null;
		2533.6[1] = 3;
		return 3;
	}

	// Token: 0x0600278B RID: 10123 RVA: 0x000C595C File Offset: 0x000C3B5C
	internal override void Build()
	{
		1381 <<EMPTY_NAME>> = 2533.8(this.2.10("image"));
		if (<<EMPTY_NAME>> != null)
		{
			this.7 = base.1<1433>(new 1433(<<EMPTY_NAME>>, (1376)6, 1065.Centre, (1044)0, base.Pivot, 0.9f, true, 198.White, null), true);
			this.8 = null;
			return;
		}
		this.7 = null;
		this.8 = base.1<1452>(2510.4((2533.7().Length == 0) ? "Drop a picture on the window" : "Pick a picture in the settings", 12f, base.Pivot, 1065.Centre, new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue), true), true);
	}

	// Token: 0x0600278C RID: 10124 RVA: 0x000C5A00 File Offset: 0x000C3C00
	internal override void Update()
	{
		if (this.8 != null)
		{
			this.8.16 = (2513.IsOpen ? 1f : 0f);
			base.3(this.8, 12f);
		}
	}

	// Token: 0x04001C84 RID: 7300
	private new static readonly string[] 5 = new string[]
	{
		".png",
		".jpg",
		".jpeg",
		".bmp",
		".gif"
	};

	// Token: 0x04001C85 RID: 7301
	private static readonly Dictionary<string, 1381> 6 = new Dictionary<string, 1381>(StringComparer.OrdinalIgnoreCase);

	// Token: 0x04001C86 RID: 7302
	private 1433 7;

	// Token: 0x04001C87 RID: 7303
	private 1452 8;

	// Token: 0x0200050B RID: 1291
	[CompilerGenerated]
	[276]
	private static class <>O
	{
		// Token: 0x04001C88 RID: 7304
		public static Func<string[]> <0>__ListImages;
	}
}
