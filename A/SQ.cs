namespace A
{
    using CrystalDecisions.CrystalReports.Engine;
    using CrystalDecisions.Shared;
    using System;
    using System.ComponentModel;

    public class SQ : ReportClass
    {
        public override string ResourceName
        {
            get => 
                "CRInvoiceSaleListItems.rpt";
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
                "YAZSYS.CRInvoiceSaleListItems.rpt";
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

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(false)]
        public Section Q =>
            this.ReportDefinition.Sections[3];

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(false)]
        public Section I =>
            this.ReportDefinition.Sections[4];

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Section D =>
            this.ReportDefinition.Sections[5];

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Section F =>
            this.ReportDefinition.Sections[6];

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(false)]
        public Section H =>
            this.ReportDefinition.Sections[7];

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IParameterField A =>
            this.DataDefinition.ParameterFields[0];

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(false)]
        public IParameterField R =>
            this.DataDefinition.ParameterFields[1];

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IParameterField P =>
            this.DataDefinition.ParameterFields[2];

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(false)]
        public IParameterField Q =>
            this.DataDefinition.ParameterFields[3];

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IParameterField I =>
            this.DataDefinition.ParameterFields[4];

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(false)]
        public IParameterField D =>
            this.DataDefinition.ParameterFields[5];

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IParameterField F =>
            this.DataDefinition.ParameterFields[6];

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IParameterField H =>
            this.DataDefinition.ParameterFields[7];

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(false)]
        public IParameterField T =>
            this.DataDefinition.ParameterFields[8];

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IParameterField X =>
            this.DataDefinition.ParameterFields[9];

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(false)]
        public IParameterField G =>
            this.DataDefinition.ParameterFields[10];

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(false)]
        public IParameterField E =>
            this.DataDefinition.ParameterFields[11];

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IParameterField K =>
            this.DataDefinition.ParameterFields[12];

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IParameterField U =>
            this.DataDefinition.ParameterFields[13];
    }
}

