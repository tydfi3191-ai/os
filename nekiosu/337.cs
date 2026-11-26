using System;

// Token: 0x020002AD RID: 685
public static class 337
{
	// Token: 0x060014C2 RID: 5314 RVA: 0x00048140 File Offset: 0x00046340
	public static byte[] Method0974(Array 1, 335 2, Func<byte[]> 3)
	{
		if (1 == null)
		{
			return null;
		}
		if (1.Length == 0)
		{
			return new byte[0];
		}
		int num = Buffer.ByteLength(1);
		byte[] array = new byte[num];
		byte[] array2 = null;
		byte[] array3 = 1 as byte[];
		byte[] array4;
		if (array3 != null)
		{
			array4 = array3;
		}
		else
		{
			array2 = new byte[Math.Min(num, 16)];
			array4 = array2;
		}
		int num2 = 0;
		byte[] array5 = null;
		int num3 = num / 16;
		if (num3 > 0)
		{
			array5 = 3();
			for (int i = 0; i < num3; i++)
			{
				int num4 = 0;
				if (array3 != null)
				{
					num4 = num2;
				}
				else
				{
					Buffer.BlockCopy(1, num2, array2, 0, 16);
				}
				int num5 = num2;
				array[num5++] = array4[num4 + (int)array5[0]];
				array[num5++] = array4[num4 + (int)array5[1]];
				array[num5++] = array4[num4 + (int)array5[2]];
				array[num5++] = array4[num4 + (int)array5[3]];
				array[num5++] = array4[num4 + (int)array5[4]];
				array[num5++] = array4[num4 + (int)array5[5]];
				array[num5++] = array4[num4 + (int)array5[6]];
				array[num5++] = array4[num4 + (int)array5[7]];
				array[num5++] = array4[num4 + (int)array5[8]];
				array[num5++] = array4[num4 + (int)array5[9]];
				array[num5++] = array4[num4 + (int)array5[10]];
				array[num5++] = array4[num4 + (int)array5[11]];
				array[num5++] = array4[num4 + (int)array5[12]];
				array[num5++] = array4[num4 + (int)array5[13]];
				array[num5++] = array4[num4 + (int)array5[14]];
				array[num5++] = array4[num4 + (int)array5[15]];
				283.Method0064(array, num2, 2.number);
				283.Method0064(array, num2 + 4, 2.number2);
				283.Method0064(array, num2 + 8, 2.number3);
				283.Method0064(array, num2 + 12, 2.number4);
				num2 += 16;
			}
		}
		if (num2 < num)
		{
			num3 = (num - num2) / 4;
			if (num3 > 0)
			{
				if (array5 == null)
				{
					array5 = 3();
				}
				for (int j = 0; j < num3; j++)
				{
					int num6 = 0;
					if (array3 != null)
					{
						num6 = num2;
					}
					else
					{
						Buffer.BlockCopy(1, num2, array2, 0, 4);
					}
					int num7 = num2;
					array[num7++] = array4[num6 + (int)array5[16]];
					array[num7++] = array4[num6 + (int)array5[17]];
					array[num7++] = array4[num6 + (int)array5[18]];
					array[num7++] = array4[num6 + (int)array5[19]];
					283.Method0064(array, num2, 2.number);
					num2 += 4;
				}
			}
		}
		int num8 = num - num2;
		if (num8 > 0)
		{
			Buffer.BlockCopy(1, num2, array, num2, num8);
			283.Method0065(array, num2, 2.number);
		}
		if (array5 != null)
		{
			Array.Clear(array5, 0, array5.Length);
		}
		if (array2 != null)
		{
			Array.Clear(array2, 0, array2.Length);
		}
		return array;
	}

