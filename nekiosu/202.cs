using System;
using System.Globalization;
using System.Runtime.InteropServices;

// Token: 0x02000381 RID: 897
[ComVisible(false)]
[Serializable]
public struct 202 : IEquatable<202>
{
	// Token: 0x06001AB3 RID: 6835 RVA: 0x00065328 File Offset: 0x00063528
	public 202(float 1, float 2, float 3, float 4, float 5, float 6, float 7, float 8, float 9, float 10, float 11, float 12, float 13, float 14, float 15, float 16)
	{
		this.M11 = 1;
		this.M12 = 2;
		this.M13 = 3;
		this.M14 = 4;
		this.M21 = 5;
		this.M22 = 6;
		this.M23 = 7;
		this.M24 = 8;
		this.M31 = 9;
		this.M32 = 10;
		this.M33 = 11;
		this.M34 = 12;
		this.M41 = 13;
		this.M42 = 14;
		this.M43 = 15;
		this.M44 = 16;
	}

	// Token: 0x06001AB4 RID: 6836 RVA: 0x000653B2 File Offset: 0x000635B2
	public static 202 GetIdentity()
	{
		return 202.identity;
	}

	// Token: 0x06001AB5 RID: 6837 RVA: 0x000653BC File Offset: 0x000635BC
	public 209 GetUp()
	{
		return new 209
		{
			X = this.M21,
			Y = this.M22,
			Z = this.M23
		};
	}

	// Token: 0x06001AB6 RID: 6838 RVA: 0x000653F9 File Offset: 0x000635F9
	public void SetUp(209 1)
	{
		this.M21 = 1.X;
		this.M22 = 1.Y;
		this.M23 = 1.Z;
	}

	// Token: 0x06001AB7 RID: 6839 RVA: 0x00065420 File Offset: 0x00063620
	public 209 GetDown()
	{
		return new 209
		{
			X = 0f - this.M21,
			Y = 0f - this.M22,
			Z = 0f - this.M23
		};
	}

	// Token: 0x06001AB8 RID: 6840 RVA: 0x0006546F File Offset: 0x0006366F
	public void SetDown(209 1)
	{
		this.M21 = 0f - 1.X;
		this.M22 = 0f - 1.Y;
		this.M23 = 0f - 1.Z;
	}

	// Token: 0x06001AB9 RID: 6841 RVA: 0x000654A8 File Offset: 0x000636A8
	public 209 GetRight()
	{
		return new 209
		{
			X = this.M11,
			Y = this.M12,
			Z = this.M13
		};
	}

	// Token: 0x06001ABA RID: 6842 RVA: 0x000654E5 File Offset: 0x000636E5
	public void SetRight(209 1)
	{
		this.M11 = 1.X;
		this.M12 = 1.Y;
		this.M13 = 1.Z;
	}

	// Token: 0x06001ABB RID: 6843 RVA: 0x0006550C File Offset: 0x0006370C
	public 209 GetLeft()
	{
		return new 209
		{
			X = 0f - this.M11,
			Y = 0f - this.M12,
			Z = 0f - this.M13
		};
	}

	// Token: 0x06001ABC RID: 6844 RVA: 0x0006555B File Offset: 0x0006375B
	public void SetLeft(209 1)
	{
		this.M11 = 0f - 1.X;
		this.M12 = 0f - 1.Y;
		this.M13 = 0f - 1.Z;
	}

	// Token: 0x06001ABD RID: 6845 RVA: 0x00065594 File Offset: 0x00063794
	public 209 GetForward()
	{
		return new 209
		{
			X = 0f - this.M31,
			Y = 0f - this.M32,
			Z = 0f - this.M33
		};
	}

	// Token: 0x06001ABE RID: 6846 RVA: 0x000655E3 File Offset: 0x000637E3
	public void SetForward(209 1)
	{
		this.M31 = 0f - 1.X;
		this.M32 = 0f - 1.Y;
		this.M33 = 0f - 1.Z;
	}

	// Token: 0x06001ABF RID: 6847 RVA: 0x0006561C File Offset: 0x0006381C
	public 209 GetBackward()
	{
		return new 209
		{
			X = this.M31,
			Y = this.M32,
			Z = this.M33
		};
	}

	// Token: 0x06001AC0 RID: 6848 RVA: 0x00065659 File Offset: 0x00063859
	public void SetBackward(209 1)
	{
		this.M31 = 1.X;
		this.M32 = 1.Y;
		this.M33 = 1.Z;
	}

	// Token: 0x06001AC1 RID: 6849 RVA: 0x00065680 File Offset: 0x00063880
	public 209 GetTranslation()
	{
		return new 209
		{
			X = this.M41,
			Y = this.M42,
			Z = this.M43
		};
	}

	// Token: 0x06001AC2 RID: 6850 RVA: 0x000656BD File Offset: 0x000638BD
	public void SetTranslation(209 1)
	{
		this.M41 = 1.X;
		this.M42 = 1.Y;
		this.M43 = 1.Z;
	}

	// Token: 0x06001AC3 RID: 6851 RVA: 0x000656E4 File Offset: 0x000638E4
	public static 202 CreateBillboard(209 1, 209 2, 209 3, 209? 4)
	{
		209 5 = default(209);
		5.X = 1.X - 2.X;
		5.Y = 1.Y - 2.Y;
		5.Z = 1.Z - 2.Z;
		float num = 5.LengthSquared();
		if (num < 0.0001f)
		{
			5 = ((4 != null) ? (-4.Value) : 209.Forward);
		}
		else
		{
			209.Multiply(ref 5, 1f / (float)Math.Sqrt((double)num), out 5);
		}
		209 6;
		209.Cross(ref 3, ref 5, out 6);
		6.Normalize();
		209 7;
		209.Cross(ref 5, ref 6, out 7);
		return new 202
		{
			M11 = 6.X,
			M12 = 6.Y,
			M13 = 6.Z,
			M14 = 0f,
			M21 = 7.X,
			M22 = 7.Y,
			M23 = 7.Z,
			M24 = 0f,
			M31 = 5.X,
			M32 = 5.Y,
			M33 = 5.Z,
			M34 = 0f,
			M41 = 1.X,
			M42 = 1.Y,
			M43 = 1.Z,
			M44 = 1f
		};
	}

	// Token: 0x06001AC4 RID: 6852 RVA: 0x00065870 File Offset: 0x00063A70
	public static void CreateBillboard(ref 209 1, ref 209 2, ref 209 3, 209? 4, out 202 5)
	{
		209 6 = default(209);
		6.X = 1.X - 2.X;
		6.Y = 1.Y - 2.Y;
		6.Z = 1.Z - 2.Z;
		float num = 6.LengthSquared();
		if (num < 0.0001f)
		{
			6 = ((4 != null) ? (-4.Value) : 209.Forward);
		}
		else
		{
			209.Multiply(ref 6, 1f / (float)Math.Sqrt((double)num), out 6);
		}
		209 7;
		209.Cross(ref 3, ref 6, out 7);
		7.Normalize();
		209 8;
		209.Cross(ref 6, ref 7, out 8);
		5.M11 = 7.X;
		5.M12 = 7.Y;
		5.M13 = 7.Z;
		5.M14 = 0f;
		5.M21 = 8.X;
		5.M22 = 8.Y;
		5.M23 = 8.Z;
		5.M24 = 0f;
		5.M31 = 6.X;
		5.M32 = 6.Y;
		5.M33 = 6.Z;
		5.M34 = 0f;
		5.M41 = 1.X;
		5.M42 = 1.Y;
		5.M43 = 1.Z;
		5.M44 = 1f;
	}

	// Token: 0x06001AC5 RID: 6853 RVA: 0x000659F0 File Offset: 0x00063BF0
	public static 202 CreateConstrainedBillboard(209 1, 209 2, 209 3, 209? 4, 209? 5)
	{
		209 6 = default(209);
		6.X = 1.X - 2.X;
		6.Y = 1.Y - 2.Y;
		6.Z = 1.Z - 2.Z;
		float num = 6.LengthSquared();
		if (num < 0.0001f)
		{
			6 = ((4 != null) ? (-4.Value) : 209.Forward);
		}
		else
		{
			209.Multiply(ref 6, 1f / (float)Math.Sqrt((double)num), out 6);
		}
		209 7 = 3;
		float value;
		209.Dot(ref 3, ref 6, out value);
		209 8;
		209 9;
		if (Math.Abs(value) > 0.99825466f)
		{
			if (5 != null)
			{
				8 = 5.Value;
				209.Dot(ref 3, ref 8, out value);
				if (Math.Abs(value) > 0.99825466f)
				{
					value = 3.X * 209.Forward.X + 3.Y * 209.Forward.Y + 3.Z * 209.Forward.Z;
					8 = ((Math.Abs(value) > 0.99825466f) ? 209.Right : 209.Forward);
				}
			}
			else
			{
				value = 3.X * 209.Forward.X + 3.Y * 209.Forward.Y + 3.Z * 209.Forward.Z;
				8 = ((Math.Abs(value) > 0.99825466f) ? 209.Right : 209.Forward);
			}
			209.Cross(ref 3, ref 8, out 9);
			9.Normalize();
			209.Cross(ref 9, ref 3, out 8);
			8.Normalize();
		}
		else
		{
			209.Cross(ref 3, ref 6, out 9);
			9.Normalize();
			209.Cross(ref 9, ref 7, out 8);
			8.Normalize();
		}
		return new 202
		{
			M11 = 9.X,
			M12 = 9.Y,
			M13 = 9.Z,
			M14 = 0f,
			M21 = 7.X,
			M22 = 7.Y,
			M23 = 7.Z,
			M24 = 0f,
			M31 = 8.X,
			M32 = 8.Y,
			M33 = 8.Z,
			M34 = 0f,
			M41 = 1.X,
			M42 = 1.Y,
			M43 = 1.Z,
			M44 = 1f
		};
	}

