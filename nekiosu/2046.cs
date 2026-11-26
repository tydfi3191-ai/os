using System;
using System.Collections.Generic;

// Token: 0x0200080E RID: 2062
[276]
public abstract class 2046 : MarshalByRefObject
{
	// Token: 0x06003C0D RID: 15373
	public abstract 2024 GetBeatmap();

	// Token: 0x06003C0E RID: 15374
	public abstract List<2036> CloneHitObjectData();

	// Token: 0x06003C0F RID: 15375
	public abstract double GetNormalizedDifficulty(double 1);

	// Token: 0x06003C10 RID: 15376
	public abstract double GetDifficultyRange(double 1, double 2, double 3, double 4);

	// Token: 0x06003C11 RID: 15377
	public abstract double GetSliderVelocityAt(int 1);

	// Token: 0x04002C42 RID: 11330
	public float 1;

	// Token: 0x04002C43 RID: 11331
	public int 2;

	// Token: 0x04002C44 RID: 11332
	public int 3;

	// Token: 0x04002C45 RID: 11333
	public int 4;

	// Token: 0x04002C46 RID: 11334
	public int 5;

	// Token: 0x04002C47 RID: 11335
	public double 6;

	// Token: 0x04002C48 RID: 11336
	public double 7;

	// Token: 0x04002C49 RID: 11337
	public float 8;
}
