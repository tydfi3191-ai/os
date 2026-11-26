using System;
using System.IO;
using System.Runtime.InteropServices;

// Token: 0x02000324 RID: 804
[ComVisible(false)]
public sealed class 783 : ICloneable
{
	// Token: 0x0600183B RID: 6203 RVA: 0x000556DB File Offset: 0x000538DB
	public 783(string 1) : this(1, 0, 51, 536.Deflated)
	{
	}

	// Token: 0x0600183C RID: 6204 RVA: 0x000556E8 File Offset: 0x000538E8
	internal 783(string 1, int 2) : this(1, 2, 51, 536.Deflated)
	{
	}

	// Token: 0x0600183D RID: 6205 RVA: 0x000556F8 File Offset: 0x000538F8
	internal 783(string 1, int 2, int 3, 536 4)
	{
		this.number3 = -1;
		this._recoveredType118710002 = 536.Deflated;
		this.number9 = -1L;
		base..ctor();
		if (1 == null)
		{
			throw new ArgumentNullException("name");
		}
		if (1.Length > 65535)
		{
			throw new ArgumentException("Name is too long", "name");
		}
		if (2 != 0 && 2 < 10)
		{
			throw new ArgumentOutOfRangeException("versionRequiredToExtract");
		}
		this.Method12801(DateTime.Now);
		this.text2 = 783.Method12827(1);
		this.uInt = (ushort)3;
		this.uInt2 = (ushort)2;
		this._recoveredType118710002 = 4;
	}

	// Token: 0x0600183E RID: 6206 RVA: 0x00055790 File Offset: 0x00053990
	[Obsolete("Use Clone instead")]
	public 783(783 1)
	{
		this.number3 = -1;
		this._recoveredType118710002 = 536.Deflated;
		this.number9 = -1L;
		base..ctor();
		if (1 == null)
		{
			throw new ArgumentNullException("entry");
		}
		this._recoveredType23409993 = 1._recoveredType23409993;
		this.text2 = 1.text2;
		this.number4 = 1.number4;
		this.number5 = 1.number5;
		this.number6 = 1.number6;
		this.number7 = 1.number7;
		this._recoveredType118710002 = 1._recoveredType118710002;
		this.text3 = 1.text3;
		this.uInt2 = 1.uInt2;
		this.uInt = 1.uInt;
		this.number3 = 1.number3;
		this.number8 = 1.number8;
		this.number9 = 1.number9;
		this.number10 = 1.number10;
		this.flag2 = 1.flag2;
		if (1.byteArray2 != null)
		{
			this.byteArray2 = new byte[1.byteArray2.Length];
			Array.Copy(1.byteArray2, 0, this.byteArray2, 0, 1.byteArray2.Length);
		}
	}

	// Token: 0x0600183F RID: 6207 RVA: 0x000558B1 File Offset: 0x00053AB1
	public bool Method12772()
	{
		return (this._recoveredType23409993 & (783.784)4) > (783.784)0;
	}

	// Token: 0x06001840 RID: 6208 RVA: 0x000558BE File Offset: 0x00053ABE
	public bool Method12773()
	{
		return (this.number8 & 1) != 0;
	}

	// Token: 0x06001841 RID: 6209 RVA: 0x000558CB File Offset: 0x00053ACB
	public void Method12774(bool 1)
	{
		if (1)
		{
			this.number8 |= 1;
			return;
		}
		this.number8 &= -2;
	}

	// Token: 0x06001842 RID: 6210 RVA: 0x000558EE File Offset: 0x00053AEE
	public bool Method12775()
	{
		return (this.number8 & 2048) != 0;
	}

	// Token: 0x06001843 RID: 6211 RVA: 0x000558FF File Offset: 0x00053AFF
	public void Method12776(bool 1)
	{
		if (1)
		{
			this.number8 |= 2048;
			return;
		}
		this.number8 &= -2049;
	}

	// Token: 0x06001844 RID: 6212 RVA: 0x00055929 File Offset: 0x00053B29
	internal byte GetByte10009_12777()
	{
		return this.byteValue2;
	}

