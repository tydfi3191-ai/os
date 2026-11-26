using System;
using System.Globalization;
using System.Runtime.InteropServices;

// Token: 0x02000387 RID: 903
[ComVisible(false)]
[Serializable]
public struct 208 : IEquatable<208>
{
	// Token: 0x1700013B RID: 315
	// (get) Token: 0x06001B42 RID: 6978 RVA: 0x0006C9F4 File Offset: 0x0006ABF4
	public static 208 Zero
	{
		get
		{
			return 208.zeroValue;
		}
	}

	// Token: 0x1700013C RID: 316
	// (get) Token: 0x06001B43 RID: 6979 RVA: 0x0006C9FB File Offset: 0x0006ABFB
	public static 208 One
	{
		get
		{
			return 208.oneValue;
		}
	}

	// Token: 0x1700013D RID: 317
	// (get) Token: 0x06001B44 RID: 6980 RVA: 0x0006CA02 File Offset: 0x0006AC02
	public static 208 UnitX
	{
		get
		{
			return 208.unitXValue;
		}
	}

	// Token: 0x1700013E RID: 318
	// (get) Token: 0x06001B45 RID: 6981 RVA: 0x0006CA09 File Offset: 0x0006AC09
	public static 208 UnitY
	{
		get
		{
			return 208.unitYValue;
		}
	}

	// Token: 0x06001B46 RID: 6982 RVA: 0x0006CA10 File Offset: 0x0006AC10
	public 208(float 1, float 2)
	{
		this.X = 1;
		this.Y = 2;
	}

	// Token: 0x06001B47 RID: 6983 RVA: 0x0006CA20 File Offset: 0x0006AC20
	public 208(float 1)
	{
		this.Y = 1;
		this.X = 1;
	}

	// Token: 0x06001B48 RID: 6984 RVA: 0x0006CA30 File Offset: 0x0006AC30
	public override string ToString()
	{
		CultureInfo currentCulture = CultureInfo.CurrentCulture;
		return string.Format(currentCulture, "{{X:{0} Y:{1}}}", new object[]
		{
			this.X.ToString(currentCulture),
			this.Y.ToString(currentCulture)
		});
	}

	// Token: 0x06001B49 RID: 6985 RVA: 0x0006CA72 File Offset: 0x0006AC72
	public bool Equals(208 1)
	{
		return this.X == 1.X && this.Y == 1.Y;
	}

	// Token: 0x06001B4A RID: 6986 RVA: 0x0006CA94 File Offset: 0x0006AC94
	public override bool Equals(object 1)
	{
		bool result = false;
		if (1 is 208)
		{
			result = this.Equals((208)1);
		}
		return result;
	}

	// Token: 0x06001B4B RID: 6987 RVA: 0x0006CAB9 File Offset: 0x0006ACB9
	public override int GetHashCode()
	{
		return this.X.GetHashCode() + this.Y.GetHashCode();
	}

	// Token: 0x06001B4C RID: 6988 RVA: 0x0006CAD2 File Offset: 0x0006ACD2
	public float Length()
	{
		return (float)Math.Sqrt((double)(this.X * this.X + this.Y * this.Y));
	}

	// Token: 0x06001B4D RID: 6989 RVA: 0x0006CAF6 File Offset: 0x0006ACF6
	public float LengthSquared()
	{
		return this.X * this.X + this.Y * this.Y;
	}

	// Token: 0x06001B4E RID: 6990 RVA: 0x0006CB14 File Offset: 0x0006AD14
	public static float Distance(208 1, 208 2)
	{
		float num = 1.X - 2.X;
		float num2 = 1.Y - 2.Y;
		return (float)Math.Sqrt((double)(num * num + num2 * num2));
	}

	// Token: 0x06001B4F RID: 6991 RVA: 0x0006CB4C File Offset: 0x0006AD4C
	public static void Distance(ref 208 1, ref 208 2, out float 3)
	{
		float num = 1.X - 2.X;
		float num2 = 1.Y - 2.Y;
		float num3 = num * num + num2 * num2;
		3 = (float)Math.Sqrt((double)num3);
	}

	// Token: 0x06001B50 RID: 6992 RVA: 0x0006CB88 File Offset: 0x0006AD88
	public static float DistanceSquared(208 1, 208 2)
	{
		float num = 1.X - 2.X;
		float num2 = 1.Y - 2.Y;
		return num * num + num2 * num2;
	}

