using System;
using System.Runtime.InteropServices;

// Token: 0x02000318 RID: 792
[ComVisible(false)]
public abstract class 720
{
	// Token: 0x060017D5 RID: 6101 RVA: 0x000055AC File Offset: 0x000037AC
	internal 720()
	{
	}

	// Token: 0x060017D6 RID: 6102 RVA: 0x00053AE4 File Offset: 0x00051CE4
	public static string Method11154(string 1)
	{
		string text = 1;
		if (1 != null && 1.Length > 0)
		{
			if (1[0] == '\\' || 1[0] == '/')
			{
				if (1.Length > 1 && (1[1] == '\\' || 1[1] == '/'))
				{
					int num = 2;
					int num2 = 2;
					while (num <= 1.Length && ((1[num] != '\\' && 1[num] != '/') || --num2 > 0))
					{
						num++;
					}
					num++;
					text = ((num >= 1.Length) ? string.Empty : 1.Substring(num));
				}
			}
			else if (1.Length > 1 && 1[1] == ':')
			{
				int count = 2;
				if (1.Length > 2 && (1[2] == '\\' || 1[2] == '/'))
				{
					count = 3;
				}
				text = text.Remove(0, count);
			}
		}
		return text;
	}
}
