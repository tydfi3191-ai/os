using System;
using System.Net;

// Token: 0x020009B9 RID: 2489
public sealed class 1628 : 1621
{
	// Token: 0x060045CA RID: 17866 RVA: 0x001B6780 File Offset: 0x001B4980
	public 1628(string 1, string 2, string 3, bool 4) : base(1296.6 + "/users", Array.Empty<object>())
	{
		base.21("user[username]", 1);
		base.21("user[user_email]", 2);
		base.21("user[password]", 3);
		base.21("check", 4 ? "1" : "0");
	}

	// Token: 0x060045CB RID: 17867 RVA: 0x001B67E6 File Offset: 0x001B49E6
	protected override HttpWebRequest CreateHttpRequest()
	{
		HttpWebRequest httpWebRequest = base.CreateHttpRequest();
		httpWebRequest.Accept = "application/json";
		return httpWebRequest;
	}
}
