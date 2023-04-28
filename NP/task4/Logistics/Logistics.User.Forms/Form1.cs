using Logistics.Domain.Enums;
using Logistics.Domain.Factories.RepositoryFactories.Concrete;
using Logistics.Domain.Models;
using Logistics.Domain.Repositories.Abstract;
using System.Data;

namespace Logistics.User.Forms;

public partial class Form1 : Form
{
    private readonly IRepository<Shipping> _repository;

    public Form1()
    {
        RepositoryFactoryProvider<Shipping> repositoryFactoryProvider = new(RepositoryFactoryType.Txt);
        var repositoryFactory = repositoryFactoryProvider.ConfigureFactory();
        _repository = repositoryFactory.CreateRepository();

        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e) => comboBoxFilter.SelectedItem = comboBoxFilter.Items[0];

    private DataTable CreateDataTable()
    {
        DataTable dt = new();

        dt.Columns.Add("Id");
        dt.Columns.Add("Goods Name");
        dt.Columns.Add("Goods Quantity (t)");
        dt.Columns.Add("Departure Warehouse Name");
        dt.Columns.Add("Departure Warehouse City");
        dt.Columns.Add("Departure Warehouse Capacity (t)");
        dt.Columns.Add("Destination Warehouse Name");
        dt.Columns.Add("Destination Warehouse City");
        dt.Columns.Add("Destination Warehouse Capacity (t)");
        dt.Columns.Add("Driver's Name");
        dt.Columns.Add("Driver's Surname");
        dt.Columns.Add("Driver's Age");
        dt.Columns.Add("Duration (days)");
        dt.Columns.Add("Shipping type");

        var filteredShippings = _repository.GetAll();

        if (comboBoxFilter.Text != @"All")
            filteredShippings = filteredShippings
                .Where(x => x.Transport!.Type.ToString() == comboBoxFilter.Text)
                .ToArray();

        labelTotalQuantity.Text = $@"{filteredShippings.Sum(x => x.Goods!.Quantity)} t";

        foreach (var shipping in filteredShippings)
            dt.Rows.Add(
                shipping.Id,
                shipping.Goods!.Name, shipping.Goods.Quantity,
                shipping.WarehouseFrom!.Name, shipping.WarehouseFrom.City, shipping.WarehouseFrom.Capacity,
                shipping.WarehouseTo!.Name, shipping.WarehouseTo.City, shipping.WarehouseTo.Capacity,
                shipping.Driver!.Name, shipping.Driver.Surname, shipping.Driver.Age,
                shipping.Duration,
                shipping.Transport!.Type
            );

        return dt;
    }

    private void ReloadShippings()
    {
        dataGridViewShippings.DataSource = null;
        dataGridViewShippings.DataSource = CreateDataTable();
    }

    private void buttonReload_Click(object sender, EventArgs e) => ReloadShippings();

    private void comboBoxFilter_SelectedValueChanged(object sender, EventArgs e) => ReloadShippings();
}