using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

// Token: 0x02000A3D RID: 2621
[ComVisible(false)]
public sealed class 1514 : IDisposable
{
	// Token: 0x0600486A RID: 18538 RVA: 0x001CB66C File Offset: 0x001C986C
	static 1514()
	{
		new 1193(1990).4(1514.4);
	}

	// Token: 0x0600486B RID: 18539 RVA: 0x001CB6BA File Offset: 0x001C98BA
	public 1514(string 1) : this(1, null, false, false)
	{
	}

	// Token: 0x0600486C RID: 18540 RVA: 0x001CB6C6 File Offset: 0x001C98C6
	public 1514(string 1, bool 2, bool 3 = false) : this(1, null, 2, 3)
	{
	}

	// Token: 0x0600486D RID: 18541 RVA: 0x001CB6D4 File Offset: 0x001C98D4
	public 1514(Stream 1, bool 2 = false)
	{
		this.21 = true;
		this.30 = new object();
		base..ctor();
		this.19 = 1;
		try
		{
			this.10(2);
		}
		catch (Exception)
		{
			this.Close();
			throw;
		}
	}

	// Token: 0x0600486E RID: 18542 RVA: 0x001CB724 File Offset: 0x001C9924
	public 1514(string 1, byte[] 2, bool 3, bool 4)
	{
		this.21 = true;
		this.30 = new object();
		base..ctor();
		this.24 = !File.Exists(1);
		if (this.24 && !3)
		{
			throw new IOException("File does not exist (" + 1 + ").");
		}
		if (2 != null)
		{
			this.3 = 2;
		}
		try
		{
			this.5 = 1;
			if (!this.24)
			{
				this.19 = File.Open(1, FileMode.Open, FileAccess.Read, FileShare.Read);
			}
			this.10(false);
		}
		catch (Exception)
		{
			this.Close();
			throw;
		}
	}

	// Token: 0x0600486F RID: 18543 RVA: 0x001CB7C4 File Offset: 0x001C99C4
	public byte[] 1()
	{
		return this.10;
	}

	// Token: 0x06004870 RID: 18544 RVA: 0x001CB7CC File Offset: 0x001C99CC
	private void 2(byte[] 1)
	{
		this.10 = 1;
	}

	// Token: 0x06004871 RID: 18545 RVA: 0x001CB7D5 File Offset: 0x001C99D5
	public byte[] 3()
	{
		return this.11;
	}

	// Token: 0x06004872 RID: 18546 RVA: 0x001CB7DD File Offset: 0x001C99DD
	private void 4(byte[] 1)
	{
		this.11 = 1;
	}

	// Token: 0x06004873 RID: 18547 RVA: 0x001CB7E6 File Offset: 0x001C99E6
	public byte[] 5()
	{
		return this.12;
	}

	// Token: 0x06004874 RID: 18548 RVA: 0x001CB7EE File Offset: 0x001C99EE
	private void 6(byte[] 1)
	{
		this.12 = 1;
	}

	// Token: 0x06004875 RID: 18549 RVA: 0x001CB7F7 File Offset: 0x001C99F7
	public int 7()
	{
		return this.25;
	}

	// Token: 0x06004876 RID: 18550 RVA: 0x001CB7FF File Offset: 0x001C99FF
	public bool 8()
	{
		return this.27;
	}

	// Token: 0x06004877 RID: 18551 RVA: 0x001CB807 File Offset: 0x001C9A07
	private void 9(bool 1)
	{
		this.27 = 1;
	}

	// Token: 0x06004878 RID: 18552 RVA: 0x001CB810 File Offset: 0x001C9A10
	~1514()
	{
		this.42(false);
	}

