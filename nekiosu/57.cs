using System;
using System.IO;
using System.Runtime.InteropServices;

// Token: 0x020002D1 RID: 721
[ComVisible(false)]
public sealed class 57 : 608
{
	// Token: 0x0600157F RID: 5503 RVA: 0x00049F76 File Offset: 0x00048176
	public 57(905 1, 455 2) : base(2)
	{
		if (1.GetName() == null)
		{
			throw new 415("Cant handle non file archives");
		}
		this.fileName = 1.GetName();
	}

	// Token: 0x06001580 RID: 5504 RVA: 0x00049F9E File Offset: 0x0004819E
	public 57(905 1) : this(1, (455)0)
	{
	}

	// Token: 0x06001581 RID: 5505 RVA: 0x00049FA8 File Offset: 0x000481A8
	public override Stream Method7557()
	{
		if (this.temporaryName != null)
		{
			this.temporaryName = 57.GetTempFileName(this.temporaryName, true);
			this.temporaryStream = File.Open(this.temporaryName, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
		}
		else
		{
			this.temporaryName = Path.GetTempFileName();
			this.temporaryStream = File.Open(this.temporaryName, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
		}
		return this.temporaryStream;
	}

	// Token: 0x06001582 RID: 5506 RVA: 0x0004A00C File Offset: 0x0004820C
	public override Stream Method7558()
	{
		if (this.temporaryStream == null)
		{
			throw new 415("No temporary stream has been created");
		}
		string tempFileName = 57.GetTempFileName(this.fileName, false);
		bool flag = false;
		Stream result;
		try
		{
			this.temporaryStream.Close();
			File.Move(this.fileName, tempFileName);
			File.Move(this.temporaryName, this.fileName);
			flag = true;
			File.Delete(tempFileName);
			result = File.Open(this.fileName, FileMode.Open, FileAccess.Read, FileShare.Read);
		}
		catch (Exception)
		{
			if (!flag)
			{
				File.Move(tempFileName, this.fileName);
				File.Delete(this.temporaryName);
			}
			throw;
		}
		return result;
	}

	// Token: 0x06001583 RID: 5507 RVA: 0x0004A0AC File Offset: 0x000482AC
	public override Stream Method7559(Stream 1)
	{
		1.Close();
		this.temporaryName = 57.GetTempFileName(this.fileName, true);
		File.Copy(this.fileName, this.temporaryName, true);
		this.temporaryStream = new FileStream(this.temporaryName, FileMode.Open, FileAccess.ReadWrite);
		return this.temporaryStream;
	}

	// Token: 0x06001584 RID: 5508 RVA: 0x0004A0FC File Offset: 0x000482FC
	public override Stream Method7560(Stream 1)
	{
		if (1 == null || !1.CanWrite)
		{
			if (1 != null)
			{
				1.Close();
			}
			return new FileStream(this.fileName, FileMode.Open, FileAccess.ReadWrite);
		}
		return 1;
	}

	// Token: 0x06001585 RID: 5509 RVA: 0x0004A121 File Offset: 0x00048321
	public override void Method7561()
	{
		if (this.temporaryStream != null)
		{
			this.temporaryStream.Close();
		}
	}

	// Token: 0x06001586 RID: 5510 RVA: 0x0004A138 File Offset: 0x00048338
	private static string GetTempFileName(string 1, bool 2)
	{
		string text = null;
		if (1 == null)
		{
			text = Path.GetTempFileName();
		}
		else
		{
			int num = 0;
			int second = DateTime.Now.Second;
			while (text == null)
			{
				num++;
				string text2 = string.Format("{0}.{1}{2}.tmp", 1, second, num);
				if (!File.Exists(text2))
				{
					if (2)
					{
						try
						{
							using (File.Create(text2))
							{
							}
							text = text2;
							continue;
						}
						catch
						{
							second = DateTime.Now.Second;
							continue;
						}
					}
					text = text2;
				}
			}
		}
		return text;
	}

	// Token: 0x04000A23 RID: 2595
	private Stream temporaryStream;

	// Token: 0x04000A24 RID: 2596
	private string fileName;

	// Token: 0x04000A25 RID: 2597
	private string temporaryName;
}
