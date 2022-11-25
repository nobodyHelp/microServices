using Mango.Services.ShoppingCartAPI.Data.Dto;

namespace Mango.Services.ShoppingCartAPI.Repository.Interface
{
    public interface ICartRepository
    {
        Task<CartDto> GetCartByUserId(string UserId);
        Task<CartDto> CreateUpdateCart(CartDto cartDto);
        Task<bool> RemoveFromCart(int cartDetailsId);
        Task<bool> ClearCart(string UserId);
    }
}