	// Token: 0x06004879 RID: 18553 RVA: 0x001CB840 File Offset: 0x001C9A40
	private void 10(bool 1)
	{
		this.18 = new Dictionary<1513, string>();
		this.6 = new Dictionary<string, 1519>(StringComparer.CurrentCultureIgnoreCase);
		this.13 = new SortedDictionary<string, int>();
		this.14 = new Dictionary<string, DateTime>();
		this.15 = new Dictionary<string, DateTime>();
		this.16 = new Dictionary<string, bool>();
		this.17 = new List<1517>();
		this.7 = new Dictionary<string, byte[]>(StringComparer.CurrentCultureIgnoreCase);
		this.23 = false;
		this.22 = false;
		this.20 = false;
		if (this.24)
		{
			this.25 = 0;
			this.26 = 0;
			425 2 = new 735();
			try
			{
				2.GenerateIV();
				this.9 = new byte[2.IV.Length];
				Array.Copy(2.IV, this.9, this.9.Length);
				2.Clear();
				return;
			}
			finally
			{
				((IDisposable)2).Dispose();
			}
		}
		BinaryReader binaryReader = new BinaryReader(this.19);
		byte[] array = binaryReader.ReadBytes(3);
		if (array.Length < 3 || array[0] != 236 || array[1] != 72 || array[2] != 79)
		{
			throw new IOException("Invalid file.");
		}
		binaryReader.ReadByte();
		this.9 = binaryReader.ReadBytes(16);
		this.2(binaryReader.ReadBytes(16));
		this.4(binaryReader.ReadBytes(16));
		this.6(binaryReader.ReadBytes(16));
		MemoryStream memoryStream = new MemoryStream();
		try
		{
			BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
			try
			{
				int num = binaryReader.ReadInt32();
				binaryWriter.Write(num);
				for (int i = 0; i < num; i++)
				{
					short num2 = binaryReader.ReadInt16();
					string value = binaryReader.ReadString();
					if (Enum.IsDefined(typeof(1513), (int)num2))
					{
						this.18.Add((1513)num2, value);
					}
					binaryWriter.Write(num2);
					binaryWriter.Write(value);
				}
				binaryWriter.Flush();
				if (!2672.28(1514.16(memoryStream.ToArray(), num * 3, 167), this.1()))
				{
					throw new IOException("File failed integrity check.");
				}
				binaryWriter.Close();
			}
			finally
			{
				((IDisposable)binaryWriter).Dispose();
			}
		}
		finally
		{
			((IDisposable)memoryStream).Dispose();
		}
		int num3 = binaryReader.ReadInt32();
		for (int j = 0; j < num3; j++)
		{
			this.13.Add(binaryReader.ReadString(), binaryReader.ReadInt32());
		}
		if (this.3 == null)
		{
			string s = this.18[1513.Creator] + "yhxyfjo5" + this.18[1513.BeatmapSetID];
			this.3 = 1514.18(Encoding.ASCII.GetBytes(s));
		}
		if (1)
		{
			this.28 = binaryReader.BaseStream.Position;
			return;
		}
		this.11(binaryReader);
	}

	// Token: 0x0600487A RID: 18554 RVA: 0x001CBB20 File Offset: 0x001C9D20
	private void 11(BinaryReader 1)
	{
		this.23(true);
		2669 2 = new 2669(1.BaseStream, (594)0, this.3);
		try
		{
			byte[] buffer = new byte[64];
			2.Read(buffer, 0, 64);
			if (!2672.28(buffer, 1514.4))
			{
				throw new Exception("Invalid key");
			}
		}
		finally
		{
			((IDisposable)2).Dispose();
		}
		this.26 = (int)1.BaseStream.Position;
		int num = 1.ReadInt32();
		for (int i = 0; i < 16; i += 2)
		{
			num -= ((int)this.3()[i] | (int)this.3()[i + 1] << 17);
		}
		byte[] buffer2 = 1.ReadBytes(num);
		this.25 = (int)1.BaseStream.Position;
		for (int j = 0; j < this.9.Length; j++)
		{
			byte[] array = this.9;
			int num2 = j;
			array[num2] ^= this.5()[j % 16];
		}
		425 3 = new 735();
		try
		{
			3.IV = this.9;
			3.Key = this.3;
			MemoryStream memoryStream = new MemoryStream(buffer2);
			try
			{
				Stream stream = new 2669(memoryStream, (594)1, this.3);
				try
				{
					BinaryReader binaryReader = new BinaryReader(stream);
					try
					{
						int num3 = binaryReader.ReadInt32();
						if (!2672.28(1514.16(buffer2, num3 * 4, 209), this.3()))
						{
							throw new IOException("File failed integrity check.");
						}
						int num4 = binaryReader.ReadInt32();
						int k = 0;
						while (k < num3)
						{
							string key = binaryReader.ReadString();
							byte[] array2 = binaryReader.ReadBytes(16);
							DateTime dateTime = DateTime.FromBinary(binaryReader.ReadInt64());
							DateTime dateTime2 = DateTime.FromBinary(binaryReader.ReadInt64());
							int num5 = (k + 1 >= num3) ? ((int)1.BaseStream.Length - this.25) : binaryReader.ReadInt32();
							int num6 = num5 - num4;
							if (!1514.22(key))
							{
								goto IL_2DD;
							}
							long position = 1.BaseStream.Position;
							bool flag;
							if ((long)(this.25 + num4 + num6 / 2 - 512 + 4) >= 1.BaseStream.Length || num6 < 1024)
							{
								flag = true;
							}
							else
							{
								byte[] buffer3 = new byte[1024];
								1517 4 = new 1517(this.24(), this.25 + num4, num6 - 4, this.9, this.3);
								try
								{
									int num7 = (num6 - 4) / 2;
									4.Seek((long)(num7 - num7 % 16 - 512 + 16), SeekOrigin.Begin);
									4.Read(buffer3, 0, 1024);
									1.BaseStream.Position = position;
								}
								finally
								{
									((IDisposable)4).Dispose();
								}
								flag = !BitConverter.ToString(1514.1.ComputeHash(buffer3)).Replace("-", string.Empty).Equals(this.18[1513.VideoHash]);
							}
							if (!flag)
							{
								goto IL_2DD;
							}
							this.21 = false;
							this.9(true);
							num4 = num5;
							IL_2FF:
							k++;
							continue;
							IL_2DD:
							this.6.Add(key, new 1519(key, num4, num6, array2, dateTime, dateTime2));
							num4 = num5;
							goto IL_2FF;
						}
						binaryReader.Close();
					}
					finally
					{
						((IDisposable)binaryReader).Dispose();
					}
				}
				finally
				{
					((IDisposable)stream).Dispose();
				}
			}
			finally
			{
				((IDisposable)memoryStream).Dispose();
			}
			3.Clear();
		}
		finally
		{
			((IDisposable)3).Dispose();
		}
		this.19.Seek(0L, SeekOrigin.Begin);
	}

