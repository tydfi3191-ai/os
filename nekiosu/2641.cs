using System;

// Token: 0x02000454 RID: 1108
public sealed class 2641 : 2656
{
	// Token: 0x06002209 RID: 8713 RVA: 0x000928B0 File Offset: 0x00090AB0
	internal 2641(string 1)
	{
		string text = 1;
		1254 2;
		if (1192.1<1254>(text, out 2) && 2 != 1254.None)
		{
			this.3 = 2;
			this.6 = true;
			text = text.Substring(this.3.ToString().Length, text.Length - this.3.ToString().Length);
			if (1192.1<1254>(text, out 2) && 2 != 1254.None)
			{
				this.4 = 2;
				this.7 = true;
				text = text.Substring(this.4.ToString().Length, text.Length - this.4.ToString().Length);
			}
		}
		1245 3;
		if (1192.1<1245>(text, out 3) && 3 != 1245.None && 3 != 1245.Normal)
		{
			this.2 = 3;
			text = text.Substring(this.2.ToString().Length, text.Length - this.2.ToString().Length);
		}
		int num;
		if (int.TryParse(text, out num))
		{
			this.5 = (1253)num;
			this.8 = true;
		}
		if (this.2 != 1245.None && this.6 && !this.7)
		{
			this.4 = this.3;
			this.3 = 1254.All;
			this.6 = false;
			this.7 = true;
		}
		if (!this.ToString().Equals(this.GetDefaultGroup().ToString() + 1))
		{
			throw new Exception("Invalid hitsound trigger description after " + this.ToString());
		}
	}

	// Token: 0x0600220A RID: 8714 RVA: 0x0001702D File Offset: 0x0001522D
	internal override 2659 GetDefaultGroup()
	{
		return 2659.HitSound;
	}

	// Token: 0x0600220B RID: 8715 RVA: 0x00092A64 File Offset: 0x00090C64
	internal override void Attach(2647 1, 2657 2, 1433 3)
	{
		2648.32(new 2640(new 2641.2642
		{
			1 = this,
			2 = 1,
			3 = 2,
			4 = 3
		}.1));
	}

	// Token: 0x0600220C RID: 8716 RVA: 0x00092A98 File Offset: 0x00090C98
	public override string ToString()
	{
		string text = this.GetDefaultGroup().ToString();
		if (this.6)
		{
			text += this.3.ToString();
		}
		if (this.7)
		{
			text += this.4.ToString();
		}
		if (this.2 != 1245.None)
		{
			text += this.2.ToString();
		}
		if (this.8)
		{
			string str = text;
			int num = (int)this.5;
			text = str + num.ToString();
		}
		return text;
	}

	// Token: 0x0400176D RID: 5997
	internal new 1245 2;

	// Token: 0x0400176E RID: 5998
	internal new 1254 3 = 1254.All;

	// Token: 0x0400176F RID: 5999
	internal new 1254 4 = 1254.All;

	// Token: 0x04001770 RID: 6000
	internal new 1253 5;

	// Token: 0x04001771 RID: 6001
	internal bool 6;

	// Token: 0x04001772 RID: 6002
	internal bool 7;

	// Token: 0x04001773 RID: 6003
	internal bool 8;

	// Token: 0x02000455 RID: 1109
	public sealed class 2642
	{
		// Token: 0x0600220D RID: 8717 RVA: 0x00092B38 File Offset: 0x00090D38
		internal void 1(1244 1)
		{
			if ((this.1.3 == 1254.All || 1.2 == this.1.3) && (this.1.4 == 1254.All || 1.3 == this.1.4 || (1.3 == 1254.None && 1.2 == this.1.4)) && (this.1.2 == 1245.None || 1.1.2(this.1.2)) && (!this.1.8 || 1.4 == this.1.5))
			{
				this.1.3(this.2, this.3, this.4, false);
			}
		}

		// Token: 0x04001774 RID: 6004
		public 2641 1;

		// Token: 0x04001775 RID: 6005
		public 2647 2;

		// Token: 0x04001776 RID: 6006
		public 2657 3;

		// Token: 0x04001777 RID: 6007
		public 1433 4;
	}
}
