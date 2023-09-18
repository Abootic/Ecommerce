using AutoMapper;
using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Application.Interfaces.Common;
using EcommereceWeb.Application.Interfaces.Services;
using EcommereceWeb.Application.Wrapper;
using EcommereceWeb.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EcommereceWeb.Application.Services
{
    public class DetailsDataService : IDetailsDataService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public DetailsDataService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<IResult<DetailsDataDto>> Add(DetailsDataDto entity, CancellationToken cancellationToken = default)
        {
            try
            {

                var entityMap = _mapper.Map<DetailsData>(entity);
                var res = await _repositoryManager.DetailsDataRepository.AddAndReturn(entityMap);
                if (res != null)
                {
                    await _repositoryManager.UnitOfWork.CompleteAsync();
                    var map = _mapper.Map<DetailsDataDto>(res);
                    return await Result<DetailsDataDto>.SucessAsync(map, "تم الاضافة بنجاح");
                }
                return await Result<DetailsDataDto>.FailAsync($"لم يتم الاضافة ");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"ggggggggggg  {ex.InnerException.Message}");
                return await Result<DetailsDataDto>.FailAsync($"something error {ex.Message} ");
            }
        }

        public async Task<IResult<IEnumerable<DetailsDataDto>>> Find(Expression<Func<DetailsData, bool>> expression, CancellationToken cancellationToken = default)
        {
            try
            {
                // var mapExor = _mapper.Map<Expression<Func<DetailsData, bool>>>(expression);


                var item = await _repositoryManager.DetailsDataRepository.Find(expression);
              
                var itemMap = _mapper.Map<IEnumerable<DetailsDataDto>>(item);
                return await Result<IEnumerable<DetailsDataDto>>.SucessAsync(itemMap);
            }
            catch (Exception ex)
            {
                return await Result<IEnumerable<DetailsDataDto>>.FailAsync($"something error {ex.Message} ");
            }
        }


        public async Task<IResult<IEnumerable<DetailsDataDto>>> GetAll(CancellationToken cancellationToken = default)
        {
            try
            {
                var res = await _repositoryManager.DetailsDataRepository.GetAll();
                if (res != null)
                {
                    return await Result<IEnumerable<DetailsDataDto>>.SucessAsync(_mapper.Map<IEnumerable<DetailsDataDto>>(res));
                }
                return await Result<IEnumerable<DetailsDataDto>>.FailAsync($"لايوجد بيانات ");

            }
            catch (Exception ex)
            {
                return await Result<IEnumerable<DetailsDataDto>>.FailAsync($"something error {ex.Message} ");
            }
        }

        public async Task<IResult<DetailsDataDto>> GetById(int Id, CancellationToken cancellationToken = default)
        {
            try
            {
                var res = await _repositoryManager.DetailsDataRepository.GetById(Id);
                if (res != null)
                {
                    return await Result<DetailsDataDto>.SucessAsync(_mapper.Map<DetailsDataDto>(res));
                }
                return await Result<DetailsDataDto>.FailAsync(" لايوجد بيانات لهذا الرقم");

            }
            catch (Exception ex)
            {
                return await Result<DetailsDataDto>.FailAsync($"something error {ex.Message} ");
            }
        }

        public async Task<IResult<DetailsDataDto>> Remove(int Id, CancellationToken cancellationToken = default)
        {
            try
            {
                var entity = await _repositoryManager.DetailsDataRepository.GetById(Id);
                if (entity != null)
                {
                    var res = await _repositoryManager.DetailsDataRepository.Remove(entity);
                    await _repositoryManager.UnitOfWork.CompleteAsync();
                    if (res != null)
                    {
                        return await Result<DetailsDataDto>.SucessAsync(_mapper.Map<DetailsDataDto>(res));
                    }
                    return await Result<DetailsDataDto>.FailAsync(" لم يتم حذف البيانات");
                }
                return await Result<DetailsDataDto>.FailAsync(" لايوجد بيانات لهذا الرقم");

            }
            catch (Exception ex)
            {
                return await Result<DetailsDataDto>.FailAsync($"something error {ex.Message} ");
            }
        }

        public async Task<IResult<DetailsDataDto>> Update(DetailsDataDto entity, CancellationToken cancellationToken = default)
        {
            try
            {
                var entityMap = _mapper.Map<DetailsData>(entity);
                var res = await _repositoryManager.DetailsDataRepository.Update(entityMap);
                if (res != null)
                {
                    await _repositoryManager.UnitOfWork.CompleteAsync();
                    var map = _mapper.Map<DetailsDataDto>(res);
                    return await Result<DetailsDataDto>.SucessAsync(map, "تم التعديل بنجاح");
                }
                return await Result<DetailsDataDto>.FailAsync($"لم يتم التعديل ");

            }
            catch (Exception ex)
            {
                return await Result<DetailsDataDto>.FailAsync($"something error {ex.Message} ");
            }
        }
    }
}
