namespace A
{
    using CrystalDecisions.CrystalReports.Engine;
    using System;
    using System.ComponentModel;

    public class SR : ReportClass
    {
        public override string ResourceName
        {
            get => 
                "CRBarCodeMulti2.rpt";
            set
            {
            }
        }

        public override bool NewGenerator
        {
            get => 
                true;
            set
            {
            }
        }

        public override string FullResourceName
        {
            get => 
                "YAZSYS.CRBarCodeMulti2.rpt";
            set
            {
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(false)]
        public Section A =>
            this.ReportDefinition.Sections[0];

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Section R =>
            this.ReportDefinition.Sections[1];

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Section P =>
            this.ReportDefinition.Sections[2];

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Section Q =>
            this.ReportDefinition.Sections[3];

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Section I =>
            this.ReportDefinition.Sections[4];

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(false)]
        public Section D =>
            this.ReportDefinition.Sections[5];

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(false)]
        public Section F =>
            this.ReportDefinition.Sections[6];

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Section H =>
            this.ReportDefinition.Sections[7];

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(false)]
        public Section T =>
            this.ReportDefinition.Sections[8];
    }
}

