using Course.Services.Basket.Dtos;
using Course.Shared.Dtos;

namespace Course.Services.Basket.Services
{
    public interface IBasketService
    {
        Task<Response<BasketDto>> GetBasket(string userId);

        Task<Response<bool>> SaveorUpdate(BasketDto basket);

        Task<Response<bool>> Delete(string userId);
    }
}