	// Token: 0x0600487B RID: 18555 RVA: 0x001CBF10 File Offset: 0x001CA110
	private void 12(Dictionary<string, byte[]> 1, ICryptoTransform 2)
	{
		string[] array = new string[1.Keys.Count];
		1.Keys.CopyTo(array, 0);
		foreach (string key in array)
		{
			MemoryStream memoryStream = new MemoryStream();
			try
			{
				Stream stream = new 2669(memoryStream, (594)1, this.3);
				try
				{
					BinaryWriter binaryWriter = new BinaryWriter(stream);
					try
					{
						binaryWriter.Write(1[key].Length);
						if (!this.16[key])
						{
							binaryWriter.Write(1[key]);
						}
						else
						{
							memoryStream.Write(1[key], 0, 1[key].Length);
						}
						stream.Flush();
						1[key] = memoryStream.ToArray();
						binaryWriter.Close();
					}
					finally
					{
						((IDisposable)binaryWriter).Dispose();
					}
				}
				finally
				{
					((IDisposable)stream).Dispose();
				}
			}
			finally
			{
				((IDisposable)memoryStream).Dispose();
			}
		}
	}

	// Token: 0x0600487C RID: 18556 RVA: 0x001CC01C File Offset: 0x001CA21C
	private static byte[] 13(SortedDictionary<string, byte[]> 1)
	{
		MemoryStream memoryStream = new MemoryStream();
		byte[] result;
		try
		{
			BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
			try
			{
				foreach (byte[] buffer in 1.Values)
				{
					binaryWriter.Write(buffer);
				}
				binaryWriter.Flush();
				byte[] array = memoryStream.ToArray();
				binaryWriter.Close();
				result = array;
			}
			finally
			{
				((IDisposable)binaryWriter).Dispose();
			}
		}
		finally
		{
			((IDisposable)memoryStream).Dispose();
		}
		return result;
	}

	// Token: 0x0600487D RID: 18557 RVA: 0x001CC0BC File Offset: 0x001CA2BC
	private byte[] 14(SortedDictionary<string, byte[]> 1, Dictionary<string, byte[]> 2, Dictionary<string, DateTime> 3, Dictionary<string, DateTime> 4, ICryptoTransform 5)
	{
		MemoryStream memoryStream = new MemoryStream();
		byte[] result;
		try
		{
			2669 6 = new 2669(memoryStream, (594)1, this.3);
			try
			{
				BinaryWriter binaryWriter = new BinaryWriter(6);
				try
				{
					binaryWriter.Write(1.Count);
					int num = 0;
					foreach (KeyValuePair<string, byte[]> keyValuePair in 1)
					{
						binaryWriter.Write(num);
						binaryWriter.Write(keyValuePair.Key);
						2669 7 = new 2669(new MemoryStream(keyValuePair.Value, false), (594)1, this.3);
						try
						{
							byte[] buffer = new byte[keyValuePair.Value.Length];
							7.Read(buffer, 0, keyValuePair.Value.Length);
							byte[] array = 1514.1.ComputeHash(buffer, 4, keyValuePair.Value.Length - 4);
							binaryWriter.Write(array);
							binaryWriter.Write(3[keyValuePair.Key].ToBinary());
							binaryWriter.Write(4[keyValuePair.Key].ToBinary());
							2[keyValuePair.Key] = array;
						}
						finally
						{
							((IDisposable)7).Dispose();
						}
						num += keyValuePair.Value.Length;
					}
					6.Flush();
					binaryWriter.Flush();
					byte[] array2 = memoryStream.ToArray();
					6.Close();
					binaryWriter.Close();
					result = array2;
				}
				finally
				{
					((IDisposable)binaryWriter).Dispose();
				}
			}
			finally
			{
				((IDisposable)6).Dispose();
			}
		}
		finally
		{
			((IDisposable)memoryStream).Dispose();
		}
		return result;
	}

	// Token: 0x0600487E RID: 18558 RVA: 0x001CC2AC File Offset: 0x001CA4AC
	private static byte[] 15(Dictionary<1513, string> 1)
	{
		MemoryStream memoryStream = new MemoryStream();
		byte[] result;
		try
		{
			BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
			try
			{
				binaryWriter.Write(1.Count);
				foreach (KeyValuePair<1513, string> keyValuePair in 1)
				{
					binaryWriter.Write((ushort)keyValuePair.Key);
					binaryWriter.Write(keyValuePair.Value ?? string.Empty);
				}
				binaryWriter.Close();
				result = memoryStream.ToArray();
			}
			finally
			{
				((IDisposable)binaryWriter).Dispose();
			}
		}
		finally
		{
			((IDisposable)memoryStream).Dispose();
		}
		return result;
	}

