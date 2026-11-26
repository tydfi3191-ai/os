using System;
using System.Globalization;
using System.Runtime.InteropServices;

// Token: 0x02000389 RID: 905
[ComVisible(false)]
[Serializable]
public struct 210 : IEquatable<210>
{
	// Token: 0x06001BDA RID: 7130 RVA: 0x0007001E File Offset: 0x0006E21E
	public 210(float 1, float 2, float 3, float 4)
	{
		this.X = 1;
		this.Y = 2;
		this.Z = 3;
		this.W = 4;
	}

	// Token: 0x06001BDB RID: 7131 RVA: 0x0007003D File Offset: 0x0006E23D
	public 210(208 1, float 2, float 3)
	{
		this.X = 1.X;
		this.Y = 1.Y;
		this.Z = 2;
		this.W = 3;
	}

	// Token: 0x06001BDC RID: 7132 RVA: 0x00070065 File Offset: 0x0006E265
	public 210(209 1, float 2)
	{
		this.X = 1.X;
		this.Y = 1.Y;
		this.Z = 1.Z;
		this.W = 2;
	}

	// Token: 0x06001BDD RID: 7133 RVA: 0x00070092 File Offset: 0x0006E292
	public 210(float 1)
	{
		this.W = 1;
		this.Z = 1;
		this.Y = 1;
		this.X = 1;
	}

	// Token: 0x06001BDE RID: 7134 RVA: 0x000700B0 File Offset: 0x0006E2B0
	public static 210 GetZero()
	{
		return 210.Zero;
	}

	// Token: 0x06001BDF RID: 7135 RVA: 0x000700B7 File Offset: 0x0006E2B7
	public static 210 GetOne()
	{
		return 210.One;
	}

	// Token: 0x06001BE0 RID: 7136 RVA: 0x000700BE File Offset: 0x0006E2BE
	public static 210 GetUnitX()
	{
		return 210.UnitX;
	}

	// Token: 0x06001BE1 RID: 7137 RVA: 0x000700C5 File Offset: 0x0006E2C5
	public static 210 GetUnitY()
	{
		return 210.UnitY;
	}

	// Token: 0x06001BE2 RID: 7138 RVA: 0x000700CC File Offset: 0x0006E2CC
	public static 210 GetUnitZ()
	{
		return 210.UnitZ;
	}

	// Token: 0x06001BE3 RID: 7139 RVA: 0x000700D3 File Offset: 0x0006E2D3
	public static 210 GetUnitW()
	{
		return 210.UnitW;
	}

	// Token: 0x06001BE4 RID: 7140 RVA: 0x000700DC File Offset: 0x0006E2DC
	public override string ToString()
	{
		CultureInfo currentCulture = CultureInfo.CurrentCulture;
		return string.Format(currentCulture, "{{X:{0} Y:{1} Z:{2} W:{3}}}", new object[]
		{
			this.X.ToString(currentCulture),
			this.Y.ToString(currentCulture),
			this.Z.ToString(currentCulture),
			this.W.ToString(currentCulture)
		});
	}

	// Token: 0x06001BE5 RID: 7141 RVA: 0x0007013C File Offset: 0x0006E33C
	public bool Equals(210 1)
	{
		return this.X == 1.X && this.Y == 1.Y && this.Z == 1.Z && this.W == 1.W;
	}

	// Token: 0x06001BE6 RID: 7142 RVA: 0x00070178 File Offset: 0x0006E378
	public override bool Equals(object 1)
	{
		bool result = false;
		if (1 is 210)
		{
			result = this.Equals((210)1);
		}
		return result;
	}

	// Token: 0x06001BE7 RID: 7143 RVA: 0x0007019D File Offset: 0x0006E39D
	public override int GetHashCode()
	{
		return this.X.GetHashCode() + this.Y.GetHashCode() + this.Z.GetHashCode() + this.W.GetHashCode();
	}

	// Token: 0x06001BE8 RID: 7144 RVA: 0x000701CE File Offset: 0x0006E3CE
	public float Length()
	{
		return (float)Math.Sqrt((double)(this.X * this.X + this.Y * this.Y + this.Z * this.Z + this.W * this.W));
	}

	// Token: 0x06001BE9 RID: 7145 RVA: 0x0007020E File Offset: 0x0006E40E
	public float LengthSquared()
	{
		return this.X * this.X + this.Y * this.Y + this.Z * this.Z + this.W * this.W;
	}

