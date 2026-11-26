using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

// Token: 0x02000C2A RID: 3114
[ComVisible(false)]
[242(1)]
[241(0)]
public sealed class 1115 : 665
{
	// Token: 0x06005444 RID: 21572 RVA: 0x0020BCEF File Offset: 0x00209EEF
	public 1115()
	{
		this.1(TraceLevel.Verbose);
		this.1 = new Queue<string>();
		this.2 = new object();
	}

	// Token: 0x06005445 RID: 21573 RVA: 0x0020BD14 File Offset: 0x00209F14
	[CompilerGenerated]
	public TraceLevel GetLevelFilter()
	{
		return this.3;
	}

	// Token: 0x06005446 RID: 21574 RVA: 0x0020BD1C File Offset: 0x00209F1C
	public void 1(TraceLevel 1)
	{
		this.3 = 1;
	}

	// Token: 0x06005447 RID: 21575 RVA: 0x0020BD28 File Offset: 0x00209F28
	public void WriteTrace(TraceLevel 1, string 2, [241(2)] Exception 3)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fff", CultureInfo.InvariantCulture));
		stringBuilder.Append(' ');
		stringBuilder.Append(1.ToString("g"));
		stringBuilder.Append(' ');
		stringBuilder.Append(2);
		string item = stringBuilder.ToString();
		object obj = this.2;
		lock (obj)
		{
			if (this.1.Count >= 1000)
			{
				this.1.Dequeue();
			}
			this.1.Enqueue(item);
		}
	}

	// Token: 0x06005448 RID: 21576 RVA: 0x0020BDE8 File Offset: 0x00209FE8
	public override string ToString()
	{
		object obj = this.2;
		string result;
		lock (obj)
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (string value in this.1)
			{
				if (stringBuilder.Length > 0)
				{
					stringBuilder.AppendLine();
				}
				stringBuilder.Append(value);
			}
			result = stringBuilder.ToString();
		}
		return result;
	}

	// Token: 0x0400405A RID: 16474
	private readonly Queue<string> 1;

	// Token: 0x0400405B RID: 16475
	private readonly object 2;

	// Token: 0x0400405C RID: 16476
	private TraceLevel 3;
}
