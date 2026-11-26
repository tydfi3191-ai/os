using System;
using System.Security;

// Token: 0x02000977 RID: 2423
public sealed class 1644
{
	// Token: 0x0600441C RID: 17436 RVA: 0x001AD1BC File Offset: 0x001AB3BC
	public 1644(string 1, bool 2 = false)
	{
		if (2)
		{
			string value;
			1 = 1614.5(1, "cu24180ncjeiu0ci1nwui", out value);
			Enum.TryParse<1643>(value, out this.2);
		}
		else
		{
			this.2 = 1643.Raw;
		}
		foreach (char c in 1)
		{
			this.1.AppendChar(c);
		}
		this.1.MakeReadOnly();
		1338.2(this.1(1643.Hashed));
	}

	// Token: 0x0600441D RID: 17437 RVA: 0x001AD240 File Offset: 0x001AB440
	internal string 1(1643 1)
	{
		if (1 == 1643.Raw)
		{
			throw new Exception("Raw password not available!");
		}
		if (1 == 1643.Encrypted)
		{
			return 1614.3((1614.1617)1, this.1.ToUnsecureString(), "cu24180ncjeiu0ci1nwui", this.2.ToString());
		}
		if (this.2 != 1643.Hashed)
		{
			return 1209.2(this.1);
		}
		return this.1.ToUnsecureString();
	}

	// Token: 0x040031F9 RID: 12793
	private readonly SecureString 1 = new SecureString();

	// Token: 0x040031FA RID: 12794
	private readonly 1643 2;
}
