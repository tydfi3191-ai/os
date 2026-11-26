using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;

// Token: 0x020003B1 RID: 945
[241(0)]
[242(1)]
[ComVisible(false)]
public class 217 : 111, IDictionary<string, 226>, ICollection<KeyValuePair<string, 226>>, IEnumerable<KeyValuePair<string, 226>>, IEnumerable, INotifyPropertyChanged, ICustomTypeDescriptor, INotifyPropertyChanging
{
	// Token: 0x170001E9 RID: 489
	// (get) Token: 0x06001CE4 RID: 7396 RVA: 0x00073268 File Offset: 0x00071468
	protected override IList<226> ChildrenTokens
	{
		get
		{
			return this._recoveredType216010849;
		}
	}

	// Token: 0x170001EA RID: 490
	// (get) Token: 0x06001CE5 RID: 7397 RVA: 0x0001702D File Offset: 0x0001522D
	public override 705 Type
	{
		get
		{
			return 705.Object;
		}
	}

	// Token: 0x170001EB RID: 491
	[241(2)]
	public override 226 this[object 1]
	{
		[return: 241(2)]
		get
		{
			756.Method12216(1, "key");
			string text = 1 as string;
			if (text == null)
			{
				throw new ArgumentException("Accessed JObject values with invalid key value: {0}. Object property name expected.".Method6825(CultureInfo.InvariantCulture, 736.Method11630(1)));
			}
			return this[text];
		}
		[param: 241(2)]
		set
		{
			756.Method12216(1, "key");
			string text = 1 as string;
			if (text == null)
			{
				throw new ArgumentException("Set JObject values with invalid key value: {0}. Object property name expected.".Method6825(CultureInfo.InvariantCulture, 736.Method11630(1)));
			}
			this[text] = value;
		}
	}

	// Token: 0x170001EC RID: 492
	[241(2)]
	public 226 this[string 1]
	{
		[return: 241(2)]
		get
		{
			756.Method12216(1, "propertyName");
			222 2 = this.Property(1, StringComparison.Ordinal);
			if (2 == null)
			{
				return null;
			}
			return 2.Value;
		}
		[param: 241(2)]
		set
		{
			222 2 = this.Property(1, StringComparison.Ordinal);
			if (2 != null)
			{
				2.Value = value;
				return;
			}
			this.OnPropertyChanging(1);
			this.Add(1, value);
			this.OnPropertyChanged(1);
		}
	}

	// Token: 0x170001ED RID: 493
	// (get) Token: 0x06001CEA RID: 7402 RVA: 0x00053ADC File Offset: 0x00051CDC
	[241(new byte[]
	{
		1,
		2
	})]
	private ICollection<226> ICollection10852
	{
		[return: 241(new byte[]
		{
			1,
			2
		})]
		get
		{
			throw new NotImplementedException();
		}
	}

