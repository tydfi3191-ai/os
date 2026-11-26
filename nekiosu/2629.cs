using System;

// Token: 0x0200046E RID: 1134
public sealed class 2629
{
	// Token: 0x060022A1 RID: 8865 RVA: 0x00096064 File Offset: 0x00094264
	internal 2629(string 1, int 2)
	{
		int num = 1.IndexOf("//");
		if (num == 0)
		{
			this.1 = true;
		}
		else if (num > 0)
		{
			while (num > 0 && 1[num - 1] == ' ')
			{
				num--;
			}
			this.2 = 1.Substring(num);
			1 = 1.Remove(num, 1.Length - num).Trim();
		}
		this.3 = 1;
		this.5 = 2;
		if (1.Contains(":"))
		{
			string[] array = 1.Trim().Split(new char[]
			{
				':'
			});
			if (array.Length > 1)
			{
				this.3 = array[0].Trim();
				this.4 = array[1].Trim();
			}
		}
	}

	// Token: 0x060022A2 RID: 8866 RVA: 0x00096121 File Offset: 0x00094321
	internal 2629(string 1, string 2)
	{
		this.3 = 1;
		this.4 = 2;
	}

	// Token: 0x060022A3 RID: 8867 RVA: 0x00096138 File Offset: 0x00094338
	public override string ToString()
	{
		string str = this.2 ?? string.Empty;
		if (this.4 == null)
		{
			return this.3 + str;
		}
		return string.Format("{0}: {1}", this.3, this.4).Trim() + str;
	}

	// Token: 0x040017FF RID: 6143
	internal bool 1;

	// Token: 0x04001800 RID: 6144
	internal string 2;

	// Token: 0x04001801 RID: 6145
	internal string 3;

	// Token: 0x04001802 RID: 6146
	internal string 4;

	// Token: 0x04001803 RID: 6147
	internal int 5;
}