	// Token: 0x06001AC6 RID: 6854 RVA: 0x00065C9C File Offset: 0x00063E9C
	public static void CreateConstrainedBillboard(ref 209 1, ref 209 2, ref 209 3, 209? 4, 209? 5, out 202 6)
	{
		209 7 = default(209);
		7.X = 1.X - 2.X;
		7.Y = 1.Y - 2.Y;
		7.Z = 1.Z - 2.Z;
		float num = 7.LengthSquared();
		if (num < 0.0001f)
		{
			7 = ((4 != null) ? (-4.Value) : 209.Forward);
		}
		else
		{
			209.Multiply(ref 7, 1f / (float)Math.Sqrt((double)num), out 7);
		}
		209 8 = 3;
		float value;
		209.Dot(ref 3, ref 7, out value);
		209 9;
		209 10;
		if (Math.Abs(value) > 0.99825466f)
		{
			if (5 != null)
			{
				9 = 5.Value;
				209.Dot(ref 3, ref 9, out value);
				if (Math.Abs(value) > 0.99825466f)
				{
					value = 3.X * 209.Forward.X + 3.Y * 209.Forward.Y + 3.Z * 209.Forward.Z;
					9 = ((Math.Abs(value) > 0.99825466f) ? 209.Right : 209.Forward);
				}
			}
			else
			{
				value = 3.X * 209.Forward.X + 3.Y * 209.Forward.Y + 3.Z * 209.Forward.Z;
				9 = ((Math.Abs(value) > 0.99825466f) ? 209.Right : 209.Forward);
			}
			209.Cross(ref 3, ref 9, out 10);
			10.Normalize();
			209.Cross(ref 10, ref 3, out 9);
			9.Normalize();
		}
		else
		{
			209.Cross(ref 3, ref 7, out 10);
			10.Normalize();
			209.Cross(ref 10, ref 8, out 9);
			9.Normalize();
		}
		6.M11 = 10.X;
		6.M12 = 10.Y;
		6.M13 = 10.Z;
		6.M14 = 0f;
		6.M21 = 8.X;
		6.M22 = 8.Y;
		6.M23 = 8.Z;
		6.M24 = 0f;
		6.M31 = 9.X;
		6.M32 = 9.Y;
		6.M33 = 9.Z;
		6.M34 = 0f;
		6.M41 = 1.X;
		6.M42 = 1.Y;
		6.M43 = 1.Z;
		6.M44 = 1f;
	}

	// Token: 0x06001AC7 RID: 6855 RVA: 0x00065F40 File Offset: 0x00064140
	public static 202 CreateTranslation(209 1)
	{
		return new 202
		{
			M11 = 1f,
			M12 = 0f,
			M13 = 0f,
			M14 = 0f,
			M21 = 0f,
			M22 = 1f,
			M23 = 0f,
			M24 = 0f,
			M31 = 0f,
			M32 = 0f,
			M33 = 1f,
			M34 = 0f,
			M41 = 1.X,
			M42 = 1.Y,
			M43 = 1.Z,
			M44 = 1f
		};
	}

	// Token: 0x06001AC8 RID: 6856 RVA: 0x0006601C File Offset: 0x0006421C
	public static void CreateTranslation(ref 209 1, out 202 2)
	{
		2.M11 = 1f;
		2.M12 = 0f;
		2.M13 = 0f;
		2.M14 = 0f;
		2.M21 = 0f;
		2.M22 = 1f;
		2.M23 = 0f;
		2.M24 = 0f;
		2.M31 = 0f;
		2.M32 = 0f;
		2.M33 = 1f;
		2.M34 = 0f;
		2.M41 = 1.X;
		2.M42 = 1.Y;
		2.M43 = 1.Z;
		2.M44 = 1f;
	}

	// Token: 0x06001AC9 RID: 6857 RVA: 0x000660DC File Offset: 0x000642DC
	public static 202 CreateTranslation(float 1, float 2, float 3)
	{
		return new 202
		{
			M11 = 1f,
			M12 = 0f,
			M13 = 0f,
			M14 = 0f,
			M21 = 0f,
			M22 = 1f,
			M23 = 0f,
			M24 = 0f,
			M31 = 0f,
			M32 = 0f,
			M33 = 1f,
			M34 = 0f,
			M41 = 1,
			M42 = 2,
			M43 = 3,
			M44 = 1f
		};
	}

	// Token: 0x06001ACA RID: 6858 RVA: 0x000661A8 File Offset: 0x000643A8
	public static void CreateTranslation(float 1, float 2, float 3, out 202 4)
	{
		4.M11 = 1f;
		4.M12 = 0f;
		4.M13 = 0f;
		4.M14 = 0f;
		4.M21 = 0f;
		4.M22 = 1f;
		4.M23 = 0f;
		4.M24 = 0f;
		4.M31 = 0f;
		4.M32 = 0f;
		4.M33 = 1f;
		4.M34 = 0f;
		4.M41 = 1;
		4.M42 = 2;
		4.M43 = 3;
		4.M44 = 1f;
	}

	// Token: 0x06001ACB RID: 6859 RVA: 0x0006625C File Offset: 0x0006445C
	public static 202 CreateScale(float 1, float 2, float 3)
	{
		return new 202
		{
			M11 = 1,
			M12 = 0f,
			M13 = 0f,
			M14 = 0f,
			M21 = 0f,
			M22 = 2,
			M23 = 0f,
			M24 = 0f,
			M31 = 0f,
			M32 = 0f,
			M33 = 3,
			M34 = 0f,
			M41 = 0f,
			M42 = 0f,
			M43 = 0f,
			M44 = 1f
		};
	}

	// Token: 0x06001ACC RID: 6860 RVA: 0x00066328 File Offset: 0x00064528
	public static void CreateScale(float 1, float 2, float 3, out 202 4)
	{
		4.M11 = 1;
		4.M12 = 0f;
		4.M13 = 0f;
		4.M14 = 0f;
		4.M21 = 0f;
		4.M22 = 2;
		4.M23 = 0f;
		4.M24 = 0f;
		4.M31 = 0f;
		4.M32 = 0f;
		4.M33 = 3;
		4.M34 = 0f;
		4.M41 = 0f;
		4.M42 = 0f;
		4.M43 = 0f;
		4.M44 = 1f;
	}

	// Token: 0x06001ACD RID: 6861 RVA: 0x000663DC File Offset: 0x000645DC
	public static 202 CreateScale(209 1)
	{
		float x = 1.X;
		float y = 1.Y;
		float z = 1.Z;
		return new 202
		{
			M11 = x,
			M12 = 0f,
			M13 = 0f,
			M14 = 0f,
			M21 = 0f,
			M22 = y,
			M23 = 0f,
			M24 = 0f,
			M31 = 0f,
			M32 = 0f,
			M33 = z,
			M34 = 0f,
			M41 = 0f,
			M42 = 0f,
			M43 = 0f,
			M44 = 1f
		};
	}

	// Token: 0x06001ACE RID: 6862 RVA: 0x000664BC File Offset: 0x000646BC
	public static void CreateScale(ref 209 1, out 202 2)
	{
		float x = 1.X;
		float y = 1.Y;
		float z = 1.Z;
		2.M11 = x;
		2.M12 = 0f;
		2.M13 = 0f;
		2.M14 = 0f;
		2.M21 = 0f;
		2.M22 = y;
		2.M23 = 0f;
		2.M24 = 0f;
		2.M31 = 0f;
		2.M32 = 0f;
		2.M33 = z;
		2.M34 = 0f;
		2.M41 = 0f;
		2.M42 = 0f;
		2.M43 = 0f;
		2.M44 = 1f;
	}

	// Token: 0x06001ACF RID: 6863 RVA: 0x00066584 File Offset: 0x00064784
	public static 202 CreateScale(float 1)
	{
		return new 202
		{
			M11 = 1,
			M12 = 0f,
			M13 = 0f,
			M14 = 0f,
			M21 = 0f,
			M22 = 1,
			M23 = 0f,
			M24 = 0f,
			M31 = 0f,
			M32 = 0f,
			M33 = 1,
			M34 = 0f,
			M41 = 0f,
			M42 = 0f,
			M43 = 0f,
			M44 = 1f
		};
	}

	// Token: 0x06001AD0 RID: 6864 RVA: 0x00066650 File Offset: 0x00064850
	public static void CreateScale(float 1, out 202 2)
	{
		2.M11 = 1;
		2.M12 = 0f;
		2.M13 = 0f;
		2.M14 = 0f;
		2.M21 = 0f;
		2.M22 = 1;
		2.M23 = 0f;
		2.M24 = 0f;
		2.M31 = 0f;
		2.M32 = 0f;
		2.M33 = 1;
		2.M34 = 0f;
		2.M41 = 0f;
		2.M42 = 0f;
		2.M43 = 0f;
		2.M44 = 1f;
	}

	// Token: 0x06001AD1 RID: 6865 RVA: 0x00066704 File Offset: 0x00064904
	public static 202 CreateRotationX(float 1)
	{
		float num = (float)Math.Cos((double)1);
		float num2 = (float)Math.Sin((double)1);
		return new 202
		{
			M11 = 1f,
			M12 = 0f,
			M13 = 0f,
			M14 = 0f,
			M21 = 0f,
			M22 = num,
			M23 = num2,
			M24 = 0f,
			M31 = 0f,
			M32 = 0f - num2,
			M33 = num,
			M34 = 0f,
			M41 = 0f,
			M42 = 0f,
			M43 = 0f,
			M44 = 1f
		};
	}

	// Token: 0x06001AD2 RID: 6866 RVA: 0x000667E4 File Offset: 0x000649E4
	public static void CreateRotationX(float 1, out 202 2)
	{
		float num = (float)Math.Cos((double)1);
		float num2 = (float)Math.Sin((double)1);
		2.M11 = 1f;
		2.M12 = 0f;
		2.M13 = 0f;
		2.M14 = 0f;
		2.M21 = 0f;
		2.M22 = num;
		2.M23 = num2;
		2.M24 = 0f;
		2.M31 = 0f;
		2.M32 = 0f - num2;
		2.M33 = num;
		2.M34 = 0f;
		2.M41 = 0f;
		2.M42 = 0f;
		2.M43 = 0f;
		2.M44 = 1f;
	}

	// Token: 0x06001AD3 RID: 6867 RVA: 0x000668AC File Offset: 0x00064AAC
	public static 202 CreateRotationY(float 1)
	{
		float num = (float)Math.Cos((double)1);
		float num2 = (float)Math.Sin((double)1);
		return new 202
		{
			M11 = num,
			M12 = 0f,
			M13 = 0f - num2,
			M14 = 0f,
			M21 = 0f,
			M22 = 1f,
			M23 = 0f,
			M24 = 0f,
			M31 = num2,
			M32 = 0f,
			M33 = num,
			M34 = 0f,
			M41 = 0f,
			M42 = 0f,
			M43 = 0f,
			M44 = 1f
		};
	}

	// Token: 0x06001AD4 RID: 6868 RVA: 0x0006698C File Offset: 0x00064B8C
	public static void CreateRotationY(float 1, out 202 2)
	{
		float num = (float)Math.Cos((double)1);
		float num2 = (float)Math.Sin((double)1);
		2.M11 = num;
		2.M12 = 0f;
		2.M13 = 0f - num2;
		2.M14 = 0f;
		2.M21 = 0f;
		2.M22 = 1f;
		2.M23 = 0f;
		2.M24 = 0f;
		2.M31 = num2;
		2.M32 = 0f;
		2.M33 = num;
		2.M34 = 0f;
		2.M41 = 0f;
		2.M42 = 0f;
		2.M43 = 0f;
		2.M44 = 1f;
	}

	// Token: 0x06001AD5 RID: 6869 RVA: 0x00066A54 File Offset: 0x00064C54
	public static 202 CreateRotationZ(float 1)
	{
		float num = (float)Math.Cos((double)1);
		float num2 = (float)Math.Sin((double)1);
		return new 202
		{
			M11 = num,
			M12 = num2,
			M13 = 0f,
			M14 = 0f,
			M21 = 0f - num2,
			M22 = num,
			M23 = 0f,
			M24 = 0f,
			M31 = 0f,
			M32 = 0f,
			M33 = 1f,
			M34 = 0f,
			M41 = 0f,
			M42 = 0f,
			M43 = 0f,
			M44 = 1f
		};
	}

