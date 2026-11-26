using System;
using System.Runtime.InteropServices;

// Token: 0x02000AD6 RID: 2774
[StructLayout(LayoutKind.Explicit)]
public sealed class 1445 : IComparable<1445>
{
	// Token: 0x06004D0F RID: 19727 RVA: 0x000055AC File Offset: 0x000037AC
	internal 1445()
	{
	}

	// Token: 0x06004D10 RID: 19728 RVA: 0x001E815D File Offset: 0x001E635D
	internal 1445(1456 1, float 2, float 3, int 4, int 5, 1046 6 = (1046)0)
	{
		this.14 = 1;
		this.1 = 2;
		this.5 = 3;
		this.9 = 4;
		this.10 = 5;
		this.15 = 6;
	}

	// Token: 0x06004D11 RID: 19729 RVA: 0x001E8192 File Offset: 0x001E6392
	internal 1445(208 1, 208 2, int 3, int 4, 1046 5 = (1046)0)
	{
		this.14 = 1456.Movement;
		this.2 = 1;
		this.6 = 2;
		this.15 = 5;
		this.9 = 3;
		this.10 = 4;
	}

	// Token: 0x06004D12 RID: 19730 RVA: 0x001E81C6 File Offset: 0x001E63C6
	internal 1445(1456 1, 208 2, 208 3, int 4, int 5, 1046 6 = (1046)0)
	{
		this.14 = 1;
		this.2 = 2;
		this.6 = 3;
		this.9 = 4;
		this.10 = 5;
		this.15 = 6;
	}

	// Token: 0x06004D13 RID: 19731 RVA: 0x001E81FB File Offset: 0x001E63FB
	internal 1445(198 1, 198 2, int 3, int 4)
	{
		this.14 = 1456.Colour;
		this.3 = 1;
		this.7 = 2;
		this.9 = 3;
		this.10 = 4;
	}

	// Token: 0x06004D14 RID: 19732 RVA: 0x001E8228 File Offset: 0x001E6428
	internal 1445(1058 1, 1058 2, int 3, int 4, 1046 5 = (1046)0)
	{
		this.14 = 1456.ClipRectangle;
		this.4 = 1;
		this.8 = 2;
		this.9 = 3;
		this.10 = 4;
		this.15 = 5;
	}

	// Token: 0x06004D15 RID: 19733 RVA: 0x001E8260 File Offset: 0x001E6460
	internal int 1()
	{
		return this.10 - this.9;
	}

	// Token: 0x06004D16 RID: 19734 RVA: 0x001E8270 File Offset: 0x001E6470
	public int CompareTo(1445 1)
	{
		int num = this.9.CompareTo(1.9);
		if (num != 0)
		{
			return num;
		}
		num = this.10.CompareTo(1.10);
		if (num != 0)
		{
			return num;
		}
		return this.14.CompareTo(1.14);
	}

	// Token: 0x06004D17 RID: 19735 RVA: 0x001E82C7 File Offset: 0x001E64C7
	internal 1445 Clone()
	{
		return (1445)base.MemberwiseClone();
	}

	// Token: 0x06004D18 RID: 19736 RVA: 0x001E82D4 File Offset: 0x001E64D4
	internal 1445 2()
	{
		1445 <<EMPTY_NAME>> = this.Clone();
		<<EMPTY_NAME>>.1 = this.5;
		<<EMPTY_NAME>>.3 = this.7;
		<<EMPTY_NAME>>.2 = this.6;
		<<EMPTY_NAME>>.4 = <<EMPTY_NAME>>.8;
		<<EMPTY_NAME>>.5 = this.1;
		<<EMPTY_NAME>>.7 = this.3;
		<<EMPTY_NAME>>.6 = this.2;
		<<EMPTY_NAME>>.8 = this.4;
		1046 2 = this.15;
		if (2 != (1046)1)
		{
			if (2 != (1046)2)
			{
				<<EMPTY_NAME>>.15 = (1046)0;
			}
			else
			{
				<<EMPTY_NAME>>.15 = (1046)1;
			}
		}
		else
		{
			<<EMPTY_NAME>>.15 = (1046)2;
		}
		return <<EMPTY_NAME>>;
	}

	// Token: 0x06004D19 RID: 19737 RVA: 0x001E8374 File Offset: 0x001E6574
	public override string ToString()
	{
		1456 <<EMPTY_NAME>> = this.14;
		string result;
		if (<<EMPTY_NAME>> != 1456.Movement)
		{
			if (<<EMPTY_NAME>> != 1456.Colour)
			{
				if (<<EMPTY_NAME>> != 1456.ClipRectangle)
				{
					result = string.Format("{2} {0}-{1} {3}->{4}", new object[]
					{
						this.9,
						this.10,
						this.14,
						this.1,
						this.5
					});
				}
				else
				{
					result = string.Format("{2} {0}-{1} {3}->{4}", new object[]
					{
						this.9,
						this.10,
						this.14,
						this.4,
						this.8
					});
				}
			}
			else
			{
				result = string.Format("{2} {0}-{1} {3}->{4}", new object[]
				{
					this.9,
					this.10,
					this.14,
					this.3,
					this.7
				});
			}
		}
		else
		{
			result = string.Format("{2} {0}-{1} {3}->{4}", new object[]
			{
				this.9,
				this.10,
				this.14,
				this.2,
				this.6
			});
		}
		return result;
	}

	// Token: 0x04003970 RID: 14704
	[FieldOffset(0)]
	internal float 1;

	// Token: 0x04003971 RID: 14705
	[FieldOffset(4)]
	internal 208 2;

	// Token: 0x04003972 RID: 14706
	[FieldOffset(12)]
	internal 198 3;

	// Token: 0x04003973 RID: 14707
	[FieldOffset(0)]
	internal 1058 4;

	// Token: 0x04003974 RID: 14708
	[FieldOffset(16)]
	internal float 5;

	// Token: 0x04003975 RID: 14709
	[FieldOffset(20)]
	internal 208 6;

	// Token: 0x04003976 RID: 14710
	[FieldOffset(28)]
	internal 198 7;

	// Token: 0x04003977 RID: 14711
	[FieldOffset(16)]
	internal 1058 8;

	// Token: 0x04003978 RID: 14712
	[FieldOffset(32)]
	internal int 9;

	// Token: 0x04003979 RID: 14713
	[FieldOffset(36)]
	internal int 10;

	// Token: 0x0400397A RID: 14714
	[FieldOffset(40)]
	internal int 11;

	// Token: 0x0400397B RID: 14715
	[FieldOffset(44)]
	internal int 12;

	// Token: 0x0400397C RID: 14716
	[FieldOffset(48)]
	internal int 13;

	// Token: 0x0400397D RID: 14717
	[FieldOffset(52)]
	internal 1456 14;

	// Token: 0x0400397E RID: 14718
	[FieldOffset(56)]
	internal 1046 15;

	// Token: 0x0400397F RID: 14719
	[FieldOffset(60)]
	internal byte 16;

	// Token: 0x04003980 RID: 14720
	[FieldOffset(61)]
	internal bool 17;

	// Token: 0x04003981 RID: 14721
	[FieldOffset(62)]
	internal bool 18;
}