	// Token: 0x06001BEA RID: 7146 RVA: 0x00070248 File Offset: 0x0006E448
	public static float Distance(210 1, 210 2)
	{
		float num = 1.X - 2.X;
		float num2 = 1.Y - 2.Y;
		float num3 = 1.Z - 2.Z;
		float num4 = 1.W - 2.W;
		return (float)Math.Sqrt((double)(num * num + num2 * num2 + num3 * num3 + num4 * num4));
	}

	// Token: 0x06001BEB RID: 7147 RVA: 0x000702A4 File Offset: 0x0006E4A4
	public static void Distance(ref 210 1, ref 210 2, out float 3)
	{
		float num = 1.X - 2.X;
		float num2 = 1.Y - 2.Y;
		float num3 = 1.Z - 2.Z;
		float num4 = 1.W - 2.W;
		float num5 = num * num + num2 * num2 + num3 * num3 + num4 * num4;
		3 = (float)Math.Sqrt((double)num5);
	}

	// Token: 0x06001BEC RID: 7148 RVA: 0x00070304 File Offset: 0x0006E504
	public static float DistanceSquared(210 1, 210 2)
	{
		float num = 1.X - 2.X;
		float num2 = 1.Y - 2.Y;
		float num3 = 1.Z - 2.Z;
		float num4 = 1.W - 2.W;
		return num * num + num2 * num2 + num3 * num3 + num4 * num4;
	}

	// Token: 0x06001BED RID: 7149 RVA: 0x00070358 File Offset: 0x0006E558
	public static void DistanceSquared(ref 210 1, ref 210 2, out float 3)
	{
		float num = 1.X - 2.X;
		float num2 = 1.Y - 2.Y;
		float num3 = 1.Z - 2.Z;
		float num4 = 1.W - 2.W;
		3 = num * num + num2 * num2 + num3 * num3 + num4 * num4;
	}

	// Token: 0x06001BEE RID: 7150 RVA: 0x000703AE File Offset: 0x0006E5AE
	public static float Dot(210 1, 210 2)
	{
		return 1.X * 2.X + 1.Y * 2.Y + 1.Z * 2.Z + 1.W * 2.W;
	}

	// Token: 0x06001BEF RID: 7151 RVA: 0x000703E7 File Offset: 0x0006E5E7
	public static void Dot(ref 210 1, ref 210 2, out float 3)
	{
		3 = 1.X * 2.X + 1.Y * 2.Y + 1.Z * 2.Z + 1.W * 2.W;
	}

	// Token: 0x06001BF0 RID: 7152 RVA: 0x00070424 File Offset: 0x0006E624
	public void Normalize()
	{
		float num = this.X * this.X + this.Y * this.Y + this.Z * this.Z + this.W * this.W;
		float num2 = 1f / (float)Math.Sqrt((double)num);
		this.X *= num2;
		this.Y *= num2;
		this.Z *= num2;
		this.W *= num2;
	}

	// Token: 0x06001BF1 RID: 7153 RVA: 0x000704B0 File Offset: 0x0006E6B0
	public static 210 Normalize(210 1)
	{
		float num = 1.X * 1.X + 1.Y * 1.Y + 1.Z * 1.Z + 1.W * 1.W;
		float num2 = 1f / (float)Math.Sqrt((double)num);
		return new 210
		{
			X = 1.X * num2,
			Y = 1.Y * num2,
			Z = 1.Z * num2,
			W = 1.W * num2
		};
	}

	// Token: 0x06001BF2 RID: 7154 RVA: 0x0007054C File Offset: 0x0006E74C
	public static void Normalize(ref 210 1, out 210 2)
	{
		float num = 1.X * 1.X + 1.Y * 1.Y + 1.Z * 1.Z + 1.W * 1.W;
		float num2 = 1f / (float)Math.Sqrt((double)num);
		2.X = 1.X * num2;
		2.Y = 1.Y * num2;
		2.Z = 1.Z * num2;
		2.W = 1.W * num2;
	}

	// Token: 0x06001BF3 RID: 7155 RVA: 0x000705D8 File Offset: 0x0006E7D8
	public static 210 Min(210 1, 210 2)
	{
		return new 210
		{
			X = ((1.X < 2.X) ? 1.X : 2.X),
			Y = ((1.Y < 2.Y) ? 1.Y : 2.Y),
			Z = ((1.Z < 2.Z) ? 1.Z : 2.Z),
			W = ((1.W < 2.W) ? 1.W : 2.W)
		};
	}

	// Token: 0x06001BF4 RID: 7156 RVA: 0x0007067C File Offset: 0x0006E87C
	public static void Min(ref 210 1, ref 210 2, out 210 3)
	{
		3.X = ((1.X < 2.X) ? 1.X : 2.X);
		3.Y = ((1.Y < 2.Y) ? 1.Y : 2.Y);
		3.Z = ((1.Z < 2.Z) ? 1.Z : 2.Z);
		3.W = ((1.W < 2.W) ? 1.W : 2.W);
	}

