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
    public class MasterDataService : IMasterDataService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public MasterDataService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<IResult<MasterDataDto>> Add(MasterDataDto entity, CancellationToken cancellationToken = default)
        {
            try
            {

                var entityMap = _mapper.Map<MasterData>(entity);
                var res = await _repositoryManager.MasterDataRepository.AddAndReturn(entityMap);
                if (res != null)
                {
                    await _repositoryManager.UnitOfWork.CompleteAsync();
                    var map = _mapper.Map<MasterDataDto>(res);
                    return await Result<MasterDataDto>.SucessAsync(map, "تم الاضافة بنجاح");
                }
                return await Result<MasterDataDto>.FailAsync($"لم يتم الاضافة ");

            }
            catch (Exception ex)
            {
                return await Result<MasterDataDto>.FailAsync($"something error {ex.Message} ");
            }
        }

        public Task<IResult<IEnumerable<MasterDataDto>>> Find(Expression<Func<MasterDataDto, bool>> expression, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public async Task<IResult<IEnumerable<MasterDataDto>>> GetAll(CancellationToken cancellationToken = default)
        {
            try
            {
                var res = await _repositoryManager.MasterDataRepository.GetAll();
                if (res != null)
                {
                    return await Result<IEnumerable<MasterDataDto>>.SucessAsync(_mapper.Map<IEnumerable<MasterDataDto>>(res));
                }
                return await Result<IEnumerable<MasterDataDto>>.FailAsync($"لايوجد بيانات ");

            }
            catch (Exception ex)
            {
                return await Result<IEnumerable<MasterDataDto>>.FailAsync($"something error {ex.Message} ");
            }
        }

        public async Task<IResult<MasterDataDto>> GetById(int Id, CancellationToken cancellationToken = default)
        {
            try
            {
                var res = await _repositoryManager.MasterDataRepository.GetById(Id);
                if (res != null)
                {
                    return await Result<MasterDataDto>.SucessAsync(_mapper.Map<MasterDataDto>(res));
                }
                return await Result<MasterDataDto>.FailAsync(" لايوجد بيانات لهذا الرقم");

            }
            catch (Exception ex)
            {
                return await Result<MasterDataDto>.FailAsync($"something error {ex.Message} ");
            }
        }

        public async Task<IResult<MasterDataDto>> Remove(int Id, CancellationToken cancellationToken = default)
        {
            try
            {
                var entity = await _repositoryManager.MasterDataRepository.GetById(Id);
                if (entity != null)
                {
                    var res = await _repositoryManager.MasterDataRepository.Remove(entity);
                    await _repositoryManager.UnitOfWork.CompleteAsync();
                    if (res != null)
                    {
                        return await Result<MasterDataDto>.SucessAsync(_mapper.Map<MasterDataDto>(res));
                    }
                    return await Result<MasterDataDto>.FailAsync(" لم يتم حذف البيانات");
                }
                return await Result<MasterDataDto>.FailAsync(" لايوجد بيانات لهذا الرقم");

            }
            catch (Exception ex)
            {
                return await Result<MasterDataDto>.FailAsync($"something error {ex.Message} ");
            }
        }

        public async Task<IResult<MasterDataDto>> Update(MasterDataDto entity, CancellationToken cancellationToken = default)
        {
            try
            {
                var entityMap = _mapper.Map<MasterData>(entity);
                var res = await _repositoryManager.MasterDataRepository.Update(entityMap);
                if (res != null)
                {
                    await _repositoryManager.UnitOfWork.CompleteAsync();
                    var map = _mapper.Map<MasterDataDto>(res);
                    return await Result<MasterDataDto>.SucessAsync(map, "تم التعديل بنجاح");
                }
                return await Result<MasterDataDto>.FailAsync($"لم يتم التعديل ");

            }
            catch (Exception ex)
            {
                return await Result<MasterDataDto>.FailAsync($"something error {ex.Message} ");
            }
        }
    }
}
