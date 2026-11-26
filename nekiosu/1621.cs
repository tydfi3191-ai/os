using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

// Token: 0x020009B2 RID: 2482
[ComVisible(false)]
public class 1621 : IDisposable
{
	// Token: 0x0600458C RID: 17804 RVA: 0x001B5CD0 File Offset: 0x001B3ED0
	static 1621()
	{
		897 <<EMPTY_NAME>> = new 897();
		<<EMPTY_NAME>>.SetMaxWorkerThreads(64);
		<<EMPTY_NAME>>.Method9344(true);
		<<EMPTY_NAME>>.SetIdleTimeout(300000);
		1621.threadPool = new 915(<<EMPTY_NAME>>);
		1621.gameLog = 1338.7(1341.Network, true);
		ServicePointManager.Expect100Continue = false;
		ServicePointManager.DefaultConnectionLimit = 12;
		ServicePointManager.CheckCertificateRevocationList = false;
		foreach (SecurityProtocolType securityProtocolType in new int[]
		{
			3072,
			768,
			192
		})
		{
			try
			{
				1621.gameLog.11(string.Format("Attempting to use protocol {0}..", securityProtocolType), (1114)1);
				ServicePointManager.SecurityProtocol = securityProtocolType;
				1621.gameLog.11("Success!", (1114)1);
				break;
			}
			catch
			{
			}
		}
	}

	// Token: 0x0600458D RID: 17805 RVA: 0x001B5DA0 File Offset: 0x001B3FA0
	public 1621(string 1, params object[] 2)
	{
		this.2((2.Length == 0) ? 1 : string.Format(1, 2));
	}

	// Token: 0x0600458E RID: 17806 RVA: 0x001B5E0C File Offset: 0x001B400C
	public string 1()
	{
		return this.url;
	}

	// Token: 0x0600458F RID: 17807 RVA: 0x001B5E14 File Offset: 0x001B4014
	private void 2(string 1)
	{
		if (!1.StartsWith("https://"))
		{
			1 = "https://" + 1.Replace("http://", string.Empty);
		}
		this.url = 1;
	}

	// Token: 0x06004590 RID: 17808 RVA: 0x001B5E46 File Offset: 0x001B4046
	public bool 3()
	{
		return this.isFailedOrAborted;
	}

	// Token: 0x06004591 RID: 17809 RVA: 0x001B5E4E File Offset: 0x001B404E
	private void 4(bool 1)
	{
		this.isFailedOrAborted = 1;
	}

	// Token: 0x06004592 RID: 17810 RVA: 0x001B5E57 File Offset: 0x001B4057
	public bool 5()
	{
		return this.isSucceeded;
	}

	// Token: 0x06004593 RID: 17811 RVA: 0x001B5E5F File Offset: 0x001B405F
	private void 6(bool 1)
	{
		this.isSucceeded = 1;
	}

