using CustomerSegmentationDashboard.Models;
using CsvHelper;
using System.Globalization;
using System.IO;
using Microsoft.AspNetCore.Mvc;

public class CustomerController : Controller
{
    public IActionResult Index()
    {
        var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "data", "rfm_customers_segmented.csv");

        List<CustomerSegment> customers;

        using (var reader = new StreamReader(path))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            customers = csv.GetRecords<CustomerSegment>().ToList();
        }

        return View(customers);
    }
}
