using System;

// Token: 0x02000244 RID: 580
public abstract class 346
{
	// Token: 0x060011D7 RID: 4567 RVA: 0x0004103D File Offset: 0x0003F23D
	protected 346(int 1)
	{
		this.number3 = 1;
	}

	// Token: 0x060011D8 RID: 4568 RVA: 0x0004104C File Offset: 0x0003F24C
	public static 346 Method1109(object 1, Type 2)
	{
		346 3 = 1 as 346;
		if (3 != null)
		{
			return 3;
		}
		if (2 == null)
		{
			if (1 == null)
			{
				return new 349();
			}
			2 = 1.GetType();
		}
		2 = 290.Method0119(2);
		346 5;
		switch (290.Method0123(2))
		{
		case 0:
		{
			349 4 = new 349();
			4.SetType0637_1116(2);
			5 = 4;
			goto IL_1E7;
		}
		case 2:
			5 = new 336();
			goto IL_1E7;
		case 4:
			5 = new 347();
			goto IL_1E7;
		case 5:
			5 = new 321();
			goto IL_1E7;
		case 7:
			5 = new 349();
			if (1 != null && 1.GetType() != 290.type3)
			{
				5.SetType0637_1116(1.GetType());
				goto IL_1E7;
			}
			goto IL_1E7;
		case 9:
			5 = new 294();
			goto IL_1E7;
		case 10:
			return new 340((1 != null) ? ((Enum)Enum.ToObject(2, 1)) : ((Enum)Activator.CreateInstance(2)));
		case 11:
			5 = new 288();
			goto IL_1E7;
		case 14:
			5 = new 329();
			goto IL_1E7;
		case 15:
			5 = new 327();
			goto IL_1E7;
		case 17:
			5 = new 285();
			goto IL_1E7;
		case 18:
			5 = new 320();
			goto IL_1E7;
		case 19:
			5 = new 338();
			goto IL_1E7;
		case 20:
			5 = new 324();
			goto IL_1E7;
		case 21:
			5 = new 296();
			goto IL_1E7;
		case 22:
			5 = new 298();
			goto IL_1E7;
		case 23:
			5 = new 339();
			goto IL_1E7;
		case 24:
			5 = new 284();
			goto IL_1E7;
		case 25:
			if (1 == null)
			{
				if (2 != 290.type7)
				{
					1 = Activator.CreateInstance(2);
				}
			}
			else if (1.GetType() != 2)
			{
				try
				{
					1 = Convert.ChangeType(1, 2);
				}
				catch
				{
				}
			}
			return new 343(1);
		case 26:
			5 = new 286();
			goto IL_1E7;
		}
		5 = new 349();
		IL_1E7:
		if (1 != null)
		{
			5.Method1136(1);
		}
		return 5;
	}

	// Token: 0x060011D9 RID: 4569
	public abstract object Method1135();

	// Token: 0x060011DA RID: 4570
	public abstract void Method1136(object 1);

	// Token: 0x060011DB RID: 4571 RVA: 0x0004125C File Offset: 0x0003F45C
	public int GetNumber0636_1112()
	{
		return this.number3;
	}

	// Token: 0x060011DC RID: 4572
	public abstract 346 Method1137(346 1);

	// Token: 0x060011DD RID: 4573
	public abstract 346 Method1138();

	// Token: 0x060011DE RID: 4574 RVA: 0x00041264 File Offset: 0x0003F464
	public Type GetType0637_1115()
	{
		return this.type3;
	}

	// Token: 0x060011DF RID: 4575 RVA: 0x0004126C File Offset: 0x0003F46C
	public void SetType0637_1116(Type 1)
	{
		this.type3 = 1;
	}

	// Token: 0x040008C4 RID: 2244
	private readonly int number3;

	// Token: 0x040008C5 RID: 2245
	private Type type3;
}