	// Token: 0x06001AD6 RID: 6870 RVA: 0x00066B34 File Offset: 0x00064D34
	public static void CreateRotationZ(float 1, out 202 2)
	{
		float num = (float)Math.Cos((double)1);
		float num2 = (float)Math.Sin((double)1);
		2.M11 = num;
		2.M12 = num2;
		2.M13 = 0f;
		2.M14 = 0f;
		2.M21 = 0f - num2;
		2.M22 = num;
		2.M23 = 0f;
		2.M24 = 0f;
		2.M31 = 0f;
		2.M32 = 0f;
		2.M33 = 1f;
		2.M34 = 0f;
		2.M41 = 0f;
		2.M42 = 0f;
		2.M43 = 0f;
		2.M44 = 1f;
	}

	// Token: 0x06001AD7 RID: 6871 RVA: 0x00066BFC File Offset: 0x00064DFC
	public static 202 CreateFromAxisAngle(209 1, float 2)
	{
		float x = 1.X;
		float y = 1.Y;
		float z = 1.Z;
		float num = (float)Math.Sin((double)2);
		float num2 = (float)Math.Cos((double)2);
		float num3 = x * x;
		float num4 = y * y;
		float num5 = z * z;
		float num6 = x * y;
		float num7 = x * z;
		float num8 = y * z;
		return new 202
		{
			M11 = num3 + num2 * (1f - num3),
			M12 = num6 - num2 * num6 + num * z,
			M13 = num7 - num2 * num7 - num * y,
			M14 = 0f,
			M21 = num6 - num2 * num6 - num * z,
			M22 = num4 + num2 * (1f - num4),
			M23 = num8 - num2 * num8 + num * x,
			M24 = 0f,
			M31 = num7 - num2 * num7 + num * y,
			M32 = num8 - num2 * num8 - num * x,
			M33 = num5 + num2 * (1f - num5),
			M34 = 0f,
			M41 = 0f,
			M42 = 0f,
			M43 = 0f,
			M44 = 1f
		};
	}

	// Token: 0x06001AD8 RID: 6872 RVA: 0x00066D60 File Offset: 0x00064F60
	public static void CreateFromAxisAngle(ref 209 1, float 2, out 202 3)
	{
		float x = 1.X;
		float y = 1.Y;
		float z = 1.Z;
		float num = (float)Math.Sin((double)2);
		float num2 = (float)Math.Cos((double)2);
		float num3 = x * x;
		float num4 = y * y;
		float num5 = z * z;
		float num6 = x * y;
		float num7 = x * z;
		float num8 = y * z;
		3.M11 = num3 + num2 * (1f - num3);
		3.M12 = num6 - num2 * num6 + num * z;
		3.M13 = num7 - num2 * num7 - num * y;
		3.M14 = 0f;
		3.M21 = num6 - num2 * num6 - num * z;
		3.M22 = num4 + num2 * (1f - num4);
		3.M23 = num8 - num2 * num8 + num * x;
		3.M24 = 0f;
		3.M31 = num7 - num2 * num7 + num * y;
		3.M32 = num8 - num2 * num8 - num * x;
		3.M33 = num5 + num2 * (1f - num5);
		3.M34 = 0f;
		3.M41 = 0f;
		3.M42 = 0f;
		3.M43 = 0f;
		3.M44 = 1f;
	}

	// Token: 0x06001AD9 RID: 6873 RVA: 0x00066EA8 File Offset: 0x000650A8
	public static 202 CreatePerspectiveFieldOfView(float 1, float 2, float 3, float 4)
	{
		if (1 <= 0f || 1 >= 3.1415927f)
		{
			throw new ArgumentOutOfRangeException(string.Format(CultureInfo.CurrentCulture, 195.GetOutRangeFieldOfViewMessage(), new object[]
			{
				"fieldOfView"
			}));
		}
		if (3 <= 0f)
		{
			throw new ArgumentOutOfRangeException(string.Format(CultureInfo.CurrentCulture, 195.GetNegativePlaneDistanceMessage(), new object[]
			{
				"nearPlaneDistance"
			}));
		}
		if (4 <= 0f)
		{
			throw new ArgumentOutOfRangeException(string.Format(CultureInfo.CurrentCulture, 195.GetNegativePlaneDistanceMessage(), new object[]
			{
				"farPlaneDistance"
			}));
		}
		if (3 >= 4)
		{
			throw new ArgumentOutOfRangeException(195.GetOppositePlanesMessage());
		}
		float num = 1f / (float)Math.Tan((double)(1 * 0.5f));
		float m = num / 2;
		202 result = default(202);
		result.M11 = m;
		result.M12 = (result.M13 = (result.M14 = 0f));
		result.M22 = num;
		result.M21 = (result.M23 = (result.M24 = 0f));
		result.M31 = (result.M32 = 0f);
		result.M33 = 4 / (3 - 4);
		result.M34 = -1f;
		result.M41 = (result.M42 = (result.M44 = 0f));
		result.M43 = 3 * 4 / (3 - 4);
		return result;
	}

	// Token: 0x06001ADA RID: 6874 RVA: 0x0006701C File Offset: 0x0006521C
	public static void CreatePerspectiveFieldOfView(float 1, float 2, float 3, float 4, out 202 5)
	{
		if (1 <= 0f || 1 >= 3.1415927f)
		{
			throw new ArgumentOutOfRangeException(string.Format(CultureInfo.CurrentCulture, 195.GetOutRangeFieldOfViewMessage(), new object[]
			{
				"fieldOfView"
			}));
		}
		if (3 <= 0f)
		{
			throw new ArgumentOutOfRangeException(string.Format(CultureInfo.CurrentCulture, 195.GetNegativePlaneDistanceMessage(), new object[]
			{
				"nearPlaneDistance"
			}));
		}
		if (4 <= 0f)
		{
			throw new ArgumentOutOfRangeException(string.Format(CultureInfo.CurrentCulture, 195.GetNegativePlaneDistanceMessage(), new object[]
			{
				"farPlaneDistance"
			}));
		}
		if (3 >= 4)
		{
			throw new ArgumentOutOfRangeException(195.GetOppositePlanesMessage());
		}
		float num = 1f / (float)Math.Tan((double)(1 * 0.5f));
		float m = num / 2;
		5.M11 = m;
		5.M12 = (5.M13 = (5.M14 = 0f));
		5.M22 = num;
		5.M21 = (5.M23 = (5.M24 = 0f));
		5.M31 = (5.M32 = 0f);
		5.M33 = 4 / (3 - 4);
		5.M34 = -1f;
		5.M41 = (5.M42 = (5.M44 = 0f));
		5.M43 = 3 * 4 / (3 - 4);
	}

	// Token: 0x06001ADB RID: 6875 RVA: 0x00067188 File Offset: 0x00065388
	public static 202 CreatePerspective(float 1, float 2, float 3, float 4)
	{
		if (3 <= 0f)
		{
			throw new ArgumentOutOfRangeException(string.Format(CultureInfo.CurrentCulture, 195.GetNegativePlaneDistanceMessage(), new object[]
			{
				"nearPlaneDistance"
			}));
		}
		if (4 <= 0f)
		{
			throw new ArgumentOutOfRangeException(string.Format(CultureInfo.CurrentCulture, 195.GetNegativePlaneDistanceMessage(), new object[]
			{
				"farPlaneDistance"
			}));
		}
		if (3 >= 4)
		{
			throw new ArgumentOutOfRangeException(195.GetOppositePlanesMessage());
		}
		202 result = default(202);
		result.M11 = 2f * 3 / 1;
		result.M12 = (result.M13 = (result.M14 = 0f));
		result.M22 = 2f * 3 / 2;
		result.M21 = (result.M23 = (result.M24 = 0f));
		result.M33 = 4 / (3 - 4);
		result.M31 = (result.M32 = 0f);
		result.M34 = -1f;
		result.M41 = (result.M42 = (result.M44 = 0f));
		result.M43 = 3 * 4 / (3 - 4);
		return result;
	}

	// Token: 0x06001ADC RID: 6876 RVA: 0x000672C0 File Offset: 0x000654C0
	public static void CreatePerspective(float 1, float 2, float 3, float 4, out 202 5)
	{
		if (3 <= 0f)
		{
			throw new ArgumentOutOfRangeException(string.Format(CultureInfo.CurrentCulture, 195.GetNegativePlaneDistanceMessage(), new object[]
			{
				"nearPlaneDistance"
			}));
		}
		if (4 <= 0f)
		{
			throw new ArgumentOutOfRangeException(string.Format(CultureInfo.CurrentCulture, 195.GetNegativePlaneDistanceMessage(), new object[]
			{
				"farPlaneDistance"
			}));
		}
		if (3 >= 4)
		{
			throw new ArgumentOutOfRangeException(195.GetOppositePlanesMessage());
		}
		5.M11 = 2f * 3 / 1;
		5.M12 = (5.M13 = (5.M14 = 0f));
		5.M22 = 2f * 3 / 2;
		5.M21 = (5.M23 = (5.M24 = 0f));
		5.M33 = 4 / (3 - 4);
		5.M31 = (5.M32 = 0f);
		5.M34 = -1f;
		5.M41 = (5.M42 = (5.M44 = 0f));
		5.M43 = 3 * 4 / (3 - 4);
	}

	// Token: 0x06001ADD RID: 6877 RVA: 0x000673F0 File Offset: 0x000655F0
	public static 202 CreatePerspectiveOffCenter(float 1, float 2, float 3, float 4, float 5, float 6)
	{
		if (5 <= 0f)
		{
			throw new ArgumentOutOfRangeException(string.Format(CultureInfo.CurrentCulture, 195.GetNegativePlaneDistanceMessage(), new object[]
			{
				"nearPlaneDistance"
			}));
		}
		if (6 <= 0f)
		{
			throw new ArgumentOutOfRangeException(string.Format(CultureInfo.CurrentCulture, 195.GetNegativePlaneDistanceMessage(), new object[]
			{
				"farPlaneDistance"
			}));
		}
		if (5 >= 6)
		{
			throw new ArgumentOutOfRangeException(195.GetOppositePlanesMessage());
		}
		202 result = default(202);
		result.M11 = 2f * 5 / (2 - 1);
		result.M12 = (result.M13 = (result.M14 = 0f));
		result.M22 = 2f * 5 / (4 - 3);
		result.M21 = (result.M23 = (result.M24 = 0f));
		result.M31 = (1 + 2) / (2 - 1);
		result.M32 = (4 + 3) / (4 - 3);
		result.M33 = 6 / (5 - 6);
		result.M34 = -1f;
		result.M43 = 5 * 6 / (5 - 6);
		result.M41 = (result.M42 = (result.M44 = 0f));
		return result;
	}

