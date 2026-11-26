using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;

// Token: 0x02000978 RID: 2424
[ComVisible(false)]
public sealed class 1650 : 2668
{
	// Token: 0x0600441E RID: 17438 RVA: 0x001AD2AC File Offset: 0x001AB4AC
	internal void Download(bool 1)
	{
		1650.1652 2 = new 1650.1652();
		2.1 = this;
		2.2 = 1;
		this.isDownloading = true;
		this.progress = 0f;
		this.bytesReceived = 0;
		this.isPatching = false;
		if (2.2 && this.url_patch == null)
		{
			throw new Exception("patch not available for this file!");
		}
		string text = "_staging/" + this.filename + (2.2 ? "_patch" : ".zip");
		this.request = new 1620(text, 2.2 ? this.url_patch : (this.url_full + ".zip"));
		this.request.isUpdateDownload = true;
		this.request.8(new 1621.1623(2.1));
		try
		{
			this.request.RunSynchronously();
			if (this.request.3())
			{
				this.isDownloading = false;
			}
			else if (!File.Exists(text))
			{
				throw new Exception("couldn't find downloaded file (" + text + ")");
			}
		}
		catch (ThreadAbortException)
		{
			this.isDownloading = false;
			return;
		}
		if (this.request.filePath.EndsWith(".zip"))
		{
			new 87().Method5857(text, "_staging", ".*");
			2672.20(text);
		}
		if (!2.2)
		{
			return;
		}
		string text2 = "_staging/" + this.filename;
		string text3 = "_staging/" + this.filename + "_patched";
		try
		{
			this.isPatching = true;
			355 3 = new 355();
			3.Method1455(new 798(2.2));
			3.Method1458(text2, text3, text, (410)1);
		}
		finally
		{
			2672.20(text);
			2672.20(text2);
			if (File.Exists(text3))
			{
				2672.16(text3, text2, true);
			}
			this.isPatching = false;
		}
		this.isDownloading = false;
	}

	// Token: 0x0600441F RID: 17439 RVA: 0x001AD4A0 File Offset: 0x001AB6A0
	internal void Start(1189 1, 1189 2)
	{
		1650.1651 downloadAttempts = new 1650.1651();
		downloadAttempts.1 = this;
		downloadAttempts.2 = 1;
		downloadAttempts.3 = 2;
		if (1650.useBackgroundThread)
		{
			this.thread = new Thread(delegate()
			{
				int num = 0;
				for (;;)
				{
					try
					{
						downloadAttempts.1.Download(false);
						if (downloadAttempts.2 != null)
						{
							downloadAttempts.2();
						}
					}
					catch (ThreadAbortException)
					{
						downloadAttempts.1.Cancel();
					}
					catch (Exception error)
					{
						if (++num < 4)
						{
							if (num > 1)
							{
								string oldValue = "m" + (num - 1).ToString() + ".";
								string newValue = "m" + num.ToString() + ".";
								if (!string.IsNullOrEmpty(downloadAttempts.1.url_full))
								{
									downloadAttempts.1.url_full = downloadAttempts.1.url_full.Replace(oldValue, newValue);
								}
								if (!string.IsNullOrEmpty(downloadAttempts.1.url_patch))
								{
									downloadAttempts.1.url_patch = downloadAttempts.1.url_patch.Replace(oldValue, newValue);
								}
							}
							Thread.Sleep(1500);
							continue;
						}
						1336.8 = (downloadAttempts.1.url_patch ?? downloadAttempts.1.url_full);
						downloadAttempts.1.Error = error;
						if (downloadAttempts.3 != null)
						{
							downloadAttempts.3();
						}
					}
					break;
				}
			});
			this.thread.IsBackground = true;
			this.thread.Start();
			return;
		}
		downloadAttempts.1();
	}

	// Token: 0x06004420 RID: 17440 RVA: 0x001AD523 File Offset: 0x001AB723
	internal void Cancel()
	{
		if (this.thread != null)
		{
			this.thread.Abort();
			this.thread = null;
		}
		if (this.request != null)
		{
			this.request.18();
		}
	}

	// Token: 0x06004421 RID: 17441 RVA: 0x001AD552 File Offset: 0x001AB752
	public override string ToString()
	{
		return this.filename;
	}

	// Token: 0x040031FB RID: 12795
	internal 1620 request;

	// Token: 0x040031FC RID: 12796
	internal float progress;

	// Token: 0x040031FD RID: 12797
	internal bool isPatching;

	// Token: 0x040031FE RID: 12798
	internal bool isDownloading;

	// Token: 0x040031FF RID: 12799
	private int bytesReceived;

	// Token: 0x04003200 RID: 12800
	public Exception Error;

	// Token: 0x04003201 RID: 12801
	public static bool useBackgroundThread = true;

	// Token: 0x04003202 RID: 12802
	private Thread thread;

	// Token: 0x02000979 RID: 2425
	public sealed class 1651
	{
		// Token: 0x06004424 RID: 17444 RVA: 0x001AD56C File Offset: 0x001AB76C
		internal void 1()
		{
			int num = 0;
			for (;;)
			{
				try
				{
					this.1.Download(false);
					if (this.2 != null)
					{
						this.2();
					}
				}
				catch (ThreadAbortException)
				{
					this.1.Cancel();
				}
				catch (Exception error)
				{
					if (++num < 4)
					{
						if (num > 1)
						{
							string oldValue = "m" + (num - 1).ToString() + ".";
							string newValue = "m" + num.ToString() + ".";
							if (!string.IsNullOrEmpty(this.1.url_full))
							{
								this.1.url_full = this.1.url_full.Replace(oldValue, newValue);
							}
							if (!string.IsNullOrEmpty(this.1.url_patch))
							{
								this.1.url_patch = this.1.url_patch.Replace(oldValue, newValue);
							}
						}
						Thread.Sleep(1500);
						continue;
					}
					1336.8 = (this.1.url_patch ?? this.1.url_full);
					this.1.Error = error;
					if (this.3 != null)
					{
						this.3();
					}
				}
				break;
			}
		}

		// Token: 0x04003203 RID: 12803
		public 1650 1;

		// Token: 0x04003204 RID: 12804
		public 1189 2;

		// Token: 0x04003205 RID: 12805
		public 1189 3;
	}

	// Token: 0x0200097A RID: 2426
	public sealed class 1652
	{
		// Token: 0x06004426 RID: 17446 RVA: 0x001AD6C0 File Offset: 0x001AB8C0
		internal void 1(1621 1, long 2, long 3)
		{
			this.1.progress = (float)2 / (float)3 * (float)(this.2 ? 50 : 100);
			this.1.bytesReceived = (int)2;
			this.1.filesize = (int)3;
		}

		// Token: 0x06004427 RID: 17447 RVA: 0x001AD6FC File Offset: 0x001AB8FC
		internal void 2(object 1, long 2, long 3)
		{
			this.1.progress = 50f + (float)2 / (float)3 * 50f;
		}

		// Token: 0x04003206 RID: 12806
		public 1650 1;

		// Token: 0x04003207 RID: 12807
		public bool 2;
	}
}
