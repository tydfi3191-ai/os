using System;
using System.Collections;
using System.Collections.Generic;

// Token: 0x02000266 RID: 614
public sealed class 526 : IEnumerable
{
	// Token: 0x060012A6 RID: 4774 RVA: 0x00042620 File Offset: 0x00040820
	public 526()
	{
		for (int i = 0; i < this.linkedListArray.Length; i++)
		{
			this.linkedListArray[i] = new LinkedList<427>();
		}
	}

	// Token: 0x060012A7 RID: 4775 RVA: 0x00042660 File Offset: 0x00040860
	public void Method6106(427 1)
	{
		int num = (639)5 - 1.Method13484() - (639)1;
		this.linkedListArray[num].AddLast(1);
		this.number2++;
		this.number3++;
	}

	// Token: 0x060012A8 RID: 4776 RVA: 0x000426A4 File Offset: 0x000408A4
	public 427 Method6107()
	{
		427 result = null;
		if (this.number2 > 0)
		{
			int num = this.Method6108(-1);
			result = this.linkedListArray[num].First.Value;
			this.linkedListArray[num].RemoveFirst();
			this.number2--;
			this.number3++;
		}
		return result;
	}

	// Token: 0x060012A9 RID: 4777 RVA: 0x00042704 File Offset: 0x00040904
	private int Method6108(int 1)
	{
		for (int i = 1 + 1; i < 5; i++)
		{
			if (this.linkedListArray[i].Count > 0)
			{
				return i;
			}
		}
		return -1;
	}

	// Token: 0x060012AA RID: 4778 RVA: 0x00042732 File Offset: 0x00040932
	public int GetNumber4843_6109()
	{
		return this.number2;
	}

	// Token: 0x060012AB RID: 4779 RVA: 0x0004273C File Offset: 0x0004093C
	public void Method6110()
	{
		if (this.number2 > 0)
		{
			LinkedList<427>[] array = this.linkedListArray;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].Clear();
			}
			this.number2 = 0;
			this.number3++;
		}
	}

	// Token: 0x060012AC RID: 4780 RVA: 0x00042784 File Offset: 0x00040984
	public IEnumerator GetEnumerator()
	{
		return new 526.527(this);
	}

	// Token: 0x040008F2 RID: 2290
	private readonly LinkedList<427>[] linkedListArray = new LinkedList<427>[5];

	// Token: 0x040008F3 RID: 2291
	private int number2;

	// Token: 0x040008F4 RID: 2292
	private int number3;

	// Token: 0x02000267 RID: 615
	public sealed class 527 : IEnumerator
	{
		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060012AD RID: 4781 RVA: 0x0004278C File Offset: 0x0004098C
		public object Current
		{
			get
			{
				return this.iEnumerator.Current;
			}
		}

		// Token: 0x060012AE RID: 4782 RVA: 0x0004279C File Offset: 0x0004099C
		public 527(526 1)
		{
			this._recoveredType11014838 = 1;
			this.number = this._recoveredType11014838.number3;
			this.number2 = this._recoveredType11014838.Method6108(-1);
			if (this.number2 >= 0)
			{
				this.iEnumerator = this._recoveredType11014838.linkedListArray[this.number2].GetEnumerator();
				return;
			}
			this.iEnumerator = null;
		}

		// Token: 0x060012AF RID: 4783 RVA: 0x0004280C File Offset: 0x00040A0C
		public void Reset()
		{
			this.number = this._recoveredType11014838.number3;
			this.number2 = this._recoveredType11014838.Method6108(-1);
			if (this.number2 >= 0)
			{
				this.iEnumerator = this._recoveredType11014838.linkedListArray[this.number2].GetEnumerator();
				return;
			}
			this.iEnumerator = null;
		}

		// Token: 0x060012B0 RID: 4784 RVA: 0x00042870 File Offset: 0x00040A70
		public bool MoveNext()
		{
			if (this.iEnumerator == null)
			{
				return false;
			}
			if (this.number != this._recoveredType11014838.number3)
			{
				throw new InvalidOperationException("The collection has been modified");
			}
			if (this.iEnumerator.MoveNext())
			{
				return true;
			}
			this.number2 = this._recoveredType11014838.Method6108(this.number2);
			if (-1 == this.number2)
			{
				return false;
			}
			this.iEnumerator = this._recoveredType11014838.linkedListArray[this.number2].GetEnumerator();
			this.iEnumerator.MoveNext();
			return true;
		}

		// Token: 0x040008F5 RID: 2293
		private readonly 526 _recoveredType11014838;

		// Token: 0x040008F6 RID: 2294
		private int number;

		// Token: 0x040008F7 RID: 2295
		private int number2;

		// Token: 0x040008F8 RID: 2296
		private IEnumerator iEnumerator;
	}
}
