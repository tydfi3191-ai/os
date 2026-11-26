using System;

// Token: 0x02000810 RID: 2064
[276]
public sealed class 2048 : 2033
{
	// Token: 0x06003C13 RID: 15379 RVA: 0x0017DBC0 File Offset: 0x0017BDC0
	internal 2048(2039 1, 208 2, int 3, bool 4, 1245 5, int 6 = 0) : this(1, 2, 3, 4, 5.2(1245.Whistle), 5.2(1245.Finish), 5.2(1245.Clap), 6)
	{
	}

	// Token: 0x06003C14 RID: 15380 RVA: 0x0017DBF4 File Offset: 0x0017BDF4
	internal 2048(2039 1, 208 2, int 3, bool 4 = false, bool 5 = false, bool 6 = false, bool 7 = false, int 8 = 0) : base(1, 2, 3, 4, 5, 6, 7, 8)
	{
		this.3 = 2047.Hold;
		this.51 = false;
	}

	// Token: 0x06003C15 RID: 15381 RVA: 0x0017DC28 File Offset: 0x0017BE28
	internal override void SetStartTime(int 1)
	{
		int num = 1 - this.1;
		this.1 = 1;
		this.2 += num;
	}

	// Token: 0x06003C16 RID: 15382 RVA: 0x0014A8A1 File Offset: 0x00148AA1
	internal override void SetEndTime(int 1)
	{
		this.2 = 1;
	}

	// Token: 0x06003C17 RID: 15383 RVA: 0x0017DC54 File Offset: 0x0017BE54
	internal override 2034 Clone()
	{
		2048 <<EMPTY_NAME>> = new 2048(this.28, this.8, this.1, false, this.4, this.16);
		<<EMPTY_NAME>>.18 = this.18;
		<<EMPTY_NAME>>.2 = this.2;
		<<EMPTY_NAME>>.SetComboNumber(this.GetComboNumber());
		<<EMPTY_NAME>>.4(base.3());
		<<EMPTY_NAME>>.35 = this.35;
		<<EMPTY_NAME>>.36 = this.36;
		<<EMPTY_NAME>>.37 = this.37;
		<<EMPTY_NAME>>.34 = this.34;
		<<EMPTY_NAME>>.32 = this.32;
		<<EMPTY_NAME>>.33 = this.33;
		<<EMPTY_NAME>>.SetComboColour(this.7);
		return <<EMPTY_NAME>>;
	}

	// Token: 0x06003C18 RID: 15384 RVA: 0x0017DD0C File Offset: 0x0017BF0C
	internal new 2034 9()
	{
		2033 <<EMPTY_NAME>> = new 2033(this.28, this.8, this.1, false, this.4, this.16);
		<<EMPTY_NAME>>.SetComboNumber(this.GetComboNumber());
		<<EMPTY_NAME>>.4(base.3());
		<<EMPTY_NAME>>.35 = this.35;
		<<EMPTY_NAME>>.36 = this.36;
		<<EMPTY_NAME>>.37 = this.37;
		<<EMPTY_NAME>>.34 = this.34;
		<<EMPTY_NAME>>.32 = this.32;
		<<EMPTY_NAME>>.33 = this.33;
		<<EMPTY_NAME>>.SetComboColour(this.7);
		return <<EMPTY_NAME>>;
	}

	// Token: 0x06003C19 RID: 15385 RVA: 0x0017DDA9 File Offset: 0x0017BFA9
	internal override void PlayHitSound()
	{
		if (Math.Abs(1226.16 - this.2) >= Math.Abs(1226.16 - this.1))
		{
			base.PlayHitSound();
		}
	}

	// Token: 0x04002C54 RID: 11348
	internal bool 51;
}
