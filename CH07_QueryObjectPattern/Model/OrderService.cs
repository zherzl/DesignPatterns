﻿using Infrastructure.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class OrderService
    {
        private IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public IEnumerable<Order> FindAllCustomersOrdersBy(Guid customerId)
        {
            IEnumerable<Order> customerOrders = new List<Order>();

            Query query = new Query();
            query.Add(new Criterion(nameof(Order.CustomerId), customerId, CriteriaOperator.Equal));
            query.OrderByProperty = new OrderByClause { PropertyName = "CustomerId", Desc = true };

            customerOrders = _orderRepository.FindBy(query);

            return customerOrders;
        }

        public IEnumerable<Order> FindAllCustomersOrdersWithInOrderDateBy(Guid customerId, DateTime orderDate)
        {
            IEnumerable<Order> customerOrders = new List<Order>();

            Query query = new Query();
            //query.Add(new Criterion("CustomerId", customerId, CriteriaOperator.Equal));
            query.Add(Criterion.Create<Order>(x => x.CustomerId, customerId, CriteriaOperator.Equal));
            query.QueryOperator = QueryOperator.And;
            //query.Add(new Criterion("OrderDate", orderDate, CriteriaOperator.LessThanOrEqual));
            query.Add(Criterion.Create<Order>(x => x.OrderDate, orderDate, CriteriaOperator.LessThanOrEqual));
            //query.OrderByProperty = new OrderByClause { PropertyName = "OrderDate", Desc = true };
            query.OrderByProperty = new OrderByClause {
                PropertyName = PropertyNameHelper.ResolvePropertyName<Order>(x => x.OrderDate),
                Desc = true };

            customerOrders = _orderRepository.FindBy(query);

            return customerOrders;
        }

        public IEnumerable<Order> FindAllCustomersOrdersUsingAComplexQueryWith(Guid customerId)
        {
            IEnumerable<Order> customerOrders = new List<Order>();

            Query query = NamedQueryFactory.CreateRetrieveOrdersUsingAComplexQuery(customerId);

            customerOrders = _orderRepository.FindBy(query);

            return customerOrders;
        }
    }
}
