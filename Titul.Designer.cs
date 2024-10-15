
namespace DriveSimulator
{
    partial class Titul
    {
        private System.ComponentModel.IContainer components = null;

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
            this.btnAddTransport = new System.Windows.Forms.Button();
            this.btnStartRace = new System.Windows.Forms.Button();
            this.btnRemoveTransport = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.listBoxAvailableTransport = new System.Windows.Forms.ListBox();
            this.comboRaceType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboWeather = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblRaceResult = new System.Windows.Forms.Label();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.listBoxRaceParticipants = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAddTransport
            // 
            this.btnAddTransport.BackColor = System.Drawing.Color.LightBlue;
            this.btnAddTransport.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddTransport.Location = new System.Drawing.Point(12, 83);
            this.btnAddTransport.Name = "btnAddTransport";
            this.btnAddTransport.Size = new System.Drawing.Size(229, 62);
            this.btnAddTransport.TabIndex = 1;
            this.btnAddTransport.Text = "Жив в Драйве";
            this.btnAddTransport.UseVisualStyleBackColor = false;
            this.btnAddTransport.Click += new System.EventHandler(this.btnAddTransport_Click);
            // 
            // btnStartRace
            // 
            this.btnStartRace.BackColor = System.Drawing.Color.LightBlue;
            this.btnStartRace.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartRace.Location = new System.Drawing.Point(453, 219);
            this.btnStartRace.Name = "btnStartRace";
            this.btnStartRace.Size = new System.Drawing.Size(180, 51);
            this.btnStartRace.TabIndex = 2;
            this.btnStartRace.Text = "Начать гонку";
            this.btnStartRace.UseVisualStyleBackColor = false;
            this.btnStartRace.Click += new System.EventHandler(this.btnStartRace_Click);
            // 
            // btnRemoveTransport
            // 
            this.btnRemoveTransport.BackColor = System.Drawing.Color.LightBlue;
            this.btnRemoveTransport.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRemoveTransport.Location = new System.Drawing.Point(786, 83);
            this.btnRemoveTransport.Name = "btnRemoveTransport";
            this.btnRemoveTransport.Size = new System.Drawing.Size(229, 62);
            this.btnRemoveTransport.TabIndex = 3;
            this.btnRemoveTransport.Text = "Умер в Драйве";
            this.btnRemoveTransport.UseVisualStyleBackColor = false;
            this.btnRemoveTransport.Click += new System.EventHandler(this.btnRemoveTransport_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightBlue;
            this.btnExit.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(786, 471);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(195, 51);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(14, 390);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 17);
            this.lblResult.TabIndex = 5;
            // 
            // listBoxAvailableTransport
            // 
            this.listBoxAvailableTransport.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxAvailableTransport.FormattingEnabled = true;
            this.listBoxAvailableTransport.ItemHeight = 23;
            this.listBoxAvailableTransport.Location = new System.Drawing.Point(12, 181);
            this.listBoxAvailableTransport.Name = "listBoxAvailableTransport";
            this.listBoxAvailableTransport.Size = new System.Drawing.Size(229, 188);
            this.listBoxAvailableTransport.TabIndex = 6;
            // 
            // comboRaceType
            // 
            this.comboRaceType.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboRaceType.FormattingEnabled = true;
            this.comboRaceType.Location = new System.Drawing.Point(12, 410);
            this.comboRaceType.Name = "comboRaceType";
            this.comboRaceType.Size = new System.Drawing.Size(180, 38);
            this.comboRaceType.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LavenderBlush;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(310, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 33);
            this.label1.TabIndex = 9;
            this.label1.Text = "Обещаем, не умрут они в конце Драйва!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseMnemonic = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LavenderBlush;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 30);
            this.label2.TabIndex = 10;
            this.label2.Text = "Участники гонки:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LavenderBlush;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 30);
            this.label4.TabIndex = 12;
            this.label4.Text = "Тип гонки:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboWeather
            // 
            this.comboWeather.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboWeather.FormattingEnabled = true;
            this.comboWeather.Location = new System.Drawing.Point(790, 405);
            this.comboWeather.Name = "comboWeather";
            this.comboWeather.Size = new System.Drawing.Size(180, 38);
            this.comboWeather.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LavenderBlush;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(787, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 30);
            this.label5.TabIndex = 14;
            this.label5.Text = "Погодные условия:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRaceResult
            // 
            this.lblRaceResult.AutoSize = true;
            this.lblRaceResult.BackColor = System.Drawing.Color.LavenderBlush;
            this.lblRaceResult.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRaceResult.Location = new System.Drawing.Point(338, 290);
            this.lblRaceResult.Name = "lblRaceResult";
            this.lblRaceResult.Size = new System.Drawing.Size(0, 24);
            this.lblRaceResult.TabIndex = 15;
            // 
            // txtDistance
            // 
            this.txtDistance.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDistance.Location = new System.Drawing.Point(12, 488);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(180, 38);
            this.txtDistance.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LavenderBlush;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 455);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 30);
            this.label6.TabIndex = 17;
            this.label6.Text = "Дистанция:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LavenderBlush;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(787, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 30);
            this.label7.TabIndex = 19;
            this.label7.Text = "Участники гонки:";
            // 
            // listBoxRaceParticipants
            // 
            this.listBoxRaceParticipants.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxRaceParticipants.FormattingEnabled = true;
            this.listBoxRaceParticipants.ItemHeight = 23;
            this.listBoxRaceParticipants.Location = new System.Drawing.Point(786, 181);
            this.listBoxRaceParticipants.Name = "listBoxRaceParticipants";
            this.listBoxRaceParticipants.Size = new System.Drawing.Size(229, 188);
            this.listBoxRaceParticipants.TabIndex = 18;
            // 
            // Titul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DriveSimulator.Properties.Resources.HD_wallpaper_movie_drive_2011;
            this.ClientSize = new System.Drawing.Size(1027, 552);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listBoxRaceParticipants);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDistance);
            this.Controls.Add(this.lblRaceResult);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboWeather);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboRaceType);
            this.Controls.Add(this.listBoxAvailableTransport);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRemoveTransport);
            this.Controls.Add(this.btnStartRace);
            this.Controls.Add(this.btnAddTransport);
            this.Name = "Titul";
            this.Text = "Drive";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddTransport;
        private System.Windows.Forms.Button btnStartRace;
        private System.Windows.Forms.Button btnRemoveTransport;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.ListBox listBoxAvailableTransport;
        private System.Windows.Forms.ComboBox comboRaceType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboWeather;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblRaceResult;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBoxRaceParticipants;
    }
}

