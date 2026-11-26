using System;
using System.Collections;
using System.IO;
using System.Runtime.InteropServices;

// Token: 0x020002D2 RID: 722
[ComVisible(false)]
public sealed class 87
{
	// Token: 0x06001587 RID: 5511 RVA: 0x0004A1E0 File Offset: 0x000483E0
	public 87()
	{
	}

	// Token: 0x06001588 RID: 5512 RVA: 0x0004A1FA File Offset: 0x000483FA
	public 87(740 1)
	{
		this.events = 1;
	}

	// Token: 0x06001589 RID: 5513 RVA: 0x0004A21B File Offset: 0x0004841B
	public bool GetCreateEmptyDirectories()
	{
		return this.createEmptyDirectories;
	}

	// Token: 0x0600158A RID: 5514 RVA: 0x0004A223 File Offset: 0x00048423
	public void SetCreateEmptyDirectories(bool 1)
	{
		this.createEmptyDirectories = 1;
	}

	// Token: 0x0600158B RID: 5515 RVA: 0x0004A22C File Offset: 0x0004842C
	public string GetPassword()
	{
		return this.password;
	}

	// Token: 0x0600158C RID: 5516 RVA: 0x0004A234 File Offset: 0x00048434
	public void SetPassword(string 1)
	{
		this.password = 1;
	}

	// Token: 0x0600158D RID: 5517 RVA: 0x0004A23D File Offset: 0x0004843D
	public 381 GetNameTransform()
	{
		return this.entryFactory.GetRecoveredType03711143_1668();
	}

	// Token: 0x0600158E RID: 5518 RVA: 0x0004A24A File Offset: 0x0004844A
	public void SetNameTransform(381 1)
	{
		this.entryFactory.Method1669(1);
	}

	// Token: 0x0600158F RID: 5519 RVA: 0x0004A258 File Offset: 0x00048458
	public 681 GetEntryFactory()
	{
		return this.entryFactory;
	}

	// Token: 0x06001590 RID: 5520 RVA: 0x0004A260 File Offset: 0x00048460
	public void SetEntryFactory(681 1)
	{
		if (1 == null)
		{
			this.entryFactory = new 362();
			return;
		}
		this.entryFactory = 1;
	}

	// Token: 0x06001591 RID: 5521 RVA: 0x0004A278 File Offset: 0x00048478
	public 609 GetUseZip64()
	{
		return this.useZip64;
	}

	// Token: 0x06001592 RID: 5522 RVA: 0x0004A280 File Offset: 0x00048480
	public void SetUseZip64(609 1)
	{
		this.useZip64 = 1;
	}

	// Token: 0x06001593 RID: 5523 RVA: 0x0004A289 File Offset: 0x00048489
	public bool GetRestoreDateTimeOnExtract()
	{
		return this.restoreDateTimeOnExtract;
	}

	// Token: 0x06001594 RID: 5524 RVA: 0x0004A291 File Offset: 0x00048491
	public void SetRestoreDateTimeOnExtract(bool 1)
	{
		this.restoreDateTimeOnExtract = 1;
	}

	// Token: 0x06001595 RID: 5525 RVA: 0x0004A29A File Offset: 0x0004849A
	public bool GetRestoreAttributesOnExtract()
	{
		return this.restoreAttributesOnExtract;
	}

	// Token: 0x06001596 RID: 5526 RVA: 0x0004A2A2 File Offset: 0x000484A2
	public void SetRestoreAttributesOnExtract(bool 1)
	{
		this.restoreAttributesOnExtract = 1;
	}

	// Token: 0x06001597 RID: 5527 RVA: 0x0004A2AB File Offset: 0x000484AB
	public void Method5854(string 1, string 2, bool 3, string 4, string 5)
	{
		this.Method5854(File.Create(1), 2, 3, 4, 5);
	}

	// Token: 0x06001598 RID: 5528 RVA: 0x0004A2BF File Offset: 0x000484BF
	public void Method5854(string 1, string 2, bool 3, string 4)
	{
		this.Method5854(File.Create(1), 2, 3, 4, null);
	}

