using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using IdeasPrj.Ideas.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdeasPrj.Ideas
{
    public class IdeasCommentAppService : AsyncCrudAppService<IdeasComment,
                                                         IdeasCommentOutputDto,
                                                         int,
                                                         GetAllIdeasCommentFilterDto,
                                                         IdeasCommentInputDto,
                                                         IdeasCommentInputDto>, IIdeasCommentAppService
    {
        private readonly IRepository<IdeasComment, int> _ideasCommentRepository;
        public IdeasCommentAppService(IRepository<IdeasComment, int> repository) : base(repository)
        {
            _ideasCommentRepository = repository;
        }

        public override Task<IdeasCommentOutputDto> CreateAsync(IdeasCommentInputDto input)
        {
            return base.CreateAsync(input);
        }

        public override Task DeleteAsync(EntityDto<int> input)
        {
            return base.DeleteAsync(input);
        }

        public override Task<PagedResultDto<IdeasCommentOutputDto>> GetAllAsync(GetAllIdeasCommentFilterDto input)
        {
            return base.GetAllAsync(input);
        }

        public override Task<IdeasCommentOutputDto> GetAsync(EntityDto<int> input)
        {
            return base.GetAsync(input);
        }

        public override Task<IdeasCommentOutputDto> UpdateAsync(IdeasCommentInputDto input)
        {
            return base.UpdateAsync(input);
        }
    }
}
