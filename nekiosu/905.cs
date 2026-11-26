using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

// Token: 0x02000328 RID: 808
[ComVisible(false)]
public sealed class 905 : IEnumerable, IDisposable
{
	// Token: 0x17000115 RID: 277
	public 783 this[int 1]
	{
		get
		{
			return (783)this.entries[1].Clone();
		}
	}

	// Token: 0x0600188F RID: 6287 RVA: 0x00057120 File Offset: 0x00055320
	public 905(string 1)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("#=zcC_miSk=");
		}
		this.fileName = 1;
		this.baseStream = File.Open(1, FileMode.Open, FileAccess.Read, FileShare.Read);
		this.isStreamOwner = true;
		try
		{
			this.ReadEntries();
		}
		catch
		{
			this.DisposeInternal(true);
			throw;
		}
	}

	// Token: 0x06001890 RID: 6288 RVA: 0x000571A0 File Offset: 0x000553A0
	public 905(FileStream 1)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("#=zI1WtFOk=");
		}
		if (!1.CanSeek)
		{
			throw new ArgumentException("Stream is not seekable", "#=zI1WtFOk=");
		}
		this.baseStream = 1;
		this.fileName = 1.Name;
		this.isStreamOwner = true;
		try
		{
			this.ReadEntries();
		}
		catch
		{
			this.DisposeInternal(true);
			throw;
		}
	}

	// Token: 0x06001891 RID: 6289 RVA: 0x00057234 File Offset: 0x00055434
	public 905(Stream 1)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("#=zls9YYyc=");
		}
		if (!1.CanSeek)
		{
			throw new ArgumentException("Stream is not seekable", "#=zls9YYyc=");
		}
		this.baseStream = 1;
		this.isStreamOwner = true;
		if (this.baseStream.Length > 0L)
		{
			try
			{
				this.ReadEntries();
				return;
			}
			catch
			{
				this.DisposeInternal(true);
				throw;
			}
		}
		this.entries = new 783[0];
		this.isNewArchive = true;
	}

	// Token: 0x06001892 RID: 6290 RVA: 0x000572DC File Offset: 0x000554DC
	internal 905()
	{
		this.entries = new 783[0];
		this.isNewArchive = true;
	}

	// Token: 0x06001893 RID: 6291 RVA: 0x00057314 File Offset: 0x00055514
	private void OnKeysRequired(string 1)
	{
		if (this.keysRequired != null)
		{
			480 2 = new 480(1, this.passwordKeys);
			this.keysRequired(this, 2);
			this.passwordKeys = 2.GetByteArray3608_4591();
		}
	}

	// Token: 0x06001894 RID: 6292 RVA: 0x0005734F File Offset: 0x0005554F
	private byte[] GetPasswordKeys()
	{
		return this.passwordKeys;
	}

	// Token: 0x06001895 RID: 6293 RVA: 0x00057357 File Offset: 0x00055557
	private void SetPasswordKeys(byte[] 1)
	{
		this.passwordKeys = 1;
	}

	// Token: 0x06001896 RID: 6294 RVA: 0x00057360 File Offset: 0x00055560
	public void SetPassword(string 1)
	{
		if (1 == null || 1.Length == 0)
		{
			this.passwordKeys = null;
			return;
		}
		this.password = 1;
		this.passwordKeys = 560.Method7523(448.Method4014(1));
	}

	// Token: 0x06001897 RID: 6295 RVA: 0x0005738D File Offset: 0x0005558D
	private bool HasPassword()
	{
		return this.passwordKeys != null;
	}

	// Token: 0x06001898 RID: 6296 RVA: 0x00057398 File Offset: 0x00055598
	~905()
	{
		this.DisposeCore(false);
	}

	// Token: 0x06001899 RID: 6297 RVA: 0x000573C8 File Offset: 0x000555C8
	public void Close()
	{
		this.DisposeInternal(true);
		GC.SuppressFinalize(this);
	}

	// Token: 0x0600189A RID: 6298 RVA: 0x000573D8 File Offset: 0x000555D8
	public static 905 Method13277(string 1)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("fileName");
		}
		FileStream fileStream = File.Create(1);
		return new 905
		{
			fileName = 1,
			baseStream = fileStream,
			isStreamOwner = true
		};
	}

	// Token: 0x0600189B RID: 6299 RVA: 0x00057414 File Offset: 0x00055614
	public static 905 Method13277(Stream 1)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("outStream");
		}
		if (!1.CanWrite)
		{
			throw new ArgumentException("Stream is not writeable", "outStream");
		}
		if (!1.CanSeek)
		{
			throw new ArgumentException("Stream is not seekable", "outStream");
		}
		return new 905
		{
			baseStream = 1
		};
	}

	// Token: 0x0600189C RID: 6300 RVA: 0x0005746B File Offset: 0x0005566B
	public bool GetIsStreamOwner()
	{
		return this.isStreamOwner;
	}

	// Token: 0x0600189D RID: 6301 RVA: 0x00057473 File Offset: 0x00055673
	public void SetIsStreamOwner(bool 1)
	{
		this.isStreamOwner = 1;
	}

	// Token: 0x0600189E RID: 6302 RVA: 0x0005747C File Offset: 0x0005567C
	public bool IsEmbeddedArchive()
	{
		return this.archiveOffset > 0L;
	}

	// Token: 0x0600189F RID: 6303 RVA: 0x00057488 File Offset: 0x00055688
	public bool GetIsNewArchive()
	{
		return this.isNewArchive;
	}

	// Token: 0x060018A0 RID: 6304 RVA: 0x00057490 File Offset: 0x00055690
	public string GetComment()
	{
		return this.comment;
	}

	// Token: 0x060018A1 RID: 6305 RVA: 0x00057498 File Offset: 0x00055698
	public string GetName()
	{
		return this.fileName;
	}

	// Token: 0x060018A2 RID: 6306 RVA: 0x000574A0 File Offset: 0x000556A0
	public int GetEntryCount()
	{
		return this.entries.Length;
	}

	// Token: 0x060018A3 RID: 6307 RVA: 0x000574AA File Offset: 0x000556AA
	public long GetCount()
	{
		return (long)this.entries.Length;
	}

	// Token: 0x060018A4 RID: 6308 RVA: 0x000574B5 File Offset: 0x000556B5
	public IEnumerator GetEnumerator()
	{
		if (this.isDisposed)
		{
			throw new ObjectDisposedException("ZipFile");
		}
		return new 905.906(this.entries);
	}

	// Token: 0x060018A5 RID: 6309 RVA: 0x000574D8 File Offset: 0x000556D8
	public int FindEntry(string 1, bool 2)
	{
		if (this.isDisposed)
		{
			throw new ObjectDisposedException("ZipFile");
		}
		for (int i = 0; i < this.entries.Length; i++)
		{
			if (string.Compare(1, this.entries[i].GetText9996_12802(), 2, CultureInfo.InvariantCulture) == 0)
			{
				return i;
			}
		}
		return -1;
	}

	// Token: 0x060018A6 RID: 6310 RVA: 0x0005752C File Offset: 0x0005572C
	public 783 GetEntry(string 1)
	{
		if (this.isDisposed)
		{
			throw new ObjectDisposedException("ZipFile");
		}
		int num = this.FindEntry(1, true);
		if (num < 0)
		{
			return null;
		}
		return (783)this.entries[num].Clone();
	}

	// Token: 0x060018A7 RID: 6311 RVA: 0x00057570 File Offset: 0x00055770
	public Stream Method13289(783 1)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("entry");
		}
		if (this.isDisposed)
		{
			throw new ObjectDisposedException("ZipFile");
		}
		long num = 1.GetNumber10006_12781();
		if (num < 0L || num >= (long)this.entries.Length || this.entries[(int)(checked((IntPtr)num))].GetText9996_12802() != 1.GetText9996_12802())
		{
			num = (long)this.FindEntry(1.GetText9996_12802(), true);
			if (num < 0L)
			{
				throw new 415("Entry cannot be found");
			}
		}
		return this.Method13289(num);
	}

	// Token: 0x060018A8 RID: 6312 RVA: 0x000575F8 File Offset: 0x000557F8
	public Stream Method13289(long 1)
	{
		if (this.isDisposed)
		{
			throw new ObjectDisposedException("ZipFile");
		}
		checked
		{
			long 2 = this.LocateEntry(this.entries[(int)((IntPtr)1)]);
			536 recoveredType118710002_ = this.entries[(int)((IntPtr)1)].GetRecoveredType118710002_12809();
			Stream stream = new 905.909(this, 2, this.entries[(int)((IntPtr)1)].Method12805());
			if (this.entries[(int)((IntPtr)1)].Method12773())
			{
				stream = this.CreateDecryptionStream(stream, this.entries[(int)((IntPtr)1)]);
				if (stream == null)
				{
					throw new 415("Unable to decrypt this entry");
				}
			}
			if (recoveredType118710002_ != 536.Stored)
			{
				if (recoveredType118710002_ != 536.Deflated)
				{
					throw new 415("Unsupported compression method " + recoveredType118710002_.ToString());
				}
				stream = new 494(stream, new 105(true));
			}
			return stream;
		}
	}

	// Token: 0x060018A9 RID: 6313 RVA: 0x000576B0 File Offset: 0x000558B0
	public bool Method13291(bool 1)
	{
		return this.Method13291(1, (378)0, null);
	}

	// Token: 0x060018AA RID: 6314 RVA: 0x000576BC File Offset: 0x000558BC
	public bool Method13291(bool 1, 378 2, 505 3)
	{
		if (this.isDisposed)
		{
			throw new ObjectDisposedException("ZipFile");
		}
		416 4 = new 416(this);
		if (3 != null)
		{
			3(4, null);
		}
		905.907 5 = 1 ? ((905.907)3) : ((905.907)2);
		bool flag = true;
		try
		{
			int num = 0;
			while (flag && (long)num < this.GetCount())
			{
				if (3 != null)
				{
					4.Method3152(this[num]);
					4.SetRecoveredType18782520_3151((694)1);
					3(4, null);
				}
				try
				{
					this.TestLocalHeader(this[num], 5);
				}
				catch (415 6)
				{
					4.Method3150();
					if (3 != null)
					{
						3(4, string.Format("Exception during test - '{0}'", 6.Message));
					}
					if (2 == (378)0)
					{
						flag = false;
					}
				}
				if (flag && 1 && this[num].Method12824())
				{
					if (3 != null)
					{
						4.SetRecoveredType18782520_3151((694)2);
						3(4, null);
					}
					597 7 = new 597();
					using (Stream stream = this.Method13289(this[num]))
					{
						byte[] array = new byte[4096];
						long num2 = 0L;
						int num3;
						while ((num3 = stream.Read(array, 0, array.Length)) > 0)
						{
							7.Method90912(array, 0, num3);
							if (3 != null)
							{
								num2 += (long)num3;
								4.SetNumber2519_3153(num2);
								3(4, null);
							}
						}
					}
					if (this[num].Method12807() != 7.GetNumber7041_9089())
					{
						4.Method3150();
						if (3 != null)
						{
							3(4, "CRC mismatch");
						}
						if (2 == (378)0)
						{
							flag = false;
						}
					}
					if ((this[num].GetNumber10005_12779() & 8) != 0)
					{
						403 8 = new 403(this.baseStream);
						395 9 = new 395();
						8._000E_2005_2006_2001_2005_2006_2000_2005_2003_2002_200B_2003_200A_2000_200B_2009_2000_2002_2009_2005_2008(this[num].Method12796(), 9);
						if (this[num].Method12807() != 9.GetNumber1962_2495())
						{
							4.Method3150();
						}
						if (this[num].Method12805() != 9.GetNumber1961_2491())
						{
							4.Method3150();
						}
						if (this[num].Method12803() != 9.GetNumber1960_2493())
						{
							4.Method3150();
						}
					}
				}
				if (3 != null)
				{
					4.SetRecoveredType18782520_3151((694)3);
					3(4, null);
				}
				num++;
			}
			if (3 != null)
			{
				4.SetRecoveredType18782520_3151((694)4);
				3(4, null);
			}
		}
		catch (Exception ex)
		{
			4.Method3150();
			if (3 != null)
			{
				3(4, string.Format("Exception during test - '{0}'", ex.Message));
			}
		}
		if (3 != null)
		{
			4.SetRecoveredType18782520_3151((694)5);
			4.Method3152(null);
			3(4, null);
		}
		return 4.GetNumber2518_3147() == 0;
	}

	// Token: 0x060018AB RID: 6315 RVA: 0x00057978 File Offset: 0x00055B78
	private long TestLocalHeader(783 1, 905.907 2)
	{
		Stream obj = this.baseStream;
		long result;
		lock (obj)
		{
			bool flag2 = (2 & (905.907)2) > (905.907)0;
			bool flag3 = (2 & (905.907)1) > (905.907)0;
			this.baseStream.Seek(this.archiveOffset + 1.GetNumber10007_12783(), SeekOrigin.Begin);
			if (this.ReadLeUint() != 67324752U)
			{
				throw new 415(string.Format("Wrong local header signature @{0:X}", this.archiveOffset + 1.GetNumber10007_12783()));
			}
			short num = (short)(this.ReadLeUshort() & 255);
			short num2 = (short)this.ReadLeUshort();
			short num3 = (short)this.ReadLeUshort();
			short num4 = (short)this.ReadLeUshort();
			short num5 = (short)this.ReadLeUshort();
			uint num6 = this.ReadLeUint();
			long num7 = (long)((ulong)this.ReadLeUint());
			long num8 = (long)((ulong)this.ReadLeUint());
			int num9 = (int)this.ReadLeUshort();
			int num10 = (int)this.ReadLeUshort();
			byte[] 3 = new byte[num9];
			402.Method2546(this.baseStream, 3);
			byte[] array = new byte[num10];
			402.Method2546(this.baseStream, array);
			758 4 = new 758(array);
			if (4.Method12226(1))
			{
				num8 = 4.Method12237();
				num7 = 4.Method12237();
				if ((num2 & 8) != 0)
				{
					if (num8 != -1L && num8 != 1.Method12803())
					{
						throw new 415("Size invalid for descriptor");
					}
					if (num7 != -1L && num7 != 1.Method12805())
					{
						throw new 415("Compressed size invalid for descriptor");
					}
				}
			}
			else if (num >= 45 && ((int)num8 == -1 || (int)num7 == -1))
			{
				throw new 415("Required Zip64 extended information missing");
			}
			if (flag3 && 1.Method12824() && !1.Method12825())
			{
				throw new 415("Compression method not supported");
			}
			if (flag2)
			{
				if (num <= 63 && num != 10 && num != 11 && num != 20 && num != 21 && num != 25 && num != 27 && num != 45 && num != 46 && num != 50 && num != 51 && num != 52 && num != 61 && num != 62 && num != 63)
				{
					throw new 415(string.Format("Version required to extract this entry is invalid ({0})", num));
				}
				if (((int)num2 & 49168) != 0)
				{
					throw new 415("Reserved bit flags cannot be set.");
				}
				if ((num2 & 1) != 0 && num < 20)
				{
					throw new 415(string.Format("Version required to extract this entry is too low for encryption ({0})", num));
				}
				if ((num2 & 64) != 0)
				{
					if ((num2 & 1) == 0)
					{
						throw new 415("Strong encryption flag set but encryption flag is not set");
					}
					if (num < 50)
					{
						throw new 415(string.Format("Version required to extract this entry is too low for encryption ({0})", num));
					}
				}
				if ((num2 & 32) != 0 && num < 27)
				{
					throw new 415(string.Format("Patched data requires higher version than ({0})", num));
				}
				if ((int)num2 != 1.GetNumber10005_12779())
				{
					throw new 415("Central header/local header flags mismatch");
				}
				if (1.GetRecoveredType118710002_12809() != (536)num3)
				{
					throw new 415("Central header/local header compression method mismatch");
				}
				if (1.Method12792() != (int)num)
				{
					throw new 415("Extract version mismatch");
				}
				if ((num2 & 64) != 0 && num < 62)
				{
					throw new 415("Strong encryption flag set but version not high enough");
				}
				if ((num2 & 8192) != 0 && (num4 != 0 || num5 != 0))
				{
					throw new 415("Header masked set but date/time values non-zero");
				}
				if ((num2 & 8) == 0 && num6 != (uint)1.Method12807())
				{
					throw new 415("Central header/local header crc mismatch");
				}
				if (num8 == 0L && num7 == 0L && num6 != 0U)
				{
					throw new 415("Invalid CRC for empty entry");
				}
				if (1.GetText9996_12802().Length > num9)
				{
					throw new 415("File name length mismatch");
				}
				string text = 448.Method4012((int)num2, 3);
				if (text != 1.GetText9996_12802())
				{
					throw new 415("Central header and local header file name mismatch");
				}
				if (1.Method12823())
				{
					if (num8 > 0L)
					{
						throw new 415("Directory cannot have size");
					}
					if (1.Method12773())
					{
						if (num7 > 14L)
						{
							throw new 415("Directory compressed size invalid");
						}
					}
					else if (num7 > 2L)
					{
						throw new 415("Directory compressed size invalid");
					}
				}
				if (!686.Method10313(text, true))
				{
					throw new 415("Name is invalid");
				}
			}
			if ((num2 & 8) == 0 || num8 > 0L || num7 > 0L)
			{
				if (num8 != 1.Method12803())
				{
					throw new 415(string.Format("Size mismatch between central header({0}) and local header({1})", 1.Method12803(), num8));
				}
				if (num7 != 1.Method12805() && num7 != (long)((ulong)-1) && num7 != -1L)
				{
					throw new 415(string.Format("Compressed size mismatch between central header({0}) and local header({1})", 1.Method12805(), num7));
				}
			}
			int num11 = num9 + num10;
			result = this.archiveOffset + 1.GetNumber10007_12783() + 30L + (long)num11;
		}
		return result;
	}

	// Token: 0x060018AC RID: 6316 RVA: 0x00057DE8 File Offset: 0x00055FE8
	public 381 GetNameTransform()
	{
		return this.entryFactory.GetRecoveredType03711143_1668();
	}

	// Token: 0x060018AD RID: 6317 RVA: 0x00057DF5 File Offset: 0x00055FF5
	public void SetNameTransform(381 1)
	{
		this.entryFactory.Method1669(1);
	}

	// Token: 0x060018AE RID: 6318 RVA: 0x00057E03 File Offset: 0x00056003
	public 681 GetEntryFactory()
	{
		return this.entryFactory;
	}

	// Token: 0x060018AF RID: 6319 RVA: 0x00057E0B File Offset: 0x0005600B
	public void SetEntryFactory(681 1)
	{
		if (1 == null)
		{
			this.entryFactory = new 362();
			return;
		}
		this.entryFactory = 1;
	}

	// Token: 0x060018B0 RID: 6320 RVA: 0x00057E23 File Offset: 0x00056023
	public int GetBufferSize()
	{
		return this.bufferSize;
	}

	// Token: 0x060018B1 RID: 6321 RVA: 0x00057E2B File Offset: 0x0005602B
	public void SetBufferSize(int 1)
	{
		if (1 < 1024)
		{
			throw new ArgumentOutOfRangeException("#=zUkSU2UA=", "cannot be below 1024");
		}
		if (this.bufferSize != 1)
		{
			this.bufferSize = 1;
			this.copyBuffer = null;
		}
	}

	// Token: 0x060018B2 RID: 6322 RVA: 0x00057E5C File Offset: 0x0005605C
	public bool IsUpdating()
	{
		return this.arrayList != null;
	}

	// Token: 0x060018B3 RID: 6323 RVA: 0x00057E67 File Offset: 0x00056067
	public 609 GetUseZip64()
	{
		return this.useZip64;
	}

	// Token: 0x060018B4 RID: 6324 RVA: 0x00057E6F File Offset: 0x0005606F
	public void SetUseZip64(609 1)
	{
		this.useZip64 = 1;
	}

	// Token: 0x060018B5 RID: 6325 RVA: 0x00057E78 File Offset: 0x00056078
	public void Method13303(97 1, 571 2)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("archiveStorage");
		}
		if (2 == null)
		{
			throw new ArgumentNullException("dataSource");
		}
		if (this.isDisposed)
		{
			throw new ObjectDisposedException("ZipFile");
		}
		if (this.IsEmbeddedArchive())
		{
			throw new 415("Cannot update embedded/SFX archives");
		}
		this.archiveStorage = 1;
		this.dataSource = 2;
		this.hashtable = new Hashtable();
		this.arrayList = new ArrayList(this.entries.Length);
		foreach (783 3 in this.entries)
		{
			int num = this.arrayList.Add(new 905.914(3));
			this.hashtable.Add(3.GetText9996_12802(), num);
		}
		this.arrayList.Sort(new 905.912());
		int num2 = 0;
		foreach (object obj in this.arrayList)
		{
			905.914 4 = (905.914)obj;
			if (num2 == this.arrayList.Count - 1)
			{
				break;
			}
			4.SetOriginalSpan(((905.914)this.arrayList[num2 + 1]).GetEntry().GetNumber10007_12783() - 4.GetEntry().GetNumber10007_12783());
			num2++;
		}
		this.entryCount = (long)this.arrayList.Count;
		this.hasEntryChanges = false;
		this.hasCommentChanges = false;
		this.pendingComment = null;
	}

	// Token: 0x060018B6 RID: 6326 RVA: 0x00058004 File Offset: 0x00056204
	public void Method13303(97 1)
	{
		this.Method13303(1, new 379());
	}

	// Token: 0x060018B7 RID: 6327 RVA: 0x00058012 File Offset: 0x00056212
	public void Method13303()
	{
		if (this.GetName() == null)
		{
			this.Method13303(new 561(), new 379());
			return;
		}
		this.Method13303(new 57(this), new 379());
	}

	// Token: 0x060018B8 RID: 6328 RVA: 0x00058040 File Offset: 0x00056240
	public void CommitUpdate()
	{
		if (this.isDisposed)
		{
			throw new ObjectDisposedException("ZipFile");
		}
		this.CheckUpdating();
		try
		{
			this.hashtable.Clear();
			this.hashtable = null;
			if (this.hasEntryChanges)
			{
				this.RunUpdates();
			}
			else if (this.hasCommentChanges)
			{
				this.UpdateCommentOnly();
			}
			else if (this.entries.Length == 0)
			{
				byte[] <<EMPTY_NAME>> = (this.pendingComment != null) ? this.pendingComment.GetRawBytes() : 448.Method4014(this.comment);
				403 2 = new 403(this.baseStream);
				try
				{
					2._0008_2006_2000_200A_2003_200B_2002_2006_2005_200B_2008_2005_2009_2003_2000(0L, 0L, 0L, <<EMPTY_NAME>>);
				}
				finally
				{
					((IDisposable)2).Dispose();
				}
			}
		}
		finally
		{
			this.CleanupUpdate();
		}
	}

	// Token: 0x060018B9 RID: 6329 RVA: 0x0005810C File Offset: 0x0005630C
	public void AbortUpdate()
	{
		this.CleanupUpdate();
	}

	// Token: 0x060018BA RID: 6330 RVA: 0x00058114 File Offset: 0x00056314
	public void SetComment(string 1)
	{
		if (this.isDisposed)
		{
			throw new ObjectDisposedException("ZipFile");
		}
		this.CheckUpdating();
		this.pendingComment = new 905.913(1);
		if (this.pendingComment.GetRawLength() > 65535)
		{
			this.pendingComment = null;
			throw new 415("Comment length exceeds maximum - 65535");
		}
		this.hasCommentChanges = true;
	}

	// Token: 0x060018BB RID: 6331 RVA: 0x00058174 File Offset: 0x00056374
	private void AddOrReplaceUpdate(905.914 1)
	{
		this.hasEntryChanges = true;
		int num = this.Method13338(1.GetEntry().GetText9996_12802());
		if (num >= 0)
		{
			if (this.arrayList[num] == null)
			{
				this.entryCount += 1L;
			}
			this.arrayList[num] = 1;
			return;
		}
		num = this.arrayList.Add(1);
		this.entryCount += 1L;
		this.hashtable.Add(1.GetEntry().GetText9996_12802(), num);
	}

	// Token: 0x060018BC RID: 6332 RVA: 0x00058204 File Offset: 0x00056404
	public void Method13310(string 1, 536 2, bool 3)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("fileName");
		}
		if (this.isDisposed)
		{
			throw new ObjectDisposedException("ZipFile");
		}
		if (!783.Method12825(2))
		{
			throw new ArgumentOutOfRangeException("compressionMethod");
		}
		this.CheckUpdating();
		this.hasEntryChanges = true;
		783 4 = this.GetEntryFactory().Method16802(1);
		4.Method12776(3);
		4.Method12810(2);
		this.AddOrReplaceUpdate(new 905.914(1, 4));
	}

	// Token: 0x060018BD RID: 6333 RVA: 0x0005827C File Offset: 0x0005647C
	public void Method13310(string 1, 536 2)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("fileName");
		}
		if (!783.Method12825(2))
		{
			throw new ArgumentOutOfRangeException("compressionMethod");
		}
		this.CheckUpdating();
		this.hasEntryChanges = true;
		783 3 = this.GetEntryFactory().Method16802(1);
		3.Method12810(2);
		this.AddOrReplaceUpdate(new 905.914(1, 3));
	}

	// Token: 0x060018BE RID: 6334 RVA: 0x000582D8 File Offset: 0x000564D8
	public void Method13310(string 1)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("#=zVhQsvQQ=");
		}
		this.CheckUpdating();
		this.AddOrReplaceUpdate(new 905.914(1, this.GetEntryFactory().Method16802(1)));
	}

	// Token: 0x060018BF RID: 6335 RVA: 0x00058306 File Offset: 0x00056506
	public void Method13310(string 1, string 2)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("#=zVhQsvQQ=");
		}
		if (2 == null)
		{
			throw new ArgumentNullException("#=zRBjuzko=");
		}
		this.CheckUpdating();
		this.AddOrReplaceUpdate(new 905.914(1, this.GetEntryFactory().Method16802(1, 2, true)));
	}

	// Token: 0x060018C0 RID: 6336 RVA: 0x00058344 File Offset: 0x00056544
	public void Method13310(790 1, string 2)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("dataSource");
		}
		if (2 == null)
		{
			throw new ArgumentNullException("entryName");
		}
		this.CheckUpdating();
		this.AddOrReplaceUpdate(new 905.914(1, this.GetEntryFactory().Method16802(2, false)));
	}

	// Token: 0x060018C1 RID: 6337 RVA: 0x00058384 File Offset: 0x00056584
	public void Method13310(790 1, string 2, 536 3)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("dataSource");
		}
		if (2 == null)
		{
			throw new ArgumentNullException("entryName");
		}
		this.CheckUpdating();
		783 4 = this.GetEntryFactory().Method16802(2, false);
		4.Method12810(3);
		this.AddOrReplaceUpdate(new 905.914(1, 4));
	}

	// Token: 0x060018C2 RID: 6338 RVA: 0x000583D8 File Offset: 0x000565D8
	public void Method13310(790 1, string 2, 536 3, bool 4)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("dataSource");
		}
		if (2 == null)
		{
			throw new ArgumentNullException("entryName");
		}
		this.CheckUpdating();
		783 5 = this.GetEntryFactory().Method16802(2, false);
		5.Method12776(4);
		5.Method12810(3);
		this.AddOrReplaceUpdate(new 905.914(1, 5));
	}

	// Token: 0x060018C3 RID: 6339 RVA: 0x00058431 File Offset: 0x00056631
	public void Method13310(783 1)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("entry");
		}
		this.CheckUpdating();
		if (1.Method12803() != 0L || 1.Method12805() != 0L)
		{
			throw new 415("Entry cannot have any data");
		}
		this.AddOrReplaceUpdate(new 905.914((905.911)2, 1));
	}

	// Token: 0x060018C4 RID: 6340 RVA: 0x00058470 File Offset: 0x00056670
	public void AddDirectory(string 1)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("#=zTKljP6Q=");
		}
		this.CheckUpdating();
		783 2 = this.GetEntryFactory().Method16832(1);
		this.AddOrReplaceUpdate(new 905.914((905.911)2, 2));
	}

	// Token: 0x060018C5 RID: 6341 RVA: 0x000584AC File Offset: 0x000566AC
	public bool Method13319(string 1)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("#=zVhQsvQQ=");
		}
		this.CheckUpdating();
		int num = this.Method13338(1);
		if (num >= 0 && this.arrayList[num] != null)
		{
			bool result = true;
			this.hasEntryChanges = true;
			this.arrayList[num] = null;
			this.entryCount -= 1L;
			return result;
		}
		throw new 415("Cannot find entry to delete");
	}

	// Token: 0x060018C6 RID: 6342 RVA: 0x00058518 File Offset: 0x00056718
	public void Method13319(783 1)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("entry");
		}
		this.CheckUpdating();
		int num = this.Method13338(1);
		if (num >= 0)
		{
			this.hasEntryChanges = true;
			this.arrayList[num] = null;
			this.entryCount -= 1L;
			return;
		}
		throw new 415("Cannot find entry to delete");
	}

	// Token: 0x060018C7 RID: 6343 RVA: 0x00058573 File Offset: 0x00056773
	private void WriteLeShort(int 1)
	{
		this.baseStream.WriteByte((byte)1);
		this.baseStream.WriteByte((byte)(1 >> 8));
	}

	// Token: 0x060018C8 RID: 6344 RVA: 0x00058573 File Offset: 0x00056773
	private void WriteLeUshort(ushort 1)
	{
		this.baseStream.WriteByte((byte)1);
		this.baseStream.WriteByte((byte)(1 >> 8));
	}

	// Token: 0x060018C9 RID: 6345 RVA: 0x00058591 File Offset: 0x00056791
	private void WriteLeInt(int 1)
	{
		this.WriteLeShort(1 & 65535);
		this.WriteLeShort(1 >> 16);
	}

	// Token: 0x060018CA RID: 6346 RVA: 0x000585AA File Offset: 0x000567AA
	private void WriteLeUint(uint 1)
	{
		this.WriteLeUshort((ushort)1);
		this.WriteLeUshort((ushort)(1 >> 16));
	}

	// Token: 0x060018CB RID: 6347 RVA: 0x000585BF File Offset: 0x000567BF
	private void WriteLeLong(long 1)
	{
		this.WriteLeInt((int)(1 & (long)((ulong)-1)));
		this.WriteLeInt((int)(1 >> 32));
	}

	// Token: 0x060018CC RID: 6348 RVA: 0x000585D7 File Offset: 0x000567D7
	private void WriteLeUlong(ulong 1)
	{
		this.WriteLeUint((uint)(1 & (ulong)-1));
		this.WriteLeUint((uint)(1 >> 32));
	}

	// Token: 0x060018CD RID: 6349 RVA: 0x000585F0 File Offset: 0x000567F0
	private void WriteLocalEntryHeader(905.914 1)
	{
		783 outEntry = 1.GetOutEntry();
		outEntry.SetNumber10007_12784(this.baseStream.Position);
		if (1.GetCommand() != (905.911)0)
		{
			if (outEntry.GetRecoveredType118710002_12809() == 536.Deflated)
			{
				if (outEntry.Method12803() == 0L)
				{
					outEntry.Method12806(outEntry.Method12803());
					outEntry.Method12808(0L);
					outEntry.Method12810(536.Stored);
				}
			}
			else if (outEntry.GetRecoveredType118710002_12809() == 536.Stored)
			{
				outEntry.SetNumber10005_12780(outEntry.GetNumber10005_12779() & -9);
			}
			if (this.HasPassword())
			{
				outEntry.Method12774(true);
				if (outEntry.Method12807() < 0L)
				{
					outEntry.SetNumber10005_12780(outEntry.GetNumber10005_12779() | 8);
				}
			}
			else
			{
				outEntry.Method12774(false);
			}
			609 2 = this.useZip64;
			if (2 != (609)1)
			{
				if (2 == (609)2 && outEntry.Method12803() < 0L)
				{
					outEntry.SetFlag10008_12794();
				}
			}
			else
			{
				outEntry.SetFlag10008_12794();
			}
		}
		this.WriteLeInt(67324752);
		this.WriteLeShort(outEntry.Method12792());
		this.WriteLeShort(outEntry.GetNumber10005_12779());
		this.WriteLeShort((int)((byte)outEntry.GetRecoveredType118710002_12809()));
		this.WriteLeInt((int)outEntry.Method12798());
		if (!outEntry.Method12772())
		{
			1.SetCrcPatchOffset(this.baseStream.Position);
			this.WriteLeInt(0);
		}
		else
		{
			this.WriteLeInt((int)outEntry.Method12807());
		}
		if (outEntry.Method12796())
		{
			this.WriteLeInt(-1);
			this.WriteLeInt(-1);
		}
		else
		{
			if (outEntry.Method12805() < 0L || outEntry.Method12803() < 0L)
			{
				1.SetSizePatchOffset(this.baseStream.Position);
			}
			this.WriteLeInt((int)outEntry.Method12805());
			this.WriteLeInt((int)outEntry.Method12803());
		}
		byte[] array = 448.Method4014(outEntry.GetNumber10005_12779(), outEntry.GetText9996_12802());
		if (array.Length > 65535)
		{
			throw new 415("Entry name too long.");
		}
		758 3 = new 758(outEntry.GetByteArray10003_12812());
		if (outEntry.Method12796())
		{
			3.SetMemoryStream9560_12229();
			3.Method12235(outEntry.Method12803());
			3.Method12235(outEntry.Method12805());
			3.Method12230(1);
		}
		else
		{
			3.Method12236(1);
		}
		outEntry.Method12813(3.Method12217());
		this.WriteLeShort(array.Length);
		this.WriteLeShort(outEntry.GetByteArray10003_12812().Length);
		if (array.Length != 0)
		{
			this.baseStream.Write(array, 0, array.Length);
		}
		if (outEntry.Method12796())
		{
			if (!3.Method12226(1))
			{
				throw new 415("Internal error cannot find extra data");
			}
			1.SetSizePatchOffset(this.baseStream.Position + (long)3.GetNumber9557_12224());
		}
		if (outEntry.GetByteArray10003_12812().Length != 0)
		{
			this.baseStream.Write(outEntry.GetByteArray10003_12812(), 0, outEntry.GetByteArray10003_12812().Length);
		}
	}

	// Token: 0x060018CE RID: 6350 RVA: 0x00058878 File Offset: 0x00056A78
	private int WriteCentralEntryHeader(783 1)
	{
		if (1.Method12805() < 0L)
		{
			throw new 415("Attempt to write central directory entry with unknown csize");
		}
		if (1.Method12803() < 0L)
		{
			throw new 415("Attempt to write central directory entry with unknown size");
		}
		if (1.Method12807() < 0L)
		{
			throw new 415("Attempt to write central directory entry with unknown crc");
		}
		this.WriteLeInt(33639248);
		this.WriteLeShort(51);
		this.WriteLeShort(1.Method12792());
		this.WriteLeShort(1.GetNumber10005_12779());
		this.WriteLeShort((int)((byte)1.GetRecoveredType118710002_12809()));
		this.WriteLeInt((int)1.Method12798());
		this.WriteLeInt((int)1.Method12807());
		if (1.GetFlag10008_12795() || 1.Method12805() >= (long)((ulong)-1))
		{
			this.WriteLeInt(-1);
		}
		else
		{
			this.WriteLeInt((int)(1.Method12805() & (long)((ulong)-1)));
		}
		if (1.GetFlag10008_12795() || 1.Method12803() >= (long)((ulong)-1))
		{
			this.WriteLeInt(-1);
		}
		else
		{
			this.WriteLeInt((int)1.Method12803());
		}
		byte[] array = 448.Method4014(1.GetNumber10005_12779(), 1.GetText9996_12802());
		if (array.Length > 65535)
		{
			throw new 415("Entry name is too long.");
		}
		this.WriteLeShort(array.Length);
		758 2 = new 758(1.GetByteArray10003_12812());
		if (1.Method12797())
		{
			2.SetMemoryStream9560_12229();
			if (1.Method12803() >= (long)((ulong)-1) || this.useZip64 == (609)1)
			{
				2.Method12235(1.Method12803());
			}
			if (1.Method12805() >= (long)((ulong)-1) || this.useZip64 == (609)1)
			{
				2.Method12235(1.Method12805());
			}
			if (1.GetNumber10007_12783() >= (long)((ulong)-1))
			{
				2.Method12235(1.GetNumber10007_12783());
			}
			2.Method12230(1);
		}
		else
		{
			2.Method12236(1);
		}
		byte[] array2 = 2.Method12217();
		this.WriteLeShort(array2.Length);
		this.WriteLeShort((1.GetText10004_12821() != null) ? 1.GetText10004_12821().Length : 0);
		this.WriteLeShort(0);
		this.WriteLeShort(0);
		if (1.Method12785() != -1)
		{
			this.WriteLeInt(1.Method12785());
		}
		else if (1.Method12823())
		{
			this.WriteLeUint(16U);
		}
		else
		{
			this.WriteLeUint(0U);
		}
		if (1.GetNumber10007_12783() >= (long)((ulong)-1))
		{
			this.WriteLeUint(uint.MaxValue);
		}
		else
		{
			this.WriteLeUint((uint)1.GetNumber10007_12783());
		}
		if (array.Length != 0)
		{
			this.baseStream.Write(array, 0, array.Length);
		}
		if (array2.Length != 0)
		{
			this.baseStream.Write(array2, 0, array2.Length);
		}
		byte[] array3 = (1.GetText10004_12821() != null) ? Encoding.ASCII.GetBytes(1.GetText10004_12821()) : new byte[0];
		if (array3.Length != 0)
		{
			this.baseStream.Write(array3, 0, array3.Length);
		}
		return 46 + array.Length + array2.Length + array3.Length;
	}

	// Token: 0x060018CF RID: 6351 RVA: 0x00058B0D File Offset: 0x00056D0D
	private void CleanupUpdate()
	{
		this.dataSource = null;
		this.arrayList = null;
		this.hashtable = null;
		if (this.archiveStorage != null)
		{
			this.archiveStorage.Method7561();
			this.archiveStorage = null;
		}
	}

	// Token: 0x060018D0 RID: 6352 RVA: 0x00058B40 File Offset: 0x00056D40
	private string TransformEntryKey(string 1)
	{
		381 nameTransform = this.GetNameTransform();
		if (nameTransform == null)
		{
			return 1;
		}
		return nameTransform.Method10309(1);
	}

	// Token: 0x060018D1 RID: 6353 RVA: 0x00058B60 File Offset: 0x00056D60
	private string Method13331(string 1)
	{
		381 nameTransform = this.GetNameTransform();
		if (nameTransform == null)
		{
			return 1;
		}
		return nameTransform.Method10308(1);
	}

	// Token: 0x060018D2 RID: 6354 RVA: 0x00058B80 File Offset: 0x00056D80
	private byte[] GetCopyBuffer()
	{
		if (this.copyBuffer == null)
		{
			this.copyBuffer = new byte[this.bufferSize];
		}
		return this.copyBuffer;
	}

	// Token: 0x060018D3 RID: 6355 RVA: 0x00058BA4 File Offset: 0x00056DA4
	private void CopyDescriptor(905.914 1, Stream 2, Stream 3)
	{
		int i = this.GetDescriptorSize(1);
		if (i <= 0)
		{
			return;
		}
		byte[] array = this.GetCopyBuffer();
		while (i > 0)
		{
			int count = Math.Min(array.Length, i);
			int num = 3.Read(array, 0, count);
			if (num <= 0)
			{
				throw new 415("Unxpected end of stream");
			}
			2.Write(array, 0, num);
			i -= num;
		}
	}

	// Token: 0x060018D4 RID: 6356 RVA: 0x00058C00 File Offset: 0x00056E00
	private void CopyEntryData(905.914 1, Stream 2, Stream 3, long 4, bool 5)
	{
		if (2 == 3)
		{
			throw new InvalidOperationException("Destination and source are the same");
		}
		597 6 = new 597();
		byte[] array = this.GetCopyBuffer();
		long num = 4;
		long num2 = 0L;
		int num4;
		do
		{
			int num3 = array.Length;
			if (4 < (long)num3)
			{
				num3 = (int)4;
			}
			num4 = 3.Read(array, 0, num3);
			if (num4 > 0)
			{
				if (5)
				{
					6.Method90912(array, 0, num4);
				}
				2.Write(array, 0, num4);
				4 -= (long)num4;
				num2 += (long)num4;
			}
		}
		while (num4 > 0 && 4 > 0L);
		if (num2 != num)
		{
			throw new 415(string.Format("Failed to copy bytes expected {0} read {1}", num, num2));
		}
		if (5)
		{
			1.GetOutEntry().Method12808(6.GetNumber7041_9089());
		}
	}

	// Token: 0x060018D5 RID: 6357 RVA: 0x00058CB8 File Offset: 0x00056EB8
	private int GetDescriptorSize(905.914 1)
	{
		int result = 0;
		if ((1.GetEntry().GetNumber10005_12779() & 8) != 0)
		{
			result = 12;
			if (1.GetEntry().Method12796())
			{
				result = 20;
			}
		}
		return result;
	}

	// Token: 0x060018D6 RID: 6358 RVA: 0x00058CEC File Offset: 0x00056EEC
	private void MoveDescriptor(905.914 1, Stream 2, ref long 3, long 4)
	{
		int i = this.GetDescriptorSize(1);
		while (i > 0)
		{
			int count = i;
			byte[] buffer = this.GetCopyBuffer();
			2.Position = 4;
			int num = 2.Read(buffer, 0, count);
			if (num <= 0)
			{
				throw new 415("Unxpected end of stream");
			}
			2.Position = 3;
			2.Write(buffer, 0, num);
			i -= num;
			3 += (long)num;
			4 += (long)num;
		}
	}

	// Token: 0x060018D7 RID: 6359 RVA: 0x00058D58 File Offset: 0x00056F58
	private void MoveCompressedData(905.914 1, Stream 2, bool 3, ref long 4, ref long 5)
	{
		long num = 1.GetEntry().Method12805();
		597 6 = new 597();
		byte[] array = this.GetCopyBuffer();
		long num2 = num;
		long num3 = 0L;
		int num5;
		do
		{
			int num4 = array.Length;
			if (num < (long)num4)
			{
				num4 = (int)num;
			}
			2.Position = 5;
			num5 = 2.Read(array, 0, num4);
			if (num5 > 0)
			{
				if (3)
				{
					6.Method90912(array, 0, num5);
				}
				2.Position = 4;
				2.Write(array, 0, num5);
				4 += (long)num5;
				5 += (long)num5;
				num -= (long)num5;
				num3 += (long)num5;
			}
		}
		while (num5 > 0 && num > 0L);
		if (num3 != num2)
		{
			throw new 415(string.Format("Failed to copy bytes expected {0} read {1}", num2, num3));
		}
		if (3)
		{
			1.GetOutEntry().Method12808(6.GetNumber7041_9089());
		}
	}

	// Token: 0x060018D8 RID: 6360 RVA: 0x00058E30 File Offset: 0x00057030
	private int Method13338(783 1)
	{
		int result = -1;
		string key = this.TransformEntryKey(1.GetText9996_12802());
		if (this.hashtable.ContainsKey(key))
		{
			result = (int)this.hashtable[key];
		}
		return result;
	}

	// Token: 0x060018D9 RID: 6361 RVA: 0x00058E70 File Offset: 0x00057070
	private int Method13338(string 1)
	{
		int result = -1;
		string key = this.TransformEntryKey(1);
		if (this.hashtable.ContainsKey(key))
		{
			result = (int)this.hashtable[key];
		}
		return result;
	}

	// Token: 0x060018DA RID: 6362 RVA: 0x00058EA8 File Offset: 0x000570A8
	private Stream CreateOutputStream(783 1)
	{
		Stream 2 = this.baseStream;
		if (1.Method12773())
		{
			2 = this.CreateEncryptionStream(2, 1);
		}
		536 recoveredType118710002_ = 1.GetRecoveredType118710002_12809();
		if (recoveredType118710002_ == 536.Stored)
		{
			return new 905.910(2);
		}
		if (recoveredType118710002_ != 536.Deflated)
		{
			throw new 415("Unknown compression method " + 1.GetRecoveredType118710002_12809().ToString());
		}
		628 3 = new 628(2, new 51(9, true));
		3._0005_2000_200A_200A_2009_200A_2006_2009_200A_2003_2003_2006_2006(false);
		return 3;
	}

	// Token: 0x060018DB RID: 6363 RVA: 0x00058F20 File Offset: 0x00057120
	private void AddEntry(905 1, 905.914 2)
	{
		Stream stream = null;
		if (2.GetEntry().Method12824())
		{
			stream = 2.GetSourceStream();
			if (stream == null)
			{
				stream = this.dataSource.Method2040(2.GetEntry(), 2.GetFileName());
			}
		}
		if (stream != null)
		{
			using (stream)
			{
				long length = stream.Length;
				if (2.GetOutEntry().Method12803() < 0L)
				{
					2.GetOutEntry().Method12804(length);
				}
				else if (2.GetOutEntry().Method12803() != length)
				{
					throw new 415("Entry size/stream size mismatch");
				}
				1.WriteLocalEntryHeader(2);
				long position = 1.baseStream.Position;
				using (Stream stream3 = 1.CreateOutputStream(2.GetOutEntry()))
				{
					this.CopyEntryData(2, stream3, stream, length, true);
				}
				long position2 = 1.baseStream.Position;
				2.GetOutEntry().Method12806(position2 - position);
				if ((2.GetOutEntry().GetNumber10005_12779() & 8) == 8)
				{
					new 403(1.baseStream)._000E_200B_2000_2005_2001_2005_200A_2004_2008_2002_2000_2006_2005_2004_2007_2002_2002_2008_200A_2003_2007_2004_200B(2.GetOutEntry());
				}
				return;
			}
		}
		1.WriteLocalEntryHeader(2);
		2.GetOutEntry().Method12806(0L);
	}

	// Token: 0x060018DC RID: 6364 RVA: 0x00059060 File Offset: 0x00057260
	private void ModifyEntry(905 1, 905.914 2)
	{
		1.WriteLocalEntryHeader(2);
		long position = 1.baseStream.Position;
		if (2.GetEntry().Method12824() && 2.GetFileName() != null)
		{
			using (Stream stream = 1.CreateOutputStream(2.GetOutEntry()))
			{
				using (Stream stream2 = this.Method13289(2.GetEntry()))
				{
					this.CopyEntryData(2, stream, stream2, stream2.Length, true);
				}
			}
		}
		long position2 = 1.baseStream.Position;
		2.GetEntry().Method12806(position2 - position);
	}

	// Token: 0x060018DD RID: 6365 RVA: 0x0005910C File Offset: 0x0005730C
	private void RelocateEntry(905 1, 905.914 2, ref long 3)
	{
		bool flag = false;
		if (2.GetEntry().GetNumber10007_12783() == 3)
		{
			flag = true;
		}
		if (!flag)
		{
			this.baseStream.Position = 3;
			1.WriteLocalEntryHeader(2);
			3 = this.baseStream.Position;
		}
		long num = 0L;
		long num2 = 2.GetEntry().GetNumber10007_12783() + 26L;
		this.baseStream.Seek(num2, SeekOrigin.Begin);
		uint num3 = (uint)this.ReadLeUshort();
		uint num4 = (uint)this.ReadLeUshort();
		num = this.baseStream.Position + (long)((ulong)num3) + (long)((ulong)num4);
		if (!flag)
		{
			if (2.GetEntry().Method12805() > 0L)
			{
				this.MoveCompressedData(2, this.baseStream, false, ref 3, ref num);
			}
			this.MoveDescriptor(2, this.baseStream, ref 3, num);
			return;
		}
		if (2.GetOriginalSpan() != -1L)
		{
			3 += 2.GetOriginalSpan();
			return;
		}
		3 += num - num2 + 26L + 2.GetEntry().Method12805() + (long)this.GetDescriptorSize(2);
	}

	// Token: 0x060018DE RID: 6366 RVA: 0x00059200 File Offset: 0x00057400
	private void CopyEntry(905 1, 905.914 2)
	{
		1.WriteLocalEntryHeader(2);
		if (2.GetEntry().Method12805() > 0L)
		{
			long offset = 2.GetEntry().GetNumber10007_12783() + 26L;
			this.baseStream.Seek(offset, SeekOrigin.Begin);
			uint num = (uint)this.ReadLeUshort();
			uint num2 = (uint)this.ReadLeUshort();
			this.baseStream.Seek((long)((ulong)(num + num2)), SeekOrigin.Current);
			this.CopyEntryData(2, 1.baseStream, this.baseStream, 2.GetEntry().Method12805(), false);
		}
		this.CopyDescriptor(2, 1.baseStream, this.baseStream);
	}

	// Token: 0x060018DF RID: 6367 RVA: 0x00059292 File Offset: 0x00057492
	private void Method13345(Stream 1)
	{
		if (1 == null)
		{
			throw new 415("Failed to reopen archive - no source");
		}
		this.isNewArchive = false;
		this.baseStream = 1;
		this.ReadEntries();
	}

	// Token: 0x060018E0 RID: 6368 RVA: 0x000592B6 File Offset: 0x000574B6
	private void Method13345()
	{
		if (this.GetName() == null)
		{
			throw new InvalidOperationException("Name is not known cannot Reopen");
		}
		this.Method13345(File.Open(this.GetName(), FileMode.Open, FileAccess.Read, FileShare.Read));
	}

	// Token: 0x060018E1 RID: 6369 RVA: 0x000592E0 File Offset: 0x000574E0
	private void UpdateCommentOnly()
	{
		long length = this.baseStream.Length;
		403 <<EMPTY_NAME>>;
		if (this.archiveStorage.GetRecoveredType07366813_8757() == (455)0)
		{
			<<EMPTY_NAME>> = new 403(this.archiveStorage.Method7559(this.baseStream));
			<<EMPTY_NAME>>._0005_2004_2002_2004_2008_2008_2006_2004_2004_2000_2000_2002_2006_2000_2000_2003_2008_200A_2004_200B_2001_2005_2001_2001(true);
			this.baseStream.Close();
			this.baseStream = null;
		}
		else if (this.archiveStorage.GetRecoveredType07366813_8757() == (455)1)
		{
			this.baseStream = this.archiveStorage.Method7560(this.baseStream);
			<<EMPTY_NAME>> = new 403(this.baseStream);
		}
		else
		{
			this.baseStream.Close();
			this.baseStream = null;
			<<EMPTY_NAME>> = new 403(this.GetName());
		}
		using (<<EMPTY_NAME>>)
		{
			if (<<EMPTY_NAME>>._0003_2000_2003_2001_2003_2009_2000_2003_2005_2002_2008_2004(101010256, length, 22, 65535) < 0L)
			{
				throw new 415("Cannot find central directory");
			}
			<<EMPTY_NAME>>.Position += 16L;
			byte[] rawBytes = this.pendingComment.GetRawBytes();
			<<EMPTY_NAME>>._0003_2005_2003_2009_2009_2004_2003_2005_2006_2002_2006_2002_2006_2007_2000_200B_2005_2004_2003_2000_2003_2001_2004_2009(rawBytes.Length);
			<<EMPTY_NAME>>.Write(rawBytes, 0, rawBytes.Length);
			<<EMPTY_NAME>>.SetLength(<<EMPTY_NAME>>.Position);
		}
		if (this.archiveStorage.GetRecoveredType07366813_8757() == (455)0)
		{
			this.Method13345(this.archiveStorage.Method7558());
			return;
		}
		this.ReadEntries();
	}

	// Token: 0x060018E2 RID: 6370 RVA: 0x0005942C File Offset: 0x0005762C
	private void RunUpdates()
	{
		long num = 0L;
		long length = 0L;
		bool flag = false;
		long position = 0L;
		905 <<EMPTY_NAME>>;
		if (this.GetIsNewArchive())
		{
			<<EMPTY_NAME>> = this;
			<<EMPTY_NAME>>.baseStream.Position = 0L;
			flag = true;
		}
		else if (this.archiveStorage.GetRecoveredType07366813_8757() == (455)1)
		{
			<<EMPTY_NAME>> = this;
			<<EMPTY_NAME>>.baseStream.Position = 0L;
			flag = true;
			this.arrayList.Sort(new 905.912());
		}
		else
		{
			<<EMPTY_NAME>> = 905.Method13277(this.archiveStorage.Method7557());
			<<EMPTY_NAME>>.SetUseZip64(this.GetUseZip64());
			if (this.passwordKeys != null)
			{
				<<EMPTY_NAME>>.passwordKeys = (byte[])this.passwordKeys.Clone();
			}
		}
		try
		{
			foreach (object obj in this.arrayList)
			{
				905.914 2 = (905.914)obj;
				if (2 != null)
				{
					switch (2.GetCommand())
					{
					case (905.911)0:
						if (flag)
						{
							this.RelocateEntry(<<EMPTY_NAME>>, 2, ref position);
						}
						else
						{
							this.CopyEntry(<<EMPTY_NAME>>, 2);
						}
						break;
					case (905.911)1:
						this.ModifyEntry(<<EMPTY_NAME>>, 2);
						break;
					case (905.911)2:
						if (!this.GetIsNewArchive() && flag)
						{
							<<EMPTY_NAME>>.baseStream.Position = position;
						}
						this.AddEntry(<<EMPTY_NAME>>, 2);
						if (flag)
						{
							position = <<EMPTY_NAME>>.baseStream.Position;
						}
						break;
					}
				}
			}
			if (!this.GetIsNewArchive() && flag)
			{
				<<EMPTY_NAME>>.baseStream.Position = position;
			}
			long position2 = <<EMPTY_NAME>>.baseStream.Position;
			foreach (object obj2 in this.arrayList)
			{
				905.914 3 = (905.914)obj2;
				if (3 != null)
				{
					num += (long)<<EMPTY_NAME>>.WriteCentralEntryHeader(3.GetOutEntry());
				}
			}
			byte[] 4 = (this.pendingComment != null) ? this.pendingComment.GetRawBytes() : 448.Method4014(this.comment);
			403 5 = new 403(<<EMPTY_NAME>>.baseStream);
			try
			{
				5._0008_2006_2000_200A_2003_200B_2002_2006_2005_200B_2008_2005_2009_2003_2000(this.entryCount, num, position2, 4);
			}
			finally
			{
				((IDisposable)5).Dispose();
			}
			length = <<EMPTY_NAME>>.baseStream.Position;
			foreach (object obj3 in this.arrayList)
			{
				905.914 6 = (905.914)obj3;
				if (6 != null)
				{
					if (6.GetCrcPatchOffset() > 0L && 6.GetOutEntry().Method12805() > 0L)
					{
						<<EMPTY_NAME>>.baseStream.Position = 6.GetCrcPatchOffset();
						<<EMPTY_NAME>>.WriteLeInt((int)6.GetOutEntry().Method12807());
					}
					if (6.GetSizePatchOffset() > 0L)
					{
						<<EMPTY_NAME>>.baseStream.Position = 6.GetSizePatchOffset();
						if (6.GetOutEntry().Method12796())
						{
							<<EMPTY_NAME>>.WriteLeLong(6.GetOutEntry().Method12803());
							<<EMPTY_NAME>>.WriteLeLong(6.GetOutEntry().Method12805());
						}
						else
						{
							<<EMPTY_NAME>>.WriteLeInt((int)6.GetOutEntry().Method12805());
							<<EMPTY_NAME>>.WriteLeInt((int)6.GetOutEntry().Method12803());
						}
					}
				}
			}
		}
		catch
		{
			<<EMPTY_NAME>>.Close();
			if (!flag && <<EMPTY_NAME>>.GetName() != null)
			{
				File.Delete(<<EMPTY_NAME>>.GetName());
			}
			throw;
		}
		if (flag)
		{
			<<EMPTY_NAME>>.baseStream.SetLength(length);
			<<EMPTY_NAME>>.baseStream.Flush();
			this.isNewArchive = false;
			this.ReadEntries();
			return;
		}
		this.baseStream.Close();
		this.Method13345(this.archiveStorage.Method7558());
	}

	// Token: 0x060018E3 RID: 6371 RVA: 0x00059858 File Offset: 0x00057A58
	private void CheckUpdating()
	{
		if (this.arrayList == null)
		{
			throw new InvalidOperationException("BeginUpdate has not been called");
		}
	}

	// Token: 0x060018E4 RID: 6372 RVA: 0x0005986D File Offset: 0x00057A6D
	private void CloseArchive()
	{
		this.Close();
	}

	// Token: 0x060018E5 RID: 6373 RVA: 0x00059875 File Offset: 0x00057A75
	void IDisposable.Dispose()
	{
		this.CloseArchive();
	}

	// Token: 0x060018E6 RID: 6374 RVA: 0x00059880 File Offset: 0x00057A80
	private void DisposeInternal(bool 1)
	{
		if (this.isDisposed)
		{
			return;
		}
		this.isDisposed = true;
		this.entries = new 783[0];
		if (this.GetIsStreamOwner() && this.baseStream != null)
		{
			Stream obj = this.baseStream;
			lock (obj)
			{
				this.baseStream.Close();
			}
		}
		this.CleanupUpdate();
	}

	// Token: 0x060018E7 RID: 6375 RVA: 0x000598F8 File Offset: 0x00057AF8
	protected void DisposeCore(bool 1)
	{
		this.DisposeInternal(1);
	}

	// Token: 0x060018E8 RID: 6376 RVA: 0x00059904 File Offset: 0x00057B04
	private ushort ReadLeUshort()
	{
		int num = this.baseStream.ReadByte();
		if (num < 0)
		{
			throw new EndOfStreamException("End of stream");
		}
		int num2 = this.baseStream.ReadByte();
		if (num2 < 0)
		{
			throw new EndOfStreamException("End of stream");
		}
		return (ushort)num | (ushort)(num2 << 8);
	}

	// Token: 0x060018E9 RID: 6377 RVA: 0x0005994D File Offset: 0x00057B4D
	private uint ReadLeUint()
	{
		return (uint)((int)this.ReadLeUshort() | (int)this.ReadLeUshort() << 16);
	}

	// Token: 0x060018EA RID: 6378 RVA: 0x0005995F File Offset: 0x00057B5F
	private ulong ReadLeUlong()
	{
		return (ulong)this.ReadLeUint() | (ulong)this.ReadLeUint() << 32;
	}

	// Token: 0x060018EB RID: 6379 RVA: 0x00059974 File Offset: 0x00057B74
	private long LocateBlockWithSignature(int 1, long 2, int 3, int 4)
	{
		403 5 = new 403(this.baseStream);
		long result;
		try
		{
			result = 5._0003_2000_2003_2001_2003_2009_2000_2003_2005_2002_2008_2004(1, 2, 3, 4);
		}
		finally
		{
			((IDisposable)5).Dispose();
		}
		return result;
	}

	// Token: 0x060018EC RID: 6380 RVA: 0x000599B4 File Offset: 0x00057BB4
	private void ReadEntries()
	{
		if (!this.baseStream.CanSeek)
		{
			throw new 415("ZipFile stream must be seekable");
		}
		long num = this.LocateBlockWithSignature(101010256, this.baseStream.Length, 22, 65535);
		if (num < 0L)
		{
			throw new 415("Cannot find central directory");
		}
		int num2 = (int)this.ReadLeUshort();
		ushort num3 = this.ReadLeUshort();
		ulong num4 = (ulong)this.ReadLeUshort();
		ulong num5 = (ulong)this.ReadLeUshort();
		ulong num6 = (ulong)this.ReadLeUint();
		long num7 = (long)((ulong)this.ReadLeUint());
		uint num8 = (uint)this.ReadLeUshort();
		if (num8 != 0U)
		{
			byte[] array = new byte[num8];
			402.Method2546(this.baseStream, array);
			this.comment = 448.Method4010(array);
		}
		else
		{
			this.comment = string.Empty;
		}
		bool flag = false;
		if (num2 == 65535 || num3 == 65535 || num4 == 65535UL || num5 == 65535UL || num6 == (ulong)-1 || num7 == (long)((ulong)-1))
		{
			flag = true;
			if (this.LocateBlockWithSignature(117853008, num, 0, 4096) < 0L)
			{
				throw new 415("Cannot find Zip64 locator");
			}
			this.ReadLeUint();
			ulong num9 = this.ReadLeUlong();
			this.ReadLeUint();
			this.baseStream.Position = (long)num9;
			if ((ulong)this.ReadLeUint() != 101075792UL)
			{
				throw new 415(string.Format("Invalid Zip64 Central directory signature at {0:X}", num9));
			}
			this.ReadLeUlong();
			this.ReadLeUshort();
			this.ReadLeUshort();
			this.ReadLeUint();
			this.ReadLeUint();
			num4 = this.ReadLeUlong();
			num5 = this.ReadLeUlong();
			num6 = this.ReadLeUlong();
			num7 = (long)this.ReadLeUlong();
		}
		this.entries = new 783[num4];
		if (!flag && num7 < num - (long)(4UL + num6))
		{
			this.archiveOffset = num - (long)(4UL + num6 + (ulong)num7);
			if (this.archiveOffset <= 0L)
			{
				throw new 415("Invalid embedded zip archive");
			}
		}
		this.baseStream.Seek(this.archiveOffset + num7, SeekOrigin.Begin);
		for (ulong num10 = 0UL; num10 < num4; num10 += 1UL)
		{
			if (this.ReadLeUint() != 33639248U)
			{
				throw new 415("Wrong Central Directory signature");
			}
			int <<EMPTY_NAME>> = (int)this.ReadLeUshort();
			int 2 = (int)this.ReadLeUshort();
			int num11 = (int)this.ReadLeUshort();
			int 3 = (int)this.ReadLeUshort();
			uint num12 = this.ReadLeUint();
			uint num13 = this.ReadLeUint();
			long num14 = (long)((ulong)this.ReadLeUint());
			long num15 = (long)((ulong)this.ReadLeUint());
			int num16 = (int)this.ReadLeUshort();
			int num17 = (int)this.ReadLeUshort();
			int num18 = (int)this.ReadLeUshort();
			this.ReadLeUshort();
			this.ReadLeUshort();
			uint 4 = this.ReadLeUint();
			long number10007_ = (long)((ulong)this.ReadLeUint());
			byte[] 5 = new byte[Math.Max(num16, num18)];
			402.Method2546(this.baseStream, 5, 0, num16);
			783 6 = new 783(448.Method4012(num11, 5, num16), 2, <<EMPTY_NAME>>, (536)3);
			6.Method12808((long)((ulong)num13 & (ulong)-1));
			6.Method12804(num15 & (long)((ulong)-1));
			6.Method12806(num14 & (long)((ulong)-1));
			6.SetNumber10005_12780(num11);
			6.Method12799((long)((ulong)num12));
			6.SetNumber10006_12782((long)num10);
			6.SetNumber10007_12784(number10007_);
			6.Method12786((int)4);
			if ((num11 & 8) == 0)
			{
				6.SetByte10009_12778((byte)(num13 >> 24));
			}
			else
			{
				6.SetByte10009_12778((byte)(num12 >> 8));
			}
			if (num17 > 0)
			{
				byte[] array2 = new byte[num17];
				402.Method2546(this.baseStream, array2);
				6.Method12813(array2);
			}
			6.Method12819(false);
			if (num18 > 0)
			{
				402.Method2546(this.baseStream, 5, 0, num18);
				6.Method12822(448.Method4012(num11, 5, num18));
			}
			this.entries[(int)(checked((IntPtr)num10))] = 6;
		}
	}

	// Token: 0x060018ED RID: 6381 RVA: 0x00059D5E File Offset: 0x00057F5E
	private long LocateEntry(783 1)
	{
		return this.TestLocalHeader(1, (905.907)1);
	}

	// Token: 0x060018EE RID: 6382 RVA: 0x00059D68 File Offset: 0x00057F68
	private Stream CreateDecryptionStream(Stream 1, 783 2)
	{
		CryptoStream cryptoStream;
		if (2.Method12792() < 50 || (2.GetNumber10005_12779() & 64) == 0)
		{
			627 3 = new 627();
			this.OnKeysRequired(2.GetText9996_12802());
			if (!this.HasPassword())
			{
				throw new 415("No password available for encrypted stream");
			}
			cryptoStream = new CryptoStream(1, 3.CreateDecryptor(this.passwordKeys, null), CryptoStreamMode.Read);
			905.CheckDecryptionHeader(cryptoStream, 2);
		}
		else
		{
			if (2.Method12792() != 51)
			{
				throw new 415("Decryption method not supported");
			}
			this.OnKeysRequired(2.GetText9996_12802());
			if (!this.HasPassword())
			{
				throw new 415("No password available for AES encrypted stream");
			}
			int num = 2.Method12817();
			byte[] array = new byte[num];
			int num2 = 1.Read(array, 0, num);
			if (num2 != num)
			{
				throw new 415("AES Salt expected " + num.ToString() + " got " + num2.ToString());
			}
			byte[] array2 = new byte[2];
			1.Read(array2, 0, 2);
			int 4 = 2.Method12814() / 8;
			413 5 = new 413(this.password, array, 4, false);
			byte[] byteArray2458_ = 5.GetByteArray2458_3084();
			if (byteArray2458_[0] != array2[0] || byteArray2458_[1] != array2[1])
			{
				throw new Exception("Invalid password for AES");
			}
			cryptoStream = new 716(1, 5, CryptoStreamMode.Read);
		}
		return cryptoStream;
	}

	// Token: 0x060018EF RID: 6383 RVA: 0x00059EA8 File Offset: 0x000580A8
	private Stream CreateEncryptionStream(Stream 1, 783 2)
	{
		CryptoStream cryptoStream = null;
		if (2.Method12792() < 50 || (2.GetNumber10005_12779() & 64) == 0)
		{
			627 3 = new 627();
			this.OnKeysRequired(2.GetText9996_12802());
			if (!this.HasPassword())
			{
				throw new 415("No password available for encrypted stream");
			}
			cryptoStream = new CryptoStream(new 905.910(1), 3.CreateEncryptor(this.passwordKeys, null), CryptoStreamMode.Write);
			if (2.Method12807() < 0L || (2.GetNumber10005_12779() & 8) != 0)
			{
				905.WriteEncryptionHeader(cryptoStream, 2.Method12798() << 16);
			}
			else
			{
				905.WriteEncryptionHeader(cryptoStream, 2.Method12807());
			}
		}
		return cryptoStream;
	}

	// Token: 0x060018F0 RID: 6384 RVA: 0x00059F40 File Offset: 0x00058140
	private static void CheckDecryptionHeader(CryptoStream 1, 783 2)
	{
		byte[] array = new byte[12];
		402.Method2546(1, array);
		if (array[11] != 2.GetByte10009_12777())
		{
			throw new 415("Invalid password");
		}
	}

	// Token: 0x060018F1 RID: 6385 RVA: 0x00059F74 File Offset: 0x00058174
	private static void WriteEncryptionHeader(Stream 1, long 2)
	{
		byte[] array = new byte[12];
		new Random().NextBytes(array);
		array[11] = (byte)(2 >> 24);
		1.Write(array, 0, array.Length);
	}

	// Token: 0x04000B85 RID: 2949
	public 905.908 keysRequired;

	// Token: 0x04000B86 RID: 2950
	private bool isDisposed;

	// Token: 0x04000B87 RID: 2951
	private string fileName;

	// Token: 0x04000B88 RID: 2952
	private string comment;

	// Token: 0x04000B89 RID: 2953
	private string password;

	// Token: 0x04000B8A RID: 2954
	private Stream baseStream;

	// Token: 0x04000B8B RID: 2955
	private bool isStreamOwner;

	// Token: 0x04000B8C RID: 2956
	private long archiveOffset;

	// Token: 0x04000B8D RID: 2957
	private 783[] entries;

	// Token: 0x04000B8E RID: 2958
	private byte[] passwordKeys;

	// Token: 0x04000B8F RID: 2959
	private bool isNewArchive;

	// Token: 0x04000B90 RID: 2960
	private 609 useZip64 = (609)2;

	// Token: 0x04000B91 RID: 2961
	private ArrayList arrayList;

	// Token: 0x04000B92 RID: 2962
	private long entryCount;

	// Token: 0x04000B93 RID: 2963
	private Hashtable hashtable;

	// Token: 0x04000B94 RID: 2964
	private 97 archiveStorage;

	// Token: 0x04000B95 RID: 2965
	private 571 dataSource;

	// Token: 0x04000B96 RID: 2966
	private bool hasEntryChanges;

	// Token: 0x04000B97 RID: 2967
	private int bufferSize = 4096;

	// Token: 0x04000B98 RID: 2968
	private byte[] copyBuffer;

	// Token: 0x04000B99 RID: 2969
	private 905.913 pendingComment;

	// Token: 0x04000B9A RID: 2970
	private bool hasCommentChanges;

	// Token: 0x04000B9B RID: 2971
	private 681 entryFactory = new 362();

	// Token: 0x02000329 RID: 809
	public sealed class 912 : IComparer
	{
		// Token: 0x060018F2 RID: 6386 RVA: 0x00059FA8 File Offset: 0x000581A8
		public int Compare(object 1, object 2)
		{
			905.914 3 = 1 as 905.914;
			905.914 4 = 2 as 905.914;
			int num;
			if (3 == null)
			{
				num = ((4 != null) ? -1 : 0);
			}
			else if (4 == null)
			{
				num = 1;
			}
			else
			{
				int num2 = (3.GetCommand() != (905.911)0 && 3.GetCommand() != (905.911)1) ? 1 : 0;
				int num3 = (4.GetCommand() != (905.911)0 && 4.GetCommand() != (905.911)1) ? 1 : 0;
				num = num2 - num3;
				if (num == 0)
				{
					long num4 = 3.GetEntry().GetNumber10007_12783() - 4.GetEntry().GetNumber10007_12783();
					num = ((num4 < 0L) ? -1 : ((num4 != 0L) ? 1 : 0));
				}
			}
			return num;
		}
	}

	// Token: 0x0200032A RID: 810
	public enum 911
	{

	}

	// Token: 0x0200032B RID: 811
	public sealed class 909 : Stream
	{
		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060018F4 RID: 6388 RVA: 0x0005A032 File Offset: 0x00058232
		// (set) Token: 0x060018F5 RID: 6389 RVA: 0x0005A044 File Offset: 0x00058244
		public override long Position
		{
			get
			{
				return this.currentOffset - this.startOffset;
			}
			set
			{
				long num = this.startOffset + value;
				if (num < this.startOffset)
				{
					throw new ArgumentException("Negative position is invalid");
				}
				if (num >= this.endOffset)
				{
					throw new InvalidOperationException("Cannot seek past end");
				}
				this.currentOffset = num;
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060018F6 RID: 6390 RVA: 0x0005A089 File Offset: 0x00058289
		public override long Length
		{
			get
			{
				return this.totalLength;
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060018F7 RID: 6391 RVA: 0x0000FF75 File Offset: 0x0000E175
		public override bool CanWrite
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060018F8 RID: 6392 RVA: 0x0001702D File Offset: 0x0001522D
		public override bool CanSeek
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x060018F9 RID: 6393 RVA: 0x0001702D File Offset: 0x0001522D
		public override bool CanRead
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x060018FA RID: 6394 RVA: 0x0005A091 File Offset: 0x00058291
		public override bool CanTimeout
		{
			get
			{
				return this.stream.CanTimeout;
			}
		}

		// Token: 0x060018FB RID: 6395 RVA: 0x0005A09E File Offset: 0x0005829E
		public 909(905 1, long 2, long 3)
		{
			this.startOffset = 2;
			this.totalLength = 3;
			this.zipFile = 1;
			this.stream = this.zipFile.baseStream;
			this.currentOffset = 2;
			this.endOffset = 2 + 3;
		}

		// Token: 0x060018FC RID: 6396 RVA: 0x0005A0DC File Offset: 0x000582DC
		public override int ReadByte()
		{
			if (this.currentOffset >= this.endOffset)
			{
				return -1;
			}
			Stream obj = this.stream;
			int result;
			lock (obj)
			{
				Stream stream = this.stream;
				long num = this.currentOffset;
				this.currentOffset = num + 1L;
				stream.Seek(num, SeekOrigin.Begin);
				result = this.stream.ReadByte();
			}
			return result;
		}

		// Token: 0x060018FD RID: 6397 RVA: 0x00005ADD File Offset: 0x00003CDD
		public override void Close()
		{
		}

		// Token: 0x060018FE RID: 6398 RVA: 0x0005A154 File Offset: 0x00058354
		public override int Read(byte[] 1, int 2, int 3)
		{
			Stream obj = this.stream;
			int result;
			lock (obj)
			{
				if ((long)3 > this.endOffset - this.currentOffset)
				{
					3 = (int)(this.endOffset - this.currentOffset);
					if (3 == 0)
					{
						return 0;
					}
				}
				this.stream.Seek(this.currentOffset, SeekOrigin.Begin);
				int num = this.stream.Read(1, 2, 3);
				if (num > 0)
				{
					this.currentOffset += (long)num;
				}
				result = num;
			}
			return result;
		}

		// Token: 0x060018FF RID: 6399 RVA: 0x00005BE8 File Offset: 0x00003DE8
		public override void Write(byte[] 1, int 2, int 3)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001900 RID: 6400 RVA: 0x00005BE8 File Offset: 0x00003DE8
		public override void SetLength(long 1)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001901 RID: 6401 RVA: 0x0005A1F0 File Offset: 0x000583F0
		public override long Seek(long 1, SeekOrigin 2)
		{
			long num = this.currentOffset;
			switch (2)
			{
			case SeekOrigin.Begin:
				num = this.startOffset + 1;
				break;
			case SeekOrigin.Current:
				num = this.currentOffset + 1;
				break;
			case SeekOrigin.End:
				num = this.endOffset + 1;
				break;
			}
			if (num < this.startOffset)
			{
				throw new ArgumentException("Negative position is invalid");
			}
			if (num >= this.endOffset)
			{
				throw new IOException("Cannot seek past end");
			}
			this.currentOffset = num;
			return this.currentOffset;
		}

		// Token: 0x06001902 RID: 6402 RVA: 0x00005ADD File Offset: 0x00003CDD
		public override void Flush()
		{
		}

		// Token: 0x04000B9D RID: 2973
		private 905 zipFile;

		// Token: 0x04000B9E RID: 2974
		private Stream stream;

		// Token: 0x04000B9F RID: 2975
		private long startOffset;

		// Token: 0x04000BA0 RID: 2976
		private long totalLength;

		// Token: 0x04000BA1 RID: 2977
		private long currentOffset;

		// Token: 0x04000BA2 RID: 2978
		private long endOffset;
	}

	// Token: 0x0200032C RID: 812
	// (Invoke) Token: 0x06001904 RID: 6404
	public delegate void 908(object 1, 480 2);

	// Token: 0x0200032D RID: 813
	public sealed class 914
	{
		// Token: 0x06001907 RID: 6407 RVA: 0x0005A26C File Offset: 0x0005846C
		public 914(string 1, 783 2)
		{
			this.command = (905.911)2;
			this.entry = 2;
			this.fileName = 1;
		}

		// Token: 0x06001908 RID: 6408 RVA: 0x0005A2A4 File Offset: 0x000584A4
		[Obsolete]
		public 914(string 1, string 2, 536 3)
		{
			this.command = (905.911)2;
			this.entry = new 783(2);
			this.entry.Method12810(3);
			this.fileName = 1;
		}

		// Token: 0x06001909 RID: 6409 RVA: 0x0005A2F5 File Offset: 0x000584F5
		[Obsolete]
		public 914(string 1, string 2) : this(1, 2, 536.Deflated)
		{
		}

		// Token: 0x0600190A RID: 6410 RVA: 0x0005A300 File Offset: 0x00058500
		[Obsolete]
		public 914(790 1, string 2, 536 3)
		{
			this.command = (905.911)2;
			this.entry = new 783(2);
			this.entry.Method12810(3);
			this.dataSource = 1;
		}

		// Token: 0x0600190B RID: 6411 RVA: 0x0005A351 File Offset: 0x00058551
		public 914(790 1, 783 2)
		{
			this.command = (905.911)2;
			this.entry = 2;
			this.dataSource = 1;
		}

		// Token: 0x0600190C RID: 6412 RVA: 0x0005A386 File Offset: 0x00058586
		public 914(783 1, 783 2)
		{
			throw new 415("Modify not currently supported");
		}

		// Token: 0x0600190D RID: 6413 RVA: 0x0005A3B0 File Offset: 0x000585B0
		public 914(905.911 1, 783 2)
		{
			this.command = 1;
			this.entry = (783)2.Clone();
		}

		// Token: 0x0600190E RID: 6414 RVA: 0x0005A3E8 File Offset: 0x000585E8
		public 914(783 1) : this((905.911)0, 1)
		{
		}

		// Token: 0x0600190F RID: 6415 RVA: 0x0005A3F2 File Offset: 0x000585F2
		public 783 GetEntry()
		{
			return this.entry;
		}

		// Token: 0x06001910 RID: 6416 RVA: 0x0005A3FA File Offset: 0x000585FA
		public 783 GetOutEntry()
		{
			if (this.outEntry == null)
			{
				this.outEntry = (783)this.entry.Clone();
			}
			return this.outEntry;
		}

		// Token: 0x06001911 RID: 6417 RVA: 0x0005A420 File Offset: 0x00058620
		public 905.911 GetCommand()
		{
			return this.command;
		}

		// Token: 0x06001912 RID: 6418 RVA: 0x0005A428 File Offset: 0x00058628
		public string GetFileName()
		{
			return this.fileName;
		}

		// Token: 0x06001913 RID: 6419 RVA: 0x0005A430 File Offset: 0x00058630
		public long GetSizePatchOffset()
		{
			return this.sizePatchOffset;
		}

		// Token: 0x06001914 RID: 6420 RVA: 0x0005A438 File Offset: 0x00058638
		public void SetSizePatchOffset(long 1)
		{
			this.sizePatchOffset = 1;
		}

		// Token: 0x06001915 RID: 6421 RVA: 0x0005A441 File Offset: 0x00058641
		public long GetCrcPatchOffset()
		{
			return this.crcPatchOffset;
		}

		// Token: 0x06001916 RID: 6422 RVA: 0x0005A449 File Offset: 0x00058649
		public void SetCrcPatchOffset(long 1)
		{
			this.crcPatchOffset = 1;
		}

		// Token: 0x06001917 RID: 6423 RVA: 0x0005A452 File Offset: 0x00058652
		public long GetOriginalSpan()
		{
			return this.originalSpan;
		}

		// Token: 0x06001918 RID: 6424 RVA: 0x0005A45A File Offset: 0x0005865A
		public void SetOriginalSpan(long 1)
		{
			this.originalSpan = 1;
		}

		// Token: 0x06001919 RID: 6425 RVA: 0x0005A464 File Offset: 0x00058664
		public Stream GetSourceStream()
		{
			Stream result = null;
			if (this.dataSource != null)
			{
				result = this.dataSource.OpenStream();
			}
			return result;
		}

		// Token: 0x04000BA3 RID: 2979
		private 783 entry;

		// Token: 0x04000BA4 RID: 2980
		private 783 outEntry;

		// Token: 0x04000BA5 RID: 2981
		private 905.911 command;

		// Token: 0x04000BA6 RID: 2982
		private 790 dataSource;

		// Token: 0x04000BA7 RID: 2983
		private string fileName;

		// Token: 0x04000BA8 RID: 2984
		private long sizePatchOffset = -1L;

		// Token: 0x04000BA9 RID: 2985
		private long crcPatchOffset = -1L;

		// Token: 0x04000BAA RID: 2986
		private long originalSpan = -1L;
	}

	// Token: 0x0200032E RID: 814
	public enum 907
	{

	}

	// Token: 0x0200032F RID: 815
	public sealed class 913
	{
		// Token: 0x0600191A RID: 6426 RVA: 0x0005A488 File Offset: 0x00058688
		public 913(string 1)
		{
			this.stringValue = 1;
			this.isFromText = true;
		}

		// Token: 0x0600191B RID: 6427 RVA: 0x0005A49E File Offset: 0x0005869E
		public 913(byte[] 1)
		{
			this.rawBytes = 1;
		}

		// Token: 0x0600191C RID: 6428 RVA: 0x0005A4AD File Offset: 0x000586AD
		public bool GetIsFromText()
		{
			return this.isFromText;
		}

		// Token: 0x0600191D RID: 6429 RVA: 0x0005A4B5 File Offset: 0x000586B5
		public int GetRawLength()
		{
			this.EnsureBytes();
			return this.rawBytes.Length;
		}

		// Token: 0x0600191E RID: 6430 RVA: 0x0005A4C5 File Offset: 0x000586C5
		public byte[] GetRawBytes()
		{
			this.EnsureBytes();
			return (byte[])this.rawBytes.Clone();
		}

		// Token: 0x0600191F RID: 6431 RVA: 0x0005A4DD File Offset: 0x000586DD
		public void ReleaseCache()
		{
			if (this.isFromText)
			{
				this.rawBytes = null;
				return;
			}
			this.stringValue = null;
		}

		// Token: 0x06001920 RID: 6432 RVA: 0x0005A4F6 File Offset: 0x000586F6
		private void EnsureText()
		{
			if (this.stringValue == null)
			{
				this.stringValue = 448.Method4010(this.rawBytes);
			}
		}

		// Token: 0x06001921 RID: 6433 RVA: 0x0005A511 File Offset: 0x00058711
		private void EnsureBytes()
		{
			if (this.rawBytes == null)
			{
				this.rawBytes = 448.Method4014(this.stringValue);
			}
		}

		// Token: 0x06001922 RID: 6434 RVA: 0x0005A52C File Offset: 0x0005872C
		public static implicit operator string(905.913 1)
		{
			1.EnsureText();
			return 1.stringValue;
		}

		// Token: 0x04000BAC RID: 2988
		private string stringValue;

		// Token: 0x04000BAD RID: 2989
		private byte[] rawBytes;

		// Token: 0x04000BAE RID: 2990
		private bool isFromText;
	}

	// Token: 0x02000330 RID: 816
	public sealed class 910 : Stream
	{
		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06001923 RID: 6435 RVA: 0x0000FF75 File Offset: 0x0000E175
		public override bool CanRead
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06001924 RID: 6436 RVA: 0x0005A53A File Offset: 0x0005873A
		public override bool CanWrite
		{
			get
			{
				return this.innerStream.CanWrite;
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06001925 RID: 6437 RVA: 0x0000FF75 File Offset: 0x0000E175
		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06001926 RID: 6438 RVA: 0x0004225D File Offset: 0x0004045D
		public override long Length
		{
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06001927 RID: 6439 RVA: 0x0005A547 File Offset: 0x00058747
		// (set) Token: 0x06001928 RID: 6440 RVA: 0x00005ADD File Offset: 0x00003CDD
		public override long Position
		{
			get
			{
				return this.innerStream.Position;
			}
			set
			{
			}
		}

		// Token: 0x06001929 RID: 6441 RVA: 0x0005A554 File Offset: 0x00058754
		public 910(Stream 1)
		{
			this.innerStream = 1;
		}

		// Token: 0x0600192A RID: 6442 RVA: 0x00005ADD File Offset: 0x00003CDD
		public override void Close()
		{
		}

		// Token: 0x0600192B RID: 6443 RVA: 0x0005A563 File Offset: 0x00058763
		public override void Flush()
		{
			this.innerStream.Flush();
		}

		// Token: 0x0600192C RID: 6444 RVA: 0x0000FF75 File Offset: 0x0000E175
		public override int Read(byte[] 1, int 2, int 3)
		{
			return 0;
		}

		// Token: 0x0600192D RID: 6445 RVA: 0x0004225D File Offset: 0x0004045D
		public override long Seek(long 1, SeekOrigin 2)
		{
			return 0L;
		}

		// Token: 0x0600192E RID: 6446 RVA: 0x00005ADD File Offset: 0x00003CDD
		public override void SetLength(long 1)
		{
		}

		// Token: 0x0600192F RID: 6447 RVA: 0x0005A570 File Offset: 0x00058770
		public override void Write(byte[] 1, int 2, int 3)
		{
			this.innerStream.Write(1, 2, 3);
		}

		// Token: 0x04000BAF RID: 2991
		private Stream innerStream;
	}

	// Token: 0x02000331 RID: 817
	public sealed class 906 : IEnumerator
	{
		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06001930 RID: 6448 RVA: 0x0005A580 File Offset: 0x00058780
		public object Current
		{
			get
			{
				return this.entries[this.currentIndex];
			}
		}

		// Token: 0x06001931 RID: 6449 RVA: 0x0005A58F File Offset: 0x0005878F
		public 906(783[] 1)
		{
			this.entries = 1;
		}

		// Token: 0x06001932 RID: 6450 RVA: 0x0005A5A5 File Offset: 0x000587A5
		public void Reset()
		{
			this.currentIndex = -1;
		}

		// Token: 0x06001933 RID: 6451 RVA: 0x0005A5B0 File Offset: 0x000587B0
		public bool MoveNext()
		{
			int num = this.currentIndex + 1;
			this.currentIndex = num;
			return num < this.entries.Length;
		}

		// Token: 0x04000BB0 RID: 2992
		private 783[] entries;

		// Token: 0x04000BB1 RID: 2993
		private int currentIndex = -1;
	}
}
