//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30306.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Original file name:
// Generation date: 3/20/2010 11:34:02 AM
namespace NorthwindClient.Northwind
{
    
    /// <summary>
    /// There are no comments for NorthwindEntities in the schema.
    /// </summary>
    public partial class NorthwindEntities : global::System.Data.Services.Client.DataServiceContext
    {
        /// <summary>
        /// Initialize a new NorthwindEntities object.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public NorthwindEntities(global::System.Uri serviceRoot) : 
                base(serviceRoot)
        {
            this.ResolveName = new global::System.Func<global::System.Type, string>(this.ResolveNameFromType);
            this.ResolveType = new global::System.Func<string, global::System.Type>(this.ResolveTypeFromName);
            this.OnContextCreated();
        }
        partial void OnContextCreated();
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected global::System.Type ResolveTypeFromName(string typeName)
        {
            if (typeName.StartsWith("NorthwindModel", global::System.StringComparison.Ordinal))
            {
                return this.GetType().Assembly.GetType(string.Concat("NorthwindClient.Northwind", typeName.Substring(14)), false);
            }
            return null;
        }
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected string ResolveNameFromType(global::System.Type clientType)
        {
            if (clientType.Namespace.Equals("NorthwindClient.Northwind", global::System.StringComparison.Ordinal))
            {
                return string.Concat("NorthwindModel.", clientType.Name);
            }
            return null;
        }
        /// <summary>
        /// There are no comments for Customers in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<Customer> Customers
        {
            get
            {
                if ((this._Customers == null))
                {
                    this._Customers = base.CreateQuery<Customer>("Customers");
                }
                return this._Customers;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<Customer> _Customers;
        /// <summary>
        /// There are no comments for Order_Details in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<Order_Detail> Order_Details
        {
            get
            {
                if ((this._Order_Details == null))
                {
                    this._Order_Details = base.CreateQuery<Order_Detail>("Order_Details");
                }
                return this._Order_Details;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<Order_Detail> _Order_Details;
        /// <summary>
        /// There are no comments for Orders in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<Order> Orders
        {
            get
            {
                if ((this._Orders == null))
                {
                    this._Orders = base.CreateQuery<Order>("Orders");
                }
                return this._Orders;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<Order> _Orders;
        /// <summary>
        /// There are no comments for Customers in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToCustomers(Customer customer)
        {
            base.AddObject("Customers", customer);
        }
        /// <summary>
        /// There are no comments for Order_Details in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToOrder_Details(Order_Detail order_Detail)
        {
            base.AddObject("Order_Details", order_Detail);
        }
        /// <summary>
        /// There are no comments for Orders in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToOrders(Order order)
        {
            base.AddObject("Orders", order);
        }
    }
    /// <summary>
    /// There are no comments for NorthwindModel.Customer in the schema.
    /// </summary>
    /// <KeyProperties>
    /// CustomerID
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("Customers")]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("CustomerID")]
    public partial class Customer : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Customer object.
        /// </summary>
        /// <param name="customerID">Initial value of CustomerID.</param>
        /// <param name="companyName">Initial value of CompanyName.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static Customer CreateCustomer(string customerID, string companyName)
        {
            Customer customer = new Customer();
            customer.CustomerID = customerID;
            customer.CompanyName = companyName;
            return customer;
        }
        /// <summary>
        /// There are no comments for Property CustomerID in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string CustomerID
        {
            get
            {
                return this._CustomerID;
            }
            set
            {
                this.OnCustomerIDChanging(value);
                this._CustomerID = value;
                this.OnCustomerIDChanged();
                this.OnPropertyChanged("CustomerID");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _CustomerID;
        partial void OnCustomerIDChanging(string value);
        partial void OnCustomerIDChanged();
        /// <summary>
        /// There are no comments for Property CompanyName in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string CompanyName
        {
            get
            {
                return this._CompanyName;
            }
            set
            {
                this.OnCompanyNameChanging(value);
                this._CompanyName = value;
                this.OnCompanyNameChanged();
                this.OnPropertyChanged("CompanyName");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _CompanyName;
        partial void OnCompanyNameChanging(string value);
        partial void OnCompanyNameChanged();
        /// <summary>
        /// There are no comments for Property ContactName in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContactName
        {
            get
            {
                return this._ContactName;
            }
            set
            {
                this.OnContactNameChanging(value);
                this._ContactName = value;
                this.OnContactNameChanged();
                this.OnPropertyChanged("ContactName");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContactName;
        partial void OnContactNameChanging(string value);
        partial void OnContactNameChanged();
        /// <summary>
        /// There are no comments for Property ContactTitle in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ContactTitle
        {
            get
            {
                return this._ContactTitle;
            }
            set
            {
                this.OnContactTitleChanging(value);
                this._ContactTitle = value;
                this.OnContactTitleChanged();
                this.OnPropertyChanged("ContactTitle");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ContactTitle;
        partial void OnContactTitleChanging(string value);
        partial void OnContactTitleChanged();
        /// <summary>
        /// There are no comments for Property Address in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Address
        {
            get
            {
                return this._Address;
            }
            set
            {
                this.OnAddressChanging(value);
                this._Address = value;
                this.OnAddressChanged();
                this.OnPropertyChanged("Address");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Address;
        partial void OnAddressChanging(string value);
        partial void OnAddressChanged();
        /// <summary>
        /// There are no comments for Property City in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string City
        {
            get
            {
                return this._City;
            }
            set
            {
                this.OnCityChanging(value);
                this._City = value;
                this.OnCityChanged();
                this.OnPropertyChanged("City");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _City;
        partial void OnCityChanging(string value);
        partial void OnCityChanged();
        /// <summary>
        /// There are no comments for Property Region in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Region
        {
            get
            {
                return this._Region;
            }
            set
            {
                this.OnRegionChanging(value);
                this._Region = value;
                this.OnRegionChanged();
                this.OnPropertyChanged("Region");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Region;
        partial void OnRegionChanging(string value);
        partial void OnRegionChanged();
        /// <summary>
        /// There are no comments for Property PostalCode in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string PostalCode
        {
            get
            {
                return this._PostalCode;
            }
            set
            {
                this.OnPostalCodeChanging(value);
                this._PostalCode = value;
                this.OnPostalCodeChanged();
                this.OnPropertyChanged("PostalCode");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _PostalCode;
        partial void OnPostalCodeChanging(string value);
        partial void OnPostalCodeChanged();
        /// <summary>
        /// There are no comments for Property Country in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Country
        {
            get
            {
                return this._Country;
            }
            set
            {
                this.OnCountryChanging(value);
                this._Country = value;
                this.OnCountryChanged();
                this.OnPropertyChanged("Country");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Country;
        partial void OnCountryChanging(string value);
        partial void OnCountryChanged();
        /// <summary>
        /// There are no comments for Property Phone in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Phone
        {
            get
            {
                return this._Phone;
            }
            set
            {
                this.OnPhoneChanging(value);
                this._Phone = value;
                this.OnPhoneChanged();
                this.OnPropertyChanged("Phone");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Phone;
        partial void OnPhoneChanging(string value);
        partial void OnPhoneChanged();
        /// <summary>
        /// There are no comments for Property Fax in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Fax
        {
            get
            {
                return this._Fax;
            }
            set
            {
                this.OnFaxChanging(value);
                this._Fax = value;
                this.OnFaxChanged();
                this.OnPropertyChanged("Fax");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Fax;
        partial void OnFaxChanging(string value);
        partial void OnFaxChanged();
        /// <summary>
        /// There are no comments for Orders in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceCollection<Order> Orders
        {
            get
            {
                return this._Orders;
            }
            set
            {
                this._Orders = value;
                this.OnPropertyChanged("Orders");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceCollection<Order> _Orders = new global::System.Data.Services.Client.DataServiceCollection<Order>(null, System.Data.Services.Client.TrackingMode.None);
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for NorthwindModel.Order_Detail in the schema.
    /// </summary>
    /// <KeyProperties>
    /// OrderID
    /// ProductID
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("Order_Details")]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("OrderID", "ProductID")]
    public partial class Order_Detail : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Order_Detail object.
        /// </summary>
        /// <param name="orderID">Initial value of OrderID.</param>
        /// <param name="productID">Initial value of ProductID.</param>
        /// <param name="unitPrice">Initial value of UnitPrice.</param>
        /// <param name="quantity">Initial value of Quantity.</param>
        /// <param name="discount">Initial value of Discount.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static Order_Detail CreateOrder_Detail(int orderID, int productID, decimal unitPrice, short quantity, float discount)
        {
            Order_Detail order_Detail = new Order_Detail();
            order_Detail.OrderID = orderID;
            order_Detail.ProductID = productID;
            order_Detail.UnitPrice = unitPrice;
            order_Detail.Quantity = quantity;
            order_Detail.Discount = discount;
            return order_Detail;
        }
        /// <summary>
        /// There are no comments for Property OrderID in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int OrderID
        {
            get
            {
                return this._OrderID;
            }
            set
            {
                this.OnOrderIDChanging(value);
                this._OrderID = value;
                this.OnOrderIDChanged();
                this.OnPropertyChanged("OrderID");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _OrderID;
        partial void OnOrderIDChanging(int value);
        partial void OnOrderIDChanged();
        /// <summary>
        /// There are no comments for Property ProductID in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int ProductID
        {
            get
            {
                return this._ProductID;
            }
            set
            {
                this.OnProductIDChanging(value);
                this._ProductID = value;
                this.OnProductIDChanged();
                this.OnPropertyChanged("ProductID");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _ProductID;
        partial void OnProductIDChanging(int value);
        partial void OnProductIDChanged();
        /// <summary>
        /// There are no comments for Property UnitPrice in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public decimal UnitPrice
        {
            get
            {
                return this._UnitPrice;
            }
            set
            {
                this.OnUnitPriceChanging(value);
                this._UnitPrice = value;
                this.OnUnitPriceChanged();
                this.OnPropertyChanged("UnitPrice");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private decimal _UnitPrice;
        partial void OnUnitPriceChanging(decimal value);
        partial void OnUnitPriceChanged();
        /// <summary>
        /// There are no comments for Property Quantity in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public short Quantity
        {
            get
            {
                return this._Quantity;
            }
            set
            {
                this.OnQuantityChanging(value);
                this._Quantity = value;
                this.OnQuantityChanged();
                this.OnPropertyChanged("Quantity");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private short _Quantity;
        partial void OnQuantityChanging(short value);
        partial void OnQuantityChanged();
        /// <summary>
        /// There are no comments for Property Discount in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public float Discount
        {
            get
            {
                return this._Discount;
            }
            set
            {
                this.OnDiscountChanging(value);
                this._Discount = value;
                this.OnDiscountChanged();
                this.OnPropertyChanged("Discount");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private float _Discount;
        partial void OnDiscountChanging(float value);
        partial void OnDiscountChanged();
        /// <summary>
        /// There are no comments for Order in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public Order Order
        {
            get
            {
                return this._Order;
            }
            set
            {
                this._Order = value;
                this.OnPropertyChanged("Order");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private Order _Order;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for NorthwindModel.Order in the schema.
    /// </summary>
    /// <KeyProperties>
    /// OrderID
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("Orders")]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("OrderID")]
    public partial class Order : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Order object.
        /// </summary>
        /// <param name="orderID">Initial value of OrderID.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static Order CreateOrder(int orderID)
        {
            Order order = new Order();
            order.OrderID = orderID;
            return order;
        }
        /// <summary>
        /// There are no comments for Property OrderID in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int OrderID
        {
            get
            {
                return this._OrderID;
            }
            set
            {
                this.OnOrderIDChanging(value);
                this._OrderID = value;
                this.OnOrderIDChanged();
                this.OnPropertyChanged("OrderID");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _OrderID;
        partial void OnOrderIDChanging(int value);
        partial void OnOrderIDChanged();
        /// <summary>
        /// There are no comments for Property CustomerID in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string CustomerID
        {
            get
            {
                return this._CustomerID;
            }
            set
            {
                this.OnCustomerIDChanging(value);
                this._CustomerID = value;
                this.OnCustomerIDChanged();
                this.OnPropertyChanged("CustomerID");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _CustomerID;
        partial void OnCustomerIDChanging(string value);
        partial void OnCustomerIDChanged();
        /// <summary>
        /// There are no comments for Property EmployeeID in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> EmployeeID
        {
            get
            {
                return this._EmployeeID;
            }
            set
            {
                this.OnEmployeeIDChanging(value);
                this._EmployeeID = value;
                this.OnEmployeeIDChanged();
                this.OnPropertyChanged("EmployeeID");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _EmployeeID;
        partial void OnEmployeeIDChanging(global::System.Nullable<int> value);
        partial void OnEmployeeIDChanged();
        /// <summary>
        /// There are no comments for Property OrderDate in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> OrderDate
        {
            get
            {
                return this._OrderDate;
            }
            set
            {
                this.OnOrderDateChanging(value);
                this._OrderDate = value;
                this.OnOrderDateChanged();
                this.OnPropertyChanged("OrderDate");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _OrderDate;
        partial void OnOrderDateChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnOrderDateChanged();
        /// <summary>
        /// There are no comments for Property RequiredDate in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> RequiredDate
        {
            get
            {
                return this._RequiredDate;
            }
            set
            {
                this.OnRequiredDateChanging(value);
                this._RequiredDate = value;
                this.OnRequiredDateChanged();
                this.OnPropertyChanged("RequiredDate");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _RequiredDate;
        partial void OnRequiredDateChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnRequiredDateChanged();
        /// <summary>
        /// There are no comments for Property ShippedDate in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> ShippedDate
        {
            get
            {
                return this._ShippedDate;
            }
            set
            {
                this.OnShippedDateChanging(value);
                this._ShippedDate = value;
                this.OnShippedDateChanged();
                this.OnPropertyChanged("ShippedDate");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _ShippedDate;
        partial void OnShippedDateChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnShippedDateChanged();
        /// <summary>
        /// There are no comments for Property ShipVia in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> ShipVia
        {
            get
            {
                return this._ShipVia;
            }
            set
            {
                this.OnShipViaChanging(value);
                this._ShipVia = value;
                this.OnShipViaChanged();
                this.OnPropertyChanged("ShipVia");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _ShipVia;
        partial void OnShipViaChanging(global::System.Nullable<int> value);
        partial void OnShipViaChanged();
        /// <summary>
        /// There are no comments for Property Freight in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<decimal> Freight
        {
            get
            {
                return this._Freight;
            }
            set
            {
                this.OnFreightChanging(value);
                this._Freight = value;
                this.OnFreightChanged();
                this.OnPropertyChanged("Freight");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<decimal> _Freight;
        partial void OnFreightChanging(global::System.Nullable<decimal> value);
        partial void OnFreightChanged();
        /// <summary>
        /// There are no comments for Property ShipName in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ShipName
        {
            get
            {
                return this._ShipName;
            }
            set
            {
                this.OnShipNameChanging(value);
                this._ShipName = value;
                this.OnShipNameChanged();
                this.OnPropertyChanged("ShipName");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ShipName;
        partial void OnShipNameChanging(string value);
        partial void OnShipNameChanged();
        /// <summary>
        /// There are no comments for Property ShipAddress in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ShipAddress
        {
            get
            {
                return this._ShipAddress;
            }
            set
            {
                this.OnShipAddressChanging(value);
                this._ShipAddress = value;
                this.OnShipAddressChanged();
                this.OnPropertyChanged("ShipAddress");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ShipAddress;
        partial void OnShipAddressChanging(string value);
        partial void OnShipAddressChanged();
        /// <summary>
        /// There are no comments for Property ShipCity in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ShipCity
        {
            get
            {
                return this._ShipCity;
            }
            set
            {
                this.OnShipCityChanging(value);
                this._ShipCity = value;
                this.OnShipCityChanged();
                this.OnPropertyChanged("ShipCity");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ShipCity;
        partial void OnShipCityChanging(string value);
        partial void OnShipCityChanged();
        /// <summary>
        /// There are no comments for Property ShipRegion in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ShipRegion
        {
            get
            {
                return this._ShipRegion;
            }
            set
            {
                this.OnShipRegionChanging(value);
                this._ShipRegion = value;
                this.OnShipRegionChanged();
                this.OnPropertyChanged("ShipRegion");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ShipRegion;
        partial void OnShipRegionChanging(string value);
        partial void OnShipRegionChanged();
        /// <summary>
        /// There are no comments for Property ShipPostalCode in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ShipPostalCode
        {
            get
            {
                return this._ShipPostalCode;
            }
            set
            {
                this.OnShipPostalCodeChanging(value);
                this._ShipPostalCode = value;
                this.OnShipPostalCodeChanged();
                this.OnPropertyChanged("ShipPostalCode");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ShipPostalCode;
        partial void OnShipPostalCodeChanging(string value);
        partial void OnShipPostalCodeChanged();
        /// <summary>
        /// There are no comments for Property ShipCountry in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ShipCountry
        {
            get
            {
                return this._ShipCountry;
            }
            set
            {
                this.OnShipCountryChanging(value);
                this._ShipCountry = value;
                this.OnShipCountryChanged();
                this.OnPropertyChanged("ShipCountry");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ShipCountry;
        partial void OnShipCountryChanging(string value);
        partial void OnShipCountryChanged();
        /// <summary>
        /// There are no comments for Customer in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public Customer Customer
        {
            get
            {
                return this._Customer;
            }
            set
            {
                this._Customer = value;
                this.OnPropertyChanged("Customer");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private Customer _Customer;
        /// <summary>
        /// There are no comments for Order_Details in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceCollection<Order_Detail> Order_Details
        {
            get
            {
                return this._Order_Details;
            }
            set
            {
                this._Order_Details = value;
                this.OnPropertyChanged("Order_Details");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceCollection<Order_Detail> _Order_Details = new global::System.Data.Services.Client.DataServiceCollection<Order_Detail>(null, System.Data.Services.Client.TrackingMode.None);
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
}
