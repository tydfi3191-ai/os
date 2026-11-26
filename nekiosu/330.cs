using System;

// Token: 0x0200002F RID: 47
public sealed class 330
{
	// Token: 0x0600010C RID: 268 RVA: 0x0000628C File Offset: 0x0000448C
	static 330()
	{
		330._recoveredType01460507 = new 330(0, 330.numberArray5, false);
		330._recoveredType01460507.number6 = 0;
		330._recoveredType01460508 = 330.Method0837(1UL);
	}

	// Token: 0x0600010D RID: 269 RVA: 0x000062E8 File Offset: 0x000044E8
	public 330(int 1, int[] 2, bool 3)
	{
		if (!3)
		{
			this.number5 = 1;
			this.numberArray6 = 2;
			return;
		}
		int num = 0;
		while (num < 2.Length && 2[num] == 0)
		{
			num++;
		}
		if (num == 2.Length)
		{
			this.number5 = 0;
			this.numberArray6 = 330.numberArray5;
			return;
		}
		this.number5 = 1;
		if (num == 0)
		{
			this.numberArray6 = 2;
			return;
		}
		this.numberArray6 = new int[2.Length - num];
		Array.Copy(2, num, this.numberArray6, 0, this.numberArray6.Length);
	}

	// Token: 0x0600010E RID: 270 RVA: 0x00006378 File Offset: 0x00004578
	public 330(int 1, byte[] 2) : this(1, 2, 0, 2.Length)
	{
	}

	// Token: 0x0600010F RID: 271 RVA: 0x00006388 File Offset: 0x00004588
	public 330(int 1, byte[] 2, int 3, int 4)
	{
		if (1 == 0)
		{
			this.number5 = 0;
			this.numberArray6 = 330.numberArray5;
			return;
		}
		this.numberArray6 = 330.Method0810(2, 3, 4);
		this.number5 = ((this.numberArray6.Length >= 1) ? 1 : 0);
	}

	// Token: 0x06000110 RID: 272 RVA: 0x000063DC File Offset: 0x000045DC
	public int[] GetNumberArray0510_808()
	{
		return this.numberArray6;
	}

	// Token: 0x06000111 RID: 273 RVA: 0x000063E4 File Offset: 0x000045E4
	private static int Method0809(int 1)
	{
		return (1 + 8 - 1) / 8;
	}

	// Token: 0x06000112 RID: 274 RVA: 0x000063F0 File Offset: 0x000045F0
	private static int[] Method0810(byte[] 1, int 2, int 3)
	{
		int num = 2 + 3;
		int num2 = 2;
		while (num2 < num && 1[num2] == 0)
		{
			num2++;
		}
		if (num2 >= num)
		{
			return 330.numberArray5;
		}
		int num3 = (num - num2 + 3) / 4;
		int num4 = (num - num2) % 4;
		if (num4 == 0)
		{
			num4 = 4;
		}
		if (num3 < 1)
		{
			return 330.numberArray5;
		}
		int[] array = new int[num3];
		int num5 = 0;
		int num6 = 0;
		for (int i = num2; i < num; i++)
		{
			num5 <<= 8;
			num5 |= (int)(1[i] & byte.MaxValue);
			num4--;
			if (num4 <= 0)
			{
				array[num6] = num5;
				num6++;
				num4 = 4;
				num5 = 0;
			}
		}
		if (num6 < array.Length)
		{
			array[num6] = num5;
		}
		return array;
	}

	// Token: 0x06000113 RID: 275 RVA: 0x00006498 File Offset: 0x00004698
	private static int Method0811(int 1, int 2, int[] 3)
	{
		while (2 < 3.Length)
		{
			if (3[2] != 0)
			{
				int num = 32 * (3.Length - 2 - 1);
				int 4 = 3[2];
				return num + 330.Method0813(4);
			}
			2++;
		}
		return 0;
	}

	// Token: 0x06000114 RID: 276 RVA: 0x000064CE File Offset: 0x000046CE
	public int Method0812()
	{
		if (this.number6 == -1)
		{
			this.number6 = ((this.number5 != 0) ? 330.Method0811(this.number5, 0, this.numberArray6) : 0);
		}
		return this.number6;
	}

