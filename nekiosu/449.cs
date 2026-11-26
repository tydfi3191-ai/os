using System;

// Token: 0x020002ED RID: 749
public sealed class 449
{
	// Token: 0x06001671 RID: 5745 RVA: 0x0004D204 File Offset: 0x0004B404
	public bool Method4016(769 1)
	{
		for (;;)
		{
			switch (this.number2)
			{
			case 0:
				this.number3 = 1.Method12418(5);
				if (this.number3 < 0)
				{
					return false;
				}
				this.number3 += 257;
				1.Method12419(5);
				this.number2 = 1;
				goto IL_5F;
			case 1:
				goto IL_5F;
			case 2:
				goto IL_B7;
			case 3:
				break;
			case 4:
				goto IL_1A8;
			case 5:
				goto IL_1F2;
			default:
				continue;
			}
			IL_139:
			while (this.number8 < this.number5)
			{
				int num = 1.Method12418(3);
				if (num < 0)
				{
					return false;
				}
				1.Method12419(3);
				this.byteArray[449.numberArray3[this.number8]] = (byte)num;
				this.number8++;
			}
			this._recoveredType17543107 = new 661(this.byteArray);
			this.byteArray = null;
			this.number8 = 0;
			this.number2 = 4;
			IL_1A8:
			int num2;
			while (((num2 = this._recoveredType17543107.Method9754(1)) & -16) == 0)
			{
				byte[] array = this.byteArray2;
				int num3 = this.number8;
				this.number8 = num3 + 1;
				array[num3] = (this.byteValue = (byte)num2);
				if (this.number8 == this.number6)
				{
					return true;
				}
			}
			if (num2 < 0)
			{
				return false;
			}
			if (num2 >= 17)
			{
				this.byteValue = 0;
			}
			else if (this.number8 == 0)
			{
				goto Block_10;
			}
			this.number7 = num2 - 16;
			this.number2 = 5;
			IL_1F2:
			int 2 = 449.numberArray2[this.number7];
			int num4 = 1.Method12418(2);
			if (num4 < 0)
			{
				return false;
			}
			1.Method12419(2);
			num4 += 449.numberArray[this.number7];
			if (this.number8 + num4 > this.number6)
			{
				goto Block_12;
			}
			while (num4-- > 0)
			{
				byte[] array2 = this.byteArray2;
				int num5 = this.number8;
				this.number8 = num5 + 1;
				array2[num5] = this.byteValue;
			}
			if (this.number8 != this.number6)
			{
				this.number2 = 4;
				continue;
			}
			return true;
			IL_B7:
			this.number5 = 1.Method12418(4);
			if (this.number5 < 0)
			{
				return false;
			}
			this.number5 += 4;
			1.Method12419(4);
			this.byteArray = new byte[19];
			this.number8 = 0;
			this.number2 = 3;
			goto IL_139;
			IL_5F:
			this.number4 = 1.Method12418(5);
			if (this.number4 < 0)
			{
				return false;
			}
			this.number4++;
			1.Method12419(5);
			this.number6 = this.number3 + this.number4;
			this.byteArray2 = new byte[this.number6];
			this.number2 = 2;
			goto IL_B7;
		}
		return false;
		Block_10:
		throw new 657();
		Block_12:
		throw new 657();
	}

	// Token: 0x06001672 RID: 5746 RVA: 0x0004D48C File Offset: 0x0004B68C
	public 661 Method4017()
	{
		byte[] array = new byte[this.number3];
		Array.Copy(this.byteArray2, 0, array, 0, this.number3);
		return new 661(array);
	}

	// Token: 0x06001673 RID: 5747 RVA: 0x0004D4C0 File Offset: 0x0004B6C0
	public 661 Method4018()
	{
		byte[] array = new byte[this.number4];
		Array.Copy(this.byteArray2, this.number3, array, 0, this.number4);
		return new 661(array);
	}

	// Token: 0x04000A83 RID: 2691
	private static readonly int[] numberArray = new int[]
	{
		3,
		3,
		11
	};

	// Token: 0x04000A84 RID: 2692
	private static readonly int[] numberArray2 = new int[]
	{
		2,
		3,
		7
	};

	// Token: 0x04000A85 RID: 2693
	private static readonly int[] numberArray3 = new int[]
	{
		16,
		17,
		18,
		0,
		8,
		7,
		9,
		6,
		10,
		5,
		11,
		4,
		12,
		3,
		13,
		2,
		14,
		1,
		15
	};

	// Token: 0x04000A86 RID: 2694
	private byte[] byteArray;

	// Token: 0x04000A87 RID: 2695
	private byte[] byteArray2;

	// Token: 0x04000A88 RID: 2696
	private 661 _recoveredType17543107;

	// Token: 0x04000A89 RID: 2697
	private int number2;

	// Token: 0x04000A8A RID: 2698
	private int number3;

	// Token: 0x04000A8B RID: 2699
	private int number4;

	// Token: 0x04000A8C RID: 2700
	private int number5;

	// Token: 0x04000A8D RID: 2701
	private int number6;

	// Token: 0x04000A8E RID: 2702
	private int number7;

	// Token: 0x04000A8F RID: 2703
	private byte byteValue;

	// Token: 0x04000A90 RID: 2704
	private int number8;
}
