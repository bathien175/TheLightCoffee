using DevExpress.XtraCharts;
using DoAnThucTap.DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DoAnThucTap.GUI
{
    public partial class statistical_menu_GUI : DevExpress.XtraEditors.XtraForm
    {
        public statistical_menu_GUI()
        {
            InitializeComponent();
            loadData();
        }

        void loadData()
        {
            Series s = new Series("Sản lượng bán ra theo thể loại", ViewType.Pie);
            Series s2 = new Series("Top 5 món bán chạy nhất", ViewType.Bar);
            Series s3 = new Series("Top 3 món bán chậm nhất", ViewType.Bar);
            Series s4 = new Series("Top 3 món bán chạy nhất hôm nay", ViewType.Bar);
            List<Staticscal_Category> list;
            List<Staticscal_Product> list2;
            List<Staticscal_Product_bottom> list3;
            List<Staticscal_Product_byDate> list4;
            using (TheLightCoffeeEntities db = new TheLightCoffeeEntities())
            {
                list = db.Staticscal_Category.ToList();
                list2 = db.Staticscal_Product.ToList();
                list3 = db.Staticscal_Product_bottom.ToList();
                list4 = db.Staticscal_Product_byDate.ToList();
            }
            foreach (var item in list)
            {
                s.Points.Add(new SeriesPoint(item.Category_Name, item.count_buy));
            }
            foreach (var item in list2)
            {
                s2.Points.Add(new SeriesPoint(item.Product_Name, item.count_buy));
            }
            foreach (var item in list3)
            {
                s3.Points.Add(new SeriesPoint(item.Product_Name, item.count_buy));
            }
            foreach (var item in list4)
            {
                s4.Points.Add(new SeriesPoint(item.Product_Name, item.count_buy));
            }
            chartControl2.Series.Add(s);
            chartControl3.Series.Add(s2);
            chartControl1.Series.Add(s3);
            chartControl4.Series.Add(s4);
            s.Label.TextPattern = "{A}: {VP: p0}";
        }
    }
}