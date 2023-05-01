namespace FormBitrateEditor
{
    partial class FormEditor
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditor));
            this.bitrateTextBox = new System.Windows.Forms.TextBox();
            this.dbmTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.restoreBtn = new System.Windows.Forms.Button();
            this.aswOffBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.hevcBtn = new System.Windows.Forms.Button();
            this.dbrBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.perfHudOffBtn = new System.Windows.Forms.Button();
            this.perfHudOnBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.numslicesTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sharpenBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bitrateTextBox
            // 
            this.bitrateTextBox.Location = new System.Drawing.Point(252, 23);
            this.bitrateTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.bitrateTextBox.Name = "bitrateTextBox";
            this.bitrateTextBox.Size = new System.Drawing.Size(50, 20);
            this.bitrateTextBox.TabIndex = 0;
            this.bitrateTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            this.bitrateTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.bitrateTextBox.Leave += new System.EventHandler(this.bitrateTextBox_Leave);
            // 
            // dbmTextBox
            // 
            this.dbmTextBox.Location = new System.Drawing.Point(252, 127);
            this.dbmTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.dbmTextBox.Name = "dbmTextBox";
            this.dbmTextBox.Size = new System.Drawing.Size(50, 20);
            this.dbmTextBox.TabIndex = 3;
            this.dbmTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            this.dbmTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.dbmTextBox.Leave += new System.EventHandler(this.dbmTextBox_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bitrate (Mbps)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(48, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Dynamic Bitrate Max (Mbps)";
            // 
            // restoreBtn
            // 
            this.restoreBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restoreBtn.Location = new System.Drawing.Point(22, 333);
            this.restoreBtn.Margin = new System.Windows.Forms.Padding(2);
            this.restoreBtn.Name = "restoreBtn";
            this.restoreBtn.Size = new System.Drawing.Size(326, 70);
            this.restoreBtn.TabIndex = 9;
            this.restoreBtn.Text = "Restore All\r\n(delete BitrateMbps, HEVC, DBR, DBRMax, numSlices, LinkSharpeningEna" +
    "bled registry values)";
            this.restoreBtn.UseVisualStyleBackColor = true;
            this.restoreBtn.Click += new System.EventHandler(this.restoreBtn_Click);
            // 
            // aswOffBtn
            // 
            this.aswOffBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aswOffBtn.Location = new System.Drawing.Point(117, 286);
            this.aswOffBtn.Margin = new System.Windows.Forms.Padding(2);
            this.aswOffBtn.Name = "aswOffBtn";
            this.aswOffBtn.Size = new System.Drawing.Size(138, 34);
            this.aswOffBtn.TabIndex = 8;
            this.aswOffBtn.Text = "ASW off";
            this.aswOffBtn.UseVisualStyleBackColor = true;
            this.aswOffBtn.Click += new System.EventHandler(this.aswOffBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(187, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "HEVC";
            // 
            // hevcBtn
            // 
            this.hevcBtn.BackColor = System.Drawing.Color.Transparent;
            this.hevcBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.hevcBtn.FlatAppearance.BorderSize = 0;
            this.hevcBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hevcBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hevcBtn.Location = new System.Drawing.Point(252, 51);
            this.hevcBtn.Margin = new System.Windows.Forms.Padding(0);
            this.hevcBtn.Name = "hevcBtn";
            this.hevcBtn.Size = new System.Drawing.Size(44, 33);
            this.hevcBtn.TabIndex = 1;
            this.hevcBtn.UseVisualStyleBackColor = false;
            this.hevcBtn.Click += new System.EventHandler(this.hevcBtn_Click);
            // 
            // dbrBtn
            // 
            this.dbrBtn.BackColor = System.Drawing.Color.Transparent;
            this.dbrBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.dbrBtn.FlatAppearance.BorderSize = 0;
            this.dbrBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dbrBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbrBtn.Location = new System.Drawing.Point(252, 84);
            this.dbrBtn.Margin = new System.Windows.Forms.Padding(0);
            this.dbrBtn.Name = "dbrBtn";
            this.dbrBtn.Size = new System.Drawing.Size(44, 33);
            this.dbrBtn.TabIndex = 2;
            this.dbrBtn.UseVisualStyleBackColor = false;
            this.dbrBtn.Click += new System.EventHandler(this.dbrBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(125, 91);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Dynamic Bitrate";
            // 
            // perfHudOffBtn
            // 
            this.perfHudOffBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perfHudOffBtn.Location = new System.Drawing.Point(94, 239);
            this.perfHudOffBtn.Margin = new System.Windows.Forms.Padding(2);
            this.perfHudOffBtn.Name = "perfHudOffBtn";
            this.perfHudOffBtn.Size = new System.Drawing.Size(87, 34);
            this.perfHudOffBtn.TabIndex = 6;
            this.perfHudOffBtn.Text = "Perf HUD off";
            this.perfHudOffBtn.UseVisualStyleBackColor = true;
            this.perfHudOffBtn.Click += new System.EventHandler(this.perfHudOffBtn_Click);
            // 
            // perfHudOnBtn
            // 
            this.perfHudOnBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perfHudOnBtn.Location = new System.Drawing.Point(193, 239);
            this.perfHudOnBtn.Margin = new System.Windows.Forms.Padding(2);
            this.perfHudOnBtn.Name = "perfHudOnBtn";
            this.perfHudOnBtn.Size = new System.Drawing.Size(87, 34);
            this.perfHudOnBtn.TabIndex = 7;
            this.perfHudOnBtn.Text = "Perf HUD on";
            this.perfHudOnBtn.UseVisualStyleBackColor = true;
            this.perfHudOnBtn.Click += new System.EventHandler(this.perfHudOnBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 163);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "numSlices (Recommend: 5)";
            // 
            // numslicesTextBox
            // 
            this.numslicesTextBox.Location = new System.Drawing.Point(252, 163);
            this.numslicesTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.numslicesTextBox.Name = "numslicesTextBox";
            this.numslicesTextBox.Size = new System.Drawing.Size(50, 20);
            this.numslicesTextBox.TabIndex = 4;
            this.numslicesTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            this.numslicesTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.numslicesTextBox.Leave += new System.EventHandler(this.numslicesTextBox_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(172, 201);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Sharpen";
            // 
            // sharpenBtn
            // 
            this.sharpenBtn.BackColor = System.Drawing.Color.Transparent;
            this.sharpenBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.sharpenBtn.FlatAppearance.BorderSize = 0;
            this.sharpenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sharpenBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sharpenBtn.Location = new System.Drawing.Point(252, 194);
            this.sharpenBtn.Margin = new System.Windows.Forms.Padding(0);
            this.sharpenBtn.Name = "sharpenBtn";
            this.sharpenBtn.Size = new System.Drawing.Size(44, 33);
            this.sharpenBtn.TabIndex = 5;
            this.sharpenBtn.UseVisualStyleBackColor = false;
            this.sharpenBtn.Click += new System.EventHandler(this.sharpenBtn_Click);
            // 
            // FormEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 422);
            this.Controls.Add(this.sharpenBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numslicesTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.perfHudOnBtn);
            this.Controls.Add(this.perfHudOffBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dbrBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.aswOffBtn);
            this.Controls.Add(this.restoreBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hevcBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dbmTextBox);
            this.Controls.Add(this.bitrateTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormEditor";
            this.Text = "Meta Quest Bitrate Registry Editor";
            this.Load += new System.EventHandler(this.FormEditor_Load);
            this.Click += new System.EventHandler(this.FormEditor_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox bitrateTextBox;
        private System.Windows.Forms.TextBox dbmTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button hevcBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button restoreBtn;
        private System.Windows.Forms.Button aswOffBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button dbrBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button perfHudOffBtn;
        private System.Windows.Forms.Button perfHudOnBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox numslicesTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button sharpenBtn;
    }
}

