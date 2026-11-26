using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;

// Token: 0x02000380 RID: 896
[ComVisible(false)]
[Serializable]
public struct 197 : IEquatable<197>
{
	// Token: 0x06001AA5 RID: 6821 RVA: 0x00064876 File Offset: 0x00062A76
	public 197(209 1, 209 2)
	{
		this.Min = 1;
		this.Max = 2;
	}

	// Token: 0x06001AA6 RID: 6822 RVA: 0x00064888 File Offset: 0x00062A88
	public 209[] GetCorners()
	{
		return new 209[]
		{
			new 209(this.Min.X, this.Max.Y, this.Max.Z),
			new 209(this.Max.X, this.Max.Y, this.Max.Z),
			new 209(this.Max.X, this.Min.Y, this.Max.Z),
			new 209(this.Min.X, this.Min.Y, this.Max.Z),
			new 209(this.Min.X, this.Max.Y, this.Min.Z),
			new 209(this.Max.X, this.Max.Y, this.Min.Z),
			new 209(this.Max.X, this.Min.Y, this.Min.Z),
			new 209(this.Min.X, this.Min.Y, this.Min.Z)
		};
	}

	// Token: 0x06001AA7 RID: 6823 RVA: 0x00064A04 File Offset: 0x00062C04
	public void GetCorners(209[] 1)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("#=zKAkMhT2laYCY");
		}
		if (1.Length < 8)
		{
			throw new ArgumentOutOfRangeException(195.GetNotEnoughCornersMessage());
		}
		1[0].X = this.Min.X;
		1[0].Y = this.Max.Y;
		1[0].Z = this.Max.Z;
		1[1].X = this.Max.X;
		1[1].Y = this.Max.Y;
		1[1].Z = this.Max.Z;
		1[2].X = this.Max.X;
		1[2].Y = this.Min.Y;
		1[2].Z = this.Max.Z;
		1[3].X = this.Min.X;
		1[3].Y = this.Min.Y;
		1[3].Z = this.Max.Z;
		1[4].X = this.Min.X;
		1[4].Y = this.Max.Y;
		1[4].Z = this.Min.Z;
		1[5].X = this.Max.X;
		1[5].Y = this.Max.Y;
		1[5].Z = this.Min.Z;
		1[6].X = this.Max.X;
		1[6].Y = this.Min.Y;
		1[6].Z = this.Min.Z;
		1[7].X = this.Min.X;
		1[7].Y = this.Min.Y;
		1[7].Z = this.Min.Z;
	}

	// Token: 0x06001AA8 RID: 6824 RVA: 0x00064C58 File Offset: 0x00062E58
	public bool Equals(197 1)
	{
		return this.Min == 1.Min && this.Max == 1.Max;
	}

	// Token: 0x06001AA9 RID: 6825 RVA: 0x00064C80 File Offset: 0x00062E80
	public override bool Equals(object 1)
	{
		bool result = false;
		if (1 is 197)
		{
			result = this.Equals((197)1);
		}
		return result;
	}

	// Token: 0x06001AAA RID: 6826 RVA: 0x00064CA5 File Offset: 0x00062EA5
	public override int GetHashCode()
	{
		return this.Min.GetHashCode() + this.Max.GetHashCode();
	}

	// Token: 0x06001AAB RID: 6827 RVA: 0x00064CCA File Offset: 0x00062ECA
	public override string ToString()
	{
		return string.Format(CultureInfo.CurrentCulture, "{{Min:{0} Max:{1}}}", new object[]
		{
			this.Min.ToString(),
			this.Max.ToString()
		});
	}

	// Token: 0x06001AAC RID: 6828 RVA: 0x00064D0C File Offset: 0x00062F0C
	public static 197 CreateMerged(197 1, 197 2)
	{
		197 result = default(197);
		209.Min(ref 1.Min, ref 2.Min, out result.Min);
		209.Max(ref 1.Max, ref 2.Max, out result.Max);
		return result;
	}

	// Token: 0x06001AAD RID: 6829 RVA: 0x00064D58 File Offset: 0x00062F58
	public static void CreateMerged(ref 197 1, ref 197 2, out 197 3)
	{
		209 min;
		209.Min(ref 1.Min, ref 2.Min, out min);
		209 max;
		209.Max(ref 1.Max, ref 2.Max, out max);
		3.Min = min;
		3.Max = max;
	}

	// Token: 0x06001AAE RID: 6830 RVA: 0x00064D9C File Offset: 0x00062F9C
	public static 197 CreateFromPoints(IEnumerable<209> 1)
	{
		if (1 == null)
		{
			throw new ArgumentNullException();
		}
		bool flag = false;
		209 2 = new 209(float.MaxValue);
		209 3 = new 209(float.MinValue);
		foreach (209 4 in 1)
		{
			209.Min(ref 2, ref 4, out 2);
			209.Max(ref 3, ref 4, out 3);
			flag = true;
		}
		if (!flag)
		{
			throw new ArgumentException(195.GetBoundingBoxZeroPointsMessage());
		}
		return new 197(2, 3);
	}

	// Token: 0x06001AAF RID: 6831 RVA: 0x00064E30 File Offset: 0x00063030
	public bool Intersects(197 1)
	{
		return this.Max.X >= 1.Min.X && this.Min.X <= 1.Max.X && this.Max.Y >= 1.Min.Y && this.Min.Y <= 1.Max.Y && this.Max.Z >= 1.Min.Z && this.Min.Z <= 1.Max.Z;
	}

	// Token: 0x06001AB0 RID: 6832 RVA: 0x00064ED4 File Offset: 0x000630D4
	public void Intersects(ref 197 1, out bool 2)
	{
		2 = false;
		if (this.Max.X >= 1.Min.X && this.Min.X <= 1.Max.X && this.Max.Y >= 1.Min.Y && this.Min.Y <= 1.Max.Y && this.Max.Z >= 1.Min.Z && this.Min.Z <= 1.Max.Z)
		{
			2 = true;
		}
	}

	// Token: 0x06001AB1 RID: 6833 RVA: 0x00064F78 File Offset: 0x00063178
	public 280 Intersects(205 1)
	{
		209 2 = default(209);
		2.X = ((1.Normal.X >= 0f) ? this.Min.X : this.Max.X);
		2.Y = ((1.Normal.Y >= 0f) ? this.Min.Y : this.Max.Y);
		2.Z = ((1.Normal.Z >= 0f) ? this.Min.Z : this.Max.Z);
		209 3 = default(209);
		3.X = ((1.Normal.X >= 0f) ? this.Max.X : this.Min.X);
		3.Y = ((1.Normal.Y >= 0f) ? this.Max.Y : this.Min.Y);
		3.Z = ((1.Normal.Z >= 0f) ? this.Max.Z : this.Min.Z);
		if (1.Normal.X * 2.X + 1.Normal.Y * 2.Y + 1.Normal.Z * 2.Z + 1.D > 0f)
		{
			return (280)0;
		}
		if (1.Normal.X * 3.X + 1.Normal.Y * 3.Y + 1.Normal.Z * 3.Z + 1.D < 0f)
		{
			return (280)1;
		}
		return (280)2;
	}

	// Token: 0x06001AB2 RID: 6834 RVA: 0x0006514C File Offset: 0x0006334C
	public void Intersects(ref 205 1, out 280 2)
	{
		209 3 = default(209);
		3.X = ((1.Normal.X >= 0f) ? this.Min.X : this.Max.X);
		3.Y = ((1.Normal.Y >= 0f) ? this.Min.Y : this.Max.Y);
		3.Z = ((1.Normal.Z >= 0f) ? this.Min.Z : this.Max.Z);
		209 4 = default(209);
		4.X = ((1.Normal.X >= 0f) ? this.Max.X : this.Min.X);
		4.Y = ((1.Normal.Y >= 0f) ? this.Max.Y : this.Min.Y);
		4.Z = ((1.Normal.Z >= 0f) ? this.Max.Z : this.Min.Z);
		if (1.Normal.X * 3.X + 1.Normal.Y * 3.Y + 1.Normal.Z * 3.Z + 1.D > 0f)
		{
			2 = (280)0;
			return;
		}
		if (1.Normal.X * 4.X + 1.Normal.Y * 4.Y + 1.Normal.Z * 4.Z + 1.D < 0f)
		{
			2 = (280)1;
			return;
		}
		2 = (280)2;
	}

	// Token: 0x04000CD5 RID: 3285
	public 209 Min;

	// Token: 0x04000CD6 RID: 3286
	public 209 Max;
}
