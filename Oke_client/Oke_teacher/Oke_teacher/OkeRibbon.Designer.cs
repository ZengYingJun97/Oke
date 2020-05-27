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
            this.Upclassbtn = this.Factory.CreateRibbonButton();
            this.Downclassbtn = this.Factory.CreateRibbonButton();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.fillbutton = this.Factory.CreateRibbonButton();
            this.simleanswerbutton = this.Factory.CreateRibbonButton();
            this.Judgquesbtn = this.Factory.CreateRibbonButton();
            this.interactgroup = this.Factory.CreateRibbonGroup();
            this.scratchbutton = this.Factory.CreateRibbonButton();
            this.datagroup = this.Factory.CreateRibbonGroup();
            this.dataoutbutton = this.Factory.CreateRibbonButton();
            this.OkeTab.SuspendLayout();
            this.LoginGroup.SuspendLayout();
            this.group1.SuspendLayout();
            this.group2.SuspendLayout();
            this.interactgroup.SuspendLayout();
            this.datagroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // OkeTab
            // 
            this.OkeTab.Groups.Add(this.LoginGroup);
            this.OkeTab.Groups.Add(this.group1);
            this.OkeTab.Groups.Add(this.group2);
            this.OkeTab.Groups.Add(this.interactgroup);
            this.OkeTab.Groups.Add(this.datagroup);
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
            this.InfoButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.InfoButton_Click);
            // 
            // group1
            // 
            this.group1.Items.Add(this.Upclassbtn);
            this.group1.Items.Add(this.Downclassbtn);
            this.group1.Name = "group1";
            // 
            // Upclassbtn
            // 
            this.Upclassbtn.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.Upclassbtn.Image = global::Oke_teacher.Properties.Resources.upclassicon_08;
            this.Upclassbtn.Label = "上课\n";
            this.Upclassbtn.Name = "Upclassbtn";
            this.Upclassbtn.ShowImage = true;
            this.Upclassbtn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Upclassbtn_Click);
            // 
            // Downclassbtn
            // 
            this.Downclassbtn.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.Downclassbtn.Image = global::Oke_teacher.Properties.Resources.downclassicon_09;
            this.Downclassbtn.Label = "下课\n";
            this.Downclassbtn.Name = "Downclassbtn";
            this.Downclassbtn.ShowImage = true;
            this.Downclassbtn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Downclassbtn_Click);
            // 
            // group2
            // 
            this.group2.Items.Add(this.fillbutton);
            this.group2.Items.Add(this.simleanswerbutton);
            this.group2.Items.Add(this.Judgquesbtn);
            this.group2.Label = "题目\n";
            this.group2.Name = "group2";
            // 
            // fillbutton
            // 
            this.fillbutton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.fillbutton.Image = global::Oke_teacher.Properties.Resources.Oke_fillinblank;
            this.fillbutton.Label = "填空题\n";
            this.fillbutton.Name = "fillbutton";
            this.fillbutton.ShowImage = true;
            this.fillbutton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Fillinbutton_Click);
            // 
            // simleanswerbutton
            // 
            this.simleanswerbutton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.simleanswerbutton.Image = global::Oke_teacher.Properties.Resources.Oke_simpleanswer;
            this.simleanswerbutton.Label = "简答题\n";
            this.simleanswerbutton.Name = "simleanswerbutton";
            this.simleanswerbutton.ShowImage = true;
            this.simleanswerbutton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Simpleanswerbutton_Click);
            // 
            // Judgquesbtn
            // 
            this.Judgquesbtn.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.Judgquesbtn.Image = global::Oke_teacher.Properties.Resources.Oke_judge;
            this.Judgquesbtn.Label = "判断题\n";
            this.Judgquesbtn.Name = "Judgquesbtn";
            this.Judgquesbtn.ShowImage = true;
            this.Judgquesbtn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Judgquesbtn_Click);
            // 
            // interactgroup
            // 
            this.interactgroup.Items.Add(this.scratchbutton);
            this.interactgroup.Label = "课堂互动";
            this.interactgroup.Name = "interactgroup";
            // 
            // scratchbutton
            // 
            this.scratchbutton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.scratchbutton.Image = global::Oke_teacher.Properties.Resources.Oke_scratchcard;
            this.scratchbutton.Label = "刮奖\n";
            this.scratchbutton.Name = "scratchbutton";
            this.scratchbutton.ShowImage = true;
            this.scratchbutton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Scratchbutton_Click);
            // 
            // datagroup
            // 
            this.datagroup.Items.Add(this.dataoutbutton);
            this.datagroup.Label = "数据工具";
            this.datagroup.Name = "datagroup";
            // 
            // dataoutbutton
            // 
            this.dataoutbutton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.dataoutbutton.Image = global::Oke_teacher.Properties.Resources.Oke_dataout;
            this.dataoutbutton.Label = "导出学生名单\n";
            this.dataoutbutton.Name = "dataoutbutton";
            this.dataoutbutton.ShowImage = true;
            this.dataoutbutton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Dataoutbutton_Click);
            // 
            // OkeRibbon
            // 
            this.Name = "OkeRibbon";
            this.RibbonType = "Microsoft.PowerPoint.Presentation";
            this.Tabs.Add(this.OkeTab);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.OkeRibbon_Load);
            this.OkeTab.ResumeLayout(false);
            this.OkeTab.PerformLayout();
            this.LoginGroup.ResumeLayout(false);
            this.LoginGroup.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            this.interactgroup.ResumeLayout(false);
            this.interactgroup.PerformLayout();
            this.datagroup.ResumeLayout(false);
            this.datagroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab OkeTab;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup LoginGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton LoginButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton Upclassbtn;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton InfoButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton Downclassbtn;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton Judgquesbtn;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton simleanswerbutton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton fillbutton;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup interactgroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton scratchbutton;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup datagroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton dataoutbutton;
    }

    partial class ThisRibbonCollection
    {
        internal OkeRibbon OkeRibbon
        {
            get { return this.GetRibbon<OkeRibbon>(); }
        }
    }
}
