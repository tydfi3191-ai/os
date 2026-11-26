using System;
using System.Runtime.InteropServices;
using OpenTK;
using OpenTK.Graphics.ES20;

// Token: 0x02000B23 RID: 2851
public struct 1395 : IEquatable<1395>
{
	// Token: 0x06004F0A RID: 20234 RVA: 0x001F3757 File Offset: 0x001F1957
	public bool Equals(1395 1)
	{
		return this.Position.Equals(1.Position) && this.TexturePosition.Equals(1.TexturePosition) && this.Colour.Equals(1.Colour);
	}

	// Token: 0x06004F0B RID: 20235 RVA: 0x001F3794 File Offset: 0x001F1994
	public static void Bind()
	{
		1507.1(3);
		GL.VertexAttribPointer(0, 3, 5126, false, 1395.Stride, 1395.1);
		GL.VertexAttribPointer(1, 4, 5121, true, 1395.Stride, 1395.2);
		GL.VertexAttribPointer(2, 2, 5126, false, 1395.Stride, 1395.3);
	}

	// Token: 0x04003B05 RID: 15109
	public 209 Position;

	// Token: 0x04003B06 RID: 15110
	public 198 Colour;

	// Token: 0x04003B07 RID: 15111
	public 208 TexturePosition;

	// Token: 0x04003B08 RID: 15112
	private static readonly IntPtr 1 = Marshal.OffsetOf(typeof(1395), "Position");

	// Token: 0x04003B09 RID: 15113
	private static readonly IntPtr 2 = Marshal.OffsetOf(typeof(1395), "Colour");

	// Token: 0x04003B0A RID: 15114
	private static readonly IntPtr 3 = Marshal.OffsetOf(typeof(1395), "TexturePosition");

	// Token: 0x04003B0B RID: 15115
	public static readonly int Stride = BlittableValueType.StrideOf<1395>(default(1395));
}