	// Token: 0x06001BF5 RID: 7157 RVA: 0x00070714 File Offset: 0x0006E914
	public static 210 Max(210 1, 210 2)
	{
		return new 210
		{
			X = ((1.X > 2.X) ? 1.X : 2.X),
			Y = ((1.Y > 2.Y) ? 1.Y : 2.Y),
			Z = ((1.Z > 2.Z) ? 1.Z : 2.Z),
			W = ((1.W > 2.W) ? 1.W : 2.W)
		};
	}

	// Token: 0x06001BF6 RID: 7158 RVA: 0x000707B8 File Offset: 0x0006E9B8
	public static void Max(ref 210 1, ref 210 2, out 210 3)
	{
		3.X = ((1.X > 2.X) ? 1.X : 2.X);
		3.Y = ((1.Y > 2.Y) ? 1.Y : 2.Y);
		3.Z = ((1.Z > 2.Z) ? 1.Z : 2.Z);
		3.W = ((1.W > 2.W) ? 1.W : 2.W);
	}

	// Token: 0x06001BF7 RID: 7159 RVA: 0x00070850 File Offset: 0x0006EA50
	public static 210 Clamp(210 1, 210 2, 210 3)
	{
		float num = 1.X;
		num = ((num > 3.X) ? 3.X : num);
		num = ((num < 2.X) ? 2.X : num);
		float num2 = 1.Y;
		num2 = ((num2 > 3.Y) ? 3.Y : num2);
		num2 = ((num2 < 2.Y) ? 2.Y : num2);
		float num3 = 1.Z;
		num3 = ((num3 > 3.Z) ? 3.Z : num3);
		num3 = ((num3 < 2.Z) ? 2.Z : num3);
		float num4 = 1.W;
		num4 = ((num4 > 3.W) ? 3.W : num4);
		num4 = ((num4 < 2.W) ? 2.W : num4);
		return new 210
		{
			X = num,
			Y = num2,
			Z = num3,
			W = num4
		};
	}

	// Token: 0x06001BF8 RID: 7160 RVA: 0x0007093C File Offset: 0x0006EB3C
	public static void Clamp(ref 210 1, ref 210 2, ref 210 3, out 210 4)
	{
		float num = 1.X;
		num = ((num > 3.X) ? 3.X : num);
		num = ((num < 2.X) ? 2.X : num);
		float num2 = 1.Y;
		num2 = ((num2 > 3.Y) ? 3.Y : num2);
		num2 = ((num2 < 2.Y) ? 2.Y : num2);
		float num3 = 1.Z;
		num3 = ((num3 > 3.Z) ? 3.Z : num3);
		num3 = ((num3 < 2.Z) ? 2.Z : num3);
		float num4 = 1.W;
		num4 = ((num4 > 3.W) ? 3.W : num4);
		num4 = ((num4 < 2.W) ? 2.W : num4);
		4.X = num;
		4.Y = num2;
		4.Z = num3;
		4.W = num4;
	}

	// Token: 0x06001BF9 RID: 7161 RVA: 0x00070A1C File Offset: 0x0006EC1C
	public static 210 Lerp(210 1, 210 2, float 3)
	{
		return new 210
		{
			X = 1.X + (2.X - 1.X) * 3,
			Y = 1.Y + (2.Y - 1.Y) * 3,
			Z = 1.Z + (2.Z - 1.Z) * 3,
			W = 1.W + (2.W - 1.W) * 3
		};
	}

	// Token: 0x06001BFA RID: 7162 RVA: 0x00070AA8 File Offset: 0x0006ECA8
	public static void Lerp(ref 210 1, ref 210 2, float 3, out 210 4)
	{
		4.X = 1.X + (2.X - 1.X) * 3;
		4.Y = 1.Y + (2.Y - 1.Y) * 3;
		4.Z = 1.Z + (2.Z - 1.Z) * 3;
		4.W = 1.W + (2.W - 1.W) * 3;
	}

	// Token: 0x06001BFB RID: 7163 RVA: 0x00070B28 File Offset: 0x0006ED28
	public static 210 Barycentric(210 1, 210 2, 210 3, float 4, float 5)
	{
		return new 210
		{
			X = 1.X + 4 * (2.X - 1.X) + 5 * (3.X - 1.X),
			Y = 1.Y + 4 * (2.Y - 1.Y) + 5 * (3.Y - 1.Y),
			Z = 1.Z + 4 * (2.Z - 1.Z) + 5 * (3.Z - 1.Z),
			W = 1.W + 4 * (2.W - 1.W) + 5 * (3.W - 1.W)
		};
	}