	// Token: 0x0600487F RID: 18559 RVA: 0x001CC368 File Offset: 0x001CA568
	private static byte[] 16(byte[] 1, int 2, byte 3)
	{
		byte[] result;
		try
		{
			1[2] ^= 3;
			byte[] array = 1514.1.ComputeHash(1);
			1[2] ^= 3;
			for (int i = 0; i < 8; i++)
			{
				byte b = array[i];
				array[i] = array[i + 8];
				array[i + 8] = b;
			}
			byte[] array2 = array;
			int num = 5;
			array2[num] ^= 45;
			result = array;
		}
		catch (Exception)
		{
			throw new IOException("File failed integrity check.");
		}
		return result;
	}

	// Token: 0x06004880 RID: 18560 RVA: 0x001CC3E8 File Offset: 0x001CA5E8
	private byte[] 17(Stream 1, int 2, byte 3)
	{
		long position = 1.Position;
		long num = 1.Length - position;
		string value = this.29(1513.VideoDataOffset);
		byte[] array;
		if (!string.IsNullOrEmpty(value))
		{
			long num2 = Convert.ToInt64(value);
			long num3 = Convert.ToInt64(this.29(1513.VideoDataLength));
			array = new byte[num - num3];
			1.Read(array, 0, (int)num2);
			long num4 = 1.Position + num3;
			if (num4 >= 1.Length)
			{
				1.Position = num4;
				1.Read(array, (int)(1.Position - position - num3), (int)(1.Length - 1.Position));
			}
			2 %= (int)(num - num3);
		}
		else
		{
			array = new byte[num];
			1.Read(array, 0, array.Length);
		}
		return 1514.16(array, 2, 3);
	}

	// Token: 0x06004881 RID: 18561 RVA: 0x001CC4AA File Offset: 0x001CA6AA
	public static byte[] 18(byte[] 1)
	{
		return 1514.1.ComputeHash(1);
	}

	// Token: 0x06004882 RID: 18562 RVA: 0x001CC4B8 File Offset: 0x001CA6B8
	public static bool 19(string 1)
	{
		2670 2 = 2672.24(1);
		return 2 == (2670)0 || 2 == (2670)6;
	}

	// Token: 0x06004883 RID: 18563 RVA: 0x001CC4D5 File Offset: 0x001CA6D5
	public static bool 20(string 1)
	{
		return 2672.24(1) == (2670)7;
	}

	// Token: 0x06004884 RID: 18564 RVA: 0x001CC4E0 File Offset: 0x001CA6E0
	public static bool 21(string 1)
	{
		2670 2 = 2672.24(1);
		return 2 == (2670)1 || 2 == (2670)2;
	}

	// Token: 0x06004885 RID: 18565 RVA: 0x001CC4FE File Offset: 0x001CA6FE
	public static bool 22(string 1)
	{
		return 2672.24(1) == (2670)13;
	}

	// Token: 0x06004886 RID: 18566 RVA: 0x001CC50A File Offset: 0x001CA70A
	private void 23(bool 1)
	{
		this.29 = 1;
	}

	// Token: 0x06004887 RID: 18567 RVA: 0x001CC513 File Offset: 0x001CA713
	public string 24()
	{
		return this.5;
	}

	// Token: 0x06004888 RID: 18568 RVA: 0x001CC51C File Offset: 0x001CA71C
	public string[] 25()
	{
		this.43();
		string[] array = new string[this.13.Count];
		this.13.Keys.CopyTo(array, 0);
		return array;
	}

	// Token: 0x06004889 RID: 18569 RVA: 0x001CC553 File Offset: 0x001CA753
	public int 26(string 1)
	{
		if (!this.13.ContainsKey(1))
		{
			return -2;
		}
		return this.13[1];
	}

	// Token: 0x0600488A RID: 18570 RVA: 0x001CC574 File Offset: 0x001CA774
	public void 27(string 1, int 2)
	{
		if (!this.13.ContainsKey(1))
		{
			throw new Exception("Map does not exist in this mappackage");
		}
		if (this.13.ContainsValue(2) && 2 != -1 && this.26(1) != 2)
		{
			throw new Exception("An other map already has this ID set");
		}
		this.13[1] = 2;
	}

	// Token: 0x0600488B RID: 18571 RVA: 0x001CC5CE File Offset: 0x001CA7CE
	public bool 28(string 1)
	{
		return this.6.ContainsKey(1) || this.7.ContainsKey(1);
	}

	// Token: 0x0600488C RID: 18572 RVA: 0x001CC5EC File Offset: 0x001CA7EC
	public string 29(1513 1)
	{
		this.43();
		string result;
		this.18.TryGetValue(1, out result);
		return result;
	}

	// Token: 0x0600488D RID: 18573 RVA: 0x001CC60F File Offset: 0x001CA80F
	public Stream 30(string 1)
	{
		return this.31(1, false);
	}

