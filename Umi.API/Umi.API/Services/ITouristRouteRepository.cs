using System;
using System.Collections.Generic;
using Umi.API.Dtos;
using Umi.API.Models;
using System.Threading.Tasks;
using Umi.API.Helper;

namespace Umi.API.Services
{
    public interface ITouristRouteRepository
    {
        // from DB, get all routes
        Task<PaginationList<TouristRoute>> GetTouristRoutesAsync(
            string keyword, 
            string ratingOpt, 
            int? ratingValue,
            int parametersPageSize, 
            int parametersPageNumber
            );
        
        Task<TouristRoute> GetTouristRouteAsync(Guid id);

        Task<bool> TouristRouteExistsAsync(Guid id);

        Task<IEnumerable<TouristRoutePicture>> GetPicturesByTouristRouteIdAsync(Guid id);
        
        Task<TouristRoutePicture> GetPictureAsync(int id);
        


        void AddTouristRoute(TouristRoute touristRoute);
        void DeleteTouristRoute(TouristRoute touristRoute);
        

        void AddTouristRoutePicture(Guid touristRouteId, TouristRoutePicture touristRoutePicture);
        void DeleteTouristRoutePicture(TouristRoutePicture touristRoutePicture);

        Task<ShoppingCart> GetShoppingCartByUserId(string userId);
        Task CreateShoppingCart(ShoppingCart shoppingCart);

        Task AddShoppingCartItem(LineItem lineItem);

        Task<LineItem> GetShoppingCartItemById(int lineItemId);
        void DeleteShoppingCartItem(LineItem lineItem);

        Task<IEnumerable<LineItem>> GetShoppingCartItemsByIds(IEnumerable<int> lineItemIds);
        void DeleteShoppingCartItems(IEnumerable<LineItem> lineItems);

        Task AddOrderAsync(Order order);
        
        Task<PaginationList<Order>> GetOrdersByUserId(string userId, int pageSize, int pageNumber);
        Task<Order> GetOrderById(Guid orderId);

        Task<bool> SaveAsync();
      
    }
}