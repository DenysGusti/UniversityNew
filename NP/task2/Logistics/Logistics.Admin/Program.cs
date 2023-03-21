using Logistics.Admin.UI;
using Logistics.Domain.Enums;
using Logistics.Domain.States.Abstract;

Menu menu = new(new ShippingMenuAdminState(), RepositoryFactoryType.Txt);