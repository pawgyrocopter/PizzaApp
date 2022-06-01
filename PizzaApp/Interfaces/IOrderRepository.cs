﻿using PizzaApp.DTOs;
using PizzaApp.Entities;

namespace PizzaApp.Interfaces;

public interface IOrderRepository
{
    Task<OrderDto> CreateOrder(OrderDto orderDto);
    Task<IEnumerable<OrderDto>> GetOrders();

    Task<IEnumerable<OrderDto>> GerUserOrders(string name);
}