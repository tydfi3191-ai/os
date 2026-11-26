using System;
using System.Globalization;
using System.Runtime.InteropServices;

// Token: 0x02000388 RID: 904
[ComVisible(false)]
[Serializable]
public struct 209 : IEquatable<209>
{
	// Token: 0x1700013F RID: 319
	// (get) Token: 0x06001B88 RID: 7048 RVA: 0x0006DF30 File Offset: 0x0006C130
	public static 209 Zero
	{
		get
		{
			return 209.zeroValue;
		}
	}

	// Token: 0x17000140 RID: 320
	// (get) Token: 0x06001B89 RID: 7049 RVA: 0x0006DF37 File Offset: 0x0006C137
	public static 209 One
	{
		get
		{
			return 209.oneValue;
		}
	}

	// Token: 0x17000141 RID: 321
	// (get) Token: 0x06001B8A RID: 7050 RVA: 0x0006DF3E File Offset: 0x0006C13E
	public static 209 UnitX
	{
		get
		{
			return 209.unitXValue;
		}
	}

	// Token: 0x17000142 RID: 322
	// (get) Token: 0x06001B8B RID: 7051 RVA: 0x0006DF45 File Offset: 0x0006C145
	public static 209 UnitY
	{
		get
		{
			return 209.unitYValue;
		}
	}

	// Token: 0x17000143 RID: 323
	// (get) Token: 0x06001B8C RID: 7052 RVA: 0x0006DF4C File Offset: 0x0006C14C
	public static 209 UnitZ
	{
		get
		{
			return 209.unitZValue;
		}
	}

	// Token: 0x17000144 RID: 324
	// (get) Token: 0x06001B8D RID: 7053 RVA: 0x0006DF53 File Offset: 0x0006C153
	public static 209 Up
	{
		get
		{
			return 209.upValue;
		}
	}

	// Token: 0x17000145 RID: 325
	// (get) Token: 0x06001B8E RID: 7054 RVA: 0x0006DF5A File Offset: 0x0006C15A
	public static 209 Down
	{
		get
		{
			return 209.downValue;
		}
	}

	// Token: 0x17000146 RID: 326
	// (get) Token: 0x06001B8F RID: 7055 RVA: 0x0006DF61 File Offset: 0x0006C161
	public static 209 Right
	{
		get
		{
			return 209.rightValue;
		}
	}

	// Token: 0x17000147 RID: 327
	// (get) Token: 0x06001B90 RID: 7056 RVA: 0x0006DF68 File Offset: 0x0006C168
	public static 209 Left
	{
		get
		{
			return 209.leftValue;
		}
	}

	// Token: 0x17000148 RID: 328
	// (get) Token: 0x06001B91 RID: 7057 RVA: 0x0006DF6F File Offset: 0x0006C16F
	public static 209 Forward
	{
		get
		{
			return 209.forwardValue;
		}
	}

	// Token: 0x17000149 RID: 329
	// (get) Token: 0x06001B92 RID: 7058 RVA: 0x0006DF76 File Offset: 0x0006C176
	public static 209 Backward
	{
		get
		{
			return 209.backwardValue;
		}
	}

	// Token: 0x06001B93 RID: 7059 RVA: 0x0006DF7D File Offset: 0x0006C17D
	public 209(float 1, float 2, float 3)
	{
		this.X = 1;
		this.Y = 2;
		this.Z = 3;
	}

	// Token: 0x06001B94 RID: 7060 RVA: 0x0006DF94 File Offset: 0x0006C194
	public 209(float 1)
	{
		this.Z = 1;
		this.Y = 1;
		this.X = 1;
	}

	// Token: 0x06001B95 RID: 7061 RVA: 0x0006DFAB File Offset: 0x0006C1AB
	public 209(208 1, float 2)
	{
		this.X = 1.X;
		this.Y = 1.Y;
		this.Z = 2;
	}

	// Token: 0x06001B96 RID: 7062 RVA: 0x0006DFCC File Offset: 0x0006C1CC
	public override string ToString()
	{
		CultureInfo currentCulture = CultureInfo.CurrentCulture;
		return string.Format(currentCulture, "{{X:{0} Y:{1} Z:{2}}}", new object[]
		{
			this.X.ToString(currentCulture),
			this.Y.ToString(currentCulture),
			this.Z.ToString(currentCulture)
		});
	}