	// Token: 0x060014C3 RID: 5315 RVA: 0x0004845C File Offset: 0x0004665C
	public static T[] Method0975<T>(byte[] 1, int 2, 335 3, Func<byte[]> 4, bool 5)
	{
		if (1 == null)
		{
			return null;
		}
		if (1.Length - 2 <= 0)
		{
			return new T[0];
		}
		int num = 1.Length - 2;
		int number = 323<T>._number0229;
		T[] array = new T[num / number];
		int num2 = 0;
		byte[] array2 = new byte[Math.Min(num, 16)];
		byte[] array3 = null;
		byte[] array4;
		if (array is byte[])
		{
			array4 = (array as byte[]);
		}
		else
		{
			array3 = new byte[array2.Length];
			array4 = array3;
		}
		byte[] array5 = null;
		int num3 = (num - num2) / 16;
		if (num3 > 0)
		{
			array5 = 4();
			for (int i = 0; i < num3; i++)
			{
				Array.Copy(1, num2 + 2, array2, 0, 16);
				283.Method0064(array2, 0, 3.number);
				283.Method0064(array2, 4, 3.number2);
				283.Method0064(array2, 8, 3.number3);
				283.Method0064(array2, 12, 3.number4);
				int num4 = 0;
				int num5 = 0;
				if (array4 == array)
				{
					num5 = num2;
				}
				array4[num5 + (int)array5[0]] = array2[num4++];
				array4[num5 + (int)array5[1]] = array2[num4++];
				array4[num5 + (int)array5[2]] = array2[num4++];
				array4[num5 + (int)array5[3]] = array2[num4++];
				array4[num5 + (int)array5[4]] = array2[num4++];
				array4[num5 + (int)array5[5]] = array2[num4++];
				array4[num5 + (int)array5[6]] = array2[num4++];
				array4[num5 + (int)array5[7]] = array2[num4++];
				array4[num5 + (int)array5[8]] = array2[num4++];
				array4[num5 + (int)array5[9]] = array2[num4++];
				array4[num5 + (int)array5[10]] = array2[num4++];
				array4[num5 + (int)array5[11]] = array2[num4++];
				array4[num5 + (int)array5[12]] = array2[num4++];
				array4[num5 + (int)array5[13]] = array2[num4++];
				array4[num5 + (int)array5[14]] = array2[num4++];
				array4[num5 + (int)array5[15]] = array2[num4++];
				if (array4 != array)
				{
					Buffer.BlockCopy(array4, 0, array, num2, 16);
				}
				num2 += 16;
			}
		}
		num3 = (num - num2) / 4;
		if (num3 > 0)
		{
			if (array5 == null)
			{
				array5 = 4();
			}
			for (int j = 0; j < num3; j++)
			{
				Array.Copy(1, num2 + 2, array2, 0, 4);
				283.Method0064(array2, 0, 3.number);
				int num6 = 0;
				int num7 = 0;
				if (array4 == array)
				{
					num7 = num2;
				}
				array4[num7 + (int)array5[16]] = array2[num6++];
				array4[num7 + (int)array5[17]] = array2[num6++];
				array4[num7 + (int)array5[18]] = array2[num6++];
				array4[num7 + (int)array5[19]] = array2[num6++];
				if (array4 != array)
				{
					Buffer.BlockCopy(array3, 0, array, num2, 4);
				}
				num2 += 4;
			}
		}
		int num8 = num - num2;
		if (num8 > 0)
		{
			Array.Copy(1, num2 + 2, array2, 0, num8);
			283.Method0065(array2, 0, 3.number);
			Buffer.BlockCopy(array2, 0, array, num2, num8);
		}
		if (array5 != null)
		{
			Array.Clear(array5, 0, array5.Length);
		}
		Array.Clear(array2, 0, array2.Length);
		if (array3 != null)
		{
			Array.Clear(array3, 0, array3.Length);
		}
		if (5 && !BitConverter.IsLittleEndian && array.Length != 0 && number != 1)
		{
			337.Method0976<T>(array);
		}
		return array;
	}

	// Token: 0x060014C4 RID: 5316 RVA: 0x000487E8 File Offset: 0x000469E8
	private static void Method0976<T>(T[] 1)
	{
		int number = 323<T>._number0229;
		if (number == 1)
		{
			return;
		}
		byte[] array = new byte[number];
		byte[] array2 = new byte[number];
		for (int i = 0; i < 1.Length; i++)
		{
			Buffer.BlockCopy(1, i * number, array, 0, number);
			if (typeof(T) == typeof(float) && !287.flag)
			{
				1[i] = (T)((object)179.ReadSingle(array, 0));
			}
			else if (typeof(T) == typeof(double) && !328.flag)
			{
				1[i] = (T)((object)179.ReadDouble(array, 0));
			}
			else
			{
				for (int j = 0; j < number; j++)
				{
					array2[number - j - 1] = array[j];
				}
				Buffer.BlockCopy(array2, 0, 1, i * number, number);
			}
		}
		Array.Clear(array, 0, array.Length);
		Array.Clear(array2, 0, array2.Length);
	}
}
