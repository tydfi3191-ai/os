using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

// Token: 0x02000635 RID: 1589
public sealed partial class 2309 : 1488
{
	// Token: 0x0600302F RID: 12335 RVA: 0x00112051 File Offset: 0x00110251
	public 2309()
	{
		this.17();
	}

	// Token: 0x06003030 RID: 12336 RVA: 0x0011205F File Offset: 0x0011025F
	protected override void OnShown(EventArgs 1)
	{
		this.11.SelectedIndex = 0;
		base.OnShown(1);
	}

	// Token: 0x06003031 RID: 12337 RVA: 0x00112074 File Offset: 0x00110274
	private void 13(object 1, EventArgs 2)
	{
		if (this.17.ShowDialog() == DialogResult.OK)
		{
			this.8.Text = this.17.FileName;
		}
	}

	// Token: 0x06003032 RID: 12338 RVA: 0x0011209A File Offset: 0x0011029A
	private void 14(object 1, EventArgs 2)
	{
		this.11.Enabled = this.9.Checked;
	}

	// Token: 0x06003033 RID: 12339 RVA: 0x00110789 File Offset: 0x0010E989
	private void 15(object 1, EventArgs 2)
	{
		base.Close();
	}

	// Token: 0x06003034 RID: 12340 RVA: 0x001120B4 File Offset: 0x001102B4
	private void 16(object 1, EventArgs 2)
	{
		if (this.8.Text == string.Empty)
		{
			MessageBox.Show("Select a bms file first!");
			return;
		}
		2263 3 = 2263.4;
		if (this.14.Checked)
		{
			3.7.7();
		}
		if (!this.18.Checked)
		{
			3.6.15.Clear();
		}
		2272 4 = new 2272(3);
		4.6 = this.12.Checked;
		4.4 = this.13.Checked;
		4.5 = this.18.Checked;
		4.7 = this.9.Checked;
		if (4.1(this.8.Text, this.11.SelectedItem.ToString()))
		{
			4.Reset();
			base.Close();
			3.7.53(false, false, false, false);
			1662.SetMode(1677.Edit, true);
			return;
		}
		base.Close();
	}

