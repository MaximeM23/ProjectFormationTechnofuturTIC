using DTO.Models;
using DTO.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.Interface
{
    public interface ICommandService: IInsertService<Command>, IGetOneService<DetailsCommand>, IGetAllService<Command>
    {
    }
}