	// Token: 0x06001B97 RID: 7063 RVA: 0x0006E01D File Offset: 0x0006C21D
	public bool Equals(209 1)
	{
		return this.X == 1.X && this.Y == 1.Y && this.Z == 1.Z;
	}

	// Token: 0x06001B98 RID: 7064 RVA: 0x0006E04C File Offset: 0x0006C24C
	public override bool Equals(object 1)
	{
		bool result = false;
		if (1 is 209)
		{
			result = this.Equals((209)1);
		}
		return result;
	}

	// Token: 0x06001B99 RID: 7065 RVA: 0x0006E071 File Offset: 0x0006C271
	public override int GetHashCode()
	{
		return this.X.GetHashCode() + this.Y.GetHashCode() + this.Z.GetHashCode();
	}

	// Token: 0x06001B9A RID: 7066 RVA: 0x0006E096 File Offset: 0x0006C296
	public float Length()
	{
		return (float)Math.Sqrt((double)(this.X * this.X + this.Y * this.Y + this.Z * this.Z));
	}

	// Token: 0x06001B9B RID: 7067 RVA: 0x0006E0C8 File Offset: 0x0006C2C8
	public float LengthSquared()
	{
		return this.X * this.X + this.Y * this.Y + this.Z * this.Z;
	}

	// Token: 0x06001B9C RID: 7068 RVA: 0x0006E0F4 File Offset: 0x0006C2F4
	public static float Distance(209 1, 209 2)
	{
		float num = 1.X - 2.X;
		float num2 = 1.Y - 2.Y;
		float num3 = 1.Z - 2.Z;
		return (float)Math.Sqrt((double)(num * num + num2 * num2 + num3 * num3));
	}

	// Token: 0x06001B9D RID: 7069 RVA: 0x0006E13C File Offset: 0x0006C33C
	public static void Distance(ref 209 1, ref 209 2, out float 3)
	{
		float num = 1.X - 2.X;
		float num2 = 1.Y - 2.Y;
		float num3 = 1.Z - 2.Z;
		float num4 = num * num + num2 * num2 + num3 * num3;
		3 = (float)Math.Sqrt((double)num4);
	}

	// Token: 0x06001B9E RID: 7070 RVA: 0x0006E188 File Offset: 0x0006C388
	public static float DistanceSquared(209 1, 209 2)
	{
		float num = 1.X - 2.X;
		float num2 = 1.Y - 2.Y;
		float num3 = 1.Z - 2.Z;
		return num * num + num2 * num2 + num3 * num3;
	}

	// Token: 0x06001B9F RID: 7071 RVA: 0x0006E1C8 File Offset: 0x0006C3C8
	public static void DistanceSquared(ref 209 1, ref 209 2, out float 3)
	{
		float num = 1.X - 2.X;
		float num2 = 1.Y - 2.Y;
		float num3 = 1.Z - 2.Z;
		3 = num * num + num2 * num2 + num3 * num3;
	}

	// Token: 0x06001BA0 RID: 7072 RVA: 0x0006E20C File Offset: 0x0006C40C
	public static float Dot(209 1, 209 2)
	{
		return 1.X * 2.X + 1.Y * 2.Y + 1.Z * 2.Z;
	}

	// Token: 0x06001BA1 RID: 7073 RVA: 0x0006E237 File Offset: 0x0006C437
	public static void Dot(ref 209 1, ref 209 2, out float 3)
	{
		3 = 1.X * 2.X + 1.Y * 2.Y + 1.Z * 2.Z;
	}

	// Token: 0x06001BA2 RID: 7074 RVA: 0x0006E264 File Offset: 0x0006C464
	public void Normalize()
	{
		float num = this.X * this.X + this.Y * this.Y + this.Z * this.Z;
		float num2 = 1f / (float)Math.Sqrt((double)num);
		this.X *= num2;
		this.Y *= num2;
		this.Z *= num2;
	}

	// Token: 0x06001BA3 RID: 7075 RVA: 0x0006E2D4 File Offset: 0x0006C4D4
	public static 209 Normalize(209 1)
	{
		float num = 1.X * 1.X + 1.Y * 1.Y + 1.Z * 1.Z;
		float num2 = 1f / (float)Math.Sqrt((double)num);
		return new 209
		{
			X = 1.X * num2,
			Y = 1.Y * num2,
			Z = 1.Z * num2
		};
	}