	// Token: 0x06001B51 RID: 6993 RVA: 0x0006CBB8 File Offset: 0x0006ADB8
	public static void DistanceSquared(ref 208 1, ref 208 2, out float 3)
	{
		float num = 1.X - 2.X;
		float num2 = 1.Y - 2.Y;
		3 = num * num + num2 * num2;
	}

	// Token: 0x06001B52 RID: 6994 RVA: 0x0006CBEA File Offset: 0x0006ADEA
	public static float Dot(208 1, 208 2)
	{
		return 1.X * 2.X + 1.Y * 2.Y;
	}

	// Token: 0x06001B53 RID: 6995 RVA: 0x0006CC07 File Offset: 0x0006AE07
	public static void Dot(ref 208 1, ref 208 2, out float 3)
	{
		3 = 1.X * 2.X + 1.Y * 2.Y;
	}

	// Token: 0x06001B54 RID: 6996 RVA: 0x0006CC28 File Offset: 0x0006AE28
	public void Normalize()
	{
		float num = this.X * this.X + this.Y * this.Y;
		float num2 = 1f / (float)Math.Sqrt((double)num);
		this.X *= num2;
		this.Y *= num2;
	}

	// Token: 0x06001B55 RID: 6997 RVA: 0x0006CC7C File Offset: 0x0006AE7C
	public static 208 Normalize(208 1)
	{
		float num = 1.X * 1.X + 1.Y * 1.Y;
		float num2 = 1f / (float)Math.Sqrt((double)num);
		return new 208
		{
			X = 1.X * num2,
			Y = 1.Y * num2
		};
	}

	// Token: 0x06001B56 RID: 6998 RVA: 0x0006CCDC File Offset: 0x0006AEDC
	public static void Normalize(ref 208 1, out 208 2)
	{
		float num = 1.X * 1.X + 1.Y * 1.Y;
		float num2 = 1f / (float)Math.Sqrt((double)num);
		2.X = 1.X * num2;
		2.Y = 1.Y * num2;
	}

	// Token: 0x06001B57 RID: 6999 RVA: 0x0006CD30 File Offset: 0x0006AF30
	public static 208 Min(208 1, 208 2)
	{
		return new 208
		{
			X = ((1.X < 2.X) ? 1.X : 2.X),
			Y = ((1.Y < 2.Y) ? 1.Y : 2.Y)
		};
	}

	// Token: 0x06001B58 RID: 7000 RVA: 0x0006CD8C File Offset: 0x0006AF8C
	public static void Min(ref 208 1, ref 208 2, out 208 3)
	{
		3.X = ((1.X < 2.X) ? 1.X : 2.X);
		3.Y = ((1.Y < 2.Y) ? 1.Y : 2.Y);
	}

	// Token: 0x06001B59 RID: 7001 RVA: 0x0006CDE0 File Offset: 0x0006AFE0
	public static 208 Max(208 1, 208 2)
	{
		return new 208
		{
			X = ((1.X > 2.X) ? 1.X : 2.X),
			Y = ((1.Y > 2.Y) ? 1.Y : 2.Y)
		};
	}

	// Token: 0x06001B5A RID: 7002 RVA: 0x0006CE3C File Offset: 0x0006B03C
	public static void Max(ref 208 1, ref 208 2, out 208 3)
	{
		3.X = ((1.X > 2.X) ? 1.X : 2.X);
		3.Y = ((1.Y > 2.Y) ? 1.Y : 2.Y);
	}

	// Token: 0x06001B5B RID: 7003 RVA: 0x0006CE90 File Offset: 0x0006B090
	public static 208 Clamp(208 1, 208 2, 208 3)
	{
		float num = 1.X;
		num = ((num > 3.X) ? 3.X : num);
		num = ((num < 2.X) ? 2.X : num);
		float num2 = 1.Y;
		num2 = ((num2 > 3.Y) ? 3.Y : num2);
		num2 = ((num2 < 2.Y) ? 2.Y : num2);
		return new 208
		{
			X = num,
			Y = num2
		};
	}

	// Token: 0x06001B5C RID: 7004 RVA: 0x0006CF10 File Offset: 0x0006B110
	public static void Clamp(ref 208 1, ref 208 2, ref 208 3, out 208 4)
	{
		float num = 1.X;
		num = ((num > 3.X) ? 3.X : num);
		num = ((num < 2.X) ? 2.X : num);
		float num2 = 1.Y;
		num2 = ((num2 > 3.Y) ? 3.Y : num2);
		num2 = ((num2 < 2.Y) ? 2.Y : num2);
		4.X = num;
		4.Y = num2;
	}

