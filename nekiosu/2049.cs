using System;
using System.Collections.Generic;

// Token: 0x02000817 RID: 2071
[276]
public interface 2049 : 1054, IDisposable
{
	// Token: 0x06003C37 RID: 15415
	List<198> GetComboColours();

	// Token: 0x06003C38 RID: 15416
	void SetComboColours(List<198> 1);

	// Token: 0x06003C39 RID: 15417
	198 GetFallbackColour();

	// Token: 0x06003C3A RID: 15418
	void SetFallbackColour(198 1);

	// Token: 0x06003C3B RID: 15419
	198 GetDefaultColour();

	// Token: 0x06003C3C RID: 15420
	void SetDefaultColour(198 1);

	// Token: 0x06003C3D RID: 15421
	198 GetBorderColour();

	// Token: 0x06003C3E RID: 15422
	void SetBorderColour(198 1);

	// Token: 0x06003C3F RID: 15423
	float GetBodyWidth();

	// Token: 0x06003C40 RID: 15424
	void SetBodyWidth(float 1);

	// Token: 0x06003C41 RID: 15425
	void SetColours(List<198> 1, 198 2, 198 3, 198 4, float 5);

	// Token: 0x06003C42 RID: 15426
	void DrawPath(List<1051> 1, 1051 2, float 3, 198 4, 198 5);

	// Token: 0x06003C43 RID: 15427
	void DrawPath(List<1051> 1, 1051 2, float 3, int 4);

	// Token: 0x06003C44 RID: 15428
	void DrawPath(List<1051> 1, 1051 2, float 3, int 4, 198 5);
}
