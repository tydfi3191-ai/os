using System;
using System.Collections.Generic;

// Token: 0x02000589 RID: 1417
public class 2278 : MarshalByRefObject
{
	// Token: 0x06002BCD RID: 11213 RVA: 0x000EFD4E File Offset: 0x000EDF4E
	public 2278(2341 1, string 2) : this(-1, 1, 2, 0, null)
	{
	}

	// Token: 0x06002BCE RID: 11214 RVA: 0x000EFD5C File Offset: 0x000EDF5C
	public 2278(int 1, 2341 2, string 3, int 4, 2340 5)
	{
		this.3 = 1;
		this.2 = 2;
		this.1 = 3;
		this.4 = "http://osu.offline.invalid/web/osu-gethelp.php?p=" + 4.ToString();
		this.6 = 5;
	}

	// Token: 0x06002BCF RID: 11215 RVA: 0x00005ADD File Offset: 0x00003CDD
	public virtual void _0008_200A_200B_2000_2005_200B_200B_2000_2000_200B_200B_2002_2008_200B()
	{
	}

	// Token: 0x06002BD0 RID: 11216 RVA: 0x000EFDAE File Offset: 0x000EDFAE
	public bool _0002_2002_2003_2006_200A_2006_2002_200B_2008_2007_2004_200A_2000_2004_2008_2006_2004_2004()
	{
		return this.6 != null && this.6();
	}

	// Token: 0x0400200F RID: 8207
	public readonly string 1;

	// Token: 0x04002010 RID: 8208
	public readonly 2341 2;

	// Token: 0x04002011 RID: 8209
	public int 3;

	// Token: 0x04002012 RID: 8210
	public readonly string 4;

	// Token: 0x04002013 RID: 8211
	public readonly List<2036> 5 = new List<2036>();

	// Token: 0x04002014 RID: 8212
	public readonly 2340 6;
}
