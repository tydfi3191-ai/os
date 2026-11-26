using System;
using System.Collections.Generic;
using System.Text;
using OpenTK.Graphics.ES20;
using osu_ui;

// Token: 0x02000ABD RID: 2749
public static class 1425
{
	// Token: 0x06004C46 RID: 19526 RVA: 0x001E1DCC File Offset: 0x001DFFCC
	internal static bool 1()
	{
		return 1379.18 >= new Version(1, 0);
	}

	// Token: 0x06004C47 RID: 19527 RVA: 0x001E1DE0 File Offset: 0x001DFFE0
	private static string 2(ShaderType 1)
	{
		string result;
		if (1 != 35632)
		{
			if (1 != 35633)
			{
				result = string.Empty;
			}
			else
			{
				result = ".vs";
			}
		}
		else
		{
			result = ".fs";
		}
		return result;
	}

	// Token: 0x06004C48 RID: 19528 RVA: 0x001E1E18 File Offset: 0x001E0018
	private static string 3(string 1, ShaderType 2)
	{
		string text = 1425.2(2);
		if (!1.StartsWith("sh_"))
		{
			1 = "sh_" + 1;
		}
		if (1.EndsWith(text))
		{
			return 1;
		}
		return 1 + text;
	}

	// Token: 0x06004C49 RID: 19529 RVA: 0x001E1E58 File Offset: 0x001E0058
	private static 1061 4(string 1, ShaderType 2, bool 3)
	{
		1 = 1425.3(1, 2);
		1061 4;
		if (!3 && 1425.1.TryGetValue(1, out 4))
		{
			return 4;
		}
		byte[] array = null;
		if (array == null)
		{
			array = (ResourcesStore.ResourceManager.GetObject(1.Replace('.', '_')) as byte[]);
			if (array == null)
			{
				return null;
			}
		}
		4 = new 1061(1, array, 2);
		4.2();
		1425.1[1] = 4;
		return 4;
	}

	// Token: 0x06004C4A RID: 19530 RVA: 0x001E1EC4 File Offset: 0x001E00C4
	internal static 1426 5(1510 1, string 2, byte[] 3)
	{
		1061 4 = new 1061("sh_" + 2 + ".fs", 3, 35632);
		4.2();
		List<1061> 5 = new List<1061>
		{
			1425.4(1.ToString(), 35633, false),
			4
		};
		1426 6 = new 1426(1.ToString() + "/" + 2, 5);
		if (!6.3)
		{
			string[] array = new string[6];
			array[0] = "Loading shader ";
			array[1] = 1.ToString();
			array[2] = "/";
			array[3] = 2;
			array[4] = ": ";
			int num = 5;
			StringBuilder 7 = 6.2;
			array[num] = ((7 != null) ? 7.ToString() : null);
			1338.5(string.Concat(array), 1341.Runtime, (1114)0);
		}
		return 6;
	}

	// Token: 0x06004C4B RID: 19531 RVA: 0x001E1F9C File Offset: 0x001E019C
	internal static 1426 6(1510 1, 1049 2, bool 3)
	{
		string str = string.Format("{0}/{1}", 1, 2);
		List<1061> list = new List<1061>();
		list.Add(1425.4(1.ToString(), 35633, false));
		list.Add(1425.4(2.ToString(), 35632, false));
		1426 4 = new 1426(str, list);
		if (!4.3)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("Loading shader " + str + ":");
			stringBuilder.Append(4.2);
			stringBuilder.AppendLine("Parts:");
			foreach (1061 5 in list)
			{
				stringBuilder.Append(5.1);
			}
			1338.5(stringBuilder.ToString(), 1341.Runtime, (1114)0);
		}
		return 4;
	}

	// Token: 0x040038C4 RID: 14532
	private static Dictionary<string, 1061> 1 = new Dictionary<string, 1061>();
}
