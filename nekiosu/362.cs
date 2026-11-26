using System;
using System.IO;
using System.Runtime.InteropServices;

// Token: 0x020002DD RID: 733
[ComVisible(false)]
public sealed class 362 : 681
{
	// Token: 0x060015FB RID: 5627 RVA: 0x0004C050 File Offset: 0x0004A250
	public 362()
	{
		this._recoveredType03711143 = new 686();
	}

	// Token: 0x060015FC RID: 5628 RVA: 0x0004C075 File Offset: 0x0004A275
	public 362(362.363 1)
	{
		this._recoveredType03071145 = 1;
		this._recoveredType03711143 = new 686();
	}

	// Token: 0x060015FD RID: 5629 RVA: 0x0004C0A1 File Offset: 0x0004A2A1
	public 362(DateTime 1)
	{
		this._recoveredType03071145 = (362.363)6;
		this.Method1673(1);
		this._recoveredType03711143 = new 686();
	}

	// Token: 0x060015FE RID: 5630 RVA: 0x0004C0D4 File Offset: 0x0004A2D4
	public 381 GetRecoveredType03711143_1668()
	{
		return this._recoveredType03711143;
	}

	// Token: 0x060015FF RID: 5631 RVA: 0x0004C0DC File Offset: 0x0004A2DC
	public void Method1669(381 1)
	{
		if (1 == null)
		{
			this._recoveredType03711143 = new 686();
			return;
		}
		this._recoveredType03711143 = 1;
	}

	// Token: 0x06001600 RID: 5632 RVA: 0x0004C0F4 File Offset: 0x0004A2F4
	public 362.363 GetRecoveredType03071145_1670()
	{
		return this._recoveredType03071145;
	}

	// Token: 0x06001601 RID: 5633 RVA: 0x0004C0FC File Offset: 0x0004A2FC
	public void SetRecoveredType03071145_1671(362.363 1)
	{
		this._recoveredType03071145 = 1;
	}

	// Token: 0x06001602 RID: 5634 RVA: 0x0004C105 File Offset: 0x0004A305
	public DateTime GetDateTime1144_1672()
	{
		return this.dateTime2;
	}

	// Token: 0x06001603 RID: 5635 RVA: 0x0004C10D File Offset: 0x0004A30D
	public void Method1673(DateTime 1)
	{
		if (1.Year < 1970)
		{
			throw new ArgumentException("Value is too old to be valid", "#=zUkSU2UA=");
		}
		this.dateTime2 = 1;
	}

	// Token: 0x06001604 RID: 5636 RVA: 0x0004C134 File Offset: 0x0004A334
	public int GetNumber1147_1674()
	{
		return this.number2;
	}

	// Token: 0x06001605 RID: 5637 RVA: 0x0004C13C File Offset: 0x0004A33C
	public void SetNumber1147_1675(int 1)
	{
		this.number2 = 1;
	}

	// Token: 0x06001606 RID: 5638 RVA: 0x0004C145 File Offset: 0x0004A345
	public int GetNumber1148_1676()
	{
		return this.number3;
	}

	// Token: 0x06001607 RID: 5639 RVA: 0x0004C14D File Offset: 0x0004A34D
	public void SetNumber1148_1677(int 1)
	{
		this.number3 = 1;
	}

	// Token: 0x06001608 RID: 5640 RVA: 0x0004C156 File Offset: 0x0004A356
	public bool GetFlag1146_1678()
	{
		return this.flag3;
	}

	// Token: 0x06001609 RID: 5641 RVA: 0x0004C15E File Offset: 0x0004A35E
	public void SetFlag1146_1679(bool 1)
	{
		this.flag3 = 1;
	}

	// Token: 0x0600160A RID: 5642 RVA: 0x0004C167 File Offset: 0x0004A367
	public 783 Method16802(string 1)
	{
		return this.Method16802(1, null, true);
	}

	// Token: 0x0600160B RID: 5643 RVA: 0x0004C172 File Offset: 0x0004A372
	public 783 Method16802(string 1, bool 2)
	{
		return this.Method16802(1, null, 2);
	}

