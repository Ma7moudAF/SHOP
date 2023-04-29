namespace A
{
    using CrystalDecisions.CrystalReports.Engine;
    using CrystalDecisions.Shared;
    using System;
    using System.ComponentModel;

    public class PI : ReportClass
    {
        public override string ResourceName
        {
            get => 
                "CRCustomerList.rpt";
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
                "YAZSYS.CRCustomerList.rpt";
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

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(false)]
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

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Section F =>
            this.ReportDefinition.Sections[6];

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Section H =>
            this.ReportDefinition.Sections[7];

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(false)]
        public IParameterField A =>
            this.DataDefinition.ParameterFields[0];

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IParameterField R =>
            this.DataDefinition.ParameterFields[1];

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IParameterField P =>
            this.DataDefinition.ParameterFields[2];

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IParameterField Q =>
            this.DataDefinition.ParameterFields[3];

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(false)]
        public IParameterField I =>
            this.DataDefinition.ParameterFields[4];

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IParameterField D =>
            this.DataDefinition.ParameterFields[5];

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(false)]
        public IParameterField F =>
            this.DataDefinition.ParameterFields[6];
    }
}

