using System;

// Token: 0x02000AA7 RID: 2727
public sealed class 1405
{
	// Token: 0x06004BAC RID: 19372 RVA: 0x001DF678 File Offset: 0x001DD878
	internal 1405(1512 1)
	{
		this.7 = 1;
		this.5 = 1f;
		this.2((float)1.1 * 0.8f);
		this.4((float)1.2 * 0.8f);
	}

	// Token: 0x06004BAD RID: 19373 RVA: 0x001DF6B8 File Offset: 0x001DD8B8
	internal float 1()
	{
		return this.1;
	}

	// Token: 0x06004BAE RID: 19374 RVA: 0x001DF6C0 File Offset: 0x001DD8C0
	internal void 2(float 1)
	{
		this.1 = 1;
	}

	// Token: 0x06004BAF RID: 19375 RVA: 0x001DF6C9 File Offset: 0x001DD8C9
	internal float 3()
	{
		return this.2;
	}

	// Token: 0x06004BB0 RID: 19376 RVA: 0x001DF6D1 File Offset: 0x001DD8D1
	internal void 4(float 1)
	{
		this.2 = 1;
	}

	// Token: 0x06004BB1 RID: 19377 RVA: 0x001DF6DA File Offset: 0x001DD8DA
	internal 208 5()
	{
		return this.3;
	}

	// Token: 0x06004BB2 RID: 19378 RVA: 0x001DF6E2 File Offset: 0x001DD8E2
	private void 6(208 1)
	{
		this.3 = 1;
	}

	// Token: 0x06004BB3 RID: 19379 RVA: 0x001DF6EB File Offset: 0x001DD8EB
	internal 208 7()
	{
		return this.4;
	}

	// Token: 0x06004BB4 RID: 19380 RVA: 0x001DF6F3 File Offset: 0x001DD8F3
	private void 8(208 1)
	{
		this.4 = 1;
	}

	// Token: 0x06004BB5 RID: 19381 RVA: 0x001DF6FC File Offset: 0x001DD8FC
	internal float 9()
	{
		return this.3() / 384f;
	}

	// Token: 0x06004BB6 RID: 19382 RVA: 0x001DF70A File Offset: 0x001DD90A
	internal float 10()
	{
		return this.3() / 384f / this.7.3();
	}

	// Token: 0x06004BB7 RID: 19383 RVA: 0x001DF724 File Offset: 0x001DD924
	private float 11()
	{
		return 1f / (this.5 * this.5 * 640f * 480f);
	}

	// Token: 0x06004BB8 RID: 19384 RVA: 0x001DF748 File Offset: 0x001DD948
	internal void 12(float 1, bool 2)
	{
		if (this.5 != 1 || 2)
		{
			bool flag = 1662.78 != 1677.Edit && 2486.14() == 2147.Osu;
			this.5 = 1;
			this.6 = flag;
			this.2(512f * this.7.3() * 1);
			this.4(384f * this.7.3() * 1);
			float num = flag ? (-16f * this.7.3()) : 0f;
			this.6(new 208(((float)this.7.1 - this.1()) / 2f, ((float)this.7.2 - this.3()) / 4f * 3f + num));
			this.8(new 208(0f, ((float)this.7.2 - this.3()) / 4f * 3f + num));
			2039.17(true);
		}
	}

	// Token: 0x06004BB9 RID: 19385 RVA: 0x001DF854 File Offset: 0x001DDA54
	internal float 13(float 1)
	{
		return (1 - this.7().X) / this.9();
	}

	// Token: 0x06004BBA RID: 19386 RVA: 0x001DF86A File Offset: 0x001DDA6A
	internal 208 14(208 1)
	{
		return (1 - this.5()) / this.9();
	}

	// Token: 0x06004BBB RID: 19387 RVA: 0x001DF883 File Offset: 0x001DDA83
	internal float 15(float 1)
	{
		return 1 * this.9() + this.5().X;
	}

	// Token: 0x06004BBC RID: 19388 RVA: 0x001DF899 File Offset: 0x001DDA99
	internal float 16(float 1)
	{
		return 1 * this.9() + this.5().Y;
	}

	// Token: 0x06004BBD RID: 19389 RVA: 0x001DF8AF File Offset: 0x001DDAAF
	internal 208 17(208 1)
	{
		this.18(ref 1);
		return 1;
	}

	// Token: 0x06004BBE RID: 19390 RVA: 0x001DF8BA File Offset: 0x001DDABA
	internal void 18(ref 208 1)
	{
		208.Multiply(ref 1, this.9(), out 1);
		1 = 208.Add(1, this.5());
	}

	// Token: 0x06004BBF RID: 19391 RVA: 0x001DF8E0 File Offset: 0x001DDAE0
	internal void 19(ref 208 1)
	{
		208.Multiply(ref 1, this.9(), out 1);
		1 = 208.Add(1, this.7());
	}

	// Token: 0x06004BC0 RID: 19392 RVA: 0x001DF906 File Offset: 0x001DDB06
	internal void 20(ref 1051 1)
	{
		this.18(ref 1.1);
		this.18(ref 1.2);
	}

	// Token: 0x06004BC1 RID: 19393 RVA: 0x001DF922 File Offset: 0x001DDB22
	internal 1051 21(1051 1)
	{
		return new 1051(this.17(1.1), this.17(1.2));
	}

	// Token: 0x06004BC2 RID: 19394 RVA: 0x001DF944 File Offset: 0x001DDB44
	internal bool 22(208 1)
	{
		return this.27().Contains(new 206((int)1.X, (int)1.Y));
	}

	// Token: 0x06004BC3 RID: 19395 RVA: 0x001DF974 File Offset: 0x001DDB74
	internal bool 23(208 1)
	{
		return this.26().Contains(new 206((int)1.X, (int)1.Y));
	}

	// Token: 0x06004BC4 RID: 19396 RVA: 0x001DF9A2 File Offset: 0x001DDBA2
	internal bool 24(208 1)
	{
		return 1.X >= 0f && 1.X <= 512f && 1.Y >= 0f && 1.Y <= 384f;
	}

	// Token: 0x06004BC5 RID: 19397 RVA: 0x001DF9DD File Offset: 0x001DDBDD
	internal void 25(float 1, float 2)
	{
		this.6(new 208(this.5().X + 1, this.5().Y + 2));
	}

	// Token: 0x06004BC6 RID: 19398 RVA: 0x001DFA04 File Offset: 0x001DDC04
	internal 207 26()
	{
		return new 207(0, 0, 513, 385);
	}

	// Token: 0x06004BC7 RID: 19399 RVA: 0x001DFA17 File Offset: 0x001DDC17
	internal 207 27()
	{
		return new 207((int)this.5().X, (int)this.5().Y, (int)this.1(), (int)this.3());
	}

	// Token: 0x06004BC8 RID: 19400 RVA: 0x001DFA44 File Offset: 0x001DDC44
	internal float 28(int 1)
	{
		return this.11() * (float)1;
	}

	// Token: 0x0400385D RID: 14429
	private float 1;

	// Token: 0x0400385E RID: 14430
	private float 2;

	// Token: 0x0400385F RID: 14431
	private 208 3;

	// Token: 0x04003860 RID: 14432
	private 208 4;

	// Token: 0x04003861 RID: 14433
	internal float 5;

	// Token: 0x04003862 RID: 14434
	internal bool 6;

	// Token: 0x04003863 RID: 14435
	private 1512 7;
}