	// Token: 0x06001845 RID: 6213 RVA: 0x00055931 File Offset: 0x00053B31
	internal void SetByte10009_12778(byte 1)
	{
		this.byteValue2 = 1;
	}

	// Token: 0x06001846 RID: 6214 RVA: 0x0005593A File Offset: 0x00053B3A
	public int GetNumber10005_12779()
	{
		return this.number8;
	}

	// Token: 0x06001847 RID: 6215 RVA: 0x00055942 File Offset: 0x00053B42
	public void SetNumber10005_12780(int 1)
	{
		this.number8 = 1;
	}

	// Token: 0x06001848 RID: 6216 RVA: 0x0005594B File Offset: 0x00053B4B
	public long GetNumber10006_12781()
	{
		return this.number9;
	}

	// Token: 0x06001849 RID: 6217 RVA: 0x00055953 File Offset: 0x00053B53
	public void SetNumber10006_12782(long 1)
	{
		this.number9 = 1;
	}

	// Token: 0x0600184A RID: 6218 RVA: 0x0005595C File Offset: 0x00053B5C
	public long GetNumber10007_12783()
	{
		return this.number10;
	}

	// Token: 0x0600184B RID: 6219 RVA: 0x00055964 File Offset: 0x00053B64
	public void SetNumber10007_12784(long 1)
	{
		this.number10 = 1;
	}

	// Token: 0x0600184C RID: 6220 RVA: 0x0005596D File Offset: 0x00053B6D
	public int Method12785()
	{
		if ((this._recoveredType23409993 & (783.784)16) == (783.784)0)
		{
			return -1;
		}
		return this.number3;
	}

	// Token: 0x0600184D RID: 6221 RVA: 0x00055982 File Offset: 0x00053B82
	public void Method12786(int 1)
	{
		this.number3 = 1;
		this._recoveredType23409993 |= (783.784)16;
	}

	// Token: 0x0600184E RID: 6222 RVA: 0x0005599A File Offset: 0x00053B9A
	public int Method12787()
	{
		return (int)(this.uInt & 255);
	}

	// Token: 0x0600184F RID: 6223 RVA: 0x000559A8 File Offset: 0x00053BA8
	public bool Method12788()
	{
		return this.Method12790() == 0 || this.Method12790() == 10;
	}

	// Token: 0x06001850 RID: 6224 RVA: 0x000559C0 File Offset: 0x00053BC0
	private bool Method12789(int 1)
	{
		bool result = false;
		if ((this._recoveredType23409993 & (783.784)16) != (783.784)0 && (this.Method12790() == 0 || this.Method12790() == 10) && (this.Method12785() & 1) == 1)
		{
			result = true;
		}
		return result;
	}

	// Token: 0x06001851 RID: 6225 RVA: 0x000559FA File Offset: 0x00053BFA
	public int Method12790()
	{
		return this.uInt >> 8 & 255;
	}

	// Token: 0x06001852 RID: 6226 RVA: 0x00055A0A File Offset: 0x00053C0A
	public void Method12791(int 1)
	{
		this.uInt &= 255;
		this.uInt |= (ushort)((1 & 255) << 8);
	}

	// Token: 0x06001853 RID: 6227 RVA: 0x00055A38 File Offset: 0x00053C38
	public int Method12792()
	{
		if (this.uInt2 != 0)
		{
			return (int)(this.uInt2 & 255);
		}
		int result = 10;
		if (this.Method12814() > 0)
		{
			result = 51;
		}
		else if (this.Method12797())
		{
			result = 45;
		}
		else if (536.Deflated == this._recoveredType118710002)
		{
			result = 20;
		}
		else if (this.Method12823())
		{
			result = 20;
		}
		else if (this.Method12773())
		{
			result = 20;
		}
		else if (this.Method12789(8))
		{
			result = 11;
		}
		return result;
	}

