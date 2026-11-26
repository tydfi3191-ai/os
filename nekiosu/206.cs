using System;
using System.Globalization;
using System.Runtime.InteropServices;

// Token: 0x02000385 RID: 901
[ComVisible(false)]
[Serializable]
public struct 206 : IEquatable<206>
{
	// Token: 0x06001B24 RID: 6948 RVA: 0x0006C478 File Offset: 0x0006A678
	public 206(int 1, int 2)
	{
		this.X = 1;
		this.Y = 2;
	}

	// Token: 0x06001B25 RID: 6949 RVA: 0x0006C488 File Offset: 0x0006A688
	public static 206 GetZero()
	{
		return 206.Zero;
	}

	// Token: 0x06001B26 RID: 6950 RVA: 0x0006C48F File Offset: 0x0006A68F
	public bool Equals(206 1)
	{
		return this.X == 1.X && this.Y == 1.Y;
	}

	// Token: 0x06001B27 RID: 6951 RVA: 0x0006C4B0 File Offset: 0x0006A6B0
	public override bool Equals(object 1)
	{
		bool result = false;
		if (1 is 206)
		{
			result = this.Equals((206)1);
		}
		return result;
	}

	// Token: 0x06001B28 RID: 6952 RVA: 0x0006C4D5 File Offset: 0x0006A6D5
	public override int GetHashCode()
	{
		return this.X.GetHashCode() + this.Y.GetHashCode();
	}

	// Token: 0x06001B29 RID: 6953 RVA: 0x0006C4F0 File Offset: 0x0006A6F0
	public override string ToString()
	{
		CultureInfo currentCulture = CultureInfo.CurrentCulture;
		return string.Format(currentCulture, "{{X:{0} Y:{1}}}", new object[]
		{
			this.X.ToString(currentCulture),
			this.Y.ToString(currentCulture)
		});
	}

	// Token: 0x06001B2A RID: 6954 RVA: 0x0006C532 File Offset: 0x0006A732
	public static bool operator ==(206 1, 206 2)
	{
		return 1.Equals(2);
	}

	// Token: 0x06001B2B RID: 6955 RVA: 0x0006C53C File Offset: 0x0006A73C
	public static bool operator !=(206 1, 206 2)
	{
		return 1.X != 2.X || 1.Y != 2.Y;
	}

	// Token: 0x04000CF0 RID: 3312
	public int X;

	// Token: 0x04000CF1 RID: 3313
	public int Y;

	// Token: 0x04000CF2 RID: 3314
	private static 206 Zero;
}
