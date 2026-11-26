using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.Win32.SafeHandles;

// Token: 0x02000C52 RID: 3154
[ComVisible(false)]
public sealed class 1110 : IDisposable
{
	// Token: 0x0600548A RID: 21642 RVA: 0x0020C400 File Offset: 0x0020A600
	public 1110()
	{
	}

	// Token: 0x0600548B RID: 21643 RVA: 0x0020C468 File Offset: 0x0020A668
	internal 1110(string 1)
	{
		this.14 = 1;
	}

	// Token: 0x0600548C RID: 21644 RVA: 0x0020C4D4 File Offset: 0x0020A6D4
	public void 1()
	{
		if (string.IsNullOrEmpty(this.14))
		{
			1110.2(new 1110.1111(this.3));
			return;
		}
		this.4(this.14);
	}

	// Token: 0x0600548D RID: 21645 RVA: 0x0020C504 File Offset: 0x0020A704
	internal static void 2(1110.1111 1)
	{
		int num = 0;
		bool flag = false;
		Guid guid;
		1071.HidD_GetHidGuid(out guid);
		IntPtr intPtr = 1071.SetupDiGetClassDevs(ref guid, null, IntPtr.Zero, 16U);
		1071.1072 2 = default(1071.1072);
		2.1 = Marshal.SizeOf(2);
		while (1071.SetupDiEnumDeviceInterfaces(intPtr, IntPtr.Zero, ref guid, num, ref 2))
		{
			uint num2;
			1071.SetupDiGetDeviceInterfaceDetail(intPtr, ref 2, IntPtr.Zero, 0U, out num2, IntPtr.Zero);
			1071.1073 3 = new 1071.1073
			{
				1 = ((IntPtr.Size == 8) ? 8U : 5U)
			};
			if (!1071.SetupDiGetDeviceInterfaceDetail(intPtr, ref 2, ref 3, num2, out num2, IntPtr.Zero))
			{
				throw new 353("SetupDiGetDeviceInterfaceDetail failed on index " + num.ToString());
			}
			SafeFileHandle safeFileHandle = 1071.CreateFile(3.2, FileAccess.ReadWrite, FileShare.ReadWrite, IntPtr.Zero, FileMode.Open, (1071.1074)1073741824U, IntPtr.Zero);
			1071.1075 4 = default(1071.1075);
			4.1 = Marshal.SizeOf(4);
			if (1071.HidD_GetAttributes(safeFileHandle.DangerousGetHandle(), ref 4) && 4.2 == 1406 && 4.3 == 774)
			{
				flag = true;
				if (!1(3.2))
				{
					break;
				}
			}
			safeFileHandle.Close();
			num++;
		}
		1071.SetupDiDestroyDeviceInfoList(intPtr);
		if (!flag)
		{
			throw new 1113("No Wiimotes found in HID device list.");
		}
	}

	// Token: 0x0600548E RID: 21646 RVA: 0x0020C65F File Offset: 0x0020A85F
	private bool 3(string 1)
	{
		this.14 = 1;
		this.4(this.14);
		return false;
	}

	// Token: 0x0600548F RID: 21647 RVA: 0x0020C678 File Offset: 0x0020A878
	private void 4(string 1)
	{
		this.3 = 1071.CreateFile(1, FileAccess.ReadWrite, FileShare.ReadWrite, IntPtr.Zero, FileMode.Open, (1071.1074)1073741824U, IntPtr.Zero);
		1071.1075 2 = default(1071.1075);
		2.1 = Marshal.SizeOf(2);
		if (1071.HidD_GetAttributes(this.3.DangerousGetHandle(), ref 2))
		{
			if (2.2 != 1406 || 2.3 != 774)
			{
				this.3.Close();
				throw new 353("Attempted to open a non-Wiimote device.");
			}
			this.4 = new FileStream(this.3, FileAccess.ReadWrite, 22, true);
			this.5();
			try
			{
				this.16();
			}
			catch
			{
				this.13 = true;
				this.16();
			}
			this.21();
		}
	}

	// Token: 0x06005490 RID: 21648 RVA: 0x0020C74C File Offset: 0x0020A94C
	public void Disconnect()
	{
		if (this.4 != null)
		{
			this.4.Close();
		}
		if (this.3 != null)
		{
			this.3.Close();
		}
	}

	// Token: 0x06005491 RID: 21649 RVA: 0x0020C774 File Offset: 0x0020A974
	private void 5()
	{
		if (this.4 != null && this.4.CanRead)
		{
			byte[] array = new byte[22];
			this.4.BeginRead(array, 0, 22, new AsyncCallback(this.6), array);
		}
	}

	// Token: 0x06005492 RID: 21650 RVA: 0x0020C7BC File Offset: 0x0020A9BC
	private void 6(IAsyncResult 1)
	{
		byte[] array = (byte[])1.AsyncState;
		try
		{
			this.4.EndRead(1);
			if (this.7(array) && this.1 != null)
			{
				this.1(this, new 728(this.9));
			}
			this.5();
		}
		catch (OperationCanceledException)
		{
		}
	}

	// Token: 0x06005493 RID: 21651 RVA: 0x0020C828 File Offset: 0x0020AA28
	private bool 7(byte[] 1)
	{
		426 2 = (426)1[0];
		switch (2)
		{
		case (426)32:
		{
			this.9(1);
			this.9.BatteryRaw = 1[6];
			this.9.Battery = 4800f * ((float)1[6] / 48f) / 192f;
			this.9.LEDState.LED1 = ((1[3] & 16) > 0);
			this.9.LEDState.LED2 = ((1[3] & 32) > 0);
			this.9.LEDState.LED3 = ((1[3] & 64) > 0);
			this.9.LEDState.LED4 = ((1[3] & 128) > 0);
			bool flag = (1[3] & 2) > 0;
			if (this.9.Extension != flag)
			{
				this.9.Extension = flag;
				if (flag)
				{
					this.5();
					this.8();
				}
				else
				{
					this.9.ExtensionType = 951.None;
				}
				if (this.2 != null && this.9.ExtensionType != (951)((ulong)-1541405694))
				{
					this.2(this, new 813(this.9.ExtensionType, this.9.Extension));
				}
			}
			this.12.Set();
			break;
		}
		case (426)33:
			this.9(1);
			this.14(1);
			break;
		case (426)34:
			this.11.Set();
			break;
		default:
			switch (2)
			{
			case (426)48:
				this.9(1);
				return true;
			case (426)49:
				this.9(1);
				this.10(1);
				return true;
			case (426)51:
				this.9(1);
				this.10(1);
				this.11(1);
				return true;
			case (426)52:
				this.9(1);
				this.12(1, 3);
				return true;
			case (426)53:
				this.9(1);
				this.10(1);
				this.12(1, 6);
				return true;
			case (426)55:
				this.9(1);
				this.10(1);
				this.11(1);
				this.12(1, 16);
				return true;
			}
			return false;
		}
		return true;
	}

