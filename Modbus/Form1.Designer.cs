namespace Modbus
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
            this.lblPort = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.tbxIpAddress = new System.Windows.Forms.TextBox();
            this.tbxPort = new System.Windows.Forms.TextBox();
            this.lblIpAddress = new System.Windows.Forms.Label();
            this.lblRegister = new System.Windows.Forms.Label();
            this.btnReadHolding = new System.Windows.Forms.Button();
            this.btnReadInputRegisters = new System.Windows.Forms.Button();
            this.btnReadCoil = new System.Windows.Forms.Button();
            this.btnReadDiscreteInputs = new System.Windows.Forms.Button();
            this.tbxValue = new System.Windows.Forms.TextBox();
            this.lblValue = new System.Windows.Forms.Label();
            this.btnWriteHolding = new System.Windows.Forms.Button();
            this.btnWriteCoil = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.lblStatusTxt = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.dgvRead = new System.Windows.Forms.DataGridView();
            this.btnWriteMultiCoils = new System.Windows.Forms.Button();
            this.btnWriteMultiHolding = new System.Windows.Forms.Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblQuantityRead = new System.Windows.Forms.Label();
            this.btnReadMultiHolding = new System.Windows.Forms.Button();
            this.btnReadMultiCoil = new System.Windows.Forms.Button();
            this.btnReadMultiInputRegisters = new System.Windows.Forms.Button();
            this.btnReadMultiDiscreteInputs = new System.Windows.Forms.Button();
            this.gbxConnection = new System.Windows.Forms.GroupBox();
            this.gbxReadFunction = new System.Windows.Forms.GroupBox();
            this.gbxWriteFunctions = new System.Windows.Forms.GroupBox();
            this.tbxQuantityWrite = new System.Windows.Forms.NumericUpDown();
            this.btnClear = new System.Windows.Forms.Button();
            this.tbxRegister = new System.Windows.Forms.NumericUpDown();
            this.tbxQuantityRead = new System.Windows.Forms.NumericUpDown();
            this.btnLogToText = new System.Windows.Forms.Button();
            this.btnDeleteFromView = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.ImportDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRead)).BeginInit();
            this.gbxConnection.SuspendLayout();
            this.gbxReadFunction.SuspendLayout();
            this.gbxWriteFunctions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbxQuantityWrite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxRegister)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxQuantityRead)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPort.Location = new System.Drawing.Point(69, 54);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(42, 20);
            this.lblPort.TabIndex = 0;
            this.lblPort.Text = "Port";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(89, 106);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(90, 55);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // tbxIpAddress
            // 
            this.tbxIpAddress.Location = new System.Drawing.Point(117, 25);
            this.tbxIpAddress.Name = "tbxIpAddress";
            this.tbxIpAddress.Size = new System.Drawing.Size(134, 20);
            this.tbxIpAddress.TabIndex = 8;
            this.tbxIpAddress.Text = "127.0.0.1";
            // 
            // tbxPort
            // 
            this.tbxPort.Location = new System.Drawing.Point(117, 54);
            this.tbxPort.Name = "tbxPort";
            this.tbxPort.Size = new System.Drawing.Size(46, 20);
            this.tbxPort.TabIndex = 9;
            this.tbxPort.Text = "502";
            // 
            // lblIpAddress
            // 
            this.lblIpAddress.AutoSize = true;
            this.lblIpAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIpAddress.Location = new System.Drawing.Point(15, 25);
            this.lblIpAddress.Name = "lblIpAddress";
            this.lblIpAddress.Size = new System.Drawing.Size(96, 20);
            this.lblIpAddress.TabIndex = 13;
            this.lblIpAddress.Text = "Ip Address";
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRegister.Location = new System.Drawing.Point(4, 226);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(77, 20);
            this.lblRegister.TabIndex = 15;
            this.lblRegister.Text = "Register";
            // 
            // btnReadHolding
            // 
            this.btnReadHolding.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReadHolding.Location = new System.Drawing.Point(19, 31);
            this.btnReadHolding.Name = "btnReadHolding";
            this.btnReadHolding.Size = new System.Drawing.Size(54, 55);
            this.btnReadHolding.TabIndex = 17;
            this.btnReadHolding.Text = "Read Holding";
            this.btnReadHolding.UseVisualStyleBackColor = true;
            this.btnReadHolding.Click += new System.EventHandler(this.btnReadHolding_Click);
            // 
            // btnReadInputRegisters
            // 
            this.btnReadInputRegisters.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReadInputRegisters.Location = new System.Drawing.Point(79, 31);
            this.btnReadInputRegisters.Name = "btnReadInputRegisters";
            this.btnReadInputRegisters.Size = new System.Drawing.Size(64, 55);
            this.btnReadInputRegisters.TabIndex = 18;
            this.btnReadInputRegisters.Text = "Read Input Registers";
            this.btnReadInputRegisters.UseVisualStyleBackColor = true;
            this.btnReadInputRegisters.Click += new System.EventHandler(this.btnReadInputRegisters_Click);
            // 
            // btnReadCoil
            // 
            this.btnReadCoil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReadCoil.Location = new System.Drawing.Point(149, 31);
            this.btnReadCoil.Name = "btnReadCoil";
            this.btnReadCoil.Size = new System.Drawing.Size(56, 55);
            this.btnReadCoil.TabIndex = 19;
            this.btnReadCoil.Text = "Read Coil";
            this.btnReadCoil.UseVisualStyleBackColor = true;
            this.btnReadCoil.Click += new System.EventHandler(this.btnReadCoil_Click);
            // 
            // btnReadDiscreteInputs
            // 
            this.btnReadDiscreteInputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReadDiscreteInputs.Location = new System.Drawing.Point(211, 31);
            this.btnReadDiscreteInputs.Name = "btnReadDiscreteInputs";
            this.btnReadDiscreteInputs.Size = new System.Drawing.Size(68, 55);
            this.btnReadDiscreteInputs.TabIndex = 20;
            this.btnReadDiscreteInputs.Text = "Read Discrete Inputs";
            this.btnReadDiscreteInputs.UseVisualStyleBackColor = true;
            this.btnReadDiscreteInputs.Click += new System.EventHandler(this.btnReadDiscreteInputs_Click);
            // 
            // tbxValue
            // 
            this.tbxValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxValue.Location = new System.Drawing.Point(65, 28);
            this.tbxValue.Name = "tbxValue";
            this.tbxValue.Size = new System.Drawing.Size(134, 20);
            this.tbxValue.TabIndex = 22;
            this.tbxValue.Text = "0";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblValue.Location = new System.Drawing.Point(4, 28);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(55, 20);
            this.lblValue.TabIndex = 21;
            this.lblValue.Text = "Value";
            // 
            // btnWriteHolding
            // 
            this.btnWriteHolding.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnWriteHolding.Location = new System.Drawing.Point(65, 59);
            this.btnWriteHolding.Name = "btnWriteHolding";
            this.btnWriteHolding.Size = new System.Drawing.Size(90, 55);
            this.btnWriteHolding.TabIndex = 23;
            this.btnWriteHolding.Text = "Write Holding";
            this.btnWriteHolding.UseVisualStyleBackColor = true;
            this.btnWriteHolding.Click += new System.EventHandler(this.btnWriteHolding_Click);
            // 
            // btnWriteCoil
            // 
            this.btnWriteCoil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnWriteCoil.Location = new System.Drawing.Point(161, 59);
            this.btnWriteCoil.Name = "btnWriteCoil";
            this.btnWriteCoil.Size = new System.Drawing.Size(90, 55);
            this.btnWriteCoil.TabIndex = 24;
            this.btnWriteCoil.Text = "Write Coil";
            this.btnWriteCoil.UseVisualStyleBackColor = true;
            this.btnWriteCoil.Click += new System.EventHandler(this.btnWriteCoil_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(185, 106);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(90, 55);
            this.btnDisconnect.TabIndex = 25;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // lblStatusTxt
            // 
            this.lblStatusTxt.AutoSize = true;
            this.lblStatusTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStatusTxt.Location = new System.Drawing.Point(325, 23);
            this.lblStatusTxt.Name = "lblStatusTxt";
            this.lblStatusTxt.Size = new System.Drawing.Size(67, 20);
            this.lblStatusTxt.TabIndex = 26;
            this.lblStatusTxt.Text = "Status:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStatus.Location = new System.Drawing.Point(391, 23);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(107, 20);
            this.lblStatus.TabIndex = 27;
            this.lblStatus.Text = "Disconnected";
            // 
            // dgvRead
            // 
            this.dgvRead.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRead.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvRead.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRead.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvRead.Location = new System.Drawing.Point(513, 0);
            this.dgvRead.Name = "dgvRead";
            this.dgvRead.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvRead.Size = new System.Drawing.Size(571, 649);
            this.dgvRead.TabIndex = 28;
            // 
            // btnWriteMultiCoils
            // 
            this.btnWriteMultiCoils.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnWriteMultiCoils.Location = new System.Drawing.Point(161, 120);
            this.btnWriteMultiCoils.Name = "btnWriteMultiCoils";
            this.btnWriteMultiCoils.Size = new System.Drawing.Size(90, 55);
            this.btnWriteMultiCoils.TabIndex = 29;
            this.btnWriteMultiCoils.Text = "Write Multi Coils";
            this.btnWriteMultiCoils.UseVisualStyleBackColor = true;
            this.btnWriteMultiCoils.Click += new System.EventHandler(this.btnWriteMulti_Click);
            // 
            // btnWriteMultiHolding
            // 
            this.btnWriteMultiHolding.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnWriteMultiHolding.Location = new System.Drawing.Point(65, 120);
            this.btnWriteMultiHolding.Name = "btnWriteMultiHolding";
            this.btnWriteMultiHolding.Size = new System.Drawing.Size(90, 55);
            this.btnWriteMultiHolding.TabIndex = 30;
            this.btnWriteMultiHolding.Text = "Write Multi Holding";
            this.btnWriteMultiHolding.UseVisualStyleBackColor = true;
            this.btnWriteMultiHolding.Click += new System.EventHandler(this.BtnWriteMultiHolding_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblQuantity.Location = new System.Drawing.Point(207, 28);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(76, 20);
            this.lblQuantity.TabIndex = 32;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblQuantityRead
            // 
            this.lblQuantityRead.AutoSize = true;
            this.lblQuantityRead.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblQuantityRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblQuantityRead.Location = new System.Drawing.Point(178, 226);
            this.lblQuantityRead.Name = "lblQuantityRead";
            this.lblQuantityRead.Size = new System.Drawing.Size(76, 20);
            this.lblQuantityRead.TabIndex = 34;
            this.lblQuantityRead.Text = "Quantity";
            // 
            // btnReadMultiHolding
            // 
            this.btnReadMultiHolding.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReadMultiHolding.Location = new System.Drawing.Point(19, 92);
            this.btnReadMultiHolding.Name = "btnReadMultiHolding";
            this.btnReadMultiHolding.Size = new System.Drawing.Size(54, 55);
            this.btnReadMultiHolding.TabIndex = 35;
            this.btnReadMultiHolding.Text = "Read Multi Holding";
            this.btnReadMultiHolding.UseVisualStyleBackColor = true;
            this.btnReadMultiHolding.Click += new System.EventHandler(this.btnReadMultiHolding_Click);
            // 
            // btnReadMultiCoil
            // 
            this.btnReadMultiCoil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReadMultiCoil.Location = new System.Drawing.Point(147, 92);
            this.btnReadMultiCoil.Name = "btnReadMultiCoil";
            this.btnReadMultiCoil.Size = new System.Drawing.Size(58, 55);
            this.btnReadMultiCoil.TabIndex = 36;
            this.btnReadMultiCoil.Text = "Read Multi Coil";
            this.btnReadMultiCoil.UseVisualStyleBackColor = true;
            this.btnReadMultiCoil.Click += new System.EventHandler(this.btnReadMultiCoil_Click);
            // 
            // btnReadMultiInputRegisters
            // 
            this.btnReadMultiInputRegisters.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReadMultiInputRegisters.Location = new System.Drawing.Point(79, 92);
            this.btnReadMultiInputRegisters.Name = "btnReadMultiInputRegisters";
            this.btnReadMultiInputRegisters.Size = new System.Drawing.Size(64, 55);
            this.btnReadMultiInputRegisters.TabIndex = 37;
            this.btnReadMultiInputRegisters.Text = "Read Multi Input Registers";
            this.btnReadMultiInputRegisters.UseVisualStyleBackColor = true;
            this.btnReadMultiInputRegisters.Click += new System.EventHandler(this.btnReadMultiInputRegisters_Click);
            // 
            // btnReadMultiDiscreteInputs
            // 
            this.btnReadMultiDiscreteInputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReadMultiDiscreteInputs.Location = new System.Drawing.Point(211, 92);
            this.btnReadMultiDiscreteInputs.Name = "btnReadMultiDiscreteInputs";
            this.btnReadMultiDiscreteInputs.Size = new System.Drawing.Size(68, 55);
            this.btnReadMultiDiscreteInputs.TabIndex = 38;
            this.btnReadMultiDiscreteInputs.Text = "Read Multi Discrete Inputs";
            this.btnReadMultiDiscreteInputs.UseVisualStyleBackColor = true;
            this.btnReadMultiDiscreteInputs.Click += new System.EventHandler(this.btnReadMultiDiscreteInputs_Click);
            // 
            // gbxConnection
            // 
            this.gbxConnection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbxConnection.Controls.Add(this.lblStatus);
            this.gbxConnection.Controls.Add(this.btnConnect);
            this.gbxConnection.Controls.Add(this.btnDisconnect);
            this.gbxConnection.Controls.Add(this.lblPort);
            this.gbxConnection.Controls.Add(this.lblStatusTxt);
            this.gbxConnection.Controls.Add(this.tbxIpAddress);
            this.gbxConnection.Controls.Add(this.lblIpAddress);
            this.gbxConnection.Controls.Add(this.tbxPort);
            this.gbxConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxConnection.Location = new System.Drawing.Point(3, 12);
            this.gbxConnection.Name = "gbxConnection";
            this.gbxConnection.Size = new System.Drawing.Size(504, 196);
            this.gbxConnection.TabIndex = 40;
            this.gbxConnection.TabStop = false;
            this.gbxConnection.Text = "Connection";
            // 
            // gbxReadFunction
            // 
            this.gbxReadFunction.Controls.Add(this.btnReadDiscreteInputs);
            this.gbxReadFunction.Controls.Add(this.btnReadHolding);
            this.gbxReadFunction.Controls.Add(this.btnReadMultiDiscreteInputs);
            this.gbxReadFunction.Controls.Add(this.btnReadInputRegisters);
            this.gbxReadFunction.Controls.Add(this.btnReadMultiInputRegisters);
            this.gbxReadFunction.Controls.Add(this.btnReadCoil);
            this.gbxReadFunction.Controls.Add(this.btnReadMultiCoil);
            this.gbxReadFunction.Controls.Add(this.btnReadMultiHolding);
            this.gbxReadFunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxReadFunction.Location = new System.Drawing.Point(8, 252);
            this.gbxReadFunction.Name = "gbxReadFunction";
            this.gbxReadFunction.Size = new System.Drawing.Size(339, 191);
            this.gbxReadFunction.TabIndex = 41;
            this.gbxReadFunction.TabStop = false;
            this.gbxReadFunction.Text = "Read Functions";
            // 
            // gbxWriteFunctions
            // 
            this.gbxWriteFunctions.Controls.Add(this.tbxQuantityWrite);
            this.gbxWriteFunctions.Controls.Add(this.btnWriteCoil);
            this.gbxWriteFunctions.Controls.Add(this.lblValue);
            this.gbxWriteFunctions.Controls.Add(this.tbxValue);
            this.gbxWriteFunctions.Controls.Add(this.btnWriteHolding);
            this.gbxWriteFunctions.Controls.Add(this.btnWriteMultiCoils);
            this.gbxWriteFunctions.Controls.Add(this.lblQuantity);
            this.gbxWriteFunctions.Controls.Add(this.btnWriteMultiHolding);
            this.gbxWriteFunctions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxWriteFunctions.Location = new System.Drawing.Point(8, 449);
            this.gbxWriteFunctions.Name = "gbxWriteFunctions";
            this.gbxWriteFunctions.Size = new System.Drawing.Size(339, 191);
            this.gbxWriteFunctions.TabIndex = 42;
            this.gbxWriteFunctions.TabStop = false;
            this.gbxWriteFunctions.Text = "Write Functions";
            // 
            // tbxQuantityWrite
            // 
            this.tbxQuantityWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxQuantityWrite.Location = new System.Drawing.Point(289, 28);
            this.tbxQuantityWrite.Name = "tbxQuantityWrite";
            this.tbxQuantityWrite.Size = new System.Drawing.Size(39, 20);
            this.tbxQuantityWrite.TabIndex = 46;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(398, 420);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(109, 23);
            this.btnClear.TabIndex = 43;
            this.btnClear.Text = "Clear to View";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tbxRegister
            // 
            this.tbxRegister.Location = new System.Drawing.Point(87, 226);
            this.tbxRegister.Name = "tbxRegister";
            this.tbxRegister.Size = new System.Drawing.Size(76, 20);
            this.tbxRegister.TabIndex = 44;
            // 
            // tbxQuantityRead
            // 
            this.tbxQuantityRead.Location = new System.Drawing.Point(260, 226);
            this.tbxQuantityRead.Name = "tbxQuantityRead";
            this.tbxQuantityRead.Size = new System.Drawing.Size(76, 20);
            this.tbxQuantityRead.TabIndex = 45;
            // 
            // btnLogToText
            // 
            this.btnLogToText.Location = new System.Drawing.Point(373, 585);
            this.btnLogToText.Name = "btnLogToText";
            this.btnLogToText.Size = new System.Drawing.Size(134, 23);
            this.btnLogToText.TabIndex = 46;
            this.btnLogToText.Text = "Log to Text";
            this.btnLogToText.UseVisualStyleBackColor = true;
            this.btnLogToText.Click += new System.EventHandler(this.btnLogToText_Click);
            // 
            // btnDeleteFromView
            // 
            this.btnDeleteFromView.Location = new System.Drawing.Point(398, 449);
            this.btnDeleteFromView.Name = "btnDeleteFromView";
            this.btnDeleteFromView.Size = new System.Drawing.Size(109, 23);
            this.btnDeleteFromView.TabIndex = 47;
            this.btnDeleteFromView.Text = "Delete From View";
            this.btnDeleteFromView.UseVisualStyleBackColor = true;
            this.btnDeleteFromView.Click += new System.EventHandler(this.btnDeleteFromView_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(373, 614);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(134, 23);
            this.btnImport.TabIndex = 48;
            this.btnImport.Text = "Import from Text";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // ImportDialog
            // 
            this.ImportDialog.Filter = "Rich Text Format|*.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1084, 649);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnDeleteFromView);
            this.Controls.Add(this.btnLogToText);
            this.Controls.Add(this.tbxQuantityRead);
            this.Controls.Add(this.tbxRegister);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.gbxWriteFunctions);
            this.Controls.Add(this.gbxReadFunction);
            this.Controls.Add(this.gbxConnection);
            this.Controls.Add(this.lblQuantityRead);
            this.Controls.Add(this.dgvRead);
            this.Controls.Add(this.lblRegister);
            this.Name = "Form1";
            this.Text = "TCP/IP";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRead)).EndInit();
            this.gbxConnection.ResumeLayout(false);
            this.gbxConnection.PerformLayout();
            this.gbxReadFunction.ResumeLayout(false);
            this.gbxWriteFunctions.ResumeLayout(false);
            this.gbxWriteFunctions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbxQuantityWrite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxRegister)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxQuantityRead)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox tbxIpAddress;
        private System.Windows.Forms.TextBox tbxPort;
        private System.Windows.Forms.Label lblIpAddress;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.Button btnReadHolding;
        private System.Windows.Forms.Button btnReadInputRegisters;
        private System.Windows.Forms.Button btnReadCoil;
        private System.Windows.Forms.Button btnReadDiscreteInputs;
        private System.Windows.Forms.TextBox tbxValue;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Button btnWriteHolding;
        private System.Windows.Forms.Button btnWriteCoil;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Label lblStatusTxt;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DataGridView dgvRead;
        private System.Windows.Forms.Button btnWriteMultiCoils;
        private System.Windows.Forms.Button btnWriteMultiHolding;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblQuantityRead;
        private System.Windows.Forms.Button btnReadMultiHolding;
        private System.Windows.Forms.Button btnReadMultiCoil;
        private System.Windows.Forms.Button btnReadMultiInputRegisters;
        private System.Windows.Forms.Button btnReadMultiDiscreteInputs;
        private System.Windows.Forms.GroupBox gbxConnection;
        private System.Windows.Forms.GroupBox gbxReadFunction;
        private System.Windows.Forms.GroupBox gbxWriteFunctions;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.NumericUpDown tbxRegister;
        private System.Windows.Forms.NumericUpDown tbxQuantityRead;
        private System.Windows.Forms.NumericUpDown tbxQuantityWrite;
        private System.Windows.Forms.Button btnLogToText;
        private System.Windows.Forms.Button btnDeleteFromView;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.OpenFileDialog ImportDialog;
    }
}

