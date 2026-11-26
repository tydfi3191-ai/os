using System;
using System.IO;
using System.Runtime.InteropServices;

// Token: 0x0200030B RID: 779
[ComVisible(false)]
public sealed class 684 : 712
{
	// Token: 0x06001759 RID: 5977 RVA: 0x000505B1 File Offset: 0x0004E7B1
	public short GetInt169818_12597()
	{
		return 21589;
	}

	// Token: 0x0600175A RID: 5978 RVA: 0x000505B8 File Offset: 0x0004E7B8
	public void Method12599(byte[] 1, int 2, int 3)
	{
		MemoryStream memoryStream = new MemoryStream(1, 2, 3, false);
		try
		{
			403 4 = new 403(memoryStream);
			try
			{
				this._recoveredType18458060 = (684.685)4.ReadByte();
				if ((this._recoveredType18458060 & (684.685)1) != (684.685)0 && 3 >= 5)
				{
					int seconds = 4._0006_200A_2001_200A_2007_2002_2005_200A_2003_2009_2009_2005_2002_200A_2007_2004_2007_2000_2001_2000_2000_2000_2005_2006_2001_2001_2006_2001_2006();
					this.dateTime2 = (new DateTime(1970, 1, 1, 0, 0, 0).ToUniversalTime() + new TimeSpan(0, 0, 0, seconds, 0)).ToLocalTime();
				}
				if ((this._recoveredType18458060 & (684.685)2) != (684.685)0)
				{
					int seconds2 = 4._0006_200A_2001_200A_2007_2002_2005_200A_2003_2009_2009_2005_2002_200A_2007_2004_2007_2000_2001_2000_2000_2000_2005_2006_2001_2001_2006_2001_2006();
					this.dateTime3 = (new DateTime(1970, 1, 1, 0, 0, 0).ToUniversalTime() + new TimeSpan(0, 0, 0, seconds2, 0)).ToLocalTime();
				}
				if ((this._recoveredType18458060 & (684.685)4) != (684.685)0)
				{
					int seconds3 = 4._0006_200A_2001_200A_2007_2002_2005_200A_2003_2009_2009_2005_2002_200A_2007_2004_2007_2000_2001_2000_2000_2000_2005_2006_2001_2001_2006_2001_2006();
					this.dateTime4 = (new DateTime(1970, 1, 1, 0, 0, 0).ToUniversalTime() + new TimeSpan(0, 0, 0, seconds3, 0)).ToLocalTime();
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

	// Token: 0x0600175B RID: 5979 RVA: 0x000506E8 File Offset: 0x0004E8E8
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
				<<EMPTY_NAME>>.WriteByte((byte)this._recoveredType18458060);
				if ((this._recoveredType18458060 & (684.685)1) != (684.685)0)
				{
					int 2 = (int)(this.dateTime2.ToUniversalTime() - new DateTime(1970, 1, 1, 0, 0, 0).ToUniversalTime()).TotalSeconds;
					<<EMPTY_NAME>>._0003_2004_2003_2008_2007_2007_200B_2007_2003_2009_2000_2004_2007_2004_2009_2005_2001_200A_200A_2006_2003(2);
				}
				if ((this._recoveredType18458060 & (684.685)2) != (684.685)0)
				{
					int 3 = (int)(this.dateTime3.ToUniversalTime() - new DateTime(1970, 1, 1, 0, 0, 0).ToUniversalTime()).TotalSeconds;
					<<EMPTY_NAME>>._0003_2004_2003_2008_2007_2007_200B_2007_2003_2009_2000_2004_2007_2004_2009_2005_2001_200A_200A_2006_2003(3);
				}
				if ((this._recoveredType18458060 & (684.685)4) != (684.685)0)
				{
					int 4 = (int)(this.dateTime4.ToUniversalTime() - new DateTime(1970, 1, 1, 0, 0, 0).ToUniversalTime()).TotalSeconds;
					<<EMPTY_NAME>>._0003_2004_2003_2008_2007_2007_200B_2007_2003_2009_2000_2004_2007_2004_2009_2005_2001_200A_200A_2006_2003(4);
				}
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

	// Token: 0x0600175C RID: 5980 RVA: 0x00050818 File Offset: 0x0004EA18
	public static bool Method10299(DateTime 1)
	{
		return 1 >= new DateTime(1901, 12, 13, 20, 45, 52) || 1 <= new DateTime(2038, 1, 19, 3, 14, 7);
	}

	// Token: 0x0600175D RID: 5981 RVA: 0x0005084F File Offset: 0x0004EA4F
	public DateTime GetDateTime8061_10300()
	{
		return this.dateTime2;
	}

	// Token: 0x0600175E RID: 5982 RVA: 0x00050857 File Offset: 0x0004EA57
	public void Method10301(DateTime 1)
	{
		if (!684.Method10299(1))
		{
			throw new ArgumentOutOfRangeException("#=zUkSU2UA=");
		}
		this._recoveredType18458060 |= (684.685)1;
		this.dateTime2 = 1;
	}

	// Token: 0x0600175F RID: 5983 RVA: 0x00050881 File Offset: 0x0004EA81
	public DateTime GetDateTime8062_10302()
	{
		return this.dateTime3;
	}

	// Token: 0x06001760 RID: 5984 RVA: 0x00050889 File Offset: 0x0004EA89
	public void Method10303(DateTime 1)
	{
		if (!684.Method10299(1))
		{
			throw new ArgumentOutOfRangeException("#=zUkSU2UA=");
		}
		this._recoveredType18458060 |= (684.685)2;
		this.dateTime3 = 1;
	}

	// Token: 0x06001761 RID: 5985 RVA: 0x000508B3 File Offset: 0x0004EAB3
	public DateTime GetDateTime8063_10304()
	{
		return this.dateTime4;
	}

	// Token: 0x06001762 RID: 5986 RVA: 0x000508BB File Offset: 0x0004EABB
	public void Method10305(DateTime 1)
	{
		if (!684.Method10299(1))
		{
			throw new ArgumentOutOfRangeException("#=zUkSU2UA=");
		}
		this._recoveredType18458060 |= (684.685)4;
		this.dateTime4 = 1;
	}

	// Token: 0x06001763 RID: 5987 RVA: 0x000508E5 File Offset: 0x0004EAE5
	private 684.685 GetRecoveredType18458060_10306()
	{
		return this._recoveredType18458060;
	}

	// Token: 0x06001764 RID: 5988 RVA: 0x000508ED File Offset: 0x0004EAED
	private void SetRecoveredType18458060_10307(684.685 1)
	{
		this._recoveredType18458060 = 1;
	}

	// Token: 0x04000AE7 RID: 2791
	private 684.685 _recoveredType18458060;

	// Token: 0x04000AE8 RID: 2792
	private DateTime dateTime2 = new DateTime(1970, 1, 1);

	// Token: 0x04000AE9 RID: 2793
	private DateTime dateTime3 = new DateTime(1970, 1, 1);

	// Token: 0x04000AEA RID: 2794
	private DateTime dateTime4 = new DateTime(1970, 1, 1);

	// Token: 0x0200030C RID: 780
	public enum 685 : byte
	{

	}
}
