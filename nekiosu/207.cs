using System;
using System.Globalization;
using System.Runtime.InteropServices;

// Token: 0x02000386 RID: 902
[ComVisible(false)]
[Serializable]
public struct 207 : IEquatable<207>
{
	// Token: 0x06001B2C RID: 6956 RVA: 0x0006C55F File Offset: 0x0006A75F
	public 207(int 1, int 2, int 3, int 4)
	{
		this.X = 1;
		this.Y = 2;
		this.Width = 3;
		this.Height = 4;
	}

	// Token: 0x06001B2D RID: 6957 RVA: 0x0006C57E File Offset: 0x0006A77E
	public int GetLeft()
	{
		return this.X;
	}

	// Token: 0x06001B2E RID: 6958 RVA: 0x0006C586 File Offset: 0x0006A786
	public int GetRight()
	{
		return this.X + this.Width;
	}

	// Token: 0x06001B2F RID: 6959 RVA: 0x0006C595 File Offset: 0x0006A795
	public int GetTop()
	{
		return this.Y;
	}

	// Token: 0x06001B30 RID: 6960 RVA: 0x0006C59D File Offset: 0x0006A79D
	public int GetBottom()
	{
		return this.Y + this.Height;
	}

	// Token: 0x06001B31 RID: 6961 RVA: 0x0006C5AC File Offset: 0x0006A7AC
	public static 207 GetEmpty()
	{
		return 207.Empty;
	}

	// Token: 0x06001B32 RID: 6962 RVA: 0x0006C5B3 File Offset: 0x0006A7B3
	public void Offset(206 1)
	{
		this.X += 1.X;
		this.Y += 1.Y;
	}

	// Token: 0x06001B33 RID: 6963 RVA: 0x0006C5DB File Offset: 0x0006A7DB
	public void Offset(int 1, int 2)
	{
		this.X += 1;
		this.Y += 2;
	}

	// Token: 0x06001B34 RID: 6964 RVA: 0x0006C5F9 File Offset: 0x0006A7F9
	public void Inflate(int 1, int 2)
	{
		this.X -= 1;
		this.Y -= 2;
		this.Width += 1 * 2;
		this.Height += 2 * 2;
	}

	// Token: 0x06001B35 RID: 6965 RVA: 0x0006C637 File Offset: 0x0006A837
	public bool Contains(int 1, int 2)
	{
		return this.X <= 1 && 1 < this.X + this.Width && this.Y <= 2 && 2 < this.Y + this.Height;
	}

	// Token: 0x06001B36 RID: 6966 RVA: 0x0006C670 File Offset: 0x0006A870
	public bool Contains(206 1)
	{
		return this.X <= 1.X && 1.X < this.X + this.Width && this.Y <= 1.Y && 1.Y < this.Y + this.Height;
	}

	// Token: 0x06001B37 RID: 6967 RVA: 0x0006C6C8 File Offset: 0x0006A8C8
	public void Contains(ref 206 1, out bool 2)
	{
		2 = (this.X <= 1.X && 1.X < this.X + this.Width && this.Y <= 1.Y && 1.Y < this.Y + this.Height);
	}

	// Token: 0x06001B38 RID: 6968 RVA: 0x0006C720 File Offset: 0x0006A920
	public bool Contains(207 1)
	{
		return this.X <= 1.X && 1.X + 1.Width <= this.X + this.Width && this.Y <= 1.Y && 1.Y + 1.Height <= this.Y + this.Height;
	}

	// Token: 0x06001B39 RID: 6969 RVA: 0x0006C788 File Offset: 0x0006A988
	public void Contains(ref 207 1, out bool 2)
	{
		2 = (this.X <= 1.X && 1.X + 1.Width <= this.X + this.Width && this.Y <= 1.Y && 1.Y + 1.Height <= this.Y + this.Height);
	}

	// Token: 0x06001B3A RID: 6970 RVA: 0x0006C7F4 File Offset: 0x0006A9F4
	public bool Intersects(207 1)
	{
		return 1.X < this.X + this.Width && this.X < 1.X + 1.Width && 1.Y < this.Y + this.Height && this.Y < 1.Y + 1.Height;
	}

	// Token: 0x06001B3B RID: 6971 RVA: 0x0006C858 File Offset: 0x0006AA58
	public void Intersects(ref 207 1, out bool 2)
	{
		2 = (1.X < this.X + this.Width && this.X < 1.X + 1.Width && 1.Y < this.Y + this.Height && this.Y < 1.Y + 1.Height);
	}

	// Token: 0x06001B3C RID: 6972 RVA: 0x0006C8BE File Offset: 0x0006AABE
	public bool Equals(207 1)
	{
		return this.X == 1.X && this.Y == 1.Y && this.Width == 1.Width && this.Height == 1.Height;
	}

	// Token: 0x06001B3D RID: 6973 RVA: 0x0006C8FC File Offset: 0x0006AAFC
	public override bool Equals(object 1)
	{
		bool result = false;
		if (1 is 207)
		{
			result = this.Equals((207)1);
		}
		return result;
	}

	// Token: 0x06001B3E RID: 6974 RVA: 0x0006C924 File Offset: 0x0006AB24
	public override string ToString()
	{
		CultureInfo currentCulture = CultureInfo.CurrentCulture;
		return string.Format(currentCulture, "{{X:{0} Y:{1} Width:{2} Height:{3}}}", new object[]
		{
			this.X.ToString(currentCulture),
			this.Y.ToString(currentCulture),
			this.Width.ToString(currentCulture),
			this.Height.ToString(currentCulture)
		});
	}

	// Token: 0x06001B3F RID: 6975 RVA: 0x0006C984 File Offset: 0x0006AB84
	public override int GetHashCode()
	{
		return this.X.GetHashCode() + this.Y.GetHashCode() + this.Width.GetHashCode() + this.Height.GetHashCode();
	}

	// Token: 0x06001B40 RID: 6976 RVA: 0x0006C8BE File Offset: 0x0006AABE
	public static bool operator ==(207 1, 207 2)
	{
		return 1.X == 2.X && 1.Y == 2.Y && 1.Width == 2.Width && 1.Height == 2.Height;
	}

	// Token: 0x06001B41 RID: 6977 RVA: 0x0006C9B5 File Offset: 0x0006ABB5
	public static bool operator !=(207 1, 207 2)
	{
		return 1.X != 2.X || 1.Y != 2.Y || 1.Width != 2.Width || 1.Height != 2.Height;
	}

	// Token: 0x04000CF3 RID: 3315
	public int X;

	// Token: 0x04000CF4 RID: 3316
	public int Y;

	// Token: 0x04000CF5 RID: 3317
	public int Width;

	// Token: 0x04000CF6 RID: 3318
	public int Height;

	// Token: 0x04000CF7 RID: 3319
	private static 207 Empty;
}
