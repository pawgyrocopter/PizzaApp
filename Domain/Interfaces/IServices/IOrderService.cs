﻿using Domain.DTOs;

namespace Domain.Interfaces.IServices;

public interface IOrderService
{
    Task<OrderDto> CreateOrderAsync(OrderDto orderDto);
    Task<bool> UpdateOrderState(int orderId);
    Task<IEnumerable<OrderDto>> GetOrdersAsync();
    Task<IEnumerable<OrderDto>> GetUserOrdersAsync(string name);
    Task<OrderDto> GerOrderById(int orderId);
}