using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

// Token: 0x020001D2 RID: 466
[ComVisible(false)]
public static class 152
{
	// Token: 0x06000EE2 RID: 3810 RVA: 0x000327BC File Offset: 0x000309BC
	public static bool Method2017(this 226 1, 529 2)
	{
		152.153 3 = new 152.153();
		3.isValid = true;
		1.Method2019(2, new 766(3.MarkInvalid));
		return 3.isValid;
	}

	// Token: 0x06000EE3 RID: 3811 RVA: 0x000327F0 File Offset: 0x000309F0
	public static bool Method2017(this 226 1, 529 2, out IList<string> 3)
	{
		152.154 4 = new 152.154();
		4.errorMessages = new List<string>();
		1.Method2019(2, new 766(4.AddErrorMessage));
		3 = 4.errorMessages;
		return 3.Count == 0;
	}

	// Token: 0x06000EE4 RID: 3812 RVA: 0x00032833 File Offset: 0x00030A33
	public static void Method2019(this 226 1, 529 2)
	{
		1.Method2019(2, null);
	}

	// Token: 0x06000EE5 RID: 3813 RVA: 0x00032840 File Offset: 0x00030A40
	public static void Method2019(this 226 1, 529 2, 766 3)
	{
		756.Method12216(1, "source");
		756.Method12216(2, "schema");
		898 4 = new 898(1.CreateReader());
		try
		{
			4.SetSchema(2);
			if (3 != null)
			{
				4.AddValidationEventHandler(3);
			}
			while (4.Read())
			{
			}
		}
		finally
		{
			((IDisposable)4).Dispose();
		}
	}

	// Token: 0x020001D3 RID: 467
	public sealed class 153
	{
		// Token: 0x06000EE6 RID: 3814 RVA: 0x000328A4 File Offset: 0x00030AA4
		internal void MarkInvalid(object 1, 691 2)
		{
			this.isValid = false;
		}

		// Token: 0x04000740 RID: 1856
		public bool isValid;
	}

	// Token: 0x020001D4 RID: 468
	public sealed class 154
	{
		// Token: 0x06000EE8 RID: 3816 RVA: 0x000328AD File Offset: 0x00030AAD
		internal void AddErrorMessage(object 1, 691 2)
		{
			this.errorMessages.Add(2.Method10355());
		}

		// Token: 0x04000741 RID: 1857
		public IList<string> errorMessages;
	}
}
