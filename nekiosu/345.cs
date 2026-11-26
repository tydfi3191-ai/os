using System;

// Token: 0x020002AE RID: 686
public sealed class 345 : IEquatable<345>
{
	// Token: 0x060014C5 RID: 5317 RVA: 0x000488E2 File Offset: 0x00046AE2
	public int GetNumber0629_1093()
	{
		return this.number2;
	}

	// Token: 0x060014C6 RID: 5318 RVA: 0x000488EA File Offset: 0x00046AEA
	public void SetNumber0629_1094(int 1)
	{
		this.number2 = 1;
	}

	// Token: 0x060014C7 RID: 5319 RVA: 0x000488F3 File Offset: 0x00046AF3
	public int GetNumber0630_1095()
	{
		return this.number3;
	}

	// Token: 0x060014C8 RID: 5320 RVA: 0x000488FB File Offset: 0x00046AFB
	public void SetNumber0630_1096(int 1)
	{
		this.number3 = 1;
	}

	// Token: 0x060014C9 RID: 5321 RVA: 0x00048904 File Offset: 0x00046B04
	public int GetNumber0631_1097()
	{
		return this.number4;
	}

	// Token: 0x060014CA RID: 5322 RVA: 0x0004890C File Offset: 0x00046B0C
	public void SetNumber0631_1098(int 1)
	{
		this.number4 = 1;
	}

	// Token: 0x060014CB RID: 5323 RVA: 0x00048915 File Offset: 0x00046B15
	public int GetNumber0632_1099()
	{
		return this.number5;
	}

	// Token: 0x060014CC RID: 5324 RVA: 0x0004891D File Offset: 0x00046B1D
	public void SetNumber0632_1100(int 1)
	{
		this.number5 = 1;
	}

	// Token: 0x060014CD RID: 5325 RVA: 0x00048926 File Offset: 0x00046B26
	public int GetNumber0633_1101()
	{
		return this.number6;
	}

	// Token: 0x060014CE RID: 5326 RVA: 0x0004892E File Offset: 0x00046B2E
	public void SetNumber0633_1102(int 1)
	{
		this.number6 = 1;
	}

	// Token: 0x060014CF RID: 5327 RVA: 0x00048937 File Offset: 0x00046B37
	public static 345 GetRecoveredType02000634_1103()
	{
		return 345._recoveredType02000634;
	}

	// Token: 0x060014D0 RID: 5328 RVA: 0x0004893E File Offset: 0x00046B3E
	public override bool Equals(object 1)
	{
		return 345.Method1104(this, 1 as 345);
	}

	// Token: 0x060014D1 RID: 5329 RVA: 0x0004894C File Offset: 0x00046B4C
	public bool Equals(345 1)
	{
		return 345.Method1104(this, 1);
	}

	// Token: 0x060014D2 RID: 5330 RVA: 0x00048958 File Offset: 0x00046B58
	public static bool Method1104(345 1, 345 2)
	{
		return 1 == 2 || (1 != null && 2 != null && (1.GetNumber0629_1093() == 2.GetNumber0629_1093() && 1.GetNumber0630_1095() == 2.GetNumber0630_1095() && 1.GetNumber0631_1097() == 2.GetNumber0631_1097() && 1.GetNumber0632_1099() == 2.GetNumber0632_1099()) && 1.GetNumber0633_1101() == 2.GetNumber0633_1101());
	}

	// Token: 0x060014D3 RID: 5331 RVA: 0x000489BC File Offset: 0x00046BBC
	public override int GetHashCode()
	{
		return ((((-8832819 + this.GetNumber0629_1093().GetHashCode()) * -1521134295 + this.GetNumber0630_1095().GetHashCode()) * -1521134295 + this.GetNumber0631_1097().GetHashCode()) * -1521134295 + this.GetNumber0632_1099().GetHashCode()) * -1521134295 + this.GetNumber0633_1101().GetHashCode();
	}

	// Token: 0x040009C6 RID: 2502
	private int number2 = 255;

	// Token: 0x040009C7 RID: 2503
	private int number3 = 12;

	// Token: 0x040009C8 RID: 2504
	private int number4 = 96;

	// Token: 0x040009C9 RID: 2505
	private int number5 = 10;

	// Token: 0x040009CA RID: 2506
	private int number6 = 4;

	// Token: 0x040009CB RID: 2507
	private static readonly 345 _recoveredType02000634 = new 345();
}