	// Token: 0x06001BA4 RID: 7076 RVA: 0x0006E350 File Offset: 0x0006C550
	public static void Normalize(ref 209 1, out 209 2)
	{
		float num = 1.X * 1.X + 1.Y * 1.Y + 1.Z * 1.Z;
		float num2 = 1f / (float)Math.Sqrt((double)num);
		2.X = 1.X * num2;
		2.Y = 1.Y * num2;
		2.Z = 1.Z * num2;
	}

	// Token: 0x06001BA5 RID: 7077 RVA: 0x0006E3C0 File Offset: 0x0006C5C0
	public static 209 Cross(209 1, 209 2)
	{
		return new 209
		{
			X = 1.Y * 2.Z - 1.Z * 2.Y,
			Y = 1.Z * 2.X - 1.X * 2.Z,
			Z = 1.X * 2.Y - 1.Y * 2.X
		};
	}

	// Token: 0x06001BA6 RID: 7078 RVA: 0x0006E43C File Offset: 0x0006C63C
	public static void Cross(ref 209 1, ref 209 2, out 209 3)
	{
		float x = 1.Y * 2.Z - 1.Z * 2.Y;
		float y = 1.Z * 2.X - 1.X * 2.Z;
		float z = 1.X * 2.Y - 1.Y * 2.X;
		3.X = x;
		3.Y = y;
		3.Z = z;
	}

	// Token: 0x06001BA7 RID: 7079 RVA: 0x0006E4B4 File Offset: 0x0006C6B4
	public static 209 Reflect(209 1, 209 2)
	{
		float num = 1.X * 2.X + 1.Y * 2.Y + 1.Z * 2.Z;
		return new 209
		{
			X = 1.X - 2f * num * 2.X,
			Y = 1.Y - 2f * num * 2.Y,
			Z = 1.Z - 2f * num * 2.Z
		};
	}

	// Token: 0x06001BA8 RID: 7080 RVA: 0x0006E548 File Offset: 0x0006C748
	public static void Reflect(ref 209 1, ref 209 2, out 209 3)
	{
		float num = 1.X * 2.X + 1.Y * 2.Y + 1.Z * 2.Z;
		3.X = 1.X - 2f * num * 2.X;
		3.Y = 1.Y - 2f * num * 2.Y;
		3.Z = 1.Z - 2f * num * 2.Z;
	}

	// Token: 0x06001BA9 RID: 7081 RVA: 0x0006E5D0 File Offset: 0x0006C7D0
	public static 209 Min(209 1, 209 2)
	{
		return new 209
		{
			X = ((1.X < 2.X) ? 1.X : 2.X),
			Y = ((1.Y < 2.Y) ? 1.Y : 2.Y),
			Z = ((1.Z < 2.Z) ? 1.Z : 2.Z)
		};
	}

	// Token: 0x06001BAA RID: 7082 RVA: 0x0006E650 File Offset: 0x0006C850
	public static void Min(ref 209 1, ref 209 2, out 209 3)
	{
		3.X = ((1.X < 2.X) ? 1.X : 2.X);
		3.Y = ((1.Y < 2.Y) ? 1.Y : 2.Y);
		3.Z = ((1.Z < 2.Z) ? 1.Z : 2.Z);
	}

	// Token: 0x06001BAB RID: 7083 RVA: 0x0006E6C4 File Offset: 0x0006C8C4
	public static 209 Max(209 1, 209 2)
	{
		return new 209
		{
			X = ((1.X > 2.X) ? 1.X : 2.X),
			Y = ((1.Y > 2.Y) ? 1.Y : 2.Y),
			Z = ((1.Z > 2.Z) ? 1.Z : 2.Z)
		};
	}

	// Token: 0x06001BAC RID: 7084 RVA: 0x0006E744 File Offset: 0x0006C944
	public static void Max(ref 209 1, ref 209 2, out 209 3)
	{
		3.X = ((1.X > 2.X) ? 1.X : 2.X);
		3.Y = ((1.Y > 2.Y) ? 1.Y : 2.Y);
		3.Z = ((1.Z > 2.Z) ? 1.Z : 2.Z);
	}

