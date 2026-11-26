using System;
using System.Collections.Generic;
using System.Threading;

// Token: 0x02000A87 RID: 2695
public class 1371 : IDisposable, IComparable<1371>
{
	// Token: 0x06004A8C RID: 19084 RVA: 0x001D917E File Offset: 0x001D737E
	public 1371(bool 1 = true)
	{
		this.5 = 1;
		if (1)
		{
			this.16 = 1f;
		}
	}

	// Token: 0x06004A8D RID: 19085 RVA: 0x0000FF75 File Offset: 0x0000E175
	internal virtual bool CanBatch()
	{
		return false;
	}

	// Token: 0x06004A8E RID: 19086 RVA: 0x001D91B8 File Offset: 0x001D73B8
	internal bool 1(bool 1)
	{
		if (this.11 && !1)
		{
			return false;
		}
		bool flag = this.13 != null;
		if (flag)
		{
			this.13(this, null);
		}
		if (this.12 != null)
		{
			int num = this.12.10 - this.12.9;
			this.12.9 = 1662.33;
			this.12.10 = 1662.33 + num;
			if (!this.3.Contains(this.12))
			{
				this.3.Add(this.12);
			}
		}
		return flag;
	}

	// Token: 0x06004A8F RID: 19087 RVA: 0x001D9251 File Offset: 0x001D7451
	internal void 2()
	{
		this.13 = null;
	}

	// Token: 0x06004A90 RID: 19088 RVA: 0x001D925C File Offset: 0x001D745C
	internal void 3(EventHandler 1)
	{
		EventHandler eventHandler = this.13;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, 1);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.13, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06004A91 RID: 19089 RVA: 0x001D9294 File Offset: 0x001D7494
	internal 207 4()
	{
		if (!this.7())
		{
			return 1379.30();
		}
		207? <<EMPTY_NAME>> = this.21;
		if (<<EMPTY_NAME>> == null)
		{
			return 1436.40.36;
		}
		return <<EMPTY_NAME>>.GetValueOrDefault();
	}

	// Token: 0x06004A92 RID: 19090 RVA: 0x001D92D4 File Offset: 0x001D74D4
	internal 1058? 5()
	{
		return new 1058?(this.22 ?? 1436.40.34);
	}

	// Token: 0x06004A93 RID: 19091 RVA: 0x001D930C File Offset: 0x001D750C
	internal void 6(1058? 1)
	{
		this.22 = 1;
		if (1 == null)
		{
			this.21 = null;
			return;
		}
		this.21 = new 207?(new 207((int)(1.Value.X * 1662.70.3()), (int)(1.Value.Y * 1662.70.3()), (int)Math.Ceiling((double)(1.Value.Width * 1662.70.3())), (int)Math.Ceiling((double)(1.Value.Height * 1662.70.3()))));
	}

	// Token: 0x06004A94 RID: 19092 RVA: 0x001D93B2 File Offset: 0x001D75B2
	protected bool 7()
	{
		return 1436.40.24 || this.22 != null;
	}

	// Token: 0x06004A95 RID: 19093 RVA: 0x001D93CD File Offset: 0x001D75CD
	internal virtual bool IsHovered()
	{
		return this.25;
	}

	// Token: 0x06004A96 RID: 19094 RVA: 0x001D93D5 File Offset: 0x001D75D5
	internal virtual void SetHovered(bool 1)
	{
		if (1 != this.25)
		{
			this.25 = 1;
		}
	}

	// Token: 0x06004A97 RID: 19095 RVA: 0x001D93E7 File Offset: 0x001D75E7
	internal bool 8()
	{
		return this.26;
	}

	// Token: 0x06004A98 RID: 19096 RVA: 0x001D93EF File Offset: 0x001D75EF
	internal void 9(bool 1)
	{
		this.26 = 1;
		if (this.26)
		{
			this.SetHovered(false);
		}
	}

	// Token: 0x06004A99 RID: 19097 RVA: 0x001D9407 File Offset: 0x001D7607
	protected int 10()
	{
		if (this.1 != (1044)0)
		{
			return 1226.16;
		}
		return 1662.33;
	}

