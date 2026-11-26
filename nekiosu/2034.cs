using System;
using System.Collections.Generic;
using System.Threading;

// Token: 0x020007FD RID: 2045
[276]
public abstract class 2034 : 2036, IDisposable, IComparable<2034>, IComparable<int>
{
	// Token: 0x170002A8 RID: 680
	// (get) Token: 0x06003B29 RID: 15145 RVA: 0x001752D4 File Offset: 0x001734D4
	internal double DifficultyStartTime
	{
		get
		{
			double? num = this.25;
			if (num == null)
			{
				return (double)this.1;
			}
			return num.GetValueOrDefault();
		}
	}

	// Token: 0x06003B2A RID: 15146 RVA: 0x00175300 File Offset: 0x00173500
	protected 2034(2039 1)
	{
		this.28 = 1;
	}

	// Token: 0x06003B2B RID: 15147 RVA: 0x0017534E File Offset: 0x0017354E
	public new 208 1()
	{
		return this.GetEndPosition() - (this.8 - this.18);
	}

	// Token: 0x06003B2C RID: 15148 RVA: 0x0017536C File Offset: 0x0017356C
	internal new 208 2()
	{
		return this.GetCurrentPosition() - (this.8 - this.18);
	}

	// Token: 0x06003B2D RID: 15149 RVA: 0x0017538C File Offset: 0x0017358C
	~2034()
	{
		this.Dispose(false);
	}

	// Token: 0x06003B2E RID: 15150 RVA: 0x001753BC File Offset: 0x001735BC
	internal new bool 3()
	{
		return this.12;
	}

	// Token: 0x06003B2F RID: 15151 RVA: 0x001753C4 File Offset: 0x001735C4
	internal new void 4(bool 1)
	{
		if (this.12 != 1)
		{
			this.12 = 1;
			if (this.12)
			{
				this.OnSelected();
				return;
			}
			this.OnDeselected();
		}
	}

	// Token: 0x06003B30 RID: 15152 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal virtual void SetComboColour(198 1)
	{
	}

	// Token: 0x06003B31 RID: 15153 RVA: 0x001753EC File Offset: 0x001735EC
	internal virtual void ApplyComboColourFade()
	{
		if (1662.78 == 1677.Edit)
		{
			return;
		}
		198 <<EMPTY_NAME>> = new 198((byte)Math.Max(0f, (float)this.7.R * 0.75f), (byte)Math.Max(0f, (float)this.7.G * 0.75f), (byte)Math.Max(0f, (float)this.7.B * 0.75f), byte.MaxValue);
		198 2 = new 198(195, 195, 195, byte.MaxValue);
		198 white = 198.White;
		foreach (1433 3 in this.29)
		{
			3.3.RemoveAll((1445 1) => 1.14 == 1456.Colour && 1.16 == 147);
			1445 4 = new 1445((3.9 == 0) ? 2 : <<EMPTY_NAME>>, (3.9 == 0) ? white : this.7, this.1 - 400, this.1 - 300);
			if (4 != null)
			{
				4.16 = 147;
			}
			3.3.Add(4);
		}
	}

	// Token: 0x06003B32 RID: 15154
	internal abstract 2149 GetOrCalculateJudgement();

	// Token: 0x06003B33 RID: 15155 RVA: 0x00175554 File Offset: 0x00173754
	public void Dispose()
	{
		this.Dispose(true);
		GC.SuppressFinalize(this);
	}

	// Token: 0x06003B34 RID: 15156 RVA: 0x00005ADD File Offset: 0x00003CDD
	protected virtual void Dispose(bool 1)
	{
	}

	// Token: 0x06003B35 RID: 15157
	internal abstract 2034 Clone();

	// Token: 0x06003B36 RID: 15158
	internal abstract void OnSelected();

	// Token: 0x06003B37 RID: 15159
	internal abstract void OnDeselected();

	// Token: 0x06003B38 RID: 15160
	internal abstract void SetStartTime(int 1);

	// Token: 0x06003B39 RID: 15161 RVA: 0x00175563 File Offset: 0x00173763
	internal virtual void SetPosition(208 1, bool 2)
	{
		this.8 = 1;
		if (!2)
		{
			this.18 = 1;
			this.9 = 0;
		}
	}

	// Token: 0x06003B3A RID: 15162 RVA: 0x0017557D File Offset: 0x0017377D
	internal new void 5()
	{
		this.SetPosition(this.18, true);
		this.9 = 0;
	}

	// Token: 0x06003B3B RID: 15163 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal virtual void Update()
	{
	}

