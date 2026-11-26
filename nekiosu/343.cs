using System;
using System.Reflection;

// Token: 0x02000242 RID: 578
public sealed class 343 : 346
{
	// Token: 0x060011C7 RID: 4551 RVA: 0x00040E10 File Offset: 0x0003F010
	public 343(object 1) : base(25)
	{
		if (1 != null && !(1 is ValueType))
		{
			throw new ArgumentException();
		}
		this.value2 = 1;
	}

	// Token: 0x060011C8 RID: 4552 RVA: 0x00040E32 File Offset: 0x0003F032
	public object GetValue0626_1075()
	{
		return this.value2;
	}

	// Token: 0x060011C9 RID: 4553 RVA: 0x00040E3A File Offset: 0x0003F03A
	public void Method1076(object 1)
	{
		if (1 != null && !(1 is ValueType))
		{
			throw new ArgumentException();
		}
		this.value2 = 1;
	}

	// Token: 0x060011CA RID: 4554 RVA: 0x00040E54 File Offset: 0x0003F054
	public override object Method1135()
	{
		return this.GetValue0626_1075();
	}

	// Token: 0x060011CB RID: 4555 RVA: 0x00040E5C File Offset: 0x0003F05C
	public override void Method1136(object 1)
	{
		this.Method1076(1);
	}

	// Token: 0x060011CC RID: 4556 RVA: 0x00040E68 File Offset: 0x0003F068
	private static bool Method1079(Type 1)
	{
		if (1.IsGenericType && 1.Namespace == "System")
		{
			string name = 1.Name;
			if (name == "Span`1" || name == "ReadOnlySpan`1")
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x060011CD RID: 4557 RVA: 0x00040EB4 File Offset: 0x0003F0B4
	public override 346 Method1137(346 1)
	{
		base.SetType0637_1116(1.GetType0637_1115());
		int number0636_ = 1.GetNumber0636_1112();
		if (number0636_ != 7)
		{
			if (number0636_ == 25)
			{
				object value0626_ = ((343)1).GetValue0626_1075();
				object value0626_2 = this.GetValue0626_1075();
				if (value0626_2 != null && value0626_ != null)
				{
					Type type = value0626_2.GetType();
					if (!type.IsPrimitive && !type.IsEnum && type == value0626_.GetType() && 343.Method1079(type))
					{
						foreach (FieldInfo fieldInfo in type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
						{
							fieldInfo.SetValue(value0626_2, fieldInfo.GetValue(value0626_));
						}
						return this;
					}
				}
				this.Method1076(value0626_);
			}
			else
			{
				this.Method1076(1.Method1135());
			}
		}
		else
		{
			this.Method1076(((349)1).GetValue0650_1133());
		}
		return this;
	}

	// Token: 0x060011CE RID: 4558 RVA: 0x00040F83 File Offset: 0x0003F183
	public override 346 Method1138()
	{
		343 <<EMPTY_NAME>> = new 343(this.value2);
		<<EMPTY_NAME>>.SetType0637_1116(base.GetType0637_1115());
		return <<EMPTY_NAME>>;
	}

	// Token: 0x040008C2 RID: 2242
	private object value2;
}
