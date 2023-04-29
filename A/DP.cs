namespace A
{
    using CrystalDecisions.CrystalReports.Engine;
    using CrystalDecisions.ReportSource;
    using CrystalDecisions.Shared;
    using System;
    using System.ComponentModel;
    using System.Drawing;

    [ToolboxBitmap(typeof(ExportOptions), "report.bmp")]
    public class DP : Component, ICachedReport
    {
        public virtual ReportDocument CreateReport() => 
            new IP { Site = this.Site };

        public virtual string GetCustomizedCacheKey(RequestContext request) => 
            null;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(false)]
        public virtual bool IsCacheable
        {
            get => 
                true;
            set
            {
            }
        }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

