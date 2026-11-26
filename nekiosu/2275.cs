using System;

// Token: 0x02000585 RID: 1413
public sealed class 2275 : 2647, IComparable<2275>
{
	// Token: 0x06002BB8 RID: 11192 RVA: 0x000EF7F8 File Offset: 0x000ED9F8
	internal 2275(int 1, int 2, bool 3 = true)
	{
		this.10 = 2635.Break;
		if (!3)
		{
			1 += 200;
			2 -= 2263.4.7.2;
		}
		this.8 = 1;
		this.1 = 2;
		this.6 = true;
	}

	// Token: 0x06002BB9 RID: 11193 RVA: 0x000EF846 File Offset: 0x000EDA46
	internal override void SetStartTime(int 1)
	{
		this.8 = 1;
	}

	// Token: 0x06002BBA RID: 11194 RVA: 0x000EF84F File Offset: 0x000EDA4F
	internal override void SetEndTime(int 1)
	{
		this.1 = 1;
	}

	// Token: 0x06002BBB RID: 11195 RVA: 0x0000FF75 File Offset: 0x0000E175
	internal override bool LoadTextures()
	{
		return false;
	}

	// Token: 0x06002BBC RID: 11196 RVA: 0x000EF858 File Offset: 0x000EDA58
	internal override 2647 Clone()
	{
		return new 2275(this.8, this.1, true)
		{
			12 = this.12,
			13 = this.13
		};
	}

	// Token: 0x06002BBD RID: 11197 RVA: 0x000EF884 File Offset: 0x000EDA84
	internal new int 4(int 1)
	{
		return this.8 - 1;
	}

	// Token: 0x06002BBE RID: 11198 RVA: 0x000EF88E File Offset: 0x000EDA8E
	internal new int 5(int 1)
	{
		return 1 - this.1;
	}

	// Token: 0x06002BBF RID: 11199 RVA: 0x000EF898 File Offset: 0x000EDA98
	internal new void 6(int 1)
	{
		int num = this.4(1);
		if (this.12 && num > 200)
		{
			if (num > 5000)
			{
				this.SetStartTime(1 + 5000);
				return;
			}
		}
		else
		{
			this.12 = false;
			this.SetStartTime(1 + 200);
		}
	}

	// Token: 0x06002BC0 RID: 11200 RVA: 0x000EF8E8 File Offset: 0x000EDAE8
	internal new void 7(int 1)
	{
		int num = this.5(1);
		if (this.13 && num > 2263.4.7.2)
		{
			if (num > 5000)
			{
				this.SetEndTime(1 - 5000);
				return;
			}
		}
		else
		{
			this.13 = false;
			this.SetEndTime(1 - 2263.4.7.2);
		}
	}

	// Token: 0x06002BC1 RID: 11201 RVA: 0x000EF94B File Offset: 0x000EDB4B
	internal new bool 8(int 1, int 2, bool 3)
	{
		this.6(1);
		this.7(2);
		return this.9(1, 2, 3);
	}

	// Token: 0x06002BC2 RID: 11202 RVA: 0x000EF964 File Offset: 0x000EDB64
	internal new bool 9(int 1, int 2, bool 3)
	{
		if (this.GetDuration() < 50)
		{
			2039 4 = 2263.4.7;
			int num = this.4(1);
			int num2 = this.5(2);
			int num3 = 50 - this.GetDuration();
			if (3)
			{
				int num4;
				if (num > 200)
				{
					num4 = num - 200;
					if (num4 >= num3)
					{
						this.12 = (num4 != num3);
						this.SetStartTime(this.8 - num3);
						return true;
					}
					this.12 = false;
					this.SetStartTime(1 + 200);
					num3 -= num4;
				}
				if (num2 <= 0)
				{
					return false;
				}
				num4 = num2 - 4.2;
				if (num4 >= num3)
				{
					this.13 = (num4 != num3);
					this.SetEndTime(this.1 + num3);
					return true;
				}
			}
			else
			{
				int num5;
				if (num2 > 4.2)
				{
					num5 = num2 - 4.2;
					if (num5 >= num3)
					{
						this.13 = (num5 != num3);
						this.SetEndTime(this.1 + num3);
						return true;
					}
					this.13 = false;
					this.SetEndTime(2 - 2263.4.7.2);
					num3 -= num5;
				}
				num5 = num - 200;
				if (num5 >= num3)
				{
					this.12 = (num5 != num3);
					this.SetStartTime(this.8 - num3);
					return true;
				}
			}
			this.6(1);
			this.7(2);
			return this.8 <= 2 && this.1 >= 1;
		}
		return true;
	}

	// Token: 0x06002BC3 RID: 11203 RVA: 0x000EFAD8 File Offset: 0x000EDCD8
	internal new bool 10(bool 1, bool 2)
	{
		return this.11(1, false, true, 2);
	}

	// Token: 0x06002BC4 RID: 11204 RVA: 0x000EFAE4 File Offset: 0x000EDCE4
	internal new bool 11(bool 1, bool 2, bool 3, bool 4)
	{
		2263 5 = 2263.4;
		if (5 == null)
		{
			throw new InvalidOperationException("Method can only be called from the Editor");
		}
		2039 6 = 5.7;
		if (5.26 == 2335.Compose)
		{
			5.74.65();
		}
		int num;
		int num2;
		bool flag = 5.7(this, out num, out num2);
		if (flag)
		{
			flag = 5.5(num, num2, 3);
			if (flag)
			{
				if (4)
				{
					5.8.19((2452)2, null);
					5.8.13((2451)0, (2450)2304);
					5.8.23(this, false);
				}
				int num3 = num + 200;
				int num4 = num2 - 6.2;
				if (2)
				{
					this.12 = (this.8 != num3);
					this.13 = (this.1 != num4);
				}
				else
				{
					if (!this.12)
					{
						this.SetStartTime(num3);
					}
					if (!this.13)
					{
						this.SetEndTime(num4);
					}
				}
				if (this.8 < num3)
				{
					this.12 = false;
					this.SetStartTime(num3);
				}
				if (this.GetDuration() >= 0 && (this.1 > num4 || num3 > this.1))
				{
					this.13 = false;
					this.SetEndTime(num4);
				}
				flag = this.8(num, num2, !1);
			}
		}
		if (!flag)
		{
			5.21(this, 4);
			return false;
		}
		return true;
	}

	// Token: 0x06002BC5 RID: 11205 RVA: 0x00095309 File Offset: 0x00093509
	public int CompareTo(2275 1)
	{
		return this.8.CompareTo(1.8);
	}

	// Token: 0x04002005 RID: 8197
	public bool 12;

	// Token: 0x04002006 RID: 8198
	public bool 13;
}
