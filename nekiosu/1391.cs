using System;
using System.Runtime.InteropServices;
using OpenTK;
using OpenTK.Graphics.ES20;

// Token: 0x02000B1F RID: 2847
public struct 1391 : IEquatable<1391>
{
	// Token: 0x06004EFE RID: 20222 RVA: 0x001F33E8 File Offset: 0x001F15E8
	public bool Equals(1391 1)
	{
		return this.Position.Equals(1.Position) && this.TexturePosition.Equals(1.TexturePosition) && this.Colour.Equals(1.Colour) && this.Time.Equals(1.Time) && this.Direction.Equals(1.Direction);
	}

	// Token: 0x06004EFF RID: 20223 RVA: 0x001F3454 File Offset: 0x001F1654
	public static void Bind()
	{
		1507.1(5);
		GL.VertexAttribPointer(0, 2, 5126, false, 1391.Stride, 1391.1);
		GL.VertexAttribPointer(1, 4, 5121, true, 1391.Stride, 1391.2);
		GL.VertexAttribPointer(2, 2, 5126, false, 1391.Stride, 1391.3);
		GL.VertexAttribPointer(3, 1, 5126, false, 1391.Stride, 1391.4);
		GL.VertexAttribPointer(4, 2, 5126, false, 1391.Stride, 1391.5);
	}

	// Token: 0x04003AEF RID: 15087
	public 208 Position;

	// Token: 0x04003AF0 RID: 15088
	public 198 Colour;

	// Token: 0x04003AF1 RID: 15089
	public 208 TexturePosition;

	// Token: 0x04003AF2 RID: 15090
	public float Time;

	// Token: 0x04003AF3 RID: 15091
	public 208 Direction;

	// Token: 0x04003AF4 RID: 15092
	private static readonly IntPtr 1 = Marshal.OffsetOf(typeof(1391), "Position");

	// Token: 0x04003AF5 RID: 15093
	private static readonly IntPtr 2 = Marshal.OffsetOf(typeof(1391), "Colour");

	// Token: 0x04003AF6 RID: 15094
	private static readonly IntPtr 3 = Marshal.OffsetOf(typeof(1391), "TexturePosition");

	// Token: 0x04003AF7 RID: 15095
	private static readonly IntPtr 4 = Marshal.OffsetOf(typeof(1391), "Time");

	// Token: 0x04003AF8 RID: 15096
	private static readonly IntPtr 5 = Marshal.OffsetOf(typeof(1391), "Direction");

	// Token: 0x04003AF9 RID: 15097
	public static readonly int Stride = BlittableValueType.StrideOf<1391>(default(1391));
}
