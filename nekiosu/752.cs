using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Threading;

// Token: 0x020001BB RID: 443
public sealed class 752 : 368
{
	// Token: 0x06000E2B RID: 3627 RVA: 0x000302F8 File Offset: 0x0002E4F8
	public int? GetNullable9513_12176()
	{
		return this.nullable2;
	}

	// Token: 0x06000E2C RID: 3628 RVA: 0x00030300 File Offset: 0x0002E500
	public void SetNullable9513_12177(int? 1)
	{
		this.nullable2 = 1;
	}

	// Token: 0x06000E2D RID: 3629 RVA: 0x00030309 File Offset: 0x0002E509
	[242(1)]
	public override IEnumerable<226> Method12761(226 1, IEnumerable<226> 2, [241(2)] 541 3)
	{
		return new 752.753(-2)
		{
			_recoveredType21959508 = this,
			iEnumerable2 = 2,
			_recoveredType12049510 = 3
		};
	}

	// Token: 0x040006EE RID: 1774
	private int? nullable2;

	// Token: 0x020001BC RID: 444
	public sealed class 753 : IEnumerable<226>, IEnumerable, IEnumerator<226>, IDisposable, IEnumerator
	{
		// Token: 0x06000E2F RID: 3631 RVA: 0x00030327 File Offset: 0x0002E527
		[DebuggerHidden]
		public 753(int 1)
		{
			this.number2 = 1;
			this.number3 = Thread.CurrentThread.ManagedThreadId;
		}

		// Token: 0x06000E30 RID: 3632 RVA: 0x00030348 File Offset: 0x0002E548
		[DebuggerHidden]
		private void Method12168()
		{
			int num = this.number2;
			if (num - -4 > 1 && num - 1 > 1)
			{
				return;
			}
			try
			{
				if (num == -4 || num == 2)
				{
					try
					{
					}
					finally
					{
						this.Method12170();
					}
				}
			}
			finally
			{
				this.Method12169();
			}
		}

		// Token: 0x06000E31 RID: 3633 RVA: 0x000303A4 File Offset: 0x0002E5A4
		void IDisposable.Dispose()
		{
			this.Method12168();
		}

		// Token: 0x06000E32 RID: 3634 RVA: 0x000303AC File Offset: 0x0002E5AC
		private bool MoveNext()
		{
			bool result;
			try
			{
				int num = this.number2;
				752 recoveredType = this._recoveredType21959508;
				switch (num)
				{
				case 0:
					this.number2 = -1;
					this.iEnumerator = this.iEnumerable.GetEnumerator();
					this.number2 = -3;
					break;
				case 1:
					this.number2 = -3;
					break;
				case 2:
					this.number2 = -4;
					goto IL_131;
				default:
					return false;
				}
				IL_60:
				while (this.iEnumerator.MoveNext())
				{
					226 <<EMPTY_NAME>> = this.iEnumerator.Current;
					if (recoveredType.GetNullable9513_12176() != null)
					{
						226 2 = 368.Method1841(<<EMPTY_NAME>>, this._recoveredType12049509, recoveredType.GetNullable9513_12176().GetValueOrDefault());
						if (2 != null)
						{
							this.jToken2 = 2;
							this.number2 = 1;
							return true;
						}
					}
					else
					{
						if (<<EMPTY_NAME>> is 109 || <<EMPTY_NAME>> is 110)
						{
							this.iEnumerator2 = ((IEnumerable<226>)<<EMPTY_NAME>>).GetEnumerator();
							this.number2 = -4;
							goto IL_131;
						}
						541 recoveredType2 = this._recoveredType12049509;
						if (recoveredType2 != null && recoveredType2.GetFlag5433_6846())
						{
							throw new 134("Index * not valid on {0}.".Method6825(CultureInfo.InvariantCulture, <<EMPTY_NAME>>.GetType().Name));
						}
					}
				}
				this.Method12169();
				this.iEnumerator = null;
				return false;
				IL_131:
				if (!this.iEnumerator2.MoveNext())
				{
					this.Method12170();
					this.iEnumerator2 = null;
					goto IL_60;
				}
				226 3 = this.iEnumerator2.Current;
				this.jToken2 = 3;
				this.number2 = 2;
				result = true;
			}
			catch
			{
				this.Method12168();
				throw;
			}
			return result;
		}

		// Token: 0x06000E33 RID: 3635 RVA: 0x00030550 File Offset: 0x0002E750
		bool IEnumerator.MoveNext()
		{
			return this.MoveNext();
		}