	// Token: 0x0600160C RID: 5644 RVA: 0x0004C180 File Offset: 0x0004A380
	public 783 Method16802(string 1, string 2, bool 3)
	{
		783 4 = new 783(this._recoveredType03711143.Method10309((2 != null && 2.Length > 0) ? 2 : 1));
		4.Method12776(this.flag3);
		int num = 0;
		bool flag = this.number3 != 0;
		FileInfo fileInfo = null;
		if (3)
		{
			fileInfo = new FileInfo(1);
		}
		if (fileInfo != null && fileInfo.Exists)
		{
			switch (this._recoveredType03071145)
			{
			case (362.363)0:
				4.Method12801(fileInfo.LastWriteTime);
				break;
			case (362.363)1:
				4.Method12801(fileInfo.LastWriteTimeUtc);
				break;
			case (362.363)2:
				4.Method12801(fileInfo.CreationTime);
				break;
			case (362.363)3:
				4.Method12801(fileInfo.CreationTimeUtc);
				break;
			case (362.363)4:
				4.Method12801(fileInfo.LastAccessTime);
				break;
			case (362.363)5:
				4.Method12801(fileInfo.LastAccessTimeUtc);
				break;
			case (362.363)6:
				4.Method12801(this.dateTime2);
				break;
			default:
				throw new 415("Unhandled time setting in MakeFileEntry");
			}
			4.Method12804(fileInfo.Length);
			flag = true;
			num = (int)(fileInfo.Attributes & (FileAttributes)this.number2);
		}
		else if (this._recoveredType03071145 == (362.363)6)
		{
			4.Method12801(this.dateTime2);
		}
		if (flag)
		{
			num |= this.number3;
			4.Method12786(num);
		}
		return 4;
	}

	// Token: 0x0600160D RID: 5645 RVA: 0x0004C2C4 File Offset: 0x0004A4C4
	public 783 Method16832(string 1)
	{
		return this.Method16832(1, true);
	}

	// Token: 0x0600160E RID: 5646 RVA: 0x0004C2D0 File Offset: 0x0004A4D0
	public 783 Method16832(string 1, bool 2)
	{
		783 3 = new 783(this._recoveredType03711143.Method10308(1));
		3.Method12776(this.flag3);
		3.Method12804(0L);
		int num = 0;
		DirectoryInfo directoryInfo = null;
		if (2)
		{
			directoryInfo = new DirectoryInfo(1);
		}
		if (directoryInfo != null && directoryInfo.Exists)
		{
			switch (this._recoveredType03071145)
			{
			case (362.363)0:
				3.Method12801(directoryInfo.LastWriteTime);
				break;
			case (362.363)1:
				3.Method12801(directoryInfo.LastWriteTimeUtc);
				break;
			case (362.363)2:
				3.Method12801(directoryInfo.CreationTime);
				break;
			case (362.363)3:
				3.Method12801(directoryInfo.CreationTimeUtc);
				break;
			case (362.363)4:
				3.Method12801(directoryInfo.LastAccessTime);
				break;
			case (362.363)5:
				3.Method12801(directoryInfo.LastAccessTimeUtc);
				break;
			case (362.363)6:
				3.Method12801(this.dateTime2);
				break;
			default:
				throw new 415("Unhandled time setting in MakeDirectoryEntry");
			}
			num = (int)(directoryInfo.Attributes & (FileAttributes)this.number2);
		}
		else if (this._recoveredType03071145 == (362.363)6)
		{
			3.Method12801(this.dateTime2);
		}
		num |= (this.number3 | 16);
		3.Method12786(num);
		return 3;
	}

	// Token: 0x04000A65 RID: 2661
	private 381 _recoveredType03711143;

	// Token: 0x04000A66 RID: 2662
	private DateTime dateTime2 = DateTime.Now;

	// Token: 0x04000A67 RID: 2663
	private 362.363 _recoveredType03071145;

	// Token: 0x04000A68 RID: 2664
	private bool flag3;

	// Token: 0x04000A69 RID: 2665
	private int number2 = -1;

	// Token: 0x04000A6A RID: 2666
	private int number3;

	// Token: 0x020002DE RID: 734
	public enum 363
	{

	}
}
