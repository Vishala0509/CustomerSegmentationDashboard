**Customer Segmentation Dashboard**

This is an interactive web dashboard that visualizes customer segments using RFM (Recency, Frequency, Monetary) analysis. It helps businesses identify and target customer groups for strategic marketing efforts.

 **Features**

- Upload customer data with RFM values and cluster labels
- Visualize customer segments by:
  - Average Recency, Frequency, Monetary values
  - Count of customers per cluster (Bar Chart)
  - Recency vs Frequency scatter plot
- Filter by cluster to inspect segment-specific KPIs
- See assigned marketing strategy per segment
- Download customer segment data as CSV

 **Use Case**

This dashboard is intended for marketing or business teams that want to:

- Identify VIP customers and reward them
- Spot at-risk customers and re-engage them
- Welcome and onboard new customers
- Analyze patterns in customer behavior
  
**Technologies Used**
- ASP.NET Core MVC (.NET 6 or later)
- Chart.js for data visualizations
- Bootstrap 5 for responsive design
- JavaScript for interactivity

**Clustering Logic**

Customer data is assumed to be pre-clustered using K-Means or similar algorithms based on:

- **Recency**: Days since last purchase
- **Frequency**: Number of purchases
- **Monetary**: Total spent

Each cluster is assigned a **strategy label** in the frontend logic:
- Cluster 0 → High Value - Retain & Reward
- Cluster 1 → Medium Value - Engage More
- Cluster 2 → Low Value - Re-engage Campaign
- Cluster 3 → Lost Customers - Winback Strategy
