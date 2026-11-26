using System;
using System.Collections.Generic;
using System.Diagnostics;

// Token: 0x02000B27 RID: 2855
public sealed class 1328 : TraceListener
{
	// Token: 0x06004F16 RID: 20246 RVA: 0x001F3AC8 File Offset: 0x001F1CC8
	public override void Write(string 1)
	{
		List<string> obj = this.1;
		lock (obj)
		{
			this.1.Add(1);
		}
	}

	// Token: 0x06004F17 RID: 20247 RVA: 0x001F3B10 File Offset: 0x001F1D10
	public override void WriteLine(string 1)
	{
		List<string> obj = this.1;
		lock (obj)
		{
			this.1.Add(1);
		}
	}

	// Token: 0x06004F18 RID: 20248 RVA: 0x001F3B58 File Offset: 0x001F1D58
	internal IEnumerable<string> 1()
	{
		List<string> obj = this.1;
		IEnumerable<string> result;
		lock (obj)
		{
			IEnumerable<string> enumerable = new List<string>(this.1);
			this.1.Clear();
			result = enumerable;
		}
		return result;
	}

	// Token: 0x06004F19 RID: 20249 RVA: 0x001F3BAC File Offset: 0x001F1DAC
	public override void Fail(string 1)
	{
		this.Fail(1, null);
	}

	// Token: 0x06004F1A RID: 20250 RVA: 0x001F3BB8 File Offset: 0x001F1DB8
	public override void Fail(string 1, string 2)
	{
		List<string> obj = this.1;
		lock (obj)
		{
			this.1.Add("ASSERT: " + 1 + " (hold shift to break)");
			if (2 != null)
			{
				this.1.Add(2);
			}
			if (Debugger.IsAttached && 1549.3)
			{
				Debugger.Break();
			}
		}
	}

	// Token: 0x04003B1D RID: 15133
	private List<string> 1 = new List<string>();
}