	// Token: 0x06005494 RID: 21652 RVA: 0x0020CA58 File Offset: 0x0020AC58
	private void 8()
	{
		this.27(77857008, 85);
		this.27(77857019, 0);
		this.5();
		byte[] array = this.26(77857018, 6);
		long num = (long)((ulong)array[0] << 40 | (ulong)array[1] << 32 | (ulong)array[2] << 24 | (ulong)array[3] << 16 | (ulong)array[4] << 8 | (ulong)array[5]);
		951 <<EMPTY_NAME>> = (951)num;
		if (<<EMPTY_NAME>> <= (951)((ulong)-1541406461))
		{
			if (<<EMPTY_NAME>> <= (951)((ulong)-1541406720))
			{
				if (<<EMPTY_NAME>> != 951.None)
				{
					if (<<EMPTY_NAME>> != (951)((ulong)-1541406720))
					{
						goto IL_600;
					}
					goto IL_E9;
				}
			}
			else
			{
				if (<<EMPTY_NAME>> != (951)((ulong)-1541406463) && <<EMPTY_NAME>> != (951)((ulong)-1541406461))
				{
					goto IL_600;
				}
				goto IL_E9;
			}
		}
		else if (<<EMPTY_NAME>> <= (951)((ulong)-1541405694))
		{
			if (<<EMPTY_NAME>> != (951)((ulong)-1541406447) && <<EMPTY_NAME>> != (951)((ulong)-1541405694))
			{
				goto IL_600;
			}
			goto IL_E9;
		}
		else
		{
			if (<<EMPTY_NAME>> == 951.Drums)
			{
				goto IL_E9;
			}
			if (<<EMPTY_NAME>> != 951.ParitallyInserted)
			{
				goto IL_600;
			}
		}
		this.9.Extension = false;
		this.9.ExtensionType = 951.None;
		return;
		IL_E9:
		this.9.ExtensionType = (951)num;
		this.17((426)52, true);
		951 extensionType = this.9.ExtensionType;
		if (extensionType == (951)((ulong)-1541406720))
		{
			array = this.26(77856800, 16);
			this.9.NunchukState.CalibrationInfo.AccelCalibration.X0 = array[0];
			this.9.NunchukState.CalibrationInfo.AccelCalibration.Y0 = array[1];
			this.9.NunchukState.CalibrationInfo.AccelCalibration.Z0 = array[2];
			this.9.NunchukState.CalibrationInfo.AccelCalibration.XG = array[4];
			this.9.NunchukState.CalibrationInfo.AccelCalibration.YG = array[5];
			this.9.NunchukState.CalibrationInfo.AccelCalibration.ZG = array[6];
			this.9.NunchukState.CalibrationInfo.MaxX = array[8];
			this.9.NunchukState.CalibrationInfo.MinX = array[9];
			this.9.NunchukState.CalibrationInfo.MidX = array[10];
			this.9.NunchukState.CalibrationInfo.MaxY = array[11];
			this.9.NunchukState.CalibrationInfo.MinY = array[12];
			this.9.NunchukState.CalibrationInfo.MidY = array[13];
			return;
		}
		if (extensionType == (951)((ulong)-1541406463))
		{
			array = this.26(77856800, 16);
			this.9.ClassicControllerState.CalibrationInfo.MaxXL = (byte)(array[0] >> 2);
			this.9.ClassicControllerState.CalibrationInfo.MinXL = (byte)(array[1] >> 2);
			this.9.ClassicControllerState.CalibrationInfo.MidXL = (byte)(array[2] >> 2);
			this.9.ClassicControllerState.CalibrationInfo.MaxYL = (byte)(array[3] >> 2);
			this.9.ClassicControllerState.CalibrationInfo.MinYL = (byte)(array[4] >> 2);
			this.9.ClassicControllerState.CalibrationInfo.MidYL = (byte)(array[5] >> 2);
			this.9.ClassicControllerState.CalibrationInfo.MaxXR = (byte)(array[6] >> 3);
			this.9.ClassicControllerState.CalibrationInfo.MinXR = (byte)(array[7] >> 3);
			this.9.ClassicControllerState.CalibrationInfo.MidXR = (byte)(array[8] >> 3);
			this.9.ClassicControllerState.CalibrationInfo.MaxYR = (byte)(array[9] >> 3);
			this.9.ClassicControllerState.CalibrationInfo.MinYR = (byte)(array[10] >> 3);
			this.9.ClassicControllerState.CalibrationInfo.MidYR = (byte)(array[11] >> 3);
			this.9.ClassicControllerState.CalibrationInfo.MinTriggerL = 0;
			this.9.ClassicControllerState.CalibrationInfo.MaxTriggerL = 31;
			this.9.ClassicControllerState.CalibrationInfo.MinTriggerR = 0;
			this.9.ClassicControllerState.CalibrationInfo.MaxTriggerR = 31;
			return;
		}
		if (extensionType != (951)((ulong)-1541405694))
		{
			return;
		}
		array = this.26(77856800, 32);
		this.9.BalanceBoardState.CalibrationInfo.Kg0.TopRight = (short)((int)array[4] << 8 | (int)array[5]);
		this.9.BalanceBoardState.CalibrationInfo.Kg0.BottomRight = (short)((int)array[6] << 8 | (int)array[7]);
		this.9.BalanceBoardState.CalibrationInfo.Kg0.TopLeft = (short)((int)array[8] << 8 | (int)array[9]);
		this.9.BalanceBoardState.CalibrationInfo.Kg0.BottomLeft = (short)((int)array[10] << 8 | (int)array[11]);
		this.9.BalanceBoardState.CalibrationInfo.Kg17.TopRight = (short)((int)array[12] << 8 | (int)array[13]);
		this.9.BalanceBoardState.CalibrationInfo.Kg17.BottomRight = (short)((int)array[14] << 8 | (int)array[15]);
		this.9.BalanceBoardState.CalibrationInfo.Kg17.TopLeft = (short)((int)array[16] << 8 | (int)array[17]);
		this.9.BalanceBoardState.CalibrationInfo.Kg17.BottomLeft = (short)((int)array[18] << 8 | (int)array[19]);
		this.9.BalanceBoardState.CalibrationInfo.Kg34.TopRight = (short)((int)array[20] << 8 | (int)array[21]);
		this.9.BalanceBoardState.CalibrationInfo.Kg34.BottomRight = (short)((int)array[22] << 8 | (int)array[23]);
		this.9.BalanceBoardState.CalibrationInfo.Kg34.TopLeft = (short)((int)array[24] << 8 | (int)array[25]);
		this.9.BalanceBoardState.CalibrationInfo.Kg34.BottomLeft = (short)((int)array[26] << 8 | (int)array[27]);
		return;
		IL_600:
		throw new 353("Unknown extension controller found: " + num.ToString("x"));
	}

