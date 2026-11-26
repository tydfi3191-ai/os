using System;
using System.Collections.Generic;
using System.Threading;
using OpenTK.Input;

// Token: 0x02000A58 RID: 2648
public sealed class 1546 : 1083
{
	// Token: 0x0600491D RID: 18717 RVA: 0x001D0FA4 File Offset: 0x001CF1A4
	internal static void 1(1546.1547 1)
	{
		1546.1547 2 = 1546.1;
		1546.1547 3;
		do
		{
			3 = 2;
			1546.1547 value = (1546.1547)Delegate.Combine(3, 1);
			2 = Interlocked.CompareExchange<1546.1547>(ref 1546.1, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x0600491E RID: 18718 RVA: 0x001D0FD8 File Offset: 0x001CF1D8
	internal static void 2(1546.1547 1)
	{
		1546.1547 2 = 1546.1;
		1546.1547 3;
		do
		{
			3 = 2;
			1546.1547 value = (1546.1547)Delegate.Remove(3, 1);
			2 = Interlocked.CompareExchange<1546.1547>(ref 1546.1, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x0600491F RID: 18719 RVA: 0x001D100B File Offset: 0x001CF20B
	internal static bool 3(200 1)
	{
		return 1 != 200.None && 1546.3.Contains(1);
	}

	// Token: 0x06004920 RID: 18720 RVA: 0x001D101D File Offset: 0x001CF21D
	internal static bool 4(200 1)
	{
		return 1546.4.Contains(1);
	}

	// Token: 0x06004921 RID: 18721 RVA: 0x001D102A File Offset: 0x001CF22A
	internal override bool Initialize()
	{
		this.5();
		1662.89.2(new 1189(this.5), 1000, true);
		return true;
	}

	// Token: 0x06004922 RID: 18722 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal override void Dispose()
	{
	}

	// Token: 0x06004923 RID: 18723 RVA: 0x001D1050 File Offset: 0x001CF250
	private void 5()
	{
		for (int i = 0; i < 16; i++)
		{
			JoystickCapabilities capabilities = Joystick.GetCapabilities(i);
			if (capabilities.IsConnected && capabilities.ButtonCount + capabilities.AxisCount + capabilities.HatCount > 0)
			{
				if (!this.7[i] || !capabilities.Equals(this.8[i]))
				{
					this.9[i] = Joystick.GetState(i);
					this.8[i] = capabilities;
				}
				this.7[i] = true;
			}
			else
			{
				this.7[i] = false;
			}
		}
	}

	// Token: 0x06004924 RID: 18724 RVA: 0x001D10EC File Offset: 0x001CF2EC
	internal override void Update(bool 1)
	{
		if (!1662.11.2())
		{
			return;
		}
		int num = -1;
		int num2 = -1;
		for (int i = 0; i < 16; i++)
		{
			if (this.7[i])
			{
				JoystickState state = Joystick.GetState(i);
				if (state.IsConnected)
				{
					if (num2 == -1 && !state.Equals(this.10[i]))
					{
						num2 = i;
					}
					if (i == this.11 || num == -1)
					{
						num = i;
					}
				}
				this.10[i] = state;
			}
		}
		this.11 = ((num2 != -1) ? num2 : num);
		if (this.11 != -1)
		{
			this.6(ref this.8[this.11], ref this.10[this.11], ref this.9[this.11]);
		}
	}

	// Token: 0x06004925 RID: 18725 RVA: 0x001D11B8 File Offset: 0x001CF3B8
	private void 6(ref JoystickCapabilities 1, ref JoystickState 2, ref JoystickState 3)
	{
		for (int i = 0; i < 78; i++)
		{
			this.5[i] = false;
		}
		List<200> list = new List<200>(78);
		for (int j = 0; j < 1.ButtonCount; j++)
		{
			if (2.IsButtonDown(j))
			{
				this.5[j] = true;
				list.Add((200)300 + j);
			}
		}
		for (int k = 0; k < 1.AxisCount; k++)
		{
			JoystickAxis joystickAxis = k;
			float axis = 2.GetAxis(joystickAxis);
			float num = (float)Math.Round((double)(3.GetAxis(joystickAxis) / this.12)) * this.12;
			float num2 = num + (-1f - num) * this.14;
			float num3 = num + (1f - num) * this.14;
			if (Math.Abs(axis - num) >= this.13)
			{
				if (axis < num2)
				{
					int num4 = 340 + k * 2;
					this.5[num4 - 300] = true;
					list.Add((200)num4);
				}
				else if (axis > num3)
				{
					int num5 = 340 + k * 2 + 1;
					this.5[num5 - 300] = true;
					list.Add((200)num5);
				}
			}
		}
		for (int l = 0; l < Math.Max(1, 1.HatCount); l++)
		{
			JoystickHatState hat = 2.GetHat(l);
			if (hat.IsUp)
			{
				int num6 = 362 + l * 4;
				this.5[num6 - 300] = true;
				list.Add((200)num6);
			}
			if (hat.IsRight)
			{
				int num7 = 362 + l * 4 + 1;
				this.5[num7 - 300] = true;
				list.Add((200)num7);
			}
			if (hat.IsDown)
			{
				int num8 = 362 + l * 4 + 2;
				this.5[num8 - 300] = true;
				list.Add((200)num8);
			}
			if (hat.IsLeft)
			{
				int num9 = 362 + l * 4 + 3;
				this.5[num9 - 300] = true;
				list.Add((200)num9);
			}
		}
		if (1546.2 != null && list.Count > 0)
		{
			1546.2(null, list);
		}
		if (1546.1 != null)
		{
			List<200> list2 = new List<200>(78);
			for (int m = 0; m < 78; m++)
			{
				if (this.6[m] && !this.5[m])
				{
					list2.Add((200)300 + m);
				}
			}
			if (list2.Count > 0)
			{
				1546.1(null, list2);
			}
		}
		1546.4.Clear();
		1546.4.AddRange(1546.3);
		1546.3.Clear();
		1546.3.AddRange(list);
		this.5.CopyTo(this.6, 0);
	}

	// Token: 0x06004926 RID: 18726 RVA: 0x0000FF75 File Offset: 0x0000E175
	internal override bool IsActive()
	{
		return false;
	}

	// Token: 0x06004927 RID: 18727 RVA: 0x0001905A File Offset: 0x0001725A
	internal override int GetPriority()
	{
		return 2;
	}

	// Token: 0x04003697 RID: 13975
	private static 1546.1547 1;

	// Token: 0x04003698 RID: 13976
	private static 1546.1547 2;

	// Token: 0x04003699 RID: 13977
	internal static List<200> 3 = new List<200>(78);

	// Token: 0x0400369A RID: 13978
	internal static List<200> 4 = new List<200>(78);

	// Token: 0x0400369B RID: 13979
	private bool[] 5 = new bool[78];

	// Token: 0x0400369C RID: 13980
	private bool[] 6 = new bool[78];

	// Token: 0x0400369D RID: 13981
	private bool[] 7 = new bool[16];

	// Token: 0x0400369E RID: 13982
	private JoystickCapabilities[] 8 = new JoystickCapabilities[16];

	// Token: 0x0400369F RID: 13983
	private JoystickState[] 9 = new JoystickState[16];

	// Token: 0x040036A0 RID: 13984
	private JoystickState[] 10 = new JoystickState[16];

	// Token: 0x040036A1 RID: 13985
	private int 11 = -1;

	// Token: 0x040036A2 RID: 13986
	private float 12 = 1f;

	// Token: 0x040036A3 RID: 13987
	private float 13 = 0.25f;

	// Token: 0x040036A4 RID: 13988
	private float 14 = 0.5f;

	// Token: 0x02000A59 RID: 2649
	// (Invoke) Token: 0x0600492B RID: 18731
	public delegate void 1547(object 1, List<200> 2);
}
