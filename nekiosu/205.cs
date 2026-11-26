using System;
using System.Globalization;
using System.Runtime.InteropServices;

// Token: 0x02000384 RID: 900
[ComVisible(false)]
[Serializable]
public struct 205 : IEquatable<205>
{
	// Token: 0x06001B0D RID: 6925 RVA: 0x0006B767 File Offset: 0x00069967
	public 205(float 1, float 2, float 3, float 4)
	{
		this.Normal.X = 1;
		this.Normal.Y = 2;
		this.Normal.Z = 3;
		this.D = 4;
	}

	// Token: 0x06001B0E RID: 6926 RVA: 0x0006B795 File Offset: 0x00069995
	public 205(209 1, float 2)
	{
		this.Normal = 1;
		this.D = 2;
	}

	// Token: 0x06001B0F RID: 6927 RVA: 0x0006B7A8 File Offset: 0x000699A8
	public 205(210 1)
	{
		this.Normal.X = 1.X;
		this.Normal.Y = 1.Y;
		this.Normal.Z = 1.Z;
		this.D = 1.W;
	}

	// Token: 0x06001B10 RID: 6928 RVA: 0x0006B7F4 File Offset: 0x000699F4
	public 205(209 1, 209 2, 209 3)
	{
		float num = 2.X - 1.X;
		float num2 = 2.Y - 1.Y;
		float num3 = 2.Z - 1.Z;
		float num4 = 3.X - 1.X;
		float num5 = 3.Y - 1.Y;
		float num6 = 3.Z - 1.Z;
		float num7 = num2 * num6 - num3 * num5;
		float num8 = num3 * num4 - num * num6;
		float num9 = num * num5 - num2 * num4;
		float num10 = num7 * num7 + num8 * num8 + num9 * num9;
		float num11 = 1f / (float)Math.Sqrt((double)num10);
		this.Normal.X = num7 * num11;
		this.Normal.Y = num8 * num11;
		this.Normal.Z = num9 * num11;
		this.D = 0f - (this.Normal.X * 1.X + this.Normal.Y * 1.Y + this.Normal.Z * 1.Z);
	}

	// Token: 0x06001B11 RID: 6929 RVA: 0x0006B910 File Offset: 0x00069B10
	public bool Equals(205 1)
	{
		return this.Normal.X == 1.Normal.X && this.Normal.Y == 1.Normal.Y && this.Normal.Z == 1.Normal.Z && this.D == 1.D;
	}

	// Token: 0x06001B12 RID: 6930 RVA: 0x0006B978 File Offset: 0x00069B78
	public override bool Equals(object 1)
	{
		bool result = false;
		if (1 is 205)
		{
			result = this.Equals((205)1);
		}
		return result;
	}

	// Token: 0x06001B13 RID: 6931 RVA: 0x0006B99D File Offset: 0x00069B9D
	public override int GetHashCode()
	{
		return this.Normal.GetHashCode() + this.D.GetHashCode();
	}

	// Token: 0x06001B14 RID: 6932 RVA: 0x0006B9BC File Offset: 0x00069BBC
	public override string ToString()
	{
		CultureInfo currentCulture = CultureInfo.CurrentCulture;
		return string.Format(currentCulture, "{{Normal:{0} D:{1}}}", new object[]
		{
			this.Normal.ToString(),
			this.D.ToString(currentCulture)
		});
	}

	// Token: 0x06001B15 RID: 6933 RVA: 0x0006BA04 File Offset: 0x00069C04
	public void Normalize()
	{
		float num = this.Normal.X * this.Normal.X + this.Normal.Y * this.Normal.Y + this.Normal.Z * this.Normal.Z;
		if (Math.Abs(num - 1f) >= 1.1920929E-07f)
		{
			float num2 = 1f / (float)Math.Sqrt((double)num);
			this.Normal.X = this.Normal.X * num2;
			this.Normal.Y = this.Normal.Y * num2;
			this.Normal.Z = this.Normal.Z * num2;
			this.D *= num2;
		}
	}

