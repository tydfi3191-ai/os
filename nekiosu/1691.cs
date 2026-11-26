using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

// Token: 0x02000917 RID: 2327
public sealed partial class 1691 : 1730
{
	// Token: 0x06004249 RID: 16969 RVA: 0x0019C66A File Offset: 0x0019A86A
	public 1691(string 1, bool 2) : this(new Exception(1), 2)
	{
	}

	// Token: 0x0600424A RID: 16970 RVA: 0x0019C67C File Offset: 0x0019A87C
	public 1691(Exception 1, bool 2)
	{
		1691.1692 exceptionDialogClosure = new 1691.1692
		{
			1 = 3
		};
		1726.14();
		1691.7 = true;
		base.3();
		base.ControlAdded += this.21;
		base.ControlRemoved += this.22;
		this.24();
		StringBuilder stringBuilder = new StringBuilder();
		foreach (string text in exceptionDialogClosure.1.ToString().Split(new char[]
		{
			'\n'
		}))
		{
			if (text.Contains("Microsoft.Xna.Framework.Game.Tick"))
			{
				break;
			}
			stringBuilder.AppendLine(text.Trim(new char[]
			{
				'\r'
			}));
		}
		exceptionDialogClosure.3 = stringBuilder.ToString();
		this.14.Text = exceptionDialogClosure.3;
		exceptionDialogClosure.2 = new StackTrace(exceptionDialogClosure.1);
		if (!4)
		{
			return;
		}
		this.6 = new BackgroundWorker();
		this.6.DoWork += delegate(object 1, DoWorkEventArgs 2)
		{
			1618 5 = new 1618();
			StringBuilder stringBuilder2 = new StringBuilder();
			foreach (StackFrame stackFrame in 1342.2(exceptionDialogClosure.2.GetFrames()))
			{
				StringBuilder stringBuilder3 = stringBuilder2;
				string str = "METHOD ";
				MethodBase method = stackFrame.GetMethod();
				stringBuilder3.AppendLine(str + ((method != null) ? method.ToString() : null));
				StringBuilder stringBuilder4 = stringBuilder2;
				string str2 = "Module ";
				Module module = stackFrame.GetMethod().Module;
				stringBuilder4.AppendLine(str2 + ((module != null) ? module.ToString() : null));
				stringBuilder2.AppendLine("Il-Offset: " + stackFrame.GetILOffset().ToString() + " Jit-offset: " + stackFrame.GetNativeOffset().ToString());
				stringBuilder2.AppendLine("IL code ");
				stringBuilder2.AppendLine(1342.1(stackFrame.GetMethod()));
				stringBuilder2.AppendLine();
				MethodBody methodBody = stackFrame.GetMethod().GetMethodBody();
				List<ExceptionHandlingClause> list = (methodBody != null) ? new List<ExceptionHandlingClause>(methodBody.ExceptionHandlingClauses) : null;
				if (list != null && list.Count != 0)
				{
					stringBuilder2.AppendLine("possible caught exceptions:");
					foreach (ExceptionHandlingClause exceptionHandlingClause in list)
					{
						try
						{
							stringBuilder2.AppendLine(string.Format("catchType:{0}, Flags:{1}, HandlerLength:{2}, HandlerOffset:{3}, TryLength:{4}, TryOffset:{5}", new object[]
							{
								exceptionHandlingClause.CatchType,
								exceptionHandlingClause.Flags,
								exceptionHandlingClause.HandlerLength,
								exceptionHandlingClause.HandlerOffset,
								exceptionHandlingClause.TryLength,
								exceptionHandlingClause.TryOffset
							}));
						}
						catch
						{
							stringBuilder2.AppendLine("Unknown ExceptionType");
						}
					}
					stringBuilder2.AppendLine("ENDMETHOD");
					stringBuilder2.AppendLine();
				}
			}
			5.2 = stringBuilder2.ToString();
			5.3 = exceptionDialogClosure.3;
			5.4 = ((exceptionDialogClosure.1 != null) ? exceptionDialogClosure.1.GetType().ToString() : string.Empty);
			1619.1(5);
		};
		this.6.RunWorkerAsync();
	}