	// Token: 0x06001BAD RID: 7085 RVA: 0x0006E7B8 File Offset: 0x0006C9B8
	public static 209 Clamp(209 1, 209 2, 209 3)
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
		return new 209
		{
			X = num,
			Y = num2,
			Z = num3
		};
	}

	// Token: 0x06001BAE RID: 7086 RVA: 0x0006E870 File Offset: 0x0006CA70
	public static void Clamp(ref 209 1, ref 209 2, ref 209 3, out 209 4)
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
		4.X = num;
		4.Y = num2;
		4.Z = num3;
	}

	// Token: 0x06001BAF RID: 7087 RVA: 0x0006E91C File Offset: 0x0006CB1C
	public static 209 Lerp(209 1, 209 2, float 3)
	{
		return new 209
		{
			X = 1.X + (2.X - 1.X) * 3,
			Y = 1.Y + (2.Y - 1.Y) * 3,
			Z = 1.Z + (2.Z - 1.Z) * 3
		};
	}

	// Token: 0x06001BB0 RID: 7088 RVA: 0x0006E98C File Offset: 0x0006CB8C
	public static void Lerp(ref 209 1, ref 209 2, float 3, out 209 4)
	{
		4.X = 1.X + (2.X - 1.X) * 3;
		4.Y = 1.Y + (2.Y - 1.Y) * 3;
		4.Z = 1.Z + (2.Z - 1.Z) * 3;
	}

	// Token: 0x06001BB1 RID: 7089 RVA: 0x0006E9F0 File Offset: 0x0006CBF0
	public static 209 Barycentric(209 1, 209 2, 209 3, float 4, float 5)
	{
		return new 209
		{
			X = 1.X + 4 * (2.X - 1.X) + 5 * (3.X - 1.X),
			Y = 1.Y + 4 * (2.Y - 1.Y) + 5 * (3.Y - 1.Y),
			Z = 1.Z + 4 * (2.Z - 1.Z) + 5 * (3.Z - 1.Z)
		};
	}

	// Token: 0x06001BB2 RID: 7090 RVA: 0x0006EA90 File Offset: 0x0006CC90
	public static void Barycentric(ref 209 1, ref 209 2, ref 209 3, float 4, float 5, out 209 6)
	{
		6.X = 1.X + 4 * (2.X - 1.X) + 5 * (3.X - 1.X);
		6.Y = 1.Y + 4 * (2.Y - 1.Y) + 5 * (3.Y - 1.Y);
		6.Z = 1.Z + 4 * (2.Z - 1.Z) + 5 * (3.Z - 1.Z);
	}

	// Token: 0x06001BB3 RID: 7091 RVA: 0x0006EB28 File Offset: 0x0006CD28
	public static 209 SmoothStep(209 1, 209 2, float 3)
	{
		3 = ((3 > 1f) ? 1f : ((3 < 0f) ? 0f : 3));
		3 = 3 * 3 * (3f - 2f * 3);
		return new 209
		{
			X = 1.X + (2.X - 1.X) * 3,
			Y = 1.Y + (2.Y - 1.Y) * 3,
			Z = 1.Z + (2.Z - 1.Z) * 3
		};
	}

	// Token: 0x06001BB4 RID: 7092 RVA: 0x0006EBCC File Offset: 0x0006CDCC
	public static void SmoothStep(ref 209 1, ref 209 2, float 3, out 209 4)
	{
		3 = ((3 > 1f) ? 1f : ((3 < 0f) ? 0f : 3));
		3 = 3 * 3 * (3f - 2f * 3);
		4.X = 1.X + (2.X - 1.X) * 3;
		4.Y = 1.Y + (2.Y - 1.Y) * 3;
		4.Z = 1.Z + (2.Z - 1.Z) * 3;
	}

	// Token: 0x06001BB5 RID: 7093 RVA: 0x0006EC64 File Offset: 0x0006CE64
	public static 209 CatmullRom(209 1, 209 2, 209 3, 209 4, float 5)
	{
		float num = 5 * 5;
		float num2 = 5 * num;
		return new 209
		{
			X = 0.5f * (2f * 2.X + (0f - 1.X + 3.X) * 5 + (2f * 1.X - 5f * 2.X + 4f * 3.X - 4.X) * num + (0f - 1.X + 3f * 2.X - 3f * 3.X + 4.X) * num2),
			Y = 0.5f * (2f * 2.Y + (0f - 1.Y + 3.Y) * 5 + (2f * 1.Y - 5f * 2.Y + 4f * 3.Y - 4.Y) * num + (0f - 1.Y + 3f * 2.Y - 3f * 3.Y + 4.Y) * num2),
			Z = 0.5f * (2f * 2.Z + (0f - 1.Z + 3.Z) * 5 + (2f * 1.Z - 5f * 2.Z + 4f * 3.Z - 4.Z) * num + (0f - 1.Z + 3f * 2.Z - 3f * 3.Z + 4.Z) * num2)
		};
	}

	// Token: 0x06001BB6 RID: 7094 RVA: 0x0006EE38 File Offset: 0x0006D038
	public static void CatmullRom(ref 209 1, ref 209 2, ref 209 3, ref 209 4, float 5, out 209 6)
	{
		float num = 5 * 5;
		float num2 = 5 * num;
		6.X = 0.5f * (2f * 2.X + (0f - 1.X + 3.X) * 5 + (2f * 1.X - 5f * 2.X + 4f * 3.X - 4.X) * num + (0f - 1.X + 3f * 2.X - 3f * 3.X + 4.X) * num2);
		6.Y = 0.5f * (2f * 2.Y + (0f - 1.Y + 3.Y) * 5 + (2f * 1.Y - 5f * 2.Y + 4f * 3.Y - 4.Y) * num + (0f - 1.Y + 3f * 2.Y - 3f * 3.Y + 4.Y) * num2);
		6.Z = 0.5f * (2f * 2.Z + (0f - 1.Z + 3.Z) * 5 + (2f * 1.Z - 5f * 2.Z + 4f * 3.Z - 4.Z) * num + (0f - 1.Z + 3f * 2.Z - 3f * 3.Z + 4.Z) * num2);
	}

	// Token: 0x06001BB7 RID: 7095 RVA: 0x0006F000 File Offset: 0x0006D200
	public static 209 Hermite(209 1, 209 2, 209 3, 209 4, float 5)
	{
		float num = 5 * 5;
		float num2 = 5 * num;
		float num3 = 2f * num2 - 3f * num + 1f;
		float num4 = -2f * num2 + 3f * num;
		float num5 = num2 - 2f * num + 5;
		float num6 = num2 - num;
		return new 209
		{
			X = 1.X * num3 + 3.X * num4 + 2.X * num5 + 4.X * num6,
			Y = 1.Y * num3 + 3.Y * num4 + 2.Y * num5 + 4.Y * num6,
			Z = 1.Z * num3 + 3.Z * num4 + 2.Z * num5 + 4.Z * num6
		};
	}

	// Token: 0x06001BB8 RID: 7096 RVA: 0x0006F0E0 File Offset: 0x0006D2E0
	public static void Hermite(ref 209 1, ref 209 2, ref 209 3, ref 209 4, float 5, out 209 6)
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
	}

	// Token: 0x06001BB9 RID: 7097 RVA: 0x0006F1B8 File Offset: 0x0006D3B8
	public static 209 Transform(209 1, 202 2)
	{
		float x = 1.X * 2.M11 + 1.Y * 2.M21 + 1.Z * 2.M31 + 2.M41;
		float y = 1.X * 2.M12 + 1.Y * 2.M22 + 1.Z * 2.M32 + 2.M42;
		float z = 1.X * 2.M13 + 1.Y * 2.M23 + 1.Z * 2.M33 + 2.M43;
		return new 209
		{
			X = x,
			Y = y,
			Z = z
		};
	}

	// Token: 0x06001BBA RID: 7098 RVA: 0x0006F27C File Offset: 0x0006D47C
	public static void Transform(ref 209 1, ref 202 2, out 209 3)
	{
		float x = 1.X * 2.M11 + 1.Y * 2.M21 + 1.Z * 2.M31 + 2.M41;
		float y = 1.X * 2.M12 + 1.Y * 2.M22 + 1.Z * 2.M32 + 2.M42;
		float z = 1.X * 2.M13 + 1.Y * 2.M23 + 1.Z * 2.M33 + 2.M43;
		3.X = x;
		3.Y = y;
		3.Z = z;
	}

	// Token: 0x06001BBB RID: 7099 RVA: 0x0006F334 File Offset: 0x0006D534
	public static 209 TransformNormal(209 1, 202 2)
	{
		float x = 1.X * 2.M11 + 1.Y * 2.M21 + 1.Z * 2.M31;
		float y = 1.X * 2.M12 + 1.Y * 2.M22 + 1.Z * 2.M32;
		float z = 1.X * 2.M13 + 1.Y * 2.M23 + 1.Z * 2.M33;
		return new 209
		{
			X = x,
			Y = y,
			Z = z
		};
	}

	// Token: 0x06001BBC RID: 7100 RVA: 0x0006F3E0 File Offset: 0x0006D5E0
	public static void TransformNormal(ref 209 1, ref 202 2, out 209 3)
	{
		float x = 1.X * 2.M11 + 1.Y * 2.M21 + 1.Z * 2.M31;
		float y = 1.X * 2.M12 + 1.Y * 2.M22 + 1.Z * 2.M32;
		float z = 1.X * 2.M13 + 1.Y * 2.M23 + 1.Z * 2.M33;
		3.X = x;
		3.Y = y;
		3.Z = z;
	}

	// Token: 0x06001BBD RID: 7101 RVA: 0x0006F480 File Offset: 0x0006D680
	public static void Transform(209[] 1, ref 202 2, 209[] 3)
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
			3[i].X = x * 2.M11 + y * 2.M21 + z * 2.M31 + 2.M41;
			3[i].Y = x * 2.M12 + y * 2.M22 + z * 2.M32 + 2.M42;
			3[i].Z = x * 2.M13 + y * 2.M23 + z * 2.M33 + 2.M43;
		}
	}

	// Token: 0x06001BBE RID: 7102 RVA: 0x0006F580 File Offset: 0x0006D780
	public static void Transform(209[] 1, int 2, ref 202 3, 209[] 4, int 5, int 6)
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
			4[5].X = x * 3.M11 + y * 3.M21 + z * 3.M31 + 3.M41;
			4[5].Y = x * 3.M12 + y * 3.M22 + z * 3.M32 + 3.M42;
			4[5].Z = x * 3.M13 + y * 3.M23 + z * 3.M33 + 3.M43;
			2++;
			5++;
			6--;
		}
	}

	// Token: 0x06001BBF RID: 7103 RVA: 0x0006F6A8 File Offset: 0x0006D8A8
	public static void TransformNormal(209[] 1, ref 202 2, 209[] 3)
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
			3[i].X = x * 2.M11 + y * 2.M21 + z * 2.M31;
			3[i].Y = x * 2.M12 + y * 2.M22 + z * 2.M32;
			3[i].Z = x * 2.M13 + y * 2.M23 + z * 2.M33;
		}
	}

	// Token: 0x06001BC0 RID: 7104 RVA: 0x0006F794 File Offset: 0x0006D994
	public static void TransformNormal(209[] 1, int 2, ref 202 3, 209[] 4, int 5, int 6)
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
			4[5].X = x * 3.M11 + y * 3.M21 + z * 3.M31;
			4[5].Y = x * 3.M12 + y * 3.M22 + z * 3.M32;
			4[5].Z = x * 3.M13 + y * 3.M23 + z * 3.M33;
			2++;
			5++;
			6--;
		}
	}

	// Token: 0x06001BC1 RID: 7105 RVA: 0x0006F8A4 File Offset: 0x0006DAA4
	public static 209 Negate(209 1)
	{
		return new 209
		{
			X = 0f - 1.X,
			Y = 0f - 1.Y,
			Z = 0f - 1.Z
		};
	}

	// Token: 0x06001BC2 RID: 7106 RVA: 0x0006F8F3 File Offset: 0x0006DAF3
	public static void Negate(ref 209 1, out 209 2)
	{
		2.X = 0f - 1.X;
		2.Y = 0f - 1.Y;
		2.Z = 0f - 1.Z;
	}

	// Token: 0x06001BC3 RID: 7107 RVA: 0x0006F92C File Offset: 0x0006DB2C
	public static 209 Add(209 1, 209 2)
	{
		return new 209
		{
			X = 1.X + 2.X,
			Y = 1.Y + 2.Y,
			Z = 1.Z + 2.Z
		};
	}

	// Token: 0x06001BC4 RID: 7108 RVA: 0x0006F97E File Offset: 0x0006DB7E
	public static void Add(ref 209 1, ref 209 2, out 209 3)
	{
		3.X = 1.X + 2.X;
		3.Y = 1.Y + 2.Y;
		3.Z = 1.Z + 2.Z;
	}

	// Token: 0x06001BC5 RID: 7109 RVA: 0x0006F9BC File Offset: 0x0006DBBC
	public static 209 Subtract(209 1, 209 2)
	{
		return new 209
		{
			X = 1.X - 2.X,
			Y = 1.Y - 2.Y,
			Z = 1.Z - 2.Z
		};
	}

	// Token: 0x06001BC6 RID: 7110 RVA: 0x0006FA0E File Offset: 0x0006DC0E
	public static void Subtract(ref 209 1, ref 209 2, out 209 3)
	{
		3.X = 1.X - 2.X;
		3.Y = 1.Y - 2.Y;
		3.Z = 1.Z - 2.Z;
	}

	// Token: 0x06001BC7 RID: 7111 RVA: 0x0006FA4C File Offset: 0x0006DC4C
	public static 209 Multiply(209 1, 209 2)
	{
		return new 209
		{
			X = 1.X * 2.X,
			Y = 1.Y * 2.Y,
			Z = 1.Z * 2.Z
		};
	}

	// Token: 0x06001BC8 RID: 7112 RVA: 0x0006FA9E File Offset: 0x0006DC9E
	public static void Multiply(ref 209 1, ref 209 2, out 209 3)
	{
		3.X = 1.X * 2.X;
		3.Y = 1.Y * 2.Y;
		3.Z = 1.Z * 2.Z;
	}

	// Token: 0x06001BC9 RID: 7113 RVA: 0x0006FADC File Offset: 0x0006DCDC
	public static 209 Multiply(209 1, float 2)
	{
		return new 209
		{
			X = 1.X * 2,
			Y = 1.Y * 2,
			Z = 1.Z * 2
		};
	}

	// Token: 0x06001BCA RID: 7114 RVA: 0x0006FB1F File Offset: 0x0006DD1F
	public static void Multiply(ref 209 1, float 2, out 209 3)
	{
		3.X = 1.X * 2;
		3.Y = 1.Y * 2;
		3.Z = 1.Z * 2;
	}

	// Token: 0x06001BCB RID: 7115 RVA: 0x0006FB4C File Offset: 0x0006DD4C
	public static 209 Divide(209 1, 209 2)
	{
		return new 209
		{
			X = 1.X / 2.X,
			Y = 1.Y / 2.Y,
			Z = 1.Z / 2.Z
		};
	}

	// Token: 0x06001BCC RID: 7116 RVA: 0x0006FB9E File Offset: 0x0006DD9E
	public static void Divide(ref 209 1, ref 209 2, out 209 3)
	{
		3.X = 1.X / 2.X;
		3.Y = 1.Y / 2.Y;
		3.Z = 1.Z / 2.Z;
	}

	// Token: 0x06001BCD RID: 7117 RVA: 0x0006FBDC File Offset: 0x0006DDDC
	public static 209 Divide(209 1, float 2)
	{
		float num = 1f / 2;
		return new 209
		{
			X = 1.X * num,
			Y = 1.Y * num,
			Z = 1.Z * num
		};
	}

	// Token: 0x06001BCE RID: 7118 RVA: 0x0006FC28 File Offset: 0x0006DE28
	public static void Divide(ref 209 1, float 2, out 209 3)
	{
		float num = 1f / 2;
		3.X = 1.X * num;
		3.Y = 1.Y * num;
		3.Z = 1.Z * num;
	}

	// Token: 0x06001BCF RID: 7119 RVA: 0x0006FC68 File Offset: 0x0006DE68
	public static 209 operator -(209 1)
	{
		return new 209
		{
			X = 0f - 1.X,
			Y = 0f - 1.Y,
			Z = 0f - 1.Z
		};
	}

	// Token: 0x06001BD0 RID: 7120 RVA: 0x0006E01D File Offset: 0x0006C21D
	public static bool operator ==(209 1, 209 2)
	{
		return 1.X == 2.X && 1.Y == 2.Y && 1.Z == 2.Z;
	}

	// Token: 0x06001BD1 RID: 7121 RVA: 0x0006FCB7 File Offset: 0x0006DEB7
	public static bool operator !=(209 1, 209 2)
	{
		return 1.X != 2.X || 1.Y != 2.Y || 1.Z != 2.Z;
	}

	// Token: 0x06001BD2 RID: 7122 RVA: 0x0006FCE8 File Offset: 0x0006DEE8
	public static 209 operator +(209 1, 209 2)
	{
		return new 209
		{
			X = 1.X + 2.X,
			Y = 1.Y + 2.Y,
			Z = 1.Z + 2.Z
		};
	}

	// Token: 0x06001BD3 RID: 7123 RVA: 0x0006FD3C File Offset: 0x0006DF3C
	public static 209 operator -(209 1, 209 2)
	{
		return new 209
		{
			X = 1.X - 2.X,
			Y = 1.Y - 2.Y,
			Z = 1.Z - 2.Z
		};
	}

	// Token: 0x06001BD4 RID: 7124 RVA: 0x0006FD90 File Offset: 0x0006DF90
	public static 209 operator *(209 1, 209 2)
	{
		return new 209
		{
			X = 1.X * 2.X,
			Y = 1.Y * 2.Y,
			Z = 1.Z * 2.Z
		};
	}

	// Token: 0x06001BD5 RID: 7125 RVA: 0x0006FDE4 File Offset: 0x0006DFE4
	public static 209 operator *(209 1, float 2)
	{
		return new 209
		{
			X = 1.X * 2,
			Y = 1.Y * 2,
			Z = 1.Z * 2
		};
	}

	// Token: 0x06001BD6 RID: 7126 RVA: 0x0006FE28 File Offset: 0x0006E028
	public static 209 operator *(float 1, 209 2)
	{
		return new 209
		{
			X = 2.X * 1,
			Y = 2.Y * 1,
			Z = 2.Z * 1
		};
	}

	// Token: 0x06001BD7 RID: 7127 RVA: 0x0006FE6C File Offset: 0x0006E06C
	public static 209 operator /(209 1, 209 2)
	{
		return new 209
		{
			X = 1.X / 2.X,
			Y = 1.Y / 2.Y,
			Z = 1.Z / 2.Z
		};
	}

	// Token: 0x06001BD8 RID: 7128 RVA: 0x0006FEC0 File Offset: 0x0006E0C0
	public static 209 operator /(209 1, float 2)
	{
		float num = 1f / 2;
		return new 209
		{
			X = 1.X * num,
			Y = 1.Y * num,
			Z = 1.Z * num
		};
	}

	// Token: 0x04000CFE RID: 3326
	public float X;

	// Token: 0x04000CFF RID: 3327
	public float Y;

	// Token: 0x04000D00 RID: 3328
	public float Z;

	// Token: 0x04000D01 RID: 3329
	private static 209 zeroValue = default(209);

	// Token: 0x04000D02 RID: 3330
	private static 209 oneValue = new 209(1f, 1f, 1f);

	// Token: 0x04000D03 RID: 3331
	private static 209 unitXValue = new 209(1f, 0f, 0f);

	// Token: 0x04000D04 RID: 3332
	private static 209 unitYValue = new 209(0f, 1f, 0f);

	// Token: 0x04000D05 RID: 3333
	private static 209 unitZValue = new 209(0f, 0f, 1f);

	// Token: 0x04000D06 RID: 3334
	private static 209 upValue = new 209(0f, 1f, 0f);

	// Token: 0x04000D07 RID: 3335
	private static 209 downValue = new 209(0f, -1f, 0f);

	// Token: 0x04000D08 RID: 3336
	private static 209 rightValue = new 209(1f, 0f, 0f);

	// Token: 0x04000D09 RID: 3337
	private static 209 leftValue = new 209(-1f, 0f, 0f);

	// Token: 0x04000D0A RID: 3338
	private static 209 forwardValue = new 209(0f, 0f, -1f);

	// Token: 0x04000D0B RID: 3339
	private static 209 backwardValue = new 209(0f, 0f, 1f);
}