	// Token: 0x06001BFC RID: 7164 RVA: 0x00070BF8 File Offset: 0x0006EDF8
	public static void Barycentric(ref 210 1, ref 210 2, ref 210 3, float 4, float 5, out 210 6)
	{
		6.X = 1.X + 4 * (2.X - 1.X) + 5 * (3.X - 1.X);
		6.Y = 1.Y + 4 * (2.Y - 1.Y) + 5 * (3.Y - 1.Y);
		6.Z = 1.Z + 4 * (2.Z - 1.Z) + 5 * (3.Z - 1.Z);
		6.W = 1.W + 4 * (2.W - 1.W) + 5 * (3.W - 1.W);
	}

	// Token: 0x06001BFD RID: 7165 RVA: 0x00070CC0 File Offset: 0x0006EEC0
	public static 210 SmoothStep(210 1, 210 2, float 3)
	{
		3 = ((3 > 1f) ? 1f : ((3 < 0f) ? 0f : 3));
		3 = 3 * 3 * (3f - 2f * 3);
		return new 210
		{
			X = 1.X + (2.X - 1.X) * 3,
			Y = 1.Y + (2.Y - 1.Y) * 3,
			Z = 1.Z + (2.Z - 1.Z) * 3,
			W = 1.W + (2.W - 1.W) * 3
		};
	}

	// Token: 0x06001BFE RID: 7166 RVA: 0x00070D80 File Offset: 0x0006EF80
	public static void SmoothStep(ref 210 1, ref 210 2, float 3, out 210 4)
	{
		3 = ((3 > 1f) ? 1f : ((3 < 0f) ? 0f : 3));
		3 = 3 * 3 * (3f - 2f * 3);
		4.X = 1.X + (2.X - 1.X) * 3;
		4.Y = 1.Y + (2.Y - 1.Y) * 3;
		4.Z = 1.Z + (2.Z - 1.Z) * 3;
		4.W = 1.W + (2.W - 1.W) * 3;
	}

	// Token: 0x06001BFF RID: 7167 RVA: 0x00070E34 File Offset: 0x0006F034
	public static 210 CatmullRom(210 1, 210 2, 210 3, 210 4, float 5)
	{
		float num = 5 * 5;
		float num2 = 5 * num;
		return new 210
		{
			X = 0.5f * (2f * 2.X + (0f - 1.X + 3.X) * 5 + (2f * 1.X - 5f * 2.X + 4f * 3.X - 4.X) * num + (0f - 1.X + 3f * 2.X - 3f * 3.X + 4.X) * num2),
			Y = 0.5f * (2f * 2.Y + (0f - 1.Y + 3.Y) * 5 + (2f * 1.Y - 5f * 2.Y + 4f * 3.Y - 4.Y) * num + (0f - 1.Y + 3f * 2.Y - 3f * 3.Y + 4.Y) * num2),
			Z = 0.5f * (2f * 2.Z + (0f - 1.Z + 3.Z) * 5 + (2f * 1.Z - 5f * 2.Z + 4f * 3.Z - 4.Z) * num + (0f - 1.Z + 3f * 2.Z - 3f * 3.Z + 4.Z) * num2),
			W = 0.5f * (2f * 2.W + (0f - 1.W + 3.W) * 5 + (2f * 1.W - 5f * 2.W + 4f * 3.W - 4.W) * num + (0f - 1.W + 3f * 2.W - 3f * 3.W + 4.W) * num2)
		};
	}

	// Token: 0x06001C00 RID: 7168 RVA: 0x00071098 File Offset: 0x0006F298
	public static void CatmullRom(ref 210 1, ref 210 2, ref 210 3, ref 210 4, float 5, out 210 6)
	{
		float num = 5 * 5;
		float num2 = 5 * num;
		6.X = 0.5f * (2f * 2.X + (0f - 1.X + 3.X) * 5 + (2f * 1.X - 5f * 2.X + 4f * 3.X - 4.X) * num + (0f - 1.X + 3f * 2.X - 3f * 3.X + 4.X) * num2);
		6.Y = 0.5f * (2f * 2.Y + (0f - 1.Y + 3.Y) * 5 + (2f * 1.Y - 5f * 2.Y + 4f * 3.Y - 4.Y) * num + (0f - 1.Y + 3f * 2.Y - 3f * 3.Y + 4.Y) * num2);
		6.Z = 0.5f * (2f * 2.Z + (0f - 1.Z + 3.Z) * 5 + (2f * 1.Z - 5f * 2.Z + 4f * 3.Z - 4.Z) * num + (0f - 1.Z + 3f * 2.Z - 3f * 3.Z + 4.Z) * num2);
		6.W = 0.5f * (2f * 2.W + (0f - 1.W + 3.W) * 5 + (2f * 1.W - 5f * 2.W + 4f * 3.W - 4.W) * num + (0f - 1.W + 3f * 2.W - 3f * 3.W + 4.W) * num2);
	}

