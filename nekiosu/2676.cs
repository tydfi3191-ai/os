using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

// Token: 0x02000437 RID: 1079
public sealed class 2676 : IEnumerable<1063>, IEnumerable
{
	// Token: 0x17000235 RID: 565
	internal object this[string 1]
	{
		get
		{
			1063 result = null;
			if (!this.1.TryGetValue(1, out result))
			{
				return null;
			}
			return result;
		}
		set
		{
			if (!this.2.3)
			{
				return;
			}
			1063 2 = null;
			if (!this.1.TryGetValue(1, out 2))
			{
				return;
			}
			object obj;
			if (value.GetType() != 2.2)
			{
				try
				{
					obj = Convert.ChangeType(value, 2.2, 1662.18);
					goto IL_4D;
				}
				catch
				{
					return;
				}
			}
			obj = value;
			IL_4D:
			if (2.3 == null || !2.3.Equals(obj))
			{
				2.3 = obj;
				if (this.2.4)
				{
					2.1();
					return;
				}
				this.2(true);
			}
		}
	}

	// Token: 0x0600219A RID: 8602 RVA: 0x00091110 File Offset: 0x0008F310
	internal 2676(1426 1)
	{
		this.2 = 1;
	}

	// Token: 0x0600219B RID: 8603 RVA: 0x0009112A File Offset: 0x0008F32A
	internal bool 1()
	{
		return this.3;
	}

	// Token: 0x0600219C RID: 8604 RVA: 0x00091132 File Offset: 0x0008F332
	private void 2(bool 1)
	{
		this.3 = 1;
	}

	// Token: 0x0600219D RID: 8605 RVA: 0x0009113C File Offset: 0x0008F33C
	internal void 3()
	{
		if (!this.1())
		{
			return;
		}
		foreach (KeyValuePair<string, 1063> keyValuePair in this.1)
		{
			keyValuePair.Value.1();
		}
		this.2(false);
	}

	// Token: 0x0600219E RID: 8606 RVA: 0x000911A4 File Offset: 0x0008F3A4
	internal void 4()
	{
		this.2(true);
		this.1.Clear();
	}

	// Token: 0x0600219F RID: 8607 RVA: 0x000911B8 File Offset: 0x0008F3B8
	internal void 5(1063 1)
	{
		this.1[1.1] = 1;
	}

	// Token: 0x060021A0 RID: 8608 RVA: 0x000911CC File Offset: 0x0008F3CC
	internal bool Remove(string 1)
	{
		return this.1.Remove(1);
	}

	// Token: 0x060021A1 RID: 8609 RVA: 0x000911DA File Offset: 0x0008F3DA
	internal bool 6(string 1)
	{
		return this.1.ContainsKey(1);
	}

	// Token: 0x060021A2 RID: 8610 RVA: 0x000911E8 File Offset: 0x0008F3E8
	public IEnumerator<1063> GetEnumerator()
	{
		return new 2676.2677(0)
		{
			3 = this
		};
	}

	// Token: 0x060021A3 RID: 8611 RVA: 0x000911F7 File Offset: 0x0008F3F7
	private IEnumerator 7()
	{
		return this.GetEnumerator();
	}

	// Token: 0x060021A4 RID: 8612 RVA: 0x000911FF File Offset: 0x0008F3FF
	IEnumerator IEnumerable.GetEnumerator()
	{
		return this.7();
	}

	// Token: 0x04001215 RID: 4629
	private Dictionary<string, 1063> 1 = new Dictionary<string, 1063>();

	// Token: 0x04001216 RID: 4630
	private 1426 2;

	// Token: 0x04001217 RID: 4631
	private bool 3;

	// Token: 0x02000438 RID: 1080
	public sealed class 2677 : IEnumerator<1063>, IDisposable, IEnumerator
	{
		// Token: 0x060021A5 RID: 8613 RVA: 0x00091207 File Offset: 0x0008F407
		[DebuggerHidden]
		public 2677(int 1)
		{
			this.1 = 1;
		}

		// Token: 0x060021A6 RID: 8614 RVA: 0x00091218 File Offset: 0x0008F418
		[DebuggerHidden]
		private void 1()
		{
			int num = this.1;
			if (num == -3 || num == 1)
			{
				try
				{
				}
				finally
				{
					this.3();
				}
			}
		}

		// Token: 0x060021A7 RID: 8615 RVA: 0x00091250 File Offset: 0x0008F450
		void IDisposable.Dispose()
		{
			this.1();
		}

		// Token: 0x060021A8 RID: 8616 RVA: 0x00091258 File Offset: 0x0008F458
		private bool 2()
		{
			bool result;
			try
			{
				int num = this.1;
				2676 <<EMPTY_NAME>> = this.3;
				if (num != 0)
				{
					if (num != 1)
					{
						return false;
					}
					this.1 = -3;
				}
				else
				{
					this.1 = -1;
					this.4 = <<EMPTY_NAME>>.1.GetEnumerator();
					this.1 = -3;
				}
				if (this.4.MoveNext())
				{
					KeyValuePair<string, 1063> keyValuePair = this.4.Current;
					this.2 = keyValuePair.Value;
					this.1 = 1;
					result = true;
				}
				else
				{
					this.3();
					this.4 = default(Dictionary<string, 1063>.Enumerator);
					result = false;
				}
			}
			catch
			{
				this.1();
				throw;
			}
			return result;
		}

		// Token: 0x060021A9 RID: 8617 RVA: 0x0009130C File Offset: 0x0008F50C
		bool IEnumerator.MoveNext()
		{
			return this.2();
		}

		// Token: 0x060021AA RID: 8618 RVA: 0x00091314 File Offset: 0x0008F514
		private void 3()
		{
			this.1 = -1;
			((IDisposable)this.4).Dispose();
		}

		// Token: 0x060021AB RID: 8619 RVA: 0x0009132D File Offset: 0x0008F52D
		[DebuggerHidden]
		private 1063 4()
		{
			return this.2;
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x060021AC RID: 8620 RVA: 0x00091335 File Offset: 0x0008F535
		1063 IEnumerator<1063>.Current
		{
			get
			{
				return this.4();
			}
		}

		// Token: 0x060021AD RID: 8621 RVA: 0x00005BE8 File Offset: 0x00003DE8
		[DebuggerHidden]
		private void 5()
		{
			throw new NotSupportedException();
		}

		// Token: 0x060021AE RID: 8622 RVA: 0x0009133D File Offset: 0x0008F53D
		void IEnumerator.Reset()
		{
			this.5();
		}

		// Token: 0x060021AF RID: 8623 RVA: 0x0009132D File Offset: 0x0008F52D
		[DebuggerHidden]
		private object 6()
		{
			return this.2;
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x060021B0 RID: 8624 RVA: 0x00091345 File Offset: 0x0008F545
		object IEnumerator.Current
		{
			get
			{
				return this.6();
			}
		}

		// Token: 0x04001218 RID: 4632
		private int 1;

		// Token: 0x04001219 RID: 4633
		private 1063 2;

		// Token: 0x0400121A RID: 4634
		public 2676 3;

		// Token: 0x0400121B RID: 4635
		private Dictionary<string, 1063>.Enumerator 4;
	}
}