	// Token: 0x14000005 RID: 5
	// (add) Token: 0x06001CEB RID: 7403 RVA: 0x00073354 File Offset: 0x00071554
	// (remove) Token: 0x06001CEC RID: 7404 RVA: 0x0007338C File Offset: 0x0007158C
	[241(2)]
	public event PropertyChangedEventHandler PropertyChanged
	{
		[CompilerGenerated]
		[242(2)]
		add
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler3;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, value);
				propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.propertyChangedEventHandler3, value2, propertyChangedEventHandler2);
			}
			while (propertyChangedEventHandler != propertyChangedEventHandler2);
		}
		[242(2)]
		[CompilerGenerated]
		remove
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler3;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value);
				propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.propertyChangedEventHandler3, value2, propertyChangedEventHandler2);
			}
			while (propertyChangedEventHandler != propertyChangedEventHandler2);
		}
	}

	// Token: 0x14000006 RID: 6
	// (add) Token: 0x06001CED RID: 7405 RVA: 0x000733C4 File Offset: 0x000715C4
	// (remove) Token: 0x06001CEE RID: 7406 RVA: 0x000733FC File Offset: 0x000715FC
	[241(2)]
	public event PropertyChangingEventHandler PropertyChanging
	{
		[CompilerGenerated]
		[242(2)]
		add
		{
			PropertyChangingEventHandler propertyChangingEventHandler = this.propertyChangingEventHandler3;
			PropertyChangingEventHandler propertyChangingEventHandler2;
			do
			{
				propertyChangingEventHandler2 = propertyChangingEventHandler;
				PropertyChangingEventHandler value2 = (PropertyChangingEventHandler)Delegate.Combine(propertyChangingEventHandler2, value);
				propertyChangingEventHandler = Interlocked.CompareExchange<PropertyChangingEventHandler>(ref this.propertyChangingEventHandler3, value2, propertyChangingEventHandler2);
			}
			while (propertyChangingEventHandler != propertyChangingEventHandler2);
		}
		[CompilerGenerated]
		[242(2)]
		remove
		{
			PropertyChangingEventHandler propertyChangingEventHandler = this.propertyChangingEventHandler3;
			PropertyChangingEventHandler propertyChangingEventHandler2;
			do
			{
				propertyChangingEventHandler2 = propertyChangingEventHandler;
				PropertyChangingEventHandler value2 = (PropertyChangingEventHandler)Delegate.Remove(propertyChangingEventHandler2, value);
				propertyChangingEventHandler = Interlocked.CompareExchange<PropertyChangingEventHandler>(ref this.propertyChangingEventHandler3, value2, propertyChangingEventHandler2);
			}
			while (propertyChangingEventHandler != propertyChangingEventHandler2);
		}
	}

	// Token: 0x06001CEF RID: 7407 RVA: 0x00073431 File Offset: 0x00071631
	public 217()
	{
	}

	// Token: 0x06001CF0 RID: 7408 RVA: 0x00073444 File Offset: 0x00071644
	public 217(217 1) : base(1, null)
	{
	}

	// Token: 0x06001CF1 RID: 7409 RVA: 0x00073459 File Offset: 0x00071659
	internal 217(217 1, [241(2)] 479 2) : base(1, 2)
	{
	}

	// Token: 0x06001CF2 RID: 7410 RVA: 0x0007346E File Offset: 0x0007166E
	public 217(params object[] 1) : this(1)
	{
	}

	// Token: 0x06001CF3 RID: 7411 RVA: 0x00073477 File Offset: 0x00071677
	public 217(object 1)
	{
		this.Method7256(1);
	}

	// Token: 0x06001CF4 RID: 7412 RVA: 0x00073494 File Offset: 0x00071694
	internal override bool Method14356(226 1)
	{
		217 2 = 1 as 217;
		return 2 != null && this._recoveredType216010849.Method11925(2._recoveredType216010849);
	}

	// Token: 0x06001CF5 RID: 7413 RVA: 0x000734BE File Offset: 0x000716BE
	[242(2)]
	internal override int Method14291(226 1)
	{
		if (1 == null)
		{
			return -1;
		}
		return this._recoveredType216010849.Method11924(1);
	}

	// Token: 0x06001CF6 RID: 7414 RVA: 0x000734D1 File Offset: 0x000716D1
	[242(2)]
	internal override bool Method14292(int 1, 226 2, bool 3, bool 4)
	{
		return (2 == null || 2.Type != 705.Comment) && base.Method14292(1, 2, 3, 4);
	}

	// Token: 0x06001CF7 RID: 7415 RVA: 0x000734EC File Offset: 0x000716EC
	internal override void Method14256(226 1, [241(2)] 226 2)
	{
		756.Method12216(1, "o");
		if (1.Type != 705.Property)
		{
			throw new ArgumentException("Can not add {0} to {1}.".Method6825(CultureInfo.InvariantCulture, 1.GetType(), base.GetType()));
		}
		222 3 = (222)1;
		if (2 != null)
		{
			222 4 = (222)2;
			if (3.Name == 4.Name)
			{
				return;
			}
		}
		if (this._recoveredType216010849.Method11921(3.Name, out 2))
		{
			throw new ArgumentException("Can not add property {0} to {1}. Property with the same name already exists on object.".Method6825(CultureInfo.InvariantCulture, 3.Name, base.GetType()));
		}
	}

	// Token: 0x06001CF8 RID: 7416 RVA: 0x0007358C File Offset: 0x0007178C
	internal override void Method14294(object 1, [241(2)] 793 2)
	{
		217 3 = 1 as 217;
		if (3 == null)
		{
			return;
		}
		foreach (KeyValuePair<string, 226> keyValuePair in 3)
		{
			222 4 = this.Property(keyValuePair.Key, (2 != null) ? 2.GetStringComparison10102_12950() : StringComparison.Ordinal);
			if (4 == null)
			{
				this.Add(keyValuePair.Key, keyValuePair.Value);
			}
			else if (keyValuePair.Value != null)
			{
				111 5 = 4.Value as 111;
				if (5 == null || 5.Type != keyValuePair.Value.Type)
				{
					if (!217.Method14258(keyValuePair.Value) || (2 != null && 2.GetRecoveredType025710101_12948() == (354)1))
					{
						4.Value = keyValuePair.Value;
					}
				}
				else
				{
					5.Method7266(keyValuePair.Value, 2);
				}
			}
		}
	}

	// Token: 0x06001CF9 RID: 7417 RVA: 0x00073678 File Offset: 0x00071878
	private static bool Method14258(226 1)
	{
		if (1.Type == 705.Null)
		{
			return true;
		}
		233 2 = 1 as 233;
		return 2 != null && 2.Value == null;
	}

	// Token: 0x06001CFA RID: 7418 RVA: 0x000736A8 File Offset: 0x000718A8
	internal void Method14259(222 1)
	{
		this.OnPropertyChanged(1.Name);
		if (this.listChangedEventHandler2 != null)
		{
			this.Method7236(new ListChangedEventArgs(ListChangedType.ItemChanged, this.Method14291(1)));
		}
		if (this.notifyCollectionChangedEventHandler2 != null)
		{
			this.Method7237(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Replace, 1, 1, this.Method14291(1)));
		}
	}

	// Token: 0x06001CFB RID: 7419 RVA: 0x000736F9 File Offset: 0x000718F9
	internal void Method14260(222 1)
	{
		this.OnPropertyChanging(1.Name);
	}

	// Token: 0x06001CFC RID: 7420 RVA: 0x00073707 File Offset: 0x00071907
	internal override 226 Method14299([241(2)] 479 1)
	{
		return new 217(this, 1);
	}

	// Token: 0x06001CFD RID: 7421 RVA: 0x00073710 File Offset: 0x00071910
	public IEnumerable<222> Properties()
	{
		return this._recoveredType216010849.Cast<222>();
	}

	// Token: 0x06001CFE RID: 7422 RVA: 0x0007371D File Offset: 0x0007191D
	[return: 241(2)]
	public 222 Property(string 1)
	{
		return this.Property(1, StringComparison.Ordinal);
	}

	// Token: 0x06001CFF RID: 7423 RVA: 0x00073728 File Offset: 0x00071928
	[return: 241(2)]
	public 222 Property(string 1, StringComparison 2)
	{
		if (1 == null)
		{
			return null;
		}
		226 3;
		if (this._recoveredType216010849.Method11921(1, out 3))
		{
			return (222)3;
		}
		if (2 != StringComparison.Ordinal)
		{
			for (int i = 0; i < this._recoveredType216010849.Count; i++)
			{
				222 4 = (222)this._recoveredType216010849[i];
				if (string.Equals(4.Name, 1, 2))
				{
					return 4;
				}
			}
		}
		return null;
	}

	// Token: 0x06001D00 RID: 7424 RVA: 0x0007378F File Offset: 0x0007198F
	[return: 241(new byte[]
	{
		0,
		1
	})]
	public 787<226> PropertyValues()
	{
		return new 787<226>(this.Properties().Select(new Func<222, 226>(217.219.instance.Method14243)));
	}

	// Token: 0x06001D01 RID: 7425 RVA: 0x000737B1 File Offset: 0x000719B1
	public new static 217 Load(139 1)
	{
		return 217.Load(1, null);
	}

	// Token: 0x06001D02 RID: 7426 RVA: 0x000737BC File Offset: 0x000719BC
	public new static 217 Load(139 1, [241(2)] 554 2)
	{
		756.Method12216(1, "reader");
		if (1.GetTokenType() == 216.None && !1.Read())
		{
			throw 141.Method12886(1, "Error reading JObject from JsonReader.");
		}
		1.Method2847();
		if (1.GetTokenType() != 216.StartObject)
		{
			throw 141.Method12886(1, "Error reading JObject from JsonReader. Current JsonReader item is not an object: {0}".Method6825(CultureInfo.InvariantCulture, 1.GetTokenType()));
		}
		217 3 = new 217();
		3.Method14343(1 as 99, 2);
		3.Method7269(1, 2);
		return 3;
	}

	// Token: 0x06001D03 RID: 7427 RVA: 0x0007383B File Offset: 0x00071A3B
	public new static 217 Parse(string 1)
	{
		return 217.Parse(1, null);
	}

	// Token: 0x06001D04 RID: 7428 RVA: 0x00073844 File Offset: 0x00071A44
	public new static 217 Parse(string 1, [241(2)] 554 2)
	{
		139 3 = new 167(new StringReader(1));
		217 result;
		try
		{
			217 4 = 217.Load(3, 2);
			while (3.Read())
			{
			}
			result = 4;
		}
		finally
		{
			((IDisposable)3).Dispose();
		}
		return result;
	}

	// Token: 0x06001D05 RID: 7429 RVA: 0x0007388C File Offset: 0x00071A8C
	public new static 217 FromObject(object 1)
	{
		return 217.FromObject(1, 158.Method3835());
	}

	// Token: 0x06001D06 RID: 7430 RVA: 0x0007389C File Offset: 0x00071A9C
	public new static 217 FromObject(object 1, 158 2)
	{
		226 3 = 226.Method14342(1, 2);
		if (3.Type != 705.Object)
		{
			throw new ArgumentException("Object serialized to {0}. JObject instance expected.".Method6825(CultureInfo.InvariantCulture, 3.Type));
		}
		return (217)3;
	}

	// Token: 0x06001D07 RID: 7431 RVA: 0x000738E0 File Offset: 0x00071AE0
	public override void WriteTo(173 1, params 214[] 2)
	{
		1.WriteStartObject();
		for (int i = 0; i < this._recoveredType216010849.Count; i++)
		{
			this._recoveredType216010849[i].WriteTo(1, 2);
		}
		1.WriteEndObject();
	}

	// Token: 0x06001D08 RID: 7432 RVA: 0x00073922 File Offset: 0x00071B22
	[242(2)]
	public 226 GetValue(string 1)
	{
		return this.GetValue(1, StringComparison.Ordinal);
	}

	// Token: 0x06001D09 RID: 7433 RVA: 0x0007392C File Offset: 0x00071B2C
	[242(2)]
	public 226 GetValue(string 1, StringComparison 2)
	{
		if (1 == null)
		{
			return null;
		}
		222 3 = this.Property(1, 2);
		if (3 == null)
		{
			return null;
		}
		return 3.Value;
	}

	// Token: 0x06001D0A RID: 7434 RVA: 0x00073946 File Offset: 0x00071B46
	public bool TryGetValue(string 1, StringComparison 2, [239(true)] [241(2)] out 226 3)
	{
		3 = this.GetValue(1, 2);
		return 3 != null;
	}

	// Token: 0x06001D0B RID: 7435 RVA: 0x00073957 File Offset: 0x00071B57
	public void Add(string 1, [241(2)] 226 2)
	{
		this.Method7256(new 222(1, 2));
	}

	// Token: 0x06001D0C RID: 7436 RVA: 0x00073966 File Offset: 0x00071B66
	public bool ContainsKey(string 1)
	{
		756.Method12216(1, "propertyName");
		return this._recoveredType216010849.Method11915(1);
	}

	// Token: 0x06001D0D RID: 7437 RVA: 0x0007397F File Offset: 0x00071B7F
	private ICollection<string> Method14262()
	{
		return this._recoveredType216010849.Method11922();
	}

	// Token: 0x170001EE RID: 494
	// (get) Token: 0x06001D0E RID: 7438 RVA: 0x0007398C File Offset: 0x00071B8C
	ICollection<string> IDictionary<string, 226>.Keys
	{
		get
		{
			return this.Method14262();
		}
	}

	// Token: 0x06001D0F RID: 7439 RVA: 0x00073994 File Offset: 0x00071B94
	public bool Remove(string 1)
	{
		222 2 = this.Property(1, StringComparison.Ordinal);
		if (2 == null)
		{
			return false;
		}
		2.Remove();
		return true;
	}

	// Token: 0x06001D10 RID: 7440 RVA: 0x000739B8 File Offset: 0x00071BB8
	public bool TryGetValue(string 1, [241(2)] [239(true)] out 226 2)
	{
		222 3 = this.Property(1, StringComparison.Ordinal);
		if (3 == null)
		{
			2 = null;
			return false;
		}
		2 = 3.Value;
		return true;
	}

	// Token: 0x06001D11 RID: 7441 RVA: 0x000739DF File Offset: 0x00071BDF
	private void Method14263([241(new byte[]
	{
		0,
		1,
		2
	})] KeyValuePair<string, 226> 1)
	{
		this.Method7256(new 222(1.Key, 1.Value));
	}

	// Token: 0x06001D12 RID: 7442 RVA: 0x000739FA File Offset: 0x00071BFA
	void ICollection<KeyValuePair<string, 226>>.Add([241(new byte[]
	{
		0,
		1,
		2
	})] KeyValuePair<string, 226> 1)
	{
		this.Method14263(1);
	}

	// Token: 0x06001D13 RID: 7443 RVA: 0x00073A03 File Offset: 0x00071C03
	private void Method14264()
	{
		base.Method7264();
	}

	// Token: 0x06001D14 RID: 7444 RVA: 0x00073A0B File Offset: 0x00071C0B
	void ICollection<KeyValuePair<string, 226>>.Clear()
	{
		this.Method14264();
	}

	// Token: 0x06001D15 RID: 7445 RVA: 0x00073A14 File Offset: 0x00071C14
	private bool Method14265([241(new byte[]
	{
		0,
		1,
		2
	})] KeyValuePair<string, 226> 1)
	{
		222 2 = this.Property(1.Key, StringComparison.Ordinal);
		return 2 != null && 2.Value == 1.Value;
	}

	// Token: 0x06001D16 RID: 7446 RVA: 0x00073A44 File Offset: 0x00071C44
	bool ICollection<KeyValuePair<string, 226>>.Contains([241(new byte[]
	{
		0,
		1,
		2
	})] KeyValuePair<string, 226> 1)
	{
		return this.Method14265(1);
	}

	// Token: 0x06001D17 RID: 7447 RVA: 0x00073A50 File Offset: 0x00071C50
	private void Method14266([241(new byte[]
	{
		1,
		0,
		1,
		2
	})] KeyValuePair<string, 226>[] 1, int 2)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("#=zf5dqUaI=");
		}
		if (2 < 0)
		{
			throw new ArgumentOutOfRangeException("#=z23ac_4Y=", "arrayIndex is less than 0.");
		}
		if (2 >= 1.Length && 2 != 0)
		{
			throw new ArgumentException("arrayIndex is equal to or greater than the length of array.");
		}
		if (base.Count > 1.Length - 2)
		{
			throw new ArgumentException("The number of elements in the source JObject is greater than the available space from arrayIndex to the end of the destination array.");
		}
		int num = 0;
		foreach (226 3 in this._recoveredType216010849)
		{
			222 4 = (222)3;
			1[2 + num] = new KeyValuePair<string, 226>(4.Name, 4.Value);
			num++;
		}
	}

	// Token: 0x06001D18 RID: 7448 RVA: 0x00073B0C File Offset: 0x00071D0C
	void ICollection<KeyValuePair<string, 226>>.CopyTo([241(new byte[]
	{
		1,
		0,
		1,
		2
	})] KeyValuePair<string, 226>[] 1, int 2)
	{
		this.Method14266(1, 2);
	}

	// Token: 0x06001D19 RID: 7449 RVA: 0x0000FF75 File Offset: 0x0000E175
	private bool Method14267()
	{
		return false;
	}

	// Token: 0x170001EF RID: 495
	// (get) Token: 0x06001D1A RID: 7450 RVA: 0x00073B16 File Offset: 0x00071D16
	bool ICollection<KeyValuePair<string, 226>>.IsReadOnly
	{
		get
		{
			return this.Method14267();
		}
	}

	// Token: 0x06001D1B RID: 7451 RVA: 0x00073B1E File Offset: 0x00071D1E
	private bool Method14268([241(new byte[]
	{
		0,
		1,
		2
	})] KeyValuePair<string, 226> 1)
	{
		if (!((ICollection<KeyValuePair<string, 226>>)this).Contains(1))
		{
			return false;
		}
		((IDictionary<string, 226>)this).Remove(1.Key);
		return true;
	}

	// Token: 0x06001D1C RID: 7452 RVA: 0x00073B3A File Offset: 0x00071D3A
	bool ICollection<KeyValuePair<string, 226>>.Remove([241(new byte[]
	{
		0,
		1,
		2
	})] KeyValuePair<string, 226> 1)
	{
		return this.Method14268(1);
	}

	// Token: 0x06001D1D RID: 7453 RVA: 0x00019390 File Offset: 0x00017590
	internal override int Method14364()
	{
		return base.Method7272();
	}

	// Token: 0x06001D1E RID: 7454 RVA: 0x00073B43 File Offset: 0x00071D43
	[return: 241(new byte[]
	{
		1,
		0,
		1,
		2
	})]
	public IEnumerator<KeyValuePair<string, 226>> GetEnumerator()
	{
		return new 217.218(0)
		{
			jObject2 = this
		};
	}

	// Token: 0x06001D1F RID: 7455 RVA: 0x00073B52 File Offset: 0x00071D52
	protected virtual void OnPropertyChanged(string 1)
	{
		PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler3;
		if (propertyChangedEventHandler == null)
		{
			return;
		}
		propertyChangedEventHandler(this, new PropertyChangedEventArgs(1));
	}

	// Token: 0x06001D20 RID: 7456 RVA: 0x00073B6B File Offset: 0x00071D6B
	protected virtual void OnPropertyChanging(string 1)
	{
		PropertyChangingEventHandler propertyChangingEventHandler = this.propertyChangingEventHandler3;
		if (propertyChangingEventHandler == null)
		{
			return;
		}
		propertyChangingEventHandler(this, new PropertyChangingEventArgs(1));
	}

	// Token: 0x06001D21 RID: 7457 RVA: 0x00073B84 File Offset: 0x00071D84
	private PropertyDescriptorCollection Method14270()
	{
		return ((ICustomTypeDescriptor)this).GetProperties(null);
	}

	// Token: 0x06001D22 RID: 7458 RVA: 0x00073B8D File Offset: 0x00071D8D
	PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties()
	{
		return this.Method14270();
	}

	// Token: 0x06001D23 RID: 7459 RVA: 0x00073B98 File Offset: 0x00071D98
	private PropertyDescriptorCollection Method14270([241(new byte[]
	{
		2,
		1
	})] Attribute[] 1)
	{
		PropertyDescriptor[] array = new PropertyDescriptor[base.Count];
		int num = 0;
		using (IEnumerator<KeyValuePair<string, 226>> enumerator = this.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				PropertyDescriptor[] array2 = array;
				int num2 = num;
				KeyValuePair<string, 226> keyValuePair = enumerator.Current;
				array2[num2] = new 610(keyValuePair.Key);
				num++;
			}
		}
		return new PropertyDescriptorCollection(array);
	}

	// Token: 0x06001D24 RID: 7460 RVA: 0x00073C00 File Offset: 0x00071E00
	PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties([241(new byte[]
	{
		2,
		1
	})] Attribute[] 1)
	{
		return this.Method14270(1);
	}

	// Token: 0x06001D25 RID: 7461 RVA: 0x00073C09 File Offset: 0x00071E09
	private AttributeCollection GetEmpty_14272()
	{
		return AttributeCollection.Empty;
	}

	// Token: 0x06001D26 RID: 7462 RVA: 0x00073C10 File Offset: 0x00071E10
	AttributeCollection ICustomTypeDescriptor.GetAttributes()
	{
		return this.GetEmpty_14272();
	}

	// Token: 0x06001D27 RID: 7463 RVA: 0x00009D1A File Offset: 0x00007F1A
	[242(2)]
	private string Method14273()
	{
		return null;
	}

	// Token: 0x06001D28 RID: 7464 RVA: 0x00073C18 File Offset: 0x00071E18
	string ICustomTypeDescriptor.GetClassName()
	{
		return this.Method14273();
	}

	// Token: 0x06001D29 RID: 7465 RVA: 0x00009D1A File Offset: 0x00007F1A
	[242(2)]
	private string Method14274()
	{
		return null;
	}

	// Token: 0x06001D2A RID: 7466 RVA: 0x00073C20 File Offset: 0x00071E20
	string ICustomTypeDescriptor.GetComponentName()
	{
		return this.Method14274();
	}

	// Token: 0x06001D2B RID: 7467 RVA: 0x00073C28 File Offset: 0x00071E28
	private TypeConverter Method14275()
	{
		return new TypeConverter();
	}

	// Token: 0x06001D2C RID: 7468 RVA: 0x00073C2F File Offset: 0x00071E2F
	TypeConverter ICustomTypeDescriptor.GetConverter()
	{
		return this.Method14275();
	}

	// Token: 0x06001D2D RID: 7469 RVA: 0x00009D1A File Offset: 0x00007F1A
	[242(2)]
	private EventDescriptor Method14276()
	{
		return null;
	}

	// Token: 0x06001D2E RID: 7470 RVA: 0x00073C37 File Offset: 0x00071E37
	EventDescriptor ICustomTypeDescriptor.GetDefaultEvent()
	{
		return this.Method14276();
	}

	// Token: 0x06001D2F RID: 7471 RVA: 0x00009D1A File Offset: 0x00007F1A
	[242(2)]
	private PropertyDescriptor Method14277()
	{
		return null;
	}

	// Token: 0x06001D30 RID: 7472 RVA: 0x00073C3F File Offset: 0x00071E3F
	PropertyDescriptor ICustomTypeDescriptor.GetDefaultProperty()
	{
		return this.Method14277();
	}

	// Token: 0x06001D31 RID: 7473 RVA: 0x00009D1A File Offset: 0x00007F1A
	[return: 241(2)]
	private object Method14278(Type 1)
	{
		return null;
	}

	// Token: 0x06001D32 RID: 7474 RVA: 0x00073C47 File Offset: 0x00071E47
	object ICustomTypeDescriptor.GetEditor(Type 1)
	{
		return this.Method14278(1);
	}

	// Token: 0x06001D33 RID: 7475 RVA: 0x00073C50 File Offset: 0x00071E50
	private EventDescriptorCollection GetEmpty_14279([241(new byte[]
	{
		2,
		1
	})] Attribute[] 1)
	{
		return EventDescriptorCollection.Empty;
	}

	// Token: 0x06001D34 RID: 7476 RVA: 0x00073C57 File Offset: 0x00071E57
	EventDescriptorCollection ICustomTypeDescriptor.GetEvents([241(new byte[]
	{
		2,
		1
	})] Attribute[] 1)
	{
		return this.GetEmpty_14279(1);
	}

	// Token: 0x06001D35 RID: 7477 RVA: 0x00073C50 File Offset: 0x00071E50
	private EventDescriptorCollection GetEmpty_14279()
	{
		return EventDescriptorCollection.Empty;
	}

	// Token: 0x06001D36 RID: 7478 RVA: 0x00073C60 File Offset: 0x00071E60
	EventDescriptorCollection ICustomTypeDescriptor.GetEvents()
	{
		return this.GetEmpty_14279();
	}

	// Token: 0x06001D37 RID: 7479 RVA: 0x00073C68 File Offset: 0x00071E68
	[242(2)]
	private object Method14281(PropertyDescriptor 1)
	{
		if (1 is 610)
		{
			return this;
		}
		return null;
	}

	// Token: 0x06001D38 RID: 7480 RVA: 0x00073C75 File Offset: 0x00071E75
	object ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor 1)
	{
		return this.Method14281(1);
	}

	// Token: 0x06001D39 RID: 7481 RVA: 0x00073C7E File Offset: 0x00071E7E
	protected override DynamicMetaObject GetMetaObject(Expression 1)
	{
		return new 640<217>(1, this, new 217.220());
	}

	// Token: 0x170001F0 RID: 496
	// (get) Token: 0x06001D3A RID: 7482 RVA: 0x00073C8C File Offset: 0x00071E8C
	ICollection<226> IDictionary<string, 226>.Values
	{
		get
		{
			return this.ICollection10852;
		}
	}

	// Token: 0x04000E98 RID: 3736
	private readonly 742 _recoveredType216010849 = new 742();

	// Token: 0x04000E99 RID: 3737
	[241(2)]
	private PropertyChangedEventHandler propertyChangedEventHandler3;

	// Token: 0x04000E9A RID: 3738
	[241(2)]
	private PropertyChangingEventHandler propertyChangingEventHandler3;

	// Token: 0x020003B2 RID: 946
	[Serializable]
	public sealed class 219
	{
		// Token: 0x06001D3B RID: 7483 RVA: 0x00073C94 File Offset: 0x00071E94
		[242(0)]
		internal 226 Method14243(222 1)
		{
			return 1.Value;
		}

		// Token: 0x04000E9B RID: 3739
		[241(0)]
		public static readonly 217.219 instance = new 217.219();

		// Token: 0x04000E9C RID: 3740
		[241(0)]
		public static Func<222, 226> func;
	}

	// Token: 0x020003B3 RID: 947
	public sealed class 218 : IEnumerator<KeyValuePair<string, 226>>, IDisposable, IEnumerator
	{
		// Token: 0x06001D3E RID: 7486 RVA: 0x00073CA8 File Offset: 0x00071EA8
		[DebuggerHidden]
		public 218(int 1)
		{
			this.number2 = 1;
		}

		// Token: 0x06001D3F RID: 7487 RVA: 0x00073CB8 File Offset: 0x00071EB8
		[DebuggerHidden]
		private void Method14244()
		{
			int num = this.number2;
			if (num == -3 || num == 1)
			{
				try
				{
				}
				finally
				{
					this.Method14245();
				}
			}
		}

		// Token: 0x06001D40 RID: 7488 RVA: 0x00073CF0 File Offset: 0x00071EF0
		void IDisposable.Dispose()
		{
			this.Method14244();
		}

		// Token: 0x06001D41 RID: 7489 RVA: 0x00073CF8 File Offset: 0x00071EF8
		private bool MoveNext()
		{
			bool result;
			try
			{
				int num = this.number2;
				217 <<EMPTY_NAME>> = this.jObject2;
				if (num != 0)
				{
					if (num != 1)
					{
						return false;
					}
					this.number2 = -3;
				}
				else
				{
					this.number2 = -1;
					this.iEnumerator = <<EMPTY_NAME>>._recoveredType216010849.GetEnumerator();
					this.number2 = -3;
				}
				if (this.iEnumerator.MoveNext())
				{
					222 2 = (222)this.iEnumerator.Current;
					this.keyValuePair = new KeyValuePair<string, 226>(2.Name, 2.Value);
					this.number2 = 1;
					result = true;
				}
				else
				{
					this.Method14245();
					this.iEnumerator = null;
					result = false;
				}
			}
			catch
			{
				this.Method14244();
				throw;
			}
			return result;
		}

		// Token: 0x06001D42 RID: 7490 RVA: 0x00073DB8 File Offset: 0x00071FB8
		bool IEnumerator.MoveNext()
		{
			return this.MoveNext();
		}

		// Token: 0x06001D43 RID: 7491 RVA: 0x00073DC0 File Offset: 0x00071FC0
		private void Method14245()
		{
			this.number2 = -1;
			if (this.iEnumerator != null)
			{
				this.iEnumerator.Dispose();
			}
		}

		// Token: 0x06001D44 RID: 7492 RVA: 0x00073DDC File Offset: 0x00071FDC
		[DebuggerHidden]
		[return: 241(new byte[]
		{
			0,
			1,
			2
		})]
		private KeyValuePair<string, 226> GetKeyValuePair10844_14246()
		{
			return this.keyValuePair;
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x06001D45 RID: 7493 RVA: 0x00073DE4 File Offset: 0x00071FE4
		KeyValuePair<string, 226> IEnumerator<KeyValuePair<string, 226>>.Current
		{
			get
			{
				return this.GetKeyValuePair10844_14246();
			}
		}

		// Token: 0x06001D46 RID: 7494 RVA: 0x00005BE8 File Offset: 0x00003DE8
		[DebuggerHidden]
		private void Method14247()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06001D47 RID: 7495 RVA: 0x00073DEC File Offset: 0x00071FEC
		void IEnumerator.Reset()
		{
			this.Method14247();
		}

		// Token: 0x06001D48 RID: 7496 RVA: 0x00073DF4 File Offset: 0x00071FF4
		[DebuggerHidden]
		[return: 241(0)]
		private object GetKeyValuePair10844_14248()
		{
			return this.keyValuePair;
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06001D49 RID: 7497 RVA: 0x00073E01 File Offset: 0x00072001
		object IEnumerator.Current
		{
			get
			{
				return this.GetKeyValuePair10844_14248();
			}
		}

		// Token: 0x04000E9D RID: 3741
		private int number2;

		// Token: 0x04000E9E RID: 3742
		[241(new byte[]
		{
			0,
			1,
			2
		})]
		private KeyValuePair<string, 226> keyValuePair;

		// Token: 0x04000E9F RID: 3743
		[241(0)]
		public 217 jObject2;

		// Token: 0x04000EA0 RID: 3744
		[241(new byte[]
		{
			0,
			1
		})]
		private IEnumerator<226> iEnumerator;
	}

	// Token: 0x020003B4 RID: 948
	[241(new byte[]
	{
		0,
		1
	})]
	public sealed class 220 : 625<217>
	{
		// Token: 0x06001D4A RID: 7498 RVA: 0x00073E09 File Offset: 0x00072009
		public override bool Method14250(217 1, GetMemberBinder 2, [241(2)] out object 3)
		{
			3 = 1[2.Name];
			return true;
		}

		// Token: 0x06001D4B RID: 7499 RVA: 0x00073E1C File Offset: 0x0007201C
		public override bool Method14251(217 1, SetMemberBinder 2, object 3)
		{
			226 4 = 3 as 226;
			if (4 == null)
			{
				4 = new 233(3);
			}
			1[2.Name] = 4;
			return true;
		}

		// Token: 0x06001D4C RID: 7500 RVA: 0x00073E48 File Offset: 0x00072048
		public override IEnumerable<string> Method14252(217 1)
		{
			return 1.Properties().Select(new Func<222, string>(217.220.221.instance.Method14249));
		}

		// Token: 0x020003B5 RID: 949
		[Serializable]
		public sealed class 221
		{
			// Token: 0x06001D4E RID: 7502 RVA: 0x00073E6D File Offset: 0x0007206D
			[242(0)]
			internal string Method14249(222 1)
			{
				return 1.Name;
			}

			// Token: 0x04000EA1 RID: 3745
			[241(0)]
			public static readonly 217.220.221 instance = new 217.220.221();

			// Token: 0x04000EA2 RID: 3746
			[241(0)]
			public static Func<222, string> func;
		}
	}
}
