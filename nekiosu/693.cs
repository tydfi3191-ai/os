using System;
using System.IO;
using System.Runtime.InteropServices;

// Token: 0x0200030F RID: 783
[ComVisible(false)]
public sealed class 693 : 712
{
	// Token: 0x0600177E RID: 6014 RVA: 0x00050FB1 File Offset: 0x0004F1B1
	public short GetInt169818_12597()
	{
		return 10;
	}

	// Token: 0x0600177F RID: 6015 RVA: 0x00050FB8 File Offset: 0x0004F1B8
	public void Method12599(byte[] 1, int 2, int 3)
	{
		MemoryStream memoryStream = new MemoryStream(1, 2, 3, false);
		try
		{
			403 4 = new 403(memoryStream);
			try
			{
				4._0006_200A_2001_200A_2007_2002_2005_200A_2003_2009_2009_2005_2002_200A_2007_2004_2007_2000_2001_2000_2000_2000_2005_2006_2001_2001_2006_2001_2006();
				while (4.Position < 4.Length)
				{
					int num = 4._0003_2009_2009_2001_2003_2004_200A_2001_2002_2008_2000_2002_2007_200A_2009_2000_2003_2005_2001();
					int num2 = 4._0003_2009_2009_2001_2003_2004_200A_2001_2002_2008_2000_2002_2007_200A_2009_2000_2003_2005_2001();
					if (num == 1)
					{
						if (num2 >= 24)
						{
							long fileTime = 4._0005_2004_200A_2004_2005_2002_2006_2001_2004_2000_2005_2000_2006_2000_2000_2007_2000_2004_200B_200B_2004_2005_2006_200A_2009_2003();
							this.dateTime3 = DateTime.FromFileTime(fileTime);
							long fileTime2 = 4._0005_2004_200A_2004_2005_2002_2006_2001_2004_2000_2005_2000_2006_2000_2000_2007_2000_2004_200B_200B_2004_2005_2006_200A_2009_2003();
							this.dateTime2 = DateTime.FromFileTime(fileTime2);
							long fileTime3 = 4._0005_2004_200A_2004_2005_2002_2006_2001_2004_2000_2005_2000_2006_2000_2000_2007_2000_2004_200B_200B_2004_2005_2006_200A_2009_2003();
							this.dateTime4 = DateTime.FromFileTime(fileTime3);
							break;
						}
						break;
					}
					else
					{
						4.Seek((long)num2, SeekOrigin.Current);
					}
				}
			}
			finally
			{
				((IDisposable)4).Dispose();
			}
		}
		finally
		{
			((IDisposable)memoryStream).Dispose();
		}
	}

	// Token: 0x06001780 RID: 6016 RVA: 0x00051078 File Offset: 0x0004F278
	public byte[] GetByteArray9819_12600()
	{
		MemoryStream memoryStream = new MemoryStream();
		byte[] result;
		try
		{
			403 <<EMPTY_NAME>> = new 403(memoryStream);
			try
			{
				<<EMPTY_NAME>>._0005_2004_2002_2004_2008_2008_2006_2004_2004_2000_2000_2002_2006_2000_2000_2003_2008_200A_2004_200B_2001_2005_2001_2001(false);
				<<EMPTY_NAME>>._0003_2004_2003_2008_2007_2007_200B_2007_2003_2009_2000_2004_2007_2004_2009_2005_2001_200A_200A_2006_2003(0);
				<<EMPTY_NAME>>._0003_2005_2003_2009_2009_2004_2003_2005_2006_2002_2006_2002_2006_2007_2000_200B_2005_2004_2003_2000_2003_2001_2004_2009(1);
				<<EMPTY_NAME>>._0003_2005_2003_2009_2009_2004_2003_2005_2006_2002_2006_2002_2006_2007_2000_200B_2005_2004_2003_2000_2003_2001_2004_2009(24);
				<<EMPTY_NAME>>._0003_2009_2003_2009_200B_2004_2009_2006_2000_200B_2009_2007_200B(this.dateTime3.ToFileTime());
				<<EMPTY_NAME>>._0003_2009_2003_2009_200B_2004_2009_2006_2000_200B_2009_2007_200B(this.dateTime2.ToFileTime());
				<<EMPTY_NAME>>._0003_2009_2003_2009_200B_2004_2009_2006_2000_200B_2009_2007_200B(this.dateTime4.ToFileTime());
				result = memoryStream.ToArray();
			}
			finally
			{
				((IDisposable)<<EMPTY_NAME>>).Dispose();
			}
		}
		finally
		{
			((IDisposable)memoryStream).Dispose();
		}
		return result;
	}

	// Token: 0x06001781 RID: 6017 RVA: 0x00051118 File Offset: 0x0004F318
	public static bool Method10374(DateTime 1)
	{
		bool result = true;
		try
		{
			1.ToFileTimeUtc();
		}
		catch
		{
			result = false;
		}
		return result;
	}

	// Token: 0x06001782 RID: 6018 RVA: 0x00051148 File Offset: 0x0004F348
	public DateTime GetDateTime8106_10375()
	{
		return this.dateTime3;
	}

	// Token: 0x06001783 RID: 6019 RVA: 0x00051150 File Offset: 0x0004F350
	public void Method10376(DateTime 1)
	{
		if (!693.Method10374(1))
		{
			throw new ArgumentOutOfRangeException("#=zUkSU2UA=");
		}
		this.dateTime3 = 1;
	}

	// Token: 0x06001784 RID: 6020 RVA: 0x0005116C File Offset: 0x0004F36C
	public DateTime GetDateTime8107_10377()
	{
		return this.dateTime4;
	}

	// Token: 0x06001785 RID: 6021 RVA: 0x00051174 File Offset: 0x0004F374
	public void Method10378(DateTime 1)
	{
		if (!693.Method10374(1))
		{
			throw new ArgumentOutOfRangeException("#=zUkSU2UA=");
		}
		this.dateTime4 = 1;
	}

	// Token: 0x06001786 RID: 6022 RVA: 0x00051190 File Offset: 0x0004F390
	public DateTime GetDateTime8105_10379()
	{
		return this.dateTime2;
	}

	// Token: 0x06001787 RID: 6023 RVA: 0x00051198 File Offset: 0x0004F398
	public void Method10380(DateTime 1)
	{
		if (!693.Method10374(1))
		{
			throw new ArgumentOutOfRangeException("#=zUkSU2UA=");
		}
		this.dateTime2 = 1;
	}

	// Token: 0x04000AF4 RID: 2804
	private DateTime dateTime2 = DateTime.FromFileTime(0L);

	// Token: 0x04000AF5 RID: 2805
	private DateTime dateTime3 = DateTime.FromFileTime(0L);

	// Token: 0x04000AF6 RID: 2806
	private DateTime dateTime4 = DateTime.FromFileTime(0L);
}
