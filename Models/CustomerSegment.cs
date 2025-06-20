using System.Diagnostics.Metrics;

namespace CustomerSegmentationDashboard.Models
{
    public class CustomerSegment
    {
        public double CustomerID { get; set; }
        public double Recency { get; set; }
        public double Frequency { get; set; }
        public double Monetary { get; set; }
        public int Cluster { get; set; }

    }
}
