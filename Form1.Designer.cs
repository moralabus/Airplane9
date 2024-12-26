﻿using System.Windows.Forms;

namespace Airplane9
{
    partial class Form1
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

        private void InitializeComponent()
        {
            this.textBoxAirplaneName = new System.Windows.Forms.TextBox();
            this.labelAirplaneName = new System.Windows.Forms.Label();
            this.comboBoxModel = new System.Windows.Forms.ComboBox();
            this.labelModel = new System.Windows.Forms.Label();
            this.numericUpDownRange = new System.Windows.Forms.NumericUpDown();
            this.labelRange = new System.Windows.Forms.Label();
            this.numericUpDownFuelConsumption = new System.Windows.Forms.NumericUpDown();
            this.labelFuelConsumption = new System.Windows.Forms.Label();
            this.dateTimePickerManufactureDate = new System.Windows.Forms.DateTimePicker();
            this.labelManufactureDate = new System.Windows.Forms.Label();
            this.numericUpDownCargoCapacity = new System.Windows.Forms.NumericUpDown();
            this.textBoxCargoType = new System.Windows.Forms.TextBox();
            this.textBoxCargoCapacityLabel = new System.Windows.Forms.Label();
            this.textBoxCargoTypeLabel = new System.Windows.Forms.Label();
            this.numericUpDownPassengerCapacity = new System.Windows.Forms.NumericUpDown();
            this.textBoxPassengerCapacityLabel = new System.Windows.Forms.Label();
            this.buttonAddAirplaneWithFoto = new System.Windows.Forms.Button();
            this.listBoxAirplanes = new System.Windows.Forms.ListBox();
            this.buttonSaveToFile = new System.Windows.Forms.Button();
            this.buttonLoadFromFile = new System.Windows.Forms.Button();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.buttonChooseFont = new System.Windows.Forms.Button();
            this.buttonChooseColor = new System.Windows.Forms.Button();
            this.checkBoxHasBusinessClassLabel = new System.Windows.Forms.CheckBox();
            this.checkBoxHasBusinessClass = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFuelConsumption)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCargoCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPassengerCapacity)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxAirplaneName
            // 
            this.textBoxAirplaneName.Location = new System.Drawing.Point(12, 45);
            this.textBoxAirplaneName.Name = "textBoxAirplaneName";
            this.textBoxAirplaneName.Size = new System.Drawing.Size(200, 31);
            this.textBoxAirplaneName.TabIndex = 0;
            // 
            // labelAirplaneName
            // 
            this.labelAirplaneName.AutoSize = true;
            this.labelAirplaneName.Location = new System.Drawing.Point(12, 15);
            this.labelAirplaneName.Name = "labelAirplaneName";
            this.labelAirplaneName.Size = new System.Drawing.Size(211, 25);
            this.labelAirplaneName.TabIndex = 1;
            this.labelAirplaneName.Text = "Название самолета";
            // 
            // comboBoxModel
            // 
            this.comboBoxModel.FormattingEnabled = true;
            this.comboBoxModel.Location = new System.Drawing.Point(12, 107);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new System.Drawing.Size(200, 33);
            this.comboBoxModel.TabIndex = 2;
            this.comboBoxModel.SelectedIndexChanged += new System.EventHandler(this.comboBoxModel_SelectedIndexChanged);
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Location = new System.Drawing.Point(12, 77);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(152, 25);
            this.labelModel.TabIndex = 3;
            this.labelModel.Text = "Вид самолета";
            // 
            // numericUpDownRange
            // 
            this.numericUpDownRange.Location = new System.Drawing.Point(12, 171);
            this.numericUpDownRange.Name = "numericUpDownRange";
            this.numericUpDownRange.Size = new System.Drawing.Size(200, 31);
            this.numericUpDownRange.TabIndex = 4;
            // 
            // labelRange
            // 
            this.labelRange.AutoSize = true;
            this.labelRange.Location = new System.Drawing.Point(12, 141);
            this.labelRange.Name = "labelRange";
            this.labelRange.Size = new System.Drawing.Size(195, 25);
            this.labelRange.TabIndex = 5;
            this.labelRange.Text = "Дальность полета";
            // 
            // numericUpDownFuelConsumption
            // 
            this.numericUpDownFuelConsumption.Location = new System.Drawing.Point(12, 235);
            this.numericUpDownFuelConsumption.Name = "numericUpDownFuelConsumption";
            this.numericUpDownFuelConsumption.Size = new System.Drawing.Size(200, 31);
            this.numericUpDownFuelConsumption.TabIndex = 6;
            // 
            // labelFuelConsumption
            // 
            this.labelFuelConsumption.AutoSize = true;
            this.labelFuelConsumption.Location = new System.Drawing.Point(12, 205);
            this.labelFuelConsumption.Name = "labelFuelConsumption";
            this.labelFuelConsumption.Size = new System.Drawing.Size(342, 25);
            this.labelFuelConsumption.TabIndex = 7;
            this.labelFuelConsumption.Text = "Потребление горючего (л/100км)";
            // 
            // dateTimePickerManufactureDate
            // 
            this.dateTimePickerManufactureDate.Location = new System.Drawing.Point(12, 299);
            this.dateTimePickerManufactureDate.Name = "dateTimePickerManufactureDate";
            this.dateTimePickerManufactureDate.Size = new System.Drawing.Size(200, 31);
            this.dateTimePickerManufactureDate.TabIndex = 8;
            // 
            // labelManufactureDate
            // 
            this.labelManufactureDate.AutoSize = true;
            this.labelManufactureDate.Location = new System.Drawing.Point(12, 269);
            this.labelManufactureDate.Name = "labelManufactureDate";
            this.labelManufactureDate.Size = new System.Drawing.Size(206, 25);
            this.labelManufactureDate.TabIndex = 9;
            this.labelManufactureDate.Text = "Дата производства";
            // 
            // numericUpDownCargoCapacity
            // 
            this.numericUpDownCargoCapacity.Location = new System.Drawing.Point(246, 107);
            this.numericUpDownCargoCapacity.Name = "numericUpDownCargoCapacity";
            this.numericUpDownCargoCapacity.Size = new System.Drawing.Size(200, 31);
            this.numericUpDownCargoCapacity.TabIndex = 10;
            this.numericUpDownCargoCapacity.Visible = false;
            // 
            // textBoxCargoType
            // 
            this.textBoxCargoType.Location = new System.Drawing.Point(246, 171);
            this.textBoxCargoType.Name = "textBoxCargoType";
            this.textBoxCargoType.Size = new System.Drawing.Size(200, 31);
            this.textBoxCargoType.TabIndex = 11;
            this.textBoxCargoType.Visible = false;
            // 
            // textBoxCargoCapacityLabel
            // 
            this.textBoxCargoCapacityLabel.AutoSize = true;
            this.textBoxCargoCapacityLabel.Location = new System.Drawing.Point(246, 77);
            this.textBoxCargoCapacityLabel.Name = "textBoxCargoCapacityLabel";
            this.textBoxCargoCapacityLabel.Size = new System.Drawing.Size(202, 25);
            this.textBoxCargoCapacityLabel.TabIndex = 12;
            this.textBoxCargoCapacityLabel.Text = "Грузоподъемность";
            this.textBoxCargoCapacityLabel.Visible = false;
            // 
            // textBoxCargoTypeLabel
            // 
            this.textBoxCargoTypeLabel.AutoSize = true;
            this.textBoxCargoTypeLabel.Location = new System.Drawing.Point(246, 141);
            this.textBoxCargoTypeLabel.Name = "textBoxCargoTypeLabel";
            this.textBoxCargoTypeLabel.Size = new System.Drawing.Size(109, 25);
            this.textBoxCargoTypeLabel.TabIndex = 13;
            this.textBoxCargoTypeLabel.Text = "Тип груза";
            this.textBoxCargoTypeLabel.Visible = false;
            // 
            // numericUpDownPassengerCapacity
            // 
            this.numericUpDownPassengerCapacity.Location = new System.Drawing.Point(246, 235);
            this.numericUpDownPassengerCapacity.Name = "numericUpDownPassengerCapacity";
            this.numericUpDownPassengerCapacity.Size = new System.Drawing.Size(200, 31);
            this.numericUpDownPassengerCapacity.TabIndex = 14;
            this.numericUpDownPassengerCapacity.Visible = false;
            // 
            // textBoxPassengerCapacityLabel
            // 
            this.textBoxPassengerCapacityLabel.AutoSize = true;
            this.textBoxPassengerCapacityLabel.Location = new System.Drawing.Point(246, 205);
            this.textBoxPassengerCapacityLabel.Name = "textBoxPassengerCapacityLabel";
            this.textBoxPassengerCapacityLabel.Size = new System.Drawing.Size(271, 25);
            this.textBoxPassengerCapacityLabel.TabIndex = 16;
            this.textBoxPassengerCapacityLabel.Text = "Вместимость пассажиров";
            this.textBoxPassengerCapacityLabel.Visible = false;
            // 
            // buttonAddAirplaneWithFoto
            // 
            this.buttonAddAirplaneWithFoto.Location = new System.Drawing.Point(246, 350);
            this.buttonAddAirplaneWithFoto.Name = "buttonAddAirplaneWithFoto";
            this.buttonAddAirplaneWithFoto.Size = new System.Drawing.Size(200, 45);
            this.buttonAddAirplaneWithFoto.TabIndex = 17;
            this.buttonAddAirplaneWithFoto.Text = "Добавить самолет с фото";
            this.buttonAddAirplaneWithFoto.UseVisualStyleBackColor = true;
            this.buttonAddAirplaneWithFoto.Click += new System.EventHandler(this.buttonAddAirplaneWithFoto_Click);
            // 
            // listBoxAirplanes
            // 
            this.listBoxAirplanes.FormattingEnabled = true;
            this.listBoxAirplanes.ItemHeight = 25;
            this.listBoxAirplanes.Location = new System.Drawing.Point(472, 45);
            this.listBoxAirplanes.Name = "listBoxAirplanes";
            this.listBoxAirplanes.Size = new System.Drawing.Size(400, 329);
            this.listBoxAirplanes.TabIndex = 18;
            // 
            // buttonSaveToFile
            // 
            this.buttonSaveToFile.Location = new System.Drawing.Point(0, 0);
            this.buttonSaveToFile.Name = "buttonSaveToFile";
            this.buttonSaveToFile.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveToFile.TabIndex = 24;
            // 
            // buttonLoadFromFile
            // 
            this.buttonLoadFromFile.Location = new System.Drawing.Point(672, 380);
            this.buttonLoadFromFile.Name = "buttonLoadFromFile";
            this.buttonLoadFromFile.Size = new System.Drawing.Size(200, 45);
            this.buttonLoadFromFile.TabIndex = 20;
            this.buttonLoadFromFile.Text = "Загрузить из файла";
            this.buttonLoadFromFile.UseVisualStyleBackColor = true;
            this.buttonLoadFromFile.Click += new System.EventHandler(this.buttonLoadFromFile_Click);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(12, 350);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(200, 100);
            this.textBoxOutput.TabIndex = 21;
            // 
            // buttonChooseFont
            // 
            this.buttonChooseFont.Location = new System.Drawing.Point(12, 460);
            this.buttonChooseFont.Name = "buttonChooseFont";
            this.buttonChooseFont.Size = new System.Drawing.Size(200, 45);
            this.buttonChooseFont.TabIndex = 22;
            this.buttonChooseFont.Text = "Выбрать шрифт";
            this.buttonChooseFont.UseVisualStyleBackColor = true;
            this.buttonChooseFont.Click += new System.EventHandler(this.buttonChooseFont_Click);
            // 
            // buttonChooseColor
            // 
            this.buttonChooseColor.Location = new System.Drawing.Point(246, 460);
            this.buttonChooseColor.Name = "buttonChooseColor";
            this.buttonChooseColor.Size = new System.Drawing.Size(200, 45);
            this.buttonChooseColor.TabIndex = 23;
            this.buttonChooseColor.Text = "Выбрать цвет";
            this.buttonChooseColor.UseVisualStyleBackColor = true;
            this.buttonChooseColor.Click += new System.EventHandler(this.buttonChooseColor_Click);
            // 
            // checkBoxHasBusinessClassLabel
            // 
            this.checkBoxHasBusinessClassLabel.AutoSize = true;
            this.checkBoxHasBusinessClassLabel.Location = new System.Drawing.Point(472, 469);
            this.checkBoxHasBusinessClassLabel.Name = "checkBoxHasBusinessClassLabel";
            this.checkBoxHasBusinessClassLabel.Size = new System.Drawing.Size(229, 29);
            this.checkBoxHasBusinessClassLabel.TabIndex = 25;
            this.checkBoxHasBusinessClassLabel.Text = "Есть бизнес класс";
            this.checkBoxHasBusinessClassLabel.UseVisualStyleBackColor = true;
            this.checkBoxHasBusinessClassLabel.CheckedChanged += new System.EventHandler(this.checkBoxHasBusinessClassLabel_CheckedChanged);
            // 
            // checkBoxHasBusinessClass
            // 
            this.checkBoxHasBusinessClass.AutoSize = true;
            this.checkBoxHasBusinessClass.Location = new System.Drawing.Point(246, 299);
            this.checkBoxHasBusinessClass.Name = "checkBoxHasBusinessClass";
            this.checkBoxHasBusinessClass.Size = new System.Drawing.Size(230, 29);
            this.checkBoxHasBusinessClass.TabIndex = 15;
            this.checkBoxHasBusinessClass.Text = "Есть бизнес-класс";
            this.checkBoxHasBusinessClass.Visible = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.checkBoxHasBusinessClassLabel);
            this.Controls.Add(this.buttonChooseColor);
            this.Controls.Add(this.buttonChooseFont);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.buttonLoadFromFile);
            this.Controls.Add(this.buttonSaveToFile);
            this.Controls.Add(this.listBoxAirplanes);
            this.Controls.Add(this.buttonAddAirplaneWithFoto);
            this.Controls.Add(this.textBoxPassengerCapacityLabel);
            this.Controls.Add(this.checkBoxHasBusinessClass);
            this.Controls.Add(this.numericUpDownPassengerCapacity);
            this.Controls.Add(this.textBoxCargoTypeLabel);
            this.Controls.Add(this.textBoxCargoType);
            this.Controls.Add(this.textBoxCargoCapacityLabel);
            this.Controls.Add(this.numericUpDownCargoCapacity);
            this.Controls.Add(this.labelManufactureDate);
            this.Controls.Add(this.dateTimePickerManufactureDate);
            this.Controls.Add(this.labelFuelConsumption);
            this.Controls.Add(this.numericUpDownFuelConsumption);
            this.Controls.Add(this.labelRange);
            this.Controls.Add(this.numericUpDownRange);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.comboBoxModel);
            this.Controls.Add(this.labelAirplaneName);
            this.Controls.Add(this.textBoxAirplaneName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFuelConsumption)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCargoCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPassengerCapacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        private TextBox textBoxAirplaneName;
        private Label labelAirplaneName;
        private ComboBox comboBoxModel;
        private Label labelModel;
        private NumericUpDown numericUpDownRange;
        private Label labelRange;
        private NumericUpDown numericUpDownFuelConsumption;
        private Label labelFuelConsumption;
        private DateTimePicker dateTimePickerManufactureDate;
        private Label labelManufactureDate;
        private NumericUpDown numericUpDownCargoCapacity;
        private TextBox textBoxCargoType;
        private Label textBoxCargoCapacityLabel;
        private Label textBoxCargoTypeLabel;
        private NumericUpDown numericUpDownPassengerCapacity;
        private Label textBoxPassengerCapacityLabel;
        private Button buttonAddAirplaneWithFoto;
        private ListBox listBoxAirplanes;
        private Button buttonSaveToFile;
        private Button buttonLoadFromFile;
        private TextBox textBoxOutput;
        private Button buttonChooseFont;
        private Button buttonChooseColor;
        private CheckBox checkBoxHasBusinessClassLabel;
        private CheckBox checkBoxHasBusinessClass;
    }
}