	// Token: 0x06005495 RID: 21653 RVA: 0x0020D080 File Offset: 0x0020B280
	private void 9(byte[] 1)
	{
		this.9.ButtonState.A = ((1[2] & 8) > 0);
		this.9.ButtonState.B = ((1[2] & 4) > 0);
		this.9.ButtonState.Minus = ((1[2] & 16) > 0);
		this.9.ButtonState.Home = ((1[2] & 128) > 0);
		this.9.ButtonState.Plus = ((1[1] & 16) > 0);
		this.9.ButtonState.One = ((1[2] & 2) > 0);
		this.9.ButtonState.Two = ((1[2] & 1) > 0);
		this.9.ButtonState.Up = ((1[1] & 8) > 0);
		this.9.ButtonState.Down = ((1[1] & 4) > 0);
		this.9.ButtonState.Left = ((1[1] & 1) > 0);
		this.9.ButtonState.Right = ((1[1] & 2) > 0);
	}

	// Token: 0x06005496 RID: 21654 RVA: 0x0020D19C File Offset: 0x0020B39C
	private void 10(byte[] 1)
	{
		this.9.AccelState.RawValues.X = (int)1[3];
		this.9.AccelState.RawValues.Y = (int)1[4];
		this.9.AccelState.RawValues.Z = (int)1[5];
		this.9.AccelState.Values.X = ((float)this.9.AccelState.RawValues.X - (float)this.9.AccelCalibrationInfo.X0) / ((float)this.9.AccelCalibrationInfo.XG - (float)this.9.AccelCalibrationInfo.X0);
		this.9.AccelState.Values.Y = ((float)this.9.AccelState.RawValues.Y - (float)this.9.AccelCalibrationInfo.Y0) / ((float)this.9.AccelCalibrationInfo.YG - (float)this.9.AccelCalibrationInfo.Y0);
		this.9.AccelState.Values.Z = ((float)this.9.AccelState.RawValues.Z - (float)this.9.AccelCalibrationInfo.Z0) / ((float)this.9.AccelCalibrationInfo.ZG - (float)this.9.AccelCalibrationInfo.Z0);
	}

	// Token: 0x06005497 RID: 21655 RVA: 0x0020D314 File Offset: 0x0020B514
	private void 11(byte[] 1)
	{
		this.9.IRState.IRSensors[0].RawPosition.X = ((int)1[6] | (1[8] >> 4 & 3) << 8);
		this.9.IRState.IRSensors[0].RawPosition.Y = ((int)1[7] | (1[8] >> 6 & 3) << 8);
		956 mode = this.9.IRState.Mode;
		if (mode != 956.Basic)
		{
			if (mode == 956.Extended)
			{
				this.9.IRState.IRSensors[1].RawPosition.X = ((int)1[9] | (1[11] >> 4 & 3) << 8);
				this.9.IRState.IRSensors[1].RawPosition.Y = ((int)1[10] | (1[11] >> 6 & 3) << 8);
				this.9.IRState.IRSensors[2].RawPosition.X = ((int)1[12] | (1[14] >> 4 & 3) << 8);
				this.9.IRState.IRSensors[2].RawPosition.Y = ((int)1[13] | (1[14] >> 6 & 3) << 8);
				this.9.IRState.IRSensors[3].RawPosition.X = ((int)1[15] | (1[17] >> 4 & 3) << 8);
				this.9.IRState.IRSensors[3].RawPosition.Y = ((int)1[16] | (1[17] >> 6 & 3) << 8);
				this.9.IRState.IRSensors[0].Size = (int)(1[8] & 15);
				this.9.IRState.IRSensors[1].Size = (int)(1[11] & 15);
				this.9.IRState.IRSensors[2].Size = (int)(1[14] & 15);
				this.9.IRState.IRSensors[3].Size = (int)(1[17] & 15);
				this.9.IRState.IRSensors[0].Found = (1[6] != byte.MaxValue || 1[7] != byte.MaxValue || 1[8] != byte.MaxValue);
				this.9.IRState.IRSensors[1].Found = (1[9] != byte.MaxValue || 1[10] != byte.MaxValue || 1[11] != byte.MaxValue);
				this.9.IRState.IRSensors[2].Found = (1[12] != byte.MaxValue || 1[13] != byte.MaxValue || 1[14] != byte.MaxValue);
				this.9.IRState.IRSensors[3].Found = (1[15] != byte.MaxValue || 1[16] != byte.MaxValue || 1[17] != byte.MaxValue);
			}
		}
		else
		{
			this.9.IRState.IRSensors[1].RawPosition.X = ((int)1[9] | (int)(1[8] & 3) << 8);
			this.9.IRState.IRSensors[1].RawPosition.Y = ((int)1[10] | (1[8] >> 2 & 3) << 8);
			this.9.IRState.IRSensors[2].RawPosition.X = ((int)1[11] | (1[13] >> 4 & 3) << 8);
			this.9.IRState.IRSensors[2].RawPosition.Y = ((int)1[12] | (1[13] >> 6 & 3) << 8);
			this.9.IRState.IRSensors[3].RawPosition.X = ((int)1[14] | (int)(1[13] & 3) << 8);
			this.9.IRState.IRSensors[3].RawPosition.Y = ((int)1[15] | (1[13] >> 2 & 3) << 8);
			this.9.IRState.IRSensors[0].Size = 0;
			this.9.IRState.IRSensors[1].Size = 0;
			this.9.IRState.IRSensors[2].Size = 0;
			this.9.IRState.IRSensors[3].Size = 0;
			this.9.IRState.IRSensors[0].Found = (1[6] != byte.MaxValue || 1[7] != byte.MaxValue);
			this.9.IRState.IRSensors[1].Found = (1[9] != byte.MaxValue || 1[10] != byte.MaxValue);
			this.9.IRState.IRSensors[2].Found = (1[11] != byte.MaxValue || 1[12] != byte.MaxValue);
			this.9.IRState.IRSensors[3].Found = (1[14] != byte.MaxValue || 1[15] != byte.MaxValue);
		}
		this.9.IRState.IRSensors[0].Position.X = (float)this.9.IRState.IRSensors[0].RawPosition.X / 1023.5f;
		this.9.IRState.IRSensors[1].Position.X = (float)this.9.IRState.IRSensors[1].RawPosition.X / 1023.5f;
		this.9.IRState.IRSensors[2].Position.X = (float)this.9.IRState.IRSensors[2].RawPosition.X / 1023.5f;
		this.9.IRState.IRSensors[3].Position.X = (float)this.9.IRState.IRSensors[3].RawPosition.X / 1023.5f;
		this.9.IRState.IRSensors[0].Position.Y = (float)this.9.IRState.IRSensors[0].RawPosition.Y / 767.5f;
		this.9.IRState.IRSensors[1].Position.Y = (float)this.9.IRState.IRSensors[1].RawPosition.Y / 767.5f;
		this.9.IRState.IRSensors[2].Position.Y = (float)this.9.IRState.IRSensors[2].RawPosition.Y / 767.5f;
		this.9.IRState.IRSensors[3].Position.Y = (float)this.9.IRState.IRSensors[3].RawPosition.Y / 767.5f;
		if (this.9.IRState.IRSensors[0].Found && this.9.IRState.IRSensors[1].Found)
		{
			this.9.IRState.RawMidpoint.X = (this.9.IRState.IRSensors[1].RawPosition.X + this.9.IRState.IRSensors[0].RawPosition.X) / 2;
			this.9.IRState.RawMidpoint.Y = (this.9.IRState.IRSensors[1].RawPosition.Y + this.9.IRState.IRSensors[0].RawPosition.Y) / 2;
			this.9.IRState.Midpoint.X = (this.9.IRState.IRSensors[1].Position.X + this.9.IRState.IRSensors[0].Position.X) / 2f;
			this.9.IRState.Midpoint.Y = (this.9.IRState.IRSensors[1].Position.Y + this.9.IRState.IRSensors[0].Position.Y) / 2f;
			return;
		}
		this.9.IRState.Midpoint.X = (this.9.IRState.Midpoint.Y = 0f);
	}

