namespace A
{
    using CrystalDecisions.CrystalReports.Engine;
    using CrystalDecisions.ReportSource;
    using CrystalDecisions.Shared;
    using System;
    using System.ComponentModel;
    using System.Drawing;

    [ToolboxBitmap(typeof(ExportOptions), "report.bmp")]
    public class NP : Component, ICachedReport
    {
        public virtual ReportDocument CreateReport() => 
            new LP { Site = this.Site };

        public virtual string GetCustomizedCacheKey(RequestContext request) => 
            null;

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public virtual bool IsCacheable
        {
            get => 
                true;
            set
            {
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(false)]
        public virtual bool ShareDBLogonInfo
        {
            get => 
                false;
            set
            {
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(false)]
        public virtual TimeSpan CacheTimeOut
        {
            get => 
                CachedReportConstants.DEFAULT_TIMEOUT;
            set
            {
            }
        }

        public virtual bool CrystalDecisions.ReportSource.ICachedReport.IsCacheable
        {
            get => 
                true;
            set
            {
            }
        }

        public virtual bool CrystalDecisions.ReportSource.ICachedReport.ShareDBLogonInfo
        {
            get => 
                false;
            set
            {
            }
        }

        public virtual TimeSpan CrystalDecisions.ReportSource.ICachedReport.CacheTimeOut
        {
            get => 
                CachedReportConstants.DEFAULT_TIMEOUT;
            set
            {
            }
        }
    }
}