	// Token: 0x06003B3C RID: 15164 RVA: 0x00175593 File Offset: 0x00173793
	internal virtual void ResetJudgementState()
	{
		this.30.ForEach(new Action<1433>(2034.2035.Instance.1));
		this.11 = false;
	}

	// Token: 0x06003B3D RID: 15165 RVA: 0x001755B7 File Offset: 0x001737B7
	internal virtual void ApplyJudgementAnimation(bool 1)
	{
		this.30.ForEach(new Action<1433>(2034.2035.Instance.2));
	}

	// Token: 0x06003B3E RID: 15166 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal virtual void PrepareRendering()
	{
	}

	// Token: 0x06003B3F RID: 15167
	internal abstract bool IsActive();

	// Token: 0x06003B40 RID: 15168 RVA: 0x0013FA97 File Offset: 0x0013DC97
	internal virtual 208 GetCurrentPosition()
	{
		return this.8;
	}

	// Token: 0x06003B41 RID: 15169 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal virtual void SetCurrentPosition(208 1)
	{
	}

	// Token: 0x06003B42 RID: 15170 RVA: 0x001755D4 File Offset: 0x001737D4
	internal new void 6(string 1)
	{
		if (this.28.39 != null && !string.IsNullOrEmpty(1) && !1226.2)
		{
			this.33 = 1;
			bool 2 = false;
			if (base.HasObjectType(2047.Slider) && 1.IndexOf("slider") > 0 && 1.IndexOf("tick") == -1)
			{
				2 = true;
			}
			this.32 = 1226.49(1, 2, false, false);
			return;
		}
		this.32 = -1;
	}

	// Token: 0x06003B43 RID: 15171 RVA: 0x00175644 File Offset: 0x00173844
	internal new void 7(1259 1, 1245 2, 1254 3, 1254 4)
	{
		1254 5 = (3 == 1254.None) ? 1.4 : 3;
		1253 6 = (this.37 == 1253.Default) ? 1.2 : this.37;
		int num = (this.34 != 0) ? this.34 : 1.6;
		1244 7 = 1244.1(2, 5, 6, num, (5 == 1254.None) ? 5 : 4);
		2039.33(7);
		if (this.32 != -1)
		{
			1226.29(this.32, 1226.44(num), this.GetSamplePan(), true, 1f, true);
			return;
		}
		1226.30(7, this.GetSamplePan(), true);
	}

	// Token: 0x06003B44 RID: 15172 RVA: 0x001756DC File Offset: 0x001738DC
	internal virtual void PlayHitSound()
	{
		1259 <<EMPTY_NAME>> = this.28.21.92((double)(this.1 + 5));
		if (<<EMPTY_NAME>> != null)
		{
			this.7(<<EMPTY_NAME>>, this.4, this.35, this.36);
		}
	}

	// Token: 0x06003B45 RID: 15173 RVA: 0x00175720 File Offset: 0x00173920
	internal virtual List<1433> CreateLightingSprites()
	{
		List<1433> list = this.42;
		if (list != null)
		{
			list.ForEach(new Action<1433>(2034.2035.Instance.4));
		}
		List<1433> list2;
		if (this.29.Count <= 0)
		{
			list2 = new List<1433>();
		}
		else
		{
			(list2 = new List<1433>()).Add(this.29[0].Clone());
		}
		return this.42 = list2;
	}

	// Token: 0x06003B46 RID: 15174 RVA: 0x00175788 File Offset: 0x00173988
	protected virtual float GetSamplePan()
	{
		return (this.8.X / 512f - 0.5f) * 0.8f;
	}

	// Token: 0x06003B47 RID: 15175 RVA: 0x001757A7 File Offset: 0x001739A7
	internal virtual int _0003_2002_200A_2007_2007_2004_200A_2006_200A_2005_2005_2007_2009_2008_2002_2001_2005_2003_2001_200B()
	{
		return this.2;
	}

	// Token: 0x06003B48 RID: 15176 RVA: 0x001757AF File Offset: 0x001739AF
	internal virtual int _0005_200B_2002_2000_2005_200A_2005_2008_2004_2007_2005_2007_2006_2008_2007_2004_2001_2002_2007_2007_2007_2004_2002_2003_2009_2009_2001()
	{
		if (this._0003_2002_200A_2007_2007_2004_200A_2006_200A_2005_2005_2007_2009_2008_2002_2001_2005_2003_2001_200B() != -2147483648)
		{
			return this._0003_2002_200A_2007_2007_2004_200A_2006_200A_2005_2005_2007_2009_2008_2002_2001_2005_2003_2001_200B();
		}
		return this._000F_2007_2000_2004_200A_2000_2007_200B_2005_2005_2003_200A_200B_2008_2002_200B_2007_2009_2009_2000();
	}

