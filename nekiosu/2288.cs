using System;
using System.Collections.Generic;

// Token: 0x0200058A RID: 1418
public class 2288 : 2254
{
	// Token: 0x06002BD1 RID: 11217 RVA: 0x0001702D File Offset: 0x0001522D
	public override 2277 _0005_2005_2000_200A_2003_2005_2004_2004_2005_2003_2000()
	{
		return 2277.Compose;
	}

	// Token: 0x06002BD2 RID: 11218 RVA: 0x000EFDC5 File Offset: 0x000EDFC5
	protected override void _000E_2000_2004_2001_2006_2006_2000_2005_2007_2009_2007_2000_2005_200B_200A_2004_2007_2002_2003_2001_2003_2005_200A_2007_200B(2046 1)
	{
		this.6 = 1;
		this.5 = 1272.5().13();
		this._0005_2008_2008_2007_2006_2004_2004_2003_2001_200A_2009_2007_2005_2004_2009_2009_200A();
		this._000E_2006_2002_2007_2005_2007_2005_2002_2006_2005_2006();
	}

	// Token: 0x06002BD3 RID: 11219 RVA: 0x000EFDEC File Offset: 0x000EDFEC
	protected virtual void _0005_2008_2008_2007_2006_2004_2004_2003_2001_200A_2009_2007_2005_2004_2009_2009_200A()
	{
		switch (this.5)
		{
		case 2327.Easy:
			this.2 = 0.5f;
			return;
		case 2327.Normal:
			this.2 = 1f;
			return;
		case 2327.Hard:
			this.2 = 1.5f;
			return;
		default:
			this.2 = 2.5f;
			return;
		}
	}

	// Token: 0x06002BD4 RID: 11220 RVA: 0x000EFE44 File Offset: 0x000EE044
	protected virtual void _000E_2006_2002_2007_2005_2007_2005_2002_2006_2005_2006()
	{
		this.3 = (float)(64.0 * (1.0 - 0.699999988079071 * this.6.GetNormalizedDifficulty((double)1272.5().2)) / 2.0) - 1f;
		this._000F_2001_2002_2005_2004_2000_2002_2002_2007_2008_2005_2003_2000_2007();
		List<2036> list = this.6.CloneHitObjectData();
		bool flag = false;
		double val = 0.0;
		bool flag2 = false;
		for (int i = 0; i < list.Count; i++)
		{
			2288.2290 objectChecks = new 2288.2290();
			objectChecks.2 = this;
			bool flag3 = i == list.Count - 1;
			objectChecks.1 = list[i];
			2036 <<EMPTY_NAME>> = flag3 ? null : list[i + 1];
			if (this.1(objectChecks.1.8))
			{
				this.1.Add(new 2338(objectChecks.1, objectChecks.1.1, new 2340(objectChecks.1), (2341)1, 1568.1(2679.AICompose_ObjectOffscreen), 0));
			}
			if (objectChecks.1.GetEndPosition() != objectChecks.1.8 && this.1(objectChecks.1.GetEndPosition()))
			{
				this.1.Add(new 2338(objectChecks.1, objectChecks.1.2, new 2340(objectChecks.2), (2341)1, 1568.1(2679.AICompose_ObjectEndOffscreen), 0));
			}
			if (objectChecks.1.5 > 1 && objectChecks.1 is 2123 && this.1(((2123)objectChecks.1).GetCurrentPosition()))
			{
				this.1.Add(new 2338(objectChecks.1, objectChecks.1.2, () => objectChecks.2.1(((2123)objectChecks.1).GetCurrentPosition()), (2341)1, 1568.1(2679.AICompose_ObjectEndOffscreen), 0));
			}
			if (objectChecks.1.GetComboNumber() > 24)
			{
				this.1.Add(new 2338(objectChecks.1, objectChecks.1.2, new 2340(objectChecks.3), (2341)1, 1568.1(2679.AICompose_LongCombo), -1));
			}
			if (i > 0 && !flag3 && list[i].1 == list[i + 1].1)
			{
				2288.2291 2 = new 2288.2291();
				2.2 = objectChecks;
				2.1 = list[i - 1];
				this.1.Add(new 2356(2.1, 2.2.1, new 2340(2.1), (2341)2, 1568.1(2679.AICompose_SimultaneousObjects), -1));
			}
			if (flag && !(objectChecks.1 is 2070))
			{
				2288.2289 3 = new 2288.2289();
				3.2 = objectChecks;
				3.1 = (2070)list[i - 1];
				if (3.1.1 > 3.2.1.1 - this.6.2 + 2039.13)
				{
					this.1.Add(new 2356(3.1, 3.2.1, new 2340(3.1), (2341)2, 1568.1(2679.AICompose_NinjaSpinner), -1));
				}
			}
			flag = (objectChecks.1 is 2070);
			if (objectChecks.1 is 2123)
			{
				2123 4 = objectChecks.1 as 2123;
				if (4.30())
				{
					this.1.Add(new 2338(objectChecks.1, objectChecks.1.1, null, (2341)2, 1568.1(2679.AICompose_AbnormalSlider), -1));
				}
				if (4.2 - 1000 > 4.1)
				{
					val = Math.Max(val, 1226.88((double)4.1, true));
				}
				if (4.54.Count > 40)
				{
					this.1.Add(new 2338(objectChecks.1, objectChecks.1.1, null, (2341)1, "Slider has an absurdly large amount of points!", -1));
				}
			}
			if (objectChecks.1.HasObjectType(2047.Spinner))
			{
				if (!objectChecks.1.HasObjectType(2047.NewCombo))
				{
					this.1.Add(new 2338(objectChecks.1, objectChecks.1.1, null, (2341)1, 1568.1(2679.AICompose_SpinnerNoNewCombo), -1));
				}
				double num = 0.05 * (double)(objectChecks.1.2 - objectChecks.1.1) / 3.141592653589793;
				double num2 = (double)(objectChecks.1.2 - objectChecks.1.1) / 1000.0 * this.6.7;
				if (num - num2 < 5.0)
				{
					this.1.Add(new 2338(objectChecks.1, objectChecks.1.1, null, (2341)1, 1568.1(2679.AICompose_ShortSpinner), -1));
				}
			}
			this._0008_200A_2000_2001_2003_2001_2005_2006_2006_2006_200B_2005_2009_2006(objectChecks.1, <<EMPTY_NAME>>, this.6);
			if (objectChecks.1.HasClap() || objectChecks.1.HasFinish() || objectChecks.1.HasWhistle())
			{
				flag2 = true;
			}
		}
		if (!flag2)
		{
			this.1.Add(new 2278((2341)2, "There are no hitsounds on any objects. Hitsounds are required for rankable beatmaps."));
		}
	}

