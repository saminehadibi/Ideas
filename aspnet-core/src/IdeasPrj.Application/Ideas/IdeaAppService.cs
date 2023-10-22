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
    public class IdeaAppService : AsyncCrudAppService<Idea,
                                                         IdeaOutputDto,
                                                         int,
                                                         GetAllIdeaFilterDto,
                                                         IdeaInputDto,
                                                         IdeaInputDto>, IIdeaAppService
    {
        private readonly IRepository<Idea, int> _ideaRepository;
        public IdeaAppService(IRepository<Idea, int> repository) : base(repository)
        {
            _ideaRepository = repository;
        }

        public override Task<IdeaOutputDto> CreateAsync(IdeaInputDto input)
        {
            return base.CreateAsync(input);
        }

        public override Task DeleteAsync(EntityDto<int> input)
        {
            return base.DeleteAsync(input);
        }

        public override Task<PagedResultDto<IdeaOutputDto>> GetAllAsync(GetAllIdeaFilterDto input)
        {
            return base.GetAllAsync(input);
        }

        public override Task<IdeaOutputDto> UpdateAsync(IdeaInputDto input)
        {
            return base.UpdateAsync(input);
        }
    }
}
