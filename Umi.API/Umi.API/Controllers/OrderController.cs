using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Umi.API.Dtos;
using Umi.API.ResourceParameters;
using Umi.API.Services;

namespace Umi.API.Controllers
{
    
    [ApiController]
    [Route("api/order")]
    public class OrderController : ControllerBase
    {

        private readonly ITouristRouteRepository _touristRouteRepository;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public OrderController(
            ITouristRouteRepository repository,
            IMapper mapper,
            IHttpContextAccessor httpContextAccessor)
        {
            _touristRouteRepository = repository;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
        }


        [HttpGet]
        [Authorize(AuthenticationSchemes = "Bearer")]
        public async Task<IActionResult> GetOrders(
            [FromQuery] PaginationResourceParameters parameters)
        {
            // 1. get current User
            var userId = _httpContextAccessor
                .HttpContext
                .User
                .FindFirst(ClaimTypes.NameIdentifier)
                .Value;

            // 2. use userId get orders
            var ordersFromRepo = await _touristRouteRepository.GetOrdersByUserId(userId, parameters.PageSize, parameters.PageNumber);

            if (ordersFromRepo == null || ordersFromRepo.Count() <= 0)
            {
                return NotFound("no order");
            }
            
            // 3. return orders 

            return Ok(_mapper.Map<IEnumerable<OrderDto>>(ordersFromRepo));

        }

        [HttpGet("{orderId}")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        public async Task<IActionResult> GetOrderById(
            [FromRoute] Guid orderId)
        {
            // 1. get current User
            var userId = _httpContextAccessor
                .HttpContext
                .User
                .FindFirst(ClaimTypes.NameIdentifier)
                .Value;

            var orderFromRepo = await _touristRouteRepository.GetOrderById(orderId);
            if (orderFromRepo == null)
            {
                return NotFound("cannot find the order");
            }

            return Ok(_mapper.Map<OrderDto>(orderFromRepo));


        }
    }
}