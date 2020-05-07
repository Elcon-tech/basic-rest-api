namespace Warikan
{
    partial class Warikan
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.textbox_total = new System.Windows.Forms.TextBox();
            this.numericUpDown_people = new System.Windows.Forms.NumericUpDown();
            this.calc = new System.Windows.Forms.Button();
            this.total = new System.Windows.Forms.Label();
            this.people = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_people)).BeginInit();
            this.SuspendLayout();
            // 
            // textbox_total
            // 
            this.textbox_total.Location = new System.Drawing.Point(77, 55);
            this.textbox_total.Name = "textbox_total";
            this.textbox_total.Size = new System.Drawing.Size(165, 19);
            this.textbox_total.TabIndex = 0;
            this.textbox_total.Text = "10000";
            // 
            // numericUpDown_people
            // 
            this.numericUpDown_people.Location = new System.Drawing.Point(77, 103);
            this.numericUpDown_people.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_people.Name = "numericUpDown_people";
            this.numericUpDown_people.Size = new System.Drawing.Size(120, 19);
            this.numericUpDown_people.TabIndex = 1;
            this.numericUpDown_people.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // calc
            // 
            this.calc.Location = new System.Drawing.Point(77, 153);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(75, 23);
            this.calc.TabIndex = 2;
            this.calc.Text = "Calc";
            this.calc.UseVisualStyleBackColor = true;
            this.calc.Click += new System.EventHandler(this.button1_Click);
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(30, 61);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(31, 12);
            this.total.TabIndex = 3;
            this.total.Text = "Total";
            // 
            // people
            // 
            this.people.AutoSize = true;
            this.people.Location = new System.Drawing.Point(32, 109);
            this.people.Name = "people";
            this.people.Size = new System.Drawing.Size(39, 12);
            this.people.TabIndex = 4;
            this.people.Text = "People";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(77, 195);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 12);
            this.result.TabIndex = 5;
            // 
            // Warikan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.result);
            this.Controls.Add(this.people);
            this.Controls.Add(this.total);
            this.Controls.Add(this.calc);
            this.Controls.Add(this.numericUpDown_people);
            this.Controls.Add(this.textbox_total);
            this.Name = "Warikan";
            this.Text = "Warikan";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_people)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textbox_total;
        private System.Windows.Forms.NumericUpDown numericUpDown_people;
        private System.Windows.Forms.Button calc;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label people;
        private System.Windows.Forms.Label result;
    }
}