	// Token: 0x06004A9A RID: 19098 RVA: 0x001D941C File Offset: 0x001D761C
	public virtual bool Draw()
	{
		if (1304.220)
		{
			1477 <<EMPTY_NAME>> = 1662.42;
			if (<<EMPTY_NAME>> != null)
			{
				1436 2 = <<EMPTY_NAME>>.1;
				bool flag;
				if (2 == null)
				{
					flag = true;
				}
				else
				{
					List<1371> 3 = 2.28;
					flag = !((3 != null) ? new bool?(3.Contains(this)) : null).GetValueOrDefault();
				}
				if (!flag)
				{
					goto IL_50;
				}
			}
			return false;
		}
		IL_50:
		return !this.26;
	}

	// Token: 0x06004A9B RID: 19099 RVA: 0x001D9484 File Offset: 0x001D7684
	public virtual 1069 Update()
	{
		if (1304.220)
		{
			1477 <<EMPTY_NAME>> = 1662.42;
			if (<<EMPTY_NAME>> != null)
			{
				1436 2 = <<EMPTY_NAME>>.1;
				bool flag;
				if (2 == null)
				{
					flag = true;
				}
				else
				{
					List<1371> 3 = 2.28;
					flag = !((3 != null) ? new bool?(3.Contains(this)) : null).GetValueOrDefault();
				}
				if (!flag)
				{
					goto IL_50;
				}
			}
			return (1069)1;
		}
		IL_50:
		if (this.26)
		{
			return (1069)1;
		}
		return (1069)0;
	}

	// Token: 0x06004A9C RID: 19100 RVA: 0x001D94EC File Offset: 0x001D76EC
	internal void 11()
	{
		if (this.4 == null || this.4.Count == 0)
		{
			return;
		}
		this.3.RemoveAll(new Predicate<1445>(1371.1372.drawableCallbacks.1));
		foreach (1457 <<EMPTY_NAME>> in this.4)
		{
			this.12(<<EMPTY_NAME>>);
		}
	}

	// Token: 0x06004A9D RID: 19101 RVA: 0x001D9574 File Offset: 0x001D7774
	internal void 12(1457 1)
	{
		List<1445> list = 1.GenerateTransformations();
		if (list == null)
		{
			return;
		}
		foreach (1445 2 in list)
		{
			this.3.Method11157(2);
		}
	}

	// Token: 0x06004A9E RID: 19102 RVA: 0x001D95D4 File Offset: 0x001D77D4
	public int CompareTo(1371 1)
	{
		return this.3[0].9.CompareTo(1.3[0].9);
	}

	// Token: 0x06004A9F RID: 19103 RVA: 0x001D9600 File Offset: 0x001D7800
	~1371()
	{
		this.ReleaseResources(true);
	}

	// Token: 0x06004AA0 RID: 19104 RVA: 0x001D9630 File Offset: 0x001D7830
	public virtual void Dispose()
	{
		GC.SuppressFinalize(this);
		this.ReleaseResources(false);
	}

	// Token: 0x06004AA1 RID: 19105 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal virtual void ReleaseResources(bool 1)
	{
	}

	// Token: 0x06004AA2 RID: 19106 RVA: 0x001D963F File Offset: 0x001D783F
	internal void 13()
	{
		this.16(0, (1046)0, 0);
	}

	// Token: 0x06004AA3 RID: 19107 RVA: 0x001D964A File Offset: 0x001D784A
	internal void 14()
	{
		this.FadeIn(0, (1046)0, 0);
	}

	// Token: 0x06004AA4 RID: 19108 RVA: 0x001D9658 File Offset: 0x001D7858
	internal void FadeIn(int 1, 1046 2, int 3)
	{
		if (this.3.Count == 0 && this.16 == 1f)
		{
			return;
		}
		object obj = 1436.2;
		lock (obj)
		{
			this.3.RemoveAll((1445 1) => 1.14 == 1456.Fade);
		}
		if (1f - this.16 >= 1E-45f)
		{
			if (4 == 0)
			{
				this.16 = 1f;
				return;
			}
			int num = 1662.43(this.1) + 3;
			1445 item = new 1445(1456.Fade, this.16, 1f, num - (int)1662.82, num + 4, 2);
			this.3.Add(item);
		}
	}

	// Token: 0x06004AA5 RID: 19109 RVA: 0x001D9734 File Offset: 0x001D7934
	internal 1445 15(int 1)
	{
		this.16 = 0f;
		object obj = 1436.2;
		lock (obj)
		{
			this.3.RemoveAll(new Predicate<1445>(1371.1372.drawableCallbacks.2));
		}
		1445 2 = new 1445(1456.Fade, 0f, 1f, 1662.43(this.1) - (int)1662.82, 1662.43(this.1) + 1, (1046)0);
		this.3.Add(2);
		return 2;
	}