	// Token: 0x06003B49 RID: 15177 RVA: 0x001757CB File Offset: 0x001739CB
	internal virtual int _000F_2007_2000_2004_200A_2000_2007_200B_2005_2005_2003_200A_200B_2008_2002_200B_2007_2009_2009_2000()
	{
		return this.1;
	}

	// Token: 0x06003B4A RID: 15178 RVA: 0x001757D3 File Offset: 0x001739D3
	internal virtual void SetHitSound(1245 1, bool 2, bool 3)
	{
		if (!3 || this.3())
		{
			if (1 == 1245.Whistle)
			{
				base.SetWhistle(2);
				return;
			}
			if (1 == 1245.Finish)
			{
				base.SetFinish(2);
				return;
			}
			if (1 != 1245.Clap)
			{
				return;
			}
			base.SetClap(2);
		}
	}

	// Token: 0x06003B4B RID: 15179 RVA: 0x00175804 File Offset: 0x00173A04
	public int CompareTo(2034 1)
	{
		if (this is 2071 || 1 is 2071)
		{
			return this.2.CompareTo(1.2);
		}
		if (this.1 == 1.1)
		{
			return 1.IsNewCombo().CompareTo(this.IsNewCombo());
		}
		return this.1.CompareTo(1.1);
	}

	// Token: 0x06003B4C RID: 15180
	internal abstract 2149 JudgeAtPosition(208 1);

	// Token: 0x06003B4D RID: 15181 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal virtual void StopHitSounds()
	{
	}

	// Token: 0x06003B4E RID: 15182
	internal abstract void SetEndTime(int 1);

	// Token: 0x06003B4F RID: 15183 RVA: 0x00175867 File Offset: 0x00173A67
	public int CompareTo(int 1)
	{
		return this.2.CompareTo(1);
	}

	// Token: 0x06003B50 RID: 15184 RVA: 0x00175878 File Offset: 0x00173A78
	internal virtual bool HitTest(208 1, bool 2, float 3)
	{
		return ((!2 && this.IsActive()) || (this.1 - this.28.2 <= 1226.16 && this.1 + this.28.3 >= 1226.16 && !this.11)) && (208.DistanceSquared(1, this.8) <= 3 * 3 || (!2 && 208.DistanceSquared(1, this.GetCurrentPosition()) <= 3 * 3));
	}

	// Token: 0x06003B51 RID: 15185 RVA: 0x001758F8 File Offset: 0x00173AF8
	internal virtual void Shake()
	{
		foreach (1433 <<EMPTY_NAME>> in this.30)
		{
			<<EMPTY_NAME>>.3.RemoveAll(new Predicate<1445>(this.8));
			208 currentPosition = this.GetCurrentPosition();
			<<EMPTY_NAME>>.3.Add(new 1445(currentPosition, currentPosition + new 208(8f, 0f), 1226.16, 1226.16 + 20, (1046)0)
			{
				16 = 123
			});
			<<EMPTY_NAME>>.3.Add(new 1445(currentPosition + new 208(8f, 0f), currentPosition - new 208(8f, 0f), 1226.16 + 20, 1226.16 + 40, (1046)0)
			{
				16 = 123
			});
			<<EMPTY_NAME>>.3.Add(new 1445(currentPosition - new 208(8f, 0f), currentPosition + new 208(8f, 0f), 1226.16 + 40, 1226.16 + 60, (1046)0)
			{
				16 = 123
			});
			<<EMPTY_NAME>>.3.Add(new 1445(currentPosition + new 208(8f, 0f), currentPosition - new 208(8f, 0f), 1226.16 + 60, 1226.16 + 80, (1046)0)
			{
				16 = 123
			});
			<<EMPTY_NAME>>.3.Add(new 1445(currentPosition + new 208(8f, 0f), currentPosition - new 208(8f, 0f), 1226.16 + 80, 1226.16 + 100, (1046)0)
			{
				16 = 123
			});
			<<EMPTY_NAME>>.3.Add(new 1445(currentPosition + new 208(8f, 0f), currentPosition, 1226.16 + 100, 1226.16 + 120, (1046)0)
			{
				16 = 123
			});
		}
	}