	// Token: 0x06001ADE RID: 6878 RVA: 0x00067540 File Offset: 0x00065740
	public static void CreatePerspectiveOffCenter(float 1, float 2, float 3, float 4, float 5, float 6, out 202 7)
	{
		if (5 <= 0f)
		{
			throw new ArgumentOutOfRangeException(string.Format(CultureInfo.CurrentCulture, 195.GetNegativePlaneDistanceMessage(), new object[]
			{
				"nearPlaneDistance"
			}));
		}
		if (6 <= 0f)
		{
			throw new ArgumentOutOfRangeException(string.Format(CultureInfo.CurrentCulture, 195.GetNegativePlaneDistanceMessage(), new object[]
			{
				"farPlaneDistance"
			}));
		}
		if (5 >= 6)
		{
			throw new ArgumentOutOfRangeException(195.GetOppositePlanesMessage());
		}
		7.M11 = 2f * 5 / (2 - 1);
		7.M12 = (7.M13 = (7.M14 = 0f));
		7.M22 = 2f * 5 / (4 - 3);
		7.M21 = (7.M23 = (7.M24 = 0f));
		7.M31 = (1 + 2) / (2 - 1);
		7.M32 = (4 + 3) / (4 - 3);
		7.M33 = 6 / (5 - 6);
		7.M34 = -1f;
		7.M43 = 5 * 6 / (5 - 6);
		7.M41 = (7.M42 = (7.M44 = 0f));
	}

	// Token: 0x06001ADF RID: 6879 RVA: 0x00067688 File Offset: 0x00065888
	public static 202 CreateOrthographic(float 1, float 2, float 3, float 4)
	{
		202 result = default(202);
		result.M11 = 2f / 1;
		result.M12 = (result.M13 = (result.M14 = 0f));
		result.M22 = 2f / 2;
		result.M21 = (result.M23 = (result.M24 = 0f));
		result.M33 = 1f / (3 - 4);
		result.M31 = (result.M32 = (result.M34 = 0f));
		result.M41 = (result.M42 = 0f);
		result.M43 = 3 / (3 - 4);
		result.M44 = 1f;
		return result;
	}

	// Token: 0x06001AE0 RID: 6880 RVA: 0x00067758 File Offset: 0x00065958
	public static void CreateOrthographic(float 1, float 2, float 3, float 4, out 202 5)
	{
		5.M11 = 2f / 1;
		5.M12 = (5.M13 = (5.M14 = 0f));
		5.M22 = 2f / 2;
		5.M21 = (5.M23 = (5.M24 = 0f));
		5.M33 = 1f / (3 - 4);
		5.M31 = (5.M32 = (5.M34 = 0f));
		5.M41 = (5.M42 = 0f);
		5.M43 = 3 / (3 - 4);
		5.M44 = 1f;
	}

	// Token: 0x06001AE1 RID: 6881 RVA: 0x00067820 File Offset: 0x00065A20
	public static 202 CreateOrthographicOffCenter(float 1, float 2, float 3, float 4, float 5, float 6)
	{
		202 result = default(202);
		result.M11 = 2f / (2 - 1);
		result.M12 = (result.M13 = (result.M14 = 0f));
		result.M22 = 2f / (4 - 3);
		result.M21 = (result.M23 = (result.M24 = 0f));
		result.M33 = 1f / (5 - 6);
		result.M31 = (result.M32 = (result.M34 = 0f));
		result.M41 = (1 + 2) / (1 - 2);
		result.M42 = (4 + 3) / (3 - 4);
		result.M43 = 5 / (5 - 6);
		result.M44 = 1f;
		return result;
	}

	// Token: 0x06001AE2 RID: 6882 RVA: 0x00067900 File Offset: 0x00065B00
	public static void CreateOrthographicOffCenter(float 1, float 2, float 3, float 4, float 5, float 6, out 202 7)
	{
		7.M11 = 2f / (2 - 1);
		7.M12 = (7.M13 = (7.M14 = 0f));
		7.M22 = 2f / (4 - 3);
		7.M21 = (7.M23 = (7.M24 = 0f));
		7.M33 = 1f / (5 - 6);
		7.M31 = (7.M32 = (7.M34 = 0f));
		7.M41 = (1 + 2) / (1 - 2);
		7.M42 = (4 + 3) / (3 - 4);
		7.M43 = 5 / (5 - 6);
		7.M44 = 1f;
	}

	// Token: 0x06001AE3 RID: 6883 RVA: 0x000679D8 File Offset: 0x00065BD8
	public static 202 CreateLookAt(209 1, 209 2, 209 3)
	{
		209 4 = 209.Normalize(1 - 2);
		209 5 = 209.Normalize(209.Cross(3, 4));
		209 6 = 209.Cross(4, 5);
		return new 202
		{
			M11 = 5.X,
			M12 = 6.X,
			M13 = 4.X,
			M14 = 0f,
			M21 = 5.Y,
			M22 = 6.Y,
			M23 = 4.Y,
			M24 = 0f,
			M31 = 5.Z,
			M32 = 6.Z,
			M33 = 4.Z,
			M34 = 0f,
			M41 = 0f - 209.Dot(5, 1),
			M42 = 0f - 209.Dot(6, 1),
			M43 = 0f - 209.Dot(4, 1),
			M44 = 1f
		};
	}

	// Token: 0x06001AE4 RID: 6884 RVA: 0x00067AF4 File Offset: 0x00065CF4
	public static void CreateLookAt(ref 209 1, ref 209 2, ref 209 3, out 202 4)
	{
		209 5 = 209.Normalize(1 - 2);
		209 6 = 209.Normalize(209.Cross(3, 5));
		209 7 = 209.Cross(5, 6);
		4.M11 = 6.X;
		4.M12 = 7.X;
		4.M13 = 5.X;
		4.M14 = 0f;
		4.M21 = 6.Y;
		4.M22 = 7.Y;
		4.M23 = 5.Y;
		4.M24 = 0f;
		4.M31 = 6.Z;
		4.M32 = 7.Z;
		4.M33 = 5.Z;
		4.M34 = 0f;
		4.M41 = 0f - 209.Dot(6, 1);
		4.M42 = 0f - 209.Dot(7, 1);
		4.M43 = 0f - 209.Dot(5, 1);
		4.M44 = 1f;
	}

	// Token: 0x06001AE5 RID: 6885 RVA: 0x00067C14 File Offset: 0x00065E14
	public static 202 CreateShadow(209 1, 205 2)
	{
		205 3;
		205.Normalize(ref 2, out 3);
		float num = 3.Normal.X * 1.X + 3.Normal.Y * 1.Y + 3.Normal.Z * 1.Z;
		float num2 = 0f - 3.Normal.X;
		float num3 = 0f - 3.Normal.Y;
		float num4 = 0f - 3.Normal.Z;
		float num5 = 0f - 3.D;
		return new 202
		{
			M11 = num2 * 1.X + num,
			M21 = num3 * 1.X,
			M31 = num4 * 1.X,
			M41 = num5 * 1.X,
			M12 = num2 * 1.Y,
			M22 = num3 * 1.Y + num,
			M32 = num4 * 1.Y,
			M42 = num5 * 1.Y,
			M13 = num2 * 1.Z,
			M23 = num3 * 1.Z,
			M33 = num4 * 1.Z + num,
			M43 = num5 * 1.Z,
			M14 = 0f,
			M24 = 0f,
			M34 = 0f,
			M44 = num
		};
	}

	// Token: 0x06001AE6 RID: 6886 RVA: 0x00067DA0 File Offset: 0x00065FA0
	public static void CreateShadow(ref 209 1, ref 205 2, out 202 3)
	{
		205 4;
		205.Normalize(ref 2, out 4);
		float num = 4.Normal.X * 1.X + 4.Normal.Y * 1.Y + 4.Normal.Z * 1.Z;
		float num2 = 0f - 4.Normal.X;
		float num3 = 0f - 4.Normal.Y;
		float num4 = 0f - 4.Normal.Z;
		float num5 = 0f - 4.D;
		3.M11 = num2 * 1.X + num;
		3.M21 = num3 * 1.X;
		3.M31 = num4 * 1.X;
		3.M41 = num5 * 1.X;
		3.M12 = num2 * 1.Y;
		3.M22 = num3 * 1.Y + num;
		3.M32 = num4 * 1.Y;
		3.M42 = num5 * 1.Y;
		3.M13 = num2 * 1.Z;
		3.M23 = num3 * 1.Z;
		3.M33 = num4 * 1.Z + num;
		3.M43 = num5 * 1.Z;
		3.M14 = 0f;
		3.M24 = 0f;
		3.M34 = 0f;
		3.M44 = num;
	}

	// Token: 0x06001AE7 RID: 6887 RVA: 0x00067F10 File Offset: 0x00066110
	public static 202 CreateReflection(205 1)
	{
		1.Normalize();
		float x = 1.Normal.X;
		float y = 1.Normal.Y;
		float z = 1.Normal.Z;
		float num = -2f * x;
		float num2 = -2f * y;
		float num3 = -2f * z;
		return new 202
		{
			M11 = num * x + 1f,
			M12 = num2 * x,
			M13 = num3 * x,
			M14 = 0f,
			M21 = num * y,
			M22 = num2 * y + 1f,
			M23 = num3 * y,
			M24 = 0f,
			M31 = num * z,
			M32 = num2 * z,
			M33 = num3 * z + 1f,
			M34 = 0f,
			M41 = num * 1.D,
			M42 = num2 * 1.D,
			M43 = num3 * 1.D,
			M44 = 1f
		};
	}

	// Token: 0x06001AE8 RID: 6888 RVA: 0x00068040 File Offset: 0x00066240
	public static void CreateReflection(ref 205 1, out 202 2)
	{
		205 3;
		205.Normalize(ref 1, out 3);
		1.Normalize();
		float x = 3.Normal.X;
		float y = 3.Normal.Y;
		float z = 3.Normal.Z;
		float num = -2f * x;
		float num2 = -2f * y;
		float num3 = -2f * z;
		2.M11 = num * x + 1f;
		2.M12 = num2 * x;
		2.M13 = num3 * x;
		2.M14 = 0f;
		2.M21 = num * y;
		2.M22 = num2 * y + 1f;
		2.M23 = num3 * y;
		2.M24 = 0f;
		2.M31 = num * z;
		2.M32 = num2 * z;
		2.M33 = num3 * z + 1f;
		2.M34 = 0f;
		2.M41 = num * 3.D;
		2.M42 = num2 * 3.D;
		2.M43 = num3 * 3.D;
		2.M44 = 1f;
	}

