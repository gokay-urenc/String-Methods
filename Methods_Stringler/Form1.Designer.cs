namespace Methods_Stringler
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCompareTo = new System.Windows.Forms.Button();
            this.btnContains = new System.Windows.Forms.Button();
            this.btnStartsWith = new System.Windows.Forms.Button();
            this.btnEndWith = new System.Windows.Forms.Button();
            this.btnIndexOf = new System.Windows.Forms.Button();
            this.btnLastIndexOf = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnSplit = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnToLower = new System.Windows.Forms.Button();
            this.btnSubstring = new System.Windows.Forms.Button();
            this.btnToCharArray = new System.Windows.Forms.Button();
            this.btnTrim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.ForeColor = System.Drawing.Color.Aqua;
            this.textBox1.Location = new System.Drawing.Point(92, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 21);
            this.textBox1.TabIndex = 0;
            // 
            // btnCompareTo
            // 
            this.btnCompareTo.BackColor = System.Drawing.Color.DarkGreen;
            this.btnCompareTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompareTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCompareTo.ForeColor = System.Drawing.Color.Lime;
            this.btnCompareTo.Location = new System.Drawing.Point(12, 40);
            this.btnCompareTo.Name = "btnCompareTo";
            this.btnCompareTo.Size = new System.Drawing.Size(132, 23);
            this.btnCompareTo.TabIndex = 1;
            this.btnCompareTo.Text = "CompareTo";
            this.btnCompareTo.UseVisualStyleBackColor = false;
            this.btnCompareTo.Click += new System.EventHandler(this.btnCompareTo_Click);
            // 
            // btnContains
            // 
            this.btnContains.BackColor = System.Drawing.Color.DarkGreen;
            this.btnContains.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContains.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnContains.ForeColor = System.Drawing.Color.Lime;
            this.btnContains.Location = new System.Drawing.Point(12, 69);
            this.btnContains.Name = "btnContains";
            this.btnContains.Size = new System.Drawing.Size(132, 23);
            this.btnContains.TabIndex = 2;
            this.btnContains.Text = "Contains";
            this.btnContains.UseVisualStyleBackColor = false;
            this.btnContains.Click += new System.EventHandler(this.btnContains_Click);
            // 
            // btnStartsWith
            // 
            this.btnStartsWith.BackColor = System.Drawing.Color.DarkGreen;
            this.btnStartsWith.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartsWith.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStartsWith.ForeColor = System.Drawing.Color.Lime;
            this.btnStartsWith.Location = new System.Drawing.Point(12, 98);
            this.btnStartsWith.Name = "btnStartsWith";
            this.btnStartsWith.Size = new System.Drawing.Size(132, 23);
            this.btnStartsWith.TabIndex = 4;
            this.btnStartsWith.Text = "StartsWith";
            this.btnStartsWith.UseVisualStyleBackColor = false;
            this.btnStartsWith.Click += new System.EventHandler(this.btnStartsWith_Click);
            // 
            // btnEndWith
            // 
            this.btnEndWith.BackColor = System.Drawing.Color.DarkGreen;
            this.btnEndWith.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndWith.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEndWith.ForeColor = System.Drawing.Color.Lime;
            this.btnEndWith.Location = new System.Drawing.Point(12, 127);
            this.btnEndWith.Name = "btnEndWith";
            this.btnEndWith.Size = new System.Drawing.Size(132, 23);
            this.btnEndWith.TabIndex = 3;
            this.btnEndWith.Text = "EndWith";
            this.btnEndWith.UseVisualStyleBackColor = false;
            this.btnEndWith.Click += new System.EventHandler(this.btnEndWith_Click);
            // 
            // btnIndexOf
            // 
            this.btnIndexOf.BackColor = System.Drawing.Color.DarkGreen;
            this.btnIndexOf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIndexOf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIndexOf.ForeColor = System.Drawing.Color.Lime;
            this.btnIndexOf.Location = new System.Drawing.Point(12, 156);
            this.btnIndexOf.Name = "btnIndexOf";
            this.btnIndexOf.Size = new System.Drawing.Size(132, 23);
            this.btnIndexOf.TabIndex = 8;
            this.btnIndexOf.Text = "IndexOf";
            this.btnIndexOf.UseVisualStyleBackColor = false;
            this.btnIndexOf.Click += new System.EventHandler(this.btnIndexOf_Click);
            // 
            // btnLastIndexOf
            // 
            this.btnLastIndexOf.BackColor = System.Drawing.Color.DarkGreen;
            this.btnLastIndexOf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLastIndexOf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLastIndexOf.ForeColor = System.Drawing.Color.Lime;
            this.btnLastIndexOf.Location = new System.Drawing.Point(12, 185);
            this.btnLastIndexOf.Name = "btnLastIndexOf";
            this.btnLastIndexOf.Size = new System.Drawing.Size(132, 23);
            this.btnLastIndexOf.TabIndex = 7;
            this.btnLastIndexOf.Text = "LastIndexOf";
            this.btnLastIndexOf.UseVisualStyleBackColor = false;
            this.btnLastIndexOf.Click += new System.EventHandler(this.btnLastIndexOf_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.DarkGreen;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRemove.ForeColor = System.Drawing.Color.Lime;
            this.btnRemove.Location = new System.Drawing.Point(12, 214);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(132, 23);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnReplace
            // 
            this.btnReplace.BackColor = System.Drawing.Color.DarkGreen;
            this.btnReplace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReplace.ForeColor = System.Drawing.Color.Lime;
            this.btnReplace.Location = new System.Drawing.Point(170, 40);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(132, 23);
            this.btnReplace.TabIndex = 5;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = false;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // btnSplit
            // 
            this.btnSplit.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSplit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSplit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSplit.ForeColor = System.Drawing.Color.Lime;
            this.btnSplit.Location = new System.Drawing.Point(170, 69);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(132, 23);
            this.btnSplit.TabIndex = 12;
            this.btnSplit.Text = "Split";
            this.btnSplit.UseVisualStyleBackColor = false;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.DarkGreen;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnInsert.ForeColor = System.Drawing.Color.Lime;
            this.btnInsert.Location = new System.Drawing.Point(170, 98);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(132, 23);
            this.btnInsert.TabIndex = 11;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnToLower
            // 
            this.btnToLower.BackColor = System.Drawing.Color.DarkGreen;
            this.btnToLower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToLower.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnToLower.ForeColor = System.Drawing.Color.Lime;
            this.btnToLower.Location = new System.Drawing.Point(170, 127);
            this.btnToLower.Name = "btnToLower";
            this.btnToLower.Size = new System.Drawing.Size(132, 23);
            this.btnToLower.TabIndex = 10;
            this.btnToLower.Text = "ToLower - ToUpper";
            this.btnToLower.UseVisualStyleBackColor = false;
            this.btnToLower.Click += new System.EventHandler(this.btnToLower_Click);
            // 
            // btnSubstring
            // 
            this.btnSubstring.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSubstring.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubstring.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSubstring.ForeColor = System.Drawing.Color.Lime;
            this.btnSubstring.Location = new System.Drawing.Point(170, 156);
            this.btnSubstring.Name = "btnSubstring";
            this.btnSubstring.Size = new System.Drawing.Size(132, 23);
            this.btnSubstring.TabIndex = 9;
            this.btnSubstring.Text = "Substring";
            this.btnSubstring.UseVisualStyleBackColor = false;
            this.btnSubstring.Click += new System.EventHandler(this.btnSubstring_Click);
            // 
            // btnToCharArray
            // 
            this.btnToCharArray.BackColor = System.Drawing.Color.DarkGreen;
            this.btnToCharArray.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToCharArray.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnToCharArray.ForeColor = System.Drawing.Color.Lime;
            this.btnToCharArray.Location = new System.Drawing.Point(170, 185);
            this.btnToCharArray.Name = "btnToCharArray";
            this.btnToCharArray.Size = new System.Drawing.Size(132, 23);
            this.btnToCharArray.TabIndex = 14;
            this.btnToCharArray.Text = "ToCharArray";
            this.btnToCharArray.UseVisualStyleBackColor = false;
            this.btnToCharArray.Click += new System.EventHandler(this.btnToCharArray_Click);
            // 
            // btnTrim
            // 
            this.btnTrim.BackColor = System.Drawing.Color.DarkGreen;
            this.btnTrim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTrim.ForeColor = System.Drawing.Color.Lime;
            this.btnTrim.Location = new System.Drawing.Point(170, 214);
            this.btnTrim.Name = "btnTrim";
            this.btnTrim.Size = new System.Drawing.Size(132, 23);
            this.btnTrim.TabIndex = 13;
            this.btnTrim.Text = "Trim";
            this.btnTrim.UseVisualStyleBackColor = false;
            this.btnTrim.Click += new System.EventHandler(this.btnTrim_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(325, 255);
            this.Controls.Add(this.btnToCharArray);
            this.Controls.Add(this.btnTrim);
            this.Controls.Add(this.btnSplit);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnToLower);
            this.Controls.Add(this.btnSubstring);
            this.Controls.Add(this.btnIndexOf);
            this.Controls.Add(this.btnLastIndexOf);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.btnStartsWith);
            this.Controls.Add(this.btnEndWith);
            this.Controls.Add(this.btnContains);
            this.Controls.Add(this.btnCompareTo);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "String Methods";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCompareTo;
        private System.Windows.Forms.Button btnContains;
        private System.Windows.Forms.Button btnStartsWith;
        private System.Windows.Forms.Button btnEndWith;
        private System.Windows.Forms.Button btnIndexOf;
        private System.Windows.Forms.Button btnLastIndexOf;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnToLower;
        private System.Windows.Forms.Button btnSubstring;
        private System.Windows.Forms.Button btnToCharArray;
        private System.Windows.Forms.Button btnTrim;
    }
}