	// Token: 0x06000115 RID: 277 RVA: 0x00006504 File Offset: 0x00004704
	private static int Method0813(int 1)
	{
		uint num = (uint)1 >> 24;
		if (num != 0U)
		{
			return (int)(24 + 330.byteArray2[(int)num]);
		}
		num = (uint)1 >> 16;
		if (num != 0U)
		{
			return (int)(16 + 330.byteArray2[(int)num]);
		}
		num = (uint)1 >> 8;
		if (num != 0U)
		{
			return (int)(8 + 330.byteArray2[(int)num]);
		}
		return (int)330.byteArray2[1];
	}

	// Token: 0x06000116 RID: 278 RVA: 0x0000654F File Offset: 0x0000474F
	public int Method0814(object 1)
	{
		return this.Method0817((330)1);
	}

	// Token: 0x06000117 RID: 279 RVA: 0x0000655D File Offset: 0x0000475D
	private static int Method0815(int 1, int[] 2, int 3, int[] 4)
	{
		while (1 != 2.Length)
		{
			if (2[1] != 0)
			{
				break;
			}
			1++;
		}
		while (3 != 4.Length && 4[3] == 0)
		{
			3++;
		}
		return 330.Method0816(1, 2, 3, 4);
	}

	// Token: 0x06000118 RID: 280 RVA: 0x0000658C File Offset: 0x0000478C
	private static int Method0816(int 1, int[] 2, int 3, int[] 4)
	{
		int num = 2.Length - 4.Length - (1 - 3);
		if (num == 0)
		{
			while (1 < 2.Length)
			{
				uint num2 = (uint)2[1++];
				uint num3 = (uint)4[3++];
				if (num2 != num3)
				{
					if (num2 >= num3)
					{
						return 1;
					}
					return -1;
				}
			}
			return 0;
		}
		if (num >= 0)
		{
			return 1;
		}
		return -1;
	}

	// Token: 0x06000119 RID: 281 RVA: 0x000065D8 File Offset: 0x000047D8
	public int Method0817(330 1)
	{
		if (this.number5 < 1.number5)
		{
			return -1;
		}
		if (this.number5 > 1.number5)
		{
			return 1;
		}
		if (this.number5 != 0)
		{
			return this.number5 * 330.Method0816(0, this.numberArray6, 0, 1.numberArray6);
		}
		return 0;
	}

	// Token: 0x0600011A RID: 282 RVA: 0x0000662C File Offset: 0x0000482C
	public override bool Equals(object 1)
	{
		if (1 == this)
		{
			return true;
		}
		330 2 = 1 as 330;
		return 2 != null && this.number5 == 2.number5 && this.Method0818(2);
	}

	// Token: 0x0600011B RID: 283 RVA: 0x00006664 File Offset: 0x00004864
	public override int GetHashCode()
	{
		int num = this.numberArray6.Length;
		if (this.numberArray6.Length != 0)
		{
			num ^= this.numberArray6[0];
			if (this.numberArray6.Length > 1)
			{
				num ^= this.numberArray6[this.numberArray6.Length - 1];
			}
		}
		return num;
	}