	// Token: 0x06001B5D RID: 7005 RVA: 0x0006CF88 File Offset: 0x0006B188
	public static 208 Lerp(208 1, 208 2, float 3)
	{
		return new 208
		{
			X = 1.X + (2.X - 1.X) * 3,
			Y = 1.Y + (2.Y - 1.Y) * 3
		};
	}

	// Token: 0x06001B5E RID: 7006 RVA: 0x0006CFD8 File Offset: 0x0006B1D8
	public static void Lerp(ref 208 1, ref 208 2, float 3, out 208 4)
	{
		4.X = 1.X + (2.X - 1.X) * 3;
		4.Y = 1.Y + (2.Y - 1.Y) * 3;
	}

	// Token: 0x06001B5F RID: 7007 RVA: 0x0006D014 File Offset: 0x0006B214
	public static 208 Barycentric(208 1, 208 2, 208 3, float 4, float 5)
	{
		return new 208
		{
			X = 1.X + 4 * (2.X - 1.X) + 5 * (3.X - 1.X),
			Y = 1.Y + 4 * (2.Y - 1.Y) + 5 * (3.Y - 1.Y)
		};
	}

	// Token: 0x06001B60 RID: 7008 RVA: 0x0006D088 File Offset: 0x0006B288
	public static void Barycentric(ref 208 1, ref 208 2, ref 208 3, float 4, float 5, out 208 6)
	{
		6.X = 1.X + 4 * (2.X - 1.X) + 5 * (3.X - 1.X);
		6.Y = 1.Y + 4 * (2.Y - 1.Y) + 5 * (3.Y - 1.Y);
	}

	// Token: 0x06001B61 RID: 7009 RVA: 0x0006D0F4 File Offset: 0x0006B2F4
	public static 208 SmoothStep(208 1, 208 2, float 3)
	{
		3 = ((3 > 1f) ? 1f : ((3 < 0f) ? 0f : 3));
		3 = 3 * 3 * (3f - 2f * 3);
		return new 208
		{
			X = 1.X + (2.X - 1.X) * 3,
			Y = 1.Y + (2.Y - 1.Y) * 3
		};
	}

	// Token: 0x06001B62 RID: 7010 RVA: 0x0006D178 File Offset: 0x0006B378
	public static void SmoothStep(ref 208 1, ref 208 2, float 3, out 208 4)
	{
		3 = ((3 > 1f) ? 1f : ((3 < 0f) ? 0f : 3));
		3 = 3 * 3 * (3f - 2f * 3);
		4.X = 1.X + (2.X - 1.X) * 3;
		4.Y = 1.Y + (2.Y - 1.Y) * 3;
	}

	// Token: 0x06001B63 RID: 7011 RVA: 0x0006D1F4 File Offset: 0x0006B3F4
	public static 208 CatmullRom(208 1, 208 2, 208 3, 208 4, float 5)
	{
		float num = 5 * 5;
		float num2 = 5 * num;
		return new 208
		{
			X = 0.5f * (2f * 2.X + (0f - 1.X + 3.X) * 5 + (2f * 1.X - 5f * 2.X + 4f * 3.X - 4.X) * num + (0f - 1.X + 3f * 2.X - 3f * 3.X + 4.X) * num2),
			Y = 0.5f * (2f * 2.Y + (0f - 1.Y + 3.Y) * 5 + (2f * 1.Y - 5f * 2.Y + 4f * 3.Y - 4.Y) * num + (0f - 1.Y + 3f * 2.Y - 3f * 3.Y + 4.Y) * num2)
		};
	}

	// Token: 0x06001B64 RID: 7012 RVA: 0x0006D338 File Offset: 0x0006B538
	public static void CatmullRom(ref 208 1, ref 208 2, ref 208 3, ref 208 4, float 5, out 208 6)
	{
		float num = 5 * 5;
		float num2 = 5 * num;
		6.X = 0.5f * (2f * 2.X + (0f - 1.X + 3.X) * 5 + (2f * 1.X - 5f * 2.X + 4f * 3.X - 4.X) * num + (0f - 1.X + 3f * 2.X - 3f * 3.X + 4.X) * num2);
		6.Y = 0.5f * (2f * 2.Y + (0f - 1.Y + 3.Y) * 5 + (2f * 1.Y - 5f * 2.Y + 4f * 3.Y - 4.Y) * num + (0f - 1.Y + 3f * 2.Y - 3f * 3.Y + 4.Y) * num2);
	}

