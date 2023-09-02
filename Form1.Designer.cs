namespace _02._09_WF
{
    partial class PixabayImageSaver
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Search_tb = new TextBox();
            Clear_btn = new Button();
            SavePath_tb = new TextBox();
            PickPath_btn = new Button();
            Save_btn = new Button();
            PicCounter_num = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)PicCounter_num).BeginInit();
            SuspendLayout();
            // 
            // Search_tb
            // 
            Search_tb.Location = new Point(12, 12);
            Search_tb.Name = "Search_tb";
            Search_tb.Size = new Size(185, 23);
            Search_tb.TabIndex = 0;
            // 
            // Clear_btn
            // 
            Clear_btn.Location = new Point(329, 13);
            Clear_btn.Name = "Clear_btn";
            Clear_btn.Size = new Size(75, 23);
            Clear_btn.TabIndex = 2;
            Clear_btn.Text = "Default";
            Clear_btn.UseVisualStyleBackColor = true;
            Clear_btn.Click += OnClearClick;
            // 
            // SavePath_tb
            // 
            SavePath_tb.Location = new Point(12, 41);
            SavePath_tb.Name = "SavePath_tb";
            SavePath_tb.ReadOnly = true;
            SavePath_tb.Size = new Size(185, 23);
            SavePath_tb.TabIndex = 3;
            // 
            // PickPath_btn
            // 
            PickPath_btn.Location = new Point(203, 41);
            PickPath_btn.Name = "PickPath_btn";
            PickPath_btn.Size = new Size(119, 23);
            PickPath_btn.TabIndex = 4;
            PickPath_btn.Text = "Pick Path";
            PickPath_btn.UseVisualStyleBackColor = true;
            PickPath_btn.Click += OnPickPathClick;
            // 
            // Save_btn
            // 
            Save_btn.Location = new Point(328, 40);
            Save_btn.Name = "Save_btn";
            Save_btn.Size = new Size(75, 23);
            Save_btn.TabIndex = 5;
            Save_btn.Text = "Save";
            Save_btn.UseVisualStyleBackColor = true;
            Save_btn.Click += OnSaveClick;
            // 
            // PicCounter_num
            // 
            PicCounter_num.Increment = new decimal(new int[] { 3, 0, 0, 0 });
            PicCounter_num.Location = new Point(203, 13);
            PicCounter_num.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            PicCounter_num.Name = "PicCounter_num";
            PicCounter_num.Size = new Size(120, 23);
            PicCounter_num.TabIndex = 6;
            // 
            // PixabayImageSaver
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 75);
            Controls.Add(PicCounter_num);
            Controls.Add(Save_btn);
            Controls.Add(PickPath_btn);
            Controls.Add(SavePath_tb);
            Controls.Add(Clear_btn);
            Controls.Add(Search_tb);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "PixabayImageSaver";
            Text = "Pixabay image saver";
            ((System.ComponentModel.ISupportInitialize)PicCounter_num).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Search_tb;
        private Button Clear_btn;
        private TextBox SavePath_tb;
        private Button PickPath_btn;
        private Button Save_btn;
        private NumericUpDown PicCounter_num;
    }
}