	// Token: 0x06003036 RID: 12342 RVA: 0x001121D8 File Offset: 0x001103D8
	private void 17()
	{
		this.7 = new Button();
		this.8 = new TextBox();
		this.9 = new CheckBox();
		this.10 = new Label();
		this.11 = new ComboBox();
		this.12 = new CheckBox();
		this.13 = new CheckBox();
		this.14 = new CheckBox();
		this.15 = new Button();
		this.16 = new Button();
		this.17 = new OpenFileDialog();
		this.18 = new CheckBox();
		base.SuspendLayout();
		this.7.Location = new Point(11, 11);
		this.7.Name = "b_file";
		this.7.Size = new Size(75, 23);
		this.7.TabIndex = 0;
		this.7.Text = "Select file";
		this.7.UseVisualStyleBackColor = true;
		this.7.Click += this.13;
		this.8.BorderStyle = BorderStyle.FixedSingle;
		this.8.Location = new Point(92, 12);
		this.8.Name = "tb_file";
		this.8.ReadOnly = true;
		this.8.Size = new Size(244, 21);
		this.8.TabIndex = 1;
		this.9.AutoSize = true;
		this.9.Location = new Point(12, 48);
		this.9.Name = "cb_meta";
		this.9.Size = new Size(115, 21);
		this.9.TabIndex = 2;
		this.9.Text = "Override meta ";
		this.9.UseVisualStyleBackColor = true;
		this.9.CheckedChanged += this.14;
		this.10.AutoSize = true;
		this.10.Location = new Point(153, 49);
		this.10.Name = "label1";
		this.10.Size = new Size(74, 17);
		this.10.TabIndex = 3;
		this.10.Text = "File encode";
		this.11.DropDownStyle = ComboBoxStyle.DropDownList;
		this.11.Enabled = false;
		this.11.FormattingEnabled = true;
		this.11.Items.AddRange(new object[]
		{
			"utf-8",
			"gb2312",
			"big5",
			"shift_jis"
		});
		this.11.Location = new Point(233, 49);
		this.11.Name = "cb_encode";
		this.11.Size = new Size(103, 20);
		this.11.TabIndex = 4;
		this.12.AutoSize = true;
		this.12.Checked = true;
		this.12.CheckState = CheckState.Checked;
		this.12.Location = new Point(12, 79);
		this.12.Name = "cb_image";
		this.12.Size = new Size(193, 21);
		this.12.TabIndex = 5;
		this.12.Text = "Override background image";
		this.12.UseVisualStyleBackColor = true;
		this.13.AutoSize = true;
		this.13.Location = new Point(12, 112);
		this.13.Name = "cb_sample";
		this.13.Size = new Size(148, 21);
		this.13.TabIndex = 6;
		this.13.Text = "Ignore note samples";
		this.13.UseVisualStyleBackColor = true;
		this.14.AutoSize = true;
		this.14.Checked = true;
		this.14.CheckState = CheckState.Checked;
		this.14.Location = new Point(12, 183);
		this.14.Name = "cb_clear";
		this.14.Size = new Size(196, 21);
		this.14.TabIndex = 7;
		this.14.Text = "Clear all notes before import";
		this.14.UseVisualStyleBackColor = true;
		this.15.Location = new Point(12, 226);
		this.15.Name = "b_start";
		this.15.Size = new Size(215, 38);
		this.15.TabIndex = 8;
		this.15.Text = "Start";
		this.15.UseVisualStyleBackColor = true;
		this.15.Click += this.16;
		this.16.Location = new Point(244, 226);
		this.16.Name = "b_cancel";
		this.16.Size = new Size(93, 38);
		this.16.TabIndex = 9;
		this.16.Text = "Cancel";
		this.16.UseVisualStyleBackColor = true;
		this.16.Click += this.15;
		this.17.FileName = "openFileDialog1";
		this.17.Filter = "BMS file|*.bms;*.bme";
		this.18.AutoSize = true;
		this.18.Location = new Point(12, 144);
		this.18.Name = "cb_effect";
		this.18.Size = new Size(154, 21);
		this.18.TabIndex = 10;
		this.18.Text = "Ignore effect samples";
		this.18.UseVisualStyleBackColor = true;
		base.AcceptButton = this.15;
		base.AutoScaleDimensions = new SizeF(96f, 96f);
		base.AutoScaleMode = AutoScaleMode.Dpi;
		base.ClientSize = new Size(349, 282);
		base.Controls.Add(this.18);
		base.Controls.Add(this.16);
		base.Controls.Add(this.15);
		base.Controls.Add(this.14);
		base.Controls.Add(this.13);
		base.Controls.Add(this.12);
		base.Controls.Add(this.11);
		base.Controls.Add(this.10);
		base.Controls.Add(this.9);
		base.Controls.Add(this.8);
		base.Controls.Add(this.7);
		base.FormBorderStyle = FormBorderStyle.FixedSingle;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "ImportBMS";
		base.ShowIcon = false;
		base.ShowInTaskbar = false;
		base.SizeGripStyle = SizeGripStyle.Hide;
		base.StartPosition = FormStartPosition.CenterParent;
		this.Text = "Import from bms";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x040022BA RID: 8890
	private new Button 7;

	// Token: 0x040022BB RID: 8891
	private new TextBox 8;

	// Token: 0x040022BC RID: 8892
	private CheckBox 9;

	// Token: 0x040022BD RID: 8893
	private Label 10;

	// Token: 0x040022BE RID: 8894
	private new ComboBox 11;

	// Token: 0x040022BF RID: 8895
	private new CheckBox 12;

	// Token: 0x040022C0 RID: 8896
	private CheckBox 13;

	// Token: 0x040022C1 RID: 8897
	private CheckBox 14;

	// Token: 0x040022C2 RID: 8898
	private Button 15;

	// Token: 0x040022C3 RID: 8899
	private Button 16;

	// Token: 0x040022C4 RID: 8900
	private OpenFileDialog 17;

	// Token: 0x040022C5 RID: 8901
	private CheckBox 18;
}
