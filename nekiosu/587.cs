using System;
using System.Runtime.InteropServices;
using System.Threading;

// Token: 0x0200016C RID: 364
[242(1)]
[ComVisible(false)]
[241(0)]
public sealed class 587 : 406
{
	// Token: 0x06000C3B RID: 3131 RVA: 0x0002C2AF File Offset: 0x0002A4AF
	public 587()
	{
		this._recoveredType1398Array6174 = new 587.588[this.number5 + 1];
	}

	// Token: 0x06000C3C RID: 3132 RVA: 0x0002C2D4 File Offset: 0x0002A4D4
	[return: 241(2)]
	public override string Method7974(char[] 1, int 2, int 3)
	{
		if (3 == 0)
		{
			return string.Empty;
		}
		int num = 3 + 587.number3;
		num += (num << 7 ^ (int)1[2]);
		int num2 = 2 + 3;
		for (int i = 2 + 1; i < num2; i++)
		{
			num += (num << 7 ^ (int)1[i]);
		}
		num -= num >> 17;
		num -= num >> 11;
		num -= num >> 5;
		int num3 = Thread.VolatileRead(ref this.number5);
		int num4 = num & num3;
		for (587.588 4 = this._recoveredType1398Array6174[num4]; 4 != null; 4 = 4._recoveredType13986171)
		{
			if (4.number2 == num && 587.Method7978(4.text2, 1, 2, 3))
			{
				return 4.text2;
			}
		}
		return null;
	}

	// Token: 0x06000C3D RID: 3133 RVA: 0x0002C380 File Offset: 0x0002A580
	public string Method7975(string 1)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("#=zGDlk81Y=");
		}
		int length = 1.Length;
		if (length == 0)
		{
			return string.Empty;
		}
		int num = length + 587.number3;
		for (int i = 0; i < 1.Length; i++)
		{
			num += (num << 7 ^ (int)1[i]);
		}
		num -= num >> 17;
		num -= num >> 11;
		num -= num >> 5;
		for (587.588 2 = this._recoveredType1398Array6174[num & this.number5]; 2 != null; 2 = 2._recoveredType13986171)
		{
			if (2.number2 == num && 2.text2.Equals(1, StringComparison.Ordinal))
			{
				return 2.text2;
			}
		}
		return this.Method7976(1, num);
	}

	// Token: 0x06000C3E RID: 3134 RVA: 0x0002C42C File Offset: 0x0002A62C
	private string Method7976(string 1, int 2)
	{
		int num = 2 & this.number5;
		587.588 3 = new 587.588(1, 2, this._recoveredType1398Array6174[num]);
		this._recoveredType1398Array6174[num] = 3;
		int num2 = this.number4;
		this.number4 = num2 + 1;
		if (num2 == this.number5)
		{
			this.Method7977();
		}
		return 3.text2;
	}

	// Token: 0x06000C3F RID: 3135 RVA: 0x0002C480 File Offset: 0x0002A680
	private void Method7977()
	{
		587.588[] recoveredType1398Array = this._recoveredType1398Array6174;
		int num = this.number5 * 2 + 1;
		587.588[] array = new 587.588[num + 1];
		foreach (587.588 <<EMPTY_NAME>> in recoveredType1398Array)
		{
			while (<<EMPTY_NAME>> != null)
			{
				int num2 = <<EMPTY_NAME>>.number2 & num;
				587.588 recoveredType = <<EMPTY_NAME>>._recoveredType13986171;
				<<EMPTY_NAME>>._recoveredType13986171 = array[num2];
				array[num2] = <<EMPTY_NAME>>;
				<<EMPTY_NAME>> = recoveredType;
			}
		}
		this._recoveredType1398Array6174 = array;
		Thread.VolatileWrite(ref this.number5, num);
	}

	// Token: 0x06000C40 RID: 3136 RVA: 0x0002C4FC File Offset: 0x0002A6FC
	private static bool Method7978(string 1, char[] 2, int 3, int 4)
	{
		if (1.Length != 4)
		{
			return false;
		}
		for (int i = 0; i < 1.Length; i++)
		{
			if (1[i] != 2[3 + i])
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x040005FD RID: 1533
	private static readonly int number3 = Environment.TickCount;

	// Token: 0x040005FE RID: 1534
	private int number4;

	// Token: 0x040005FF RID: 1535
	private 587.588[] _recoveredType1398Array6174;

	// Token: 0x04000600 RID: 1536
	private int number5 = 31;

	// Token: 0x0200016D RID: 365
	[241(0)]
	public sealed class 588
	{
		// Token: 0x06000C41 RID: 3137 RVA: 0x0002C536 File Offset: 0x0002A736
		internal 588(string 1, int 2, 587.588 3)
		{
			this.text2 = 1;
			this.number2 = 2;
			this._recoveredType13986171 = 3;
		}

		// Token: 0x04000601 RID: 1537
		internal readonly string text2;

		// Token: 0x04000602 RID: 1538
		internal readonly int number2;

		// Token: 0x04000603 RID: 1539
		internal 587.588 _recoveredType13986171;
	}
}
