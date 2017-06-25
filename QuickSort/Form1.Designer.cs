namespace QuickSort
{
    partial class Form1
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
            this.toSort = new System.Windows.Forms.ListBox();
            this.sorted = new System.Windows.Forms.ListBox();
            this.sort = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // toSort
            // 
            this.toSort.FormattingEnabled = true;
            this.toSort.Location = new System.Drawing.Point(33, 58);
            this.toSort.Name = "toSort";
            this.toSort.Size = new System.Drawing.Size(140, 186);
            this.toSort.TabIndex = 0;
            // 
            // sorted
            // 
            this.sorted.FormattingEnabled = true;
            this.sorted.Location = new System.Drawing.Point(329, 58);
            this.sorted.Name = "sorted";
            this.sorted.Size = new System.Drawing.Size(134, 186);
            this.sorted.TabIndex = 1;
            // 
            // sort
            // 
            this.sort.Location = new System.Drawing.Point(212, 83);
            this.sort.Name = "sort";
            this.sort.Size = new System.Drawing.Size(75, 23);
            this.sort.TabIndex = 2;
            this.sort.Text = "Sort";
            this.sort.UseVisualStyleBackColor = true;
            this.sort.Click += new System.EventHandler(this.sort_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(212, 164);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 27);
            this.reset.TabIndex = 3;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 261);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.sort);
            this.Controls.Add(this.sorted);
            this.Controls.Add(this.toSort);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox toSort;
        private System.Windows.Forms.ListBox sorted;
        private System.Windows.Forms.Button sort;
        private System.Windows.Forms.Button reset;
    }
}

