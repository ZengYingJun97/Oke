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
            this.OkeTab.SuspendLayout();
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
            this.LoginGroup.Label = "登录";
            this.LoginGroup.Name = "LoginGroup";
            // 
            // OkeRibbon
            // 
            this.Name = "OkeRibbon";
            this.RibbonType = "Microsoft.PowerPoint.Presentation";
            this.Tabs.Add(this.OkeTab);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.OkeRibbon_Load);
            this.OkeTab.ResumeLayout(false);
            this.OkeTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab OkeTab;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup LoginGroup;
    }

    partial class ThisRibbonCollection
    {
        internal OkeRibbon OkeRibbon
        {
            get { return this.GetRibbon<OkeRibbon>(); }
        }
    }
}