	// Token: 0x06001599 RID: 5529 RVA: 0x0004A2D4 File Offset: 0x000484D4
	public void Method5854(Stream 1, string 2, bool 3, string 4, string 5)
	{
		this.SetNameTransform(new 686(2));
		this.sourceDirectory = 2;
		using (this.zipOutputStream = new 987(1))
		{
			if (this.password != null)
			{
				this.zipOutputStream._000F_200B_2004_2005_2008_2005_2003_2000_2003_200A_2007_2002_2005_2006_2002_2005_2008_2002_2009_2000_200A_2006_2009_2004(this.password);
			}
			this.zipOutputStream._0002_2003_2006_2000_200B_200B_2000_2006_200B_2000_2006(this.GetUseZip64());
			92 7 = new 92(4, 5);
			7.processFile = (487)Delegate.Combine(7.processFile, new 487(this.ProcessFile));
			if (this.GetCreateEmptyDirectories())
			{
				7.processDirectory = (444)Delegate.Combine(7.processDirectory, new 444(this.ProcessDirectory));
			}
			if (this.events != null)
			{
				if (this.events._recoveredType20139320 != null)
				{
					7.fileFailure = (719)Delegate.Combine(7.fileFailure, this.events._recoveredType20139320);
				}
				if (this.events._recoveredType09649319 != null)
				{
					7.directoryFailure = (496)Delegate.Combine(7.directoryFailure, this.events._recoveredType09649319);
				}
			}
			7.Scan(2, 3);
		}
	}

	// Token: 0x0600159A RID: 5530 RVA: 0x0004A40C File Offset: 0x0004860C
	public void Method5857(string 1, string 2, string 3)
	{
		this.Method5857(1, 2, (87.89)2, null, 3, null, this.restoreDateTimeOnExtract);
	}

	// Token: 0x0600159B RID: 5531 RVA: 0x0004A420 File Offset: 0x00048620
	public void Method5857(string 1, string 2, 87.89 3, 87.88 4, string 5, string 6, bool 7)
	{
		Stream 8 = File.Open(1, FileMode.Open, FileAccess.Read, FileShare.Read);
		this.Method5857(8, 2, 3, 4, 5, 6, 7, true);
	}

	// Token: 0x0600159C RID: 5532 RVA: 0x0004A44C File Offset: 0x0004864C
	public void Method5857(Stream 1, string 2, 87.89 3, 87.88 4, string 5, string 6, bool 7, bool 8)
	{
		if (3 == (87.89)0 && 4 == null)
		{
			throw new ArgumentNullException("confirmDelegate");
		}
		this.targetDirectory = 2;
		this.continueRunning = true;
		this.overwriteMode = 3;
		this.confirmDelegate = 4;
		this.extractNameTransform = new 626(2);
		this.fileFilter = new 357(5);
		this.directoryFilter = new 357(6);
		this.restoreDateTimeOnExtract = 7;
		using (this.zipFile = new 905(1))
		{
			if (this.password != null)
			{
				this.zipFile.SetPassword(this.password);
			}
			this.zipFile.SetIsStreamOwner(8);
			IEnumerator enumerator = this.zipFile.GetEnumerator();
			while (this.continueRunning && enumerator.MoveNext())
			{
				783 10 = (783)enumerator.Current;
				if (10.Method12824())
				{
					if (this.directoryFilter.Method11363(Path.GetDirectoryName(10.GetText9996_12802())) && this.fileFilter.Method11363(10.GetText9996_12802()))
					{
						this.ExtractEntry(10);
					}
				}
				else if (10.Method12823() && this.directoryFilter.Method11363(10.GetText9996_12802()) && this.GetCreateEmptyDirectories())
				{
					this.ExtractEntry(10);
				}
			}
		}
	}

	// Token: 0x0600159D RID: 5533 RVA: 0x0004A59C File Offset: 0x0004879C
	private void ProcessDirectory(object 1, 565 2)
	{
		if (!2.GetFlag6029_7765() && this.GetCreateEmptyDirectories())
		{
			if (this.events != null)
			{
				this.events.Method11829(2.GetText9562_12245(), 2.GetFlag6029_7765());
			}
			if (2.GetFlag9563_12246() && 2.GetText9562_12245() != this.sourceDirectory)
			{
				783 3 = this.entryFactory.Method16832(2.GetText9562_12245());
				this.zipOutputStream._0003_2001_2009_2004_2006_2007_2000_2005_2008_2005_2001_2007_2002_2000_2005_2006_2008_2005_2004_2002_2004_2001_2005_2007_2007(3);
			}
		}
	}

