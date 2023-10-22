using Abp.Application.Services;
using IdeasPrj.Ideas.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdeasPrj.Ideas
{
    public interface IIdeasCommentAppService:IAsyncCrudAppService<IdeasCommentOutputDto,
                                                      int,
                                                      GetAllIdeasCommentFilterDto,
                                                      IdeasCommentInputDto,
                                                      IdeasCommentInputDto>
    {
    }
}
