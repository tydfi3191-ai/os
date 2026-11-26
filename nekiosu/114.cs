using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;

// Token: 0x020000B1 RID: 177
[ComVisible(false)]
[242(1)]
[241(0)]
public static class 114
{
	// Token: 0x06000473 RID: 1139 RVA: 0x0000D98A File Offset: 0x0000BB8A
	public static 411<226> Ancestors<[241(0)] T>(this IEnumerable<T> 1) where T : 226
	{
		756.Method12216(1, "source");
		return 1.SelectMany(new Func<T, IEnumerable<226>>(114.118<T>._recoveredType10234577.Method5737)).Method5764();
	}

	// Token: 0x06000474 RID: 1140 RVA: 0x0000D9B2 File Offset: 0x0000BBB2
	public static 411<226> AncestorsAndSelf<[241(0)] T>(this IEnumerable<T> 1) where T : 226
	{
		756.Method12216(2, "source");
		return 2.SelectMany((T 1) => 1.AncestorsAndSelf()).Method5764();
	}

	// Token: 0x06000475 RID: 1141 RVA: 0x0000D9E9 File Offset: 0x0000BBE9
	public static 411<226> Method5750<[241(0)] T>(this IEnumerable<T> 1) where T : 111
	{
		756.Method12216(1, "source");
		return 1.SelectMany(new Func<T, IEnumerable<226>>(114.122<T>._recoveredType10274589.Method5747)).Method5764();
	}

	// Token: 0x06000476 RID: 1142 RVA: 0x0000DA11 File Offset: 0x0000BC11
	public static 411<226> Method5751<[241(0)] T>(this IEnumerable<T> 1) where T : 111
	{
		756.Method12216(1, "source");
		return 1.SelectMany(new Func<T, IEnumerable<226>>(114.120<T>._recoveredType10254585.Method5745)).Method5764();
	}

	// Token: 0x06000477 RID: 1143 RVA: 0x0000DA39 File Offset: 0x0000BC39
	public static 411<222> Properties(this IEnumerable<217> 1)
	{
		756.Method12216(2, "source");
		return 2.SelectMany((217 1) => 1.Properties()).Method5764<222>();
	}

	// Token: 0x06000478 RID: 1144 RVA: 0x0000DA70 File Offset: 0x0000BC70
	public static 411<226> Method5753(this IEnumerable<226> 1, [241(2)] object 2)
	{
		return 1.Method5753(2).Method5764();
	}

	// Token: 0x06000479 RID: 1145 RVA: 0x0000DA7E File Offset: 0x0000BC7E
	public static 411<226> Method5753(this IEnumerable<226> 1)
	{
		return 1.Method5753(null);
	}

	// Token: 0x0600047A RID: 1146 RVA: 0x0000DA87 File Offset: 0x0000BC87
	[return: 241(new byte[]
	{
		1,
		2
	})]
	public static IEnumerable<U> Method5753<[241(2)] U>(this IEnumerable<226> 1, object 2)
	{
		return 1.Method5753(2);
	}

	// Token: 0x0600047B RID: 1147 RVA: 0x0000DA90 File Offset: 0x0000BC90
	[return: 241(new byte[]
	{
		1,
		2
	})]
	public static IEnumerable<U> Method5753<[241(2)] U>(this IEnumerable<226> 1)
	{
		return 1.Method5753(null);
	}

	// Token: 0x0600047C RID: 1148 RVA: 0x0000DA99 File Offset: 0x0000BC99
	[242(2)]
	public static U Method5757<U>([241(1)] this IEnumerable<226> 1)
	{
		return 1.Method5757<226, U>();
	}

	// Token: 0x0600047D RID: 1149 RVA: 0x0000DAA1 File Offset: 0x0000BCA1
	[return: 241(2)]
	public static U Method5757<[241(0)] T, [241(2)] U>(this IEnumerable<T> 1) where T : 226
	{
		756.Method12216(1, "value");
		226 2 = 1 as 226;
		if (2 == null)
		{
			throw new ArgumentException("Source value must be a JToken.");
		}
		return 2.Method5762<226, U>();
	}

