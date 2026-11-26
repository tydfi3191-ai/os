using System;

// Token: 0x02000239 RID: 569
public sealed class 321 : 346
{
	// Token: 0x0600118D RID: 4493 RVA: 0x0003FD44 File Offset: 0x0003DF44
	public 321() : base(5)
	{
	}

	// Token: 0x0600118E RID: 4494 RVA: 0x0003FD4D File Offset: 0x0003DF4D
	public Array GetArray0212_694()
	{
		return this.array2;
	}

	// Token: 0x0600118F RID: 4495 RVA: 0x0003FD55 File Offset: 0x0003DF55
	public void SetArray0212_695(Array 1)
	{
		this.array2 = 1;
	}

	// Token: 0x06001190 RID: 4496 RVA: 0x0003FD5E File Offset: 0x0003DF5E
	public override object Method1135()
	{
		return this.GetArray0212_694();
	}

	// Token: 0x06001191 RID: 4497 RVA: 0x0003FD66 File Offset: 0x0003DF66
	public override void Method1136(object 1)
	{
		this.SetArray0212_695((Array)1);
	}

	// Token: 0x06001192 RID: 4498 RVA: 0x0003FD74 File Offset: 0x0003DF74
	public override 346 Method1138()
	{
		321 <<EMPTY_NAME>> = new 321();
		<<EMPTY_NAME>>.SetArray0212_695(this.array2);
		<<EMPTY_NAME>>.SetType0637_1116(base.GetType0637_1115());
		return <<EMPTY_NAME>>;
	}

	// Token: 0x06001193 RID: 4499 RVA: 0x0003FD94 File Offset: 0x0003DF94
	public override 346 Method1137(346 1)
	{
		base.SetType0637_1116(1.GetType0637_1115());
		int number0636_ = 1.GetNumber0636_1112();
		if (number0636_ != 5)
		{
			if (number0636_ != 7)
			{
				throw new ArgumentOutOfRangeException();
			}
			this.SetArray0212_695((Array)((349)1).GetValue0650_1133());
		}
		else
		{
			this.SetArray0212_695(((321)1).GetArray0212_694());
		}
		return this;
	}

	// Token: 0x040008B8 RID: 2232
	private Array array2;
}
