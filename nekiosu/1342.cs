using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;

// Token: 0x02000B31 RID: 2865
public static class 1342
{
	// Token: 0x06004F45 RID: 20293 RVA: 0x001F53C5 File Offset: 0x001F35C5
	static 1342()
	{
		102.InitializeOpCodeTables();
	}

	// Token: 0x06004F46 RID: 20294 RVA: 0x001F53CC File Offset: 0x001F35CC
	internal static string 1(MethodBase 1)
	{
		return new 104(1).GetDisassembly();
	}

	// Token: 0x06004F47 RID: 20295 RVA: 0x001F53DC File Offset: 0x001F35DC
	internal static List<StackFrame> 2(StackFrame[] 1)
	{
		1342.1343 frameFilter = new 1342.1343();
		List<StackFrame> list = new List<StackFrame>();
		if (2 == null)
		{
			return list;
		}
		list.AddRange(2);
		frameFilter.1 = new List<string>("ErrorDialog~Void Update(Microsoft.Xna.Framework.GameTime)~Void Main()~Void UpdateFadeState()~Void UpdateChildren()".Split(new char[]
		{
			'~'
		}));
		list.RemoveAll(delegate(StackFrame 1)
		{
			1342.1344 frameMethodMatcher = new 1342.1344();
			frameMethodMatcher.1 = 1;
			return !frameMethodMatcher.1.GetMethod().Module.ToString().Contains(1345.2()) || frameFilter.1.Find((string 1) => frameMethodMatcher.1.GetMethod().ToString().Contains(1)) != null;
		});
		return list;
	}

	// Token: 0x02000B32 RID: 2866
	public sealed class 1343
	{
		// Token: 0x04003B54 RID: 15188
		public List<string> 1;
	}

	// Token: 0x02000B33 RID: 2867
	public sealed class 1344
	{
		// Token: 0x04003B55 RID: 15189
		public StackFrame 1;
	}
}