	// Token: 0x0600488E RID: 18574 RVA: 0x001CC61C File Offset: 0x001CA81C
	public Stream 31(string 1, bool 2)
	{
		this.43();
		Stream result = null;
		if (this.6.ContainsKey(4))
		{
			if (!2)
			{
				1517 3 = new 1517(this.19, this.25 + this.6[4].5(), this.6[4].3(), this.9, this.3);
				this.17.Add(3);
				3.3(delegate(1517 1)
				{
					if (!this.20 && this.17.Contains(1))
					{
						this.17.Remove(1);
					}
				});
				result = 3;
			}
			else
			{
				byte[] array = new byte[this.6[4].3() - 4];
				FileStream fileStream = File.Open(this.5, FileMode.Open, FileAccess.Read, FileShare.Read);
				fileStream.Seek((long)(this.25 + this.6[4].5() + 4), SeekOrigin.Begin);
				fileStream.Read(array, 0, array.Length);
				result = new MemoryStream(array, false);
			}
		}
		else if (this.7.ContainsKey(4))
		{
			result = new MemoryStream(this.7[4], false);
		}
		return result;
	}

	// Token: 0x0600488F RID: 18575 RVA: 0x001CC738 File Offset: 0x001CA938
	public void 32(1513 1, string 2)
	{
		this.43();
		this.18[1] = 2;
		this.23 = true;
		if (1 == 1513.Creator || 1 == 1513.BeatmapSetID)
		{
			string text;
			this.18.TryGetValue(1513.Creator, out text);
			string text2;
			this.18.TryGetValue(1513.BeatmapSetID, out text2);
			if (text != null && text2 != null && (this.3 == null || this.3 == 1514.2))
			{
				string s = text + "yhxyfjo5" + text2;
				this.3 = 1514.18(Encoding.ASCII.GetBytes(s));
			}
		}
	}

	// Token: 0x06004890 RID: 18576 RVA: 0x001CC7C8 File Offset: 0x001CA9C8
	public void 33(string 1, bool 2)
	{
		this.43();
		1 = 2672.18(1);
		string[] array;
		if (!2)
		{
			array = Directory.GetFiles(1);
		}
		else
		{
			List<string> list = new List<string>();
			Stack<string> stack = new Stack<string>();
			stack.Push(1);
			while (stack.Count > 0)
			{
				string path = stack.Pop();
				foreach (string item in Directory.GetFiles(path))
				{
					list.Add(item);
				}
				foreach (string item2 in Directory.GetDirectories(path))
				{
					stack.Push(item2);
				}
			}
			array = list.ToArray();
		}
		foreach (string path2 in array)
		{
			if (!1514.21(path2))
			{
				this.34(2672.33(path2, 1), path2, File.GetCreationTimeUtc(path2), File.GetLastWriteTimeUtc(path2));
			}
		}
		this.22 = true;
	}

	// Token: 0x06004891 RID: 18577 RVA: 0x001CC8C0 File Offset: 0x001CAAC0
	public void 34(string 1, string 2, DateTime 3, DateTime 4)
	{
		this.43();
		if (1514.21(1))
		{
			throw new IOException("Cannot add other map packages to a map package.");
		}
		byte[] buffer;
		using (FileStream fileStream = File.OpenRead(2))
		{
			buffer = new byte[fileStream.Length];
			fileStream.Read(buffer, 0, (int)fileStream.Length);
			fileStream.Close();
		}
		this.35(1, buffer, 3, 4);
		this.22 = true;
	}

	// Token: 0x06004892 RID: 18578 RVA: 0x001CC940 File Offset: 0x001CAB40
	public void 35(string 1, byte[] 2, DateTime 3, DateTime 4)
	{
		this.36(1, 2, 3, 4, false);
	}

	// Token: 0x06004893 RID: 18579 RVA: 0x001CC950 File Offset: 0x001CAB50
	public void 36(string 1, byte[] 2, DateTime 3, DateTime 4, bool 5)
	{
		this.43();
		if (1514.21(1))
		{
			throw new IOException("Cannot add other map packages to a map package.");
		}
		if (1514.19(1) && !this.13.ContainsKey(1))
		{
			this.13.Add(1, -1);
		}
		if (1514.22(1))
		{
			if (2.Length < 1024)
			{
				throw new IOException("Video needs to be atleast 1024 bytes big");
			}
			long num = this.8;
			foreach (KeyValuePair<string, 1519> keyValuePair in this.6)
			{
				num += (long)keyValuePair.Value.3();
			}
			byte[] array = new byte[1024];
			Array.Copy(2, (long)2.Length / 2L - (long)2.Length / 2L % 16L - 512L + 16L, array, 0L, 1024L);
			byte[] value = 1514.1.ComputeHash(array);
			this.32(1513.VideoDataOffset, Convert.ToString(num));
			this.32(1513.VideoDataLength, Convert.ToString(2.Length));
			this.32(1513.VideoHash, BitConverter.ToString(value).Replace("-", string.Empty));
			this.23 = true;
		}
		this.7[1] = 2;
		this.14[1] = 3;
		this.15[1] = 4;
		this.16[1] = 5;
		this.8 += (long)2.Length;
		if (this.6.ContainsKey(1))
		{
			this.6.Remove(1);
		}
		this.22 = true;
	}