	// Token: 0x06001854 RID: 6228 RVA: 0x00055AB0 File Offset: 0x00053CB0
	public bool Method12793()
	{
		return this.Method12792() <= 51 && (this.Method12792() == 10 || this.Method12792() == 11 || this.Method12792() == 20 || this.Method12792() == 45 || this.Method12792() == 51) && this.Method12825();
	}

	// Token: 0x06001855 RID: 6229 RVA: 0x00055B01 File Offset: 0x00053D01
	public void SetFlag10008_12794()
	{
		this.flag2 = true;
	}

	// Token: 0x06001856 RID: 6230 RVA: 0x00055B0A File Offset: 0x00053D0A
	public bool GetFlag10008_12795()
	{
		return this.flag2;
	}

	// Token: 0x06001857 RID: 6231 RVA: 0x00055B14 File Offset: 0x00053D14
	public bool Method12796()
	{
		bool flag = this.flag2;
		if (!flag)
		{
			ulong num = this.number5;
			if (this.uInt2 == 0 && this.Method12773())
			{
				num += 12UL;
			}
			flag = ((this.number4 >= (ulong)-1 || num >= (ulong)-1) && (this.uInt2 == 0 || this.uInt2 >= 45));
		}
		return flag;
	}

	// Token: 0x06001858 RID: 6232 RVA: 0x00055B74 File Offset: 0x00053D74
	public bool Method12797()
	{
		return this.Method12796() || this.number10 >= (long)((ulong)-1);
	}

	// Token: 0x06001859 RID: 6233 RVA: 0x00055B8D File Offset: 0x00053D8D
	public long Method12798()
	{
		if ((this._recoveredType23409993 & (783.784)8) == (783.784)0)
		{
			return 0L;
		}
		return (long)((ulong)this.number7);
	}

	// Token: 0x0600185A RID: 6234 RVA: 0x00055BA3 File Offset: 0x00053DA3
	public void Method12799(long 1)
	{
		this.number7 = (uint)1;
		this._recoveredType23409993 |= (783.784)8;
	}

	// Token: 0x0600185B RID: 6235 RVA: 0x00055BBC File Offset: 0x00053DBC
	public DateTime Method12800()
	{
		uint second = Math.Min(59U, 2U * (this.number7 & 31U));
		uint minute = Math.Min(59U, this.number7 >> 5 & 63U);
		uint hour = Math.Min(23U, this.number7 >> 11 & 31U);
		uint month = Math.Max(1U, Math.Min(12U, this.number7 >> 21 & 15U));
		uint year = (this.number7 >> 25 & 127U) + 1980U;
		int day = Math.Max(1, Math.Min(DateTime.DaysInMonth((int)year, (int)month), (int)(this.number7 >> 16 & 31U)));
		return new DateTime((int)year, (int)month, day, (int)hour, (int)minute, (int)second);
	}

	// Token: 0x0600185C RID: 6236 RVA: 0x00055C60 File Offset: 0x00053E60
	public void Method12801(DateTime 1)
	{
		uint num = (uint)1.Year;
		uint num2 = (uint)1.Month;
		uint num3 = (uint)1.Day;
		uint num4 = (uint)1.Hour;
		uint num5 = (uint)1.Minute;
		uint num6 = (uint)1.Second;
		if (num < 1980U)
		{
			num = 1980U;
			num2 = 1U;
			num3 = 1U;
			num4 = 0U;
			num5 = 0U;
			num6 = 0U;
		}
		else if (num > 2107U)
		{
			num = 2107U;
			num2 = 12U;
			num3 = 31U;
			num4 = 23U;
			num5 = 59U;
			num6 = 59U;
		}
		this.Method12799((long)((ulong)((num - 1980U & 127U) << 25 | num2 << 21 | num3 << 16 | num4 << 11 | num5 << 5 | num6 >> 1)));
	}

	// Token: 0x0600185D RID: 6237 RVA: 0x00055D07 File Offset: 0x00053F07
	public string GetText9996_12802()
	{
		return this.text2;
	}