	// Token: 0x06005498 RID: 21656 RVA: 0x0020DCB8 File Offset: 0x0020BEB8
	private void 12(byte[] 1, int 2)
	{
		951 extensionType = this.9.ExtensionType;
		if (extensionType <= (951)((ulong)-1541406461))
		{
			if (extensionType != (951)((ulong)-1541406720))
			{
				if (extensionType != (951)((ulong)-1541406463))
				{
					if (extensionType != (951)((ulong)-1541406461))
					{
						return;
					}
					this.9.GuitarState.GuitarType = (((1[2] & 128) == 0) ? 955.GuitarHeroWorldTour : 955.GuitarHero3);
					this.9.GuitarState.ButtonState.Plus = ((1[2 + 4] & 4) == 0);
					this.9.GuitarState.ButtonState.Minus = ((1[2 + 4] & 16) == 0);
					this.9.GuitarState.ButtonState.StrumDown = ((1[2 + 4] & 64) == 0);
					this.9.GuitarState.ButtonState.StrumUp = ((1[2 + 5] & 1) == 0);
					this.9.GuitarState.FretButtonState.Yellow = ((1[2 + 5] & 8) == 0);
					this.9.GuitarState.FretButtonState.Green = ((1[2 + 5] & 16) == 0);
					this.9.GuitarState.FretButtonState.Blue = ((1[2 + 5] & 32) == 0);
					this.9.GuitarState.FretButtonState.Red = ((1[2 + 5] & 64) == 0);
					this.9.GuitarState.FretButtonState.Orange = ((1[2 + 5] & 128) == 0);
					this.9.GuitarState.RawJoystick.X = (int)(1[2] & 63);
					this.9.GuitarState.RawJoystick.Y = (int)(1[2 + 1] & 63);
					this.9.GuitarState.RawWhammyBar = (1[2 + 3] & 31);
					this.9.GuitarState.Joystick.X = (float)(this.9.GuitarState.RawJoystick.X - 31) / 63f;
					this.9.GuitarState.Joystick.Y = (float)(this.9.GuitarState.RawJoystick.Y - 31) / 63f;
					this.9.GuitarState.WhammyBar = (float)this.9.GuitarState.RawWhammyBar / 10f;
					this.9.GuitarState.TouchbarState.Yellow = false;
					this.9.GuitarState.TouchbarState.Green = false;
					this.9.GuitarState.TouchbarState.Blue = false;
					this.9.GuitarState.TouchbarState.Red = false;
					this.9.GuitarState.TouchbarState.Orange = false;
					int num = (int)(1[2 + 2] & 31);
					switch (num)
					{
					case 4:
						this.9.GuitarState.TouchbarState.Green = true;
						return;
					case 5:
					case 6:
					case 8:
					case 9:
					case 11:
					case 14:
					case 15:
					case 16:
					case 17:
					case 22:
					case 25:
						break;
					case 7:
						this.9.GuitarState.TouchbarState.Green = true;
						this.9.GuitarState.TouchbarState.Red = true;
						return;
					case 10:
						this.9.GuitarState.TouchbarState.Red = true;
						return;
					case 12:
					case 13:
						this.9.GuitarState.TouchbarState.Red = true;
						this.9.GuitarState.TouchbarState.Yellow = true;
						return;
					case 18:
					case 19:
						this.9.GuitarState.TouchbarState.Yellow = true;
						return;
					case 20:
					case 21:
						this.9.GuitarState.TouchbarState.Yellow = true;
						this.9.GuitarState.TouchbarState.Blue = true;
						return;
					case 23:
					case 24:
						this.9.GuitarState.TouchbarState.Blue = true;
						return;
					case 26:
						this.9.GuitarState.TouchbarState.Blue = true;
						this.9.GuitarState.TouchbarState.Orange = true;
						return;
					default:
						if (num != 31)
						{
							return;
						}
						this.9.GuitarState.TouchbarState.Orange = true;
						return;
					}
				}
				else
				{
					this.9.ClassicControllerState.RawJoystickL.X = (int)(1[2] & 63);
					this.9.ClassicControllerState.RawJoystickL.Y = (int)(1[2 + 1] & 63);
					this.9.ClassicControllerState.RawJoystickR.X = (int)((byte)(1[2 + 2] >> 7 | (1[2 + 1] & 192) >> 5 | (1[2] & 192) >> 3));
					this.9.ClassicControllerState.RawJoystickR.Y = (int)(1[2 + 2] & 31);
					this.9.ClassicControllerState.RawTriggerL = (byte)((1[2 + 2] & 96) >> 2 | 1[2 + 3] >> 5);
					this.9.ClassicControllerState.RawTriggerR = (1[2 + 3] & 31);
					this.9.ClassicControllerState.ButtonState.TriggerR = ((1[2 + 4] & 2) == 0);
					this.9.ClassicControllerState.ButtonState.Plus = ((1[2 + 4] & 4) == 0);
					this.9.ClassicControllerState.ButtonState.Home = ((1[2 + 4] & 8) == 0);
					this.9.ClassicControllerState.ButtonState.Minus = ((1[2 + 4] & 16) == 0);
					this.9.ClassicControllerState.ButtonState.TriggerL = ((1[2 + 4] & 32) == 0);
					this.9.ClassicControllerState.ButtonState.Down = ((1[2 + 4] & 64) == 0);
					this.9.ClassicControllerState.ButtonState.Right = ((1[2 + 4] & 128) == 0);
					this.9.ClassicControllerState.ButtonState.Up = ((1[2 + 5] & 1) == 0);
					this.9.ClassicControllerState.ButtonState.Left = ((1[2 + 5] & 2) == 0);
					this.9.ClassicControllerState.ButtonState.ZR = ((1[2 + 5] & 4) == 0);
					this.9.ClassicControllerState.ButtonState.X = ((1[2 + 5] & 8) == 0);
					this.9.ClassicControllerState.ButtonState.A = ((1[2 + 5] & 16) == 0);
					this.9.ClassicControllerState.ButtonState.Y = ((1[2 + 5] & 32) == 0);
					this.9.ClassicControllerState.ButtonState.B = ((1[2 + 5] & 64) == 0);
					this.9.ClassicControllerState.ButtonState.ZL = ((1[2 + 5] & 128) == 0);
					if (this.9.ClassicControllerState.CalibrationInfo.MaxXL != 0)
					{
						this.9.ClassicControllerState.JoystickL.X = ((float)this.9.ClassicControllerState.RawJoystickL.X - (float)this.9.ClassicControllerState.CalibrationInfo.MidXL) / (float)(this.9.ClassicControllerState.CalibrationInfo.MaxXL - this.9.ClassicControllerState.CalibrationInfo.MinXL);
					}
					if (this.9.ClassicControllerState.CalibrationInfo.MaxYL != 0)
					{
						this.9.ClassicControllerState.JoystickL.Y = ((float)this.9.ClassicControllerState.RawJoystickL.Y - (float)this.9.ClassicControllerState.CalibrationInfo.MidYL) / (float)(this.9.ClassicControllerState.CalibrationInfo.MaxYL - this.9.ClassicControllerState.CalibrationInfo.MinYL);
					}
					if (this.9.ClassicControllerState.CalibrationInfo.MaxXR != 0)
					{
						this.9.ClassicControllerState.JoystickR.X = ((float)this.9.ClassicControllerState.RawJoystickR.X - (float)this.9.ClassicControllerState.CalibrationInfo.MidXR) / (float)(this.9.ClassicControllerState.CalibrationInfo.MaxXR - this.9.ClassicControllerState.CalibrationInfo.MinXR);
					}
					if (this.9.ClassicControllerState.CalibrationInfo.MaxYR != 0)
					{
						this.9.ClassicControllerState.JoystickR.Y = ((float)this.9.ClassicControllerState.RawJoystickR.Y - (float)this.9.ClassicControllerState.CalibrationInfo.MidYR) / (float)(this.9.ClassicControllerState.CalibrationInfo.MaxYR - this.9.ClassicControllerState.CalibrationInfo.MinYR);
					}
					if (this.9.ClassicControllerState.CalibrationInfo.MaxTriggerL != 0)
					{
						this.9.ClassicControllerState.TriggerL = (float)this.9.ClassicControllerState.RawTriggerL / (float)(this.9.ClassicControllerState.CalibrationInfo.MaxTriggerL - this.9.ClassicControllerState.CalibrationInfo.MinTriggerL);
					}
					if (this.9.ClassicControllerState.CalibrationInfo.MaxTriggerR != 0)
					{
						this.9.ClassicControllerState.TriggerR = (float)this.9.ClassicControllerState.RawTriggerR / (float)(this.9.ClassicControllerState.CalibrationInfo.MaxTriggerR - this.9.ClassicControllerState.CalibrationInfo.MinTriggerR);
						return;
					}
				}
			}
			else
			{
				this.9.NunchukState.RawJoystick.X = (int)1[2];
				this.9.NunchukState.RawJoystick.Y = (int)1[2 + 1];
				this.9.NunchukState.AccelState.RawValues.X = (int)1[2 + 2];
				this.9.NunchukState.AccelState.RawValues.Y = (int)1[2 + 3];
				this.9.NunchukState.AccelState.RawValues.Z = (int)1[2 + 4];
				this.9.NunchukState.C = ((1[2 + 5] & 2) == 0);
				this.9.NunchukState.Z = ((1[2 + 5] & 1) == 0);
				this.9.NunchukState.AccelState.Values.X = ((float)this.9.NunchukState.AccelState.RawValues.X - (float)this.9.NunchukState.CalibrationInfo.AccelCalibration.X0) / ((float)this.9.NunchukState.CalibrationInfo.AccelCalibration.XG - (float)this.9.NunchukState.CalibrationInfo.AccelCalibration.X0);
				this.9.NunchukState.AccelState.Values.Y = ((float)this.9.NunchukState.AccelState.RawValues.Y - (float)this.9.NunchukState.CalibrationInfo.AccelCalibration.Y0) / ((float)this.9.NunchukState.CalibrationInfo.AccelCalibration.YG - (float)this.9.NunchukState.CalibrationInfo.AccelCalibration.Y0);
				this.9.NunchukState.AccelState.Values.Z = ((float)this.9.NunchukState.AccelState.RawValues.Z - (float)this.9.NunchukState.CalibrationInfo.AccelCalibration.Z0) / ((float)this.9.NunchukState.CalibrationInfo.AccelCalibration.ZG - (float)this.9.NunchukState.CalibrationInfo.AccelCalibration.Z0);
				if (this.9.NunchukState.CalibrationInfo.MaxX != 0)
				{
					this.9.NunchukState.Joystick.X = ((float)this.9.NunchukState.RawJoystick.X - (float)this.9.NunchukState.CalibrationInfo.MidX) / ((float)this.9.NunchukState.CalibrationInfo.MaxX - (float)this.9.NunchukState.CalibrationInfo.MinX);
				}
				if (this.9.NunchukState.CalibrationInfo.MaxY != 0)
				{
					this.9.NunchukState.Joystick.Y = ((float)this.9.NunchukState.RawJoystick.Y - (float)this.9.NunchukState.CalibrationInfo.MidY) / ((float)this.9.NunchukState.CalibrationInfo.MaxY - (float)this.9.NunchukState.CalibrationInfo.MinY);
					return;
				}
			}
		}
		else
		{
			if (extensionType == (951)((ulong)-1541406447))
			{
				this.9.TaikoDrumState.OuterLeft = ((1[2 + 5] & 32) == 0);
				this.9.TaikoDrumState.InnerLeft = ((1[2 + 5] & 64) == 0);
				this.9.TaikoDrumState.InnerRight = ((1[2 + 5] & 16) == 0);
				this.9.TaikoDrumState.OuterRight = ((1[2 + 5] & 8) == 0);
				return;
			}
			if (extensionType != (951)((ulong)-1541405694))
			{
				if (extensionType != 951.Drums)
				{
					return;
				}
				this.9.DrumsState.RawJoystick.X = (int)(1[2] & 63);
				this.9.DrumsState.RawJoystick.Y = (int)(1[2 + 1] & 63);
				this.9.DrumsState.Plus = ((1[2 + 4] & 4) == 0);
				this.9.DrumsState.Minus = ((1[2 + 4] & 16) == 0);
				this.9.DrumsState.Pedal = ((1[2 + 5] & 4) == 0);
				this.9.DrumsState.Blue = ((1[2 + 5] & 8) == 0);
				this.9.DrumsState.Green = ((1[2 + 5] & 16) == 0);
				this.9.DrumsState.Yellow = ((1[2 + 5] & 32) == 0);
				this.9.DrumsState.Red = ((1[2 + 5] & 64) == 0);
				this.9.DrumsState.Orange = ((1[2 + 5] & 128) == 0);
				this.9.DrumsState.Joystick.X = (float)(this.9.DrumsState.RawJoystick.X - 31) / 63f;
				this.9.DrumsState.Joystick.Y = (float)(this.9.DrumsState.RawJoystick.Y - 31) / 63f;
				if ((1[2 + 2] & 64) == 0)
				{
					int num2 = 1[2 + 2] >> 1 & 31;
					int num3 = 1[2 + 3] >> 5;
					if (num3 != 7)
					{
						switch (num2)
						{
						case 14:
							this.9.DrumsState.OrangeVelocity = num3;
							return;
						case 15:
							this.9.DrumsState.BlueVelocity = num3;
							return;
						case 16:
							break;
						case 17:
							this.9.DrumsState.YellowVelocity = num3;
							return;
						case 18:
							this.9.DrumsState.GreenVelocity = num3;
							return;
						default:
							if (num2 == 25)
							{
								this.9.DrumsState.RedVelocity = num3;
								return;
							}
							if (num2 == 27)
							{
								this.9.DrumsState.PedalVelocity = num3;
								return;
							}
							break;
						}
					}
				}
			}
			else
			{
				this.9.BalanceBoardState.SensorValuesRaw.TopRight = (short)((int)1[2] << 8 | (int)1[2 + 1]);
				this.9.BalanceBoardState.SensorValuesRaw.BottomRight = (short)((int)1[2 + 2] << 8 | (int)1[2 + 3]);
				this.9.BalanceBoardState.SensorValuesRaw.TopLeft = (short)((int)1[2 + 4] << 8 | (int)1[2 + 5]);
				this.9.BalanceBoardState.SensorValuesRaw.BottomLeft = (short)((int)1[2 + 6] << 8 | (int)1[2 + 7]);
				this.9.BalanceBoardState.SensorValuesKg.TopLeft = this.13(this.9.BalanceBoardState.SensorValuesRaw.TopLeft, this.9.BalanceBoardState.CalibrationInfo.Kg0.TopLeft, this.9.BalanceBoardState.CalibrationInfo.Kg17.TopLeft, this.9.BalanceBoardState.CalibrationInfo.Kg34.TopLeft);
				this.9.BalanceBoardState.SensorValuesKg.TopRight = this.13(this.9.BalanceBoardState.SensorValuesRaw.TopRight, this.9.BalanceBoardState.CalibrationInfo.Kg0.TopRight, this.9.BalanceBoardState.CalibrationInfo.Kg17.TopRight, this.9.BalanceBoardState.CalibrationInfo.Kg34.TopRight);
				this.9.BalanceBoardState.SensorValuesKg.BottomLeft = this.13(this.9.BalanceBoardState.SensorValuesRaw.BottomLeft, this.9.BalanceBoardState.CalibrationInfo.Kg0.BottomLeft, this.9.BalanceBoardState.CalibrationInfo.Kg17.BottomLeft, this.9.BalanceBoardState.CalibrationInfo.Kg34.BottomLeft);
				this.9.BalanceBoardState.SensorValuesKg.BottomRight = this.13(this.9.BalanceBoardState.SensorValuesRaw.BottomRight, this.9.BalanceBoardState.CalibrationInfo.Kg0.BottomRight, this.9.BalanceBoardState.CalibrationInfo.Kg17.BottomRight, this.9.BalanceBoardState.CalibrationInfo.Kg34.BottomRight);
				this.9.BalanceBoardState.SensorValuesLb.TopLeft = this.9.BalanceBoardState.SensorValuesKg.TopLeft * 2.2046225f;
				this.9.BalanceBoardState.SensorValuesLb.TopRight = this.9.BalanceBoardState.SensorValuesKg.TopRight * 2.2046225f;
				this.9.BalanceBoardState.SensorValuesLb.BottomLeft = this.9.BalanceBoardState.SensorValuesKg.BottomLeft * 2.2046225f;
				this.9.BalanceBoardState.SensorValuesLb.BottomRight = this.9.BalanceBoardState.SensorValuesKg.BottomRight * 2.2046225f;
				this.9.BalanceBoardState.WeightKg = (this.9.BalanceBoardState.SensorValuesKg.TopLeft + this.9.BalanceBoardState.SensorValuesKg.TopRight + this.9.BalanceBoardState.SensorValuesKg.BottomLeft + this.9.BalanceBoardState.SensorValuesKg.BottomRight) / 4f;
				this.9.BalanceBoardState.WeightLb = (this.9.BalanceBoardState.SensorValuesLb.TopLeft + this.9.BalanceBoardState.SensorValuesLb.TopRight + this.9.BalanceBoardState.SensorValuesLb.BottomLeft + this.9.BalanceBoardState.SensorValuesLb.BottomRight) / 4f;
				float num4 = (this.9.BalanceBoardState.SensorValuesKg.TopLeft + this.9.BalanceBoardState.SensorValuesKg.BottomLeft) / (this.9.BalanceBoardState.SensorValuesKg.TopRight + this.9.BalanceBoardState.SensorValuesKg.BottomRight);
				float num5 = (this.9.BalanceBoardState.SensorValuesKg.TopLeft + this.9.BalanceBoardState.SensorValuesKg.TopRight) / (this.9.BalanceBoardState.SensorValuesKg.BottomLeft + this.9.BalanceBoardState.SensorValuesKg.BottomRight);
				this.9.BalanceBoardState.CenterOfGravity.X = (num4 - 1f) / (num4 + 1f) * -21f;
				this.9.BalanceBoardState.CenterOfGravity.Y = (num5 - 1f) / (num5 + 1f) * -12f;
			}
		}
	}

