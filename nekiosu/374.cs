using System;
using System.IO;
using System.Runtime.InteropServices;

// Token: 0x020002DF RID: 735
[ComVisible(false)]
public class 374 : 495
{
	// Token: 0x0600160F RID: 5647 RVA: 0x0004C3F3 File Offset: 0x0004A5F3
	public 374(string 1)
	{
		this._recoveredType02811323 = new 357(1);
	}

	// Token: 0x06001610 RID: 5648 RVA: 0x0004C408 File Offset: 0x0004A608
	public virtual bool Method11363(string 1)
	{
		bool result = false;
		if (1 != null)
		{
			string 2 = (1.Length > 0) ? Path.GetFullPath(1) : string.Empty;
			result = this._recoveredType02811323.Method11363(2);
		}
		return result;
	}

	// Token: 0x04000A6C RID: 2668
	private 357 _recoveredType02811323;
}
