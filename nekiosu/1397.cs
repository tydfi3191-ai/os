using System;
using System.Runtime.InteropServices;
using OpenTK;
using OpenTK.Graphics.ES20;

// Token: 0x02000B25 RID: 2853
public struct 1397 : IEquatable<1397>
{
	// Token: 0x06004F10 RID: 20240 RVA: 0x001F39A8 File Offset: 0x001F1BA8
	public bool Equals(1397 1)
	{
		return this.Position.Equals(1.Position);
	}

	// Token: 0x06004F11 RID: 20241 RVA: 0x001F39BB File Offset: 0x001F1BBB
	public static void Bind()
	{
		1507.1(1);
		GL.VertexAttribPointer(0, 2, 5126, false, 1397.Stride, 1397.1);
	}

	// Token: 0x04003B15 RID: 15125
	public 208 Position;

	// Token: 0x04003B16 RID: 15126
	private static readonly IntPtr 1 = Marshal.OffsetOf(typeof(1397), "Position");

	// Token: 0x04003B17 RID: 15127
	public static readonly int Stride = BlittableValueType.StrideOf<1397>(default(1397));
}
