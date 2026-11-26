using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;

// Token: 0x020001DF RID: 479
[ComVisible(false)]
public sealed class 898 : 139, 99
{
	// Token: 0x06000F07 RID: 3847 RVA: 0x000332C6 File Offset: 0x000314C6
	public 898(139 1)
	{
		756.Method12216(1, "reader");
		this.innerReader = 1;
		this.stack = new Stack<898.900>();
	}

	// Token: 0x06000F08 RID: 3848 RVA: 0x000332EC File Offset: 0x000314EC
	public void AddValidationEventHandler(766 1)
	{
		766 2 = this.validationEventHandler;
		766 3;
		do
		{
			3 = 2;
			766 value = (766)Delegate.Combine(3, 1);
			2 = Interlocked.CompareExchange<766>(ref this.validationEventHandler, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x06000F09 RID: 3849 RVA: 0x00033324 File Offset: 0x00031524
	public void RemoveValidationEventHandler(766 1)
	{
		766 2 = this.validationEventHandler;
		766 3;
		do
		{
			3 = 2;
			766 value = (766)Delegate.Remove(3, 1);
			2 = Interlocked.CompareExchange<766>(ref this.validationEventHandler, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x06000F0A RID: 3850 RVA: 0x00033359 File Offset: 0x00031559
	public override object GetValue()
	{
		return this.innerReader.GetValue();
	}

	// Token: 0x06000F0B RID: 3851 RVA: 0x00033366 File Offset: 0x00031566
	public override int GetDepth()
	{
		return this.innerReader.GetDepth();
	}

	// Token: 0x06000F0C RID: 3852 RVA: 0x00033373 File Offset: 0x00031573
	public string Method1317()
	{
		return this.innerReader.Path;
	}

	// Token: 0x06000F0D RID: 3853 RVA: 0x00033380 File Offset: 0x00031580
	public override char GetQuoteChar()
	{
		return this.innerReader.GetQuoteChar();
	}

	// Token: 0x06000F0E RID: 3854 RVA: 0x00005ADD File Offset: 0x00003CDD
	protected internal override void SetQuoteChar(char 1)
	{
	}

	// Token: 0x06000F0F RID: 3855 RVA: 0x0003338D File Offset: 0x0003158D
	public override 216 GetTokenType()
	{
		return this.innerReader.GetTokenType();
	}

	// Token: 0x06000F10 RID: 3856 RVA: 0x0003339A File Offset: 0x0003159A
	public override Type GetValueType()
	{
		return this.innerReader.GetValueType();
	}

	// Token: 0x06000F11 RID: 3857 RVA: 0x000333A7 File Offset: 0x000315A7
	private void PushScope(898.900 1)
	{
		this.stack.Push(1);
		this.currentScope = 1;
	}

	// Token: 0x06000F12 RID: 3858 RVA: 0x000333BC File Offset: 0x000315BC
	private 898.900 PopScope()
	{
		898.900 result = this.stack.Pop();
		this.currentScope = ((this.stack.Count != 0) ? this.stack.Peek() : null);
		return result;
	}

	// Token: 0x06000F13 RID: 3859 RVA: 0x000333EA File Offset: 0x000315EA
	private IList<78> GetScopeSchemas()
	{
		return this.currentScope.GetSchemas();
	}

	// Token: 0x06000F14 RID: 3860 RVA: 0x000333F8 File Offset: 0x000315F8
	private IList<78> GetApplicableSchemas()
	{
		if (this.currentScope == null)
		{
			return new List<78>(new 78[]
			{
				this.currentSchema
			});
		}
		if (this.currentScope.GetSchemas() == null || this.currentScope.GetSchemas().Count == 0)
		{
			return 898.emptySchemas;
		}
		switch (this.currentScope.GetTokenType())
		{
		case 705.None:
			return this.currentScope.GetSchemas();
		case 705.Object:
		{
			if (this.currentScope.GetCurrentPropertyName() == null)
			{
				throw new 141("CurrentPropertyName has not been set on scope.");
			}
			IList<78> list = new List<78>();
			foreach (78 <<EMPTY_NAME>> in this.GetScopeSchemas())
			{
				78 item;
				if (<<EMPTY_NAME>>.GetProperties() != null && <<EMPTY_NAME>>.GetProperties().TryGetValue(this.currentScope.GetCurrentPropertyName(), out item))
				{
					list.Add(item);
				}
				if (<<EMPTY_NAME>>.GetPatternProperties() != null)
				{
					foreach (KeyValuePair<string, 78> keyValuePair in <<EMPTY_NAME>>.GetPatternProperties())
					{
						if (Regex.IsMatch(this.currentScope.GetCurrentPropertyName(), keyValuePair.Key))
						{
							list.Add(keyValuePair.Value);
						}
					}
				}
				if (list.Count == 0 && <<EMPTY_NAME>>.GetAllowAdditionalProperties() && <<EMPTY_NAME>>.GetAdditionalProperties() != null)
				{
					list.Add(<<EMPTY_NAME>>.GetAdditionalProperties());
				}
			}
			return list;
		}
		case 705.Array:
		{
			IList<78> list2 = new List<78>();
			foreach (78 2 in this.GetScopeSchemas())
			{
				if (!2.GetPositionalItemsValidation())
				{
					if (2.GetItems() != null && 2.GetItems().Count > 0)
					{
						list2.Add(2.GetItems()[0]);
					}
				}
				else
				{
					if (2.GetItems() != null && 2.GetItems().Count > 0 && 2.GetItems().Count > this.currentScope.GetArrayItemCount() - 1)
					{
						list2.Add(2.GetItems()[this.currentScope.GetArrayItemCount() - 1]);
					}
					if (2.GetAllowAdditionalItems() && 2.GetAdditionalItems() != null)
					{
						list2.Add(2.GetAdditionalItems());
					}
				}
			}
			return list2;
		}
		case 705.Constructor:
			return 898.emptySchemas;
		default:
			throw new ArgumentOutOfRangeException("TokenType", "Unexpected token type: {0}".Method6825(CultureInfo.InvariantCulture, this.currentScope.GetTokenType()));
		}
	}

	// Token: 0x06000F15 RID: 3861 RVA: 0x000336B8 File Offset: 0x000318B8
	private void ReportError(string 1, 78 2)
	{
		string 3 = ((99)this).HasLineInfo() ? (1 + " Line {0}, position {1}.".Method6825(CultureInfo.InvariantCulture, ((99)this).GetLineNumber(), ((99)this).GetLinePosition())) : 1;
		this.RaiseValidationEvent(new 142(3, null, this.Path, ((99)this).GetLineNumber(), ((99)this).GetLinePosition()));
	}

	// Token: 0x06000F16 RID: 3862 RVA: 0x0003371C File Offset: 0x0003191C
	private void RaiseValidationEvent(142 1)
	{
		766 2 = this.validationEventHandler;
		if (2 != null)
		{
			2(this, new 691(1));
			return;
		}
		throw 1;
	}

	// Token: 0x06000F17 RID: 3863 RVA: 0x00033742 File Offset: 0x00031942
	public 529 GetSchema()
	{
		return this.schema;
	}

	// Token: 0x06000F18 RID: 3864 RVA: 0x0003374A File Offset: 0x0003194A
	public void SetSchema(529 1)
	{
		if (this.GetTokenType() != 216.None)
		{
			throw new InvalidOperationException("Cannot change schema while validating JSON.");
		}
		this.schema = 1;
		this.currentSchema = null;
	}

	// Token: 0x06000F19 RID: 3865 RVA: 0x0003376D File Offset: 0x0003196D
	public 139 GetInnerReader()
	{
		return this.innerReader;
	}

	// Token: 0x06000F1A RID: 3866 RVA: 0x00033775 File Offset: 0x00031975
	public override void Close()
	{
		base.Close();
		if (base.GetCloseInput())
		{
			139 <<EMPTY_NAME>> = this.innerReader;
			if (<<EMPTY_NAME>> == null)
			{
				return;
			}
			<<EMPTY_NAME>>.Close();
		}
	}

	// Token: 0x06000F1B RID: 3867 RVA: 0x00033798 File Offset: 0x00031998
	private void ValidateDisallowedType(78 1)
	{
		if (1 != null)
		{
			235? currentSchemaType = this.GetCurrentSchemaType();
			if (currentSchemaType != null && 155.Method10028(new 235?(1.GetDisallow()), currentSchemaType.GetValueOrDefault()))
			{
				this.ReportError("Type {0} is disallowed.".Method6825(CultureInfo.InvariantCulture, currentSchemaType), 1);
			}
		}
	}

	// Token: 0x06000F1C RID: 3868 RVA: 0x000337F0 File Offset: 0x000319F0
	private 235? GetCurrentSchemaType()
	{
		switch (this.innerReader.GetTokenType())
		{
		case 216.StartObject:
			return new 235?(235.Object);
		case 216.StartArray:
			return new 235?(235.Array);
		case 216.Integer:
			return new 235?(235.Integer);
		case 216.Float:
			return new 235?(235.Float);
		case 216.String:
			return new 235?(235.String);
		case 216.Boolean:
			return new 235?(235.Boolean);
		case 216.Null:
			return new 235?(235.Null);
		}
		return null;
	}

	// Token: 0x06000F1D RID: 3869 RVA: 0x0003388C File Offset: 0x00031A8C
	public override int? ReadAsInt32()
	{
		int? result = this.innerReader.ReadAsInt32();
		this.ValidateToken();
		return result;
	}

	// Token: 0x06000F1E RID: 3870 RVA: 0x0003389F File Offset: 0x00031A9F
	public override byte[] ReadAsBytes()
	{
		byte[] result = this.innerReader.ReadAsBytes();
		this.ValidateToken();
		return result;
	}

	// Token: 0x06000F1F RID: 3871 RVA: 0x000338B2 File Offset: 0x00031AB2
	public override decimal? ReadAsDecimal()
	{
		decimal? result = this.innerReader.ReadAsDecimal();
		this.ValidateToken();
		return result;
	}

	// Token: 0x06000F20 RID: 3872 RVA: 0x000338C5 File Offset: 0x00031AC5
	public override double? ReadAsDouble()
	{
		double? result = this.innerReader.ReadAsDouble();
		this.ValidateToken();
		return result;
	}

	// Token: 0x06000F21 RID: 3873 RVA: 0x000338D8 File Offset: 0x00031AD8
	public override bool? ReadAsBoolean()
	{
		bool? result = this.innerReader.ReadAsBoolean();
		this.ValidateToken();
		return result;
	}

	// Token: 0x06000F22 RID: 3874 RVA: 0x000338EB File Offset: 0x00031AEB
	public override string ReadAsString()
	{
		string result = this.innerReader.ReadAsString();
		this.ValidateToken();
		return result;
	}

	// Token: 0x06000F23 RID: 3875 RVA: 0x000338FE File Offset: 0x00031AFE
	public override DateTime? ReadAsDateTime()
	{
		DateTime? result = this.innerReader.ReadAsDateTime();
		this.ValidateToken();
		return result;
	}

	// Token: 0x06000F24 RID: 3876 RVA: 0x00033911 File Offset: 0x00031B11
	public override DateTimeOffset? ReadAsDateTimeOffset()
	{
		DateTimeOffset? result = this.innerReader.ReadAsDateTimeOffset();
		this.ValidateToken();
		return result;
	}

	// Token: 0x06000F25 RID: 3877 RVA: 0x00033924 File Offset: 0x00031B24
	public override bool Read()
	{
		if (!this.innerReader.Read())
		{
			return false;
		}
		if (this.innerReader.GetTokenType() == 216.Comment)
		{
			return true;
		}
		this.ValidateToken();
		return true;
	}

	// Token: 0x06000F26 RID: 3878 RVA: 0x0003394C File Offset: 0x00031B4C
	private void ValidateToken()
	{
		if (this.currentSchema == null)
		{
			401 <<EMPTY_NAME>> = new 401();
			this.currentSchema = <<EMPTY_NAME>>.Method2538(this.schema);
			if (!169.IsStartToken(this.innerReader.GetTokenType()))
			{
				this.PushScope(new 898.900(705.None, this.GetApplicableSchemas()));
			}
		}
		switch (this.innerReader.GetTokenType())
		{
		case 216.None:
			return;
		case 216.StartObject:
		{
			this.ValidateArrayItem();
			IList<78> 2 = this.GetApplicableSchemas().Where(new Func<78, bool>(this.IsObjectSchema)).ToList<78>();
			this.PushScope(new 898.900(705.Object, 2));
			this.CaptureTokenValue(this.GetScopeSchemas());
			return;
		}
		case 216.StartArray:
		{
			this.ValidateArrayItem();
			IList<78> 3 = this.GetApplicableSchemas().Where(new Func<78, bool>(this.IsArraySchema)).ToList<78>();
			this.PushScope(new 898.900(705.Array, 3));
			this.CaptureTokenValue(this.GetScopeSchemas());
			return;
		}
		case 216.StartConstructor:
			this.ValidateArrayItem();
			this.PushScope(new 898.900(705.Constructor, null));
			this.CaptureTokenValue(this.GetScopeSchemas());
			return;
		case 216.PropertyName:
			this.CaptureTokenValue(this.GetScopeSchemas());
			using (IEnumerator<78> enumerator = this.GetScopeSchemas().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					78 4 = enumerator.Current;
					this.ValidatePropertyName(4);
				}
				return;
			}
			break;
		case 216.Comment:
			goto IL_3BD;
		case 216.Raw:
			break;
		case 216.Integer:
			this.ValidateArrayItem();
			this.CaptureTokenValue(this.GetApplicableSchemas());
			using (IEnumerator<78> enumerator = this.GetApplicableSchemas().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					78 5 = enumerator.Current;
					this.ValidateInteger(5);
				}
				return;
			}
			goto IL_1D6;
		case 216.Float:
			goto IL_1D6;
		case 216.String:
			goto IL_222;
		case 216.Boolean:
			goto IL_26E;
		case 216.Null:
			goto IL_2BA;
		case 216.Undefined:
		case 216.Date:
		case 216.Bytes:
			this.CaptureTokenValue(this.GetApplicableSchemas());
			return;
		case 216.EndObject:
			goto IL_306;
		case 216.EndArray:
			this.CaptureTokenValue(this.GetScopeSchemas());
			foreach (78 6 in this.GetScopeSchemas())
			{
				this.ValidateArrayItemCount(6);
			}
			this.PopScope();
			return;
		case 216.EndConstructor:
			this.CaptureTokenValue(this.GetScopeSchemas());
			this.PopScope();
			return;
		default:
			goto IL_3BD;
		}
		this.ValidateArrayItem();
		return;
		IL_1D6:
		this.ValidateArrayItem();
		this.CaptureTokenValue(this.GetApplicableSchemas());
		using (IEnumerator<78> enumerator = this.GetApplicableSchemas().GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				78 7 = enumerator.Current;
				this.ValidateFloat(7);
			}
			return;
		}
		IL_222:
		this.ValidateArrayItem();
		this.CaptureTokenValue(this.GetApplicableSchemas());
		using (IEnumerator<78> enumerator = this.GetApplicableSchemas().GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				78 8 = enumerator.Current;
				this.ValidateString(8);
			}
			return;
		}
		IL_26E:
		this.ValidateArrayItem();
		this.CaptureTokenValue(this.GetApplicableSchemas());
		using (IEnumerator<78> enumerator = this.GetApplicableSchemas().GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				78 9 = enumerator.Current;
				this.ValidateBoolean(9);
			}
			return;
		}
		IL_2BA:
		this.ValidateArrayItem();
		this.CaptureTokenValue(this.GetApplicableSchemas());
		using (IEnumerator<78> enumerator = this.GetApplicableSchemas().GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				78 10 = enumerator.Current;
				this.ValidateNull(10);
			}
			return;
		}
		IL_306:
		this.CaptureTokenValue(this.GetScopeSchemas());
		foreach (78 11 in this.GetScopeSchemas())
		{
			this.ValidateRequiredProperties(11);
		}
		this.PopScope();
		return;
		IL_3BD:
		throw new ArgumentOutOfRangeException();
	}