	// Token: 0x06004894 RID: 18580 RVA: 0x001CCB00 File Offset: 0x001CAD00
	public void 37(string 1)
	{
		this.43();
		bool flag = false;
		if (this.6.ContainsKey(1))
		{
			this.6.Remove(1);
			flag = true;
		}
		if (this.7.ContainsKey(1))
		{
			this.7.Remove(1);
			this.14.Remove(1);
			this.15.Remove(1);
			this.16.Remove(1);
			flag = true;
		}
		if (flag)
		{
			this.22 = true;
			if (this.13.ContainsKey(1))
			{
				this.13.Remove(1);
			}
		}
	}

	// Token: 0x06004895 RID: 18581 RVA: 0x001CCB9C File Offset: 0x001CAD9C
	public static void 38(string 1, List<1519> 2, int 3, long 4)
	{
		2.Sort(new Comparison<1519>(1514.1515.instance.1));
		BinaryWriter binaryWriter = new BinaryWriter(new MemoryStream());
		try
		{
			binaryWriter.Write(new byte[3]);
			1514 5 = new 1514(1);
			try
			{
				using (FileStream fileStream = File.OpenRead(1))
				{
					int num = 5.7();
					foreach (1519 6 in 2)
					{
						if (5.6.ContainsKey(6.1()))
						{
							1519 7 = 5.6[6.1()];
							long num2 = (long)6.5() - binaryWriter.BaseStream.Position;
							if (num2 > 0L)
							{
								binaryWriter.Write(new byte[num2]);
							}
							byte[] array = new byte[6.3()];
							binaryWriter.Seek(6.5() + 3, SeekOrigin.Begin);
							fileStream.Seek((long)(7.5() + num), SeekOrigin.Begin);
							fileStream.Read(array, 0, array.Length);
							binaryWriter.Write(array);
						}
					}
				}
			}
			finally
			{
				((IDisposable)5).Dispose();
			}
			binaryWriter.Seek(0, SeekOrigin.Begin);
			using (FileStream fileStream2 = File.Open(1, FileMode.Create))
			{
				byte[] buffer = new byte[524288];
				Stream baseStream = binaryWriter.BaseStream;
				int count;
				while ((count = baseStream.Read(buffer, 0, 524288)) > 0)
				{
					fileStream2.Write(buffer, 0, count);
				}
				long position = fileStream2.Position;
			}
		}
		finally
		{
			((IDisposable)binaryWriter).Dispose();
		}
	}

	// Token: 0x06004896 RID: 18582 RVA: 0x001CCDAC File Offset: 0x001CAFAC
	public List<1519> 39()
	{
		List<1519> list = new List<1519>();
		foreach (1519 item in this.6.Values)
		{
			list.Add(item);
		}
		return list;
	}

	// Token: 0x06004897 RID: 18583 RVA: 0x001CCE0C File Offset: 0x001CB00C
	public bool Save()
	{
		return this.Save(false);
	}

