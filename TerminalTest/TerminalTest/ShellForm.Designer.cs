namespace TerminalTest
{
    partial class ShellForm
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
            splitContainer1 = new SplitContainer();
            terminal1 = new WFTerminal.Terminal();
            terminal2 = new WFTerminal.Terminal();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(terminal1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(terminal2);
            splitContainer1.Size = new Size(784, 647);
            splitContainer1.SplitterDistance = 345;
            splitContainer1.TabIndex = 1;
            // 
            // terminal1
            // 
            terminal1.AllowInputPositionMovement = true;
            terminal1.AllowOutputOnUserInputMode = false;
            terminal1.AllowsScrollToCurrentPosition = true;
            terminal1.BackColor = Color.FromArgb(12, 12, 12);
            terminal1.CellHeight = 13U;
            terminal1.CellWidth = 9U;
            terminal1.DefaultPlaceholderColor = Color.Gray;
            terminal1.DeltaWheelSensitivity = 100;
            terminal1.DirectInputStreamWriting = false;
            terminal1.Dock = DockStyle.Fill;
            terminal1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            terminal1.ForeColor = Color.FromArgb(224, 224, 224);
            terminal1.FreeInputMode = false;
            terminal1.HighlightColor = Color.FromArgb(44, 44, 44);
            terminal1.InputColor = Color.LightGray;
            terminal1.Location = new Point(0, 0);
            terminal1.Margin = new Padding(4, 3, 4, 3);
            terminal1.Name = "terminal1";
            terminal1.RestrictFreeInputMode = true;
            terminal1.ScrollViewKeepPosition = 0.75D;
            terminal1.ShowCursorPosition = true;
            terminal1.Size = new Size(784, 345);
            terminal1.TabIndex = 1;
            terminal1.TerminalFont = new Font("Cascadia Code Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            terminal1.UserInputMode = false;
            // 
            // terminal2
            // 
            terminal2.AllowInputPositionMovement = true;
            terminal2.AllowOutputOnUserInputMode = false;
            terminal2.AllowsScrollToCurrentPosition = true;
            terminal2.BackColor = Color.FromArgb(12, 12, 12);
            terminal2.CellHeight = 13U;
            terminal2.CellWidth = 9U;
            terminal2.DefaultPlaceholderColor = Color.Gray;
            terminal2.DeltaWheelSensitivity = 100;
            terminal2.DirectInputStreamWriting = false;
            terminal2.Dock = DockStyle.Fill;
            terminal2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            terminal2.ForeColor = Color.FromArgb(224, 224, 224);
            terminal2.FreeInputMode = false;
            terminal2.HighlightColor = Color.FromArgb(44, 44, 44);
            terminal2.InputColor = Color.LightGray;
            terminal2.Location = new Point(0, 0);
            terminal2.Margin = new Padding(4, 3, 4, 3);
            terminal2.Name = "terminal2";
            terminal2.RestrictFreeInputMode = true;
            terminal2.ScrollViewKeepPosition = 0.75D;
            terminal2.ShowCursorPosition = true;
            terminal2.Size = new Size(784, 298);
            terminal2.TabIndex = 2;
            terminal2.TerminalFont = new Font("Cascadia Code Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            terminal2.UserInputMode = false;
            // 
            // ShellForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 647);
            Controls.Add(splitContainer1);
            Font = new Font("Syne", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "ShellForm";
            Text = "Test Form - SSH to Local Client";
            Load += Form1_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private WFTerminal.Terminal terminal1;
        private WFTerminal.Terminal terminal2;
    }
}