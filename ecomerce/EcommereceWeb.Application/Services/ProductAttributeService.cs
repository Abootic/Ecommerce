using AutoMapper;
using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Application.Interfaces.Common;
using EcommereceWeb.Application.Interfaces.Services;
using EcommereceWeb.Application.Wrapper;
using EcommereceWeb.Domain.Entity;
using System.Linq.Expressions;

namespace EcommereceWeb.Application.Services
{
    public class ProductAttributeService : IProductAttributeService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public ProductAttributeService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }
        public async Task<IResult<ProductAttributeDto>> Add(ProductAttributeDto entity, CancellationToken cancellationToken = default)
        {
            try
            {

                if (entity == null) return await Result<ProductAttributeDto>.FailAsync("--- entity is null ---");

                Console.WriteLine($"vvvvvvvvvvvvvvvvvv  {entity.AttributeId}");
                var entityMap = _mapper.Map<ProductAttribute>(entity);
                Console.WriteLine($"dddddddddddddddddddddddddddd  {entityMap.AttributeId}");
                var res = await _repositoryManager.ProductAttributeRepository.AddAndReturn(entityMap);
                if (res != null)
                {
                    await _repositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                    var map = _mapper.Map<ProductAttributeDto>(res);
                    return await Result<ProductAttributeDto>.SucessAsync(map, "تم الاضافة بنجاح");
                }
                return await Result<ProductAttributeDto>.FailAsync($"لم يتم الاضافة ");

            }
            catch (Exception ex)
            {
                return await Result<ProductAttributeDto>.FailAsync($"------------------- Exp in add Attribute : {ex.Message} ---------- {(ex.InnerException != null ? "InnerExp: " + ex.InnerException.Message : "no inner")} ----------------");
            }
        }

        public async Task<IResult<IEnumerable<ProductAttributeDto>>> Find(Expression<Func<ProductAttributeDto, bool>> expression, CancellationToken cancellationToken = default)
        {
            try
            {
                var entityMap = _mapper.Map<Expression<Func<ProductAttribute, bool>>>(expression);
                var res = await _repositoryManager.ProductAttributeRepository.Find(entityMap);
                if (res == null) return await Result<IEnumerable<ProductAttributeDto>>.FailAsync("--- there is no any Attribute like find expression ---");
                return await Result<IEnumerable<ProductAttributeDto>>.SucessAsync(_mapper.Map<IEnumerable<ProductAttributeDto>>(res), "");

            }
            catch (Exception ex)
            {

                return await Result<IEnumerable<ProductAttributeDto>>.FailAsync($"Exp in find Attributes: {ex.Message} --- {(ex.InnerException != null ? "InnerExp: " + ex.InnerException.Message : "no inner")} .");

            }
        }

        public async Task<IResult<IEnumerable<ProductAttributeDto>>> GetAll(CancellationToken cancellationToken = default)
        {
            try
            {
                var res = await _repositoryManager.ProductAttributeRepository.GetAll();
                if (res != null)
                {
                    return await Result<IEnumerable<ProductAttributeDto>>.SucessAsync(_mapper.Map<IEnumerable<ProductAttributeDto>>(res));
                }
                return await Result<IEnumerable<ProductAttributeDto>>.FailAsync($"لايوجد بيانات ");

            }
            catch (Exception ex)
            {
                return await Result<IEnumerable<ProductAttributeDto>>.FailAsync($"Exp in get all Attributes: {ex.Message} --- {(ex.InnerException != null ? "InnerExp: " + ex.InnerException.Message : "no inner")} .");
            }
        }

        public Task<IResult<ProductAttributeDto>> GetById(int Id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
        private List<ProductVariation> GenerateVariations(List<List<ProductAttribute>> attributeLists)
        {
            var variations = new List<ProductVariation>();

            if (attributeLists.Count == 0)
            {
                return variations;
            }
            try
            {

                var currentIndexes = new int[attributeLists.Count];
                var maxIndexes = new int[attributeLists.Count];

                for (int i = 0; i < attributeLists.Count; i++)
                {
                    maxIndexes[i] = attributeLists[i].Count - 1;
                }

                while (true)
                {
                    var variation = GetVariation(attributeLists, currentIndexes);
                    variations.Add(variation);

                    int nextIndex = attributeLists.Count - 1;

                    while (nextIndex >= 0 && currentIndexes[nextIndex] == maxIndexes[nextIndex])
                    {
                        currentIndexes[nextIndex] = 0;
                        nextIndex--;
                    }

                    if (nextIndex < 0)
                    {
                        break;
                    }

                    currentIndexes[nextIndex]++;
                }

                return variations;
            }catch(Exception ex)
            {
                Console.WriteLine($"eeeeeeeeeeeeeeeeeeeee  {ex.Message}");
                return variations;
            }
        }

        private ProductVariation GetVariation(List<List<ProductAttribute>> attributeLists, int[] currentIndexes)
        {
            var variation = new ProductVariation();

            for (int i = 0; i < attributeLists.Count; i++)
            {
                var currentList = attributeLists[i];
                var currentIndex = currentIndexes[i];
                var attribute = currentList[currentIndex];
                Console.WriteLine("545555555555555555555555");

                variation.ProductId = attribute.ProductId;
                variation.EnName += (currentList[i].Name.Length> 0 ? "-" : "") + attribute.Name;
            }

            return variation;
        }
        public IResult<List<ProductVariationDto>> GetListVaration()
        {
          
            try
            {

                var res = _repositoryManager.ProductAttributeRepository.GetListVarationData();
                var varition = GenerateVariations(res);
             
                if (res != null)
                {
                   
                    var map=_mapper.Map<List<ProductVariationDto>>(varition);
                    return Result<List<ProductVariationDto>>.Sucess(map,"eeeeeeeeeeeeeeee",200);
                }
                return Result<List<ProductVariationDto>>.Fail("لا يوجد بيانات", 500);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"2222222222222222222222   {ex.Message}");
                return Result<List<ProductVariationDto>>.Fail(ex.Message, 500);
            }
        }


        public Task<IResult<ProductAttributeDto>> Remove(int Id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IResult<ProductAttributeDto>> Update(ProductAttributeDto entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

       
    }

}
