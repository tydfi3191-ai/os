using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

// Token: 0x020002F9 RID: 761
[ComVisible(false)]
public abstract class 560 : SymmetricAlgorithm
{
	// Token: 0x060016E0 RID: 5856 RVA: 0x0004F4D0 File Offset: 0x0004D6D0
	public static byte[] Method7523(byte[] 1)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("#=z5L0SEnY=");
		}
		if (1.Length == 0)
		{
			throw new ArgumentException("Length is zero", "#=z5L0SEnY=");
		}
		uint[] array = new uint[]
		{
			305419896U,
			591751049U,
			878082192U
		};
		for (int i = 0; i < 1.Length; i++)
		{
			array[0] = 597.Method8131(array[0], 1[i]);
			array[1] = array[1] + (uint)((byte)array[0]);
			array[1] = array[1] * 134775813U + 1U;
			array[2] = 597.Method8131(array[2], (byte)(array[1] >> 24));
		}
		return new byte[]
		{
			(byte)array[0],
			(byte)(array[0] >> 8),
			(byte)(array[0] >> 16),
			(byte)(array[0] >> 24),
			(byte)array[1],
			(byte)(array[1] >> 8),
			(byte)(array[1] >> 16),
			(byte)(array[1] >> 24),
			(byte)array[2],
			(byte)(array[2] >> 8),
			(byte)(array[2] >> 16),
			(byte)(array[2] >> 24)
		};
	}
}