	// Token: 0x06001B16 RID: 6934 RVA: 0x0006BABC File Offset: 0x00069CBC
	public static 205 Normalize(205 1)
	{
		float num = 1.Normal.X * 1.Normal.X + 1.Normal.Y * 1.Normal.Y + 1.Normal.Z * 1.Normal.Z;
		205 result = default(205);
		if (Math.Abs(num - 1f) < 1.1920929E-07f)
		{
			result.Normal = 1.Normal;
			result.D = 1.D;
			return result;
		}
		float num2 = 1f / (float)Math.Sqrt((double)num);
		result.Normal.X = 1.Normal.X * num2;
		result.Normal.Y = 1.Normal.Y * num2;
		result.Normal.Z = 1.Normal.Z * num2;
		result.D = 1.D * num2;
		return result;
	}

	// Token: 0x06001B17 RID: 6935 RVA: 0x0006BBB4 File Offset: 0x00069DB4
	public static void Normalize(ref 205 1, out 205 2)
	{
		float num = 1.Normal.X * 1.Normal.X + 1.Normal.Y * 1.Normal.Y + 1.Normal.Z * 1.Normal.Z;
		if (Math.Abs(num - 1f) < 1.1920929E-07f)
		{
			2.Normal = 1.Normal;
			2.D = 1.D;
			return;
		}
		float num2 = 1f / (float)Math.Sqrt((double)num);
		2.Normal.X = 1.Normal.X * num2;
		2.Normal.Y = 1.Normal.Y * num2;
		2.Normal.Z = 1.Normal.Z * num2;
		2.D = 1.D * num2;
	}

	// Token: 0x06001B18 RID: 6936 RVA: 0x0006BC9C File Offset: 0x00069E9C
	public static 205 Transform(205 1, 202 2)
	{
		202 3;
		202.Invert(ref 2, out 3);
		float x = 1.Normal.X;
		float y = 1.Normal.Y;
		float z = 1.Normal.Z;
		float d = 1.D;
		205 result = default(205);
		result.Normal.X = x * 3.M11 + y * 3.M12 + z * 3.M13 + d * 3.M14;
		result.Normal.Y = x * 3.M21 + y * 3.M22 + z * 3.M23 + d * 3.M24;
		result.Normal.Z = x * 3.M31 + y * 3.M32 + z * 3.M33 + d * 3.M34;
		result.D = x * 3.M41 + y * 3.M42 + z * 3.M43 + d * 3.M44;
		return result;
	}

	// Token: 0x06001B19 RID: 6937 RVA: 0x0006BDA4 File Offset: 0x00069FA4
	public static void Transform(ref 205 1, ref 202 2, out 205 3)
	{
		202 4;
		202.Invert(ref 2, out 4);
		float x = 1.Normal.X;
		float y = 1.Normal.Y;
		float z = 1.Normal.Z;
		float d = 1.D;
		3.Normal.X = x * 4.M11 + y * 4.M12 + z * 4.M13 + d * 4.M14;
		3.Normal.Y = x * 4.M21 + y * 4.M22 + z * 4.M23 + d * 4.M24;
		3.Normal.Z = x * 4.M31 + y * 4.M32 + z * 4.M33 + d * 4.M34;
		3.D = x * 4.M41 + y * 4.M42 + z * 4.M43 + d * 4.M44;
	}

	// Token: 0x06001B1A RID: 6938 RVA: 0x0006BE9C File Offset: 0x0006A09C
	public float Dot(210 1)
	{
		return this.Normal.X * 1.X + this.Normal.Y * 1.Y + this.Normal.Z * 1.Z + this.D * 1.W;
	}

	// Token: 0x06001B1B RID: 6939 RVA: 0x0006BEF0 File Offset: 0x0006A0F0
	public void Dot(ref 210 1, out float 2)
	{
		2 = this.Normal.X * 1.X + this.Normal.Y * 1.Y + this.Normal.Z * 1.Z + this.D * 1.W;
	}

	// Token: 0x06001B1C RID: 6940 RVA: 0x0006BF48 File Offset: 0x0006A148
	public float DotCoordinate(209 1)
	{
		return this.Normal.X * 1.X + this.Normal.Y * 1.Y + this.Normal.Z * 1.Z + this.D;
	}

