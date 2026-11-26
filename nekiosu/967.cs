using System;
using System.Runtime.InteropServices;

// Token: 0x020003A9 RID: 937
[810]
[ComVisible(false)]
[Serializable]
public sealed class 967
{
	// Token: 0x06001CCD RID: 7373 RVA: 0x000731B0 File Offset: 0x000713B0
	public 967()
	{
		this.IRState.IRSensors = new 957[4];
	}

	// Token: 0x04000E63 RID: 3683
	[519]
	public 940 AccelCalibrationInfo;

	// Token: 0x04000E64 RID: 3684
	[519]
	public 941 AccelState;

	// Token: 0x04000E65 RID: 3685
	[519]
	public 946 ButtonState;

	// Token: 0x04000E66 RID: 3686
	[519]
	public 958 IRState;

	// Token: 0x04000E67 RID: 3687
	[519]
	public byte BatteryRaw;

	// Token: 0x04000E68 RID: 3688
	[519]
	public float Battery;

	// Token: 0x04000E69 RID: 3689
	[519]
	public bool Rumble;

	// Token: 0x04000E6A RID: 3690
	[519]
	public bool Extension;

	// Token: 0x04000E6B RID: 3691
	[519]
	public 951 ExtensionType;

	// Token: 0x04000E6C RID: 3692
	[519]
	public 961 NunchukState;

	// Token: 0x04000E6D RID: 3693
	[519]
	public 949 ClassicControllerState;

	// Token: 0x04000E6E RID: 3694
	[519]
	public 954 GuitarState;

	// Token: 0x04000E6F RID: 3695
	[519]
	public 966 TaikoDrumState;

	// Token: 0x04000E70 RID: 3696
	[519]
	public 950 DrumsState;

	// Token: 0x04000E71 RID: 3697
	public 945 BalanceBoardState;

	// Token: 0x04000E72 RID: 3698
	[519]
	public 959 LEDState;
}
