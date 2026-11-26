using System;
using System.Runtime.InteropServices;

// Token: 0x02000304 RID: 772
[ComVisible(false)]
public sealed class 629 : 656
{
	// Token: 0x06001733 RID: 5939 RVA: 0x0005005B File Offset: 0x0004E25B
	public 629()
	{
		this.SetNumber7041_9090();
	}

	// Token: 0x06001734 RID: 5940 RVA: 0x00050069 File Offset: 0x0004E269
	public long GetNumber7041_9089()
	{
		return (long)((ulong)this.number3);
	}

	// Token: 0x06001735 RID: 5941 RVA: 0x00050072 File Offset: 0x0004E272
	public void SetNumber7041_9090()
	{
		this.number3 = 1U;
	}

	// Token: 0x06001736 RID: 5942 RVA: 0x0005007C File Offset: 0x0004E27C
	public void Method90912(int 1)
	{
		uint num = this.number3 & 65535U;
		uint num2 = this.number3 >> 16;
		num = (num + (uint)(1 & 255)) % 65521U;
		num2 = (num + num2) % 65521U;
		this.number3 = (num2 << 16) + num;
	}

	// Token: 0x06001737 RID: 5943 RVA: 0x000500C6 File Offset: 0x0004E2C6
	public void Method90912(byte[] 1)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("#=zpMJwVYM=");
		}
		this.Method90912(1, 0, 1.Length);
	}

	// Token: 0x06001738 RID: 5944 RVA: 0x000500E4 File Offset: 0x0004E2E4
	public void Method90912(byte[] 1, int 2, int 3)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("#=zpMJwVYM=");
		}
		if (2 < 0)
		{
			throw new ArgumentOutOfRangeException("#=zJ_sgkP4=", "cannot be negative");
		}
		if (3 < 0)
		{
			throw new ArgumentOutOfRangeException("#=zW32YDQ0=", "cannot be negative");
		}
		if (2 >= 1.Length)
		{
			throw new ArgumentOutOfRangeException("#=zJ_sgkP4=", "not a valid index into buffer");
		}
		if (2 + 3 > 1.Length)
		{
			throw new ArgumentOutOfRangeException("#=zW32YDQ0=", "exceeds buffer size");
		}
		uint num = this.number3 & 65535U;
		uint num2 = this.number3 >> 16;
		while (3 > 0)
		{
			int num3 = 3800;
			if (num3 > 3)
			{
				num3 = 3;
			}
			3 -= num3;
			while (--num3 >= 0)
			{
				num += (uint)(1[2++] & byte.MaxValue);
				num2 += num;
			}
			num %= 65521U;
			num2 %= 65521U;
		}
		this.number3 = (num2 << 16 | num);
	}

	// Token: 0x04000AE3 RID: 2787
	private uint number3;
}