	// Token: 0x06000F27 RID: 3879 RVA: 0x00033D80 File Offset: 0x00031F80
	private void CaptureTokenValue(IList<78> 1)
	{
		foreach (898.900 2 in this.stack)
		{
			bool flag = 2.GetTokenType() == 705.Array && 2.IsUniqueArray() && 2.GetArrayItemCount() > 0;
			if (flag || 5.Any(new Func<78, bool>(898.899.Instance.HasEnumValues)))
			{
				if (2.GetTokenWriter() == null)
				{
					if (169.IsEndToken(this.innerReader.GetTokenType()))
					{
						continue;
					}
					2.SetTokenWriter(new 124());
				}
				2.GetTokenWriter().WriteToken(this.innerReader, false);
				if (2.GetTokenWriter().GetTop() == 0 && this.innerReader.GetTokenType() != 216.PropertyName)
				{
					226 3 = 2.GetTokenWriter().Method11875();
					2.SetTokenWriter(null);
					if (flag)
					{
						if (2.GetArrayTokens().Contains(3, 226.EqualityComparer))
						{
							this.ReportError("Non-unique array item at index {0}.".Method6825(CultureInfo.InvariantCulture, 2.GetArrayItemCount() - 1), 2.GetSchemas().First(new Func<78, bool>(898.899.Instance.HasUniqueItems)));
						}
						2.GetArrayTokens().Add(3);
					}
					else if (5.Any((78 1) => 1.GetEnumValues() != null))
					{
						foreach (78 4 in 5)
						{
							if (4.GetEnumValues() != null && !4.GetEnumValues().Method3172(3, 226.EqualityComparer))
							{
								StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture);
								3.WriteTo(new 168(stringWriter), Array.Empty<214>());
								this.ReportError("Value {0} is not defined in enum.".Method6825(CultureInfo.InvariantCulture, stringWriter.ToString()), 4);
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06000F28 RID: 3880 RVA: 0x00033FB4 File Offset: 0x000321B4
	private void ValidateRequiredProperties(78 1)
	{
		if (1 != null)
		{
			Dictionary<string, bool> requiredProperties = this.currentScope.GetRequiredProperties();
			if (requiredProperties != null && requiredProperties.Values.Any(new Func<bool, bool>(898.899.Instance.IsNotSeen)))
			{
				IEnumerable<string> values = requiredProperties.Where(new Func<KeyValuePair<string, bool>, bool>(898.899.Instance.IsPropertyMissing)).Select(new Func<KeyValuePair<string, bool>, string>(898.899.Instance.GetPropertyName));
				this.ReportError("Required properties are missing from object: {0}.".Method6825(CultureInfo.InvariantCulture, string.Join(", ", values)), 1);
			}
		}
	}

	// Token: 0x06000F29 RID: 3881 RVA: 0x00034040 File Offset: 0x00032240
	private void ValidateArrayItemCount(78 1)
	{
		if (1 != null)
		{
			int arrayItemCount = this.currentScope.GetArrayItemCount();
			if (1.GetMaximumItems() != null)
			{
				int num = arrayItemCount;
				int? num2 = 1.GetMaximumItems();
				if (num > num2.GetValueOrDefault() & num2 != null)
				{
					this.ReportError("Array item count {0} exceeds maximum count of {1}.".Method6825(CultureInfo.InvariantCulture, arrayItemCount, 1.GetMaximumItems()), 1);
				}
			}
			if (1.GetMinimumItems() != null)
			{
				int num3 = arrayItemCount;
				int? num2 = 1.GetMinimumItems();
				if (num3 < num2.GetValueOrDefault() & num2 != null)
				{
					this.ReportError("Array item count {0} is less than minimum count of {1}.".Method6825(CultureInfo.InvariantCulture, arrayItemCount, 1.GetMinimumItems()), 1);
				}
			}
		}
	}

	// Token: 0x06000F2A RID: 3882 RVA: 0x00034103 File Offset: 0x00032303
	private void ValidateNull(78 1)
	{
		if (1 != null && this.ValidateType(1, 235.Null))
		{
			this.ValidateDisallowedType(1);
		}
	}

	// Token: 0x06000F2B RID: 3883 RVA: 0x0003411A File Offset: 0x0003231A
	private void ValidateBoolean(78 1)
	{
		if (1 != null && this.ValidateType(1, 235.Boolean))
		{
			this.ValidateDisallowedType(1);
		}
	}

	// Token: 0x06000F2C RID: 3884 RVA: 0x00034130 File Offset: 0x00032330
	private void ValidateString(78 1)
	{
		if (1 == null || !this.ValidateType(1, 235.String))
		{
			return;
		}
		this.ValidateDisallowedType(1);
		string text = this.innerReader.GetValue().ToString();
		if (1.GetMaximumLength() != null)
		{
			int length = text.Length;
			int? num = 1.GetMaximumLength();
			if (length > num.GetValueOrDefault() & num != null)
			{
				this.ReportError("String '{0}' exceeds maximum length of {1}.".Method6825(CultureInfo.InvariantCulture, text, 1.GetMaximumLength()), 1);
			}
		}
		if (1.GetMinimumLength() != null)
		{
			int length2 = text.Length;
			int? num = 1.GetMinimumLength();
			if (length2 < num.GetValueOrDefault() & num != null)
			{
				this.ReportError("String '{0}' is less than minimum length of {1}.".Method6825(CultureInfo.InvariantCulture, text, 1.GetMinimumLength()), 1);
			}
		}
		if (1.GetPatterns() == null)
		{
			return;
		}
		foreach (string text2 in 1.GetPatterns())
		{
			if (!Regex.IsMatch(text, text2))
			{
				this.ReportError("String '{0}' does not match regex pattern '{1}'.".Method6825(CultureInfo.InvariantCulture, text, text2), 1);
			}
		}
	}

	// Token: 0x06000F2D RID: 3885 RVA: 0x0003426C File Offset: 0x0003246C
	private void ValidateInteger(78 1)
	{
		if (1 == null || !this.ValidateType(1, 235.Integer))
		{
			return;
		}
		this.ValidateDisallowedType(1);
		object value = this.innerReader.GetValue();
		if (1.GetNullable4149_5314() != null)
		{
			if (233.Method14358(705.Integer, value, 1.GetNullable4149_5314()) > 0)
			{
				this.ReportError("Integer {0} exceeds maximum value of {1}.".Method6825(CultureInfo.InvariantCulture, value, 1.GetNullable4149_5314()), 1);
			}
			if (1.GetExclusiveMaximum() && 233.Method14358(705.Integer, value, 1.GetNullable4149_5314()) == 0)
			{
				this.ReportError("Integer {0} equals maximum value of {1} and exclusive maximum is true.".Method6825(CultureInfo.InvariantCulture, value, 1.GetNullable4149_5314()), 1);
			}
		}
		if (1.GetNullable4148_5312() != null)
		{
			if (233.Method14358(705.Integer, value, 1.GetNullable4148_5312()) < 0)
			{
				this.ReportError("Integer {0} is less than minimum value of {1}.".Method6825(CultureInfo.InvariantCulture, value, 1.GetNullable4148_5312()), 1);
			}
			if (1.GetExclusiveMinimum() && 233.Method14358(705.Integer, value, 1.GetNullable4148_5312()) == 0)
			{
				this.ReportError("Integer {0} equals minimum value of {1} and exclusive minimum is true.".Method6825(CultureInfo.InvariantCulture, value, 1.GetNullable4148_5312()), 1);
			}
		}
		if (1.GetNullable4147_5310() != null)
		{
			bool flag;
			if (value is BigInteger)
			{
				BigInteger bigInteger = (BigInteger)value;
				flag = (Math.Abs(1.GetNullable4147_5310().Value - Math.Truncate(1.GetNullable4147_5310().Value)).Equals(0.0) ? (bigInteger % new BigInteger(1.GetNullable4147_5310().Value) != 0L) : (bigInteger != 0L));
			}
			else
			{
				flag = !898.IsNearZero((double)Convert.ToInt64(value, CultureInfo.InvariantCulture) % 1.GetNullable4147_5310().GetValueOrDefault());
			}
			if (flag)
			{
				this.ReportError("Integer {0} is not evenly divisible by {1}.".Method6825(CultureInfo.InvariantCulture, 77.Method5202(value), 1.GetNullable4147_5310()), 1);
			}
		}
	}

	// Token: 0x06000F2E RID: 3886 RVA: 0x00034478 File Offset: 0x00032678
	private void ValidateArrayItem()
	{
		if (this.currentScope == null || this.currentScope.GetTokenType() != 705.Array)
		{
			return;
		}
		898.900 <<EMPTY_NAME>> = this.currentScope;
		int arrayItemCount = <<EMPTY_NAME>>.GetArrayItemCount();
		<<EMPTY_NAME>>.SetArrayItemCount(arrayItemCount + 1);
		foreach (78 2 in this.GetScopeSchemas())
		{
			if (2 != null && 2.GetPositionalItemsValidation() && !2.GetAllowAdditionalItems() && (2.GetItems() == null || this.currentScope.GetArrayItemCount() - 1 >= 2.GetItems().Count))
			{
				this.ReportError("Index {0} has not been defined and the schema does not allow additional items.".Method6825(CultureInfo.InvariantCulture, this.currentScope.GetArrayItemCount()), 2);
			}
		}
	}

	// Token: 0x06000F2F RID: 3887 RVA: 0x00034548 File Offset: 0x00032748
	private void ValidateFloat(78 1)
	{
		if (1 == null || !this.ValidateType(1, 235.Float))
		{
			return;
		}
		this.ValidateDisallowedType(1);
		double num = Convert.ToDouble(this.innerReader.GetValue(), CultureInfo.InvariantCulture);
		if (1.GetNullable4149_5314() != null)
		{
			double num2 = num;
			double? num3 = 1.GetNullable4149_5314();
			if (num2 > num3.GetValueOrDefault() & num3 != null)
			{
				this.ReportError("Float {0} exceeds maximum value of {1}.".Method6825(CultureInfo.InvariantCulture, 77.Method5202(num), 1.GetNullable4149_5314()), 1);
			}
			if (1.GetExclusiveMaximum())
			{
				double num4 = num;
				num3 = 1.GetNullable4149_5314();
				if (num4 == num3.GetValueOrDefault() & num3 != null)
				{
					this.ReportError("Float {0} equals maximum value of {1} and exclusive maximum is true.".Method6825(CultureInfo.InvariantCulture, 77.Method5202(num), 1.GetNullable4149_5314()), 1);
				}
			}
		}
		if (1.GetNullable4148_5312() != null)
		{
			double num5 = num;
			double? num3 = 1.GetNullable4148_5312();
			if (num5 < num3.GetValueOrDefault() & num3 != null)
			{
				this.ReportError("Float {0} is less than minimum value of {1}.".Method6825(CultureInfo.InvariantCulture, 77.Method5202(num), 1.GetNullable4148_5312()), 1);
			}
			if (1.GetExclusiveMinimum())
			{
				double num6 = num;
				num3 = 1.GetNullable4148_5312();
				if (num6 == num3.GetValueOrDefault() & num3 != null)
				{
					this.ReportError("Float {0} equals minimum value of {1} and exclusive minimum is true.".Method6825(CultureInfo.InvariantCulture, 77.Method5202(num), 1.GetNullable4148_5312()), 1);
				}
			}
		}
		if (1.GetNullable4147_5310() != null && !898.IsNearZero(898.FloatModulo(num, 1.GetNullable4147_5310().GetValueOrDefault())))
		{
			this.ReportError("Float {0} is not evenly divisible by {1}.".Method6825(CultureInfo.InvariantCulture, 77.Method5202(num), 1.GetNullable4147_5310()), 1);
		}
	}

	// Token: 0x06000F30 RID: 3888 RVA: 0x00034710 File Offset: 0x00032910
	private static double FloatModulo(double 1, double 2)
	{
		return 1 - Math.Floor(1 / 2) * 2;
	}

	// Token: 0x06000F31 RID: 3889 RVA: 0x0003471E File Offset: 0x0003291E
	private static bool IsNearZero(double 1)
	{
		return Math.Abs(1) < 4.440892098500626E-15;
	}

	// Token: 0x06000F32 RID: 3890 RVA: 0x00034734 File Offset: 0x00032934
	private void ValidatePropertyName(78 1)
	{
		if (1 != null)
		{
			string text = Convert.ToString(this.innerReader.GetValue(), CultureInfo.InvariantCulture);
			if (this.currentScope.GetRequiredProperties().ContainsKey(text))
			{
				this.currentScope.GetRequiredProperties()[text] = true;
			}
			if (!1.GetAllowAdditionalProperties() && !this.IsPropertyDefined(1, text))
			{
				this.ReportError("Property '{0}' has not been defined and the schema does not allow additional properties.".Method6825(CultureInfo.InvariantCulture, text), 1);
			}
			this.currentScope.SetCurrentPropertyName(text);
		}
	}

	// Token: 0x06000F33 RID: 3891 RVA: 0x000347B4 File Offset: 0x000329B4
	private bool IsPropertyDefined(78 1, string 2)
	{
		if (1.GetProperties() != null && 1.GetProperties().ContainsKey(2))
		{
			return true;
		}
		if (1.GetPatternProperties() != null)
		{
			foreach (string pattern in 1.GetPatternProperties().Keys)
			{
				if (Regex.IsMatch(2, pattern))
				{
					return true;
				}
			}
			return false;
		}
		return false;
	}

	// Token: 0x06000F34 RID: 3892 RVA: 0x00034830 File Offset: 0x00032A30
	private bool IsArraySchema(78 1)
	{
		return 1 == null || this.ValidateType(1, 235.Array);
	}

	// Token: 0x06000F35 RID: 3893 RVA: 0x00034840 File Offset: 0x00032A40
	private bool IsObjectSchema(78 1)
	{
		return 1 == null || this.ValidateType(1, 235.Object);
	}

	// Token: 0x06000F36 RID: 3894 RVA: 0x00034850 File Offset: 0x00032A50
	private bool ValidateType(78 1, 235 2)
	{
		if (!155.Method10028(new 235?(1.GetSchemaType()), 2))
		{
			this.ReportError("Invalid type. Expected {0} but got {1}.".Method6825(CultureInfo.InvariantCulture, 1.GetSchemaType(), 2), 1);
			return false;
		}
		return true;
	}

	// Token: 0x06000F37 RID: 3895 RVA: 0x00034890 File Offset: 0x00032A90
	private bool InnerReaderHasLineInfo()
	{
		99 <<EMPTY_NAME>> = this.innerReader as 99;
		return <<EMPTY_NAME>> != null && <<EMPTY_NAME>>.HasLineInfo();
	}

	// Token: 0x06000F38 RID: 3896 RVA: 0x000348B4 File Offset: 0x00032AB4
	bool 99.HasLineInfo()
	{
		return this.InnerReaderHasLineInfo();
	}

	// Token: 0x06000F39 RID: 3897 RVA: 0x000348BC File Offset: 0x00032ABC
	private int InnerReaderLineNumber()
	{
		99 <<EMPTY_NAME>> = this.innerReader as 99;
		if (<<EMPTY_NAME>> == null)
		{
			return 0;
		}
		return <<EMPTY_NAME>>.GetLineNumber();
	}

	// Token: 0x06000F3A RID: 3898 RVA: 0x000348E0 File Offset: 0x00032AE0
	int 99.GetLineNumber()
	{
		return this.InnerReaderLineNumber();
	}

	// Token: 0x06000F3B RID: 3899 RVA: 0x000348E8 File Offset: 0x00032AE8
	private int InnerReaderLinePosition()
	{
		99 <<EMPTY_NAME>> = this.innerReader as 99;
		if (<<EMPTY_NAME>> == null)
		{
			return 0;
		}
		return <<EMPTY_NAME>>.GetLinePosition();
	}

	// Token: 0x06000F3C RID: 3900 RVA: 0x0003490C File Offset: 0x00032B0C
	int 99.GetLinePosition()
	{
		return this.InnerReaderLinePosition();
	}

	// Token: 0x04000751 RID: 1873
	private readonly 139 innerReader;

	// Token: 0x04000752 RID: 1874
	private readonly Stack<898.900> stack;

	// Token: 0x04000753 RID: 1875
	private 529 schema;

	// Token: 0x04000754 RID: 1876
	private 78 currentSchema;

	// Token: 0x04000755 RID: 1877
	private 898.900 currentScope;

	// Token: 0x04000756 RID: 1878
	private 766 validationEventHandler;

	// Token: 0x04000757 RID: 1879
	private static readonly IList<78> emptySchemas = new List<78>();

	// Token: 0x020001E0 RID: 480
	[Serializable]
	public sealed class 899
	{
		// Token: 0x06000F3E RID: 3902 RVA: 0x00034920 File Offset: 0x00032B20
		internal bool HasEnumValues(78 1)
		{
			return 1.GetEnumValues() != null;
		}

		// Token: 0x06000F3F RID: 3903 RVA: 0x0003492B File Offset: 0x00032B2B
		internal bool HasUniqueItems(78 1)
		{
			return 1.GetUniqueItems();
		}

		// Token: 0x06000F40 RID: 3904 RVA: 0x00034920 File Offset: 0x00032B20
		internal bool Method1292(78 1)
		{
			return 1.GetEnumValues() != null;
		}

		// Token: 0x06000F41 RID: 3905 RVA: 0x00034933 File Offset: 0x00032B33
		internal bool IsNotSeen(bool 1)
		{
			return !1;
		}

		// Token: 0x06000F42 RID: 3906 RVA: 0x00034939 File Offset: 0x00032B39
		internal bool IsPropertyMissing(KeyValuePair<string, bool> 1)
		{
			return !1.Value;
		}

		// Token: 0x06000F43 RID: 3907 RVA: 0x00034945 File Offset: 0x00032B45
		internal string GetPropertyName(KeyValuePair<string, bool> 1)
		{
			return 1.Key;
		}

		// Token: 0x04000758 RID: 1880
		public static readonly 898.899 Instance = new 898.899();

		// Token: 0x04000759 RID: 1881
		public static Func<78, bool> func;

		// Token: 0x0400075A RID: 1882
		public static Func<78, bool> func2;

		// Token: 0x0400075B RID: 1883
		public static Func<78, bool> func3;

		// Token: 0x0400075C RID: 1884
		public static Func<bool, bool> func4;

		// Token: 0x0400075D RID: 1885
		public static Func<KeyValuePair<string, bool>, bool> func5;

		// Token: 0x0400075E RID: 1886
		public static Func<KeyValuePair<string, bool>, string> func6;
	}

	// Token: 0x020001E1 RID: 481
	public sealed class 900
	{
		// Token: 0x06000F46 RID: 3910 RVA: 0x0003495C File Offset: 0x00032B5C
		public 900(705 1, IList<78> 2)
		{
			this.tokenType = 3;
			this.schemas = 2;
			this.requiredProperties = 2.SelectMany(new Func<78, IEnumerable<string>>(this.GetRequiredPropertyNames)).Distinct<string>().ToDictionary((string 1) => 1, new Func<string, bool>(898.900.901.Instance.ReturnFalse));
			if (3 == 705.Array && 2.Any(new Func<78, bool>(898.900.901.Instance.HasUniqueItems)))
			{
				this.isUniqueArray = true;
				this.arrayTokens = new List<226>();
			}
		}

		// Token: 0x06000F47 RID: 3911 RVA: 0x000349FC File Offset: 0x00032BFC
		public string GetCurrentPropertyName()
		{
			return this.currentPropertyName;
		}

		// Token: 0x06000F48 RID: 3912 RVA: 0x00034A04 File Offset: 0x00032C04
		public void SetCurrentPropertyName(string 1)
		{
			this.currentPropertyName = 1;
		}

		// Token: 0x06000F49 RID: 3913 RVA: 0x00034A0D File Offset: 0x00032C0D
		public int GetArrayItemCount()
		{
			return this.arrayItemCount;
		}

		// Token: 0x06000F4A RID: 3914 RVA: 0x00034A15 File Offset: 0x00032C15
		public void SetArrayItemCount(int 1)
		{
			this.arrayItemCount = 1;
		}

		// Token: 0x06000F4B RID: 3915 RVA: 0x00034A1E File Offset: 0x00032C1E
		public bool IsUniqueArray()
		{
			return this.isUniqueArray;
		}

		// Token: 0x06000F4C RID: 3916 RVA: 0x00034A26 File Offset: 0x00032C26
		public IList<226> GetArrayTokens()
		{
			return this.arrayTokens;
		}

		// Token: 0x06000F4D RID: 3917 RVA: 0x00034A2E File Offset: 0x00032C2E
		public 124 GetTokenWriter()
		{
			return this.tokenWriter;
		}

		// Token: 0x06000F4E RID: 3918 RVA: 0x00034A36 File Offset: 0x00032C36
		public void SetTokenWriter(124 1)
		{
			this.tokenWriter = 1;
		}

		// Token: 0x06000F4F RID: 3919 RVA: 0x00034A3F File Offset: 0x00032C3F
		public IList<78> GetSchemas()
		{
			return this.schemas;
		}

		// Token: 0x06000F50 RID: 3920 RVA: 0x00034A47 File Offset: 0x00032C47
		public Dictionary<string, bool> GetRequiredProperties()
		{
			return this.requiredProperties;
		}

		// Token: 0x06000F51 RID: 3921 RVA: 0x00034A4F File Offset: 0x00032C4F
		public 705 GetTokenType()
		{
			return this.tokenType;
		}

		// Token: 0x06000F52 RID: 3922 RVA: 0x00034A58 File Offset: 0x00032C58
		private IEnumerable<string> GetRequiredPropertyNames(78 1)
		{
			if (((2 != null) ? 2.GetProperties() : null) == null)
			{
				return Enumerable.Empty<string>();
			}
			return 2.GetProperties().Where(new Func<KeyValuePair<string, 78>, bool>(898.900.901.Instance.IsRequiredProperty)).Select(delegate(KeyValuePair<string, 78> 1)
			{
				KeyValuePair<string, 78> keyValuePair = 1;
				return keyValuePair.Key;
			});
		}

		// Token: 0x0400075F RID: 1887
		private readonly 705 tokenType;

		// Token: 0x04000760 RID: 1888
		private readonly IList<78> schemas;

		// Token: 0x04000761 RID: 1889
		private readonly Dictionary<string, bool> requiredProperties;

		// Token: 0x04000762 RID: 1890
		private string currentPropertyName;

		// Token: 0x04000763 RID: 1891
		private int arrayItemCount;

		// Token: 0x04000764 RID: 1892
		private readonly bool isUniqueArray;

		// Token: 0x04000765 RID: 1893
		private readonly IList<226> arrayTokens;

		// Token: 0x04000766 RID: 1894
		private 124 tokenWriter;

		// Token: 0x020001E2 RID: 482
		[Serializable]
		public sealed class 901
		{
			// Token: 0x06000F53 RID: 3923 RVA: 0x00022391 File Offset: 0x00020591
			internal string Identity(string 1)
			{
				return 1;
			}

			// Token: 0x06000F54 RID: 3924 RVA: 0x0000FF75 File Offset: 0x0000E175
			internal bool ReturnFalse(string 1)
			{
				return false;
			}

			// Token: 0x06000F55 RID: 3925 RVA: 0x0003492B File Offset: 0x00032B2B
			internal bool HasUniqueItems(78 1)
			{
				return 1.GetUniqueItems();
			}

			// Token: 0x06000F56 RID: 3926 RVA: 0x00034AB8 File Offset: 0x00032CB8
			internal bool IsRequiredProperty(KeyValuePair<string, 78> 1)
			{
				return 1.Value.GetIsRequired();
			}

			// Token: 0x06000F57 RID: 3927 RVA: 0x00034AC6 File Offset: 0x00032CC6
			internal string GetPropertyName(KeyValuePair<string, 78> 1)
			{
				return 1.Key;
			}

			// Token: 0x04000767 RID: 1895
			public static readonly 898.900.901 Instance = new 898.900.901();

			// Token: 0x04000768 RID: 1896
			public static Func<string, string> func;

			// Token: 0x04000769 RID: 1897
			public static Func<string, bool> func2;

			// Token: 0x0400076A RID: 1898
			public static Func<78, bool> func3;

			// Token: 0x0400076B RID: 1899
			public static Func<KeyValuePair<string, 78>, bool> func4;

			// Token: 0x0400076C RID: 1900
			public static Func<KeyValuePair<string, 78>, string> func5;
		}
	}
}
