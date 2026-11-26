using System;

// Token: 0x02000606 RID: 1542
public sealed class 2398 : 2387
{
	// Token: 0x06002F38 RID: 12088 RVA: 0x0010B55E File Offset: 0x0010975E
	internal 2398(2440 1, 2450 2) : base(1, 2)
	{
		base.2((2451)13);
	}

	// Token: 0x06002F39 RID: 12089 RVA: 0x0010B570 File Offset: 0x00109770
	internal override bool CaptureBackup()
	{
		if (this.12 == 0)
		{
			return false;
		}
		2034 <<EMPTY_NAME>> = this.8[0] as 2034;
		this.14 = (((<<EMPTY_NAME>> != null) ? <<EMPTY_NAME>>.Clone() : null) as 2123);
		return this.14 != null;
	}

	// Token: 0x06002F3A RID: 12090 RVA: 0x0010B5AD File Offset: 0x001097AD
	internal override void Release()
	{
		this.14 = null;
		base.Release();
	}

	// Token: 0x06002F3B RID: 12091 RVA: 0x0010B5BC File Offset: 0x001097BC
	internal override bool HasChanged()
	{
		if (this.14 == null)
		{
			return false;
		}
		2123 <<EMPTY_NAME>> = (2123)this.8[0];
		return <<EMPTY_NAME>>.18 != this.14.18 || <<EMPTY_NAME>>.2() != this.14.2() || (<<EMPTY_NAME>>.1 != this.14.1 || <<EMPTY_NAME>>.2 != this.14.2) || (<<EMPTY_NAME>>.IsNewCombo() != this.14.IsNewCombo() || <<EMPTY_NAME>>.4 != this.14.4 || <<EMPTY_NAME>>.35 != this.14.35 || <<EMPTY_NAME>>.36 != this.14.36) || (!<<EMPTY_NAME>>.84.ElementsEqual(this.14.84) || !<<EMPTY_NAME>>.85.ElementsEqual(this.14.85) || !<<EMPTY_NAME>>.86.ElementsEqual(this.14.86)) || !<<EMPTY_NAME>>.54.ElementsEqual(this.14.54) || <<EMPTY_NAME>>.9().Count != this.14.9().Count;
	}

	// Token: 0x06002F3C RID: 12092 RVA: 0x0010B714 File Offset: 0x00109914
	internal override void Apply(2457 1)
	{
		2123 2 = (2123)this.8[0];
		177.Method12592<208>(2.54, this.14.54);
		2.5();
		this.14.5();
		208 3 = 2.18;
		2.58.SetPosition(this.14.8, false);
		2.8 = (2.18 = this.14.8);
		this.14.8 = (this.14.18 = 3);
		double 4 = 2.6;
		2.6 = this.14.6;
		this.14.6 = 4;
		int 5 = 2.1;
		int 6 = 2.2;
		2.13(this.14.1, false);
		this.14.1 = 5;
		this.14.2 = 6;
		bool newCombo = 2.IsNewCombo();
		2.SetNewCombo(this.14.IsNewCombo());
		this.14.SetNewCombo(newCombo);
		1245 7 = 2.4;
		2.4 = this.14.4;
		this.14.4 = 7;
		1254 8 = 2.35;
		1254 9 = 2.36;
		2.35 = this.14.35;
		2.36 = this.14.36;
		this.14.35 = 8;
		this.14.36 = 9;
		177.Method12592<1245>(2.84, this.14.84);
		177.Method12592<1254>(2.85, this.14.85);
		177.Method12592<1254>(2.86, this.14.86);
		2.RebuildPathAndTiming(true);
		this.4.1.74.53();
		this.4.1.74.54();
	}

	// Token: 0x04002235 RID: 8757
	private 2123 14;
}
