using System;
using System.Runtime.InteropServices;

// Token: 0x020000F4 RID: 244
[AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
[ComVisible(false)]
public sealed class 524 : 129
{
	// Token: 0x17000076 RID: 118
	// (get) Token: 0x06000869 RID: 2153 RVA: 0x0001CC05 File Offset: 0x0001AE05
	// (set) Token: 0x0600086A RID: 2154 RVA: 0x0001CC0D File Offset: 0x0001AE0D
	public 698 RecoveredType19324814
	{
		get
		{
			return this._recoveredType19324810;
		}
		set
		{
			this._recoveredType19324810 = value;
		}
	}

	// Token: 0x17000077 RID: 119
	// (get) Token: 0x0600086B RID: 2155 RVA: 0x0001CC16 File Offset: 0x0001AE16
	// (set) Token: 0x0600086C RID: 2156 RVA: 0x0001CC23 File Offset: 0x0001AE23
	public 492 RecoveredType09354815
	{
		get
		{
			return this.nullable.GetValueOrDefault();
		}
		set
		{
			this.nullable = new 492?(value);
		}
	}

	// Token: 0x17000078 RID: 120
	// (get) Token: 0x0600086D RID: 2157 RVA: 0x0001CC31 File Offset: 0x0001AE31
	// (set) Token: 0x0600086E RID: 2158 RVA: 0x0001CC3E File Offset: 0x0001AE3E
	public 240 RecoveredType11884816
	{
		get
		{
			return this.nullable3.GetValueOrDefault();
		}
		set
		{
			this.nullable3 = new 240?(value);
		}
	}

	// Token: 0x17000079 RID: 121
	// (get) Token: 0x0600086F RID: 2159 RVA: 0x0001CC4C File Offset: 0x0001AE4C
	// (set) Token: 0x06000870 RID: 2160 RVA: 0x0001CC59 File Offset: 0x0001AE59
	public 896 RecoveredType07394817
	{
		get
		{
			return this.nullable2.GetValueOrDefault();
		}
		set
		{
			this.nullable2 = new 896?(value);
		}
	}

	// Token: 0x06000871 RID: 2161 RVA: 0x0001CC67 File Offset: 0x0001AE67
	public 524()
	{
	}

	// Token: 0x06000872 RID: 2162 RVA: 0x0001CC6F File Offset: 0x0001AE6F
	public 524(698 1)
	{
		this.RecoveredType19324814 = 1;
	}

	// Token: 0x06000873 RID: 2163 RVA: 0x0001CC7E File Offset: 0x0001AE7E
	[242(1)]
	public 524(string 1) : base(1)
	{
	}

	// Token: 0x040004BB RID: 1211
	private 698 _recoveredType19324810;

	// Token: 0x040004BC RID: 1212
	internal 492? nullable;

	// Token: 0x040004BD RID: 1213
	internal 896? nullable2;

	// Token: 0x040004BE RID: 1214
	internal 240? nullable3;
}