	// Token: 0x06001AE9 RID: 6889 RVA: 0x00068160 File Offset: 0x00066360
	public override string ToString()
	{
		CultureInfo currentCulture = CultureInfo.CurrentCulture;
		return string.Concat(new string[]
		{
			"{ ",
			string.Format(currentCulture, "{{M11:{0} M12:{1} M13:{2} M14:{3}}} ", new object[]
			{
				this.M11.ToString(currentCulture),
				this.M12.ToString(currentCulture),
				this.M13.ToString(currentCulture),
				this.M14.ToString(currentCulture)
			}),
			string.Format(currentCulture, "{{M21:{0} M22:{1} M23:{2} M24:{3}}} ", new object[]
			{
				this.M21.ToString(currentCulture),
				this.M22.ToString(currentCulture),
				this.M23.ToString(currentCulture),
				this.M24.ToString(currentCulture)
			}),
			string.Format(currentCulture, "{{M31:{0} M32:{1} M33:{2} M34:{3}}} ", new object[]
			{
				this.M31.ToString(currentCulture),
				this.M32.ToString(currentCulture),
				this.M33.ToString(currentCulture),
				this.M34.ToString(currentCulture)
			}),
			string.Format(currentCulture, "{{M41:{0} M42:{1} M43:{2} M44:{3}}} ", new object[]
			{
				this.M41.ToString(currentCulture),
				this.M42.ToString(currentCulture),
				this.M43.ToString(currentCulture),
				this.M44.ToString(currentCulture)
			}),
			"}"
		});
	}

	// Token: 0x06001AEA RID: 6890 RVA: 0x000682D0 File Offset: 0x000664D0
	public bool Equals(202 1)
	{
		return this.M11 == 1.M11 && this.M22 == 1.M22 && this.M33 == 1.M33 && this.M44 == 1.M44 && this.M12 == 1.M12 && this.M13 == 1.M13 && this.M14 == 1.M14 && this.M21 == 1.M21 && this.M23 == 1.M23 && this.M24 == 1.M24 && this.M31 == 1.M31 && this.M32 == 1.M32 && this.M34 == 1.M34 && this.M41 == 1.M41 && this.M42 == 1.M42 && this.M43 == 1.M43;
	}

	// Token: 0x06001AEB RID: 6891 RVA: 0x000683D4 File Offset: 0x000665D4
	public override bool Equals(object 1)
	{
		bool result = false;
		if (1 is 202)
		{
			result = this.Equals((202)1);
		}
		return result;
	}

	// Token: 0x06001AEC RID: 6892 RVA: 0x000683FC File Offset: 0x000665FC
	public override int GetHashCode()
	{
		return this.M11.GetHashCode() + this.M12.GetHashCode() + this.M13.GetHashCode() + this.M14.GetHashCode() + this.M21.GetHashCode() + this.M22.GetHashCode() + this.M23.GetHashCode() + this.M24.GetHashCode() + this.M31.GetHashCode() + this.M32.GetHashCode() + this.M33.GetHashCode() + this.M34.GetHashCode() + this.M41.GetHashCode() + this.M42.GetHashCode() + this.M43.GetHashCode() + this.M44.GetHashCode();
	}

	// Token: 0x06001AED RID: 6893 RVA: 0x000684C8 File Offset: 0x000666C8
	public static 202 Transpose(202 1)
	{
		return new 202
		{
			M11 = 1.M11,
			M12 = 1.M21,
			M13 = 1.M31,
			M14 = 1.M41,
			M21 = 1.M12,
			M22 = 1.M22,
			M23 = 1.M32,
			M24 = 1.M42,
			M31 = 1.M13,
			M32 = 1.M23,
			M33 = 1.M33,
			M34 = 1.M43,
			M41 = 1.M14,
			M42 = 1.M24,
			M43 = 1.M34,
			M44 = 1.M44
		};
	}

	// Token: 0x06001AEE RID: 6894 RVA: 0x000685B0 File Offset: 0x000667B0
	public static void Transpose(ref 202 1, out 202 2)
	{
		float m = 1.M11;
		float m2 = 1.M12;
		float m3 = 1.M13;
		float m4 = 1.M14;
		float m5 = 1.M21;
		float m6 = 1.M22;
		float m7 = 1.M23;
		float m8 = 1.M24;
		float m9 = 1.M31;
		float m10 = 1.M32;
		float m11 = 1.M33;
		float m12 = 1.M34;
		float m13 = 1.M41;
		float m14 = 1.M42;
		float m15 = 1.M43;
		float m16 = 1.M44;
		2.M11 = m;
		2.M12 = m5;
		2.M13 = m9;
		2.M14 = m13;
		2.M21 = m2;
		2.M22 = m6;
		2.M23 = m10;
		2.M24 = m14;
		2.M31 = m3;
		2.M32 = m7;
		2.M33 = m11;
		2.M34 = m15;
		2.M41 = m4;
		2.M42 = m8;
		2.M43 = m12;
		2.M44 = m16;
	}

	// Token: 0x06001AEF RID: 6895 RVA: 0x000686B8 File Offset: 0x000668B8
	public float Determinant()
	{
		float m = this.M11;
		float m2 = this.M12;
		float m3 = this.M13;
		float m4 = this.M14;
		float m5 = this.M21;
		float m6 = this.M22;
		float m7 = this.M23;
		float m8 = this.M24;
		float m9 = this.M31;
		float m10 = this.M32;
		float m11 = this.M33;
		float m12 = this.M34;
		float m13 = this.M41;
		float m14 = this.M42;
		float m15 = this.M43;
		float m16 = this.M44;
		float num = m11 * m16 - m12 * m15;
		float num2 = m10 * m16 - m12 * m14;
		float num3 = m10 * m15 - m11 * m14;
		float num4 = m9 * m16 - m12 * m13;
		float num5 = m9 * m15 - m11 * m13;
		float num6 = m9 * m14 - m10 * m13;
		return m * (m6 * num - m7 * num2 + m8 * num3) - m2 * (m5 * num - m7 * num4 + m8 * num5) + m3 * (m5 * num2 - m6 * num4 + m8 * num6) - m4 * (m5 * num3 - m6 * num5 + m7 * num6);
	}

	// Token: 0x06001AF0 RID: 6896 RVA: 0x000687D4 File Offset: 0x000669D4
	public static 202 Invert(202 1)
	{
		float m = 1.M11;
		float m2 = 1.M12;
		float m3 = 1.M13;
		float m4 = 1.M14;
		float m5 = 1.M21;
		float m6 = 1.M22;
		float m7 = 1.M23;
		float m8 = 1.M24;
		float m9 = 1.M31;
		float m10 = 1.M32;
		float m11 = 1.M33;
		float m12 = 1.M34;
		float m13 = 1.M41;
		float m14 = 1.M42;
		float m15 = 1.M43;
		float m16 = 1.M44;
		float num = m11 * m16 - m12 * m15;
		float num2 = m10 * m16 - m12 * m14;
		float num3 = m10 * m15 - m11 * m14;
		float num4 = m9 * m16 - m12 * m13;
		float num5 = m9 * m15 - m11 * m13;
		float num6 = m9 * m14 - m10 * m13;
		float num7 = m6 * num - m7 * num2 + m8 * num3;
		float num8 = 0f - (m5 * num - m7 * num4 + m8 * num5);
		float num9 = m5 * num2 - m6 * num4 + m8 * num6;
		float num10 = 0f - (m5 * num3 - m6 * num5 + m7 * num6);
		float num11 = 1f / (m * num7 + m2 * num8 + m3 * num9 + m4 * num10);
		202 result = default(202);
		result.M11 = num7 * num11;
		result.M21 = num8 * num11;
		result.M31 = num9 * num11;
		result.M41 = num10 * num11;
		result.M12 = (0f - (m2 * num - m3 * num2 + m4 * num3)) * num11;
		result.M22 = (m * num - m3 * num4 + m4 * num5) * num11;
		result.M32 = (0f - (m * num2 - m2 * num4 + m4 * num6)) * num11;
		result.M42 = (m * num3 - m2 * num5 + m3 * num6) * num11;
		float num12 = m7 * m16 - m8 * m15;
		float num13 = m6 * m16 - m8 * m14;
		float num14 = m6 * m15 - m7 * m14;
		float num15 = m5 * m16 - m8 * m13;
		float num16 = m5 * m15 - m7 * m13;
		float num17 = m5 * m14 - m6 * m13;
		result.M13 = (m2 * num12 - m3 * num13 + m4 * num14) * num11;
		result.M23 = (0f - (m * num12 - m3 * num15 + m4 * num16)) * num11;
		result.M33 = (m * num13 - m2 * num15 + m4 * num17) * num11;
		result.M43 = (0f - (m * num14 - m2 * num16 + m3 * num17)) * num11;
		float num18 = m7 * m12 - m8 * m11;
		float num19 = m6 * m12 - m8 * m10;
		float num20 = m6 * m11 - m7 * m10;
		float num21 = m5 * m12 - m8 * m9;
		float num22 = m5 * m11 - m7 * m9;
		float num23 = m5 * m10 - m6 * m9;
		result.M14 = (0f - (m2 * num18 - m3 * num19 + m4 * num20)) * num11;
		result.M24 = (m * num18 - m3 * num21 + m4 * num22) * num11;
		result.M34 = (0f - (m * num19 - m2 * num21 + m4 * num23)) * num11;
		result.M44 = (m * num20 - m2 * num22 + m3 * num23) * num11;
		return result;
	}

	// Token: 0x06001AF1 RID: 6897 RVA: 0x00068B38 File Offset: 0x00066D38
	public static void Invert(ref 202 1, out 202 2)
	{
		float m = 1.M11;
		float m2 = 1.M12;
		float m3 = 1.M13;
		float m4 = 1.M14;
		float m5 = 1.M21;
		float m6 = 1.M22;
		float m7 = 1.M23;
		float m8 = 1.M24;
		float m9 = 1.M31;
		float m10 = 1.M32;
		float m11 = 1.M33;
		float m12 = 1.M34;
		float m13 = 1.M41;
		float m14 = 1.M42;
		float m15 = 1.M43;
		float m16 = 1.M44;
		float num = m11 * m16 - m12 * m15;
		float num2 = m10 * m16 - m12 * m14;
		float num3 = m10 * m15 - m11 * m14;
		float num4 = m9 * m16 - m12 * m13;
		float num5 = m9 * m15 - m11 * m13;
		float num6 = m9 * m14 - m10 * m13;
		float num7 = m6 * num - m7 * num2 + m8 * num3;
		float num8 = 0f - (m5 * num - m7 * num4 + m8 * num5);
		float num9 = m5 * num2 - m6 * num4 + m8 * num6;
		float num10 = 0f - (m5 * num3 - m6 * num5 + m7 * num6);
		float num11 = 1f / (m * num7 + m2 * num8 + m3 * num9 + m4 * num10);
		2.M11 = num7 * num11;
		2.M21 = num8 * num11;
		2.M31 = num9 * num11;
		2.M41 = num10 * num11;
		2.M12 = (0f - (m2 * num - m3 * num2 + m4 * num3)) * num11;
		2.M22 = (m * num - m3 * num4 + m4 * num5) * num11;
		2.M32 = (0f - (m * num2 - m2 * num4 + m4 * num6)) * num11;
		2.M42 = (m * num3 - m2 * num5 + m3 * num6) * num11;
		float num12 = m7 * m16 - m8 * m15;
		float num13 = m6 * m16 - m8 * m14;
		float num14 = m6 * m15 - m7 * m14;
		float num15 = m5 * m16 - m8 * m13;
		float num16 = m5 * m15 - m7 * m13;
		float num17 = m5 * m14 - m6 * m13;
		2.M13 = (m2 * num12 - m3 * num13 + m4 * num14) * num11;
		2.M23 = (0f - (m * num12 - m3 * num15 + m4 * num16)) * num11;
		2.M33 = (m * num13 - m2 * num15 + m4 * num17) * num11;
		2.M43 = (0f - (m * num14 - m2 * num16 + m3 * num17)) * num11;
		float num18 = m7 * m12 - m8 * m11;
		float num19 = m6 * m12 - m8 * m10;
		float num20 = m6 * m11 - m7 * m10;
		float num21 = m5 * m12 - m8 * m9;
		float num22 = m5 * m11 - m7 * m9;
		float num23 = m5 * m10 - m6 * m9;
		2.M14 = (0f - (m2 * num18 - m3 * num19 + m4 * num20)) * num11;
		2.M24 = (m * num18 - m3 * num21 + m4 * num22) * num11;
		2.M34 = (0f - (m * num19 - m2 * num21 + m4 * num23)) * num11;
		2.M44 = (m * num20 - m2 * num22 + m3 * num23) * num11;
	}

