namespace LMAOSoft.Inc.Forms.Debug
{
    partial class frm_dump_memory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.hb_main = new Be.Windows.Forms.HexBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_alloc = new System.Windows.Forms.Button();
            this.btn_baseFile = new System.Windows.Forms.Button();
            this.btn_ram = new System.Windows.Forms.Button();
            this.btn_dmpMem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_len = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_addr = new System.Windows.Forms.TextBox();
            this.ss_main = new System.Windows.Forms.StatusStrip();
            this.tspb_progress = new System.Windows.Forms.ToolStripProgressBar();
            this.tssl_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_poke = new System.Windows.Forms.Button();
            this.btn_peek = new System.Windows.Forms.Button();
            this.btn_save_peek = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_peek_poke_len = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_peek_poke_addr = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.ss_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // hb_main
            // 
            this.hb_main.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hb_main.LineInfoVisible = true;
            this.hb_main.Location = new System.Drawing.Point(12, 138);
            this.hb_main.Name = "hb_main";
            this.hb_main.SelectionBackColor = System.Drawing.Color.Gray;
            this.hb_main.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.hb_main.Size = new System.Drawing.Size(303, 221);
            this.hb_main.StringViewVisible = true;
            this.hb_main.TabIndex = 1;
            this.hb_main.UseFixedBytesPerLine = true;
            this.hb_main.VScrollBarVisible = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(303, 120);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_alloc);
            this.tabPage1.Controls.Add(this.btn_baseFile);
            this.tabPage1.Controls.Add(this.btn_ram);
            this.tabPage1.Controls.Add(this.btn_dmpMem);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.tb_len);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tb_addr);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(295, 94);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dump Memory";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_new);
            this.tabPage2.Controls.Add(this.btn_poke);
            this.tabPage2.Controls.Add(this.btn_peek);
            this.tabPage2.Controls.Add(this.btn_save_peek);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.tb_peek_poke_len);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.tb_peek_poke_addr);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(295, 94);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Peek Poker";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_alloc
            // 
            this.btn_alloc.Location = new System.Drawing.Point(169, 63);
            this.btn_alloc.Name = "btn_alloc";
            this.btn_alloc.Size = new System.Drawing.Size(117, 23);
            this.btn_alloc.TabIndex = 15;
            this.btn_alloc.Text = "Allocated / Virtual";
            this.btn_alloc.UseVisualStyleBackColor = true;
            // 
            // btn_baseFile
            // 
            this.btn_baseFile.Location = new System.Drawing.Point(169, 35);
            this.btn_baseFile.Name = "btn_baseFile";
            this.btn_baseFile.Size = new System.Drawing.Size(117, 23);
            this.btn_baseFile.TabIndex = 14;
            this.btn_baseFile.Text = "Base file / Image";
            this.btn_baseFile.UseVisualStyleBackColor = true;
            // 
            // btn_ram
            // 
            this.btn_ram.Location = new System.Drawing.Point(169, 9);
            this.btn_ram.Name = "btn_ram";
            this.btn_ram.Size = new System.Drawing.Size(117, 23);
            this.btn_ram.TabIndex = 13;
            this.btn_ram.Text = "RAM";
            this.btn_ram.UseVisualStyleBackColor = true;
            // 
            // btn_dmpMem
            // 
            this.btn_dmpMem.Location = new System.Drawing.Point(12, 63);
            this.btn_dmpMem.Name = "btn_dmpMem";
            this.btn_dmpMem.Size = new System.Drawing.Size(151, 23);
            this.btn_dmpMem.TabIndex = 12;
            this.btn_dmpMem.Text = "Dump";
            this.btn_dmpMem.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Length:";
            // 
            // tb_len
            // 
            this.tb_len.Location = new System.Drawing.Point(63, 37);
            this.tb_len.Name = "tb_len";
            this.tb_len.Size = new System.Drawing.Size(100, 20);
            this.tb_len.TabIndex = 10;
            this.tb_len.Text = "0x1FFF0FFF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Address:";
            // 
            // tb_addr
            // 
            this.tb_addr.Location = new System.Drawing.Point(63, 11);
            this.tb_addr.Name = "tb_addr";
            this.tb_addr.Size = new System.Drawing.Size(100, 20);
            this.tb_addr.TabIndex = 8;
            this.tb_addr.Text = "0xC0000000";
            // 
            // ss_main
            // 
            this.ss_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspb_progress,
            this.tssl_status});
            this.ss_main.Location = new System.Drawing.Point(0, 374);
            this.ss_main.Name = "ss_main";
            this.ss_main.Size = new System.Drawing.Size(327, 22);
            this.ss_main.TabIndex = 3;
            this.ss_main.Text = "statusStrip1";
            // 
            // tspb_progress
            // 
            this.tspb_progress.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tspb_progress.Name = "tspb_progress";
            this.tspb_progress.Size = new System.Drawing.Size(75, 16);
            // 
            // tssl_status
            // 
            this.tssl_status.Name = "tssl_status";
            this.tssl_status.Size = new System.Drawing.Size(26, 17);
            this.tssl_status.Text = "Idle";
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(169, 63);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(117, 23);
            this.btn_new.TabIndex = 23;
            this.btn_new.Text = "New";
            this.btn_new.UseVisualStyleBackColor = true;
            // 
            // btn_poke
            // 
            this.btn_poke.Location = new System.Drawing.Point(169, 35);
            this.btn_poke.Name = "btn_poke";
            this.btn_poke.Size = new System.Drawing.Size(117, 23);
            this.btn_poke.TabIndex = 22;
            this.btn_poke.Text = "Poke";
            this.btn_poke.UseVisualStyleBackColor = true;
            // 
            // btn_peek
            // 
            this.btn_peek.Location = new System.Drawing.Point(169, 9);
            this.btn_peek.Name = "btn_peek";
            this.btn_peek.Size = new System.Drawing.Size(117, 23);
            this.btn_peek.TabIndex = 21;
            this.btn_peek.Text = "Peek";
            this.btn_peek.UseVisualStyleBackColor = true;
            // 
            // btn_save_peek
            // 
            this.btn_save_peek.Location = new System.Drawing.Point(12, 63);
            this.btn_save_peek.Name = "btn_save_peek";
            this.btn_save_peek.Size = new System.Drawing.Size(151, 23);
            this.btn_save_peek.TabIndex = 20;
            this.btn_save_peek.Text = "Save";
            this.btn_save_peek.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Length:";
            // 
            // tb_peek_poke_len
            // 
            this.tb_peek_poke_len.Location = new System.Drawing.Point(63, 37);
            this.tb_peek_poke_len.Name = "tb_peek_poke_len";
            this.tb_peek_poke_len.Size = new System.Drawing.Size(100, 20);
            this.tb_peek_poke_len.TabIndex = 18;
            this.tb_peek_poke_len.Text = "0xFFFF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Address:";
            // 
            // tb_peek_poke_addr
            // 
            this.tb_peek_poke_addr.Location = new System.Drawing.Point(63, 11);
            this.tb_peek_poke_addr.Name = "tb_peek_poke_addr";
            this.tb_peek_poke_addr.Size = new System.Drawing.Size(100, 20);
            this.tb_peek_poke_addr.TabIndex = 16;
            this.tb_peek_poke_addr.Text = "0xC0000000";
            // 
            // frm_dump_memory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 396);
            this.Controls.Add(this.ss_main);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.hb_main);
            this.Name = "frm_dump_memory";
            this.Text = "Memory Dumper";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ss_main.ResumeLayout(false);
            this.ss_main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Be.Windows.Forms.HexBox hb_main;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_alloc;
        private System.Windows.Forms.Button btn_baseFile;
        private System.Windows.Forms.Button btn_ram;
        private System.Windows.Forms.Button btn_dmpMem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_len;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_addr;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_poke;
        private System.Windows.Forms.Button btn_peek;
        private System.Windows.Forms.Button btn_save_peek;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_peek_poke_len;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_peek_poke_addr;
        private System.Windows.Forms.StatusStrip ss_main;
        private System.Windows.Forms.ToolStripProgressBar tspb_progress;
        private System.Windows.Forms.ToolStripStatusLabel tssl_status;
    }
}