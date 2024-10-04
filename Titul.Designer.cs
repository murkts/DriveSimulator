
namespace DriveSimulator
{
    partial class Titul
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCreateRace = new System.Windows.Forms.Button();
            this.btnStartRace = new System.Windows.Forms.Button();
            this.btnRegisterTransport = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.listBoxParticipants = new System.Windows.Forms.ListBox();
            this.numericUpDownDistance = new System.Windows.Forms.NumericUpDown();
            this.comboBoxRaceType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDistance)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Thistle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(211, 173);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(644, 30);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Для перехода к выбору гонки используй кнопки";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCreateRace
            // 
            this.btnCreateRace.BackColor = System.Drawing.Color.LightBlue;
            this.btnCreateRace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreateRace.Location = new System.Drawing.Point(211, 209);
            this.btnCreateRace.Name = "btnCreateRace";
            this.btnCreateRace.Size = new System.Drawing.Size(180, 51);
            this.btnCreateRace.TabIndex = 1;
            this.btnCreateRace.Text = "Создать гонку";
            this.btnCreateRace.UseVisualStyleBackColor = false;
            this.btnCreateRace.Click += new System.EventHandler(this.btnCreateRace_Click);
            // 
            // btnStartRace
            // 
            this.btnStartRace.BackColor = System.Drawing.Color.LightBlue;
            this.btnStartRace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStartRace.Location = new System.Drawing.Point(445, 209);
            this.btnStartRace.Name = "btnStartRace";
            this.btnStartRace.Size = new System.Drawing.Size(180, 51);
            this.btnStartRace.TabIndex = 2;
            this.btnStartRace.Text = "Запуск";
            this.btnStartRace.UseVisualStyleBackColor = false;
            this.btnStartRace.Click += new System.EventHandler(this.btnStartRace_Click);
            // 
            // btnRegisterTransport
            // 
            this.btnRegisterTransport.BackColor = System.Drawing.Color.LightBlue;
            this.btnRegisterTransport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRegisterTransport.Location = new System.Drawing.Point(675, 209);
            this.btnRegisterTransport.Name = "btnRegisterTransport";
            this.btnRegisterTransport.Size = new System.Drawing.Size(180, 51);
            this.btnRegisterTransport.TabIndex = 3;
            this.btnRegisterTransport.Text = "Регистрация";
            this.btnRegisterTransport.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightBlue;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(814, 470);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(180, 51);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(69, 490);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 17);
            this.lblResult.TabIndex = 5;
            // 
            // listBoxParticipants
            // 
            this.listBoxParticipants.FormattingEnabled = true;
            this.listBoxParticipants.ItemHeight = 16;
            this.listBoxParticipants.Location = new System.Drawing.Point(543, 278);
            this.listBoxParticipants.Name = "listBoxParticipants";
            this.listBoxParticipants.Size = new System.Drawing.Size(120, 84);
            this.listBoxParticipants.TabIndex = 6;
            // 
            // numericUpDownDistance
            // 
            this.numericUpDownDistance.Location = new System.Drawing.Point(737, 286);
            this.numericUpDownDistance.Name = "numericUpDownDistance";
            this.numericUpDownDistance.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownDistance.TabIndex = 7;
            // 
            // comboBoxRaceType
            // 
            this.comboBoxRaceType.FormattingEnabled = true;
            this.comboBoxRaceType.Location = new System.Drawing.Point(449, 396);
            this.comboBoxRaceType.Name = "comboBoxRaceType";
            this.comboBoxRaceType.Size = new System.Drawing.Size(121, 24);
            this.comboBoxRaceType.TabIndex = 8;
            // 
            // Titul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DriveSimulator.Properties.Resources.HD_wallpaper_movie_drive_2011;
            this.ClientSize = new System.Drawing.Size(1027, 552);
            this.Controls.Add(this.comboBoxRaceType);
            this.Controls.Add(this.numericUpDownDistance);
            this.Controls.Add(this.listBoxParticipants);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRegisterTransport);
            this.Controls.Add(this.btnStartRace);
            this.Controls.Add(this.btnCreateRace);
            this.Controls.Add(this.textBox1);
            this.Name = "Titul";
            this.Text = "Drive";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDistance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCreateRace;
        private System.Windows.Forms.Button btnStartRace;
        private System.Windows.Forms.Button btnRegisterTransport;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.ListBox listBoxParticipants;
        private System.Windows.Forms.NumericUpDown numericUpDownDistance;
        private System.Windows.Forms.ComboBox comboBoxRaceType;
    }
}

