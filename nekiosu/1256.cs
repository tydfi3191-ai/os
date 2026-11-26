using System;

// Token: 0x02000BBE RID: 3006
public sealed class 1256 : IDisposable
{
	// Token: 0x060052B4 RID: 21172 RVA: 0x00208AA0 File Offset: 0x00206CA0
	internal 1256(int 1)
	{
		this.10(1);
	}

	// Token: 0x060052B5 RID: 21173 RVA: 0x00208AC5 File Offset: 0x00206CC5
	public float 1()
	{
		return this.1;
	}

	// Token: 0x060052B6 RID: 21174 RVA: 0x00208ACD File Offset: 0x00206CCD
	public void 2(float 1)
	{
		if (1 != this.1)
		{
			this.1 = 1;
			this.6();
		}
	}

	// Token: 0x060052B7 RID: 21175 RVA: 0x00208AE5 File Offset: 0x00206CE5
	public void 3(float 1)
	{
		if (1 != this.2)
		{
			this.2 = 1052.19(1, -1f, 1f);
			this.6();
		}
	}

	// Token: 0x060052B8 RID: 21176 RVA: 0x00208B0C File Offset: 0x00206D0C
	public void 4(float 1)
	{
		if (1 != this.3)
		{
			this.3 = 1;
			this.6();
		}
	}

	// Token: 0x060052B9 RID: 21177 RVA: 0x00208B24 File Offset: 0x00206D24
	public void 5(float 1)
	{
		if (1 != this.4)
		{
			this.4 = 1;
			this.6();
		}
	}

	// Token: 0x060052BA RID: 21178 RVA: 0x00208B3C File Offset: 0x00206D3C
	internal void 6()
	{
		if (!this.7())
		{
			return;
		}
		if (this.3 > 0f)
		{
			if (2504.28 != null)
			{
				this.2 = 2504.28.GetReplayCursorPosition().X / 512f - 0.5f;
			}
			else
			{
				this.2 = 1535.6.X / 1662.70.3() / (float)1662.70.1() - 0.5f;
			}
			this.2 *= this.3;
		}
		1025.BASS_ChannelSetAttribute(this.5, (994)2, Math.Min(1f, this.1 * (this.10 ? 1226.42() : 1226.41()) / 100f));
		1025.BASS_ChannelSetAttribute(this.5, (994)3, this.2);
		1025.BASS_ChannelSetAttribute(this.5, (994)1, this.7 * this.4);
	}

	// Token: 0x060052BB RID: 21179 RVA: 0x00208C2E File Offset: 0x00206E2E
	private bool 7()
	{
		return this.5 != 0;
	}

	// Token: 0x060052BC RID: 21180 RVA: 0x00208C3C File Offset: 0x00206E3C
	public int 8()
	{
		if (!this.7())
		{
			this.5 = 1219.4(this.6, false);
			1025.BASS_ChannelSetAttribute(this.5, (994)11, 1f);
			1025.BASS_ChannelGetAttribute(this.5, (994)1, ref this.7);
			this.6();
		}
		return this.5;
	}

	// Token: 0x060052BD RID: 21181 RVA: 0x00208C95 File Offset: 0x00206E95
	private bool 9()
	{
		return this.6 != 0 && this.6 != -1;
	}

	// Token: 0x060052BE RID: 21182 RVA: 0x00208CAD File Offset: 0x00206EAD
	public void 10(int 1)
	{
		if (1 != this.6)
		{
			this.6 = 1;
			this.11();
		}
	}

	// Token: 0x060052BF RID: 21183 RVA: 0x00208CC5 File Offset: 0x00206EC5
	private void 11()
	{
		this.5 = 0;
	}

	// Token: 0x060052C0 RID: 21184 RVA: 0x00208CCE File Offset: 0x00206ECE
	internal void Play(bool 1, bool 2)
	{
		if (this.9)
		{
			return;
		}
		if (!this.9())
		{
			this.8 = true;
			return;
		}
		if (2)
		{
			this.11();
		}
		int num = this.8();
		this.6();
		1219.Play(num, 1);
		this.8 = true;
	}

	// Token: 0x060052C1 RID: 21185 RVA: 0x00208D0C File Offset: 0x00206F0C
	internal void 12(bool 1)
	{
		if (this.7())
		{
			1219.6(this.5);
		}
	}

	// Token: 0x060052C2 RID: 21186 RVA: 0x00208D24 File Offset: 0x00206F24
	~1256()
	{
		this.13(false);
	}

	// Token: 0x060052C3 RID: 21187 RVA: 0x00208D54 File Offset: 0x00206F54
	public void Dispose()
	{
		if (!this.9)
		{
			this.9 = true;
			this.13(true);
			GC.SuppressFinalize(this);
		}
	}

	// Token: 0x060052C4 RID: 21188 RVA: 0x00208D72 File Offset: 0x00206F72
	protected void 13(bool 1)
	{
		this.12(true);
	}

	// Token: 0x060052C5 RID: 21189 RVA: 0x00208D7B File Offset: 0x00206F7B
	public bool 14()
	{
		return this.7() && 1219.7(this.5) != 0;
	}

	// Token: 0x060052C6 RID: 21190 RVA: 0x00208D95 File Offset: 0x00206F95
	internal bool 15()
	{
		return (!this.9() || 1219.7(this.5) == 0) && this.8;
	}

	// Token: 0x060052C7 RID: 21191 RVA: 0x00208DB4 File Offset: 0x00206FB4
	internal void Pause()
	{
		if (this.14() && this.7())
		{
			1219.Pause(this.5);
		}
	}

	// Token: 0x04003EFF RID: 16127
	private float 1 = 1f;

	// Token: 0x04003F00 RID: 16128
	private float 2;

	// Token: 0x04003F01 RID: 16129
	private float 3;

	// Token: 0x04003F02 RID: 16130
	private float 4 = 1f;

	// Token: 0x04003F03 RID: 16131
	private int 5;

	// Token: 0x04003F04 RID: 16132
	private int 6;

	// Token: 0x04003F05 RID: 16133
	private float 7;

	// Token: 0x04003F06 RID: 16134
	private bool 8;

	// Token: 0x04003F07 RID: 16135
	internal bool 9;

	// Token: 0x04003F08 RID: 16136
	internal bool 10;
}