	// Token: 0x06002BD5 RID: 11221 RVA: 0x000F04CC File Offset: 0x000EE6CC
	protected virtual void _000F_2001_2002_2005_2004_2000_2002_2002_2007_2008_2005_2003_2000_2007()
	{
		List<2036> list = this.6.CloneHitObjectData();
		int i = 0;
		while (i < list.Count)
		{
			2288.2292 snapCheck = new 2288.2292();
			bool flag = i == list.Count - 1;
			snapCheck.1 = list[i];
			if (!flag)
			{
				2036 <<EMPTY_NAME>> = list[i + 1];
			}
			if (i > 0 && !flag && list[i].1 != list[i + 1].1 && list[i].1 < list[i - 1].2 + 10)
			{
				2288.2295 2 = new 2288.2295();
				2.2 = snapCheck;
				2.1 = list[i - 1];
				this.1.Add(new 2356(2.1, 2.2.1, new 2340(2.1), (2341)2, 1568.1(2679.AICompose_ObjectsTooClose), -1));
			}
			if (snapCheck.1.5 > 1)
			{
				2288.2294 spanSnapCheck = new 2288.2294();
				spanSnapCheck.2 = snapCheck;
				spanSnapCheck.1 = 1;
				while (spanSnapCheck.1 <= spanSnapCheck.2.1.5)
				{
					if (2280.7(((2123)spanSnapCheck.2.1).26(spanSnapCheck.1), true, 2.0))
					{
						int num;
						if (2280.8(spanSnapCheck.2.1.2, out num, true))
						{
							int recheckedRepeatDivisor;
							2278 item = new 2338(spanSnapCheck.2.1, spanSnapCheck.2.1.2, () => !2280.8(((2123)spanSnapCheck.2.1).26(spanSnapCheck.1), out recheckedRepeatDivisor, true), (2341)0, string.Format("Rare snap divisor used on slider repeat (1/{0})", num), 0);
							this.1.Add(item);
						}
						else
						{
							2278 item2 = new 2338(spanSnapCheck.2.1, ((2123)spanSnapCheck.2.1).26(spanSnapCheck.1), new 2340(spanSnapCheck.1), (2341)1, 1568.1(2679.AICompose_UnsnappedObject), 0);
							this.1.Add(item2);
						}
					}
					spanSnapCheck.1++;
				}
				goto IL_3DB;
			}
			if (!2280.7(snapCheck.1.1, true, 1.0))
			{
				goto IL_3DB;
			}
			if (!(snapCheck.1 is 2129) || i <= 0 || snapCheck.1.1 - list[i - 1].2 >= 50)
			{
				int num2;
				if (2280.8(snapCheck.1.1, out num2, true))
				{
					2278 item3 = new 2338(snapCheck.1, snapCheck.1.1, new 2340(snapCheck.1), (2341)0, string.Format("Rare snap divisor used (1/{0})", num2), 0);
					this.1.Add(item3);
					goto IL_3DB;
				}
				2278 item4 = new 2338(snapCheck.1, snapCheck.1.1, new 2340(snapCheck.2), (2341)1, 1568.1(2679.AICompose_UnsnappedObject), 0);
				this.1.Add(item4);
				goto IL_3DB;
			}
			IL_4DA:
			i++;
			continue;
			IL_3DB:
			if (snapCheck.1.2 == snapCheck.1.1 || !2280.7(snapCheck.1.2, true, 2.0))
			{
				goto IL_4DA;
			}
			int num3;
			if (2280.8(snapCheck.1.2, out num3, true))
			{
				int recheckedEndDivisor;
				2278 item5 = new 2338(snapCheck.1, snapCheck.1.2, () => !2280.8(snapCheck.1.2, out recheckedEndDivisor, true), (2341)0, string.Format("Rare snap divisor used on slider end (1/{0})", num3), 0);
				this.1.Add(item5);
				goto IL_4DA;
			}
			2278 item6 = new 2338(snapCheck.1, snapCheck.1.2, new 2340(snapCheck.3), (2341)1, 1568.1(2679.AICompose_UnsnappedObjectEnd), 0);
			this.1.Add(item6);
			goto IL_4DA;
		}
	}