	// Token: 0x0600185E RID: 6238 RVA: 0x00055D0F File Offset: 0x00053F0F
	public long Method12803()
	{
		if ((this._recoveredType23409993 & (783.784)1) == (783.784)0)
		{
			return -1L;
		}
		return (long)this.number4;
	}

	// Token: 0x0600185F RID: 6239 RVA: 0x00055D24 File Offset: 0x00053F24
	public void Method12804(long 1)
	{
		this.number4 = (ulong)1;
		this._recoveredType23409993 |= (783.784)1;
	}

	// Token: 0x06001860 RID: 6240 RVA: 0x00055D3B File Offset: 0x00053F3B
	public long Method12805()
	{
		if ((this._recoveredType23409993 & (783.784)2) == (783.784)0)
		{
			return -1L;
		}
		return (long)this.number5;
	}

	// Token: 0x06001861 RID: 6241 RVA: 0x00055D50 File Offset: 0x00053F50
	public void Method12806(long 1)
	{
		this.number5 = (ulong)1;
		this._recoveredType23409993 |= (783.784)2;
	}

	// Token: 0x06001862 RID: 6242 RVA: 0x00055D67 File Offset: 0x00053F67
	public long Method12807()
	{
		if ((this._recoveredType23409993 & (783.784)4) == (783.784)0)
		{
			return -1L;
		}
		return (long)((ulong)this.number6 & (ulong)-1);
	}

	// Token: 0x06001863 RID: 6243 RVA: 0x00055D80 File Offset: 0x00053F80
	public void Method12808(long 1)
	{
		if (((ulong)this.number6 & 18446744069414584320UL) != 0UL)
		{
			throw new ArgumentOutOfRangeException("#=zUkSU2UA=");
		}
		this.number6 = (uint)1;
		this._recoveredType23409993 |= (783.784)4;
	}

	// Token: 0x06001864 RID: 6244 RVA: 0x00055DB6 File Offset: 0x00053FB6
	public 536 GetRecoveredType118710002_12809()
	{
		return this._recoveredType118710002;
	}

	// Token: 0x06001865 RID: 6245 RVA: 0x00055DBE File Offset: 0x00053FBE
	public void Method12810(536 1)
	{
		if (!783.Method12825(1))
		{
			throw new NotSupportedException("Compression method not supported");
		}
		this._recoveredType118710002 = 1;
	}

	// Token: 0x06001866 RID: 6246 RVA: 0x00055DDA File Offset: 0x00053FDA
	internal 536 Method12811()
	{
		if (this.Method12814() <= 0)
		{
			return this._recoveredType118710002;
		}
		return 536.WinZipAES;
	}

	// Token: 0x06001867 RID: 6247 RVA: 0x00055DEE File Offset: 0x00053FEE
	public byte[] GetByteArray10003_12812()
	{
		return this.byteArray2;
	}

	// Token: 0x06001868 RID: 6248 RVA: 0x00055DF8 File Offset: 0x00053FF8
	public void Method12813(byte[] 1)
	{
		if (1 == null)
		{
			this.byteArray2 = null;
			return;
		}
		if (1.Length > 65535)
		{
			throw new ArgumentOutOfRangeException("#=zUkSU2UA=");
		}
		this.byteArray2 = new byte[1.Length];
		Array.Copy(1, 0, this.byteArray2, 0, 1.Length);
	}

	// Token: 0x06001869 RID: 6249 RVA: 0x00055E44 File Offset: 0x00054044
	public int Method12814()
	{
		int result;
		switch (this.number12)
		{
		case 0:
			result = 0;
			break;
		case 1:
			result = 128;
			break;
		case 2:
			result = 192;
			break;
		case 3:
			result = 256;
			break;
		default:
			throw new 415("Invalid AESEncryptionStrength " + this.number12.ToString());
		}
		return result;
	}