	// Token: 0x06001C01 RID: 7169 RVA: 0x000712F0 File Offset: 0x0006F4F0
	public static 210 Hermite(210 1, 210 2, 210 3, 210 4, float 5)
	{
		float num = 5 * 5;
		float num2 = 5 * num;
		float num3 = 2f * num2 - 3f * num + 1f;
		float num4 = -2f * num2 + 3f * num;
		float num5 = num2 - 2f * num + 5;
		float num6 = num2 - num;
		return new 210
		{
			X = 1.X * num3 + 3.X * num4 + 2.X * num5 + 4.X * num6,
			Y = 1.Y * num3 + 3.Y * num4 + 2.Y * num5 + 4.Y * num6,
			Z = 1.Z * num3 + 3.Z * num4 + 2.Z * num5 + 4.Z * num6,
			W = 1.W * num3 + 3.W * num4 + 2.W * num5 + 4.W * num6
		};
	}

	// Token: 0x06001C02 RID: 7170 RVA: 0x000713FC File Offset: 0x0006F5FC
	public static void Hermite(ref 210 1, ref 210 2, ref 210 3, ref 210 4, float 5, out 210 6)
	{
		float num = 5 * 5;
		float num2 = 5 * num;
		float num3 = 2f * num2 - 3f * num + 1f;
		float num4 = -2f * num2 + 3f * num;
		float num5 = num2 - 2f * num + 5;
		float num6 = num2 - num;
		6.X = 1.X * num3 + 3.X * num4 + 2.X * num5 + 4.X * num6;
		6.Y = 1.Y * num3 + 3.Y * num4 + 2.Y * num5 + 4.Y * num6;
		6.Z = 1.Z * num3 + 3.Z * num4 + 2.Z * num5 + 4.Z * num6;
		6.W = 1.W * num3 + 3.W * num4 + 2.W * num5 + 4.W * num6;
	}

	// Token: 0x06001C03 RID: 7171 RVA: 0x00071500 File Offset: 0x0006F700
	public static 210 Transform(208 1, 202 2)
	{
		float x = 1.X * 2.M11 + 1.Y * 2.M21 + 2.M41;
		float y = 1.X * 2.M12 + 1.Y * 2.M22 + 2.M42;
		float z = 1.X * 2.M13 + 1.Y * 2.M23 + 2.M43;
		float w = 1.X * 2.M14 + 1.Y * 2.M24 + 2.M44;
		return new 210
		{
			X = x,
			Y = y,
			Z = z,
			W = w
		};
	}

	// Token: 0x06001C04 RID: 7172 RVA: 0x000715C4 File Offset: 0x0006F7C4
	public static void Transform(ref 208 1, ref 202 2, out 210 3)
	{
		float x = 1.X * 2.M11 + 1.Y * 2.M21 + 2.M41;
		float y = 1.X * 2.M12 + 1.Y * 2.M22 + 2.M42;
		float z = 1.X * 2.M13 + 1.Y * 2.M23 + 2.M43;
		float w = 1.X * 2.M14 + 1.Y * 2.M24 + 2.M44;
		3.X = x;
		3.Y = y;
		3.Z = z;
		3.W = w;
	}

	// Token: 0x06001C05 RID: 7173 RVA: 0x0007167C File Offset: 0x0006F87C
	public static 210 Transform(209 1, 202 2)
	{
		float x = 1.X * 2.M11 + 1.Y * 2.M21 + 1.Z * 2.M31 + 2.M41;
		float y = 1.X * 2.M12 + 1.Y * 2.M22 + 1.Z * 2.M32 + 2.M42;
		float z = 1.X * 2.M13 + 1.Y * 2.M23 + 1.Z * 2.M33 + 2.M43;
		float w = 1.X * 2.M14 + 1.Y * 2.M24 + 1.Z * 2.M34 + 2.M44;
		return new 210
		{
			X = x,
			Y = y,
			Z = z,
			W = w
		};
	}