	// Token: 0x0600424B RID: 16971 RVA: 0x0019C7B6 File Offset: 0x0019A9B6
	private void 14(object 1, EventArgs 2)
	{
		1345.15(false, null);
		base.Close();
	}

	// Token: 0x0600424C RID: 16972 RVA: 0x0019C7C5 File Offset: 0x0019A9C5
	private void 15(object 1, EventArgs 2)
	{
		261.Start(1296.6 + "/forum/viewtopic.php?f=5&t=576");
	}

	// Token: 0x0600424D RID: 16973 RVA: 0x0019C7DC File Offset: 0x0019A9DC
	private void 16(object 1, FormClosingEventArgs 2)
	{
		if (2.CloseReason == CloseReason.UserClosing || 2.CloseReason == CloseReason.WindowsShutDown)
		{
			1345.16();
		}
	}

	// Token: 0x0600424E RID: 16974 RVA: 0x0019C7F5 File Offset: 0x0019A9F5
	private void 17(object 1, EventArgs 2)
	{
		this.14.Visible = !this.14.Visible;
	}

	// Token: 0x0600424F RID: 16975 RVA: 0x0019C810 File Offset: 0x0019AA10
	private void 18(object 1, EventArgs 2)
	{
		if (string.IsNullOrEmpty(this.14.SelectedText))
		{
			this.14.SelectAll();
		}
	}

	// Token: 0x06004250 RID: 16976 RVA: 0x0019C830 File Offset: 0x0019AA30
	private void 19(Control 1)
	{
		1.MouseLeave += this.23;
		1.ControlAdded += this.21;
		1.ControlRemoved += this.22;
		foreach (object obj in 1.Controls)
		{
			Control 2 = (Control)obj;
			this.19(2);
		}
	}

	// Token: 0x06004251 RID: 16977 RVA: 0x0019C8C0 File Offset: 0x0019AAC0
	private void 20(Control 1)
	{
		1.MouseLeave -= this.23;
		1.ControlAdded -= this.21;
		1.ControlRemoved -= this.22;
		foreach (object obj in 1.Controls)
		{
			Control 2 = (Control)obj;
			this.20(2);
		}
	}

	// Token: 0x06004252 RID: 16978 RVA: 0x0019C950 File Offset: 0x0019AB50
	private void 21(object 1, ControlEventArgs 2)
	{
		this.19(2.Control);
	}

	// Token: 0x06004253 RID: 16979 RVA: 0x0019C95E File Offset: 0x0019AB5E
	private void 22(object 1, ControlEventArgs 2)
	{
		this.20(2.Control);
	}

	// Token: 0x06004254 RID: 16980 RVA: 0x0019C96C File Offset: 0x0019AB6C
	private void 23(object 1, EventArgs 2)
	{
		if (!base.ClientRectangle.Contains(base.PointToClient(Cursor.Position)))
		{
			this.14.Visible = false;
		}
	}

