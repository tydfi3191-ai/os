using System;
using System.Runtime.InteropServices;
using OpenTK;
using OpenTK.Graphics.ES20;

// Token: 0x02000B26 RID: 2854
public struct 1398 : IEquatable<1398>
{
	// Token: 0x06004F13 RID: 20243 RVA: 0x001F3A15 File Offset: 0x001F1C15
	public bool Equals(1398 1)
	{
		return this.Position.Equals(1.Position) && this.Colour.Equals(1.Colour);
	}

	// Token: 0x06004F14 RID: 20244 RVA: 0x001F3A3D File Offset: 0x001F1C3D
	public static void Bind()
	{
		1507.1(2);
		GL.VertexAttribPointer(0, 2, 5126, false, 1398.Stride, 1398.1);
		GL.VertexAttribPointer(1, 4, 5121, true, 1398.Stride, 1398.2);
	}

	// Token: 0x04003B18 RID: 15128
	public 208 Position;

	// Token: 0x04003B19 RID: 15129
	public 198 Colour;

	// Token: 0x04003B1A RID: 15130
	private static readonly IntPtr 1 = Marshal.OffsetOf(typeof(1398), "Position");

	// Token: 0x04003B1B RID: 15131
	private static readonly IntPtr 2 = Marshal.OffsetOf(typeof(1398), "Colour");

	// Token: 0x04003B1C RID: 15132
	public static readonly int Stride = BlittableValueType.StrideOf<1398>(default(1398));
}
