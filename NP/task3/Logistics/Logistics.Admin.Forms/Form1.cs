using System.Data;
using Logistics.Domain.Enums;
using Logistics.Domain.Factories.RepositoryFactories.Concrete;
using Logistics.Domain.Factories.ShippingFactories.Concrete;
using Logistics.Domain.Loggers;
using Logistics.Domain.Models;
using Logistics.Domain.Repositories.Abstract;
using Logistics.Domain.ShippingMembers;
using static Logistics.Domain.GlobalSettings.GlobalSettings;

namespace Logistics.Admin.Forms;

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

    private void Form1_Load(object sender, EventArgs e) => ReloadShippings();

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

        foreach (var shipping in _repository.GetAll())
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

    private void OnAddShippingUnsafe()
    {
        var id = Convert.ToInt32(textBoxAddId.Text);

        var goodsName = textBoxAddGoodsName.Text;
        var goodsQuantity = Convert.ToDecimal(textBoxAddGoodsQuantity.Text);

        var warehouseFromName = textBoxAddDepartureWarehouseName.Text;
        var warehouseFromCity = textBoxAddDepartureWarehouseCity.Text;
        var warehouseFromCapacity = Convert.ToDecimal(textBoxAddDepartureWarehouseCapacity.Text);

        var warehouseToName = textBoxAddDestinationWarehouseName.Text;
        var warehouseToCity = textBoxAddDestinationWarehouseCity.Text;
        var warehouseToCapacity = Convert.ToDecimal(textBoxAddDestinationWarehouseCapacity.Text);

        var driverName = textBoxAddDriverName.Text;
        var driverSurname = textBoxAddDriverSurname.Text;
        var driverAge = Convert.ToUInt64(textBoxAddDriverAge.Text);

        var duration = Convert.ToUInt64(textBoxAddDuration.Text);

        var transport = new ShippingFactoryProvider(comboBoxAddShippingType.Text).ConfigureFactory().CreateTransport();

        Shipping shipping = new()
        {
            Id = id,
            Goods = new Goods
            {
                Name = goodsName,
                Quantity = goodsQuantity
            },
            WarehouseFrom = new Warehouse
            {
                Name = warehouseFromName,
                City = warehouseFromCity,
                Capacity = warehouseFromCapacity
            },
            WarehouseTo = new Warehouse
            {
                Name = warehouseToName,
                City = warehouseToCity,
                Capacity = warehouseToCapacity
            },
            Driver = new Driver
            {
                Name = driverName,
                Surname = driverSurname,
                Age = driverAge
            },
            Duration = duration,
            Transport = transport
        };

        _repository.Create(shipping);
    }

    private void buttonAddShipping_Click(object sender, EventArgs e)
    {
        try
        {
            OnAddShippingUnsafe();
            MessageBox.Show(@"Added successfully", @"Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception exception)
        {
            TxtLogger.GetInstance(LogErrorsFile).LogError(exception);
            MessageBox.Show($@"WinForms Error: {exception.Message}", @"Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        ReloadShippings();
    }

    private void dataGridViewShippings_SelectionChanged(object sender, EventArgs e)
    {
        if (dataGridViewShippings.SelectedRows.Count != 1)
            return;

        var shippingRow = dataGridViewShippings.SelectedRows[0];

        textBoxEditId.Text = shippingRow.Cells[0].Value.ToString();

        textBoxEditGoodsName.Text = shippingRow.Cells[1].Value.ToString();
        textBoxEditGoodsQuantity.Text = shippingRow.Cells[2].Value.ToString();

        textBoxEditDepartureWarehouseName.Text = shippingRow.Cells[3].Value.ToString();
        textBoxEditDepartureWarehouseCity.Text = shippingRow.Cells[4].Value.ToString();
        textBoxEditDepartureWarehouseCapacity.Text = shippingRow.Cells[5].Value.ToString();

        textBoxEditDestinationWarehouseName.Text = shippingRow.Cells[6].Value.ToString();
        textBoxEditDestinationWarehouseCity.Text = shippingRow.Cells[7].Value.ToString();
        textBoxEditDestinationWarehouseCapacity.Text = shippingRow.Cells[8].Value.ToString();

        textBoxEditDriverName.Text = shippingRow.Cells[9].Value.ToString();
        textBoxEditDriverSurname.Text = shippingRow.Cells[10].Value.ToString();
        textBoxEditDriverAge.Text = shippingRow.Cells[11].Value.ToString();

        textBoxEditDuration.Text = shippingRow.Cells[12].Value.ToString();
        comboBoxEditShippingType.Text = shippingRow.Cells[13].Value.ToString();
    }

    private void OnEditShippingUnsafe()
    {
        var id = Convert.ToInt32(textBoxEditId.Text);

        var goodsName = textBoxEditGoodsName.Text;
        var goodsQuantity = Convert.ToDecimal(textBoxEditGoodsQuantity.Text);

        var warehouseFromName = textBoxEditDepartureWarehouseName.Text;
        var warehouseFromCity = textBoxEditDepartureWarehouseCity.Text;
        var warehouseFromCapacity = Convert.ToDecimal(textBoxEditDepartureWarehouseCapacity.Text);

        var warehouseToName = textBoxEditDestinationWarehouseName.Text;
        var warehouseToCity = textBoxEditDestinationWarehouseCity.Text;
        var warehouseToCapacity = Convert.ToDecimal(textBoxEditDestinationWarehouseCapacity.Text);

        var driverName = textBoxEditDriverName.Text;
        var driverSurname = textBoxEditDriverSurname.Text;
        var driverAge = Convert.ToUInt64(textBoxEditDriverAge.Text);

        var duration = Convert.ToUInt64(textBoxEditDuration.Text);

        var transport = new ShippingFactoryProvider(comboBoxEditShippingType.Text).ConfigureFactory().CreateTransport();

        Shipping shipping = new()
        {
            Id = id,
            Goods = new Goods
            {
                Name = goodsName,
                Quantity = goodsQuantity
            },
            WarehouseFrom = new Warehouse
            {
                Name = warehouseFromName,
                City = warehouseFromCity,
                Capacity = warehouseFromCapacity
            },
            WarehouseTo = new Warehouse
            {
                Name = warehouseToName,
                City = warehouseToCity,
                Capacity = warehouseToCapacity
            },
            Driver = new Driver
            {
                Name = driverName,
                Surname = driverSurname,
                Age = driverAge
            },
            Duration = duration,
            Transport = transport
        };

        _repository.Update(shipping);
    }

    private void buttonEditShipping_Click(object sender, EventArgs e)
    {
        try
        {
            OnEditShippingUnsafe();
            MessageBox.Show(@"Edited successfully", @"Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception exception)
        {
            TxtLogger.GetInstance(LogErrorsFile).LogError(exception);
            MessageBox.Show($@"WinForms Error: {exception.Message}", @"Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        ReloadShippings();
    }

    private void buttonReload_Click(object sender, EventArgs e) => ReloadShippings();

    private void buttonDelete_Click(object sender, EventArgs e)
    {
        if (dataGridViewShippings.SelectedRows.Count != 1)
            return;

        var id = Convert.ToInt32(dataGridViewShippings.SelectedRows[0].Cells[0].Value.ToString());
        _repository.Delete(_repository.GetById(id));
        
        ReloadShippings();
    }
}