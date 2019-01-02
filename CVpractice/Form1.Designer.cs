namespace CVpractice
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLbp = new System.Windows.Forms.Button();
            this.btnSharpen = new System.Windows.Forms.Button();
            this.btnWord = new System.Windows.Forms.Button();
            this.btnLP = new System.Windows.Forms.Button();
            this.btn_findred = new System.Windows.Forms.Button();
            this.btnCut = new System.Windows.Forms.Button();
            this.btnPryDown = new System.Windows.Forms.Button();
            this.btnPryUp = new System.Windows.Forms.Button();
            this.btnCalcHist = new System.Windows.Forms.Button();
            this.btnLaplacian = new System.Windows.Forms.Button();
            this.btnThreshold = new System.Windows.Forms.Button();
            this.btnGetRedChanel = new System.Windows.Forms.Button();
            this.btnGray = new System.Windows.Forms.Button();
            this.btnSLBP = new System.Windows.Forms.Button();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.histogramBox1 = new Emgu.CV.UI.HistogramBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ocrOptionsComboBox = new System.Windows.Forms.ComboBox();
            this.ocrTextBox = new System.Windows.Forms.TextBox();
            this.languageNameLabel = new System.Windows.Forms.Label();
            this.btnasLBP = new System.Windows.Forms.Button();
            this.btnOutLBP = new System.Windows.Forms.Button();
            this.btnLTP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Location = new System.Drawing.Point(10, 12);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(75, 23);
            this.btnLoadImage.TabIndex = 0;
            this.btnLoadImage.Text = "LoadImage";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(91, 12);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(592, 22);
            this.txtPath.TabIndex = 1;
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(10, 149);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(312, 260);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLTP);
            this.groupBox1.Controls.Add(this.btnLbp);
            this.groupBox1.Controls.Add(this.btnSharpen);
            this.groupBox1.Controls.Add(this.btnWord);
            this.groupBox1.Controls.Add(this.btnLP);
            this.groupBox1.Controls.Add(this.btn_findred);
            this.groupBox1.Controls.Add(this.btnCut);
            this.groupBox1.Controls.Add(this.btnPryDown);
            this.groupBox1.Controls.Add(this.btnPryUp);
            this.groupBox1.Controls.Add(this.btnCalcHist);
            this.groupBox1.Controls.Add(this.btnLaplacian);
            this.groupBox1.Controls.Add(this.btnThreshold);
            this.groupBox1.Controls.Add(this.btnGetRedChanel);
            this.groupBox1.Controls.Add(this.btnGray);
            this.groupBox1.Location = new System.Drawing.Point(10, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(673, 74);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setup";
            // 
            // btnLbp
            // 
            this.btnLbp.Location = new System.Drawing.Point(577, 21);
            this.btnLbp.Name = "btnLbp";
            this.btnLbp.Size = new System.Drawing.Size(75, 23);
            this.btnLbp.TabIndex = 15;
            this.btnLbp.Text = "LBP";
            this.btnLbp.UseVisualStyleBackColor = true;
            this.btnLbp.Click += new System.EventHandler(this.btnLbp_Click);
            // 
            // btnSharpen
            // 
            this.btnSharpen.Location = new System.Drawing.Point(334, 45);
            this.btnSharpen.Name = "btnSharpen";
            this.btnSharpen.Size = new System.Drawing.Size(75, 23);
            this.btnSharpen.TabIndex = 12;
            this.btnSharpen.Text = "Sharpen";
            this.btnSharpen.UseVisualStyleBackColor = true;
            this.btnSharpen.Click += new System.EventHandler(this.btnSharpen_Click);
            // 
            // btnWord
            // 
            this.btnWord.Location = new System.Drawing.Point(253, 45);
            this.btnWord.Name = "btnWord";
            this.btnWord.Size = new System.Drawing.Size(75, 23);
            this.btnWord.TabIndex = 11;
            this.btnWord.Text = "convolution";
            this.btnWord.UseVisualStyleBackColor = true;
            this.btnWord.Click += new System.EventHandler(this.btnWord_Click);
            // 
            // btnLP
            // 
            this.btnLP.Location = new System.Drawing.Point(172, 45);
            this.btnLP.Name = "btnLP";
            this.btnLP.Size = new System.Drawing.Size(75, 23);
            this.btnLP.TabIndex = 10;
            this.btnLP.Text = "中值濾波";
            this.btnLP.UseVisualStyleBackColor = true;
            this.btnLP.Click += new System.EventHandler(this.btnLP_Click);
            // 
            // btn_findred
            // 
            this.btn_findred.Location = new System.Drawing.Point(91, 45);
            this.btn_findred.Name = "btn_findred";
            this.btn_findred.Size = new System.Drawing.Size(75, 23);
            this.btn_findred.TabIndex = 9;
            this.btn_findred.Text = "找紅色";
            this.btn_findred.UseVisualStyleBackColor = true;
            this.btn_findred.Click += new System.EventHandler(this.btn_findred_Click);
            // 
            // btnCut
            // 
            this.btnCut.Location = new System.Drawing.Point(10, 45);
            this.btnCut.Name = "btnCut";
            this.btnCut.Size = new System.Drawing.Size(75, 23);
            this.btnCut.TabIndex = 8;
            this.btnCut.Text = "影像切割";
            this.btnCut.UseVisualStyleBackColor = true;
            this.btnCut.Click += new System.EventHandler(this.btnCut_Click);
            // 
            // btnPryDown
            // 
            this.btnPryDown.Location = new System.Drawing.Point(496, 21);
            this.btnPryDown.Name = "btnPryDown";
            this.btnPryDown.Size = new System.Drawing.Size(75, 23);
            this.btnPryDown.TabIndex = 7;
            this.btnPryDown.Text = "PryDown";
            this.btnPryDown.UseVisualStyleBackColor = true;
            this.btnPryDown.Click += new System.EventHandler(this.btnPryDown_Click);
            // 
            // btnPryUp
            // 
            this.btnPryUp.Location = new System.Drawing.Point(415, 21);
            this.btnPryUp.Name = "btnPryUp";
            this.btnPryUp.Size = new System.Drawing.Size(75, 23);
            this.btnPryUp.TabIndex = 6;
            this.btnPryUp.Text = "PryUp";
            this.btnPryUp.UseVisualStyleBackColor = true;
            this.btnPryUp.Click += new System.EventHandler(this.btnPryUp_Click);
            // 
            // btnCalcHist
            // 
            this.btnCalcHist.Location = new System.Drawing.Point(334, 21);
            this.btnCalcHist.Name = "btnCalcHist";
            this.btnCalcHist.Size = new System.Drawing.Size(75, 23);
            this.btnCalcHist.TabIndex = 5;
            this.btnCalcHist.Text = "直方圖";
            this.btnCalcHist.UseVisualStyleBackColor = true;
            this.btnCalcHist.Click += new System.EventHandler(this.btnCalcHist_Click);
            // 
            // btnLaplacian
            // 
            this.btnLaplacian.Location = new System.Drawing.Point(253, 21);
            this.btnLaplacian.Name = "btnLaplacian";
            this.btnLaplacian.Size = new System.Drawing.Size(75, 23);
            this.btnLaplacian.TabIndex = 4;
            this.btnLaplacian.Text = "Canny";
            this.btnLaplacian.UseVisualStyleBackColor = true;
            this.btnLaplacian.Click += new System.EventHandler(this.btnLaplacian_Click);
            // 
            // btnThreshold
            // 
            this.btnThreshold.Location = new System.Drawing.Point(172, 21);
            this.btnThreshold.Name = "btnThreshold";
            this.btnThreshold.Size = new System.Drawing.Size(75, 23);
            this.btnThreshold.TabIndex = 3;
            this.btnThreshold.Text = "Threshold";
            this.btnThreshold.UseVisualStyleBackColor = true;
            this.btnThreshold.Click += new System.EventHandler(this.btnThreshold_Click);
            // 
            // btnGetRedChanel
            // 
            this.btnGetRedChanel.Location = new System.Drawing.Point(91, 21);
            this.btnGetRedChanel.Name = "btnGetRedChanel";
            this.btnGetRedChanel.Size = new System.Drawing.Size(75, 23);
            this.btnGetRedChanel.TabIndex = 2;
            this.btnGetRedChanel.Text = "GetRedChanel";
            this.btnGetRedChanel.UseVisualStyleBackColor = true;
            this.btnGetRedChanel.Click += new System.EventHandler(this.btnGetRedChanel_Click);
            // 
            // btnGray
            // 
            this.btnGray.Location = new System.Drawing.Point(10, 21);
            this.btnGray.Name = "btnGray";
            this.btnGray.Size = new System.Drawing.Size(75, 23);
            this.btnGray.TabIndex = 0;
            this.btnGray.Text = "Gray";
            this.btnGray.UseVisualStyleBackColor = true;
            this.btnGray.Click += new System.EventHandler(this.btnGray_Click);
            // 
            // btnSLBP
            // 
            this.btnSLBP.Location = new System.Drawing.Point(674, 301);
            this.btnSLBP.Name = "btnSLBP";
            this.btnSLBP.Size = new System.Drawing.Size(75, 23);
            this.btnSLBP.TabIndex = 16;
            this.btnSLBP.Text = "sLBP";
            this.btnSLBP.UseVisualStyleBackColor = true;
            this.btnSLBP.Click += new System.EventHandler(this.btnSLBP_Click);
            // 
            // imageBox2
            // 
            this.imageBox2.Location = new System.Drawing.Point(328, 149);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(312, 260);
            this.imageBox2.TabIndex = 4;
            this.imageBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(7, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(325, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Output";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // histogramBox1
            // 
            this.histogramBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.histogramBox1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.histogramBox1.Location = new System.Drawing.Point(689, 28);
            this.histogramBox1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.histogramBox1.Name = "histogramBox1";
            this.histogramBox1.Size = new System.Drawing.Size(280, 236);
            this.histogramBox1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(797, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "histogramBox";
            // 
            // ocrOptionsComboBox
            // 
            this.ocrOptionsComboBox.FormattingEnabled = true;
            this.ocrOptionsComboBox.Items.AddRange(new object[] {
            "Full Page OCR",
            "Text Region Detection"});
            this.ocrOptionsComboBox.Location = new System.Drawing.Point(770, 297);
            this.ocrOptionsComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.ocrOptionsComboBox.Name = "ocrOptionsComboBox";
            this.ocrOptionsComboBox.Size = new System.Drawing.Size(147, 20);
            this.ocrOptionsComboBox.TabIndex = 9;
            // 
            // ocrTextBox
            // 
            this.ocrTextBox.Location = new System.Drawing.Point(770, 336);
            this.ocrTextBox.Multiline = true;
            this.ocrTextBox.Name = "ocrTextBox";
            this.ocrTextBox.Size = new System.Drawing.Size(147, 61);
            this.ocrTextBox.TabIndex = 10;
            // 
            // languageNameLabel
            // 
            this.languageNameLabel.AutoSize = true;
            this.languageNameLabel.Location = new System.Drawing.Point(832, 412);
            this.languageNameLabel.Name = "languageNameLabel";
            this.languageNameLabel.Size = new System.Drawing.Size(85, 12);
            this.languageNameLabel.TabIndex = 11;
            this.languageNameLabel.Text = "{language name}";
            // 
            // btnasLBP
            // 
            this.btnasLBP.Location = new System.Drawing.Point(674, 339);
            this.btnasLBP.Name = "btnasLBP";
            this.btnasLBP.Size = new System.Drawing.Size(75, 23);
            this.btnasLBP.TabIndex = 17;
            this.btnasLBP.Text = "asLBP";
            this.btnasLBP.UseVisualStyleBackColor = true;
            this.btnasLBP.Click += new System.EventHandler(this.btnasLBP_Click);
            // 
            // btnOutLBP
            // 
            this.btnOutLBP.Location = new System.Drawing.Point(674, 374);
            this.btnOutLBP.Name = "btnOutLBP";
            this.btnOutLBP.Size = new System.Drawing.Size(75, 23);
            this.btnOutLBP.TabIndex = 18;
            this.btnOutLBP.Text = "OutLBP";
            this.btnOutLBP.UseVisualStyleBackColor = true;
            this.btnOutLBP.Click += new System.EventHandler(this.btnOutLBP_Click);
            // 
            // btnLTP
            // 
            this.btnLTP.Location = new System.Drawing.Point(577, 45);
            this.btnLTP.Name = "btnLTP";
            this.btnLTP.Size = new System.Drawing.Size(75, 23);
            this.btnLTP.TabIndex = 16;
            this.btnLTP.Text = "LTP";
            this.btnLTP.UseVisualStyleBackColor = true;
            this.btnLTP.Click += new System.EventHandler(this.btnLTP_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 448);
            this.Controls.Add(this.btnOutLBP);
            this.Controls.Add(this.btnasLBP);
            this.Controls.Add(this.btnSLBP);
            this.Controls.Add(this.languageNameLabel);
            this.Controls.Add(this.ocrTextBox);
            this.Controls.Add(this.ocrOptionsComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.histogramBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imageBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.imageBox1);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnLoadImage);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.TextBox txtPath;
        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Emgu.CV.UI.ImageBox imageBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnGray;
        private System.Windows.Forms.Button btnGetRedChanel;
        private System.Windows.Forms.Button btnThreshold;
        private System.Windows.Forms.Button btnLaplacian;
        private System.Windows.Forms.Button btnCalcHist;
        private Emgu.CV.UI.HistogramBox histogramBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPryUp;
        private System.Windows.Forms.Button btnPryDown;
        private System.Windows.Forms.Button btnCut;
        private System.Windows.Forms.Button btn_findred;
        private System.Windows.Forms.Button btnLP;
        private System.Windows.Forms.Button btnWord;
        private System.Windows.Forms.Button btnSharpen;
        private System.Windows.Forms.ComboBox ocrOptionsComboBox;
        private System.Windows.Forms.TextBox ocrTextBox;
        private System.Windows.Forms.Label languageNameLabel;
        private System.Windows.Forms.Button btnLbp;
        private System.Windows.Forms.Button btnSLBP;
        private System.Windows.Forms.Button btnasLBP;
        private System.Windows.Forms.Button btnOutLBP;
        private System.Windows.Forms.Button btnLTP;
    }
}