	// Token: 0x06004898 RID: 18584 RVA: 0x001CCE18 File Offset: 0x001CB018
	public bool Save(bool 1)
	{
		this.43();
		if (!this.21 && !1)
		{
			throw new Exception("Cannot save a no-video beatmap if it's missing videodata when ignoreHeader is set to false");
		}
		if (!this.22 && !this.23)
		{
			return false;
		}
		if (this.17.Count != 0)
		{
			throw new IOException("Cannot save while streams are open.");
		}
		if (this.6.Count + this.7.Count == 0)
		{
			throw new IOException("Cannot save an empty package.");
		}
		if (this.19 != null)
		{
			this.19.Close();
		}
		byte[] array = null;
		if (this.24)
		{
			this.22 = true;
			this.23 = true;
		}
		else
		{
			array = File.ReadAllBytes(this.5);
		}
		using (425 2 = new 735())
		{
			BinaryWriter binaryWriter = new BinaryWriter(new MemoryStream());
			try
			{
				2.IV = this.9;
				2.Key = this.3;
				binaryWriter.Write(new byte[]
				{
					236,
					72,
					79
				});
				binaryWriter.Write(0);
				SortedDictionary<string, byte[]> sortedDictionary = new SortedDictionary<string, byte[]>(new 1514.1516());
				Dictionary<string, byte[]> dictionary = new Dictionary<string, byte[]>();
				Dictionary<string, DateTime> dictionary2 = new Dictionary<string, DateTime>();
				Dictionary<string, DateTime> dictionary3 = new Dictionary<string, DateTime>();
				byte[] array3;
				if (this.22)
				{
					foreach (KeyValuePair<string, 1519> keyValuePair in this.6)
					{
						byte[] array2 = new byte[keyValuePair.Value.3()];
						Array.Copy(array, this.25 + keyValuePair.Value.5(), array2, 0, array2.Length);
						sortedDictionary.Add(keyValuePair.Key, array2);
						dictionary2[keyValuePair.Key] = keyValuePair.Value.9();
						dictionary3[keyValuePair.Key] = keyValuePair.Value.11();
					}
					this.12(this.7, 2.CreateEncryptor());
					foreach (KeyValuePair<string, byte[]> keyValuePair2 in this.7)
					{
						sortedDictionary.Add(keyValuePair2.Key, keyValuePair2.Value);
						dictionary2[keyValuePair2.Key] = this.14[keyValuePair2.Key];
						dictionary3[keyValuePair2.Key] = this.15[keyValuePair2.Key];
					}
					array3 = 1514.13(sortedDictionary);
				}
				else
				{
					array3 = new byte[array.Length - this.25];
					Array.Copy(array, this.25, array3, 0, array3.Length);
				}
				byte[] array4 = new byte[this.9.Length];
				for (int i = 0; i < array4.Length; i++)
				{
					array4[i] = (this.9[i] ^ array3[i]);
				}
				binaryWriter.Write(array4);
				byte[] array5;
				if (this.23 || this.22)
				{
					array5 = 1514.15(this.18);
					binaryWriter.Write(array5);
					binaryWriter.Write(this.13.Count);
					foreach (KeyValuePair<string, int> keyValuePair3 in this.13)
					{
						binaryWriter.Write(keyValuePair3.Key);
						binaryWriter.Write(keyValuePair3.Value);
					}
					2669 3 = new 2669(binaryWriter.BaseStream, (594)0, this.3);
					try
					{
						3.Write(1514.4, 0, 64);
						goto IL_3AE;
					}
					finally
					{
						((IDisposable)3).Dispose();
					}
				}
				array5 = new byte[this.26 - 68];
				Array.Copy(array, 68, array5, 0, array5.Length);
				binaryWriter.Write(array5);
				IL_3AE:
				int num = (int)binaryWriter.BaseStream.Position;
				if (this.22)
				{
					byte[] array6 = this.14(sortedDictionary, dictionary, dictionary2, dictionary3, 2.CreateEncryptor());
					this.4(1514.16(array6, sortedDictionary.Count * 4, 209));
					int num2 = array6.Length;
					for (int j = 0; j < 16; j += 2)
					{
						num2 += ((int)this.3()[j] | (int)this.3()[j + 1] << 17);
					}
					binaryWriter.Write(num2);
					binaryWriter.Write(array6);
				}
				else
				{
					byte[] array7 = new byte[this.25 - this.26];
					Array.Copy(array, this.26, array7, 0, array7.Length);
					binaryWriter.Write(array7);
				}
				int num3 = (int)binaryWriter.BaseStream.Position;
				binaryWriter.Write(array3);
				if (!1)
				{
					this.2(1514.16(array5, this.18.Count * 3, 167));
					this.6(this.17(new MemoryStream(array3, false), array3.Length / 2, 159));
				}
				using (FileStream fileStream = File.Open(this.5, FileMode.Create, FileAccess.Write, FileShare.None))
				{
					byte[] buffer = new byte[524288];
					binaryWriter.Seek(0, SeekOrigin.Begin);
					Stream baseStream = binaryWriter.BaseStream;
					baseStream.Read(buffer, 0, 20);
					fileStream.Write(buffer, 0, 20);
					fileStream.Write(this.1(), 0, 16);
					fileStream.Write(this.3(), 0, 16);
					fileStream.Write(this.5(), 0, 16);
					int count;
					while ((count = baseStream.Read(buffer, 0, 524288)) > 0)
					{
						fileStream.Write(buffer, 0, count);
					}
				}
				binaryWriter.Close();
				2.Clear();
				if (this.22)
				{
					this.6.Clear();
					int num4 = 0;
					foreach (KeyValuePair<string, byte[]> keyValuePair4 in sortedDictionary)
					{
						this.6.Add(keyValuePair4.Key, new 1519(keyValuePair4.Key, num4, keyValuePair4.Value.Length, dictionary[keyValuePair4.Key], dictionary2[keyValuePair4.Key], dictionary3[keyValuePair4.Key]));
						num4 += keyValuePair4.Value.Length;
					}
				}
				this.26 = num;
				this.25 = num3;
				this.24 = false;
				this.23 = false;
				this.22 = false;
				this.14.Clear();
				this.15.Clear();
				this.7.Clear();
			}
			finally
			{
				((IDisposable)binaryWriter).Dispose();
			}
		}
		this.19 = File.Open(this.5, FileMode.Open, FileAccess.Read, FileShare.Read);
		return true;
	}

	// Token: 0x06004899 RID: 18585 RVA: 0x001CD570 File Offset: 0x001CB770
	public void Close()
	{
		if (this.20)
		{
			return;
		}
		if (this.17 != null)
		{
			foreach (1517 <<EMPTY_NAME>> in new List<1517>(this.17))
			{
				<<EMPTY_NAME>>.Close();
			}
		}
		if (this.9 != null)
		{
			Array.Clear(this.9, 0, this.9.Length);
		}
		if (this.6 != null)
		{
			this.6.Clear();
		}
		if (this.7 != null)
		{
			this.7.Clear();
		}
		if (this.14 != null)
		{
			this.14.Clear();
		}
		if (this.15 != null)
		{
			this.15.Clear();
		}
		if (this.16 != null)
		{
			this.16.Clear();
		}
		if (this.18 != null)
		{
			this.18.Clear();
		}
		if (this.19 != null)
		{
			this.19.Close();
			this.19.Dispose();
		}
		this.20 = true;
	}

