using System;
using System.Collections.Generic;

// Token: 0x020002A9 RID: 681
public sealed class 332
{
	// Token: 0x060014A1 RID: 5281 RVA: 0x00047858 File Offset: 0x00045A58
	internal 325 Method0879(345 1)
	{
		if (1 == null)
		{
			throw new ArgumentNullException();
		}
		object obj = this.value2;
		325 result;
		lock (obj)
		{
			if (this.dictionary == null)
			{
				this.dictionary = new Dictionary<345, 325>();
			}
			325 2;
			if (!this.dictionary.TryGetValue(1, out 2))
			{
				2 = new 325(1);
				this.dictionary[1] = 2;
			}
			result = 2;
		}
		return result;
	}

	// Token: 0x040009B3 RID: 2483
	private object value2 = new object();

	// Token: 0x040009B4 RID: 2484
	private Dictionary<345, 325> dictionary;
}