	// Token: 0x06001AF2 RID: 6898 RVA: 0x00068E84 File Offset: 0x00067084
	public static 202 Lerp(202 1, 202 2, float 3)
	{
		return new 202
		{
			M11 = 1.M11 + (2.M11 - 1.M11) * 3,
			M12 = 1.M12 + (2.M12 - 1.M12) * 3,
			M13 = 1.M13 + (2.M13 - 1.M13) * 3,
			M14 = 1.M14 + (2.M14 - 1.M14) * 3,
			M21 = 1.M21 + (2.M21 - 1.M21) * 3,
			M22 = 1.M22 + (2.M22 - 1.M22) * 3,
			M23 = 1.M23 + (2.M23 - 1.M23) * 3,
			M24 = 1.M24 + (2.M24 - 1.M24) * 3,
			M31 = 1.M31 + (2.M31 - 1.M31) * 3,
			M32 = 1.M32 + (2.M32 - 1.M32) * 3,
			M33 = 1.M33 + (2.M33 - 1.M33) * 3,
			M34 = 1.M34 + (2.M34 - 1.M34) * 3,
			M41 = 1.M41 + (2.M41 - 1.M41) * 3,
			M42 = 1.M42 + (2.M42 - 1.M42) * 3,
			M43 = 1.M43 + (2.M43 - 1.M43) * 3,
			M44 = 1.M44 + (2.M44 - 1.M44) * 3
		};
	}

	// Token: 0x06001AF3 RID: 6899 RVA: 0x0006906C File Offset: 0x0006726C
	public static void Lerp(ref 202 1, ref 202 2, float 3, out 202 4)
	{
		4.M11 = 1.M11 + (2.M11 - 1.M11) * 3;
		4.M12 = 1.M12 + (2.M12 - 1.M12) * 3;
		4.M13 = 1.M13 + (2.M13 - 1.M13) * 3;
		4.M14 = 1.M14 + (2.M14 - 1.M14) * 3;
		4.M21 = 1.M21 + (2.M21 - 1.M21) * 3;
		4.M22 = 1.M22 + (2.M22 - 1.M22) * 3;
		4.M23 = 1.M23 + (2.M23 - 1.M23) * 3;
		4.M24 = 1.M24 + (2.M24 - 1.M24) * 3;
		4.M31 = 1.M31 + (2.M31 - 1.M31) * 3;
		4.M32 = 1.M32 + (2.M32 - 1.M32) * 3;
		4.M33 = 1.M33 + (2.M33 - 1.M33) * 3;
		4.M34 = 1.M34 + (2.M34 - 1.M34) * 3;
		4.M41 = 1.M41 + (2.M41 - 1.M41) * 3;
		4.M42 = 1.M42 + (2.M42 - 1.M42) * 3;
		4.M43 = 1.M43 + (2.M43 - 1.M43) * 3;
		4.M44 = 1.M44 + (2.M44 - 1.M44) * 3;
	}

	// Token: 0x06001AF4 RID: 6900 RVA: 0x0006923C File Offset: 0x0006743C
	public static 202 Negate(202 1)
	{
		return new 202
		{
			M11 = 0f - 1.M11,
			M12 = 0f - 1.M12,
			M13 = 0f - 1.M13,
			M14 = 0f - 1.M14,
			M21 = 0f - 1.M21,
			M22 = 0f - 1.M22,
			M23 = 0f - 1.M23,
			M24 = 0f - 1.M24,
			M31 = 0f - 1.M31,
			M32 = 0f - 1.M32,
			M33 = 0f - 1.M33,
			M34 = 0f - 1.M34,
			M41 = 0f - 1.M41,
			M42 = 0f - 1.M42,
			M43 = 0f - 1.M43,
			M44 = 0f - 1.M44
		};
	}

	// Token: 0x06001AF5 RID: 6901 RVA: 0x00069384 File Offset: 0x00067584
	public static void Negate(ref 202 1, out 202 2)
	{
		2.M11 = 0f - 1.M11;
		2.M12 = 0f - 1.M12;
		2.M13 = 0f - 1.M13;
		2.M14 = 0f - 1.M14;
		2.M21 = 0f - 1.M21;
		2.M22 = 0f - 1.M22;
		2.M23 = 0f - 1.M23;
		2.M24 = 0f - 1.M24;
		2.M31 = 0f - 1.M31;
		2.M32 = 0f - 1.M32;
		2.M33 = 0f - 1.M33;
		2.M34 = 0f - 1.M34;
		2.M41 = 0f - 1.M41;
		2.M42 = 0f - 1.M42;
		2.M43 = 0f - 1.M43;
		2.M44 = 0f - 1.M44;
	}

	// Token: 0x06001AF6 RID: 6902 RVA: 0x000694B4 File Offset: 0x000676B4
	public static 202 Add(202 1, 202 2)
	{
		return new 202
		{
			M11 = 1.M11 + 2.M11,
			M12 = 1.M12 + 2.M12,
			M13 = 1.M13 + 2.M13,
			M14 = 1.M14 + 2.M14,
			M21 = 1.M21 + 2.M21,
			M22 = 1.M22 + 2.M22,
			M23 = 1.M23 + 2.M23,
			M24 = 1.M24 + 2.M24,
			M31 = 1.M31 + 2.M31,
			M32 = 1.M32 + 2.M32,
			M33 = 1.M33 + 2.M33,
			M34 = 1.M34 + 2.M34,
			M41 = 1.M41 + 2.M41,
			M42 = 1.M42 + 2.M42,
			M43 = 1.M43 + 2.M43,
			M44 = 1.M44 + 2.M44
		};
	}

	// Token: 0x06001AF7 RID: 6903 RVA: 0x0006960C File Offset: 0x0006780C
	public static void Add(ref 202 1, ref 202 2, out 202 3)
	{
		3.M11 = 1.M11 + 2.M11;
		3.M12 = 1.M12 + 2.M12;
		3.M13 = 1.M13 + 2.M13;
		3.M14 = 1.M14 + 2.M14;
		3.M21 = 1.M21 + 2.M21;
		3.M22 = 1.M22 + 2.M22;
		3.M23 = 1.M23 + 2.M23;
		3.M24 = 1.M24 + 2.M24;
		3.M31 = 1.M31 + 2.M31;
		3.M32 = 1.M32 + 2.M32;
		3.M33 = 1.M33 + 2.M33;
		3.M34 = 1.M34 + 2.M34;
		3.M41 = 1.M41 + 2.M41;
		3.M42 = 1.M42 + 2.M42;
		3.M43 = 1.M43 + 2.M43;
		3.M44 = 1.M44 + 2.M44;
	}

	// Token: 0x06001AF8 RID: 6904 RVA: 0x0006974C File Offset: 0x0006794C
	public static 202 Subtract(202 1, 202 2)
	{
		return new 202
		{
			M11 = 1.M11 - 2.M11,
			M12 = 1.M12 - 2.M12,
			M13 = 1.M13 - 2.M13,
			M14 = 1.M14 - 2.M14,
			M21 = 1.M21 - 2.M21,
			M22 = 1.M22 - 2.M22,
			M23 = 1.M23 - 2.M23,
			M24 = 1.M24 - 2.M24,
			M31 = 1.M31 - 2.M31,
			M32 = 1.M32 - 2.M32,
			M33 = 1.M33 - 2.M33,
			M34 = 1.M34 - 2.M34,
			M41 = 1.M41 - 2.M41,
			M42 = 1.M42 - 2.M42,
			M43 = 1.M43 - 2.M43,
			M44 = 1.M44 - 2.M44
		};
	}

	// Token: 0x06001AF9 RID: 6905 RVA: 0x000698A4 File Offset: 0x00067AA4
	public static void Subtract(ref 202 1, ref 202 2, out 202 3)
	{
		3.M11 = 1.M11 - 2.M11;
		3.M12 = 1.M12 - 2.M12;
		3.M13 = 1.M13 - 2.M13;
		3.M14 = 1.M14 - 2.M14;
		3.M21 = 1.M21 - 2.M21;
		3.M22 = 1.M22 - 2.M22;
		3.M23 = 1.M23 - 2.M23;
		3.M24 = 1.M24 - 2.M24;
		3.M31 = 1.M31 - 2.M31;
		3.M32 = 1.M32 - 2.M32;
		3.M33 = 1.M33 - 2.M33;
		3.M34 = 1.M34 - 2.M34;
		3.M41 = 1.M41 - 2.M41;
		3.M42 = 1.M42 - 2.M42;
		3.M43 = 1.M43 - 2.M43;
		3.M44 = 1.M44 - 2.M44;
	}

	// Token: 0x06001AFA RID: 6906 RVA: 0x000699E4 File Offset: 0x00067BE4
	public static 202 Multiply(202 1, 202 2)
	{
		return new 202
		{
			M11 = 1.M11 * 2.M11 + 1.M12 * 2.M21 + 1.M13 * 2.M31 + 1.M14 * 2.M41,
			M12 = 1.M11 * 2.M12 + 1.M12 * 2.M22 + 1.M13 * 2.M32 + 1.M14 * 2.M42,
			M13 = 1.M11 * 2.M13 + 1.M12 * 2.M23 + 1.M13 * 2.M33 + 1.M14 * 2.M43,
			M14 = 1.M11 * 2.M14 + 1.M12 * 2.M24 + 1.M13 * 2.M34 + 1.M14 * 2.M44,
			M21 = 1.M21 * 2.M11 + 1.M22 * 2.M21 + 1.M23 * 2.M31 + 1.M24 * 2.M41,
			M22 = 1.M21 * 2.M12 + 1.M22 * 2.M22 + 1.M23 * 2.M32 + 1.M24 * 2.M42,
			M23 = 1.M21 * 2.M13 + 1.M22 * 2.M23 + 1.M23 * 2.M33 + 1.M24 * 2.M43,
			M24 = 1.M21 * 2.M14 + 1.M22 * 2.M24 + 1.M23 * 2.M34 + 1.M24 * 2.M44,
			M31 = 1.M31 * 2.M11 + 1.M32 * 2.M21 + 1.M33 * 2.M31 + 1.M34 * 2.M41,
			M32 = 1.M31 * 2.M12 + 1.M32 * 2.M22 + 1.M33 * 2.M32 + 1.M34 * 2.M42,
			M33 = 1.M31 * 2.M13 + 1.M32 * 2.M23 + 1.M33 * 2.M33 + 1.M34 * 2.M43,
			M34 = 1.M31 * 2.M14 + 1.M32 * 2.M24 + 1.M33 * 2.M34 + 1.M34 * 2.M44,
			M41 = 1.M41 * 2.M11 + 1.M42 * 2.M21 + 1.M43 * 2.M31 + 1.M44 * 2.M41,
			M42 = 1.M41 * 2.M12 + 1.M42 * 2.M22 + 1.M43 * 2.M32 + 1.M44 * 2.M42,
			M43 = 1.M41 * 2.M13 + 1.M42 * 2.M23 + 1.M43 * 2.M33 + 1.M44 * 2.M43,
			M44 = 1.M41 * 2.M14 + 1.M42 * 2.M24 + 1.M43 * 2.M34 + 1.M44 * 2.M44
		};
	}

