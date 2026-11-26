using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Threading;

// Token: 0x02000B11 RID: 2833
public sealed class 1505 : 1413
{
	// Token: 0x06004EB2 RID: 20146 RVA: 0x001F1A94 File Offset: 0x001EFC94
	internal 1505(string 1, string 2, int 3, 208 4, float 5) : base(null, 4, 5, true, 198.White)
	{
		if (string.IsNullOrEmpty(2) && !string.IsNullOrEmpty(1))
		{
			string text = 1654.1();
			string text2 = "dynamic_sprite_";
			byte[] array = 1209.2.GetBytes(1);
			string str = text2;
			string path = text;
			MD5 6 = 1209.1;
			string text3;
			lock (6)
			{
				try
				{
					array = 1209.1.ComputeHash(array);
				}
				catch (Exception)
				{
					text3 = "fail";
					goto IL_C7;
				}
			}
			char[] array2 = new char[array.Length * 2];
			for (int i = 0; i < array.Length; i++)
			{
				array[i].ToString("x2", 1209.3).CopyTo(0, array2, i * 2, 2);
			}
			string text4 = new string(array2);
			goto IL_F2;
			IL_C7:
			text4 = text3;
			IL_F2:
			string str2 = text4;
			2 = Path.Combine(path, str + str2);
		}
		this.74 = 2;
		this.73 = 1;
		this.72 = 3;
		this.27 = true;
		if (1 == null)
		{
			this.71 = (1484)4;
		}
	}

	// Token: 0x06004EB3 RID: 20147 RVA: 0x001F1BC4 File Offset: 0x001EFDC4
	internal new string 52()
	{
		return this.73;
	}

	// Token: 0x06004EB4 RID: 20148 RVA: 0x001F1BCC File Offset: 0x001EFDCC
	internal new void 53(string 1)
	{
		if (this.73 != 1)
		{
			if (this.47 != null)
			{
				this.47.Dispose();
				this.47 = null;
			}
			this.73 = 1;
			this.71 = (1484)0;
		}
		if (string.IsNullOrEmpty(this.73))
		{
			this.71 = (1484)4;
		}
	}

	// Token: 0x06004EB5 RID: 20149 RVA: 0x001F1C23 File Offset: 0x001EFE23
	internal new string 54()
	{
		return this.74;
	}

	// Token: 0x06004EB6 RID: 20150 RVA: 0x001F1C2B File Offset: 0x001EFE2B
	internal new void 55(string 1)
	{
		if (this.74 != 1)
		{
			this.74 = 1;
			this.71 = (1484)0;
		}
	}

	// Token: 0x06004EB7 RID: 20151 RVA: 0x001F1C49 File Offset: 0x001EFE49
	internal override void ReleaseResources(bool 1)
	{
		1414.1(this);
		base.ReleaseResources(1);
	}