	// Token: 0x06004256 RID: 16982 RVA: 0x0019C9C0 File Offset: 0x0019ABC0
	private void 24()
	{
		this.14 = new TextBox();
		this.13 = new Label();
		this.10 = new PictureBox();
		this.12 = new Panel();
		this.9 = new Button();
		this.11 = new Button();
		((ISupportInitialize)this.10).BeginInit();
		this.12.SuspendLayout();
		base.SuspendLayout();
		this.14.BackColor = Color.White;
		this.14.BorderStyle = BorderStyle.None;
		this.14.ForeColor = Color.Gray;
		this.14.Location = new Point(0, 87);
		this.14.Multiline = true;
		this.14.Name = "textBoxDetails";
		this.14.ReadOnly = true;
		this.14.Size = new Size(364, 374);
		this.14.TabIndex = 9;
		this.14.Visible = false;
		this.14.Click += this.18;
		this.13.BackColor = Color.Transparent;
		this.13.Dock = DockStyle.Top;
		this.13.Font = new Font("Segoe UI Semilight", 26.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.13.ForeColor = Color.FromArgb(40, 106, 151);
		this.13.Location = new Point(0, 0);
		this.13.Name = "label1";
		this.13.Size = new Size(364, 88);
		this.13.TabIndex = 8;
		this.13.Text = "nekiosu crashed";
		this.13.TextAlign = ContentAlignment.MiddleCenter;
		this.10.Anchor = AnchorStyles.Bottom;
		this.10.BackgroundImageLayout = ImageLayout.None;
		this.10.Image = 277.GetOsuCrashImage();
		this.10.Location = new Point(-7, 87);
		this.10.Name = "pippiBox";
		this.10.Size = new Size(375, 374);
		this.10.TabIndex = 4;
		this.10.TabStop = false;
		this.10.Click += this.17;
		this.12.BackColor = Color.FromArgb(85, 85, 85);
		this.12.Controls.Add(this.9);
		this.12.Controls.Add(this.11);
		this.12.Dock = DockStyle.Bottom;
		this.12.Location = new Point(0, 461);
		this.12.Name = "panel1";
		this.12.Size = new Size(364, 100);
		this.12.TabIndex = 7;
		this.9.FlatAppearance.BorderColor = Color.DimGray;
		this.9.FlatAppearance.BorderSize = 0;
		this.9.FlatAppearance.MouseDownBackColor = Color.FromArgb(61, 172, 220);
		this.9.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 127, 161);
		this.9.FlatStyle = FlatStyle.Flat;
		this.9.Font = new Font("Segoe UI", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.9.ForeColor = Color.White;
		this.9.Location = new Point(7, 14);
		this.9.Name = "buttonRestart";
		this.9.Size = new Size(350, 35);
		this.9.TabIndex = 2;
		this.9.Text = "restart osu!";
		this.9.UseVisualStyleBackColor = true;
		this.9.Click += this.14;
		this.11.FlatAppearance.BorderColor = Color.DimGray;
		this.11.FlatAppearance.BorderSize = 0;
		this.11.FlatStyle = FlatStyle.Flat;
		this.11.Font = new Font("Segoe UI", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.11.ForeColor = Color.White;
		this.11.Location = new Point(7, 57);
		this.11.Name = "buttonReport";
		this.11.Size = new Size(350, 35);
		this.11.TabIndex = 6;
		this.11.Text = "report an issue...";
		this.11.UseVisualStyleBackColor = true;
		this.11.Click += this.15;
		base.AutoScaleMode = AutoScaleMode.None;
		this.BackColor = Color.White;
		base.ClientSize = new Size(364, 561);
		base.Controls.Add(this.14);
		base.Controls.Add(this.13);
		base.Controls.Add(this.10);
		base.Controls.Add(this.12);
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "ErrorDialog";
		base.Opacity = 1.0;
		base.ShowIcon = false;
		base.SizeGripStyle = SizeGripStyle.Hide;
		base.StartPosition = FormStartPosition.CenterScreen;
		this.Text = "oh no!";
		base.FormClosing += this.16;
		base.MouseLeave += this.23;
		((ISupportInitialize)this.10).EndInit();
		this.12.ResumeLayout(false);
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x04003066 RID: 12390
	private BackgroundWorker 6;

	// Token: 0x04003067 RID: 12391
	public new static bool 7;

	// Token: 0x04003069 RID: 12393
	private Button 9;

	// Token: 0x0400306A RID: 12394
	private PictureBox 10;

	// Token: 0x0400306B RID: 12395
	private new Button 11;

	// Token: 0x0400306C RID: 12396
	private new Panel 12;

	// Token: 0x0400306D RID: 12397
	private Label 13;

	// Token: 0x0400306E RID: 12398
	private TextBox 14;

	// Token: 0x02000918 RID: 2328
	public sealed class 1692
	{
		// Token: 0x0400306F RID: 12399
		public Exception 1;

		// Token: 0x04003070 RID: 12400
		public StackTrace 2;

		// Token: 0x04003071 RID: 12401
		public string 3;
	}
}
