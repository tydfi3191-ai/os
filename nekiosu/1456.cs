using System;

// Token: 0x02000ADF RID: 2783
[Flags]
public enum 1456
{
	// Token: 0x040039D3 RID: 14803
	None = 0,
	// Token: 0x040039D4 RID: 14804
	Movement = 1,
	// Token: 0x040039D5 RID: 14805
	Fade = 2,
	// Token: 0x040039D6 RID: 14806
	Scale = 4,
	// Token: 0x040039D7 RID: 14807
	Rotation = 8,
	// Token: 0x040039D8 RID: 14808
	Colour = 16,
	// Token: 0x040039D9 RID: 14809
	ParameterFlipHorizontal = 32,
	// Token: 0x040039DA RID: 14810
	ParameterFlipVertical = 64,
	// Token: 0x040039DB RID: 14811
	MovementX = 128,
	// Token: 0x040039DC RID: 14812
	MovementY = 256,
	// Token: 0x040039DD RID: 14813
	VectorScale = 512,
	// Token: 0x040039DE RID: 14814
	ParameterAdditive = 1024,
	// Token: 0x040039DF RID: 14815
	ClippingWidth = 2048,
	// Token: 0x040039E0 RID: 14816
	ClippingHeight = 4096,
	// Token: 0x040039E1 RID: 14817
	ClipRectangle = 8192,
	// Token: 0x040039E2 RID: 14818
	Blur = 16384
}