	// Token: 0x0600489A RID: 18586 RVA: 0x001CD68C File Offset: 0x001CB88C
	public bool 40(int 1, bool 2)
	{
		try
		{
			object obj = this.30;
			lock (obj)
			{
				if (!Monitor.TryEnter(this.30, 1))
				{
					return false;
				}
			}
		}
		catch
		{
			return false;
		}
		if (2 && this.19 != null)
		{
			this.19.Close();
			this.19 = null;
		}
		return true;
	}

	// Token: 0x0600489B RID: 18587 RVA: 0x001CD70C File Offset: 0x001CB90C
	public void 41()
	{
		if (this.19 == null)
		{
			this.19 = File.Open(this.5, FileMode.Open, FileAccess.Read, FileShare.Read);
		}
		object obj = this.30;
		lock (obj)
		{
			Monitor.Exit(this.30);
		}
	}

	// Token: 0x0600489C RID: 18588 RVA: 0x001CD770 File Offset: 0x001CB970
	public void Dispose()
	{
		this.42(true);
		GC.SuppressFinalize(this);
	}

	// Token: 0x0600489D RID: 18589 RVA: 0x001CD77F File Offset: 0x001CB97F
	private void 42(bool 1)
	{
		this.Close();
	}

	// Token: 0x0600489E RID: 18590 RVA: 0x001CD787 File Offset: 0x001CB987
	private void 43()
	{
		if (this.20)
		{
			throw new Exception("Object is closed.");
		}
	}

	// Token: 0x04003588 RID: 13704
	private static readonly MD5CryptoServiceProvider 1 = new MD5CryptoServiceProvider();

	// Token: 0x04003589 RID: 13705
	private static byte[] 2 = new byte[]
	{
		216,
		98,
		163,
		48,
		2,
		109,
		118,
		89,
		244,
		247,
		37,
		194,
		235,
		70,
		174,
		52,
		13,
		106,
		97,
		84,
		242,
		62,
		186,
		48,
		25,
		66,
		72,
		85,
		242,
		22,
		15,
		92
	};

	// Token: 0x0400358A RID: 13706
	private byte[] 3;

	// Token: 0x0400358B RID: 13707
	private static readonly byte[] 4 = new byte[64];

	// Token: 0x0400358C RID: 13708
	private string 5;

	// Token: 0x0400358D RID: 13709
	private Dictionary<string, 1519> 6;

	// Token: 0x0400358E RID: 13710
	private Dictionary<string, byte[]> 7;

	// Token: 0x0400358F RID: 13711
	private long 8;

	// Token: 0x04003590 RID: 13712
	private byte[] 9;

	// Token: 0x04003591 RID: 13713
	private byte[] 10;

	// Token: 0x04003592 RID: 13714
	private byte[] 11;

	// Token: 0x04003593 RID: 13715
	private byte[] 12;

	// Token: 0x04003594 RID: 13716
	private SortedDictionary<string, int> 13;

	// Token: 0x04003595 RID: 13717
	private Dictionary<string, DateTime> 14;

	// Token: 0x04003596 RID: 13718
	private Dictionary<string, DateTime> 15;

	// Token: 0x04003597 RID: 13719
	private Dictionary<string, bool> 16;

	// Token: 0x04003598 RID: 13720
	private List<1517> 17;

	// Token: 0x04003599 RID: 13721
	private Dictionary<1513, string> 18;

	// Token: 0x0400359A RID: 13722
	private Stream 19;

	// Token: 0x0400359B RID: 13723
	internal bool 20;

	// Token: 0x0400359C RID: 13724
	private bool 21;

	// Token: 0x0400359D RID: 13725
	private bool 22;

	// Token: 0x0400359E RID: 13726
	private bool 23;

	// Token: 0x0400359F RID: 13727
	private bool 24;

	// Token: 0x040035A0 RID: 13728
	private int 25;

	// Token: 0x040035A1 RID: 13729
	private int 26;

	// Token: 0x040035A2 RID: 13730
	private bool 27;

	// Token: 0x040035A3 RID: 13731
	private long 28;

	// Token: 0x040035A4 RID: 13732
	private bool 29;

	// Token: 0x040035A5 RID: 13733
	private object 30;

	// Token: 0x02000A3E RID: 2622
	[Serializable]
	public sealed class 1515
	{
		// Token: 0x060048A0 RID: 18592 RVA: 0x001CD7C1 File Offset: 0x001CB9C1
		internal int 1(1519 1, 1519 2)
		{
			return 1.5() - 2.5();
		}

		// Token: 0x040035A6 RID: 13734
		public static readonly 1514.1515 instance = new 1514.1515();

		// Token: 0x040035A7 RID: 13735
		public static Comparison<1519> comparison;
	}

	// Token: 0x02000A3F RID: 2623
	public sealed class 1516 : IComparer<string>
	{
		// Token: 0x060048A3 RID: 18595 RVA: 0x001CD7DE File Offset: 0x001CB9DE
		public int Compare(string 1, string 2)
		{
			if (1 == 2)
			{
				return 0;
			}
			if (1514.22(1))
			{
				return 1;
			}
			if (1514.22(2))
			{
				return -1;
			}
			return 1.CompareTo(2);
		}
	}
}
