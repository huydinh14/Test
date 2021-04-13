
namespace View
{
    partial class frmGridView
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.gcEmployee = new DevExpress.XtraGrid.GridControl();
            this.gvEmployee = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemFontEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemFontEdit();
            this.colFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRule = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colNumberPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGender = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirthDay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPassWord = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDCard = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalary = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployOfTypeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.gcEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemFontEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // gcEmployee
            // 
            this.gcEmployee.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            gridLevelNode1.RelationName = "Level1";
            this.gcEmployee.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gcEmployee.Location = new System.Drawing.Point(3, 13);
            this.gcEmployee.MainView = this.gvEmployee;
            this.gcEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.gcEmployee.Name = "gcEmployee";
            this.gcEmployee.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemFontEdit1});
            this.gcEmployee.Size = new System.Drawing.Size(1273, 657);
            this.gcEmployee.TabIndex = 1;
            this.gcEmployee.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvEmployee});
            // 
            // gvEmployee
            // 
            this.gvEmployee.Appearance.GroupPanel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvEmployee.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvEmployee.Appearance.GroupPanel.Options.UseFont = true;
            this.gvEmployee.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvEmployee.Appearance.GroupPanel.Options.UseTextOptions = true;
            this.gvEmployee.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvEmployee.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colFullName,
            this.colRule,
            this.colNumberPhone,
            this.colGender,
            this.colBirthDay,
            this.colEmail,
            this.colPassWord,
            this.colIDCard,
            this.colSalary,
            this.colEmployOfTypeID,
            this.colStatus});
            this.gvEmployee.DetailHeight = 437;
            this.gvEmployee.GridControl = this.gcEmployee;
            this.gvEmployee.GroupPanelText = "Danh Sách Nhân Viên";
            this.gvEmployee.Name = "gvEmployee";
            this.gvEmployee.OptionsSelection.MultiSelect = true;
            // 
            // colID
            // 
            this.colID.Caption = "Mã NV";
            this.colID.ColumnEdit = this.repositoryItemFontEdit1;
            this.colID.FieldName = "StrID";
            this.colID.MinWidth = 31;
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 117;
            // 
            // repositoryItemFontEdit1
            // 
            this.repositoryItemFontEdit1.AutoHeight = false;
            this.repositoryItemFontEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemFontEdit1.Name = "repositoryItemFontEdit1";
            // 
            // colFullName
            // 
            this.colFullName.Caption = "Họ Tên";
            this.colFullName.FieldName = "StrFullName";
            this.colFullName.MinWidth = 31;
            this.colFullName.Name = "colFullName";
            this.colFullName.Visible = true;
            this.colFullName.VisibleIndex = 1;
            this.colFullName.Width = 117;
            // 
            // colRule
            // 
            this.colRule.Caption = "Chức Vụ";
            this.colRule.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colRule.FieldName = "StrEmployTypeID";
            this.colRule.MinWidth = 31;
            this.colRule.Name = "colRule";
            this.colRule.Visible = true;
            this.colRule.VisibleIndex = 2;
            this.colRule.Width = 117;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // colNumberPhone
            // 
            this.colNumberPhone.Caption = "SĐT";
            this.colNumberPhone.FieldName = "StrNumberPhone";
            this.colNumberPhone.MinWidth = 31;
            this.colNumberPhone.Name = "colNumberPhone";
            this.colNumberPhone.Visible = true;
            this.colNumberPhone.VisibleIndex = 3;
            this.colNumberPhone.Width = 117;
            // 
            // colGender
            // 
            this.colGender.Caption = "Giới Tính";
            this.colGender.FieldName = "StrGender";
            this.colGender.MinWidth = 31;
            this.colGender.Name = "colGender";
            this.colGender.Visible = true;
            this.colGender.VisibleIndex = 4;
            this.colGender.Width = 117;
            // 
            // colBirthDay
            // 
            this.colBirthDay.Caption = "Ngày Sinh";
            this.colBirthDay.FieldName = "DTBirthDay";
            this.colBirthDay.MinWidth = 25;
            this.colBirthDay.Name = "colBirthDay";
            this.colBirthDay.Visible = true;
            this.colBirthDay.VisibleIndex = 5;
            this.colBirthDay.Width = 94;
            // 
            // colEmail
            // 
            this.colEmail.Caption = "Email";
            this.colEmail.FieldName = "StrEmail";
            this.colEmail.MinWidth = 25;
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 6;
            this.colEmail.Width = 94;
            // 
            // colPassWord
            // 
            this.colPassWord.Caption = "PassWord";
            this.colPassWord.FieldName = "StrPassword";
            this.colPassWord.MinWidth = 25;
            this.colPassWord.Name = "colPassWord";
            this.colPassWord.Visible = true;
            this.colPassWord.VisibleIndex = 7;
            this.colPassWord.Width = 94;
            // 
            // colIDCard
            // 
            this.colIDCard.Caption = "IDCard";
            this.colIDCard.FieldName = "StrIDCard";
            this.colIDCard.MinWidth = 25;
            this.colIDCard.Name = "colIDCard";
            this.colIDCard.Visible = true;
            this.colIDCard.VisibleIndex = 8;
            this.colIDCard.Width = 94;
            // 
            // colSalary
            // 
            this.colSalary.Caption = "Salary";
            this.colSalary.FieldName = "DecSalary";
            this.colSalary.MinWidth = 25;
            this.colSalary.Name = "colSalary";
            this.colSalary.Visible = true;
            this.colSalary.VisibleIndex = 9;
            this.colSalary.Width = 94;
            // 
            // colEmployOfTypeID
            // 
            this.colEmployOfTypeID.Caption = "EmployOfTypeID";
            this.colEmployOfTypeID.FieldName = "StrEmployTypeID";
            this.colEmployOfTypeID.MinWidth = 25;
            this.colEmployOfTypeID.Name = "colEmployOfTypeID";
            this.colEmployOfTypeID.Visible = true;
            this.colEmployOfTypeID.VisibleIndex = 10;
            this.colEmployOfTypeID.Width = 94;
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Status";
            this.colStatus.FieldName = "Bstatus";
            this.colStatus.MinWidth = 25;
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 11;
            this.colStatus.Width = 94;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(143, 107);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(8, 8);
            this.progressBar1.TabIndex = 2;
            // 
            // frmGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 820);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.gcEmployee);
            this.Name = "frmGridView";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmGridView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemFontEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcEmployee;
        private DevExpress.XtraGrid.Views.Grid.GridView gvEmployee;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraEditors.Repository.RepositoryItemFontEdit repositoryItemFontEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colRule;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colNumberPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colGender;
        private System.Windows.Forms.ProgressBar progressBar1;
        private DevExpress.XtraGrid.Columns.GridColumn colBirthDay;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colPassWord;
        private DevExpress.XtraGrid.Columns.GridColumn colIDCard;
        private DevExpress.XtraGrid.Columns.GridColumn colSalary;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployOfTypeID;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
    }
}