	// Token: 0x06002BD6 RID: 11222 RVA: 0x000F09C4 File Offset: 0x000EEBC4
	protected virtual void _0008_200A_2000_2001_2003_2001_2005_2006_2006_2006_200B_2005_2009_2006(2036 1, 2036 2, 2046 3)
	{
		2288.2293 4 = new 2288.2293();
		4.1 = 1;
		4.2 = 2;
		4.3 = 3;
		if (this.4 && 4.2 != null && !4.2.IsNewCombo() && !(4.2 is 2070))
		{
			float num = 2288.2(4.1, 4.2, 4.3);
			if (4.1.IsNewCombo() || this.9 < 0.01f)
			{
				this.9 = num;
				this.7 = 4.1;
				this.8 = 4.2;
				return;
			}
			if (this.9 > 0.01f && num > 0.01f && ((double)(num - this.9) > (double)this.9 * 0.1 * (double)this.2 || (double)(this.9 - num) > (double)this.9 * 0.2 * (double)this.2))
			{
				4.4 = this.7;
				4.5 = this.8;
				2356 item = new 2356(4.1, 4.2, new 2340(4.1), (2341)1, (num < this.9) ? 1568.1(2679.AICompose_ObjectTooClose) : 1568.1(2679.AICompose_ObjectTooFar), 82809);
				this.1.Add(item);
			}
		}
	}

	// Token: 0x06002BD7 RID: 11223 RVA: 0x000F0B40 File Offset: 0x000EED40
	private new bool 1(208 1)
	{
		return 1.X - this.3 < -64f || 1.X + this.3 > 576f || 1.Y - this.3 < -48f || 1.Y + this.3 > 432f;
	}

	// Token: 0x06002BD8 RID: 11224 RVA: 0x000F0BA0 File Offset: 0x000EEDA0
	private static float 2(2036 1, 2036 2, 2046 3)
	{
		int num = 1.2;
		int 4 = 2.1;
		int num2 = 4 - num;
		float num3 = (float)3.GetSliderVelocityAt(4);
		return 1000f * (2.8 - 1.GetEndPosition()).Length() / (num3 * (float)num2);
	}

	// Token: 0x04002015 RID: 8213
	private float 2 = 1f;

	// Token: 0x04002016 RID: 8214
	private float 3 = 40f;

	// Token: 0x04002017 RID: 8215
	public bool 4;

	// Token: 0x04002018 RID: 8216
	public 2327 5;

	// Token: 0x04002019 RID: 8217
	protected 2046 6;

