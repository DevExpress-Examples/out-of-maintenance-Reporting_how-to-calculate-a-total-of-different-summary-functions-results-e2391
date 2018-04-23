using System;
using DevExpress.XtraReports.UI;
// ...

namespace ComplexSummary {
    public partial class XtraReport1 : XtraReport {
        public XtraReport1() {
            InitializeComponent();
        }

        public double avgPrice;
        public double sumUnits;
        public double total;

        private void xrLabel5_SummaryCalculated(object sender, TextFormatEventArgs e) {
            avgPrice += Convert.ToDouble(e.Value);
        }

        private void xrLabel6_SummaryCalculated(object sender, TextFormatEventArgs e) {
            sumUnits += Convert.ToDouble(e.Value);
        }

        private void xrLabel7_PrintOnPage(object sender, PrintOnPageEventArgs e) {
            total = avgPrice + sumUnits;
            ((XRLabel)sender).Text = total.ToString("#,#");
        }

    }
}
