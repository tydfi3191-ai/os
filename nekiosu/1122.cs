using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

// Token: 0x02000BEC RID: 3052
public sealed class 1122 : 282, IDisposable
{
	// Token: 0x0600535E RID: 21342 RVA: 0x0020AC88 File Offset: 0x00208E88
	public 1122(bool 1, 289 2, bool 3 = false)
	{
		this.2 = 1;
		this.1 = 2;
		this.3 = 3;
		this.3 = true;
		int num = 2.GetRecoveredType01460030_115().Method0812();
		this.4 = 1122.2(num, 1);
		this.5 = 1122.3(num, 1);
	}

	// Token: 0x0600535F RID: 21343 RVA: 0x0020ACE8 File Offset: 0x00208EE8
	public bool 1()
	{
		return this.2;
	}

	// Token: 0x06005360 RID: 21344 RVA: 0x00006208 File Offset: 0x00004408
	private static int 2(int 1, bool 2)
	{
		if (!2)
		{
			return (1 + 7) / 8;
		}
		return (1 - 1) / 8;
	}

	// Token: 0x06005361 RID: 21345 RVA: 0x00006218 File Offset: 0x00004418
	private static int 3(int 1, bool 2)
	{
		if (!2)
		{
			return (1 - 1) / 8;
		}
		return (1 + 7) / 8;
	}

	// Token: 0x06005362 RID: 21346 RVA: 0x0020ACF0 File Offset: 0x00208EF0
	public int TransformBlock(byte[] 1, int 2, int 3, byte[] 4, int 5, RandomNumberGenerator 6)
	{
		this.5();
		1122.1123 7 = this.6;
		int result;
		try
		{
			result = 7.2.TransformBlock(1, 2, 3, 4, 5, 6);
		}
		catch when (endfilter(7.1 > false))
		{
			this.4();
			7 = this.6;
			result = 7.2.TransformBlock(1, 2, 3, 4, 5, 6);
		}
		return result;
	}

	// Token: 0x06005363 RID: 21347 RVA: 0x0020AD64 File Offset: 0x00208F64
	private void 4()
	{
		object obj = this.8;
		lock (obj)
		{
			1122.1123 <<EMPTY_NAME>> = this.6;
			if (<<EMPTY_NAME>>.1)
			{
				try
				{
					IDisposable disposable = <<EMPTY_NAME>>.2 as IDisposable;
					if (disposable != null)
					{
						disposable.Dispose();
					}
				}
				catch
				{
				}
				282 2 = this.6(this.2, this.1);
				if (2 == null)
				{
					throw new InvalidOperationException();
				}
				this.6 = new 1122.1123
				{
					1 = false,
					2 = 2
				};
			}
		}
	}

	// Token: 0x06005364 RID: 21348 RVA: 0x0020AE10 File Offset: 0x00209010
	private void 5()
	{
		if (this.7)
		{
			return;
		}
		object obj = this.8;
		lock (obj)
		{
			if (!this.7)
			{
				282 <<EMPTY_NAME>>;
				if (!this.3 && (<<EMPTY_NAME>> = this.7(this.2, this.1)) != null)
				{
					this.6 = new 1122.1123
					{
						1 = true,
						2 = <<EMPTY_NAME>>
					};
				}
				else
				{
					<<EMPTY_NAME>> = this.6(this.2, this.1);
					if (<<EMPTY_NAME>> == null)
					{
						throw new InvalidOperationException();
					}
					this.6 = new 1122.1123
					{
						1 = false,
						2 = <<EMPTY_NAME>>
					};
				}
				this.7 = true;
			}
		}
	}

	// Token: 0x06005365 RID: 21349 RVA: 0x0020AED8 File Offset: 0x002090D8
	protected 282 6(bool 1, 289 2)
	{
		return new 342(1, 2);
	}

	// Token: 0x06005366 RID: 21350 RVA: 0x0020AEE1 File Offset: 0x002090E1
	protected 282 7(bool 1, 289 2)
	{
		return 1119.1(1, 2);
	}

	// Token: 0x06005367 RID: 21351 RVA: 0x0020AEEC File Offset: 0x002090EC
	public void Dispose()
	{
		1122.1123 <<EMPTY_NAME>> = this.6;
		IDisposable disposable = ((<<EMPTY_NAME>> != null) ? <<EMPTY_NAME>>.2 : null) as IDisposable;
		if (disposable != null)
		{
			disposable.Dispose();
			this.6 = null;
		}
	}

	// Token: 0x06005368 RID: 21352 RVA: 0x0020AF21 File Offset: 0x00209121
	[CompilerGenerated]
	public int GetInputBlockSize()
	{
		return this.4;
	}

	// Token: 0x06005369 RID: 21353 RVA: 0x0020AF29 File Offset: 0x00209129
	[CompilerGenerated]
	public int GetOutputBlockSize()
	{
		return this.5;
	}

	// Token: 0x04003F5C RID: 16220
	private readonly 289 1;

	// Token: 0x04003F5D RID: 16221
	private readonly bool 2;

	// Token: 0x04003F5E RID: 16222
	private readonly bool 3;

	// Token: 0x04003F5F RID: 16223
	private readonly int 4;

	// Token: 0x04003F60 RID: 16224
	private readonly int 5;

	// Token: 0x04003F61 RID: 16225
	private 1122.1123 6;

	// Token: 0x04003F62 RID: 16226
	private bool 7;

	// Token: 0x04003F63 RID: 16227
	private readonly object 8 = new object();

	// Token: 0x02000BED RID: 3053
	public sealed class 1123
	{
		// Token: 0x04003F64 RID: 16228
		public bool 1;

		// Token: 0x04003F65 RID: 16229
		public 282 2;
	}
}
