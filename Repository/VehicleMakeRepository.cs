using AutoMapper;
using DAL;
using Model.DTO;
using Repository.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using X.PagedList;

namespace Repository
{
    public class VehicleMakeRepository : IVehicleMakeRepository
    {
        private ICrudOperation _unitOfWork;
        private IRepository _repository;

        public VehicleMakeRepository(IRepository repository, ICrudOperation unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }

        public virtual async Task<IEnumerable<IVehicleMakeDTO>> GetPagedListAsync(IArrange arrange)
        {
            try
            {
                int pageNumber = (arrange.Page ?? 1);

                var queryable = _repository.Get<VehicleMake>();

                if (!String.IsNullOrEmpty(arrange.SearchString))
                {
                    queryable = queryable.Where(c => c.Name.Contains(arrange.SearchString));
                }

                switch (arrange.SortOrder)
                {
                    case "name_desc":
                        queryable = queryable.OrderByDescending(c => c.Name);
                        break;
                    case "Abrv":
                        queryable = queryable.OrderBy(c => c.Abrv);
                        break;
                    case "abrv_desc":
                        queryable = queryable.OrderByDescending(c => c.Abrv);
                        break;
                    default:
                        queryable = queryable.OrderBy(c => c.Name);
                        break;
                }

                var vehicleMakes = await queryable.ToPagedListAsync(pageNumber, arrange.PageSize);
                var vehicleMakesPaged = vehicleMakes.ToMappedPagedList<VehicleMake, VehicleMakeDTO>();

                return vehicleMakesPaged;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public virtual async Task<int> DeleteAsync(IVehicleMakeDTO vehicleMakePoco)
        {
            try
            {
                var vehicleMake = Mapper.Map<VehicleMake>(vehicleMakePoco);
                await _unitOfWork.DeleteAsync<VehicleMake>(vehicleMake);
                return await _unitOfWork.CommitAsync();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public virtual async Task<IVehicleMakeDTO> GetByIdAsync(int id)
        {
            try
            {
                var vehicleMake = await _repository.GetByIdAsync<VehicleMake>(id);
                var vehicleMakePoco = Mapper.Map<VehicleMakeDTO>(vehicleMake);
                return vehicleMakePoco;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public virtual async Task<int> InsertAsync(IVehicleMakeDTO vehicleMakePoco)
        {
            try
            {
                var vehicleMake = Mapper.Map<VehicleMake>(vehicleMakePoco);
                await _unitOfWork.AddAsync<VehicleMake>(vehicleMake);
                return await _unitOfWork.CommitAsync();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public virtual async Task<int> UpdateAsync(IVehicleMakeDTO vehicleMakePoco)
        {
            try
            {
                var vehicleMake = Mapper.Map<VehicleMake>(vehicleMakePoco);
                await _unitOfWork.UpdateAsync<VehicleMake>(vehicleMake);
                return await _unitOfWork.CommitAsync();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public virtual async Task<IEnumerable<IVehicleMakeDTO>> GetAllAsync()
        {
            try
            {
                var vehicleMakes = await _repository.Get<VehicleMake>().ToListAsync();
                var vehicleMakesPoco = Mapper.Map<IEnumerable<VehicleMakeDTO>>(vehicleMakes);
                return vehicleMakesPoco;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }

}