	// Token: 0x0600159E RID: 5534 RVA: 0x0004A614 File Offset: 0x00048814
	private void ProcessFile(object 1, 759 2)
	{
		if (this.events != null && this.events._recoveredType08789316 != null)
		{
			this.events._recoveredType08789316(1, 2);
		}
		if (!2.GetFlag9563_12246())
		{
			return;
		}
		try
		{
			using (FileStream fileStream = File.Open(2.GetText9562_12245(), FileMode.Open, FileAccess.Read, FileShare.Read))
			{
				783 3 = this.entryFactory.Method16802(2.GetText9562_12245());
				this.zipOutputStream._0003_2001_2009_2004_2006_2007_2000_2005_2008_2005_2001_2007_2002_2000_2005_2006_2008_2005_2004_2002_2004_2001_2005_2007_2007(3);
				this.WriteEntryData(2.GetText9562_12245(), fileStream);
			}
		}
		catch (Exception 4)
		{
			if (this.events == null)
			{
				this.continueRunning = false;
				throw;
			}
			this.continueRunning = this.events.Method11826(2.GetText9562_12245(), 4);
		}
	}

	// Token: 0x0600159F RID: 5535 RVA: 0x0004A6E4 File Offset: 0x000488E4
	private void WriteEntryData(string 1, Stream 2)
	{
		if (2 == null)
		{
			throw new ArgumentNullException("#=zls9YYyc=");
		}
		if (this.copyBuffer == null)
		{
			this.copyBuffer = new byte[4096];
		}
		if (this.events != null && this.events._recoveredType03709317 != null)
		{
			402.Method2548(2, this.zipOutputStream, this.copyBuffer, this.events._recoveredType03709317, this.events.GetTimeSpan9321_11830(), this, 1);
		}
		else
		{
			402.Method2548(2, this.zipOutputStream, this.copyBuffer);
		}
		if (this.events != null)
		{
			this.continueRunning = this.events.Method11828(1);
		}
	}

	// Token: 0x060015A0 RID: 5536 RVA: 0x0004A784 File Offset: 0x00048984
	private void ExtractFileEntry(783 1, string 2)
	{
		bool flag = true;
		if (this.overwriteMode != (87.89)2 && File.Exists(2))
		{
			flag = (this.overwriteMode == (87.89)0 && this.confirmDelegate != null && this.confirmDelegate(2));
		}
		if (!flag)
		{
			return;
		}
		if (this.events != null)
		{
			this.continueRunning = this.events.Method11827(1.GetText9996_12802());
		}
		if (!this.continueRunning)
		{
			return;
		}
		try
		{
			using (FileStream fileStream = File.Create(2))
			{
				if (this.copyBuffer == null)
				{
					this.copyBuffer = new byte[4096];
				}
				if (this.events != null && this.events._recoveredType03709317 != null)
				{
					402.Method2548(this.zipFile.Method13289(1), fileStream, this.copyBuffer, this.events._recoveredType03709317, this.events.GetTimeSpan9321_11830(), this, 1.GetText9996_12802(), 1.Method12803());
				}
				else
				{
					402.Method2548(this.zipFile.Method13289(1), fileStream, this.copyBuffer);
				}
				if (this.events != null)
				{
					this.continueRunning = this.events.Method11828(1.GetText9996_12802());
				}
			}
			if (this.restoreDateTimeOnExtract)
			{
				File.SetLastWriteTime(2, 1.Method12800());
			}
			if (this.GetRestoreAttributesOnExtract() && 1.Method12788() && 1.Method12785() != -1)
			{
				FileAttributes fileAttributes = (FileAttributes)1.Method12785();
				fileAttributes &= (FileAttributes.ReadOnly | FileAttributes.Hidden | FileAttributes.Archive | FileAttributes.Normal);
				File.SetAttributes(2, fileAttributes);
			}
		}
		catch (Exception 3)
		{
			if (this.events == null)
			{
				this.continueRunning = false;
				throw;
			}
			this.continueRunning = this.events.Method11826(2, 3);
		}
	}

