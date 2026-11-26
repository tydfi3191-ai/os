using System;
using System.Text;

// Token: 0x02000973 RID: 2419
public sealed class 1618
{
	// Token: 0x06004419 RID: 17433 RVA: 0x001AD06B File Offset: 0x001AB26B
	internal 1618()
	{
	}

	// Token: 0x0600441A RID: 17434 RVA: 0x001AD0A0 File Offset: 0x001AB2A0
	internal 1618(Exception 1)
	{
		this.5 = 1;
		this.4 = 1.GetType().ToString();
		StringBuilder stringBuilder = new StringBuilder();
		foreach (string text in 1.ToString().Split(new char[]
		{
			'\n'
		}))
		{
			if (text.Contains("Microsoft.Xna.Framework.Game.Tick"))
			{
				break;
			}
			stringBuilder.AppendLine(text.Trim(new char[]
			{
				'\r'
			}));
		}
		this.3 = stringBuilder.ToString();
	}

	// Token: 0x040031EC RID: 12780
	internal string 1 = string.Empty;

	// Token: 0x040031ED RID: 12781
	internal string 2 = string.Empty;

	// Token: 0x040031EE RID: 12782
	internal string 3 = string.Empty;

	// Token: 0x040031EF RID: 12783
	public string 4 = string.Empty;

	// Token: 0x040031F0 RID: 12784
	public Exception 5;

	// Token: 0x040031F1 RID: 12785
	public byte[] 6;

	// Token: 0x040031F2 RID: 12786
	internal bool 7;
}
