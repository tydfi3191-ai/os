using System;

// Token: 0x0200023D RID: 573
public sealed class 336 : 346
{
	// Token: 0x060011AA RID: 4522 RVA: 0x00040579 File Offset: 0x0003E779
	public 336() : base(2)
	{
	}

	// Token: 0x060011AB RID: 4523 RVA: 0x00040582 File Offset: 0x0003E782
	public string GetText0574_955()
	{
		return this.text2;
	}

	// Token: 0x060011AC RID: 4524 RVA: 0x0004058A File Offset: 0x0003E78A
	public void SetText0574_956(string 1)
	{
		this.text2 = 1;
	}

	// Token: 0x060011AD RID: 4525 RVA: 0x00040593 File Offset: 0x0003E793
	public override object Method1135()
	{
		return this.GetText0574_955();
	}

	// Token: 0x060011AE RID: 4526 RVA: 0x0004059B File Offset: 0x0003E79B
	public override void Method1136(object 1)
	{
		this.SetText0574_956((string)1);
	}

	// Token: 0x060011AF RID: 4527 RVA: 0x000405AC File Offset: 0x0003E7AC
	public override 346 Method1137(346 1)
	{
		base.SetType0637_1116(1.GetType0637_1115());
		int number0636_ = 1.GetNumber0636_1112();
		if (number0636_ != 2)
		{
			if (number0636_ != 7)
			{
				throw new ArgumentOutOfRangeException();
			}
			this.SetText0574_956((string)((349)1).GetValue0650_1133());
		}
		else
		{
			this.SetText0574_956(((336)1).GetText0574_955());
		}
		return this;
	}

	// Token: 0x060011B0 RID: 4528 RVA: 0x00040608 File Offset: 0x0003E808
	public override 346 Method1138()
	{
		336 <<EMPTY_NAME>> = new 336();
		<<EMPTY_NAME>>.SetText0574_956(this.text2);
		<<EMPTY_NAME>>.SetType0637_1116(base.GetType0637_1115());
		return <<EMPTY_NAME>>;
	}

	// Token: 0x040008BC RID: 2236
	private string text2;
}
