using System;
using System.Runtime.InteropServices;
using OpenTK;
using OpenTK.Graphics.ES20;

// Token: 0x02000B22 RID: 2850
public struct 1394 : IEquatable<1394>
{
	// Token: 0x06004F07 RID: 20231 RVA: 0x001F3656 File Offset: 0x001F1856
	public bool Equals(1394 1)
	{
		return this.Position.Equals(1.Position) && this.TexturePosition.Equals(1.TexturePosition) && this.Colour.Equals(1.Colour);
	}

	// Token: 0x06004F08 RID: 20232 RVA: 0x001F3694 File Offset: 0x001F1894
	public static void Bind()
	{
		1507.1(3);
		GL.VertexAttribPointer(0, 2, 5126, false, 1394.Stride, 1394.1);
		GL.VertexAttribPointer(1, 4, 5121, true, 1394.Stride, 1394.2);
		GL.VertexAttribPointer(2, 2, 5126, false, 1394.Stride, 1394.3);
	}

	// Token: 0x04003AFE RID: 15102
	public 208 Position;

	// Token: 0x04003AFF RID: 15103
	public 198 Colour;

	// Token: 0x04003B00 RID: 15104
	public 208 TexturePosition;

	// Token: 0x04003B01 RID: 15105
	private static readonly IntPtr 1 = Marshal.OffsetOf(typeof(1394), "Position");

	// Token: 0x04003B02 RID: 15106
	private static readonly IntPtr 2 = Marshal.OffsetOf(typeof(1394), "Colour");

	// Token: 0x04003B03 RID: 15107
	private static readonly IntPtr 3 = Marshal.OffsetOf(typeof(1394), "TexturePosition");

	// Token: 0x04003B04 RID: 15108
	public static readonly int Stride = BlittableValueType.StrideOf<1394>(default(1394));
}
