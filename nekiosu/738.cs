using System;
using System.Globalization;

// Token: 0x020001B0 RID: 432
[241(0)]
[242(1)]
public sealed class 738 : 548
{
	// Token: 0x06000DE1 RID: 3553 RVA: 0x0002F994 File Offset: 0x0002DB94
	private 805<string, object> Method11691(object 1)
	{
		159 2 = 1 as 159;
		if (2 == null)
		{
			366 3 = 1 as 366;
			if (3 == null)
			{
				throw new 134("The DefaultReferenceResolver can only be used internally.");
			}
			2 = 3.Method1809();
		}
		return 2.Method4116();
	}

	// Token: 0x06000DE2 RID: 3554 RVA: 0x0002F9CC File Offset: 0x0002DBCC
	public object Method11692(object 1, string 2)
	{
		object result;
		this.Method11691(1).Method13500(2, out result);
		return result;
	}

	// Token: 0x06000DE3 RID: 3555 RVA: 0x0002F9EC File Offset: 0x0002DBEC
	public string Method11693(object 1, object 2)
	{
		805<string, object> 3 = this.Method11691(1);
		string text;
		if (!3.Method13501(2, out text))
		{
			this.number++;
			text = this.number.ToString(CultureInfo.InvariantCulture);
			3.Method13499(text, 2);
		}
		return text;
	}

	// Token: 0x06000DE4 RID: 3556 RVA: 0x0002FA34 File Offset: 0x0002DC34
	public void Method11694(object 1, string 2, object 3)
	{
		this.Method11691(1).Method13499(2, 3);
	}

	// Token: 0x06000DE5 RID: 3557 RVA: 0x0002FA44 File Offset: 0x0002DC44
	public bool Method11695(object 1, object 2)
	{
		string text;
		return this.Method11691(1).Method13501(2, out text);
	}

	// Token: 0x040006D2 RID: 1746
	private int number;
}