	// Token: 0x0400201A RID: 8218
	protected 2036 7;

	// Token: 0x0400201B RID: 8219
	protected 2036 8;

	// Token: 0x0400201C RID: 8220
	protected float 9;

	// Token: 0x0200058B RID: 1419
	public sealed class 2289
	{
		// Token: 0x06002BDA RID: 11226 RVA: 0x000F0C0B File Offset: 0x000EEE0B
		internal bool 1()
		{
			return this.1.1 <= this.2.1.1 - this.2.2.6.2 + 2039.13;
		}

		// Token: 0x0400201D RID: 8221
		public 2070 1;

		// Token: 0x0400201E RID: 8222
		public 2288.2290 2;
	}

	// Token: 0x0200058C RID: 1420
	public sealed class 2290
	{
		// Token: 0x06002BDC RID: 11228 RVA: 0x000F0C49 File Offset: 0x000EEE49
		internal bool 1()
		{
			return this.2.1(this.1.8);
		}

		// Token: 0x06002BDD RID: 11229 RVA: 0x000F0C61 File Offset: 0x000EEE61
		internal bool 2()
		{
			return this.2.1(this.1.GetEndPosition());
		}

		// Token: 0x06002BDE RID: 11230 RVA: 0x000F0C79 File Offset: 0x000EEE79
		internal bool 3()
		{
			return this.1.GetComboNumber() <= 24;
		}

		// Token: 0x0400201F RID: 8223
		public 2036 1;

		// Token: 0x04002020 RID: 8224
		public 2288 2;
	}

	// Token: 0x0200058D RID: 1421
	public sealed class 2293
	{
		// Token: 0x06002BE0 RID: 11232 RVA: 0x000F0C8D File Offset: 0x000EEE8D
		internal bool 1()
		{
			return Math.Abs(2288.2(this.1, this.2, this.3) - 2288.2(this.4, this.5, this.3)) < 0.05f;
		}

		// Token: 0x04002021 RID: 8225
		public 2036 1;

		// Token: 0x04002022 RID: 8226
		public 2036 2;

		// Token: 0x04002023 RID: 8227
		public 2046 3;

		// Token: 0x04002024 RID: 8228
		public 2036 4;

		// Token: 0x04002025 RID: 8229
		public 2036 5;
	}

	// Token: 0x0200058E RID: 1422
	public sealed class 2295
	{
		// Token: 0x06002BE2 RID: 11234 RVA: 0x000F0CCA File Offset: 0x000EEECA
		internal bool 1()
		{
			return Math.Abs(this.1.1 - this.2.1.1) > 10;
		}

		// Token: 0x04002026 RID: 8230
		public 2036 1;

		// Token: 0x04002027 RID: 8231
		public 2288.2292 2;
	}

	// Token: 0x0200058F RID: 1423
	public sealed class 2294
	{
		// Token: 0x06002BE4 RID: 11236 RVA: 0x000F0CF1 File Offset: 0x000EEEF1
		internal bool 1()
		{
			return 2280.7(((2123)this.2.1).26(this.1), true, 2.0);
		}

		// Token: 0x04002028 RID: 8232
		public int 1;

		// Token: 0x04002029 RID: 8233
		public 2288.2292 2;
	}

	// Token: 0x02000590 RID: 1424
	public sealed class 2292
	{
		// Token: 0x06002BE6 RID: 11238 RVA: 0x000F0D20 File Offset: 0x000EEF20
		internal bool 1()
		{
			int num;
			return !2280.8(this.1.1, out num, true);
		}

		// Token: 0x06002BE7 RID: 11239 RVA: 0x000F0D43 File Offset: 0x000EEF43
		internal bool 2()
		{
			return 2280.7(this.1.1, true, 1.0);
		}

		// Token: 0x06002BE8 RID: 11240 RVA: 0x000F0D5F File Offset: 0x000EEF5F
		internal bool 3()
		{
			return 2280.7(this.1.2, true, 2.0);
		}

		// Token: 0x0400202A RID: 8234
		public 2036 1;
	}

	// Token: 0x02000591 RID: 1425
	public sealed class 2291
	{
		// Token: 0x06002BEA RID: 11242 RVA: 0x000F0D7B File Offset: 0x000EEF7B
		internal bool 1()
		{
			return this.1.1 != this.2.1.1;
		}

		// Token: 0x0400202B RID: 8235
		public 2036 1;

		// Token: 0x0400202C RID: 8236
		public 2288.2290 2;
	}
}