	// Token: 0x06004EB8 RID: 20152 RVA: 0x001F1C5C File Offset: 0x001EFE5C
	internal override 1381 GetTexture()
	{
		if (this.71 == (1484)0)
		{
			if (string.IsNullOrEmpty(this.73))
			{
				return null;
			}
			if (this.75 > 0 && 1662.33 - this.75 < 200)
			{
				this.76 += 1662.33 - this.75;
			}
			else
			{
				this.76 = 0;
			}
			this.75 = 1662.33;
			if (this.76 < this.72)
			{
				return null;
			}
			if (this.47 != null)
			{
				this.47.Dispose();
			}
			this.81 = 1505.82.Find(new Predicate<1620>(this.58));
			if (this.81 != null)
			{
				return null;
			}
			if (!File.Exists(this.54()))
			{
				this.71 = (1484)1;
				this.81 = new 1620(this.54(), this.52());
				this.81.9(new 1621.1622(this.59));
				this.81.Start();
				List<1620> obj = 1505.82;
				lock (obj)
				{
					1505.82.Add(this.81);
					goto IL_12C;
				}
			}
			this.71 = (1484)3;
		}
		IL_12C:
		if (this.71 == (1484)3)
		{
			this.71 = (1484)2;
			try
			{
				if (this.78 > 0 && this.79 > 0)
				{
					1639.2(this.54(), this.78, this.79);
				}
				this.SetTexture(1381.13(this.54(), null));
				if (this.GetTexture() == null)
				{
					try
					{
						File.Delete(this.54());
					}
					catch
					{
					}
					this.71 = (1484)4;
					return null;
				}
				if (!this.80)
				{
					base.GetTexture().10 = true;
				}
				1414.2(this, !this.80);
				if (this.77 != 0f)
				{
					this.15 = this.77 / (float)Math.Max(this.39, this.38);
				}
				if (this.16 == 1f && this.3.Count == 0)
				{
					this.30 = new 198(this.30.R, this.30.G, this.30.B, 0);
					base.15(200);
				}
				this.57();
			}
			catch
			{
				try
				{
					File.Delete(this.54());
				}
				catch
				{
				}
				this.71 = (1484)4;
			}
		}
		return base.GetTexture();
	}

	// Token: 0x06004EB9 RID: 20153 RVA: 0x001F1F3C File Offset: 0x001F013C
	internal override void SetTexture(1381 1)
	{
		base.SetTexture(1);
	}

	// Token: 0x06004EBA RID: 20154 RVA: 0x001F1F48 File Offset: 0x001F0148
	internal void 56(1189 1)
	{
		1189 2 = this.83;
		1189 3;
		do
		{
			3 = 2;
			1189 value = (1189)Delegate.Combine(3, 1);
			2 = Interlocked.CompareExchange<1189>(ref this.83, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x06004EBB RID: 20155 RVA: 0x001F1F7D File Offset: 0x001F017D
	private void 57()
	{
		1189 <<EMPTY_NAME>> = this.83;
		if (<<EMPTY_NAME>> != null)
		{
			<<EMPTY_NAME>>();
		}
		this.83 = null;
	}

	// Token: 0x06004EBC RID: 20156 RVA: 0x001F1F98 File Offset: 0x001F0198
	public override void Dispose()
	{
		if (this.81 != null)
		{
			this.81.18();
			List<1620> obj = 1505.82;
			lock (obj)
			{
				1505.82.Remove(this.81);
			}
			this.71 = (1484)0;
		}
	}

	// Token: 0x06004EBD RID: 20157 RVA: 0x001F1FFC File Offset: 0x001F01FC
	private bool 58(1620 1)
	{
		return 1 != null && 1.filePath == this.74 && 1.1() == this.73;
	}

	// Token: 0x06004EBE RID: 20158 RVA: 0x001F2028 File Offset: 0x001F0228
	private new void 59(1621 1, Exception 2)
	{
		this.71 = (1484)3;
		List<1620> obj = 1505.82;
		lock (obj)
		{
			1505.82.Remove(this.81);
		}
		this.81 = null;
	}

	// Token: 0x04003AAD RID: 15021
	internal int 72;

	// Token: 0x04003AAE RID: 15022
	private string 73;

	// Token: 0x04003AAF RID: 15023
	private string 74;

	// Token: 0x04003AB0 RID: 15024
	private int 75;

	// Token: 0x04003AB1 RID: 15025
	private int 76;

	// Token: 0x04003AB2 RID: 15026
	internal float 77;

	// Token: 0x04003AB3 RID: 15027
	internal int 78;

	// Token: 0x04003AB4 RID: 15028
	internal int 79;

	// Token: 0x04003AB5 RID: 15029
	public bool 80;

	// Token: 0x04003AB6 RID: 15030
	private 1620 81;

	// Token: 0x04003AB7 RID: 15031
	private static List<1620> 82 = new List<1620>();

	// Token: 0x04003AB8 RID: 15032
	private 1189 83;
}
