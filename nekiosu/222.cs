using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;

// Token: 0x020003B6 RID: 950
[241(0)]
[242(1)]
[ComVisible(false)]
public class 222 : 111
{
	// Token: 0x170001F3 RID: 499
	// (get) Token: 0x06001D51 RID: 7505 RVA: 0x00073E81 File Offset: 0x00072081
	protected override IList<226> ChildrenTokens
	{
		get
		{
			return this._recoveredType253810857;
		}
	}

	// Token: 0x170001F4 RID: 500
	// (get) Token: 0x06001D52 RID: 7506 RVA: 0x00073E89 File Offset: 0x00072089
	public string Name
	{
		[DebuggerStepThrough]
		get
		{
			return this.text2;
		}
	}

	// Token: 0x170001F5 RID: 501
	// (get) Token: 0x06001D53 RID: 7507 RVA: 0x00073E91 File Offset: 0x00072091
	// (set) Token: 0x06001D54 RID: 7508 RVA: 0x00073EA0 File Offset: 0x000720A0
	public new 226 Value
	{
		[DebuggerStepThrough]
		get
		{
			return this._recoveredType253810857.jToken2;
		}
		set
		{
			base.Method7233();
			226 <<EMPTY_NAME>> = value ?? 233.CreateNull();
			if (this._recoveredType253810857.jToken2 == null)
			{
				this.Method14292(0, <<EMPTY_NAME>>, false, true);
				return;
			}
			this.Method14288(0, <<EMPTY_NAME>>);
		}
	}

	// Token: 0x170001F6 RID: 502
	// (get) Token: 0x06001D55 RID: 7509 RVA: 0x0000D019 File Offset: 0x0000B219
	public override 705 Type
	{
		[DebuggerStepThrough]
		get
		{
			return 705.Property;
		}
	}

	// Token: 0x06001D56 RID: 7510 RVA: 0x00073EDF File Offset: 0x000720DF
	public 222(222 1) : base(1, null)
	{
		this.text2 = 1.Name;
	}

	// Token: 0x06001D57 RID: 7511 RVA: 0x00073F00 File Offset: 0x00072100
	internal 222(222 1, [241(2)] 479 2) : base(1, 2)
	{
		this.text2 = 1.Name;
	}

	// Token: 0x06001D58 RID: 7512 RVA: 0x00073F21 File Offset: 0x00072121
	internal 222(string 1)
	{
		756.Method12216(1, "name");
		this.text2 = 1;
	}

	// Token: 0x06001D59 RID: 7513 RVA: 0x00073F46 File Offset: 0x00072146
	public 222(string 1, params object[] 2) : this(1, 2)
	{
	}

	// Token: 0x06001D5A RID: 7514 RVA: 0x00073F50 File Offset: 0x00072150
	public 222(string 1, [241(2)] object 2)
	{
		756.Method12216(1, "name");
		this.text2 = 1;
		this.Value = (base.Method7242(2) ? new 109(2) : 111.Method7261(2));
	}