	// Token: 0x06001B1D RID: 6941 RVA: 0x0006BF94 File Offset: 0x0006A194
	public void DotCoordinate(ref 209 1, out float 2)
	{
		2 = this.Normal.X * 1.X + this.Normal.Y * 1.Y + this.Normal.Z * 1.Z + this.D;
	}

	// Token: 0x06001B1E RID: 6942 RVA: 0x0006BFE2 File Offset: 0x0006A1E2
	public float DotNormal(209 1)
	{
		return this.Normal.X * 1.X + this.Normal.Y * 1.Y + this.Normal.Z * 1.Z;
	}

	// Token: 0x06001B1F RID: 6943 RVA: 0x0006C01C File Offset: 0x0006A21C
	public void DotNormal(ref 209 1, out float 2)
	{
		2 = this.Normal.X * 1.X + this.Normal.Y * 1.Y + this.Normal.Z * 1.Z;
	}

	// Token: 0x06001B20 RID: 6944 RVA: 0x0006C058 File Offset: 0x0006A258
	public 280 Intersects(197 1)
	{
		209 2 = default(209);
		2.X = ((this.Normal.X >= 0f) ? 1.Min.X : 1.Max.X);
		2.Y = ((this.Normal.Y >= 0f) ? 1.Min.Y : 1.Max.Y);
		2.Z = ((this.Normal.Z >= 0f) ? 1.Min.Z : 1.Max.Z);
		209 3 = default(209);
		3.X = ((this.Normal.X >= 0f) ? 1.Max.X : 1.Min.X);
		3.Y = ((this.Normal.Y >= 0f) ? 1.Max.Y : 1.Min.Y);
		3.Z = ((this.Normal.Z >= 0f) ? 1.Max.Z : 1.Min.Z);
		if (this.Normal.X * 2.X + this.Normal.Y * 2.Y + this.Normal.Z * 2.Z + this.D > 0f)
		{
			return (280)0;
		}
		if (this.Normal.X * 3.X + this.Normal.Y * 3.Y + this.Normal.Z * 3.Z + this.D < 0f)
		{
			return (280)1;
		}
		return (280)2;
	}

	// Token: 0x06001B21 RID: 6945 RVA: 0x0006C22C File Offset: 0x0006A42C
	public void Intersects(ref 197 1, out 280 2)
	{
		209 3 = default(209);
		3.X = ((this.Normal.X >= 0f) ? 1.Min.X : 1.Max.X);
		3.Y = ((this.Normal.Y >= 0f) ? 1.Min.Y : 1.Max.Y);
		3.Z = ((this.Normal.Z >= 0f) ? 1.Min.Z : 1.Max.Z);
		209 4 = default(209);
		4.X = ((this.Normal.X >= 0f) ? 1.Max.X : 1.Min.X);
		4.Y = ((this.Normal.Y >= 0f) ? 1.Max.Y : 1.Min.Y);
		4.Z = ((this.Normal.Z >= 0f) ? 1.Max.Z : 1.Min.Z);
		if (this.Normal.X * 3.X + this.Normal.Y * 3.Y + this.Normal.Z * 3.Z + this.D > 0f)
		{
			2 = (280)0;
			return;
		}
		if (this.Normal.X * 4.X + this.Normal.Y * 4.Y + this.Normal.Z * 4.Z + this.D < 0f)
		{
			2 = (280)1;
			return;
		}
		2 = (280)2;
	}

	// Token: 0x06001B22 RID: 6946 RVA: 0x0006C406 File Offset: 0x0006A606
	public static bool operator ==(205 1, 205 2)
	{
		return 1.Equals(2);
	}

	// Token: 0x06001B23 RID: 6947 RVA: 0x0006C410 File Offset: 0x0006A610
	public static bool operator !=(205 1, 205 2)
	{
		return 1.Normal.X != 2.Normal.X || 1.Normal.Y != 2.Normal.Y || 1.Normal.Z != 2.Normal.Z || 1.D != 2.D;
	}

	// Token: 0x04000CEE RID: 3310
	public 209 Normal;

	// Token: 0x04000CEF RID: 3311
	public float D;
}