	// Token: 0x06001C06 RID: 7174 RVA: 0x00071778 File Offset: 0x0006F978
	public static void Transform(ref 209 1, ref 202 2, out 210 3)
	{
		float x = 1.X * 2.M11 + 1.Y * 2.M21 + 1.Z * 2.M31 + 2.M41;
		float y = 1.X * 2.M12 + 1.Y * 2.M22 + 1.Z * 2.M32 + 2.M42;
		float z = 1.X * 2.M13 + 1.Y * 2.M23 + 1.Z * 2.M33 + 2.M43;
		float w = 1.X * 2.M14 + 1.Y * 2.M24 + 1.Z * 2.M34 + 2.M44;
		3.X = x;
		3.Y = y;
		3.Z = z;
		3.W = w;
	}

	// Token: 0x06001C07 RID: 7175 RVA: 0x00071868 File Offset: 0x0006FA68
	public static 210 Transform(210 1, 202 2)
	{
		float x = 1.X * 2.M11 + 1.Y * 2.M21 + 1.Z * 2.M31 + 1.W * 2.M41;
		float y = 1.X * 2.M12 + 1.Y * 2.M22 + 1.Z * 2.M32 + 1.W * 2.M42;
		float z = 1.X * 2.M13 + 1.Y * 2.M23 + 1.Z * 2.M33 + 1.W * 2.M43;
		float w = 1.X * 2.M14 + 1.Y * 2.M24 + 1.Z * 2.M34 + 1.W * 2.M44;
		return new 210
		{
			X = x,
			Y = y,
			Z = z,
			W = w
		};
	}

	// Token: 0x06001C08 RID: 7176 RVA: 0x00071980 File Offset: 0x0006FB80
	public static void Transform(ref 210 1, ref 202 2, out 210 3)
	{
		float x = 1.X * 2.M11 + 1.Y * 2.M21 + 1.Z * 2.M31 + 1.W * 2.M41;
		float y = 1.X * 2.M12 + 1.Y * 2.M22 + 1.Z * 2.M32 + 1.W * 2.M42;
		float z = 1.X * 2.M13 + 1.Y * 2.M23 + 1.Z * 2.M33 + 1.W * 2.M43;
		float w = 1.X * 2.M14 + 1.Y * 2.M24 + 1.Z * 2.M34 + 1.W * 2.M44;
		3.X = x;
		3.Y = y;
		3.Z = z;
		3.W = w;
	}

