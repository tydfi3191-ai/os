using System;
using System.IO;
using System.Runtime.InteropServices;

// Token: 0x020002D5 RID: 725
[ComVisible(false)]
public sealed class 92
{
	// Token: 0x060015A9 RID: 5545 RVA: 0x0004AAD6 File Offset: 0x00048CD6
	public 92(string 1)
	{
		this.fileFilter = new 374(1);
	}

	// Token: 0x060015AA RID: 5546 RVA: 0x0004AAEA File Offset: 0x00048CEA
	public 92(string 1, string 2)
	{
		this.fileFilter = new 374(1);
		this.directoryFilter = new 374(2);
	}

	// Token: 0x060015AB RID: 5547 RVA: 0x0004AB0A File Offset: 0x00048D0A
	public 92(495 1)
	{
		this.fileFilter = 1;
	}

	// Token: 0x060015AC RID: 5548 RVA: 0x0004AB19 File Offset: 0x00048D19
	public 92(495 1, 495 2)
	{
		this.fileFilter = 1;
		this.directoryFilter = 2;
	}

	// Token: 0x060015AD RID: 5549 RVA: 0x0004AB30 File Offset: 0x00048D30
	private bool OnDirectoryFailure(string 1, Exception 2)
	{
		496 3 = this.directoryFailure;
		bool flag = 3 != null;
		if (flag)
		{
			782 4 = new 782(1, 2);
			3(this, 4);
			this.alive = 4.GetFlag9992_12767();
		}
		return flag;
	}

	// Token: 0x060015AE RID: 5550 RVA: 0x0004AB68 File Offset: 0x00048D68
	private bool OnFileFailure(string 1, Exception 2)
	{
		bool flag = this.fileFailure != null;
		if (flag)
		{
			782 3 = new 782(1, 2);
			this.fileFailure(this, 3);
			this.alive = 3.GetFlag9992_12767();
		}
		return flag;
	}

	// Token: 0x060015AF RID: 5551 RVA: 0x0004ABA4 File Offset: 0x00048DA4
	private void OnProcessFile(string 1)
	{
		487 2 = this.processFile;
		if (2 != null)
		{
			759 3 = new 759(1);
			2(this, 3);
			this.alive = 3.GetFlag9563_12246();
		}
	}

	// Token: 0x060015B0 RID: 5552 RVA: 0x0004ABD8 File Offset: 0x00048DD8
	private void OnCompletedFile(string 1)
	{
		376 2 = this.completedFile;
		if (2 != null)
		{
			759 3 = new 759(1);
			2(this, 3);
			this.alive = 3.GetFlag9563_12246();
		}
	}

	// Token: 0x060015B1 RID: 5553 RVA: 0x0004AC0C File Offset: 0x00048E0C
	private void OnProcessDirectory(string 1, bool 2)
	{
		444 3 = this.processDirectory;
		if (3 != null)
		{
			565 4 = new 565(1, 2);
			3(this, 4);
			this.alive = 4.GetFlag9563_12246();
		}
	}

	// Token: 0x060015B2 RID: 5554 RVA: 0x0004AC3F File Offset: 0x00048E3F
	public void Scan(string 1, bool 2)
	{
		this.alive = true;
		this.ScanDir(1, 2);
	}

	// Token: 0x060015B3 RID: 5555 RVA: 0x0004AC50 File Offset: 0x00048E50
	private void ScanDir(string 1, bool 2)
	{
		try
		{
			string[] files = Directory.GetFiles(1);
			bool flag = false;
			for (int i = 0; i < files.Length; i++)
			{
				if (!this.fileFilter.Method11363(files[i]))
				{
					files[i] = null;
				}
				else
				{
					flag = true;
				}
			}
			this.OnProcessDirectory(1, flag);
			if (this.alive && flag)
			{
				foreach (string text in files)
				{
					try
					{
						if (text != null)
						{
							this.OnProcessFile(text);
							if (!this.alive)
							{
								break;
							}
						}
					}
					catch (Exception 3)
					{
						if (!this.OnFileFailure(text, 3))
						{
							throw;
						}
					}
				}
			}
		}
		catch (Exception 4)
		{
			if (!this.OnDirectoryFailure(1, 4))
			{
				throw;
			}
		}
		if (!this.alive || !2)
		{
			return;
		}
		try
		{
			foreach (string 5 in Directory.GetDirectories(1))
			{
				if (this.directoryFilter == null || this.directoryFilter.Method11363(5))
				{
					this.ScanDir(5, true);
					if (!this.alive)
					{
						break;
					}
				}
			}
		}
		catch (Exception 6)
		{
			if (!this.OnDirectoryFailure(1, 6))
			{
				throw;
			}
		}
	}

	// Token: 0x04000A39 RID: 2617
	public 444 processDirectory;

	// Token: 0x04000A3A RID: 2618
	public 487 processFile;

	// Token: 0x04000A3B RID: 2619
	public 376 completedFile;

	// Token: 0x04000A3C RID: 2620
	public 496 directoryFailure;

	// Token: 0x04000A3D RID: 2621
	public 719 fileFailure;

	// Token: 0x04000A3E RID: 2622
	private 495 fileFilter;

	// Token: 0x04000A3F RID: 2623
	private 495 directoryFilter;

	// Token: 0x04000A40 RID: 2624
	private bool alive;
}