	// Token: 0x06001D5B RID: 7515 RVA: 0x00073F9D File Offset: 0x0007219D
	internal override 226 Method14287(int 1)
	{
		if (1 != 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		return this.Value;
	}

	// Token: 0x06001D5C RID: 7516 RVA: 0x00073FB0 File Offset: 0x000721B0
	[242(2)]
	internal override void Method14288(int 1, 226 2)
	{
		if (1 != 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (!111.Method7254(this.Value, 2))
		{
			217 3 = (217)base.Parent;
			if (3 != null)
			{
				3.Method14260(this);
			}
			base.Method14288(0, 2);
			217 4 = (217)base.Parent;
			if (4 == null)
			{
				return;
			}
			4.Method14259(this);
		}
	}

	// Token: 0x06001D5D RID: 7517 RVA: 0x00074009 File Offset: 0x00072209
	[242(2)]
	internal override bool Method14289(226 1)
	{
		throw new 134("Cannot add or remove items from {0}.".Method6825(CultureInfo.InvariantCulture, typeof(222)));
	}

	// Token: 0x06001D5E RID: 7518 RVA: 0x00074009 File Offset: 0x00072209
	internal override void Method14290(int 1)
	{
		throw new 134("Cannot add or remove items from {0}.".Method6825(CultureInfo.InvariantCulture, typeof(222)));
	}

	// Token: 0x06001D5F RID: 7519 RVA: 0x00074029 File Offset: 0x00072229
	[242(2)]
	internal override int Method14291(226 1)
	{
		if (1 == null)
		{
			return -1;
		}
		return this._recoveredType253810857.IndexOf(1);
	}

	// Token: 0x06001D60 RID: 7520 RVA: 0x0007403C File Offset: 0x0007223C
	[242(2)]
	internal override bool Method14292(int 1, 226 2, bool 3, bool 4)
	{
		if (2 != null && 2.Type == 705.Comment)
		{
			return false;
		}
		if (this.Value != null)
		{
			throw new 134("{0} cannot have multiple values.".Method6825(CultureInfo.InvariantCulture, typeof(222)));
		}
		return base.Method14292(0, 2, false, 4);
	}

	// Token: 0x06001D61 RID: 7521 RVA: 0x00074089 File Offset: 0x00072289
	[242(2)]
	internal override bool Method14293(226 1)
	{
		return this.Value == 1;
	}

	// Token: 0x06001D62 RID: 7522 RVA: 0x00074094 File Offset: 0x00072294
	internal override void Method14294(object 1, [241(2)] 793 2)
	{
		222 3 = 1 as 222;
		226 4 = (3 != null) ? 3.Value : null;
		if (4 != null && 4.Type != 705.Null)
		{
			this.Value = 4;
		}
	}

	// Token: 0x06001D63 RID: 7523 RVA: 0x00074009 File Offset: 0x00072209
	internal override void Method14295()
	{
		throw new 134("Cannot add or remove items from {0}.".Method6825(CultureInfo.InvariantCulture, typeof(222)));
	}

	// Token: 0x06001D64 RID: 7524 RVA: 0x000740C8 File Offset: 0x000722C8
	internal override bool Method14356(226 1)
	{
		222 2 = 1 as 222;
		return 2 != null && this.text2 == 2.Name && base.Method7238(2);
	}

	// Token: 0x06001D65 RID: 7525 RVA: 0x000740FB File Offset: 0x000722FB
	internal override 226 Method14299([241(2)] 479 1)
	{
		return new 222(this, 1);
	}

	// Token: 0x06001D66 RID: 7526 RVA: 0x00074104 File Offset: 0x00072304
	public override void WriteTo(173 1, params 214[] 2)
	{
		1.WritePropertyName(this.text2);
		226 value = this.Value;
		if (value != null)
		{
			value.WriteTo(1, 2);
			return;
		}
		1.WriteNull();
	}

	// Token: 0x06001D67 RID: 7527 RVA: 0x00074136 File Offset: 0x00072336
	internal override int Method14364()
	{
		int hashCode = this.text2.GetHashCode();
		226 value = this.Value;
		return hashCode ^ ((value != null) ? value.Method14364() : 0);
	}

	// Token: 0x06001D68 RID: 7528 RVA: 0x00074156 File Offset: 0x00072356
	public new static 222 Load(139 1)
	{
		return 222.Load(1, null);
	}

	// Token: 0x06001D69 RID: 7529 RVA: 0x00074160 File Offset: 0x00072360
	public new static 222 Load(139 1, [241(2)] 554 2)
	{
		if (1.GetTokenType() == 216.None && !1.Read())
		{
			throw 141.Method12886(1, "Error reading JProperty from JsonReader.");
		}
		1.Method2847();
		if (1.GetTokenType() != 216.PropertyName)
		{
			throw 141.Method12886(1, "Error reading JProperty from JsonReader. Current JsonReader item is not a property: {0}".Method6825(CultureInfo.InvariantCulture, 1.GetTokenType()));
		}
		222 3 = new 222((string)1.GetValue());
		3.Method14343(1 as 99, 2);
		3.Method7269(1, 2);
		return 3;
	}

	// Token: 0x04000EA3 RID: 3747
	private readonly 222.223 _recoveredType253810857 = new 222.223();

	// Token: 0x04000EA4 RID: 3748
	private readonly string text2;

	// Token: 0x020003B7 RID: 951
	[241(0)]
	public sealed class 223 : IList<226>, ICollection<226>, IEnumerable<226>, IEnumerable
	{
		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06001D6A RID: 7530 RVA: 0x000741DF File Offset: 0x000723DF
		public int Count
		{
			get
			{
				if (this.jToken2 == null)
				{
					return 0;
				}
				return 1;
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06001D6B RID: 7531 RVA: 0x0000FF75 File Offset: 0x0000E175
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170001F9 RID: 505
		public 226 this[int 1]
		{
			get
			{
				if (1 != 0)
				{
					throw new IndexOutOfRangeException();
				}
				return this.jToken2;
			}
			set
			{
				if (1 != 0)
				{
					throw new IndexOutOfRangeException();
				}
				this.jToken2 = value;
			}
		}

		// Token: 0x06001D6E RID: 7534 RVA: 0x0007420F File Offset: 0x0007240F
		public IEnumerator<226> GetEnumerator()
		{
			return new 222.223.224(0)
			{
				_recoveredType253810855 = this
			};
		}

		// Token: 0x06001D6F RID: 7535 RVA: 0x0007421E File Offset: 0x0007241E
		private IEnumerator Method14286()
		{
			return this.GetEnumerator();
		}

		// Token: 0x06001D70 RID: 7536 RVA: 0x00074226 File Offset: 0x00072426
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.Method14286();
		}

		// Token: 0x06001D71 RID: 7537 RVA: 0x0007422E File Offset: 0x0007242E
		public void Add(226 1)
		{
			this.jToken2 = 1;
		}

		// Token: 0x06001D72 RID: 7538 RVA: 0x00074237 File Offset: 0x00072437
		public void Clear()
		{
			this.jToken2 = null;
		}

		// Token: 0x06001D73 RID: 7539 RVA: 0x00074240 File Offset: 0x00072440
		public bool Contains(226 1)
		{
			return this.jToken2 == 1;
		}

		// Token: 0x06001D74 RID: 7540 RVA: 0x0007424B File Offset: 0x0007244B
		public void CopyTo(226[] 1, int 2)
		{
			if (this.jToken2 != null)
			{
				1[2] = this.jToken2;
			}
		}

		// Token: 0x06001D75 RID: 7541 RVA: 0x0007425E File Offset: 0x0007245E
		public bool Remove(226 1)
		{
			if (this.jToken2 == 1)
			{
				this.jToken2 = null;
				return true;
			}
			return false;
		}

		// Token: 0x06001D76 RID: 7542 RVA: 0x00074273 File Offset: 0x00072473
		public int IndexOf(226 1)
		{
			if (this.jToken2 != 1)
			{
				return -1;
			}
			return 0;
		}

		// Token: 0x06001D77 RID: 7543 RVA: 0x00074281 File Offset: 0x00072481
		public void Insert(int 1, 226 2)
		{
			if (1 == 0)
			{
				this.jToken2 = 2;
			}
		}

		// Token: 0x06001D78 RID: 7544 RVA: 0x0007428D File Offset: 0x0007248D
		public void RemoveAt(int 1)
		{
			if (1 == 0)
			{
				this.jToken2 = null;
			}
		}

		// Token: 0x04000EA5 RID: 3749
		[241(2)]
		internal 226 jToken2;

		// Token: 0x020003B8 RID: 952
		public sealed class 224 : IEnumerator<226>, IDisposable, IEnumerator
		{
			// Token: 0x06001D7A RID: 7546 RVA: 0x00074299 File Offset: 0x00072499
			[DebuggerHidden]
			public 224(int 1)
			{
				this.number2 = 1;
			}

			// Token: 0x06001D7B RID: 7547 RVA: 0x00005ADD File Offset: 0x00003CDD
			[DebuggerHidden]
			private void Method14282()
			{
			}

			// Token: 0x06001D7C RID: 7548 RVA: 0x000742A8 File Offset: 0x000724A8
			void IDisposable.Dispose()
			{
				this.Method14282();
			}

			// Token: 0x06001D7D RID: 7549 RVA: 0x000742B0 File Offset: 0x000724B0
			private bool MoveNext()
			{
				int num = this.number2;
				222.223 recoveredType = this._recoveredType253810855;
				if (num != 0)
				{
					if (num != 1)
					{
						return false;
					}
					this.number2 = -1;
				}
				else
				{
					this.number2 = -1;
					if (recoveredType.jToken2 != null)
					{
						this.jToken = recoveredType.jToken2;
						this.number2 = 1;
						return true;
					}
				}
				return false;
			}

			// Token: 0x06001D7E RID: 7550 RVA: 0x00074300 File Offset: 0x00072500
			bool IEnumerator.MoveNext()
			{
				return this.MoveNext();
			}

			// Token: 0x06001D7F RID: 7551 RVA: 0x00074308 File Offset: 0x00072508
			[DebuggerHidden]
			private 226 GetJToken10854_14283()
			{
				return this.jToken;
			}

			// Token: 0x170001FA RID: 506
			// (get) Token: 0x06001D80 RID: 7552 RVA: 0x00074310 File Offset: 0x00072510
			226 IEnumerator<226>.Current
			{
				get
				{
					return this.GetJToken10854_14283();
				}
			}

			// Token: 0x06001D81 RID: 7553 RVA: 0x00005BE8 File Offset: 0x00003DE8
			[DebuggerHidden]
			private void Method14284()
			{
				throw new NotSupportedException();
			}

			// Token: 0x06001D82 RID: 7554 RVA: 0x00074318 File Offset: 0x00072518
			void IEnumerator.Reset()
			{
				this.Method14284();
			}

			// Token: 0x06001D83 RID: 7555 RVA: 0x00074308 File Offset: 0x00072508
			[DebuggerHidden]
			[return: 241(0)]
			private object GetJToken10854_14285()
			{
				return this.jToken;
			}

			// Token: 0x170001FB RID: 507
			// (get) Token: 0x06001D84 RID: 7556 RVA: 0x00074320 File Offset: 0x00072520
			object IEnumerator.Current
			{
				get
				{
					return this.GetJToken10854_14285();
				}
			}

			// Token: 0x04000EA6 RID: 3750
			private int number2;

			// Token: 0x04000EA7 RID: 3751
			private 226 jToken;

			// Token: 0x04000EA8 RID: 3752
			[241(0)]
			public 222.223 _recoveredType253810855;
		}
	}
}
