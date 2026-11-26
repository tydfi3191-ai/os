using System;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using System.Text;

// Token: 0x02000BD5 RID: 3029
[ComVisible(false)]
public static class 1209
{
	// Token: 0x060052F9 RID: 21241 RVA: 0x002099B4 File Offset: 0x00207BB4
	public static string 1(string 1)
	{
		MD5 obj = 1209.1;
		string result;
		lock (obj)
		{
			if (!File.Exists(1))
			{
				result = string.Empty;
			}
			else
			{
				try
				{
					using (Stream stream = File.Open(1, FileMode.Open, FileAccess.Read, FileShare.Read))
					{
						byte[] array = 1209.1.ComputeHash(stream);
						StringBuilder stringBuilder = new StringBuilder();
						for (int i = 0; i < array.Length; i++)
						{
							stringBuilder.Append(array[i].ToString("x2"));
						}
						result = stringBuilder.ToString();
					}
				}
				catch (Exception)
				{
					result = string.Empty;
				}
			}
		}
		return result;
	}

	// Token: 0x060052FA RID: 21242 RVA: 0x00209A80 File Offset: 0x00207C80
	public static string 2(SecureString 1)
	{
		string s = 1.ToUnsecureString();
		byte[] array = 1209.2.GetBytes(s);
		MD5 obj = 1209.1;
		string result;
		lock (obj)
		{
			try
			{
				array = 1209.1.ComputeHash(array);
			}
			catch (Exception)
			{
				result = "fail";
				goto IL_94;
			}
		}
		char[] array2 = new char[array.Length * 2];
		for (int i = 0; i < array.Length; i++)
		{
			array[i].ToString("x2", 1209.3).CopyTo(0, array2, i * 2, 2);
		}
		return new string(array2);
		IL_94:
		return result;
	}

	// Token: 0x04003F22 RID: 16162
	internal static MD5 1 = MD5.Create();

	// Token: 0x04003F23 RID: 16163
	internal static UTF8Encoding 2 = new UTF8Encoding();

	// Token: 0x04003F24 RID: 16164
	internal static NumberFormatInfo 3 = new CultureInfo("en-US", false).NumberFormat;
}