	// Token: 0x06003B52 RID: 15186 RVA: 0x00175B3C File Offset: 0x00173D3C
	protected virtual int GetPreemptTime()
	{
		return this.28.2;
	}

	// Token: 0x06003B53 RID: 15187 RVA: 0x00175B49 File Offset: 0x00173D49
	private new bool 8(1445 1)
	{
		return 1.14 == 1456.Movement && this.40 == 123;
	}

	// Token: 0x04002BC4 RID: 11204
	internal bool 11;

	// Token: 0x04002BC5 RID: 11205
	private bool 12;

	// Token: 0x04002BC6 RID: 11206
	internal double 13;

	// Token: 0x04002BC7 RID: 11207
	internal 2149 14;

	// Token: 0x04002BC8 RID: 11208
	internal bool 15;

	// Token: 0x04002BC9 RID: 11209
	internal int 16;

	// Token: 0x04002BCA RID: 11210
	internal int 17;

	// Token: 0x04002BCB RID: 11211
	public 208 18;

	// Token: 0x04002BCC RID: 11212
	internal int 19;

	// Token: 0x04002BCD RID: 11213
	internal bool 20;

	// Token: 0x04002BCE RID: 11214
	internal string 21;

	// Token: 0x04002BCF RID: 11215
	internal int 22;

	// Token: 0x04002BD0 RID: 11216
	internal int 23;

	// Token: 0x04002BD1 RID: 11217
	internal double 24;

	// Token: 0x04002BD2 RID: 11218
	internal double? 25;

	// Token: 0x04002BD3 RID: 11219
	private static int 26;

	// Token: 0x04002BD4 RID: 11220
	internal readonly int 27 = Interlocked.Increment(ref 2034.26);

	// Token: 0x04002BD5 RID: 11221
	internal 2039 28;

	// Token: 0x04002BD6 RID: 11222
	protected internal List<1433> 29 = new List<1433>();

	// Token: 0x04002BD7 RID: 11223
	internal List<1433> 30 = new List<1433>();

	// Token: 0x04002BD8 RID: 11224
	internal bool 31;

	// Token: 0x04002BD9 RID: 11225
	internal int 32 = -1;

	// Token: 0x04002BDA RID: 11226
	internal string 33;

	// Token: 0x04002BDB RID: 11227
	internal int 34;

	// Token: 0x04002BDC RID: 11228
	internal 1254 35;

	// Token: 0x04002BDD RID: 11229
	internal 1254 36;

	// Token: 0x04002BDE RID: 11230
	internal 1253 37;

	// Token: 0x04002BDF RID: 11231
	internal bool 38;

	// Token: 0x04002BE0 RID: 11232
	public bool 39 = true;

	// Token: 0x04002BE1 RID: 11233
	public int 40;

	// Token: 0x04002BE2 RID: 11234
	public int 41;

	// Token: 0x04002BE3 RID: 11235
	protected List<1433> 42;

	// Token: 0x020007FE RID: 2046
	[276]
	[Serializable]
	public sealed class 2035
	{
		// Token: 0x06003B54 RID: 15188 RVA: 0x00175B60 File Offset: 0x00173D60
		internal void 1(1433 1)
		{
			2.3.RemoveAll((1445 1) => 1.16 == 148);
		}

		// Token: 0x06003B55 RID: 15189 RVA: 0x00175B8D File Offset: 0x00173D8D
		internal void 2(1433 1)
		{
			1.3.RemoveAll(new Predicate<1445>(2034.2035.Instance.3));
		}

		// Token: 0x06003B56 RID: 15190 RVA: 0x00085465 File Offset: 0x00083665
		internal bool 3(1445 1)
		{
			return 1.16 == 148;
		}

		// Token: 0x06003B57 RID: 15191 RVA: 0x001409F8 File Offset: 0x0013EBF8
		internal void 4(1433 1)
		{
			1.13();
		}

		// Token: 0x04002BE4 RID: 11236
		public static readonly 2034.2035 Instance = new 2034.2035();

		// Token: 0x04002BE5 RID: 11237
		public static Predicate<1445> predicate;

		// Token: 0x04002BE6 RID: 11238
		public static Predicate<1445> predicate2;

		// Token: 0x04002BE7 RID: 11239
		public static Action<1433> action;

		// Token: 0x04002BE8 RID: 11240
		public static Predicate<1445> predicate3;

		// Token: 0x04002BE9 RID: 11241
		public static Action<1433> action2;

		// Token: 0x04002BEA RID: 11242
		public static Action<1433> action3;
	}
}
