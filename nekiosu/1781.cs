using System;
using System.Collections.Generic;

// Token: 0x020008B8 RID: 2232
public sealed class 1781 : 1779
{
	// Token: 0x06003FEC RID: 16364 RVA: 0x0018B7FF File Offset: 0x001899FF
	public 1781(2679 1, IEnumerable<string> 2 = null) : this(1568.1(1), 2)
	{
		base.10(1.ToString());
	}

	// Token: 0x06003FED RID: 16365 RVA: 0x0018B824 File Offset: 0x00189A24
	public 1781(string 1, IEnumerable<string> 2 = null)
	{
		this.14 = new 1452(1.ToUpper(), 12f, new 208(10f, 0f), 1f, true, 198.White);
		this.14.54(true);
		this.1.12(this.14);
		base.3(new 208(0f, 14f));
		this.13 = new 1433(1662.34, (1376)6, 1065.TopLeft, (1044)0, new 208(5f, 0f))
		{
			15 = 1.6f,
			20 = new 208(2f, 0f),
			5 = true,
			28 = true,
			6 = new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue, 40)
		};
		this.18();
		this.1.12(this.13);
		base.10(1);
		if (2 == null)
		{
			return;
		}
		foreach (string 3 in 2)
		{
			base.10(3);
		}
	}

	// Token: 0x06003FEE RID: 16366 RVA: 0x0018B964 File Offset: 0x00189B64
	internal override int GetSpacingBefore()
	{
		return 20;
	}

	// Token: 0x06003FEF RID: 16367 RVA: 0x0018B968 File Offset: 0x00189B68
	internal override void OnLayoutUpdated()
	{
		base.OnLayoutUpdated();
		this.18();
	}

	// Token: 0x06003FF0 RID: 16368 RVA: 0x0018B978 File Offset: 0x00189B78
	private void 18()
	{
		float num = base.2().Y + 5f;
		if (this.GetChildren() != null)
		{
			foreach (1779 <<EMPTY_NAME>> in this.GetChildren())
			{
				if (!<<EMPTY_NAME>>.1.6)
				{
					num += <<EMPTY_NAME>>.2().Y + 10f;
				}
			}
		}
		this.13.20.Y = num;
	}

	// Token: 0x06003FF1 RID: 16369 RVA: 0x0018BA0C File Offset: 0x00189C0C
	internal override IEnumerable<1779> GetChildren()
	{
		return base.GetChildren();
	}

	// Token: 0x06003FF2 RID: 16370 RVA: 0x0018BA14 File Offset: 0x00189C14
	internal override void SetChildren(IEnumerable<1779> 1)
	{
		base.SetChildren(1);
		this.18();
	}

	// Token: 0x06003FF3 RID: 16371 RVA: 0x0001702D File Offset: 0x0001522D
	internal override bool IsHeader()
	{
		return true;
	}

	// Token: 0x04002EB5 RID: 11957
	private new 1433 13;

	// Token: 0x04002EB6 RID: 11958
	public new 1452 14;
}