	// Token: 0x0600011C RID: 284 RVA: 0x000066B0 File Offset: 0x000048B0
	private bool Method0818(330 1)
	{
		int[] array = 1.numberArray6;
		if (this.numberArray6.Length != 1.numberArray6.Length)
		{
			return false;
		}
		for (int i = 0; i < this.numberArray6.Length; i++)
		{
			if (this.numberArray6[i] != 1.numberArray6[i])
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600011D RID: 285 RVA: 0x00006700 File Offset: 0x00004900
	public 330 Method0819(330 1, 330 2)
	{
		if (2.Equals(330._recoveredType01460508))
		{
			return 330._recoveredType01460507;
		}
		if (1.number5 == 0)
		{
			return 330._recoveredType01460508;
		}
		if (this.number5 == 0)
		{
			return 330._recoveredType01460507;
		}
		330 3 = this;
		if (!1.Equals(330._recoveredType01460508))
		{
			3 = 330.Method0820(3, 1.numberArray6[0], 2);
		}
		return 3;
	}

	// Token: 0x0600011E RID: 286 RVA: 0x0000675C File Offset: 0x0000495C
	private static 330 Method0820(330 1, int 2, 330 3)
	{
		int num = 3.numberArray6.Length;
		int num2 = 32 * num;
		bool flag = 3.Method0812() + 2 <= num2;
		uint num3 = (uint)3.Method0822();
		1 = 1.Method0829(num2).Method0840(3);
		int[] 4 = new int[num + 1];
		int[] array = 1.numberArray6;
		if (array.Length < num)
		{
			int[] array2 = new int[num];
			Buffer.BlockCopy(array, 0, array2, num - array.Length, array.Length * 4);
			array = array2;
		}
		int[] array3 = 330.Method0841(array);
		330.Method0825(4, array3, 3.numberArray6, num3, flag);
		int[] array4 = 330.Method0827(2);
		int num4 = array4[0];
		int num5 = num4 >> 8;
		num5--;
		int num6 = 1;
		while ((num4 = array4[num6++]) != -1)
		{
			int num7 = num5 + 1;
			for (int i = 0; i < num7; i++)
			{
				330.Method0825(4, array3, 3.numberArray6, num3, flag);
			}
			330.Method0824(4, array3, array, 3.numberArray6, num3, flag);
			num5 = num4 >> 8;
		}
		for (int j = 0; j < num5; j++)
		{
			330.Method0825(4, array3, 3.numberArray6, num3, flag);
		}
		330.Method0823(array3, 3.numberArray6, num3);
		return new 330(1, array3, true);
	}

	// Token: 0x0600011F RID: 287 RVA: 0x0000689C File Offset: 0x00004A9C
	private static int Method0821(int 1)
	{
		int num = 1 + ((1 + 1 & 4) << 1);
		num *= 2 - 1 * num;
		num *= 2 - 1 * num;
		return num * (2 - 1 * num);
	}

	// Token: 0x06000120 RID: 288 RVA: 0x000068CC File Offset: 0x00004ACC
	private int Method0822()
	{
		if (this.number7 != 0)
		{
			return this.number7;
		}
		int <<EMPTY_NAME>> = -this.numberArray6[this.numberArray6.Length - 1];
		return this.number7 = 330.Method0821(<<EMPTY_NAME>>);
	}

	// Token: 0x06000121 RID: 289 RVA: 0x0000690C File Offset: 0x00004B0C
	private static void Method0823(int[] 1, int[] 2, uint 3)
	{
		int num = 2.Length;
		for (int i = num - 1; i >= 0; i--)
		{
			uint num2 = (uint)1[num - 1];
			ulong num3 = (ulong)(num2 * 3);
			ulong num4 = num3 * (ulong)2[num - 1] + (ulong)num2;
			num4 >>= 32;
			for (int j = num - 2; j >= 0; j--)
			{
				num4 += num3 * (ulong)2[j] + (ulong)1[j];
				1[j + 1] = (int)num4;
				num4 >>= 32;
			}
			1[0] = (int)num4;
		}
		if (330.Method0815(0, 1, 0, 2) >= 0)
		{
			330.Method0833(0, 1, 0, 2);
		}
	}

	// Token: 0x06000122 RID: 290 RVA: 0x0000699C File Offset: 0x00004B9C
	private static void Method0824(int[] 1, int[] 2, int[] 3, int[] 4, uint 5, bool 6)
	{
		int num = 4.Length;
		if (num == 1)
		{
			2[0] = (int)330.Method0826((uint)2[0], (uint)3[0], (uint)4[0], 5);
			return;
		}
		uint num2 = (uint)3[num - 1];
		ulong num3 = (ulong)2[num - 1];
		ulong num4 = num3 * (ulong)num2;
		ulong num5 = (ulong)((int)num4 * (int)5);
		ulong num6 = num5 * (ulong)4[num - 1];
		num4 += (ulong)((uint)num6);
		num4 = (num4 >> 32) + (num6 >> 32);
		for (int i = num - 2; i >= 0; i--)
		{
			ulong num7 = num3 * (ulong)3[i];
			num6 = num5 * (ulong)4[i];
			num4 += (num7 & (ulong)-1) + (ulong)((uint)num6);
			1[i + 2] = (int)num4;
			num4 = (num4 >> 32) + (num7 >> 32) + (num6 >> 32);
		}
		1[1] = (int)num4;
		int num8 = (int)(num4 >> 32);
		for (int j = num - 2; j >= 0; j--)
		{
			uint num9 = (uint)1[num];
			ulong num10 = (ulong)2[j];
			ulong num11 = num10 * (ulong)num2;
			ulong num12 = (num11 & (ulong)-1) + (ulong)num9;
			ulong num13 = (ulong)((int)num12 * (int)5);
			ulong num14 = num13 * (ulong)4[num - 1];
			num12 += (ulong)((uint)num14);
			num12 = (num12 >> 32) + (num11 >> 32) + (num14 >> 32);
			for (int k = num - 2; k >= 0; k--)
			{
				num11 = num10 * (ulong)3[k];
				num14 = num13 * (ulong)4[k];
				num12 += (num11 & (ulong)-1) + (ulong)((uint)num14) + (ulong)1[k + 1];
				1[k + 2] = (int)num12;
				num12 = (num12 >> 32) + (num11 >> 32) + (num14 >> 32);
			}
			num12 += (ulong)num8;
			1[1] = (int)num12;
			num8 = (int)(num12 >> 32);
		}
		1[0] = num8;
		if (!6 && 330.Method0815(0, 1, 0, 4) >= 0)
		{
			330.Method0833(0, 1, 0, 4);
		}
		Array.Copy(1, 1, 2, 0, num);
	}

	// Token: 0x06000123 RID: 291 RVA: 0x00006B54 File Offset: 0x00004D54
	private static void Method0825(int[] 1, int[] 2, int[] 3, uint 4, bool 5)
	{
		int num = 3.Length;
		if (num == 1)
		{
			uint num2 = (uint)2[0];
			2[0] = (int)330.Method0826(num2, num2, (uint)3[0], 4);
			return;
		}
		ulong num3 = (ulong)2[num - 1];
		ulong num4 = num3 * num3;
		ulong num5 = (ulong)((int)num4 * (int)4);
		ulong num6 = num5 * (ulong)3[num - 1];
		num4 += (ulong)((uint)num6);
		num4 = (num4 >> 32) + (num6 >> 32);
		for (int i = num - 2; i >= 0; i--)
		{
			ulong num7 = num3 * (ulong)2[i];
			num6 = num5 * (ulong)3[i];
			num4 += (num6 & (ulong)-1) + (ulong)((ulong)((int)num7) << 1);
			1[i + 2] = (int)num4;
			num4 = (num4 >> 32) + (num7 >> 31) + (num6 >> 32);
		}
		1[1] = (int)num4;
		int num8 = (int)(num4 >> 32);
		for (int j = num - 2; j >= 0; j--)
		{
			uint num9 = (uint)1[num];
			ulong num10 = (ulong)(num9 * 4);
			ulong num11 = num10 * (ulong)3[num - 1] + (ulong)num9;
			num11 >>= 32;
			for (int k = num - 2; k > j; k--)
			{
				num11 += num10 * (ulong)3[k] + (ulong)1[k + 1];
				1[k + 2] = (int)num11;
				num11 >>= 32;
			}
			ulong num12 = (ulong)2[j];
			ulong num13 = num12 * num12;
			ulong num14 = num10 * (ulong)3[j];
			num11 += (num13 & (ulong)-1) + (ulong)((uint)num14) + (ulong)1[j + 1];
			1[j + 2] = (int)num11;
			num11 = (num11 >> 32) + (num13 >> 32) + (num14 >> 32);
			for (int l = j - 1; l >= 0; l--)
			{
				ulong num15 = num12 * (ulong)2[l];
				ulong num16 = num10 * (ulong)3[l];
				num11 += (num16 & (ulong)-1) + (ulong)((ulong)((int)num15) << 1) + (ulong)1[l + 1];
				1[l + 2] = (int)num11;
				num11 = (num11 >> 32) + (num15 >> 31) + (num16 >> 32);
			}
			num11 += (ulong)num8;
			1[1] = (int)num11;
			num8 = (int)(num11 >> 32);
		}
		1[0] = num8;
		if (!5 && 330.Method0815(0, 1, 0, 3) >= 0)
		{
			330.Method0833(0, 1, 0, 3);
		}
		Array.Copy(1, 1, 2, 0, num);
	}

	// Token: 0x06000124 RID: 292 RVA: 0x00006D5C File Offset: 0x00004F5C
	private static uint Method0826(uint 1, uint 2, uint 3, uint 4)
	{
		ulong num = (ulong)1 * (ulong)2;
		uint num2 = (uint)((int)num * (int)4);
		ulong num3 = (ulong)3;
		ulong num4 = num3 * (ulong)num2;
		num += (ulong)((uint)num4);
		num = (num >> 32) + (num4 >> 32);
		if (num > num3)
		{
			num -= num3;
		}
		return (uint)num;
	}

	// Token: 0x06000125 RID: 293 RVA: 0x00006D98 File Offset: 0x00004F98
	private static int[] Method0827(int 1)
	{
		int num = 330.Method0813(1);
		int[] array = new int[num + 2];
		int num2 = 0;
		int i = 33 - num;
		1 <<= i;
		int num3 = 0;
		while (i < 32)
		{
			if (1 < 0)
			{
				array[num2++] = (1 | num3 << 8);
				num3 = 0;
			}
			else
			{
				num3++;
			}
			1 <<= 1;
			i++;
		}
		array[num2++] = (1 | num3 << 8);
		array[num2] = -1;
		return array;
	}

	// Token: 0x06000126 RID: 294 RVA: 0x00006E08 File Offset: 0x00005008
	private static int[] Method0828(int[] 1, int 2)
	{
		int num = (int)((uint)2 >> 5);
		int num2 = 2 & 31;
		int num3 = 1.Length;
		int[] array;
		if (num2 == 0)
		{
			array = new int[num3 + num];
			1.CopyTo(array, 0);
		}
		else
		{
			int num4 = 0;
			int num5 = 32 - num2;
			int num6 = (int)((uint)1[0] >> num5);
			if (num6 != 0)
			{
				array = new int[num3 + num + 1];
				array[num4++] = num6;
			}
			else
			{
				array = new int[num3 + num];
			}
			int num7 = 1[0];
			for (int i = 0; i < num3 - 1; i++)
			{
				int num8 = 1[i + 1];
				array[num4++] = (num7 << num2 | (int)((uint)num8 >> num5));
				num7 = num8;
			}
			array[num4] = 1[num3 - 1] << num2;
		}
		return array;
	}

	// Token: 0x06000127 RID: 295 RVA: 0x00006EC0 File Offset: 0x000050C0
	private 330 Method0829(int 1)
	{
		if (this.number5 == 0 || this.numberArray6.Length == 0)
		{
			return 330._recoveredType01460507;
		}
		if (1 == 0)
		{
			return this;
		}
		330 2 = new 330(this.number5, 330.Method0828(this.numberArray6, 1), true);
		if (this.number6 != -1)
		{
			2.number6 = this.number6 + 1;
		}
		return 2;
	}

	// Token: 0x06000128 RID: 296 RVA: 0x00006F1C File Offset: 0x0000511C
	private static void Method0830(int 1, int[] 2, int 3)
	{
		/*
An exception occurred when decompiling this method (06000128)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void 330::Method0830(System.Int32,System.Int32[],System.Int32)

 ---> System.InvalidCastException: Unable to cast object of type 'ICSharpCode.NRefactory.CSharp.ParenthesizedExpression' to type 'ICSharpCode.NRefactory.CSharp.BinaryOperatorExpression'.
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 640
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 414
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformNode(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 270
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformBlock(ILBlock block) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 254
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformNode(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 295
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformBlock(ILBlock block) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 254
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 151
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
	}

	// Token: 0x06000129 RID: 297 RVA: 0x00006FC0 File Offset: 0x000051C0
	private static void Method0831(int 1, int[] 2)
	{
		int num = 2.Length;
		int num2 = 2[num - 1];
		while (--num > 1)
		{
			int num3 = 2[num - 1];
			2[num] = (int)((uint)num2 >> 1 | (uint)((uint)num3 << 31));
			num2 = num3;
		}
		2[1] = (int)((uint)2[1] >> 1);
	}

	// Token: 0x0600012A RID: 298 RVA: 0x00007000 File Offset: 0x00005200
	public int GetNumber0511_832()
	{
		return this.number5;
	}

	// Token: 0x0600012B RID: 299 RVA: 0x00007008 File Offset: 0x00005208
	private static int[] Method0833(int 1, int[] 2, int 3, int[] 4)
	{
		int num = 2.Length;
		int num2 = 4.Length;
		int num3 = 0;
		do
		{
			long num4 = ((long)2[--num] & (long)((ulong)-1)) - ((long)4[--num2] & (long)((ulong)-1)) + (long)num3;
			2[num] = (int)num4;
			num3 = (int)(num4 >> 63);
		}
		while (num2 > 3);
		if (num3 != 0)
		{
			int num6;
			do
			{
				int num5 = --num;
				num6 = 2[num5] - 1;
				2[num5] = num6;
			}
			while (num6 == -1);
		}
		return 2;
	}

	// Token: 0x0600012C RID: 300 RVA: 0x00007068 File Offset: 0x00005268
	public byte[] Method0834()
	{
		if (this.number5 == 0)
		{
			return new byte[0];
		}
		byte[] array = new byte[330.Method0809(this.Method0812())];
		this.Method0836(array, 0);
		return array;
	}

	// Token: 0x0600012D RID: 301 RVA: 0x0000709F File Offset: 0x0000529F
	public int Method0835()
	{
		return this.Method0836(null, 0);
	}

	// Token: 0x0600012E RID: 302 RVA: 0x000070AC File Offset: 0x000052AC
	public int Method0836(byte[] 1, int 2)
	{
		if (this.number5 == 0)
		{
			return 0;
		}
		int num = 330.Method0809(this.Method0812());
		if (1 == null)
		{
			return num;
		}
		int i = this.numberArray6.Length;
		int num2 = 2 + num;
		if (num2 > 1.Length)
		{
			throw new IndexOutOfRangeException();
		}
		while (i > 1)
		{
			uint num3 = (uint)this.numberArray6[--i];
			1[--num2] = (byte)num3;
			1[--num2] = (byte)(num3 >> 8);
			1[--num2] = (byte)(num3 >> 16);
			1[--num2] = (byte)(num3 >> 24);
		}
		uint num4;
		for (num4 = (uint)this.numberArray6[0]; num4 > 255U; num4 >>= 8)
		{
			1[--num2] = (byte)num4;
		}
		1[num2 - 1] = (byte)num4;
		return num;
	}

	// Token: 0x0600012F RID: 303 RVA: 0x0000715C File Offset: 0x0000535C
	private static 330 Method0837(ulong 1)
	{
		int num = (int)(1 >> 32);
		int num2 = (int)1;
		if (num != 0)
		{
			return new 330(1, new int[]
			{
				num,
				num2
			}, false);
		}
		if (num2 != 0)
		{
			return new 330(1, new int[]
			{
				num2
			}, false);
		}
		return 330._recoveredType01460507;
	}

	// Token: 0x06000130 RID: 304 RVA: 0x000071A5 File Offset: 0x000053A5
	public static 330 Method0838(ulong 1)
	{
		return 330.Method0837(1);
	}

	// Token: 0x06000131 RID: 305 RVA: 0x000071B0 File Offset: 0x000053B0
	private static int[] Method0839(int[] 1, int[] 2)
	{
		int num = 0;
		while (num < 1.Length && 1[num] == 0)
		{
			num++;
		}
		int num2 = 0;
		while (num2 < 2.Length && 2[num2] == 0)
		{
			num2++;
		}
		int num3 = 330.Method0816(num, 1, num2, 2);
		if (num3 > 0)
		{
			int num4 = 330.Method0811(1, num2, 2);
			int num5 = 330.Method0811(1, num, 1);
			int num6 = num5 - num4;
			int num7 = 0;
			int num8 = num4;
			int[] array;
			if (num6 > 0)
			{
				array = 330.Method0828(2, num6);
				num8 += num6;
			}
			else
			{
				int num9 = 2.Length - num2;
				array = new int[num9];
				Array.Copy(2, num2, array, 0, num9);
			}
			for (;;)
			{
				if (num8 < num5 || 330.Method0816(num, 1, num7, array) >= 0)
				{
					330.Method0833(num, 1, num7, array);
					while (1[num] == 0)
					{
						if (++num == 1.Length)
						{
							return 1;
						}
					}
					num5 = 32 * (1.Length - num - 1) + 330.Method0813(1[num]);
					if (num5 <= num4)
					{
						if (num5 < num4)
						{
							return 1;
						}
						num3 = 330.Method0816(num, 1, num2, 2);
						if (num3 <= 0)
						{
							goto IL_14A;
						}
					}
				}
				num6 = num8 - num5;
				if (num6 == 1)
				{
					uint num10 = (uint)array[num7] >> 1;
					uint num11 = (uint)1[num];
					if (num10 > num11)
					{
						num6++;
					}
				}
				if (num6 < 2)
				{
					330.Method0831(num7, array);
					num8--;
				}
				else
				{
					330.Method0830(num7, array, num6);
					num8 -= num6;
				}
				while (array[num7] == 0)
				{
					num7++;
				}
			}
			return 1;
		}
		IL_14A:
		if (num3 == 0)
		{
			Array.Clear(1, num, 1.Length - num);
		}
		return 1;
	}

	// Token: 0x06000132 RID: 306 RVA: 0x00007318 File Offset: 0x00005518
	private 330 Method0840(330 1)
	{
		if (this.number5 == 0)
		{
			return 330._recoveredType01460507;
		}
		if (330.Method0816(0, this.numberArray6, 0, 1.numberArray6) < 0)
		{
			return this;
		}
		int[] array = (int[])this.numberArray6.Clone();
		array = 330.Method0839(array, 1.numberArray6);
		return new 330(this.number5, array, true);
	}

	// Token: 0x06000133 RID: 307 RVA: 0x00007378 File Offset: 0x00005578
	private static int[] Method0841(int[] 1)
	{
		int[] array = new int[1.Length];
		Buffer.BlockCopy(1, 0, array, 0, 1.Length * 4);
		return array;
	}

	// Token: 0x04000071 RID: 113
	private static readonly int[] numberArray5 = new int[0];

	// Token: 0x04000072 RID: 114
	public static readonly 330 _recoveredType01460507;

	// Token: 0x04000073 RID: 115
	public static readonly 330 _recoveredType01460508;

	// Token: 0x04000074 RID: 116
	private static readonly byte[] byteArray2 = new byte[]
	{
		0,
		1,
		2,
		2,
		3,
		3,
		3,
		3,
		4,
		4,
		4,
		4,
		4,
		4,
		4,
		4,
		5,
		5,
		5,
		5,
		5,
		5,
		5,
		5,
		5,
		5,
		5,
		5,
		5,
		5,
		5,
		5,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		6,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		7,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8
	};

	// Token: 0x04000075 RID: 117
	private int[] numberArray6;

	// Token: 0x04000076 RID: 118
	private int number5;

	// Token: 0x04000077 RID: 119
	private int number6 = -1;

	// Token: 0x04000078 RID: 120
	private int number7;
}