	// Token: 0x06005499 RID: 21657 RVA: 0x0020F215 File Offset: 0x0020D415
	private float 13(short 1, short 2, short 3, short 4)
	{
		if (4 == 3 || 3 == 2)
		{
			return 0f;
		}
		if (1 < 3)
		{
			return 68f * ((float)(1 - 2) / (float)(3 - 2));
		}
		return 68f * ((float)(1 - 3) / (float)(4 - 3)) + 68f;
	}

	// Token: 0x0600549A RID: 21658 RVA: 0x0020F250 File Offset: 0x0020D450
	private void 14(byte[] 1)
	{
		if ((1[3] & 8) != 0)
		{
			throw new 353("Error reading data from Wiimote: Bytes do not exist.");
		}
		if ((1[3] & 7) != 0)
		{
			throw new 353("Error reading data from Wiimote: Attempt to read from write-only registers.");
		}
		int num = (1[3] >> 4) + 1;
		int num2 = (int)1[4] << 8 | (int)1[5];
		Array.Copy(1, 6, this.6, num2 - this.7, num);
		if (this.7 + (int)this.8 == num2 + num)
		{
			this.10.Set();
		}
	}

	// Token: 0x0600549B RID: 21659 RVA: 0x0020F2C7 File Offset: 0x0020D4C7
	private byte 15()
	{
		return (this.9.Rumble > false) ? 1 : 0;
	}

