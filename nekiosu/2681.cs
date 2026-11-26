using System;
using System.IO;
using System.Threading;

// Token: 0x0200043C RID: 1084
public sealed class 2681 : FileStream
{
	// Token: 0x060021C7 RID: 8647 RVA: 0x00091C10 File Offset: 0x0008FE10
	public 2681(string 1) : base(1 + "." + DateTime.Now.Ticks.ToString(), FileMode.Create)
	{
		this.3 = 1;
	}

	// Token: 0x17000238 RID: 568
	// (get) Token: 0x060021C8 RID: 8648 RVA: 0x00091C4B File Offset: 0x0008FE4B
	// (set) Token: 0x060021C9 RID: 8649 RVA: 0x00091C53 File Offset: 0x0008FE53
	internal bool Committed { get; private set; }

	// Token: 0x060021CA RID: 8650 RVA: 0x00091C5C File Offset: 0x0008FE5C
	private string 1()
	{
		return base.Name;
	}

	// Token: 0x060021CB RID: 8651 RVA: 0x00091C64 File Offset: 0x0008FE64
	internal void 2()
	{
		this.2 = true;
	}

	// Token: 0x060021CC RID: 8652 RVA: 0x00091C70 File Offset: 0x0008FE70
	protected override void Dispose(bool 1)
	{
		if (this.4)
		{
			return;
		}
		this.4 = true;
		if (!this.2 && 1)
		{
			try
			{
				this.Flush(true);
			}
			catch (Exception)
			{
			}
		}
		base.Dispose(1);
		object obj = 2681.1;
		lock (obj)
		{
			if (File.Exists(this.1()))
			{
				if (this.2)
				{
					2672.20(this.1());
				}
				else
				{
					string text = 2672.31(this.3);
					try
					{
						Directory.CreateDirectory(Path.GetDirectoryName(text));
					}
					catch
					{
					}
					int num = 1;
					for (;;)
					{
						try
						{
							if (File.Exists(this.3))
							{
								File.Replace(this.1(), this.3, text, true);
							}
							else
							{
								File.Move(this.1(), this.3);
							}
							this.Committed = true;
							break;
						}
						catch (Exception ex)
						{
							if (num >= 3 || (!(ex is IOException) && !(ex is UnauthorizedAccessException)))
							{
								1338.4(ex, "file write issue", 1341.Runtime);
								if (File.Exists(this.3))
								{
									2672.20(this.1());
								}
								break;
							}
							Thread.Sleep(100);
						}
						num++;
					}
				}
			}
		}
	}

	// Token: 0x04001729 RID: 5929
	private static object 1 = new object();

	// Token: 0x0400172A RID: 5930
	private bool 2;

	// Token: 0x0400172B RID: 5931
	private string 3;

	// Token: 0x0400172C RID: 5932
	private bool 4;
}