		// Token: 0x06000E34 RID: 3636 RVA: 0x00030558 File Offset: 0x0002E758
		private void Method12169()
		{
			this.number2 = -1;
			if (this.iEnumerator != null)
			{
				this.iEnumerator.Dispose();
			}
		}

		// Token: 0x06000E35 RID: 3637 RVA: 0x00030574 File Offset: 0x0002E774
		private void Method12170()
		{
			this.number2 = -3;
			if (this.iEnumerator2 != null)
			{
				this.iEnumerator2.Dispose();
			}
		}

		// Token: 0x06000E36 RID: 3638 RVA: 0x00030591 File Offset: 0x0002E791
		[DebuggerHidden]
		[return: 241(1)]
		private 226 GetJToken9504_12171()
		{
			return this.jToken2;
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000E37 RID: 3639 RVA: 0x00030599 File Offset: 0x0002E799
		226 IEnumerator<226>.Current
		{
			get
			{
				return this.GetJToken9504_12171();
			}
		}

		// Token: 0x06000E38 RID: 3640 RVA: 0x00005BE8 File Offset: 0x00003DE8
		[DebuggerHidden]
		private void Method12172()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06000E39 RID: 3641 RVA: 0x000305A1 File Offset: 0x0002E7A1
		void IEnumerator.Reset()
		{
			this.Method12172();
		}

		// Token: 0x06000E3A RID: 3642 RVA: 0x00030591 File Offset: 0x0002E791
		[DebuggerHidden]
		private object GetJToken9504_12173()
		{
			return this.jToken2;
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000E3B RID: 3643 RVA: 0x000305A9 File Offset: 0x0002E7A9
		object IEnumerator.Current
		{
			get
			{
				return this.GetJToken9504_12173();
			}
		}

		// Token: 0x06000E3C RID: 3644 RVA: 0x000305B4 File Offset: 0x0002E7B4
		[DebuggerHidden]
		private IEnumerator<226> Method12174()
		{
			752.753 <<EMPTY_NAME>>;
			if (this.number2 == -2 && this.number3 == Thread.CurrentThread.ManagedThreadId)
			{
				this.number2 = 0;
				<<EMPTY_NAME>> = this;
			}
			else
			{
				<<EMPTY_NAME>> = new 752.753(0);
				<<EMPTY_NAME>>._recoveredType21959508 = this._recoveredType21959508;
			}
			<<EMPTY_NAME>>.iEnumerable = this.iEnumerable2;
			<<EMPTY_NAME>>._recoveredType12049509 = this._recoveredType12049510;
			return <<EMPTY_NAME>>;
		}

		// Token: 0x06000E3D RID: 3645 RVA: 0x00030614 File Offset: 0x0002E814
		IEnumerator<226> IEnumerable<226>.GetEnumerator()
		{
			return this.Method12174();
		}

		// Token: 0x06000E3E RID: 3646 RVA: 0x00030614 File Offset: 0x0002E814
		[DebuggerHidden]
		private IEnumerator Method12175()
		{
			return this.Method12174();
		}

		// Token: 0x06000E3F RID: 3647 RVA: 0x0003061C File Offset: 0x0002E81C
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.Method12175();
		}

		// Token: 0x040006EF RID: 1775
		private int number2;

		// Token: 0x040006F0 RID: 1776
		[241(1)]
		private 226 jToken2;

		// Token: 0x040006F1 RID: 1777
		private int number3;

		// Token: 0x040006F2 RID: 1778
		[241(new byte[]
		{
			0,
			1
		})]
		private IEnumerable<226> iEnumerable;

		// Token: 0x040006F3 RID: 1779
		[241(new byte[]
		{
			0,
			1
		})]
		public IEnumerable<226> iEnumerable2;

		// Token: 0x040006F4 RID: 1780
		public 752 _recoveredType21959508;

		// Token: 0x040006F5 RID: 1781
		private 541 _recoveredType12049509;

		// Token: 0x040006F6 RID: 1782
		public 541 _recoveredType12049510;

		// Token: 0x040006F7 RID: 1783
		[241(new byte[]
		{
			0,
			1
		})]
		private IEnumerator<226> iEnumerator;

		// Token: 0x040006F8 RID: 1784
		[241(new byte[]
		{
			0,
			1
		})]
		private IEnumerator<226> iEnumerator2;
	}
}