	// Token: 0x0600549C RID: 21660 RVA: 0x0020F2D8 File Offset: 0x0020D4D8
	private void 16()
	{
		byte[] array = this.26(22, 7);
		this.9.AccelCalibrationInfo.X0 = array[0];
		this.9.AccelCalibrationInfo.Y0 = array[1];
		this.9.AccelCalibrationInfo.Z0 = array[2];
		this.9.AccelCalibrationInfo.XG = array[4];
		this.9.AccelCalibrationInfo.YG = array[5];
		this.9.AccelCalibrationInfo.ZG = array[6];
	}

	// Token: 0x0600549D RID: 21661 RVA: 0x0020F361 File Offset: 0x0020D561
	public void 17(426 1, bool 2)
	{
		this.18(1, (1080)5, 2);
	}

	// Token: 0x0600549E RID: 21662 RVA: 0x0020F36C File Offset: 0x0020D56C
	public void 18(426 1, 1080 2, bool 3)
	{
		if (this.9.ExtensionType == (951)((ulong)-1541405694))
		{
			1 = (426)52;
		}
		if (1 != (426)51)
		{
			if (1 != (426)55)
			{
				this.23();
			}
			else
			{
				this.22(956.Basic, 2);
			}
		}
		else
		{
			this.22(956.Extended, 2);
		}
		this.24();
		this.5[0] = 18;
		this.5[1] = ((3 ? 4 : 0) | ((this.9.Rumble > false) ? 1 : 0));
		this.5[2] = (byte)1;
		this.25();
	}