	// Token: 0x0600047E RID: 1150 RVA: 0x0000DAC8 File Offset: 0x0000BCC8
	[return: 241(new byte[]
	{
		1,
		2
	})]
	internal static IEnumerable<U> Method5753<[241(0)] T, [241(2)] U>(this IEnumerable<T> 1, [241(2)] object 2) where T : 226
	{
		return new 114.117<T, U>(-2)
		{
			_iEnumerable4572 = 1,
			_value4574 = 2
		};
	}

	// Token: 0x0600047F RID: 1151 RVA: 0x0000DADF File Offset: 0x0000BCDF
	public static 411<226> Method5760<[241(0)] T>(this IEnumerable<T> 1) where T : 226
	{
		return 1.Method5760<T, 226>().Method5764();
	}

	// Token: 0x06000480 RID: 1152 RVA: 0x0000DAEC File Offset: 0x0000BCEC
	[return: 241(new byte[]
	{
		1,
		2
	})]
	public static IEnumerable<U> Method5760<[241(0)] T, [241(2)] U>(this IEnumerable<T> 1) where T : 226
	{
		756.Method12216(2, "source");
		return 2.SelectMany((T 1) => 1.Children()).Method5762<226, U>();
	}

	// Token: 0x06000481 RID: 1153 RVA: 0x0000DB23 File Offset: 0x0000BD23
	[return: 241(new byte[]
	{
		1,
		2
	})]
	internal static IEnumerable<U> Method5762<[241(0)] T, [241(2)] U>(this IEnumerable<T> 1) where T : 226
	{
		return new 114.119<T, U>(-2)
		{
			_iEnumerable4583 = 1
		};
	}

	// Token: 0x06000482 RID: 1154 RVA: 0x0000DB34 File Offset: 0x0000BD34
	[242(2)]
	internal static U Method5762<[241(0)] T, U>([241(1)] this T 1) where T : 226
	{
		if (1 == null)
		{
			return default(U);
		}
		if (1 is U)
		{
			U result = 1 as U;
			if (typeof(U) != typeof(IComparable) && typeof(U) != typeof(IFormattable))
			{
				return result;
			}
		}
		233 2 = 1 as 233;
		if (2 == null)
		{
			throw new InvalidCastException("Cannot cast {0} to {1}.".Method6825(CultureInfo.InvariantCulture, 1.GetType(), typeof(T)));
		}
		object value = 2.Value;
		if (value is U)
		{
			return (U)((object)value);
		}
		Type type = typeof(U);
		if (143.IsNullableType(type))
		{
			if (2.Value == null)
			{
				return default(U);
			}
			type = Nullable.GetUnderlyingType(type);
		}
		return (U)((object)Convert.ChangeType(2.Value, type, CultureInfo.InvariantCulture));
	}

	// Token: 0x06000483 RID: 1155 RVA: 0x0000DC3E File Offset: 0x0000BE3E
	public static 411<226> Method5764(this IEnumerable<226> 1)
	{
		return 1.Method5764<226>();
	}

	// Token: 0x06000484 RID: 1156 RVA: 0x0000DC48 File Offset: 0x0000BE48
	public static 411<T> Method5764<[241(0)] T>(this IEnumerable<T> 1) where T : 226
	{
		if (1 == null)
		{
			return null;
		}
		411<T> 2 = 1 as 411<T>;
		if (2 != null)
		{
			return 2;
		}
		return new 787<T>(1);
	}

	// Token: 0x020000B2 RID: 178
	[Serializable]
	public sealed class 115
	{
		// Token: 0x06000485 RID: 1157 RVA: 0x0000DC71 File Offset: 0x0000BE71
		[242(0)]
		internal IEnumerable<222> Method5726(217 1)
		{
			return 1.Properties();
		}

		// Token: 0x040003C2 RID: 962
		[241(0)]
		public static readonly 114.115 instance = new 114.115();

