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
            this.InfoButton = this.Factory.CreateRibbonButton();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.button1 = this.Factory.CreateRibbonButton();
            this.OkeTab.SuspendLayout();
            this.LoginGroup.SuspendLayout();
            this.group1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OkeTab
            // 
            this.OkeTab.Groups.Add(this.LoginGroup);
            this.OkeTab.Groups.Add(this.group1);
            this.OkeTab.Label = "Oke";
            this.OkeTab.Name = "OkeTab";
            // 
            // LoginGroup
            // 
            this.LoginGroup.Items.Add(this.LoginButton);
            this.LoginGroup.Items.Add(this.InfoButton);
            this.LoginGroup.Label = "个人中心";
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
            // InfoButton
            // 
            this.InfoButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.InfoButton.Image = global::Oke_teacher.Properties.Resources.MyInfo;
            this.InfoButton.Label = "我的信息\n";
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.ShowImage = true;
            this.InfoButton.Visible = false;
            // 
            // group1
            // 
            this.group1.Items.Add(this.button1);
            this.group1.Label = "题目";
            this.group1.Name = "group1";
            // 
            // button1
            // 
            this.button1.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button1.Image = global::Oke_teacher.Properties.Resources.Oke_logo;
            this.button1.Label = "发布题目\n";
            this.button1.Name = "button1";
            this.button1.ShowImage = true;
            this.button1.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button1_Click);
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
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab OkeTab;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup LoginGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton LoginButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton InfoButton;
    }

    partial class ThisRibbonCollection
    {
        internal OkeRibbon OkeRibbon
        {
            get { return this.GetRibbon<OkeRibbon>(); }
        }
    }
}