	// Token: 0x0600549F RID: 21663 RVA: 0x0020F3F8 File Offset: 0x0020D5F8
	public void 19(bool 1, bool 2, bool 3, bool 4)
	{
		this.9.LEDState.LED1 = 1;
		this.9.LEDState.LED2 = 2;
		this.9.LEDState.LED3 = 3;
		this.9.LEDState.LED4 = 4;
		this.24();
		this.5[0] = 17;
		this.5[1] = ((1 ? 16 : 0) | (2 ? 32 : 0) | (3 ? 64 : 0) | (4 ? 128 : 0) | this.15());
		this.25();
	}

	// Token: 0x060054A0 RID: 21664 RVA: 0x0020F498 File Offset: 0x0020D698
	public void 20(bool 1)
	{
		this.9.Rumble = 1;
		this.19(this.9.LEDState.LED1, this.9.LEDState.LED2, this.9.LEDState.LED3, this.9.LEDState.LED4);
	}

	// Token: 0x060054A1 RID: 21665 RVA: 0x0020F4F8 File Offset: 0x0020D6F8
	public void 21()
	{
		this.24();
		this.5[0] = 21;
		this.5[1] = this.15();
		this.25();
		if (!this.12.WaitOne(3000, false))
		{
			throw new 353("Timed out waiting for status report");
		}
	}