	// Token: 0x06004AA6 RID: 19110 RVA: 0x001D97D4 File Offset: 0x001D79D4
	internal void 16(int 1, 1046 2, int 3)
	{
		if (this.3.Count == 0 && this.16 == 0f)
		{
			return;
		}
		object obj = 1436.2;
		lock (obj)
		{
			this.3.RemoveAll((1445 1) => 1.14 == 1456.Fade);
		}
		if (this.16 >= 1E-45f)
		{
			if (4 == 0)
			{
				this.16 = 0f;
				return;
			}
			int num = 1662.43(this.1) + 3;
			1445 item = new 1445(1456.Fade, this.16, 0f, num - (int)1662.82, num + 4, 2);
			this.3.Add(item);
		}
	}

	// Token: 0x06004AA7 RID: 19111 RVA: 0x001D98A8 File Offset: 0x001D7AA8
	internal 1445 17(int 1)
	{
		this.16 = 1f;
		object obj = 1436.2;
		lock (obj)
		{
			this.3.RemoveAll(new Predicate<1445>(1371.1372.drawableCallbacks.3));
		}
		1445 2 = new 1445(1456.Fade, 1f, 0f, 1662.43(this.1) - (int)1662.82, 1662.43(this.1) + 1, (1046)0);
		this.3.Add(2);
		return 2;
	}

	// Token: 0x06004AA8 RID: 19112 RVA: 0x001D9948 File Offset: 0x001D7B48
	internal void 18(208 1, int 2)
	{
		this.19(1, 2, (1046)0);
	}

	// Token: 0x06004AA9 RID: 19113 RVA: 0x001D9954 File Offset: 0x001D7B54
	internal 1445 19(208 1, int 2, 1046 3)
	{
		object obj = 1436.2;
		lock (obj)
		{
			this.3.RemoveAll(new Predicate<1445>(1371.1372.drawableCallbacks.4));
		}
		if (1 == this.17)
		{
			return null;
		}
		if (2 == 0)
		{
			this.17 = 1;
			return null;
		}
		1445 4 = new 1445(this.17, 1, 1662.43(this.1) - (int)Math.Max(1.0, 1662.82), 1662.43(this.1) + 2, (1046)0);
		4.15 = 3;
		this.3.Add(4);
		return 4;
	}

	// Token: 0x06004AAA RID: 19114 RVA: 0x001D9A14 File Offset: 0x001D7C14
	internal void 20(float 1, int 2, 1046 3)
	{
		object obj = 1436.2;
		lock (obj)
		{
			this.3.RemoveAll(new Predicate<1445>(1371.1372.drawableCallbacks.5));
		}
		if (1 != this.17.X)
		{
			if (2 == 0)
			{
				this.17.X = 1;
				return;
			}
			1445 4 = new 1445(1456.MovementX, this.17.X, 1, 1662.43(this.1) - (int)Math.Max(1.0, 1662.82), 1662.43(this.1) + 2, (1046)0);
			4.15 = 3;
			this.3.Add(4);
		}
	}

	// Token: 0x06004AAB RID: 19115 RVA: 0x001D9AE0 File Offset: 0x001D7CE0
	internal void 21(float 1, int 2, 1046 3)
	{
		object obj = 1436.2;
		lock (obj)
		{
			this.3.RemoveAll(new Predicate<1445>(1371.1372.drawableCallbacks.6));
		}
		if (1 != this.17.Y)
		{
			if (2 == 0)
			{
				this.17.Y = 1;
				return;
			}
			1445 4 = new 1445(1456.MovementY, this.17.Y, 1, 1662.43(this.1) - (int)Math.Max(1.0, 1662.82), 1662.43(this.1) + 2, (1046)0);
			4.15 = 3;
			this.3.Add(4);
		}
	}

	// Token: 0x06004AAC RID: 19116 RVA: 0x001D9BAC File Offset: 0x001D7DAC
	internal void 22(208 1, int 2, 1046 3)
	{
		1445 4 = this.3.Find(new Predicate<1445>(1371.1372.drawableCallbacks.7));
		if (4 != null)
		{
			this.17 = 4.6;
		}
		object obj = 1436.2;
		lock (obj)
		{
			this.3.RemoveAll(new Predicate<1445>(1371.1372.drawableCallbacks.8));
		}
		1445 item = new 1445(this.17, this.17 + 1, 1662.43(this.1), 1662.43(this.1) + 2, (1046)0)
		{
			15 = 3,
			16 = 125
		};
		this.3.Add(item);
	}

