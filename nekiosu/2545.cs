using System;

// Token: 0x02000511 RID: 1297
[276]
internal sealed class 2545 : 2503
{
	// Token: 0x060027A6 RID: 10150 RVA: 0x000C6C65 File Offset: 0x000C4E65
	internal 2545(2511 1, 2528 2) : base(1, 2)
	{
		2.8(2530.Text("text", "Text", "What is written.", "Circles!", 100));
		base.6();
	}

	// Token: 0x060027A7 RID: 10151 RVA: 0x000C6C98 File Offset: 0x000C4E98
	protected override string GetText()
	{
		string text = this.2.10("text");
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		return " ";
	}
}