	// Token: 0x060015A1 RID: 5537 RVA: 0x0004A930 File Offset: 0x00048B30
	private void ExtractEntry(783 1)
	{
		bool flag = 1.Method12825();
		string text = 1.GetText9996_12802();
		if (flag)
		{
			try
			{
				if (1.Method12824())
				{
					text = this.extractNameTransform.Method10309(text);
				}
				else if (1.Method12823())
				{
					text = this.extractNameTransform.Method10308(text);
				}
				flag = (text != null && text.Length != 0 && !text.Contains("..\\") && !text.Contains("../"));
				if (!Path.GetFullPath(text).Contains(Path.GetFullPath(this.targetDirectory)))
				{
					flag = false;
				}
			}
			catch (Exception 2)
			{
				this.HandleFailure(1, text, 2);
				flag = false;
			}
		}
		string path = null;
		if (flag)
		{
			path = ((!1.Method12823()) ? Path.GetDirectoryName(Path.GetFullPath(text)) : text);
		}
		if (flag && !Directory.Exists(path) && (!1.Method12823() || this.GetCreateEmptyDirectories()))
		{
			try
			{
				Directory.CreateDirectory(path);
			}
			catch (Exception 3)
			{
				flag = false;
				if (!this.HandleFailure(1, text, 3))
				{
					this.continueRunning = false;
					throw;
				}
			}
		}
		if (flag && 1.Method12824())
		{
			this.ExtractFileEntry(1, text);
		}
	}

	// Token: 0x060015A2 RID: 5538 RVA: 0x0004AA60 File Offset: 0x00048C60
	private bool HandleFailure(783 1, string 2, Exception 3)
	{
		if (this.events == null)
		{
			return false;
		}
		if (1.Method12824())
		{
			this.continueRunning = this.events.Method11826(2, 3);
		}
		else if (1.Method12823())
		{
			this.continueRunning = this.events.Method11825(2, 3);
		}
		return true;
	}

	// Token: 0x060015A3 RID: 5539 RVA: 0x0004AAB0 File Offset: 0x00048CB0
	private static int GetFileAttributesValue(FileInfo 1)
	{
		return (int)1.Attributes;
	}

	// Token: 0x060015A4 RID: 5540 RVA: 0x0004AAB8 File Offset: 0x00048CB8
	private static bool IsValidPath(string 1)
	{
		return 1 != null && 1.Length > 0 && 1.IndexOfAny(Path.GetInvalidPathChars()) < 0;
	}

	// Token: 0x04000A26 RID: 2598
	private bool continueRunning;

	// Token: 0x04000A27 RID: 2599
	private byte[] copyBuffer;

	// Token: 0x04000A28 RID: 2600
	private 987 zipOutputStream;

	// Token: 0x04000A29 RID: 2601
	private 905 zipFile;

	// Token: 0x04000A2A RID: 2602
	private string sourceDirectory;

	// Token: 0x04000A2B RID: 2603
	private 357 fileFilter;

	// Token: 0x04000A2C RID: 2604
	private 357 directoryFilter;

	// Token: 0x04000A2D RID: 2605
	private 87.89 overwriteMode;

	// Token: 0x04000A2E RID: 2606
	private 87.88 confirmDelegate;

	// Token: 0x04000A2F RID: 2607
	private bool restoreDateTimeOnExtract;

	// Token: 0x04000A30 RID: 2608
	private bool restoreAttributesOnExtract;

	// Token: 0x04000A31 RID: 2609
	private bool createEmptyDirectories;

	// Token: 0x04000A32 RID: 2610
	private 740 events;

	// Token: 0x04000A33 RID: 2611
	private 681 entryFactory = new 362();

	// Token: 0x04000A34 RID: 2612
	private 381 extractNameTransform;

	// Token: 0x04000A35 RID: 2613
	private 609 useZip64 = (609)2;

	// Token: 0x04000A36 RID: 2614
	private string password;

	// Token: 0x04000A37 RID: 2615
	private string targetDirectory;

	// Token: 0x020002D3 RID: 723
	public enum 89
	{

	}

	// Token: 0x020002D4 RID: 724
	// (Invoke) Token: 0x060015A6 RID: 5542
	public delegate bool 88(string 1);
}
