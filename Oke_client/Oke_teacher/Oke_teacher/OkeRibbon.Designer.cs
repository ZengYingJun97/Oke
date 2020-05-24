namespace Oke_teacher
{
    partial class OkeRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public OkeRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.OkeTab = this.Factory.CreateRibbonTab();
            this.LoginGroup = this.Factory.CreateRibbonGroup();
            this.LoginButton = this.Factory.CreateRibbonButton();
            this.OkeTab.SuspendLayout();
            this.LoginGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // OkeTab
            // 
            this.OkeTab.Groups.Add(this.LoginGroup);
            this.OkeTab.Label = "Oke";
            this.OkeTab.Name = "OkeTab";
            // 
            // LoginGroup
            // 
            this.LoginGroup.Items.Add(this.LoginButton);
            this.LoginGroup.Label = "登录";
            this.LoginGroup.Name = "LoginGroup";
            // 
            // LoginButton
            // 
            this.LoginButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.LoginButton.Image = global::Oke_teacher.Properties.Resources.Oke_logo;
            this.LoginButton.Label = "用户登录\n";
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.ShowImage = true;
            this.LoginButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.LoginButton_Click);
            // 
            // OkeRibbon
            // 
            this.Name = "OkeRibbon";
            this.RibbonType = "Microsoft.PowerPoint.Presentation";
            this.Tabs.Add(this.OkeTab);
            this.OkeTab.ResumeLayout(false);
            this.OkeTab.PerformLayout();
            this.LoginGroup.ResumeLayout(false);
            this.LoginGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab OkeTab;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup LoginGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton LoginButton;
    }

    partial class ThisRibbonCollection
    {
        internal OkeRibbon OkeRibbon
        {
            get { return this.GetRibbon<OkeRibbon>(); }
        }
    }
}