	// Token: 0x06001B65 RID: 7013 RVA: 0x0006D470 File Offset: 0x0006B670
	public static 208 Hermite(208 1, 208 2, 208 3, 208 4, float 5)
	{
		float num = 5 * 5;
		float num2 = 5 * num;
		float num3 = 2f * num2 - 3f * num + 1f;
		float num4 = -2f * num2 + 3f * num;
		float num5 = num2 - 2f * num + 5;
		float num6 = num2 - num;
		return new 208
		{
			X = 1.X * num3 + 3.X * num4 + 2.X * num5 + 4.X * num6,
			Y = 1.Y * num3 + 3.Y * num4 + 2.Y * num5 + 4.Y * num6
		};
	}

	// Token: 0x06001B66 RID: 7014 RVA: 0x0006D524 File Offset: 0x0006B724
	public static void Hermite(ref 208 1, ref 208 2, ref 208 3, ref 208 4, float 5, out 208 6)
	{
		float num = 5 * 5;
		float num2 = 5 * num;
		float num3 = 2f * num2 - 3f * num + 1f;
		float num4 = -2f * num2 + 3f * num;
		float num5 = num2 - 2f * num + 5;
		float num6 = num2 - num;
		6.X = 1.X * num3 + 3.X * num4 + 2.X * num5 + 4.X * num6;
		6.Y = 1.Y * num3 + 3.Y * num4 + 2.Y * num5 + 4.Y * num6;
	}

	// Token: 0x06001B67 RID: 7015 RVA: 0x0006D5D0 File Offset: 0x0006B7D0
	public static 208 Transform(208 1, 202 2)
	{
		float x = 1.X * 2.M11 + 1.Y * 2.M21 + 2.M41;
		float y = 1.X * 2.M12 + 1.Y * 2.M22 + 2.M42;
		return new 208
		{
			X = x,
			Y = y
		};
	}

	// Token: 0x06001B68 RID: 7016 RVA: 0x0006D63C File Offset: 0x0006B83C
	public static void Transform(ref 208 1, ref 202 2, out 208 3)
	{
		float x = 1.X * 2.M11 + 1.Y * 2.M21 + 2.M41;
		float y = 1.X * 2.M12 + 1.Y * 2.M22 + 2.M42;
		3.X = x;
		3.Y = y;
	}

	// Token: 0x06001B69 RID: 7017 RVA: 0x0006D6A0 File Offset: 0x0006B8A0
	public static 208 TransformNormal(208 1, 202 2)
	{
		float x = 1.X * 2.M11 + 1.Y * 2.M21;
		float y = 1.X * 2.M12 + 1.Y * 2.M22;
		return new 208
		{
			X = x,
			Y = y
		};
	}

	// Token: 0x06001B6A RID: 7018 RVA: 0x0006D700 File Offset: 0x0006B900
	public static void TransformNormal(ref 208 1, ref 202 2, out 208 3)
	{
		float x = 1.X * 2.M11 + 1.Y * 2.M21;
		float y = 1.X * 2.M12 + 1.Y * 2.M22;
		3.X = x;
		3.Y = y;
	}