	// Token: 0x06004AAD RID: 19117 RVA: 0x001D9C78 File Offset: 0x001D7E78
	internal void 23(int 1)
	{
		if (1 == 0)
		{
			return;
		}
		foreach (1445 2 in this.3)
		{
			2.9 += 1;
			2.10 += 1;
		}
	}

	// Token: 0x06004AAE RID: 19118 RVA: 0x001D9CE4 File Offset: 0x001D7EE4
	public void 24(float 1, int 2, 1046 3)
	{
		if (this.3.Count == 1)
		{
			1445 4 = this.3[0];
			if (4.14 == 1456.Fade && 4.5 == 6 && 4.10 - 4.9 == 2)
			{
				return;
			}
		}
		object obj = 1436.2;
		lock (obj)
		{
			this.3.RemoveAll((1445 1) => 1.14 == 1456.Fade);
		}
		if (this.16 != 6)
		{
			1445 5 = new 1445(1456.Fade, this.16, (this.6.A != 0) ? ((float)this.6.A / 255f * 6) : 6, 1662.43(this.1) - (int)1662.82, 1662.43(this.1) + 2, (1046)0);
			5.15 = 3;
			this.3.Add(5);
		}
	}

	// Token: 0x06004AAF RID: 19119 RVA: 0x001D9DF4 File Offset: 0x001D7FF4
	public 1445 25(float 1, int 2, 1046 3)
	{
		if (this.3.Count == 1)
		{
			1445 4 = this.3[0];
			if (4.14 == 1456.Scale && 4.5 == 1 && 4.10 - 4.9 == 2)
			{
				return null;
			}
		}
		object obj = 1436.2;
		lock (obj)
		{
			this.3.RemoveAll(new Predicate<1445>(1371.1372.drawableCallbacks.9));
		}
		if (this.15 == 1)
		{
			return null;
		}
		1445 5 = new 1445(1456.Scale, this.15, 1, 1662.43(this.1) - (int)1662.82, 1662.43(this.1) + 2, (1046)0);
		5.15 = 3;
		this.3.Add(5);
		return 5;
	}

	// Token: 0x06004AB0 RID: 19120 RVA: 0x001D9ED8 File Offset: 0x001D80D8
	public void 26(float 1, int 2, 1046 3)
	{
		if (this.3.Count == 1)
		{
			1445 4 = this.3[0];
			if (4.14 == 1456.Rotation && 4.5 == 1 && 4.10 - 4.9 == 2)
			{
				return;
			}
		}
		object obj = 1436.2;
		lock (obj)
		{
			this.3.RemoveAll(new Predicate<1445>(1371.1372.drawableCallbacks.10));
		}
		if (this.14 != 1)
		{
			1445 5 = new 1445(1456.Rotation, this.14, 1, 1662.43(this.1) - (int)1662.82, 1662.43(this.1) + 2, (1046)0);
			5.15 = 3;
			this.3.Add(5);
		}
	}

	// Token: 0x04003796 RID: 14230
	internal 1044 1;

	// Token: 0x04003797 RID: 14231
	internal float 2;

	// Token: 0x04003798 RID: 14232
	internal readonly List<1445> 3 = new List<1445>();

	// Token: 0x04003799 RID: 14233
	internal List<1457> 4;

	// Token: 0x0400379A RID: 14234
	internal bool 5;

	// Token: 0x0400379B RID: 14235
	internal 198 6;

	// Token: 0x0400379C RID: 14236
	internal 208 7;

	// Token: 0x0400379D RID: 14237
	internal object 8;

	// Token: 0x0400379E RID: 14238
	internal int 9;

	// Token: 0x0400379F RID: 14239
	internal bool 10;

	// Token: 0x040037A0 RID: 14240
	internal bool 11;

	// Token: 0x040037A1 RID: 14241
	internal 1445 12;

	// Token: 0x040037A2 RID: 14242
	private EventHandler 13;

	// Token: 0x040037A3 RID: 14243
	internal float 14;

	// Token: 0x040037A4 RID: 14244
	internal float 15;

	// Token: 0x040037A5 RID: 14245
	internal float 16;

	// Token: 0x040037A6 RID: 14246
	internal 208 17;

	// Token: 0x040037A7 RID: 14247
	internal 2528 18;