	// Token: 0x0600186A RID: 6250 RVA: 0x00055EA8 File Offset: 0x000540A8
	public void Method12815(int 1)
	{
		if (1 == 0)
		{
			this.number12 = 0;
			return;
		}
		if (1 == 128)
		{
			this.number12 = 1;
			return;
		}
		if (1 != 256)
		{
			throw new 415("AESKeySize must be 0, 128 or 256: " + 1.ToString());
		}
		this.number12 = 3;
	}

	// Token: 0x0600186B RID: 6251 RVA: 0x00055EF8 File Offset: 0x000540F8
	internal byte Method12816()
	{
		return (byte)this.number12;
	}

	// Token: 0x0600186C RID: 6252 RVA: 0x00055F01 File Offset: 0x00054101
	internal int Method12817()
	{
		return this.Method12814() / 16;
	}

	// Token: 0x0600186D RID: 6253 RVA: 0x00055F0C File Offset: 0x0005410C
	internal int Method12818()
	{
		return 12 + this.Method12817();
	}

	// Token: 0x0600186E RID: 6254 RVA: 0x00055F18 File Offset: 0x00054118
	internal void Method12819(bool 1)
	{
		758 2 = new 758(this.byteArray2);
		if (2.Method12226(1))
		{
			this.flag2 = true;
			if (2.GetNumber9559_12223() < 4)
			{
				throw new 415("Extra data extended Zip64 information length is invalid");
			}
			if (1 || this.number4 == (ulong)-1)
			{
				this.number4 = (ulong)2.Method12237();
			}
			if (1 || this.number5 == (ulong)-1)
			{
				this.number5 = (ulong)2.Method12237();
			}
			if (!1 && this.number10 == (long)((ulong)-1))
			{
				this.number10 = 2.Method12237();
			}
		}
		else if ((this.uInt2 & 255) >= 45 && (this.number4 == (ulong)-1 || this.number5 == (ulong)-1))
		{
			throw new 415("Zip64 Extended information required but is missing.");
		}
		if (2.Method12226(10))
		{
			if (2.GetNumber9559_12223() < 4)
			{
				throw new 415("NTFS Extra data invalid");
			}
			2.Method12238();
			while (2.Method12225() >= 4)
			{
				int num = 2.Method12239();
				int num2 = 2.Method12239();
				if (num == 1)
				{
					if (num2 >= 24)
					{
						long fileTime = 2.Method12237();
						2.Method12237();
						2.Method12237();
						this.Method12801(DateTime.FromFileTime(fileTime));
						break;
					}
					break;
				}
				else
				{
					2.Method12241(num2);
				}
			}
		}
		else if (2.Method12226(21589))
		{
			int number9559_ = 2.GetNumber9559_12223();
			if ((2.Method12240() & 1) != 0 && number9559_ >= 5)
			{
				int seconds = 2.Method12238();
				this.Method12801((new DateTime(1970, 1, 1, 0, 0, 0).ToUniversalTime() + new TimeSpan(0, 0, 0, seconds, 0)).ToLocalTime());
			}
		}
		if (this._recoveredType118710002 == 536.WinZipAES)
		{
			this.Method12820(2);
		}
	}

	// Token: 0x0600186F RID: 6255 RVA: 0x000560B8 File Offset: 0x000542B8
	private void Method12820(758 1)
	{
		if (!1.Method12226(39169))
		{
			throw new 415("AES Extra Data missing");
		}
		this.uInt2 = 51;
		this.SetNumber10005_12780(this.GetNumber10005_12779() | 64);
		int number9559_ = 1.GetNumber9559_12223();
		if (number9559_ < 7)
		{
			throw new 415("AES Extra Data Length " + number9559_.ToString() + " invalid.");
		}
		int num = 1.Method12239();
		1.Method12239();
		int num2 = 1.Method12240();
		int recoveredType = 1.Method12239();
		this.number11 = num;
		this.number12 = num2;
		this._recoveredType118710002 = (536)recoveredType;
	}

	// Token: 0x06001870 RID: 6256 RVA: 0x0005614C File Offset: 0x0005434C
	public string GetText10004_12821()
	{
		return this.text3;
	}

