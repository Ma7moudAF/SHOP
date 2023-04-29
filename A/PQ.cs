namespace A
{
    using CrystalDecisions.CrystalReports.Engine;
    using CrystalDecisions.Shared;
    using System;
    using System.ComponentModel;

    public class PQ : ReportClass
    {
        public override string ResourceName
        {
            get => 
                "CRInvoiceSaleHMini80.rpt";
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
                "YAZSYS.CRInvoiceSaleHMini80.rpt";
            set
            {
            }
        }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Section A =>
            this.ReportDefinition.Sections[0];

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(false)]
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

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(false)]
        public IParameterField R =>
            this.DataDefinition.ParameterFields[1];

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(false)]
        public IParameterField P =>
            this.DataDefinition.ParameterFields[2];

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(false)]
        public IParameterField Q =>
            this.DataDefinition.ParameterFields[3];

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IParameterField I =>
            this.DataDefinition.ParameterFields[4];

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IParameterField D =>
            this.DataDefinition.ParameterFields[5];

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(false)]
        public IParameterField F =>
            this.DataDefinition.ParameterFields[6];

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(false)]
        public IParameterField H =>
            this.DataDefinition.ParameterFields[7];

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(false)]
        public IParameterField T =>
            this.DataDefinition.ParameterFields[8];

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(false)]
        public IParameterField X =>
            this.DataDefinition.ParameterFields[9];

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IParameterField G =>
            this.DataDefinition.ParameterFields[10];

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IParameterField E =>
            this.DataDefinition.ParameterFields[11];

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(false)]
        public IParameterField K =>
            this.DataDefinition.ParameterFields[12];

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(false)]
        public IParameterField U =>
            this.DataDefinition.ParameterFields[13];

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IParameterField L =>
            this.DataDefinition.ParameterFields[14];

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(false)]
        public IParameterField N =>
            this.DataDefinition.ParameterFields[15];

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(false)]
        public IParameterField V =>
            this.DataDefinition.ParameterFields[0x10];
    }
}

