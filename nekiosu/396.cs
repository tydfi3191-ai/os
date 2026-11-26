using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Runtime.InteropServices;

// Token: 0x020000F2 RID: 242
[241(0)]
[242(1)]
[ComVisible(false)]
public sealed class 396 : 214
{
	// Token: 0x0600085D RID: 2141 RVA: 0x0001C700 File Offset: 0x0001A900
	public override void WriteJson(173 1, [241(2)] object 2, 158 3)
	{
		if (2 == null)
		{
			1.WriteNull();
			return;
		}
		DataTable dataTable = (DataTable)2;
		65 4 = 3.Method1759() as 65;
		1.WriteStartArray();
		foreach (object obj in dataTable.Rows)
		{
			DataRow dataRow = (DataRow)obj;
			1.WriteStartObject();
			foreach (object obj2 in dataRow.Table.Columns)
			{
				DataColumn dataColumn = (DataColumn)obj2;
				object obj3 = dataRow[dataColumn];
				if (3.Method1763() != (240)1 || (obj3 != null && obj3 != DBNull.Value))
				{
					1.WritePropertyName((4 != null) ? 4.GetResolvedPropertyName(dataColumn.ColumnName) : dataColumn.ColumnName);
					3.Method3848(1, obj3);
				}
			}
			1.WriteEndObject();
		}
		1.WriteEndArray();
	}

	// Token: 0x0600085E RID: 2142 RVA: 0x0001C820 File Offset: 0x0001AA20
	[return: 241(2)]
	public override object ReadJson(139 1, Type 2, [241(2)] object 3, 158 4)
	{
		if (1.GetTokenType() == 216.Null)
		{
			return null;
		}
		DataTable dataTable = 3 as DataTable;
		if (dataTable == null)
		{
			dataTable = ((2 == typeof(DataTable)) ? new DataTable() : ((DataTable)Activator.CreateInstance(2)));
		}
		if (1.GetTokenType() == 216.PropertyName)
		{
			dataTable.TableName = (string)1.GetValue();
			1.Method2843();
			if (1.GetTokenType() == 216.Null)
			{
				return dataTable;
			}
		}
		if (1.GetTokenType() != 216.StartArray)
		{
			throw 364.Method1687(1, "Unexpected JSON token when reading DataTable. Expected StartArray, got {0}.".Method6825(CultureInfo.InvariantCulture, 1.GetTokenType()));
		}
		1.Method2843();
		while (1.GetTokenType() != 216.EndArray)
		{
			396.Method2506(1, dataTable, 4);
			1.Method2843();
		}
		return dataTable;
	}

	// Token: 0x0600085F RID: 2143 RVA: 0x0001C8E0 File Offset: 0x0001AAE0
	private static void Method2506(139 1, DataTable 2, 158 3)
	{
		DataRow dataRow = 2.NewRow();
		1.Method2843();
		while (1.GetTokenType() == 216.PropertyName)
		{
			string text = (string)1.GetValue();
			1.Method2843();
			DataColumn dataColumn = 2.Columns[text];
			if (dataColumn == null)
			{
				Type dataType = 396.Method2507(1);
				dataColumn = new DataColumn(text, dataType);
				2.Columns.Add(dataColumn);
			}
			if (dataColumn.DataType == typeof(DataTable))
			{
				if (1.GetTokenType() == 216.StartArray)
				{
					1.Method2843();
				}
				DataTable dataTable = new DataTable();
				while (1.GetTokenType() != 216.EndArray)
				{
					396.Method2506(1, dataTable, 3);
					1.Method2843();
				}
				dataRow[text] = dataTable;
			}
			else if (dataColumn.DataType.IsArray && dataColumn.DataType != typeof(byte[]))
			{
				if (1.GetTokenType() == 216.StartArray)
				{
					1.Method2843();
				}
				List<object> list = new List<object>();
				while (1.GetTokenType() != 216.EndArray)
				{
					list.Add(1.GetValue());
					1.Method2843();
				}
				Array array = Array.CreateInstance(dataColumn.DataType.GetElementType(), list.Count);
				((ICollection)list).CopyTo(array, 0);
				dataRow[text] = array;
			}
			else
			{
				object value = (1.GetValue() != null) ? (3.Method3841(1, dataColumn.DataType) ?? DBNull.Value) : DBNull.Value;
				dataRow[text] = value;
			}
			1.Method2843();
		}
		dataRow.EndEdit();
		2.Rows.Add(dataRow);
	}

	// Token: 0x06000860 RID: 2144 RVA: 0x0001CA70 File Offset: 0x0001AC70
	private static Type Method2507(139 1)
	{
		216 tokenType = 1.GetTokenType();
		switch (tokenType)
		{
		case 216.StartArray:
			1.Method2843();
			if (1.GetTokenType() == 216.StartObject)
			{
				return typeof(DataTable);
			}
			return 396.Method2507(1).MakeArrayType();
		case 216.Integer:
		case 216.Float:
		case 216.String:
		case 216.Boolean:
		case 216.Date:
		case 216.Bytes:
			return 1.GetValueType();
		case 216.Null:
		case 216.Undefined:
		case 216.EndArray:
			return typeof(string);
		}
		throw 364.Method1687(1, "Unexpected JSON token when reading DataTable: {0}".Method6825(CultureInfo.InvariantCulture, tokenType));
	}

	// Token: 0x06000861 RID: 2145 RVA: 0x0001CB21 File Offset: 0x0001AD21
	public override bool CanConvert(Type 1)
	{
		return typeof(DataTable).IsAssignableFrom(1);
	}
}