	// Token: 0x06001C09 RID: 7177 RVA: 0x00071A8C File Offset: 0x0006FC8C
	public static void Transform(210[] 1, ref 202 2, 210[] 3)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("values");
		}
		if (3 == null)
		{
			throw new ArgumentNullException("results");
		}
		if (3.Length < 1.Length)
		{
			throw new IndexOutOfRangeException(195.GetNotEnoughTargetSizeMessage());
		}
		for (int i = 0; i < 1.Length; i++)
		{
			float x = 1[i].X;
			float y = 1[i].Y;
			float z = 1[i].Z;
			float w = 1[i].W;
			3[i].X = x * 2.M11 + y * 2.M21 + z * 2.M31 + w * 2.M41;
			3[i].Y = x * 2.M12 + y * 2.M22 + z * 2.M32 + w * 2.M42;
			3[i].Z = x * 2.M13 + y * 2.M23 + z * 2.M33 + w * 2.M43;
			3[i].W = x * 2.M14 + y * 2.M24 + z * 2.M34 + w * 2.M44;
		}
	}

	// Token: 0x06001C0A RID: 7178 RVA: 0x00071BD4 File Offset: 0x0006FDD4
	public static void Transform(210[] 1, int 2, ref 202 3, 210[] 4, int 5, int 6)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("values");
		}
		if (4 == null)
		{
			throw new ArgumentNullException("results");
		}
		if ((long)1.Length < (long)2 + (long)6)
		{
			throw new IndexOutOfRangeException(195.GetNotEnoughSourceSizeMessage());
		}
		if ((long)4.Length < (long)5 + (long)6)
		{
			throw new IndexOutOfRangeException(195.GetNotEnoughTargetSizeMessage());
		}
		while (6 > 0)
		{
			float x = 1[2].X;
			float y = 1[2].Y;
			float z = 1[2].Z;
			float w = 1[2].W;
			4[5].X = x * 3.M11 + y * 3.M21 + z * 3.M31 + w * 3.M41;
			4[5].Y = x * 3.M12 + y * 3.M22 + z * 3.M32 + w * 3.M42;
			4[5].Z = x * 3.M13 + y * 3.M23 + z * 3.M33 + w * 3.M43;
			4[5].W = x * 3.M14 + y * 3.M24 + z * 3.M34 + w * 3.M44;
			2++;
			5++;
			6--;
		}
	}

	// Token: 0x06001C0B RID: 7179 RVA: 0x00071D3C File Offset: 0x0006FF3C
	public static 210 Negate(210 1)
	{
		return new 210
		{
			X = 0f - 1.X,
			Y = 0f - 1.Y,
			Z = 0f - 1.Z,
			W = 0f - 1.W
		};
	}

	// Token: 0x06001C0C RID: 7180 RVA: 0x00071DA0 File Offset: 0x0006FFA0
	public static void Negate(ref 210 1, out 210 2)
	{
		2.X = 0f - 1.X;
		2.Y = 0f - 1.Y;
		2.Z = 0f - 1.Z;
		2.W = 0f - 1.W;
	}

	// Token: 0x06001C0D RID: 7181 RVA: 0x00071DF8 File Offset: 0x0006FFF8
	public static 210 Add(210 1, 210 2)
	{
		return new 210
		{
			X = 1.X + 2.X,
			Y = 1.Y + 2.Y,
			Z = 1.Z + 2.Z,
			W = 1.W + 2.W
		};
	}

	// Token: 0x06001C0E RID: 7182 RVA: 0x00071E60 File Offset: 0x00070060
	public static void Add(ref 210 1, ref 210 2, out 210 3)
	{
		3.X = 1.X + 2.X;
		3.Y = 1.Y + 2.Y;
		3.Z = 1.Z + 2.Z;
		3.W = 1.W + 2.W;
	}

	// Token: 0x06001C0F RID: 7183 RVA: 0x00071EBC File Offset: 0x000700BC
	public static 210 Subtract(210 1, 210 2)
	{
		return new 210
		{
			X = 1.X - 2.X,
			Y = 1.Y - 2.Y,
			Z = 1.Z - 2.Z,
			W = 1.W - 2.W
		};
	}

	// Token: 0x06001C10 RID: 7184 RVA: 0x00071F24 File Offset: 0x00070124
	public static void Subtract(ref 210 1, ref 210 2, out 210 3)
	{
		3.X = 1.X - 2.X;
		3.Y = 1.Y - 2.Y;
		3.Z = 1.Z - 2.Z;
		3.W = 1.W - 2.W;
	}

	// Token: 0x06001C11 RID: 7185 RVA: 0x00071F80 File Offset: 0x00070180
	public static 210 Multiply(210 1, 210 2)
	{
		return new 210
		{
			X = 1.X * 2.X,
			Y = 1.Y * 2.Y,
			Z = 1.Z * 2.Z,
			W = 1.W * 2.W
		};
	}

	// Token: 0x06001C12 RID: 7186 RVA: 0x00071FE8 File Offset: 0x000701E8
	public static void Multiply(ref 210 1, ref 210 2, out 210 3)
	{
		3.X = 1.X * 2.X;
		3.Y = 1.Y * 2.Y;
		3.Z = 1.Z * 2.Z;
		3.W = 1.W * 2.W;
	}

	// Token: 0x06001C13 RID: 7187 RVA: 0x00072044 File Offset: 0x00070244
	public static 210 Multiply(210 1, float 2)
	{
		return new 210
		{
			X = 1.X * 2,
			Y = 1.Y * 2,
			Z = 1.Z * 2,
			W = 1.W * 2
		};
	}

	// Token: 0x06001C14 RID: 7188 RVA: 0x00072096 File Offset: 0x00070296
	public static void Multiply(ref 210 1, float 2, out 210 3)
	{
		3.X = 1.X * 2;
		3.Y = 1.Y * 2;
		3.Z = 1.Z * 2;
		3.W = 1.W * 2;
	}

	// Token: 0x06001C15 RID: 7189 RVA: 0x000720D0 File Offset: 0x000702D0
	public static 210 Divide(210 1, 210 2)
	{
		return new 210
		{
			X = 1.X / 2.X,
			Y = 1.Y / 2.Y,
			Z = 1.Z / 2.Z,
			W = 1.W / 2.W
		};
	}

	// Token: 0x06001C16 RID: 7190 RVA: 0x00072138 File Offset: 0x00070338
	public static void Divide(ref 210 1, ref 210 2, out 210 3)
	{
		3.X = 1.X / 2.X;
		3.Y = 1.Y / 2.Y;
		3.Z = 1.Z / 2.Z;
		3.W = 1.W / 2.W;
	}

	// Token: 0x06001C17 RID: 7191 RVA: 0x00072194 File Offset: 0x00070394
	public static 210 Divide(210 1, float 2)
	{
		float num = 1f / 2;
		return new 210
		{
			X = 1.X * num,
			Y = 1.Y * num,
			Z = 1.Z * num,
			W = 1.W * num
		};
	}

	// Token: 0x06001C18 RID: 7192 RVA: 0x000721F0 File Offset: 0x000703F0
	public static void Divide(ref 210 1, float 2, out 210 3)
	{
		float num = 1f / 2;
		3.X = 1.X * num;
		3.Y = 1.Y * num;
		3.Z = 1.Z * num;
		3.W = 1.W * num;
	}

	// Token: 0x06001C19 RID: 7193 RVA: 0x00072240 File Offset: 0x00070440
	public static 210 operator -(210 1)
	{
		return new 210
		{
			X = 0f - 1.X,
			Y = 0f - 1.Y,
			Z = 0f - 1.Z,
			W = 0f - 1.W
		};
	}

	// Token: 0x06001C1A RID: 7194 RVA: 0x0007013C File Offset: 0x0006E33C
	public static bool operator ==(210 1, 210 2)
	{
		return 1.X == 2.X && 1.Y == 2.Y && 1.Z == 2.Z && 1.W == 2.W;
	}

	// Token: 0x06001C1B RID: 7195 RVA: 0x000722A2 File Offset: 0x000704A2
	public static bool operator !=(210 1, 210 2)
	{
		return 1.X != 2.X || 1.Y != 2.Y || 1.Z != 2.Z || 1.W != 2.W;
	}

	// Token: 0x06001C1C RID: 7196 RVA: 0x000722E4 File Offset: 0x000704E4
	public static 210 operator +(210 1, 210 2)
	{
		return new 210
		{
			X = 1.X + 2.X,
			Y = 1.Y + 2.Y,
			Z = 1.Z + 2.Z,
			W = 1.W + 2.W
		};
	}

	// Token: 0x06001C1D RID: 7197 RVA: 0x0007234C File Offset: 0x0007054C
	public static 210 operator -(210 1, 210 2)
	{
		return new 210
		{
			X = 1.X - 2.X,
			Y = 1.Y - 2.Y,
			Z = 1.Z - 2.Z,
			W = 1.W - 2.W
		};
	}

	// Token: 0x06001C1E RID: 7198 RVA: 0x000723B4 File Offset: 0x000705B4
	public static 210 operator *(210 1, 210 2)
	{
		return new 210
		{
			X = 1.X * 2.X,
			Y = 1.Y * 2.Y,
			Z = 1.Z * 2.Z,
			W = 1.W * 2.W
		};
	}

	// Token: 0x06001C1F RID: 7199 RVA: 0x0007241C File Offset: 0x0007061C
	public static 210 operator *(210 1, float 2)
	{
		return new 210
		{
			X = 1.X * 2,
			Y = 1.Y * 2,
			Z = 1.Z * 2,
			W = 1.W * 2
		};
	}

	// Token: 0x06001C20 RID: 7200 RVA: 0x00072470 File Offset: 0x00070670
	public static 210 operator *(float 1, 210 2)
	{
		return new 210
		{
			X = 2.X * 1,
			Y = 2.Y * 1,
			Z = 2.Z * 1,
			W = 2.W * 1
		};
	}

	// Token: 0x06001C21 RID: 7201 RVA: 0x000724C4 File Offset: 0x000706C4
	public static 210 operator /(210 1, 210 2)
	{
		return new 210
		{
			X = 1.X / 2.X,
			Y = 1.Y / 2.Y,
			Z = 1.Z / 2.Z,
			W = 1.W / 2.W
		};
	}

	// Token: 0x06001C22 RID: 7202 RVA: 0x0007252C File Offset: 0x0007072C
	public static 210 operator /(210 1, float 2)
	{
		float num = 1f / 2;
		return new 210
		{
			X = 1.X * num,
			Y = 1.Y * num,
			Z = 1.Z * num,
			W = 1.W * num
		};
	}

	// Token: 0x04000D0C RID: 3340
	public float X;

	// Token: 0x04000D0D RID: 3341
	public float Y;

	// Token: 0x04000D0E RID: 3342
	public float Z;

	// Token: 0x04000D0F RID: 3343
	public float W;

	// Token: 0x04000D10 RID: 3344
	private static 210 Zero = default(210);

	// Token: 0x04000D11 RID: 3345
	private static 210 One = new 210(1f, 1f, 1f, 1f);

	// Token: 0x04000D12 RID: 3346
	private static 210 UnitX = new 210(1f, 0f, 0f, 0f);

	// Token: 0x04000D13 RID: 3347
	private static 210 UnitY = new 210(0f, 1f, 0f, 0f);

	// Token: 0x04000D14 RID: 3348
	private static 210 UnitZ = new 210(0f, 0f, 1f, 0f);

	// Token: 0x04000D15 RID: 3349
	private static 210 UnitW = new 210(0f, 0f, 0f, 1f);
}