	// Token: 0x06004594 RID: 17812 RVA: 0x001B5E68 File Offset: 0x001B4068
	public void 7(1621.1623 1)
	{
		1621.1623 2 = this.uploadProgress;
		1621.1623 3;
		do
		{
			3 = 2;
			1621.1623 value = (1621.1623)Delegate.Combine(3, 1);
			2 = Interlocked.CompareExchange<1621.1623>(ref this.uploadProgress, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x06004595 RID: 17813 RVA: 0x001B5EA0 File Offset: 0x001B40A0
	public void 8(1621.1623 1)
	{
		1621.1623 2 = this.downloadProgress;
		1621.1623 3;
		do
		{
			3 = 2;
			1621.1623 value = (1621.1623)Delegate.Combine(3, 1);
			2 = Interlocked.CompareExchange<1621.1623>(ref this.downloadProgress, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x06004596 RID: 17814 RVA: 0x001B5ED8 File Offset: 0x001B40D8
	public void 9(1621.1622 1)
	{
		1621.1622 2 = this.completed;
		1621.1622 3;
		do
		{
			3 = 2;
			1621.1622 value = (1621.1622)Delegate.Combine(3, 1);
			2 = Interlocked.CompareExchange<1621.1622>(ref this.completed, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x06004597 RID: 17815 RVA: 0x001B5F10 File Offset: 0x001B4110
	public void 10(1621.1624 1)
	{
		1621.1624 2 = this.responseReceived;
		1621.1624 3;
		do
		{
			3 = 2;
			1621.1624 value = (1621.1624)Delegate.Combine(3, 1);
			2 = Interlocked.CompareExchange<1621.1624>(ref this.responseReceived, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x06004598 RID: 17816 RVA: 0x001B5F48 File Offset: 0x001B4148
	~1621()
	{
		this.25(false);
	}

	// Token: 0x06004599 RID: 17817 RVA: 0x001B5F78 File Offset: 0x001B4178
	protected virtual HttpWebRequest CreateHttpRequest()
	{
		261.9("HTTP, downloads, telemetry and updates");
		return null;
	}

	// Token: 0x0600459A RID: 17818 RVA: 0x001B5F85 File Offset: 0x001B4185
	private IPEndPoint 11(ServicePoint 1, IPEndPoint 2, int 3)
	{
		this.usedIPv6 |= (2.AddressFamily == AddressFamily.InterNetworkV6);
		return null;
	}

	// Token: 0x0600459B RID: 17819 RVA: 0x001B5F9F File Offset: 0x001B419F
	protected virtual Stream CreateResponseStream()
	{
		return new MemoryStream();
	}

	// Token: 0x0600459C RID: 17820 RVA: 0x001B5FA8 File Offset: 0x001B41A8
	public string 12()
	{
		string result;
		try
		{
			this.responseStream.Seek(0L, SeekOrigin.Begin);
			result = new StreamReader(this.responseStream, Encoding.UTF8).ReadToEnd();
		}
		catch
		{
			result = null;
		}
		return result;
	}

	// Token: 0x0600459D RID: 17821 RVA: 0x001B5FF4 File Offset: 0x001B41F4
	public byte[] 13()
	{
		byte[] result;
		try
		{
			MemoryStream memoryStream = new MemoryStream((int)this.responseStream.Length);
			try
			{
				this.responseStream.Seek(0L, SeekOrigin.Begin);
				this.responseStream.CopyTo(memoryStream);
				result = memoryStream.ToArray();
			}
			finally
			{
				((IDisposable)memoryStream).Dispose();
			}
		}
		catch
		{
			result = null;
		}
		return result;
	}

	// Token: 0x0600459E RID: 17822 RVA: 0x001B6060 File Offset: 0x001B4260
	public void Start()
	{
		this.workItem = 1621.threadPool.Method36622(new Action(this.14), (639)2);
		if (1621.threadPool.GetNumber6512_8339() == 1621.threadPool.GetMaxThreads())
		{
			1621.gameLog.11("WARNING: ThreadPool is saturated!", (1114)3);
		}
	}

	// Token: 0x0600459F RID: 17823 RVA: 0x001B60B0 File Offset: 0x001B42B0
	private void 14()
	{
		if (this.3())
		{
			return;
		}
		if (259.2(this.url))
		{
			this.15();
			return;
		}
		this.4(true);
		WebException <<EMPTY_NAME>> = new WebException("Offline build: network services are disabled.", WebExceptionStatus.RequestCanceled);
		1621.1622 2 = this.completed;
		if (2 != null)
		{
			2(this, <<EMPTY_NAME>>);
		}
		if (!this.keepHandlers)
		{
			this.22();
		}
	}

	// Token: 0x060045A0 RID: 17824 RVA: 0x001B6110 File Offset: 0x001B4310
	private void 15()
	{
		this.description = "beatmap mirror";
		this.lastActivityTicks = DateTime.Now.Ticks;
		try
		{
			this.httpResponse = 259.Get(this.url, this.idleTimeoutMs, delegate(HttpWebRequest 1)
			{
				this.httpRequest = 1;
			});
			1621.1624 <<EMPTY_NAME>> = this.responseReceived;
			if (<<EMPTY_NAME>> != null)
			{
				<<EMPTY_NAME>>(this);
			}
			long contentLength = this.httpResponse.ContentLength;
			this.responseStream = this.CreateResponseStream();
			this.bytesRead = 0;
			this.networkStream = this.httpResponse.GetResponseStream();
			byte[] array = new byte[32768];
			int num;
			while ((num = this.networkStream.Read(array, 0, array.Length)) > 0)
			{
				if (this.3())
				{
					return;
				}
				this.responseStream.Write(array, 0, num);
				this.bytesRead += num;
				this.lastActivityTicks = DateTime.Now.Ticks;
				1621.1623 2 = this.downloadProgress;
				if (2 != null)
				{
					2(this, (long)this.bytesRead, contentLength);
				}
			}
			this.networkStream.Dispose();
			this.networkStream = null;
			this.Finish(null);
		}
		catch (Exception 3)
		{
			if (!this.3())
			{
				this.Finish(3);
			}
		}
	}

	// Token: 0x060045A1 RID: 17825 RVA: 0x001B6258 File Offset: 0x001B4458
	public void 16(Action<HttpWebRequest> 1)
	{
		Action<HttpWebRequest> action = this.requestCustomizers;
		Action<HttpWebRequest> action2;
		do
		{
			action2 = action;
			Action<HttpWebRequest> value = (Action<HttpWebRequest>)Delegate.Combine(action2, 1);
			action = Interlocked.CompareExchange<Action<HttpWebRequest>>(ref this.requestCustomizers, value, action2);
		}
		while (action != action2);
	}

	// Token: 0x060045A2 RID: 17826 RVA: 0x001B628D File Offset: 0x001B448D
	public virtual void RunSynchronously()
	{
		261.9("synchronous network services");
	}

	// Token: 0x060045A3 RID: 17827 RVA: 0x001B629C File Offset: 0x001B449C
	protected virtual void Finish(Exception 1)
	{
		if (this.3())
		{
			return;
		}
		WebException ex = 1 as WebException;
		if (ex != null)
		{
			bool flag = true;
			HttpWebResponse httpWebResponse = ex.Response as HttpWebResponse;
			HttpStatusCode? httpStatusCode = new HttpStatusCode?((httpWebResponse != null) ? httpWebResponse.StatusCode : HttpStatusCode.RequestTimeout);
			if (httpStatusCode != null)
			{
				HttpStatusCode valueOrDefault = httpStatusCode.GetValueOrDefault();
				if (valueOrDefault - HttpStatusCode.Forbidden > 2)
				{
					if (valueOrDefault == HttpStatusCode.RequestTimeout && this.24())
					{
						1 = new WebException(string.Format("Timeout to {0} ({1}) after {2} seconds idle (read {3} bytes).", new object[]
						{
							this.1(),
							this.description,
							this.23() / 1000L,
							this.bytesRead
						}), WebExceptionStatus.Timeout);
					}
				}
				else
				{
					flag = false;
				}
			}
			if (flag)
			{
				int num = this.retriesLeft;
				this.retriesLeft = num - 1;
				if (num > 0 && this.bytesRead == 0)
				{
					1621.gameLog.11(string.Format("Request to {0} ({1}) failed with {2} (retrying {3}/{4}).", new object[]
					{
						this.1(),
						this.description,
						httpStatusCode,
						2 - this.retriesLeft,
						2
					}), (1114)1);
					this.14();
					return;
				}
			}
			if (1621.usingFallbackPath == null && flag && this.usedIPv6)
			{
				1621.usingFallbackPath = new bool?(true);
				1621.gameLog.11("---------------------- USING FALLBACK PATH! ---------------------", (1114)1);
			}
			1621.gameLog.11(string.Format("Request to {0} ({1}) failed with {2} (FAILED).", this.1(), this.description, httpStatusCode), (1114)1);
		}
		else if (1 == null)
		{
			if (1621.usingFallbackPath == null)
			{
				1621.usingFallbackPath = new bool?(false);
			}
			1621.gameLog.11(string.Concat(new string[]
			{
				"Request to ",
				this.1(),
				" (",
				this.description,
				") successfully completed!"
			}), (1114)1);
		}
		HttpWebResponse httpWebResponse2 = this.httpResponse;
		if (httpWebResponse2 != null)
		{
			httpWebResponse2.Close();
		}
		1621.1622 2 = this.completed;
		if (2 != null)
		{
			2(this, 1);
		}
		if (!this.keepHandlers)
		{
			this.22();
		}
		if (1 != null)
		{
			this.4(true);
			return;
		}
		this.6(true);
	}

	// Token: 0x060045A4 RID: 17828 RVA: 0x001B64D4 File Offset: 0x001B46D4
	private void 17()
	{
		try
		{
			HttpWebRequest httpWebRequest = this.httpRequest;
			if (httpWebRequest != null)
			{
				httpWebRequest.Abort();
			}
			HttpWebResponse httpWebResponse = this.httpResponse;
			if (httpWebResponse != null)
			{
				httpWebResponse.Close();
			}
		}
		catch
		{
		}
	}

	// Token: 0x060045A5 RID: 17829 RVA: 0x001B6518 File Offset: 0x001B4718
	public void 18()
	{
		if (!this.3())
		{
			this.4(true);
			this.17();
			373 <<EMPTY_NAME>> = this.workItem;
			if (<<EMPTY_NAME>> != null)
			{
				<<EMPTY_NAME>>.Method134352();
			}
			this.workItem = null;
			if (!this.keepHandlers)
			{
				this.22();
			}
		}
	}

	// Token: 0x060045A6 RID: 17830 RVA: 0x001B6556 File Offset: 0x001B4756
	public void 19(byte[] 1)
	{
		this.requestBody.Write(1, 0, 1.Length);
	}

	// Token: 0x060045A7 RID: 17831 RVA: 0x001B6568 File Offset: 0x001B4768
	public void 20(string 1, byte[] 2)
	{
		this.files.Add(1, 2);
	}

	// Token: 0x060045A8 RID: 17832 RVA: 0x001B6577 File Offset: 0x001B4777
	public void 21(string 1, string 2)
	{
		this.formFields.Add(1, 2);
	}

	// Token: 0x060045A9 RID: 17833 RVA: 0x001B6588 File Offset: 0x001B4788
	private void 22()
	{
		this.uploadProgress = null;
		this.downloadProgress = null;
		this.completed = null;
		this.responseReceived = null;
		try
		{
			HttpWebRequest httpWebRequest = this.httpRequest;
			if (((httpWebRequest != null) ? httpWebRequest.ServicePoint.BindIPEndPointDelegate : null) != null)
			{
				ServicePoint servicePoint = this.httpRequest.ServicePoint;
				servicePoint.BindIPEndPointDelegate = (BindIPEndPoint)Delegate.Remove(servicePoint.BindIPEndPointDelegate, new BindIPEndPoint(this.11));
			}
		}
		catch
		{
		}
	}

	// Token: 0x060045AA RID: 17834 RVA: 0x001B660C File Offset: 0x001B480C
	private long 23()
	{
		return (DateTime.Now.Ticks - this.lastActivityTicks) / 10000L;
	}

	// Token: 0x060045AB RID: 17835 RVA: 0x001B6634 File Offset: 0x001B4834
	private bool 24()
	{
		return this.23() > (long)this.idleTimeoutMs;
	}

	// Token: 0x060045AC RID: 17836 RVA: 0x001B6648 File Offset: 0x001B4848
	protected void 25(bool 1)
	{
		if (!this.isDisposed)
		{
			this.isDisposed = true;
			if (!(this.responseStream is MemoryStream))
			{
				Stream stream = this.responseStream;
				if (stream != null)
				{
					stream.Dispose();
				}
			}
			Stream stream2 = this.networkStream;
			if (stream2 != null)
			{
				stream2.Dispose();
			}
			HttpWebResponse httpWebResponse = this.httpResponse;
			if (httpWebResponse != null)
			{
				httpWebResponse.Close();
			}
			this.22();
		}
	}

	// Token: 0x060045AD RID: 17837 RVA: 0x001B66AA File Offset: 0x001B48AA
	public void Dispose()
	{
		this.25(true);
		GC.SuppressFinalize(this);
	}

	// Token: 0x060045AE RID: 17838 RVA: 0x001B66BC File Offset: 0x001B48BC
	public void 26(int 1)
	{
		this.maxRetries = 1;
		this.retriesLeft = 1;
	}

	// Token: 0x040032EA RID: 13034
	private string url;

	// Token: 0x040032EB RID: 13035
	private bool isFailedOrAborted;

	// Token: 0x040032EC RID: 13036
	private bool isSucceeded;

	// Token: 0x040032ED RID: 13037
	private 1621.1623 uploadProgress;

	// Token: 0x040032EE RID: 13038
	private 1621.1623 downloadProgress;

	// Token: 0x040032EF RID: 13039
	private 1621.1622 completed;

	// Token: 0x040032F0 RID: 13040
	private 1621.1624 responseReceived;

	// Token: 0x040032F1 RID: 13041
	public bool keepHandlers;

	// Token: 0x040032F2 RID: 13042
	public bool isUpdateDownload;

	// Token: 0x040032F3 RID: 13043
	public Dictionary<string, string> formFields = new Dictionary<string, string>();

	// Token: 0x040032F4 RID: 13044
	public Dictionary<string, byte[]> files = new Dictionary<string, byte[]>();

	// Token: 0x040032F5 RID: 13045
	public Dictionary<string, string> extraHeaders = new Dictionary<string, string>();

	// Token: 0x040032F6 RID: 13046
	public int idleTimeoutMs = 16384;

	// Token: 0x040032F7 RID: 13047
	private static 1338 gameLog;

	// Token: 0x040032F8 RID: 13048
	private static 915 threadPool;

	// Token: 0x040032F9 RID: 13049
	private 373 workItem;

	// Token: 0x040032FA RID: 13050
	private string description;

	// Token: 0x040032FB RID: 13051
	private HttpWebRequest httpRequest;

	// Token: 0x040032FC RID: 13052
	private HttpWebResponse httpResponse;

	// Token: 0x040032FD RID: 13053
	private Stream networkStream;

	// Token: 0x040032FE RID: 13054
	private static AddressFamily? preferredAddressFamily = new AddressFamily?(AddressFamily.InterNetwork);

	// Token: 0x040032FF RID: 13055
	public static bool httpCompatibilityMode = false;

	// Token: 0x04003300 RID: 13056
	private static bool? usingFallbackPath;

	// Token: 0x04003301 RID: 13057
	private bool usedIPv6;

	// Token: 0x04003302 RID: 13058
	private int bytesRead;

	// Token: 0x04003303 RID: 13059
	private readonly MemoryStream requestBody = new MemoryStream();

	// Token: 0x04003304 RID: 13060
	public Stream responseStream;

	// Token: 0x04003305 RID: 13061
	private Action<HttpWebRequest> requestCustomizers;

	// Token: 0x04003306 RID: 13062
	private long lastActivityTicks;

	// Token: 0x04003307 RID: 13063
	private bool isDisposed;

	// Token: 0x04003308 RID: 13064
	private int maxRetries = 2;

	// Token: 0x04003309 RID: 13065
	private int retriesLeft = 2;

	// Token: 0x0400330A RID: 13066
	public static bool hasInvalidCertificate;

	// Token: 0x020009B3 RID: 2483
	// (Invoke) Token: 0x060045B1 RID: 17841
	public delegate void 1623(1621 1, long 2, long 3);

	// Token: 0x020009B4 RID: 2484
	// (Invoke) Token: 0x060045B5 RID: 17845
	public delegate void 1622(1621 1, Exception 2);

	// Token: 0x020009B5 RID: 2485
	// (Invoke) Token: 0x060045B9 RID: 17849
	public delegate void 1624(1621 1);
}
