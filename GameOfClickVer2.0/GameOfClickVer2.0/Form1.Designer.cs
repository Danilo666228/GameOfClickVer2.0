namespace GameOfClickVer2._0
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сложностьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.низкаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.средняяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.высокаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMap = new System.Windows.Forms.Panel();
            this.ptb4 = new System.Windows.Forms.PictureBox();
            this.ptb2 = new System.Windows.Forms.PictureBox();
            this.ptb3 = new System.Windows.Forms.PictureBox();
            this.ptb1 = new System.Windows.Forms.PictureBox();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.lblTimerResult = new System.Windows.Forms.Label();
            this.lblCountObjectResult = new System.Windows.Forms.Label();
            this.lblCountPointResult = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblCountObject = new System.Windows.Forms.Label();
            this.lblCountPoint = new System.Windows.Forms.Label();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.правилаИгрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.pnlMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb1)).BeginInit();
            this.pnlInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem,
            this.правилаИгрыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1348, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сложностьToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.настройкиToolStripMenuItem.Text = "Играть";
            // 
            // сложностьToolStripMenuItem
            // 
            this.сложностьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.низкаяToolStripMenuItem,
            this.средняяToolStripMenuItem,
            this.высокаяToolStripMenuItem});
            this.сложностьToolStripMenuItem.Name = "сложностьToolStripMenuItem";
            this.сложностьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сложностьToolStripMenuItem.Text = "Сложность";
            // 
            // низкаяToolStripMenuItem
            // 
            this.низкаяToolStripMenuItem.Name = "низкаяToolStripMenuItem";
            this.низкаяToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.низкаяToolStripMenuItem.Text = "Низкая";
            this.низкаяToolStripMenuItem.Click += new System.EventHandler(this.низкаяToolStripMenuItem_Click);
            // 
            // средняяToolStripMenuItem
            // 
            this.средняяToolStripMenuItem.Name = "средняяToolStripMenuItem";
            this.средняяToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.средняяToolStripMenuItem.Text = "Средняя";
            this.средняяToolStripMenuItem.Click += new System.EventHandler(this.средняяToolStripMenuItem_Click);
            // 
            // высокаяToolStripMenuItem
            // 
            this.высокаяToolStripMenuItem.Name = "высокаяToolStripMenuItem";
            this.высокаяToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.высокаяToolStripMenuItem.Text = "Высокая";
            this.высокаяToolStripMenuItem.Click += new System.EventHandler(this.высокаяToolStripMenuItem_Click);
            // 
            // pnlMap
            // 
            this.pnlMap.Controls.Add(this.ptb4);
            this.pnlMap.Controls.Add(this.ptb2);
            this.pnlMap.Controls.Add(this.ptb3);
            this.pnlMap.Controls.Add(this.ptb1);
            this.pnlMap.Location = new System.Drawing.Point(12, 43);
            this.pnlMap.Name = "pnlMap";
            this.pnlMap.Size = new System.Drawing.Size(916, 548);
            this.pnlMap.TabIndex = 1;
            // 
            // ptb4
            // 
            this.ptb4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptb4.Location = new System.Drawing.Point(622, 384);
            this.ptb4.Name = "ptb4";
            this.ptb4.Size = new System.Drawing.Size(44, 38);
            this.ptb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb4.TabIndex = 3;
            this.ptb4.TabStop = false;
            this.ptb4.Click += new System.EventHandler(this.ClickPicture_Click);
            // 
            // ptb2
            // 
            this.ptb2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptb2.Location = new System.Drawing.Point(586, 101);
            this.ptb2.Name = "ptb2";
            this.ptb2.Size = new System.Drawing.Size(44, 38);
            this.ptb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb2.TabIndex = 2;
            this.ptb2.TabStop = false;
            this.ptb2.Click += new System.EventHandler(this.ClickPicture_Click);
            // 
            // ptb3
            // 
            this.ptb3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptb3.Location = new System.Drawing.Point(78, 304);
            this.ptb3.Name = "ptb3";
            this.ptb3.Size = new System.Drawing.Size(44, 38);
            this.ptb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb3.TabIndex = 1;
            this.ptb3.TabStop = false;
            this.ptb3.Click += new System.EventHandler(this.ClickPicture_Click);
            // 
            // ptb1
            // 
            this.ptb1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptb1.Location = new System.Drawing.Point(62, 67);
            this.ptb1.Name = "ptb1";
            this.ptb1.Size = new System.Drawing.Size(44, 38);
            this.ptb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb1.TabIndex = 0;
            this.ptb1.TabStop = false;
            this.ptb1.Click += new System.EventHandler(this.ClickPicture_Click);
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.Olive;
            this.pnlInfo.Controls.Add(this.btnReset);
            this.pnlInfo.Controls.Add(this.btnStartGame);
            this.pnlInfo.Controls.Add(this.lblTimerResult);
            this.pnlInfo.Controls.Add(this.lblCountObjectResult);
            this.pnlInfo.Controls.Add(this.lblCountPointResult);
            this.pnlInfo.Controls.Add(this.lblTimer);
            this.pnlInfo.Controls.Add(this.lblCountObject);
            this.pnlInfo.Controls.Add(this.lblCountPoint);
            this.pnlInfo.Location = new System.Drawing.Point(969, 43);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(342, 402);
            this.pnlInfo.TabIndex = 2;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(117, 284);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(110, 33);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Заново";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStartGame
            // 
            this.btnStartGame.Location = new System.Drawing.Point(117, 198);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(110, 33);
            this.btnStartGame.TabIndex = 6;
            this.btnStartGame.Text = "Начать";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // lblTimerResult
            // 
            this.lblTimerResult.AutoSize = true;
            this.lblTimerResult.Location = new System.Drawing.Point(203, 106);
            this.lblTimerResult.Name = "lblTimerResult";
            this.lblTimerResult.Size = new System.Drawing.Size(24, 17);
            this.lblTimerResult.TabIndex = 5;
            this.lblTimerResult.Text = "60";
            // 
            // lblCountObjectResult
            // 
            this.lblCountObjectResult.AutoSize = true;
            this.lblCountObjectResult.Location = new System.Drawing.Point(237, 72);
            this.lblCountObjectResult.Name = "lblCountObjectResult";
            this.lblCountObjectResult.Size = new System.Drawing.Size(16, 17);
            this.lblCountObjectResult.TabIndex = 4;
            this.lblCountObjectResult.Text = "0";
            // 
            // lblCountPointResult
            // 
            this.lblCountPointResult.AutoSize = true;
            this.lblCountPointResult.Location = new System.Drawing.Point(228, 38);
            this.lblCountPointResult.Name = "lblCountPointResult";
            this.lblCountPointResult.Size = new System.Drawing.Size(16, 17);
            this.lblCountPointResult.TabIndex = 3;
            this.lblCountPointResult.Text = "0";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(121, 106);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(64, 17);
            this.lblTimer.TabIndex = 2;
            this.lblTimer.Text = "Таймер:";
            // 
            // lblCountObject
            // 
            this.lblCountObject.AutoSize = true;
            this.lblCountObject.Location = new System.Drawing.Point(92, 72);
            this.lblCountObject.Name = "lblCountObject";
            this.lblCountObject.Size = new System.Drawing.Size(152, 17);
            this.lblCountObject.TabIndex = 1;
            this.lblCountObject.Text = "Сколько осталось: ";
            // 
            // lblCountPoint
            // 
            this.lblCountPoint.AutoSize = true;
            this.lblCountPoint.Location = new System.Drawing.Point(110, 38);
            this.lblCountPoint.Name = "lblCountPoint";
            this.lblCountPoint.Size = new System.Drawing.Size(112, 17);
            this.lblCountPoint.TabIndex = 0;
            this.lblCountPoint.Text = "Кол-во очков:";
            // 
            // tmr
            // 
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // правилаИгрыToolStripMenuItem
            // 
            this.правилаИгрыToolStripMenuItem.Name = "правилаИгрыToolStripMenuItem";
            this.правилаИгрыToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.правилаИгрыToolStripMenuItem.Text = "Правила игры";
            this.правилаИгрыToolStripMenuItem.Click += new System.EventHandler(this.правилаИгрыToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 599);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.pnlMap);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "GameOfClick";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlMap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb1)).EndInit();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сложностьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem низкаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem средняяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem высокаяToolStripMenuItem;
        private System.Windows.Forms.Panel pnlMap;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.PictureBox ptb4;
        private System.Windows.Forms.PictureBox ptb2;
        private System.Windows.Forms.PictureBox ptb3;
        private System.Windows.Forms.PictureBox ptb1;
        private System.Windows.Forms.Label lblTimerResult;
        private System.Windows.Forms.Label lblCountObjectResult;
        private System.Windows.Forms.Label lblCountPointResult;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblCountObject;
        private System.Windows.Forms.Label lblCountPoint;
        private System.Windows.Forms.Timer tmr;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ToolStripMenuItem правилаИгрыToolStripMenuItem;
    }
}

