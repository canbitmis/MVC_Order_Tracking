using Sipsis.BLL.Repository.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sipsis.BLL.Repository.Service
{
    public class EntityService
    {
        public EntityService()
        { 
            _userService = new UserRepository();
            _orderService = new OrderRepository();
            _orderStatusService = new OrderStatusRepository();
            _marketService = new MarkettRepository();
            _customerService = new CustomerRepository();
            _cargoService = new CargoRepository();

        }

        private UserRepository _userService;

        public UserRepository UserService
        {
            get { return _userService; }
            set { _userService = value; }
        }
        
        
        private OrderRepository _orderService;

        public OrderRepository OrderService
        {
            get { return _orderService; }
            set { _orderService = value; }
        }

        private OrderStatusRepository _orderStatusService;

        public OrderStatusRepository OrderStatusService
        {
            get { return _orderStatusService; }
            set { _orderStatusService = value; }
        }

        private MarkettRepository _marketService;

        public MarkettRepository MarketService
        {
            get { return _marketService; }
            set { _marketService = value; }
        }

        private CustomerRepository _customerService;

        public CustomerRepository CustomerService
        {
            get { return _customerService; }
            set { _customerService = value; }
        }

        private CargoRepository _cargoService;

        public CargoRepository CargoService
        {
            get { return _cargoService; }
            set { _cargoService = value; }
        }



    }
}
