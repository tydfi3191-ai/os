using System;
using System.Runtime.InteropServices;

// Token: 0x02000C3A RID: 3130
[ComVisible(false)]
public struct 1087
{
	// Token: 0x1700032D RID: 813
	public 1086 this[200 1]
	{
		get
		{
			uint num;
			switch (1 >> 5)
			{
			case 200.None:
				num = this.9;
				break;
			case (200)1:
				num = this.10;
				break;
			case (200)2:
				num = this.11;
				break;
			case (200)3:
				num = this.12;
				break;
			case (200)4:
				num = this.13;
				break;
			case (200)5:
				num = this.14;
				break;
			case (200)6:
				num = this.15;
				break;
			case (200)7:
				num = this.16;
				break;
			default:
				return (1086)0;
			}
			uint num2 = 1U << (int)1;
			if ((num & num2) == 0U)
			{
				return (1086)0;
			}
			return (1086)1;
		}
	}

	// Token: 0x0600546A RID: 21610 RVA: 0x0020BF40 File Offset: 0x0020A140
	static 1087()
	{
		1087 <<EMPTY_NAME>> = default(1087);
		foreach (object obj in Enum.GetValues(typeof(200)))
		{
			int num = (int)obj;
			<<EMPTY_NAME>>.1(num);
		}
		1087.1 = <<EMPTY_NAME>>.9;
		1087.2 = <<EMPTY_NAME>>.10;
		1087.3 = <<EMPTY_NAME>>.11;
		1087.4 = <<EMPTY_NAME>>.12;
		1087.5 = <<EMPTY_NAME>>.13;
		1087.6 = <<EMPTY_NAME>>.14;
		1087.7 = <<EMPTY_NAME>>.15;
		1087.8 = <<EMPTY_NAME>>.16;
	}

	// Token: 0x0600546B RID: 21611 RVA: 0x0020C034 File Offset: 0x0020A234
	public void 1(int 1)
	{
		uint num = 1U << 1;
		switch (1 >> 5)
		{
		case 0:
			this.9 |= (num & 1087.1);
			return;
		case 1:
			this.10 |= (num & 1087.2);
			return;
		case 2:
			this.11 |= (num & 1087.3);
			return;
		case 3:
			this.12 |= (num & 1087.4);
			return;
		case 4:
			this.13 |= (num & 1087.5);
			return;
		case 5:
			this.14 |= (num & 1087.6);
			return;
		case 6:
			this.15 |= (num & 1087.7);
			return;
		case 7:
			this.16 |= (num & 1087.8);
			return;
		default:
			return;
		}
	}

	// Token: 0x0600546C RID: 21612 RVA: 0x0020C11A File Offset: 0x0020A31A
	public bool 2(200 1)
	{
		return this[1] == (1086)1;
	}

	// Token: 0x0600546D RID: 21613 RVA: 0x0020C128 File Offset: 0x0020A328
	public 200[] 3()
	{
		int num = 0;
		1087.4(this.9, 0, null, ref num);
		1087.4(this.10, 0, null, ref num);
		1087.4(this.11, 0, null, ref num);
		1087.4(this.12, 0, null, ref num);
		1087.4(this.13, 0, null, ref num);
		1087.4(this.14, 0, null, ref num);
		1087.4(this.15, 0, null, ref num);
		1087.4(this.16, 0, null, ref num);
		200[] result = new 200[num];
		if (num > 0)
		{
			int num2 = 0;
			1087.4(this.9, 0, result, ref num2);
			1087.4(this.10, 1, result, ref num2);
			1087.4(this.11, 2, result, ref num2);
			1087.4(this.12, 3, result, ref num2);
			1087.4(this.13, 4, result, ref num2);
			1087.4(this.14, 5, result, ref num2);
			1087.4(this.15, 6, result, ref num2);
			1087.4(this.16, 7, result, ref num2);
		}
		return result;
	}

	// Token: 0x0600546E RID: 21614 RVA: 0x0020C238 File Offset: 0x0020A438
	private static void 4(uint 1, int 2, 200[] 3, ref int 4)
	{
		if (1 == 0U)
		{
			return;
		}
		for (int i = 0; i < 32; i++)
		{
			if (((ulong)1 & 1UL << (i & 31)) != 0UL)
			{
				if (3 != null)
				{
					3[4] = (200)(2 * 32 + i);
				}
				4++;
			}
		}
	}

	// Token: 0x0600546F RID: 21615 RVA: 0x0020C278 File Offset: 0x0020A478
	public override int GetHashCode()
	{
		return this.9.GetHashCode() ^ this.10.GetHashCode() ^ this.11.GetHashCode() ^ this.12.GetHashCode() ^ this.13.GetHashCode() ^ this.14.GetHashCode() ^ this.15.GetHashCode() ^ this.16.GetHashCode();
	}

	// Token: 0x06005470 RID: 21616 RVA: 0x0020C2E4 File Offset: 0x0020A4E4
	public override bool Equals(object 1)
	{
		return 1 is 1087 && this == (1087)1;
	}

	// Token: 0x06005471 RID: 21617 RVA: 0x0020C304 File Offset: 0x0020A504
	public static bool operator ==(1087 1, 1087 2)
	{
		return 1.9 == 2.9 && 1.10 == 2.10 && 1.11 == 2.11 && 1.12 == 2.12 && 1.13 == 2.13 && 1.14 == 2.14 && 1.15 == 2.15 && 1.16 == 2.16;
	}

	// Token: 0x06005472 RID: 21618 RVA: 0x0020C383 File Offset: 0x0020A583
	public static bool operator !=(1087 1, 1087 2)
	{
		return !(1 == 2);
	}

	// Token: 0x040040B7 RID: 16567
	private static uint 1 = uint.MaxValue;

	// Token: 0x040040B8 RID: 16568
	private static uint 2 = uint.MaxValue;

	// Token: 0x040040B9 RID: 16569
	private static uint 3 = uint.MaxValue;

	// Token: 0x040040BA RID: 16570
	private static uint 4 = uint.MaxValue;

	// Token: 0x040040BB RID: 16571
	private static uint 5 = uint.MaxValue;

	// Token: 0x040040BC RID: 16572
	private static uint 6 = uint.MaxValue;

	// Token: 0x040040BD RID: 16573
	private static uint 7 = uint.MaxValue;

	// Token: 0x040040BE RID: 16574
	private static uint 8 = uint.MaxValue;

	// Token: 0x040040BF RID: 16575
	private uint 9;

	// Token: 0x040040C0 RID: 16576
	private uint 10;

	// Token: 0x040040C1 RID: 16577
	private uint 11;

	// Token: 0x040040C2 RID: 16578
	private uint 12;

	// Token: 0x040040C3 RID: 16579
	private uint 13;

	// Token: 0x040040C4 RID: 16580
	private uint 14;

	// Token: 0x040040C5 RID: 16581
	private uint 15;

	// Token: 0x040040C6 RID: 16582
	private uint 16;
}
