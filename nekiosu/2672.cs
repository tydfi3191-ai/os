using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using Microsoft.Win32;

// Token: 0x02000433 RID: 1075
[ComVisible(false)]
public static class 2672
{
	// Token: 0x06002172 RID: 8562 RVA: 0x00090091 File Offset: 0x0008E291
	public static string 1(Enum 1)
	{
		return 1.1();
	}

	// Token: 0x06002173 RID: 8563 RVA: 0x0009009C File Offset: 0x0008E29C
	public static string 2(string 1)
	{
		foreach (char c in Path.GetInvalidFileNameChars())
		{
			1 = 1.Replace(c.ToString(), string.Empty);
		}
		return 1;
	}

	// Token: 0x06002174 RID: 8564 RVA: 0x000900D8 File Offset: 0x0008E2D8
	public static string 3(string 1)
	{
		foreach (char c in Path.GetInvalidFileNameChars())
		{
			1 = 1.Replace(c.ToString(), string.Empty);
		}
		1 = 1.Replace(".", string.Empty);
		return 1;
	}

	// Token: 0x06002175 RID: 8565 RVA: 0x00090124 File Offset: 0x0008E324
	public static bool 4(string 1, string 2)
	{
		try
		{
			using (RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey(1))
			{
				if (2 == null)
				{
					bool result;
					if (registryKey != null)
					{
						RegistryKey registryKey2 = registryKey.OpenSubKey("shell\\open\\command");
						result = !string.IsNullOrEmpty(((registryKey2 != null) ? registryKey2.GetValue(string.Empty) : null) as string);
					}
					else
					{
						result = false;
					}
					return result;
				}
				if (registryKey == null || registryKey.OpenSubKey("shell\\open\\command").GetValue(string.Empty).ToString() != string.Format("\"{0}\" \"%1\"", 2))
				{
					return false;
				}
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	// Token: 0x06002176 RID: 8566 RVA: 0x0001702D File Offset: 0x0001522D
	public static bool 5(string 1, string 2)
	{
		return true;
	}

	// Token: 0x06002177 RID: 8567 RVA: 0x0001702D File Offset: 0x0001522D
	public static bool 6(string 1)
	{
		return true;
	}

	// Token: 0x06002178 RID: 8568 RVA: 0x0001702D File Offset: 0x0001522D
	public static bool 7(string 1)
	{
		return true;
	}

	// Token: 0x06002179 RID: 8569 RVA: 0x000901D8 File Offset: 0x0008E3D8
	public static void 8(string 1, string 2, FileSystemRights 3, InheritanceFlags 4, PropagationFlags 5, AccessControlType 6)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(1);
		DirectorySecurity accessControl = directoryInfo.GetAccessControl();
		accessControl.AddAccessRule(new FileSystemAccessRule(2, 3, 4, 5, 6));
		directoryInfo.SetAccessControl(accessControl);
	}

	// Token: 0x0600217A RID: 8570 RVA: 0x0009020A File Offset: 0x0008E40A
	public static string 9(string 1)
	{
		if (1 == null)
		{
			return null;
		}
		return 2672.10(1, Encoding.UTF8, true);
	}

	// Token: 0x0600217B RID: 8571 RVA: 0x0009021D File Offset: 0x0008E41D
	public static string 10(string 1, Encoding 2, bool 3)
	{
		if (1 == null)
		{
			return null;
		}
		return Encoding.ASCII.GetString(2672.11(1, 2, 3));
	}

	// Token: 0x0600217C RID: 8572 RVA: 0x00090238 File Offset: 0x0008E438
	public static byte[] 11(string 1, Encoding 2, bool 3)
	{
		if (1 == null)
		{
			return null;
		}
		byte[] bytes = 2.GetBytes(1);
		return 2672.12(bytes, 0, bytes.Length, false, 3);
	}

	// Token: 0x0600217D RID: 8573 RVA: 0x00090260 File Offset: 0x0008E460
	private static byte[] 12(byte[] 1, int 2, int 3, bool 4, bool 5)
	{
		int num = 0;
		int num2 = 0;
		for (int i = 0; i < 3; i++)
		{
			char c = (char)1[2 + i];
			if (5 && c == ' ')
			{
				num++;
			}
			else if (!2672.13(c))
			{
				num2++;
			}
		}
		if (!4 && num == 0 && num2 == 0)
		{
			return 1;
		}
		byte[] array = new byte[3 + num2 * 2];
		int num3 = 0;
		for (int j = 0; j < 3; j++)
		{
			byte b = 1[2 + j];
			char c2 = (char)b;
			if (2672.13(c2))
			{
				array[num3++] = b;
			}
			else if (5 && c2 == ' ')
			{
				array[num3++] = 43;
			}
			else
			{
				array[num3++] = 37;
				array[num3++] = (byte)2672.14(b >> 4 & 15);
				array[num3++] = (byte)2672.14((int)(b & 15));
			}
		}
		return array;
	}

	// Token: 0x0600217E RID: 8574 RVA: 0x00090334 File Offset: 0x0008E534
	public static bool 13(char 1)
	{
		if ((1 >= 'a' && 1 <= 'z') || (1 >= 'A' && 1 <= 'Z') || (1 >= '0' && 1 <= '9'))
		{
			return true;
		}
		if (1 != '!')
		{
			switch (1)
			{
			case '\'':
			case '(':
			case ')':
			case '*':
			case '-':
			case '.':
				return true;
			case '+':
			case ',':
				break;
			default:
				if (1 == '_')
				{
					return true;
				}
				break;
			}
			return false;
		}
		return true;
	}

	// Token: 0x0600217F RID: 8575 RVA: 0x00028797 File Offset: 0x00026997
	public static char 14(int 1)
	{
		if (1 <= 9)
		{
			return (char)(1 + 48);
		}
		return (char)(1 - 10 + 97);
	}

	// Token: 0x06002180 RID: 8576 RVA: 0x00090398 File Offset: 0x0008E598
	public static void 15(string 1)
	{
		string[] array = Directory.GetFiles(1);
		for (int i = 0; i < array.Length; i++)
		{
			FileInfo fileInfo = new FileInfo(array[i]);
			if ((fileInfo.Attributes & FileAttributes.ReadOnly) > (FileAttributes)0)
			{
				fileInfo.Attributes &= ~FileAttributes.ReadOnly;
			}
		}
		array = Directory.GetDirectories(1);
		for (int j = 0; j < array.Length; j++)
		{
			2672.15(array[j]);
		}
	}

	// Token: 0x06002181 RID: 8577 RVA: 0x000903FC File Offset: 0x0008E5FC
	public static bool 16(string 1, string 2, bool 3)
	{
		1 = 2672.17(1);
		2 = 2672.17(2);
		if (1 == 2)
		{
			return true;
		}
		try
		{
			if (3)
			{
				2672.20(2);
			}
			File.Move(1, 2);
		}
		catch
		{
			return false;
		}
		return true;
	}

	// Token: 0x06002182 RID: 8578 RVA: 0x00090450 File Offset: 0x0008E650
	public static string 17(string 1)
	{
		return 1.Replace('\\', Path.DirectorySeparatorChar).Replace('/', Path.DirectorySeparatorChar).TrimEnd(new char[]
		{
			Path.DirectorySeparatorChar
		});
	}

	// Token: 0x06002183 RID: 8579 RVA: 0x0009047E File Offset: 0x0008E67E
	public static string 18(string 1)
	{
		return 1.Replace(Path.DirectorySeparatorChar, '/');
	}

	// Token: 0x06002184 RID: 8580 RVA: 0x00090490 File Offset: 0x0008E690
	public static bool 19(string 1)
	{
		1 = 2672.17(1);
		try
		{
			File.Delete(1);
			return true;
		}
		catch
		{
		}
		string text = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
		try
		{
			File.Move(1, text);
		}
		catch
		{
			text = 1;
		}
		return 2672.2674.MoveFileEx(text, null, (2672.2673)4);
	}

	// Token: 0x06002185 RID: 8581 RVA: 0x00090504 File Offset: 0x0008E704
	public static bool 20(string 1)
	{
		1 = 2672.17(1);
		if (!File.Exists(1))
		{
			return true;
		}
		try
		{
			File.Delete(1);
			return true;
		}
		catch
		{
		}
		try
		{
			if (!Directory.Exists("_cleanup"))
			{
				Directory.CreateDirectory("_cleanup").Attributes |= FileAttributes.Hidden;
			}
			File.Move(1, "_cleanup/" + Guid.NewGuid().ToString());
			return true;
		}
		catch
		{
		}
		return false;
	}

	// Token: 0x06002186 RID: 8582 RVA: 0x000905A0 File Offset: 0x0008E7A0
	public static string 21(string 1, bool 2)
	{
		if (1 == null)
		{
			return null;
		}
		StringBuilder stringBuilder = new StringBuilder(1.Length);
		foreach (char c in 1)
		{
			if (c <= '~')
			{
				stringBuilder.Append(c);
			}
		}
		if (2)
		{
			return stringBuilder.ToString().Trim();
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06002187 RID: 8583 RVA: 0x000905FC File Offset: 0x0008E7FC
	public static void 22(string 1, string 2)
	{
		1 = 2672.17(1);
		2 = 2672.17(2);
		if (1 == 2)
		{
			return;
		}
		foreach (string text in Directory.GetDirectories(1))
		{
			string text2 = text;
			text2 = Path.Combine(2, text2.Remove(0, 1 + text2.LastIndexOf(Path.DirectorySeparatorChar)));
			try
			{
				DirectoryInfo directoryInfo = Directory.CreateDirectory(text2);
				if ((new DirectoryInfo(text).Attributes & FileAttributes.Hidden) > (FileAttributes)0)
				{
					directoryInfo.Attributes |= FileAttributes.Hidden;
				}
			}
			catch
			{
			}
			2672.22(text, text2);
		}
		bool flag = Directory.Exists(2);
		if (!flag)
		{
			DirectoryInfo directoryInfo2 = Directory.CreateDirectory(2);
			try
			{
				if ((new DirectoryInfo(1).Attributes & FileAttributes.Hidden) > (FileAttributes)0)
				{
					directoryInfo2.Attributes |= FileAttributes.Hidden;
				}
			}
			catch
			{
			}
		}
		foreach (string text3 in Directory.GetFiles(1))
		{
			string text4 = Path.Combine(2, Path.GetFileName(text3));
			if (!2672.16(text3, text4, flag))
			{
				try
				{
					File.Copy(text3, text4);
				}
				catch
				{
				}
				File.Delete(text3);
			}
		}
		Directory.Delete(1, true);
	}

	// Token: 0x06002188 RID: 8584 RVA: 0x00090744 File Offset: 0x0008E944
	public static string 23(string 1)
	{
		return Path.GetExtension(1).Trim(new char[]
		{
			'.'
		}).ToLower();
	}

	// Token: 0x06002189 RID: 8585 RVA: 0x00090764 File Offset: 0x0008E964
	public static 2670 24(string 1)
	{
		2670 result;
		try
		{
			string text = 2672.23(1);
			uint num = 299.Method0301(text);
			if (num <= 2877453236U)
			{
				if (num <= 1191122858U)
				{
					if (num <= 333626681U)
					{
						if (num != 317839295U)
						{
							if (num == 333626681U)
							{
								if (text == "wav")
								{
									return (2670)8;
								}
							}
						}
						else if (text == "osz2")
						{
							return (2670)2;
						}
					}
					else if (num != 334318229U)
					{
						if (num != 476447045U)
						{
							if (num == 1191122858U && text == "rar")
							{
								return (2670)3;
							}
						}
						else if (text == "avi")
						{
							goto IL_307;
						}
					}
					else if (text == "wmv")
					{
						goto IL_307;
					}
				}
				else if (num <= 1748353692U)
				{
					if (num != 1461503683U)
					{
						if (num != 1738962391U)
						{
							if (num == 1748353692U && text == "png")
							{
								goto IL_2FE;
							}
						}
						else if (text == "exe")
						{
							return (2670)15;
						}
					}
					else if (text == "db")
					{
						return (2670)14;
					}
				}
				else if (num != 2625189937U)
				{
					if (num != 2641967556U)
					{
						if (num == 2877453236U && text == "zip")
						{
							return (2670)4;
						}
					}
					else if (text == "mp4")
					{
						goto IL_307;
					}
				}
				else if (text == "mp3")
				{
					goto IL_303;
				}
			}
			else if (num <= 3240126767U)
			{
				if (num <= 3105905815U)
				{
					if (num != 2921352006U)
					{
						if (num != 2971684863U)
						{
							if (num == 3105905815U)
							{
								if (text == "osz")
								{
									return (2670)1;
								}
							}
						}
						else if (text == "osr")
						{
							return (2670)11;
						}
					}
					else if (text == "osu")
					{
						return (2670)0;
					}
				}
				else if (num != 3202323235U)
				{
					if (num != 3223349148U)
					{
						if (num == 3240126767U)
						{
							if (text == "osb")
							{
								return (2670)9;
							}
						}
					}
					else if (text == "osc")
					{
						return (2670)6;
					}
				}
				else if (text == "jpeg")
				{
					goto IL_2FE;
				}
			}
			else if (num <= 3426548884U)
			{
				if (num != 3270600603U)
				{
					if (num != 3357570100U)
					{
						if (num == 3426548884U && text == "ogg")
						{
							goto IL_303;
						}
					}
					else if (text == "osk")
					{
						return (2670)10;
					}
				}
				else if (text == "flv")
				{
					goto IL_307;
				}
			}
			else if (num != 3491882646U)
			{
				if (num != 3670499120U)
				{
					if (num == 4034509933U && text == "mpg")
					{
						goto IL_307;
					}
				}
				else if (text == "jpg")
				{
					goto IL_2FE;
				}
			}
			else if (text == "m4v")
			{
				goto IL_307;
			}
			return (2670)16;
			IL_2FE:
			return (2670)12;
			IL_303:
			return (2670)7;
			IL_307:
			result = (2670)13;
		}
		catch
		{
			result = (2670)16;
		}
		return result;
	}

	// Token: 0x0600218A RID: 8586 RVA: 0x00090AA0 File Offset: 0x0008ECA0
	public static int 25(string 1)
	{
		int num = 1.Length;
		string[] array = Directory.GetFiles(1);
		foreach (string text in array)
		{
			if (text.Length > num)
			{
				num = text.Length;
			}
		}
		array = Directory.GetDirectories(1);
		for (int j = 0; j < array.Length; j++)
		{
			int num2 = 2672.25(array[j]);
			if (num2 > num)
			{
				num = num2;
			}
		}
		return num;
	}

	// Token: 0x0600218B RID: 8587 RVA: 0x00090B0F File Offset: 0x0008ED0F
	public static string 26(string 1)
	{
		return 2672.18(1.Trim(new char[]
		{
			'"'
		}));
	}

	// Token: 0x0600218C RID: 8588 RVA: 0x00090B28 File Offset: 0x0008ED28
	public static byte[] 27(string 1)
	{
		int length = 1.Length;
		byte[] array = new byte[length / 2];
		for (int i = 0; i < length; i += 2)
		{
			array[i / 2] = Convert.ToByte(1.Substring(i, 2), 16);
		}
		return array;
	}

	// Token: 0x0600218D RID: 8589 RVA: 0x00090B68 File Offset: 0x0008ED68
	public unsafe static bool 28(byte[] 1, byte[] 2)
	{
		if (1 == null || 2 == null || 1.Length != 2.Length)
		{
			return false;
		}
		byte* ptr;
		if (1 == null || 1.Length == 0)
		{
			ptr = null;
		}
		else
		{
			ptr = &1[0];
		}
		byte* ptr2;
		if (2 == null || 2.Length == 0)
		{
			ptr2 = null;
		}
		else
		{
			ptr2 = &2[0];
		}
		byte* ptr3 = ptr;
		byte* ptr4 = ptr2;
		int num = 1.Length;
		int i = 0;
		while (i < num / 8)
		{
			if (*(long*)ptr3 != *(long*)ptr4)
			{
				return false;
			}
			i++;
			ptr3 += 8;
			ptr4 += 8;
		}
		if ((num & 4) != 0)
		{
			if (*(int*)ptr3 != *(int*)ptr4)
			{
				return false;
			}
			ptr3 += 4;
			ptr4 += 4;
		}
		if ((num & 2) != 0)
		{
			if (*(short*)ptr3 != *(short*)ptr4)
			{
				return false;
			}
			ptr3 += 2;
			ptr4 += 2;
		}
		return (num & 1) == 0 || *ptr3 == *ptr4;
	}

	// Token: 0x0600218E RID: 8590 RVA: 0x00090C34 File Offset: 0x0008EE34
	public static bool 29(string 1)
	{
		string 2 = (new SecurityIdentifier(WellKnownSidType.BuiltinUsersSid, null).Translate(typeof(NTAccount)) as NTAccount).ToString();
		try
		{
			2672.8(1, 2, FileSystemRights.FullControl, InheritanceFlags.None, PropagationFlags.NoPropagateInherit, AccessControlType.Allow);
			2672.8(1, 2, FileSystemRights.FullControl, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.InheritOnly, AccessControlType.Allow);
			2672.15(1);
		}
		catch
		{
			return false;
		}
		return true;
	}

	// Token: 0x0600218F RID: 8591 RVA: 0x00090CA4 File Offset: 0x0008EEA4
	private static string 30(string 1)
	{
		string text = 268.HasOwnDataDirectory ? (Path.GetFullPath(268.DataDirectory).TrimEnd(new char[]
		{
			'\\'
		}) + "\\") : null;
		if (text != null && 1.StartsWith(text, StringComparison.OrdinalIgnoreCase))
		{
			return 268.BackupDirectory;
		}
		return Path.Combine(Path.GetDirectoryName(1), "backups");
	}

	// Token: 0x06002190 RID: 8592 RVA: 0x00090D04 File Offset: 0x0008EF04
	internal static string 31(string 1)
	{
		string fullPath = Path.GetFullPath(1);
		string text = 2672.30(fullPath);
		string text2 = Path.Combine(text, Path.GetFileName(fullPath) + ".backup");
		string text3 = fullPath + ".backup";
		try
		{
			if (File.Exists(text3))
			{
				Directory.CreateDirectory(text);
				if (File.Exists(text2))
				{
					File.Delete(text3);
				}
				else
				{
					File.Move(text3, text2);
				}
			}
		}
		catch
		{
		}
		return text2;
	}

	// Token: 0x06002191 RID: 8593 RVA: 0x00090D80 File Offset: 0x0008EF80
	public static void 32(string 1)
	{
		string fullPath = Path.GetFullPath(1);
		string text = 2672.30(fullPath);
		Directory.CreateDirectory(text);
		string text2 = Path.Combine(text, Path.GetFileName(fullPath) + "." + DateTime.Now.Ticks.ToString() + ".bak");
		if (File.Exists(1) && !File.Exists(text2))
		{
			File.Move(1, text2);
		}
	}

	// Token: 0x06002192 RID: 8594 RVA: 0x00090DE8 File Offset: 0x0008EFE8
	public static string 33(string 1, string 2)
	{
		1 = 2672.18(1).TrimEnd(new char[]
		{
			'/'
		});
		2 = 2672.18(2).TrimEnd(new char[]
		{
			'/'
		});
		if (1.Length < 2.Length + 1 || 1[2.Length] != '/' || !1.StartsWith(2))
		{
			throw new ArgumentException(1 + " isn't contained in " + 2);
		}
		return 1.Substring(2.Length + 1);
	}

	// Token: 0x06002193 RID: 8595 RVA: 0x00090E6E File Offset: 0x0008F06E
	public static string 34(string 1)
	{
		string text = Path.Combine(Path.GetTempPath(), "osu!");
		Directory.CreateDirectory(text);
		return Path.Combine(text, 1);
	}

	// Token: 0x06002194 RID: 8596 RVA: 0x00090E8C File Offset: 0x0008F08C
	public static string 35(string 1)
	{
		int num = 1.LastIndexOf('.');
		if (num != -1)
		{
			return 1.Substring(0, num);
		}
		return 1;
	}

	// Token: 0x02000434 RID: 1076
	public enum 2673
	{

	}

	// Token: 0x02000435 RID: 1077
	public static class 2674
	{
		// Token: 0x06002195 RID: 8597
		[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern bool MoveFileEx(string 1, string 2, 2672.2673 3);
	}
}