	// Token: 0x06001AFB RID: 6907 RVA: 0x00069DDC File Offset: 0x00067FDC
	public static void Multiply(ref 202 1, ref 202 2, out 202 3)
	{
		float m = 1.M11 * 2.M11 + 1.M12 * 2.M21 + 1.M13 * 2.M31 + 1.M14 * 2.M41;
		float m2 = 1.M11 * 2.M12 + 1.M12 * 2.M22 + 1.M13 * 2.M32 + 1.M14 * 2.M42;
		float m3 = 1.M11 * 2.M13 + 1.M12 * 2.M23 + 1.M13 * 2.M33 + 1.M14 * 2.M43;
		float m4 = 1.M11 * 2.M14 + 1.M12 * 2.M24 + 1.M13 * 2.M34 + 1.M14 * 2.M44;
		float m5 = 1.M21 * 2.M11 + 1.M22 * 2.M21 + 1.M23 * 2.M31 + 1.M24 * 2.M41;
		float m6 = 1.M21 * 2.M12 + 1.M22 * 2.M22 + 1.M23 * 2.M32 + 1.M24 * 2.M42;
		float m7 = 1.M21 * 2.M13 + 1.M22 * 2.M23 + 1.M23 * 2.M33 + 1.M24 * 2.M43;
		float m8 = 1.M21 * 2.M14 + 1.M22 * 2.M24 + 1.M23 * 2.M34 + 1.M24 * 2.M44;
		float m9 = 1.M31 * 2.M11 + 1.M32 * 2.M21 + 1.M33 * 2.M31 + 1.M34 * 2.M41;
		float m10 = 1.M31 * 2.M12 + 1.M32 * 2.M22 + 1.M33 * 2.M32 + 1.M34 * 2.M42;
		float m11 = 1.M31 * 2.M13 + 1.M32 * 2.M23 + 1.M33 * 2.M33 + 1.M34 * 2.M43;
		float m12 = 1.M31 * 2.M14 + 1.M32 * 2.M24 + 1.M33 * 2.M34 + 1.M34 * 2.M44;
		float m13 = 1.M41 * 2.M11 + 1.M42 * 2.M21 + 1.M43 * 2.M31 + 1.M44 * 2.M41;
		float m14 = 1.M41 * 2.M12 + 1.M42 * 2.M22 + 1.M43 * 2.M32 + 1.M44 * 2.M42;
		float m15 = 1.M41 * 2.M13 + 1.M42 * 2.M23 + 1.M43 * 2.M33 + 1.M44 * 2.M43;
		float m16 = 1.M41 * 2.M14 + 1.M42 * 2.M24 + 1.M43 * 2.M34 + 1.M44 * 2.M44;
		3.M11 = m;
		3.M12 = m2;
		3.M13 = m3;
		3.M14 = m4;
		3.M21 = m5;
		3.M22 = m6;
		3.M23 = m7;
		3.M24 = m8;
		3.M31 = m9;
		3.M32 = m10;
		3.M33 = m11;
		3.M34 = m12;
		3.M41 = m13;
		3.M42 = m14;
		3.M43 = m15;
		3.M44 = m16;
	}

	// Token: 0x06001AFC RID: 6908 RVA: 0x0006A1F4 File Offset: 0x000683F4
	public static 202 Multiply(202 1, float 2)
	{
		return new 202
		{
			M11 = 1.M11 * 2,
			M12 = 1.M12 * 2,
			M13 = 1.M13 * 2,
			M14 = 1.M14 * 2,
			M21 = 1.M21 * 2,
			M22 = 1.M22 * 2,
			M23 = 1.M23 * 2,
			M24 = 1.M24 * 2,
			M31 = 1.M31 * 2,
			M32 = 1.M32 * 2,
			M33 = 1.M33 * 2,
			M34 = 1.M34 * 2,
			M41 = 1.M41 * 2,
			M42 = 1.M42 * 2,
			M43 = 1.M43 * 2,
			M44 = 1.M44 * 2
		};
	}

	// Token: 0x06001AFD RID: 6909 RVA: 0x0006A2FC File Offset: 0x000684FC
	public static void Multiply(ref 202 1, float 2, out 202 3)
	{
		3.M11 = 1.M11 * 2;
		3.M12 = 1.M12 * 2;
		3.M13 = 1.M13 * 2;
		3.M14 = 1.M14 * 2;
		3.M21 = 1.M21 * 2;
		3.M22 = 1.M22 * 2;
		3.M23 = 1.M23 * 2;
		3.M24 = 1.M24 * 2;
		3.M31 = 1.M31 * 2;
		3.M32 = 1.M32 * 2;
		3.M33 = 1.M33 * 2;
		3.M34 = 1.M34 * 2;
		3.M41 = 1.M41 * 2;
		3.M42 = 1.M42 * 2;
		3.M43 = 1.M43 * 2;
		3.M44 = 1.M44 * 2;
	}

	// Token: 0x06001AFE RID: 6910 RVA: 0x0006A3EC File Offset: 0x000685EC
	public static 202 Divide(202 1, 202 2)
	{
		return new 202
		{
			M11 = 1.M11 / 2.M11,
			M12 = 1.M12 / 2.M12,
			M13 = 1.M13 / 2.M13,
			M14 = 1.M14 / 2.M14,
			M21 = 1.M21 / 2.M21,
			M22 = 1.M22 / 2.M22,
			M23 = 1.M23 / 2.M23,
			M24 = 1.M24 / 2.M24,
			M31 = 1.M31 / 2.M31,
			M32 = 1.M32 / 2.M32,
			M33 = 1.M33 / 2.M33,
			M34 = 1.M34 / 2.M34,
			M41 = 1.M41 / 2.M41,
			M42 = 1.M42 / 2.M42,
			M43 = 1.M43 / 2.M43,
			M44 = 1.M44 / 2.M44
		};
	}

	// Token: 0x06001AFF RID: 6911 RVA: 0x0006A544 File Offset: 0x00068744
	public static void Divide(ref 202 1, ref 202 2, out 202 3)
	{
		3.M11 = 1.M11 / 2.M11;
		3.M12 = 1.M12 / 2.M12;
		3.M13 = 1.M13 / 2.M13;
		3.M14 = 1.M14 / 2.M14;
		3.M21 = 1.M21 / 2.M21;
		3.M22 = 1.M22 / 2.M22;
		3.M23 = 1.M23 / 2.M23;
		3.M24 = 1.M24 / 2.M24;
		3.M31 = 1.M31 / 2.M31;
		3.M32 = 1.M32 / 2.M32;
		3.M33 = 1.M33 / 2.M33;
		3.M34 = 1.M34 / 2.M34;
		3.M41 = 1.M41 / 2.M41;
		3.M42 = 1.M42 / 2.M42;
		3.M43 = 1.M43 / 2.M43;
		3.M44 = 1.M44 / 2.M44;
	}

	// Token: 0x06001B00 RID: 6912 RVA: 0x0006A684 File Offset: 0x00068884
	public static 202 Divide(202 1, float 2)
	{
		float num = 1f / 2;
		return new 202
		{
			M11 = 1.M11 * num,
			M12 = 1.M12 * num,
			M13 = 1.M13 * num,
			M14 = 1.M14 * num,
			M21 = 1.M21 * num,
			M22 = 1.M22 * num,
			M23 = 1.M23 * num,
			M24 = 1.M24 * num,
			M31 = 1.M31 * num,
			M32 = 1.M32 * num,
			M33 = 1.M33 * num,
			M34 = 1.M34 * num,
			M41 = 1.M41 * num,
			M42 = 1.M42 * num,
			M43 = 1.M43 * num,
			M44 = 1.M44 * num
		};
	}

	// Token: 0x06001B01 RID: 6913 RVA: 0x0006A794 File Offset: 0x00068994
	public static void Divide(ref 202 1, float 2, out 202 3)
	{
		float num = 1f / 2;
		3.M11 = 1.M11 * num;
		3.M12 = 1.M12 * num;
		3.M13 = 1.M13 * num;
		3.M14 = 1.M14 * num;
		3.M21 = 1.M21 * num;
		3.M22 = 1.M22 * num;
		3.M23 = 1.M23 * num;
		3.M24 = 1.M24 * num;
		3.M31 = 1.M31 * num;
		3.M32 = 1.M32 * num;
		3.M33 = 1.M33 * num;
		3.M34 = 1.M34 * num;
		3.M41 = 1.M41 * num;
		3.M42 = 1.M42 * num;
		3.M43 = 1.M43 * num;
		3.M44 = 1.M44 * num;
	}

	// Token: 0x06001B02 RID: 6914 RVA: 0x0006A88C File Offset: 0x00068A8C
	public static 202 operator -(202 1)
	{
		return new 202
		{
			M11 = 0f - 1.M11,
			M12 = 0f - 1.M12,
			M13 = 0f - 1.M13,
			M14 = 0f - 1.M14,
			M21 = 0f - 1.M21,
			M22 = 0f - 1.M22,
			M23 = 0f - 1.M23,
			M24 = 0f - 1.M24,
			M31 = 0f - 1.M31,
			M32 = 0f - 1.M32,
			M33 = 0f - 1.M33,
			M34 = 0f - 1.M34,
			M41 = 0f - 1.M41,
			M42 = 0f - 1.M42,
			M43 = 0f - 1.M43,
			M44 = 0f - 1.M44
		};
	}

	// Token: 0x06001B03 RID: 6915 RVA: 0x0006A9D4 File Offset: 0x00068BD4
	public static bool operator ==(202 1, 202 2)
	{
		return 1.M11 == 2.M11 && 1.M22 == 2.M22 && 1.M33 == 2.M33 && 1.M44 == 2.M44 && 1.M12 == 2.M12 && 1.M13 == 2.M13 && 1.M14 == 2.M14 && 1.M21 == 2.M21 && 1.M23 == 2.M23 && 1.M24 == 2.M24 && 1.M31 == 2.M31 && 1.M32 == 2.M32 && 1.M34 == 2.M34 && 1.M41 == 2.M41 && 1.M42 == 2.M42 && 1.M43 == 2.M43;
	}