		// Token: 0x040003C3 RID: 963
		[241(0)]
		public static Func<217, IEnumerable<222>> func;
	}

	// Token: 0x020000B3 RID: 179
	[Serializable]
	public sealed class 116<TItem> where TItem : 226
	{
		// Token: 0x06000488 RID: 1160 RVA: 0x0000DC85 File Offset: 0x0000BE85
		[242(0)]
		internal IEnumerable<226> Method5727(TItem 1)
		{
			return 1.AncestorsAndSelf();
		}

		// Token: 0x040003C4 RID: 964
		[241(0)]
		public static readonly 114.116<TItem> _recoveredType10214566 = new 114.116<TItem>();

		// Token: 0x040003C5 RID: 965
		[241(0)]
		public static Func<TItem, IEnumerable<226>> _func4567;
	}

	// Token: 0x020000B4 RID: 180
	public sealed class 117<TItem, TItem2> : IEnumerable<!1>, IEnumerable, IEnumerator<!1>, IDisposable, IEnumerator where TItem : 226
	{
		// Token: 0x0600048B RID: 1163 RVA: 0x0000DC9E File Offset: 0x0000BE9E
		[DebuggerHidden]
		public 117(int 1)
		{
			this._number4568 = 1;
			this._number4570 = Thread.CurrentThread.ManagedThreadId;
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x0000DCC0 File Offset: 0x0000BEC0
		[DebuggerHidden]
		private void Method5728()
		{
			int number = this._number4568;
			switch (number)
			{
			case -5:
			case 3:
				break;
			case -4:
			case -3:
			case 1:
			case 2:
				try
				{
					if (number != -4 && number != 2)
					{
						return;
					}
					try
					{
						return;
					}
					finally
					{
						this.Method5730();
					}
				}
				finally
				{
					this.Method5729();
				}
				break;
			case -2:
			case -1:
			case 0:
				return;
			default:
				return;
			}
			try
			{
			}
			finally
			{
				this.Method5731();
			}
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x0000DD54 File Offset: 0x0000BF54
		void IDisposable.Dispose()
		{
			this.Method5728();
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x0000DD5C File Offset: 0x0000BF5C
		private bool MoveNext()
		{
			bool result;
			try
			{
				switch (this._number4568)
				{
				case 0:
					this._number4568 = -1;
					756.Method12216(this._iEnumerable4571, "source");
					if (this._value4573 == null)
					{
						this._iEnumerator4575 = this._iEnumerable4571.GetEnumerator();
						this._number4568 = -3;
						goto IL_A0;
					}
					this._iEnumerator4575 = this._iEnumerable4571.GetEnumerator();
					this._number4568 = -5;
					break;
				case 1:
					this._number4568 = -3;
					goto IL_A0;
				case 2:
					this._number4568 = -4;
					goto IL_118;
				case 3:
					this._number4568 = -5;
					break;
				default:
					return false;
				}
				while (this._iEnumerator4575.MoveNext())
				{
					226 <<EMPTY_NAME>> = this._iEnumerator4575.Current[this._value4573];
					if (<<EMPTY_NAME>> != null)
					{
						this._item4569 = <<EMPTY_NAME>>.Method5762<226, TItem2>();
						this._number4568 = 3;
						return true;
					}
				}
				this.Method5731();
				this._iEnumerator4575 = null;
				goto IL_1AF;
				IL_A0:
				if (!this._iEnumerator4575.MoveNext())
				{
					this.Method5729();
					this._iEnumerator4575 = null;
					goto IL_1AF;
				}
				TItem titem = this._iEnumerator4575.Current;
				233 2 = titem as 233;
				if (2 != null)
				{
					this._item4569 = 2.Method5762<233, TItem2>();
					this._number4568 = 1;
					return true;
				}
				this._iEnumerator4576 = titem.Children().GetEnumerator();
				this._number4568 = -4;
				IL_118:
				if (this._iEnumerator4576.MoveNext())
				{
					226 3 = this._iEnumerator4576.Current;
					this._item4569 = 3.Method5762<226, TItem2>();
					this._number4568 = 2;
					return true;
				}
				this.Method5730();
				this._iEnumerator4576 = null;
				goto IL_A0;
				IL_1AF:
				result = false;
			}
			catch
			{
				this.Method5728();
				throw;
			}
			return result;
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x0000DF44 File Offset: 0x0000C144
		bool IEnumerator.MoveNext()
		{
			return this.MoveNext();
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x0000DF4C File Offset: 0x0000C14C
		private void Method5729()
		{
			this._number4568 = -1;
			if (this._iEnumerator4575 != null)
			{
				this._iEnumerator4575.Dispose();
			}
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x0000DF68 File Offset: 0x0000C168
		private void Method5730()
		{
			this._number4568 = -3;
			if (this._iEnumerator4576 != null)
			{
				this._iEnumerator4576.Dispose();
			}
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x0000DF4C File Offset: 0x0000C14C
		private void Method5731()
		{
			this._number4568 = -1;
			if (this._iEnumerator4575 != null)
			{
				this._iEnumerator4575.Dispose();
			}
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x0000DF85 File Offset: 0x0000C185
		[DebuggerHidden]
		[return: 241(2)]
		private TItem2 GetItem4569_5732()
		{
			return this._item4569;
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000494 RID: 1172 RVA: 0x0000DF8D File Offset: 0x0000C18D
		TItem2 IEnumerator<!1>.Current
		{
			get
			{
				return this.GetItem4569_5732();
			}
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x00005BE8 File Offset: 0x00003DE8
		[DebuggerHidden]
		private void Method5733()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x0000DF95 File Offset: 0x0000C195
		void IEnumerator.Reset()
		{
			this.Method5733();
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x0000DF9D File Offset: 0x0000C19D
		[DebuggerHidden]
		[return: 241(0)]
		private object GetItem4569_5734()
		{
			return this._item4569;
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000498 RID: 1176 RVA: 0x0000DFAA File Offset: 0x0000C1AA
		object IEnumerator.Current
		{
			get
			{
				return this.GetItem4569_5734();
			}
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x0000DFB4 File Offset: 0x0000C1B4
		[DebuggerHidden]
		[return: 241(0)]
		private IEnumerator<TItem2> Method5735()
		{
			114.117<TItem, TItem2> <<EMPTY_NAME>>;
			if (this._number4568 == -2 && this._number4570 == Thread.CurrentThread.ManagedThreadId)
			{
				this._number4568 = 0;
				<<EMPTY_NAME>> = this;
			}
			else
			{
				<<EMPTY_NAME>> = new 114.117<TItem, TItem2>(0);
			}
			<<EMPTY_NAME>>._iEnumerable4571 = this._iEnumerable4572;
			<<EMPTY_NAME>>._value4573 = this._value4574;
			return <<EMPTY_NAME>>;
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x0000E008 File Offset: 0x0000C208
		IEnumerator<TItem2> IEnumerable<!1>.GetEnumerator()
		{
			return this.Method5735();
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x0000E008 File Offset: 0x0000C208
		[DebuggerHidden]
		[return: 241(0)]
		private IEnumerator Method5736()
		{
			return this.Method5735();
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x0000E010 File Offset: 0x0000C210
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.Method5736();
		}

		// Token: 0x040003C6 RID: 966
		private int _number4568;

		// Token: 0x040003C7 RID: 967
		[241(2)]
		private TItem2 _item4569;

		// Token: 0x040003C8 RID: 968
		private int _number4570;

		// Token: 0x040003C9 RID: 969
		[241(new byte[]
		{
			0,
			1
		})]
		private IEnumerable<TItem> _iEnumerable4571;

		// Token: 0x040003CA RID: 970
		[241(new byte[]
		{
			0,
			1
		})]
		public IEnumerable<TItem> _iEnumerable4572;

		// Token: 0x040003CB RID: 971
		[241(0)]
		private object _value4573;

		// Token: 0x040003CC RID: 972
		[241(0)]
		public object _value4574;

		// Token: 0x040003CD RID: 973
		[241(new byte[]
		{
			0,
			1
		})]
		private IEnumerator<TItem> _iEnumerator4575;

		// Token: 0x040003CE RID: 974
		[241(new byte[]
		{
			0,
			1
		})]
		private IEnumerator<226> _iEnumerator4576;
	}

	// Token: 0x020000B5 RID: 181
	[Serializable]
	public sealed class 118<TItem> where TItem : 226
	{
		// Token: 0x0600049D RID: 1181 RVA: 0x0000E018 File Offset: 0x0000C218
		[242(0)]
		internal IEnumerable<226> Method5737(TItem 1)
		{
			return 1.Ancestors();
		}

		// Token: 0x040003CF RID: 975
		[241(0)]
		public static readonly 114.118<TItem> _recoveredType10234577 = new 114.118<TItem>();

		// Token: 0x040003D0 RID: 976
		[241(0)]
		public static Func<TItem, IEnumerable<226>> _func4578;
	}

	// Token: 0x020000B6 RID: 182
	public sealed class 119<TItem, TItem2> : IEnumerable<!1>, IEnumerable, IEnumerator<!1>, IDisposable, IEnumerator where TItem : 226
	{
		// Token: 0x060004A0 RID: 1184 RVA: 0x0000E031 File Offset: 0x0000C231
		[DebuggerHidden]
		public 119(int 1)
		{
			this._number4579 = 1;
			this._number4581 = Thread.CurrentThread.ManagedThreadId;
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x0000E050 File Offset: 0x0000C250
		[DebuggerHidden]
		private void Method5738()
		{
			int number = this._number4579;
			if (number == -3 || number == 1)
			{
				try
				{
				}
				finally
				{
					this.Method5739();
				}
			}
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x0000E088 File Offset: 0x0000C288
		void IDisposable.Dispose()
		{
			this.Method5738();
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x0000E090 File Offset: 0x0000C290
		private bool MoveNext()
		{
			bool result;
			try
			{
				int number = this._number4579;
				if (number != 0)
				{
					if (number != 1)
					{
						return false;
					}
					this._number4579 = -3;
				}
				else
				{
					this._number4579 = -1;
					756.Method12216(this._iEnumerable4582, "source");
					this._iEnumerator4584 = this._iEnumerable4582.GetEnumerator();
					this._number4579 = -3;
				}
				if (this._iEnumerator4584.MoveNext())
				{
					TItem titem = this._iEnumerator4584.Current;
					this._item4580 = titem.Method5762<226, TItem2>();
					this._number4579 = 1;
					result = true;
				}
				else
				{
					this.Method5739();
					this._iEnumerator4584 = null;
					result = false;
				}
			}
			catch
			{
				this.Method5738();
				throw;
			}
			return result;
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x0000E14C File Offset: 0x0000C34C
		bool IEnumerator.MoveNext()
		{
			return this.MoveNext();
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x0000E154 File Offset: 0x0000C354
		private void Method5739()
		{
			this._number4579 = -1;
			if (this._iEnumerator4584 != null)
			{
				this._iEnumerator4584.Dispose();
			}
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x0000E170 File Offset: 0x0000C370
		[DebuggerHidden]
		[return: 241(2)]
		private TItem2 GetItem4580_5740()
		{
			return this._item4580;
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060004A7 RID: 1191 RVA: 0x0000E178 File Offset: 0x0000C378
		TItem2 IEnumerator<!1>.Current
		{
			get
			{
				return this.GetItem4580_5740();
			}
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x00005BE8 File Offset: 0x00003DE8
		[DebuggerHidden]
		private void Method5741()
		{
			throw new NotSupportedException();
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x0000E180 File Offset: 0x0000C380
		void IEnumerator.Reset()
		{
			this.Method5741();
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x0000E188 File Offset: 0x0000C388
		[DebuggerHidden]
		[return: 241(0)]
		private object GetItem4580_5742()
		{
			return this._item4580;
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060004AB RID: 1195 RVA: 0x0000E195 File Offset: 0x0000C395
		object IEnumerator.Current
		{
			get
			{
				return this.GetItem4580_5742();
			}
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x0000E1A0 File Offset: 0x0000C3A0
		[DebuggerHidden]
		[return: 241(0)]
		private IEnumerator<TItem2> Method5743()
		{
			114.119<TItem, TItem2> <<EMPTY_NAME>>;
			if (this._number4579 == -2 && this._number4581 == Thread.CurrentThread.ManagedThreadId)
			{
				this._number4579 = 0;
				<<EMPTY_NAME>> = this;
			}
			else
			{
				<<EMPTY_NAME>> = new 114.119<TItem, TItem2>(0);
			}
			<<EMPTY_NAME>>._iEnumerable4582 = this._iEnumerable4583;
			return <<EMPTY_NAME>>;
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x0000E1E8 File Offset: 0x0000C3E8
		IEnumerator<TItem2> IEnumerable<!1>.GetEnumerator()
		{
			return this.Method5743();
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x0000E1E8 File Offset: 0x0000C3E8
		[DebuggerHidden]
		[return: 241(0)]
		private IEnumerator Method5744()
		{
			return this.Method5743();
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x0000E1F0 File Offset: 0x0000C3F0
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.Method5744();
		}

		// Token: 0x040003D1 RID: 977
		private int _number4579;

		// Token: 0x040003D2 RID: 978
		[241(2)]
		private TItem2 _item4580;

		// Token: 0x040003D3 RID: 979
		private int _number4581;

		// Token: 0x040003D4 RID: 980
		[241(new byte[]
		{
			0,
			1
		})]
		private IEnumerable<TItem> _iEnumerable4582;

		// Token: 0x040003D5 RID: 981
		[241(new byte[]
		{
			0,
			1
		})]
		public IEnumerable<TItem> _iEnumerable4583;

		// Token: 0x040003D6 RID: 982
		[241(new byte[]
		{
			0,
			1
		})]
		private IEnumerator<TItem> _iEnumerator4584;
	}

	// Token: 0x020000B7 RID: 183
	[Serializable]
	public sealed class 120<TItem> where TItem : 111
	{
		// Token: 0x060004B0 RID: 1200 RVA: 0x0000E1F8 File Offset: 0x0000C3F8
		[242(0)]
		internal IEnumerable<226> Method5745(TItem 1)
		{
			return 1.Method7240();
		}

		// Token: 0x040003D7 RID: 983
		[241(0)]
		public static readonly 114.120<TItem> _recoveredType10254585 = new 114.120<TItem>();

		// Token: 0x040003D8 RID: 984
		[241(0)]
		public static Func<TItem, IEnumerable<226>> _func4586;
	}

	// Token: 0x020000B8 RID: 184
	[Serializable]
	public sealed class 121<TItem, TItem2> where TItem : 226
	{
		// Token: 0x060004B3 RID: 1203 RVA: 0x0000E211 File Offset: 0x0000C411
		[242(0)]
		internal IEnumerable<226> Method5746(TItem 1)
		{
			return 1.Children();
		}

		// Token: 0x040003D9 RID: 985
		[241(0)]
		public static readonly 114.121<TItem, TItem2> _recoveredType10264587 = new 114.121<TItem, TItem2>();

		// Token: 0x040003DA RID: 986
		[241(0)]
		public static Func<TItem, IEnumerable<226>> _func4588;
	}

	// Token: 0x020000B9 RID: 185
	[Serializable]
	public sealed class 122<TItem> where TItem : 111
	{
		// Token: 0x060004B6 RID: 1206 RVA: 0x0000E22F File Offset: 0x0000C42F
		[242(0)]
		internal IEnumerable<226> Method5747(TItem 1)
		{
			return 1.Method7239();
		}

		// Token: 0x040003DB RID: 987
		[241(0)]
		public static readonly 114.122<TItem> _recoveredType10274589 = new 114.122<TItem>();

		// Token: 0x040003DC RID: 988
		[241(0)]
		public static Func<TItem, IEnumerable<226>> _func4590;
	}
}