	// Token: 0x060054A2 RID: 21666 RVA: 0x0020F548 File Offset: 0x0020D748
	private void 22(956 1, 1080 2)
	{
		this.9.IRState.Mode = 1;
		this.24();
		this.5[0] = 19;
		this.5[1] = (4 | this.15());
		this.25();
		this.24();
		this.5[0] = 26;
		this.5[1] = (4 | this.15());
		this.25();
		this.27(78643248, 8);
		switch (2)
		{
		case (1080)0:
			this.28(78643200, 9, new byte[]
			{
				2,
				0,
				0,
				113,
				1,
				0,
				100,
				0,
				254
			});
			this.28(78643226, 2, new byte[]
			{
				253,
				5
			});
			break;
		case (1080)1:
			this.28(78643200, 9, new byte[]
			{
				2,
				0,
				0,
				113,
				1,
				0,
				150,
				0,
				180
			});
			this.28(78643226, 2, new byte[]
			{
				179,
				4
			});
			break;
		case (1080)2:
			this.28(78643200, 9, new byte[]
			{
				2,
				0,
				0,
				113,
				1,
				0,
				170,
				0,
				100
			});
			this.28(78643226, 2, new byte[]
			{
				99,
				3
			});
			break;
		case (1080)3:
			this.28(78643200, 9, new byte[]
			{
				2,
				0,
				0,
				113,
				1,
				0,
				200,
				0,
				54
			});
			this.28(78643226, 2, new byte[]
			{
				53,
				3
			});
			break;
		case (1080)4:
			this.28(78643200, 9, new byte[]
			{
				7,
				0,
				0,
				113,
				1,
				0,
				114,
				0,
				32
			});
			this.28(78643226, 2, new byte[]
			{
				1,
				3
			});
			break;
		case (1080)5:
		{
			this.28(78643200, 9, new byte[]
			{
				2,
				0,
				0,
				113,
				1,
				0,
				144,
				0,
				65
			});
			int num = 78643226;
			byte b = 2;
			byte[] array = new byte[2];
			array[0] = 64;
			this.28(num, b, array);
			break;
		}
		default:
			throw new ArgumentOutOfRangeException("irSensitivity");
		}
		this.27(78643251, (byte)1);
		this.27(78643248, 8);
	}

	// Token: 0x060054A3 RID: 21667 RVA: 0x0020F778 File Offset: 0x0020D978
	private void 23()
	{
		this.9.IRState.Mode = 956.Off;
		this.24();
		this.5[0] = 19;
		this.5[1] = this.15();
		this.25();
		this.24();
		this.5[0] = 26;
		this.5[1] = this.15();
		this.25();
	}

	// Token: 0x060054A4 RID: 21668 RVA: 0x0020F7DE File Offset: 0x0020D9DE
	private void 24()
	{
		Array.Clear(this.5, 0, 22);
	}

	// Token: 0x060054A5 RID: 21669 RVA: 0x0020F7F0 File Offset: 0x0020D9F0
	private void 25()
	{
		if (this.13)
		{
			1071.HidD_SetOutputReport(this.3.DangerousGetHandle(), this.5, (uint)this.5.Length);
		}
		else if (this.4 != null)
		{
			this.4.Write(this.5, 0, 22);
		}
		if (this.5[0] == 22)
		{
			this.11.WaitOne(1000, false);
		}
	}

	// Token: 0x060054A6 RID: 21670 RVA: 0x0020F860 File Offset: 0x0020DA60
	public byte[] 26(int 1, short 2)
	{
		this.24();
		this.6 = new byte[(int)2];
		this.7 = (1 & 65535);
		this.8 = 2;
		this.5[0] = 23;
		this.5[1] = (byte)(((long)1 & (long)((ulong)-16777216)) >> 24 | (long)((ulong)this.15()));
		this.5[2] = (byte)((1 & 16711680) >> 16);
		this.5[3] = (byte)((1 & 65280) >> 8);
		this.5[4] = (byte)1;
		this.5[5] = (byte)(((int)2 & 65280) >> 8);
		this.5[6] = (byte)2;
		this.25();
		if (!this.10.WaitOne(1000, false))
		{
			throw new 353("Error reading data from Wiimote...is it connected?");
		}
		return this.6;
	}

	// Token: 0x060054A7 RID: 21671 RVA: 0x0020F92F File Offset: 0x0020DB2F
	public void 27(int 1, byte 2)
	{
		this.28(1, 1, new byte[]
		{
			2
		});
	}

	// Token: 0x060054A8 RID: 21672 RVA: 0x0020F944 File Offset: 0x0020DB44
	public void 28(int 1, byte 2, byte[] 3)
	{
		this.24();
		this.5[0] = 22;
		this.5[1] = (byte)(((long)1 & (long)((ulong)-16777216)) >> 24 | (long)((ulong)this.15()));
		this.5[2] = (byte)((1 & 16711680) >> 16);
		this.5[3] = (byte)((1 & 65280) >> 8);
		this.5[4] = (byte)1;
		this.5[5] = 2;
		Array.Copy(3, 0, this.5, 6, (int)2);
		this.25();
	}

	// Token: 0x060054A9 RID: 21673 RVA: 0x0020F9CB File Offset: 0x0020DBCB
	public 967 29()
	{
		return this.9;
	}

	// Token: 0x060054AA RID: 21674 RVA: 0x0020F9D3 File Offset: 0x0020DBD3
	public void Dispose()
	{
		this.30(true);
		GC.SuppressFinalize(this);
	}

	// Token: 0x060054AB RID: 21675 RVA: 0x0020F9E2 File Offset: 0x0020DBE2
	protected void 30(bool 1)
	{
		if (1)
		{
			this.Disconnect();
		}
	}

	// Token: 0x040040FF RID: 16639
	private EventHandler<728> 1;

	// Token: 0x04004100 RID: 16640
	private EventHandler<813> 2;

	// Token: 0x04004101 RID: 16641
	private SafeFileHandle 3;

	// Token: 0x04004102 RID: 16642
	private FileStream 4;

	// Token: 0x04004103 RID: 16643
	private readonly byte[] 5 = new byte[22];

	// Token: 0x04004104 RID: 16644
	private byte[] 6;

	// Token: 0x04004105 RID: 16645
	private int 7;

	// Token: 0x04004106 RID: 16646
	private short 8;

	// Token: 0x04004107 RID: 16647
	private readonly 967 9 = new 967();

	// Token: 0x04004108 RID: 16648
	private readonly AutoResetEvent 10 = new AutoResetEvent(false);

	// Token: 0x04004109 RID: 16649
	private readonly AutoResetEvent 11 = new AutoResetEvent(false);

	// Token: 0x0400410A RID: 16650
	private readonly AutoResetEvent 12 = new AutoResetEvent(false);

	// Token: 0x0400410B RID: 16651
	private bool 13;

	// Token: 0x0400410C RID: 16652
	private string 14 = string.Empty;

	// Token: 0x0400410D RID: 16653
	private readonly Guid 15 = Guid.NewGuid();

	// Token: 0x02000C53 RID: 3155
	// (Invoke) Token: 0x060054AD RID: 21677
	public delegate bool 1111(string 1);
}