	// Token: 0x06001B04 RID: 6916 RVA: 0x0006AAD8 File Offset: 0x00068CD8
	public static bool operator !=(202 1, 202 2)
	{
		return 1.M11 != 2.M11 || 1.M12 != 2.M12 || 1.M13 != 2.M13 || 1.M14 != 2.M14 || 1.M21 != 2.M21 || 1.M22 != 2.M22 || 1.M23 != 2.M23 || 1.M24 != 2.M24 || 1.M31 != 2.M31 || 1.M32 != 2.M32 || 1.M33 != 2.M33 || 1.M34 != 2.M34 || 1.M41 != 2.M41 || 1.M42 != 2.M42 || 1.M43 != 2.M43 || 1.M44 != 2.M44;
	}

	// Token: 0x06001B05 RID: 6917 RVA: 0x0006ABE0 File Offset: 0x00068DE0
	public static 202 operator +(202 1, 202 2)
	{
		return new 202
		{
			M11 = 1.M11 + 2.M11,
			M12 = 1.M12 + 2.M12,
			M13 = 1.M13 + 2.M13,
			M14 = 1.M14 + 2.M14,
			M21 = 1.M21 + 2.M21,
			M22 = 1.M22 + 2.M22,
			M23 = 1.M23 + 2.M23,
			M24 = 1.M24 + 2.M24,
			M31 = 1.M31 + 2.M31,
			M32 = 1.M32 + 2.M32,
			M33 = 1.M33 + 2.M33,
			M34 = 1.M34 + 2.M34,
			M41 = 1.M41 + 2.M41,
			M42 = 1.M42 + 2.M42,
			M43 = 1.M43 + 2.M43,
			M44 = 1.M44 + 2.M44
		};
	}

	// Token: 0x06001B06 RID: 6918 RVA: 0x0006AD38 File Offset: 0x00068F38
	public static 202 operator -(202 1, 202 2)
	{
		return new 202
		{
			M11 = 1.M11 - 2.M11,
			M12 = 1.M12 - 2.M12,
			M13 = 1.M13 - 2.M13,
			M14 = 1.M14 - 2.M14,
			M21 = 1.M21 - 2.M21,
			M22 = 1.M22 - 2.M22,
			M23 = 1.M23 - 2.M23,
			M24 = 1.M24 - 2.M24,
			M31 = 1.M31 - 2.M31,
			M32 = 1.M32 - 2.M32,
			M33 = 1.M33 - 2.M33,
			M34 = 1.M34 - 2.M34,
			M41 = 1.M41 - 2.M41,
			M42 = 1.M42 - 2.M42,
			M43 = 1.M43 - 2.M43,
			M44 = 1.M44 - 2.M44
		};
	}

	// Token: 0x06001B07 RID: 6919 RVA: 0x0006AE90 File Offset: 0x00069090
	public static 202 operator *(202 1, 202 2)
	{
		return new 202
		{
			M11 = 1.M11 * 2.M11 + 1.M12 * 2.M21 + 1.M13 * 2.M31 + 1.M14 * 2.M41,
			M12 = 1.M11 * 2.M12 + 1.M12 * 2.M22 + 1.M13 * 2.M32 + 1.M14 * 2.M42,
			M13 = 1.M11 * 2.M13 + 1.M12 * 2.M23 + 1.M13 * 2.M33 + 1.M14 * 2.M43,
			M14 = 1.M11 * 2.M14 + 1.M12 * 2.M24 + 1.M13 * 2.M34 + 1.M14 * 2.M44,
			M21 = 1.M21 * 2.M11 + 1.M22 * 2.M21 + 1.M23 * 2.M31 + 1.M24 * 2.M41,
			M22 = 1.M21 * 2.M12 + 1.M22 * 2.M22 + 1.M23 * 2.M32 + 1.M24 * 2.M42,
			M23 = 1.M21 * 2.M13 + 1.M22 * 2.M23 + 1.M23 * 2.M33 + 1.M24 * 2.M43,
			M24 = 1.M21 * 2.M14 + 1.M22 * 2.M24 + 1.M23 * 2.M34 + 1.M24 * 2.M44,
			M31 = 1.M31 * 2.M11 + 1.M32 * 2.M21 + 1.M33 * 2.M31 + 1.M34 * 2.M41,
			M32 = 1.M31 * 2.M12 + 1.M32 * 2.M22 + 1.M33 * 2.M32 + 1.M34 * 2.M42,
			M33 = 1.M31 * 2.M13 + 1.M32 * 2.M23 + 1.M33 * 2.M33 + 1.M34 * 2.M43,
			M34 = 1.M31 * 2.M14 + 1.M32 * 2.M24 + 1.M33 * 2.M34 + 1.M34 * 2.M44,
			M41 = 1.M41 * 2.M11 + 1.M42 * 2.M21 + 1.M43 * 2.M31 + 1.M44 * 2.M41,
			M42 = 1.M41 * 2.M12 + 1.M42 * 2.M22 + 1.M43 * 2.M32 + 1.M44 * 2.M42,
			M43 = 1.M41 * 2.M13 + 1.M42 * 2.M23 + 1.M43 * 2.M33 + 1.M44 * 2.M43,
			M44 = 1.M41 * 2.M14 + 1.M42 * 2.M24 + 1.M43 * 2.M34 + 1.M44 * 2.M44
		};
	}

	// Token: 0x06001B08 RID: 6920 RVA: 0x0006B288 File Offset: 0x00069488
	public static 202 operator *(202 1, float 2)
	{
		return new 202
		{
			M11 = 1.M11 * 2,
			M12 = 1.M12 * 2,
			M13 = 1.M13 * 2,
			M14 = 1.M14 * 2,
			M21 = 1.M21 * 2,
			M22 = 1.M22 * 2,
			M23 = 1.M23 * 2,
			M24 = 1.M24 * 2,
			M31 = 1.M31 * 2,
			M32 = 1.M32 * 2,
			M33 = 1.M33 * 2,
			M34 = 1.M34 * 2,
			M41 = 1.M41 * 2,
			M42 = 1.M42 * 2,
			M43 = 1.M43 * 2,
			M44 = 1.M44 * 2
		};
	}

	// Token: 0x06001B09 RID: 6921 RVA: 0x0006B390 File Offset: 0x00069590
	public static 202 operator *(float 1, 202 2)
	{
		return new 202
		{
			M11 = 2.M11 * 1,
			M12 = 2.M12 * 1,
			M13 = 2.M13 * 1,
			M14 = 2.M14 * 1,
			M21 = 2.M21 * 1,
			M22 = 2.M22 * 1,
			M23 = 2.M23 * 1,
			M24 = 2.M24 * 1,
			M31 = 2.M31 * 1,
			M32 = 2.M32 * 1,
			M33 = 2.M33 * 1,
			M34 = 2.M34 * 1,
			M41 = 2.M41 * 1,
			M42 = 2.M42 * 1,
			M43 = 2.M43 * 1,
			M44 = 2.M44 * 1
		};
	}

	// Token: 0x06001B0A RID: 6922 RVA: 0x0006B498 File Offset: 0x00069698
	public static 202 operator /(202 1, 202 2)
	{
		return new 202
		{
			M11 = 1.M11 / 2.M11,
			M12 = 1.M12 / 2.M12,
			M13 = 1.M13 / 2.M13,
			M14 = 1.M14 / 2.M14,
			M21 = 1.M21 / 2.M21,
			M22 = 1.M22 / 2.M22,
			M23 = 1.M23 / 2.M23,
			M24 = 1.M24 / 2.M24,
			M31 = 1.M31 / 2.M31,
			M32 = 1.M32 / 2.M32,
			M33 = 1.M33 / 2.M33,
			M34 = 1.M34 / 2.M34,
			M41 = 1.M41 / 2.M41,
			M42 = 1.M42 / 2.M42,
			M43 = 1.M43 / 2.M43,
			M44 = 1.M44 / 2.M44
		};
	}

	// Token: 0x06001B0B RID: 6923 RVA: 0x0006B5F0 File Offset: 0x000697F0
	public static 202 operator /(202 1, float 2)
	{
		float num = 1f / 2;
		return new 202
		{
			M11 = 1.M11 * num,
			M12 = 1.M12 * num,
			M13 = 1.M13 * num,
			M14 = 1.M14 * num,
			M21 = 1.M21 * num,
			M22 = 1.M22 * num,
			M23 = 1.M23 * num,
			M24 = 1.M24 * num,
			M31 = 1.M31 * num,
			M32 = 1.M32 * num,
			M33 = 1.M33 * num,
			M34 = 1.M34 * num,
			M41 = 1.M41 * num,
			M42 = 1.M42 * num,
			M43 = 1.M43 * num,
			M44 = 1.M44 * num
		};
	}

	// Token: 0x04000CD7 RID: 3287
	public float M11;

	// Token: 0x04000CD8 RID: 3288
	public float M12;

	// Token: 0x04000CD9 RID: 3289
	public float M13;

	// Token: 0x04000CDA RID: 3290
	public float M14;

	// Token: 0x04000CDB RID: 3291
	public float M21;

	// Token: 0x04000CDC RID: 3292
	public float M22;

	// Token: 0x04000CDD RID: 3293
	public float M23;

	// Token: 0x04000CDE RID: 3294
	public float M24;

	// Token: 0x04000CDF RID: 3295
	public float M31;

	// Token: 0x04000CE0 RID: 3296
	public float M32;

	// Token: 0x04000CE1 RID: 3297
	public float M33;

	// Token: 0x04000CE2 RID: 3298
	public float M34;

	// Token: 0x04000CE3 RID: 3299
	public float M41;

	// Token: 0x04000CE4 RID: 3300
	public float M42;

	// Token: 0x04000CE5 RID: 3301
	public float M43;

	// Token: 0x04000CE6 RID: 3302
	public float M44;

	// Token: 0x04000CE7 RID: 3303
	private static 202 identity = new 202(1f, 0f, 0f, 0f, 0f, 1f, 0f, 0f, 0f, 0f, 1f, 0f, 0f, 0f, 0f, 1f);

	// Token: 0x02000382 RID: 898
	public struct 203
	{
		// Token: 0x04000CE8 RID: 3304
		public 209 vector;

		// Token: 0x04000CE9 RID: 3305
		public 209 vector2;

		// Token: 0x04000CEA RID: 3306
		public 209 vector3;
	}

	// Token: 0x02000383 RID: 899
	public struct 204
	{
		// Token: 0x04000CEB RID: 3307
		public unsafe 209* value;

		// Token: 0x04000CEC RID: 3308
		public unsafe 209* value2;

		// Token: 0x04000CED RID: 3309
		public unsafe 209* value3;
	}
}