	// Token: 0x06001B6B RID: 7019 RVA: 0x0006D754 File Offset: 0x0006B954
	public static void Transform(208[] 1, ref 202 2, 208[] 3)
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
			3[i].X = x * 2.M11 + y * 2.M21 + 2.M41;
			3[i].Y = x * 2.M12 + y * 2.M22 + 2.M42;
		}
	}

	// Token: 0x06001B6C RID: 7020 RVA: 0x0006D800 File Offset: 0x0006BA00
	public static void Transform(208[] 1, int 2, ref 202 3, 208[] 4, int 5, int 6)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("values");
		}
		if (4 == null)
		{
			throw new ArgumentNullException("results");
		}
		if ((long)4.Length < (long)5 + (long)6)
		{
			throw new IndexOutOfRangeException(195.GetNotEnoughTargetSizeMessage());
		}
		while (6 > 0)
		{
			float x = 1[2].X;
			float y = 1[2].Y;
			4[5].X = x * 3.M11 + y * 3.M21 + 3.M41;
			4[5].Y = x * 3.M12 + y * 3.M22 + 3.M42;
			2++;
			5++;
			6--;
		}
	}

	// Token: 0x06001B6D RID: 7021 RVA: 0x0006D8C0 File Offset: 0x0006BAC0
	public static void TransformNormal(208[] 1, ref 202 2, 208[] 3)
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
			3[i].X = x * 2.M11 + y * 2.M21;
			3[i].Y = x * 2.M12 + y * 2.M22;
		}
	}

	// Token: 0x06001B6E RID: 7022 RVA: 0x0006D960 File Offset: 0x0006BB60
	public static void TransformNormal(208[] 1, int 2, ref 202 3, 208[] 4, int 5, int 6)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("values");
		}
		if (4 == null)
		{
			throw new ArgumentNullException("results");
		}
		if ((long)4.Length < (long)5 + (long)6)
		{
			throw new IndexOutOfRangeException(195.GetNotEnoughTargetSizeMessage());
		}
		while (6 > 0)
		{
			float x = 1[2].X;
			float y = 1[2].Y;
			4[5].X = x * 3.M11 + y * 3.M21;
			4[5].Y = x * 3.M12 + y * 3.M22;
			2++;
			5++;
			6--;
		}
	}

	// Token: 0x06001B6F RID: 7023 RVA: 0x0006DA10 File Offset: 0x0006BC10
	public static 208 Negate(208 1)
	{
		return new 208
		{
			X = 0f - 1.X,
			Y = 0f - 1.Y
		};
	}

	// Token: 0x06001B70 RID: 7024 RVA: 0x0006DA4C File Offset: 0x0006BC4C
	public static void Negate(ref 208 1, out 208 2)
	{
		2.X = 0f - 1.X;
		2.Y = 0f - 1.Y;
	}

	// Token: 0x06001B71 RID: 7025 RVA: 0x0006DA74 File Offset: 0x0006BC74
	public static 208 Add(208 1, 208 2)
	{
		return new 208
		{
			X = 1.X + 2.X,
			Y = 1.Y + 2.Y
		};
	}

	// Token: 0x06001B72 RID: 7026 RVA: 0x0006DAB2 File Offset: 0x0006BCB2
	public static void Add(ref 208 1, ref 208 2, out 208 3)
	{
		3.X = 1.X + 2.X;
		3.Y = 1.Y + 2.Y;
	}

	// Token: 0x06001B73 RID: 7027 RVA: 0x0006DADC File Offset: 0x0006BCDC
	public static 208 Subtract(208 1, 208 2)
	{
		return new 208
		{
			X = 1.X - 2.X,
			Y = 1.Y - 2.Y
		};
	}

	// Token: 0x06001B74 RID: 7028 RVA: 0x0006DB1A File Offset: 0x0006BD1A
	public static void Subtract(ref 208 1, ref 208 2, out 208 3)
	{
		3.X = 1.X - 2.X;
		3.Y = 1.Y - 2.Y;
	}

	// Token: 0x06001B75 RID: 7029 RVA: 0x0006DB44 File Offset: 0x0006BD44
	public static 208 Multiply(208 1, 208 2)
	{
		return new 208
		{
			X = 1.X * 2.X,
			Y = 1.Y * 2.Y
		};
	}

	// Token: 0x06001B76 RID: 7030 RVA: 0x0006DB82 File Offset: 0x0006BD82
	public static void Multiply(ref 208 1, ref 208 2, out 208 3)
	{
		3.X = 1.X * 2.X;
		3.Y = 1.Y * 2.Y;
	}

	// Token: 0x06001B77 RID: 7031 RVA: 0x0006DBAC File Offset: 0x0006BDAC
	public static 208 Multiply(208 1, float 2)
	{
		return new 208
		{
			X = 1.X * 2,
			Y = 1.Y * 2
		};
	}

	// Token: 0x06001B78 RID: 7032 RVA: 0x0006DBE0 File Offset: 0x0006BDE0
	public static void Multiply(ref 208 1, float 2, out 208 3)
	{
		3.X = 1.X * 2;
		3.Y = 1.Y * 2;
	}

	// Token: 0x06001B79 RID: 7033 RVA: 0x0006DC00 File Offset: 0x0006BE00
	public static 208 Divide(208 1, 208 2)
	{
		return new 208
		{
			X = 1.X / 2.X,
			Y = 1.Y / 2.Y
		};
	}

	// Token: 0x06001B7A RID: 7034 RVA: 0x0006DC3E File Offset: 0x0006BE3E
	public static void Divide(ref 208 1, ref 208 2, out 208 3)
	{
		3.X = 1.X / 2.X;
		3.Y = 1.Y / 2.Y;
	}

	// Token: 0x06001B7B RID: 7035 RVA: 0x0006DC68 File Offset: 0x0006BE68
	public static 208 Divide(208 1, float 2)
	{
		float num = 1f / 2;
		return new 208
		{
			X = 1.X * num,
			Y = 1.Y * num
		};
	}

	// Token: 0x06001B7C RID: 7036 RVA: 0x0006DCA4 File Offset: 0x0006BEA4
	public static void Divide(ref 208 1, float 2, out 208 3)
	{
		float num = 1f / 2;
		3.X = 1.X * num;
		3.Y = 1.Y * num;
	}

	// Token: 0x06001B7D RID: 7037 RVA: 0x0006DCD8 File Offset: 0x0006BED8
	public static 208 operator -(208 1)
	{
		return new 208
		{
			X = 0f - 1.X,
			Y = 0f - 1.Y
		};
	}

	// Token: 0x06001B7E RID: 7038 RVA: 0x0006CA72 File Offset: 0x0006AC72
	public static bool operator ==(208 1, 208 2)
	{
		return 1.X == 2.X && 1.Y == 2.Y;
	}

	// Token: 0x06001B7F RID: 7039 RVA: 0x0006DD14 File Offset: 0x0006BF14
	public static bool operator !=(208 1, 208 2)
	{
		return 1.X != 2.X || 1.Y != 2.Y;
	}

	// Token: 0x06001B80 RID: 7040 RVA: 0x0006DD38 File Offset: 0x0006BF38
	public static 208 operator +(208 1, 208 2)
	{
		return new 208
		{
			X = 1.X + 2.X,
			Y = 1.Y + 2.Y
		};
	}

	// Token: 0x06001B81 RID: 7041 RVA: 0x0006DD78 File Offset: 0x0006BF78
	public static 208 operator -(208 1, 208 2)
	{
		return new 208
		{
			X = 1.X - 2.X,
			Y = 1.Y - 2.Y
		};
	}

	// Token: 0x06001B82 RID: 7042 RVA: 0x0006DDB8 File Offset: 0x0006BFB8
	public static 208 operator *(208 1, 208 2)
	{
		return new 208
		{
			X = 1.X * 2.X,
			Y = 1.Y * 2.Y
		};
	}

	// Token: 0x06001B83 RID: 7043 RVA: 0x0006DDF8 File Offset: 0x0006BFF8
	public static 208 operator *(208 1, float 2)
	{
		return new 208
		{
			X = 1.X * 2,
			Y = 1.Y * 2
		};
	}

	// Token: 0x06001B84 RID: 7044 RVA: 0x0006DE2C File Offset: 0x0006C02C
	public static 208 operator *(float 1, 208 2)
	{
		return new 208
		{
			X = 2.X * 1,
			Y = 2.Y * 1
		};
	}

	// Token: 0x06001B85 RID: 7045 RVA: 0x0006DE60 File Offset: 0x0006C060
	public static 208 operator /(208 1, 208 2)
	{
		return new 208
		{
			X = 1.X / 2.X,
			Y = 1.Y / 2.Y
		};
	}

	// Token: 0x06001B86 RID: 7046 RVA: 0x0006DEA0 File Offset: 0x0006C0A0
	public static 208 operator /(208 1, float 2)
	{
		float num = 1f / 2;
		return new 208
		{
			X = 1.X * num,
			Y = 1.Y * num
		};
	}

	// Token: 0x04000CF8 RID: 3320
	public float X;

	// Token: 0x04000CF9 RID: 3321
	public float Y;

	// Token: 0x04000CFA RID: 3322
	private static 208 zeroValue = default(208);

	// Token: 0x04000CFB RID: 3323
	private static 208 oneValue = new 208(1f, 1f);

	// Token: 0x04000CFC RID: 3324
	private static 208 unitXValue = new 208(1f, 0f);

	// Token: 0x04000CFD RID: 3325
	private static 208 unitYValue = new 208(0f, 1f);
}