	// Token: 0x040037A8 RID: 14248
	internal bool 19;

	// Token: 0x040037A9 RID: 14249
	internal 208 20 = 208.One;

	// Token: 0x040037AA RID: 14250
	private 207? 21;

	// Token: 0x040037AB RID: 14251
	private 1058? 22;

	// Token: 0x040037AC RID: 14252
	internal int 23;

	// Token: 0x040037AD RID: 14253
	internal 1060 24 = (1060)2;

	// Token: 0x040037AE RID: 14254
	protected bool 25;

	// Token: 0x040037AF RID: 14255
	protected bool 26;

	// Token: 0x040037B0 RID: 14256
	internal bool 27;

	// Token: 0x02000A88 RID: 2696
	[Serializable]
	public sealed class 1372
	{
		// Token: 0x06004AB1 RID: 19121 RVA: 0x001D9FB8 File Offset: 0x001D81B8
		internal bool 1(1445 1)
		{
			return 1.18;
		}

		// Token: 0x06004AB2 RID: 19122 RVA: 0x000CAAF9 File Offset: 0x000C8CF9
		internal bool 2(1445 1)
		{
			return 1.14 == 1456.Fade;
		}

		// Token: 0x06004AB3 RID: 19123 RVA: 0x000CAAF9 File Offset: 0x000C8CF9
		internal bool 3(1445 1)
		{
			return 1.14 == 1456.Fade;
		}

		// Token: 0x06004AB4 RID: 19124 RVA: 0x001D9FC0 File Offset: 0x001D81C0
		internal bool 4(1445 1)
		{
			return (1.14 & 1456.Movement) > 1456.None;
		}

		// Token: 0x06004AB5 RID: 19125 RVA: 0x001D9FCD File Offset: 0x001D81CD
		internal bool 5(1445 1)
		{
			return (1.14 & 1456.MovementX) > 1456.None;
		}

		// Token: 0x06004AB6 RID: 19126 RVA: 0x001D9FDE File Offset: 0x001D81DE
		internal bool 6(1445 1)
		{
			return (1.14 & 1456.MovementY) > 1456.None;
		}

		// Token: 0x06004AB7 RID: 19127 RVA: 0x001D9FEF File Offset: 0x001D81EF
		internal bool 7(1445 1)
		{
			return 1.16 == 125;
		}

		// Token: 0x06004AB8 RID: 19128 RVA: 0x001D9FC0 File Offset: 0x001D81C0
		internal bool 8(1445 1)
		{
			return (1.14 & 1456.Movement) > 1456.None;
		}

		// Token: 0x06004AB9 RID: 19129 RVA: 0x000AAB47 File Offset: 0x000A8D47
		internal bool 9(1445 1)
		{
			return 1.14 == 1456.Scale;
		}

		// Token: 0x06004ABA RID: 19130 RVA: 0x000DD489 File Offset: 0x000DB689
		internal bool 10(1445 1)
		{
			return 1.14 == 1456.Rotation;
		}

		// Token: 0x040037B1 RID: 14257
		public static readonly 1371.1372 drawableCallbacks = new 1371.1372();

		// Token: 0x040037B2 RID: 14258
		public static Predicate<1445> predicate;

		// Token: 0x040037B3 RID: 14259
		public static Predicate<1445> predicate2;

		// Token: 0x040037B4 RID: 14260
		public static Predicate<1445> predicate3;

		// Token: 0x040037B5 RID: 14261
		public static Predicate<1445> predicate4;

		// Token: 0x040037B6 RID: 14262
		public static Predicate<1445> predicate5;

		// Token: 0x040037B7 RID: 14263
		public static Predicate<1445> predicate6;

		// Token: 0x040037B8 RID: 14264
		public static Predicate<1445> predicate7;

		// Token: 0x040037B9 RID: 14265
		public static Predicate<1445> predicate8;

		// Token: 0x040037BA RID: 14266
		public static Predicate<1445> predicate9;

		// Token: 0x040037BB RID: 14267
		public static Predicate<1445> predicate10;

		// Token: 0x040037BC RID: 14268
		public static Predicate<1445> predicate11;

		// Token: 0x040037BD RID: 14269
		public static Predicate<1445> predicate12;

		// Token: 0x040037BE RID: 14270
		public static Predicate<1445> predicate13;

		// Token: 0x040037BF RID: 14271
		public static Predicate<1445> predicate14;
	}
}
