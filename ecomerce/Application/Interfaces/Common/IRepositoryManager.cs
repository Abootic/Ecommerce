

using EcommereceWeb.Application.Interfaces.Repositories;

namespace EcommereceWeb.Application.Interfaces.Common
{
    public interface IRepositoryManager
    {
        IAddProductToFavoriteRepository addProductToFavoriteRepository { get; }
        IBrandRepository brandRepository { get; }
        IConfigurationRepository configurationRepository { get; }
        IProductRepository productRepository { get; }
        ICouponRepository couponRepository { get; }
         ICouponItemRepository couponItemRepository { get; }
        ICurrencyRepository currencyRepository { get; }
        IMainClassificationRepository mainClassificationRepository { get; }
        IMasterDataRepository masterDataRepository { get; }
        IProductColorsRepository productColorsRepository { get; }
        IProductEvaluatonRepository productEvaluatonRepository { get; }
        IProductImageRepository productImageRepository { get; }
        IProductSizeRepository productSizeRepository { get; }
        IProductUnitSizeRepository productUnitSizeRepository { get; }
        ISliderRepository sliderRepository { get; }
        ISubClassificationBaseRepository subClassificationBaseRepository { get; }
        ISubSubclassificationRepository subSubclassificationRepository { get; }
        ITaxConfigurationRepository taxConfigurationRepository { get; }

    }
}
