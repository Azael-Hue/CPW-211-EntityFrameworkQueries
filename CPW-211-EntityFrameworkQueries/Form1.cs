using CPW_211_EntityFrameworkQueries.Data;
using CPW_211_EntityFrameworkQueries.Models;

namespace CPW_211_EntityFrameworkQueries
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectAllVendors_Click(object sender, EventArgs e)
        {
            using ApContext dbContext = new ApContext();

            // LINQ (Language Integrated Query) method syntax
            List<Vendor> vendorList = dbContext.Vendors.ToList();

            // LINQ query syntax
            List<Vendor> vendorList2 = (from v in dbContext.Vendors
                                        select v).ToList();
        }

        private void btnAllCaliVendors_Click(object sender, EventArgs e)
        {
            using ApContext dbContext = new();

            List<Vendor> vendorList = dbContext.Vendors
                                .Where(v => v.VendorState == "CA")
                                .OrderBy(v => v.VendorName)
                                .ToList();

            List<Vendor> vendorList2 = (from v in dbContext.Vendors
                                       where v.VendorState == "CA"
                                       orderby v.VendorName
                                       select v).ToList();
        }
    }
}