	// Token: 0x06001871 RID: 6257 RVA: 0x00056154 File Offset: 0x00054354
	public void Method12822(string 1)
	{
		if (1 != null && 1.Length > 65535)
		{
			throw new ArgumentOutOfRangeException("#=zUkSU2UA=", "cannot exceed 65535");
		}
		this.text3 = 1;
	}

	// Token: 0x06001872 RID: 6258 RVA: 0x00056180 File Offset: 0x00054380
	public bool Method12823()
	{
		int length = this.text2.Length;
		return (length > 0 && (this.text2[length - 1] == '/' || this.text2[length - 1] == '\\')) || this.Method12789(16);
	}

	// Token: 0x06001873 RID: 6259 RVA: 0x000561CB File Offset: 0x000543CB
	public bool Method12824()
	{
		return !this.Method12823() && !this.Method12789(8);
	}

	// Token: 0x06001874 RID: 6260 RVA: 0x000561E1 File Offset: 0x000543E1
	public bool Method12825()
	{
		return 783.Method12825(this.GetRecoveredType118710002_12809());
	}

	// Token: 0x06001875 RID: 6261 RVA: 0x000561F0 File Offset: 0x000543F0
	public object Clone()
	{
		783 <<EMPTY_NAME>> = (783)base.MemberwiseClone();
		if (this.byteArray2 != null)
		{
			<<EMPTY_NAME>>.byteArray2 = new byte[this.byteArray2.Length];
			Array.Copy(this.byteArray2, 0, <<EMPTY_NAME>>.byteArray2, 0, this.byteArray2.Length);
		}
		return <<EMPTY_NAME>>;
	}

	// Token: 0x06001876 RID: 6262 RVA: 0x00055D07 File Offset: 0x00053F07
	public override string ToString()
	{
		return this.text2;
	}

	// Token: 0x06001877 RID: 6263 RVA: 0x00056240 File Offset: 0x00054440
	public static bool Method12825(536 1)
	{
		return 1 == 536.Deflated || 1 == 536.Stored;
	}

	// Token: 0x06001878 RID: 6264 RVA: 0x0005624C File Offset: 0x0005444C
	public static string Method12827(string 1)
	{
		if (1 == null)
		{
			return string.Empty;
		}
		if (Path.IsPathRooted(1))
		{
			1 = 1.Substring(Path.GetPathRoot(1).Length);
		}
		1 = 1.Replace('\\', '/');
		while (1.Length > 0 && 1[0] == '/')
		{
			1 = 1.Remove(0, 1);
		}
		return 1;
	}

	// Token: 0x04000B5A RID: 2906
	private 783.784 _recoveredType23409993;

	// Token: 0x04000B5B RID: 2907
	private int number3;

	// Token: 0x04000B5C RID: 2908
	private ushort uInt;

	// Token: 0x04000B5D RID: 2909
	private string text2;

	// Token: 0x04000B5E RID: 2910
	private ulong number4;

	// Token: 0x04000B5F RID: 2911
	private ulong number5;

	// Token: 0x04000B60 RID: 2912
	private ushort uInt2;

	// Token: 0x04000B61 RID: 2913
	private uint number6;

	// Token: 0x04000B62 RID: 2914
	private uint number7;

	// Token: 0x04000B63 RID: 2915
	private 536 _recoveredType118710002;

	// Token: 0x04000B64 RID: 2916
	private byte[] byteArray2;

	// Token: 0x04000B65 RID: 2917
	private string text3;

	// Token: 0x04000B66 RID: 2918
	private int number8;

	// Token: 0x04000B67 RID: 2919
	private long number9;

	// Token: 0x04000B68 RID: 2920
	private long number10;

	// Token: 0x04000B69 RID: 2921
	private bool flag2;

	// Token: 0x04000B6A RID: 2922
	private byte byteValue2;

	// Token: 0x04000B6B RID: 2923
	private int number11;

	// Token: 0x04000B6C RID: 2924
	private int number12;

	// Token: 0x02000325 RID: 805
	public enum 784 : byte
	{

	}
}
