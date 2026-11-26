using System;
using System.Runtime.InteropServices;
using OpenTK;
using OpenTK.Graphics.ES20;

// Token: 0x02000B24 RID: 2852
public struct 1396 : IEquatable<1396>
{
	// Token: 0x06004F0D RID: 20237 RVA: 0x001F3858 File Offset: 0x001F1A58
	public bool Equals(1396 1)
	{
		return this.Position.Equals(1.Position) && this.TexturePosition.Equals(1.TexturePosition) && this.Colour.Equals(1.Colour) && this.Time.Equals(1.Time);
	}

	// Token: 0x06004F0E RID: 20238 RVA: 0x001F38B4 File Offset: 0x001F1AB4
	public static void Bind()
	{
		1507.1(4);
		GL.VertexAttribPointer(0, 2, 5126, false, 1396.Stride, 1396.1);
		GL.VertexAttribPointer(1, 4, 5121, true, 1396.Stride, 1396.2);
		GL.VertexAttribPointer(2, 2, 5126, false, 1396.Stride, 1396.3);
		GL.VertexAttribPointer(3, 1, 5126, false, 1396.Stride, 1396.4);
	}

	// Token: 0x04003B0C RID: 15116
	public 208 Position;

	// Token: 0x04003B0D RID: 15117
	public 198 Colour;

	// Token: 0x04003B0E RID: 15118
	public 208 TexturePosition;

	// Token: 0x04003B0F RID: 15119
	public float Time;

	// Token: 0x04003B10 RID: 15120
	private static readonly IntPtr 1 = Marshal.OffsetOf(typeof(1396), "Position");

	// Token: 0x04003B11 RID: 15121
	private static readonly IntPtr 2 = Marshal.OffsetOf(typeof(1396), "Colour");

	// Token: 0x04003B12 RID: 15122
	private static readonly IntPtr 3 = Marshal.OffsetOf(typeof(1396), "TexturePosition");

	// Token: 0x04003B13 RID: 15123
	private static readonly IntPtr 4 = Marshal.OffsetOf(typeof(1396), "Time");

	// Token: 0x04003B14 RID: 15124
	public static readonly int Stride = BlittableValueType.StrideOf<1396>(default(1396));
}
